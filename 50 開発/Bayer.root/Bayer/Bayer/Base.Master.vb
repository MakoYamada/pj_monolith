Imports CommonLib
Imports AppLib
Partial Public Class Base
    Inherits System.Web.UI.MasterPage

    '変数定義
    Private pHideMenu As Boolean
    Private pHideLogout As Boolean
    Private pHideLoginUser As Boolean
    Private pPageTitle As String

    'プロパティ
    Public Property HideMenu() As Boolean
        Get
            Return pHideMenu
        End Get
        Set(ByVal value As Boolean)
            pHideMenu = value
        End Set
    End Property
    Public Property HideLogout() As Boolean
        Get
            Return pHideLogout
        End Get
        Set(ByVal value As Boolean)
            pHideLogout = value
        End Set
    End Property
    Public Property HideLoginUser() As Boolean
        Get
            Return pHideLoginUser
        End Get
        Set(ByVal value As Boolean)
            pHideLoginUser = value
        End Set
    End Property
    Public Property PageTitle() As String
        Get
            Return pPageTitle
        End Get
        Set(ByVal value As String)
            pPageTitle = value
        End Set
    End Property

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '画面項目 表示
        SetForm()
    End Sub

    '画面表示
    Private Sub SetForm()
        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        Me.ImgSiteName.ImageUrl = "~/Images/logo.png"
        'Me.TdHeader1.Style(CmnConst.Html.Style.BackgroundImage) = "url('" & VirtualPathUtility.ToAbsolute("~/Images/bgheader.png") & "')"
        'Me.TrPageTitle.Style(CmnConst.Html.Style.BackgroundImage) = "url('" & VirtualPathUtility.ToAbsolute("~/Images/bgtitle.png") & "')"

        If Trim(Session.Item(SessionDef.LoginID)) = "" Then
            pHideLogout = True
            pHideLoginUser = True
        End If

        '[メニューへ]
        If pHideMenu = True Then
            Me.SpnMenu.Visible = False
        Else
            Me.SpnMenu.Visible = True
        End If

        '[ログアウト]
        If pHideLogout = True Then
            pHideLogout = True
            Me.SpnLogout.Visible = False
        Else
            Me.SpnLogout.Visible = True
        End If

        'ログインユーザ名
        If pHideLoginUser = True Then
            Me.TblLoginUser.Visible = False
        Else
            Dim MS_USER As TableDef.MS_USER.DataStruct
            Try
                MS_USER = Session.Item(SessionDef.LoginUser)
            Catch ex As Exception
                Response.Redirect(URL.TimeOut)
            End Try

            Me.TblLoginUser.Visible = True
            Me.LabelLoginUser.Text = MS_USER.LOGIN_ID & "：" & MS_USER.USER_NAME & " 様"
        End If

        'ページタイトル
        Me.LabelPageTitle.Text = pPageTitle
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '[メニューへ]
    Protected Sub LnkBMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBMenu.Click
        Response.Redirect(URL.Menu)
    End Sub

End Class
