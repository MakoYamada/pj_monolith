Imports CommonLib
Imports AppLib
Partial Public Class SeisanRegist
    Inherits WebBase

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

        If MyModule.IsInsertMode() Then
            '新規登録
            'キー項目入力可
            Me.KOUENKAI_NO.Enabled = True
        Else
            Me.KOUENKAI_NO.Enabled = False
        End If

        'クリア
        CmnModule.ClearAllControl(Me)
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

        If CmnCheck.IsInput(Me.KOUENKAI_NO) AndAlso CmnCheck.IsInput(Me.SEIKYU_NO_TOPTOUR) Then
            '登録済みのデータのとき

            SetFormFirst(Not AppModule.IsExist( _
                         SQL.TBL_SEIKYU.byKOUENKAI_NO_LESS_THAN_SEIKYU_NO_TOPTOUR( _
                            TBL_SEIKYU(SEQ).KOUENKAI_NO, TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), MyBase.DbConnection))
        End If

    End Sub

    '画面入力可/不可の制御
    'isFirst:True  1講演会に対して1回目の精算データのとき
    '       :False 1講演会に対して2回目以降の精算データのとき
    Private Sub SetFormFirst(ByVal isFirst As Boolean)

        CmnModule.SetEnabled(Me.KAIJOHI_TF, isFirst)
        CmnModule.SetEnabled(Me.KIZAIHI_TF, isFirst)
        CmnModule.SetEnabled(Me.INSHOKUHI_TF, isFirst)

        CmnModule.SetEnabled(Me.HOTELHI_TF, isFirst)
        CmnModule.SetEnabled(Me.HOTELHI_TOZEI, isFirst)
        CmnModule.SetEnabled(Me.JR_TF, isFirst)
        CmnModule.SetEnabled(Me.AIR_TF, isFirst)
        CmnModule.SetEnabled(Me.OTHER_TRAFFIC_TF, isFirst)
        CmnModule.SetEnabled(Me.TAXI_COMMISSION_TF, isFirst)
        CmnModule.SetEnabled(Me.HOTEL_COMMISSION_TF, isFirst)
        CmnModule.SetEnabled(Me.JINKENHI_TF, isFirst)
        CmnModule.SetEnabled(Me.OTHER_TF, isFirst)
        CmnModule.SetEnabled(Me.KANRIHI_TF, isFirst)
        CmnModule.SetEnabled(Me.TAXI_TF, isFirst)
        CmnModule.SetEnabled(Me.TAXI_SEISAN_TF, isFirst)

        CmnModule.SetEnabled(Me.KAIJOUHI_T, isFirst)
        CmnModule.SetEnabled(Me.KIZAIHI_T, isFirst)
        CmnModule.SetEnabled(Me.INSHOKUHI_T, isFirst)

        CmnModule.SetEnabled(Me.JINKENHI_T, isFirst)
        CmnModule.SetEnabled(Me.OTHER_T, isFirst)
        CmnModule.SetEnabled(Me.KANRIHI_T, isFirst)

        CmnModule.SetEnabled(Me.MR_HOTEL, isFirst)
        CmnModule.SetEnabled(Me.MR_HOTEL_TOZEI, isFirst)
        CmnModule.SetEnabled(Me.MR_JR, isFirst)
        CmnModule.SetEnabled(Me.SEISANSHO_URL, isFirst)

        CmnModule.SetEnabled(Me.TAXI_T, Not isFirst)
        CmnModule.SetEnabled(Me.TAXI_SEISAN_T, Not isFirst)
        CmnModule.SetEnabled(Me.TAXI_TICKET_URL, Not isFirst)
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


    Private Function Check_First(ByVal isFirst As Boolean) As Boolean
        If isFirst Then
            '1講演会に対して1回目の精算データのときの入力チェック
            '入力されていたらNG
            If CmnCheck.IsInput(Me.TAXI_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.TAXI_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.TAXI_SEISAN_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.TAXI_SEISAN_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.TAXI_TICKET_URL.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.TAXI_TICKET_URL), Me)
                Return False
            End If
        Else
            '1講演会に対して2回目以降の精算データのときの入力チェック
            '入力されていたらNG
            If CmnCheck.IsInput(Me.KAIJOHI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.KAIJOHI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.KIZAIHI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.KIZAIHI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.INSHOKUHI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.INSHOKUHI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.HOTELHI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.HOTELHI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.HOTELHI_TOZEI.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.HOTELHI_TOZEI), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.JR_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.JR_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.AIR_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.AIR_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.OTHER_TRAFFIC_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.OTHER_TRAFFIC_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.TAXI_COMMISSION_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.TAXI_COMMISSION_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.HOTEL_COMMISSION_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.HOTEL_COMMISSION_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.JINKENHI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.JINKENHI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.OTHER_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.OTHER_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.KANRIHI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.KANRIHI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.TAXI_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.TAXI_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.TAXI_SEISAN_TF.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.TAXI_SEISAN_TF), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.KAIJOUHI_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.KAIJOUHI_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.KIZAIHI_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.KIZAIHI_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.INSHOKUHI_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.INSHOKUHI_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.JINKENHI_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.JINKENHI_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.OTHER_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.OTHER_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.KANRIHI_T.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.KANRIHI_T), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.MR_HOTEL.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.MR_HOTEL), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.MR_HOTEL_TOZEI.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.MR_HOTEL_TOZEI), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.MR_JR.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.MR_JR), Me)
                Return False
            End If

            If CmnCheck.IsInput(Me.SEISANSHO_URL.Text) Then
                CmnModule.AlertMessage(MessageDef.Error.MustNotInput(TableDef.TBL_SEIKYU.Name.SEISANSHO_URL), Me)
                Return False
            End If
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
    Private Function ExecuteTransaction() As Boolean

        If MyModule.IsInsertMode() Then
            '新規登録
            If AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                            MyBase.DbConnection) Then
                CmnModule.AlertMessage(MessageDef.Error.IsRegistered(TableDef.TBL_SEIKYU.Name.KOUENKAI_NO & ":" & TBL_SEIKYU(SEQ).KOUENKAI_NO & "\n" & _
                                                                     TableDef.TBL_SEIKYU.Name.SEIKYU_NO_TOPTOUR & ":" & TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR & "\nのデータ"), Me)
                Return False
            End If
            If AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_LESS_THAN_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                            MyBase.DbConnection) Then
                '1講演会に対して2回目以降の精算データのとき
                If Not Check_First(False) Then
                    Return False
                End If
            Else
                '1講演会に対して1回目の精算データのとき
                If Not Check_First(True) Then
                    Return False
                End If
            End If

            Return InsertData()
        Else
            '更新
            If AppModule.IsExist(SQL.TBL_SEIKYU.byKOUENKAI_NO_LESS_THAN_SEIKYU_NO_TOPTOUR(TBL_SEIKYU(SEQ).KOUENKAI_NO, TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR), _
                                                                            MyBase.DbConnection) Then
                '1講演会に対して2回目以降の精算データのとき
                If Not Check_First(False) Then
                    Return False
                End If
            Else
                '1講演会に対して1回目の精算データのとき
                If Not Check_First(True) Then
                    Return False
                End If
            End If
            Return UpdateData()
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

            Return True
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
            '自動採番
            Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
        End If

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
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
            '自動採番
            Me.SEIKYU_NO_TOPTOUR.Text = MyModule.GetMaxSEISAN_NO(MyBase.DbConnection)
        End If

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If ExecuteTransaction() Then
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

End Class