﻿Imports CommonLib
Imports AppLib

Partial Public Class SeisanList
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private DATA_MAINTENANCE As String

    'グリッド列    Private Enum CellIndex
        BU
        AREA
        EIGYOSHO
        TANTO_NAME
        FROM_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        SEIHIN_NAME
        SEIKYU_NO_TOPTOUR
        SHIHARAI_NO
        SEISAN_KINGAKU
        SEISAN_KANRYO
        SEISAN_YM
        UPDATE_DATE
        SHOUNIN_KUBUN
        SHOUNIN_DATE
        SEND_FLAG
        Button1
        TO_DATE
        KEI_TF
        KEI_T
        MR_JR
        MR_HOTEL
        MR_HOTEL_TOZEI
        TAXI_T
        TAXI_SEISAN_T
    End Enum

    Private Sub SeisanList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_SEIKYU) = TBL_SEIKYU
        Session.Item(SessionDef.Joken) = Joken
        Session.Item(SessionDef.DATA_MAINTENANCE) = DATA_MAINTENANCE
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

            If DATA_MAINTENANCE = CmnConst.Flag.Off Then
                SetJoken()
                SetForm()
            Else
                Me.BtnInsert.Visible = False
                Me.BtnSeisanListCsv1.Visible = False
                Me.BtnSeisanListCsv2.Visible = False
                Me.BtnSeisanListPrint1.Visible = False
                Me.BtnSeisanListPrint2.Visible = False
                Me.BtnMishuHoukoku1.Visible = False
                Me.BtnMishuHoukoku2.Visible = False
                Me.BtnBack2.Visible = False
            End If
        End If

        Session.Item(SessionDef.PrintPreview) = Nothing

        'マスターページ設定
        With Me.Master
            .PageTitle = "【検索】精算データ"
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
            TBL_SEIKYU = Session.Item(SessionDef.TBL_SEIKYU)
            If TBL_SEIKYU Is Nothing Then ReDim TBL_SEIKYU(0)
        Catch ex As Exception
            ReDim TBL_SEIKYU(0)
        End Try
        Try
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            If TBL_KOUENKAI Is Nothing Then ReDim TBL_KOUENKAI(0)
        Catch ex As Exception
            ReDim TBL_KOUENKAI(0)
        End Try

        Try
            If Not Session.Item(SessionDef.DATA_MAINTENANCE) Is Nothing Then
                DATA_MAINTENANCE = Session.Item(SessionDef.DATA_MAINTENANCE)
            Else
                DATA_MAINTENANCE = ""
            End If
        Catch ex As Exception
            DATA_MAINTENANCE = ""
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'ドロップダウンリスト設定
        AppModule.SetDropDownList_SHOUNIN_KUBUN(Me.JokenSHOUNIN_KUBUN)
        AppModule.SetDropDownList_BU(Me.JokenBU, DbConnection)
        AppModule.SetDropDownList_AREA(Me.JokenKIKAKU_TANTO_AREA, DbConnection)
        AppModule.SetDropDownList_SEND_FLAG(Me.JokenSEND_FLAG)

        'IME設定        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEISAN_Y, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEISAN_M, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenKIKAKU_TANTO_ROMA, CmnModule.ImeType.Disabled)

        If URL.SeisanKensaku.IndexOf(Session.Item(SessionDef.BackURL)) > 0 Then
            Joken.KOUENKAI_NO = TBL_KOUENKAI(Session.Item(SessionDef.SeisanKensaku_SEQ)).KOUENKAI_NO
        End If

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '抽出条件表示
    Private Sub SetJoken()
        If Joken.KOUENKAI_NO <> "" Then Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        If Joken.SEIKYU_NO_TOPTOUR <> "" Then Me.JokenSEIKYU_NO_TOPTOUR.Text = Joken.SEIKYU_NO_TOPTOUR
        If Joken.SEISAN_YM <> "" Then
            Me.JokenSEISAN_Y.Text = Mid(Joken.SEISAN_YM, 1, 4)
            Me.JokenSEISAN_M.Text = Mid(Joken.SEISAN_YM, 5, 2)
        End If

        If Joken.SHOUNIN_KUBUN <> "" Then Me.JokenSHOUNIN_KUBUN.SelectedValue = Joken.SHOUNIN_KUBUN

        If Joken.FROM_DATE <> "" AndAlso Joken.FROM_DATE <> "指定なし" Then
            Me.JokenFROM_DATE_YYYY.Text = Joken.FROM_DATE.Substring(0, 4)
            Me.JokenFROM_DATE_MM.Text = Joken.FROM_DATE.Substring(4, 2)
            Me.JokenFROM_DATE_DD.Text = Joken.FROM_DATE.Substring(6, 2)
        End If
        If Joken.TO_DATE <> "" AndAlso Joken.TO_DATE <> "指定なし" Then
            Me.JokenTO_DATE_YYYY.Text = Joken.TO_DATE.Substring(0, 4)
            Me.JokenTO_DATE_MM.Text = Joken.TO_DATE.Substring(4, 2)
            Me.JokenTO_DATE_DD.Text = Joken.TO_DATE.Substring(6, 2)
        End If
        If Joken.KIKAKU_TANTO_ROMA <> "" AndAlso Joken.KIKAKU_TANTO_ROMA <> "指定なし" Then Me.JokenKIKAKU_TANTO_ROMA.Text = Joken.KIKAKU_TANTO_ROMA
        If Joken.BU <> "" AndAlso Joken.BU <> "指定なし" Then Me.JokenBU.SelectedValue = Joken.BU
        If Joken.AREA <> "" AndAlso Joken.AREA <> "指定なし" Then Me.JokenKIKAKU_TANTO_AREA.SelectedValue = Joken.AREA
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.TblButton1.Visible = False
            Me.BtnSeisanListCsv1.Visible = False
            Me.BtnSeisanListCsv2.Visible = False
            Me.BtnSeisanListPrint1.Visible = False
            Me.BtnSeisanListPrint2.Visible = False
            Me.BtnMishuHoukoku1.Visible = False
            Me.BtnMishuHoukoku2.Visible = False
            Me.BtnBack2.Visible = True
            CmnModule.SetEnabled(Me.BtnSeisanListCsv2, False)
            CmnModule.SetEnabled(Me.BtnSeisanListPrint2, False)
            CmnModule.SetEnabled(Me.BtnMishuHoukoku2, False)
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.TblButton1.Visible = True
            If DATA_MAINTENANCE = CmnConst.Flag.Off Then
                Me.BtnSeisanListCsv1.Visible = True
                Me.BtnSeisanListCsv2.Visible = True
                Me.BtnSeisanListPrint1.Visible = True
                Me.BtnSeisanListPrint2.Visible = True
                Me.BtnMishuHoukoku1.Visible = True
                Me.BtnMishuHoukoku2.Visible = True
            Else
                Me.BtnSeisanListCsv1.Visible = False
                Me.BtnSeisanListCsv2.Visible = False
                Me.BtnSeisanListPrint1.Visible = False
                Me.BtnSeisanListPrint2.Visible = False
                Me.BtnMishuHoukoku1.Visible = False
                Me.BtnMishuHoukoku2.Visible = False
            End If
            Me.BtnBack2.Visible = True
            CmnModule.SetEnabled(Me.BtnSeisanListCsv2, True)
            CmnModule.SetEnabled(Me.BtnSeisanListPrint2, True)
            CmnModule.SetEnabled(Me.BtnMishuHoukoku2, True)

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
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        Joken.SEIKYU_NO_TOPTOUR = Me.JokenSEIKYU_NO_TOPTOUR.Text.Trim
        If Me.JokenSHOUNIN_KUBUN.SelectedIndex <> 0 Then Joken.SHOUNIN_KUBUN = Me.JokenSHOUNIN_KUBUN.SelectedItem.Value
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.SEISAN_YM = CmnModule.Format_DateToString(Me.JokenSEISAN_Y.Text, Me.JokenSEISAN_M.Text)
        Joken.KIKAKU_TANTO_ROMA = Me.JokenKIKAKU_TANTO_ROMA.Text.Trim
        If Me.JokenBU.SelectedIndex <> 0 Then Joken.BU = Me.JokenBU.SelectedItem.Value
        If Me.JokenKIKAKU_TANTO_AREA.SelectedIndex <> 0 Then Joken.AREA = Me.JokenKIKAKU_TANTO_AREA.SelectedItem.Value
        If Me.JokenSEND_FLAG.SelectedIndex <> 0 Then Joken.SEND_FLAG = Me.JokenSEND_FLAG.SelectedValue

        ReDim TBL_SEIKYU(wCnt)
        strSQL = SQL.TBL_SEIKYU.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_SEIKYU(wCnt)
            TBL_SEIKYU(wCnt) = AppModule.SetRsData(RsData, TBL_SEIKYU(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()

        'データソース設定
        Dim strSQL As String = SQL.TBL_SEIKYU.Search(Joken)
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
    Private Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            e.Row.Cells(CellIndex.SEISAN_YM).Text = AppModule.GetName_SEISAN_YM(e.Row.Cells(CellIndex.SEISAN_YM).Text)
            e.Row.Cells(CellIndex.UPDATE_DATE).Text = AppModule.GetName_UPDATE_DATE(e.Row.Cells(CellIndex.UPDATE_DATE).Text)
            e.Row.Cells(CellIndex.SHOUNIN_KUBUN).Text = AppModule.GetName_SHOUNIN_KUBUN(e.Row.Cells(CellIndex.SHOUNIN_KUBUN).Text)
            e.Row.Cells(CellIndex.SHOUNIN_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.SHOUNIN_DATE).Text, CmnModule.DateFormatType.YYYYMMDD)
            e.Row.Cells(CellIndex.SEND_FLAG).Text = AppModule.GetName_SEND_FLAG(e.Row.Cells(CellIndex.SEND_FLAG).Text, True)

            If e.Row.Cells(CellIndex.SEISAN_KANRYO).Text = AppConst.SEISAN.SEISAN_KANRYO.Code.Mi Then
                e.Row.Cells(CellIndex.SEISAN_KANRYO).Text = AppModule.GetName_SEISAN_KANRYO(e.Row.Cells(CellIndex.SEISAN_KANRYO).Text)
            ElseIf e.Row.Cells(CellIndex.SEISAN_KANRYO).Text = AppConst.SEISAN.SEISAN_KANRYO.Code.Kanryo Then
                e.Row.Cells(CellIndex.SEISAN_KANRYO).Text = AppModule.GetName_SEISAN_KANRYO(e.Row.Cells(CellIndex.SEISAN_KANRYO).Text)
            End If

            e.Row.Cells(CellIndex.SEISAN_KINGAKU).Text = "\" & CmnModule.EditComma(AppModule.GetName_SEISAN_KINGKU(e.Row.Cells(CellIndex.KEI_TF).Text, _
                                                                                          e.Row.Cells(CellIndex.KEI_T).Text, _
                                                                                          e.Row.Cells(CellIndex.MR_JR).Text, _
                                                                                          e.Row.Cells(CellIndex.MR_HOTEL).Text, _
                                                                                          e.Row.Cells(CellIndex.MR_HOTEL_TOZEI).Text, _
                                                                                          e.Row.Cells(CellIndex.TAXI_T).Text, _
                                                                                          e.Row.Cells(CellIndex.TAXI_SEISAN_T).Text))
        End If
    End Sub

    'グリッドビュー列の表示設定
    Private Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.KEI_TF).Visible = False
            e.Row.Cells(CellIndex.KEI_T).Visible = False
            e.Row.Cells(CellIndex.MR_JR).Visible = False
            e.Row.Cells(CellIndex.MR_HOTEL).Visible = False
            e.Row.Cells(CellIndex.MR_HOTEL_TOZEI).Visible = False
            e.Row.Cells(CellIndex.TAXI_T).Visible = False
            e.Row.Cells(CellIndex.TAXI_SEISAN_T).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 1
            Me.GrvList.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
        End If
    End Sub

    'グリッドビュー ページ移動時
    Private Sub GrvList_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrvList.PageIndexChanged
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
    Private Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Select Case e.CommandName
            Case "Detail"
                '選択レコード情報をセッション変数にセット
                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.TBL_SEIKYU) = TBL_SEIKYU
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath

                If DATA_MAINTENANCE = CmnConst.Flag.On Then
                    Response.Redirect(URL.SeisanMaintenance)
                Else
                    Response.Redirect(URL.SeisanRegist)
                End If
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        Session.Item(SessionDef.PageIndex) = 0
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

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("会合番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenSEISAN_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_YM & "(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenSEISAN_M) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_YM & "(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenFROM_DATE_YYYY.Text) & "/" & Trim(Me.JokenFROM_DATE_MM.Text) & "/" & Trim(Me.JokenFROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("開催日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenTO_DATE_YYYY.Text) & "/" & Trim(Me.JokenTO_DATE_MM.Text) & "/" & Trim(Me.JokenTO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("開催日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Session.Remove(SessionDef.SeisanListPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Joken = Nothing

        Response.Redirect(URL.SeisanKensaku)
    End Sub

    '[新規登録]
    Private Sub BtnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        TBL_SEIKYU = Nothing
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Response.Redirect(URL.SeisanRegist)
    End Sub

    '[精算データ一覧印刷]
    Protected Sub BtnSeisanListPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSeisanListPrint1.Click, BtnSeisanListPrint2.Click
        Dim strSQL As String = SQL.TBL_SEIKYU.Search(Joken)
        Session.Item(SessionDef.SeisanListPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[精算データ一覧CSV出力]
    Protected Sub BtnSeisanListCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSeisanListCsv1.Click, BtnSeisanListCsv2.Click

        Dim CsvData() As TableDef.TBL_SEIKYU.DataStruct
        If GetData() Then
            CsvData = TBL_SEIKYU
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "SeisanList_" & Now.ToString("yyyyMMddHHmmss") & ".csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.SeisanListCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If

    End Sub

    '[未収入金滞留理由報告書印刷]
    Protected Sub BtnMishuHoukoku_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMishuHoukoku1.Click, BtnMishuHoukoku2.Click
        Dim MISHU_JOKEN() As TableDef.MISHU_JOKEN.DataStruct
        Dim seq As Integer = 0
        Dim PrintSeq As Integer = 0

        '承認済みデータのみ印刷対象とする
        For Each row As GridViewRow In Me.GrvList.Rows
            If TBL_SEIKYU(seq).SHOUNIN_KUBUN = AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN Then
                ReDim Preserve MISHU_JOKEN(PrintSeq)
                MISHU_JOKEN(PrintSeq).KOUENKAI_NO = TBL_SEIKYU(seq).KOUENKAI_NO
                MISHU_JOKEN(PrintSeq).SEIKYU_NO_TOPTOUR = TBL_SEIKYU(seq).SEIKYU_NO_TOPTOUR
                PrintSeq += 1
            End If
            seq += 1
        Next

        Dim strSQL As String = SQL.TBL_SEIKYU.MishuHoukoku(MISHU_JOKEN)
        Session.Item(SessionDef.MishuHoukoku_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.PrintPreview) = "MishuHoukoku"
        Response.Redirect(URL.Preview)
    End Sub
End Class