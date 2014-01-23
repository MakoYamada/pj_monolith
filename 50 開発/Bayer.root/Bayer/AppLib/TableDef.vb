Public Class TableDef

    Public Class TBL_KOUENKAI
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public TIME_STAMP As String
            Public TORIKESHI_FLG As String
            Public KIDOKU_FLG As String
            Public KOUENKAI_TITLE As String
            Public KOUENKAI_NAME As String
            Public TAXI_PRT_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public KAIJO_NAME As String
            Public SEIHIN_NAME As String
            Public INTERNAL_ORDER_T As String
            Public INTERNAL_ORDER_TF As String
            Public ACCOUNT_CD_T As String
            Public ACCOUNT_CD_TF As String
            Public ZETIA_CD As String
            Public SANKA_YOTEI_CNT_NMBR As String
            Public SANKA_YOTEI_CNT_MBR As String
            Public SRM_HACYU_KBN As String
            Public BU As String
            Public KIKAKU_TANTO_JIGYOUBU As String
            Public KIKAKU_TANTO_AREA As String
            Public KIKAKU_TANTO_EIGYOSHO As String
            Public KIKAKU_TANTO_NAME As String
            Public KIKAKU_TANTO_ROMA As String
            Public KIKAKU_TANTO_EMAIL_PC As String
            Public KIKAKU_TANTO_EMAIL_KEITAI As String
            Public KIKAKU_TANTO_KEITAI As String
            Public KIKAKU_TANTO_TEL As String
            Public COST_CENTER As String
            Public TEHAI_TANTO_BU As String
            Public TEHAI_TANTO_AREA As String
            Public TEHAI_TANTO_EIGYOSHO As String
            Public TEHAI_TANTO_NAME As String
            Public TEHAI_TANTO_ROMA As String
            Public TEHAI_TANTO_EMAIL_PC As String
            Public TEHAI_TANTO_EMAIL_KEITAI As String
            Public TEHAI_TANTO_KEITAI As String
            Public TEHAI_TANTO_TEL As String
            Public YOSAN_TF As String
            Public YOSAN_T As String
            Public IROUKAI_YOSAN_T As String
            Public IKENKOUKAN_YOSAN_T As String
            Public DANTAI_CODE As String
            Public TTEHAI_TANTO As String
            Public SEND_FLAG As String
            Public TTANTO_ID As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String

            Public TEHAI_ID As String
            Public REQ_STATUS_TEHAI As String
            Public ANS_STATUS_TEHAI As String
            Public TIME_STAMP_BYL As String
            Public TIME_STAMP_TOP As String
            Public SHONIN_NAME As String
            Public SHONIN_DATE As String
            Public KAISAI_DATE_NOTE As String
            Public KAISAI_KIBOU_ADDRESS1 As String
            Public KAISAI_KIBOU_ADDRESS2 As String
            Public KAISAI_KIBOU_NOTE As String
            Public KOUEN_TIME1 As String
            Public KOUEN_TIME2 As String
            Public KOUEN_KAIJO_LAYOUT As String
            Public IKENKOUKAN_KAIJO_TEHAI As String
            Public IROUKAI_KAIJO_TEHAI As String
            Public IROUKAI_SANKA_YOTEI_CNT As String
            Public KOUSHI_ROOM_TEHAI As String
            Public SHAIN_ROOM_TEHAI As String
            Public MANAGER_KAIJO_TEHAI As String
            Public KAIJO_URL As String
            Public OTHER_NOTE As String
            Public ANS_SENTEI_RIYU As String
            Public ANS_MITSUMORI_TF As String
            Public ANS_MITSUMORI_T As String
            Public ANS_MITSUMORI_TOTAL As String
            Public ANS_MITSUMORI_URL As String
            Public ANS_SHISETSU_NAME As String
            Public ANS_SHISETSU_ZIP As String
            Public ANS_SHISETSU_ADDRESS As String
            Public ANS_SHISETSU_TEL As String
            Public ANS_SHISETSU_URL As String
            Public ANS_KOUEN_KAIJO_NAME As String
            Public ANS_KOUEN_KAIJO_FLOOR As String
            Public ANS_IKENKOUKAN_KAIJO_NAME As String
            Public ANS_IROUKAI_KAIJO_NAME As String
            Public ANS_KOUSHI_ROOM_NAME As String
            Public ANS_SHAIN_ROOM_NAME As String
            Public ANS_MANAGER_KAIJO_NAME As String
            Public ANS_KAISAI_NOTE As String
            Public ANS_SEISAN_TF As String
            Public ANS_SEISAN_T As String
            Public ANS_SEISANSHO_URL As String
            Public FROM_DATE_YM As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const TIME_STAMP As String = "TIME_STAMP"
            Public Const TORIKESHI_FLG As String = "TORIKESHI_FLG"
            Public Const KIDOKU_FLG As String = "KIDOKU_FLG"
            Public Const KOUENKAI_TITLE As String = "KOUENKAI_TITLE"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const TAXI_PRT_NAME As String = "TAXI_PRT_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const KAIJO_NAME As String = "KAIJO_NAME"
            Public Const SEIHIN_NAME As String = "SEIHIN_NAME"
            Public Const INTERNAL_ORDER_T As String = "INTERNAL_ORDER_T"
            Public Const INTERNAL_ORDER_TF As String = "INTERNAL_ORDER_TF"
            Public Const ACCOUNT_CD_T As String = "ACCOUNT_CD_T"
            Public Const ACCOUNT_CD_TF As String = "ACCOUNT_CD_TF"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const SANKA_YOTEI_CNT_NMBR As String = "SANKA_YOTEI_CNT_NMBR"
            Public Const SANKA_YOTEI_CNT_MBR As String = "SANKA_YOTEI_CNT_MBR"
            Public Const SRM_HACYU_KBN As String = "SRM_HACYU_KBN"
            Public Const BU As String = "BU"
            Public Const KIKAKU_TANTO_JIGYOUBU As String = "KIKAKU_TANTO_JIGYOUBU"
            Public Const KIKAKU_TANTO_AREA As String = "KIKAKU_TANTO_AREA"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "KIKAKU_TANTO_EIGYOSHO"
            Public Const KIKAKU_TANTO_NAME As String = "KIKAKU_TANTO_NAME"
            Public Const KIKAKU_TANTO_ROMA As String = "KIKAKU_TANTO_ROMA"
            Public Const KIKAKU_TANTO_EMAIL_PC As String = "KIKAKU_TANTO_EMAIL_PC"
            Public Const KIKAKU_TANTO_EMAIL_KEITAI As String = "KIKAKU_TANTO_EMAIL_KEITAI"
            Public Const KIKAKU_TANTO_KEITAI As String = "KIKAKU_TANTO_KEITAI"
            Public Const KIKAKU_TANTO_TEL As String = "KIKAKU_TANTO_TEL"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const TEHAI_TANTO_BU As String = "TEHAI_TANTO_BU"
            Public Const TEHAI_TANTO_AREA As String = "TEHAI_TANTO_AREA"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "TEHAI_TANTO_EIGYOSHO"
            Public Const TEHAI_TANTO_NAME As String = "TEHAI_TANTO_NAME"
            Public Const TEHAI_TANTO_ROMA As String = "TEHAI_TANTO_ROMA"
            Public Const TEHAI_TANTO_EMAIL_PC As String = "TEHAI_TANTO_EMAIL_PC"
            Public Const TEHAI_TANTO_EMAIL_KEITAI As String = "TEHAI_TANTO_EMAIL_KEITAI"
            Public Const TEHAI_TANTO_KEITAI As String = "TEHAI_TANTO_KEITAI"
            Public Const TEHAI_TANTO_TEL As String = "TEHAI_TANTO_TEL"
            Public Const YOSAN_TF As String = "YOSAN_TF"
            Public Const YOSAN_T As String = "YOSAN_T"
            Public Const IROUKAI_YOSAN_T As String = "IROUKAI_YOSAN_T"
            Public Const IKENKOUKAN_YOSAN_T As String = "IKENKOUKAN_YOSAN_T"
            Public Const DANTAI_CODE As String = "DANTAI_CODE"
            Public Const TTEHAI_TANTO As String = "TTEHAI_TANTO"
            Public Const SEND_FLAG As String = "SEND_FLAG"
            Public Const TTANTO_ID As String = "TTANTO_ID"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"

            Public Const TEHAI_ID As String = "TEHAI_ID"
            Public Const REQ_STATUS_TEHAI As String = "REQ_STATUS_TEHAI"
            Public Const ANS_STATUS_TEHAI As String = "ANS_STATUS_TEHAI"
            Public Const TIME_STAMP_BYL As String = "TIME_STAMP_BYL"
            Public Const TIME_STAMP_TOP As String = "TIME_STAMP_TOP"
            Public Const SHONIN_NAME As String = "SHONIN_NAME"
            Public Const SHONIN_DATE As String = "SHONIN_DATE"
            Public Const KAISAI_DATE_NOTE As String = "KAISAI_DATE_NOTE"
            Public Const KAISAI_KIBOU_ADDRESS1 As String = "KAISAI_KIBOU_ADDRESS1"
            Public Const KAISAI_KIBOU_ADDRESS2 As String = "KAISAI_KIBOU_ADDRESS2"
            Public Const KAISAI_KIBOU_NOTE As String = "KAISAI_KIBOU_NOTE"
            Public Const KOUEN_TIME1 As String = "KOUEN_TIME1"
            Public Const KOUEN_TIME2 As String = "KOUEN_TIME2"
            Public Const KOUEN_KAIJO_LAYOUT As String = "KOUEN_KAIJO_LAYOUT"
            Public Const IKENKOUKAN_KAIJO_TEHAI As String = "IKENKOUKAN_KAIJO_TEHAI"
            Public Const IROUKAI_KAIJO_TEHAI As String = "IROUKAI_KAIJO_TEHAI"
            Public Const IROUKAI_SANKA_YOTEI_CNT As String = "IROUKAI_SANKA_YOTEI_CNT"
            Public Const KOUSHI_ROOM_TEHAI As String = "KOUSHI_ROOM_TEHAI"
            Public Const SHAIN_ROOM_TEHAI As String = "SHAIN_ROOM_TEHAI"
            Public Const MANAGER_KAIJO_TEHAI As String = "MANAGER_KAIJO_TEHAI"
            Public Const KAIJO_URL As String = "KAIJO_URL"
            Public Const OTHER_NOTE As String = "OTHER_NOTE"
            Public Const ANS_SENTEI_RIYU As String = "ANS_SENTEI_RIYU"
            Public Const ANS_MITSUMORI_TF As String = "ANS_MITSUMORI_TF"
            Public Const ANS_MITSUMORI_T As String = "ANS_MITSUMORI_T"
            Public Const ANS_MITSUMORI_TOTAL As String = "ANS_MITSUMORI_TOTAL"
            Public Const ANS_MITSUMORI_URL As String = "ANS_MITSUMORI_URL"
            Public Const ANS_SHISETSU_NAME As String = "ANS_SHISETSU_NAME"
            Public Const ANS_SHISETSU_ZIP As String = "ANS_SHISETSU_ZIP"
            Public Const ANS_SHISETSU_ADDRESS As String = "ANS_SHISETSU_ADDRESS"
            Public Const ANS_SHISETSU_TEL As String = "ANS_SHISETSU_TEL"
            Public Const ANS_SHISETSU_URL As String = "ANS_SHISETSU_URL"
            Public Const ANS_KOUEN_KAIJO_NAME As String = "ANS_KOUEN_KAIJO_NAME"
            Public Const ANS_KOUEN_KAIJO_FLOOR As String = "ANS_KOUEN_KAIJO_FLOOR"
            Public Const ANS_IKENKOUKAN_KAIJO_NAME As String = "ANS_IKENKOUKAN_KAIJO_NAME"
            Public Const ANS_IROUKAI_KAIJO_NAME As String = "ANS_IROUKAI_KAIJO_NAME"
            Public Const ANS_KOUSHI_ROOM_NAME As String = "ANS_KOUSHI_ROOM_NAME"
            Public Const ANS_SHAIN_ROOM_NAME As String = "ANS_SHAIN_ROOM_NAME"
            Public Const ANS_MANAGER_KAIJO_NAME As String = "ANS_MANAGER_KAIJO_NAME"
            Public Const ANS_KAISAI_NOTE As String = "ANS_KAISAI_NOTE"
            Public Const ANS_SEISAN_TF As String = "ANS_SEISAN_TF"
            Public Const ANS_SEISAN_T As String = "ANS_SEISAN_T"
            Public Const ANS_SEISANSHO_URL As String = "ANS_SEISANSHO_URL"
            Public Const FROM_DATE_YM As String = "FROM_DATE_YM"
        End Class
        Public Class Name
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const TIME_STAMP As String = "Timestamp(BYL)"
            Public Const TORIKESHI_FLG As String = "取消フラグ"
            Public Const KIDOKU_FLG As String = "既読フラグ"
            Public Const KOUENKAI_TITLE As String = "タイトル"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const TAXI_PRT_NAME As String = "講演会名(チケット印字用)"
            Public Const FROM_DATE As String = "講演会開催日From"
            Public Const TO_DATE As String = "講演会開催日To"
            Public Const KAIJO_NAME As String = "講演会会場名"
            Public Const SEIHIN_NAME As String = "製品名"
            Public Const INTERNAL_ORDER_T As String = "Internal order(課税)"
            Public Const INTERNAL_ORDER_TF As String = "Internal order(非課税)"
            Public Const ACCOUNT_CD_T As String = "Account Code(課税)"
            Public Const ACCOUNT_CD_TF As String = "Account Code(非課税)"
            Public Const ZETIA_CD As String = "Zetia Code"
            Public Const SANKA_YOTEI_CNT_NMBR As String = "参加予定数(従業員以外)"
            Public Const SANKA_YOTEI_CNT_MBR As String = "参加予定数(従業員)"
            Public Const SRM_HACYU_KBN As String = "SRM発注区分"
            Public Const BU As String = "BU(企画担当者)"
            Public Const KIKAKU_TANTO_JIGYOUBU As String = "事業部(企画担当者)"
            Public Const KIKAKU_TANTO_AREA As String = "エリア(企画担当者)"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "営業所(企画担当者)"
            Public Const KIKAKU_TANTO_NAME As String = "担当者(企画担当者)名"
            Public Const KIKAKU_TANTO_ROMA As String = "担当者(企画担当者)名(ローマ字)"
            Public Const KIKAKU_TANTO_EMAIL_PC As String = "Emailアドレス(企画担当者)"
            Public Const KIKAKU_TANTO_EMAIL_KEITAI As String = "携帯のアドレス(企画担当者)"
            Public Const KIKAKU_TANTO_KEITAI As String = "携帯電話番号(企画担当者)"
            Public Const KIKAKU_TANTO_TEL As String = "オフィスの電話番号(企画担当者)"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const TEHAI_TANTO_BU As String = "BU(手配担当者)"
            Public Const TEHAI_TANTO_AREA As String = "エリア(手配担当者)"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "営業所(手配担当者)"
            Public Const TEHAI_TANTO_NAME As String = "担当者(手配担当者)名"
            Public Const TEHAI_TANTO_ROMA As String = "担当者(手配担当者)名(ローマ字)"
            Public Const TEHAI_TANTO_EMAIL_PC As String = "Emailアドレス(手配担当者)"
            Public Const TEHAI_TANTO_EMAIL_KEITAI As String = "携帯のアドレス(手配担当者)"
            Public Const TEHAI_TANTO_KEITAI As String = "携帯電話番号(手配担当者)"
            Public Const TEHAI_TANTO_TEL As String = "オフィスの電話番号(手配担当者)"
            Public Const YOSAN_TF As String = "予算額_非課税"
            Public Const YOSAN_T As String = "予算額_課税"
            Public Const IROUKAI_YOSAN_T As String = "慰労会予算_課税"
            Public Const IKENKOUKAN_YOSAN_T As String = "意見交換会予算_課税"
            Public Const DANTAI_CODE As String = "団体コード"
            Public Const TTEHAI_TANTO As String = "トップツアー担当者ID"
            Public Const SEND_FLAG As String = "送信フラグ"
            Public Const TTANTO_ID As String = "トップツアー更新担当者ID"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class TBL_SEIKYU
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public SHIHARAI_NO As String
            Public SEISAN_YM As String
            Public SHOUNIN_KUBUN As String
            Public SHOUNIN_DATE As String
            Public KAIJOHI_TF As String
            Public KIZAIHI_TF As String
            Public INSHOKUHI_TF As String
            Public KEI_991330401_TF As String
            Public HOTELHI_TF As String
            Public HOTELHI_TOZEI As String
            Public JR_TF As String
            Public AIR_TF As String
            Public OTHER_TRAFFIC_TF As String
            Public TAXI_TF As String
            Public HOTEL_COMMISSION_TF As String
            Public TAXI_COMMISSION_TF As String
            Public TAXI_SEISAN_TF As String
            Public JINKENHI_TF As String
            Public OTHER_TF As String
            Public KANRIHI_TF As String
            Public KEI_41120200_TF As String
            Public KEI_TF As String
            Public KAIJOUHI_T As String
            Public KIZAIHI_T As String
            Public INSHOKUHI_T As String
            Public KEI_991330401_T As String
            Public JINKENHI_T As String
            Public OTHER_T As String
            Public KANRIHI_T As String
            Public KEI_41120200_T As String
            Public KEI_T As String
            Public SEIKYU_NO_TOPTOUR As String
            Public TAXI_T As String
            Public TAXI_SEISAN_T As String
            Public SEISANSHO_URL As String
            Public TAXI_TICKET_URL As String
            Public SEISAN_KANRYO As String
            Public MR_JR As String
            Public MR_HOTEL As String
            Public MR_HOTEL_TOZEI As String
            Public SEND_FLAG As String
            Public TTANTO_ID As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String

            Public KOUENKAI_NAME As String
            Public FROM_DATE As String
            Public SANKASHA_ID As String
            Public DR_CD As String
            Public DR_NAME As String
            Public MR_NAME As String
            Public COST_CENTER As String
            Public INTERNAL_ORDER_T As String
            Public INTERNAL_ORDER_TF As String
            Public ACCOUNT_CD_T As String
            Public ACCOUNT_CD_TF As String
            Public ZETIA_CD As String
            Public SRM_HACYU_KBN As String
            Public ROW_NO As String
            Public TO_DATE As String
            Public DANTAI_CODE As String
            Public KIKAKU_TANTO_NAME As String
            Public BU As String
            Public KIKAKU_TANTO_AREA As String
            Public KIKAKU_TANTO_EIGYOSHO As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const SHIHARAI_NO As String = "SHIHARAI_NO"
            Public Const SEISAN_YM As String = "SEISAN_YM"
            Public Const SHOUNIN_KUBUN As String = "SHOUNIN_KUBUN"
            Public Const SHOUNIN_DATE As String = "SHOUNIN_DATE"
            Public Const KAIJOHI_TF As String = "KAIJOHI_TF"
            Public Const KIZAIHI_TF As String = "KIZAIHI_TF"
            Public Const INSHOKUHI_TF As String = "INSHOKUHI_TF"
            Public Const KEI_991330401_TF As String = "KEI_991330401_TF"
            Public Const HOTELHI_TF As String = "HOTELHI_TF"
            Public Const HOTELHI_TOZEI As String = "HOTELHI_TOZEI"
            Public Const JR_TF As String = "JR_TF"
            Public Const AIR_TF As String = "AIR_TF"
            Public Const OTHER_TRAFFIC_TF As String = "OTHER_TRAFFIC_TF"
            Public Const TAXI_TF As String = "TAXI_TF"
            Public Const HOTEL_COMMISSION_TF As String = "HOTEL_COMMISSION_TF"
            Public Const TAXI_COMMISSION_TF As String = "TAXI_COMMISSION_TF"
            Public Const TAXI_SEISAN_TF As String = "TAXI_SEISAN_TF"
            Public Const JINKENHI_TF As String = "JINKENHI_TF"
            Public Const OTHER_TF As String = "OTHER_TF"
            Public Const KANRIHI_TF As String = "KANRIHI_TF"
            Public Const KEI_41120200_TF As String = "KEI_41120200_TF"
            Public Const KEI_TF As String = "KEI_TF"
            Public Const KAIJOUHI_T As String = "KAIJOUHI_T"
            Public Const KIZAIHI_T As String = "KIZAIHI_T"
            Public Const INSHOKUHI_T As String = "INSHOKUHI_T"
            Public Const KEI_991330401_T As String = "KEI_991330401_T"
            Public Const JINKENHI_T As String = "JINKENHI_T"
            Public Const OTHER_T As String = "OTHER_T"
            Public Const KANRIHI_T As String = "KANRIHI_T"
            Public Const KEI_41120200_T As String = "KEI_41120200_T"
            Public Const KEI_T As String = "KEI_T"
            Public Const SEIKYU_NO_TOPTOUR As String = "SEIKYU_NO_TOPTOUR"
            Public Const TAXI_T As String = "TAXI_T"
            Public Const TAXI_SEISAN_T As String = "TAXI_SEISAN_T"
            Public Const SEISANSHO_URL As String = "SEISANSHO_URL"
            Public Const TAXI_TICKET_URL As String = "TAXI_TICKET_URL"
            Public Const SEISAN_KANRYO As String = "SEISAN_KANRYO"
            Public Const MR_JR As String = "MR_JR"
            Public Const MR_HOTEL As String = "MR_HOTEL"
            Public Const MR_HOTEL_TOZEI As String = "MR_HOTEL_TOZEI"
            Public Const SEND_FLAG As String = "SEND_FLAG"
            Public Const TTANTO_ID As String = "TTANTO_ID"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"

            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const SANKASHA_ID As String = "SANKASHA_ID"
            Public Const DR_CD As String = "DR_CD"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const MR_NAME As String = "MR_NAME"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const INTERNAL_ORDER_T As String = "INTERNAL_ORDER_T"
            Public Const INTERNAL_ORDER_TF As String = "INTERNAL_ORDER_TF"
            Public Const ACCOUNT_CD_T As String = "ACCOUNT_CD_T"
            Public Const ACCOUNT_CD_TF As String = "ACCOUNT_CD_TF"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const SRM_HACYU_KBN As String = "SRM_HACYU_KBN"
            Public Const ROW_NO As String = "ROW_NO"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const DANTAI_CODE As String = "DANTAI_CODE"
            Public Const KIKAKU_TANTO_NAME As String = "KIKAKU_TANTO_NAME"
            Public Const BU As String = "BU"
            Public Const KIKAKU_TANTO_AREA As String = "KIKAKU_TANTO_AREA"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "KIKAKU_TANTO_EIGYOSHO"
        End Class
        Public Class Name
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const SHIHARAI_NO As String = "支払番号"
            Public Const SEISAN_YM As String = "トップツアー精算年月"
            Public Const SHOUNIN_KUBUN As String = "承認区分"
            Public Const SHOUNIN_DATE As String = "精算承認日"
            Public Const KAIJOHI_TF As String = "会場費(非課税)991330401"
            Public Const KIZAIHI_TF As String = "機材費(非課税)991330401"
            Public Const INSHOKUHI_TF As String = "飲食費(非課税)991330401"
            Public Const KEI_991330401_TF As String = "991330401(非課税)小計"
            Public Const HOTELHI_TF As String = "宿泊費(非課税)41120200"
            Public Const HOTELHI_TOZEI As String = "宿泊費都税（非課税） 41120200"
            Public Const JR_TF As String = "JR代(非課税)41120200"
            Public Const AIR_TF As String = "航空券代(非課税)41120200"
            Public Const OTHER_TRAFFIC_TF As String = "その他鉄道等費用(非課税)41120200"
            Public Const TAXI_TF As String = "タクチケ実車料金(非課税)41120200"
            Public Const HOTEL_COMMISSION_TF As String = "登録手数料(非課税)41120200"
            Public Const TAXI_COMMISSION_TF As String = "タクチケ発券手数料(非課税)41120200"
            Public Const TAXI_SEISAN_TF As String = "タクチケ精算手数料 (非課税)41120200"
            Public Const JINKENHI_TF As String = "人件費(非課税)41120200"
            Public Const OTHER_TF As String = "その他費(非課税)41120200"
            Public Const KANRIHI_TF As String = "管理費(非課税)41120200"
            Public Const KEI_41120200_TF As String = "41120200(非課税)小計"
            Public Const KEI_TF As String = "非課税金額合計"
            Public Const KAIJOUHI_T As String = "会場費(課税)991330401"
            Public Const KIZAIHI_T As String = "機材費(課税)991330401"
            Public Const INSHOKUHI_T As String = "飲食費(課税)991330401"
            Public Const KEI_991330401_T As String = "991330401(課税)小計"
            Public Const JINKENHI_T As String = "人件費(課税)41120200"
            Public Const OTHER_T As String = "その他費(課税)41120200"
            Public Const KANRIHI_T As String = "管理費(課税)41120200"
            Public Const KEI_41120200_T As String = "41120200(課税)小計"
            Public Const KEI_T As String = "課税金額合計"
            Public Const SEIKYU_NO_TOPTOUR As String = "精算番号"
            Public Const TAXI_T As String = "タクチケ実車料金(課税)"
            Public Const TAXI_SEISAN_T As String = "タクチケ精算手数料(課税)"
            Public Const SEISANSHO_URL As String = "精算書保存場所URL"
            Public Const TAXI_TICKET_URL As String = "タクチケ管理表保存場所URL"
            Public Const SEISAN_KANRYO As String = "精算完了"
            Public Const MR_JR As String = "社員の国内旅費(JR/航空券)"
            Public Const MR_HOTEL As String = "社員の国内旅費(宿泊)"
            Public Const MR_HOTEL_TOZEI As String = "社員の国内旅費(宿泊都税)"
            Public Const SEND_FLAG As String = "送信フラグ"
            Public Const TTANTO_ID As String = "トップツアー担当者ID"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"

            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const FROM_DATE As String = "開催日FROM"
            Public Const SANKASHA_ID As String = "参加者ID"
            Public Const DR_CD As String = "DRコード"
            Public Const DR_NAME As String = "DR氏名"
            Public Const MR_NAME As String = "担当者(担当MR)名"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const INTERNAL_ORDER_T As String = "Internal order(課税)"
            Public Const INTERNAL_ORDER_TF As String = "Internal order(非課税)"
            Public Const ACCOUNT_CD_T As String = "Account Code(課税)"
            Public Const ACCOUNT_CD_TF As String = "Account Code(非課税)"
            Public Const ZETIA_CD As String = "Zetia Code"
            Public Const SRM_HACYU_KBN As String = "SRM発注区分"
            Public Const TO_DATE As String = "講演会開催日To"
            Public Const DANTAI_CODE As String = "団体コード"
            Public Const KIKAKU_TANTO_NAME As String = "担当者(企画担当者)名"
            Public Const BU As String = "企画担当者BU"
            Public Const KIKAKU_TANTO_AREA As String = "企画担当者エリア"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "企画担当者営業所"
        End Class
    End Class

    Public Class TBL_KOTSUHOTEL
        <Serializable()> Public Structure DataStruct
            Public SALEFORCE_ID As String
            Public SANKASHA_ID As String
            Public KOUENKAI_NO As String
            Public REQ_STATUS_TEHAI As String
            Public ANS_STATUS_TEHAI As String
            Public TIME_STAMP_BYL As String
            Public TIME_STAMP_TOP As String
            Public DR_MPID As String
            Public DR_CD As String
            Public DR_NAME As String
            Public DR_KANA As String
            Public DR_SHISETSU_CD As String
            Public DR_SHISETSU_NAME As String
            Public DR_SHISETSU_ADDRESS As String
            Public DR_YAKUWARI As String
            Public DR_SEX As String
            Public DR_AGE As String
            Public SHITEIGAI_RIYU As String
            Public DR_SANKA As String
            Public MR_BU As String
            Public MR_AREA As String
            Public MR_EIGYOSHO As String
            Public MR_NAME As String
            Public MR_ROMA As String
            Public MR_KANA As String
            Public MR_EMAIL_PC As String
            Public MR_EMAIL_KEITAI As String
            Public MR_KEITAI As String
            Public MR_TEL As String
            Public MR_SEND_SAKI_FS As String
            Public MR_SEND_SAKI_OTHER As String
            Public ACCOUNT_CD As String
            Public COST_CENTER As String
            Public INTERNAL_ORDER As String
            Public ZETIA_CD As String
            Public SHONIN_NAME As String
            Public SHONIN_DATE As String
            Public TEHAI_HOTEL As String
            Public HOTEL_IRAINAIYOU As String
            Public REQ_HOTEL_DATE As String
            Public REQ_HAKUSU As String
            Public REQ_HOTEL_SMOKING As String
            Public REQ_HOTEL_NOTE As String
            Public ANS_STATUS_HOTEL As String
            Public ANS_HOTEL_NAME As String
            Public ANS_HOTEL_ADDRESS As String
            Public ANS_HOTEL_TEL As String
            Public ANS_HOTEL_DATE As String
            Public ANS_HAKUSU As String
            Public ANS_CHECKIN_TIME As String
            Public ANS_CHECKOUT_TIME As String
            Public ANS_ROOM_TYPE As String
            Public ANS_HOTEL_SMOKING As String
            Public ANS_HOTEL_NOTE As String
            Public ANS_HOTELHI As String
            Public ANS_HOTELHI_TOZEI As String
            Public ANS_HOTELHI_CANCEL As String
            Public REQ_O_TEHAI_1 As String
            Public REQ_O_IRAINAIYOU_1 As String
            Public REQ_O_KOTSUKIKAN_1 As String
            Public REQ_O_DATE_1 As String
            Public REQ_O_AIRPORT1_1 As String
            Public REQ_O_AIRPORT2_1 As String
            Public REQ_O_TIME1_1 As String
            Public REQ_O_TIME2_1 As String
            Public REQ_O_BIN_1 As String
            Public REQ_O_SEAT_1 As String
            Public REQ_O_SEAT_KIBOU1 As String
            Public REQ_O_TEHAI_2 As String
            Public REQ_O_IRAINAIYOU_2 As String
            Public REQ_O_KOTSUKIKAN_2 As String
            Public REQ_O_DATE_2 As String
            Public REQ_O_AIRPORT1_2 As String
            Public REQ_O_AIRPORT2_2 As String
            Public REQ_O_TIME1_2 As String
            Public REQ_O_TIME2_2 As String
            Public REQ_O_BIN_2 As String
            Public REQ_O_SEAT_2 As String
            Public REQ_O_SEAT_KIBOU2 As String
            Public REQ_O_TEHAI_3 As String
            Public REQ_O_IRAINAIYOU_3 As String
            Public REQ_O_KOTSUKIKAN_3 As String
            Public REQ_O_DATE_3 As String
            Public REQ_O_AIRPORT1_3 As String
            Public REQ_O_AIRPORT2_3 As String
            Public REQ_O_TIME1_3 As String
            Public REQ_O_TIME2_3 As String
            Public REQ_O_BIN_3 As String
            Public REQ_O_SEAT_3 As String
            Public REQ_O_SEAT_KIBOU3 As String
            Public REQ_O_TEHAI_4 As String
            Public REQ_O_IRAINAIYOU_4 As String
            Public REQ_O_KOTSUKIKAN_4 As String
            Public REQ_O_DATE_4 As String
            Public REQ_O_AIRPORT1_4 As String
            Public REQ_O_AIRPORT2_4 As String
            Public REQ_O_TIME1_4 As String
            Public REQ_O_TIME2_4 As String
            Public REQ_O_BIN_4 As String
            Public REQ_O_SEAT_4 As String
            Public REQ_O_SEAT_KIBOU4 As String
            Public REQ_O_TEHAI_5 As String
            Public REQ_O_IRAINAIYOU_5 As String
            Public REQ_O_KOTSUKIKAN_5 As String
            Public REQ_O_DATE_5 As String
            Public REQ_O_AIRPORT1_5 As String
            Public REQ_O_AIRPORT2_5 As String
            Public REQ_O_TIME1_5 As String
            Public REQ_O_TIME2_5 As String
            Public REQ_O_BIN_5 As String
            Public REQ_O_SEAT_5 As String
            Public REQ_O_SEAT_KIBOU5 As String
            Public REQ_F_TEHAI_1 As String
            Public REQ_F_IRAINAIYOU_1 As String
            Public REQ_F_KOTSUKIKAN_1 As String
            Public REQ_F_DATE_1 As String
            Public REQ_F_AIRPORT1_1 As String
            Public REQ_F_AIRPORT2_1 As String
            Public REQ_F_TIME1_1 As String
            Public REQ_F_TIME2_1 As String
            Public REQ_F_BIN_1 As String
            Public REQ_F_SEAT_1 As String
            Public REQ_F_SEAT_KIBOU1 As String
            Public REQ_F_TEHAI_2 As String
            Public REQ_F_IRAINAIYOU_2 As String
            Public REQ_F_KOTSUKIKAN_2 As String
            Public REQ_F_DATE_2 As String
            Public REQ_F_AIRPORT1_2 As String
            Public REQ_F_AIRPORT2_2 As String
            Public REQ_F_TIME1_2 As String
            Public REQ_F_TIME2_2 As String
            Public REQ_F_BIN_2 As String
            Public REQ_F_SEAT_2 As String
            Public REQ_F_SEAT_KIBOU2 As String
            Public REQ_F_TEHAI_3 As String
            Public REQ_F_IRAINAIYOU_3 As String
            Public REQ_F_KOTSUKIKAN_3 As String
            Public REQ_F_DATE_3 As String
            Public REQ_F_AIRPORT1_3 As String
            Public REQ_F_AIRPORT2_3 As String
            Public REQ_F_TIME1_3 As String
            Public REQ_F_TIME2_3 As String
            Public REQ_F_BIN_3 As String
            Public REQ_F_SEAT_3 As String
            Public REQ_F_SEAT_KIBOU3 As String
            Public REQ_F_TEHAI_4 As String
            Public REQ_F_IRAINAIYOU_4 As String
            Public REQ_F_KOTSUKIKAN_4 As String
            Public REQ_F_DATE_4 As String
            Public REQ_F_AIRPORT1_4 As String
            Public REQ_F_AIRPORT2_4 As String
            Public REQ_F_TIME1_4 As String
            Public REQ_F_TIME2_4 As String
            Public REQ_F_BIN_4 As String
            Public REQ_F_SEAT_4 As String
            Public REQ_F_SEAT_KIBOU4 As String
            Public REQ_F_TEHAI_5 As String
            Public REQ_F_IRAINAIYOU_5 As String
            Public REQ_F_KOTSUKIKAN_5 As String
            Public REQ_F_DATE_5 As String
            Public REQ_F_AIRPORT1_5 As String
            Public REQ_F_AIRPORT2_5 As String
            Public REQ_F_TIME1_5 As String
            Public REQ_F_TIME2_5 As String
            Public REQ_F_BIN_5 As String
            Public REQ_F_SEAT_5 As String
            Public REQ_F_SEAT_KIBOU5 As String
            Public REQ_KOTSU_BIKO As String
            Public ANS_O_STATUS_1 As String
            Public ANS_O_KOTSUKIKAN_1 As String
            Public ANS_O_DATE_1 As String
            Public ANS_O_AIRPORT1_1 As String
            Public ANS_O_AIRPORT2_1 As String
            Public ANS_O_TIME1_1 As String
            Public ANS_O_TIME2_1 As String
            Public ANS_O_BIN_1 As String
            Public ANS_O_SEAT_1 As String
            Public ANS_O_SEAT_KIBOU1 As String
            Public ANS_O_STATUS_2 As String
            Public ANS_O_KOTSUKIKAN_2 As String
            Public ANS_O_DATE_2 As String
            Public ANS_O_AIRPORT1_2 As String
            Public ANS_O_AIRPORT2_2 As String
            Public ANS_O_TIME1_2 As String
            Public ANS_O_TIME2_2 As String
            Public ANS_O_BIN_2 As String
            Public ANS_O_SEAT_2 As String
            Public ANS_O_SEAT_KIBOU2 As String
            Public ANS_O_STATUS_3 As String
            Public ANS_O_KOTSUKIKAN_3 As String
            Public ANS_O_DATE_3 As String
            Public ANS_O_AIRPORT1_3 As String
            Public ANS_O_AIRPORT2_3 As String
            Public ANS_O_TIME1_3 As String
            Public ANS_O_TIME2_3 As String
            Public ANS_O_BIN_3 As String
            Public ANS_O_SEAT_3 As String
            Public ANS_O_SEAT_KIBOU3 As String
            Public ANS_O_STATUS_4 As String
            Public ANS_O_KOTSUKIKAN_4 As String
            Public ANS_O_DATE_4 As String
            Public ANS_O_AIRPORT1_4 As String
            Public ANS_O_AIRPORT2_4 As String
            Public ANS_O_TIME1_4 As String
            Public ANS_O_TIME2_4 As String
            Public ANS_O_BIN_4 As String
            Public ANS_O_SEAT_4 As String
            Public ANS_O_SEAT_KIBOU4 As String
            Public ANS_O_STATUS_5 As String
            Public ANS_O_KOTSUKIKAN_5 As String
            Public ANS_O_DATE_5 As String
            Public ANS_O_AIRPORT1_5 As String
            Public ANS_O_AIRPORT2_5 As String
            Public ANS_O_TIME1_5 As String
            Public ANS_O_TIME2_5 As String
            Public ANS_O_BIN_5 As String
            Public ANS_O_SEAT_5 As String
            Public ANS_O_SEAT_KIBOU5 As String
            Public ANS_F_STATUS_1 As String
            Public ANS_F_KOTSUKIKAN_1 As String
            Public ANS_F_DATE_1 As String
            Public ANS_F_AIRPORT1_1 As String
            Public ANS_F_AIRPORT2_1 As String
            Public ANS_F_TIME1_1 As String
            Public ANS_F_TIME2_1 As String
            Public ANS_F_BIN_1 As String
            Public ANS_F_SEAT_1 As String
            Public ANS_F_SEAT_KIBOU1 As String
            Public ANS_F_STATUS_2 As String
            Public ANS_F_KOTSUKIKAN_2 As String
            Public ANS_F_DATE_2 As String
            Public ANS_F_AIRPORT1_2 As String
            Public ANS_F_AIRPORT2_2 As String
            Public ANS_F_TIME1_2 As String
            Public ANS_F_TIME2_2 As String
            Public ANS_F_BIN_2 As String
            Public ANS_F_SEAT_2 As String
            Public ANS_F_SEAT_KIBOU2 As String
            Public ANS_F_STATUS_3 As String
            Public ANS_F_KOTSUKIKAN_3 As String
            Public ANS_F_DATE_3 As String
            Public ANS_F_AIRPORT1_3 As String
            Public ANS_F_AIRPORT2_3 As String
            Public ANS_F_TIME1_3 As String
            Public ANS_F_TIME2_3 As String
            Public ANS_F_BIN_3 As String
            Public ANS_F_SEAT_3 As String
            Public ANS_F_SEAT_KIBOU3 As String
            Public ANS_F_STATUS_4 As String
            Public ANS_F_KOTSUKIKAN_4 As String
            Public ANS_F_DATE_4 As String
            Public ANS_F_AIRPORT1_4 As String
            Public ANS_F_AIRPORT2_4 As String
            Public ANS_F_TIME1_4 As String
            Public ANS_F_TIME2_4 As String
            Public ANS_F_BIN_4 As String
            Public ANS_F_SEAT_4 As String
            Public ANS_F_SEAT_KIBOU4 As String
            Public ANS_F_STATUS_5 As String
            Public ANS_F_KOTSUKIKAN_5 As String
            Public ANS_F_DATE_5 As String
            Public ANS_F_AIRPORT1_5 As String
            Public ANS_F_AIRPORT2_5 As String
            Public ANS_F_TIME1_5 As String
            Public ANS_F_TIME2_5 As String
            Public ANS_F_BIN_5 As String
            Public ANS_F_SEAT_5 As String
            Public ANS_F_SEAT_KIBOU5 As String
            Public ANS_KOTSU_BIKO As String
            Public ANS_RAIL_FARE As String
            Public ANS_RAIL_CANCELLATION As String
            Public ANS_OTHER_FARE As String
            Public ANS_OTHER_CANCELLATION As String
            Public ANS_AIR_FARE As String
            Public ANS_AIR_CANCELLATION As String
            Public ANS_KOTSUHOTEL_TESURYO As String
            Public ANS_TAXI_TESURYO As String
            Public ANS_TICKET_SEND_DAY As String
            Public TEHAI_TAXI As String
            Public REQ_TAXI_DATE_1 As String
            Public REQ_TAXI_FROM_1 As String
            Public TAXI_YOTEIKINGAKU_1 As String
            Public REQ_TAXI_DATE_2 As String
            Public REQ_TAXI_FROM_2 As String
            Public TAXI_YOTEIKINGAKU_2 As String
            Public REQ_TAXI_DATE_3 As String
            Public REQ_TAXI_FROM_3 As String
            Public TAXI_YOTEIKINGAKU_3 As String
            Public REQ_TAXI_DATE_4 As String
            Public REQ_TAXI_FROM_4 As String
            Public TAXI_YOTEIKINGAKU_4 As String
            Public REQ_TAXI_DATE_5 As String
            Public REQ_TAXI_FROM_5 As String
            Public TAXI_YOTEIKINGAKU_5 As String
            Public REQ_TAXI_DATE_6 As String
            Public REQ_TAXI_FROM_6 As String
            Public TAXI_YOTEIKINGAKU_6 As String
            Public REQ_TAXI_DATE_7 As String
            Public REQ_TAXI_FROM_7 As String
            Public TAXI_YOTEIKINGAKU_7 As String
            Public REQ_TAXI_DATE_8 As String
            Public REQ_TAXI_FROM_8 As String
            Public TAXI_YOTEIKINGAKU_8 As String
            Public REQ_TAXI_DATE_9 As String
            Public REQ_TAXI_FROM_9 As String
            Public TAXI_YOTEIKINGAKU_9 As String
            Public REQ_TAXI_DATE_10 As String
            Public REQ_TAXI_FROM_10 As String
            Public TAXI_YOTEIKINGAKU_10 As String
            Public REQ_TAXI_NOTE As String
            Public ANS_TAXI_DATE_1 As String
            Public ANS_TAXI_KENSHU_1 As String
            Public ANS_TAXI_NO_1 As String
            Public ANS_TAXI_HAKKO_1 As String
            Public ANS_TAXI_HAKKO_DATE_1 As String
            Public ANS_TAXI_RMKS_1 As String
            Public ANS_TAXI_DATE_2 As String
            Public ANS_TAXI_KENSHU_2 As String
            Public ANS_TAXI_NO_2 As String
            Public ANS_TAXI_HAKKO_2 As String
            Public ANS_TAXI_HAKKO_DATE_2 As String
            Public ANS_TAXI_RMKS_2 As String
            Public ANS_TAXI_DATE_3 As String
            Public ANS_TAXI_KENSHU_3 As String
            Public ANS_TAXI_NO_3 As String
            Public ANS_TAXI_HAKKO_3 As String
            Public ANS_TAXI_HAKKO_DATE_3 As String
            Public ANS_TAXI_RMKS_3 As String
            Public ANS_TAXI_DATE_4 As String
            Public ANS_TAXI_KENSHU_4 As String
            Public ANS_TAXI_NO_4 As String
            Public ANS_TAXI_HAKKO_4 As String
            Public ANS_TAXI_HAKKO_DATE_4 As String
            Public ANS_TAXI_RMKS_4 As String
            Public ANS_TAXI_DATE_5 As String
            Public ANS_TAXI_KENSHU_5 As String
            Public ANS_TAXI_NO_5 As String
            Public ANS_TAXI_HAKKO_5 As String
            Public ANS_TAXI_HAKKO_DATE_5 As String
            Public ANS_TAXI_RMKS_5 As String
            Public ANS_TAXI_DATE_6 As String
            Public ANS_TAXI_KENSHU_6 As String
            Public ANS_TAXI_NO_6 As String
            Public ANS_TAXI_HAKKO_6 As String
            Public ANS_TAXI_HAKKO_DATE_6 As String
            Public ANS_TAXI_RMKS_6 As String
            Public ANS_TAXI_DATE_7 As String
            Public ANS_TAXI_KENSHU_7 As String
            Public ANS_TAXI_NO_7 As String
            Public ANS_TAXI_HAKKO_7 As String
            Public ANS_TAXI_HAKKO_DATE_7 As String
            Public ANS_TAXI_RMKS_7 As String
            Public ANS_TAXI_DATE_8 As String
            Public ANS_TAXI_KENSHU_8 As String
            Public ANS_TAXI_NO_8 As String
            Public ANS_TAXI_HAKKO_8 As String
            Public ANS_TAXI_HAKKO_DATE_8 As String
            Public ANS_TAXI_RMKS_8 As String
            Public ANS_TAXI_DATE_9 As String
            Public ANS_TAXI_KENSHU_9 As String
            Public ANS_TAXI_NO_9 As String
            Public ANS_TAXI_HAKKO_9 As String
            Public ANS_TAXI_HAKKO_DATE_9 As String
            Public ANS_TAXI_RMKS_9 As String
            Public ANS_TAXI_DATE_10 As String
            Public ANS_TAXI_KENSHU_10 As String
            Public ANS_TAXI_NO_10 As String
            Public ANS_TAXI_HAKKO_10 As String
            Public ANS_TAXI_HAKKO_DATE_10 As String
            Public ANS_TAXI_RMKS_10 As String
            Public ANS_TAXI_DATE_11 As String
            Public ANS_TAXI_KENSHU_11 As String
            Public ANS_TAXI_NO_11 As String
            Public ANS_TAXI_HAKKO_11 As String
            Public ANS_TAXI_HAKKO_DATE_11 As String
            Public ANS_TAXI_RMKS_11 As String
            Public ANS_TAXI_DATE_12 As String
            Public ANS_TAXI_KENSHU_12 As String
            Public ANS_TAXI_NO_12 As String
            Public ANS_TAXI_HAKKO_12 As String
            Public ANS_TAXI_HAKKO_DATE_12 As String
            Public ANS_TAXI_RMKS_12 As String
            Public ANS_TAXI_DATE_13 As String
            Public ANS_TAXI_KENSHU_13 As String
            Public ANS_TAXI_NO_13 As String
            Public ANS_TAXI_HAKKO_13 As String
            Public ANS_TAXI_HAKKO_DATE_13 As String
            Public ANS_TAXI_RMKS_13 As String
            Public ANS_TAXI_DATE_14 As String
            Public ANS_TAXI_KENSHU_14 As String
            Public ANS_TAXI_NO_14 As String
            Public ANS_TAXI_HAKKO_14 As String
            Public ANS_TAXI_HAKKO_DATE_14 As String
            Public ANS_TAXI_RMKS_14 As String
            Public ANS_TAXI_DATE_15 As String
            Public ANS_TAXI_KENSHU_15 As String
            Public ANS_TAXI_NO_15 As String
            Public ANS_TAXI_HAKKO_15 As String
            Public ANS_TAXI_HAKKO_DATE_15 As String
            Public ANS_TAXI_RMKS_15 As String
            Public ANS_TAXI_DATE_16 As String
            Public ANS_TAXI_KENSHU_16 As String
            Public ANS_TAXI_NO_16 As String
            Public ANS_TAXI_HAKKO_16 As String
            Public ANS_TAXI_HAKKO_DATE_16 As String
            Public ANS_TAXI_RMKS_16 As String
            Public ANS_TAXI_DATE_17 As String
            Public ANS_TAXI_KENSHU_17 As String
            Public ANS_TAXI_NO_17 As String
            Public ANS_TAXI_HAKKO_17 As String
            Public ANS_TAXI_HAKKO_DATE_17 As String
            Public ANS_TAXI_RMKS_17 As String
            Public ANS_TAXI_DATE_18 As String
            Public ANS_TAXI_KENSHU_18 As String
            Public ANS_TAXI_NO_18 As String
            Public ANS_TAXI_HAKKO_18 As String
            Public ANS_TAXI_HAKKO_DATE_18 As String
            Public ANS_TAXI_RMKS_18 As String
            Public ANS_TAXI_DATE_19 As String
            Public ANS_TAXI_KENSHU_19 As String
            Public ANS_TAXI_NO_19 As String
            Public ANS_TAXI_HAKKO_19 As String
            Public ANS_TAXI_HAKKO_DATE_19 As String
            Public ANS_TAXI_RMKS_19 As String
            Public ANS_TAXI_DATE_20 As String
            Public ANS_TAXI_KENSHU_20 As String
            Public ANS_TAXI_NO_20 As String
            Public ANS_TAXI_HAKKO_20 As String
            Public ANS_TAXI_HAKKO_DATE_20 As String
            Public ANS_TAXI_RMKS_20 As String
            Public ANS_TAXI_NOTE As String
            Public REQ_MR_O_TEHAI As String
            Public REQ_MR_F_TEHAI As String
            Public MR_SEX As String
            Public MR_AGE As String
            Public REQ_MR_HOTEL_NOTE As String
            Public ANS_MR_O_TEHAI As String
            Public ANS_MR_F_TEHAI As String
            Public ANS_MR_HOTEL_NOTE As String
            Public ANS_MR_KOTSUHI As String
            Public ANS_MR_HOTELHI As String
            Public ANS_MR_HOTELHI_TOZEI As String
            Public SEND_FLAG As String
            Public TTANTO_ID As String
            Public SEIKYU_NO_TOPTOUR As String
            Public SCAN_IMPORT_DATE As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
            Public SEND_DATE As String

            Public KOUENKAI_NAME As String
            Public KOUENKAI_TIME_STAMP As String
            Public TORIKESHI_FLG As String
            Public TAXI_PRT_NAME As String
            Public KAIJO_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public USER_NAME As String
            Public SEIHIN_NAME As String
            Public TIME_STAMP As String

            Public TKT_LINE_NO_1 As Integer
            Public TKT_LINE_NO_2 As Integer
            Public TKT_LINE_NO_3 As Integer
            Public TKT_LINE_NO_4 As Integer
            Public TKT_LINE_NO_5 As Integer
            Public TKT_LINE_NO_6 As Integer
            Public TKT_LINE_NO_7 As Integer
            Public TKT_LINE_NO_8 As Integer
            Public TKT_LINE_NO_9 As Integer
            Public TKT_LINE_NO_10 As Integer
            Public TKT_LINE_NO_11 As Integer
            Public TKT_LINE_NO_12 As Integer
            Public TKT_LINE_NO_13 As Integer
            Public TKT_LINE_NO_14 As Integer
            Public TKT_LINE_NO_15 As Integer
            Public TKT_LINE_NO_16 As Integer
            Public TKT_LINE_NO_17 As Integer
            Public TKT_LINE_NO_18 As Integer
            Public TKT_LINE_NO_19 As Integer
            Public TKT_LINE_NO_20 As Integer
        End Structure
        Public Class Column
            Public Const SALEFORCE_ID As String = "SALEFORCE_ID"
            Public Const SANKASHA_ID As String = "SANKASHA_ID"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const REQ_STATUS_TEHAI As String = "REQ_STATUS_TEHAI"
            Public Const ANS_STATUS_TEHAI As String = "ANS_STATUS_TEHAI"
            Public Const TIME_STAMP_BYL As String = "TIME_STAMP_BYL"
            Public Const TIME_STAMP_TOP As String = "TIME_STAMP_TOP"
            Public Const DR_MPID As String = "DR_MPID"
            Public Const DR_CD As String = "DR_CD"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const DR_KANA As String = "DR_KANA"
            Public Const DR_SHISETSU_CD As String = "DR_SHISETSU_CD"
            Public Const DR_SHISETSU_NAME As String = "DR_SHISETSU_NAME"
            Public Const DR_SHISETSU_ADDRESS As String = "DR_SHISETSU_ADDRESS"
            Public Const DR_YAKUWARI As String = "DR_YAKUWARI"
            Public Const DR_SEX As String = "DR_SEX"
            Public Const DR_AGE As String = "DR_AGE"
            Public Const SHITEIGAI_RIYU As String = "SHITEIGAI_RIYU"
            Public Const DR_SANKA As String = "DR_SANKA"
            Public Const MR_BU As String = "MR_BU"
            Public Const MR_AREA As String = "MR_AREA"
            Public Const MR_EIGYOSHO As String = "MR_EIGYOSHO"
            Public Const MR_NAME As String = "MR_NAME"
            Public Const MR_ROMA As String = "MR_ROMA"
            Public Const MR_KANA As String = "MR_KANA"
            Public Const MR_EMAIL_PC As String = "MR_EMAIL_PC"
            Public Const MR_EMAIL_KEITAI As String = "MR_EMAIL_KEITAI"
            Public Const MR_KEITAI As String = "MR_KEITAI"
            Public Const MR_TEL As String = "MR_TEL"
            Public Const MR_SEND_SAKI_FS As String = "MR_SEND_SAKI_FS"
            Public Const MR_SEND_SAKI_OTHER As String = "MR_SEND_SAKI_OTHER"
            Public Const ACCOUNT_CD As String = "ACCOUNT_CD"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const INTERNAL_ORDER As String = "INTERNAL_ORDER"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const SHONIN_NAME As String = "SHONIN_NAME"
            Public Const SHONIN_DATE As String = "SHONIN_DATE"
            Public Const TEHAI_HOTEL As String = "TEHAI_HOTEL"
            Public Const HOTEL_IRAINAIYOU As String = "HOTEL_IRAINAIYOU"
            Public Const REQ_HOTEL_DATE As String = "REQ_HOTEL_DATE"
            Public Const REQ_HAKUSU As String = "REQ_HAKUSU"
            Public Const REQ_HOTEL_SMOKING As String = "REQ_HOTEL_SMOKING"
            Public Const REQ_HOTEL_NOTE As String = "REQ_HOTEL_NOTE"
            Public Const ANS_STATUS_HOTEL As String = "ANS_STATUS_HOTEL"
            Public Const ANS_HOTEL_NAME As String = "ANS_HOTEL_NAME"
            Public Const ANS_HOTEL_ADDRESS As String = "ANS_HOTEL_ADDRESS"
            Public Const ANS_HOTEL_TEL As String = "ANS_HOTEL_TEL"
            Public Const ANS_HOTEL_DATE As String = "ANS_HOTEL_DATE"
            Public Const ANS_HAKUSU As String = "ANS_HAKUSU"
            Public Const ANS_CHECKIN_TIME As String = "ANS_CHECKIN_TIME"
            Public Const ANS_CHECKOUT_TIME As String = "ANS_CHECKOUT_TIME"
            Public Const ANS_ROOM_TYPE As String = "ANS_ROOM_TYPE"
            Public Const ANS_HOTEL_SMOKING As String = "ANS_HOTEL_SMOKING"
            Public Const ANS_HOTEL_NOTE As String = "ANS_HOTEL_NOTE"
            Public Const ANS_HOTELHI As String = "ANS_HOTELHI"
            Public Const ANS_HOTELHI_TOZEI As String = "ANS_HOTELHI_TOZEI"
            Public Const ANS_HOTELHI_CANCEL As String = "ANS_HOTELHI_CANCEL"
            Public Const REQ_O_TEHAI_1 As String = "REQ_O_TEHAI_1"
            Public Const REQ_O_IRAINAIYOU_1 As String = "REQ_O_IRAINAIYOU_1"
            Public Const REQ_O_KOTSUKIKAN_1 As String = "REQ_O_KOTSUKIKAN_1"
            Public Const REQ_O_DATE_1 As String = "REQ_O_DATE_1"
            Public Const REQ_O_AIRPORT1_1 As String = "REQ_O_AIRPORT1_1"
            Public Const REQ_O_AIRPORT2_1 As String = "REQ_O_AIRPORT2_1"
            Public Const REQ_O_TIME1_1 As String = "REQ_O_TIME1_1"
            Public Const REQ_O_TIME2_1 As String = "REQ_O_TIME2_1"
            Public Const REQ_O_BIN_1 As String = "REQ_O_BIN_1"
            Public Const REQ_O_SEAT_1 As String = "REQ_O_SEAT_1"
            Public Const REQ_O_SEAT_KIBOU1 As String = "REQ_O_SEAT_KIBOU1"
            Public Const REQ_O_TEHAI_2 As String = "REQ_O_TEHAI_2"
            Public Const REQ_O_IRAINAIYOU_2 As String = "REQ_O_IRAINAIYOU_2"
            Public Const REQ_O_KOTSUKIKAN_2 As String = "REQ_O_KOTSUKIKAN_2"
            Public Const REQ_O_DATE_2 As String = "REQ_O_DATE_2"
            Public Const REQ_O_AIRPORT1_2 As String = "REQ_O_AIRPORT1_2"
            Public Const REQ_O_AIRPORT2_2 As String = "REQ_O_AIRPORT2_2"
            Public Const REQ_O_TIME1_2 As String = "REQ_O_TIME1_2"
            Public Const REQ_O_TIME2_2 As String = "REQ_O_TIME2_2"
            Public Const REQ_O_BIN_2 As String = "REQ_O_BIN_2"
            Public Const REQ_O_SEAT_2 As String = "REQ_O_SEAT_2"
            Public Const REQ_O_SEAT_KIBOU2 As String = "REQ_O_SEAT_KIBOU2"
            Public Const REQ_O_TEHAI_3 As String = "REQ_O_TEHAI_3"
            Public Const REQ_O_IRAINAIYOU_3 As String = "REQ_O_IRAINAIYOU_3"
            Public Const REQ_O_KOTSUKIKAN_3 As String = "REQ_O_KOTSUKIKAN_3"
            Public Const REQ_O_DATE_3 As String = "REQ_O_DATE_3"
            Public Const REQ_O_AIRPORT1_3 As String = "REQ_O_AIRPORT1_3"
            Public Const REQ_O_AIRPORT2_3 As String = "REQ_O_AIRPORT2_3"
            Public Const REQ_O_TIME1_3 As String = "REQ_O_TIME1_3"
            Public Const REQ_O_TIME2_3 As String = "REQ_O_TIME2_3"
            Public Const REQ_O_BIN_3 As String = "REQ_O_BIN_3"
            Public Const REQ_O_SEAT_3 As String = "REQ_O_SEAT_3"
            Public Const REQ_O_SEAT_KIBOU3 As String = "REQ_O_SEAT_KIBOU3"
            Public Const REQ_O_TEHAI_4 As String = "REQ_O_TEHAI_4"
            Public Const REQ_O_IRAINAIYOU_4 As String = "REQ_O_IRAINAIYOU_4"
            Public Const REQ_O_KOTSUKIKAN_4 As String = "REQ_O_KOTSUKIKAN_4"
            Public Const REQ_O_DATE_4 As String = "REQ_O_DATE_4"
            Public Const REQ_O_AIRPORT1_4 As String = "REQ_O_AIRPORT1_4"
            Public Const REQ_O_AIRPORT2_4 As String = "REQ_O_AIRPORT2_4"
            Public Const REQ_O_TIME1_4 As String = "REQ_O_TIME1_4"
            Public Const REQ_O_TIME2_4 As String = "REQ_O_TIME2_4"
            Public Const REQ_O_BIN_4 As String = "REQ_O_BIN_4"
            Public Const REQ_O_SEAT_4 As String = "REQ_O_SEAT_4"
            Public Const REQ_O_SEAT_KIBOU4 As String = "REQ_O_SEAT_KIBOU4"
            Public Const REQ_O_TEHAI_5 As String = "REQ_O_TEHAI_5"
            Public Const REQ_O_IRAINAIYOU_5 As String = "REQ_O_IRAINAIYOU_5"
            Public Const REQ_O_KOTSUKIKAN_5 As String = "REQ_O_KOTSUKIKAN_5"
            Public Const REQ_O_DATE_5 As String = "REQ_O_DATE_5"
            Public Const REQ_O_AIRPORT1_5 As String = "REQ_O_AIRPORT1_5"
            Public Const REQ_O_AIRPORT2_5 As String = "REQ_O_AIRPORT2_5"
            Public Const REQ_O_TIME1_5 As String = "REQ_O_TIME1_5"
            Public Const REQ_O_TIME2_5 As String = "REQ_O_TIME2_5"
            Public Const REQ_O_BIN_5 As String = "REQ_O_BIN_5"
            Public Const REQ_O_SEAT_5 As String = "REQ_O_SEAT_5"
            Public Const REQ_O_SEAT_KIBOU5 As String = "REQ_O_SEAT_KIBOU5"
            Public Const REQ_F_TEHAI_1 As String = "REQ_F_TEHAI_1"
            Public Const REQ_F_IRAINAIYOU_1 As String = "REQ_F_IRAINAIYOU_1"
            Public Const REQ_F_KOTSUKIKAN_1 As String = "REQ_F_KOTSUKIKAN_1"
            Public Const REQ_F_DATE_1 As String = "REQ_F_DATE_1"
            Public Const REQ_F_AIRPORT1_1 As String = "REQ_F_AIRPORT1_1"
            Public Const REQ_F_AIRPORT2_1 As String = "REQ_F_AIRPORT2_1"
            Public Const REQ_F_TIME1_1 As String = "REQ_F_TIME1_1"
            Public Const REQ_F_TIME2_1 As String = "REQ_F_TIME2_1"
            Public Const REQ_F_BIN_1 As String = "REQ_F_BIN_1"
            Public Const REQ_F_SEAT_1 As String = "REQ_F_SEAT_1"
            Public Const REQ_F_SEAT_KIBOU1 As String = "REQ_F_SEAT_KIBOU1"
            Public Const REQ_F_TEHAI_2 As String = "REQ_F_TEHAI_2"
            Public Const REQ_F_IRAINAIYOU_2 As String = "REQ_F_IRAINAIYOU_2"
            Public Const REQ_F_KOTSUKIKAN_2 As String = "REQ_F_KOTSUKIKAN_2"
            Public Const REQ_F_DATE_2 As String = "REQ_F_DATE_2"
            Public Const REQ_F_AIRPORT1_2 As String = "REQ_F_AIRPORT1_2"
            Public Const REQ_F_AIRPORT2_2 As String = "REQ_F_AIRPORT2_2"
            Public Const REQ_F_TIME1_2 As String = "REQ_F_TIME1_2"
            Public Const REQ_F_TIME2_2 As String = "REQ_F_TIME2_2"
            Public Const REQ_F_BIN_2 As String = "REQ_F_BIN_2"
            Public Const REQ_F_SEAT_2 As String = "REQ_F_SEAT_2"
            Public Const REQ_F_SEAT_KIBOU2 As String = "REQ_F_SEAT_KIBOU2"
            Public Const REQ_F_TEHAI_3 As String = "REQ_F_TEHAI_3"
            Public Const REQ_F_IRAINAIYOU_3 As String = "REQ_F_IRAINAIYOU_3"
            Public Const REQ_F_KOTSUKIKAN_3 As String = "REQ_F_KOTSUKIKAN_3"
            Public Const REQ_F_DATE_3 As String = "REQ_F_DATE_3"
            Public Const REQ_F_AIRPORT1_3 As String = "REQ_F_AIRPORT1_3"
            Public Const REQ_F_AIRPORT2_3 As String = "REQ_F_AIRPORT2_3"
            Public Const REQ_F_TIME1_3 As String = "REQ_F_TIME1_3"
            Public Const REQ_F_TIME2_3 As String = "REQ_F_TIME2_3"
            Public Const REQ_F_BIN_3 As String = "REQ_F_BIN_3"
            Public Const REQ_F_SEAT_3 As String = "REQ_F_SEAT_3"
            Public Const REQ_F_SEAT_KIBOU3 As String = "REQ_F_SEAT_KIBOU3"
            Public Const REQ_F_TEHAI_4 As String = "REQ_F_TEHAI_4"
            Public Const REQ_F_IRAINAIYOU_4 As String = "REQ_F_IRAINAIYOU_4"
            Public Const REQ_F_KOTSUKIKAN_4 As String = "REQ_F_KOTSUKIKAN_4"
            Public Const REQ_F_DATE_4 As String = "REQ_F_DATE_4"
            Public Const REQ_F_AIRPORT1_4 As String = "REQ_F_AIRPORT1_4"
            Public Const REQ_F_AIRPORT2_4 As String = "REQ_F_AIRPORT2_4"
            Public Const REQ_F_TIME1_4 As String = "REQ_F_TIME1_4"
            Public Const REQ_F_TIME2_4 As String = "REQ_F_TIME2_4"
            Public Const REQ_F_BIN_4 As String = "REQ_F_BIN_4"
            Public Const REQ_F_SEAT_4 As String = "REQ_F_SEAT_4"
            Public Const REQ_F_SEAT_KIBOU4 As String = "REQ_F_SEAT_KIBOU4"
            Public Const REQ_F_TEHAI_5 As String = "REQ_F_TEHAI_5"
            Public Const REQ_F_IRAINAIYOU_5 As String = "REQ_F_IRAINAIYOU_5"
            Public Const REQ_F_KOTSUKIKAN_5 As String = "REQ_F_KOTSUKIKAN_5"
            Public Const REQ_F_DATE_5 As String = "REQ_F_DATE_5"
            Public Const REQ_F_AIRPORT1_5 As String = "REQ_F_AIRPORT1_5"
            Public Const REQ_F_AIRPORT2_5 As String = "REQ_F_AIRPORT2_5"
            Public Const REQ_F_TIME1_5 As String = "REQ_F_TIME1_5"
            Public Const REQ_F_TIME2_5 As String = "REQ_F_TIME2_5"
            Public Const REQ_F_BIN_5 As String = "REQ_F_BIN_5"
            Public Const REQ_F_SEAT_5 As String = "REQ_F_SEAT_5"
            Public Const REQ_F_SEAT_KIBOU5 As String = "REQ_F_SEAT_KIBOU5"
            Public Const REQ_KOTSU_BIKO As String = "REQ_KOTSU_BIKO"
            Public Const ANS_O_STATUS_1 As String = "ANS_O_STATUS_1"
            Public Const ANS_O_KOTSUKIKAN_1 As String = "ANS_O_KOTSUKIKAN_1"
            Public Const ANS_O_DATE_1 As String = "ANS_O_DATE_1"
            Public Const ANS_O_AIRPORT1_1 As String = "ANS_O_AIRPORT1_1"
            Public Const ANS_O_AIRPORT2_1 As String = "ANS_O_AIRPORT2_1"
            Public Const ANS_O_TIME1_1 As String = "ANS_O_TIME1_1"
            Public Const ANS_O_TIME2_1 As String = "ANS_O_TIME2_1"
            Public Const ANS_O_BIN_1 As String = "ANS_O_BIN_1"
            Public Const ANS_O_SEAT_1 As String = "ANS_O_SEAT_1"
            Public Const ANS_O_SEAT_KIBOU1 As String = "ANS_O_SEAT_KIBOU1"
            Public Const ANS_O_STATUS_2 As String = "ANS_O_STATUS_2"
            Public Const ANS_O_KOTSUKIKAN_2 As String = "ANS_O_KOTSUKIKAN_2"
            Public Const ANS_O_DATE_2 As String = "ANS_O_DATE_2"
            Public Const ANS_O_AIRPORT1_2 As String = "ANS_O_AIRPORT1_2"
            Public Const ANS_O_AIRPORT2_2 As String = "ANS_O_AIRPORT2_2"
            Public Const ANS_O_TIME1_2 As String = "ANS_O_TIME1_2"
            Public Const ANS_O_TIME2_2 As String = "ANS_O_TIME2_2"
            Public Const ANS_O_BIN_2 As String = "ANS_O_BIN_2"
            Public Const ANS_O_SEAT_2 As String = "ANS_O_SEAT_2"
            Public Const ANS_O_SEAT_KIBOU2 As String = "ANS_O_SEAT_KIBOU2"
            Public Const ANS_O_STATUS_3 As String = "ANS_O_STATUS_3"
            Public Const ANS_O_KOTSUKIKAN_3 As String = "ANS_O_KOTSUKIKAN_3"
            Public Const ANS_O_DATE_3 As String = "ANS_O_DATE_3"
            Public Const ANS_O_AIRPORT1_3 As String = "ANS_O_AIRPORT1_3"
            Public Const ANS_O_AIRPORT2_3 As String = "ANS_O_AIRPORT2_3"
            Public Const ANS_O_TIME1_3 As String = "ANS_O_TIME1_3"
            Public Const ANS_O_TIME2_3 As String = "ANS_O_TIME2_3"
            Public Const ANS_O_BIN_3 As String = "ANS_O_BIN_3"
            Public Const ANS_O_SEAT_3 As String = "ANS_O_SEAT_3"
            Public Const ANS_O_SEAT_KIBOU3 As String = "ANS_O_SEAT_KIBOU3"
            Public Const ANS_O_STATUS_4 As String = "ANS_O_STATUS_4"
            Public Const ANS_O_KOTSUKIKAN_4 As String = "ANS_O_KOTSUKIKAN_4"
            Public Const ANS_O_DATE_4 As String = "ANS_O_DATE_4"
            Public Const ANS_O_AIRPORT1_4 As String = "ANS_O_AIRPORT1_4"
            Public Const ANS_O_AIRPORT2_4 As String = "ANS_O_AIRPORT2_4"
            Public Const ANS_O_TIME1_4 As String = "ANS_O_TIME1_4"
            Public Const ANS_O_TIME2_4 As String = "ANS_O_TIME2_4"
            Public Const ANS_O_BIN_4 As String = "ANS_O_BIN_4"
            Public Const ANS_O_SEAT_4 As String = "ANS_O_SEAT_4"
            Public Const ANS_O_SEAT_KIBOU4 As String = "ANS_O_SEAT_KIBOU4"
            Public Const ANS_O_STATUS_5 As String = "ANS_O_STATUS_5"
            Public Const ANS_O_KOTSUKIKAN_5 As String = "ANS_O_KOTSUKIKAN_5"
            Public Const ANS_O_DATE_5 As String = "ANS_O_DATE_5"
            Public Const ANS_O_AIRPORT1_5 As String = "ANS_O_AIRPORT1_5"
            Public Const ANS_O_AIRPORT2_5 As String = "ANS_O_AIRPORT2_5"
            Public Const ANS_O_TIME1_5 As String = "ANS_O_TIME1_5"
            Public Const ANS_O_TIME2_5 As String = "ANS_O_TIME2_5"
            Public Const ANS_O_BIN_5 As String = "ANS_O_BIN_5"
            Public Const ANS_O_SEAT_5 As String = "ANS_O_SEAT_5"
            Public Const ANS_O_SEAT_KIBOU5 As String = "ANS_O_SEAT_KIBOU5"
            Public Const ANS_F_STATUS_1 As String = "ANS_F_STATUS_1"
            Public Const ANS_F_KOTSUKIKAN_1 As String = "ANS_F_KOTSUKIKAN_1"
            Public Const ANS_F_DATE_1 As String = "ANS_F_DATE_1"
            Public Const ANS_F_AIRPORT1_1 As String = "ANS_F_AIRPORT1_1"
            Public Const ANS_F_AIRPORT2_1 As String = "ANS_F_AIRPORT2_1"
            Public Const ANS_F_TIME1_1 As String = "ANS_F_TIME1_1"
            Public Const ANS_F_TIME2_1 As String = "ANS_F_TIME2_1"
            Public Const ANS_F_BIN_1 As String = "ANS_F_BIN_1"
            Public Const ANS_F_SEAT_1 As String = "ANS_F_SEAT_1"
            Public Const ANS_F_SEAT_KIBOU1 As String = "ANS_F_SEAT_KIBOU1"
            Public Const ANS_F_STATUS_2 As String = "ANS_F_STATUS_2"
            Public Const ANS_F_KOTSUKIKAN_2 As String = "ANS_F_KOTSUKIKAN_2"
            Public Const ANS_F_DATE_2 As String = "ANS_F_DATE_2"
            Public Const ANS_F_AIRPORT1_2 As String = "ANS_F_AIRPORT1_2"
            Public Const ANS_F_AIRPORT2_2 As String = "ANS_F_AIRPORT2_2"
            Public Const ANS_F_TIME1_2 As String = "ANS_F_TIME1_2"
            Public Const ANS_F_TIME2_2 As String = "ANS_F_TIME2_2"
            Public Const ANS_F_BIN_2 As String = "ANS_F_BIN_2"
            Public Const ANS_F_SEAT_2 As String = "ANS_F_SEAT_2"
            Public Const ANS_F_SEAT_KIBOU2 As String = "ANS_F_SEAT_KIBOU2"
            Public Const ANS_F_STATUS_3 As String = "ANS_F_STATUS_3"
            Public Const ANS_F_KOTSUKIKAN_3 As String = "ANS_F_KOTSUKIKAN_3"
            Public Const ANS_F_DATE_3 As String = "ANS_F_DATE_3"
            Public Const ANS_F_AIRPORT1_3 As String = "ANS_F_AIRPORT1_3"
            Public Const ANS_F_AIRPORT2_3 As String = "ANS_F_AIRPORT2_3"
            Public Const ANS_F_TIME1_3 As String = "ANS_F_TIME1_3"
            Public Const ANS_F_TIME2_3 As String = "ANS_F_TIME2_3"
            Public Const ANS_F_BIN_3 As String = "ANS_F_BIN_3"
            Public Const ANS_F_SEAT_3 As String = "ANS_F_SEAT_3"
            Public Const ANS_F_SEAT_KIBOU3 As String = "ANS_F_SEAT_KIBOU3"
            Public Const ANS_F_STATUS_4 As String = "ANS_F_STATUS_4"
            Public Const ANS_F_KOTSUKIKAN_4 As String = "ANS_F_KOTSUKIKAN_4"
            Public Const ANS_F_DATE_4 As String = "ANS_F_DATE_4"
            Public Const ANS_F_AIRPORT1_4 As String = "ANS_F_AIRPORT1_4"
            Public Const ANS_F_AIRPORT2_4 As String = "ANS_F_AIRPORT2_4"
            Public Const ANS_F_TIME1_4 As String = "ANS_F_TIME1_4"
            Public Const ANS_F_TIME2_4 As String = "ANS_F_TIME2_4"
            Public Const ANS_F_BIN_4 As String = "ANS_F_BIN_4"
            Public Const ANS_F_SEAT_4 As String = "ANS_F_SEAT_4"
            Public Const ANS_F_SEAT_KIBOU4 As String = "ANS_F_SEAT_KIBOU4"
            Public Const ANS_F_STATUS_5 As String = "ANS_F_STATUS_5"
            Public Const ANS_F_KOTSUKIKAN_5 As String = "ANS_F_KOTSUKIKAN_5"
            Public Const ANS_F_DATE_5 As String = "ANS_F_DATE_5"
            Public Const ANS_F_AIRPORT1_5 As String = "ANS_F_AIRPORT1_5"
            Public Const ANS_F_AIRPORT2_5 As String = "ANS_F_AIRPORT2_5"
            Public Const ANS_F_TIME1_5 As String = "ANS_F_TIME1_5"
            Public Const ANS_F_TIME2_5 As String = "ANS_F_TIME2_5"
            Public Const ANS_F_BIN_5 As String = "ANS_F_BIN_5"
            Public Const ANS_F_SEAT_5 As String = "ANS_F_SEAT_5"
            Public Const ANS_F_SEAT_KIBOU5 As String = "ANS_F_SEAT_KIBOU5"
            Public Const ANS_KOTSU_BIKO As String = "ANS_KOTSU_BIKO"
            Public Const ANS_RAIL_FARE As String = "ANS_RAIL_FARE"
            Public Const ANS_RAIL_CANCELLATION As String = "ANS_RAIL_CANCELLATION"
            Public Const ANS_OTHER_FARE As String = "ANS_OTHER_FARE"
            Public Const ANS_OTHER_CANCELLATION As String = "ANS_OTHER_CANCELLATION"
            Public Const ANS_AIR_FARE As String = "ANS_AIR_FARE"
            Public Const ANS_AIR_CANCELLATION As String = "ANS_AIR_CANCELLATION"
            Public Const ANS_KOTSUHOTEL_TESURYO As String = "ANS_KOTSUHOTEL_TESURYO"
            Public Const ANS_TAXI_TESURYO As String = "ANS_TAXI_TESURYO"
            Public Const ANS_TICKET_SEND_DAY As String = "ANS_TICKET_SEND_DAY"
            Public Const TEHAI_TAXI As String = "TEHAI_TAXI"
            Public Const REQ_TAXI_DATE_1 As String = "REQ_TAXI_DATE_1"
            Public Const REQ_TAXI_FROM_1 As String = "REQ_TAXI_FROM_1"
            Public Const TAXI_YOTEIKINGAKU_1 As String = "TAXI_YOTEIKINGAKU_1"
            Public Const REQ_TAXI_DATE_2 As String = "REQ_TAXI_DATE_2"
            Public Const REQ_TAXI_FROM_2 As String = "REQ_TAXI_FROM_2"
            Public Const TAXI_YOTEIKINGAKU_2 As String = "TAXI_YOTEIKINGAKU_2"
            Public Const REQ_TAXI_DATE_3 As String = "REQ_TAXI_DATE_3"
            Public Const REQ_TAXI_FROM_3 As String = "REQ_TAXI_FROM_3"
            Public Const TAXI_YOTEIKINGAKU_3 As String = "TAXI_YOTEIKINGAKU_3"
            Public Const REQ_TAXI_DATE_4 As String = "REQ_TAXI_DATE_4"
            Public Const REQ_TAXI_FROM_4 As String = "REQ_TAXI_FROM_4"
            Public Const TAXI_YOTEIKINGAKU_4 As String = "TAXI_YOTEIKINGAKU_4"
            Public Const REQ_TAXI_DATE_5 As String = "REQ_TAXI_DATE_5"
            Public Const REQ_TAXI_FROM_5 As String = "REQ_TAXI_FROM_5"
            Public Const TAXI_YOTEIKINGAKU_5 As String = "TAXI_YOTEIKINGAKU_5"
            Public Const REQ_TAXI_DATE_6 As String = "REQ_TAXI_DATE_6"
            Public Const REQ_TAXI_FROM_6 As String = "REQ_TAXI_FROM_6"
            Public Const TAXI_YOTEIKINGAKU_6 As String = "TAXI_YOTEIKINGAKU_6"
            Public Const REQ_TAXI_DATE_7 As String = "REQ_TAXI_DATE_7"
            Public Const REQ_TAXI_FROM_7 As String = "REQ_TAXI_FROM_7"
            Public Const TAXI_YOTEIKINGAKU_7 As String = "TAXI_YOTEIKINGAKU_7"
            Public Const REQ_TAXI_DATE_8 As String = "REQ_TAXI_DATE_8"
            Public Const REQ_TAXI_FROM_8 As String = "REQ_TAXI_FROM_8"
            Public Const TAXI_YOTEIKINGAKU_8 As String = "TAXI_YOTEIKINGAKU_8"
            Public Const REQ_TAXI_DATE_9 As String = "REQ_TAXI_DATE_9"
            Public Const REQ_TAXI_FROM_9 As String = "REQ_TAXI_FROM_9"
            Public Const TAXI_YOTEIKINGAKU_9 As String = "TAXI_YOTEIKINGAKU_9"
            Public Const REQ_TAXI_DATE_10 As String = "REQ_TAXI_DATE_10"
            Public Const REQ_TAXI_FROM_10 As String = "REQ_TAXI_FROM_10"
            Public Const TAXI_YOTEIKINGAKU_10 As String = "TAXI_YOTEIKINGAKU_10"
            Public Const REQ_TAXI_NOTE As String = "REQ_TAXI_NOTE"
            Public Const ANS_TAXI_DATE_1 As String = "ANS_TAXI_DATE_1"
            Public Const ANS_TAXI_KENSHU_1 As String = "ANS_TAXI_KENSHU_1"
            Public Const ANS_TAXI_NO_1 As String = "ANS_TAXI_NO_1"
            Public Const ANS_TAXI_HAKKO_1 As String = "ANS_TAXI_HAKKO_1"
            Public Const ANS_TAXI_HAKKO_DATE_1 As String = "ANS_TAXI_HAKKO_DATE_1"
            Public Const ANS_TAXI_RMKS_1 As String = "ANS_TAXI_RMKS_1"
            Public Const ANS_TAXI_DATE_2 As String = "ANS_TAXI_DATE_2"
            Public Const ANS_TAXI_KENSHU_2 As String = "ANS_TAXI_KENSHU_2"
            Public Const ANS_TAXI_NO_2 As String = "ANS_TAXI_NO_2"
            Public Const ANS_TAXI_HAKKO_2 As String = "ANS_TAXI_HAKKO_2"
            Public Const ANS_TAXI_HAKKO_DATE_2 As String = "ANS_TAXI_HAKKO_DATE_2"
            Public Const ANS_TAXI_RMKS_2 As String = "ANS_TAXI_RMKS_2"
            Public Const ANS_TAXI_DATE_3 As String = "ANS_TAXI_DATE_3"
            Public Const ANS_TAXI_KENSHU_3 As String = "ANS_TAXI_KENSHU_3"
            Public Const ANS_TAXI_NO_3 As String = "ANS_TAXI_NO_3"
            Public Const ANS_TAXI_HAKKO_3 As String = "ANS_TAXI_HAKKO_3"
            Public Const ANS_TAXI_HAKKO_DATE_3 As String = "ANS_TAXI_HAKKO_DATE_3"
            Public Const ANS_TAXI_RMKS_3 As String = "ANS_TAXI_RMKS_3"
            Public Const ANS_TAXI_DATE_4 As String = "ANS_TAXI_DATE_4"
            Public Const ANS_TAXI_KENSHU_4 As String = "ANS_TAXI_KENSHU_4"
            Public Const ANS_TAXI_NO_4 As String = "ANS_TAXI_NO_4"
            Public Const ANS_TAXI_HAKKO_4 As String = "ANS_TAXI_HAKKO_4"
            Public Const ANS_TAXI_HAKKO_DATE_4 As String = "ANS_TAXI_HAKKO_DATE_4"
            Public Const ANS_TAXI_RMKS_4 As String = "ANS_TAXI_RMKS_4"
            Public Const ANS_TAXI_DATE_5 As String = "ANS_TAXI_DATE_5"
            Public Const ANS_TAXI_KENSHU_5 As String = "ANS_TAXI_KENSHU_5"
            Public Const ANS_TAXI_NO_5 As String = "ANS_TAXI_NO_5"
            Public Const ANS_TAXI_HAKKO_5 As String = "ANS_TAXI_HAKKO_5"
            Public Const ANS_TAXI_HAKKO_DATE_5 As String = "ANS_TAXI_HAKKO_DATE_5"
            Public Const ANS_TAXI_RMKS_5 As String = "ANS_TAXI_RMKS_5"
            Public Const ANS_TAXI_DATE_6 As String = "ANS_TAXI_DATE_6"
            Public Const ANS_TAXI_KENSHU_6 As String = "ANS_TAXI_KENSHU_6"
            Public Const ANS_TAXI_NO_6 As String = "ANS_TAXI_NO_6"
            Public Const ANS_TAXI_HAKKO_6 As String = "ANS_TAXI_HAKKO_6"
            Public Const ANS_TAXI_HAKKO_DATE_6 As String = "ANS_TAXI_HAKKO_DATE_6"
            Public Const ANS_TAXI_RMKS_6 As String = "ANS_TAXI_RMKS_6"
            Public Const ANS_TAXI_DATE_7 As String = "ANS_TAXI_DATE_7"
            Public Const ANS_TAXI_KENSHU_7 As String = "ANS_TAXI_KENSHU_7"
            Public Const ANS_TAXI_NO_7 As String = "ANS_TAXI_NO_7"
            Public Const ANS_TAXI_HAKKO_7 As String = "ANS_TAXI_HAKKO_7"
            Public Const ANS_TAXI_HAKKO_DATE_7 As String = "ANS_TAXI_HAKKO_DATE_7"
            Public Const ANS_TAXI_RMKS_7 As String = "ANS_TAXI_RMKS_7"
            Public Const ANS_TAXI_DATE_8 As String = "ANS_TAXI_DATE_8"
            Public Const ANS_TAXI_KENSHU_8 As String = "ANS_TAXI_KENSHU_8"
            Public Const ANS_TAXI_NO_8 As String = "ANS_TAXI_NO_8"
            Public Const ANS_TAXI_HAKKO_8 As String = "ANS_TAXI_HAKKO_8"
            Public Const ANS_TAXI_HAKKO_DATE_8 As String = "ANS_TAXI_HAKKO_DATE_8"
            Public Const ANS_TAXI_RMKS_8 As String = "ANS_TAXI_RMKS_8"
            Public Const ANS_TAXI_DATE_9 As String = "ANS_TAXI_DATE_9"
            Public Const ANS_TAXI_KENSHU_9 As String = "ANS_TAXI_KENSHU_9"
            Public Const ANS_TAXI_NO_9 As String = "ANS_TAXI_NO_9"
            Public Const ANS_TAXI_HAKKO_9 As String = "ANS_TAXI_HAKKO_9"
            Public Const ANS_TAXI_HAKKO_DATE_9 As String = "ANS_TAXI_HAKKO_DATE_9"
            Public Const ANS_TAXI_RMKS_9 As String = "ANS_TAXI_RMKS_9"
            Public Const ANS_TAXI_DATE_10 As String = "ANS_TAXI_DATE_10"
            Public Const ANS_TAXI_KENSHU_10 As String = "ANS_TAXI_KENSHU_10"
            Public Const ANS_TAXI_NO_10 As String = "ANS_TAXI_NO_10"
            Public Const ANS_TAXI_HAKKO_10 As String = "ANS_TAXI_HAKKO_10"
            Public Const ANS_TAXI_HAKKO_DATE_10 As String = "ANS_TAXI_HAKKO_DATE_10"
            Public Const ANS_TAXI_RMKS_10 As String = "ANS_TAXI_RMKS_10"
            Public Const ANS_TAXI_DATE_11 As String = "ANS_TAXI_DATE_11"
            Public Const ANS_TAXI_KENSHU_11 As String = "ANS_TAXI_KENSHU_11"
            Public Const ANS_TAXI_NO_11 As String = "ANS_TAXI_NO_11"
            Public Const ANS_TAXI_HAKKO_11 As String = "ANS_TAXI_HAKKO_11"
            Public Const ANS_TAXI_HAKKO_DATE_11 As String = "ANS_TAXI_HAKKO_DATE_11"
            Public Const ANS_TAXI_RMKS_11 As String = "ANS_TAXI_RMKS_11"
            Public Const ANS_TAXI_DATE_12 As String = "ANS_TAXI_DATE_12"
            Public Const ANS_TAXI_KENSHU_12 As String = "ANS_TAXI_KENSHU_12"
            Public Const ANS_TAXI_NO_12 As String = "ANS_TAXI_NO_12"
            Public Const ANS_TAXI_HAKKO_12 As String = "ANS_TAXI_HAKKO_12"
            Public Const ANS_TAXI_HAKKO_DATE_12 As String = "ANS_TAXI_HAKKO_DATE_12"
            Public Const ANS_TAXI_RMKS_12 As String = "ANS_TAXI_RMKS_12"
            Public Const ANS_TAXI_DATE_13 As String = "ANS_TAXI_DATE_13"
            Public Const ANS_TAXI_KENSHU_13 As String = "ANS_TAXI_KENSHU_13"
            Public Const ANS_TAXI_NO_13 As String = "ANS_TAXI_NO_13"
            Public Const ANS_TAXI_HAKKO_13 As String = "ANS_TAXI_HAKKO_13"
            Public Const ANS_TAXI_HAKKO_DATE_13 As String = "ANS_TAXI_HAKKO_DATE_13"
            Public Const ANS_TAXI_RMKS_13 As String = "ANS_TAXI_RMKS_13"
            Public Const ANS_TAXI_DATE_14 As String = "ANS_TAXI_DATE_14"
            Public Const ANS_TAXI_KENSHU_14 As String = "ANS_TAXI_KENSHU_14"
            Public Const ANS_TAXI_NO_14 As String = "ANS_TAXI_NO_14"
            Public Const ANS_TAXI_HAKKO_14 As String = "ANS_TAXI_HAKKO_14"
            Public Const ANS_TAXI_HAKKO_DATE_14 As String = "ANS_TAXI_HAKKO_DATE_14"
            Public Const ANS_TAXI_RMKS_14 As String = "ANS_TAXI_RMKS_14"
            Public Const ANS_TAXI_DATE_15 As String = "ANS_TAXI_DATE_15"
            Public Const ANS_TAXI_KENSHU_15 As String = "ANS_TAXI_KENSHU_15"
            Public Const ANS_TAXI_NO_15 As String = "ANS_TAXI_NO_15"
            Public Const ANS_TAXI_HAKKO_15 As String = "ANS_TAXI_HAKKO_15"
            Public Const ANS_TAXI_HAKKO_DATE_15 As String = "ANS_TAXI_HAKKO_DATE_15"
            Public Const ANS_TAXI_RMKS_15 As String = "ANS_TAXI_RMKS_15"
            Public Const ANS_TAXI_DATE_16 As String = "ANS_TAXI_DATE_16"
            Public Const ANS_TAXI_KENSHU_16 As String = "ANS_TAXI_KENSHU_16"
            Public Const ANS_TAXI_NO_16 As String = "ANS_TAXI_NO_16"
            Public Const ANS_TAXI_HAKKO_16 As String = "ANS_TAXI_HAKKO_16"
            Public Const ANS_TAXI_HAKKO_DATE_16 As String = "ANS_TAXI_HAKKO_DATE_16"
            Public Const ANS_TAXI_RMKS_16 As String = "ANS_TAXI_RMKS_16"
            Public Const ANS_TAXI_DATE_17 As String = "ANS_TAXI_DATE_17"
            Public Const ANS_TAXI_KENSHU_17 As String = "ANS_TAXI_KENSHU_17"
            Public Const ANS_TAXI_NO_17 As String = "ANS_TAXI_NO_17"
            Public Const ANS_TAXI_HAKKO_17 As String = "ANS_TAXI_HAKKO_17"
            Public Const ANS_TAXI_HAKKO_DATE_17 As String = "ANS_TAXI_HAKKO_DATE_17"
            Public Const ANS_TAXI_RMKS_17 As String = "ANS_TAXI_RMKS_17"
            Public Const ANS_TAXI_DATE_18 As String = "ANS_TAXI_DATE_18"
            Public Const ANS_TAXI_KENSHU_18 As String = "ANS_TAXI_KENSHU_18"
            Public Const ANS_TAXI_NO_18 As String = "ANS_TAXI_NO_18"
            Public Const ANS_TAXI_HAKKO_18 As String = "ANS_TAXI_HAKKO_18"
            Public Const ANS_TAXI_HAKKO_DATE_18 As String = "ANS_TAXI_HAKKO_DATE_18"
            Public Const ANS_TAXI_RMKS_18 As String = "ANS_TAXI_RMKS_18"
            Public Const ANS_TAXI_DATE_19 As String = "ANS_TAXI_DATE_19"
            Public Const ANS_TAXI_KENSHU_19 As String = "ANS_TAXI_KENSHU_19"
            Public Const ANS_TAXI_NO_19 As String = "ANS_TAXI_NO_19"
            Public Const ANS_TAXI_HAKKO_19 As String = "ANS_TAXI_HAKKO_19"
            Public Const ANS_TAXI_HAKKO_DATE_19 As String = "ANS_TAXI_HAKKO_DATE_19"
            Public Const ANS_TAXI_RMKS_19 As String = "ANS_TAXI_RMKS_19"
            Public Const ANS_TAXI_DATE_20 As String = "ANS_TAXI_DATE_20"
            Public Const ANS_TAXI_KENSHU_20 As String = "ANS_TAXI_KENSHU_20"
            Public Const ANS_TAXI_NO_20 As String = "ANS_TAXI_NO_20"
            Public Const ANS_TAXI_HAKKO_20 As String = "ANS_TAXI_HAKKO_20"
            Public Const ANS_TAXI_HAKKO_DATE_20 As String = "ANS_TAXI_HAKKO_DATE_20"
            Public Const ANS_TAXI_RMKS_20 As String = "ANS_TAXI_RMKS_20"
            Public Const ANS_TAXI_NOTE As String = "ANS_TAXI_NOTE"
            Public Const REQ_MR_O_TEHAI As String = "REQ_MR_O_TEHAI"
            Public Const REQ_MR_F_TEHAI As String = "REQ_MR_F_TEHAI"
            Public Const MR_SEX As String = "MR_SEX"
            Public Const MR_AGE As String = "MR_AGE"
            Public Const REQ_MR_HOTEL_NOTE As String = "REQ_MR_HOTEL_NOTE"
            Public Const ANS_MR_O_TEHAI As String = "ANS_MR_O_TEHAI"
            Public Const ANS_MR_F_TEHAI As String = "ANS_MR_F_TEHAI"
            Public Const ANS_MR_HOTEL_NOTE As String = "ANS_MR_HOTEL_NOTE"
            Public Const ANS_MR_KOTSUHI As String = "ANS_MR_KOTSUHI"
            Public Const ANS_MR_HOTELHI As String = "ANS_MR_HOTELHI"
            Public Const ANS_MR_HOTELHI_TOZEI As String = "ANS_MR_HOTELHI_TOZEI"
            Public Const SEND_FLAG As String = "SEND_FLAG"
            Public Const TTANTO_ID As String = "TTANTO_ID"
            Public Const SEIKYU_NO_TOPTOUR As String = "SEIKYU_NO_TOPTOUR"
            Public Const SCAN_IMPORT_DATE As String = "SCAN_IMPORT_DATE"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
            Public Const SEND_DATE As String = "SEND_DATE"

            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const KOUENKAI_TIME_STAMP As String = "KOUENKAI_TIME_STAMP"
            Public Const TORIKESHI_FLG As String = "TORIKESHI_FLG"
            Public Const TAXI_PRT_NAME As String = "TAXI_PRT_NAME"
            Public Const KAIJO_NAME As String = "KAIJO_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const USER_NAME As String = "USER_NAME"
            Public Const SEIHIN_NAME As String = "SEIHIN_NAME"
            Public Const TIME_STAMP As String = "TIME_STAMP"
        End Class
        Public Class Name
            Public Const SALEFORCE_ID As String = "SalesForceID"
            Public Const SANKASHA_ID As String = "参加者ID"
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const REQ_STATUS_TEHAI As String = "手配ステータス(依頼)"
            Public Const ANS_STATUS_TEHAI As String = "手配ステータス(回答)"
            Public Const TIME_STAMP_BYL As String = "Timestamp(BYL)"
            Public Const TIME_STAMP_TOP As String = "Timestamp(TOP)"
            Public Const DR_MPID As String = "MPID"
            Public Const DR_CD As String = "DRコード"
            Public Const DR_NAME As String = "DR氏名"
            Public Const DR_KANA As String = "DR氏名(半角カタカナ)"
            Public Const DR_SHISETSU_CD As String = "DCF施設コード"
            Public Const DR_SHISETSU_NAME As String = "施設名"
            Public Const DR_SHISETSU_ADDRESS As String = "施設住所"
            Public Const DR_YAKUWARI As String = "参加者役割"
            Public Const DR_SEX As String = "DR性別"
            Public Const DR_AGE As String = "航空搭乗者年齢(年齢)"
            Public Const SHITEIGAI_RIYU As String = "指定外申請理由(依頼)"
            Public Const DR_SANKA As String = "参加/不参加"
            Public Const MR_BU As String = "BU(担当MR)"
            Public Const MR_AREA As String = "所属エリア(担当MR)"
            Public Const MR_EIGYOSHO As String = "所属営業所(担当MR)"
            Public Const MR_NAME As String = "担当者(担当MR)名"
            Public Const MR_ROMA As String = "担当者名(担当MR)(ローマ字)"
            Public Const MR_KANA As String = "担当者名(担当MR)(カナ)"
            Public Const MR_EMAIL_PC As String = "Emailアドレス(担当MR)"
            Public Const MR_EMAIL_KEITAI As String = "携帯Emailアドレス(担当MR)"
            Public Const MR_KEITAI As String = "携帯電話番号(担当MR)"
            Public Const MR_TEL As String = "オフィスの電話番号(担当MR)"
            Public Const MR_SEND_SAKI_FS As String = "チケット送付先FS"
            Public Const MR_SEND_SAKI_OTHER As String = "チケット送付先(その他)"
            Public Const ACCOUNT_CD As String = "Account Code"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const INTERNAL_ORDER As String = "Internal Order"
            Public Const ZETIA_CD As String = "Zetia Code"
            Public Const SHONIN_NAME As String = "最終承認者(氏名)"
            Public Const SHONIN_DATE As String = "最終承認日時"
            Public Const TEHAI_HOTEL As String = "宿泊手配(希望する)"
            Public Const HOTEL_IRAINAIYOU As String = "宿泊依頼内容"
            Public Const REQ_HOTEL_DATE As String = "宿泊日(依頼)"
            Public Const REQ_HAKUSU As String = "泊数(依頼)"
            Public Const REQ_HOTEL_SMOKING As String = "宿泊ホテル喫煙(依頼)"
            Public Const REQ_HOTEL_NOTE As String = "宿泊備考(依頼)"
            Public Const ANS_STATUS_HOTEL As String = "宿泊ステータス(回答)"
            Public Const ANS_HOTEL_NAME As String = "宿泊先(回答)"
            Public Const ANS_HOTEL_ADDRESS As String = "宿泊先住所(回答)"
            Public Const ANS_HOTEL_TEL As String = "宿泊先電話番号(回答)"
            Public Const ANS_HOTEL_DATE As String = "宿泊日(回答)"
            Public Const ANS_HAKUSU As String = "泊数(回答)"
            Public Const ANS_CHECKIN_TIME As String = "宿泊先チェックイン時間(回答)"
            Public Const ANS_CHECKOUT_TIME As String = "宿泊先チェックアウト時間(回答)"
            Public Const ANS_ROOM_TYPE As String = "宿泊部屋タイプ(回答)"
            Public Const ANS_HOTEL_SMOKING As String = "宿泊ホテル喫煙(回答)"
            Public Const ANS_HOTEL_NOTE As String = "宿泊備考(回答)"
            Public Const ANS_HOTELHI As String = "宿泊費(回答)"
            Public Const ANS_HOTELHI_TOZEI As String = "宿泊都税(回答)"
            Public Const ANS_HOTELHI_CANCEL As String = "宿泊取消料(回答)"
            Public Const REQ_O_TEHAI_1 As String = "往路1:希望する(依頼)"
            Public Const REQ_O_IRAINAIYOU_1 As String = "往路1:依頼内容(依頼)"
            Public Const REQ_O_KOTSUKIKAN_1 As String = "往路1:交通機関(依頼)"
            Public Const REQ_O_DATE_1 As String = "往路1:利用日(依頼)"
            Public Const REQ_O_AIRPORT1_1 As String = "往路1:出発地(依頼)"
            Public Const REQ_O_AIRPORT2_1 As String = "往路1:到着地(依頼)"
            Public Const REQ_O_TIME1_1 As String = "往路1:出発時間(依頼)"
            Public Const REQ_O_TIME2_1 As String = "往路1:到着時間(依頼)"
            Public Const REQ_O_BIN_1 As String = "往路1:列車名・便名(依頼)"
            Public Const REQ_O_SEAT_1 As String = "往路1:座席区分(依頼)"
            Public Const REQ_O_SEAT_KIBOU1 As String = "往路1:座席希望(依頼)"
            Public Const REQ_O_TEHAI_2 As String = "往路2:希望する(依頼)"
            Public Const REQ_O_IRAINAIYOU_2 As String = "往路2:依頼内容(依頼)"
            Public Const REQ_O_KOTSUKIKAN_2 As String = "往路2:交通機関(依頼)"
            Public Const REQ_O_DATE_2 As String = "往路2:利用日(依頼)"
            Public Const REQ_O_AIRPORT1_2 As String = "往路2:出発地(依頼)"
            Public Const REQ_O_AIRPORT2_2 As String = "往路2:到着地(依頼)"
            Public Const REQ_O_TIME1_2 As String = "往路2:出発時間(依頼)"
            Public Const REQ_O_TIME2_2 As String = "往路2:到着時間(依頼)"
            Public Const REQ_O_BIN_2 As String = "往路2:列車名・便名(依頼)"
            Public Const REQ_O_SEAT_2 As String = "往路2:座席区分(依頼)"
            Public Const REQ_O_SEAT_KIBOU2 As String = "往路2:座席希望(依頼)"
            Public Const REQ_O_TEHAI_3 As String = "往路3:希望する(依頼)"
            Public Const REQ_O_IRAINAIYOU_3 As String = "往路3:依頼内容(依頼)"
            Public Const REQ_O_KOTSUKIKAN_3 As String = "往路3:交通機関(依頼)"
            Public Const REQ_O_DATE_3 As String = "往路3:利用日(依頼)"
            Public Const REQ_O_AIRPORT1_3 As String = "往路3:出発地(依頼)"
            Public Const REQ_O_AIRPORT2_3 As String = "往路3:到着地(依頼)"
            Public Const REQ_O_TIME1_3 As String = "往路3:出発時間(依頼)"
            Public Const REQ_O_TIME2_3 As String = "往路3:到着時間(依頼)"
            Public Const REQ_O_BIN_3 As String = "往路3:列車名・便名(依頼)"
            Public Const REQ_O_SEAT_3 As String = "往路3:座席区分(依頼)"
            Public Const REQ_O_SEAT_KIBOU3 As String = "往路3:座席希望(依頼)"
            Public Const REQ_O_TEHAI_4 As String = "往路4:希望する(依頼)"
            Public Const REQ_O_IRAINAIYOU_4 As String = "往路4:依頼内容(依頼)"
            Public Const REQ_O_KOTSUKIKAN_4 As String = "往路4:交通機関(依頼)"
            Public Const REQ_O_DATE_4 As String = "往路4:利用日(依頼)"
            Public Const REQ_O_AIRPORT1_4 As String = "往路4:出発地(依頼)"
            Public Const REQ_O_AIRPORT2_4 As String = "往路4:到着地(依頼)"
            Public Const REQ_O_TIME1_4 As String = "往路4:出発時間(依頼)"
            Public Const REQ_O_TIME2_4 As String = "往路4:到着時間(依頼)"
            Public Const REQ_O_BIN_4 As String = "往路4:列車名・便名(依頼)"
            Public Const REQ_O_SEAT_4 As String = "往路4:座席区分(依頼)"
            Public Const REQ_O_SEAT_KIBOU4 As String = "往路4:座席希望(依頼)"
            Public Const REQ_O_TEHAI_5 As String = "往路5:希望する(依頼)"
            Public Const REQ_O_IRAINAIYOU_5 As String = "往路5:依頼内容(依頼)"
            Public Const REQ_O_KOTSUKIKAN_5 As String = "往路5:交通機関(依頼)"
            Public Const REQ_O_DATE_5 As String = "往路5:利用日(依頼)"
            Public Const REQ_O_AIRPORT1_5 As String = "往路5:出発地(依頼)"
            Public Const REQ_O_AIRPORT2_5 As String = "往路5:到着地(依頼)"
            Public Const REQ_O_TIME1_5 As String = "往路5:出発時間(依頼)"
            Public Const REQ_O_TIME2_5 As String = "往路5:到着時間(依頼)"
            Public Const REQ_O_BIN_5 As String = "往路5:列車名・便名(依頼)"
            Public Const REQ_O_SEAT_5 As String = "往路5:座席区分(依頼)"
            Public Const REQ_O_SEAT_KIBOU5 As String = "往路5:座席希望(依頼)"
            Public Const REQ_F_TEHAI_1 As String = "復路1:希望する(依頼)"
            Public Const REQ_F_IRAINAIYOU_1 As String = "復路1:依頼内容(依頼)"
            Public Const REQ_F_KOTSUKIKAN_1 As String = "復路1:交通機関(依頼)"
            Public Const REQ_F_DATE_1 As String = "復路1:利用日(依頼)"
            Public Const REQ_F_AIRPORT1_1 As String = "復路1:出発地(依頼)"
            Public Const REQ_F_AIRPORT2_1 As String = "復路1:到着地(依頼)"
            Public Const REQ_F_TIME1_1 As String = "復路1:出発時間(依頼)"
            Public Const REQ_F_TIME2_1 As String = "復路1:到着時間(依頼)"
            Public Const REQ_F_BIN_1 As String = "復路1:列車名・便名(依頼)"
            Public Const REQ_F_SEAT_1 As String = "復路1:座席区分(依頼)"
            Public Const REQ_F_SEAT_KIBOU1 As String = "復路1:座席希望(依頼)"
            Public Const REQ_F_TEHAI_2 As String = "復路2:希望する(依頼)"
            Public Const REQ_F_IRAINAIYOU_2 As String = "復路2:依頼内容(依頼)"
            Public Const REQ_F_KOTSUKIKAN_2 As String = "復路2:交通機関(依頼)"
            Public Const REQ_F_DATE_2 As String = "復路2:利用日(依頼)"
            Public Const REQ_F_AIRPORT1_2 As String = "復路2:出発地(依頼)"
            Public Const REQ_F_AIRPORT2_2 As String = "復路2:到着地(依頼)"
            Public Const REQ_F_TIME1_2 As String = "復路2:出発時間(依頼)"
            Public Const REQ_F_TIME2_2 As String = "復路2:到着時間(依頼)"
            Public Const REQ_F_BIN_2 As String = "復路2:列車名・便名(依頼)"
            Public Const REQ_F_SEAT_2 As String = "復路2:座席区分(依頼)"
            Public Const REQ_F_SEAT_KIBOU2 As String = "復路2:座席希望(依頼)"
            Public Const REQ_F_TEHAI_3 As String = "復路3:希望する(依頼)"
            Public Const REQ_F_IRAINAIYOU_3 As String = "復路3:依頼内容(依頼)"
            Public Const REQ_F_KOTSUKIKAN_3 As String = "復路3:交通機関(依頼)"
            Public Const REQ_F_DATE_3 As String = "復路3:利用日(依頼)"
            Public Const REQ_F_AIRPORT1_3 As String = "復路3:出発地(依頼)"
            Public Const REQ_F_AIRPORT2_3 As String = "復路3:到着地(依頼)"
            Public Const REQ_F_TIME1_3 As String = "復路3:出発時間(依頼)"
            Public Const REQ_F_TIME2_3 As String = "復路3:到着時間(依頼)"
            Public Const REQ_F_BIN_3 As String = "復路3:列車名・便名(依頼)"
            Public Const REQ_F_SEAT_3 As String = "復路3:座席区分(依頼)"
            Public Const REQ_F_SEAT_KIBOU3 As String = "復路3:座席希望(依頼)"
            Public Const REQ_F_TEHAI_4 As String = "復路4:希望する(依頼)"
            Public Const REQ_F_IRAINAIYOU_4 As String = "復路4:依頼内容(依頼)"
            Public Const REQ_F_KOTSUKIKAN_4 As String = "復路4:交通機関(依頼)"
            Public Const REQ_F_DATE_4 As String = "復路4:利用日(依頼)"
            Public Const REQ_F_AIRPORT1_4 As String = "復路4:出発地(依頼)"
            Public Const REQ_F_AIRPORT2_4 As String = "復路4:到着地(依頼)"
            Public Const REQ_F_TIME1_4 As String = "復路4:出発時間(依頼)"
            Public Const REQ_F_TIME2_4 As String = "復路4:到着時間(依頼)"
            Public Const REQ_F_BIN_4 As String = "復路4:列車名・便名(依頼)"
            Public Const REQ_F_SEAT_4 As String = "復路4:座席区分(依頼)"
            Public Const REQ_F_SEAT_KIBOU4 As String = "復路4:座席希望(依頼)"
            Public Const REQ_F_TEHAI_5 As String = "復路5:希望する(依頼)"
            Public Const REQ_F_IRAINAIYOU_5 As String = "復路5:依頼内容(依頼)"
            Public Const REQ_F_KOTSUKIKAN_5 As String = "復路5:交通機関(依頼)"
            Public Const REQ_F_DATE_5 As String = "復路5:利用日(依頼)"
            Public Const REQ_F_AIRPORT1_5 As String = "復路5:出発地(依頼)"
            Public Const REQ_F_AIRPORT2_5 As String = "復路5:到着地(依頼)"
            Public Const REQ_F_TIME1_5 As String = "復路5:出発時間(依頼)"
            Public Const REQ_F_TIME2_5 As String = "復路5:到着時間(依頼)"
            Public Const REQ_F_BIN_5 As String = "復路5:列車名・便名(依頼)"
            Public Const REQ_F_SEAT_5 As String = "復路5:座席区分(依頼)"
            Public Const REQ_F_SEAT_KIBOU5 As String = "復路5:座席希望(依頼)"
            Public Const REQ_KOTSU_BIKO As String = "交通備考(依頼)"
            Public Const ANS_O_STATUS_1 As String = "往路1:ステータス(回答)"
            Public Const ANS_O_KOTSUKIKAN_1 As String = "往路1:交通機関(回答)"
            Public Const ANS_O_DATE_1 As String = "往路1:利用日(回答)"
            Public Const ANS_O_AIRPORT1_1 As String = "往路1:出発地(回答)"
            Public Const ANS_O_AIRPORT2_1 As String = "往路1:到着地(回答)"
            Public Const ANS_O_TIME1_1 As String = "往路1:出発時間(回答)"
            Public Const ANS_O_TIME2_1 As String = "往路1:到着時間(回答)"
            Public Const ANS_O_BIN_1 As String = "往路1:列車名・便名(回答)"
            Public Const ANS_O_SEAT_1 As String = "往路1:座席区分(回答)"
            Public Const ANS_O_SEAT_KIBOU1 As String = "往路1:座席希望(回答)"
            Public Const ANS_O_STATUS_2 As String = "往路2:ステータス(回答)"
            Public Const ANS_O_KOTSUKIKAN_2 As String = "往路2:交通機関(回答)"
            Public Const ANS_O_DATE_2 As String = "往路2:利用日(回答)"
            Public Const ANS_O_AIRPORT1_2 As String = "往路2:出発地(回答)"
            Public Const ANS_O_AIRPORT2_2 As String = "往路2:到着地(回答)"
            Public Const ANS_O_TIME1_2 As String = "往路2:出発時間(回答)"
            Public Const ANS_O_TIME2_2 As String = "往路2:到着時間(回答)"
            Public Const ANS_O_BIN_2 As String = "往路2:列車名・便名(回答)"
            Public Const ANS_O_SEAT_2 As String = "往路2:座席区分(回答)"
            Public Const ANS_O_SEAT_KIBOU2 As String = "往路2:座席希望(回答)"
            Public Const ANS_O_STATUS_3 As String = "往路3:ステータス(回答)"
            Public Const ANS_O_KOTSUKIKAN_3 As String = "往路3:交通機関(回答)"
            Public Const ANS_O_DATE_3 As String = "往路3:利用日(回答)"
            Public Const ANS_O_AIRPORT1_3 As String = "往路3:出発地(回答)"
            Public Const ANS_O_AIRPORT2_3 As String = "往路3:到着地(回答)"
            Public Const ANS_O_TIME1_3 As String = "往路3:出発時間(回答)"
            Public Const ANS_O_TIME2_3 As String = "往路3:到着時間(回答)"
            Public Const ANS_O_BIN_3 As String = "往路3:列車名・便名(回答)"
            Public Const ANS_O_SEAT_3 As String = "往路3:座席区分(回答)"
            Public Const ANS_O_SEAT_KIBOU3 As String = "往路3:座席希望(回答)"
            Public Const ANS_O_STATUS_4 As String = "往路4:ステータス(回答)"
            Public Const ANS_O_KOTSUKIKAN_4 As String = "往路4:交通機関(回答)"
            Public Const ANS_O_DATE_4 As String = "往路4:利用日(回答)"
            Public Const ANS_O_AIRPORT1_4 As String = "往路4:出発地(回答)"
            Public Const ANS_O_AIRPORT2_4 As String = "往路4:到着地(回答)"
            Public Const ANS_O_TIME1_4 As String = "往路4:出発時間(回答)"
            Public Const ANS_O_TIME2_4 As String = "往路4:到着時間(回答)"
            Public Const ANS_O_BIN_4 As String = "往路4:列車名・便名(回答)"
            Public Const ANS_O_SEAT_4 As String = "往路4:座席区分(回答)"
            Public Const ANS_O_SEAT_KIBOU4 As String = "往路4:座席希望(回答)"
            Public Const ANS_O_STATUS_5 As String = "往路5:ステータス(回答)"
            Public Const ANS_O_KOTSUKIKAN_5 As String = "往路5:交通機関(回答)"
            Public Const ANS_O_DATE_5 As String = "往路5:利用日(回答)"
            Public Const ANS_O_AIRPORT1_5 As String = "往路5:出発地(回答)"
            Public Const ANS_O_AIRPORT2_5 As String = "往路5:到着地(回答)"
            Public Const ANS_O_TIME1_5 As String = "往路5:出発時間(回答)"
            Public Const ANS_O_TIME2_5 As String = "往路5:到着時間(回答)"
            Public Const ANS_O_BIN_5 As String = "往路5:列車名・便名(回答)"
            Public Const ANS_O_SEAT_5 As String = "往路5:座席区分(回答)"
            Public Const ANS_O_SEAT_KIBOU5 As String = "往路5:座席希望(回答)"
            Public Const ANS_F_STATUS_1 As String = "復路1:ステータス(回答)"
            Public Const ANS_F_KOTSUKIKAN_1 As String = "復路1:交通機関(回答)"
            Public Const ANS_F_DATE_1 As String = "復路1:利用日(回答)"
            Public Const ANS_F_AIRPORT1_1 As String = "復路1:出発地(回答)"
            Public Const ANS_F_AIRPORT2_1 As String = "復路1:到着地(回答)"
            Public Const ANS_F_TIME1_1 As String = "復路1:出発時間(回答)"
            Public Const ANS_F_TIME2_1 As String = "復路1:到着時間(回答)"
            Public Const ANS_F_BIN_1 As String = "復路1:列車名・便名(回答)"
            Public Const ANS_F_SEAT_1 As String = "復路1:座席区分(回答)"
            Public Const ANS_F_SEAT_KIBOU1 As String = "復路1:座席希望(回答)"
            Public Const ANS_F_STATUS_2 As String = "復路2:ステータス(回答)"
            Public Const ANS_F_KOTSUKIKAN_2 As String = "復路2:交通機関(回答)"
            Public Const ANS_F_DATE_2 As String = "復路2:利用日(回答)"
            Public Const ANS_F_AIRPORT1_2 As String = "復路2:出発地(回答)"
            Public Const ANS_F_AIRPORT2_2 As String = "復路2:到着地(回答)"
            Public Const ANS_F_TIME1_2 As String = "復路2:出発時間(回答)"
            Public Const ANS_F_TIME2_2 As String = "復路2:到着時間(回答)"
            Public Const ANS_F_BIN_2 As String = "復路2:列車名・便名(回答)"
            Public Const ANS_F_SEAT_2 As String = "復路2:座席区分(回答)"
            Public Const ANS_F_SEAT_KIBOU2 As String = "復路2:座席希望(回答)"
            Public Const ANS_F_STATUS_3 As String = "復路3:ステータス(回答)"
            Public Const ANS_F_KOTSUKIKAN_3 As String = "復路3:交通機関(回答)"
            Public Const ANS_F_DATE_3 As String = "復路3:利用日(回答)"
            Public Const ANS_F_AIRPORT1_3 As String = "復路3:出発地(回答)"
            Public Const ANS_F_AIRPORT2_3 As String = "復路3:到着地(回答)"
            Public Const ANS_F_TIME1_3 As String = "復路3:出発時間(回答)"
            Public Const ANS_F_TIME2_3 As String = "復路3:到着時間(回答)"
            Public Const ANS_F_BIN_3 As String = "復路3:列車名・便名(回答)"
            Public Const ANS_F_SEAT_3 As String = "復路3:座席区分(回答)"
            Public Const ANS_F_SEAT_KIBOU3 As String = "復路3:座席希望(回答)"
            Public Const ANS_F_STATUS_4 As String = "復路4:ステータス(回答)"
            Public Const ANS_F_KOTSUKIKAN_4 As String = "復路4:交通機関(回答)"
            Public Const ANS_F_DATE_4 As String = "復路4:利用日(回答)"
            Public Const ANS_F_AIRPORT1_4 As String = "復路4:出発地(回答)"
            Public Const ANS_F_AIRPORT2_4 As String = "復路4:到着地(回答)"
            Public Const ANS_F_TIME1_4 As String = "復路4:出発時間(回答)"
            Public Const ANS_F_TIME2_4 As String = "復路4:到着時間(回答)"
            Public Const ANS_F_BIN_4 As String = "復路4:列車名・便名(回答)"
            Public Const ANS_F_SEAT_4 As String = "復路4:座席区分(回答)"
            Public Const ANS_F_SEAT_KIBOU4 As String = "復路4:座席希望(回答)"
            Public Const ANS_F_STATUS_5 As String = "復路5:ステータス(回答)"
            Public Const ANS_F_KOTSUKIKAN_5 As String = "復路5:交通機関(回答)"
            Public Const ANS_F_DATE_5 As String = "復路5:利用日(回答)"
            Public Const ANS_F_AIRPORT1_5 As String = "復路5:出発地(回答)"
            Public Const ANS_F_AIRPORT2_5 As String = "復路5:到着地(回答)"
            Public Const ANS_F_TIME1_5 As String = "復路5:出発時間(回答)"
            Public Const ANS_F_TIME2_5 As String = "復路5:到着時間(回答)"
            Public Const ANS_F_BIN_5 As String = "復路5:列車名・便名(回答)"
            Public Const ANS_F_SEAT_5 As String = "復路5:座席区分(回答)"
            Public Const ANS_F_SEAT_KIBOU5 As String = "復路5:座席希望(回答)"
            Public Const ANS_KOTSU_BIKO As String = "交通備考(回答)"
            Public Const ANS_RAIL_FARE As String = "【回答】JR・鉄道代金"
            Public Const ANS_RAIL_CANCELLATION As String = "【回答】JR・鉄道取消料"
            Public Const ANS_OTHER_FARE As String = "【回答】その他鉄道等代金"
            Public Const ANS_OTHER_CANCELLATION As String = "【回答】その他鉄道等取消料"
            Public Const ANS_AIR_FARE As String = "【回答】航空券代金"
            Public Const ANS_AIR_CANCELLATION As String = "【回答】航空券取消料"
            Public Const ANS_KOTSUHOTEL_TESURYO As String = "【回答】手数料(交通・宿泊)"
            Public Const ANS_TAXI_TESURYO As String = "【回答】手数料(タクチケ発券手数料)"
            Public Const ANS_TICKET_SEND_DAY As String = "【回答】チケット類発送日(最新)"
            Public Const TEHAI_TAXI As String = "タクシーチケット(有・無)"
            Public Const REQ_TAXI_DATE_1 As String = "行程1:利用日(依頼)"
            Public Const REQ_TAXI_FROM_1 As String = "行程1:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_1 As String = "行程1:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_2 As String = "行程2:利用日(依頼)"
            Public Const REQ_TAXI_FROM_2 As String = "行程2:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_2 As String = "行程2:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_3 As String = "行程3:利用日(依頼)"
            Public Const REQ_TAXI_FROM_3 As String = "行程3:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_3 As String = "行程3:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_4 As String = "行程4:利用日(依頼)"
            Public Const REQ_TAXI_FROM_4 As String = "行程4:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_4 As String = "行程4:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_5 As String = "行程5:利用日(依頼)"
            Public Const REQ_TAXI_FROM_5 As String = "行程5:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_5 As String = "行程5:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_6 As String = "行程6:利用日(依頼)"
            Public Const REQ_TAXI_FROM_6 As String = "行程6:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_6 As String = "行程6:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_7 As String = "行程7:利用日(依頼)"
            Public Const REQ_TAXI_FROM_7 As String = "行程7:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_7 As String = "行程7:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_8 As String = "行程8:利用日(依頼)"
            Public Const REQ_TAXI_FROM_8 As String = "行程8:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_8 As String = "行程8:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_9 As String = "行程9:利用日(依頼)"
            Public Const REQ_TAXI_FROM_9 As String = "行程9:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_9 As String = "行程9:依頼金額(依頼)"
            Public Const REQ_TAXI_DATE_10 As String = "行程10:利用日(依頼)"
            Public Const REQ_TAXI_FROM_10 As String = "行程10:発地(依頼)"
            Public Const TAXI_YOTEIKINGAKU_10 As String = "行程10:依頼金額(依頼)"
            Public Const REQ_TAXI_NOTE As String = "タクシーチケット:備考(依頼)"
            Public Const ANS_TAXI_DATE_1 As String = "タクシーチケット1:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_1 As String = "タクシーチケット1:券種(回答)"
            Public Const ANS_TAXI_NO_1 As String = "タクシーチケット1:番号(回答)"
            Public Const ANS_TAXI_HAKKO_1 As String = "タクシーチケット1:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_1 As String = "タクシーチケット1:発行日(回答)"
            Public Const ANS_TAXI_RMKS_1 As String = "タクシーチケット1:備考(回答)"
            Public Const ANS_TAXI_DATE_2 As String = "タクシーチケット2:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_2 As String = "タクシーチケット2:券種(回答)"
            Public Const ANS_TAXI_NO_2 As String = "タクシーチケット2:番号(回答)"
            Public Const ANS_TAXI_HAKKO_2 As String = "タクシーチケット2:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_2 As String = "タクシーチケット2:発行日(回答)"
            Public Const ANS_TAXI_RMKS_2 As String = "タクシーチケット2:備考(回答)"
            Public Const ANS_TAXI_DATE_3 As String = "タクシーチケット3:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_3 As String = "タクシーチケット3:券種(回答)"
            Public Const ANS_TAXI_NO_3 As String = "タクシーチケット3:番号(回答)"
            Public Const ANS_TAXI_HAKKO_3 As String = "タクシーチケット3:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_3 As String = "タクシーチケット3:発行日(回答)"
            Public Const ANS_TAXI_RMKS_3 As String = "タクシーチケット3:備考(回答)"
            Public Const ANS_TAXI_DATE_4 As String = "タクシーチケット4:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_4 As String = "タクシーチケット4:券種(回答)"
            Public Const ANS_TAXI_NO_4 As String = "タクシーチケット4:番号(回答)"
            Public Const ANS_TAXI_HAKKO_4 As String = "タクシーチケット4:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_4 As String = "タクシーチケット4:発行日(回答)"
            Public Const ANS_TAXI_RMKS_4 As String = "タクシーチケット4:備考(回答)"
            Public Const ANS_TAXI_DATE_5 As String = "タクシーチケット5:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_5 As String = "タクシーチケット5:券種(回答)"
            Public Const ANS_TAXI_NO_5 As String = "タクシーチケット5:番号(回答)"
            Public Const ANS_TAXI_HAKKO_5 As String = "タクシーチケット5:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_5 As String = "タクシーチケット5:発行日(回答)"
            Public Const ANS_TAXI_RMKS_5 As String = "タクシーチケット5:備考(回答)"
            Public Const ANS_TAXI_DATE_6 As String = "タクシーチケット6:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_6 As String = "タクシーチケット6:券種(回答)"
            Public Const ANS_TAXI_NO_6 As String = "タクシーチケット6:番号(回答)"
            Public Const ANS_TAXI_HAKKO_6 As String = "タクシーチケット6:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_6 As String = "タクシーチケット6:発行日(回答)"
            Public Const ANS_TAXI_RMKS_6 As String = "タクシーチケット6:備考(回答)"
            Public Const ANS_TAXI_DATE_7 As String = "タクシーチケット7:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_7 As String = "タクシーチケット7:券種(回答)"
            Public Const ANS_TAXI_NO_7 As String = "タクシーチケット7:番号(回答)"
            Public Const ANS_TAXI_HAKKO_7 As String = "タクシーチケット7:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_7 As String = "タクシーチケット7:発行日(回答)"
            Public Const ANS_TAXI_RMKS_7 As String = "タクシーチケット7:備考(回答)"
            Public Const ANS_TAXI_DATE_8 As String = "タクシーチケット8:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_8 As String = "タクシーチケット8:券種(回答)"
            Public Const ANS_TAXI_NO_8 As String = "タクシーチケット8:番号(回答)"
            Public Const ANS_TAXI_HAKKO_8 As String = "タクシーチケット8:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_8 As String = "タクシーチケット8:発行日(回答)"
            Public Const ANS_TAXI_RMKS_8 As String = "タクシーチケット8:備考(回答)"
            Public Const ANS_TAXI_DATE_9 As String = "タクシーチケット9:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_9 As String = "タクシーチケット9:券種(回答)"
            Public Const ANS_TAXI_NO_9 As String = "タクシーチケット9:番号(回答)"
            Public Const ANS_TAXI_HAKKO_9 As String = "タクシーチケット9:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_9 As String = "タクシーチケット9:発行日(回答)"
            Public Const ANS_TAXI_RMKS_9 As String = "タクシーチケット9:備考(回答)"
            Public Const ANS_TAXI_DATE_10 As String = "タクシーチケット10:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_10 As String = "タクシーチケット10:券種(回答)"
            Public Const ANS_TAXI_NO_10 As String = "タクシーチケット10:番号(回答)"
            Public Const ANS_TAXI_HAKKO_10 As String = "タクシーチケット10:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_10 As String = "タクシーチケット10:発行日(回答)"
            Public Const ANS_TAXI_RMKS_10 As String = "タクシーチケット10:備考(回答)"
            Public Const ANS_TAXI_DATE_11 As String = "タクシーチケット11:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_11 As String = "タクシーチケット11:券種(回答)"
            Public Const ANS_TAXI_NO_11 As String = "タクシーチケット11:番号(回答)"
            Public Const ANS_TAXI_HAKKO_11 As String = "タクシーチケット11:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_11 As String = "タクシーチケット11:発行日(回答)"
            Public Const ANS_TAXI_RMKS_11 As String = "タクシーチケット11:備考(回答)"
            Public Const ANS_TAXI_DATE_12 As String = "タクシーチケット12:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_12 As String = "タクシーチケット12:券種(回答)"
            Public Const ANS_TAXI_NO_12 As String = "タクシーチケット12:番号(回答)"
            Public Const ANS_TAXI_HAKKO_12 As String = "タクシーチケット12:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_12 As String = "タクシーチケット12:発行日(回答)"
            Public Const ANS_TAXI_RMKS_12 As String = "タクシーチケット12:備考(回答)"
            Public Const ANS_TAXI_DATE_13 As String = "タクシーチケット13:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_13 As String = "タクシーチケット13:券種(回答)"
            Public Const ANS_TAXI_NO_13 As String = "タクシーチケット13:番号(回答)"
            Public Const ANS_TAXI_HAKKO_13 As String = "タクシーチケット13:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_13 As String = "タクシーチケット13:発行日(回答)"
            Public Const ANS_TAXI_RMKS_13 As String = "タクシーチケット13:備考(回答)"
            Public Const ANS_TAXI_DATE_14 As String = "タクシーチケット14:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_14 As String = "タクシーチケット14:券種(回答)"
            Public Const ANS_TAXI_NO_14 As String = "タクシーチケット14:番号(回答)"
            Public Const ANS_TAXI_HAKKO_14 As String = "タクシーチケット14:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_14 As String = "タクシーチケット14:発行日(回答)"
            Public Const ANS_TAXI_RMKS_14 As String = "タクシーチケット14:備考(回答)"
            Public Const ANS_TAXI_DATE_15 As String = "タクシーチケット15:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_15 As String = "タクシーチケット15:券種(回答)"
            Public Const ANS_TAXI_NO_15 As String = "タクシーチケット15:番号(回答)"
            Public Const ANS_TAXI_HAKKO_15 As String = "タクシーチケット15:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_15 As String = "タクシーチケット15:発行日(回答)"
            Public Const ANS_TAXI_RMKS_15 As String = "タクシーチケット15:備考(回答)"
            Public Const ANS_TAXI_DATE_16 As String = "タクシーチケット16:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_16 As String = "タクシーチケット16:券種(回答)"
            Public Const ANS_TAXI_NO_16 As String = "タクシーチケット16:番号(回答)"
            Public Const ANS_TAXI_HAKKO_16 As String = "タクシーチケット16:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_16 As String = "タクシーチケット16:発行日(回答)"
            Public Const ANS_TAXI_RMKS_16 As String = "タクシーチケット16:備考(回答)"
            Public Const ANS_TAXI_DATE_17 As String = "タクシーチケット17:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_17 As String = "タクシーチケット17:券種(回答)"
            Public Const ANS_TAXI_NO_17 As String = "タクシーチケット17:番号(回答)"
            Public Const ANS_TAXI_HAKKO_17 As String = "タクシーチケット17:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_17 As String = "タクシーチケット17:発行日(回答)"
            Public Const ANS_TAXI_RMKS_17 As String = "タクシーチケット17:備考(回答)"
            Public Const ANS_TAXI_DATE_18 As String = "タクシーチケット18:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_18 As String = "タクシーチケット18:券種(回答)"
            Public Const ANS_TAXI_NO_18 As String = "タクシーチケット18:番号(回答)"
            Public Const ANS_TAXI_HAKKO_18 As String = "タクシーチケット18:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_18 As String = "タクシーチケット18:発行日(回答)"
            Public Const ANS_TAXI_RMKS_18 As String = "タクシーチケット18:備考(回答)"
            Public Const ANS_TAXI_DATE_19 As String = "タクシーチケット19:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_19 As String = "タクシーチケット19:券種(回答)"
            Public Const ANS_TAXI_NO_19 As String = "タクシーチケット19:番号(回答)"
            Public Const ANS_TAXI_HAKKO_19 As String = "タクシーチケット19:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_19 As String = "タクシーチケット19:発行日(回答)"
            Public Const ANS_TAXI_RMKS_19 As String = "タクシーチケット19:備考(回答)"
            Public Const ANS_TAXI_DATE_20 As String = "タクシーチケット20:利用日(回答)"
            Public Const ANS_TAXI_KENSHU_20 As String = "タクシーチケット20:券種(回答)"
            Public Const ANS_TAXI_NO_20 As String = "タクシーチケット20:番号(回答)"
            Public Const ANS_TAXI_HAKKO_20 As String = "タクシーチケット20:発行フラグ(回答)"
            Public Const ANS_TAXI_HAKKO_DATE_20 As String = "タクシーチケット20:発行日(回答)"
            Public Const ANS_TAXI_RMKS_20 As String = "タクシーチケット20:備考(回答)"
            Public Const ANS_TAXI_NOTE As String = "タクシーチケット:備考(回答)"
            Public Const REQ_MR_O_TEHAI As String = "社員用往路臨席希望(依頼)"
            Public Const REQ_MR_F_TEHAI As String = "社員用復路臨席希望(依頼)"
            Public Const MR_SEX As String = "MR性別(航空券の場合)"
            Public Const MR_AGE As String = "MR年齢(航空券の場合)"
            Public Const REQ_MR_HOTEL_NOTE As String = "社員用交通・宿泊備考"
            Public Const ANS_MR_O_TEHAI As String = "社員用往路手配(回答)"
            Public Const ANS_MR_F_TEHAI As String = "社員用復路手配(回答)"
            Public Const ANS_MR_HOTEL_NOTE As String = "社員用交通・宿泊備考(回答)"
            Public Const ANS_MR_KOTSUHI As String = "【回答】MR 交通費"
            Public Const ANS_MR_HOTELHI As String = "【回答】MR 宿泊費"
            Public Const ANS_MR_HOTELHI_TOZEI As String = "【回答】MR 宿泊都税"
            Public Const SEND_FLAG As String = "送信フラグ"
            Public Const TTANTO_ID As String = "トップツアー担当者ID"
            Public Const SEIKYU_NO_TOPTOUR As String = "トップツアー請求番号"
            Public Const SCAN_IMPORT_DATE As String = "スキャンデータ取込日"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
            Public Const SEND_DATE As String = "発送日"

            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const KOUENKAI_TIME_STAMP As String = "TimeStamp"
            Public Const TORIKESHI_FLG As String = "取消フラグ"
            Public Const TAXI_PRT_NAME As String = "チケット印字名"
            Public Const KAIJO_NAME As String = "会場名"
            Public Const FROM_DATE As String = "開催日FROM"
            Public Const TO_DATE As String = "開催日TO"
            Public Const USER_NAME As String = "トップツアー担当者"
        End Class
    End Class

    Public Class TBL_KAIJO
        <Serializable()> Public Structure DataStruct
            Public SALEFORCE_ID As String
            Public TEHAI_ID As String
            Public KOUENKAI_NO As String
            Public REQ_STATUS_TEHAI As String
            Public ANS_STATUS_TEHAI As String
            Public TIME_STAMP_BYL As String
            Public TIME_STAMP_TOP As String
            Public SHONIN_NAME As String
            Public SHONIN_DATE As String
            Public KAISAI_DATE_NOTE As String
            Public KAISAI_KIBOU_ADDRESS1 As String
            Public KAISAI_KIBOU_ADDRESS2 As String
            Public KAISAI_KIBOU_NOTE As String
            Public KOUEN_TIME1 As String
            Public KOUEN_TIME2 As String
            Public KOUEN_KAIJO_LAYOUT As String
            Public IKENKOUKAN_KAIJO_TEHAI As String
            Public IROUKAI_KAIJO_TEHAI As String
            Public IROUKAI_SANKA_YOTEI_CNT As String
            Public KOUSHI_ROOM_TEHAI As String
            Public KOUSHI_ROOM_FROM As String
            Public KOUSHI_ROOM_CNT As String
            Public SHAIN_ROOM_TEHAI As String
            Public SHAIN_ROOM_CNT As String
            Public MANAGER_KAIJO_TEHAI As String
            Public MANAGER_ROOM_FROM As String
            Public MANAGER_ROOM_CNT As String
            Public REQ_ROOM_CNT As String
            Public REQ_STAY_DATE As String
            Public REQ_KOTSU_CNT As String
            Public REQ_TAXI_CNT As String
            Public KAIJO_URL As String
            Public OTHER_NOTE As String
            Public ANS_SENTEI_RIYU As String
            Public ANS_MITSUMORI_TF As String
            Public ANS_MITSUMORI_T As String
            Public ANS_MITSUMORI_TOTAL As String
            Public ANS_MITSUMORI_URL As String
            Public ANS_SHISETSU_NAME As String
            Public ANS_SHISETSU_ZIP As String
            Public ANS_SHISETSU_ADDRESS As String
            Public ANS_SHISETSU_TEL As String
            Public ANS_SHISETSU_URL As String
            Public ANS_KOUEN_KAIJO_NAME As String
            Public ANS_KOUEN_KAIJO_FLOOR As String
            Public ANS_IKENKOUKAN_KAIJO_NAME As String
            Public ANS_IROUKAI_KAIJO_NAME As String
            Public ANS_KOUSHI_ROOM_NAME As String
            Public ANS_SHAIN_ROOM_NAME As String
            Public ANS_MANAGER_KAIJO_NAME As String
            Public ANS_KAISAI_NOTE As String
            Public ANS_KAIJOUHI_TF As String
            Public ANS_KIZAIHI_TF As String
            Public ANS_INSHOKUHI_TF As String
            Public ANS_991330401_TF As String
            Public ANS_HOTELHI_TF As String
            Public ANS_KOTSUHI_TF As String
            Public ANS_TAXI_TF As String
            Public ANS_TEHAI_TESURYO_TF As String
            Public ANS_TAXI_HAKKEN_TESURYO_TF As String
            Public ANS_TAXI_SEISAN_TESURYO_TF As String
            Public ANS_JINKENHI_TF As String
            Public ANS_OTHER_TF As String
            Public ANS_KANRIHI_TF As String
            Public ANS_41120200_TF As String
            Public ANS_TOTAL_TF As String
            Public ANS_KAIJOUHI_T As String
            Public ANS_KIZAIHI_T As String
            Public ANS_INSHOKUHI_T As String
            Public ANS_991330401_T As String
            Public ANS_JINKENHI_T As String
            Public ANS_OTHER_T As String
            Public ANS_KANRIHI_T As String
            Public ANS_41120200_T As String
            Public ANS_TOTAL_T As String
            Public SEND_FLAG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String

            Public TIME_STAMP As String
            Public TORIKESHI_FLG As String
            Public KIDOKU_FLG As String
            Public KOUENKAI_TITLE As String
            Public KOUENKAI_NAME As String
            Public TAXI_PRT_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public KAIJO_NAME As String
            Public SEIHIN_NAME As String
            Public INTERNAL_ORDER_T As String
            Public INTERNAL_ORDER_TF As String
            Public ACCOUNT_CD_T As String
            Public ACCOUNT_CD_TF As String
            Public ZETIA_CD As String
            Public SANKA_YOTEI_CNT_NMBR As String
            Public SANKA_YOTEI_CNT_MBR As String
            Public SRM_HACYU_KBN As String
            Public BU As String
            Public KIKAKU_TANTO_JIGYOUBU As String
            Public KIKAKU_TANTO_AREA As String
            Public KIKAKU_TANTO_EIGYOSHO As String
            Public KIKAKU_TANTO_NAME As String
            Public KIKAKU_TANTO_ROMA As String
            Public KIKAKU_TANTO_EMAIL_PC As String
            Public KIKAKU_TANTO_EMAIL_KEITAI As String
            Public KIKAKU_TANTO_KEITAI As String
            Public KIKAKU_TANTO_TEL As String
            Public COST_CENTER As String
            Public TEHAI_TANTO_BU As String
            Public TEHAI_TANTO_AREA As String
            Public TEHAI_TANTO_EIGYOSHO As String
            Public TEHAI_TANTO_NAME As String
            Public TEHAI_TANTO_ROMA As String
            Public TEHAI_TANTO_EMAIL_PC As String
            Public TEHAI_TANTO_EMAIL_KEITAI As String
            Public TEHAI_TANTO_KEITAI As String
            Public TEHAI_TANTO_TEL As String
            Public YOSAN_TF As String
            Public YOSAN_T As String
            Public TTANTO_ID As String
            Public IROUKAI_YOSAN_T As String
            Public IKENKOUKAN_YOSAN_T As String
            Public USER_NAME As String
        End Structure
        Public Class Column
            Public Const SALEFORCE_ID As String = "SALEFORCE_ID"
            Public Const TEHAI_ID As String = "TEHAI_ID"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const REQ_STATUS_TEHAI As String = "REQ_STATUS_TEHAI"
            Public Const ANS_STATUS_TEHAI As String = "ANS_STATUS_TEHAI"
            Public Const TIME_STAMP_BYL As String = "TIME_STAMP_BYL"
            Public Const TIME_STAMP_TOP As String = "TIME_STAMP_TOP"
            Public Const SHONIN_NAME As String = "SHONIN_NAME"
            Public Const SHONIN_DATE As String = "SHONIN_DATE"
            Public Const KAISAI_DATE_NOTE As String = "KAISAI_DATE_NOTE"
            Public Const KAISAI_KIBOU_ADDRESS1 As String = "KAISAI_KIBOU_ADDRESS1"
            Public Const KAISAI_KIBOU_ADDRESS2 As String = "KAISAI_KIBOU_ADDRESS2"
            Public Const KAISAI_KIBOU_NOTE As String = "KAISAI_KIBOU_NOTE"
            Public Const KOUEN_TIME1 As String = "KOUEN_TIME1"
            Public Const KOUEN_TIME2 As String = "KOUEN_TIME2"
            Public Const KOUEN_KAIJO_LAYOUT As String = "KOUEN_KAIJO_LAYOUT"
            Public Const IKENKOUKAN_KAIJO_TEHAI As String = "IKENKOUKAN_KAIJO_TEHAI"
            Public Const IROUKAI_KAIJO_TEHAI As String = "IROUKAI_KAIJO_TEHAI"
            Public Const IROUKAI_SANKA_YOTEI_CNT As String = "IROUKAI_SANKA_YOTEI_CNT"
            Public Const KOUSHI_ROOM_TEHAI As String = "KOUSHI_ROOM_TEHAI"
            Public Const KOUSHI_ROOM_FROM As String = "KOUSHI_ROOM_FROM"
            Public Const KOUSHI_ROOM_CNT As String = "KOUSHI_ROOM_CNT"
            Public Const SHAIN_ROOM_TEHAI As String = "SHAIN_ROOM_TEHAI"
            Public Const SHAIN_ROOM_CNT As String = "SHAIN_ROOM_CNT"
            Public Const MANAGER_KAIJO_TEHAI As String = "MANAGER_KAIJO_TEHAI"
            Public Const MANAGER_ROOM_FROM As String = "MANAGER_ROOM_FROM"
            Public Const MANAGER_ROOM_CNT As String = "MANAGER_ROOM_CNT"
            Public Const REQ_ROOM_CNT As String = "REQ_ROOM_CNT"
            Public Const REQ_STAY_DATE As String = "REQ_STAY_DATE"
            Public Const REQ_KOTSU_CNT As String = "REQ_KOTSU_CNT"
            Public Const REQ_TAXI_CNT As String = "REQ_TAXI_CNT"
            Public Const KAIJO_URL As String = "KAIJO_URL"
            Public Const OTHER_NOTE As String = "OTHER_NOTE"
            Public Const ANS_SENTEI_RIYU As String = "ANS_SENTEI_RIYU"
            Public Const ANS_MITSUMORI_TF As String = "ANS_MITSUMORI_TF"
            Public Const ANS_MITSUMORI_T As String = "ANS_MITSUMORI_T"
            Public Const ANS_MITSUMORI_TOTAL As String = "ANS_MITSUMORI_TOTAL"
            Public Const ANS_MITSUMORI_URL As String = "ANS_MITSUMORI_URL"
            Public Const ANS_SHISETSU_NAME As String = "ANS_SHISETSU_NAME"
            Public Const ANS_SHISETSU_ZIP As String = "ANS_SHISETSU_ZIP"
            Public Const ANS_SHISETSU_ADDRESS As String = "ANS_SHISETSU_ADDRESS"
            Public Const ANS_SHISETSU_TEL As String = "ANS_SHISETSU_TEL"
            Public Const ANS_SHISETSU_URL As String = "ANS_SHISETSU_URL"
            Public Const ANS_KOUEN_KAIJO_NAME As String = "ANS_KOUEN_KAIJO_NAME"
            Public Const ANS_KOUEN_KAIJO_FLOOR As String = "ANS_KOUEN_KAIJO_FLOOR"
            Public Const ANS_IKENKOUKAN_KAIJO_NAME As String = "ANS_IKENKOUKAN_KAIJO_NAME"
            Public Const ANS_IROUKAI_KAIJO_NAME As String = "ANS_IROUKAI_KAIJO_NAME"
            Public Const ANS_KOUSHI_ROOM_NAME As String = "ANS_KOUSHI_ROOM_NAME"
            Public Const ANS_SHAIN_ROOM_NAME As String = "ANS_SHAIN_ROOM_NAME"
            Public Const ANS_MANAGER_KAIJO_NAME As String = "ANS_MANAGER_KAIJO_NAME"
            Public Const ANS_KAISAI_NOTE As String = "ANS_KAISAI_NOTE"
            Public Const ANS_KAIJOUHI_TF As String = "ANS_KAIJOUHI_TF"
            Public Const ANS_KIZAIHI_TF As String = "ANS_KIZAIHI_TF"
            Public Const ANS_INSHOKUHI_TF As String = "ANS_INSHOKUHI_TF"
            Public Const ANS_991330401_TF As String = "ANS_991330401_TF"
            Public Const ANS_HOTELHI_TF As String = "ANS_HOTELHI_TF"
            Public Const ANS_KOTSUHI_TF As String = "ANS_KOTSUHI_TF"
            Public Const ANS_TAXI_TF As String = "ANS_TAXI_TF"
            Public Const ANS_TEHAI_TESURYO_TF As String = "ANS_TEHAI_TESURYO_TF"
            Public Const ANS_TAXI_HAKKEN_TESURYO_TF As String = "ANS_TAXI_HAKKEN_TESURYO_TF"
            Public Const ANS_TAXI_SEISAN_TESURYO_TF As String = "ANS_TAXI_SEISAN_TESURYO_TF"
            Public Const ANS_JINKENHI_TF As String = "ANS_JINKENHI_TF"
            Public Const ANS_OTHER_TF As String = "ANS_OTHER_TF"
            Public Const ANS_KANRIHI_TF As String = "ANS_KANRIHI_TF"
            Public Const ANS_41120200_TF As String = "ANS_41120200_TF"
            Public Const ANS_TOTAL_TF As String = "ANS_TOTAL_TF"
            Public Const ANS_KAIJOUHI_T As String = "ANS_KAIJOUHI_T"
            Public Const ANS_KIZAIHI_T As String = "ANS_KIZAIHI_T"
            Public Const ANS_INSHOKUHI_T As String = "ANS_INSHOKUHI_T"
            Public Const ANS_991330401_T As String = "ANS_991330401_T"
            Public Const ANS_JINKENHI_T As String = "ANS_JINKENHI_T"
            Public Const ANS_OTHER_T As String = "ANS_OTHER_T"
            Public Const ANS_KANRIHI_T As String = "ANS_KANRIHI_T"
            Public Const ANS_41120200_T As String = "ANS_41120200_T"
            Public Const ANS_TOTAL_T As String = "ANS_TOTAL_T"
            Public Const SEND_FLAG As String = "SEND_FLAG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"

            Public Const TIME_STAMP As String = "TIME_STAMP"
            Public Const TORIKESHI_FLG As String = "TORIKESHI_FLG"
            Public Const KIDOKU_FLG As String = "KIDOKU_FLG"
            Public Const KOUENKAI_TITLE As String = "KOUENKAI_TITLE"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const TAXI_PRT_NAME As String = "TAXI_PRT_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const KAIJO_NAME As String = "KAIJO_NAME"
            Public Const SEIHIN_NAME As String = "SEIHIN_NAME"
            Public Const INTERNAL_ORDER_T As String = "INTERNAL_ORDER_T"
            Public Const INTERNAL_ORDER_TF As String = "INTERNAL_ORDER_TF"
            Public Const ACCOUNT_CD_T As String = "ACCOUNT_CD_T"
            Public Const ACCOUNT_CD_TF As String = "ACCOUNT_CD_TF"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const SANKA_YOTEI_CNT_NMBR As String = "SANKA_YOTEI_CNT_NMBR"
            Public Const SANKA_YOTEI_CNT_MBR As String = "SANKA_YOTEI_CNT_MBR"
            Public Const SRM_HACYU_KBN As String = "SRM_HACYU_KBN"
            Public Const BU As String = "BU"
            Public Const KIKAKU_TANTO_JIGYOUBU As String = "KIKAKU_TANTO_JIGYOUBU"
            Public Const KIKAKU_TANTO_AREA As String = "KIKAKU_TANTO_AREA"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "KIKAKU_TANTO_EIGYOSHO"
            Public Const KIKAKU_TANTO_NAME As String = "KIKAKU_TANTO_NAME"
            Public Const KIKAKU_TANTO_ROMA As String = "KIKAKU_TANTO_ROMA"
            Public Const KIKAKU_TANTO_EMAIL_PC As String = "KIKAKU_TANTO_EMAIL_PC"
            Public Const KIKAKU_TANTO_EMAIL_KEITAI As String = "KIKAKU_TANTO_EMAIL_KEITAI"
            Public Const KIKAKU_TANTO_KEITAI As String = "KIKAKU_TANTO_KEITAI"
            Public Const KIKAKU_TANTO_TEL As String = "KIKAKU_TANTO_TEL"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const TEHAI_TANTO_BU As String = "TEHAI_TANTO_BU"
            Public Const TEHAI_TANTO_AREA As String = "TEHAI_TANTO_AREA"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "TEHAI_TANTO_EIGYOSHO"
            Public Const TEHAI_TANTO_NAME As String = "TEHAI_TANTO_NAME"
            Public Const TEHAI_TANTO_ROMA As String = "TEHAI_TANTO_ROMA"
            Public Const TEHAI_TANTO_EMAIL_PC As String = "TEHAI_TANTO_EMAIL_PC"
            Public Const TEHAI_TANTO_EMAIL_KEITAI As String = "TEHAI_TANTO_EMAIL_KEITAI"
            Public Const TEHAI_TANTO_KEITAI As String = "TEHAI_TANTO_KEITAI"
            Public Const TEHAI_TANTO_TEL As String = "TEHAI_TANTO_TEL"
            Public Const YOSAN_TF As String = "YOSAN_TF"
            Public Const YOSAN_T As String = "YOSAN_T"
            Public Const TTANTO_ID As String = "TTANTO_ID"
            Public Const IROUKAI_YOSAN_T As String = "IROUKAI_YOSAN_T"
            Public Const IKENKOUKAN_YOSAN_T As String = "IKENKOUKAN_YOSAN_T"
            Public Const USER_NAME As String = "USER_NAME"
        End Class
        Public Class Name
            Public Const SALEFORCE_ID As String = "SalesForceID"
            Public Const TEHAI_ID As String = "講演会手配ID"
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const REQ_STATUS_TEHAI As String = "手配ステータス(依頼)"
            Public Const ANS_STATUS_TEHAI As String = "手配ステータス(回答)"
            Public Const TIME_STAMP_BYL As String = "Timestamp(BYL)"
            Public Const TIME_STAMP_TOP As String = "Timestamp(TOP)"
            Public Const SHONIN_NAME As String = "承認者(氏名)"
            Public Const SHONIN_DATE As String = "承認日"
            Public Const KAISAI_DATE_NOTE As String = "開催日備考欄"
            Public Const KAISAI_KIBOU_ADDRESS1 As String = "開催希望地 (都道府県)"
            Public Const KAISAI_KIBOU_ADDRESS2 As String = "開催希望地 (市町村)"
            Public Const KAISAI_KIBOU_NOTE As String = "開催希望 (フリーテキスト)"
            Public Const KOUEN_TIME1 As String = "講演会 開始時間"
            Public Const KOUEN_TIME2 As String = "講演会 終了時間"
            Public Const KOUEN_KAIJO_LAYOUT As String = "講演会場 レイアウト"
            Public Const IKENKOUKAN_KAIJO_TEHAI As String = "意見交換会場 要・不要"
            Public Const IROUKAI_KAIJO_TEHAI As String = "慰労会会場 (要・不要)"
            Public Const IROUKAI_SANKA_YOTEI_CNT As String = "慰労会参加予定者数"
            Public Const KOUSHI_ROOM_TEHAI As String = "講師控室 要・不要"
            Public Const KOUSHI_ROOM_FROM As String = "講師控室 時間From"
            Public Const KOUSHI_ROOM_CNT As String = "講師控室 人数"
            Public Const SHAIN_ROOM_TEHAI As String = "社員控室  (要・不要)"
            Public Const SHAIN_ROOM_CNT As String = "社員控室 人数"
            Public Const MANAGER_KAIJO_TEHAI As String = "世話人会場 要・不要"
            Public Const MANAGER_ROOM_FROM As String = "世話人控室 時間From"
            Public Const MANAGER_ROOM_CNT As String = "世話人控室 人数"
            Public Const REQ_ROOM_CNT As String = "宿泊希望室数"
            Public Const REQ_STAY_DATE As String = "宿泊希望日"
            Public Const REQ_KOTSU_CNT As String = "交通手配予定人数(JR/AIR)"
            Public Const REQ_TAXI_CNT As String = "タクシー手配予定人数"
            Public Const KAIJO_URL As String = "会場URL"
            Public Const OTHER_NOTE As String = "その他備考欄"
            Public Const ANS_SENTEI_RIYU As String = "【回答】施設選定理由"
            Public Const ANS_MITSUMORI_TF As String = "【回答】 概算見積_非課税"
            Public Const ANS_MITSUMORI_T As String = "【回答】 概算見積_課税"
            Public Const ANS_MITSUMORI_TOTAL As String = "【回答】 利用額 合計"
            Public Const ANS_MITSUMORI_URL As String = "【回答】 見積書 保存場所URL"
            Public Const ANS_SHISETSU_NAME As String = "【回答】 開催地 (施設名)"
            Public Const ANS_SHISETSU_ZIP As String = "【回答】 開催地 (施設郵便番号)"
            Public Const ANS_SHISETSU_ADDRESS As String = "【回答】 開催地 (施設住所)"
            Public Const ANS_SHISETSU_TEL As String = "【回答】 開催地 (施設TEL)"
            Public Const ANS_SHISETSU_URL As String = "【回答】 開催地 (施設HP URL)"
            Public Const ANS_KOUEN_KAIJO_NAME As String = "【回答】 開催地 (講演会会場名)"
            Public Const ANS_KOUEN_KAIJO_FLOOR As String = "【回答】 開催地 (講演会会場フロア)"
            Public Const ANS_IKENKOUKAN_KAIJO_NAME As String = "【回答】 開催地 (意見交換会場名)"
            Public Const ANS_IROUKAI_KAIJO_NAME As String = "【回答】 開催地 (慰労会会場名)"
            Public Const ANS_KOUSHI_ROOM_NAME As String = "【回答】 開催地 (講師控室会場名)"
            Public Const ANS_SHAIN_ROOM_NAME As String = "【回答】 開催地 (社員控室会場名)"
            Public Const ANS_MANAGER_KAIJO_NAME As String = "【回答】 開催地 (世話人会会場名)"
            Public Const ANS_KAISAI_NOTE As String = "【回答】 開催地 (備考欄)"
            Public Const ANS_KAIJOUHI_TF As String = "【回答】概算見積_会場費(非課税)"
            Public Const ANS_KIZAIHI_TF As String = "【回答】概算見積_機材費(非課税)"
            Public Const ANS_INSHOKUHI_TF As String = "【回答】概算見積_飲食費(非課税)"
            Public Const ANS_991330401_TF As String = "【回答】991330401(非課税)小計"
            Public Const ANS_HOTELHI_TF As String = "【回答】概算見積_宿泊費(非課税)"
            Public Const ANS_KOTSUHI_TF As String = "【回答】概算見積_交通費(非課税)"
            Public Const ANS_TAXI_TF As String = "【回答】概算見積_タクシー実車料金(非課税)"
            Public Const ANS_TEHAI_TESURYO_TF As String = "【回答】概算見積_交通宿泊手配手数料(非課税)"
            Public Const ANS_TAXI_HAKKEN_TESURYO_TF As String = "【回答】概算見積_タクシー発券手数料(非課税)"
            Public Const ANS_TAXI_SEISAN_TESURYO_TF As String = "【回答】概算見積_タクシー精算手数料(非課税)"
            Public Const ANS_JINKENHI_TF As String = "【回答】概算見積_人件費(非課税)"
            Public Const ANS_OTHER_TF As String = "【回答】概算見積_その他(非課税)"
            Public Const ANS_KANRIHI_TF As String = "【回答】概算見積_管理費(非課税)"
            Public Const ANS_41120200_TF As String = "【回答】41120200 (非課税)小計"
            Public Const ANS_TOTAL_TF As String = "【回答】非課税合計"
            Public Const ANS_KAIJOUHI_T As String = "【回答】概算見積_会場費(課税)"
            Public Const ANS_KIZAIHI_T As String = "【回答】概算見積_機材費(課税)"
            Public Const ANS_INSHOKUHI_T As String = "【回答】概算見積_飲食費(課税)"
            Public Const ANS_991330401_T As String = "【回答】991330401(課税)小計"
            Public Const ANS_JINKENHI_T As String = "【回答】概算見積_人件費(課税)"
            Public Const ANS_OTHER_T As String = "【回答】概算見積_その他(課税)"
            Public Const ANS_KANRIHI_T As String = "【回答】概算見積_管理費(課税)"
            Public Const ANS_41120200_T As String = "【回答】41120200(課税)小計"
            Public Const ANS_TOTAL_T As String = "【回答】課税合計"
            Public Const SEND_FLAG As String = "送信フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
            Public Const USER_NAME As String = "TOP担当者"
        End Class
    End Class

    Public Class TBL_BENTO
        <Serializable()> Public Structure DataStruct
            Public ID As String
            Public KINKYU_FLG As String
            Public RAIJO_FLG As String
            Public AREA As String
            Public ADDRESS As String
            Public EIGYOSHO As String
            Public ZIP As String
            Public TANTO_NO As String
            Public TANTO_NAME As String
            Public TANTO_KANA As String
            Public INTERNAL_ORDER_T As String
            Public ACCOUNT_CODE_T As String
            Public TEL As String
            Public EMAIL As String
            Public SEND_SAKI_FS As String
            Public DR_MPID As String
            Public DR_NAME As String
            Public DR_KANA As String
            Public DR_SHISETSU_NAME As String
            Public DR_CD As String
            Public DR_SHISETSU_CD As String
            Public DR_ADDRESS As String
            Public DR_GOFFICIAL As String
            Public DR_YAKUWARI As String
            Public KOUENKAI_NAME As String
            Public KOUENKAI_DATE As String
            Public KOUENKAI_NO As String
            Public KAIJO As String
            Public BU As String
            Public ACCOUNT_CODE As String
            Public COST_CENTER As String
            Public INTERNAL_ORDER As String
            Public ZETIA_CD As String
            Public STATUS_SHONIN As String
            Public SHONIN_NAME As String
            Public SHONIN_TIME As String
            Public SHONIN_NOTE As String
            Public CMSHONIN_NAME As String
            Public CMSHONIN_TIME As String
            Public CMSHONIN_NOTE As String
            Public STATUS_TEHAI As String
            Public HAITATSU_DATE As String
            Public HAITATSU_KIBOU_TIME As String
            Public HAITATSU_ADDRESS As String
            Public HAITATSU_SHISETSU As String
            Public SURYO As String
            Public TANKA As String
            Public KIBOU_MAKER As String
            Public KIBOU_MENU As String
            Public NOTE As String
            Public ANS_STATUS_TEHAI As String
            Public FIX_HAITATSU_TIME As String
            Public FIX_HAITATSU_ADDRESS As String
            Public FIX_HAITATSU_SHISETSU As String
            Public FIX_SURYO As String
            Public FIX_TANKA As String
            Public FIX_KINGAKU_TOTAL As String
            Public FIX_MAKER As String
            Public FIX_MAKER_CONTACT As String
            Public FIX_KIBOU_MAKER As String
            Public FIX_NOTE As String
        End Structure
        Public Class Column
            Public Const ID As String = "ID"
            Public Const KINKYU_FLG As String = "KINKYU_FLG"
            Public Const RAIJO_FLG As String = "RAIJO_FLG"
            Public Const AREA As String = "AREA"
            Public Const ADDRESS As String = "ADDRESS"
            Public Const EIGYOSHO As String = "EIGYOSHO"
            Public Const ZIP As String = "ZIP"
            Public Const TANTO_NO As String = "TANTO_NO"
            Public Const TANTO_NAME As String = "TANTO_NAME"
            Public Const TANTO_KANA As String = "TANTO_KANA"
            Public Const INTERNAL_ORDER_T As String = "INTERNAL_ORDER_T"
            Public Const ACCOUNT_CODE_T As String = "ACCOUNT_CODE_T"
            Public Const TEL As String = "TEL"
            Public Const EMAIL As String = "EMAIL"
            Public Const SEND_SAKI_FS As String = "SEND_SAKI_FS"
            Public Const DR_MPID As String = "DR_MPID"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const DR_KANA As String = "DR_KANA"
            Public Const DR_SHISETSU_NAME As String = "DR_SHISETSU_NAME"
            Public Const DR_CD As String = "DR_CD"
            Public Const DR_SHISETSU_CD As String = "DR_SHISETSU_CD"
            Public Const DR_ADDRESS As String = "DR_ADDRESS"
            Public Const DR_GOFFICIAL As String = "DR_GOFFICIAL"
            Public Const DR_YAKUWARI As String = "DR_YAKUWARI"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const KOUENKAI_DATE As String = "KOUENKAI_DATE"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const KAIJO As String = "KAIJO"
            Public Const BU As String = "BU"
            Public Const ACCOUNT_CODE As String = "ACCOUNT_CODE"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const INTERNAL_ORDER As String = "INTERNAL_ORDER"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const STATUS_SHONIN As String = "STATUS_SHONIN"
            Public Const SHONIN_NAME As String = "SHONIN_NAME"
            Public Const SHONIN_TIME As String = "SHONIN_TIME"
            Public Const SHONIN_NOTE As String = "SHONIN_NOTE"
            Public Const CMSHONIN_NAME As String = "CMSHONIN_NAME"
            Public Const CMSHONIN_TIME As String = "CMSHONIN_TIME"
            Public Const CMSHONIN_NOTE As String = "CMSHONIN_NOTE"
            Public Const STATUS_TEHAI As String = "STATUS_TEHAI"
            Public Const HAITATSU_DATE As String = "HAITATSU_DATE"
            Public Const HAITATSU_KIBOU_TIME As String = "HAITATSU_KIBOU_TIME"
            Public Const HAITATSU_ADDRESS As String = "HAITATSU_ADDRESS"
            Public Const HAITATSU_SHISETSU As String = "HAITATSU_SHISETSU"
            Public Const SURYO As String = "SURYO"
            Public Const TANKA As String = "TANKA"
            Public Const KIBOU_MAKER As String = "KIBOU_MAKER"
            Public Const KIBOU_MENU As String = "KIBOU_MENU"
            Public Const NOTE As String = "NOTE"
            Public Const ANS_STATUS_TEHAI As String = "ANS_STATUS_TEHAI"
            Public Const FIX_HAITATSU_TIME As String = "FIX_HAITATSU_TIME"
            Public Const FIX_HAITATSU_ADDRESS As String = "FIX_HAITATSU_ADDRESS"
            Public Const FIX_HAITATSU_SHISETSU As String = "FIX_HAITATSU_SHISETSU"
            Public Const FIX_SURYO As String = "FIX_SURYO"
            Public Const FIX_TANKA As String = "FIX_TANKA"
            Public Const FIX_KINGAKU_TOTAL As String = "FIX_KINGAKU_TOTAL"
            Public Const FIX_MAKER As String = "FIX_MAKER"
            Public Const FIX_MAKER_CONTACT As String = "FIX_MAKER_CONTACT"
            Public Const FIX_KIBOU_MAKER As String = "FIX_KIBOU_MAKER"
            Public Const FIX_NOTE As String = "FIX_NOTE"
        End Class
        Public Class Name
            Public Const ID As String = "ID"
            Public Const KINKYU_FLG As String = "緊急対応フラグ"
            Public Const RAIJO_FLG As String = "来場フラグ"
            Public Const AREA As String = "所属エリア"
            Public Const ADDRESS As String = "住所"
            Public Const EIGYOSHO As String = "営業所"
            Public Const ZIP As String = "郵便番号"
            Public Const TANTO_NO As String = "担当者No"
            Public Const TANTO_NAME As String = "担当者名"
            Public Const TANTO_KANA As String = "担当者名(カタカナ)"
            Public Const INTERNAL_ORDER_T As String = "課税Internal order"
            Public Const ACCOUNT_CODE_T As String = "課税Account code"
            Public Const TEL As String = "電話番号"
            Public Const EMAIL As String = "Emailアドレス"
            Public Const SEND_SAKI_FS As String = "送付先FS"
            Public Const DR_MPID As String = "MPID"
            Public Const DR_NAME As String = "DR氏名"
            Public Const DR_KANA As String = "DR氏名(全角カタカナ)"
            Public Const DR_SHISETSU_NAME As String = "施設名"
            Public Const DR_CD As String = "DRコード"
            Public Const DR_SHISETSU_CD As String = "DCF施設コード"
            Public Const DR_ADDRESS As String = "DR住所"
            Public Const DR_GOFFICIAL As String = "国家公務員"
            Public Const DR_YAKUWARI As String = "参加者役割"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const KOUENKAI_DATE As String = "講演会開催日"
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const KAIJO As String = "会場"
            Public Const BU As String = "BU"
            Public Const ACCOUNT_CODE As String = "Account Code"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const INTERNAL_ORDER As String = "Internal Order"
            Public Const ZETIA_CD As String = "Zetia Code"
            Public Const STATUS_SHONIN As String = "承認ステータス"
            Public Const SHONIN_NAME As String = "承認者"
            Public Const SHONIN_TIME As String = "承認時間"
            Public Const SHONIN_NOTE As String = "承認者備考"
            Public Const CMSHONIN_NAME As String = "CM承認者"
            Public Const CMSHONIN_TIME As String = "CM承認時間"
            Public Const CMSHONIN_NOTE As String = "CM承認者備考"
            Public Const STATUS_TEHAI As String = "手配ステータス"
            Public Const HAITATSU_DATE As String = "配達日(実施日)"
            Public Const HAITATSU_KIBOU_TIME As String = "利用(配達希望)時間"
            Public Const HAITATSU_ADDRESS As String = "利用(配達)住所"
            Public Const HAITATSU_SHISETSU As String = "利用(配達)施設名"
            Public Const SURYO As String = "数量"
            Public Const TANKA As String = "単価"
            Public Const KIBOU_MAKER As String = "希望弁当業者"
            Public Const KIBOU_MENU As String = "希望メニュー"
            Public Const NOTE As String = "特記事項"
            Public Const ANS_STATUS_TEHAI As String = "【回答】手配ステータス"
            Public Const FIX_HAITATSU_TIME As String = "【確定】利用(配達)時間"
            Public Const FIX_HAITATSU_ADDRESS As String = "【確定】利用(配達)住所"
            Public Const FIX_HAITATSU_SHISETSU As String = "【確定】利用(配達)施設名"
            Public Const FIX_SURYO As String = "【確定】数量"
            Public Const FIX_TANKA As String = "【確定】単価"
            Public Const FIX_KINGAKU_TOTAL As String = "【確定】確定金額 合計"
            Public Const FIX_MAKER As String = "【確定】弁当業者"
            Public Const FIX_MAKER_CONTACT As String = "【確定】弁当業者連絡先"
            Public Const FIX_KIBOU_MAKER As String = "【確定】希望メニュー"
            Public Const FIX_NOTE As String = "【確定】特記事項"
        End Class
    End Class

    Public Class TBL_COST
        <Serializable()> Public Structure DataStruct
            Public SEIKYU_NO As String
            Public SEIKYU_YM As String
            Public COSTCENTER_CD As String
            Public KOTSUHI As String
            Public HOTELHI As String
            Public TAXI_T As String
            Public TAXI_SEISAN_T As String
            Public SAP_FLAG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String

            Public DEL_FLAG As String

            'プロパティ
            Public ReadOnly Property pCOSTCENTER_CD() As String
                Get
                    Return COSTCENTER_CD
                End Get
            End Property
            Public ReadOnly Property pKOTSUHI() As String
                Get
                    Return KOTSUHI
                End Get
            End Property
            Public ReadOnly Property pHOTELHI() As String
                Get
                    Return HOTELHI
                End Get
            End Property
            Public ReadOnly Property pTAXI_T() As String
                Get
                    Return TAXI_T
                End Get
            End Property
            Public ReadOnly Property pTAXI_SEISAN_T() As String
                Get
                    Return TAXI_SEISAN_T
                End Get
            End Property
            Public ReadOnly Property pINPUT_DATE() As String
                Get
                    Return INPUT_DATE
                End Get
            End Property
            Public ReadOnly Property pINPUT_USER() As String
                Get
                    Return INPUT_USER
                End Get
            End Property
        End Structure
        Public Class Column
            Public Const SEIKYU_NO As String = "SEIKYU_NO"
            Public Const SEIKYU_YM As String = "SEIKYU_YM"
            Public Const COSTCENTER_CD As String = "COSTCENTER_CD"
            Public Const KOTSUHI As String = "KOTSUHI"
            Public Const HOTELHI As String = "HOTELHI"
            Public Const TAXI_T As String = "TAXI_T"
            Public Const TAXI_SEISAN_T As String = "TAXI_SEISAN_T"
            Public Const SAP_FLAG As String = "SAP_FLAG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"

            Public Const DEL_FLAG As String = "DEL_FLAG"
        End Class
        Public Class Name
            Public Const SEIKYU_NO As String = "請求番号"
            Public Const SEIKYU_YM As String = "請求年月"
            Public Const COSTCENTER_CD As String = "コストセンターコード"
            Public Const KOTSUHI As String = "交通費"
            Public Const HOTELHI As String = "宿泊費"
            Public Const TAXI_T As String = "タクチケ実車料金(課税)"
            Public Const TAXI_SEISAN_T As String = "タクチケ精算手数料(課税)"
            Public Const SAP_FLAG As String = "SAP作成フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class

    End Class

    Public Class MS_SHISETSU
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public ZIP As String
            Public ADDRESS1 As String
            Public ADDRESS2 As String
            Public SHISETSU_NAME As String
            Public SHISETSU_KANA As String
            Public TEL As String
            Public CHECKIN_TIME As String
            Public CHECKOUT_TIME As String
            Public URL As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const ZIP As String = "ZIP"
            Public Const ADDRESS1 As String = "ADDRESS1"
            Public Const ADDRESS2 As String = "ADDRESS2"
            Public Const SHISETSU_NAME As String = "SHISETSU_NAME"
            Public Const SHISETSU_KANA As String = "SHISETSU_KANA"
            Public Const TEL As String = "TEL"
            Public Const CHECKIN_TIME As String = "CHECKIN_TIME"
            Public Const CHECKOUT_TIME As String = "CHECKOUT_TIME"
            Public Const URL As String = "URL"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const ZIP As String = "郵便番号"
            Public Const ADDRESS1 As String = "都道府県"
            Public Const ADDRESS2 As String = "住所"
            Public Const SHISETSU_NAME As String = "施設名"
            Public Const SHISETSU_KANA As String = "施設名カナ"
            Public Const TEL As String = "施設電話番号"
            Public Const CHECKIN_TIME As String = "チェックイン時間"
            Public Const CHECKOUT_TIME As String = "チェックアウト時間"
            Public Const URL As String = "ホームページURL"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_USER
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public LOGIN_ID As String
            Public PASSWORD As String
            Public KENGEN As String
            Public KENGEN_SEISAN As String
            Public USER_NAME As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const LOGIN_ID As String = "LOGIN_ID"
            Public Const PASSWORD As String = "PASSWORD"
            Public Const KENGEN As String = "KENGEN"
            Public Const KENGEN_SEISAN As String = "KENGEN_SEISAN"
            Public Const USER_NAME As String = "USER_NAME"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const LOGIN_ID As String = "ログインID"
            Public Const PASSWORD As String = "パスワード"
            Public Const KENGEN As String = "権限"
            Public Const KENGEN_SEISAN As String = "精算入力権限"
            Public Const USER_NAME As String = "氏名"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_COSTCENTER
        <Serializable()> Public Structure DataStruct
            Public COSTCENTER_CD As String
            Public COSTCENTER_NAME As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const COSTCENTER_CD As String = "COSTCENTER_CD"
            Public Const COSTCENTER_NAME As String = "COSTCENTER_NAME"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const COSTCENTER_CD As String = "コストセンターコード"
            Public Const COSTCENTER_NAME As String = "コストセンター名称"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_BU
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public BU As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const BU As String = "BU"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const BU As String = "BU"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_AREA
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public AREA As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const AREA As String = "AREA"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const AREA As String = "エリア"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_SEIHIN
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public SEIHIN As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const SEIHIN As String = "SEIHIN"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const SEIHIN As String = "製品"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    'Public Class MS_EIGYOSHO
    '    <Serializable()> Public Structure DataStruct
    '        Public SYSTEM_ID As String
    '        Public 未定 As String
    '        Public STOP_FLG As String
    '        Public INPUT_DATE As String
    '        Public INPUT_USER As String
    '        Public UPDATE_DATE As String
    '        Public UPDATE_USER As String
    '    End Structure
    '    Public Class Column
    '        Public Const SYSTEM_ID As String = "SYSTEM_ID"
    '        Public Const 未定 As String = "未定"
    '        Public Const STOP_FLG As String = "STOP_FLG"
    '        Public Const INPUT_DATE As String = "INPUT_DATE"
    '        Public Const INPUT_USER As String = "INPUT_USER"
    '        Public Const UPDATE_DATE As String = "UPDATE_DATE"
    '        Public Const UPDATE_USER As String = "UPDATE_USER"
    '    End Class
    '    Public Class Name
    '        Public Const SYSTEM_ID As String = "システムID"
    '        Public Const 未定 As String = "未定"
    '        Public Const STOP_FLG As String = "利用停止フラグ"
    '        Public Const INPUT_DATE As String = "登録日時"
    '        Public Const INPUT_USER As String = "登録者"
    '        Public Const UPDATE_DATE As String = "更新日時"
    '        Public Const UPDATE_USER As String = "更新者"
    '    End Class
    'End Class

    Public Class MS_ZEI
        <Serializable()> Public Structure DataStruct
            Public ZEI_CD As String
            Public ZEI_NAME As String
            Public ZEI_RATE As String
            Public START_DATE As String
            Public END_DATE As String
            Public SAP_ZEI_CD As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const ZEI_CD As String = "ZEI_CD"
            Public Const ZEI_NAME As String = "ZEI_NAME"
            Public Const ZEI_RATE As String = "ZEI_RATE"
            Public Const START_DATE As String = "START_DATE"
            Public Const END_DATE As String = "END_DATE"
            Public Const SAP_ZEI_CD As String = "SAP_ZEI_CD"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const ZEI_CD As String = "消費税コード"
            Public Const ZEI_NAME As String = "消費税名称"
            Public Const ZEI_RATE As String = "消費税率"
            Public Const START_DATE As String = "開始日"
            Public Const END_DATE As String = "終了日"
            Public Const SAP_ZEI_CD As String = "SAP用税コード"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_CODE
        <Serializable()> Public Structure DataStruct
            Public CODE As String
            Public DATA_ID As String
            Public DISP_TEXT As String
            Public DISP_VALUE As String
        End Structure
        Public Class Column
            Public Const CODE As String = "CODE"
            Public Const DATA_ID As String = "DATA_ID"
            Public Const DISP_TEXT As String = "DISP_TEXT"
            Public Const DISP_VALUE As String = "DISP_VALUE"
        End Class
        Public Class Name
            Public Const CODE As String = ""
            Public Const DATA_ID As String = ""
            Public Const DISP_TEXT As String = ""
            Public Const DISP_VALUE As String = ""
        End Class
    End Class

    Public Class TBL_LOG
        <Serializable()> Public Structure DataStruct
            Public LOG_NO As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public SYORI_KBN As String
            Public SYORI_NAME As String
            Public TABLE_NAME As String
            Public STATUS As String
            Public NOTE As String
            Public USER_NAME As String
        End Structure
        Public Class Column
            Public Const LOG_NO As String = "LOG_NO"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const SYORI_KBN As String = "SYORI_KBN"
            Public Const SYORI_NAME As String = "SYORI_NAME"
            Public Const TABLE_NAME As String = "TABLE_NAME"
            Public Const STATUS As String = "STATUS"
            Public Const NOTE As String = "NOTE"
            Public Const USER_NAME As String = "USER_NAME"
        End Class
        Public Class Name
            Public Const LOG_NO As String = ""
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const SYORI_KBN As String = "処理区分"
            Public Const SYORI_NAME As String = "処理名"
            Public Const TABLE_NAME As String = "テーブル名"
            Public Const STATUS As String = "ステータス"
            Public Const NOTE As String = "備考"
            Public Const USER_NAME As String = "ログイン者"
        End Class
    End Class

    Public Class Joken
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public BU As String
            Public AREA As String
            Public EIGYOSHO As String
            Public TANTO_NAME As String
            Public TANTO_KANA As String
            Public KOUENKAI_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public TTANTO_ID As String
            Public KUBUN As String
            Public SEIHIN_NAME As String
            Public KIKAKU_TANTO_ROMA As String
            Public TEHAI_TANTO_ROMA As String
            Public REQ_STATUS_TEHAI As String
            Public ANS_STATUS_TEHAI As String
            Public ADDRESS1 As String
            Public ADDRESS2 As String
            Public SHISETSU_NAME As String
            Public SHISETSU_KANA As String
            Public LOGIN_ID As String
            Public USER_NAME As String
            Public STOP_FLG As String
            Public KENGEN As String
            Public KENGEN_SEISAN As String
            Public DR_SANKA As String
            Public MR_ROMA As String
            Public DR_KANA As String
            Public UPDATE_DATE As String
            Public EXPORTIMPORT As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public SYORI_KBN As String
            Public SYORI_NAME As String
            Public STATUS As String
            Public CODE As String
            Public SEIKYU_NO_TOPTOUR As String
            Public SANKASHA_ID As String
            Public SEIKYU_NO As String
            Public SEIKYU_YM As String
            Public SEISAN_YM As String
            Public SHOUNIN_KUBUN As String
            Public SHOUNIN_YM As String
            Public TIME_STAMP_BYL As String
            Public TTEHAI_MITOUROKU As String
            Public TKT_NO As String
            Public TKT_SEIKYU_YM As String
            Public TKT_ENTA As String
        End Structure
        Public Class Name
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const BU As String = "BU"
            Public Const AREA As String = "エリア"
            Public Const EIGYOSHO As String = "営業所"
            Public Const TANTO_NAME As String = "担当者名"
            Public Const TANTO_KANA As String = "担当者名(カタカナ)"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const FROM_DATE As String = "講演会開催日(From)"
            Public Const TO_DATE As String = "講演会開催日(To)"
            Public Const TTANTO_ID As String = "担当者"
            Public Const KUBUN As String = "区分"
            Public Const SEIHIN_NAME As String = "製品名"
            Public Const KIKAKU_TANTO_ROMA As String = "企画担当者名"
            Public Const TEHAI_TANTO_ROMA As String = "手配担当者名"
            Public Const REQ_STATUS_TEHAI As String = ""
            Public Const ANS_STATUS_TEHAI As String = ""
            Public Const ADDRESS1 As String = "都道府県"
            Public Const ADDRESS2 As String = "市区町村"
            Public Const SHISETSU_NAME As String = "施設名"
            Public Const SHISETSU_KANA As String = "施設名(カナ)"
            Public Const LOGIN_ID As String = "ログインID"
            Public Const USER_NAME As String = "氏名"
            Public Const KENGEN As String = "権限"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const SALESFORCE_ID As String = "SalesForceID"
            Public Const MR_ROMA As String = "Dr担当MR名(ローマ字)"
            Public Const DR_KANA As String = "Dr氏名(カナ)"
            Public Const UPDATE_DATE As String = "更新日"
            Public Const EXPORTIMPORT As String = "送信／受信"
            Public Const INPUT_DATE As String = "送受信日時"
            Public Const INPUT_USER As String = "処理ユーザ"
            Public Const SYORI_KBN As String = "処理区分"
            Public Const SYORI_NAME As String = "処理名"
            Public Const STATUS As String = "処理結果"
            Public Const CODE As String = "コード区分"
            Public Const SEIKYU_NO_TOPTOUR As String = "精算番号"
            Public Const SEIKYU_NO As String = "請求番号"
            Public Const SEIKYU_YM As String = "請求年月"
            Public Const SEISAN_YM As String = "トップツアー精算年月"
            Public Const SHOUNIN_KUBUN As String = "承認区分"
            Public Const TIME_STAMP_BYL As String = "Timestamp(BYL)"
            Public Const TKT_NO As String = "タクチケ番号"
        End Class
    End Class

    Public Class TehaishoJoken
        <Serializable()> Public Structure DataStruct
            Public SALEFORCE_ID As String
            Public SANKASHA_ID As String
            Public KOUENKAI_NO As String
            Public TIME_STAMP_BYL As String
            Public DR_MPID As String
        End Structure
        Public Class Column
            Public Const SALEFORCE_ID As String = "SALEFORCE_ID"
            Public Const SANKASHA_ID As String = "SANKASHA_ID"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const TIME_STAMP_BYL As String = "TIME_STAMP_BYL"
            Public Const DR_MPID As String = "DR_MPID"
        End Class
    End Class

    Public Class SAP_CSV
        <Serializable()> Public Structure DataStruct
            Public KUBUN As String
            Public KAISHA_CD As String
            Public SEIKYU_YMD As String
            Public DENPYO_TYPE As String
            Public SEIKYUSHO_NO As String
            Public DOC_HTEXT As String
            Public ACCOUNT As String
            Public KINGAKU As String
            Public ZEI_CD As String
            Public COST_CENTER As String
            Public INTERNAL_ORDER As String
            Public KAIGOU_MEI As String
            Public PAYMENT_BLOCK As String
            Public ZETIA_CD As String
            Public BARCODE As String

            Public DANTAI_CODE As String
            Public FROM_DATE As String
            Public KOUENKAI_NO As String
            Public KOUENKAI_NAME As String
            Public KIKAKU_TANTO_NAME As String
        End Structure
        Public Class Column
            Public Const KUBUN As String = "KUBUN"
            Public Const KAISHA_CD As String = "KAISHA_CD"
            Public Const SEIKYU_YMD As String = "SEIKYU_YMD"
            Public Const DENPYO_TYPE As String = "DENPYO_TYPE"
            Public Const SEIKYUSHO_NO As String = "SEIKYUSHO_NO"
            Public Const DOC_HTEXT As String = "DOC_HTEXT"
            Public Const ACCOUNT As String = "ACCOUNT"
            Public Const KINGAKU As String = "KINGAKU"
            Public Const ZEI_CD As String = "ZEI_CD"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const INTERNAL_ORDER As String = "INTERNAL_ORDER"
            Public Const KAIGOU_MEI As String = "KAIGOU_MEI"
            Public Const PAYMENT_BLOCK As String = "PAYMENT_BLOCK"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const BARCODE As String = "BARCODE"

            Public Const DANTAI_CODE As String = "DANTAI_CODE"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const KIKAKU_TANTO_NAME As String = "KIKAKU_TANTO_NAME"
        End Class
        Public Class Name
            Public Const KUBUN As String = "区分"
            Public Const KAISHA_CD As String = "会社コード"
            Public Const SEIKYU_YMD As String = "請求年月日"
            Public Const DENPYO_TYPE As String = "伝票タイプ"
            Public Const SEIKYUSHO_NO As String = "請求書番号"
            Public Const DOC_HTEXT As String = "ﾄﾞｷｭﾒﾝﾄﾍｯﾀﾞｰﾃｷｽﾄ"
            Public Const ACCOUNT As String = "Account"
            Public Const KINGAKU As String = "金額"
            Public Const ZEI_CD As String = "消費税コード"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const INTERNAL_ORDER As String = "Internal Order"
            Public Const KAIGOU_MEI As String = "支払番号"
            Public Const PAYMENT_BLOCK As String = "Payment block"
            Public Const ZETIA_CD As String = "Zetia Code"
            Public Const BARCODE As String = "ﾊﾞｰｺｰﾄﾞ"

            Public Const DANTAI_CODE As String = "団体コード"
            Public Const FROM_DATE As String = "実施日"
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const KIKAKU_TANTO_NAME As String = "BYL企画担当者名"
        End Class
    End Class

    Public Class MISHU_JOKEN
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public SEIKYU_NO_TOPTOUR As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const SEIKYU_NO_TOPTOUR As String = "SEIKYU_NO_TOPTOUR"
        End Class
    End Class

    Public Class TBL_TAXITICKET_HAKKO
        <Serializable()> Public Structure DataStruct
            Public TKT_KAISHA As String
            Public TKT_NO As String
            Public TKT_KENSHU As String
            Public KOUENKAI_NO As String
            Public SANKASHA_ID As String
            Public TKT_LINE_NO As String
            Public TKT_USED_DATE As String
            Public TKT_URIAGE As String
            Public TKT_SEISAN_FEE As String
            Public TKT_HAKKO_FEE As String
            Public TKT_ENTA As String
            Public TKT_VOID As String
            Public TKT_MIKETSU As String
            Public TKT_IMPORT_DATE As String
            Public TKT_SEIKYU_YM As String
            Public SEIKYU_NO_TOPTOUR As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String

            Public KOUENKAI_NAME As String
            Public TAXI_PRT_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public USER_NAME As String
            Public DR_MPID As String
            Public DR_CD As String
            Public DR_NAME As String
            Public DR_KANA As String
            Public DR_SHISETSU_CD As String
            Public DR_SHISETSU_NAME As String
            Public DR_SHISETSU_ADDRESS As String
            Public DR_YAKUWARI As String
            Public DR_SEX As String
            Public DR_AGE As String
            Public SHITEIGAI_RIYU As String
            Public DR_SANKA As String
            Public ANS_TAXI_DATE_1 As String
            Public ANS_TAXI_KENSHU_1 As String
            Public ANS_TAXI_NO_1 As String
            Public ANS_TAXI_HAKKO_1 As String
            Public ANS_TAXI_HAKKO_DATE_1 As String
            Public ANS_TAXI_RMKS_1 As String
            Public ANS_TAXI_DATE_2 As String
            Public ANS_TAXI_KENSHU_2 As String
            Public ANS_TAXI_NO_2 As String
            Public ANS_TAXI_HAKKO_2 As String
            Public ANS_TAXI_HAKKO_DATE_2 As String
            Public ANS_TAXI_RMKS_2 As String
            Public ANS_TAXI_DATE_3 As String
            Public ANS_TAXI_KENSHU_3 As String
            Public ANS_TAXI_NO_3 As String
            Public ANS_TAXI_HAKKO_3 As String
            Public ANS_TAXI_HAKKO_DATE_3 As String
            Public ANS_TAXI_RMKS_3 As String
            Public ANS_TAXI_DATE_4 As String
            Public ANS_TAXI_KENSHU_4 As String
            Public ANS_TAXI_NO_4 As String
            Public ANS_TAXI_HAKKO_4 As String
            Public ANS_TAXI_HAKKO_DATE_4 As String
            Public ANS_TAXI_RMKS_4 As String
            Public ANS_TAXI_DATE_5 As String
            Public ANS_TAXI_KENSHU_5 As String
            Public ANS_TAXI_NO_5 As String
            Public ANS_TAXI_HAKKO_5 As String
            Public ANS_TAXI_HAKKO_DATE_5 As String
            Public ANS_TAXI_RMKS_5 As String
            Public ANS_TAXI_DATE_6 As String
            Public ANS_TAXI_KENSHU_6 As String
            Public ANS_TAXI_NO_6 As String
            Public ANS_TAXI_HAKKO_6 As String
            Public ANS_TAXI_HAKKO_DATE_6 As String
            Public ANS_TAXI_RMKS_6 As String
            Public ANS_TAXI_DATE_7 As String
            Public ANS_TAXI_KENSHU_7 As String
            Public ANS_TAXI_NO_7 As String
            Public ANS_TAXI_HAKKO_7 As String
            Public ANS_TAXI_HAKKO_DATE_7 As String
            Public ANS_TAXI_RMKS_7 As String
            Public ANS_TAXI_DATE_8 As String
            Public ANS_TAXI_KENSHU_8 As String
            Public ANS_TAXI_NO_8 As String
            Public ANS_TAXI_HAKKO_8 As String
            Public ANS_TAXI_HAKKO_DATE_8 As String
            Public ANS_TAXI_RMKS_8 As String
            Public ANS_TAXI_DATE_9 As String
            Public ANS_TAXI_KENSHU_9 As String
            Public ANS_TAXI_NO_9 As String
            Public ANS_TAXI_HAKKO_9 As String
            Public ANS_TAXI_HAKKO_DATE_9 As String
            Public ANS_TAXI_RMKS_9 As String
            Public ANS_TAXI_DATE_10 As String
            Public ANS_TAXI_KENSHU_10 As String
            Public ANS_TAXI_NO_10 As String
            Public ANS_TAXI_HAKKO_10 As String
            Public ANS_TAXI_HAKKO_DATE_10 As String
            Public ANS_TAXI_RMKS_10 As String
            Public ANS_TAXI_DATE_11 As String
            Public ANS_TAXI_KENSHU_11 As String
            Public ANS_TAXI_NO_11 As String
            Public ANS_TAXI_HAKKO_11 As String
            Public ANS_TAXI_HAKKO_DATE_11 As String
            Public ANS_TAXI_RMKS_11 As String
            Public ANS_TAXI_DATE_12 As String
            Public ANS_TAXI_KENSHU_12 As String
            Public ANS_TAXI_NO_12 As String
            Public ANS_TAXI_HAKKO_12 As String
            Public ANS_TAXI_HAKKO_DATE_12 As String
            Public ANS_TAXI_RMKS_12 As String
            Public ANS_TAXI_DATE_13 As String
            Public ANS_TAXI_KENSHU_13 As String
            Public ANS_TAXI_NO_13 As String
            Public ANS_TAXI_HAKKO_13 As String
            Public ANS_TAXI_HAKKO_DATE_13 As String
            Public ANS_TAXI_RMKS_13 As String
            Public ANS_TAXI_DATE_14 As String
            Public ANS_TAXI_KENSHU_14 As String
            Public ANS_TAXI_NO_14 As String
            Public ANS_TAXI_HAKKO_14 As String
            Public ANS_TAXI_HAKKO_DATE_14 As String
            Public ANS_TAXI_RMKS_14 As String
            Public ANS_TAXI_DATE_15 As String
            Public ANS_TAXI_KENSHU_15 As String
            Public ANS_TAXI_NO_15 As String
            Public ANS_TAXI_HAKKO_15 As String
            Public ANS_TAXI_HAKKO_DATE_15 As String
            Public ANS_TAXI_RMKS_15 As String
            Public ANS_TAXI_DATE_16 As String
            Public ANS_TAXI_KENSHU_16 As String
            Public ANS_TAXI_NO_16 As String
            Public ANS_TAXI_HAKKO_16 As String
            Public ANS_TAXI_HAKKO_DATE_16 As String
            Public ANS_TAXI_RMKS_16 As String
            Public ANS_TAXI_DATE_17 As String
            Public ANS_TAXI_KENSHU_17 As String
            Public ANS_TAXI_NO_17 As String
            Public ANS_TAXI_HAKKO_17 As String
            Public ANS_TAXI_HAKKO_DATE_17 As String
            Public ANS_TAXI_RMKS_17 As String
            Public ANS_TAXI_DATE_18 As String
            Public ANS_TAXI_KENSHU_18 As String
            Public ANS_TAXI_NO_18 As String
            Public ANS_TAXI_HAKKO_18 As String
            Public ANS_TAXI_HAKKO_DATE_18 As String
            Public ANS_TAXI_RMKS_18 As String
            Public ANS_TAXI_DATE_19 As String
            Public ANS_TAXI_KENSHU_19 As String
            Public ANS_TAXI_NO_19 As String
            Public ANS_TAXI_HAKKO_19 As String
            Public ANS_TAXI_HAKKO_DATE_19 As String
            Public ANS_TAXI_RMKS_19 As String
            Public ANS_TAXI_DATE_20 As String
            Public ANS_TAXI_KENSHU_20 As String
            Public ANS_TAXI_NO_20 As String
            Public ANS_TAXI_HAKKO_20 As String
            Public ANS_TAXI_HAKKO_DATE_20 As String
            Public ANS_TAXI_RMKS_20 As String
            Public TAXI_HAKKO_DATE As String

            Public SALEFORCE_ID As String
            Public TIME_STAMP_BYL As String
            Public TAXI_KENSHU As String
            Public KAZEI_KBN As String
            Public COST_CENTER As String
            Public REQ_TAXI_DATE As String
        End Structure
        Public Class Column
            Public Const TKT_KAISHA As String = "TKT_KAISHA"
            Public Const TKT_NO As String = "TKT_NO"
            Public Const TKT_KENSHU As String = "TKT_KENSHU"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const SANKASHA_ID As String = "SANKASHA_ID"
            Public Const TKT_LINE_NO As String = "TKT_LINE_NO"
            Public Const TKT_USED_DATE As String = "TKT_USED_DATE"
            Public Const TKT_URIAGE As String = "TKT_URIAGE"
            Public Const TKT_SEISAN_FEE As String = "TKT_SEISAN_FEE"
            Public Const TKT_HAKKO_FEE As String = "TKT_HAKKO_FEE"
            Public Const TKT_ENTA As String = "TKT_ENTA"
            Public Const TKT_VOID As String = "TKT_VOID"
            Public Const TKT_MIKETSU As String = "TKT_MIKETSU"
            Public Const TKT_IMPORT_DATE As String = "TKT_IMPORT_DATE"
            Public Const TKT_SEIKYU_YM As String = "TKT_SEIKYU_YM"
            Public Const SEIKYU_NO_TOPTOUR As String = "SEIKYU_NO_TOPTOUR"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"

            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const TAXI_PRT_NAME As String = "TAXI_PRT_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const USER_NAME As String = "USER_NAME"
            Public Const DR_MPID As String = "DR_MPID"
            Public Const DR_CD As String = "DR_CD"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const DR_KANA As String = "DR_KANA"
            Public Const DR_SHISETSU_CD As String = "DR_SHISETSU_CD"
            Public Const DR_SHISETSU_NAME As String = "DR_SHISETSU_NAME"
            Public Const DR_SHISETSU_ADDRESS As String = "DR_SHISETSU_ADDRESS"
            Public Const DR_YAKUWARI As String = "DR_YAKUWARI"
            Public Const DR_SEX As String = "DR_SEX"
            Public Const DR_AGE As String = "DR_AGE"
            Public Const SHITEIGAI_RIYU As String = "SHITEIGAI_RIYU"
            Public Const DR_SANKA As String = "DR_SANKA"
            Public Const ANS_TAXI_DATE_1 As String = "ANS_TAXI_DATE_1"
            Public Const ANS_TAXI_KENSHU_1 As String = "ANS_TAXI_KENSHU_1"
            Public Const ANS_TAXI_NO_1 As String = "ANS_TAXI_NO_1"
            Public Const ANS_TAXI_HAKKO_1 As String = "ANS_TAXI_HAKKO_1"
            Public Const ANS_TAXI_HAKKO_DATE_1 As String = "ANS_TAXI_HAKKO_DATE_1"
            Public Const ANS_TAXI_RMKS_1 As String = "ANS_TAXI_RMKS_1"
            Public Const ANS_TAXI_DATE_2 As String = "ANS_TAXI_DATE_2"
            Public Const ANS_TAXI_KENSHU_2 As String = "ANS_TAXI_KENSHU_2"
            Public Const ANS_TAXI_NO_2 As String = "ANS_TAXI_NO_2"
            Public Const ANS_TAXI_HAKKO_2 As String = "ANS_TAXI_HAKKO_2"
            Public Const ANS_TAXI_HAKKO_DATE_2 As String = "ANS_TAXI_HAKKO_DATE_2"
            Public Const ANS_TAXI_RMKS_2 As String = "ANS_TAXI_RMKS_2"
            Public Const ANS_TAXI_DATE_3 As String = "ANS_TAXI_DATE_3"
            Public Const ANS_TAXI_KENSHU_3 As String = "ANS_TAXI_KENSHU_3"
            Public Const ANS_TAXI_NO_3 As String = "ANS_TAXI_NO_3"
            Public Const ANS_TAXI_HAKKO_3 As String = "ANS_TAXI_HAKKO_3"
            Public Const ANS_TAXI_HAKKO_DATE_3 As String = "ANS_TAXI_HAKKO_DATE_3"
            Public Const ANS_TAXI_RMKS_3 As String = "ANS_TAXI_RMKS_3"
            Public Const ANS_TAXI_DATE_4 As String = "ANS_TAXI_DATE_4"
            Public Const ANS_TAXI_KENSHU_4 As String = "ANS_TAXI_KENSHU_4"
            Public Const ANS_TAXI_NO_4 As String = "ANS_TAXI_NO_4"
            Public Const ANS_TAXI_HAKKO_4 As String = "ANS_TAXI_HAKKO_4"
            Public Const ANS_TAXI_HAKKO_DATE_4 As String = "ANS_TAXI_HAKKO_DATE_4"
            Public Const ANS_TAXI_RMKS_4 As String = "ANS_TAXI_RMKS_4"
            Public Const ANS_TAXI_DATE_5 As String = "ANS_TAXI_DATE_5"
            Public Const ANS_TAXI_KENSHU_5 As String = "ANS_TAXI_KENSHU_5"
            Public Const ANS_TAXI_NO_5 As String = "ANS_TAXI_NO_5"
            Public Const ANS_TAXI_HAKKO_5 As String = "ANS_TAXI_HAKKO_5"
            Public Const ANS_TAXI_HAKKO_DATE_5 As String = "ANS_TAXI_HAKKO_DATE_5"
            Public Const ANS_TAXI_RMKS_5 As String = "ANS_TAXI_RMKS_5"
            Public Const ANS_TAXI_DATE_6 As String = "ANS_TAXI_DATE_6"
            Public Const ANS_TAXI_KENSHU_6 As String = "ANS_TAXI_KENSHU_6"
            Public Const ANS_TAXI_NO_6 As String = "ANS_TAXI_NO_6"
            Public Const ANS_TAXI_HAKKO_6 As String = "ANS_TAXI_HAKKO_6"
            Public Const ANS_TAXI_HAKKO_DATE_6 As String = "ANS_TAXI_HAKKO_DATE_6"
            Public Const ANS_TAXI_RMKS_6 As String = "ANS_TAXI_RMKS_6"
            Public Const ANS_TAXI_DATE_7 As String = "ANS_TAXI_DATE_7"
            Public Const ANS_TAXI_KENSHU_7 As String = "ANS_TAXI_KENSHU_7"
            Public Const ANS_TAXI_NO_7 As String = "ANS_TAXI_NO_7"
            Public Const ANS_TAXI_HAKKO_7 As String = "ANS_TAXI_HAKKO_7"
            Public Const ANS_TAXI_HAKKO_DATE_7 As String = "ANS_TAXI_HAKKO_DATE_7"
            Public Const ANS_TAXI_RMKS_7 As String = "ANS_TAXI_RMKS_7"
            Public Const ANS_TAXI_DATE_8 As String = "ANS_TAXI_DATE_8"
            Public Const ANS_TAXI_KENSHU_8 As String = "ANS_TAXI_KENSHU_8"
            Public Const ANS_TAXI_NO_8 As String = "ANS_TAXI_NO_8"
            Public Const ANS_TAXI_HAKKO_8 As String = "ANS_TAXI_HAKKO_8"
            Public Const ANS_TAXI_HAKKO_DATE_8 As String = "ANS_TAXI_HAKKO_DATE_8"
            Public Const ANS_TAXI_RMKS_8 As String = "ANS_TAXI_RMKS_8"
            Public Const ANS_TAXI_DATE_9 As String = "ANS_TAXI_DATE_9"
            Public Const ANS_TAXI_KENSHU_9 As String = "ANS_TAXI_KENSHU_9"
            Public Const ANS_TAXI_NO_9 As String = "ANS_TAXI_NO_9"
            Public Const ANS_TAXI_HAKKO_9 As String = "ANS_TAXI_HAKKO_9"
            Public Const ANS_TAXI_HAKKO_DATE_9 As String = "ANS_TAXI_HAKKO_DATE_9"
            Public Const ANS_TAXI_RMKS_9 As String = "ANS_TAXI_RMKS_9"
            Public Const ANS_TAXI_DATE_10 As String = "ANS_TAXI_DATE_10"
            Public Const ANS_TAXI_KENSHU_10 As String = "ANS_TAXI_KENSHU_10"
            Public Const ANS_TAXI_NO_10 As String = "ANS_TAXI_NO_10"
            Public Const ANS_TAXI_HAKKO_10 As String = "ANS_TAXI_HAKKO_10"
            Public Const ANS_TAXI_HAKKO_DATE_10 As String = "ANS_TAXI_HAKKO_DATE_10"
            Public Const ANS_TAXI_RMKS_10 As String = "ANS_TAXI_RMKS_10"
            Public Const ANS_TAXI_DATE_11 As String = "ANS_TAXI_DATE_11"
            Public Const ANS_TAXI_KENSHU_11 As String = "ANS_TAXI_KENSHU_11"
            Public Const ANS_TAXI_NO_11 As String = "ANS_TAXI_NO_11"
            Public Const ANS_TAXI_HAKKO_11 As String = "ANS_TAXI_HAKKO_11"
            Public Const ANS_TAXI_HAKKO_DATE_11 As String = "ANS_TAXI_HAKKO_DATE_11"
            Public Const ANS_TAXI_RMKS_11 As String = "ANS_TAXI_RMKS_11"
            Public Const ANS_TAXI_DATE_12 As String = "ANS_TAXI_DATE_12"
            Public Const ANS_TAXI_KENSHU_12 As String = "ANS_TAXI_KENSHU_12"
            Public Const ANS_TAXI_NO_12 As String = "ANS_TAXI_NO_12"
            Public Const ANS_TAXI_HAKKO_12 As String = "ANS_TAXI_HAKKO_12"
            Public Const ANS_TAXI_HAKKO_DATE_12 As String = "ANS_TAXI_HAKKO_DATE_12"
            Public Const ANS_TAXI_RMKS_12 As String = "ANS_TAXI_RMKS_12"
            Public Const ANS_TAXI_DATE_13 As String = "ANS_TAXI_DATE_13"
            Public Const ANS_TAXI_KENSHU_13 As String = "ANS_TAXI_KENSHU_13"
            Public Const ANS_TAXI_NO_13 As String = "ANS_TAXI_NO_13"
            Public Const ANS_TAXI_HAKKO_13 As String = "ANS_TAXI_HAKKO_13"
            Public Const ANS_TAXI_HAKKO_DATE_13 As String = "ANS_TAXI_HAKKO_DATE_13"
            Public Const ANS_TAXI_RMKS_13 As String = "ANS_TAXI_RMKS_13"
            Public Const ANS_TAXI_DATE_14 As String = "ANS_TAXI_DATE_14"
            Public Const ANS_TAXI_KENSHU_14 As String = "ANS_TAXI_KENSHU_14"
            Public Const ANS_TAXI_NO_14 As String = "ANS_TAXI_NO_14"
            Public Const ANS_TAXI_HAKKO_14 As String = "ANS_TAXI_HAKKO_14"
            Public Const ANS_TAXI_HAKKO_DATE_14 As String = "ANS_TAXI_HAKKO_DATE_14"
            Public Const ANS_TAXI_RMKS_14 As String = "ANS_TAXI_RMKS_14"
            Public Const ANS_TAXI_DATE_15 As String = "ANS_TAXI_DATE_15"
            Public Const ANS_TAXI_KENSHU_15 As String = "ANS_TAXI_KENSHU_15"
            Public Const ANS_TAXI_NO_15 As String = "ANS_TAXI_NO_15"
            Public Const ANS_TAXI_HAKKO_15 As String = "ANS_TAXI_HAKKO_15"
            Public Const ANS_TAXI_HAKKO_DATE_15 As String = "ANS_TAXI_HAKKO_DATE_15"
            Public Const ANS_TAXI_RMKS_15 As String = "ANS_TAXI_RMKS_15"
            Public Const ANS_TAXI_DATE_16 As String = "ANS_TAXI_DATE_16"
            Public Const ANS_TAXI_KENSHU_16 As String = "ANS_TAXI_KENSHU_16"
            Public Const ANS_TAXI_NO_16 As String = "ANS_TAXI_NO_16"
            Public Const ANS_TAXI_HAKKO_16 As String = "ANS_TAXI_HAKKO_16"
            Public Const ANS_TAXI_HAKKO_DATE_16 As String = "ANS_TAXI_HAKKO_DATE_16"
            Public Const ANS_TAXI_RMKS_16 As String = "ANS_TAXI_RMKS_16"
            Public Const ANS_TAXI_DATE_17 As String = "ANS_TAXI_DATE_17"
            Public Const ANS_TAXI_KENSHU_17 As String = "ANS_TAXI_KENSHU_17"
            Public Const ANS_TAXI_NO_17 As String = "ANS_TAXI_NO_17"
            Public Const ANS_TAXI_HAKKO_17 As String = "ANS_TAXI_HAKKO_17"
            Public Const ANS_TAXI_HAKKO_DATE_17 As String = "ANS_TAXI_HAKKO_DATE_17"
            Public Const ANS_TAXI_RMKS_17 As String = "ANS_TAXI_RMKS_17"
            Public Const ANS_TAXI_DATE_18 As String = "ANS_TAXI_DATE_18"
            Public Const ANS_TAXI_KENSHU_18 As String = "ANS_TAXI_KENSHU_18"
            Public Const ANS_TAXI_NO_18 As String = "ANS_TAXI_NO_18"
            Public Const ANS_TAXI_HAKKO_18 As String = "ANS_TAXI_HAKKO_18"
            Public Const ANS_TAXI_HAKKO_DATE_18 As String = "ANS_TAXI_HAKKO_DATE_18"
            Public Const ANS_TAXI_RMKS_18 As String = "ANS_TAXI_RMKS_18"
            Public Const ANS_TAXI_DATE_19 As String = "ANS_TAXI_DATE_19"
            Public Const ANS_TAXI_KENSHU_19 As String = "ANS_TAXI_KENSHU_19"
            Public Const ANS_TAXI_NO_19 As String = "ANS_TAXI_NO_19"
            Public Const ANS_TAXI_HAKKO_19 As String = "ANS_TAXI_HAKKO_19"
            Public Const ANS_TAXI_HAKKO_DATE_19 As String = "ANS_TAXI_HAKKO_DATE_19"
            Public Const ANS_TAXI_RMKS_19 As String = "ANS_TAXI_RMKS_19"
            Public Const ANS_TAXI_DATE_20 As String = "ANS_TAXI_DATE_20"
            Public Const ANS_TAXI_KENSHU_20 As String = "ANS_TAXI_KENSHU_20"
            Public Const ANS_TAXI_NO_20 As String = "ANS_TAXI_NO_20"
            Public Const ANS_TAXI_HAKKO_20 As String = "ANS_TAXI_HAKKO_20"
            Public Const ANS_TAXI_HAKKO_DATE_20 As String = "ANS_TAXI_HAKKO_DATE_20"
            Public Const ANS_TAXI_RMKS_20 As String = "ANS_TAXI_RMKS_20"
            Public Const TAXI_HAKKO_DATE As String = "TAXI_HAKKO_DATE"

            Public Const KAZEI_KBN As String = "KAZEI_KBN"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const REQ_TAXI_DATE As String = "REQ_TAXI_DATE"
        End Class
        Public Class Name
            Public Const TKT_KAISHA As String = "タクシー会社"
            Public Const TKT_NO As String = "タクシーチケット番号"
            Public Const TKT_KENSHU As String = "券種"
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const SANKASHA_ID As String = "参加者ID"
            Public Const TKT_LINE_NO As String = "交通手配タクチケ行番号"
            Public Const TKT_USED_DATE As String = "利用日"
            Public Const TKT_URIAGE As String = "売上金額"
            Public Const TKT_SEISAN_FEE As String = "精算手数料"
            Public Const TKT_HAKKO_FEE As String = "発行手数料"
            Public Const TKT_ENTA As String = "エンタ"
            Public Const TKT_VOID As String = "VOID"
            Public Const TKT_MIKETSU As String = "未決フラグ"
            Public Const TKT_IMPORT_DATE As String = "取込日"
            Public Const TKT_SEIKYU_YM As String = "請求年月"
            Public Const SEIKYU_NO_TOPTOUR As String = "精算番号"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class TaxiMeisaiCsv
        <Serializable()> Public Structure DataStruct
            Public TKT_KAISHA As String
            Public TKT_KENSHU As String
            Public TKT_NO As String
            Public KOUENKAI_NO As String
            Public KOUENKAI_NAME As String
            Public STATUS As String
            Public MR_BU As String
            Public MR_AREA As String
            Public MR_EIGYOSHO As String
            Public MR_NAME As String
            Public DR_SHISETSU_NAME As String
            Public DR_NAME As String
            Public DR_CD As String
            Public SANKASHA_ID As String
            Public DR_SANKA As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public KIKAKU_TANTO_JIGYOUBU As String
            Public KIKAKU_TANTO_AREA As String
            Public KIKAKU_TANTO_EIGYOSHO As String
            Public KIKAKU_TANTO_NAME As String
            Public TKT_LINE_NO As String
            Public ANS_TAXI_DATE As String
            Public TKT_USED_DATE As String
            Public TKT_ENTA As String
            Public ACCOUNT_CD As String
            Public COST_CENTER As String
            Public INTERNAL_ORDER As String
            Public ZETIA_CD As String
            Public TKT_URIAGE As String
            Public TKT_SEISAN_FEE As String
            Public SEISAN_KINGAKU As String
            Public TKT_HAKKO_FEE As String
            Public TOTAL_KINGAKU As String
            Public TKT_SEIKYU_YM As String
            Public TKT_VOID As String
            Public TKT_MIKETSU As String
        End Structure
    End Class

End Class
