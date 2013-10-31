Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class KaijoReport 
 
    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUENKAI_NAME.Text)
        Me.TEHAI_ID.Text = AppModule.GetName_KOUENKAI_NO(Me.TEHAI_ID.Text)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUENKAI_NO.Text)
        Me.REQ_STATUS_TEHAI.Text = Me.REQ_STATUS_TEHAI.Text & ":" & AppModule.GetName_KOUENKAI_NO(Me.REQ_STATUS_TEHAI.Text)
        Me.TIME_STAMP_TOP.Text = AppModule.GetName_KOUENKAI_NO(Me.TIME_STAMP_TOP.Text)
        Me.SHONIN_NAME.Text = AppModule.GetName_KOUENKAI_NO(Me.SHONIN_NAME.Text)
        Me.SHONIN_DATE.Text = AppModule.GetName_KOUENKAI_NO(Me.SHONIN_DATE.Text)
        Me.KAISAI_DATE_NOTE.Text = AppModule.GetName_KOUENKAI_NO(Me.KAISAI_DATE_NOTE.Text)
        Me.KAISAI_KIBOU_ADDRESS1.Text = AppModule.GetName_KOUENKAI_NO(Me.KAISAI_KIBOU_ADDRESS1.Text)
        Me.KAISAI_KIBOU_ADDRESS2.Text = AppModule.GetName_KOUENKAI_NO(Me.KAISAI_KIBOU_ADDRESS2.Text)
        Me.KAISAI_KIBOU_NOTE.Text = AppModule.GetName_KOUENKAI_NO(Me.KAISAI_KIBOU_NOTE.Text)
        Me.KOUEN_TIME1.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUEN_TIME1.Text)
        Me.KOUEN_TIME2.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUEN_TIME2.Text)
        Me.KOUEN_KAIJO_LAYOUT.Text = Me.KOUEN_KAIJO_LAYOUT.Text & ":" & AppModule.GetName_KOUENKAI_NO(Me.KOUEN_KAIJO_LAYOUT.Text)
        Me.IKENKOUKAN_KAIJO_TEHAI.Text = AppModule.GetName_KOUENKAI_NO(Me.IKENKOUKAN_KAIJO_TEHAI.Text)
        Me.IROUKAI_KAIJO_TEHAI.Text = AppModule.GetName_KOUENKAI_NO(Me.IROUKAI_KAIJO_TEHAI.Text)
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = AppModule.GetName_KOUENKAI_NO(Me.IROUKAI_SANKA_YOTEI_CNT.Text)
        Me.KOUSHI_ROOM_TEHAI.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUSHI_ROOM_TEHAI.Text)
        Me.KOUSHI_ROOM_FROM.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUSHI_ROOM_FROM.Text)
        Me.KOUSHI_ROOM_CNT.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUSHI_ROOM_CNT.Text)
        Me.SHAIN_ROOM_TEHAI.Text = AppModule.GetName_KOUENKAI_NO(Me.SHAIN_ROOM_TEHAI.Text)
        Me.MANAGER_KAIJO_TEHAI.Text = AppModule.GetName_KOUENKAI_NO(Me.MANAGER_KAIJO_TEHAI.Text)
        Me.MANAGER_ROOM_FROM.Text = AppModule.GetName_KOUENKAI_NO(Me.MANAGER_ROOM_FROM.Text)
        Me.MANAGER_ROOM_CNT.Text = AppModule.GetName_KOUENKAI_NO(Me.MANAGER_ROOM_CNT.Text)
        Me.REQ_ROOM_CNT.Text = AppModule.GetName_KOUENKAI_NO(Me.REQ_ROOM_CNT.Text)
        Me.REQ_STAY_DATE.Text = AppModule.GetName_KOUENKAI_NO(Me.REQ_STAY_DATE.Text)
        Me.REQ_KOTSU_CNT.Text = AppModule.GetName_KOUENKAI_NO(Me.REQ_KOTSU_CNT.Text)
        Me.REQ_TAXI_CNT.Text = AppModule.GetName_KOUENKAI_NO(Me.REQ_TAXI_CNT.Text)
        Me.OTHER_NOTE.Text = AppModule.GetName_KOUENKAI_NO(Me.OTHER_NOTE.Text)
    End Sub

End Class
