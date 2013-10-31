Imports CommonLib
Imports AppLib
Partial Public Class MstShisetsu
    Inherits WebBase

    Private MS_SHISETSU() As TableDef.MS_SHISETSU.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private SEQ As Integer

    'グリッド列
    Private Enum CellIndex
        Button1
        SHISETSU_NAME
        ADDRESS1
        ADDRESS2
        STOP_FLG
        SYSTEM_ID
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MS_SHISETSU) = MS_SHISETSU
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
            .PageTitle = "施設マスタメンテナンス"
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
            MS_SHISETSU = Session.Item(SessionDef.MS_SHISETSU)
            If MS_SHISETSU Is Nothing Then ReDim MS_SHISETSU(0)
        Catch ex As Exception
            ReDim MS_SHISETSU(0)
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
        'プルダウン設定
        AppModule.SetDropDownList_ADDRESS1(Me.JokenADDRESS1)

        'IME設定
        CmnModule.SetIme(Me.JokenSHISETSU_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.SHISETSU_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.SHISETSU_KANA, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ZIP_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ZIP_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ADDRESS2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.TEL_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TEL_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TEL_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKIN_TIME_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKIN_TIME_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKOUT_TIME_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKOUT_TIME_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SHISETSU_URL, CmnModule.ImeType.Disabled)

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
            wStr &= "施設情報を" & AppModule.GetName_RECORD_KUBUN(Session.Item(SessionDef.RECORD_KUBUN)) & "しました。"
            wStr &= CmnConst.Html.Break
            wStr &= CmnConst.Html.Break
            wStr &= "施設名＝" & MS_SHISETSU(SEQ).SHISETSU_NAME
            wStr &= CmnConst.Html.Break
            wStr &= "住所＝" & "〒" & MS_SHISETSU(SEQ).ZIP & CmnConst.Html.Space _
                  & MS_SHISETSU(SEQ).ADDRESS1 & MS_SHISETSU(SEQ).ADDRESS2
            If MS_SHISETSU(SEQ).STOP_FLG = AppConst.STOP_FLG.Code.Stop Then
                wStr &= CmnConst.Html.Break
                wStr &= "(利用停止)"
            End If
            Me.LabelMessage.Text = wStr

            Me.DivMessage.Visible = True
            Me.LabelMessage.Visible = True
        End If

        Me.TblRegist.Visible = False

        AppModule.SetForm_ADDRESS1(Joken.ADDRESS1, Me.JokenADDRESS1)
        AppModule.SetForm_SHISETSU_NAME(Joken.SHISETSU_NAME, Me.JokenSHISETSU_NAME)

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

        ReDim MS_SHISETSU(wCnt)
        strSQL = SQL.MS_SHISETSU.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve MS_SHISETSU(wCnt)
            MS_SHISETSU(wCnt) = AppModule.SetRsData(RsData, MS_SHISETSU(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.MS_SHISETSU.Search(Joken)
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
                Session.Item(SessionDef.SYSTEM_ID) = MS_SHISETSU(SEQ).SYSTEM_ID

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
        Joken.ADDRESS1 = CmnModule.GetSelectedItemValue(Me.JokenADDRESS1)
        Joken.SHISETSU_NAME = Trim(Me.JokenSHISETSU_NAME.Text)
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

        CmnModule.ClearControl(Me.JokenADDRESS1)
        CmnModule.ClearControl(Me.JokenSHISETSU_NAME)
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

        If Not CmnCheck.IsInput(Me.JokenADDRESS1) AndAlso _
           Not CmnCheck.IsInput(Me.JokenSHISETSU_NAME) AndAlso _
           Not CmnCheck.IsInput(Me.JokenSTOP_FLG) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput_Joken, Me)
            Return False
        End If

        Return True
    End Function

    '[新規施設登録]
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
        'プルダウン設定
        AppModule.SetDropDownList_ADDRESS1(Me.ADDRESS1)

        'IME設定
        CmnModule.SetIme(Me.SHISETSU_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.SHISETSU_KANA, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ZIP_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ZIP_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ADDRESS2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.TEL_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TEL_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TEL_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKIN_TIME_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKIN_TIME_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKOUT_TIME_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.CHECKOUT_TIME_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SHISETSU_URL, CmnModule.ImeType.Disabled)

        If Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update Then
            '変更時
            Me.DivMessage.Visible = False
            Me.BtnSubmit.Text = "変更"

            AppModule.SetForm_SHISETSU_NAME(MS_SHISETSU(SEQ).SHISETSU_NAME, Me.SHISETSU_NAME)
            AppModule.SetForm_SHISETSU_KANA(MS_SHISETSU(SEQ).SHISETSU_KANA, Me.SHISETSU_KANA)
            AppModule.SetForm_ZIP(MS_SHISETSU(SEQ).ZIP, Me.ZIP_1, Me.ZIP_2)
            AppModule.SetForm_ADDRESS1(MS_SHISETSU(SEQ).ADDRESS1, Me.ADDRESS1)
            AppModule.SetForm_ADDRESS2(MS_SHISETSU(SEQ).ADDRESS2, Me.ADDRESS2)
            AppModule.SetForm_TEL(MS_SHISETSU(SEQ).TEL, Me.TEL_1, Me.TEL_2, Me.TEL_3)
            AppModule.SetForm_CHECKIN_TIME(MS_SHISETSU(SEQ).CHECKIN_TIME, Me.CHECKIN_TIME_1, Me.CHECKIN_TIME_2)
            AppModule.SetForm_CHECKOUT_TIME(MS_SHISETSU(SEQ).CHECKOUT_TIME, Me.CHECKOUT_TIME_1, Me.CHECKOUT_TIME_2)
            AppModule.SetForm_URL(MS_SHISETSU(SEQ).URL, Me.SHISETSU_URL)
            AppModule.SetForm_STOP_FLG(MS_SHISETSU(SEQ).STOP_FLG, Me.STOP_FLG)
            Me.SYSTEM_ID.Value = MS_SHISETSU(SEQ).SYSTEM_ID
        Else
            '登録時
            Me.DivMessage.Visible = False
            Me.BtnSubmit.Text = "登録"
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
            Me.SYSTEM_ID.Value = MS_SHISETSU(SEQ).SYSTEM_ID

            '再取得＋行数取得
            Dim strSQL As String = SQL.MS_SHISETSU.AllData()
            Dim RsData As System.Data.SqlClient.SqlDataReader
            Dim wCnt As Integer = 0
            ReDim MS_SHISETSU(wCnt)
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            While RsData.Read()
                ReDim Preserve MS_SHISETSU(wCnt)
                MS_SHISETSU(wCnt) = AppModule.SetRsData(RsData, MS_SHISETSU(wCnt))

                If Val(MS_SHISETSU(wCnt).SYSTEM_ID) = Val(Me.SYSTEM_ID.Value) Then
                    SEQ = wCnt
                    Session.Item(SessionDef.SEQ) = SEQ
                End If
                wCnt += 1
            End While

            Response.Redirect(URL.MstShisetsu & "?" & RequestDef.DbInsertEnd & "=" & CmnConst.Flag.On)
        End If
    End Sub

    '入力チェック(登録/変更)
    Private Function Check_Regist() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.SHISETSU_NAME) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_SHISETSU.Name.SHISETSU_NAME), Me)
            Return False
        End If

        If MyModule.IsInsertMode() Then
            If CmnDb.IsExist(SQL.MS_SHISETSU.bySHISETSU_NAME(Trim(Me.SHISETSU_NAME.Text)), MyBase.DbConnection) Then
                CmnModule.AlertMessage(MessageDef.Error.IsRegistered("入力された施設名"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.SHISETSU_KANA) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_SHISETSU.Name.SHISETSU_KANA), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.ZIP_1, Me.ZIP_2) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_SHISETSU.Name.ZIP), Me)
            Return False
        Else
            If Not CmnCheck.IsValidZip(Me.ZIP_1, Me.ZIP_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.MS_SHISETSU.Name.ZIP), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.ADDRESS1) Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.MS_SHISETSU.Name.ADDRESS1), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.ADDRESS2) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_SHISETSU.Name.ADDRESS2), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.TEL_1, Me.TEL_2, Me.TEL_3) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_SHISETSU.Name.TEL), Me)
            Return False
        Else
            If Not CmnCheck.IsValidTel(Me.TEL_1, Me.TEL_2, Me.TEL_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.MS_SHISETSU.Name.TEL), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.CHECKIN_TIME_1, Me.CHECKIN_TIME_2) Then
        Else
            If Not CmnCheck.IsValidTime(Me.CHECKIN_TIME_1, Me.CHECKIN_TIME_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.MS_SHISETSU.Name.CHECKIN_TIME), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.CHECKOUT_TIME_1, Me.CHECKOUT_TIME_2) Then
        Else
            If Not CmnCheck.IsValidTime(Me.CHECKOUT_TIME_1, Me.CHECKOUT_TIME_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.MS_SHISETSU.Name.CHECKOUT_TIME), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.SHISETSU_URL) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_SHISETSU.Name.URL), Me)
            Return False
        End If

        Return True
    End Function

    '入力値を取得
    Private Sub GetValue()
        MS_SHISETSU(SEQ).SHISETSU_NAME = AppModule.GetValue_SHISETSU_NAME(Me.SHISETSU_NAME)
        MS_SHISETSU(SEQ).SHISETSU_KANA = AppModule.GetValue_SHISETSU_KANA(Me.SHISETSU_KANA)
        MS_SHISETSU(SEQ).ZIP = AppModule.GetValue_ZIP(Me.ZIP_1, Me.ZIP_2)
        MS_SHISETSU(SEQ).ADDRESS1 = AppModule.GetValue_ADDRESS1(Me.ADDRESS1)
        MS_SHISETSU(SEQ).ADDRESS2 = AppModule.GetValue_ADDRESS2(Me.ADDRESS2)
        MS_SHISETSU(SEQ).TEL = AppModule.GetValue_TEL(Me.TEL_1, Me.TEL_2, Me.TEL_3)
        MS_SHISETSU(SEQ).CHECKIN_TIME = AppModule.GetValue_CHECKIN_TIME(Me.CHECKIN_TIME_1, Me.CHECKIN_TIME_2)
        MS_SHISETSU(SEQ).CHECKOUT_TIME = AppModule.GetValue_CHECKOUT_TIME(Me.CHECKOUT_TIME_1, Me.CHECKOUT_TIME_2)
        MS_SHISETSU(SEQ).URL = AppModule.GetValue_URL(Me.SHISETSU_URL)
        MS_SHISETSU(SEQ).STOP_FLG = AppModule.GetValue_STOP_FLG(Me.STOP_FLG)
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

        MS_SHISETSU(SEQ).SYSTEM_ID = MyModule.GetMaxSYSTEM_ID(AppModule.TableType.MS_SHISETSU, MyBase.DbConnection)
        MS_SHISETSU(SEQ).INPUT_USER = Session.Item(SessionDef.LoginID)
        MS_SHISETSU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

        MyBase.BeginTransaction()
        Try
            'データ登録
            strSQL = SQL.MS_SHISETSU.Insert(MS_SHISETSU(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu, MS_SHISETSU(SEQ), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu, MS_SHISETSU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        Dim strSQL As String

        MS_SHISETSU(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

        MyBase.BeginTransaction()
        Try
            'データ更新
            strSQL = SQL.MS_SHISETSU.Update(MS_SHISETSU(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu, MS_SHISETSU(SEQ), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu, MS_SHISETSU(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

End Class
