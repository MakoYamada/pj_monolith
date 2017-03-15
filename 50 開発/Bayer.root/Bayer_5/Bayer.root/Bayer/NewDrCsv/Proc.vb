Imports AppLib
Imports CommonLib
Imports System.IO
Imports System.Data.SqlClient
Imports System.Text
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "NewDrCsv" 'バッチID
    Private Const pDelimiter As String = ","

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()
        Call OutputDrCsv()
    End Sub

    '新着交通・宿泊一覧CSV出力
    Private Sub OutputDrCsv()

        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct = GetDrCsvData()

        If TBL_KOTSUHOTEL Is Nothing Then
            '対象データなし
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象データがありません。")
            Exit Sub
        Else
            ExportData(TBL_KOTSUHOTEL)
        End If
    End Sub

    '新着交通・宿泊CSV用データ取得
    Private Function GetDrCsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct()
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim wFlag As Boolean = False

        Dim csvJoken As TableDef.Joken.DataStruct
        Dim TBL_KOTSUHOTEL(wCnt) As TableDef.TBL_KOTSUHOTEL.DataStruct

        strSQL = SQL.TBL_KOTSUHOTEL.NewDrCsv(csvJoken, True)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KOTSUHOTEL(wCnt)

            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_KOTSUHOTEL
        Else
            Return Nothing
        End If
    End Function

    Private Sub ExportData(ByVal outputData() As TableDef.TBL_KOTSUHOTEL.DataStruct)

        Dim wNow As String = Now.ToString("yyyyMMddHHmmss")
        Dim strFileFull As String = My.Settings.PATH_WORK & "\" & My.Settings.FILE_NAME & wNow & ".csv"
        Dim strFileName As String = My.Settings.FILE_NAME & wNow & ".csv"

        'ファイル作成
        If Not NewDrCsv(strFileFull, outputData) Then
            'エラー
            If File.Exists(strFileFull) Then
                File.Delete(strFileFull)
            End If
            Exit Sub
        End If

        '新着一覧CSV保存テーブル登録
        Dim W_FILE As New TableDef.TBL_FILE.DataStruct
        Call GetValueFile(strFileFull, strFileName, W_FILE)
        If CsvUpload(W_FILE) Then
            'サーバフォルダ内に生成したPDFを削除
            ' ''System.IO.File.Delete(strFileFull)
        End If

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, outputData.Length.ToString & "件のデータを出力しました。")

    End Sub

    '新着一覧CSV保存テーブル用データセット
    Private Sub GetValueFile(ByVal pFileFull As String, ByVal pFileName As String, ByRef pFILE As TableDef.TBL_FILE.DataStruct)
        Dim sysDT As String = Now.ToString("yyyyMMddHHmmss")

        If Not pFileName Is Nothing AndAlso pFileName.ToString.Trim <> "" Then
            pFILE.FILE_NAME = pFileName
            'pFILE.FILE_TYPE = "text/csv"
            pFILE.FILE_TYPE = "Application/octet-stream"
            Dim aryData() As Byte = System.IO.File.ReadAllBytes(pFileFull)
            pFILE.DATUME = aryData
            pFILE.INS_DATE = sysDT
            pFILE.INS_PGM = "NewDrCsv"
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
        strSQL &= "(" & TableDef.TBL_FILE.Column.FILE_NAME
        strSQL &= "," & TableDef.TBL_FILE.Column.FILE_TYPE
        strSQL &= "," & TableDef.TBL_FILE.Column.DATUME
        strSQL &= "," & TableDef.TBL_FILE.Column.INS_DATE
        strSQL &= "," & TableDef.TBL_FILE.Column.INS_PGM
        strSQL &= ") VALUES "
        strSQL &= "(@" & TableDef.TBL_FILE.Column.FILE_NAME
        strSQL &= ",@" & TableDef.TBL_FILE.Column.FILE_TYPE
        strSQL &= ",@" & TableDef.TBL_FILE.Column.DATUME
        strSQL &= ",@" & TableDef.TBL_FILE.Column.INS_DATE
        strSQL &= ",@" & TableDef.TBL_FILE.Column.INS_PGM
        strSQL &= ")"

        ' データの登録
        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        Try
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

            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction, True)
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

End Class
