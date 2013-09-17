Imports CommonLib
Imports AppLib
Imports DataDynamics.ActiveReports

Partial Public Class Preview
    Inherits WebBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            '帳票出力            PrintReport()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "プレビュー"
        End With

    End Sub

    Private Sub PrintReport()

        Dim rpt1 As New DrReport() ' 1/2ページ
        'Dim rpt2 As New DrReport2() ' 2/2ページ

        'データ設定
        rpt1.DataSource = GetData()

        rpt1.Document.Printer.PrinterName = ""
        
        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)


        ' それぞれのレポートを作成します。
        rpt1.Run()
        'rpt2.Run()

        'For i As Integer = 0 To rpt1.Document.Pages.Count - 1
        '    ' 各レポートが交互に出力されるように、ページを挿入します。
        '    rpt1.Document.Pages.Insert(i * 2 + 1, rpt2.Document.Pages(i))
        'Next

        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub


    '仮
    Private Function GetData() As DataTable

        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'strSQL = SQL.TBL_DR.byMR_ID(Session.Item(SessionDef.LoginID), PLACE)
        strSQL = "SELECT *" _
               & " FROM TBL_KOTSUHOTEL TKH" _
               & " LEFT OUTER JOIN TBL_KOUENKAI TKE" _
               & " ON TKH.KOUENKAI_NO = TKE.KOUENKAI_NO"

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        'select 
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function

End Class