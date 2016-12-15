Imports AppLib
Imports CommonLib
Imports System.IO

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKaijoManual" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    Private Const COL_COUNT As Integer = 30 'ファイルの項目数

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
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "Salesforce Id"
        Public Const Field2 As String = "会合手配Id"
        Public Const Field3 As String = "講演会番号"
        Public Const Field4 As String = "手配スタータス (依頼)"
        Public Const Field5 As String = "Timestamp (BYL)"
        Public Const Field6 As String = "最終承認者 (氏名)"
        Public Const Field7 As String = "最終承認日"
        Public Const Field8 As String = "開催日備考欄"
        Public Const Field9 As String = "開催希望地 (都道府県)"
        Public Const Field10 As String = "開催希望地 (市町村)"
        Public Const Field11 As String = "開催希望地 (フリーテキスト)"
        Public Const Field12 As String = "講演会 開始時間"
        Public Const Field13 As String = "講演会 終了時間"
        Public Const Field14 As String = "講演会場 レイアウト"
        Public Const Field15 As String = "意見交換会場 (要・不要)"
        Public Const Field16 As String = "慰労会会場 (要・不要)"
        Public Const Field17 As String = "慰労会参加予定者数"
        Public Const Field18 As String = "講師控室 (要・不要)"
        Public Const Field19 As String = "講師控室 (時間 From)"
        Public Const Field20 As String = "講師控室 (人数)"
        Public Const Field21 As String = "社員控室 (要・不要)"
        Public Const Field22 As String = "社員控室 (人数)"
        Public Const Field23 As String = "世話人会会場 (要・不要)"
        Public Const Field24 As String = "世話人控室 (時間 From)"
        Public Const Field25 As String = "世話人控室 (人数)"
        Public Const Field26 As String = "宿泊希望室数"
        Public Const Field27 As String = "宿泊希望日"
        Public Const Field28 As String = "交通手配予定人数（JR/AIR）"
        Public Const Field29 As String = "タクシー手配予定人数"
        Public Const Field30 As String = "その他備考欄"
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

            'ヘッダ行は読み飛ばし
            If rowCnt > 1 Then
                If CheckInput(fileData, strFileName, rowCnt.ToString, strNgMoji) Then
                    insCnt += InsertTable(fileData)
                End If
            End If
            If (rowCnt - 1) Mod 100 = 0 Then
                Console.WriteLine(batchID & " 取込件数=" & rowCnt - 1.ToString & Space(3) & System.DateTime.Now().ToString("yyyy/MM/dd HH:mm:ss"))
            End If

        End While
        Console.WriteLine(batchID & " 取込件数=" & rowCnt - 1.ToString & Space(3) & System.DateTime.Now().ToString("yyyy/MM/dd HH:mm:ss"))

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

            If fileData(COL_NO.Field3).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field3 & "がセットされていません。")
            End If

            If fileData(COL_NO.Field5).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field5 & "がセットされていません。")
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
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.MANUALBAT
        TBL_LOG.SYORI_NAME = "会場手配ファイル手動取込"
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
        Dim TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct

        Try
            TBL_KAIJO = SetInsData(fileData)
            strSQL = SQL.TBL_KAIJO.Insert(TBL_KAIJO)
            insCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

        Catch ex As Exception
            'ログテーブルに登録
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_KAIJO", " SQL:" & strSQL)
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_KAIJO.DataStruct

        Dim TBL_KAIJO_Ins As New TableDef.TBL_KAIJO.DataStruct

        TBL_KAIJO_Ins.SALEFORCE_ID = fileData(COL_NO.Field1)
        TBL_KAIJO_Ins.TEHAI_ID = fileData(COL_NO.Field2)
        TBL_KAIJO_Ins.KOUENKAI_NO = fileData(COL_NO.Field3)
        TBL_KAIJO_Ins.REQ_STATUS_TEHAI = fileData(COL_NO.Field4)
        TBL_KAIJO_Ins.ANS_STATUS_TEHAI = AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai
        TBL_KAIJO_Ins.TIME_STAMP_BYL = fileData(COL_NO.Field5)

        TBL_KAIJO_Ins.SHONIN_NAME = fileData(COL_NO.Field6)
        TBL_KAIJO_Ins.SHONIN_DATE = fileData(COL_NO.Field7)
        TBL_KAIJO_Ins.KAISAI_DATE_NOTE = fileData(COL_NO.Field8)
        TBL_KAIJO_Ins.KAISAI_KIBOU_ADDRESS1 = fileData(COL_NO.Field9)
        TBL_KAIJO_Ins.KAISAI_KIBOU_ADDRESS2 = fileData(COL_NO.Field10)
        TBL_KAIJO_Ins.KAISAI_KIBOU_NOTE = fileData(COL_NO.Field11)
        TBL_KAIJO_Ins.KOUEN_TIME1 = fileData(COL_NO.Field12)
        TBL_KAIJO_Ins.KOUEN_TIME2 = fileData(COL_NO.Field13)
        TBL_KAIJO_Ins.KOUEN_KAIJO_LAYOUT = fileData(COL_NO.Field14)
        'True/Falseで取得した項目は｢1｣｢0｣に変換(2015/6/15)
        'TBL_KAIJO_Ins.IKENKOUKAN_KAIJO_TEHAI = fileData(COL_NO.Field15)
        If UCase(fileData(COL_NO.Field15)) = "TRUE" Then
            TBL_KAIJO_Ins.IKENKOUKAN_KAIJO_TEHAI = AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Code.Yes
        ElseIf UCase(fileData(COL_NO.Field15)) = "FALSE" Then
            TBL_KAIJO_Ins.IKENKOUKAN_KAIJO_TEHAI = AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Code.No
        Else
            TBL_KAIJO_Ins.IKENKOUKAN_KAIJO_TEHAI = fileData(COL_NO.Field15)
        End If
        'TBL_KAIJO_Ins.IROUKAI_KAIJO_TEHAI = fileData(COL_NO.Field16)
        If UCase(fileData(COL_NO.Field16)) = "TRUE" Then
            TBL_KAIJO_Ins.IROUKAI_KAIJO_TEHAI = AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Code.Yes
        ElseIf UCase(fileData(COL_NO.Field16)) = "FALSE" Then
            TBL_KAIJO_Ins.IROUKAI_KAIJO_TEHAI = AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Code.No
        Else
            TBL_KAIJO_Ins.IROUKAI_KAIJO_TEHAI = fileData(COL_NO.Field16)
        End If
        '小数点付きで取得した項目は整数部分のみ取得(2015/6/15)
        'TBL_KAIJO_Ins.IROUKAI_SANKA_YOTEI_CNT = fileData(COL_NO.Field17)
        If fileData(COL_NO.Field17).Trim = "" Then
            TBL_KAIJO_Ins.IROUKAI_SANKA_YOTEI_CNT = "0"
        Else
            TBL_KAIJO_Ins.IROUKAI_SANKA_YOTEI_CNT = CInt(fileData(COL_NO.Field17))
        End If
        '2015/6/15 End
        'True/Falseで取得した項目は｢1｣｢0｣に変換(2015/6/15)
        'TBL_KAIJO_Ins.KOUSHI_ROOM_TEHAI = fileData(COL_NO.Field18)
        If UCase(fileData(COL_NO.Field18)) = "TRUE" Then
            TBL_KAIJO_Ins.KOUSHI_ROOM_TEHAI = AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Code.Yes
        ElseIf UCase(fileData(COL_NO.Field18)) = "FALSE" Then
            TBL_KAIJO_Ins.KOUSHI_ROOM_TEHAI = AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Code.No
        Else
            TBL_KAIJO_Ins.KOUSHI_ROOM_TEHAI = fileData(COL_NO.Field18)
        End If
        '2015/6/15 End
        TBL_KAIJO_Ins.KOUSHI_ROOM_FROM = fileData(COL_NO.Field19)
        '小数点付きで取得した項目は整数部分のみ取得(2015/6/15)
        'TBL_KAIJO_Ins.KOUSHI_ROOM_CNT = fileData(COL_NO.Field20)
        If fileData(COL_NO.Field20).Trim = "" Then
            TBL_KAIJO_Ins.KOUSHI_ROOM_CNT = "0"
        Else
            TBL_KAIJO_Ins.KOUSHI_ROOM_CNT = CInt(fileData(COL_NO.Field20))
        End If
        '2015/6/15 End

        'True/Falseで取得した項目は｢1｣｢0｣に変換(2015/6/15)
        'TBL_KAIJO_Ins.SHAIN_ROOM_TEHAI = fileData(COL_NO.Field21)
        If UCase(fileData(COL_NO.Field21)) = "TRUE" Then
            TBL_KAIJO_Ins.SHAIN_ROOM_TEHAI = AppConst.KAIJO.SHAIN_ROOM_TEHAI.Code.Yes
        ElseIf UCase(fileData(COL_NO.Field21)) = "FALSE" Then
            TBL_KAIJO_Ins.SHAIN_ROOM_TEHAI = AppConst.KAIJO.SHAIN_ROOM_TEHAI.Code.No
        Else
            TBL_KAIJO_Ins.SHAIN_ROOM_TEHAI = fileData(COL_NO.Field21)
        End If
        '2015/6/15 End
        '小数点付きで取得した項目は整数部分のみ取得(2015/6/15)
        'TBL_KAIJO_Ins.SHAIN_ROOM_CNT = fileData(COL_NO.Field22)
        If fileData(COL_NO.Field22).Trim = "" Then
            TBL_KAIJO_Ins.SHAIN_ROOM_CNT = "0"
        Else
            TBL_KAIJO_Ins.SHAIN_ROOM_CNT = CInt(fileData(COL_NO.Field22))
        End If
        '2015/6/15 End
        'True/Falseで取得した項目は｢1｣｢0｣に変換(2015/6/15)
        TBL_KAIJO_Ins.MANAGER_KAIJO_TEHAI = fileData(COL_NO.Field23)
        If UCase(fileData(COL_NO.Field23)) = "TRUE" Then
            TBL_KAIJO_Ins.MANAGER_KAIJO_TEHAI = AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Code.Yes
        ElseIf UCase(fileData(COL_NO.Field23)) = "FALSE" Then
            TBL_KAIJO_Ins.MANAGER_KAIJO_TEHAI = AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Code.No
        Else
            TBL_KAIJO_Ins.MANAGER_KAIJO_TEHAI = fileData(COL_NO.Field23)
        End If
        '2015/6/15 End
        TBL_KAIJO_Ins.MANAGER_ROOM_FROM = fileData(COL_NO.Field24)
        '小数点付きで取得した項目は整数部分のみ取得(2015/6/15)
        'TBL_KAIJO_Ins.MANAGER_ROOM_CNT = fileData(COL_NO.Field25)
        'TBL_KAIJO_Ins.REQ_ROOM_CNT = fileData(COL_NO.Field26)
        If fileData(COL_NO.Field25).Trim = "" Then
            TBL_KAIJO_Ins.MANAGER_ROOM_CNT = "0"
        Else
            TBL_KAIJO_Ins.MANAGER_ROOM_CNT = CInt(fileData(COL_NO.Field25))
        End If
        If fileData(COL_NO.Field26).Trim = "" Then
            TBL_KAIJO_Ins.REQ_ROOM_CNT = "0"
        Else
            TBL_KAIJO_Ins.REQ_ROOM_CNT = CInt(fileData(COL_NO.Field26))
        End If
        '2015/6/15 End

        TBL_KAIJO_Ins.REQ_STAY_DATE = fileData(COL_NO.Field27)
        '小数点付きで取得した項目は整数部分のみ取得(2015/6/15)
        'TBL_KAIJO_Ins.REQ_KOTSU_CNT = fileData(COL_NO.Field28)
        'TBL_KAIJO_Ins.REQ_TAXI_CNT = fileData(COL_NO.Field29)
        If fileData(COL_NO.Field28).Trim = "" Then
            TBL_KAIJO_Ins.REQ_KOTSU_CNT = "0"
        Else
            TBL_KAIJO_Ins.REQ_KOTSU_CNT = CInt(fileData(COL_NO.Field28))
        End If
        If fileData(COL_NO.Field29).Trim = "" Then
            TBL_KAIJO_Ins.REQ_TAXI_CNT = "0"
        Else
            TBL_KAIJO_Ins.REQ_TAXI_CNT = CInt(fileData(COL_NO.Field29))
        End If
        '2015/6/15 End
        TBL_KAIJO_Ins.OTHER_NOTE = fileData(COL_NO.Field30)

        TBL_KAIJO_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi
        TBL_KAIJO_Ins.INPUT_USER = pbatchID
        TBL_KAIJO_Ins.UPDATE_USER = pbatchID

        '同一キーのデータを検索
        Dim TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct = GetData(fileData(COL_NO.Field3), fileData(COL_NO.Field2))
        If Not TBL_KAIJO Is Nothing Then
            '該当データがあるとき
            Dim idx As Integer = GetLastData(TBL_KAIJO)

            TBL_KAIJO_Ins.KAIJO_URL = TBL_KAIJO(idx).KAIJO_URL
            TBL_KAIJO_Ins.ANS_SENTEI_RIYU = TBL_KAIJO(idx).ANS_SENTEI_RIYU
            TBL_KAIJO_Ins.ANS_MITSUMORI_TF = TBL_KAIJO(idx).ANS_MITSUMORI_TF
            TBL_KAIJO_Ins.ANS_MITSUMORI_T = TBL_KAIJO(idx).ANS_MITSUMORI_T
            TBL_KAIJO_Ins.ANS_MITSUMORI_TOTAL = TBL_KAIJO(idx).ANS_MITSUMORI_TOTAL
            TBL_KAIJO_Ins.ANS_MITSUMORI_URL = TBL_KAIJO(idx).ANS_MITSUMORI_URL
            TBL_KAIJO_Ins.ANS_SHISETSU_NAME = TBL_KAIJO(idx).ANS_SHISETSU_NAME
            TBL_KAIJO_Ins.ANS_SHISETSU_ZIP = TBL_KAIJO(idx).ANS_SHISETSU_ZIP
            TBL_KAIJO_Ins.ANS_SHISETSU_ADDRESS = TBL_KAIJO(idx).ANS_SHISETSU_ADDRESS
            TBL_KAIJO_Ins.ANS_SHISETSU_TEL = TBL_KAIJO(idx).ANS_SHISETSU_TEL
            TBL_KAIJO_Ins.ANS_SHISETSU_URL = TBL_KAIJO(idx).ANS_SHISETSU_URL
            TBL_KAIJO_Ins.ANS_KOUEN_KAIJO_NAME = TBL_KAIJO(idx).ANS_KOUEN_KAIJO_NAME
            TBL_KAIJO_Ins.ANS_KOUEN_KAIJO_FLOOR = TBL_KAIJO(idx).ANS_KOUEN_KAIJO_FLOOR
            TBL_KAIJO_Ins.ANS_IKENKOUKAN_KAIJO_NAME = TBL_KAIJO(idx).ANS_IKENKOUKAN_KAIJO_NAME
            TBL_KAIJO_Ins.ANS_IROUKAI_KAIJO_NAME = TBL_KAIJO(idx).ANS_IROUKAI_KAIJO_NAME
            TBL_KAIJO_Ins.ANS_KOUSHI_ROOM_NAME = TBL_KAIJO(idx).ANS_KOUSHI_ROOM_NAME
            TBL_KAIJO_Ins.ANS_SHAIN_ROOM_NAME = TBL_KAIJO(idx).ANS_SHAIN_ROOM_NAME
            TBL_KAIJO_Ins.ANS_MANAGER_KAIJO_NAME = TBL_KAIJO(idx).ANS_MANAGER_KAIJO_NAME
            TBL_KAIJO_Ins.ANS_KAISAI_NOTE = TBL_KAIJO(idx).ANS_KAISAI_NOTE
            TBL_KAIJO_Ins.ANS_KAIJOUHI_TF = TBL_KAIJO(idx).ANS_KAIJOUHI_TF
            TBL_KAIJO_Ins.ANS_KIZAIHI_TF = TBL_KAIJO(idx).ANS_KIZAIHI_TF
            TBL_KAIJO_Ins.ANS_INSHOKUHI_TF = TBL_KAIJO(idx).ANS_INSHOKUHI_TF
            TBL_KAIJO_Ins.ANS_991330401_TF = TBL_KAIJO(idx).ANS_991330401_TF
            TBL_KAIJO_Ins.ANS_HOTELHI_TF = TBL_KAIJO(idx).ANS_HOTELHI_TF
            TBL_KAIJO_Ins.ANS_KOTSUHI_TF = TBL_KAIJO(idx).ANS_KOTSUHI_TF
            TBL_KAIJO_Ins.ANS_TAXI_TF = TBL_KAIJO(idx).ANS_TAXI_TF
            TBL_KAIJO_Ins.ANS_TEHAI_TESURYO_TF = TBL_KAIJO(idx).ANS_TEHAI_TESURYO_TF
            TBL_KAIJO_Ins.ANS_TAXI_HAKKEN_TESURYO_TF = TBL_KAIJO(idx).ANS_TAXI_HAKKEN_TESURYO_TF
            TBL_KAIJO_Ins.ANS_TAXI_SEISAN_TESURYO_TF = TBL_KAIJO(idx).ANS_TAXI_SEISAN_TESURYO_TF
            TBL_KAIJO_Ins.ANS_JINKENHI_TF = TBL_KAIJO(idx).ANS_JINKENHI_TF
            TBL_KAIJO_Ins.ANS_OTHER_TF = TBL_KAIJO(idx).ANS_OTHER_TF
            TBL_KAIJO_Ins.ANS_KANRIHI_TF = TBL_KAIJO(idx).ANS_KANRIHI_TF
            TBL_KAIJO_Ins.ANS_41120200_TF = TBL_KAIJO(idx).ANS_41120200_TF
            TBL_KAIJO_Ins.ANS_TOTAL_TF = TBL_KAIJO(idx).ANS_TOTAL_TF
            TBL_KAIJO_Ins.ANS_KAIJOUHI_T = TBL_KAIJO(idx).ANS_KAIJOUHI_T
            TBL_KAIJO_Ins.ANS_KIZAIHI_T = TBL_KAIJO(idx).ANS_KIZAIHI_T
            TBL_KAIJO_Ins.ANS_INSHOKUHI_T = TBL_KAIJO(idx).ANS_INSHOKUHI_T
            TBL_KAIJO_Ins.ANS_991330401_T = TBL_KAIJO(idx).ANS_991330401_T
            TBL_KAIJO_Ins.ANS_JINKENHI_T = TBL_KAIJO(idx).ANS_JINKENHI_T
            TBL_KAIJO_Ins.ANS_OTHER_T = TBL_KAIJO(idx).ANS_OTHER_T
            TBL_KAIJO_Ins.ANS_KANRIHI_T = TBL_KAIJO(idx).ANS_KANRIHI_T
            TBL_KAIJO_Ins.ANS_41120200_T = TBL_KAIJO(idx).ANS_41120200_T
            TBL_KAIJO_Ins.ANS_TOTAL_T = TBL_KAIJO(idx).ANS_TOTAL_T
        End If

        Return TBL_KAIJO_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strKouenkaiNo As String, ByVal strTehaiId As String) As TableDef.TBL_KAIJO.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KAIJO(wCnt) As TableDef.TBL_KAIJO.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_KAIJO.byKOUENKAI_NO_TEHAI_ID(strKouenkaiNo, strTehaiId)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KAIJO(wCnt)

            TBL_KAIJO(wCnt) = AppModule.SetRsData(RsData, TBL_KAIJO(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_KAIJO
        Else
            Return Nothing
        End If

    End Function

    '最新データがセットされている配列の添え字を取得する
    Private Function GetLastData(ByVal TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct) As Integer
        Dim rowNo As Integer = 0
        Dim wCnt As Integer = 0

        For Each record As TableDef.TBL_KAIJO.DataStruct In TBL_KAIJO
            rowNo = wCnt
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
