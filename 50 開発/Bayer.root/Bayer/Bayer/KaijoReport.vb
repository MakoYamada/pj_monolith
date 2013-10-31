Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class KaijoReport 

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(Me.KOUENKAI_NAME.Text)
        Me.TEHAI_ID.Text = AppModule.GetName_TEHAI_ID(Me.TEHAI_ID.Text)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUENKAI_NO.Text)
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(Me.REQ_STATUS_TEHAI.Text)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(Me.TIME_STAMP_BYL.Text)
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(Me.SHONIN_NAME.Text)
        Me.SHONIN_DATE.Text = AppModule.GetName_SHONIN_DATE(Me.SHONIN_DATE.Text)
        Me.KAISAI_DATE_NOTE.Text = AppModule.GetName_KAISAI_DATE_NOTE(Me.KAISAI_DATE_NOTE.Text)
        Me.KAISAI_KIBOU_ADDRESS1.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS1(Me.KAISAI_KIBOU_ADDRESS1.Text)
        Me.KAISAI_KIBOU_ADDRESS2.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS2(Me.KAISAI_KIBOU_ADDRESS2.Text)
        Me.KAISAI_KIBOU_NOTE.Text = AppModule.GetName_KAISAI_KIBOU_NOTE(Me.KAISAI_KIBOU_NOTE.Text)
        Me.KOUEN_TIME1.Text = AppModule.GetName_KOUEN_TIME1(Me.KOUEN_TIME1.Text)
        Me.KOUEN_TIME2.Text = AppModule.GetName_KOUEN_TIME2(Me.KOUEN_TIME2.Text)
        Me.KOUEN_KAIJO_LAYOUT.Text = AppModule.GetName_KOUEN_KAIJO_LAYOUT(Me.KOUEN_KAIJO_LAYOUT.Text)
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

End Class
