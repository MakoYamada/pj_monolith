Public Class TableDef

    Public Class TBL_KOUENKAI
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public KOUENKAI_EDABAN As String
            Public KOUENKAI_NAME As String
            Public TAXI_PRT_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public SEIHIN_NAME As String
            Public INTERNAL_ORDER_T As String
            Public INTERNAL_ORDER_TF As String
            Public ZETIA_CD As String
            Public BU As String
            Public KIKAKU_TANTO_JIGYOBU As String
            Public KIKAKU_TANTO_AREA As String
            Public KIKAKU_TANTO_EIGYOSHO As String
            Public KIKAKU_TANTO_NO As String
            Public KIKAKU_TANTO_NAME As String
            Public KIKAKU_TANTO_KANA As String
            Public KIKAKU_TANTO_EMAIL As String
            Public KIKAKU_TANTO_KEITAI As String
            Public TEHAI_TANTO_JIGYOBU As String
            Public TEHAI_TANTO_AREA As String
            Public TEHAI_TANTO_EIGYOSHO As String
            Public TEHAI_TANTO_NO As String
            Public TEHAI_TANTO_NAME As String
            Public TEHAI_TANTO_KANA As String
            Public TEHAI_TANTO_EMAIL As String
            Public TEHAI_TANTO_KEITAI As String
            Public ACCOUNT_CODE_T As String
            Public COST_CENTER As String
            Public DAIKIBO_FLG As String
            Public TTANTO_ID As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const KOUENKAI_EDABAN As String = "KOUENKAI_EDABAN"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const TAXI_PRT_NAME As String = "TAXI_PRT_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const SEIHIN_NAME As String = "SEIHIN_NAME"
            Public Const INTERNAL_ORDER_T As String = "INTERNAL_ORDER_T"
            Public Const INTERNAL_ORDER_TF As String = "INTERNAL_ORDER_TF"
            Public Const ZETIA_CD As String = "ZETIA_CD"
            Public Const BU As String = "BU"
            Public Const KIKAKU_TANTO_JIGYOBU As String = "KIKAKU_TANTO_JIGYOBU"
            Public Const KIKAKU_TANTO_AREA As String = "KIKAKU_TANTO_AREA"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "KIKAKU_TANTO_EIGYOSHO"
            Public Const KIKAKU_TANTO_NO As String = "KIKAKU_TANTO_NO"
            Public Const KIKAKU_TANTO_NAME As String = "KIKAKU_TANTO_NAME"
            Public Const KIKAKU_TANTO_KANA As String = "KIKAKU_TANTO_KANA"
            Public Const KIKAKU_TANTO_EMAIL As String = "KIKAKU_TANTO_EMAIL"
            Public Const KIKAKU_TANTO_KEITAI As String = "KIKAKU_TANTO_KEITAI"
            Public Const TEHAI_TANTO_JIGYOBU As String = "TEHAI_TANTO_JIGYOBU"
            Public Const TEHAI_TANTO_AREA As String = "TEHAI_TANTO_AREA"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "TEHAI_TANTO_EIGYOSHO"
            Public Const TEHAI_TANTO_NO As String = "TEHAI_TANTO_NO"
            Public Const TEHAI_TANTO_NAME As String = "TEHAI_TANTO_NAME"
            Public Const TEHAI_TANTO_KANA As String = "TEHAI_TANTO_KANA"
            Public Const TEHAI_TANTO_EMAIL As String = "TEHAI_TANTO_EMAIL"
            Public Const TEHAI_TANTO_KEITAI As String = "TEHAI_TANTO_KEITAI"
            Public Const ACCOUNT_CODE_T As String = "ACCOUNT_CODE_T"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const DAIKIBO_FLG As String = "DAIKIBO_FLG"
            Public Const TTANTO_ID As String = "TTANTO_ID"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const KOUENKAI_EDABAN As String = "枝番"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const TAXI_PRT_NAME As String = "タクシーチケット印字名"
            Public Const FROM_DATE As String = "講演会開催日From"
            Public Const TO_DATE As String = "講演会開催日To"
            Public Const SEIHIN_NAME As String = "製品名"
            Public Const INTERNAL_ORDER_T As String = "Internal order（課税）"
            Public Const INTERNAL_ORDER_TF As String = "Internal order（非課税）"
            Public Const ZETIA_CD As String = "zetia Code"
            Public Const BU As String = "BU（領域）"
            Public Const KIKAKU_TANTO_JIGYOBU As String = "所属事業部"
            Public Const KIKAKU_TANTO_AREA As String = "所属エリア"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "所属営業所"
            Public Const KIKAKU_TANTO_NO As String = "担当者（企画担当者）No"
            Public Const KIKAKU_TANTO_NAME As String = "担当者（企画担当者）名"
            Public Const KIKAKU_TANTO_KANA As String = "担当者（企画担当者）名（カタカナ）"
            Public Const KIKAKU_TANTO_EMAIL As String = "Emailアドレス（企画担当者）"
            Public Const KIKAKU_TANTO_KEITAI As String = "携帯電話番号"
            Public Const TEHAI_TANTO_JIGYOBU As String = "所属事業部（手配担当者）"
            Public Const TEHAI_TANTO_AREA As String = "所属エリア（手配担当者）"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "所属営業所（手配担当者）"
            Public Const TEHAI_TANTO_NO As String = "担当者（手配担当者）No"
            Public Const TEHAI_TANTO_NAME As String = "担当者（手配担当者）名"
            Public Const TEHAI_TANTO_KANA As String = "担当者（手配担当者）名（カタカナ）"
            Public Const TEHAI_TANTO_EMAIL As String = "Emailアドレス（手配担当者）"
            Public Const TEHAI_TANTO_KEITAI As String = "携帯電話番号"
            Public Const ACCOUNT_CODE_T As String = "課税Account code"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const DAIKIBO_FLG As String = "特定大規模フラグ"
            Public Const TTANTO_ID As String = "トップツアー担当者ID"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class TBL_SEIKYU
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public KAIJOHI_TF As String
            Public INSHOKUHI_TF As String
            Public KIZAIHI_TF As String
            Public UNEIHI_TF As String
            Public HOTELHI_TF As String
            Public KOTSUHI_TF As String
            Public KAIJOHI_T As String
            Public INSHOKUHI_T As String
            Public KIZAIHI_T As String
            Public UNEIHI_T As String
            Public HOTELHI_T As String
            Public KOTSUHI_T As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const KAIJOHI_TF As String = "KAIJOHI_TF"
            Public Const INSHOKUHI_TF As String = "INSHOKUHI_TF"
            Public Const KIZAIHI_TF As String = "KIZAIHI_TF"
            Public Const UNEIHI_TF As String = "UNEIHI_TF"
            Public Const HOTELHI_TF As String = "HOTELHI_TF"
            Public Const KOTSUHI_TF As String = "KOTSUHI_TF"
            Public Const KAIJOHI_T As String = "KAIJOHI_T"
            Public Const INSHOKUHI_T As String = "INSHOKUHI_T"
            Public Const KIZAIHI_T As String = "KIZAIHI_T"
            Public Const UNEIHI_T As String = "UNEIHI_T"
            Public Const HOTELHI_T As String = "HOTELHI_T"
            Public Const KOTSUHI_T As String = "KOTSUHI_T"
        End Class
        Public Class Name
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const KAIJOHI_TF As String = "会場費（非課税）"
            Public Const INSHOKUHI_TF As String = "飲食費（非課税）"
            Public Const KIZAIHI_TF As String = "機材費（非課税）"
            Public Const UNEIHI_TF As String = "運営費（非課税）"
            Public Const HOTELHI_TF As String = "宿泊費（非課税）"
            Public Const KOTSUHI_TF As String = "交通費（非課税）"
            Public Const KAIJOHI_T As String = "会場費（課税）"
            Public Const INSHOKUHI_T As String = "飲食費（課税）"
            Public Const KIZAIHI_T As String = "機材費（課税）"
            Public Const UNEIHI_T As String = "運営費（課税）"
            Public Const HOTELHI_T As String = "宿泊費（課税）"
            Public Const KOTSUHI_T As String = "交通費（課税）"
        End Class
    End Class

    Public Class TBL_KOTSUHOTEL
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_NO As String
            Public STATUS_TEHAI As String
            Public DR_MPID As String
            Public DR_CD As String
            Public DR_EDABAN As String
            Public DR_NAME As String
            Public DR_KANA As String
            Public DR_SEX As String
            Public DR_SHISETSU_CD As String
            Public DR_SHISETSU_NAME As String
            Public DR_SHISETSU_ADDRESS As String
            Public DR_YAKUWARI As String
            Public DR_SANKA As String
            Public MR_JIGYOBU As String
            Public MR_AREA As String
            Public MR_EIGYOSHO As String
            Public MR_NO As String
            Public MR_NAME As String
            Public MR_KANA As String
            Public MR_EMAIL As String
            Public MR_KEITAI As String
            Public MR_SEND_SAKI_FS As String
            Public MR_SEND_SAKI_OTHER As String
            Public ACCOUNT_CODE As String
            Public COST_CENTER As String
            Public INTERNAL_ORDER As String
            Public SHONIN_NAME As String
            Public SHONIN_DATE As String
            Public SHONIN_NOTE As String
            Public CMSHONIN_NAME As String
            Public CMSHONIN_DATE As String
            Public CMSHONIN_NOTE As String
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
            Public REQ_O_AGE_1 As String
            Public ANS_O_STATUS_1 As String
            Public ANS_O_KOTSUKIKAN_1 As String
            Public ANS_O_DATE_1 As String
            Public ANS_O_AIRPORT1_1 As String
            Public ANS_O_AIRPORT2_1 As String
            Public ANS_O_TIME1_1 As String
            Public ANS_O_TIME2_1 As String
            Public ANS_O_BIN_1 As String
            Public ANS_O_SEAT_1 As String
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
            Public REQ_O_AGE_2 As String
            Public ANS_O_STATUS_2 As String
            Public ANS_O_KOTSUKIKAN_2 As String
            Public ANS_O_DATE_2 As String
            Public ANS_O_AIRPORT1_2 As String
            Public ANS_O_AIRPORT2_2 As String
            Public ANS_O_TIME1_2 As String
            Public ANS_O_TIME2_2 As String
            Public ANS_O_BIN_2 As String
            Public ANS_O_SEAT_2 As String
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
            Public REQ_O_AGE_3 As String
            Public ANS_O_STATUS_3 As String
            Public ANS_O_KOTSUKIKAN_3 As String
            Public ANS_O_DATE_3 As String
            Public ANS_O_AIRPORT1_3 As String
            Public ANS_O_AIRPORT2_3 As String
            Public ANS_O_TIME1_3 As String
            Public ANS_O_TIME2_3 As String
            Public ANS_O_BIN_3 As String
            Public ANS_O_SEAT_3 As String
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
            Public REQ_O_AGE_4 As String
            Public ANS_O_STATUS_4 As String
            Public ANS_O_KOTSUKIKAN_4 As String
            Public ANS_O_DATE_4 As String
            Public ANS_O_AIRPORT1_4 As String
            Public ANS_O_AIRPORT2_4 As String
            Public ANS_O_TIME1_4 As String
            Public ANS_O_TIME2_4 As String
            Public ANS_O_BIN_4 As String
            Public ANS_O_SEAT_4 As String
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
            Public REQ_O_AGE_5 As String
            Public ANS_O_STATUS_5 As String
            Public ANS_O_KOTSUKIKAN_5 As String
            Public ANS_O_DATE_5 As String
            Public ANS_O_AIRPORT1_5 As String
            Public ANS_O_AIRPORT2_5 As String
            Public ANS_O_TIME1_5 As String
            Public ANS_O_TIME2_5 As String
            Public ANS_O_BIN_5 As String
            Public ANS_O_SEAT_5 As String
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
            Public REQ_F_AGE_1 As String
            Public ANS_F_STATUS_1 As String
            Public ANS_F_KOTSUKIKAN_1 As String
            Public ANS_F_DATE_1 As String
            Public ANS_F_AIRPORT1_1 As String
            Public ANS_F_AIRPORT2_1 As String
            Public ANS_F_TIME1_1 As String
            Public ANS_F_TIME2_1 As String
            Public ANS_F_BIN_1 As String
            Public ANS_F_SEAT_1 As String
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
            Public REQ_F_AGE_2 As String
            Public ANS_F_STATUS_2 As String
            Public ANS_F_KOTSUKIKAN_2 As String
            Public ANS_F_DATE_2 As String
            Public ANS_F_AIRPORT1_2 As String
            Public ANS_F_AIRPORT2_2 As String
            Public ANS_F_TIME1_2 As String
            Public ANS_F_TIME2_2 As String
            Public ANS_F_BIN_2 As String
            Public ANS_F_SEAT_2 As String
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
            Public REQ_F_AGE_3 As String
            Public ANS_F_STATUS_3 As String
            Public ANS_F_KOTSUKIKAN_3 As String
            Public ANS_F_DATE_3 As String
            Public ANS_F_AIRPORT1_3 As String
            Public ANS_F_AIRPORT2_3 As String
            Public ANS_F_TIME1_3 As String
            Public ANS_F_TIME2_3 As String
            Public ANS_F_BIN_3 As String
            Public ANS_F_SEAT_3 As String
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
            Public REQ_F_AGE_4 As String
            Public ANS_F_STATUS_4 As String
            Public ANS_F_KOTSUKIKAN_4 As String
            Public ANS_F_DATE_4 As String
            Public ANS_F_AIRPORT1_4 As String
            Public ANS_F_AIRPORT2_4 As String
            Public ANS_F_TIME1_4 As String
            Public ANS_F_TIME2_4 As String
            Public ANS_F_BIN_4 As String
            Public ANS_F_SEAT_4 As String
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
            Public REQ_F_AGE_5 As String
            Public ANS_F_STATUS_5 As String
            Public ANS_F_KOTSUKIKAN_5 As String
            Public ANS_F_DATE_5 As String
            Public ANS_F_AIRPORT1_5 As String
            Public ANS_F_AIRPORT2_5 As String
            Public ANS_F_TIME1_5 As String
            Public ANS_F_TIME2_5 As String
            Public ANS_F_BIN_5 As String
            Public ANS_F_SEAT_5 As String
            Public REQ_O_NOTE_1 As String
            Public ANS_O_NOTE_1 As String
            Public REQ_F_NOTE_1 As String
            Public ANS_F_NOTE_1 As String
            Public FIX_RAIL_FARE As String
            Public FIX_RAIL_CANCELLATION As String
            Public FIX_AIR_FARE As String
            Public FIX_AIR_CANCELLATION As String
            Public FIX_OTHER_FARE As String
            Public FIX_OTHER_CANCELLATION As String
            Public TOUROKUKANRI_FEE As String
            Public TAXI_HAKKEN_FEE As String
            Public TAXI_SEISAN_FEE As String
            Public TEHAI_TAXI As String
            Public TAXI_MOUSHIKOMI_SAKI As String
            Public REQ_TAXI_DATE_1 As String
            Public REQ_TAXI_FROM_1 As String
            Public REQ_TAXI_TO_1 As String
            Public REQ_TAXI_NO_1 As String
            Public TAXI_YOTEIKINGAKU_1 As String
            Public ANS_TAXI_DATE_1 As String
            Public ANS_TAXI_FROM_1 As String
            Public ANS_TAXI_TO_1 As String
            Public ANS_TAXI_KENSHU_1 As String
            Public ANS_TAXI_NO_1 As String
            Public ANS_TAXI_KINGAKU_1 As String
            Public ANS_TAXI_MEISAI_NO_1 As String
            Public ANS_TAXI_VOID_1 As String
            Public ANS_TAXI_PRINTDATE_1 As String
            Public ANS_TAXI_SEIKYUDATE_1 As String
            Public REQ_TAXI_DATE_2 As String
            Public REQ_TAXI_FROM_2 As String
            Public REQ_TAXI_TO_2 As String
            Public REQ_TAXI_NO_2 As String
            Public TAXI_YOTEIKINGAKU_2 As String
            Public ANS_TAXI_DATE_2 As String
            Public ANS_TAXI_FROM_2 As String
            Public ANS_TAXI_TO_2 As String
            Public ANS_TAXI_KENSHU_2 As String
            Public ANS_TAXI_NO_2 As String
            Public ANS_TAXI_KINGAKU_2 As String
            Public ANS_TAXI_MEISAI_NO_2 As String
            Public ANS_TAXI_VOID_2 As String
            Public ANS_TAXI_PRINTDATE_2 As String
            Public ANS_TAXI_SEIKYUDATE_2 As String
            Public REQ_TAXI_DATE_3 As String
            Public REQ_TAXI_FROM_3 As String
            Public REQ_TAXI_TO_3 As String
            Public REQ_TAXI_NO_3 As String
            Public TAXI_YOTEIKINGAKU_3 As String
            Public ANS_TAXI_DATE_3 As String
            Public ANS_TAXI_FROM_3 As String
            Public ANS_TAXI_TO_3 As String
            Public ANS_TAXI_KENSHU_3 As String
            Public ANS_TAXI_NO_3 As String
            Public ANS_TAXI_KINGAKU_3 As String
            Public ANS_TAXI_MEISAI_NO_3 As String
            Public ANS_TAXI_VOID_3 As String
            Public ANS_TAXI_PRINTDATE_3 As String
            Public ANS_TAXI_SEIKYUDATE_3 As String
            Public REQ_TAXI_DATE_4 As String
            Public REQ_TAXI_FROM_4 As String
            Public REQ_TAXI_TO_4 As String
            Public REQ_TAXI_NO_4 As String
            Public TAXI_YOTEIKINGAKU_4 As String
            Public ANS_TAXI_DATE_4 As String
            Public ANS_TAXI_FROM_4 As String
            Public ANS_TAXI_TO_4 As String
            Public ANS_TAXI_KENSHU_4 As String
            Public ANS_TAXI_NO_4 As String
            Public ANS_TAXI_KINGAKU_4 As String
            Public ANS_TAXI_MEISAI_NO_4 As String
            Public ANS_TAXI_VOID_4 As String
            Public ANS_TAXI_PRINTDATE_4 As String
            Public ANS_TAXI_SEIKYUDATE_4 As String
            Public REQ_TAXI_DATE_5 As String
            Public REQ_TAXI_FROM_5 As String
            Public REQ_TAXI_TO_5 As String
            Public REQ_TAXI_NO_5 As String
            Public TAXI_YOTEIKINGAKU_5 As String
            Public ANS_TAXI_DATE_5 As String
            Public ANS_TAXI_FROM_5 As String
            Public ANS_TAXI_TO_5 As String
            Public ANS_TAXI_KENSHU_5 As String
            Public ANS_TAXI_NO_5 As String
            Public ANS_TAXI_KINGAKU_5 As String
            Public ANS_TAXI_MEISAI_NO_5 As String
            Public ANS_TAXI_VOID_5 As String
            Public ANS_TAXI_PRINTDATE_5 As String
            Public ANS_TAXI_SEIKYUDATE_5 As String
            Public REQ_TAXI_DATE_6 As String
            Public REQ_TAXI_FROM_6 As String
            Public REQ_TAXI_TO_6 As String
            Public REQ_TAXI_NO_6 As String
            Public TAXI_YOTEIKINGAKU_6 As String
            Public ANS_TAXI_DATE_6 As String
            Public ANS_TAXI_FROM_6 As String
            Public ANS_TAXI_TO_6 As String
            Public ANS_TAXI_KENSHU_6 As String
            Public ANS_TAXI_NO_6 As String
            Public ANS_TAXI_KINGAKU_6 As String
            Public ANS_TAXI_MEISAI_NO_6 As String
            Public ANS_TAXI_VOID_6 As String
            Public ANS_TAXI_PRINTDATE_6 As String
            Public ANS_TAXI_SEIKYUDATE_6 As String
            Public REQ_TAXI_DATE_7 As String
            Public REQ_TAXI_FROM_7 As String
            Public REQ_TAXI_TO_7 As String
            Public REQ_TAXI_NO_7 As String
            Public TAXI_YOTEIKINGAKU_7 As String
            Public ANS_TAXI_DATE_7 As String
            Public ANS_TAXI_FROM_7 As String
            Public ANS_TAXI_TO_7 As String
            Public ANS_TAXI_KENSHU_7 As String
            Public ANS_TAXI_NO_7 As String
            Public ANS_TAXI_KINGAKU_7 As String
            Public ANS_TAXI_MEISAI_NO_7 As String
            Public ANS_TAXI_VOID_7 As String
            Public ANS_TAXI_PRINTDATE_7 As String
            Public ANS_TAXI_SEIKYUDATE_7 As String
            Public REQ_TAXI_DATE_8 As String
            Public REQ_TAXI_FROM_8 As String
            Public REQ_TAXI_TO_8 As String
            Public REQ_TAXI_NO_8 As String
            Public TAXI_YOTEIKINGAKU_8 As String
            Public ANS_TAXI_DATE_8 As String
            Public ANS_TAXI_FROM_8 As String
            Public ANS_TAXI_TO_8 As String
            Public ANS_TAXI_KENSHU_8 As String
            Public ANS_TAXI_NO_8 As String
            Public ANS_TAXI_KINGAKU_8 As String
            Public ANS_TAXI_MEISAI_NO_8 As String
            Public ANS_TAXI_VOID_8 As String
            Public ANS_TAXI_PRINTDATE_8 As String
            Public ANS_TAXI_SEIKYUDATE_8 As String
            Public REQ_TAXI_DATE_9 As String
            Public REQ_TAXI_FROM_9 As String
            Public REQ_TAXI_TO_9 As String
            Public REQ_TAXI_NO_9 As String
            Public TAXI_YOTEIKINGAKU_9 As String
            Public ANS_TAXI_DATE_9 As String
            Public ANS_TAXI_FROM_9 As String
            Public ANS_TAXI_TO_9 As String
            Public ANS_TAXI_KENSHU_9 As String
            Public ANS_TAXI_NO_9 As String
            Public ANS_TAXI_KINGAKU_9 As String
            Public ANS_TAXI_MEISAI_NO_9 As String
            Public ANS_TAXI_VOID_9 As String
            Public ANS_TAXI_PRINTDATE_9 As String
            Public ANS_TAXI_SEIKYUDATE_9 As String
            Public REQ_TAXI_DATE_10 As String
            Public REQ_TAXI_FROM_10 As String
            Public REQ_TAXI_TO_10 As String
            Public REQ_TAXI_NO_10 As String
            Public TAXI_YOTEIKINGAKU_10 As String
            Public ANS_TAXI_DATE_10 As String
            Public ANS_TAXI_FROM_10 As String
            Public ANS_TAXI_TO_10 As String
            Public ANS_TAXI_KENSHU_10 As String
            Public ANS_TAXI_NO_10 As String
            Public ANS_TAXI_KINGAKU_10 As String
            Public ANS_TAXI_MEISAI_NO_10 As String
            Public ANS_TAXI_VOID_10 As String
            Public ANS_TAXI_PRINTDATE_10 As String
            Public ANS_TAXI_SEIKYUDATE_10 As String
            Public TAXI_NOTE As String
            Public TEHAI_MR As String
            Public MR_SEAT As String
            Public MR_SEX As String
            Public MR_AGE As String
            Public INPUT_DATE As String
            Public UPDATE_DATE As String
            Public SEND_DATE As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const STATUS_TEHAI As String = "STATUS_TEHAI"
            Public Const DR_MPID As String = "DR_MPID"
            Public Const DR_CD As String = "DR_CD"
            Public Const DR_EDABAN As String = "DR_EDABAN"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const DR_KANA As String = "DR_KANA"
            Public Const DR_SEX As String = "DR_SEX"
            Public Const DR_SHISETSU_CD As String = "DR_SHISETSU_CD"
            Public Const DR_SHISETSU_NAME As String = "DR_SHISETSU_NAME"
            Public Const DR_SHISETSU_ADDRESS As String = "DR_SHISETSU_ADDRESS"
            Public Const DR_YAKUWARI As String = "DR_YAKUWARI"
            Public Const DR_SANKA As String = "DR_SANKA"
            Public Const MR_JIGYOBU As String = "MR_JIGYOBU"
            Public Const MR_AREA As String = "MR_AREA"
            Public Const MR_EIGYOSHO As String = "MR_EIGYOSHO"
            Public Const MR_NO As String = "MR_NO"
            Public Const MR_NAME As String = "MR_NAME"
            Public Const MR_KANA As String = "MR_KANA"
            Public Const MR_EMAIL As String = "MR_EMAIL"
            Public Const MR_KEITAI As String = "MR_KEITAI"
            Public Const MR_SEND_SAKI_FS As String = "MR_SEND_SAKI_FS"
            Public Const MR_SEND_SAKI_OTHER As String = "MR_SEND_SAKI_OTHER"
            Public Const ACCOUNT_CODE As String = "ACCOUNT_CODE"
            Public Const COST_CENTER As String = "COST_CENTER"
            Public Const INTERNAL_ORDER As String = "INTERNAL_ORDER"
            Public Const SHONIN_NAME As String = "SHONIN_NAME"
            Public Const SHONIN_DATE As String = "SHONIN_DATE"
            Public Const SHONIN_NOTE As String = "SHONIN_NOTE"
            Public Const CMSHONIN_NAME As String = "CMSHONIN_NAME"
            Public Const CMSHONIN_DATE As String = "CMSHONIN_DATE"
            Public Const CMSHONIN_NOTE As String = "CMSHONIN_NOTE"
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
            Public Const REQ_O_AGE_1 As String = "REQ_O_AGE_1"
            Public Const ANS_O_STATUS_1 As String = "ANS_O_STATUS_1"
            Public Const ANS_O_KOTSUKIKAN_1 As String = "ANS_O_KOTSUKIKAN_1"
            Public Const ANS_O_DATE_1 As String = "ANS_O_DATE_1"
            Public Const ANS_O_AIRPORT1_1 As String = "ANS_O_AIRPORT1_1"
            Public Const ANS_O_AIRPORT2_1 As String = "ANS_O_AIRPORT2_1"
            Public Const ANS_O_TIME1_1 As String = "ANS_O_TIME1_1"
            Public Const ANS_O_TIME2_1 As String = "ANS_O_TIME2_1"
            Public Const ANS_O_BIN_1 As String = "ANS_O_BIN_1"
            Public Const ANS_O_SEAT_1 As String = "ANS_O_SEAT_1"
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
            Public Const REQ_O_AGE_2 As String = "REQ_O_AGE_2"
            Public Const ANS_O_STATUS_2 As String = "ANS_O_STATUS_2"
            Public Const ANS_O_KOTSUKIKAN_2 As String = "ANS_O_KOTSUKIKAN_2"
            Public Const ANS_O_DATE_2 As String = "ANS_O_DATE_2"
            Public Const ANS_O_AIRPORT1_2 As String = "ANS_O_AIRPORT1_2"
            Public Const ANS_O_AIRPORT2_2 As String = "ANS_O_AIRPORT2_2"
            Public Const ANS_O_TIME1_2 As String = "ANS_O_TIME1_2"
            Public Const ANS_O_TIME2_2 As String = "ANS_O_TIME2_2"
            Public Const ANS_O_BIN_2 As String = "ANS_O_BIN_2"
            Public Const ANS_O_SEAT_2 As String = "ANS_O_SEAT_2"
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
            Public Const REQ_O_AGE_3 As String = "REQ_O_AGE_3"
            Public Const ANS_O_STATUS_3 As String = "ANS_O_STATUS_3"
            Public Const ANS_O_KOTSUKIKAN_3 As String = "ANS_O_KOTSUKIKAN_3"
            Public Const ANS_O_DATE_3 As String = "ANS_O_DATE_3"
            Public Const ANS_O_AIRPORT1_3 As String = "ANS_O_AIRPORT1_3"
            Public Const ANS_O_AIRPORT2_3 As String = "ANS_O_AIRPORT2_3"
            Public Const ANS_O_TIME1_3 As String = "ANS_O_TIME1_3"
            Public Const ANS_O_TIME2_3 As String = "ANS_O_TIME2_3"
            Public Const ANS_O_BIN_3 As String = "ANS_O_BIN_3"
            Public Const ANS_O_SEAT_3 As String = "ANS_O_SEAT_3"
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
            Public Const REQ_O_AGE_4 As String = "REQ_O_AGE_4"
            Public Const ANS_O_STATUS_4 As String = "ANS_O_STATUS_4"
            Public Const ANS_O_KOTSUKIKAN_4 As String = "ANS_O_KOTSUKIKAN_4"
            Public Const ANS_O_DATE_4 As String = "ANS_O_DATE_4"
            Public Const ANS_O_AIRPORT1_4 As String = "ANS_O_AIRPORT1_4"
            Public Const ANS_O_AIRPORT2_4 As String = "ANS_O_AIRPORT2_4"
            Public Const ANS_O_TIME1_4 As String = "ANS_O_TIME1_4"
            Public Const ANS_O_TIME2_4 As String = "ANS_O_TIME2_4"
            Public Const ANS_O_BIN_4 As String = "ANS_O_BIN_4"
            Public Const ANS_O_SEAT_4 As String = "ANS_O_SEAT_4"
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
            Public Const REQ_O_AGE_5 As String = "REQ_O_AGE_5"
            Public Const ANS_O_STATUS_5 As String = "ANS_O_STATUS_5"
            Public Const ANS_O_KOTSUKIKAN_5 As String = "ANS_O_KOTSUKIKAN_5"
            Public Const ANS_O_DATE_5 As String = "ANS_O_DATE_5"
            Public Const ANS_O_AIRPORT1_5 As String = "ANS_O_AIRPORT1_5"
            Public Const ANS_O_AIRPORT2_5 As String = "ANS_O_AIRPORT2_5"
            Public Const ANS_O_TIME1_5 As String = "ANS_O_TIME1_5"
            Public Const ANS_O_TIME2_5 As String = "ANS_O_TIME2_5"
            Public Const ANS_O_BIN_5 As String = "ANS_O_BIN_5"
            Public Const ANS_O_SEAT_5 As String = "ANS_O_SEAT_5"
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
            Public Const REQ_F_AGE_1 As String = "REQ_F_AGE_1"
            Public Const ANS_F_STATUS_1 As String = "ANS_F_STATUS_1"
            Public Const ANS_F_KOTSUKIKAN_1 As String = "ANS_F_KOTSUKIKAN_1"
            Public Const ANS_F_DATE_1 As String = "ANS_F_DATE_1"
            Public Const ANS_F_AIRPORT1_1 As String = "ANS_F_AIRPORT1_1"
            Public Const ANS_F_AIRPORT2_1 As String = "ANS_F_AIRPORT2_1"
            Public Const ANS_F_TIME1_1 As String = "ANS_F_TIME1_1"
            Public Const ANS_F_TIME2_1 As String = "ANS_F_TIME2_1"
            Public Const ANS_F_BIN_1 As String = "ANS_F_BIN_1"
            Public Const ANS_F_SEAT_1 As String = "ANS_F_SEAT_1"
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
            Public Const REQ_F_AGE_2 As String = "REQ_F_AGE_2"
            Public Const ANS_F_STATUS_2 As String = "ANS_F_STATUS_2"
            Public Const ANS_F_KOTSUKIKAN_2 As String = "ANS_F_KOTSUKIKAN_2"
            Public Const ANS_F_DATE_2 As String = "ANS_F_DATE_2"
            Public Const ANS_F_AIRPORT1_2 As String = "ANS_F_AIRPORT1_2"
            Public Const ANS_F_AIRPORT2_2 As String = "ANS_F_AIRPORT2_2"
            Public Const ANS_F_TIME1_2 As String = "ANS_F_TIME1_2"
            Public Const ANS_F_TIME2_2 As String = "ANS_F_TIME2_2"
            Public Const ANS_F_BIN_2 As String = "ANS_F_BIN_2"
            Public Const ANS_F_SEAT_2 As String = "ANS_F_SEAT_2"
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
            Public Const REQ_F_AGE_3 As String = "REQ_F_AGE_3"
            Public Const ANS_F_STATUS_3 As String = "ANS_F_STATUS_3"
            Public Const ANS_F_KOTSUKIKAN_3 As String = "ANS_F_KOTSUKIKAN_3"
            Public Const ANS_F_DATE_3 As String = "ANS_F_DATE_3"
            Public Const ANS_F_AIRPORT1_3 As String = "ANS_F_AIRPORT1_3"
            Public Const ANS_F_AIRPORT2_3 As String = "ANS_F_AIRPORT2_3"
            Public Const ANS_F_TIME1_3 As String = "ANS_F_TIME1_3"
            Public Const ANS_F_TIME2_3 As String = "ANS_F_TIME2_3"
            Public Const ANS_F_BIN_3 As String = "ANS_F_BIN_3"
            Public Const ANS_F_SEAT_3 As String = "ANS_F_SEAT_3"
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
            Public Const REQ_F_AGE_4 As String = "REQ_F_AGE_4"
            Public Const ANS_F_STATUS_4 As String = "ANS_F_STATUS_4"
            Public Const ANS_F_KOTSUKIKAN_4 As String = "ANS_F_KOTSUKIKAN_4"
            Public Const ANS_F_DATE_4 As String = "ANS_F_DATE_4"
            Public Const ANS_F_AIRPORT1_4 As String = "ANS_F_AIRPORT1_4"
            Public Const ANS_F_AIRPORT2_4 As String = "ANS_F_AIRPORT2_4"
            Public Const ANS_F_TIME1_4 As String = "ANS_F_TIME1_4"
            Public Const ANS_F_TIME2_4 As String = "ANS_F_TIME2_4"
            Public Const ANS_F_BIN_4 As String = "ANS_F_BIN_4"
            Public Const ANS_F_SEAT_4 As String = "ANS_F_SEAT_4"
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
            Public Const REQ_F_AGE_5 As String = "REQ_F_AGE_5"
            Public Const ANS_F_STATUS_5 As String = "ANS_F_STATUS_5"
            Public Const ANS_F_KOTSUKIKAN_5 As String = "ANS_F_KOTSUKIKAN_5"
            Public Const ANS_F_DATE_5 As String = "ANS_F_DATE_5"
            Public Const ANS_F_AIRPORT1_5 As String = "ANS_F_AIRPORT1_5"
            Public Const ANS_F_AIRPORT2_5 As String = "ANS_F_AIRPORT2_5"
            Public Const ANS_F_TIME1_5 As String = "ANS_F_TIME1_5"
            Public Const ANS_F_TIME2_5 As String = "ANS_F_TIME2_5"
            Public Const ANS_F_BIN_5 As String = "ANS_F_BIN_5"
            Public Const ANS_F_SEAT_5 As String = "ANS_F_SEAT_5"
            Public Const REQ_O_NOTE_1 As String = "REQ_O_NOTE_1"
            Public Const ANS_O_NOTE_1 As String = "ANS_O_NOTE_1"
            Public Const REQ_F_NOTE_1 As String = "REQ_F_NOTE_1"
            Public Const ANS_F_NOTE_1 As String = "ANS_F_NOTE_1"
            Public Const FIX_RAIL_FARE As String = "FIX_RAIL_FARE"
            Public Const FIX_RAIL_CANCELLATION As String = "FIX_RAIL_CANCELLATION"
            Public Const FIX_AIR_FARE As String = "FIX_AIR_FARE"
            Public Const FIX_AIR_CANCELLATION As String = "FIX_AIR_CANCELLATION"
            Public Const FIX_OTHER_FARE As String = "FIX_OTHER_FARE"
            Public Const FIX_OTHER_CANCELLATION As String = "FIX_OTHER_CANCELLATION"
            Public Const TOUROKUKANRI_FEE As String = "TOUROKUKANRI_FEE"
            Public Const TAXI_HAKKEN_FEE As String = "TAXI_HAKKEN_FEE"
            Public Const TAXI_SEISAN_FEE As String = "TAXI_SEISAN_FEE"
            Public Const TEHAI_TAXI As String = "TEHAI_TAXI"
            Public Const TAXI_MOUSHIKOMI_SAKI As String = "TAXI_MOUSHIKOMI_SAKI"
            Public Const REQ_TAXI_DATE_1 As String = "REQ_TAXI_DATE_1"
            Public Const REQ_TAXI_FROM_1 As String = "REQ_TAXI_FROM_1"
            Public Const REQ_TAXI_TO_1 As String = "REQ_TAXI_TO_1"
            Public Const REQ_TAXI_NO_1 As String = "REQ_TAXI_NO_1"
            Public Const TAXI_YOTEIKINGAKU_1 As String = "TAXI_YOTEIKINGAKU_1"
            Public Const ANS_TAXI_DATE_1 As String = "ANS_TAXI_DATE_1"
            Public Const ANS_TAXI_FROM_1 As String = "ANS_TAXI_FROM_1"
            Public Const ANS_TAXI_TO_1 As String = "ANS_TAXI_TO_1"
            Public Const ANS_TAXI_KENSHU_1 As String = "ANS_TAXI_KENSHU_1"
            Public Const ANS_TAXI_NO_1 As String = "ANS_TAXI_NO_1"
            Public Const ANS_TAXI_KINGAKU_1 As String = "ANS_TAXI_KINGAKU_1"
            Public Const ANS_TAXI_MEISAI_NO_1 As String = "ANS_TAXI_MEISAI_NO_1"
            Public Const ANS_TAXI_VOID_1 As String = "ANS_TAXI_VOID_1"
            Public Const ANS_TAXI_PRINTDATE_1 As String = "ANS_TAXI_PRINTDATE_1"
            Public Const ANS_TAXI_SEIKYUDATE_1 As String = "ANS_TAXI_SEIKYUDATE_1"
            Public Const REQ_TAXI_DATE_2 As String = "REQ_TAXI_DATE_2"
            Public Const REQ_TAXI_FROM_2 As String = "REQ_TAXI_FROM_2"
            Public Const REQ_TAXI_TO_2 As String = "REQ_TAXI_TO_2"
            Public Const REQ_TAXI_NO_2 As String = "REQ_TAXI_NO_2"
            Public Const TAXI_YOTEIKINGAKU_2 As String = "TAXI_YOTEIKINGAKU_2"
            Public Const ANS_TAXI_DATE_2 As String = "ANS_TAXI_DATE_2"
            Public Const ANS_TAXI_FROM_2 As String = "ANS_TAXI_FROM_2"
            Public Const ANS_TAXI_TO_2 As String = "ANS_TAXI_TO_2"
            Public Const ANS_TAXI_KENSHU_2 As String = "ANS_TAXI_KENSHU_2"
            Public Const ANS_TAXI_NO_2 As String = "ANS_TAXI_NO_2"
            Public Const ANS_TAXI_KINGAKU_2 As String = "ANS_TAXI_KINGAKU_2"
            Public Const ANS_TAXI_MEISAI_NO_2 As String = "ANS_TAXI_MEISAI_NO_2"
            Public Const ANS_TAXI_VOID_2 As String = "ANS_TAXI_VOID_2"
            Public Const ANS_TAXI_PRINTDATE_2 As String = "ANS_TAXI_PRINTDATE_2"
            Public Const ANS_TAXI_SEIKYUDATE_2 As String = "ANS_TAXI_SEIKYUDATE_2"
            Public Const REQ_TAXI_DATE_3 As String = "REQ_TAXI_DATE_3"
            Public Const REQ_TAXI_FROM_3 As String = "REQ_TAXI_FROM_3"
            Public Const REQ_TAXI_TO_3 As String = "REQ_TAXI_TO_3"
            Public Const REQ_TAXI_NO_3 As String = "REQ_TAXI_NO_3"
            Public Const TAXI_YOTEIKINGAKU_3 As String = "TAXI_YOTEIKINGAKU_3"
            Public Const ANS_TAXI_DATE_3 As String = "ANS_TAXI_DATE_3"
            Public Const ANS_TAXI_FROM_3 As String = "ANS_TAXI_FROM_3"
            Public Const ANS_TAXI_TO_3 As String = "ANS_TAXI_TO_3"
            Public Const ANS_TAXI_KENSHU_3 As String = "ANS_TAXI_KENSHU_3"
            Public Const ANS_TAXI_NO_3 As String = "ANS_TAXI_NO_3"
            Public Const ANS_TAXI_KINGAKU_3 As String = "ANS_TAXI_KINGAKU_3"
            Public Const ANS_TAXI_MEISAI_NO_3 As String = "ANS_TAXI_MEISAI_NO_3"
            Public Const ANS_TAXI_VOID_3 As String = "ANS_TAXI_VOID_3"
            Public Const ANS_TAXI_PRINTDATE_3 As String = "ANS_TAXI_PRINTDATE_3"
            Public Const ANS_TAXI_SEIKYUDATE_3 As String = "ANS_TAXI_SEIKYUDATE_3"
            Public Const REQ_TAXI_DATE_4 As String = "REQ_TAXI_DATE_4"
            Public Const REQ_TAXI_FROM_4 As String = "REQ_TAXI_FROM_4"
            Public Const REQ_TAXI_TO_4 As String = "REQ_TAXI_TO_4"
            Public Const REQ_TAXI_NO_4 As String = "REQ_TAXI_NO_4"
            Public Const TAXI_YOTEIKINGAKU_4 As String = "TAXI_YOTEIKINGAKU_4"
            Public Const ANS_TAXI_DATE_4 As String = "ANS_TAXI_DATE_4"
            Public Const ANS_TAXI_FROM_4 As String = "ANS_TAXI_FROM_4"
            Public Const ANS_TAXI_TO_4 As String = "ANS_TAXI_TO_4"
            Public Const ANS_TAXI_KENSHU_4 As String = "ANS_TAXI_KENSHU_4"
            Public Const ANS_TAXI_NO_4 As String = "ANS_TAXI_NO_4"
            Public Const ANS_TAXI_KINGAKU_4 As String = "ANS_TAXI_KINGAKU_4"
            Public Const ANS_TAXI_MEISAI_NO_4 As String = "ANS_TAXI_MEISAI_NO_4"
            Public Const ANS_TAXI_VOID_4 As String = "ANS_TAXI_VOID_4"
            Public Const ANS_TAXI_PRINTDATE_4 As String = "ANS_TAXI_PRINTDATE_4"
            Public Const ANS_TAXI_SEIKYUDATE_4 As String = "ANS_TAXI_SEIKYUDATE_4"
            Public Const REQ_TAXI_DATE_5 As String = "REQ_TAXI_DATE_5"
            Public Const REQ_TAXI_FROM_5 As String = "REQ_TAXI_FROM_5"
            Public Const REQ_TAXI_TO_5 As String = "REQ_TAXI_TO_5"
            Public Const REQ_TAXI_NO_5 As String = "REQ_TAXI_NO_5"
            Public Const TAXI_YOTEIKINGAKU_5 As String = "TAXI_YOTEIKINGAKU_5"
            Public Const ANS_TAXI_DATE_5 As String = "ANS_TAXI_DATE_5"
            Public Const ANS_TAXI_FROM_5 As String = "ANS_TAXI_FROM_5"
            Public Const ANS_TAXI_TO_5 As String = "ANS_TAXI_TO_5"
            Public Const ANS_TAXI_KENSHU_5 As String = "ANS_TAXI_KENSHU_5"
            Public Const ANS_TAXI_NO_5 As String = "ANS_TAXI_NO_5"
            Public Const ANS_TAXI_KINGAKU_5 As String = "ANS_TAXI_KINGAKU_5"
            Public Const ANS_TAXI_MEISAI_NO_5 As String = "ANS_TAXI_MEISAI_NO_5"
            Public Const ANS_TAXI_VOID_5 As String = "ANS_TAXI_VOID_5"
            Public Const ANS_TAXI_PRINTDATE_5 As String = "ANS_TAXI_PRINTDATE_5"
            Public Const ANS_TAXI_SEIKYUDATE_5 As String = "ANS_TAXI_SEIKYUDATE_5"
            Public Const REQ_TAXI_DATE_6 As String = "REQ_TAXI_DATE_6"
            Public Const REQ_TAXI_FROM_6 As String = "REQ_TAXI_FROM_6"
            Public Const REQ_TAXI_TO_6 As String = "REQ_TAXI_TO_6"
            Public Const REQ_TAXI_NO_6 As String = "REQ_TAXI_NO_6"
            Public Const TAXI_YOTEIKINGAKU_6 As String = "TAXI_YOTEIKINGAKU_6"
            Public Const ANS_TAXI_DATE_6 As String = "ANS_TAXI_DATE_6"
            Public Const ANS_TAXI_FROM_6 As String = "ANS_TAXI_FROM_6"
            Public Const ANS_TAXI_TO_6 As String = "ANS_TAXI_TO_6"
            Public Const ANS_TAXI_KENSHU_6 As String = "ANS_TAXI_KENSHU_6"
            Public Const ANS_TAXI_NO_6 As String = "ANS_TAXI_NO_6"
            Public Const ANS_TAXI_KINGAKU_6 As String = "ANS_TAXI_KINGAKU_6"
            Public Const ANS_TAXI_MEISAI_NO_6 As String = "ANS_TAXI_MEISAI_NO_6"
            Public Const ANS_TAXI_VOID_6 As String = "ANS_TAXI_VOID_6"
            Public Const ANS_TAXI_PRINTDATE_6 As String = "ANS_TAXI_PRINTDATE_6"
            Public Const ANS_TAXI_SEIKYUDATE_6 As String = "ANS_TAXI_SEIKYUDATE_6"
            Public Const REQ_TAXI_DATE_7 As String = "REQ_TAXI_DATE_7"
            Public Const REQ_TAXI_FROM_7 As String = "REQ_TAXI_FROM_7"
            Public Const REQ_TAXI_TO_7 As String = "REQ_TAXI_TO_7"
            Public Const REQ_TAXI_NO_7 As String = "REQ_TAXI_NO_7"
            Public Const TAXI_YOTEIKINGAKU_7 As String = "TAXI_YOTEIKINGAKU_7"
            Public Const ANS_TAXI_DATE_7 As String = "ANS_TAXI_DATE_7"
            Public Const ANS_TAXI_FROM_7 As String = "ANS_TAXI_FROM_7"
            Public Const ANS_TAXI_TO_7 As String = "ANS_TAXI_TO_7"
            Public Const ANS_TAXI_KENSHU_7 As String = "ANS_TAXI_KENSHU_7"
            Public Const ANS_TAXI_NO_7 As String = "ANS_TAXI_NO_7"
            Public Const ANS_TAXI_KINGAKU_7 As String = "ANS_TAXI_KINGAKU_7"
            Public Const ANS_TAXI_MEISAI_NO_7 As String = "ANS_TAXI_MEISAI_NO_7"
            Public Const ANS_TAXI_VOID_7 As String = "ANS_TAXI_VOID_7"
            Public Const ANS_TAXI_PRINTDATE_7 As String = "ANS_TAXI_PRINTDATE_7"
            Public Const ANS_TAXI_SEIKYUDATE_7 As String = "ANS_TAXI_SEIKYUDATE_7"
            Public Const REQ_TAXI_DATE_8 As String = "REQ_TAXI_DATE_8"
            Public Const REQ_TAXI_FROM_8 As String = "REQ_TAXI_FROM_8"
            Public Const REQ_TAXI_TO_8 As String = "REQ_TAXI_TO_8"
            Public Const REQ_TAXI_NO_8 As String = "REQ_TAXI_NO_8"
            Public Const TAXI_YOTEIKINGAKU_8 As String = "TAXI_YOTEIKINGAKU_8"
            Public Const ANS_TAXI_DATE_8 As String = "ANS_TAXI_DATE_8"
            Public Const ANS_TAXI_FROM_8 As String = "ANS_TAXI_FROM_8"
            Public Const ANS_TAXI_TO_8 As String = "ANS_TAXI_TO_8"
            Public Const ANS_TAXI_KENSHU_8 As String = "ANS_TAXI_KENSHU_8"
            Public Const ANS_TAXI_NO_8 As String = "ANS_TAXI_NO_8"
            Public Const ANS_TAXI_KINGAKU_8 As String = "ANS_TAXI_KINGAKU_8"
            Public Const ANS_TAXI_MEISAI_NO_8 As String = "ANS_TAXI_MEISAI_NO_8"
            Public Const ANS_TAXI_VOID_8 As String = "ANS_TAXI_VOID_8"
            Public Const ANS_TAXI_PRINTDATE_8 As String = "ANS_TAXI_PRINTDATE_8"
            Public Const ANS_TAXI_SEIKYUDATE_8 As String = "ANS_TAXI_SEIKYUDATE_8"
            Public Const REQ_TAXI_DATE_9 As String = "REQ_TAXI_DATE_9"
            Public Const REQ_TAXI_FROM_9 As String = "REQ_TAXI_FROM_9"
            Public Const REQ_TAXI_TO_9 As String = "REQ_TAXI_TO_9"
            Public Const REQ_TAXI_NO_9 As String = "REQ_TAXI_NO_9"
            Public Const TAXI_YOTEIKINGAKU_9 As String = "TAXI_YOTEIKINGAKU_9"
            Public Const ANS_TAXI_DATE_9 As String = "ANS_TAXI_DATE_9"
            Public Const ANS_TAXI_FROM_9 As String = "ANS_TAXI_FROM_9"
            Public Const ANS_TAXI_TO_9 As String = "ANS_TAXI_TO_9"
            Public Const ANS_TAXI_KENSHU_9 As String = "ANS_TAXI_KENSHU_9"
            Public Const ANS_TAXI_NO_9 As String = "ANS_TAXI_NO_9"
            Public Const ANS_TAXI_KINGAKU_9 As String = "ANS_TAXI_KINGAKU_9"
            Public Const ANS_TAXI_MEISAI_NO_9 As String = "ANS_TAXI_MEISAI_NO_9"
            Public Const ANS_TAXI_VOID_9 As String = "ANS_TAXI_VOID_9"
            Public Const ANS_TAXI_PRINTDATE_9 As String = "ANS_TAXI_PRINTDATE_9"
            Public Const ANS_TAXI_SEIKYUDATE_9 As String = "ANS_TAXI_SEIKYUDATE_9"
            Public Const REQ_TAXI_DATE_10 As String = "REQ_TAXI_DATE_10"
            Public Const REQ_TAXI_FROM_10 As String = "REQ_TAXI_FROM_10"
            Public Const REQ_TAXI_TO_10 As String = "REQ_TAXI_TO_10"
            Public Const REQ_TAXI_NO_10 As String = "REQ_TAXI_NO_10"
            Public Const TAXI_YOTEIKINGAKU_10 As String = "TAXI_YOTEIKINGAKU_10"
            Public Const ANS_TAXI_DATE_10 As String = "ANS_TAXI_DATE_10"
            Public Const ANS_TAXI_FROM_10 As String = "ANS_TAXI_FROM_10"
            Public Const ANS_TAXI_TO_10 As String = "ANS_TAXI_TO_10"
            Public Const ANS_TAXI_KENSHU_10 As String = "ANS_TAXI_KENSHU_10"
            Public Const ANS_TAXI_NO_10 As String = "ANS_TAXI_NO_10"
            Public Const ANS_TAXI_KINGAKU_10 As String = "ANS_TAXI_KINGAKU_10"
            Public Const ANS_TAXI_MEISAI_NO_10 As String = "ANS_TAXI_MEISAI_NO_10"
            Public Const ANS_TAXI_VOID_10 As String = "ANS_TAXI_VOID_10"
            Public Const ANS_TAXI_PRINTDATE_10 As String = "ANS_TAXI_PRINTDATE_10"
            Public Const ANS_TAXI_SEIKYUDATE_10 As String = "ANS_TAXI_SEIKYUDATE_10"
            Public Const TAXI_NOTE As String = "TAXI_NOTE"
            Public Const TEHAI_MR As String = "TEHAI_MR"
            Public Const MR_SEAT As String = "MR_SEAT"
            Public Const MR_SEX As String = "MR_SEX"
            Public Const MR_AGE As String = "MR_AGE"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const SEND_DATE As String = "SEND_DATE"
        End Class
        Public Class Name
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const STATUS_TEHAI As String = "手配スタータス"
            Public Const DR_MPID As String = "MPID"
            Public Const DR_CD As String = "DRコード"
            Public Const DR_EDABAN As String = "枝番"
            Public Const DR_NAME As String = "DR氏名"
            Public Const DR_KANA As String = "DR氏名（全角カタカナ）"
            Public Const DR_SEX As String = "DR性別"
            Public Const DR_SHISETSU_CD As String = "DCF施設コード"
            Public Const DR_SHISETSU_NAME As String = "施設名"
            Public Const DR_SHISETSU_ADDRESS As String = "施設住所"
            Public Const DR_YAKUWARI As String = "参加者役割"
            Public Const DR_SANKA As String = "参加／不参加"
            Public Const MR_JIGYOBU As String = "所属事業部（担当MR）"
            Public Const MR_AREA As String = "所属エリア（担当MR）"
            Public Const MR_EIGYOSHO As String = "所属営業所（担当MR）"
            Public Const MR_NO As String = "担当者（担当MR）No"
            Public Const MR_NAME As String = "担当者（担当MR）名"
            Public Const MR_KANA As String = "担当者名（担当MR）（カタカナ）"
            Public Const MR_EMAIL As String = "Emailアドレス（担当MR）"
            Public Const MR_KEITAI As String = "携帯電話番号（担当MR）"
            Public Const MR_SEND_SAKI_FS As String = "チケット送付先FS"
            Public Const MR_SEND_SAKI_OTHER As String = "チケット送付先（その他）"
            Public Const ACCOUNT_CODE As String = "Account Code"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const INTERNAL_ORDER As String = "Internal Order"
            Public Const SHONIN_NAME As String = "承認者（氏名）"
            Public Const SHONIN_DATE As String = "承認日時"
            Public Const SHONIN_NOTE As String = "承認者備考"
            Public Const CMSHONIN_NAME As String = "CM承認者（氏名）"
            Public Const CMSHONIN_DATE As String = "CM承認日時"
            Public Const CMSHONIN_NOTE As String = "CM承認者備考"
            Public Const TEHAI_HOTEL As String = "宿泊手配（希望する）"
            Public Const HOTEL_IRAINAIYOU As String = "宿泊依頼内容"
            Public Const REQ_HOTEL_DATE As String = "宿泊日（依頼）"
            Public Const REQ_HAKUSU As String = "泊数（依頼）"
            Public Const REQ_HOTEL_SMOKING As String = "宿泊ホテル喫煙（依頼）"
            Public Const REQ_HOTEL_NOTE As String = "宿泊備考（依頼）"
            Public Const ANS_STATUS_HOTEL As String = "宿泊ステータス（回答）"
            Public Const ANS_HOTEL_NAME As String = "宿泊先（回答）"
            Public Const ANS_HOTEL_ADDRESS As String = "宿泊先住所（回答）"
            Public Const ANS_HOTEL_TEL As String = "宿泊先電話番号（回答）"
            Public Const ANS_HOTEL_DATE As String = "宿泊日（回答）"
            Public Const ANS_HAKUSU As String = "泊数（回答）"
            Public Const ANS_CHECKIN_TIME As String = "宿泊先チェックイン時間（回答）"
            Public Const ANS_CHECKOUT_TIME As String = "宿泊先チェックアウト時間（回答）"
            Public Const ANS_ROOM_TYPE As String = "宿泊部屋タイプ（回答）"
            Public Const ANS_HOTEL_SMOKING As String = "宿泊ホテル喫煙（回答）"
            Public Const ANS_HOTEL_NOTE As String = "宿泊備考（回答）"
            Public Const REQ_O_TEHAI_1 As String = "往路１：希望する（依頼）"
            Public Const REQ_O_IRAINAIYOU_1 As String = "往路１：依頼内容（依頼）"
            Public Const REQ_O_KOTSUKIKAN_1 As String = "往路１：交通機関（依頼）"
            Public Const REQ_O_DATE_1 As String = "往路１：利用日（依頼）"
            Public Const REQ_O_AIRPORT1_1 As String = "往路１：出発地（依頼）"
            Public Const REQ_O_AIRPORT2_1 As String = "往路１：到着地（依頼）"
            Public Const REQ_O_TIME1_1 As String = "往路１：出発時間（依頼）"
            Public Const REQ_O_TIME2_1 As String = "往路１：到着時間（依頼）"
            Public Const REQ_O_BIN_1 As String = "往路１：列車名・便名（依頼）"
            Public Const REQ_O_SEAT_1 As String = "往路１：座席区分（依頼）"
            Public Const REQ_O_AGE_1 As String = "往路１：航空搭乗者年齢（年齢）"
            Public Const ANS_O_STATUS_1 As String = "往路１：ステータス（回答）"
            Public Const ANS_O_KOTSUKIKAN_1 As String = "往路１：交通機関（回答）"
            Public Const ANS_O_DATE_1 As String = "往路１：利用日（回答）"
            Public Const ANS_O_AIRPORT1_1 As String = "往路１：出発地（回答）"
            Public Const ANS_O_AIRPORT2_1 As String = "往路１：到着地（回答）"
            Public Const ANS_O_TIME1_1 As String = "往路１：出発時間（回答）"
            Public Const ANS_O_TIME2_1 As String = "往路１：到着時間（回答）"
            Public Const ANS_O_BIN_1 As String = "往路１：列車名・便名（回答）"
            Public Const ANS_O_SEAT_1 As String = "往路１：座席区分（回答）"
            Public Const REQ_O_TEHAI_2 As String = "往路２：希望する（依頼）"
            Public Const REQ_O_IRAINAIYOU_2 As String = "往路２：依頼内容（依頼）"
            Public Const REQ_O_KOTSUKIKAN_2 As String = "往路２：交通機関（依頼）"
            Public Const REQ_O_DATE_2 As String = "往路２：利用日（依頼）"
            Public Const REQ_O_AIRPORT1_2 As String = "往路２：出発地（依頼）"
            Public Const REQ_O_AIRPORT2_2 As String = "往路２：到着地（依頼）"
            Public Const REQ_O_TIME1_2 As String = "往路２：出発時間（依頼）"
            Public Const REQ_O_TIME2_2 As String = "往路２：到着時間（依頼）"
            Public Const REQ_O_BIN_2 As String = "往路２：列車名・便名（依頼）"
            Public Const REQ_O_SEAT_2 As String = "往路２：座席区分（依頼）"
            Public Const REQ_O_AGE_2 As String = "往路２：航空搭乗者年齢（年齢）"
            Public Const ANS_O_STATUS_2 As String = "往路２：ステータス（回答）"
            Public Const ANS_O_KOTSUKIKAN_2 As String = "往路２：交通機関（回答）"
            Public Const ANS_O_DATE_2 As String = "往路２：利用日（回答）"
            Public Const ANS_O_AIRPORT1_2 As String = "往路２：出発地（回答）"
            Public Const ANS_O_AIRPORT2_2 As String = "往路２：到着地（回答）"
            Public Const ANS_O_TIME1_2 As String = "往路２：出発時間（回答）"
            Public Const ANS_O_TIME2_2 As String = "往路２：到着時間（回答）"
            Public Const ANS_O_BIN_2 As String = "往路２：列車名・便名（回答）"
            Public Const ANS_O_SEAT_2 As String = "往路２：座席区分（回答）"
            Public Const REQ_O_TEHAI_3 As String = "往路３：希望する（依頼）"
            Public Const REQ_O_IRAINAIYOU_3 As String = "往路３：依頼内容（依頼）"
            Public Const REQ_O_KOTSUKIKAN_3 As String = "往路３：交通機関（依頼）"
            Public Const REQ_O_DATE_3 As String = "往路３：利用日（依頼）"
            Public Const REQ_O_AIRPORT1_3 As String = "往路３：出発地（依頼）"
            Public Const REQ_O_AIRPORT2_3 As String = "往路３：到着地（依頼）"
            Public Const REQ_O_TIME1_3 As String = "往路３：出発時間（依頼）"
            Public Const REQ_O_TIME2_3 As String = "往路３：到着時間（依頼）"
            Public Const REQ_O_BIN_3 As String = "往路３：列車名・便名（依頼）"
            Public Const REQ_O_SEAT_3 As String = "往路３：座席区分（依頼）"
            Public Const REQ_O_AGE_3 As String = "往路３：航空搭乗者年齢（年齢）"
            Public Const ANS_O_STATUS_3 As String = "往路３：ステータス（回答）"
            Public Const ANS_O_KOTSUKIKAN_3 As String = "往路３：交通機関（回答）"
            Public Const ANS_O_DATE_3 As String = "往路３：利用日（回答）"
            Public Const ANS_O_AIRPORT1_3 As String = "往路３：出発地（回答）"
            Public Const ANS_O_AIRPORT2_3 As String = "往路３：到着地（回答）"
            Public Const ANS_O_TIME1_3 As String = "往路３：出発時間（回答）"
            Public Const ANS_O_TIME2_3 As String = "往路３：到着時間（回答）"
            Public Const ANS_O_BIN_3 As String = "往路３：列車名・便名（回答）"
            Public Const ANS_O_SEAT_3 As String = "往路３：座席区分（回答）"
            Public Const REQ_O_TEHAI_4 As String = "往路４：希望する（依頼）"
            Public Const REQ_O_IRAINAIYOU_4 As String = "往路４：依頼内容（依頼）"
            Public Const REQ_O_KOTSUKIKAN_4 As String = "往路４：交通機関（依頼）"
            Public Const REQ_O_DATE_4 As String = "往路４：利用日（依頼）"
            Public Const REQ_O_AIRPORT1_4 As String = "往路４：出発地（依頼）"
            Public Const REQ_O_AIRPORT2_4 As String = "往路４：到着地（依頼）"
            Public Const REQ_O_TIME1_4 As String = "往路４：出発時間（依頼）"
            Public Const REQ_O_TIME2_4 As String = "往路４：到着時間（依頼）"
            Public Const REQ_O_BIN_4 As String = "往路４：列車名・便名（依頼）"
            Public Const REQ_O_SEAT_4 As String = "往路４：座席区分（依頼）"
            Public Const REQ_O_AGE_4 As String = "往路４：航空搭乗者年齢（年齢）"
            Public Const ANS_O_STATUS_4 As String = "往路４：ステータス（回答）"
            Public Const ANS_O_KOTSUKIKAN_4 As String = "往路４：交通機関（回答）"
            Public Const ANS_O_DATE_4 As String = "往路４：利用日（回答）"
            Public Const ANS_O_AIRPORT1_4 As String = "往路４：出発地（回答）"
            Public Const ANS_O_AIRPORT2_4 As String = "往路４：到着地（回答）"
            Public Const ANS_O_TIME1_4 As String = "往路４：出発時間（回答）"
            Public Const ANS_O_TIME2_4 As String = "往路４：到着時間（回答）"
            Public Const ANS_O_BIN_4 As String = "往路４：列車名・便名（回答）"
            Public Const ANS_O_SEAT_4 As String = "往路４：座席区分（回答）"
            Public Const REQ_O_TEHAI_5 As String = "往路５：希望する（依頼）"
            Public Const REQ_O_IRAINAIYOU_5 As String = "往路５：依頼内容（依頼）"
            Public Const REQ_O_KOTSUKIKAN_5 As String = "往路５：交通機関（依頼）"
            Public Const REQ_O_DATE_5 As String = "往路５：利用日（依頼）"
            Public Const REQ_O_AIRPORT1_5 As String = "往路５：出発地（依頼）"
            Public Const REQ_O_AIRPORT2_5 As String = "往路５：到着地（依頼）"
            Public Const REQ_O_TIME1_5 As String = "往路５：出発時間（依頼）"
            Public Const REQ_O_TIME2_5 As String = "往路５：到着時間（依頼）"
            Public Const REQ_O_BIN_5 As String = "往路５：列車名・便名（依頼）"
            Public Const REQ_O_SEAT_5 As String = "往路５：座席区分（依頼）"
            Public Const REQ_O_AGE_5 As String = "往路５：航空搭乗者年齢（年齢）"
            Public Const ANS_O_STATUS_5 As String = "往路５：ステータス（回答）"
            Public Const ANS_O_KOTSUKIKAN_5 As String = "往路５：交通機関（回答）"
            Public Const ANS_O_DATE_5 As String = "往路５：利用日（回答）"
            Public Const ANS_O_AIRPORT1_5 As String = "往路５：出発地（回答）"
            Public Const ANS_O_AIRPORT2_5 As String = "往路５：到着地（回答）"
            Public Const ANS_O_TIME1_5 As String = "往路５：出発時間（回答）"
            Public Const ANS_O_TIME2_5 As String = "往路５：到着時間（回答）"
            Public Const ANS_O_BIN_5 As String = "往路５：列車名・便名（回答）"
            Public Const ANS_O_SEAT_5 As String = "往路５：座席区分（回答）"
            Public Const REQ_F_TEHAI_1 As String = "復路１：希望する（依頼）"
            Public Const REQ_F_IRAINAIYOU_1 As String = "復路１：依頼内容（依頼）"
            Public Const REQ_F_KOTSUKIKAN_1 As String = "復路１：交通機関（依頼）"
            Public Const REQ_F_DATE_1 As String = "復路１：利用日（依頼）"
            Public Const REQ_F_AIRPORT1_1 As String = "復路１：出発地（依頼）"
            Public Const REQ_F_AIRPORT2_1 As String = "復路１：到着地（依頼）"
            Public Const REQ_F_TIME1_1 As String = "復路１：出発時間（依頼）"
            Public Const REQ_F_TIME2_1 As String = "復路１：到着時間（依頼）"
            Public Const REQ_F_BIN_1 As String = "復路１：列車名・便名（依頼）"
            Public Const REQ_F_SEAT_1 As String = "復路１：座席区分（依頼）"
            Public Const REQ_F_AGE_1 As String = "復路１：航空搭乗者年齢（年齢）"
            Public Const ANS_F_STATUS_1 As String = "復路１：ステータス（回答）"
            Public Const ANS_F_KOTSUKIKAN_1 As String = "復路１：交通機関（回答）"
            Public Const ANS_F_DATE_1 As String = "復路１：利用日（回答）"
            Public Const ANS_F_AIRPORT1_1 As String = "復路１：出発地（回答）"
            Public Const ANS_F_AIRPORT2_1 As String = "復路１：到着地（回答）"
            Public Const ANS_F_TIME1_1 As String = "復路１：出発時間（回答）"
            Public Const ANS_F_TIME2_1 As String = "復路１：到着時間（回答）"
            Public Const ANS_F_BIN_1 As String = "復路１：列車名・便名（回答）"
            Public Const ANS_F_SEAT_1 As String = "復路１：座席区分（回答）"
            Public Const REQ_F_TEHAI_2 As String = "復路２：希望する（依頼）"
            Public Const REQ_F_IRAINAIYOU_2 As String = "復路２：依頼内容（依頼）"
            Public Const REQ_F_KOTSUKIKAN_2 As String = "復路２：交通機関（依頼）"
            Public Const REQ_F_DATE_2 As String = "復路２：利用日（依頼）"
            Public Const REQ_F_AIRPORT1_2 As String = "復路２：出発地（依頼）"
            Public Const REQ_F_AIRPORT2_2 As String = "復路２：到着地（依頼）"
            Public Const REQ_F_TIME1_2 As String = "復路２：出発時間（依頼）"
            Public Const REQ_F_TIME2_2 As String = "復路２：到着時間（依頼）"
            Public Const REQ_F_BIN_2 As String = "復路２：列車名・便名（依頼）"
            Public Const REQ_F_SEAT_2 As String = "復路２：座席区分（依頼）"
            Public Const REQ_F_AGE_2 As String = "復路２：航空搭乗者年齢（年齢）"
            Public Const ANS_F_STATUS_2 As String = "復路２：ステータス（回答）"
            Public Const ANS_F_KOTSUKIKAN_2 As String = "復路２：交通機関（回答）"
            Public Const ANS_F_DATE_2 As String = "復路２：利用日（回答）"
            Public Const ANS_F_AIRPORT1_2 As String = "復路２：出発地（回答）"
            Public Const ANS_F_AIRPORT2_2 As String = "復路２：到着地（回答）"
            Public Const ANS_F_TIME1_2 As String = "復路２：出発時間（回答）"
            Public Const ANS_F_TIME2_2 As String = "復路２：到着時間（回答）"
            Public Const ANS_F_BIN_2 As String = "復路２：列車名・便名（回答）"
            Public Const ANS_F_SEAT_2 As String = "復路２：座席区分（回答）"
            Public Const REQ_F_TEHAI_3 As String = "復路３：希望する（依頼）"
            Public Const REQ_F_IRAINAIYOU_3 As String = "復路３：依頼内容（依頼）"
            Public Const REQ_F_KOTSUKIKAN_3 As String = "復路３：交通機関（依頼）"
            Public Const REQ_F_DATE_3 As String = "復路３：利用日（依頼）"
            Public Const REQ_F_AIRPORT1_3 As String = "復路３：出発地（依頼）"
            Public Const REQ_F_AIRPORT2_3 As String = "復路３：到着地（依頼）"
            Public Const REQ_F_TIME1_3 As String = "復路３：出発時間（依頼）"
            Public Const REQ_F_TIME2_3 As String = "復路３：到着時間（依頼）"
            Public Const REQ_F_BIN_3 As String = "復路３：列車名・便名（依頼）"
            Public Const REQ_F_SEAT_3 As String = "復路３：座席区分（依頼）"
            Public Const REQ_F_AGE_3 As String = "復路３：航空搭乗者年齢（年齢）"
            Public Const ANS_F_STATUS_3 As String = "復路３：ステータス（回答）"
            Public Const ANS_F_KOTSUKIKAN_3 As String = "復路３：交通機関（回答）"
            Public Const ANS_F_DATE_3 As String = "復路３：利用日（回答）"
            Public Const ANS_F_AIRPORT1_3 As String = "復路３：出発地（回答）"
            Public Const ANS_F_AIRPORT2_3 As String = "復路３：到着地（回答）"
            Public Const ANS_F_TIME1_3 As String = "復路３：出発時間（回答）"
            Public Const ANS_F_TIME2_3 As String = "復路３：到着時間（回答）"
            Public Const ANS_F_BIN_3 As String = "復路３：列車名・便名（回答）"
            Public Const ANS_F_SEAT_3 As String = "復路３：座席区分（回答）"
            Public Const REQ_F_TEHAI_4 As String = "復路４：希望する（依頼）"
            Public Const REQ_F_IRAINAIYOU_4 As String = "復路４：依頼内容（依頼）"
            Public Const REQ_F_KOTSUKIKAN_4 As String = "復路４：交通機関（依頼）"
            Public Const REQ_F_DATE_4 As String = "復路４：利用日（依頼）"
            Public Const REQ_F_AIRPORT1_4 As String = "復路４：出発地（依頼）"
            Public Const REQ_F_AIRPORT2_4 As String = "復路４：到着地（依頼）"
            Public Const REQ_F_TIME1_4 As String = "復路４：出発時間（依頼）"
            Public Const REQ_F_TIME2_4 As String = "復路４：到着時間（依頼）"
            Public Const REQ_F_BIN_4 As String = "復路４：列車名・便名（依頼）"
            Public Const REQ_F_SEAT_4 As String = "復路４：座席区分（依頼）"
            Public Const REQ_F_AGE_4 As String = "復路４：航空搭乗者年齢（年齢）"
            Public Const ANS_F_STATUS_4 As String = "復路４：ステータス（回答）"
            Public Const ANS_F_KOTSUKIKAN_4 As String = "復路４：交通機関（回答）"
            Public Const ANS_F_DATE_4 As String = "復路４：利用日（回答）"
            Public Const ANS_F_AIRPORT1_4 As String = "復路４：出発地（回答）"
            Public Const ANS_F_AIRPORT2_4 As String = "復路４：到着地（回答）"
            Public Const ANS_F_TIME1_4 As String = "復路４：出発時間（回答）"
            Public Const ANS_F_TIME2_4 As String = "復路４：到着時間（回答）"
            Public Const ANS_F_BIN_4 As String = "復路４：列車名・便名（回答）"
            Public Const ANS_F_SEAT_4 As String = "復路４：座席区分（回答）"
            Public Const REQ_F_TEHAI_5 As String = "復路５：希望する（依頼）"
            Public Const REQ_F_IRAINAIYOU_5 As String = "復路５：依頼内容（依頼）"
            Public Const REQ_F_KOTSUKIKAN_5 As String = "復路５：交通機関（依頼）"
            Public Const REQ_F_DATE_5 As String = "復路５：利用日（依頼）"
            Public Const REQ_F_AIRPORT1_5 As String = "復路５：出発地（依頼）"
            Public Const REQ_F_AIRPORT2_5 As String = "復路５：到着地（依頼）"
            Public Const REQ_F_TIME1_5 As String = "復路５：出発時間（依頼）"
            Public Const REQ_F_TIME2_5 As String = "復路５：到着時間（依頼）"
            Public Const REQ_F_BIN_5 As String = "復路５：列車名・便名（依頼）"
            Public Const REQ_F_SEAT_5 As String = "復路５：座席区分（依頼）"
            Public Const REQ_F_AGE_5 As String = "復路５：航空搭乗者年齢（年齢）"
            Public Const ANS_F_STATUS_5 As String = "復路５：ステータス（回答）"
            Public Const ANS_F_KOTSUKIKAN_5 As String = "復路５：交通機関（回答）"
            Public Const ANS_F_DATE_5 As String = "復路５：利用日（回答）"
            Public Const ANS_F_AIRPORT1_5 As String = "復路５：出発地（回答）"
            Public Const ANS_F_AIRPORT2_5 As String = "復路５：到着地（回答）"
            Public Const ANS_F_TIME1_5 As String = "復路５：出発時間（回答）"
            Public Const ANS_F_TIME2_5 As String = "復路５：到着時間（回答）"
            Public Const ANS_F_BIN_5 As String = "復路５：列車名・便名（回答）"
            Public Const ANS_F_SEAT_5 As String = "復路５：座席区分（回答）"
            Public Const REQ_O_NOTE_1 As String = "往路備考（依頼）"
            Public Const ANS_O_NOTE_1 As String = "往路備考（回答）"
            Public Const REQ_F_NOTE_1 As String = "復路備考（依頼）"
            Public Const ANS_F_NOTE_1 As String = "復路備考（回答）"
            Public Const FIX_RAIL_FARE As String = "【確定】JR・鉄道代金"
            Public Const FIX_RAIL_CANCELLATION As String = "【確定】JR・鉄道取消料"
            Public Const FIX_AIR_FARE As String = "【確定】航空券代金"
            Public Const FIX_AIR_CANCELLATION As String = "【確定】航空券取消料"
            Public Const FIX_OTHER_FARE As String = "【確定】バス・船等代金"
            Public Const FIX_OTHER_CANCELLATION As String = "【確定】バス・船等取消料"
            Public Const TOUROKUKANRI_FEE As String = "登録管理手数料"
            Public Const TAXI_HAKKEN_FEE As String = "タクチケ発券手数料"
            Public Const TAXI_SEISAN_FEE As String = "タクチケ精算手数料"
            Public Const TEHAI_TAXI As String = "タクシーチケット（有・無）"
            Public Const TAXI_MOUSHIKOMI_SAKI As String = "タクシーチケット申込先"
            Public Const REQ_TAXI_DATE_1 As String = "タクシーチケット１：利用日（依頼）"
            Public Const REQ_TAXI_FROM_1 As String = "タクシーチケット１：発地（依頼）"
            Public Const REQ_TAXI_TO_1 As String = "タクシーチケット１：着地（依頼）"
            Public Const REQ_TAXI_NO_1 As String = "タクシーチケット１：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_1 As String = "タクシーチケット１：予定金額"
            Public Const ANS_TAXI_DATE_1 As String = "タクシーチケット１：利用日（回答）"
            Public Const ANS_TAXI_FROM_1 As String = "タクシーチケット１：発地（回答）"
            Public Const ANS_TAXI_TO_1 As String = "タクシーチケット１：着地（回答）"
            Public Const ANS_TAXI_KENSHU_1 As String = "タクシーチケット１：券種（回答）"
            Public Const ANS_TAXI_NO_1 As String = "タクシーチケット１：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_1 As String = "タクシーチケット１：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_1 As String = "タクシーチケット１：明細（回答）"
            Public Const ANS_TAXI_VOID_1 As String = "タクシーチケット１：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_1 As String = "タクシーチケット１：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_1 As String = "タクシーチケット１：請求月（回答）"
            Public Const REQ_TAXI_DATE_2 As String = "タクシーチケット２：利用日（依頼）"
            Public Const REQ_TAXI_FROM_2 As String = "タクシーチケット２：発地（依頼）"
            Public Const REQ_TAXI_TO_2 As String = "タクシーチケット２：着地（依頼）"
            Public Const REQ_TAXI_NO_2 As String = "タクシーチケット２：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_2 As String = "タクシーチケット２：予定金額"
            Public Const ANS_TAXI_DATE_2 As String = "タクシーチケット２：利用日（回答）"
            Public Const ANS_TAXI_FROM_2 As String = "タクシーチケット２：発地（回答）"
            Public Const ANS_TAXI_TO_2 As String = "タクシーチケット２：着地（回答）"
            Public Const ANS_TAXI_KENSHU_2 As String = "タクシーチケット２：券種（回答）"
            Public Const ANS_TAXI_NO_2 As String = "タクシーチケット２：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_2 As String = "タクシーチケット２：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_2 As String = "タクシーチケット２：明細（回答）"
            Public Const ANS_TAXI_VOID_2 As String = "タクシーチケット２：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_2 As String = "タクシーチケット２：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_2 As String = "タクシーチケット２：請求月（回答）"
            Public Const REQ_TAXI_DATE_3 As String = "タクシーチケット３：利用日（依頼）"
            Public Const REQ_TAXI_FROM_3 As String = "タクシーチケット３：発地（依頼）"
            Public Const REQ_TAXI_TO_3 As String = "タクシーチケット３：着地（依頼）"
            Public Const REQ_TAXI_NO_3 As String = "タクシーチケット３：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_3 As String = "タクシーチケット３：予定金額"
            Public Const ANS_TAXI_DATE_3 As String = "タクシーチケット３：利用日（回答）"
            Public Const ANS_TAXI_FROM_3 As String = "タクシーチケット３：発地（回答）"
            Public Const ANS_TAXI_TO_3 As String = "タクシーチケット３：着地（回答）"
            Public Const ANS_TAXI_KENSHU_3 As String = "タクシーチケット３：券種（回答）"
            Public Const ANS_TAXI_NO_3 As String = "タクシーチケット３：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_3 As String = "タクシーチケット３：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_3 As String = "タクシーチケット３：明細（回答）"
            Public Const ANS_TAXI_VOID_3 As String = "タクシーチケット３：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_3 As String = "タクシーチケット３：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_3 As String = "タクシーチケット３：請求月（回答）"
            Public Const REQ_TAXI_DATE_4 As String = "タクシーチケット４：利用日（依頼）"
            Public Const REQ_TAXI_FROM_4 As String = "タクシーチケット４：発地（依頼）"
            Public Const REQ_TAXI_TO_4 As String = "タクシーチケット４：着地（依頼）"
            Public Const REQ_TAXI_NO_4 As String = "タクシーチケット４：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_4 As String = "タクシーチケット４：予定金額"
            Public Const ANS_TAXI_DATE_4 As String = "タクシーチケット４：利用日（回答）"
            Public Const ANS_TAXI_FROM_4 As String = "タクシーチケット４：発地（回答）"
            Public Const ANS_TAXI_TO_4 As String = "タクシーチケット４：着地（回答）"
            Public Const ANS_TAXI_KENSHU_4 As String = "タクシーチケット４：券種（回答）"
            Public Const ANS_TAXI_NO_4 As String = "タクシーチケット４：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_4 As String = "タクシーチケット４：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_4 As String = "タクシーチケット４：明細（回答）"
            Public Const ANS_TAXI_VOID_4 As String = "タクシーチケット４：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_4 As String = "タクシーチケット４：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_4 As String = "タクシーチケット４：請求月（回答）"
            Public Const REQ_TAXI_DATE_5 As String = "タクシーチケット５：利用日（依頼）"
            Public Const REQ_TAXI_FROM_5 As String = "タクシーチケット５：発地（依頼）"
            Public Const REQ_TAXI_TO_5 As String = "タクシーチケット５：着地（依頼）"
            Public Const REQ_TAXI_NO_5 As String = "タクシーチケット５：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_5 As String = "タクシーチケット５：予定金額"
            Public Const ANS_TAXI_DATE_5 As String = "タクシーチケット５：利用日（回答）"
            Public Const ANS_TAXI_FROM_5 As String = "タクシーチケット５：発地（回答）"
            Public Const ANS_TAXI_TO_5 As String = "タクシーチケット５：着地（回答）"
            Public Const ANS_TAXI_KENSHU_5 As String = "タクシーチケット５：券種（回答）"
            Public Const ANS_TAXI_NO_5 As String = "タクシーチケット５：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_5 As String = "タクシーチケット５：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_5 As String = "タクシーチケット５：明細（回答）"
            Public Const ANS_TAXI_VOID_5 As String = "タクシーチケット５：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_5 As String = "タクシーチケット５：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_5 As String = "タクシーチケット５：請求月（回答）"
            Public Const REQ_TAXI_DATE_6 As String = "タクシーチケット６：利用日（依頼）"
            Public Const REQ_TAXI_FROM_6 As String = "タクシーチケット６：発地（依頼）"
            Public Const REQ_TAXI_TO_6 As String = "タクシーチケット６：着地（依頼）"
            Public Const REQ_TAXI_NO_6 As String = "タクシーチケット６：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_6 As String = "タクシーチケット６：予定金額"
            Public Const ANS_TAXI_DATE_6 As String = "タクシーチケット６：利用日（回答）"
            Public Const ANS_TAXI_FROM_6 As String = "タクシーチケット６：発地（回答）"
            Public Const ANS_TAXI_TO_6 As String = "タクシーチケット６：着地（回答）"
            Public Const ANS_TAXI_KENSHU_6 As String = "タクシーチケット６：券種（回答）"
            Public Const ANS_TAXI_NO_6 As String = "タクシーチケット６：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_6 As String = "タクシーチケット６：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_6 As String = "タクシーチケット６：明細（回答）"
            Public Const ANS_TAXI_VOID_6 As String = "タクシーチケット６：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_6 As String = "タクシーチケット６：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_6 As String = "タクシーチケット６：請求月（回答）"
            Public Const REQ_TAXI_DATE_7 As String = "タクシーチケット７：利用日（依頼）"
            Public Const REQ_TAXI_FROM_7 As String = "タクシーチケット７：発地（依頼）"
            Public Const REQ_TAXI_TO_7 As String = "タクシーチケット７：着地（依頼）"
            Public Const REQ_TAXI_NO_7 As String = "タクシーチケット７：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_7 As String = "タクシーチケット７：予定金額"
            Public Const ANS_TAXI_DATE_7 As String = "タクシーチケット７：利用日（回答）"
            Public Const ANS_TAXI_FROM_7 As String = "タクシーチケット７：発地（回答）"
            Public Const ANS_TAXI_TO_7 As String = "タクシーチケット７：着地（回答）"
            Public Const ANS_TAXI_KENSHU_7 As String = "タクシーチケット７：券種（回答）"
            Public Const ANS_TAXI_NO_7 As String = "タクシーチケット７：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_7 As String = "タクシーチケット７：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_7 As String = "タクシーチケット７：明細（回答）"
            Public Const ANS_TAXI_VOID_7 As String = "タクシーチケット７：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_7 As String = "タクシーチケット７：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_7 As String = "タクシーチケット７：請求月（回答）"
            Public Const REQ_TAXI_DATE_8 As String = "タクシーチケット８：利用日（依頼）"
            Public Const REQ_TAXI_FROM_8 As String = "タクシーチケット８：発地（依頼）"
            Public Const REQ_TAXI_TO_8 As String = "タクシーチケット８：着地（依頼）"
            Public Const REQ_TAXI_NO_8 As String = "タクシーチケット８：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_8 As String = "タクシーチケット８：予定金額"
            Public Const ANS_TAXI_DATE_8 As String = "タクシーチケット８：利用日（回答）"
            Public Const ANS_TAXI_FROM_8 As String = "タクシーチケット８：発地（回答）"
            Public Const ANS_TAXI_TO_8 As String = "タクシーチケット８：着地（回答）"
            Public Const ANS_TAXI_KENSHU_8 As String = "タクシーチケット８：券種（回答）"
            Public Const ANS_TAXI_NO_8 As String = "タクシーチケット８：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_8 As String = "タクシーチケット８：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_8 As String = "タクシーチケット８：明細（回答）"
            Public Const ANS_TAXI_VOID_8 As String = "タクシーチケット８：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_8 As String = "タクシーチケット８：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_8 As String = "タクシーチケット８：請求月（回答）"
            Public Const REQ_TAXI_DATE_9 As String = "タクシーチケット９：利用日（依頼）"
            Public Const REQ_TAXI_FROM_9 As String = "タクシーチケット９：発地（依頼）"
            Public Const REQ_TAXI_TO_9 As String = "タクシーチケット９：着地（依頼）"
            Public Const REQ_TAXI_NO_9 As String = "タクシーチケット９：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_9 As String = "タクシーチケット９：予定金額"
            Public Const ANS_TAXI_DATE_9 As String = "タクシーチケット９：利用日（回答）"
            Public Const ANS_TAXI_FROM_9 As String = "タクシーチケット９：発地（回答）"
            Public Const ANS_TAXI_TO_9 As String = "タクシーチケット９：着地（回答）"
            Public Const ANS_TAXI_KENSHU_9 As String = "タクシーチケット９：券種（回答）"
            Public Const ANS_TAXI_NO_9 As String = "タクシーチケット９：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_9 As String = "タクシーチケット９：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_9 As String = "タクシーチケット９：明細（回答）"
            Public Const ANS_TAXI_VOID_9 As String = "タクシーチケット９：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_9 As String = "タクシーチケット９：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_9 As String = "タクシーチケット９：請求月（回答）"
            Public Const REQ_TAXI_DATE_10 As String = "タクシーチケット１０：利用日（依頼）"
            Public Const REQ_TAXI_FROM_10 As String = "タクシーチケット１０：発地（依頼）"
            Public Const REQ_TAXI_TO_10 As String = "タクシーチケット１０：着地（依頼）"
            Public Const REQ_TAXI_NO_10 As String = "タクシーチケット１０：番号（依頼）"
            Public Const TAXI_YOTEIKINGAKU_10 As String = "タクシーチケット１０：予定金額"
            Public Const ANS_TAXI_DATE_10 As String = "タクシーチケット１０：利用日（回答）"
            Public Const ANS_TAXI_FROM_10 As String = "タクシーチケット１０：発地（回答）"
            Public Const ANS_TAXI_TO_10 As String = "タクシーチケット１０：着地（回答）"
            Public Const ANS_TAXI_KENSHU_10 As String = "タクシーチケット１０：券種（回答）"
            Public Const ANS_TAXI_NO_10 As String = "タクシーチケット１０：番号（回答）"
            Public Const ANS_TAXI_KINGAKU_10 As String = "タクシーチケット１０：利用額（回答）"
            Public Const ANS_TAXI_MEISAI_NO_10 As String = "タクシーチケット１０：明細（回答）"
            Public Const ANS_TAXI_VOID_10 As String = "タクシーチケット１０：VOID（回答）"
            Public Const ANS_TAXI_PRINTDATE_10 As String = "タクシーチケット１０：印刷日（回答）"
            Public Const ANS_TAXI_SEIKYUDATE_10 As String = "タクシーチケット１０：請求月（回答）"
            Public Const TAXI_NOTE As String = "タクチケ備考"
            Public Const TEHAI_MR As String = "MR随行有無(MR入力）"
            Public Const MR_SEAT As String = "MR随行（隣席、別席）(MR入力）"
            Public Const MR_SEX As String = "MR性別"
            Public Const MR_AGE As String = "MR年齢"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const SEND_DATE As String = "発送日"
        End Class
    End Class

    Public Class TBL_KAIJO
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_ID As String
            Public TIME_STAMP As String
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
            Public ANS_STATUS_TEHAI As String
            Public YOTEI_DATE As String
            Public KAISAI_DATE_NOTE As String
            Public MEETING_NAME As String
            Public SEIHIN_NAME As String
            Public SANKA_YOTEI_CNT_DR As String
            Public SANKA_YOTEI_CNT_OTHER As String
            Public MITSUMORI_TF As String
            Public MITSUMORI_T As String
            Public MITSUMORI_TOTAL As String
            Public MITSUMORI_URL As String
            Public KAISAI_KIBOU_ADDRESS1 As String
            Public KAISAI_KIBOU_ADDRESS2 As String
            Public KAISAI_KIBOU_NOTE As String
            Public KOUEN_KAIJO_TEHAI As String
            Public KOUEN_TIME1 As String
            Public KOUEN_TIME2 As String
            Public KOUEN_KAIJO_LAYOUT As String
            Public IKENKOUKAN_KAIJO_TEHAI As String
            Public IKENKOUKAN_TIME1 As String
            Public IKENKOUKAN_TIME2 As String
            Public KOUSHI_ROOM_TEHAI As String
            Public KOUSHI_ROOM_TIME1 As String
            Public KOUSHI_ROOM_TIME2 As String
            Public KOUSHI_ROOM_CNT As String
            Public MANAGER_KAIJO_TEHAI As String
            Public MANAGER_KAIJO_TIME1 As String
            Public MANAGER_KAIJO_TIME2 As String
            Public KAIJO_URL As String
            Public OTHER_NOTE As String
            Public FIX_KAISAI_SHISETSU As String
            Public FIX_KAISAI_NOTE As String
            Public FIX_SEISAN_TF As String
            Public FIX_SEISAN_GTAX As String
            Public FIX_SEISAN_NTAX As String

            Public KOUENKAI_NO As String
            Public KOUENKAI_EDABAN As String
            Public KOUENKAI_NAME As String
            Public TAXI_PRT_NAME As String
            Public FROM_DATE As String
            Public TO_DATE As String
            Public KIKAKU_TANTO_JIGYOBU As String
            Public KIKAKU_TANTO_AREA As String
            Public KIKAKU_TANTO_EIGYOSHO As String
            Public KIKAKU_TANTO_NO As String
            Public KIKAKU_TANTO_NAME As String
            Public KIKAKU_TANTO_KANA As String
            Public KIKAKU_TANTO_EMAIL As String
            Public KIKAKU_TANTO_KEITAI As String
            Public TEHAI_TANTO_JIGYOBU As String
            Public TEHAI_TANTO_AREA As String
            Public TEHAI_TANTO_EIGYOSHO As String
            Public TEHAI_TANTO_NO As String
            Public TEHAI_TANTO_NAME As String
            Public TEHAI_TANTO_KANA As String
            Public TEHAI_TANTO_EMAIL As String
            Public TEHAI_TANTO_KEITAI As String
            Public DAIKIBO_FLG As String
            Public TTANTO_ID As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_ID As String = "KOUENKAI_ID"
            Public Const TIME_STAMP As String = "TIME_STAMP"
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
            Public Const ANS_STATUS_TEHAI As String = "ANS_STATUS_TEHAI"
            Public Const YOTEI_DATE As String = "YOTEI_DATE"
            Public Const KAISAI_DATE_NOTE As String = "KAISAI_DATE_NOTE"
            Public Const MEETING_NAME As String = "MEETING_NAME"
            Public Const SEIHIN_NAME As String = "SEIHIN_NAME"
            Public Const SANKA_YOTEI_CNT_DR As String = "SANKA_YOTEI_CNT_DR"
            Public Const SANKA_YOTEI_CNT_OTHER As String = "SANKA_YOTEI_CNT_OTHER"
            Public Const MITSUMORI_TF As String = "MITSUMORI_TF"
            Public Const MITSUMORI_T As String = "MITSUMORI_T"
            Public Const MITSUMORI_TOTAL As String = "MITSUMORI_TOTAL"
            Public Const MITSUMORI_URL As String = "MITSUMORI_URL"
            Public Const KAISAI_KIBOU_ADDRESS1 As String = "KAISAI_KIBOU_ADDRESS1"
            Public Const KAISAI_KIBOU_ADDRESS2 As String = "KAISAI_KIBOU_ADDRESS2"
            Public Const KAISAI_KIBOU_NOTE As String = "KAISAI_KIBOU_NOTE"
            Public Const KOUEN_KAIJO_TEHAI As String = "KOUEN_KAIJO_TEHAI"
            Public Const KOUEN_TIME1 As String = "KOUEN_TIME1"
            Public Const KOUEN_TIME2 As String = "KOUEN_TIME2"
            Public Const KOUEN_KAIJO_LAYOUT As String = "KOUEN_KAIJO_LAYOUT"
            Public Const IKENKOUKAN_KAIJO_TEHAI As String = "IKENKOUKAN_KAIJO_TEHAI"
            Public Const IKENKOUKAN_TIME1 As String = "IKENKOUKAN_TIME1"
            Public Const IKENKOUKAN_TIME2 As String = "IKENKOUKAN_TIME2"
            Public Const KOUSHI_ROOM_TEHAI As String = "KOUSHI_ROOM_TEHAI"
            Public Const KOUSHI_ROOM_TIME1 As String = "KOUSHI_ROOM_TIME1"
            Public Const KOUSHI_ROOM_TIME2 As String = "KOUSHI_ROOM_TIME2"
            Public Const KOUSHI_ROOM_CNT As String = "KOUSHI_ROOM_CNT"
            Public Const MANAGER_KAIJO_TEHAI As String = "MANAGER_KAIJO_TEHAI"
            Public Const MANAGER_KAIJO_TIME1 As String = "MANAGER_KAIJO_TIME1"
            Public Const MANAGER_KAIJO_TIME2 As String = "MANAGER_KAIJO_TIME2"
            Public Const KAIJO_URL As String = "KAIJO_URL"
            Public Const OTHER_NOTE As String = "OTHER_NOTE"
            Public Const FIX_KAISAI_SHISETSU As String = "FIX_KAISAI_SHISETSU"
            Public Const FIX_KAISAI_NOTE As String = "FIX_KAISAI_NOTE"
            Public Const FIX_SEISAN_TF As String = "FIX_SEISAN_TF"
            Public Const FIX_SEISAN_GTAX As String = "FIX_SEISAN_GTAX"
            Public Const FIX_SEISAN_NTAX As String = "FIX_SEISAN_NTAX"

            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const KOUENKAI_EDABAN As String = "KOUENKAI_EDABAN"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const TAXI_PRT_NAME As String = "TAXI_PRT_NAME"
            Public Const FROM_DATE As String = "FROM_DATE"
            Public Const TO_DATE As String = "TO_DATE"
            Public Const KIKAKU_TANTO_JIGYOBU As String = "KIKAKU_TANTO_JIGYOBU"
            Public Const KIKAKU_TANTO_AREA As String = "KIKAKU_TANTO_AREA"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "KIKAKU_TANTO_EIGYOSHO"
            Public Const KIKAKU_TANTO_NO As String = "KIKAKU_TANTO_NO"
            Public Const KIKAKU_TANTO_NAME As String = "KIKAKU_TANTO_NAME"
            Public Const KIKAKU_TANTO_KANA As String = "KIKAKU_TANTO_KANA"
            Public Const KIKAKU_TANTO_EMAIL As String = "KIKAKU_TANTO_EMAIL"
            Public Const KIKAKU_TANTO_KEITAI As String = "KIKAKU_TANTO_KEITAI"
            Public Const TEHAI_TANTO_JIGYOBU As String = "TEHAI_TANTO_JIGYOBU"
            Public Const TEHAI_TANTO_AREA As String = "TEHAI_TANTO_AREA"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "TEHAI_TANTO_EIGYOSHO"
            Public Const TEHAI_TANTO_NO As String = "TEHAI_TANTO_NO"
            Public Const TEHAI_TANTO_NAME As String = "TEHAI_TANTO_NAME"
            Public Const TEHAI_TANTO_KANA As String = "TEHAI_TANTO_KANA"
            Public Const TEHAI_TANTO_EMAIL As String = "TEHAI_TANTO_EMAIL"
            Public Const TEHAI_TANTO_KEITAI As String = "TEHAI_TANTO_KEITAI"
            Public Const DAIKIBO_FLG As String = "DAIKIBO_FLG"
            Public Const TTANTO_ID As String = "TTANTO_ID"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const KOUENKAI_ID As String = "講演会ID"
            Public Const TIME_STAMP As String = "Time stamp"
            Public Const AREA As String = "所属エリア"
            Public Const ADDRESS As String = "住所"
            Public Const EIGYOSHO As String = "営業所"
            Public Const ZIP As String = "郵便番号"
            Public Const TANTO_NO As String = "担当者No"
            Public Const TANTO_NAME As String = "担当者名"
            Public Const TANTO_KANA As String = "担当者名（カタカナ）"
            Public Const INTERNAL_ORDER_T As String = "課税Internal order"
            Public Const ACCOUNT_CODE_T As String = "課税Account code"
            Public Const TEL As String = "電話番号"
            Public Const EMAIL As String = "Emailアドレス"
            Public Const SEND_SAKI_FS As String = "送付先FS"
            Public Const BU As String = "BU"
            Public Const ACCOUNT_CODE As String = "Account Code"
            Public Const COST_CENTER As String = "Cost Center"
            Public Const INTERNAL_ORDER As String = "Internal Order"
            Public Const ZETIA_CD As String = "zetia Code"
            Public Const STATUS_SHONIN As String = "承認ステータス"
            Public Const SHONIN_NAME As String = "承認者"
            Public Const SHONIN_TIME As String = "承認時間"
            Public Const SHONIN_NOTE As String = "承認者備考"
            Public Const CMSHONIN_NAME As String = "CM承認者"
            Public Const CMSHONIN_TIME As String = "CM承認時間"
            Public Const CMSHONIN_NOTE As String = "CM承認者備考"
            Public Const STATUS_TEHAI As String = "手配ステータス"
            Public Const ANS_STATUS_TEHAI As String = "【回答】手配ステータス"
            Public Const YOTEI_DATE As String = "実施予定日　（候補優先日）"
            Public Const KAISAI_DATE_NOTE As String = "開催日備考欄"
            Public Const MEETING_NAME As String = "会合名"
            Public Const SEIHIN_NAME As String = "製品名"
            Public Const SANKA_YOTEI_CNT_DR As String = "参加予定数　（医師・薬剤師）"
            Public Const SANKA_YOTEI_CNT_OTHER As String = "参加予定数　（その他）"
            Public Const MITSUMORI_TF As String = "見積額（非課税）"
            Public Const MITSUMORI_T As String = "見積額（課税）"
            Public Const MITSUMORI_TOTAL As String = "見積額（合計）"
            Public Const MITSUMORI_URL As String = "見積書保存URL"
            Public Const KAISAI_KIBOU_ADDRESS1 As String = "開催希望地　（都道府県）"
            Public Const KAISAI_KIBOU_ADDRESS2 As String = "開催希望地　（市町村）"
            Public Const KAISAI_KIBOU_NOTE As String = "開催希望　（フリーテキスト）"
            Public Const KOUEN_KAIJO_TEHAI As String = "講演会場　要・不要"
            Public Const KOUEN_TIME1 As String = "講演会　開始時間"
            Public Const KOUEN_TIME2 As String = "講演会　終了時間"
            Public Const KOUEN_KAIJO_LAYOUT As String = "講演会場　レイアウト"
            Public Const IKENKOUKAN_KAIJO_TEHAI As String = "意見交換会場　要・不要"
            Public Const IKENKOUKAN_TIME1 As String = "意見交換会　開始時間"
            Public Const IKENKOUKAN_TIME2 As String = "意見交換会　終了時間"
            Public Const KOUSHI_ROOM_TEHAI As String = "講師控室　要・不要"
            Public Const KOUSHI_ROOM_TIME1 As String = "講師控室　開始時間"
            Public Const KOUSHI_ROOM_TIME2 As String = "講師控室　終了時間"
            Public Const KOUSHI_ROOM_CNT As String = "講師控室　室数"
            Public Const MANAGER_KAIJO_TEHAI As String = "世話人会場　要・不要"
            Public Const MANAGER_KAIJO_TIME1 As String = "世話人会場　開始時間"
            Public Const MANAGER_KAIJO_TIME2 As String = "世話人会場　終了時間"
            Public Const KAIJO_URL As String = "会場URL"
            Public Const OTHER_NOTE As String = "その他備考欄"
            Public Const FIX_KAISAI_SHISETSU As String = "【確定】　開催地　（施設名）"
            Public Const FIX_KAISAI_NOTE As String = "【確定】　開催地　（備考欄）"
            Public Const FIX_SEISAN_TF As String = "【確定精算情報】　非課税"
            Public Const FIX_SEISAN_GTAX As String = "【確定精算情報】　課税１　(社外）"
            Public Const FIX_SEISAN_NTAX As String = "【確定精算情報】　課税１　(社内）"

            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const KOUENKAI_EDABAN As String = "枝番"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const TAXI_PRT_NAME As String = "タクシーチケット印字名"
            Public Const FROM_DATE As String = "講演会開催日From"
            Public Const TO_DATE As String = "講演会開催日To"
            Public Const KIKAKU_TANTO_JIGYOBU As String = "所属事業部"
            Public Const KIKAKU_TANTO_AREA As String = "所属エリア"
            Public Const KIKAKU_TANTO_EIGYOSHO As String = "所属営業所"
            Public Const KIKAKU_TANTO_NO As String = "担当者（企画担当者）No"
            Public Const KIKAKU_TANTO_NAME As String = "担当者（企画担当者）名"
            Public Const KIKAKU_TANTO_KANA As String = "担当者（企画担当者）名（カタカナ）"
            Public Const KIKAKU_TANTO_EMAIL As String = "Emailアドレス（企画担当者）"
            Public Const KIKAKU_TANTO_KEITAI As String = "携帯電話番号"
            Public Const TEHAI_TANTO_JIGYOBU As String = "所属事業部（手配担当者）"
            Public Const TEHAI_TANTO_AREA As String = "所属エリア（手配担当者）"
            Public Const TEHAI_TANTO_EIGYOSHO As String = "所属営業所（手配担当者）"
            Public Const TEHAI_TANTO_NO As String = "担当者（手配担当者）No"
            Public Const TEHAI_TANTO_NAME As String = "担当者（手配担当者）名"
            Public Const TEHAI_TANTO_KANA As String = "担当者（手配担当者）名（カタカナ）"
            Public Const TEHAI_TANTO_EMAIL As String = "Emailアドレス（手配担当者）"
            Public Const TEHAI_TANTO_KEITAI As String = "携帯電話番号"
            Public Const DAIKIBO_FLG As String = "特定大規模フラグ"
            Public Const TTANTO_ID As String = "トップツアー担当者ID"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
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
            Public Const TANTO_KANA As String = "担当者名（カタカナ）"
            Public Const INTERNAL_ORDER_T As String = "課税Internal order"
            Public Const ACCOUNT_CODE_T As String = "課税Account code"
            Public Const TEL As String = "電話番号"
            Public Const EMAIL As String = "Emailアドレス"
            Public Const SEND_SAKI_FS As String = "送付先FS"
            Public Const DR_MPID As String = "MPID"
            Public Const DR_NAME As String = "DR氏名"
            Public Const DR_KANA As String = "DR氏名（全角カタカナ）"
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
            Public Const ZETIA_CD As String = "zetia Code"
            Public Const STATUS_SHONIN As String = "承認ステータス"
            Public Const SHONIN_NAME As String = "承認者"
            Public Const SHONIN_TIME As String = "承認時間"
            Public Const SHONIN_NOTE As String = "承認者備考"
            Public Const CMSHONIN_NAME As String = "CM承認者"
            Public Const CMSHONIN_TIME As String = "CM承認時間"
            Public Const CMSHONIN_NOTE As String = "CM承認者備考"
            Public Const STATUS_TEHAI As String = "手配ステータス"
            Public Const HAITATSU_DATE As String = "配達日（実施日）"
            Public Const HAITATSU_KIBOU_TIME As String = "利用（配達希望）時間"
            Public Const HAITATSU_ADDRESS As String = "利用（配達）住所"
            Public Const HAITATSU_SHISETSU As String = "利用（配達）施設名"
            Public Const SURYO As String = "数量"
            Public Const TANKA As String = "単価"
            Public Const KIBOU_MAKER As String = "希望弁当業者"
            Public Const KIBOU_MENU As String = "希望メニュー"
            Public Const NOTE As String = "特記事項"
            Public Const ANS_STATUS_TEHAI As String = "【回答】手配ステータス"
            Public Const FIX_HAITATSU_TIME As String = "【確定】利用（配達）時間"
            Public Const FIX_HAITATSU_ADDRESS As String = "【確定】利用（配達）住所"
            Public Const FIX_HAITATSU_SHISETSU As String = "【確定】利用（配達）施設名"
            Public Const FIX_SURYO As String = "【確定】数量"
            Public Const FIX_TANKA As String = "【確定】単価"
            Public Const FIX_KINGAKU_TOTAL As String = "【確定】確定金額　合計"
            Public Const FIX_MAKER As String = "【確定】弁当業者"
            Public Const FIX_MAKER_CONTACT As String = "【確定】弁当業者連絡先"
            Public Const FIX_KIBOU_MAKER As String = "【確定】希望メニュー"
            Public Const FIX_NOTE As String = "【確定】特記事項"
        End Class
    End Class

    Public Class MS_SHISETSU
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public ADDRESS1 As String
            Public ADDRESS2 As String
            Public SHISETSU_NAME As String
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
            Public Const ADDRESS1 As String = "ADDRESS1"
            Public Const ADDRESS2 As String = "ADDRESS2"
            Public Const SHISETSU_NAME As String = "SHISETSU_NAME"
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
            Public Const ADDRESS1 As String = "都道府県"
            Public Const ADDRESS2 As String = "住所"
            Public Const SHISETSU_NAME As String = "施設名"
            Public Const TEL As String = "施設電話番号"
            Public Const CHECKIN_TIME As String = "ﾁｪｯｸｲﾝ時間"
            Public Const CHECKOUT_TIME As String = "ﾁｪｯｸｱｳﾄ時間"
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
            Public Const USER_NAME As String = "氏名"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_JIGYOSHO
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public 未定 As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const 未定 As String = "未定"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const 未定 As String = "未定"
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
            Public 未定 As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const 未定 As String = "未定"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const 未定 As String = "未定"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class MS_EIGYOSHO
        <Serializable()> Public Structure DataStruct
            Public SYSTEM_ID As String
            Public 未定 As String
            Public STOP_FLG As String
            Public INPUT_DATE As String
            Public INPUT_USER As String
            Public UPDATE_DATE As String
            Public UPDATE_USER As String
        End Structure
        Public Class Column
            Public Const SYSTEM_ID As String = "SYSTEM_ID"
            Public Const 未定 As String = "未定"
            Public Const STOP_FLG As String = "STOP_FLG"
            Public Const INPUT_DATE As String = "INPUT_DATE"
            Public Const INPUT_USER As String = "INPUT_USER"
            Public Const UPDATE_DATE As String = "UPDATE_DATE"
            Public Const UPDATE_USER As String = "UPDATE_USER"
        End Class
        Public Class Name
            Public Const SYSTEM_ID As String = "システムID"
            Public Const 未定 As String = "未定"
            Public Const STOP_FLG As String = "利用停止フラグ"
            Public Const INPUT_DATE As String = "登録日時"
            Public Const INPUT_USER As String = "登録者"
            Public Const UPDATE_DATE As String = "更新日時"
            Public Const UPDATE_USER As String = "更新者"
        End Class
    End Class

    Public Class TBL_KENSAKU
        <Serializable()> Public Structure DataStruct
            Public KOUENKAI_ID As String
            Public AREA As String
            Public EIGYOSHO As String
            Public TANTO_NAME As String
            Public TANTO_KANA As String
            Public KOUENKAI_NAME As String
            Public KOUENKAI_DATE As String
            Public KOUENKAI_NO As String
            Public JIGYOBU As String
            Public MEETING_NAME As String
            Public TTANTO_ID As String
        End Structure
        Public Class Column
            Public Const KOUENKAI_ID As String = "KOUENKAI_ID"
            Public Const AREA As String = "AREA"
            Public Const EIGYOSHO As String = "EIGYOSHO"
            Public Const TANTO_NAME As String = "TANTO_NAME"
            Public Const TANTO_KANA As String = "TANTO_KANA"
            Public Const KOUENKAI_NAME As String = "KOUENKAI_NAME"
            Public Const KOUENKAI_DATE As String = "KOUENKAI_DATE"
            Public Const KOUENKAI_NO As String = "KOUENKAI_NO"
            Public Const JIGYOBU As String = "JIGYOBU"
            Public Const MEETING_NAME As String = "MEETING_NAME"
            Public Const TTANTO_ID As String = "TTANTO_ID"
         End Class
        Public Class Name
            Public Const KOUENKAI_ID As String = "講演会ID"
            Public Const AREA As String = "所属エリア"
            Public Const EIGYOSHO As String = "所属営業所"
            Public Const TANTO_NAME As String = "担当者名"
            Public Const TANTO_KANA As String = "担当者名（カタカナ）"
            Public Const KOUENKAI_NAME As String = "講演会名"
            Public Const KOUENKAI_DATE As String = "講演会開催日"
            Public Const KOUENKAI_NO As String = "講演会番号"
            Public Const JIGYOBU As String = "事業部"
            Public Const MEETING_NAME As String = "会合名"
            Public Const TTANTO_ID As String = "担当者"
         End Class
    End Class


End Class
