Imports System.Web
Imports System.Web.SessionState
Imports System.IO

Public Class [Global]
    Inherits System.Web.HttpApplication

#Region " コンポーネント デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは、コンポーネント デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。
    End Sub

    ' コンポーネント デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    ' メモ : 以下のプロシージャはコンポーネント デザイナで必要です。
    ' コンポーネント デザイナを使って変更して下さい。
    ' コード エディタを使って変更しないで下さい。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' アプリケーションの起動時に呼び出されます。
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' セッションの開始時に呼び出されます。
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' 各要求の開始時に呼び出されます。
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' 使用の認証時に呼び出されます。
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' エラーの発生時に呼び出されます。
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' セッションの終了時に呼び出されます。
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' アプリケーションの終了時に呼び出されます。
    End Sub

    Sub Application_OnPreRequestHandlerExecute(ByVal sender As Object, ByVal e As EventArgs)
        'メンテナンス中
        If WebConfig.Site.Maintenance = CommonLib.CmnConst.Flag.On Then
            Response.Redirect(URL.MaintenancePage)
        End If
    End Sub

End Class