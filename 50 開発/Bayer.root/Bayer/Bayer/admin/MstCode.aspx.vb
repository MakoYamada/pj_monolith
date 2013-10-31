Imports CommonLib
Imports AppLib
Partial Public Class MstCode
    Inherits WebBase

    Private MS_CODE() As TableDef.MS_CODE.DataStruct
    Private wRowNo As Integer

    'グリッド列
    Private Enum CellIndex
        Template1
        DISP_VALUE
        DISP_TEXT
        CODE
        DATA_ID
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MS_CODE) = MS_CODE
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "コードマスタメンテナンス"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            MS_CODE = Session.Item(SessionDef.MS_CODE)
            If MS_CODE Is Nothing Then ReDim MS_CODE(0)
        Catch ex As Exception
            ReDim MS_CODE(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定
        CmnModule.SetIme(Me.DISP_VALUE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.DISP_TEXT, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)

        Me.TblUpdate.Visible = False
        Me.TblInsert.Visible = False
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        Me.CODE.Value = CmnModule.GetSelectedItemValue(Me.JokenCODE)
        Me.DISP_VALUE.Text = ""
        Me.DISP_TEXT.Text = ""

        'データ取得
        If Not GetData() Then
            Me.TblUpdate.Visible = False
            Me.TblInsert.Visible = False
        Else
            Me.TblUpdate.Visible = True
            Me.TblInsert.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        ReDim MS_CODE(wCnt)
        strSQL = SQL.MS_CODE.byCODE(CmnModule.GetSelectedItemValue(Me.JokenCODE))
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve MS_CODE(wCnt)
            MS_CODE(wCnt) = AppModule.SetRsData(RsData, MS_CODE(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.MS_CODE.byCODE(CmnModule.GetSelectedItemValue(Me.JokenCODE))
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        wRowNo = 0
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

    'グリッドビュー内書式設定
    Protected Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'IME設定
            CmnModule.SetIme(CType(e.Row.Cells(CellIndex.Template1).FindControl("DISP_TEXT"), TextBox), CmnModule.ImeType.Active)

            CType(e.Row.Cells(CellIndex.Template1).FindControl("DISP_TEXT"), TextBox).Text = CmnModule.ClearHtmlSpace(e.Row.Cells(CellIndex.DISP_TEXT).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.DISP_TEXT).Visible = False
            e.Row.Cells(CellIndex.CODE).Visible = False
            e.Row.Cells(CellIndex.DATA_ID).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 3
            Me.GrvList.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
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

    '[選択]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック(条件)
        If Not Check_Joken() Then Exit Sub

        '画面項目表示
        SetForm()
    End Sub

    '入力チェック(条件)
    Private Function Check_Joken() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.JokenCODE) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("コード区分"), Me)
            Return False
        End If

        Return True
    End Function

    '[登録]
    Protected Sub BtnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        '入力チェック
        If Not Check1() Then Exit Sub

        '入力値を取得
        GetValue1()

        'データ更新
        If InsertData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '[変更]
    Protected Sub BtnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        '入力チェック
        If Not Check2() Then Exit Sub

        '入力値を取得
        GetValue2()

        'データ更新
        If UpdateData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '入力チェック(登録)
    Private Function Check1() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.DISP_VALUE) OrElse CmnCheck.IsInput(Me.DISP_TEXT) Then
            If Not CmnCheck.IsInput(Me.DISP_VALUE) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("追加枠：コード"), Me)
                Return False
            End If
            If Not CmnCheck.IsInput(Me.DISP_TEXT) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("追加枠：名称"), Me)
                Return False
            End If

            If CmnDb.IsExist(SQL.MS_CODE.byCODE_DISP_VALUE(Me.CODE.Value, Trim(StrConv(Me.DISP_VALUE.Text, VbStrConv.Narrow))), MyBase.DbConnection) Then
                CmnModule.AlertMessage(MessageDef.Error.IsRegistered("入力されたコード"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '入力チェック(変更)
    Private Function Check2() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '追加枠
        If Not Check1() Then Return False

        '変更
        For Each wRow As GridViewRow In Me.GrvList.Rows
            If Not CmnCheck.IsInput(CType(wRow.Cells(CellIndex.Template1).FindControl("DISP_TEXT"), TextBox)) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("名称"), Me)
                Return False
            End If
        Next

        Return True
    End Function

    '入力値を取得
    '登録
    Private Sub GetValue1()
        Dim wCnt As Integer = UBound(MS_CODE) + 1

        ReDim Preserve MS_CODE(wCnt)
        MS_CODE(wCnt).CODE = Me.CODE.Value
        MS_CODE(wCnt).DISP_VALUE = Trim(StrConv(Me.DISP_VALUE.Text, VbStrConv.Narrow))
        MS_CODE(wCnt).DISP_TEXT = Trim(Me.DISP_TEXT.Text)
    End Sub
    '変更
    Private Sub GetValue2()
        Dim wCnt As Integer = 0

        ReDim MS_CODE(wCnt)
        For Each wRow As GridViewRow In Me.GrvList.Rows
            ReDim Preserve MS_CODE(wCnt)
            MS_CODE(wCnt).CODE = Me.CODE.Value
            MS_CODE(wCnt).DATA_ID = wRow.Cells(CellIndex.DATA_ID).Text
            MS_CODE(wCnt).DISP_VALUE = wRow.Cells(CellIndex.DISP_VALUE).Text
            MS_CODE(wCnt).DISP_TEXT = Trim(CType(wRow.Cells(CellIndex.Template1).FindControl("DISP_TEXT"), TextBox).Text)
            wCnt += 1
        Next
    End Sub

    'データ登録
    Private Function InsertData() As Boolean
        Dim wCnt As Integer = UBound(MS_CODE)
        Dim strSQL As String

        MS_CODE(wCnt).DATA_ID = MyModule.GetMaxDATA_ID(Me.CODE.Value, MyBase.DbConnection)

        MyBase.BeginTransaction()
        Try
            'データ登録
            strSQL = SQL.MS_CODE.Insert(MS_CODE(wCnt))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode, MS_CODE(wCnt), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode, MS_CODE(wCnt), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        Dim wCnt As Integer
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            'データ更新
            For wCnt = LBound(MS_CODE) To UBound(MS_CODE)
                strSQL = SQL.MS_CODE.Update(MS_CODE(wCnt))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            Next wCnt

            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode, MS_CODE(0), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode, MS_CODE(0), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

End Class
