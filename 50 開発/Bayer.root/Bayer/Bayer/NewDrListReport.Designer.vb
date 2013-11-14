<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NewDrListReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewDrListReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_BU = New DataDynamics.ActiveReports.TextBox
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_AREA = New DataDynamics.ActiveReports.TextBox
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.PRINT_USER = New DataDynamics.ActiveReports.TextBox
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_KUBUN = New DataDynamics.ActiveReports.TextBox
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_KIKAKU_TANTO_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_TEHAI_TANTO_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP = New DataDynamics.ActiveReports.TextBox
        Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.REQ_KOTSU = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_HOTEL = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_TAXI = New DataDynamics.ActiveReports.TextBox
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Line27 = New DataDynamics.ActiveReports.Line
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_USER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_KUBUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_KIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_TEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_KOTSU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_HOTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Label2, Me.PRINT_DATE, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Line1, Me.Line2, Me.Label9, Me.Label10, Me.Label11, Me.JOKEN_BU, Me.Label12, Me.JOKEN_AREA, Me.ReportInfo1, Me.Shape1, Me.Label1, Me.Line3, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Label13, Me.PRINT_USER, Me.Label14, Me.JOKEN_KUBUN, Me.Label15, Me.JOKEN_KOUENKAI_NO, Me.Label16, Me.JOKEN_KOUENKAI_NAME, Me.Label17, Me.JOKEN_KIKAKU_TANTO_ROMA, Me.Label18, Me.JOKEN_TEHAI_TANTO_ROMA, Me.Label19, Me.Label20, Me.Label21, Me.Line13, Me.Line15, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27})
        Me.PageHeader.Height = 2.766536!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.Silver
        Me.Shape2.Height = 0.2818897!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 2.484252!
        Me.Shape2.Width = 12.16535!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 10.03701!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "text-align: right"
        Me.Label2.Text = "出力日："
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.5834652!
        '
        'PRINT_DATE
        '
        Me.PRINT_DATE.Height = 0.2!
        Me.PRINT_DATE.Left = 10.62047!
        Me.PRINT_DATE.Name = "PRINT_DATE"
        Me.PRINT_DATE.Style = "white-space: nowrap"
        Me.PRINT_DATE.Text = "1234/56/78 12:34:56"
        Me.PRINT_DATE.Top = 0.0!
        Me.PRINT_DATE.Width = 1.364567!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 8.323623!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック"
        Me.Label3.Text = "TOP担当者"
        Me.Label3.Top = 2.525197!
        Me.Label3.Width = 0.9271646!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 9.875985!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; text-align: center"
        Me.Label4.Text = "区分"
        Me.Label4.Top = 2.525197!
        Me.Label4.Width = 0.3539367!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 10.32283!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; text-align: center"
        Me.Label5.Text = "宿泊"
        Me.Label5.Top = 2.525197!
        Me.Label5.Width = 0.353937!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.007874016!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック"
        Me.Label6.Text = "実施日"
        Me.Label6.Top = 2.525197!
        Me.Label6.Width = 0.5102362!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.696457!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック"
        Me.Label7.Text = "講演会名"
        Me.Label7.Top = 2.525197!
        Me.Label7.Width = 1.051969!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 6.614567!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック"
        Me.Label8.Text = "TimeStamp(BYL)"
        Me.Label8.Top = 2.525197!
        Me.Label8.Width = 1.051969!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 2.484252!
        Me.Line1.Width = 12.16535!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 12.16535!
        Me.Line1.Y1 = 2.484252!
        Me.Line1.Y2 = 2.484252!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.766142!
        Me.Line2.Width = 12.16535!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 12.16535!
        Me.Line2.Y1 = 2.766142!
        Me.Line2.Y2 = 2.766142!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 10.03701!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-align: right"
        Me.Label9.Text = "ページ："
        Me.Label9.Top = 0.4208662!
        Me.Label9.Width = 0.5834652!
        '
        'Label10
        '
        Me.Label10.Height = 0.2!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-weight: bold"
        Me.Label10.Text = "【抽出条件】"
        Me.Label10.Top = 1.002362!
        Me.Label10.Width = 0.968504!
        '
        'Label11
        '
        Me.Label11.Height = 0.2!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.0!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label11.Text = "BYL手配担当者BU："
        Me.Label11.Top = 1.222835!
        Me.Label11.Width = 1.802756!
        '
        'JOKEN_BU
        '
        Me.JOKEN_BU.CanGrow = False
        Me.JOKEN_BU.Height = 0.2!
        Me.JOKEN_BU.Left = 1.802756!
        Me.JOKEN_BU.Name = "JOKEN_BU"
        Me.JOKEN_BU.Style = "white-space: nowrap"
        Me.JOKEN_BU.Text = Nothing
        Me.JOKEN_BU.Top = 1.222835!
        Me.JOKEN_BU.Width = 1.479134!
        '
        'Label12
        '
        Me.Label12.Height = 0.2!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label12.Text = "BYL手配担当者エリア："
        Me.Label12.Top = 1.433071!
        Me.Label12.Width = 1.802756!
        '
        'JOKEN_AREA
        '
        Me.JOKEN_AREA.CanGrow = False
        Me.JOKEN_AREA.Height = 0.2!
        Me.JOKEN_AREA.Left = 1.802756!
        Me.JOKEN_AREA.Name = "JOKEN_AREA"
        Me.JOKEN_AREA.Style = "white-space: nowrap"
        Me.JOKEN_AREA.Text = Nothing
        Me.JOKEN_AREA.Top = 1.433071!
        Me.JOKEN_AREA.Width = 1.479134!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.FormatString = "{PageNumber} / {PageCount}"
        Me.ReportInfo1.Height = 0.2!
        Me.ReportInfo1.Left = 10.62047!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = ""
        Me.ReportInfo1.Top = 0.4208662!
        Me.ReportInfo1.Width = 1.364567!
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.3149607!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6413386!
        Me.Shape1.Width = 12.16535!
        '
        'Label1
        '
        Me.Label1.Height = 0.2169291!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.03937008!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = resources.GetString("Label1.Style")
        Me.Label1.Text = "新着　交通・宿泊一覧"
        Me.Label1.Top = 0.6874017!
        Me.Label1.Width = 12.08661!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.6413386!
        Me.Line3.Width = 12.16535!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 12.16535!
        Me.Line3.Y1 = 0.6413386!
        Me.Line3.Y2 = 0.6413386!
        '
        'Line16
        '
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 0.0!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.9562993!
        Me.Line16.Width = 12.16535!
        Me.Line16.X1 = 0.0!
        Me.Line16.X2 = 12.16535!
        Me.Line16.Y1 = 0.9562993!
        Me.Line16.Y2 = 0.9562993!
        '
        'Line17
        '
        Me.Line17.Height = 0.3149606!
        Me.Line17.Left = 0.0!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.6413386!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 0.0!
        Me.Line17.X2 = 0.0!
        Me.Line17.Y1 = 0.6413386!
        Me.Line17.Y2 = 0.9562992!
        '
        'Line18
        '
        Me.Line18.Height = 0.3149609!
        Me.Line18.Left = 12.16535!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.6413386!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 12.16535!
        Me.Line18.X2 = 12.16535!
        Me.Line18.Y1 = 0.6413386!
        Me.Line18.Y2 = 0.9562995!
        '
        'Line19
        '
        Me.Line19.Height = 0.2818902!
        Me.Line19.Left = 12.16535!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 2.484252!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 12.16535!
        Me.Line19.X2 = 12.16535!
        Me.Line19.Y1 = 2.484252!
        Me.Line19.Y2 = 2.766142!
        '
        'Line20
        '
        Me.Line20.Height = 0.281889!
        Me.Line20.Left = 0.0!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 2.484252!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 0.0!
        Me.Line20.X2 = 0.0!
        Me.Line20.Y1 = 2.484252!
        Me.Line20.Y2 = 2.766141!
        '
        'Label13
        '
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 9.609843!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-align: right"
        Me.Label13.Text = "出力担当："
        Me.Label13.Top = 0.2055118!
        Me.Label13.Width = 1.010631!
        '
        'PRINT_USER
        '
        Me.PRINT_USER.Height = 0.2!
        Me.PRINT_USER.Left = 10.62047!
        Me.PRINT_USER.Name = "PRINT_USER"
        Me.PRINT_USER.Style = "white-space: nowrap"
        Me.PRINT_USER.Text = Nothing
        Me.PRINT_USER.Top = 0.2055118!
        Me.PRINT_USER.Width = 1.364567!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TO_DATE, Me.USER_NAME, Me.REQ_STATUS_TEHAI, Me.FROM_DATE, Me.KOUENKAI_NAME, Me.Line6, Me.TIME_STAMP, Me.Line14, Me.Line21, Me.DR_NAME, Me.REQ_KOTSU, Me.REQ_O_TEHAI_1, Me.REQ_HOTEL, Me.REQ_O_TEHAI_2, Me.REQ_O_TEHAI_3, Me.REQ_O_TEHAI_4, Me.REQ_O_TEHAI_5, Me.REQ_F_TEHAI_1, Me.REQ_F_TEHAI_2, Me.REQ_F_TEHAI_3, Me.REQ_F_TEHAI_4, Me.REQ_F_TEHAI_5, Me.TEHAI_TAXI, Me.Line4, Me.Line5, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12})
        Me.Detail.Height = 0.2437008!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'TO_DATE
        '
        Me.TO_DATE.CanGrow = False
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.2!
        Me.TO_DATE.Left = 5.574016!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Style = "text-align: center; white-space: nowrap"
        Me.TO_DATE.Text = Nothing
        Me.TO_DATE.Top = 0.3956693!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 0.353937!
        '
        'USER_NAME
        '
        Me.USER_NAME.CanGrow = False
        Me.USER_NAME.DataField = "USER_NAME"
        Me.USER_NAME.Height = 0.2!
        Me.USER_NAME.Left = 8.323623!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Style = "white-space: nowrap"
        Me.USER_NAME.Text = Nothing
        Me.USER_NAME.Top = 0.0!
        Me.USER_NAME.Width = 1.479134!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.CanGrow = False
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.2!
        Me.REQ_STATUS_TEHAI.Left = 9.875985!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Style = "text-align: center; white-space: nowrap"
        Me.REQ_STATUS_TEHAI.Top = 0.0!
        Me.REQ_STATUS_TEHAI.Width = 0.353937!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.CanGrow = False
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.2!
        Me.FROM_DATE.Left = 0.007874016!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Style = "white-space: nowrap"
        Me.FROM_DATE.Text = Nothing
        Me.FROM_DATE.Top = 0.0!
        Me.FROM_DATE.Width = 1.614567!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.CanGrow = False
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2!
        Me.KOUENKAI_NAME.Left = 1.696457!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "white-space: nowrap"
        Me.KOUENKAI_NAME.Top = 0.0!
        Me.KOUENKAI_NAME.Width = 2.364567!
        '
        'Line6
        '
        Me.Line6.Height = 0.2362205!
        Me.Line6.Left = 0.0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.0!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 0.0!
        Me.Line6.Y1 = 0.0!
        Me.Line6.Y2 = 0.2362205!
        '
        'Line14
        '
        Me.Line14.Height = 0.2362205!
        Me.Line14.Left = 12.16535!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.0!
        Me.Line14.Width = 0.0!
        Me.Line14.X1 = 12.16535!
        Me.Line14.X2 = 12.16535!
        Me.Line14.Y1 = 0.0!
        Me.Line14.Y2 = 0.2362205!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.0!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.2433071!
        Me.Line21.Width = 12.16535!
        Me.Line21.X1 = 0.0!
        Me.Line21.X2 = 12.16535!
        Me.Line21.Y1 = 0.2433071!
        Me.Line21.Y2 = 0.2433071!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label14
        '
        Me.Label14.Height = 0.2!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label14.Text = "区分："
        Me.Label14.Top = 1.633071!
        Me.Label14.Width = 1.802756!
        '
        'JOKEN_KUBUN
        '
        Me.JOKEN_KUBUN.CanGrow = False
        Me.JOKEN_KUBUN.Height = 0.2!
        Me.JOKEN_KUBUN.Left = 1.802756!
        Me.JOKEN_KUBUN.Name = "JOKEN_KUBUN"
        Me.JOKEN_KUBUN.Style = "white-space: nowrap"
        Me.JOKEN_KUBUN.Text = Nothing
        Me.JOKEN_KUBUN.Top = 1.633071!
        Me.JOKEN_KUBUN.Width = 1.479134!
        '
        'Label15
        '
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.0!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label15.Text = "講演会番号："
        Me.Label15.Top = 1.833071!
        Me.Label15.Width = 1.802756!
        '
        'JOKEN_KOUENKAI_NO
        '
        Me.JOKEN_KOUENKAI_NO.CanGrow = False
        Me.JOKEN_KOUENKAI_NO.Height = 0.2!
        Me.JOKEN_KOUENKAI_NO.Left = 1.802756!
        Me.JOKEN_KOUENKAI_NO.Name = "JOKEN_KOUENKAI_NO"
        Me.JOKEN_KOUENKAI_NO.Style = "white-space: nowrap"
        Me.JOKEN_KOUENKAI_NO.Top = 1.833071!
        Me.JOKEN_KOUENKAI_NO.Width = 1.083465!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.968898!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label16.Text = "講演会名："
        Me.Label16.Top = 1.833071!
        Me.Label16.Width = 0.8027562!
        '
        'JOKEN_KOUENKAI_NAME
        '
        Me.JOKEN_KOUENKAI_NAME.CanGrow = False
        Me.JOKEN_KOUENKAI_NAME.Height = 0.2!
        Me.JOKEN_KOUENKAI_NAME.Left = 3.781103!
        Me.JOKEN_KOUENKAI_NAME.Name = "JOKEN_KOUENKAI_NAME"
        Me.JOKEN_KOUENKAI_NAME.Style = "white-space: nowrap"
        Me.JOKEN_KOUENKAI_NAME.Top = 1.833071!
        Me.JOKEN_KOUENKAI_NAME.Width = 7.821654!
        '
        'Label17
        '
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.0!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label17.Text = "BYL企画担当者(ローマ字)："
        Me.Label17.Top = 2.033071!
        Me.Label17.Width = 1.802756!
        '
        'JOKEN_KIKAKU_TANTO_ROMA
        '
        Me.JOKEN_KIKAKU_TANTO_ROMA.CanGrow = False
        Me.JOKEN_KIKAKU_TANTO_ROMA.Height = 0.2!
        Me.JOKEN_KIKAKU_TANTO_ROMA.Left = 1.802756!
        Me.JOKEN_KIKAKU_TANTO_ROMA.Name = "JOKEN_KIKAKU_TANTO_ROMA"
        Me.JOKEN_KIKAKU_TANTO_ROMA.Style = "white-space: nowrap"
        Me.JOKEN_KIKAKU_TANTO_ROMA.Text = Nothing
        Me.JOKEN_KIKAKU_TANTO_ROMA.Top = 2.033071!
        Me.JOKEN_KIKAKU_TANTO_ROMA.Width = 1.479134!
        '
        'Label18
        '
        Me.Label18.Height = 0.2!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label18.Text = "BYL手配担当者(ローマ字)："
        Me.Label18.Top = 2.233071!
        Me.Label18.Width = 1.802756!
        '
        'JOKEN_TEHAI_TANTO_ROMA
        '
        Me.JOKEN_TEHAI_TANTO_ROMA.CanGrow = False
        Me.JOKEN_TEHAI_TANTO_ROMA.Height = 0.2!
        Me.JOKEN_TEHAI_TANTO_ROMA.Left = 1.802756!
        Me.JOKEN_TEHAI_TANTO_ROMA.Name = "JOKEN_TEHAI_TANTO_ROMA"
        Me.JOKEN_TEHAI_TANTO_ROMA.Style = "white-space: nowrap"
        Me.JOKEN_TEHAI_TANTO_ROMA.Text = Nothing
        Me.JOKEN_TEHAI_TANTO_ROMA.Top = 2.233071!
        Me.JOKEN_TEHAI_TANTO_ROMA.Width = 1.479134!
        '
        'TIME_STAMP
        '
        Me.TIME_STAMP.CanGrow = False
        Me.TIME_STAMP.DataField = "TIME_STAMP"
        Me.TIME_STAMP.Height = 0.2!
        Me.TIME_STAMP.Left = 6.614567!
        Me.TIME_STAMP.Name = "TIME_STAMP"
        Me.TIME_STAMP.Style = "white-space: nowrap"
        Me.TIME_STAMP.Text = Nothing
        Me.TIME_STAMP.Top = 0.0!
        Me.TIME_STAMP.Width = 1.614567!
        '
        'DR_NAME
        '
        Me.DR_NAME.CanGrow = False
        Me.DR_NAME.DataField = "DR_NAME"
        Me.DR_NAME.Height = 0.2!
        Me.DR_NAME.Left = 4.154725!
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.Style = "white-space: nowrap"
        Me.DR_NAME.Top = 0.0!
        Me.DR_NAME.Width = 2.364567!
        '
        'Label19
        '
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 4.154725!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック"
        Me.Label19.Text = "DR氏名"
        Me.Label19.Top = 2.525197!
        Me.Label19.Width = 1.051969!
        '
        'Label20
        '
        Me.Label20.Height = 0.2!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 10.77087!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; text-align: center"
        Me.Label20.Text = "交通"
        Me.Label20.Top = 2.525197!
        Me.Label20.Width = 0.353937!
        '
        'REQ_KOTSU
        '
        Me.REQ_KOTSU.CanGrow = False
        Me.REQ_KOTSU.Height = 0.2!
        Me.REQ_KOTSU.Left = 10.77087!
        Me.REQ_KOTSU.Name = "REQ_KOTSU"
        Me.REQ_KOTSU.Style = "text-align: center; white-space: nowrap"
        Me.REQ_KOTSU.Text = Nothing
        Me.REQ_KOTSU.Top = 0.0!
        Me.REQ_KOTSU.Visible = False
        Me.REQ_KOTSU.Width = 0.353937!
        '
        'REQ_O_TEHAI_1
        '
        Me.REQ_O_TEHAI_1.CanGrow = False
        Me.REQ_O_TEHAI_1.DataField = "REQ_O_TEHAI_1"
        Me.REQ_O_TEHAI_1.Height = 0.2!
        Me.REQ_O_TEHAI_1.Left = 6.051969!
        Me.REQ_O_TEHAI_1.Name = "REQ_O_TEHAI_1"
        Me.REQ_O_TEHAI_1.Style = "text-align: center; white-space: nowrap"
        Me.REQ_O_TEHAI_1.Text = Nothing
        Me.REQ_O_TEHAI_1.Top = 0.3956693!
        Me.REQ_O_TEHAI_1.Visible = False
        Me.REQ_O_TEHAI_1.Width = 0.353937!
        '
        'REQ_HOTEL
        '
        Me.REQ_HOTEL.CanGrow = False
        Me.REQ_HOTEL.DataField = "REQ_HOTEL"
        Me.REQ_HOTEL.Height = 0.2!
        Me.REQ_HOTEL.Left = 10.32283!
        Me.REQ_HOTEL.Name = "REQ_HOTEL"
        Me.REQ_HOTEL.Style = "white-space: nowrap"
        Me.REQ_HOTEL.Top = 0.0!
        Me.REQ_HOTEL.Width = 0.353937!
        '
        'REQ_O_TEHAI_2
        '
        Me.REQ_O_TEHAI_2.CanGrow = False
        Me.REQ_O_TEHAI_2.DataField = "REQ_O_TEHAI_2"
        Me.REQ_O_TEHAI_2.Height = 0.2!
        Me.REQ_O_TEHAI_2.Left = 6.519292!
        Me.REQ_O_TEHAI_2.Name = "REQ_O_TEHAI_2"
        Me.REQ_O_TEHAI_2.Style = "text-align: center; white-space: nowrap"
        Me.REQ_O_TEHAI_2.Text = Nothing
        Me.REQ_O_TEHAI_2.Top = 0.3956693!
        Me.REQ_O_TEHAI_2.Visible = False
        Me.REQ_O_TEHAI_2.Width = 0.353937!
        '
        'REQ_O_TEHAI_3
        '
        Me.REQ_O_TEHAI_3.CanGrow = False
        Me.REQ_O_TEHAI_3.DataField = "REQ_O_TEHAI_3"
        Me.REQ_O_TEHAI_3.Height = 0.2!
        Me.REQ_O_TEHAI_3.Left = 6.946457!
        Me.REQ_O_TEHAI_3.Name = "REQ_O_TEHAI_3"
        Me.REQ_O_TEHAI_3.Style = "text-align: center; white-space: nowrap"
        Me.REQ_O_TEHAI_3.Text = Nothing
        Me.REQ_O_TEHAI_3.Top = 0.3956693!
        Me.REQ_O_TEHAI_3.Visible = False
        Me.REQ_O_TEHAI_3.Width = 0.353937!
        '
        'REQ_O_TEHAI_4
        '
        Me.REQ_O_TEHAI_4.CanGrow = False
        Me.REQ_O_TEHAI_4.DataField = "REQ_O_TEHAI_4"
        Me.REQ_O_TEHAI_4.Height = 0.2!
        Me.REQ_O_TEHAI_4.Left = 7.373622!
        Me.REQ_O_TEHAI_4.Name = "REQ_O_TEHAI_4"
        Me.REQ_O_TEHAI_4.Style = "text-align: center; white-space: nowrap"
        Me.REQ_O_TEHAI_4.Text = Nothing
        Me.REQ_O_TEHAI_4.Top = 0.3956693!
        Me.REQ_O_TEHAI_4.Visible = False
        Me.REQ_O_TEHAI_4.Width = 0.353937!
        '
        'REQ_O_TEHAI_5
        '
        Me.REQ_O_TEHAI_5.CanGrow = False
        Me.REQ_O_TEHAI_5.DataField = "REQ_O_TEHAI_5"
        Me.REQ_O_TEHAI_5.Height = 0.2!
        Me.REQ_O_TEHAI_5.Left = 7.800788!
        Me.REQ_O_TEHAI_5.Name = "REQ_O_TEHAI_5"
        Me.REQ_O_TEHAI_5.Style = "text-align: center; white-space: nowrap"
        Me.REQ_O_TEHAI_5.Text = Nothing
        Me.REQ_O_TEHAI_5.Top = 0.3956693!
        Me.REQ_O_TEHAI_5.Visible = False
        Me.REQ_O_TEHAI_5.Width = 0.353937!
        '
        'REQ_F_TEHAI_1
        '
        Me.REQ_F_TEHAI_1.CanGrow = False
        Me.REQ_F_TEHAI_1.DataField = "REQ_F_TEHAI_1"
        Me.REQ_F_TEHAI_1.Height = 0.2!
        Me.REQ_F_TEHAI_1.Left = 8.229135!
        Me.REQ_F_TEHAI_1.Name = "REQ_F_TEHAI_1"
        Me.REQ_F_TEHAI_1.Style = "text-align: center; white-space: nowrap"
        Me.REQ_F_TEHAI_1.Text = Nothing
        Me.REQ_F_TEHAI_1.Top = 0.3956693!
        Me.REQ_F_TEHAI_1.Visible = False
        Me.REQ_F_TEHAI_1.Width = 0.353937!
        '
        'REQ_F_TEHAI_2
        '
        Me.REQ_F_TEHAI_2.CanGrow = False
        Me.REQ_F_TEHAI_2.DataField = "REQ_F_TEHAI_2"
        Me.REQ_F_TEHAI_2.Height = 0.2!
        Me.REQ_F_TEHAI_2.Left = 8.635434!
        Me.REQ_F_TEHAI_2.Name = "REQ_F_TEHAI_2"
        Me.REQ_F_TEHAI_2.Style = "text-align: center; white-space: nowrap"
        Me.REQ_F_TEHAI_2.Text = Nothing
        Me.REQ_F_TEHAI_2.Top = 0.3956693!
        Me.REQ_F_TEHAI_2.Visible = False
        Me.REQ_F_TEHAI_2.Width = 0.353937!
        '
        'REQ_F_TEHAI_3
        '
        Me.REQ_F_TEHAI_3.CanGrow = False
        Me.REQ_F_TEHAI_3.DataField = "REQ_F_TEHAI_3"
        Me.REQ_F_TEHAI_3.Height = 0.2!
        Me.REQ_F_TEHAI_3.Left = 9.041733!
        Me.REQ_F_TEHAI_3.Name = "REQ_F_TEHAI_3"
        Me.REQ_F_TEHAI_3.Style = "text-align: center; white-space: nowrap"
        Me.REQ_F_TEHAI_3.Text = Nothing
        Me.REQ_F_TEHAI_3.Top = 0.3956693!
        Me.REQ_F_TEHAI_3.Visible = False
        Me.REQ_F_TEHAI_3.Width = 0.353937!
        '
        'REQ_F_TEHAI_4
        '
        Me.REQ_F_TEHAI_4.CanGrow = False
        Me.REQ_F_TEHAI_4.DataField = "REQ_F_TEHAI_4"
        Me.REQ_F_TEHAI_4.Height = 0.2!
        Me.REQ_F_TEHAI_4.Left = 9.522048!
        Me.REQ_F_TEHAI_4.Name = "REQ_F_TEHAI_4"
        Me.REQ_F_TEHAI_4.Style = "text-align: center; white-space: nowrap"
        Me.REQ_F_TEHAI_4.Text = Nothing
        Me.REQ_F_TEHAI_4.Top = 0.3956693!
        Me.REQ_F_TEHAI_4.Visible = False
        Me.REQ_F_TEHAI_4.Width = 0.353937!
        '
        'REQ_F_TEHAI_5
        '
        Me.REQ_F_TEHAI_5.CanGrow = False
        Me.REQ_F_TEHAI_5.DataField = "REQ_F_TEHAI_5"
        Me.REQ_F_TEHAI_5.Height = 0.2!
        Me.REQ_F_TEHAI_5.Left = 9.968899!
        Me.REQ_F_TEHAI_5.Name = "REQ_F_TEHAI_5"
        Me.REQ_F_TEHAI_5.Style = "text-align: center; white-space: nowrap"
        Me.REQ_F_TEHAI_5.Text = Nothing
        Me.REQ_F_TEHAI_5.Top = 0.3956693!
        Me.REQ_F_TEHAI_5.Visible = False
        Me.REQ_F_TEHAI_5.Width = 0.353937!
        '
        'Label21
        '
        Me.Label21.Height = 0.2!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 11.19803!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; text-align: center"
        Me.Label21.Text = "タクチケ"
        Me.Label21.Top = 2.525197!
        Me.Label21.Width = 0.676771!
        '
        'TEHAI_TAXI
        '
        Me.TEHAI_TAXI.CanGrow = False
        Me.TEHAI_TAXI.DataField = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Height = 0.2!
        Me.TEHAI_TAXI.Left = 11.19803!
        Me.TEHAI_TAXI.Name = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Style = "text-align: center; white-space: nowrap"
        Me.TEHAI_TAXI.Text = Nothing
        Me.TEHAI_TAXI.Top = 0.0!
        Me.TEHAI_TAXI.Visible = False
        Me.TEHAI_TAXI.Width = 0.676771!
        '
        'Line4
        '
        Me.Line4.Height = 0.2362205!
        Me.Line4.Left = 1.65315!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.007086615!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 1.65315!
        Me.Line4.X2 = 1.65315!
        Me.Line4.Y1 = 0.007086615!
        Me.Line4.Y2 = 0.2433071!
        '
        'Line5
        '
        Me.Line5.Height = 0.2362205!
        Me.Line5.Left = 4.11378!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 4.11378!
        Me.Line5.X2 = 4.11378!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.2362205!
        '
        'Line7
        '
        Me.Line7.Height = 0.2362205!
        Me.Line7.Left = 6.563386!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.007086615!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 6.563386!
        Me.Line7.X2 = 6.563386!
        Me.Line7.Y1 = 0.007086615!
        Me.Line7.Y2 = 0.2433071!
        '
        'Line8
        '
        Me.Line8.Height = 0.2362205!
        Me.Line8.Left = 8.280315!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.0!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 8.280315!
        Me.Line8.X2 = 8.280315!
        Me.Line8.Y1 = 0.0!
        Me.Line8.Y2 = 0.2362205!
        '
        'Line9
        '
        Me.Line9.Height = 0.2362205!
        Me.Line9.Left = 9.83504!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.007086615!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 9.83504!
        Me.Line9.X2 = 9.83504!
        Me.Line9.Y1 = 0.007086615!
        Me.Line9.Y2 = 0.2433071!
        '
        'Line10
        '
        Me.Line10.Height = 0.2362205!
        Me.Line10.Left = 10.28189!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.007086615!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 10.28189!
        Me.Line10.X2 = 10.28189!
        Me.Line10.Y1 = 0.007086615!
        Me.Line10.Y2 = 0.2433071!
        '
        'Line11
        '
        Me.Line11.Height = 0.2362205!
        Me.Line11.Left = 10.71969!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.0!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 10.71969!
        Me.Line11.X2 = 10.71969!
        Me.Line11.Y1 = 0.0!
        Me.Line11.Y2 = 0.2362205!
        '
        'Line12
        '
        Me.Line12.Height = 0.2362205!
        Me.Line12.Left = 11.16732!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.0!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 11.16732!
        Me.Line12.X2 = 11.16732!
        Me.Line12.Y1 = 0.0!
        Me.Line12.Y2 = 0.2362205!
        '
        'Line13
        '
        Me.Line13.Height = 0.2818904!
        Me.Line13.Left = 11.16732!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 2.484252!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 11.16732!
        Me.Line13.X2 = 11.16732!
        Me.Line13.Y1 = 2.484252!
        Me.Line13.Y2 = 2.766143!
        '
        'Line15
        '
        Me.Line15.Height = 0.2818904!
        Me.Line15.Left = 10.71969!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 2.484252!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 10.71969!
        Me.Line15.X2 = 10.71969!
        Me.Line15.Y1 = 2.484252!
        Me.Line15.Y2 = 2.766143!
        '
        'Line22
        '
        Me.Line22.Height = 0.2818904!
        Me.Line22.Left = 10.28189!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 2.484252!
        Me.Line22.Width = 0.0!
        Me.Line22.X1 = 10.28189!
        Me.Line22.X2 = 10.28189!
        Me.Line22.Y1 = 2.484252!
        Me.Line22.Y2 = 2.766143!
        '
        'Line23
        '
        Me.Line23.Height = 0.2818904!
        Me.Line23.Left = 9.83504!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 2.484252!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 9.83504!
        Me.Line23.X2 = 9.83504!
        Me.Line23.Y1 = 2.484252!
        Me.Line23.Y2 = 2.766143!
        '
        'Line24
        '
        Me.Line24.Height = 0.2818904!
        Me.Line24.Left = 8.280315!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 2.484252!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 8.280315!
        Me.Line24.X2 = 8.280315!
        Me.Line24.Y1 = 2.484252!
        Me.Line24.Y2 = 2.766143!
        '
        'Line25
        '
        Me.Line25.Height = 0.2818904!
        Me.Line25.Left = 6.563386!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 2.484252!
        Me.Line25.Width = 0.0!
        Me.Line25.X1 = 6.563386!
        Me.Line25.X2 = 6.563386!
        Me.Line25.Y1 = 2.484252!
        Me.Line25.Y2 = 2.766143!
        '
        'Line26
        '
        Me.Line26.Height = 0.2818904!
        Me.Line26.Left = 4.11378!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 2.484252!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 4.11378!
        Me.Line26.X2 = 4.11378!
        Me.Line26.Y1 = 2.484252!
        Me.Line26.Y2 = 2.766143!
        '
        'Line27
        '
        Me.Line27.Height = 0.2818904!
        Me.Line27.Left = 1.65315!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 2.484252!
        Me.Line27.Width = 0.0!
        Me.Line27.X1 = 1.65315!
        Me.Line27.X2 = 1.65315!
        Me.Line27.Y1 = 2.484252!
        Me.Line27.Y2 = 2.766143!
        '
        'NewDrListReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 12.35276!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_USER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_KUBUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_KIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_TEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_KOTSU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_HOTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_USER As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_KUBUN As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_KIKAKU_TANTO_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_TEHAI_TANTO_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_KOTSU As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_O_TEHAI_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TAXI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
End Class
