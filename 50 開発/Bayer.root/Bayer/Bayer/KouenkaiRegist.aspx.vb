Imports CommonLib
Imports AppLib
Partial Public Class KouenkaiRegist
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'QQQ
        Session.Item(SessionDef.LoginID) = "QQQ"

        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

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
            .PageTitle = "講演会基本情報"
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            If IsNothing(TBL_KOUENKAI) Then Return False
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
        AppModule.SetDropDownList_KIDOKU(Me.KIDOKU_FLG)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KOUENKAI(SEQ).KOUENKAI_NO)
        Me.KIDOKU_FLG.Text = AppModule.GetName_KIDOKU_FLG(TBL_KOUENKAI(SEQ).KIDOKU_FLG)
        Me.TORIKESHI_FLG.Text = AppModule.GetName_TORIKESHI_FLG(TBL_KOUENKAI(SEQ).TORIKESHI_FLG)
        Me.TIME_STAMP.Text = AppModule.GetName_TIME_STAMP(TBL_KOUENKAI(SEQ).TIME_STAMP)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KOUENKAI(SEQ).KOUENKAI_NAME)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(TBL_KOUENKAI(SEQ).TAXI_PRT_NAME)
        Me.KOUENKAI_TITLE.Text = AppModule.GetName_KOUENKAI_TITLE(TBL_KOUENKAI(SEQ).KOUENKAI_TITLE)
        Me.FROM_DATE.Text = AppModule.GetName_FROM_DATE(TBL_KOUENKAI(SEQ).FROM_DATE)
        Me.TO_DATE.Text = AppModule.GetName_TO_DATE(TBL_KOUENKAI(SEQ).TO_DATE)
        Me.KAIJO_NAME.Text = AppModule.GetName_KAIJO_NAME(TBL_KOUENKAI(SEQ).KAIJO_NAME)
        Me.SEIHIN_NAME.Text = AppModule.GetName_SEIHIN_NAME(TBL_KOUENKAI(SEQ).SEIHIN_NAME)
        Me.INTERNAL_ORDER_T.Text = AppModule.GetName_INTERNAL_ORDER_T(TBL_KOUENKAI(SEQ).INTERNAL_ORDER_T)
        Me.INTERNAL_ORDER_TF.Text = AppModule.GetName_INTERNAL_ORDER_TF(TBL_KOUENKAI(SEQ).INTERNAL_ORDER_TF)
        Me.ACCOUNT_CD_T.Text = AppModule.GetName_ACCOUNT_CD_T(TBL_KOUENKAI(SEQ).ACCOUNT_CD_T)
        Me.ACCOUNT_CD_TF.Text = AppModule.GetName_ACCOUNT_CD_TF(TBL_KOUENKAI(SEQ).ACCOUNT_CD_TF)
        Me.ZETIA_CD.Text = AppModule.GetName_ZETIA_CD(TBL_KOUENKAI(SEQ).ZETIA_CD)
        Me.SANKA_YOTEI_CNT.Text = AppModule.GetName_SANKA_YOTEI_CNT(TBL_KOUENKAI(SEQ).SANKA_YOTEI_CNT)
        Me.BU.Text = AppModule.GetName_BU(TBL_KOUENKAI(SEQ).BU)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_AREA)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_EIGYOSHO)
        Me.COST_CENTER.Text = AppModule.GetName_COST_CENTER(TBL_KOUENKAI(SEQ).COST_CENTER)
        Me.KIKAKU_TANTO_NAME.Text = AppModule.GetName_KIKAKU_TANTO_NAME(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_NAME)
        Me.KIKAKU_TANTO_ROMA.Text = AppModule.GetName_KIKAKU_TANTO_ROMA(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_ROMA)
        Me.KIKAKU_TANTO_TEL.Text = AppModule.GetName_KIKAKU_TANTO_TEL(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_TEL)
        Me.KIKAKU_TANTO_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_KEITAI(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_KEITAI)
        Me.KIKAKU_TANTO_EMAIL.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_EMAIL_PC)
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL_KEITAI(TBL_KOUENKAI(SEQ).KIKAKU_TANTO_EMAIL_KEITAI)
        Me.YOSAN_TF.Text = AppModule.GetName_YOSAN_TF(TBL_KOUENKAI(SEQ).YOSAN_TF)
        Me.YOSAN_T.Text = AppModule.GetName_YOSAN_T(TBL_KOUENKAI(SEQ).YOSAN_T)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If
        Return True
    End Function

    '入力値を取得
    Private Sub GetValue(ByVal SEND_FLAG As String)
        TBL_KOUENKAI(SEQ).KIDOKU_FLG = Me.KIDOKU_FLG.SelectedValue
        TBL_KOUENKAI(SEQ).SEND_FLAG = SEND_FLAG
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
            strSQL = SQL.TBL_KOUENKAI.Update(TBL_KOUENKAI(SEQ))
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

    '[キャンセル]
    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Response.Redirect(Session.Item(SessionDef.BackURL))
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '[NOZOMIへ]
    Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub
End Class
