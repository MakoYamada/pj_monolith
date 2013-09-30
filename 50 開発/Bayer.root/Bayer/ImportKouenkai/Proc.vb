Imports AppLib
Imports CommonLib
Imports System.IO
Imports System.Web 'TEST(System.Web.HttpContext.Current.Session.Item(SessionDbError) = "" でエラー回避のため)

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKouenkai" 'バッチID
    Private Const pDelimiter As String = ","

    Private Const COL_COUNT As Integer = 8 'ファイルの項目数

#Region "ファイル項目"

    'TODO:項目確定次第定義する
    Private Enum COL_NO
        KOUENKAI_NO = 0
        TIME_STAMP
        KOUENKAI_TITLE
    End Enum

    Private Class COL_NAME
        Public Const KOUENKAI_NO As String = "講演会番号"
    End Class
#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        Dim receiveFiles() As String = Directory.GetFiles(My.Settings.PATH_RECEIVE)

        'フォルダが存在しないとエラーになるので注意（念のためフォルダの存在チェックを入れる？）

        '受信フォルダ→作業フォルダへコピー
        '受信フォルダからファイルを削除
        For Each motofile As String In receiveFiles
            If motofile.ToLower.IndexOf(My.Settings.FILE_KOUENKAI.ToLower) >= 0 Then
                File.Copy(motofile, My.Settings.PATH_WORK_KOUENKAI & "\" & Path.GetFileName(motofile))
                File.Delete(motofile)
            End If
        Next

        Dim workFiles() As String = Directory.GetFiles(My.Settings.PATH_WORK_KOUENKAI)
        If workFiles.Length = 0 Then

            '対象ファイルなし
            InsertTBL_LOG("0", "処理対象ファイルがありません。")
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント
        For Each filePath As String In workFiles
            ImportData(filePath, insCnt)
        Next

        MyBase.WriteInfoLog(insCnt.ToString & "件のデータを登録しました。")

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        For Each filePath As String In workFiles
            File.Copy(filePath, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileName(filePath))
            File.Delete(filePath)
        Next

    End Sub

    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("UTF-8"))
        Else
            '対象ファイル無し
            'Throw New Exception(pbatchID & ":" & strFilePath & "が見つかりません。")
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        Dim strNgMoji() As String = My.Settings.NG_MOJI.Split(",")
        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            If CheckInput(fileData, strFileName, rowCnt.ToString, strNgMoji) Then
                insCnt += InsertTable()
            End If

        End While

        'インスタンス開放
        parser.Dispose()

    End Function

    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, _
                                ByVal strNGMoji As String()) As Boolean

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                Throw New Exception("項目数が不正です。")
            End If

            '必須入力チェック
            If fileData(COL_NO.KOUENKAI_NO).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.KOUENKAI_NO & "がセットされていません。")
            End If


            '禁則文字チェック
            For Each colData As String In fileData
                For Each moji As String In strNGMoji
                    If colData.Contains(moji) Then
                        Throw New Exception("禁則文字[" & moji & "]が含まれています。")
                    End If
                Next
            Next

        Catch ex As Exception
            'TODO:ログテーブル書き込み
            Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            Return False
        End Try

        Return True

    End Function

    Private Function InsertTable() As Integer

        '同一キーのデータを検索


        '該当データ0件のとき



    End Function

    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String)

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = "2"
        TBL_LOG.SYORI_NAME = "講演会基本情報ファイル取込"
        TBL_LOG.TABLE_NAME = "TBL_LOG"
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        Dim strSQL As String = SQL.TBL_LOG.Insert(TBL_LOG)
        CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)



        'ログファイル出力
        MyBase.WriteInfoLog(strMsg)

    End Sub

End Class
