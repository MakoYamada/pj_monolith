Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class DrReport3

    Private Sub DrReport3_FetchData(ByVal sender As Object, ByVal eArgs As DataDynamics.ActiveReports.ActiveReport.FetchEventArgs) Handles Me.FetchData

    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format

        'SetSubRep(New DrReport3_1(), Me.SubReport1)
        'SetSubRep(New DrReport3_1(), Me.SubReport2)
        'SetSubRep(New DrReport3_1(), Me.SubReport3)
        'SetSubRep(New DrReport3_1(), Me.SubReport4)



    End Sub

    'TODO:SQLも引数にしたい
    Private Sub SetSubRep(ByVal rpt As Object, ByVal ctlSubReport As DataDynamics.ActiveReports.SubReport)

        Dim subDS As New DataDynamics.ActiveReports.DataSources.SqlDBDataSource

        ' サブレポートのデータソースの接続文字列・SQL文を設定します。
        subDS.ConnectionString = WebConfig.Db.ConnectionString

        '仮
        'subDS.SQL = "select *" _
        '            & " from" _
        '            & "((select" _
        '            & " KOUENKAI_NO" _
        '            & ",DR_MPID" _
        '            & ",REQ_O_TEHAI_1 AS REQ_O_TEHAI" _
        '            & ",REQ_O_IRAINAIYOU_1 AS REQ_O_IRAINAIYOU" _
        '            & ",REQ_O_KOTSUKIKAN_1 AS REQ_O_KOTSUKIKAN" _
        '            & ",REQ_O_DATE_1 AS REQ_O_DATE" _
        '            & ",REQ_O_AIRPORT1_1 AS REQ_O_AIRPORT1" _
        '            & ",REQ_O_AIRPORT2_1 AS REQ_O_AIRPORT2" _
        '            & ",REQ_O_SEAT_1 AS REQ_O_SEAT" _
        '            & " from TBL_KOTSUHOTEL)" _
        '            & " UNION" _
        '            & " (select" _
        '            & " KOUENKAI_NO" _
        '            & ",DR_MPID" _
        '            & ",REQ_O_TEHAI_2 AS REQ_O_TEHAI" _
        '            & ",REQ_O_IRAINAIYOU_2 AS REQ_O_IRAINAIYOU" _
        '            & ",REQ_O_KOTSUKIKAN_2 AS REQ_O_KOTSUKIKAN" _
        '            & ",REQ_O_DATE_2 AS REQ_O_DATE" _
        '            & ",REQ_O_AIRPORT1_2 AS REQ_O_AIRPORT1" _
        '            & ",REQ_O_AIRPORT2_2 AS REQ_O_AIRPORT2" _
        '            & ",REQ_O_SEAT_2 AS REQ_O_SEAT" _
        '            & " from TBL_KOTSUHOTEL)" _
        '            & "  UNION" _
        '            & " (select" _
        '            & " KOUENKAI_NO" _
        '            & ",DR_MPID" _
        '            & ",REQ_O_TEHAI_3 AS REQ_O_TEHAI" _
        '            & ",REQ_O_IRAINAIYOU_3 AS REQ_O_IRAINAIYOU" _
        '            & ",REQ_O_KOTSUKIKAN_3 AS REQ_O_KOTSUKIKAN" _
        '            & ",REQ_O_DATE_3 AS REQ_O_DATE" _
        '            & ",REQ_O_AIRPORT1_3 AS REQ_O_AIRPORT1" _
        '            & ",REQ_O_AIRPORT2_3 AS REQ_O_AIRPORT2" _
        '            & ",REQ_O_SEAT_3 AS REQ_O_SEAT" _
        '            & " from TBL_KOTSUHOTEL)" _
        '            & "  UNION" _
        '            & " (select" _
        '            & " KOUENKAI_NO" _
        '            & ",DR_MPID" _
        '            & ",REQ_O_TEHAI_4 AS REQ_O_TEHAI" _
        '            & ",REQ_O_IRAINAIYOU_4 AS REQ_O_IRAINAIYOU" _
        '            & ",REQ_O_KOTSUKIKAN_4 AS REQ_O_KOTSUKIKAN" _
        '            & ",REQ_O_DATE_4 AS REQ_O_DATE" _
        '            & ",REQ_O_AIRPORT1_4 AS REQ_O_AIRPORT1" _
        '            & ",REQ_O_AIRPORT2_4 AS REQ_O_AIRPORT2" _
        '            & ",REQ_O_SEAT_4 AS REQ_O_SEAT" _
        '            & " from TBL_KOTSUHOTEL)" _
        '            & "UNION" _
        '            & " (select" _
        '            & " KOUENKAI_NO" _
        '            & ",DR_MPID" _
        '            & ",REQ_O_TEHAI_5 AS REQ_O_TEHAI" _
        '            & ",REQ_O_IRAINAIYOU_5 AS REQ_O_IRAINAIYOU" _
        '            & ",REQ_O_KOTSUKIKAN_5 AS REQ_O_KOTSUKIKAN" _
        '            & ",REQ_O_DATE_5 AS REQ_O_DATE" _
        '            & ",REQ_O_AIRPORT1_5 AS REQ_O_AIRPORT1" _
        '            & ",REQ_O_AIRPORT2_5 AS REQ_O_AIRPORT2" _
        '            & ",REQ_O_SEAT_5 AS REQ_O_SEAT" _
        '            & " from TBL_KOTSUHOTEL)" _
        '            & " ) AS T_WORK" _
        '            & " where" _
        '            & " kouenkai_no = '" & Me.txtKouenkaiNo.Text & "'" _
        '            & " and dr_mpid = '" & Me.txtDrMpid.Text & "'" _
        '            & " and T_WORK.req_o_tehai = '1'"


        rpt.DataSource = subDS

        ' サブレポートコントロールにサブレポートオブジェクトをセットします。
        ctlSubReport.Report = rpt

    End Sub

End Class
