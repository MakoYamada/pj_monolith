<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class KaijoReport 
    Inherits DataDynamics.ActiveReports.ActiveReport

    'ActiveReport がコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'メモ: 以下のプロシージャは ActiveReport デザイナで必要です。
    'ActiveReport デザイナを使用して変更できます。
    'コード エディタを使って変更しないでください。
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KaijoReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.PrintDate = New DataDynamics.ActiveReports.TextBox
        Me.PageCount = New DataDynamics.ActiveReports.TextBox
        Me.PageTotal = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.Label35 = New DataDynamics.ActiveReports.Label
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.Label38 = New DataDynamics.ActiveReports.Label
        Me.Shape3 = New DataDynamics.ActiveReports.Shape
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.TEHAI_ID = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_TOP = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.SHONIN_NAME = New DataDynamics.ActiveReports.TextBox
        Me.SHONIN_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.KAISAI_DATE_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.KAISAI_KIBOU_ADDRESS1 = New DataDynamics.ActiveReports.TextBox
        Me.KAISAI_KIBOU_ADDRESS2 = New DataDynamics.ActiveReports.TextBox
        Me.KAISAI_KIBOU_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.KOUEN_TIME1 = New DataDynamics.ActiveReports.TextBox
        Me.KOUEN_TIME2 = New DataDynamics.ActiveReports.TextBox
        Me.KOUEN_KAIJO_LAYOUT = New DataDynamics.ActiveReports.TextBox
        Me.IKENKOUKAN_KAIJO_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_KAIJO_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_SANKA_YOTEI_CNT = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_FROM = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_KAIJO_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_ROOM_FROM = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.REQ_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STAY_DATE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_KOTSU_CNT = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_CNT = New DataDynamics.ActiveReports.TextBox
        Me.OTHER_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Shape4 = New DataDynamics.ActiveReports.Shape
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_TOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_DATE_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_ADDRESS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_ADDRESS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_TIME1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_TIME2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_KAIJO_LAYOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_SANKA_YOTEI_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_ROOM_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STAY_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_KOTSU_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.USER_NAME, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.PrintDate, Me.PageCount, Me.PageTotal, Me.Label5, Me.Label6, Me.Label7, Me.Label8})
        Me.PageHeader.Height = 0.995571!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.3149607!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6576772!
        Me.Shape1.Width = 7.141732!
        '
        'USER_NAME
        '
        Me.USER_NAME.CanGrow = False
        Me.USER_NAME.DataField = "USER_NAME"
        Me.USER_NAME.Height = 0.1771653!
        Me.USER_NAME.Left = 5.801969!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Style = "font-family: ＭＳ ゴシック"
        Me.USER_NAME.Text = Nothing
        Me.USER_NAME.Top = 0.1771654!
        Me.USER_NAME.Width = 1.354331!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.030349!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label1.Text = "出力日"
        Me.Label1.Top = 0.0001311451!
        Me.Label1.Width = 0.6251969!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.030349!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label2.Text = "出力担当"
        Me.Label2.Top = 0.1772966!
        Me.Label2.Width = 0.6251969!
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.64531!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label3.Text = "："
        Me.Label3.Top = 0.1772966!
        Me.Label3.Width = 0.1669291!
        '
        'Label4
        '
        Me.Label4.Height = 0.1771654!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.64531!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001311451!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1771654!
        Me.PrintDate.Left = 5.802003!
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Style = "font-family: ＭＳ ゴシック"
        Me.PrintDate.Text = "2013/12/12 00:00:00"
        Me.PrintDate.Top = 0.0001311451!
        Me.PrintDate.Width = 1.354331!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 5.978741!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.4602363!
        Me.PageCount.Width = 0.2755905!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 6.333072!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageTotal
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.4602363!
        Me.PageTotal.Width = 0.2755905!
        '
        'Label5
        '
        Me.Label5.Height = 0.1692913!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.900001!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック"
        Me.Label5.Text = "("
        Me.Label5.Top = 0.4602363!
        Me.Label5.Width = 0.07874016!
        '
        'Label6
        '
        Me.Label6.Height = 0.1692913!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.254332!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック"
        Me.Label6.Text = "/"
        Me.Label6.Top = 0.4602363!
        Me.Label6.Width = 0.07874014!
        '
        'Label7
        '
        Me.Label7.Height = 0.1692913!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.608663!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック"
        Me.Label7.Text = "ページ)"
        Me.Label7.Top = 0.4602363!
        Me.Label7.Width = 0.5476375!
        '
        'Label8
        '
        Me.Label8.Height = 0.2688977!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.627953!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "会場手配依頼"
        Me.Label8.Top = 0.6807087!
        Me.Label8.Width = 1.770473!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label9, Me.KOUENKAI_NAME, Me.Shape2, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label38, Me.Shape3, Me.Line1, Me.TEHAI_ID, Me.KOUENKAI_NO, Me.REQ_STATUS_TEHAI, Me.TIME_STAMP_TOP, Me.SHONIN_NAME, Me.SHONIN_DATE, Me.Label41, Me.KAISAI_DATE_NOTE, Me.KAISAI_KIBOU_ADDRESS1, Me.KAISAI_KIBOU_ADDRESS2, Me.KAISAI_KIBOU_NOTE, Me.KOUEN_TIME1, Me.KOUEN_TIME2, Me.KOUEN_KAIJO_LAYOUT, Me.IKENKOUKAN_KAIJO_TEHAI, Me.IROUKAI_KAIJO_TEHAI, Me.IROUKAI_SANKA_YOTEI_CNT, Me.KOUSHI_ROOM_TEHAI, Me.KOUSHI_ROOM_FROM, Me.KOUSHI_ROOM_CNT, Me.SHAIN_ROOM_TEHAI, Me.MANAGER_KAIJO_TEHAI, Me.MANAGER_ROOM_FROM, Me.MANAGER_ROOM_CNT, Me.REQ_ROOM_CNT, Me.REQ_STAY_DATE, Me.REQ_KOTSU_CNT, Me.REQ_TAXI_CNT, Me.OTHER_NOTE, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line9, Me.Line10, Me.Line11, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Shape4})
        Me.Detail.Height = 10.06205!
        Me.Detail.Name = "Detail"
        '
        'Label9
        '
        Me.Label9.Height = 0.1771654!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.0!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = resources.GetString("Label9.Style")
        Me.Label9.Text = "講演会名："
        Me.Label9.Top = 0.07165354!
        Me.Label9.Width = 0.7496064!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.1771654!
        Me.KOUENKAI_NAME.Left = 0.7496064!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 11.25pt; font-weight: bold; white-space: nowrap"
        Me.KOUENKAI_NAME.Text = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Top = 0.07165354!
        Me.KOUENKAI_NAME.Width = 6.13504!
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape2.Height = 7.665354!
        Me.Shape2.Left = 0.02007946!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 0.2693765!
        Me.Shape2.Width = 2.015354!
        '
        'Label10
        '
        Me.Label10.Height = 0.1771654!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.08149679!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label10.Text = "会合手配Id"
        Me.Label10.Top = 0.3205576!
        Me.Label10.Width = 1.753543!
        '
        'Label11
        '
        Me.Label11.Height = 0.1771655!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.08149679!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label11.Text = "交通手配予定人数 (JR/AIR)"
        Me.Label11.Top = 6.859605!
        Me.Label11.Width = 1.753543!
        '
        'Label12
        '
        Me.Label12.Height = 0.1771654!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.08149679!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label12.Text = "手配ステータス (依頼)"
        Me.Label12.Top = 0.771507!
        Me.Label12.Width = 1.753543!
        '
        'Label13
        '
        Me.Label13.Height = 0.1771654!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.08149679!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label13.Text = "最終承認者 (氏名)"
        Me.Label13.Top = 1.222456!
        Me.Label13.Width = 1.753543!
        '
        'Label14
        '
        Me.Label14.Height = 0.1771654!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.08149679!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label14.Text = "開催希望地 (都道府県)"
        Me.Label14.Top = 2.349829!
        Me.Label14.Width = 1.753543!
        '
        'Label15
        '
        Me.Label15.Height = 0.1771655!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.08149679!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label15.Text = "開催希望地 (フリーテキスト)"
        Me.Label15.Top = 2.800779!
        Me.Label15.Width = 1.953937!
        '
        'Label16
        '
        Me.Label16.Height = 0.1771654!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.08149679!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label16.Text = "講演会番号"
        Me.Label16.Top = 0.5460322!
        Me.Label16.Width = 1.753543!
        '
        'Label17
        '
        Me.Label17.Height = 0.1771654!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.08149679!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label17.Text = "Timestamp (BYL)"
        Me.Label17.Top = 0.9969814!
        Me.Label17.Width = 1.753543!
        '
        'Label18
        '
        Me.Label18.Height = 0.1771654!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.08149679!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label18.Text = "開催日備考欄"
        Me.Label18.Top = 1.673405!
        Me.Label18.Width = 1.753543!
        '
        'Label19
        '
        Me.Label19.Height = 0.1771655!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.08149679!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label19.Text = "開催希望地 (市町村)"
        Me.Label19.Top = 2.575304!
        Me.Label19.Width = 1.753543!
        '
        'Label20
        '
        Me.Label20.Height = 0.1771655!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.08149679!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label20.Text = "講演会場 レイアウト"
        Me.Label20.Top = 3.928153!
        Me.Label20.Width = 1.753543!
        '
        'Label21
        '
        Me.Label21.Height = 0.1771655!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.08149679!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label21.Text = "講演会 終了時間"
        Me.Label21.Top = 3.702678!
        Me.Label21.Width = 1.753543!
        '
        'Label22
        '
        Me.Label22.Height = 0.1771655!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.08149679!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label22.Text = "講演会 開始時間"
        Me.Label22.Top = 3.477204!
        Me.Label22.Width = 1.753543!
        '
        'Label23
        '
        Me.Label23.Height = 0.1771655!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.08149679!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label23.Text = "慰労会会場 (要・不要)"
        Me.Label23.Top = 4.379382!
        Me.Label23.Width = 1.753543!
        '
        'Label24
        '
        Me.Label24.Height = 0.1771655!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.08149679!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label24.Text = "意見交換会場 (要・不要)"
        Me.Label24.Top = 4.153907!
        Me.Label24.Width = 1.753543!
        '
        'Label26
        '
        Me.Label26.Height = 0.1771655!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.08149679!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label26.Text = "講師控室 (時間 From)"
        Me.Label26.Top = 5.055807!
        Me.Label26.Width = 1.753543!
        '
        'Label27
        '
        Me.Label27.Height = 0.1771655!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.08149679!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label27.Text = "講師控室 (要・不要)"
        Me.Label27.Top = 4.830331!
        Me.Label27.Width = 1.753543!
        '
        'Label28
        '
        Me.Label28.Height = 0.1771655!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 0.08149679!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label28.Text = "慰労会参加予定者数"
        Me.Label28.Top = 4.604857!
        Me.Label28.Width = 1.753543!
        '
        'Label29
        '
        Me.Label29.Height = 0.1771655!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.08149679!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label29.Text = "講師控室 (人数)"
        Me.Label29.Top = 5.281281!
        Me.Label29.Width = 1.753543!
        '
        'Label30
        '
        Me.Label30.Height = 0.1771655!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.08149679!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label30.Text = "世話人控室 (時間 From)"
        Me.Label30.Top = 5.957706!
        Me.Label30.Width = 1.753543!
        '
        'Label31
        '
        Me.Label31.Height = 0.1771655!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.08149679!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label31.Text = "世話人会会場 (要・不要)"
        Me.Label31.Top = 5.732231!
        Me.Label31.Width = 1.753543!
        '
        'Label32
        '
        Me.Label32.Height = 0.1771655!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.08149679!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label32.Text = "社員控室 (要・不要)"
        Me.Label32.Top = 5.506756!
        Me.Label32.Width = 1.753543!
        '
        'Label33
        '
        Me.Label33.Height = 0.1771655!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.08149679!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label33.Text = "宿泊希望日"
        Me.Label33.Top = 6.63413!
        Me.Label33.Width = 1.753543!
        '
        'Label34
        '
        Me.Label34.Height = 0.1771655!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.08149679!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label34.Text = "宿泊希望室数"
        Me.Label34.Top = 6.408656!
        Me.Label34.Width = 1.753543!
        '
        'Label35
        '
        Me.Label35.Height = 0.1771655!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 0.08149679!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label35.Text = "世話人控室 (人数)"
        Me.Label35.Top = 6.18318!
        Me.Label35.Width = 1.753543!
        '
        'Label36
        '
        Me.Label36.Height = 0.1771655!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 0.08149679!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label36.Text = "その他備考欄"
        Me.Label36.Top = 7.310555!
        Me.Label36.Width = 1.753543!
        '
        'Label38
        '
        Me.Label38.Height = 0.1771655!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 0.08149679!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label38.Text = "タクシー手配予定人数"
        Me.Label38.Top = 7.08508!
        Me.Label38.Width = 1.753543!
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.Color.White
        Me.Shape3.Height = 7.665354!
        Me.Shape3.Left = 2.035433!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 0.2692914!
        Me.Shape3.Width = 5.110237!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.02007946!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.4882741!
        Me.Line1.Width = 7.125985!
        Me.Line1.X1 = 0.02007946!
        Me.Line1.X2 = 7.146065!
        Me.Line1.Y1 = 0.4882741!
        Me.Line1.Y2 = 0.4882741!
        '
        'TEHAI_ID
        '
        Me.TEHAI_ID.CanGrow = False
        Me.TEHAI_ID.DataField = "TEHAI_ID"
        Me.TEHAI_ID.Height = 0.1771654!
        Me.TEHAI_ID.Left = 2.086614!
        Me.TEHAI_ID.Name = "TEHAI_ID"
        Me.TEHAI_ID.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.TEHAI_ID.Text = "TEHAI_ID"
        Me.TEHAI_ID.Top = 0.3205576!
        Me.TEHAI_ID.Width = 4.989764!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.1771653!
        Me.KOUENKAI_NO.Left = 2.086615!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUENKAI_NO.Text = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Top = 0.5413253!
        Me.KOUENKAI_NO.Width = 4.989764!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.CanGrow = False
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.1771653!
        Me.REQ_STATUS_TEHAI.Left = 2.086615!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.REQ_STATUS_TEHAI.Text = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Top = 0.7620933!
        Me.REQ_STATUS_TEHAI.Width = 4.989764!
        '
        'TIME_STAMP_TOP
        '
        Me.TIME_STAMP_TOP.CanGrow = False
        Me.TIME_STAMP_TOP.DataField = "TIME_STAMP_TOP"
        Me.TIME_STAMP_TOP.Height = 0.1771653!
        Me.TIME_STAMP_TOP.Left = 2.086615!
        Me.TIME_STAMP_TOP.Name = "TIME_STAMP_TOP"
        Me.TIME_STAMP_TOP.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.TIME_STAMP_TOP.Text = "TIME_STAMP_TOP"
        Me.TIME_STAMP_TOP.Top = 0.9828608!
        Me.TIME_STAMP_TOP.Width = 4.989764!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'SHONIN_NAME
        '
        Me.SHONIN_NAME.CanGrow = False
        Me.SHONIN_NAME.DataField = "SHONIN_NAME"
        Me.SHONIN_NAME.Height = 0.1771653!
        Me.SHONIN_NAME.Left = 2.086615!
        Me.SHONIN_NAME.Name = "SHONIN_NAME"
        Me.SHONIN_NAME.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SHONIN_NAME.Text = "SHONIN_NAME"
        Me.SHONIN_NAME.Top = 1.203629!
        Me.SHONIN_NAME.Width = 4.989764!
        '
        'SHONIN_DATE
        '
        Me.SHONIN_DATE.CanGrow = False
        Me.SHONIN_DATE.DataField = "SHONIN_DATE"
        Me.SHONIN_DATE.Height = 0.1771653!
        Me.SHONIN_DATE.Left = 2.086615!
        Me.SHONIN_DATE.Name = "SHONIN_DATE"
        Me.SHONIN_DATE.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SHONIN_DATE.Text = "SHONIN_DATE"
        Me.SHONIN_DATE.Top = 1.424396!
        Me.SHONIN_DATE.Width = 4.989764!
        '
        'Label41
        '
        Me.Label41.Height = 0.1771654!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0.08149679!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9.75pt"
        Me.Label41.Text = "最終承認日"
        Me.Label41.Top = 1.447931!
        Me.Label41.Width = 1.753543!
        '
        'KAISAI_DATE_NOTE
        '
        Me.KAISAI_DATE_NOTE.CanGrow = False
        Me.KAISAI_DATE_NOTE.DataField = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Height = 0.5866142!
        Me.KAISAI_DATE_NOTE.Left = 2.086615!
        Me.KAISAI_DATE_NOTE.Name = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Style = "font-family: ＭＳ ゴシック"
        Me.KAISAI_DATE_NOTE.Text = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Top = 1.673314!
        Me.KAISAI_DATE_NOTE.Width = 4.989764!
        '
        'KAISAI_KIBOU_ADDRESS1
        '
        Me.KAISAI_KIBOU_ADDRESS1.CanGrow = False
        Me.KAISAI_KIBOU_ADDRESS1.DataField = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Height = 0.1771653!
        Me.KAISAI_KIBOU_ADDRESS1.Left = 2.086615!
        Me.KAISAI_KIBOU_ADDRESS1.Name = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KAISAI_KIBOU_ADDRESS1.Text = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Top = 2.349692!
        Me.KAISAI_KIBOU_ADDRESS1.Width = 4.989764!
        '
        'KAISAI_KIBOU_ADDRESS2
        '
        Me.KAISAI_KIBOU_ADDRESS2.CanGrow = False
        Me.KAISAI_KIBOU_ADDRESS2.DataField = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Height = 0.1771653!
        Me.KAISAI_KIBOU_ADDRESS2.Left = 2.086615!
        Me.KAISAI_KIBOU_ADDRESS2.Name = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KAISAI_KIBOU_ADDRESS2.Text = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Top = 2.575282!
        Me.KAISAI_KIBOU_ADDRESS2.Width = 4.989764!
        '
        'KAISAI_KIBOU_NOTE
        '
        Me.KAISAI_KIBOU_NOTE.CanGrow = False
        Me.KAISAI_KIBOU_NOTE.DataField = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Height = 0.5866142!
        Me.KAISAI_KIBOU_NOTE.Left = 2.086615!
        Me.KAISAI_KIBOU_NOTE.Name = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Style = "font-family: ＭＳ ゴシック"
        Me.KAISAI_KIBOU_NOTE.Text = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Top = 2.800873!
        Me.KAISAI_KIBOU_NOTE.Width = 4.989764!
        '
        'KOUEN_TIME1
        '
        Me.KOUEN_TIME1.CanGrow = False
        Me.KOUEN_TIME1.DataField = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Height = 0.1771653!
        Me.KOUEN_TIME1.Left = 2.086615!
        Me.KOUEN_TIME1.Name = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUEN_TIME1.Text = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Top = 3.477251!
        Me.KOUEN_TIME1.Width = 4.989764!
        '
        'KOUEN_TIME2
        '
        Me.KOUEN_TIME2.CanGrow = False
        Me.KOUEN_TIME2.DataField = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Height = 0.1771653!
        Me.KOUEN_TIME2.Left = 2.086615!
        Me.KOUEN_TIME2.Name = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUEN_TIME2.Text = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Top = 3.702842!
        Me.KOUEN_TIME2.Width = 4.989764!
        '
        'KOUEN_KAIJO_LAYOUT
        '
        Me.KOUEN_KAIJO_LAYOUT.CanGrow = False
        Me.KOUEN_KAIJO_LAYOUT.DataField = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Height = 0.1771653!
        Me.KOUEN_KAIJO_LAYOUT.Left = 2.086615!
        Me.KOUEN_KAIJO_LAYOUT.Name = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUEN_KAIJO_LAYOUT.Text = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Top = 3.928038!
        Me.KOUEN_KAIJO_LAYOUT.Width = 4.989764!
        '
        'IKENKOUKAN_KAIJO_TEHAI
        '
        Me.IKENKOUKAN_KAIJO_TEHAI.CanGrow = False
        Me.IKENKOUKAN_KAIJO_TEHAI.DataField = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI.Height = 0.1771653!
        Me.IKENKOUKAN_KAIJO_TEHAI.Left = 2.086615!
        Me.IKENKOUKAN_KAIJO_TEHAI.Name = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.IKENKOUKAN_KAIJO_TEHAI.Text = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI.Top = 4.15363!
        Me.IKENKOUKAN_KAIJO_TEHAI.Width = 4.989764!
        '
        'IROUKAI_KAIJO_TEHAI
        '
        Me.IROUKAI_KAIJO_TEHAI.CanGrow = False
        Me.IROUKAI_KAIJO_TEHAI.DataField = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI.Height = 0.1771653!
        Me.IROUKAI_KAIJO_TEHAI.Left = 2.086615!
        Me.IROUKAI_KAIJO_TEHAI.Name = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.IROUKAI_KAIJO_TEHAI.Text = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI.Top = 4.37922!
        Me.IROUKAI_KAIJO_TEHAI.Width = 4.989764!
        '
        'IROUKAI_SANKA_YOTEI_CNT
        '
        Me.IROUKAI_SANKA_YOTEI_CNT.CanGrow = False
        Me.IROUKAI_SANKA_YOTEI_CNT.DataField = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Height = 0.1771653!
        Me.IROUKAI_SANKA_YOTEI_CNT.Left = 2.086615!
        Me.IROUKAI_SANKA_YOTEI_CNT.Name = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Top = 4.604417!
        Me.IROUKAI_SANKA_YOTEI_CNT.Width = 4.989764!
        '
        'KOUSHI_ROOM_TEHAI
        '
        Me.KOUSHI_ROOM_TEHAI.CanGrow = False
        Me.KOUSHI_ROOM_TEHAI.DataField = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI.Height = 0.1771653!
        Me.KOUSHI_ROOM_TEHAI.Left = 2.086615!
        Me.KOUSHI_ROOM_TEHAI.Name = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUSHI_ROOM_TEHAI.Text = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI.Top = 4.830007!
        Me.KOUSHI_ROOM_TEHAI.Width = 4.989764!
        '
        'KOUSHI_ROOM_FROM
        '
        Me.KOUSHI_ROOM_FROM.CanGrow = False
        Me.KOUSHI_ROOM_FROM.DataField = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Height = 0.1771653!
        Me.KOUSHI_ROOM_FROM.Left = 2.086615!
        Me.KOUSHI_ROOM_FROM.Name = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUSHI_ROOM_FROM.Text = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Top = 5.055598!
        Me.KOUSHI_ROOM_FROM.Width = 4.989764!
        '
        'KOUSHI_ROOM_CNT
        '
        Me.KOUSHI_ROOM_CNT.CanGrow = False
        Me.KOUSHI_ROOM_CNT.DataField = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Height = 0.1771653!
        Me.KOUSHI_ROOM_CNT.Left = 2.086615!
        Me.KOUSHI_ROOM_CNT.Name = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUSHI_ROOM_CNT.Text = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Top = 5.281188!
        Me.KOUSHI_ROOM_CNT.Width = 4.989764!
        '
        'SHAIN_ROOM_TEHAI
        '
        Me.SHAIN_ROOM_TEHAI.CanGrow = False
        Me.SHAIN_ROOM_TEHAI.DataField = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI.Height = 0.1771653!
        Me.SHAIN_ROOM_TEHAI.Left = 2.086615!
        Me.SHAIN_ROOM_TEHAI.Name = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SHAIN_ROOM_TEHAI.Text = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI.Top = 5.506385!
        Me.SHAIN_ROOM_TEHAI.Width = 4.989764!
        '
        'MANAGER_KAIJO_TEHAI
        '
        Me.MANAGER_KAIJO_TEHAI.CanGrow = False
        Me.MANAGER_KAIJO_TEHAI.DataField = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI.Height = 0.1771653!
        Me.MANAGER_KAIJO_TEHAI.Left = 2.086615!
        Me.MANAGER_KAIJO_TEHAI.Name = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.MANAGER_KAIJO_TEHAI.Text = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI.Top = 5.731976!
        Me.MANAGER_KAIJO_TEHAI.Width = 4.989764!
        '
        'MANAGER_ROOM_FROM
        '
        Me.MANAGER_ROOM_FROM.CanGrow = False
        Me.MANAGER_ROOM_FROM.DataField = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Height = 0.1771653!
        Me.MANAGER_ROOM_FROM.Left = 2.086615!
        Me.MANAGER_ROOM_FROM.Name = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.MANAGER_ROOM_FROM.Text = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Top = 5.957567!
        Me.MANAGER_ROOM_FROM.Width = 4.989764!
        '
        'MANAGER_ROOM_CNT
        '
        Me.MANAGER_ROOM_CNT.CanGrow = False
        Me.MANAGER_ROOM_CNT.DataField = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Height = 0.1771653!
        Me.MANAGER_ROOM_CNT.Left = 2.086615!
        Me.MANAGER_ROOM_CNT.Name = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.MANAGER_ROOM_CNT.Text = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Top = 6.182764!
        Me.MANAGER_ROOM_CNT.Width = 4.989764!
        '
        'REQ_ROOM_CNT
        '
        Me.REQ_ROOM_CNT.CanGrow = False
        Me.REQ_ROOM_CNT.DataField = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Height = 0.1771653!
        Me.REQ_ROOM_CNT.Left = 2.086615!
        Me.REQ_ROOM_CNT.Name = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.REQ_ROOM_CNT.Text = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Top = 6.408354!
        Me.REQ_ROOM_CNT.Width = 4.989764!
        '
        'REQ_STAY_DATE
        '
        Me.REQ_STAY_DATE.CanGrow = False
        Me.REQ_STAY_DATE.DataField = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Height = 0.1771653!
        Me.REQ_STAY_DATE.Left = 2.086615!
        Me.REQ_STAY_DATE.Name = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.REQ_STAY_DATE.Text = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Top = 6.633945!
        Me.REQ_STAY_DATE.Width = 4.989764!
        '
        'REQ_KOTSU_CNT
        '
        Me.REQ_KOTSU_CNT.CanGrow = False
        Me.REQ_KOTSU_CNT.DataField = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Height = 0.1771653!
        Me.REQ_KOTSU_CNT.Left = 2.086615!
        Me.REQ_KOTSU_CNT.Name = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.REQ_KOTSU_CNT.Text = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Top = 6.859142!
        Me.REQ_KOTSU_CNT.Width = 4.989764!
        '
        'REQ_TAXI_CNT
        '
        Me.REQ_TAXI_CNT.CanGrow = False
        Me.REQ_TAXI_CNT.DataField = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Height = 0.1771653!
        Me.REQ_TAXI_CNT.Left = 2.086615!
        Me.REQ_TAXI_CNT.Name = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.REQ_TAXI_CNT.Text = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Top = 7.084732!
        Me.REQ_TAXI_CNT.Width = 4.989764!
        '
        'OTHER_NOTE
        '
        Me.OTHER_NOTE.CanGrow = False
        Me.OTHER_NOTE.DataField = "OTHER_NOTE"
        Me.OTHER_NOTE.Height = 0.5866142!
        Me.OTHER_NOTE.Left = 2.086615!
        Me.OTHER_NOTE.Name = "OTHER_NOTE"
        Me.OTHER_NOTE.Style = "font-family: ＭＳ ゴシック"
        Me.OTHER_NOTE.Text = "OTHER_NOTE"
        Me.OTHER_NOTE.Top = 7.310322!
        Me.OTHER_NOTE.Width = 4.989764!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.02007946!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.7140615!
        Me.Line2.Width = 7.125986!
        Me.Line2.X1 = 0.02007946!
        Me.Line2.X2 = 7.146066!
        Me.Line2.Y1 = 0.7140615!
        Me.Line2.Y2 = 0.7140615!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.02007946!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.9398489!
        Me.Line3.Width = 7.125986!
        Me.Line3.X1 = 0.02007946!
        Me.Line3.X2 = 7.146066!
        Me.Line3.Y1 = 0.9398489!
        Me.Line3.Y2 = 0.9398489!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.02007946!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.165636!
        Me.Line4.Width = 7.125986!
        Me.Line4.X1 = 0.02007946!
        Me.Line4.X2 = 7.146066!
        Me.Line4.Y1 = 1.165636!
        Me.Line4.Y2 = 1.165636!
        '
        'Line5
        '
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.02007946!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.391424!
        Me.Line5.Width = 7.125986!
        Me.Line5.X1 = 0.02007946!
        Me.Line5.X2 = 7.146066!
        Me.Line5.Y1 = 1.391424!
        Me.Line5.Y2 = 1.391424!
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.02007946!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.617211!
        Me.Line6.Width = 7.125986!
        Me.Line6.X1 = 0.02007946!
        Me.Line6.X2 = 7.146066!
        Me.Line6.Y1 = 1.617211!
        Me.Line6.Y2 = 1.617211!
        '
        'Line9
        '
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.02007946!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 2.294574!
        Me.Line9.Width = 7.125986!
        Me.Line9.X1 = 0.02007946!
        Me.Line9.X2 = 7.146066!
        Me.Line9.Y1 = 2.294574!
        Me.Line9.Y2 = 2.294574!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.02007946!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 2.520361!
        Me.Line10.Width = 7.125986!
        Me.Line10.X1 = 0.02007946!
        Me.Line10.X2 = 7.146066!
        Me.Line10.Y1 = 2.520361!
        Me.Line10.Y2 = 2.520361!
        '
        'Line11
        '
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 0.02007946!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 2.746148!
        Me.Line11.Width = 7.125986!
        Me.Line11.X1 = 0.02007946!
        Me.Line11.X2 = 7.146066!
        Me.Line11.Y1 = 2.746148!
        Me.Line11.Y2 = 2.746148!
        '
        'Line14
        '
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 0.02007946!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 3.42351!
        Me.Line14.Width = 7.125986!
        Me.Line14.X1 = 0.02007946!
        Me.Line14.X2 = 7.146066!
        Me.Line14.Y1 = 3.42351!
        Me.Line14.Y2 = 3.42351!
        '
        'Line15
        '
        Me.Line15.Height = 0.0!
        Me.Line15.Left = 0.02007946!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 3.649297!
        Me.Line15.Width = 7.125986!
        Me.Line15.X1 = 0.02007946!
        Me.Line15.X2 = 7.146066!
        Me.Line15.Y1 = 3.649297!
        Me.Line15.Y2 = 3.649297!
        '
        'Line16
        '
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 0.02007946!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 3.875085!
        Me.Line16.Width = 7.125986!
        Me.Line16.X1 = 0.02007946!
        Me.Line16.X2 = 7.146066!
        Me.Line16.Y1 = 3.875085!
        Me.Line16.Y2 = 3.875085!
        '
        'Line17
        '
        Me.Line17.Height = 0.0!
        Me.Line17.Left = 0.02007946!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 4.100873!
        Me.Line17.Width = 7.125986!
        Me.Line17.X1 = 0.02007946!
        Me.Line17.X2 = 7.146066!
        Me.Line17.Y1 = 4.100873!
        Me.Line17.Y2 = 4.100873!
        '
        'Line18
        '
        Me.Line18.Height = 0.0!
        Me.Line18.Left = 0.02007946!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 4.326661!
        Me.Line18.Width = 7.125986!
        Me.Line18.X1 = 0.02007946!
        Me.Line18.X2 = 7.146066!
        Me.Line18.Y1 = 4.326661!
        Me.Line18.Y2 = 4.326661!
        '
        'Line19
        '
        Me.Line19.Height = 0.0!
        Me.Line19.Left = 0.02007946!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 4.552449!
        Me.Line19.Width = 7.125986!
        Me.Line19.X1 = 0.02007946!
        Me.Line19.X2 = 7.146066!
        Me.Line19.Y1 = 4.552449!
        Me.Line19.Y2 = 4.552449!
        '
        'Line20
        '
        Me.Line20.Height = 0.0!
        Me.Line20.Left = 0.02007946!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 4.778236!
        Me.Line20.Width = 7.125986!
        Me.Line20.X1 = 0.02007946!
        Me.Line20.X2 = 7.146066!
        Me.Line20.Y1 = 4.778236!
        Me.Line20.Y2 = 4.778236!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.02007946!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 5.004024!
        Me.Line21.Width = 7.125986!
        Me.Line21.X1 = 0.02007946!
        Me.Line21.X2 = 7.146066!
        Me.Line21.Y1 = 5.004024!
        Me.Line21.Y2 = 5.004024!
        '
        'Line22
        '
        Me.Line22.Height = 0.0!
        Me.Line22.Left = 0.02007946!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 5.229811!
        Me.Line22.Width = 7.125986!
        Me.Line22.X1 = 0.02007946!
        Me.Line22.X2 = 7.146066!
        Me.Line22.Y1 = 5.229811!
        Me.Line22.Y2 = 5.229811!
        '
        'Line23
        '
        Me.Line23.Height = 0.0!
        Me.Line23.Left = 0.02007946!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 5.455599!
        Me.Line23.Width = 7.125986!
        Me.Line23.X1 = 0.02007946!
        Me.Line23.X2 = 7.146066!
        Me.Line23.Y1 = 5.455599!
        Me.Line23.Y2 = 5.455599!
        '
        'Line24
        '
        Me.Line24.Height = 0.0!
        Me.Line24.Left = 0.02007946!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 5.681386!
        Me.Line24.Width = 7.125986!
        Me.Line24.X1 = 0.02007946!
        Me.Line24.X2 = 7.146066!
        Me.Line24.Y1 = 5.681386!
        Me.Line24.Y2 = 5.681386!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.02007946!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 5.907175!
        Me.Line25.Width = 7.125986!
        Me.Line25.X1 = 0.02007946!
        Me.Line25.X2 = 7.146066!
        Me.Line25.Y1 = 5.907175!
        Me.Line25.Y2 = 5.907175!
        '
        'Line26
        '
        Me.Line26.Height = 0.0!
        Me.Line26.Left = 0.02007946!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 6.132962!
        Me.Line26.Width = 7.125986!
        Me.Line26.X1 = 0.02007946!
        Me.Line26.X2 = 7.146066!
        Me.Line26.Y1 = 6.132962!
        Me.Line26.Y2 = 6.132962!
        '
        'Line27
        '
        Me.Line27.Height = 0.0!
        Me.Line27.Left = 0.02007946!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 6.35875!
        Me.Line27.Width = 7.125986!
        Me.Line27.X1 = 0.02007946!
        Me.Line27.X2 = 7.146066!
        Me.Line27.Y1 = 6.35875!
        Me.Line27.Y2 = 6.35875!
        '
        'Line28
        '
        Me.Line28.Height = 0.0!
        Me.Line28.Left = 0.02007946!
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 6.584537!
        Me.Line28.Width = 7.125986!
        Me.Line28.X1 = 0.02007946!
        Me.Line28.X2 = 7.146066!
        Me.Line28.Y1 = 6.584537!
        Me.Line28.Y2 = 6.584537!
        '
        'Line29
        '
        Me.Line29.Height = 0.0!
        Me.Line29.Left = 0.02007946!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 6.810325!
        Me.Line29.Width = 7.125986!
        Me.Line29.X1 = 0.02007946!
        Me.Line29.X2 = 7.146066!
        Me.Line29.Y1 = 6.810325!
        Me.Line29.Y2 = 6.810325!
        '
        'Line30
        '
        Me.Line30.Height = 0.0!
        Me.Line30.Left = 0.02007946!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 7.036112!
        Me.Line30.Width = 7.125986!
        Me.Line30.X1 = 0.02007946!
        Me.Line30.X2 = 7.146066!
        Me.Line30.Y1 = 7.036112!
        Me.Line30.Y2 = 7.036112!
        '
        'Line31
        '
        Me.Line31.Height = 0.0!
        Me.Line31.Left = 0.02007946!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 7.261898!
        Me.Line31.Width = 7.125986!
        Me.Line31.X1 = 0.02007946!
        Me.Line31.X2 = 7.146066!
        Me.Line31.Y1 = 7.261898!
        Me.Line31.Y2 = 7.261898!
        '
        'Shape4
        '
        Me.Shape4.Height = 1.9063!
        Me.Shape4.Left = 0.02007874!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = 10.0!
        Me.Shape4.Top = 8.123229!
        Me.Shape4.Width = 7.121655!
        '
        'KaijoReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.165355!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_TOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_DATE_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_ADDRESS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_ADDRESS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_TIME1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_TIME2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_KAIJO_LAYOUT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_SANKA_YOTEI_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_ROOM_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STAY_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_KOTSU_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents PrintDate As DataDynamics.ActiveReports.TextBox
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageCount As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageTotal As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents Label35 As DataDynamics.ActiveReports.Label
    Private WithEvents Label36 As DataDynamics.ActiveReports.Label
    Private WithEvents Label38 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape3 As DataDynamics.ActiveReports.Shape
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents TEHAI_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_TOP As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_DATE_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KAISAI_KIBOU_ADDRESS1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KAISAI_KIBOU_ADDRESS2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KAISAI_KIBOU_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUEN_TIME1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUEN_TIME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUEN_KAIJO_LAYOUT As DataDynamics.ActiveReports.TextBox
    Private WithEvents IKENKOUKAN_KAIJO_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_KAIJO_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_SANKA_YOTEI_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_FROM As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_KAIJO_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_ROOM_FROM As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STAY_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_KOTSU_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents OTHER_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape4 As DataDynamics.ActiveReports.Shape
End Class
