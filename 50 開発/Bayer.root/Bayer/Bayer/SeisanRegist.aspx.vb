﻿Imports CommonLib
Imports AppLib
Partial Public Class SeisanRegist
    Inherits WebBase

    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private SEQ As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化            InitControls()

            If MyModule.IsInsertMode() Then
                Session.Remove(SessionDef.TBL_SEIKYU)
                Session.Remove(SessionDef.SEQ)
            Else
                '画面項目表示
                SetForm()
            End If
        End If

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True
            .PageTitle = "精算金額入力"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_SEIKYU = Session.Item(SessionDef.TBL_SEIKYU)
        Catch ex As Exception
            Return False
        End Try
        Try
            SEQ = Session.Item(SessionDef.SEQ)
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'IME設定        CmnModule.SetIme(Me.KOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KAIJOHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KIZAIHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.INSHOKUHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.HOTELHI_TF, CmnModule.ImeType.Disabled)
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
        CmnModule.SetIme(Me.SEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_SEISAN_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISANSHO_URL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TAXI_TICKET_URL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEISAN_KANRYO, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.MR_JR, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.MR_HOTEL, CmnModule.ImeType.Disabled)

        If MyModule.IsInsertMode() Then
            '新規登録
            'キー項目入力可
            Me.KOUENKAI_NO.Enabled = True
            Me.SEIKYU_NO_TOPTOUR.Enabled = True
        Else
            Me.KOUENKAI_NO.Enabled = False
            Me.SEIKYU_NO_TOPTOUR.Enabled = False
        End If

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()

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
        Me.SEISAN_KANRYO.Text = TBL_SEIKYU(SEQ).SEISAN_KANRYO
        Me.MR_JR.Text = TBL_SEIKYU(SEQ).MR_JR
        Me.MR_HOTEL.Text = TBL_SEIKYU(SEQ).MR_HOTEL
    End Sub

    Private Sub CalculateKingaku()

        Dim wTOTAL_TF1 As Integer = 0
        Dim wTOTAL_TF2 As Integer = 0
        Dim wTOTAL_T1 As Integer = 0
        Dim wTOTAL_T2 As Integer = 0

        Try
            '991330401
            wTOTAL_TF1 = CmnModule.DbVal(Me.KAIJOHI_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.KIZAIHI_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.INSHOKUHI_TF.Text.Trim)

            Me.KEI_991330401_TF.Text = CmnModule.EditComma(wTOTAL_TF1.ToString)

            '41120200
            wTOTAL_TF2 = CmnModule.DbVal(Me.HOTELHI_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.JR_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.AIR_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.OTHER_TRAFFIC_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.TAXI_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.HOTEL_COMMISSION_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.TAXI_COMMISSION_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.TAXI_SEISAN_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.JINKENHI_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.OTHER_TF.Text.Trim) + _
                         CmnModule.DbVal(Me.KANRIHI_TF.Text.Trim)

            Me.KEI_41120200_TF.Text = CmnModule.EditComma(wTOTAL_TF2.ToString)

            '非課税金額合計
            Me.KEI_TF.Text = CmnModule.EditComma(CStr(wTOTAL_TF1 + wTOTAL_TF2))


            '991330401
            wTOTAL_T1 = CmnModule.DbVal(Me.KAIJOUHI_T.Text.Trim) + _
                         CmnModule.DbVal(Me.KIZAIHI_T.Text.Trim) + _
                         CmnModule.DbVal(Me.INSHOKUHI_T.Text.Trim)

            Me.KEI_991330401_T.Text = CmnModule.EditComma(wTOTAL_T1.ToString)

            '41120200
            wTOTAL_T2 = CmnModule.DbVal(Me.JINKENHI_T.Text.Trim) + _
                         CmnModule.DbVal(Me.OTHER_T.Text.Trim) + _
                         CmnModule.DbVal(Me.KANRIHI_T.Text.Trim)

            Me.KEI_41120200_T.Text = CmnModule.EditComma(wTOTAL_T2.ToString)

            '課税金額合計
            Me.KEI_T.Text = CmnModule.EditComma(CStr(wTOTAL_T1 + wTOTAL_T2))

        Catch ex As Exception
        End Try

    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '必須入力
        If Not CmnCheck.IsInput(Me.KOUENKAI_NO) AndAlso _
           Not CmnCheck.IsInput(Me.SEIKYU_NO_TOPTOUR) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_SEIKYU.Name.KOUENKAI_NO & "、" & _
                                                              TableDef.TBL_SEIKYU.Name.SEIKYU_NO_TOPTOUR), Me)
            Return False
        End If

        '数値チェック
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

        Return True
    End Function

    '入力値を取得    Private Sub GetValue(ByVal SEND_FLAG As String)

        TBL_SEIKYU(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO.Text
        TBL_SEIKYU(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text

        TBL_SEIKYU(SEQ).KAIJOHI_TF = Me.KAIJOHI_TF.Text
        TBL_SEIKYU(SEQ).KIZAIHI_TF = Me.KIZAIHI_TF.Text
        TBL_SEIKYU(SEQ).INSHOKUHI_TF = Me.INSHOKUHI_TF.Text
        TBL_SEIKYU(SEQ).KEI_991330401_TF = Me.KEI_991330401_TF.Text

        TBL_SEIKYU(SEQ).HOTELHI_TF = Me.HOTELHI_TF.Text
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
        TBL_SEIKYU(SEQ).KEI_41120200_TF = Me.KEI_41120200_TF.Text
        TBL_SEIKYU(SEQ).KEI_TF = Me.KEI_TF.Text

        TBL_SEIKYU(SEQ).KAIJOUHI_T = Me.KAIJOUHI_T.Text
        TBL_SEIKYU(SEQ).KIZAIHI_T = Me.KIZAIHI_T.Text
        TBL_SEIKYU(SEQ).INSHOKUHI_T = Me.INSHOKUHI_T.Text
        TBL_SEIKYU(SEQ).KEI_991330401_T = Me.KEI_991330401_T.Text

        TBL_SEIKYU(SEQ).JINKENHI_T = Me.JINKENHI_T.Text
        TBL_SEIKYU(SEQ).OTHER_T = Me.OTHER_T.Text
        TBL_SEIKYU(SEQ).KANRIHI_T = Me.KANRIHI_T.Text
        TBL_SEIKYU(SEQ).KEI_41120200_T = Me.KEI_41120200_T.Text
        TBL_SEIKYU(SEQ).KEI_T = Me.KEI_T.Text

        TBL_SEIKYU(SEQ).SEISAN_YM = Me.SEISAN_YM.Text
        TBL_SEIKYU(SEQ).TAXI_T = Me.TAXI_T.Text
        TBL_SEIKYU(SEQ).TAXI_SEISAN_T = Me.TAXI_SEISAN_T.Text
        TBL_SEIKYU(SEQ).SEISANSHO_URL = Me.SEISANSHO_URL.Text
        TBL_SEIKYU(SEQ).TAXI_TICKET_URL = Me.TAXI_TICKET_URL.Text
        TBL_SEIKYU(SEQ).SEISAN_KANRYO = Me.SEISAN_KANRYO.Text
        TBL_SEIKYU(SEQ).MR_JR = Me.MR_JR.Text
        TBL_SEIKYU(SEQ).MR_HOTEL = Me.MR_HOTEL.Text

        TBL_SEIKYU(SEQ).SEND_FLAG = SEND_FLAG
        TBL_SEIKYU(SEQ).INPUT_USER = Session.Item(SessionDef.LoginID)
        TBL_SEIKYU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)
    End Sub

    'データ更新
    Private Function ExecuteTransaction() As Boolean

        If MyModule.IsInsertMode() Then
            '新規登録
            Return InsertData()
        Else
            '更新
            Return UpdateData()
        End If

    End Function

    'データ新規登録
    Private Function InsertData() As Boolean
        Dim strSQL As String

        'TODO:T_LOG

        MyBase.BeginTransaction()
        Try
            'データ登録
            strSQL = SQL.TBL_SEIKYU.Insert(TBL_SEIKYU(SEQ))
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

    'データ更新
    Private Function UpdateData() As Boolean
        Dim strSQL As String

        'TODO:T_LOG

        MyBase.BeginTransaction()
        Try
            'データ更新
            strSQL = SQL.TBL_SEIKYU.Update(TBL_SEIKYU(SEQ))
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

    '[再計算]
    Private Sub BtnCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCalc.Click
        CalculateKingaku()
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click

        '入力チェック
        If Not Check() Then Exit Sub

        CalculateKingaku()

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
            'TODO:メッセージ出して画面遷移？
        End If

    End Sub

    '[NOZOMIへ]
    Private Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNozomi.Click

        '入力チェック
        If Not Check() Then Exit Sub

        CalculateKingaku()

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If ExecuteTransaction() Then
            'TODO:メッセージ？
        End If
    End Sub

    '[キャンセル]
    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Response.Redirect(URL.SeisanList)
    End Sub
End Class