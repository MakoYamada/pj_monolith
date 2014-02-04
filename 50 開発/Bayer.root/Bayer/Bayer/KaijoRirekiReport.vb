Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class KaijoRirekiReport

    Private pMS_USER As TableDef.MS_USER.DataStruct
    Public WriteOnly Property MS_USER() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pMS_USER = value
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
        Me.LOGIN_USER_NAME.Text = pMS_USER.USER_NAME
        '会合名
        Me.JokenKOUENKAI_NO.Text = pJoken.KOUENKAI_NO
        Me.KOUENKAI_NAME.Text = pJoken.KOUENKAI_NAME
    End Sub

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.BeforePrint
        Me.LabelPage.Text = "(" & Me.PageCount.Text & "/" & Me.PageTotal.Text & "ページ)"
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Me.BU.Text = AppModule.GetName_BU(Me.BU.Text)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(Me.KIKAKU_TANTO_AREA.Text)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(Me.KIKAKU_TANTO_EIGYOSHO.Text)
        Me.FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(Me.FROM_DATE.Text, Me.TO_DATE.Text, True)
        Me.UPDATE_DATE.Text = AppModule.GetName_UPDATE_DATE(Me.UPDATE_DATE.Text)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(Me.TIME_STAMP_BYL.Text)
        Me.SEND_FLAG.Text = AppModule.GetName_SEND_FLAG(Me.SEND_FLAG.Text)
        Me.USER_NAME.Text = AppModule.GetName_USER_NAME(Me.USER_NAME.Text)
    End Sub

End Class
