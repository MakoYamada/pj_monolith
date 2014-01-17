Imports CommonLib
Imports AppLib
Partial Public Class SeisanRegist
    Inherits WebBase

    Private Joken As TableDef.Joken.DataStruct
    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private SEQ As Integer

    Private Sub SeisanRegist_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_SEIKYU) = TBL_SEIKYU
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        AppModule.SetDropDownList_SEND_FLAG(Me.SEND_FLAG)
        CmnModule.SetEnabled(Me.SEND_FLAG, False)

        'クリア
        CmnModule.ClearAllControl(Me)

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
        AppModule.SetForm_SEISAN_KANRYO(TBL_SEIKYU(SEQ).SEISAN_KANRYO, Me.SEISAN_KANRYO)
        Me.MR_JR.Text = TBL_SEIKYU(SEQ).MR_JR
        Me.MR_HOTEL.Text = TBL_SEIKYU(SEQ).MR_HOTEL
        Me.MR_HOTEL_TOZEI.Text = TBL_SEIKYU(SEQ).MR_HOTEL_TOZEI
    End Sub

    Private Sub CalculateKingaku()

        Dim wTOTAL_TF1 As Long = 0
        Dim wTOTAL_TF2 As Long = 0
        Dim wTOTAL_T1 As Long = 0
        Dim wTOTAL_T2 As Long = 0

        Try
            '991330401
            wTOTAL_TF1 = CLng(AppModule.GetName_ANS_991330401_TF(Me.KAIJOHI_TF.Text.Trim, Me.KIZAIHI_TF.Text.Trim, Me.INSHOKUHI_TF.Text.Trim, True))

            '41120200
            wTOTAL_TF2 = CLng(AppModule.GetName_ANS_41120200_TF(CStr(CmnModule.DbVal(Me.HOTELHI_TF.Text.Trim) + CmnModule.DbVal(Me.HOTELHI_TOZEI.Text.Trim)), _
                                                                Me.JR_TF.Text.Trim, _
                                                                Me.AIR_TF.Text.Trim, _
                                                                Me.OTHER_TRAFFIC_TF.Text.Trim, _
                                                                Me.TAXI_TF.Text.Trim, _
                                                                Me.HOTEL_COMMISSION_TF.Text.Trim, _
                                                                Me.TAXI_COMMISSION_TF.Text.Trim, _
                                                                Me.TAXI_SEISAN_TF.Text.Trim, _
                                                                Me.JINKENHI_TF.Text.Trim, _
                                                                Me.OTHER_TF.Text.Trim, _
                                                                Me.KANRIHI_TF.Text.Trim, True))

            '991330401
            wTOTAL_T1 = CLng(AppModule.GetName_ANS_991330401_T(Me.KAIJOUHI_T.Text.Trim, Me.KIZAIHI_T.Text.Trim, Me.INSHOKUHI_T.Text.Trim, True))

            '41120200
            wTOTAL_T2 = CLng(AppModule.GetName_ANS_41120200_T(Me.JINKENHI_T.Text.Trim, Me.OTHER_T.Text.Trim, Me.KANRIHI_T.Text.Trim, True))

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


        If Not CmnCheck.IsNumberOnly(Me.TAXI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.TAXI_SEISAN_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_SEISAN_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.MR_JR) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.MR_JR), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.MR_HOTEL) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.MR_HOTEL), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.MR_HOTEL_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.MR_HOTEL_TOZEI), Me)
            Return False
        End If

        Return True
    End Function

    '集計対象項目の数値チェック
    Private Function CheckCalcItem() As Boolean

        If Not CmnCheck.IsNumberOnly(Me.KAIJOHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KAIJOHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.KIZAIHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KIZAIHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.INSHOKUHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.INSHOKUHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.HOTELHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.HOTELHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.HOTELHI_TOZEI), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JR_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.JR_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.AIR_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.AIR_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.OTHER_TRAFFIC_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.OTHER_TRAFFIC_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.TAXI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.HOTEL_COMMISSION_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.HOTEL_COMMISSION_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.TAXI_COMMISSION_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_COMMISSION_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.TAXI_SEISAN_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.TAXI_SEISAN_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JINKENHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.JINKENHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.OTHER_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.OTHER_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.KANRIHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KANRIHI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.KAIJOUHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KAIJOUHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.KIZAIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KIZAIHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.INSHOKUHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.INSHOKUHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JINKENHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.JINKENHI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.OTHER_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.OTHER_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.KANRIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.KANRIHI_T), Me)
            Return False
        End If

        Return True
    End Function

    '入力値を取得    Private Sub GetValue(ByVal SEND_FLAG As String)

        TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text

        TBL_SEIKYU(SEQ).KAIJOHI_TF = Me.KAIJOHI_TF.Text
        TBL_SEIKYU(SEQ).KIZAIHI_TF = Me.KIZAIHI_TF.Text
        TBL_SEIKYU(SEQ).INSHOKUHI_TF = Me.INSHOKUHI_TF.Text
        TBL_SEIKYU(SEQ).KEI_991330401_TF = Me.KEI_991330401_TF.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).HOTELHI_TF = Me.HOTELHI_TF.Text
        TBL_SEIKYU(SEQ).HOTELHI_TOZEI = Me.HOTELHI_TOZEI.Text
        TBL_SEIKYU(SEQ).JR_TF = Me.JR_TF.Text
        TBL_SEIKYU(SEQ).AIR_TF = Me.AIR_TF.Text
        TBL_SEIKYU(SEQ).OTHER_TRAFFIC_TF = Me.OTHER_TRAFFIC_TF.Text
        TBL_SEIKYU(SEQ).TAXI_TF = Me.TAXI_TF.Text
        TBL_SEIKYU(SEQ).HOTEL_COMMISSION_TF = Me.HOTEL_COMMISSION_TF.Text
        TBL_SEIKYU(SEQ).TAXI_COMMISSION_TF = Me.TAXI_COMMISSION_TF.Text
        TBL_SEIKYU(SEQ).TAXI_SEISAN_TF = Me.TAXI_SEISAN_TF.Text
        TBL_SEIKYU(SEQ).JINKENHI_TF = Me.JINKENHI_TF.Text
        TBL_SEIKYU(SEQ).OTHER_TF = Me.OTHER_TF.Text
        TBL_SEIKYU(SEQ).KANRIHI_TF = Me.KANRIHI_TF.Text
        TBL_SEIKYU(SEQ).KEI_41120200_TF = Me.KEI_41120200_TF.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_TF = Me.KEI_TF.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).KAIJOUHI_T = Me.KAIJOUHI_T.Text
        TBL_SEIKYU(SEQ).KIZAIHI_T = Me.KIZAIHI_T.Text
        TBL_SEIKYU(SEQ).INSHOKUHI_T = Me.INSHOKUHI_T.Text
        TBL_SEIKYU(SEQ).KEI_991330401_T = Me.KEI_991330401_T.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).JINKENHI_T = Me.JINKENHI_T.Text
        TBL_SEIKYU(SEQ).OTHER_T = Me.OTHER_T.Text
        TBL_SEIKYU(SEQ).KANRIHI_T = Me.KANRIHI_T.Text
        TBL_SEIKYU(SEQ).KEI_41120200_T = Me.KEI_41120200_T.Text.Replace(",", "")
        TBL_SEIKYU(SEQ).KEI_T = Me.KEI_T.Text.Replace(",", "")

        TBL_SEIKYU(SEQ).SEISAN_YM = Me.SEISAN_YM.Text
        TBL_SEIKYU(SEQ).TAXI_T = Me.TAXI_T.Text
        TBL_SEIKYU(SEQ).TAXI_SEISAN_T = Me.TAXI_SEISAN_T.Text
        TBL_SEIKYU(SEQ).SEISANSHO_URL = Me.SEISANSHO_URL.Text
        TBL_SEIKYU(SEQ).TAXI_TICKET_URL = Me.TAXI_TICKET_URL.Text
        TBL_SEIKYU(SEQ).SEISAN_KANRYO = AppModule.GetValue_SEISAN_KANRYO(Me.SEISAN_KANRYO)
        TBL_SEIKYU(SEQ).MR_JR = Me.MR_JR.Text
        TBL_SEIKYU(SEQ).MR_HOTEL = Me.MR_HOTEL.Text
        TBL_SEIKYU(SEQ).MR_HOTEL_TOZEI = Me.MR_HOTEL_TOZEI.Text

        TBL_SEIKYU(SEQ).SEND_FLAG = SEND_FLAG
        TBL_SEIKYU(SEQ).INPUT_USER = Session.Item(SessionDef.LoginID)
        TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)
    End Sub

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

            Return True
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

        If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
            'TODO:要確認
            CmnModule.AlertMessage("先に参加者一覧CSVまたはMR一覧CSVを出力してください。", Me)
            Exit Sub
        End If

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If UpdateData() Then
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

        If Me.SEIKYU_NO_TOPTOUR.Text = "" Then
            'TODO:要確認
            CmnModule.AlertMessage("先に参加者一覧CSVまたはMR一覧CSVを出力してください。", Me)
            Exit Sub
        End If

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If UpdateData() Then
            Response.Redirect(URL.SeisanRegist & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '[印刷]
    Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click, BtnPrint2.Click

        If Not CmnCheck.IsInput(Me.SEIKYU_NO_TOPTOUR) Then
            '精算番号が自動採番されていないとき(=DBへ登録されていない)
            CmnModule.AlertMessage("印刷対象となるデータが登録されていません。", Me)
            Exit Sub
        End If

        Dim strSQL As String = SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(Me.KOUENKAI_NO.Text, Me.SEIKYU_NO_TOPTOUR.Text)
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
        If Not FixSeikyuNo() Then
            Exit Sub
        End If

        '非表示ボタンをクリック(画面再表示の為)
        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType, "click", "<script language=javascript>document.getElementById('" + BtnDrCsvHid.ClientID + "').click();</script>")
    End Sub
    Protected Sub BtnDrCsvHid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDrCsvHid.Click
        OutputDrCsv()
    End Sub

    '[MR一覧CSV作成]
    Protected Sub BtnMrCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMrCsv.Click
        If Not FixSeikyuNo() Then
            Exit Sub
        End If
        '非表示ボタンをクリック(画面再表示の為)
        Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType, "click", "<script language=javascript>document.getElementById('" + BtnMrCsvHid.ClientID + "').click();</script>")
    End Sub
    Protected Sub BtnMrCsvHid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMrCsvHid.Click
        OutputMrCsv()
    End Sub

    '[タクチケ精算データCSV作成]
    Protected Sub BtnTaxiCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiCsv.Click
        UpdateTaxiData()
        'OutputTaxiCsv()
    End Sub

    '請求番号採番、精算番号を交通宿泊データに登録、請求データ作成
    Private Function FixSeikyuNo() As Boolean

        '入力チェック
        If Not Check() Then Exit Function

        If Me.SEIKYU_NO_TOPTOUR.Text = "" Then

            Try
                '自動採番
                Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)

                MyBase.BeginTransaction()

                '講演会番号をキーに交通宿泊データに請求番号を登録(請求番号未設定のデータのみ)
                'データ更新
                Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Update_SEIKYU_NO(Me.KOUENKAI_NO.Text, Me.SEIKYU_NO_TOPTOUR.Text, Session.Item(SessionDef.LoginID))
                Dim cnt As Integer = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                ''TODO:更新対象データがないときは？
                'If cnt = 0 Then
                '    Exit Function
                'End If

                '請求データを登録する
                '入力値を取得
                GetValue(AppConst.SEND_FLAG.Code.Mi)

                'データ登録
                strSQL = SQL.TBL_SEIKYU.Insert(TBL_SEIKYU(SEQ))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            Catch ex As Exception
                MyBase.Rollback()

                'エラーメッセージ
                Exit Function
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
        strSQL = SQL.TBL_SEIKYU.DrCsv(csvJoken)
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

        Dim CsvData() As TableDef.TBL_SEIKYU.DataStruct
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
    Private Function GetMrCsvData(ByRef CsvData() As TableDef.TBL_SEIKYU.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim csvJoken As TableDef.Joken.DataStruct
        csvJoken.KOUENKAI_NO = Me.KOUENKAI_NO.Text
        csvJoken.SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
        strSQL = SQL.TBL_SEIKYU.MrCsv(csvJoken)
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

    '
    Private Function UpdateTaxiData() As Boolean

    End Function
End Class