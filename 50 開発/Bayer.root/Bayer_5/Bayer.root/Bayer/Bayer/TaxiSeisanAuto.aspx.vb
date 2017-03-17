Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiSeisanAuto
    Inherits WebBase

    Private Const COL_COUNT As Integer = 13 'ファイルの項目数
    Private Const pDelimiter As String = ","
    Private SEISAN_TESURYO As String = "0"
    Private HAKKO_TESURYO As String = "0"
    Private TBL_SEISAN_TKTNO As TableDef.TBL_SEISAN_TKTNO.DataStruct = Nothing

    Private Enum COL_NO
        TKT_KAISHA = 0
        TKT_NO
        TKT_KENSHU
        KOUENKAI_NO
        SANKASHA_ID
        TKT_LINE_NO
        TKT_USED_DATE
        TKT_HATUTI
        TKT_CHAKUTI
        TKT_URIAGE
        TKT_SEISAN_FEE
        TKT_HAKKO_FEE
        TKT_ENTA
    End Enum

    Private Class COL_NAME
        Public Const TKT_KAISHA As String = "タクシー会社"
        Public Const TKT_NO As String = "タクシーチケット番号"
        Public Const TKT_KENSHU As String = "券種"
        Public Const KOUENKAI_NO As String = "会合番号"
        Public Const SANKASHA_ID As String = "参加者ID"
        Public Const TKT_LINE_NO As String = "交通手配タクチケ行番号"
        Public Const TKT_USED_DATE As String = "利用日"
        Public Const TKT_HATUTI As String = "実車発地"
        Public Const TKT_CHAKUTI As String = "実車着地"
        Public Const TKT_URIAGE As String = "売上金額"
        Public Const TKT_SEISAN_FEE As String = "精算手数料"
        Public Const TKT_HAKKO_FEE As String = "発行手数料"
        Public Const TKT_ENTA As String = "エンタ"
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
            .PageTitle = "タクチケ自動精算指示"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定        CmnModule.SetIme(Me.SEISAN_YM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISAN_DANTAI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISAN_COMMENT, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[データ作成予約]
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
            CmnModule.AlertMessage("実績データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルをタクチケTBLへImport
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

        Me.LabelErrorMessage.Text &= (insCnt * -1).ToString & "件のデータを登録しました。" & vbNewLine

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

    'ファイル読み込み
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
                    If Not CheckExists(fileData) Then
                        '自動精算対象タクチケテーブル追加
                        insCnt += UpdateTable(fileData, strFileName, rowCnt, ErrorMessage)
                    Else
                        '自動精算対象タクチケテーブル更新
                        insCnt += UpdateTable(fileData, strFileName, rowCnt, ErrorMessage)
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
        If Not CmnCheck.IsInput(Me.SEISAN_YM) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_SEISAN_TKTNO.Name.SEISAN_YM), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.SEISAN_YM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_YM), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthEQ(Me.SEISAN_YM, Me.SEISAN_YM.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthEQ(TableDef.TBL_SEIKYU.Name.SEISAN_YM, Me.SEISAN_YM.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsValidDateYMD(Me.SEISAN_YM.Text & "01") Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.TBL_SEIKYU.Name.SEISAN_YM), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.SEISAN_DANTAI) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_SEIKYU.Name.SEISAN_DANTAI), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.SEISAN_DANTAI) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_DANTAI), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthEQ(Me.SEISAN_DANTAI, Me.SEISAN_DANTAI.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthEQ(TableDef.TBL_SEIKYU.Name.SEISAN_DANTAI, Me.SEISAN_DANTAI.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.SEISAN_COMMENT, Me.SEISAN_COMMENT.MaxLength * 2) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.SEISAN_KANRYO, Me.SEISAN_COMMENT.MaxLength * 2, True), Me)
            SetFocus(Me.SEISAN_COMMENT)
            Return False
        End If

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

            If fileData(COL_NO.TKT_NO).Trim.Equals(String.Empty) Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_NO & "がセットされていません。" & vbNewLine
            End If

            If fileData(COL_NO.TKT_ENTA).Trim = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.SeisanFuka Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_ENTA & "が｢N｣のため、取込できません。" & vbNewLine
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

    Private Function CheckExists(ByVal filedata As String()) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_SEISAN_TKTNO.byTKT_NO(filedata(COL_NO.TKT_NO))
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_SEISAN_TKTNO = AppModule.SetRsData(RsData, TBL_SEISAN_TKTNO)
        End If
        RsData.Close()

        Return wFlag
    End Function

    'データ登録
    Private Function InsertTable(ByVal fileData As String(), ByVal strFileName As String, ByVal rowCnt As Long, ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_SEISAN_TKTNO As TableDef.TBL_SEISAN_TKTNO.DataStruct = Nothing

        TBL_SEISAN_TKTNO = SetItem(fileData)
        Try
            strSQL = SQL.TBL_SEISAN_TKTNO.Insert(TBL_SEISAN_TKTNO)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[データ取込失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function
    Private Function UpdateTable(ByVal fileData As String(), ByVal strFileName As String, ByVal rowCnt As Long, ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_SEISAN_TKTNO As TableDef.TBL_SEISAN_TKTNO.DataStruct = Nothing

        TBL_SEISAN_TKTNO = SetItem(fileData)
        Try
            strSQL = SQL.TBL_SEISAN_TKTNO.Update(TBL_SEISAN_TKTNO)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[データ取込失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '精算用CSV→タクチケ発行テーブル項目セット
    Private Function SetItem(ByVal filedata() As String) As TableDef.TBL_SEISAN_TKTNO.DataStruct

        TBL_SEISAN_TKTNO.TKT_NO = filedata(COL_NO.TKT_NO)
        TBL_SEISAN_TKTNO.KOUENKAI_NO = filedata(COL_NO.KOUENKAI_NO)
        TBL_SEISAN_TKTNO.SEISAN_YM = Me.SEISAN_YM.Text
        TBL_SEISAN_TKTNO.SEISAN_DANTAI = Me.SEISAN_DANTAI.Text
        TBL_SEISAN_TKTNO.SEISAN_COMMENT = Me.SEISAN_COMMENT.Text
        TBL_SEISAN_TKTNO.INS_USER = Session.Item(SessionDef.LoginID)

        Return TBL_SEISAN_TKTNO
    End Function
End Class
