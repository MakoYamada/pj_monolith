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
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.SubReport1 = New DataDynamics.ActiveReports.SubReport
        Me.PageBreak1 = New DataDynamics.ActiveReports.PageBreak
        Me.SubReport2 = New DataDynamics.ActiveReports.SubReport
        Me.PageBreak2 = New DataDynamics.ActiveReports.PageBreak
        Me.SubReport3 = New DataDynamics.ActiveReports.SubReport
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
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.SubReport1, Me.PageBreak1, Me.SubReport2, Me.PageBreak2, Me.SubReport3})
        Me.Detail.Height = 32.37008!
        Me.Detail.Name = "Detail"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'SubReport1
        '
        Me.SubReport1.CloseBorder = False
        Me.SubReport1.Height = 10.71496!
        Me.SubReport1.Left = 0.0!
        Me.SubReport1.Name = "SubReport1"
        Me.SubReport1.Report = Nothing
        Me.SubReport1.ReportName = "SubReport1"
        Me.SubReport1.Top = 0.0!
        Me.SubReport1.Width = 7.165355!
        '
        'PageBreak1
        '
        Me.PageBreak1.Height = 0.2!
        Me.PageBreak1.Left = 0.0!
        Me.PageBreak1.Name = "PageBreak1"
        Me.PageBreak1.Size = New System.Drawing.SizeF(7.165355!, 0.2!)
        Me.PageBreak1.Top = 10.71496!
        Me.PageBreak1.Width = 7.165355!
        '
        'SubReport2
        '
        Me.SubReport2.CloseBorder = False
        Me.SubReport2.Height = 11.92717!
        Me.SubReport2.Left = 0.0!
        Me.SubReport2.Name = "SubReport2"
        Me.SubReport2.Report = Nothing
        Me.SubReport2.ReportName = "SubReport2"
        Me.SubReport2.Top = 10.71496!
        Me.SubReport2.Width = 7.165355!
        '
        'PageBreak2
        '
        Me.PageBreak2.Height = 0.2!
        Me.PageBreak2.Left = 0.0!
        Me.PageBreak2.Name = "PageBreak2"
        Me.PageBreak2.Size = New System.Drawing.SizeF(7.165355!, 0.2!)
        Me.PageBreak2.Top = 22.64213!
        Me.PageBreak2.Width = 7.165355!
        '
        'SubReport3
        '
        Me.SubReport3.CloseBorder = False
        Me.SubReport3.Height = 9.727166!
        Me.SubReport3.Left = 0.0!
        Me.SubReport3.Name = "SubReport3"
        Me.SubReport3.Report = Nothing
        Me.SubReport3.ReportName = "SubReport3"
        Me.SubReport3.Top = 22.64213!
        Me.SubReport3.Width = 7.165355!
        '
        'DrReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.165355!
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
    Private WithEvents SubReport1 As DataDynamics.ActiveReports.SubReport
    Private WithEvents PageBreak1 As DataDynamics.ActiveReports.PageBreak
    Private WithEvents SubReport2 As DataDynamics.ActiveReports.SubReport
    Private WithEvents PageBreak2 As DataDynamics.ActiveReports.PageBreak
    Private WithEvents SubReport3 As DataDynamics.ActiveReports.SubReport
End Class
