Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "NewDrCsv" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    Private Const COL_COUNT As Integer = 3 'ファイルの項目数

    Private Enum COL_NO
        Field1 = 0
        Field2
        Field3
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "講演会番号"
        Public Const Field2 As String = "MTP ID (参加者ID)"
        Public Const Field3 As String = "参加・不参加"
    End Class

#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()
        Call OutputDrCsv()
    End Sub

    '新着交通・宿泊一覧CSV出力
    Private Sub OutputDrCsv()

        Dim strFileWork As String = My.Settings.PATH_WORK & "\" & My.Settings.FILE_NAME & Now.ToString("yyyyMMddHHmmss") & ".csv"

        'ファイル作成
        If Not CreateFile(strFileWork, outputData) Then
            'エラー
            If File.Exists(strFileWork) Then
                File.Delete(strFileWork)
            End If
            Exit Sub
        End If

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, outputData.Length.ToString & "件のデータを出力しました。")

        ''バックアップフォルダへコピー
        'File.Copy(strFileWork, My.Settings.PATH_SEND_BKUP & "\" & Path.GetFileName(strFileWork))

        ''送信フォルダへコピー
        ''ワークフォルダのファイル削除
        'File.Copy(strFileWork, My.Settings.PATH_SEND & "\" & Path.GetFileName(strFileWork))
        'File.Delete(strFileWork)

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetDrCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "NewDrList_" & Now.ToString("yyyyMMddHHmmss") & ".csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.NewDrCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If
    End Sub

    '新着交通・宿泊CSV用データ取得
    Private Function GetDrCsvData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim csvJoken As TableDef.Joken.DataStruct
        strSQL = SQL.TBL_KOTSUHOTEL.NewDrCsv(csvJoken, True)
        'strSQL = SQL.TBL_KOTSUHOTEL.Search(csvJoken, True)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

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

        CmnDbBatch.Execute(Sql.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

End Class
