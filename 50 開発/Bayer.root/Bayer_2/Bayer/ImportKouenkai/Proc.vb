Imports AppLib
Imports CommonLib
Imports System.IO

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKouenkai" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    Private Const COL_COUNT As Integer = 42 'ファイルの項目数(Phase3で41→42)

    Private Enum COL_NO
        Field1 = 0
        Field2
        Field3
        Field4
        Field5
        Field6
        Field7
        Field8
        Field9
        Field10
        Field11
        Field12
        Field13
        Field14
        Field15
        Field16
        Field17
        Field18
        Field19
        Field20
        Field21
        Field22
        Field23
        Field24
        Field25
        Field26
        Field27
        Field28
        Field29
        Field30
        Field31
        Field32
        Field33
        Field34
        Field35
        Field36
        Field37
        Field38
        Field39
        Field40
        Field41
        Field42 '@@@ Phase3 ADD
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "講演会番号"
        Public Const Field2 As String = "Timestamp(BYL)"
        Public Const Field3 As String = "取消フラグ"
        Public Const Field4 As String = "講演会名"
        Public Const Field5 As String = "講演会名(チケット印字用)"
        Public Const Field6 As String = "講演会開催日From"
        Public Const Field7 As String = "講演会開催日To"
        Public Const Field8 As String = "講演会会場名"
        Public Const Field9 As String = "製品名"
        Public Const Field10 As String = "Internal order(課税)"
        Public Const Field11 As String = "Internal order(非課税)"
        Public Const Field12 As String = "アカウントコード(課税)"
        Public Const Field13 As String = "アカウントコード(非課税)"
        Public Const Field14 As String = "zetia Code"
        Public Const Field15 As String = "BU(領域)"
        Public Const Field16 As String = "参加予定数(従業員以外)"
        Public Const Field17 As String = "参加予定数(従業員)"
        Public Const Field18 As String = "ＳＲＭ発注区分"
        Public Const Field19 As String = "所属事業部"
        Public Const Field20 As String = "所属エリア"
        Public Const Field21 As String = "所属営業所"
        Public Const Field22 As String = "担当者(企画担当者)名"
        Public Const Field23 As String = "担当者(企画担当者)名(ﾛｰﾏ字)"
        Public Const Field24 As String = "Emailアドレス(企画担当者)"
        Public Const Field25 As String = "携帯のアドレス(企画担当者)"
        Public Const Field26 As String = "携帯電話番号(企画担当者)"
        Public Const Field27 As String = "オフィスの電話番号(企画担当者)"
        Public Const Field28 As String = "Cost Center"
        Public Const Field29 As String = "手配担当者のBU英名"
        Public Const Field30 As String = "手配担当者のエリア名"
        Public Const Field31 As String = "手配担当者の営業所名"
        Public Const Field32 As String = "手配担当者の氏名"
        Public Const Field33 As String = "手配担当者の氏名(ﾛｰﾏ字)"
        Public Const Field34 As String = "手配担当者の会社電話"
        Public Const Field35 As String = "手配担当者のEmail"
        Public Const Field36 As String = "手配担当者の携帯番号"
        Public Const Field37 As String = "手配担当者の携帯メール"
        Public Const Field38 As String = "予算額_非課税"
        Public Const Field39 As String = "予算額_課税"
        Public Const Field40 As String = "慰労会予算_課税"
        Public Const Field41 As String = "意見交換会予算_課税"
        Public Const Field42 As String = "WBSElement"   '@@@ Phase3 ADD 
    End Class
