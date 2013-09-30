Imports CommonLib
Imports AppLib
Partial Public Class ShisetsuKensaku
    Inherits WebBase

    Private MS_SHISETSU() As TableDef.MS_SHISETSU.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        Button1
        ADDRESS1
        SHISETSU_NAME
        ZIP
        ADDRESS2
        TEL
        SYSTEM_ID
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MS_SHISETSU) = MS_SHISETSU
        Session.Item(SessionDef.Joken) = Joken
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
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
            .HideLoginUser = True
            .HideLogout = True
            .HideMenu = True
            .PageTitle = "施設検索"
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
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'プルダウン設定
        AppModule.SetDropDownList_ADDRESS1(Me.ADDRESS1)

        'IME設定
        CmnModule.SetIme(Me.ADDRESS2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.SHISETSU_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.SHISETSU_NAME_KANA, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '条件
        If Trim(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1)) <> "" Then
            AppModule.SetForm_ADDRESS1(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1), Me.ADDRESS1)
        End If
        If Trim(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2)) <> "" Then
            AppModule.SetForm_ADDRESS2(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2), Me.ADDRESS2)
        End If
        If Trim(Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME)) <> "" Then
            AppModule.SetForm_SHISETSU_NAME(Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME), Me.SHISETSU_NAME)
        End If
        If Trim(Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME_KANA)) <> "" Then
            AppModule.SetForm_SHISETSU_KANA(Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME_KANA), Me.SHISETSU_NAME_KANA)
        End If

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
        Dim Joken As TableDef.Joken.DataStruct = Nothing

        Joken.ADDRESS1 = CmnModule.GetSelectedItemValue(Me.ADDRESS1)
        Joken.ADDRESS2 = Trim(Me.ADDRESS2.Text)
        Joken.SHISETSU_NAME = Trim(Me.SHISETSU_NAME.Text)
        Joken.SHISETSU_NAME_KANA = Trim(Me.SHISETSU_NAME_KANA.Text)
        Session.Item(SessionDef.Joken) = Joken

        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1) = Joken.ADDRESS1
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2) = Joken.ADDRESS2
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME) = Joken.SHISETSU_NAME
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME_KANA) = Joken.SHISETSU_NAME_KANA

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
            Case "OK"
                Dim SEQ As Integer
                SEQ = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME) = MS_SHISETSU(SEQ).SHISETSU_NAME
                Session.Item(SessionDef.ShisetsuKensaku_ZIP) = MS_SHISETSU(SEQ).ZIP
                Session.Item(SessionDef.ShisetsuKensaku_ADDRESS) = MS_SHISETSU(SEQ).ADDRESS2
                Session.Item(SessionDef.ShisetsuKensaku_TEL) = MS_SHISETSU(SEQ).TEL
                Session.Item(SessionDef.ShisetsuKensaku_URL) = MS_SHISETSU(SEQ).URL

                Dim scriptStr As String = ""
                scriptStr &= "<script language='javascript' type='text/javascript'>"
                scriptStr &= "window.opener.aspnetForm.submit();"
                scriptStr &= "window.close();"
                scriptStr &= "</script>"

                ClientScript.RegisterStartupScript(Me.GetType(), "OK", scriptStr)
        End Select
    End Sub

    '[検索]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        Joken.ADDRESS1 = CmnModule.GetSelectedItemValue(Me.ADDRESS1)
        Joken.ADDRESS2 = Trim(Me.ADDRESS2.Text)
        Joken.SHISETSU_NAME = Trim(Me.SHISETSU_NAME.Text)
        Joken.SHISETSU_NAME_KANA = Trim(Me.SHISETSU_NAME_KANA.Text)
        Session.Item(SessionDef.Joken) = Joken

        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1) = Joken.ADDRESS1
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2) = Joken.ADDRESS2
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME) = Joken.SHISETSU_NAME
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME_KANA) = Joken.SHISETSU_NAME_KANA

        '画面項目表示
        SetForm()
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        'If Not CmnCheck.IsInput(ADDRESS1) AndAlso _
        '   Not CmnCheck.IsInput(ADDRESS2) AndAlso _
        '   Not CmnCheck.IsInput(SHISETSU_NAME) AndAlso _
        '   Not CmnCheck.IsInput(SHISETSU_NAME_KANA) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput_Joken, Me)
        '    Return False
        'End If

        Return True
    End Function

End Class
