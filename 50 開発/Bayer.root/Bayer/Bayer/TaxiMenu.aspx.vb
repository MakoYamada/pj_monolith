Imports CommonLib
Imports AppLib
Partial Public Class TaxiMenu
    Inherits WebBase

    Private MS_USER As TableDef.MS_USER.DataStruct

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
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
            .PageTitle = "タクシーチケット管理メニュー"
        End With
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
    End Sub
 
    '[タクチケ印刷データ作成]
    Protected Sub BtnTaxiCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiCsv.Click
        Response.Redirect(URL.TaxiCsv)
    End Sub

    '[タクチケ納品データ取込]
    Private Sub BtnTaxiNouhinTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTaxiNouhinTorikomi.Click
        Response.Redirect(URL.TaxiNouhinTorikomi)
    End Sub

    '[タクチケ未決処理]
    Protected Sub BtnTaxiMiketsu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMiketsu.Click
        Response.Redirect(URL.TaxiMiketsu)
    End Sub

    '[スキャンデータ取込]
    Protected Sub BtnTaxiScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiScan.Click
        Response.Redirect(URL.TaxiScan)
    End Sub

    '[タクチケメンテナンス]
    Protected Sub BtnTaxiMaintenance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMaintenance.Click
        Response.Redirect(URL.TaxiMaintenance)
    End Sub

    '[実績データ取込]
    Protected Sub BtnTaxiJisseki_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiJisseki.Click
        Response.Redirect(URL.TaxiJisseki)
    End Sub
End Class
