Imports CommonLib
Imports AppLib

Partial Public Class NewDrList
    Inherits WebBase

    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        CHK_PRINT
        JISSHI_DATE
        KOUENKAI_NAME
        DR_NAME
        TIME_STAMP
        USER_NAME
        KUBUN
        REQ_HOTEL
        REQ_KOTSU
        REQ_TAXI
        Button1
        KOUENKAI_NO
        SALESFORCE_ID
        TO_DATE
        REQ_O_TEHAI_1
        REQ_O_TEHAI_2
        REQ_O_TEHAI_3
        REQ_O_TEHAI_4
        REQ_O_TEHAI_5
        REQ_F_TEHAI_1
        REQ_F_TEHAI_2
        REQ_F_TEHAI_3
        REQ_F_TEHAI_4
        REQ_F_TEHAI_5
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.Joken) = Joken
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '共通チェック
        Session.Item(SessionDef.LoginID) = "QQQ"
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
            .PageTitle = "新着　宿泊・交通・タクシーチケット手配依頼"
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
            TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
            If TBL_KOTSUHOTEL Is Nothing Then ReDim TBL_KOTSUHOTEL(0)
        Catch ex As Exception
            ReDim TBL_KOTSUHOTEL(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'IME設定        CmnModule.SetIme(Me.JokenBU, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTEHAI_TANTO_AREA, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenKOUENKAI_NAME, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)
        AppModule.SetDropDownList_KUBUN(Me.JokenKUBUN, True)
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        If Joken.BU <> "" Then Me.JokenBU.Text = Joken.BU
        If Joken.KIKAKU_TANTO_ROMA <> "" Then Me.JokenTEHAI_TANTO_AREA.Text = Joken.KIKAKU_TANTO_ROMA
        If Joken.KOUENKAI_NO <> "" Then Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        If Joken.KOUENKAI_NAME <> "" Then Me.JokenKOUENKAI_NAME.Text = Joken.KOUENKAI_NAME
        If Joken.KIKAKU_TANTO_ROMA <> "" Then Me.JokenTEHAI_TANTO_ROMA.Text = Joken.KOUENKAI_NAME
        If Joken.KUBUN <> "" Then Me.JokenKUBUN.SelectedValue = Joken.KUBUN

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

        Joken = Nothing
        Joken.BU = Trim(Me.JokenBU.Text)
        Joken.AREA = Trim(Me.JokenTEHAI_TANTO_AREA.Text)
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.JokenKUBUN)

        ReDim TBL_KOTSUHOTEL(wCnt)

        strSQL = SQL.TBL_KOTSUHOTEL.Search(Joken, True)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOTSUHOTEL(wCnt)
            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    '一覧 表示
    Private Sub DispList()

        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.BtnPrint.Visible = False
            Me.lnkCheck.Visible = False
            Me.lnkNoCheck.Visible = False

            CmnModule.SetEnabled(Me.BtnPrint, False)

        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnPrint.Visible = True
            Me.lnkCheck.Visible = True
            Me.lnkNoCheck.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Search(Joken, True)
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

            '実施日
            e.Row.Cells(CellIndex.JISSHI_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.JISSHI_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            'TimeStamp
            e.Row.Cells(CellIndex.TIME_STAMP).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.TIME_STAMP).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            '宿泊
            e.Row.Cells(CellIndex.REQ_HOTEL).Text = AppModule.GetMark_TEHAI_HOTEL(e.Row.Cells(CellIndex.REQ_HOTEL).Text)
            '交通
            If e.Row.Cells(CellIndex.REQ_O_TEHAI_1).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_2).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_3).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_4).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_5).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_1).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_2).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_3).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_4).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_5).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Then

                e.Row.Cells(CellIndex.REQ_KOTSU).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
            Else
                e.Row.Cells(CellIndex.REQ_KOTSU).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
            End If
            'タクチケ
            e.Row.Cells(CellIndex.REQ_TAXI).Text = AppModule.GetMark_TEHAI_TAXI(e.Row.Cells(CellIndex.REQ_TAXI).Text)

            '区分
            e.Row.Cells(CellIndex.KUBUN).Text = AppModule.GetName_REQ_STATUS_TEHAI(e.Row.Cells(CellIndex.KUBUN).Text, False, True)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.SALESFORCE_ID).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_1).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_2).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_3).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_4).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_5).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_1).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_2).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_3).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_4).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_5).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 0
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
            Case "Detail"
                '選択レコード情報をセッション変数にセット
                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

                '履歴画面用セッション変数をクリア
                Session.Remove(SessionDef.KaijoRireki)
                Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
                Session.Remove(SessionDef.KouenkaiRireki_SEQ)
                Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = False

                Response.Redirect(URL.DrRegist)
        End Select
    End Sub

    '[全てにチェック]
    Private Sub lnkCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkCheck.Click
        For Each row As GridViewRow In Me.GrvList.Rows
            DirectCast(row.FindControl("chkPrint"), CheckBox).Checked = True
        Next
    End Sub

    '[全てのチェックを解除]
    Private Sub lnkNoCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkNoCheck.Click
        For Each row As GridViewRow In Me.GrvList.Rows
            DirectCast(row.FindControl("chkPrint"), CheckBox).Checked = False
        Next
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '一覧 表示
        DispList()

    End Sub

    '[NOZOMIへ・印刷]
    Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Dim UPD_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim seq As Integer = 0

        '送信フラグ→送信対象
        For Each row As GridViewRow In Me.GrvList.Rows
            If DirectCast(row.FindControl("chkPrint"), CheckBox).Checked Then
                '回答ステータス・送信フラグON
                If Not ExecuteTransaction(seq) Then
                    Exit Sub
                End If

                '手配書印刷
                'TODO:条件かデータを渡す
                Response.Redirect(URL.Preview)
            End If
            seq += 1
        Next
    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Response.Redirect(URL.Menu)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsAlphabetOnly(Me.JokenBU) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphabetOnly("手配担当者BU"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("講演会番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphabetOnly(Me.JokenTEHAI_TANTO_ROMA) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphabetOnly("手配担当者(ローマ字)"), Me)
            Return False
        End If

        Return True
    End Function

    'データ更新
    Private Function ExecuteTransaction(ByVal seq As Integer) As Boolean
        TBL_KOTSUHOTEL(seq).ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke
        TBL_KOTSUHOTEL(seq).SEND_FLAG = AppConst.SEND_FLAG.Code.Taisho
        Return UpdateData(seq)
    End Function

    'データ更新
    Private Function UpdateData(ByVal seq As Integer) As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            'データ更新
            strSQL = SQL.TBL_KOTSUHOTEL.Update(TBL_KOTSUHOTEL(seq))
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