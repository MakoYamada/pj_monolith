﻿Public Class SessionDef
    'セッション変数名 定義
    Public Const TBL_KOUENKAI As String = "TBL_KOUENKAI"
    Public Const TBL_SEIKYU As String = "TBL_SEIKYU"
    Public Const TBL_KOTSUHOTEL As String = "TBL_KOTSUHOTEL"
    Public Const TBL_KAIJO As String = "TBL_KAIJO"
    Public Const TBL_BENTO As String = "TBL_BENTO"
    Public Const TBL_COST As String = "TBL_COST"
    Public Const TBL_LOG As String = "TBL_LOG"
    Public Const TBL_TAXITICKET_HAKKO As String = "TBL_TAXITICKET_HAKKO"
    Public Const MS_USER As String = "MS_USER"
    Public Const MS_COSTCENTER As String = "MS_COSTCENTER"
    Public Const MS_SHISETSU As String = "MS_SHISETSU"
    Public Const MS_JIGYOSHO As String = "MS_JIGYOSHO"
    Public Const MS_AREA As String = "MS_AREA"
    Public Const MS_EIGYOSHO As String = "MS_EIGYOSHO"
    Public Const MS_CODE As String = "MS_CODE"
    Public Const RECORD_KUBUN As String = "RECORD_KUBUN"
    Public Const SEQ As String = "SEQ"
    Public Const PageIndex As String = "PageIndex"
    Public Const BackURL As String = "BackURL"
    Public Const BackURL2 As String = "BackURL2"
    Public Const DbError As String = "DbError"
    Public Const LoginID As String = "LoginID"
    Public Const Joken As String = "Joken"
    Public Const SYSTEM_ID As String = "SYSTEM_ID"
    Public Const DrRireki As String = "DrRireki"
    Public Const DrRireki_TBL_KOTSUHOTEL As String = "DrRireki_TBL_KOTSUHOTEL"
    Public Const DrRireki_TBL_KOUENKAI As String = "DrRireki_TBL_KOUENKAI"
    Public Const DrRireki_SEQ As String = "DrRireki_SEQ"
    Public Const DrRireki_PageIndex As String = "DrRireki_PageIndex"
    Public Const DrPrint_SQL As String = "DrPrint_SQL"
    Public Const DrRirekiPrint_SQL As String = "DrRirekiPrint_SQL"
    Public Const NewDrPrint_SQL As String = "NewDrPrint_SQL"
    Public Const TehaishoPrint_SQL As String = "TehaishoPrint_SQL"
    Public Const KouenkaiRireki As String = "KouenkaiRireki"
    Public Const KouenkaiRireki_TBL_KOUENKAI As String = "KouenkaiRireki_TBL_KOUENKAI"
    Public Const KouenkaiRireki_SEQ As String = "KouenkaiRireki_SEQ"
    Public Const KouenkaiRireki_PageIndex As String = "KouenkaiRireki_PageIndex"
    Public Const KouenkaiRirekiPrint_SQL As String = "KouenkaiRirekiPrint_SQL"
    Public Const KouenkaiPrint_SQL As String = "KouenkaiPrint_SQL"
    Public Const NewKouenkaiPrint_SQL As String = "NewKouenkaiPrint_SQL"
    Public Const KaijoRireki As String = "KaijoRireki"
    Public Const KaijoRireki_TBL_KAIJO As String = "KaijoRireki_TBL_KAIJO"
    Public Const KaijoRireki_SEQ As String = "KaijoRireki_SEQ"
    Public Const KaijoRireki_PageIndex As String = "KaijoRireki_PageIndex"
    Public Const KaijoRireki_Joken As String = "KaijoRireki_Joken"
    Public Const KaijoPrint_SQL As String = "KaijoPrint_SQL"
    Public Const BackURL_Print As String = "BackURL_Print"
    Public Const HotelKensaku_ZIP As String = "HotelKensaku_ZIP"
    Public Const HotelKensaku_ADDRESS1 As String = "HotelKensaku_ADDRESS1"
    Public Const HotelKensaku_ADDRESS2 As String = "HotelKensaku_ADDRESS2"
    Public Const HotelKensaku_SHISETSU_NAME As String = "HotelKensaku_SHISETSU_NAME"
    Public Const HotelKensaku_SHISETSU_KANA As String = "HotelKensaku_SHISETSU_KANA"
    Public Const HotelKensaku_ADDRESS As String = "HotelKensaku_ADDRESS"
    Public Const HotelKensaku_TEL As String = "HotelKensaku_TEL"
    Public Const HotelKensaku_CHECKIN_TIME As String = "HotelKensaku_CHECKIN_TIME"
    Public Const HotelKensaku_CHECKOUT_TIME As String = "HotelKensaku_CHECKOUT_TIME"
    Public Const HotelKensaku_URL As String = "HotelKensaku_URL"
    Public Const HotelKensaku_Back As String = "HotelKensaku_Back"
    Public Const ShisetsuKensaku_ZIP As String = "ShisetsuKensaku_ZIP"
    Public Const ShisetsuKensaku_ADDRESS1 As String = "ShisetsuKensaku_ADDRESS1"
    Public Const ShisetsuKensaku_ADDRESS2 As String = "ShisetsuKensaku_ADDRESS2"
    Public Const ShisetsuKensaku_SHISETSU_NAME As String = "ShisetsuKensaku_SHISETSU_NAME"
    Public Const ShisetsuKensaku_SHISETSU_KANA As String = "ShisetsuKensaku_SHISETSU_KANA"
    Public Const ShisetsuKensaku_ADDRESS As String = "ShisetsuKensaku_ADDRESS"
    Public Const ShisetsuKensaku_TEL As String = "ShisetsuKensaku_TEL"
    Public Const ShisetsuKensaku_URL As String = "ShisetsuKensaku_URL"
    Public Const ShisetsuKensaku_Back As String = "ShisetsuKensaku_Back"
    Public Const SeisanKensaku_SEQ As String = "SeisanKensaku_SEQ"
    Public Const SeisanKensaku_PageIndex As String = "SeisanKensaku_PageIndex"
    Public Const SeisanKensaku_Joken As String = "SeisanKensaku_Joken"
    Public Const SeisanListPrint_SQL As String = "SeisanListPrint_SQL"
    Public Const SeisanRegistReport_SQL As String = "SeisanRegistReport_SQL"
    Public Const CostRegist_Search As String = "CostRegist_Search"
    Public Const CostRegist_Update As String = "CostRegist_Update"
    Public Const MishuHoukoku_SQL As String = "MishuHoukoku_SQL"
    Public Const PrintPreview As String = "PrintPreview"
    Public Const MstCode As String = "MstCode"
    Public Const MstUser As String = "MstUser"
    Public Const OldTBL_KAIJO As String = "OldTBL_KAIJO"
    Public Const OldTBL_KOTSUHOTEL As String = "OldTBL_KOTSUHOTEL"
End Class
