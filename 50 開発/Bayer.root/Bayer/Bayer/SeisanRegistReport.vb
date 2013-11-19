Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class SeisanRegistReport

    Private pLoginUser As TableDef.MS_USER.DataStruct
    Public WriteOnly Property LoginUser() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pLoginUser = value
        End Set
    End Property

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.BeforePrint
        Me.LabelPage.Text = "(" & Me.PageCount.Text & "/" & Me.PageTotal.Text & "ページ)"
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        Me.LOGIN_USER_NAME.Text = pLoginUser.USER_NAME
    End Sub

    Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format

        'Me.SEISAN_YM.Text =Me.SEISAN_YM.Text 
        Me.SHOUNIN_KUBUN.Text = AppModule.GetName_SHOUNIN_KUBUN(Me.SHOUNIN_KUBUN.Text)
        Me.SHOUNIN_DATE.Text = CmnModule.Format_Date(Me.SHOUNIN_DATE.Text, CmnModule.DateFormatType.YYYYMMDD)

        Me.KAIJOHI_TF.Text = CmnModule.EditComma(Me.KAIJOHI_TF.Text)
        Me.KIZAIHI_TF.Text = CmnModule.EditComma(Me.KIZAIHI_TF.Text)
        Me.INSHOKUHI_TF.Text = CmnModule.EditComma(Me.INSHOKUHI_TF.Text)
        Me.KEI_991330401_TF.Text = CmnModule.EditComma(Me.KEI_991330401_TF.Text)

        Me.HOTELHI_TF.Text = CmnModule.EditComma(Me.HOTELHI_TF.Text)
        Me.HOTELHI_TOZEI.Text = CmnModule.EditComma(Me.HOTELHI_TOZEI.Text)
        Me.JR_TF.Text = CmnModule.EditComma(Me.JR_TF.Text)
        Me.AIR_TF.Text = CmnModule.EditComma(Me.AIR_TF.Text)
        Me.OTHER_TRAFFIC_TF.Text = CmnModule.EditComma(Me.OTHER_TRAFFIC_TF.Text)
        Me.TAXI_COMMISSION_TF.Text = CmnModule.EditComma(Me.TAXI_COMMISSION_TF.Text)
        Me.HOTEL_COMMISSION_TF.Text = CmnModule.EditComma(Me.HOTEL_COMMISSION_TF.Text)
        Me.JINKENHI_TF.Text = CmnModule.EditComma(Me.JINKENHI_TF.Text)
        Me.OTHER_TF.Text = CmnModule.EditComma(Me.OTHER_TF.Text)
        Me.KANRIHI_TF.Text = CmnModule.EditComma(Me.KANRIHI_TF.Text)
        Me.TAXI_TF.Text = CmnModule.EditComma(Me.TAXI_TF.Text)
        Me.TAXI_SEISAN_TF.Text = CmnModule.EditComma(Me.TAXI_SEISAN_TF.Text)
        Me.KEI_41120200_TF.Text = CmnModule.EditComma(Me.KEI_41120200_TF.Text)
        Me.KEI_TF.Text = CmnModule.EditComma(Me.KEI_TF.Text)

        Me.KAIJOUHI_T.Text = CmnModule.EditComma(Me.KAIJOUHI_T.Text)
        Me.KIZAIHI_T.Text = CmnModule.EditComma(Me.KIZAIHI_T.Text)
        Me.INSHOKUHI_T.Text = CmnModule.EditComma(Me.INSHOKUHI_T.Text)
        Me.KEI_991330401_T.Text = CmnModule.EditComma(Me.KEI_991330401_T.Text)

        Me.JINKENHI_T.Text = CmnModule.EditComma(Me.JINKENHI_T.Text)
        Me.OTHER_T.Text = CmnModule.EditComma(Me.OTHER_T.Text)
        Me.KANRIHI_T.Text = CmnModule.EditComma(Me.KANRIHI_T.Text)
        Me.KEI_41120200_T.Text = CmnModule.EditComma(Me.KEI_41120200_T.Text)
        Me.KEI_T.Text = CmnModule.EditComma(Me.KEI_T.Text)

        
        Me.MR_HOTEL.Text = CmnModule.EditComma(Me.MR_HOTEL.Text)
        Me.MR_HOTEL_TOZEI.Text = CmnModule.EditComma(Me.MR_HOTEL_TOZEI.Text)
        Me.MR_JR.Text = CmnModule.EditComma(Me.MR_JR.Text)

        Me.TAXI_T.Text = CmnModule.EditComma(Me.TAXI_T.Text)
        Me.TAXI_SEISAN_T.Text = CmnModule.EditComma(Me.TAXI_SEISAN_T.Text)

        'Me.SEISAN_KANRYO.Text = Me.SEISAN_KANRYO.Text

    End Sub
End Class
