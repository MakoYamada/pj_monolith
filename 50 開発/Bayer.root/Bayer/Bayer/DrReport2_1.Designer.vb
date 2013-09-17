<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrReport2_1 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrReport2_1))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label8, Me.TextBox7, Me.TextBox1, Me.Label11, Me.Label1, Me.TextBox2})
        Me.Detail.Height = 0.3854166!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
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
        Me.Label8.Height = 0.396063!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: Gainsboro; vertical-align: middle"
        Me.Label8.Text = "行程１"
        Me.Label8.Top = 0.0!
        Me.Label8.Width = 1.0!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.DataField = "DR_MPID"
        Me.TextBox7.Height = 0.396063!
        Me.TextBox7.Left = 1.0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.9377952!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.DataField = "DR_MPID"
        Me.TextBox1.Height = 0.1979167!
        Me.TextBox1.Left = 2.624803!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.9377952!
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
        Me.Label11.Left = 1.937795!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "background-color: Gainsboro"
        Me.Label11.Text = "発地"
        Me.Label11.Top = 0.0!
        Me.Label11.Width = 0.6870079!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.1979167!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.937795!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: Gainsboro"
        Me.Label1.Text = "席区分"
        Me.Label1.Top = 0.1980315!
        Me.Label1.Width = 0.6870079!
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
        Me.TextBox2.DataField = "DR_MPID"
        Me.TextBox2.Height = 0.1979167!
        Me.TextBox2.Left = 2.624803!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.1980315!
        Me.TextBox2.Width = 0.9377952!
        '
        'DrReport2_1
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.0!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
End Class 
