Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class DrReport1 

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        Dim rpt As New DrReport1
        Dim subDS As New DataTable

        ' サブレポートのデータソースの接続文字列・SQL文を設定します。
        subDS = Me.DataSource
        rpt.DataSource = subDS
    End Sub
End Class
