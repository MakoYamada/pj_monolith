Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class NewKaijoListReport

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        Me.LOGIN_USER_NAME.Text = "ログイン者名"
        ''''''CType(System.Web.HttpContext.Current.Session.Item("LoginUser"), 頓挫中
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Me.BU.Text = AppModule.GetName_BU(Me.BU.Text)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(Me.KIKAKU_TANTO_AREA.Text)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(Me.KIKAKU_TANTO_EIGYOSHO.Text)
        Me.FROM_DATE.TEXT = AppModule.GetName_KOUENKAI_DATE(Me.FROM_DATE.TEXT, Me.TO_DATE.TEXT, True)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(Me.KOUENKAI_NAME.Text)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(Me.TIME_STAMP_BYL.Text)
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(Me.REQ_STATUS_TEHAI.Text)
        Me.USER_NAME.Text = AppModule.GetName_USER_NAME(Me.USER_NAME.Text)
    End Sub

End Class
