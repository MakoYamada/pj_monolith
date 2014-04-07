Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports CommonLib
Imports AppLib

Public Class DrListReport

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If Len(USER_NAME.Text) > 20 Then USER_NAME.Text = Left(USER_NAME.Text, 20)
        If Len(KOUENKAI_NAME.Text) > 20 Then KOUENKAI_NAME.Text = Left(KOUENKAI_NAME.Text, 20)
        If Len(DR_NAME.Text) > 20 Then DR_NAME.Text = Left(DR_NAME.Text, 20)

        '宿泊
        TEHAI_HOTEL.Text = AppModule.GetMark_TEHAI_HOTEL(TEHAI_HOTEL.Text)
        '交通
        If REQ_O_TEHAI_1.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_O_TEHAI_2.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_O_TEHAI_3.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_O_TEHAI_4.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_O_TEHAI_5.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_F_TEHAI_1.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_F_TEHAI_2.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_F_TEHAI_3.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_F_TEHAI_4.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            REQ_F_TEHAI_5.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Then

            REQ_KOTSU.Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
        Else
            REQ_KOTSU.Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
        End If
        'タクチケ
        TEHAI_TAXI.Text = AppModule.GetMark_TEHAI_TAXI(TEHAI_TAXI.Text)
        '緊急
        TEHAI_EMERGENCY.Text = AppModule.GetMark_KINKYU_FLAG(TEHAI_EMERGENCY.Text)
        'MR手配
        If REQ_MR_O_TEHAI.Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
            REQ_MR_O_TEHAI.Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
            REQ_MR_O_TEHAI.Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
            REQ_MR_F_TEHAI.Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
            REQ_MR_F_TEHAI.Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
            REQ_MR_F_TEHAI.Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
            REQ_MR_HOTEL_NOTE.Text.Trim <> "&nbsp;" Then

            TEHAI_MR.Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
        Else
            TEHAI_MR.Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
        End If
        'NOZOMI送信ステータス
        SEND_FLAG.Text = AppModule.GetName_SEND_FLAG(SEND_FLAG.Text, True)

        '区分
        REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(REQ_STATUS_TEHAI.Text, False, True)

        '開催日
        FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(FROM_DATE.Text, TO_DATE.Text, True)

        'TimeStamp
        TIME_STAMP.Text = _
            CmnModule.Format_Date(TIME_STAMP.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)

    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub
End Class
