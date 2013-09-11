Imports CommonLib
Imports AppLib
Partial Public Class Login
    Inherits WebBase

    Private MS_USER As TableDef.ms_user.struct

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MS_USER) = MS_USER
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session.Abandon()

            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .HideMenu = True
            .HideLoginUser = True
            .HideLogout = True
            .PageTitle = "ログイン"
        End With
    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定
        CmnModule.SetIme(Me.LOGIN_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.PASSWORD, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
    End Sub

    '入力値チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.LOGIN_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.LOGIN_ID), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.PASSWORD) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.PASSWORD), Me)
            Return False
        End If

        'ユーザマスタ
        Dim strSQL As String = SQL.MS_USER.Login(Trim(Me.LOGIN_ID.Text), Trim(Me.PASSWORD.Text))
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        MS_USER = Nothing

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            MS_USER = AppModule.SetRsData(RsData, MS_USER)
        End If
        RsData.Close()

        '該当データがない場合はエラー
        If wFlag = False Then
            'CmnModule.AlertMessage(MessageDef, Me)
            Return False
        End If

        Return True
    End Function

    '[ログイン]
    Protected Sub BtnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        '入力値チェック
        If Not Check() Then Exit Sub

        'メニューへ
        Response.Redirect(URL.Menu)
    End Sub

End Class
