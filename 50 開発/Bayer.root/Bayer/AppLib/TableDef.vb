Public Class TableDef

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

    Public Class MS_OFFICE
        <Serializable()> Public Structure DataStruct
            Public OFFICE As String
            Public ZIP As String
            Public ADDRESS As String
            Public TEL As String
            Public FAX As String
            Public SORT_NO As String
        End Structure
        Public Class Column
            Public Const OFFICE As String = "OFFICE"
            Public Const ZIP As String = "ZIP"
            Public Const ADDRESS As String = "ADDRESS"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const SORT_NO As String = "SORT_NO"
        End Class
        Public Class Name
            Public Const OFFICE As String = "所属"
            Public Const ZIP As String = "郵便番号"
            Public Const ADDRESS As String = "住所"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const SORT_NO As String = ""
        End Class
    End Class

    Public Class MS_MEMBER
        <Serializable()> Public Structure DataStruct
            Public MEMBER_ID As String
            Public MEMBER_PW As String
            Public LOGIN_FLAG As String
            Public UPD_DATE As String
            Public UPD_USER As String
            Public UPD_PGM As String
            Public INS_DATE As String
            Public INS_USER As String
            Public INS_PGM As String
            Public MEMBER_NAME_FIRST As String
            Public MEMBER_NAME_LAST As String
            Public MEMBER_NAME_KANA_FIRST As String
            Public MEMBER_NAME_KANA_LAST As String
            Public OFFICE As String
            Public ZIP As String
            Public ADDRESS As String
            Public TEL As String
            Public FAX As String
            Public KEITAI As String
            Public PC_MAIL As String
            Public KEITAI_MAIL As String
            Public SEX As String
            Public AGE As String
            Public ATTEND As String
            Public MEMBER_NAME As String
            Public MEMBER_NAME_KANA As String
            Public SORT_NO As String
        End Structure
        Public Class Column
            Public Const MEMBER_ID As String = "MEMBER_ID"
            Public Const MEMBER_PW As String = "MEMBER_PW"
            Public Const LOGIN_FLAG As String = "LOGIN_FLAG"
            Public Const UPD_DATE As String = "UPD_DATE"
            Public Const UPD_USER As String = "UPD_USER"
            Public Const UPD_PGM As String = "UPD_PGM"
            Public Const INS_DATE As String = "INS_DATE"
            Public Const INS_USER As String = "INS_USER"
            Public Const INS_PGM As String = "INS_PGM"
            Public Const MEMBER_NAME_FIRST As String = "MEMBER_NAME_FIRST"
            Public Const MEMBER_NAME_LAST As String = "MEMBER_NAME_LAST"
            Public Const MEMBER_NAME_KANA_FIRST As String = "MEMBER_NAME_KANA_FIRST"
            Public Const MEMBER_NAME_KANA_LAST As String = "MEMBER_NAME_KANA_LAST"
            Public Const OFFICE As String = "OFFICE"
            Public Const ZIP As String = "ZIP"
            Public Const ADDRESS As String = "ADDRESS"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const KEITAI As String = "KEITAI"
            Public Const PC_MAIL As String = "PC_MAIL"
            Public Const KEITAI_MAIL As String = "KEITAI_MAIL"
            Public Const SEX As String = "SEX"
            Public Const AGE As String = "AGE"
            Public Const ATTEND As String = "ATTEND"
            Public Const MEMBER_NAME As String = "MEMBER_NAME"
            Public Const MEMBER_NAME_KANA As String = "MEMBER_NAME_KANA"
            Public Const SORT_NO As String = "SORT_NO"
        End Class
        Public Class Name
            Public Const MEMBER_ID As String = "社員コード"
            Public Const MEMBER_PW As String = "パスワード"
            Public Const LOGIN_FLAG As String = "ログイン済みフラグ"
            Public Const UPD_DATE As String = "登録日時"
            Public Const UPD_USER As String = "登録ユーザ"
            Public Const UPD_PGM As String = "登録プログラム"
            Public Const INS_DATE As String = "更新日時"
            Public Const INS_USER As String = "更新ユーザ"
            Public Const INS_PGM As String = "更新プログラム"
            Public Const MEMBER_NAME_FIRST As String = "氏名(漢字)・姓"
            Public Const MEMBER_NAME_LAST As String = "氏名(漢字)・名"
            Public Const MEMBER_NAME_KANA_FIRST As String = "氏名(カナ)・姓"
            Public Const MEMBER_NAME_KANA_LAST As String = "氏名(カナ)・名"
            Public Const OFFICE As String = "所属"
            Public Const ZIP As String = "郵便番号"
            Public Const ADDRESS As String = "住所"
            Public Const TEL As String = "電話番号"
            Public Const FAX As String = "FAX番号"
            Public Const KEITAI As String = "携帯電話番号"
            Public Const PC_MAIL As String = "PCメールアドレス"
            Public Const KEITAI_MAIL As String = "携帯電話メールアドレス"
            Public Const SEX As String = "性別"
            Public Const AGE As String = "年齢"
            Public Const ATTEND As String = "来場"
            Public Const MEMBER_NAME As String = "氏名(漢字)"
            Public Const MEMBER_NAME_KANA As String = "氏名(カナ)"
            Public Const SORT_NO As String = ""
        End Class
    End Class

    Public Class TBL_DR
        <Serializable()> Public Structure DataStruct
            Public DATA_NO As String
            Public MEMBER_ID As String
            Public DR_ID As String
            Public RECORD_KUBUN As String
            Public STATUS_TEHAI As String
            Public STATUS_PAYMENT As String
            Public UPD_DATE As String
            Public UPD_USER As String
            Public UPD_PGM As String
            Public INS_DATE As String
            Public INS_USER As String
            Public INS_PGM As String
            Public INS_TYPE As String
            Public DR_MAIL As String
            Public DR_NAME_FIRST As String
            Public DR_NAME_LAST As String
            Public DR_NAME_KANA_FIRST As String
            Public DR_NAME_KANA_LAST As String
            Public PREFECTURES_NO As String
            Public SHISETSU_NAME As String
            Public SHISETSU_NAME_KANA As String
            Public KAMOKU As String
            Public YAKUSHOKU As String
            Public SEX As String
            Public AGE As String
            Public PARTY As String
            Public WETLAB_FLAG As String
            Public WETLAB_COURSE As String
            Public SANKA_KUBUN As String
            Public TEHAI_HOTEL As String
            Public HOTEL_NO As String
            Public ROOM_RATE As String
            Public STAY_DATE As String
            Public CHECK_IN As String
            Public CHECK_OUT As String
            Public HOTEL_SMOKING As String
            Public HOTEL_NAME As String
            Public HOTEL_ADDRESS As String
            Public HOTEL_TEL As String
            Public HOTEL_FAX As String
            Public ROOM_TYPE As String
            Public ROOM_SU As String
            Public HOTELPRINT_SHIHARAI As String
            Public HOTELPRINT_CHECKIN As String
            Public HOTELPRINT_RENRAKU As String
            Public HOTEL_CHECKIN_DATE As String
            Public HOTEL_CHECKOUT_DATE As String
            Public HOTELPRINT_SHIHARAI_IDX As String
            Public HOTELPRINT_CHECKIN_IDX As String
            Public HOTELPRINT_RENRAKU_IDX As String
            Public NOTE_HOTEL As String
            Public TEHAIMAIL_HOTEL As String
            Public ACCOMPANY_FLAG As String
            Public NOTE_ACCOMPANY As String
            Public ACCOMPANY_STAY As String
            Public ACCOMPANY_SAME_ROOM As String
            Public ACCOMPANY_STAY_DATE As String
            Public ACCOMPANY_CHECK_IN As String
            Public ACCOMPANY_CHECK_OUT As String
            Public ACCOMPANY_ADULT_SU As String
            Public ACCOMPANY_CHILD_SU As String
            Public ACCOMPANY_CHILD_AGE_1 As String
            Public ACCOMPANY_CHILD_AGE_2 As String
            Public ACCOMPANY_CHILD_BED_1 As String
            Public ACCOMPANY_CHILD_BED_2 As String
            Public ACCOMPANY_CHILD_SEX_1 As String
            Public ACCOMPANY_CHILD_SEX_2 As String
            Public ACCOMPANY_ROOM_RATE As String
            Public TEHAI_KOTSU As String
            Public KOTSU_NO As String
            Public O_KOTSU_FARE As String
            Public F_KOTSU_FARE As String
            Public O_KOTSU_KUBUN_1 As String
            Public O_DATE_1 As String
            Public O_BIN_1 As String
            Public O_AIRPORT1_1 As String
            Public O_AIRPORT2_1 As String
            Public O_LOCAL1_1 As String
            Public O_LOCAL2_1 As String
            Public O_EXPRESS1_1 As String
            Public O_EXPRESS2_1 As String
            Public O_TIME1_1 As String
            Public O_TIME2_1 As String
            Public O_SEAT_1 As String
            Public O_SEATCLASS_1 As String
            Public O_KOTSU_KUBUN_2 As String
            Public O_DATE_2 As String
            Public O_BIN_2 As String
            Public O_AIRPORT1_2 As String
            Public O_AIRPORT2_2 As String
            Public O_LOCAL1_2 As String
            Public O_LOCAL2_2 As String
            Public O_EXPRESS1_2 As String
            Public O_EXPRESS2_2 As String
            Public O_TIME1_2 As String
            Public O_TIME2_2 As String
            Public O_SEAT_2 As String
            Public O_SEATCLASS_2 As String
            Public O_KOTSU_KUBUN_3 As String
            Public O_DATE_3 As String
            Public O_BIN_3 As String
            Public O_AIRPORT1_3 As String
            Public O_AIRPORT2_3 As String
            Public O_LOCAL1_3 As String
            Public O_LOCAL2_3 As String
            Public O_EXPRESS1_3 As String
            Public O_EXPRESS2_3 As String
            Public O_TIME1_3 As String
            Public O_TIME2_3 As String
            Public O_SEAT_3 As String
            Public O_SEATCLASS_3 As String
            Public F_KOTSU_KUBUN_1 As String
            Public F_DATE_1 As String
            Public F_BIN_1 As String
            Public F_AIRPORT1_1 As String
            Public F_AIRPORT2_1 As String
            Public F_LOCAL1_1 As String
            Public F_LOCAL2_1 As String
            Public F_EXPRESS1_1 As String
            Public F_EXPRESS2_1 As String
            Public F_TIME1_1 As String
            Public F_TIME2_1 As String
            Public F_SEAT_1 As String
            Public F_SEATCLASS_1 As String
            Public F_KOTSU_KUBUN_2 As String
            Public F_DATE_2 As String
            Public F_BIN_2 As String
            Public F_AIRPORT1_2 As String
            Public F_AIRPORT2_2 As String
            Public F_LOCAL1_2 As String
            Public F_LOCAL2_2 As String
            Public F_EXPRESS1_2 As String
            Public F_EXPRESS2_2 As String
            Public F_TIME1_2 As String
            Public F_TIME2_2 As String
            Public F_SEAT_2 As String
            Public F_SEATCLASS_2 As String
            Public F_KOTSU_KUBUN_3 As String
            Public F_DATE_3 As String
            Public F_BIN_3 As String
            Public F_AIRPORT1_3 As String
            Public F_AIRPORT2_3 As String
            Public F_LOCAL1_3 As String
            Public F_LOCAL2_3 As String
            Public F_EXPRESS1_3 As String
            Public F_EXPRESS2_3 As String
            Public F_TIME1_3 As String
            Public F_TIME2_3 As String
            Public F_SEAT_3 As String
            Public F_SEATCLASS_3 As String
            Public AIRLINE As String
            Public MILAGE_NO As String
            Public NOTE_KOTSU As String
            Public TEHAIMAIL_KOTSU As String
            Public NOTES As String
            Public SEND_SAKI As String
            Public SEND_ZIP As String
            Public SEND_ADDRESS As String
            Public SEND_TEL As String
            Public SEND_NAME As String
            Public ATTEND_FLAG As String
            Public MAIL_FLAG As String
            Public ARRIVE_TIME As String
            Public TOTAL_AMOUNT As String
            Public SAGAKU_NAME_1 As String
            Public SAGAKU_1 As String
            Public SAGAKU_NAME_2 As String
            Public SAGAKU_2 As String
            Public SAGAKU_NAME_3 As String
            Public SAGAKU_3 As String
            Public SAGAKU_NAME_4 As String
            Public SAGAKU_4 As String
            Public SAGAKU_NAME_5 As String
            Public SAGAKU_5 As String
            Public REPLY As String
            Public REPLY_HOTEL As String
            Public REPLY_KOTSU As String
            Public PAYMENT_METHOD As String
            Public BILL_NO As String
            Public BILL_NAME As String
            Public PAYMENT_DATE_BANK As String
            Public AUTHORIZATION_NO As String
            Public TRANSACTION_NO As String
            Public PAYMENT_DATE_CARD As String
            Public PUBLIC_SERVANT As String
            Public SECANDARY_USE As String
            Public HOTELPRINT_ACCOMPANY As String
            Public HOTELPRINT_BREAKFAST As String
            Public ACCESS_ID As String
            Public ACCESS_PW As String
            Public TICKET_FLAG As String
            Public TICKET_SEND_DATE1 As String
            Public TICKET_SEND_DATE2 As String
            Public YOBI1 As String
            Public YOBI2 As String
            Public YOBI3 As String
            Public YOBI4 As String
            Public YOBI5 As String
            Public NEW_RECORD_KUBUN As String
            Public NEW_STATUS_TEHAI As String
            Public NEW_STATUS_PAYMENT As String
            Public DR_NAME As String
            Public DR_NAME_KANA As String
            Public MEMBER_NAME_FIRST As String
            Public MEMBER_NAME_LAST As String
            Public MEMBER_NAME_KANA_FIRST As String
            Public MEMBER_NAME_KANA_LAST As String
            Public MEMBER_NAME As String
            Public MEMBER_NAME_KANA As String
            Public HIS_KUBUN As String
            Public DATANO As String
            Public UPDDATE As String
            Public LOGIN_FLAG As String
            Public OFFICE As String
            Public ZIP As String
            Public ADDRESS As String
            Public TEL As String
            Public FAX As String
            Public KEITAI As String
            Public PC_MAIL As String
            Public KEITAI_MAIL As String
            Public SORT_NO As String
        End Structure
        Public Class Column
            Public Const DATA_NO As String = "DATA_NO"
            Public Const MEMBER_ID As String = "MEMBER_ID"
            Public Const DR_ID As String = "DR_ID"
            Public Const RECORD_KUBUN As String = "RECORD_KUBUN"
            Public Const STATUS_TEHAI As String = "STATUS_TEHAI"
            Public Const STATUS_PAYMENT As String = "STATUS_PAYMENT"
            Public Const UPD_DATE As String = "UPD_DATE"
            Public Const UPD_USER As String = "UPD_USER"
            Public Const UPD_PGM As String = "UPD_PGM"
            Public Const INS_DATE As String = "INS_DATE"
            Public Const INS_USER As String = "INS_USER"
            Public Const INS_PGM As String = "INS_PGM"
            Public Const INS_TYPE As String = "INS_TYPE"
            Public Const DR_MAIL As String = "DR_MAIL"
            Public Const DR_NAME_FIRST As String = "DR_NAME_FIRST"
            Public Const DR_NAME_LAST As String = "DR_NAME_LAST"
            Public Const DR_NAME_KANA_FIRST As String = "DR_NAME_KANA_FIRST"
            Public Const DR_NAME_KANA_LAST As String = "DR_NAME_KANA_LAST"
            Public Const PREFECTURES_NO As String = "PREFECTURES_NO"
            Public Const SHISETSU_NAME As String = "SHISETSU_NAME"
            Public Const SHISETSU_NAME_KANA As String = "SHISETSU_NAME_KANA"
            Public Const KAMOKU As String = "KAMOKU"
            Public Const YAKUSHOKU As String = "YAKUSHOKU"
            Public Const SEX As String = "SEX"
            Public Const AGE As String = "AGE"
            Public Const PARTY As String = "PARTY"
            Public Const WETLAB_FLAG As String = "WETLAB_FLAG"
            Public Const WETLAB_COURSE As String = "WETLAB_COURSE"
            Public Const SANKA_KUBUN As String = "SANKA_KUBUN"
            Public Const TEHAI_HOTEL As String = "TEHAI_HOTEL"
            Public Const HOTEL_NO As String = "HOTEL_NO"
            Public Const ROOM_RATE As String = "ROOM_RATE"
            Public Const STAY_DATE As String = "STAY_DATE"
            Public Const CHECK_IN As String = "CHECK_IN"
            Public Const CHECK_OUT As String = "CHECK_OUT"
            Public Const HOTEL_SMOKING As String = "HOTEL_SMOKING"
            Public Const HOTEL_NAME As String = "HOTEL_NAME"
            Public Const HOTEL_ADDRESS As String = "HOTEL_ADDRESS"
            Public Const HOTEL_TEL As String = "HOTEL_TEL"
            Public Const HOTEL_FAX As String = "HOTEL_FAX"
            Public Const ROOM_TYPE As String = "ROOM_TYPE"
            Public Const ROOM_SU As String = "ROOM_SU"
            Public Const HOTELPRINT_SHIHARAI As String = "HOTELPRINT_SHIHARAI"
            Public Const HOTELPRINT_CHECKIN As String = "HOTELPRINT_CHECKIN"
            Public Const HOTELPRINT_RENRAKU As String = "HOTELPRINT_RENRAKU"
            Public Const HOTEL_CHECKIN_DATE As String = "HOTEL_CHECKIN_DATE"
            Public Const HOTEL_CHECKOUT_DATE As String = "HOTEL_CHECKOUT_DATE"
            Public Const HOTELPRINT_SHIHARAI_IDX As String = "HOTELPRINT_SHIHARAI_IDX"
            Public Const HOTELPRINT_CHECKIN_IDX As String = "HOTELPRINT_CHECKIN_IDX"
            Public Const HOTELPRINT_RENRAKU_IDX As String = "HOTELPRINT_RENRAKU_IDX"
            Public Const NOTE_HOTEL As String = "NOTE_HOTEL"
            Public Const TEHAIMAIL_HOTEL As String = "TEHAIMAIL_HOTEL"
            Public Const ACCOMPANY_FLAG As String = "ACCOMPANY_FLAG"
            Public Const NOTE_ACCOMPANY As String = "NOTE_ACCOMPANY"
            Public Const ACCOMPANY_STAY As String = "ACCOMPANY_STAY"
            Public Const ACCOMPANY_SAME_ROOM As String = "ACCOMPANY_SAME_ROOM"
            Public Const ACCOMPANY_STAY_DATE As String = "ACCOMPANY_STAY_DATE"
            Public Const ACCOMPANY_CHECK_IN As String = "ACCOMPANY_CHECK_IN"
            Public Const ACCOMPANY_CHECK_OUT As String = "ACCOMPANY_CHECK_OUT"
            Public Const ACCOMPANY_ADULT_SU As String = "ACCOMPANY_ADULT_SU"
            Public Const ACCOMPANY_CHILD_SU As String = "ACCOMPANY_CHILD_SU"
            Public Const ACCOMPANY_CHILD_AGE_1 As String = "ACCOMPANY_CHILD_AGE_1"
            Public Const ACCOMPANY_CHILD_AGE_2 As String = "ACCOMPANY_CHILD_AGE_2"
            Public Const ACCOMPANY_CHILD_BED_1 As String = "ACCOMPANY_CHILD_BED_1"
            Public Const ACCOMPANY_CHILD_BED_2 As String = "ACCOMPANY_CHILD_BED_2"
            Public Const ACCOMPANY_CHILD_SEX_1 As String = "ACCOMPANY_CHILD_SEX_1"
            Public Const ACCOMPANY_CHILD_SEX_2 As String = "ACCOMPANY_CHILD_SEX_2"
            Public Const ACCOMPANY_ROOM_RATE As String = "ACCOMPANY_ROOM_RATE"
            Public Const TEHAI_KOTSU As String = "TEHAI_KOTSU"
            Public Const KOTSU_NO As String = "KOTSU_NO"
            Public Const O_KOTSU_FARE As String = "O_KOTSU_FARE"
            Public Const F_KOTSU_FARE As String = "F_KOTSU_FARE"
            Public Const O_KOTSU_KUBUN_1 As String = "O_KOTSU_KUBUN_1"
            Public Const O_DATE_1 As String = "O_DATE_1"
            Public Const O_BIN_1 As String = "O_BIN_1"
            Public Const O_AIRPORT1_1 As String = "O_AIRPORT1_1"
            Public Const O_AIRPORT2_1 As String = "O_AIRPORT2_1"
            Public Const O_LOCAL1_1 As String = "O_LOCAL1_1"
            Public Const O_LOCAL2_1 As String = "O_LOCAL2_1"
            Public Const O_EXPRESS1_1 As String = "O_EXPRESS1_1"
            Public Const O_EXPRESS2_1 As String = "O_EXPRESS2_1"
            Public Const O_TIME1_1 As String = "O_TIME1_1"
            Public Const O_TIME2_1 As String = "O_TIME2_1"
            Public Const O_SEAT_1 As String = "O_SEAT_1"
            Public Const O_SEATCLASS_1 As String = "O_SEATCLASS_1"
            Public Const O_KOTSU_KUBUN_2 As String = "O_KOTSU_KUBUN_2"
            Public Const O_DATE_2 As String = "O_DATE_2"
            Public Const O_BIN_2 As String = "O_BIN_2"
            Public Const O_AIRPORT1_2 As String = "O_AIRPORT1_2"
            Public Const O_AIRPORT2_2 As String = "O_AIRPORT2_2"
            Public Const O_LOCAL1_2 As String = "O_LOCAL1_2"
            Public Const O_LOCAL2_2 As String = "O_LOCAL2_2"
            Public Const O_EXPRESS1_2 As String = "O_EXPRESS1_2"
            Public Const O_EXPRESS2_2 As String = "O_EXPRESS2_2"
            Public Const O_TIME1_2 As String = "O_TIME1_2"
            Public Const O_TIME2_2 As String = "O_TIME2_2"
            Public Const O_SEAT_2 As String = "O_SEAT_2"
            Public Const O_SEATCLASS_2 As String = "O_SEATCLASS_2"
            Public Const O_KOTSU_KUBUN_3 As String = "O_KOTSU_KUBUN_3"
            Public Const O_DATE_3 As String = "O_DATE_3"
            Public Const O_BIN_3 As String = "O_BIN_3"
            Public Const O_AIRPORT1_3 As String = "O_AIRPORT1_3"
            Public Const O_AIRPORT2_3 As String = "O_AIRPORT2_3"
            Public Const O_LOCAL1_3 As String = "O_LOCAL1_3"
            Public Const O_LOCAL2_3 As String = "O_LOCAL2_3"
            Public Const O_EXPRESS1_3 As String = "O_EXPRESS1_3"
            Public Const O_EXPRESS2_3 As String = "O_EXPRESS2_3"
            Public Const O_TIME1_3 As String = "O_TIME1_3"
            Public Const O_TIME2_3 As String = "O_TIME2_3"
            Public Const O_SEAT_3 As String = "O_SEAT_3"
            Public Const O_SEATCLASS_3 As String = "O_SEATCLASS_3"
            Public Const F_KOTSU_KUBUN_1 As String = "F_KOTSU_KUBUN_1"
            Public Const F_DATE_1 As String = "F_DATE_1"
            Public Const F_BIN_1 As String = "F_BIN_1"
            Public Const F_AIRPORT1_1 As String = "F_AIRPORT1_1"
            Public Const F_AIRPORT2_1 As String = "F_AIRPORT2_1"
            Public Const F_LOCAL1_1 As String = "F_LOCAL1_1"
            Public Const F_LOCAL2_1 As String = "F_LOCAL2_1"
            Public Const F_EXPRESS1_1 As String = "F_EXPRESS1_1"
            Public Const F_EXPRESS2_1 As String = "F_EXPRESS2_1"
            Public Const F_TIME1_1 As String = "F_TIME1_1"
            Public Const F_TIME2_1 As String = "F_TIME2_1"
            Public Const F_SEAT_1 As String = "F_SEAT_1"
            Public Const F_SEATCLASS_1 As String = "F_SEATCLASS_1"
            Public Const F_KOTSU_KUBUN_2 As String = "F_KOTSU_KUBUN_2"
            Public Const F_DATE_2 As String = "F_DATE_2"
            Public Const F_BIN_2 As String = "F_BIN_2"
            Public Const F_AIRPORT1_2 As String = "F_AIRPORT1_2"
            Public Const F_AIRPORT2_2 As String = "F_AIRPORT2_2"
            Public Const F_LOCAL1_2 As String = "F_LOCAL1_2"
            Public Const F_LOCAL2_2 As String = "F_LOCAL2_2"
            Public Const F_EXPRESS1_2 As String = "F_EXPRESS1_2"
            Public Const F_EXPRESS2_2 As String = "F_EXPRESS2_2"
            Public Const F_TIME1_2 As String = "F_TIME1_2"
            Public Const F_TIME2_2 As String = "F_TIME2_2"
            Public Const F_SEAT_2 As String = "F_SEAT_2"
            Public Const F_SEATCLASS_2 As String = "F_SEATCLASS_2"
            Public Const F_KOTSU_KUBUN_3 As String = "F_KOTSU_KUBUN_3"
            Public Const F_DATE_3 As String = "F_DATE_3"
            Public Const F_BIN_3 As String = "F_BIN_3"
            Public Const F_AIRPORT1_3 As String = "F_AIRPORT1_3"
            Public Const F_AIRPORT2_3 As String = "F_AIRPORT2_3"
            Public Const F_LOCAL1_3 As String = "F_LOCAL1_3"
            Public Const F_LOCAL2_3 As String = "F_LOCAL2_3"
            Public Const F_EXPRESS1_3 As String = "F_EXPRESS1_3"
            Public Const F_EXPRESS2_3 As String = "F_EXPRESS2_3"
            Public Const F_TIME1_3 As String = "F_TIME1_3"
            Public Const F_TIME2_3 As String = "F_TIME2_3"
            Public Const F_SEAT_3 As String = "F_SEAT_3"
            Public Const F_SEATCLASS_3 As String = "F_SEATCLASS_3"
            Public Const AIRLINE As String = "AIRLINE"
            Public Const MILAGE_NO As String = "MILAGE_NO"
            Public Const NOTE_KOTSU As String = "NOTE_KOTSU"
            Public Const TEHAIMAIL_KOTSU As String = "TEHAIMAIL_KOTSU"
            Public Const NOTES As String = "NOTES"
            Public Const SEND_SAKI As String = "SEND_SAKI"
            Public Const SEND_ZIP As String = "SEND_ZIP"
            Public Const SEND_ADDRESS As String = "SEND_ADDRESS"
            Public Const SEND_TEL As String = "SEND_TEL"
            Public Const SEND_NAME As String = "SEND_NAME"
            Public Const ATTEND_FLAG As String = "ATTEND_FLAG"
            Public Const MAIL_FLAG As String = "MAIL_FLAG"
            Public Const ARRIVE_TIME As String = "ARRIVE_TIME"
            Public Const TOTAL_AMOUNT As String = "TOTAL_AMOUNT"
            Public Const SAGAKU_NAME_1 As String = "SAGAKU_NAME_1"
            Public Const SAGAKU_1 As String = "SAGAKU_1"
            Public Const SAGAKU_NAME_2 As String = "SAGAKU_NAME_2"
            Public Const SAGAKU_2 As String = "SAGAKU_2"
            Public Const SAGAKU_NAME_3 As String = "SAGAKU_NAME_3"
            Public Const SAGAKU_3 As String = "SAGAKU_3"
            Public Const SAGAKU_NAME_4 As String = "SAGAKU_NAME_4"
            Public Const SAGAKU_4 As String = "SAGAKU_4"
            Public Const SAGAKU_NAME_5 As String = "SAGAKU_NAME_5"
            Public Const SAGAKU_5 As String = "SAGAKU_5"
            Public Const REPLY As String = "REPLY"
            Public Const REPLY_HOTEL As String = "REPLY_HOTEL"
            Public Const REPLY_KOTSU As String = "REPLY_KOTSU"
            Public Const PAYMENT_METHOD As String = "PAYMENT_METHOD"
            Public Const BILL_NO As String = "BILL_NO"
            Public Const BILL_NAME As String = "BILL_NAME"
            Public Const PAYMENT_DATE_BANK As String = "PAYMENT_DATE_BANK"
            Public Const AUTHORIZATION_NO As String = "AUTHORIZATION_NO"
            Public Const TRANSACTION_NO As String = "TRANSACTION_NO"
            Public Const PAYMENT_DATE_CARD As String = "PAYMENT_DATE_CARD"
            Public Const PUBLIC_SERVANT As String = "PUBLIC_SERVANT"
            Public Const SECANDARY_USE As String = "SECANDARY_USE"
            Public Const HOTELPRINT_ACCOMPANY As String = "HOTELPRINT_ACCOMPANY"
            Public Const HOTELPRINT_BREAKFAST As String = "HOTELPRINT_BREAKFAST"
            Public Const ACCESS_ID As String = "ACCESS_ID"
            Public Const ACCESS_PW As String = "ACCESS_PW"
            Public Const TICKET_FLAG As String = "TICKET_FLAG"
            Public Const TICKET_SEND_DATE1 As String = "TICKET_SEND_DATE1"
            Public Const TICKET_SEND_DATE2 As String = "TICKET_SEND_DATE2"
            Public Const YOBI1 As String = "YOBI1"
            Public Const YOBI2 As String = "YOBI2"
            Public Const YOBI3 As String = "YOBI3"
            Public Const YOBI4 As String = "YOBI4"
            Public Const YOBI5 As String = "YOBI5"
            Public Const NEW_RECORD_KUBUN As String = "NEW_RECORD_KUBUN"
            Public Const NEW_STATUS_TEHAI As String = "NEW_STATUS_TEHAI"
            Public Const NEW_STATUS_PAYMENT As String = "NEW_STATUS_PAYMENT"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const DR_NAME_KANA As String = "DR_NAME_KANA"
            Public Const MEMBER_NAME_FIRST As String = "MEMBER_NAME_FIRST"
            Public Const MEMBER_NAME_LAST As String = "MEMBER_NAME_LAST"
            Public Const MEMBER_NAME_KANA_FIRST As String = "MEMBER_NAME_KANA_FIRST"
            Public Const MEMBER_NAME_KANA_LAST As String = "MEMBER_NAME_KANA_LAST"
            Public Const MEMBER_NAME As String = "MEMBER_NAME"
            Public Const MEMBER_NAME_KANA As String = "MEMBER_NAME_KANA"
            Public Const HIS_KUBUN As String = "HIS_KUBUN"
            Public Const DATANO As String = "DATANO"
            Public Const UPDDATE As String = "UPDDATE"
            Public Const LOGIN_FLAG As String = "LOGIN_FLAG"
            Public Const OFFICE As String = "OFFICE"
            Public Const ZIP As String = "ZIP"
            Public Const ADDRESS As String = "ADDRESS"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const KEITAI As String = "KEITAI"
            Public Const PC_MAIL As String = "PC_MAIL"
            Public Const KEITAI_MAIL As String = "KEITAI_MAIL"
            Public Const SORT_NO As String = "SORT_NO"
        End Class
        Public Class Name
            Public Const DATA_NO As String = "登録番号"
            Public Const MEMBER_ID As String = "社員コード"
            Public Const DR_ID As String = "ドクターログインID"
            Public Const RECORD_KUBUN As String = "データ登録区分"
            Public Const STATUS_TEHAI As String = "手配状況"
            Public Const STATUS_PAYMENT As String = "支払状況"
            Public Const UPD_DATE As String = "更新日時"
            Public Const UPD_USER As String = "更新ユーザ"
            Public Const UPD_PGM As String = "更新プログラム"
            Public Const INS_DATE As String = "登録日時"
            Public Const INS_USER As String = "登録ユーザ"
            Public Const INS_PGM As String = "登録プログラム"
            Public Const INS_TYPE As String = "登録者"
            Public Const DR_MAIL As String = "Dr.メールアドレス"
            Public Const DR_NAME_FIRST As String = "氏名(漢字)・姓"
            Public Const DR_NAME_LAST As String = "氏名(漢字)・名"
            Public Const DR_NAME_KANA_FIRST As String = "氏名(カナ)・姓"
            Public Const DR_NAME_KANA_LAST As String = "氏名(カナ)・名"
            Public Const PREFECTURES_NO As String = "都道府県"
            Public Const SHISETSU_NAME As String = "施設・病院名称"
            Public Const SHISETSU_NAME_KANA As String = "施設・病院名称(カナ)"
            Public Const KAMOKU As String = "診療科"
            Public Const YAKUSHOKU As String = "役職"
            Public Const SEX As String = "性別"
            Public Const AGE As String = "年齢"
            Public Const PARTY As String = "情報交換会"
            Public Const WETLAB_FLAG As String = "ウェットラボ"
            Public Const WETLAB_COURSE As String = "ウェットラボ コース"
            Public Const SANKA_KUBUN As String = "参加区分"
            Public Const TEHAI_HOTEL As String = "宿泊手配"
            Public Const HOTEL_NO As String = "宿泊パッケージ№"
            Public Const ROOM_RATE As String = "宿泊料金"
            Public Const STAY_DATE As String = "宿泊日"
            Public Const CHECK_IN As String = "チェックイン日"
            Public Const CHECK_OUT As String = "チェックアウト日"
            Public Const HOTEL_SMOKING As String = "おたばこ"
            Public Const HOTEL_NAME As String = "宿泊ホテル"
            Public Const HOTEL_ADDRESS As String = "ホテル住所"
            Public Const HOTEL_TEL As String = "電話番号"
            Public Const HOTEL_FAX As String = "FAX番号"
            Public Const ROOM_TYPE As String = "部屋タイプ"
            Public Const ROOM_SU As String = "部屋数"
            Public Const HOTELPRINT_SHIHARAI As String = "宿泊確認書:お支払いについて"
            Public Const HOTELPRINT_CHECKIN As String = "宿泊確認書:チェックインについて"
            Public Const HOTELPRINT_RENRAKU As String = "宿泊確認書:変更・取消のご連絡方法"
            Public Const HOTEL_CHECKIN_DATE As String = "チェックイン日"
            Public Const HOTEL_CHECKOUT_DATE As String = "チェックアウト日"
            Public Const HOTELPRINT_SHIHARAI_IDX As String = "宿泊確認書:お支払いについて(IDX)"
            Public Const HOTELPRINT_CHECKIN_IDX As String = "宿泊確認書:チェックインについて(IDX)"
            Public Const HOTELPRINT_RENRAKU_IDX As String = "宿泊確認書:変更・取消のご連絡方法(IDX)"
            Public Const NOTE_HOTEL As String = "宿泊備考欄"
            Public Const TEHAIMAIL_HOTEL As String = "宿泊手配 特別手配事項"
            Public Const ACCOMPANY_FLAG As String = "同伴者有無"
            Public Const NOTE_ACCOMPANY As String = "同伴者 詳細情報"
            Public Const ACCOMPANY_STAY As String = "同伴者 宿泊有無"
            Public Const ACCOMPANY_SAME_ROOM As String = "同伴者 同室/別室"
            Public Const ACCOMPANY_STAY_DATE As String = "同伴者 宿泊日"
            Public Const ACCOMPANY_CHECK_IN As String = "同伴者 チェックイン日"
            Public Const ACCOMPANY_CHECK_OUT As String = "同伴者 チェックアウト日"
            Public Const ACCOMPANY_ADULT_SU As String = "同室者人数(大人)"
            Public Const ACCOMPANY_CHILD_SU As String = "同室者人数(小人)"
            Public Const ACCOMPANY_CHILD_AGE_1 As String = "同室者(小人 1人目) 年齢"
            Public Const ACCOMPANY_CHILD_AGE_2 As String = "同室者(小人 2人目) 年齢"
            Public Const ACCOMPANY_CHILD_BED_1 As String = "同室者(小人 1人目) ベッド"
            Public Const ACCOMPANY_CHILD_BED_2 As String = "同室者(小人 2人目) ベッド"
            Public Const ACCOMPANY_CHILD_SEX_1 As String = "同室者(小人 1人目) 性別"
            Public Const ACCOMPANY_CHILD_SEX_2 As String = "同室者(小人 2人目) 性別"
            Public Const ACCOMPANY_ROOM_RATE As String = "同伴者 宿泊料金"
            Public Const TEHAI_KOTSU As String = "公共交通手配"
            Public Const KOTSU_NO As String = "交通パッケージ№"
            Public Const O_KOTSU_FARE As String = "往路:交通料金"
            Public Const F_KOTSU_FARE As String = "復路:交通料金"
            Public Const O_KOTSU_KUBUN_1 As String = "往路1:航空便/JR"
            Public Const O_DATE_1 As String = "往路1:乗車・搭乗日"
            Public Const O_BIN_1 As String = "往路1:便名"
            Public Const O_AIRPORT1_1 As String = "往路1:区間(発)"
            Public Const O_AIRPORT2_1 As String = "往路1:区間(着)"
            Public Const O_LOCAL1_1 As String = "往路1:乗車券区間(発)"
            Public Const O_LOCAL2_1 As String = "往路1:乗車券区間(着)"
            Public Const O_EXPRESS1_1 As String = "往路1:新幹線・特急区間(発)"
            Public Const O_EXPRESS2_1 As String = "往路1:新幹線・特急区間(着)"
            Public Const O_TIME1_1 As String = "往路1:発時間"
            Public Const O_TIME2_1 As String = "往路1:着時間"
            Public Const O_SEAT_1 As String = "往路1:座席希望"
            Public Const O_SEATCLASS_1 As String = "往路1:座席区分"
            Public Const O_KOTSU_KUBUN_2 As String = "往路2:航空便/JR"
            Public Const O_DATE_2 As String = "往路2:乗車・搭乗日"
            Public Const O_BIN_2 As String = "往路2:便名"
            Public Const O_AIRPORT1_2 As String = "往路2:区間(発)"
            Public Const O_AIRPORT2_2 As String = "往路2:区間(着)"
            Public Const O_LOCAL1_2 As String = "往路2:乗車券区間(発)"
            Public Const O_LOCAL2_2 As String = "往路2:乗車券区間(着)"
            Public Const O_EXPRESS1_2 As String = "往路2:新幹線・特急区間(発)"
            Public Const O_EXPRESS2_2 As String = "往路2:新幹線・特急区間(着)"
            Public Const O_TIME1_2 As String = "往路2:発時間"
            Public Const O_TIME2_2 As String = "往路2:着時間"
            Public Const O_SEAT_2 As String = "往路2:座席希望"
            Public Const O_SEATCLASS_2 As String = "往路2:座席区分"
            Public Const O_KOTSU_KUBUN_3 As String = "往路3:航空便/JR"
            Public Const O_DATE_3 As String = "往路3:乗車・搭乗日"
            Public Const O_BIN_3 As String = "往路3:便名"
            Public Const O_AIRPORT1_3 As String = "往路3:区間(発)"
            Public Const O_AIRPORT2_3 As String = "往路3:区間(着)"
            Public Const O_LOCAL1_3 As String = "往路3:乗車券区間(発)"
            Public Const O_LOCAL2_3 As String = "往路3:乗車券区間(着)"
            Public Const O_EXPRESS1_3 As String = "往路3:新幹線・特急区間(発)"
            Public Const O_EXPRESS2_3 As String = "往路3:新幹線・特急区間(着)"
            Public Const O_TIME1_3 As String = "往路3:発時間"
            Public Const O_TIME2_3 As String = "往路3:着時間"
            Public Const O_SEAT_3 As String = "往路3:座席希望"
            Public Const O_SEATCLASS_3 As String = "往路3:座席区分"
            Public Const F_KOTSU_KUBUN_1 As String = "復路1:航空便/JR"
            Public Const F_DATE_1 As String = "復路1:乗車・搭乗日"
            Public Const F_BIN_1 As String = "復路1:便名"
            Public Const F_AIRPORT1_1 As String = "復路1:区間(発)"
            Public Const F_AIRPORT2_1 As String = "復路1:区間(着)"
            Public Const F_LOCAL1_1 As String = "復路1:乗車券区間(発)"
            Public Const F_LOCAL2_1 As String = "復路1:乗車券区間(着)"
            Public Const F_EXPRESS1_1 As String = "復路1:新幹線・特急区間(発)"
            Public Const F_EXPRESS2_1 As String = "復路1:新幹線・特急区間(着)"
            Public Const F_TIME1_1 As String = "復路1:発時間"
            Public Const F_TIME2_1 As String = "復路1:着時間"
            Public Const F_SEAT_1 As String = "復路1:座席希望"
            Public Const F_SEATCLASS_1 As String = "復路1:座席区分"
            Public Const F_KOTSU_KUBUN_2 As String = "復路2:航空便/JR"
            Public Const F_DATE_2 As String = "復路2:乗車・搭乗日"
            Public Const F_BIN_2 As String = "復路2:便名"
            Public Const F_AIRPORT1_2 As String = "復路2:区間(発)"
            Public Const F_AIRPORT2_2 As String = "復路2:区間(着)"
            Public Const F_LOCAL1_2 As String = "復路2:乗車券区間(発)"
            Public Const F_LOCAL2_2 As String = "復路2:乗車券区間(着)"
            Public Const F_EXPRESS1_2 As String = "復路2:新幹線・特急区間(発)"
            Public Const F_EXPRESS2_2 As String = "復路2:新幹線・特急区間(着)"
            Public Const F_TIME1_2 As String = "復路2:発時間"
            Public Const F_TIME2_2 As String = "復路2:着時間"
            Public Const F_SEAT_2 As String = "復路2:座席希望"
            Public Const F_SEATCLASS_2 As String = "復路2:座席区分"
            Public Const F_KOTSU_KUBUN_3 As String = "復路3:航空便/JR"
            Public Const F_DATE_3 As String = "復路3:乗車・搭乗日"
            Public Const F_BIN_3 As String = "復路3:便名"
            Public Const F_AIRPORT1_3 As String = "復路3:区間(発)"
            Public Const F_AIRPORT2_3 As String = "復路3:区間(着)"
            Public Const F_LOCAL1_3 As String = "復路3:乗車券区間(発)"
            Public Const F_LOCAL2_3 As String = "復路3:乗車券区間(着)"
            Public Const F_EXPRESS1_3 As String = "復路3:新幹線・特急区間(発)"
            Public Const F_EXPRESS2_3 As String = "復路3:新幹線・特急区間(着)"
            Public Const F_TIME1_3 As String = "復路3:発時間"
            Public Const F_TIME2_3 As String = "復路3:着時間"
            Public Const F_SEAT_3 As String = "復路3:座席希望"
            Public Const F_SEATCLASS_3 As String = "復路3:座席区分"
            Public Const AIRLINE As String = "航空会社"
            Public Const MILAGE_NO As String = "マイレージナンバー"
            Public Const NOTE_KOTSU As String = "交通備考欄"
            Public Const TEHAIMAIL_KOTSU As String = "公共交通手配 特別手配事項"
            Public Const NOTES As String = "備考"
            Public Const SEND_SAKI As String = "チケット送付先"
            Public Const SEND_ZIP As String = "チケット送付先:郵便番号"
            Public Const SEND_ADDRESS As String = "チケット送付先:住所"
            Public Const SEND_TEL As String = "チケット送付先:電話番号"
            Public Const SEND_NAME As String = "チケット送付先:宛先名"
            Public Const ATTEND_FLAG As String = "出欠フラグ"
            Public Const MAIL_FLAG As String = "メール送信フラグ"
            Public Const ARRIVE_TIME As String = "来場時刻"
            Public Const TOTAL_AMOUNT As String = "合計金額"
            Public Const SAGAKU_NAME_1 As String = "差額名称1"
            Public Const SAGAKU_1 As String = "差額1"
            Public Const SAGAKU_NAME_2 As String = "差額名称2"
            Public Const SAGAKU_2 As String = "差額2"
            Public Const SAGAKU_NAME_3 As String = "差額名称3"
            Public Const SAGAKU_3 As String = "差額3"
            Public Const SAGAKU_NAME_4 As String = "差額名称4"
            Public Const SAGAKU_4 As String = "差額4"
            Public Const SAGAKU_NAME_5 As String = "差額名称5"
            Public Const SAGAKU_5 As String = "差額5"
            Public Const REPLY As String = "トップツアー回答"
            Public Const REPLY_HOTEL As String = "トップツアー回答・宿泊"
            Public Const REPLY_KOTSU As String = "トップツアー回答・交通"
            Public Const PAYMENT_METHOD As String = "お支払い方法"
            Public Const BILL_NO As String = "請求書番号"
            Public Const BILL_NAME As String = "請求先名"
            Public Const PAYMENT_DATE_BANK As String = "入金日"
            Public Const AUTHORIZATION_NO As String = "承認番号"
            Public Const TRANSACTION_NO As String = "取引番号"
            Public Const PAYMENT_DATE_CARD As String = "カード決済完了日"
            Public Const PUBLIC_SERVANT As String = "公務員/非公務員"
            Public Const SECANDARY_USE As String = "画像及び発言の二次使用"
            Public Const HOTELPRINT_ACCOMPANY As String = "宿泊確認書:同伴者について"
            Public Const HOTELPRINT_BREAKFAST As String = "宿泊確認書:朝食について"
            Public Const ACCESS_ID As String = "取引ID"
            Public Const ACCESS_PW As String = "取引PW"
            Public Const TICKET_FLAG As String = "チケット発送"
            Public Const TICKET_SEND_DATE1 As String = "チケット発送日 1"
            Public Const TICKET_SEND_DATE2 As String = "チケット発送日 2"
            Public Const YOBI1 As String = ""
            Public Const YOBI2 As String = ""
            Public Const YOBI3 As String = ""
            Public Const YOBI4 As String = ""
            Public Const YOBI5 As String = ""
            Public Const NEW_RECORD_KUBUN As String = ""
            Public Const NEW_STATUS_TEHAI As String = ""
            Public Const NEW_STATUS_PAYMENT As String = ""
            Public Const DR_NAME As String = "氏名(漢字)"
            Public Const DR_NAME_KANA As String = "氏名(カナ)"
            Public Const MEMBER_NAME_FIRST As String = "営業担当者氏名(漢字)・姓"
            Public Const MEMBER_NAME_LAST As String = "営業担当者氏名(漢字)・名"
            Public Const MEMBER_NAME_KANA_FIRST As String = "営業担当者氏名(カナ)・姓"
            Public Const MEMBER_NAME_KANA_LAST As String = "営業担当者氏名(カナ)・名"
            Public Const MEMBER_NAME As String = "営業担当者氏名(漢字)"
            Public Const MEMBER_NAME_KANA As String = "営業担当者氏名(カナ)"
            Public Const HIS_KUBUN As String = "履歴"
            Public Const DATANO As String = ""
            Public Const UPDDATE As String = ""
            Public Const LOGIN_FLAG As String = ""
            Public Const OFFICE As String = "所属"
            Public Const ZIP As String = "郵便番号"
            Public Const ADDRESS As String = "住所"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const KEITAI As String = "携帯電話番号"
            Public Const PC_MAIL As String = "PCメールアドレス"
            Public Const KEITAI_MAIL As String = "携帯電話メールアドレス"
            Public Const SORT_NO As String = ""
            Public Const GMO_ORDER_ID As String = "GMOオーダーID"
        End Class
    End Class

    Public Class MS_PACKAGE_HOTEL
        <Serializable()> Public Structure DataStruct
            Public HOTEL_NO As String
            Public HOTEL_NAME As String
            Public CHECKIN_DATE As String
            Public ROOM_RATE As String
            Public ACCOMPANY_ROOM_RATE_TWIN As String
            Public ACCOMPANY_ROOM_RATE_TRIPLE As String
            Public ACCOMPANY_ROOM_RATE_OTHER As String
        End Structure
        Public Class Column
            Public Const HOTEL_NO As String = "HOTEL_NO"
            Public Const HOTEL_NAME As String = "HOTEL_NAME"
            Public Const CHECKIN_DATE As String = "CHECKIN_DATE"
            Public Const ROOM_RATE As String = "ROOM_RATE"
            Public Const ACCOMPANY_ROOM_RATE_TWIN As String = "ACCOMPANY_ROOM_RATE_TWIN"
            Public Const ACCOMPANY_ROOM_RATE_TRIPLE As String = "ACCOMPANY_ROOM_RATE_TRIPLE"
            Public Const ACCOMPANY_ROOM_RATE_OTHER As String = "ACCOMPANY_ROOM_RATE_OTHER"
        End Class
        Public Class Name
            Public Const HOTEL_NO As String = ""
            Public Const HOTEL_NAME As String = ""
            Public Const CHECKIN_DATE As String = ""
            Public Const ROOM_RATE As String = ""
            Public Const ACCOMPANY_ROOM_RATE_TWIN As String = ""
            Public Const ACCOMPANY_ROOM_RATE_TRIPLE As String = ""
            Public Const ACCOMPANY_ROOM_RATE_OTHER As String = ""
        End Class
    End Class

    Public Class MS_PACKAGE_KOTSU
        <Serializable()> Public Structure DataStruct
            Public KOTSU_NO As String
            Public PREFECTURES_NO As String
            Public AIR_FLAG As String
            Public AIR_FARE As String
            Public JR_FLAG As String
            Public JR_FARE As String
        End Structure
        Public Class Column
            Public Const KOTSU_NO As String = "KOTSU_NO"
            Public Const PREFECTURES_NO As String = "PREFECTURES_NO"
            Public Const AIR_FLAG As String = "AIR_FLAG"
            Public Const AIR_FARE As String = "AIR_FARE"
            Public Const JR_FLAG As String = "JR_FLAG"
            Public Const JR_FARE As String = "JR_FARE"
        End Class
        Public Class Name
            Public Const KOTSU_NO As String = ""
            Public Const PREFECTURES_NO As String = ""
            Public Const AIR_FLAG As String = ""
            Public Const AIR_FARE As String = ""
            Public Const JR_FLAG As String = ""
            Public Const JR_FARE As String = ""
        End Class
    End Class

    Public Class MS_HOTEL
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public HOTEL_NAME As String
            Public ADDRESS As String
            Public TEL As String
            Public FAX As String
            Public URL As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const HOTEL_NAME As String = "HOTEL_NAME"
            Public Const ADDRESS As String = "ADDRESS"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const URL As String = "URL"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const HOTEL_NAME As String = ""
            Public Const ADDRESS As String = ""
            Public Const TEL As String = ""
            Public Const FAX As String = ""
            Public Const URL As String = ""
        End Class
    End Class

    Public Class MS_HOTELPRINT_ACCOMPANY
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public DISP_TEXT As String
            Public DISP_VALUE As String
            Public DETAIL As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const DISP_TEXT As String = "DISP_TEXT"
            Public Const DISP_VALUE As String = "DISP_VALUE"
            Public Const DETAIL As String = "DETAIL"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const DISP_TEXT As String = ""
            Public Const DISP_VALUE As String = ""
            Public Const DETAIL As String = ""
        End Class
    End Class

    Public Class MS_HOTELPRINT_BREAKFAST
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public DISP_TEXT As String
            Public DISP_VALUE As String
            Public DETAIL As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const DISP_TEXT As String = "DISP_TEXT"
            Public Const DISP_VALUE As String = "DISP_VALUE"
            Public Const DETAIL As String = "DETAIL"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const DISP_TEXT As String = ""
            Public Const DISP_VALUE As String = ""
            Public Const DETAIL As String = ""
        End Class
    End Class

    Public Class MS_HOTELPRINT_CHECKIN
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public DISP_TEXT As String
            Public DISP_VALUE As String
            Public DETAIL As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const DISP_TEXT As String = "DISP_TEXT"
            Public Const DISP_VALUE As String = "DISP_VALUE"
            Public Const DETAIL As String = "DETAIL"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const DISP_TEXT As String = ""
            Public Const DISP_VALUE As String = ""
            Public Const DETAIL As String = ""
        End Class
    End Class

    Public Class MS_HOTELPRINT_RENRAKU
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public DISP_TEXT As String
            Public DISP_VALUE As String
            Public DETAIL As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const DISP_TEXT As String = "DISP_TEXT"
            Public Const DISP_VALUE As String = "DISP_VALUE"
            Public Const DETAIL As String = "DETAIL"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const DISP_TEXT As String = ""
            Public Const DISP_VALUE As String = ""
            Public Const DETAIL As String = ""
        End Class
    End Class

    Public Class MS_HOTELPRINT_SHIHARAI
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public DISP_TEXT As String
            Public DISP_VALUE As String
            Public DETAIL As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const DISP_TEXT As String = "DISP_TEXT"
            Public Const DISP_VALUE As String = "DISP_VALUE"
            Public Const DETAIL As String = "DETAIL"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const DISP_TEXT As String = ""
            Public Const DISP_VALUE As String = ""
            Public Const DETAIL As String = ""
        End Class
    End Class

    Public Class MS_ROOM_TYPE
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public HOTEL_NAME As String
            Public ROOM_TYPE As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const HOTEL_NAME As String = "HOTEL_NAME"
            Public Const ROOM_TYPE As String = "ROOM_TYPE"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const HOTEL_NAME As String = ""
            Public Const ROOM_TYPE As String = ""
        End Class
    End Class

    Public Class MS_MANAGE
        <Serializable()> Public Structure DataStruct
            Public MANAGE_ID As String
            Public MANAGE_PW As String
            Public SHITEN_CD As String
            Public SHITEN_NAME As String
            Public EIGYOSHO_CD As String
            Public EIGYOSHO_NAME As String
            Public KENGEN As String
        End Structure
        Public Class Column
            Public Const MANAGE_ID As String = "MANAGE_ID"
            Public Const MANAGE_PW As String = "MANAGE_PW"
            Public Const SHITEN_CD As String = "SHITEN_CD"
            Public Const SHITEN_NAME As String = "SHITEN_NAME"
            Public Const EIGYOSHO_CD As String = "EIGYOSHO_CD"
            Public Const EIGYOSHO_NAME As String = "EIGYOSHO_NAME"
            Public Const KENGEN As String = "KENGEN"
        End Class
        Public Class Name
            Public Const MANAGE_ID As String = ""
            Public Const MANAGE_PW As String = ""
            Public Const SHITEN_CD As String = ""
            Public Const SHITEN_NAME As String = ""
            Public Const EIGYOSHO_CD As String = ""
            Public Const EIGYOSHO_NAME As String = ""
            Public Const KENGEN As String = ""
        End Class
    End Class

    Public Class MS_PREFECTURES
        <Serializable()> Public Structure DataStruct
            Public PREFECTURES_NO As String
            Public PREFECTURES As String
        End Structure
        Public Class Column
            Public Const PREFECTURES_NO As String = "PREFECTURES_NO"
            Public Const PREFECTURES As String = "PREFECTURES"
        End Class
        Public Class Name
            Public Const PREFECTURES_NO As String = ""
            Public Const PREFECTURES As String = "都道府県"
        End Class
    End Class

    Public Class Joken
        <Serializable()> Public Structure DataStruct
            Public PLACE As String
            Public DATA_NO As String
            Public RECORD_KUBUN As String
            Public DR_NAME As String
            Public MEMBER_NAME As String
            Public MEMBER_ID As String
            Public SHISETSU_CODE As String
            Public SHISETSU_NAME As String
            Public TEHAI_HOTEL As String
            Public TEHAI_KOTSU As String
            Public O_DATE As String
            Public F_DATE As String
            Public OFFICE As String
        End Structure
    End Class

    Public Class DATA_COUNT
        <Serializable()> Public Structure DataStruct
            Public SHITEN As String
            Public EIGYOSHO As String
            Public KA As String
            Public SHITEN_NAME As String
            Public EIGYOSHO_NAME As String
            Public KA_NAME As String
            Public DOCTOR_SU As Long
            Public DR_TEHAI_HOTEL As Long
            Public DR_TEHAI_KOTSU As Long
            Public MR_SU As Long
            Public MR_TEHAI_KOTSU As Long
        End Structure
        Public Class Column
            Public Const SHITEN As String = "SHITEN"
            Public Const EIGYOSHO As String = "EIGYOSHO"
            Public Const KA As String = "KA"
            Public Const SHITEN_NAME As String = "SHITEN_NAME"
            Public Const EIGYOSHO_NAME As String = "EIGYOSHO_NAME"
            Public Const KA_NAME As String = "KA_NAME"
            Public Const DOCTOR_SU As String = "DOCTOR_SU"
            Public Const DR_TEHAI_HOTEL As String = "DR_TEHAI_HOTEL"
            Public Const DR_TEHAI_KOTSU As String = "DR_TEHAI_KOTSU"
            Public Const MR_SU As String = "MR_SU"
            Public Const MR_TEHAI_KOTSU As String = "MR_TEHAI_KOTSU"
        End Class
    End Class

    Public Class MS_DR
        <Serializable()> Public Structure DataStruct
            Public DR_ID As String
            Public DR_PW As String
            Public UPD_DATE As String
            Public UPD_USER As String
            Public UPD_PGM As String
            Public INS_DATE As String
            Public INS_USER As String
            Public INS_PGM As String
            Public MEMBER_ID As String
            Public MEMBER_NAME As String
            Public DR_NAME_FIRST As String
            Public DR_NAME_LAST As String
            Public DR_NAME_KANA_FIRST As String
            Public DR_NAME_KANA_LAST As String
            Public DATA_ID As String
            Public SHISETSU_NAME As String
            Public SHISETSU_NAME_KANA As String
            Public DR_MAIL As String
            Public PC_MAIL As String
            Public OFFICE As String
            Public ZIP As String
            Public ADDRESS As String
            Public TEL As String
            Public FAX As String
            Public DR_NAME As String
            Public DR_NAME_KANA As String
            Public MEMBER_NAME_FIRST As String
            Public MEMBER_NAME_LAST As String
            Public MEMBER_NAME_KANA_FIRST As String
            Public MEMBER_NAME_KANA_LAST As String
            Public MEMBER_NAME_KANA As String
            Public SORT_NO As String
        End Structure
        Public Class Column
            Public Const DR_ID As String = "DR_ID"
            Public Const DR_PW As String = "DR_PW"
            Public Const UPD_DATE As String = "UPD_DATE"
            Public Const UPD_USER As String = "UPD_USER"
            Public Const UPD_PGM As String = "UPD_PGM"
            Public Const INS_DATE As String = "INS_DATE"
            Public Const INS_USER As String = "INS_USER"
            Public Const INS_PGM As String = "INS_PGM"
            Public Const MEMBER_ID As String = "MEMBER_ID"
            Public Const MEMBER_NAME As String = "MEMBER_NAME"
            Public Const DR_NAME_FIRST As String = "DR_NAME_FIRST"
            Public Const DR_NAME_LAST As String = "DR_NAME_LAST"
            Public Const DR_NAME_KANA_FIRST As String = "DR_NAME_KANA_FIRST"
            Public Const DR_NAME_KANA_LAST As String = "DR_NAME_KANA_LAST"
            Public Const DATA_ID As String = "DATA_ID"
            Public Const SHISETSU_NAME As String = "SHISETSU_NAME"
            Public Const SHISETSU_NAME_KANA As String = "SHISETSU_NAME_KANA"
            Public Const DR_MAIL As String = "DR_MAIL"
            Public Const PC_MAIL As String = "PC_MAIL"
            Public Const OFFICE As String = "OFFICE"
            Public Const ZIP As String = "ZIP"
            Public Const ADDRESS As String = "ADDRESS"
            Public Const TEL As String = "TEL"
            Public Const FAX As String = "FAX"
            Public Const DR_NAME As String = "DR_NAME"
            Public Const DR_NAME_KANA As String = "DR_NAME_KANA"
            Public Const MEMBER_NAME_FIRST As String = "MEMBER_NAME_FIRST"
            Public Const MEMBER_NAME_LAST As String = "MEMBER_NAME_LAST"
            Public Const MEMBER_NAME_KANA_FIRST As String = "MEMBER_NAME_KANA_FIRST"
            Public Const MEMBER_NAME_KANA_LAST As String = "MEMBER_NAME_KANA_LAST"
            Public Const MEMBER_NAME_KANA As String = "MEMBER_NAME_KANA"
            Public Const SORT_NO As String = "SORT_NO"
        End Class
        Public Class Name
            Public Const DR_ID As String = "ログインID"
            Public Const DR_PW As String = "パスワード"
            Public Const UPD_DATE As String = ""
            Public Const UPD_USER As String = ""
            Public Const UPD_PGM As String = ""
            Public Const INS_DATE As String = ""
            Public Const INS_USER As String = ""
            Public Const INS_PGM As String = ""
            Public Const MEMBER_ID As String = "担当社員コード"
            Public Const MEMBER_NAME As String = "営業担当者氏名(漢字)"
            Public Const DR_NAME_FIRST As String = "氏名(漢字)・姓"
            Public Const DR_NAME_LAST As String = "氏名(漢字)・名"
            Public Const DR_NAME_KANA_FIRST As String = "氏名(カナ)・姓"
            Public Const DR_NAME_KANA_LAST As String = "氏名(カナ)・名"
            Public Const DATA_ID As String = ""
            Public Const SHISETSU_NAME As String = "施設・病院名称"
            Public Const SHISETSU_NAME_KANA As String = "施設・病院名称(カナ)"
            Public Const DR_MAIL As String = "メールアドレス"
            Public Const PC_MAIL As String = "営業担当メールアドレス"
            Public Const OFFICE As String = "事業所"
            Public Const ZIP As String = ""
            Public Const ADDRESS As String = ""
            Public Const TEL As String = ""
            Public Const FAX As String = ""
            Public Const DR_NAME As String = "氏名(漢字)"
            Public Const DR_NAME_KANA As String = "氏名(カナ)"
            Public Const MEMBER_NAME_FIRST As String = ""
            Public Const MEMBER_NAME_KANA As String = "営業担当者氏名(カナ)"
            Public Const SORT_NO As String = ""
        End Class
    End Class

    Public Class MS_SHISETSU
        <Serializable()> Public Structure DataStruct
            Public DATA_ID As String
            Public MEMBER_ID As String
            Public SHISETSU_NAME As String
            Public SHISETSU_NAME_KANA As String
            Public MEMBER_NAME As String
            Public OFFICE As String
        End Structure
        Public Class Column
            Public Const DATA_ID As String = "DATA_ID"
            Public Const MEMBER_ID As String = "MEMBER_ID"
            Public Const SHISETSU_NAME As String = "SHISETSU_NAME"
            Public Const SHISETSU_NAME_KANA As String = "SHISETSU_NAME_KANA"
            Public Const MEMBER_NAME As String = "MEMBER_NAME"
            Public Const OFFICE As String = "OFFICE"
        End Class
        Public Class Name
            Public Const DATA_ID As String = ""
            Public Const MEMBER_ID As String = "担当社員コード"
            Public Const SHISETSU_NAME As String = "病院・施設名称"
            Public Const SHISETSU_NAME_KANA As String = "病院・施設名称(カナ)"
        End Class
    End Class

    Public Class TBL_ZAIKO
        <Serializable()> Public Structure DataStruct
            Public WETLAB_COURSE As String
            Public ZAIKO_SU As String
            Public TOROKU_SU As String
        End Structure
        Public Class Column
            Public Const WETLAB_COURSE As String = "WETLAB_COURSE"
            Public Const ZAIKO_SU As String = "ZAIKO_SU"
            Public Const TOROKU_SU As String = "TOROKU_SU"
        End Class
        Public Class Name
            Public Const WETLAB_COURSE As String = ""
            Public Const ZAIKO_SU As String = ""
            Public Const TOROKU_SU As String = ""
        End Class
    End Class

    Public Class TBL_SEND_MAIL
        <Serializable()> Public Structure DataStruct
            Public SEND_DATE As String
            Public DATA_NO As String
            Public ADDRESS_TO As String
            Public ADDRESS_CC As String
            Public ADDRESS_BCC As String
            Public ADDRESS_FROM As String
            Public SUBJECT As String
            Public BODY As String
            Public RESULT As String
            Public INS_PGM As String
        End Structure
        Public Class Column
            Public Const SEND_DATE As String = "SEND_DATE"
            Public Const DATA_NO As String = "DATA_NO"
            Public Const ADDRESS_TO As String = "ADDRESS_TO"
            Public Const ADDRESS_CC As String = "ADDRESS_CC"
            Public Const ADDRESS_BCC As String = "ADDRESS_BCC"
            Public Const ADDRESS_FROM As String = "ADDRESS_FROM"
            Public Const SUBJECT As String = "SUBJECT"
            Public Const BODY As String = "BODY"
            Public Const RESULT As String = "RESULT"
            Public Const INS_PGM As String = "INS_PGM"
        End Class
    End Class

End Class
