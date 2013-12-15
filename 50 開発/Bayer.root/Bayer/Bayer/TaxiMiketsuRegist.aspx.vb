Imports CommonLib
Imports AppLib
Partial Public Class TaxiMiketsuRegist
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "未決登録"
            .HideLogout = False
            .HideMenu = False
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_TAXITICKET_HAKKO = Session.Item(SessionDef.TBL_TAXITICKET_HAKKO)
            If IsNothing(TBL_TAXITICKET_HAKKO) Then Return False
        Catch ex As Exception
            Return False
        End Try
        If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
            Return False
        Else
            SEQ = Session.Item(SessionDef.SEQ)
        End If
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NO)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NAME)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(TBL_TAXITICKET_HAKKO(SEQ).TAXI_PRT_NAME)
        Me.FROM_DATE.Text = AppModule.GetName_FROM_DATE(TBL_TAXITICKET_HAKKO(SEQ).FROM_DATE)
        Me.TO_DATE.Text = AppModule.GetName_TO_DATE(TBL_TAXITICKET_HAKKO(SEQ).TO_DATE)
    End Sub

    'データ更新
    Private Function ExecuteTransaction() As Boolean
        Return UpdateData()
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            'データ更新
            strSQL = SQL.TBL_TAXITICKET_HAKKO.Update(TBL_TAXITICKET_HAKKO(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu, TBL_TAXITICKET_HAKKO(SEQ), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu, TBL_TAXITICKET_HAKKO(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)
        Response.Redirect(Session.Item(SessionDef.BackURL2))
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub
End Class
