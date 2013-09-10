Public Class URL

    Public Class Site
        Private Shared SiteUrl As String = System.Configuration.ConfigurationManager.AppSettings("URL")
        Public Shared SorryPage As String = SiteUrl & "Sorry.html"
        Public Shared MaintenancePage As String = SiteUrl & "Maintenance.html"
        Public Shared ComingSoonPage As String = SiteUrl & "ComingSoon.html"
        Public Shared ClosePage As String = SiteUrl & "Close.html"
        Public Shared ArrivalList As String = System.Configuration.ConfigurationManager.AppSettings("URL_ArrivalList")
    End Class

    Public Class Dr
        Private Shared SiteUrl As String = System.Configuration.ConfigurationManager.AppSettings("URL")
        Public Shared Top As String = SiteUrl & "Top.aspx"
        Public Shared Guide As String = SiteUrl & "Guide.aspx"
        Public Shared SearchShisetsu As String = SiteUrl & "SearchShisetsu.aspx"
        Public Shared DrInfoRegist As String = SiteUrl & "DrInfoRegist.aspx"
        Public Shared DrInfoConfirm As String = SiteUrl & "DrInfoConfirm.aspx"
        Public Shared DrInfoRegistEnd As String = SiteUrl & "DrInfoRegistEnd.aspx"
        Public Shared PasswordRemain As String = SiteUrl & "PasswordRemain.aspx"
        Public Shared Login As String = SiteUrl & "Login.aspx"
        Public Shared PaymentLogin As String = SiteUrl & "Payment/Login.aspx"
        Public Shared DrRegist As String = SiteUrl & "DrRegist.aspx"
        Public Shared DrData As String = SiteUrl & "DrData.aspx"
        Public Shared Payment As String = SiteUrl & "Payment.aspx"
        Public Shared Card As String = SiteUrl & "Card.aspx"
        Public Shared CardConfirm As String = SiteUrl & "CardConfirm.aspx"
        Public Shared CardEnd As String = SiteUrl & "CardEnd.aspx"
        Public Shared BillName As String = SiteUrl & "BillName.aspx"
        Public Shared Bill As String = SiteUrl & "Bill.aspx"
        Public Shared DrConfirm As String = SiteUrl & "DrConfirm.aspx"
        Public Shared DrRegistEnd As String = SiteUrl & "DrRegistEnd.aspx"
        Public Shared TimeOut As String = SiteUrl & "TimeOut.html"
        Public Shared TimeOutPayment As String = SiteUrl & "TimeOutPayment.html"
        Public Shared TimeOutDialog As String = SiteUrl & "TimeOutD.html"
    End Class

    Public Class Member
        Private Shared SiteUrl As String = System.Configuration.ConfigurationManager.AppSettings("URL")
        Public Shared Top As String = SiteUrl & "Regist/Top.aspx"
        Public Shared Guide As String = SiteUrl & "Guide2.aspx"
        Public Shared Login As String = SiteUrl & "Login2.aspx"
        Public Shared PasswordRemain As String = SiteUrl & "PasswordRemain2.aspx"
        Public Shared Menu As String = SiteUrl & "Menu2.aspx"
        Public Shared DrList As String = SiteUrl & "DrList2.aspx"
        Public Shared Payment As String = SiteUrl & "Payment2.aspx"
        Public Shared BillName As String = SiteUrl & "BillName2.aspx"
        Public Shared Bill As String = SiteUrl & "Bill2.aspx"
        Public Shared DrRegist As String = SiteUrl & "DrRegist2.aspx"
        Public Shared Card As String = SiteUrl & "Card2.aspx"
        Public Shared CardConfirm As String = SiteUrl & "CardConfirm2.aspx"
        Public Shared CardEnd As String = SiteUrl & "CardEnd2.aspx"
        Public Shared DrConfirm As String = SiteUrl & "DrConfirm2.aspx"
        Public Shared DrData As String = SiteUrl & "DrData2.aspx"
        Public Shared DrRegistEnd As String = SiteUrl & "DrRegistEnd2.aspx"
        Public Shared MemberInfoRegist As String = SiteUrl & "MemberInfoRegist2.aspx"
        Public Shared MemberInfoConfirm As String = SiteUrl & "MemberInfoConfirm2.aspx"
        Public Shared MemberInfoRegistEnd As String = SiteUrl & "MemberInfoRegistEnd2.aspx"
        Public Shared TimeOut As String = SiteUrl & "TimeOut2.html"
    End Class

    Public Class Admin
        Private Shared SiteUrl As String = System.Configuration.ConfigurationManager.AppSettings("URL") & "Admin/"
        Public Shared Login As String = SiteUrl & "Login.aspx"
        Public Shared Menu As String = SiteUrl & "Menu.aspx"
        Public Shared Count As String = SiteUrl & "Count.aspx"
        Public Shared DrSearchList As String = SiteUrl & "DrSearchList.aspx"
        Public Shared MemberInfoSearchList As String = SiteUrl & "MemberInfoSearchList.aspx"
        Public Shared DrList As String = SiteUrl & "DrList.aspx"
        Public Shared DrCancelList As String = SiteUrl & "DrCancelList.aspx"
        Public Shared MemberInput As String = SiteUrl & "MemberInput.aspx"
        Public Shared DrRegist As String = SiteUrl & "DrRegist.aspx"
        Public Shared DrRegistEnd As String = SiteUrl & "DrRegistEnd.aspx"
        Public Shared DrTehaiList As String = SiteUrl & "DrTehaiList.aspx"
        Public Shared DrTehai As String = SiteUrl & "DrTehai.aspx"
        Public Shared DrTehaiEnd As String = SiteUrl & "DrTehaiEnd.aspx"
        Public Shared MemberInfoList As String = SiteUrl & "MemberInfoList.aspx"
        Public Shared MemberInfoRegist As String = SiteUrl & "MemberInfoRegist.aspx"
        Public Shared MemberInfoRegistEnd As String = SiteUrl & "MemberInfoRegistEnd.aspx"
        Public Shared DrInfoList As String = SiteUrl & "DrInfoList.aspx"
        Public Shared DrInfoRegist As String = SiteUrl & "DrInfoRegist.aspx"
        Public Shared DrInfoRegistEnd As String = SiteUrl & "DrInfoRegistEnd.aspx"
        Public Shared BillName As String = SiteUrl & "BillName.aspx"
        Public Shared Bill As String = SiteUrl & "Bill.aspx"
        Public Shared PayList As String = SiteUrl & "PayList.aspx"
        Public Shared UnPaidList As String = SiteUrl & "UnPaidList.aspx"
        Public Shared PayRegist As String = SiteUrl & "PayRegist.aspx"
        Public Shared PayRegistEnd As String = SiteUrl & "PayRegistEnd.aspx"
        Public Shared Shisetsu As String = SiteUrl & "Shisetsu.aspx"
        Public Shared ShisetsuEnd As String = SiteUrl & "ShisetsuEnd.aspx"
        Public Shared TimeOut As String = SiteUrl & "TimeOut.html"
    End Class

    Public Class Keiri
        Private Shared SiteUrl As String = System.Configuration.ConfigurationManager.AppSettings("URL") & "Admin/"
        Public Shared Login As String = SiteUrl & "Login.aspx"
        Public Shared Menu As String = SiteUrl & "MenuK.aspx"
        Public Shared PayList As String = SiteUrl & "PayListK.aspx"
        Public Shared UnPaidList As String = SiteUrl & "UnPaidListK.aspx"
        Public Shared PayRegist As String = SiteUrl & "PayRegistK.aspx"
        Public Shared PayRegistEnd As String = SiteUrl & "PayRegistEndK.aspx"
        Public Shared TimeOut As String = SiteUrl & "TimeOut.html"
    End Class

    Public Class Manage
        Private Shared SiteUrl As String = System.Configuration.ConfigurationManager.AppSettings("URL") & "Manage/"
        Public Shared Login As String = SiteUrl & "Login.aspx"
        Public Shared [Select] As String = SiteUrl & "Select.aspx"
        Public Shared Count As String = SiteUrl & "Count.aspx"
        Public Shared Search As String = SiteUrl & "Search.aspx"
        Public Shared DrList As String = SiteUrl & "DrList.aspx"
        Public Shared DrCancelList As String = SiteUrl & "DrCancelList.aspx"
        Public Shared DrData As String = SiteUrl & "DrData.aspx"
        Public Shared MrList As String = SiteUrl & "MrList.aspx"
        Public Shared MrCancelList As String = SiteUrl & "MrCancelList.aspx"
        Public Shared MrData As String = SiteUrl & "MrData.aspx"
        Public Shared MemberInfoList As String = SiteUrl & "MemberInfoList.aspx"
        Public Shared MemberInfoData As String = SiteUrl & "MemberInfoData.aspx"
        Public Shared TimeOut As String = SiteUrl & "TimeOut.html"
    End Class

End Class
