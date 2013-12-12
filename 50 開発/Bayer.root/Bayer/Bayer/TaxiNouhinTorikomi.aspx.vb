Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiNouhinTorikomi
    Inherits WebBase

    Private Const COL_COUNT As Integer = 3 'ファイルの項目数
    Private Const pDelimiter As String = ","

    Private Enum COL_NO
        Field1 = 0
        Field2
        Field3
    End Enum

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "タクチケ納品データ取込"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        'クリア
        CmnModule.ClearAllControl(Me)

        'タクシー会社ラジオボタン設定
        AppModule.SetRadioButtonList_RDO_TAXI(Me.RdoTaxi)
        Me.RdoTaxi.SelectedValue = "DC"
    End Sub

    '[取込開始]
    Private Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTorikomi.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.NOUHIN_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("納品データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルをタクチケTBLへImport
        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.NOUHIN_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.NOUHIN_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK))

        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.NOUHIN_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.NOUHIN_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_LOG, False, "取込対象CSVファイルが存在しません。", MyBase.DbConnection)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント
        For Each filePath As String In workFiles
            ImportData(filePath, insCnt)
        Next

        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_LOG, True, insCnt.ToString & "件のデータを登録しました。", MyBase.DbConnection)

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        For Each filePath As String In workFiles
            Try
                File.Copy(filePath, Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK) & Path.GetFileName(filePath))
            Catch ex As Exception
                File.Copy(filePath, Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK) & Path.GetFileNameWithoutExtension(filePath) _
                                                                        & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
            End Try
            File.Delete(filePath)
        Next
    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("UTF-8"))
        Else
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_LOG, False, strFilePath & "が見つかりません。", MyBase.DbConnection)
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        'ダブルクォート囲み、ダブルクォートのエスケープ対応
        parser.HasFieldsEnclosedInQuotes = True

        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1
            insCnt += InsertTable(fileData)

        End While

        'インスタンス開放
        parser.Dispose()

    End Function

    '入力チェック
    Private Function Check() As Boolean
        If Me.FileUpload1.FileName.Trim = String.Empty Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("取込む納品データ"), Me)
            Return False
        End If
        Return True
    End Function

    'データ登録
    Private Function InsertTable(ByVal fileData As String()) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct

        TBL_TAXITICKET_HAKKO = SetInsData(fileData)
        Try
            strSQL = SQL.TBL_TAXITICKET_HAKKO.Insert(TBL_TAXITICKET_HAKKO)
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_TAXITICKET_HAKKO, True, "", MyBase.DbConnection)

            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_TAXITICKET_HAKKO, False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_TAXITICKET_HAKKO.DataStruct

        Dim TBL_TAXITICKET_HAKKO_Ins As New TableDef.TBL_TAXITICKET_HAKKO.DataStruct

        TBL_TAXITICKET_HAKKO_Ins.TKT_KAISHA = fileData(COL_NO.Field1)
        TBL_TAXITICKET_HAKKO_Ins.TKT_NO = fileData(COL_NO.Field2)
        TBL_TAXITICKET_HAKKO_Ins.TKT_KENSHU = fileData(COL_NO.Field3)
        TBL_TAXITICKET_HAKKO_Ins.INPUT_USER = AppModule.GetValue_USER_NAME(Session.Item(SessionDef.MS_USER))
        TBL_TAXITICKET_HAKKO_Ins.UPDATE_USER = AppModule.GetValue_USER_NAME(Session.Item(SessionDef.MS_USER))

        Return TBL_TAXITICKET_HAKKO_Ins

    End Function
End Class
