Public Class CmnDb

    Const SessionDbError As String = "DbError"

    'DB�ڑ�
    Public Shared Function DbOpen(ByVal DbConn As SqlClient.SqlConnection) As Boolean
        If DbConn.State <> ConnectionState.Open Then
            Try
                DbConn.Open()
            Catch
            End Try
        End If
    End Function

    'DB�ؒf
    Public Shared Function DbClose(ByVal DbConn As SqlClient.SqlConnection) As Boolean
        If DbConn.State <> ConnectionState.Closed Then
            DbConn.Close()
        End If
    End Function

    '�g�����U�N�V�����ڑ�
    Public Shared Function TransOpen(ByVal TransConn As SqlClient.SqlConnection) As Boolean
        If TransConn.State <> ConnectionState.Open Then
            Try
                TransConn.Open()
            Catch EXPx As Exception
                Stop
            End Try
        End If
    End Function

    '�g�����U�N�V�����ؒf
    Public Shared Function TransClose(ByVal TransConn As SqlClient.SqlConnection) As Boolean
        If TransConn.State <> ConnectionState.Closed Then
            TransConn.Close()
        End If
    End Function

    '���ꕶ���G�X�P�[�v
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

    'DB�f�[�^����w��̍��ڂ̒l��Ԃ�
    Public Shared Function DbData(ByVal ColumnName As String, ByVal RsData As SqlClient.SqlDataReader) As String
        Return CmnModule.DbTrim(RsData(ColumnName).ToString)
    End Function

    'SQL���s(�X�V)
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

            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ""

            Return ret
        Catch ex As Exception
            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ex.Message & "    SQL�F" & strSQL
            Throw New Exception(System.Web.HttpContext.Current.Session.Item(SessionDbError))
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

            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ""

            Return ret
        Catch ex As Exception
            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ex.Message & "    SQL�F" & strSQL
            Throw New Exception(System.Web.HttpContext.Current.Session.Item(SessionDbError))
        End Try
    End Function
    Public Shared Function ExecuteForDeligate(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection) As Integer
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim ret As Integer
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            ret = DbCmd.ExecuteNonQuery()
            DbCmd.Dispose()

            'System.Web.HttpContext.Current.Session.Item(SessionDbError) = ""

            Return ret
        Catch ex As Exception
            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ex.Message & "    SQL�F" & strSQL
            Throw New Exception(System.Web.HttpContext.Current.Session.Item(SessionDbError))
        End Try
    End Function

    'SQL���s(�I��)
    Public Shared Function Read(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection) As SqlClient.SqlDataReader
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim RsData As SqlClient.SqlDataReader
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            RsData = DbCmd.ExecuteReader
            DbCmd.Dispose()

            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ""

            Return RsData
        Catch ex As Exception
            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ex.Message & "    SQL�F" & strSQL
            Throw New Exception(System.Web.HttpContext.Current.Session.Item(SessionDbError))
        End Try
    End Function
    Public Shared Function Read(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection, ByVal DbTrans As SqlClient.SqlTransaction) As SqlClient.SqlDataReader
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim RsData As SqlClient.SqlDataReader
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn, DbTrans)
            RsData = DbCmd.ExecuteReader
            DbCmd.Dispose()

            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ""

            Return RsData
        Catch ex As Exception
            System.Web.HttpContext.Current.Session.Item(SessionDbError) = ex.Message & "    SQL�F" & strSQL
            Throw New Exception(System.Web.HttpContext.Current.Session.Item(SessionDbError))
        End Try
    End Function
    Public Shared Function ReadForDeligate(ByVal strSQL As String, ByVal DbConn As SqlClient.SqlConnection) As SqlClient.SqlDataReader
        Dim DbCmd As System.Data.SqlClient.SqlCommand
        Dim RsDeligate As SqlClient.SqlDataReader
        If Not IsNothing(DbCmd) Then DbCmd.Dispose()

        Try
            DbOpen(DbConn)
            DbCmd = New System.Data.SqlClient.SqlCommand(strSQL, DbConn)
            RsDeligate = DbCmd.ExecuteReader
            DbCmd.Dispose()

            Return RsDeligate
        Catch ex As Exception

        End Try
    End Function

    '�f�[�^�̗L����Ԃ�
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

End Class
