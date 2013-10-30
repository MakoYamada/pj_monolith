Imports CommonLib
Imports AppLib
Partial Public Class CostRegist
    Inherits WebBase

    Private TBL_COST_Search() As TableDef.TBL_COST.DataStruct
    Private TBL_COST_Update() As TableDef.TBL_COST.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer

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
        ''共通チェック
        'MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

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
        'CmnModule.SetIme(Me.MR_KOTSUHI1, CmnModule.ImeType.Disabled)
        'CmnModule.SetIme(Me.MR_HOTELHI1, CmnModule.ImeType.Disabled)
        'CmnModule.SetIme(Me.TAXI_T1, CmnModule.ImeType.Active)
        'CmnModule.SetIme(Me.TAXI_SEISAN_T1, CmnModule.ImeType.Active)

        ''プルダウン設定
        'AppModule.SetDropDownList_COSTCENTER(Me.ANS_STATUS_TEHAI)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm(Optional ByVal DispMessage As Boolean = False)
        If DispMessage = False Then
            Me.DivMessage.Visible = False
        Else
            Me.DivMessage.Visible = True
            Dim wStr As String = ""
            wStr &= "コストセンター別費用情報を" & AppModule.GetName_RECORD_KUBUN(Session.Item(SessionDef.RECORD_KUBUN)) & "しました。"
            wStr &= CmnConst.Html.Break
            wStr &= CmnConst.Html.Break
            wStr &= "請求番号＝" & TBL_COST_Search(SEQ).SEIKYU_NO
            wStr &= CmnConst.Html.Break
            wStr &= "請求年月＝" & TBL_COST_Search(SEQ).SEIKYU_YM
            Me.LabelMessage.Text = wStr

            Me.DivMessage.Visible = True
            Me.LabelMessage.Visible = True
        End If

        Me.TblRegist.Visible = False

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

    '[行追加]
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
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
        'CmnModule.SetIme(Me.MR_KOTSUHI1, CmnModule.ImeType.Active)

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

    Private Sub GrvUpdate_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvUpdate.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'プルダウン設定
            AppModule.SetDropDownList_COSTCENTER(DirectCast(e.Row.FindControl("ddlCostCenter"), DropDownList), MyBase.DbConnection)
            DirectCast(e.Row.FindControl("ddlCostCenter"), DropDownList).SelectedValue = e.Row.Cells(CellIndex_Update.COSTCENTER_CD).Text
        End If
    End Sub

    'GrvUpdateのプルダウンの選択値変更時
    Protected Sub ddlCostCenter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Protected Sub ddlCostCenter_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ddlist As DropDownList = sender
        Dim name As String = ""
        name = GetCostCenterName(ddlist.SelectedValue)
        'DirectCast(e.Row.FindControl("COSTCENTER_NAME"), Label).text = 
    End Sub

    '仮
    Private Function GetCostCenterName(ByVal COSTCENTER_CD As String) As String

        Dim strSQL As String = "SELECT COSTCENTER_NAME FROM MS_COSTCENTER WHERE COSTCENTER_CD = N'" & COSTCENTER_CD & "'"
        Dim MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct = AppModule.GetOneRecord(AppModule.TableType.MS_COSTCENTER, strSQL, MyBase.DbConnection)

        Return MS_COSTCENTER.COSTCENTER_NAME

    End Function
End Class