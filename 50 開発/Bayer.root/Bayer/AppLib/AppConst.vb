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
                    Public Const Tehai As String = "01"
                    Public Const Change As String = "02"
                    Public Const Cancel As String = "03"
                End Class
                Public Class Name
                    Public Const Tehai As String = "新規手配依頼"
                    Public Const Change As String = "変更依頼"
                    Public Const Cancel As String = "取消依頼"
                End Class
            End Class
            Public Class Answer
                '回答
                Public Class Code
                    Public Const Uketsuke As String = "51"
                    Public Const Prepare As String = "52"
                    Public Const OK As String = "53"
                    Public Const OK_Daian As String = "54"
                    Public Const Changed As String = "55"
                    Public Const NG As String = "56"
                    Public Const TicketSend As String = "57"
                    Public Const Canceled As String = "58"
                End Class
                Public Class Name
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
                Public Const Prepare As String = "51"
                Public Const OK As String = "52"
                Public Const Canceled As String = "53"
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
        End Class

        Public Class REQ_F_TEHAI
            '復路：交通手配
            Inherits REQ_O_TEHAI
        End Class

        Public Class REQ_O_IRAINAIYOU
            '往路：交通依頼内容
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

        Public Class REQ_F_IRAINAIYOU
            '復路：交通依頼内容（依頼）
            Inherits REQ_O_IRAINAIYOU
        End Class

        Public Class ANS_O_STATUS
            '往路：回答ステータス
            Public Class Code
                Public Const Prepare As String = "51"
                Public Const OK As String = "52"
                Public Const Canceled As String = "53"
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
        End Class

    End Class

    Public Class KAIJO

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
                Public Const NewRequest As String = "1"
                Public Const Change As String = "2"
                Public Const Cancel As String = "3"
                Public Const After As String = "4"
            End Class
            Public Class Name
                Public Const NewRequest As String = "新規手配依頼"
                Public Const Change As String = "変更依頼"
                Public Const Cancel As String = "取消依頼"
                Public Const After As String = "事後登録"
            End Class
        End Class

        Public Class ANS_STATUS_TEHAI
            '【回答】手配ステータス
            Public Class Code
                Public Const Uketsuke As String = "01"
                Public Const Prepare As String = "02"
                Public Const OK As String = "03"
                Public Const SeisanEnd As String = "04"
            End Class
            Public Class Name
                Public Const Uketsuke As String = "受付中"
                Public Const Prepare As String = "手配中"
                Public Const OK As String = "手配済"
                Public Const SeisanEnd As String = "精算済"
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
            '????
            Public Class Code
                Public Const KENGEN_1 As String = "1"
                Public Const KENGEN_2 As String = "2"
            End Class
            Public Class Name
                Public Const KENGEN_1 As String = "権限その１"
                Public Const KENGEN_2 As String = "権限その２"
            End Class
        End Class
    End Class

End Class
