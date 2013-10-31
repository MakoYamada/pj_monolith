Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class DrReport4

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        REQ_STATUS_TEHAI.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI.Text)
        TIME_STAMP_BYL.Text = CmnModule.Format_Date(TIME_STAMP_BYL.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        REQ_MR_O_TEHAI.Text = AppModule.GetName_REQ_MR_O_TEHAI(REQ_MR_O_TEHAI.Text)
        REQ_MR_F_TEHAI.Text = AppModule.GetName_REQ_MR_F_TEHAI(REQ_MR_F_TEHAI.Text)
        MR_SEX.Text = AppModule.GetName_MR_SEX(MR_SEX.Text)
    End Sub

End Class
