Imports CommonLib
Imports AppLib
Partial Public Class KouenkaiRegist
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private DSP_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private OldTBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct
    Private SEQ As Integer
    Private Popup As Boolean = False

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        If Not Session.Item(SessionDef.KouenkaiRireki) Then
            '呼び元が新着一覧・検索の場合
            MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)
            Popup = False
        Else
            '呼び元が履歴一覧・手配画面の場合
            MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)
            Popup = True
        End If

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            '旧データ取得
            GetData_Old()

            '画面項目表示
            SetForm()

            '呼び元が新着一覧・検索以外の場合は登録・NOZOMIボタンは非表示
            If URL.NewKouenkaiList.IndexOf(Session.Item(SessionDef.BackURL2)) > 0 OrElse _
                URL.KouenkaiList.IndexOf(Session.Item(SessionDef.BackURL2)) > 0 Then
                BtnSubmit1.Visible = True
                BtnSubmit2.Visible = True
                '''BtnNozomi.Visible = True
            Else
                BtnSubmit1.Visible = False
                BtnSubmit2.Visible = False
                '''BtnNozomi.Visible = False
            End If

            '呼び元が履歴一覧の場合は履歴表示ボタンは非表示
            If Popup Then
                BtnRireki.Visible = False
                BtnSubmit1.Visible = False
                BtnSubmit2.Visible = False
                '''BtnNozomi.Visible = False
            Else
                BtnRireki.Visible = True
                BtnSubmit1.Visible = True
                BtnSubmit2.Visible = True
                '''BtnNozomi.Visible = True
            End If

            '' ''表示対象より新しい会合基本情報がある場合はNOZOMIボタンは使用不可
            ' ''If ChkNewData() Then
            ' ''    BtnNozomi.Enabled = True
            ' ''Else
            ' ''    BtnNozomi.Enabled = False
            ' ''End If

        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "会合基本情報"
            If Popup Then
                .HideLogout = True
                .HideMenu = True
            Else
                .HideLogout = False
                .HideMenu = False
            End If
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            If Popup Then
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                DSP_KOUENKAI = Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI)
            Else
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                DSP_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            End If
            If IsNothing(DSP_KOUENKAI) Then Return False
        Catch ex As Exception
            Return False
        End Try
        If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
            Return False
        Else
            If Popup Then
                SEQ = Session.Item(SessionDef.KouenkaiRireki_SEQ)
            Else
                SEQ = Session.Item(SessionDef.SEQ)
            End If
        End If
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'プルダウン設定
        AppModule.SetDropDownList_KIDOKU(Me.KIDOKU_FLG)
        AppModule.SetDropDownList_USER_NAME(Me.TTEHAI_TANTO, DbConnection)
        'IME設定        CmnModule.SetIme(Me.DANTAI_CODE, CmnModule.ImeType.InActive)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        Dim DSP_SEQ As Integer = 0

        If Popup Then
            DSP_KOUENKAI = Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI)
            DSP_SEQ = Session.Item(SessionDef.KouenkaiRireki_SEQ)
        Else
            DSP_SEQ = SEQ
        End If
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(DSP_KOUENKAI(DSP_SEQ).KOUENKAI_NO)
        Me.KIDOKU_FLG.SelectedValue = AppModule.GetName_KIDOKU_FLG(DSP_KOUENKAI(DSP_SEQ).KIDOKU_FLG)
        Me.TORIKESHI_FLG.Text = AppModule.GetName_TORIKESHI_FLG(DSP_KOUENKAI(DSP_SEQ).TORIKESHI_FLG)
        Me.TIME_STAMP.Text = AppModule.GetName_TIME_STAMP(DSP_KOUENKAI(DSP_SEQ).TIME_STAMP)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(DSP_KOUENKAI(DSP_SEQ).KOUENKAI_NAME)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(DSP_KOUENKAI(DSP_SEQ).TAXI_PRT_NAME)
        Me.FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(DSP_KOUENKAI(DSP_SEQ).FROM_DATE, DSP_KOUENKAI(DSP_SEQ).TO_DATE)
        Me.KAIJO_NAME.Text = AppModule.GetName_KAIJO_NAME(DSP_KOUENKAI(DSP_SEQ).KAIJO_NAME)
        Me.SEIHIN_NAME.Text = AppModule.GetName_SEIHIN_NAME(DSP_KOUENKAI(DSP_SEQ).SEIHIN_NAME)
        Me.INTERNAL_ORDER_T.Text = AppModule.GetName_INTERNAL_ORDER_T(DSP_KOUENKAI(DSP_SEQ).INTERNAL_ORDER_T)
        Me.INTERNAL_ORDER_TF.Text = AppModule.GetName_INTERNAL_ORDER_TF(DSP_KOUENKAI(DSP_SEQ).INTERNAL_ORDER_TF)
        Me.ACCOUNT_CD_T.Text = AppModule.GetName_ACCOUNT_CD_T(DSP_KOUENKAI(DSP_SEQ).ACCOUNT_CD_T)
        Me.ACCOUNT_CD_TF.Text = AppModule.GetName_ACCOUNT_CD_TF(DSP_KOUENKAI(DSP_SEQ).ACCOUNT_CD_TF)
        Me.ZETIA_CD.Text = AppModule.GetName_ZETIA_CD(DSP_KOUENKAI(DSP_SEQ).ZETIA_CD)
        Me.SANKA_YOTEI_CNT_NMBR.Text = AppModule.GetName_SANKA_YOTEI_CNT_NMBR(DSP_KOUENKAI(DSP_SEQ).SANKA_YOTEI_CNT_NMBR)
        Me.SANKA_YOTEI_CNT_MBR.Text = AppModule.GetName_SANKA_YOTEI_CNT_MBR(DSP_KOUENKAI(DSP_SEQ).SANKA_YOTEI_CNT_MBR)
        Dim strSQL As String = "SELECT * FROM MS_USER WHERE " & TableDef.MS_USER.Column.LOGIN_ID & "=N'" & DSP_KOUENKAI(DSP_SEQ).TTEHAI_TANTO & "'"
        Dim MS_USER As TableDef.MS_USER.DataStruct = AppModule.GetOneRecord(AppModule.TableType.MS_USER, strSQL, DbConnection)
        Me.TTEHAI_TANTO.SelectedValue = MS_USER.LOGIN_ID
        Me.DANTAI_CODE.Text = AppModule.GetName_DANTAI_CODE(DSP_KOUENKAI(DSP_SEQ).DANTAI_CODE)
        Me.BU.Text = AppModule.GetName_BU(DSP_KOUENKAI(DSP_SEQ).BU)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_AREA)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_EIGYOSHO)
        Me.COST_CENTER.Text = AppModule.GetName_COST_CENTER(DSP_KOUENKAI(DSP_SEQ).COST_CENTER)
        Me.KIKAKU_TANTO_NAME.Text = AppModule.GetName_KIKAKU_TANTO_NAME(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_NAME)
        Me.KIKAKU_TANTO_ROMA.Text = AppModule.GetName_KIKAKU_TANTO_ROMA(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_ROMA)
        Me.KIKAKU_TANTO_TEL.Text = AppModule.GetName_KIKAKU_TANTO_TEL(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_TEL)
        Me.KIKAKU_TANTO_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_KEITAI(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_KEITAI)
        Me.KIKAKU_TANTO_EMAIL.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_EMAIL_PC)
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL_KEITAI(DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_EMAIL_KEITAI)
        Me.YOSAN_TF.Text = AppModule.GetName_YOSAN_TF(DSP_KOUENKAI(DSP_SEQ).YOSAN_TF)
        Me.YOSAN_T.Text = AppModule.GetName_YOSAN_T(DSP_KOUENKAI(DSP_SEQ).YOSAN_T)
        Me.IROUKAI_YOSAN_T.Text = AppModule.GetName_IROUKAI_YOSAN_T(DSP_KOUENKAI(DSP_SEQ).IROUKAI_YOSAN_T)
        Me.IKENKOUKAN_YOSAN_T.Text = AppModule.GetName_IKENKOUKAN_YOSAN_T(DSP_KOUENKAI(DSP_SEQ).IKENKOUKAN_YOSAN_T)

        If Not Popup Then
            SetChangedColor(Me.TORIKESHI_FLG, DSP_KOUENKAI(DSP_SEQ).TORIKESHI_FLG, OldTBL_KOUENKAI.TORIKESHI_FLG)
            SetChangedColor(Me.KOUENKAI_NAME, DSP_KOUENKAI(DSP_SEQ).KOUENKAI_NAME, OldTBL_KOUENKAI.KOUENKAI_NAME)
            SetChangedColor(Me.FROM_DATE, DSP_KOUENKAI(DSP_SEQ).FROM_DATE, OldTBL_KOUENKAI.FROM_DATE)
            SetChangedColor(Me.KAIJO_NAME, DSP_KOUENKAI(DSP_SEQ).KAIJO_NAME, OldTBL_KOUENKAI.KAIJO_NAME)
            SetChangedColor(Me.SEIHIN_NAME, DSP_KOUENKAI(DSP_SEQ).SEIHIN_NAME, OldTBL_KOUENKAI.SEIHIN_NAME)
            SetChangedColor(Me.INTERNAL_ORDER_T, DSP_KOUENKAI(DSP_SEQ).INTERNAL_ORDER_T, OldTBL_KOUENKAI.INTERNAL_ORDER_T)
            SetChangedColor(Me.INTERNAL_ORDER_TF, DSP_KOUENKAI(DSP_SEQ).INTERNAL_ORDER_TF, OldTBL_KOUENKAI.INTERNAL_ORDER_TF)
            SetChangedColor(Me.ACCOUNT_CD_T, DSP_KOUENKAI(DSP_SEQ).ACCOUNT_CD_T, OldTBL_KOUENKAI.ACCOUNT_CD_T)
            SetChangedColor(Me.ACCOUNT_CD_TF, DSP_KOUENKAI(DSP_SEQ).ACCOUNT_CD_TF, OldTBL_KOUENKAI.ACCOUNT_CD_TF)
            SetChangedColor(Me.ZETIA_CD, DSP_KOUENKAI(DSP_SEQ).ZETIA_CD, OldTBL_KOUENKAI.ZETIA_CD)
            SetChangedColor(Me.SANKA_YOTEI_CNT_MBR, DSP_KOUENKAI(DSP_SEQ).SANKA_YOTEI_CNT_MBR, OldTBL_KOUENKAI.SANKA_YOTEI_CNT_MBR)
            SetChangedColor(Me.SANKA_YOTEI_CNT_NMBR, DSP_KOUENKAI(DSP_SEQ).SANKA_YOTEI_CNT_NMBR, OldTBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR)
            SetChangedColor(Me.TTEHAI_TANTO, DSP_KOUENKAI(DSP_SEQ).TTEHAI_TANTO, OldTBL_KOUENKAI.TTEHAI_TANTO)
            SetChangedColor(Me.DANTAI_CODE, DSP_KOUENKAI(DSP_SEQ).DANTAI_CODE, OldTBL_KOUENKAI.DANTAI_CODE)
            SetChangedColor(Me.KIKAKU_TANTO_JIGYOUBU, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_JIGYOUBU, OldTBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU)
            SetChangedColor(Me.BU, DSP_KOUENKAI(DSP_SEQ).BU, OldTBL_KOUENKAI.BU)
            SetChangedColor(Me.KIKAKU_TANTO_AREA, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_AREA, OldTBL_KOUENKAI.KIKAKU_TANTO_AREA)
            SetChangedColor(Me.KIKAKU_TANTO_EIGYOSHO, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_EIGYOSHO, OldTBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO)
            SetChangedColor(Me.COST_CENTER, DSP_KOUENKAI(DSP_SEQ).COST_CENTER, OldTBL_KOUENKAI.COST_CENTER)
            SetChangedColor(Me.KIKAKU_TANTO_NAME, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_NAME, OldTBL_KOUENKAI.KIKAKU_TANTO_NAME)
            SetChangedColor(Me.KIKAKU_TANTO_ROMA, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_ROMA, OldTBL_KOUENKAI.KIKAKU_TANTO_ROMA)
            SetChangedColor(Me.KIKAKU_TANTO_TEL, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_TEL, OldTBL_KOUENKAI.KIKAKU_TANTO_TEL)
            SetChangedColor(Me.KIKAKU_TANTO_KEITAI, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_KEITAI, OldTBL_KOUENKAI.KIKAKU_TANTO_KEITAI)
            SetChangedColor(Me.KIKAKU_TANTO_EMAIL, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_EMAIL_PC, OldTBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC)
            SetChangedColor(Me.KIKAKU_TANTO_EMAIL_KEITAI, DSP_KOUENKAI(DSP_SEQ).KIKAKU_TANTO_EMAIL_KEITAI, OldTBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI)
            SetChangedColor(Me.YOSAN_TF, DSP_KOUENKAI(DSP_SEQ).YOSAN_TF, OldTBL_KOUENKAI.YOSAN_TF)
            SetChangedColor(Me.YOSAN_T, DSP_KOUENKAI(DSP_SEQ).YOSAN_T, OldTBL_KOUENKAI.YOSAN_T)
            SetChangedColor(Me.IROUKAI_YOSAN_T, DSP_KOUENKAI(DSP_SEQ).IROUKAI_YOSAN_T, OldTBL_KOUENKAI.IROUKAI_YOSAN_T)
            SetChangedColor(Me.IKENKOUKAN_YOSAN_T, DSP_KOUENKAI(DSP_SEQ).IKENKOUKAN_YOSAN_T, OldTBL_KOUENKAI.IKENKOUKAN_YOSAN_T)
        End If
    End Sub

    '差異
    Private Function SetChangedColor(ByVal Data1 As String, ByVal Data2 As String) As System.Drawing.Color
        If Trim(OldTBL_KOUENKAI.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
            Return Drawing.Color.OrangeRed
        Else
            Return Drawing.Color.FromArgb(10, 10, 10)
        End If
    End Function
    Private Sub SetChangedColor(ByRef control As Label, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If Trim(OldTBL_KOUENKAI.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(255, 204, 255)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
    End Sub
    Private Sub SetChangedColor(ByRef control As TextBox, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If Trim(OldTBL_KOUENKAI.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(255, 204, 255)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
    End Sub
    Private Sub SetChangedColor(ByRef control As DropDownList, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If Trim(OldTBL_KOUENKAI.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(255, 204, 255)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
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
        DSP_KOUENKAI(SEQ).KIDOKU_FLG = Me.KIDOKU_FLG.SelectedValue
        DSP_KOUENKAI(SEQ).SEND_FLAG = SEND_FLAG
        DSP_KOUENKAI(SEQ).DANTAI_CODE = Me.DANTAI_CODE.Text
        DSP_KOUENKAI(SEQ).UPDATE_DATE = DSP_KOUENKAI(SEQ).TIME_STAMP_TOP
        DSP_KOUENKAI(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)
        If Me.TTEHAI_TANTO.SelectedIndex <> 0 Then
            DSP_KOUENKAI(SEQ).TTEHAI_TANTO = Me.TTEHAI_TANTO.SelectedValue
        End If
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
            strSQL = SQL.TBL_KOUENKAI.Update(DSP_KOUENKAI(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist, DSP_KOUENKAI(SEQ), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist, DSP_KOUENKAI(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

    '最新版データ存在チェック
    Private Function ChkNewData() As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim NewCnt(0) As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOUENKAI.byNEW_TIME_STAMP(DSP_KOUENKAI(SEQ).KOUENKAI_NO, DSP_KOUENKAI(SEQ).TIME_STAMP)

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            NewCnt(0) = CmnDb.DbData(RsData.GetName(0), RsData)
        End If
        RsData.Close()

        If NewCnt(0) = "0" Then
            Return True
        Else
            Return False
        End If
    End Function

    '旧データ取得
    Private Sub GetData_Old()
        Dim strSQL As String = SQL.TBL_KOUENKAI.byKOUENKAI_NO_UPDATE_DATE_DESC(DSP_KOUENKAI(SEQ).KOUENKAI_NO, DSP_KOUENKAI(SEQ).UPDATE_DATE)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlAG As Boolean = False

        OldTBL_KOUENKAI = Nothing
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlAG = True
            OldTBL_KOUENKAI = AppModule.SetRsData(RsData, OldTBL_KOUENKAI)
        End If
        RsData.Close()
    End Sub

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)

        If Popup Then
            Dim scriptStr As String = ""
            scriptStr &= "<script language='javascript' type='text/javascript'>"
            scriptStr &= "window.opener.aspnetForm.submit();"
            scriptStr &= "window.close();"
            scriptStr &= "</script>"

            ClientScript.RegisterStartupScript(Me.GetType(), "Detail", scriptStr)
        Else
            Response.Redirect(Session.Item(SessionDef.BackURL2))
        End If
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit1.Click, BtnSubmit2.Click
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '' ''[NOZOMIへ]
    ' ''Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
    ' ''    If Not Check() Then Exit Sub

    ' ''    '入力値を取得
    ' ''    GetValue(AppConst.SEND_FLAG.Code.Taisho)

    ' ''    'データ更新
    ' ''    If ExecuteTransaction() Then
    ' ''    End If
    ' ''End Sub

    '[履歴表示]
    Private Sub BtnRireki_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRireki.Click
        Session.Item(SessionDef.SEQ) = SEQ
        Session.Item(SessionDef.TBL_KOUENKAI) = DSP_KOUENKAI
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Response.Redirect(URL.KouenkaiRireki)
    End Sub
End Class
