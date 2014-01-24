<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrSoufujo
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
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrSoufujo))
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEND_SAKI = New DataDynamics.ActiveReports.TextBox
        Me.MR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.JISSI_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.SANKASHA_ID = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.KAIJO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEND_SAKI_FS = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEND_SAKI_OTHER = New DataDynamics.ActiveReports.TextBox
        Me.AISATSU1 = New DataDynamics.ActiveReports.TextBox
        Me.AISATSU2 = New DataDynamics.ActiveReports.TextBox
        Me.AISATSU3 = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.JR_SETSUMEI1 = New DataDynamics.ActiveReports.TextBox
        Me.AIR_SETSUMEI1 = New DataDynamics.ActiveReports.TextBox
        Me.OTHER_SETSUMEI1 = New DataDynamics.ActiveReports.TextBox
        Me.FOOTER_SETSUMEI1 = New DataDynamics.ActiveReports.TextBox
        Me.JR_SETSUMEI2 = New DataDynamics.ActiveReports.TextBox
        Me.JR_SETSUMEI3 = New DataDynamics.ActiveReports.TextBox
        Me.JR_SETSUMEI4 = New DataDynamics.ActiveReports.TextBox
        Me.AIR_SETSUMEI2 = New DataDynamics.ActiveReports.TextBox
        Me.AIR_SETSUMEI3 = New DataDynamics.ActiveReports.TextBox
        Me.AIR_SETSUMEI4 = New DataDynamics.ActiveReports.TextBox
        Me.AIR_SETSUMEI5 = New DataDynamics.ActiveReports.TextBox
        Me.AIR_SETSUMEI6 = New DataDynamics.ActiveReports.TextBox
        Me.OTHER_SETSUMEI2 = New DataDynamics.ActiveReports.TextBox
        Me.FOOTER_SETSUMEI2 = New DataDynamics.ActiveReports.TextBox
        Me.FOOTER_SETSUMEI3 = New DataDynamics.ActiveReports.TextBox
        Me.FOOTER_SETSUMEI4 = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEND_SAKI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JISSI_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAIJO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEND_SAKI_FS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEND_SAKI_OTHER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISATSU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISATSU2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AISATSU3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JR_SETSUMEI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_SETSUMEI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_SETSUMEI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOOTER_SETSUMEI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JR_SETSUMEI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JR_SETSUMEI3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JR_SETSUMEI4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_SETSUMEI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_SETSUMEI3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_SETSUMEI4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_SETSUMEI5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_SETSUMEI6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_SETSUMEI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOOTER_SETSUMEI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOOTER_SETSUMEI3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOOTER_SETSUMEI4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.CanShrink = True
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3})
        Me.Detail.Height = 0.3914372!
        Me.Detail.Name = "Detail"
        '
        'Label3
        '
        Me.Label3.Height = 0.1791339!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: bold; text-align: center; ddo" & _
            "-char-set: 1"
        Me.Label3.Text = "送付チケット内訳表"
        Me.Label3.Top = 0.0330711!
        Me.Label3.Width = 7.151969!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.CanShrink = True
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.PRINT_DATE, Me.Label1, Me.Label2, Me.DR_NAME, Me.MR_SEND_SAKI, Me.MR_NAME, Me.Label4, Me.JISSI_DATE, Me.Label5, Me.KOUENKAI_NAME, Me.Label6, Me.KOUENKAI_NO, Me.Label7, Me.SANKASHA_ID, Me.Label8, Me.KAIJO_NAME, Me.MR_SEND_SAKI_FS, Me.MR_SEND_SAKI_OTHER, Me.AISATSU1, Me.AISATSU2, Me.AISATSU3})
        Me.GroupHeader1.DataField = "=KOUENKAI_NO + SANKASHA_ID"
        Me.GroupHeader1.Height = 3.604166!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.NewPage = DataDynamics.ActiveReports.NewPage.Before
        '
        'GroupFooter1
        '
        Me.GroupFooter1.CanShrink = True
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label9, Me.JR_SETSUMEI1, Me.AIR_SETSUMEI1, Me.OTHER_SETSUMEI1, Me.FOOTER_SETSUMEI1, Me.JR_SETSUMEI2, Me.JR_SETSUMEI3, Me.JR_SETSUMEI4, Me.AIR_SETSUMEI2, Me.AIR_SETSUMEI3, Me.AIR_SETSUMEI4, Me.AIR_SETSUMEI5, Me.AIR_SETSUMEI6, Me.OTHER_SETSUMEI2, Me.FOOTER_SETSUMEI2, Me.FOOTER_SETSUMEI3, Me.FOOTER_SETSUMEI4})
        Me.GroupFooter1.Height = 3.520833!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'PRINT_DATE
        '
        Me.PRINT_DATE.Height = 0.2!
        Me.PRINT_DATE.Left = 6.086615!
        Me.PRINT_DATE.Name = "PRINT_DATE"
        Me.PRINT_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.PRINT_DATE.Text = "1234年56月78日"
        Me.PRINT_DATE.Top = 0.0!
        Me.PRINT_DATE.Width = 1.065354!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.50315!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: right"
        Me.Label1.Text = "送付日："
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.5834652!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center; ddo" & _
            "-char-set: 128"
        Me.Label2.Text = "チケット類送付状"
        Me.Label2.Top = 2.056693!
        Me.Label2.Width = 7.151965!
        '
        'DR_NAME
        '
        Me.DR_NAME.DataField = "DR_NAME"
        Me.DR_NAME.Height = 0.2!
        Me.DR_NAME.Left = 0.553937!
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle; w" & _
            "hite-space: nowrap"
        Me.DR_NAME.Text = "[DR_NAME]"
        Me.DR_NAME.Top = 0.1999996!
        Me.DR_NAME.Width = 3.495275!
        '
        'MR_SEND_SAKI
        '
        Me.MR_SEND_SAKI.DataField = "MR_SEND_SAKI_FS"
        Me.MR_SEND_SAKI.Height = 1.044095!
        Me.MR_SEND_SAKI.Left = 0.553937!
        Me.MR_SEND_SAKI.Name = "MR_SEND_SAKI"
        Me.MR_SEND_SAKI.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top"
        Me.MR_SEND_SAKI.Text = "[MR_SEND_SAKI]"
        Me.MR_SEND_SAKI.Top = 0.5165352!
        Me.MR_SEND_SAKI.Width = 3.380709!
        '
        'MR_NAME
        '
        Me.MR_NAME.DataField = "MR_NAME"
        Me.MR_NAME.Height = 0.2!
        Me.MR_NAME.Left = 0.553937!
        Me.MR_NAME.Name = "MR_NAME"
        Me.MR_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle; w" & _
            "hite-space: nowrap"
        Me.MR_NAME.Text = "[MR_NAME]"
        Me.MR_NAME.Top = 1.651969!
        Me.MR_NAME.Width = 3.495275!
        '
        'Label4
        '
        Me.Label4.Height = 0.1791339!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.5311024!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.Label4.Text = "講演会開催日："
        Me.Label4.Top = 2.377167!
        Me.Label4.Width = 0.8744091!
        '
        'JISSI_DATE
        '
        Me.JISSI_DATE.DataField = "FROM_DATE"
        Me.JISSI_DATE.Height = 0.1791339!
        Me.JISSI_DATE.Left = 1.416535!
        Me.JISSI_DATE.Name = "JISSI_DATE"
        Me.JISSI_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.JISSI_DATE.Text = "1234年12月12日(月)～1234年12月12日(月)"
        Me.JISSI_DATE.Top = 2.377167!
        Me.JISSI_DATE.Width = 2.420866!
        '
        'Label5
        '
        Me.Label5.Height = 0.1791339!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.5311024!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.Label5.Text = "講演会名："
        Me.Label5.Top = 2.556299!
        Me.Label5.Width = 0.8744097!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.CanShrink = True
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.1791339!
        Me.KOUENKAI_NAME.Left = 1.405512!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.KOUENKAI_NAME.Text = "[KOUENKAI_NAME]"
        Me.KOUENKAI_NAME.Top = 2.556299!
        Me.KOUENKAI_NAME.Width = 5.694095!
        '
        'Label6
        '
        Me.Label6.Height = 0.1791339!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 3.934646!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.Label6.Text = "講演会ID："
        Me.Label6.Top = 2.377167!
        Me.Label6.Width = 0.6354331!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.1791339!
        Me.KOUENKAI_NO.Left = 4.570079!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.KOUENKAI_NO.Text = "[KOUENKAI_NO]"
        Me.KOUENKAI_NO.Top = 2.377166!
        Me.KOUENKAI_NO.Width = 0.9330716!
        '
        'Label7
        '
        Me.Label7.Height = 0.1791339!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.50945!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.Label7.Text = "参加者ID："
        Me.Label7.Top = 2.377166!
        Me.Label7.Width = 0.6665354!
        '
        'SANKASHA_ID
        '
        Me.SANKASHA_ID.DataField = "SANKASHA_ID"
        Me.SANKASHA_ID.Height = 0.1791339!
        Me.SANKASHA_ID.Left = 6.175985!
        Me.SANKASHA_ID.Name = "SANKASHA_ID"
        Me.SANKASHA_ID.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.SANKASHA_ID.Text = "[SANKASHA_ID]"
        Me.SANKASHA_ID.Top = 2.377166!
        Me.SANKASHA_ID.Width = 0.9236222!
        '
        'Label8
        '
        Me.Label8.Height = 0.1791339!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.5200788!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: top; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.Label8.Text = "会場："
        Me.Label8.Top = 2.735433!
        Me.Label8.Width = 0.8854334!
        '
        'KAIJO_NAME
        '
        Me.KAIJO_NAME.DataField = "KAIJO_NAME"
        Me.KAIJO_NAME.Height = 0.1791339!
        Me.KAIJO_NAME.Left = 1.405512!
        Me.KAIJO_NAME.Name = "KAIJO_NAME"
        Me.KAIJO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.KAIJO_NAME.Text = "[KAIJO_NAME]"
        Me.KAIJO_NAME.Top = 2.735433!
        Me.KAIJO_NAME.Width = 5.694095!
        '
        'MR_SEND_SAKI_FS
        '
        Me.MR_SEND_SAKI_FS.DataField = "MR_SEND_SAKI_FS"
        Me.MR_SEND_SAKI_FS.Height = 0.2!
        Me.MR_SEND_SAKI_FS.Left = 5.50315!
        Me.MR_SEND_SAKI_FS.Name = "MR_SEND_SAKI_FS"
        Me.MR_SEND_SAKI_FS.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle; w" & _
            "hite-space: nowrap"
        Me.MR_SEND_SAKI_FS.Text = "[MR_SEND_SAKI_FS]"
        Me.MR_SEND_SAKI_FS.Top = 0.2!
        Me.MR_SEND_SAKI_FS.Visible = False
        Me.MR_SEND_SAKI_FS.Width = 1.276378!
        '
        'MR_SEND_SAKI_OTHER
        '
        Me.MR_SEND_SAKI_OTHER.DataField = "MR_SEND_SAKI_OTHER"
        Me.MR_SEND_SAKI_OTHER.Height = 0.2!
        Me.MR_SEND_SAKI_OTHER.Left = 5.50315!
        Me.MR_SEND_SAKI_OTHER.Name = "MR_SEND_SAKI_OTHER"
        Me.MR_SEND_SAKI_OTHER.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle; w" & _
            "hite-space: nowrap"
        Me.MR_SEND_SAKI_OTHER.Text = "[MR_SEND_SAKI_OTHER]"
        Me.MR_SEND_SAKI_OTHER.Top = 0.4!
        Me.MR_SEND_SAKI_OTHER.Visible = False
        Me.MR_SEND_SAKI_OTHER.Width = 1.536614!
        '
        'AISATSU1
        '
        Me.AISATSU1.Height = 0.1791339!
        Me.AISATSU1.Left = 0.5200788!
        Me.AISATSU1.Name = "AISATSU1"
        Me.AISATSU1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.AISATSU1.Text = "[AISATSU1]"
        Me.AISATSU1.Top = 3.016928!
        Me.AISATSU1.Width = 6.579529!
        '
        'AISATSU2
        '
        Me.AISATSU2.Height = 0.1791339!
        Me.AISATSU2.Left = 0.5311024!
        Me.AISATSU2.Name = "AISATSU2"
        Me.AISATSU2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.AISATSU2.Text = "[AISATSU2]"
        Me.AISATSU2.Top = 3.196063!
        Me.AISATSU2.Width = 6.568504!
        '
        'AISATSU3
        '
        Me.AISATSU3.Height = 0.1791339!
        Me.AISATSU3.Left = 0.5200788!
        Me.AISATSU3.Name = "AISATSU3"
        Me.AISATSU3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: top; whit" & _
            "e-space: nowrap; ddo-char-set: 1"
        Me.AISATSU3.Text = "[AISATSU3]"
        Me.AISATSU3.Top = 3.375197!
        Me.AISATSU3.Width = 6.579529!
        '
        'Label9
        '
        Me.Label9.Height = 0.230315!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.0!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 10.5pt; font-weight: normal; text-align: left; d" & _
            "do-char-set: 1"
        Me.Label9.Text = "～　チケット類の変更、取消について　～"
        Me.Label9.Top = 0.0!
        Me.Label9.Width = 7.151965!
        '
        'JR_SETSUMEI1
        '
        Me.JR_SETSUMEI1.Height = 0.1791339!
        Me.JR_SETSUMEI1.Left = 0.0!
        Me.JR_SETSUMEI1.Name = "JR_SETSUMEI1"
        Me.JR_SETSUMEI1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.JR_SETSUMEI1.Text = "[JR_SETSUMEI1]"
        Me.JR_SETSUMEI1.Top = 0.230315!
        Me.JR_SETSUMEI1.Width = 7.151965!
        '
        'AIR_SETSUMEI1
        '
        Me.AIR_SETSUMEI1.Height = 0.1791339!
        Me.AIR_SETSUMEI1.Left = 0.0!
        Me.AIR_SETSUMEI1.Name = "AIR_SETSUMEI1"
        Me.AIR_SETSUMEI1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.AIR_SETSUMEI1.Text = "[AIR_SETSUMEI1]"
        Me.AIR_SETSUMEI1.Top = 0.9468502!
        Me.AIR_SETSUMEI1.Width = 7.151965!
        '
        'OTHER_SETSUMEI1
        '
        Me.OTHER_SETSUMEI1.Height = 0.2!
        Me.OTHER_SETSUMEI1.Left = 0.0!
        Me.OTHER_SETSUMEI1.Name = "OTHER_SETSUMEI1"
        Me.OTHER_SETSUMEI1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.OTHER_SETSUMEI1.Text = "[OTHER_SETSUMEI1]"
        Me.OTHER_SETSUMEI1.Top = 2.32874!
        Me.OTHER_SETSUMEI1.Width = 7.151965!
        '
        'FOOTER_SETSUMEI1
        '
        Me.FOOTER_SETSUMEI1.Height = 0.1791339!
        Me.FOOTER_SETSUMEI1.Left = 0.0!
        Me.FOOTER_SETSUMEI1.Name = "FOOTER_SETSUMEI1"
        Me.FOOTER_SETSUMEI1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.FOOTER_SETSUMEI1.Text = "[FOOTER_SETSUMEI1]"
        Me.FOOTER_SETSUMEI1.Top = 2.810235!
        Me.FOOTER_SETSUMEI1.Width = 7.151965!
        '
        'JR_SETSUMEI2
        '
        Me.JR_SETSUMEI2.Height = 0.1791338!
        Me.JR_SETSUMEI2.Left = 0.0!
        Me.JR_SETSUMEI2.Name = "JR_SETSUMEI2"
        Me.JR_SETSUMEI2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.JR_SETSUMEI2.Text = "[JR_SETSUMEI2]"
        Me.JR_SETSUMEI2.Top = 0.4094489!
        Me.JR_SETSUMEI2.Width = 7.151965!
        '
        'JR_SETSUMEI3
        '
        Me.JR_SETSUMEI3.Height = 0.1791339!
        Me.JR_SETSUMEI3.Left = 0.0!
        Me.JR_SETSUMEI3.Name = "JR_SETSUMEI3"
        Me.JR_SETSUMEI3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.JR_SETSUMEI3.Text = "[JR_SETSUMEI3]"
        Me.JR_SETSUMEI3.Top = 0.5885828!
        Me.JR_SETSUMEI3.Width = 7.151965!
        '
        'JR_SETSUMEI4
        '
        Me.JR_SETSUMEI4.Height = 0.1791339!
        Me.JR_SETSUMEI4.Left = 0.0!
        Me.JR_SETSUMEI4.Name = "JR_SETSUMEI4"
        Me.JR_SETSUMEI4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.JR_SETSUMEI4.Text = "[JR_SETSUMEI4]"
        Me.JR_SETSUMEI4.Top = 0.7677161!
        Me.JR_SETSUMEI4.Width = 7.151965!
        '
        'AIR_SETSUMEI2
        '
        Me.AIR_SETSUMEI2.Height = 0.1791339!
        Me.AIR_SETSUMEI2.Left = 0.0!
        Me.AIR_SETSUMEI2.Name = "AIR_SETSUMEI2"
        Me.AIR_SETSUMEI2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.AIR_SETSUMEI2.Text = "[AIR_SETSUMEI2]"
        Me.AIR_SETSUMEI2.Top = 1.125984!
        Me.AIR_SETSUMEI2.Width = 7.151965!
        '
        'AIR_SETSUMEI3
        '
        Me.AIR_SETSUMEI3.Height = 0.1791339!
        Me.AIR_SETSUMEI3.Left = 0.0!
        Me.AIR_SETSUMEI3.Name = "AIR_SETSUMEI3"
        Me.AIR_SETSUMEI3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.AIR_SETSUMEI3.Text = "[AIR_SETSUMEI3]"
        Me.AIR_SETSUMEI3.Top = 1.40748!
        Me.AIR_SETSUMEI3.Width = 7.151965!
        '
        'AIR_SETSUMEI4
        '
        Me.AIR_SETSUMEI4.Height = 0.1791339!
        Me.AIR_SETSUMEI4.Left = 0.0!
        Me.AIR_SETSUMEI4.Name = "AIR_SETSUMEI4"
        Me.AIR_SETSUMEI4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.AIR_SETSUMEI4.Text = "[AIR_SETSUMEI4]"
        Me.AIR_SETSUMEI4.Top = 1.586614!
        Me.AIR_SETSUMEI4.Width = 7.151965!
        '
        'AIR_SETSUMEI5
        '
        Me.AIR_SETSUMEI5.Height = 0.1791339!
        Me.AIR_SETSUMEI5.Left = 0.0!
        Me.AIR_SETSUMEI5.Name = "AIR_SETSUMEI5"
        Me.AIR_SETSUMEI5.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.AIR_SETSUMEI5.Text = "[AIR_SETSUMEI5]"
        Me.AIR_SETSUMEI5.Top = 1.86811!
        Me.AIR_SETSUMEI5.Width = 7.151965!
        '
        'AIR_SETSUMEI6
        '
        Me.AIR_SETSUMEI6.Height = 0.1791339!
        Me.AIR_SETSUMEI6.Left = 0.0!
        Me.AIR_SETSUMEI6.Name = "AIR_SETSUMEI6"
        Me.AIR_SETSUMEI6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.AIR_SETSUMEI6.Text = "[AIR_SETSUMEI6]"
        Me.AIR_SETSUMEI6.Top = 2.047244!
        Me.AIR_SETSUMEI6.Width = 7.151965!
        '
        'OTHER_SETSUMEI2
        '
        Me.OTHER_SETSUMEI2.Height = 0.1791339!
        Me.OTHER_SETSUMEI2.Left = 0.0!
        Me.OTHER_SETSUMEI2.Name = "OTHER_SETSUMEI2"
        Me.OTHER_SETSUMEI2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.OTHER_SETSUMEI2.Text = "[OTHER_SETSUMEI2]"
        Me.OTHER_SETSUMEI2.Top = 2.528739!
        Me.OTHER_SETSUMEI2.Width = 7.151965!
        '
        'FOOTER_SETSUMEI2
        '
        Me.FOOTER_SETSUMEI2.Height = 0.1791339!
        Me.FOOTER_SETSUMEI2.Left = 0.0!
        Me.FOOTER_SETSUMEI2.Name = "FOOTER_SETSUMEI2"
        Me.FOOTER_SETSUMEI2.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.FOOTER_SETSUMEI2.Text = "[FOOTER_SETSUMEI2]"
        Me.FOOTER_SETSUMEI2.Top = 2.989369!
        Me.FOOTER_SETSUMEI2.Width = 7.151965!
        '
        'FOOTER_SETSUMEI3
        '
        Me.FOOTER_SETSUMEI3.Height = 0.1791339!
        Me.FOOTER_SETSUMEI3.Left = 0.0!
        Me.FOOTER_SETSUMEI3.Name = "FOOTER_SETSUMEI3"
        Me.FOOTER_SETSUMEI3.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.FOOTER_SETSUMEI3.Text = "[FOOTER_SETSUMEI3]"
        Me.FOOTER_SETSUMEI3.Top = 3.168503!
        Me.FOOTER_SETSUMEI3.Width = 7.151965!
        '
        'FOOTER_SETSUMEI4
        '
        Me.FOOTER_SETSUMEI4.Height = 0.1791339!
        Me.FOOTER_SETSUMEI4.Left = 0.0!
        Me.FOOTER_SETSUMEI4.Name = "FOOTER_SETSUMEI4"
        Me.FOOTER_SETSUMEI4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: left; vertical-align: middle"
        Me.FOOTER_SETSUMEI4.Text = "[FOOTER_SETSUMEI4]"
        Me.FOOTER_SETSUMEI4.Top = 3.347637!
        Me.FOOTER_SETSUMEI4.Width = 7.151965!
        '
        'DrSoufujo
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.165355!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEND_SAKI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JISSI_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAIJO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEND_SAKI_FS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEND_SAKI_OTHER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISATSU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISATSU2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AISATSU3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JR_SETSUMEI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_SETSUMEI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_SETSUMEI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOOTER_SETSUMEI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JR_SETSUMEI2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JR_SETSUMEI3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JR_SETSUMEI4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_SETSUMEI2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_SETSUMEI3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_SETSUMEI4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_SETSUMEI5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_SETSUMEI6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_SETSUMEI2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOOTER_SETSUMEI2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOOTER_SETSUMEI3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOOTER_SETSUMEI4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Private WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEND_SAKI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents JISSI_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents SANKASHA_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents KAIJO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEND_SAKI_FS As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEND_SAKI_OTHER As DataDynamics.ActiveReports.TextBox
    Private WithEvents AISATSU1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AISATSU2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AISATSU3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents JR_SETSUMEI1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AIR_SETSUMEI1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents OTHER_SETSUMEI1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents FOOTER_SETSUMEI1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents JR_SETSUMEI2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents JR_SETSUMEI3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents JR_SETSUMEI4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AIR_SETSUMEI2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AIR_SETSUMEI3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AIR_SETSUMEI4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AIR_SETSUMEI5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents AIR_SETSUMEI6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents OTHER_SETSUMEI2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents FOOTER_SETSUMEI2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents FOOTER_SETSUMEI3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents FOOTER_SETSUMEI4 As DataDynamics.ActiveReports.TextBox
End Class
