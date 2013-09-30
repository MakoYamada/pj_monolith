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

    Public Class KOTSUHOTEL

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
            '��z�X�e�[�^�X
            Public Class Request
                '�˗�
                Public Class Code
                    Public Const Tehai As String = "01"
                    Public Const Change As String = "02"
                    Public Const Cancel As String = "03"
                End Class
                Public Class Name
                    Public Const Tehai As String = "�V�K��z�˗�"
                    Public Const Change As String = "�ύX�˗�"
                    Public Const Cancel As String = "����˗�"
                End Class
            End Class
            Public Class Answer
                '��
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
                    Public Const Uketsuke As String = "��t��"
                    Public Const Prepare As String = "��z��"
                    Public Const OK As String = "��z��"
                    Public Const OK_Daian As String = "��Ď�z��"
                    Public Const Changed As String = "�ύX��"
                    Public Const NG As String = "��z�s��"
                    Public Const TicketSend As String = "������"
                    Public Const Canceled As String = "�����"
                End Class
            End Class
        End Class

        Public Class DR_SANKA
            '�Q���^�s�Q��
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�Q��"
                Public Const No As String = "�s�Q��"
            End Class
        End Class

        Public Class TEHAI_HOTEL
            '�h����z
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "��]����"
                Public Const No As String = "��]���Ȃ�"
            End Class
        End Class

        Public Class HOTEL_IRAINAIYOU
            '�h���˗����e
            Public Class Code
                Public Const Tehai As String = "01"
                Public Const Change As String = "02"
                Public Const Cancel As String = "03"
            End Class
            Public Class Name
                Public Const Tehai As String = "��z�˗�"
                Public Const Change As String = "�ύX�˗�"
                Public Const Cancel As String = "����˗�"
            End Class
        End Class

        Public Class ANS_STATUS_HOTEL
            '�h���X�e�[�^�X�i�񓚁j
            Public Class Code
                Public Const Prepare As String = "51"
                Public Const OK As String = "52"
                Public Const Canceled As String = "53"
            End Class
            Public Class Name
                Public Const Prepare As String = "��z��"
                Public Const OK As String = "��z��"
                Public Const Canceled As String = "�����"
            End Class
        End Class

        Public Class REQ_O_TEHAI
            '���H�F��ʎ�z
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "��]����"
                Public Const No As String = "��]���Ȃ�"
            End Class
        End Class

        Public Class REQ_F_TEHAI
            '���H�F��ʎ�z
            Inherits REQ_O_TEHAI
        End Class

        Public Class REQ_O_IRAINAIYOU
            '���H�F��ʈ˗����e
            Public Class Code
                Public Const Tehai As String = "01"
                Public Const Change As String = "02"
                Public Const Cancel As String = "03"
            End Class
            Public Class Name
                Public Const Tehai As String = "��z�˗�"
                Public Const Change As String = "�ύX�˗�"
                Public Const Cancel As String = "����˗�"
            End Class
        End Class

        Public Class REQ_F_IRAINAIYOU
            '���H�F��ʈ˗����e�i�˗��j
            Inherits REQ_O_IRAINAIYOU
        End Class

        Public Class ANS_O_STATUS
            '���H�F�񓚃X�e�[�^�X
            Public Class Code
                Public Const Prepare As String = "51"
                Public Const OK As String = "52"
                Public Const Canceled As String = "53"
            End Class
            Public Class Name
                Public Const Prepare As String = "��z��"
                Public Const OK As String = "��z��"
                Public Const Canceled As String = "�����"
            End Class
        End Class

        Public Class ANS_F_STATUS
            '���H�F�񓚃X�e�[�^�X
            Inherits ANS_O_STATUS
        End Class

        Public Class TEHAI_TAXI
            '�^�N�V�[�`�P�b�g
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
            End Class
        End Class

    End Class

    Public Class KAIJO

        Public Class STATUS_TEHAI
            '��z�X�e�[�^�X
            Public Class Code
                Public Const Tehai As String = "01"
                Public Const Change As String = "02"
                Public Const Cancel As String = "03"
            End Class
            Public Class Name
                Public Const Tehai As String = "�V�K"
                Public Const Change As String = "�ύX"
                Public Const Cancel As String = "���"
            End Class
        End Class

        Public Class REQ_STATUS_TEHAI
            '�y�˗��z��z�X�e�[�^�X
            Public Class Code
                Public Const NewRequest As String = "1"
                Public Const Change As String = "2"
                Public Const Cancel As String = "3"
                Public Const After As String = "4"
            End Class
            Public Class Name
                Public Const NewRequest As String = "�V�K��z�˗�"
                Public Const Change As String = "�ύX�˗�"
                Public Const Cancel As String = "����˗�"
                Public Const After As String = "����o�^"
            End Class
        End Class

        Public Class ANS_STATUS_TEHAI
            '�y�񓚁z��z�X�e�[�^�X
            Public Class Code
                Public Const Uketsuke As String = "01"
                Public Const Prepare As String = "02"
                Public Const OK As String = "03"
                Public Const SeisanEnd As String = "04"
            End Class
            Public Class Name
                Public Const Uketsuke As String = "��t��"
                Public Const Prepare As String = "��z��"
                Public Const OK As String = "��z��"
                Public Const SeisanEnd As String = "���Z��"
            End Class
        End Class

        Public Class KOUEN_KAIJO_TEHAI
            '�u�����@�v�E�s�v
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
            End Class
        End Class

        Public Class IKENKOUKAN_KAIJO_TEHAI
            '�ӌ��������@�v�E�s�v
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
            End Class
        End Class

        Public Class IROUKAI_KAIJO_TEHAI
            '�ԘJ����@�v�E�s�v
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
            End Class
        End Class

        Public Class KOUSHI_ROOM_TEHAI
            '�u�t�T���@�v�E�s�v
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
            End Class
        End Class

        Public Class MANAGER_KAIJO_TEHAI
            '���b�l���@�v�E�s�v
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "2"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
            End Class
        End Class

    End Class

    Public Class MS_CODE
        Public Const SEX As String = "01"                   '����
        Public Const KOUEN_KAIJO_LAYOUT As String = "02"    '���C�A�E�g
        Public Const DR_YAKUWARI As String = "03"           '�Q���Җ���
        Public Const REQ_HOTEL_SMOKING As String = "04"     '�˗��F�z�e���i��
        Public Const ANS_HOTEL_SMOKING As String = "05"     '�񓚁F�z�e���i��
        Public Const KOTSUKIKAN As String = "06"            '��ʋ@��
        Public Const SEAT As String = "07"                  '���ȋ敪
        Public Const SEAT_KIBOU As String = "08"            '���Ȋ�]
        Public Const MR_TEHAI As String = "09"              '�Ј��ՐȊ�]
        Public Const MR_HOTEL_SMOKING As String = "10"      '�Ј��z�e���։�
        Public Const ROOM_TYPE As String = "11"             '�h�������^�C�v
    End Class

    Public Class STOP_FLG
        Public Class Code
            Public Const [Stop] As String = "1"
        End Class
        Public Class Name
            Public Const [Stop] As String = "���p��~"
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
                Public Const KENGEN_1 As String = "�������̂P"
                Public Const KENGEN_2 As String = "�������̂Q"
            End Class
        End Class
    End Class

End Class
