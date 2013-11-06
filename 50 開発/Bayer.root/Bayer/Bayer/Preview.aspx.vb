Imports CommonLib
Imports AppLib
Imports DataDynamics.ActiveReports

Partial Public Class Preview
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private DSP_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private SEQ As Integer
    Private Popup As Boolean = False

    Private Sub Page_Unload1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '呼び元が履歴一覧・手配画面の場合
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)
        Popup = True

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '帳票出力            If URL.DrRegist.IndexOf(Session.Item(SessionDef.BackURL)) > 0 Then
                '呼び元画面が交通・宿泊手配回答登録画面の場合
                PrintDrReport()
            ElseIf InStr(Session.Item(SessionDef.BackURL_Print).ToString.ToLower, "kaijo") > 0 Then
                '呼び元画面が新着会場手配一覧または会場手配回答登録画面の場合
                PrintKaijoReport()
            End If
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "プレビュー"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        If URL.DrRegist.IndexOf(Session.Item(SessionDef.BackURL)) > 0 Then
            Try
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
                DSP_KOTSUHOTEL = Session.Item(SessionDef.DrRireki_TBL_KOTSUHOTEL)
                If IsNothing(DSP_KOTSUHOTEL) Then Return False
            Catch ex As Exception
                Return False
            End Try
            If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
                Return False
            Else
                SEQ = Session.Item(SessionDef.DrRireki_SEQ)
            End If
        ElseIf InStr(Session.Item(SessionDef.BackURL_Print).ToString.ToLower, "kaijo") > 0 Then
            If Trim(Session.Item(SessionDef.KaijoPrint_SQL)) = "" Then
                Return False
            End If
        End If
        Return True
    End Function

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
        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    '交通・宿泊データ取得
    Private Function GetDrData() As DataTable

        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        strSQL = SQL.TBL_KOTSUHOTEL.DrReport(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO, TBL_KOTSUHOTEL(SEQ).SANKASHA_ID)

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        'select 
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function

    '会場手配依頼印刷
    Private Sub PrintKaijoReport()

        Dim rpt1 As New KaijoReport()

        'データ設定
        rpt1.DataSource = GetKaijoData()
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

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    '会場手配データ取得
    Private Function GetKaijoData() As DataTable

        Dim strSQL As String = Session.Item(SessionDef.KaijoPrint_SQL)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table

    End Function

    '[前の画面に戻る]
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect(Session.Item(SessionDef.BackURL_Print))
    End Sub

End Class
