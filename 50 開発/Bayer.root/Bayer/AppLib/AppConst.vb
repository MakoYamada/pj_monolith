Public Class AppConst

    Public Class UserType
        '���[�U���
        Public Const Dr As String = "D"
        Public Const Member As String = "M"
        Public Const Admin As String = "A"
        'Public Const Manage As String = "3"
    End Class

    Public Class INS_TYPE
        '�o�^��
        Public Class Code
            Public Const Member As String = "M"
            Public Const Dr As String = "D"
            Public Const Admin As String = "A"
        End Class
        Public Class Name
            Public Const Member As String = "�c�ƒS��"
            Public Const Dr As String = "�h�N�^�["
            Public Const Admin As String = "�g�b�v�c�A�["
        End Class
    End Class

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

    Public Class LOGIN_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "0"
        End Class
        Public Class Name
            Public Const Yes As String = "��"
            Public Const No As String = "��"
        End Class
    End Class

    Public Class ATTEND
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
            Public Const Mi As String = "3"
        End Class
        Public Class Name
            Public Const Yes As String = "����"
            Public Const No As String = "���Ȃ�"
            Public Const Mi As String = "����"
        End Class
    End Class

    Public Class DATA_NO
        '�o�^�ԍ�
        Public Const Head As String = "D-"
        Public Const NumberLength As Integer = 4
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

    Public Class STATUS_PAYMENT
        '�x����
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
            Public Const Fuyo As String = "�x���s�v"
            Public Const Input As String = "�\����t"
            Public Const OK As String = "���z�m��"
            Public Const BillPrint As String = "���������"
            Public Const OKToFuyo As String = "��z�ό� �x���s�v"
            Public Const OkToChange As String = "��z�ό� �ύX"
            Public Const OKToCancel As String = "��z�ό� �L�����Z��"
            Public Const CardEnd As String = "�J�[�h���ϊ���"
            Public Const BillEnd As String = "��������"
            Public Const EndToFuyo As String = "���ρE������ �x���s�v"
            Public Const EndToChange As String = "���ρE������ �ύX"
            Public Const EndToCancel As String = "���ρE������ �L�����Z��"
            Public Const EndToNG As String = "���ώ��s"
        End Class
    End Class

    Public Class PAYMENT_METHOD
        Public Class Code
            Public Const Card As String = "C"
            Public Const Bank As String = "B"
        End Class
        Public Class Name
            Public Const Card As String = "�N���W�b�g�J�[�h"
            Public Const Bank As String = "��s�U��"
            Public Class ShortFormat
                Public Const Card As String = "�J�[�h"
                Public Const Bank As String = "�U��"
            End Class
        End Class
    End Class

    Public Class SANKA_KUBUN
        '�Q���敪
        Public Class Code
            Public Const Speaker As String = "1"
            Public Const Listener As String = "2"
        End Class
        Public Class Name
            Public Const Speaker As String = "�u�t�E����"
            Public Const Listener As String = "�Q��Dr."
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

    Public Class PUBLIC_SERVANT
        '������/�������
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "������"
            Public Const No As String = "�������"
        End Class
    End Class

    Public Class SECANDARY_USE
        '�摜�y�є����̓񎟎g�p
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "���ӂ��܂�"
            Public Const No As String = "���ӂ��܂��� "
            Public Class ShortFormat
                Public Const Yes As String = "����"
                Public Const No As String = ""
            End Class
        End Class
    End Class

    Public Class WETLAB_FLAG
        '�E�F�b�g���{
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

    Public Class WETLAB_COURSE
        '�E�F�b�g���{ �R�[�X
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
        '�h����
        Public Class Code
            Public Const Before As String = "01"
            Public Const BeforeTojitsu As String = "02"
            Public Const Tojitsu As String = "03"
            Public Const TojitsuAfter As String = "04"
            Public Const After As String = "05"
        End Class
        Public Class Name
            Public Const Before As String = "�O��"
            Public Const BeforeTojitsu As String = "�O���{������"
            Public Const Tojitsu As String = "������"
            Public Const TojitsuAfter As String = "�������{�㔑"
            Public Const After As String = "�㔑"
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

    Public Class HOTEL_SMOKING
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�i��"
            Public Const No As String = "�։�"
        End Class
    End Class

    Public Class KOTSU_SMOKING
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�i����"
            Public Const No As String = "�։���"
        End Class
    End Class

    Public Class SEND_SAKI
        Public Class Code
            Public Const DrOffice As String = "1"
            Public Const DrHome As String = "2"
            Public Const MemberOffice As String = "3"
        End Class
        Public Class Name
            Public Const DrOffice As String = "�Ζ���"
            Public Const DrHome As String = "����"
            Public Const MemberOffice As String = "�c�ƒS���ҏ����I�t�B�X"
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
            Public Const Yes As String = "��"
            Public Const No As String = "�s��"
        End Class
    End Class

    Public Class JR_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "0"
        End Class
        Public Class Name
            Public Const Yes As String = "��"
            Public Const No As String = "�s��"
        End Class
    End Class

    Public Class ACCOMPANY_FLAG
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = ""
        End Class
        Public Class Name
            Public Const Yes As String = "�L"
            Public Const No As String = "��"
        End Class
    End Class

    Public Class ACCOMPANY_STAY
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�L"
            Public Const No As String = "��"
        End Class
    End Class

    Public Class ACCOMPANY_SAME_ROOM
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�h�N�^�[�Ɠ���"
            Public Const No As String = "�h�N�^�[�ƕʎ�"
            Public Class ShortFormat
                Public Const Yes As String = "����"
                Public Const No As String = "�ʎ�"
            End Class
        End Class
    End Class

    Public Class ACCOMPANY_STAY_DATE
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = ""
        End Class
        Public Class Name
            Public Const Yes As String = "�h�N�^�[�Ɠ�����"
            Public Const No As String = "�h�N�^�[�ƕʓ���"
        End Class
    End Class

    Public Class ACCOMPANY_BED
        Public Class Code
            Public Const Yes As String = "1"
            Public Const No As String = "2"
        End Class
        Public Class Name
            Public Const Yes As String = "�K�v"
            Public Const No As String = "�s�v"
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

    Public Class Mail
        '���[������
        Public Const Signature As String = "---------------------�V�X�e���y�ь�ʏh���Ɋւ���₢���킹��-------------------------" & vbNewLine _
                                          & "Edwards Heart Valve Seminar 2013 �^�c������" & vbNewLine _
                                          & "�g�b�v�c�A�[�������@�l�����ƕ� �i�S���F���c�E�k�ځj" & vbNewLine _
                                          & vbNewLine _
                                          & "��103-0025�@�����s��������{�����꒬2�|10�|5 �Z�F�������꒬�r��2�K" & vbNewLine _
                                          & "TEL: 03-6667-0591�@FAX: 03-6667-0565" & vbNewLine _
                                          & "MAIL: edwards_2013@toptour.co.jp" & vbNewLine _
                                          & vbNewLine _
                                          & "�c�Ǝ��ԁF���`��10:00-17:30�@�y���j�� �x��" & vbNewLine _
                                          & "-------------------------------------------------------------------------------------"

        Public Class Result
            '���[�����M�t���O
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
            Public Const AIR As String = "�q��� ���p"
            Public Const JR As String = "JR ���p"
            Public Const None As String = "���p�Ȃ�"
            Public Class ShortFormat
                Public Const AIR As String = "�q���"
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
            Public Const PREFECTURES_NO01 As String = "�k�C��"
            Public Const PREFECTURES_NO02 As String = "�X��"
            Public Const PREFECTURES_NO03 As String = "��茧"
            Public Const PREFECTURES_NO04 As String = "�{�錧"
            Public Const PREFECTURES_NO05 As String = "�H�c��"
            Public Const PREFECTURES_NO06 As String = "�R�`��"
            Public Const PREFECTURES_NO07 As String = "������"
            Public Const PREFECTURES_NO08 As String = "��錧"
            Public Const PREFECTURES_NO09 As String = "�Ȗ،�"
            Public Const PREFECTURES_NO10 As String = "�Q�n��"
            Public Const PREFECTURES_NO11 As String = "��ʌ�"
            Public Const PREFECTURES_NO12 As String = "��t��"
            Public Const PREFECTURES_NO13 As String = "�����s"
            Public Const PREFECTURES_NO14 As String = "�_�ސ쌧"
            Public Const PREFECTURES_NO15 As String = "�V����"
            Public Const PREFECTURES_NO16 As String = "�x�R��"
            Public Const PREFECTURES_NO17 As String = "�ΐ쌧"
            Public Const PREFECTURES_NO18 As String = "���䌧"
            Public Const PREFECTURES_NO19 As String = "�R����"
            Public Const PREFECTURES_NO20 As String = "���쌧"
            Public Const PREFECTURES_NO21 As String = "�򕌌�"
            Public Const PREFECTURES_NO22 As String = "�É���"
            Public Const PREFECTURES_NO23 As String = "���m��"
            Public Const PREFECTURES_NO24 As String = "�O�d��"
            Public Const PREFECTURES_NO25 As String = "���ꌧ"
            Public Const PREFECTURES_NO26 As String = "���s�{"
            Public Const PREFECTURES_NO27 As String = "���{"
            Public Const PREFECTURES_NO28 As String = "���Ɍ�"
            Public Const PREFECTURES_NO29 As String = "�ޗǌ�"
            Public Const PREFECTURES_NO30 As String = "�a�̎R��"
            Public Const PREFECTURES_NO31 As String = "���挧"
            Public Const PREFECTURES_NO32 As String = "������"
            Public Const PREFECTURES_NO33 As String = "���R��"
            Public Const PREFECTURES_NO34 As String = "�L����"
            Public Const PREFECTURES_NO35 As String = "�R����"
            Public Const PREFECTURES_NO36 As String = "������"
            Public Const PREFECTURES_NO37 As String = "���쌧"
            Public Const PREFECTURES_NO38 As String = "���Q��"
            Public Const PREFECTURES_NO39 As String = "���m��"
            Public Const PREFECTURES_NO40 As String = "������"
            Public Const PREFECTURES_NO41 As String = "���ꌧ"
            Public Const PREFECTURES_NO42 As String = "���茧"
            Public Const PREFECTURES_NO43 As String = "�F�{��"
            Public Const PREFECTURES_NO44 As String = "�啪��"
            Public Const PREFECTURES_NO45 As String = "�{�茧"
            Public Const PREFECTURES_NO46 As String = "��������"
            Public Const PREFECTURES_NO47 As String = "���ꌧ"
        End Class
    End Class

    Public Class MS_CODE
        '�R�[�hMS
        Public Const O_DATE As String = "01"
        Public Const F_DATE As String = "02"
        Public Const CHECK_IN As String = "03"
        Public Const CHECK_OUT As String = "04"
        Public Const ROOM_TYPE As String = "05"
    End Class

    Public Class ROOM_TYPE
        Public Const [Single] As String = "�V���O��"
        Public Const Twin As String = "�c�C��"
        Public Const Triple As String = "�g���v��"
        Public Const OtherRoom As String = "�h�N�^�[�ƕʎ�(�V���O�����[�X)"
        Public Class ShortFormat
            Public Const [Single] As String = "�V���O��"
            Public Const Twin As String = "�c�C��"
            Public Const Triple As String = "�g���v��"
            Public Const OtherRoom As String = "�ʎ�"
        End Class
    End Class

End Class
