Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class SetTicketSend
    Inherits WebBase

    Private Const COL_COUNT As Integer = 4 'ファイルの項目数
    Private Const pDelimiter As String = ","
    Private SEISAN_TESURYO As String = "0"
    Private HAKKO_TESURYO As String = "0"
    Private TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing

    Private Enum COL_NO
        KOUENKAI_NO = 0
        KOUENKAI_NAME
        SANKASHA_ID
        DR_NAME
    End Enum

    Private Class COL_NAME
        Public Const KOUENKAI_NO As String = "会合番号"
        Public Const KOUENKAI_NAME As String = "会合名"
        Public Const SANKASHA_ID As String = "参加者番号"
        Public Const DR_NAME As String = "DR氏名"
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
            .PageTitle = "発送日一括設定"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)
        Me.ANS_TICKET_SEND_DAY.Text = Now.ToString("yyyyMMdd")
    End Sub

    '[取込開始]
    Private Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTorikomi.Click
        Dim wErrMessage As String = ""

        Me.LabelErrorMessage.Text = ""
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV_BK))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("発送済対象取込用CSVファイルをアップロードできませんでした。", Me)
            wErrMessage &= CmnCsv.Quotes("発送済対象取込用CSVファイルをアップロードできませんでした。") & vbNewLine
            Exit Sub
        End Try

        'CSVファイルを交通宿泊へImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.TICKET_SEND_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            CmnModule.AlertMessage("発送済対象取込用CSVファイルが存在しません。", Me)
            wErrMessage &= CmnCsv.Quotes("発送済対象取込用CSVファイルが存在しません。") & vbNewLine
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.TICKET_SEND_CSV) & FileUpload1.FileName

        ImportData(filePath, insCnt, wErrMessage)

        Me.LabelErrorMessage.Text &= (insCnt * -1).ToString & "件の交通・宿泊データに発送日を登録しました。" & vbNewLine

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.TICKET_SEND_CSV) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.TICKET_SEND_CSV) & Path.GetFileNameWithoutExtension(filePath) _
                                                                    & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
        End Try
        File.Delete(filePath)

        If wErrMessage <> "" Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "SetTicketSendErr_" & Now.ToString("yyyyMMddHHmmss") & ".csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(wErrMessage)
            Response.End()
        End If
    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer, ByRef wErrMessage As String) As Boolean

        Dim parser As FileIO.TextFieldParser
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("SHIFT-JIS"))
        Else
            Me.LabelErrorMessage.Text &= strFilePath & "が見つかりません。" & vbNewLine
            wErrMessage &= CmnCsv.Quotes(strFilePath & "が見つかりません。") & vbNewLine
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

                    '請求データ存在チェック
                    Dim updCnt As Integer = 0
                    If GetKotsuHotel(fileData(COL_NO.KOUENKAI_NO), fileData(COL_NO.SANKASHA_ID)) Then
                        '自動精算対象タクチケテーブルデータ項目セット()
                        Call SetKotsuHotelItem(TBL_KOTSUHOTEL)
                        updCnt = UpdateKotsuhotel(ErrorMessage)
                    Else
                        ErrorMessage &= "参加者ID：" & fileData(COL_NO.SANKASHA_ID) & "は交通宿泊テーブルに登録されていないか、対象外のステータスです。" & vbNewLine
                        wErrMessage &= CmnCsv.Quotes("参加者ID：" & fileData(COL_NO.SANKASHA_ID) & "は交通宿泊テーブルに登録されていないか、対象外のステータスです。") & vbNewLine
                    End If

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
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '必須入力
        If Me.FileUpload1.FileName.Trim = String.Empty Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("発送済対象取込用CSV"), Me)
            Return False
        End If

        '発送年月日
        If Not CmnCheck.IsNumberOnly(Me.ANS_TICKET_SEND_DAY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("発送年月日"), Me)
            SetFocus(Me.ANS_TICKET_SEND_DAY)
            Return False
        End If

        If CmnCheck.IsInput(Me.ANS_TICKET_SEND_DAY) Then
            If Me.ANS_TICKET_SEND_DAY.Text.Trim.Length < 8 Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ("発送年月日", 8, False), Me)
                SetFocus(Me.ANS_TICKET_SEND_DAY)
                Return False
            End If

            Dim wStr As String = StrConv(Me.ANS_TICKET_SEND_DAY.Text.Substring(0, 4) & "/" & Me.ANS_TICKET_SEND_DAY.Text.Substring(4, 2) & "/" & Me.ANS_TICKET_SEND_DAY.Text.Substring(6, 2), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("発送年月日"), Me)
                SetFocus(Me.ANS_TICKET_SEND_DAY)
                Return False
            End If
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

            If fileData(COL_NO.SANKASHA_ID).Trim.Equals(String.Empty) Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.SANKASHA_ID & "がセットされていません。" & vbNewLine
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SetTicketSend, TBL_LOG, False, ErrStr, MyBase.DbConnection)
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

    '送信対象CSV→請求データの送信フラグセット
    Private Sub SetKotsuHotelItem(ByRef TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct)

        TBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY = Me.ANS_TICKET_SEND_DAY.Text
        TBL_KOTSUHOTEL.SEND_FLAG = AppConst.SEND_FLAG.Code.Taisho

    End Sub

    Private Function UpdateKotsuhotel(ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0

        Try
            strSQL = SQL.TBL_KOTSUHOTEL.Update_ANS_TICKET_SEND_DAY(TBL_KOTSUHOTEL)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[交通宿泊テーブルチケット送付日更新失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '交通宿泊データ取得
    Private Function GetKotsuHotel(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID_NEW(KOUENKAI_NO, SANKASHA_ID)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)
            If TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke OrElse _
                TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK OrElse _
                TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend Then

                wFlag = True
            End If
        End If
        RsData.Close()

        Return wFlag
    End Function
End Class
