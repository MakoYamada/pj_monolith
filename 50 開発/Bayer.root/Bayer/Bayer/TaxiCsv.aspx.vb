﻿Imports CommonLib
Imports AppLib
Partial Public Class TaxiCsv
    Inherits WebBase

    Private Joken As TableDef.Joken.DataStruct

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
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
        End If

        'マステーページ設定
        With Me.Master
            .PageTitle = "タクシー管理システム用CSVファイル作成"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定
        CmnModule.SetIme(Me.JokenBU, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenKIKAKU_TANTO_AREA, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenKOUENKAI_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTTANTO_ID, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[CSVファイル作成]ボタン
    Protected Sub BtnCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCsv.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '条件
        Joken = Nothing
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.BU = Trim(Me.JokenBU.Text)
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.AREA = Trim(Me.JokenKIKAKU_TANTO_AREA.Text)
        Joken.TTANTO_ID = Trim(Me.JokenTTANTO_ID.Text)

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "Taxi.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("utf-8")

            Response.Write(MyModule.Csv.TaxiCsv(CsvData))
            Response.End()
        End If
    End Sub

    'CSV用データ取得
    Private Function GetData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
         Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        strSQL = SQL.TBL_KOTSUHOTEL.TaxiCsv(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

        Return True
    End Function

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenFROM_DATE_YYYY.Text) & "/" & Trim(Me.JokenFROM_DATE_MM.Text) & "/" & Trim(Me.JokenFROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenTO_DATE_YYYY.Text) & "/" & Trim(Me.JokenTO_DATE_MM.Text) & "/" & Trim(Me.JokenTO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

End Class
