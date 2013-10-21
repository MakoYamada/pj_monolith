Public Class AppConst

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

    Public Class SEND_FLAG
        'データ区分
        Public Class Code
            Public Const Mi As String = "0"
            Public Const Taisho As String = "1"
            Public Const Sumi As String = "2"
        End Class
        Public Class Name
            Public Const Mi As String = "未送信"
            Public Const Taisho As String = "送信対象"
            Public Const Sumi As String = "送信済"
        End Class
    End Class

    Public Class KOTSUHOTEL

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

        Public Class STATUS_TEHAI
            '手配ステータス
            Public Class Request
                '依頼
                Public Class Code
                    Public Const Tehai As String = "1"
                    Public Const Change As String = "2"
                    Public Const Cancel As String = "3"
                End Class
                Public Class Name
                    Public Const Tehai As String = "新規手配依頼"
                    Public Const Change As String = "変更依頼"
                    Public Const Cancel As String = "取消依頼"
                End Class
                Public Class ShortName
                    Public Const Tehai As String = "新規"
                    Public Const Change As String = "変更"
                    Public Const Cancel As String = "取消"
                End Class
            End Class
            Public Class Answer
                '回答
                Public Class Code
                    Public Const NewTehai As String = "0"
                    Public Const Uketsuke As String = "1"
                    Public Const Prepare As String = "2"
                    Public Const OK As String = "3"
                    Public Const OK_Daian As String = "4"
                    Public Const Changed As String = "5"
                    Public Const NG As String = "6"
                    Public Const TicketSend As String = "7"
                    Public Const Canceled As String = "8"
                End Class
                Public Class Name
                    Public Const NewTehai As String = "新着"
                    Public Const Uketsuke As String = "受付中"
                    Public Const Prepare As String = "手配中"
                    Public Const OK As String = "手配済"
                    Public Const OK_Daian As String = "代案手配済"
                    Public Const Changed As String = "変更済"
                    Public Const NG As String = "手配不可"
                    Public Const TicketSend As String = "発送済"
                    Public Const Canceled As String = "取消済"
                End Class
            End Class
        End Class

        Public Class DR_SANKA
            '参加／不参加
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "参加"
                Public Const No As String = "不参加"
            End Class
        End Class

        Public Class TEHAI_HOTEL
            '宿泊手配
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "希望する"
                Public Const No As String = "希望しない"
            End Class
            Public Class Mark
                Public Const Yes As String = "●"
                Public Const No As String = "○"
            End Class
        End Class

        Public Class HOTEL_IRAINAIYOU
            '宿泊依頼内容
            Public Class Code
                Public Const Tehai As String = "01"
                Public Const Change As String = "02"
                Public Const Cancel As String = "03"
            End Class
            Public Class Name
                Public Const Tehai As String = "手配依頼"
                Public Const Change As String = "変更依頼"
                Public Const Cancel As String = "取消依頼"
            End Class
        End Class

        Public Class ANS_STATUS_HOTEL
            '宿泊ステータス（回答）
            Public Class Code
                Public Const Prepare As String = "1"
                Public Const OK As String = "2"
                Public Const Canceled As String = "3"
            End Class
            Public Class Name
                Public Const Prepare As String = "手配中"
                Public Const OK As String = "手配済"
                Public Const Canceled As String = "取消済"
            End Class
        End Class

        Public Class REQ_O_TEHAI
            '往路：交通手配
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "希望する"
                Public Const No As String = "希望しない"
            End Class
            Public Class Mark
                Public Const Yes As String = "●"
                Public Const No As String = "○"
            End Class
        End Class

        Public Class REQ_F_TEHAI
            '復路：交通手配
            Inherits REQ_O_TEHAI
        End Class

        Public Class REQ_O_IRAINAIYOU
            '往路：交通依頼内容
            Public Class Code
                Public Const Tehai As String = "1"
                Public Const Change As String = "2"
                Public Const Cancel As String = "3"
            End Class
            Public Class Name
                Public Const Tehai As String = "手配依頼"
                Public Const Change As String = "変更依頼"
                Public Const Cancel As String = "取消依頼"
            End Class
        End Class

        Public Class REQ_F_IRAINAIYOU
            '復路：交通依頼内容（依頼）
            Inherits REQ_O_IRAINAIYOU
        End Class

        Public Class ANS_O_STATUS
            '往路：回答ステータス
            Public Class Code
                Public Const Prepare As String = "1"
                Public Const OK As String = "2"
                Public Const Canceled As String = "3"
            End Class
            Public Class Name
                Public Const Prepare As String = "手配中"
                Public Const OK As String = "手配済"
                Public Const Canceled As String = "取消済"
            End Class
        End Class

        Public Class ANS_F_STATUS
            '復路：回答ステータス
            Inherits ANS_O_STATUS
        End Class

        Public Class TEHAI_TAXI
            'タクシーチケット
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "要"
                Public Const No As String = "不要"
            End Class
            Public Class Mark
                Public Const Yes As String = "●"
                Public Const No As String = "○"
            End Class
        End Class

        Public Class ANS_MR_O_TEHAI
            '社員往路：回答ステータス
            Public Class Code
                Public Const Side As String = "1"
                Public Const DifferntSeat As String = "2"
                Public Const DifferntTraffic As String = "3"
                Public Const No = "9"
            End Class
            Public Class Name
                Public Const Side As String = "ドクターの隣席"
                Public Const DifferntSeat As String = "ドクターと同便別席"
                Public Const DifferntTraffic As String = "ドクターと別便"
                Public Const No = "不要"
            End Class
        End Class

        Public Class ANS_MR_F_TEHAI
            '社員復路：回答ステータス
            Public Class Code
                Public Const Side As String = "1"
                Public Const DifferntSeat As String = "2"
                Public Const DifferntTraffic As String = "3"
                Public Const No = "9"
            End Class
            Public Class Name
                Public Const Side As String = "ドクターの隣席"
                Public Const DifferntSeat As String = "ドクターと同便別席"
                Public Const DifferntTraffic As String = "ドクターと別便"
                Public Const No = "不要"
            End Class
        End Class

    End Class

    Public Class KAIJO

        Public Class KIDOKU_FLG
            '新着情報　既読・未読
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "既読"
                Public Const No As String = "未読"
            End Class
        End Class

        Public Class STATUS_TEHAI
            '手配ステータス
            Public Class Code
                Public Const Tehai As String = "01"
                Public Const Change As String = "02"
                Public Const Cancel As String = "03"
            End Class
            Public Class Name
                Public Const Tehai As String = "新規"
                Public Const Change As String = "変更"
                Public Const Cancel As String = "取消"
            End Class
        End Class

        Public Class REQ_STATUS_TEHAI
            '【依頼】手配ステータス
            Public Class Code
                Public Const Mitsumori As String = "0"
                Public Const NewRequest As String = "1"
                Public Const Change As String = "2"
                Public Const Cancel As String = "3"
                Public Const After As String = "4"
            End Class
            Public Class Name
                Public Const Mitsumori As String = "見積依頼"
                Public Const NewRequest As String = "新規手配依頼"
                Public Const Change As String = "変更依頼"
                Public Const Cancel As String = "取消依頼"
                Public Const After As String = "事後登録"
            End Class
        End Class

        Public Class ANS_STATUS_TEHAI
            '【回答】手配ステータス
            Public Class Code
                Public Const NewTehai As String = ""
                Public Const KaijoSearch As String = "1"
                Public Const UchiawaseSeisanUketsuke As String = "2"
                Public Const SeisanUketsuke As String = "3"
                Public Const TehaiFuka As String = "4"
                Public Const ShoninIrai As String = "5"
                Public Const KaijoKettei As String = "6"
                Public Const SeisanIrai As String = "7"
                Public Const SeisanZumi As String = "8"
            End Class
            Public Class Name
                Public Const NewTehai As String = "新着"
                Public Const KaijoSearch As String = "会場検索中"
                Public Const UchiawaseSeisanUketsuke As String = "打合・精算受付済"
                Public Const SeisanUketsuke As String = "精算のみ受付済"
                Public Const TehaiFuka As String = "手配不可"
                Public Const ShoninIrai As String = "承認依頼中"
                Public Const KaijoKettei As String = "会場決定済"
                Public Const SeisanIrai As String = "精算承認依頼中"
                Public Const SeisanZumi As String = "精算済"
            End Class
        End Class

        Public Class SRM_HACYU_KBN
            'SRM発注区分
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "SRM発注"
                Public Const No As String = "SRM発注以外"
            End Class
        End Class

        Public Class KOUEN_KAIJO_TEHAI
            '講演会場　要・不要
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "要"
                Public Const No As String = "不要"
            End Class
        End Class

        Public Class IKENKOUKAN_KAIJO_TEHAI
            '意見交換会場　要・不要
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "要"
                Public Const No As String = "不要"
            End Class
        End Class

        Public Class IROUKAI_KAIJO_TEHAI
            '慰労会会場　要・不要
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "要"
                Public Const No As String = "不要"
            End Class
        End Class

        Public Class KOUSHI_ROOM_TEHAI
            '講師控室　要・不要
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "要"
                Public Const No As String = "不要"
            End Class
        End Class

        Public Class MANAGER_KAIJO_TEHAI
            '世話人会場　要・不要
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "要"
                Public Const No As String = "不要"
            End Class
        End Class
    End Class

    Public Class KOUENKAI
        Public Class KIDOKU_FLG
            '新着情報　既読・未読
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "既読"
                Public Const No As String = "未読"
            End Class
        End Class

        Public Class TORIKESHI_FLG
            '取消フラグ
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "取消済"
                Public Const No As String = "有効"
            End Class
        End Class
    End Class

    Public Class MS_CODE
        Public Const SEX As String = "01"                   '性別
        Public Const KOUEN_KAIJO_LAYOUT As String = "02"    'レイアウト
        Public Const DR_YAKUWARI As String = "03"           '参加者役割
        Public Const REQ_HOTEL_SMOKING As String = "04"     '依頼：ホテル喫煙
        Public Const ANS_HOTEL_SMOKING As String = "05"     '回答：ホテル喫煙
        Public Const KOTSUKIKAN As String = "06"            '交通機関
        Public Const SEAT As String = "07"                  '座席区分
        Public Const SEAT_KIBOU As String = "08"            '座席希望
        Public Const MR_TEHAI As String = "09"              '社員臨席希望
        Public Const MR_HOTEL_SMOKING As String = "10"      '社員ホテル禁煙
        Public Const ROOM_TYPE As String = "11"             '宿泊部屋タイプ
    End Class

    Public Class STOP_FLG
        Public Class Code
            Public Const [Stop] As String = "1"
        End Class
        Public Class Name
            Public Const [Stop] As String = "利用停止"
        End Class
    End Class

    Public Class MS_USER
        Public Class KENGEN
            '権限
            Public Class Code
                Public Const Admin As String = "1"
                Public Const User As String = "2"
            End Class
            Public Class Name
                Public Const Admin As String = "管理者"
                Public Const User As String = "一般ユーザー"
            End Class
        End Class
    End Class

    Public Class TBL_LOG
        Public Class SYORI_KBN
            Public Class Code
                Public Const GAMEN As String = "1"
                Public Const BATCH As String = "2"
            End Class
            Public Class Name
                Public Const GAMEN As String = "画面"
                Public Const BATCH As String = "バッチ"
            End Class
        End Class

        Public Class STATUS
            Public Class Code
                Public Const OK As String = "0"
                Public Const NG As String = "1"
            End Class
            Public Class Name
                Public Const OK As String = "正常"
                Public Const NG As String = "エラー"
            End Class
        End Class

        Public Class EXPORTIMPORT
            Public Class Code
                Public Const EXPORT As String = "E"
                Public Const IMPORT As String = "I"
            End Class
            Public Class Name
                Public Const EXPORT As String = "送信"
                Public Const IMPORT As String = "受信"
            End Class
        End Class
    End Class

End Class
