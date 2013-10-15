Imports System.Diagnostics
Imports System.Threading
Imports System.Collections
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
'Imports Oracle.DataAccess.Client
Imports System.Collections.Specialized
Imports log4net

''' <summary>
''' ログを出力するメインクラスです。
''' 出力はログファイルとWindowsのイベントログに出力します。
''' log4netを使用してログを出力します。''' </summary>
''' <remarks></remarks>
Public Class PrintLogProc

#Region "ロガーの定義"
    'log4netにてログを出力するためロガーを取得します。
    Private Shared ReadOnly LOG_SHOSAI As log4net.ILog = log4net.LogManager.GetLogger("SHOSAI")
    Private Shared ReadOnly LOG_SQL As log4net.ILog = log4net.LogManager.GetLogger("SQL")
    Private Shared ReadOnly LOG_DEBUG As log4net.ILog = log4net.LogManager.GetLogger("DEBUG")
    Private Shared ReadOnly LOG_MAIL As log4net.ILog = log4net.LogManager.GetLogger("SMTP")

#End Region

#Region "ログデータの定義"

    'イベントログに出力するときの設定
    Private logName As String = "Application"
    Private mySource As String = "手配管理システム"

    'ログ出力レベル
    Public Enum logLevel
        LOGLEVEL_FATAL = 1
        LOGLEVEL_ERROR
        LOGLEVEL_WARN
        LOGLEVEL_INFO
        LOGLEVEL_DEBUG
    End Enum

    '出力データのディクショナリキー
    Public Const KEY_DATE As String = "Date"
    Public Const KEY_TIME As String = "Time"
    Public Const KEY_IPADDRESS As String = "IPaddress"
    Public Const KEY_HOSTNAME As String = "HostName"
    Public Const KEY_LOGSOURCE As String = "LogSource"
    Public Const KEY_LOGCLASS As String = "LogClass"
    Public Const KEY_LOGERRCODE As String = "LogErrCode"
    Public Const KEY_BATCHID As String = "BatchID"
    Public Const KEY_LOGINID As String = "LoginID"
    Public Const KEY_ACTION As String = "Action"
    Public Const KEY_PARAM As String = "Param"
    Public Const KEY_LOGEXCEPTION As String = "LogException"
    Public Const KEY_LOGERRMSG As String = "LogErrMsg"
    Public Const kEY_LOGLEVEL As String = "LogLevel"

#End Region

#Region "プロパティ"
    '' ------------------------------------------------
    ''    機  能：プロセス名をセット・ゲットします。
    '' ------------------------------------------------
    'Public Property proc() As String
    '    Get
    '        Return pProc
    '    End Get
    '    Set(ByVal value As String)
    '        pProc = value
    '    End Set
    'End Property

