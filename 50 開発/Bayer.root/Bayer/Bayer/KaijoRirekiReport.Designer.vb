<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class KaijoRirekiReport 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(KaijoRirekiReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Line1 = New DataDynamics.ActiveReports.Line
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.25!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line1})
        Me.Detail.Height = 2.0!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.25!
        Me.PageFooter.Name = "PageFooter"
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 2.770866!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.208268!
        Me.Line1.Width = 1.0!
        Me.Line1.X1 = 2.770866!
        Me.Line1.X2 = 3.770866!
        Me.Line1.Y1 = 1.208268!
        Me.Line1.Y2 = 1.208268!
        '
        'KaijoRirekiReport
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
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
End Class 
