﻿Imports CommonLib
Imports AppLib
Public Class URL
    Public Shared SorryPage As String = WebConfig.Site.URL & "Sorry.html"
    Public Shared MaintenancePage As String = WebConfig.Site.URL & "Maintenance.html"
    Public Shared ComingSoonPage As String = WebConfig.Site.URL & "ComingSoon.html"
    Public Shared ClosePage As String = WebConfig.Site.URL & "Close.html"
    Public Shared TimeOut As String = WebConfig.Site.URL & "TimeOut.html"

    Public Shared Login As String = WebConfig.Site.URL & "Login.aspx"
    Public Shared Menu As String = WebConfig.Site.URL & "Menu.aspx"
    '@@@ Phase2 TEST START
    Public Shared MenuPhase2 As String = WebConfig.Site.URL & "Menu_Phase2.aspx"
    '@@@ Phase2 TEST END
    Public Shared NewKouenkaiList As String = WebConfig.Site.URL & "NewKouenkaiList.aspx"
    Public Shared NewKaijoList As String = WebConfig.Site.URL & "NewKaijoList.aspx"
    Public Shared NewDrList As String = WebConfig.Site.URL & "NewDrList.aspx"
    Public Shared NewDrCsv As String = WebConfig.Site.URL & "NewDrCsv.aspx"
    Public Shared KouenkaiList As String = WebConfig.Site.URL & "KouenkaiList.aspx"
    Public Shared KouenkaiRegist As String = WebConfig.Site.URL & "KouenkaiRegist.aspx"
    Public Shared KouenkaiRireki As String = WebConfig.Site.URL & "KouenkaiRireki.aspx"
    Public Shared KaijoList As String = WebConfig.Site.URL & "KaijoList.aspx"
    Public Shared KaijoRegist As String = WebConfig.Site.URL & "KaijoRegist.aspx"
    Public Shared KaijoRireki As String = WebConfig.Site.URL & "KaijoRireki.aspx"
    Public Shared Preview As String = WebConfig.Site.URL & "Preview.aspx"
    Public Shared DrList As String = WebConfig.Site.URL & "DrList.aspx"
    Public Shared DrRegist As String = WebConfig.Site.URL & "DrRegist.aspx"
    Public Shared DrRireki As String = WebConfig.Site.URL & "DrRireki.aspx"
    Public Shared HotelKensaku As String = WebConfig.Site.URL & "HotelKensaku.aspx"
    Public Shared ShisetsuKensaku As String = WebConfig.Site.URL & "ShisetsuKensaku.aspx"
    Public Shared MstShisetsu As String = WebConfig.Site.URL & "admin/MstShisetsu.aspx"
    Public Shared MstUser As String = WebConfig.Site.URL & "admin/MstUser.aspx"
    Public Shared MstCode As String = WebConfig.Site.URL & "admin/MstCode.aspx"
    Public Shared LogFile As String = WebConfig.Site.URL & "admin/LogFile.aspx"
    Public Shared LogSousa As String = WebConfig.Site.URL & "admin/LogSousa.aspx"
    Public Shared LogManual As String = WebConfig.Site.URL & "admin/LogManual.aspx"

    Public Shared SeisanKensaku As String = WebConfig.Site.URL & "SeisanKensaku.aspx"
    Public Shared SeisanList As String = WebConfig.Site.URL & "SeisanList.aspx"
    Public Shared SeisanRegist As String = WebConfig.Site.URL & "SeisanRegist.aspx"
    Public Shared SeisanMaintenance As String = WebConfig.Site.URL & "SeisanMaintenance.aspx"
    Public Shared CostRegist As String = WebConfig.Site.URL & "CostRegist.aspx"
    Public Shared SapCsv As String = WebConfig.Site.URL & "SapCsv.aspx"
    Public Shared SapCsvTop As String = WebConfig.Site.URL & "SapCsvTop.aspx"
    '@@@ Phase2
    Public Shared BunsekiCsv As String = WebConfig.Site.URL & "BunsekiCsv.aspx"
    Public Shared KaigouHiyouCsv As String = WebConfig.Site.URL & "KaigouHiyouCsv.aspx"
    Public Shared SankashaRyohiCsv As String = WebConfig.Site.URL & "SankashaRyohiCsv.aspx"
    Public Shared MRRyohiCsv As String = WebConfig.Site.URL & "MRRyohiCsv.aspx"
    Public Shared TaxiJissekiCsv As String = WebConfig.Site.URL & "TaxiJissekiCsv.aspx"
    '@@@ Phase2

    Public Shared TaxiMenu As String = WebConfig.Site.URL & "TaxiMenu.aspx"
    Public Shared TaxiNouhinTorikomi As String = WebConfig.Site.URL & "TaxiNouhinTorikomi.aspx"
    Public Shared TaxiPrintCsv As String = WebConfig.Site.URL & "TaxiPrintCsv.aspx"
    Public Shared TaxiScan As String = WebConfig.Site.URL & "TaxiScan.aspx"
    Public Shared TaxiMaintenance As String = WebConfig.Site.URL & "TaxiMaintenance.aspx"
    Public Shared TaxiMaintenanceRegist As String = WebConfig.Site.URL & "TaxiMaintenanceRegist.aspx"
    Public Shared TaxiJisseki As String = WebConfig.Site.URL & "TaxiJisseki.aspx"
    Public Shared TaxiSeisanMikanryou As String = WebConfig.Site.URL & "TaxiSeisanMikanryou.aspx"
    Public Shared TaxiMiketsu As String = WebConfig.Site.URL & "TaxiMiketsu.aspx"
    Public Shared TaxiMiketsuRegist As String = WebConfig.Site.URL & "TaxiMiketsuRegist.aspx"
    Public Shared TaxiMeisaiCsv As String = WebConfig.Site.URL & "TaxiMeisaiCsv.aspx"
    Public Shared TaxiMeisaiCsv2 As String = WebConfig.Site.URL & "TaxiMeisaiCsv2.aspx"
    Public Shared TaxiMikanryou As String = WebConfig.Site.URL & "TaxiMikanryou.aspx"
    Public Shared TaxiJissekiMiseisanCsv As String = WebConfig.Site.URL & "TaxiJissekiMiseisanCsv.aspx"
    Public Shared TaxiSoufujoIkkatsu As String = WebConfig.Site.URL & "TaxiSoufujoIkkatsu.aspx"
    Public Shared TaxiJissekiOTH As String = WebConfig.Site.URL & "TaxiJissekiOTH.aspx"

    '@@@ 20170317 Add Start
    Public Shared TaxiSeisanAuto As String = WebConfig.Site.URL & "TaxiSeisanAuto.aspx"
    Public Shared TaxiSeisanAutoCsv As String = WebConfig.Site.URL & "TaxiSeisanAutoCsv.aspx"
    Public Shared SeisanshoAuto As String = WebConfig.Site.URL & "SeisanshoAuto.aspx"
    Public Shared TaxiSeisanToNozomi As String = WebConfig.Site.URL & "TaxiSeisanToNozomi.aspx"
    Public Shared SetTicketSend As String = WebConfig.Site.URL & "SetTicketSend.aspx"
    Public Shared TaxiDaicho As String = WebConfig.Site.URL & "TaxiDaichoDLUL.aspx"
    '@@@ 20170317 Add End
End Class
