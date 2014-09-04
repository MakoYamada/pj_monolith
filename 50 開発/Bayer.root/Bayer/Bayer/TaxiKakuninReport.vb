Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class TaxiKakuninReport

    Private pMS_USER As TableDef.MS_USER.DataStruct
    Public WriteOnly Property MS_USER() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pMS_USER = value
        End Set
    End Property

    Private pKOTSUHOTEL_DATA As TableDef.TBL_KOTSUHOTEL.DataStruct
    Public WriteOnly Property KOTSUHOTEL_DATA() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Set(ByVal value As TableDef.TBL_KOTSUHOTEL.DataStruct)
            pKOTSUHOTEL_DATA = value
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        If DR_NAME.Text.Length > 19 Then DR_NAME.Text = Left(DR_NAME.Text, 19)
        If DR_SHISETSU_NAME.Text.Length > 25 Then DR_SHISETSU_NAME.Text = Left(DR_SHISETSU_NAME.Text, 25)
        TEHAI_TAXI.Text = AppModule.GetMark_TEHAI_TAXI(TEHAI_TAXI.Text)
        TEHAI_HOTEL.Text = AppModule.GetMark_TEHAI_HOTEL(TEHAI_HOTEL.Text)

        If REQ_O_TEHAI_1.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Or _
            REQ_O_TEHAI_2.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Or _
            REQ_O_TEHAI_3.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Or _
            REQ_O_TEHAI_4.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Or _
            REQ_O_TEHAI_5.Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Or _
            REQ_F_TEHAI_1.Text = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Or _
            REQ_F_TEHAI_2.Text = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Or _
            REQ_F_TEHAI_3.Text = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Or _
            REQ_F_TEHAI_4.Text = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Or _
            REQ_F_TEHAI_5.Text = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Then
            TEHAI_KOTSU.Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
        Else
            TEHAI_KOTSU.Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
        End If

        If REQ_MR_O_TEHAI.Text <> AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.Mi And _
            REQ_MR_O_TEHAI.Text <> AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.Fuyou Or _
            REQ_MR_F_TEHAI.Text <> AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.Mi And _
            REQ_MR_F_TEHAI.Text <> AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.Fuyou Then
            REQ_MR_TEHAI.Text = "●"
        Else
            REQ_MR_TEHAI.Text = "○"
        End If

        If KINKYU_FLAG.Text = AppConst.KOTSUHOTEL.KINKYU_FLAG.Code.Yes Then
            KINKYU_FLAG.Text = AppModule.GetMark_KINKYU_FLAG(AppConst.KOTSUHOTEL.KINKYU_FLAG.Code.Yes)
        Else
            KINKYU_FLAG.Text = AppModule.GetMark_KINKYU_FLAG(AppConst.KOTSUHOTEL.KINKYU_FLAG.Code.No)
        End If

        REQ_TAXI_DATE_1.Text = AppModule.GetName_REQ_TAXI_DATE_1(REQ_TAXI_DATE_1.Text)
        REQ_TAXI_DATE_2.Text = AppModule.GetName_REQ_TAXI_DATE_2(REQ_TAXI_DATE_2.Text)
        REQ_TAXI_DATE_3.Text = AppModule.GetName_REQ_TAXI_DATE_3(REQ_TAXI_DATE_3.Text)
        REQ_TAXI_DATE_4.Text = AppModule.GetName_REQ_TAXI_DATE_4(REQ_TAXI_DATE_4.Text)
        REQ_TAXI_DATE_5.Text = AppModule.GetName_REQ_TAXI_DATE_5(REQ_TAXI_DATE_5.Text)
        REQ_TAXI_DATE_6.Text = AppModule.GetName_REQ_TAXI_DATE_6(REQ_TAXI_DATE_6.Text)
        REQ_TAXI_DATE_7.Text = AppModule.GetName_REQ_TAXI_DATE_7(REQ_TAXI_DATE_7.Text)
        REQ_TAXI_DATE_8.Text = AppModule.GetName_REQ_TAXI_DATE_8(REQ_TAXI_DATE_8.Text)
        REQ_TAXI_DATE_9.Text = AppModule.GetName_REQ_TAXI_DATE_9(REQ_TAXI_DATE_9.Text)
        REQ_TAXI_DATE_10.Text = AppModule.GetName_REQ_TAXI_DATE_10(REQ_TAXI_DATE_10.Text)
        TAXI_YOTEIKINGAKU_1.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_1.Text) & "円"
        TAXI_YOTEIKINGAKU_2.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_2.Text) & "円"
        TAXI_YOTEIKINGAKU_3.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_3.Text) & "円"
        TAXI_YOTEIKINGAKU_4.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_4.Text) & "円"
        TAXI_YOTEIKINGAKU_5.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_5.Text) & "円"
        TAXI_YOTEIKINGAKU_6.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_6.Text) & "円"
        TAXI_YOTEIKINGAKU_7.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_7.Text) & "円"
        TAXI_YOTEIKINGAKU_8.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_8.Text) & "円"
        TAXI_YOTEIKINGAKU_9.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_9.Text) & "円"
        TAXI_YOTEIKINGAKU_10.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_10.Text) & "円"
        If REQ_TAXI_FROM_1.Text.Length > 11 Then REQ_TAXI_FROM_1.Text = Left(REQ_TAXI_FROM_1.Text, 11)
        If REQ_TAXI_FROM_2.Text.Length > 11 Then REQ_TAXI_FROM_2.Text = Left(REQ_TAXI_FROM_2.Text, 11)
        If REQ_TAXI_FROM_3.Text.Length > 11 Then REQ_TAXI_FROM_3.Text = Left(REQ_TAXI_FROM_3.Text, 11)
        If REQ_TAXI_FROM_4.Text.Length > 11 Then REQ_TAXI_FROM_4.Text = Left(REQ_TAXI_FROM_4.Text, 11)
        If REQ_TAXI_FROM_5.Text.Length > 11 Then REQ_TAXI_FROM_5.Text = Left(REQ_TAXI_FROM_5.Text, 11)
        If REQ_TAXI_FROM_6.Text.Length > 11 Then REQ_TAXI_FROM_6.Text = Left(REQ_TAXI_FROM_6.Text, 11)
        If REQ_TAXI_FROM_7.Text.Length > 11 Then REQ_TAXI_FROM_7.Text = Left(REQ_TAXI_FROM_7.Text, 11)
        If REQ_TAXI_FROM_8.Text.Length > 11 Then REQ_TAXI_FROM_8.Text = Left(REQ_TAXI_FROM_8.Text, 11)
        If REQ_TAXI_FROM_9.Text.Length > 11 Then REQ_TAXI_FROM_9.Text = Left(REQ_TAXI_FROM_9.Text, 11)
        If REQ_TAXI_FROM_10.Text.Length > 11 Then REQ_TAXI_FROM_10.Text = Left(REQ_TAXI_FROM_10.Text, 11)
        ANS_TAXI_DATE_1.Text = AppModule.GetName_ANS_TAXI_DATE_1(ANS_TAXI_DATE_1.Text)
        ANS_TAXI_DATE_2.Text = AppModule.GetName_ANS_TAXI_DATE_2(ANS_TAXI_DATE_2.Text)
        ANS_TAXI_DATE_3.Text = AppModule.GetName_ANS_TAXI_DATE_3(ANS_TAXI_DATE_3.Text)
        ANS_TAXI_DATE_4.Text = AppModule.GetName_ANS_TAXI_DATE_4(ANS_TAXI_DATE_4.Text)
        ANS_TAXI_DATE_5.Text = AppModule.GetName_ANS_TAXI_DATE_5(ANS_TAXI_DATE_5.Text)
        ANS_TAXI_DATE_6.Text = AppModule.GetName_ANS_TAXI_DATE_6(ANS_TAXI_DATE_6.Text)
        ANS_TAXI_DATE_7.Text = AppModule.GetName_ANS_TAXI_DATE_7(ANS_TAXI_DATE_7.Text)
        ANS_TAXI_DATE_8.Text = AppModule.GetName_ANS_TAXI_DATE_8(ANS_TAXI_DATE_8.Text)
        ANS_TAXI_DATE_9.Text = AppModule.GetName_ANS_TAXI_DATE_9(ANS_TAXI_DATE_9.Text)
        ANS_TAXI_DATE_10.Text = AppModule.GetName_ANS_TAXI_DATE_10(ANS_TAXI_DATE_10.Text)
        ANS_TAXI_DATE_11.Text = AppModule.GetName_ANS_TAXI_DATE_11(ANS_TAXI_DATE_11.Text)
        ANS_TAXI_DATE_12.Text = AppModule.GetName_ANS_TAXI_DATE_12(ANS_TAXI_DATE_12.Text)
        ANS_TAXI_DATE_13.Text = AppModule.GetName_ANS_TAXI_DATE_13(ANS_TAXI_DATE_13.Text)
        ANS_TAXI_DATE_14.Text = AppModule.GetName_ANS_TAXI_DATE_14(ANS_TAXI_DATE_14.Text)
        ANS_TAXI_DATE_15.Text = AppModule.GetName_ANS_TAXI_DATE_15(ANS_TAXI_DATE_15.Text)
        ANS_TAXI_DATE_16.Text = AppModule.GetName_ANS_TAXI_DATE_16(ANS_TAXI_DATE_16.Text)
        ANS_TAXI_DATE_17.Text = AppModule.GetName_ANS_TAXI_DATE_17(ANS_TAXI_DATE_17.Text)
        ANS_TAXI_DATE_18.Text = AppModule.GetName_ANS_TAXI_DATE_18(ANS_TAXI_DATE_18.Text)
        ANS_TAXI_DATE_19.Text = AppModule.GetName_ANS_TAXI_DATE_19(ANS_TAXI_DATE_19.Text)
        ANS_TAXI_DATE_20.Text = AppModule.GetName_ANS_TAXI_DATE_20(ANS_TAXI_DATE_20.Text)
        ANS_TAXI_KENSHU_1.Text = AppModule.GetName_ANS_TAXI_KENSHU_1(ANS_TAXI_KENSHU_1.Text)
        ANS_TAXI_KENSHU_2.Text = AppModule.GetName_ANS_TAXI_KENSHU_2(ANS_TAXI_KENSHU_2.Text)
        ANS_TAXI_KENSHU_3.Text = AppModule.GetName_ANS_TAXI_KENSHU_3(ANS_TAXI_KENSHU_3.Text)
        ANS_TAXI_KENSHU_4.Text = AppModule.GetName_ANS_TAXI_KENSHU_4(ANS_TAXI_KENSHU_4.Text)
        ANS_TAXI_KENSHU_5.Text = AppModule.GetName_ANS_TAXI_KENSHU_5(ANS_TAXI_KENSHU_5.Text)
        ANS_TAXI_KENSHU_6.Text = AppModule.GetName_ANS_TAXI_KENSHU_6(ANS_TAXI_KENSHU_6.Text)
        ANS_TAXI_KENSHU_7.Text = AppModule.GetName_ANS_TAXI_KENSHU_7(ANS_TAXI_KENSHU_7.Text)
        ANS_TAXI_KENSHU_8.Text = AppModule.GetName_ANS_TAXI_KENSHU_8(ANS_TAXI_KENSHU_8.Text)
        ANS_TAXI_KENSHU_9.Text = AppModule.GetName_ANS_TAXI_KENSHU_9(ANS_TAXI_KENSHU_9.Text)
        ANS_TAXI_KENSHU_10.Text = AppModule.GetName_ANS_TAXI_KENSHU_10(ANS_TAXI_KENSHU_10.Text)
        ANS_TAXI_KENSHU_11.Text = AppModule.GetName_ANS_TAXI_KENSHU_11(ANS_TAXI_KENSHU_11.Text)
        ANS_TAXI_KENSHU_12.Text = AppModule.GetName_ANS_TAXI_KENSHU_12(ANS_TAXI_KENSHU_12.Text)
        ANS_TAXI_KENSHU_13.Text = AppModule.GetName_ANS_TAXI_KENSHU_13(ANS_TAXI_KENSHU_13.Text)
        ANS_TAXI_KENSHU_14.Text = AppModule.GetName_ANS_TAXI_KENSHU_14(ANS_TAXI_KENSHU_14.Text)
        ANS_TAXI_KENSHU_15.Text = AppModule.GetName_ANS_TAXI_KENSHU_15(ANS_TAXI_KENSHU_15.Text)
        ANS_TAXI_KENSHU_16.Text = AppModule.GetName_ANS_TAXI_KENSHU_16(ANS_TAXI_KENSHU_16.Text)
        ANS_TAXI_KENSHU_17.Text = AppModule.GetName_ANS_TAXI_KENSHU_17(ANS_TAXI_KENSHU_17.Text)
        ANS_TAXI_KENSHU_18.Text = AppModule.GetName_ANS_TAXI_KENSHU_18(ANS_TAXI_KENSHU_18.Text)
        ANS_TAXI_KENSHU_19.Text = AppModule.GetName_ANS_TAXI_KENSHU_19(ANS_TAXI_KENSHU_19.Text)
        ANS_TAXI_KENSHU_20.Text = AppModule.GetName_ANS_TAXI_KENSHU_20(ANS_TAXI_KENSHU_20.Text)
        ANS_TAXI_HAKKO_DATE_1.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_1(ANS_TAXI_HAKKO_DATE_1.Text)
        ANS_TAXI_HAKKO_DATE_2.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_2(ANS_TAXI_HAKKO_DATE_2.Text)
        ANS_TAXI_HAKKO_DATE_3.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_3(ANS_TAXI_HAKKO_DATE_3.Text)
        ANS_TAXI_HAKKO_DATE_4.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_4(ANS_TAXI_HAKKO_DATE_4.Text)
        ANS_TAXI_HAKKO_DATE_5.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_5(ANS_TAXI_HAKKO_DATE_5.Text)
        ANS_TAXI_HAKKO_DATE_6.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_6(ANS_TAXI_HAKKO_DATE_6.Text)
        ANS_TAXI_HAKKO_DATE_7.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_7(ANS_TAXI_HAKKO_DATE_7.Text)
        ANS_TAXI_HAKKO_DATE_8.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_8(ANS_TAXI_HAKKO_DATE_8.Text)
        ANS_TAXI_HAKKO_DATE_9.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_9(ANS_TAXI_HAKKO_DATE_9.Text)
        ANS_TAXI_HAKKO_DATE_10.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_10(ANS_TAXI_HAKKO_DATE_10.Text)
        ANS_TAXI_HAKKO_DATE_11.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_11(ANS_TAXI_HAKKO_DATE_11.Text)
        ANS_TAXI_HAKKO_DATE_12.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_12(ANS_TAXI_HAKKO_DATE_12.Text)
        ANS_TAXI_HAKKO_DATE_13.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_13(ANS_TAXI_HAKKO_DATE_13.Text)
        ANS_TAXI_HAKKO_DATE_14.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_14(ANS_TAXI_HAKKO_DATE_14.Text)
        ANS_TAXI_HAKKO_DATE_15.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_15(ANS_TAXI_HAKKO_DATE_15.Text)
        ANS_TAXI_HAKKO_DATE_16.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_16(ANS_TAXI_HAKKO_DATE_16.Text)
        ANS_TAXI_HAKKO_DATE_17.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_17(ANS_TAXI_HAKKO_DATE_17.Text)
        ANS_TAXI_HAKKO_DATE_18.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_18(ANS_TAXI_HAKKO_DATE_18.Text)
        ANS_TAXI_HAKKO_DATE_19.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_19(ANS_TAXI_HAKKO_DATE_19.Text)
        ANS_TAXI_HAKKO_DATE_20.Text = AppModule.GetName_ANS_TAXI_HAKKO_DATE_20(ANS_TAXI_HAKKO_DATE_20.Text)

        If REQ_TAXI_NOTE.Text.Trim.Length > 200 Then
            REQ_TAXI_NOTE.Text = Left(REQ_TAXI_NOTE.Text.Trim, 200)
        End If
        If ANS_TAXI_NOTE.Text.Trim.Length > 200 Then
            ANS_TAXI_NOTE.Text = Left(ANS_TAXI_NOTE.Text.Trim, 200)
        End If
        If MR_SEND_SAKI_OTHER.Text.Trim.Length > 200 Then
            MR_SEND_SAKI_OTHER.Text = Left(MR_SEND_SAKI_OTHER.Text.Trim, 200)
        End If

        ''チケット送付先(その他)出力するため、備考の出力文字数削減(2014/9/4)
        'If REQ_TAXI_NOTE.Text.Trim.Length > 288 Then
        '    REQ_TAXI_NOTE.Text = Left(REQ_TAXI_NOTE.Text.Trim, 288)
        'End If
        'If ANS_TAXI_NOTE.Text.Trim.Length > 288 Then
        '    ANS_TAXI_NOTE.Text = Left(ANS_TAXI_NOTE.Text.Trim, 288)
        'End If

    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        Me.PRINT_USER.Text = pMS_USER.USER_NAME
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub
End Class
