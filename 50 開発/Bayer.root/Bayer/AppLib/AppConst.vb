Public Class AppConst

    Public Class RECORD_KUBUN
        '�f�[�^�敪
        Public Class Code
            Public Const Insert As String = "I"
            Public Const Update As String = "U"
            Public Const Cancel As String = "C"
        End Class
        Public Class Name
            Public Const Insert As String = "�o�^"
            Public Const Update As String = "�ύX"
            Public Const Cancel As String = "���"
        End Class
    End Class
     
    Public Class STATUS_TEHAI
        '��z��
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
            Public Const Fuyo As String = "��z�s�v"
            Public Const Input As String = "�V�K�o�^"
            Public Const Change As String = "�ύX"
            Public Const Cancel As String = "�Q�����"
            Public Const HotelNG As String = "�h����z��"
            Public Const KotsuNG As String = "������ʎ�z��"
            Public Const HotelNG_KotsuNG As String = "�h���E������ʎ�z��"
            Public Const HotelOK_KotsuNG As String = "�h����z�ρE������ʎ�z��"
            Public Const HotelNG_KotsuOK As String = "�h����z���E������ʎ�z��"
            Public Const KotsuOK As String = "������ʎ�z��"
            Public Const HotelOK As String = "�h����z��"
            Public Const HotelOK_KotsuOK As String = "�h���E������ʎ�z��"
            Public Const OKToFuyo As String = "��z�ό� ��z�s�v"
            Public Const OkToChange As String = "��z�ό� �ύX"
            Public Const OKToCancel As String = "��z�ό� �L�����Z��"
            Public Const EndToFuyo As String = "���ρE������ ��z�s�v"
            Public Const EndToChange As String = "���ρE������ �ύX"
            Public Const EndToCancel As String = "���ρE������ �L�����Z��"
        End Class
    End Class

    Public Class TEHAI
        '��z
        Public Const DefaultValue As String = "2"
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�˗�����"
            Public Const No As String = "�˗����Ȃ�"
            Public Class ShortFormat
                Public Const Yes As String = "�L"
                Public Const No As String = "��"
            End Class
        End Class
    End Class

    Public Class PARTY
        '��������
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�Q������"
            Public Const No As String = "�Q�����Ȃ�"
            Public Class ShortFormat
                Public Const Yes As String = "�Q��"
                Public Const No As String = "�s�Q��"
            End Class
        End Class
    End Class

    Public Class SEAT
        '���ȏꏊ
        Public Class Code
            Public Const Window As String = "1"
            Public Const Aisle As String = "2"
        End Class
        Public Class Name
            Public Const Window As String = "����"
            Public Const Aisle As String = "�ʘH��"
        End Class
    End Class

    Public Class SEATCLASS
        '���ȋ敪
        Public Class Code
            Public Const Regular As String = "1"
            Public Const Premium As String = "2"
            Public Const Unreserved As String = "3"
        End Class
        Public Class Name
            Public Const Regular As String = "���ʐ�"
            Public Const Premium As String = "�v���~�A���E�N���XJ�E�O���[��"
            Public Const Unreserved As String = "���R��"
        End Class
    End Class

    Public Class SMOKING
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�i��"
            Public Const No As String = "�։�"
        End Class
    End Class

    Public Class SEX
        '����
        Public Class Code
            Public Const Male As String = "M"
            Public Const Female As String = "F"
        End Class
        Public Class Name
            Public Const Male As String = "�j��"
            Public Const Female As String = "����"
        End Class
    End Class
     
End Class
