Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class DrReport2_1 

    Dim detailCounter As Integer = 0 '行番号

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        detailCounter += 1
        Me.txtNo.Value = detailCounter
    End Sub
End Class
