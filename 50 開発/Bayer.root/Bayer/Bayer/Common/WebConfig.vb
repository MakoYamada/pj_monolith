Public Class WebConfig

    Public Class Mail
        'メール関連
        Public Shared SMTP As String = System.Configuration.ConfigurationManager.AppSettings("SMTP")
        Public Shared Toptour As String = System.Configuration.ConfigurationManager.AppSettings("MailToptour")
        Public Shared Send As String = System.Configuration.ConfigurationManager.AppSettings("MailSend")
        Public Shared DomainPC As String = System.Configuration.ConfigurationManager.AppSettings("DomainPC")
        Public Shared DomainKeitai As String = System.Configuration.ConfigurationManager.AppSettings("DomainKeitai")
        Public Shared AlertMail As String = System.Configuration.ConfigurationManager.AppSettings("AlertMail")
    End Class

    Public Class Site
        'サイト
        Public Shared URL As String = System.Configuration.ConfigurationManager.AppSettings("URL")
        Public Shared Company As String = System.Configuration.ConfigurationManager.AppSettings("Company")
        Public Shared EventName As String = System.Configuration.ConfigurationManager.AppSettings("EventName")
        Public Shared DEMOSITE As String = System.Configuration.ConfigurationManager.AppSettings("DEMOSITE")

        'メンテナンス
        Public Shared Maintenance As String = System.Configuration.ConfigurationManager.AppSettings("Maintenance")
        '日
        Public Shared OpenDay As String = System.Configuration.ConfigurationManager.AppSettings("OpenDay")
        Public Shared CloseDay As String = System.Configuration.ConfigurationManager.AppSettings("CloseDay")
        Public Shared CloseDay_INSERT As String = System.Configuration.ConfigurationManager.AppSettings("CloseDay_INSERT")
        Public Shared CloseDay_HOTEL As String = System.Configuration.ConfigurationManager.AppSettings("CloseDay_HOTEL")
        Public Shared CloseDay_KOTSU As String = System.Configuration.ConfigurationManager.AppSettings("CloseDay_KOTSU")
    End Class

    Public Class Db
        'DB
        Public Shared ConnectionString As String = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")
    End Class

    Public Class Login
        'ID、パスワード
        Public Shared DR_ACCESS_ID As String = System.Configuration.ConfigurationManager.AppSettings("DR_ACCESS_ID")
        Public Shared DR_ACCESS_PW As String = System.Configuration.ConfigurationManager.AppSettings("DR_ACCESS_PW")
        Public Const C_DR_ACCESS_ID As String = "アクセス用ログインID"
        Public Const C_DR_ACCESS_PW As String = "アクセス用パスワード"

        Public Shared MEMBER_ACCESS_ID As String = System.Configuration.ConfigurationManager.AppSettings("MEMBER_ACCESS_ID")
        Public Shared MEMBER_ACCESS_PW As String = System.Configuration.ConfigurationManager.AppSettings("MEMBER_ACCESS_PW")
        Public Const C_MEMBER_ACCESS_ID As String = "アクセス用ログインID"
        Public Const C_MEMBER_ACCESS_PW As String = "アクセス用パスワード"

        Public Shared TOPTOUR_ID As String = System.Configuration.ConfigurationManager.AppSettings("TOPTOUR_ID")
        Public Shared TOPTOUR_PW As String = System.Configuration.ConfigurationManager.AppSettings("TOPTOUR_PW")
        Public Const C_TOPTOUR_ID As String = "管理者ID"
        Public Const C_TOPTOUR_PW As String = "管理者パスワード"

        Public Shared MANAGE_ID As String = System.Configuration.ConfigurationManager.AppSettings("MANAGE_ID")
        Public Shared MANAGE_PW As String = System.Configuration.ConfigurationManager.AppSettings("MANAGE_PW")
        Public Const C_MANAGE_ID As String = "事務局ID"
        Public Const C_MANAGE_PW As String = "事務局パスワード"
    End Class

    Public Class Path
        'フォルダ
        Public Shared Doc As String = System.Configuration.ConfigurationManager.AppSettings("DocPath")
        Public Shared Csv As String = System.Configuration.ConfigurationManager.AppSettings("CsvPath")
    End Class

End Class