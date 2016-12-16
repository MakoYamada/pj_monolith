Imports CommonLib
Imports AppLib
Partial Public Class SeisanMaintenance
    Inherits WebBase

    Private MS_USER As TableDef.MS_USER.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private TBL_SHOUNIN As TableDef.TBL_SHOUNIN.DataStruct
    Private SEQ As Integer

    Private Sub SeisanMaintenance_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_SEIKYU) = TBL_SEIKYU
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化            InitControls()

            If Trim(Request.QueryString(RequestDef.DbInsertEnd)) = CmnConst.Flag.On Then
                SetForm(True)
            Else
                If Not MyModule.IsInsertMode() Then
                    '画面項目表示
                    SetForm()
                End If
            End If
        End If

        Session.Remove(SessionDef.SeisanRegistReport_SQL)
        Session.Remove(SessionDef.BackURL_Print)

        'マスターページ設定
        With Me.Master
            .PageTitle = "精算データメンテナンス"
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
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Try
            TBL_SEIKYU = Session.Item(SessionDef.TBL_SEIKYU)
            If TBL_SEIKYU Is Nothing Then
                If MyModule.IsInsertMode() Then
                    Session.Item(SessionDef.SEQ) = 0
                    SEQ = 0
                    ReDim TBL_SEIKYU(SEQ)
                Else
                    Return False
                End If
            End If
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

    '画面項目 初期化    Private Sub InitControls()
        'IME設定        CmnModule.SetIme(Me.SEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KAIJOHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KIZAIHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.INSHOKUHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.HOTELHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.HOTELHI_TOZEI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JR_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.AIR_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.OTHER_TRAFFIC_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.HOTEL_COMMISSION_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_COMMISSION_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_SEISAN_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JINKENHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.OTHER_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KANRIHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KAIJOUHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KIZAIHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.INSHOKUHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JINKENHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.OTHER_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KANRIHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISAN_YM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_SEISAN_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISANSHO_URL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_TICKET_URL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.MR_JR, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.MR_HOTEL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.MR_HOTEL_TOZEI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISAN_KANRYO, CmnModule.ImeType.Active)

        AppModule.SetDropDownList_SEND_FLAG_ForSEISAN(Me.SEND_FLAG)
        CmnModule.SetEnabled(Me.SEND_FLAG, False)

        'クリア
        CmnModule.ClearAllControl(Me)

        '初期表示時の設定
        If MyModule.IsInsertMode() Then
            '新規登録
            'キー項目入力可
            Me.KOUENKAI_NO.Enabled = True
            Me.KOUENKAI_NO.Text = Joken.KOUENKAI_NO
        Else
            Me.KOUENKAI_NO.Enabled = False
        End If

    End Sub

    '画面項目 表示
    Private Sub SetForm(Optional ByVal DispMessage As Boolean = False)

        If DispMessage = False Then
            Me.DivMessage.Visible = False
        Else
            Dim recordKbn As String = Session.Item(SessionDef.RECORD_KUBUN)
            Dim wStr As String = "精算データを" & AppModule.GetName_RECORD_KUBUN(recordKbn) & "しました。"
            Me.LabelMessage.Text = wStr

            Me.DivMessage.Visible = True

            '登録後は、更新モードとする
            Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update
        End If

        Me.SEND_FLAG.SelectedValue = TBL_SEIKYU(SEQ).SEND_FLAG
        Me.KOUENKAI_NO.Text = TBL_SEIKYU(SEQ).KOUENKAI_NO
        Me.SEIKYU_NO_TOPTOUR.Text = TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR
        Me.SHIHARAI_NO.Text = TBL_SEIKYU(SEQ).SHIHARAI_NO
        Select Case TBL_SEIKYU(SEQ).SHOUNIN_KUBUN
            Case AppConst.SEISAN.SHOUNIN_KUBUN.Code.Mi
                Me.RdoMi.Checked = True
            Case AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN
                Me.RdoShounin.Checked = True
            Case AppConst.SEISAN.SHOUNIN_KUBUN.Code.HININ
                Me.RdoHinin.Checked = True
        End Select
        Me.SHOUNIN_DATE.Text = TBL_SEIKYU(SEQ).SHOUNIN_DATE
        Me.KAIJOHI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KAIJOHI_TF)
        Me.KIZAIHI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KIZAIHI_TF)
        Me.INSHOKUHI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).INSHOKUHI_TF)
        Me.KEI_991330401_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_991330401_TF)
        Me.HOTELHI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).HOTELHI_TF)
        Me.HOTELHI_TOZEI.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).HOTELHI_TOZEI)
        Me.JR_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).JR_TF)
        Me.AIR_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).AIR_TF)
        Me.OTHER_TRAFFIC_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).OTHER_TRAFFIC_TF)
        Me.TAXI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).TAXI_TF)
        Me.HOTEL_COMMISSION_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).HOTEL_COMMISSION_TF)
        Me.TAXI_COMMISSION_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).TAXI_COMMISSION_TF)
        Me.TAXI_SEISAN_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).TAXI_SEISAN_TF)
        Me.JINKENHI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).JINKENHI_TF)
        Me.OTHER_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).OTHER_TF)
        Me.KANRIHI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KANRIHI_TF)
        Me.KEI_41120200_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_41120200_TF)
        Me.KEI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_TF)
        Me.KAIJOUHI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KAIJOUHI_T)
        Me.KIZAIHI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KIZAIHI_T)
        Me.INSHOKUHI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).INSHOKUHI_T)
        Me.IROUKAIHI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).IROUKAIHI_T)
        Me.KEI_991330401_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_991330401_T)
        Me.JINKENHI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).JINKENHI_T)
        Me.OTHER_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).OTHER_T)
        Me.KANRIHI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KANRIHI_T)
        Me.KEI_41120200_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_41120200_T)
        Me.KEI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_T)
        Me.SEISAN_YM.Text = TBL_SEIKYU(SEQ).SEISAN_YM
        Me.TAXI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).TAXI_T)
        Me.TAXI_SEISAN_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).TAXI_SEISAN_T)
        Me.SEISANSHO_URL.Text = TBL_SEIKYU(SEQ).SEISANSHO_URL
        Me.TAXI_TICKET_URL.Text = TBL_SEIKYU(SEQ).TAXI_TICKET_URL
        'AppModule.SetForm_SEISAN_KANRYO(TBL_SEIKYU(SEQ).SEISAN_KANRYO, Me.SEISAN_KANRYO)
        Me.MR_JR.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).MR_JR)
        Me.MR_HOTEL.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).MR_HOTEL)
        Me.MR_HOTEL_TOZEI.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).MR_HOTEL_TOZEI)
        Me.SEISAN_KANRYO.Text = TBL_SEIKYU(SEQ).SEISAN_KANRYO

        '合計金額再計算
        CalculateKingaku()

        '登録処理後のコントロール制御
        If Not MyModule.IsInsertMode() Then
            Me.KOUENKAI_NO.Enabled = False
            'Me.SEISAN_YM.Enabled = False
        End If
    End Sub

    Private Sub CalculateKingaku()

        Dim wTOTAL_TF1 As Long = 0
        Dim wTOTAL_TF2 As Long = 0
        Dim wTOTAL_T1 As Long = 0
        Dim wTOTAL_T2 As Long = 0
        Dim wMR_KINGAKU As Long = 0
        Dim wTAXI_ENTA As Long = 0

        Try
            '991330401
            wTOTAL_TF1 = CmnModule.DbVal_Kingaku(Me.KAIJOHI_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.KIZAIHI_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.INSHOKUHI_TF.Text.Trim)

            '41120200
            wTOTAL_TF2 = CmnModule.DbVal_Kingaku(Me.HOTELHI_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.HOTELHI_TOZEI.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.JR_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.AIR_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.OTHER_TRAFFIC_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.TAXI_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.HOTEL_COMMISSION_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.TAXI_COMMISSION_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.TAXI_SEISAN_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.JINKENHI_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.OTHER_TF.Text.Trim) + _
                         CmnModule.DbVal_Kingaku(Me.KANRIHI_TF.Text.Trim)

            '991330401
            wTOTAL_T1 = CmnModule.DbVal_Kingaku(Me.KAIJOUHI_T.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.KIZAIHI_T.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.INSHOKUHI_T.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.IROUKAIHI_T.Text.Trim)

            '41120200
            wTOTAL_T2 = CmnModule.DbVal_Kingaku(Me.JINKENHI_T.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.OTHER_T.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.KANRIHI_T.Text.Trim)

            wMR_KINGAKU = CmnModule.DbVal_Kingaku(Me.MR_HOTEL.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.MR_HOTEL_TOZEI.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.MR_JR.Text.Trim)

            wTAXI_ENTA = CmnModule.DbVal_Kingaku(Me.TAXI_T.Text.Trim) + _
                        CmnModule.DbVal_Kingaku(Me.TAXI_SEISAN_T.Text.Trim)

        Catch ex As Exception
        End Try

        '非課税金額
        Me.KEI_991330401_TF.Text = CmnModule.EditComma(wTOTAL_TF1.ToString)
        Me.KEI_41120200_TF.Text = CmnModule.EditComma(wTOTAL_TF2.ToString)
        Me.KEI_TF.Text = CmnModule.EditComma(CStr(wTOTAL_TF1 + wTOTAL_TF2))

        '課税金額
        Me.KEI_991330401_T.Text = CmnModule.EditComma(wTOTAL_T1.ToString)
        Me.KEI_41120200_T.Text = CmnModule.EditComma(wTOTAL_T2.ToString)
        Me.KEI_T.Text = CmnModule.EditComma(CStr(wTOTAL_T1 + wTOTAL_T2))

        '総合計金額
        Me.lblTotalKingaku.Text = CmnModule.EditComma(CStr(wTOTAL_TF1 + wTOTAL_TF2 + wTOTAL_T1 + wTOTAL_T2 + wMR_KINGAKU + wTAXI_ENTA))

    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '精算月
        If Not CmnCheck.IsInput(Me.SEISAN_YM) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_SEIKYU.Name.SEISAN_YM), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.SEISAN_YM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_YM), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthEQ(Me.SEISAN_YM, Me.SEISAN_YM.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthEQ(TableDef.TBL_SEIKYU.Name.SEISAN_YM, Me.SEISAN_YM.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsValidDateYMD(Me.SEISAN_YM.Text & "01") Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.TBL_SEIKYU.Name.SEISAN_YM), Me)
            Return False
        End If


        '承認日
        If Not CmnCheck.IsNumberOnly(Me.SHOUNIN_DATE) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("承認日"), Me)
            SetFocus(Me.SHOUNIN_DATE)
            Return False
        End If

        If CmnCheck.IsInput(Me.SHOUNIN_DATE) Then
            If Me.SHOUNIN_DATE.Text.Trim.Length < 8 Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ("承認日", 8, False), Me)
                SetFocus(Me.SHOUNIN_DATE)
                Return False
            End If

            Dim wStr As String = StrConv(Me.SHOUNIN_DATE.Text.Substring(0, 4) & "/" & Me.SHOUNIN_DATE.Text.Substring(4, 2) & "/" & Me.SHOUNIN_DATE.Text.Substring(6, 2), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("承認日"), Me)
                SetFocus(Me.SHOUNIN_DATE)
                Return False
            End If
        End If

        Return True
    End Function

    '入力値を取得    Private Sub GetValue(ByVal SEND_FLAG As String)

        TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        TBL_SEIKYU(SEQ).SHOUNIN_DATE = Me.SHOUNIN_DATE.Text
        If Me.RdoMi.Checked Then
            TBL_SEIKYU(SEQ).SHOUNIN_KUBUN = AppConst.SEISAN.SHOUNIN_KUBUN.Code.Mi
        ElseIf Me.RdoShounin.Checked Then
            TBL_SEIKYU(SEQ).SHOUNIN_KUBUN = AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN
        Else
            TBL_SEIKYU(SEQ).SHOUNIN_KUBUN = AppConst.SEISAN.SHOUNIN_KUBUN.Code.HININ
        End If
        TBL_SEIKYU(SEQ).SEISAN_YM = Me.SEISAN_YM.Text

        ' ''TBL_SEIKYU(SEQ).SEND_FLAG = SEND_FLAG   'メンテナンスモードの場合は、NOZOMI送信フラグを更新しない(2015/11/09)
        TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

        TBL_SHOUNIN = Nothing
        TBL_SHOUNIN.KOUENKAI_NO = Me.KOUENKAI_NO.Text
        TBL_SHOUNIN.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        TBL_SHOUNIN.SHIHARAI_NO = Me.SHIHARAI_NO.Text
        TBL_SHOUNIN.SHOUNIN_KUBUN = TBL_SEIKYU(SEQ).SHOUNIN_KUBUN
        TBL_SHOUNIN.SHOUNIN_DATE = TBL_SEIKYU(SEQ).SHOUNIN_DATE
        TBL_SHOUNIN.UPDATE_USER = Session.Item(SessionDef.LoginID)
    End Sub

    'DB登録処理
    Private Function ExecuteTransaction() As Boolean
        Dim wFlag As Boolean = False

        If AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                            TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                            MyBase.DbConnection) Then
            '更新
            wFlag = UpdateData()
        End If
        If Not wFlag Then Return wFlag

        If AppModule.IsExist(SQL.TBL_SHOUNIN.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                            TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                            MyBase.DbConnection) Then
            '更新
            wFlag = UpdateShounin()
        End If

        Return wFlag
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        MyBase.BeginTransaction()
        Try
            'データ更新
            Dim strSQL As String = SQL.TBL_SEIKYU.Update_MAINTENANCE(TBL_SEIKYU(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanMaintenance, TBL_SEIKYU(SEQ), True, "", MyBase.DbConnection)

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanMaintenance, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return True
    End Function
    Private Function UpdateShounin() As Boolean
        MyBase.BeginTransaction()
        Try
            'データ更新
            Dim strSQL As String = SQL.TBL_SHOUNIN.Update_MAINTENANCE(TBL_SHOUNIN)
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanMaintenance, TBL_SHOUNIN, True, "", MyBase.DbConnection)

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanMaintenance, TBL_SHOUNIN, False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return True
    End Function

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click

        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
            Response.Redirect(URL.SeisanMaintenance & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '[NOZOMIへ]
    Private Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNozomi.Click

        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If ExecuteTransaction() Then
            Response.Redirect(URL.SeisanRegist & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '[戻る]
    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel1.Click, BtnCancel2.Click
        Session.Remove(SessionDef.SeisanRegistReport_SQL)
        Session.Remove(SessionDef.BackURL_Print)

        Response.Redirect(URL.SeisanList)
    End Sub

End Class