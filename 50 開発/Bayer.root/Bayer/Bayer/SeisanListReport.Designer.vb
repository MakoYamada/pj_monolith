<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SeisanListReport 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeisanListReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.LOGIN_USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.PrintDate = New DataDynamics.ActiveReports.TextBox
        Me.PageTotal = New DataDynamics.ActiveReports.TextBox
        Me.PageCount = New DataDynamics.ActiveReports.TextBox
        Me.LabelPage = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.JokenTO_DATE = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.JokenKOUENKAI_NO = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.JokenFROM_DATE = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.JokenKIKAKU_TANTO_ROMA = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.JokenBU = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.JokenKIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.JokenSEIKYU_NO_TOPTOUR = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.JokenSEISAN_YM = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.JokenSHOUNIN_KUBUN = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.SEIKYU_NO_TOPTOUR = New DataDynamics.ActiveReports.TextBox
        Me.SEISAN_YM = New DataDynamics.ActiveReports.TextBox
        Me.SHOUNIN_KUBUN = New DataDynamics.ActiveReports.TextBox
        Me.SEND_FLAG = New DataDynamics.ActiveReports.TextBox
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
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
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenTO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenFROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenBU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenSEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenSEISAN_YM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenSHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEISAN_YM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEND_FLAG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Shape1, Me.Label8, Me.LOGIN_USER_NAME, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.PrintDate, Me.PageTotal, Me.PageCount, Me.LabelPage, Me.Label5, Me.JokenTO_DATE, Me.Label19, Me.JokenKOUENKAI_NO, Me.Label22, Me.JokenFROM_DATE, Me.Label18, Me.JokenKIKAKU_TANTO_ROMA, Me.Label6, Me.JokenBU, Me.Label7, Me.JokenKIKAKU_TANTO_AREA, Me.Label9, Me.JokenSEIKYU_NO_TOPTOUR, Me.Label11, Me.JokenSEISAN_YM, Me.Label13, Me.JokenSHOUNIN_KUBUN, Me.Label15, Me.Label16, Me.Label17, Me.Label20, Me.Label21, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Line1, Me.Line2, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15})
        Me.PageHeader.Height = 2.066929!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Shape2.Height = 0.2362205!
        Me.Shape2.Left = 0.0!
        Me.Shape2.LineColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Shape2.LineWeight = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 1.819685!
        Me.Shape2.Width = 11.41732!
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.3149607!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6480315!
        Me.Shape1.Width = 11.41732!
        '
        'Label8
        '
        Me.Label8.Height = 0.2688977!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.823423!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "検索 精算データ一覧"
        Me.Label8.Top = 0.668504!
        Me.Label8.Width = 1.770473!
        '
        'LOGIN_USER_NAME
        '
        Me.LOGIN_USER_NAME.CanGrow = False
        Me.LOGIN_USER_NAME.DataField = "USER_NAME"
        Me.LOGIN_USER_NAME.Height = 0.1968504!
        Me.LOGIN_USER_NAME.Left = 10.01023!
        Me.LOGIN_USER_NAME.Name = "LOGIN_USER_NAME"
        Me.LOGIN_USER_NAME.Style = "font-family: ＭＳ ゴシック"
        Me.LOGIN_USER_NAME.Text = Nothing
        Me.LOGIN_USER_NAME.Top = 0.1771654!
        Me.LOGIN_USER_NAME.Width = 1.377953!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 9.259451!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label1.Text = "出力日"
        Me.Label1.Top = 0.00000002980232!
        Me.Label1.Width = 0.6251969!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 9.259451!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label2.Text = "出力担当"
        Me.Label2.Top = 0.1771654!
        Me.Label2.Width = 0.6251969!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 9.853582!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label3.Text = "："
        Me.Label3.Top = 0.1772966!
        Me.Label3.Width = 0.1669291!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 9.853582!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001311004!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1968504!
        Me.PrintDate.Left = 10.01027!
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Style = "font-family: ＭＳ ゴシック"
        Me.PrintDate.Text = "2013/12/12 00:00:00"
        Me.PrintDate.Top = 0.0001311004!
        Me.PrintDate.Width = 1.377953!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 7.411813!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.2822836!
        Me.PageTotal.Visible = False
        Me.PageTotal.Width = 0.2755905!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 7.036619!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.PageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.2822836!
        Me.PageCount.Visible = False
        Me.PageCount.Width = 0.2755905!
        '
        'LabelPage
        '
        Me.LabelPage.Height = 0.1968504!
        Me.LabelPage.HyperLink = Nothing
        Me.LabelPage.Left = 9.790158!
        Me.LabelPage.Name = "LabelPage"
        Me.LabelPage.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: right"
        Me.LabelPage.Text = "(999 / 999 ページ)"
        Me.LabelPage.Top = 0.4354331!
        Me.LabelPage.Width = 1.574803!
        '
        'Label5
        '
        Me.Label5.Height = 0.1771654!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: bold; text-align: left"
        Me.Label5.Text = "【抽出条件】"
        Me.Label5.Top = 0.9732284!
        Me.Label5.Width = 0.9055118!
        '
        'JokenTO_DATE
        '
        Me.JokenTO_DATE.Height = 0.1968504!
        Me.JokenTO_DATE.HyperLink = Nothing
        Me.JokenTO_DATE.Left = 1.314173!
        Me.JokenTO_DATE.Name = "JokenTO_DATE"
        Me.JokenTO_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenTO_DATE.Text = ""
        Me.JokenTO_DATE.Top = 0.9732284!
        Me.JokenTO_DATE.Visible = False
        Me.JokenTO_DATE.Width = 0.7874014!
        '
        'Label19
        '
        Me.Label19.Height = 0.1968504!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.1330713!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label19.Text = "会合番号："
        Me.Label19.Top = 1.170079!
        Me.Label19.Width = 1.181102!
        '
        'JokenKOUENKAI_NO
        '
        Me.JokenKOUENKAI_NO.Height = 0.1968504!
        Me.JokenKOUENKAI_NO.HyperLink = Nothing
        Me.JokenKOUENKAI_NO.Left = 1.314173!
        Me.JokenKOUENKAI_NO.Name = "JokenKOUENKAI_NO"
        Me.JokenKOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenKOUENKAI_NO.Text = ""
        Me.JokenKOUENKAI_NO.Top = 1.170079!
        Me.JokenKOUENKAI_NO.Width = 1.574803!
        '
        'Label22
        '
        Me.Label22.Height = 0.1968504!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 2.888977!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label22.Text = "実施日："
        Me.Label22.Top = 1.170079!
        Me.Label22.Width = 1.262992!
        '
        'JokenFROM_DATE
        '
        Me.JokenFROM_DATE.Height = 0.1968504!
        Me.JokenFROM_DATE.HyperLink = Nothing
        Me.JokenFROM_DATE.Left = 4.151969!
        Me.JokenFROM_DATE.Name = "JokenFROM_DATE"
        Me.JokenFROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenFROM_DATE.Text = ""
        Me.JokenFROM_DATE.Top = 1.170079!
        Me.JokenFROM_DATE.Width = 1.574803!
        '
        'Label18
        '
        Me.Label18.Height = 0.1968504!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.1330704!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label18.Text = "BYL企画担当者："
        Me.Label18.Top = 1.366929!
        Me.Label18.Width = 1.181102!
        '
        'JokenKIKAKU_TANTO_ROMA
        '
        Me.JokenKIKAKU_TANTO_ROMA.Height = 0.1968504!
        Me.JokenKIKAKU_TANTO_ROMA.HyperLink = Nothing
        Me.JokenKIKAKU_TANTO_ROMA.Left = 1.314173!
        Me.JokenKIKAKU_TANTO_ROMA.Name = "JokenKIKAKU_TANTO_ROMA"
        Me.JokenKIKAKU_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenKIKAKU_TANTO_ROMA.Text = ""
        Me.JokenKIKAKU_TANTO_ROMA.Top = 1.366929!
        Me.JokenKIKAKU_TANTO_ROMA.Width = 1.574803!
        '
        'Label6
        '
        Me.Label6.Height = 0.1968504!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.888977!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label6.Text = "BYL企画担当者BU："
        Me.Label6.Top = 1.366929!
        Me.Label6.Width = 1.262992!
        '
        'JokenBU
        '
        Me.JokenBU.Height = 0.1968504!
        Me.JokenBU.HyperLink = Nothing
        Me.JokenBU.Left = 4.151969!
        Me.JokenBU.Name = "JokenBU"
        Me.JokenBU.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenBU.Text = "ABC"
        Me.JokenBU.Top = 1.366929!
        Me.JokenBU.Width = 0.6645669!
        '
        'Label7
        '
        Me.Label7.Height = 0.1968504!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.816536!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label7.Text = "BYL企画担当者エリア："
        Me.Label7.Top = 1.366929!
        Me.Label7.Width = 1.694095!
        '
        'JokenKIKAKU_TANTO_AREA
        '
        Me.JokenKIKAKU_TANTO_AREA.Height = 0.1968504!
        Me.JokenKIKAKU_TANTO_AREA.HyperLink = Nothing
        Me.JokenKIKAKU_TANTO_AREA.Left = 6.510631!
        Me.JokenKIKAKU_TANTO_AREA.Name = "JokenKIKAKU_TANTO_AREA"
        Me.JokenKIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenKIKAKU_TANTO_AREA.Text = "中国・四国地方"
        Me.JokenKIKAKU_TANTO_AREA.Top = 1.366929!
        Me.JokenKIKAKU_TANTO_AREA.Width = 1.574803!
        '
        'Label9
        '
        Me.Label9.Height = 0.1968504!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.1330709!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label9.Text = "精算番号："
        Me.Label9.Top = 1.56378!
        Me.Label9.Width = 1.181102!
        '
        'JokenSEIKYU_NO_TOPTOUR
        '
        Me.JokenSEIKYU_NO_TOPTOUR.Height = 0.1968504!
        Me.JokenSEIKYU_NO_TOPTOUR.HyperLink = Nothing
        Me.JokenSEIKYU_NO_TOPTOUR.Left = 1.314173!
        Me.JokenSEIKYU_NO_TOPTOUR.Name = "JokenSEIKYU_NO_TOPTOUR"
        Me.JokenSEIKYU_NO_TOPTOUR.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenSEIKYU_NO_TOPTOUR.Text = ""
        Me.JokenSEIKYU_NO_TOPTOUR.Top = 1.56378!
        Me.JokenSEIKYU_NO_TOPTOUR.Width = 1.574803!
        '
        'Label11
        '
        Me.Label11.Height = 0.1968504!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.888977!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label11.Text = "TOP精算年月："
        Me.Label11.Top = 1.56378!
        Me.Label11.Width = 1.262992!
        '
        'JokenSEISAN_YM
        '
        Me.JokenSEISAN_YM.Height = 0.1968504!
        Me.JokenSEISAN_YM.HyperLink = Nothing
        Me.JokenSEISAN_YM.Left = 4.151969!
        Me.JokenSEISAN_YM.Name = "JokenSEISAN_YM"
        Me.JokenSEISAN_YM.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenSEISAN_YM.Text = ""
        Me.JokenSEISAN_YM.Top = 1.56378!
        Me.JokenSEISAN_YM.Width = 1.324803!
        '
        'Label13
        '
        Me.Label13.Height = 0.1968504!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 5.476772!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label13.Text = "承認区分："
        Me.Label13.Top = 1.56378!
        Me.Label13.Width = 1.033859!
        '
        'JokenSHOUNIN_KUBUN
        '
        Me.JokenSHOUNIN_KUBUN.Height = 0.1968504!
        Me.JokenSHOUNIN_KUBUN.HyperLink = Nothing
        Me.JokenSHOUNIN_KUBUN.Left = 6.510631!
        Me.JokenSHOUNIN_KUBUN.Name = "JokenSHOUNIN_KUBUN"
        Me.JokenSHOUNIN_KUBUN.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenSHOUNIN_KUBUN.Text = ""
        Me.JokenSHOUNIN_KUBUN.Top = 1.56378!
        Me.JokenSHOUNIN_KUBUN.Width = 1.574803!
        '
        'Label15
        '
        Me.Label15.Height = 0.1771654!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.0!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label15.Text = "BU"
        Me.Label15.Top = 1.87874!
        Me.Label15.Width = 0.6822835!
        '
        'Label16
        '
        Me.Label16.Height = 0.1771655!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.6822835!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label16.Text = "エリア"
        Me.Label16.Top = 1.87874!
        Me.Label16.Width = 0.8996065!
        '
        'Label17
        '
        Me.Label17.Height = 0.1771654!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 1.58189!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label17.Text = "営業所"
        Me.Label17.Top = 1.87874!
        Me.Label17.Width = 0.8401574!
        '
        'Label20
        '
        Me.Label20.Height = 0.1771654!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 2.422047!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label20.Text = "BYL企画担当者"
        Me.Label20.Top = 1.87874!
        Me.Label20.Width = 1.053937!
        '
        'Label21
        '
        Me.Label21.Height = 0.1771654!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 3.475985!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label21.Text = "実施日"
        Me.Label21.Top = 1.87874!
        Me.Label21.Width = 1.617717!
        '
        'Label23
        '
        Me.Label23.Height = 0.1771655!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 5.093701!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label23.Text = "会合番号"
        Me.Label23.Top = 1.87874!
        Me.Label23.Width = 1.065354!
        '
        'Label24
        '
        Me.Label24.Height = 0.1771655!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 6.159056!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label24.Text = "会合名"
        Me.Label24.Top = 1.87874!
        Me.Label24.Width = 2.190158!
        '
        'Label25
        '
        Me.Label25.Height = 0.1771655!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 8.349214!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label25.Text = "精算番号"
        Me.Label25.Top = 1.87874!
        Me.Label25.Width = 1.065354!
        '
        'Label26
        '
        Me.Label26.Height = 0.1771655!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 9.414568!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center"
        Me.Label26.Text = "TOP精算年月"
        Me.Label26.Top = 1.87874!
        Me.Label26.Width = 0.762598!
        '
        'Label27
        '
        Me.Label27.Height = 0.1771655!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 10.17717!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center"
        Me.Label27.Text = "承認区分"
        Me.Label27.Top = 1.87874!
        Me.Label27.Width = 0.5728321!
        '
        'Label28
        '
        Me.Label28.Height = 0.1771654!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 10.75!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center"
        Me.Label28.Text = "NOZOMI送信"
        Me.Label28.Top = 1.87874!
        Me.Label28.Width = 0.6673222!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.819685!
        Me.Line1.Width = 11.41732!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 11.41732!
        Me.Line1.Y1 = 1.819685!
        Me.Line1.Y2 = 1.819685!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.070866!
        Me.Line2.Width = 11.41733!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 11.41733!
        Me.Line2.Y1 = 2.070866!
        Me.Line2.Y2 = 2.070866!
        '
        'Line4
        '
        Me.Line4.Height = 0.2511811!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.819685!
        Me.Line4.Width = 0.0000002086163!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 0.0000002086163!
        Me.Line4.Y1 = 1.819685!
        Me.Line4.Y2 = 2.070866!
        '
        'Line5
        '
        Me.Line5.Height = 0.2511821!
        Me.Line5.Left = 0.6822835!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.819685!
        Me.Line5.Width = 0.0000001788139!
        Me.Line5.X1 = 0.6822835!
        Me.Line5.X2 = 0.6822837!
        Me.Line5.Y1 = 1.819685!
        Me.Line5.Y2 = 2.070867!
        '
        'Line6
        '
        Me.Line6.Height = 0.2511821!
        Me.Line6.Left = 1.58189!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.819685!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 1.58189!
        Me.Line6.X2 = 1.58189!
        Me.Line6.Y1 = 1.819685!
        Me.Line6.Y2 = 2.070867!
        '
        'Line7
        '
        Me.Line7.Height = 0.2511821!
        Me.Line7.Left = 2.422047!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.832284!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 2.422047!
        Me.Line7.X2 = 2.422047!
        Me.Line7.Y1 = 1.832284!
        Me.Line7.Y2 = 2.083466!
        '
        'Line8
        '
        Me.Line8.Height = 0.2511821!
        Me.Line8.Left = 3.475985!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.832284!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 3.475985!
        Me.Line8.X2 = 3.475985!
        Me.Line8.Y1 = 1.832284!
        Me.Line8.Y2 = 2.083466!
        '
        'Line9
        '
        Me.Line9.Height = 0.2511821!
        Me.Line9.Left = 5.093701!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.819685!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 5.093701!
        Me.Line9.X2 = 5.093701!
        Me.Line9.Y1 = 1.819685!
        Me.Line9.Y2 = 2.070867!
        '
        'Line10
        '
        Me.Line10.Height = 0.2511821!
        Me.Line10.Left = 6.159056!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 1.819685!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 6.159056!
        Me.Line10.X2 = 6.159056!
        Me.Line10.Y1 = 1.819685!
        Me.Line10.Y2 = 2.070867!
        '
        'Line11
        '
        Me.Line11.Height = 0.2511821!
        Me.Line11.Left = 8.349214!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 1.832284!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 8.349214!
        Me.Line11.X2 = 8.349214!
        Me.Line11.Y1 = 1.832284!
        Me.Line11.Y2 = 2.083466!
        '
        'Line12
        '
        Me.Line12.Height = 0.2511821!
        Me.Line12.Left = 9.414568!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 1.819685!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 9.414568!
        Me.Line12.X2 = 9.414568!
        Me.Line12.Y1 = 1.819685!
        Me.Line12.Y2 = 2.070867!
        '
        'Line13
        '
        Me.Line13.Height = 0.2511821!
        Me.Line13.Left = 10.17717!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 1.819685!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 10.17717!
        Me.Line13.X2 = 10.17717!
        Me.Line13.Y1 = 1.819685!
        Me.Line13.Y2 = 2.070867!
        '
        'Line14
        '
        Me.Line14.Height = 0.2511821!
        Me.Line14.Left = 10.75!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 1.832284!
        Me.Line14.Width = 0.0!
        Me.Line14.X1 = 10.75!
        Me.Line14.X2 = 10.75!
        Me.Line14.Y1 = 1.832284!
        Me.Line14.Y2 = 2.083466!
        '
        'Line15
        '
        Me.Line15.Height = 0.2511821!
        Me.Line15.Left = 11.41732!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 1.819685!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 11.41732!
        Me.Line15.X2 = 11.41732!
        Me.Line15.Y1 = 1.819685!
        Me.Line15.Y2 = 2.070867!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.BU, Me.KIKAKU_TANTO_AREA, Me.KIKAKU_TANTO_EIGYOSHO, Me.KIKAKU_TANTO_NAME, Me.KOUENKAI_NAME, Me.FROM_DATE, Me.KOUENKAI_NO, Me.SEIKYU_NO_TOPTOUR, Me.SEISAN_YM, Me.SHOUNIN_KUBUN, Me.SEND_FLAG, Me.TO_DATE, Me.Line3, Me.Line17, Me.Line16, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27})
        Me.Detail.Height = 0.2204724!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'BU
        '
        Me.BU.CanGrow = False
        Me.BU.DataField = "BU"
        Me.BU.Height = 0.2165354!
        Me.BU.Left = 0.0!
        Me.BU.Name = "BU"
        Me.BU.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.BU.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.BU.Text = "ABC"
        Me.BU.Top = 0.0!
        Me.BU.Width = 0.6822835!
        '
        'KIKAKU_TANTO_AREA
        '
        Me.KIKAKU_TANTO_AREA.CanGrow = False
        Me.KIKAKU_TANTO_AREA.DataField = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Height = 0.2165354!
        Me.KIKAKU_TANTO_AREA.Left = 0.6822835!
        Me.KIKAKU_TANTO_AREA.Name = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_AREA.Text = "中国・四国"
        Me.KIKAKU_TANTO_AREA.Top = 0.0!
        Me.KIKAKU_TANTO_AREA.Width = 0.8996065!
        '
        'KIKAKU_TANTO_EIGYOSHO
        '
        Me.KIKAKU_TANTO_EIGYOSHO.CanGrow = False
        Me.KIKAKU_TANTO_EIGYOSHO.DataField = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Height = 0.2165354!
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 1.58189!
        Me.KIKAKU_TANTO_EIGYOSHO.Name = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KIKAKU_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_EIGYOSHO.Text = "高松営業所"
        Me.KIKAKU_TANTO_EIGYOSHO.Top = 0.0!
        Me.KIKAKU_TANTO_EIGYOSHO.Width = 0.8401574!
        '
        'KIKAKU_TANTO_NAME
        '
        Me.KIKAKU_TANTO_NAME.CanGrow = False
        Me.KIKAKU_TANTO_NAME.DataField = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Height = 0.2165354!
        Me.KIKAKU_TANTO_NAME.Left = 2.422047!
        Me.KIKAKU_TANTO_NAME.Name = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KIKAKU_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_NAME.Text = "バイエル　太郎"
        Me.KIKAKU_TANTO_NAME.Top = 0.0!
        Me.KIKAKU_TANTO_NAME.Width = 1.053937!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.CanGrow = False
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2165354!
        Me.KOUENKAI_NAME.Left = 6.159056!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KOUENKAI_NAME.Text = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Top = 0.0!
        Me.KOUENKAI_NAME.Width = 2.190158!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.CanGrow = False
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.2165354!
        Me.FROM_DATE.Left = 3.475985!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.FROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.FROM_DATE.Text = "2013/12/12～2013/12/13"
        Me.FROM_DATE.Top = 0.0!
        Me.FROM_DATE.Width = 1.617717!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.2165354!
        Me.KOUENKAI_NO.Left = 5.093701!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KOUENKAI_NO.Text = "12345678901234"
        Me.KOUENKAI_NO.Top = 0.0!
        Me.KOUENKAI_NO.Width = 1.065354!
        '
        'SEIKYU_NO_TOPTOUR
        '
        Me.SEIKYU_NO_TOPTOUR.CanGrow = False
        Me.SEIKYU_NO_TOPTOUR.DataField = "SEIKYU_NO_TOPTOUR"
        Me.SEIKYU_NO_TOPTOUR.Height = 0.2165354!
        Me.SEIKYU_NO_TOPTOUR.Left = 8.349214!
        Me.SEIKYU_NO_TOPTOUR.Name = "SEIKYU_NO_TOPTOUR"
        Me.SEIKYU_NO_TOPTOUR.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.SEIKYU_NO_TOPTOUR.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.SEIKYU_NO_TOPTOUR.Text = "12345678901234"
        Me.SEIKYU_NO_TOPTOUR.Top = 0.0!
        Me.SEIKYU_NO_TOPTOUR.Width = 1.065354!
        '
        'SEISAN_YM
        '
        Me.SEISAN_YM.CanGrow = False
        Me.SEISAN_YM.DataField = "SEISAN_YM"
        Me.SEISAN_YM.Height = 0.2165354!
        Me.SEISAN_YM.Left = 9.414568!
        Me.SEISAN_YM.Name = "SEISAN_YM"
        Me.SEISAN_YM.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.SEISAN_YM.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.SEISAN_YM.Text = "2013年12月"
        Me.SEISAN_YM.Top = 0.0!
        Me.SEISAN_YM.Width = 0.7625971!
        '
        'SHOUNIN_KUBUN
        '
        Me.SHOUNIN_KUBUN.CanGrow = False
        Me.SHOUNIN_KUBUN.DataField = "SHOUNIN_KUBUN"
        Me.SHOUNIN_KUBUN.Height = 0.2165354!
        Me.SHOUNIN_KUBUN.Left = 10.17717!
        Me.SHOUNIN_KUBUN.Name = "SHOUNIN_KUBUN"
        Me.SHOUNIN_KUBUN.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.SHOUNIN_KUBUN.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.SHOUNIN_KUBUN.Text = Nothing
        Me.SHOUNIN_KUBUN.Top = 0.0!
        Me.SHOUNIN_KUBUN.Width = 0.572835!
        '
        'SEND_FLAG
        '
        Me.SEND_FLAG.CanGrow = False
        Me.SEND_FLAG.DataField = "SEND_FLAG"
        Me.SEND_FLAG.Height = 0.2165354!
        Me.SEND_FLAG.Left = 10.88032!
        Me.SEND_FLAG.Name = "SEND_FLAG"
        Me.SEND_FLAG.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.SEND_FLAG.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; white-space: nowrap; d" & _
            "do-char-set: 1"
        Me.SEND_FLAG.Text = "SEND_FLAG"
        Me.SEND_FLAG.Top = 0.0!
        Me.SEND_FLAG.Width = 0.4066935!
        '
        'TO_DATE
        '
        Me.TO_DATE.CanGrow = False
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.2165354!
        Me.TO_DATE.Left = 11.26102!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.TO_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.TO_DATE.Text = "TO"
        Me.TO_DATE.Top = 0.0!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 0.1271648!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.2165354!
        Me.Line3.Width = 11.41733!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 11.41733!
        Me.Line3.Y1 = 0.2165354!
        Me.Line3.Y2 = 0.2165354!
        '
        'Line17
        '
        Me.Line17.Height = 0.2165354!
        Me.Line17.Left = 0.0!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.0!
        Me.Line17.Width = 0.0000002980232!
        Me.Line17.X1 = 0.0!
        Me.Line17.X2 = 0.0000002980232!
        Me.Line17.Y1 = 0.0!
        Me.Line17.Y2 = 0.2165354!
        '
        'Line16
        '
        Me.Line16.Height = 0.2165354!
        Me.Line16.Left = 0.6822835!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.0!
        Me.Line16.Width = 0.0000002980232!
        Me.Line16.X1 = 0.6822835!
        Me.Line16.X2 = 0.6822838!
        Me.Line16.Y1 = 0.0!
        Me.Line16.Y2 = 0.2165354!
        '
        'Line18
        '
        Me.Line18.Height = 0.2165354!
        Me.Line18.Left = 1.58189!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 1.58189!
        Me.Line18.X2 = 1.58189!
        Me.Line18.Y1 = 0.0!
        Me.Line18.Y2 = 0.2165354!
        '
        'Line19
        '
        Me.Line19.Height = 0.2165354!
        Me.Line19.Left = 2.422047!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.0!
        Me.Line19.Width = 0.000001192093!
        Me.Line19.X1 = 2.422047!
        Me.Line19.X2 = 2.422048!
        Me.Line19.Y1 = 0.0!
        Me.Line19.Y2 = 0.2165354!
        '
        'Line20
        '
        Me.Line20.Height = 0.2165354!
        Me.Line20.Left = 3.475985!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.0!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 3.475985!
        Me.Line20.X2 = 3.475985!
        Me.Line20.Y1 = 0.0!
        Me.Line20.Y2 = 0.2165354!
        '
        'Line21
        '
        Me.Line21.Height = 0.2165354!
        Me.Line21.Left = 5.093701!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.0!
        Me.Line21.Width = 0.0000009536743!
        Me.Line21.X1 = 5.093701!
        Me.Line21.X2 = 5.093702!
        Me.Line21.Y1 = 0.0!
        Me.Line21.Y2 = 0.2165354!
        '
        'Line22
        '
        Me.Line22.Height = 0.2165354!
        Me.Line22.Left = 6.159056!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 0.0!
        Me.Line22.Width = 0.0!
        Me.Line22.X1 = 6.159056!
        Me.Line22.X2 = 6.159056!
        Me.Line22.Y1 = 0.0!
        Me.Line22.Y2 = 0.2165354!
        '
        'Line23
        '
        Me.Line23.Height = 0.2165354!
        Me.Line23.Left = 8.349214!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.0!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 8.349214!
        Me.Line23.X2 = 8.349214!
        Me.Line23.Y1 = 0.0!
        Me.Line23.Y2 = 0.2165354!
        '
        'Line24
        '
        Me.Line24.Height = 0.2165354!
        Me.Line24.Left = 9.414568!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.0!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 9.414568!
        Me.Line24.X2 = 9.414568!
        Me.Line24.Y1 = 0.0!
        Me.Line24.Y2 = 0.2165354!
        '
        'Line25
        '
        Me.Line25.Height = 0.2165354!
        Me.Line25.Left = 10.17717!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.0!
        Me.Line25.Width = 0.0!
        Me.Line25.X1 = 10.17717!
        Me.Line25.X2 = 10.17717!
        Me.Line25.Y1 = 0.0!
        Me.Line25.Y2 = 0.2165354!
        '
        'Line26
        '
        Me.Line26.Height = 0.2165354!
        Me.Line26.Left = 10.75!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.0!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 10.75!
        Me.Line26.X2 = 10.75!
        Me.Line26.Y1 = 0.0!
        Me.Line26.Y2 = 0.2165354!
        '
        'Line27
        '
        Me.Line27.Height = 0.2165354!
        Me.Line27.Left = 11.41732!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0.0!
        Me.Line27.Width = 0.0!
        Me.Line27.X1 = 11.41732!
        Me.Line27.X2 = 11.41732!
        Me.Line27.Y1 = 0.0!
        Me.Line27.Y2 = 0.2165354!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'SeisanListReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.43701!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenTO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenFROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenBU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenSEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenSEISAN_YM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenSHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEISAN_YM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEND_FLAG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents LOGIN_USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents PrintDate As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageTotal As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageCount As DataDynamics.ActiveReports.TextBox
    Private WithEvents LabelPage As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenTO_DATE As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKOUENKAI_NO As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenFROM_DATE As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKIKAKU_TANTO_ROMA As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenBU As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKIKAKU_TANTO_AREA As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenSEIKYU_NO_TOPTOUR As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenSEISAN_YM As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenSHOUNIN_KUBUN As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents SEIKYU_NO_TOPTOUR As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents SEISAN_YM As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents SHOUNIN_KUBUN As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents SEND_FLAG As DataDynamics.ActiveReports.TextBox
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
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
End Class
