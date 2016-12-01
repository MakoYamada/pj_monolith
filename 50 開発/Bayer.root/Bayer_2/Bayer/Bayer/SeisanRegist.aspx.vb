Imports CommonLib
Imports AppLib
Partial Public Class SeisanRegist
    Inherits WebBase

    Private MS_USER As TableDef.MS_USER.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private SEQ As Integer

    Private Sub SeisanRegist_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
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
            .PageTitle = "精算金額入力"
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
        'IME設定        CmnModule.SetIme(Me.KOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)
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

        AppModule.SetDropDownList_SEND_FLAG_ForSEISAN(Me.SEND_FLAG)
        CmnModule.SetEnabled(Me.SEND_FLAG, False)
        CmnModule.SetEnabled(Me.BtnLockCancel, False)

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
        Me.SHOUNIN_KUBUN.Text = AppModule.GetName_SHOUNIN_KUBUN(TBL_SEIKYU(SEQ).SHOUNIN_KUBUN)
        Me.SHOUNIN_DATE.Text = CmnModule.Format_Date(TBL_SEIKYU(SEQ).SHOUNIN_DATE, CmnModule.DateFormatType.YYYYMMDD)
        Me.KAIJOHI_TF.Text = TBL_SEIKYU(SEQ).KAIJOHI_TF
        Me.KIZAIHI_TF.Text = TBL_SEIKYU(SEQ).KIZAIHI_TF
        Me.INSHOKUHI_TF.Text = TBL_SEIKYU(SEQ).INSHOKUHI_TF
        Me.KEI_991330401_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_991330401_TF)
        Me.HOTELHI_TF.Text = TBL_SEIKYU(SEQ).HOTELHI_TF
        Me.HOTELHI_TOZEI.Text = TBL_SEIKYU(SEQ).HOTELHI_TOZEI
        Me.JR_TF.Text = TBL_SEIKYU(SEQ).JR_TF
        Me.AIR_TF.Text = TBL_SEIKYU(SEQ).AIR_TF
        Me.OTHER_TRAFFIC_TF.Text = TBL_SEIKYU(SEQ).OTHER_TRAFFIC_TF
        Me.TAXI_TF.Text = TBL_SEIKYU(SEQ).TAXI_TF
        Me.HOTEL_COMMISSION_TF.Text = TBL_SEIKYU(SEQ).HOTEL_COMMISSION_TF
        Me.TAXI_COMMISSION_TF.Text = TBL_SEIKYU(SEQ).TAXI_COMMISSION_TF
        Me.TAXI_SEISAN_TF.Text = TBL_SEIKYU(SEQ).TAXI_SEISAN_TF
        Me.JINKENHI_TF.Text = TBL_SEIKYU(SEQ).JINKENHI_TF
        Me.OTHER_TF.Text = TBL_SEIKYU(SEQ).OTHER_TF
        Me.KANRIHI_TF.Text = TBL_SEIKYU(SEQ).KANRIHI_TF
        Me.KEI_41120200_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_41120200_TF)
        Me.KEI_TF.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_TF)
        Me.KAIJOUHI_T.Text = TBL_SEIKYU(SEQ).KAIJOUHI_T
        Me.KIZAIHI_T.Text = TBL_SEIKYU(SEQ).KIZAIHI_T
        Me.INSHOKUHI_T.Text = TBL_SEIKYU(SEQ).INSHOKUHI_T
        Me.IROUKAIHI_T.Text = TBL_SEIKYU(SEQ).IROUKAIHI_T
        Me.KEI_991330401_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_991330401_T)
        Me.JINKENHI_T.Text = TBL_SEIKYU(SEQ).JINKENHI_T
        Me.OTHER_T.Text = TBL_SEIKYU(SEQ).OTHER_T
        Me.KANRIHI_T.Text = TBL_SEIKYU(SEQ).KANRIHI_T
        Me.KEI_41120200_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_41120200_T)
        Me.KEI_T.Text = CmnModule.EditComma(TBL_SEIKYU(SEQ).KEI_T)
        Me.SEISAN_YM.Text = TBL_SEIKYU(SEQ).SEISAN_YM
        Me.TAXI_T.Text = TBL_SEIKYU(SEQ).TAXI_T
        Me.TAXI_SEISAN_T.Text = TBL_SEIKYU(SEQ).TAXI_SEISAN_T
        Me.SEISANSHO_URL.Text = TBL_SEIKYU(SEQ).SEISANSHO_URL
        Me.TAXI_TICKET_URL.Text = TBL_SEIKYU(SEQ).TAXI_TICKET_URL
        Me.SEISAN_KANRYO.Text = TBL_SEIKYU(SEQ).SEISAN_KANRYO.Trim
        'AppModule.SetForm_SEISAN_KANRYO(TBL_SEIKYU(SEQ).SEISAN_KANRYO, Me.SEISAN_KANRYO)
        Me.MR_JR.Text = TBL_SEIKYU(SEQ).MR_JR
        Me.MR_HOTEL.Text = TBL_SEIKYU(SEQ).MR_HOTEL
        Me.MR_HOTEL_TOZEI.Text = TBL_SEIKYU(SEQ).MR_HOTEL_TOZEI

        '合計金額再計算
        If Not CheckCalcItem() Then Exit Sub
        CalculateKingaku()

        'ボタン制御
        If MS_USER.KENGEN = AppConst.MS_USER.KENGEN.Code.Admin Then
            Me.BtnLockCancel.Visible = True
        Else
            Me.BtnLockCancel.Visible = False
        End If

        Select Case Me.SEND_FLAG.SelectedValue
            Case AppConst.SEND_FLAG.Code.Mi
                CmnModule.SetEnabled(Me.BtnLockCancel, False)
                CmnModule.SetEnabled(Me.BtnSubmit, True)
                CmnModule.SetEnabled(Me.BtnNozomi, True)
            Case AppConst.SEND_FLAG.Code.Taisho
                CmnModule.SetEnabled(Me.BtnLockCancel, False)
                CmnModule.SetEnabled(Me.BtnSubmit, False)
                CmnModule.SetEnabled(Me.BtnNozomi, False)
            Case AppConst.SEND_FLAG.Code.Sumi
                CmnModule.SetEnabled(Me.BtnLockCancel, True)
                CmnModule.SetEnabled(Me.BtnSubmit, False)
                CmnModule.SetEnabled(Me.BtnNozomi, False)
        End Select

        '登録処理後のコントロール制御
        If Not MyModule.IsInsertMode() Then
            Me.KOUENKAI_NO.Enabled = False
            Me.SEISAN_YM.Enabled = False
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

        '必須入力
        If Not CmnCheck.IsInput(Me.KOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_SEIKYU.Name.KOUENKAI_NO), Me)
            Return False
        End If

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

        '小計、合計金額桁数
        Dim intKetasu As Integer = 10
        If Not CmnCheck.IsLengthLE(Me.KEI_991330401_TF.Text.Replace(",", ""), intKetasu) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.KEI_991330401_TF, intKetasu), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.KEI_41120200_TF.Text.Replace(",", ""), intKetasu) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.KEI_41120200_TF, intKetasu), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.KEI_TF.Text.Replace(",", ""), intKetasu) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.KEI_TF, intKetasu), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.KEI_991330401_T.Text.Replace(",", ""), intKetasu) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.KEI_991330401_T, intKetasu), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.KEI_41120200_T.Text.Replace(",", ""), intKetasu) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.KEI_41120200_T, intKetasu), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.KEI_T.Text.Replace(",", ""), intKetasu) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_SEIKYU.Name.KEI_T, intKetasu), Me)
            Return False
        End If

        Return True
    End Function

    '集計対象項目の数値チェック
    Private Function CheckCalcItem() As Boolean

        If Not CmnCheck.IsValidKingaku(Me.KAIJOHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KAIJOHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.INSHOKUHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.INSHOKUHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.KIZAIHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KIZAIHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.HOTELHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.HOTELHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.HOTELHI_TOZEI), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.AIR_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.AIR_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.JR_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.JR_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.OTHER_TRAFFIC_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.OTHER_TRAFFIC_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.JINKENHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.JINKENHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.KANRIHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KANRIHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.HOTEL_COMMISSION_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.HOTEL_COMMISSION_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.TAXI_COMMISSION_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_COMMISSION_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.OTHER_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.OTHER_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.TAXI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_TF), Me)
            Return False
        End If
        
        If Not CmnCheck.IsValidKingaku(Me.TAXI_SEISAN_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_SEISAN_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.KAIJOUHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KAIJOUHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.INSHOKUHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.INSHOKUHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.IROUKAIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.IROUKAIHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.KIZAIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KIZAIHI_T), Me)
            Return False
        End If


        If Not CmnCheck.IsValidKingaku(Me.JINKENHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.JINKENHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.KANRIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KANRIHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.OTHER_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.OTHER_T), Me)
            Return False
        End If


        If Not CmnCheck.IsValidKingaku(Me.MR_HOTEL) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.MR_HOTEL), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.MR_HOTEL_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.MR_HOTEL_TOZEI), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.MR_JR) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.MR_JR), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.TAXI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsValidKingaku(Me.TAXI_SEISAN_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_SEISAN_T), Me)
            Return False
        End If

        Return True
    End Function

    '入力値を取得    Private Sub GetValue(ByVal SEND_FLAG As String)

        TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text

        TBL_SEIKYU(SEQ).KAIJOHI_TF = Me.KAIJOHI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KIZAIHI_TF = Me.KIZAIHI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).INSHOKUHI_TF = Me.INSHOKUHI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_991330401_TF = Me.KEI_991330401_TF.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).HOTELHI_TF = Me.HOTELHI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).HOTELHI_TOZEI = Me.HOTELHI_TOZEI.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).JR_TF = Me.JR_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).AIR_TF = Me.AIR_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).OTHER_TRAFFIC_TF = Me.OTHER_TRAFFIC_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).TAXI_TF = Me.TAXI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).HOTEL_COMMISSION_TF = Me.HOTEL_COMMISSION_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).TAXI_COMMISSION_TF = Me.TAXI_COMMISSION_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).TAXI_SEISAN_TF = Me.TAXI_SEISAN_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).JINKENHI_TF = Me.JINKENHI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).OTHER_TF = Me.OTHER_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KANRIHI_TF = Me.KANRIHI_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_41120200_TF = Me.KEI_41120200_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_TF = Me.KEI_TF.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).KAIJOUHI_T = Me.KAIJOUHI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KIZAIHI_T = Me.KIZAIHI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).INSHOKUHI_T = Me.INSHOKUHI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).IROUKAIHI_T = Me.IROUKAIHI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_991330401_T = Me.KEI_991330401_T.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).JINKENHI_T = Me.JINKENHI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).OTHER_T = Me.OTHER_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KANRIHI_T = Me.KANRIHI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_41120200_T = Me.KEI_41120200_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_T = Me.KEI_T.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).SEISAN_YM = Me.SEISAN_YM.Text
        TBL_SEIKYU(SEQ).TAXI_T = Me.TAXI_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).TAXI_SEISAN_T = Me.TAXI_SEISAN_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).SEISANSHO_URL = Me.SEISANSHO_URL.Text
        TBL_SEIKYU(SEQ).TAXI_TICKET_URL = Me.TAXI_TICKET_URL.Text
        'TBL_SEIKYU(SEQ).SEISAN_KANRYO = AppModule.GetValue_SEISAN_KANRYO(Me.SEISAN_KANRYO)
        TBL_SEIKYU(SEQ).SEISAN_KANRYO = Me.SEISAN_KANRYO.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).MR_JR = Me.MR_JR.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).MR_HOTEL = Me.MR_HOTEL.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).MR_HOTEL_TOZEI = Me.MR_HOTEL_TOZEI.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).SEND_FLAG = SEND_FLAG
        TBL_SEIKYU(SEQ).INPUT_USER = Session.Item(SessionDef.LoginID)
        TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)
    End Sub

    'DB登録処理
    Private Function ExecuteTransaction() As Boolean


        If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
            Dim wRtn As Boolean = True
            'TOPTOUR請求番号が重複しなくなるまで最大値を取得し続ける
            Do Until wRtn = False
                '自動採番
                TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
                wRtn = AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                                    TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                                    MyBase.DbConnection)
            Loop

            '新規登録
            Return InsertData()
        Else
            If AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                                TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                                MyBase.DbConnection) Then
                '更新
                Return UpdateData()
            Else
                Dim wRtn As Boolean = True
                'TOPTOUR請求番号が重複しなくなるまで最大値を取得し続ける
                Do Until wRtn = False
                    '自動採番
                    TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
                    wRtn = AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                                        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                                        MyBase.DbConnection)
                Loop

                '新規登録
                Return InsertData()
            End If
        End If

    End Function

    'データ新規登録
    Private Function InsertData() As Boolean
        MyBase.BeginTransaction()
        Try
            'データ登録
            Dim strSQL As String = SQL.TBL_SEIKYU.Insert(TBL_SEIKYU(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), True, "", MyBase.DbConnection)

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return True
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        MyBase.BeginTransaction()
        Try
            'データ更新
            Dim strSQL As String = SQL.TBL_SEIKYU.Update(TBL_SEIKYU(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), True, "", MyBase.DbConnection)

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return True
    End Function

    '[再計算]
    Private Sub BtnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        If Not CheckCalcItem() Then Exit Sub
        CalculateKingaku()
        Me.DivMessage.Visible = False
        SetFocus(Me.BtnCalc)
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click

        '再計算
        If Not CheckCalcItem() Then Exit Sub
        CalculateKingaku()
        Me.DivMessage.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
        '    '自動採番
        '    Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
        'End If

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
            Me.SEIKYU_NO_TOPTOUR.Text = TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR
            Response.Redirect(URL.SeisanRegist & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '[NOZOMIへ]
    Private Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNozomi.Click

        '再計算
        If Not CheckCalcItem() Then Exit Sub
        CalculateKingaku()
        Me.DivMessage.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
        '    '自動採番
        '    Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
        'End If

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If ExecuteTransaction() Then
            Response.Redirect(URL.SeisanRegist & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '[解除]
    Protected Sub BtnLockCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLockCancel.Click

        '送信フラグを「未送信」に戻す
        TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        TBL_SEIKYU(SEQ).SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
        TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

        MyBase.BeginTransaction()

        Try
            Dim strSQL As String = SQL.TBL_SEIKYU.Update_SEND_FLAG(TBL_SEIKYU(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
        Catch ex As Exception
            MyBase.Rollback()
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        'ログ登録
        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), True, "", MyBase.DbConnection)
        '自画面へ遷移
        Response.Redirect(URL.SeisanRegist)
    End Sub

    '[印刷]
    Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click, BtnPrint2.Click

        If Not CmnCheck.IsInput(Me.SEIKYU_NO_TOPTOUR) Then
            '精算番号が自動採番されていないとき(=DBへ登録されていない)
            CmnModule.AlertMessage("印刷対象となるデータが登録されていません。", Me)
            Exit Sub
        End If

        Dim reportJoken As TableDef.Joken.DataStruct
        reportJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
        reportJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        Dim strSQL As String = SQL.TBL_SEIKYU.Search(reportJoken)
        Session.Item(SessionDef.SeisanRegistReport_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[戻る]
    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel1.Click, BtnCancel2.Click
        Session.Remove(SessionDef.SeisanRegistReport_SQL)
        Session.Remove(SessionDef.BackURL_Print)

        Response.Redirect(URL.SeisanList)
    End Sub

    '[参加者一覧CSV作成]
    Protected Sub BtnDrCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDrCsv.Click
        If Not FixSeikyuNo() Then Exit Sub

        '非表示ボタンをクリック(画面再表示の為)
        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType, "click", "<script language=javascript>document.getElementById('" + BtnDrCsvHid.ClientID + "').click();</script>")
    End Sub
    Protected Sub BtnDrCsvHid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDrCsvHid.Click
        OutputDrCsv()
    End Sub

    '[MR一覧CSV作成]
    Protected Sub BtnMrCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMrCsv.Click
        If Not FixSeikyuNo() Then Exit Sub

        '非表示ボタンをクリック(画面再表示の為)
        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType, "click", "<script language=javascript>document.getElementById('" + BtnMrCsvHid.ClientID + "').click();</script>")
    End Sub
    Protected Sub BtnMrCsvHid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMrCsvHid.Click
        OutputMrCsv()
    End Sub

    '[タクチケ精算データCSV作成]
    Protected Sub BtnTaxiCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiCsv.Click
        If Not UpdateTaxiData() Then Exit Sub

        '非表示ボタンをクリック(画面再表示の為)
        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType, "click", "<script language=javascript>document.getElementById('" + BtnTaxiCsvHid.ClientID + "').click();</script>")
    End Sub
    Protected Sub BtnTaxiCsvHid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiCsvHid.Click
        OutputTaxiCsv()
    End Sub

    '交通宿泊テーブルに精算番号を登録
    Private Function FixSeikyuNo() As Boolean

        If Me.SEND_FLAG.SelectedValue <> AppConst.SEND_FLAG.Code.Mi Then
            'データ更新処理は行わない
            Return True
        End If

        '入力チェック
        If Not Check() Then Return False

        If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
            Dim kensakuJoken As TableDef.Joken.DataStruct
            kensakuJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
            If Not AppModule.IsExist(SQL.TBL_KOTSUHOTEL.DrCsvCheck(kensakuJoken), MyBase.DbConnection) Then
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return False
            End If

            ''自動採番
            'Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)

            Try
                '請求データ(キー項目と送信フラグのみ)を登録する
                TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
                'TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
                TBL_SEIKYU(SEQ).SEISAN_YM = Me.SEISAN_YM.Text
                TBL_SEIKYU(SEQ).SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
                TBL_SEIKYU(SEQ).INPUT_USER = Session.Item(SessionDef.LoginID)
                TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

                Dim wRtn As Boolean = True
                'TOPTOUR請求番号が重複しなくなるまで最大値を取得し続ける
                Do Until wRtn = False
                    '自動採番
                    TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
                    wRtn = AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                                        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                                        MyBase.DbConnection)

                Loop


                Me.SEIKYU_NO_TOPTOUR.Text = TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR

                MyBase.BeginTransaction()

                Dim strSQL As String = SQL.TBL_SEIKYU.InsertSEIKYU_NO(TBL_SEIKYU(SEQ))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                '会合番号をキーに交通宿泊データに請求番号を登録(請求番号未設定のデータのみ)
                strSQL = SQL.TBL_KOTSUHOTEL.Update_SEIKYU_NO(Me.KOUENKAI_NO.Text, Me.SEIKYU_NO_TOPTOUR.Text, Session.Item(SessionDef.LoginID))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
                MyBase.Commit()


                '更新モードに切り替える
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update
                Me.KOUENKAI_NO.Enabled = False
                Me.SEISAN_YM.Enabled = False
            Catch ex As Exception
                MyBase.Rollback()

                'ログ登録
                MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
                Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            End Try
        Else
            Dim kensakuJoken As TableDef.Joken.DataStruct
            kensakuJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
            kensakuJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
            If Not AppModule.IsExist(SQL.TBL_KOTSUHOTEL.DrCsvCheck(kensakuJoken), MyBase.DbConnection) Then
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return False
            End If

            MyBase.BeginTransaction()

            Try
                '会合番号をキーに交通宿泊データに請求番号を登録(請求番号未設定のデータのみ)
                Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Update_SEIKYU_NO(Me.KOUENKAI_NO.Text, Me.SEIKYU_NO_TOPTOUR.Text, Session.Item(SessionDef.LoginID))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            Catch ex As Exception
                MyBase.Rollback()

                'ログ登録
                MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
                Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            End Try
            MyBase.Commit()
        End If

        Return True
    End Function

    '参加者一覧CSV出力
    Private Sub OutputDrCsv()

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetDrCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "SankashaIchiran.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.DrCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If
    End Sub

    '参加者一覧CSV用データ取得
    Private Function GetDrCsvData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim csvJoken As TableDef.Joken.DataStruct
        csvJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
        csvJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        strSQL = SQL.TBL_KOTSUHOTEL.DrCsv(csvJoken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

        Return True
    End Function

    'MR一覧CSV出力
    Private Sub OutputMrCsv()

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetMrCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "MRIchiran.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.MrCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If
    End Sub

    'MR一覧CSV用データ取得
    Private Function GetMrCsvData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim csvJoken As TableDef.Joken.DataStruct
        csvJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
        csvJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        strSQL = SQL.TBL_KOTSUHOTEL.MrCsv(csvJoken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

        Return True
    End Function

    'タクチケ発行テーブルに請求番号を登録
    Private Function UpdateTaxiData() As Boolean

        If Me.SEND_FLAG.SelectedValue <> AppConst.SEND_FLAG.Code.Mi Then
            'データ更新処理は行わない
            Return True
        End If

        '入力チェック
        If Not Check() Then Return False

        If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
            Dim kensakuJoken As TableDef.Joken.DataStruct
            kensakuJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
            If Not AppModule.IsExist(SQL.TBL_TAXITICKET_HAKKO.TaxiSeisanCsvCheck(kensakuJoken), MyBase.DbConnection) Then
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return False
            End If

            ''自動採番
            'Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)

            Try
                '請求データ(キー項目と送信フラグのみ)を登録する
                TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
                'TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
                TBL_SEIKYU(SEQ).SEISAN_YM = Me.SEISAN_YM.Text
                TBL_SEIKYU(SEQ).SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
                TBL_SEIKYU(SEQ).INPUT_USER = Session.Item(SessionDef.LoginID)
                TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

                Dim wRtn As Boolean = True
                'TOPTOUR請求番号が重複しなくなるまで最大値を取得し続ける
                Do Until wRtn = False
                    '自動採番
                    TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
                    wRtn = AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, _
                                                                                        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                                        MyBase.DbConnection)
                Loop

                MyBase.BeginTransaction()

                Dim strSQL As String = SQL.TBL_SEIKYU.InsertSEIKYU_NO(TBL_SEIKYU(SEQ))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                '会合番号をキーにタクチケ発行テーブルに請求番号、精算年月を登録(請求番号未設定のデータのみ)
                Dim updateData As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
                updateData.KOUENKAI_NO = Me.KOUENKAI_NO.Text
                updateData.TKT_SEIKYU_YM = Me.SEISAN_YM.Text
                updateData.SEIKYU_NO_TOPTOUR = TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR
                updateData.UPDATE_USER = Session.Item(SessionDef.LoginID)
                strSQL = SQL.TBL_TAXITICKET_HAKKO.Update_SEIKYU_NO_YM(updateData)
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                MyBase.Commit()

                Me.SEIKYU_NO_TOPTOUR.Text = TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR

                '更新モードに切り替える
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update
                Me.KOUENKAI_NO.Enabled = False
                Me.SEISAN_YM.Enabled = False
            Catch ex As Exception
                MyBase.Rollback()

                'ログ登録
                MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
                Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            End Try
        Else
            Dim kensakuJoken As TableDef.Joken.DataStruct
            kensakuJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
            kensakuJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
            If Not AppModule.IsExist(SQL.TBL_TAXITICKET_HAKKO.TaxiSeisanCsvCheck(kensakuJoken), MyBase.DbConnection) Then
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return False
            End If

            MyBase.BeginTransaction()

            Try
                '会合番号をキーにタクチケ発行テーブルに請求番号、精算年月を登録(請求番号未設定のデータのみ)
                Dim updateData As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
                updateData.KOUENKAI_NO = Me.KOUENKAI_NO.Text
                updateData.TKT_SEIKYU_YM = Me.SEISAN_YM.Text
                updateData.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
                updateData.UPDATE_USER = Session.Item(SessionDef.LoginID)
                Dim strSQL As String = SQL.TBL_TAXITICKET_HAKKO.Update_SEIKYU_NO_YM(updateData)
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            Catch ex As Exception
                MyBase.Rollback()

                'ログ登録
                MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist, TBL_SEIKYU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
                Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            End Try
            MyBase.Commit()
        End If

        Return True
    End Function

    'タクチケ精算データCSV出力
    Private Sub OutputTaxiCsv()

        Dim CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        If GetTaxiCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "TaxiSeisan.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.TaxiSeisanCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If
    End Sub

    'タクチケ精算データCSV出力用データ取得
    Private Function GetTaxiCsvData(ByRef CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim csvJoken As TableDef.Joken.DataStruct
        csvJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
        csvJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiSeisanCsv(csvJoken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

        Return True
    End Function

End Class