Imports AppLib
Imports CommonLib
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.Encoding
Imports System.Configuration
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "OutputTaxiDaicho" 'バッチID
    Private Const pDelimiter As String = ","
    Private MS_CODE() As TableDef.MS_CODE.DataStruct
    Private TBL_TAXIDAICHO() As TableDef.TBL_TAXIDAICHO.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()
        Call DaichoMain()
    End Sub

    'タクチケ台帳出力処理
    Private Sub DaichoMain()
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        'タクチケ台帳出力対象データ取得
        strSQL = SQL.TBL_TAXIDAICHO.GetOutputData
        RsData = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_TAXIDAICHO(wCnt)
            TBL_TAXIDAICHO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXIDAICHO(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "タクチケ台帳出力対象データがありません。")
        End If

        'タクチケ台帳CSV出力→ファイル保存
        Call TaxiMeisaiCsv()

        'タクチケ台帳出力対象データ 台帳出力済フラグ・ファイル名更新
        UpdateOutputFlag()

        MyBase.BeginTransaction()

    End Sub

    Private Sub TaxiMeisaiCsv()

        'コードマスターデータ取得
        If Not GetMstData() Then Exit Sub

        'タクチケ台帳出力
        For i As Integer = LBound(TBL_TAXIDAICHO) To UBound(TBL_TAXIDAICHO)

            Dim wNow As String = Now.ToString("yyyyMMddHHmmss")
            Dim strFileName As String = TBL_TAXIDAICHO(i).KOUENKAI_NO & ".csv"
            Dim strFileFull As String = My.Settings.PATH_WORK & "\" & strFileName
            Dim wCsvStr As String = ""
            Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
            CsvData = GetCsvData(TBL_TAXIDAICHO(i).KOUENKAI_NO)

            If File.Exists(strFileFull) Then
                File.Delete(strFileFull)
            End If

            If Not CsvData Is Nothing Then
                wCsvStr = CreateCsv(CsvData)

                '出力ファイル作成
                Dim sw As New StreamWriter(strFileFull, False, System.Text.Encoding.GetEncoding("shift_jis"))
                Try
                    sw.NewLine = vbCrLf
                    sw.Write(wCsvStr)
                Catch ex As Exception
                    'エラー
                    InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[ファイル出力失敗]" & ex.Message)
                    MyBase.SendAlertMail("[ファイル出力失敗]" & ex.Message)
                Finally
                    sw.Flush()
                    sw.Close()
                    sw = Nothing
                End Try

                'タクチケ台帳CSV保存テーブル登録
                Dim W_FILE As New TableDef.TBL_FILE.DataStruct
                Call GetValueFile(strFileFull, strFileName, W_FILE, AppConst.FILE_KBN.Code.TaxiMeisai)
                If CsvUpload(W_FILE) Then
                    'サーバフォルダ内に生成したPDFを削除
                    System.IO.File.Delete(strFileFull)
                End If

                TBL_TAXIDAICHO(i).FILE_NAME = strFileName
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "【" & TBL_TAXIDAICHO(i).KOUENKAI_NO & "】" & CsvData.Length.ToString & "件のデータを出力しました。")
            End If
        Next
    End Sub
    'データ取得
    Private Function GetCsvData(ByVal KOUENKAI_NO As String) As TableDef.TaxiMeisaiCsv.DataStruct()
        Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct
        Dim TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        '会合情報
        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(KOUENKAI_NO)
        RsData = CmnDbBatch.Read(strSQL, Me.DbConnection, MyBase.DbTransaction)
        If RsData.HasRows = False Then
            Return Nothing
        Else
            RsData.Read()
            TBL_KOUENKAI = AppModule.SetRsData(RsData, TBL_KOUENKAI)
        End If
        RsData.Close()

        'タクチケ情報
        Joken.KOUENKAI_NO = KOUENKAI_NO
        Joken.FROM_DATE = ""
        Joken.TKT_ENTA = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.ALL
        strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiMeisaiCsv(Joken)
        RsData = CmnDbBatch.Read(strSQL, Me.DbConnection, MyBase.DbTransaction)
        ReDim TBL_TAXITICKET_HAKKO(wCnt)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
            TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        'csv用データにセット
        wCnt = 0
        ReDim CsvData(wCnt)
        If wFlag = False Then
            CsvData(wCnt).KOUENKAI_NO = ""
        Else
            For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
                ReDim Preserve CsvData(wCnt)
                CsvData(wCnt).KOUENKAI_NAME = TBL_KOUENKAI.KOUENKAI_NAME
                CsvData(wCnt).WBS_ELEMENT_KOUENKAI = TBL_KOUENKAI.WBS_ELEMENT
                CsvData(wCnt).KIKAKU_TANTO_JIGYOUBU = TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU
                CsvData(wCnt).KIKAKU_TANTO_AREA = TBL_KOUENKAI.KIKAKU_TANTO_AREA
                CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO = TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO
                CsvData(wCnt).KIKAKU_TANTO_NAME = TBL_KOUENKAI.KIKAKU_TANTO_NAME
                CsvData(wCnt).KOUENKAI_NO = TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO
                CsvData(wCnt).STATUS = GetName_STATUS(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)
                CsvData(wCnt).TKT_KENSHU = GetNameTKT_KENSHU(TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU)
                CsvData(wCnt).TKT_NO = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                CsvData(wCnt).TKT_LINE_NO = TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO
                CsvData(wCnt).TKT_URIAGE = TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE
                CsvData(wCnt).TKT_ENTA = TBL_TAXITICKET_HAKKO(wCnt).TKT_ENTA
                CsvData(wCnt).TKT_HAKKO_FEE = TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE
                CsvData(wCnt).TKT_SEISAN_FEE = TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE
                CsvData(wCnt).TOTAL_KINGAKU = CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE).ToString
                CsvData(wCnt).TKT_SEIKYU_YM = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, CmnModule.DateFormatType.YYYYMM)
                CsvData(wCnt).TKT_VOID = GetName_VOID(TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)
                CsvData(wCnt).TKT_MIKETSU = GetName_TKT_MIKETSU(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_MIKETSU)
                CsvData(wCnt).SANKASHA_ID = TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID
                CsvData(wCnt).FROM_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)
                CsvData(wCnt).TKT_USED_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD)
                CsvData(wCnt).TKT_HATUTI = TBL_TAXITICKET_HAKKO(wCnt).TKT_HATUTI
                CsvData(wCnt).TKT_CHAKUTI = TBL_TAXITICKET_HAKKO(wCnt).TKT_CHAKUTI
                CsvData(wCnt).TKT_KAISHA = TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA
            Next wCnt
        End If

        '手配情報
        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
            If Trim(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID) <> "" AndAlso Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO) <> 0 Then
                strSQL = SQL.TBL_KOTSUHOTEL.byTKT_NO_TKT_LINE_NO(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID, TBL_TAXITICKET_HAKKO(wCnt).TKT_NO, TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                RsData = CmnDbBatch.Read(strSQL, Me.DbConnection, MyBase.DbTransaction)
                If RsData.HasRows Then
                    RsData.Read()
                    TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)

                    Select Case CInt(CsvData(wCnt).TKT_LINE_NO).ToString
                        Case "1"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_1
                        Case "2"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_2
                        Case "3"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_3
                        Case "4"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_4
                        Case "5"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_5
                        Case "6"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_6
                        Case "7"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_7
                        Case "8"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_8
                        Case "9"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_9
                        Case "10"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_10
                        Case "11"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_11
                        Case "12"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_12
                        Case "13"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_13
                        Case "14"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_14
                        Case "15"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_15
                        Case "16"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_16
                        Case "17"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_17
                        Case "18"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_18
                        Case "19"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_19
                        Case "20"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_20
                    End Select
                    CsvData(wCnt).ANS_TAXI_DATE = CmnModule.Format_Date(CsvData(wCnt).ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
                    CsvData(wCnt).DR_SHISETSU_NAME = TBL_KOTSUHOTEL.DR_SHISETSU_NAME
                    CsvData(wCnt).DR_NAME = TBL_KOTSUHOTEL.DR_NAME
                    CsvData(wCnt).DR_SANKA = GetName_DR_SANKA(TBL_KOTSUHOTEL.DR_SANKA)
                    CsvData(wCnt).DR_CD = TBL_KOTSUHOTEL.DR_CD
                    'CsvData(wCnt).ACCOUNT_CD = TBL_KOTSUHOTEL.ACCOUNT_CD
                    CsvData(wCnt).KIHON_COST_CENTER = TBL_KOUENKAI.COST_CENTER
                    CsvData(wCnt).ACCOUNT_CD = TBL_KOUENKAI.ACCOUNT_CD_TF
                    CsvData(wCnt).KOTSU_COST_CENTER = TBL_KOTSUHOTEL.COST_CENTER
                    CsvData(wCnt).INTERNAL_ORDER = TBL_KOUENKAI.INTERNAL_ORDER_TF
                    CsvData(wCnt).ZETIA_CD = TBL_KOUENKAI.ZETIA_CD
                    CsvData(wCnt).MR_BU = TBL_KOTSUHOTEL.MR_BU
                    CsvData(wCnt).MR_AREA = TBL_KOTSUHOTEL.MR_AREA
                    CsvData(wCnt).MR_EIGYOSHO = TBL_KOTSUHOTEL.MR_EIGYOSHO
                    CsvData(wCnt).MR_NAME = TBL_KOTSUHOTEL.MR_NAME
                    CsvData(wCnt).DR_YAKUWARI = GetName_DR_YAKUWARI(TBL_KOTSUHOTEL.DR_YAKUWARI)
                    CsvData(wCnt).WBS_ELEMENT = AppModule.GetName_WBS_ELEMENT(TBL_KOTSUHOTEL.WBS_ELEMENT)
                    CsvData(wCnt).REQ_TAXI_NOTE = AppModule.GetName_REQ_TAXI_NOTE(TBL_KOTSUHOTEL.REQ_TAXI_NOTE)
                    CsvData(wCnt).ANS_TAXI_NOTE = AppModule.GetName_ANS_TAXI_NOTE(TBL_KOTSUHOTEL.ANS_TAXI_NOTE)
                End If
                RsData.Close()
            End If
        Next wCnt

        Return CsvData
    End Function

    Private Function GetNameTKT_KENSHU(ByVal TKT_KENSHU As String) As String
        If Not CmnCheck.IsNumberOnly(TKT_KENSHU) Then
            Return Mid(Trim(TKT_KENSHU), 3, 10)
        Else
            Return Trim(TKT_KENSHU)
        End If
    End Function
    Private Function GetName_TKT_MIKETSU(ByVal TKT_SEIKYU_YM As String, ByVal TKT_MIKETSU As String) As String
        If Trim(TKT_SEIKYU_YM) = "" AndAlso Trim(TKT_MIKETSU) = AppConst.TAXITICKET_HAKKO.TKT_MIKETSU.Code.Kanou Then
            Return "○"
        Else
            Return ""
        End If
    End Function
    Private Function GetName_DR_SANKA(ByVal DR_SANKA As String) As String
        If Trim(DR_SANKA) = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
            Return "出席"
        ElseIf Trim(DR_SANKA) = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
            Return "欠席"
        Else
            Return "出欠未照合"
        End If
    End Function
    Private Function GetName_STATUS(ByVal TKT_SEIKYU_YM As String, ByVal TKT_VOID As String) As String
        If Trim(TKT_SEIKYU_YM) <> "" Then
            Return "請求済"
        ElseIf Trim(TKT_VOID) <> CmnConst.Flag.Off Then
            Return "破棄済"
        Else
            Return "未請求"
        End If
    End Function
    Private Function GetName_XXX(ByVal ANS_TAXI_DATE As String, ByVal TKT_USERD_DATE As String) As String
        If Trim(ANS_TAXI_DATE) = "" OrElse Trim(TKT_USERD_DATE) = "" Then
            Return ""
        Else
            If Trim(ANS_TAXI_DATE) <> Trim(TKT_USERD_DATE) Then
                Return "請求対象外"
            Else
                Return "請求対象"
            End If
        End If
    End Function
    Private Function GetName_VOID(ByVal TKT_VOID As String) As String
        If Trim(TKT_VOID) = CmnConst.Flag.On Then
            Return "VOID"
        Else
            Return ""
        End If
    End Function

    '参加者役割
    Private Function GetName_DR_YAKUWARI(ByVal DR_YAKUWARI As String) As String
        Dim wStr As String = ""
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.DR_YAKUWARI AndAlso MS_CODE(wCnt).DISP_VALUE = DR_YAKUWARI Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    Private Function GetMstData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        ReDim MS_CODE(wCnt)
        strSQL = SQL.MS_CODE.AllData
        RsData = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True

            ReDim Preserve MS_CODE(wCnt)
            MS_CODE(wCnt) = AppModule.SetRsData(RsData, MS_CODE(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'csv出力
    Private Function CreateCsv(ByVal CsvData() As TableDef.TaxiMeisaiCsv.DataStruct) As String
        Dim wCnt As Integer = 0
        Dim sb As New System.Text.StringBuilder

        '表題
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG No")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ステータス")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種(金額)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("売上金額")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行手数料")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求額")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算月")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合参加者Id")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開始日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日(依頼)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用年月日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("AccountCode(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当のCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("WBS Element(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合のZetia Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRエリア名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR営業所")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code(課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ会社")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実績発地")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実績着地")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算コメント")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケTTT備考")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(依頼)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(回答)"), True))
        sb.Append(vbNewLine)

        '明細
        For wCnt = LBound(CsvData) To UBound(CsvData)
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SANKA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).STATUS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_URIAGE))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_ENTA)))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_HAKKO_FEE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_SEISAN_FEE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TOTAL_KINGAKU))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_SEIKYU_YM))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_VOID))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_YAKUWARI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_JIGYOUBU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).FROM_DATE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).ANS_TAXI_DATE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_USED_DATE))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KAISHA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_HATUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_CHAKUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_SRMKS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_TAXI_NOTE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE)))
            sb.Append(vbNewLine)
        Next wCnt

        Return sb.ToString
    End Function

    '書類テーブル用データセット
    Private Sub GetValueShorui(ByVal pFileName As String, ByVal pFullPath As String, ByRef pFILE As TableDef.TBL_FILE.DataStruct)
        Dim sysDT As String = Now.ToString("yyyyMMddHHmmss")

        If Not pFileName Is Nothing AndAlso pFileName.ToString.Trim <> "" Then
            pFILE.FILE_KBN = AppConst.FILE_KBN.Code.SougouSeisan
            pFILE.FILE_NAME = pFileName
            pFILE.FILE_TYPE = "application/pdf"
            Dim aryData() As Byte = System.IO.File.ReadAllBytes(pFullPath)
            pFILE.DATUME = aryData
            pFILE.INS_DATE = sysDT
            pFILE.INS_PGM = Me.batchID
        End If
    End Sub

    '書類テーブル登録
    Private Function ShoruiUpload(ByVal pFILE As TableDef.TBL_FILE.DataStruct) As Boolean
        If Not DeleteTBL_FILE(pFILE) Then Return False
        If Not InsertTBL_FILE(pFILE) Then Return False

        Return True
    End Function

    'タクチケ台帳 ファイル保存テーブル用データセット
    Private Sub GetValueFile(ByVal pFileFull As String, ByVal pFileName As String, ByRef pFILE As TableDef.TBL_FILE.DataStruct, ByVal pMode As String)
        Dim sysDT As String = Now.ToString("yyyyMMddHHmmss")

        If Not pFileName Is Nothing AndAlso pFileName.ToString.Trim <> "" Then
            pFILE.FILE_KBN = pMode
            pFILE.FILE_NAME = pFileName
            pFILE.FILE_TYPE = "Application/octet-stream"
            Dim aryData() As Byte = System.IO.File.ReadAllBytes(pFileFull)
            pFILE.DATUME = aryData
            pFILE.INS_DATE = sysDT
            pFILE.INS_PGM = Me.batchID
        End If
    End Sub

    '書類テーブル登録
    Private Function CsvUpload(ByVal pFILE As TableDef.TBL_FILE.DataStruct) As Boolean
        If Not DeleteTBL_FILE(pFILE) Then Return False
        If Not InsertTBL_FILE(pFILE) Then Return False

        Return True
    End Function
    Private Function InsertTBL_FILE(ByVal pTBL_FILE As TableDef.TBL_FILE.DataStruct) As Boolean
        Dim strSQL As String = ""
        strSQL &= "INSERT INTO TBL_FILE"
        strSQL &= "(" & TableDef.TBL_FILE.Column.FILE_KBN
        strSQL &= "," & TableDef.TBL_FILE.Column.FILE_NAME
        strSQL &= "," & TableDef.TBL_FILE.Column.FILE_TYPE
        strSQL &= "," & TableDef.TBL_FILE.Column.DATUME
        strSQL &= "," & TableDef.TBL_FILE.Column.INS_DATE
        strSQL &= "," & TableDef.TBL_FILE.Column.INS_PGM
        strSQL &= ") VALUES "
        strSQL &= "(@" & TableDef.TBL_FILE.Column.FILE_KBN
        strSQL &= ",@" & TableDef.TBL_FILE.Column.FILE_NAME
        strSQL &= ",@" & TableDef.TBL_FILE.Column.FILE_TYPE
        strSQL &= ",@" & TableDef.TBL_FILE.Column.DATUME
        strSQL &= ",@" & TableDef.TBL_FILE.Column.INS_DATE
        strSQL &= ",@" & TableDef.TBL_FILE.Column.INS_PGM
        strSQL &= ")"

        ' データの登録
        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        Try
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_KBN, pTBL_FILE.FILE_KBN)
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_NAME, pTBL_FILE.FILE_NAME)
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_TYPE, pTBL_FILE.FILE_TYPE)
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.DATUME, pTBL_FILE.DATUME)
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.INS_DATE, pTBL_FILE.INS_DATE)
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.INS_PGM, pTBL_FILE.INS_PGM)
            objCom.ExecuteNonQuery()
            objCom.Dispose()
        Catch ex As Exception
            objCom.Dispose()
            Return False
        End Try
        Return True
    End Function
    Private Function DeleteTBL_FILE(ByVal pTBL_FILE As TableDef.TBL_FILE.DataStruct) As Boolean
        Dim strSQL As String = ""

        Try
            strSQL = "DELETE FROM TBL_FILE WHERE FILE_NAME='" & pTBL_FILE.FILE_NAME & "'"

            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As New TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "交通新着CSV"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub
    Private Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_TAXIDAICHO As TableDef.TBL_TAXIDAICHO.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_TAXIDAICHO.KOUENKAI_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Private Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        TBL_LOG = GetValue_TBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message)

        Dim strSQL As String

        Try
            strSQL = SQL.TBL_LOG.Insert(TBL_LOG)
            CmnDb.Execute(strSQL, DbConn, MyBase.DbTransaction, True)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function GetValue_TBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                            ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct, _
                                            ByVal STATUS_OK As Boolean, _
                                            ByVal Message As String) As TableDef.TBL_LOG.DataStruct

        TBL_LOG.INPUT_DATE = CmnModule.GetSysDateTime()
        TBL_LOG.INPUT_USER = Me.batchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.GAMEN

        'テーブル名
        If TBL_LOG.TABLE_NAME = "" Then
            Select Case GamenType
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist
                    TBL_LOG.TABLE_NAME = "TBL_KOUENKAI"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KaijoRegist
                    TBL_LOG.TABLE_NAME = "TBL_KAIJO"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.DrRegist
                    TBL_LOG.TABLE_NAME = "TBL_KOTSUHOTEL"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist
                    TBL_LOG.TABLE_NAME = "TBL_TAXIDAICHO"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.CostRegist
                    TBL_LOG.TABLE_NAME = "TBL_COST"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu
                    TBL_LOG.TABLE_NAME = "MS_SHISETSU"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstUser
                    TBL_LOG.TABLE_NAME = "MS_USER"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode
                    TBL_LOG.TABLE_NAME = "MS_CODE"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCostcenter
                    TBL_LOG.TABLE_NAME = "MS_COSTCENTER"
                Case Else
                    TBL_LOG.TABLE_NAME = ""
            End Select
        End If

        If STATUS_OK = True Then
            TBL_LOG.STATUS = AppConst.TBL_LOG.STATUS.Code.OK
            If Trim(Message) <> "" Then
                TBL_LOG.NOTE = Trim(Message)
            End If
        Else
            TBL_LOG.STATUS = AppConst.TBL_LOG.STATUS.Code.NG
            If Trim(TBL_LOG.NOTE) <> "" Then TBL_LOG.NOTE &= "　"

            Dim wStr As String = ""
            If InStr(Message, "    SQL：") > 0 Then
                wStr = Mid(Message, 1, InStr(Message, "    SQL："))
            Else
                wStr = Message
            End If
            TBL_LOG.NOTE &= wStr
        End If

        Return TBL_LOG
    End Function

    'タクチケ台帳出力対象テーブル　出力対象フラグセット
    Private Sub UpdateOutputFlag()

        Dim strSQL As String = ""

        For i As Integer = LBound(TBL_TAXIDAICHO) To UBound(TBL_TAXIDAICHO)
            Try
                TBL_TAXIDAICHO(i).UPDATE_USER = MyBase.batchID
                TBL_TAXIDAICHO(i).OUTPUT_FLAG = CmnConst.Flag.On
                strSQL = SQL.TBL_TAXIDAICHO.Update(TBL_TAXIDAICHO(i))
                Call CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            Catch ex As Exception
                'ログテーブルに登録
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_TAXIDAICHO", " SQL:" & strSQL)
            End Try
        Next

    End Sub
End Class
