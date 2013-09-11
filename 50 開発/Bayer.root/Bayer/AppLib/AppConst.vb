Public Class AppConst

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

        Public Class ANS_ROOM_TYPE
            '宿泊部屋タイプ（回答）
            Public Class Code
                Public Const [Single] As String = "51"
                Public Const Twin As String = "52"
                Public Const Triple As String = "53"
            End Class
            Public Class Name
                Public Const [Single] As String = "シングル"
                Public Const Twin As String = "ツイン"
                Public Const Triple As String = "トリプル"
            End Class
        End Class

        Public Class REQ_HOTEL_SMOKING
            '宿泊ホテル喫煙（依頼）
            Public Class Code
                Public Const No As String = "1"
                Public Const Deodorant As String = "2"
                Public Const Yes As String = "3"
            End Class
            Public Class Name
                Public Const No As String = "禁煙"
                Public Const Deodorant As String = "禁煙（消臭対応の可能性があります）"
                Public Const Yes As String = "喫煙"
            End Class
        End Class

        Public Class ANS_HOTEL_SMOKING
            '宿泊ホテル喫煙（回答）
            Inherits REQ_HOTEL_SMOKING
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

        Public Class REQ_O_KOTSUKIKAN
            '往路：交通機関（依頼）
            Public Class Code
                Public Const JR As String = "01"
                Public Const Air As String = "02"
                Public Const Railway As String = "03"
                Public Const Ship As String = "04"
                Public Const Bus As String = "05"
            End Class
            Public Class Name
                Public Const JR As String = "JR"
                Public Const Air As String = "航空"
                Public Const Railway As String = "私鉄"
                Public Const Ship As String = "船舶"
                Public Const Bus As String = "バス"
            End Class
        End Class

        Public Class REQ_F_KOTSUKIKAN
            '復路：交通機関（依頼）
            Inherits REQ_O_KOTSUKIKAN
        End Class

        Public Class ANS_O_KOTSUKIKAN
            '往路：交通機関（回答）
            Inherits REQ_O_KOTSUKIKAN
        End Class

        Public Class ANS_F_KOTSUKIKAN
            '復路：交通機関（回答）
            Inherits REQ_F_KOTSUKIKAN
        End Class

        Public Class REQ_O_SEAT
            '往路：座席区分（依頼）
            Public Class Code
                Public Const Reserved As String = "普通席"
                Public Const Green As String = "グリーン席"
                Public Const ClassJ As String = "クラスJ"
                Public Const Premium As String = "プレミアム"
                Public Const FirstClass As String = "ファースト"
                Public Const GranClass As String = "グランクラス"
            End Class
            Public Class Name
                Public Const Reserved As String = "01"
                Public Const Green As String = "02"
                Public Const ClassJ As String = "03"
                Public Const Premium As String = "04"
                Public Const FirstClass As String = "05"
                Public Const GranClass As String = "06"
            End Class
        End Class

        Public Class REQ_F_SEAT
            '復路：座席区分（依頼）
            Inherits REQ_O_SEAT
        End Class

        Public Class ANS_O_SEAT
            '往路：座席区分（回答）
            Inherits REQ_O_SEAT
        End Class

        Public Class ANS_F_SEAT
            '復路：座席区分（回答）
            Inherits REQ_F_SEAT
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

        Public Class KOUEN_KAIJO_LAYOUT
            '世話人会場　要・不要
            Public Class Code
                Public Const School As String = "1"
                Public Const Konoji As String = "2"
                Public Const Other As String = "3"
            End Class
            Public Class Name
                Public Const School As String = "スクール"
                Public Const Konoji As String = "コの字"
                Public Const Other As String = "その他"
            End Class
        End Class

    End Class

End Class
