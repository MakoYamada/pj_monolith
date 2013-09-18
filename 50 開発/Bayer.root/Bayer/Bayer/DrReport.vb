Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class DrReport

    
    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

        Dim rpt As New DrReport2()

        Dim subDS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource

        ' サブレポートのデータソースの接続文字列・SQL文を設定します。
        subDS.ConnectionString = WebConfig.Db.ConnectionString

        '仮
        subDS.SQL = "SELECT *" _
               & " FROM TBL_KOTSUHOTEL TKH" _
               & " LEFT OUTER JOIN TBL_KOUENKAI TKE" _
               & " ON TKH.KOUENKAI_NO = TKE.KOUENKAI_NO" _
               & " WHERE TKH.kouenkai_no = '" & Me.txtKouenkaiNo.Text & "'" _
               & " and TKH.dr_mpid = '" & Me.txtDrMpid.Text & "'"

        rpt.DataSource = subDS

        ' サブレポートコントロールにサブレポートオブジェクトをセットします。
        Me.SubReport1.Report = rpt

    End Sub
End Class
