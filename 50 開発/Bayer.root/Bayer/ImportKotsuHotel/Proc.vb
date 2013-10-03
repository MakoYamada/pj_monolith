Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKotsuHotel" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    'TODO:項目確定次第定義する
    Private Const COL_COUNT As Integer = 188 'ファイルの項目数

    Private Enum COL_NO
        SANKASHA_ID = 0
        KOUENKAI_NO
        REQ_STATUS_TEHAI
        'ANS_STATUS_TEHAI
        TIME_STAMP_BYL
        TIME_STAMP_TOP
        'DR_MPID
        DR_CD
        DR_NAME
        DR_KANA
        DR_SHISETSU_CD
        DR_SHISETSU_NAME
        DR_SHISETSU_ADDRESS
        DR_YAKUWARI
        DR_SEX
        DR_AGE
        SHITEIGAI_RIYU
        'DR_SANKA
        MR_BU
        MR_AREA
        MR_EIGYOSHO
        MR_NAME
        MR_ROMA
        MR_EMAIL_PC
        MR_EMAIL_KEITAI
        MR_KEITAI
        MR_TEL
        MR_SEND_SAKI_FS
        MR_SEND_SAKI_OTHER
        ACCOUNT_CD
        COST_CENTER
        INTERNAL_ORDER
        ZETIA_CD
        SHONIN_NAME
        SHONIN_DATE
        TEHAI_HOTEL
        HOTEL_IRAINAIYOU
        REQ_HOTEL_DATE
        REQ_HAKUSU
        REQ_HOTEL_SMOKING
        REQ_HOTEL_NOTE
        'ANS_STATUS_HOTEL
        'ANS_HOTEL_NAME
        'ANS_HOTEL_ADDRESS
        'ANS_HOTEL_TEL
        'ANS_HOTEL_DATE
        'ANS_HAKUSU
        'ANS_CHECKIN_TIME
        'ANS_CHECKOUT_TIME
        'ANS_ROOM_TYPE
        'ANS_HOTEL_SMOKING
        'ANS_HOTEL_NOTE
        REQ_O_TEHAI_1
        REQ_O_IRAINAIYOU_1
        REQ_O_KOTSUKIKAN_1
        REQ_O_DATE_1
        REQ_O_AIRPORT1_1
        REQ_O_AIRPORT2_1
        REQ_O_TIME1_1
        REQ_O_TIME2_1
        REQ_O_BIN_1
        REQ_O_SEAT_1
        REQ_O_SEAT_KIBOU1
        REQ_O_TEHAI_2
        REQ_O_IRAINAIYOU_2
        REQ_O_KOTSUKIKAN_2
        REQ_O_DATE_2
        REQ_O_AIRPORT1_2
        REQ_O_AIRPORT2_2
        REQ_O_TIME1_2
        REQ_O_TIME2_2
        REQ_O_BIN_2
        REQ_O_SEAT_2
        REQ_O_SEAT_KIBOU2
        REQ_O_TEHAI_3
        REQ_O_IRAINAIYOU_3
        REQ_O_KOTSUKIKAN_3
        REQ_O_DATE_3
        REQ_O_AIRPORT1_3
        REQ_O_AIRPORT2_3
        REQ_O_TIME1_3
        REQ_O_TIME2_3
        REQ_O_BIN_3
        REQ_O_SEAT_3
        REQ_O_SEAT_KIBOU3
        REQ_O_TEHAI_4
        REQ_O_IRAINAIYOU_4
        REQ_O_KOTSUKIKAN_4
        REQ_O_DATE_4
        REQ_O_AIRPORT1_4
        REQ_O_AIRPORT2_4
        REQ_O_TIME1_4
        REQ_O_TIME2_4
        REQ_O_BIN_4
        REQ_O_SEAT_4
        REQ_O_SEAT_KIBOU4
        REQ_O_TEHAI_5
        REQ_O_IRAINAIYOU_5
        REQ_O_KOTSUKIKAN_5
        REQ_O_DATE_5
        REQ_O_AIRPORT1_5
        REQ_O_AIRPORT2_5
        REQ_O_TIME1_5
        REQ_O_TIME2_5
        REQ_O_BIN_5
        REQ_O_SEAT_5
        REQ_O_SEAT_KIBOU5
        REQ_F_TEHAI_1
        REQ_F_IRAINAIYOU_1
        REQ_F_KOTSUKIKAN_1
        REQ_F_DATE_1
        REQ_F_AIRPORT1_1
        REQ_F_AIRPORT2_1
        REQ_F_TIME1_1
        REQ_F_TIME2_1
        REQ_F_BIN_1
        REQ_F_SEAT_1
        REQ_F_SEAT_KIBOU1
        REQ_F_TEHAI_2
        REQ_F_IRAINAIYOU_2
        REQ_F_KOTSUKIKAN_2
        REQ_F_DATE_2
        REQ_F_AIRPORT1_2
        REQ_F_AIRPORT2_2
        REQ_F_TIME1_2
        REQ_F_TIME2_2
        REQ_F_BIN_2
        REQ_F_SEAT_2
        REQ_F_SEAT_KIBOU2
        REQ_F_TEHAI_3
        REQ_F_IRAINAIYOU_3
        REQ_F_KOTSUKIKAN_3
        REQ_F_DATE_3
        REQ_F_AIRPORT1_3
        REQ_F_AIRPORT2_3
        REQ_F_TIME1_3
        REQ_F_TIME2_3
        REQ_F_BIN_3
        REQ_F_SEAT_3
        REQ_F_SEAT_KIBOU3
        REQ_F_TEHAI_4
        REQ_F_IRAINAIYOU_4
        REQ_F_KOTSUKIKAN_4
        REQ_F_DATE_4
        REQ_F_AIRPORT1_4
        REQ_F_AIRPORT2_4
        REQ_F_TIME1_4
        REQ_F_TIME2_4
        REQ_F_BIN_4
        REQ_F_SEAT_4
        REQ_F_SEAT_KIBOU4
        REQ_F_TEHAI_5
        REQ_F_IRAINAIYOU_5
        REQ_F_KOTSUKIKAN_5
        REQ_F_DATE_5
        REQ_F_AIRPORT1_5
        REQ_F_AIRPORT2_5
        REQ_F_TIME1_5
        REQ_F_TIME2_5
        REQ_F_BIN_5
        REQ_F_SEAT_5
        REQ_F_SEAT_KIBOU5
        REQ_KOTSU_BIKO
        'ANS_O_STATUS_1
        'ANS_O_KOTSUKIKAN_1
        'ANS_O_DATE_1
        'ANS_O_AIRPORT1_1
        'ANS_O_AIRPORT2_1
        'ANS_O_TIME1_1
        'ANS_O_TIME2_1
        'ANS_O_BIN_1
        'ANS_O_SEAT_1
        'ANS_O_SEAT_KIBOU1
        'ANS_O_STATUS_2
        'ANS_O_KOTSUKIKAN_2
        'ANS_O_DATE_2
        'ANS_O_AIRPORT1_2
        'ANS_O_AIRPORT2_2
        'ANS_O_TIME1_2
        'ANS_O_TIME2_2
        'ANS_O_BIN_2
        'ANS_O_SEAT_2
        'ANS_O_SEAT_KIBOU2
        'ANS_O_STATUS_3
        'ANS_O_KOTSUKIKAN_3
        'ANS_O_DATE_3
        'ANS_O_AIRPORT1_3
        'ANS_O_AIRPORT2_3
        'ANS_O_TIME1_3
        'ANS_O_TIME2_3
        'ANS_O_BIN_3
        'ANS_O_SEAT_3
        'ANS_O_SEAT_KIBOU3
        'ANS_O_STATUS_4
        'ANS_O_KOTSUKIKAN_4
        'ANS_O_DATE_4
        'ANS_O_AIRPORT1_4
        'ANS_O_AIRPORT2_4
        'ANS_O_TIME1_4
        'ANS_O_TIME2_4
        'ANS_O_BIN_4
        'ANS_O_SEAT_4
        'ANS_O_SEAT_KIBOU4
        'ANS_O_STATUS_5
        'ANS_O_KOTSUKIKAN_5
        'ANS_O_DATE_5
        'ANS_O_AIRPORT1_5
        'ANS_O_AIRPORT2_5
        'ANS_O_TIME1_5
        'ANS_O_TIME2_5
        'ANS_O_BIN_5
        'ANS_O_SEAT_5
        'ANS_O_SEAT_KIBOU5
        'ANS_F_STATUS_1
        'ANS_F_KOTSUKIKAN_1
        'ANS_F_DATE_1
        'ANS_F_AIRPORT1_1
        'ANS_F_AIRPORT2_1
        'ANS_F_TIME1_1
        'ANS_F_TIME2_1
        'ANS_F_BIN_1
        'ANS_F_SEAT_1
        'ANS_F_SEAT_KIBOU1
        'ANS_F_STATUS_2
        'ANS_F_KOTSUKIKAN_2
        'ANS_F_DATE_2
        'ANS_F_AIRPORT1_2
        'ANS_F_AIRPORT2_2
        'ANS_F_TIME1_2
        'ANS_F_TIME2_2
        'ANS_F_BIN_2
        'ANS_F_SEAT_2
        'ANS_F_SEAT_KIBOU2
        'ANS_F_STATUS_3
        'ANS_F_KOTSUKIKAN_3
        'ANS_F_DATE_3
        'ANS_F_AIRPORT1_3
        'ANS_F_AIRPORT2_3
        'ANS_F_TIME1_3
        'ANS_F_TIME2_3
        'ANS_F_BIN_3
        'ANS_F_SEAT_3
        'ANS_F_SEAT_KIBOU3
        'ANS_F_STATUS_4
        'ANS_F_KOTSUKIKAN_4
        'ANS_F_DATE_4
        'ANS_F_AIRPORT1_4
        'ANS_F_AIRPORT2_4
        'ANS_F_TIME1_4
        'ANS_F_TIME2_4
        'ANS_F_BIN_4
        'ANS_F_SEAT_4
        'ANS_F_SEAT_KIBOU4
        'ANS_F_STATUS_5
        'ANS_F_KOTSUKIKAN_5
        'ANS_F_DATE_5
        'ANS_F_AIRPORT1_5
        'ANS_F_AIRPORT2_5
        'ANS_F_TIME1_5
        'ANS_F_TIME2_5
        'ANS_F_BIN_5
        'ANS_F_SEAT_5
        'ANS_F_SEAT_KIBOU5
        'ANS_KOTSU_BIKO
        'ANS_RAIL_FARE
        'ANS_RAIL_CANCELLATION
        'ANS_OTHER_FARE
        'ANS_OTHER_CANCELLATION
        'ANS_AIR_FARE
        'ANS_AIR_CANCELLATION
        TEHAI_TAXI
        REQ_TAXI_DATE_1
        REQ_TAXI_FROM_1
        TAXI_YOTEIKINGAKU_1
        REQ_TAXI_DATE_2
        REQ_TAXI_FROM_2
        TAXI_YOTEIKINGAKU_2
        REQ_TAXI_DATE_3
        REQ_TAXI_FROM_3
        TAXI_YOTEIKINGAKU_3
        REQ_TAXI_DATE_4
        REQ_TAXI_FROM_4
        TAXI_YOTEIKINGAKU_4
        REQ_TAXI_DATE_5
        REQ_TAXI_FROM_5
        TAXI_YOTEIKINGAKU_5
        REQ_TAXI_DATE_6
        REQ_TAXI_FROM_6
        TAXI_YOTEIKINGAKU_6
        REQ_TAXI_DATE_7
        REQ_TAXI_FROM_7
        TAXI_YOTEIKINGAKU_7
        REQ_TAXI_DATE_8
        REQ_TAXI_FROM_8
        TAXI_YOTEIKINGAKU_8
        REQ_TAXI_DATE_9
        REQ_TAXI_FROM_9
        TAXI_YOTEIKINGAKU_9
        REQ_TAXI_DATE_10
        REQ_TAXI_FROM_10
        TAXI_YOTEIKINGAKU_10
        REQ_TAXI_NOTE
        'ANS_TAXI_DATE_1
        'ANS_TAXI_KENSHU_1
        'ANS_TAXI_NO_1
        'ANS_TAXI_DATE_2
        'ANS_TAXI_KENSHU_2
        'ANS_TAXI_NO_2
        'ANS_TAXI_DATE_3
        'ANS_TAXI_KENSHU_3
        'ANS_TAXI_NO_3
        'ANS_TAXI_DATE_4
        'ANS_TAXI_KENSHU_4
        'ANS_TAXI_NO_4
        'ANS_TAXI_DATE_5
        'ANS_TAXI_KENSHU_5
        'ANS_TAXI_NO_5
        'ANS_TAXI_DATE_6
        'ANS_TAXI_KENSHU_6
        'ANS_TAXI_NO_6
        'ANS_TAXI_DATE_7
        'ANS_TAXI_KENSHU_7
        'ANS_TAXI_NO_7
        'ANS_TAXI_DATE_8
        'ANS_TAXI_KENSHU_8
        'ANS_TAXI_NO_8
        'ANS_TAXI_DATE_9
        'ANS_TAXI_KENSHU_9
        'ANS_TAXI_NO_9
        'ANS_TAXI_DATE_10
        'ANS_TAXI_KENSHU_10
        'ANS_TAXI_NO_10
        'ANS_TAXI_DATE_11
        'ANS_TAXI_KENSHU_11
        'ANS_TAXI_NO_11
        'ANS_TAXI_DATE_12
        'ANS_TAXI_KENSHU_12
        'ANS_TAXI_NO_12
        'ANS_TAXI_DATE_13
        'ANS_TAXI_KENSHU_13
        'ANS_TAXI_NO_13
        'ANS_TAXI_DATE_14
        'ANS_TAXI_KENSHU_14
        'ANS_TAXI_NO_14
        'ANS_TAXI_DATE_15
        'ANS_TAXI_KENSHU_15
        'ANS_TAXI_NO_15
        'ANS_TAXI_DATE_16
        'ANS_TAXI_KENSHU_16
        'ANS_TAXI_NO_16
        'ANS_TAXI_DATE_17
        'ANS_TAXI_KENSHU_17
        'ANS_TAXI_NO_17
        'ANS_TAXI_DATE_18
        'ANS_TAXI_KENSHU_18
        'ANS_TAXI_NO_18
        'ANS_TAXI_DATE_19
        'ANS_TAXI_KENSHU_19
        'ANS_TAXI_NO_19
        'ANS_TAXI_DATE_20
        'ANS_TAXI_KENSHU_20
        'ANS_TAXI_NO_20
        'ANS_TAXI_NOTE
        REQ_MR_O_TEHAI
        REQ_MR_F_TEHAI
        MR_SEX
        MR_AGE
        REQ_MR_TEHAI_HOTEL
        REQ_MR_HOTEL_SMOKING
        REQ_MR_HOTEL_NOTE
        'ANS_MR_O_TEHAI
        'ANS_MR_F_TEHAI
        'ANS_MR_HOTEL_NAME
        'ANS_MR_HOTEL_ADDRESS
        'ANS_MR_HOTEL_TEL
        'ANS_MR_CHECKIN_TIME
        'ANS_MR_CHECKOUT_TIME
        'ANS_MR_HOTEL_SMOKING
        'ANS_MR_HOTEL_NOTE
        'ANS_MR_KOTSUHI
        'ANS_MR_HOTELHI
    End Enum

    Private Class COL_NAME
        Public Const SANKASHA_ID As String = "参加者ID"
        Public Const KOUENKAI_NO As String = "講演会番号"
        Public Const REQ_STATUS_TEHAI As String = "手配スタータス（依頼）"
        'Public Const ANS_STATUS_TEHAI As String = "手配スタータス（回答）"
        Public Const TIME_STAMP_BYL As String = "Timestamp（BYL)"
        Public Const TIME_STAMP_TOP As String = "Timestamp（TOP)"
        'Public Const DR_MPID As String = "MPID"
        Public Const DR_CD As String = "DRコード"
        Public Const DR_NAME As String = "DR氏名"
        Public Const DR_KANA As String = "DR氏名（半角カタカナ）"
        Public Const DR_SHISETSU_CD As String = "DCF施設コード"
        Public Const DR_SHISETSU_NAME As String = "施設名"
        Public Const DR_SHISETSU_ADDRESS As String = "施設住所"
        Public Const DR_YAKUWARI As String = "参加者役割"
        Public Const DR_SEX As String = "DR性別"
        Public Const DR_AGE As String = "航空搭乗者年齢（年齢）"
        Public Const SHITEIGAI_RIYU As String = "指定外申請理由（依頼）"
        'Public Const DR_SANKA As String = "参加／不参加"
        Public Const MR_BU As String = "BU（担当MR）"
        Public Const MR_AREA As String = "所属エリア（担当MR）"
        Public Const MR_EIGYOSHO As String = "所属営業所（担当MR）"
        Public Const MR_NAME As String = "担当者（担当MR）名"
        Public Const MR_ROMA As String = "担当者名（担当MR）（ローマ字）"
        Public Const MR_EMAIL_PC As String = "Emailアドレス（担当MR）"
        Public Const MR_EMAIL_KEITAI As String = "携帯Emailアドレス（担当MR）"
        Public Const MR_KEITAI As String = "携帯電話番号（担当MR）"
        Public Const MR_TEL As String = "オフィスの電話番号（担当MR）"
        Public Const MR_SEND_SAKI_FS As String = "チケット送付先FS"
        Public Const MR_SEND_SAKI_OTHER As String = "チケット送付先（その他）"
        Public Const ACCOUNT_CD As String = "Account Code"
        Public Const COST_CENTER As String = "Cost Center"
        Public Const INTERNAL_ORDER As String = "Internal Order"
        Public Const ZETIA_CD As String = "zetia Code"
        Public Const SHONIN_NAME As String = "最終承認者（氏名）"
        Public Const SHONIN_DATE As String = "最終承認日時"
        Public Const TEHAI_HOTEL As String = "宿泊手配（希望する）"
        Public Const HOTEL_IRAINAIYOU As String = "宿泊依頼内容"
        Public Const REQ_HOTEL_DATE As String = "宿泊日（依頼）"
        Public Const REQ_HAKUSU As String = "泊数（依頼）"
        Public Const REQ_HOTEL_SMOKING As String = "宿泊ホテル喫煙（依頼）"
        Public Const REQ_HOTEL_NOTE As String = "宿泊備考（依頼）"
        'Public Const ANS_STATUS_HOTEL As String = "宿泊ステータス（回答）"
        'Public Const ANS_HOTEL_NAME As String = "宿泊先（回答）"
        'Public Const ANS_HOTEL_ADDRESS As String = "宿泊先住所（回答）"
        'Public Const ANS_HOTEL_TEL As String = "宿泊先電話番号（回答）"
        'Public Const ANS_HOTEL_DATE As String = "宿泊日（回答）"
        'Public Const ANS_HAKUSU As String = "泊数（回答）"
        'Public Const ANS_CHECKIN_TIME As String = "宿泊先チェックイン時間（回答）"
        'Public Const ANS_CHECKOUT_TIME As String = "宿泊先チェックアウト時間（回答）"
        'Public Const ANS_ROOM_TYPE As String = "宿泊部屋タイプ（回答）"
        'Public Const ANS_HOTEL_SMOKING As String = "宿泊ホテル喫煙（回答）"
        'Public Const ANS_HOTEL_NOTE As String = "宿泊備考（回答）"
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
        Public Const REQ_O_SEAT_KIBOU1 As String = "往路１：座席希望（依頼）"
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
        Public Const REQ_O_SEAT_KIBOU2 As String = "往路２：座席希望（依頼）"
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
        Public Const REQ_O_SEAT_KIBOU3 As String = "往路３：座席希望（依頼）"
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
        Public Const REQ_O_SEAT_KIBOU4 As String = "往路４：座席希望（依頼）"
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
        Public Const REQ_O_SEAT_KIBOU5 As String = "往路５：座席希望（依頼）"
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
        Public Const REQ_F_SEAT_KIBOU1 As String = "復路１：座席希望（依頼）"
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
        Public Const REQ_F_SEAT_KIBOU2 As String = "復路２：座席希望（依頼）"
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
        Public Const REQ_F_SEAT_KIBOU3 As String = "復路３：座席希望（依頼）"
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
        Public Const REQ_F_SEAT_KIBOU4 As String = "復路４：座席希望（依頼）"
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
        Public Const REQ_F_SEAT_KIBOU5 As String = "復路５：座席希望（依頼）"
        Public Const REQ_KOTSU_BIKO As String = "交通備考（依頼）"
        'Public Const ANS_O_STATUS_1 As String = "往路１：ステータス（回答）"
        'Public Const ANS_O_KOTSUKIKAN_1 As String = "往路１：交通機関（回答）"
        'Public Const ANS_O_DATE_1 As String = "往路１：利用日（回答）"
        'Public Const ANS_O_AIRPORT1_1 As String = "往路１：出発地（回答）"
        'Public Const ANS_O_AIRPORT2_1 As String = "往路１：到着地（回答）"
        'Public Const ANS_O_TIME1_1 As String = "往路１：出発時間（回答）"
        'Public Const ANS_O_TIME2_1 As String = "往路１：到着時間（回答）"
        'Public Const ANS_O_BIN_1 As String = "往路１：列車名・便名（回答）"
        'Public Const ANS_O_SEAT_1 As String = "往路１：座席区分（回答）"
        'Public Const ANS_O_SEAT_KIBOU1 As String = "往路１：座席希望（回答）"
        'Public Const ANS_O_STATUS_2 As String = "往路２：ステータス（回答）"
        'Public Const ANS_O_KOTSUKIKAN_2 As String = "往路２：交通機関（回答）"
        'Public Const ANS_O_DATE_2 As String = "往路２：利用日（回答）"
        'Public Const ANS_O_AIRPORT1_2 As String = "往路２：出発地（回答）"
        'Public Const ANS_O_AIRPORT2_2 As String = "往路２：到着地（回答）"
        'Public Const ANS_O_TIME1_2 As String = "往路２：出発時間（回答）"
        'Public Const ANS_O_TIME2_2 As String = "往路２：到着時間（回答）"
        'Public Const ANS_O_BIN_2 As String = "往路２：列車名・便名（回答）"
        'Public Const ANS_O_SEAT_2 As String = "往路２：座席区分（回答）"
        'Public Const ANS_O_SEAT_KIBOU2 As String = "往路２：座席希望（回答）"
        'Public Const ANS_O_STATUS_3 As String = "往路３：ステータス（回答）"
        'Public Const ANS_O_KOTSUKIKAN_3 As String = "往路３：交通機関（回答）"
        'Public Const ANS_O_DATE_3 As String = "往路３：利用日（回答）"
        'Public Const ANS_O_AIRPORT1_3 As String = "往路３：出発地（回答）"
        'Public Const ANS_O_AIRPORT2_3 As String = "往路３：到着地（回答）"
        'Public Const ANS_O_TIME1_3 As String = "往路３：出発時間（回答）"
        'Public Const ANS_O_TIME2_3 As String = "往路３：到着時間（回答）"
        'Public Const ANS_O_BIN_3 As String = "往路３：列車名・便名（回答）"
        'Public Const ANS_O_SEAT_3 As String = "往路３：座席区分（回答）"
        'Public Const ANS_O_SEAT_KIBOU3 As String = "往路３：座席希望（回答）"
        'Public Const ANS_O_STATUS_4 As String = "往路４：ステータス（回答）"
        'Public Const ANS_O_KOTSUKIKAN_4 As String = "往路４：交通機関（回答）"
        'Public Const ANS_O_DATE_4 As String = "往路４：利用日（回答）"
        'Public Const ANS_O_AIRPORT1_4 As String = "往路４：出発地（回答）"
        'Public Const ANS_O_AIRPORT2_4 As String = "往路４：到着地（回答）"
        'Public Const ANS_O_TIME1_4 As String = "往路４：出発時間（回答）"
        'Public Const ANS_O_TIME2_4 As String = "往路４：到着時間（回答）"
        'Public Const ANS_O_BIN_4 As String = "往路４：列車名・便名（回答）"
        'Public Const ANS_O_SEAT_4 As String = "往路４：座席区分（回答）"
        'Public Const ANS_O_SEAT_KIBOU4 As String = "往路４：座席希望（回答）"
        'Public Const ANS_O_STATUS_5 As String = "往路５：ステータス（回答）"
        'Public Const ANS_O_KOTSUKIKAN_5 As String = "往路５：交通機関（回答）"
        'Public Const ANS_O_DATE_5 As String = "往路５：利用日（回答）"
        'Public Const ANS_O_AIRPORT1_5 As String = "往路５：出発地（回答）"
        'Public Const ANS_O_AIRPORT2_5 As String = "往路５：到着地（回答）"
        'Public Const ANS_O_TIME1_5 As String = "往路５：出発時間（回答）"
        'Public Const ANS_O_TIME2_5 As String = "往路５：到着時間（回答）"
        'Public Const ANS_O_BIN_5 As String = "往路５：列車名・便名（回答）"
        'Public Const ANS_O_SEAT_5 As String = "往路５：座席区分（回答）"
        'Public Const ANS_O_SEAT_KIBOU5 As String = "往路５：座席希望（回答）"
        'Public Const ANS_F_STATUS_1 As String = "復路１：ステータス（回答）"
        'Public Const ANS_F_KOTSUKIKAN_1 As String = "復路１：交通機関（回答）"
        'Public Const ANS_F_DATE_1 As String = "復路１：利用日（回答）"
        'Public Const ANS_F_AIRPORT1_1 As String = "復路１：出発地（回答）"
        'Public Const ANS_F_AIRPORT2_1 As String = "復路１：到着地（回答）"
        'Public Const ANS_F_TIME1_1 As String = "復路１：出発時間（回答）"
        'Public Const ANS_F_TIME2_1 As String = "復路１：到着時間（回答）"
        'Public Const ANS_F_BIN_1 As String = "復路１：列車名・便名（回答）"
        'Public Const ANS_F_SEAT_1 As String = "復路１：座席区分（回答）"
        'Public Const ANS_F_SEAT_KIBOU1 As String = "復路１：座席希望（回答）"
        'Public Const ANS_F_STATUS_2 As String = "復路２：ステータス（回答）"
        'Public Const ANS_F_KOTSUKIKAN_2 As String = "復路２：交通機関（回答）"
        'Public Const ANS_F_DATE_2 As String = "復路２：利用日（回答）"
        'Public Const ANS_F_AIRPORT1_2 As String = "復路２：出発地（回答）"
        'Public Const ANS_F_AIRPORT2_2 As String = "復路２：到着地（回答）"
        'Public Const ANS_F_TIME1_2 As String = "復路２：出発時間（回答）"
        'Public Const ANS_F_TIME2_2 As String = "復路２：到着時間（回答）"
        'Public Const ANS_F_BIN_2 As String = "復路２：列車名・便名（回答）"
        'Public Const ANS_F_SEAT_2 As String = "復路２：座席区分（回答）"
        'Public Const ANS_F_SEAT_KIBOU2 As String = "復路２：座席希望（回答）"
        'Public Const ANS_F_STATUS_3 As String = "復路３：ステータス（回答）"
        'Public Const ANS_F_KOTSUKIKAN_3 As String = "復路３：交通機関（回答）"
        'Public Const ANS_F_DATE_3 As String = "復路３：利用日（回答）"
        'Public Const ANS_F_AIRPORT1_3 As String = "復路３：出発地（回答）"
        'Public Const ANS_F_AIRPORT2_3 As String = "復路３：到着地（回答）"
        'Public Const ANS_F_TIME1_3 As String = "復路３：出発時間（回答）"
        'Public Const ANS_F_TIME2_3 As String = "復路３：到着時間（回答）"
        'Public Const ANS_F_BIN_3 As String = "復路３：列車名・便名（回答）"
        'Public Const ANS_F_SEAT_3 As String = "復路３：座席区分（回答）"
        'Public Const ANS_F_SEAT_KIBOU3 As String = "復路３：座席希望（回答）"
        'Public Const ANS_F_STATUS_4 As String = "復路４：ステータス（回答）"
        'Public Const ANS_F_KOTSUKIKAN_4 As String = "復路４：交通機関（回答）"
        'Public Const ANS_F_DATE_4 As String = "復路４：利用日（回答）"
        'Public Const ANS_F_AIRPORT1_4 As String = "復路４：出発地（回答）"
        'Public Const ANS_F_AIRPORT2_4 As String = "復路４：到着地（回答）"
        'Public Const ANS_F_TIME1_4 As String = "復路４：出発時間（回答）"
        'Public Const ANS_F_TIME2_4 As String = "復路４：到着時間（回答）"
        'Public Const ANS_F_BIN_4 As String = "復路４：列車名・便名（回答）"
        'Public Const ANS_F_SEAT_4 As String = "復路４：座席区分（回答）"
        'Public Const ANS_F_SEAT_KIBOU4 As String = "復路４：座席希望（回答）"
        'Public Const ANS_F_STATUS_5 As String = "復路５：ステータス（回答）"
        'Public Const ANS_F_KOTSUKIKAN_5 As String = "復路５：交通機関（回答）"
        'Public Const ANS_F_DATE_5 As String = "復路５：利用日（回答）"
        'Public Const ANS_F_AIRPORT1_5 As String = "復路５：出発地（回答）"
        'Public Const ANS_F_AIRPORT2_5 As String = "復路５：到着地（回答）"
        'Public Const ANS_F_TIME1_5 As String = "復路５：出発時間（回答）"
        'Public Const ANS_F_TIME2_5 As String = "復路５：到着時間（回答）"
        'Public Const ANS_F_BIN_5 As String = "復路５：列車名・便名（回答）"
        'Public Const ANS_F_SEAT_5 As String = "復路５：座席区分（回答）"
        'Public Const ANS_F_SEAT_KIBOU5 As String = "復路５：座席希望（回答）"
        'Public Const ANS_KOTSU_BIKO As String = "交通備考（回答）"
        'Public Const ANS_RAIL_FARE As String = "【回答】JR・鉄道代金"
        'Public Const ANS_RAIL_CANCELLATION As String = "【回答】JR・鉄道取消料"
        'Public Const ANS_OTHER_FARE As String = "【回答】その他鉄道等代金"
        'Public Const ANS_OTHER_CANCELLATION As String = "【回答】その他鉄道等取消料"
        'Public Const ANS_AIR_FARE As String = "【回答】航空券代金"
        'Public Const ANS_AIR_CANCELLATION As String = "【回答】航空券取消料"
        Public Const TEHAI_TAXI As String = "タクシーチケット（有・無）"
        Public Const REQ_TAXI_DATE_1 As String = "行程１：利用日（依頼）"
        Public Const REQ_TAXI_FROM_1 As String = "行程１：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_1 As String = "行程１：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_2 As String = "行程２：利用日（依頼）"
        Public Const REQ_TAXI_FROM_2 As String = "行程２：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_2 As String = "行程２：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_3 As String = "行程３：利用日（依頼）"
        Public Const REQ_TAXI_FROM_3 As String = "行程３：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_3 As String = "行程３：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_4 As String = "行程４：利用日（依頼）"
        Public Const REQ_TAXI_FROM_4 As String = "行程４：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_4 As String = "行程４：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_5 As String = "行程５：利用日（依頼）"
        Public Const REQ_TAXI_FROM_5 As String = "行程５：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_5 As String = "行程５：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_6 As String = "行程６：利用日（依頼）"
        Public Const REQ_TAXI_FROM_6 As String = "行程６：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_6 As String = "行程６：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_7 As String = "行程７：利用日（依頼）"
        Public Const REQ_TAXI_FROM_7 As String = "行程７：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_7 As String = "行程７：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_8 As String = "行程８：利用日（依頼）"
        Public Const REQ_TAXI_FROM_8 As String = "行程８：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_8 As String = "行程８：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_9 As String = "行程９：利用日（依頼）"
        Public Const REQ_TAXI_FROM_9 As String = "行程９：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_9 As String = "行程９：依頼金額（依頼）"
        Public Const REQ_TAXI_DATE_10 As String = "行程１０：利用日（依頼）"
        Public Const REQ_TAXI_FROM_10 As String = "行程１０：発地（依頼）"
        Public Const TAXI_YOTEIKINGAKU_10 As String = "行程１０：依頼金額（依頼）"
        Public Const REQ_TAXI_NOTE As String = "タクシーチケット：備考（依頼）"
        'Public Const ANS_TAXI_DATE_1 As String = "タクシーチケット１：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_1 As String = "タクシーチケット１：券種（回答）"
        'Public Const ANS_TAXI_NO_1 As String = "タクシーチケット１：番号（回答）"
        'Public Const ANS_TAXI_DATE_2 As String = "タクシーチケット２：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_2 As String = "タクシーチケット２：券種（回答）"
        'Public Const ANS_TAXI_NO_2 As String = "タクシーチケット２：番号（回答）"
        'Public Const ANS_TAXI_DATE_3 As String = "タクシーチケット３：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_3 As String = "タクシーチケット３：券種（回答）"
        'Public Const ANS_TAXI_NO_3 As String = "タクシーチケット３：番号（回答）"
        'Public Const ANS_TAXI_DATE_4 As String = "タクシーチケット４：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_4 As String = "タクシーチケット４：券種（回答）"
        'Public Const ANS_TAXI_NO_4 As String = "タクシーチケット４：番号（回答）"
        'Public Const ANS_TAXI_DATE_5 As String = "タクシーチケット５：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_5 As String = "タクシーチケット５：券種（回答）"
        'Public Const ANS_TAXI_NO_5 As String = "タクシーチケット５：番号（回答）"
        'Public Const ANS_TAXI_DATE_6 As String = "タクシーチケット６：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_6 As String = "タクシーチケット６：券種（回答）"
        'Public Const ANS_TAXI_NO_6 As String = "タクシーチケット６：番号（回答）"
        'Public Const ANS_TAXI_DATE_7 As String = "タクシーチケット７：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_7 As String = "タクシーチケット７：券種（回答）"
        'Public Const ANS_TAXI_NO_7 As String = "タクシーチケット７：番号（回答）"
        'Public Const ANS_TAXI_DATE_8 As String = "タクシーチケット８：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_8 As String = "タクシーチケット８：券種（回答）"
        'Public Const ANS_TAXI_NO_8 As String = "タクシーチケット８：番号（回答）"
        'Public Const ANS_TAXI_DATE_9 As String = "タクシーチケット９：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_9 As String = "タクシーチケット９：券種（回答）"
        'Public Const ANS_TAXI_NO_9 As String = "タクシーチケット９：番号（回答）"
        'Public Const ANS_TAXI_DATE_10 As String = "タクシーチケット１０：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_10 As String = "タクシーチケット１０：券種（回答）"
        'Public Const ANS_TAXI_NO_10 As String = "タクシーチケット１０：番号（回答）"
        'Public Const ANS_TAXI_DATE_11 As String = "タクシーチケット１１：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_11 As String = "タクシーチケット１１：券種（回答）"
        'Public Const ANS_TAXI_NO_11 As String = "タクシーチケット１１：番号（回答）"
        'Public Const ANS_TAXI_DATE_12 As String = "タクシーチケット１２：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_12 As String = "タクシーチケット１２：券種（回答）"
        'Public Const ANS_TAXI_NO_12 As String = "タクシーチケット１２：番号（回答）"
        'Public Const ANS_TAXI_DATE_13 As String = "タクシーチケット１３：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_13 As String = "タクシーチケット１３：券種（回答）"
        'Public Const ANS_TAXI_NO_13 As String = "タクシーチケット１３：番号（回答）"
        'Public Const ANS_TAXI_DATE_14 As String = "タクシーチケット１４：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_14 As String = "タクシーチケット１４：券種（回答）"
        'Public Const ANS_TAXI_NO_14 As String = "タクシーチケット１４：番号（回答）"
        'Public Const ANS_TAXI_DATE_15 As String = "タクシーチケット１５：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_15 As String = "タクシーチケット１５：券種（回答）"
        'Public Const ANS_TAXI_NO_15 As String = "タクシーチケット１５：番号（回答）"
        'Public Const ANS_TAXI_DATE_16 As String = "タクシーチケット１６：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_16 As String = "タクシーチケット１６：券種（回答）"
        'Public Const ANS_TAXI_NO_16 As String = "タクシーチケット１６：番号（回答）"
        'Public Const ANS_TAXI_DATE_17 As String = "タクシーチケット１７：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_17 As String = "タクシーチケット１７：券種（回答）"
        'Public Const ANS_TAXI_NO_17 As String = "タクシーチケット１７：番号（回答）"
        'Public Const ANS_TAXI_DATE_18 As String = "タクシーチケット１８：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_18 As String = "タクシーチケット１８：券種（回答）"
        'Public Const ANS_TAXI_NO_18 As String = "タクシーチケット１８：番号（回答）"
        'Public Const ANS_TAXI_DATE_19 As String = "タクシーチケット１９：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_19 As String = "タクシーチケット１９：券種（回答）"
        'Public Const ANS_TAXI_NO_19 As String = "タクシーチケット１９：番号（回答）"
        'Public Const ANS_TAXI_DATE_20 As String = "タクシーチケット２０：利用日（回答）"
        'Public Const ANS_TAXI_KENSHU_20 As String = "タクシーチケット２０：券種（回答）"
        'Public Const ANS_TAXI_NO_20 As String = "タクシーチケット２０：番号（回答）"
        'Public Const ANS_TAXI_NOTE As String = "タクシーチケット：備考（回答）"
        Public Const REQ_MR_O_TEHAI As String = "社員用往路臨席希望（依頼）"
        Public Const REQ_MR_F_TEHAI As String = "社員用復路臨席希望（依頼）"
        Public Const MR_SEX As String = "MR性別（航空券の場合）"
        Public Const MR_AGE As String = "MR年齢（航空券の場合）"
        Public Const REQ_MR_TEHAI_HOTEL As String = "社員用宿泊希望（有・無）"
        Public Const REQ_MR_HOTEL_SMOKING As String = "社員用宿泊　（禁煙・喫煙）"
        Public Const REQ_MR_HOTEL_NOTE As String = "社員用交通・宿泊備考"
        'Public Const ANS_MR_O_TEHAI As String = "社員用往路手配（回答）"
        'Public Const ANS_MR_F_TEHAI As String = "社員用復路手配（回答）"
        'Public Const ANS_MR_HOTEL_NAME As String = "社員用宿泊ホテル名（回答）"
        'Public Const ANS_MR_HOTEL_ADDRESS As String = "社員用ホテル住所（回答）"
        'Public Const ANS_MR_HOTEL_TEL As String = "社員用ホテルＴＥＬ（回答）"
        'Public Const ANS_MR_CHECKIN_TIME As String = "社員用ホテルチェックイン時間（回答）"
        'Public Const ANS_MR_CHECKOUT_TIME As String = "社員用ホテルチェックアウト時間（回答）"
        'Public Const ANS_MR_HOTEL_SMOKING As String = "社員用宿泊（禁煙・喫煙）(回答)"
        'Public Const ANS_MR_HOTEL_NOTE As String = "社員用交通・宿泊備考（回答）"
        'Public Const ANS_MR_KOTSUHI As String = "【回答】MR　交通費"
        'Public Const ANS_MR_HOTELHI As String = "【回答】MR　宿泊費"
    End Class
