Imports AppLib
Imports CommonLib
Imports System.IO

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKouenkai" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    'TODO:項目確定次第定義する
    Private Const COL_COUNT As Integer = 40 'ファイルの項目数

    Private Enum COL_NO
        Name = 0
        MeetingName__c
        MeetingNo__c
        TT_TimestampBYL__c
        TT_NameForTicket__c
        TT_StartDate__c
        TT_EndDate__c
        TT_Cancel__c
        TT_ItemName__c
        TT_InternalOrderTaxable__c
        TT_InternalOrderNonTaxable__c
        TT_AccountCodeTaxable__c
        TT_AccountCodeNonTaxable__c
        TT_ZetiaCode__c
        TT_NumberOfInvitedMember__c
        TT_PlanPersonBU_NameEN__c
        TT_PlanPersonAreaName__c
        TT_PlanPersonFS_Name__c
        TT_PlanPersonNameKanji__c
        TT_PlanPersonName__c
        TT_PlanPersonPhone__c
        TT_PlanPersonEmail__c
        TT_PlanPersonMobile__c
        TT_PlanPersonMobileMail__c
        TT_CostCenter__c
        TT_ArrangePersonBU_NameEN__c
        TT_ArrangePersonAreaName__c
        TT_ArrangePersonFS_Name__c
        TT_ArrangePersonNameKanji__c
        TT_ArrangePersonName__c
        TT_ArrangePersonPhone__c
        TT_ArrangePersonEmail__c
        TT_ArrangePersonMobile__c
        TT_ArrangePersonMobileMail__c
        TT_BudgetTaxableTotal__c
        TT_BudgetNonTaxableTotal__c
        TT_MeetingPlaceName__c
        TT_StatusRequest__c
        TT_LastModifiedDate__c
        Invalid__c
    End Enum

    Private Class COL_NAME
        Public Const Name As String = "タイトル"
        Public Const MeetingName__c As String = "会合名"
        Public Const MeetingNo__c As String = "会合番号"
        Public Const TT_TimestampBYL__c As String = "Timestamp (BYL)"
        Public Const TT_NameForTicket__c As String = "会合名 (チケット印字用)"
        Public Const TT_StartDate__c As String = "開催開始日"
        Public Const TT_EndDate__c As String = "開催終了日"
        Public Const TT_Cancel__c As String = "取消フラグ"
        Public Const TT_ItemName__c As String = "品名"
        Public Const TT_InternalOrderTaxable__c As String = "Internal Order (課税)"
        Public Const TT_InternalOrderNonTaxable__c As String = "Internal Order (非課税)"
        Public Const TT_AccountCodeTaxable__c As String = "Account Code (課税)"
        Public Const TT_AccountCodeNonTaxable__c As String = "Account Code (非課税)"
        Public Const TT_ZetiaCode__c As String = "Zetiaコード"
        Public Const TT_NumberOfInvitedMember__c As String = "参加予定人数"
        Public Const TT_PlanPersonBU_NameEN__c As String = "企画担当者のBU英名"
        Public Const TT_PlanPersonAreaName__c As String = "企画担当者のエリア名"
        Public Const TT_PlanPersonFS_Name__c As String = "企画担当者の営業所名"
        Public Const TT_PlanPersonNameKanji__c As String = "企画担当者の氏名"
        Public Const TT_PlanPersonName__c As String = "企画担当者の氏名(ﾛｰﾏ字)"
        Public Const TT_PlanPersonPhone__c As String = "企画担当者の会社電話"
        Public Const TT_PlanPersonEmail__c As String = "企画担当者のEmail"
        Public Const TT_PlanPersonMobile__c As String = "企画担当者の携帯番号"
        Public Const TT_PlanPersonMobileMail__c As String = "企画担当者の携帯メール"
        Public Const TT_CostCenter__c As String = "企画担当者のCostCenter"
        Public Const TT_ArrangePersonBU_NameEN__c As String = "手配担当者のBU英名"
        Public Const TT_ArrangePersonAreaName__c As String = "手配担当者のエリア名"
        Public Const TT_ArrangePersonFS_Name__c As String = "手配担当者の営業所名"
        Public Const TT_ArrangePersonNameKanji__c As String = "手配担当者の氏名"
        Public Const TT_ArrangePersonName__c As String = "手配担当者の氏名(ﾛｰﾏ字)"
        Public Const TT_ArrangePersonPhone__c As String = "手配担当者の会社電話"
        Public Const TT_ArrangePersonEmail__c As String = "手配担当者のEmail"
        Public Const TT_ArrangePersonMobile__c As String = "手配担当者の携帯番号"
        Public Const TT_ArrangePersonMobileMail__c As String = "手配担当者の携帯メール"
        Public Const TT_BudgetTaxableTotal__c As String = "概算予算（課税）"
        Public Const TT_BudgetNonTaxableTotal__c As String = "概算予算（非課税）"
        Public Const TT_MeetingPlaceName__c As String = "会場名"
        Public Const TT_StatusRequest__c As String = "TT連携ステータス(Request)"
        Public Const TT_LastModifiedDate__c As String = "TT連携用最終更新日"
        Public Const Invalid__c As String = "無効"
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
            If fileData(COL_NO.MeetingNo__c).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.MeetingNo__c & "がセットされていません。")
            End If

            If fileData(COL_NO.TT_TimestampBYL__c).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.TT_TimestampBYL__c & "がセットされていません。")
            End If

            If fileData(COL_NO.Name).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Name & "がセットされていません。")
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

        TBL_KOUENKAI_Ins.KOUENKAI_NO = fileData(COL_NO.MeetingNo__c)
        TBL_KOUENKAI_Ins.TIME_STAMP = fileData(COL_NO.TT_TimestampBYL__c)
        TBL_KOUENKAI_Ins.TORIKESHI_FLG = fileData(COL_NO.TT_Cancel__c)
        TBL_KOUENKAI_Ins.KIDOKU_FLG = CmnConst.Flag.Off
        TBL_KOUENKAI_Ins.KOUENKAI_TITLE = fileData(COL_NO.Name)
        TBL_KOUENKAI_Ins.KOUENKAI_NAME = fileData(COL_NO.MeetingName__c)
        TBL_KOUENKAI_Ins.TAXI_PRT_NAME = fileData(COL_NO.TT_NameForTicket__c)
        TBL_KOUENKAI_Ins.FROM_DATE = fileData(COL_NO.TT_StartDate__c)
        TBL_KOUENKAI_Ins.TO_DATE = fileData(COL_NO.TT_EndDate__c)
        TBL_KOUENKAI_Ins.KAIJO_NAME = fileData(COL_NO.TT_MeetingPlaceName__c)
        TBL_KOUENKAI_Ins.SEIHIN_NAME = fileData(COL_NO.TT_ItemName__c)
        TBL_KOUENKAI_Ins.INTERNAL_ORDER_T = fileData(COL_NO.TT_InternalOrderTaxable__c)
        TBL_KOUENKAI_Ins.INTERNAL_ORDER_TF = fileData(COL_NO.TT_InternalOrderNonTaxable__c)
        TBL_KOUENKAI_Ins.ACCOUNT_CD_T = fileData(COL_NO.TT_AccountCodeTaxable__c)
        TBL_KOUENKAI_Ins.ACCOUNT_CD_TF = fileData(COL_NO.TT_AccountCodeNonTaxable__c)
        TBL_KOUENKAI_Ins.ZETIA_CD = fileData(COL_NO.TT_ZetiaCode__c)
        TBL_KOUENKAI_Ins.SANKA_YOTEI_CNT = fileData(COL_NO.TT_NumberOfInvitedMember__c)
        TBL_KOUENKAI_Ins.BU = fileData(COL_NO.TT_PlanPersonBU_NameEN__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_AREA = fileData(COL_NO.TT_PlanPersonAreaName__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EIGYOSHO = fileData(COL_NO.TT_PlanPersonFS_Name__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_NAME = fileData(COL_NO.TT_PlanPersonNameKanji__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_ROMA = fileData(COL_NO.TT_PlanPersonName__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EMAIL_PC = fileData(COL_NO.TT_PlanPersonEmail__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_EMAIL_KEITAI = fileData(COL_NO.TT_PlanPersonMobileMail__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_KEITAI = fileData(COL_NO.TT_PlanPersonMobile__c)
        TBL_KOUENKAI_Ins.KIKAKU_TANTO_TEL = fileData(COL_NO.TT_PlanPersonPhone__c)
        TBL_KOUENKAI_Ins.COST_CENTER = fileData(COL_NO.TT_CostCenter__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_BU = fileData(COL_NO.TT_ArrangePersonBU_NameEN__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_AREA = fileData(COL_NO.TT_ArrangePersonAreaName__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_EIGYOSHO = fileData(COL_NO.TT_ArrangePersonFS_Name__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_NAME = fileData(COL_NO.TT_ArrangePersonNameKanji__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_ROMA = fileData(COL_NO.TT_ArrangePersonName__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_EMAIL_PC = fileData(COL_NO.TT_ArrangePersonEmail__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_EMAIL_KEITAI = fileData(COL_NO.TT_ArrangePersonMobileMail__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_KEITAI = fileData(COL_NO.TT_ArrangePersonMobile__c)
        TBL_KOUENKAI_Ins.TEHAI_TANTO_TEL = fileData(COL_NO.TT_ArrangePersonPhone__c)
        TBL_KOUENKAI_Ins.YOSAN_TF = fileData(COL_NO.TT_BudgetNonTaxableTotal__c)
        TBL_KOUENKAI_Ins.YOSAN_T = fileData(COL_NO.TT_BudgetTaxableTotal__c)
        TBL_KOUENKAI_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
        TBL_KOUENKAI_Ins.INPUT_USER = pbatchID
        TBL_KOUENKAI_Ins.UPDATE_USER = pbatchID

        '同一キーのデータを検索
        Dim TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct = GetData(fileData(COL_NO.MeetingNo__c))
        If Not TBL_KOUENKAI Is Nothing Then
            '該当データがあるとき
            Dim idx As Integer = GetLastData(TBL_KOUENKAI)
            TBL_KOUENKAI_Ins.TTANTO_ID = TBL_KOUENKAI(idx).TTANTO_ID
        End If

        Return TBL_KOUENKAI_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strKouenkaiNo As String) As TableDef.TBL_KOUENKAI.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOUENKAI(wCnt) As TableDef.TBL_KOUENKAI.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_KOUENKAI.byKOUENKAI_NO(strKouenkaiNo)
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
            If record.KIDOKU_FLG = CmnConst.Flag.On Then
                rowNo = wCnt
            End If
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