#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        Dim receiveFiles() As String = Directory.GetFiles(My.Settings.PATH_RECEIVE)

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        If Not Directory.Exists(My.Settings.PATH_RECEIVE_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_RECEIVE_BKUP)

        '作業フォルダを空にする'2013/11/05Add
        Dim workFiles() As String = Directory.GetFiles(My.Settings.PATH_WORK)
        For Each workFile As String In workFiles
            File.Delete(workFile)
        Next

        '受信フォルダ→作業フォルダへコピー
        '受信フォルダからファイルを削除
        For Each motofile As String In receiveFiles
            If motofile.ToLower.IndexOf(My.Settings.FILE_NAME.ToLower) >= 0 Then
                File.Copy(motofile, My.Settings.PATH_WORK & "\" & Path.GetFileName(motofile))
                File.Delete(motofile)
            End If
        Next

        workFiles = Directory.GetFiles(My.Settings.PATH_WORK)
        If workFiles.Length = 0 Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象ファイルがありません。")
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント
        For Each filePath As String In workFiles
            ImportData(filePath, insCnt)
        Next

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, insCnt.ToString & "件のデータを登録しました。")

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        For Each filePath As String In workFiles
            Try
                File.Copy(filePath, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileName(filePath))
            Catch ex As Exception
                File.Copy(filePath, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileNameWithoutExtension(filePath) _
                                                                        & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
            End Try
            File.Delete(filePath)
        Next

    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("UTF-8"))
        Else
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, strFilePath & "が見つかりません。")
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        'ダブルクォート囲み、ダブルクォートのエスケープ対応
        parser.HasFieldsEnclosedInQuotes = True

        Dim strNgMoji As String = My.Settings.NG_MOJI
        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            If CheckInput(fileData, strFileName, rowCnt.ToString, strNgMoji) Then
                insCnt += InsertTable(fileData)
            End If

        End While

        'インスタンス開放
        parser.Dispose()

    End Function

    '入力チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, _
                                ByVal strNGMoji As String) As Boolean

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

            '禁則文字チェック
            If Not strNGMoji.Equals(String.Empty) Then
                Dim chkMoji() As String = strNGMoji.Split(",")
                For Each colData As String In fileData
                    For Each moji As String In chkMoji
                        If colData.Contains(moji) Then
                            Throw New Exception("禁則文字[" & moji & "]が含まれています。")
                        End If
                    Next
                Next
            End If

        Catch ex As Exception
            Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, strErrMsg)
            Return False
        End Try

        Return True

    End Function

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As New TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "講演会基本情報ファイル取込"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

    'データ登録
    Private Function InsertTable(ByVal fileData As String()) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct

        Try
            TBL_KOUENKAI = SetInsData(fileData)
            strSQL = SQL.TBL_KOUENKAI.Insert(TBL_KOUENKAI)
            insCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

        Catch ex As Exception
            'ログテーブルに登録
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_KOUENKAI", " SQL:" & strSQL)
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_KOUENKAI.DataStruct

        Dim TBL_KOUENKAI_Ins As New TableDef.TBL_KOUENKAI.DataStruct

        TBL_KOUENKAI_Ins.KOUENKAI_NO = fileData(COL_NO.Field1)
        TBL_KOUENKAI_Ins.TIME_STAMP = fileData(COL_NO.Field2)
        TBL_KOUENKAI_Ins.TORIKESHI_FLG = fileData(COL_NO.Field3)

        TBL_KOUENKAI_Ins.KOUENKAI_TITLE = fileData(COL_NO.Field4)
        TBL_KOUENKAI_Ins.KOUENKAI_NAME = fileData(COL_NO.Field4)

        If fileData(COL_NO.Field5).Trim = "" Then
            'チケット印字名が未設定の場合は、講演会名頭10文字をセットする。
            TBL_KOUENKAI_Ins.TAXI_PRT_NAME = Mid(fileData(COL_NO.Field4), 1, 10)
        Else
            TBL_KOUENKAI_Ins.TAXI_PRT_NAME = fileData(COL_NO.Field5)
        End If

        TBL_KOUENKAI_Ins.FROM_DATE = fileData(COL_NO.Field6)
        TBL_KOUENKAI_Ins.TO_DATE = fileData(COL_NO.Field7)
        TBL_KOUENKAI_Ins.KAIJO_NAME = fileData(COL_NO.Field8)
        TBL_KOUENKAI_Ins.SEIHIN_NAME = fileData(COL_NO.Field9)
        TBL_KOUENKAI_Ins.INTERNAL_ORDER_T = fileData(COL_NO.Field10)
        TBL_KOUENKAI_Ins.INTERNAL_ORDER_TF = fileData(COL_NO.Field11)
        TBL_KOUENKAI_Ins.ACCOUNT_CD_T = fileData(COL_NO.Field12)
        TBL_KOUENKAI_Ins.ACCOUNT_CD_TF = fileData(COL_NO.Field13)
        TBL_KOUENKAI_Ins.ZETIA_CD = fileData(COL_NO.Field14)
        TBL_KOUENKAI_Ins.SANKA_YOTEI_CNT_NMBR = fileData(COL_NO.Field16)
        TBL_KOUENKAI_Ins.SANKA_YOTEI_CNT_MBR = fileData(COL_NO.Field17)
        TBL_KOUENKAI_Ins.SRM_HACYU_KBN = fileData(COL_NO.Field18)
        TBL_KOUENKAI_Ins.BU = fileData(COL_NO.Field15)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_JIGYOUBU = fileData(COL_NO.Field19)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_AREA = fileData(COL_NO.Field20)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EIGYOSHO = fileData(COL_NO.Field21)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_NAME = fileData(COL_NO.Field22)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_ROMA = fileData(COL_NO.Field23)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EMAIL_PC = fileData(COL_NO.Field24)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EMAIL_KEITAI = fileData(COL_NO.Field25)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_KEITAI = fileData(COL_NO.Field26)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_TEL = fileData(COL_NO.Field27)
        TBL_KOUENKAI_Ins.COST_CENTER = fileData(COL_NO.Field28)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_BU = fileData(COL_NO.Field29)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_AREA = fileData(COL_NO.Field30)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_EIGYOSHO = fileData(COL_NO.Field31)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_NAME = fileData(COL_NO.Field32)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_ROMA = fileData(COL_NO.Field33)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_EMAIL_PC = fileData(COL_NO.Field35)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_EMAIL_KEITAI = fileData(COL_NO.Field37)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_KEITAI = fileData(COL_NO.Field36)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_TEL = fileData(COL_NO.Field34)
        TBL_KOUENKAI_Ins.YOSAN_TF = fileData(COL_NO.Field38)
        TBL_KOUENKAI_Ins.YOSAN_T = fileData(COL_NO.Field39)
        TBL_KOUENKAI_Ins.IROUKAI_YOSAN_T = fileData(COL_NO.Field40)
        TBL_KOUENKAI_Ins.IKENKOUKAN_YOSAN_T = fileData(COL_NO.Field41)
        TBL_KOUENKAI_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
        TBL_KOUENKAI_Ins.INPUT_USER = pbatchID
        TBL_KOUENKAI_Ins.UPDATE_USER = pbatchID
        TBL_KOUENKAI_Ins.WBS_ELEMENT = fileData(COL_NO.Field42)

        '同一キーのデータを検索
        Dim TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct = GetData(fileData(COL_NO.Field1))
        If TBL_KOUENKAI Is Nothing Then
            '新規データ
            TBL_KOUENKAI_Ins.KIDOKU_FLG = CmnConst.Flag.On
        Else
            '変更データ
            TBL_KOUENKAI_Ins.KIDOKU_FLG = CmnConst.Flag.Off

            Dim idx As Integer = GetLastData(TBL_KOUENKAI)
            TBL_KOUENKAI_Ins.DANTAI_CODE = TBL_KOUENKAI(idx).DANTAI_CODE
            TBL_KOUENKAI_Ins.TTEHAI_TANTO = TBL_KOUENKAI(idx).TTEHAI_TANTO
            TBL_KOUENKAI_Ins.TTANTO_ID = TBL_KOUENKAI(idx).TTANTO_ID
        End If

        Return TBL_KOUENKAI_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strKouenkaiNo As String) As TableDef.TBL_KOUENKAI.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOUENKAI(wCnt) As TableDef.TBL_KOUENKAI.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_KOUENKAI.byKOUENKAI_NO2(strKouenkaiNo)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KOUENKAI(wCnt)

            TBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_KOUENKAI
        Else
            Return Nothing
        End If

    End Function

    '最新データがセットされている配列の添え字を取得する
    Private Function GetLastData(ByVal TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct) As Integer
        Dim rowNo As Integer = 0
        Dim wCnt As Integer = 0

        For Each record As TableDef.TBL_KOUENKAI.DataStruct In TBL_KOUENKAI
            rowNo = wCnt
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
