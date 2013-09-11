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

    Public Class SMOKING
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "喫煙"
            Public Const No As String = "禁煙"
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
     
End Class
