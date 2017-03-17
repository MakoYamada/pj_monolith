Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiSeisanImport
    Inherits WebBase

    Private Const COL_COUNT As Integer = 13 'ファイルの項目数
    Private Const pDelimiter As String = ","
    Private SEISAN_TESURYO As String = "0"
    Private HAKKO_TESURYO As String = "0"
    Private TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct = Nothing
    Private TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing

    Private Enum COL_NO
        TKT_KAISHA = 0
        TKT_NO
        TKT_KENSHU
        KOUENKAI_NO
        SANKASHA_ID
        TKT_LINE_NO
        TKT_USED_DATE
        TKT_HATUTI
        TKT_CHAKUTI
        TKT_URIAGE
        TKT_SEISAN_FEE
        TKT_HAKKO_FEE
        TKT_ENTA
    End Enum

    Private Class COL_NAME
        Public Const TKT_KAISHA As String = "タクシー会社"
        Public Const TKT_NO As String = "タクシーチケット番号"
        Public Const TKT_KENSHU As String = "券種"
        Public Const KOUENKAI_NO As String = "会合番号"
        Public Const SANKASHA_ID As String = "参加者ID"
        Public Const TKT_LINE_NO As String = "交通手配タクチケ行番号"
        Public Const TKT_USED_DATE As String = "利用日"
        Public Const TKT_HATUTI As String = "実車発地"
        Public Const TKT_CHAKUTI As String = "実車着地"
        Public Const TKT_URIAGE As String = "売上金額"
        Public Const TKT_SEISAN_FEE As String = "精算手数料"
        Public Const TKT_HAKKO_FEE As String = "発行手数料"
        Public Const TKT_ENTA As String = "エンタ"
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
            .PageTitle = "タクチケ精算用CSV取込"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[取込開始]
    Private Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTorikomi.Click
        Me.LabelErrorMessage.Text = ""
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.SEISAN_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.SEISAN_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.SEISAN_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.SEISAN_CSV_BK))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.SEISAN_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("実績データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルをタクチケTBLへImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.SEISAN_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.SEISAN_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            CmnModule.AlertMessage("取込対象CSVファイルが存在しません。", Me)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.SEISAN_CSV) & FileUpload1.FileName
        ImportData(filePath, insCnt)
        Me.LabelErrorMessage.Text &= (insCnt * -1).ToString & "件のデータを登録しました。" & vbNewLine

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.SEISAN_CSV) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.SEISAN_CSV) & Path.GetFileNameWithoutExtension(filePath) _
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
            Me.LabelErrorMessage.Text &= strFilePath & "が見つかりません。" & vbNewLine
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

            '1行目はタイトル行のため読み飛ばす
            If rowCnt > 1 Then
                If CheckInput(fileData, strFileName, rowCnt.ToString, ErrorMessage) Then
                    'タクチケ発行テーブル更新
                    insCnt += UpdateTable(fileData, strFileName, rowCnt, ErrorMessage)
                End If
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
            Me.LabelUpdatedCount.Text = (rowCnt - 1).ToString
            Return True
        End If

    End Function

    '入力チェック
    Private Function Check() As Boolean
        If Me.FileUpload1.FileName.Trim = String.Empty Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("取込むタクチケ精算用CSV"), Me)
            Return False
        End If
        Return True
    End Function

    'CSVデータ内容チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, ByRef ErrorMessage As String) As Boolean
        Dim ErrStr As String = ""

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            End If

            If fileData(COL_NO.TKT_NO).Trim.Equals(String.Empty) Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_NO & "がセットされていません。" & vbNewLine
            End If

            If fileData(COL_NO.TKT_ENTA).Trim = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.SeisanFuka Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_ENTA & "が｢N｣のため、取込できません。" & vbNewLine
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            Return False
        End Try

        If Trim(ErrStr) <> "" Then
            ErrorMessage &= ErrStr
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Return True
        End If

    End Function

    'データ登録
    Private Function UpdateTable(ByVal fileData As String(), ByVal strFileName As String, ByVal rowCnt As Long, ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_TAITICKET_HAKKO_UPD As TableDef.TBL_TAXITICKET_HAKKO.DataStruct = Nothing

        TBL_TAITICKET_HAKKO_UPD = SetUpdateData(fileData, strFileName, rowCnt, ErrorMessage)
        Try
            strSQL = Sql.TBL_TAXITICKET_HAKKO.Update(TBL_TAITICKET_HAKKO_UPD)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[データ取込失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetUpdateData(ByVal fileData As String(), ByVal strFileName As String, ByVal rowCnt As Long, ByRef ErrorMessage As String) As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Try
            'タクチケ発行テーブル更新対象レコード取得
            If GetTaxiticketHakko(fileData(COL_NO.TKT_NO)) Then
                '未決登録済みのタクチケは取込エラーとする。
                If TBL_TAXITICKET_HAKKO.TKT_MIKETSU = CmnConst.Flag.On Then
                    Throw New Exception("未決登録済のため、精算データ取込できません。[タクチケ番号:" & fileData(COL_NO.TKT_NO) & "]")
                Else

                    '実績CSVの内容をタクチケ発行テーブルの項目へセット
                    Call SetItem(fileData)

                    '交通宿泊テーブルに未登録の場合はエラー
                    If Not GetKotsuhotel(TBL_TAXITICKET_HAKKO.KOUENKAI_NO, TBL_TAXITICKET_HAKKO.SANKASHA_ID) Then
                        Throw New Exception("交通宿泊テーブルに登録されていません。[会合番号:" & TBL_TAXITICKET_HAKKO.KOUENKAI_NO & ",参加者番号:" & TBL_TAXITICKET_HAKKO.SANKASHA_ID & "]")
                    End If
                End If
            Else
                Throw New Exception("タクチケ発行テーブルに登録されていません。[タクチケ番号:" & fileData(COL_NO.TKT_NO) & "]")
            End If
        Catch ex As Exception
            Dim strErrMsg As String = strFileName & "【" & rowCnt & "行目】" & ex.Message
            ErrorMessage &= strErrMsg & vbNewLine
        End Try

        Return TBL_TAXITICKET_HAKKO

    End Function

    'タクチケ発行情報取得
    Private Function GetTaxiticketHakko(ByVal TKT_NO As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = Sql.TBL_TAXITICKET_HAKKO.byTKT_NO(TKT_NO)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_TAXITICKET_HAKKO = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO)
        End If
        RsData.Close()

        Return wFlag
    End Function

    '交通宿泊最新情報取得
    Private Function GetKotsuhotel(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = Sql.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID_NEW(KOUENKAI_NO, SANKASHA_ID)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)
        End If
        RsData.Close()

        Return wFlag
    End Function

    '精算用CSV→タクチケ発行テーブル項目セット
    Private Sub SetItem(ByVal filedata() As String)
        Dim wDate As Date = filedata(COL_NO.TKT_USED_DATE)
        TBL_TAXITICKET_HAKKO.TKT_USED_DATE = CmnModule.Format_DateToString(wDate, CmnModule.DateFormatType.YYYYMMDD)
        TBL_TAXITICKET_HAKKO.TKT_HATUTI = filedata(COL_NO.TKT_HATUTI)
        TBL_TAXITICKET_HAKKO.TKT_CHAKUTI = filedata(COL_NO.TKT_CHAKUTI)
        TBL_TAXITICKET_HAKKO.TKT_URIAGE = filedata(COL_NO.TKT_URIAGE)
        TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE = filedata(COL_NO.TKT_SEISAN_FEE)
        TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE = filedata(COL_NO.TKT_HAKKO_FEE)
        TBL_TAXITICKET_HAKKO.TKT_ENTA = String.Empty
        TBL_TAXITICKET_HAKKO.TKT_MIKETSU = "0"
        TBL_TAXITICKET_HAKKO.UPDATE_USER = Session.Item(SessionDef.LoginID)
    End Sub
End Class
