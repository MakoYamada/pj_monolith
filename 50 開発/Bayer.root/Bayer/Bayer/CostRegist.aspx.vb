Imports CommonLib
Imports AppLib
Partial Public Class CostRegist
    Inherits WebBase

    Private TBL_COST_Search() As TableDef.TBL_COST.DataStruct
    Private TBL_COST_Update() As TableDef.TBL_COST.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer '_Search用

    Private lngKotsuhiKei As Long = 0
    Private lngHotelhiKei As Long = 0
    Private lngTaxiKei As Long = 0
    Private lngTaxiSeisanKei As Long = 0

    'グリッド列
    Private Enum CellIndex_Search
        Button1 = 0
        SEIKYU_NO
        SEIKYU_YM
    End Enum

    Private Enum CellIndex_Update
        COSTCENTER = 0
        KOTSUHI
        HOTELHI
        TAXI_T
        TAXI_SEISAN_T
        TOTAL
        chkDelete
        COSTCENTER_CD
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.CostRegist_Search) = TBL_COST_Search
        Session.Item(SessionDef.CostRegist_Update) = TBL_COST_Update
        Session.Item(SessionDef.Joken) = Joken
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

            '画面項目表示
            If Trim(Request.QueryString(RequestDef.DbInsertEnd)) = CmnConst.Flag.On Then
                SetForm(True)
            Else
                SetForm()
            End If
        End If

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True
            .PageTitle = "コストセンター別費用入力"
        End With
    End Sub

    'セッションを変数に格納    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Try
            TBL_COST_Search = Session.Item(SessionDef.CostRegist_Search)
            If TBL_COST_Search Is Nothing Then ReDim TBL_COST_Search(0)
        Catch ex As Exception
            ReDim TBL_COST_Search(0)
        End Try
        Try
            TBL_COST_Update = Session.Item(SessionDef.CostRegist_Update)
            If TBL_COST_Update Is Nothing Then ReDim TBL_COST_Update(0)
        Catch ex As Exception
            ReDim TBL_COST_Update(0)
        End Try
        Try
            SEQ = CmnModule.DbVal(Session.Item(SessionDef.SEQ))
        Catch ex As Exception
            SEQ = 0
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'IME設定        CmnModule.SetIme(Me.JokenSEIKYU_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEIKYU_YM, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm(Optional ByVal DispMessage As Boolean = False)
        If DispMessage = False Then
            Me.DivMessage.Visible = False
            Me.TblRegist.Visible = False
        Else
            Me.DivMessage.Visible = True
            Dim wStr As String = ""
            wStr &= "コストセンター別費用情報を" & AppModule.GetName_RECORD_KUBUN(Session.Item(SessionDef.RECORD_KUBUN)) & "しました。"
            wStr &= CmnConst.Html.Break
            wStr &= CmnConst.Html.Break
            wStr &= "請求番号＝" & TBL_COST_Update(0).SEIKYU_NO
            wStr &= CmnConst.Html.Break
            wStr &= "請求年月＝" & TBL_COST_Update(0).SEIKYU_YM
            Me.LabelMessage.Text = wStr

            Me.DivMessage.Visible = True
            Me.LabelMessage.Visible = True

            Me.TblRegist.Visible = True
            'TODO:UPDATEした場合は、キー項目が入力できてはだめ

            'TODO:要確認
            SetGridViewUpdate(TBL_COST_Update(0).SEIKYU_NO, TBL_COST_Update(0).SEIKYU_YM)
            'DispMessage = 1のままになるのでは？？それで影響はない？
        End If

        'Me.TblRegist.Visible = False

        'Me.JokenSEIKYU_NO.Text = Joken.SEIKYU_NO
        'AppModule.SetForm_USER_NAME(Joken.USER_NAME, Me.JokenSEIKYU_YM)
        'AppModule.SetForm_KENGEN(Joken.KENGEN, Me.JokenKENGEN_Admin, Me.JokenKENGEN_User)
        'AppModule.SetForm_STOP_FLG(Joken.STOP_FLG, Me.JokenSTOP_FLG)

        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True

            'グリッドビュー表示
            SetGridViewSearch()
        End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        ReDim TBL_COST_Search(wCnt)
        strSQL = SQL.TBL_COST.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_COST_Search(wCnt)
            TBL_COST_Search(wCnt) = AppModule.SetRsData(RsData, TBL_COST_Search(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridViewSearch()

        Dim strSQL As String = SQL.TBL_COST.Search(Joken)
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

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

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        ''入力チェック(条件)
        'If Not Check_Joken() Then Exit Sub

        Joken = Nothing
        Joken.SEIKYU_NO = Trim(Me.JokenSEIKYU_NO.Text)
        Joken.SEIKYU_YM = Trim(Me.JokenSEIKYU_YM.Text)
        'If CmnCheck.IsInput(Me.JokenKENGEN_Admin) OrElse CmnCheck.IsInput(Me.JokenKENGEN_User) Then
        '    If CmnCheck.IsInput(Me.JokenKENGEN_Admin) AndAlso Not CmnCheck.IsInput(Me.JokenKENGEN_User) Then
        '        Joken.KENGEN = AppConst.MS_USER.KENGEN.Code.Admin
        '    End If
        '    If Not CmnCheck.IsInput(Me.JokenKENGEN_Admin) AndAlso CmnCheck.IsInput(Me.JokenKENGEN_User) Then
        '        Joken.KENGEN = AppConst.MS_USER.KENGEN.Code.User
        '    End If
        'End If
        Session.Item(SessionDef.Joken) = Joken

        '画面項目表示
        SetForm()
    End Sub

    '[行追加]
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click

        GetUpdateValue()
        Dim indexMax As Integer = TBL_COST_Update.Length
        '表示している値の配列の最大値に""をセット
        ReDim Preserve TBL_COST_Update(indexMax)
        TBL_COST_Update(indexMax).KOTSUHI = ""
        TBL_COST_Update(indexMax).HOTELHI = ""
        TBL_COST_Update(indexMax).TAXI_T = ""
        TBL_COST_Update(indexMax).TAXI_SEISAN_T = ""
        '再バインド
        Me.GrvUpdate.DataSource = TBL_COST_Update
        Me.GrvUpdate.DataBind()
        '今画面に表示している値をセッションへ
        Session.Item(SessionDef.CostRegist_Search) = TBL_COST_Search
    End Sub

    '[新規登録]
    Protected Sub BtnRegist_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegist.Click
        Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert
        Session.Item(SessionDef.SEQ) = 0
        Me.DivMessage.Visible = False
        Me.TblRegist.Visible = True

        '登録枠
        SetForm_Regist()
    End Sub

    '登録枠
    Private Sub SetForm_Regist()

        'IME設定        CmnModule.SetIme(Me.SEIKYU_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYU_YM, CmnModule.ImeType.Disabled)

        If Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update Then
            '変更時
            Me.SEIKYU_NO.Visible = False
            Me.SEIKYU_YM.Visible = False
            Me.DispSEIKYU_NO.Visible = True
            Me.DispSEIKYU_YM.Visible = True
            Me.DivMessage.Visible = False
            Me.BtnSubmit.Text = "変更"

            Me.DispSEIKYU_NO.Text = TBL_COST_Search(SEQ).SEIKYU_NO
            Me.DispSEIKYU_YM.Text = TBL_COST_Search(SEQ).SEIKYU_YM
            SetGridViewUpdate(Me.DispSEIKYU_NO.Text, Me.DispSEIKYU_YM.Text)

        Else
            '登録時
            Me.SEIKYU_NO.Visible = True
            Me.SEIKYU_YM.Visible = True
            Me.DispSEIKYU_NO.Visible = False
            Me.DispSEIKYU_YM.Visible = False
            Me.DivMessage.Visible = False
            Me.BtnSubmit.Text = "登録"
            SetGridViewUpdate("", "")
        End If
    End Sub

    'データソース設定
    Private Sub SetGridViewUpdate(ByVal SEIKYU_NO As String, ByVal SEIKYU_YM As String)
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim RsData As System.Data.SqlClient.SqlDataReader

        ReDim TBL_COST_Update(wCnt)
        Dim strSQL As String = SQL.TBL_COST.bySEIKYU_NO_SEIKYU_YM(SEIKYU_NO, SEIKYU_YM)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_COST_Update(wCnt)
            TBL_COST_Update(wCnt) = AppModule.SetRsData(RsData, TBL_COST_Update(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If Not wFlag Then
            TBL_COST_Update(0).KOTSUHI = ""
            TBL_COST_Update(0).HOTELHI = ""
            TBL_COST_Update(0).TAXI_T = ""
            TBL_COST_Update(0).TAXI_SEISAN_T = ""
        End If

        Me.GrvUpdate.DataSource = TBL_COST_Update
        Me.GrvUpdate.DataBind()


        'With Me.GrvList
        '    Try
        '        .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
        '        .DataBind()
        '    Catch ex As Exception
        '        Session.Item(SessionDef.PageIndex) = 0
        '        .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
        '        .DataBind()
        '    End Try
        '    .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        'End With



    End Sub


    '検索結果一覧
    'グリッドビュー内書式設定
    Private Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex_Search.SEIKYU_YM).Text = Mid(CmnModule.Format_DateJP(e.Row.Cells(CellIndex_Search.SEIKYU_YM).Text & "01", CmnModule.DateFormatType.YYYYMMDD), 1, 8)
        End If
    End Sub

    'グリッドビュー コマンドボタン押下時
    Protected Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Select Case e.CommandName
            Case "Regist"
                SEQ = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.SEQ) = SEQ
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update

                Me.DivMessage.Visible = False
                Me.TblRegist.Visible = True

                '登録枠
                SetForm_Regist()
        End Select
    End Sub

    'グリッドビュー ページ移動時
    Private Sub GrvList_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrvList.PageIndexChanged
        With Me.GrvList
            '選択行をキャンセル
            .SelectedIndex = -1
            'カレントページを変更
            Session.Item(SessionDef.PageIndex) = .PageIndex

            'グリッドビュー表示
            SetGridViewSearch()
        End With
    End Sub

    '更新データ一覧
    'グリッドビュー 行作成時
    Private Sub GrvUpdate_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvUpdate.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex_Update.COSTCENTER_CD).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 2
            Me.GrvList.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
        End If
    End Sub

    'グリッドビュー内書式設定
    Private Sub GrvUpdate_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvUpdate.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then
            'プルダウン設定
            AppModule.SetDropDownList_COSTCENTER(DirectCast(e.Row.FindControl("ddlCostCenter"), DropDownList), MyBase.DbConnection)
            DirectCast(e.Row.FindControl("ddlCostCenter"), DropDownList).SelectedValue = e.Row.Cells(CellIndex_Update.COSTCENTER_CD).Text
            'DirectCast(e.Row.FindControl("COSTCENTER_NAME"), Label).Text = GetCostCenterName(e.Row.Cells(CellIndex_Update.COSTCENTER_CD).Text)


            'TODO:変更後⇒再計算ボタン押下⇒隠しフィールドのコードから名称取得で本当に問題ないのか？
            DirectCast(e.Row.FindControl("COSTCENTER_NAME"), TextBox).Text = MyModule.GetCostCenterName(e.Row.Cells(CellIndex_Update.COSTCENTER_CD).Text, MyBase.DbConnection)


            'コストセンター計算出
            Dim lngKei As Long = _
            CmnModule.DbVal(DirectCast(e.Row.FindControl("KOTSUHI"), TextBox).Text.Trim) + _
            CmnModule.DbVal(DirectCast(e.Row.FindControl("HOTELHI"), TextBox).Text.Trim) + _
            CmnModule.DbVal(DirectCast(e.Row.FindControl("TAXI_T"), TextBox).Text.Trim) + _
            CmnModule.DbVal(DirectCast(e.Row.FindControl("TAXI_SEISAN_T"), TextBox).Text.Trim)

            DirectCast(e.Row.FindControl("KEI"), Label).Text = CmnModule.EditComma(lngKei.ToString)


            '請求額合計算出
            lngKotsuhiKei += CmnModule.DbVal(DirectCast(e.Row.FindControl("KOTSUHI"), TextBox).Text)
            lngHotelhiKei += CmnModule.DbVal(DirectCast(e.Row.FindControl("HOTELHI"), TextBox).Text)
            lngTaxiKei += CmnModule.DbVal(DirectCast(e.Row.FindControl("TAXI_T"), TextBox).Text)
            lngTaxiSeisanKei += CmnModule.DbVal(DirectCast(e.Row.FindControl("TAXI_SEISAN_T"), TextBox).Text)

        ElseIf e.Row.RowType = DataControlRowType.Footer Then
            e.Row.Cells(CellIndex_Update.COSTCENTER).Text = "請求額合計"
            e.Row.Cells(CellIndex_Update.KOTSUHI).Text = CmnModule.EditComma(lngKotsuhiKei.ToString)
            e.Row.Cells(CellIndex_Update.HOTELHI).Text = CmnModule.EditComma(lngHotelhiKei.ToString)
            e.Row.Cells(CellIndex_Update.TAXI_T).Text = CmnModule.EditComma(lngTaxiKei.ToString)
            e.Row.Cells(CellIndex_Update.TAXI_SEISAN_T).Text = CmnModule.EditComma(lngTaxiSeisanKei.ToString)
        End If
    End Sub

    'GrvUpdateのプルダウンの選択値変更時
    Protected Sub ddlCostCenter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim ddlist As DropDownList = sender
        Dim name As String = MyModule.GetCostCenterName(ddlist.SelectedValue, MyBase.DbConnection)

        Dim index As Integer
        'index = DirectCast(ddlist.Parent.Parent, GridViewRow).RowIndex
        'DirectCast(DirectCast(ddlist.Parent.Parent, GridViewRow).FindControl("COSTCENTER_NAME"), Label).Text = name

        Dim nowGvRow As GridViewRow = GetGridViewRow(ddlist)

        If Not nowGvRow Is Nothing Then
            index = nowGvRow.RowIndex
            'DirectCast(nowGvRow.FindControl("COSTCENTER_NAME"), Label).Text = name
            DirectCast(nowGvRow.FindControl("COSTCENTER_NAME"), TextBox).Text = name
        End If

    End Sub

    'GridViewのItemTemplateに配置したコントロールがある行(GridViewRow)を取得する
    Private Function GetGridViewRow(ByVal ctl As Control) As GridViewRow

        Dim item As GridViewRow

        While (Not ctl Is Nothing)
            Try
                item = DirectCast(ctl, GridViewRow)
                If (Not item Is Nothing) Then
                    Return item
                End If
            Catch ex As Exception
            End Try

            ctl = ctl.Parent '一階層上のコントロールを取得する
        End While

        Return Nothing
    End Function

    '[再計算]
    Protected Sub BtnCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCalc.Click

        'TODO:入力チェック

        '画面の値を取得
        GetUpdateValue()

        '再バインド(GrvUpdate_RowDataBoundイベントを発生させるため)
        Me.GrvUpdate.DataSource = TBL_COST_Update
        Me.GrvUpdate.DataBind()
    End Sub

    '[登録/変更]ボタン
    Protected Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSubmit.Click

        '入力チェック(登録/変更)
        If Not Check_Regist() Then Exit Sub

        '入力値を取得        GetUpdateValue()

        'データ更新
        If ExecuteTransaction() Then

            '検索結果再取得＋行数取得
            Dim strSQL As String
            strSQL = SQL.TBL_COST.bySEIKYU_NO_SEIKYU_YM(Me.JokenSEIKYU_NO.Text, Me.JokenSEIKYU_YM.Text)
            Dim RsData As System.Data.SqlClient.SqlDataReader
            Dim wCnt As Integer = 0
            ReDim TBL_COST_Search(wCnt)
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            While RsData.Read()
                ReDim Preserve TBL_COST_Search(wCnt)
                TBL_COST_Search(wCnt) = AppModule.SetRsData(RsData, TBL_COST_Search(wCnt))

                If TBL_COST_Search(wCnt).COSTCENTER_CD <> "" Then
                    SEQ = wCnt
                    Session.Item(SessionDef.SEQ) = SEQ
                End If
                wCnt += 1
            End While

            ''TODO:更新対象データ
            'strSQL = SQL.TBL_COST.bySEIKYU_NO_SEIKYU_YM(Me.JokenSEIKYU_NO.Text, Me.JokenSEIKYU_YM.Text)

            Response.Redirect(URL.CostRegist & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '入力チェック(登録/変更)
    Private Function Check_Regist() As Boolean

        '必須入力
        If Me.SEIKYU_NO.Visible = True Then
            If Not CmnCheck.IsInput(Me.SEIKYU_NO) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_COST.Name.SEIKYU_NO), Me)
                Return False
            End If

            If Not CmnCheck.IsInput(Me.SEIKYU_YM) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_COST.Name.SEIKYU_YM), Me)
                Return False
            End If
        End If


        'TODO:Insesrt のときはここで、キー重複データ存在チェックする？

        'TODO:現在の画面上にコストセンターコードが同じレコードがないかチェックすること

        Return True
    End Function

    '入力値を取得
    Private Sub GetUpdateValue()

        Dim wCnt As Integer = 0
        ReDim TBL_COST_Update(wCnt)

        For Each gvRow As GridViewRow In Me.GrvUpdate.Rows
            ReDim Preserve TBL_COST_Update(wCnt)

            If Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert Then
                TBL_COST_Update(wCnt).SEIKYU_NO = Me.SEIKYU_NO.Text
                TBL_COST_Update(wCnt).SEIKYU_YM = Me.SEIKYU_YM.Text
            Else
                TBL_COST_Update(wCnt).SEIKYU_NO = Me.DispSEIKYU_NO.Text
                TBL_COST_Update(wCnt).SEIKYU_YM = Me.DispSEIKYU_YM.Text
            End If

            TBL_COST_Update(wCnt).COSTCENTER_CD = DirectCast(gvRow.FindControl("ddlCostCenter"), DropDownList).SelectedItem.Value
            TBL_COST_Update(wCnt).KOTSUHI = DirectCast(gvRow.FindControl("KOTSUHI"), TextBox).Text.Trim
            TBL_COST_Update(wCnt).HOTELHI = DirectCast(gvRow.FindControl("HOTELHI"), TextBox).Text.Trim
            TBL_COST_Update(wCnt).TAXI_T = DirectCast(gvRow.FindControl("TAXI_T"), TextBox).Text.Trim
            TBL_COST_Update(wCnt).TAXI_SEISAN_T = DirectCast(gvRow.FindControl("TAXI_SEISAN_T"), TextBox).Text.Trim

            wCnt += 1
        Next
    End Sub

    'データ登録/更新
    Private Function ExecuteTransaction() As Boolean
        If Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert Then
            Return InsertData()
        ElseIf Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update Then
            Return UpdateData()
        End If
    End Function

    'データ登録
    Private Function InsertData() As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            For idx As Integer = 0 To TBL_COST_Update.Length - 1

                ''コストセンターコードが入力されていてかつDEL_FLAGのチェックがついていないレコードをINS
                'If TBL_COST_Update(idx).COSTCENTER_CD <> CmnConst.Flag.off AndAlso _
                '   TBL_COST_Update(idx).DEL_FLAG = CmnConst.Flag.On Then

                'End If

                TBL_COST_Update(idx).SAP_FLAG = AppConst.COST.SAP_FLAG.Code.Mi
                TBL_COST_Update(idx).INPUT_USER = Session.Item(SessionDef.LoginID)
                TBL_COST_Update(idx).UPDATE_USER = Session.Item(SessionDef.LoginID)

                'データ登録
                strSQL = SQL.TBL_COST.Insert(TBL_COST_Update(idx))
                CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)


                ''ログ登録
                'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MSTUSER, TBL_COST(idx), True, "", MyBase.DbConnection)
            Next idx

            MyBase.Commit()

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            ''ログ登録
            'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MSTUSER, TBL_COST(idx), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try

    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try

            ''一括削除
            'strSQL = SQL.TBL_COST.Delete(TBL_COST_Update(0))
            'CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            For idx As Integer = 0 To TBL_COST_Update.Length - 1

                ''コストセンターコードが入力されていてかつDEL_FLAGのチェックがついていないレコードをUPD
                'If TBL_COST_Update(idx).COSTCENTER_CD <> CmnConst.Flag.off AndAlso _
                '   TBL_COST_Update(idx).DEL_FLAG = CmnConst.Flag.On Then

                'End If

                TBL_COST_Update(idx).SAP_FLAG = AppConst.COST.SAP_FLAG.Code.Mi
                TBL_COST_Update(idx).UPDATE_USER = Session.Item(SessionDef.LoginID)

                'データ更新
                strSQL = SQL.TBL_COST.Update(TBL_COST_Update(idx))
                Dim updCnt As Integer = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                If updCnt = 0 Then
                    'UPDで0件のデータをINS
                End If

                'ログ登録
                'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstUser, TBL_COST(idx), True, "", MyBase.DbConnection)
            Next idx

            MyBase.Commit()

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstUser, TBL_COST(idx), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try

    End Function

End Class