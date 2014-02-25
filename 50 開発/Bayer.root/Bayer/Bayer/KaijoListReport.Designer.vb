<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class KaijoListReport 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KaijoListReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.LOGIN_USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.PrintDate = New DataDynamics.ActiveReports.TextBox
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.PageTotal = New DataDynamics.ActiveReports.TextBox
        Me.PageCount = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.LabelPage = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.JokenBU = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.JokenSEIHIN = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.JokenKIKAKU_TANTO_NAME = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.JokenKOUENKAI_NO = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.JokenFROM_DATE = New DataDynamics.ActiveReports.Label
        Me.JokenTO_DATE = New DataDynamics.ActiveReports.Label
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.JoKenTTANTO_ID = New DataDynamics.ActiveReports.Label
        Me.JokenKIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.Label
        Me.JokenTEHAI_TANTO_NAME = New DataDynamics.ActiveReports.Label
        Me.JokenKOUENKAI_NAME = New DataDynamics.ActiveReports.Label
        Me.Shape3 = New DataDynamics.ActiveReports.Shape
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_ID = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.SEND_FLAG = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.JokenKIKAKU_TANTO_ROMA = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.JokenTEHAI_TANTO_ROMA = New DataDynamics.ActiveReports.Label
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenBU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenSEIHIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenFROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenTO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoKenTTANTO_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenTEHAI_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEND_FLAG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenTEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.BackColor = System.Drawing.Color.Empty
        Me.PageHeader.CanGrow = False
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.LOGIN_USER_NAME, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.PrintDate, Me.Shape1, Me.PageTotal, Me.PageCount, Me.Label8, Me.LabelPage, Me.Label5, Me.Label6, Me.JokenBU, Me.Label7, Me.Label17, Me.JokenSEIHIN, Me.Label18, Me.Label20, Me.JokenKIKAKU_TANTO_NAME, Me.Label19, Me.JokenKOUENKAI_NO, Me.Label21, Me.Label22, Me.JokenFROM_DATE, Me.JokenTO_DATE, Me.Label23, Me.JoKenTTANTO_ID, Me.JokenKIKAKU_TANTO_AREA, Me.JokenTEHAI_TANTO_NAME, Me.JokenKOUENKAI_NAME, Me.Shape3, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Label32, Me.Label33, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Label34, Me.Line31, Me.Line32, Me.Line10, Me.Line2, Me.Label9, Me.JokenKIKAKU_TANTO_ROMA, Me.Label10, Me.JokenTEHAI_TANTO_ROMA, Me.Line11})
        Me.PageHeader.Height = 2.334646!
        Me.PageHeader.Name = "PageHeader"
        '
        'LOGIN_USER_NAME
        '
        Me.LOGIN_USER_NAME.CanGrow = False
        Me.LOGIN_USER_NAME.DataField = "USER_NAME"
        Me.LOGIN_USER_NAME.Height = 0.1968504!
        Me.LOGIN_USER_NAME.Left = 12.22835!
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
        Me.Label1.Left = 11.47757!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label1.Text = "出力日"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.6251969!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 11.47757!
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
        Me.Label3.Left = 12.07169!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label3.Text = "："
        Me.Label3.Top = 0.1772965!
        Me.Label3.Width = 0.1669291!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 12.07169!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001310706!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1968504!
        Me.PrintDate.Left = 12.22838!
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Style = "font-family: ＭＳ ゴシック"
        Me.PrintDate.Text = "2013/12/12 00:00:00"
        Me.PrintDate.Top = 0.0001310706!
        Me.PrintDate.Width = 1.377953!
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.3149607!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6412075!
        Me.Shape1.Width = 13.61024!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 10.89803!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.2661417!
        Me.PageTotal.Visible = False
        Me.PageTotal.Width = 0.2755905!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 10.52283!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.PageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.2661417!
        Me.PageCount.Visible = False
        Me.PageCount.Width = 0.2755905!
        '
        'Label8
        '
        Me.Label8.Height = 0.2688977!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 5.742815!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "検索 会場手配依頼一覧"
        Me.Label8.Top = 0.664239!
        Me.Label8.Width = 2.124607!
        '
        'LabelPage
        '
        Me.LabelPage.Height = 0.1968504!
        Me.LabelPage.HyperLink = Nothing
        Me.LabelPage.Left = 12.0185!
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
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: bold; text-align: left; verti" & _
            "cal-align: middle"
        Me.Label5.Text = "【抽出条件】"
        Me.Label5.Top = 0.988189!
        Me.Label5.Width = 0.9055118!
        '
        'Label6
        '
        Me.Label6.Height = 0.1968504!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.8661418!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label6.Text = "BU："
        Me.Label6.Top = 1.398425!
        Me.Label6.Width = 0.9866145!
        '
        'JokenBU
        '
        Me.JokenBU.Height = 0.1968504!
        Me.JokenBU.HyperLink = Nothing
        Me.JokenBU.Left = 1.852757!
        Me.JokenBU.Name = "JokenBU"
        Me.JokenBU.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenBU.Text = "ABC"
        Me.JokenBU.Top = 1.398426!
        Me.JokenBU.Width = 0.8692915!
        '
        'Label7
        '
        Me.Label7.Height = 0.1968504!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.723622!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label7.Text = "エリア："
        Me.Label7.Top = 1.398425!
        Me.Label7.Width = 0.5917323!
        '
        'Label17
        '
        Me.Label17.Height = 0.1968504!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 7.187796!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label17.Text = "製品名："
        Me.Label17.Top = 1.398425!
        Me.Label17.Width = 0.6299213!
        '
        'JokenSEIHIN
        '
        Me.JokenSEIHIN.Height = 0.1968504!
        Me.JokenSEIHIN.HyperLink = Nothing
        Me.JokenSEIHIN.Left = 7.807481!
        Me.JokenSEIHIN.Name = "JokenSEIHIN"
        Me.JokenSEIHIN.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenSEIHIN.Text = ""
        Me.JokenSEIHIN.Top = 1.398425!
        Me.JokenSEIHIN.Width = 5.020473!
        '
        'Label18
        '
        Me.Label18.Height = 0.1968504!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.3200788!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label18.Text = "BYL企画担当者(漢字)："
        Me.Label18.Top = 1.595276!
        Me.Label18.Width = 1.535433!
        '
        'Label20
        '
        Me.Label20.Height = 0.1968504!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.3200788!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label20.Text = "BYL手配担当者(漢字)："
        Me.Label20.Top = 1.792126!
        Me.Label20.Width = 1.535433!
        '
        'JokenKIKAKU_TANTO_NAME
        '
        Me.JokenKIKAKU_TANTO_NAME.Height = 0.1968504!
        Me.JokenKIKAKU_TANTO_NAME.HyperLink = Nothing
        Me.JokenKIKAKU_TANTO_NAME.Left = 1.855512!
        Me.JokenKIKAKU_TANTO_NAME.Name = "JokenKIKAKU_TANTO_NAME"
        Me.JokenKIKAKU_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenKIKAKU_TANTO_NAME.Text = ""
        Me.JokenKIKAKU_TANTO_NAME.Top = 1.595276!
        Me.JokenKIKAKU_TANTO_NAME.Width = 1.574803!
        '
        'Label19
        '
        Me.Label19.Height = 0.1968504!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 4.580709!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label19.Text = "会合番号："
        Me.Label19.Top = 1.201575!
        Me.Label19.Width = 0.7436998!
        '
        'JokenKOUENKAI_NO
        '
        Me.JokenKOUENKAI_NO.Height = 0.1968504!
        Me.JokenKOUENKAI_NO.HyperLink = Nothing
        Me.JokenKOUENKAI_NO.Left = 5.32441!
        Me.JokenKOUENKAI_NO.Name = "JokenKOUENKAI_NO"
        Me.JokenKOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenKOUENKAI_NO.Text = ""
        Me.JokenKOUENKAI_NO.Top = 1.201575!
        Me.JokenKOUENKAI_NO.Width = 1.574803!
        '
        'Label21
        '
        Me.Label21.Height = 0.1968504!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 7.118898!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label21.Text = "会合名："
        Me.Label21.Top = 1.201575!
        Me.Label21.Width = 0.6885834!
        '
        'Label22
        '
        Me.Label22.Height = 0.1968504!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.7236221!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label22.Text = "開催日："
        Me.Label22.Top = 1.201575!
        Me.Label22.Width = 1.129134!
        '
        'JokenFROM_DATE
        '
        Me.JokenFROM_DATE.Height = 0.1968504!
        Me.JokenFROM_DATE.HyperLink = Nothing
        Me.JokenFROM_DATE.Left = 1.852757!
        Me.JokenFROM_DATE.Name = "JokenFROM_DATE"
        Me.JokenFROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenFROM_DATE.Text = ""
        Me.JokenFROM_DATE.Top = 1.201576!
        Me.JokenFROM_DATE.Width = 1.574803!
        '
        'JokenTO_DATE
        '
        Me.JokenTO_DATE.Height = 0.1968504!
        Me.JokenTO_DATE.HyperLink = Nothing
        Me.JokenTO_DATE.Left = 1.262205!
        Me.JokenTO_DATE.Name = "JokenTO_DATE"
        Me.JokenTO_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenTO_DATE.Text = ""
        Me.JokenTO_DATE.Top = 0.9881893!
        Me.JokenTO_DATE.Visible = False
        Me.JokenTO_DATE.Width = 0.7874016!
        '
        'Label23
        '
        Me.Label23.Height = 0.1968504!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 6.980709!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label23.Text = "TOP担当者："
        Me.Label23.Top = 1.792126!
        Me.Label23.Width = 0.8267716!
        '
        'JoKenTTANTO_ID
        '
        Me.JoKenTTANTO_ID.Height = 0.1968504!
        Me.JoKenTTANTO_ID.HyperLink = Nothing
        Me.JoKenTTANTO_ID.Left = 7.807481!
        Me.JoKenTTANTO_ID.Name = "JoKenTTANTO_ID"
        Me.JoKenTTANTO_ID.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JoKenTTANTO_ID.Text = ""
        Me.JoKenTTANTO_ID.Top = 1.792126!
        Me.JoKenTTANTO_ID.Width = 2.147639!
        '
        'JokenKIKAKU_TANTO_AREA
        '
        Me.JokenKIKAKU_TANTO_AREA.Height = 0.1968504!
        Me.JokenKIKAKU_TANTO_AREA.HyperLink = Nothing
        Me.JokenKIKAKU_TANTO_AREA.Left = 5.324409!
        Me.JokenKIKAKU_TANTO_AREA.Name = "JokenKIKAKU_TANTO_AREA"
        Me.JokenKIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenKIKAKU_TANTO_AREA.Text = "中国・四国地方"
        Me.JokenKIKAKU_TANTO_AREA.Top = 1.398425!
        Me.JokenKIKAKU_TANTO_AREA.Width = 1.574803!
        '
        'JokenTEHAI_TANTO_NAME
        '
        Me.JokenTEHAI_TANTO_NAME.Height = 0.1968504!
        Me.JokenTEHAI_TANTO_NAME.HyperLink = Nothing
        Me.JokenTEHAI_TANTO_NAME.Left = 1.852757!
        Me.JokenTEHAI_TANTO_NAME.Name = "JokenTEHAI_TANTO_NAME"
        Me.JokenTEHAI_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenTEHAI_TANTO_NAME.Text = ""
        Me.JokenTEHAI_TANTO_NAME.Top = 1.792127!
        Me.JokenTEHAI_TANTO_NAME.Width = 1.574803!
        '
        'JokenKOUENKAI_NAME
        '
        Me.JokenKOUENKAI_NAME.Height = 0.1968504!
        Me.JokenKOUENKAI_NAME.HyperLink = Nothing
        Me.JokenKOUENKAI_NAME.Left = 7.807483!
        Me.JokenKOUENKAI_NAME.Name = "JokenKOUENKAI_NAME"
        Me.JokenKOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenKOUENKAI_NAME.Text = ""
        Me.JokenKOUENKAI_NAME.Top = 1.201575!
        Me.JokenKOUENKAI_NAME.Width = 5.020471!
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Shape3.Height = 0.2330708!
        Me.Shape3.Left = 0.0!
        Me.Shape3.LineColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Shape3.LineWeight = 0.0!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 2.099213!
        Me.Shape3.Width = 13.6063!
        '
        'Label24
        '
        Me.Label24.Height = 0.1771654!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.02539369!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label24.Text = "BU"
        Me.Label24.Top = 2.118898!
        Me.Label24.Width = 0.2444882!
        '
        'Label25
        '
        Me.Label25.Height = 0.1771655!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.3887797!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label25.Text = "エリア"
        Me.Label25.Top = 2.118897!
        Me.Label25.Width = 0.5464567!
        '
        'Label26
        '
        Me.Label26.Height = 0.1771655!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 1.212992!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label26.Text = "営業所"
        Me.Label26.Top = 2.118898!
        Me.Label26.Width = 0.7354338!
        '
        'Label27
        '
        Me.Label27.Height = 0.1771654!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 3.832481!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label27.Text = "開催日"
        Me.Label27.Top = 2.118898!
        Me.Label27.Width = 1.212992!
        '
        'Label28
        '
        Me.Label28.Height = 0.1771655!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 7.115748!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label28.Text = "会合名"
        Me.Label28.Top = 2.118897!
        Me.Label28.Width = 1.376378!
        '
        'Label29
        '
        Me.Label29.Height = 0.1771655!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 10.56575!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label29.Text = "Timestamp"
        Me.Label29.Top = 2.118898!
        Me.Label29.Width = 1.005511!
        '
        'Label30
        '
        Me.Label30.Height = 0.1771654!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 11.78976!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label30.Text = "NOZOMI送信"
        Me.Label30.Top = 2.122047!
        Me.Label30.Width = 0.7480315!
        '
        'Label31
        '
        Me.Label31.Height = 0.1771654!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 12.68228!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label31.Text = "TOP担当者"
        Me.Label31.Top = 2.118898!
        Me.Label31.Width = 0.7633824!
        '
        'Line22
        '
        Me.Line22.Height = 0.2362213!
        Me.Line22.Left = 0.2952756!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 2.099213!
        Me.Line22.Width = 0.0000002086163!
        Me.Line22.X1 = 0.2952756!
        Me.Line22.X2 = 0.2952758!
        Me.Line22.Y1 = 2.099213!
        Me.Line22.Y2 = 2.335434!
        '
        'Line23
        '
        Me.Line23.Height = 0.2362213!
        Me.Line23.Left = 1.02874!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 2.099213!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 1.02874!
        Me.Line23.X2 = 1.02874!
        Me.Line23.Y1 = 2.099213!
        Me.Line23.Y2 = 2.335434!
        '
        'Line24
        '
        Me.Line24.Height = 0.2358284!
        Me.Line24.Left = 11.76929!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 2.099213!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 11.76929!
        Me.Line24.X2 = 11.76929!
        Me.Line24.Y1 = 2.099213!
        Me.Line24.Y2 = 2.335041!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.0!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 2.331496!
        Me.Line25.Width = 13.61024!
        Me.Line25.X1 = 0.0!
        Me.Line25.X2 = 13.61024!
        Me.Line25.Y1 = 2.331496!
        Me.Line25.Y2 = 2.331496!
        '
        'Label32
        '
        Me.Label32.Height = 0.1771655!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 2.346063!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label32.Text = "企画担当者"
        Me.Label32.Top = 2.118897!
        Me.Label32.Width = 1.078346!
        '
        'Label33
        '
        Me.Label33.Height = 0.1771655!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 5.375!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label33.Text = "会合番号"
        Me.Label33.Top = 2.118898!
        Me.Label33.Width = 0.7814965!
        '
        'Line26
        '
        Me.Line26.Height = 0.2362213!
        Me.Line26.Left = 12.51732!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 2.099213!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 12.51732!
        Me.Line26.X2 = 12.51732!
        Me.Line26.Y1 = 2.099213!
        Me.Line26.Y2 = 2.335434!
        '
        'Line27
        '
        Me.Line27.Height = 0.2362213!
        Me.Line27.Left = 6.291339!
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 2.099213!
        Me.Line27.Width = 0.0!
        Me.Line27.X1 = 6.291339!
        Me.Line27.X2 = 6.291339!
        Me.Line27.Y1 = 2.099213!
        Me.Line27.Y2 = 2.335434!
        '
        'Line28
        '
        Me.Line28.Height = 0.2362213!
        Me.Line28.Left = 5.240158!
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 2.099213!
        Me.Line28.Width = 0.0!
        Me.Line28.X1 = 5.240158!
        Me.Line28.X2 = 5.240158!
        Me.Line28.Y1 = 2.099213!
        Me.Line28.Y2 = 2.335434!
        '
        'Line29
        '
        Me.Line29.Height = 0.2362213!
        Me.Line29.Left = 3.637795!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 2.099213!
        Me.Line29.Width = 0.0!
        Me.Line29.X1 = 3.637795!
        Me.Line29.X2 = 3.637795!
        Me.Line29.Y1 = 2.099213!
        Me.Line29.Y2 = 2.335434!
        '
        'Line30
        '
        Me.Line30.Height = 0.2362213!
        Me.Line30.Left = 2.132677!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 2.099213!
        Me.Line30.Width = 0.0!
        Me.Line30.X1 = 2.132677!
        Me.Line30.X2 = 2.132677!
        Me.Line30.Y1 = 2.099213!
        Me.Line30.Y2 = 2.335434!
        '
        'Label34
        '
        Me.Label34.Height = 0.1771655!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 9.357481!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center; vertical-align: middle" & _
            "; ddo-font-vertical: none"
        Me.Label34.Text = "会合手配番号"
        Me.Label34.Top = 2.118898!
        Me.Label34.Width = 0.9689016!
        '
        'Line31
        '
        Me.Line31.Height = 0.2358284!
        Me.Line31.Left = 10.36772!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 2.099607!
        Me.Line31.Width = 0.0!
        Me.Line31.X1 = 10.36772!
        Me.Line31.X2 = 10.36772!
        Me.Line31.Y1 = 2.099607!
        Me.Line31.Y2 = 2.335435!
        '
        'Line32
        '
        Me.Line32.Height = 0.2362213!
        Me.Line32.Left = 9.316536!
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 2.099213!
        Me.Line32.Width = 0.0!
        Me.Line32.X1 = 9.316536!
        Me.Line32.X2 = 9.316536!
        Me.Line32.Y1 = 2.099213!
        Me.Line32.Y2 = 2.335434!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 2.099607!
        Me.Line10.Width = 13.61024!
        Me.Line10.X1 = 0.0!
        Me.Line10.X2 = 13.61024!
        Me.Line10.Y1 = 2.099607!
        Me.Line10.Y2 = 2.099607!
        '
        'Line11
        '
        Me.Line11.Height = 0.2362211!
        Me.Line11.Left = 0.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 2.110236!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 0.0!
        Me.Line11.X2 = 0.0!
        Me.Line11.Y1 = 2.110236!
        Me.Line11.Y2 = 2.346457!
        '
        'Line2
        '
        Me.Line2.Height = 0.2362208!
        Me.Line2.Left = 13.61024!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.099607!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 13.61024!
        Me.Line2.X2 = 13.61024!
        Me.Line2.Y1 = 2.099607!
        Me.Line2.Y2 = 2.335827!
        '
        'Detail
        '
        Me.Detail.CanGrow = False
        Me.Detail.CanShrink = True
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.KIKAKU_TANTO_EIGYOSHO, Me.KIKAKU_TANTO_NAME, Me.FROM_DATE, Me.TEHAI_ID, Me.KOUENKAI_NO, Me.KOUENKAI_NAME, Me.Line5, Me.Line4, Me.USER_NAME, Me.SEND_FLAG, Me.TIME_STAMP_BYL, Me.KIKAKU_TANTO_AREA, Me.BU, Me.Line1, Me.Line7, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.TO_DATE, Me.Line21, Me.Line3})
        Me.Detail.Height = 0.234252!
        Me.Detail.Name = "Detail"
        '
        'KIKAKU_TANTO_EIGYOSHO
        '
        Me.KIKAKU_TANTO_EIGYOSHO.CanGrow = False
        Me.KIKAKU_TANTO_EIGYOSHO.DataField = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Height = 0.2165354!
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 1.030315!
        Me.KIKAKU_TANTO_EIGYOSHO.Name = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.KIKAKU_TANTO_EIGYOSHO.Text = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Top = 0.0!
        Me.KIKAKU_TANTO_EIGYOSHO.Width = 1.102362!
        '
        'KIKAKU_TANTO_NAME
        '
        Me.KIKAKU_TANTO_NAME.CanGrow = False
        Me.KIKAKU_TANTO_NAME.DataField = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Height = 0.2165354!
        Me.KIKAKU_TANTO_NAME.Left = 2.132677!
        Me.KIKAKU_TANTO_NAME.Name = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1; ddo-font-vertical: none"
        Me.KIKAKU_TANTO_NAME.Text = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Top = 0.0!
        Me.KIKAKU_TANTO_NAME.Width = 1.505119!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.CanGrow = False
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.2165354!
        Me.FROM_DATE.Left = 3.637795!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.FROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1; ddo-font-vertical: none"
        Me.FROM_DATE.Text = "FROM_DATE"
        Me.FROM_DATE.Top = 0.0!
        Me.FROM_DATE.Width = 1.602362!
        '
        'TEHAI_ID
        '
        Me.TEHAI_ID.CanGrow = False
        Me.TEHAI_ID.DataField = "TEHAI_ID"
        Me.TEHAI_ID.Height = 0.2165354!
        Me.TEHAI_ID.Left = 9.316536!
        Me.TEHAI_ID.Name = "TEHAI_ID"
        Me.TEHAI_ID.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_ID.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.TEHAI_ID.Text = "TEHAI_ID"
        Me.TEHAI_ID.Top = 0.0!
        Me.TEHAI_ID.Width = 1.051181!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.2165354!
        Me.KOUENKAI_NO.Left = 5.240158!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1; ddo-font-vertical: none"
        Me.KOUENKAI_NO.Text = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Top = 0.0!
        Me.KOUENKAI_NO.Width = 1.051181!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.CanGrow = False
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2165354!
        Me.KOUENKAI_NAME.Left = 6.291339!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.KOUENKAI_NAME.Text = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Top = 0.0!
        Me.KOUENKAI_NAME.Width = 3.025197!
        '
        'Line5
        '
        Me.Line5.Height = 0.2322835!
        Me.Line5.Left = 9.316536!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.0!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 9.316536!
        Me.Line5.X2 = 9.316536!
        Me.Line5.Y1 = 0.0!
        Me.Line5.Y2 = 0.2322835!
        '
        'Line4
        '
        Me.Line4.Height = 0.2322837!
        Me.Line4.Left = 6.291339!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.0!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 6.291339!
        Me.Line4.X2 = 6.291339!
        Me.Line4.Y1 = 0.0!
        Me.Line4.Y2 = 0.2322837!
        '
        'USER_NAME
        '
        Me.USER_NAME.CanGrow = False
        Me.USER_NAME.DataField = "USER_NAME"
        Me.USER_NAME.Height = 0.2165354!
        Me.USER_NAME.Left = 12.51732!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.USER_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.USER_NAME.Text = "USER_NAME"
        Me.USER_NAME.Top = 0.0!
        Me.USER_NAME.Width = 1.082677!
        '
        'SEND_FLAG
        '
        Me.SEND_FLAG.CanGrow = False
        Me.SEND_FLAG.DataField = "SEND_FLAG"
        Me.SEND_FLAG.Height = 0.2165354!
        Me.SEND_FLAG.Left = 11.76929!
        Me.SEND_FLAG.Name = "SEND_FLAG"
        Me.SEND_FLAG.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SEND_FLAG.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.SEND_FLAG.Text = "SEND_FLAG"
        Me.SEND_FLAG.Top = 0.0!
        Me.SEND_FLAG.Width = 0.7480315!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.CanGrow = False
        Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Height = 0.2165354!
        Me.TIME_STAMP_BYL.Left = 10.36772!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TIME_STAMP_BYL.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.TIME_STAMP_BYL.Text = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Top = 0.0!
        Me.TIME_STAMP_BYL.Width = 1.401575!
        '
        'KIKAKU_TANTO_AREA
        '
        Me.KIKAKU_TANTO_AREA.CanGrow = False
        Me.KIKAKU_TANTO_AREA.DataField = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Height = 0.2165354!
        Me.KIKAKU_TANTO_AREA.Left = 0.2952756!
        Me.KIKAKU_TANTO_AREA.Name = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.KIKAKU_TANTO_AREA.Text = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Top = 0.0!
        Me.KIKAKU_TANTO_AREA.Width = 0.7334646!
        '
        'BU
        '
        Me.BU.CanGrow = False
        Me.BU.DataField = "BU"
        Me.BU.Height = 0.2165354!
        Me.BU.Left = 0.0!
        Me.BU.Name = "BU"
        Me.BU.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.BU.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: middle; white-space: nowra" & _
            "p; ddo-char-set: 1"
        Me.BU.Text = "BU"
        Me.BU.Top = 0.0!
        Me.BU.Width = 0.2952756!
        '
        'Line1
        '
        Me.Line1.Height = 0.2322835!
        Me.Line1.Left = 0.2952756!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.00000008940697!
        Me.Line1.X1 = 0.2952756!
        Me.Line1.X2 = 0.2952757!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.2322835!
        '
        'Line7
        '
        Me.Line7.Height = 0.2322835!
        Me.Line7.Left = 1.030315!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 1.030315!
        Me.Line7.X2 = 1.030315!
        Me.Line7.Y1 = 0.0!
        Me.Line7.Y2 = 0.2322835!
        '
        'Line13
        '
        Me.Line13.Height = 0.2322835!
        Me.Line13.Left = 2.132677!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 2.132677!
        Me.Line13.X2 = 2.132677!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.2322835!
        '
        'Line14
        '
        Me.Line14.Height = 0.2322835!
        Me.Line14.Left = 3.637795!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.0!
        Me.Line14.Width = 0.0!
        Me.Line14.X1 = 3.637795!
        Me.Line14.X2 = 3.637795!
        Me.Line14.Y1 = 0.0!
        Me.Line14.Y2 = 0.2322835!
        '
        'Line15
        '
        Me.Line15.Height = 0.2322835!
        Me.Line15.Left = 10.36772!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.0!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 10.36772!
        Me.Line15.X2 = 10.36772!
        Me.Line15.Y1 = 0.0!
        Me.Line15.Y2 = 0.2322835!
        '
        'Line16
        '
        Me.Line16.Height = 0.2322835!
        Me.Line16.Left = 11.76929!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.0!
        Me.Line16.Width = 0.0!
        Me.Line16.X1 = 11.76929!
        Me.Line16.X2 = 11.76929!
        Me.Line16.Y1 = 0.0!
        Me.Line16.Y2 = 0.2322835!
        '
        'Line17
        '
        Me.Line17.Height = 0.2322835!
        Me.Line17.Left = 12.51732!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.0!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 12.51732!
        Me.Line17.X2 = 12.51732!
        Me.Line17.Y1 = 0.0!
        Me.Line17.Y2 = 0.2322835!
        '
        'Line18
        '
        Me.Line18.Height = 0.2322835!
        Me.Line18.Left = 13.61024!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 13.61024!
        Me.Line18.X2 = 13.61024!
        Me.Line18.Y1 = 0.0!
        Me.Line18.Y2 = 0.2322835!
        '
        'Line19
        '
        Me.Line19.Height = 0.2322835!
        Me.Line19.Left = 0.0!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.0!
        Me.Line19.Width = 0.0000002086163!
        Me.Line19.X1 = 0.0!
        Me.Line19.X2 = 0.0000002086163!
        Me.Line19.Y1 = 0.0!
        Me.Line19.Y2 = 0.2322835!
        '
        'TO_DATE
        '
        Me.TO_DATE.CanGrow = False
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.1692913!
        Me.TO_DATE.Left = 8.155119!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.TO_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.TO_DATE.Text = "TO_DATE"
        Me.TO_DATE.Top = 0.464567!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 1.181102!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.0!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.2322835!
        Me.Line21.Width = 13.61024!
        Me.Line21.X1 = 0.0!
        Me.Line21.X2 = 13.61024!
        Me.Line21.Y1 = 0.2322835!
        Me.Line21.Y2 = 0.2322835!
        '
        'Line3
        '
        Me.Line3.Height = 0.2322836!
        Me.Line3.Left = 5.240158!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 5.240158!
        Me.Line3.X2 = 5.240158!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.2322836!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label9
        '
        Me.Label9.Height = 0.1968504!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 3.509449!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label9.Text = "BYL企画担当者(ローマ字)："
        Me.Label9.Top = 1.595275!
        Me.Label9.Width = 1.814961!
        '
        'JokenKIKAKU_TANTO_ROMA
        '
        Me.JokenKIKAKU_TANTO_ROMA.Height = 0.1968504!
        Me.JokenKIKAKU_TANTO_ROMA.HyperLink = Nothing
        Me.JokenKIKAKU_TANTO_ROMA.Left = 5.324409!
        Me.JokenKIKAKU_TANTO_ROMA.Name = "JokenKIKAKU_TANTO_ROMA"
        Me.JokenKIKAKU_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenKIKAKU_TANTO_ROMA.Text = ""
        Me.JokenKIKAKU_TANTO_ROMA.Top = 1.595276!
        Me.JokenKIKAKU_TANTO_ROMA.Width = 1.574803!
        '
        'Label10
        '
        Me.Label10.Height = 0.1968504!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.509449!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right; ve" & _
            "rtical-align: middle"
        Me.Label10.Text = "BYL手配担当者(ローマ字)："
        Me.Label10.Top = 1.792126!
        Me.Label10.Width = 1.814961!
        '
        'JokenTEHAI_TANTO_ROMA
        '
        Me.JokenTEHAI_TANTO_ROMA.Height = 0.1968504!
        Me.JokenTEHAI_TANTO_ROMA.HyperLink = Nothing
        Me.JokenTEHAI_TANTO_ROMA.Left = 5.324409!
        Me.JokenTEHAI_TANTO_ROMA.Name = "JokenTEHAI_TANTO_ROMA"
        Me.JokenTEHAI_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left; ver" & _
            "tical-align: middle"
        Me.JokenTEHAI_TANTO_ROMA.Text = ""
        Me.JokenTEHAI_TANTO_ROMA.Top = 1.792126!
        Me.JokenTEHAI_TANTO_ROMA.Width = 1.574803!
        '
        'KaijoListReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 13.62205!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenBU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenSEIHIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenFROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenTO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoKenTTANTO_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenTEHAI_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEND_FLAG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenTEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents LOGIN_USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents PrintDate As DataDynamics.ActiveReports.TextBox
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents PageTotal As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageCount As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SEND_FLAG As DataDynamics.ActiveReports.TextBox
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents LabelPage As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenBU As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKIKAKU_TANTO_AREA As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenSEIHIN As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenTEHAI_TANTO_NAME As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKIKAKU_TANTO_NAME As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKOUENKAI_NO As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKOUENKAI_NAME As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenFROM_DATE As DataDynamics.ActiveReports.Label
    Private WithEvents JokenTO_DATE As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents JoKenTTANTO_ID As DataDynamics.ActiveReports.Label
    Private WithEvents Shape3 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents KIKAKU_TANTO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKIKAKU_TANTO_ROMA As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenTEHAI_TANTO_ROMA As DataDynamics.ActiveReports.Label
End Class
