Imports AppLib
Imports CommonLib
Imports System.IO

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKouenkai" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    'TODO:項目確定次第定義する
    Private Const COL_COUNT As Integer = 28 'ファイルの項目数

    Private Enum COL_NO
        KOUENKAI_NO = 0
        TIME_STAMP
        TORIKESHI_FLG
        KOUENKAI_TITLE
        KOUENKAI_NAME
        TAXI_PRT_NAME
        FROM_DATE
        TO_DATE
        KAIJO_NAME
        SEIHIN_NAME
        INTERNAL_ORDER_T
        INTERNAL_ORDER_TF
        ACCOUNT_CD_T
        ACCOUNT_CD_TF
        ZETIA_CD
        SANKA_YOTEI_CNT
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        KIKAKU_TANTO_ROMA
        KIKAKU_TANTO_EMAIL_PC
        KIKAKU_TANTO_EMAIL_KEITAI
        KIKAKU_TANTO_KEITAI
        KIKAKU_TANTO_TEL
        COST_CENTER
        YOSAN_TF
        YOSAN_T
    End Enum

    Private Class COL_NAME
        Public Const KOUENKAI_NO As String = "講演会番号"
        Public Const TIME_STAMP As String = "Timestamp（BYL)"
        Public Const TORIKESHI_FLG As String = ""
        Public Const KOUENKAI_TITLE As String = "タイトル"
        Public Const KOUENKAI_NAME As String = ""
        Public Const TAXI_PRT_NAME As String = ""
        Public Const FROM_DATE As String = ""
        Public Const TO_DATE As String = ""
        Public Const KAIJO_NAME As String = ""
        Public Const SEIHIN_NAME As String = ""
        Public Const INTERNAL_ORDER_T As String = ""
        Public Const INTERNAL_ORDER_TF As String = ""
        Public Const ACCOUNT_CD_T As String = ""
        Public Const ACCOUNT_CD_TF As String = ""
        Public Const ZETIA_CD As String = ""
        Public Const SANKA_YOTEI_CNT As String = ""
        Public Const BU As String = ""
        Public Const KIKAKU_TANTO_AREA As String = ""
        Public Const KIKAKU_TANTO_EIGYOSHO As String = ""
        Public Const KIKAKU_TANTO_NAME As String = ""
        Public Const KIKAKU_TANTO_ROMA As String = ""
        Public Const KIKAKU_TANTO_EMAIL_PC As String = ""
        Public Const KIKAKU_TANTO_EMAIL_KEITAI As String = ""
        Public Const KIKAKU_TANTO_KEITAI As String = ""
        Public Const KIKAKU_TANTO_TEL As String = ""
        Public Const COST_CENTER As String = ""
        Public Const YOSAN_TF As String = ""
        Public Const YOSAN_T As String = ""
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

        '受信フォルダ→作業フォルダへコピー
        '受信フォルダからファイルを削除
        For Each motofile As String In receiveFiles
            If motofile.ToLower.IndexOf(My.Settings.FILE_NAME.ToLower) >= 0 Then
                File.Copy(motofile, My.Settings.PATH_WORK & "\" & Path.GetFileName(motofile))
                File.Delete(motofile)
            End If
        Next

        Dim workFiles() As String = Directory.GetFiles(My.Settings.PATH_WORK)
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
            File.Copy(filePath, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileName(filePath))
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
            If fileData(COL_NO.KOUENKAI_NO).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.KOUENKAI_NO & "がセットされていません。")
            End If

            If fileData(COL_NO.TIME_STAMP).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.TIME_STAMP & "がセットされていません。")
            End If

            If fileData(COL_NO.KOUENKAI_TITLE).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.KOUENKAI_TITLE & "がセットされていません。")
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

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct
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

        'TODO:ダブルクォート囲みのとき、またダブルクォートのエスケープの仕様が確定したら処理追加

        TBL_KOUENKAI_Ins.KOUENKAI_NO = fileData(COL_NO.KOUENKAI_NO)
        TBL_KOUENKAI_Ins.TIME_STAMP = fileData(COL_NO.TIME_STAMP)
        TBL_KOUENKAI_Ins.TORIKESHI_FLG = fileData(COL_NO.TORIKESHI_FLG)
        TBL_KOUENKAI_Ins.KIDOKU_FLG = CmnConst.Flag.Off
        TBL_KOUENKAI_Ins.KOUENKAI_TITLE = fileData(COL_NO.KOUENKAI_TITLE)
        TBL_KOUENKAI_Ins.KOUENKAI_NAME = fileData(COL_NO.KOUENKAI_NAME)
        TBL_KOUENKAI_Ins.TAXI_PRT_NAME = fileData(COL_NO.TAXI_PRT_NAME)
        TBL_KOUENKAI_Ins.FROM_DATE = fileData(COL_NO.FROM_DATE)
        TBL_KOUENKAI_Ins.TO_DATE = fileData(COL_NO.TO_DATE)
        TBL_KOUENKAI_Ins.KAIJO_NAME = fileData(COL_NO.KAIJO_NAME)
        TBL_KOUENKAI_Ins.SEIHIN_NAME = fileData(COL_NO.SEIHIN_NAME)
        TBL_KOUENKAI_Ins.INTERNAL_ORDER_T = fileData(COL_NO.INTERNAL_ORDER_T)
        TBL_KOUENKAI_Ins.INTERNAL_ORDER_TF = fileData(COL_NO.INTERNAL_ORDER_TF)
        TBL_KOUENKAI_Ins.ACCOUNT_CD_T = fileData(COL_NO.ACCOUNT_CD_T)
        TBL_KOUENKAI_Ins.ACCOUNT_CD_TF = fileData(COL_NO.ACCOUNT_CD_TF)
        TBL_KOUENKAI_Ins.ZETIA_CD = fileData(COL_NO.ZETIA_CD)
        TBL_KOUENKAI_Ins.SANKA_YOTEI_CNT = fileData(COL_NO.SANKA_YOTEI_CNT)
        TBL_KOUENKAI_Ins.BU = fileData(COL_NO.BU)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_AREA = fileData(COL_NO.KIKAKU_TANTO_AREA)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EIGYOSHO = fileData(COL_NO.KIKAKU_TANTO_EIGYOSHO)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_NAME = fileData(COL_NO.KIKAKU_TANTO_NAME)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_ROMA = fileData(COL_NO.KIKAKU_TANTO_ROMA)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EMAIL_PC = fileData(COL_NO.KIKAKU_TANTO_EMAIL_PC)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EMAIL_KEITAI = fileData(COL_NO.KIKAKU_TANTO_EMAIL_KEITAI)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_KEITAI = fileData(COL_NO.KIKAKU_TANTO_KEITAI)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_TEL = fileData(COL_NO.KIKAKU_TANTO_TEL)
        TBL_KOUENKAI_Ins.COST_CENTER = fileData(COL_NO.COST_CENTER)
        TBL_KOUENKAI_Ins.YOSAN_TF = fileData(COL_NO.YOSAN_TF)
        TBL_KOUENKAI_Ins.YOSAN_T = fileData(COL_NO.YOSAN_T)
        TBL_KOUENKAI_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi

        Dim strNow As String = Now.ToString("yyyyMMddHHmmss")

        TBL_KOUENKAI_Ins.INPUT_DATE = strNow
        TBL_KOUENKAI_Ins.INPUT_USER = pbatchID
        TBL_KOUENKAI_Ins.UPDATE_DATE = strNow
        TBL_KOUENKAI_Ins.UPDATE_USER = pbatchID


        '同一キーのデータを検索
        Dim TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct = GetData(fileData(COL_NO.KOUENKAI_NO))
        If TBL_KOUENKAI.Length = 0 Then
            '該当データ0件のとき
            TBL_KOUENKAI_Ins.TTANTO_ID = ""
        Else
            TBL_KOUENKAI_Ins.TTANTO_ID = TBL_KOUENKAI(GetLastData(TBL_KOUENKAI)).TTANTO_ID
        End If

        Return TBL_KOUENKAI_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strKouenkaiNo As String) As TableDef.TBL_KOUENKAI.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOUENKAI(wCnt) As TableDef.TBL_KOUENKAI.DataStruct

        Dim strSQL As String = SQL.TBL_KOUENKAI.byKOUENKAI_NO(strKouenkaiNo)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            ReDim Preserve TBL_KOUENKAI(wCnt)

            TBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        Return TBL_KOUENKAI
    End Function

    '最新データがセットされている配列の添え字を取得する
    Private Function GetLastData(ByVal TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct) As Integer
        Dim rowNo As Integer = 0
        Dim wCnt As Integer = 0

        For Each record As TableDef.TBL_KOUENKAI.DataStruct In TBL_KOUENKAI
            If record.KIDOKU_FLG = CmnConst.Flag.On Then
                rowNo = wCnt
            End If
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