#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        Dim receiveFiles() As String = Directory.GetFiles(My.Settings.PATH_RECEIVE)

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        If Not Directory.Exists(My.Settings.PATH_RECEIVE_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_RECEIVE_BKUP)

        '受信フォルダ→作業フォルダへコピー
        '受信フォルダからファイルを削除
        For Each motofile As String In receiveFiles
            If motofile.ToLower.IndexOf(My.Settings.FILE_NAME.ToLower) >= 0 Then
                File.Copy(motofile, My.Settings.PATH_WORK & "\" & Path.GetFileName(motofile))
                File.Delete(motofile)
            End If
        Next

        Dim workFiles() As String = Directory.GetFiles(My.Settings.PATH_WORK)
        If workFiles.Length = 0 Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象ファイルがありません。")
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント
        For Each filePath As String In workFiles
            ImportData(filePath, insCnt)
        Next

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, insCnt.ToString & "件のデータを登録しました。")

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        For Each filePath As String In workFiles
            File.Copy(filePath, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileName(filePath))
            File.Delete(filePath)
        Next

    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("UTF-8"))
        Else
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, strFilePath & "が見つかりません。")
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        Dim strNgMoji As String = My.Settings.NG_MOJI
        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            If CheckInput(fileData, strFileName, rowCnt.ToString, strNgMoji) Then
                insCnt += InsertTable(fileData)
            End If

        End While

        'インスタンス開放
        parser.Dispose()

    End Function

    '入力チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, _
                                ByVal strNGMoji As String) As Boolean

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                Throw New Exception("項目数が不正です。")
            End If

            '必須入力チェック
            If fileData(COL_NO.SANKASHA_ID).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.SANKASHA_ID & "がセットされていません。")
            End If

            If fileData(COL_NO.KOUENKAI_NO).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.KOUENKAI_NO & "がセットされていません。")
            End If

            If fileData(COL_NO.TIME_STAMP_BYL).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.TIME_STAMP_BYL & "がセットされていません。")
            End If

            '禁則文字チェック
            If Not strNGMoji.Equals(String.Empty) Then
                Dim chkMoji() As String = strNGMoji.Split(",")
                For Each colData As String In fileData
                    For Each moji As String In chkMoji
                        If colData.Contains(moji) Then
                            Throw New Exception("禁則文字[" & moji & "]が含まれています。")
                        End If
                    Next
                Next
            End If

        Catch ex As Exception
            Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, strErrMsg)
            Return False
        End Try

        Return True

    End Function

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "交通宿泊手配依頼ファイル取込"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

    'データ登録
    Private Function InsertTable(ByVal fileData As String()) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct

        Try
            TBL_KOTSUHOTEL = SetInsData(fileData)
            strSQL = SQL.TBL_KOTSUHOTEL.Insert(TBL_KOTSUHOTEL)
            insCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

        Catch ex As Exception
            'ログテーブルに登録
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_KOTSUHOTEL", " SQL:" & strSQL)
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_KOTSUHOTEL.DataStruct

        Dim TBL_KOTSUHOTEL_Ins As New TableDef.TBL_KOTSUHOTEL.DataStruct

        'TODO:ダブルクォート囲みのとき、またダブルクォートのエスケープの仕様が確定したら処理追加

        'TODO:ファイル項目が確定次第セットする値を修正する

        TBL_KOTSUHOTEL_Ins.SANKASHA_ID = fileData(COL_NO.SANKASHA_ID)
        TBL_KOTSUHOTEL_Ins.KOUENKAI_NO = fileData(COL_NO.KOUENKAI_NO)
        TBL_KOTSUHOTEL_Ins.REQ_STATUS_TEHAI = fileData(COL_NO.REQ_STATUS_TEHAI)
        'TODO:要確認
        TBL_KOTSUHOTEL_Ins.ANS_STATUS_TEHAI = "1"
        TBL_KOTSUHOTEL_Ins.TIME_STAMP_BYL = fileData(COL_NO.TIME_STAMP_BYL)
        TBL_KOTSUHOTEL_Ins.TIME_STAMP_TOP = fileData(COL_NO.TIME_STAMP_TOP)
        TBL_KOTSUHOTEL_Ins.DR_MPID = fileData(COL_NO.SANKASHA_ID)
        TBL_KOTSUHOTEL_Ins.DR_CD = fileData(COL_NO.DR_CD)
        TBL_KOTSUHOTEL_Ins.DR_NAME = fileData(COL_NO.DR_NAME)
        TBL_KOTSUHOTEL_Ins.DR_KANA = fileData(COL_NO.DR_KANA)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_CD = fileData(COL_NO.DR_SHISETSU_CD)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_NAME = fileData(COL_NO.DR_SHISETSU_NAME)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_ADDRESS = fileData(COL_NO.DR_SHISETSU_ADDRESS)
        TBL_KOTSUHOTEL_Ins.DR_YAKUWARI = fileData(COL_NO.DR_YAKUWARI)
        TBL_KOTSUHOTEL_Ins.DR_SEX = fileData(COL_NO.DR_SEX)
        TBL_KOTSUHOTEL_Ins.DR_AGE = fileData(COL_NO.DR_AGE)
        TBL_KOTSUHOTEL_Ins.SHITEIGAI_RIYU = fileData(COL_NO.SHITEIGAI_RIYU)
        TBL_KOTSUHOTEL_Ins.DR_SANKA = ""
        TBL_KOTSUHOTEL_Ins.MR_BU = fileData(COL_NO.MR_BU)
        TBL_KOTSUHOTEL_Ins.MR_AREA = fileData(COL_NO.MR_AREA)
        TBL_KOTSUHOTEL_Ins.MR_EIGYOSHO = fileData(COL_NO.MR_EIGYOSHO)
        TBL_KOTSUHOTEL_Ins.MR_NAME = fileData(COL_NO.MR_NAME)
        TBL_KOTSUHOTEL_Ins.MR_ROMA = fileData(COL_NO.MR_ROMA)
        TBL_KOTSUHOTEL_Ins.MR_EMAIL_PC = fileData(COL_NO.MR_EMAIL_PC)
        TBL_KOTSUHOTEL_Ins.MR_EMAIL_KEITAI = fileData(COL_NO.MR_EMAIL_KEITAI)
        TBL_KOTSUHOTEL_Ins.MR_KEITAI = fileData(COL_NO.MR_KEITAI)
        TBL_KOTSUHOTEL_Ins.MR_TEL = fileData(COL_NO.MR_TEL)
        TBL_KOTSUHOTEL_Ins.MR_SEND_SAKI_FS = fileData(COL_NO.MR_SEND_SAKI_FS)
        TBL_KOTSUHOTEL_Ins.MR_SEND_SAKI_OTHER = fileData(COL_NO.MR_SEND_SAKI_OTHER)
        TBL_KOTSUHOTEL_Ins.ACCOUNT_CD = fileData(COL_NO.ACCOUNT_CD)
        TBL_KOTSUHOTEL_Ins.COST_CENTER = fileData(COL_NO.COST_CENTER)
        TBL_KOTSUHOTEL_Ins.INTERNAL_ORDER = fileData(COL_NO.INTERNAL_ORDER)
        TBL_KOTSUHOTEL_Ins.ZETIA_CD = fileData(COL_NO.ZETIA_CD)
        TBL_KOTSUHOTEL_Ins.SHONIN_NAME = fileData(COL_NO.SHONIN_NAME)
        TBL_KOTSUHOTEL_Ins.SHONIN_DATE = fileData(COL_NO.SHONIN_DATE)
        TBL_KOTSUHOTEL_Ins.TEHAI_HOTEL = fileData(COL_NO.TEHAI_HOTEL)
        TBL_KOTSUHOTEL_Ins.HOTEL_IRAINAIYOU = fileData(COL_NO.HOTEL_IRAINAIYOU)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_DATE = fileData(COL_NO.REQ_HOTEL_DATE)
        TBL_KOTSUHOTEL_Ins.REQ_HAKUSU = fileData(COL_NO.REQ_HAKUSU)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_SMOKING = fileData(COL_NO.REQ_HOTEL_SMOKING)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_NOTE = fileData(COL_NO.REQ_HOTEL_NOTE)
        TBL_KOTSUHOTEL_Ins.ANS_STATUS_HOTEL = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NAME = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_ADDRESS = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_TEL = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_DATE = ""
        TBL_KOTSUHOTEL_Ins.ANS_HAKUSU = ""
        TBL_KOTSUHOTEL_Ins.ANS_CHECKIN_TIME = ""
        TBL_KOTSUHOTEL_Ins.ANS_CHECKOUT_TIME = ""
        TBL_KOTSUHOTEL_Ins.ANS_ROOM_TYPE = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_SMOKING = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NOTE = ""
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_1 = fileData(COL_NO.REQ_O_TEHAI_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_1 = fileData(COL_NO.REQ_O_IRAINAIYOU_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_1 = fileData(COL_NO.REQ_O_KOTSUKIKAN_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_1 = fileData(COL_NO.REQ_O_DATE_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_1 = fileData(COL_NO.REQ_O_AIRPORT1_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_1 = fileData(COL_NO.REQ_O_AIRPORT2_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_1 = fileData(COL_NO.REQ_O_TIME1_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_1 = fileData(COL_NO.REQ_O_TIME2_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_1 = fileData(COL_NO.REQ_O_BIN_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_1 = fileData(COL_NO.REQ_O_SEAT_1)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU1 = fileData(COL_NO.REQ_O_SEAT_KIBOU1)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_2 = fileData(COL_NO.REQ_O_TEHAI_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_2 = fileData(COL_NO.REQ_O_IRAINAIYOU_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_2 = fileData(COL_NO.REQ_O_KOTSUKIKAN_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_2 = fileData(COL_NO.REQ_O_DATE_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_2 = fileData(COL_NO.REQ_O_AIRPORT1_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_2 = fileData(COL_NO.REQ_O_AIRPORT2_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_2 = fileData(COL_NO.REQ_O_TIME1_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_2 = fileData(COL_NO.REQ_O_TIME2_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_2 = fileData(COL_NO.REQ_O_BIN_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_2 = fileData(COL_NO.REQ_O_SEAT_2)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU2 = fileData(COL_NO.REQ_O_SEAT_KIBOU2)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_3 = fileData(COL_NO.REQ_O_TEHAI_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_3 = fileData(COL_NO.REQ_O_IRAINAIYOU_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_3 = fileData(COL_NO.REQ_O_KOTSUKIKAN_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_3 = fileData(COL_NO.REQ_O_DATE_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_3 = fileData(COL_NO.REQ_O_AIRPORT1_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_3 = fileData(COL_NO.REQ_O_AIRPORT2_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_3 = fileData(COL_NO.REQ_O_TIME1_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_3 = fileData(COL_NO.REQ_O_TIME2_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_3 = fileData(COL_NO.REQ_O_BIN_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_3 = fileData(COL_NO.REQ_O_SEAT_3)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU3 = fileData(COL_NO.REQ_O_SEAT_KIBOU3)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_4 = fileData(COL_NO.REQ_O_TEHAI_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_4 = fileData(COL_NO.REQ_O_IRAINAIYOU_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_4 = fileData(COL_NO.REQ_O_KOTSUKIKAN_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_4 = fileData(COL_NO.REQ_O_DATE_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_4 = fileData(COL_NO.REQ_O_AIRPORT1_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_4 = fileData(COL_NO.REQ_O_AIRPORT2_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_4 = fileData(COL_NO.REQ_O_TIME1_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_4 = fileData(COL_NO.REQ_O_TIME2_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_4 = fileData(COL_NO.REQ_O_BIN_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_4 = fileData(COL_NO.REQ_O_SEAT_4)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU4 = fileData(COL_NO.REQ_O_SEAT_KIBOU4)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_5 = fileData(COL_NO.REQ_O_TEHAI_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_5 = fileData(COL_NO.REQ_O_IRAINAIYOU_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_5 = fileData(COL_NO.REQ_O_KOTSUKIKAN_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_5 = fileData(COL_NO.REQ_O_DATE_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_5 = fileData(COL_NO.REQ_O_AIRPORT1_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_5 = fileData(COL_NO.REQ_O_AIRPORT2_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_5 = fileData(COL_NO.REQ_O_TIME1_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_5 = fileData(COL_NO.REQ_O_TIME2_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_5 = fileData(COL_NO.REQ_O_BIN_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_5 = fileData(COL_NO.REQ_O_SEAT_5)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU5 = fileData(COL_NO.REQ_O_SEAT_KIBOU5)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_1 = fileData(COL_NO.REQ_F_TEHAI_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_1 = fileData(COL_NO.REQ_F_IRAINAIYOU_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_1 = fileData(COL_NO.REQ_F_KOTSUKIKAN_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_1 = fileData(COL_NO.REQ_F_DATE_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_1 = fileData(COL_NO.REQ_F_AIRPORT1_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_1 = fileData(COL_NO.REQ_F_AIRPORT2_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_1 = fileData(COL_NO.REQ_F_TIME1_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_1 = fileData(COL_NO.REQ_F_TIME2_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_1 = fileData(COL_NO.REQ_F_BIN_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_1 = fileData(COL_NO.REQ_F_SEAT_1)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU1 = fileData(COL_NO.REQ_F_SEAT_KIBOU1)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_2 = fileData(COL_NO.REQ_F_TEHAI_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_2 = fileData(COL_NO.REQ_F_IRAINAIYOU_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_2 = fileData(COL_NO.REQ_F_KOTSUKIKAN_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_2 = fileData(COL_NO.REQ_F_DATE_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_2 = fileData(COL_NO.REQ_F_AIRPORT1_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_2 = fileData(COL_NO.REQ_F_AIRPORT2_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_2 = fileData(COL_NO.REQ_F_TIME1_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_2 = fileData(COL_NO.REQ_F_TIME2_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_2 = fileData(COL_NO.REQ_F_BIN_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_2 = fileData(COL_NO.REQ_F_SEAT_2)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU2 = fileData(COL_NO.REQ_F_SEAT_KIBOU2)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_3 = fileData(COL_NO.REQ_F_TEHAI_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_3 = fileData(COL_NO.REQ_F_IRAINAIYOU_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_3 = fileData(COL_NO.REQ_F_KOTSUKIKAN_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_3 = fileData(COL_NO.REQ_F_DATE_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_3 = fileData(COL_NO.REQ_F_AIRPORT1_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_3 = fileData(COL_NO.REQ_F_AIRPORT2_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_3 = fileData(COL_NO.REQ_F_TIME1_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_3 = fileData(COL_NO.REQ_F_TIME2_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_3 = fileData(COL_NO.REQ_F_BIN_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_3 = fileData(COL_NO.REQ_F_SEAT_3)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU3 = fileData(COL_NO.REQ_F_SEAT_KIBOU3)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_4 = fileData(COL_NO.REQ_F_TEHAI_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_4 = fileData(COL_NO.REQ_F_IRAINAIYOU_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_4 = fileData(COL_NO.REQ_F_KOTSUKIKAN_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_4 = fileData(COL_NO.REQ_F_DATE_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_4 = fileData(COL_NO.REQ_F_AIRPORT1_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_4 = fileData(COL_NO.REQ_F_AIRPORT2_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_4 = fileData(COL_NO.REQ_F_TIME1_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_4 = fileData(COL_NO.REQ_F_TIME2_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_4 = fileData(COL_NO.REQ_F_BIN_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_4 = fileData(COL_NO.REQ_F_SEAT_4)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU4 = fileData(COL_NO.REQ_F_SEAT_KIBOU4)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_5 = fileData(COL_NO.REQ_F_TEHAI_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_5 = fileData(COL_NO.REQ_F_IRAINAIYOU_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_5 = fileData(COL_NO.REQ_F_KOTSUKIKAN_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_5 = fileData(COL_NO.REQ_F_DATE_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_5 = fileData(COL_NO.REQ_F_AIRPORT1_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_5 = fileData(COL_NO.REQ_F_AIRPORT2_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_5 = fileData(COL_NO.REQ_F_TIME1_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_5 = fileData(COL_NO.REQ_F_TIME2_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_5 = fileData(COL_NO.REQ_F_BIN_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_5 = fileData(COL_NO.REQ_F_SEAT_5)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU5 = fileData(COL_NO.REQ_F_SEAT_KIBOU5)
        TBL_KOTSUHOTEL_Ins.REQ_KOTSU_BIKO = fileData(COL_NO.REQ_KOTSU_BIKO)
        TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_DATE_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_BIN_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU1 = ""
        
        TBL_KOTSUHOTEL_Ins.TEHAI_TAXI = fileData(COL_NO.TEHAI_TAXI)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_1 = fileData(COL_NO.REQ_TAXI_DATE_1)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_1 = fileData(COL_NO.REQ_TAXI_FROM_1)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_1 = fileData(COL_NO.TAXI_YOTEIKINGAKU_1)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_2 = fileData(COL_NO.REQ_TAXI_DATE_2)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_2 = fileData(COL_NO.REQ_TAXI_FROM_2)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_2 = fileData(COL_NO.TAXI_YOTEIKINGAKU_2)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_3 = fileData(COL_NO.REQ_TAXI_DATE_3)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_3 = fileData(COL_NO.REQ_TAXI_FROM_3)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_3 = fileData(COL_NO.TAXI_YOTEIKINGAKU_3)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_4 = fileData(COL_NO.REQ_TAXI_DATE_4)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_4 = fileData(COL_NO.REQ_TAXI_FROM_4)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_4 = fileData(COL_NO.TAXI_YOTEIKINGAKU_4)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_5 = fileData(COL_NO.REQ_TAXI_DATE_5)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_5 = fileData(COL_NO.REQ_TAXI_FROM_5)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_5 = fileData(COL_NO.TAXI_YOTEIKINGAKU_5)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_6 = fileData(COL_NO.REQ_TAXI_DATE_6)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_6 = fileData(COL_NO.REQ_TAXI_FROM_6)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_6 = fileData(COL_NO.TAXI_YOTEIKINGAKU_6)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_7 = fileData(COL_NO.REQ_TAXI_DATE_7)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_7 = fileData(COL_NO.REQ_TAXI_FROM_7)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_7 = fileData(COL_NO.TAXI_YOTEIKINGAKU_7)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_8 = fileData(COL_NO.REQ_TAXI_DATE_8)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_8 = fileData(COL_NO.REQ_TAXI_FROM_8)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_8 = fileData(COL_NO.TAXI_YOTEIKINGAKU_8)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_9 = fileData(COL_NO.REQ_TAXI_DATE_9)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_9 = fileData(COL_NO.REQ_TAXI_FROM_9)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_9 = fileData(COL_NO.TAXI_YOTEIKINGAKU_9)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_10 = fileData(COL_NO.REQ_TAXI_DATE_10)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_10 = fileData(COL_NO.REQ_TAXI_FROM_10)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_10 = fileData(COL_NO.TAXI_YOTEIKINGAKU_10)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_NOTE = fileData(COL_NO.REQ_TAXI_NOTE)
        
        TBL_KOTSUHOTEL_Ins.REQ_MR_O_TEHAI = fileData(COL_NO.REQ_MR_O_TEHAI)
        TBL_KOTSUHOTEL_Ins.REQ_MR_F_TEHAI = fileData(COL_NO.REQ_MR_F_TEHAI)
        TBL_KOTSUHOTEL_Ins.MR_SEX = fileData(COL_NO.MR_SEX)
        TBL_KOTSUHOTEL_Ins.MR_AGE = fileData(COL_NO.MR_AGE)
        TBL_KOTSUHOTEL_Ins.REQ_MR_TEHAI_HOTEL = fileData(COL_NO.REQ_MR_TEHAI_HOTEL)
        TBL_KOTSUHOTEL_Ins.REQ_MR_HOTEL_SMOKING = fileData(COL_NO.REQ_MR_HOTEL_SMOKING)
        TBL_KOTSUHOTEL_Ins.REQ_MR_HOTEL_NOTE = fileData(COL_NO.REQ_MR_HOTEL_NOTE)
        
        TBL_KOTSUHOTEL_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi

        TBL_KOTSUHOTEL_Ins.INPUT_USER = pbatchID
        TBL_KOTSUHOTEL_Ins.UPDATE_USER = pbatchID
        TBL_KOTSUHOTEL_Ins.SEND_DATE = ""

        '同一キーのデータを検索
        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct = GetData(fileData(COL_NO.KOUENKAI_NO), fileData(COL_NO.SANKASHA_ID))

        'TODO:.Length = 0だと判断できないので他の方法を探す。
        If TBL_KOTSUHOTEL.Length = 0 Then
            '該当データ0件のとき

            'TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_2 = fileData(COL_NO.ANS_O_STATUS_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_2 = fileData(COL_NO.ANS_O_KOTSUKIKAN_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_DATE_2 = fileData(COL_NO.ANS_O_DATE_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_2 = fileData(COL_NO.ANS_O_AIRPORT1_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_2 = fileData(COL_NO.ANS_O_AIRPORT2_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_2 = fileData(COL_NO.ANS_O_TIME1_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_2 = fileData(COL_NO.ANS_O_TIME2_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_BIN_2 = fileData(COL_NO.ANS_O_BIN_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_2 = fileData(COL_NO.ANS_O_SEAT_2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU2 = fileData(COL_NO.ANS_O_SEAT_KIBOU2)
            'TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_3 = fileData(COL_NO.ANS_O_STATUS_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_3 = fileData(COL_NO.ANS_O_KOTSUKIKAN_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_DATE_3 = fileData(COL_NO.ANS_O_DATE_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_3 = fileData(COL_NO.ANS_O_AIRPORT1_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_3 = fileData(COL_NO.ANS_O_AIRPORT2_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_3 = fileData(COL_NO.ANS_O_TIME1_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_3 = fileData(COL_NO.ANS_O_TIME2_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_BIN_3 = fileData(COL_NO.ANS_O_BIN_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_3 = fileData(COL_NO.ANS_O_SEAT_3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU3 = fileData(COL_NO.ANS_O_SEAT_KIBOU3)
            'TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_4 = fileData(COL_NO.ANS_O_STATUS_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_4 = fileData(COL_NO.ANS_O_KOTSUKIKAN_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_DATE_4 = fileData(COL_NO.ANS_O_DATE_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_4 = fileData(COL_NO.ANS_O_AIRPORT1_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_4 = fileData(COL_NO.ANS_O_AIRPORT2_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_4 = fileData(COL_NO.ANS_O_TIME1_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_4 = fileData(COL_NO.ANS_O_TIME2_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_BIN_4 = fileData(COL_NO.ANS_O_BIN_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_4 = fileData(COL_NO.ANS_O_SEAT_4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU4 = fileData(COL_NO.ANS_O_SEAT_KIBOU4)
            'TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_5 = fileData(COL_NO.ANS_O_STATUS_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_5 = fileData(COL_NO.ANS_O_KOTSUKIKAN_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_DATE_5 = fileData(COL_NO.ANS_O_DATE_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_5 = fileData(COL_NO.ANS_O_AIRPORT1_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_5 = fileData(COL_NO.ANS_O_AIRPORT2_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_5 = fileData(COL_NO.ANS_O_TIME1_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_5 = fileData(COL_NO.ANS_O_TIME2_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_BIN_5 = fileData(COL_NO.ANS_O_BIN_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_5 = fileData(COL_NO.ANS_O_SEAT_5)
            'TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU5 = fileData(COL_NO.ANS_O_SEAT_KIBOU5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_1 = fileData(COL_NO.ANS_F_STATUS_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_1 = fileData(COL_NO.ANS_F_KOTSUKIKAN_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_DATE_1 = fileData(COL_NO.ANS_F_DATE_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_1 = fileData(COL_NO.ANS_F_AIRPORT1_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_1 = fileData(COL_NO.ANS_F_AIRPORT2_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_1 = fileData(COL_NO.ANS_F_TIME1_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_1 = fileData(COL_NO.ANS_F_TIME2_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_BIN_1 = fileData(COL_NO.ANS_F_BIN_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_1 = fileData(COL_NO.ANS_F_SEAT_1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU1 = fileData(COL_NO.ANS_F_SEAT_KIBOU1)
            'TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_2 = fileData(COL_NO.ANS_F_STATUS_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_2 = fileData(COL_NO.ANS_F_KOTSUKIKAN_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_DATE_2 = fileData(COL_NO.ANS_F_DATE_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_2 = fileData(COL_NO.ANS_F_AIRPORT1_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_2 = fileData(COL_NO.ANS_F_AIRPORT2_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_2 = fileData(COL_NO.ANS_F_TIME1_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_2 = fileData(COL_NO.ANS_F_TIME2_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_BIN_2 = fileData(COL_NO.ANS_F_BIN_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_2 = fileData(COL_NO.ANS_F_SEAT_2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU2 = fileData(COL_NO.ANS_F_SEAT_KIBOU2)
            'TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_3 = fileData(COL_NO.ANS_F_STATUS_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_3 = fileData(COL_NO.ANS_F_KOTSUKIKAN_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_DATE_3 = fileData(COL_NO.ANS_F_DATE_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_3 = fileData(COL_NO.ANS_F_AIRPORT1_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_3 = fileData(COL_NO.ANS_F_AIRPORT2_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_3 = fileData(COL_NO.ANS_F_TIME1_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_3 = fileData(COL_NO.ANS_F_TIME2_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_BIN_3 = fileData(COL_NO.ANS_F_BIN_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_3 = fileData(COL_NO.ANS_F_SEAT_3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU3 = fileData(COL_NO.ANS_F_SEAT_KIBOU3)
            'TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_4 = fileData(COL_NO.ANS_F_STATUS_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_4 = fileData(COL_NO.ANS_F_KOTSUKIKAN_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_DATE_4 = fileData(COL_NO.ANS_F_DATE_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_4 = fileData(COL_NO.ANS_F_AIRPORT1_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_4 = fileData(COL_NO.ANS_F_AIRPORT2_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_4 = fileData(COL_NO.ANS_F_TIME1_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_4 = fileData(COL_NO.ANS_F_TIME2_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_BIN_4 = fileData(COL_NO.ANS_F_BIN_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_4 = fileData(COL_NO.ANS_F_SEAT_4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU4 = fileData(COL_NO.ANS_F_SEAT_KIBOU4)
            'TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_5 = fileData(COL_NO.ANS_F_STATUS_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_5 = fileData(COL_NO.ANS_F_KOTSUKIKAN_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_DATE_5 = fileData(COL_NO.ANS_F_DATE_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_5 = fileData(COL_NO.ANS_F_AIRPORT1_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_5 = fileData(COL_NO.ANS_F_AIRPORT2_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_5 = fileData(COL_NO.ANS_F_TIME1_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_5 = fileData(COL_NO.ANS_F_TIME2_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_BIN_5 = fileData(COL_NO.ANS_F_BIN_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_5 = fileData(COL_NO.ANS_F_SEAT_5)
            'TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU5 = fileData(COL_NO.ANS_F_SEAT_KIBOU5)
            'TBL_KOTSUHOTEL_Ins.ANS_KOTSU_BIKO = fileData(COL_NO.ANS_KOTSU_BIKO)
            'TBL_KOTSUHOTEL_Ins.ANS_RAIL_FARE = fileData(COL_NO.ANS_RAIL_FARE)
            'TBL_KOTSUHOTEL_Ins.ANS_RAIL_CANCELLATION = fileData(COL_NO.ANS_RAIL_CANCELLATION)
            'TBL_KOTSUHOTEL_Ins.ANS_OTHER_FARE = fileData(COL_NO.ANS_OTHER_FARE)
            'TBL_KOTSUHOTEL_Ins.ANS_OTHER_CANCELLATION = fileData(COL_NO.ANS_OTHER_CANCELLATION)
            'TBL_KOTSUHOTEL_Ins.ANS_AIR_FARE = fileData(COL_NO.ANS_AIR_FARE)
            'TBL_KOTSUHOTEL_Ins.ANS_AIR_CANCELLATION = fileData(COL_NO.ANS_AIR_CANCELLATION)

            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_1 = fileData(COL_NO.ANS_TAXI_DATE_1)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_1 = fileData(COL_NO.ANS_TAXI_KENSHU_1)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_1 = fileData(COL_NO.ANS_TAXI_NO_1)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_2 = fileData(COL_NO.ANS_TAXI_DATE_2)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_2 = fileData(COL_NO.ANS_TAXI_KENSHU_2)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_2 = fileData(COL_NO.ANS_TAXI_NO_2)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_3 = fileData(COL_NO.ANS_TAXI_DATE_3)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_3 = fileData(COL_NO.ANS_TAXI_KENSHU_3)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_3 = fileData(COL_NO.ANS_TAXI_NO_3)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_4 = fileData(COL_NO.ANS_TAXI_DATE_4)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_4 = fileData(COL_NO.ANS_TAXI_KENSHU_4)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_4 = fileData(COL_NO.ANS_TAXI_NO_4)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_5 = fileData(COL_NO.ANS_TAXI_DATE_5)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_5 = fileData(COL_NO.ANS_TAXI_KENSHU_5)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_5 = fileData(COL_NO.ANS_TAXI_NO_5)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_6 = fileData(COL_NO.ANS_TAXI_DATE_6)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_6 = fileData(COL_NO.ANS_TAXI_KENSHU_6)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_6 = fileData(COL_NO.ANS_TAXI_NO_6)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_7 = fileData(COL_NO.ANS_TAXI_DATE_7)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_7 = fileData(COL_NO.ANS_TAXI_KENSHU_7)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_7 = fileData(COL_NO.ANS_TAXI_NO_7)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_8 = fileData(COL_NO.ANS_TAXI_DATE_8)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_8 = fileData(COL_NO.ANS_TAXI_KENSHU_8)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_8 = fileData(COL_NO.ANS_TAXI_NO_8)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_9 = fileData(COL_NO.ANS_TAXI_DATE_9)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_9 = fileData(COL_NO.ANS_TAXI_KENSHU_9)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_9 = fileData(COL_NO.ANS_TAXI_NO_9)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_10 = fileData(COL_NO.ANS_TAXI_DATE_10)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_10 = fileData(COL_NO.ANS_TAXI_KENSHU_10)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_10 = fileData(COL_NO.ANS_TAXI_NO_10)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_11 = fileData(COL_NO.ANS_TAXI_DATE_11)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_11 = fileData(COL_NO.ANS_TAXI_KENSHU_11)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_11 = fileData(COL_NO.ANS_TAXI_NO_11)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_12 = fileData(COL_NO.ANS_TAXI_DATE_12)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_12 = fileData(COL_NO.ANS_TAXI_KENSHU_12)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_12 = fileData(COL_NO.ANS_TAXI_NO_12)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_13 = fileData(COL_NO.ANS_TAXI_DATE_13)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_13 = fileData(COL_NO.ANS_TAXI_KENSHU_13)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_13 = fileData(COL_NO.ANS_TAXI_NO_13)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_14 = fileData(COL_NO.ANS_TAXI_DATE_14)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_14 = fileData(COL_NO.ANS_TAXI_KENSHU_14)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_14 = fileData(COL_NO.ANS_TAXI_NO_14)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_15 = fileData(COL_NO.ANS_TAXI_DATE_15)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_15 = fileData(COL_NO.ANS_TAXI_KENSHU_15)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_15 = fileData(COL_NO.ANS_TAXI_NO_15)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_16 = fileData(COL_NO.ANS_TAXI_DATE_16)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_16 = fileData(COL_NO.ANS_TAXI_KENSHU_16)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_16 = fileData(COL_NO.ANS_TAXI_NO_16)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_17 = fileData(COL_NO.ANS_TAXI_DATE_17)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_17 = fileData(COL_NO.ANS_TAXI_KENSHU_17)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_17 = fileData(COL_NO.ANS_TAXI_NO_17)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_18 = fileData(COL_NO.ANS_TAXI_DATE_18)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_18 = fileData(COL_NO.ANS_TAXI_KENSHU_18)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_18 = fileData(COL_NO.ANS_TAXI_NO_18)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_19 = fileData(COL_NO.ANS_TAXI_DATE_19)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_19 = fileData(COL_NO.ANS_TAXI_KENSHU_19)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_19 = fileData(COL_NO.ANS_TAXI_NO_19)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_20 = fileData(COL_NO.ANS_TAXI_DATE_20)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_20 = fileData(COL_NO.ANS_TAXI_KENSHU_20)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_20 = fileData(COL_NO.ANS_TAXI_NO_20)
            'TBL_KOTSUHOTEL_Ins.ANS_TAXI_NOTE = fileData(COL_NO.ANS_TAXI_NOTE)

            'TBL_KOTSUHOTEL_Ins.ANS_MR_O_TEHAI = fileData(COL_NO.ANS_MR_O_TEHAI)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_F_TEHAI = fileData(COL_NO.ANS_MR_F_TEHAI)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NAME = fileData(COL_NO.ANS_MR_HOTEL_NAME)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_ADDRESS = fileData(COL_NO.ANS_MR_HOTEL_ADDRESS)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_TEL = fileData(COL_NO.ANS_MR_HOTEL_TEL)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKIN_TIME = fileData(COL_NO.ANS_MR_CHECKIN_TIME)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKOUT_TIME = fileData(COL_NO.ANS_MR_CHECKOUT_TIME)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_SMOKING = fileData(COL_NO.ANS_MR_HOTEL_SMOKING)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NOTE = fileData(COL_NO.ANS_MR_HOTEL_NOTE)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_KOTSUHI = fileData(COL_NO.ANS_MR_KOTSUHI)
            'TBL_KOTSUHOTEL_Ins.ANS_MR_HOTELHI = fileData(COL_NO.ANS_MR_HOTELHI)

            TBL_KOTSUHOTEL_Ins.TTANTO_ID = ""
            'TODO:もしかしたら""はセットしなくていいかも
        Else
            Dim idx As Integer = GetLastData(TBL_KOTSUHOTEL)

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_2 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_2
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_2 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_2
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_2 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_2
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_2 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_2
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_2 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_2
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_2 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_2
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_2 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_2
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_2 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_2
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU2 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU2
            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_3 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_3
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_3 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_3
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_3 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_3
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_3 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_3
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_3 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_3
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_3 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_3
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_3 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_3
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_3 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_3
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU3 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU3
            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_4 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_4
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_4 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_4
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_4 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_4
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_4 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_4
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_4 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_4
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_4 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_4
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_4 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_4
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_4 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_4
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU4 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU4
            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_5 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_5
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_5 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_5
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_5 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_5
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_5 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_5
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_5 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_5
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_5 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_5
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_5 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_5
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_5 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_5
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU5 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU5
            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_1 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_1
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_1 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_1
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_1 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_1
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_1 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_1
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_1 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_1
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_1 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_1
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_1 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_1
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_1 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_1
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU1 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU1
            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_2 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_2
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_2 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_2
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_2 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_2
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_2 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_2
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_2 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_2
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_2 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_2
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_2 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_2
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_2 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_2
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU2 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU2
            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_3 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_3
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_3 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_3
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_3 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_3
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_3 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_3
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_3 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_3
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_3 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_3
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_3 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_3
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_3 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_3
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU3 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU3
            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_4 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_4
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_4 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_4
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_4 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_4
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_4 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_4
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_4 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_4
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_4 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_4
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_4 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_4
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_4 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_4
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU4 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU4
            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_5 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_5
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_5 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_5
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_5 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_5
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_5 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_5
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_5 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_5
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_5 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_5
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_5 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_5
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_5 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_5
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU5 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU5
            TBL_KOTSUHOTEL_Ins.ANS_KOTSU_BIKO = TBL_KOTSUHOTEL(idx).ANS_KOTSU_BIKO
            TBL_KOTSUHOTEL_Ins.ANS_RAIL_FARE = TBL_KOTSUHOTEL(idx).ANS_RAIL_FARE
            TBL_KOTSUHOTEL_Ins.ANS_RAIL_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_RAIL_CANCELLATION
            TBL_KOTSUHOTEL_Ins.ANS_OTHER_FARE = TBL_KOTSUHOTEL(idx).ANS_OTHER_FARE
            TBL_KOTSUHOTEL_Ins.ANS_OTHER_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_OTHER_CANCELLATION
            TBL_KOTSUHOTEL_Ins.ANS_AIR_FARE = TBL_KOTSUHOTEL(idx).ANS_AIR_FARE
            TBL_KOTSUHOTEL_Ins.ANS_AIR_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_AIR_CANCELLATION

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NOTE = TBL_KOTSUHOTEL(idx).ANS_TAXI_NOTE

            TBL_KOTSUHOTEL_Ins.ANS_MR_O_TEHAI = TBL_KOTSUHOTEL(idx).ANS_MR_O_TEHAI
            TBL_KOTSUHOTEL_Ins.ANS_MR_F_TEHAI = TBL_KOTSUHOTEL(idx).ANS_MR_F_TEHAI
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NAME = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_NAME
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_ADDRESS = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_ADDRESS
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_TEL = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_TEL
            TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKIN_TIME = TBL_KOTSUHOTEL(idx).ANS_MR_CHECKIN_TIME
            TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKOUT_TIME = TBL_KOTSUHOTEL(idx).ANS_MR_CHECKOUT_TIME
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_SMOKING = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_SMOKING
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NOTE = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_NOTE
            TBL_KOTSUHOTEL_Ins.ANS_MR_KOTSUHI = TBL_KOTSUHOTEL(idx).ANS_MR_KOTSUHI
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTELHI = TBL_KOTSUHOTEL(idx).ANS_MR_HOTELHI

            TBL_KOTSUHOTEL_Ins.TTANTO_ID = TBL_KOTSUHOTEL(idx).TTANTO_ID
        End If

        Return TBL_KOTSUHOTEL_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strSankashaId As String, ByVal strKouenkaiNo As String) As TableDef.TBL_KOTSUHOTEL.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOTSUHOTEL(wCnt) As TableDef.TBL_KOTSUHOTEL.DataStruct

        'TODO:SQLのOrderbyをTimeStamp昇順にして問題ないか確認
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID(strKouenkaiNo, strSankashaId)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            ReDim Preserve TBL_KOTSUHOTEL(wCnt)

            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        Return TBL_KOTSUHOTEL
    End Function

    '最新データがセットされている配列の添え字を取得する
    Private Function GetLastData(ByVal TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Integer
        Dim rowNo As Integer = 0
        Dim wCnt As Integer = 0

        For Each record As TableDef.TBL_KOTSUHOTEL.DataStruct In TBL_KOTSUHOTEL
            'If record.KIDOKU_FLG = CmnConst.Flag.On Then
            rowNo = wCnt
            'End If
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
