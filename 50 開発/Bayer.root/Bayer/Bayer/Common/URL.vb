Imports CommonLib
Imports AppLib
Public Class URL

    Public Shared SorryPage As String = WebConfig.Site.URL & "Sorry.html"
    Public Shared MaintenancePage As String = WebConfig.Site.URL & "Maintenance.html"
    Public Shared ComingSoonPage As String = WebConfig.Site.URL & "ComingSoon.html"
    Public Shared ClosePage As String = WebConfig.Site.URL & "Close.html"
    Public Shared TimeOut As String = WebConfig.Site.URL & "TimeOut.html"

    Public Shared Login As String = WebConfig.Site.URL & "Login.aspx"
    Public Shared Menu As String = WebConfig.Site.URL & "Menu.aspx"
    Public Shared NewKouenList As String = WebConfig.Site.URL & "NewKouenList.aspx"
    Public Shared NewKaijoList As String = WebConfig.Site.URL & "NewKaijoList.aspx"
    Public Shared KouenList As String = WebConfig.Site.URL & "KouenList.aspx"
    Public Shared KaijoList As String = WebConfig.Site.URL & "KaijoList.aspx"
    Public Shared KaijoRegist As String = WebConfig.Site.URL & "KaijoRegist.aspx"
    Public Shared Preview As String = WebConfig.Site.URL & "Preview.aspx"

End Class
