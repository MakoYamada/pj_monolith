<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NewKouenkaiReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewKouenkaiReport))
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
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
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
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.TIME_STAMP = New DataDynamics.ActiveReports.TextBox
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
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
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Label2, Me.PRINT_DATE, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label8, Me.Line1, Me.Line2, Me.Label9, Me.Label10, Me.Label11, Me.JOKEN_BU, Me.Label12, Me.JOKEN_AREA, Me.ReportInfo1, Me.Shape1, Me.Label1, Me.Line4, Me.Line8, Me.Line9, Me.Line11, Me.Line15, Me.Line3, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Label13, Me.PRINT_USER})
        Me.PageHeader.Height = 2.025843!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.Silver
        Me.Shape2.Height = 0.2818897!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 1.737008!
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
        Me.Label3.Left = 0.02047244!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック"
        Me.Label3.Text = "BYL企画担当者BU"
        Me.Label3.Top = 1.777953!
        Me.Label3.Width = 1.458662!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.55315!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック"
        Me.Label4.Text = "BYL企画担当者エリア"
        Me.Label4.Top = 1.777953!
        Me.Label4.Width = 1.477952!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.093701!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック"
        Me.Label5.Text = "BYL企画担当者営業所"
        Me.Label5.Top = 1.777953!
        Me.Label5.Width = 1.479134!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.645669!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック"
        Me.Label6.Text = "開催日"
        Me.Label6.Top = 1.777953!
        Me.Label6.Width = 0.5102362!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.446064!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック"
        Me.Label7.Text = "会合名"
        Me.Label7.Top = 1.777953!
        Me.Label7.Width = 1.051969!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 10.53859!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック"
        Me.Label8.Text = "TimeStamp(BYL)"
        Me.Label8.Top = 1.777953!
        Me.Label8.Width = 1.051969!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.737008!
        Me.Line1.Width = 12.16535!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 12.16535!
        Me.Line1.Y1 = 1.737008!
        Me.Line1.Y2 = 1.737008!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.018899!
        Me.Line2.Width = 12.16535!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 12.16535!
        Me.Line2.Y1 = 2.018899!
        Me.Line2.Y2 = 2.018899!
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
        Me.Label11.Style = "font-family: ＭＳ ゴシック; text-align: right; text-justify: auto"
        Me.Label11.Text = "BYL企画担当者BU："
        Me.Label11.Top = 1.222835!
        Me.Label11.Width = 1.604331!
        '
        'JOKEN_BU
        '
        Me.JOKEN_BU.CanGrow = False
        Me.JOKEN_BU.Height = 0.2!
        Me.JOKEN_BU.Left = 1.614567!
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
        Me.Label12.Text = "BYL企画担当者エリア："
        Me.Label12.Top = 1.433071!
        Me.Label12.Width = 1.604331!
        '
        'JOKEN_AREA
        '
        Me.JOKEN_AREA.CanGrow = False
        Me.JOKEN_AREA.Height = 0.2!
        Me.JOKEN_AREA.Left = 1.614567!
        Me.JOKEN_AREA.Name = "JOKEN_AREA"
        Me.JOKEN_AREA.Style = "white-space: nowrap"
        Me.JOKEN_AREA.Text = Nothing
        Me.JOKEN_AREA.Top = 1.422835!
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
        Me.Label1.Text = "【新着】会合一覧"
        Me.Label1.Top = 0.6874017!
        Me.Label1.Width = 12.08661!
        '
        'Line4
        '
        Me.Line4.Height = 0.28189!
        Me.Line4.Left = 1.511024!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.737008!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 1.511024!
        Me.Line4.X2 = 1.511024!
        Me.Line4.Y1 = 1.737008!
        Me.Line4.Y2 = 2.018898!
        '
        'Line8
        '
        Me.Line8.Height = 0.28189!
        Me.Line8.Left = 3.061811!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.737008!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 3.061811!
        Me.Line8.X2 = 3.061811!
        Me.Line8.Y1 = 1.737008!
        Me.Line8.Y2 = 2.018898!
        '
        'Line9
        '
        Me.Line9.Height = 0.28189!
        Me.Line9.Left = 4.614961!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.737008!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 4.614961!
        Me.Line9.X2 = 4.614961!
        Me.Line9.Y1 = 1.737008!
        Me.Line9.Y2 = 2.018898!
        '
        'Line11
        '
        Me.Line11.Height = 0.28189!
        Me.Line11.Left = 6.354725!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 1.737008!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 6.354725!
        Me.Line11.X2 = 6.354725!
        Me.Line11.Y1 = 1.737008!
        Me.Line11.Y2 = 2.018898!
        '
        'Line15
        '
        Me.Line15.Height = 0.2818891!
        Me.Line15.Left = 10.51811!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 1.737008!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 10.51811!
        Me.Line15.X2 = 10.51811!
        Me.Line15.Y1 = 1.737008!
        Me.Line15.Y2 = 2.018897!
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
        Me.Line19.Height = 0.28189!
        Me.Line19.Left = 12.16535!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 1.737008!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 12.16535!
        Me.Line19.X2 = 12.16535!
        Me.Line19.Y1 = 1.737008!
        Me.Line19.Y2 = 2.018898!
        '
        'Line20
        '
        Me.Line20.Height = 0.2818891!
        Me.Line20.Left = 0.0!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 1.737008!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 0.0!
        Me.Line20.X2 = 0.0!
        Me.Line20.Y1 = 1.737008!
        Me.Line20.Y2 = 2.018897!
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
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TO_DATE, Me.BU, Me.KIKAKU_TANTO_AREA, Me.KIKAKU_TANTO_EIGYOSHO, Me.FROM_DATE, Me.KOUENKAI_NAME, Me.Line5, Me.Line6, Me.Line7, Me.Line10, Me.Line12, Me.Line13, Me.TIME_STAMP, Me.Line14, Me.Line21})
        Me.Detail.Height = 0.2437008!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'TO_DATE
        '
        Me.TO_DATE.CanGrow = False
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.2!
        Me.TO_DATE.Left = 4.645669!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Style = "white-space: nowrap"
        Me.TO_DATE.Text = Nothing
        Me.TO_DATE.Top = 0.0!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 1.614567!
        '
        'BU
        '
        Me.BU.CanGrow = False
        Me.BU.DataField = "BU"
        Me.BU.Height = 0.2!
        Me.BU.Left = 0.0!
        Me.BU.Name = "BU"
        Me.BU.Style = "white-space: nowrap"
        Me.BU.Text = Nothing
        Me.BU.Top = 0.0!
        Me.BU.Width = 1.479134!
        '
        'KIKAKU_TANTO_AREA
        '
        Me.KIKAKU_TANTO_AREA.CanGrow = False
        Me.KIKAKU_TANTO_AREA.DataField = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Height = 0.2!
        Me.KIKAKU_TANTO_AREA.Left = 1.551969!
        Me.KIKAKU_TANTO_AREA.Name = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Style = "white-space: nowrap"
        Me.KIKAKU_TANTO_AREA.Text = Nothing
        Me.KIKAKU_TANTO_AREA.Top = 0.0!
        Me.KIKAKU_TANTO_AREA.Width = 1.479134!
        '
        'KIKAKU_TANTO_EIGYOSHO
        '
        Me.KIKAKU_TANTO_EIGYOSHO.CanGrow = False
        Me.KIKAKU_TANTO_EIGYOSHO.DataField = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Height = 0.2!
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 3.093701!
        Me.KIKAKU_TANTO_EIGYOSHO.Name = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Style = "white-space: nowrap"
        Me.KIKAKU_TANTO_EIGYOSHO.Text = Nothing
        Me.KIKAKU_TANTO_EIGYOSHO.Top = 0.0!
        Me.KIKAKU_TANTO_EIGYOSHO.Width = 1.479134!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.CanGrow = False
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.2!
        Me.FROM_DATE.Left = 4.645669!
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
        Me.KOUENKAI_NAME.Left = 6.446064!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "white-space: nowrap"
        Me.KOUENKAI_NAME.Text = Nothing
        Me.KOUENKAI_NAME.Top = 0.0!
        Me.KOUENKAI_NAME.Width = 4.041733!
        '
        'Line5
        '
        Me.Line5.Height = 0.2362205!
        Me.Line5.Left = 1.511024!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 1.511024!
        Me.Line5.X2 = 1.511024!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.2362205!
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
        'Line7
        '
        Me.Line7.Height = 0.2362205!
        Me.Line7.Left = 3.061811!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 3.061811!
        Me.Line7.X2 = 3.061811!
        Me.Line7.Y1 = 0.0!
        Me.Line7.Y2 = 0.2362205!
        '
        'Line10
        '
        Me.Line10.Height = 0.2362205!
        Me.Line10.Left = 4.614961!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.0!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 4.614961!
        Me.Line10.X2 = 4.614961!
        Me.Line10.Y1 = 0.0!
        Me.Line10.Y2 = 0.2362205!
        '
        'Line12
        '
        Me.Line12.Height = 0.2362205!
        Me.Line12.Left = 6.354725!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.0!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 6.354725!
        Me.Line12.X2 = 6.354725!
        Me.Line12.Y1 = 0.0!
        Me.Line12.Y2 = 0.2362205!
        '
        'Line13
        '
        Me.Line13.Height = 0.2362204!
        Me.Line13.Left = 10.51811!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 10.51811!
        Me.Line13.X2 = 10.51811!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.2362204!
        '
        'TIME_STAMP
        '
        Me.TIME_STAMP.CanGrow = False
        Me.TIME_STAMP.DataField = "TIME_STAMP"
        Me.TIME_STAMP.Height = 0.2!
        Me.TIME_STAMP.Left = 10.55079!
        Me.TIME_STAMP.Name = "TIME_STAMP"
        Me.TIME_STAMP.Style = "white-space: nowrap"
        Me.TIME_STAMP.Text = Nothing
        Me.TIME_STAMP.Top = 0.0!
        Me.TIME_STAMP.Width = 1.614567!
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
        'NewKouenkaiReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 12.20472!
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
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents KIKAKU_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents KIKAKU_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents TIME_STAMP As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
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
End Class
