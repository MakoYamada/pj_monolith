<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NewKaijoListReport 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewKaijoListReport))
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
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.LabelPage = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.JokenBU = New DataDynamics.ActiveReports.Label
        Me.JokenKIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.JokenREQ_STATUS_TEHAI = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenBU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenKIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JokenREQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.CanGrow = False
        Me.PageHeader.CanShrink = True
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.LOGIN_USER_NAME, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.PrintDate, Me.Shape1, Me.PageTotal, Me.PageCount, Me.Label8, Me.Shape2, Me.Label12, Me.Label9, Me.Label10, Me.Label11, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line20, Me.LabelPage, Me.Label5, Me.Label6, Me.JokenBU, Me.JokenKIKAKU_TANTO_AREA, Me.Label7, Me.Label17, Me.JokenREQ_STATUS_TEHAI})
        Me.PageHeader.Height = 1.692126!
        Me.PageHeader.Name = "PageHeader"
        '
        'LOGIN_USER_NAME
        '
        Me.LOGIN_USER_NAME.CanGrow = False
        Me.LOGIN_USER_NAME.DataField = "USER_NAME"
        Me.LOGIN_USER_NAME.Height = 0.1968504!
        Me.LOGIN_USER_NAME.Left = 9.64567!
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
        Me.Label1.Left = 8.894884!
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
        Me.Label2.Left = 8.894884!
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
        Me.Label3.Left = 9.489011!
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
        Me.Label4.Left = 9.489011!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001310706!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1968504!
        Me.PrintDate.Left = 9.645703!
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
        Me.Shape1.Width = 11.02362!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 7.388583!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.2822835!
        Me.PageTotal.Visible = False
        Me.PageTotal.Width = 0.2755905!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 7.013386!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.PageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.2822835!
        Me.PageCount.Visible = False
        Me.PageCount.Width = 0.2755905!
        '
        'Label8
        '
        Me.Label8.Height = 0.2688977!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.232874!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "新着 会場手配依頼一覧"
        Me.Label8.Top = 0.664239!
        Me.Label8.Width = 1.770473!
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Shape2.Height = 0.2340157!
        Me.Shape2.Left = 0.0!
        Me.Shape2.LineColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Shape2.LineWeight = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 1.454331!
        Me.Shape2.Width = 11.02362!
        '
        'Label12
        '
        Me.Label12.Height = 0.1771654!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label12.Text = "BU"
        Me.Label12.Top = 1.474016!
        Me.Label12.Width = 0.3937008!
        '
        'Label9
        '
        Me.Label9.Height = 0.1771654!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.3937008!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label9.Text = "エリア"
        Me.Label9.Top = 1.474016!
        Me.Label9.Width = 0.9055118!
        '
        'Label10
        '
        Me.Label10.Height = 0.1771654!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 1.299213!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label10.Text = "営業所"
        Me.Label10.Top = 1.474016!
        Me.Label10.Width = 1.496063!
        '
        'Label11
        '
        Me.Label11.Height = 0.1771654!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.795276!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label11.Text = "実施日"
        Me.Label11.Top = 1.474016!
        Me.Label11.Width = 1.574803!
        '
        'Label13
        '
        Me.Label13.Height = 0.1771654!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.370079!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label13.Text = "講演会名"
        Me.Label13.Top = 1.474016!
        Me.Label13.Width = 3.119291!
        '
        'Label14
        '
        Me.Label14.Height = 0.1771654!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 7.489371!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label14.Text = "Timestamp"
        Me.Label14.Top = 1.474016!
        Me.Label14.Width = 1.358268!
        '
        'Label15
        '
        Me.Label15.Height = 0.1771654!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 8.850788!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label15.Text = "区分"
        Me.Label15.Top = 1.474016!
        Me.Label15.Width = 0.9133858!
        '
        'Label16
        '
        Me.Label16.Height = 0.1771654!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 9.764174!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: center"
        Me.Label16.Text = "TOP担当者"
        Me.Label16.Top = 1.474016!
        Me.Label16.Width = 1.233071!
        '
        'Line2
        '
        Me.Line2.Height = 0.236221!
        Me.Line2.Left = 0.3937008!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.454331!
        Me.Line2.Width = 0.0000001788139!
        Me.Line2.X1 = 0.3937008!
        Me.Line2.X2 = 0.393701!
        Me.Line2.Y1 = 1.454331!
        Me.Line2.Y2 = 1.690552!
        '
        'Line3
        '
        Me.Line3.Height = 0.236221!
        Me.Line3.Left = 1.299213!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.454331!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 1.299213!
        Me.Line3.X2 = 1.299213!
        Me.Line3.Y1 = 1.454331!
        Me.Line3.Y2 = 1.690552!
        '
        'Line4
        '
        Me.Line4.Height = 0.236221!
        Me.Line4.Left = 2.795276!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.454331!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 2.795276!
        Me.Line4.X2 = 2.795276!
        Me.Line4.Y1 = 1.454331!
        Me.Line4.Y2 = 1.690552!
        '
        'Line5
        '
        Me.Line5.Height = 0.236221!
        Me.Line5.Left = 4.370079!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.454331!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 4.370079!
        Me.Line5.X2 = 4.370079!
        Me.Line5.Y1 = 1.454331!
        Me.Line5.Y2 = 1.690552!
        '
        'Line6
        '
        Me.Line6.Height = 0.236221!
        Me.Line6.Left = 7.489371!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.454331!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 7.489371!
        Me.Line6.X2 = 7.489371!
        Me.Line6.Y1 = 1.454331!
        Me.Line6.Y2 = 1.690552!
        '
        'Line8
        '
        Me.Line8.Height = 0.236221!
        Me.Line8.Left = 8.850788!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.454331!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 8.850788!
        Me.Line8.X2 = 8.850788!
        Me.Line8.Y1 = 1.454331!
        Me.Line8.Y2 = 1.690552!
        '
        'Line9
        '
        Me.Line9.Height = 0.236221!
        Me.Line9.Left = 9.764174!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.454331!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 9.764174!
        Me.Line9.X2 = 9.764174!
        Me.Line9.Y1 = 1.454331!
        Me.Line9.Y2 = 1.690552!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 1.45433!
        Me.Line10.Width = 11.02362!
        Me.Line10.X1 = 0.0!
        Me.Line10.X2 = 11.02362!
        Me.Line10.Y1 = 1.45433!
        Me.Line10.Y2 = 1.45433!
        '
        'Line11
        '
        Me.Line11.Height = 0.236221!
        Me.Line11.Left = 0.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 1.454331!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 0.0!
        Me.Line11.X2 = 0.0!
        Me.Line11.Y1 = 1.454331!
        Me.Line11.Y2 = 1.690552!
        '
        'Line12
        '
        Me.Line12.Height = 0.236221!
        Me.Line12.Left = 11.02362!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 1.454331!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 11.02362!
        Me.Line12.X2 = 11.02362!
        Me.Line12.Y1 = 1.454331!
        Me.Line12.Y2 = 1.690552!
        '
        'Line20
        '
        Me.Line20.Height = 0.0!
        Me.Line20.Left = 0.0!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 1.690552!
        Me.Line20.Width = 11.02362!
        Me.Line20.X1 = 0.0!
        Me.Line20.X2 = 11.02362!
        Me.Line20.Y1 = 1.690552!
        Me.Line20.Y2 = 1.690552!
        '
        'LabelPage
        '
        Me.LabelPage.Height = 0.1968504!
        Me.LabelPage.HyperLink = Nothing
        Me.LabelPage.Left = 9.425591!
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
        Me.Label5.Top = 0.988189!
        Me.Label5.Width = 0.9055118!
        '
        'Label6
        '
        Me.Label6.Height = 0.1771654!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.2559055!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label6.Text = "BU："
        Me.Label6.Top = 1.201575!
        Me.Label6.Width = 0.3149606!
        '
        'JokenBU
        '
        Me.JokenBU.Height = 0.1771654!
        Me.JokenBU.HyperLink = Nothing
        Me.JokenBU.Left = 0.5708662!
        Me.JokenBU.Name = "JokenBU"
        Me.JokenBU.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenBU.Text = "ABC"
        Me.JokenBU.Top = 1.201575!
        Me.JokenBU.Width = 0.5082678!
        '
        'JokenKIKAKU_TANTO_AREA
        '
        Me.JokenKIKAKU_TANTO_AREA.Height = 0.1968504!
        Me.JokenKIKAKU_TANTO_AREA.HyperLink = Nothing
        Me.JokenKIKAKU_TANTO_AREA.Left = 1.913386!
        Me.JokenKIKAKU_TANTO_AREA.Name = "JokenKIKAKU_TANTO_AREA"
        Me.JokenKIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenKIKAKU_TANTO_AREA.Text = "中国・四国地方"
        Me.JokenKIKAKU_TANTO_AREA.Top = 1.201575!
        Me.JokenKIKAKU_TANTO_AREA.Width = 1.574803!
        '
        'Label7
        '
        Me.Label7.Height = 0.1968504!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.322835!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label7.Text = "エリア："
        Me.Label7.Top = 1.201575!
        Me.Label7.Width = 0.5905512!
        '
        'Label17
        '
        Me.Label17.Height = 0.1968504!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 3.796851!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: right"
        Me.Label17.Text = "区分："
        Me.Label17.Top = 1.201575!
        Me.Label17.Width = 0.5070863!
        '
        'JokenREQ_STATUS_TEHAI
        '
        Me.JokenREQ_STATUS_TEHAI.Height = 0.1968504!
        Me.JokenREQ_STATUS_TEHAI.HyperLink = Nothing
        Me.JokenREQ_STATUS_TEHAI.Left = 4.303937!
        Me.JokenREQ_STATUS_TEHAI.Name = "JokenREQ_STATUS_TEHAI"
        Me.JokenREQ_STATUS_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal; text-align: left"
        Me.JokenREQ_STATUS_TEHAI.Text = "新規手配依頼"
        Me.JokenREQ_STATUS_TEHAI.Top = 1.201575!
        Me.JokenREQ_STATUS_TEHAI.Width = 1.023622!
        '
        'Detail
        '
        Me.Detail.CanGrow = False
        Me.Detail.CanShrink = True
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1, Me.Line7, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.BU, Me.KIKAKU_TANTO_AREA, Me.KIKAKU_TANTO_EIGYOSHO, Me.FROM_DATE, Me.KOUENKAI_NAME, Me.TIME_STAMP_BYL, Me.REQ_STATUS_TEHAI, Me.USER_NAME, Me.Line19, Me.TO_DATE, Me.KOUENKAI_NO, Me.Line21})
        Me.Detail.Height = 0.234252!
        Me.Detail.Name = "Detail"
        '
        'Line1
        '
        Me.Line1.Height = 0.2322835!
        Me.Line1.Left = 0.3937008!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 0.0000001788139!
        Me.Line1.X1 = 0.3937008!
        Me.Line1.X2 = 0.393701!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.2322835!
        '
        'Line7
        '
        Me.Line7.Height = 0.2322835!
        Me.Line7.Left = 1.299213!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 1.299213!
        Me.Line7.X2 = 1.299213!
        Me.Line7.Y1 = 0.0!
        Me.Line7.Y2 = 0.2322835!
        '
        'Line13
        '
        Me.Line13.Height = 0.2322835!
        Me.Line13.Left = 2.795276!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 2.795276!
        Me.Line13.X2 = 2.795276!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.2322835!
        '
        'Line14
        '
        Me.Line14.Height = 0.2322835!
        Me.Line14.Left = 4.370079!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.0!
        Me.Line14.Width = 0.0!
        Me.Line14.X1 = 4.370079!
        Me.Line14.X2 = 4.370079!
        Me.Line14.Y1 = 0.0!
        Me.Line14.Y2 = 0.2322835!
        '
        'Line15
        '
        Me.Line15.Height = 0.2322835!
        Me.Line15.Left = 7.489368!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.0!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 7.489368!
        Me.Line15.X2 = 7.489368!
        Me.Line15.Y1 = 0.0!
        Me.Line15.Y2 = 0.2322835!
        '
        'Line16
        '
        Me.Line16.Height = 0.2322835!
        Me.Line16.Left = 8.850788!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.0!
        Me.Line16.Width = 0.0!
        Me.Line16.X1 = 8.850788!
        Me.Line16.X2 = 8.850788!
        Me.Line16.Y1 = 0.0!
        Me.Line16.Y2 = 0.2322835!
        '
        'Line17
        '
        Me.Line17.Height = 0.2322835!
        Me.Line17.Left = 9.764174!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.0!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 9.764174!
        Me.Line17.X2 = 9.764174!
        Me.Line17.Y1 = 0.0!
        Me.Line17.Y2 = 0.2322835!
        '
        'Line18
        '
        Me.Line18.Height = 0.2322835!
        Me.Line18.Left = 11.02362!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 11.02362!
        Me.Line18.X2 = 11.02362!
        Me.Line18.Y1 = 0.0!
        Me.Line18.Y2 = 0.2322835!
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
        Me.BU.Text = "BU"
        Me.BU.Top = 0.01181102!
        Me.BU.Width = 0.3937008!
        '
        'KIKAKU_TANTO_AREA
        '
        Me.KIKAKU_TANTO_AREA.CanGrow = False
        Me.KIKAKU_TANTO_AREA.DataField = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Height = 0.2165354!
        Me.KIKAKU_TANTO_AREA.Left = 0.3937008!
        Me.KIKAKU_TANTO_AREA.Name = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_AREA.Text = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Top = 0.01181102!
        Me.KIKAKU_TANTO_AREA.Width = 0.9055118!
        '
        'KIKAKU_TANTO_EIGYOSHO
        '
        Me.KIKAKU_TANTO_EIGYOSHO.CanGrow = False
        Me.KIKAKU_TANTO_EIGYOSHO.DataField = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Height = 0.2165354!
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 1.299213!
        Me.KIKAKU_TANTO_EIGYOSHO.Name = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KIKAKU_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_EIGYOSHO.Text = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Top = 0.01181102!
        Me.KIKAKU_TANTO_EIGYOSHO.Width = 1.496063!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.CanGrow = False
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.2165354!
        Me.FROM_DATE.Left = 2.795276!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.FROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.FROM_DATE.Text = "FROM_DATE"
        Me.FROM_DATE.Top = 0.01181102!
        Me.FROM_DATE.Width = 1.574803!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.CanGrow = False
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2165354!
        Me.KOUENKAI_NAME.Left = 4.370079!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KOUENKAI_NAME.Text = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Top = 0.01181102!
        Me.KOUENKAI_NAME.Width = 3.119292!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.CanGrow = False
        Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Height = 0.2165354!
        Me.TIME_STAMP_BYL.Left = 7.489371!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.TIME_STAMP_BYL.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.TIME_STAMP_BYL.Text = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Top = 0.01181102!
        Me.TIME_STAMP_BYL.Width = 1.358268!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.CanGrow = False
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.2165354!
        Me.REQ_STATUS_TEHAI.Left = 8.850788!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.REQ_STATUS_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.REQ_STATUS_TEHAI.Text = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Top = 0.01181102!
        Me.REQ_STATUS_TEHAI.Width = 0.9133858!
        '
        'USER_NAME
        '
        Me.USER_NAME.CanGrow = False
        Me.USER_NAME.DataField = "USER_NAME"
        Me.USER_NAME.Height = 0.2165354!
        Me.USER_NAME.Left = 9.764174!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.USER_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.USER_NAME.Text = "USER_NAME"
        Me.USER_NAME.Top = 0.01181102!
        Me.USER_NAME.Width = 1.233071!
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
        Me.TO_DATE.Left = 3.377166!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.TO_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.TO_DATE.Text = "TO_DATE"
        Me.TO_DATE.Top = 0.3811024!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 1.181102!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.1692913!
        Me.KOUENKAI_NO.Left = 4.683465!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 1, 1)
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; white-space: nowrap; ddo-char-set: 1"
        Me.KOUENKAI_NO.Text = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Top = 0.3811024!
        Me.KOUENKAI_NO.Visible = False
        Me.KOUENKAI_NO.Width = 1.181102!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.0!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.2322835!
        Me.Line21.Width = 11.02362!
        Me.Line21.X1 = 0.0!
        Me.Line21.X2 = 11.02362!
        Me.Line21.Y1 = 0.2322835!
        Me.Line21.Y2 = 0.2322835!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'NewKaijoListReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.04331!
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
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenBU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenKIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JokenREQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
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
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents LabelPage As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenBU As DataDynamics.ActiveReports.Label
    Private WithEvents JokenKIKAKU_TANTO_AREA As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents JokenREQ_STATUS_TEHAI As DataDynamics.ActiveReports.Label
End Class 
