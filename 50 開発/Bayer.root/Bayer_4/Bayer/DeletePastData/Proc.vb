Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "DeletePastData" 'バッチID
    Private Joken As New TableDef.Joken.DataStruct
    Private CNT_TBL_KOUENKAI As Integer = 0
    Private CNT_TBL_KAIJO As Integer = 0
    Private CNT_TBL_KOTSUHOTEL As Integer = 0
    Private CNT_TBL_SANKA As Integer = 0
    Private CNT_TBL_TAXITICKET_HAKKO = 0
    Private CNT_TBL_SEIKYU = 0
    Private CNT_TBL_SHOUNIN = 0
    Private CNT_TBL_KOUENKAI_DEL As Integer = 0
    Private CNT_TBL_KAIJO_DEL As Integer = 0
    Private CNT_TBL_KOTSUHOTEL_DEL As Integer = 0
    Private CNT_TBL_SANKA_DEL As Integer = 0
    Private CNT_TBL_TAXITICKET_HAKKO_DEL = 0
    Private CNT_TBL_SEIKYU_DEL = 0
    Private CNT_TBL_SHOUNIN_DEL = 0

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "過去データの移行を開始しました。")

        '削除対象日付を取得
        Dim wDate As String = GetMS_CODE()
        If wDate = "" Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "コードマスターに削除対象年数が登録されていません")
            Exit Sub
        End If

        ''過去データ用DBマスターデータ削除
        'If Not DelPastMaster() Then
        '    InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "過去データ用DBマスターデータ削除に失敗しました")
        '    Exit Sub
        'End If

        ''マスターデータ移行
        'If Not InsertPastMaster() Then
        '    InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "マスターデータ移行に失敗しました")
        '    Exit Sub
        'End If

        '削除対象会合番号抽出
        Dim wKOUENKAI_NO() As String = GetData(wDate)
        If wKOUENKAI_NO Is Nothing Then
            '対象データなし
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象データがありません。")
        Else
            '本番データ用DBから過去データ用DBへデータ移行
            Call MigrationData(wKOUENKAI_NO)
        End If

        '本番データインデックス再構成
        Try
            Dim strSQL As String = ""
            strSQL = SQL.ALTER_INDEX.AlterIndex1
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            strSQL = SQL.ALTER_INDEX.AlterIndex2
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            strSQL = SQL.ALTER_INDEX.AlterIndex3
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            strSQL = SQL.ALTER_INDEX.AlterIndex4
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            strSQL = SQL.ALTER_INDEX.AlterIndex5
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            strSQL = SQL.ALTER_INDEX.AlterIndex6
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            strSQL = SQL.ALTER_INDEX.AlterIndex7
            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        Catch ex As Exception
            '再構成失敗
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番データのインデックス再構成に失敗しました")
            Exit Sub
        End Try

        '過去データインデックス再構成
        Try
            Dim strSQL As String = ""
            strSQL = SQL.ALTER_INDEX.AlterIndex1
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            strSQL = SQL.ALTER_INDEX.AlterIndex2
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            strSQL = SQL.ALTER_INDEX.AlterIndex3
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            strSQL = SQL.ALTER_INDEX.AlterIndex4
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            strSQL = SQL.ALTER_INDEX.AlterIndex5
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            strSQL = SQL.ALTER_INDEX.AlterIndex6
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            strSQL = SQL.ALTER_INDEX.AlterIndex7
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        Catch ex As Exception
            '再構成失敗
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "過去データのインデックス再構成に失敗しました")
            Exit Sub
        End Try

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "過去データの移行が正常に終了しました")
    End Sub

    '削除対象日付取得
    Private Function GetMS_CODE() As String
        Dim wDate As String = ""

        Dim strSQL As String = SQL.MS_CODE.byCODE_DATA_ID(AppConst.MS_CODE.DEL_NENSU, "01")
        Dim MS_CODE As New TableDef.MS_CODE.DataStruct
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        If RsData.Read() Then
            MS_CODE = AppModule.SetRsData(RsData, MS_CODE)
            wDate = CmnModule.Format_DateToString(Now.AddYears(Integer.Parse(MS_CODE.DISP_VALUE) * -1), CmnModule.DateFormatType.YYYYMMDD)
        End If
        RsData.Close()

        Return wDate
    End Function

    '削除対象会合番号抽出
    Private Function GetData(ByVal wDate As String) As String()
        Dim wCnt As Integer = 0
        Dim wKOUENKAI_NO() As String = Nothing
        Dim wTBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
        Dim wFlag As Boolean = False

        Joken.FROM_DATE = wDate
        Dim strSQL As String = SQL.TBL_KOUENKAI.Search_DelData(Joken)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve wTBL_KOUENKAI(wCnt)
            ReDim Preserve wKOUENKAI_NO(wCnt)
            wTBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, wTBL_KOUENKAI(wCnt))
            wKOUENKAI_NO(wCnt) = wTBL_KOUENKAI(wCnt).KOUENKAI_NO
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return wKOUENKAI_NO
        Else
            Return Nothing
        End If

    End Function

    '本番データ用DB→過去データ用DBへデータ移行
    Private Function MigrationData(ByVal wKOUENKAI_NO() As String) As Boolean
        Dim i As Integer = 0

        For i = LBound(wKOUENKAI_NO) To UBound(wKOUENKAI_NO)
            '本番データ用DBの削除対象データを過去データ用DBへInsert
            If Not InsertPastData(wKOUENKAI_NO(i)) Then
                Return False
            End If

            '本番データ用DBから削除対象データを削除
            If Not DelPastData(wKOUENKAI_NO(i)) Then
                Return False
            End If
        Next

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "基本情報データを" & CmnModule.EditComma(CNT_TBL_KOUENKAI.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBから基本情報データを" & CmnModule.EditComma(CNT_TBL_KOUENKAI_DEL.ToString) & "件削除しました")

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "会場データを" & CmnModule.EditComma(CNT_TBL_KAIJO.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBから会場データを" & CmnModule.EditComma(CNT_TBL_KAIJO_DEL.ToString) & "件削除しました")

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "交通ホテル手配データを" & CmnModule.EditComma(CNT_TBL_KOTSUHOTEL.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBから交通ホテル手配データを" & CmnModule.EditComma(CNT_TBL_KOTSUHOTEL_DEL.ToString) & "件削除しました")

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "参加者データを" & CmnModule.EditComma(CNT_TBL_SANKA.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBから参加者データを" & CmnModule.EditComma(CNT_TBL_SANKA_DEL.ToString) & "件削除しました")

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "請求データを" & CmnModule.EditComma(CNT_TBL_SEIKYU.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBから請求データを" & CmnModule.EditComma(CNT_TBL_SEIKYU_DEL.ToString) & "件削除しました")

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "タクチケ発行データを" & CmnModule.EditComma(CNT_TBL_TAXITICKET_HAKKO.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBからタクチケ発行データを" & CmnModule.EditComma(CNT_TBL_TAXITICKET_HAKKO_DEL.ToString) & "件削除しました")

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "請求承認データを" & CmnModule.EditComma(CNT_TBL_SHOUNIN.ToString) & "件移行しました")
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBから請求承認データを" & CmnModule.EditComma(CNT_TBL_SHOUNIN_DEL.ToString) & "件削除しました")

        Return True
    End Function

    '本番データ用DBの削除対象データを過去データ用DBへInsert
    Private Function InsertPastData(ByVal KOUENKAI_NO As String) As Boolean
        Dim strSQL As String = ""
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = True
        Dim orgDbName As String = Configuration.ConfigurationManager.AppSettings("OrgDbName")
        Dim pastDbName As String = Configuration.ConfigurationManager.AppSettings("PastDbName")

        MyBase.BeginTransactionPast()

        '基本情報
        '過去データ用DBの基本情報テーブルの該当会合番号のデータを削除
        Try
            strSQL = SQL.TBL_KOUENKAI.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        Catch ex As Exception

        End Try

        '本番用DBの基本情報テーブルの該当会合番号データ取得
        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(KOUENKAI_NO)
        Dim wTBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct = Nothing
        Dim RsKouenkai As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsKouenkai.Read
            ReDim Preserve wTBL_KOUENKAI(wCnt)
            wTBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsKouenkai, wTBL_KOUENKAI(wCnt))
            Try
                '1レコードずつ過去データ用DBの基本情報テーブルにInsert
                strSQL = SQL.TBL_KOUENKAI.Insert(wTBL_KOUENKAI(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "基本情報データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
                Exit While
            End Try
            wCnt += 1
        End While
        RsKouenkai.Close()

        CNT_TBL_KOUENKAI += wCnt
        If Not wFlag Then Return False

        ''会場手配
        ''過去データ用DBの会場手配テーブルの該当会合番号のデータを削除
        'Try
        '    strSQL = SQL.TBL_KAIJO.DeleteByKOUENKAI_NO(KOUENKAI_NO)
        '    CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        'Catch ex As Exception

        'End Try
        ''本番用DBの会場手配テーブルの該当会合番号データ取得
        'wCnt = 0
        'strSQL = SQL.TBL_KAIJO.byKOUENKAI_NO(KOUENKAI_NO)
        'Dim wTBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct = Nothing
        'Dim RsKaijo As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        'While RsKaijo.Read
        '    ReDim Preserve wTBL_KAIJO(wCnt)
        '    wTBL_KAIJO(wCnt) = AppModule.SetRsData(RsKaijo, wTBL_KAIJO(wCnt))
        '    Try
        '        '1レコードずつ過去データ用DBの会場手配テーブルにInsert
        '        strSQL = SQL.TBL_KAIJO.Insert(wTBL_KAIJO(wCnt))
        '        CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

        '    Catch ex As Exception
        '        wFlag = False
        '        MyBase.RollbackPast()
        '        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "会場手配データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
        '        Exit While
        '    End Try
        '    wCnt += 1
        'End While
        'RsKaijo.Close()
        'CNT_TBL_KAIJO += wCnt
        'If Not wFlag Then Return False

        ''交通ホテル手配
        ''過去データ用DBの交通ホテル手配テーブルの該当会合番号のデータを削除
        'Try
        '    strSQL = SQL.TBL_KOTSUHOTEL.DeleteByKOUENKAI_NO(KOUENKAI_NO)
        '    CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        'Catch ex As Exception

        'End Try
        ''本番用DBの交通ホテル手配テーブルの該当会合番号データ取得
        'wCnt = 0
        'strSQL = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO(KOUENKAI_NO)
        'Dim wTBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing
        'Dim RsKotsuHotel As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        'While RsKotsuHotel.Read
        '    ReDim Preserve wTBL_KOTSUHOTEL(wCnt)
        '    wTBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsKotsuHotel, wTBL_KOTSUHOTEL(wCnt))
        '    Try
        '        '1レコードずつ過去データ用DBの交通ホテル手配テーブルにInsert
        '        strSQL = SQL.TBL_KOTSUHOTEL.Insert(wTBL_KOTSUHOTEL(wCnt))
        '        CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

        '    Catch ex As Exception
        '        wFlag = False
        '        MyBase.RollbackPast()
        '        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "交通ホテル手配データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
        '        Exit While
        '    End Try
        '    wCnt += 1
        'End While
        'RsKotsuHotel.Close()
        'CNT_TBL_KOTSUHOTEL += wCnt
        'If Not wFlag Then Return False

        ''参加者
        ''過去データ用DBの参加者テーブルの該当会合番号のデータを削除
        'Try
        '    strSQL = SQL.TBL_SANKA.DeleteByKOUENKAI_NO(KOUENKAI_NO)
        '    CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        'Catch ex As Exception

        'End Try
        ''本番用DBの参加者テーブルの該当会合番号データ取得
        'wCnt = 0
        'strSQL = SQL.TBL_SANKA.byKOUENKAI_NO(KOUENKAI_NO)
        'Dim wTBL_SANKA() As TableDef.TBL_SANKA.DataStruct = Nothing
        'Dim RsSankasha As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        'While RsSankasha.Read
        '    ReDim Preserve wTBL_SANKA(wCnt)
        '    wTBL_SANKA(wCnt) = AppModule.SetRsData(RsSankasha, wTBL_SANKA(wCnt))
        '    Try
        '        '1レコードずつ過去データ用DBの参加者テーブルにInsert
        '        strSQL = SQL.TBL_SANKA.Insert(wTBL_SANKA(wCnt))
        '        CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

        '    Catch ex As Exception
        '        wFlag = False
        '        MyBase.RollbackPast()
        '        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "参加者データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
        '        Exit While
        '    End Try
        '    wCnt += 1
        'End While
        'RsSankasha.Close()
        'CNT_TBL_SANKA += wCnt
        'If Not wFlag Then Return False

        ''請求
        ''過去データ用DBの参加者テーブルの該当会合番号のデータを削除
        'Try
        '    strSQL = SQL.TBL_SEIKYU.DeleteByKOUENKAI_NO(KOUENKAI_NO)
        '    CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        'Catch ex As Exception

        'End Try
        ''本番用DBの請求テーブルの該当会合番号データ取得
        'wCnt = 0
        'strSQL = SQL.TBL_SEIKYU.byKOUENKAI_NO(KOUENKAI_NO)
        'Dim wTBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct = Nothing
        'Dim RsSeikyu As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        'While RsSeikyu.Read
        '    ReDim Preserve wTBL_SEIKYU(wCnt)
        '    wTBL_SEIKYU(wCnt) = AppModule.SetRsData(RsSeikyu, wTBL_SEIKYU(wCnt))
        '    Try
        '        '1レコードずつ過去データ用DBの請求テーブルにInsert
        '        strSQL = SQL.TBL_SEIKYU.Insert(wTBL_SEIKYU(wCnt))
        '        CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

        '    Catch ex As Exception
        '        wFlag = False
        '        MyBase.RollbackPast()
        '        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "請求データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
        '        Exit While
        '    End Try
        '    wCnt += 1
        'End While
        'RsSeikyu.Close()
        'CNT_TBL_SEIKYU += wCnt
        'If Not wFlag Then Return False

        'タクチケ発行
        '過去データ用DBのタクチケ発行テーブルの該当会合番号のデータを削除
        Try
            strSQL = SQL.TBL_TAXITICKET_HAKKO.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        Catch ex As Exception

        End Try
        '本番用DBのタクチケ発行テーブルの該当会合番号データ取得
        wCnt = 0
        strSQL = SQL.TBL_TAXITICKET_HAKKO.byKOUENKAI_NO(KOUENKAI_NO)
        Dim wTBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct = Nothing
        Dim RsTaxiticketHakko As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsTaxiticketHakko.Read
            ReDim Preserve wTBL_TAXITICKET_HAKKO(wCnt)
            wTBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsTaxiticketHakko, wTBL_TAXITICKET_HAKKO(wCnt))
            Try
                '1レコードずつ過去データ用DBのタクチケ発行テーブルにInsert
                strSQL = SQL.TBL_TAXITICKET_HAKKO.Insert(wTBL_TAXITICKET_HAKKO(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "タクチケ発行データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
                Exit While
            End Try
            wCnt += 1
        End While
        RsTaxiticketHakko.Close()
        CNT_TBL_TAXITICKET_HAKKO += wCnt
        If Not wFlag Then Return False

        ''請求承認
        ''過去データ用DBのタクチケ発行テーブルの該当会合番号のデータを削除
        'Try
        '    strSQL = SQL.TBL_SHOUNIN.DeleteByKOUENKAI_NO(KOUENKAI_NO)
        '    CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)
        'Catch ex As Exception

        'End Try
        ''本番用DBの請求承認テーブルの該当会合番号データ取得
        'wCnt = 0
        'strSQL = SQL.TBL_SHOUNIN.byKOUENKAI_NO(KOUENKAI_NO)
        'Dim wTBL_SHOUNIN() As TableDef.TBL_SHOUNIN.DataStruct = Nothing
        'Dim RsShounin As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        'While RsShounin.Read
        '    ReDim Preserve wTBL_SHOUNIN(wCnt)
        '    wTBL_SHOUNIN(wCnt) = AppModule.SetRsData(RsShounin, wTBL_SHOUNIN(wCnt))
        '    Try
        '        '1レコードずつ過去データ用DBの請求承認テーブルにInsert
        '        strSQL = SQL.TBL_SHOUNIN.Insert(wTBL_SHOUNIN(wCnt))
        '        CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

        '    Catch ex As Exception
        '        wFlag = False
        '        MyBase.RollbackPast()
        '        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "請求承認データの移行に失敗しました。(会合番号：" & KOUENKAI_NO & ")")
        '        Exit While
        '    End Try
        '    wCnt += 1
        'End While
        'RsShounin.Close()
        'CNT_TBL_SHOUNIN += wCnt
        'If Not wFlag Then Return False

        MyBase.CommitPast()
        Return True
    End Function

    '過去データ削除
    Private Function DelPastData(ByVal KOUENKAI_NO As String) As Boolean
        Dim strSQL As String = ""
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = True

        If MyBase.DbTransaction Is Nothing Then MyBase.BeginTransaction()
        Try
            '本番用DBの基本情報テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_KOUENKAI.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_KOUENKAI_DEL += wCnt

            '本番用DBの会場テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_KAIJO.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_KAIJO_DEL += wCnt

            '本番用DBの交通ホテル手配テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_KOTSUHOTEL.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_KOTSUHOTEL_DEL += wCnt

            '本番用DBの参加者テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_SANKA.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_SANKA_DEL += wCnt

            '本番用DBの請求テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_SEIKYU.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_SEIKYU_DEL += wCnt

            '本番用DBのタクチケ発行テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_TAXITICKET_HAKKO.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_TAXITICKET_HAKKO_DEL += wCnt

            '本番用DBの請求承認テーブルから該当会合番号データ削除
            strSQL = SQL.TBL_SHOUNIN.DeleteByKOUENKAI_NO(KOUENKAI_NO)
            wCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            CNT_TBL_SHOUNIN_DEL += wCnt

        Catch ex As Exception
            MyBase.Rollback()
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "本番用DBからの過去データ削除に失敗しました")
            Return False
        End Try

        MyBase.Commit()
        Return True
    End Function

    '過去データ用DBマスターデータ削除
    Private Function DelPastMaster() As Boolean

        Try
            MyBase.BeginTransactionPast()
            CmnDbBatch.Execute("DELETE FROM MS_AREA", MyBase.DbConnectionPast, MyBase.DbTransactionPast)
            CmnDbBatch.Execute("DELETE FROM MS_BU", MyBase.DbConnectionPast, MyBase.DbTransactionPast)
            CmnDbBatch.Execute("DELETE FROM MS_CODE", MyBase.DbConnectionPast, MyBase.DbTransactionPast)
            CmnDbBatch.Execute("DELETE FROM MS_SAPKANRI", MyBase.DbConnectionPast, MyBase.DbTransactionPast)
            CmnDbBatch.Execute("DELETE FROM MS_USER", MyBase.DbConnectionPast, MyBase.DbTransactionPast)
            CmnDbBatch.Execute("DELETE FROM MS_ZEI", MyBase.DbConnectionPast, MyBase.DbTransactionPast)
            MyBase.CommitPast()
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "過去データ用DBからのマスターデータ削除が成功しました")
        Catch ex As Exception
            MyBase.RollbackPast()
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "過去データ用DBからのマスターデータ削除に失敗しました")
            Return False
        End Try

        Return True
    End Function

    'マスターデータ移行
    Private Function InsertPastMaster() As Boolean
        Dim strSQL As String = ""
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = True

        MyBase.BeginTransactionPast()

        'エリアマスター
        '本番用DBのエリアマスターの全データ取得
        strSQL = SQL.MS_AREA.AllData
        Dim MS_AREA() As TableDef.MS_AREA.DataStruct = Nothing
        Dim RsArea As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsArea.Read
            ReDim Preserve MS_AREA(wCnt)
            MS_AREA(wCnt) = AppModule.SetRsData(RsArea, MS_AREA(wCnt))
            Try
                '1レコードずつ過去データ用DBのエリアマスターにInsert
                strSQL = SQL.MS_AREA.Insert(MS_AREA(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "エリアマスターの移行に失敗しました。")
            End Try
            wCnt += 1
        End While
        RsArea.Close()
        If Not wFlag Then Return False
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "エリアマスターを" & CmnModule.EditComma(wCnt.ToString) & "件移行しました")

        'BUマスター
        '本番用DBのBUマスターの全データ取得
        wCnt = 0
        strSQL = SQL.MS_BU.AllData
        Dim MS_BU() As TableDef.MS_BU.DataStruct = Nothing
        Dim RsBU As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsBU.Read
            ReDim Preserve MS_BU(wCnt)
            MS_BU(wCnt) = AppModule.SetRsData(RsBU, MS_BU(wCnt))
            Try
                '1レコードずつ過去データ用DBのBUマスターにInsert
                strSQL = SQL.MS_BU.Insert(MS_BU(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "BUマスターの移行に失敗しました。")
            End Try
            wCnt += 1
        End While
        RsBU.Close()
        If Not wFlag Then Return False
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "BUマスターを" & CmnModule.EditComma(wCnt.ToString) & "件移行しました")

        'コードマスター
        '本番用DBのコードマスターの全データ取得
        wCnt = 0
        strSQL = SQL.MS_CODE.AllData
        Dim MS_CODE() As TableDef.MS_CODE.DataStruct = Nothing
        Dim RsCode As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsCode.Read
            ReDim Preserve MS_CODE(wCnt)
            MS_CODE(wCnt) = AppModule.SetRsData(RsCode, MS_CODE(wCnt))
            Try
                '1レコードずつ過去データ用DBのコードマスターにInsert
                strSQL = SQL.MS_CODE.Insert(MS_CODE(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "コードマスターの移行に失敗しました。")
            End Try
            wCnt += 1
        End While
        RsCode.Close()
        If Not wFlag Then Return False
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "コードマスターを" & CmnModule.EditComma(wCnt.ToString) & "件移行しました")

        'SAP管理マスター
        '本番用DBのSAP管理マスターの全データ取得
        wCnt = 0
        strSQL = SQL.MS_SAPKANRI.AllData
        Dim MS_SAPKANRI() As TableDef.MS_SAPKANRI.DataStruct = Nothing
        Dim RsSapKanri As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsSapKanri.Read
            ReDim Preserve MS_SAPKANRI(wCnt)
            MS_SAPKANRI(wCnt) = AppModule.SetRsData(RsSapKanri, MS_SAPKANRI(wCnt))
            Try
                '1レコードずつ過去データ用DBのSAP管理マスターにInsert
                strSQL = SQL.MS_SAPKANRI.Insert(MS_SAPKANRI(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "SAP管理マスターの移行に失敗しました。")
            End Try
            wCnt += 1
        End While
        RsSapKanri.Close()
        If Not wFlag Then Return False
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "SAP管理マスターを" & CmnModule.EditComma(wCnt.ToString) & "件移行しました")

        'TOP担当者マスター
        '本番用DBのTOP担当者マスターの全データ取得
        wCnt = 0
        strSQL = SQL.MS_USER.AllData
        Dim MS_USER() As TableDef.MS_USER.DataStruct = Nothing
        Dim RsUser As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsUser.Read
            ReDim Preserve MS_USER(wCnt)
            MS_USER(wCnt) = AppModule.SetRsData(RsUser, MS_USER(wCnt))
            Try
                '1レコードずつ過去データ用DBのTOP担当者マスターにInsert
                strSQL = SQL.MS_USER.Insert(MS_USER(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "担当者マスターの移行に失敗しました。")
            End Try
            wCnt += 1
        End While
        RsUser.Close()
        If Not wFlag Then Return False
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "担当者マスターを" & CmnModule.EditComma(wCnt.ToString) & "件移行しました")

        '税率マスター
        '本番用DBの税率マスターの全データ取得
        wCnt = 0
        strSQL = SQL.MS_ZEI.AllData
        Dim MS_ZEI() As TableDef.MS_ZEI.DataStruct = Nothing
        Dim RsZei As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsZei.Read
            ReDim Preserve MS_ZEI(wCnt)
            MS_ZEI(wCnt) = AppModule.SetRsData(RsZei, MS_ZEI(wCnt))
            Try
                '1レコードずつ過去データ用DBの税率マスターにInsert
                strSQL = SQL.MS_ZEI.Insert(MS_ZEI(wCnt))
                CmnDbBatch.Execute(strSQL, MyBase.DbConnectionPast, MyBase.DbTransactionPast)

            Catch ex As Exception
                wFlag = False
                MyBase.RollbackPast()
                InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "税率マスターの移行に失敗しました。")
            End Try
            wCnt += 1
        End While
        RsZei.Close()
        If Not wFlag Then Return False
        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "税率マスターを" & CmnModule.EditComma(wCnt.ToString) & "件移行しました")

        MyBase.CommitPast()
        Return wFlag
    End Function

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As New TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = pbatchID
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub



End Class
