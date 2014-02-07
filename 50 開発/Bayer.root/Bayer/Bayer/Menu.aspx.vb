Imports CommonLib
Imports AppLib
Partial Public Class Menu1
    Inherits WebBase

    Private MS_USER As TableDef.MS_USER.DataStruct

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '不要なセッションを破棄
            MyModule.ClearSession()

            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .HideMenu = True
            .PageTitle = "メインメニュー"
        End With

        CmnModule.SetEnabled(Me.BtnNewBentoList, False)
        CmnModule.SetEnabled(Me.BtnBentoList, False)

        ''リリース時
        'CmnModule.SetEnabled(Me.BtnMstCostcenter, False)
        'CmnModule.SetEnabled(Me.BtnTaxiMenu, False)
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            MS_USER = Session.Item(SessionDef.MS_USER)
            If IsNothing(MS_USER) Then Return False
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '画面項目 初期化

    Private Sub InitControls()

        'クリア
        'CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        If MS_USER.KENGEN = AppConst.MS_USER.KENGEN.Code.Admin Then
            CmnModule.SetEnabled(Me.BtnMstUser, True)
            CmnModule.SetEnabled(Me.BtnMstCode, True)
            CmnModule.SetEnabled(Me.BtnMstCostcenter, True)
            CmnModule.SetEnabled(Me.BtnLogFile, True)
            CmnModule.SetEnabled(Me.BtnLogSousa, True)
        Else
            CmnModule.SetEnabled(Me.BtnMstUser, False)
            CmnModule.SetEnabled(Me.BtnMstCode, False)
            CmnModule.SetEnabled(Me.BtnMstCostcenter, False)
            CmnModule.SetEnabled(Me.BtnLogFile, False)
            CmnModule.SetEnabled(Me.BtnLogSousa, False)
        End If
        If MS_USER.KENGEN_SEISAN = AppConst.MS_USER.KENGEN_SEISAN.Code.Yes Then
            CmnModule.SetEnabled(Me.BtnSeisan, True)
            CmnModule.SetEnabled(Me.BtnCost, True)
            CmnModule.SetEnabled(Me.BtnSap, True)
        Else
            CmnModule.SetEnabled(Me.BtnSeisan, False)
            CmnModule.SetEnabled(Me.BtnCost, False)
            CmnModule.SetEnabled(Me.BtnSap, False)
        End If
    End Sub

    '[新着：会場手配]
    Protected Sub BtnNewKaijoList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewKaijoList.Click
        Response.Redirect(URL.NewKaijoList)
    End Sub

    '[検索：会場手配]
    Protected Sub BtnKaijoList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaijoList.Click
        Response.Redirect(URL.KaijoList)
    End Sub

    '[TOP担当者マスタ]
    Protected Sub BtnMstUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMstUser.Click
        Response.Redirect(URL.MstUser)
    End Sub

    '[施設マスタ]
    Protected Sub BtnMstShisetsu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMstShisetsu.Click
        Response.Redirect(URL.MstShisetsu)
    End Sub

    '[コードマスタ]
    Protected Sub BtnMstCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMstCode.Click
        Response.Redirect(URL.MstCode)
    End Sub

    '[新着 会合基本情報一覧]
    Private Sub BtnNewKoenkaiList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewKoenkaiList.Click
        Response.Redirect(URL.NewKouenkaiList)
    End Sub

    '[検索 会合基本情報一覧]
    Private Sub BtnKoenkaiList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKoenkaiList.Click
        Response.Redirect(URL.KouenkaiList)
    End Sub

    '[送受信ログ照会]
    Protected Sub BtnLogFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLogFile.Click
        Dim Joken As TableDef.Joken.DataStruct = Nothing
        Joken.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.LogFile)
    End Sub

    '[操作ログ照会]
    Protected Sub BtnLogSousa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLogSousa.Click
        Dim Joken As TableDef.Joken.DataStruct = Nothing
        Joken.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.GAMEN
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.LogSousa)
    End Sub

    '[新着 交通・宿泊]
    Protected Sub BtnNewKotsuList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewKotsuList.Click
        Response.Redirect(URL.NewDrList)
    End Sub

    '[検索 交通・宿泊]
    Protected Sub BtnKotsuList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKotsuList.Click
        Response.Redirect(URL.DrList)
    End Sub

    '[精算処理]
    Protected Sub BtnSeisan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSeisan.Click
        Response.Redirect(URL.SeisanKensaku)
    End Sub

    '[コストセンター別費用入力]
    Protected Sub BtnCost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCost.Click
        Response.Redirect(URL.CostRegist)
    End Sub

    '[SAPデータ作成]
    Protected Sub BtnSap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSap.Click
        Response.Redirect(URL.SapCsv)
    End Sub

    '[タクシーチケット管理]
    Protected Sub BtnSeikyuMeisai0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMenu.Click
        Response.Redirect(URL.TaxiMenu)
    End Sub

End Class
