Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class KaijoReport

    Private pMS_USER As TableDef.MS_USER.DataStruct
    Public WriteOnly Property MS_USER() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pMS_USER = value
        End Set
    End Property

    Private pOldTBL_KAIJO As TableDef.TBL_KAIJO.DataStruct
    Public WriteOnly Property OldTBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
        Set(ByVal value As TableDef.TBL_KAIJO.DataStruct)
            pOldTBL_KAIJO = value
        End Set
    End Property

    Private pRireki As Boolean
    Public Property Rireki() As Boolean
        Get
            Return pRireki
        End Get
        Set(ByVal value As Boolean)
            pRireki = value
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        Me.LOGIN_USER_NAME.Text = pMS_USER.USER_NAME
    End Sub

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.BeforePrint
        Me.LabelPage.Text = "(" & Me.PageCount.Text & "/" & Me.PageTotal.Text & "ページ)"
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '差異のある項目の背景色を変更
        If pRireki = False AndAlso Trim(pOldTBL_KAIJO.KOUENKAI_NO) <> "" Then
            '履歴、新規登録時は除外
            SetChangedColor(Me.KOUENKAI_NAME, pOldTBL_KAIJO.KOUENKAI_NAME, Me.KOUENKAI_NAME.Text)
            SetChangedColor(Me.SEND_FLAG, pOldTBL_KAIJO.SEND_FLAG, Me.SEND_FLAG.Text)
            SetChangedColor(Me.REQ_STATUS_TEHAI, pOldTBL_KAIJO.REQ_STATUS_TEHAI, Me.REQ_STATUS_TEHAI.Text)
            SetChangedColor(Me.TIME_STAMP_BYL, pOldTBL_KAIJO.TIME_STAMP_BYL, Me.TIME_STAMP_BYL.Text)
            SetChangedColor(Me.USER_NAME, pOldTBL_KAIJO.USER_NAME, Me.USER_NAME.Text)
            SetChangedColor(Me.UPDATE_DATE, pOldTBL_KAIJO.UPDATE_DATE, Me.UPDATE_DATE.Text)
            SetChangedColor(Me.SHONIN_NAME, pOldTBL_KAIJO.SHONIN_NAME, Me.SHONIN_NAME.Text)
            SetChangedColor(Me.SHONIN_DATE, pOldTBL_KAIJO.SHONIN_DATE, Me.SHONIN_DATE.Text)
            SetChangedColor(Me.KAISAI_DATE_NOTE, pOldTBL_KAIJO.KAISAI_DATE_NOTE, Me.KAISAI_DATE_NOTE.Text)
            SetChangedColor(Me.KAISAI_KIBOU_ADDRESS1, pOldTBL_KAIJO.KAISAI_KIBOU_ADDRESS1, Me.KAISAI_KIBOU_ADDRESS1.Text)
            SetChangedColor(Me.KAISAI_KIBOU_ADDRESS2, pOldTBL_KAIJO.KAISAI_KIBOU_ADDRESS2, Me.KAISAI_KIBOU_ADDRESS2.Text)
            SetChangedColor(Me.KAISAI_KIBOU_NOTE, pOldTBL_KAIJO.KAISAI_KIBOU_NOTE, Me.KAISAI_KIBOU_NOTE.Text)
            SetChangedColor(Me.KOUEN_TIME1, pOldTBL_KAIJO.KOUEN_TIME1, Me.KOUEN_TIME1.Text)
            SetChangedColor(Me.KOUEN_TIME2, pOldTBL_KAIJO.KOUEN_TIME2, Me.KOUEN_TIME2.Text)
            SetChangedColor(Me.KOUEN_KAIJO_LAYOUT, pOldTBL_KAIJO.KOUEN_KAIJO_LAYOUT, Me.KOUEN_KAIJO_LAYOUT.Text)
            SetChangedColor(Me.IKENKOUKAN_KAIJO_TEHAI, pOldTBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI, Me.IKENKOUKAN_KAIJO_TEHAI.Text)
            SetChangedColor(Me.IROUKAI_KAIJO_TEHAI, pOldTBL_KAIJO.IROUKAI_KAIJO_TEHAI, Me.IROUKAI_KAIJO_TEHAI.Text)
            SetChangedColor(Me.IROUKAI_SANKA_YOTEI_CNT, pOldTBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT, Me.IROUKAI_SANKA_YOTEI_CNT.Text)
            SetChangedColor(Me.KOUSHI_ROOM_TEHAI, pOldTBL_KAIJO.KOUSHI_ROOM_TEHAI, Me.KOUSHI_ROOM_TEHAI.Text)
            SetChangedColor(Me.KOUSHI_ROOM_FROM, pOldTBL_KAIJO.KOUSHI_ROOM_FROM, Me.KOUSHI_ROOM_FROM.Text)
            SetChangedColor(Me.KOUSHI_ROOM_CNT, pOldTBL_KAIJO.KOUSHI_ROOM_CNT, Me.KOUSHI_ROOM_CNT.Text)
            SetChangedColor(Me.SHAIN_ROOM_TEHAI, pOldTBL_KAIJO.SHAIN_ROOM_TEHAI, Me.SHAIN_ROOM_TEHAI.Text)
            SetChangedColor(Me.MANAGER_KAIJO_TEHAI, pOldTBL_KAIJO.MANAGER_KAIJO_TEHAI, Me.MANAGER_KAIJO_TEHAI.Text)
            SetChangedColor(Me.MANAGER_ROOM_FROM, pOldTBL_KAIJO.MANAGER_ROOM_FROM, Me.MANAGER_ROOM_FROM.Text)
            SetChangedColor(Me.MANAGER_ROOM_CNT, pOldTBL_KAIJO.MANAGER_ROOM_CNT, Me.MANAGER_ROOM_CNT.Text)
            SetChangedColor(Me.REQ_ROOM_CNT, pOldTBL_KAIJO.REQ_ROOM_CNT, Me.REQ_ROOM_CNT.Text)
            SetChangedColor(Me.REQ_STAY_DATE, pOldTBL_KAIJO.REQ_STAY_DATE, Me.REQ_STAY_DATE.Text)
            SetChangedColor(Me.REQ_KOTSU_CNT, pOldTBL_KAIJO.REQ_KOTSU_CNT, Me.REQ_KOTSU_CNT.Text)
            SetChangedColor(Me.REQ_TAXI_CNT, pOldTBL_KAIJO.REQ_TAXI_CNT, Me.REQ_TAXI_CNT.Text)
            SetChangedColor(Me.OTHER_NOTE, pOldTBL_KAIJO.OTHER_NOTE, Me.OTHER_NOTE.Text)
        End If

        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(Me.KOUENKAI_NAME.Text)
        Me.SEND_FLAG.Text = AppModule.GetName_SEND_FLAG(Me.SEND_FLAG.Text)
        Me.TEHAI_ID.Text = AppModule.GetName_TEHAI_ID(Me.TEHAI_ID.Text)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUENKAI_NO.Text)
        Me.REQ_STATUS_TEHAI.Text = Me.REQ_STATUS_TEHAI.Text & ": " & AppModule.GetName_REQ_STATUS_TEHAI(Me.REQ_STATUS_TEHAI.Text, True)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(Me.TIME_STAMP_BYL.Text)
        Me.USER_NAME.Text = AppModule.GetName_USER_NAME(Me.USER_NAME.Text)
        Me.UPDATE_DATE.Text = AppModule.GetName_UPDATE_DATE(Me.UPDATE_DATE.Text)
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(Me.SHONIN_NAME.Text)
        Me.SHONIN_DATE.Text = AppModule.GetName_SHONIN_DATE(Me.SHONIN_DATE.Text)
        Me.KAISAI_DATE_NOTE.Text = AppModule.GetName_KAISAI_DATE_NOTE(Me.KAISAI_DATE_NOTE.Text)
        Me.KAISAI_KIBOU_ADDRESS1.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS1(Me.KAISAI_KIBOU_ADDRESS1.Text)
        Me.KAISAI_KIBOU_ADDRESS2.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS2(Me.KAISAI_KIBOU_ADDRESS2.Text)
        Me.KAISAI_KIBOU_NOTE.Text = AppModule.GetName_KAISAI_KIBOU_NOTE(Me.KAISAI_KIBOU_NOTE.Text)
        Me.KOUEN_TIME1.Text = AppModule.GetName_KOUEN_TIME1(Me.KOUEN_TIME1.Text)
        Me.KOUEN_TIME2.Text = AppModule.GetName_KOUEN_TIME2(Me.KOUEN_TIME2.Text)
        Me.KOUEN_KAIJO_LAYOUT.Text = Me.KOUEN_KAIJO_LAYOUT.Text & ": " & AppModule.GetName_KOUEN_KAIJO_LAYOUT(Me.KOUEN_KAIJO_LAYOUT.Text)
        Me.IKENKOUKAN_KAIJO_TEHAI.Text = AppModule.GetName_IKENKOUKAN_KAIJO_TEHAI(Me.IKENKOUKAN_KAIJO_TEHAI.Text)
        Me.IROUKAI_KAIJO_TEHAI.Text = AppModule.GetName_IROUKAI_KAIJO_TEHAI(Me.IROUKAI_KAIJO_TEHAI.Text)
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = AppModule.GetName_IROUKAI_SANKA_YOTEI_CNT(Me.IROUKAI_SANKA_YOTEI_CNT.Text)
        Me.KOUSHI_ROOM_TEHAI.Text = AppModule.GetName_KOUSHI_ROOM_TEHAI(Me.KOUSHI_ROOM_TEHAI.Text)
        Me.KOUSHI_ROOM_FROM.Text = AppModule.GetName_KOUSHI_ROOM_FROM(Me.KOUSHI_ROOM_FROM.Text)
        Me.KOUSHI_ROOM_CNT.Text = AppModule.GetName_KOUSHI_ROOM_CNT(Me.KOUSHI_ROOM_CNT.Text)
        Me.SHAIN_ROOM_TEHAI.Text = AppModule.GetName_SHAIN_ROOM_TEHAI(Me.SHAIN_ROOM_TEHAI.Text)
        Me.MANAGER_KAIJO_TEHAI.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI(Me.MANAGER_KAIJO_TEHAI.Text)
        Me.MANAGER_ROOM_FROM.Text = AppModule.GetName_MANAGER_ROOM_FROM(Me.MANAGER_ROOM_FROM.Text)
        Me.MANAGER_ROOM_CNT.Text = AppModule.GetName_MANAGER_ROOM_CNT(Me.MANAGER_ROOM_CNT.Text)
        Me.REQ_ROOM_CNT.Text = AppModule.GetName_REQ_ROOM_CNT(Me.REQ_ROOM_CNT.Text)
        Me.REQ_STAY_DATE.Text = AppModule.GetName_REQ_STAY_DATE(Me.REQ_STAY_DATE.Text)
        Me.REQ_KOTSU_CNT.Text = AppModule.GetName_REQ_KOTSU_CNT(Me.REQ_KOTSU_CNT.Text)
        Me.REQ_TAXI_CNT.Text = AppModule.GetName_REQ_TAXI_CNT(Me.REQ_TAXI_CNT.Text)
        Me.OTHER_NOTE.Text = AppModule.GetName_OTHER_NOTE(Me.OTHER_NOTE.Text)
    End Sub

    '差異
    Private Sub SetChangedColor(ByRef control As TextBox, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(220, 220, 220)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
    End Sub

End Class
