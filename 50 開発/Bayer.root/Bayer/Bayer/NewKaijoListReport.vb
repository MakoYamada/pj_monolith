Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class NewKaijoListReport

    Private pLoginUser As TableDef.MS_USER.DataStruct
    Public WriteOnly Property LoginUser() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pLoginUser = value
        End Set
    End Property

    Private pJoken As TableDef.Joken.DataStruct
    Public WriteOnly Property Joken() As TableDef.Joken.DataStruct
        Set(ByVal value As TableDef.Joken.DataStruct)
            pJoken = value
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        Me.LOGIN_USER_NAME.Text = pLoginUser.USER_NAME
        '条件
    End Sub

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.BeforePrint
        Me.LabelPage.Text = "(" & Me.PageCount.Text & "/" & Me.PageTotal.Text & "ページ)"
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Me.BU.Text = AppModule.GetName_BU(Me.BU.Text)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(Me.KIKAKU_TANTO_AREA.Text)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(Me.KIKAKU_TANTO_EIGYOSHO.Text)
        Me.FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(Me.FROM_DATE.Text, Me.TO_DATE.Text, True)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(Me.KOUENKAI_NAME.Text)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(Me.TIME_STAMP_BYL.Text)
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(Me.REQ_STATUS_TEHAI.Text)
        Me.USER_NAME.Text = AppModule.GetName_USER_NAME(Me.USER_NAME.Text)
    End Sub

End Class
