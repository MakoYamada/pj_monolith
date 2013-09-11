Imports CommonLib
Imports AppLib
Partial Public Class Login
    Inherits WebBase

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
        CmnModule.SetIme(Me.TOPTOUR_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TOPTOUR_PW, CmnModule.ImeType.Disabled)

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

        If Not CmnCheck.IsInput(Me.TOPTOUR_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(WebConfig.Login.C_TOPTOUR_ID), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.TOPTOUR_PW) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(WebConfig.Login.C_TOPTOUR_PW), Me)
            Return False
        End If

        '定義ファイルチェック
        If Trim(Me.TOPTOUR_ID.Text) = WebConfig.Login.TOPTOUR_ID AndAlso _
           Trim(Me.TOPTOUR_PW.Text) = WebConfig.Login.TOPTOUR_PW Then
            Session.Item(SessionDef.LoginID) = WebConfig.Login.TOPTOUR_ID
            Session.Item(SessionDef.UserType) = AppConst.UserType.Admin
        Else
            '一致しない場合、エラー
            CmnModule.AlertMessage(MessageDef.Error.Login, Me)
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
