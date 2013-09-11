Public Class AppConst

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

        Public Class ANS_ROOM_TYPE
            '�h�������^�C�v�i�񓚁j
            Public Class Code
                Public Const [Single] As String = "51"
                Public Const Twin As String = "52"
                Public Const Triple As String = "53"
            End Class
            Public Class Name
                Public Const [Single] As String = "�V���O��"
                Public Const Twin As String = "�c�C��"
                Public Const Triple As String = "�g���v��"
            End Class
        End Class

        Public Class REQ_HOTEL_SMOKING
            '�h���z�e���i���i�˗��j
            Public Class Code
                Public Const No As String = "1"
                Public Const Deodorant As String = "2"
                Public Const Yes As String = "3"
            End Class
            Public Class Name
                Public Const No As String = "�։�"
                Public Const Deodorant As String = "�։��i���L�Ή��̉\��������܂��j"
                Public Const Yes As String = "�i��"
            End Class
        End Class

        Public Class ANS_HOTEL_SMOKING
            '�h���z�e���i���i�񓚁j
            Inherits REQ_HOTEL_SMOKING
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

        Public Class REQ_O_KOTSUKIKAN
            '���H�F��ʋ@�ցi�˗��j
            Public Class Code
                Public Const JR As String = "01"
                Public Const Air As String = "02"
                Public Const Railway As String = "03"
                Public Const Ship As String = "04"
                Public Const Bus As String = "05"
            End Class
            Public Class Name
                Public Const JR As String = "JR"
                Public Const Air As String = "�q��"
                Public Const Railway As String = "���S"
                Public Const Ship As String = "�D��"
                Public Const Bus As String = "�o�X"
            End Class
        End Class

        Public Class REQ_F_KOTSUKIKAN
            '���H�F��ʋ@�ցi�˗��j
            Inherits REQ_O_KOTSUKIKAN
        End Class

        Public Class ANS_O_KOTSUKIKAN
            '���H�F��ʋ@�ցi�񓚁j
            Inherits REQ_O_KOTSUKIKAN
        End Class

        Public Class ANS_F_KOTSUKIKAN
            '���H�F��ʋ@�ցi�񓚁j
            Inherits REQ_F_KOTSUKIKAN
        End Class

        Public Class REQ_O_SEAT
            '���H�F���ȋ敪�i�˗��j
            Public Class Code
                Public Const Reserved As String = "���ʐ�"
                Public Const Green As String = "�O���[����"
                Public Const ClassJ As String = "�N���XJ"
                Public Const Premium As String = "�v���~�A��"
                Public Const FirstClass As String = "�t�@�[�X�g"
                Public Const GranClass As String = "�O�����N���X"
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
            '���H�F���ȋ敪�i�˗��j
            Inherits REQ_O_SEAT
        End Class

        Public Class ANS_O_SEAT
            '���H�F���ȋ敪�i�񓚁j
            Inherits REQ_O_SEAT
        End Class

        Public Class ANS_F_SEAT
            '���H�F���ȋ敪�i�񓚁j
            Inherits REQ_F_SEAT
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

        Public Class KOUEN_KAIJO_LAYOUT
            '���b�l���@�v�E�s�v
            Public Class Code
                Public Const School As String = "1"
                Public Const Konoji As String = "2"
                Public Const Other As String = "3"
            End Class
            Public Class Name
                Public Const School As String = "�X�N�[��"
                Public Const Konoji As String = "�R�̎�"
                Public Const Other As String = "���̑�"
            End Class
        End Class

    End Class

End Class
