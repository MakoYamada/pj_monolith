Imports CommonLib
Imports AppLib
Imports DataDynamics.ActiveReports

Partial Public Class Preview
    Inherits WebBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            '帳票出力            'TODO:ドクター情報か会場手配情報かを、前画面URLまたは区分などで判定            PrintDrReport()

            'PrintKaijoReport()

        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "プレビュー"
        End With

    End Sub

    'ドクター情報印刷
    Private Sub PrintDrReport()

        Dim rpt1 As New DrReport()

        'データ設定
        rpt1.DataSource = GetDrData()

        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub


    '仮
    Private Function GetDrData() As DataTable

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

    Private Sub PrintKaijoReport()

        Dim rpt1 As New KaijoReport1() ' 1/3ページ
        Dim rpt2 As New KaijoReport2() ' 2/3ページ
        Dim rpt3 As New KaijoReport3() ' 3/3ページ

        'データ取得
        Dim dtPrintData As DataTable = GetKaijoData()

        'データ設定
        rpt1.DataSource = dtPrintData
        rpt2.DataSource = dtPrintData

        rpt1.Document.Printer.PrinterName = ""
        rpt2.Document.Printer.PrinterName = ""
        rpt3.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        rpt2.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt2.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        rpt3.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt3.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)
        rpt2.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt2.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt2.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt2.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)
        rpt3.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt3.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt3.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt3.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'それぞれのレポートを作成
        rpt1.Run()
        rpt2.Run()
        rpt3.Run()

        For i As Integer = 0 To rpt1.Document.Pages.Count - 1
            ' 各レポートが順番に出力されるように、ページを挿入
            rpt1.Document.Pages.Insert(i * 3 + 1, rpt2.Document.Pages(i))
            rpt1.Document.Pages.Insert(i * 3 + 2, rpt3.Document.Pages(i))
        Next

        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    '仮
    Private Function GetKaijoData() As DataTable

        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'strSQL = SQL.TBL_DR.byMR_ID(Session.Item(SessionDef.LoginID), PLACE)
        strSQL = "SELECT *" _
               & " FROM TBL_KAIJO TKJ" _
               & " LEFT OUTER JOIN TBL_KOUENKAI TKE" _
               & " ON TKJ.KOUENKAI_NO = TKE.KOUENKAI_NO"

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        'select 
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table

    End Function

End Class