Imports AppLib
Imports CommonLib
Imports System.IO

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ExportKotsuHotel" 'バッチID

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        If Not Directory.Exists(My.Settings.PATH_SEND_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_SEND_BKUP)

        '対象データ取得
        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct = GetData()

        If TBL_KOTSUHOTEL Is Nothing Then
            '対象データなし
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象データがありません。")
            Exit Sub
        Else
            ExportData(TBL_KOTSUHOTEL)
        End If

    End Sub

    '対象データを取得
    Private Function GetData() As TableDef.TBL_KOTSUHOTEL.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOTSUHOTEL(wCnt) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.bySEND_FLAG(AppConst.SEND_FLAG.Code.Taisho)
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

    Private Function CreateFile(ByVal fileName As String, ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean

        'コードマスタ取得
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        MS_CODE = GetMsCode()

        '出力ファイル作成
        Dim sw As New StreamWriter(fileName, False, New System.Text.UTF8Encoding(False))
        sw.NewLine = vbCrLf

        Try
            Dim sb As New System.Text.StringBuilder
            For wCnt As Integer = 0 To UBound(CsvData)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SALEFORCE_ID))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUENKAI_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).KOUENKAI_NO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).REQ_STATUS_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_STATUS_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).TIME_STAMP_BYL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).TIME_STAMP_BYL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHONIN_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).SHONIN_DATE))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_STATUS_HOTEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTEL_NAME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTEL_ADDRESS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTEL_TEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTEL_DATE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HAKUSU))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_CHECKIN_TIME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_CHECKOUT_TIME))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_ROOM_TYPE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTEL_SMOKING))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTEL_NOTE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTELHI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_HOTELHI_CANCEL))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_STATUS_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_KOTSUKIKAN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_DATE_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_BIN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_KIBOU1))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_STATUS_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_KOTSUKIKAN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_DATE_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_BIN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_KIBOU2))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_STATUS_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_KOTSUKIKAN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_DATE_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_BIN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_KIBOU3))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_STATUS_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_KOTSUKIKAN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_DATE_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_BIN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_KIBOU4))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_STATUS_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_KOTSUKIKAN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_DATE_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_AIRPORT2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_TIME2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_BIN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_O_SEAT_KIBOU5))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_STATUS_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_KOTSUKIKAN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_DATE_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_BIN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_KIBOU1))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_STATUS_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_KOTSUKIKAN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_DATE_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_BIN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_KIBOU2))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_STATUS_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_KOTSUKIKAN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_DATE_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_BIN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_KIBOU3))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_STATUS_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_KOTSUKIKAN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_DATE_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_BIN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_KIBOU4))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_STATUS_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_KOTSUKIKAN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_DATE_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_AIRPORT2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_TIME2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_BIN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_F_SEAT_KIBOU5))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KOTSU_BIKO))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_RAIL_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_RAIL_CANCELLATION))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_OTHER_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_OTHER_CANCELLATION))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_AIR_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_AIR_CANCELLATION))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_TESURYO))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TICKET_SEND_DAY))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_1))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_2))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_3))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_4))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_5))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_6))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_6))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_6))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_7))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_7))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_7))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_8))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_8))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_8))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_9))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_9))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_9))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_10))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_10))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_10))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_11))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_11))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_11))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_12))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_12))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_12))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_13))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_13))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_13))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_14))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_14))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_14))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_15))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_15))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_15))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_16))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_16))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_16))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_17))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_17))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_17))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_18))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_18))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_18))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_19))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_19))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_19))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_DATE_20))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_KENSHU_20))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NO_20))))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_TAXI_NOTE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(GetName_ANS_MR_O_TEHAI(CsvData(wCnt).ANS_MR_O_TEHAI, MS_CODE)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(GetName_ANS_MR_F_TEHAI(CsvData(wCnt).ANS_MR_F_TEHAI, MS_CODE)))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MR_HOTEL_NOTE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MR_KOTSUHI))))
                sb.Append(CmnCsv.Quotes(CmnCsv.EscapeQuotes(CsvData(wCnt).ANS_MR_HOTELHI)))
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

    'テーブル更新
    Private Sub UpdateData(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct)

        'CSV出力したデータを更新
        For wCnt As Integer = 0 To UBound(CsvData)

            CsvData(wCnt).SEND_FLAG = AppConst.SEND_FLAG.Code.Sumi
            CsvData(wCnt).UPDATE_USER = pbatchID

            Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Update_SEND_FLAG(CsvData(wCnt))
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        Next

    End Sub

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As New TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "交通宿泊手配回答ファイル作成"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

    '社員用往路臨席希望（回答）
    Private Function GetName_ANS_MR_O_TEHAI(ByVal ANS_MR_O_TEHAI As String, ByVal MS_CODE As List(Of TableDef.MS_CODE.DataStruct)) As String
        Select Case ANS_MR_O_TEHAI
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Prepare, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.OK, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Daian, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Canceled, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Fuka, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka

            Case Else
                Return ""
        End Select
    End Function

    '社員用復路臨席希望（回答）
    Private Function GetName_ANS_MR_F_TEHAI(ByVal ANS_MR_F_TEHAI As String, ByVal MS_CODE As List(Of TableDef.MS_CODE.DataStruct)) As String
        Select Case ANS_MR_F_TEHAI
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Prepare, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.OK, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Daian, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Canceled, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Fuka, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka

            Case Else
                Return ""
        End Select
    End Function

    'MS_CODEのデータを取得
    Private Function GetMsCode() As List(Of TableDef.MS_CODE.DataStruct)

        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)

        Dim strSQL As String = SQL.MS_CODE.AllData()
        Dim RsData As System.Data.SqlClient.SqlDataReader

        RsData = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            Dim MS_CODE_Item As New TableDef.MS_CODE.DataStruct
            With MS_CODE_Item
                .CODE = CmnDb.DbData(TableDef.MS_CODE.Column.CODE, RsData)
                .DATA_ID = CmnDb.DbData(TableDef.MS_CODE.Column.DATA_ID, RsData)
                .DISP_VALUE = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
                .DISP_TEXT = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData)
            End With
            MS_CODE.Add(MS_CODE_Item)
        End While
        RsData.Close()

        Return MS_CODE
    End Function
End Class
