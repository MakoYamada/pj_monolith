Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class DrReport

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Dim rpt1 As New DrReport1
        Dim rpt2 As New DrReport2
        Dim rpt3 As New DrReport3
        Dim subDS As New DataDynamics.ActiveReports.DataSources.OleDBDataSource

        ' サブレポートのデータソースの接続文字列・SQL文を設定します。
        subDS = Me.DataSource
        rpt1.DataSource = subDS
        rpt2.DataSource = subDS
        rpt3.DataSource = subDS

        ' サブレポートコントロールにサブレポートオブジェクトをセットします。
        Me.SubReport1.Report = rpt1
        Me.SubReport2.Report = rpt2
        Me.SubReport3.Report = rpt3
    End Sub
End Class
