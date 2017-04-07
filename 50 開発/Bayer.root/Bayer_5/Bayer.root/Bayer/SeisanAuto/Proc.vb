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
        If Not UpdateSeikyu(W_SEIKYU, wFilePath, wFileName) Then Exit Sub

        MyBase.Commit()

        '精算番号表保存
        Dim W_FILE As New TableDef.TBL_FILE.DataStruct
        Call GetValueFile(wFilePath, wFileName, W_FILE, AppConst.FILE_KBN.Code.TaxiSeisan)
        If Not CsvUpload(W_FILE) Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "精算番号表CSVの保存に失敗しました。")
        End If

        '総合精算書出力
        Call PrintSeisanRegistReport(W_SEIKYU)

        'タクチケ台帳出力対象会合番号ファイル生成
        Call TaxiMeisaiCsv(W_SEISAN_TKTNO)

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
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(P_SEISAN_TKTNO(i).FROM_DATE)))
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

    'Private Sub TaxiMeisaiCsv(ByVal P_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct)

    '    'コードマスターデータ取得
    '    If Not GetMstData() Then Exit Sub

    '    'タクチケ台帳出力
    '    For i As Integer = LBound(P_SEIKYU) To UBound(P_SEIKYU)

    '        Dim wNow As String = Now.ToString("yyyyMMddHHmmss")
    '        Dim strFileName As String = P_SEIKYU(i).FROM_DATE.Substring(0, 6) & "_" & P_SEIKYU(i).KOUENKAI_NO & "_" & wNow & ".csv"
    '        Dim strFileFull As String = My.Settings.PATH_WORK & "\" & strFileName
    '        Dim wCsvStr As String = ""
    '        Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
    '        CsvData = GetCsvData(P_SEIKYU(i).KOUENKAI_NO, P_SEIKYU(i).SEISAN_YM, P_SEIKYU(i).FROM_DATE)

    '        If File.Exists(strFileFull) Then
    '            File.Delete(strFileFull)
    '        End If

    '        If Not CsvData Is Nothing Then
    '            wCsvStr = CreateCsv(CsvData)

    '            '出力ファイル作成
    '            Dim sw As New StreamWriter(strFileFull, False, System.Text.Encoding.GetEncoding("shift_jis"))
    '            Try
    '                sw.NewLine = vbCrLf
    '                sw.Write(wCsvStr)
    '            Catch ex As Exception
    '                'エラー
    '                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[ファイル出力失敗]" & ex.Message)
    '                MyBase.SendAlertMail("[ファイル出力失敗]" & ex.Message)
    '            Finally
    '                sw.Flush()
    '                sw.Close()
    '                sw = Nothing
    '            End Try

    '            'タクチケ台帳CSV保存テーブル登録
    '            Dim W_FILE As New TableDef.TBL_FILE.DataStruct
    '            Call GetValueFile(strFileFull, strFileName, W_FILE, AppConst.FILE_KBN.Code.TaxiMeisai)
    '            If CsvUpload(W_FILE) Then
    '                'サーバフォルダ内に生成したPDFを削除
    '                System.IO.File.Delete(strFileFull)
    '            End If

    '            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, CsvData.Length.ToString & "件のデータを出力しました。")
    '        End If
    '    Next
    'End Sub
    ''データ取得
    'Private Function GetCsvData(ByVal KOUENKAI_NO As String, ByVal TKT_SEIKYU_YM As String, ByVal FROM_DATE As String) As TableDef.TaxiMeisaiCsv.DataStruct()
    '    Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
    '    Dim strSQL As String = ""
    '    Dim RsData As System.Data.SqlClient.SqlDataReader
    '    Dim TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct
    '    Dim TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    '    Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
    '    Dim wCnt As Integer = 0
    '    Dim wFlag As Boolean = False

    '    '会合情報
    '    strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(KOUENKAI_NO)
    '    RsData = CmnDbBatch.Read(strSQL, Me.DbConnection)
    '    If RsData.HasRows = False Then
    '        Return Nothing
    '    Else
    '        RsData.Read()
    '        TBL_KOUENKAI = AppModule.SetRsData(RsData, TBL_KOUENKAI)
    '    End If
    '    RsData.Close()

    '    'タクチケ情報
    '    Joken.KOUENKAI_NO = KOUENKAI_NO
    '    Joken.FROM_DATE = ""
    '    Joken.TKT_ENTA = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.ALL
    '    strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiMeisaiCsv(Joken)
    '    RsData = CmnDbBatch.Read(strSQL, Me.DbConnection)
    '    ReDim TBL_TAXITICKET_HAKKO(wCnt)
    '    While RsData.Read()
    '        wFlag = True
    '        ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
    '        TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO(wCnt))
    '        wCnt += 1
    '    End While
    '    RsData.Close()

    '    'csv用データにセット
    '    wCnt = 0
    '    ReDim CsvData(wCnt)
    '    If wFlag = False Then
    '        CsvData(wCnt).KOUENKAI_NO = ""
    '    Else
    '        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
    '            ReDim Preserve CsvData(wCnt)
    '            CsvData(wCnt).KOUENKAI_NAME = TBL_KOUENKAI.KOUENKAI_NAME
    '            CsvData(wCnt).WBS_ELEMENT_KOUENKAI = TBL_KOUENKAI.WBS_ELEMENT
    '            CsvData(wCnt).KIKAKU_TANTO_JIGYOUBU = TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU
    '            CsvData(wCnt).KIKAKU_TANTO_AREA = TBL_KOUENKAI.KIKAKU_TANTO_AREA
    '            CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO = TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO
    '            CsvData(wCnt).KIKAKU_TANTO_NAME = TBL_KOUENKAI.KIKAKU_TANTO_NAME
    '            CsvData(wCnt).KOUENKAI_NO = TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO
    '            CsvData(wCnt).STATUS = GetName_STATUS(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)
    '            CsvData(wCnt).TKT_KENSHU = GetNameTKT_KENSHU(TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU)
    '            CsvData(wCnt).TKT_NO = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
    '            CsvData(wCnt).TKT_LINE_NO = TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO
    '            CsvData(wCnt).TKT_URIAGE = TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE
    '            CsvData(wCnt).TKT_ENTA = TBL_TAXITICKET_HAKKO(wCnt).TKT_ENTA
    '            CsvData(wCnt).TKT_HAKKO_FEE = TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE
    '            CsvData(wCnt).TKT_SEISAN_FEE = TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE
    '            CsvData(wCnt).TOTAL_KINGAKU = CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE).ToString
    '            CsvData(wCnt).TKT_SEIKYU_YM = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, CmnModule.DateFormatType.YYYYMM)
    '            CsvData(wCnt).TKT_VOID = GetName_VOID(TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)
    '            CsvData(wCnt).TKT_MIKETSU = GetName_TKT_MIKETSU(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_MIKETSU)
    '            CsvData(wCnt).SANKASHA_ID = TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID
    '            CsvData(wCnt).FROM_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)
    '            CsvData(wCnt).TKT_USED_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD)
    '            CsvData(wCnt).TKT_HATUTI = TBL_TAXITICKET_HAKKO(wCnt).TKT_HATUTI
    '            CsvData(wCnt).TKT_CHAKUTI = TBL_TAXITICKET_HAKKO(wCnt).TKT_CHAKUTI
    '            CsvData(wCnt).TKT_KAISHA = TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA
    '        Next wCnt
    '    End If

    '    '手配情報
    '    For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
    '        If Trim(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID) <> "" AndAlso Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO) <> 0 Then
    '            strSQL = SQL.TBL_KOTSUHOTEL.byTKT_NO_TKT_LINE_NO(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID, TBL_TAXITICKET_HAKKO(wCnt).TKT_NO, TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
    '            RsData = CmnDbBatch.Read(strSQL, Me.DbConnection)
    '            If RsData.HasRows Then
    '                RsData.Read()
    '                TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)

    '                Select Case CInt(CsvData(wCnt).TKT_LINE_NO).ToString
    '                    Case "1"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_1
    '                    Case "2"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_2
    '                    Case "3"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_3
    '                    Case "4"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_4
    '                    Case "5"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_5
    '                    Case "6"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_6
    '                    Case "7"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_7
    '                    Case "8"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_8
    '                    Case "9"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_9
    '                    Case "10"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_10
    '                    Case "11"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_11
    '                    Case "12"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_12
    '                    Case "13"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_13
    '                    Case "14"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_14
    '                    Case "15"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_15
    '                    Case "16"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_16
    '                    Case "17"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_17
    '                    Case "18"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_18
    '                    Case "19"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_19
    '                    Case "20"
    '                        CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
    '                        CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20
    '                        CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_20
    '                End Select
    '                CsvData(wCnt).ANS_TAXI_DATE = CmnModule.Format_Date(CsvData(wCnt).ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
    '                CsvData(wCnt).DR_SHISETSU_NAME = TBL_KOTSUHOTEL.DR_SHISETSU_NAME
    '                CsvData(wCnt).DR_NAME = TBL_KOTSUHOTEL.DR_NAME
    '                CsvData(wCnt).DR_SANKA = GetName_DR_SANKA(TBL_KOTSUHOTEL.DR_SANKA)
    '                CsvData(wCnt).DR_CD = TBL_KOTSUHOTEL.DR_CD
    '                'CsvData(wCnt).ACCOUNT_CD = TBL_KOTSUHOTEL.ACCOUNT_CD
    '                CsvData(wCnt).KIHON_COST_CENTER = TBL_KOUENKAI.COST_CENTER
    '                CsvData(wCnt).ACCOUNT_CD = TBL_KOUENKAI.ACCOUNT_CD_TF
    '                CsvData(wCnt).KOTSU_COST_CENTER = TBL_KOTSUHOTEL.COST_CENTER
    '                CsvData(wCnt).INTERNAL_ORDER = TBL_KOUENKAI.INTERNAL_ORDER_TF
    '                CsvData(wCnt).ZETIA_CD = TBL_KOUENKAI.ZETIA_CD
    '                CsvData(wCnt).MR_BU = TBL_KOTSUHOTEL.MR_BU
    '                CsvData(wCnt).MR_AREA = TBL_KOTSUHOTEL.MR_AREA
    '                CsvData(wCnt).MR_EIGYOSHO = TBL_KOTSUHOTEL.MR_EIGYOSHO
    '                CsvData(wCnt).MR_NAME = TBL_KOTSUHOTEL.MR_NAME
    '                CsvData(wCnt).DR_YAKUWARI = GetName_DR_YAKUWARI(TBL_KOTSUHOTEL.DR_YAKUWARI)
    '                CsvData(wCnt).WBS_ELEMENT = AppModule.GetName_WBS_ELEMENT(TBL_KOTSUHOTEL.WBS_ELEMENT)
    '                CsvData(wCnt).REQ_TAXI_NOTE = AppModule.GetName_REQ_TAXI_NOTE(TBL_KOTSUHOTEL.REQ_TAXI_NOTE)
    '                CsvData(wCnt).ANS_TAXI_NOTE = AppModule.GetName_ANS_TAXI_NOTE(TBL_KOTSUHOTEL.ANS_TAXI_NOTE)
    '            End If
    '            RsData.Close()
    '        End If
    '    Next wCnt

    '    Return CsvData
    'End Function

    'Private Function GetNameTKT_KENSHU(ByVal TKT_KENSHU As String) As String
    '    If Not CmnCheck.IsNumberOnly(TKT_KENSHU) Then
    '        Return Mid(Trim(TKT_KENSHU), 3, 10)
    '    Else
    '        Return Trim(TKT_KENSHU)
    '    End If
    'End Function
    'Private Function GetName_TKT_MIKETSU(ByVal TKT_SEIKYU_YM As String, ByVal TKT_MIKETSU As String) As String
    '    If Trim(TKT_SEIKYU_YM) = "" AndAlso Trim(TKT_MIKETSU) = AppConst.TAXITICKET_HAKKO.TKT_MIKETSU.Code.Kanou Then
    '        Return "○"
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Private Function GetName_DR_SANKA(ByVal DR_SANKA As String) As String
    '    If Trim(DR_SANKA) = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
    '        Return "出席"
    '    ElseIf Trim(DR_SANKA) = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
    '        Return "欠席"
    '    Else
    '        Return "出欠未照合"
    '    End If
    'End Function
    'Private Function GetName_STATUS(ByVal TKT_SEIKYU_YM As String, ByVal TKT_VOID As String) As String
    '    If Trim(TKT_SEIKYU_YM) <> "" Then
    '        Return "請求済"
    '    ElseIf Trim(TKT_VOID) <> CmnConst.Flag.Off Then
    '        Return "破棄済"
    '    Else
    '        Return "未請求"
    '    End If
    'End Function
    'Private Function GetName_XXX(ByVal ANS_TAXI_DATE As String, ByVal TKT_USERD_DATE As String) As String
    '    If Trim(ANS_TAXI_DATE) = "" OrElse Trim(TKT_USERD_DATE) = "" Then
    '        Return ""
    '    Else
    '        If Trim(ANS_TAXI_DATE) <> Trim(TKT_USERD_DATE) Then
    '            Return "請求対象外"
    '        Else
    '            Return "請求対象"
    '        End If
    '    End If
    'End Function
    'Private Function GetName_VOID(ByVal TKT_VOID As String) As String
    '    If Trim(TKT_VOID) = CmnConst.Flag.On Then
    '        Return "VOID"
    '    Else
    '        Return ""
    '    End If
    'End Function

    ''参加者役割
    'Private Function GetName_DR_YAKUWARI(ByVal DR_YAKUWARI As String) As String
    '    Dim wStr As String = ""
    '    For wCnt As Integer = 0 To MS_CODE.Count - 1
    '        If MS_CODE(wCnt).CODE = AppConst.MS_CODE.DR_YAKUWARI AndAlso MS_CODE(wCnt).DISP_VALUE = DR_YAKUWARI Then
    '            wStr = MS_CODE(wCnt).DISP_TEXT
    '            Exit For
    '        End If
    '    Next
    '    Return wStr
    'End Function

    'Private Function GetMstData() As Boolean
    '    Dim wFlag As Boolean = False
    '    Dim wCnt As Integer = 0
    '    Dim strSQL As String = ""
    '    Dim RsData As System.Data.SqlClient.SqlDataReader

    '    ReDim MS_CODE(wCnt)
    '    strSQL = SQL.MS_CODE.AllData
    '    RsData = CmnDbBatch.Read(strSQL, MyBase.DbConnection)
    '    While RsData.Read()
    '        wFlag = True

    '        ReDim Preserve MS_CODE(wCnt)
    '        MS_CODE(wCnt) = AppModule.SetRsData(RsData, MS_CODE(wCnt))

    '        wCnt += 1
    '    End While
    '    RsData.Close()

    '    Return wFlag
    'End Function

    ''csv出力
    'Private Function CreateCsv(ByVal CsvData() As TableDef.TaxiMeisaiCsv.DataStruct) As String
    '    Dim wCnt As Integer = 0
    '    Dim sb As New System.Text.StringBuilder

    '    '表題
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG No")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ステータス")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種(金額)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("売上金額")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行手数料")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求額")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算月")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合参加者Id")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開始日")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日(依頼)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用年月日")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("AccountCode(非課税)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当のCost Center")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order(非課税)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("WBS Element(非課税)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合のZetia Code")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR BU")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRエリア名")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR営業所")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR氏名")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code(課税)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ会社")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実績発地")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実績着地")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算コメント")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケTTT備考")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(依頼)")))
    '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(回答)"), True))
    '    sb.Append(vbNewLine)

    '    '明細
    '    For wCnt = LBound(CsvData) To UBound(CsvData)
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SANKA)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).STATUS)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_URIAGE))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_ENTA)))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_HAKKO_FEE))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_SEISAN_FEE))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TOTAL_KINGAKU))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_SEIKYU_YM))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_VOID))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_YAKUWARI)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_JIGYOUBU)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).FROM_DATE))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).ANS_TAXI_DATE))
    '        sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_USED_DATE))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KAISHA)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_HATUTI)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_CHAKUTI)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_SRMKS)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_TAXI_NOTE)))
    '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE)))
    '        sb.Append(vbNewLine)
    '    Next wCnt

    '    Return sb.ToString
    'End Function

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

        ''処理名
        'Select Case GamenType
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KouenkaiRegist
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.DrRegist
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.DrRegist
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KaijoRegist
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KaijoRegist
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.SeisanRegist
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.CostRegist
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.CostRegist
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstShisetsu
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstUser
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstUser
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCode
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCostcenter
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCostcenter
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiNouhinTorikomi
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiPrintCsv
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiScan
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMaintenance
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMaintenance
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJisseki
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJissekiOTH
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJissekiOTH
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiSeisanMikanryou
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiSeisanMikanryou
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMiketsu
        '    Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMeisaiCsv
        '        TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMeisaiCsv
        '    Case Else
        '        TBL_LOG.SYORI_NAME = "画面名 エラー"
        'End Select

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
