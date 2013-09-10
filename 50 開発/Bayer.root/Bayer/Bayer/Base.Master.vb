Imports CommonLib
Imports AppLib
Partial Public Class Base
    Inherits System.Web.UI.MasterPage

    '変数定義
    Private pHideHeader As Boolean
    Private pHideDrInfo As Boolean
    Private pHideLogout As Boolean
    Private pHideLoginUser As Boolean
    Private pPageTitle As String

    'プロパティ
    Public Property HideHeader() As Boolean
        Get
            Return pHideHeader
        End Get
        Set(ByVal value As Boolean)
            pHideHeader = value
        End Set
    End Property
    Public Property HideDrInfo() As Boolean
        Get
            Return pHideDrInfo
        End Get
        Set(ByVal value As Boolean)
            pHideDrInfo = value
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
            Response.Redirect(URL.Dr.TimeOut)
        End If

        Me.TdHeader2.Style(CmnConst.Html.Style.BackgroundImage) = "url('" & VirtualPathUtility.ToAbsolute("~/Images/logo.png") & "')"
        Me.TdHeader1.Style(CmnConst.Html.Style.BackgroundImage) = "url('" & VirtualPathUtility.ToAbsolute("~/Images/bgheader.png") & "')"
        Me.TrPageTitle.Style(CmnConst.Html.Style.BackgroundImage) = "url('" & VirtualPathUtility.ToAbsolute("~/Images/bgtitle.png") & "')"

        'ヘッダ表示設定
        If pHideHeader = True Then
            Me.TblHeader1.Visible = False
            Me.TblHeader2.Visible = False
            Me.TblLoginUser.Visible = False
        Else
            Me.TblHeader1.Visible = True
            Me.TblHeader2.Visible = True
            Me.TblLoginUser.Visible = True
        End If

        '[ログイン情報変更へ]
        If pHideDrInfo = True Then
            Me.SpnDrInfo.Visible = False
        Else
            Me.SpnDrInfo.Visible = True
        End If

        '[ログアウト]
        If pHideLogout = True OrElse Trim(Session.Item(SessionDef.LoginID)) = "" Then
            pHideLogout = True
            Me.SpnLogout.Visible = False
        Else
            Me.SpnLogout.Visible = True
            If MyModule.IsPaymentLogin() Then
                Me.LnkBLogout.NavigateUrl = URL.Dr.PaymentLogin
            Else
                Me.LnkBLogout.NavigateUrl = URL.Dr.Top
            End If
        End If

        If Trim(Session.Item(SessionDef.LoginID)) = "" Then
            pHideLoginUser = True
        End If

        If pHideLoginUser = True Then
            Me.TblLoginUser.Visible = False
        Else
            Me.TblLoginUser.Visible = True
            'ログイン者名
            Dim MS_DR As TableDef.MS_DR.DataStruct = Session.Item(SessionDef.MS_DR)
            Me.LabelLoginUser.Text = MS_DR.SHISETSU_NAME & "　" & MS_DR.DR_NAME & " 様"
        End If

        'ページタイトル
        Me.LabelPageTitle.Text = pPageTitle
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '[ログイン情報変更へ]
    Protected Sub LnkBDrInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBDrInfo.Click
        Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update
        Response.Redirect(URL.Dr.DrInfoRegist)
    End Sub

End Class
