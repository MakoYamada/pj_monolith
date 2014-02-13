Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiNouhinTorikomi
    Inherits WebBase

    Private Const COL_COUNT As Integer = 2 'ファイルの項目数
    Private Const DC_COL_COUNT As Integer = 3 'ファイルの項目数(DC)
    Private Const pDelimiter As String = ","

    Private Enum COL_NO
        COL_TKT_NO = 0
        COL_KENSHU
    End Enum
    Private Class COL_NAME
        Public Const COL_TKT_NO As String = "タクチケ番号"
        Public Const COL_KENSHU As String = "券種"
    End Class

    Private Enum DC_COL_NO
        COL_KAISHA_CODE = 0
        COL_TKT_NO
        COL_KENSHU
    End Enum
    Private Class DC_COL_NAME
        Public Const COL_KAISHA_CODE As String = "会社コード"
        Public Const COL_TKT_NO As String = "タクチケ番号"
        Public Const COL_KENSHU As String = "券種"
    End Class

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

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "タクチケ納品データ取込"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)

        'タクシー会社ラジオボタン設定
        AppModule.SetRadioButtonList_RDO_TAXI(Me.RdoTaxi)
        Me.RdoTaxi.SelectedValue = "DC"
    End Sub

    '[取込開始]
    Private Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTorikomi.Click
        Me.LabelErrorMessage.Text = ""
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

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
            CmnModule.AlertMessage("取込対象CSVファイルが存在しません。", Me)
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
        Dim ErrorMessage As String = String.Empty

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1
            If CheckInput(fileData, strFileName, rowCnt.ToString, ErrorMessage) Then
                insCnt += InsertTable(fileData)
            End If

        End While

        'インスタンス開放
        parser.Dispose()

        If Trim(ErrorMessage) <> "" Then
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Me.TrError.Visible = False
            Me.TrEnd.Visible = True
            Me.LabelUpdatedCount.Text = rowCnt.ToString
            Return True
        End If

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
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, ByRef ErrorMessage As String) As Boolean

        Try
            If Me.RdoTaxi.SelectedValue = "DC" Then
                '項目数チェック
                If fileData.Count <> DC_COL_COUNT Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
                End If
                '必須入力チェック
                If fileData(DC_COL_NO.COL_KAISHA_CODE).Trim.Equals(String.Empty) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & DC_COL_NAME.COL_KAISHA_CODE & "がセットされていません。" & vbNewLine
                End If
                If fileData(DC_COL_NO.COL_TKT_NO).Trim.Equals(String.Empty) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & DC_COL_NAME.COL_TKT_NO & "がセットされていません。" & vbNewLine
                End If
                If fileData(DC_COL_NO.COL_KENSHU).Trim.Equals(String.Empty) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & DC_COL_NAME.COL_KENSHU & "がセットされていません。" & vbNewLine
                End If
                '券種チェック
                If Not ChkKenshu(Me.RdoTaxi.SelectedValue, fileData(DC_COL_NO.COL_KENSHU)) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & DC_COL_NO.COL_KENSHU & "が不正です。" & vbNewLine
                End If
            Else
                '項目数チェック
                If fileData.Count <> COL_COUNT Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
                End If
                '必須入力チェック
                If fileData(COL_NO.COL_TKT_NO).Trim.Equals(String.Empty) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.COL_TKT_NO & "がセットされていません。" & vbNewLine
                End If

                If fileData(COL_NO.COL_KENSHU).Trim.Equals(String.Empty) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.COL_KENSHU & "がセットされていません。" & vbNewLine
                End If
                '券種チェック
                If Not ChkKenshu(Me.RdoTaxi.SelectedValue, fileData(COL_NO.COL_KENSHU)) Then
                    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.COL_KENSHU & "が不正です。" & vbNewLine
                End If
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
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

        If Me.RdoTaxi.SelectedValue = "DC" Then
            TBL_TAXITICKET_HAKKO_Ins.TKT_NO = fileData(DC_COL_NO.COL_TKT_NO)
            TBL_TAXITICKET_HAKKO_Ins.TKT_KENSHU = Me.RdoTaxi.SelectedValue & fileData(DC_COL_NO.COL_KENSHU)
        Else
            TBL_TAXITICKET_HAKKO_Ins.TKT_NO = fileData(COL_NO.COL_TKT_NO)
            TBL_TAXITICKET_HAKKO_Ins.TKT_KENSHU = Me.RdoTaxi.SelectedValue & fileData(COL_NO.COL_KENSHU)
        End If

        TBL_TAXITICKET_HAKKO_Ins.TKT_MIKETSU = CmnConst.Flag.Off
        TBL_TAXITICKET_HAKKO_Ins.TKT_VOID = CmnConst.Flag.Off
        TBL_TAXITICKET_HAKKO_Ins.INPUT_USER = MS_USER.LOGIN_ID
        TBL_TAXITICKET_HAKKO_Ins.UPDATE_USER = MS_USER.LOGIN_ID

        Return TBL_TAXITICKET_HAKKO_Ins

    End Function

    '券種チェック
    Private Function ChkKenshu(ByVal Kaisha As String, ByVal Kenshu As String) As Boolean
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        Dim wKenshu As String = Kaisha.Trim & Kenshu.Trim

        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TAXI_KENSHU Then
                If wKenshu = MS_CODE(wCnt).DISP_VALUE Then
                    Return True
                End If
            End If
        Next

        Return False
    End Function
End Class
