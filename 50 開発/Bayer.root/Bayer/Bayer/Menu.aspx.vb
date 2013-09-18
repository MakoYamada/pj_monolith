Imports CommonLib
Imports AppLib
Partial Public Class Menu1
    Inherits WebBase

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '共通チェック
        'MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), AppModule.UserType.Admin, Me)

        'セッションを変数に格納
        'If Not SetSession() Then
        '    Response.Redirect(URL.TimeOut)
        'End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            'InitControls()

            ''画面項目表示
            'SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "メインメニュー"
            .HideMenu = True
            .HideLogout = False
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()

        'クリア
        'CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
    End Sub

    ''[参加者一覧]
    'Protected Sub BtnDrList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDrList.Click
    '    Session.Remove(SessionDef.Joken)
    '    Session.Remove(SessionDef.SEQ)
    '    Session.Remove(SessionDef.PageIndex)
    '    Session.Remove(SessionDef.RECORD_KUBUN)

    '    Response.Redirect(URL.)
    'End Sub

    ''[手配管理]
    'Protected Sub BtnDrTehaiList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDrTehaiList.Click
    '    Session.Remove(SessionDef.TBL_DR)
    '    Session.Remove(SessionDef.OldTBL_DR)
    '    Session.Remove(SessionDef.MS_MEMBER)
    '    Session.Remove(SessionDef.MS_DR)
    '    Session.Remove(SessionDef.Search)
    '    Session.Remove(SessionDef.Joken)
    '    Session.Remove(SessionDef.TehaiListJoken)
    '    Session.Remove(SessionDef.TehaiListTicketJoken)
    '    Session.Remove(SessionDef.SEQ)
    '    Session.Remove(SessionDef.PageIndex)
    '    Session.Remove(SessionDef.RECORD_KUBUN)
    '    Session.Item(SessionDef.TehaiListJoken) = ""
    '    Session.Item(SessionDef.TehaiListTicketJoken) = ""

    '    Response.Redirect(URL.Admin.DrTehaiList)
    'End Sub
End Class
