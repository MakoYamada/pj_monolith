Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportSeisan" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    Private Const COL_COUNT As Integer = 5 'ファイルの項目数

    Private Enum COL_NO
        Field1 = 0
        Field2
        Field3
        Field4
        Field5
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "講演会番号"
        Public Const Field2 As String = "支払番号"
        Public Const Field3 As String = "TOP請求書番号"
        Public Const Field4 As String = "承認区分"
        Public Const Field5 As String = "精算承認日"
    End Class

#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        Try
            '受信フォルダの処理対象ファイル名を保持する
            Dim receiveFiles() As String = Directory.GetFiles(My.Settings.PATH_RECEIVE)

            'コピー先フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
            If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
            If Not Directory.Exists(My.Settings.PATH_RECEIVE_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_RECEIVE_BKUP)

            '作業フォルダを空にする'2013/11/05Add
            Dim workFiles() As String = Directory.GetFiles(My.Settings.PATH_WORK)
            For Each workFile As String In workFiles
                File.Delete(workFile)
            Next

            '受信フォルダ→作業フォルダへコピー
            '受信フォルダ→バックアップフォルダへコピー
            For Each motofile As String In receiveFiles
                If motofile.ToLower.IndexOf(My.Settings.FILE_NAME.ToLower) >= 0 Then
                    File.Copy(motofile, My.Settings.PATH_WORK & "\" & Path.GetFileName(motofile))

                    Try
                        File.Copy(motofile, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileName(motofile))
                    Catch ex As Exception
                        '同名ファイルが存在した場合は、ファイル名にyyyyMMddHHmmssを付加
                        File.Copy(motofile, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileNameWithoutExtension(motofile) _
                                                                                & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(motofile))
                    End Try
                End If
            Next

            workFiles = Directory.GetFiles(My.Settings.PATH_WORK)
            If workFiles.Length = 0 Then
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象ファイルがありません。")
                Exit Sub
            End If

            Dim updCnt As Integer = 0  '取込み件数カウント
            For Each filePath As String In workFiles
                'データ取り込み
                ImportData(filePath, updCnt)
            Next

            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, updCnt.ToString & "件のデータを更新しました。")

            '作業フォルダからファイルを削除
            For Each filePath As String In workFiles
                File.Delete(filePath)
            Next

            '受信フォルダからファイルを削除
            For Each motofile As String In receiveFiles
                If motofile.ToLower.IndexOf(My.Settings.FILE_NAME.ToLower) >= 0 Then
                    File.Delete(motofile)
                End If
            Next

        Catch ex As Exception
            'ログファイル出力(想定外のエラー発生時はここでログファイルに書き込む)
            MyBase.WriteInfoLog(ex.Message)
        End Try

    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef updCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("UTF-8"))
        Else
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, strFilePath & "が見つかりません。")
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        'ダブルクォート囲み、ダブルクォートのエスケープ対応
        parser.HasFieldsEnclosedInQuotes = True

        Dim strNgMoji As String = My.Settings.NG_MOJI
        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            If CheckInput(fileData, strFileName, rowCnt.ToString, strNgMoji) Then
                updCnt += UpdateTable(fileData, strFileName, rowCnt.ToString)
            End If

        End While

        'インスタンス開放
        parser.Dispose()

    End Function

    '入力チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, _
                                ByVal strNGMoji As String) As Boolean

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                Throw New Exception("項目数が不正です。")
            End If

            '必須入力チェック
            If fileData(COL_NO.Field1).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field1 & "がセットされていません。")
            End If

            If fileData(COL_NO.Field3).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field3 & "がセットされていません。")
            End If

            '禁則文字チェック
            If Not strNGMoji.Equals(String.Empty) Then
                Dim chkMoji() As String = strNGMoji.Split(",")
                For Each colData As String In fileData
                    For Each moji As String In chkMoji
                        If colData.Contains(moji) Then
                            Throw New Exception("禁則文字[" & moji & "]が含まれています。")
                        End If
                    Next
                Next
            End If

        Catch ex As Exception
            Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, strErrMsg)
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
        TBL_LOG.SYORI_NAME = "精算承認結果ファイル取込"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

    'データ更新または新規登録
    Private Function UpdateTable(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String) As Integer

        Dim strSQL As String = ""
        Dim updCnt As Integer = 0
        Dim TBL_SHOUNIN As New TableDef.TBL_SHOUNIN.DataStruct

        Try
            TBL_SHOUNIN.KOUENKAI_NO = fileData(COL_NO.Field1)
            TBL_SHOUNIN.SHIHARAI_NO = fileData(COL_NO.Field2)
            TBL_SHOUNIN.SEIKYU_NO_TOPTOUR = fileData(COL_NO.Field3)
            TBL_SHOUNIN.SHOUNIN_KUBUN = fileData(COL_NO.Field4)
            TBL_SHOUNIN.SHOUNIN_DATE = fileData(COL_NO.Field5)
            TBL_SHOUNIN.UPDATE_USER = pbatchID

            strSQL = SQL.TBL_SHOUNIN.Update(TBL_SHOUNIN)
            updCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            If updCnt = 0 Then
                TBL_SHOUNIN.INPUT_USER = pbatchID

                strSQL = SQL.TBL_SHOUNIN.Insert(TBL_SHOUNIN)
                updCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            End If

        Catch ex As Exception
            'ログテーブルに登録
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_SHOUNIN", " SQL:" & strSQL)
        End Try

        '更新成功件数を返す
        Return updCnt

    End Function

End Class
