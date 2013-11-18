Imports CommonLib
Imports AppLib
Imports DataDynamics.ActiveReports

Partial Public Class Preview
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private DSP_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private Joken As TableDef.Joken.DataStruct
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
            ElseIf URL.NewKouenkaiList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が新着講演会一覧の場合
                PrintNewKouenkaiList()
            ElseIf URL.KouenkaiList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が検索講演会一覧の場合
                PrintKouenkaiList()
            ElseIf URL.KouenkaiRireki.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が講演会基本情報履歴一覧の場合
                PrintKouenkaiRireki()
            ElseIf URL.NewDrList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が新着交通・宿泊一覧の場合
                If Session.Item(SessionDef.PrintPreview) = "NewDrPrint" Then
                    '新着交通・宿泊一覧
                    PrintNewDrList()
                ElseIf Session.Item(SessionDef.PrintPreview) = "TehaishoPrint" Then
                    '手配書一括印刷
                    PrintDrReport()
                End If
            ElseIf InStr(Session.Item(SessionDef.BackURL_Print).ToString.ToLower, "kaijo") > 0 Then
                Select Case Session.Item(SessionDef.PrintPreview)
                    Case "NewKaijoList"
                        '新着会場手配一覧
                        PrintNewKaijoListReport()
                    Case "KaijoList"
                        '検索会場手配一覧
                        PrintKaijoListReport()
                    Case "KaijoRegist"
                        '会場手配回答登録画面
                        PrintKaijoReport()
                    Case "KaijoRireki"
                        '会場手配履歴一覧
                        PrintKaijoRirekiReport()
                End Select
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
                Joken = Session.Item(SessionDef.Joken)
                If IsNothing(DSP_KOTSUHOTEL) Then Return False
            Catch ex As Exception
                Return False
            End Try
            If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
                Return False
            Else
                SEQ = Session.Item(SessionDef.DrRireki_SEQ)
            End If
        ElseIf URL.NewKouenkaiList.IndexOf(Session.Item(SessionDef.BackURL)) > 0 Then
            Try
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                Joken = Session.Item(SessionDef.Joken)
                If IsNothing(TBL_KOUENKAI) Then Return False
            Catch ex As Exception
                Return False
            End Try
        ElseIf URL.KouenkaiList.IndexOf(Session.Item(SessionDef.BackURL)) > 0 Then
            Try
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                Joken = Session.Item(SessionDef.Joken)
                If IsNothing(TBL_KOUENKAI) Then Return False
            Catch ex As Exception
                Return False
            End Try
        ElseIf URL.KouenkaiRireki.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
            Try
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                SEQ = Session.Item(SessionDef.SEQ)
                If IsNothing(TBL_KOUENKAI) Then Return False
            Catch ex As Exception
                Return False
            End Try
        ElseIf URL.NewDrList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
            Try
                TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
                Joken = Session.Item(SessionDef.Joken)
                If IsNothing(TBL_KOTSUHOTEL) Then Return False
            Catch ex As Exception
                Return False
            End Try
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
        Dim strSQL As String = Session.Item(SessionDef.TehaishoPrint_SQL)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

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

        'ログイン者名
        rpt1.LoginUser = Session.Item(SessionDef.LoginUser)
 
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

    '新着講演会一覧印刷
    Private Sub PrintNewKouenkaiList()

        Dim rpt1 As New NewKouenkaiReport()

        'データ設定
        rpt1.DataSource = GetNewKouenkaiData()
        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        '抽出条件を渡す
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_BU"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.BU
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_AREA"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.AREA
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.LoginUser)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    'データ取得
    Private Function GetNewKouenkaiData() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.NewKouenkaiPrint_SQL)
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

    '検索講演会一覧印刷
    Private Sub PrintKouenkaiList()

        Dim rpt1 As New KouenkaiReport()

        'データ設定
        rpt1.DataSource = GetKouenkaiData()
        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        '抽出条件を渡す
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KIKAKU_TANTO_ROMA"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.KIKAKU_TANTO_ROMA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TEHAI_TANTO_ROMA"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.TEHAI_TANTO_ROMA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_SEIHIN_NAME"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.SEIHIN_NAME
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NO"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.KOUENKAI_NO
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NAME"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.KOUENKAI_NAME
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_BU"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.BU
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_AREA"),  _
             DataDynamics.ActiveReports.TextBox).Text = Joken.AREA
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.LoginUser)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        If Joken.TTANTO_ID.Trim <> "指定なし" Then
            Dim strSQL As String = "SELECT * FROM MS_USER" _
                & " WHERE" _
                & TableDef.MS_USER.Column.LOGIN_ID & "='" & Joken.TTANTO_ID & "'"
            MS_USER = AppModule.GetOneRecord(AppModule.TableType.MS_USER, strSQL, DbConnection)
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_USER_NAME"),  _
                 DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME
        Else
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_USER_NAME"),  _
                 DataDynamics.ActiveReports.TextBox).Text = Joken.TTANTO_ID
        End If

        If Joken.FROM_DATE.Trim <> "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_JISSIBI"),  _
                DataDynamics.ActiveReports.TextBox).Text = AppModule.GetName_KOUENKAI_DATE(Joken.FROM_DATE, Joken.TO_DATE, True)
        Else
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_JISSIBI"),  _
                 DataDynamics.ActiveReports.TextBox).Text = Joken.FROM_DATE
        End If

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1
    End Sub

    'データ取得
    Private Function GetKouenkaiData() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.KouenkaiPrint_SQL)
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

    '講演会基本情報履歴一覧印刷
    Private Sub PrintKouenkaiRireki()

        Dim rpt1 As New KouenkaiRirekiReport()

        'データ設定
        rpt1.DataSource = GetKouenkaiRirekiData()
        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        '講演会№・講演会名を渡す
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NO"),  _
            DataDynamics.ActiveReports.TextBox).Text = TBL_KOUENKAI(SEQ).KOUENKAI_NO
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NAME"),  _
            DataDynamics.ActiveReports.TextBox).Text = TBL_KOUENKAI(SEQ).KOUENKAI_NAME
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.LoginUser)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1
    End Sub

    'データ取得
    Private Function GetKouenkaiRirekiData() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.KouenkaiRirekiPrint_SQL)
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

    '新着交通・宿泊一覧印刷
    Private Sub PrintNewDrList()

        Dim rpt1 As New NewDrListReport()

        'データ設定
        rpt1.DataSource = GetNewDrData()
        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        '抽出条件を渡す
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_BU"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.BU
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_AREA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.AREA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KUBUN"),  _
            DataDynamics.ActiveReports.TextBox).Text = AppModule.GetName_STATUS_TEHAI(Joken.KUBUN)
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NO"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.KOUENKAI_NO
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NAME"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.KOUENKAI_NAME
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KIKAKU_TANTO_ROMA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.KIKAKU_TANTO_ROMA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TEHAI_TANTO_ROMA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.TEHAI_TANTO_ROMA
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.LoginUser)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1
    End Sub

    'データ取得
    Private Function GetNewDrData() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.NewDrPrint_SQL)
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

    '新着会場手配依頼一覧印刷
    Private Sub PrintNewKaijoListReport()

        Dim rpt1 As New NewKaijoListReport()

        'データ設定
        rpt1.DataSource = GetNewKaijoListData()
        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'ログイン者名
        rpt1.LoginUser = Session.Item(SessionDef.LoginUser)
        '抽出条件
        rpt1.Joken = Session.Item(SessionDef.Joken)

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1
    End Sub

    '新着会場手配一覧データ取得
    Private Function GetNewKaijoListData() As DataTable

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

    '検索会場手配依頼一覧印刷
    Private Sub PrintKaijoListReport()

        Dim rpt1 As New KaijoListReport()

        'データ設定
        rpt1.DataSource = GetKaijoListData()
        rpt1.Document.Printer.PrinterName = ""

        'A4横
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'ログイン者名
        rpt1.LoginUser = Session.Item(SessionDef.LoginUser)
        '抽出条件
        rpt1.Joken = Session.Item(SessionDef.Joken)

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    '検索会場手配一覧データ取得
    Private Function GetKaijoListData() As DataTable

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

    '会場手配依頼 履歴一覧印刷
    Private Sub PrintKaijoRirekiReport()

        Dim rpt1 As New KaijoRirekiReport()

        'データ設定
        rpt1.DataSource = GetKaijoRirekiData()
        rpt1.Document.Printer.PrinterName = ""

        'A4横
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'ログイン者名
        rpt1.LoginUser = Session.Item(SessionDef.LoginUser)
        '抽出条件
        rpt1.Joken = Session.Item(SessionDef.KaijoRireki_Joken)

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    '検索会場手配一覧データ取得
    Private Function GetKaijoRirekiData() As DataTable

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
