Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class DrReport3

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        REQ_STATUS_TEHAI.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI.Text)
        TIME_STAMP_BYL.Text = CmnModule.Format_Date(TIME_STAMP_BYL.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        REQ_O_TEHAI_5.Text = AppModule.GetName_REQ_O_TEHAI(REQ_O_TEHAI_5.Text)
        REQ_O_KOTSUKIKAN_5.Text = AppModule.GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_5.Text)
        REQ_O_DATE_5.Text = CmnModule.Format_Date(REQ_O_DATE_5.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_O_TIME1_5.Text = CmnModule.Format_Date(REQ_O_TIME1_5.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_5.Text = CmnModule.Format_Date(REQ_O_TIME2_5.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_SEAT_5.Text = AppModule.GetName_REQ_O_SEAT(REQ_O_SEAT_5.Text)
        REQ_O_SEAT_KIBOU5.Text = AppModule.GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU5.Text)
        REQ_F_TEHAI_5.Text = AppModule.GetName_REQ_F_TEHAI(REQ_F_TEHAI_5.Text)
        REQ_F_KOTSUKIKAN_5.Text = AppModule.GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_5.Text)
        REQ_F_DATE_5.Text = CmnModule.Format_Date(REQ_F_DATE_5.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_TIME1_5.Text = CmnModule.Format_Date(REQ_F_TIME1_5.Text, CmnModule.DateFormatType.HHMM)
        REQ_F_TIME2_5.Text = CmnModule.Format_Date(REQ_F_TIME2_5.Text, CmnModule.DateFormatType.HHMM)
        REQ_F_SEAT_5.Text = AppModule.GetName_REQ_F_SEAT(REQ_F_SEAT_5.Text)
        REQ_F_SEAT_KIBOU5.Text = AppModule.GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU5.Text)
        TEHAI_TAXI.Text = AppModule.GetName_TEHAI_TAXI(TEHAI_TAXI.Text)
        REQ_TAXI_DATE_1.Text = CmnModule.Format_Date(REQ_TAXI_DATE_1.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_1.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_1.Text) & " 円"
        REQ_TAXI_DATE_2.Text = CmnModule.Format_Date(REQ_TAXI_DATE_2.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_2.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_2.Text) & " 円"
        REQ_TAXI_DATE_3.Text = CmnModule.Format_Date(REQ_TAXI_DATE_3.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_3.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_3.Text) & " 円"
        REQ_TAXI_DATE_4.Text = CmnModule.Format_Date(REQ_TAXI_DATE_4.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_4.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_4.Text) & " 円"
        REQ_TAXI_DATE_5.Text = CmnModule.Format_Date(REQ_TAXI_DATE_5.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_5.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_5.Text) & " 円"
        REQ_TAXI_DATE_6.Text = CmnModule.Format_Date(REQ_TAXI_DATE_6.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_6.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_6.Text) & " 円"
        REQ_TAXI_DATE_7.Text = CmnModule.Format_Date(REQ_TAXI_DATE_7.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_7.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_7.Text) & " 円"
        REQ_TAXI_DATE_8.Text = CmnModule.Format_Date(REQ_TAXI_DATE_8.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_8.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_8.Text) & " 円"
        REQ_TAXI_DATE_9.Text = CmnModule.Format_Date(REQ_TAXI_DATE_9.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_9.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_9.Text) & " 円"
        REQ_TAXI_DATE_10.Text = CmnModule.Format_Date(REQ_TAXI_DATE_10.Text, CmnModule.DateFormatType.YYYYMD)
        TAXI_YOTEIKINGAKU_10.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_10.Text) & " 円"
    End Sub

End Class
