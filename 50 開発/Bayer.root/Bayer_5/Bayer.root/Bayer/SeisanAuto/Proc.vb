Imports AppLib
Imports CommonLib
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Imports System.Text.Encoding
Imports System.Configuration
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Export.Pdf
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "SeisanAuto" 'バッチID
    Private Const pDelimiter As String = ","
    Private MS_CODE() As TableDef.MS_CODE.DataStruct
    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private CSV_TAXI_TICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()
        Call SeisanMain()
    End Sub

    '精算処理
    Private Sub SeisanMain()
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim W_SEISAN_TKTNO() As TableDef.TBL_SEISAN_TKTNO.DataStruct

        '自動精算対象タクチケテーブルデータ取得(対象の会合番号と画面で指示された精算年月等)
        strSQL = SQL.TBL_SEISAN_TKTNO.GrpByKOUENKAI_NO()
        RsData = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve W_SEISAN_TKTNO(wCnt)
            W_SEISAN_TKTNO(wCnt) = AppModule.SetRsData(RsData, W_SEISAN_TKTNO(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "自動精算処理対象データがありません。")
        End If

        'タクチケ発行テーブルに請求番号を登録
        If Not UpdateTaxiData(W_SEISAN_TKTNO) Then Exit Sub

        '請求データにタクチケ関連金額セット＆精算番号表CSV生成
        Dim W_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
        Dim wFilePath As String = ""
        Dim wFileName As String = ""
        'If Not UpdateSeikyu(W_SEIKYU, wFilePath, wFileName) Then Exit Sub

        Dim wCntSeikyu As Integer = 0
        Dim RsSeikyu As System.Data.SqlClient.SqlDataReader

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        wFileName = My.Settings.FILE_BANGOUHYO & Now.ToString("yyyyMMddHHmmss") & ".csv"
        wFilePath = My.Settings.PATH_WORK & "\" & wFileName
        Dim sw As New StreamWriter(wFilePath, False, System.Text.Encoding.GetEncoding("shift_jis"))
        Dim sb As New System.Text.StringBuilder
        sw.NewLine = vbCrLf

        For i As Integer = LBound(CSV_TAXI_TICKET_HAKKO) To UBound(CSV_TAXI_TICKET_HAKKO)
            '精算対象の会合番号+精算番号でタクチケデータの金額を集計
            Dim wJoken As TableDef.Joken.DataStruct
            wJoken.KOUENKAI_NO = CSV_TAXI_TICKET_HAKKO(i).KOUENKAI_NO
            wJoken.SEIKYU_NO_TOPTOUR = CSV_TAXI_TICKET_HAKKO(i).SEIKYU_NO_TOPTOUR
            strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiSeisanAuto(wJoken)
            RsSeikyu = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            If RsSeikyu.Read Then
                Dim W_TAXITICKET_HAKKO As New TableDef.TBL_TAXITICKET_HAKKO.DataStruct
                W_TAXITICKET_HAKKO = AppModule.SetRsData(RsSeikyu, W_TAXITICKET_HAKKO)
                RsSeikyu.Close()

                '請求テーブル更新
                Dim W_SEIKYU2 As New TableDef.TBL_SEIKYU.DataStruct
                Dim W_FROMDATE As String = ""
                If Trim(W_TAXITICKET_HAKKO.FROM_DATE) <> "" Then
                    W_FROMDATE = W_TAXITICKET_HAKKO.FROM_DATE.Substring(0, 4)
                End If
                W_SEIKYU2.KOUENKAI_NO = wJoken.KOUENKAI_NO
                W_SEIKYU2.SEIKYU_NO_TOPTOUR = wJoken.SEIKYU_NO_TOPTOUR
                W_SEIKYU2.TAXI_TF = W_TAXITICKET_HAKKO.TAXI_TF
                W_SEIKYU2.TAXI_T = W_TAXITICKET_HAKKO.TAXI_T
                W_SEIKYU2.TAXI_SEISAN_TF = W_TAXITICKET_HAKKO.TAXI_SEISAN_TF
                W_SEIKYU2.TAXI_SEISAN_T = W_TAXITICKET_HAKKO.TAXI_SEISAN_T
                W_SEIKYU2.TAXI_TICKET_URL = System.Configuration.ConfigurationManager.AppSettings("TaxiTicketURL") _
                                            & W_FROMDATE & "/" _
                                            & W_TAXITICKET_HAKKO.KOUENKAI_NO & System.Configuration.ConfigurationManager.AppSettings("TaxiTicketURL_FileName")
                W_SEIKYU2.UPDATE_USER = Me.batchID
                W_SEIKYU2.FROM_DATE = W_TAXITICKET_HAKKO.FROM_DATE

                '金額計算
                Call CalculateKingaku(W_SEIKYU2)

                strSQL = SQL.TBL_SEIKYU.Update_KINGAKU(W_SEIKYU2)

                Try
                    CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                    ReDim Preserve W_SEIKYU(wCntSeikyu)
                    W_SEIKYU(wCntSeikyu) = W_SEIKYU2
                    wCntSeikyu += 1

                Catch ex As Exception
                    MyBase.Rollback()

                    'ログ登録
                    InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, ex.ToString, MyBase.DbConnection)
                End Try

                '精算番号表CSV出力
                If wCntSeikyu = 1 Then
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("通番")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催年")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金（非課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SRM発注区分")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料（非課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金（課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金（課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金小計")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料小計")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG合計")))
                    sb.Append(vbNewLine)
                End If

                'CSV出力
                Dim wTaxi As Long = Long.Parse(W_TAXITICKET_HAKKO.TAXI_TF) + Long.Parse(W_TAXITICKET_HAKKO.TAXI_T)
                Dim wSeisan As Long = Long.Parse(W_TAXITICKET_HAKKO.TAXI_SEISAN_TF) + Long.Parse(W_TAXITICKET_HAKKO.TAXI_SEISAN_T)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(wCntSeikyu.ToString.PadLeft(4, "0")))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_TAXITICKET_HAKKO.KOUENKAI_NO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_FROMDATE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.Format_Date(W_TAXITICKET_HAKKO.FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_TAXITICKET_HAKKO.KOUENKAI_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_TF)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(AppModule.GetName_SRM_HACYU_KBN(W_TAXITICKET_HAKKO.SRM_HACYU_KBN)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_SEISAN_TF)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_T)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_SEISAN_T)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(wTaxi.ToString)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(wSeisan.ToString)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma((wTaxi + wSeisan).ToString)))))
                sb.Append(vbNewLine)

            Else
                RsSeikyu.Close()
            End If
        Next

        sw.Write(sb.ToString)
        sw.Flush()
        sw.Close()
        sw = Nothing

        MyBase.Commit()

        '精算番号表保存
        Dim W_FILE As New TableDef.TBL_FILE.DataStruct
        Call GetValueFile(wFilePath, wFileName, W_FILE, AppConst.FILE_KBN.Code.TaxiSeisan)
        If Not CsvUpload(W_FILE) Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "精算番号表CSVの保存に失敗しました。")
        End If

        '総合精算書出力
        Call PrintSeisanRegistReport(W_SEIKYU)

        'タクチケ台帳出力対象会合番号CSVファイル生成
        Call TaxiMeisaiCsv(W_SEISAN_TKTNO)

        '自動精算対象タクチケテーブルから処理済みデータ削除
        Call DeleteTBL_SEISAN_TKTNO(W_SEISAN_TKTNO)

        MyBase.BeginTransaction()

    End Sub

    'タクチケ発行テーブルに請求番号を登録
    Private Function UpdateTaxiData(ByVal TBL_SEISAN_TKTNO() As TableDef.TBL_SEISAN_TKTNO.DataStruct) As Boolean

        Dim j As Integer = 0
        CSV_TAXI_TICKET_HAKKO = Nothing

        For i As Integer = LBound(TBL_SEISAN_TKTNO) To UBound(TBL_SEISAN_TKTNO)
            Dim kensakuJoken As TableDef.Joken.DataStruct
            kensakuJoken.KOUENKAI_NO = TBL_SEISAN_TKTNO(i).KOUENKAI_NO
            If CmnDbBatch.IsExist(SQL.TBL_TAXITICKET_HAKKO.TaxiSeisanCsvCheck(kensakuJoken), MyBase.DbConnection, MyBase.DbTransaction) Then
                Try
                    Dim W_SEIKYU As New TableDef.TBL_SEIKYU.DataStruct
                    '請求データ(キー項目と送信フラグのみ)を登録する
                    W_SEIKYU.KOUENKAI_NO = TBL_SEISAN_TKTNO(i).KOUENKAI_NO
                    W_SEIKYU.SEISAN_YM = TBL_SEISAN_TKTNO(i).SEISAN_YM
                    W_SEIKYU.SEISAN_KANRYO = TBL_SEISAN_TKTNO(i).SEISAN_COMMENT
                    W_SEIKYU.SEISAN_DANTAI = TBL_SEISAN_TKTNO(i).SEISAN_DANTAI
                    W_SEIKYU.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
                    W_SEIKYU.INPUT_USER = Me.batchID
                    W_SEIKYU.UPDATE_USER = Me.batchID

                    Dim wRtn As Boolean = True
                    'TOPTOUR請求番号が重複しなくなるまで最大値を取得し続ける
                    Do Until wRtn = False
                        '自動採番
                        W_SEIKYU.SEIKYU_NO_TOPTOUR = GetMaxSEISAN_NO(MyBase.DbConnection)
                        wRtn = CmnDbBatch.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(W_SEIKYU.KOUENKAI_NO, _
                                                                                            W_SEIKYU.SEIKYU_NO_TOPTOUR), _
                                                                                            MyBase.DbConnection, MyBase.DbTransaction)
                    Loop

                    'MyBase.BeginTransaction()

                    Dim strSQL As String = SQL.TBL_SEIKYU.InsertSEIKYU_NO(W_SEIKYU)
                    CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                    '会合番号をキーにタクチケ発行テーブルに請求番号、精算年月を登録(請求番号未設定のデータのみ)
                    Dim updateData As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
                    updateData.KOUENKAI_NO = TBL_SEISAN_TKTNO(i).KOUENKAI_NO
                    updateData.TKT_SEIKYU_YM = TBL_SEISAN_TKTNO(i).SEISAN_YM
                    updateData.SEIKYU_NO_TOPTOUR = W_SEIKYU.SEIKYU_NO_TOPTOUR
                    updateData.UPDATE_USER = Me.batchID
                    strSQL = SQL.TBL_TAXITICKET_HAKKO.Update_SEIKYU_NO_YM(updateData)
                    CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                    'MyBase.Commit()

                    ReDim Preserve CSV_TAXI_TICKET_HAKKO(j)
                    CSV_TAXI_TICKET_HAKKO(j).KOUENKAI_NO = TBL_SEISAN_TKTNO(i).KOUENKAI_NO
                    CSV_TAXI_TICKET_HAKKO(j).SEIKYU_NO_TOPTOUR = W_SEIKYU.SEIKYU_NO_TOPTOUR
                    j += 1

                Catch ex As Exception
                    MyBase.Rollback()

                    'ログ登録
                    InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(0), False, ex.ToString, MyBase.DbConnection)
                End Try
            End If
        Next

        Return True
    End Function

    '請求データにタクチケ関連金額セット
    Private Function UpdateSeikyu(ByRef P_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct, ByRef pFilePath As String, ByRef pFileName As String) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        P_SEIKYU = Nothing

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        pFileName = My.Settings.FILE_BANGOUHYO & Now.ToString("yyyyMMddHHmmss") & ".csv"
        pFilePath = My.Settings.PATH_WORK & "\" & pFileName
        Dim sw As New StreamWriter(pFilePath, False, System.Text.Encoding.GetEncoding("shift_jis"))
        Dim sb As New System.Text.StringBuilder
        sw.NewLine = vbCrLf

        For i As Integer = LBound(CSV_TAXI_TICKET_HAKKO) To UBound(CSV_TAXI_TICKET_HAKKO)
            '精算対象の会合番号+精算番号でタクチケデータの金額を集計
            Dim wJoken As TableDef.Joken.DataStruct
            wJoken.KOUENKAI_NO = CSV_TAXI_TICKET_HAKKO(i).KOUENKAI_NO
            wJoken.SEIKYU_NO_TOPTOUR = CSV_TAXI_TICKET_HAKKO(i).SEIKYU_NO_TOPTOUR
            strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiSeisanAuto(wJoken)
            RsData = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            If RsData.Read Then
                Dim W_TAXITICKET_HAKKO As New TableDef.TBL_TAXITICKET_HAKKO.DataStruct
                W_TAXITICKET_HAKKO = AppModule.SetRsData(RsData, W_TAXITICKET_HAKKO)
                RsData.Close()

                '請求テーブル更新
                Dim W_SEIKYU As New TableDef.TBL_SEIKYU.DataStruct
                Dim W_FROMDATE As String = ""
                If Trim(W_TAXITICKET_HAKKO.FROM_DATE) <> "" Then
                    W_FROMDATE = W_TAXITICKET_HAKKO.FROM_DATE.Substring(0, 4)
                End If
                W_SEIKYU.KOUENKAI_NO = wJoken.KOUENKAI_NO
                W_SEIKYU.SEIKYU_NO_TOPTOUR = wJoken.SEIKYU_NO_TOPTOUR
                W_SEIKYU.TAXI_TF = W_TAXITICKET_HAKKO.TAXI_TF
                W_SEIKYU.TAXI_T = W_TAXITICKET_HAKKO.TAXI_T
                W_SEIKYU.TAXI_SEISAN_TF = W_TAXITICKET_HAKKO.TAXI_SEISAN_TF
                W_SEIKYU.TAXI_SEISAN_T = W_TAXITICKET_HAKKO.TAXI_SEISAN_T
                W_SEIKYU.TAXI_TICKET_URL = System.Configuration.ConfigurationManager.AppSettings("TaxiTicketURL") _
                                            & W_FROMDATE & "/" _
                                            & W_TAXITICKET_HAKKO.KOUENKAI_NO & System.Configuration.ConfigurationManager.AppSettings("TaxiTicketURL_FileName")
                W_SEIKYU.UPDATE_USER = Me.batchID
                W_SEIKYU.FROM_DATE = W_TAXITICKET_HAKKO.FROM_DATE

                '金額計算
                Call CalculateKingaku(W_SEIKYU)

                strSQL = SQL.TBL_SEIKYU.Update_KINGAKU(W_SEIKYU)

                Try
                    CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                    ReDim Preserve P_SEIKYU(wCnt)
                    P_SEIKYU(wCnt) = W_SEIKYU
                    wCnt += 1

                Catch ex As Exception
                    MyBase.Rollback()

                    'ログ登録
                    InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, ex.ToString, MyBase.DbConnection)
                End Try

                '精算番号表CSV出力
                If wCnt = 1 Then
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("通番")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催年")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金（非課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料（非課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料（非課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金（課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金（課税）")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料金小計")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料小計")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG合計")))
                    sb.Append(vbNewLine)
                End If

                'CSV出力
                Dim wTaxi As Long = Long.Parse(W_TAXITICKET_HAKKO.TAXI_TF) + Long.Parse(W_TAXITICKET_HAKKO.TAXI_T)
                Dim wSeisan As Long = Long.Parse(W_TAXITICKET_HAKKO.TAXI_SEISAN_TF) + Long.Parse(W_TAXITICKET_HAKKO.TAXI_SEISAN_T)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(wCnt.ToString.PadLeft(4, "0")))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_TAXITICKET_HAKKO.KOUENKAI_NO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_FROMDATE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.Format_Date(W_TAXITICKET_HAKKO.FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(W_TAXITICKET_HAKKO.KOUENKAI_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_TF)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_SEISAN_TF)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_T)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(W_TAXITICKET_HAKKO.TAXI_SEISAN_T)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(wTaxi.ToString)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma(wSeisan.ToString)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CmnModule.EditComma((wTaxi + wSeisan).ToString)))))
                sb.Append(vbNewLine)

            Else
                RsData.Close()
            End If
        Next

        sw.Write(sb.ToString)
        sw.Flush()
        sw.Close()
        sw = Nothing

        Return True
    End Function

    '精算番号自動採番
    Private Function GetMaxSEISAN_NO(ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wSEISAN_NO As Long = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_SEIKYU.MaxSEISAN_NO()

        RsData = CmnDbBatch.Read(strSQL, DbConn, MyBase.DbTransaction)
        If RsData.Read() Then
            wSEISAN_NO = CmnModule.DbVal(CmnDb.DbData(TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR, RsData))
        End If
        RsData.Close()
        wSEISAN_NO += 1

        Return wSEISAN_NO.ToString.PadLeft(14, "0"c)
    End Function

    '各種金額計算
    Private Sub CalculateKingaku(ByRef P_SEIKYU As TableDef.TBL_SEIKYU.DataStruct)

        Dim wTOTAL_TF As Long = 0
        Dim wTOTAL_T As Long = 0
        Dim wMR_KINGAKU As Long = 0
        Dim wTAXI_ENTA As Long = 0

        Try
            '41120200
            wTOTAL_TF = CmnModule.DbVal_Kingaku(P_SEIKYU.TAXI_TF) + _
                         CmnModule.DbVal_Kingaku(P_SEIKYU.TAXI_SEISAN_TF)

            '41120200
            wTOTAL_T = CmnModule.DbVal_Kingaku(P_SEIKYU.TAXI_T) + _
                        CmnModule.DbVal_Kingaku(P_SEIKYU.TAXI_SEISAN_T)

        Catch ex As Exception
        End Try

        '非課税金額
        P_SEIKYU.KEI_41120200_TF = wTOTAL_TF.ToString
        P_SEIKYU.KEI_TF = wTOTAL_TF.ToString

        '課税金額
        P_SEIKYU.KEI_41120200_T = wTOTAL_T.ToString
        P_SEIKYU.KEI_T = wTOTAL_T.ToString

    End Sub

    '総合精算書印刷
    Private Sub PrintSeisanRegistReport(ByVal P_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct)

        For i As Integer = LBound(P_SEIKYU) To UBound(P_SEIKYU)
            Dim rpt As New SeisanRegistReport
            Dim reportJoken As New TableDef.Joken.DataStruct

            reportJoken.KOUENKAI_NO = P_SEIKYU(i).KOUENKAI_NO
            reportJoken.SEIKYU_NO_TOPTOUR = P_SEIKYU(i).SEIKYU_NO_TOPTOUR
            Dim strSQL As String = SQL.TBL_SEIKYU.Search(reportJoken)

            ' 接続文字列をapp.configファイルから取得
            Dim conn As New SqlConnection
            conn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")
            Dim cmd As New SqlCommand
            cmd.Connection = conn
            cmd.CommandText = strSQL
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim dt As New DataTable
            da.Fill(dt)

            'データ設定
            rpt.DataSource = dt
            rpt.Document.Printer.PrinterName = ""

            'A4縦
            rpt.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
            rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

            '必要に応じマージン設定
            rpt.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
            rpt.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
            rpt.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
            rpt.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

            'レポートを作成
            rpt.Run()

            Dim pdf As New PdfExport
            Dim wFullPath As String = System.IO.Path.Combine(My.Settings.PATH_WORK, reportJoken.KOUENKAI_NO & "_" & reportJoken.SEIKYU_NO_TOPTOUR & ".PDF")
            pdf.Export(rpt.Document, wFullPath)

            '書類テーブル登録            
            Dim W_FILE As New TableDef.TBL_FILE.DataStruct
            Dim wFileName As String = reportJoken.KOUENKAI_NO & "_" & reportJoken.SEIKYU_NO_TOPTOUR & ".PDF"
            Call GetValueShorui(wFileName, wFullPath, W_FILE)
            If ShoruiUpload(W_FILE) Then
                'サーバフォルダ内に生成したPDFを削除
                System.IO.File.Delete(wFullPath)
            End If
        Next
    End Sub

    'タクチケ台帳出力対象会合番号ファイル生成
    Private Sub TaxiMeisaiCsv(ByVal P_SEISAN_TKTNO() As TableDef.TBL_SEISAN_TKTNO.DataStruct)

        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        Dim wFileName As String = My.Settings.FILE_TAXIMEISAI & "_" & Now.ToString("yyyyMMddHHmmss") & ".csv"
        Dim wFilePath As String = My.Settings.PATH_WORK & "\" & wFileName
        Dim sw As New StreamWriter(wFilePath, False, System.Text.Encoding.GetEncoding("shift_jis"))
        Dim sb As New System.Text.StringBuilder
        sw.NewLine = vbCrLf

        '表題
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG No")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日"), True))
        sb.Append(vbNewLine)

        For i As Integer = LBound(P_SEISAN_TKTNO) To UBound(P_SEISAN_TKTNO)
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(P_SEISAN_TKTNO(i).KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(P_SEISAN_TKTNO(i).KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(P_SEISAN_TKTNO(i).FROM_DATE), True))
            sb.Append(vbNewLine)
        Next

        sw.Write(sb.ToString)
        sw.Flush()
        sw.Close()
        sw = Nothing

        Dim W_FILE As New TableDef.TBL_FILE.DataStruct
        Call GetValueFile(wFilePath, wFileName, W_FILE, AppConst.FILE_KBN.Code.TaxiMeisaiTaisho)
        If Not CsvUpload(W_FILE) Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "タクチケ台帳出力対象会合CSVの保存に失敗しました。")
        End If

    End Sub

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

    '精算番号表CSV／タクチケ台帳 ファイル保存テーブル用データセット
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

    '契約書用書類テーブル登録
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

    '自動精算対象タクチケテーブルから処理済みデータ削除
    Private Function DeleteTBL_SEISAN_TKTNO(ByVal pTBL_SEISAN_TKTNO() As TableDef.TBL_SEISAN_TKTNO.DataStruct) As Boolean

        For i As Integer = LBound(pTBL_SEISAN_TKTNO) To UBound(pTBL_SEISAN_TKTNO)
            Dim strSQL As String = ""
            Try
                strSQL = "DELETE FROM TBL_SEISAN_TKTNO WHERE"
                strSQL &= " KOUENKAI_NO='" & pTBL_SEISAN_TKTNO(i).KOUENKAI_NO & "' AND"
                strSQL &= " SEISAN_YM='" & pTBL_SEISAN_TKTNO(i).SEISAN_YM & "'"

                CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
                MyBase.Commit()
            Catch ex As Exception
                Return False
            End Try
        Next
        Return True
    End Function

    '新着交通・宿泊一覧CSV
    Private Function NewDrCsv(ByVal filename As String, ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0

        '出力ファイル作成
        Dim sw As New StreamWriter(filename, False, System.Text.Encoding.GetEncoding("shift_jis"))
        sw.NewLine = vbCrLf

        Try
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.FROM_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TO_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.DR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_SEND_SAKI_FS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_SEND_SAKI_OTHER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TIME_STAMP_BYL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.INPUT_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.USER_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.REQ_STATUS_TEHAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_KOTSU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_TAXI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_MR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KINKYU_FLAG)))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TO_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_FS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_OTHER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).USER_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_STATUS_TEHAI(CsvData(wCnt).REQ_STATUS_TEHAI, False, True))))
                '宿泊
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL))))
                '交通
                If CsvData(wCnt).REQ_O_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No))))
                End If
                'タクチケ
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_TEHAI_TAXI(CsvData(wCnt).TEHAI_TAXI))))
                'MR手配
                If CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                    CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                    CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                    CsvData(wCnt).REQ_MR_HOTEL_NOTE.Trim <> "" OrElse _
                    CsvData(wCnt).ANS_MR_HOTEL_NOTE.Trim <> "" Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No))))
                End If
                '緊急
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_KINKYU_FLAG(CsvData(wCnt).KINKYU_FLAG))))

                sb.Append(vbNewLine)
            Next wCnt

            sw.Write(sb.ToString)

        Catch ex As Exception
            'エラー
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[ファイル出力失敗]" & ex.Message)
            MyBase.SendAlertMail("[ファイル出力失敗]" & ex.Message)
            Return False
        Finally
            sw.Flush()
            sw.Close()
            sw = Nothing
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
                                         ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_SEIKYU.KOUENKAI_NO _
                     & "／" _
                     & "精算番号：" & TBL_SEIKYU.SEIKYU_NO_TOPTOUR

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
                    TBL_LOG.TABLE_NAME = "TBL_SEIKYU"
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
End Class
