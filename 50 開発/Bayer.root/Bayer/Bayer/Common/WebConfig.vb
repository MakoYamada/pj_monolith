Public Class WebConfig

    Public Class Site
        'サイト        Public Shared URL As String = System.Configuration.ConfigurationManager.AppSettings("URL")
        Public Shared SystemName As String = System.Configuration.ConfigurationManager.AppSettings("SystemName")

        'メンテナンス
        Public Shared Maintenance As String = System.Configuration.ConfigurationManager.AppSettings("Maintenance")

        'ヘッダ部文言
        Public Shared HeaderComment1 As String = System.Configuration.ConfigurationManager.AppSettings("HeaderComment1")
        Public Shared HeaderComment2 As String = System.Configuration.ConfigurationManager.AppSettings("HeaderComment2")

        '未収入金滞留理由報告書
        Public Shared JIGYOSHO As String = System.Configuration.ConfigurationManager.AppSettings("JIGYOSHO")
        Public Shared DANTAI_NAME As String = System.Configuration.ConfigurationManager.AppSettings("DANTAI_NAME")
        Public Shared KAMOKU_CODE As String = System.Configuration.ConfigurationManager.AppSettings("KAMOKU_CODE")
        Public Shared RIYU As String = System.Configuration.ConfigurationManager.AppSettings("RIYU")

        'タクチケ関連
        Public Shared NOUHIN_CSV As String = System.Configuration.ConfigurationManager.AppSettings("NOUHIN_CSV")
        Public Shared NOUHIN_CSV_BK As String = System.Configuration.ConfigurationManager.AppSettings("NOUHIN_CSV_BK")
        Public Shared JISSEKI_CSV As String = System.Configuration.ConfigurationManager.AppSettings("JISSEKI_CSV")
        Public Shared JISSEKI_CSV_BK As String = System.Configuration.ConfigurationManager.AppSettings("JISSEKI_CSV_BK")
        Public Shared SCAN_CSV As String = System.Configuration.ConfigurationManager.AppSettings("SCAN_CSV")
        Public Shared SCAN_CSV_BK As String = System.Configuration.ConfigurationManager.AppSettings("SCAN_CSV_BK")

    End Class

    Public Class Db
        'DB
        Public Shared ConnectionString As String = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")
    End Class

End Class