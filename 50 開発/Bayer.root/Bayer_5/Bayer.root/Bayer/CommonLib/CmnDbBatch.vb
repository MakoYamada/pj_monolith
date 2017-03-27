Public Class CmnDbBatch
    Const SessionDbError As String = "DbError"

    'DB接続
    Public Shared Function DbOpen(ByVal DbConn As SqlClient.SqlConnection) As Boolean
        If DbConn.State <> ConnectionState.Open Then
            Try
                DbConn.Open()
            Catch
            End Try
        End If
    End Function

    'DB切断
    Public Shared Function DbClose(ByVal DbConn As SqlClient.SqlConnection) As Boolean
        If DbConn.State <> ConnectionState.Closed Then
            DbConn.Close()
        End If
    End Function

    'トランザクション接続
    Public Shared Function TransOpen(ByVal TransConn As SqlClient.SqlConnection) As Boolean
        If TransConn.State <> ConnectionState.Open Then
            Try
                TransConn.Open()
            Catch EXPx As Exception
                Stop
            End Try
        End If
    End Function

    'トランザクション切断
    Public Shared Function TransClose(ByVal TransConn As SqlClient.SqlConnection) As Boolean
        If TransConn.State <> ConnectionState.Closed Then
            TransConn.Close()
        End If
    End Function

    '特殊文字エスケープ
    Public Shared Function SqlString(ByVal sql As String, Optional ByVal LikeFlag As Boolean = False) As String
        Dim wStr As String = CmnModule.DbTrim(sql)
        wStr = Replace(wStr, "'", "''")
        If LikeFlag = True Then
            wStr = Replace(wStr, "[", "[[]")
            wStr = Replace(wStr, "%", "[%]")
            wStr = Replace(wStr, "_", "[_]")
        End If
        Return wStr
    End Function

    'DBデータから指定の項目の値を返す
    Public Shared Function DbData(ByVal ColumnName As String, ByVal RsData As SqlClient.SqlDataReader) As String
        Return CmnModule.DbTrim(RsData(ColumnName).ToString)
    End Function

    'SQL実行(更新)
    Public Shared Function Execute(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection, ByVal DbTrans As SqlClient.SqlTransaction) As Integer
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim ret As Integer
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            DbCmd.Transaction = DbTrans
            ret = DbCmd.ExecuteNonQuery()
            DbCmd.Dispose()

            Return ret
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function Execute(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection) As Integer
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim ret As Integer
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            ret = DbCmd.ExecuteNonQuery()
            DbCmd.Dispose()

            Return ret
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function Execute(ByVal strSQL As String, ByVal DbConn1 As SqlClient.SqlConnection, ByVal DbConn2 As SqlClient.SqlConnection, ByVal DbTrans As SqlClient.SqlTransaction) As Integer
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim ret As Integer
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn1)
            DbOpen(DbConn2)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn1)
            DbCmd.Transaction = DbTrans
            ret = DbCmd.ExecuteNonQuery()
            DbCmd.Dispose()

            Return ret
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    'SQL実行(選択)
    Public Shared Function Read(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection, ByVal DbTrans As SqlClient.SqlTransaction) As SqlClient.SqlDataReader
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim RsData As SqlClient.SqlDataReader
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            DbCmd.Transaction = DbTrans
            RsData = DbCmd.ExecuteReader
            DbCmd.Dispose()

            Return RsData
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function Read(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection) As SqlClient.SqlDataReader
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim RsData As SqlClient.SqlDataReader
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            RsData = DbCmd.ExecuteReader
            DbCmd.Dispose()

            Return RsData
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    'データの有無を返す
    Public Shared Function IsExist(ByVal strSQL As String, ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean
        Dim wFlag As Boolean = False
        Dim RsData As System.Data.SqlClient.SqlDataReader

        RsData = CmnDb.Read(strSQL, DbConn)
        If RsData.Read() Then
            wFlag = True
        End If
        RsData.Close()

        Return wFlag
    End Function

    'SQL実行(選択)
    Public Shared Function IsExist(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection, ByVal DbTrans As SqlClient.SqlTransaction) As Boolean
        Dim wFlag As Boolean = False
        Dim RsData As System.Data.SqlClient.SqlDataReader

        RsData = Read(strSQL, DbConn, DbTrans)
        If RsData.Read() Then
            wFlag = True
        End If
        RsData.Close()

        Return wFlag

        'Dim wFlag As Boolean = False
        'Dim DbCmd As System.Data.SqlClient.SqlCommand
        'Dim RsData As SqlClient.SqlDataReader
        'If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        'Try
        '    DbOpen(DbConn)
        '    DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
        '    DbCmd.Transaction = DbTrans
        '    RsData = DbCmd.ExecuteReader
        '    If RsData.Read Then
        '        wflag = True
        '    End If
        '    DbCmd.Dispose()

        '    Return wflag
        'Catch ex As Exception
        '    Throw New Exception(ex.Message)
        'End Try
    End Function
End Class
