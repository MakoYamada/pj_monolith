Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class DrReport1 

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        REQ_STATUS_TEHAI.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI.Text)
        TIME_STAMP_BYL.Text = CmnModule.Format_Date(TIME_STAMP_BYL.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        DR_YAKUWARI.Text = AppModule.GetName_DR_YAKUWARI(DR_YAKUWARI.Text)
        DR_SEX.Text = AppModule.GetName_DR_SEX(DR_SEX.Text)
        SHONIN_DATE.Text = CmnModule.Format_Date(SHONIN_DATE.Text, CmnModule.DateFormatType.YYYYMD)
        TEHAI_HOTEL.Text = AppModule.GetName_TEHAI_HOTEL(TEHAI_HOTEL.Text)
        REQ_HOTEL_DATE.Text = CmnModule.Format_Date(REQ_HOTEL_DATE.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_HOTEL_SMOKING.Text = AppModule.GetName_REQ_HOTEL_SMOKING(REQ_HOTEL_SMOKING.Text)
        REQ_O_TEHAI_1.Text = AppModule.GetName_REQ_O_TEHAI(REQ_O_TEHAI_1.Text)
        REQ_O_KOTSUKIKAN_1.Text = AppModule.GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_1.Text)
        REQ_O_DATE_1.Text = CmnModule.Format_Date(REQ_O_DATE_1.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_O_TIME1_1.Text = CmnModule.Format_Date(REQ_O_TIME1_1.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_1.Text = CmnModule.Format_Date(REQ_O_TIME2_1.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_SEAT_1.Text = AppModule.GetName_REQ_O_SEAT(REQ_O_SEAT_1.Text)
        REQ_O_SEAT_KIBOU1.Text = AppModule.GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU1.Text)
        REQ_F_TEHAI_1.Text = AppModule.GetName_REQ_F_TEHAI(REQ_F_TEHAI_1.Text)
        REQ_F_KOTSUKIKAN_1.Text = AppModule.GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_1.Text)
        REQ_F_DATE_1.Text = CmnModule.Format_Date(REQ_F_DATE_1.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_TIME1_1.Text = CmnModule.Format_Date(REQ_F_TIME1_1.Text, CmnModule.DateFormatType.HHMM)
        REQ_F_TIME2_1.Text = CmnModule.Format_Date(REQ_F_TIME2_1.Text, CmnModule.DateFormatType.HHMM)
        REQ_F_SEAT_1.Text = AppModule.GetName_REQ_F_SEAT(REQ_F_SEAT_1.Text)
        REQ_F_SEAT_KIBOU1.Text = AppModule.GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU1.Text)
    End Sub
End Class
