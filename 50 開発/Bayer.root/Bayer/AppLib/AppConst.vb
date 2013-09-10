Public Class AppConst

    Public Class UserType
        'ユーザ種類
        Public Const Dr As String = "D"
        Public Const Member As String = "M"
        Public Const Admin As String = "A"
        'Public Const Manage As String = "3"
    End Class

    Public Class INS_TYPE
        '登録者
        Public Class Code
            Public Const Member As String = "M"
            Public Const Dr As String = "D"
            Public Const Admin As String = "A"
        End Class
        Public Class Name
            Public Const Member As String = "営業担当"
            Public Const Dr As String = "ドクター"
            Public Const Admin As String = "トップツアー"
        End Class
    End Class

    Public Class RECORD_KUBUN
        'データ区分
        Public Class Code
            Public Const Insert As String = "I"
            Public Const Update As String = "U"
            Public Const Cancel As String = "C"
        End Class
        Public Class Name
            Public Const Insert As String = "登録"
            Public Const Update As String = "変更"
            Public Const Cancel As String = "取消"
        End Class
    End Class

    Public Class LOGIN_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "0"
        End Class
        Public Class Name
            Public Const Yes As String = "済"
            Public Const No As String = "未"
        End Class
    End Class

    Public Class ATTEND
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
            Public Const Mi As String = "3"
        End Class
        Public Class Name
            Public Const Yes As String = "する"
            Public Const No As String = "しない"
            Public Const Mi As String = "未定"
        End Class
    End Class

    Public Class DATA_NO
        '登録番号
        Public Const Head As String = "D-"
        Public Const NumberLength As Integer = 4
    End Class

    Public Class STATUS_TEHAI
        '手配状況
        Public Class Code
            Public Const Fuyo As String = "00"
            Public Const Input As String = "05"
            Public Const Change As String = "10"
            Public Const Cancel As String = "15"
            Public Const HotelNG As String = "20"
            Public Const KotsuNG As String = "25"
            Public Const HotelNG_KotsuNG As String = "30"
            Public Const HotelOK_KotsuNG As String = "35"
            Public Const HotelNG_KotsuOK As String = "40"
            Public Const KotsuOK As String = "45"
            Public Const HotelOK As String = "50"
            Public Const HotelOK_KotsuOK As String = "55"
            Public Const OKToFuyo As String = "60"
            Public Const OkToChange As String = "65"
            Public Const OKToCancel As String = "70"
            Public Const EndToFuyo As String = "75"
            Public Const EndToChange As String = "80"
            Public Const EndToCancel As String = "85"
        End Class
        Public Class Name
            Public Const Fuyo As String = "手配不要"
            Public Const Input As String = "新規登録"
            Public Const Change As String = "変更"
            Public Const Cancel As String = "参加取消"
            Public Const HotelNG As String = "宿泊手配中"
            Public Const KotsuNG As String = "公共交通手配中"
            Public Const HotelNG_KotsuNG As String = "宿泊・公共交通手配中"
            Public Const HotelOK_KotsuNG As String = "宿泊手配済・公共交通手配中"
            Public Const HotelNG_KotsuOK As String = "宿泊手配中・公共交通手配済"
            Public Const KotsuOK As String = "公共交通手配済"
            Public Const HotelOK As String = "宿泊手配済"
            Public Const HotelOK_KotsuOK As String = "宿泊・公共交通手配済"
            Public Const OKToFuyo As String = "手配済後 手配不要"
            Public Const OkToChange As String = "手配済後 変更"
            Public Const OKToCancel As String = "手配済後 キャンセル"
            Public Const EndToFuyo As String = "決済・入金後 手配不要"
            Public Const EndToChange As String = "決済・入金後 変更"
            Public Const EndToCancel As String = "決済・入金後 キャンセル"
        End Class
    End Class

    Public Class STATUS_PAYMENT
        '支払状況
        Public Class Code
            Public Const Fuyo As String = "00"
            Public Const Input As String = "05"
            Public Const OK As String = "10"
            Public Const BillPrint As String = "15"
            Public Const OKToFuyo As String = "20"
            Public Const OkToChange As String = "25"
            Public Const OKToCancel As String = "30"
            Public Const CardEnd As String = "35"
            Public Const BillEnd As String = "40"
            Public Const EndToFuyo As String = "45"
            Public Const EndToChange As String = "50"
            Public Const EndToCancel As String = "55"
            Public Const EndToNG As String = "60"
        End Class
        Public Class Name
            Public Const Fuyo As String = "支払不要"
            Public Const Input As String = "申込受付"
            Public Const OK As String = "金額確定"
            Public Const BillPrint As String = "請求書印刷"
            Public Const OKToFuyo As String = "手配済後 支払不要"
            Public Const OkToChange As String = "手配済後 変更"
            Public Const OKToCancel As String = "手配済後 キャンセル"
            Public Const CardEnd As String = "カード決済完了"
            Public Const BillEnd As String = "入金完了"
            Public Const EndToFuyo As String = "決済・入金後 支払不要"
            Public Const EndToChange As String = "決済・入金後 変更"
            Public Const EndToCancel As String = "決済・入金後 キャンセル"
            Public Const EndToNG As String = "決済失敗"
        End Class
    End Class

    Public Class PAYMENT_METHOD
        Public Class Code
            Public Const Card As String = "C"
            Public Const Bank As String = "B"
        End Class
        Public Class Name
            Public Const Card As String = "クレジットカード"
            Public Const Bank As String = "銀行振込"
            Public Class ShortFormat
                Public Const Card As String = "カード"
                Public Const Bank As String = "振込"
            End Class
        End Class
    End Class

    Public Class SANKA_KUBUN
        '参加区分
        Public Class Code
            Public Const Speaker As String = "1"
            Public Const Listener As String = "2"
        End Class
        Public Class Name
            Public Const Speaker As String = "講師・座長"
            Public Const Listener As String = "参加Dr."
        End Class
    End Class

    Public Class TEHAI
        '手配
        Public Const DefaultValue As String = "2"
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "依頼する"
            Public Const No As String = "依頼しない"
            Public Class ShortFormat
                Public Const Yes As String = "有"
                Public Const No As String = "無"
            End Class
        End Class
    End Class

    Public Class PARTY
        '情報交換会
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "参加する"
            Public Const No As String = "参加しない"
            Public Class ShortFormat
                Public Const Yes As String = "参加"
                Public Const No As String = "不参加"
            End Class
        End Class
    End Class

    Public Class PUBLIC_SERVANT
        '公務員/非公務員
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "公務員"
            Public Const No As String = "非公務員"
        End Class
    End Class

    Public Class SECANDARY_USE
        '画像及び発言の二次使用
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "同意します"
            Public Const No As String = "同意しません "
            Public Class ShortFormat
                Public Const Yes As String = "同意"
                Public Const No As String = ""
            End Class
        End Class
    End Class

    Public Class WETLAB_FLAG
        'ウェットラボ
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "参加する"
            Public Const No As String = "参加しない"
            Public Class ShortFormat
                Public Const Yes As String = "参加"
                Public Const No As String = "不参加"
            End Class
        End Class
    End Class

    Public Class WETLAB_COURSE
        'ウェットラボ コース
        Public Class Code
            Public Const A As String = "A"
            Public Const B As String = "B"
        End Class
        Public Class Name
            Public Const A As String = "MICS Mitral Valve Repair"
            Public Const B As String = "Mitral Valve Repair"
            Public Class ShortFormat
                Public Const A As String = "A"
                Public Const B As String = "B"
            End Class
        End Class
    End Class

    Public Class STAY_DATE
        '宿泊日
        Public Class Code
            Public Const Before As String = "01"
            Public Const BeforeTojitsu As String = "02"
            Public Const Tojitsu As String = "03"
            Public Const TojitsuAfter As String = "04"
            Public Const After As String = "05"
        End Class
        Public Class Name
            Public Const Before As String = "前泊"
            Public Const BeforeTojitsu As String = "前泊＋当日泊"
            Public Const Tojitsu As String = "当日泊"
            Public Const TojitsuAfter As String = "当日泊＋後泊"
            Public Const After As String = "後泊"
        End Class
        Public Class CHECK_IN
            Public Const Before As String = "09/06"
            Public Const BeforeTojitsu As String = "09/06"
            Public Const Tojitsu As String = "09/07"
            Public Const TojitsuAfter As String = "09/07"
            Public Const After As String = "09/08"
        End Class
        Public Class CHECK_OUT
            Public Const Before As String = "09/07"
            Public Const BeforeTojitsu As String = "09/08"
            Public Const Tojitsu As String = "09/08"
            Public Const TojitsuAfter As String = "09/09"
            Public Const After As String = "09/09"
        End Class
    End Class

    Public Class HOTEL
        Public Const DATA_ID As String = "01"
        Public Const CHECK_IN As String = "09/07"
        Public Const CHECK_OUT As String = "09/08"
    End Class

    Public Class SEAT
        '座席場所
        Public Class Code
            Public Const Window As String = "1"
            Public Const Aisle As String = "2"
        End Class
        Public Class Name
            Public Const Window As String = "窓側"
            Public Const Aisle As String = "通路側"
        End Class
    End Class

    Public Class SEATCLASS
        '座席区分
        Public Class Code
            Public Const Regular As String = "1"
            Public Const Premium As String = "2"
            Public Const Unreserved As String = "3"
        End Class
        Public Class Name
            Public Const Regular As String = "普通席"
            Public Const Premium As String = "プレミアム・クラスJ・グリーン"
            Public Const Unreserved As String = "自由席"
        End Class
    End Class

    Public Class HOTEL_SMOKING
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "喫煙"
            Public Const No As String = "禁煙"
        End Class
    End Class

    Public Class KOTSU_SMOKING
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "喫煙席"
            Public Const No As String = "禁煙席"
        End Class
    End Class

    Public Class SEND_SAKI
        Public Class Code
            Public Const DrOffice As String = "1"
            Public Const DrHome As String = "2"
            Public Const MemberOffice As String = "3"
        End Class
        Public Class Name
            Public Const DrOffice As String = "勤務先"
            Public Const DrHome As String = "自宅"
            Public Const MemberOffice As String = "営業担当者所属オフィス"
        End Class
    End Class

    Public Class JR_KUBUN
        Public Const ORO As String = "O"
        Public Const FUKURO As String = "F"
    End Class

    Public Class AIR_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "0"
        End Class
        Public Class Name
            Public Const Yes As String = "可"
            Public Const No As String = "不可"
        End Class
    End Class

    Public Class JR_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "0"
        End Class
        Public Class Name
            Public Const Yes As String = "可"
            Public Const No As String = "不可"
        End Class
    End Class

    Public Class ACCOMPANY_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = ""
        End Class
        Public Class Name
            Public Const Yes As String = "有"
            Public Const No As String = "無"
        End Class
    End Class

    Public Class ACCOMPANY_STAY
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "有"
            Public Const No As String = "無"
        End Class
    End Class

    Public Class ACCOMPANY_SAME_ROOM
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "ドクターと同室"
            Public Const No As String = "ドクターと別室"
            Public Class ShortFormat
                Public Const Yes As String = "同室"
                Public Const No As String = "別室"
            End Class
        End Class
    End Class

    Public Class ACCOMPANY_STAY_DATE
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = ""
        End Class
        Public Class Name
            Public Const Yes As String = "ドクターと同日程"
            Public Const No As String = "ドクターと別日程"
        End Class
    End Class

    Public Class ACCOMPANY_BED
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "必要"
            Public Const No As String = "不要"
        End Class
    End Class

    Public Class SEX
        '性別
        Public Class Code
            Public Const Male As String = "M"
            Public Const Female As String = "F"
        End Class
        Public Class Name
            Public Const Male As String = "男性"
            Public Const Female As String = "女性"
        End Class
    End Class

    Public Class Mail
        'メール署名
        Public Const Signature As String = "---------------------システム及び交通宿泊に関する問い合わせ先-------------------------" & vbNewLine _
                                          & "Edwards Heart Valve Seminar 2013 運営事務局" & vbNewLine _
                                          & "トップツアー㈱東京法人東事業部 （担当：島田・北舘）" & vbNewLine _
                                          & vbNewLine _
                                          & "〒103-0025　東京都中央区日本橋茅場町2－10－5 住友生命茅場町ビル2階" & vbNewLine _
                                          & "TEL: 03-6667-0591　FAX: 03-6667-0565" & vbNewLine _
                                          & "MAIL: edwards_2013@toptour.co.jp" & vbNewLine _
                                          & vbNewLine _
                                          & "営業時間：月～金10:00-17:30　土日祝日 休業" & vbNewLine _
                                          & "-------------------------------------------------------------------------------------"

        Public Class Result
            'メール送信フラグ
            Public Const OK As String = "0"
            Public Const NG As String = "9"
        End Class
    End Class

    Public Class KOTSU_KUBUN
        Public Class Code
            Public Const AIR As String = "A"
            Public Const JR As String = "J"
            Public Const None As String = ""
        End Class
        Public Class Name
            Public Const AIR As String = "航空便 利用"
            Public Const JR As String = "JR 利用"
            Public Const None As String = "利用なし"
            Public Class ShortFormat
                Public Const AIR As String = "航空便"
                Public Const JR As String = "JR"
                Public Const None As String = ""
            End Class
        End Class
    End Class

    Public Class AIRLINE
        Public Class Code
            Public Const ANA As String = "A"
            Public Const JAL As String = "J"
        End Class
        Public Class Name
            Public Const ANA As String = "ANA"
            Public Const JAL As String = "JAL"
        End Class
    End Class

    Public Class PREFECTURES_NO
        Public Class Code
            Public Const PREFECTURES_NO01 As String = "01"
            Public Const PREFECTURES_NO02 As String = "02"
            Public Const PREFECTURES_NO03 As String = "03"
            Public Const PREFECTURES_NO04 As String = "04"
            Public Const PREFECTURES_NO05 As String = "05"
            Public Const PREFECTURES_NO06 As String = "06"
            Public Const PREFECTURES_NO07 As String = "07"
            Public Const PREFECTURES_NO08 As String = "08"
            Public Const PREFECTURES_NO09 As String = "09"
            Public Const PREFECTURES_NO10 As String = "10"
            Public Const PREFECTURES_NO11 As String = "11"
            Public Const PREFECTURES_NO12 As String = "12"
            Public Const PREFECTURES_NO13 As String = "13"
            Public Const PREFECTURES_NO14 As String = "14"
            Public Const PREFECTURES_NO15 As String = "15"
            Public Const PREFECTURES_NO16 As String = "16"
            Public Const PREFECTURES_NO17 As String = "17"
            Public Const PREFECTURES_NO18 As String = "18"
            Public Const PREFECTURES_NO19 As String = "19"
            Public Const PREFECTURES_NO20 As String = "20"
            Public Const PREFECTURES_NO21 As String = "21"
            Public Const PREFECTURES_NO22 As String = "22"
            Public Const PREFECTURES_NO23 As String = "23"
            Public Const PREFECTURES_NO24 As String = "24"
            Public Const PREFECTURES_NO25 As String = "25"
            Public Const PREFECTURES_NO26 As String = "26"
            Public Const PREFECTURES_NO27 As String = "27"
            Public Const PREFECTURES_NO28 As String = "28"
            Public Const PREFECTURES_NO29 As String = "29"
            Public Const PREFECTURES_NO30 As String = "30"
            Public Const PREFECTURES_NO31 As String = "31"
            Public Const PREFECTURES_NO32 As String = "32"
            Public Const PREFECTURES_NO33 As String = "33"
            Public Const PREFECTURES_NO34 As String = "34"
            Public Const PREFECTURES_NO35 As String = "35"
            Public Const PREFECTURES_NO36 As String = "36"
            Public Const PREFECTURES_NO37 As String = "37"
            Public Const PREFECTURES_NO38 As String = "38"
            Public Const PREFECTURES_NO39 As String = "39"
            Public Const PREFECTURES_NO40 As String = "40"
            Public Const PREFECTURES_NO41 As String = "41"
            Public Const PREFECTURES_NO42 As String = "42"
            Public Const PREFECTURES_NO43 As String = "43"
            Public Const PREFECTURES_NO44 As String = "44"
            Public Const PREFECTURES_NO45 As String = "45"
            Public Const PREFECTURES_NO46 As String = "46"
            Public Const PREFECTURES_NO47 As String = "47"
        End Class
        Public Class Name
            Public Const PREFECTURES_NO01 As String = "北海道"
            Public Const PREFECTURES_NO02 As String = "青森県"
            Public Const PREFECTURES_NO03 As String = "岩手県"
            Public Const PREFECTURES_NO04 As String = "宮城県"
            Public Const PREFECTURES_NO05 As String = "秋田県"
            Public Const PREFECTURES_NO06 As String = "山形県"
            Public Const PREFECTURES_NO07 As String = "福島県"
            Public Const PREFECTURES_NO08 As String = "茨城県"
            Public Const PREFECTURES_NO09 As String = "栃木県"
            Public Const PREFECTURES_NO10 As String = "群馬県"
            Public Const PREFECTURES_NO11 As String = "埼玉県"
            Public Const PREFECTURES_NO12 As String = "千葉県"
            Public Const PREFECTURES_NO13 As String = "東京都"
            Public Const PREFECTURES_NO14 As String = "神奈川県"
            Public Const PREFECTURES_NO15 As String = "新潟県"
            Public Const PREFECTURES_NO16 As String = "富山県"
            Public Const PREFECTURES_NO17 As String = "石川県"
            Public Const PREFECTURES_NO18 As String = "福井県"
            Public Const PREFECTURES_NO19 As String = "山梨県"
            Public Const PREFECTURES_NO20 As String = "長野県"
            Public Const PREFECTURES_NO21 As String = "岐阜県"
            Public Const PREFECTURES_NO22 As String = "静岡県"
            Public Const PREFECTURES_NO23 As String = "愛知県"
            Public Const PREFECTURES_NO24 As String = "三重県"
            Public Const PREFECTURES_NO25 As String = "滋賀県"
            Public Const PREFECTURES_NO26 As String = "京都府"
            Public Const PREFECTURES_NO27 As String = "大阪府"
            Public Const PREFECTURES_NO28 As String = "兵庫県"
            Public Const PREFECTURES_NO29 As String = "奈良県"
            Public Const PREFECTURES_NO30 As String = "和歌山県"
            Public Const PREFECTURES_NO31 As String = "鳥取県"
            Public Const PREFECTURES_NO32 As String = "島根県"
            Public Const PREFECTURES_NO33 As String = "岡山県"
            Public Const PREFECTURES_NO34 As String = "広島県"
            Public Const PREFECTURES_NO35 As String = "山口県"
            Public Const PREFECTURES_NO36 As String = "徳島県"
            Public Const PREFECTURES_NO37 As String = "香川県"
            Public Const PREFECTURES_NO38 As String = "愛媛県"
            Public Const PREFECTURES_NO39 As String = "高知県"
            Public Const PREFECTURES_NO40 As String = "福岡県"
            Public Const PREFECTURES_NO41 As String = "佐賀県"
            Public Const PREFECTURES_NO42 As String = "長崎県"
            Public Const PREFECTURES_NO43 As String = "熊本県"
            Public Const PREFECTURES_NO44 As String = "大分県"
            Public Const PREFECTURES_NO45 As String = "宮崎県"
            Public Const PREFECTURES_NO46 As String = "鹿児島県"
            Public Const PREFECTURES_NO47 As String = "沖縄県"
        End Class
    End Class

    Public Class MS_CODE
        'コードMS
        Public Const O_DATE As String = "01"
        Public Const F_DATE As String = "02"
        Public Const CHECK_IN As String = "03"
        Public Const CHECK_OUT As String = "04"
        Public Const ROOM_TYPE As String = "05"
    End Class

    Public Class ROOM_TYPE
        Public Const [Single] As String = "シングル"
        Public Const Twin As String = "ツイン"
        Public Const Triple As String = "トリプル"
        Public Const OtherRoom As String = "ドクターと別室(シングルユース)"
        Public Class ShortFormat
            Public Const [Single] As String = "シングル"
            Public Const Twin As String = "ツイン"
            Public Const Triple As String = "トリプル"
            Public Const OtherRoom As String = "別室"
        End Class
    End Class

End Class
