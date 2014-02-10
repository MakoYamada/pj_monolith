Imports CommonLib
Imports AppLib
Partial Public Class MstCode
    Inherits WebBase

    Private MS_CODE() As TableDef.MS_CODE.DataStruct
    Private wRowNo As Integer

    'TblRegist1
    '    以下のコントロール名の末尾＝1
    '    コード、名称を設定するもの
    'TblRegist2
    '    以下のコントロール名の末尾＝2
    '    部屋タイプ(名称とコードが同じ値)
    'TblRegist3
    '    以下のコントロール名の末尾＝3
    '    タクチケ発券手数料(1レコードのみ、名称とコードが同じ値)

    'グリッド列
    Private Enum CellIndex1
        DISP_VALUE
        Template1
        DISP_TEXT
        CODE
        DATA_ID
    End Enum
    Private Enum CellIndex2
        DISP_VALUE
        Template1
        DISP_TEXT
        CODE
        DATA_ID
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MstCode) = MS_CODE
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

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
            .PageTitle = "【ステータス】コードマスタ"
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            MS_CODE = Session.Item(SessionDef.MstCode)
            If MS_CODE Is Nothing Then ReDim MS_CODE(0)
        Catch ex As Exception
            ReDim MS_CODE(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定
        CmnModule.SetIme(Me.DISP_TEXT1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.DISP_VALUE1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.DISP_TEXT2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.DISP_TEXT3, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)

        Me.TblRegist1.Visible = False
        Me.TblRegist2.Visible = False
        Me.TblRegist3.Visible = False
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

    '画面項目 表示
    Private Sub SetForm()
        Me.CODE.Value = CmnModule.GetSelectedItemValue(Me.JokenCODE)
        Me.DISP_VALUE1.Text = ""
        Me.DISP_TEXT1.Text = ""
        Me.DISP_TEXT2.Text = ""
        Me.DISP_TEXT3.Text = ""

        'データ取得
        If Not GetData() Then
            Me.TblUpdate.Visible = False
            Me.TblInsert.Visible = False
        Else
            Me.TblRegist1.Visible = False
            Me.TblRegist2.Visible = False
            Me.TblRegist3.Visible = False

            Select Case Me.CODE.Value
                Case AppConst.MS_CODE.ROOM_TYPE
                    Me.TblRegist2.Visible = True
                    SetGridView2()
                Case AppConst.MS_CODE.TAXI_TESURYO
                    Me.TblRegist3.Visible = True
                    SetForm3()
                Case Else
                    Me.TblRegist1.Visible = True
                    SetGridView1()
            End Select

            'グリッドビュー表示
            SetGridView1()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView1()
        'データソース設定
        Dim strSQL As String = SQL.MS_CODE.byCODE(CmnModule.GetSelectedItemValue(Me.JokenCODE))
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        wRowNo = 0
        With Me.GrvList1
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
    Protected Sub GrvList1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList1.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'IME設定
            CmnModule.SetIme(CType(e.Row.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox), CmnModule.ImeType.Active)

            CType(e.Row.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox).Text = CmnModule.ClearHtmlSpace(e.Row.Cells(CellIndex1.DISP_TEXT).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList1_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList1.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex1.DISP_TEXT).Visible = False
            e.Row.Cells(CellIndex1.CODE).Visible = False
            e.Row.Cells(CellIndex1.DATA_ID).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 3
            Me.GrvList1.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView2()
        'データソース設定
        Dim strSQL As String = SQL.MS_CODE.byCODE(CmnModule.GetSelectedItemValue(Me.JokenCODE))
        Me.SqlDataSource2.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource2.SelectCommand = strSQL

        wRowNo = 0
        With Me.GrvList2
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
    Protected Sub GrvList2_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList2.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'IME設定
            CmnModule.SetIme(CType(e.Row.Cells(CellIndex2.Template1).FindControl("DISP_TEXT"), TextBox), CmnModule.ImeType.Active)

            CType(e.Row.Cells(CellIndex2.Template1).FindControl("DISP_TEXT"), TextBox).Text = CmnModule.ClearHtmlSpace(e.Row.Cells(CellIndex2.DISP_TEXT).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList2_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList2.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex2.DISP_VALUE).Visible = False
            e.Row.Cells(CellIndex2.DISP_TEXT).Visible = False
            e.Row.Cells(CellIndex2.CODE).Visible = False
            e.Row.Cells(CellIndex2.DATA_ID).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 4
            Me.GrvList2.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
        End If
    End Sub

    '[登録]
    Protected Sub BtnInsert1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert1.Click
        '入力チェック
        If Not Check1_Insert() Then Exit Sub

        '入力値を取得
        GetValue1_Insert()

        'データ更新
        If InsertData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '[変更]
    Protected Sub BtnUpdate1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate1.Click
        '入力チェック
        If Not Check1_Update() Then Exit Sub

        '入力値を取得
        GetValue1_Update()

        'データ更新
        If UpdateData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '入力チェック(登録)
    Private Function Check1_Insert() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.DISP_VALUE1) OrElse CmnCheck.IsInput(Me.DISP_TEXT1) Then
            If Not CmnCheck.IsInput(Me.DISP_VALUE1) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("追加枠：コード"), Me)
                Return False
            End If
            If Not CmnCheck.IsInput(Me.DISP_TEXT1) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("追加枠：名称"), Me)
                Return False
            End If

            If CmnDb.IsExist(SQL.MS_CODE.byCODE_DISP_VALUE(Me.CODE.Value, Trim(StrConv(Me.DISP_VALUE1.Text, VbStrConv.Narrow))), MyBase.DbConnection) Then
                CmnModule.AlertMessage(MessageDef.Error.IsRegistered("入力されたコード"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '入力チェック(変更)
    Private Function Check1_Update() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If
 
        '変更
        For Each wRow As GridViewRow In Me.GrvList1.Rows
            If Not CmnCheck.IsInput(CType(wRow.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox)) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("変更：名称"), Me)
                Return False
            End If
        Next

        Return True
    End Function

    '入力値を取得
    '登録
    Private Sub GetValue1_Insert()
        Dim wCnt As Integer = UBound(MS_CODE) + 1

        ReDim Preserve MS_CODE(wCnt)
        MS_CODE(wCnt).CODE = Me.CODE.Value
        MS_CODE(wCnt).DISP_VALUE = Trim(StrConv(Me.DISP_VALUE1.Text, VbStrConv.Narrow))
        MS_CODE(wCnt).DISP_TEXT = Trim(Me.DISP_TEXT1.Text)
    End Sub
    '変更
    Private Sub GetValue1_Update()
        Dim wCnt As Integer = 0

        ReDim MS_CODE(wCnt)
        For Each wRow As GridViewRow In Me.GrvList1.Rows
            ReDim Preserve MS_CODE(wCnt)
            MS_CODE(wCnt).CODE = Me.CODE.Value
            MS_CODE(wCnt).DATA_ID = wRow.Cells(CellIndex1.DATA_ID).Text
            MS_CODE(wCnt).DISP_VALUE = wRow.Cells(CellIndex1.DISP_VALUE).Text
            MS_CODE(wCnt).DISP_TEXT = Trim(CType(wRow.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox).Text)
            wCnt += 1
        Next
    End Sub

    '[登録]
    Protected Sub BtnInsert2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert2.Click
        '入力チェック
        If Not Check2_Insert() Then Exit Sub

        '入力値を取得
        GetValue2_Insert()

        'データ更新
        If InsertData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '[変更]
    Protected Sub BtnUpdate2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate2.Click
        '入力チェック
        If Not Check2_Update() Then Exit Sub

        '入力値を取得
        GetValue2_Update()

        'データ更新
        If UpdateData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '入力チェック(登録)
    Private Function Check2_Insert() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.DISP_TEXT2) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("追加枠：名称"), Me)
            Return False
        End If

        If CmnDb.IsExist(SQL.MS_CODE.byCODE_DISP_TEXT(Me.CODE.Value, Trim(Me.DISP_TEXT2.Text)), MyBase.DbConnection) Then
            CmnModule.AlertMessage(MessageDef.Error.IsRegistered("入力された部屋タイプ"), Me)
            Return False
        End If

        Return True
    End Function

    '入力チェック(変更)
    Private Function Check2_Update() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If
 
        '変更
        For Each wRow As GridViewRow In Me.GrvList2.Rows
            If Not CmnCheck.IsInput(CType(wRow.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox)) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("変更：部屋タイプ名称"), Me)
                Return False
            End If
        Next

        Return True
    End Function

    '入力値を取得
    '登録
    Private Sub GetValue2_Insert()
        Dim wCnt As Integer = UBound(MS_CODE) + 1

        ReDim Preserve MS_CODE(wCnt)
        MS_CODE(wCnt).CODE = Me.CODE.Value
        MS_CODE(wCnt).DISP_VALUE = Trim(Me.DISP_TEXT2.Text)
        MS_CODE(wCnt).DISP_TEXT = Trim(Me.DISP_TEXT2.Text)
    End Sub
    '変更
    Private Sub GetValue2_Update()
        Dim wCnt As Integer = 0

        ReDim MS_CODE(wCnt)
        For Each wRow As GridViewRow In Me.GrvList2.Rows
            ReDim Preserve MS_CODE(wCnt)
            MS_CODE(wCnt).CODE = Me.CODE.Value
            MS_CODE(wCnt).DATA_ID = wRow.Cells(CellIndex1.DATA_ID).Text
            MS_CODE(wCnt).DISP_VALUE = Trim(CType(wRow.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox).Text)
            MS_CODE(wCnt).DISP_TEXT = Trim(CType(wRow.Cells(CellIndex1.Template1).FindControl("DISP_TEXT"), TextBox).Text)
            wCnt += 1
        Next
    End Sub

    '画面項目セット
    Private Sub SetForm3()
        Me.CODE.Value = MS_CODE(0).CODE
        Me.DISP_TEXT3.Text = MS_CODE(0).DISP_TEXT
    End Sub

    '[変更]
    Protected Sub BtnUpdate3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUpdate3.Click
        '入力チェック
        If Not Check3_Update() Then Exit Sub

        '入力値を取得
        GetValue3_Update()

        'データ更新
        If UpdateData() Then
            '再表示
            SetForm()
        End If
    End Sub

    '入力チェック(変更)
    Private Function Check3_Update() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.DISP_TEXT3) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("タクシーチケット発券手数料"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.DISP_TEXT3) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("タクシーチケット発券手数料"), Me)
            Return False
        End If

        Return True
    End Function

    '入力値を取得
    '変更
    Private Sub GetValue3_Update()
        MS_CODE(0).DISP_TEXT = Trim(StrConv(Me.DISP_TEXT3.Text, VbStrConv.Narrow))
        MS_CODE(0).DISP_VALUE = MS_CODE(0).DISP_TEXT
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
