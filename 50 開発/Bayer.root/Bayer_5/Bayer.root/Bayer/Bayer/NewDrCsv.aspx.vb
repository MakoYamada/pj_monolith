Imports CommonLib
Imports AppLib
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Partial Public Class NewDrCsv
    Inherits WebBase

    Private TBL_FILE() As TableDef.TBL_FILE.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private grv_selected() As String

    'グリッド列    Private Enum CellIndex
        ROW_NO
        FILE_NAME
        INS_DATE
        FILE_TYPE
        BUTTON1
        BUTTON2
    End Enum

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "【新着】交通・宿泊手配依頼CSVダウンロード"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        TBL_FILE = Nothing
        Joken = Nothing
        If Not GetData(Joken, TBL_FILE) Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True

            'グリッドビュー表示
            Session.Item(SessionDef.PageIndex) = 0
            SetGridView()
        End If
    End Sub

    'データ取得
    Private Function GetData(ByVal Joken As TableDef.Joken.DataStruct, ByRef pFILE() As TableDef.TBL_FILE.DataStruct) As Boolean
        Dim strSQL As String = ""
        Dim i As Integer = 0
        Dim wFlag As Boolean = False

        Erase pFILE

        strSQL &= "SELECT *"
        strSQL &= " FROM TBL_FILE"

        If Trim(Joken.FILE_NAME) <> "" Then
            strSQL &= " WHERE"
            strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & "=@" & TableDef.TBL_FILE.Column.FILE_NAME
        End If

        strSQL &= " ORDER BY"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.INS_DATE & " DESC"

        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        If Trim(Joken.FILE_NAME) <> "" Then
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_NAME, Joken.FILE_NAME)
        End If

        Dim objRs As Object = objCom.ExecuteReader()
        Try
            While objRs.read()
                ReDim Preserve pFILE(i)
                pFILE(i).FILE_NAME = objRs.item(TableDef.TBL_FILE.ColumnNo.FILE_NAME)
                pFILE(i).FILE_TYPE = objRs.item(TableDef.TBL_FILE.ColumnNo.FILE_TYPE)
                pFILE(i).DATUME = CType(objRs.item(TableDef.TBL_FILE.ColumnNo.DATUME), Byte())
                i += 1
                wFlag = True
            End While
        Catch ex As Exception
            objRs.close()
            objCom.Cancel()
            Return False
        End Try
        objRs.close()
        objCom.Cancel()
        Return wFlag
    End Function

    'グリッドビュー表示項目取得

    Private Function GetGridData() As Boolean
        Dim strSQL As String = ""
        Dim i As Integer = 0
        Dim wFlag As Boolean = False

        strSQL &= "SELECT *"
        strSQL &= " FROM TBL_FILE"

        strSQL &= " ORDER BY"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.INS_DATE & " DESC"

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL
        Me.SqlDataSource1.SelectParameters.Clear()

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With
    End Function

    'データソース設定
    Private Sub SetGridView()
        Dim strSQL As String = ""

        'データソース設定
        strSQL &= "SELECT *"
        strSQL &= " FROM TBL_FILE"

        strSQL &= " ORDER BY"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.INS_DATE & " DESC"

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL
        Me.SqlDataSource1.SelectParameters.Clear()

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.FILE_TYPE).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 0
            Me.GrvList.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
        End If
    End Sub

    'グリッドビュー内書式設定
    Private Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'CSV作成日
            e.Row.Cells(CellIndex.INS_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.INS_DATE).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        End If
    End Sub

    'グリッドビュー ページ移動時
    Protected Sub GrvList_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrvList.PageIndexChanged
        With Me.GrvList

            '選択行をキャンセル
            .SelectedIndex = -1
            'カレントページを変更
            Session.Item(SessionDef.PageIndex) = .PageIndex

            'グリッドビュー表示
            SetGridView()
        End With
    End Sub

    'グリッドビュー コマンドボタン押下時
    Protected Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = GrvList.Rows(index)

        Select Case e.CommandName
            Case "Download"
                '新着一覧ダウンロード
                Joken.FILE_NAME = DirectCast(GrvList.Rows(index).Controls(CellIndex.FILE_NAME), DataControlFieldCell).Text()
                Call DLCsvFile(Joken)

            Case "Delete"
                '新着一覧CSV削除
                Joken.FILE_NAME = DirectCast(GrvList.Rows(index).Controls(CellIndex.FILE_NAME), DataControlFieldCell).Text()
                Call DeleteTBL_FILE(Joken)

                '新着一覧CSV再表示
                Call SetForm()
        End Select
    End Sub

    '[新着一覧CSVファイルダウンロード]
    Protected Sub DLCsvFile(ByVal Joken As TableDef.Joken.DataStruct)
        Dim wFILE(0) As TableDef.TBL_FILE.DataStruct

        '書類テーブルデータ取得
        If Not GetData(Joken, wFILE) Then Exit Sub

        Response.HeaderEncoding = System.Text.Encoding.GetEncoding("shift_jis")
        Response.AddHeader("Content-Disposition", "attachment;filename=" & wFILE(0).FILE_NAME)
        Response.Charset = CmnConst.Csv.Charset
        Response.ContentType = wFILE(0).FILE_TYPE
        Response.BinaryWrite(wFILE(0).DATUME)
        Response.End()
    End Sub

    '[新着一覧CSVファイル削除]
    Private Function DeleteTBL_FILE(ByVal Joken As TableDef.Joken.DataStruct) As Boolean
        Dim strSQL As String = ""

        'データソース設定
        strSQL = "DELETE FROM TBL_FILE WHERE FILE_NAME='" & Joken.FILE_NAME & "'"

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.DeleteCommand = strSQL
        Me.SqlDataSource1.DeleteParameters.Clear()
        Me.SqlDataSource1.DeleteParameters.Add("FILE_NAME", Joken.FILE_NAME)

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With

        Return True
    End Function
End Class