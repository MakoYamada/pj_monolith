Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ExportSeisan" 'バッチID

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        If Not Directory.Exists(My.Settings.PATH_SEND_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_SEND_BKUP)

        '対象データ取得
        Dim TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct = GetData()

        If TBL_SEIKYU Is Nothing Then
            '対象データなし
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象データがありません。")
            Exit Sub
        Else
            ExportData(TBL_SEIKYU)
        End If

    End Sub

    '対象データを取得
    Private Function GetData() As TableDef.TBL_SEIKYU.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_SEIKYU(wCnt) As TableDef.TBL_SEIKYU.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_SEIKYU.bySEND_FLAG(AppConst.SEND_FLAG.Code.Taisho)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_SEIKYU(wCnt)

            TBL_SEIKYU(wCnt) = AppModule.SetRsData(RsData, TBL_SEIKYU(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_SEIKYU
        Else
            Return Nothing
        End If

    End Function

    Private Sub ExportData(ByVal outputData() As TableDef.TBL_SEIKYU.DataStruct)

        Dim strFileWork As String = My.Settings.PATH_WORK & "\" & My.Settings.FILE_NAME & Now.ToString("yyyyMMddHHmmss") & ".csv"

        'ファイル作成
        If Not CreateFile(strFileWork, outputData) Then
            'エラー
            If File.Exists(strFileWork) Then
                File.Delete(strFileWork)
            End If
            Exit Sub
        End If

        '送信フラグ更新
        UpdateData(outputData)

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, outputData.Length.ToString & "件のデータを出力しました。")

        'バックアップフォルダへコピー
        File.Copy(strFileWork, My.Settings.PATH_SEND_BKUP & "\" & Path.GetFileName(strFileWork))

        '送信フォルダへコピー
        'ワークフォルダのファイル削除
        File.Copy(strFileWork, My.Settings.PATH_SEND & "\" & Path.GetFileName(strFileWork))
        File.Delete(strFileWork)

    End Sub

    Private Function CreateFile(ByVal fileName As String, ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As Boolean

        '出力ファイル作成
        Dim sw As New StreamWriter(fileName, False, New System.Text.UTF8Encoding(False))
        sw.NewLine = vbCrLf

        Try
            Dim sb As New System.Text.StringBuilder
            For wCnt As Integer = 0 To UBound(CsvData)

                'ファイル出力
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUENKAI_NO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SEISAN_YM))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHOUNIN_KUBUN))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHOUNIN_DATE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).AIR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TRAFFIC_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTEL_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SEISANSHO_URL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).TAXI_TICKET_URL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SEISAN_KANRYO))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_JR)))
                sb.Append(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL))
                sb.Append(vbNewLine)
            Next

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

    'テーブル更新
    Private Sub UpdateData(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct)

        'CSV出力したデータを更新
        For wCnt As Integer = 0 To UBound(CsvData)

            CsvData(wCnt).SEND_FLAG = AppConst.SEND_FLAG.Code.Sumi
            CsvData(wCnt).UPDATE_USER = pbatchID

            Dim strSQL As String = SQL.TBL_SEIKYU.Update_SEND_FLAG(CsvData(wCnt))
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        Next

    End Sub

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As New TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "精算ファイル作成"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

End Class
