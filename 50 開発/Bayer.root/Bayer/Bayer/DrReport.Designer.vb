<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrReport 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label35 = New DataDynamics.ActiveReports.Label
        Me.lblPrintDate = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.txtDrMpid = New DataDynamics.ActiveReports.TextBox
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
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
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport
        Me.txtKouenkaiNo = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.Label37 = New DataDynamics.ActiveReports.Label
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox
        Me.Label38 = New DataDynamics.ActiveReports.Label
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox25 = New DataDynamics.ActiveReports.TextBox
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.TextBox26 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox27 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox28 = New DataDynamics.ActiveReports.TextBox
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox31 = New DataDynamics.ActiveReports.TextBox
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.TextBox32 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox33 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox34 = New DataDynamics.ActiveReports.TextBox
        Me.Label44 = New DataDynamics.ActiveReports.Label
        Me.Label45 = New DataDynamics.ActiveReports.Label
        Me.TextBox35 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox36 = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDrMpid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtKouenkaiNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.Label35, Me.lblPrintDate})
        Me.PageHeader.Height = 0.4791667!
        Me.PageHeader.Name = "PageHeader"
        '
        'Label1
        '
        Me.Label1.Height = 0.3125!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.968849!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 16pt"
        Me.Label1.Text = "講演会参加ドクター情報・手配状況"
        Me.Label1.Top = 0.1354167!
        Me.Label1.Width = 3.312533!
        '
        'Label35
        '
        Me.Label35.Height = 0.21875!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 5.323229!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = ""
        Me.Label35.Text = "Print:"
        Me.Label35.Top = 0.05196851!
        Me.Label35.Width = 0.3854327!
        '
        'lblPrintDate
        '
        Me.lblPrintDate.Height = 0.21875!
        Me.lblPrintDate.HyperLink = Nothing
        Me.lblPrintDate.Left = 5.708662!
        Me.lblPrintDate.Name = "lblPrintDate"
        Me.lblPrintDate.Style = ""
        Me.lblPrintDate.Text = "yyyy/MM/dd HH:mm:ss"
        Me.lblPrintDate.Top = 0.05196851!
        Me.lblPrintDate.Width = 1.47874!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3, Me.Label4, Me.TextBox1, Me.Label5, Me.TextBox2, Me.TextBox3, Me.Label6, Me.TextBox4, Me.Label7, Me.Label8, Me.Label9, Me.TextBox5, Me.Label10, Me.TextBox6, Me.Label11, Me.txtDrMpid, Me.TextBox8, Me.TextBox9, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Line1, Me.Line2, Me.SubReport1, Me.txtKouenkaiNo, Me.TextBox11, Me.TextBox12, Me.Label36, Me.TextBox13, Me.Label37, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.Label38, Me.Label39, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.Label40, Me.TextBox24, Me.TextBox25, Me.Label41, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.Label42, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.Label43, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.Label44, Me.Label45, Me.TextBox35, Me.TextBox36})
        Me.Detail.Height = 10.76088!
        Me.Detail.Name = "Detail"
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.DimGray
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftColor = System.Drawing.Color.DimGray
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightColor = System.Drawing.Color.DimGray
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopColor = System.Drawing.Color.DimGray
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.1979167!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.06259843!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: Gainsboro; text-align: center"
        Me.Label3.Text = "＜会合情報＞"
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 7.020473!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.DimGray
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftColor = System.Drawing.Color.DimGray
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightColor = System.Drawing.Color.DimGray
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopColor = System.Drawing.Color.DimGray
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.1979167!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.06259842!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: Gainsboro"
        Me.Label4.Text = "会合名"
        Me.Label4.Top = 0.1992126!
        Me.Label4.Width = 1.0!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.DimGray
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.DimGray
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightColor = System.Drawing.Color.DimGray
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopColor = System.Drawing.Color.DimGray
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.DataField = "KOUENKAI_NAME"
        Me.TextBox1.Height = 0.1979167!
        Me.TextBox1.Left = 1.062598!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Top = 0.1992126!
        Me.TextBox1.Width = 6.020473!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.1979167!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.06259842!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "background-color: Gainsboro"
        Me.Label5.Text = "実施日時"
        Me.Label5.Top = 0.3972442!
        Me.Label5.Width = 1.0!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.DataField = "DR_NAME"
        Me.TextBox2.Height = 0.1979167!
        Me.TextBox2.Left = 1.062598!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 1.012599!
        Me.TextBox2.Width = 1.541339!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "FROM_DATE"
        Me.TextBox3.Height = 0.1665355!
        Me.TextBox3.Left = 1.093701!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.4074804!
        Me.TextBox3.Width = 0.7291337!
        '
        'Label6
        '
        Me.Label6.Height = 0.1767717!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 1.822835!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: center"
        Me.Label6.Text = "～"
        Me.Label6.Top = 0.3972442!
        Me.Label6.Width = 0.2602363!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "TO_DATE"
        Me.TextBox4.Height = 0.1665354!
        Me.TextBox4.Left = 2.083071!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.4074804!
        Me.TextBox4.Width = 0.7291338!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.1979167!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.06259843!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: Gainsboro; text-align: center"
        Me.Label7.Text = "＜ドクター情報＞"
        Me.Label7.Top = 0.8145671!
        Me.Label7.Width = 7.020473!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label8.Height = 0.1979167!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.06259843!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: Gainsboro"
        Me.Label8.Text = "氏名（漢字）"
        Me.Label8.Top = 1.012599!
        Me.Label8.Width = 1.0!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Height = 0.5940946!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.06259843!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "background-color: Gainsboro; vertical-align: middle"
        Me.Label9.Text = "施設・所属機関"
        Me.Label9.Top = 1.21063!
        Me.Label9.Width = 1.0!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.DataField = "DR_SHISETSU_NAME"
        Me.TextBox5.Height = 0.1979167!
        Me.TextBox5.Left = 1.062598!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 1.21063!
        Me.TextBox5.Width = 6.020473!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.1979167!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 2.603938!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "background-color: Gainsboro"
        Me.Label10.Text = "フリガナ"
        Me.Label10.Top = 1.012599!
        Me.Label10.Width = 1.0!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.DataField = "DR_KANA"
        Me.TextBox6.Height = 0.1979167!
        Me.TextBox6.Left = 3.603938!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 1.012599!
        Me.TextBox6.Width = 1.541339!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Height = 0.1979167!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 5.145276!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "background-color: Gainsboro"
        Me.Label11.Text = "医師コード"
        Me.Label11.Top = 1.012599!
        Me.Label11.Width = 1.0!
        '
        'txtDrMpid
        '
        Me.txtDrMpid.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDrMpid.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDrMpid.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDrMpid.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDrMpid.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDrMpid.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDrMpid.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtDrMpid.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtDrMpid.DataField = "DR_MPID"
        Me.txtDrMpid.Height = 0.1979167!
        Me.txtDrMpid.Left = 6.145276!
        Me.txtDrMpid.Name = "txtDrMpid"
        Me.txtDrMpid.Text = Nothing
        Me.txtDrMpid.Top = 1.012599!
        Me.txtDrMpid.Width = 0.9377952!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.1979167!
        Me.TextBox8.Left = 1.062598!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 1.408662!
        Me.TextBox8.Width = 6.020473!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.1979167!
        Me.TextBox9.Left = 1.062598!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 1.606693!
        Me.TextBox9.Width = 6.020473!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label12.Height = 0.1979167!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.06259843!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "background-color: Gainsboro"
        Me.Label12.Text = "世話人会参加"
        Me.Label12.Top = 1.804725!
        Me.Label12.Width = 1.0!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.1979167!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.06259843!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "background-color: Gainsboro"
        Me.Label13.Text = "担当者"
        Me.Label13.Top = 2.002756!
        Me.Label13.Width = 1.0!
        '
        'Label14
        '
        Me.Label14.Height = 0.1979167!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.06259844!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "text-align: left"
        Me.Label14.Text = "チケット送付先"
        Me.Label14.Top = 2.50461!
        Me.Label14.Width = 1.0!
        '
        'Label15
        '
        Me.Label15.Height = 0.1979167!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 1.062598!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "text-align: left"
        Me.Label15.Text = "担当者事業所（上記住所）"
        Me.Label15.Top = 2.504725!
        Me.Label15.Width = 3.510236!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.1979167!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.06259844!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "background-color: Gainsboro"
        Me.Label16.Text = "郵便番号"
        Me.Label16.Top = 2.702756!
        Me.Label16.Width = 1.0!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Height = 0.1979167!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.06259843!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "background-color: Gainsboro"
        Me.Label17.Text = "住所"
        Me.Label17.Top = 2.900788!
        Me.Label17.Width = 1.0!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Height = 0.1979167!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.06259844!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "background-color: Gainsboro"
        Me.Label18.Text = "宛先名"
        Me.Label18.Top = 3.098819!
        Me.Label18.Width = 1.0!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Height = 0.1979167!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.06259844!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "background-color: Gainsboro"
        Me.Label19.Text = "TEL"
        Me.Label19.Top = 3.296851!
        Me.Label19.Width = 1.0!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Height = 0.1979167!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.06259843!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "background-color: Gainsboro"
        Me.Label20.Text = "通信欄"
        Me.Label20.Top = 3.485433!
        Me.Label20.Width = 1.0!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Height = 0.1979167!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.06259844!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "background-color: Gainsboro; text-align: center"
        Me.Label21.Text = "＜宿泊手配＞"
        Me.Label21.Top = 3.882678!
        Me.Label21.Width = 7.020473!
        '
        'Label22
        '
        Me.Label22.Height = 0.1979167!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.06259844!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "text-align: left"
        Me.Label22.Text = "依頼内容"
        Me.Label22.Top = 4.08043!
        Me.Label22.Width = 1.0!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label23.Height = 0.1979167!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.06259844!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "background-color: Gainsboro"
        Me.Label23.Text = "宿泊手配"
        Me.Label23.Top = 4.278461!
        Me.Label23.Width = 1.0!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Height = 0.1979167!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.06259844!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "background-color: Gainsboro"
        Me.Label24.Text = "希望地"
        Me.Label24.Top = 4.476492!
        Me.Label24.Width = 1.0!
        '
        'Label25
        '
        Me.Label25.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Height = 0.1979167!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.06259844!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "background-color: Gainsboro"
        Me.Label25.Text = "チェックイン"
        Me.Label25.Top = 4.674524!
        Me.Label25.Width = 1.0!
        '
        'Label26
        '
        Me.Label26.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label26.Height = 0.5940946!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.06259844!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "background-color: Gainsboro; vertical-align: middle"
        Me.Label26.Text = "宿泊備考"
        Me.Label26.Top = 4.872555!
        Me.Label26.Width = 1.0!
        '
        'Label27
        '
        Me.Label27.Height = 0.1979167!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.06259844!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "text-align: left"
        Me.Label27.Text = "回答"
        Me.Label27.Top = 5.46665!
        Me.Label27.Width = 1.0!
        '
        'Label28
        '
        Me.Label28.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label28.Height = 0.1979167!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 0.06259844!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "background-color: DarkGray"
        Me.Label28.Text = "手配ステータス"
        Me.Label28.Top = 5.664681!
        Me.Label28.Width = 1.0!
        '
        'Label29
        '
        Me.Label29.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label29.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label29.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label29.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label29.Height = 0.1979167!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.06259844!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "background-color: DarkGray"
        Me.Label29.Text = "希望地"
        Me.Label29.Top = 5.862713!
        Me.Label29.Width = 1.0!
        '
        'Label30
        '
        Me.Label30.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label30.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label30.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label30.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label30.Height = 0.1979167!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.06259844!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "background-color: DarkGray"
        Me.Label30.Text = "チェックイン"
        Me.Label30.Top = 6.060744!
        Me.Label30.Width = 1.0!
        '
        'Label31
        '
        Me.Label31.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label31.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label31.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label31.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label31.Height = 0.1979167!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.06259844!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "background-color: DarkGray"
        Me.Label31.Text = "金額"
        Me.Label31.Top = 6.258777!
        Me.Label31.Width = 1.0!
        '
        'Label32
        '
        Me.Label32.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label32.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label32.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label32.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label32.Height = 0.5940946!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.06259844!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "background-color: DarkGray; vertical-align: middle"
        Me.Label32.Text = "宿泊回答備考"
        Me.Label32.Top = 6.456808!
        Me.Label32.Width = 1.0!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 1.062598!
        Me.Line1.LineColor = System.Drawing.Color.DimGray
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5952756!
        Me.Line1.Width = 6.020474!
        Me.Line1.X1 = 1.062598!
        Me.Line1.X2 = 7.083072!
        Me.Line1.Y1 = 0.5952756!
        Me.Line1.Y2 = 0.5952756!
        '
        'Line2
        '
        Me.Line2.Height = 0.1893701!
        Me.Line2.Left = 7.083072!
        Me.Line2.LineColor = System.Drawing.Color.DimGray
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.3972441!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 7.083072!
        Me.Line2.X2 = 7.083072!
        Me.Line2.Y1 = 0.3972441!
        Me.Line2.Y2 = 0.5866142!
        '
        'SubReport1
        '
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 0.6874022!
        Me.SubReport1.Left = 0.06259844!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.ReportName = "SubReport1"
        Me.SubReport1.Top = 10.04213!
        Me.SubReport1.Width = 7.020473!
        '
        'txtKouenkaiNo
        '
        Me.txtKouenkaiNo.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtKouenkaiNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKouenkaiNo.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtKouenkaiNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKouenkaiNo.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtKouenkaiNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKouenkaiNo.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.txtKouenkaiNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtKouenkaiNo.DataField = "KOUENKAI_NO"
        Me.txtKouenkaiNo.Height = 0.1456693!
        Me.txtKouenkaiNo.Left = 0.06259842!
        Me.txtKouenkaiNo.Name = "txtKouenkaiNo"
        Me.txtKouenkaiNo.Text = Nothing
        Me.txtKouenkaiNo.Top = 0.6688979!
        Me.txtKouenkaiNo.Visible = False
        Me.txtKouenkaiNo.Width = 0.2291339!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.25!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox7, Me.Label33, Me.TextBox10, Me.Label2, Me.Label34})
        Me.GroupHeader1.DataField = "DR_MPID"
        Me.GroupHeader1.Height = 0.2813977!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPage
        '
        'TextBox7
        '
        Me.TextBox7.Height = 0.2188977!
        Me.TextBox7.Left = 6.051969!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "text-align: right"
        Me.TextBox7.SummaryGroup = "GroupHeader1"
        Me.TextBox7.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox7.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.TextBox7.Text = "#"
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.177165!
        '
        'Label33
        '
        Me.Label33.Height = 0.21875!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 6.229134!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = ""
        Me.Label33.Text = "/"
        Me.Label33.Top = 0.0!
        Me.Label33.Width = 0.1354337!
        '
        'TextBox10
        '
        Me.TextBox10.Height = 0.2188977!
        Me.TextBox10.Left = 6.364567!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "text-align: right"
        Me.TextBox10.SummaryGroup = "GroupHeader1"
        Me.TextBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.TextBox10.Text = "##"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.177165!
        '
        'Label2
        '
        Me.Label2.Height = 0.21875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.916536!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "（"
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.1354337!
        '
        'Label34
        '
        Me.Label34.Height = 0.21875!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 6.541733!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = ""
        Me.Label34.Text = "ﾍﾟｰｼﾞ）"
        Me.Label34.Top = 0.0!
        Me.Label34.Width = 0.4692912!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.NewPage = DataDynamics.ActiveReports.NewPage.After
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.1979167!
        Me.TextBox11.Left = 1.062598!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 2.002756!
        Me.TextBox11.Width = 6.020473!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.1979167!
        Me.TextBox12.Left = 1.062598!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 1.804725!
        Me.TextBox12.Width = 1.340158!
        '
        'Label36
        '
        Me.Label36.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label36.Height = 0.1979167!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 2.405906!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "background-color: Gainsboro"
        Me.Label36.Text = "演者"
        Me.Label36.Top = 1.804725!
        Me.Label36.Width = 1.0!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.1979167!
        Me.TextBox13.Left = 3.405906!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 1.804725!
        Me.TextBox13.Width = 1.340158!
        '
        'Label37
        '
        Me.Label37.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label37.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label37.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label37.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label37.Height = 0.1979167!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 4.746063!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "background-color: Gainsboro"
        Me.Label37.Text = "座長"
        Me.Label37.Top = 1.804725!
        Me.Label37.Width = 1.0!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Height = 0.1979167!
        Me.TextBox14.Left = 5.746063!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 1.804725!
        Me.TextBox14.Width = 1.338583!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.1979167!
        Me.TextBox15.Left = 1.062598!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 2.702756!
        Me.TextBox15.Width = 6.020473!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Height = 0.1979167!
        Me.TextBox16.Left = 1.062598!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 2.900788!
        Me.TextBox16.Width = 6.020473!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.1979167!
        Me.TextBox17.Left = 1.062598!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 3.098819!
        Me.TextBox17.Width = 6.020473!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.1979167!
        Me.TextBox18.Left = 1.062598!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 3.296851!
        Me.TextBox18.Width = 6.020473!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.1979167!
        Me.TextBox19.Left = 1.062598!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Top = 3.485433!
        Me.TextBox19.Width = 6.020473!
        '
        'Label38
        '
        Me.Label38.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label38.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label38.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label38.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label38.Height = 0.1979167!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 2.405906!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "background-color: Gainsboro"
        Me.Label38.Text = "チェックアウト"
        Me.Label38.Top = 4.67441!
        Me.Label38.Width = 1.0!
        '
        'Label39
        '
        Me.Label39.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label39.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label39.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label39.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label39.Height = 0.1979167!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 3.572835!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "background-color: Gainsboro"
        Me.Label39.Text = "依頼内容"
        Me.Label39.Top = 4.278347!
        Me.Label39.Width = 1.0!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Height = 0.1979167!
        Me.TextBox20.Left = 1.062598!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 4.278347!
        Me.TextBox20.Width = 2.510237!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Height = 0.1979167!
        Me.TextBox21.Left = 4.572835!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 4.278347!
        Me.TextBox21.Width = 2.510237!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Height = 0.1979167!
        Me.TextBox22.Left = 1.062598!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 4.476772!
        Me.TextBox22.Width = 2.510236!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.1979167!
        Me.TextBox23.Left = 4.572835!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 4.476772!
        Me.TextBox23.Width = 2.510237!
        '
        'Label40
        '
        Me.Label40.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label40.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label40.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label40.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label40.Height = 0.1979167!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 3.572835!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "background-color: Gainsboro"
        Me.Label40.Text = "宿泊施設"
        Me.Label40.Top = 4.476772!
        Me.Label40.Width = 1.0!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Height = 0.1979167!
        Me.TextBox24.Left = 1.062598!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 4.67441!
        Me.TextBox24.Width = 1.340158!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Height = 0.1979167!
        Me.TextBox25.Left = 3.405906!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 4.67441!
        Me.TextBox25.Width = 1.340158!
        '
        'Label41
        '
        Me.Label41.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label41.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label41.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label41.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label41.Height = 0.1979167!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 4.746063!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "background-color: Gainsboro"
        Me.Label41.Text = "部屋タイプ"
        Me.Label41.Top = 4.67441!
        Me.Label41.Width = 1.0!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox26.Height = 0.1979167!
        Me.TextBox26.Left = 5.746063!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Text = Nothing
        Me.TextBox26.Top = 4.67441!
        Me.TextBox26.Width = 1.338583!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox27.Height = 0.594095!
        Me.TextBox27.Left = 1.062598!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Top = 4.872441!
        Me.TextBox27.Width = 6.020473!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox28.Height = 0.1979167!
        Me.TextBox28.Left = 1.062598!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Text = Nothing
        Me.TextBox28.Top = 5.664961!
        Me.TextBox28.Width = 2.510236!
        '
        'Label42
        '
        Me.Label42.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label42.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label42.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label42.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label42.Height = 0.1979167!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 3.572835!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "background-color: DarkGray"
        Me.Label42.Text = "手配内容"
        Me.Label42.Top = 5.664961!
        Me.Label42.Width = 1.0!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Height = 0.1979167!
        Me.TextBox29.Left = 4.57441!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 5.664961!
        Me.TextBox29.Width = 2.510236!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.1979167!
        Me.TextBox30.Left = 1.062598!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 5.862993!
        Me.TextBox30.Width = 2.510236!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox31.Height = 0.1979167!
        Me.TextBox31.Left = 4.57441!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 5.862993!
        Me.TextBox31.Width = 2.510236!
        '
        'Label43
        '
        Me.Label43.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label43.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label43.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label43.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label43.Height = 0.1979167!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 3.57441!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "background-color: DarkGray"
        Me.Label43.Text = "宿泊施設"
        Me.Label43.Top = 5.862993!
        Me.Label43.Width = 1.0!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox32.Height = 0.1979167!
        Me.TextBox32.Left = 1.061024!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 6.061024!
        Me.TextBox32.Width = 1.340158!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox33.Height = 0.1979167!
        Me.TextBox33.Left = 3.40433!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 6.061024!
        Me.TextBox33.Width = 1.340158!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox34.Height = 0.1979167!
        Me.TextBox34.Left = 5.744489!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Text = Nothing
        Me.TextBox34.Top = 6.061024!
        Me.TextBox34.Width = 1.338583!
        '
        'Label44
        '
        Me.Label44.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label44.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label44.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label44.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label44.Height = 0.1979167!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 2.405906!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "background-color: DarkGray"
        Me.Label44.Text = "チェックアウト"
        Me.Label44.Top = 6.061024!
        Me.Label44.Width = 1.0!
        '
        'Label45
        '
        Me.Label45.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label45.Height = 0.1979167!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 4.744489!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "background-color: DarkGray"
        Me.Label45.Text = "部屋タイプ"
        Me.Label45.Top = 6.061024!
        Me.Label45.Width = 1.0!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Height = 0.1979167!
        Me.TextBox35.Left = 1.061024!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Top = 6.259056!
        Me.TextBox35.Width = 6.020473!
        '
        'TextBox36
        '
        Me.TextBox36.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox36.Height = 0.594095!
        Me.TextBox36.Left = 1.061024!
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Top = 6.457087!
        Me.TextBox36.Width = 6.020473!
        '
        'DrReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.25023!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDrMpid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtKouenkaiNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents txtDrMpid As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
    Private WithEvents txtKouenkaiNo As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents Label35 As DataDynamics.ActiveReports.Label
    Private WithEvents lblPrintDate As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label36 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label37 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label38 As DataDynamics.ActiveReports.Label
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox25 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox26 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox27 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox28 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox31 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox32 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox33 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox34 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label44 As DataDynamics.ActiveReports.Label
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox35 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox36 As DataDynamics.ActiveReports.TextBox
End Class
