Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKotsuHotel" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    Private Const COL_COUNT As Integer = 188 'ファイルの項目数

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
        Field42
        Field43
        Field44
        Field45
        Field46
        Field47
        Field48
        Field49
        Field50
        Field51
        Field52
        Field53
        Field54
        Field55
        Field56
        Field57
        Field58
        Field59
        Field60
        Field61
        Field62
        Field63
        Field64
        Field65
        Field66
        Field67
        Field68
        Field69
        Field70
        Field71
        Field72
        Field73
        Field74
        Field75
        Field76
        Field77
        Field78
        Field79
        Field80
        Field81
        Field82
        Field83
        Field84
        Field85
        Field86
        Field87
        Field88
        Field89
        Field90
        Field91
        Field92
        Field93
        Field94
        Field95
        Field96
        Field97
        Field98
        Field99
        Field100
        Field101
        Field102
        Field103
        Field104
        Field105
        Field106
        Field107
        Field108
        Field109
        Field110
        Field111
        Field112
        Field113
        Field114
        Field115
        Field116
        Field117
        Field118
        Field119
        Field120
        Field121
        Field122
        Field123
        Field124
        Field125
        Field126
        Field127
        Field128
        Field129
        Field130
        Field131
        Field132
        Field133
        Field134
        Field135
        Field136
        Field137
        Field138
        Field139
        Field140
        Field141
        Field142
        Field143
        Field144
        Field145
        Field146
        Field147
        Field148
        Field149
        Field150
        Field151
        Field152
        Field153
        Field154
        Field155
        Field156
        Field157
        Field158
        Field159
        Field160
        Field161
        Field162
        Field163
        Field164
        Field165
        Field166
        Field167
        Field168
        Field169
        Field170
        Field171
        Field172
        Field173
        Field174
        Field175
        Field176
        Field177
        Field178
        Field179
        Field180
        Field181
        Field182
        Field183
        Field184
        Field185
        Field186
        Field187
        Field188
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "Salesforce Id"
        Public Const Field2 As String = "講演会番号"
        Public Const Field3 As String = "手配スタータス (依頼)"
        Public Const Field4 As String = "Timestamp (BYL)"
        Public Const Field5 As String = "MTP ID (参加者ID)"
        Public Const Field6 As String = "DRコード"
        Public Const Field7 As String = "DR氏名"
        Public Const Field8 As String = "DR氏名 (半角カタカナ)"
        Public Const Field9 As String = "DCF施設コード"
        Public Const Field10 As String = "施設名"
        Public Const Field11 As String = "施設住所"
        Public Const Field12 As String = "参加者役割"
        Public Const Field13 As String = "性別 (航空券の場合必須)"
        Public Const Field14 As String = "航空搭乗者年齢 (年齢)(航空券の場合必須)"
        Public Const Field15 As String = "指定外申請理由 (依頼)"
        Public Const Field16 As String = "所属事業部 (担当MR)"
        Public Const Field17 As String = "所属エリア (担当MR)"
        Public Const Field18 As String = "所属営業所 (担当MR)"
        Public Const Field19 As String = "担当者(担当MR)名"
        Public Const Field20 As String = "担当者名(担当MR)(ローマ字)"
        Public Const Field21 As String = "Emailアドレス (担当MR)"
        Public Const Field22 As String = "携帯Emailアドレス (担当MR)"
        Public Const Field23 As String = "携帯電話番号 (担当MR)"
        Public Const Field24 As String = "オフィスの電話番号 (担当MR)"
        Public Const Field25 As String = "チケット送付先FS"
        Public Const Field26 As String = "チケット送付先 (その他)"
        Public Const Field27 As String = "Account Code"
        Public Const Field28 As String = "Cost Center"
        Public Const Field29 As String = "Internal Order"
        Public Const Field30 As String = "zetia Code"
        Public Const Field31 As String = "最終承認者（氏名）"
        Public Const Field32 As String = "最終承認日時"
        Public Const Field33 As String = "宿泊手配（希望する）"
        Public Const Field34 As String = "宿泊依頼内容"
        Public Const Field35 As String = "宿泊日（依頼）"
        Public Const Field36 As String = "泊数（依頼）"
        Public Const Field37 As String = "宿泊ホテル喫煙（依頼）"
        Public Const Field38 As String = "宿泊備考（依頼）"
        Public Const Field39 As String = "往路1：希望する（依頼）"
        Public Const Field40 As String = "往路1：依頼内容（依頼）"
        Public Const Field41 As String = "往路1：交通機関（依頼）"
        Public Const Field42 As String = "往路1：利用日（依頼）"
        Public Const Field43 As String = "往路1：出発地（依頼）"
        Public Const Field44 As String = "往路1：到着地（依頼）"
        Public Const Field45 As String = "往路1：出発時間（依頼）"
        Public Const Field46 As String = "往路1：到着時間（依頼）"
        Public Const Field47 As String = "往路1：列車名・便名（依頼）"
        Public Const Field48 As String = "往路1：座席区分（依頼）"
        Public Const Field49 As String = "往路1：座席希望（依頼）"
        Public Const Field50 As String = "往路2：希望する（依頼）"
        Public Const Field51 As String = "往路2：依頼内容（依頼）"
        Public Const Field52 As String = "往路2：交通機関（依頼）"
        Public Const Field53 As String = "往路2：利用日（依頼）"
        Public Const Field54 As String = "往路2：出発地（依頼）"
        Public Const Field55 As String = "往路2：到着地（依頼）"
        Public Const Field56 As String = "往路2：出発時間（依頼）"
        Public Const Field57 As String = "往路2：到着時間（依頼）"
        Public Const Field58 As String = "往路2：列車名・便名（依頼）"
        Public Const Field59 As String = "往路2：座席区分（依頼）"
        Public Const Field60 As String = "往路2：座席希望（依頼）"
        Public Const Field61 As String = "往路3：希望する（依頼）"
        Public Const Field62 As String = "往路3：依頼内容（依頼）"
        Public Const Field63 As String = "往路3：交通機関（依頼）"
        Public Const Field64 As String = "往路3：利用日（依頼）"
        Public Const Field65 As String = "往路3：出発地（依頼）"
        Public Const Field66 As String = "往路3：到着地（依頼）"
        Public Const Field67 As String = "往路3：出発時間（依頼）"
        Public Const Field68 As String = "往路3：到着時間（依頼）"
        Public Const Field69 As String = "往路3：列車名・便名（依頼）"
        Public Const Field70 As String = "往路3：座席区分（依頼）"
        Public Const Field71 As String = "往路3：座席希望（依頼）"
        Public Const Field72 As String = "往路4：希望する（依頼）"
        Public Const Field73 As String = "往路4：依頼内容（依頼）"
        Public Const Field74 As String = "往路4：交通機関（依頼）"
        Public Const Field75 As String = "往路4：利用日（依頼）"
        Public Const Field76 As String = "往路4：出発地（依頼）"
        Public Const Field77 As String = "往路4：到着地（依頼）"
        Public Const Field78 As String = "往路4：出発時間（依頼）"
        Public Const Field79 As String = "往路4：到着時間（依頼）"
        Public Const Field80 As String = "往路4：列車名・便名（依頼）"
        Public Const Field81 As String = "往路4：座席区分（依頼）"
        Public Const Field82 As String = "往路4：座席希望（依頼）"
        Public Const Field83 As String = "往路5：希望する（依頼）"
        Public Const Field84 As String = "往路5：依頼内容（依頼）"
        Public Const Field85 As String = "往路5：交通機関（依頼）"
        Public Const Field86 As String = "往路5：利用日（依頼）"
        Public Const Field87 As String = "往路5：出発地（依頼）"
        Public Const Field88 As String = "往路5：到着地（依頼）"
        Public Const Field89 As String = "往路5：出発時間（依頼）"
        Public Const Field90 As String = "往路5：到着時間（依頼）"
        Public Const Field91 As String = "往路5：列車名・便名（依頼）"
        Public Const Field92 As String = "往路5：座席区分（依頼）"
        Public Const Field93 As String = "往路5：座席希望（依頼）"
        Public Const Field94 As String = "復路1：希望する（依頼）"
        Public Const Field95 As String = "復路1：依頼内容（依頼）"
        Public Const Field96 As String = "復路1：交通機関（依頼）"
        Public Const Field97 As String = "復路1：利用日（依頼）"
        Public Const Field98 As String = "復路1：出発地（依頼）"
        Public Const Field99 As String = "復路1：到着地（依頼）"
        Public Const Field100 As String = "復路1：出発時間（依頼）"
        Public Const Field101 As String = "復路1：到着時間（依頼）"
        Public Const Field102 As String = "復路1：列車名・便名（依頼）"
        Public Const Field103 As String = "復路1：座席区分（依頼）"
        Public Const Field104 As String = "復路1：座席希望（依頼）"
        Public Const Field105 As String = "復路2：希望する（依頼）"
        Public Const Field106 As String = "復路2：依頼内容（依頼）"
        Public Const Field107 As String = "復路2：交通機関（依頼）"
        Public Const Field108 As String = "復路2：利用日（依頼）"
        Public Const Field109 As String = "復路2：出発地（依頼）"
        Public Const Field110 As String = "復路2：到着地（依頼）"
        Public Const Field111 As String = "復路2：出発時間（依頼）"
        Public Const Field112 As String = "復路2：到着時間（依頼）"
        Public Const Field113 As String = "復路2：列車名・便名（依頼）"
        Public Const Field114 As String = "復路2：座席区分（依頼）"
        Public Const Field115 As String = "復路2：座席希望（依頼）"
        Public Const Field116 As String = "復路3：希望する（依頼）"
        Public Const Field117 As String = "復路3：依頼内容（依頼）"
        Public Const Field118 As String = "復路3：交通機関（依頼）"
        Public Const Field119 As String = "復路3：利用日（依頼）"
        Public Const Field120 As String = "復路3：出発地（依頼）"
        Public Const Field121 As String = "復路3：到着地（依頼）"
        Public Const Field122 As String = "復路3：出発時間（依頼）"
        Public Const Field123 As String = "復路3：到着時間（依頼）"
        Public Const Field124 As String = "復路3：列車名・便名（依頼）"
        Public Const Field125 As String = "復路3：座席区分（依頼）"
        Public Const Field126 As String = "復路3：座席希望（依頼）"
        Public Const Field127 As String = "復路4：希望する（依頼）"
        Public Const Field128 As String = "復路4：依頼内容（依頼）"
        Public Const Field129 As String = "復路4：交通機関（依頼）"
        Public Const Field130 As String = "復路4：利用日（依頼）"
        Public Const Field131 As String = "復路4：出発地（依頼）"
        Public Const Field132 As String = "復路4：到着地（依頼）"
        Public Const Field133 As String = "復路4：出発時間（依頼）"
        Public Const Field134 As String = "復路4：到着時間（依頼）"
        Public Const Field135 As String = "復路4：列車名・便名（依頼）"
        Public Const Field136 As String = "復路4：座席区分（依頼）"
        Public Const Field137 As String = "復路4：座席希望（依頼）"
        Public Const Field138 As String = "復路5：希望する（依頼）"
        Public Const Field139 As String = "復路5：依頼内容（依頼）"
        Public Const Field140 As String = "復路5：交通機関（依頼）"
        Public Const Field141 As String = "復路5：利用日（依頼）"
        Public Const Field142 As String = "復路5：出発地（依頼）"
        Public Const Field143 As String = "復路5：到着地（依頼）"
        Public Const Field144 As String = "復路5：出発時間（依頼）"
        Public Const Field145 As String = "復路5：到着時間（依頼）"
        Public Const Field146 As String = "復路5：列車名・便名（依頼）"
        Public Const Field147 As String = "復路5：座席区分（依頼）"
        Public Const Field148 As String = "復路5：座席希望（依頼）"
        Public Const Field149 As String = "交通備考（依頼）"
        Public Const Field150 As String = "タクシーチケット（有・無）"
        Public Const Field151 As String = "行程１：利用日（依頼）"
        Public Const Field152 As String = "行程１：発地（依頼）"
        Public Const Field153 As String = "行程１：依頼金額（依頼）"
        Public Const Field154 As String = "行程２：利用日（依頼）"
        Public Const Field155 As String = "行程２：発地（依頼）"
        Public Const Field156 As String = "行程２：依頼金額（依頼）"
        Public Const Field157 As String = "行程3：利用日（依頼）"
        Public Const Field158 As String = "行程3：発地（依頼）"
        Public Const Field159 As String = "行程3：依頼金額（依頼）"
        Public Const Field160 As String = "行程4：利用日（依頼）"
        Public Const Field161 As String = "行程4：発地（依頼）"
        Public Const Field162 As String = "行程4：依頼金額（依頼）"
        Public Const Field163 As String = "行程5：利用日（依頼）"
        Public Const Field164 As String = "行程5：発地（依頼）"
        Public Const Field165 As String = "行程5：依頼金額（依頼）"
        Public Const Field166 As String = "行程6：利用日（依頼）"
        Public Const Field167 As String = "行程6：発地（依頼）"
        Public Const Field168 As String = "行程6：依頼金額（依頼）"
        Public Const Field169 As String = "行程7：利用日（依頼）"
        Public Const Field170 As String = "行程7：発地（依頼）"
        Public Const Field171 As String = "行程7：依頼金額（依頼）"
        Public Const Field172 As String = "行程8：利用日（依頼）"
        Public Const Field173 As String = "行程8：発地（依頼）"
        Public Const Field174 As String = "行程8：依頼金額（依頼）"
        Public Const Field175 As String = "行程9：利用日（依頼）"
        Public Const Field176 As String = "行程9：発地（依頼）"
        Public Const Field177 As String = "行程9：依頼金額 (依頼)"
        Public Const Field178 As String = "行程１0：利用日 (依頼)"
        Public Const Field179 As String = "行程１0：発地 (依頼)"
        Public Const Field180 As String = "行程１0：依頼金額 (依頼)"
        Public Const Field181 As String = "タクチケ備考 (依頼)"
        Public Const Field182 As String = "社員用往路臨席希望 (依頼)"
        Public Const Field183 As String = "社員用復路臨席希望 (依頼)"
        Public Const Field184 As String = "MR性別 (航空券の場合)"
        Public Const Field185 As String = "MR年齢 (航空券の場合)"
        Public Const Field186 As String = "社員用宿泊希望 (有・無)"
        Public Const Field187 As String = "社員用宿泊 (禁煙・喫煙)"
        Public Const Field188 As String = "社員用交通・宿泊備考"
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

            If fileData(COL_NO.Field4).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Field4 & "がセットされていません。")
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

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "交通宿泊手配依頼ファイル取込"
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
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct

        Try
            TBL_KOTSUHOTEL = SetInsData(fileData)
            strSQL = SQL.TBL_KOTSUHOTEL.Insert(TBL_KOTSUHOTEL)
            insCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

        Catch ex As Exception
            'ログテーブルに登録
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_KOTSUHOTEL", " SQL:" & strSQL)
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_KOTSUHOTEL.DataStruct

        Dim TBL_KOTSUHOTEL_Ins As New TableDef.TBL_KOTSUHOTEL.DataStruct

        TBL_KOTSUHOTEL_Ins.SALEFORCE_ID = fileData(COL_NO.Field1)
        TBL_KOTSUHOTEL_Ins.SANKASHA_ID = fileData(COL_NO.Field5)
        TBL_KOTSUHOTEL_Ins.KOUENKAI_NO = fileData(COL_NO.Field2)
        TBL_KOTSUHOTEL_Ins.REQ_STATUS_TEHAI = fileData(COL_NO.Field3)
        'TODO:ステータスの初期値要確認
        TBL_KOTSUHOTEL_Ins.ANS_STATUS_TEHAI = "1" 'AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NewTehai
        TBL_KOTSUHOTEL_Ins.TIME_STAMP_BYL = fileData(COL_NO.Field4)
        TBL_KOTSUHOTEL_Ins.TIME_STAMP_TOP = ""
        TBL_KOTSUHOTEL_Ins.DR_MPID = fileData(COL_NO.Field5)
        TBL_KOTSUHOTEL_Ins.DR_CD = fileData(COL_NO.Field6)
        TBL_KOTSUHOTEL_Ins.DR_NAME = fileData(COL_NO.Field7)
        TBL_KOTSUHOTEL_Ins.DR_KANA = fileData(COL_NO.Field8)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_CD = fileData(COL_NO.Field9)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_NAME = fileData(COL_NO.Field10)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_ADDRESS = fileData(COL_NO.Field11)
        TBL_KOTSUHOTEL_Ins.DR_YAKUWARI = fileData(COL_NO.Field12)
        TBL_KOTSUHOTEL_Ins.DR_SEX = fileData(COL_NO.Field13)
        TBL_KOTSUHOTEL_Ins.DR_AGE = fileData(COL_NO.Field14)
        TBL_KOTSUHOTEL_Ins.SHITEIGAI_RIYU = fileData(COL_NO.Field15)

        TBL_KOTSUHOTEL_Ins.DR_SANKA = ""
        TBL_KOTSUHOTEL_Ins.MR_BU = fileData(COL_NO.Field16)
        TBL_KOTSUHOTEL_Ins.MR_AREA = fileData(COL_NO.Field17)
        TBL_KOTSUHOTEL_Ins.MR_EIGYOSHO = fileData(COL_NO.Field18)
        TBL_KOTSUHOTEL_Ins.MR_NAME = fileData(COL_NO.Field19)
        TBL_KOTSUHOTEL_Ins.MR_ROMA = fileData(COL_NO.Field20)
        TBL_KOTSUHOTEL_Ins.MR_EMAIL_PC = fileData(COL_NO.Field21)
        TBL_KOTSUHOTEL_Ins.MR_EMAIL_KEITAI = fileData(COL_NO.Field22)
        TBL_KOTSUHOTEL_Ins.MR_KEITAI = fileData(COL_NO.Field23)
        TBL_KOTSUHOTEL_Ins.MR_TEL = fileData(COL_NO.Field24)
        TBL_KOTSUHOTEL_Ins.MR_SEND_SAKI_FS = fileData(COL_NO.Field25)
        TBL_KOTSUHOTEL_Ins.MR_SEND_SAKI_OTHER = fileData(COL_NO.Field26)
        TBL_KOTSUHOTEL_Ins.ACCOUNT_CD = fileData(COL_NO.Field27)
        TBL_KOTSUHOTEL_Ins.COST_CENTER = fileData(COL_NO.Field28)
        TBL_KOTSUHOTEL_Ins.INTERNAL_ORDER = fileData(COL_NO.Field29)
        TBL_KOTSUHOTEL_Ins.ZETIA_CD = fileData(COL_NO.Field30)
        TBL_KOTSUHOTEL_Ins.SHONIN_NAME = fileData(COL_NO.Field31)
        TBL_KOTSUHOTEL_Ins.SHONIN_DATE = fileData(COL_NO.Field32)
        TBL_KOTSUHOTEL_Ins.TEHAI_HOTEL = fileData(COL_NO.Field33)
        TBL_KOTSUHOTEL_Ins.HOTEL_IRAINAIYOU = fileData(COL_NO.Field34)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_DATE = fileData(COL_NO.Field35)
        TBL_KOTSUHOTEL_Ins.REQ_HAKUSU = fileData(COL_NO.Field36)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_SMOKING = fileData(COL_NO.Field37)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_NOTE = fileData(COL_NO.Field38)
        
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_1 = fileData(COL_NO.Field39)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_1 = fileData(COL_NO.Field40)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_1 = fileData(COL_NO.Field41)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_1 = fileData(COL_NO.Field42)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_1 = fileData(COL_NO.Field43)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_1 = fileData(COL_NO.Field44)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_1 = fileData(COL_NO.Field45)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_1 = fileData(COL_NO.Field46)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_1 = fileData(COL_NO.Field47)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_1 = fileData(COL_NO.Field48)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU1 = fileData(COL_NO.Field49)

        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_2 = fileData(COL_NO.Field50)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_2 = fileData(COL_NO.Field51)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_2 = fileData(COL_NO.Field52)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_2 = fileData(COL_NO.Field53)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_2 = fileData(COL_NO.Field54)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_2 = fileData(COL_NO.Field55)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_2 = fileData(COL_NO.Field56)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_2 = fileData(COL_NO.Field57)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_2 = fileData(COL_NO.Field58)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_2 = fileData(COL_NO.Field59)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU2 = fileData(COL_NO.Field60)

        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_3 = fileData(COL_NO.Field61)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_3 = fileData(COL_NO.Field62)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_3 = fileData(COL_NO.Field63)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_3 = fileData(COL_NO.Field64)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_3 = fileData(COL_NO.Field65)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_3 = fileData(COL_NO.Field66)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_3 = fileData(COL_NO.Field67)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_3 = fileData(COL_NO.Field68)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_3 = fileData(COL_NO.Field69)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_3 = fileData(COL_NO.Field70)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU3 = fileData(COL_NO.Field71)

        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_4 = fileData(COL_NO.Field72)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_4 = fileData(COL_NO.Field73)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_4 = fileData(COL_NO.Field74)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_4 = fileData(COL_NO.Field75)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_4 = fileData(COL_NO.Field76)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_4 = fileData(COL_NO.Field77)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_4 = fileData(COL_NO.Field78)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_4 = fileData(COL_NO.Field79)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_4 = fileData(COL_NO.Field80)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_4 = fileData(COL_NO.Field81)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU4 = fileData(COL_NO.Field82)

        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_5 = fileData(COL_NO.Field83)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_5 = fileData(COL_NO.Field84)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_5 = fileData(COL_NO.Field85)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_5 = fileData(COL_NO.Field86)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_5 = fileData(COL_NO.Field87)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_5 = fileData(COL_NO.Field88)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_5 = fileData(COL_NO.Field89)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_5 = fileData(COL_NO.Field90)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_5 = fileData(COL_NO.Field91)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_5 = fileData(COL_NO.Field92)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU5 = fileData(COL_NO.Field93)

        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_1 = fileData(COL_NO.Field94)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_1 = fileData(COL_NO.Field95)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_1 = fileData(COL_NO.Field96)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_1 = fileData(COL_NO.Field97)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_1 = fileData(COL_NO.Field98)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_1 = fileData(COL_NO.Field99)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_1 = fileData(COL_NO.Field100)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_1 = fileData(COL_NO.Field101)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_1 = fileData(COL_NO.Field102)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_1 = fileData(COL_NO.Field103)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU1 = fileData(COL_NO.Field104)

        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_2 = fileData(COL_NO.Field105)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_2 = fileData(COL_NO.Field106)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_2 = fileData(COL_NO.Field107)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_2 = fileData(COL_NO.Field108)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_2 = fileData(COL_NO.Field109)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_2 = fileData(COL_NO.Field110)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_2 = fileData(COL_NO.Field111)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_2 = fileData(COL_NO.Field112)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_2 = fileData(COL_NO.Field113)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_2 = fileData(COL_NO.Field114)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU2 = fileData(COL_NO.Field115)

        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_3 = fileData(COL_NO.Field116)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_3 = fileData(COL_NO.Field117)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_3 = fileData(COL_NO.Field118)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_3 = fileData(COL_NO.Field119)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_3 = fileData(COL_NO.Field120)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_3 = fileData(COL_NO.Field121)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_3 = fileData(COL_NO.Field122)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_3 = fileData(COL_NO.Field123)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_3 = fileData(COL_NO.Field124)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_3 = fileData(COL_NO.Field125)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU3 = fileData(COL_NO.Field126)

        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_4 = fileData(COL_NO.Field127)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_4 = fileData(COL_NO.Field128)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_4 = fileData(COL_NO.Field129)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_4 = fileData(COL_NO.Field130)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_4 = fileData(COL_NO.Field131)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_4 = fileData(COL_NO.Field132)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_4 = fileData(COL_NO.Field133)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_4 = fileData(COL_NO.Field134)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_4 = fileData(COL_NO.Field135)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_4 = fileData(COL_NO.Field136)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU4 = fileData(COL_NO.Field137)

        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_5 = fileData(COL_NO.Field138)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_5 = fileData(COL_NO.Field139)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_5 = fileData(COL_NO.Field140)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_5 = fileData(COL_NO.Field141)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_5 = fileData(COL_NO.Field142)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_5 = fileData(COL_NO.Field143)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_5 = fileData(COL_NO.Field144)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_5 = fileData(COL_NO.Field145)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_5 = fileData(COL_NO.Field146)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_5 = fileData(COL_NO.Field147)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU5 = fileData(COL_NO.Field148)
        TBL_KOTSUHOTEL_Ins.REQ_KOTSU_BIKO = fileData(COL_NO.Field149)

        TBL_KOTSUHOTEL_Ins.TEHAI_TAXI = fileData(COL_NO.Field150)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_1 = fileData(COL_NO.Field151)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_1 = fileData(COL_NO.Field152)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_1 = fileData(COL_NO.Field153)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_2 = fileData(COL_NO.Field154)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_2 = fileData(COL_NO.Field155)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_2 = fileData(COL_NO.Field156)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_3 = fileData(COL_NO.Field157)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_3 = fileData(COL_NO.Field158)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_3 = fileData(COL_NO.Field159)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_4 = fileData(COL_NO.Field160)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_4 = fileData(COL_NO.Field161)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_4 = fileData(COL_NO.Field162)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_5 = fileData(COL_NO.Field163)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_5 = fileData(COL_NO.Field164)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_5 = fileData(COL_NO.Field165)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_6 = fileData(COL_NO.Field166)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_6 = fileData(COL_NO.Field167)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_6 = fileData(COL_NO.Field168)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_7 = fileData(COL_NO.Field169)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_7 = fileData(COL_NO.Field170)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_7 = fileData(COL_NO.Field171)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_8 = fileData(COL_NO.Field172)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_8 = fileData(COL_NO.Field173)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_8 = fileData(COL_NO.Field174)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_9 = fileData(COL_NO.Field175)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_9 = fileData(COL_NO.Field176)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_9 = fileData(COL_NO.Field177)

        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_10 = fileData(COL_NO.Field178)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_10 = fileData(COL_NO.Field179)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_10 = fileData(COL_NO.Field180)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_NOTE = fileData(COL_NO.Field181)
        
        TBL_KOTSUHOTEL_Ins.REQ_MR_O_TEHAI = fileData(COL_NO.Field182)
        TBL_KOTSUHOTEL_Ins.REQ_MR_F_TEHAI = fileData(COL_NO.Field183)
        TBL_KOTSUHOTEL_Ins.MR_SEX = fileData(COL_NO.Field184)
        TBL_KOTSUHOTEL_Ins.MR_AGE = fileData(COL_NO.Field185)
        TBL_KOTSUHOTEL_Ins.REQ_MR_TEHAI_HOTEL = fileData(COL_NO.Field186)
        TBL_KOTSUHOTEL_Ins.REQ_MR_HOTEL_SMOKING = fileData(COL_NO.Field187)
        TBL_KOTSUHOTEL_Ins.REQ_MR_HOTEL_NOTE = fileData(COL_NO.Field188)
        
        TBL_KOTSUHOTEL_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi

        TBL_KOTSUHOTEL_Ins.INPUT_USER = pbatchID
        TBL_KOTSUHOTEL_Ins.UPDATE_USER = pbatchID
        TBL_KOTSUHOTEL_Ins.SEND_DATE = ""

        '同一キーのデータを検索
        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct = GetData(fileData(COL_NO.Field5), fileData(COL_NO.Field2))

        If Not TBL_KOTSUHOTEL Is Nothing Then
            '該当データがあるとき
            Dim idx As Integer = GetLastData(TBL_KOTSUHOTEL)

            TBL_KOTSUHOTEL_Ins.ANS_STATUS_HOTEL = TBL_KOTSUHOTEL(idx).ANS_STATUS_HOTEL
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NAME = TBL_KOTSUHOTEL(idx).ANS_HOTEL_NAME
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_ADDRESS = TBL_KOTSUHOTEL(idx).ANS_HOTEL_ADDRESS
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_TEL = TBL_KOTSUHOTEL(idx).ANS_HOTEL_TEL
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_DATE = TBL_KOTSUHOTEL(idx).ANS_HOTEL_DATE
            TBL_KOTSUHOTEL_Ins.ANS_HAKUSU = TBL_KOTSUHOTEL(idx).ANS_HAKUSU
            TBL_KOTSUHOTEL_Ins.ANS_CHECKIN_TIME = TBL_KOTSUHOTEL(idx).ANS_CHECKIN_TIME
            TBL_KOTSUHOTEL_Ins.ANS_CHECKOUT_TIME = TBL_KOTSUHOTEL(idx).ANS_CHECKOUT_TIME
            TBL_KOTSUHOTEL_Ins.ANS_ROOM_TYPE = TBL_KOTSUHOTEL(idx).ANS_ROOM_TYPE
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_SMOKING = TBL_KOTSUHOTEL(idx).ANS_HOTEL_SMOKING
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NOTE = TBL_KOTSUHOTEL(idx).ANS_HOTEL_NOTE

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_1 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_1
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_1 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_1
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_1 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_1
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_1 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_1
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_1 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_1
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_1 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_1
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_1 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_1
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_1 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_1
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU1 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU1

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_2 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_2
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_2 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_2
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_2 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_2
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_2 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_2
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_2 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_2
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_2 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_2
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_2 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_2
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_2 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_2
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU2 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU2

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_3 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_3
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_3 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_3
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_3 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_3
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_3 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_3
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_3 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_3
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_3 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_3
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_3 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_3
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_3 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_3
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU3 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU3

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_4 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_4
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_4 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_4
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_4 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_4
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_4 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_4
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_4 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_4
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_4 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_4
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_4 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_4
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_4 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_4
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU4 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU4

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_5 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_5
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_5 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_5
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_5 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_5
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_5 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_5
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_5 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_5
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_5 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_5
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_5 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_5
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_5 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_5
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU5 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU5

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_1 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_1
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_1 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_1
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_1 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_1
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_1 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_1
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_1 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_1
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_1 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_1
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_1 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_1
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_1 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_1
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU1 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU1

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_2 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_2
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_2 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_2
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_2 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_2
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_2 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_2
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_2 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_2
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_2 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_2
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_2 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_2
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_2 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_2
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU2 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU2

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_3 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_3
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_3 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_3
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_3 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_3
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_3 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_3
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_3 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_3
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_3 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_3
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_3 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_3
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_3 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_3
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU3 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU3

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_4 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_4
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_4 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_4
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_4 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_4
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_4 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_4
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_4 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_4
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_4 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_4
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_4 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_4
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_4 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_4
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU4 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU4

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_5 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_5
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_5 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_5
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_5 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_5
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_5 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_5
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_5 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_5
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_5 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_5
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_5 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_5
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_5 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_5
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU5 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU5

            TBL_KOTSUHOTEL_Ins.ANS_KOTSU_BIKO = TBL_KOTSUHOTEL(idx).ANS_KOTSU_BIKO

            TBL_KOTSUHOTEL_Ins.ANS_RAIL_FARE = TBL_KOTSUHOTEL(idx).ANS_RAIL_FARE
            TBL_KOTSUHOTEL_Ins.ANS_RAIL_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_RAIL_CANCELLATION
            TBL_KOTSUHOTEL_Ins.ANS_OTHER_FARE = TBL_KOTSUHOTEL(idx).ANS_OTHER_FARE
            TBL_KOTSUHOTEL_Ins.ANS_OTHER_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_OTHER_CANCELLATION
            TBL_KOTSUHOTEL_Ins.ANS_AIR_FARE = TBL_KOTSUHOTEL(idx).ANS_AIR_FARE
            TBL_KOTSUHOTEL_Ins.ANS_AIR_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_AIR_CANCELLATION

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_1

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_2

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_3

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_4

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_5

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_6

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_7

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_8

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_9

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_10

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_11

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_12

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_13

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_14

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_15

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_16

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_17

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_18

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_19

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_20

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NOTE = TBL_KOTSUHOTEL(idx).ANS_TAXI_NOTE

            TBL_KOTSUHOTEL_Ins.ANS_MR_O_TEHAI = TBL_KOTSUHOTEL(idx).ANS_MR_O_TEHAI
            TBL_KOTSUHOTEL_Ins.ANS_MR_F_TEHAI = TBL_KOTSUHOTEL(idx).ANS_MR_F_TEHAI
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NAME = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_NAME
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_ADDRESS = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_ADDRESS
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_TEL = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_TEL
            TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKIN_TIME = TBL_KOTSUHOTEL(idx).ANS_MR_CHECKIN_TIME
            TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKOUT_TIME = TBL_KOTSUHOTEL(idx).ANS_MR_CHECKOUT_TIME
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_SMOKING = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_SMOKING
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NOTE = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_NOTE
            TBL_KOTSUHOTEL_Ins.ANS_MR_KOTSUHI = TBL_KOTSUHOTEL(idx).ANS_MR_KOTSUHI
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTELHI = TBL_KOTSUHOTEL(idx).ANS_MR_HOTELHI

            TBL_KOTSUHOTEL_Ins.TTANTO_ID = TBL_KOTSUHOTEL(idx).TTANTO_ID
        End If

        Return TBL_KOTSUHOTEL_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strSankashaId As String, ByVal strKouenkaiNo As String) As TableDef.TBL_KOTSUHOTEL.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOTSUHOTEL(wCnt) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wFlag As Boolean = False

        'TODO:SALEFORCE_IDも検索時のキーとして必要な場合はSQLを変更する。
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID(strKouenkaiNo, strSankashaId)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KOTSUHOTEL(wCnt)

            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_KOTSUHOTEL
        Else
            Return Nothing
        End If

    End Function

    '最新データがセットされている配列の添え字を取得する
    Private Function GetLastData(ByVal TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Integer
        Dim rowNo As Integer = 0
        Dim wCnt As Integer = 0

        For Each record As TableDef.TBL_KOTSUHOTEL.DataStruct In TBL_KOTSUHOTEL
            rowNo = wCnt
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
