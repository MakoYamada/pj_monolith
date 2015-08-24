Imports System.IO
Public Class WebBase
    Inherits System.Web.UI.Page

    Private pDbConnection As SqlClient.SqlConnection
    Private pDbTransaction As SqlClient.SqlTransaction

    '---------------------------------------------------------
    '   機　能: ページロード
    '   引　数:
    '   戻り値:
    '---------------------------------------------------------
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreAction()
        MyBase.Title = Configuration.ConfigurationManager.AppSettings("SystemName")
    End Sub

    '---------------------------------------------------------
    '   機　能: ページアンロード
    '   引　数:
    '   戻り値:
    '---------------------------------------------------------
    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        PostAction()
    End Sub

    '---------------------------------------------------------
    '   機　能: エラー時
    '   引　数:
    '   戻り値:
    '---------------------------------------------------------
    Private Sub Page_Error(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Error
        'ログファイルの検索
        Dim wLogFile As String = Server.MapPath("~") & "\error.log"
        If File.Exists(wLogFile) = False Then
            'なかったら作成
            Dim hStream As FileStream = Nothing
            Try
                Try
                    '指定したパスのファイルを作成
                    hStream = File.Create(wLogFile)
                Finally
                    '作成時に返される FileStream を利用して閉じる
                    If Not hStream Is Nothing Then
                        hStream.Close()
                    End If
                End Try
            Finally
                'hStream を破棄する
                If Not hStream Is Nothing Then
                    Dim hDisposable As System.IDisposable = hStream
                    hDisposable.Dispose()
                End If
            End Try
        End If
        Dim wStWrite As New StreamWriter(wLogFile, True)
        wStWrite.Write("【" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "】")
        wStWrite.Write(vbNewLine)

        wStWrite.Write(Replace(Server.GetLastError.ToString, "    SQL：", vbNewLine))
        wStWrite.Write(vbNewLine)
        wStWrite.Write(vbNewLine)
        wStWrite.Close()

        Response.Redirect(System.Configuration.ConfigurationManager.AppSettings("URL") & "Sorry.html")
    End Sub

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

        CmnDb.DbOpen(pDbConnection)
    End Sub

    '---------------------------------------------------------
    '   機　能: 後処理(DB切断)
    '   引　数:
    '   戻り値:
    '---------------------------------------------------------
    Private Sub PostAction()

        PreAction()

        'DB切断
        CmnDb.DbClose(pDbConnection)
    End Sub

    '---------------------------------------------------------
    '   トランザクション関連
    '---------------------------------------------------------
    Public Sub BeginTransaction()
        Try
            pDbTransaction = pDbConnection.BeginTransaction
        Catch ex As Exception
            Throw New Exception("BeginTransaction Error", ex)
        End Try
    End Sub
    Public Sub Commit()
        Try
            If pDbTransaction Is Nothing = False Then
                pDbTransaction.Commit()
            End If
        Catch ex As Exception
            Throw New Exception("CommitTransaction Error", ex)
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
            Throw New Exception("RollbackTransaction Error", ex)
        Finally
            pDbTransaction = Nothing
        End Try
    End Sub

End Class