#End Region

    'コンストラクタ
    Public Sub New()
    End Sub

    ''' <summary>
    ''' ジョブ開始のログを出力する
    ''' </summary>
    ''' <param name="jobName"></param>
    ''' <remarks></remarks>
    Public Sub PrintStartLog(ByVal jobName As String)
        LOG_SHOSAI.Info("STR JOB" & Space(1) & jobName)
    End Sub

    ''' <summary>
    ''' ジョブ終了のログを出力する
    ''' </summary>
    ''' <param name="jobName"></param>
    ''' <remarks></remarks>
    Public Sub PrintEndLog(ByVal jobName As String)
        LOG_SHOSAI.Info("END JOB" & Space(1) & jobName)
    End Sub

    ''' <summary>
    ''' ジョブの実行に関するログを出力する。
    ''' </summary>
    ''' <param name="jobName"></param>
    ''' <param name="msg">メッセージ</param>
    ''' <remarks></remarks>
    Public Sub PrintInfoLog(ByVal jobName As String, ByVal msg As String)
        LOG_SHOSAI.Info("       " & Space(1) & jobName & Space(1) & msg)
    End Sub

    ''' <summary>
    ''' ジョブエラーのログを出力する    ''' </summary>
    ''' <param name="jobName"></param>
    ''' <param name="errroNaiyo"></param>
    ''' <remarks></remarks>
    Public Sub PrintErrorLog(ByVal jobName As String, ByVal errroNaiyo As String)
        LOG_SHOSAI.Error("ERR JOB" & Space(1) & jobName & Space(1) & errroNaiyo)
    End Sub

    ''' <summary>
    ''' メールにて通知を行う。
    ''' </summary>
    ''' <param name="jobName"></param>
    ''' <param name="errroNaiyo"></param>
    ''' <remarks></remarks>
    Public Sub SendErrorMsg(ByVal jobName As String, ByVal errroNaiyo As String)
        LOG_MAIL.Error("ERR JOB" & Space(1) & jobName & Space(1) & vbCrLf & vbCrLf & errroNaiyo)
    End Sub

    ' ------------------------------------------------
    '    機  能：SQLを出力します。
    '    引  数：オラクルコマンド/ベース名/ログイン名
    '    戻り値：無し
    ' ------------------------------------------------
    Public Sub PrintSQL(ByVal dbcmd As IDbCommand, ByVal BaseName As String, _
                        ByVal LoginID As String, ByVal hostName As String, _
                        ByVal pcAdd As String, ByVal URLPath As String)

        Try

            ' 変数宣言
            Dim nowTime As String = DateTime.Now.ToString()
            Dim logText_SQL As String = ""
            Dim SQLString As String = dbcmd.CommandText.ToUpper()


            Dim logTextTop As New System.Text.StringBuilder
            logTextTop.Append("---SQL-START---")
            logTextTop.Append(BaseName)
            logTextTop.Append("_")
            logTextTop.Append(nowTime)
            logTextTop.Append("-----------------" & vbCrLf)
            logTextTop.Append("-------------------------------Base Info-----------------------------" & vbCrLf)
            logTextTop.Append("Base Instance：" & BaseName & vbCrLf)
            logTextTop.Append("Connect PC：" & pcAdd & vbCrLf)
            logTextTop.Append("LoginID：" & LoginID & vbCrLf)
            logTextTop.Append("URLPath：" & URLPath & vbCrLf)


            Dim ParaNameList As ArrayList = setPara(dbcmd)
            Dim BindCount As Integer = 0
            '2012/10/05 コメントアウト　ukon
            'If TypeOf dbcmd Is OracleCommand Then
            '    BindCount = DirectCast(dbcmd, OracleCommand).ArrayBindCount()
            'End If

            'パラメータの出力
            Dim logTextMiddle As New System.Text.StringBuilder

            If BindCount < 1 Then
                logTextMiddle.Append("------------------------------Parameters---------------------------" & vbCrLf)
                For i As Integer = ParaNameList.Count - 1 To 0 Step -1
                    If dbcmd.Parameters(DirectCast(ParaNameList(i), String)).Value IsNot Nothing Then
                        logTextMiddle.Append(("SQL-Parameters:" & DirectCast(ParaNameList(i), String) & "(") + dbcmd.Parameters(DirectCast(ParaNameList(i), String)).Value & ")" & vbCrLf)
                        Dim obj As Object = dbcmd.Parameters(DirectCast(ParaNameList(i), String)).Value
                        If TypeOf obj Is String Then
                            SQLString = SQLString.Replace(":" & ParaNameList(i).ToString(), "'" & obj.ToString() & "'")
                        Else
                            SQLString = SQLString.Replace(":" & ParaNameList(i).ToString(), obj.ToString())
                        End If
                    Else
                        logTextMiddle.Append("SQL-Parameters:" & DirectCast(ParaNameList(i), String) & "( !!Nothing!! )" & vbCrLf)
                    End If
                Next
                SQLString = SQLString.Replace(":", "")
            Else
                For i As Integer = 0 To BindCount - 1
                    Dim ii As Long = i
                    ii = System.Threading.Interlocked.Increment(ii)
                    logTextMiddle.Append("------------------------------Parameters : " & ii & "---------------------------" & vbCrLf)
                    For j As Integer = ParaNameList.Count - 1 To 0 Step -1
                        If dbcmd.Parameters(DirectCast(ParaNameList(j), String)).Value IsNot Nothing Then
                            Dim obj As Object = dbcmd.Parameters(DirectCast(ParaNameList(j), String)).Value
                            'Dim tmparr As Array = DirectCast(obj, Array)
                            If obj IsNot Nothing Then
                                'If tmparr.Length > 0 Then
                                logTextMiddle.Append("SQL-Parameters:" & DirectCast(ParaNameList(j), String) & "(" & Convert.ToString(obj) & ")" & vbCrLf)
                            Else
                                logTextMiddle.Append("SQL-Parameters:" & DirectCast(ParaNameList(j), String) & "( パラメータ設定が異常です!! )" & vbCrLf)
                            End If
                        Else
                            logTextMiddle.Append("SQL-Parameters:" & DirectCast(ParaNameList(j), String) & "( !!Nothing!! )" & vbCr)
                        End If
                    Next

                    If (ii Mod 100) = 0 Then
                        'log4netにて中間ログを出力
                        nowTime = DateTime.Now.ToString()
                        logTextMiddle.Append("------------------------------NowTime : " & nowTime & "---------------------------" & vbCrLf)

                        '出力
                        LOG_SQL.Info(logTextTop.ToString & logTextMiddle.ToString)
                    End If
                Next
            End If

            Dim logTextSQL As New System.Text.StringBuilder
            logTextSQL.Append("------------------------------SQLString---------------------------" & vbCrLf)
            For i As Integer = 0 To 9
                SQLString = SQLString.Replace("  ", " ")
            Next
            SQLString = SQLString.Replace(" AND ", " AND " & vbCrLf)
            SQLString = SQLString.Replace(" OR ", " OR " & vbCrLf)
            SQLString = SQLString.Replace(" From", vbCrLf & " From " & vbCrLf)
            SQLString = SQLString.Replace(" FROM", vbCrLf & " From " & vbCrLf)
            SQLString = SQLString.Replace(" WHERE", vbCrLf & " Where " & vbCrLf)
            SQLString = SQLString.Replace(",", vbCrLf & " , ")
            SQLString = SQLString.Replace(" ORDER ", vbCrLf & " ORDER " & vbCrLf)
            SQLString = SQLString.Replace(" VALUES ", vbCrLf & " VALUES " & vbCrLf)
            SQLString = SQLString.Replace("SYSDATE" & vbCrLf & " , ", "SYSDATE, ")
            SQLString = SQLString.Replace("SYSDATE " & vbCrLf & " , ", "SYSDATE, ")

            logTextSQL.Append(SQLString & vbCrLf)
            logTextSQL.Append("---SQL-END----------------" & BaseName & "-----------------------" & vbCrLf)

            '出力
            LOG_SQL.Info(logTextTop.ToString & logTextMiddle.ToString & logTextSQL.ToString)

        Catch ex As Exception
            Debug.WriteLine(ex)
            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
        End Try

    End Sub


    ' ------------------------------------------------
    '    機  能：オラクルコマンドパラメータをソートします。
    '    引  数：オラクルコマンド
    '    戻り値：ArrayList
    ' ------------------------------------------------
    Private Function setPara(ByVal dbcmd As IDbCommand) As ArrayList
        Dim paraName As New ArrayList()
        For i As Integer = 0 To dbcmd.Parameters.Count - 1
            paraName.Add(dbcmd.Parameters(i).ParameterName.ToUpper())
        Next
        Dim comp As New LengthComparer()
        paraName.Sort(comp)

        Return paraName

    End Function


    ' ------------------------------------------------
    '    機  能：ログを出力します。
    '    引  数：ログ情報
    '    戻り値：無し
    ' ------------------------------------------------
    Public Sub PrintLog(ByVal logdata As StringDictionary)

        Try
            Const space1 As String = vbTab

            '出力メッセージ作成
            Dim logText As New System.Text.StringBuilder

            '出力必須項目
            logText.Append(logdata.Item(KEY_IPADDRESS).PadRight(15))
            logText.Append(space1)
            logText.Append(logdata.Item(KEY_HOSTNAME).PadRight(20))
            logText.Append(space1)
            logText.Append(logdata.Item(KEY_LOGSOURCE).PadRight(30))
            logText.Append(space1)
            logText.Append(logdata.Item(KEY_LOGCLASS).PadRight(30))
            logText.Append(space1)
            logText.Append(logdata.Item(KEY_LOGERRCODE).PadRight(8))

            '以下、出力オプション項目
            If logdata.Item(KEY_BATCHID) IsNot Nothing Then
                logText.Append(space1)
                logText.Append(logdata.Item(KEY_BATCHID).PadRight(8))
            End If
            If logdata.Item(KEY_LOGINID) IsNot Nothing Then
                logText.Append(space1)
                logText.Append(logdata.Item(KEY_LOGINID))
            End If
            If logdata.Item(KEY_ACTION) IsNot Nothing Then
                logText.Append(space1)
                logText.Append(logdata.Item(KEY_ACTION))
            End If
            If logdata.Item(KEY_PARAM) IsNot Nothing Then
                logText.Append(space1)
                logText.Append(logdata.Item(KEY_PARAM))
            End If
            Select Case logdata.Item(kEY_LOGLEVEL)
                Case logLevel.LOGLEVEL_DEBUG
                    LOG_SHOSAI.Debug(logText.ToString)
                    Exit Select
                Case logLevel.LOGLEVEL_ERROR
                    LOG_SHOSAI.Error(logText.ToString & vbCrLf & logdata.Item(KEY_LOGEXCEPTION))
                    Exit Select
                Case logLevel.LOGLEVEL_INFO
                    LOG_SHOSAI.Info(logText.ToString & Convert.ToString(logdata.Item(KEY_LOGERRMSG)))
                    Exit Select
                Case logLevel.LOGLEVEL_WARN
                    LOG_SHOSAI.Warn(logText.ToString & vbCrLf & logdata.Item(KEY_LOGEXCEPTION))
                    Exit Select
                Case logLevel.LOGLEVEL_FATAL
                    LOG_SHOSAI.Fatal(logText.ToString & vbCrLf & logdata.Item(KEY_LOGEXCEPTION))
                    Exit Select
            End Select

        Catch ex As Exception
            Debug.WriteLine(ex)
            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
        End Try

    End Sub

    ' ------------------------------------------------
    '    機  能：デバッグログを出力します。
    '    引  数：ログ情報
    '    戻り値：無し
    ' ------------------------------------------------
    Public Sub Debuglog_Out(ByVal MessageParam As String)
        Dim DEBUG_LOG As log4net.ILog = log4net.LogManager.GetLogger("DEBUG")

        Try
            Dim logText As String = MessageParam
            Debug.WriteLine(MessageParam)

            DEBUG_LOG.Debug(logText)
        Catch ex As Exception
            Debug.WriteLine(ex)
            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
        End Try
    End Sub

    ' ------------------------------------------------
    '    機  能：デバッグログを出力します。
    '    引  数：ログ情報
    '    戻り値：無し
    ' ------------------------------------------------
    Public Sub Debuglog_Out(ByVal MessageParam As String())
        Dim DEBUG_LOG As log4net.ILog = log4net.LogManager.GetLogger("DEBUG")

        Try
            Dim logText As String = ""

            For i As Integer = 0 To MessageParam.Length - 1
                logText += MessageParam(i) & vbTab
            Next

            DEBUG_LOG.Debug(logText)
        Catch ex As Exception
            Debug.WriteLine(ex)
            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
        End Try

    End Sub
    ' ------------------------------------------------
    '    機  能：windowsのイベントログにエラーを出力します。
    '    引  数：バッチID
    '    戻り値：無し
    ' ------------------------------------------------
    Public Sub WinEventlog_Out(ByVal batchID As String)

        Try

            Console.WriteLine("イベントログ出力処理中")

            ' Create the source, if it does not already exist.
            If Not EventLog.SourceExists(logName) Then
                EventLog.CreateEventSource(logName, logName)
            End If

            Dim myEventlog As New System.Diagnostics.EventLog()
            myEventlog.Source = mySource
            myEventlog.Log = logName

            Dim myMessage As String = mySource & "：バッチ処理でエラーが発生しました。：" & batchID
            Dim myEventLogEntryType As EventLogEntryType = EventLogEntryType.[Error]
            Dim myApplicatinEventId As Integer = 1100
            Dim myApplicatinCategoryId As Short = 5

            ' Write the entry in the event log.
            myEventlog.WriteEntry(myMessage, myEventLogEntryType, myApplicatinEventId, myApplicatinCategoryId)
            myEventlog.Close()
            Console.WriteLine("イベントログ出力処理終了")
        Catch ex As Exception
            Debug.WriteLine(ex)
            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
        End Try

    End Sub

    '    ' ------------------------------------------------
    '    '    コンペアBATCH用の
    '    '    機  能：windowsのイベントログにエラーを出力します。
    '    '    引  数：ArrayList
    '    '    戻り値：無し
    '    ' ------------------------------------------------
    '    Public Sub WinEventlog_Out(ByVal ExceptionList As ArrayList)

    '        Try

    '            Console.WriteLine("イベントログ出力処理中")

    '            Dim logData As datlogout

    '            ' Create the source, if it does not already exist.
    '            If Not EventLog.SourceExists(logName) Then
    '                EventLog.CreateEventSource(logName, logName)
    '            End If

    '            Dim myEventlog As New System.Diagnostics.EventLog()
    '            myEventlog.Source = mySource
    '            myEventlog.Log = logName

    '            For i As Integer = 0 To ExceptionList.Count - 1
    '                logData = DirectCast(ExceptionList(i), datlogout)

    '                Dim myMessage As String = (mySource & "：バッチ処理でエラーが発生しました。：") + logData.BatchID
    '                myMessage += vbLf
    '                myMessage += vbLf & "後日連絡してください。"
    '                myMessage += vbLf
    '                myMessage += vbLf & "メッセージ：" + logData.Action
    '                myMessage += vbLf & "対象マスタ名：" + logData.Param
    '                Dim myEventLogEntryType As EventLogEntryType = EventLogEntryType.[Error]
    '                Dim myApplicatinEventId As Integer = 1100
    '                Dim myApplicatinCategoryId As Short = 5

    '                ' Write the entry in the event log.
    '                myEventlog.WriteEntry(myMessage, myEventLogEntryType, myApplicatinEventId, myApplicatinCategoryId)
    '                myMessage = ""
    '            Next

    '            myEventlog.Close()

    '            Console.WriteLine("イベントログ出力処理終了")
    '        Catch ex As Exception
    '            Debug.WriteLine(ex)
    '#If (Debug) Then
    '#End If

    '            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
    '        End Try

    '    End Sub

    ' ------------------------------------------------
    '    機  能：windowsのイベントログにエラーを出力します。
    '    引  数：
    '    戻り値：無し
    ' ------------------------------------------------
    Public Sub WinEventlog_Out_Online(ByVal refPage As String)

        Try


            ' Create the source, if it does not already exist.
            If Not EventLog.SourceExists(logName) Then
                EventLog.CreateEventSource(logName, logName)
            End If

            Dim myEventlog As New System.Diagnostics.EventLog()
            myEventlog.Source = mySource
            myEventlog.Log = logName

            Dim myMessage As String = mySource & "：オンライン処理でエラーが発生しました。：" _
                                     & vbLf _
                                     & "エラー発生場所：" _
                                     & refPage

            Dim myEventLogEntryType As EventLogEntryType = EventLogEntryType.[Error]
            Dim myApplicatinEventId As Integer = 1001
            Dim myApplicatinCategoryId As Short = 1

            ' Write the entry in the event log.
            myEventlog.WriteEntry(myMessage, myEventLogEntryType, myApplicatinEventId, myApplicatinCategoryId)

            myEventlog.Close()
        Catch ex As Exception
            Debug.WriteLine(ex)
            Console.WriteLine("Error Debug:" & vbLf & ex.StackTrace)
        End Try

    End Sub


    'Public Sub WebLog_out(ByVal sender As Object, ByVal e As EventArgs, ByVal page As System.Web.UI.ControlCollection)
    '    Dim SR As New System.Text.StringBuilder()

    '    Debug.WriteLine(sender.[GetType]().GetEvents().ToString())
    '    For Each c As System.Web.UI.Control In page
    '        If c.HasControls() Then
    '            SR.Append(web_debug_log_out(c))
    '        Else
    '            getCtlData(SR, c)

    '        End If
    '    Next

    '    LOG_DEBUG.Debug(SR.ToString())

    'End Sub

    'Private Function web_debug_log_out(ByVal c As System.Web.UI.Control) As String
    '    Dim SR As New System.Text.StringBuilder()

    '    For Each ci As System.Web.UI.Control In c.Controls
    '        If ci.HasControls() Then
    '            SR.Append(web_debug_log_out(ci) & vbTab)
    '        Else
    '            getCtlData(SR, ci)

    '        End If
    '    Next

    '    Return SR.ToString()

    'End Function

    'Private Function getCtlData(ByVal SR As System.Text.StringBuilder, ByVal ci As System.Web.UI.Control) As System.Text.StringBuilder
    '    Dim txbobj As System.Web.UI.WebControls.TextBox = TryCast(ci, System.Web.UI.WebControls.TextBox)
    '    If txbobj IsNot Nothing Then
    '        If Not txbobj.ID.StartsWith("TextBox") Then
    '            If Not txbobj.ID.Equals("txtRiyouKiyaku") Then
    '                SR.Append(txbobj.ID & ":" & txbobj.Text & vbTab)
    '            End If
    '        End If
    '    Else
    '        Dim lblobj As System.Web.UI.WebControls.Label = TryCast(ci, System.Web.UI.WebControls.Label)
    '        If lblobj IsNot Nothing Then
    '            If Not lblobj.ID.StartsWith("Label") Then
    '                SR.Append(lblobj.ID & ":" & lblobj.Text & vbTab)
    '            End If
    '        Else
    '            Dim chkobj As System.Web.UI.WebControls.CheckBox = TryCast(ci, System.Web.UI.WebControls.CheckBox)
    '            If chkobj IsNot Nothing Then
    '                If Not chkobj.ID.StartsWith("CheckBox") Then
    '                    SR.Append(chkobj.ID & ":" & chkobj.Checked.ToString() & vbTab)
    '                End If
    '            Else
    '                Dim ddlobj As System.Web.UI.WebControls.DropDownList = TryCast(ci, System.Web.UI.WebControls.DropDownList)
    '                If ddlobj IsNot Nothing Then
    '                    Try
    '                        If Not ddlobj.ID.StartsWith("DropDownList") Then
    '                            SR.Append(ddlobj.ID & ":" & ddlobj.SelectedItem.ToString() & "(" & ddlobj.SelectedValue.ToString() & ")" & vbTab)
    '                        End If
    '                    Catch ex As Exception
    '                        Debug.WriteLine(ex)
    '                    End Try

    '                End If
    '            End If
    '        End If
    '    End If

    '    Return SR
    'End Function

End Class



Public Class LengthComparer
    Implements System.Collections.IComparer
    'xがyより小さいときはマイナスの数、大きいときはプラスの数、
    '同じときは0を返す
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Return DirectCast(x, String).Length - DirectCast(y, String).Length
    End Function
End Class



