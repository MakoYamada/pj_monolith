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
        'Public Shared SEISAN_CSV As String = System.Configuration.ConfigurationManager.AppSettings("SEISAN_CSV")
        'Public Shared SEISAN_CSV_BK As String = System.Configuration.ConfigurationManager.AppSettings("SEISAN_CSV_BK")
        Public Shared SEISAN_AUTO_CSV As String = System.Configuration.ConfigurationManager.AppSettings("SEISAN_AUTO_CSV")
        Public Shared SEISAN_AUTO_CSV_BK As String = System.Configuration.ConfigurationManager.AppSettings("SEISAN_AUTO_CSV_BK")

        'チケット類送付状
        Public Shared AISATSU1 As String = System.Configuration.ConfigurationManager.AppSettings("AISATSU1")
        Public Shared AISATSU2 As String = System.Configuration.ConfigurationManager.AppSettings("AISATSU2")
        Public Shared AISATSU3 As String = System.Configuration.ConfigurationManager.AppSettings("AISATSU3")
        Public Shared OTHER_SETSUMEI1 As String = System.Configuration.ConfigurationManager.AppSettings("OTHER_SETSUMEI1")
        Public Shared OTHER_SETSUMEI2 As String = System.Configuration.ConfigurationManager.AppSettings("OTHER_SETSUMEI2")
        Public Shared FOOTER_SETSUMEI1 As String = System.Configuration.ConfigurationManager.AppSettings("FOOTER_SETSUMEI1")
        Public Shared FOOTER_SETSUMEI2 As String = System.Configuration.ConfigurationManager.AppSettings("FOOTER_SETSUMEI2")
        Public Shared FOOTER_SETSUMEI3 As String = System.Configuration.ConfigurationManager.AppSettings("FOOTER_SETSUMEI3")
        Public Shared FOOTER_SETSUMEI4 As String = System.Configuration.ConfigurationManager.AppSettings("FOOTER_SETSUMEI4")
    End Class

    Public Class Db
        'DB
        Public Shared ConnectionString As String = System.Configuration.ConfigurationManager.AppSettings("ConnectionString")
    End Class

    Public Class Path
        Public Shared TaxiPrintCsv As String = System.Configuration.ConfigurationManager.AppSettings("TaxiPrintCsv")
        Public Shared TaxiPrintCsv_BackUp As String = System.Configuration.ConfigurationManager.AppSettings("TaxiPrintCsv_BackUp")
    End Class

End Class
