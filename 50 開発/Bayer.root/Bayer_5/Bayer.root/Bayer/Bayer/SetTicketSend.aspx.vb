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

        'FROM_DATE = 0
        'TO_DATE
        'KOUENKAI_NO
        'KOUENKAI_NAME
        'SANKASHA_ID
        'DR_NAME
        'DR_KANA
        'MR_BU
        'MR_AREA
        'MR_EIGYOSHO
        'MR_NAME
        'MR_KANA
        'MR_SEND_SAKI_FS
        'MR_SEND_SAKI_OTHER
        'TIME_STAMP_BYL
        'INPUT_DATE
        'USER_NAME
        'REQ_STATUS_TEHAI
        'TEHAI_HOTEL
        'TEHAI_KOTSU
        'TEHAI_TAXI
        'TEHAI_MR
        'KINKYU_FLAG
    End Enum

    Private Class COL_NAME
        Public Const KOUENKAI_NO As String = "会合番号"
        Public Const KOUENKAI_NAME As String = "会合名"
        Public Const SANKASHA_ID As String = "参加者番号"
        Public Const DR_NAME As String = "DR氏名"

        'Public Const FROM_DATE = "開催日FROM"
        'Public Const TO_DATE = "開催日TO"
        'Public Const KOUENKAI_NO = "会合番号"
        'Public Const KOUENKAI_NAME = "会合名"
        'Public Const SANKASHA_ID = "参加者番号"
        'Public Const DR_NAME = "DR氏名"
        'Public Const DR_KANA = "DR氏名カナ"
        'Public Const MR_BU = "DR担当MRのBU"
        'Public Const MR_AREA = "DR担当MRのエリア名"
        'Public Const MR_EIGYOSHO = "DR担当MRの営業所名"
        'Public Const MR_NAME = "DR担当MR"
        'Public Const MR_KANA = "DR担当MR(カナ)"
        'Public Const MR_SEND_SAKI_FS = "チケット送付先FS"
        'Public Const MR_SEND_SAKI_OTHER = "チケット送付先(その他)"
        'Public Const TIME_STAMP_BYL = "BYL Timestamp"
        'Public Const INPUT_DATE = "TOP受信日時"
        'Public Const USER_NAME = "TOP担当"
        'Public Const REQ_STATUS_TEHAI = "依頼内容"
        'Public Const TEHAI_HOTEL = "宿泊"
        'Public Const TEHAI_KOTSU = "交通"
        'Public Const TEHAI_TAXI = "タク"
        'Public Const TEHAI_MR = "MR手配"
        'Public Const KINKYU_FLAG = "緊急"
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
        Dim sb As New System.Text.StringBuilder
        Dim sbErr As New System.Text.StringBuilder
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("下記は交通宿泊テーブルに登録されていないか、対象外のステータスです。"), True))
        sb.Append(vbNewLine)
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("対象外ステータス")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催日From")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR名カナ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属エリア")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属営業所")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR名カナ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("送付先")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("送付先(その他)"), True))
        sb.Append(vbNewLine)

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            '1行目はタイトル行のため読み飛ばす
            If rowCnt > 1 Then
                If CheckInput(fileData, strFileName, rowCnt.ToString, ErrorMessage) Then

                    '交通・宿泊データ存在チェック
                    Dim updCnt As Integer = 0
                    Dim wStatus As String = ""
                    If GetKotsuHotel(fileData(COL_NO.KOUENKAI_NO), fileData(COL_NO.SANKASHA_ID), TBL_KOTSUHOTEL, wStatus) Then
                        '発送日設定対象 交通・宿泊テーブルデータ項目セット()
                        Call SetKotsuHotelItem(TBL_KOTSUHOTEL)
                        updCnt = UpdateKotsuhotel(ErrorMessage)
                    Else
                        If wStatus = "" Then
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.KOUENKAI_NO)))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(fileData(COL_NO.SANKASHA_ID))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_TEHAI(TBL_KOTSUHOTEL.ANS_STATUS_TEHAI))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(TBL_KOTSUHOTEL.FROM_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.KOUENKAI_NAME)))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.DR_NAME)))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.DR_KANA)))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_BU(TBL_KOTSUHOTEL.MR_BU))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_AREA(TBL_KOTSUHOTEL.MR_AREA))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_EIGYOSHO(TBL_KOTSUHOTEL.MR_EIGYOSHO))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_NAME(TBL_KOTSUHOTEL.MR_NAME))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_KANA(TBL_KOTSUHOTEL.MR_KANA))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_SEND_SAKI_FS(TBL_KOTSUHOTEL.MR_SEND_SAKI_FS))))
                            sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MR_SEND_SAKI_OTHER(TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER)), True))
                            sbErr.Append(vbNewLine)
                            ErrorMessage &= "参加者ID：" & fileData(COL_NO.SANKASHA_ID) & "は対象外のステータスです。" & vbNewLine
                        Else
                            Dim W_KOUENKAI As New TableDef.TBL_KOUENKAI.DataStruct
                            If GetKouenkai(fileData(COL_NO.KOUENKAI_NO), W_KOUENKAI) Then
                                sbErr.Append(CmnCsv.SetData(W_KOUENKAI.KOUENKAI_NO))
                                sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(fileData(COL_NO.SANKASHA_ID))))
                                sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(wStatus)))
                                sbErr.Append(CmnCsv.SetData(CmnModule.Format_Date(W_KOUENKAI.KOUENKAI_NO, CmnModule.DateFormatType.YYYYMMDD)))
                                sbErr.Append(CmnCsv.SetData(W_KOUENKAI.KOUENKAI_NAME))
                            Else
                                sbErr.Append(CmnCsv.SetData(""))
                                sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(fileData(COL_NO.SANKASHA_ID))))
                                sbErr.Append(CmnCsv.SetData(CmnCsv.Quotes(wStatus)))
                                sbErr.Append(CmnCsv.SetData(""))
                                sbErr.Append(CmnCsv.SetData(""))
                                sbErr.Append(CmnCsv.SetData(""))
                            End If
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""))
                            sbErr.Append(CmnCsv.SetData(""), True)
                            sbErr.Append(vbNewLine)
                            ErrorMessage &= "参加者ID：" & fileData(COL_NO.SANKASHA_ID) & "は交通宿泊テーブルに登録されていません。" & vbNewLine
                        End If
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
            wErrMessage = sb.ToString & sbErr.ToString
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
        TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend
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
    Private Function GetKotsuHotel(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String, ByRef W_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, ByRef STATUS_TEHAI As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOTSUHOTEL.bySANKASHA_ID_NEW(SANKASHA_ID)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)
            If TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke OrElse _
                TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK OrElse _
                TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend Then

                wFlag = True
            Else
                STATUS_TEHAI = ""
            End If
        Else
            STATUS_TEHAI = "交通宿泊テーブル未登録"
        End If
        RsData.Close()

        Return wFlag
    End Function

    '基本情報データ取得
    Private Function GetKouenkai(ByVal KOUENKAI_NO As String, ByRef W_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(KOUENKAI_NO)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            W_KOUENKAI = AppModule.SetRsData(RsData, W_KOUENKAI)
            wFlag = True
        End If
        RsData.Close()

        Return wFlag
    End Function
End Class
