﻿Public Class WebConfig

    Public Class Site
        'サイト        Public Shared URL As String = System.Configuration.ConfigurationManager.AppSettings("URL")
        Public Shared SystemName As String = System.Configuration.ConfigurationManager.AppSettings("SystemName")

        'メンテナンス
        Public Shared Maintenance As String = System.Configuration.ConfigurationManager.AppSettings("Maintenance")
     End Class

    Public Class Db
        'DB
        Public Shared ConnectionString As String = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")
    End Class

End Class