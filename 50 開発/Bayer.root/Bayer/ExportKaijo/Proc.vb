Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ExportKaijo" 'バッチID

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        If Not Directory.Exists(My.Settings.PATH_SEND_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_SEND_BKUP)

        '対象データ取得
        Dim TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct = GetData()

        If TBL_KAIJO Is Nothing Then
            '対象データなし
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象データがありません。")
            Exit Sub
        Else
            ExportData(TBL_KAIJO)
        End If

    End Sub

    '対象データを取得
    Private Function GetData() As TableDef.TBL_KAIJO.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KAIJO(wCnt) As TableDef.TBL_KAIJO.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_KAIJO.bySEND_FLAG(AppConst.SEND_FLAG.Code.Taisho)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KAIJO(wCnt)

            TBL_KAIJO(wCnt) = AppModule.SetRsData(RsData, TBL_KAIJO(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_KAIJO
        Else
            Return Nothing
        End If

    End Function

    Private Sub ExportData(ByVal outputData() As TableDef.TBL_KAIJO.DataStruct)

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

    Private Function CreateFile(ByVal fileName As String, ByVal CsvData() As TableDef.TBL_KAIJO.DataStruct) As Boolean

        '出力ファイル作成
        Dim sw As New StreamWriter(fileName, False, New System.Text.UTF8Encoding(False))
        sw.NewLine = vbCrLf

        Try
            Dim sb As New System.Text.StringBuilder
            For wCnt As Integer = 0 To UBound(CsvData)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SALEFORCE_ID))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).TEHAI_ID))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUENKAI_NO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).REQ_STATUS_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_STATUS_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).TIME_STAMP_BYL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).TIME_STAMP_BYL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHONIN_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHONIN_DATE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KAISAI_DATE_NOTE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KAISAI_KIBOU_ADDRESS1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KAISAI_KIBOU_ADDRESS2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KAISAI_KIBOU_NOTE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUEN_TIME1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUEN_TIME2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUEN_KAIJO_LAYOUT))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).IKENKOUKAN_KAIJO_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).IROUKAI_KAIJO_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).IROUKAI_SANKA_YOTEI_CNT))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUSHI_ROOM_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHAIN_ROOM_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).MANAGER_KAIJO_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).OTHER_NOTE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SENTEI_RIYU))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MITSUMORI_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MITSUMORI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MITSUMORI_TOTAL))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MITSUMORI_URL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SHISETSU_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SHISETSU_ZIP))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SHISETSU_ADDRESS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SHISETSU_TEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SHISETSU_URL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KOUEN_KAIJO_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KOUEN_KAIJO_FLOOR))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_IKENKOUKAN_KAIJO_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_IROUKAI_KAIJO_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KOUSHI_ROOM_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_SHAIN_ROOM_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MANAGER_KAIJO_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KAISAI_NOTE))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KAIJOUHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KIZAIHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_INSHOKUHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_991330401_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTELHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KOTSUHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TEHAI_TESURYO_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_HAKKEN_TESURYO_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_SEISAN_TESURYO_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_JINKENHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_OTHER_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KANRIHI_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_41120200_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TOTAL_TF))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KAIJOUHI_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KIZAIHI_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_INSHOKUHI_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_991330401_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_JINKENHI_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_OTHER_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KANRIHI_T))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_41120200_T))))
                sb.Append(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TOTAL_T)))
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
    Private Sub UpdateData(ByVal CsvData() As TableDef.TBL_KAIJO.DataStruct)

        'CSV出力したデータを更新
        For wCnt As Integer = 0 To UBound(CsvData)

            CsvData(wCnt).SEND_FLAG = AppConst.SEND_FLAG.Code.Sumi
            CsvData(wCnt).UPDATE_USER = pbatchID

            Dim strSQL As String = SQL.TBL_KAIJO.Update_SEND_FLAG(CsvData(wCnt))
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        Next

    End Sub

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As New TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "会場手配回答ファイル作成"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

    

End Class
