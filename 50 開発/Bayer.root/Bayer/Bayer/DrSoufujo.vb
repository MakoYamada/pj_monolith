Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class DrSoufujo
    Private Const RowHeight As Single = 0.455
    Private Const StartY As Single = 0.799
    Private RowNo As Integer = 1
    Private ItemTitleX As Single = 0
    Private HotelItemTitleX1 As Single = 1.349
    Private HotelItemTitleX2 As Single = 8.572
    Private HotelItemTitleWidth = 2.433
    Private HotelItemX1 As Single = 3.57
    Private HotelItemX2 As Single = 10.555
    Private HotelItemWidth1 = 4.974
    Private HotelItemWidth2 = 7.478
    Private HotelItemWidthMax = 14.463
    Private KotsuItemTitleX1 As Single = 1.349
    Private KotsuItemTitleX2 As Single = 3.57
    Private KotsuItemTitleX3 As Single = 10.708
    Private KotsuItemX2 As Single = 4.971
    Private KotsuItemX3 As Single = 12.374
    Private KotsuItemTitleWidth2 = 1.401
    Private KotsuItemTitleWidth3 = 1.666
    Private KotsuItemWidth2 = 5.659
    Private KotsuItemWidth3 = 5.659
    Private TaxiItemTitleX1 As Single = 1.349
    Private TaxiItemTitleX2 As Single = 8.438
    Private TaxiItemTitleX3 As Single = 12.587
    Private TaxiItemTitleWidth1 As Single = 1.718
    Private TaxiItemTitleWidth2 As Single = 2.5
    Private TaxiItemTitleWidth3 As Single = 1.031
    Private TaxiItemX1 As Single = 3.57
    Private TaxiItemX2 As Single = 5.156
    Private TaxiItemX3 As Single = 10.708
    Private TaxiItemX4 As Single = 13.618
    Private TaxiItemWidth1 As Single = 1.399
    Private TaxiItemWidth2 As Single = 2.06
    Private TaxiItemWidth3 As Single = 1.534
    Private TaxiItemWidth4 As Single = 4.415

    Private pKOTSUHOTEL_DATA As TableDef.TBL_KOTSUHOTEL.DataStruct
    Public WriteOnly Property KOTSUHOTEL_DATA() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Set(ByVal value As TableDef.TBL_KOTSUHOTEL.DataStruct)
            pKOTSUHOTEL_DATA = value
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
    End Sub

    Private Sub ReportHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
        '送付日
        PRINT_DATE.Text = Format(Now, "yyyy年MM月dd日")

        'DR氏名
        If Me.DR_NAME.Text.Trim <> "" Then
            If Me.DR_NAME.Text.Trim.Length > 27 Then
                Me.DR_NAME.Text = Left(Me.DR_NAME.Text, 27) & "　先生"
            Else
                Me.DR_NAME.Text = Me.DR_NAME.Text & "　先生"
            End If
        End If

        '送付先
        If Me.MR_SEND_SAKI_FS.Text.Trim <> "" Then
            If Me.MR_SEND_SAKI_FS.Text.Trim.Length > 210 Then
                Me.MR_SEND_SAKI.Text = Left(Me.MR_SEND_SAKI_FS.Text, 210)
            Else
                Me.MR_SEND_SAKI.Text = Me.MR_SEND_SAKI_FS.Text
            End If
        Else
            If Me.MR_SEND_SAKI_OTHER.Text.Trim.Length > 210 Then
                Me.MR_SEND_SAKI.Text = Left(Me.MR_SEND_SAKI_OTHER.Text, 210)
            Else
                Me.MR_SEND_SAKI.Text = Me.MR_SEND_SAKI_OTHER.Text
            End If
        End If

        'MR氏名
        If Me.MR_NAME.Text.Trim <> "" Then
            Me.MR_NAME.Text = Me.MR_NAME.Text & "様"
        End If

        '開催日
        Me.JISSI_DATE.Text = AppModule.GetName_KOUENKAI_DATE(pKOTSUHOTEL_DATA.FROM_DATE, pKOTSUHOTEL_DATA.TO_DATE)

        '講演会名
        If Me.KOUENKAI_NAME.Text.Trim.Length > 50 Then
            Me.KOUENKAI_NAME.Text = Left(Me.KOUENKAI_NAME.Text.Trim, 50)
        Else
            Me.KOUENKAI_NAME.Text = Me.KOUENKAI_NAME.Text.Trim
        End If

        '会場名
        If Me.KAIJO_NAME.Text.Trim.Length > 50 Then
            Me.KAIJO_NAME.Text = Left(Me.KAIJO_NAME.Text.Trim, 50)
        Else
            Me.KAIJO_NAME.Text = Me.KAIJO_NAME.Text.Trim
        End If

        '冒頭あいさつ文
        Me.AISATSU1.Text = WebConfig.Site.AISATSU1
        Me.AISATSU2.Text = WebConfig.Site.AISATSU2
        Me.AISATSU3.Text = WebConfig.Site.AISATSU3
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        Me.JR_SETSUMEI1.Text = WebConfig.Site.JR_SETSUMEI1
        Me.JR_SETSUMEI2.Text = WebConfig.Site.JR_SETSUMEI2
        Me.JR_SETSUMEI3.Text = WebConfig.Site.JR_SETSUMEI3
        Me.JR_SETSUMEI4.Text = WebConfig.Site.JR_SETSUMEI4
        Me.AIR_SETSUMEI1.Text = WebConfig.Site.AIR_SETSUMEI1
        Me.AIR_SETSUMEI2.Text = WebConfig.Site.AIR_SETSUMEI2
        Me.AIR_SETSUMEI3.Text = WebConfig.Site.AIR_SETSUMEI3
        Me.AIR_SETSUMEI4.Text = WebConfig.Site.AIR_SETSUMEI4
        Me.AIR_SETSUMEI5.Text = WebConfig.Site.AIR_SETSUMEI5
        Me.AIR_SETSUMEI6.Text = WebConfig.Site.AIR_SETSUMEI6
        Me.OTHER_SETSUMEI1.Text = WebConfig.Site.OTHER_SETSUMEI1
        Me.OTHER_SETSUMEI2.Text = WebConfig.Site.OTHER_SETSUMEI2
        Me.FOOTER_SETSUMEI1.Text = WebConfig.Site.FOOTER_SETSUMEI1
        Me.FOOTER_SETSUMEI2.Text = WebConfig.Site.FOOTER_SETSUMEI2
        Me.FOOTER_SETSUMEI3.Text = WebConfig.Site.FOOTER_SETSUMEI3
        Me.FOOTER_SETSUMEI4.Text = WebConfig.Site.FOOTER_SETSUMEI4
    End Sub

    Private Sub DrSoufujo_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart

        '宿泊手配済
        If pKOTSUHOTEL_DATA.ANS_STATUS_HOTEL = AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.OK Then
            Dim HotelTitle As New Label
            HotelTitle.Text = "【宿泊】"
            HotelTitle.Height = RowHeight
            HotelTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY))
            HotelTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelTitle)

            Dim HotelDateTitle As New Label
            HotelDateTitle.Text = "利用日："
            HotelDateTitle.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            HotelDateTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX1), Me.CmToInch(StartY))
            HotelDateTitle.Alignment = TextAlignment.Left
            HotelDateTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelDateTitle)

            Dim HotelDate As New TextBox
            HotelDate.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_HOTEL_DATE, CmnModule.DateFormatType.YYYYMD)
            HotelDate.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemWidth1), Me.CmToInch(RowHeight))
            HotelDate.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX1), Me.CmToInch(StartY))
            HotelDate.CanGrow = True
            HotelDate.CanShrink = True
            HotelDate.WordWrap = False
            HotelDate.Alignment = TextAlignment.Left
            HotelDate.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelDate)

            Dim HotelNameTitle As New Label
            HotelNameTitle.Text = "宿泊施設名："
            HotelNameTitle.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            HotelNameTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX2), Me.CmToInch(StartY))
            HotelNameTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelNameTitle)

            Dim HotelName As New TextBox
            If pKOTSUHOTEL_DATA.ANS_HOTEL_NAME.Trim.Length > 25 Then
                HotelName.Text = Left(pKOTSUHOTEL_DATA.ANS_HOTEL_NAME.Trim, 25)
            Else
                HotelName.Text = pKOTSUHOTEL_DATA.ANS_HOTEL_NAME
            End If
            HotelName.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX2), Me.CmToInch(StartY))
            HotelName.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemWidth2), Me.CmToInch(RowHeight))
            HotelName.CanGrow = True
            HotelName.CanShrink = True
            HotelName.WordWrap = False
            HotelName.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelName)

            Dim HotelAddrTitle As New Label
            HotelAddrTitle.Text = "住所："
            HotelAddrTitle.Height = RowHeight
            HotelAddrTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            HotelAddrTitle.Alignment = TextAlignment.Left
            HotelAddrTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelAddrTitle)

            Dim HotelAddress As New TextBox
            HotelAddress.Text = pKOTSUHOTEL_DATA.ANS_HOTEL_ADDRESS.Trim
            HotelAddress.Height = RowHeight
            HotelAddress.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            HotelAddress.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemWidthMax), Me.CmToInch(RowHeight))
            HotelAddress.CanGrow = True
            HotelAddress.CanShrink = True
            HotelAddress.WordWrap = False
            HotelAddress.Alignment = TextAlignment.Left
            HotelAddress.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelAddress)

            RowNo += 1

            Dim HotelTelTitle As New Label
            HotelTelTitle.Text = "電話番号："
            HotelTelTitle.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            HotelTelTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            HotelTelTitle.Alignment = TextAlignment.Left
            HotelTelTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelTelTitle)

            Dim HotelTel As New TextBox
            HotelTel.Text = pKOTSUHOTEL_DATA.ANS_HOTEL_TEL
            HotelTel.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            HotelTel.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemWidthMax), Me.CmToInch(RowHeight))
            HotelTel.CanGrow = True
            HotelTel.CanShrink = True
            HotelTel.WordWrap = False
            HotelTel.Alignment = TextAlignment.Left
            HotelTel.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(HotelTel)

            RowNo += 1

            Dim RoomTypeTitle As New Label
            RoomTypeTitle.Text = "部屋タイプ："
            RoomTypeTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            RoomTypeTitle.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            RoomTypeTitle.Alignment = TextAlignment.Left
            RoomTypeTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(RoomTypeTitle)

            Dim RoomType As New TextBox
            RoomType.Text = pKOTSUHOTEL_DATA.ANS_ROOM_TYPE.Trim & _
                "　　　喫煙：" & AppModule.GetName_ANS_HOTEL_SMOKING(pKOTSUHOTEL_DATA.ANS_HOTEL_SMOKING)
            RoomType.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            RoomType.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemWidthMax), Me.CmToInch(RowHeight))
            RoomType.CanGrow = True
            RoomType.CanShrink = True
            RoomType.WordWrap = False
            RoomType.Alignment = TextAlignment.Left
            RoomType.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(RoomType)

            RowNo += 1

            Dim CheckinTitle As New Label
            CheckinTitle.Text = "チェックイン："
            CheckinTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            CheckinTitle.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            CheckinTitle.Alignment = TextAlignment.Left
            CheckinTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(CheckinTitle)

            Dim Checkin As New TextBox
            Checkin.Text = pKOTSUHOTEL_DATA.ANS_CHECKIN_TIME.Trim & _
                "　　　チェックアウト：" & pKOTSUHOTEL_DATA.ANS_CHECKOUT_TIME
            Checkin.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Checkin.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemWidthMax), Me.CmToInch(RowHeight))
            Checkin.CanGrow = True
            Checkin.CanShrink = True
            Checkin.WordWrap = False
            Checkin.Alignment = TextAlignment.Left
            Checkin.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Checkin)

            RowNo += 2
        End If

        '【交通】
        Dim KotsuFlg As Boolean = False
        '往路１手配済
        If pKOTSUHOTEL_DATA.ANS_O_STATUS_1 = AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK Then
            KotsuFlg = True

            Dim KotsuTitle As New Label
            KotsuTitle.Text = "【交通】"
            KotsuTitle.Height = RowHeight
            KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
            KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(KotsuTitle)

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜往路１＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_O_Date_1_Title As New Label
            Ans_O_Date_1_Title.Text = "利用日："
            Ans_O_Date_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_1_Title.Alignment = TextAlignment.Left
            Ans_O_Date_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_1_Title)

            Dim Ans_O_Date_1 As New TextBox
            Ans_O_Date_1.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_O_DATE_1, CmnModule.DateFormatType.MD)
            Ans_O_Date_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_1.CanGrow = True
            Ans_O_Date_1.CanShrink = True
            Ans_O_Date_1.WordWrap = False
            Ans_O_Date_1.Alignment = TextAlignment.Left
            Ans_O_Date_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_1)

            Dim Ans_O_Bin_1_Title As New Label
            Ans_O_Bin_1_Title.Text = "乗車便名："
            Ans_O_Bin_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Bin_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_1_Title.Alignment = TextAlignment.Left
            Ans_O_Bin_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_1_Title)

            Dim Ans_O_Bin_1 As New TextBox
            Ans_O_Bin_1.Text = pKOTSUHOTEL_DATA.ANS_O_BIN_1
            Ans_O_Bin_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Bin_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_1.CanGrow = True
            Ans_O_Bin_1.CanShrink = True
            Ans_O_Bin_1.WordWrap = False
            Ans_O_Bin_1.Alignment = TextAlignment.Left
            Ans_O_Bin_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_1)

            RowNo += 1

            Dim Ans_O_Airport1_1_Title As New Label
            Ans_O_Airport1_1_Title.Text = "発地："
            Ans_O_Airport1_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_1_Title.Alignment = TextAlignment.Left
            Ans_O_Airport1_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_1_Title)

            Dim Ans_O_Airport1_1 As New TextBox
            Ans_O_Airport1_1.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT1_1
            Ans_O_Airport1_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_1.CanGrow = True
            Ans_O_Airport1_1.CanShrink = True
            Ans_O_Airport1_1.WordWrap = False
            Ans_O_Airport1_1.Alignment = TextAlignment.Left
            Ans_O_Airport1_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_1)

            Dim Ans_O_Airport2_1_Title As New Label
            Ans_O_Airport2_1_Title.Text = "着地："
            Ans_O_Airport2_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_1_Title.Alignment = TextAlignment.Left
            Ans_O_Airport2_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_1_Title)

            Dim Ans_O_Airport2_1 As New TextBox
            Ans_O_Airport2_1.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT2_1
            Ans_O_Airport2_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_1.CanGrow = True
            Ans_O_Airport2_1.CanShrink = True
            Ans_O_Airport2_1.WordWrap = False
            Ans_O_Airport2_1.Alignment = TextAlignment.Left
            Ans_O_Airport2_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_1)

            RowNo += 1

            Dim Ans_O_Time1_1_Title As New Label
            Ans_O_Time1_1_Title.Text = "発時間："
            Ans_O_Time1_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_1_Title.Alignment = TextAlignment.Left
            Ans_O_Time1_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_1_Title)

            Dim Ans_O_Time1_1 As New TextBox
            Ans_O_Time1_1.Text = pKOTSUHOTEL_DATA.ANS_O_TIME1_1
            Ans_O_Time1_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_1.CanGrow = True
            Ans_O_Time1_1.CanShrink = True
            Ans_O_Time1_1.WordWrap = False
            Ans_O_Time1_1.Alignment = TextAlignment.Left
            Ans_O_Time1_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_1)

            Dim Ans_O_Time2_1_Title As New Label
            Ans_O_Time2_1_Title.Text = "着時間："
            Ans_O_Time2_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Time2_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_1_Title.Alignment = TextAlignment.Left
            Ans_O_Time2_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_1_Title)

            Dim Ans_O_Time2_1 As New TextBox
            Ans_O_Time2_1.Text = pKOTSUHOTEL_DATA.ANS_O_TIME2_1
            Ans_O_Time2_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Time2_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_1.CanGrow = True
            Ans_O_Time2_1.CanShrink = True
            Ans_O_Time2_1.WordWrap = False
            Ans_O_Time2_1.Alignment = TextAlignment.Left
            Ans_O_Time2_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_1)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '往路２手配済
        If pKOTSUHOTEL_DATA.ANS_O_STATUS_2 = AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜往路２＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_O_Date_2_Title As New Label
            Ans_O_Date_2_Title.Text = "利用日："
            Ans_O_Date_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_2_Title.Alignment = TextAlignment.Left
            Ans_O_Date_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_2_Title)

            Dim Ans_O_Date_2 As New TextBox
            Ans_O_Date_2.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_O_DATE_2, CmnModule.DateFormatType.MD)
            Ans_O_Date_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_2.CanGrow = True
            Ans_O_Date_2.CanShrink = True
            Ans_O_Date_2.WordWrap = False
            Ans_O_Date_2.Alignment = TextAlignment.Left
            Ans_O_Date_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_2)

            Dim Ans_O_Bin_2_Title As New Label
            Ans_O_Bin_2_Title.Text = "乗車便名："
            Ans_O_Bin_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Bin_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_2_Title.Alignment = TextAlignment.Left
            Ans_O_Bin_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_2_Title)

            Dim Ans_O_Bin_2 As New TextBox
            Ans_O_Bin_2.Text = pKOTSUHOTEL_DATA.ANS_O_BIN_2
            Ans_O_Bin_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Bin_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_2.CanGrow = True
            Ans_O_Bin_2.CanShrink = True
            Ans_O_Bin_2.WordWrap = False
            Ans_O_Bin_2.Alignment = TextAlignment.Left
            Ans_O_Bin_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_2)

            RowNo += 1

            Dim Ans_O_Airport1_2_Title As New Label
            Ans_O_Airport1_2_Title.Text = "発地："
            Ans_O_Airport1_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_2_Title.Alignment = TextAlignment.Left
            Ans_O_Airport1_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_2_Title)

            Dim Ans_O_Airport1_2 As New TextBox
            Ans_O_Airport1_2.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT1_2
            Ans_O_Airport1_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_2.CanGrow = True
            Ans_O_Airport1_2.CanShrink = True
            Ans_O_Airport1_2.WordWrap = False
            Ans_O_Airport1_2.Alignment = TextAlignment.Left
            Ans_O_Airport1_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_2)

            Dim Ans_O_Airport2_2_Title As New Label
            Ans_O_Airport2_2_Title.Text = "着地："
            Ans_O_Airport2_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_2_Title.Alignment = TextAlignment.Left
            Ans_O_Airport2_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_2_Title)

            Dim Ans_O_Airport2_2 As New TextBox
            Ans_O_Airport2_2.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT2_2
            Ans_O_Airport2_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_2.CanGrow = True
            Ans_O_Airport2_2.CanShrink = True
            Ans_O_Airport2_2.WordWrap = False
            Ans_O_Airport2_2.Alignment = TextAlignment.Left
            Ans_O_Airport2_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_2)

            RowNo += 1

            Dim Ans_O_Time1_2_Title As New Label
            Ans_O_Time1_2_Title.Text = "発時間："
            Ans_O_Time1_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_2_Title.Alignment = TextAlignment.Left
            Ans_O_Time1_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_2_Title)

            Dim Ans_O_Time1_2 As New TextBox
            Ans_O_Time1_2.Text = pKOTSUHOTEL_DATA.ANS_O_TIME1_2
            Ans_O_Time1_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_2.CanGrow = True
            Ans_O_Time1_2.CanShrink = True
            Ans_O_Time1_2.WordWrap = False
            Ans_O_Time1_2.Alignment = TextAlignment.Left
            Ans_O_Time1_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_2)

            Dim Ans_O_Time2_2_Title As New Label
            Ans_O_Time2_2_Title.Text = "着時間："
            Ans_O_Time2_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Time2_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_2_Title.Alignment = TextAlignment.Left
            Ans_O_Time2_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_2_Title)

            Dim Ans_O_Time2_2 As New TextBox
            Ans_O_Time2_2.Text = pKOTSUHOTEL_DATA.ANS_O_TIME2_2
            Ans_O_Time2_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Time2_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_2.CanGrow = True
            Ans_O_Time2_2.CanShrink = True
            Ans_O_Time2_2.WordWrap = False
            Ans_O_Time2_2.Alignment = TextAlignment.Left
            Ans_O_Time2_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_2)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '往路３手配済
        If pKOTSUHOTEL_DATA.ANS_O_STATUS_3 = AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜往路３＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_O_Date_3_Title As New Label
            Ans_O_Date_3_Title.Text = "利用日："
            Ans_O_Date_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_3_Title.Alignment = TextAlignment.Left
            Ans_O_Date_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_3_Title)

            Dim Ans_O_Date_3 As New TextBox
            Ans_O_Date_3.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_O_DATE_3, CmnModule.DateFormatType.MD)
            Ans_O_Date_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_3.CanGrow = True
            Ans_O_Date_3.CanShrink = True
            Ans_O_Date_3.WordWrap = False
            Ans_O_Date_3.Alignment = TextAlignment.Left
            Ans_O_Date_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_3)

            Dim Ans_O_Bin_3_Title As New Label
            Ans_O_Bin_3_Title.Text = "乗車便名："
            Ans_O_Bin_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Bin_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_3_Title.Alignment = TextAlignment.Left
            Ans_O_Bin_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_3_Title)

            Dim Ans_O_Bin_3 As New TextBox
            Ans_O_Bin_3.Text = pKOTSUHOTEL_DATA.ANS_O_BIN_3
            Ans_O_Bin_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Bin_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_3.CanGrow = True
            Ans_O_Bin_3.CanShrink = True
            Ans_O_Bin_3.WordWrap = False
            Ans_O_Bin_3.Alignment = TextAlignment.Left
            Ans_O_Bin_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_3)

            RowNo += 1

            Dim Ans_O_Airport1_3_Title As New Label
            Ans_O_Airport1_3_Title.Text = "発地："
            Ans_O_Airport1_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_3_Title.Alignment = TextAlignment.Left
            Ans_O_Airport1_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_3_Title)

            Dim Ans_O_Airport1_3 As New TextBox
            Ans_O_Airport1_3.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT1_3
            Ans_O_Airport1_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_3.CanGrow = True
            Ans_O_Airport1_3.CanShrink = True
            Ans_O_Airport1_3.WordWrap = False
            Ans_O_Airport1_3.Alignment = TextAlignment.Left
            Ans_O_Airport1_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_3)

            Dim Ans_O_Airport2_3_Title As New Label
            Ans_O_Airport2_3_Title.Text = "着地："
            Ans_O_Airport2_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_3_Title.Alignment = TextAlignment.Left
            Ans_O_Airport2_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_3_Title)

            Dim Ans_O_Airport2_3 As New TextBox
            Ans_O_Airport2_3.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT2_3
            Ans_O_Airport2_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_3.CanGrow = True
            Ans_O_Airport2_3.CanShrink = True
            Ans_O_Airport2_3.WordWrap = False
            Ans_O_Airport2_3.Alignment = TextAlignment.Left
            Ans_O_Airport2_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_3)

            RowNo += 1

            Dim Ans_O_Time1_3_Title As New Label
            Ans_O_Time1_3_Title.Text = "発時間："
            Ans_O_Time1_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_3_Title.Alignment = TextAlignment.Left
            Ans_O_Time1_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_3_Title)

            Dim Ans_O_Time1_3 As New TextBox
            Ans_O_Time1_3.Text = pKOTSUHOTEL_DATA.ANS_O_TIME1_3
            Ans_O_Time1_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_3.CanGrow = True
            Ans_O_Time1_3.CanShrink = True
            Ans_O_Time1_3.WordWrap = False
            Ans_O_Time1_3.Alignment = TextAlignment.Left
            Ans_O_Time1_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_3)

            Dim Ans_O_Time2_3_Title As New Label
            Ans_O_Time2_3_Title.Text = "着時間："
            Ans_O_Time2_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Time2_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_3_Title.Alignment = TextAlignment.Left
            Ans_O_Time2_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_3_Title)

            Dim Ans_O_Time2_3 As New TextBox
            Ans_O_Time2_3.Text = pKOTSUHOTEL_DATA.ANS_O_TIME2_3
            Ans_O_Time2_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Time2_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_3.CanGrow = True
            Ans_O_Time2_3.CanShrink = True
            Ans_O_Time2_3.WordWrap = False
            Ans_O_Time2_3.Alignment = TextAlignment.Left
            Ans_O_Time2_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_3)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '往路４手配済
        If pKOTSUHOTEL_DATA.ANS_O_STATUS_4 = AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜往路４＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_O_Date_4_Title As New Label
            Ans_O_Date_4_Title.Text = "利用日："
            Ans_O_Date_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_4_Title.Alignment = TextAlignment.Left
            Ans_O_Date_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_4_Title)

            Dim Ans_O_Date_4 As New TextBox
            Ans_O_Date_4.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_O_DATE_4, CmnModule.DateFormatType.MD)
            Ans_O_Date_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_4.CanGrow = True
            Ans_O_Date_4.CanShrink = True
            Ans_O_Date_4.WordWrap = False
            Ans_O_Date_4.Alignment = TextAlignment.Left
            Ans_O_Date_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_4)

            Dim Ans_O_Bin_4_Title As New Label
            Ans_O_Bin_4_Title.Text = "乗車便名："
            Ans_O_Bin_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Bin_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_4_Title.Alignment = TextAlignment.Left
            Ans_O_Bin_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_4_Title)

            Dim Ans_O_Bin_4 As New TextBox
            Ans_O_Bin_4.Text = pKOTSUHOTEL_DATA.ANS_O_BIN_4
            Ans_O_Bin_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Bin_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_4.CanGrow = True
            Ans_O_Bin_4.CanShrink = True
            Ans_O_Bin_4.WordWrap = False
            Ans_O_Bin_4.Alignment = TextAlignment.Left
            Ans_O_Bin_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_4)

            RowNo += 1

            Dim Ans_O_Airport1_4_Title As New Label
            Ans_O_Airport1_4_Title.Text = "発地："
            Ans_O_Airport1_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_4_Title.Alignment = TextAlignment.Left
            Ans_O_Airport1_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_4_Title)

            Dim Ans_O_Airport1_4 As New TextBox
            Ans_O_Airport1_4.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT1_4
            Ans_O_Airport1_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_4.CanGrow = True
            Ans_O_Airport1_4.CanShrink = True
            Ans_O_Airport1_4.WordWrap = False
            Ans_O_Airport1_4.Alignment = TextAlignment.Left
            Ans_O_Airport1_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_4)

            Dim Ans_O_Airport2_4_Title As New Label
            Ans_O_Airport2_4_Title.Text = "着地："
            Ans_O_Airport2_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_4_Title.Alignment = TextAlignment.Left
            Ans_O_Airport2_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_4_Title)

            Dim Ans_O_Airport2_4 As New TextBox
            Ans_O_Airport2_4.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT2_4
            Ans_O_Airport2_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_4.CanGrow = True
            Ans_O_Airport2_4.CanShrink = True
            Ans_O_Airport2_4.WordWrap = False
            Ans_O_Airport2_4.Alignment = TextAlignment.Left
            Ans_O_Airport2_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_4)

            RowNo += 1

            Dim Ans_O_Time1_4_Title As New Label
            Ans_O_Time1_4_Title.Text = "発時間："
            Ans_O_Time1_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_4_Title.Alignment = TextAlignment.Left
            Ans_O_Time1_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_4_Title)

            Dim Ans_O_Time1_4 As New TextBox
            Ans_O_Time1_4.Text = pKOTSUHOTEL_DATA.ANS_O_TIME1_4
            Ans_O_Time1_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_4.CanGrow = True
            Ans_O_Time1_4.CanShrink = True
            Ans_O_Time1_4.WordWrap = False
            Ans_O_Time1_4.Alignment = TextAlignment.Left
            Ans_O_Time1_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_4)

            Dim Ans_O_Time2_4_Title As New Label
            Ans_O_Time2_4_Title.Text = "着時間："
            Ans_O_Time2_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Time2_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_4_Title.Alignment = TextAlignment.Left
            Ans_O_Time2_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_4_Title)

            Dim Ans_O_Time2_4 As New TextBox
            Ans_O_Time2_4.Text = pKOTSUHOTEL_DATA.ANS_O_TIME2_4
            Ans_O_Time2_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Time2_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_4.CanGrow = True
            Ans_O_Time2_4.CanShrink = True
            Ans_O_Time2_4.WordWrap = False
            Ans_O_Time2_4.Alignment = TextAlignment.Left
            Ans_O_Time2_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_4)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '往路５手配済
        If pKOTSUHOTEL_DATA.ANS_O_STATUS_5 = AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜往路５＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_O_Date_5_Title As New Label
            Ans_O_Date_5_Title.Text = "利用日："
            Ans_O_Date_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_5_Title.Alignment = TextAlignment.Left
            Ans_O_Date_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_5_Title)

            Dim Ans_O_Date_5 As New TextBox
            Ans_O_Date_5.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_O_DATE_5, CmnModule.DateFormatType.MD)
            Ans_O_Date_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Date_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Date_5.CanGrow = True
            Ans_O_Date_5.CanShrink = True
            Ans_O_Date_5.WordWrap = False
            Ans_O_Date_5.Alignment = TextAlignment.Left
            Ans_O_Date_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Date_5)

            Dim Ans_O_Bin_5_Title As New Label
            Ans_O_Bin_5_Title.Text = "乗車便名："
            Ans_O_Bin_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Bin_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_5_Title.Alignment = TextAlignment.Left
            Ans_O_Bin_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_5_Title)

            Dim Ans_O_Bin_5 As New TextBox
            Ans_O_Bin_5.Text = pKOTSUHOTEL_DATA.ANS_O_BIN_5
            Ans_O_Bin_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Bin_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Bin_5.CanGrow = True
            Ans_O_Bin_5.CanShrink = True
            Ans_O_Bin_5.WordWrap = False
            Ans_O_Bin_5.Alignment = TextAlignment.Left
            Ans_O_Bin_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Bin_5)

            RowNo += 1

            Dim Ans_O_Airport1_5_Title As New Label
            Ans_O_Airport1_5_Title.Text = "発地："
            Ans_O_Airport1_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_5_Title.Alignment = TextAlignment.Left
            Ans_O_Airport1_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_5_Title)

            Dim Ans_O_Airport1_5 As New TextBox
            Ans_O_Airport1_5.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT1_5
            Ans_O_Airport1_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Airport1_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport1_5.CanGrow = True
            Ans_O_Airport1_5.CanShrink = True
            Ans_O_Airport1_5.WordWrap = False
            Ans_O_Airport1_5.Alignment = TextAlignment.Left
            Ans_O_Airport1_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport1_5)

            Dim Ans_O_Airport2_5_Title As New Label
            Ans_O_Airport2_5_Title.Text = "着地："
            Ans_O_Airport2_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_5_Title.Alignment = TextAlignment.Left
            Ans_O_Airport2_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_5_Title)

            Dim Ans_O_Airport2_5 As New TextBox
            Ans_O_Airport2_5.Text = pKOTSUHOTEL_DATA.ANS_O_AIRPORT2_5
            Ans_O_Airport2_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Airport2_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Airport2_5.CanGrow = True
            Ans_O_Airport2_5.CanShrink = True
            Ans_O_Airport2_5.WordWrap = False
            Ans_O_Airport2_5.Alignment = TextAlignment.Left
            Ans_O_Airport2_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Airport2_5)

            RowNo += 1

            Dim Ans_O_Time1_5_Title As New Label
            Ans_O_Time1_5_Title.Text = "発時間："
            Ans_O_Time1_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_5_Title.Alignment = TextAlignment.Left
            Ans_O_Time1_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_5_Title)

            Dim Ans_O_Time1_5 As New TextBox
            Ans_O_Time1_5.Text = pKOTSUHOTEL_DATA.ANS_O_TIME1_5
            Ans_O_Time1_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_O_Time1_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time1_5.CanGrow = True
            Ans_O_Time1_5.CanShrink = True
            Ans_O_Time1_5.WordWrap = False
            Ans_O_Time1_5.Alignment = TextAlignment.Left
            Ans_O_Time1_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time1_5)

            Dim Ans_O_Time2_5_Title As New Label
            Ans_O_Time2_5_Title.Text = "着時間："
            Ans_O_Time2_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_O_Time2_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_5_Title.Alignment = TextAlignment.Left
            Ans_O_Time2_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_5_Title)

            Dim Ans_O_Time2_5 As New TextBox
            Ans_O_Time2_5.Text = pKOTSUHOTEL_DATA.ANS_O_TIME2_5
            Ans_O_Time2_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_O_Time2_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_O_Time2_5.CanGrow = True
            Ans_O_Time2_5.CanShrink = True
            Ans_O_Time2_5.WordWrap = False
            Ans_O_Time2_5.Alignment = TextAlignment.Left
            Ans_O_Time2_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_O_Time2_5)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If
        '復路１手配済
        If pKOTSUHOTEL_DATA.ANS_F_STATUS_1 = AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜復路１＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_F_Date_1_Title As New Label
            Ans_F_Date_1_Title.Text = "利用日："
            Ans_F_Date_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_1_Title.Alignment = TextAlignment.Left
            Ans_F_Date_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_1_Title)

            Dim Ans_F_Date_1 As New TextBox
            Ans_F_Date_1.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_F_DATE_1, CmnModule.DateFormatType.MD)
            Ans_F_Date_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_1.CanGrow = True
            Ans_F_Date_1.CanShrink = True
            Ans_F_Date_1.WordWrap = False
            Ans_F_Date_1.Alignment = TextAlignment.Left
            Ans_F_Date_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_1)

            Dim Ans_F_Bin_1_Title As New Label
            Ans_F_Bin_1_Title.Text = "乗車便名："
            Ans_F_Bin_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Bin_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_1_Title.Alignment = TextAlignment.Left
            Ans_F_Bin_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_1_Title)

            Dim Ans_F_Bin_1 As New TextBox
            Ans_F_Bin_1.Text = pKOTSUHOTEL_DATA.ANS_F_BIN_1
            Ans_F_Bin_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Bin_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_1.CanGrow = True
            Ans_F_Bin_1.CanShrink = True
            Ans_F_Bin_1.WordWrap = False
            Ans_F_Bin_1.Alignment = TextAlignment.Left
            Ans_F_Bin_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_1)

            RowNo += 1

            Dim Ans_F_Airport1_1_Title As New Label
            Ans_F_Airport1_1_Title.Text = "発地："
            Ans_F_Airport1_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_1_Title.Alignment = TextAlignment.Left
            Ans_F_Airport1_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_1_Title)

            Dim Ans_F_Airport1_1 As New TextBox
            Ans_F_Airport1_1.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT1_1
            Ans_F_Airport1_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_1.CanGrow = True
            Ans_F_Airport1_1.CanShrink = True
            Ans_F_Airport1_1.WordWrap = False
            Ans_F_Airport1_1.Alignment = TextAlignment.Left
            Ans_F_Airport1_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_1)

            Dim Ans_F_Airport2_1_Title As New Label
            Ans_F_Airport2_1_Title.Text = "着地："
            Ans_F_Airport2_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_1_Title.Alignment = TextAlignment.Left
            Ans_F_Airport2_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_1_Title)

            Dim Ans_F_Airport2_1 As New TextBox
            Ans_F_Airport2_1.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT2_1
            Ans_F_Airport2_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_1.CanGrow = True
            Ans_F_Airport2_1.CanShrink = True
            Ans_F_Airport2_1.WordWrap = False
            Ans_F_Airport2_1.Alignment = TextAlignment.Left
            Ans_F_Airport2_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_1)

            RowNo += 1

            Dim Ans_F_Time1_1_Title As New Label
            Ans_F_Time1_1_Title.Text = "発時間："
            Ans_F_Time1_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_1_Title.Alignment = TextAlignment.Left
            Ans_F_Time1_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_1_Title)

            Dim Ans_F_Time1_1 As New TextBox
            Ans_F_Time1_1.Text = pKOTSUHOTEL_DATA.ANS_F_TIME1_1
            Ans_F_Time1_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_1.CanGrow = True
            Ans_F_Time1_1.CanShrink = True
            Ans_F_Time1_1.WordWrap = False
            Ans_F_Time1_1.Alignment = TextAlignment.Left
            Ans_F_Time1_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_1)

            Dim Ans_F_Time2_1_Title As New Label
            Ans_F_Time2_1_Title.Text = "着時間："
            Ans_F_Time2_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Time2_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_1_Title.Alignment = TextAlignment.Left
            Ans_F_Time2_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_1_Title)

            Dim Ans_F_Time2_1 As New TextBox
            Ans_F_Time2_1.Text = pKOTSUHOTEL_DATA.ANS_F_TIME2_1
            Ans_F_Time2_1.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Time2_1.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_1.CanGrow = True
            Ans_F_Time2_1.CanShrink = True
            Ans_F_Time2_1.WordWrap = False
            Ans_F_Time2_1.Alignment = TextAlignment.Left
            Ans_F_Time2_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_1)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '復路２手配済
        If pKOTSUHOTEL_DATA.ANS_F_STATUS_2 = AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜復路２＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_F_Date_2_Title As New Label
            Ans_F_Date_2_Title.Text = "利用日："
            Ans_F_Date_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_2_Title.Alignment = TextAlignment.Left
            Ans_F_Date_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_2_Title)

            Dim Ans_F_Date_2 As New TextBox
            Ans_F_Date_2.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_F_DATE_2, CmnModule.DateFormatType.MD)
            Ans_F_Date_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_2.CanGrow = True
            Ans_F_Date_2.CanShrink = True
            Ans_F_Date_2.WordWrap = False
            Ans_F_Date_2.Alignment = TextAlignment.Left
            Ans_F_Date_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_2)

            Dim Ans_F_Bin_2_Title As New Label
            Ans_F_Bin_2_Title.Text = "乗車便名："
            Ans_F_Bin_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Bin_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_2_Title.Alignment = TextAlignment.Left
            Ans_F_Bin_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_2_Title)

            Dim Ans_F_Bin_2 As New TextBox
            Ans_F_Bin_2.Text = pKOTSUHOTEL_DATA.ANS_F_BIN_2
            Ans_F_Bin_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Bin_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_2.CanGrow = True
            Ans_F_Bin_2.CanShrink = True
            Ans_F_Bin_2.WordWrap = False
            Ans_F_Bin_2.Alignment = TextAlignment.Left
            Ans_F_Bin_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_2)

            RowNo += 1

            Dim Ans_F_Airport1_2_Title As New Label
            Ans_F_Airport1_2_Title.Text = "発地："
            Ans_F_Airport1_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_2_Title.Alignment = TextAlignment.Left
            Ans_F_Airport1_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_2_Title)

            Dim Ans_F_Airport1_2 As New TextBox
            Ans_F_Airport1_2.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT1_2
            Ans_F_Airport1_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_2.CanGrow = True
            Ans_F_Airport1_2.CanShrink = True
            Ans_F_Airport1_2.WordWrap = False
            Ans_F_Airport1_2.Alignment = TextAlignment.Left
            Ans_F_Airport1_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_2)

            Dim Ans_F_Airport2_2_Title As New Label
            Ans_F_Airport2_2_Title.Text = "着地："
            Ans_F_Airport2_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_2_Title.Alignment = TextAlignment.Left
            Ans_F_Airport2_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_2_Title)

            Dim Ans_F_Airport2_2 As New TextBox
            Ans_F_Airport2_2.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT2_2
            Ans_F_Airport2_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_2.CanGrow = True
            Ans_F_Airport2_2.CanShrink = True
            Ans_F_Airport2_2.WordWrap = False
            Ans_F_Airport2_2.Alignment = TextAlignment.Left
            Ans_F_Airport2_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_2)

            RowNo += 1

            Dim Ans_F_Time1_2_Title As New Label
            Ans_F_Time1_2_Title.Text = "発時間："
            Ans_F_Time1_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_2_Title.Alignment = TextAlignment.Left
            Ans_F_Time1_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_2_Title)

            Dim Ans_F_Time1_2 As New TextBox
            Ans_F_Time1_2.Text = pKOTSUHOTEL_DATA.ANS_F_TIME1_2
            Ans_F_Time1_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_2.CanGrow = True
            Ans_F_Time1_2.CanShrink = True
            Ans_F_Time1_2.WordWrap = False
            Ans_F_Time1_2.Alignment = TextAlignment.Left
            Ans_F_Time1_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_2)

            Dim Ans_F_Time2_2_Title As New Label
            Ans_F_Time2_2_Title.Text = "着時間："
            Ans_F_Time2_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Time2_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_2_Title.Alignment = TextAlignment.Left
            Ans_F_Time2_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_2_Title)

            Dim Ans_F_Time2_2 As New TextBox
            Ans_F_Time2_2.Text = pKOTSUHOTEL_DATA.ANS_F_TIME2_2
            Ans_F_Time2_2.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Time2_2.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_2.CanGrow = True
            Ans_F_Time2_2.CanShrink = True
            Ans_F_Time2_2.WordWrap = False
            Ans_F_Time2_2.Alignment = TextAlignment.Left
            Ans_F_Time2_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_2)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '復路３手配済
        If pKOTSUHOTEL_DATA.ANS_F_STATUS_3 = AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜復路３＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_F_Date_3_Title As New Label
            Ans_F_Date_3_Title.Text = "利用日："
            Ans_F_Date_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_3_Title.Alignment = TextAlignment.Left
            Ans_F_Date_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_3_Title)

            Dim Ans_F_Date_3 As New TextBox
            Ans_F_Date_3.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_F_DATE_3, CmnModule.DateFormatType.MD)
            Ans_F_Date_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_3.CanGrow = True
            Ans_F_Date_3.CanShrink = True
            Ans_F_Date_3.WordWrap = False
            Ans_F_Date_3.Alignment = TextAlignment.Left
            Ans_F_Date_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_3)

            Dim Ans_F_Bin_3_Title As New Label
            Ans_F_Bin_3_Title.Text = "乗車便名："
            Ans_F_Bin_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Bin_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_3_Title.Alignment = TextAlignment.Left
            Ans_F_Bin_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_3_Title)

            Dim Ans_F_Bin_3 As New TextBox
            Ans_F_Bin_3.Text = pKOTSUHOTEL_DATA.ANS_F_BIN_3
            Ans_F_Bin_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Bin_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_3.CanGrow = True
            Ans_F_Bin_3.CanShrink = True
            Ans_F_Bin_3.WordWrap = False
            Ans_F_Bin_3.Alignment = TextAlignment.Left
            Ans_F_Bin_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_3)

            RowNo += 1

            Dim Ans_F_Airport1_3_Title As New Label
            Ans_F_Airport1_3_Title.Text = "発地："
            Ans_F_Airport1_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_3_Title.Alignment = TextAlignment.Left
            Ans_F_Airport1_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_3_Title)

            Dim Ans_F_Airport1_3 As New TextBox
            Ans_F_Airport1_3.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT1_3
            Ans_F_Airport1_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_3.CanGrow = True
            Ans_F_Airport1_3.CanShrink = True
            Ans_F_Airport1_3.WordWrap = False
            Ans_F_Airport1_3.Alignment = TextAlignment.Left
            Ans_F_Airport1_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_3)

            Dim Ans_F_Airport2_3_Title As New Label
            Ans_F_Airport2_3_Title.Text = "着地："
            Ans_F_Airport2_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_3_Title.Alignment = TextAlignment.Left
            Ans_F_Airport2_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_3_Title)

            Dim Ans_F_Airport2_3 As New TextBox
            Ans_F_Airport2_3.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT2_3
            Ans_F_Airport2_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_3.CanGrow = True
            Ans_F_Airport2_3.CanShrink = True
            Ans_F_Airport2_3.WordWrap = False
            Ans_F_Airport2_3.Alignment = TextAlignment.Left
            Ans_F_Airport2_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_3)

            RowNo += 1

            Dim Ans_F_Time1_3_Title As New Label
            Ans_F_Time1_3_Title.Text = "発時間："
            Ans_F_Time1_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_3_Title.Alignment = TextAlignment.Left
            Ans_F_Time1_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_3_Title)

            Dim Ans_F_Time1_3 As New TextBox
            Ans_F_Time1_3.Text = pKOTSUHOTEL_DATA.ANS_F_TIME1_3
            Ans_F_Time1_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_3.CanGrow = True
            Ans_F_Time1_3.CanShrink = True
            Ans_F_Time1_3.WordWrap = False
            Ans_F_Time1_3.Alignment = TextAlignment.Left
            Ans_F_Time1_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_3)

            Dim Ans_F_Time2_3_Title As New Label
            Ans_F_Time2_3_Title.Text = "着時間："
            Ans_F_Time2_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Time2_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_3_Title.Alignment = TextAlignment.Left
            Ans_F_Time2_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_3_Title)

            Dim Ans_F_Time2_3 As New TextBox
            Ans_F_Time2_3.Text = pKOTSUHOTEL_DATA.ANS_F_TIME2_3
            Ans_F_Time2_3.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Time2_3.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_3.CanGrow = True
            Ans_F_Time2_3.CanShrink = True
            Ans_F_Time2_3.WordWrap = False
            Ans_F_Time2_3.Alignment = TextAlignment.Left
            Ans_F_Time2_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_3)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '復路４手配済
        If pKOTSUHOTEL_DATA.ANS_F_STATUS_4 = AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜復路４＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_F_Date_4_Title As New Label
            Ans_F_Date_4_Title.Text = "利用日："
            Ans_F_Date_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_4_Title.Alignment = TextAlignment.Left
            Ans_F_Date_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_4_Title)

            Dim Ans_F_Date_4 As New TextBox
            Ans_F_Date_4.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_F_DATE_4, CmnModule.DateFormatType.MD)
            Ans_F_Date_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_4.CanGrow = True
            Ans_F_Date_4.CanShrink = True
            Ans_F_Date_4.WordWrap = False
            Ans_F_Date_4.Alignment = TextAlignment.Left
            Ans_F_Date_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_4)

            Dim Ans_F_Bin_4_Title As New Label
            Ans_F_Bin_4_Title.Text = "乗車便名："
            Ans_F_Bin_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Bin_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_4_Title.Alignment = TextAlignment.Left
            Ans_F_Bin_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_4_Title)

            Dim Ans_F_Bin_4 As New TextBox
            Ans_F_Bin_4.Text = pKOTSUHOTEL_DATA.ANS_F_BIN_4
            Ans_F_Bin_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Bin_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_4.CanGrow = True
            Ans_F_Bin_4.CanShrink = True
            Ans_F_Bin_4.WordWrap = False
            Ans_F_Bin_4.Alignment = TextAlignment.Left
            Ans_F_Bin_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_4)

            RowNo += 1

            Dim Ans_F_Airport1_4_Title As New Label
            Ans_F_Airport1_4_Title.Text = "発地："
            Ans_F_Airport1_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_4_Title.Alignment = TextAlignment.Left
            Ans_F_Airport1_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_4_Title)

            Dim Ans_F_Airport1_4 As New TextBox
            Ans_F_Airport1_4.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT1_4
            Ans_F_Airport1_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_4.CanGrow = True
            Ans_F_Airport1_4.CanShrink = True
            Ans_F_Airport1_4.WordWrap = False
            Ans_F_Airport1_4.Alignment = TextAlignment.Left
            Ans_F_Airport1_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_4)

            Dim Ans_F_Airport2_4_Title As New Label
            Ans_F_Airport2_4_Title.Text = "着地："
            Ans_F_Airport2_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_4_Title.Alignment = TextAlignment.Left
            Ans_F_Airport2_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_4_Title)

            Dim Ans_F_Airport2_4 As New TextBox
            Ans_F_Airport2_4.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT2_4
            Ans_F_Airport2_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_4.CanGrow = True
            Ans_F_Airport2_4.CanShrink = True
            Ans_F_Airport2_4.WordWrap = False
            Ans_F_Airport2_4.Alignment = TextAlignment.Left
            Ans_F_Airport2_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_4)

            RowNo += 1

            Dim Ans_F_Time1_4_Title As New Label
            Ans_F_Time1_4_Title.Text = "発時間："
            Ans_F_Time1_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_4_Title.Alignment = TextAlignment.Left
            Ans_F_Time1_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_4_Title)

            Dim Ans_F_Time1_4 As New TextBox
            Ans_F_Time1_4.Text = pKOTSUHOTEL_DATA.ANS_F_TIME1_4
            Ans_F_Time1_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_4.CanGrow = True
            Ans_F_Time1_4.CanShrink = True
            Ans_F_Time1_4.WordWrap = False
            Ans_F_Time1_4.Alignment = TextAlignment.Left
            Ans_F_Time1_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_4)

            Dim Ans_F_Time2_4_Title As New Label
            Ans_F_Time2_4_Title.Text = "着時間："
            Ans_F_Time2_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Time2_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_4_Title.Alignment = TextAlignment.Left
            Ans_F_Time2_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_4_Title)

            Dim Ans_F_Time2_4 As New TextBox
            Ans_F_Time2_4.Text = pKOTSUHOTEL_DATA.ANS_F_TIME2_4
            Ans_F_Time2_4.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Time2_4.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_4.CanGrow = True
            Ans_F_Time2_4.CanShrink = True
            Ans_F_Time2_4.WordWrap = False
            Ans_F_Time2_4.Alignment = TextAlignment.Left
            Ans_F_Time2_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_4)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        '復路５手配済
        If pKOTSUHOTEL_DATA.ANS_F_STATUS_5 = AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK Then
            If Not KotsuFlg Then
                KotsuFlg = True
                Dim KotsuTitle As New Label
                KotsuTitle.Text = "【交通】"
                KotsuTitle.Height = RowHeight
                KotsuTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                KotsuTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(KotsuTitle)
            End If

            Dim Ouro1Title As New Label
            Ouro1Title.Text = "＜復路５＞"
            Ouro1Title.Size = New System.Drawing.SizeF(Me.CmToInch(HotelItemTitleWidth), Me.CmToInch(RowHeight))
            Ouro1Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ouro1Title.Alignment = TextAlignment.Left
            Ouro1Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ouro1Title)

            Dim Ans_F_Date_5_Title As New Label
            Ans_F_Date_5_Title.Text = "利用日："
            Ans_F_Date_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_5_Title.Alignment = TextAlignment.Left
            Ans_F_Date_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_5_Title)

            Dim Ans_F_Date_5 As New TextBox
            Ans_F_Date_5.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_F_DATE_5, CmnModule.DateFormatType.MD)
            Ans_F_Date_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Date_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Date_5.CanGrow = True
            Ans_F_Date_5.CanShrink = True
            Ans_F_Date_5.WordWrap = False
            Ans_F_Date_5.Alignment = TextAlignment.Left
            Ans_F_Date_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Date_5)

            Dim Ans_F_Bin_5_Title As New Label
            Ans_F_Bin_5_Title.Text = "乗車便名："
            Ans_F_Bin_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Bin_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_5_Title.Alignment = TextAlignment.Left
            Ans_F_Bin_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_5_Title)

            Dim Ans_F_Bin_5 As New TextBox
            Ans_F_Bin_5.Text = pKOTSUHOTEL_DATA.ANS_F_BIN_5
            Ans_F_Bin_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Bin_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Bin_5.CanGrow = True
            Ans_F_Bin_5.CanShrink = True
            Ans_F_Bin_5.WordWrap = False
            Ans_F_Bin_5.Alignment = TextAlignment.Left
            Ans_F_Bin_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Bin_5)

            RowNo += 1

            Dim Ans_F_Airport1_5_Title As New Label
            Ans_F_Airport1_5_Title.Text = "発地："
            Ans_F_Airport1_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_5_Title.Alignment = TextAlignment.Left
            Ans_F_Airport1_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_5_Title)

            Dim Ans_F_Airport1_5 As New TextBox
            Ans_F_Airport1_5.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT1_5
            Ans_F_Airport1_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Airport1_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport1_5.CanGrow = True
            Ans_F_Airport1_5.CanShrink = True
            Ans_F_Airport1_5.WordWrap = False
            Ans_F_Airport1_5.Alignment = TextAlignment.Left
            Ans_F_Airport1_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport1_5)

            Dim Ans_F_Airport2_5_Title As New Label
            Ans_F_Airport2_5_Title.Text = "着地："
            Ans_F_Airport2_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_5_Title.Alignment = TextAlignment.Left
            Ans_F_Airport2_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_5_Title)

            Dim Ans_F_Airport2_5 As New TextBox
            Ans_F_Airport2_5.Text = pKOTSUHOTEL_DATA.ANS_F_AIRPORT2_5
            Ans_F_Airport2_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Airport2_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Airport2_5.CanGrow = True
            Ans_F_Airport2_5.CanShrink = True
            Ans_F_Airport2_5.WordWrap = False
            Ans_F_Airport2_5.Alignment = TextAlignment.Left
            Ans_F_Airport2_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Airport2_5)

            RowNo += 1

            Dim Ans_F_Time1_5_Title As New Label
            Ans_F_Time1_5_Title.Text = "発時間："
            Ans_F_Time1_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_5_Title.Alignment = TextAlignment.Left
            Ans_F_Time1_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_5_Title)

            Dim Ans_F_Time1_5 As New TextBox
            Ans_F_Time1_5.Text = pKOTSUHOTEL_DATA.ANS_F_TIME1_5
            Ans_F_Time1_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemWidth2), Me.CmToInch(RowHeight))
            Ans_F_Time1_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time1_5.CanGrow = True
            Ans_F_Time1_5.CanShrink = True
            Ans_F_Time1_5.WordWrap = False
            Ans_F_Time1_5.Alignment = TextAlignment.Left
            Ans_F_Time1_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time1_5)

            Dim Ans_F_Time2_5_Title As New Label
            Ans_F_Time2_5_Title.Text = "着時間："
            Ans_F_Time2_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_F_Time2_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_5_Title.Alignment = TextAlignment.Left
            Ans_F_Time2_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_5_Title)

            Dim Ans_F_Time2_5 As New TextBox
            Ans_F_Time2_5.Text = pKOTSUHOTEL_DATA.ANS_F_TIME2_5
            Ans_F_Time2_5.Size = New System.Drawing.SizeF(Me.CmToInch(KotsuItemTitleX3), Me.CmToInch(RowHeight))
            Ans_F_Time2_5.Location = New System.Drawing.PointF(Me.CmToInch(KotsuItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_F_Time2_5.CanGrow = True
            Ans_F_Time2_5.CanShrink = True
            Ans_F_Time2_5.WordWrap = False
            Ans_F_Time2_5.Alignment = TextAlignment.Left
            Ans_F_Time2_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_F_Time2_5)

            RowNo += 2
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１手配済
        Dim TaxiFlg As Boolean = False
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_1.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_1_Title As New Label
            Ans_Taxi_Date_1_Title.Text = "利用日："
            Ans_Taxi_Date_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_1_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_1_Title)

            Dim Ans_Taxi_Date_1 As New TextBox
            Ans_Taxi_Date_1.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_1, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_1.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_1.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_1.CanGrow = True
            Ans_Taxi_Date_1.CanShrink = True
            Ans_Taxi_Date_1.WordWrap = False
            Ans_Taxi_Date_1.Alignment = TextAlignment.Left
            Ans_Taxi_Date_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_1)

            Dim Ans_Taxi_Kenshu_1 As New TextBox
            Ans_Taxi_Kenshu_1.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_1)
            Ans_Taxi_Kenshu_1.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_1.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_1.CanGrow = True
            Ans_Taxi_Kenshu_1.CanShrink = True
            Ans_Taxi_Kenshu_1.WordWrap = False
            Ans_Taxi_Kenshu_1.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_1)

            Dim Ans_Taxi_No_1_Title As New Label
            Ans_Taxi_No_1_Title.Text = "チケット番号："
            Ans_Taxi_No_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_1_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_1_Title)

            Dim ANS_TAXI_NO_1 As New TextBox
            ANS_TAXI_NO_1.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_1
            ANS_TAXI_NO_1.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_1.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_1.CanGrow = True
            ANS_TAXI_NO_1.CanShrink = True
            ANS_TAXI_NO_1.WordWrap = False
            ANS_TAXI_NO_1.Alignment = TextAlignment.Left
            ANS_TAXI_NO_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_1)

            Dim Ans_Taxi_Rmks_1_Title As New Label
            Ans_Taxi_Rmks_1_Title.Text = "備考："
            Ans_Taxi_Rmks_1_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_1_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_1_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_1_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_1_Title)

            Dim Ans_Taxi_Rmks_1 As New TextBox
            'Ans_Taxi_Rmks_1.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_1
            Ans_Taxi_Rmks_1.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_1.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_1.CanGrow = True
            Ans_Taxi_Rmks_1.CanShrink = True
            Ans_Taxi_Rmks_1.WordWrap = False
            Ans_Taxi_Rmks_1.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_1)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ２手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_2.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_2_Title As New Label
            Ans_Taxi_Date_2_Title.Text = "利用日："
            Ans_Taxi_Date_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_2_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_2_Title)

            Dim Ans_Taxi_Date_2 As New TextBox
            Ans_Taxi_Date_2.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_2, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_2.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_2.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_2.CanGrow = True
            Ans_Taxi_Date_2.CanShrink = True
            Ans_Taxi_Date_2.WordWrap = False
            Ans_Taxi_Date_2.Alignment = TextAlignment.Left
            Ans_Taxi_Date_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_2)

            Dim Ans_Taxi_Kenshu_2 As New TextBox
            Ans_Taxi_Kenshu_2.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_2)
            Ans_Taxi_Kenshu_2.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_2.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_2.CanGrow = True
            Ans_Taxi_Kenshu_2.CanShrink = True
            Ans_Taxi_Kenshu_2.WordWrap = False
            Ans_Taxi_Kenshu_2.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_2)

            Dim Ans_Taxi_No_2_Title As New Label
            Ans_Taxi_No_2_Title.Text = "チケット番号："
            Ans_Taxi_No_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_2_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_2_Title)

            Dim ANS_TAXI_NO_2 As New TextBox
            ANS_TAXI_NO_2.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_2
            ANS_TAXI_NO_2.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_2.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_2.CanGrow = True
            ANS_TAXI_NO_2.CanShrink = True
            ANS_TAXI_NO_2.WordWrap = False
            ANS_TAXI_NO_2.Alignment = TextAlignment.Left
            ANS_TAXI_NO_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_2)

            Dim Ans_Taxi_Rmks_2_Title As New Label
            Ans_Taxi_Rmks_2_Title.Text = "備考："
            Ans_Taxi_Rmks_2_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_2_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_2_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_2_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_2_Title)

            Dim Ans_Taxi_Rmks_2 As New TextBox
            'Ans_Taxi_Rmks_2.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_2
            Ans_Taxi_Rmks_2.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_2.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_2.CanGrow = True
            Ans_Taxi_Rmks_2.CanShrink = True
            Ans_Taxi_Rmks_2.WordWrap = False
            Ans_Taxi_Rmks_2.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_2.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_2)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ３手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_3.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_3_Title As New Label
            Ans_Taxi_Date_3_Title.Text = "利用日："
            Ans_Taxi_Date_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_3_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_3_Title)

            Dim Ans_Taxi_Date_3 As New TextBox
            Ans_Taxi_Date_3.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_3, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_3.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_3.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_3.CanGrow = True
            Ans_Taxi_Date_3.CanShrink = True
            Ans_Taxi_Date_3.WordWrap = False
            Ans_Taxi_Date_3.Alignment = TextAlignment.Left
            Ans_Taxi_Date_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_3)

            Dim Ans_Taxi_Kenshu_3 As New TextBox
            Ans_Taxi_Kenshu_3.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_3)
            Ans_Taxi_Kenshu_3.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_3.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_3.CanGrow = True
            Ans_Taxi_Kenshu_3.CanShrink = True
            Ans_Taxi_Kenshu_3.WordWrap = False
            Ans_Taxi_Kenshu_3.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_3)

            Dim Ans_Taxi_No_3_Title As New Label
            Ans_Taxi_No_3_Title.Text = "チケット番号："
            Ans_Taxi_No_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_3_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_3_Title)

            Dim ANS_TAXI_NO_3 As New TextBox
            ANS_TAXI_NO_3.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_3
            ANS_TAXI_NO_3.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_3.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_3.CanGrow = True
            ANS_TAXI_NO_3.CanShrink = True
            ANS_TAXI_NO_3.WordWrap = False
            ANS_TAXI_NO_3.Alignment = TextAlignment.Left
            ANS_TAXI_NO_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_3)

            Dim Ans_Taxi_Rmks_3_Title As New Label
            Ans_Taxi_Rmks_3_Title.Text = "備考："
            Ans_Taxi_Rmks_3_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_3_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_3_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_3_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_3_Title)

            Dim Ans_Taxi_Rmks_3 As New TextBox
            'Ans_Taxi_Rmks_3.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_3
            Ans_Taxi_Rmks_3.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_3.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_3.CanGrow = True
            Ans_Taxi_Rmks_3.CanShrink = True
            Ans_Taxi_Rmks_3.WordWrap = False
            Ans_Taxi_Rmks_3.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_3.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_3)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ４手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_4.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_4_Title As New Label
            Ans_Taxi_Date_4_Title.Text = "利用日："
            Ans_Taxi_Date_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_4_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_4_Title)

            Dim Ans_Taxi_Date_4 As New TextBox
            Ans_Taxi_Date_4.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_4, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_4.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_4.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_4.CanGrow = True
            Ans_Taxi_Date_4.CanShrink = True
            Ans_Taxi_Date_4.WordWrap = False
            Ans_Taxi_Date_4.Alignment = TextAlignment.Left
            Ans_Taxi_Date_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_4)

            Dim Ans_Taxi_Kenshu_4 As New TextBox
            Ans_Taxi_Kenshu_4.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_4)
            Ans_Taxi_Kenshu_4.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_4.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_4.CanGrow = True
            Ans_Taxi_Kenshu_4.CanShrink = True
            Ans_Taxi_Kenshu_4.WordWrap = False
            Ans_Taxi_Kenshu_4.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_4)

            Dim Ans_Taxi_No_4_Title As New Label
            Ans_Taxi_No_4_Title.Text = "チケット番号："
            Ans_Taxi_No_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_4_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_4_Title)

            Dim ANS_TAXI_NO_4 As New TextBox
            ANS_TAXI_NO_4.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_4
            ANS_TAXI_NO_4.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_4.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_4.CanGrow = True
            ANS_TAXI_NO_4.CanShrink = True
            ANS_TAXI_NO_4.WordWrap = False
            ANS_TAXI_NO_4.Alignment = TextAlignment.Left
            ANS_TAXI_NO_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_4)

            Dim Ans_Taxi_Rmks_4_Title As New Label
            Ans_Taxi_Rmks_4_Title.Text = "備考："
            Ans_Taxi_Rmks_4_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_4_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_4_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_4_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_4_Title)

            Dim Ans_Taxi_Rmks_4 As New TextBox
            'Ans_Taxi_Rmks_4.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_4
            Ans_Taxi_Rmks_4.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_4.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_4.CanGrow = True
            Ans_Taxi_Rmks_4.CanShrink = True
            Ans_Taxi_Rmks_4.WordWrap = False
            Ans_Taxi_Rmks_4.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_4.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_4)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ５手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_5.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_5_Title As New Label
            Ans_Taxi_Date_5_Title.Text = "利用日："
            Ans_Taxi_Date_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_5_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_5_Title)

            Dim Ans_Taxi_Date_5 As New TextBox
            Ans_Taxi_Date_5.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_5, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_5.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_5.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_5.CanGrow = True
            Ans_Taxi_Date_5.CanShrink = True
            Ans_Taxi_Date_5.WordWrap = False
            Ans_Taxi_Date_5.Alignment = TextAlignment.Left
            Ans_Taxi_Date_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_5)

            Dim Ans_Taxi_Kenshu_5 As New TextBox
            Ans_Taxi_Kenshu_5.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_5)
            Ans_Taxi_Kenshu_5.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_5.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_5.CanGrow = True
            Ans_Taxi_Kenshu_5.CanShrink = True
            Ans_Taxi_Kenshu_5.WordWrap = False
            Ans_Taxi_Kenshu_5.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_5)

            Dim Ans_Taxi_No_5_Title As New Label
            Ans_Taxi_No_5_Title.Text = "チケット番号："
            Ans_Taxi_No_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_5_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_5_Title)

            Dim ANS_TAXI_NO_5 As New TextBox
            ANS_TAXI_NO_5.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_5
            ANS_TAXI_NO_5.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_5.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_5.CanGrow = True
            ANS_TAXI_NO_5.CanShrink = True
            ANS_TAXI_NO_5.WordWrap = False
            ANS_TAXI_NO_5.Alignment = TextAlignment.Left
            ANS_TAXI_NO_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_5)

            Dim Ans_Taxi_Rmks_5_Title As New Label
            Ans_Taxi_Rmks_5_Title.Text = "備考："
            Ans_Taxi_Rmks_5_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_5_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_5_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_5_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_5_Title)

            Dim Ans_Taxi_Rmks_5 As New TextBox
            'Ans_Taxi_Rmks_5.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_5
            Ans_Taxi_Rmks_5.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_5.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_5.CanGrow = True
            Ans_Taxi_Rmks_5.CanShrink = True
            Ans_Taxi_Rmks_5.WordWrap = False
            Ans_Taxi_Rmks_5.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_5.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_5)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ６手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_6.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_6_Title As New Label
            Ans_Taxi_Date_6_Title.Text = "利用日："
            Ans_Taxi_Date_6_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_6_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_6_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_6_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_6_Title)

            Dim Ans_Taxi_Date_6 As New TextBox
            Ans_Taxi_Date_6.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_6, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_6.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_6.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_6.CanGrow = True
            Ans_Taxi_Date_6.CanShrink = True
            Ans_Taxi_Date_6.WordWrap = False
            Ans_Taxi_Date_6.Alignment = TextAlignment.Left
            Ans_Taxi_Date_6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_6)

            Dim Ans_Taxi_Kenshu_6 As New TextBox
            Ans_Taxi_Kenshu_6.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_6)
            Ans_Taxi_Kenshu_6.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_6.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_6.CanGrow = True
            Ans_Taxi_Kenshu_6.CanShrink = True
            Ans_Taxi_Kenshu_6.WordWrap = False
            Ans_Taxi_Kenshu_6.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_6)

            Dim Ans_Taxi_No_6_Title As New Label
            Ans_Taxi_No_6_Title.Text = "チケット番号："
            Ans_Taxi_No_6_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_6_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_6_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_6_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_6_Title)

            Dim ANS_TAXI_NO_6 As New TextBox
            ANS_TAXI_NO_6.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_6
            ANS_TAXI_NO_6.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_6.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_6.CanGrow = True
            ANS_TAXI_NO_6.CanShrink = True
            ANS_TAXI_NO_6.WordWrap = False
            ANS_TAXI_NO_6.Alignment = TextAlignment.Left
            ANS_TAXI_NO_6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_6)

            Dim Ans_Taxi_Rmks_6_Title As New Label
            Ans_Taxi_Rmks_6_Title.Text = "備考："
            Ans_Taxi_Rmks_6_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_6_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_6_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_6_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_6_Title)

            Dim Ans_Taxi_Rmks_6 As New TextBox
            'Ans_Taxi_Rmks_6.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_6
            Ans_Taxi_Rmks_6.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_6.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_6.CanGrow = True
            Ans_Taxi_Rmks_6.CanShrink = True
            Ans_Taxi_Rmks_6.WordWrap = False
            Ans_Taxi_Rmks_6.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_6.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_6)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ７手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_7.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_7_Title As New Label
            Ans_Taxi_Date_7_Title.Text = "利用日："
            Ans_Taxi_Date_7_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_7_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_7_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_7_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_7_Title)

            Dim Ans_Taxi_Date_7 As New TextBox
            Ans_Taxi_Date_7.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_7, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_7.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_7.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_7.CanGrow = True
            Ans_Taxi_Date_7.CanShrink = True
            Ans_Taxi_Date_7.WordWrap = False
            Ans_Taxi_Date_7.Alignment = TextAlignment.Left
            Ans_Taxi_Date_7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_7)

            Dim Ans_Taxi_Kenshu_7 As New TextBox
            Ans_Taxi_Kenshu_7.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_7)
            Ans_Taxi_Kenshu_7.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_7.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_7.CanGrow = True
            Ans_Taxi_Kenshu_7.CanShrink = True
            Ans_Taxi_Kenshu_7.WordWrap = False
            Ans_Taxi_Kenshu_7.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_7)

            Dim Ans_Taxi_No_7_Title As New Label
            Ans_Taxi_No_7_Title.Text = "チケット番号："
            Ans_Taxi_No_7_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_7_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_7_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_7_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_7_Title)

            Dim ANS_TAXI_NO_7 As New TextBox
            ANS_TAXI_NO_7.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_7
            ANS_TAXI_NO_7.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_7.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_7.CanGrow = True
            ANS_TAXI_NO_7.CanShrink = True
            ANS_TAXI_NO_7.WordWrap = False
            ANS_TAXI_NO_7.Alignment = TextAlignment.Left
            ANS_TAXI_NO_7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_7)

            Dim Ans_Taxi_Rmks_7_Title As New Label
            Ans_Taxi_Rmks_7_Title.Text = "備考："
            Ans_Taxi_Rmks_7_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_7_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_7_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_7_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_7_Title)

            Dim Ans_Taxi_Rmks_7 As New TextBox
            'Ans_Taxi_Rmks_7.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_7
            Ans_Taxi_Rmks_7.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_7.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_7.CanGrow = True
            Ans_Taxi_Rmks_7.CanShrink = True
            Ans_Taxi_Rmks_7.WordWrap = False
            Ans_Taxi_Rmks_7.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_7.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_7)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ８手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_8.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_8_Title As New Label
            Ans_Taxi_Date_8_Title.Text = "利用日："
            Ans_Taxi_Date_8_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_8_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_8_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_8_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_8_Title)

            Dim Ans_Taxi_Date_8 As New TextBox
            Ans_Taxi_Date_8.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_8, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_8.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_8.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_8.CanGrow = True
            Ans_Taxi_Date_8.CanShrink = True
            Ans_Taxi_Date_8.WordWrap = False
            Ans_Taxi_Date_8.Alignment = TextAlignment.Left
            Ans_Taxi_Date_8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_8)

            Dim Ans_Taxi_Kenshu_8 As New TextBox
            Ans_Taxi_Kenshu_8.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_8)
            Ans_Taxi_Kenshu_8.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_8.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_8.CanGrow = True
            Ans_Taxi_Kenshu_8.CanShrink = True
            Ans_Taxi_Kenshu_8.WordWrap = False
            Ans_Taxi_Kenshu_8.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_8)

            Dim Ans_Taxi_No_8_Title As New Label
            Ans_Taxi_No_8_Title.Text = "チケット番号："
            Ans_Taxi_No_8_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_8_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_8_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_8_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_8_Title)

            Dim ANS_TAXI_NO_8 As New TextBox
            ANS_TAXI_NO_8.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_8
            ANS_TAXI_NO_8.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_8.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_8.CanGrow = True
            ANS_TAXI_NO_8.CanShrink = True
            ANS_TAXI_NO_8.WordWrap = False
            ANS_TAXI_NO_8.Alignment = TextAlignment.Left
            ANS_TAXI_NO_8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_8)

            Dim Ans_Taxi_Rmks_8_Title As New Label
            Ans_Taxi_Rmks_8_Title.Text = "備考："
            Ans_Taxi_Rmks_8_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_8_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_8_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_8_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_8_Title)

            Dim Ans_Taxi_Rmks_8 As New TextBox
            'Ans_Taxi_Rmks_8.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_8
            Ans_Taxi_Rmks_8.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_8.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_8.CanGrow = True
            Ans_Taxi_Rmks_8.CanShrink = True
            Ans_Taxi_Rmks_8.WordWrap = False
            Ans_Taxi_Rmks_8.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_8.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_8)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ９手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_9.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_9_Title As New Label
            Ans_Taxi_Date_9_Title.Text = "利用日："
            Ans_Taxi_Date_9_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_9_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_9_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_9_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_9_Title)

            Dim Ans_Taxi_Date_9 As New TextBox
            Ans_Taxi_Date_9.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_9, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_9.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_9.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_9.CanGrow = True
            Ans_Taxi_Date_9.CanShrink = True
            Ans_Taxi_Date_9.WordWrap = False
            Ans_Taxi_Date_9.Alignment = TextAlignment.Left
            Ans_Taxi_Date_9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_9)

            Dim Ans_Taxi_Kenshu_9 As New TextBox
            Ans_Taxi_Kenshu_9.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_9)
            Ans_Taxi_Kenshu_9.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_9.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_9.CanGrow = True
            Ans_Taxi_Kenshu_9.CanShrink = True
            Ans_Taxi_Kenshu_9.WordWrap = False
            Ans_Taxi_Kenshu_9.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_9)

            Dim Ans_Taxi_No_9_Title As New Label
            Ans_Taxi_No_9_Title.Text = "チケット番号："
            Ans_Taxi_No_9_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_9_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_9_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_9_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_9_Title)

            Dim ANS_TAXI_NO_9 As New TextBox
            ANS_TAXI_NO_9.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_9
            ANS_TAXI_NO_9.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_9.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_9.CanGrow = True
            ANS_TAXI_NO_9.CanShrink = True
            ANS_TAXI_NO_9.WordWrap = False
            ANS_TAXI_NO_9.Alignment = TextAlignment.Left
            ANS_TAXI_NO_9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_9)

            Dim Ans_Taxi_Rmks_9_Title As New Label
            Ans_Taxi_Rmks_9_Title.Text = "備考："
            Ans_Taxi_Rmks_9_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_9_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_9_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_9_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_9_Title)

            Dim Ans_Taxi_Rmks_9 As New TextBox
            'Ans_Taxi_Rmks_9.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_9
            Ans_Taxi_Rmks_9.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_9.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_9.CanGrow = True
            Ans_Taxi_Rmks_9.CanShrink = True
            Ans_Taxi_Rmks_9.WordWrap = False
            Ans_Taxi_Rmks_9.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_9.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_9)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１０手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_10.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_10_Title As New Label
            Ans_Taxi_Date_10_Title.Text = "利用日："
            Ans_Taxi_Date_10_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_10_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_10_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_10_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_10_Title)

            Dim Ans_Taxi_Date_10 As New TextBox
            Ans_Taxi_Date_10.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_10, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_10.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_10.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_10.CanGrow = True
            Ans_Taxi_Date_10.CanShrink = True
            Ans_Taxi_Date_10.WordWrap = False
            Ans_Taxi_Date_10.Alignment = TextAlignment.Left
            Ans_Taxi_Date_10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_10)

            Dim Ans_Taxi_Kenshu_10 As New TextBox
            Ans_Taxi_Kenshu_10.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_10)
            Ans_Taxi_Kenshu_10.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_10.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_10.CanGrow = True
            Ans_Taxi_Kenshu_10.CanShrink = True
            Ans_Taxi_Kenshu_10.WordWrap = False
            Ans_Taxi_Kenshu_10.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_10)

            Dim Ans_Taxi_No_10_Title As New Label
            Ans_Taxi_No_10_Title.Text = "チケット番号："
            Ans_Taxi_No_10_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_10_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_10_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_10_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_10_Title)

            Dim ANS_TAXI_NO_10 As New TextBox
            ANS_TAXI_NO_10.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_10
            ANS_TAXI_NO_10.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_10.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_10.CanGrow = True
            ANS_TAXI_NO_10.CanShrink = True
            ANS_TAXI_NO_10.WordWrap = False
            ANS_TAXI_NO_10.Alignment = TextAlignment.Left
            ANS_TAXI_NO_10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_10)

            Dim Ans_Taxi_Rmks_10_Title As New Label
            Ans_Taxi_Rmks_10_Title.Text = "備考："
            Ans_Taxi_Rmks_10_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_10_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_10_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_10_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_10_Title)

            Dim Ans_Taxi_Rmks_10 As New TextBox
            'Ans_Taxi_Rmks_10.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_10
            Ans_Taxi_Rmks_10.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_10.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_10.CanGrow = True
            Ans_Taxi_Rmks_10.CanShrink = True
            Ans_Taxi_Rmks_10.WordWrap = False
            Ans_Taxi_Rmks_10.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_10.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_10)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１１手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_11.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_11_Title As New Label
            Ans_Taxi_Date_11_Title.Text = "利用日："
            Ans_Taxi_Date_11_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_11_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_11_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_11_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_11_Title)

            Dim Ans_Taxi_Date_11 As New TextBox
            Ans_Taxi_Date_11.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_11, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_11.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_11.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_11.CanGrow = True
            Ans_Taxi_Date_11.CanShrink = True
            Ans_Taxi_Date_11.WordWrap = False
            Ans_Taxi_Date_11.Alignment = TextAlignment.Left
            Ans_Taxi_Date_11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_11)

            Dim Ans_Taxi_Kenshu_11 As New TextBox
            Ans_Taxi_Kenshu_11.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_11)
            Ans_Taxi_Kenshu_11.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_11.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_11.CanGrow = True
            Ans_Taxi_Kenshu_11.CanShrink = True
            Ans_Taxi_Kenshu_11.WordWrap = False
            Ans_Taxi_Kenshu_11.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_11)

            Dim Ans_Taxi_No_11_Title As New Label
            Ans_Taxi_No_11_Title.Text = "チケット番号："
            Ans_Taxi_No_11_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_11_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_11_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_11_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_11_Title)

            Dim ANS_TAXI_NO_11 As New TextBox
            ANS_TAXI_NO_11.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_11
            ANS_TAXI_NO_11.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_11.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_11.CanGrow = True
            ANS_TAXI_NO_11.CanShrink = True
            ANS_TAXI_NO_11.WordWrap = False
            ANS_TAXI_NO_11.Alignment = TextAlignment.Left
            ANS_TAXI_NO_11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_11)

            Dim Ans_Taxi_Rmks_11_Title As New Label
            Ans_Taxi_Rmks_11_Title.Text = "備考："
            Ans_Taxi_Rmks_11_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_11_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_11_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_11_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_11_Title)

            Dim Ans_Taxi_Rmks_11 As New TextBox
            'Ans_Taxi_Rmks_11.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_11
            Ans_Taxi_Rmks_11.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_11.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_11.CanGrow = True
            Ans_Taxi_Rmks_11.CanShrink = True
            Ans_Taxi_Rmks_11.WordWrap = False
            Ans_Taxi_Rmks_11.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_11.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_11)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１２手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_12.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_12_Title As New Label
            Ans_Taxi_Date_12_Title.Text = "利用日："
            Ans_Taxi_Date_12_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_12_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_12_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_12_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_12_Title)

            Dim Ans_Taxi_Date_12 As New TextBox
            Ans_Taxi_Date_12.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_12, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_12.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_12.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_12.CanGrow = True
            Ans_Taxi_Date_12.CanShrink = True
            Ans_Taxi_Date_12.WordWrap = False
            Ans_Taxi_Date_12.Alignment = TextAlignment.Left
            Ans_Taxi_Date_12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_12)

            Dim Ans_Taxi_Kenshu_12 As New TextBox
            Ans_Taxi_Kenshu_12.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_12)
            Ans_Taxi_Kenshu_12.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_12.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_12.CanGrow = True
            Ans_Taxi_Kenshu_12.CanShrink = True
            Ans_Taxi_Kenshu_12.WordWrap = False
            Ans_Taxi_Kenshu_12.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_12)

            Dim Ans_Taxi_No_12_Title As New Label
            Ans_Taxi_No_12_Title.Text = "チケット番号："
            Ans_Taxi_No_12_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_12_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_12_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_12_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_12_Title)

            Dim ANS_TAXI_NO_12 As New TextBox
            ANS_TAXI_NO_12.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_12
            ANS_TAXI_NO_12.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_12.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_12.CanGrow = True
            ANS_TAXI_NO_12.CanShrink = True
            ANS_TAXI_NO_12.WordWrap = False
            ANS_TAXI_NO_12.Alignment = TextAlignment.Left
            ANS_TAXI_NO_12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_12)

            Dim Ans_Taxi_Rmks_12_Title As New Label
            Ans_Taxi_Rmks_12_Title.Text = "備考："
            Ans_Taxi_Rmks_12_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_12_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_12_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_12_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_12_Title)

            Dim Ans_Taxi_Rmks_12 As New TextBox
            'Ans_Taxi_Rmks_12.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_12
            Ans_Taxi_Rmks_12.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_12.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_12.CanGrow = True
            Ans_Taxi_Rmks_12.CanShrink = True
            Ans_Taxi_Rmks_12.WordWrap = False
            Ans_Taxi_Rmks_12.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_12)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１３手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_13.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_13_Title As New Label
            Ans_Taxi_Date_13_Title.Text = "利用日："
            Ans_Taxi_Date_13_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_13_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_13_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_13_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_13_Title)

            Dim Ans_Taxi_Date_13 As New TextBox
            Ans_Taxi_Date_13.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_13, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_13.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_13.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_13.CanGrow = True
            Ans_Taxi_Date_13.CanShrink = True
            Ans_Taxi_Date_13.WordWrap = False
            Ans_Taxi_Date_13.Alignment = TextAlignment.Left
            Ans_Taxi_Date_13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_13)

            Dim Ans_Taxi_Kenshu_13 As New TextBox
            Ans_Taxi_Kenshu_13.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_13)
            Ans_Taxi_Kenshu_13.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_13.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_13.CanGrow = True
            Ans_Taxi_Kenshu_13.CanShrink = True
            Ans_Taxi_Kenshu_13.WordWrap = False
            Ans_Taxi_Kenshu_13.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_13)

            Dim Ans_Taxi_No_13_Title As New Label
            Ans_Taxi_No_13_Title.Text = "チケット番号："
            Ans_Taxi_No_13_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_13_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_13_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_13_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_13_Title)

            Dim ANS_TAXI_NO_13 As New TextBox
            ANS_TAXI_NO_13.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_13
            ANS_TAXI_NO_13.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_13.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_13.CanGrow = True
            ANS_TAXI_NO_13.CanShrink = True
            ANS_TAXI_NO_13.WordWrap = False
            ANS_TAXI_NO_13.Alignment = TextAlignment.Left
            ANS_TAXI_NO_13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_13)

            Dim Ans_Taxi_Rmks_13_Title As New Label
            Ans_Taxi_Rmks_13_Title.Text = "備考："
            Ans_Taxi_Rmks_13_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_13_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_13_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_13_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_13_Title)

            Dim Ans_Taxi_Rmks_13 As New TextBox
            'Ans_Taxi_Rmks_13.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_13
            Ans_Taxi_Rmks_13.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_13.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_13.CanGrow = True
            Ans_Taxi_Rmks_13.CanShrink = True
            Ans_Taxi_Rmks_13.WordWrap = False
            Ans_Taxi_Rmks_13.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_13.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_13)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１４手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_14.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_14_Title As New Label
            Ans_Taxi_Date_14_Title.Text = "利用日："
            Ans_Taxi_Date_14_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_14_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_14_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_14_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_14_Title)

            Dim Ans_Taxi_Date_14 As New TextBox
            Ans_Taxi_Date_14.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_14, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_14.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_14.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_14.CanGrow = True
            Ans_Taxi_Date_14.CanShrink = True
            Ans_Taxi_Date_14.WordWrap = False
            Ans_Taxi_Date_14.Alignment = TextAlignment.Left
            Ans_Taxi_Date_14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_14)

            Dim Ans_Taxi_Kenshu_14 As New TextBox
            Ans_Taxi_Kenshu_14.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_14)
            Ans_Taxi_Kenshu_14.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_14.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_14.CanGrow = True
            Ans_Taxi_Kenshu_14.CanShrink = True
            Ans_Taxi_Kenshu_14.WordWrap = False
            Ans_Taxi_Kenshu_14.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_14)

            Dim Ans_Taxi_No_14_Title As New Label
            Ans_Taxi_No_14_Title.Text = "チケット番号："
            Ans_Taxi_No_14_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_14_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_14_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_14_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_14_Title)

            Dim ANS_TAXI_NO_14 As New TextBox
            ANS_TAXI_NO_14.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_14
            ANS_TAXI_NO_14.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_14.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_14.CanGrow = True
            ANS_TAXI_NO_14.CanShrink = True
            ANS_TAXI_NO_14.WordWrap = False
            ANS_TAXI_NO_14.Alignment = TextAlignment.Left
            ANS_TAXI_NO_14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_14)

            Dim Ans_Taxi_Rmks_14_Title As New Label
            Ans_Taxi_Rmks_14_Title.Text = "備考："
            Ans_Taxi_Rmks_14_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_14_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_14_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_14_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_14_Title)

            Dim Ans_Taxi_Rmks_14 As New TextBox
            'Ans_Taxi_Rmks_14.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_14
            Ans_Taxi_Rmks_14.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_14.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_14.CanGrow = True
            Ans_Taxi_Rmks_14.CanShrink = True
            Ans_Taxi_Rmks_14.WordWrap = False
            Ans_Taxi_Rmks_14.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_14.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_14)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１５手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_15.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_15_Title As New Label
            Ans_Taxi_Date_15_Title.Text = "利用日："
            Ans_Taxi_Date_15_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_15_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_15_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_15_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_15_Title)

            Dim Ans_Taxi_Date_15 As New TextBox
            Ans_Taxi_Date_15.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_15, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_15.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_15.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_15.CanGrow = True
            Ans_Taxi_Date_15.CanShrink = True
            Ans_Taxi_Date_15.WordWrap = False
            Ans_Taxi_Date_15.Alignment = TextAlignment.Left
            Ans_Taxi_Date_15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_15)

            Dim Ans_Taxi_Kenshu_15 As New TextBox
            Ans_Taxi_Kenshu_15.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_15)
            Ans_Taxi_Kenshu_15.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_15.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_15.CanGrow = True
            Ans_Taxi_Kenshu_15.CanShrink = True
            Ans_Taxi_Kenshu_15.WordWrap = False
            Ans_Taxi_Kenshu_15.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_15)

            Dim Ans_Taxi_No_15_Title As New Label
            Ans_Taxi_No_15_Title.Text = "チケット番号："
            Ans_Taxi_No_15_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_15_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_15_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_15_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_15_Title)

            Dim ANS_TAXI_NO_15 As New TextBox
            ANS_TAXI_NO_15.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_15
            ANS_TAXI_NO_15.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_15.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_15.CanGrow = True
            ANS_TAXI_NO_15.CanShrink = True
            ANS_TAXI_NO_15.WordWrap = False
            ANS_TAXI_NO_15.Alignment = TextAlignment.Left
            ANS_TAXI_NO_15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_15)

            Dim Ans_Taxi_Rmks_15_Title As New Label
            Ans_Taxi_Rmks_15_Title.Text = "備考："
            Ans_Taxi_Rmks_15_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_15_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_15_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_15_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_15_Title)

            Dim Ans_Taxi_Rmks_15 As New TextBox
            'Ans_Taxi_Rmks_15.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_15
            Ans_Taxi_Rmks_15.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_15.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_15.CanGrow = True
            Ans_Taxi_Rmks_15.CanShrink = True
            Ans_Taxi_Rmks_15.WordWrap = False
            Ans_Taxi_Rmks_15.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_15.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_15)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１６手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_16.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_16_Title As New Label
            Ans_Taxi_Date_16_Title.Text = "利用日："
            Ans_Taxi_Date_16_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_16_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_16_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_16_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_16_Title)

            Dim Ans_Taxi_Date_16 As New TextBox
            Ans_Taxi_Date_16.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_16, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_16.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_16.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_16.CanGrow = True
            Ans_Taxi_Date_16.CanShrink = True
            Ans_Taxi_Date_16.WordWrap = False
            Ans_Taxi_Date_16.Alignment = TextAlignment.Left
            Ans_Taxi_Date_16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_16)

            Dim Ans_Taxi_Kenshu_16 As New TextBox
            Ans_Taxi_Kenshu_16.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_16)
            Ans_Taxi_Kenshu_16.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_16.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_16.CanGrow = True
            Ans_Taxi_Kenshu_16.CanShrink = True
            Ans_Taxi_Kenshu_16.WordWrap = False
            Ans_Taxi_Kenshu_16.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_16)

            Dim Ans_Taxi_No_16_Title As New Label
            Ans_Taxi_No_16_Title.Text = "チケット番号："
            Ans_Taxi_No_16_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_16_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_16_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_16_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_16_Title)

            Dim ANS_TAXI_NO_16 As New TextBox
            ANS_TAXI_NO_16.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_16
            ANS_TAXI_NO_16.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_16.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_16.CanGrow = True
            ANS_TAXI_NO_16.CanShrink = True
            ANS_TAXI_NO_16.WordWrap = False
            ANS_TAXI_NO_16.Alignment = TextAlignment.Left
            ANS_TAXI_NO_16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_16)

            Dim Ans_Taxi_Rmks_16_Title As New Label
            Ans_Taxi_Rmks_16_Title.Text = "備考："
            Ans_Taxi_Rmks_16_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_16_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_16_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_16_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_16_Title)

            Dim Ans_Taxi_Rmks_16 As New TextBox
            'Ans_Taxi_Rmks_16.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_16
            Ans_Taxi_Rmks_16.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_16.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_16.CanGrow = True
            Ans_Taxi_Rmks_16.CanShrink = True
            Ans_Taxi_Rmks_16.WordWrap = False
            Ans_Taxi_Rmks_16.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_16.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_16)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１７手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_17.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_17_Title As New Label
            Ans_Taxi_Date_17_Title.Text = "利用日："
            Ans_Taxi_Date_17_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_17_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_17_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_17_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_17_Title)

            Dim Ans_Taxi_Date_17 As New TextBox
            Ans_Taxi_Date_17.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_17, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_17.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_17.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_17.CanGrow = True
            Ans_Taxi_Date_17.CanShrink = True
            Ans_Taxi_Date_17.WordWrap = False
            Ans_Taxi_Date_17.Alignment = TextAlignment.Left
            Ans_Taxi_Date_17.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_17)

            Dim Ans_Taxi_Kenshu_17 As New TextBox
            Ans_Taxi_Kenshu_17.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_17)
            Ans_Taxi_Kenshu_17.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_17.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_17.CanGrow = True
            Ans_Taxi_Kenshu_17.CanShrink = True
            Ans_Taxi_Kenshu_17.WordWrap = False
            Ans_Taxi_Kenshu_17.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_17.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_17)

            Dim Ans_Taxi_No_17_Title As New Label
            Ans_Taxi_No_17_Title.Text = "チケット番号："
            Ans_Taxi_No_17_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_17_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_17_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_17_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_17_Title)

            Dim ANS_TAXI_NO_17 As New TextBox
            ANS_TAXI_NO_17.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_17
            ANS_TAXI_NO_17.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_17.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_17.CanGrow = True
            ANS_TAXI_NO_17.CanShrink = True
            ANS_TAXI_NO_17.WordWrap = False
            ANS_TAXI_NO_17.Alignment = TextAlignment.Left
            ANS_TAXI_NO_17.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_17)

            Dim Ans_Taxi_Rmks_17_Title As New Label
            Ans_Taxi_Rmks_17_Title.Text = "備考："
            Ans_Taxi_Rmks_17_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_17_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_17_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_17_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_17_Title)

            Dim Ans_Taxi_Rmks_17 As New TextBox
            'Ans_Taxi_Rmks_17.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_17
            Ans_Taxi_Rmks_17.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_17.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_17.CanGrow = True
            Ans_Taxi_Rmks_17.CanShrink = True
            Ans_Taxi_Rmks_17.WordWrap = False
            Ans_Taxi_Rmks_17.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_17.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_17)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１８手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_18.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_18_Title As New Label
            Ans_Taxi_Date_18_Title.Text = "利用日："
            Ans_Taxi_Date_18_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_18_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_18_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_18_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_18_Title)

            Dim Ans_Taxi_Date_18 As New TextBox
            Ans_Taxi_Date_18.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_18, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_18.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_18.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_18.CanGrow = True
            Ans_Taxi_Date_18.CanShrink = True
            Ans_Taxi_Date_18.WordWrap = False
            Ans_Taxi_Date_18.Alignment = TextAlignment.Left
            Ans_Taxi_Date_18.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_18)

            Dim Ans_Taxi_Kenshu_18 As New TextBox
            Ans_Taxi_Kenshu_18.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_18)
            Ans_Taxi_Kenshu_18.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_18.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_18.CanGrow = True
            Ans_Taxi_Kenshu_18.CanShrink = True
            Ans_Taxi_Kenshu_18.WordWrap = False
            Ans_Taxi_Kenshu_18.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_18.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_18)

            Dim Ans_Taxi_No_18_Title As New Label
            Ans_Taxi_No_18_Title.Text = "チケット番号："
            Ans_Taxi_No_18_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_18_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_18_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_18_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_18_Title)

            Dim ANS_TAXI_NO_18 As New TextBox
            ANS_TAXI_NO_18.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_18
            ANS_TAXI_NO_18.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_18.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_18.CanGrow = True
            ANS_TAXI_NO_18.CanShrink = True
            ANS_TAXI_NO_18.WordWrap = False
            ANS_TAXI_NO_18.Alignment = TextAlignment.Left
            ANS_TAXI_NO_18.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_18)

            Dim Ans_Taxi_Rmks_18_Title As New Label
            Ans_Taxi_Rmks_18_Title.Text = "備考："
            Ans_Taxi_Rmks_18_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_18_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_18_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_18_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_18_Title)

            Dim Ans_Taxi_Rmks_18 As New TextBox
            'Ans_Taxi_Rmks_18.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_18
            Ans_Taxi_Rmks_18.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_18.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_18.CanGrow = True
            Ans_Taxi_Rmks_18.CanShrink = True
            Ans_Taxi_Rmks_18.WordWrap = False
            Ans_Taxi_Rmks_18.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_18.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_18)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ１９手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_19.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_19_Title As New Label
            Ans_Taxi_Date_19_Title.Text = "利用日："
            Ans_Taxi_Date_19_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_19_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_19_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_19_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_19_Title)

            Dim Ans_Taxi_Date_19 As New TextBox
            Ans_Taxi_Date_19.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_19, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_19.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_19.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_19.CanGrow = True
            Ans_Taxi_Date_19.CanShrink = True
            Ans_Taxi_Date_19.WordWrap = False
            Ans_Taxi_Date_19.Alignment = TextAlignment.Left
            Ans_Taxi_Date_19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_19)

            Dim Ans_Taxi_Kenshu_19 As New TextBox
            Ans_Taxi_Kenshu_19.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_19)
            Ans_Taxi_Kenshu_19.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_19.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_19.CanGrow = True
            Ans_Taxi_Kenshu_19.CanShrink = True
            Ans_Taxi_Kenshu_19.WordWrap = False
            Ans_Taxi_Kenshu_19.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_19)

            Dim Ans_Taxi_No_19_Title As New Label
            Ans_Taxi_No_19_Title.Text = "チケット番号："
            Ans_Taxi_No_19_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_19_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_19_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_19_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_19_Title)

            Dim ANS_TAXI_NO_19 As New TextBox
            ANS_TAXI_NO_19.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_19
            ANS_TAXI_NO_19.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_19.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_19.CanGrow = True
            ANS_TAXI_NO_19.CanShrink = True
            ANS_TAXI_NO_19.WordWrap = False
            ANS_TAXI_NO_19.Alignment = TextAlignment.Left
            ANS_TAXI_NO_19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_19)

            Dim Ans_Taxi_Rmks_19_Title As New Label
            Ans_Taxi_Rmks_19_Title.Text = "備考："
            Ans_Taxi_Rmks_19_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_19_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_19_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_19_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_19_Title)

            Dim Ans_Taxi_Rmks_19 As New TextBox
            'Ans_Taxi_Rmks_19.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_19
            Ans_Taxi_Rmks_19.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_19.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_19.CanGrow = True
            Ans_Taxi_Rmks_19.CanShrink = True
            Ans_Taxi_Rmks_19.WordWrap = False
            Ans_Taxi_Rmks_19.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_19.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_19)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If

        'タクチケ２０手配済
        If pKOTSUHOTEL_DATA.ANS_TAXI_DATE_20.Trim <> "" Then
            If Not TaxiFlg Then
                TaxiFlg = True
                Dim TaxiTitle As New Label
                TaxiTitle.Text = "【タクシーチケット】"
                TaxiTitle.Size = New System.Drawing.SizeF(Me.CmToInch(4), Me.CmToInch(RowHeight))
                TaxiTitle.Location = New System.Drawing.PointF(Me.CmToInch(ItemTitleX), Me.CmToInch(StartY + RowHeight * RowNo))
                TaxiTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
                Me.Detail.Controls.Add(TaxiTitle)

                RowNo += 1
            End If

            Dim Ans_Taxi_Date_20_Title As New Label
            Ans_Taxi_Date_20_Title.Text = "利用日："
            Ans_Taxi_Date_20_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_20_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_20_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Date_20_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_20_Title)

            Dim Ans_Taxi_Date_20 As New TextBox
            Ans_Taxi_Date_20.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_TAXI_DATE_20, CmnModule.DateFormatType.MD)
            Ans_Taxi_Date_20.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth1), Me.CmToInch(RowHeight))
            Ans_Taxi_Date_20.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX1), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Date_20.CanGrow = True
            Ans_Taxi_Date_20.CanShrink = True
            Ans_Taxi_Date_20.WordWrap = False
            Ans_Taxi_Date_20.Alignment = TextAlignment.Left
            Ans_Taxi_Date_20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Date_20)

            Dim Ans_Taxi_Kenshu_20 As New TextBox
            Ans_Taxi_Kenshu_20.Text = AppModule.GetName_ANS_TAXI_KENSHU(pKOTSUHOTEL_DATA.ANS_TAXI_KENSHU_20)
            Ans_Taxi_Kenshu_20.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_Kenshu_20.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Kenshu_20.CanGrow = True
            Ans_Taxi_Kenshu_20.CanShrink = True
            Ans_Taxi_Kenshu_20.WordWrap = False
            Ans_Taxi_Kenshu_20.Alignment = TextAlignment.Left
            Ans_Taxi_Kenshu_20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Kenshu_20)

            Dim Ans_Taxi_No_20_Title As New Label
            Ans_Taxi_No_20_Title.Text = "チケット番号："
            Ans_Taxi_No_20_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth2), Me.CmToInch(RowHeight))
            Ans_Taxi_No_20_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX2), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_No_20_Title.Alignment = TextAlignment.Left
            Ans_Taxi_No_20_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_No_20_Title)

            Dim ANS_TAXI_NO_20 As New TextBox
            ANS_TAXI_NO_20.Text = pKOTSUHOTEL_DATA.ANS_TAXI_NO_20
            ANS_TAXI_NO_20.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth3), Me.CmToInch(RowHeight))
            ANS_TAXI_NO_20.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX3), Me.CmToInch(StartY + RowHeight * RowNo))
            ANS_TAXI_NO_20.CanGrow = True
            ANS_TAXI_NO_20.CanShrink = True
            ANS_TAXI_NO_20.WordWrap = False
            ANS_TAXI_NO_20.Alignment = TextAlignment.Left
            ANS_TAXI_NO_20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(ANS_TAXI_NO_20)

            Dim Ans_Taxi_Rmks_20_Title As New Label
            Ans_Taxi_Rmks_20_Title.Text = "備考："
            Ans_Taxi_Rmks_20_Title.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemTitleWidth3), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_20_Title.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemTitleX3), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_20_Title.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_20_Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_20_Title)

            Dim Ans_Taxi_Rmks_20 As New TextBox
            'Ans_Taxi_Rmks_20.Text = pKOTSUHOTEL_DATA.ans_taxi_rmks_20
            Ans_Taxi_Rmks_20.Size = New System.Drawing.SizeF(Me.CmToInch(TaxiItemWidth4), Me.CmToInch(RowHeight))
            Ans_Taxi_Rmks_20.Location = New System.Drawing.PointF(Me.CmToInch(TaxiItemX4), Me.CmToInch(StartY + RowHeight * RowNo))
            Ans_Taxi_Rmks_20.CanGrow = True
            Ans_Taxi_Rmks_20.CanShrink = True
            Ans_Taxi_Rmks_20.WordWrap = False
            Ans_Taxi_Rmks_20.Alignment = TextAlignment.Left
            Ans_Taxi_Rmks_20.Font = New System.Drawing.Font("ＭＳ ゴシック", 9)
            Me.Detail.Controls.Add(Ans_Taxi_Rmks_20)

            RowNo += 1
            Me.Detail.Height = Me.CmToInch(StartY + RowHeight * RowNo)
        End If
    End Sub
End Class
