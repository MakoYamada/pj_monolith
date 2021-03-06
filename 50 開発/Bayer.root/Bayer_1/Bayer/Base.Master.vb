﻿Imports CommonLib
Imports AppLib
Partial Public Class Base
    Inherits System.Web.UI.MasterPage

    '変数定義
    Private pHideMenu As Boolean
    Private pDispTaxiMenu As Boolean
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
    Public Property DispTaxiMenu() As Boolean
        Get
            Return pDispTaxiMenu
        End Get
        Set(ByVal value As Boolean)
            pDispTaxiMenu = value
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

        If Trim(WebConfig.Site.HeaderComment1) <> "" AndAlso Trim(WebConfig.Site.HeaderComment2) <> "" Then
            Me.HeaderComment1.Text = WebConfig.Site.HeaderComment1
            Me.HeaderComment2.Text = WebConfig.Site.HeaderComment2
            Me.TdHeader2.Visible = True
        Else
            Me.TdHeader2.Visible = False
        End If

        If Trim(Session.Item(SessionDef.LoginID)) = "" Then
            pHideLogout = True
            pHideLoginUser = True
        End If

        '[メニューへ]
        If pHideMenu = True Then
            Me.SpnMenu.Visible = False
        Else
            Me.SpnMenu.Visible = True
            Me.Image1.Style(CmnConst.Html.Style.VerticalAlign) = "middle"
            Me.LnkBMenu.Style(CmnConst.Html.Style.VerticalAlign) = "middle"
        End If

        '[タクシーチケット管理メニューへ]
        If pDispTaxiMenu = False Then
            Me.SpnTaxiMenu.Visible = False
        Else
            Me.SpnTaxiMenu.Visible = True
            Me.Image1.Style(CmnConst.Html.Style.VerticalAlign) = "middle"
            Me.LnkBTaxiMenu.Style(CmnConst.Html.Style.VerticalAlign) = "middle"
        End If

        '[ログアウト]
        If pHideLogout = True Then
            pHideLogout = True
            Me.SpnLogout.Visible = False
        Else
            Me.SpnLogout.Visible = True
            Me.Image2.Style(CmnConst.Html.Style.VerticalAlign) = "middle"
            Me.LnkBLogout.Style(CmnConst.Html.Style.VerticalAlign) = "middle"
        End If

        'ログインユーザ名
        If pHideLoginUser = True Then
            Me.TblLoginUser.Visible = False
        Else
            Dim MS_USER As TableDef.MS_USER.DataStruct
            Try
                MS_USER = Session.Item(SessionDef.MS_USER)
            Catch ex As Exception
                Response.Redirect(URL.TimeOut)
            End Try

            Me.TblLoginUser.Visible = True
            Me.LabelLoginUser.Text = MS_USER.LOGIN_ID & "：" & MS_USER.USER_NAME & " 様"
        End If

        'ページタイトル
        Me.LabelPageTitle.Text = pPageTitle
    End Sub

    'セッションを変数に格納    Private Function SetSession() As Boolean
        Return True
    End Function

    '[メニューへ]
    Protected Sub LnkBMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBMenu.Click
        '不要なセッションを破棄
        MyModule.ClearSession()

        Response.Redirect(URL.Menu)
    End Sub

    '[タクシーチケット管理メニューへ]
    Protected Sub LnkBTaxiMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBTaxiMenu.Click
        '不要なセッションを破棄
        MyModule.ClearSession()

        Response.Redirect(URL.TaxiMenu)
    End Sub

End Class
