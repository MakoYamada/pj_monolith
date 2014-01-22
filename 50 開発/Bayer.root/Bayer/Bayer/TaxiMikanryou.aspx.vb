Imports CommonLib
Imports AppLib
Imports System.IO

Partial Public Class TaxiMikanryou
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'CSV列    Private Enum CellIndex
        FROM_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
    End Enum

    Private Class COL_NAME
        Public Const FROM_DATE As String = "講演会開始日"
        Public Const KOUENKAI_NO As String = "MTG №"
        Public Const KOUENKAI_NAME As String = "講演会名"
        Public Const BU As String = "企画担当者BU"
        Public Const KIKAKU_TANTO_AREA As String = "企画担当者エリア"
        Public Const KIKAKU_TANTO_EIGYOSHO As String = "企画担当者営業所"
        Public Const KIKAKU_TANTO_NAME As String = "企画担当者"
    End Class

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
        Session.Item(SessionDef.Joken) = Joken
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "精算未完了CSV出力"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'IME設定        CmnModule.SetIme(Me.Joken_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.Joken_MM, CmnModule.ImeType.InActive)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '開催日初期値表示(システム日付－5ヶ月)
        Dim wStr As String = Now.AddMonths(-5).ToString("yyyyMMdd")
        Me.Joken_YYYY.Text = wStr.Substring(0, 4)
        Me.Joken_MM.Text = wStr.Substring(4, 2)

        Me.LabelNoData.Visible = False
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Joken = Nothing
        Joken.TO_DATE = CmnModule.GetLastDateOfMonth(Me.Joken_YYYY.Text, Me.Joken_MM.Text)

        ReDim TBL_TAXITICKET_HAKKO(wCnt)

        strSQL = SQL.TBL_SEIKYU.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
            TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.Joken_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.Joken_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(月)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.Joken_YYYY) AndAlso CmnCheck.IsInput(Me.Joken_MM) Then
            Dim wStr As String = StrConv(Trim(Me.Joken_YYYY.Text) & "/" & Trim(Me.Joken_MM.Text) & "/01", VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.Joken_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.Joken_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(月)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.Joken_YYYY) AndAlso CmnCheck.IsInput(Me.Joken_MM) Then
            Dim wStr As String = StrConv(Trim(Me.Joken_YYYY.Text) & "/" & Trim(Me.Joken_MM.Text) & "/01", VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub BtnCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCsv.Click
        '入力チェック
        If Not Check() Then Exit Sub

        If GetData() Then
            Me.LabelNoData.Visible = False

            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "SeisanMikanryou.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-JIS")

            Response.Write(MyModule.Csv.TaxiMiketsu(TBL_TAXITICKET_HAKKO))
            Response.End()
        Else
            Me.LabelNoData.Visible = True
        End If
    End Sub
End Class