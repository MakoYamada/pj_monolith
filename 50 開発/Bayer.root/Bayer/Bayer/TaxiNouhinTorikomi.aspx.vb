Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiNouhinTorikomi
    Inherits WebBase

    Private Const COL_COUNT As Integer = 2 'ファイルの項目数
    Private Const pDelimiter As String = ","

    Private Enum COL_NO
        Field1 = 0
        Field2
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "タクチケ番号"
        Public Const Field2 As String = "券種"
    End Class

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

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.NOUHIN_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.NOUHIN_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.NOUHIN_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("納品データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルをタクチケTBLへImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.NOUHIN_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.NOUHIN_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_LOG, False, "取込対象CSVファイルが存在しません。", MyBase.DbConnection)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.NOUHIN_CSV) & FileUpload1.FileName
        ImportData(filePath, insCnt)

        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_LOG, True, (insCnt * -1).ToString & "件のデータを登録しました。", MyBase.DbConnection)

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.NOUHIN_CSV_BK) & Path.GetFileNameWithoutExtension(filePath) _
                                                                    & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
        End Try
        File.Delete(filePath)
    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("SHIFT-JIS"))
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

            If CheckInput(fileData, strFileName, rowCnt.ToString) Then
                insCnt += InsertTable(fileData)
            End If

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

    'CSVデータ内容チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String) As Boolean

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                Throw New Exception("項目数が不正です。")
            End If

            '必須入力チェック
            If fileData(COL_NO.Field1).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field1 & "がセットされていません。")
            End If

            If fileData(COL_NO.Field2).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field2 & "がセットされていません。")
            End If

            'タクシー会社チェック
            If fileData(COL_NO.Field2).Trim.Substring(0, 2) <> "10" AndAlso _
                fileData(COL_NO.Field2).Trim.Substring(0, 2) <> "20" AndAlso _
                fileData(COL_NO.Field2).Trim.Substring(0, 2) <> "30" AndAlso _
                fileData(COL_NO.Field2).Trim.Substring(0, 2) <> "50" Then
                If fileData(COL_NO.Field2).Trim.Substring(0, 2) <> Me.RdoTaxi.SelectedValue Then
                    Throw New Exception(COL_NAME.Field2 & "がタクシー会社と一致しません。")
                End If
            Else
                If fileData(COL_NO.Field2).Trim.Substring(0, 2) <> "DC" Then
                    Throw New Exception(COL_NAME.Field2 & "がタクシー会社と一致しません。")
                End If
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_LOG, False, strErrMsg, MyBase.DbConnection)
            Return False
        End Try

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
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi, TBL_TAXITICKET_HAKKO, False, "[データ取込失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL, MyBase.DbConnection)
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_TAXITICKET_HAKKO.DataStruct

        Dim TBL_TAXITICKET_HAKKO_Ins As New TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim MS_USER As TableDef.MS_USER.DataStruct

        MS_USER = Session.Item(SessionDef.MS_USER)

        TBL_TAXITICKET_HAKKO_Ins.TKT_KAISHA = Me.RdoTaxi.SelectedValue
        TBL_TAXITICKET_HAKKO_Ins.TKT_NO = fileData(COL_NO.Field1)
        If Me.RdoTaxi.SelectedValue = "DC" Then
            TBL_TAXITICKET_HAKKO_Ins.TKT_KENSHU = Me.RdoTaxi.SelectedValue & fileData(COL_NO.Field2)
        Else
            TBL_TAXITICKET_HAKKO_Ins.TKT_KENSHU = fileData(COL_NO.Field2)
        End If
        TBL_TAXITICKET_HAKKO_Ins.TKT_MIKETSU = CmnConst.Flag.Off
        TBL_TAXITICKET_HAKKO_Ins.INPUT_USER = MS_USER.LOGIN_ID
        TBL_TAXITICKET_HAKKO_Ins.UPDATE_USER = MS_USER.LOGIN_ID

        Return TBL_TAXITICKET_HAKKO_Ins

    End Function
End Class
