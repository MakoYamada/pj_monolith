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
     
End Class
