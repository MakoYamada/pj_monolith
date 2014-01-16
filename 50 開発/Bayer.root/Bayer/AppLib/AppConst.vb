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

    Public Class SEND_FLAG
        '�f�[�^�敪
        Public Class Code
            Public Const Mi As String = "0"
            Public Const Taisho As String = "1"
            Public Const Sumi As String = "2"
        End Class
        Public Class Name
            Public Const Mi As String = "�����M"
            Public Const Taisho As String = "���M�Ώ�"
            Public Const Sumi As String = "���M��"
            Public Class ShortFormat
                Public Const Mi As String = "��"
                Public Const Taisho As String = "�Ώ�"
                Public Const Sumi As String = "��"
            End Class
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
                    Public Const Tehai As String = "1"
                    Public Const Change As String = "2"
                    Public Const Cancel As String = "3"
                    Public Const Jigo As String = "4"
                End Class
                Public Class Name
                    Public Const Tehai As String = "�V�K��z�˗�"
                    Public Const Change As String = "�ύX�˗�"
                    Public Const Cancel As String = "����˗�"
                    Public Const After As String = "����o�^"
                End Class
                Public Class ShortName
                    Public Const Tehai As String = "�V�K"
                    Public Const Change As String = "�ύX"
                    Public Const Cancel As String = "���"
                    Public Const After As String = "����"
                End Class
            End Class
            Public Class Answer
                '��
                Public Class Code
                    Public Const NewTehai As String = "0"
                    Public Const Uketsuke As String = "1"
                    Public Const Prepare As String = "2"
                    Public Const OK As String = "3"
                    Public Const TicketSend As String = "4"
                    Public Const Canceled As String = "5"
                    Public Const Fuka As String = "6"
                End Class
                Public Class Name
                    Public Const NewTehai As String = "�V��"
                    Public Const Uketsuke As String = "��t��"
                    Public Const Prepare As String = "��z��"
                    Public Const OK As String = "��z��"
                    Public Const TicketSend As String = "������"
                    Public Const Canceled As String = "�����"
                    Public Const Fuka As String = "��z�s��"
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
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "��]����"
                Public Const No As String = "��]���Ȃ�"
            End Class
            Public Class Mark
                Public Const Yes As String = "��"
                Public Const No As String = "��"
            End Class
        End Class

        Public Class HOTEL_IRAINAIYOU
            '�h���˗����e
            Public Class Code
                Public Const Tehai As String = "1"
                Public Const Change As String = "2"
                Public Const Cancel As String = "3"
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
                Public Const Prepare As String = "1"
                Public Const OK As String = "2"
                Public Const Canceled As String = "3"
                Public Const Fuka As String = "4"
            End Class
            Public Class Name
                Public Const Prepare As String = "��z��"
                Public Const OK As String = "��z��"
                Public Const Canceled As String = "�����"
                Public Const Fuka As String = "��z�s��"
            End Class
        End Class

        Public Class REQ_O_TEHAI
            '���H�F��ʎ�z
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "��]����"
                Public Const No As String = "��]���Ȃ�"
            End Class
            Public Class Mark
                Public Const Yes As String = "��"
                Public Const No As String = "��"
            End Class
        End Class

        Public Class REQ_F_TEHAI
            '���H�F��ʎ�z
            Inherits REQ_O_TEHAI
        End Class

        Public Class REQ_O_IRAINAIYOU
            '���H�F��ʈ˗����e
            Public Class Code
                Public Const Mishitei As String = " "
                Public Const Tehai As String = "1"
                Public Const Change As String = "2"
                Public Const Cancel As String = "3"
            End Class
            Public Class Name
                Public Const Mishitei As String = "���w��"
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
                Public Const Prepare As String = "1"
                Public Const OK As String = "2"
                Public Const Daian As String = "3"
                Public Const Canceled As String = "4"
                Public Const Fuka As String = "5"
            End Class
            Public Class Name
                Public Const Prepare As String = "��z��"
                Public Const OK As String = "��z��"
                Public Const Daian As String = "��Ď�z��"
                Public Const Canceled As String = "�����"
                Public Const Fuka As String = "��z�s��"
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
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "��]����"
                Public Const No As String = "��]���Ȃ�"
            End Class
            Public Class Mark
                Public Const Yes As String = "��"
                Public Const No As String = "��"
            End Class
        End Class

        Public Class TAXI_HAKKO
            '���s�t���O
            Public Class Code
                Public Const Mi As String = "0"
                Public Const Taisho As String = "1"
                Public Const Sumi As String = "2"
            End Class
            Public Class Name
                Public Const Mi As String = "�����s"
                Public Const Taisho As String = "���s�Ώ�"
                Public Const Sumi As String = "���s��"
            End Class
        End Class

        Public Class ANS_MR_O_TEHAI
            '�Ј����H�F�񓚃X�e�[�^�X
            Public Class Code
                Public Const Side As String = "1"
                Public Const DifferntSeat As String = "2"
                Public Const DifferntTraffic As String = "3"
                Public Const No = "9"
            End Class
            Public Class Name
                Public Const Side As String = "�אȂɂĎ�z��"
                Public Const DifferntSeat As String = "�ʐ�"
                Public Const DifferntTraffic As String = "�ʕ�"
                Public Const No = "��z����"
            End Class
        End Class

        Public Class ANS_MR_F_TEHAI
            '�Ј����H�F�񓚃X�e�[�^�X
            Public Class Code
                Public Const Side As String = "1"
                Public Const DifferntSeat As String = "2"
                Public Const DifferntTraffic As String = "3"
                Public Const No = "9"
            End Class
            Public Class Name
                Public Const Side As String = "�א�"
                Public Const DifferntSeat As String = "�ʐ�"
                Public Const DifferntTraffic As String = "�ʕ�"
                Public Const No = "��z����"
            End Class
        End Class

    End Class

    Public Class KAIJO

        Public Class KIDOKU_FLG
            '�V�����@���ǁE����
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "����"
                Public Const No As String = "����"
            End Class
        End Class

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
                Public Const Mitsumori As String = "1"
                Public Const NewRequest As String = "2"
                Public Const Change As String = "3"
                Public Const Cancel As String = "4"
                Public Const After As String = "5"
            End Class
            Public Class Name
                Public Const Mitsumori As String = "���ψ˗�"
                Public Const NewRequest As String = "�V�K��z�˗�"
                Public Const Change As String = "�ύX�˗�"
                Public Const Cancel As String = "����˗�"
                Public Const After As String = "����o�^"
            End Class
        End Class

        Public Class ANS_STATUS_TEHAI
            '�y�񓚁z��z�X�e�[�^�X
            Public Class Code
                Public Const NewTehai As String = ""
                Public Const KaijoSearch As String = "1"
                Public Const ShoninIrai As String = "2"
                Public Const KaijoKettei As String = "3"
                Public Const Cancel As String = "4"
                Public Const ToriatsukaiFuka As String = "5"
                Public Const AkiNashi As String = "6"
            End Class
            Public Class Name
                Public Const NewTehai As String = "�V��"
                Public Const KaijoSearch As String = "��ꌟ����"
                Public Const ShoninIrai As String = "���F�˗�"
                Public Const KaijoKettei As String = "��ꌈ���"
                Public Const Cancel As String = "�����"
                Public Const ToriatsukaiFuka As String = "�戵�s��"
                Public Const AkiNashi As String = "�󂫖���(�v���k)"
            End Class
        End Class

        Public Class SRM_HACYU_KBN
            'SRM�����敪
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "SRM����"
                Public Const No As String = "SRM�����ȊO"
            End Class
        End Class

        Public Class KOUEN_KAIJO_TEHAI
            '�u�����@�v�E�s�v
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "�v"
                Public Const No As String = "�s�v"
                Public Class ShortFormat
                    Public Const Yes As String = "�v"
                    Public Const No As String = "�s"
                End Class
            End Class
        End Class

        Public Class SHAIN_ROOM_TEHAI
            '�Ј��T���@�v�E�s�v
            Inherits KOUEN_KAIJO_TEHAI
        End Class

        Public Class IKENKOUKAN_KAIJO_TEHAI
            '�ӌ��������@�v�E�s�v
            Inherits KOUEN_KAIJO_TEHAI
        End Class

        Public Class IROUKAI_KAIJO_TEHAI
            '�ԘJ����@�v�E�s�v
            Inherits KOUEN_KAIJO_TEHAI
        End Class

        Public Class KOUSHI_ROOM_TEHAI
            '�u�t�T���@�v�E�s�v
            Inherits KOUEN_KAIJO_TEHAI
        End Class

        Public Class MANAGER_KAIJO_TEHAI
            '���b�l���@�v�E�s�v
            Inherits KOUEN_KAIJO_TEHAI
        End Class

    End Class

    Public Class KOUENKAI
        Public Class KIDOKU_FLG
            '�V�����@���ǁE����
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "����"
                Public Const No As String = "����"
            End Class
        End Class

        Public Class TORIKESHI_FLG
            '����t���O
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "�����"
                Public Const No As String = "�L��"
            End Class
        End Class
    End Class

    Public Class SEISAN
        Public Class SHOUNIN_KUBUN
            '���F�敪
            Public Class Code
                Public Const SHOUNIN As String = "0"
                Public Const HININ As String = "1"
                Public Const Mi As String = "9"          '�����I�Ɏg�p
            End Class
            Public Class Name
                Public Const SHOUNIN As String = "���F"
                Public Const HININ As String = "�۔F"
                Public Const Mi As String = "(�񓚂Ȃ�)" '�����I�Ɏg�p
            End Class
        End Class

        Public Class SEISAN_KANRYO
            '���Z����
            Public Class Code
                Public Const Mi As String = "0"
                Public Const Kanryo As String = "1"
            End Class
            Public Class Name
                Public Const Mi As String = ""
                Public Const Kanryo As String = "����"
            End Class
        End Class
    End Class

    Public Class COST
        Public Class SAP_FLAG
            'SAP�t���O
            Public Class Code
                Public Const Mi As String = "0"
                Public Const Sumi As String = "1"
            End Class
            Public Class Name
                Public Const Mi As String = "���쐬"
                Public Const Sumi As String = "�쐬��"
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
        Public Const SEAT_KIBOU As String = "08"            '�񓚁F���Ȋ�]
        Public Const REQ_MR_TEHAI As String = "09"          '�˗��F�Ј����H��z
        Public Const MR_HOTEL_SMOKING As String = "10"      '�Ј��z�e���։�
        Public Const ROOM_TYPE As String = "11"             '�h�������^�C�v
        Public Const TAXI_KENSHU As String = "12"           '�^�N�`�P����
        Public Const TAXI_TESURYO As String = "13"          '�^�N�`�P�����萔���P��
        Public Const TAXI_SEISAN_TESURYO As String = "14"   '�^�N�`�P���Z�萔��
        Public Const TAXI_KAISHA As String = "15"           '�^�N�V�[���
        Public Const TESURYO As String = "16"               '�萔���i��ʁE�h���j
        Public Const ANS_MR_TEHAI As String = "17"          '�񓚁F�Ј����H��z
        Public Const REQ_SEAT_KIBOU As String = "18"        '�˗��F���Ȋ�]
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
            '����
            Public Class Code
                Public Const Admin As String = "1"
                Public Const User As String = "2"
            End Class
            Public Class Name
                Public Const Admin As String = "�Ǘ���"
                Public Const User As String = "��ʃ��[�U�["
            End Class
        End Class
        Public Class KENGEN_SEISAN
            '���Z����
            Public Class Code
                Public Const Yes As String = "1"
                Public Const No As String = "0"
            End Class
            Public Class Name
                Public Const Yes As String = "�g�p�\"
                Public Const No As String = "�g�p�s��"
                Public Class ShortFormat
                    Public Const Yes As String = "��"
                    Public Const No As String = "�~"
                End Class
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
                Public Const GAMEN As String = "���"
                Public Const BATCH As String = "�o�b�`"
            End Class
        End Class

        Public Class STATUS
            Public Class Code
                Public Const OK As String = "0"
                Public Const NG As String = "1"
            End Class
            Public Class Name
                Public Const OK As String = "����"
                Public Const NG As String = "�G���["
            End Class
        End Class

        Public Class EXPORTIMPORT
            Public Class Code
                Public Const EXPORT As String = "E"
                Public Const IMPORT As String = "I"
            End Class
            Public Class Name
                Public Const EXPORT As String = "���M"
                Public Const IMPORT As String = "��M"
            End Class
        End Class

        Public Class SYORI_NAME
            Public Class BATCH
                Public Class Name
                    Public Const ImportKouenkai As String = "�u�����{���t�@�C���捞"
                    Public Const ImportKaijo As String = "����z�t�@�C���捞"
                    Public Const ExportKaijo As String = "����z�񓚃t�@�C���쐬"
                    Public Const ImportKotsuHotel As String = "��ʏh����z�˗��t�@�C���捞"
                    Public Const ExportKotsuHotel As String = "��ʏh����z�񓚃t�@�C���쐬"
                    Public Const ImportSanka As String = "�Q���ҏo�ȃt�@�C���捞"
                    Public Const ExportSeisan As String = "���Z�t�@�C���쐬"
                    Public Const ImportSeisan As String = "���Z���F���ʃt�@�C���捞"
                End Class
            End Class
            Public Class GAMEN
                Public Class Name
                    Public Const KouenkaiRegist As String = "�u�����{���"
                    Public Const DrRegist As String = "�h���E��ʁE�^�N�V�[�`�P�b�g ��z�˗�"
                    Public Const KaijoRegist As String = "�u����� ��z�E���ψ˗�"
                    Public Const SeisanRegist As String = "���Z���z����"
                    Public Const CostRegist As String = "�R�X�g�Z���^�[�ʔ�p����"
                    Public Const MstShisetsu As String = "�{�݃}�X�^�����e�i���X"
                    Public Const MstUser As String = "TOP�S���҃}�X�^�����e�i���X"
                    Public Const MstCode As String = "�R�[�h�}�X�^�����e�i���X"
                    Public Const MstCostcenter As String = "�R�X�g�Z���^�[�}�X�^�����e�i���X"
                    Public Const TaxiNouhinTorikomi As String = "�^�N�`�P�[�i�f�[�^�捞"
                    Public Const TaxiPrintCsv As String = "�^�N�`�P����f�[�^�쐬"
                    Public Const TaxiScan As String = "�^�N�`�P�X�L�����f�[�^�捞"
                    Public Const TaxiMaintenance As String = "�^�N�`�P�����e�i���X"
                    Public Const TaxiJisseki As String = "�^�N�`�P���уf�[�^�捞"
                    Public Const TaxiSeisanMikanryou As String = "���Z������CSV"
                    Public Const TaxiMiketsu As String = "�^�N�`�P�����o�^"
                    Public Const TaxiMeisaiCsv As String = "�^�N�`�P�Ǘ��䒠"
                End Class
                Public Enum GamenType
                    KouenkaiRegist
                    DrRegist
                    KaijoRegist
                    SeisanRegist
                    CostRegist
                    MstShisetsu
                    MstUser
                    MstCode
                    MstCostcenter
                    TaxiNouhinTorikomi
                    TaxiPrintCsv
                    TaxiScan
                    TaxiMaintenance
                    TaxiMaintenanceRegist
                    TaxiJisseki
                    TaxiSeisanMikanryou
                    TaxiMiketsu
                    TaxiMeisaiCsv
                End Enum
            End Class
        End Class
    End Class

End Class
