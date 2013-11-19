<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SeisanRegistReport 
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SeisanRegistReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.PrintDate = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.LOGIN_USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.LabelPage = New DataDynamics.ActiveReports.Label
        Me.PageCount = New DataDynamics.ActiveReports.TextBox
        Me.PageTotal = New DataDynamics.ActiveReports.TextBox
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.lblKOUENKAI_NO = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.lblSHIHARAI_NO = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Shape3 = New DataDynamics.ActiveReports.Shape
        Me.Shape4 = New DataDynamics.ActiveReports.Shape
        Me.lblSEISAN_YM = New DataDynamics.ActiveReports.Label
        Me.lblSHOUNIN_KUBUN = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.SHIHARAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.SEISAN_YM = New DataDynamics.ActiveReports.TextBox
        Me.SHOUNIN_KUBUN = New DataDynamics.ActiveReports.TextBox
        Me.lblSEIKYU_NO_TOPTOUR = New DataDynamics.ActiveReports.Label
        Me.lblSHOUNIN_DATE = New DataDynamics.ActiveReports.Label
        Me.SEIKYU_NO_TOPTOUR = New DataDynamics.ActiveReports.TextBox
        Me.SHOUNIN_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Shape5 = New DataDynamics.ActiveReports.Shape
        Me.lblTF = New DataDynamics.ActiveReports.Label
        Me.lbl991330401_TF = New DataDynamics.ActiveReports.Label
        Me.lblKAIJOHI_TF = New DataDynamics.ActiveReports.Label
        Me.lblINSHOKUHI_TF = New DataDynamics.ActiveReports.Label
        Me.lblHOTELHI_TF = New DataDynamics.ActiveReports.Label
        Me.lblHOTEL_COMMISSION_TF = New DataDynamics.ActiveReports.Label
        Me.lblOTHER_TRAFFIC_TF = New DataDynamics.ActiveReports.Label
        Me.lblJR_TF = New DataDynamics.ActiveReports.Label
        Me.lblKIZAIHI_TF = New DataDynamics.ActiveReports.Label
        Me.lblHOTELHI_TOZEI = New DataDynamics.ActiveReports.Label
        Me.lblKANRIHI_TF = New DataDynamics.ActiveReports.Label
        Me.lblAIR_TF = New DataDynamics.ActiveReports.Label
        Me.lblTAXI_COMMISSION_TF = New DataDynamics.ActiveReports.Label
        Me.lblJINKENHI_TF = New DataDynamics.ActiveReports.Label
        Me.lblOTHER_TF = New DataDynamics.ActiveReports.Label
        Me.lblTAXI_TF = New DataDynamics.ActiveReports.Label
        Me.lblTAXI_SEISAN_TF = New DataDynamics.ActiveReports.Label
        Me.KAIJOHI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.KIZAIHI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.lblKEI_991330401_TF = New DataDynamics.ActiveReports.Label
        Me.KEI_991330401_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.lblKEI_41120200_TF = New DataDynamics.ActiveReports.Label
        Me.KEI_41120200_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.lblKEI_TF = New DataDynamics.ActiveReports.Label
        Me.KEI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.lblT = New DataDynamics.ActiveReports.Label
        Me.lbl41120200_TF = New DataDynamics.ActiveReports.Label
        Me.lbl991330401_T = New DataDynamics.ActiveReports.Label
        Me.lblKAIJOUHI_T = New DataDynamics.ActiveReports.Label
        Me.lblINSHOKUHI_T = New DataDynamics.ActiveReports.Label
        Me.lblKIZAIHI_T = New DataDynamics.ActiveReports.Label
        Me.lblJINKENHI_T = New DataDynamics.ActiveReports.Label
        Me.lbl41120200_T = New DataDynamics.ActiveReports.Label
        Me.lblOTHER_T = New DataDynamics.ActiveReports.Label
        Me.lblKANRIHI_T = New DataDynamics.ActiveReports.Label
        Me.lblMR_HOTEL = New DataDynamics.ActiveReports.Label
        Me.lblMR_JR = New DataDynamics.ActiveReports.Label
        Me.lblMR_HOTEL_TOZEI = New DataDynamics.ActiveReports.Label
        Me.lblSEISANSHO_URL = New DataDynamics.ActiveReports.Label
        Me.lblTAXI_T = New DataDynamics.ActiveReports.Label
        Me.lblTAXI_SEISAN_T = New DataDynamics.ActiveReports.Label
        Me.lblTAXI_TICKET_URL = New DataDynamics.ActiveReports.Label
        Me.lblSEISAN_KANRYO = New DataDynamics.ActiveReports.Label
        Me.INSHOKUHI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.HOTELHI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.JR_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.OTHER_TRAFFIC_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.HOTEL_COMMISSION_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.OTHER_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label38 = New DataDynamics.ActiveReports.Label
        Me.TAXI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label49 = New DataDynamics.ActiveReports.Label
        Me.KAIJOUHI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label50 = New DataDynamics.ActiveReports.Label
        Me.INSHOKUHI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label51 = New DataDynamics.ActiveReports.Label
        Me.JINKENHI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label52 = New DataDynamics.ActiveReports.Label
        Me.KANRIHI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label53 = New DataDynamics.ActiveReports.Label
        Me.HOTELHI_TOZEI = New DataDynamics.ActiveReports.TextBox
        Me.Label54 = New DataDynamics.ActiveReports.Label
        Me.AIR_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label55 = New DataDynamics.ActiveReports.Label
        Me.TAXI_COMMISSION_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label56 = New DataDynamics.ActiveReports.Label
        Me.JINKENHI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label57 = New DataDynamics.ActiveReports.Label
        Me.KANRIHI_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label58 = New DataDynamics.ActiveReports.Label
        Me.TAXI_SEISAN_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label59 = New DataDynamics.ActiveReports.Label
        Me.KIZAIHI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label60 = New DataDynamics.ActiveReports.Label
        Me.OTHER_T = New DataDynamics.ActiveReports.TextBox
        Me.Label61 = New DataDynamics.ActiveReports.Label
        Me.MR_HOTEL = New DataDynamics.ActiveReports.TextBox
        Me.Label62 = New DataDynamics.ActiveReports.Label
        Me.MR_HOTEL_TOZEI = New DataDynamics.ActiveReports.TextBox
        Me.Label63 = New DataDynamics.ActiveReports.Label
        Me.MR_JR = New DataDynamics.ActiveReports.TextBox
        Me.Label64 = New DataDynamics.ActiveReports.Label
        Me.TAXI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label65 = New DataDynamics.ActiveReports.Label
        Me.TAXI_SEISAN_T = New DataDynamics.ActiveReports.TextBox
        Me.Label66 = New DataDynamics.ActiveReports.Label
        Me.SEISANSHO_URL = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_TICKET_URL = New DataDynamics.ActiveReports.TextBox
        Me.SEISAN_KANRYO = New DataDynamics.ActiveReports.TextBox
        Me.lblKEI_991330401_T = New DataDynamics.ActiveReports.Label
        Me.KEI_991330401_T = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.lblKEI_41120200_T = New DataDynamics.ActiveReports.Label
        Me.KEI_41120200_T = New DataDynamics.ActiveReports.TextBox
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.lblKEI_T = New DataDynamics.ActiveReports.Label
        Me.KEI_T = New DataDynamics.ActiveReports.TextBox
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSHIHARAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSEISAN_YM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHIHARAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEISAN_YM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSHOUNIN_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHOUNIN_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl991330401_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKAIJOHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblINSHOKUHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHOTELHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHOTEL_COMMISSION_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOTHER_TRAFFIC_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJR_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKIZAIHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHOTELHI_TOZEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKANRIHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAIR_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTAXI_COMMISSION_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJINKENHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOTHER_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTAXI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTAXI_SEISAN_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAIJOHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIZAIHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKEI_991330401_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KEI_991330401_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKEI_41120200_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KEI_41120200_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKEI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KEI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl41120200_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl991330401_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKAIJOUHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblINSHOKUHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKIZAIHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblJINKENHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl41120200_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblOTHER_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKANRIHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMR_HOTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMR_JR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblMR_HOTEL_TOZEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSEISANSHO_URL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTAXI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTAXI_SEISAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTAXI_TICKET_URL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSEISAN_KANRYO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSHOKUHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JR_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_TRAFFIC_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTEL_COMMISSION_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAIJOUHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INSHOKUHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JINKENHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KANRIHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTELHI_TOZEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AIR_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_COMMISSION_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JINKENHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KANRIHI_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_SEISAN_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIZAIHI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_HOTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_HOTEL_TOZEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_JR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_SEISAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEISANSHO_URL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_TICKET_URL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEISAN_KANRYO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKEI_991330401_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KEI_991330401_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKEI_41120200_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KEI_41120200_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblKEI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KEI_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Label8, Me.Label4, Me.PrintDate, Me.Label1, Me.Label3, Me.LOGIN_USER_NAME, Me.Label2, Me.LabelPage, Me.PageCount, Me.PageTotal})
        Me.PageHeader.Height = 0.929544!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.3149607!
        Me.Shape1.Left = 0.007480315!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.5933071!
        Me.Shape1.Width = 7.529923!
        '
        'Label8
        '
        Me.Label8.Height = 0.2688977!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.879921!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "精算金額入力"
        Me.Label8.Top = 0.6137795!
        Me.Label8.Width = 1.770473!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.002757!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001311153!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1968504!
        Me.PrintDate.Left = 6.159449!
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Style = "font-family: ＭＳ ゴシック"
        Me.PrintDate.Text = "2013/12/12 00:00:00"
        Me.PrintDate.Top = 0.0001311153!
        Me.PrintDate.Width = 1.377953!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.408628!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label1.Text = "出力日"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.6251969!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 6.002758!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label3.Text = "："
        Me.Label3.Top = 0.1772966!
        Me.Label3.Width = 0.1669291!
        '
        'LOGIN_USER_NAME
        '
        Me.LOGIN_USER_NAME.CanGrow = False
        Me.LOGIN_USER_NAME.DataField = "USER_NAME"
        Me.LOGIN_USER_NAME.Height = 0.1968504!
        Me.LOGIN_USER_NAME.Left = 6.159415!
        Me.LOGIN_USER_NAME.Name = "LOGIN_USER_NAME"
        Me.LOGIN_USER_NAME.Style = "font-family: ＭＳ ゴシック"
        Me.LOGIN_USER_NAME.Text = Nothing
        Me.LOGIN_USER_NAME.Top = 0.1771654!
        Me.LOGIN_USER_NAME.Width = 1.377953!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.408628!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label2.Text = "出力担当"
        Me.Label2.Top = 0.1771655!
        Me.Label2.Width = 0.6251969!
        '
        'LabelPage
        '
        Me.LabelPage.Height = 0.1968504!
        Me.LabelPage.HyperLink = Nothing
        Me.LabelPage.Left = 5.955085!
        Me.LabelPage.Name = "LabelPage"
        Me.LabelPage.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: right"
        Me.LabelPage.Text = "(999 / 999 ページ)"
        Me.LabelPage.Top = 0.3740158!
        Me.LabelPage.Width = 1.574803!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 4.510991!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.PageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.3590552!
        Me.PageCount.Visible = False
        Me.PageCount.Width = 0.2755905!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 4.865322!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.3590552!
        Me.PageTotal.Visible = False
        Me.PageTotal.Width = 0.2755905!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.lblKOUENKAI_NO, Me.lblSHIHARAI_NO, Me.Shape3, Me.Shape4, Me.lblSEISAN_YM, Me.lblSHOUNIN_KUBUN, Me.KOUENKAI_NO, Me.SHIHARAI_NO, Me.SEISAN_YM, Me.SHOUNIN_KUBUN, Me.lblSEIKYU_NO_TOPTOUR, Me.lblSHOUNIN_DATE, Me.SEIKYU_NO_TOPTOUR, Me.SHOUNIN_DATE, Me.Shape5, Me.lblTF, Me.lbl991330401_TF, Me.lblKAIJOHI_TF, Me.lblINSHOKUHI_TF, Me.lblHOTELHI_TF, Me.lblHOTEL_COMMISSION_TF, Me.lblOTHER_TRAFFIC_TF, Me.lblJR_TF, Me.lblKIZAIHI_TF, Me.lblHOTELHI_TOZEI, Me.lblKANRIHI_TF, Me.lblAIR_TF, Me.lblTAXI_COMMISSION_TF, Me.lblJINKENHI_TF, Me.lblOTHER_TF, Me.lblTAXI_TF, Me.lblTAXI_SEISAN_TF, Me.KAIJOHI_TF, Me.Label23, Me.KIZAIHI_TF, Me.Label24, Me.lblKEI_991330401_TF, Me.KEI_991330401_TF, Me.Label26, Me.lblKEI_41120200_TF, Me.KEI_41120200_TF, Me.Label28, Me.lblKEI_TF, Me.KEI_TF, Me.Label30, Me.lblT, Me.lbl41120200_TF, Me.lbl991330401_T, Me.lblKAIJOUHI_T, Me.lblINSHOKUHI_T, Me.lblKIZAIHI_T, Me.lblJINKENHI_T, Me.lbl41120200_T, Me.lblOTHER_T, Me.lblKANRIHI_T, Me.lblMR_HOTEL, Me.lblMR_JR, Me.lblMR_HOTEL_TOZEI, Me.lblSEISANSHO_URL, Me.lblTAXI_T, Me.lblTAXI_SEISAN_T, Me.lblTAXI_TICKET_URL, Me.lblSEISAN_KANRYO, Me.INSHOKUHI_TF, Me.Label5, Me.HOTELHI_TF, Me.Label6, Me.JR_TF, Me.Label31, Me.OTHER_TRAFFIC_TF, Me.Label32, Me.HOTEL_COMMISSION_TF, Me.Label33, Me.OTHER_TF, Me.Label38, Me.TAXI_TF, Me.Label49, Me.KAIJOUHI_T, Me.Label50, Me.INSHOKUHI_T, Me.Label51, Me.JINKENHI_T, Me.Label52, Me.KANRIHI_T, Me.Label53, Me.HOTELHI_TOZEI, Me.Label54, Me.AIR_TF, Me.Label55, Me.TAXI_COMMISSION_TF, Me.Label56, Me.JINKENHI_TF, Me.Label57, Me.KANRIHI_TF, Me.Label58, Me.TAXI_SEISAN_TF, Me.Label59, Me.KIZAIHI_T, Me.Label60, Me.OTHER_T, Me.Label61, Me.MR_HOTEL, Me.Label62, Me.MR_HOTEL_TOZEI, Me.Label63, Me.MR_JR, Me.Label64, Me.TAXI_T, Me.Label65, Me.TAXI_SEISAN_T, Me.Label66, Me.SEISANSHO_URL, Me.TAXI_TICKET_URL, Me.SEISAN_KANRYO, Me.lblKEI_991330401_T, Me.KEI_991330401_T, Me.Label9, Me.lblKEI_41120200_T, Me.KEI_41120200_T, Me.Label11, Me.lblKEI_T, Me.KEI_T, Me.Label13, Me.Line1, Me.Line7, Me.Line2, Me.Line4, Me.Line5, Me.Line3, Me.Line6, Me.Line8, Me.Line9, Me.Line10})
        Me.Detail.Height = 9.581957!
        Me.Detail.Name = "Detail"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape2.Height = 0.3937008!
        Me.Shape2.Left = 0.007480315!
        Me.Shape2.LineColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape2.LineWeight = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 0.1874016!
        Me.Shape2.Width = 0.8547245!
        '
        'Line7
        '
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 0.0!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.1874016!
        Me.Line7.Width = 7.490942!
        Me.Line7.X1 = 0.0!
        Me.Line7.X2 = 7.490942!
        Me.Line7.Y1 = 0.1874016!
        Me.Line7.Y2 = 0.1874016!
        '
        'lblKOUENKAI_NO
        '
        Me.lblKOUENKAI_NO.Height = 0.1968504!
        Me.lblKOUENKAI_NO.HyperLink = Nothing
        Me.lblKOUENKAI_NO.Left = 0.007480315!
        Me.lblKOUENKAI_NO.Name = "lblKOUENKAI_NO"
        Me.lblKOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKOUENKAI_NO.Text = "講演会番号"
        Me.lblKOUENKAI_NO.Top = 0.1874016!
        Me.lblKOUENKAI_NO.Width = 0.8547245!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.384252!
        Me.Line1.Width = 7.490944!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.490944!
        Me.Line1.Y1 = 0.384252!
        Me.Line1.Y2 = 0.384252!
        '
        'lblSHIHARAI_NO
        '
        Me.lblSHIHARAI_NO.Height = 0.1968504!
        Me.lblSHIHARAI_NO.HyperLink = Nothing
        Me.lblSHIHARAI_NO.Left = 0.0!
        Me.lblSHIHARAI_NO.Name = "lblSHIHARAI_NO"
        Me.lblSHIHARAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSHIHARAI_NO.Text = "支払番号"
        Me.lblSHIHARAI_NO.Top = 0.384252!
        Me.lblSHIHARAI_NO.Width = 0.8622048!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.584252!
        Me.Line2.Width = 7.490944!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.490944!
        Me.Line2.Y1 = 0.584252!
        Me.Line2.Y2 = 0.584252!
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape3.Height = 0.3937008!
        Me.Shape3.Left = 2.291733!
        Me.Shape3.LineColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape3.LineWeight = 0.0!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 0.1905512!
        Me.Shape3.Width = 1.500787!
        '
        'Shape4
        '
        Me.Shape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape4.Height = 0.3937008!
        Me.Shape4.Left = 4.944095!
        Me.Shape4.LineColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape4.LineWeight = 0.0!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = 9.999999!
        Me.Shape4.Top = 0.1905512!
        Me.Shape4.Width = 0.9173231!
        '
        'lblSEISAN_YM
        '
        Me.lblSEISAN_YM.Height = 0.1968504!
        Me.lblSEISAN_YM.HyperLink = Nothing
        Me.lblSEISAN_YM.Left = 2.35315!
        Me.lblSEISAN_YM.Name = "lblSEISAN_YM"
        Me.lblSEISAN_YM.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSEISAN_YM.Text = "トップツアー精算年月"
        Me.lblSEISAN_YM.Top = 0.1905512!
        Me.lblSEISAN_YM.Width = 1.500787!
        '
        'lblSHOUNIN_KUBUN
        '
        Me.lblSHOUNIN_KUBUN.Height = 0.1968504!
        Me.lblSHOUNIN_KUBUN.HyperLink = Nothing
        Me.lblSHOUNIN_KUBUN.Left = 2.35315!
        Me.lblSHOUNIN_KUBUN.Name = "lblSHOUNIN_KUBUN"
        Me.lblSHOUNIN_KUBUN.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSHOUNIN_KUBUN.Text = "承認区分"
        Me.lblSHOUNIN_KUBUN.Top = 0.3874016!
        Me.lblSHOUNIN_KUBUN.Width = 1.500787!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.1968504!
        Me.KOUENKAI_NO.Left = 0.9248032!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.KOUENKAI_NO.Text = "12345678901234"
        Me.KOUENKAI_NO.Top = 0.1905512!
        Me.KOUENKAI_NO.Width = 1.291339!
        '
        'SHIHARAI_NO
        '
        Me.SHIHARAI_NO.CanGrow = False
        Me.SHIHARAI_NO.DataField = "SHIHARAI_NO"
        Me.SHIHARAI_NO.Height = 0.1968504!
        Me.SHIHARAI_NO.Left = 0.9248032!
        Me.SHIHARAI_NO.Name = "SHIHARAI_NO"
        Me.SHIHARAI_NO.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SHIHARAI_NO.Text = "12345678901234"
        Me.SHIHARAI_NO.Top = 0.3905512!
        Me.SHIHARAI_NO.Width = 1.291339!
        '
        'SEISAN_YM
        '
        Me.SEISAN_YM.CanGrow = False
        Me.SEISAN_YM.DataField = "SEISAN_YM"
        Me.SEISAN_YM.Height = 0.1968504!
        Me.SEISAN_YM.Left = 3.853937!
        Me.SEISAN_YM.Name = "SEISAN_YM"
        Me.SEISAN_YM.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SEISAN_YM.Text = "YYYY年MM月"
        Me.SEISAN_YM.Top = 0.1905512!
        Me.SEISAN_YM.Width = 0.9267719!
        '
        'SHOUNIN_KUBUN
        '
        Me.SHOUNIN_KUBUN.CanGrow = False
        Me.SHOUNIN_KUBUN.DataField = "SHOUNIN_KUBUN"
        Me.SHOUNIN_KUBUN.Height = 0.1968504!
        Me.SHOUNIN_KUBUN.Left = 3.853937!
        Me.SHOUNIN_KUBUN.Name = "SHOUNIN_KUBUN"
        Me.SHOUNIN_KUBUN.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SHOUNIN_KUBUN.Text = Nothing
        Me.SHOUNIN_KUBUN.Top = 0.384252!
        Me.SHOUNIN_KUBUN.Width = 0.9267719!
        '
        'lblSEIKYU_NO_TOPTOUR
        '
        Me.lblSEIKYU_NO_TOPTOUR.Height = 0.1968504!
        Me.lblSEIKYU_NO_TOPTOUR.HyperLink = Nothing
        Me.lblSEIKYU_NO_TOPTOUR.Left = 4.944095!
        Me.lblSEIKYU_NO_TOPTOUR.Name = "lblSEIKYU_NO_TOPTOUR"
        Me.lblSEIKYU_NO_TOPTOUR.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSEIKYU_NO_TOPTOUR.Text = "精算番号"
        Me.lblSEIKYU_NO_TOPTOUR.Top = 0.1905512!
        Me.lblSEIKYU_NO_TOPTOUR.Width = 0.9173231!
        '
        'lblSHOUNIN_DATE
        '
        Me.lblSHOUNIN_DATE.Height = 0.1968504!
        Me.lblSHOUNIN_DATE.HyperLink = Nothing
        Me.lblSHOUNIN_DATE.Left = 4.944095!
        Me.lblSHOUNIN_DATE.Name = "lblSHOUNIN_DATE"
        Me.lblSHOUNIN_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSHOUNIN_DATE.Text = "精算承認日"
        Me.lblSHOUNIN_DATE.Top = 0.3874016!
        Me.lblSHOUNIN_DATE.Width = 0.9173231!
        '
        'SEIKYU_NO_TOPTOUR
        '
        Me.SEIKYU_NO_TOPTOUR.CanGrow = False
        Me.SEIKYU_NO_TOPTOUR.DataField = "SEIKYU_NO_TOPTOUR"
        Me.SEIKYU_NO_TOPTOUR.Height = 0.1968504!
        Me.SEIKYU_NO_TOPTOUR.Left = 5.955119!
        Me.SEIKYU_NO_TOPTOUR.Name = "SEIKYU_NO_TOPTOUR"
        Me.SEIKYU_NO_TOPTOUR.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SEIKYU_NO_TOPTOUR.Text = "12345678901234"
        Me.SEIKYU_NO_TOPTOUR.Top = 0.1874016!
        Me.SEIKYU_NO_TOPTOUR.Width = 1.291339!
        '
        'SHOUNIN_DATE
        '
        Me.SHOUNIN_DATE.CanGrow = False
        Me.SHOUNIN_DATE.DataField = "SHOUNIN_DATE"
        Me.SHOUNIN_DATE.Height = 0.1968504!
        Me.SHOUNIN_DATE.Left = 5.955119!
        Me.SHOUNIN_DATE.Name = "SHOUNIN_DATE"
        Me.SHOUNIN_DATE.Style = "font-family: ＭＳ ゴシック; white-space: nowrap"
        Me.SHOUNIN_DATE.Text = "YYYY年MM月DD日"
        Me.SHOUNIN_DATE.Top = 0.384252!
        Me.SHOUNIN_DATE.Width = 1.291339!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.007480315!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.7799213!
        Me.Line3.Width = 7.490944!
        Me.Line3.X1 = 0.007480315!
        Me.Line3.X2 = 7.498424!
        Me.Line3.Y1 = 0.7799213!
        Me.Line3.Y2 = 0.7799213!
        '
        'Shape5
        '
        Me.Shape5.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape5.Height = 5.988584!
        Me.Shape5.Left = 0.007480315!
        Me.Shape5.LineColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape5.LineWeight = 0.0!
        Me.Shape5.Name = "Shape5"
        Me.Shape5.RoundingRadius = 9.999999!
        Me.Shape5.Top = 0.7799213!
        Me.Shape5.Width = 0.5212598!
        '
        'lblTF
        '
        Me.lblTF.Height = 0.1968504!
        Me.lblTF.HyperLink = Nothing
        Me.lblTF.Left = 0.0!
        Me.lblTF.Name = "lblTF"
        Me.lblTF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTF.Text = "非課税"
        Me.lblTF.Top = 1.760236!
        Me.lblTF.Width = 0.5212598!
        '
        'lbl991330401_TF
        '
        Me.lbl991330401_TF.Height = 0.1968504!
        Me.lbl991330401_TF.HyperLink = Nothing
        Me.lbl991330401_TF.Left = 0.5834646!
        Me.lbl991330401_TF.Name = "lbl991330401_TF"
        Me.lbl991330401_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lbl991330401_TF.Text = "991330401"
        Me.lbl991330401_TF.Top = 0.937008!
        Me.lbl991330401_TF.Width = 1.396457!
        '
        'lblKAIJOHI_TF
        '
        Me.lblKAIJOHI_TF.Height = 0.1968504!
        Me.lblKAIJOHI_TF.HyperLink = Nothing
        Me.lblKAIJOHI_TF.Left = 0.5759843!
        Me.lblKAIJOHI_TF.Name = "lblKAIJOHI_TF"
        Me.lblKAIJOHI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKAIJOHI_TF.Text = "会場費"
        Me.lblKAIJOHI_TF.Top = 1.238364!
        Me.lblKAIJOHI_TF.Width = 1.396457!
        '
        'lblINSHOKUHI_TF
        '
        Me.lblINSHOKUHI_TF.Height = 0.1968504!
        Me.lblINSHOKUHI_TF.HyperLink = Nothing
        Me.lblINSHOKUHI_TF.Left = 0.5759843!
        Me.lblINSHOKUHI_TF.Name = "lblINSHOKUHI_TF"
        Me.lblINSHOKUHI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblINSHOKUHI_TF.Text = "飲食費"
        Me.lblINSHOKUHI_TF.Top = 1.53972!
        Me.lblINSHOKUHI_TF.Width = 1.396457!
        '
        'lblHOTELHI_TF
        '
        Me.lblHOTELHI_TF.Height = 0.1968504!
        Me.lblHOTELHI_TF.HyperLink = Nothing
        Me.lblHOTELHI_TF.Left = 0.5834646!
        Me.lblHOTELHI_TF.Name = "lblHOTELHI_TF"
        Me.lblHOTELHI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblHOTELHI_TF.Text = "宿泊費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHOTELHI_TF.Top = 2.224322!
        Me.lblHOTELHI_TF.Width = 1.396457!
        '
        'lblHOTEL_COMMISSION_TF
        '
        Me.lblHOTEL_COMMISSION_TF.Height = 0.1968504!
        Me.lblHOTEL_COMMISSION_TF.HyperLink = Nothing
        Me.lblHOTEL_COMMISSION_TF.Left = 0.5834646!
        Me.lblHOTEL_COMMISSION_TF.Name = "lblHOTEL_COMMISSION_TF"
        Me.lblHOTEL_COMMISSION_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblHOTEL_COMMISSION_TF.Text = "登録手数料"
        Me.lblHOTEL_COMMISSION_TF.Top = 3.12839!
        Me.lblHOTEL_COMMISSION_TF.Width = 1.396457!
        '
        'lblOTHER_TRAFFIC_TF
        '
        Me.lblOTHER_TRAFFIC_TF.Height = 0.1968504!
        Me.lblOTHER_TRAFFIC_TF.HyperLink = Nothing
        Me.lblOTHER_TRAFFIC_TF.Left = 0.5834646!
        Me.lblOTHER_TRAFFIC_TF.Name = "lblOTHER_TRAFFIC_TF"
        Me.lblOTHER_TRAFFIC_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblOTHER_TRAFFIC_TF.Text = "その他鉄道等費用"
        Me.lblOTHER_TRAFFIC_TF.Top = 2.827034!
        Me.lblOTHER_TRAFFIC_TF.Width = 1.396457!
        '
        'lblJR_TF
        '
        Me.lblJR_TF.Height = 0.1968504!
        Me.lblJR_TF.HyperLink = Nothing
        Me.lblJR_TF.Left = 0.5834646!
        Me.lblJR_TF.Name = "lblJR_TF"
        Me.lblJR_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblJR_TF.Text = "JR代"
        Me.lblJR_TF.Top = 2.525678!
        Me.lblJR_TF.Width = 1.396457!
        '
        'lblKIZAIHI_TF
        '
        Me.lblKIZAIHI_TF.Height = 0.1968504!
        Me.lblKIZAIHI_TF.HyperLink = Nothing
        Me.lblKIZAIHI_TF.Left = 3.246457!
        Me.lblKIZAIHI_TF.Name = "lblKIZAIHI_TF"
        Me.lblKIZAIHI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKIZAIHI_TF.Text = "機材費"
        Me.lblKIZAIHI_TF.Top = 1.238364!
        Me.lblKIZAIHI_TF.Width = 1.396457!
        '
        'lblHOTELHI_TOZEI
        '
        Me.lblHOTELHI_TOZEI.Height = 0.1968504!
        Me.lblHOTELHI_TOZEI.HyperLink = Nothing
        Me.lblHOTELHI_TOZEI.Left = 3.253937!
        Me.lblHOTELHI_TOZEI.Name = "lblHOTELHI_TOZEI"
        Me.lblHOTELHI_TOZEI.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblHOTELHI_TOZEI.Text = "宿泊費都税"
        Me.lblHOTELHI_TOZEI.Top = 2.224322!
        Me.lblHOTELHI_TOZEI.Width = 1.396457!
        '
        'lblKANRIHI_TF
        '
        Me.lblKANRIHI_TF.Height = 0.1968504!
        Me.lblKANRIHI_TF.HyperLink = Nothing
        Me.lblKANRIHI_TF.Left = 3.253937!
        Me.lblKANRIHI_TF.Name = "lblKANRIHI_TF"
        Me.lblKANRIHI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKANRIHI_TF.Text = "管理費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblKANRIHI_TF.Top = 3.429746!
        Me.lblKANRIHI_TF.Width = 1.396457!
        '
        'lblAIR_TF
        '
        Me.lblAIR_TF.Height = 0.1968504!
        Me.lblAIR_TF.HyperLink = Nothing
        Me.lblAIR_TF.Left = 3.253937!
        Me.lblAIR_TF.Name = "lblAIR_TF"
        Me.lblAIR_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblAIR_TF.Text = "航空券代"
        Me.lblAIR_TF.Top = 2.525678!
        Me.lblAIR_TF.Width = 1.396457!
        '
        'lblTAXI_COMMISSION_TF
        '
        Me.lblTAXI_COMMISSION_TF.Height = 0.1968504!
        Me.lblTAXI_COMMISSION_TF.HyperLink = Nothing
        Me.lblTAXI_COMMISSION_TF.Left = 3.253937!
        Me.lblTAXI_COMMISSION_TF.Name = "lblTAXI_COMMISSION_TF"
        Me.lblTAXI_COMMISSION_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTAXI_COMMISSION_TF.Text = "タクチケ発券手数料"
        Me.lblTAXI_COMMISSION_TF.Top = 2.827034!
        Me.lblTAXI_COMMISSION_TF.Width = 1.396457!
        '
        'lblJINKENHI_TF
        '
        Me.lblJINKENHI_TF.Height = 0.1968504!
        Me.lblJINKENHI_TF.HyperLink = Nothing
        Me.lblJINKENHI_TF.Left = 3.253937!
        Me.lblJINKENHI_TF.Name = "lblJINKENHI_TF"
        Me.lblJINKENHI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblJINKENHI_TF.Text = "人件費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblJINKENHI_TF.Top = 3.12839!
        Me.lblJINKENHI_TF.Width = 1.396457!
        '
        'lblOTHER_TF
        '
        Me.lblOTHER_TF.Height = 0.1968504!
        Me.lblOTHER_TF.HyperLink = Nothing
        Me.lblOTHER_TF.Left = 0.5834646!
        Me.lblOTHER_TF.Name = "lblOTHER_TF"
        Me.lblOTHER_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblOTHER_TF.Text = "その他費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblOTHER_TF.Top = 3.429746!
        Me.lblOTHER_TF.Width = 1.396457!
        '
        'lblTAXI_TF
        '
        Me.lblTAXI_TF.Height = 0.1968504!
        Me.lblTAXI_TF.HyperLink = Nothing
        Me.lblTAXI_TF.Left = 0.5834646!
        Me.lblTAXI_TF.Name = "lblTAXI_TF"
        Me.lblTAXI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTAXI_TF.Text = "タクチケ実車料金"
        Me.lblTAXI_TF.Top = 3.731103!
        Me.lblTAXI_TF.Width = 1.396457!
        '
        'lblTAXI_SEISAN_TF
        '
        Me.lblTAXI_SEISAN_TF.Height = 0.1968504!
        Me.lblTAXI_SEISAN_TF.HyperLink = Nothing
        Me.lblTAXI_SEISAN_TF.Left = 3.253937!
        Me.lblTAXI_SEISAN_TF.Name = "lblTAXI_SEISAN_TF"
        Me.lblTAXI_SEISAN_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTAXI_SEISAN_TF.Text = "タクチケ精算手数料"
        Me.lblTAXI_SEISAN_TF.Top = 3.731103!
        Me.lblTAXI_SEISAN_TF.Width = 1.396457!
        '
        'KAIJOHI_TF
        '
        Me.KAIJOHI_TF.CanGrow = False
        Me.KAIJOHI_TF.DataField = "KAIJOHI_TF"
        Me.KAIJOHI_TF.Height = 0.1968504!
        Me.KAIJOHI_TF.Left = 1.972441!
        Me.KAIJOHI_TF.Name = "KAIJOHI_TF"
        Me.KAIJOHI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KAIJOHI_TF.Text = "1,234,567,890"
        Me.KAIJOHI_TF.Top = 1.238364!
        Me.KAIJOHI_TF.Width = 0.9681104!
        '
        'Label23
        '
        Me.Label23.Height = 0.1968504!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 2.940551!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label23.Text = "円"
        Me.Label23.Top = 1.238364!
        Me.Label23.Width = 0.2015748!
        '
        'KIZAIHI_TF
        '
        Me.KIZAIHI_TF.CanGrow = False
        Me.KIZAIHI_TF.DataField = "KIZAIHI_TF"
        Me.KIZAIHI_TF.Height = 0.1968504!
        Me.KIZAIHI_TF.Left = 4.642914!
        Me.KIZAIHI_TF.Name = "KIZAIHI_TF"
        Me.KIZAIHI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KIZAIHI_TF.Text = "1,234,567,890"
        Me.KIZAIHI_TF.Top = 1.238364!
        Me.KIZAIHI_TF.Width = 0.9681104!
        '
        'Label24
        '
        Me.Label24.Height = 0.1968504!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 5.611024!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label24.Text = "円"
        Me.Label24.Top = 1.238364!
        Me.Label24.Width = 0.2015748!
        '
        'lblKEI_991330401_TF
        '
        Me.lblKEI_991330401_TF.Height = 0.1968504!
        Me.lblKEI_991330401_TF.HyperLink = Nothing
        Me.lblKEI_991330401_TF.Left = 5.850787!
        Me.lblKEI_991330401_TF.Name = "lblKEI_991330401_TF"
        Me.lblKEI_991330401_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKEI_991330401_TF.Text = "小計"
        Me.lblKEI_991330401_TF.Top = 1.53972!
        Me.lblKEI_991330401_TF.Width = 0.427559!
        '
        'KEI_991330401_TF
        '
        Me.KEI_991330401_TF.CanGrow = False
        Me.KEI_991330401_TF.DataField = "KEI_991330401_TF"
        Me.KEI_991330401_TF.Height = 0.1968504!
        Me.KEI_991330401_TF.Left = 6.278347!
        Me.KEI_991330401_TF.Name = "KEI_991330401_TF"
        Me.KEI_991330401_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KEI_991330401_TF.Text = "1,234,567,890"
        Me.KEI_991330401_TF.Top = 1.53972!
        Me.KEI_991330401_TF.Width = 0.9681104!
        '
        'Label26
        '
        Me.Label26.Height = 0.1968504!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 7.246456!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label26.Text = "円"
        Me.Label26.Top = 1.53972!
        Me.Label26.Width = 0.2015748!
        '
        'lblKEI_41120200_TF
        '
        Me.lblKEI_41120200_TF.Height = 0.1968504!
        Me.lblKEI_41120200_TF.HyperLink = Nothing
        Me.lblKEI_41120200_TF.Left = 5.850787!
        Me.lblKEI_41120200_TF.Name = "lblKEI_41120200_TF"
        Me.lblKEI_41120200_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKEI_41120200_TF.Text = "小計"
        Me.lblKEI_41120200_TF.Top = 3.731103!
        Me.lblKEI_41120200_TF.Width = 0.4275589!
        '
        'KEI_41120200_TF
        '
        Me.KEI_41120200_TF.CanGrow = False
        Me.KEI_41120200_TF.DataField = "KEI_41120200_TF"
        Me.KEI_41120200_TF.Height = 0.1968504!
        Me.KEI_41120200_TF.Left = 6.278347!
        Me.KEI_41120200_TF.Name = "KEI_41120200_TF"
        Me.KEI_41120200_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KEI_41120200_TF.Text = "1,234,567,890"
        Me.KEI_41120200_TF.Top = 3.731103!
        Me.KEI_41120200_TF.Width = 0.9681104!
        '
        'Label28
        '
        Me.Label28.Height = 0.1968504!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 7.246455!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label28.Text = "円"
        Me.Label28.Top = 3.731103!
        Me.Label28.Width = 0.2015748!
        '
        'lblKEI_TF
        '
        Me.lblKEI_TF.Height = 0.1968505!
        Me.lblKEI_TF.HyperLink = Nothing
        Me.lblKEI_TF.Left = 5.267323!
        Me.lblKEI_TF.Name = "lblKEI_TF"
        Me.lblKEI_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKEI_TF.Text = "非課税金額計"
        Me.lblKEI_TF.Top = 4.083465!
        Me.lblKEI_TF.Width = 1.011024!
        '
        'KEI_TF
        '
        Me.KEI_TF.CanGrow = False
        Me.KEI_TF.DataField = "KEI_TF"
        Me.KEI_TF.Height = 0.1968504!
        Me.KEI_TF.Left = 6.278347!
        Me.KEI_TF.Name = "KEI_TF"
        Me.KEI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KEI_TF.Text = "1,234,567,890"
        Me.KEI_TF.Top = 4.083465!
        Me.KEI_TF.Width = 0.9681104!
        '
        'Label30
        '
        Me.Label30.Height = 0.1968504!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 7.246457!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label30.Text = "円"
        Me.Label30.Top = 4.083465!
        Me.Label30.Width = 0.2015748!
        '
        'lblT
        '
        Me.lblT.Height = 0.1968504!
        Me.lblT.HyperLink = Nothing
        Me.lblT.Left = 0.007480323!
        Me.lblT.Name = "lblT"
        Me.lblT.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblT.Text = "課税"
        Me.lblT.Top = 4.446851!
        Me.lblT.Width = 0.5212598!
        '
        'lbl41120200_TF
        '
        Me.lbl41120200_TF.Height = 0.1968504!
        Me.lbl41120200_TF.HyperLink = Nothing
        Me.lbl41120200_TF.Left = 0.5834646!
        Me.lbl41120200_TF.Name = "lbl41120200_TF"
        Me.lbl41120200_TF.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lbl41120200_TF.Text = "41120200"
        Me.lbl41120200_TF.Top = 1.922966!
        Me.lbl41120200_TF.Width = 1.396457!
        '
        'lbl991330401_T
        '
        Me.lbl991330401_T.Height = 0.1968504!
        Me.lbl991330401_T.HyperLink = Nothing
        Me.lbl991330401_T.Left = 0.5834646!
        Me.lbl991330401_T.Name = "lbl991330401_T"
        Me.lbl991330401_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lbl991330401_T.Text = "991330401"
        Me.lbl991330401_T.Top = 4.446851!
        Me.lbl991330401_T.Width = 1.396457!
        '
        'lblKAIJOUHI_T
        '
        Me.lblKAIJOUHI_T.Height = 0.1968504!
        Me.lblKAIJOUHI_T.HyperLink = Nothing
        Me.lblKAIJOUHI_T.Left = 0.5834647!
        Me.lblKAIJOUHI_T.Name = "lblKAIJOUHI_T"
        Me.lblKAIJOUHI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKAIJOUHI_T.Text = "会場費"
        Me.lblKAIJOUHI_T.Top = 4.748032!
        Me.lblKAIJOUHI_T.Width = 1.396457!
        '
        'lblINSHOKUHI_T
        '
        Me.lblINSHOKUHI_T.Height = 0.1968504!
        Me.lblINSHOKUHI_T.HyperLink = Nothing
        Me.lblINSHOKUHI_T.Left = 0.5834646!
        Me.lblINSHOKUHI_T.Name = "lblINSHOKUHI_T"
        Me.lblINSHOKUHI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblINSHOKUHI_T.Text = "飲食費"
        Me.lblINSHOKUHI_T.Top = 5.049212!
        Me.lblINSHOKUHI_T.Width = 1.396457!
        '
        'lblKIZAIHI_T
        '
        Me.lblKIZAIHI_T.Height = 0.1968504!
        Me.lblKIZAIHI_T.HyperLink = Nothing
        Me.lblKIZAIHI_T.Left = 3.253937!
        Me.lblKIZAIHI_T.Name = "lblKIZAIHI_T"
        Me.lblKIZAIHI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKIZAIHI_T.Text = "機材費"
        Me.lblKIZAIHI_T.Top = 4.748032!
        Me.lblKIZAIHI_T.Width = 1.396457!
        '
        'lblJINKENHI_T
        '
        Me.lblJINKENHI_T.Height = 0.1968504!
        Me.lblJINKENHI_T.HyperLink = Nothing
        Me.lblJINKENHI_T.Left = 0.5834646!
        Me.lblJINKENHI_T.Name = "lblJINKENHI_T"
        Me.lblJINKENHI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblJINKENHI_T.Text = "人件費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblJINKENHI_T.Top = 5.753937!
        Me.lblJINKENHI_T.Width = 1.396457!
        '
        'lbl41120200_T
        '
        Me.lbl41120200_T.Height = 0.1968504!
        Me.lbl41120200_T.HyperLink = Nothing
        Me.lbl41120200_T.Left = 0.5834646!
        Me.lbl41120200_T.Name = "lbl41120200_T"
        Me.lbl41120200_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lbl41120200_T.Text = "41120200"
        Me.lbl41120200_T.Top = 5.452756!
        Me.lbl41120200_T.Width = 1.396457!
        '
        'lblOTHER_T
        '
        Me.lblOTHER_T.Height = 0.1968504!
        Me.lblOTHER_T.HyperLink = Nothing
        Me.lblOTHER_T.Left = 3.253937!
        Me.lblOTHER_T.Name = "lblOTHER_T"
        Me.lblOTHER_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblOTHER_T.Text = "その他費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblOTHER_T.Top = 5.753937!
        Me.lblOTHER_T.Width = 1.396457!
        '
        'lblKANRIHI_T
        '
        Me.lblKANRIHI_T.Height = 0.1968504!
        Me.lblKANRIHI_T.HyperLink = Nothing
        Me.lblKANRIHI_T.Left = 0.5834646!
        Me.lblKANRIHI_T.Name = "lblKANRIHI_T"
        Me.lblKANRIHI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKANRIHI_T.Text = "管理費" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblKANRIHI_T.Top = 6.055119!
        Me.lblKANRIHI_T.Width = 1.396457!
        '
        'lblMR_HOTEL
        '
        Me.lblMR_HOTEL.Height = 0.1968504!
        Me.lblMR_HOTEL.HyperLink = Nothing
        Me.lblMR_HOTEL.Left = 0.007480315!
        Me.lblMR_HOTEL.Name = "lblMR_HOTEL"
        Me.lblMR_HOTEL.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblMR_HOTEL.Text = "社員の国内旅費（宿泊）"
        Me.lblMR_HOTEL.Top = 7.134253!
        Me.lblMR_HOTEL.Width = 1.925197!
        '
        'lblMR_JR
        '
        Me.lblMR_JR.Height = 0.1968504!
        Me.lblMR_JR.HyperLink = Nothing
        Me.lblMR_JR.Left = 0.007480334!
        Me.lblMR_JR.Name = "lblMR_JR"
        Me.lblMR_JR.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblMR_JR.Text = "社員の国内旅費（JR/航空券）"
        Me.lblMR_JR.Top = 7.655905!
        Me.lblMR_JR.Width = 1.925197!
        '
        'lblMR_HOTEL_TOZEI
        '
        Me.lblMR_HOTEL_TOZEI.Height = 0.1968504!
        Me.lblMR_HOTEL_TOZEI.HyperLink = Nothing
        Me.lblMR_HOTEL_TOZEI.Left = 0.007480334!
        Me.lblMR_HOTEL_TOZEI.Name = "lblMR_HOTEL_TOZEI"
        Me.lblMR_HOTEL_TOZEI.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblMR_HOTEL_TOZEI.Text = "社員の国内旅費（宿泊都税）"
        Me.lblMR_HOTEL_TOZEI.Top = 7.407086!
        Me.lblMR_HOTEL_TOZEI.Width = 1.925197!
        '
        'lblSEISANSHO_URL
        '
        Me.lblSEISANSHO_URL.Height = 0.1968504!
        Me.lblSEISANSHO_URL.HyperLink = Nothing
        Me.lblSEISANSHO_URL.Left = 0.007480334!
        Me.lblSEISANSHO_URL.Name = "lblSEISANSHO_URL"
        Me.lblSEISANSHO_URL.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSEISANSHO_URL.Text = "精算書保存場所URL"
        Me.lblSEISANSHO_URL.Top = 7.93819!
        Me.lblSEISANSHO_URL.Width = 1.925197!
        '
        'lblTAXI_T
        '
        Me.lblTAXI_T.Height = 0.1968504!
        Me.lblTAXI_T.HyperLink = Nothing
        Me.lblTAXI_T.Left = 0.007480334!
        Me.lblTAXI_T.Name = "lblTAXI_T"
        Me.lblTAXI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTAXI_T.Text = "タクチケ実車料金（課税）"
        Me.lblTAXI_T.Top = 8.335051!
        Me.lblTAXI_T.Width = 1.925197!
        '
        'lblTAXI_SEISAN_T
        '
        Me.lblTAXI_SEISAN_T.Height = 0.1968504!
        Me.lblTAXI_SEISAN_T.HyperLink = Nothing
        Me.lblTAXI_SEISAN_T.Left = 0.00000001862645!
        Me.lblTAXI_SEISAN_T.Name = "lblTAXI_SEISAN_T"
        Me.lblTAXI_SEISAN_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTAXI_SEISAN_T.Text = "タクチケ精算手数料（課税）"
        Me.lblTAXI_SEISAN_T.Top = 8.586241!
        Me.lblTAXI_SEISAN_T.Width = 1.925197!
        '
        'lblTAXI_TICKET_URL
        '
        Me.lblTAXI_TICKET_URL.Height = 0.1968504!
        Me.lblTAXI_TICKET_URL.HyperLink = Nothing
        Me.lblTAXI_TICKET_URL.Left = 0.00000001862645!
        Me.lblTAXI_TICKET_URL.Name = "lblTAXI_TICKET_URL"
        Me.lblTAXI_TICKET_URL.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblTAXI_TICKET_URL.Text = "タクチケ管理表保存場所URL"
        Me.lblTAXI_TICKET_URL.Top = 8.857903!
        Me.lblTAXI_TICKET_URL.Width = 1.925197!
        '
        'lblSEISAN_KANRYO
        '
        Me.lblSEISAN_KANRYO.Height = 0.1968504!
        Me.lblSEISAN_KANRYO.HyperLink = Nothing
        Me.lblSEISAN_KANRYO.Left = 0.00000001862645!
        Me.lblSEISAN_KANRYO.Name = "lblSEISAN_KANRYO"
        Me.lblSEISAN_KANRYO.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblSEISAN_KANRYO.Text = "精算完了"
        Me.lblSEISAN_KANRYO.Top = 9.254753!
        Me.lblSEISAN_KANRYO.Width = 1.925197!
        '
        'INSHOKUHI_TF
        '
        Me.INSHOKUHI_TF.CanGrow = False
        Me.INSHOKUHI_TF.DataField = "INSHOKUHI_TF"
        Me.INSHOKUHI_TF.Height = 0.1968504!
        Me.INSHOKUHI_TF.Left = 1.979921!
        Me.INSHOKUHI_TF.Name = "INSHOKUHI_TF"
        Me.INSHOKUHI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.INSHOKUHI_TF.Text = "1,234,567,890"
        Me.INSHOKUHI_TF.Top = 1.53972!
        Me.INSHOKUHI_TF.Width = 0.9681104!
        '
        'Label5
        '
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.948032!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label5.Text = "円"
        Me.Label5.Top = 1.53972!
        Me.Label5.Width = 0.2015748!
        '
        'HOTELHI_TF
        '
        Me.HOTELHI_TF.CanGrow = False
        Me.HOTELHI_TF.DataField = "HOTELHI_TF"
        Me.HOTELHI_TF.Height = 0.1968504!
        Me.HOTELHI_TF.Left = 1.972441!
        Me.HOTELHI_TF.Name = "HOTELHI_TF"
        Me.HOTELHI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.HOTELHI_TF.Text = "1,234,567,890"
        Me.HOTELHI_TF.Top = 2.224322!
        Me.HOTELHI_TF.Width = 0.9681104!
        '
        'Label6
        '
        Me.Label6.Height = 0.1968504!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.940552!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label6.Text = "円"
        Me.Label6.Top = 2.224322!
        Me.Label6.Width = 0.2015748!
        '
        'JR_TF
        '
        Me.JR_TF.CanGrow = False
        Me.JR_TF.DataField = "JR_TF"
        Me.JR_TF.Height = 0.1968504!
        Me.JR_TF.Left = 1.972441!
        Me.JR_TF.Name = "JR_TF"
        Me.JR_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.JR_TF.Text = "1,234,567,890"
        Me.JR_TF.Top = 2.525678!
        Me.JR_TF.Width = 0.9681104!
        '
        'Label31
        '
        Me.Label31.Height = 0.1968504!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 2.940552!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label31.Text = "円"
        Me.Label31.Top = 2.525678!
        Me.Label31.Width = 0.2015748!
        '
        'OTHER_TRAFFIC_TF
        '
        Me.OTHER_TRAFFIC_TF.CanGrow = False
        Me.OTHER_TRAFFIC_TF.DataField = "OTHER_TRAFFIC_TF"
        Me.OTHER_TRAFFIC_TF.Height = 0.1968504!
        Me.OTHER_TRAFFIC_TF.Left = 1.972441!
        Me.OTHER_TRAFFIC_TF.Name = "OTHER_TRAFFIC_TF"
        Me.OTHER_TRAFFIC_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.OTHER_TRAFFIC_TF.Text = "1,234,567,890"
        Me.OTHER_TRAFFIC_TF.Top = 2.827034!
        Me.OTHER_TRAFFIC_TF.Width = 0.9681104!
        '
        'Label32
        '
        Me.Label32.Height = 0.1968504!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 2.940552!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label32.Text = "円"
        Me.Label32.Top = 2.827034!
        Me.Label32.Width = 0.2015748!
        '
        'HOTEL_COMMISSION_TF
        '
        Me.HOTEL_COMMISSION_TF.CanGrow = False
        Me.HOTEL_COMMISSION_TF.DataField = "HOTEL_COMMISSION_TF"
        Me.HOTEL_COMMISSION_TF.Height = 0.1968504!
        Me.HOTEL_COMMISSION_TF.Left = 1.972441!
        Me.HOTEL_COMMISSION_TF.Name = "HOTEL_COMMISSION_TF"
        Me.HOTEL_COMMISSION_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.HOTEL_COMMISSION_TF.Text = "1,234,567,890"
        Me.HOTEL_COMMISSION_TF.Top = 3.12839!
        Me.HOTEL_COMMISSION_TF.Width = 0.9681104!
        '
        'Label33
        '
        Me.Label33.Height = 0.1968504!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 2.940552!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label33.Text = "円"
        Me.Label33.Top = 3.12839!
        Me.Label33.Width = 0.2015748!
        '
        'OTHER_TF
        '
        Me.OTHER_TF.CanGrow = False
        Me.OTHER_TF.DataField = "OTHER_TF"
        Me.OTHER_TF.Height = 0.1968504!
        Me.OTHER_TF.Left = 1.972441!
        Me.OTHER_TF.Name = "OTHER_TF"
        Me.OTHER_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.OTHER_TF.Text = "1,234,567,890"
        Me.OTHER_TF.Top = 3.429746!
        Me.OTHER_TF.Width = 0.9681104!
        '
        'Label38
        '
        Me.Label38.Height = 0.1968504!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 2.940552!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label38.Text = "円"
        Me.Label38.Top = 3.429746!
        Me.Label38.Width = 0.2015748!
        '
        'TAXI_TF
        '
        Me.TAXI_TF.CanGrow = False
        Me.TAXI_TF.DataField = "TAXI_TF"
        Me.TAXI_TF.Height = 0.1968504!
        Me.TAXI_TF.Left = 1.972441!
        Me.TAXI_TF.Name = "TAXI_TF"
        Me.TAXI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.TAXI_TF.Text = "1,234,567,890"
        Me.TAXI_TF.Top = 3.731103!
        Me.TAXI_TF.Width = 0.9681104!
        '
        'Label49
        '
        Me.Label49.Height = 0.1968504!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 2.940552!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label49.Text = "円"
        Me.Label49.Top = 3.731103!
        Me.Label49.Width = 0.2015748!
        '
        'KAIJOUHI_T
        '
        Me.KAIJOUHI_T.CanGrow = False
        Me.KAIJOUHI_T.DataField = "KAIJOUHI_T"
        Me.KAIJOUHI_T.Height = 0.1968504!
        Me.KAIJOUHI_T.Left = 1.979921!
        Me.KAIJOUHI_T.Name = "KAIJOUHI_T"
        Me.KAIJOUHI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KAIJOUHI_T.Text = "1,234,567,890"
        Me.KAIJOUHI_T.Top = 4.748032!
        Me.KAIJOUHI_T.Width = 0.9681104!
        '
        'Label50
        '
        Me.Label50.Height = 0.1968504!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 2.948032!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label50.Text = "円"
        Me.Label50.Top = 4.748032!
        Me.Label50.Width = 0.2015748!
        '
        'INSHOKUHI_T
        '
        Me.INSHOKUHI_T.CanGrow = False
        Me.INSHOKUHI_T.DataField = "INSHOKUHI_T"
        Me.INSHOKUHI_T.Height = 0.1968504!
        Me.INSHOKUHI_T.Left = 1.979921!
        Me.INSHOKUHI_T.Name = "INSHOKUHI_T"
        Me.INSHOKUHI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.INSHOKUHI_T.Text = "1,234,567,890"
        Me.INSHOKUHI_T.Top = 5.049212!
        Me.INSHOKUHI_T.Width = 0.9681104!
        '
        'Label51
        '
        Me.Label51.Height = 0.1968504!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 2.948032!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label51.Text = "円"
        Me.Label51.Top = 5.049212!
        Me.Label51.Width = 0.2015748!
        '
        'JINKENHI_T
        '
        Me.JINKENHI_T.CanGrow = False
        Me.JINKENHI_T.DataField = "JINKENHI_T"
        Me.JINKENHI_T.Height = 0.1968504!
        Me.JINKENHI_T.Left = 1.979921!
        Me.JINKENHI_T.Name = "JINKENHI_T"
        Me.JINKENHI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.JINKENHI_T.Text = "1,234,567,890"
        Me.JINKENHI_T.Top = 5.753937!
        Me.JINKENHI_T.Width = 0.9681104!
        '
        'Label52
        '
        Me.Label52.Height = 0.1968504!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 2.948032!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label52.Text = "円"
        Me.Label52.Top = 5.753937!
        Me.Label52.Width = 0.2015748!
        '
        'KANRIHI_T
        '
        Me.KANRIHI_T.CanGrow = False
        Me.KANRIHI_T.DataField = "KANRIHI_T"
        Me.KANRIHI_T.Height = 0.1968504!
        Me.KANRIHI_T.Left = 1.979921!
        Me.KANRIHI_T.Name = "KANRIHI_T"
        Me.KANRIHI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KANRIHI_T.Text = "1,234,567,890"
        Me.KANRIHI_T.Top = 6.055119!
        Me.KANRIHI_T.Width = 0.9681104!
        '
        'Label53
        '
        Me.Label53.Height = 0.1968504!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 2.948032!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label53.Text = "円"
        Me.Label53.Top = 6.055119!
        Me.Label53.Width = 0.2015748!
        '
        'HOTELHI_TOZEI
        '
        Me.HOTELHI_TOZEI.CanGrow = False
        Me.HOTELHI_TOZEI.DataField = "HOTELHI_TOZEI"
        Me.HOTELHI_TOZEI.Height = 0.1968504!
        Me.HOTELHI_TOZEI.Left = 4.642914!
        Me.HOTELHI_TOZEI.Name = "HOTELHI_TOZEI"
        Me.HOTELHI_TOZEI.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.HOTELHI_TOZEI.Text = "1,234,567,890"
        Me.HOTELHI_TOZEI.Top = 2.224322!
        Me.HOTELHI_TOZEI.Width = 0.9681104!
        '
        'Label54
        '
        Me.Label54.Height = 0.1968504!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 5.611024!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label54.Text = "円"
        Me.Label54.Top = 2.224322!
        Me.Label54.Width = 0.2015748!
        '
        'AIR_TF
        '
        Me.AIR_TF.CanGrow = False
        Me.AIR_TF.DataField = "AIR_TF"
        Me.AIR_TF.Height = 0.1968504!
        Me.AIR_TF.Left = 4.642914!
        Me.AIR_TF.Name = "AIR_TF"
        Me.AIR_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.AIR_TF.Text = "1,234,567,890"
        Me.AIR_TF.Top = 2.525678!
        Me.AIR_TF.Width = 0.9681104!
        '
        'Label55
        '
        Me.Label55.Height = 0.1968504!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 5.611024!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label55.Text = "円"
        Me.Label55.Top = 2.525678!
        Me.Label55.Width = 0.2015748!
        '
        'TAXI_COMMISSION_TF
        '
        Me.TAXI_COMMISSION_TF.CanGrow = False
        Me.TAXI_COMMISSION_TF.DataField = "TAXI_COMMISSION_TF"
        Me.TAXI_COMMISSION_TF.Height = 0.1968504!
        Me.TAXI_COMMISSION_TF.Left = 4.642914!
        Me.TAXI_COMMISSION_TF.Name = "TAXI_COMMISSION_TF"
        Me.TAXI_COMMISSION_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.TAXI_COMMISSION_TF.Text = "1,234,567,890"
        Me.TAXI_COMMISSION_TF.Top = 2.827034!
        Me.TAXI_COMMISSION_TF.Width = 0.9681104!
        '
        'Label56
        '
        Me.Label56.Height = 0.1968504!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 5.611024!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label56.Text = "円"
        Me.Label56.Top = 2.827034!
        Me.Label56.Width = 0.2015748!
        '
        'JINKENHI_TF
        '
        Me.JINKENHI_TF.CanGrow = False
        Me.JINKENHI_TF.DataField = "JINKENHI_TF"
        Me.JINKENHI_TF.Height = 0.1968504!
        Me.JINKENHI_TF.Left = 4.642914!
        Me.JINKENHI_TF.Name = "JINKENHI_TF"
        Me.JINKENHI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.JINKENHI_TF.Text = "1,234,567,890"
        Me.JINKENHI_TF.Top = 3.12839!
        Me.JINKENHI_TF.Width = 0.9681104!
        '
        'Label57
        '
        Me.Label57.Height = 0.1968504!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 5.611024!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label57.Text = "円"
        Me.Label57.Top = 3.12839!
        Me.Label57.Width = 0.2015748!
        '
        'KANRIHI_TF
        '
        Me.KANRIHI_TF.CanGrow = False
        Me.KANRIHI_TF.DataField = "KANRIHI_TF"
        Me.KANRIHI_TF.Height = 0.1968504!
        Me.KANRIHI_TF.Left = 4.642914!
        Me.KANRIHI_TF.Name = "KANRIHI_TF"
        Me.KANRIHI_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KANRIHI_TF.Text = "1,234,567,890"
        Me.KANRIHI_TF.Top = 3.429746!
        Me.KANRIHI_TF.Width = 0.9681104!
        '
        'Label58
        '
        Me.Label58.Height = 0.1968504!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 5.611024!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label58.Text = "円"
        Me.Label58.Top = 3.429746!
        Me.Label58.Width = 0.2015748!
        '
        'TAXI_SEISAN_TF
        '
        Me.TAXI_SEISAN_TF.CanGrow = False
        Me.TAXI_SEISAN_TF.DataField = "TAXI_SEISAN_TF"
        Me.TAXI_SEISAN_TF.Height = 0.1968504!
        Me.TAXI_SEISAN_TF.Left = 4.642914!
        Me.TAXI_SEISAN_TF.Name = "TAXI_SEISAN_TF"
        Me.TAXI_SEISAN_TF.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.TAXI_SEISAN_TF.Text = "1,234,567,890"
        Me.TAXI_SEISAN_TF.Top = 3.731103!
        Me.TAXI_SEISAN_TF.Width = 0.9681104!
        '
        'Label59
        '
        Me.Label59.Height = 0.1968504!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 5.611024!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label59.Text = "円"
        Me.Label59.Top = 3.731103!
        Me.Label59.Width = 0.2015748!
        '
        'KIZAIHI_T
        '
        Me.KIZAIHI_T.CanGrow = False
        Me.KIZAIHI_T.DataField = "KIZAIHI_T"
        Me.KIZAIHI_T.Height = 0.1968504!
        Me.KIZAIHI_T.Left = 4.642914!
        Me.KIZAIHI_T.Name = "KIZAIHI_T"
        Me.KIZAIHI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KIZAIHI_T.Text = "1,234,567,890"
        Me.KIZAIHI_T.Top = 4.748032!
        Me.KIZAIHI_T.Width = 0.9681104!
        '
        'Label60
        '
        Me.Label60.Height = 0.1968504!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 5.611025!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label60.Text = "円"
        Me.Label60.Top = 4.748032!
        Me.Label60.Width = 0.2015748!
        '
        'OTHER_T
        '
        Me.OTHER_T.CanGrow = False
        Me.OTHER_T.DataField = "OTHER_T"
        Me.OTHER_T.Height = 0.1968504!
        Me.OTHER_T.Left = 4.642914!
        Me.OTHER_T.Name = "OTHER_T"
        Me.OTHER_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.OTHER_T.Text = "1,234,567,890"
        Me.OTHER_T.Top = 5.753937!
        Me.OTHER_T.Width = 0.9681104!
        '
        'Label61
        '
        Me.Label61.Height = 0.1968504!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 5.611025!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label61.Text = "円"
        Me.Label61.Top = 5.753937!
        Me.Label61.Width = 0.2015748!
        '
        'MR_HOTEL
        '
        Me.MR_HOTEL.CanGrow = False
        Me.MR_HOTEL.DataField = "MR_HOTEL"
        Me.MR_HOTEL.Height = 0.1968504!
        Me.MR_HOTEL.Left = 1.979921!
        Me.MR_HOTEL.Name = "MR_HOTEL"
        Me.MR_HOTEL.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.MR_HOTEL.Text = "1,234,567,890"
        Me.MR_HOTEL.Top = 7.135039!
        Me.MR_HOTEL.Width = 0.9681104!
        '
        'Label62
        '
        Me.Label62.Height = 0.1968504!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 2.948033!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label62.Text = "円"
        Me.Label62.Top = 7.134645!
        Me.Label62.Width = 0.2015748!
        '
        'MR_HOTEL_TOZEI
        '
        Me.MR_HOTEL_TOZEI.CanGrow = False
        Me.MR_HOTEL_TOZEI.DataField = "MR_HOTEL_TOZEI"
        Me.MR_HOTEL_TOZEI.Height = 0.1968504!
        Me.MR_HOTEL_TOZEI.Left = 1.972441!
        Me.MR_HOTEL_TOZEI.Name = "MR_HOTEL_TOZEI"
        Me.MR_HOTEL_TOZEI.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.MR_HOTEL_TOZEI.Text = "1,234,567,890"
        Me.MR_HOTEL_TOZEI.Top = 7.40748!
        Me.MR_HOTEL_TOZEI.Width = 0.9681104!
        '
        'Label63
        '
        Me.Label63.Height = 0.1968504!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 2.940552!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label63.Text = "円"
        Me.Label63.Top = 7.407085!
        Me.Label63.Width = 0.2015748!
        '
        'MR_JR
        '
        Me.MR_JR.CanGrow = False
        Me.MR_JR.DataField = "MR_JR"
        Me.MR_JR.Height = 0.1968504!
        Me.MR_JR.Left = 1.979921!
        Me.MR_JR.Name = "MR_JR"
        Me.MR_JR.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.MR_JR.Text = "1,234,567,890"
        Me.MR_JR.Top = 7.655905!
        Me.MR_JR.Width = 0.9681104!
        '
        'Label64
        '
        Me.Label64.Height = 0.1968504!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 2.940552!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label64.Text = "円"
        Me.Label64.Top = 7.655904!
        Me.Label64.Width = 0.2015748!
        '
        'TAXI_T
        '
        Me.TAXI_T.CanGrow = False
        Me.TAXI_T.DataField = "TAXI_T"
        Me.TAXI_T.Height = 0.1968504!
        Me.TAXI_T.Left = 1.972441!
        Me.TAXI_T.Name = "TAXI_T"
        Me.TAXI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.TAXI_T.Text = "1,234,567,890"
        Me.TAXI_T.Top = 8.335051!
        Me.TAXI_T.Width = 0.9681104!
        '
        'Label65
        '
        Me.Label65.Height = 0.1968504!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 2.940552!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label65.Text = "円"
        Me.Label65.Top = 8.334656!
        Me.Label65.Width = 0.2015748!
        '
        'TAXI_SEISAN_T
        '
        Me.TAXI_SEISAN_T.CanGrow = False
        Me.TAXI_SEISAN_T.DataField = "TAXI_SEISAN_T"
        Me.TAXI_SEISAN_T.Height = 0.1968504!
        Me.TAXI_SEISAN_T.Left = 1.972441!
        Me.TAXI_SEISAN_T.Name = "TAXI_SEISAN_T"
        Me.TAXI_SEISAN_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.TAXI_SEISAN_T.Text = "1,234,567,890"
        Me.TAXI_SEISAN_T.Top = 8.586634!
        Me.TAXI_SEISAN_T.Width = 0.9681104!
        '
        'Label66
        '
        Me.Label66.Height = 0.1968504!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 2.940552!
        Me.Label66.Name = "Label66"
        Me.Label66.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label66.Text = "円"
        Me.Label66.Top = 8.586239!
        Me.Label66.Width = 0.2015748!
        '
        'SEISANSHO_URL
        '
        Me.SEISANSHO_URL.CanGrow = False
        Me.SEISANSHO_URL.DataField = "SEISANSHO_URL"
        Me.SEISANSHO_URL.Height = 0.1968504!
        Me.SEISANSHO_URL.Left = 1.979921!
        Me.SEISANSHO_URL.Name = "SEISANSHO_URL"
        Me.SEISANSHO_URL.Style = "font-family: ＭＳ ゴシック; text-align: left; white-space: nowrap"
        Me.SEISANSHO_URL.Text = Nothing
        Me.SEISANSHO_URL.Top = 7.93819!
        Me.SEISANSHO_URL.Width = 5.395277!
        '
        'TAXI_TICKET_URL
        '
        Me.TAXI_TICKET_URL.CanGrow = False
        Me.TAXI_TICKET_URL.DataField = "TAXI_TICKET_URL"
        Me.TAXI_TICKET_URL.Height = 0.1968504!
        Me.TAXI_TICKET_URL.Left = 1.979921!
        Me.TAXI_TICKET_URL.Name = "TAXI_TICKET_URL"
        Me.TAXI_TICKET_URL.Style = "font-family: ＭＳ ゴシック; text-align: left; white-space: nowrap"
        Me.TAXI_TICKET_URL.Text = Nothing
        Me.TAXI_TICKET_URL.Top = 8.857903!
        Me.TAXI_TICKET_URL.Width = 5.395277!
        '
        'SEISAN_KANRYO
        '
        Me.SEISAN_KANRYO.CanGrow = False
        Me.SEISAN_KANRYO.DataField = "SEISAN_KANRYO"
        Me.SEISAN_KANRYO.Height = 0.1968504!
        Me.SEISAN_KANRYO.Left = 1.979921!
        Me.SEISAN_KANRYO.Name = "SEISAN_KANRYO"
        Me.SEISAN_KANRYO.Style = "font-family: ＭＳ ゴシック; text-align: left; white-space: nowrap"
        Me.SEISAN_KANRYO.Text = Nothing
        Me.SEISAN_KANRYO.Top = 9.254753!
        Me.SEISAN_KANRYO.Width = 5.395277!
        '
        'lblKEI_991330401_T
        '
        Me.lblKEI_991330401_T.Height = 0.1968504!
        Me.lblKEI_991330401_T.HyperLink = Nothing
        Me.lblKEI_991330401_T.Left = 5.850788!
        Me.lblKEI_991330401_T.Name = "lblKEI_991330401_T"
        Me.lblKEI_991330401_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKEI_991330401_T.Text = "小計"
        Me.lblKEI_991330401_T.Top = 5.049212!
        Me.lblKEI_991330401_T.Width = 0.4275589!
        '
        'KEI_991330401_T
        '
        Me.KEI_991330401_T.CanGrow = False
        Me.KEI_991330401_T.DataField = "KEI_991330401_T"
        Me.KEI_991330401_T.Height = 0.1968504!
        Me.KEI_991330401_T.Left = 6.278347!
        Me.KEI_991330401_T.Name = "KEI_991330401_T"
        Me.KEI_991330401_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KEI_991330401_T.Text = "1,234,567,890"
        Me.KEI_991330401_T.Top = 5.049212!
        Me.KEI_991330401_T.Width = 0.9681104!
        '
        'Label9
        '
        Me.Label9.Height = 0.1968504!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 7.246452!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label9.Text = "円"
        Me.Label9.Top = 5.049212!
        Me.Label9.Width = 0.2015748!
        '
        'lblKEI_41120200_T
        '
        Me.lblKEI_41120200_T.Height = 0.1968504!
        Me.lblKEI_41120200_T.HyperLink = Nothing
        Me.lblKEI_41120200_T.Left = 5.850788!
        Me.lblKEI_41120200_T.Name = "lblKEI_41120200_T"
        Me.lblKEI_41120200_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKEI_41120200_T.Text = "小計"
        Me.lblKEI_41120200_T.Top = 6.055119!
        Me.lblKEI_41120200_T.Width = 0.4275589!
        '
        'KEI_41120200_T
        '
        Me.KEI_41120200_T.CanGrow = False
        Me.KEI_41120200_T.DataField = "KEI_41120200_T"
        Me.KEI_41120200_T.Height = 0.1968504!
        Me.KEI_41120200_T.Left = 6.278347!
        Me.KEI_41120200_T.Name = "KEI_41120200_T"
        Me.KEI_41120200_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KEI_41120200_T.Text = "1,234,567,890"
        Me.KEI_41120200_T.Top = 6.055119!
        Me.KEI_41120200_T.Width = 0.9681104!
        '
        'Label11
        '
        Me.Label11.Height = 0.1968504!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 7.246452!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label11.Text = "円"
        Me.Label11.Top = 6.055119!
        Me.Label11.Width = 0.2015748!
        '
        'lblKEI_T
        '
        Me.lblKEI_T.Height = 0.1968508!
        Me.lblKEI_T.HyperLink = Nothing
        Me.lblKEI_T.Left = 5.469686!
        Me.lblKEI_T.Name = "lblKEI_T"
        Me.lblKEI_T.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.lblKEI_T.Text = "課税金額計"
        Me.lblKEI_T.Top = 6.491733!
        Me.lblKEI_T.Width = 0.8086634!
        '
        'KEI_T
        '
        Me.KEI_T.CanGrow = False
        Me.KEI_T.DataField = "KEI_T"
        Me.KEI_T.Height = 0.1968504!
        Me.KEI_T.Left = 6.278345!
        Me.KEI_T.Name = "KEI_T"
        Me.KEI_T.Style = "font-family: ＭＳ ゴシック; text-align: right; white-space: nowrap"
        Me.KEI_T.Text = "1,234,567,890"
        Me.KEI_T.Top = 6.491733!
        Me.KEI_T.Width = 0.9681104!
        '
        'Label13
        '
        Me.Label13.Height = 0.1968504!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 7.246457!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label13.Text = "円"
        Me.Label13.Top = 6.491733!
        Me.Label13.Width = 0.2015748!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.01041667!
        Me.PageFooter.Name = "PageFooter"
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 4.354331!
        Me.Line4.Width = 7.490944!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.490944!
        Me.Line4.Y1 = 4.354331!
        Me.Line4.Y2 = 4.354331!
        '
        'Line5
        '
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.5511811!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.850394!
        Me.Line5.Width = 6.939763!
        Me.Line5.X1 = 0.5511811!
        Me.Line5.X2 = 7.490944!
        Me.Line5.Y1 = 1.850394!
        Me.Line5.Y2 = 1.850394!
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 6.768505!
        Me.Line6.Width = 7.490944!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 7.490944!
        Me.Line6.Y1 = 6.768505!
        Me.Line6.Y2 = 6.768505!
        '
        'Line8
        '
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.5287402!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 5.348425!
        Me.Line8.Width = 6.939763!
        Me.Line8.X1 = 0.5287402!
        Me.Line8.X2 = 7.468503!
        Me.Line8.Y1 = 5.348425!
        Me.Line8.Y2 = 5.348425!
        '
        'Line9
        '
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.5287402!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 4.009056!
        Me.Line9.Width = 6.939763!
        Me.Line9.X1 = 0.5287402!
        Me.Line9.X2 = 7.468503!
        Me.Line9.Y1 = 4.009056!
        Me.Line9.Y2 = 4.009056!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.5287402!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 6.3563!
        Me.Line10.Width = 6.939759!
        Me.Line10.X1 = 0.5287402!
        Me.Line10.X2 = 7.468499!
        Me.Line10.Y1 = 6.3563!
        Me.Line10.Y2 = 6.3563!
        '
        'SeisanRegistReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.537404!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSHIHARAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSEISAN_YM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHIHARAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEISAN_YM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOUNIN_KUBUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSHOUNIN_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEIKYU_NO_TOPTOUR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHOUNIN_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl991330401_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKAIJOHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblINSHOKUHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHOTELHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHOTEL_COMMISSION_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOTHER_TRAFFIC_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJR_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKIZAIHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHOTELHI_TOZEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKANRIHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAIR_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTAXI_COMMISSION_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJINKENHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOTHER_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTAXI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTAXI_SEISAN_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAIJOHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIZAIHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKEI_991330401_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KEI_991330401_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKEI_41120200_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KEI_41120200_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKEI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KEI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl41120200_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl991330401_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKAIJOUHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblINSHOKUHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKIZAIHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblJINKENHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl41120200_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblOTHER_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKANRIHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMR_HOTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMR_JR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblMR_HOTEL_TOZEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSEISANSHO_URL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTAXI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTAXI_SEISAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTAXI_TICKET_URL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSEISAN_KANRYO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSHOKUHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTELHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JR_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_TRAFFIC_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTEL_COMMISSION_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAIJOUHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INSHOKUHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JINKENHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KANRIHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTELHI_TOZEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AIR_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_COMMISSION_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JINKENHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KANRIHI_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_SEISAN_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIZAIHI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_HOTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_HOTEL_TOZEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_JR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_SEISAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEISANSHO_URL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_TICKET_URL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEISAN_KANRYO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKEI_991330401_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KEI_991330401_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKEI_41120200_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KEI_41120200_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblKEI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KEI_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents PrintDate As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents LOGIN_USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents LabelPage As DataDynamics.ActiveReports.Label
    Private WithEvents PageCount As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageTotal As DataDynamics.ActiveReports.TextBox
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents lblKOUENKAI_NO As DataDynamics.ActiveReports.Label
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents lblSHIHARAI_NO As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape3 As DataDynamics.ActiveReports.Shape
    Private WithEvents Shape4 As DataDynamics.ActiveReports.Shape
    Private WithEvents lblSEISAN_YM As DataDynamics.ActiveReports.Label
    Private WithEvents lblSHOUNIN_KUBUN As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHIHARAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents SEISAN_YM As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHOUNIN_KUBUN As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblSEIKYU_NO_TOPTOUR As DataDynamics.ActiveReports.Label
    Private WithEvents lblSHOUNIN_DATE As DataDynamics.ActiveReports.Label
    Private WithEvents SEIKYU_NO_TOPTOUR As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHOUNIN_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape5 As DataDynamics.ActiveReports.Shape
    Private WithEvents lblTF As DataDynamics.ActiveReports.Label
    Private WithEvents lbl991330401_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblKAIJOHI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblINSHOKUHI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblHOTELHI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblHOTEL_COMMISSION_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblOTHER_TRAFFIC_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblJR_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblKIZAIHI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblHOTELHI_TOZEI As DataDynamics.ActiveReports.Label
    Private WithEvents lblKANRIHI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblAIR_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblTAXI_COMMISSION_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblJINKENHI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblOTHER_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblTAXI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lblTAXI_SEISAN_TF As DataDynamics.ActiveReports.Label
    Private WithEvents KAIJOHI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents KIZAIHI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents lblKEI_991330401_TF As DataDynamics.ActiveReports.Label
    Private WithEvents KEI_991330401_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents lblKEI_41120200_TF As DataDynamics.ActiveReports.Label
    Private WithEvents KEI_41120200_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents lblKEI_TF As DataDynamics.ActiveReports.Label
    Private WithEvents KEI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents lblT As DataDynamics.ActiveReports.Label
    Private WithEvents lbl41120200_TF As DataDynamics.ActiveReports.Label
    Private WithEvents lbl991330401_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblKAIJOUHI_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblINSHOKUHI_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblKIZAIHI_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblJINKENHI_T As DataDynamics.ActiveReports.Label
    Private WithEvents lbl41120200_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblOTHER_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblKANRIHI_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblMR_HOTEL As DataDynamics.ActiveReports.Label
    Private WithEvents lblMR_JR As DataDynamics.ActiveReports.Label
    Private WithEvents lblMR_HOTEL_TOZEI As DataDynamics.ActiveReports.Label
    Private WithEvents lblSEISANSHO_URL As DataDynamics.ActiveReports.Label
    Private WithEvents lblTAXI_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblTAXI_SEISAN_T As DataDynamics.ActiveReports.Label
    Private WithEvents lblTAXI_TICKET_URL As DataDynamics.ActiveReports.Label
    Private WithEvents lblSEISAN_KANRYO As DataDynamics.ActiveReports.Label
    Private WithEvents INSHOKUHI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents HOTELHI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents JR_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents OTHER_TRAFFIC_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents HOTEL_COMMISSION_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents OTHER_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label38 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label49 As DataDynamics.ActiveReports.Label
    Private WithEvents KAIJOUHI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label50 As DataDynamics.ActiveReports.Label
    Private WithEvents INSHOKUHI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label51 As DataDynamics.ActiveReports.Label
    Private WithEvents JINKENHI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label52 As DataDynamics.ActiveReports.Label
    Private WithEvents KANRIHI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label53 As DataDynamics.ActiveReports.Label
    Private WithEvents HOTELHI_TOZEI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label54 As DataDynamics.ActiveReports.Label
    Private WithEvents AIR_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label55 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_COMMISSION_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label56 As DataDynamics.ActiveReports.Label
    Private WithEvents JINKENHI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label57 As DataDynamics.ActiveReports.Label
    Private WithEvents KANRIHI_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label58 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_SEISAN_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label59 As DataDynamics.ActiveReports.Label
    Private WithEvents KIZAIHI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label60 As DataDynamics.ActiveReports.Label
    Private WithEvents OTHER_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label61 As DataDynamics.ActiveReports.Label
    Private WithEvents MR_HOTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label62 As DataDynamics.ActiveReports.Label
    Private WithEvents MR_HOTEL_TOZEI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label63 As DataDynamics.ActiveReports.Label
    Private WithEvents MR_JR As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label64 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label65 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_SEISAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label66 As DataDynamics.ActiveReports.Label
    Private WithEvents SEISANSHO_URL As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_TICKET_URL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SEISAN_KANRYO As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblKEI_991330401_T As DataDynamics.ActiveReports.Label
    Private WithEvents KEI_991330401_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents lblKEI_41120200_T As DataDynamics.ActiveReports.Label
    Private WithEvents KEI_41120200_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents lblKEI_T As DataDynamics.ActiveReports.Label
    Private WithEvents KEI_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
End Class 
