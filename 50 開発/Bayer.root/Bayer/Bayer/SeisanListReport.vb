Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class SeisanListReport

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
        Me.JokenKOUENKAI_NO.Text = pJoken.KOUENKAI_NO
        Me.JokenFROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(pJoken.FROM_DATE, pJoken.TO_DATE, True)

        Me.JokenKIKAKU_TANTO_ROMA.Text = pJoken.KIKAKU_TANTO_ROMA
        Me.JokenBU.Text = pJoken.BU
        Me.JokenKIKAKU_TANTO_AREA.Text = pJoken.AREA

        Me.JokenSEIKYU_NO_TOPTOUR.Text = pJoken.SEIKYU_NO_TOPTOUR
        Me.JokenSEISAN_YM.Text = pJoken.SEISAN_YM
        Me.JokenSHOUNIN_KUBUN.Text = pJoken.SHOUNIN_KUBUN
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
        Me.SEISAN_YM.Text = AppModule.GetName_SEISAN_YM(Me.SEISAN_YM.Text)
        Me.SHOUNIN_KUBUN.Text = AppModule.GetName_SHOUNIN_KUBUN(Me.SHOUNIN_KUBUN.Text)
        Me.SEND_FLAG.Text = AppModule.GetName_SEND_FLAG(Me.SEND_FLAG.Text, True)

    End Sub
End Class
