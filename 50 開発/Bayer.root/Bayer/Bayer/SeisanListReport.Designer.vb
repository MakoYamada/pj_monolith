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
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label8 = New DataDynamics.ActiveReports.Label
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Label8})
        Me.PageHeader.Height = 1.270833!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Height = 2.0!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.25!
        Me.PageFooter.Name = "PageFooter"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.3149607!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.7811024!
        Me.Shape1.Width = 11.02362!
        '
        'Label8
        '
        Me.Label8.Height = 0.2688977!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.724999!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "検索 精算データ一覧"
        Me.Label8.Top = 0.8015749!
        Me.Label8.Width = 1.770473!
        '
        'SeisanListReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.22047!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
End Class 
