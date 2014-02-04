Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiJisseki
    Inherits WebBase

    Private Const COL_COUNT As Integer = 9 'ファイルの項目数
    Private Const pDelimiter As String = ","
    Private SEISAN_TESURYO As String = "0"
    Private HAKKO_TESURYO As String = "0"
    Private TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct = Nothing
    Private TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing

    Private Enum COL_NO
        KOUZA_NO = 0
        KOUZA_SUBNO
        KOUZA_NAME1
        KOUZA_NAME2
        KOUZA_BUKA
        TKT_NO
        USED_DATE
        USED_TAXI
        URIAGE
    End Enum

    Private Class COL_NAME
        Public Const KOUZA_NO As String = "口座番号"
        Public Const KOUZA_SUBNO As String = "口座番号枝番"
        Public Const KOUZA_NAME1 As String = "口座名１"
        Public Const KOUZA_NAME2 As String = "口座名２"
        Public Const KOUZA_BUKA As String = "部課名"
        Public Const TKT_NO As String = "チケット番号"
        Public Const USED_DATE As String = "使用日付"
        Public Const USED_TAXI As String = "タクシー会社コード"
        Public Const URIAGE As String = "金額"
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
            .DispTaxiMenu = True
            .PageTitle = "タクチケ実績データ取込"
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
        '入力チェック
        If Not Check() Then Exit Sub

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.JISSEKI_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.JISSEKI_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.JISSEKI_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("実績データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルをタクチケTBLへImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.JISSEKI_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.JISSEKI_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, False, "取込対象CSVファイルが存在しません。", MyBase.DbConnection)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.JISSEKI_CSV) & FileUpload1.FileName
        ImportData(filePath, insCnt)

        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, True, (insCnt * -1).ToString & "件のデータを登録しました。", MyBase.DbConnection)

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK) & Path.GetFileNameWithoutExtension(filePath) _
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
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, False, strFilePath & "が見つかりません。", MyBase.DbConnection)
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        'ダブルクォート囲み、ダブルクォートのエスケープ対応
        parser.HasFieldsEnclosedInQuotes = True

        '手数料取得
        HAKKO_TESURYO = GetTesuryo(AppConst.MS_CODE.TAXI_TESURYO)
        SEISAN_TESURYO = GetTesuryo(AppConst.MS_CODE.TAXI_SEISAN_TESURYO)

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
            Return True
        End If

    End Function

    '入力チェック
    Private Function Check() As Boolean
        If Me.FileUpload1.FileName.Trim = String.Empty Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("取込む実績データ"), Me)
            Return False
        End If
        Return True
    End Function

    'CSVデータ内容チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, ByRef ErrorMessage As String) As Boolean

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            End If

            If fileData(COL_NO.TKT_NO).Trim.Equals(String.Empty) Then
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_NO & "がセットされていません。" & vbNewLine
            End If

            If fileData(COL_NO.USED_DATE).Trim.Equals(String.Empty) Then
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.USED_DATE & "がセットされていません。" & vbNewLine
            End If

            If fileData(COL_NO.URIAGE).Trim.Equals(String.Empty) Then
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.URIAGE & "がセットされていません。" & vbNewLine
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            'Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, False, strErrMsg, MyBase.DbConnection)
            Return False
        End Try

        Return True

    End Function

    'データ登録
    Private Function UpdateTable(ByVal fileData As String(), ByVal strFileName As String, ByVal rowCnt As Long, ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_TAITICKET_HAKKO_UPD As TableDef.TBL_TAXITICKET_HAKKO.DataStruct = Nothing

        TBL_TAITICKET_HAKKO_UPD = SetUpdateData(fileData, strFileName, rowCnt, ErrorMessage)
        Try
            strSQL = SQL.TBL_TAXITICKET_HAKKO.Update(TBL_TAITICKET_HAKKO_UPD)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_TAXITICKET_HAKKO, False, "[データ取込失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL, MyBase.DbConnection)
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
                    Throw New Exception("未決登録済のため、実績取込できません。[タクチケ番号:" & fileData(COL_NO.TKT_NO) & "]")
                Else

                    '実績CSVの内容をタクチケ発行テーブルの項目へセット
                    Call SetItem(fileData)

                    '交通宿泊テーブル最新レコード取得
                    If GetKotsuhotel(TBL_TAXITICKET_HAKKO.KOUENKAI_NO, TBL_TAXITICKET_HAKKO.SANKASHA_ID) Then
                        '実績CSVに利用日・金額が設定されているが、DRが不参加の場合エンタ="E"
                        If fileData(COL_NO.USED_DATE).Trim <> "" And _
                            Val(fileData(COL_NO.URIAGE).Trim) <> 0 And _
                            TBL_KOTSUHOTEL.SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
                            TBL_TAXITICKET_HAKKO.TKT_ENTA = "E"
                        End If
                        '実績CSVの利用日(実車日)と、交通宿泊テーブルの利用日(予定日)が異なる場合
                        Dim wDate As Date = fileData(COL_NO.USED_DATE)
                        Dim wDateStr As String = CmnModule.Format_DateToString(wDate, CmnModule.DateFormatType.YYYYMMDD)

                        Select Case Val(TBL_TAXITICKET_HAKKO.TKT_LINE_NO)
                            Case 1
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 2
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 3
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 4
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 5
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 6
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 7
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 8
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 9
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 10
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 11
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 12
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 13
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 14
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 15
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 16
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 17
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 18
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 19
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                            Case 20
                                If wDateStr <> TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 Then
                                    TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
                                End If
                        End Select
                    Else
                        Throw New Exception("交通宿泊テーブルに登録されていません。[講演会番号:" & TBL_TAXITICKET_HAKKO.KOUENKAI_NO & ",参加者番号:" & TBL_TAXITICKET_HAKKO.SANKASHA_ID & "]")
                    End If
                End If
            Else
                Throw New Exception("タクチケ発行テーブルに登録されていません。[タクチケ番号:" & fileData(COL_NO.TKT_NO) & "]")
            End If
        Catch ex As Exception
            'Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            Dim strErrMsg As String = strFileName & "【" & rowCnt & "行目】" & ex.Message
            ErrorMessage &= strErrMsg & vbNewLine
            'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, False, strErrMsg, MyBase.DbConnection)
        End Try

        Return TBL_TAXITICKET_HAKKO

    End Function

    '手数料取得
    Private Function GetTesuryo(ByVal Code As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = Code Then
                wStr = MS_CODE(wCnt).DISP_VALUE
                Exit For
            End If
        Next
        Return wStr
    End Function

    'タクチケ発行情報取得
    Private Function GetTaxiticketHakko(ByVal TKT_NO As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_TAXITICKET_HAKKO.byTKT_NO(TKT_NO)
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

        strSQL = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID_NEW(KOUENKAI_NO, SANKASHA_ID)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)
        End If
        RsData.Close()

        Return wFlag
    End Function

    '実績CSV→タクチケ発行テーブル項目セット
    Private Sub SetItem(ByVal filedata() As String)
        Dim wDate As Date = filedata(COL_NO.USED_DATE)
        TBL_TAXITICKET_HAKKO.TKT_USED_DATE = CmnModule.Format_DateToString(wDate, CmnModule.DateFormatType.YYYYMMDD)
        TBL_TAXITICKET_HAKKO.TKT_URIAGE = filedata(COL_NO.URIAGE)
        TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE = HAKKO_TESURYO
        TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE = SEISAN_TESURYO
        TBL_TAXITICKET_HAKKO.TKT_ENTA = String.Empty
        TBL_TAXITICKET_HAKKO.TKT_MIKETSU = "0"
        'TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM = Now.ToString("yyyyMM")
    End Sub
End Class
