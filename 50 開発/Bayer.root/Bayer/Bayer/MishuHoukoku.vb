Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class MishuHoukoku

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        Dim calendar = New System.Globalization.JapaneseCalendar()
        Dim culture = New System.Globalization.CultureInfo("ja-JP")
        Culture.DateTimeFormat.Calendar = Calendar
        PRINT_DATE.Text = Now.ToString("gyy年MM月dd日", culture)

        JIGYOSHO.Text = WebConfig.Site.JIGYOSHO
        DANTAI_NAME.Text = WebConfig.Site.DANTAI_NAME
        KAMOKU_CODE.Text = WebConfig.Site.KAMOKU_CODE
        RIYU.Text = WebConfig.Site.RIYU
        FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(FROM_DATE.Text, TO_DATE.Text, True)

        '未収金額算出
        Dim mishu As Long = 0
        mishu += CLng(Val(KEI_991330401_TF.Text))
        mishu += CLng(Val(KEI_41120200_TF.Text))
        mishu += CLng(Val(KEI_991330401_T.Text))
        mishu += CLng(Val(KEI_41120200_T.Text))
        mishu += CLng(Val(MR_HOTEL.Text))
        mishu += CLng(Val(MR_HOTEL_TOZEI.Text))
        mishu += CLng(Val(MR_JR.Text))
        mishu += CLng(Val(TAXI_T.Text))
        mishu += CLng(Val(TAXI_SEISAN_T.Text))
        MISHU_KINGAKU.Text = "\" & CmnModule.EditComma(mishu)
        If KOUENKAI_NAME.Text.Length > 60 Then KOUENKAI_NAME.Text = Left(KOUENKAI_NAME.Text, 60)

        'トップツアー精算年月の末日取得
        If SEISAN_YM.Text.Trim.Length = 6 Then
            Dim wdate As Date = CDate(CmnModule.Format_Date(SEISAN_YM.Text & "01", CmnModule.DateFormatType.YYYYMMDD))
            SEISAN_YM.Text = CmnModule.Format_Date(CmnModule.Format_DateToString(DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, wdate)), CmnModule.DateFormatType.YYYYMMDD), CmnModule.DateFormatType.YYYYMMDD)
        Else
            SEISAN_YM.Text = ""
        End If
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
    End Sub
End Class
