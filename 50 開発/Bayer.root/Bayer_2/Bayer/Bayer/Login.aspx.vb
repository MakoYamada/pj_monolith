Imports CommonLib
Imports AppLib
Partial Public Class Login
    Inherits WebBase

    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session.Contents.RemoveAll()

            '画面項目 初期化            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .HideMenu = True
            .HideLoginUser = True
            .HideLogout = True
            .PageTitle = "ログイン"
        End With
    End Sub

    '画面項目 初期化    Private Sub InitControls()
        'IME設定        CmnModule.SetIme(Me.LOGIN_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.PASSWORD, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
    End Sub

    '入力値チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.LOGIN_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.LOGIN_ID), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.PASSWORD) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.PASSWORD), Me)
            Return False
        End If

        'TOP担当者マスタ
        Dim strSQL As String = SQL.MS_USER.Login(Trim(Me.LOGIN_ID.Text), Trim(Me.PASSWORD.Text))
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim MS_USER As TableDef.MS_USER.DataStruct = Nothing
        
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            '大文字・小文字チェック
            If RsData(TableDef.MS_USER.Column.LOGIN_ID).ToString = Trim(Me.LOGIN_ID.Text) AndAlso _
               RsData(TableDef.MS_USER.Column.PASSWORD).ToString = Trim(Me.PASSWORD.Text) Then
                wFlag = True
                MS_USER = AppModule.SetRsData(RsData, MS_USER)
            End If
        End If
        RsData.Close()
        Session.Item(SessionDef.MS_USER) = MS_USER
        Session.Item(SessionDef.LoginID) = MS_USER.LOGIN_ID

        '該当データがない場合はエラー
        If wFlag = False Then
            CmnModule.AlertMessage(MessageDef.Error.Login, Me)
            Return False
        End If

        '利用停止フラグ="1"のユーザはログイン不可
        If MS_USER.STOP_FLG = AppConst.STOP_FLG.Code.Stop Then
            CmnModule.AlertMessage(MessageDef.Error.StopUser, Me)
            Return False
        End If

        Return True
    End Function

    '[ログイン]
    Protected Sub BtnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        '入力値チェック
        If Not Check() Then Exit Sub

        'メニューへ
        Response.Redirect(URL.Menu)
    End Sub

End Class
