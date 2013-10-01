Option Explicit On

Imports System
Imports System.Text
Imports System.Collections.Specialized
Imports CommonLib

Public MustInherit Class batchBase

    Private pbatchID As String
    Private retvalue As Integer
    Private paction As String = ""
    Private pparam As String = ""

    Private pDbConnection As SqlClient.SqlConnection
    Private pDbTransaction As SqlClient.SqlTransaction

    Public MustOverride Sub run()

    Private Sub New()

    End Sub

    Public Sub New(ByVal batchID As String)

        Console.WriteLine("batchBase Started")

        Me.pbatchID = batchID

        ' 起動ログの出力
        Console.WriteLine(batchID & " Start " & System.DateTime.Now().ToString("yyyy/MM/dd HH:mm:ss"))
    End Sub

    Public Function doAction() As Integer

        Dim logger As New PrintLog.PrintLogProc()

        Try
            '開始ログ出力
            logger.PrintStartLog(batchID)

            '初期処理
            PreAction()

            'トランザクション開始
            BeginTransaction()

            '処理実行
            run()

            'コミット
            Commit()

        Catch ex As Exception

            'エラー処理表示
            Console.WriteLine(CrtString(ex))

#If DEBUG Then
            ' DEBUG 時はメッセージを送る
            Debug.WriteLine(CrtString(ex))
#End If

            'ロールバック
            Rollback()

            Me.batchStatus = 1

            'ログ出力
            Application_OnError(ex)

        Finally
            ' 終了ログの出力
            Console.WriteLine(batchID & " End " & System.DateTime.Now().ToString("yyyy/MM/dd HH:mm:ss"))
            logger.PrintEndLog(batchID)
            PostAction()
        End Try

        Return Me.batchStatus
    End Function

    Public ReadOnly Property batchID() As String
        Get
            Return pbatchID
        End Get
    End Property

    Public Property batchStatus() As Integer
        Get
            Return retvalue
        End Get
        Set(ByVal batchStatus As Integer)
            retvalue = batchStatus
        End Set
    End Property

    Public Property action() As String
        Get
            Return paction
        End Get
        Set(ByVal action As String)
            Me.paction = action
        End Set
    End Property

    Public Property addParam() As String
        Get
            Return pparam
        End Get
        Set(ByVal param As String)
            Me.pparam = param
        End Set
    End Property

    Public Function CrtString(ByVal ex As Exception) As String
        Dim sb As New StringBuilder
        sb.Append("BatchID:" & pbatchID & vbCrLf)
        sb.Append("Action:" & paction & vbCrLf)
        sb.Append("Params:" & pparam & vbCrLf)
        sb.Append("base Exception:" & ex.ToString())
        Return sb.ToString
    End Function

    Private Sub Application_OnError(ByVal ex As Exception)
        Dim currentLogData As New StringDictionary
        currentLogData.Item(PrintLog.PrintLogProc.KEY_DATE) = Format(Now(), "yyyy/MM/dd")
        currentLogData.Item(PrintLog.PrintLogProc.KEY_TIME) = Format(Now(), "HH:mm:ss")
        currentLogData.Item(PrintLog.PrintLogProc.kEY_LOGLEVEL) = PrintLog.PrintLogProc.logLevel.LOGLEVEL_ERROR
        currentLogData.Item(PrintLog.PrintLogProc.KEY_LOGSOURCE) = ex.Source.ToString()
        currentLogData.Item(PrintLog.PrintLogProc.KEY_LOGCLASS) = ""
        currentLogData.Item(PrintLog.PrintLogProc.KEY_LOGERRCODE) = ""
        currentLogData.Item(PrintLog.PrintLogProc.KEY_LOGERRMSG) = ex.Message
        currentLogData.Item(PrintLog.PrintLogProc.KEY_LOGEXCEPTION) = ex.ToString
        currentLogData.Item(PrintLog.PrintLogProc.KEY_BATCHID) = Me.batchID
        currentLogData.Item(PrintLog.PrintLogProc.KEY_PARAM) = Me.pparam
        currentLogData.Item(PrintLog.PrintLogProc.KEY_ACTION) = Me.action
        currentLogData.Item(PrintLog.PrintLogProc.KEY_HOSTNAME) = System.Net.Dns.GetHostName()

        Dim ip As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
        Dim ipadd As System.Net.IPAddress = ip.AddressList(0)
        currentLogData.Item(PrintLog.PrintLogProc.KEY_IPADDRESS) = ipadd.ToString()

        Dim logger As New PrintLog.PrintLogProc()
        logger.PrintLog(currentLogData)
        logger.WinEventlog_Out(Me.batchID)

        'エラーメールの送信
        logger.SendErrorMsg(Me.batchID, ex.Message)

    End Sub

    ''' <summary>
    ''' 警告メールの送信を行う。
    ''' </summary>
    ''' <param name="outMessage">メッセージ内容</param>
    ''' <remarks></remarks>
    Public Sub SendAlertMail(ByVal outMessage As String)
        Dim logger As New PrintLog.PrintLogProc()
        logger.SendErrorMsg(Me.batchID, outMessage)
    End Sub

    ''' <summary>
    ''' 処理状況をログに出力する。
    ''' </summary>
    ''' <param name="outMessage">メッセージ内容</param>
    ''' <remarks></remarks>
    Public Sub WriteInfoLog(ByVal outMessage As String)
        Dim logger As New PrintLog.PrintLogProc()
        logger.PrintInfoLog(Me.batchID, outMessage)
    End Sub


    '2013/09/27Add

    'プロパティ
    'DB接続
    Public ReadOnly Property DbConnection() As SqlClient.SqlConnection
        Get
            Return pDbConnection
        End Get
    End Property

    'トランザクション
    Public ReadOnly Property DbTransaction() As SqlClient.SqlTransaction
        Get
            Return pDbTransaction
        End Get
    End Property

    '---------------------------------------------------------
    '   機　能: 前処理(DB接続)
    '   引　数:
    '   戻り値:
    '---------------------------------------------------------
    Private Sub PreAction()
        'DB接続

        If pDbConnection Is Nothing Then
            pDbConnection = New SqlClient.SqlConnection(Configuration.ConfigurationManager.AppSettings("ConnectionString"))
        End If

        CmnDbBatch.DbOpen(pDbConnection)
    End Sub

    '---------------------------------------------------------
    '   機　能: 後処理(DB切断)
    '   引　数:
    '   戻り値:
    '---------------------------------------------------------
    Private Sub PostAction()
        'DB切断
        CmnDbBatch.DbClose(pDbConnection)
    End Sub

    '---------------------------------------------------------
    '   トランザクション関連
    '---------------------------------------------------------
    Public Sub BeginTransaction()
        Try
            pDbTransaction = pDbConnection.BeginTransaction
        Catch ex As Exception
            Throw New Exception("BeginTransaction Error:" & ex.Message, ex)
        End Try
    End Sub
    Public Sub Commit()
        Try
            If pDbTransaction Is Nothing = False Then
                pDbTransaction.Commit()
            End If
        Catch ex As Exception
            Throw New Exception("CommitTransaction Error:" & ex.Message, ex)
        Finally
            pDbTransaction = Nothing
        End Try
    End Sub
    Public Sub Rollback()
        Try
            If pDbTransaction Is Nothing = False Then
                pDbTransaction.Rollback()
            End If
        Catch ex As Exception
            Throw New Exception("RollbackTransaction Error:" & ex.Message, ex)
        Finally
            pDbTransaction = Nothing
        End Try
    End Sub

End Class
