Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiSeisanToNozomi
    Inherits WebBase

    Private Const COL_COUNT As Integer = 3 'ファイルの項目数
    Private Const pDelimiter As String = ","
    Private SEISAN_TESURYO As String = "0"
    Private HAKKO_TESURYO As String = "0"
    Private TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct = Nothing

    Private Enum COL_NO
        SEQ_NO = 0
        KOUENKAI_NO
        SEIKYU_NO_TOPTOUR
    End Enum

    Private Class COL_NAME
        Public Const SEQ_NO As String = "連番"
        Public Const KOUENKAI_NO As String = "会合番号"
        Public Const SEIKYU_NO_TOPTOUR As String = "精算番号"
    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "Nozomi送信対象精算番号取込"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[取込開始]
    Private Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTorikomi.Click
        Me.LabelErrorMessage.Text = ""
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV_BK))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("Nozomi送信対象精算番号データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルを請求TBLへImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            CmnModule.AlertMessage("取込対象CSVファイルが存在しません。", Me)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV) & FileUpload1.FileName
        ImportData(filePath, insCnt)

        Me.LabelErrorMessage.Text &= (insCnt * -1).ToString & "件の精算番号をNozomi送信対象として登録しました。" & vbNewLine

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.SEISAN_AUTO_CSV) & Path.GetFileNameWithoutExtension(filePath) _
                                                                    & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
        End Try
        File.Delete(filePath)
    End Sub

    'ファイル読み込み→テーブル保存
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("SHIFT-JIS"))
        Else
            Me.LabelErrorMessage.Text &= strFilePath & "が見つかりません。" & vbNewLine
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        'ダブルクォート囲み、ダブルクォートのエスケープ対応
        parser.HasFieldsEnclosedInQuotes = True

        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント
        Dim ErrorMessage As String = String.Empty

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            '1行目はタイトル行のため読み飛ばす
            If rowCnt > 1 Then
                If CheckInput(fileData, strFileName, rowCnt.ToString, ErrorMessage) Then

                    '請求データ存在チェック
                    Dim updCnt As Integer = 0
                    If GetSeikyu(fileData(COL_NO.KOUENKAI_NO), fileData(COL_NO.SEIKYU_NO_TOPTOUR).PadLeft(14, "0")) Then
                        '自動精算対象タクチケテーブルデータ項目セット()
                        TBL_SEIKYU = SetSeikyuItem(fileData)
                        updCnt = UpdateSeikyu(ErrorMessage)
                    Else
                        Me.LabelErrorMessage.Text &= "講演会番号：" & fileData(COL_NO.KOUENKAI_NO) & "  精算番号：" & fileData(COL_NO.SEIKYU_NO_TOPTOUR) _
                            & "は請求テーブルに登録されていません"
                    End If

                End If
            End If
        End While

        'インスタンス開放
        parser.Dispose()

        If Trim(ErrorMessage) <> "" Then
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Me.TrError.Visible = False
            Me.TrEnd.Visible = True
            Me.LabelUpdatedCount.Text = (rowCnt - 1).ToString
            Return True
        End If

    End Function

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '必須入力
        If Me.FileUpload1.FileName.Trim = String.Empty Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("取込むタクチケ自動精算用CSV"), Me)
            Return False
        End If
        Return True
    End Function

    'CSVデータ内容チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, ByRef ErrorMessage As String) As Boolean
        Dim ErrStr As String = ""

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            End If

            If fileData(COL_NO.KOUENKAI_NO).Trim.Equals(String.Empty) Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.KOUENKAI_NO & "がセットされていません。" & vbNewLine
            End If

            If fileData(COL_NO.SEIKYU_NO_TOPTOUR).Trim.Equals(String.Empty) Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.SEIKYU_NO_TOPTOUR & "がセットされていません。" & vbNewLine
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            Return False
        End Try

        If Trim(ErrStr) <> "" Then
            ErrorMessage &= ErrStr
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Return True
        End If

    End Function

    '送信対象CSV→請求データの送信フラグセット
    Private Function SetSeikyuItem(ByVal filedata() As String) As TableDef.TBL_SEIKYU.DataStruct

        TBL_SEIKYU.SEND_FLAG = AppConst.SEND_FLAG.Code.Taisho

        Return TBL_SEIKYU
    End Function

    Private Function UpdateSeikyu(ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0

        Try
            strSQL = SQL.TBL_SEIKYU.Update_SEND_FLAG(TBL_SEIKYU)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[請求テーブル送信フラグ更新失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '請求データ取得
    Private Function GetSeikyu(ByVal KOUENKAI_NO As String, ByVal SEIKYU_NO_TOPTOUR As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(KOUENKAI_NO, SEIKYU_NO_TOPTOUR)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_SEIKYU = AppModule.SetRsData(RsData, TBL_SEIKYU)
        End If
        RsData.Close()

        Return wFlag
    End Function
End Class
