<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class KouenkaiRirekiReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(KouenkaiRirekiReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.ReportInfo1 = New DataDynamics.ActiveReports.ReportInfo
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.JOKEN_KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP = New DataDynamics.ActiveReports.TextBox
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.UPDATE_DATE = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JOKEN_KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UPDATE_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label2, Me.PRINT_DATE, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label8, Me.Line1, Me.Line2, Me.Label9, Me.ReportInfo1, Me.Label13, Me.Label16, Me.JOKEN_KOUENKAI_NO, Me.Label17, Me.JOKEN_KOUENKAI_NAME, Me.Label7})
        Me.PageHeader.Height = 1.11688!
        Me.PageHeader.Name = "PageHeader"
        '
        'Label1
        '
        Me.Label1.Height = 0.2728347!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 16pt; font-weight: bold"
        Me.Label1.Text = "講演会基本情報履歴一覧"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 3.781496!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 10.03701!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
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
        Me.Label3.Left = 3.573229!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック"
        Me.Label3.Text = "BYL企画担当BU"
        Me.Label3.Top = 0.86063!
        Me.Label3.Width = 1.479134!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.126379!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック"
        Me.Label4.Text = "BYL企画担当エリア"
        Me.Label4.Top = 0.86063!
        Me.Label4.Width = 1.477952!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 6.66693!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック"
        Me.Label5.Text = "BYL企画担当営業所"
        Me.Label5.Top = 0.86063!
        Me.Label5.Width = 1.479134!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 8.218898!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック"
        Me.Label6.Text = "実施日"
        Me.Label6.Top = 0.86063!
        Me.Label6.Width = 0.5102362!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック"
        Me.Label8.Text = "TimeStamp(BYL)"
        Me.Label8.Top = 0.86063!
        Me.Label8.Width = 1.051969!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.819684!
        Me.Line1.Width = 12.16535!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 12.16535!
        Me.Line1.Y1 = 0.819684!
        Me.Line1.Y2 = 0.819684!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.101575!
        Me.Line2.Width = 12.16535!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 12.16535!
        Me.Line2.Y1 = 1.101575!
        Me.Line2.Y2 = 1.101575!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 10.03701!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = ""
        Me.Label9.Text = "ページ："
        Me.Label9.Top = 0.2!
        Me.Label9.Width = 0.5834652!
        '
        'ReportInfo1
        '
        Me.ReportInfo1.FormatString = "{PageNumber} / {PageCount}"
        Me.ReportInfo1.Height = 0.2!
        Me.ReportInfo1.Left = 10.62047!
        Me.ReportInfo1.Name = "ReportInfo1"
        Me.ReportInfo1.Style = ""
        Me.ReportInfo1.Top = 0.2!
        Me.ReportInfo1.Width = 1.364567!
        '
        'Label13
        '
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 10.03701!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック"
        Me.Label13.Text = "TOP担当者"
        Me.Label13.Top = 0.860629!
        Me.Label13.Width = 1.051969!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; text-align: left"
        Me.Label16.Text = "講演会番号："
        Me.Label16.Top = 0.5519685!
        Me.Label16.Width = 0.864567!
        '
        'JOKEN_KOUENKAI_NO
        '
        Me.JOKEN_KOUENKAI_NO.CanGrow = False
        Me.JOKEN_KOUENKAI_NO.Height = 0.2000002!
        Me.JOKEN_KOUENKAI_NO.Left = 0.864567!
        Me.JOKEN_KOUENKAI_NO.Name = "JOKEN_KOUENKAI_NO"
        Me.JOKEN_KOUENKAI_NO.Style = "white-space: nowrap"
        Me.JOKEN_KOUENKAI_NO.Text = Nothing
        Me.JOKEN_KOUENKAI_NO.Top = 0.5519685!
        Me.JOKEN_KOUENKAI_NO.Width = 1.114567!
        '
        'Label17
        '
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 1.979133!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.Label17.Text = "講演会名："
        Me.Label17.Top = 0.5519685!
        Me.Label17.Width = 0.9062994!
        '
        'JOKEN_KOUENKAI_NAME
        '
        Me.JOKEN_KOUENKAI_NAME.CanGrow = False
        Me.JOKEN_KOUENKAI_NAME.Height = 0.2000002!
        Me.JOKEN_KOUENKAI_NAME.Left = 2.885433!
        Me.JOKEN_KOUENKAI_NAME.Name = "JOKEN_KOUENKAI_NAME"
        Me.JOKEN_KOUENKAI_NAME.Style = "white-space: nowrap"
        Me.JOKEN_KOUENKAI_NAME.Text = Nothing
        Me.JOKEN_KOUENKAI_NAME.Top = 0.5519685!
        Me.JOKEN_KOUENKAI_NAME.Width = 4.248425!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.583465!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック"
        Me.Label7.Text = "更新日"
        Me.Label7.Top = 0.86063!
        Me.Label7.Width = 1.051969!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TO_DATE, Me.BU, Me.KIKAKU_TANTO_AREA, Me.KIKAKU_TANTO_EIGYOSHO, Me.FROM_DATE, Me.TIME_STAMP, Me.USER_NAME, Me.UPDATE_DATE})
        Me.Detail.Height = 0.2458334!
        Me.Detail.Name = "Detail"
        '
        'TO_DATE
        '
        Me.TO_DATE.CanGrow = False
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.2!
        Me.TO_DATE.Left = 8.218898!
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
        Me.BU.Left = 3.573229!
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
        Me.KIKAKU_TANTO_AREA.Left = 5.125198!
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
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 6.66693!
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
        Me.FROM_DATE.Left = 8.218898!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Style = "white-space: nowrap"
        Me.FROM_DATE.Text = Nothing
        Me.FROM_DATE.Top = 0.0!
        Me.FROM_DATE.Width = 1.614567!
        '
        'TIME_STAMP
        '
        Me.TIME_STAMP.CanGrow = False
        Me.TIME_STAMP.DataField = "TIME_STAMP"
        Me.TIME_STAMP.Height = 0.2!
        Me.TIME_STAMP.Left = 0.0!
        Me.TIME_STAMP.Name = "TIME_STAMP"
        Me.TIME_STAMP.Style = "white-space: nowrap"
        Me.TIME_STAMP.Text = Nothing
        Me.TIME_STAMP.Top = 0.0!
        Me.TIME_STAMP.Width = 1.312598!
        '
        'USER_NAME
        '
        Me.USER_NAME.CanGrow = False
        Me.USER_NAME.DataField = "USER_NAME"
        Me.USER_NAME.Height = 0.2!
        Me.USER_NAME.Left = 10.03701!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Style = "white-space: nowrap"
        Me.USER_NAME.Text = Nothing
        Me.USER_NAME.Top = 0.0!
        Me.USER_NAME.Width = 2.0!
        '
        'UPDATE_DATE
        '
        Me.UPDATE_DATE.CanGrow = False
        Me.UPDATE_DATE.DataField = "UPDATE_DATE"
        Me.UPDATE_DATE.Height = 0.2!
        Me.UPDATE_DATE.Left = 1.583465!
        Me.UPDATE_DATE.Name = "UPDATE_DATE"
        Me.UPDATE_DATE.Style = "white-space: nowrap"
        Me.UPDATE_DATE.Text = Nothing
        Me.UPDATE_DATE.Top = 0.0!
        Me.UPDATE_DATE.Width = 1.312598!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'KouenkaiRirekiReport
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
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JOKEN_KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UPDATE_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents KIKAKU_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ReportInfo1 As DataDynamics.ActiveReports.ReportInfo
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents JOKEN_KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents UPDATE_DATE As DataDynamics.ActiveReports.TextBox
End Class
