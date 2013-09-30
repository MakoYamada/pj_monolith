Imports CommonLib
Imports AppLib
Imports System.Web.UI.WebControls
Imports System.Drawing

Public Class AppModule

    '== �f�[�^�x�[�X�֘A ==
    '�e�[�u������\���̂Ƀf�[�^���Z�b�g
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As TableDef.TBL_KOUENKAI.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO.ToUpper Then TBL_KOUENKAI.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TIME_STAMP.ToUpper Then TBL_KOUENKAI.TIME_STAMP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TORIKESHI_FLG.ToUpper Then TBL_KOUENKAI.TORIKESHI_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG.ToUpper Then TBL_KOUENKAI.KIDOKU_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE.ToUpper Then TBL_KOUENKAI.KOUENKAI_TITLE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME.ToUpper Then TBL_KOUENKAI.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME.ToUpper Then TBL_KOUENKAI.TAXI_PRT_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.FROM_DATE.ToUpper Then TBL_KOUENKAI.FROM_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TO_DATE.ToUpper Then TBL_KOUENKAI.TO_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KAIJO_NAME.ToUpper Then TBL_KOUENKAI.KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME.ToUpper Then TBL_KOUENKAI.SEIHIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T.ToUpper Then TBL_KOUENKAI.INTERNAL_ORDER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF.ToUpper Then TBL_KOUENKAI.INTERNAL_ORDER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_T.ToUpper Then TBL_KOUENKAI.ACCOUNT_CD_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_TF.ToUpper Then TBL_KOUENKAI.ACCOUNT_CD_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ZETIA_CD.ToUpper Then TBL_KOUENKAI.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT.ToUpper Then TBL_KOUENKAI.SANKA_YOTEI_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.BU.ToUpper Then TBL_KOUENKAI.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_PC.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_TEL.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.COST_CENTER.ToUpper Then TBL_KOUENKAI.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.YOSAN_TF.ToUpper Then TBL_KOUENKAI.YOSAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.YOSAN_T.ToUpper Then TBL_KOUENKAI.YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SEND_FLAG.ToUpper Then TBL_KOUENKAI.SEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TTANTO_ID.ToUpper Then TBL_KOUENKAI.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INPUT_DATE.ToUpper Then TBL_KOUENKAI.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INPUT_USER.ToUpper Then TBL_KOUENKAI.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.UPDATE_DATE.ToUpper Then TBL_KOUENKAI.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.UPDATE_USER.ToUpper Then TBL_KOUENKAI.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_ID.ToUpper Then TBL_KOUENKAI.TEHAI_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.REQ_STATUS_TEHAI.ToUpper Then TBL_KOUENKAI.REQ_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_STATUS_TEHAI.ToUpper Then TBL_KOUENKAI.ANS_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TIME_STAMP_BYL.ToUpper Then TBL_KOUENKAI.TIME_STAMP_BYL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TIME_STAMP_TOP.ToUpper Then TBL_KOUENKAI.TIME_STAMP_TOP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SHONIN_NAME.ToUpper Then TBL_KOUENKAI.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SHONIN_DATE.ToUpper Then TBL_KOUENKAI.SHONIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KAISAI_DATE_NOTE.ToUpper Then TBL_KOUENKAI.KAISAI_DATE_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KAISAI_KIBOU_ADDRESS1.ToUpper Then TBL_KOUENKAI.KAISAI_KIBOU_ADDRESS1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KAISAI_KIBOU_ADDRESS2.ToUpper Then TBL_KOUENKAI.KAISAI_KIBOU_ADDRESS2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KAISAI_KIBOU_NOTE.ToUpper Then TBL_KOUENKAI.KAISAI_KIBOU_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUEN_TIME1.ToUpper Then TBL_KOUENKAI.KOUEN_TIME1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUEN_TIME2.ToUpper Then TBL_KOUENKAI.KOUEN_TIME2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUEN_KAIJO_LAYOUT.ToUpper Then TBL_KOUENKAI.KOUEN_KAIJO_LAYOUT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.IKENKOUKAN_KAIJO_TEHAI.ToUpper Then TBL_KOUENKAI.IKENKOUKAN_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.IROUKAI_KAIJO_TEHAI.ToUpper Then TBL_KOUENKAI.IROUKAI_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.IROUKAI_SANKA_YOTEI_CNT.ToUpper Then TBL_KOUENKAI.IROUKAI_SANKA_YOTEI_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUSHI_ROOM_TEHAI.ToUpper Then TBL_KOUENKAI.KOUSHI_ROOM_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SHAIN_ROOM_TEHAI.ToUpper Then TBL_KOUENKAI.SHAIN_ROOM_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.MANAGER_KAIJO_TEHAI.ToUpper Then TBL_KOUENKAI.MANAGER_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KAIJO_URL.ToUpper Then TBL_KOUENKAI.KAIJO_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.OTHER_NOTE.ToUpper Then TBL_KOUENKAI.OTHER_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SENTEI_RIYU.ToUpper Then TBL_KOUENKAI.ANS_SENTEI_RIYU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_MITSUMORI_TF.ToUpper Then TBL_KOUENKAI.ANS_MITSUMORI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_MITSUMORI_T.ToUpper Then TBL_KOUENKAI.ANS_MITSUMORI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_MITSUMORI_TOTAL.ToUpper Then TBL_KOUENKAI.ANS_MITSUMORI_TOTAL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_MITSUMORI_URL.ToUpper Then TBL_KOUENKAI.ANS_MITSUMORI_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SHISETSU_NAME.ToUpper Then TBL_KOUENKAI.ANS_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SHISETSU_ZIP.ToUpper Then TBL_KOUENKAI.ANS_SHISETSU_ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SHISETSU_ADDRESS.ToUpper Then TBL_KOUENKAI.ANS_SHISETSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SHISETSU_TEL.ToUpper Then TBL_KOUENKAI.ANS_SHISETSU_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SHISETSU_URL.ToUpper Then TBL_KOUENKAI.ANS_SHISETSU_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_KOUEN_KAIJO_NAME.ToUpper Then TBL_KOUENKAI.ANS_KOUEN_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_KOUEN_KAIJO_FLOOR.ToUpper Then TBL_KOUENKAI.ANS_KOUEN_KAIJO_FLOOR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_IKENKOUKAN_KAIJO_NAME.ToUpper Then TBL_KOUENKAI.ANS_IKENKOUKAN_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_IROUKAI_KAIJO_NAME.ToUpper Then TBL_KOUENKAI.ANS_IROUKAI_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_KOUSHI_ROOM_NAME.ToUpper Then TBL_KOUENKAI.ANS_KOUSHI_ROOM_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SHAIN_ROOM_NAME.ToUpper Then TBL_KOUENKAI.ANS_SHAIN_ROOM_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_MANAGER_KAIJO_NAME.ToUpper Then TBL_KOUENKAI.ANS_MANAGER_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_KAISAI_NOTE.ToUpper Then TBL_KOUENKAI.ANS_KAISAI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SEISAN_TF.ToUpper Then TBL_KOUENKAI.ANS_SEISAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SEISAN_T.ToUpper Then TBL_KOUENKAI.ANS_SEISAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ANS_SEISANSHO_URL.ToUpper Then TBL_KOUENKAI.ANS_SEISANSHO_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_PC.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_TEL.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KOUENKAI
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As TableDef.TBL_SEIKYU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KOUENKAI_NO.ToUpper Then TBL_SEIKYU.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEISAN_YM.ToUpper Then TBL_SEIKYU.SEISAN_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.PAYMENT_NO.ToUpper Then TBL_SEIKYU.PAYMENT_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN.ToUpper Then TBL_SEIKYU.SHOUNIN_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE.ToUpper Then TBL_SEIKYU.SHOUNIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJOHI_TF.ToUpper Then TBL_SEIKYU.KAIJOHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIZAIHI_TF.ToUpper Then TBL_SEIKYU.KIZAIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF.ToUpper Then TBL_SEIKYU.INSHOKUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_99133040_1.ToUpper Then TBL_SEIKYU.KEI_99133040_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UNEIHI_TF.ToUpper Then TBL_SEIKYU.UNEIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.JINKENHI_TF.ToUpper Then TBL_SEIKYU.JINKENHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_41120200_1.ToUpper Then TBL_SEIKYU.KEI_41120200_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTELHI_TF.ToUpper Then TBL_SEIKYU.HOTELHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.JR_TF.ToUpper Then TBL_SEIKYU.JR_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.OTHER_TF.ToUpper Then TBL_SEIKYU.OTHER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTEL_COMMISSION_TF.ToUpper Then TBL_SEIKYU.HOTEL_COMMISSION_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_COMMISSION_TF.ToUpper Then TBL_SEIKYU.TAXI_COMMISSION_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF.ToUpper Then TBL_SEIKYU.TAXI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_41120200_2.ToUpper Then TBL_SEIKYU.KEI_41120200_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_TF.ToUpper Then TBL_SEIKYU.KEI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJOUHI_T.ToUpper Then TBL_SEIKYU.KAIJOUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIZAIHI_T.ToUpper Then TBL_SEIKYU.KIZAIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INSHOKUHI_T.ToUpper Then TBL_SEIKYU.INSHOKUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_99133040_2.ToUpper Then TBL_SEIKYU.KEI_99133040_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_T.ToUpper Then TBL_SEIKYU.KEI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR.ToUpper Then TBL_SEIKYU.SEIKYU_NO_TOPTOUR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_T.ToUpper Then TBL_SEIKYU.TAXI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_T.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TICKET_URL.ToUpper Then TBL_SEIKYU.TAXI_TICKET_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_1.ToUpper Then TBL_SEIKYU.MR_JR_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_2.ToUpper Then TBL_SEIKYU.MR_JR_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_3.ToUpper Then TBL_SEIKYU.MR_JR_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_4.ToUpper Then TBL_SEIKYU.MR_JR_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_5.ToUpper Then TBL_SEIKYU.MR_JR_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_6.ToUpper Then TBL_SEIKYU.MR_JR_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_7.ToUpper Then TBL_SEIKYU.MR_JR_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_8.ToUpper Then TBL_SEIKYU.MR_JR_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_9.ToUpper Then TBL_SEIKYU.MR_JR_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_10.ToUpper Then TBL_SEIKYU.MR_JR_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_11.ToUpper Then TBL_SEIKYU.MR_JR_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_12.ToUpper Then TBL_SEIKYU.MR_JR_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_13.ToUpper Then TBL_SEIKYU.MR_JR_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_14.ToUpper Then TBL_SEIKYU.MR_JR_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR_15.ToUpper Then TBL_SEIKYU.MR_JR_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_1.ToUpper Then TBL_SEIKYU.MR_HOTEL_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_2.ToUpper Then TBL_SEIKYU.MR_HOTEL_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_3.ToUpper Then TBL_SEIKYU.MR_HOTEL_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_4.ToUpper Then TBL_SEIKYU.MR_HOTEL_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_5.ToUpper Then TBL_SEIKYU.MR_HOTEL_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_6.ToUpper Then TBL_SEIKYU.MR_HOTEL_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_7.ToUpper Then TBL_SEIKYU.MR_HOTEL_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_8.ToUpper Then TBL_SEIKYU.MR_HOTEL_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_9.ToUpper Then TBL_SEIKYU.MR_HOTEL_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_10.ToUpper Then TBL_SEIKYU.MR_HOTEL_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_11.ToUpper Then TBL_SEIKYU.MR_HOTEL_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_12.ToUpper Then TBL_SEIKYU.MR_HOTEL_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_13.ToUpper Then TBL_SEIKYU.MR_HOTEL_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_14.ToUpper Then TBL_SEIKYU.MR_HOTEL_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_15.ToUpper Then TBL_SEIKYU.MR_HOTEL_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_1.ToUpper Then TBL_SEIKYU.TAXI_TF_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_2.ToUpper Then TBL_SEIKYU.TAXI_TF_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_3.ToUpper Then TBL_SEIKYU.TAXI_TF_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_4.ToUpper Then TBL_SEIKYU.TAXI_TF_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_5.ToUpper Then TBL_SEIKYU.TAXI_TF_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_6.ToUpper Then TBL_SEIKYU.TAXI_TF_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_7.ToUpper Then TBL_SEIKYU.TAXI_TF_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_8.ToUpper Then TBL_SEIKYU.TAXI_TF_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_9.ToUpper Then TBL_SEIKYU.TAXI_TF_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_10.ToUpper Then TBL_SEIKYU.TAXI_TF_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_11.ToUpper Then TBL_SEIKYU.TAXI_TF_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_12.ToUpper Then TBL_SEIKYU.TAXI_TF_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_13.ToUpper Then TBL_SEIKYU.TAXI_TF_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_14.ToUpper Then TBL_SEIKYU.TAXI_TF_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF_15.ToUpper Then TBL_SEIKYU.TAXI_TF_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_1.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_2.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_3.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_4.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_5.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_6.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_7.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_8.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_9.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_10.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_11.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_12.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_13.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_14.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_15.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEND_FLAG.ToUpper Then TBL_SEIKYU.SEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TTANTO_ID.ToUpper Then TBL_SEIKYU.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INPUT_DATE.ToUpper Then TBL_SEIKYU.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INPUT_USER.ToUpper Then TBL_SEIKYU.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UPDATE_DATE.ToUpper Then TBL_SEIKYU.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UPDATE_USER.ToUpper Then TBL_SEIKYU.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_SEIKYU
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID.ToUpper Then TBL_KOTSUHOTEL.SANKASHA_ID = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO.ToUpper Then TBL_KOTSUHOTEL.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI.ToUpper Then TBL_KOTSUHOTEL.REQ_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI.ToUpper Then TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL.ToUpper Then TBL_KOTSUHOTEL.TIME_STAMP_BYL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_TOP.ToUpper Then TBL_KOTSUHOTEL.TIME_STAMP_TOP = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_MPID.ToUpper Then TBL_KOTSUHOTEL.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_CD.ToUpper Then TBL_KOTSUHOTEL.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_NAME.ToUpper Then TBL_KOTSUHOTEL.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_KANA.ToUpper Then TBL_KOTSUHOTEL.DR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_CD = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI.ToUpper Then TBL_KOTSUHOTEL.DR_YAKUWARI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SEX.ToUpper Then TBL_KOTSUHOTEL.DR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_AGE.ToUpper Then TBL_KOTSUHOTEL.DR_AGE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHITEIGAI_RIYU.ToUpper Then TBL_KOTSUHOTEL.SHITEIGAI_RIYU = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA.ToUpper Then TBL_KOTSUHOTEL.DR_SANKA = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_BU.ToUpper Then TBL_KOTSUHOTEL.MR_BU = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_AREA.ToUpper Then TBL_KOTSUHOTEL.MR_AREA = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO.ToUpper Then TBL_KOTSUHOTEL.MR_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_NAME.ToUpper Then TBL_KOTSUHOTEL.MR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA.ToUpper Then TBL_KOTSUHOTEL.MR_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_PC.ToUpper Then TBL_KOTSUHOTEL.MR_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_KEITAI.ToUpper Then TBL_KOTSUHOTEL.MR_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI.ToUpper Then TBL_KOTSUHOTEL.MR_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_TEL.ToUpper Then TBL_KOTSUHOTEL.MR_TEL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS.ToUpper Then TBL_KOTSUHOTEL.MR_SEND_SAKI_FS = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER.ToUpper Then TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CD.ToUpper Then TBL_KOTSUHOTEL.ACCOUNT_CD = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER.ToUpper Then TBL_KOTSUHOTEL.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER.ToUpper Then TBL_KOTSUHOTEL.INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ZETIA_CD.ToUpper Then TBL_KOTSUHOTEL.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME.ToUpper Then TBL_KOTSUHOTEL.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE.ToUpper Then TBL_KOTSUHOTEL.SHONIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TEHAI_HOTEL.ToUpper Then TBL_KOTSUHOTEL.TEHAI_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.HOTEL_IRAINAIYOU.ToUpper Then TBL_KOTSUHOTEL.HOTEL_IRAINAIYOU = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_DATE.ToUpper Then TBL_KOTSUHOTEL.REQ_HOTEL_DATE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HAKUSU.ToUpper Then TBL_KOTSUHOTEL.REQ_HAKUSU = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_SMOKING.ToUpper Then TBL_KOTSUHOTEL.REQ_HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.REQ_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_HOTEL.ToUpper Then TBL_KOTSUHOTEL.ANS_STATUS_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NAME.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_ADDRESS.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_TEL.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_TEL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_DATE.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_DATE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HAKUSU.ToUpper Then TBL_KOTSUHOTEL.ANS_HAKUSU = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKIN_TIME.ToUpper Then TBL_KOTSUHOTEL.ANS_CHECKIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKOUT_TIME.ToUpper Then TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_ROOM_TYPE.ToUpper Then TBL_KOTSUHOTEL.ANS_ROOM_TYPE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_SMOKING.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_KOTSU_BIKO.ToUpper Then TBL_KOTSUHOTEL.REQ_KOTSU_BIKO = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSU_BIKO.ToUpper Then TBL_KOTSUHOTEL.ANS_KOTSU_BIKO = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_FARE.ToUpper Then TBL_KOTSUHOTEL.ANS_RAIL_FARE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_FARE.ToUpper Then TBL_KOTSUHOTEL.ANS_OTHER_FARE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_FARE.ToUpper Then TBL_KOTSUHOTEL.ANS_AIR_FARE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI.ToUpper Then TBL_KOTSUHOTEL.TEHAI_TAXI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_6 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_7 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_8 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_9 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_10 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_NOTE.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_1 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_2 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_3 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_4 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_5 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_6 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_7 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_8 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_9 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_10 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_11 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_12 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_13 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_14 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_15 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_16 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_17 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_18 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_19 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_20 = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NOTE.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_O_TEHAI.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_O_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_F_TEHAI.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_F_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEX.ToUpper Then TBL_KOTSUHOTEL.MR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_AGE.ToUpper Then TBL_KOTSUHOTEL.MR_AGE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_TEHAI_HOTEL.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_TEHAI_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_SMOKING.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_O_TEHAI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_O_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_F_TEHAI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_F_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NAME.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_ADDRESS.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTEL_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_TEL.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTEL_TEL = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_CHECKIN_TIME.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_CHECKIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_CHECKOUT_TIME.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_CHECKOUT_TIME = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_SMOKING.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_KOTSUHI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_KOTSUHI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTELHI = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG.ToUpper Then TBL_KOTSUHOTEL.SEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TTANTO_ID.ToUpper Then TBL_KOTSUHOTEL.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE.ToUpper Then TBL_KOTSUHOTEL.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INPUT_USER.ToUpper Then TBL_KOTSUHOTEL.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE.ToUpper Then TBL_KOTSUHOTEL.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER.ToUpper Then TBL_KOTSUHOTEL.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE.ToUpper Then TBL_KOTSUHOTEL.SEND_DATE = CmnDb.DbData(RsData.GetName(wCnt), RSDATA)
        Next wCnt

        Return TBL_KOTSUHOTEL
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As TableDef.TBL_KAIJO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_ID.ToUpper Then TBL_KAIJO.TEHAI_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUENKAI_NO.ToUpper Then TBL_KAIJO.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.REQ_STATUS_TEHAI.ToUpper Then TBL_KAIJO.REQ_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI.ToUpper Then TBL_KAIJO.ANS_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TIME_STAMP_BYL.ToUpper Then TBL_KAIJO.TIME_STAMP_BYL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TIME_STAMP_TOP.ToUpper Then TBL_KAIJO.TIME_STAMP_TOP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHONIN_NAME.ToUpper Then TBL_KAIJO.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHONIN_DATE.ToUpper Then TBL_KAIJO.SHONIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_DATE_NOTE.ToUpper Then TBL_KAIJO.KAISAI_DATE_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS1.ToUpper Then TBL_KAIJO.KAISAI_KIBOU_ADDRESS1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS2.ToUpper Then TBL_KAIJO.KAISAI_KIBOU_ADDRESS2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_NOTE.ToUpper Then TBL_KAIJO.KAISAI_KIBOU_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_TIME1.ToUpper Then TBL_KAIJO.KOUEN_TIME1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_TIME2.ToUpper Then TBL_KAIJO.KOUEN_TIME2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_LAYOUT.ToUpper Then TBL_KAIJO.KOUEN_KAIJO_LAYOUT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IKENKOUKAN_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IROUKAI_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.IROUKAI_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IROUKAI_SANKA_YOTEI_CNT.ToUpper Then TBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TEHAI.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHAIN_ROOM_TEHAI.ToUpper Then TBL_KAIJO.SHAIN_ROOM_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.MANAGER_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAIJO_URL.ToUpper Then TBL_KAIJO.KAIJO_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.OTHER_NOTE.ToUpper Then TBL_KAIJO.OTHER_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SENTEI_RIYU.ToUpper Then TBL_KAIJO.ANS_SENTEI_RIYU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TF.ToUpper Then TBL_KAIJO.ANS_MITSUMORI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_T.ToUpper Then TBL_KAIJO.ANS_MITSUMORI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TOTAL.ToUpper Then TBL_KAIJO.ANS_MITSUMORI_TOTAL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_URL.ToUpper Then TBL_KAIJO.ANS_MITSUMORI_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SHISETSU_NAME.ToUpper Then TBL_KAIJO.ANS_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ZIP.ToUpper Then TBL_KAIJO.ANS_SHISETSU_ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ADDRESS.ToUpper Then TBL_KAIJO.ANS_SHISETSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SHISETSU_TEL.ToUpper Then TBL_KAIJO.ANS_SHISETSU_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SHISETSU_URL.ToUpper Then TBL_KAIJO.ANS_SHISETSU_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_NAME.ToUpper Then TBL_KAIJO.ANS_KOUEN_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_FLOOR.ToUpper Then TBL_KAIJO.ANS_KOUEN_KAIJO_FLOOR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_IKENKOUKAN_KAIJO_NAME.ToUpper Then TBL_KAIJO.ANS_IKENKOUKAN_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_IROUKAI_KAIJO_NAME.ToUpper Then TBL_KAIJO.ANS_IROUKAI_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KOUSHI_ROOM_NAME.ToUpper Then TBL_KAIJO.ANS_KOUSHI_ROOM_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SHAIN_ROOM_NAME.ToUpper Then TBL_KAIJO.ANS_SHAIN_ROOM_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_MANAGER_KAIJO_NAME.ToUpper Then TBL_KAIJO.ANS_MANAGER_KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KAISAI_NOTE.ToUpper Then TBL_KAIJO.ANS_KAISAI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SEISAN_TF.ToUpper Then TBL_KAIJO.ANS_SEISAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SEISAN_T.ToUpper Then TBL_KAIJO.ANS_SEISAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_SEISANSHO_URL.ToUpper Then TBL_KAIJO.ANS_SEISANSHO_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_BU.ToUpper Then TBL_KAIJO.TEHAI_TANTO_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_AREA.ToUpper Then TBL_KAIJO.TEHAI_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EIGYOSHO.ToUpper Then TBL_KAIJO.TEHAI_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_NAME.ToUpper Then TBL_KAIJO.TEHAI_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_ROMA.ToUpper Then TBL_KAIJO.TEHAI_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_PC.ToUpper Then TBL_KAIJO.TEHAI_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KAIJO.TEHAI_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_KEITAI.ToUpper Then TBL_KAIJO.TEHAI_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_TEL.ToUpper Then TBL_KAIJO.TEHAI_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SEND_FLAG.ToUpper Then TBL_KAIJO.SEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.INPUT_DATE.ToUpper Then TBL_KAIJO.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.INPUT_USER.ToUpper Then TBL_KAIJO.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.UPDATE_DATE.ToUpper Then TBL_KAIJO.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.UPDATE_USER.ToUpper Then TBL_KAIJO.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TIME_STAMP.ToUpper Then TBL_KAIJO.TIME_STAMP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TORIKESHI_FLG.ToUpper Then TBL_KAIJO.TORIKESHI_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIDOKU_FLG.ToUpper Then TBL_KAIJO.KIDOKU_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUENKAI_TITLE.ToUpper Then TBL_KAIJO.KOUENKAI_TITLE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUENKAI_NAME.ToUpper Then TBL_KAIJO.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TAXI_PRT_NAME.ToUpper Then TBL_KAIJO.TAXI_PRT_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.FROM_DATE.ToUpper Then TBL_KAIJO.FROM_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TO_DATE.ToUpper Then TBL_KAIJO.TO_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAIJO_NAME.ToUpper Then TBL_KAIJO.KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SEIHIN_NAME.ToUpper Then TBL_KAIJO.SEIHIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.INTERNAL_ORDER_T.ToUpper Then TBL_KAIJO.INTERNAL_ORDER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.INTERNAL_ORDER_TF.ToUpper Then TBL_KAIJO.INTERNAL_ORDER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ACCOUNT_CD_T.ToUpper Then TBL_KAIJO.ACCOUNT_CD_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ACCOUNT_CD_TF.ToUpper Then TBL_KAIJO.ACCOUNT_CD_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ZETIA_CD.ToUpper Then TBL_KAIJO.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT.ToUpper Then TBL_KAIJO.SANKA_YOTEI_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.BU.ToUpper Then TBL_KAIJO.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_ROMA.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_EMAIL_PC.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_KEITAI.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_TEL.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.COST_CENTER.ToUpper Then TBL_KAIJO.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.YOSAN_TF.ToUpper Then TBL_KAIJO.YOSAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.YOSAN_T.ToUpper Then TBL_KAIJO.YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TTANTO_ID.ToUpper Then TBL_KAIJO.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KAIJO
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_BENTO As TableDef.TBL_BENTO.DataStruct) As TableDef.TBL_BENTO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ID.ToUpper Then TBL_BENTO.ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KINKYU_FLG.ToUpper Then TBL_BENTO.KINKYU_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.RAIJO_FLG.ToUpper Then TBL_BENTO.RAIJO_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.AREA.ToUpper Then TBL_BENTO.AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ADDRESS.ToUpper Then TBL_BENTO.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.EIGYOSHO.ToUpper Then TBL_BENTO.EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ZIP.ToUpper Then TBL_BENTO.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.TANTO_NO.ToUpper Then TBL_BENTO.TANTO_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.TANTO_NAME.ToUpper Then TBL_BENTO.TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.TANTO_KANA.ToUpper Then TBL_BENTO.TANTO_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.INTERNAL_ORDER_T.ToUpper Then TBL_BENTO.INTERNAL_ORDER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ACCOUNT_CODE_T.ToUpper Then TBL_BENTO.ACCOUNT_CODE_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.TEL.ToUpper Then TBL_BENTO.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.EMAIL.ToUpper Then TBL_BENTO.EMAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.SEND_SAKI_FS.ToUpper Then TBL_BENTO.SEND_SAKI_FS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_MPID.ToUpper Then TBL_BENTO.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_NAME.ToUpper Then TBL_BENTO.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_KANA.ToUpper Then TBL_BENTO.DR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_SHISETSU_NAME.ToUpper Then TBL_BENTO.DR_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_CD.ToUpper Then TBL_BENTO.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_SHISETSU_CD.ToUpper Then TBL_BENTO.DR_SHISETSU_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_ADDRESS.ToUpper Then TBL_BENTO.DR_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_GOFFICIAL.ToUpper Then TBL_BENTO.DR_GOFFICIAL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.DR_YAKUWARI.ToUpper Then TBL_BENTO.DR_YAKUWARI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KOUENKAI_NAME.ToUpper Then TBL_BENTO.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KOUENKAI_DATE.ToUpper Then TBL_BENTO.KOUENKAI_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KOUENKAI_NO.ToUpper Then TBL_BENTO.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KAIJO.ToUpper Then TBL_BENTO.KAIJO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.BU.ToUpper Then TBL_BENTO.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ACCOUNT_CODE.ToUpper Then TBL_BENTO.ACCOUNT_CODE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.COST_CENTER.ToUpper Then TBL_BENTO.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.INTERNAL_ORDER.ToUpper Then TBL_BENTO.INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ZETIA_CD.ToUpper Then TBL_BENTO.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.STATUS_SHONIN.ToUpper Then TBL_BENTO.STATUS_SHONIN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.SHONIN_NAME.ToUpper Then TBL_BENTO.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.SHONIN_TIME.ToUpper Then TBL_BENTO.SHONIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.SHONIN_NOTE.ToUpper Then TBL_BENTO.SHONIN_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.CMSHONIN_NAME.ToUpper Then TBL_BENTO.CMSHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.CMSHONIN_TIME.ToUpper Then TBL_BENTO.CMSHONIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.CMSHONIN_NOTE.ToUpper Then TBL_BENTO.CMSHONIN_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.STATUS_TEHAI.ToUpper Then TBL_BENTO.STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.HAITATSU_DATE.ToUpper Then TBL_BENTO.HAITATSU_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.HAITATSU_KIBOU_TIME.ToUpper Then TBL_BENTO.HAITATSU_KIBOU_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.HAITATSU_ADDRESS.ToUpper Then TBL_BENTO.HAITATSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.HAITATSU_SHISETSU.ToUpper Then TBL_BENTO.HAITATSU_SHISETSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.SURYO.ToUpper Then TBL_BENTO.SURYO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.TANKA.ToUpper Then TBL_BENTO.TANKA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KIBOU_MAKER.ToUpper Then TBL_BENTO.KIBOU_MAKER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.KIBOU_MENU.ToUpper Then TBL_BENTO.KIBOU_MENU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.NOTE.ToUpper Then TBL_BENTO.NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.ANS_STATUS_TEHAI.ToUpper Then TBL_BENTO.ANS_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_HAITATSU_TIME.ToUpper Then TBL_BENTO.FIX_HAITATSU_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_HAITATSU_ADDRESS.ToUpper Then TBL_BENTO.FIX_HAITATSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_HAITATSU_SHISETSU.ToUpper Then TBL_BENTO.FIX_HAITATSU_SHISETSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_SURYO.ToUpper Then TBL_BENTO.FIX_SURYO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_TANKA.ToUpper Then TBL_BENTO.FIX_TANKA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_KINGAKU_TOTAL.ToUpper Then TBL_BENTO.FIX_KINGAKU_TOTAL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_MAKER.ToUpper Then TBL_BENTO.FIX_MAKER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_MAKER_CONTACT.ToUpper Then TBL_BENTO.FIX_MAKER_CONTACT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_KIBOU_MAKER.ToUpper Then TBL_BENTO.FIX_KIBOU_MAKER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BENTO.Column.FIX_NOTE.ToUpper Then TBL_BENTO.FIX_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_BENTO
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As TableDef.MS_SHISETSU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.SYSTEM_ID.ToUpper Then MS_SHISETSU.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.ZIP.ToUpper Then MS_SHISETSU.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.ADDRESS1.ToUpper Then MS_SHISETSU.ADDRESS1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.ADDRESS2.ToUpper Then MS_SHISETSU.ADDRESS2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.SHISETSU_NAME.ToUpper Then MS_SHISETSU.SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.SHISETSU_KANA.ToUpper Then MS_SHISETSU.SHISETSU_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.TEL.ToUpper Then MS_SHISETSU.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.CHECKIN_TIME.ToUpper Then MS_SHISETSU.CHECKIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.CHECKOUT_TIME.ToUpper Then MS_SHISETSU.CHECKOUT_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.URL.ToUpper Then MS_SHISETSU.URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.STOP_FLG.ToUpper Then MS_SHISETSU.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.INPUT_DATE.ToUpper Then MS_SHISETSU.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.INPUT_USER.ToUpper Then MS_SHISETSU.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.UPDATE_DATE.ToUpper Then MS_SHISETSU.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.UPDATE_USER.ToUpper Then MS_SHISETSU.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_SHISETSU
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_USER As TableDef.MS_USER.DataStruct) As TableDef.MS_USER.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.SYSTEM_ID.ToUpper Then MS_USER.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.LOGIN_ID.ToUpper Then MS_USER.LOGIN_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.PASSWORD.ToUpper Then MS_USER.PASSWORD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.KENGEN.ToUpper Then MS_USER.KENGEN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.USER_NAME.ToUpper Then MS_USER.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.STOP_FLG.ToUpper Then MS_USER.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.INPUT_DATE.ToUpper Then MS_USER.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.INPUT_USER.ToUpper Then MS_USER.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.UPDATE_DATE.ToUpper Then MS_USER.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.UPDATE_USER.ToUpper Then MS_USER.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_USER
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_JIGYOSHO As TableDef.MS_JIGYOSHO.DataStruct) As TableDef.MS_JIGYOSHO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.SYSTEM_ID.ToUpper Then MS_JIGYOSHO.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.����.ToUpper Then MS_JIGYOSHO.���� = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.STOP_FLG.ToUpper Then MS_JIGYOSHO.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.INPUT_DATE.ToUpper Then MS_JIGYOSHO.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.INPUT_USER.ToUpper Then MS_JIGYOSHO.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.UPDATE_DATE.ToUpper Then MS_JIGYOSHO.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.UPDATE_USER.ToUpper Then MS_JIGYOSHO.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_JIGYOSHO
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_AREA As TableDef.MS_AREA.DataStruct) As TableDef.MS_AREA.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.SYSTEM_ID.ToUpper Then MS_AREA.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.����.ToUpper Then MS_AREA.���� = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.STOP_FLG.ToUpper Then MS_AREA.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.INPUT_DATE.ToUpper Then MS_AREA.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.INPUT_USER.ToUpper Then MS_AREA.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.UPDATE_DATE.ToUpper Then MS_AREA.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.UPDATE_USER.ToUpper Then MS_AREA.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_AREA
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_EIGYOSHO As TableDef.MS_EIGYOSHO.DataStruct) As TableDef.MS_EIGYOSHO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.SYSTEM_ID.ToUpper Then MS_EIGYOSHO.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.����.ToUpper Then MS_EIGYOSHO.���� = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.STOP_FLG.ToUpper Then MS_EIGYOSHO.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.INPUT_DATE.ToUpper Then MS_EIGYOSHO.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.INPUT_USER.ToUpper Then MS_EIGYOSHO.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.UPDATE_DATE.ToUpper Then MS_EIGYOSHO.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.UPDATE_USER.ToUpper Then MS_EIGYOSHO.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_EIGYOSHO
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_CODE As TableDef.MS_CODE.DataStruct) As TableDef.MS_CODE.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_CODE.Column.CODE.ToUpper Then MS_CODE.CODE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_CODE.Column.DATA_ID.ToUpper Then MS_CODE.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_CODE.Column.DISP_TEXT.ToUpper Then MS_CODE.DISP_TEXT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_CODE.Column.DISP_VALUE.ToUpper Then MS_CODE.DISP_VALUE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_CODE
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct) As TableDef.TBL_LOG.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.INPUT_DATE.ToUpper Then TBL_LOG.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.INPUT_USER.ToUpper Then TBL_LOG.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.SYORI_KBN.ToUpper Then TBL_LOG.SYORI_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.SYORI_NAME.ToUpper Then TBL_LOG.SYORI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.TABLE_NAME.ToUpper Then TBL_LOG.TABLE_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.STATUS.ToUpper Then TBL_LOG.STATUS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.NOTE.ToUpper Then TBL_LOG.NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_LOG
    End Function


    '�f�[�^�擾
    Public Shared Function GetOneRecord(ByVal TableType As TableType, ByVal SQL As String, ByVal DbConn As System.Data.SqlClient.SqlConnection) As Object
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Select Case TableType
            Case AppModule.TableType.TBL_KOUENKAI
                Dim TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_KOUENKAI = SetRsData(RsData, TBL_KOUENKAI)
                End If
                RsData.Close()
                Return TBL_KOUENKAI
            Case AppModule.TableType.TBL_SEIKYU
                Dim TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_SEIKYU = SetRsData(RsData, TBL_SEIKYU)
                End If
                RsData.Close()
                Return TBL_SEIKYU
            Case AppModule.TableType.TBL_KOTSUHOTEL
                Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_KOTSUHOTEL = SetRsData(RsData, TBL_KOTSUHOTEL)
                End If
                RsData.Close()
                Return TBL_KOTSUHOTEL
            Case AppModule.TableType.TBL_KAIJO
                Dim TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_KAIJO = SetRsData(RsData, TBL_KAIJO)
                End If
                RsData.Close()
                Return TBL_KAIJO
            Case AppModule.TableType.TBL_BENTO
                Dim TBL_BENTO As TableDef.TBL_BENTO.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_BENTO = SetRsData(RsData, TBL_BENTO)
                End If
                RsData.Close()
                Return TBL_BENTO
            Case AppModule.TableType.MS_SHISETSU
                Dim MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_SHISETSU = SetRsData(RsData, MS_SHISETSU)
                End If
                RsData.Close()
                Return MS_SHISETSU
            Case AppModule.TableType.MS_USER
                Dim MS_USER As TableDef.MS_USER.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_USER = SetRsData(RsData, MS_USER)
                End If
                RsData.Close()
                Return MS_USER
            Case AppModule.TableType.MS_JIGYOSHO
                Dim MS_JIGYOSHO As TableDef.MS_JIGYOSHO.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_JIGYOSHO = SetRsData(RsData, MS_JIGYOSHO)
                End If
                RsData.Close()
                Return MS_JIGYOSHO
            Case AppModule.TableType.MS_AREA
                Dim MS_AREA As TableDef.MS_AREA.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_AREA = SetRsData(RsData, MS_AREA)
                End If
                RsData.Close()
                Return MS_AREA
            Case AppModule.TableType.MS_EIGYOSHO
                Dim MS_EIGYOSHO As TableDef.MS_EIGYOSHO.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_EIGYOSHO = SetRsData(RsData, MS_EIGYOSHO)
                End If
                RsData.Close()
                Return MS_EIGYOSHO
            Case AppModule.TableType.MS_CODE
                Dim MS_CODE As TableDef.MS_CODE.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_CODE = SetRsData(RsData, MS_CODE)
                End If
                RsData.Close()
                Return MS_CODE
            Case AppModule.TableType.TBL_LOG
                Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_LOG = SetRsData(RsData, TBL_LOG)
                End If
                RsData.Close()
                Return TBL_LOG
            Case Else
                Return Nothing
        End Select
    End Function


    '== �\���p�ɕ������ҏW ==
    '�f�[�^�敪
    Public Shared Function GetName_RECORD_KUBUN(ByVal RECORD_KUBUN As String) As String
        Select Case RECORD_KUBUN
            Case AppConst.RECORD_KUBUN.Code.Insert, AppConst.RECORD_KUBUN.Name.Insert
                Return AppConst.RECORD_KUBUN.Name.Insert
            Case AppConst.RECORD_KUBUN.Code.Update, AppConst.RECORD_KUBUN.Name.Update
                Return AppConst.RECORD_KUBUN.Name.Update
            Case AppConst.RECORD_KUBUN.Code.Cancel, AppConst.RECORD_KUBUN.Name.Cancel
                Return AppConst.RECORD_KUBUN.Name.Cancel
            Case Else
                Return ""
        End Select
    End Function

    '���O�C��ID
    Public Shared Function GetName_LOGIN_ID(ByVal LOGIN_ID As String) As String
        Return LOGIN_ID
    End Function

    '�p�X���[�h
    Public Shared Function GetName_PASSWORD(ByVal PASSWORD As String) As String
        Return PASSWORD
    End Function

    '�u����ԍ�
    Public Shared Function GetName_KOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
        Return KOUENKAI_NO
    End Function

    '��z�X�e�[�^�X
    Public Shared Function GetName_STATUS_TEHAI(ByVal STATUS_TEHAI As String, Optional ByVal KAIJO As Boolean = False) As String
        If KAIJO = False Then
            '�h���E���
            Select Case STATUS_TEHAI
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel

                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK_Daian, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK_Daian
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK_Daian
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Changed, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Changed
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Changed
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NG, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.NG
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.NG
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled

                Case Else
                    Return ""
            End Select
        Else
            '���
            Select Case STATUS_TEHAI
                Case AppConst.KAIJO.STATUS_TEHAI.Code.Tehai, AppConst.KAIJO.STATUS_TEHAI.Name.Tehai
                    Return AppConst.KAIJO.STATUS_TEHAI.Name.Tehai
                Case AppConst.KAIJO.STATUS_TEHAI.Code.Change, AppConst.KAIJO.STATUS_TEHAI.Name.Change
                    Return AppConst.KAIJO.STATUS_TEHAI.Name.Change
                Case AppConst.KAIJO.STATUS_TEHAI.Code.Cancel, AppConst.KAIJO.STATUS_TEHAI.Name.Cancel
                    Return AppConst.KAIJO.STATUS_TEHAI.Name.Cancel

                Case Else
                    Return ""
            End Select
        End If
    End Function

    '�y�˗��z��z�X�e�[�^�X
    Public Shared Function GetName_REQ_STATUS_TEHAI(ByVal REQ_STATUS_TEHAI As String, Optional ByVal KAIJO As Boolean = False) As String
        If KAIJO = False Then
            Select Case REQ_STATUS_TEHAI
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel

                Case Else
                    Return ""
            End Select
        Else
            Select Case REQ_STATUS_TEHAI
                Case AppConst.KAIJO.REQ_STATUS_TEHAI.Code.NewRequest, AppConst.KAIJO.REQ_STATUS_TEHAI.Name.NewRequest
                    Return AppConst.KAIJO.REQ_STATUS_TEHAI.Name.NewRequest
                Case AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Change, AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Change
                    Return AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Change
                Case AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Cancel, AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Cancel
                    Return AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Cancel
                Case AppConst.KAIJO.REQ_STATUS_TEHAI.Code.After, AppConst.KAIJO.REQ_STATUS_TEHAI.Name.After
                    Return AppConst.KAIJO.REQ_STATUS_TEHAI.Name.After

                Case Else
                    Return ""
            End Select
        End If
    End Function

    '�y�񓚁z��z�X�e�[�^�X
    Public Shared Function GetName_ANS_STATUS_TEHAI(ByVal ANS_STATUS_TEHAI As String) As String
        Select Case ANS_STATUS_TEHAI
            Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.Uketsuke, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Uketsuke
                Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Uketsuke
            Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.Prepare, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Prepare
                Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Prepare
            Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.OK, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.OK
                Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.OK
            Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanEnd, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanEnd
                Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanEnd

            Case Else
                Return ""
        End Select
    End Function

    'MPID
    Public Shared Function GetName_DR_MPID(ByVal DR_MPID As String) As String
        Return DR_MPID
    End Function

    'DR�R�[�h
    Public Shared Function GetName_DR_CD(ByVal DR_CD As String) As String
        Return DR_CD
    End Function

    '�}��
    Public Shared Function GetName_DR_EDABAN(ByVal DR_EDABAN As String) As String
        Return DR_EDABAN
    End Function

    'DR����
    Public Shared Function GetName_DR_NAME(ByVal DR_NAME As String) As String
        Return DR_NAME
    End Function

    'DR�����i�S�p�J�^�J�i�j
    Public Shared Function GetName_DR_KANA(ByVal DR_KANA As String) As String
        Return DR_KANA
    End Function

    'DR����
    Public Shared Function GetName_DR_SEX(ByVal DR_SEX As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEX AndAlso MS_CODE(wCnt).DISP_VALUE = DR_SEX Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    'DCF�{�݃R�[�h
    Public Shared Function GetName_DR_SHISETSU_CD(ByVal DR_SHISETSU_CD As String) As String
        Return DR_SHISETSU_CD
    End Function

    '�{�ݖ�
    Public Shared Function GetName_DR_SHISETSU_NAME(ByVal DR_SHISETSU_NAME As String) As String
        Return DR_SHISETSU_NAME
    End Function

    '�{�ݏZ��
    Public Shared Function GetName_DR_SHISETSU_ADDRESS(ByVal DR_SHISETSU_ADDRESS As String) As String
        Return DR_SHISETSU_ADDRESS
    End Function

    '�Q���Җ���
    Public Shared Function GetName_DR_YAKUWARI(ByVal DR_YAKUWARI As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.DR_YAKUWARI AndAlso MS_CODE(wCnt).DISP_VALUE = DR_YAKUWARI Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�Q���^�s�Q��
    Public Shared Function GetName_DR_SANKA(ByVal DR_SANKA As String) As String
        Select Case DR_SANKA
            Case AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes, AppConst.KOTSUHOTEL.DR_SANKA.Name.Yes
                Return AppConst.KOTSUHOTEL.DR_SANKA.Name.Yes
            Case AppConst.KOTSUHOTEL.DR_SANKA.Code.No, AppConst.KOTSUHOTEL.DR_SANKA.Name.No
                Return AppConst.KOTSUHOTEL.DR_SANKA.Name.No

            Case Else
                Return ""
        End Select
    End Function

    '�������ƕ��i�S��MR�j
    Public Shared Function GetName_MR_JIGYOBU(ByVal MR_JIGYOBU As String) As String
        Return MR_JIGYOBU
    End Function

    '�����G���A�i�S��MR�j
    Public Shared Function GetName_MR_AREA(ByVal MR_AREA As String) As String
        Return MR_AREA
    End Function

    '�����c�Ə��i�S��MR�j
    Public Shared Function GetName_MR_EIGYOSHO(ByVal MR_EIGYOSHO As String) As String
        Return MR_EIGYOSHO
    End Function

    '�S���ҁi�S��MR�jNo
    Public Shared Function GetName_MR_NO(ByVal MR_NO As String) As String
        Return MR_NO
    End Function

    '�S���ҁi�S��MR�j��
    Public Shared Function GetName_MR_NAME(ByVal MR_NAME As String) As String
        Return MR_NAME
    End Function

    '�S���Җ��i�S��MR�j�i�J�^�J�i�j
    Public Shared Function GetName_MR_KANA(ByVal MR_KANA As String) As String
        Return MR_KANA
    End Function

    'Email�A�h���X�i�S��MR�j
    Public Shared Function GetName_MR_EMAIL(ByVal MR_EMAIL As String) As String
        Return MR_EMAIL
    End Function

    '�g�ѓd�b�ԍ��i�S��MR�j
    Public Shared Function GetName_MR_KEITAI(ByVal MR_KEITAI As String) As String
        Return MR_KEITAI
    End Function

    '�`�P�b�g���t��FS
    Public Shared Function GetName_MR_SEND_SAKI_FS(ByVal MR_SEND_SAKI_FS As String) As String
        Return MR_SEND_SAKI_FS
    End Function

    '�`�P�b�g���t��i���̑��j
    Public Shared Function GetName_MR_SEND_SAKI_OTHER(ByVal MR_SEND_SAKI_OTHER As String) As String
        Return MR_SEND_SAKI_OTHER
    End Function

    'Account Code
    Public Shared Function GetName_ACCOUNT_CODE(ByVal ACCOUNT_CODE As String) As String
        Return ACCOUNT_CODE
    End Function

    'Cost Center
    Public Shared Function GetName_COST_CENTER(ByVal COST_CENTER As String) As String
        Return COST_CENTER
    End Function

    'Internal Order
    Public Shared Function GetName_INTERNAL_ORDER(ByVal INTERNAL_ORDER As String) As String
        Return INTERNAL_ORDER
    End Function

    '���F�ҁi�����j
    Public Shared Function GetName_SHONIN_NAME(ByVal SHONIN_NAME As String) As String
        Return SHONIN_NAME
    End Function

    '���F����
    Public Shared Function GetName_SHONIN_DATE(ByVal SHONIN_DATE As String) As String
        Return CmnModule.Format_Date(SHONIN_DATE, CmnModule.DateFormatType.YYYYMD)
    End Function

    'CM���F�ҁi�����j
    Public Shared Function GetName_CMSHONIN_NAME(ByVal CMSHONIN_NAME As String) As String
        Return CMSHONIN_NAME
    End Function

    'CM���F����
    Public Shared Function GetName_CMSHONIN_DATE(ByVal CMSHONIN_DATE As String) As String
        Return CmnModule.Format_Date(CMSHONIN_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    'CM���F�Ҕ��l
    Public Shared Function GetName_CMSHONIN_NOTE(ByVal CMSHONIN_NOTE As String) As String
        Return CMSHONIN_NOTE
    End Function

    '�h����z
    Public Shared Function GetName_TEHAI_HOTEL(ByVal TEHAI_HOTEL As String) As String
        Select Case TEHAI_HOTEL
            Case AppConst.KOTSUHOTEL.TEHAI_HOTEL.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.Yes
                Return AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.Yes
            Case AppConst.KOTSUHOTEL.TEHAI_HOTEL.Code.No, AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.No
                Return AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.No

            Case Else
                Return ""
        End Select
    End Function

    '�h���˗����e
    Public Shared Function GetName_HOTEL_IRAINAIYOU(ByVal HOTEL_IRAINAIYOU As String) As String
        Select Case HOTEL_IRAINAIYOU
            Case AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Code.Tehai, AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Tehai
                Return AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Tehai
            Case AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Code.Change, AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Change
                Return AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Change
            Case AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Code.Cancel, AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Cancel
                Return AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Cancel

            Case Else
                Return ""
        End Select
    End Function

    '�h�����i�˗��j
    Public Shared Function GetName_REQ_HOTEL_DATE(ByVal REQ_HOTEL_DATE As String) As String
        Return CmnModule.Format_Date(REQ_HOTEL_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '�����i�˗��j
    Public Shared Function GetName_REQ_HAKUSU(ByVal REQ_HAKUSU As String) As String
        Return REQ_HAKUSU
    End Function

    '�h���z�e���i���i�˗��j
    Public Shared Function GetName_REQ_HOTEL_SMOKING(ByVal REQ_HOTEL_SMOKING As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_HOTEL_SMOKING AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_HOTEL_SMOKING Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�h�����l�i�˗��j
    Public Shared Function GetName_REQ_HOTEL_NOTE(ByVal REQ_HOTEL_NOTE As String) As String
        Return REQ_HOTEL_NOTE
    End Function

    '�h���X�e�[�^�X�i�񓚁j
    Public Shared Function GetName_ANS_STATUS_HOTEL(ByVal ANS_STATUS_HOTEL As String) As String
        Select Case ANS_STATUS_HOTEL
            Case AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Prepare, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.OK, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Canceled, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Canceled

            Case Else
                Return ""
        End Select
    End Function

    '�h����i�񓚁j
    Public Shared Function GetName_ANS_HOTEL_NAME(ByVal ANS_HOTEL_NAME As String) As String
        Return ANS_HOTEL_NAME
    End Function

    '�h����Z���i�񓚁j
    Public Shared Function GetName_ANS_HOTEL_ADDRESS(ByVal ANS_HOTEL_ADDRESS As String) As String
        Return ANS_HOTEL_ADDRESS
    End Function

    '�h����d�b�ԍ��i�񓚁j
    Public Shared Function GetName_ANS_HOTEL_TEL(ByVal ANS_HOTEL_TEL As String) As String
        Return ANS_HOTEL_TEL
    End Function

    '�h�����i�񓚁j
    Public Shared Function GetName_ANS_HOTEL_DATE(ByVal ANS_HOTEL_DATE As String) As String
        Return ANS_HOTEL_DATE
    End Function

    '�����i�񓚁j
    Public Shared Function GetName_ANS_HAKUSU(ByVal ANS_HAKUSU As String) As String
        Return ANS_HAKUSU
    End Function

    '�h����`�F�b�N�C�����ԁi�񓚁j
    Public Shared Function GetName_ANS_CHECKIN_TIME(ByVal ANS_CHECKIN_TIME As String) As String
        Return ANS_CHECKIN_TIME
    End Function

    '�h����`�F�b�N�A�E�g���ԁi�񓚁j
    Public Shared Function GetName_ANS_CHECKOUT_TIME(ByVal ANS_CHECKOUT_TIME As String) As String
        Return ANS_CHECKOUT_TIME
    End Function

    '�h�������^�C�v�i�񓚁j
    Public Shared Function GetName_ANS_ROOM_TYPE(ByVal ANS_ROOM_TYPE As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.ROOM_TYPE AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_ROOM_TYPE Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�h���z�e���i���i�񓚁j
    Public Shared Function GetName_ANS_HOTEL_SMOKING(ByVal ANS_HOTEL_SMOKING As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.ANS_HOTEL_SMOKING AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_HOTEL_SMOKING Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�h�����l�i�񓚁j
    Public Shared Function GetName_ANS_HOTEL_NOTE(ByVal ANS_HOTEL_NOTE As String) As String
        Return ANS_HOTEL_NOTE
    End Function

    '���H�F��ʎ�z
    Public Shared Function GetName_REQ_O_TEHAI(ByVal REQ_O_TEHAI As String) As String
        Select Case REQ_O_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes, AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.Yes
                Return AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.Yes
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No, AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.No
                Return AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_REQ_O_TEHAI_1(ByVal REQ_O_TEHAI_1 As String) As String
        Return GetName_REQ_O_TEHAI(REQ_O_TEHAI_1)
    End Function
    Public Shared Function GetName_REQ_O_TEHAI_2(ByVal REQ_O_TEHAI_2 As String) As String
        Return GetName_REQ_O_TEHAI(REQ_O_TEHAI_2)
    End Function
    Public Shared Function GetName_REQ_O_TEHAI_3(ByVal REQ_O_TEHAI_3 As String) As String
        Return GetName_REQ_O_TEHAI(REQ_O_TEHAI_3)
    End Function
    Public Shared Function GetName_REQ_O_TEHAI_4(ByVal REQ_O_TEHAI_4 As String) As String
        Return GetName_REQ_O_TEHAI(REQ_O_TEHAI_4)
    End Function
    Public Shared Function GetName_REQ_O_TEHAI_5(ByVal REQ_O_TEHAI_5 As String) As String
        Return GetName_REQ_O_TEHAI(REQ_O_TEHAI_5)
    End Function

    '���H�F��ʈ˗����e
    Public Shared Function GetName_REQ_O_IRAINAIYOU(ByVal REQ_O_IRAINAIYOU As String) As String
        Select Case REQ_O_IRAINAIYOU
            Case AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Code.Tehai, AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Tehai
                Return AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Tehai
            Case AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Code.Change, AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Change
                Return AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Change
            Case AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Code.Cancel, AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Cancel
                Return AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Cancel

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_REQ_O_IRAINAIYOU_1(ByVal REQ_O_IRAINAIYOU_1 As String) As String
        Return GetName_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_1)
    End Function
    Public Shared Function GetName_REQ_O_IRAINAIYOU_2(ByVal REQ_O_IRAINAIYOU_2 As String) As String
        Return GetName_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_2)
    End Function
    Public Shared Function GetName_REQ_O_IRAINAIYOU_3(ByVal REQ_O_IRAINAIYOU_3 As String) As String
        Return GetName_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_3)
    End Function
    Public Shared Function GetName_REQ_O_IRAINAIYOU_4(ByVal REQ_O_IRAINAIYOU_4 As String) As String
        Return GetName_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_4)
    End Function
    Public Shared Function GetName_REQ_O_IRAINAIYOU_5(ByVal REQ_O_IRAINAIYOU_5 As String) As String
        Return GetName_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_5)
    End Function

    '���H�F��ʋ@��
    Public Shared Function GetName_REQ_O_KOTSUKIKAN(ByVal REQ_O_KOTSUKIKAN As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_O_KOTSUKIKAN Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_REQ_O_KOTSUKIKAN_1(ByVal REQ_O_KOTSUKIKAN_1 As String) As String
        Return GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_1)
    End Function
    Public Shared Function GetName_REQ_O_KOTSUKIKAN_2(ByVal REQ_O_KOTSUKIKAN_2 As String) As String
        Return GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_2)
    End Function
    Public Shared Function GetName_REQ_O_KOTSUKIKAN_3(ByVal REQ_O_KOTSUKIKAN_3 As String) As String
        Return GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_3)
    End Function
    Public Shared Function GetName_REQ_O_KOTSUKIKAN_4(ByVal REQ_O_KOTSUKIKAN_4 As String) As String
        Return GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_4)
    End Function
    Public Shared Function GetName_REQ_O_KOTSUKIKAN_5(ByVal REQ_O_KOTSUKIKAN_5 As String) As String
        Return GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_5)
    End Function

    '���H�F���p���i�˗��j
    Public Shared Function GetName_REQ_O_DATE(ByVal REQ_O_DATE As String) As String
        Return CmnModule.Format_Date(REQ_O_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_REQ_O_DATE_1(ByVal REQ_O_DATE_1 As String) As String
        Return GetName_REQ_O_DATE(REQ_O_DATE_1)
    End Function
    Public Shared Function GetName_REQ_O_DATE_2(ByVal REQ_O_DATE_2 As String) As String
        Return GetName_REQ_O_DATE(REQ_O_DATE_2)
    End Function
    Public Shared Function GetName_REQ_O_DATE_3(ByVal REQ_O_DATE_3 As String) As String
        Return GetName_REQ_O_DATE(REQ_O_DATE_3)
    End Function
    Public Shared Function GetName_REQ_O_DATE_4(ByVal REQ_O_DATE_4 As String) As String
        Return GetName_REQ_O_DATE(REQ_O_DATE_4)
    End Function
    Public Shared Function GetName_REQ_O_DATE_5(ByVal REQ_O_DATE_5 As String) As String
        Return GetName_REQ_O_DATE(REQ_O_DATE_5)
    End Function

    '���H�F�o���n�i�˗��j
    Public Shared Function GetName_REQ_O_AIRPORT1(ByVal REQ_O_AIRPORT1 As String) As String
        Return REQ_O_AIRPORT1
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT1_1(ByVal REQ_O_AIRPORT1_1 As String) As String
        Return GetName_REQ_O_AIRPORT1(REQ_O_AIRPORT1_1)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT1_2(ByVal REQ_O_AIRPORT1_2 As String) As String
        Return GetName_REQ_O_AIRPORT1(REQ_O_AIRPORT1_2)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT1_3(ByVal REQ_O_AIRPORT1_3 As String) As String
        Return GetName_REQ_O_AIRPORT1(REQ_O_AIRPORT1_3)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT1_4(ByVal REQ_O_AIRPORT1_4 As String) As String
        Return GetName_REQ_O_AIRPORT1(REQ_O_AIRPORT1_4)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT1_5(ByVal REQ_O_AIRPORT1_5 As String) As String
        Return GetName_REQ_O_AIRPORT1(REQ_O_AIRPORT1_5)
    End Function

    '���H�F�����n�i�˗��j
    Public Shared Function GetName_REQ_O_AIRPORT2(ByVal REQ_O_AIRPORT2 As String) As String
        Return REQ_O_AIRPORT2
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT2_1(ByVal REQ_O_AIRPORT2_1 As String) As String
        Return GetName_REQ_O_AIRPORT2(REQ_O_AIRPORT2_1)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT2_2(ByVal REQ_O_AIRPORT2_2 As String) As String
        Return GetName_REQ_O_AIRPORT2(REQ_O_AIRPORT2_2)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT2_3(ByVal REQ_O_AIRPORT2_3 As String) As String
        Return GetName_REQ_O_AIRPORT2(REQ_O_AIRPORT2_3)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT2_4(ByVal REQ_O_AIRPORT2_4 As String) As String
        Return GetName_REQ_O_AIRPORT2(REQ_O_AIRPORT2_4)
    End Function
    Public Shared Function GetName_REQ_O_AIRPORT2_5(ByVal REQ_O_AIRPORT2_5 As String) As String
        Return GetName_REQ_O_AIRPORT2(REQ_O_AIRPORT2_5)
    End Function

    '���H�F�o�����ԁi�˗��j
    Public Shared Function GetName_REQ_O_TIME1(ByVal REQ_O_TIME1 As String) As String
        Return REQ_O_TIME1
    End Function
    Public Shared Function GetName_REQ_O_TIME1_1(ByVal REQ_O_TIME1_1 As String) As String
        Return GetName_REQ_O_TIME1(REQ_O_TIME1_1)
    End Function
    Public Shared Function GetName_REQ_O_TIME1_2(ByVal REQ_O_TIME1_2 As String) As String
        Return GetName_REQ_O_TIME1(REQ_O_TIME1_2)
    End Function
    Public Shared Function GetName_REQ_O_TIME1_3(ByVal REQ_O_TIME1_3 As String) As String
        Return GetName_REQ_O_TIME1(REQ_O_TIME1_3)
    End Function
    Public Shared Function GetName_REQ_O_TIME1_4(ByVal REQ_O_TIME1_4 As String) As String
        Return GetName_REQ_O_TIME1(REQ_O_TIME1_4)
    End Function
    Public Shared Function GetName_REQ_O_TIME1_5(ByVal REQ_O_TIME1_5 As String) As String
        Return GetName_REQ_O_TIME1(REQ_O_TIME1_5)
    End Function

    '���H�F�������ԁi�˗��j
    Public Shared Function GetName_REQ_O_TIME2(ByVal REQ_O_TIME2 As String) As String
        Return REQ_O_TIME2
    End Function
    Public Shared Function GetName_REQ_O_TIME2_1(ByVal REQ_O_TIME2_1 As String) As String
        Return GetName_REQ_O_TIME2(REQ_O_TIME2_1)
    End Function
    Public Shared Function GetName_REQ_O_TIME2_2(ByVal REQ_O_TIME2_2 As String) As String
        Return GetName_REQ_O_TIME2(REQ_O_TIME2_2)
    End Function
    Public Shared Function GetName_REQ_O_TIME2_3(ByVal REQ_O_TIME2_3 As String) As String
        Return GetName_REQ_O_TIME2(REQ_O_TIME2_3)
    End Function
    Public Shared Function GetName_REQ_O_TIME2_4(ByVal REQ_O_TIME2_4 As String) As String
        Return GetName_REQ_O_TIME2(REQ_O_TIME2_4)
    End Function
    Public Shared Function GetName_REQ_O_TIME2_5(ByVal REQ_O_TIME2_5 As String) As String
        Return GetName_REQ_O_TIME2(REQ_O_TIME2_5)
    End Function

    '���H�F��Ԗ��E�֖��i�˗��j
    Public Shared Function GetName_REQ_O_BIN(ByVal REQ_O_BIN As String) As String
        Return REQ_O_BIN
    End Function
    Public Shared Function GetName_REQ_O_BIN_1(ByVal REQ_O_BIN_1 As String) As String
        Return GetName_REQ_O_BIN(REQ_O_BIN_1)
    End Function
    Public Shared Function GetName_REQ_O_BIN_2(ByVal REQ_O_BIN_2 As String) As String
        Return GetName_REQ_O_BIN(REQ_O_BIN_2)
    End Function
    Public Shared Function GetName_REQ_O_BIN_3(ByVal REQ_O_BIN_3 As String) As String
        Return GetName_REQ_O_BIN(REQ_O_BIN_3)
    End Function
    Public Shared Function GetName_REQ_O_BIN_4(ByVal REQ_O_BIN_4 As String) As String
        Return GetName_REQ_O_BIN(REQ_O_BIN_4)
    End Function
    Public Shared Function GetName_REQ_O_BIN_5(ByVal REQ_O_BIN_5 As String) As String
        Return GetName_REQ_O_BIN(REQ_O_BIN_5)
    End Function

    '���H�F���ȋ敪
    Public Shared Function GetName_REQ_O_SEAT(ByVal REQ_O_SEAT As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_O_SEAT Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_REQ_O_SEAT_1(ByVal REQ_O_SEAT_1 As String) As String
        Return GetName_REQ_O_SEAT(REQ_O_SEAT_1)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_2(ByVal REQ_O_SEAT_2 As String) As String
        Return GetName_REQ_O_SEAT(REQ_O_SEAT_2)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_3(ByVal REQ_O_SEAT_3 As String) As String
        Return GetName_REQ_O_SEAT(REQ_O_SEAT_3)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_4(ByVal REQ_O_SEAT_4 As String) As String
        Return GetName_REQ_O_SEAT(REQ_O_SEAT_4)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_5(ByVal REQ_O_SEAT_5 As String) As String
        Return GetName_REQ_O_SEAT(REQ_O_SEAT_5)
    End Function

    '���H�F���Ȋ�]
    Public Shared Function GetName_REQ_O_SEAT_KIBOU(ByVal REQ_O_SEAT_KIBOU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT_KIBOU AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_O_SEAT_KIBOU Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_REQ_O_SEAT_KIBOU_1(ByVal REQ_O_SEAT_KIBOU_1 As String) As String
        Return GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU_1)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_KIBOU_2(ByVal REQ_O_SEAT_KIBOU_2 As String) As String
        Return GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU_2)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_KIBOU_3(ByVal REQ_O_SEAT_KIBOU_3 As String) As String
        Return GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU_3)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_KIBOU_4(ByVal REQ_O_SEAT_KIBOU_4 As String) As String
        Return GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU_4)
    End Function
    Public Shared Function GetName_REQ_O_SEAT_KIBOU_5(ByVal REQ_O_SEAT_KIBOU_5 As String) As String
        Return GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU_5)
    End Function

    '���H�F�q�󓋏�ҔN��i�N��j
    Public Shared Function GetName_REQ_O_AGE(ByVal REQ_O_AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(REQ_O_AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = True Then
                Return Trim(REQ_O_AGE)
            Else
                Return Trim(REQ_O_AGE) & "��"
            End If
        End If
    End Function
    Public Shared Function GetName_REQ_O_AGE_1(ByVal REQ_O_AGE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_O_AGE(REQ_O_AGE_1, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_O_AGE_2(ByVal REQ_O_AGE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_O_AGE(REQ_O_AGE_2, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_O_AGE_3(ByVal REQ_O_AGE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_O_AGE(REQ_O_AGE_3, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_O_AGE_4(ByVal REQ_O_AGE_4 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_O_AGE(REQ_O_AGE_4, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_O_AGE_5(ByVal REQ_O_AGE_5 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_O_AGE(REQ_O_AGE_5, ShortFormat)
    End Function

    '���H�F�񓚃X�e�[�^�X
    Public Shared Function GetName_ANS_O_STATUS(ByVal ANS_O_STATUS As String) As String
        Select Case ANS_O_STATUS
            Case AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Prepare, AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK, AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Canceled, AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Canceled

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_ANS_O_STATUS_1(ByVal ANS_O_STATUS_1 As String) As String
        Return GetName_ANS_O_STATUS(ANS_O_STATUS_1)
    End Function
    Public Shared Function GetName_ANS_O_STATUS_2(ByVal ANS_O_STATUS_2 As String) As String
        Return GetName_ANS_O_STATUS(ANS_O_STATUS_2)
    End Function
    Public Shared Function GetName_ANS_O_STATUS_3(ByVal ANS_O_STATUS_3 As String) As String
        Return GetName_ANS_O_STATUS(ANS_O_STATUS_3)
    End Function
    Public Shared Function GetName_ANS_O_STATUS_4(ByVal ANS_O_STATUS_4 As String) As String
        Return GetName_ANS_O_STATUS(ANS_O_STATUS_4)
    End Function
    Public Shared Function GetName_ANS_O_STATUS_5(ByVal ANS_O_STATUS_5 As String) As String
        Return GetName_ANS_O_STATUS(ANS_O_STATUS_5)
    End Function

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Function GetName_ANS_O_KOTSUKIKAN(ByVal ANS_O_KOTSUKIKAN As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_O_KOTSUKIKAN Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_ANS_O_KOTSUKIKAN_1(ByVal ANS_O_KOTSUKIKAN_1 As String) As String
        Return GetName_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_1)
    End Function
    Public Shared Function GetName_ANS_O_KOTSUKIKAN_2(ByVal ANS_O_KOTSUKIKAN_2 As String) As String
        Return GetName_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_2)
    End Function
    Public Shared Function GetName_ANS_O_KOTSUKIKAN_3(ByVal ANS_O_KOTSUKIKAN_3 As String) As String
        Return GetName_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_3)
    End Function
    Public Shared Function GetName_ANS_O_KOTSUKIKAN_4(ByVal ANS_O_KOTSUKIKAN_4 As String) As String
        Return GetName_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_4)
    End Function
    Public Shared Function GetName_ANS_O_KOTSUKIKAN_5(ByVal ANS_O_KOTSUKIKAN_5 As String) As String
        Return GetName_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_5)
    End Function

    '���H�F���p���i�񓚁j
    Public Shared Function GetName_ANS_O_DATE(ByVal ANS_O_DATE As String) As String
        Return CmnModule.Format_Date(ANS_O_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_ANS_O_DATE_1(ByVal ANS_O_DATE_1 As String) As String
        Return GetName_ANS_O_DATE(ANS_O_DATE_1)
    End Function
    Public Shared Function GetName_ANS_O_DATE_2(ByVal ANS_O_DATE_2 As String) As String
        Return GetName_ANS_O_DATE(ANS_O_DATE_2)
    End Function
    Public Shared Function GetName_ANS_O_DATE_3(ByVal ANS_O_DATE_3 As String) As String
        Return GetName_ANS_O_DATE(ANS_O_DATE_3)
    End Function
    Public Shared Function GetName_ANS_O_DATE_4(ByVal ANS_O_DATE_4 As String) As String
        Return GetName_ANS_O_DATE(ANS_O_DATE_4)
    End Function
    Public Shared Function GetName_ANS_O_DATE_5(ByVal ANS_O_DATE_5 As String) As String
        Return GetName_ANS_O_DATE(ANS_O_DATE_5)
    End Function

    '���H�F�o���n�i�˗��j
    Public Shared Function GetName_ANS_O_AIRPORT1(ByVal ANS_O_AIRPORT1 As String) As String
        Return ANS_O_AIRPORT1
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT1_1(ByVal ANS_O_AIRPORT1_1 As String) As String
        Return GetName_ANS_O_AIRPORT1(ANS_O_AIRPORT1_1)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT1_2(ByVal ANS_O_AIRPORT1_2 As String) As String
        Return GetName_ANS_O_AIRPORT1(ANS_O_AIRPORT1_2)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT1_3(ByVal ANS_O_AIRPORT1_3 As String) As String
        Return GetName_ANS_O_AIRPORT1(ANS_O_AIRPORT1_3)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT1_4(ByVal ANS_O_AIRPORT1_4 As String) As String
        Return GetName_ANS_O_AIRPORT1(ANS_O_AIRPORT1_4)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT1_5(ByVal ANS_O_AIRPORT1_5 As String) As String
        Return GetName_ANS_O_AIRPORT1(ANS_O_AIRPORT1_5)
    End Function

    '���H�F�����n�i�˗��j
    Public Shared Function GetName_ANS_O_AIRPORT2(ByVal ANS_O_AIRPORT2 As String) As String
        Return ANS_O_AIRPORT2
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT2_1(ByVal ANS_O_AIRPORT2_1 As String) As String
        Return GetName_ANS_O_AIRPORT2(ANS_O_AIRPORT2_1)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT2_2(ByVal ANS_O_AIRPORT2_2 As String) As String
        Return GetName_ANS_O_AIRPORT2(ANS_O_AIRPORT2_2)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT2_3(ByVal ANS_O_AIRPORT2_3 As String) As String
        Return GetName_ANS_O_AIRPORT2(ANS_O_AIRPORT2_3)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT2_4(ByVal ANS_O_AIRPORT2_4 As String) As String
        Return GetName_ANS_O_AIRPORT2(ANS_O_AIRPORT2_4)
    End Function
    Public Shared Function GetName_ANS_O_AIRPORT2_5(ByVal ANS_O_AIRPORT2_5 As String) As String
        Return GetName_ANS_O_AIRPORT2(ANS_O_AIRPORT2_5)
    End Function

    '���H�F�o�����ԁi�˗��j
    Public Shared Function GetName_ANS_O_TIME1(ByVal ANS_O_TIME1 As String) As String
        Return ANS_O_TIME1
    End Function
    Public Shared Function GetName_ANS_O_TIME1_1(ByVal ANS_O_TIME1_1 As String) As String
        Return GetName_ANS_O_TIME1(ANS_O_TIME1_1)
    End Function
    Public Shared Function GetName_ANS_O_TIME1_2(ByVal ANS_O_TIME1_2 As String) As String
        Return GetName_ANS_O_TIME1(ANS_O_TIME1_2)
    End Function
    Public Shared Function GetName_ANS_O_TIME1_3(ByVal ANS_O_TIME1_3 As String) As String
        Return GetName_ANS_O_TIME1(ANS_O_TIME1_3)
    End Function
    Public Shared Function GetName_ANS_O_TIME1_4(ByVal ANS_O_TIME1_4 As String) As String
        Return GetName_ANS_O_TIME1(ANS_O_TIME1_4)
    End Function
    Public Shared Function GetName_ANS_O_TIME1_5(ByVal ANS_O_TIME1_5 As String) As String
        Return GetName_ANS_O_TIME1(ANS_O_TIME1_5)
    End Function

    '���H�F�������ԁi�˗��j
    Public Shared Function GetName_ANS_O_TIME2(ByVal ANS_O_TIME2 As String) As String
        Return ANS_O_TIME2
    End Function
    Public Shared Function GetName_ANS_O_TIME2_1(ByVal ANS_O_TIME2_1 As String) As String
        Return GetName_ANS_O_TIME2(ANS_O_TIME2_1)
    End Function
    Public Shared Function GetName_ANS_O_TIME2_2(ByVal ANS_O_TIME2_2 As String) As String
        Return GetName_ANS_O_TIME2(ANS_O_TIME2_2)
    End Function
    Public Shared Function GetName_ANS_O_TIME2_3(ByVal ANS_O_TIME2_3 As String) As String
        Return GetName_ANS_O_TIME2(ANS_O_TIME2_3)
    End Function
    Public Shared Function GetName_ANS_O_TIME2_4(ByVal ANS_O_TIME2_4 As String) As String
        Return GetName_ANS_O_TIME2(ANS_O_TIME2_4)
    End Function
    Public Shared Function GetName_ANS_O_TIME2_5(ByVal ANS_O_TIME2_5 As String) As String
        Return GetName_ANS_O_TIME2(ANS_O_TIME2_5)
    End Function

    '���H�F��Ԗ��E�֖��i�˗��j
    Public Shared Function GetName_ANS_O_BIN(ByVal ANS_O_BIN As String) As String
        Return ANS_O_BIN
    End Function
    Public Shared Function GetName_ANS_O_BIN_1(ByVal ANS_O_BIN_1 As String) As String
        Return GetName_ANS_O_BIN(ANS_O_BIN_1)
    End Function
    Public Shared Function GetName_ANS_O_BIN_2(ByVal ANS_O_BIN_2 As String) As String
        Return GetName_ANS_O_BIN(ANS_O_BIN_2)
    End Function
    Public Shared Function GetName_ANS_O_BIN_3(ByVal ANS_O_BIN_3 As String) As String
        Return GetName_ANS_O_BIN(ANS_O_BIN_3)
    End Function
    Public Shared Function GetName_ANS_O_BIN_4(ByVal ANS_O_BIN_4 As String) As String
        Return GetName_ANS_O_BIN(ANS_O_BIN_4)
    End Function
    Public Shared Function GetName_ANS_O_BIN_5(ByVal ANS_O_BIN_5 As String) As String
        Return GetName_ANS_O_BIN(ANS_O_BIN_5)
    End Function

    '���H�F���ȋ敪
    Public Shared Function GetName_ANS_O_SEAT(ByVal ANS_O_SEAT As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_O_SEAT Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_ANS_O_SEAT_1(ByVal ANS_O_SEAT_1 As String) As String
        Return GetName_ANS_O_SEAT(ANS_O_SEAT_1)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_2(ByVal ANS_O_SEAT_2 As String) As String
        Return GetName_ANS_O_SEAT(ANS_O_SEAT_2)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_3(ByVal ANS_O_SEAT_3 As String) As String
        Return GetName_ANS_O_SEAT(ANS_O_SEAT_3)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_4(ByVal ANS_O_SEAT_4 As String) As String
        Return GetName_ANS_O_SEAT(ANS_O_SEAT_4)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_5(ByVal ANS_O_SEAT_5 As String) As String
        Return GetName_ANS_O_SEAT(ANS_O_SEAT_5)
    End Function

    '���H�F���Ȋ�]
    Public Shared Function GetName_ANS_O_SEAT_KIBOU(ByVal ANS_O_SEAT_KIBOU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT_KIBOU AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_O_SEAT_KIBOU Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_ANS_O_SEAT_KIBOU_1(ByVal ANS_O_SEAT_KIBOU_1 As String) As String
        Return GetName_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_1)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_KIBOU_2(ByVal ANS_O_SEAT_KIBOU_2 As String) As String
        Return GetName_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_2)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_KIBOU_3(ByVal ANS_O_SEAT_KIBOU_3 As String) As String
        Return GetName_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_3)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_KIBOU_4(ByVal ANS_O_SEAT_KIBOU_4 As String) As String
        Return GetName_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_4)
    End Function
    Public Shared Function GetName_ANS_O_SEAT_KIBOU_5(ByVal ANS_O_SEAT_KIBOU_5 As String) As String
        Return GetName_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_5)
    End Function

    '���H�F��ʎ�z
    Public Shared Function GetName_REQ_F_TEHAI(ByVal REQ_F_TEHAI As String) As String
        Select Case REQ_F_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes, AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.Yes
                Return AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.Yes
            Case AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.No, AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.No
                Return AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_REQ_F_TEHAI_1(ByVal REQ_F_TEHAI_1 As String) As String
        Return GetName_REQ_F_TEHAI(REQ_F_TEHAI_1)
    End Function
    Public Shared Function GetName_REQ_F_TEHAI_2(ByVal REQ_F_TEHAI_2 As String) As String
        Return GetName_REQ_F_TEHAI(REQ_F_TEHAI_2)
    End Function
    Public Shared Function GetName_REQ_F_TEHAI_3(ByVal REQ_F_TEHAI_3 As String) As String
        Return GetName_REQ_F_TEHAI(REQ_F_TEHAI_3)
    End Function
    Public Shared Function GetName_REQ_F_TEHAI_4(ByVal REQ_F_TEHAI_4 As String) As String
        Return GetName_REQ_F_TEHAI(REQ_F_TEHAI_4)
    End Function
    Public Shared Function GetName_REQ_F_TEHAI_5(ByVal REQ_F_TEHAI_5 As String) As String
        Return GetName_REQ_F_TEHAI(REQ_F_TEHAI_5)
    End Function

    '���H�F��ʈ˗����e
    Public Shared Function GetName_REQ_F_IRAINAIYOU(ByVal REQ_F_IRAINAIYOU As String) As String
        Select Case REQ_F_IRAINAIYOU
            Case AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Code.Tehai, AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Name.Tehai
                Return AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Name.Tehai
            Case AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Code.Change, AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Name.Change
                Return AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Name.Change
            Case AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Code.Cancel, AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Name.Cancel
                Return AppConst.KOTSUHOTEL.REQ_F_IRAINAIYOU.Name.Cancel

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_REQ_F_IRAINAIYOU_1(ByVal REQ_F_IRAINAIYOU_1 As String) As String
        Return GetName_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_1)
    End Function
    Public Shared Function GetName_REQ_F_IRAINAIYOU_2(ByVal REQ_F_IRAINAIYOU_2 As String) As String
        Return GetName_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_2)
    End Function
    Public Shared Function GetName_REQ_F_IRAINAIYOU_3(ByVal REQ_F_IRAINAIYOU_3 As String) As String
        Return GetName_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_3)
    End Function
    Public Shared Function GetName_REQ_F_IRAINAIYOU_4(ByVal REQ_F_IRAINAIYOU_4 As String) As String
        Return GetName_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_4)
    End Function
    Public Shared Function GetName_REQ_F_IRAINAIYOU_5(ByVal REQ_F_IRAINAIYOU_5 As String) As String
        Return GetName_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_5)
    End Function

    '���H�F��ʋ@��
    Public Shared Function GetName_REQ_F_KOTSUKIKAN(ByVal REQ_F_KOTSUKIKAN As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_F_KOTSUKIKAN Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_REQ_F_KOTSUKIKAN_1(ByVal REQ_F_KOTSUKIKAN_1 As String) As String
        Return GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_1)
    End Function
    Public Shared Function GetName_REQ_F_KOTSUKIKAN_2(ByVal REQ_F_KOTSUKIKAN_2 As String) As String
        Return GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_2)
    End Function
    Public Shared Function GetName_REQ_F_KOTSUKIKAN_3(ByVal REQ_F_KOTSUKIKAN_3 As String) As String
        Return GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_3)
    End Function
    Public Shared Function GetName_REQ_F_KOTSUKIKAN_4(ByVal REQ_F_KOTSUKIKAN_4 As String) As String
        Return GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_4)
    End Function
    Public Shared Function GetName_REQ_F_KOTSUKIKAN_5(ByVal REQ_F_KOTSUKIKAN_5 As String) As String
        Return GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_5)
    End Function

    '���H�F���p���i�˗��j
    Public Shared Function GetName_REQ_F_DATE(ByVal REQ_F_DATE As String) As String
        Return CmnModule.Format_Date(REQ_F_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_REQ_F_DATE_1(ByVal REQ_F_DATE_1 As String) As String
        Return GetName_REQ_F_DATE(REQ_F_DATE_1)
    End Function
    Public Shared Function GetName_REQ_F_DATE_2(ByVal REQ_F_DATE_2 As String) As String
        Return GetName_REQ_F_DATE(REQ_F_DATE_2)
    End Function
    Public Shared Function GetName_REQ_F_DATE_3(ByVal REQ_F_DATE_3 As String) As String
        Return GetName_REQ_F_DATE(REQ_F_DATE_3)
    End Function
    Public Shared Function GetName_REQ_F_DATE_4(ByVal REQ_F_DATE_4 As String) As String
        Return GetName_REQ_F_DATE(REQ_F_DATE_4)
    End Function
    Public Shared Function GetName_REQ_F_DATE_5(ByVal REQ_F_DATE_5 As String) As String
        Return GetName_REQ_F_DATE(REQ_F_DATE_5)
    End Function

    '���H�F�o���n�i�˗��j
    Public Shared Function GetName_REQ_F_AIRPORT1(ByVal REQ_F_AIRPORT1 As String) As String
        Return REQ_F_AIRPORT1
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT1_1(ByVal REQ_F_AIRPORT1_1 As String) As String
        Return GetName_REQ_F_AIRPORT1(REQ_F_AIRPORT1_1)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT1_2(ByVal REQ_F_AIRPORT1_2 As String) As String
        Return GetName_REQ_F_AIRPORT1(REQ_F_AIRPORT1_2)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT1_3(ByVal REQ_F_AIRPORT1_3 As String) As String
        Return GetName_REQ_F_AIRPORT1(REQ_F_AIRPORT1_3)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT1_4(ByVal REQ_F_AIRPORT1_4 As String) As String
        Return GetName_REQ_F_AIRPORT1(REQ_F_AIRPORT1_4)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT1_5(ByVal REQ_F_AIRPORT1_5 As String) As String
        Return GetName_REQ_F_AIRPORT1(REQ_F_AIRPORT1_5)
    End Function

    '���H�F�����n�i�˗��j
    Public Shared Function GetName_REQ_F_AIRPORT2(ByVal REQ_F_AIRPORT2 As String) As String
        Return REQ_F_AIRPORT2
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT2_1(ByVal REQ_F_AIRPORT2_1 As String) As String
        Return GetName_REQ_F_AIRPORT2(REQ_F_AIRPORT2_1)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT2_2(ByVal REQ_F_AIRPORT2_2 As String) As String
        Return GetName_REQ_F_AIRPORT2(REQ_F_AIRPORT2_2)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT2_3(ByVal REQ_F_AIRPORT2_3 As String) As String
        Return GetName_REQ_F_AIRPORT2(REQ_F_AIRPORT2_3)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT2_4(ByVal REQ_F_AIRPORT2_4 As String) As String
        Return GetName_REQ_F_AIRPORT2(REQ_F_AIRPORT2_4)
    End Function
    Public Shared Function GetName_REQ_F_AIRPORT2_5(ByVal REQ_F_AIRPORT2_5 As String) As String
        Return GetName_REQ_F_AIRPORT2(REQ_F_AIRPORT2_5)
    End Function

    '���H�F�o�����ԁi�˗��j
    Public Shared Function GetName_REQ_F_TIME1(ByVal REQ_F_TIME1 As String) As String
        Return REQ_F_TIME1
    End Function
    Public Shared Function GetName_REQ_F_TIME1_1(ByVal REQ_F_TIME1_1 As String) As String
        Return GetName_REQ_F_TIME1(REQ_F_TIME1_1)
    End Function
    Public Shared Function GetName_REQ_F_TIME1_2(ByVal REQ_F_TIME1_2 As String) As String
        Return GetName_REQ_F_TIME1(REQ_F_TIME1_2)
    End Function
    Public Shared Function GetName_REQ_F_TIME1_3(ByVal REQ_F_TIME1_3 As String) As String
        Return GetName_REQ_F_TIME1(REQ_F_TIME1_3)
    End Function
    Public Shared Function GetName_REQ_F_TIME1_4(ByVal REQ_F_TIME1_4 As String) As String
        Return GetName_REQ_F_TIME1(REQ_F_TIME1_4)
    End Function
    Public Shared Function GetName_REQ_F_TIME1_5(ByVal REQ_F_TIME1_5 As String) As String
        Return GetName_REQ_F_TIME1(REQ_F_TIME1_5)
    End Function

    '���H�F�������ԁi�˗��j
    Public Shared Function GetName_REQ_F_TIME2(ByVal REQ_F_TIME2 As String) As String
        Return REQ_F_TIME2
    End Function
    Public Shared Function GetName_REQ_F_TIME2_1(ByVal REQ_F_TIME2_1 As String) As String
        Return GetName_REQ_F_TIME2(REQ_F_TIME2_1)
    End Function
    Public Shared Function GetName_REQ_F_TIME2_2(ByVal REQ_F_TIME2_2 As String) As String
        Return GetName_REQ_F_TIME2(REQ_F_TIME2_2)
    End Function
    Public Shared Function GetName_REQ_F_TIME2_3(ByVal REQ_F_TIME2_3 As String) As String
        Return GetName_REQ_F_TIME2(REQ_F_TIME2_3)
    End Function
    Public Shared Function GetName_REQ_F_TIME2_4(ByVal REQ_F_TIME2_4 As String) As String
        Return GetName_REQ_F_TIME2(REQ_F_TIME2_4)
    End Function
    Public Shared Function GetName_REQ_F_TIME2_5(ByVal REQ_F_TIME2_5 As String) As String
        Return GetName_REQ_F_TIME2(REQ_F_TIME2_5)
    End Function

    '���H�F��Ԗ��E�֖��i�˗��j
    Public Shared Function GetName_REQ_F_BIN(ByVal REQ_F_BIN As String) As String
        Return REQ_F_BIN
    End Function
    Public Shared Function GetName_REQ_F_BIN_1(ByVal REQ_F_BIN_1 As String) As String
        Return GetName_REQ_F_BIN(REQ_F_BIN_1)
    End Function
    Public Shared Function GetName_REQ_F_BIN_2(ByVal REQ_F_BIN_2 As String) As String
        Return GetName_REQ_F_BIN(REQ_F_BIN_2)
    End Function
    Public Shared Function GetName_REQ_F_BIN_3(ByVal REQ_F_BIN_3 As String) As String
        Return GetName_REQ_F_BIN(REQ_F_BIN_3)
    End Function
    Public Shared Function GetName_REQ_F_BIN_4(ByVal REQ_F_BIN_4 As String) As String
        Return GetName_REQ_F_BIN(REQ_F_BIN_4)
    End Function
    Public Shared Function GetName_REQ_F_BIN_5(ByVal REQ_F_BIN_5 As String) As String
        Return GetName_REQ_F_BIN(REQ_F_BIN_5)
    End Function

    '���H�F���ȋ敪
    Public Shared Function GetName_REQ_F_SEAT(ByVal REQ_F_SEAT As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_F_SEAT Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_REQ_F_SEAT_1(ByVal REQ_F_SEAT_1 As String) As String
        Return GetName_REQ_F_SEAT(REQ_F_SEAT_1)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_2(ByVal REQ_F_SEAT_2 As String) As String
        Return GetName_REQ_F_SEAT(REQ_F_SEAT_2)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_3(ByVal REQ_F_SEAT_3 As String) As String
        Return GetName_REQ_F_SEAT(REQ_F_SEAT_3)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_4(ByVal REQ_F_SEAT_4 As String) As String
        Return GetName_REQ_F_SEAT(REQ_F_SEAT_4)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_5(ByVal REQ_F_SEAT_5 As String) As String
        Return GetName_REQ_F_SEAT(REQ_F_SEAT_5)
    End Function

    '���H�F���Ȋ�]
    Public Shared Function GetName_REQ_F_SEAT_KIBOU(ByVal REQ_F_SEAT_KIBOU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT_KIBOU AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_F_SEAT_KIBOU Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_REQ_F_SEAT_KIBOU_1(ByVal REQ_F_SEAT_KIBOU_1 As String) As String
        Return GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU_1)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_KIBOU_2(ByVal REQ_F_SEAT_KIBOU_2 As String) As String
        Return GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU_2)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_KIBOU_3(ByVal REQ_F_SEAT_KIBOU_3 As String) As String
        Return GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU_3)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_KIBOU_4(ByVal REQ_F_SEAT_KIBOU_4 As String) As String
        Return GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU_4)
    End Function
    Public Shared Function GetName_REQ_F_SEAT_KIBOU_5(ByVal REQ_F_SEAT_KIBOU_5 As String) As String
        Return GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU_5)
    End Function

    '���H�F�q�󓋏�ҔN��i�N��j
    Public Shared Function GetName_REQ_F_AGE(ByVal REQ_F_AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(REQ_F_AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = True Then
                Return Trim(REQ_F_AGE)
            Else
                Return Trim(REQ_F_AGE) & "��"
            End If
        End If
    End Function
    Public Shared Function GetName_REQ_F_AGE_1(ByVal REQ_F_AGE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_F_AGE(REQ_F_AGE_1, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_F_AGE_2(ByVal REQ_F_AGE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_F_AGE(REQ_F_AGE_2, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_F_AGE_3(ByVal REQ_F_AGE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_F_AGE(REQ_F_AGE_3, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_F_AGE_4(ByVal REQ_F_AGE_4 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_F_AGE(REQ_F_AGE_4, ShortFormat)
    End Function
    Public Shared Function GetName_REQ_F_AGE_5(ByVal REQ_F_AGE_5 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_REQ_F_AGE(REQ_F_AGE_5, ShortFormat)
    End Function

    '���H�F�񓚃X�e�[�^�X
    Public Shared Function GetName_ANS_F_STATUS(ByVal ANS_F_STATUS As String) As String
        Select Case ANS_F_STATUS
            Case AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Prepare, AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK, AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Canceled, AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Canceled

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_ANS_F_STATUS_1(ByVal ANS_F_STATUS_1 As String) As String
        Return GetName_ANS_F_STATUS(ANS_F_STATUS_1)
    End Function
    Public Shared Function GetName_ANS_F_STATUS_2(ByVal ANS_F_STATUS_2 As String) As String
        Return GetName_ANS_F_STATUS(ANS_F_STATUS_2)
    End Function
    Public Shared Function GetName_ANS_F_STATUS_3(ByVal ANS_F_STATUS_3 As String) As String
        Return GetName_ANS_F_STATUS(ANS_F_STATUS_3)
    End Function
    Public Shared Function GetName_ANS_F_STATUS_4(ByVal ANS_F_STATUS_4 As String) As String
        Return GetName_ANS_F_STATUS(ANS_F_STATUS_4)
    End Function
    Public Shared Function GetName_ANS_F_STATUS_5(ByVal ANS_F_STATUS_5 As String) As String
        Return GetName_ANS_F_STATUS(ANS_F_STATUS_5)
    End Function

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Function GetName_ANS_F_KOTSUKIKAN(ByVal ANS_F_KOTSUKIKAN As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_F_KOTSUKIKAN Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_ANS_F_KOTSUKIKAN_1(ByVal ANS_F_KOTSUKIKAN_1 As String) As String
        Return GetName_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_1)
    End Function
    Public Shared Function GetName_ANS_F_KOTSUKIKAN_2(ByVal ANS_F_KOTSUKIKAN_2 As String) As String
        Return GetName_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_2)
    End Function
    Public Shared Function GetName_ANS_F_KOTSUKIKAN_3(ByVal ANS_F_KOTSUKIKAN_3 As String) As String
        Return GetName_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_3)
    End Function
    Public Shared Function GetName_ANS_F_KOTSUKIKAN_4(ByVal ANS_F_KOTSUKIKAN_4 As String) As String
        Return GetName_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_4)
    End Function
    Public Shared Function GetName_ANS_F_KOTSUKIKAN_5(ByVal ANS_F_KOTSUKIKAN_5 As String) As String
        Return GetName_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_5)
    End Function

    '���H�F���p���i�񓚁j
    Public Shared Function GetName_ANS_F_DATE(ByVal ANS_F_DATE As String) As String
        Return CmnModule.Format_Date(ANS_F_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_ANS_F_DATE_1(ByVal ANS_F_DATE_1 As String) As String
        Return GetName_ANS_F_DATE(ANS_F_DATE_1)
    End Function
    Public Shared Function GetName_ANS_F_DATE_2(ByVal ANS_F_DATE_2 As String) As String
        Return GetName_ANS_F_DATE(ANS_F_DATE_2)
    End Function
    Public Shared Function GetName_ANS_F_DATE_3(ByVal ANS_F_DATE_3 As String) As String
        Return GetName_ANS_F_DATE(ANS_F_DATE_3)
    End Function
    Public Shared Function GetName_ANS_F_DATE_4(ByVal ANS_F_DATE_4 As String) As String
        Return GetName_ANS_F_DATE(ANS_F_DATE_4)
    End Function
    Public Shared Function GetName_ANS_F_DATE_5(ByVal ANS_F_DATE_5 As String) As String
        Return GetName_ANS_F_DATE(ANS_F_DATE_5)
    End Function

    '���H�F�o���n�i�˗��j
    Public Shared Function GetName_ANS_F_AIRPORT1(ByVal ANS_F_AIRPORT1 As String) As String
        Return ANS_F_AIRPORT1
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT1_1(ByVal ANS_F_AIRPORT1_1 As String) As String
        Return GetName_ANS_F_AIRPORT1(ANS_F_AIRPORT1_1)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT1_2(ByVal ANS_F_AIRPORT1_2 As String) As String
        Return GetName_ANS_F_AIRPORT1(ANS_F_AIRPORT1_2)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT1_3(ByVal ANS_F_AIRPORT1_3 As String) As String
        Return GetName_ANS_F_AIRPORT1(ANS_F_AIRPORT1_3)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT1_4(ByVal ANS_F_AIRPORT1_4 As String) As String
        Return GetName_ANS_F_AIRPORT1(ANS_F_AIRPORT1_4)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT1_5(ByVal ANS_F_AIRPORT1_5 As String) As String
        Return GetName_ANS_F_AIRPORT1(ANS_F_AIRPORT1_5)
    End Function

    '���H�F�����n�i�˗��j
    Public Shared Function GetName_ANS_F_AIRPORT2(ByVal ANS_F_AIRPORT2 As String) As String
        Return ANS_F_AIRPORT2
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT2_1(ByVal ANS_F_AIRPORT2_1 As String) As String
        Return GetName_ANS_F_AIRPORT2(ANS_F_AIRPORT2_1)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT2_2(ByVal ANS_F_AIRPORT2_2 As String) As String
        Return GetName_ANS_F_AIRPORT2(ANS_F_AIRPORT2_2)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT2_3(ByVal ANS_F_AIRPORT2_3 As String) As String
        Return GetName_ANS_F_AIRPORT2(ANS_F_AIRPORT2_3)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT2_4(ByVal ANS_F_AIRPORT2_4 As String) As String
        Return GetName_ANS_F_AIRPORT2(ANS_F_AIRPORT2_4)
    End Function
    Public Shared Function GetName_ANS_F_AIRPORT2_5(ByVal ANS_F_AIRPORT2_5 As String) As String
        Return GetName_ANS_F_AIRPORT2(ANS_F_AIRPORT2_5)
    End Function

    '���H�F�o�����ԁi�˗��j
    Public Shared Function GetName_ANS_F_TIME1(ByVal ANS_F_TIME1 As String) As String
        Return ANS_F_TIME1
    End Function
    Public Shared Function GetName_ANS_F_TIME1_1(ByVal ANS_F_TIME1_1 As String) As String
        Return GetName_ANS_F_TIME1(ANS_F_TIME1_1)
    End Function
    Public Shared Function GetName_ANS_F_TIME1_2(ByVal ANS_F_TIME1_2 As String) As String
        Return GetName_ANS_F_TIME1(ANS_F_TIME1_2)
    End Function
    Public Shared Function GetName_ANS_F_TIME1_3(ByVal ANS_F_TIME1_3 As String) As String
        Return GetName_ANS_F_TIME1(ANS_F_TIME1_3)
    End Function
    Public Shared Function GetName_ANS_F_TIME1_4(ByVal ANS_F_TIME1_4 As String) As String
        Return GetName_ANS_F_TIME1(ANS_F_TIME1_4)
    End Function
    Public Shared Function GetName_ANS_F_TIME1_5(ByVal ANS_F_TIME1_5 As String) As String
        Return GetName_ANS_F_TIME1(ANS_F_TIME1_5)
    End Function

    '���H�F�������ԁi�˗��j
    Public Shared Function GetName_ANS_F_TIME2(ByVal ANS_F_TIME2 As String) As String
        Return ANS_F_TIME2
    End Function
    Public Shared Function GetName_ANS_F_TIME2_1(ByVal ANS_F_TIME2_1 As String) As String
        Return GetName_ANS_F_TIME2(ANS_F_TIME2_1)
    End Function
    Public Shared Function GetName_ANS_F_TIME2_2(ByVal ANS_F_TIME2_2 As String) As String
        Return GetName_ANS_F_TIME2(ANS_F_TIME2_2)
    End Function
    Public Shared Function GetName_ANS_F_TIME2_3(ByVal ANS_F_TIME2_3 As String) As String
        Return GetName_ANS_F_TIME2(ANS_F_TIME2_3)
    End Function
    Public Shared Function GetName_ANS_F_TIME2_4(ByVal ANS_F_TIME2_4 As String) As String
        Return GetName_ANS_F_TIME2(ANS_F_TIME2_4)
    End Function
    Public Shared Function GetName_ANS_F_TIME2_5(ByVal ANS_F_TIME2_5 As String) As String
        Return GetName_ANS_F_TIME2(ANS_F_TIME2_5)
    End Function

    '���H�F��Ԗ��E�֖��i�˗��j
    Public Shared Function GetName_ANS_F_BIN(ByVal ANS_F_BIN As String) As String
        Return ANS_F_BIN
    End Function
    Public Shared Function GetName_ANS_F_BIN_1(ByVal ANS_F_BIN_1 As String) As String
        Return GetName_ANS_F_BIN(ANS_F_BIN_1)
    End Function
    Public Shared Function GetName_ANS_F_BIN_2(ByVal ANS_F_BIN_2 As String) As String
        Return GetName_ANS_F_BIN(ANS_F_BIN_2)
    End Function
    Public Shared Function GetName_ANS_F_BIN_3(ByVal ANS_F_BIN_3 As String) As String
        Return GetName_ANS_F_BIN(ANS_F_BIN_3)
    End Function
    Public Shared Function GetName_ANS_F_BIN_4(ByVal ANS_F_BIN_4 As String) As String
        Return GetName_ANS_F_BIN(ANS_F_BIN_4)
    End Function
    Public Shared Function GetName_ANS_F_BIN_5(ByVal ANS_F_BIN_5 As String) As String
        Return GetName_ANS_F_BIN(ANS_F_BIN_5)
    End Function

    '���H�F���ȋ敪
    Public Shared Function GetName_ANS_F_SEAT(ByVal ANS_F_SEAT As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_F_SEAT Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_ANS_F_SEAT_1(ByVal ANS_F_SEAT_1 As String) As String
        Return GetName_ANS_F_SEAT(ANS_F_SEAT_1)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_2(ByVal ANS_F_SEAT_2 As String) As String
        Return GetName_ANS_F_SEAT(ANS_F_SEAT_2)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_3(ByVal ANS_F_SEAT_3 As String) As String
        Return GetName_ANS_F_SEAT(ANS_F_SEAT_3)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_4(ByVal ANS_F_SEAT_4 As String) As String
        Return GetName_ANS_F_SEAT(ANS_F_SEAT_4)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_5(ByVal ANS_F_SEAT_5 As String) As String
        Return GetName_ANS_F_SEAT(ANS_F_SEAT_5)
    End Function

    '���H�F���Ȋ�]
    Public Shared Function GetName_ANS_F_SEAT_KIBOU(ByVal ANS_F_SEAT_KIBOU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT_KIBOU AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_F_SEAT_KIBOU Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
    Public Shared Function GetName_ANS_F_SEAT_KIBOU_1(ByVal ANS_F_SEAT_KIBOU_1 As String) As String
        Return GetName_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_1)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_KIBOU_2(ByVal ANS_F_SEAT_KIBOU_2 As String) As String
        Return GetName_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_2)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_KIBOU_3(ByVal ANS_F_SEAT_KIBOU_3 As String) As String
        Return GetName_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_3)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_KIBOU_4(ByVal ANS_F_SEAT_KIBOU_4 As String) As String
        Return GetName_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_4)
    End Function
    Public Shared Function GetName_ANS_F_SEAT_KIBOU_5(ByVal ANS_F_SEAT_KIBOU_5 As String) As String
        Return GetName_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_5)
    End Function

    '���H���l�i�˗��j
    Public Shared Function GetName_REQ_O_NOTE_1(ByVal REQ_O_NOTE_1 As String) As String
        Return REQ_O_NOTE_1
    End Function

    '���H���l�i�񓚁j
    Public Shared Function GetName_ANS_O_NOTE_1(ByVal ANS_O_NOTE_1 As String) As String
        Return ANS_O_NOTE_1
    End Function

    '���H���l�i�˗��j
    Public Shared Function GetName_REQ_F_NOTE_1(ByVal REQ_F_NOTE_1 As String) As String
        Return REQ_F_NOTE_1
    End Function

    '���H���l�i�񓚁j
    Public Shared Function GetName_ANS_F_NOTE_1(ByVal ANS_F_NOTE_1 As String) As String
        Return ANS_F_NOTE_1
    End Function

    '�y�m��zJR�E�S�����
    Public Shared Function GetName_FIX_RAIL_FARE(ByVal FIX_RAIL_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(FIX_RAIL_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(FIX_RAIL_FARE).ToString("#,#")
            Else
                Return FIX_RAIL_FARE
            End If
        End If
    End Function

    '�y�m��zJR�E�S�������
    Public Shared Function GetName_FIX_RAIL_CANCELLATION(ByVal FIX_RAIL_CANCELLATION As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(FIX_RAIL_CANCELLATION) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(FIX_RAIL_CANCELLATION).ToString("#,#")
            Else
                Return FIX_RAIL_CANCELLATION
            End If
        End If
    End Function

    '�y�m��z�q�󌔑��
    Public Shared Function GetName_FIX_AIR_FARE(ByVal FIX_AIR_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(FIX_AIR_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(FIX_AIR_FARE).ToString("#,#")
            Else
                Return FIX_AIR_FARE
            End If
        End If
    End Function

    '�y�m��z�q�󌔎����
    Public Shared Function GetName_FIX_AIR_CANCELLATION(ByVal FIX_AIR_CANCELLATION As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(FIX_AIR_CANCELLATION) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(FIX_AIR_CANCELLATION).ToString("#,#")
            Else
                Return FIX_AIR_CANCELLATION
            End If
        End If
    End Function

    '�y�m��z�o�X�E�D�����
    Public Shared Function GetName_FIX_OTHER_FARE(ByVal FIX_OTHER_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(FIX_OTHER_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(FIX_OTHER_FARE).ToString("#,#")
            Else
                Return FIX_OTHER_FARE
            End If
        End If
    End Function

    '�y�m��z�o�X�E�D�������
    Public Shared Function GetName_FIX_OTHER_CANCELLATION(ByVal FIX_OTHER_CANCELLATION As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(FIX_OTHER_CANCELLATION) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(FIX_OTHER_CANCELLATION).ToString("#,#")
            Else
                Return FIX_OTHER_CANCELLATION
            End If
        End If
    End Function

    '�o�^�Ǘ��萔��
    Public Shared Function GetName_TOUROKUKANRI_FEE(ByVal TOUROKUKANRI_FEE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(TOUROKUKANRI_FEE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(TOUROKUKANRI_FEE).ToString("#,#")
            Else
                Return TOUROKUKANRI_FEE
            End If
        End If
    End Function

    '�^�N�`�P�����萔��
    Public Shared Function GetName_TAXI_HAKKEN_FEE(ByVal TAXI_HAKKEN_FEE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(TAXI_HAKKEN_FEE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(TAXI_HAKKEN_FEE).ToString("#,#")
            Else
                Return TAXI_HAKKEN_FEE
            End If
        End If
    End Function

    '�^�N�`�P���Z�萔��
    Public Shared Function GetName_TAXI_SEISAN_FEE(ByVal TAXI_SEISAN_FEE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(TAXI_SEISAN_FEE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(TAXI_SEISAN_FEE).ToString("#,#")
            Else
                Return TAXI_SEISAN_FEE
            End If
        End If
    End Function

    '�^�N�V�[�`�P�b�g
    Public Shared Function GetName_TEHAI_TAXI(ByVal TEHAI_TAXI As String) As String
        Select Case TEHAI_TAXI
            Case AppConst.KOTSUHOTEL.TEHAI_TAXI.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.Yes
                Return AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.Yes
            Case AppConst.KOTSUHOTEL.TEHAI_TAXI.Code.No, AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.No
                Return AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.No

            Case Else
                Return ""
        End Select
    End Function

    '�^�N�V�[�`�P�b�g�\����
    Public Shared Function GetName_TAXI_MOUSHIKOMI_SAKI(ByVal TAXI_MOUSHIKOMI_SAKI As String) As String
        Return TAXI_MOUSHIKOMI_SAKI
    End Function

    '�^�N�V�[�`�P�b�g�F���p���i�˗��j
    Public Shared Function GetName_REQ_TAXI_DATE(ByVal REQ_TAXI_DATE As String) As String
        Return CmnModule.Format_Date(REQ_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_1(ByVal REQ_TAXI_DATE_1 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_1)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_2(ByVal REQ_TAXI_DATE_2 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_2)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_3(ByVal REQ_TAXI_DATE_3 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_3)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_4(ByVal REQ_TAXI_DATE_4 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_4)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_5(ByVal REQ_TAXI_DATE_5 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_5)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_6(ByVal REQ_TAXI_DATE_6 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_6)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_7(ByVal REQ_TAXI_DATE_7 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_7)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_8(ByVal REQ_TAXI_DATE_8 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_8)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_9(ByVal REQ_TAXI_DATE_9 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_9)
    End Function
    Public Shared Function GetName_REQ_TAXI_DATE_10(ByVal REQ_TAXI_DATE_10 As String) As String
        Return GetName_REQ_TAXI_DATE(REQ_TAXI_DATE_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���n�i�˗��j
    Public Shared Function GetName_REQ_TAXI_FROM(ByVal REQ_TAXI_FROM As String) As String
        Return REQ_TAXI_FROM
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_1(ByVal REQ_TAXI_FROM_1 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_1)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_2(ByVal REQ_TAXI_FROM_2 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_2)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_3(ByVal REQ_TAXI_FROM_3 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_3)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_4(ByVal REQ_TAXI_FROM_4 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_4)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_5(ByVal REQ_TAXI_FROM_5 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_5)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_6(ByVal REQ_TAXI_FROM_6 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_6)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_7(ByVal REQ_TAXI_FROM_7 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_7)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_8(ByVal REQ_TAXI_FROM_8 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_8)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_9(ByVal REQ_TAXI_FROM_9 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_9)
    End Function
    Public Shared Function GetName_REQ_TAXI_FROM_10(ByVal REQ_TAXI_FROM_10 As String) As String
        Return GetName_REQ_TAXI_FROM(REQ_TAXI_FROM_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���n�i�˗��j
    Public Shared Function GetName_REQ_TAXI_TO(ByVal REQ_TAXI_TO As String) As String
        Return REQ_TAXI_TO
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_1(ByVal REQ_TAXI_TO_1 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_1)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_2(ByVal REQ_TAXI_TO_2 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_2)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_3(ByVal REQ_TAXI_TO_3 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_3)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_4(ByVal REQ_TAXI_TO_4 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_4)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_5(ByVal REQ_TAXI_TO_5 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_5)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_6(ByVal REQ_TAXI_TO_6 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_6)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_7(ByVal REQ_TAXI_TO_7 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_7)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_8(ByVal REQ_TAXI_TO_8 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_8)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_9(ByVal REQ_TAXI_TO_9 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_9)
    End Function
    Public Shared Function GetName_REQ_TAXI_TO_10(ByVal REQ_TAXI_TO_10 As String) As String
        Return GetName_REQ_TAXI_TO(REQ_TAXI_TO_10)
    End Function

    '�^�N�V�[�`�P�b�g�F�\����z
    Public Shared Function GetName_TAXI_YOTEIKINGAKU(ByVal TAXI_YOTEIKINGAKU As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(TAXI_YOTEIKINGAKU) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(TAXI_YOTEIKINGAKU).ToString("#,#")
            Else
                Return TAXI_YOTEIKINGAKU
            End If
        End If
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_1(ByVal TAXI_YOTEIKINGAKU_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_1, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_2(ByVal TAXI_YOTEIKINGAKU_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_2, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_3(ByVal TAXI_YOTEIKINGAKU_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_3, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_4(ByVal TAXI_YOTEIKINGAKU_4 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_4, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_5(ByVal TAXI_YOTEIKINGAKU_5 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_5, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_6(ByVal TAXI_YOTEIKINGAKU_6 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_6, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_7(ByVal TAXI_YOTEIKINGAKU_7 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_7, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_8(ByVal TAXI_YOTEIKINGAKU_8 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_8, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_9(ByVal TAXI_YOTEIKINGAKU_9 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_9, ShortFormat)
    End Function
    Public Shared Function GetName_TAXI_YOTEIKINGAKU_10(ByVal TAXI_YOTEIKINGAKU_10 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���p���i�񓚁j
    Public Shared Function GetName_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String) As String
        Return CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_1(ByVal ANS_TAXI_DATE_1 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_2(ByVal ANS_TAXI_DATE_2 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_3(ByVal ANS_TAXI_DATE_3 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_4(ByVal ANS_TAXI_DATE_4 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_5(ByVal ANS_TAXI_DATE_5 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_6(ByVal ANS_TAXI_DATE_6 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_7(ByVal ANS_TAXI_DATE_7 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_8(ByVal ANS_TAXI_DATE_8 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_9(ByVal ANS_TAXI_DATE_9 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_10(ByVal ANS_TAXI_DATE_10 As String) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���n�i�񓚁j
    Public Shared Function GetName_ANS_TAXI_FROM(ByVal ANS_TAXI_FROM As String) As String
        Return ANS_TAXI_FROM
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_1(ByVal ANS_TAXI_FROM_1 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_2(ByVal ANS_TAXI_FROM_2 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_3(ByVal ANS_TAXI_FROM_3 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_4(ByVal ANS_TAXI_FROM_4 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_5(ByVal ANS_TAXI_FROM_5 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_6(ByVal ANS_TAXI_FROM_6 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_7(ByVal ANS_TAXI_FROM_7 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_8(ByVal ANS_TAXI_FROM_8 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_9(ByVal ANS_TAXI_FROM_9 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_FROM_10(ByVal ANS_TAXI_FROM_10 As String) As String
        Return GetName_ANS_TAXI_FROM(ANS_TAXI_FROM_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���n�i�񓚁j
    Public Shared Function GetName_ANS_TAXI_TO(ByVal ANS_TAXI_TO As String) As String
        Return ANS_TAXI_TO
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_1(ByVal ANS_TAXI_TO_1 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_2(ByVal ANS_TAXI_TO_2 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_3(ByVal ANS_TAXI_TO_3 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_4(ByVal ANS_TAXI_TO_4 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_5(ByVal ANS_TAXI_TO_5 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_6(ByVal ANS_TAXI_TO_6 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_7(ByVal ANS_TAXI_TO_7 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_8(ByVal ANS_TAXI_TO_8 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_9(ByVal ANS_TAXI_TO_9 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_TO_10(ByVal ANS_TAXI_TO_10 As String) As String
        Return GetName_ANS_TAXI_TO(ANS_TAXI_TO_10)
    End Function

    '�^�N�V�[�`�P�b�g�F����i�񓚁j
    Public Shared Function GetName_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As String) As String
        Return ANS_TAXI_KENSHU
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_1(ByVal ANS_TAXI_KENSHU_1 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_2(ByVal ANS_TAXI_KENSHU_2 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_3(ByVal ANS_TAXI_KENSHU_3 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_4(ByVal ANS_TAXI_KENSHU_4 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_5(ByVal ANS_TAXI_KENSHU_5 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_6(ByVal ANS_TAXI_KENSHU_6 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_7(ByVal ANS_TAXI_KENSHU_7 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_8(ByVal ANS_TAXI_KENSHU_8 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_9(ByVal ANS_TAXI_KENSHU_9 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_10(ByVal ANS_TAXI_KENSHU_10 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_10)
    End Function

    '�^�N�V�[�`�P�b�g�F�ԍ��i�񓚁j
    Public Shared Function GetName_ANS_TAXI_NO(ByVal ANS_TAXI_NO As String) As String
        Return ANS_TAXI_NO
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_1(ByVal ANS_TAXI_NO_1 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_2(ByVal ANS_TAXI_NO_2 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_3(ByVal ANS_TAXI_NO_3 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_4(ByVal ANS_TAXI_NO_4 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_5(ByVal ANS_TAXI_NO_5 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_6(ByVal ANS_TAXI_NO_6 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_7(ByVal ANS_TAXI_NO_7 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_8(ByVal ANS_TAXI_NO_8 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_9(ByVal ANS_TAXI_NO_9 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_10(ByVal ANS_TAXI_NO_10 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���p�z�i�񓚁j
    Public Shared Function GetName_ANS_TAXI_KINGAKU(ByVal ANS_TAXI_KINGAKU As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_TAXI_KINGAKU) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_TAXI_KINGAKU).ToString("#,#")
            Else
                Return ANS_TAXI_KINGAKU
            End If
        End If
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_1(ByVal ANS_TAXI_KINGAKU_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_1, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_2(ByVal ANS_TAXI_KINGAKU_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_2, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_3(ByVal ANS_TAXI_KINGAKU_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_3, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_4(ByVal ANS_TAXI_KINGAKU_4 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_4, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_5(ByVal ANS_TAXI_KINGAKU_5 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_5, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_6(ByVal ANS_TAXI_KINGAKU_6 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_6, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_7(ByVal ANS_TAXI_KINGAKU_7 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_7, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_8(ByVal ANS_TAXI_KINGAKU_8 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_8, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_9(ByVal ANS_TAXI_KINGAKU_9 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_9, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_KINGAKU_10(ByVal ANS_TAXI_KINGAKU_10 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_KINGAKU(ANS_TAXI_KINGAKU_10, ShortFormat)
    End Function

    '�^�N�V�[�`�P�b�g�F���ׁi�񓚁j
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO(ByVal ANS_TAXI_MEISAI_NO As String) As String
        Return ANS_TAXI_MEISAI_NO
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_1(ByVal ANS_TAXI_MEISAI_NO_1 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_2(ByVal ANS_TAXI_MEISAI_NO_2 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_3(ByVal ANS_TAXI_MEISAI_NO_3 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_4(ByVal ANS_TAXI_MEISAI_NO_4 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_5(ByVal ANS_TAXI_MEISAI_NO_5 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_6(ByVal ANS_TAXI_MEISAI_NO_6 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_7(ByVal ANS_TAXI_MEISAI_NO_7 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_8(ByVal ANS_TAXI_MEISAI_NO_8 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_9(ByVal ANS_TAXI_MEISAI_NO_9 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_MEISAI_NO_10(ByVal ANS_TAXI_MEISAI_NO_10 As String) As String
        Return GetName_ANS_TAXI_MEISAI_NO(ANS_TAXI_MEISAI_NO_10)
    End Function

    '�^�N�V�[�`�P�b�g�FVOID�i�񓚁j
    Public Shared Function GetName_ANS_TAXI_VOID(ByVal ANS_TAXI_VOID As String) As String
        Return ANS_TAXI_VOID
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_1(ByVal ANS_TAXI_VOID_1 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_2(ByVal ANS_TAXI_VOID_2 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_3(ByVal ANS_TAXI_VOID_3 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_4(ByVal ANS_TAXI_VOID_4 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_5(ByVal ANS_TAXI_VOID_5 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_6(ByVal ANS_TAXI_VOID_6 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_7(ByVal ANS_TAXI_VOID_7 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_8(ByVal ANS_TAXI_VOID_8 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_9(ByVal ANS_TAXI_VOID_9 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_VOID_10(ByVal ANS_TAXI_VOID_10 As String) As String
        Return GetName_ANS_TAXI_VOID(ANS_TAXI_VOID_10)
    End Function

    '�^�N�V�[�`�P�b�g�F������i�񓚁j
    Public Shared Function GetName_ANS_TAXI_PRINTDATE(ByVal ANS_TAXI_PRINTDATE As String) As String
        Return ANS_TAXI_PRINTDATE
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_1(ByVal ANS_TAXI_PRINTDATE_1 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_2(ByVal ANS_TAXI_PRINTDATE_2 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_3(ByVal ANS_TAXI_PRINTDATE_3 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_4(ByVal ANS_TAXI_PRINTDATE_4 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_5(ByVal ANS_TAXI_PRINTDATE_5 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_6(ByVal ANS_TAXI_PRINTDATE_6 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_7(ByVal ANS_TAXI_PRINTDATE_7 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_8(ByVal ANS_TAXI_PRINTDATE_8 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_9(ByVal ANS_TAXI_PRINTDATE_9 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_PRINTDATE_10(ByVal ANS_TAXI_PRINTDATE_10 As String) As String
        Return GetName_ANS_TAXI_PRINTDATE(ANS_TAXI_PRINTDATE_10)
    End Function

    '�^�N�V�[�`�P�b�g�F�������i�񓚁j
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE(ByVal ANS_TAXI_SEIKYUDATE As String) As String
        Return ANS_TAXI_SEIKYUDATE
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_1(ByVal ANS_TAXI_SEIKYUDATE_1 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_2(ByVal ANS_TAXI_SEIKYUDATE_2 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_3(ByVal ANS_TAXI_SEIKYUDATE_3 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_4(ByVal ANS_TAXI_SEIKYUDATE_4 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_5(ByVal ANS_TAXI_SEIKYUDATE_5 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_6(ByVal ANS_TAXI_SEIKYUDATE_6 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_7(ByVal ANS_TAXI_SEIKYUDATE_7 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_8(ByVal ANS_TAXI_SEIKYUDATE_8 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_9(ByVal ANS_TAXI_SEIKYUDATE_9 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_SEIKYUDATE_10(ByVal ANS_TAXI_SEIKYUDATE_10 As String) As String
        Return GetName_ANS_TAXI_SEIKYUDATE(ANS_TAXI_SEIKYUDATE_10)
    End Function

    '�^�N�`�P���l
    Public Shared Function GetName_TAXI_NOTE(ByVal TAXI_NOTE As String) As String
        Return TAXI_NOTE
    End Function

    'MR���s�L��(MR���́j
    Public Shared Function GetName_TEHAI_MR(ByVal TEHAI_MR As String) As String
        Return TEHAI_MR
    End Function

    'MR���s�i�אȁA�ʐȁj(MR���́j
    Public Shared Function GetName_MR_SEAT(ByVal MR_SEAT As String) As String
        Return MR_SEAT
    End Function

    'MR����
    Public Shared Function GetName_MR_SEX(ByVal MR_SEX As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEX AndAlso MS_CODE(wCnt).DISP_VALUE = MR_SEX Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�Ј��p���H�ՐȊ�]�i�˗��j
    Public Shared Function GetName_REQ_MR_O_TEHAI(ByVal REQ_MR_O_TEHAI As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.MR_TEHAI AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_MR_O_TEHAI Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�Ј��p���H�ՐȊ�]�i�˗��j
    Public Shared Function GetName_REQ_MR_F_TEHAI(ByVal REQ_MR_F_TEHAI As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.MR_TEHAI AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_MR_F_TEHAI Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�Ј��p�h���i�։��E�i���j
    Public Shared Function GetName_REQ_MR_HOTEL_SMOKING(ByVal REQ_MR_HOTEL_SMOKING As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.MR_HOTEL_SMOKING AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_MR_HOTEL_SMOKING Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    'MR�N��
    Public Shared Function GetName_MR_AGE(ByVal MR_AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(MR_AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = True Then
                Return Trim(MR_AGE)
            Else
                Return Trim(MR_AGE) & "��"
            End If
        End If
    End Function

    '������
    Public Shared Function GetName_SEND_DATE(ByVal SEND_DATE As String) As String
        Return CmnModule.Format_Date(SEND_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '�o�^����
    Public Shared Function GetName_INPUT_DATE(ByVal INPUT_DATE As String) As String
        Return CmnModule.Format_Date(INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '�X�V����
    Public Shared Function GetName_UPDATE_DATE(ByVal UPDATE_DATE As String) As String
        Return CmnModule.Format_Date(UPDATE_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '�u����{���@���ǁE����
    Public Shared Function GetName_KIDOKU_FLG(ByVal KIDOKU_FLG As String) As String
        Select Case KIDOKU_FLG
            Case AppConst.KOUENKAI.KIDOKU_FLG.Code.Yes
                Return AppConst.KOUENKAI.KIDOKU_FLG.Name.Yes
            Case AppConst.KOUENKAI.KIDOKU_FLG.Code.No
                Return AppConst.KOUENKAI.KIDOKU_FLG.Name.No
            Case Else
                Return ""
        End Select
    End Function

    '�u���
    Public Shared Function GetName_KOUENKAI_NAME(ByVal KOUENKAI_NAME As String) As String
        Return KOUENKAI_NAME
    End Function

    '�u����J�Ó�From
    Public Shared Function GetName_FROM_DATE(ByVal FROM_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD)
        Else
            Dim wStr As String = ""
            wStr = CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD), True)
            wStr = Replace(Replace(wStr, "/", "��"), "(", "��(")
            wStr = Replace(wStr, "��0", "��")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        End If
    End Function

    '�u����J�Ó�To
    Public Shared Function GetName_TO_DATE(ByVal TO_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.Format_Date(TO_DATE, CmnModule.DateFormatType.YYYYMD)
        Else
            Dim wStr As String = ""
            wStr = CmnModule.Format_Date(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD), True)
            wStr = Replace(Replace(wStr, "/", "��"), "(", "��(")
            wStr = Replace(wStr, "��0", "��")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        End If
    End Function

    '�u����J�Ó�
    Public Shared Function GetName_KOUENKAI_DATE(ByVal FROM_DATE As String, ByVal TO_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wStr As String = ""
        If ShortFormat = False Then
            If Trim(FROM_DATE) = Trim(TO_DATE) OrElse Trim(TO_DATE) = "" Then
                wStr = CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD)
            Else
                wStr = CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD) & "�`" & CmnModule.Format_Date(TO_DATE, CmnModule.DateFormatType.YYYYMD)
            End If
        Else
            If Trim(FROM_DATE) = Trim(TO_DATE) OrElse Trim(TO_DATE) = "" Then
                wStr = CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD) _
                     & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD), True)
                wStr = Replace(Replace(wStr, "/", "��"), "(", "��(")
                wStr = Replace(wStr, "��0", "��")
                If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Else
                Dim wFROM_DATE As String = ""
                Dim wTO_DATE As String = ""
                wFROM_DATE = CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD) _
                     & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD), True)
                wFROM_DATE = Replace(Replace(wFROM_DATE, "/", "��"), "(", "��(")
                wFROM_DATE = Replace(wFROM_DATE, "��0", "��")
                If Mid(wFROM_DATE, 1, 1) = "0" Then wFROM_DATE = Mid(wFROM_DATE, 2, 10)

                wTO_DATE = CmnModule.Format_Date(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD) _
                     & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD), True)
                wTO_DATE = Replace(Replace(wTO_DATE, "/", "��"), "(", "��(")
                wTO_DATE = Replace(wTO_DATE, "��0", "��")
                If Mid(wTO_DATE, 1, 1) = "0" Then wTO_DATE = Mid(wTO_DATE, 2, 10)

                wStr = wFROM_DATE & "�`" & wTO_DATE
            End If
        End If
        Return wStr
    End Function

    '�^�N�V�[�`�P�b�g�󎚖�
    Public Shared Function GetName_TAXI_PRT_NAME(ByVal TAXI_PRT_NAME As String) As String
        Return TAXI_PRT_NAME
    End Function

    '�u����^�C�g��
    Public Shared Function GetName_KOUENKAI_TITLE(ByVal KOUENKAI_TITLE As String) As String
        Return KOUENKAI_TITLE
    End Function

    'Time stamp
    Public Shared Function GetName_TIME_STAMP(ByVal TIME_STAMP As String) As String
        Return CmnModule.Format_Date(TIME_STAMP, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_TIME_STAMP_BYL(ByVal TIME_STAMP_BYL As String) As String
        Return CmnModule.Format_Date(TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function
    Public Shared Function GetName_TIME_STAMP_TOP(ByVal TIME_STAMP_TOP As String) As String
        Return CmnModule.Format_Date(TIME_STAMP_TOP, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '���{�\���
    Public Shared Function GetName_YOTEI_DATE(ByVal YOTEI_DATE As String) As String
        Return CmnModule.Format_Date(YOTEI_DATE, CmnModule.DateFormatType.YYYYMD)
    End Function

    '�J�Ó����l��
    Public Shared Function GetName_KAISAI_DATE_NOTE(ByVal KAISAI_DATE_NOTE As String) As String
        Return KAISAI_DATE_NOTE
    End Function

    'Internal order�i�ېŁj
    Public Shared Function GetName_INTERNAL_ORDER_T(ByVal INTERNAL_ORDER_T As String) As String
        Return INTERNAL_ORDER_T
    End Function

    'Internal order�i��ېŁj
    Public Shared Function GetName_INTERNAL_ORDER_TF(ByVal INTERNAL_ORDER_TF As String) As String
        Return INTERNAL_ORDER_TF
    End Function

    '�A�J�E���g�R�[�h�i�ېŁj
    Public Shared Function GetName_ACCOUNT_CD_T(ByVal ACCOUNT_CD_T As String) As String
        Return ACCOUNT_CD_T
    End Function

    '�A�J�E���g�R�[�h�i��ېŁj
    Public Shared Function GetName_ACCOUNT_CD_TF(ByVal ACCOUNT_CD_TF As String) As String
        Return ACCOUNT_CD_TF
    End Function

    'zetia Code
    Public Shared Function GetName_ZETIA_CD(ByVal ZETIA_CD As String) As String
        Return ZETIA_CD
    End Function

    '���
    Public Shared Function GetName_MEETING_NAME(ByVal MEETING_NAME As String) As String
        Return MEETING_NAME
    End Function

    '���i��
    Public Shared Function GetName_SEIHIN_NAME(ByVal SEIHIN_NAME As String) As String
        Return SEIHIN_NAME
    End Function

    '���F����
    Public Shared Function GetName_SHONIN_TIME(ByVal SHONIN_TIME As String) As String
        Return SHONIN_TIME
    End Function

    '���F�Ҕ��l
    Public Shared Function GetName_SHONIN_NOTE(ByVal SHONIN_NOTE As String) As String
        Return SHONIN_NOTE
    End Function

    '�������ƕ�
    Public Shared Function GetName_KIKAKU_TANTO_JIGYOBU(ByVal KIKAKU_TANTO_JIGYOBU As String) As String
        Return KIKAKU_TANTO_JIGYOBU
    End Function

    'BU
    Public Shared Function GetName_BU(ByVal BU As String) As String
        Return BU
    End Function

    '�����G���A
    Public Shared Function GetName_KIKAKU_TANTO_AREA(ByVal KIKAKU_TANTO_AREA As String) As String
        Return KIKAKU_TANTO_AREA
    End Function

    '�����c�Ə�
    Public Shared Function GetName_KIKAKU_TANTO_EIGYOSHO(ByVal KIKAKU_TANTO_EIGYOSHO As String) As String
        Return KIKAKU_TANTO_EIGYOSHO
    End Function

    '�S���ҁi���S���ҁjNo
    Public Shared Function GetName_KIKAKU_TANTO_NO(ByVal KIKAKU_TANTO_NO As String) As String
        Return KIKAKU_TANTO_NO
    End Function

    '�S���ҁi���S���ҁj��
    Public Shared Function GetName_KIKAKU_TANTO_NAME(ByVal KIKAKU_TANTO_NAME As String) As String
        Return KIKAKU_TANTO_NAME
    End Function

    '�S���ҁi���S���ҁj���i�J�^�J�i�j
    Public Shared Function GetName_KIKAKU_TANTO_KANA(ByVal KIKAKU_TANTO_KANA As String) As String
        Return KIKAKU_TANTO_KANA
    End Function

    '�S���ҁi���S���ҁj���i���[�}���j
    Public Shared Function GetName_KIKAKU_TANTO_ROMA(ByVal KIKAKU_TANTO_ROMA As String) As String
        Return KIKAKU_TANTO_ROMA
    End Function

    'Email�A�h���X�i���S���ҁj
    Public Shared Function GetName_KIKAKU_TANTO_EMAIL(ByVal KIKAKU_TANTO_EMAIL As String) As String
        Return KIKAKU_TANTO_EMAIL
    End Function
    Public Shared Function GetName_KIKAKU_TANTO_EMAIL_PC(ByVal KIKAKU_TANTO_EMAIL_PC As String) As String
        Return KIKAKU_TANTO_EMAIL_PC
    End Function
    Public Shared Function GetName_KIKAKU_TANTO_EMAIL_KEITAI(ByVal KIKAKU_TANTO_EMAIL_KEITAI As String) As String
        Return KIKAKU_TANTO_EMAIL_KEITAI
    End Function

    '�g�ѓd�b�ԍ�
    Public Shared Function GetName_KIKAKU_TANTO_KEITAI(ByVal KIKAKU_TANTO_KEITAI As String) As String
        Return KIKAKU_TANTO_KEITAI
    End Function

    '�d�b�ԍ�
    Public Shared Function GetName_KIKAKU_TANTO_TEL(ByVal KIKAKU_TANTO_TEL As String) As String
        Return KIKAKU_TANTO_TEL
    End Function

    '�������ƕ��i��z�S���ҁj
    Public Shared Function GetName_TEHAI_TANTO_JIGYOBU(ByVal TEHAI_TANTO_JIGYOBU As String) As String
        Return TEHAI_TANTO_JIGYOBU
    End Function

    '����BU�i��z�S���ҁj
    Public Shared Function GetName_TEHAI_TANTO_BU(ByVal TEHAI_TANTO_BU As String) As String
        Return TEHAI_TANTO_BU
    End Function

    '�����G���A�i��z�S���ҁj
    Public Shared Function GetName_TEHAI_TANTO_AREA(ByVal TEHAI_TANTO_AREA As String) As String
        Return TEHAI_TANTO_AREA
    End Function

    '�����c�Ə��i��z�S���ҁj
    Public Shared Function GetName_TEHAI_TANTO_EIGYOSHO(ByVal TEHAI_TANTO_EIGYOSHO As String) As String
        Return TEHAI_TANTO_EIGYOSHO
    End Function

    '�S���ҁi��z�S���ҁjNo
    Public Shared Function GetName_TEHAI_TANTO_NO(ByVal TEHAI_TANTO_NO As String) As String
        Return TEHAI_TANTO_NO
    End Function

    '�S���ҁi��z�S���ҁj��
    Public Shared Function GetName_TEHAI_TANTO_NAME(ByVal TEHAI_TANTO_NAME As String) As String
        Return TEHAI_TANTO_NAME
    End Function

    '�S���ҁi��z�S���ҁj���i�J�^�J�i�j
    Public Shared Function GetName_TEHAI_TANTO_KANA(ByVal TEHAI_TANTO_KANA As String) As String
        Return TEHAI_TANTO_KANA
    End Function

    '�S���ҁi��z�S���ҁj���i���[�}���j
    Public Shared Function GetName_TEHAI_TANTO_ROMA(ByVal TEHAI_TANTO_ROMA As String) As String
        Return TEHAI_TANTO_ROMA
    End Function

    'Email�A�h���X�i��z�S���ҁj
    Public Shared Function GetName_TEHAI_TANTO_EMAIL(ByVal TEHAI_TANTO_EMAIL As String) As String
        Return TEHAI_TANTO_EMAIL
    End Function
    Public Shared Function GetName_TEHAI_TANTO_EMAIL_PC(ByVal TEHAI_TANTO_EMAIL_PC As String) As String
        Return TEHAI_TANTO_EMAIL_PC
    End Function
    Public Shared Function GetName_TEHAI_TANTO_EMAIL_KEITAI(ByVal TEHAI_TANTO_EMAIL_KEITAI As String) As String
        Return TEHAI_TANTO_EMAIL_KEITAI
    End Function

    '�g�ѓd�b�ԍ�
    Public Shared Function GetName_TEHAI_TANTO_KEITAI(ByVal TEHAI_TANTO_KEITAI As String) As String
        Return TEHAI_TANTO_KEITAI
    End Function

    '�d�b�ԍ�
    Public Shared Function GetName_TEHAI_TANTO_TEL(ByVal TEHAI_TANTO_TEL As String) As String
        Return TEHAI_TANTO_TEL
    End Function

    '�Q���\�萔
    Public Shared Function GetName_SANKA_YOTEI_CNT(ByVal SANKA_YOTEI_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(SANKA_YOTEI_CNT)
        Else
            Return SANKA_YOTEI_CNT
        End If
    End Function

    '�Q���\�萔�@�i��t�E��܎t�j
    Public Shared Function GetName_SANKA_YOTEI_CNT_DR(ByVal SANKA_YOTEI_CNT_DR As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(SANKA_YOTEI_CNT_DR)
        Else
            Return SANKA_YOTEI_CNT_DR
        End If
    End Function

    '�Q���\�萔�@�i���̑��j
    Public Shared Function GetName_SANKA_YOTEI_CNT_OTHER(ByVal SANKA_YOTEI_CNT_OTHER As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(SANKA_YOTEI_CNT_OTHER)
        Else
            Return SANKA_YOTEI_CNT_OTHER
        End If
    End Function

    '���ϊz�i��ېŁj
    Public Shared Function GetName_MITSUMORI_TF(ByVal MITSUMORI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(MITSUMORI_TF)
        Else
            Return MITSUMORI_TF
        End If
    End Function

    '���ϊz�i�ېŁj
    Public Shared Function GetName_MITSUMORI_T(ByVal MITSUMORI_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(MITSUMORI_T)
        Else
            Return MITSUMORI_T
        End If
    End Function

    '�\�Z�z(�ې�)
    Public Shared Function GetName_YOSAN_T(ByVal YOSAN_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(YOSAN_T)
        Else
            Return YOSAN_T
        End If
    End Function

    '�\�Z�z(��ې�)
    Public Shared Function GetName_YOSAN_TF(ByVal YOSAN_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(YOSAN_TF)
        Else
            Return YOSAN_TF
        End If
    End Function

    '�\�Z�z���v
    Public Shared Function GetName_YOSAN_TOTAL(ByVal YOSAN_T As String, ByVal YOSAN_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(YOSAN_T) + CmnModule.DbVal(YOSAN_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function

    '�J�Ê�]�n�@�i�s���{���j
    Public Shared Function GetName_KAISAI_KIBOU_ADDRESS1(ByVal KAISAI_KIBOU_ADDRESS1 As String) As String
        Return KAISAI_KIBOU_ADDRESS1
    End Function

    '�J�Ê�]�n�@�i�s�����j
    Public Shared Function GetName_KAISAI_KIBOU_ADDRESS2(ByVal KAISAI_KIBOU_ADDRESS2 As String) As String
        Return KAISAI_KIBOU_ADDRESS2
    End Function

    '�J�Ê�]�@�i�t���[�e�L�X�g�j
    Public Shared Function GetName_KAISAI_KIBOU_NOTE(ByVal KAISAI_KIBOU_NOTE As String) As String
        Return KAISAI_KIBOU_NOTE
    End Function

    '�u����@�J�n����
    Public Shared Function GetName_KOUEN_TIME1(ByVal KOUEN_TIME1 As String) As String
        Return KOUEN_TIME1
    End Function

    '�u����@�I������
    Public Shared Function GetName_KOUEN_TIME2(ByVal KOUEN_TIME2 As String) As String
        Return KOUEN_TIME2
    End Function

    '�u�����@�v�E�s�v
    Public Shared Function GetName_KOUEN_KAIJO_TEHAI(ByVal KOUEN_KAIJO_TEHAI As String) As String
        Select Case KOUEN_KAIJO_TEHAI
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.Yes
                Return AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.Yes
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.No, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.No
                Return AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_KOUEN_KAIJO_TEHAI_Yes(ByVal KOUEN_KAIJO_TEHAI As String) As String
        Select Case KOUEN_KAIJO_TEHAI
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.Yes
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function
    Public Shared Function GetName_KOUEN_KAIJO_TEHAI_No(ByVal KOUEN_KAIJO_TEHAI As String) As String
        Select Case KOUEN_KAIJO_TEHAI
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.No, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.No
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function

    '�u�����@���C�A�E�g
    Public Shared Function GetName_KOUEN_KAIJO_LAYOUT(ByVal KOUEN_KAIJO_LAYOUT As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOUEN_KAIJO_LAYOUT AndAlso MS_CODE(wCnt).DISP_VALUE = KOUEN_KAIJO_LAYOUT Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '�ӌ��������@�v�E�s�v
    Public Shared Function GetName_IKENKOUKAN_KAIJO_TEHAI(ByVal IKENKOUKAN_KAIJO_TEHAI As String) As String
        Select Case IKENKOUKAN_KAIJO_TEHAI
            Case AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Name.Yes
                Return AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Name.Yes
            Case AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Code.No, AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Name.No
                Return AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_IKENKOUKAN_KAIJO_TEHAI_Yes(ByVal IKENKOUKAN_KAIJO_TEHAI As String) As String
        Select Case IKENKOUKAN_KAIJO_TEHAI
            Case AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Name.Yes
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function
    Public Shared Function GetName_IKENKOUKAN_KAIJO_TEHAI_No(ByVal IKENKOUKAN_KAIJO_TEHAI As String) As String
        Select Case IKENKOUKAN_KAIJO_TEHAI
            Case AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Code.No, AppConst.KAIJO.IKENKOUKAN_KAIJO_TEHAI.Name.No
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function

    '�ӌ�������@�J�n����
    Public Shared Function GetName_IKENKOUKAN_TIME1(ByVal IKENKOUKAN_TIME1 As String) As String
        Return IKENKOUKAN_TIME1
    End Function

    '�ӌ�������@�I������
    Public Shared Function GetName_IKENKOUKAN_TIME2(ByVal IKENKOUKAN_TIME2 As String) As String
        Return IKENKOUKAN_TIME2
    End Function

    '�u�t�T���@�v�E�s�v
    Public Shared Function GetName_KOUSHI_ROOM_TEHAI(ByVal KOUSHI_ROOM_TEHAI As String) As String
        Select Case KOUSHI_ROOM_TEHAI
            Case AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Code.Yes, AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Name.Yes
                Return AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Name.Yes
            Case AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Code.No, AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Name.No
                Return AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_KOUSHI_ROOM_TEHAI_Yes(ByVal KOUSHI_ROOM_TEHAI As String) As String
        Select Case KOUSHI_ROOM_TEHAI
            Case AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Code.Yes, AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Name.Yes
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function
    Public Shared Function GetName_KOUSHI_ROOM_TEHAI_No(ByVal KOUSHI_ROOM_TEHAI As String) As String
        Select Case KOUSHI_ROOM_TEHAI
            Case AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Code.No, AppConst.KAIJO.KOUSHI_ROOM_TEHAI.Name.No
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function

    '�u�t�T���@�J�n����
    Public Shared Function GetName_KOUSHI_ROOM_TIME1(ByVal KOUSHI_ROOM_TIME1 As String) As String
        Return KOUSHI_ROOM_TIME1
    End Function

    '�u�t�T���@�I������
    Public Shared Function GetName_KOUSHI_ROOM_TIME2(ByVal KOUSHI_ROOM_TIME2 As String) As String
        Return KOUSHI_ROOM_TIME2
    End Function

    '�u�t�T���@����
    Public Shared Function GetName_KOUSHI_ROOM_CNT(ByVal KOUSHI_ROOM_CNT As String) As String
        Return KOUSHI_ROOM_CNT
    End Function

    '���b�l���@�v�E�s�v
    Public Shared Function GetName_MANAGER_KAIJO_TEHAI(ByVal MANAGER_KAIJO_TEHAI As String) As String
        Select Case MANAGER_KAIJO_TEHAI
            Case AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Name.Yes
                Return AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Name.Yes
            Case AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Code.No, AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Name.No
                Return AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_MANAGER_KAIJO_TEHAI_Yes(ByVal MANAGER_KAIJO_TEHAI As String) As String
        Select Case MANAGER_KAIJO_TEHAI
            Case AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Name.Yes
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function
    Public Shared Function GetName_MANAGER_KAIJO_TEHAI_No(ByVal MANAGER_KAIJO_TEHAI As String) As String
        Select Case MANAGER_KAIJO_TEHAI
            Case AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Code.No, AppConst.KAIJO.MANAGER_KAIJO_TEHAI.Name.No
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function

    '���b�l���@�J�n����
    Public Shared Function GetName_MANAGER_KAIJO_TIME1(ByVal MANAGER_KAIJO_TIME1 As String) As String
        Return MANAGER_KAIJO_TIME1
    End Function

    '���b�l���@�I������
    Public Shared Function GetName_MANAGER_KAIJO_TIME2(ByVal MANAGER_KAIJO_TIME2 As String) As String
        Return MANAGER_KAIJO_TIME2
    End Function

    '�ԘJ����@�v�E�s�v
    Public Shared Function GetName_IROUKAI_KAIJO_TEHAI(ByVal IROUKAI_KAIJO_TEHAI As String) As String
        Select Case IROUKAI_KAIJO_TEHAI
            Case AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Name.Yes
                Return AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Name.Yes
            Case AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Code.No, AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Name.No
                Return AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Name.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_IROUKAI_KAIJO_TEHAI_Yes(ByVal IROUKAI_KAIJO_TEHAI As String) As String
        Select Case IROUKAI_KAIJO_TEHAI
            Case AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Name.Yes
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function
    Public Shared Function GetName_IROUKAI_KAIJO_TEHAI_No(ByVal IROUKAI_KAIJO_TEHAI As String) As String
        Select Case IROUKAI_KAIJO_TEHAI
            Case AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Code.No, AppConst.KAIJO.IROUKAI_KAIJO_TEHAI.Name.No
                Return "��"
            Case Else
                Return "��"
        End Select
    End Function

    '�ԘJ��Q���\��Ґ�
    Public Shared Function GetName_IROUKAI_SANKA_YOTEI_CNT(ByVal IROUKAI_SANKA_YOTEI_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(IROUKAI_SANKA_YOTEI_CNT)
        Else
            Return IROUKAI_SANKA_YOTEI_CNT
        End If
    End Function

    '���p�z�v
    Public Shared Function GetName_FIX_TOTAL(ByVal FIX_SEISAN_TF As String, ByVal FIX_SEISAN_GTAX As String, ByVal FIX_SEISAN_NTAX As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(FIX_SEISAN_TF) + CmnModule.DbVal(FIX_SEISAN_GTAX) + CmnModule.DbVal(FIX_SEISAN_NTAX)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function

    '��From�`To
    Public Shared Function GetName_DATE_FROM_TO(ByVal DATE_FROM As String, ByVal DATE_TO As String) As String
        Dim wStr As String = ""
        Dim wFrom As String = CmnModule.Format_Date(DATE_FROM, CmnModule.DateFormatType.YYYYMMDD)
        If IsDate(wFrom) Then
            wStr &= wFrom
        End If
        Dim wTo As String = CmnModule.Format_Date(DATE_TO, CmnModule.DateFormatType.YYYYMMDD)
        If IsDate(wTo) Then
            If wFrom <> wTo Then
                If Trim(wStr) <> "" Then wStr &= "�`"
                wStr &= wTo
            End If
        End If
        Return wStr
    End Function

    '���ϊz���v
    Public Shared Function GetName_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_MITSUMORI_TOTAL)
        Else
            Return ANS_MITSUMORI_TOTAL
        End If
    End Function
    Public Shared Function GetName_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_T As String, ByVal ANS_MITSUMORI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_MITSUMORI_T) + CmnModule.DbVal(ANS_MITSUMORI_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function

    '�y�񓚁z�{�ݑI�藝�R
    Public Shared Function GetName_ANS_SENTEI_RIYU(ByVal ANS_SENTEI_RIYU As String) As String
        Return Trim(ANS_SENTEI_RIYU)
    End Function

    '�y�񓚁z �J�Òn (�{�ݗX�֔ԍ�)
    Public Shared Function GetName_ANS_SHISETSU_ZIP(ByVal ANS_SHISETSU_ZIP As String) As String
        Return Trim(ANS_SHISETSU_ZIP)
    End Function

    '���[�U�}�X�^�F����
    Public Shared Function GetName_KENGEN(ByVal KENGEN As String) As String
        Select Case KENGEN
            Case AppConst.MS_USER.KENGEN.Code.KENGEN_1, AppConst.MS_USER.KENGEN.Name.KENGEN_1
                Return AppConst.MS_USER.KENGEN.Name.KENGEN_1
            Case AppConst.MS_USER.KENGEN.Code.KENGEN_2, AppConst.MS_USER.KENGEN.Name.KENGEN_2
                Return AppConst.MS_USER.KENGEN.Name.KENGEN_2

            Case Else
                Return ""
        End Select
    End Function

    '���[�U�}�X�^�F���p��~�t���O
    Public Shared Function GetName_STOP_FLG(ByVal STOP_FLG As String) As String
        Select Case STOP_FLG
            Case AppConst.STOP_FLG.Code.Stop, AppConst.STOP_FLG.Name.Stop
                Return AppConst.STOP_FLG.Name.Stop

            Case Else
                Return ""
        End Select
    End Function


    '== �R���g���[�����Z�b�g ==
    '���O�C��ID
    Public Shared Sub SetForm_LOGIN_ID(ByVal LOGIN_ID As String, ByRef control As TextBox)
        control.Text = LOGIN_ID
    End Sub

    '�p�X���[�h
    Public Shared Sub SetForm_PASSWORD(ByVal PASSWORD As String, ByRef control As TextBox)
        control.Text = PASSWORD
    End Sub

    '����
    Public Shared Sub SetForm_USER_NAME(ByVal USER_NAME As String, ByRef control As TextBox)
        control.Text = USER_NAME
    End Sub

    '�Q���^�s�Q��
    Public Shared Sub SetForm_DR_SANKA(ByVal DR_SANKA As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If DR_SANKA = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf DR_SANKA = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
        End If
    End Sub

    '��z�X�e�[�^�X
    Public Shared Sub SetForm_STATUS_TEHAI(ByVal STATUS_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(STATUS_TEHAI, control)
    End Sub

    '�h���X�e�[�^�X�i�񓚁j
    Public Shared Sub SetForm_ANS_STATUS_HOTEL(ByVal ANS_STATUS_HOTEL As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_STATUS_HOTEL, control)
    End Sub

    '�h����i�񓚁j
    Public Shared Sub SetForm_ANS_HOTEL_NAME(ByVal ANS_HOTEL_NAME As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_NAME
    End Sub

    '�h����Z���i�񓚁j
    Public Shared Sub SetForm_ANS_HOTEL_ADDRESS(ByVal ANS_HOTEL_ADDRESS As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_ADDRESS
    End Sub

    '�h����d�b�ԍ��i�񓚁j
    Public Shared Sub SetForm_ANS_HOTEL_TEL(ByVal ANS_HOTEL_TEL As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_TEL
    End Sub

    '�h�����i�񓚁j
    Public Shared Sub SetForm_ANS_HOTEL_DATE(ByVal ANS_HOTEL_DATE As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_DATE
    End Sub

    '�����i�񓚁j
    Public Shared Sub SetForm_ANS_HAKUSU(ByVal ANS_HAKUSU As String, ByRef control As TextBox)
        control.Text = ANS_HAKUSU
    End Sub

    '�h����`�F�b�N�C�����ԁi�񓚁j
    Public Shared Sub SetForm_ANS_CHECKIN_TIME(ByVal ANS_CHECKIN_TIME As String, ByRef control As TextBox)
        control.Text = ANS_CHECKIN_TIME
    End Sub

    '�h����`�F�b�N�A�E�g���ԁi�񓚁j
    Public Shared Sub SetForm_ANS_CHECKOUT_TIME(ByVal ANS_CHECKOUT_TIME As String, ByRef control As TextBox)
        control.Text = ANS_CHECKOUT_TIME
    End Sub

    '�h�������^�C�v�i�񓚁j
    Public Shared Sub SetForm_ANS_ROOM_TYPE(ByVal ANS_ROOM_TYPE As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_ROOM_TYPE, control)
    End Sub

    '�h���z�e���i���i�񓚁j
    Public Shared Sub SetForm_ANS_HOTEL_SMOKING(ByVal ANS_HOTEL_SMOKING As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_HOTEL_SMOKING, control)
    End Sub

    '�h�����l�i�񓚁j
    Public Shared Sub SetForm_ANS_HOTEL_NOTE(ByVal ANS_HOTEL_NOTE As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_NOTE
    End Sub

    '�h�����  ?????

    '���H�F�X�e�[�^�X�i�񓚁j
    Public Shared Sub SetForm_ANS_O_STATUS(ByVal ANS_O_STATUS As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_O_STATUS, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_STATUS_1(ByVal ANS_O_STATUS_1 As String, ByRef control As DropDownList)
        SetForm_ANS_O_STATUS(ANS_O_STATUS_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_STATUS_2(ByVal ANS_O_STATUS_2 As String, ByRef control As DropDownList)
        SetForm_ANS_O_STATUS(ANS_O_STATUS_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_STATUS_3(ByVal ANS_O_STATUS_3 As String, ByRef control As DropDownList)
        SetForm_ANS_O_STATUS(ANS_O_STATUS_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_STATUS_4(ByVal ANS_O_STATUS_4 As String, ByRef control As DropDownList)
        SetForm_ANS_O_STATUS(ANS_O_STATUS_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_STATUS_5(ByVal ANS_O_STATUS_5 As String, ByRef control As DropDownList)
        SetForm_ANS_O_STATUS(ANS_O_STATUS_5, control)
    End Sub

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN(ByVal ANS_O_KOTSUKIKAN As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_O_KOTSUKIKAN, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN_1(ByVal ANS_O_KOTSUKIKAN_1 As String, ByRef control As DropDownList)
        SetForm_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN_2(ByVal ANS_O_KOTSUKIKAN_2 As String, ByRef control As DropDownList)
        SetForm_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN_3(ByVal ANS_O_KOTSUKIKAN_3 As String, ByRef control As DropDownList)
        SetForm_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN_4(ByVal ANS_O_KOTSUKIKAN_4 As String, ByRef control As DropDownList)
        SetForm_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN_5(ByVal ANS_O_KOTSUKIKAN_5 As String, ByRef control As DropDownList)
        SetForm_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_5, control)
    End Sub

    '���H�F���p���i�񓚁j
    Public Shared Sub SetForm_ANS_O_DATE(ByVal ANS_O_DATE As String, ByRef control As TextBox)
        control.Text = ANS_O_DATE
    End Sub
    Public Shared Sub SetForm_ANS_O_DATE_1(ByVal ANS_O_DATE_1 As String, ByRef control As TextBox)
        SetForm_ANS_O_DATE(ANS_O_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_DATE_2(ByVal ANS_O_DATE_2 As String, ByRef control As TextBox)
        SetForm_ANS_O_DATE(ANS_O_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_DATE_3(ByVal ANS_O_DATE_3 As String, ByRef control As TextBox)
        SetForm_ANS_O_DATE(ANS_O_DATE_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_DATE_4(ByVal ANS_O_DATE_4 As String, ByRef control As TextBox)
        SetForm_ANS_O_DATE(ANS_O_DATE_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_DATE_5(ByVal ANS_O_DATE_5 As String, ByRef control As TextBox)
        SetForm_ANS_O_DATE(ANS_O_DATE_5, control)
    End Sub

    '���H�F�o���n�i�񓚁j
    Public Shared Sub SetForm_ANS_O_AIRPORT1(ByVal ANS_O_AIRPORT1 As String, ByRef control As TextBox)
        control.Text = ANS_O_AIRPORT1
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT1_1(ByVal ANS_O_AIRPORT1_1 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT1(ANS_O_AIRPORT1_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT1_2(ByVal ANS_O_AIRPORT1_2 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT1(ANS_O_AIRPORT1_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT1_3(ByVal ANS_O_AIRPORT1_3 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT1(ANS_O_AIRPORT1_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT1_4(ByVal ANS_O_AIRPORT1_4 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT1(ANS_O_AIRPORT1_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT1_5(ByVal ANS_O_AIRPORT1_5 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT1(ANS_O_AIRPORT1_5, control)
    End Sub

    '���H�F�����n�i�񓚁j
    Public Shared Sub SetForm_ANS_O_AIRPORT2(ByVal ANS_O_AIRPORT2 As String, ByRef control As TextBox)
        control.Text = ANS_O_AIRPORT2
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT2_1(ByVal ANS_O_AIRPORT2_1 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT2(ANS_O_AIRPORT2_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT2_2(ByVal ANS_O_AIRPORT2_2 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT2(ANS_O_AIRPORT2_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT2_3(ByVal ANS_O_AIRPORT2_3 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT2(ANS_O_AIRPORT2_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT2_4(ByVal ANS_O_AIRPORT2_4 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT2(ANS_O_AIRPORT2_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_AIRPORT2_5(ByVal ANS_O_AIRPORT2_5 As String, ByRef control As TextBox)
        SetForm_ANS_O_AIRPORT2(ANS_O_AIRPORT2_5, control)
    End Sub

    '���H�F�o�����ԁi�񓚁j
    Public Shared Sub SetForm_ANS_O_TIME1(ByVal ANS_O_TIME1 As String, ByRef control As TextBox)
        control.Text = ANS_O_TIME1
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME1_1(ByVal ANS_O_TIME1_1 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME1(ANS_O_TIME1_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME1_2(ByVal ANS_O_TIME1_2 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME1(ANS_O_TIME1_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME1_3(ByVal ANS_O_TIME1_3 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME1(ANS_O_TIME1_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME1_4(ByVal ANS_O_TIME1_4 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME1(ANS_O_TIME1_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME1_5(ByVal ANS_O_TIME1_5 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME1(ANS_O_TIME1_5, control)
    End Sub

    '���H�F�������ԁi�񓚁j
    Public Shared Sub SetForm_ANS_O_TIME2(ByVal ANS_O_TIME2 As String, ByRef control As TextBox)
        control.Text = ANS_O_TIME2
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME2_1(ByVal ANS_O_TIME2_1 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME2(ANS_O_TIME2_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME2_2(ByVal ANS_O_TIME2_2 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME2(ANS_O_TIME2_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME2_3(ByVal ANS_O_TIME2_3 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME2(ANS_O_TIME2_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME2_4(ByVal ANS_O_TIME2_4 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME2(ANS_O_TIME2_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_TIME2_5(ByVal ANS_O_TIME2_5 As String, ByRef control As TextBox)
        SetForm_ANS_O_TIME2(ANS_O_TIME2_5, control)
    End Sub

    '���H�F��Ԗ��E�֖��i�񓚁j
    Public Shared Sub SetForm_ANS_O_BIN(ByVal ANS_O_BIN As String, ByRef control As TextBox)
        control.Text = ANS_O_BIN
    End Sub
    Public Shared Sub SetForm_ANS_O_BIN_1(ByVal ANS_O_BIN_1 As String, ByRef control As TextBox)
        SetForm_ANS_O_BIN(ANS_O_BIN_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_BIN_2(ByVal ANS_O_BIN_2 As String, ByRef control As TextBox)
        SetForm_ANS_O_BIN(ANS_O_BIN_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_BIN_3(ByVal ANS_O_BIN_3 As String, ByRef control As TextBox)
        SetForm_ANS_O_BIN(ANS_O_BIN_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_BIN_4(ByVal ANS_O_BIN_4 As String, ByRef control As TextBox)
        SetForm_ANS_O_BIN(ANS_O_BIN_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_BIN_5(ByVal ANS_O_BIN_5 As String, ByRef control As TextBox)
        SetForm_ANS_O_BIN(ANS_O_BIN_5, control)
    End Sub

    '���H�F���ȋ敪�i�񓚁j
    Public Shared Sub SetForm_ANS_O_SEAT(ByVal ANS_O_SEAT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_O_SEAT, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_1(ByVal ANS_O_SEAT_1 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_2(ByVal ANS_O_SEAT_2 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_3(ByVal ANS_O_SEAT_3 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_4(ByVal ANS_O_SEAT_4 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_5(ByVal ANS_O_SEAT_5 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_5, control)
    End Sub

    '���H�F�X�e�[�^�X�i�񓚁j
    Public Shared Sub SetForm_ANS_F_STATUS(ByVal ANS_F_STATUS As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_F_STATUS, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_STATUS_1(ByVal ANS_F_STATUS_1 As String, ByRef control As DropDownList)
        SetForm_ANS_F_STATUS(ANS_F_STATUS_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_STATUS_2(ByVal ANS_F_STATUS_2 As String, ByRef control As DropDownList)
        SetForm_ANS_F_STATUS(ANS_F_STATUS_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_STATUS_3(ByVal ANS_F_STATUS_3 As String, ByRef control As DropDownList)
        SetForm_ANS_F_STATUS(ANS_F_STATUS_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_STATUS_4(ByVal ANS_F_STATUS_4 As String, ByRef control As DropDownList)
        SetForm_ANS_F_STATUS(ANS_F_STATUS_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_STATUS_5(ByVal ANS_F_STATUS_5 As String, ByRef control As DropDownList)
        SetForm_ANS_F_STATUS(ANS_F_STATUS_5, control)
    End Sub

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN(ByVal ANS_F_KOTSUKIKAN As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_F_KOTSUKIKAN, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN_1(ByVal ANS_F_KOTSUKIKAN_1 As String, ByRef control As DropDownList)
        SetForm_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN_2(ByVal ANS_F_KOTSUKIKAN_2 As String, ByRef control As DropDownList)
        SetForm_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN_3(ByVal ANS_F_KOTSUKIKAN_3 As String, ByRef control As DropDownList)
        SetForm_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN_4(ByVal ANS_F_KOTSUKIKAN_4 As String, ByRef control As DropDownList)
        SetForm_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN_5(ByVal ANS_F_KOTSUKIKAN_5 As String, ByRef control As DropDownList)
        SetForm_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_5, control)
    End Sub

    '���H�F���p���i�񓚁j
    Public Shared Sub SetForm_ANS_F_DATE(ByVal ANS_F_DATE As String, ByRef control As TextBox)
        control.Text = ANS_F_DATE
    End Sub
    Public Shared Sub SetForm_ANS_F_DATE_1(ByVal ANS_F_DATE_1 As String, ByRef control As TextBox)
        SetForm_ANS_F_DATE(ANS_F_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_DATE_2(ByVal ANS_F_DATE_2 As String, ByRef control As TextBox)
        SetForm_ANS_F_DATE(ANS_F_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_DATE_3(ByVal ANS_F_DATE_3 As String, ByRef control As TextBox)
        SetForm_ANS_F_DATE(ANS_F_DATE_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_DATE_4(ByVal ANS_F_DATE_4 As String, ByRef control As TextBox)
        SetForm_ANS_F_DATE(ANS_F_DATE_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_DATE_5(ByVal ANS_F_DATE_5 As String, ByRef control As TextBox)
        SetForm_ANS_F_DATE(ANS_F_DATE_5, control)
    End Sub

    '���H�F�o���n�i�񓚁j
    Public Shared Sub SetForm_ANS_F_AIRPORT1(ByVal ANS_F_AIRPORT1 As String, ByRef control As TextBox)
        control.Text = ANS_F_AIRPORT1
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT1_1(ByVal ANS_F_AIRPORT1_1 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT1(ANS_F_AIRPORT1_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT1_2(ByVal ANS_F_AIRPORT1_2 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT1(ANS_F_AIRPORT1_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT1_3(ByVal ANS_F_AIRPORT1_3 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT1(ANS_F_AIRPORT1_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT1_4(ByVal ANS_F_AIRPORT1_4 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT1(ANS_F_AIRPORT1_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT1_5(ByVal ANS_F_AIRPORT1_5 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT1(ANS_F_AIRPORT1_5, control)
    End Sub

    '���H�F�����n�i�񓚁j
    Public Shared Sub SetForm_ANS_F_AIRPORT2(ByVal ANS_F_AIRPORT2 As String, ByRef control As TextBox)
        control.Text = ANS_F_AIRPORT2
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT2_1(ByVal ANS_F_AIRPORT2_1 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT2(ANS_F_AIRPORT2_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT2_2(ByVal ANS_F_AIRPORT2_2 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT2(ANS_F_AIRPORT2_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT2_3(ByVal ANS_F_AIRPORT2_3 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT2(ANS_F_AIRPORT2_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT2_4(ByVal ANS_F_AIRPORT2_4 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT2(ANS_F_AIRPORT2_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_AIRPORT2_5(ByVal ANS_F_AIRPORT2_5 As String, ByRef control As TextBox)
        SetForm_ANS_F_AIRPORT2(ANS_F_AIRPORT2_5, control)
    End Sub

    '���H�F�o�����ԁi�񓚁j
    Public Shared Sub SetForm_ANS_F_TIME1(ByVal ANS_F_TIME1 As String, ByRef control As TextBox)
        control.Text = ANS_F_TIME1
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME1_1(ByVal ANS_F_TIME1_1 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME1(ANS_F_TIME1_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME1_2(ByVal ANS_F_TIME1_2 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME1(ANS_F_TIME1_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME1_3(ByVal ANS_F_TIME1_3 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME1(ANS_F_TIME1_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME1_4(ByVal ANS_F_TIME1_4 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME1(ANS_F_TIME1_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME1_5(ByVal ANS_F_TIME1_5 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME1(ANS_F_TIME1_5, control)
    End Sub

    '���H�F�������ԁi�񓚁j
    Public Shared Sub SetForm_ANS_F_TIME2(ByVal ANS_F_TIME2 As String, ByRef control As TextBox)
        control.Text = ANS_F_TIME2
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME2_1(ByVal ANS_F_TIME2_1 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME2(ANS_F_TIME2_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME2_2(ByVal ANS_F_TIME2_2 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME2(ANS_F_TIME2_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME2_3(ByVal ANS_F_TIME2_3 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME2(ANS_F_TIME2_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME2_4(ByVal ANS_F_TIME2_4 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME2(ANS_F_TIME2_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_TIME2_5(ByVal ANS_F_TIME2_5 As String, ByRef control As TextBox)
        SetForm_ANS_F_TIME2(ANS_F_TIME2_5, control)
    End Sub

    '���H�F��Ԗ��E�֖��i�񓚁j
    Public Shared Sub SetForm_ANS_F_BIN(ByVal ANS_F_BIN As String, ByRef control As TextBox)
        control.Text = ANS_F_BIN
    End Sub
    Public Shared Sub SetForm_ANS_F_BIN_1(ByVal ANS_F_BIN_1 As String, ByRef control As TextBox)
        SetForm_ANS_F_BIN(ANS_F_BIN_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_BIN_2(ByVal ANS_F_BIN_2 As String, ByRef control As TextBox)
        SetForm_ANS_F_BIN(ANS_F_BIN_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_BIN_3(ByVal ANS_F_BIN_3 As String, ByRef control As TextBox)
        SetForm_ANS_F_BIN(ANS_F_BIN_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_BIN_4(ByVal ANS_F_BIN_4 As String, ByRef control As TextBox)
        SetForm_ANS_F_BIN(ANS_F_BIN_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_BIN_5(ByVal ANS_F_BIN_5 As String, ByRef control As TextBox)
        SetForm_ANS_F_BIN(ANS_F_BIN_5, control)
    End Sub

    '���H�F���ȋ敪�i�񓚁j
    Public Shared Sub SetForm_ANS_F_SEAT(ByVal ANS_F_SEAT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_F_SEAT, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_1(ByVal ANS_F_SEAT_1 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_2(ByVal ANS_F_SEAT_2 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_3(ByVal ANS_F_SEAT_3 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_4(ByVal ANS_F_SEAT_4 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_5(ByVal ANS_F_SEAT_5 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_5, control)
    End Sub

    '���H���l�i�˗��j
    Public Shared Sub SetForm_REQ_O_NOTE_1(ByVal REQ_O_NOTE_1 As String, ByRef control As TextBox)
        control.Text = REQ_O_NOTE_1
    End Sub

    '���H���l�i�񓚁j
    Public Shared Sub SetForm_ANS_O_NOTE_1(ByVal ANS_O_NOTE_1 As String, ByRef control As TextBox)
        control.Text = ANS_O_NOTE_1
    End Sub

    '���H���l�i�˗��j
    Public Shared Sub SetForm_REQ_F_NOTE_1(ByVal REQ_F_NOTE_1 As String, ByRef control As TextBox)
        control.Text = REQ_F_NOTE_1
    End Sub

    '���H���l�i�񓚁j
    Public Shared Sub SetForm_ANS_F_NOTE_1(ByVal ANS_F_NOTE_1 As String, ByRef control As TextBox)
        control.Text = ANS_F_NOTE_1
    End Sub

    '�y�m��zJR�E�S�����
    Public Shared Sub SetForm_FIX_RAIL_FARE(ByVal FIX_RAIL_FARE As String, ByRef control As TextBox)
        control.Text = FIX_RAIL_FARE
    End Sub

    '�y�m��zJR�E�S�������
    Public Shared Sub SetForm_FIX_RAIL_CANCELLATION(ByVal FIX_RAIL_CANCELLATION As String, ByRef control As TextBox)
        control.Text = FIX_RAIL_CANCELLATION
    End Sub

    '�y�m��z�q�󌔑��
    Public Shared Sub SetForm_FIX_AIR_FARE(ByVal FIX_AIR_FARE As String, ByRef control As TextBox)
        control.Text = FIX_AIR_FARE
    End Sub

    '�y�m��z�q�󌔎����
    Public Shared Sub SetForm_FIX_AIR_CANCELLATION(ByVal FIX_AIR_CANCELLATION As String, ByRef control As TextBox)
        control.Text = FIX_AIR_CANCELLATION
    End Sub

    '�y�m��z�o�X�E�D�����
    Public Shared Sub SetForm_FIX_OTHER_FARE(ByVal FIX_OTHER_FARE As String, ByRef control As TextBox)
        control.Text = FIX_OTHER_FARE
    End Sub

    '�y�m��z�o�X�E�D�������
    Public Shared Sub SetForm_FIX_OTHER_CANCELLATION(ByVal FIX_OTHER_CANCELLATION As String, ByRef control As TextBox)
        control.Text = FIX_OTHER_CANCELLATION
    End Sub

    '�o�^�Ǘ��萔��
    Public Shared Sub SetForm_TOUROKUKANRI_FEE(ByVal TOUROKUKANRI_FEE As String, ByRef control As TextBox)
        control.Text = TOUROKUKANRI_FEE
    End Sub

    '�^�N�`�P�����萔��
    Public Shared Sub SetForm_TAXI_HAKKEN_FEE(ByVal TAXI_HAKKEN_FEE As String, ByRef control As TextBox)
        control.Text = TAXI_HAKKEN_FEE
    End Sub

    '�^�N�`�P���Z�萔��
    Public Shared Sub SetForm_TAXI_SEISAN_FEE(ByVal TAXI_SEISAN_FEE As String, ByRef control As TextBox)
        control.Text = TAXI_SEISAN_FEE
    End Sub

    '�^�N�V�[�`�P�b�g�F���p���i�񓚁j
    Public Shared Sub SetForm_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_DATE
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_1(ByVal ANS_TAXI_DATE_1 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_2(ByVal ANS_TAXI_DATE_2 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_3(ByVal ANS_TAXI_DATE_3 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_4(ByVal ANS_TAXI_DATE_4 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_5(ByVal ANS_TAXI_DATE_5 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_5, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_6(ByVal ANS_TAXI_DATE_6 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_6, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_7(ByVal ANS_TAXI_DATE_7 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_7, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_8(ByVal ANS_TAXI_DATE_8 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_8, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_9(ByVal ANS_TAXI_DATE_9 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_9, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_10(ByVal ANS_TAXI_DATE_10 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_10, control)
    End Sub

    '�^�N�V�[�`�P�b�g�F���n�i�񓚁j
    Public Shared Sub SetForm_ANS_TAXI_FROM(ByVal ANS_TAXI_FROM As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_FROM
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_1(ByVal ANS_TAXI_FROM_1 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_2(ByVal ANS_TAXI_FROM_2 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_3(ByVal ANS_TAXI_FROM_3 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_4(ByVal ANS_TAXI_FROM_4 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_5(ByVal ANS_TAXI_FROM_5 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_5, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_6(ByVal ANS_TAXI_FROM_6 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_6, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_7(ByVal ANS_TAXI_FROM_7 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_7, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_8(ByVal ANS_TAXI_FROM_8 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_8, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_9(ByVal ANS_TAXI_FROM_9 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_9, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_FROM_10(ByVal ANS_TAXI_FROM_10 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_FROM(ANS_TAXI_FROM_10, control)
    End Sub

    '�^�N�V�[�`�P�b�g�F���n�i�񓚁j
    Public Shared Sub SetForm_ANS_TAXI_TO(ByVal ANS_TAXI_TO As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_TO
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_1(ByVal ANS_TAXI_TO_1 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_2(ByVal ANS_TAXI_TO_2 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_3(ByVal ANS_TAXI_TO_3 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_4(ByVal ANS_TAXI_TO_4 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_5(ByVal ANS_TAXI_TO_5 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_5, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_6(ByVal ANS_TAXI_TO_6 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_6, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_7(ByVal ANS_TAXI_TO_7 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_7, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_8(ByVal ANS_TAXI_TO_8 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_8, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_9(ByVal ANS_TAXI_TO_9 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_9, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_TO_10(ByVal ANS_TAXI_TO_10 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_TO(ANS_TAXI_TO_10, control)
    End Sub

    '�^�N�V�[�`�P�b�g�F����i�񓚁j
    Public Shared Sub SetForm_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_TAXI_KENSHU, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_1(ByVal ANS_TAXI_KENSHU_1 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_2(ByVal ANS_TAXI_KENSHU_2 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_3(ByVal ANS_TAXI_KENSHU_3 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_4(ByVal ANS_TAXI_KENSHU_4 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_5(ByVal ANS_TAXI_KENSHU_5 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_5, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_6(ByVal ANS_TAXI_KENSHU_6 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_6, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_7(ByVal ANS_TAXI_KENSHU_7 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_7, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_8(ByVal ANS_TAXI_KENSHU_8 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_8, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_9(ByVal ANS_TAXI_KENSHU_9 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_9, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_10(ByVal ANS_TAXI_KENSHU_10 As String, ByRef control As DropDownList)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_10, control)
    End Sub

    '�^�N�V�[�`�P�b�g�F�ԍ��i�񓚁j
    Public Shared Sub SetForm_ANS_TAXI_NO(ByVal ANS_TAXI_NO As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_NO
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_1(ByVal ANS_TAXI_NO_1 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_1, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_2(ByVal ANS_TAXI_NO_2 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_2, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_3(ByVal ANS_TAXI_NO_3 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_3, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_4(ByVal ANS_TAXI_NO_4 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_4, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_5(ByVal ANS_TAXI_NO_5 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_5, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_6(ByVal ANS_TAXI_NO_6 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_6, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_7(ByVal ANS_TAXI_NO_7 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_7, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_8(ByVal ANS_TAXI_NO_8 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_8, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_9(ByVal ANS_TAXI_NO_9 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_9, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_10(ByVal ANS_TAXI_NO_10 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_10, control)
    End Sub

    '�d�b�ԍ�
    Public Shared Sub SetForm_TEL(ByVal TEL As String, ByRef control As TextBox)
        control.Text = TEL
    End Sub
    Public Shared Sub SetForm_TEL(ByVal TEL As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox, ByRef control_3 As TextBox)
        Dim wTEL_1 As String = ""
        Dim wTEL_2 As String = ""
        Dim wTEL_3 As String = ""
        If Trim(TEL) = "" OrElse Trim(StrConv(TEL, VbStrConv.Narrow)) = "-" Then
        Else
            Dim wSplit() As String
            If InStr(TEL, "-") > 0 Then
                wSplit = Split(Trim(TEL), "-")
                Try
                    wTEL_1 = wSplit(0)
                    wTEL_2 = wSplit(1)
                    wTEL_3 = wSplit(2)
                Catch ex As Exception
                    wTEL_1 = ""
                    wTEL_2 = ""
                    wTEL_3 = ""
                End Try
            End If
        End If
        control_1.Text = wTEL_1
        control_2.Text = wTEL_2
        control_3.Text = wTEL_3
    End Sub

    '�g�ѓd�b�ԍ�
    Public Shared Sub SetForm_KEITAI(ByVal KEITAI As String, ByRef control As TextBox)
        SetForm_TEL(KEITAI, control)
    End Sub
    Public Shared Sub SetForm_KEITAI(ByVal KEITAI As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox, ByRef control_3 As TextBox)
        SetForm_TEL(KEITAI, control_1, control_2, control_3)
    End Sub

    '�X�֔ԍ�
    Public Shared Sub SetForm_ZIP(ByVal ZIP As String, ByRef control As TextBox)
        control.Text = ZIP
    End Sub
    Public Shared Sub SetForm_ZIP(ByVal ZIP As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox)
        Dim wZIP_1 As String = ""
        Dim wZIP_2 As String = ""
        If Trim(ZIP) = "" OrElse Trim(StrConv(ZIP, VbStrConv.Narrow)) = "-" Then
        Else
            Dim wSplit() As String
            If InStr(ZIP, "-") > 0 Then
                wSplit = Split(Trim(ZIP), "-")
                Try
                    wZIP_1 = wSplit(0)
                    wZIP_2 = wSplit(1)
                Catch ex As Exception
                    wZIP_1 = ""
                    wZIP_2 = ""
                End Try
            End If
        End If
        control_1.Text = wZIP_1
        control_2.Text = wZIP_2
    End Sub

    '�y�񓚁z��z�X�e�[�^�X
    Public Shared Sub SetForm_ANS_STATUS_TEHAI(ByVal ANS_STATUS_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_STATUS_TEHAI, control)
    End Sub

    '�s���{��
    Public Shared Sub SetForm_ADDRESS1(ByVal ADDRESS1 As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ADDRESS1, control)
    End Sub

    '�Z��
    Public Shared Sub SetForm_ADDRESS(ByVal ADDRESS As String, ByRef control As TextBox)
        control.Text = ADDRESS
    End Sub
    Public Shared Sub SetForm_ANS_SHISETSU_ADDRESS(ByVal ANS_SHISETSU_ADDRESS As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_ADDRESS
    End Sub

    '�s����
    Public Shared Sub SetForm_ADDRESS2(ByVal ADDRESS2 As String, ByRef control As TextBox)
        control.Text = ADDRESS2
    End Sub

    '�{�ݖ�
    Public Shared Sub SetForm_SHISETSU_NAME(ByVal SHISETSU_NAME As String, ByRef control As TextBox)
        control.Text = SHISETSU_NAME
    End Sub
    Public Shared Sub SetForm_ANS_SHISETSU_NAME(ByVal ANS_SHISETSU_NAME As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_NAME
    End Sub

    '�{�ݖ�(�J�i)
    Public Shared Sub SetForm_SHISETSU_NAME_KANA(ByVal SHISETSU_NAME_KANA As String, ByRef control As TextBox)
        control.Text = SHISETSU_NAME_KANA
    End Sub

    '�y�񓚁z�{�ݑI�藝�R
    Public Shared Sub SetForm_ANS_SENTEI_RIYU(ByVal ANS_SENTEI_RIYU As String, ByRef control As TextBox)
        control.Text = ANS_SENTEI_RIYU
    End Sub

    '�y�񓚁z �J�Òn (�{�ݗX�֔ԍ�)
    Public Shared Sub SetForm_ANS_SHISETSU_ZIP(ByVal ANS_SHISETSU_ZIP As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_ZIP
    End Sub

    '���ϊz�i��ېŁj
    Public Shared Sub SetForm_ANS_MITSUMORI_TF(ByVal ANS_MITSUMORI_TF As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_TF
    End Sub

    '���ϊz�i�ېŁj
    Public Shared Sub SetForm_ANS_MITSUMORI_T(ByVal ANS_MITSUMORI_T As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_T
    End Sub

    '���ϊz�i���v�j
    Public Shared Sub SetForm_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_TOTAL
    End Sub
    Public Shared Sub SetForm_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_MITSUMORI_TOTAL(ANS_MITSUMORI_TOTAL, ShortFormat)
    End Sub

    '�J�Ê�]�n�@�i�s���{���j
    Public Shared Sub SetForm_KAISAI_KIBOU_ADDRESS1(ByVal KAISAI_KIBOU_ADDRESS1 As String, ByRef control As TextBox)
        control.Text = KAISAI_KIBOU_ADDRESS1
    End Sub

    '�J�Ê�]�n�@�i�s�����j
    Public Shared Sub SetForm_KAISAI_KIBOU_ADDRESS2(ByVal KAISAI_KIBOU_ADDRESS2 As String, ByRef control As TextBox)
        control.Text = KAISAI_KIBOU_ADDRESS2
    End Sub

    '�y�m��z�@�J�Òn�@�i�{�ݖ��j
    Public Shared Sub SetForm_FIX_KAISAI_SHISETSU(ByVal FIX_KAISAI_SHISETSU As String, ByRef control As TextBox)
        control.Text = FIX_KAISAI_SHISETSU
    End Sub

    '�y�m��z�@�J�Òn�@�i���l���j
    Public Shared Sub SetForm_FIX_KAISAI_NOTE(ByVal FIX_KAISAI_NOTE As String, ByRef control As TextBox)
        control.Text = FIX_KAISAI_NOTE
    End Sub

    '�y�m�萸�Z���z�@��ې�
    Public Shared Sub SetForm_FIX_SEISAN_TF(ByVal FIX_SEISAN_TF As String, ByRef control As TextBox)
        control.Text = FIX_SEISAN_TF
    End Sub

    '�y�m�萸�Z���z�@�ېłP�@(�ЊO�j
    Public Shared Sub SetForm_FIX_SEISAN_GTAX(ByVal FIX_SEISAN_GTAX As String, ByRef control As TextBox)
        control.Text = FIX_SEISAN_GTAX
    End Sub

    '�y�m�萸�Z���z�@�ېłP�@(�Г��j
    Public Shared Sub SetForm_FIX_SEISAN_NTAX(ByVal FIX_SEISAN_NTAX As String, ByRef control As TextBox)
        control.Text = FIX_SEISAN_NTAX
    End Sub

    '���p�z�v
    Public Shared Sub SetForm_FIX_TOTAL(ByVal FIX_SEISAN_TF As String, ByVal FIX_SEISAN_GTAX As String, ByVal FIX_SEISAN_FTAX As String, ByRef control As TextBox)
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(FIX_SEISAN_TF) + CmnModule.DbVal(FIX_SEISAN_FTAX) + CmnModule.DbVal(FIX_SEISAN_GTAX)
        control.Text = wTOTAL
    End Sub

    '���URL
    Public Shared Sub SetForm_KAIJO_URL(ByVal KAIJO_URL As String, ByRef control As TextBox)
        control.Text = KAIJO_URL
    End Sub

    '�{��TEL
    Public Shared Sub SetForm_ANS_SHISETSU_TEL(ByVal ANS_SHISETSU_TEL As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_TEL
    End Sub

    '�{��URL
    Public Shared Sub SetForm_ANS_SHISETSU_URL(ByVal ANS_SHISETSU_URL As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_URL
    End Sub

    '���ώZ���@�ۑ��ꏊURL
    Public Shared Sub SetForm_ANS_MITSUMORI_URL(ByVal ANS_MITSUMORI_URL As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_URL
    End Sub

    '����
    Public Shared Sub SetForm_KENGEN(ByVal KENGEN As String, ByRef control_KENGEN_1 As RadioButton, ByRef control_KENGEN_2 As RadioButton)
        If KENGEN = AppConst.MS_USER.KENGEN.Code.KENGEN_1 Then
            control_KENGEN_1.Checked = True
            control_KENGEN_2.Checked = False
        ElseIf KENGEN = AppConst.MS_USER.KENGEN.Code.KENGEN_2 Then
            control_KENGEN_1.Checked = False
            control_KENGEN_2.Checked = True
        Else
            control_KENGEN_1.Checked = False
            control_KENGEN_2.Checked = False
        End If
    End Sub

    '���p��~�t���O
    Public Shared Sub SetForm_STOP_FLG(ByVal [Stop] As String, ByRef control As CheckBox)
        If [Stop] = AppConst.STOP_FLG.Code.Stop Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub

    '== �v���_�E���ݒ� ==
    '���ƕ�
    Public Shared Sub SetDropDownList_JIGYOSHO(ByRef JIGYOSHO As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With JIGYOSHO
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_JIGYOSHO.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_JIGYOSHO.Column.����, RsData), CmnDb.DbData(TableDef.MS_JIGYOSHO.Column.����, RsData)))
            End While
            RsData.Close()
        End With
    End Sub

    '�G���A
    Public Shared Sub SetDropDownList_AREA(ByRef AREA As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With AREA
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_AREA.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_AREA.Column.����, RsData), CmnDb.DbData(TableDef.MS_AREA.Column.����, RsData)))
            End While
            RsData.Close()
        End With
    End Sub

    '��z�X�e�[�^�X
    Public Shared Sub SetDropDownList_STATUS_TEHAI(ByRef STATUS_TEHAI As DropDownList, Optional ByVal KAIJO As Boolean = False)
        With STATUS_TEHAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            If KAIJO = False Then
                '�h�����
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK_Daian, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK_Daian))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Changed, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Changed))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.NG, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NG))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled))
            Else
                '���
                .Items.Add(New ListItem(AppConst.KAIJO.STATUS_TEHAI.Name.Tehai, AppConst.KAIJO.STATUS_TEHAI.Code.Tehai))
                .Items.Add(New ListItem(AppConst.KAIJO.STATUS_TEHAI.Name.Change, AppConst.KAIJO.STATUS_TEHAI.Code.Change))
                .Items.Add(New ListItem(AppConst.KAIJO.STATUS_TEHAI.Name.Cancel, AppConst.KAIJO.STATUS_TEHAI.Code.Cancel))
            End If
        End With
    End Sub

    '�y�˗��z��z�X�e�[�^�X
    Public Shared Sub SetDropDownList_REQ_STATUS_TEHAI(ByRef REQ_STATUS_TEHAI As DropDownList, Optional ByVal KAIJO As Boolean = False)
        With REQ_STATUS_TEHAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            If KAIJO = False Then
                '�h�����
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel))
            Else
                '���
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.NewRequest, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.NewRequest))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Change, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Change))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Cancel, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Cancel))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.After, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.After))
            End If
        End With
    End Sub

    '�y�񓚁z��z�X�e�[�^�X
    Public Shared Sub SetDropDownList_ANS_STATUS_TEHAI(ByRef ANS_STATUS_TEHAI As DropDownList, Optional ByVal KAIJO As Boolean = False)
        With ANS_STATUS_TEHAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            If KAIJO = False Then
                '�h�����
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK_Daian, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK_Daian))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Changed, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Changed))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.NG, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NG))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled))
            Else
                '���
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Uketsuke, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.Uketsuke))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Prepare, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.Prepare))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.OK, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.OK))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanEnd, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanEnd))
            End If
        End With
    End Sub

    '�h���X�e�[�^�X�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_STATUS_HOTEL(ByRef ANS_STATUS_HOTEL As DropDownList)
        With ANS_STATUS_HOTEL
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Prepare, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.OK, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Canceled, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Canceled))
        End With
    End Sub

    '�h�������^�C�v�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_ROOM_TYPE(ByRef ANS_ROOM_TYPE As DropDownList)
        With ANS_ROOM_TYPE
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.ROOM_TYPE Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub

    '�h���z�e���i���i�񓚁j
    Public Shared Sub SetDropDownList_ANS_HOTEL_SMOKING(ByRef ANS_HOTEL_SMOKING As DropDownList)
        With ANS_HOTEL_SMOKING
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.ANS_HOTEL_SMOKING Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub

    '�s���{��
    Public Shared Sub SetDropDownList_ADDRESS1(ByRef ADDRESS1 As DropDownList)
        With ADDRESS1
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem("�k�C��", "�k�C��"))
            .Items.Add(New ListItem("�X��", "�X��"))
            .Items.Add(New ListItem("��茧", "��茧"))
            .Items.Add(New ListItem("�{�錧", "�{�錧"))
            .Items.Add(New ListItem("�H�c��", "�H�c��"))
            .Items.Add(New ListItem("�R�`��", "�R�`��"))
            .Items.Add(New ListItem("������", "������"))
            .Items.Add(New ListItem("��錧", "��錧"))
            .Items.Add(New ListItem("�Ȗ،�", "�Ȗ،�"))
            .Items.Add(New ListItem("�Q�n��", "�Q�n��"))
            .Items.Add(New ListItem("��ʌ�", "��ʌ�"))
            .Items.Add(New ListItem("��t��", "��t��"))
            .Items.Add(New ListItem("�����s", "�����s"))
            .Items.Add(New ListItem("�_�ސ쌧", "�_�ސ쌧"))
            .Items.Add(New ListItem("�R����", "�R����"))
            .Items.Add(New ListItem("�É���", "�É���"))
            .Items.Add(New ListItem("���쌧", "���쌧"))
            .Items.Add(New ListItem("�򕌌�", "�򕌌�"))
            .Items.Add(New ListItem("���m��", "���m��"))
            .Items.Add(New ListItem("�O�d��", "�O�d��"))
            .Items.Add(New ListItem("�V����", "�V����"))
            .Items.Add(New ListItem("�x�R��", "�x�R��"))
            .Items.Add(New ListItem("�ΐ쌧", "�ΐ쌧"))
            .Items.Add(New ListItem("���䌧", "���䌧"))
            .Items.Add(New ListItem("���ꌧ", "���ꌧ"))
            .Items.Add(New ListItem("���s�{", "���s�{"))
            .Items.Add(New ListItem("���{", "���{"))
            .Items.Add(New ListItem("���Ɍ�", "���Ɍ�"))
            .Items.Add(New ListItem("�ޗǌ�", "�ޗǌ�"))
            .Items.Add(New ListItem("�a�̎R��", "�a�̎R��"))
            .Items.Add(New ListItem("���挧", "���挧"))
            .Items.Add(New ListItem("������", "������"))
            .Items.Add(New ListItem("���R��", "���R��"))
            .Items.Add(New ListItem("�L����", "�L����"))
            .Items.Add(New ListItem("�R����", "�R����"))
            .Items.Add(New ListItem("������", "������"))
            .Items.Add(New ListItem("���쌧", "���쌧"))
            .Items.Add(New ListItem("���Q��", "���Q��"))
            .Items.Add(New ListItem("���m��", "���m��"))
            .Items.Add(New ListItem("������", "������"))
            .Items.Add(New ListItem("���ꌧ", "���ꌧ"))
            .Items.Add(New ListItem("���茧", "���茧"))
            .Items.Add(New ListItem("�F�{��", "�F�{��"))
            .Items.Add(New ListItem("�啪��", "�啪��"))
            .Items.Add(New ListItem("�{�茧", "�{�茧"))
            .Items.Add(New ListItem("��������", "��������"))
            .Items.Add(New ListItem("���ꌧ", "���ꌧ"))
        End With
    End Sub

    '���H�F�X�e�[�^�X�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_O_STATUS(ByRef ANS_O_STATUS As DropDownList)
        With ANS_O_STATUS
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Prepare, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.OK, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Canceled, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Canceled))
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_STATUS_1(ByRef ANS_O_STATUS_1 As DropDownList)
        SetDropDownList_ANS_O_STATUS(ANS_O_STATUS_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_STATUS_2(ByRef ANS_O_STATUS_2 As DropDownList)
        SetDropDownList_ANS_O_STATUS(ANS_O_STATUS_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_STATUS_3(ByRef ANS_O_STATUS_3 As DropDownList)
        SetDropDownList_ANS_O_STATUS(ANS_O_STATUS_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_STATUS_4(ByRef ANS_O_STATUS_4 As DropDownList)
        SetDropDownList_ANS_O_STATUS(ANS_O_STATUS_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_STATUS_5(ByRef ANS_O_STATUS_5 As DropDownList)
        SetDropDownList_ANS_O_STATUS(ANS_O_STATUS_5)
    End Sub

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN(ByRef ANS_O_KOTSUKIKAN As DropDownList)
        With ANS_O_KOTSUKIKAN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN_1(ByRef ANS_O_KOTSUKIKAN_1 As DropDownList)
        SetDropDownList_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN_2(ByRef ANS_O_KOTSUKIKAN_2 As DropDownList)
        SetDropDownList_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN_3(ByRef ANS_O_KOTSUKIKAN_3 As DropDownList)
        SetDropDownList_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN_4(ByRef ANS_O_KOTSUKIKAN_4 As DropDownList)
        SetDropDownList_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN_5(ByRef ANS_O_KOTSUKIKAN_5 As DropDownList)
        SetDropDownList_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_5)
    End Sub

    '���H�F���ȋ敪�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_O_SEAT(ByRef ANS_O_SEAT As DropDownList)
        With ANS_O_SEAT
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_1(ByRef ANS_O_SEAT_1 As DropDownList)
        SetDropDownList_ANS_O_SEAT(ANS_O_SEAT_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_2(ByRef ANS_O_SEAT_2 As DropDownList)
        SetDropDownList_ANS_O_SEAT(ANS_O_SEAT_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_3(ByRef ANS_O_SEAT_3 As DropDownList)
        SetDropDownList_ANS_O_SEAT(ANS_O_SEAT_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_4(ByRef ANS_O_SEAT_4 As DropDownList)
        SetDropDownList_ANS_O_SEAT(ANS_O_SEAT_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_5(ByRef ANS_O_SEAT_5 As DropDownList)
        SetDropDownList_ANS_O_SEAT(ANS_O_SEAT_5)
    End Sub

    '���H�F���Ȋ�]�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU(ByRef ANS_O_SEAT_KIBOU As DropDownList)
        With ANS_O_SEAT_KIBOU
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT_KIBOU Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU_1(ByRef ANS_O_SEAT_KIBOU_1 As DropDownList)
        SetDropDownList_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU_2(ByRef ANS_O_SEAT_KIBOU_2 As DropDownList)
        SetDropDownList_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU_3(ByRef ANS_O_SEAT_KIBOU_3 As DropDownList)
        SetDropDownList_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU_4(ByRef ANS_O_SEAT_KIBOU_4 As DropDownList)
        SetDropDownList_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU_5(ByRef ANS_O_SEAT_KIBOU_5 As DropDownList)
        SetDropDownList_ANS_O_SEAT_KIBOU(ANS_O_SEAT_KIBOU_5)
    End Sub

    '���H�F�X�e�[�^�X�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_F_STATUS(ByRef ANS_F_STATUS As DropDownList)
        With ANS_F_STATUS
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Prepare, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.OK, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Canceled, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Canceled))
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_STATUS_1(ByRef ANS_F_STATUS_1 As DropDownList)
        SetDropDownList_ANS_F_STATUS(ANS_F_STATUS_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_STATUS_2(ByRef ANS_F_STATUS_2 As DropDownList)
        SetDropDownList_ANS_F_STATUS(ANS_F_STATUS_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_STATUS_3(ByRef ANS_F_STATUS_3 As DropDownList)
        SetDropDownList_ANS_F_STATUS(ANS_F_STATUS_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_STATUS_4(ByRef ANS_F_STATUS_4 As DropDownList)
        SetDropDownList_ANS_F_STATUS(ANS_F_STATUS_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_STATUS_5(ByRef ANS_F_STATUS_5 As DropDownList)
        SetDropDownList_ANS_F_STATUS(ANS_F_STATUS_5)
    End Sub

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN(ByRef ANS_F_KOTSUKIKAN As DropDownList)
        With ANS_F_KOTSUKIKAN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN_1(ByRef ANS_F_KOTSUKIKAN_1 As DropDownList)
        SetDropDownList_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN_2(ByRef ANS_F_KOTSUKIKAN_2 As DropDownList)
        SetDropDownList_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN_3(ByRef ANS_F_KOTSUKIKAN_3 As DropDownList)
        SetDropDownList_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN_4(ByRef ANS_F_KOTSUKIKAN_4 As DropDownList)
        SetDropDownList_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN_5(ByRef ANS_F_KOTSUKIKAN_5 As DropDownList)
        SetDropDownList_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_5)
    End Sub

    '���H�F���ȋ敪�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_F_SEAT(ByRef ANS_F_SEAT As DropDownList)
        With ANS_F_SEAT
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_1(ByRef ANS_F_SEAT_1 As DropDownList)
        SetDropDownList_ANS_F_SEAT(ANS_F_SEAT_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_2(ByRef ANS_F_SEAT_2 As DropDownList)
        SetDropDownList_ANS_F_SEAT(ANS_F_SEAT_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_3(ByRef ANS_F_SEAT_3 As DropDownList)
        SetDropDownList_ANS_F_SEAT(ANS_F_SEAT_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_4(ByRef ANS_F_SEAT_4 As DropDownList)
        SetDropDownList_ANS_F_SEAT(ANS_F_SEAT_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_5(ByRef ANS_F_SEAT_5 As DropDownList)
        SetDropDownList_ANS_F_SEAT(ANS_F_SEAT_5)
    End Sub

    '���H�F���Ȋ�]�i�񓚁j
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU(ByRef ANS_F_SEAT_KIBOU As DropDownList)
        With ANS_F_SEAT_KIBOU
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.SEAT_KIBOU Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU_1(ByRef ANS_F_SEAT_KIBOU_1 As DropDownList)
        SetDropDownList_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_1)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU_2(ByRef ANS_F_SEAT_KIBOU_2 As DropDownList)
        SetDropDownList_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_2)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU_3(ByRef ANS_F_SEAT_KIBOU_3 As DropDownList)
        SetDropDownList_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_3)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU_4(ByRef ANS_F_SEAT_KIBOU_4 As DropDownList)
        SetDropDownList_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_4)
    End Sub
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU_5(ByRef ANS_F_SEAT_KIBOU_5 As DropDownList)
        SetDropDownList_ANS_F_SEAT_KIBOU(ANS_F_SEAT_KIBOU_5)
    End Sub

    '�V���ꗗ�@�敪
    Public Shared Sub SetDropDownList_KUBUN(ByRef KUBUN As DropDownList)
        With KUBUN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))
            .Items.Add(New ListItem("�V�K", "A"))
            .Items.Add(New ListItem("�ύX", "U"))
        End With
    End Sub

    '�u�����{���@�X�e�[�^�X
    Public Shared Sub SetDropDownList_KIDOKU(ByRef KUBUN As DropDownList)
        With KUBUN
            .Items.Clear()
            .Items.Add(New ListItem(AppConst.KOUENKAI.KIDOKU_FLG.Name.No, AppConst.KOUENKAI.KIDOKU_FLG.Code.No))
            .Items.Add(New ListItem(AppConst.KOUENKAI.KIDOKU_FLG.Name.Yes, AppConst.KOUENKAI.KIDOKU_FLG.Code.Yes))

        End With
    End Sub
    '== �R���g���[������DB�p�̒l��Ԃ� ==
    '���O�C��ID
    Public Shared Function GetValue_LOGIN_ID(ByVal LOGIN_ID As TextBox) As String
        Return Trim(StrConv(LOGIN_ID.Text, VbStrConv.Narrow))
    End Function

    '�p�X���[�h
    Public Shared Function GetValue_PASSWORD(ByVal PASSWORD As TextBox) As String
        Return Trim(StrConv(PASSWORD.Text, VbStrConv.Narrow))
    End Function

    '����
    Public Shared Function GetValue_USER_NAME(ByVal USER_NAME As TextBox) As String
        Return Trim(USER_NAME.Text)
    End Function

    '��z�X�e�[�^�X
    Public Shared Function GetValue_STATUS_TEHAI(ByVal STATUS_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(STATUS_TEHAI)
    End Function

    '�y�񓚁z��z�X�e�[�^�X
    Public Shared Function GetValue_ANS_STATUS_TEHAI(ByVal ANS_STATUS_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_STATUS_TEHAI)
    End Function

    '�h����i�񓚁j
    Public Shared Function GetValue_ANS_HOTEL_NAME(ByVal ANS_HOTEL_NAME As TextBox) As String
        Return Trim(ANS_HOTEL_NAME.Text)
    End Function

    '�h����Z���i�񓚁j
    Public Shared Function GetValue_ANS_HOTEL_ADDRESS(ByVal ANS_HOTEL_ADDRESS As TextBox) As String
        Return Trim(ANS_HOTEL_ADDRESS.Text)
    End Function

    '�h����d�b�ԍ��i�񓚁j
    Public Shared Function GetValue_ANS_HOTEL_TEL(ByVal ANS_HOTEL_TEL As TextBox) As String
        Return Trim(ANS_HOTEL_TEL.Text)
    End Function

    '�h�����i�񓚁j
    Public Shared Function GetValue_ANS_HOTEL_DATE(ByVal ANS_HOTEL_DATE As TextBox) As String
        Return Trim(ANS_HOTEL_DATE.Text)
    End Function

    '�����i�񓚁j
    Public Shared Function GetValue_ANS_HAKUSU(ByVal ANS_HAKUSU As TextBox) As String
        Return Trim(ANS_HAKUSU.Text)
    End Function

    '�h����`�F�b�N�C�����ԁi�񓚁j
    Public Shared Function GetValue_ANS_CHECKIN_TIME(ByVal ANS_CHECKIN_TIME As TextBox) As String
        Return Trim(ANS_CHECKIN_TIME.Text)
    End Function

    '�h����`�F�b�N�A�E�g���ԁi�񓚁j
    Public Shared Function GetValue_ANS_CHECKOUT_TIME(ByVal ANS_CHECKOUT_TIME As TextBox) As String
        Return Trim(ANS_CHECKOUT_TIME.Text)
    End Function

    '�h�������^�C�v�i�񓚁j
    Public Shared Function GetValue_ANS_ROOM_TYPE(ByVal ANS_ROOM_TYPE As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_ROOM_TYPE)
    End Function

    '�h���z�e���i���i�񓚁j
    Public Shared Function GetValue_ANS_HOTEL_SMOKING(ByVal ANS_HOTEL_SMOKING As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_HOTEL_SMOKING)
    End Function

    '�h�����l�i�񓚁j
    Public Shared Function GetValue_ANS_HOTEL_NOTE(ByVal ANS_HOTEL_NOTE As TextBox) As String
        Return Trim(ANS_HOTEL_NOTE.Text)
    End Function

    '���H�F�X�e�[�^�X�i�񓚁j
    Public Shared Function GetValue_ANS_O_STATUS(ByVal ANS_O_STATUS As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_STATUS)
    End Function
    Public Shared Function GetValue_ANS_O_STATUS_1(ByVal ANS_O_STATUS_1 As DropDownList) As String
        Return GetValue_ANS_O_STATUS(ANS_O_STATUS_1)
    End Function
    Public Shared Function GetValue_ANS_O_STATUS_2(ByVal ANS_O_STATUS_2 As DropDownList) As String
        Return GetValue_ANS_O_STATUS(ANS_O_STATUS_2)
    End Function
    Public Shared Function GetValue_ANS_O_STATUS_3(ByVal ANS_O_STATUS_3 As DropDownList) As String
        Return GetValue_ANS_O_STATUS(ANS_O_STATUS_3)
    End Function
    Public Shared Function GetValue_ANS_O_STATUS_4(ByVal ANS_O_STATUS_4 As DropDownList) As String
        Return GetValue_ANS_O_STATUS(ANS_O_STATUS_4)
    End Function
    Public Shared Function GetValue_ANS_O_STATUS_5(ByVal ANS_O_STATUS_5 As DropDownList) As String
        Return GetValue_ANS_O_STATUS(ANS_O_STATUS_5)
    End Function

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN(ByVal ANS_O_KOTSUKIKAN As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_KOTSUKIKAN)
    End Function
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN_1(ByVal ANS_O_KOTSUKIKAN_1 As DropDownList) As String
        Return GetValue_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_1)
    End Function
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN_2(ByVal ANS_O_KOTSUKIKAN_2 As DropDownList) As String
        Return GetValue_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_2)
    End Function
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN_3(ByVal ANS_O_KOTSUKIKAN_3 As DropDownList) As String
        Return GetValue_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_3)
    End Function
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN_4(ByVal ANS_O_KOTSUKIKAN_4 As DropDownList) As String
        Return GetValue_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_4)
    End Function
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN_5(ByVal ANS_O_KOTSUKIKAN_5 As DropDownList) As String
        Return GetValue_ANS_O_KOTSUKIKAN(ANS_O_KOTSUKIKAN_5)
    End Function

    '���H�F���p���i�񓚁j
    Public Shared Function GetValue_ANS_O_DATE(ByVal ANS_O_DATE As TextBox) As String
        Return Trim(ANS_O_DATE.Text)
    End Function
    Public Shared Function GetValue_ANS_O_DATE_1(ByVal ANS_O_DATE_1 As TextBox) As String
        Return GetValue_ANS_O_DATE(ANS_O_DATE_1)
    End Function
    Public Shared Function GetValue_ANS_O_DATE_2(ByVal ANS_O_DATE_2 As TextBox) As String
        Return GetValue_ANS_O_DATE(ANS_O_DATE_2)
    End Function
    Public Shared Function GetValue_ANS_O_DATE_3(ByVal ANS_O_DATE_3 As TextBox) As String
        Return GetValue_ANS_O_DATE(ANS_O_DATE_3)
    End Function
    Public Shared Function GetValue_ANS_O_DATE_4(ByVal ANS_O_DATE_4 As TextBox) As String
        Return GetValue_ANS_O_DATE(ANS_O_DATE_4)
    End Function
    Public Shared Function GetValue_ANS_O_DATE_5(ByVal ANS_O_DATE_5 As TextBox) As String
        Return GetValue_ANS_O_DATE(ANS_O_DATE_5)
    End Function

    '���H�F�o���n�i�񓚁j
    Public Shared Function GetValue_ANS_O_AIRPORT1(ByVal ANS_O_AIRPORT1 As TextBox) As String
        Return Trim(ANS_O_AIRPORT1.Text)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT1_1(ByVal ANS_O_AIRPORT1_1 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT1(ANS_O_AIRPORT1_1)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT1_2(ByVal ANS_O_AIRPORT1_2 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT1(ANS_O_AIRPORT1_2)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT1_3(ByVal ANS_O_AIRPORT1_3 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT1(ANS_O_AIRPORT1_3)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT1_4(ByVal ANS_O_AIRPORT1_4 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT1(ANS_O_AIRPORT1_4)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT1_5(ByVal ANS_O_AIRPORT1_5 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT1(ANS_O_AIRPORT1_5)
    End Function

    '���H�F�����n�i�񓚁j
    Public Shared Function GetValue_ANS_O_AIRPORT2(ByVal ANS_O_AIRPORT2 As TextBox) As String
        Return Trim(ANS_O_AIRPORT2.Text)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT2_1(ByVal ANS_O_AIRPORT2_1 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT2(ANS_O_AIRPORT2_1)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT2_2(ByVal ANS_O_AIRPORT2_2 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT2(ANS_O_AIRPORT2_2)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT2_3(ByVal ANS_O_AIRPORT2_3 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT2(ANS_O_AIRPORT2_3)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT2_4(ByVal ANS_O_AIRPORT2_4 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT2(ANS_O_AIRPORT2_4)
    End Function
    Public Shared Function GetValue_ANS_O_AIRPORT2_5(ByVal ANS_O_AIRPORT2_5 As TextBox) As String
        Return GetValue_ANS_O_AIRPORT2(ANS_O_AIRPORT2_5)
    End Function

    '���H�F�o�����ԁi�񓚁j
    Public Shared Function GetValue_ANS_O_TIME1(ByVal ANS_O_TIME1 As TextBox) As String
        Return Trim(ANS_O_TIME1.Text)
    End Function
    Public Shared Function GetValue_ANS_O_TIME1_1(ByVal ANS_O_TIME1_1 As TextBox) As String
        Return GetValue_ANS_O_TIME1(ANS_O_TIME1_1)
    End Function
    Public Shared Function GetValue_ANS_O_TIME1_2(ByVal ANS_O_TIME1_2 As TextBox) As String
        Return GetValue_ANS_O_TIME1(ANS_O_TIME1_2)
    End Function
    Public Shared Function GetValue_ANS_O_TIME1_3(ByVal ANS_O_TIME1_3 As TextBox) As String
        Return GetValue_ANS_O_TIME1(ANS_O_TIME1_3)
    End Function
    Public Shared Function GetValue_ANS_O_TIME1_4(ByVal ANS_O_TIME1_4 As TextBox) As String
        Return GetValue_ANS_O_TIME1(ANS_O_TIME1_4)
    End Function
    Public Shared Function GetValue_ANS_O_TIME1_5(ByVal ANS_O_TIME1_5 As TextBox) As String
        Return GetValue_ANS_O_TIME1(ANS_O_TIME1_5)
    End Function

    '���H�F�������ԁi�񓚁j
    Public Shared Function GetValue_ANS_O_TIME2(ByVal ANS_O_TIME2 As TextBox) As String
        Return Trim(ANS_O_TIME2.Text)
    End Function
    Public Shared Function GetValue_ANS_O_TIME2_1(ByVal ANS_O_TIME2_1 As TextBox) As String
        Return GetValue_ANS_O_TIME2(ANS_O_TIME2_1)
    End Function
    Public Shared Function GetValue_ANS_O_TIME2_2(ByVal ANS_O_TIME2_2 As TextBox) As String
        Return GetValue_ANS_O_TIME2(ANS_O_TIME2_2)
    End Function
    Public Shared Function GetValue_ANS_O_TIME2_3(ByVal ANS_O_TIME2_3 As TextBox) As String
        Return GetValue_ANS_O_TIME2(ANS_O_TIME2_3)
    End Function
    Public Shared Function GetValue_ANS_O_TIME2_4(ByVal ANS_O_TIME2_4 As TextBox) As String
        Return GetValue_ANS_O_TIME2(ANS_O_TIME2_4)
    End Function
    Public Shared Function GetValue_ANS_O_TIME2_5(ByVal ANS_O_TIME2_5 As TextBox) As String
        Return GetValue_ANS_O_TIME2(ANS_O_TIME2_5)
    End Function

    '���H�F��Ԗ��E�֖��i�񓚁j
    Public Shared Function GetValue_ANS_O_BIN(ByVal ANS_O_BIN As TextBox) As String
        Return Trim(ANS_O_BIN.Text)
    End Function
    Public Shared Function GetValue_ANS_O_BIN_1(ByVal ANS_O_BIN_1 As TextBox) As String
        Return GetValue_ANS_O_BIN(ANS_O_BIN_1)
    End Function
    Public Shared Function GetValue_ANS_O_BIN_2(ByVal ANS_O_BIN_2 As TextBox) As String
        Return GetValue_ANS_O_BIN(ANS_O_BIN_2)
    End Function
    Public Shared Function GetValue_ANS_O_BIN_3(ByVal ANS_O_BIN_3 As TextBox) As String
        Return GetValue_ANS_O_BIN(ANS_O_BIN_3)
    End Function
    Public Shared Function GetValue_ANS_O_BIN_4(ByVal ANS_O_BIN_4 As TextBox) As String
        Return GetValue_ANS_O_BIN(ANS_O_BIN_4)
    End Function
    Public Shared Function GetValue_ANS_O_BIN_5(ByVal ANS_O_BIN_5 As TextBox) As String
        Return GetValue_ANS_O_BIN(ANS_O_BIN_5)
    End Function

    '���H�F���ȋ敪�i�񓚁j
    Public Shared Function GetValue_ANS_O_SEAT(ByVal ANS_O_SEAT As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_SEAT)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_1(ByVal ANS_O_SEAT_1 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_1)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_2(ByVal ANS_O_SEAT_2 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_2)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_3(ByVal ANS_O_SEAT_3 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_3)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_4(ByVal ANS_O_SEAT_4 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_4)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_5(ByVal ANS_O_SEAT_5 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_5)
    End Function

    '���H�F�X�e�[�^�X�i�񓚁j
    Public Shared Function GetValue_ANS_F_STATUS(ByVal ANS_F_STATUS As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_F_STATUS)
    End Function
    Public Shared Function GetValue_ANS_F_STATUS_1(ByVal ANS_F_STATUS_1 As DropDownList) As String
        Return GetValue_ANS_F_STATUS(ANS_F_STATUS_1)
    End Function
    Public Shared Function GetValue_ANS_F_STATUS_2(ByVal ANS_F_STATUS_2 As DropDownList) As String
        Return GetValue_ANS_F_STATUS(ANS_F_STATUS_2)
    End Function
    Public Shared Function GetValue_ANS_F_STATUS_3(ByVal ANS_F_STATUS_3 As DropDownList) As String
        Return GetValue_ANS_F_STATUS(ANS_F_STATUS_3)
    End Function
    Public Shared Function GetValue_ANS_F_STATUS_4(ByVal ANS_F_STATUS_4 As DropDownList) As String
        Return GetValue_ANS_F_STATUS(ANS_F_STATUS_4)
    End Function
    Public Shared Function GetValue_ANS_F_STATUS_5(ByVal ANS_F_STATUS_5 As DropDownList) As String
        Return GetValue_ANS_F_STATUS(ANS_F_STATUS_5)
    End Function

    '���H�F��ʋ@�ցi�񓚁j
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN(ByVal ANS_F_KOTSUKIKAN As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_F_KOTSUKIKAN)
    End Function
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN_1(ByVal ANS_F_KOTSUKIKAN_1 As DropDownList) As String
        Return GetValue_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_1)
    End Function
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN_2(ByVal ANS_F_KOTSUKIKAN_2 As DropDownList) As String
        Return GetValue_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_2)
    End Function
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN_3(ByVal ANS_F_KOTSUKIKAN_3 As DropDownList) As String
        Return GetValue_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_3)
    End Function
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN_4(ByVal ANS_F_KOTSUKIKAN_4 As DropDownList) As String
        Return GetValue_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_4)
    End Function
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN_5(ByVal ANS_F_KOTSUKIKAN_5 As DropDownList) As String
        Return GetValue_ANS_F_KOTSUKIKAN(ANS_F_KOTSUKIKAN_5)
    End Function

    '���H�F���p���i�񓚁j
    Public Shared Function GetValue_ANS_F_DATE(ByVal ANS_F_DATE As TextBox) As String
        Return Trim(ANS_F_DATE.Text)
    End Function
    Public Shared Function GetValue_ANS_F_DATE_1(ByVal ANS_F_DATE_1 As TextBox) As String
        Return GetValue_ANS_F_DATE(ANS_F_DATE_1)
    End Function
    Public Shared Function GetValue_ANS_F_DATE_2(ByVal ANS_F_DATE_2 As TextBox) As String
        Return GetValue_ANS_F_DATE(ANS_F_DATE_2)
    End Function
    Public Shared Function GetValue_ANS_F_DATE_3(ByVal ANS_F_DATE_3 As TextBox) As String
        Return GetValue_ANS_F_DATE(ANS_F_DATE_3)
    End Function
    Public Shared Function GetValue_ANS_F_DATE_4(ByVal ANS_F_DATE_4 As TextBox) As String
        Return GetValue_ANS_F_DATE(ANS_F_DATE_4)
    End Function
    Public Shared Function GetValue_ANS_F_DATE_5(ByVal ANS_F_DATE_5 As TextBox) As String
        Return GetValue_ANS_F_DATE(ANS_F_DATE_5)
    End Function

    '���H�F�o���n�i�񓚁j
    Public Shared Function GetValue_ANS_F_AIRPORT1(ByVal ANS_F_AIRPORT1 As TextBox) As String
        Return Trim(ANS_F_AIRPORT1.Text)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT1_1(ByVal ANS_F_AIRPORT1_1 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT1(ANS_F_AIRPORT1_1)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT1_2(ByVal ANS_F_AIRPORT1_2 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT1(ANS_F_AIRPORT1_2)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT1_3(ByVal ANS_F_AIRPORT1_3 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT1(ANS_F_AIRPORT1_3)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT1_4(ByVal ANS_F_AIRPORT1_4 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT1(ANS_F_AIRPORT1_4)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT1_5(ByVal ANS_F_AIRPORT1_5 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT1(ANS_F_AIRPORT1_5)
    End Function

    '���H�F�����n�i�񓚁j
    Public Shared Function GetValue_ANS_F_AIRPORT2(ByVal ANS_F_AIRPORT2 As TextBox) As String
        Return Trim(ANS_F_AIRPORT2.Text)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT2_1(ByVal ANS_F_AIRPORT2_1 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT2(ANS_F_AIRPORT2_1)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT2_2(ByVal ANS_F_AIRPORT2_2 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT2(ANS_F_AIRPORT2_2)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT2_3(ByVal ANS_F_AIRPORT2_3 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT2(ANS_F_AIRPORT2_3)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT2_4(ByVal ANS_F_AIRPORT2_4 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT2(ANS_F_AIRPORT2_4)
    End Function
    Public Shared Function GetValue_ANS_F_AIRPORT2_5(ByVal ANS_F_AIRPORT2_5 As TextBox) As String
        Return GetValue_ANS_F_AIRPORT2(ANS_F_AIRPORT2_5)
    End Function

    '���H�F�o�����ԁi�񓚁j
    Public Shared Function GetValue_ANS_F_TIME1(ByVal ANS_F_TIME1 As TextBox) As String
        Return Trim(ANS_F_TIME1.Text)
    End Function
    Public Shared Function GetValue_ANS_F_TIME1_1(ByVal ANS_F_TIME1_1 As TextBox) As String
        Return GetValue_ANS_F_TIME1(ANS_F_TIME1_1)
    End Function
    Public Shared Function GetValue_ANS_F_TIME1_2(ByVal ANS_F_TIME1_2 As TextBox) As String
        Return GetValue_ANS_F_TIME1(ANS_F_TIME1_2)
    End Function
    Public Shared Function GetValue_ANS_F_TIME1_3(ByVal ANS_F_TIME1_3 As TextBox) As String
        Return GetValue_ANS_F_TIME1(ANS_F_TIME1_3)
    End Function
    Public Shared Function GetValue_ANS_F_TIME1_4(ByVal ANS_F_TIME1_4 As TextBox) As String
        Return GetValue_ANS_F_TIME1(ANS_F_TIME1_4)
    End Function
    Public Shared Function GetValue_ANS_F_TIME1_5(ByVal ANS_F_TIME1_5 As TextBox) As String
        Return GetValue_ANS_F_TIME1(ANS_F_TIME1_5)
    End Function

    '���H�F�������ԁi�񓚁j
    Public Shared Function GetValue_ANS_F_TIME2(ByVal ANS_F_TIME2 As TextBox) As String
        Return Trim(ANS_F_TIME2.Text)
    End Function
    Public Shared Function GetValue_ANS_F_TIME2_1(ByVal ANS_F_TIME2_1 As TextBox) As String
        Return GetValue_ANS_F_TIME2(ANS_F_TIME2_1)
    End Function
    Public Shared Function GetValue_ANS_F_TIME2_2(ByVal ANS_F_TIME2_2 As TextBox) As String
        Return GetValue_ANS_F_TIME2(ANS_F_TIME2_2)
    End Function
    Public Shared Function GetValue_ANS_F_TIME2_3(ByVal ANS_F_TIME2_3 As TextBox) As String
        Return GetValue_ANS_F_TIME2(ANS_F_TIME2_3)
    End Function
    Public Shared Function GetValue_ANS_F_TIME2_4(ByVal ANS_F_TIME2_4 As TextBox) As String
        Return GetValue_ANS_F_TIME2(ANS_F_TIME2_4)
    End Function
    Public Shared Function GetValue_ANS_F_TIME2_5(ByVal ANS_F_TIME2_5 As TextBox) As String
        Return GetValue_ANS_F_TIME2(ANS_F_TIME2_5)
    End Function

    '���H�F��Ԗ��E�֖��i�񓚁j
    Public Shared Function GetValue_ANS_F_BIN(ByVal ANS_F_BIN As TextBox) As String
        Return Trim(ANS_F_BIN.Text)
    End Function
    Public Shared Function GetValue_ANS_F_BIN_1(ByVal ANS_F_BIN_1 As TextBox) As String
        Return GetValue_ANS_F_BIN(ANS_F_BIN_1)
    End Function
    Public Shared Function GetValue_ANS_F_BIN_2(ByVal ANS_F_BIN_2 As TextBox) As String
        Return GetValue_ANS_F_BIN(ANS_F_BIN_2)
    End Function
    Public Shared Function GetValue_ANS_F_BIN_3(ByVal ANS_F_BIN_3 As TextBox) As String
        Return GetValue_ANS_F_BIN(ANS_F_BIN_3)
    End Function
    Public Shared Function GetValue_ANS_F_BIN_4(ByVal ANS_F_BIN_4 As TextBox) As String
        Return GetValue_ANS_F_BIN(ANS_F_BIN_4)
    End Function
    Public Shared Function GetValue_ANS_F_BIN_5(ByVal ANS_F_BIN_5 As TextBox) As String
        Return GetValue_ANS_F_BIN(ANS_F_BIN_5)
    End Function

    '���H�F���ȋ敪�i�񓚁j
    Public Shared Function GetValue_ANS_F_SEAT(ByVal ANS_F_SEAT As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_F_SEAT)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_1(ByVal ANS_F_SEAT_1 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_1)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_2(ByVal ANS_F_SEAT_2 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_2)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_3(ByVal ANS_F_SEAT_3 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_3)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_4(ByVal ANS_F_SEAT_4 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_4)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_5(ByVal ANS_F_SEAT_5 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_5)
    End Function

    '���H���l�i�񓚁j
    Public Shared Function GetValue_ANS_O_NOTE_1(ByVal ANS_O_NOTE_1 As TextBox) As String
        Return Trim(ANS_O_NOTE_1.Text)
    End Function

    '���H���l�i�񓚁j
    Public Shared Function GetValue_ANS_F_NOTE_1(ByVal ANS_F_NOTE_1 As TextBox) As String
        Return Trim(ANS_F_NOTE_1.Text)
    End Function

    '�y�m��zJR�E�S�����
    Public Shared Function GetValue_FIX_RAIL_FARE(ByVal FIX_RAIL_FARE As TextBox) As String
        Return Trim(StrConv(FIX_RAIL_FARE.Text, VbStrConv.Narrow))
    End Function

    '�y�m��zJR�E�S�������
    Public Shared Function GetValue_FIX_RAIL_CANCELLATION(ByVal FIX_RAIL_CANCELLATION As TextBox) As String
        Return Trim(StrConv(FIX_RAIL_CANCELLATION.Text, VbStrConv.Narrow))
    End Function

    '�y�m��z�q�󌔑��
    Public Shared Function GetValue_FIX_AIR_FARE(ByVal FIX_AIR_FARE As TextBox) As String
        Return Trim(StrConv(FIX_AIR_FARE.Text, VbStrConv.Narrow))
    End Function

    '�y�m��z�q�󌔎����
    Public Shared Function GetValue_FIX_AIR_CANCELLATION(ByVal FIX_AIR_CANCELLATION As TextBox) As String
        Return Trim(StrConv(FIX_AIR_CANCELLATION.Text, VbStrConv.Narrow))
    End Function

    '�y�m��z�o�X�E�D�����
    Public Shared Function GetValue_FIX_OTHER_FARE(ByVal FIX_OTHER_FARE As TextBox) As String
        Return Trim(StrConv(FIX_OTHER_FARE.Text, VbStrConv.Narrow))
    End Function

    '�y�m��z�o�X�E�D�������
    Public Shared Function GetValue_FIX_OTHER_CANCELLATION(ByVal FIX_OTHER_CANCELLATION As TextBox) As String
        Return Trim(StrConv(FIX_OTHER_CANCELLATION.Text, VbStrConv.Narrow))
    End Function

    '�o�^�Ǘ��萔��
    Public Shared Function GetValue_TOUROKUKANRI_FEE(ByVal TOUROKUKANRI_FEE As TextBox) As String
        Return Trim(StrConv(TOUROKUKANRI_FEE.Text, VbStrConv.Narrow))
    End Function

    '�^�N�`�P�����萔��
    Public Shared Function GetValue_TAXI_HAKKEN_FEE(ByVal TAXI_HAKKEN_FEE As TextBox) As String
        Return Trim(StrConv(TAXI_HAKKEN_FEE.Text, VbStrConv.Narrow))
    End Function

    '�^�N�`�P���Z�萔��
    Public Shared Function GetValue_TAXI_SEISAN_FEE(ByVal TAXI_SEISAN_FEE As TextBox) As String
        Return Trim(StrConv(TAXI_SEISAN_FEE.Text, VbStrConv.Narrow))
    End Function

    '�^�N�V�[�`�P�b�g�F���p���i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_DATE.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_1(ByVal ANS_TAXI_DATE_1 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_2(ByVal ANS_TAXI_DATE_2 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_3(ByVal ANS_TAXI_DATE_3 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_4(ByVal ANS_TAXI_DATE_4 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_5(ByVal ANS_TAXI_DATE_5 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_6(ByVal ANS_TAXI_DATE_6 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_7(ByVal ANS_TAXI_DATE_7 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_8(ByVal ANS_TAXI_DATE_8 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_9(ByVal ANS_TAXI_DATE_9 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_10(ByVal ANS_TAXI_DATE_10 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���n�i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_FROM(ByVal ANS_TAXI_FROM As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_FROM.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_1(ByVal ANS_TAXI_FROM_1 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_2(ByVal ANS_TAXI_FROM_2 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_3(ByVal ANS_TAXI_FROM_3 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_4(ByVal ANS_TAXI_FROM_4 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_5(ByVal ANS_TAXI_FROM_5 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_6(ByVal ANS_TAXI_FROM_6 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_7(ByVal ANS_TAXI_FROM_7 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_8(ByVal ANS_TAXI_FROM_8 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_9(ByVal ANS_TAXI_FROM_9 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_FROM_10(ByVal ANS_TAXI_FROM_10 As TextBox) As String
        Return GetValue_ANS_TAXI_FROM(ANS_TAXI_FROM_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���n�i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_TO(ByVal ANS_TAXI_TO As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_TO.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_1(ByVal ANS_TAXI_TO_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_2(ByVal ANS_TAXI_TO_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_3(ByVal ANS_TAXI_TO_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_4(ByVal ANS_TAXI_TO_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_5(ByVal ANS_TAXI_TO_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_6(ByVal ANS_TAXI_TO_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_7(ByVal ANS_TAXI_TO_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_8(ByVal ANS_TAXI_TO_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_9(ByVal ANS_TAXI_TO_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_TO_10(ByVal ANS_TAXI_TO_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_TO_10)
    End Function

    '�^�N�V�[�`�P�b�g�F����i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_TAXI_KENSHU)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_1(ByVal ANS_TAXI_KENSHU_1 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_2(ByVal ANS_TAXI_KENSHU_2 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_3(ByVal ANS_TAXI_KENSHU_3 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_4(ByVal ANS_TAXI_KENSHU_4 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_5(ByVal ANS_TAXI_KENSHU_5 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_6(ByVal ANS_TAXI_KENSHU_6 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_7(ByVal ANS_TAXI_KENSHU_7 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_8(ByVal ANS_TAXI_KENSHU_8 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_9(ByVal ANS_TAXI_KENSHU_9 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_10(ByVal ANS_TAXI_KENSHU_10 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_10)
    End Function

    '�^�N�V�[�`�P�b�g�F�ԍ��i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_NO(ByVal ANS_TAXI_NO As TextBox) As String
        Return Trim(ANS_TAXI_NO.Text)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_1(ByVal ANS_TAXI_NO_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_2(ByVal ANS_TAXI_NO_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_3(ByVal ANS_TAXI_NO_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_4(ByVal ANS_TAXI_NO_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_5(ByVal ANS_TAXI_NO_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_6(ByVal ANS_TAXI_NO_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_7(ByVal ANS_TAXI_NO_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_8(ByVal ANS_TAXI_NO_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_9(ByVal ANS_TAXI_NO_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_10(ByVal ANS_TAXI_NO_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_NO_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���z�i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_KINGAKU(ByVal ANS_TAXI_KINGAKU As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_KINGAKU.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_1(ByVal ANS_TAXI_KINGAKU_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_2(ByVal ANS_TAXI_KINGAKU_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_3(ByVal ANS_TAXI_KINGAKU_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_4(ByVal ANS_TAXI_KINGAKU_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_5(ByVal ANS_TAXI_KINGAKU_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_6(ByVal ANS_TAXI_KINGAKU_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_7(ByVal ANS_TAXI_KINGAKU_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_8(ByVal ANS_TAXI_KINGAKU_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_9(ByVal ANS_TAXI_KINGAKU_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KINGAKU_10(ByVal ANS_TAXI_KINGAKU_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_KINGAKU_10)
    End Function

    '�^�N�V�[�`�P�b�g�F���ׁi�񓚁j
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO(ByVal ANS_TAXI_MEISAI_NO As TextBox) As String
        Return Trim(ANS_TAXI_MEISAI_NO.Text)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_1(ByVal ANS_TAXI_MEISAI_NO_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_2(ByVal ANS_TAXI_MEISAI_NO_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_3(ByVal ANS_TAXI_MEISAI_NO_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_4(ByVal ANS_TAXI_MEISAI_NO_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_5(ByVal ANS_TAXI_MEISAI_NO_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_6(ByVal ANS_TAXI_MEISAI_NO_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_7(ByVal ANS_TAXI_MEISAI_NO_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_8(ByVal ANS_TAXI_MEISAI_NO_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_9(ByVal ANS_TAXI_MEISAI_NO_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_MEISAI_NO_10(ByVal ANS_TAXI_MEISAI_NO_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_MEISAI_NO_10)
    End Function

    '�^�N�V�[�`�P�b�g�FVOID�i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_VOID(ByVal ANS_TAXI_VOID As TextBox) As String
        Return Trim(ANS_TAXI_VOID.Text)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_1(ByVal ANS_TAXI_VOID_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_2(ByVal ANS_TAXI_VOID_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_3(ByVal ANS_TAXI_VOID_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_4(ByVal ANS_TAXI_VOID_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_5(ByVal ANS_TAXI_VOID_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_6(ByVal ANS_TAXI_VOID_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_7(ByVal ANS_TAXI_VOID_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_8(ByVal ANS_TAXI_VOID_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_9(ByVal ANS_TAXI_VOID_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_VOID_10(ByVal ANS_TAXI_VOID_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_VOID_10)
    End Function

    '�^�N�V�[�`�P�b�g�F������i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE(ByVal ANS_TAXI_PRINTDATE As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_PRINTDATE.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_1(ByVal ANS_TAXI_PRINTDATE_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_2(ByVal ANS_TAXI_PRINTDATE_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_3(ByVal ANS_TAXI_PRINTDATE_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_4(ByVal ANS_TAXI_PRINTDATE_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_5(ByVal ANS_TAXI_PRINTDATE_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_6(ByVal ANS_TAXI_PRINTDATE_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_7(ByVal ANS_TAXI_PRINTDATE_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_8(ByVal ANS_TAXI_PRINTDATE_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_9(ByVal ANS_TAXI_PRINTDATE_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_PRINTDATE_10(ByVal ANS_TAXI_PRINTDATE_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_PRINTDATE_10)
    End Function

    '�^�N�V�[�`�P�b�g�F�������i�񓚁j
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE(ByVal ANS_TAXI_SEIKYUDATE As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_SEIKYUDATE.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_1(ByVal ANS_TAXI_SEIKYUDATE_1 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_2(ByVal ANS_TAXI_SEIKYUDATE_2 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_3(ByVal ANS_TAXI_SEIKYUDATE_3 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_4(ByVal ANS_TAXI_SEIKYUDATE_4 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_5(ByVal ANS_TAXI_SEIKYUDATE_5 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_6(ByVal ANS_TAXI_SEIKYUDATE_6 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_7(ByVal ANS_TAXI_SEIKYUDATE_7 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_8(ByVal ANS_TAXI_SEIKYUDATE_8 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_9(ByVal ANS_TAXI_SEIKYUDATE_9 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_SEIKYUDATE_10(ByVal ANS_TAXI_SEIKYUDATE_10 As TextBox) As String
        Return GetValue_ANS_TAXI_TO(ANS_TAXI_SEIKYUDATE_10)
    End Function

    '�d�b�ԍ�
    Public Shared Function GetValue_TEL(ByVal TEL As TextBox) As String
        Return Trim(StrConv(TEL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_TEL(ByVal TEL_1 As TextBox, ByVal TEL_2 As TextBox, ByVal TEL_3 As TextBox) As String
        Dim wStr As String = Trim(StrConv(TEL_1.Text & "-" & TEL_2.Text & "-" & TEL_3.Text, VbStrConv.Narrow))
        If wStr = "--" Then wStr = ""
        Return wStr
    End Function
    Public Shared Function GetValue_ANS_SHISETSU_TEL(ByVal ANS_SHISETSU_TEL As TextBox) As String
        Return Trim(StrConv(ANS_SHISETSU_TEL.Text, VbStrConv.Narrow))
    End Function

    '�g�ѓd�b�ԍ�
    Public Shared Function GetValue_KEITAI(ByVal KEITAI As TextBox) As String
        Return GetValue_TEL(KEITAI)
    End Function
    Public Shared Function GetValue_KEITAI(ByVal KEITAI_1 As TextBox, ByVal KEITAI_2 As TextBox, ByVal KEITAI_3 As TextBox) As String
        Return GetValue_TEL(KEITAI_1, KEITAI_2, KEITAI_3)
    End Function

    '�X�֔ԍ�
    Public Shared Function GetValue_ZIP(ByVal ZIP As TextBox) As String
        Return Trim(StrConv(ZIP.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ZIP(ByVal ZIP_1 As TextBox, ByVal ZIP_2 As TextBox) As String
        Dim wStr As String = Trim(StrConv(ZIP_1.Text & "-" & ZIP_2.Text, VbStrConv.Narrow))
        If wStr = "-" Then wStr = ""
        Return wStr
    End Function

    '�{��URL
    Public Shared Function GetValue_ANS_SHISETSU_URL(ByVal ANS_SHISETSU_URL As TextBox) As String
        Return Trim(StrConv(ANS_SHISETSU_URL.Text, VbStrConv.Narrow))
    End Function

    '�s���{��
    Public Shared Function GetValue_ADDRESS1(ByVal ADDRESS1 As TextBox) As String
        Return Trim(ADDRESS1.Text)
    End Function

    '�s����
    Public Shared Function GetValue_ADDRESS2(ByVal ADDRESS2 As TextBox) As String
        Return Trim(ADDRESS2.Text)
    End Function

    '�Z��
    Public Shared Function GetValue_ADDRESS(ByVal ADDRESS As TextBox) As String
        Return Trim(ADDRESS.Text)
    End Function
    Public Shared Function GetValue_ANS_SHISETSU_ADDRESS(ByVal ANS_SHISETSU_ADDRESS As TextBox) As String
        Return Trim(ANS_SHISETSU_ADDRESS.Text)
    End Function

    '�{�ݖ�
    Public Shared Function GetValue_SHISETSU_NAME(ByVal SHISETSU_NAME As TextBox) As String
        Return Trim(SHISETSU_NAME.Text)
    End Function
    Public Shared Function GetValue_ANS_SHISETSU_NAME(ByVal ANS_SHISETSU_NAME As TextBox) As String
        Return Trim(ANS_SHISETSU_NAME.Text)
    End Function

    '�y�񓚁z�{�ݑI�藝�R
    Public Shared Function GetValue_ANS_SENTEI_RIYU(ByVal ANS_SENTEI_RIYU As TextBox) As String
        Return Trim(ANS_SENTEI_RIYU.Text)
    End Function

    '�y�񓚁z �J�Òn (�{�ݗX�֔ԍ�)
    Public Shared Function GetValue_ANS_SHISETSU_ZIP(ByVal ANS_SHISETSU_ZIP As TextBox) As String
        Return Trim(ANS_SHISETSU_ZIP.Text)
    End Function

    '���ϊz�i��ېŁj
    Public Shared Function GetValue_ANS_MITSUMORI_TF(ByVal ANS_MITSUMORI_TF As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_TF.Text, VbStrConv.Narrow))
    End Function

    '���ϊz�i�ېŁj
    Public Shared Function GetValue_ANS_MITSUMORI_T(ByVal ANS_MITSUMORI_T As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_T.Text, VbStrConv.Narrow))
    End Function

    '���ϊz�i���v�j
    Public Shared Function GetValue_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_TOTAL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_T As TextBox, ByVal ANS_MITSUMORI_TF As TextBox) As String
        Return CmnModule.DbVal(StrConv(ANS_MITSUMORI_T.Text, VbStrConv.Narrow)) + CmnModule.DbVal(StrConv(ANS_MITSUMORI_TF.Text, VbStrConv.Narrow)).ToString
    End Function

    '�J�Ê�]�n�@�i�s���{���j
    Public Shared Function GetValue_KAISAI_KIBOU_ADDRESS1(ByVal KAISAI_KIBOU_ADDRESS1 As TextBox) As String
        Return Trim(KAISAI_KIBOU_ADDRESS1.Text)
    End Function

    '�J�Ê�]�n�@�i�s�����j
    Public Shared Function GetValue_KAISAI_KIBOU_ADDRESS2(ByVal KAISAI_KIBOU_ADDRESS2 As TextBox) As String
        Return Trim(KAISAI_KIBOU_ADDRESS2.Text)
    End Function

    '�y�m��z�@�J�Òn�@�i�{�ݖ��j
    Public Shared Function GetValue_FIX_KAISAI_SHISETSU(ByVal FIX_KAISAI_SHISETSU As TextBox) As String
        Return Trim(FIX_KAISAI_SHISETSU.Text)
    End Function

    '�y�m��z�@�J�Òn�@�i���l���j
    Public Shared Function GetValue_FIX_KAISAI_NOTE(ByVal FIX_KAISAI_NOTE As TextBox) As String
        Return Trim(FIX_KAISAI_NOTE.Text)
    End Function

    '�y�m�萸�Z���z�@��ې�
    Public Shared Function GetValue_FIX_SEISAN_TF(ByVal FIX_SEISAN_TF As TextBox) As String
        Return Trim(StrConv(FIX_SEISAN_TF.Text, VbStrConv.Narrow))
    End Function

    '�y�m�萸�Z���z�@�ېłP�@(�ЊO�j
    Public Shared Function GetValue_FIX_SEISAN_GTAX(ByVal FIX_SEISAN_GTAX As TextBox) As String
        Return Trim(StrConv(FIX_SEISAN_GTAX.Text, VbStrConv.Narrow))
    End Function

    '�y�m�萸�Z���z�@�ېłP�@(�Г��j
    Public Shared Function GetValue_FIX_SEISAN_NTAX(ByVal FIX_SEISAN_NTAX As TextBox) As String
        Return Trim(StrConv(FIX_SEISAN_NTAX.Text, VbStrConv.Narrow))
    End Function

    '���URL
    Public Shared Function GetValue_KAIJO_URL(ByVal KAIJO_URL As TextBox) As String
        Return Trim(StrConv(KAIJO_URL.Text, VbStrConv.Narrow))
    End Function

    '���TEL
    Public Shared Function GetValue_KAIJO_TEL(ByVal KAIJO_TEL As TextBox) As String
        Return GetValue_TEL(KAIJO_TEL)
    End Function

    '���Ϗ��ۑ��ꏊURL
    Public Shared Function GetValue_ANS_MITSUMORI_URL(ByVal ANS_MITSUMORI_URL As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_URL.Text, VbStrConv.Narrow))
    End Function

    '����
    Public Shared Function GetValue_KENGEN(ByVal KENGEN_1 As RadioButton, ByVal KENGEN_2 As RadioButton) As String
        If KENGEN_1.Checked = True Then
            Return AppConst.MS_USER.KENGEN.Code.KENGEN_1
        ElseIf KENGEN_2.Checked = True Then
            Return AppConst.MS_USER.KENGEN.Code.KENGEN_2
        Else
            Return ""
        End If
    End Function

    '���p��~�t���O
    Public Shared Function GetValue_STOP_FLG(ByVal STOP_FLG As CheckBox) As String
        If STOP_FLG.Checked = True Then
            Return AppConst.STOP_FLG.Code.Stop
        Else
            Return ""
        End If
    End Function


    '==
    '�h����z�˗������True��Ԃ�
    Public Shared Function IsTEHAI_HOTEL(ByVal TEHAI_HOTEL As String) As Boolean
        Select Case TEHAI_HOTEL
            Case AppConst.KOTSUHOTEL.TEHAI_HOTEL.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function

    '��ʎ�z�˗������True��Ԃ�
    Public Shared Function IsREQ_O_TEHAI(ByVal REQ_O_TEHAI As String) As Boolean
        Select Case REQ_O_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes, AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function
    Public Shared Function IsREQ_O_TEHAI_1(ByVal REQ_O_TEHAI_1 As String) As Boolean
        Return IsREQ_O_TEHAI(REQ_O_TEHAI_1)
    End Function
    Public Shared Function IsREQ_O_TEHAI_2(ByVal REQ_O_TEHAI_2 As String) As Boolean
        Return IsREQ_O_TEHAI(REQ_O_TEHAI_2)
    End Function
    Public Shared Function IsREQ_O_TEHAI_3(ByVal REQ_O_TEHAI_3 As String) As Boolean
        Return IsREQ_O_TEHAI(REQ_O_TEHAI_3)
    End Function
    Public Shared Function IsREQ_O_TEHAI_4(ByVal REQ_O_TEHAI_4 As String) As Boolean
        Return IsREQ_O_TEHAI(REQ_O_TEHAI_4)
    End Function
    Public Shared Function IsREQ_O_TEHAI_5(ByVal REQ_O_TEHAI_5 As String) As Boolean
        Return IsREQ_O_TEHAI(REQ_O_TEHAI_5)
    End Function
    Public Shared Function IsREQ_F_TEHAI(ByVal REQ_F_TEHAI As String) As Boolean
        Select Case REQ_F_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes, AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function
    Public Shared Function IsREQ_F_TEHAI_1(ByVal REQ_F_TEHAI_1 As String) As Boolean
        Return IsREQ_F_TEHAI(REQ_F_TEHAI_1)
    End Function
    Public Shared Function IsREQ_F_TEHAI_2(ByVal REQ_F_TEHAI_2 As String) As Boolean
        Return IsREQ_F_TEHAI(REQ_F_TEHAI_2)
    End Function
    Public Shared Function IsREQ_F_TEHAI_3(ByVal REQ_F_TEHAI_3 As String) As Boolean
        Return IsREQ_F_TEHAI(REQ_F_TEHAI_3)
    End Function
    Public Shared Function IsREQ_F_TEHAI_4(ByVal REQ_F_TEHAI_4 As String) As Boolean
        Return IsREQ_F_TEHAI(REQ_F_TEHAI_4)
    End Function
    Public Shared Function IsREQ_F_TEHAI_5(ByVal REQ_F_TEHAI_5 As String) As Boolean
        Return IsREQ_F_TEHAI(REQ_F_TEHAI_5)
    End Function

    '�^�N�V�[�`�P�b�g�i�L�E���j
    Public Shared Function IsTEHAI_TAXI(ByVal TEHAI_TAXI As String) As Boolean
        Select Case TEHAI_TAXI
            Case AppConst.KOTSUHOTEL.TEHAI_TAXI.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function


    '�Q�������True��Ԃ�
    Public Shared Function IsCanceled(ByVal data As String) As Boolean
        Select Case data
            Case AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Cancel, AppConst.KOTSUHOTEL.RECORD_KUBUN.Name.Cancel
                Return True
            Case Else
                Return False
        End Select
    End Function

    ''��z����=True��Ԃ�
    'Public Shared Function IsOK_TEHAI(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As Boolean
    '    If IsCanceled(TBL_DR.RECORD_KUBUN) Then
    '        '�Q�������True
    '        Return True
    '    Else
    '        If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '��z�s�v��True
    '            Return True
    '        ElseIf IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '�h���A��� ��z����
    '            If IsOK_TEHAI_HOTEL(TBL_DR.STATUS_TEHAI) AndAlso IsOK_TEHAI_KOTSU(TBL_DR.STATUS_TEHAI) Then
    '                '�h������+��ʊ�����True
    '                Return True
    '            End If
    '        ElseIf IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '�h����z����
    '            If IsOK_TEHAI_HOTEL(TBL_DR.STATUS_TEHAI) Then
    '                '�h��������True
    '                Return True
    '            End If
    '        ElseIf Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '������ʎ�z����
    '            If IsOK_TEHAI_KOTSU(TBL_DR.STATUS_TEHAI) Then
    '                '��ʊ�����True
    '                Return True
    '            End If
    '        End If
    '    End If
    '    Return False    '��z��
    'End Function

    ''�h����z����=True��Ԃ�
    'Public Shared Function IsOK_TEHAI_HOTEL(ByVal STATUS_TEHAI As String) As Boolean
    '    Select Case STATUS_TEHAI
    '        Case AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK_KotsuNG, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
    '             AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK_KotsuNG, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK_KotsuOK
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function

    ''������ʎ�z����=True��Ԃ�
    'Public Shared Function IsOK_TEHAI_KOTSU(ByVal STATUS_TEHAI As String) As Boolean
    '    Select Case STATUS_TEHAI
    '        Case AppConst.kotsuhotel.STATUS_TEHAI.Code.KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelNG_KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
    '             AppConst.kotsuhotel.STATUS_TEHAI.Name.KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelNG_KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK_KotsuOK
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function


    '== �񋓌^ ==
    '�e�[�u��
    Enum TableType
        [TBL_KOUENKAI]
        [TBL_SEIKYU]
        [TBL_KOTSUHOTEL]
        [TBL_KAIJO]
        [TBL_BENTO]
        [MS_SHISETSU]
        [MS_USER]
        [MS_JIGYOSHO]
        [MS_AREA]
        [MS_EIGYOSHO]
        [MS_CODE]
        [TBL_LOG]
    End Enum

End Class
