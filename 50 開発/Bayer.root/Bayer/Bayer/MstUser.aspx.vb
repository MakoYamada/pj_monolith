Imports CommonLib
Imports AppLib
Partial Public Class MstUser
    Inherits WebBase

    Private MS_USER() As TableDef.MS_USER.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer

    'グリッド列
    Private Enum CellIndex
        Button1
        LOGIN_ID
        KENGEN
        USER_NAME
        STOP_FLG
        SYSTEM_ID
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MS_USER) = MS_USER
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
            .HideLoginUser = True   'QQQ
            .PageTitle = "ユーザマスタメンテナンス"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Try
            MS_USER = Session.Item(SessionDef.MS_USER)
            If MS_USER Is Nothing Then ReDim MS_USER(0)
        Catch ex As Exception
            ReDim MS_USER(0)
        End Try
        Try
            SEQ = CmnModule.DbVal(Session.Item(SessionDef.SEQ))
        Catch ex As Exception
            SEQ = 0
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定
        CmnModule.SetIme(Me.JokenLOGIN_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenUSER_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.LOGIN_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.PASSWORD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.USER_NAME, CmnModule.ImeType.Active)

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
            wStr &= "ユーザ情報を" & AppModule.GetName_RECORD_KUBUN(Session.Item(SessionDef.RECORD_KUBUN)) & "しました。"
            wStr &= CmnConst.Html.Break
            wStr &= CmnConst.Html.Break
            wStr &= "ログインID＝" & MS_USER(SEQ).LOGIN_ID
            wStr &= CmnConst.Html.Break
            wStr &= "氏名＝" & MS_USER(SEQ).USER_NAME
            If MS_USER(SEQ).STOP_FLG = AppConst.STOP_FLG.Code.Stop Then
                wStr &= CmnConst.Html.Break
                wStr &= "(利用停止)"
            End If
            Me.LabelMessage.Text = wStr

            Me.DivMessage.Visible = True
            Me.LabelMessage.Visible = True
        End If

        Me.TblRegist.Visible = False

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True

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

        ReDim MS_USER(wCnt)
        strSQL = SQL.MS_USER.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve MS_USER(wCnt)
            MS_USER(wCnt) = AppModule.SetRsData(RsData, MS_USER(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.MS_USER.Search(Joken)
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

    'グリッドビュー内書式設定
    Protected Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.KENGEN).Text = AppModule.GetName_KENGEN(e.Row.Cells(CellIndex.KENGEN).Text)
            e.Row.Cells(CellIndex.STOP_FLG).Text = AppModule.GetName_STOP_FLG(e.Row.Cells(CellIndex.STOP_FLG).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.SYSTEM_ID).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 1
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

    'グリッドビュー コマンドボタン押下時
    Protected Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Select Case e.CommandName
            Case "Regist"
                SEQ = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.SEQ) = SEQ
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update
                Session.Item(SessionDef.SYSTEM_ID) = MS_USER(SEQ).SYSTEM_ID
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update

                Me.DivMessage.Visible = False
                Me.TblRegist.Visible = True

                '登録枠
                SetForm_Regist()
        End Select
    End Sub

    '[検索]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック(条件)
        If Not Check_Joken() Then Exit Sub

        Joken = Nothing
        Joken.LOGIN_ID = Trim(Me.JokenLOGIN_ID.Text)
        Joken.USER_NAME = Trim(Me.JokenUSER_NAME.Text)
        If CmnCheck.IsInput(Me.JokenKENGEN_1) OrElse CmnCheck.IsInput(Me.JokenKENGEN_2) Then
            If CmnCheck.IsInput(Me.JokenKENGEN_1) AndAlso Not CmnCheck.IsInput(Me.JokenKENGEN_2) Then
                Joken.KENGEN = AppConst.MS_USER.KENGEN.Code.KENGEN_1
            End If
            If Not CmnCheck.IsInput(Me.JokenKENGEN_1) AndAlso CmnCheck.IsInput(Me.JokenKENGEN_2) Then
                Joken.KENGEN = AppConst.MS_USER.KENGEN.Code.KENGEN_2
            End If
        End If
        If CmnCheck.IsInput(Me.JokenSTOP_FLG) Then
            Joken.STOP_FLG = AppConst.STOP_FLG.Code.Stop
        End If
        Session.Item(SessionDef.Joken) = Joken

        '画面項目表示
        SetForm()
    End Sub

    '[全データ]
    Protected Sub BtnAllData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAllData.Click
        Joken = Nothing
        Session.Item(SessionDef.Joken) = Joken

        CmnModule.ClearControl(Me.JokenLOGIN_ID)
        CmnModule.ClearControl(Me.JokenUSER_NAME)
        CmnModule.ClearControl(Me.JokenKENGEN_1)
        CmnModule.ClearControl(Me.JokenKENGEN_2)
        CmnModule.ClearControl(Me.JokenSTOP_FLG)

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

        If Not CmnCheck.IsInput(Me.JokenLOGIN_ID) AndAlso _
           Not CmnCheck.IsInput(Me.JokenUSER_NAME) AndAlso _
           Not CmnCheck.IsInput(Me.JokenKENGEN_1) AndAlso _
           Not CmnCheck.IsInput(Me.JokenKENGEN_2) AndAlso _
           Not CmnCheck.IsInput(Me.JokenSTOP_FLG) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput_Joken, Me)
            Return False
        End If

        Return True
    End Function

    '[新規ユーザ登録]
    Protected Sub BtnRegist_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRegist.Click
        Session.Item(SessionDef.SYSTEM_ID) = ""
        Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert
        Session.Item(SessionDef.SEQ) = 0
        Me.DivMessage.Visible = False
        Me.TblRegist.Visible = True

        '登録枠
        SetForm_Regist()
    End Sub

    '登録枠
    Private Sub SetForm_Regist()
        If Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update Then
            '変更時
            Me.LOGIN_ID.Visible = False
            Me.DispLOGIN_ID.Visible = True
            Me.DivMessage.Visible = False
            Me.BtnRegist.Text = "変更"

            Me.DispLOGIN_ID.Text = AppModule.GetName_LOGIN_ID(MS_USER(SEQ).LOGIN_ID)
            AppModule.SetForm_LOGIN_ID(MS_USER(SEQ).LOGIN_ID, Me.LOGIN_ID)
            AppModule.SetForm_PASSWORD(MS_USER(SEQ).PASSWORD, Me.PASSWORD)
            AppModule.SetForm_USER_NAME(MS_USER(SEQ).USER_NAME, Me.USER_NAME)
            AppModule.SetForm_KENGEN(MS_USER(SEQ).KENGEN, Me.KENGEN_1, Me.KENGEN_2)
            AppModule.SetForm_STOP_FLG(MS_USER(SEQ).STOP_FLG, Me.STOP_FLG)
            Me.SYSTEM_ID.Value = MS_USER(SEQ).SYSTEM_ID
        Else
            '登録時
            Me.LOGIN_ID.Visible = True
            Me.DispLOGIN_ID.Visible = False
            Me.DivMessage.Visible = False
            Me.BtnRegist.Text = "登録"
            Me.SYSTEM_ID.Value = ""
        End If
    End Sub

    '[登録/変更]
    Protected Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSubmit.Click
        '入力チェック(登録/変更)
        If Not Check_Regist() Then Exit Sub

        '入力値を取得
        GetValue()

        'データ更新
        If ExecuteTransaction() Then
            Me.SYSTEM_ID.Value = MS_USER(SEQ).SYSTEM_ID

            '再取得＋行数取得
            Dim strSQL As String = SQL.MS_USER.AllData()
            Dim RsData As System.Data.SqlClient.SqlDataReader
            Dim wCnt As Integer = 0
            ReDim MS_USER(wCnt)
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            While RsData.Read()
                ReDim Preserve MS_USER(wCnt)
                MS_USER(wCnt) = AppModule.SetRsData(RsData, MS_USER(wCnt))

                If Val(MS_USER(wCnt).SYSTEM_ID) = Val(Me.SYSTEM_ID.Value) Then
                    SEQ = wCnt
                    Session.Item(SessionDef.SEQ) = SEQ
                End If
                wCnt += 1
            End While

            Response.Redirect(URL.MstUser & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '入力チェック(登録/変更)
    Private Function Check_Regist() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Me.LOGIN_ID.Visible = True Then
            If Not CmnCheck.IsInput(Me.LOGIN_ID) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.LOGIN_ID), Me)
                Return False
            End If

            If CmnDb.IsExist(SQL.MS_USER.byLOGIN_ID(Trim(Me.LOGIN_ID.Text)), MyBase.DbConnection) Then
                CmnModule.AlertMessage(MessageDef.Error.IsRegistered("入力されたログインID"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.PASSWORD) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.PASSWORD), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.USER_NAME) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.USER_NAME), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.KENGEN_1, Me.KENGEN_2) Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.MS_USER.Name.KENGEN), Me)
            Return False
        End If

        Return True
    End Function

    '入力値を取得
    Private Sub GetValue()
        If Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert Then
            MS_USER(SEQ).LOGIN_ID = AppModule.GetValue_LOGIN_ID(Me.LOGIN_ID)
        End If
        MS_USER(SEQ).PASSWORD = AppModule.GetValue_PASSWORD(Me.PASSWORD)
        MS_USER(SEQ).USER_NAME = AppModule.GetValue_USER_NAME(Me.USER_NAME)
        MS_USER(SEQ).KENGEN = AppModule.GetValue_KENGEN(Me.KENGEN_1, Me.KENGEN_2)
        MS_USER(SEQ).STOP_FLG = AppModule.GetValue_STOP_FLG(Me.STOP_FLG)
    End Sub

    'データ更新
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

        MS_USER(SEQ).SYSTEM_ID = MyModule.GetMaxSYSTEM_ID(MyBase.DbConnection)

        MyBase.BeginTransaction()
        Try
            'データ更新
            strSQL = SQL.MS_USER.Insert(MS_USER(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        Return True
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            'データ更新
            strSQL = SQL.MS_USER.Update(MS_USER(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        Return True
    End Function

End Class
