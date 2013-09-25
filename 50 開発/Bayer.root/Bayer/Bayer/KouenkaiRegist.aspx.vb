Imports CommonLib
Imports AppLib
Partial Public Class KouenkaiRegist
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_KAIJO) = TBL_KAIJO
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'QQQ
        Session.Item(SessionDef.LoginID) = "QQQ"

        ''共通チェック
        'MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        ''セッションを変数に格納
        'If Not SetSession() Then
        '    Response.Redirect(URL.TimeOut)
        'End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "講演会基本情報"
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_KAIJO = Session.Item(SessionDef.TBL_KAIJO)
            If IsNothing(TBL_KAIJO) Then Return False
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
        'プルダウン設定
        AppModule.SetDropDownList_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '依頼(表示)
        'Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KAIJO(SEQ).KOUENKAI_NO)
        'Me.FROM_DATE.Text = AppModule.GetName_YOTEI_DATE(TBL_KAIJO(SEQ).YOTEI_DATE)
        'Me.TO_DATE.Text = AppModule.GetName_YOTEI_DATE(TBL_KAIJO(SEQ).YOTEI_DATE)
        'Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KAIJO(SEQ).KOUENKAI_NAME)
        'Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(TBL_KAIJO(SEQ).TAXI_PRT_NAME)
        ''Me.SEIHIN_NAME.Text = AppModule.GetName_SEIHIN_NAME(TBL_KAIJO(SEQ).SEIHIN_NAME)
        'Me.KIKAKU_TANTO_JIGYOBU.Text = AppModule.GetName_KIKAKU_TANTO_JIGYOBU(TBL_KAIJO(SEQ).KIKAKU_TANTO_JIGYOBU)
        'Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(TBL_KAIJO(SEQ).KIKAKU_TANTO_AREA)
        'Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(TBL_KAIJO(SEQ).KIKAKU_TANTO_EIGYOSHO)
        'Me.KIKAKU_TANTO_NO.Text = AppModule.GetName_KIKAKU_TANTO_NO(TBL_KAIJO(SEQ).KIKAKU_TANTO_NO)
        'Me.KIKAKU_TANTO_NAME.Text = AppModule.GetName_KIKAKU_TANTO_NAME(TBL_KAIJO(SEQ).KIKAKU_TANTO_NAME)
        'Me.KIKAKU_TANTO_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_KEITAI(TBL_KAIJO(SEQ).KIKAKU_TANTO_KEITAI)
        'Me.KIKAKU_TANTO_EMAIL.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL(TBL_KAIJO(SEQ).KIKAKU_TANTO_EMAIL)
        'Me.TEHAI_TANTO_JIGYOBU.Text = AppModule.GetName_TEHAI_TANTO_JIGYOBU(TBL_KAIJO(SEQ).TEHAI_TANTO_JIGYOBU)
        'Me.TEHAI_TANTO_AREA.Text = AppModule.GetName_TEHAI_TANTO_AREA(TBL_KAIJO(SEQ).TEHAI_TANTO_AREA)
        'Me.TEHAI_TANTO_EIGYOSHO.Text = AppModule.GetName_TEHAI_TANTO_EIGYOSHO(TBL_KAIJO(SEQ).TEHAI_TANTO_EIGYOSHO)
        'Me.TEHAI_TANTO_NO.Text = AppModule.GetName_TEHAI_TANTO_NO(TBL_KAIJO(SEQ).TEHAI_TANTO_NO)
        'Me.TEHAI_TANTO_NAME.Text = AppModule.GetName_TEHAI_TANTO_NAME(TBL_KAIJO(SEQ).TEHAI_TANTO_NAME)
        'Me.TEHAI_TANTO_KEITAI.Text = AppModule.GetName_TEHAI_TANTO_KEITAI(TBL_KAIJO(SEQ).TEHAI_TANTO_KEITAI)
        'Me.TEHAI_TANTO_EMAIL.Text = AppModule.GetName_TEHAI_TANTO_EMAIL(TBL_KAIJO(SEQ).TEHAI_TANTO_EMAIL)
        'Me.MITSUMORI_TF.Text = AppModule.GetName_MITSUMORI_TF(TBL_KAIJO(SEQ).MITSUMORI_TF)
        ''Me.予算額費用1.Text = AppModule.GetName_予算額費用1(TBL_KAIJO(SEQ).予算額費用1)
        ''Me.予算額費用2.Text = AppModule.GetName_予算額費用2(TBL_KAIJO(SEQ).予算額費用2)
        ''Me.実施費用計.Text = AppModule.GetName_実施費用計(TBL_KAIJO(SEQ).MITSUMORI_TF, TBL_KAIJO(SEQ).予算額費用1, TBL_KAIJO(SEQ).予算額費用2)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.ANS_STATUS_TEHAI) Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_KAIJO.Name.ANS_STATUS_TEHAI), Me)
            Return False
        End If

        Return True
    End Function

    '[NOZOMIへ]
    Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue()

        'データ更新
        If ExecuteTransaction() Then
            'QQQ ??????? Response.Redirect(URL.KaijoRegistEnd)
        End If
    End Sub

    '入力値を取得
    Private Sub GetValue()

        'QQQ ???? 送信対象のフラグ等
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
            strSQL = SQL.TBL_KAIJO.Update(TBL_KAIJO(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        Return True
    End Function

End Class
