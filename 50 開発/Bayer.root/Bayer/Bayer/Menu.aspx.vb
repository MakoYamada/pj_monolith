Imports CommonLib
Imports AppLib
Partial Public Class Menu1
    Inherits WebBase

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

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

    'セッションを変数に格納    Private Function SetSession() As Boolean
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

    '[新着：会場手配]
    Protected Sub BtnNewKaijoList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewKaijoList.Click
        Session.Remove(SessionDef.Joken)
        Session.Remove(SessionDef.TBL_KOUENKAI)
        Session.Remove(SessionDef.TBL_KAIJO)
        Session.Remove(SessionDef.SEQ)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS1)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS2)
        Session.Remove(SessionDef.ShisetsuKensaku_SHISETSU_NAME)
        Session.Remove(SessionDef.ShisetsuKensaku_SHISETSU_KANA)
        Session.Remove(SessionDef.ShisetsuKensaku_ZIP)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS)
        Session.Remove(SessionDef.ShisetsuKensaku_TEL)
        Session.Remove(SessionDef.ShisetsuKensaku_URL)
        Response.Redirect(URL.NewKaijoList)
    End Sub

    '[検索：会場手配]
    Protected Sub BtnKaijoList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaijoList.Click
        Session.Remove(SessionDef.Joken)
        Session.Remove(SessionDef.TBL_KOUENKAI)
        Session.Remove(SessionDef.TBL_KAIJO)
        Session.Remove(SessionDef.SEQ)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS1)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS2)
        Session.Remove(SessionDef.ShisetsuKensaku_SHISETSU_NAME)
        Session.Remove(SessionDef.ShisetsuKensaku_SHISETSU_KANA)
        Session.Remove(SessionDef.ShisetsuKensaku_ZIP)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS)
        Session.Remove(SessionDef.ShisetsuKensaku_TEL)
        Session.Remove(SessionDef.ShisetsuKensaku_URL)
        Response.Redirect(URL.KaijoList)
    End Sub

    '[ユーザマスタ]
    Protected Sub BtnUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnUser.Click
        Session.Remove(SessionDef.Joken)
        Session.Remove(SessionDef.MS_USER)
        Session.Remove(SessionDef.SEQ)
        Session.Remove(SessionDef.SYSTEM_ID)
        Response.Redirect(URL.MstUser)
    End Sub

    '[施設マスタ]
    Protected Sub BtnShisetsu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnShisetsu.Click
        Session.Remove(SessionDef.Joken)
        Session.Remove(SessionDef.MS_SHISETSU)
        Session.Remove(SessionDef.SEQ)
        Session.Remove(SessionDef.SYSTEM_ID)
        Response.Redirect(URL.MstShisetsu)
    End Sub

    '[新着 講演会基本情報一覧]
    Private Sub BtnNewKoenkaiList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewKoenkaiList.Click
        Session.Remove(SessionDef.Joken)
        Session.Remove(SessionDef.TBL_KOUENKAI)
        Session.Remove(SessionDef.SEQ)
        Session.Remove(SessionDef.SYSTEM_ID)
        Session.Remove(SessionDef.KouenkaiRireki)
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)
        Session.Remove(SessionDef.KouenkaiRireki_TBL_KOUENKAI)
        Response.Redirect(URL.NewKouenkaiList)
    End Sub

    '[検索 講演会基本情報一覧]
    Private Sub BtnKoenkaiList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKoenkaiList.Click
        Session.Remove(SessionDef.Joken)
        Session.Remove(SessionDef.TBL_KOUENKAI)
        Session.Remove(SessionDef.TBL_KAIJO)
        Session.Remove(SessionDef.SEQ)
        Session.Remove(SessionDef.HotelKensaku_ADDRESS)
        Session.Remove(SessionDef.HotelKensaku_ADDRESS1)
        Session.Remove(SessionDef.HotelKensaku_ADDRESS2)
        Session.Remove(SessionDef.HotelKensaku_Back)
        Session.Remove(SessionDef.KouenkaiRireki)
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)
        Session.Remove(SessionDef.KouenkaiRireki_TBL_KOUENKAI)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS1)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS2)
        Session.Remove(SessionDef.ShisetsuKensaku_SHISETSU_NAME)
        Session.Remove(SessionDef.ShisetsuKensaku_SHISETSU_KANA)
        Session.Remove(SessionDef.ShisetsuKensaku_ZIP)
        Session.Remove(SessionDef.ShisetsuKensaku_ADDRESS)
        Session.Remove(SessionDef.ShisetsuKensaku_TEL)
        Session.Remove(SessionDef.ShisetsuKensaku_URL)
        Response.Redirect(URL.KouenkaiList)
    End Sub

    '[送受信ログ照会]
    Protected Sub BtnTorikomiLog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTorikomiLog.Click

    End Sub

End Class
