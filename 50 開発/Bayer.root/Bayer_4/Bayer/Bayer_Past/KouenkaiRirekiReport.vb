Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports CommonLib
Imports AppLib

Public Class KouenkaiRirekiReport

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If Len(BU.Text) > 20 Then BU.Text = Left(BU.Text, 20)
        If Len(KIKAKU_TANTO_AREA.Text) > 20 Then KIKAKU_TANTO_AREA.Text = Left(KIKAKU_TANTO_AREA.Text, 20)
        If Len(KIKAKU_TANTO_EIGYOSHO.Text) > 20 Then KIKAKU_TANTO_EIGYOSHO.Text = Left(KIKAKU_TANTO_EIGYOSHO.Text, 20)
        If Len(USER_NAME.Text) > 20 Then USER_NAME.Text = Left(USER_NAME.Text, 20)

        '開催日
        FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(FROM_DATE.Text, TO_DATE.Text, True)

        'TimeStamp
        TIME_STAMP.Text = _
            CmnModule.Format_Date(TIME_STAMP.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)

        '更新日
        UPDATE_DATE.Text = _
            CmnModule.Format_Date(UPDATE_DATE.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)

    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub
End Class
