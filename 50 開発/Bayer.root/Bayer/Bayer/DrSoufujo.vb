Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class DrSoufujo
    Private Const RowHeight As Single = 0.508
    Private Const StartY As Single = 1.204
    Private RowNo As Integer = 1
    Private ItemTitleX As Single = 0
    Private HotelItemTitleX1 As Single = 1.349
    Private HotelItemTitleX2 As Single = 8.572
    Private HotelItemX1 As Single = 3.57
    Private HotelItemX2 As Single = 10.555
    Private KotsuItemTitleX1 As Single = 1.349
    Private KotsuItemTitleX2 As Single = 3.57
    Private KotsuItemTitleX3 As Single = 10.555
    Private KotsuItemX2 As Single = 4.786
    Private KotsuItemX3 As Single = 3.911
    Private TaxiItemTitleX1 As Single = 1.349
    Private TaxiItemTitleX2 As Single = 8.572
    Private TaxiItemTitleX3 As Single = 13.058
    Private TaxiItemX1 As Single = 3.57
    Private TaxiItemX2 As Single = 5.387
    Private TaxiItemX3 As Single = 10.555
    Private TaxiItemX4 As Single = 14.122

    Private pKOTSUHOTEL_DATA As TableDef.TBL_KOTSUHOTEL.DataStruct
    Public WriteOnly Property KOTSUHOTEL_DATA() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Set(ByVal value As TableDef.TBL_KOTSUHOTEL.DataStruct)
            pKOTSUHOTEL_DATA = value
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
    End Sub

    Private Sub ReportHeader1_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
        PRINT_DATE.Text = Format(Now, "yyyy年MM月dd日")
        If Me.DR_NAME.Text.Trim <> "" Then
            Me.DR_NAME.Text = Me.DR_NAME.Text & "　先生"
        End If
        If Me.MR_SEND_SAKI_FS.Text.Trim <> "" Then
            Me.MR_SEND_SAKI.Text = Me.MR_SEND_SAKI_FS.Text
        Else
            Me.MR_SEND_SAKI.Text = Me.MR_SEND_SAKI_OTHER.Text
        End If
        If Me.MR_NAME.Text.Trim <> "" Then
            Me.MR_NAME.Text = Me.MR_NAME.Text & "様"
        End If
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
            HotelTitle.Location = New System.Drawing.PointF(Me.CmToInch(0), Me.CmToInch(StartY))
            Me.Detail.Controls.Add(HotelTitle)

            Dim HotelDateTitle As New Label
            HotelDateTitle.Text = "利用日："
            HotelDateTitle.Height = RowHeight
            HotelDateTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX1), Me.CmToInch(StartY))
            HotelDateTitle.Alignment = TextAlignment.Left
            Me.Detail.Controls.Add(HotelDateTitle)

            Dim HotelDate As New TextBox
            HotelDate.Text = CmnModule.Format_DateJP(pKOTSUHOTEL_DATA.ANS_HOTEL_DATE, CmnModule.DateFormatType.YYYYMD)
            HotelDate.Height = RowHeight
            HotelDate.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX1), Me.CmToInch(StartY))
            HotelDate.CanGrow = True
            HotelDate.CanShrink = True
            HotelDate.WordWrap = False
            HotelDate.Alignment = TextAlignment.Left
            Me.Detail.Controls.Add(HotelDate)

            Dim HotelNameTitle As New Label
            HotelNameTitle.Text = "宿泊施設名："
            HotelNameTitle.Height = RowHeight
            HotelNameTitle.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemTitleX2), Me.CmToInch(StartY))
            Me.Detail.Controls.Add(HotelNameTitle)

            Dim HotelName As New TextBox
            If pKOTSUHOTEL_DATA.ANS_HOTEL_NAME.Trim.Length > 25 Then
                HotelName.Text = Left(pKOTSUHOTEL_DATA.ANS_HOTEL_NAME.Trim, 25)
            Else
                HotelName.Text = pKOTSUHOTEL_DATA.ANS_HOTEL_NAME
            End If
            HotelName.Height = RowHeight
            HotelName.Location = New System.Drawing.PointF(Me.CmToInch(HotelItemX2), Me.CmToInch(StartY))
            HotelName.CanGrow = True
            HotelName.CanShrink = True
            HotelName.WordWrap = False
            Me.Detail.Controls.Add(HotelName)

            RowNo += 1

        End If
    End Sub
End Class
