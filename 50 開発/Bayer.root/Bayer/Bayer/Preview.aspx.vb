Imports CommonLib
Imports AppLib
Imports DataDynamics.ActiveReports

Partial Public Class Preview
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private DSP_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private RPT_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer
    Private Popup As Boolean = False

    Private Sub Page_Unload1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '呼び元が履歴一覧・手配画面の場合
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)
        Popup = True

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '帳票出力            If URL.DrRegist.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が交通・宿泊手配回答登録画面の場合
                Select Case Session.Item(SessionDef.PrintPreview)
                    Case "Tehaisho"
                        '手配書印刷
                        PrintDrReport(False)
                    Case "TehaishoRireki"
                        '手配書印刷(履歴)
                        PrintDrReport(True)
                    Case "Soufujo"
                        '送付状印刷
                        PrintSoufujo()
                    Case "TaxiKakuninhyo"
                        'タクチケ手配確認票
                        PrintKakuninhyo()
                End Select
            ElseIf URL.NewKouenkaiList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が新着会合一覧の場合
                PrintNewKouenkaiList()
            ElseIf URL.KouenkaiList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が検索会合一覧の場合
                PrintKouenkaiList()
            ElseIf URL.KouenkaiRireki.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が会合基本情報履歴一覧の場合
                PrintKouenkaiRireki()
            ElseIf URL.NewDrList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が新着交通・宿泊一覧の場合
                If Session.Item(SessionDef.PrintPreview) = "NewDrPrint" Then
                    '新着交通・宿泊一覧
                    PrintNewDrList()
                ElseIf Session.Item(SessionDef.PrintPreview) = "TehaishoPrint" Then
                    '手配書一括印刷
                    PrintDrReport(False)
                End If
            ElseIf URL.DrList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が交通・宿泊履歴一覧の場合
                PrintDrList()
            ElseIf URL.DrRireki.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                '呼び元画面が交通・宿泊履歴一覧の場合
                PrintDrRireki()
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
                        PrintKaijoReport(False)
                    Case "KaijoRegistRireki"
                        '会場手配回答登録画面(履歴)
                        PrintKaijoReport(True)
                    Case "KaijoRireki"
                        '会場手配履歴一覧
                        PrintKaijoRirekiReport()
                End Select
            ElseIf URL.SeisanRegist.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                PrintSeisanRegistReport()
            ElseIf URL.SeisanList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                If Session.Item(SessionDef.PrintPreview) = "MishuHoukoku" Then
                    '未収入金滞留理由報告書
                    PrintMishuHoukoku()
                Else
                    '精算データ一覧印刷
                    PrintSeisanListReport()
                End If
            ElseIf URL.TaxiSoufujoIkkatsu.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
                Select Case Session.Item(SessionDef.PrintPreview)
                    Case "Soufujo"
                        '送付状一括印刷
                        PrintSoufujo()
                    Case "TaxiKakuninhyo"
                        '確認票一括印刷
                        PrintKakuninhyo()
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
        If InStr(Session.Item(SessionDef.BackURL_Print).ToString.ToLower, "kaijo") > 0 Then
            If Trim(Session.Item(SessionDef.KaijoPrint_SQL)) = "" Then
                Return False
            End If
        ElseIf URL.DrRegist.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
            If Trim(Session.Item(SessionDef.TehaishoPrint_SQL)) = "" Then
                Return False
            End If
        ElseIf URL.NewKouenkaiList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
            Try
                TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
                Joken = Session.Item(SessionDef.Joken)
                If IsNothing(TBL_KOUENKAI) Then Return False
            Catch ex As Exception
                Return False
            End Try
        ElseIf URL.KouenkaiList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
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
        ElseIf URL.DrList.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
            Try
                TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
                Joken = Session.Item(SessionDef.Joken)
                If IsNothing(TBL_KOTSUHOTEL) Then Return False
            Catch ex As Exception
                Return False
            End Try
        ElseIf URL.DrRireki.IndexOf(Session.Item(SessionDef.BackURL_Print)) > 0 Then
            Try
                TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
                If IsNothing(TBL_KOTSUHOTEL) Then Return False
            Catch ex As Exception
                Return False
            End Try
        End If
        Return True
    End Function

    'ドクター情報印刷
    Private Sub PrintDrReport(ByVal pRireki As Boolean)

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

        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        '旧データ
        rpt1.OldTBL_KOTSUHOTEL = Session.Item(SessionDef.OldTBL_KOTSUHOTEL)
        '履歴=True
        rpt1.Rireki = pRireki

        'レポートを作成
        rpt1.Run()
        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    'チケット類送付状印刷
    Private Sub PrintSoufujo()

        Dim rpt1 As New DrSoufujo()

        'データ設定
        rpt1.DataSource = GetTehaishoIkkatsu()

        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        rpt1.KOTSUHOTEL_DATA = RPT_KOTSUHOTEL

        'レポートを作成
        rpt1.Run()
        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1

    End Sub

    'タクチケ手配確認票
    Private Sub PrintKakuninhyo()

        Dim rpt1 As New TaxiKakuninReport()

        'データ設定
        rpt1.DataSource = GetTehaishoIkkatsu()

        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        rpt1.KOTSUHOTEL_DATA = RPT_KOTSUHOTEL

        'ログイン者名
        rpt1.MS_USER = Session.Item(SessionDef.MS_USER)

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
        If RsData.Read() Then
            RPT_KOTSUHOTEL = AppModule.SetRsData(RsData, RPT_KOTSUHOTEL)
        End If
        RsData.Close()

        Dim arguments As New DataSourceSelectArguments()
        'select 
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function

    '送付状・確認票一括印刷データ取得
    Private Function GetTehaishoIkkatsu() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.TehaishoPrint_SQL)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        'If RsData.Read() Then
        '    RPT_KOTSUHOTEL = AppModule.SetRsData(RsData, RPT_KOTSUHOTEL)
        'End If
        'RsData.Close()

        Dim arguments As New DataSourceSelectArguments()
        'select 
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function
    '会場手配依頼印刷
    Private Sub PrintKaijoReport(ByVal Rireki As Boolean)

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
        rpt1.MS_USER = Session.Item(SessionDef.MS_USER)
        '旧データ
        rpt1.OldTBL_KAIJO = Session.Item(SessionDef.OldTBL_KAIJO)
        '履歴=True
        rpt1.Rireki = Rireki

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

    '新着会合一覧印刷
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
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
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

    '検索会合一覧印刷
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
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
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

    '会合基本情報履歴一覧印刷
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

        '会合№・会合名を渡す
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NO"),  _
            DataDynamics.ActiveReports.TextBox).Text = TBL_KOUENKAI(SEQ).KOUENKAI_NO
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NAME"),  _
            DataDynamics.ActiveReports.TextBox).Text = TBL_KOUENKAI(SEQ).KOUENKAI_NAME
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
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
        If Joken.TTANTO_ID <> "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TTEHAI_TANTO"),  _
                DataDynamics.ActiveReports.TextBox).Text = GetTANTO_NAME(Joken.TTANTO_ID)
        Else
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TTEHAI_TANTO"),  _
                DataDynamics.ActiveReports.TextBox).Text = Joken.TTANTO_ID
        End If
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TTEHAI_MITOUROKU"),  _
                DataDynamics.ActiveReports.TextBox).Text = Joken.TTEHAI_MITOUROKU

        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
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
        'Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function
    '検索交通・宿泊一覧印刷
    Private Sub PrintDrList()    
        Dim rpt1 As New DrListReport()

        'データ設定
        rpt1.DataSource = GetDrList()
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
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_MR_ROMA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.MR_ROMA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_DR_KANA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.DR_KANA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_DR_SANKA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.DR_SANKA
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NO"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.KOUENKAI_NO
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_KOUENKAI_NAME"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.KOUENKAI_NAME

        If Joken.FROM_DATE <> "指定なし" AndAlso Joken.TO_DATE <> "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_JISSIBI"),  _
                DataDynamics.ActiveReports.TextBox).Text = CmnModule.Format_Date(Joken.FROM_DATE, CmnModule.DateFormatType.YYYYMMDD) _
                    & "～" _
                    & CmnModule.Format_Date(Joken.TO_DATE, CmnModule.DateFormatType.YYYYMMDD)
        ElseIf Joken.FROM_DATE <> "指定なし" AndAlso Joken.TO_DATE = "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_JISSIBI"),  _
                DataDynamics.ActiveReports.TextBox).Text = CmnModule.Format_Date(Joken.FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)
        ElseIf Joken.FROM_DATE = "指定なし" AndAlso Joken.TO_DATE <> "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_JISSIBI"),  _
                DataDynamics.ActiveReports.TextBox).Text = CmnModule.Format_Date(Joken.TO_DATE, CmnModule.DateFormatType.YYYYMMDD)
        ElseIf Joken.FROM_DATE = "指定なし" AndAlso Joken.TO_DATE = "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_JISSIBI"),  _
                DataDynamics.ActiveReports.TextBox).Text = "指定なし"
        End If

        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TEHAI_BU"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.BU
        DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TEHAI_AREA"),  _
            DataDynamics.ActiveReports.TextBox).Text = Joken.AREA
        If Joken.TTANTO_ID <> "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TTANTO"),  _
                    DataDynamics.ActiveReports.TextBox).Text = GetTANTO_NAME(Joken.TTANTO_ID)
        Else
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_TTANTO"),  _
                    DataDynamics.ActiveReports.TextBox).Text = Joken.TTANTO_ID
        End If


        If Joken.UPDATE_DATE <> "指定なし" Then
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_UPD_DATE"),  _
                DataDynamics.ActiveReports.TextBox).Text = CmnModule.Format_Date(Joken.UPDATE_DATE, CmnModule.DateFormatType.YYYYMMDD)
        Else
            DirectCast(rpt1.Sections("PageHeader").Controls("JOKEN_UPD_DATE"),  _
                DataDynamics.ActiveReports.TextBox).Text = Joken.UPDATE_DATE
        End If

        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1
    End Sub

    'データ取得
    Private Function GetDrList() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.DrPrint_SQL)
        'Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function

    '交通・宿泊履歴一覧印刷
    Private Sub PrintDrRireki()

        Dim rpt1 As New DrRirekiReport()

        'データ設定
        rpt1.DataSource = GetDrRireki()
        rpt1.Document.Printer.PrinterName = ""

        'A4縦
        rpt1.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt1.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt1.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt1.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        '出力担当者情報を渡す
        Dim MS_USER As TableDef.MS_USER.DataStruct = Session.Item(SessionDef.MS_USER)
        DirectCast(rpt1.Sections("PageHeader").Controls("PRINT_USER"),  _
            DataDynamics.ActiveReports.TextBox).Text = MS_USER.USER_NAME

        'レポートを作成
        rpt1.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt1
    End Sub

    'データ取得
    Private Function GetDrRireki() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.DrRirekiPrint_SQL)
        'Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

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
        rpt1.MS_USER = Session.Item(SessionDef.MS_USER)
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
        rpt1.MS_USER = Session.Item(SessionDef.MS_USER)
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
        rpt1.MS_USER = Session.Item(SessionDef.MS_USER)
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

    '精算データ一覧印刷
    Private Sub PrintSeisanListReport()

        Dim rpt As New SeisanListReport

        'データ設定
        rpt.DataSource = GetSeisanListData()
        rpt.Document.Printer.PrinterName = ""

        'A4横
        rpt.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape

        '必要に応じマージン設定
        rpt.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'ログイン者名
        rpt.LoginUser = Session.Item(SessionDef.MS_USER)
        '抽出条件
        rpt.Joken = Session.Item(SessionDef.Joken)

        'レポートを作成
        rpt.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt

    End Sub

    '精算一覧取得
    Private Function GetSeisanListData() As DataTable

        Dim strSQL As String = Session.Item(SessionDef.SeisanListPrint_SQL)
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

    '精算金額印刷
    Private Sub PrintSeisanRegistReport()

        Dim rpt As New SeisanRegistReport

        'データ設定
        rpt.DataSource = GetSeisanRegistData()
        rpt.Document.Printer.PrinterName = ""

        'A4縦
        rpt.Document.Printer.PaperKind = Drawing.Printing.PaperKind.A4
        rpt.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait

        '必要に応じマージン設定
        rpt.PageSettings.Margins.Top = ActiveReport.CmToInch(0.9)
        rpt.PageSettings.Margins.Bottom = ActiveReport.CmToInch(0.9)
        rpt.PageSettings.Margins.Left = ActiveReport.CmToInch(0.9)
        rpt.PageSettings.Margins.Right = ActiveReport.CmToInch(0.9)

        'ログイン者名
        rpt.LoginUser = Session.Item(SessionDef.MS_USER)

        'レポートを作成
        rpt.Run()

        Me.WebViewer1.ViewerType = DataDynamics.ActiveReports.Web.ViewerType.FlashViewer
        Me.WebViewer1.ClearCachedReport()
        Me.WebViewer1.Report = rpt

    End Sub

    '精算金額取得
    Private Function GetSeisanRegistData() As DataTable

        Dim strSQL As String = Session.Item(SessionDef.SeisanRegistReport_SQL)
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

    '未収入金滞留理由報告書印刷
    Private Sub PrintMishuHoukoku()
        Dim rpt1 As New MishuHoukoku()

        'データ設定
        rpt1.DataSource = GetMishuHoukokuData()

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

    '未収入金滞留理由報告書データ取得
    Private Function GetMishuHoukokuData() As DataTable
        Dim strSQL As String = Session.Item(SessionDef.MishuHoukoku_SQL)
        'Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        Dim arguments As New DataSourceSelectArguments()
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        Dim dtView As DataView = Me.SqlDataSource1.Select(arguments)

        Return dtView.Table
    End Function

    'TOP担当者名取得
    Private Function GetTANTO_NAME(ByVal LOGIN_ID As String) As String
        Dim strSQL As String = SQL.MS_USER.byLOGIN_ID(LOGIN_ID)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlAG As Boolean = False
        Dim MS_USER As TableDef.MS_USER.DataStruct

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            MS_USER = AppModule.SetRsData(RsData, MS_USER)
            Return MS_USER.USER_NAME
        Else
            Return String.Empty
        End If
        RsData.Close()
    End Function

    '[前の画面に戻る]
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBack.Click
        Response.Redirect(Session.Item(SessionDef.BackURL_Print))
    End Sub

End Class
