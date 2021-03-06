Imports CommonLib
Imports AppLib
Imports System.Web.UI.WebControls
Imports System.Drawing

Public Class AppModule

    '== データベース関連 ==
#Region "テーブルから構造体にデータをセット"

#Region "会合テーブル"
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT_NMBR.ToUpper Then TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT_MBR.ToUpper Then TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SRM_HACYU_KBN.ToUpper Then TBL_KOUENKAI.SRM_HACYU_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.BU.ToUpper Then TBL_KOUENKAI.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_JIGYOUBU.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_PC.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_TEL.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.COST_CENTER.ToUpper Then TBL_KOUENKAI.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_PC.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_TEL.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.YOSAN_TF.ToUpper Then TBL_KOUENKAI.YOSAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.YOSAN_T.ToUpper Then TBL_KOUENKAI.YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.IROUKAI_YOSAN_T.ToUpper Then TBL_KOUENKAI.IROUKAI_YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.IKENKOUKAN_YOSAN_T.ToUpper Then TBL_KOUENKAI.IKENKOUKAN_YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.DANTAI_CODE.ToUpper Then TBL_KOUENKAI.DANTAI_CODE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO.ToUpper Then TBL_KOUENKAI.TTEHAI_TANTO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.FROM_DATE_YM.ToUpper Then TBL_KOUENKAI.FROM_DATE_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SEISAN_KANRYO.ToUpper Then TBL_KOUENKAI.SEISAN_KANRYO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KOUENKAI
    End Function
#End Region

#Region "請求テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As TableDef.TBL_SEIKYU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KOUENKAI_NO.ToUpper Then TBL_SEIKYU.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SHIHARAI_NO.ToUpper Then TBL_SEIKYU.SHIHARAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEISAN_YM.ToUpper Then TBL_SEIKYU.SEISAN_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN.ToUpper Then TBL_SEIKYU.SHOUNIN_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE.ToUpper Then TBL_SEIKYU.SHOUNIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJOHI_TF.ToUpper Then TBL_SEIKYU.KAIJOHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIZAIHI_TF.ToUpper Then TBL_SEIKYU.KIZAIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF.ToUpper Then TBL_SEIKYU.INSHOKUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_991330401_TF.ToUpper Then TBL_SEIKYU.KEI_991330401_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTELHI_TF.ToUpper Then TBL_SEIKYU.HOTELHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTELHI_TOZEI.ToUpper Then TBL_SEIKYU.HOTELHI_TOZEI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.JR_TF.ToUpper Then TBL_SEIKYU.JR_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.AIR_TF.ToUpper Then TBL_SEIKYU.AIR_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.OTHER_TRAFFIC_TF.ToUpper Then TBL_SEIKYU.OTHER_TRAFFIC_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TF.ToUpper Then TBL_SEIKYU.TAXI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTEL_COMMISSION_TF.ToUpper Then TBL_SEIKYU.HOTEL_COMMISSION_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_COMMISSION_TF.ToUpper Then TBL_SEIKYU.TAXI_COMMISSION_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.JINKENHI_TF.ToUpper Then TBL_SEIKYU.JINKENHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.OTHER_TF.ToUpper Then TBL_SEIKYU.OTHER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KANRIHI_TF.ToUpper Then TBL_SEIKYU.KANRIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_41120200_TF.ToUpper Then TBL_SEIKYU.KEI_41120200_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_TF.ToUpper Then TBL_SEIKYU.KEI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJOUHI_T.ToUpper Then TBL_SEIKYU.KAIJOUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIZAIHI_T.ToUpper Then TBL_SEIKYU.KIZAIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INSHOKUHI_T.ToUpper Then TBL_SEIKYU.INSHOKUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_991330401_T.ToUpper Then TBL_SEIKYU.KEI_991330401_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.JINKENHI_T.ToUpper Then TBL_SEIKYU.JINKENHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.OTHER_T.ToUpper Then TBL_SEIKYU.OTHER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KANRIHI_T.ToUpper Then TBL_SEIKYU.KANRIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_41120200_T.ToUpper Then TBL_SEIKYU.KEI_41120200_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KEI_T.ToUpper Then TBL_SEIKYU.KEI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR.ToUpper Then TBL_SEIKYU.SEIKYU_NO_TOPTOUR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_T.ToUpper Then TBL_SEIKYU.TAXI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_T.ToUpper Then TBL_SEIKYU.TAXI_SEISAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEISANSHO_URL.ToUpper Then TBL_SEIKYU.SEISANSHO_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TAXI_TICKET_URL.ToUpper Then TBL_SEIKYU.TAXI_TICKET_URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEISAN_KANRYO.ToUpper Then TBL_SEIKYU.SEISAN_KANRYO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_JR.ToUpper Then TBL_SEIKYU.MR_JR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL.ToUpper Then TBL_SEIKYU.MR_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_HOTEL_TOZEI.ToUpper Then TBL_SEIKYU.MR_HOTEL_TOZEI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEND_FLAG.ToUpper Then TBL_SEIKYU.SEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TTANTO_ID.ToUpper Then TBL_SEIKYU.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INPUT_DATE.ToUpper Then TBL_SEIKYU.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INPUT_USER.ToUpper Then TBL_SEIKYU.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UPDATE_DATE.ToUpper Then TBL_SEIKYU.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UPDATE_USER.ToUpper Then TBL_SEIKYU.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KOUENKAI_NAME.ToUpper Then TBL_SEIKYU.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.FROM_DATE.ToUpper Then TBL_SEIKYU.FROM_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SANKASHA_ID.ToUpper Then TBL_SEIKYU.SANKASHA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.DR_CD.ToUpper Then TBL_SEIKYU.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.DR_NAME.ToUpper Then TBL_SEIKYU.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.MR_NAME.ToUpper Then TBL_SEIKYU.MR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.COST_CENTER.ToUpper Then TBL_SEIKYU.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INTERNAL_ORDER_T.ToUpper Then TBL_SEIKYU.INTERNAL_ORDER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INTERNAL_ORDER_TF.ToUpper Then TBL_SEIKYU.INTERNAL_ORDER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.ACCOUNT_CD_T.ToUpper Then TBL_SEIKYU.ACCOUNT_CD_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.ACCOUNT_CD_TF.ToUpper Then TBL_SEIKYU.ACCOUNT_CD_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.ZETIA_CD.ToUpper Then TBL_SEIKYU.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SRM_HACYU_KBN.ToUpper Then TBL_SEIKYU.SRM_HACYU_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.ROW_NO.ToUpper Then TBL_SEIKYU.ROW_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TO_DATE.ToUpper Then TBL_SEIKYU.TO_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.DANTAI_CODE.ToUpper Then TBL_SEIKYU.DANTAI_CODE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_SEIKYU.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.BU.ToUpper Then TBL_SEIKYU.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_SEIKYU.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_SEIKYU.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TEHAI_ID.ToUpper Then TBL_SEIKYU.TEHAI_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            '@@@ Phase2
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJO_NAME.ToUpper Then TBL_SEIKYU.KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.SEIHIN_NAME.ToUpper Then TBL_SEIKYU.SEIHIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TEHAI_TANTO_BU.ToUpper Then TBL_SEIKYU.TEHAI_TANTO_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TEHAI_TANTO_AREA.ToUpper Then TBL_SEIKYU.TEHAI_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TEHAI_TANTO_EIGYOSHO.ToUpper Then TBL_SEIKYU.TEHAI_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.TEHAI_TANTO_NAME.ToUpper Then TBL_SEIKYU.TEHAI_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            '@@@ Phase2

        Next wCnt

        Return TBL_SEIKYU
    End Function
#End Region

#Region "交通・宿泊手配テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID.ToUpper Then TBL_KOTSUHOTEL.SALEFORCE_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID.ToUpper Then TBL_KOTSUHOTEL.SANKASHA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO.ToUpper Then TBL_KOTSUHOTEL.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI.ToUpper Then TBL_KOTSUHOTEL.REQ_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI.ToUpper Then TBL_KOTSUHOTEL.ANS_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL.ToUpper Then TBL_KOTSUHOTEL.TIME_STAMP_BYL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_TOP.ToUpper Then TBL_KOTSUHOTEL.TIME_STAMP_TOP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_MPID.ToUpper Then TBL_KOTSUHOTEL.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_CD.ToUpper Then TBL_KOTSUHOTEL.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_NAME.ToUpper Then TBL_KOTSUHOTEL.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_KANA.ToUpper Then TBL_KOTSUHOTEL.DR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI.ToUpper Then TBL_KOTSUHOTEL.DR_YAKUWARI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SEX.ToUpper Then TBL_KOTSUHOTEL.DR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_AGE.ToUpper Then TBL_KOTSUHOTEL.DR_AGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHITEIGAI_RIYU.ToUpper Then TBL_KOTSUHOTEL.SHITEIGAI_RIYU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA.ToUpper Then TBL_KOTSUHOTEL.DR_SANKA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_BU.ToUpper Then TBL_KOTSUHOTEL.MR_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_AREA.ToUpper Then TBL_KOTSUHOTEL.MR_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO.ToUpper Then TBL_KOTSUHOTEL.MR_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_NAME.ToUpper Then TBL_KOTSUHOTEL.MR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA.ToUpper Then TBL_KOTSUHOTEL.MR_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_KANA.ToUpper Then TBL_KOTSUHOTEL.MR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_PC.ToUpper Then TBL_KOTSUHOTEL.MR_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_KEITAI.ToUpper Then TBL_KOTSUHOTEL.MR_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI.ToUpper Then TBL_KOTSUHOTEL.MR_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_TEL.ToUpper Then TBL_KOTSUHOTEL.MR_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS.ToUpper Then TBL_KOTSUHOTEL.MR_SEND_SAKI_FS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER.ToUpper Then TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CD.ToUpper Then TBL_KOTSUHOTEL.ACCOUNT_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER.ToUpper Then TBL_KOTSUHOTEL.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER.ToUpper Then TBL_KOTSUHOTEL.INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ZETIA_CD.ToUpper Then TBL_KOTSUHOTEL.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME.ToUpper Then TBL_KOTSUHOTEL.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE.ToUpper Then TBL_KOTSUHOTEL.SHONIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TEHAI_HOTEL.ToUpper Then TBL_KOTSUHOTEL.TEHAI_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.HOTEL_IRAINAIYOU.ToUpper Then TBL_KOTSUHOTEL.HOTEL_IRAINAIYOU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_DATE.ToUpper Then TBL_KOTSUHOTEL.REQ_HOTEL_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HAKUSU.ToUpper Then TBL_KOTSUHOTEL.REQ_HAKUSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_SMOKING.ToUpper Then TBL_KOTSUHOTEL.REQ_HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.REQ_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_HOTEL.ToUpper Then TBL_KOTSUHOTEL.ANS_STATUS_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NAME.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_ADDRESS.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_TEL.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_DATE.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HAKUSU.ToUpper Then TBL_KOTSUHOTEL.ANS_HAKUSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKIN_TIME.ToUpper Then TBL_KOTSUHOTEL.ANS_CHECKIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKOUT_TIME.ToUpper Then TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_ROOM_TYPE.ToUpper Then TBL_KOTSUHOTEL.ANS_ROOM_TYPE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_SMOKING.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTELHI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI_TOZEI.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTELHI_TOZEI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI_CANCEL.ToUpper Then TBL_KOTSUHOTEL.ANS_HOTELHI_CANCEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TEHAI_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TEHAI_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_KOTSU_BIKO.ToUpper Then TBL_KOTSUHOTEL.REQ_KOTSU_BIKO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSU_BIKO.ToUpper Then TBL_KOTSUHOTEL.ANS_KOTSU_BIKO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_FARE.ToUpper Then TBL_KOTSUHOTEL.ANS_RAIL_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_FARE.ToUpper Then TBL_KOTSUHOTEL.ANS_OTHER_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_FARE.ToUpper Then TBL_KOTSUHOTEL.ANS_AIR_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSUHOTEL_TESURYO.ToUpper Then TBL_KOTSUHOTEL.ANS_KOTSUHOTEL_TESURYO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TESURYO.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TESURYO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TICKET_SEND_DAY.ToUpper Then TBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI.ToUpper Then TBL_KOTSUHOTEL.TEHAI_TAXI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_NOTE.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_11.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_12.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_13.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_14.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_15.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_16.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_17.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_18.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_19.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_20.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NOTE.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_O_TEHAI.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_O_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_F_TEHAI.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_F_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEX.ToUpper Then TBL_KOTSUHOTEL.MR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_AGE.ToUpper Then TBL_KOTSUHOTEL.MR_AGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_O_TEHAI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_O_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_F_TEHAI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_F_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NOTE.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_KOTSUHI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_KOTSUHI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTELHI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI_TOZEI.ToUpper Then TBL_KOTSUHOTEL.ANS_MR_HOTELHI_TOZEI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG.ToUpper Then TBL_KOTSUHOTEL.SEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TTANTO_ID.ToUpper Then TBL_KOTSUHOTEL.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEIKYU_NO_TOPTOUR.ToUpper Then TBL_KOTSUHOTEL.SEIKYU_NO_TOPTOUR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE.ToUpper Then TBL_KOTSUHOTEL.SCAN_IMPORT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KINKYU_FLAG.ToUpper Then TBL_KOTSUHOTEL.KINKYU_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.YOBI1.ToUpper Then TBL_KOTSUHOTEL.YOBI1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.YOBI2.ToUpper Then TBL_KOTSUHOTEL.YOBI2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.YOBI3.ToUpper Then TBL_KOTSUHOTEL.YOBI3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.YOBI4.ToUpper Then TBL_KOTSUHOTEL.YOBI4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.YOBI5.ToUpper Then TBL_KOTSUHOTEL.YOBI5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE.ToUpper Then TBL_KOTSUHOTEL.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INPUT_USER.ToUpper Then TBL_KOTSUHOTEL.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE.ToUpper Then TBL_KOTSUHOTEL.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER.ToUpper Then TBL_KOTSUHOTEL.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE.ToUpper Then TBL_KOTSUHOTEL.SEND_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOTSU_ACCOUNT_CD.ToUpper Then TBL_KOTSUHOTEL.KOTSU_ACCOUNT_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOTSU_COST_CENTER.ToUpper Then TBL_KOTSUHOTEL.KOTSU_COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOTSU_INTERNAL_ORDER.ToUpper Then TBL_KOTSUHOTEL.KOTSU_INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOTSU_ZETIA_CD.ToUpper Then TBL_KOTSUHOTEL.KOTSU_ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NAME.ToUpper Then TBL_KOTSUHOTEL.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_TIME_STAMP.ToUpper Then TBL_KOTSUHOTEL.KOUENKAI_TIME_STAMP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TORIKESHI_FLG.ToUpper Then TBL_KOTSUHOTEL.TORIKESHI_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_PRT_NAME.ToUpper Then TBL_KOTSUHOTEL.TAXI_PRT_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KAIJO_NAME.ToUpper Then TBL_KOTSUHOTEL.KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FROM_DATE.ToUpper Then TBL_KOTSUHOTEL.FROM_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TO_DATE.ToUpper Then TBL_KOTSUHOTEL.TO_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.USER_NAME.ToUpper Then TBL_KOTSUHOTEL.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEIHIN_NAME.ToUpper Then TBL_KOTSUHOTEL.SEIHIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP.ToUpper Then TBL_KOTSUHOTEL.TIME_STAMP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.BU.ToUpper Then TBL_KOTSUHOTEL.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_KOTSUHOTEL.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_KOTSUHOTEL.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_KOTSUHOTEL.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIKAKU_TANTO_ROMA.ToUpper Then TBL_KOTSUHOTEL.KIKAKU_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIHON_ACCOUNT_CD_TF.ToUpper Then TBL_KOTSUHOTEL.KIHON_ACCOUNT_CD_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIHON_ACCOUNT_CD_T.ToUpper Then TBL_KOTSUHOTEL.KIHON_ACCOUNT_CD_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KIHON_COST_CENTER.ToUpper Then TBL_KOTSUHOTEL.KIHON_COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SRM_HACYU_KBN.ToUpper Then TBL_KOTSUHOTEL.SRM_HACYU_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SANKA_FLAG.ToUpper Then TBL_KOTSUHOTEL.SANKA_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHIHARAI_NO.ToUpper Then TBL_KOTSUHOTEL.SHIHARAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEIKYU_NO_TOPTOUR.ToUpper Then TBL_KOTSUHOTEL.SEIKYU_NO_TOPTOUR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEISAN_YM.ToUpper Then TBL_KOTSUHOTEL.SEISAN_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KOTSUHOTEL
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL_KEY.DataStruct) As TableDef.TBL_KOTSUHOTEL_KEY.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID.ToUpper Then TBL_KOTSUHOTEL.SALEFORCE_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID.ToUpper Then TBL_KOTSUHOTEL.SANKASHA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO.ToUpper Then TBL_KOTSUHOTEL.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL.ToUpper Then TBL_KOTSUHOTEL.TIME_STAMP_BYL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE.ToUpper Then TBL_KOTSUHOTEL.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE.ToUpper Then TBL_KOTSUHOTEL.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.USER_NAME.ToUpper Then TBL_KOTSUHOTEL.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SANKA_FLAG.ToUpper Then TBL_KOTSUHOTEL.SANKA_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KOTSUHOTEL
    End Function
#End Region

#Region "会場手配テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As TableDef.TBL_KAIJO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SALEFORCE_ID.ToUpper Then TBL_KAIJO.SALEFORCE_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_FROM.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_FROM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_CNT.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHAIN_ROOM_TEHAI.ToUpper Then TBL_KAIJO.SHAIN_ROOM_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHAIN_ROOM_CNT.ToUpper Then TBL_KAIJO.SHAIN_ROOM_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.MANAGER_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_ROOM_FROM.ToUpper Then TBL_KAIJO.MANAGER_ROOM_FROM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_ROOM_CNT.ToUpper Then TBL_KAIJO.MANAGER_ROOM_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.REQ_ROOM_CNT.ToUpper Then TBL_KAIJO.REQ_ROOM_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.REQ_STAY_DATE.ToUpper Then TBL_KAIJO.REQ_STAY_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.REQ_KOTSU_CNT.ToUpper Then TBL_KAIJO.REQ_KOTSU_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.REQ_TAXI_CNT.ToUpper Then TBL_KAIJO.REQ_TAXI_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KAIJOUHI_TF.ToUpper Then TBL_KAIJO.ANS_KAIJOUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KIZAIHI_TF.ToUpper Then TBL_KAIJO.ANS_KIZAIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_INSHOKUHI_TF.ToUpper Then TBL_KAIJO.ANS_INSHOKUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_991330401_TF.ToUpper Then TBL_KAIJO.ANS_991330401_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_HOTELHI_TF.ToUpper Then TBL_KAIJO.ANS_HOTELHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KOTSUHI_TF.ToUpper Then TBL_KAIJO.ANS_KOTSUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_TAXI_TF.ToUpper Then TBL_KAIJO.ANS_TAXI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_TEHAI_TESURYO_TF.ToUpper Then TBL_KAIJO.ANS_TEHAI_TESURYO_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_TAXI_HAKKEN_TESURYO_TF.ToUpper Then TBL_KAIJO.ANS_TAXI_HAKKEN_TESURYO_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_TAXI_SEISAN_TESURYO_TF.ToUpper Then TBL_KAIJO.ANS_TAXI_SEISAN_TESURYO_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_JINKENHI_TF.ToUpper Then TBL_KAIJO.ANS_JINKENHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_OTHER_TF.ToUpper Then TBL_KAIJO.ANS_OTHER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KANRIHI_TF.ToUpper Then TBL_KAIJO.ANS_KANRIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_41120200_TF.ToUpper Then TBL_KAIJO.ANS_41120200_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_TOTAL_TF.ToUpper Then TBL_KAIJO.ANS_TOTAL_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KAIJOUHI_T.ToUpper Then TBL_KAIJO.ANS_KAIJOUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KIZAIHI_T.ToUpper Then TBL_KAIJO.ANS_KIZAIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_INSHOKUHI_T.ToUpper Then TBL_KAIJO.ANS_INSHOKUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_991330401_T.ToUpper Then TBL_KAIJO.ANS_991330401_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_JINKENHI_T.ToUpper Then TBL_KAIJO.ANS_JINKENHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_OTHER_T.ToUpper Then TBL_KAIJO.ANS_OTHER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_KANRIHI_T.ToUpper Then TBL_KAIJO.ANS_KANRIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_41120200_T.ToUpper Then TBL_KAIJO.ANS_41120200_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_TOTAL_T.ToUpper Then TBL_KAIJO.ANS_TOTAL_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_NMBR.ToUpper Then TBL_KAIJO.SANKA_YOTEI_CNT_NMBR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_MBR.ToUpper Then TBL_KAIJO.SANKA_YOTEI_CNT_MBR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SRM_HACYU_KBN.ToUpper Then TBL_KAIJO.SRM_HACYU_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.BU.ToUpper Then TBL_KAIJO.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_JIGYOUBU.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_JIGYOUBU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_ROMA.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_EMAIL_PC.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_KEITAI.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KIKAKU_TANTO_TEL.ToUpper Then TBL_KAIJO.KIKAKU_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.COST_CENTER.ToUpper Then TBL_KAIJO.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_BU.ToUpper Then TBL_KAIJO.TEHAI_TANTO_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_AREA.ToUpper Then TBL_KAIJO.TEHAI_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EIGYOSHO.ToUpper Then TBL_KAIJO.TEHAI_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_NAME.ToUpper Then TBL_KAIJO.TEHAI_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_ROMA.ToUpper Then TBL_KAIJO.TEHAI_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_PC.ToUpper Then TBL_KAIJO.TEHAI_TANTO_EMAIL_PC = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_KEITAI.ToUpper Then TBL_KAIJO.TEHAI_TANTO_EMAIL_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_KEITAI.ToUpper Then TBL_KAIJO.TEHAI_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEHAI_TANTO_TEL.ToUpper Then TBL_KAIJO.TEHAI_TANTO_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.YOSAN_TF.ToUpper Then TBL_KAIJO.YOSAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.YOSAN_T.ToUpper Then TBL_KAIJO.YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TTANTO_ID.ToUpper Then TBL_KAIJO.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TTEHAI_TANTO.ToUpper Then TBL_KAIJO.TTEHAI_TANTO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IROUKAI_YOSAN_T.ToUpper Then TBL_KAIJO.IROUKAI_YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IKENKOUKAN_YOSAN_T.ToUpper Then TBL_KAIJO.IKENKOUKAN_YOSAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.USER_NAME.ToUpper Then TBL_KAIJO.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KAIJO
    End Function
#End Region

#Region "弁当手配テーブル"
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
#End Region

#Region "費用テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_COST As TableDef.TBL_COST.DataStruct) As TableDef.TBL_COST.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.SEIKYU_NO.ToUpper Then TBL_COST.SEIKYU_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.SEIKYU_YM.ToUpper Then TBL_COST.SEIKYU_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.COSTCENTER_CD.ToUpper Then TBL_COST.COSTCENTER_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.KOTSUHI.ToUpper Then TBL_COST.KOTSUHI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.HOTELHI.ToUpper Then TBL_COST.HOTELHI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.TAXI_T.ToUpper Then TBL_COST.TAXI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.TAXI_SEISAN_T.ToUpper Then TBL_COST.TAXI_SEISAN_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.SAP_FLAG.ToUpper Then TBL_COST.SAP_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.INPUT_DATE.ToUpper Then TBL_COST.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.INPUT_USER.ToUpper Then TBL_COST.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.UPDATE_DATE.ToUpper Then TBL_COST.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_COST.Column.UPDATE_USER.ToUpper Then TBL_COST.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_COST
    End Function
#End Region

#Region "タクチケ発行テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_KAISHA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KENSHU.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_KENSHU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO.ToUpper Then TBL_TAXITICKET_HAKKO.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID.ToUpper Then TBL_TAXITICKET_HAKKO.SANKASHA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_LINE_NO.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_LINE_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_USED_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_URIAGE.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_URIAGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEISAN_FEE.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HAKKO_FEE.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_ENTA.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_ENTA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_VOID.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_VOID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_MIKETSU.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_MIKETSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_IMPORT_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_IMPORT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM.ToUpper Then TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SEIKYU_NO_TOPTOUR.ToUpper Then TBL_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.INPUT_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.INPUT_USER.ToUpper Then TBL_TAXITICKET_HAKKO.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_USER.ToUpper Then TBL_TAXITICKET_HAKKO.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TAXI_PRT_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.TAXI_PRT_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.FROM_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.FROM_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.TO_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.TO_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.USER_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_MPID.ToUpper Then TBL_TAXITICKET_HAKKO.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_CD.ToUpper Then TBL_TAXITICKET_HAKKO.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_KANA.ToUpper Then TBL_TAXITICKET_HAKKO.DR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_SHISETSU_CD.ToUpper Then TBL_TAXITICKET_HAKKO.DR_SHISETSU_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_SHISETSU_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.DR_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_SHISETSU_ADDRESS.ToUpper Then TBL_TAXITICKET_HAKKO.DR_SHISETSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_YAKUWARI.ToUpper Then TBL_TAXITICKET_HAKKO.DR_YAKUWARI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_SEX.ToUpper Then TBL_TAXITICKET_HAKKO.DR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_AGE.ToUpper Then TBL_TAXITICKET_HAKKO.DR_AGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SHITEIGAI_RIYU.ToUpper Then TBL_TAXITICKET_HAKKO.SHITEIGAI_RIYU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.DR_SANKA.ToUpper Then TBL_TAXITICKET_HAKKO.DR_SANKA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_1.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_1.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_1.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_1.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_1.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_1.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_2.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_2.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_2.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_2.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_2.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_2.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_3.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_3.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_3.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_3.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_3.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_3.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_4.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_4.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_4.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_4.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_4.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_4.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_5.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_5.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_5.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_5.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_5.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_5.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_6.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_6.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_6.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_6.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_6.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_6.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_7.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_7.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_7.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_7.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_7.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_7.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_8.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_8.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_8.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_8.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_8.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_8.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_9.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_9.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_9.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_9.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_9.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_9.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_10.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_10.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_10.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_10.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_10.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_10.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_11.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_11.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_11.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_11.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_11.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_11.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_11 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_12.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_12.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_12.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_12.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_12.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_12.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_12 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_13.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_13.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_13.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_13.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_13.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_13.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_13 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_14.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_14.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_14.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_14.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_14.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_14.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_14 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_15.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_15.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_15.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_15.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_15.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_15.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_15 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_16.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_16.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_16.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_16.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_16.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_16.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_16 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_17.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_17.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_17.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_17.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_17.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_17.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_17 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_18.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_18.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_18.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_18.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_18.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_18.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_18 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_19.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_19.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_19.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_19.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_19.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_19.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_19 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE_20.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_KENSHU_20.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_KENSHU_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_NO_20.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_NO_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_20.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_HAKKO_DATE_20.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_HAKKO_DATE_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_RMKS_20.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_RMKS_20 = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KAZEI_KBN.ToUpper Then TBL_TAXITICKET_HAKKO.KAZEI_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.COST_CENTER.ToUpper Then TBL_TAXITICKET_HAKKO.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.REQ_TAXI_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.REQ_TAXI_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.ANS_TAXI_DATE.ToUpper Then TBL_TAXITICKET_HAKKO.ANS_TAXI_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SRM_HACYU_KBN.ToUpper Then TBL_TAXITICKET_HAKKO.SRM_HACYU_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KAIJO_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.KAIJO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.BU.ToUpper Then TBL_TAXITICKET_HAKKO.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_TAXITICKET_HAKKO.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_TAXITICKET_HAKKO.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIKAKU_TANTO_ROMA.ToUpper Then TBL_TAXITICKET_HAKKO.KIKAKU_TANTO_ROMA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIHON_ACCOUNT_CD_TF.ToUpper Then TBL_TAXITICKET_HAKKO.KIHON_ACCOUNT_CD_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIHON_ACCOUNT_CD_T.ToUpper Then TBL_TAXITICKET_HAKKO.KIHON_ACCOUNT_CD_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KOTSU_ACCOUNT_CD.ToUpper Then TBL_TAXITICKET_HAKKO.KOTSU_ACCOUNT_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIHON_COST_CENTER.ToUpper Then TBL_TAXITICKET_HAKKO.KIHON_COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KOTSU_COST_CENTER.ToUpper Then TBL_TAXITICKET_HAKKO.KOTSU_COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIHON_INTERNAL_ORDER.ToUpper Then TBL_TAXITICKET_HAKKO.KIHON_INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KOTSU_INTERNAL_ORDER.ToUpper Then TBL_TAXITICKET_HAKKO.KOTSU_INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KIHON_ZETIA_CD.ToUpper Then TBL_TAXITICKET_HAKKO.KIHON_ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.KOTSU_ZETIA_CD.ToUpper Then TBL_TAXITICKET_HAKKO.KOTSU_ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SANKA_FLAG.ToUpper Then TBL_TAXITICKET_HAKKO.SANKA_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SANKA_UPDATE.ToUpper Then TBL_TAXITICKET_HAKKO.SANKA_UPDATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.MR_BU.ToUpper Then TBL_TAXITICKET_HAKKO.MR_BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.MR_AREA.ToUpper Then TBL_TAXITICKET_HAKKO.MR_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.MR_EIGYOSHO.ToUpper Then TBL_TAXITICKET_HAKKO.MR_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.MR_NAME.ToUpper Then TBL_TAXITICKET_HAKKO.MR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.MR_KANA.ToUpper Then TBL_TAXITICKET_HAKKO.MR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.MR_KEITAI.ToUpper Then TBL_TAXITICKET_HAKKO.MR_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)

            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SHIHARAI_NO.ToUpper Then TBL_TAXITICKET_HAKKO.SHIHARAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_TAXITICKET_HAKKO.Column.SEISAN_YM.ToUpper Then TBL_TAXITICKET_HAKKO.SEISAN_YM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_TAXITICKET_HAKKO
    End Function
#End Region

#Region "参加テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_SANKA As TableDef.TBL_SANKA.DataStruct) As TableDef.TBL_SANKA.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.KOUENKAI_NO.ToUpper Then TBL_SANKA.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.SANKASHA_ID.ToUpper Then TBL_SANKA.SANKASHA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.DR_SANKA.ToUpper Then TBL_SANKA.DR_SANKA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.INPUT_DATE.ToUpper Then TBL_SANKA.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.INPUT_USER.ToUpper Then TBL_SANKA.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.UPDATE_DATE.ToUpper Then TBL_SANKA.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SANKA.Column.UPDATE_USER.ToUpper Then TBL_SANKA.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_SANKA
    End Function
#End Region

#Region "承認テーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_SHOUNIN As TableDef.TBL_SHOUNIN.DataStruct) As TableDef.TBL_SHOUNIN.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.KOUENKAI_NO.ToUpper Then TBL_SHOUNIN.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.SEIKYU_NO_TOPTOUR.ToUpper Then TBL_SHOUNIN.SEIKYU_NO_TOPTOUR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.SHIHARAI_NO.ToUpper Then TBL_SHOUNIN.SHIHARAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.SHOUNIN_KUBUN.ToUpper Then TBL_SHOUNIN.SHOUNIN_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.SHOUNIN_DATE.ToUpper Then TBL_SHOUNIN.SHOUNIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.INPUT_DATE.ToUpper Then TBL_SHOUNIN.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.INPUT_USER.ToUpper Then TBL_SHOUNIN.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.UPDATE_DATE.ToUpper Then TBL_SHOUNIN.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SHOUNIN.Column.UPDATE_USER.ToUpper Then TBL_SHOUNIN.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_SHOUNIN
    End Function
#End Region

#Region "施設マスタ"
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
#End Region

#Region "ユーザマスタ"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_USER As TableDef.MS_USER.DataStruct) As TableDef.MS_USER.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.SYSTEM_ID.ToUpper Then MS_USER.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.LOGIN_ID.ToUpper Then MS_USER.LOGIN_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.PASSWORD.ToUpper Then MS_USER.PASSWORD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.KENGEN.ToUpper Then MS_USER.KENGEN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.KENGEN_SEISAN.ToUpper Then MS_USER.KENGEN_SEISAN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.USER_NAME.ToUpper Then MS_USER.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.STOP_FLG.ToUpper Then MS_USER.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.INPUT_DATE.ToUpper Then MS_USER.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.INPUT_USER.ToUpper Then MS_USER.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.UPDATE_DATE.ToUpper Then MS_USER.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_USER.Column.UPDATE_USER.ToUpper Then MS_USER.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_USER
    End Function
#End Region

#Region "コストセンターマスタ"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct) As TableDef.MS_COSTCENTER.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.COSTCENTER_CD.ToUpper Then MS_COSTCENTER.COSTCENTER_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.COSTCENTER_NAME.ToUpper Then MS_COSTCENTER.COSTCENTER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.STOP_FLG.ToUpper Then MS_COSTCENTER.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.INPUT_DATE.ToUpper Then MS_COSTCENTER.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.INPUT_USER.ToUpper Then MS_COSTCENTER.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.UPDATE_DATE.ToUpper Then MS_COSTCENTER.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_COSTCENTER.Column.UPDATE_USER.ToUpper Then MS_COSTCENTER.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_COSTCENTER
    End Function
#End Region

#Region "BUマスタ"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_BU As TableDef.MS_BU.DataStruct) As TableDef.MS_BU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.SYSTEM_ID.ToUpper Then MS_BU.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.BU.ToUpper Then MS_BU.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.STOP_FLG.ToUpper Then MS_BU.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.INPUT_DATE.ToUpper Then MS_BU.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.INPUT_USER.ToUpper Then MS_BU.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.UPDATE_DATE.ToUpper Then MS_BU.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_BU.Column.UPDATE_USER.ToUpper Then MS_BU.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_BU
    End Function
#End Region

#Region "エリアマスタ"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_AREA As TableDef.MS_AREA.DataStruct) As TableDef.MS_AREA.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.SYSTEM_ID.ToUpper Then MS_AREA.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.area.ToUpper Then MS_AREA.area = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.STOP_FLG.ToUpper Then MS_AREA.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.INPUT_DATE.ToUpper Then MS_AREA.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.INPUT_USER.ToUpper Then MS_AREA.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.UPDATE_DATE.ToUpper Then MS_AREA.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.UPDATE_USER.ToUpper Then MS_AREA.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_AREA
    End Function
#End Region

#Region "製品マスタ"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_SEIHIN As TableDef.MS_SEIHIN.DataStruct) As TableDef.MS_SEIHIN.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.SYSTEM_ID.ToUpper Then MS_SEIHIN.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.SEIHIN.ToUpper Then MS_SEIHIN.SEIHIN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.STOP_FLG.ToUpper Then MS_SEIHIN.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.INPUT_DATE.ToUpper Then MS_SEIHIN.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.INPUT_USER.ToUpper Then MS_SEIHIN.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.UPDATE_DATE.ToUpper Then MS_SEIHIN.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SEIHIN.Column.UPDATE_USER.ToUpper Then MS_SEIHIN.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_SEIHIN
    End Function
#End Region

    '#Region "営業所マスタ"
    '    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_EIGYOSHO As TableDef.MS_EIGYOSHO.DataStruct) As TableDef.MS_EIGYOSHO.DataStruct
    '        Dim wCnt As Integer = 0

    '        For wCnt = 0 To RsData.FieldCount - 1
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.SYSTEM_ID.ToUpper Then MS_EIGYOSHO.SYSTEM_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.未定.ToUpper Then MS_EIGYOSHO.未定 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.STOP_FLG.ToUpper Then MS_EIGYOSHO.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.INPUT_DATE.ToUpper Then MS_EIGYOSHO.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.INPUT_USER.ToUpper Then MS_EIGYOSHO.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.UPDATE_DATE.ToUpper Then MS_EIGYOSHO.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.UPDATE_USER.ToUpper Then MS_EIGYOSHO.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
    '        Next wCnt

    '        Return MS_EIGYOSHO
    '    End Function
    '#End Region

#Region "消費税マスタ"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_ZEI As TableDef.MS_ZEI.DataStruct) As TableDef.MS_ZEI.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.ZEI_CD.ToUpper Then MS_ZEI.ZEI_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.ZEI_NAME.ToUpper Then MS_ZEI.ZEI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.ZEI_RATE.ToUpper Then MS_ZEI.ZEI_RATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.START_DATE.ToUpper Then MS_ZEI.START_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.END_DATE.ToUpper Then MS_ZEI.END_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.SAP_ZEI_CD.ToUpper Then MS_ZEI.SAP_ZEI_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.STOP_FLG.ToUpper Then MS_ZEI.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.INPUT_DATE.ToUpper Then MS_ZEI.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.INPUT_USER.ToUpper Then MS_ZEI.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.UPDATE_DATE.ToUpper Then MS_ZEI.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ZEI.Column.UPDATE_USER.ToUpper Then MS_ZEI.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_ZEI
    End Function
#End Region

#Region "コードマスタ"
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
#End Region

#Region "ログテーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct) As TableDef.TBL_LOG.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.LOG_NO.ToUpper Then TBL_LOG.LOG_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.INPUT_DATE.ToUpper Then TBL_LOG.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.INPUT_USER.ToUpper Then TBL_LOG.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.SYORI_KBN.ToUpper Then TBL_LOG.SYORI_KBN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.SYORI_NAME.ToUpper Then TBL_LOG.SYORI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.TABLE_NAME.ToUpper Then TBL_LOG.TABLE_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.STATUS.ToUpper Then TBL_LOG.STATUS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.NOTE.ToUpper Then TBL_LOG.NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_LOG.Column.USER_NAME.ToUpper Then TBL_LOG.USER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_LOG
    End Function
#End Region

#Region "デリゲートテーブル"
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_DELIGATE As TableDef.TBL_DELIGATE.DataStruct) As TableDef.TBL_DELIGATE.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE.Column.LOGIN_ID.ToUpper Then TBL_DELIGATE.LOGIN_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE.Column.CNT.ToUpper Then TBL_DELIGATE.CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE.Column.MAXCNT.ToUpper Then TBL_DELIGATE.MAXCNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE.Column.CSVSTRING.ToUpper Then TBL_DELIGATE.CSVSTRING = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_DELIGATE
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct) As TableDef.TBL_DELIGATE2.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE2.Column.LOGIN_ID.ToUpper Then TBL_DELIGATE2.LOGIN_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE2.Column.CNT.ToUpper Then TBL_DELIGATE2.CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DELIGATE2.Column.MAXCNT.ToUpper Then TBL_DELIGATE2.MAXCNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_DELIGATE2
    End Function
#End Region

#Region "分析CSV出力用テーブル"

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct) As TableDef.TBL_BUNSEKICSV.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BUNSEKICSV.Column.LOGIN_ID.ToUpper Then TBL_BUNSEKICSV.LOGIN_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BUNSEKICSV.Column.LINE_NO.ToUpper Then TBL_BUNSEKICSV.LINE_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_BUNSEKICSV.Column.LINE_DATA.ToUpper Then TBL_BUNSEKICSV.LINE_DATA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_BUNSEKICSV
    End Function

#End Region
#End Region


#Region "データ取得"
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
            Case AppModule.TableType.TBL_COST
                Dim TBL_COST As TableDef.TBL_COST.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_COST = SetRsData(RsData, TBL_COST)
                End If
                RsData.Close()
                Return TBL_COST
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
            Case AppModule.TableType.MS_COSTCENTER
                Dim MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_COSTCENTER = SetRsData(RsData, MS_COSTCENTER)
                End If
                RsData.Close()
                Return MS_COSTCENTER
                'Case AppModule.TableType.MS_JIGYOSHO
                '    Dim MS_JIGYOSHO As TableDef.MS_JIGYOSHO.DataStruct = Nothing
                '    RsData = CmnDb.Read(SQL, DbConn)
                '    If RsData.Read() Then
                '        MS_JIGYOSHO = SetRsData(RsData, MS_JIGYOSHO)
                '    End If
                '    RsData.Close()
                '    Return MS_JIGYOSHO
                'Case AppModule.TableType.MS_AREA
                '    Dim MS_AREA As TableDef.MS_AREA.DataStruct = Nothing
                '    RsData = CmnDb.Read(SQL, DbConn)
                '    If RsData.Read() Then
                '        MS_AREA = SetRsData(RsData, MS_AREA)
                '    End If
                '    RsData.Close()
                '    Return MS_AREA
                'Case AppModule.TableType.MS_EIGYOSHO
                '    Dim MS_EIGYOSHO As TableDef.MS_EIGYOSHO.DataStruct = Nothing
                '    RsData = CmnDb.Read(SQL, DbConn)
                '    If RsData.Read() Then
                '        MS_EIGYOSHO = SetRsData(RsData, MS_EIGYOSHO)
                '    End If
                '    RsData.Close()
                '    Return MS_EIGYOSHO
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

    'データの有無を返す
    Public Shared Function IsExist(ByVal SQL As String, ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean
        Dim wFlag As Boolean = False
        Dim RsData As System.Data.SqlClient.SqlDataReader

        RsData = CmnDb.Read(SQL, DbConn)
        If RsData.Read() Then
            wFlag = True
        End If
        RsData.Close()

        Return wFlag
    End Function
    Public Shared Function IsExist(ByVal SQL As String, ByVal DbConn As System.Data.SqlClient.SqlConnection, ByVal DbTrans As SqlClient.SqlTransaction) As Boolean
        Dim wFlag As Boolean = False
        Dim RsData As System.Data.SqlClient.SqlDataReader

        RsData = CmnDb.Read(SQL, DbConn, DbTrans)
        If RsData.Read() Then
            wFlag = True
        End If
        RsData.Close()

        Return wFlag
    End Function

#End Region


#Region "== 表示用に文字列を編集 =="
    'データ区分
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

    'ログインID
    Public Shared Function GetName_LOGIN_ID(ByVal LOGIN_ID As String) As String
        Return LOGIN_ID
    End Function

    'パスワード
    Public Shared Function GetName_PASSWORD(ByVal PASSWORD As String) As String
        Return PASSWORD
    End Function

    'NOZOMI送信フラグ
    Public Shared Function GetName_SEND_FLAG(ByVal SEND_FLAG As String, Optional ByVal ShortFormat As Boolean = False) As String
        Select Case SEND_FLAG
            Case AppConst.SEND_FLAG.Code.Mi, AppConst.SEND_FLAG.Name.Mi, AppConst.SEND_FLAG.Name.ShortFormat.Mi
                If ShortFormat = False Then
                    Return AppConst.SEND_FLAG.Name.Mi
                Else
                    Return AppConst.SEND_FLAG.Name.ShortFormat.Mi
                End If
            Case AppConst.SEND_FLAG.Code.Taisho, AppConst.SEND_FLAG.Name.Taisho, AppConst.SEND_FLAG.Name.ShortFormat.Taisho
                If ShortFormat = False Then
                    Return AppConst.SEND_FLAG.Name.Taisho
                Else
                    Return AppConst.SEND_FLAG.Name.ShortFormat.Taisho
                End If
            Case AppConst.SEND_FLAG.Code.Sumi, AppConst.SEND_FLAG.Name.Sumi, AppConst.SEND_FLAG.Name.ShortFormat.Sumi
                If ShortFormat = False Then
                    Return AppConst.SEND_FLAG.Name.Sumi
                Else
                    Return AppConst.SEND_FLAG.Name.ShortFormat.Sumi
                End If

            Case Else
                Return ""
        End Select
    End Function

#Region "会合情報"
    '会合番号
    Public Shared Function GetName_KOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
        Return KOUENKAI_NO
    End Function

    '取消フラグ
    Public Shared Function GetName_TORIKESHI_FLG(ByVal TORIKESHI_FLG As String) As String
        Select Case TORIKESHI_FLG
            Case AppConst.KOUENKAI.TORIKESHI_FLG.Code.No
                Return AppConst.KOUENKAI.TORIKESHI_FLG.Name.No
            Case AppConst.KOUENKAI.TORIKESHI_FLG.Code.Yes
                Return AppConst.KOUENKAI.TORIKESHI_FLG.Name.Yes
            Case Else
                Return String.Empty
        End Select
    End Function

    '講演基本情報　未読・既読
    Public Shared Function GetName_KIDOKU_FLG(ByVal KIDOKU_FLG As String) As String
        Select Case KIDOKU_FLG
            Case AppConst.KOUENKAI.KIDOKU_FLG.Code.Yes
                Return AppConst.KOUENKAI.KIDOKU_FLG.Code.Yes
            Case AppConst.KOUENKAI.KIDOKU_FLG.Code.No
                Return AppConst.KOUENKAI.KIDOKU_FLG.Code.No
            Case Else
                Return ""
        End Select
    End Function

    '会合手配ID
    Public Shared Function GetName_TEHAI_ID(ByVal TEHAI_ID As String) As String
        Return TEHAI_ID
    End Function

    '会合名
    Public Shared Function GetName_KOUENKAI_NAME(ByVal KOUENKAI_NAME As String) As String
        Return KOUENKAI_NAME
    End Function

    '会合開催日From
    Public Shared Function GetName_FROM_DATE(ByVal FROM_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = True Then
            Return CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD)
        Else
            Dim wStr As String = ""
            wStr = CmnModule.Format_DateJP(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD), True)
            wStr = Replace(wStr, "月0", "月")
            wStr = Replace(wStr, "日0", "日")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        End If
    End Function

    '会合開催日To
    Public Shared Function GetName_TO_DATE(ByVal TO_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = True Then
            Return CmnModule.Format_Date(TO_DATE, CmnModule.DateFormatType.YYYYMD)
        Else
            Dim wStr As String = ""
            wStr = CmnModule.Format_DateJP(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD), True)
            wStr = Replace(wStr, "月0", "月")
            wStr = Replace(wStr, "日0", "日")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        End If
    End Function

    '会合開催日
    Public Shared Function GetName_KOUENKAI_DATE(ByVal FROM_DATE As String, ByVal TO_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wStr As String = ""
        If ShortFormat = True Then
            If Trim(FROM_DATE) = Trim(TO_DATE) OrElse Trim(TO_DATE) = "" Then
                wStr = CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD)
            Else
                wStr = CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD) & "〜" & CmnModule.Format_Date(TO_DATE, CmnModule.DateFormatType.YYYYMD)
            End If
        Else
            If Trim(FROM_DATE) = Trim(TO_DATE) OrElse Trim(TO_DATE) = "" Then
                wStr = CmnModule.Format_DateJP(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD) _
                     & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD), True)
                wStr = Replace(wStr, "月0", "月")
                wStr = Replace(wStr, "日0", "日")
                If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Else
                Dim wFROM_DATE As String = ""
                Dim wTO_DATE As String = ""
                wFROM_DATE = CmnModule.Format_DateJP(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD) _
                     & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(FROM_DATE), CmnModule.DateFormatType.YYYYMD), True)
                wStr = Replace(wStr, "月0", "月")
                wStr = Replace(wStr, "日0", "日")
                If Mid(wFROM_DATE, 1, 1) = "0" Then wFROM_DATE = Mid(wFROM_DATE, 2, 10)

                wTO_DATE = CmnModule.Format_DateJP(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD) _
                     & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(TO_DATE), CmnModule.DateFormatType.YYYYMD), True)
                wStr = Replace(wStr, "月0", "月")
                wStr = Replace(wStr, "日0", "日")
                If Mid(wTO_DATE, 1, 1) = "0" Then wTO_DATE = Mid(wTO_DATE, 2, 10)

                wStr = wFROM_DATE & "〜" & wTO_DATE
            End If
        End If
        Return wStr
    End Function

    'タクシーチケット印字名
    Public Shared Function GetName_TAXI_PRT_NAME(ByVal TAXI_PRT_NAME As String) As String
        Return TAXI_PRT_NAME
    End Function

    '会場名
    Public Shared Function GetName_KAIJO_NAME(ByVal KAIJO_NAME As String) As String
        Return KAIJO_NAME
    End Function

    '会合タイトル
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

    '実施予定日
    Public Shared Function GetName_YOTEI_DATE(ByVal YOTEI_DATE As String) As String
        Return CmnModule.Format_Date(YOTEI_DATE, CmnModule.DateFormatType.YYYYMD)
    End Function

    '開催日備考欄
    Public Shared Function GetName_KAISAI_DATE_NOTE(ByVal KAISAI_DATE_NOTE As String) As String
        Return KAISAI_DATE_NOTE
    End Function

    'Internal order（課税）
    Public Shared Function GetName_INTERNAL_ORDER_T(ByVal INTERNAL_ORDER_T As String) As String
        Return INTERNAL_ORDER_T
    End Function

    'Internal order（非課税）
    Public Shared Function GetName_INTERNAL_ORDER_TF(ByVal INTERNAL_ORDER_TF As String) As String
        Return INTERNAL_ORDER_TF
    End Function

    'アカウントコード（課税）
    Public Shared Function GetName_ACCOUNT_CD_T(ByVal ACCOUNT_CD_T As String) As String
        Return ACCOUNT_CD_T
    End Function

    'アカウントコード（非課税）
    Public Shared Function GetName_ACCOUNT_CD_TF(ByVal ACCOUNT_CD_TF As String) As String
        Return ACCOUNT_CD_TF
    End Function

    'zetia Code
    Public Shared Function GetName_ZETIA_CD(ByVal ZETIA_CD As String) As String
        Return ZETIA_CD
    End Function

    '会合名
    Public Shared Function GetName_MEETING_NAME(ByVal MEETING_NAME As String) As String
        Return MEETING_NAME
    End Function

    '製品名
    Public Shared Function GetName_SEIHIN_NAME(ByVal SEIHIN_NAME As String) As String
        Return SEIHIN_NAME
    End Function

    '承認時間
    Public Shared Function GetName_SHONIN_TIME(ByVal SHONIN_TIME As String) As String
        Return SHONIN_TIME
    End Function

    '承認者備考
    Public Shared Function GetName_SHONIN_NOTE(ByVal SHONIN_NOTE As String) As String
        Return SHONIN_NOTE
    End Function

    'TOP担当者
    Public Shared Function GetName_TTANTO_ID(ByVal TTANTO_ID As String) As String
        Return TTANTO_ID
    End Function
    Public Shared Function GetName_USER_NAME(ByVal USER_NAME As String) As String
        Return USER_NAME
    End Function

    '所属事業部
    Public Shared Function GetName_KIKAKU_TANTO_JIGYOBU(ByVal KIKAKU_TANTO_JIGYOBU As String) As String
        Return KIKAKU_TANTO_JIGYOBU
    End Function

    'BU
    Public Shared Function GetName_BU(ByVal BU As String) As String
        Return BU
    End Function

    '所属エリア
    Public Shared Function GetName_KIKAKU_TANTO_AREA(ByVal KIKAKU_TANTO_AREA As String) As String
        Return KIKAKU_TANTO_AREA
    End Function

    '所属営業所
    Public Shared Function GetName_KIKAKU_TANTO_EIGYOSHO(ByVal KIKAKU_TANTO_EIGYOSHO As String) As String
        Return KIKAKU_TANTO_EIGYOSHO
    End Function

    '担当者（企画担当者）No
    Public Shared Function GetName_KIKAKU_TANTO_NO(ByVal KIKAKU_TANTO_NO As String) As String
        Return KIKAKU_TANTO_NO
    End Function

    '担当者（企画担当者）名
    Public Shared Function GetName_KIKAKU_TANTO_NAME(ByVal KIKAKU_TANTO_NAME As String) As String
        Return KIKAKU_TANTO_NAME
    End Function

    '担当者（企画担当者）名（カタカナ）
    Public Shared Function GetName_KIKAKU_TANTO_KANA(ByVal KIKAKU_TANTO_KANA As String) As String
        Return KIKAKU_TANTO_KANA
    End Function

    '担当者（企画担当者）名（ローマ字）
    Public Shared Function GetName_KIKAKU_TANTO_ROMA(ByVal KIKAKU_TANTO_ROMA As String) As String
        Return KIKAKU_TANTO_ROMA
    End Function

    'Emailアドレス（企画担当者）
    Public Shared Function GetName_KIKAKU_TANTO_EMAIL(ByVal KIKAKU_TANTO_EMAIL As String) As String
        Return KIKAKU_TANTO_EMAIL
    End Function
    Public Shared Function GetName_KIKAKU_TANTO_EMAIL_PC(ByVal KIKAKU_TANTO_EMAIL_PC As String) As String
        Return KIKAKU_TANTO_EMAIL_PC
    End Function
    Public Shared Function GetName_KIKAKU_TANTO_EMAIL_KEITAI(ByVal KIKAKU_TANTO_EMAIL_KEITAI As String) As String
        Return KIKAKU_TANTO_EMAIL_KEITAI
    End Function

    '携帯電話番号
    Public Shared Function GetName_KIKAKU_TANTO_KEITAI(ByVal KIKAKU_TANTO_KEITAI As String) As String
        Return KIKAKU_TANTO_KEITAI
    End Function

    '電話番号
    Public Shared Function GetName_KIKAKU_TANTO_TEL(ByVal KIKAKU_TANTO_TEL As String) As String
        Return KIKAKU_TANTO_TEL
    End Function

    '所属事業部（手配担当者）
    Public Shared Function GetName_TEHAI_TANTO_JIGYOBU(ByVal TEHAI_TANTO_JIGYOBU As String) As String
        Return TEHAI_TANTO_JIGYOBU
    End Function

    '所属BU（手配担当者）
    Public Shared Function GetName_TEHAI_TANTO_BU(ByVal TEHAI_TANTO_BU As String) As String
        Return TEHAI_TANTO_BU
    End Function

    '所属エリア（手配担当者）
    Public Shared Function GetName_TEHAI_TANTO_AREA(ByVal TEHAI_TANTO_AREA As String) As String
        Return TEHAI_TANTO_AREA
    End Function

    '所属営業所（手配担当者）
    Public Shared Function GetName_TEHAI_TANTO_EIGYOSHO(ByVal TEHAI_TANTO_EIGYOSHO As String) As String
        Return TEHAI_TANTO_EIGYOSHO
    End Function

    '担当者（手配担当者）No
    Public Shared Function GetName_TEHAI_TANTO_NO(ByVal TEHAI_TANTO_NO As String) As String
        Return TEHAI_TANTO_NO
    End Function

    '担当者（手配担当者）名
    Public Shared Function GetName_TEHAI_TANTO_NAME(ByVal TEHAI_TANTO_NAME As String) As String
        Return TEHAI_TANTO_NAME
    End Function

    '担当者（手配担当者）名（カタカナ）
    Public Shared Function GetName_TEHAI_TANTO_KANA(ByVal TEHAI_TANTO_KANA As String) As String
        Return TEHAI_TANTO_KANA
    End Function

    '担当者（手配担当者）名（ローマ字）
    Public Shared Function GetName_TEHAI_TANTO_ROMA(ByVal TEHAI_TANTO_ROMA As String) As String
        Return TEHAI_TANTO_ROMA
    End Function

    'Emailアドレス（手配担当者）
    Public Shared Function GetName_TEHAI_TANTO_EMAIL(ByVal TEHAI_TANTO_EMAIL As String) As String
        Return TEHAI_TANTO_EMAIL
    End Function
    Public Shared Function GetName_TEHAI_TANTO_EMAIL_PC(ByVal TEHAI_TANTO_EMAIL_PC As String) As String
        Return TEHAI_TANTO_EMAIL_PC
    End Function
    Public Shared Function GetName_TEHAI_TANTO_EMAIL_KEITAI(ByVal TEHAI_TANTO_EMAIL_KEITAI As String) As String
        Return TEHAI_TANTO_EMAIL_KEITAI
    End Function

    '携帯電話番号
    Public Shared Function GetName_TEHAI_TANTO_KEITAI(ByVal TEHAI_TANTO_KEITAI As String) As String
        Return TEHAI_TANTO_KEITAI
    End Function

    '電話番号
    Public Shared Function GetName_TEHAI_TANTO_TEL(ByVal TEHAI_TANTO_TEL As String) As String
        Return TEHAI_TANTO_TEL
    End Function

    '参加予定数
    Public Shared Function GetName_SANKA_YOTEI_CNT(ByVal SANKA_YOTEI_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wSANKA_YOTEI_CNT As String = Trim(SANKA_YOTEI_CNT)
        If IsNumeric(wSANKA_YOTEI_CNT) Then
            wSANKA_YOTEI_CNT = CInt(wSANKA_YOTEI_CNT).ToString
        End If

        If ShortFormat = False Then
            Return CmnModule.EditComma(wSANKA_YOTEI_CNT)
        Else
            Return wSANKA_YOTEI_CNT
        End If
    End Function
    Public Shared Function GetName_SANKA_YOTEI_CNT_NMBR(ByVal SANKA_YOTEI_CNT_NMBR As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(SANKA_YOTEI_CNT_NMBR, ShortFormat)
    End Function
    Public Shared Function GetName_SANKA_YOTEI_CNT_MBR(ByVal SANKA_YOTEI_CNT_MBR As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(SANKA_YOTEI_CNT_MBR, ShortFormat)
    End Function

    '参加予定数　（医師・薬剤師）
    Public Shared Function GetName_SANKA_YOTEI_CNT_DR(ByVal SANKA_YOTEI_CNT_DR As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(SANKA_YOTEI_CNT_DR, ShortFormat)
    End Function

    '参加予定数　（その他）
    Public Shared Function GetName_SANKA_YOTEI_CNT_OTHER(ByVal SANKA_YOTEI_CNT_OTHER As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(SANKA_YOTEI_CNT_OTHER, ShortFormat)
    End Function

    '団体コード
    Public Shared Function GetName_DANTAI_CODE(ByVal DANTAI_CODE As String) As String
        Return DANTAI_CODE
    End Function

    'SRM発注区分
    Public Shared Function GetName_SRM_HACYU_KBN(ByVal SRM_HACYU_KBN As String) As String
        Select Case SRM_HACYU_KBN
            Case AppConst.KAIJO.SRM_HACYU_KBN.Code.Yes, AppConst.KAIJO.SRM_HACYU_KBN.Name.Yes
                Return AppConst.KAIJO.SRM_HACYU_KBN.Name.Yes
            Case AppConst.KAIJO.SRM_HACYU_KBN.Code.No, AppConst.KAIJO.SRM_HACYU_KBN.Name.No
                Return AppConst.KAIJO.SRM_HACYU_KBN.Name.No

            Case Else
                Return ""
        End Select
    End Function

    '見積額（非課税）
    Public Shared Function GetName_MITSUMORI_TF(ByVal MITSUMORI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(MITSUMORI_TF)
        Else
            Return MITSUMORI_TF
        End If
    End Function

    '見積額（課税）
    Public Shared Function GetName_MITSUMORI_T(ByVal MITSUMORI_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(MITSUMORI_T)
        Else
            Return MITSUMORI_T
        End If
    End Function

    '予算額(課税)
    Public Shared Function GetName_YOSAN_T(ByVal YOSAN_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(YOSAN_T)
        Else
            Return YOSAN_T
        End If
    End Function

    '予算額(非課税)
    Public Shared Function GetName_YOSAN_TF(ByVal YOSAN_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(YOSAN_TF)
        Else
            Return YOSAN_TF
        End If
    End Function

    '予算額合計
    Public Shared Function GetName_YOSAN_TOTAL(ByVal YOSAN_T As String, ByVal YOSAN_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(YOSAN_T) + CmnModule.DbVal(YOSAN_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function

    '慰労会予算(課税)
    Public Shared Function GetName_IROUKAI_YOSAN_T(ByVal IROUKAI_YOSAN_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(IROUKAI_YOSAN_T)
        Else
            Return IROUKAI_YOSAN_T
        End If
    End Function

    '意見交換会予算(課税)
    Public Shared Function GetName_IKENKOUKAN_YOSAN_T(ByVal IKENKOUKAN_YOSAN_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(IKENKOUKAN_YOSAN_T)
        Else
            Return IKENKOUKAN_YOSAN_T
        End If
    End Function

    '開催希望地　（都道府県）
    Public Shared Function GetName_KAISAI_KIBOU_ADDRESS1(ByVal KAISAI_KIBOU_ADDRESS1 As String) As String
        Return KAISAI_KIBOU_ADDRESS1
    End Function

    '開催希望地　（市町村）
    Public Shared Function GetName_KAISAI_KIBOU_ADDRESS2(ByVal KAISAI_KIBOU_ADDRESS2 As String) As String
        Return KAISAI_KIBOU_ADDRESS2
    End Function

    '開催希望　（フリーテキスト）
    Public Shared Function GetName_KAISAI_KIBOU_NOTE(ByVal KAISAI_KIBOU_NOTE As String) As String
        Return KAISAI_KIBOU_NOTE
    End Function

    '会合　開始時間
    Public Shared Function GetName_KOUEN_TIME1(ByVal KOUEN_TIME1 As String) As String
        Return KOUEN_TIME1
    End Function

    '会合　終了時間
    Public Shared Function GetName_KOUEN_TIME2(ByVal KOUEN_TIME2 As String) As String
        Return KOUEN_TIME2
    End Function

    '講演会場　要・不要
    Public Shared Function GetName_KOUEN_KAIJO_TEHAI(ByVal KOUEN_KAIJO_TEHAI As String, Optional ByVal ShortFomat As Boolean = False) As String
        Select Case KOUEN_KAIJO_TEHAI
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.Yes, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.ShortFormat.Yes
                If ShortFomat = False Then
                    Return AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.Yes
                Else
                    Return AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.ShortFormat.Yes
                End If
                If ShortFomat = False Then
                    Return AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.No
                Else
                    Return AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.ShortFormat.No
                End If

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_KOUEN_KAIJO_TEHAI_Yes(ByVal KOUEN_KAIJO_TEHAI As String) As String
        Select Case KOUEN_KAIJO_TEHAI
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.Yes, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.Yes
                Return "●"
            Case Else
                Return "○"
        End Select
    End Function
    Public Shared Function GetName_KOUEN_KAIJO_TEHAI_No(ByVal KOUEN_KAIJO_TEHAI As String) As String
        Select Case KOUEN_KAIJO_TEHAI
            Case AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Code.No, AppConst.KAIJO.KOUEN_KAIJO_TEHAI.Name.No
                Return "●"
            Case Else
                Return "○"
        End Select
    End Function

    '講演会場　レイアウト
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

    '意見交換会場　要・不要
    Public Shared Function GetName_IKENKOUKAN_KAIJO_TEHAI(ByVal IKENKOUKAN_KAIJO_TEHAI As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_KOUEN_KAIJO_TEHAI(IKENKOUKAN_KAIJO_TEHAI, ShortFormat)
    End Function
    Public Shared Function GetName_IKENKOUKAN_KAIJO_TEHAI_Yes(ByVal IKENKOUKAN_KAIJO_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_Yes(IKENKOUKAN_KAIJO_TEHAI)
    End Function
    Public Shared Function GetName_IKENKOUKAN_KAIJO_TEHAI_No(ByVal IKENKOUKAN_KAIJO_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_No(IKENKOUKAN_KAIJO_TEHAI)
    End Function

    '意見交換会　開始時間
    Public Shared Function GetName_IKENKOUKAN_TIME1(ByVal IKENKOUKAN_TIME1 As String) As String
        Return IKENKOUKAN_TIME1
    End Function

    '意見交換会　終了時間
    Public Shared Function GetName_IKENKOUKAN_TIME2(ByVal IKENKOUKAN_TIME2 As String) As String
        Return IKENKOUKAN_TIME2
    End Function

    '講師控室　要・不要
    Public Shared Function GetName_KOUSHI_ROOM_TEHAI(ByVal KOUSHI_ROOM_TEHAI As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_KOUEN_KAIJO_TEHAI(KOUSHI_ROOM_TEHAI, ShortFormat)
    End Function
    Public Shared Function GetName_KOUSHI_ROOM_TEHAI_Yes(ByVal KOUSHI_ROOM_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_Yes(KOUSHI_ROOM_TEHAI)
    End Function
    Public Shared Function GetName_KOUSHI_ROOM_TEHAI_No(ByVal KOUSHI_ROOM_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_No(KOUSHI_ROOM_TEHAI)
    End Function

    '講師控室　開始時間
    Public Shared Function GetName_KOUSHI_ROOM_TIME1(ByVal KOUSHI_ROOM_TIME1 As String) As String
        Return KOUSHI_ROOM_TIME1
    End Function
    Public Shared Function GetName_KOUSHI_ROOM_FROM(ByVal KOUSHI_ROOM_FROM As String) As String
        Return KOUSHI_ROOM_FROM
    End Function

    '講師控室　終了時間
    Public Shared Function GetName_KOUSHI_ROOM_TIME2(ByVal KOUSHI_ROOM_TIME2 As String) As String
        Return KOUSHI_ROOM_TIME2
    End Function

    '講師控室　人数
    Public Shared Function GetName_KOUSHI_ROOM_CNT(ByVal KOUSHI_ROOM_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(KOUSHI_ROOM_CNT, ShortFormat)
    End Function

    '社員控室　要・不要
    Public Shared Function GetName_SHAIN_ROOM_TEHAI(ByVal SHAIN_ROOM_TEHAI As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_KOUEN_KAIJO_TEHAI(SHAIN_ROOM_TEHAI, ShortFormat)
    End Function
    Public Shared Function GetName_SHAIN_ROOM_TEHAI_Yes(ByVal SHAIN_ROOM_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_Yes(SHAIN_ROOM_TEHAI)
    End Function
    Public Shared Function GetName_SHAIN_ROOM_TEHAI_No(ByVal SHAIN_ROOM_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_No(SHAIN_ROOM_TEHAI)
    End Function

    '社員控室 人数
    Public Shared Function GetName_SHAIN_ROOM_CNT(ByVal SHAIN_ROOM_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(SHAIN_ROOM_CNT, ShortFormat)
    End Function

    '世話人会場　要・不要
    Public Shared Function GetName_MANAGER_KAIJO_TEHAI(ByVal MANAGER_KAIJO_TEHAI As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_KOUEN_KAIJO_TEHAI(MANAGER_KAIJO_TEHAI, ShortFormat)
    End Function
    Public Shared Function GetName_MANAGER_KAIJO_TEHAI_Yes(ByVal MANAGER_KAIJO_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_Yes(MANAGER_KAIJO_TEHAI)
    End Function
    Public Shared Function GetName_MANAGER_KAIJO_TEHAI_No(ByVal MANAGER_KAIJO_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_No(MANAGER_KAIJO_TEHAI)
    End Function

    '世話人会場　開始時間
    Public Shared Function GetName_MANAGER_ROOM_FROM(ByVal MANAGER_ROOM_FROM As String) As String
        Return MANAGER_ROOM_FROM
    End Function

    '世話人控室 人数
    Public Shared Function GetName_MANAGER_ROOM_CNT(ByVal MANAGER_ROOM_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(MANAGER_ROOM_CNT, ShortFormat)
    End Function

    '世話人会場　開始時間
    Public Shared Function GetName_MANAGER_KAIJO_TIME1(ByVal MANAGER_KAIJO_TIME1 As String) As String
        Return MANAGER_KAIJO_TIME1
    End Function

    '世話人会場　終了時間
    Public Shared Function GetName_MANAGER_KAIJO_TIME2(ByVal MANAGER_KAIJO_TIME2 As String) As String
        Return MANAGER_KAIJO_TIME2
    End Function

    '慰労会会場　要・不要
    Public Shared Function GetName_IROUKAI_KAIJO_TEHAI(ByVal IROUKAI_KAIJO_TEHAI As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_KOUEN_KAIJO_TEHAI(IROUKAI_KAIJO_TEHAI, ShortFormat)
    End Function
    Public Shared Function GetName_IROUKAI_KAIJO_TEHAI_Yes(ByVal IROUKAI_KAIJO_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_Yes(IROUKAI_KAIJO_TEHAI)
    End Function
    Public Shared Function GetName_IROUKAI_KAIJO_TEHAI_No(ByVal IROUKAI_KAIJO_TEHAI As String) As String
        Return GetName_KOUEN_KAIJO_TEHAI_No(IROUKAI_KAIJO_TEHAI)
    End Function

    '慰労会参加予定者数
    Public Shared Function GetName_IROUKAI_SANKA_YOTEI_CNT(ByVal IROUKAI_SANKA_YOTEI_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(IROUKAI_SANKA_YOTEI_CNT, ShortFormat)
    End Function

    '利用額計
    Public Shared Function GetName_FIX_TOTAL(ByVal FIX_SEISAN_TF As String, ByVal FIX_SEISAN_GTAX As String, ByVal FIX_SEISAN_NTAX As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(FIX_SEISAN_TF) + CmnModule.DbVal(FIX_SEISAN_GTAX) + CmnModule.DbVal(FIX_SEISAN_NTAX)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function

    '日From〜To
    Public Shared Function GetName_DATE_FROM_TO(ByVal DATE_FROM As String, ByVal DATE_TO As String) As String
        Dim wStr As String = ""
        Dim wFrom As String = CmnModule.Format_Date(DATE_FROM, CmnModule.DateFormatType.YYYYMMDD)
        If IsDate(wFrom) Then
            wStr &= wFrom
        End If
        Dim wTo As String = CmnModule.Format_Date(DATE_TO, CmnModule.DateFormatType.YYYYMMDD)
        If IsDate(wTo) Then
            If wFrom <> wTo Then
                If Trim(wStr) <> "" Then wStr &= "〜"
                wStr &= wTo
            End If
        End If
        Return wStr
    End Function

    '(依頼)宿泊希望者数
    Public Shared Function GetName_REQ_ROOM_CNT(ByVal REQ_ROOM_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(REQ_ROOM_CNT)
    End Function

    '(依頼)宿泊希望日
    Public Shared Function GetName_REQ_STAY_DATE(ByVal REQ_STAY_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = True Then
            Return CmnModule.Format_Date(REQ_STAY_DATE, CmnModule.DateFormatType.YYYYMD)
        Else
            Dim wStr As String = ""
            wStr = CmnModule.Format_DateJP(Trim(REQ_STAY_DATE), CmnModule.DateFormatType.YYYYMD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(REQ_STAY_DATE), CmnModule.DateFormatType.YYYYMD), True)
            wStr = Replace(wStr, "月0", "月")
            wStr = Replace(wStr, "日0", "日")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        End If
    End Function

    '(依頼)交通手配予定人数(JR/AIR) 
    Public Shared Function GetName_REQ_KOTSU_CNT(ByVal REQ_KOTSU_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(REQ_KOTSU_CNT)
    End Function

    '(依頼)タクシー手配予定人数
    Public Shared Function GetName_REQ_TAXI_CNT(ByVal REQ_TAXI_CNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SANKA_YOTEI_CNT(REQ_TAXI_CNT)
    End Function

    'その他備考欄
    Public Shared Function GetName_OTHER_NOTE(ByVal OTHER_NOTE As String) As String
        Return OTHER_NOTE
    End Function

    '見積額（非課税）
    Public Shared Function GetName_ANS_MITSUMORI_TF(ByVal ANS_MITSUMORI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_MITSUMORI_TF)
        Else
            Return ANS_MITSUMORI_TF
        End If
    End Function

    '見積額（課税）
    Public Shared Function GetName_ANS_MITSUMORI_T(ByVal ANS_MITSUMORI_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_MITSUMORI_T)
        Else
            Return ANS_MITSUMORI_T
        End If
    End Function

    '見積額合計
    Public Shared Function GetName_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_MITSUMORI_TOTAL)
        Else
            Return CmnModule.DbVal(ANS_MITSUMORI_TOTAL).ToString
        End If
    End Function
    'Public Shared Function GetName_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_T As String, ByVal ANS_MITSUMORI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Dim wTOTAL As Long = 0
    '    wTOTAL = CmnModule.DbVal(ANS_MITSUMORI_T) + CmnModule.DbVal(ANS_MITSUMORI_TF)
    '    If ShortFormat = False Then
    '        Return CmnModule.EditComma(wTOTAL)
    '    Else
    '        Return wTOTAL.ToString
    '    End If
    'End Function

    '見積額合計関連
    Public Shared Function GetName_ANS_991330401_TF(ByVal ANS_KAIJOUHI_TF As String, ByVal ANS_KIZAIHI_TF As String, ByVal ANS_INSHOKUHI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_KAIJOUHI_TF) + CmnModule.DbVal(ANS_KIZAIHI_TF) + CmnModule.DbVal(ANS_INSHOKUHI_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_991330401_T(ByVal ANS_KAIJOUHI_T As String, ByVal ANS_KIZAIHI_T As String, ByVal ANS_INSHOKUHI_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_KAIJOUHI_T) + CmnModule.DbVal(ANS_KIZAIHI_T) + CmnModule.DbVal(ANS_INSHOKUHI_T)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_41120200_TF(ByVal ANS_HOTELHI_TF As String, ByVal ANS_KOTSUHI_TF As String, ByVal ANS_TAXI_TF As String, ByVal ANS_TEHAI_TESURYO_TF As String, ByVal ANS_TAXI_HAKKEN_TESURYO_TF As String, ByVal ANS_TAXI_SEISAN_TESURYO_TF As String, ByVal ANS_JINKENHI_TF As String, ByVal ANS_OTHER_TF As String, ByVal ANS_KANRIHI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_HOTELHI_TF) + CmnModule.DbVal(ANS_KOTSUHI_TF) + CmnModule.DbVal(ANS_TAXI_TF) + CmnModule.DbVal(ANS_TEHAI_TESURYO_TF) + CmnModule.DbVal(ANS_TAXI_HAKKEN_TESURYO_TF) + CmnModule.DbVal(ANS_TAXI_SEISAN_TESURYO_TF) + CmnModule.DbVal(ANS_JINKENHI_TF) + CmnModule.DbVal(ANS_OTHER_TF) + CmnModule.DbVal(ANS_KANRIHI_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_41120200_TF(ByVal ANS_HOTELHI_TF As String, ByVal ANS_KOTSUHI_JR_TF As String, ByVal ANS_KOTSUHI_AIR_TF As String, ByVal ANS_KOTSUHI_OTHER_TF As String, ByVal ANS_TAXI_TF As String, ByVal ANS_TEHAI_TESURYO_TF As String, ByVal ANS_TAXI_HAKKEN_TESURYO_TF As String, ByVal ANS_TAXI_SEISAN_TESURYO_TF As String, ByVal ANS_JINKENHI_TF As String, ByVal ANS_OTHER_TF As String, ByVal ANS_KANRIHI_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_HOTELHI_TF) + CmnModule.DbVal(ANS_KOTSUHI_JR_TF) + CmnModule.DbVal(ANS_KOTSUHI_AIR_TF) + CmnModule.DbVal(ANS_KOTSUHI_OTHER_TF) + CmnModule.DbVal(ANS_TAXI_TF) + CmnModule.DbVal(ANS_TEHAI_TESURYO_TF) + CmnModule.DbVal(ANS_TAXI_HAKKEN_TESURYO_TF) + CmnModule.DbVal(ANS_TAXI_SEISAN_TESURYO_TF) + CmnModule.DbVal(ANS_JINKENHI_TF) + CmnModule.DbVal(ANS_OTHER_TF) + CmnModule.DbVal(ANS_KANRIHI_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_41120200_T(ByVal ANS_JINKENHI_T As String, ByVal ANS_OTHER_T As String, ByVal ANS_KANRIHI_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_JINKENHI_T) + CmnModule.DbVal(ANS_OTHER_T) + CmnModule.DbVal(ANS_KANRIHI_T)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_TOTAL_TF(ByVal ANS_KAIJOUHI_TF As String, _
                                                ByVal ANS_KIZAIHI_TF As String, _
                                                ByVal ANS_INSHOKUHI_TF As String, _
                                                ByVal ANS_HOTELHI_TF As String, _
                                                ByVal ANS_KOTSUHI_TF As String, _
                                                ByVal ANS_TAXI_TF As String, _
                                                ByVal ANS_TEHAI_TESURYO_TF As String, _
                                                ByVal ANS_TAXI_HAKKEN_TESURYO_TF As String, _
                                                ByVal ANS_TAXI_SEISAN_TESURYO_TF As String, _
                                                ByVal ANS_JINKENHI_TF As String, _
                                                ByVal ANS_OTHER_TF As String, _
                                                ByVal ANS_KANRIHI_TF As String, _
                                                Optional ByVal ShortFormat As Boolean = False) As String
        Dim wANS_TOTAL_TF As Long = 0
        wANS_TOTAL_TF = CmnModule.DbVal(ANS_KAIJOUHI_TF) + CmnModule.DbVal(ANS_KIZAIHI_TF) + CmnModule.DbVal(ANS_INSHOKUHI_TF) + CmnModule.DbVal(ANS_HOTELHI_TF) + CmnModule.DbVal(ANS_KOTSUHI_TF) + CmnModule.DbVal(ANS_TAXI_TF) + CmnModule.DbVal(ANS_TEHAI_TESURYO_TF) + CmnModule.DbVal(ANS_TAXI_HAKKEN_TESURYO_TF) + CmnModule.DbVal(ANS_TAXI_SEISAN_TESURYO_TF) + CmnModule.DbVal(ANS_JINKENHI_TF) + CmnModule.DbVal(ANS_OTHER_TF) + CmnModule.DbVal(ANS_KANRIHI_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wANS_TOTAL_TF)
        Else
            Return wANS_TOTAL_TF.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_TOTAL_TF(ByVal ANS_991330401_TF As String, ByVal ANS_41120200_TF As String,Optional ByVal ShortFormat As Boolean = False) As String
        Dim wANS_TOTAL_TF As Long = 0
        wANS_TOTAL_TF = CmnModule.DbVal(ANS_991330401_TF) + CmnModule.DbVal(ANS_41120200_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wANS_TOTAL_TF)
        Else
            Return wANS_TOTAL_TF.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_TOTAL_T(ByVal ANS_KAIJOUHI_T As String, _
                                                ByVal ANS_KIZAIHI_T As String, _
                                                ByVal ANS_INSHOKUHI_T As String, _
                                                ByVal ANS_JINKENHI_T As String, _
                                                ByVal ANS_OTHER_T As String, _
                                                ByVal ANS_KANRIHI_T As String, _
                                                Optional ByVal ShortFormat As Boolean = False) As String
        Dim wANS_TOTAL_T As Long = 0
        wANS_TOTAL_T = CmnModule.DbVal(ANS_KAIJOUHI_T) + CmnModule.DbVal(ANS_KIZAIHI_T) + CmnModule.DbVal(ANS_INSHOKUHI_T) + CmnModule.DbVal(ANS_JINKENHI_T) + CmnModule.DbVal(ANS_OTHER_T) + CmnModule.DbVal(ANS_KANRIHI_T)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wANS_TOTAL_T)
        Else
            Return wANS_TOTAL_T.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_TOTAL_T(ByVal ANS_991330401_T As String, ByVal ANS_41120200_T As String,  Optional ByVal ShortFormat As Boolean = False) As String
        Dim wANS_TOTAL_T As Long = 0
        wANS_TOTAL_T = CmnModule.DbVal(ANS_991330401_T) + CmnModule.DbVal(ANS_41120200_T)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wANS_TOTAL_T)
        Else
            Return wANS_TOTAL_T.ToString
        End If
    End Function
    Public Shared Function GetName_ANS_991330401_TF(ByVal ANS_991330401_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_991330401_TF)
        Else
            Return CmnModule.DbVal(ANS_991330401_TF).ToString
        End If
    End Function
    Public Shared Function GetName_ANS_41120200_TF(ByVal ANS_41120200_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_41120200_TF)
        Else
            Return CmnModule.DbVal(ANS_41120200_TF).ToString
        End If
    End Function
    Public Shared Function GetName_ANS_TOTAL_TF(ByVal ANS_TOTAL_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_TOTAL_TF)
        Else
            Return CmnModule.DbVal(ANS_TOTAL_TF).ToString
        End If
    End Function
    Public Shared Function GetName_ANS_991330401_T(ByVal ANS_991330401_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_991330401_T)
        Else
            Return CmnModule.DbVal(ANS_991330401_T).ToString
        End If
    End Function
    Public Shared Function GetName_ANS_41120200_T(ByVal ANS_41120200_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_41120200_T)
        Else
            Return CmnModule.DbVal(ANS_41120200_T).ToString
        End If
    End Function
    Public Shared Function GetName_ANS_TOTAL_T(ByVal ANS_TOTAL_T As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_TOTAL_T)
        Else
            Return CmnModule.DbVal(ANS_TOTAL_T).ToString
        End If
    End Function

    '精算額合計
    Public Shared Function GetName_ANS_SEISAN_TOTAL(ByVal ANS_SEISAN_TOTAL As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Return CmnModule.EditComma(ANS_SEISAN_TOTAL)
        Else
            Return ANS_SEISAN_TOTAL
        End If
    End Function
    Public Shared Function GetName_ANS_SEISAN_TOTAL(ByVal ANS_SEISAN_T As String, ByVal ANS_SEISAN_TF As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(ANS_SEISAN_T) + CmnModule.DbVal(ANS_SEISAN_TF)
        If ShortFormat = False Then
            Return CmnModule.EditComma(wTOTAL)
        Else
            Return wTOTAL.ToString
        End If
    End Function

    '【回答】施設選定理由
    Public Shared Function GetName_ANS_SENTEI_RIYU(ByVal ANS_SENTEI_RIYU As String) As String
        Return Trim(ANS_SENTEI_RIYU)
    End Function

    '【回答】 開催地 (施設郵便番号)
    Public Shared Function GetName_ANS_SHISETSU_ZIP(ByVal ANS_SHISETSU_ZIP As String) As String
        Return Trim(ANS_SHISETSU_ZIP)
    End Function
#End Region

#Region "交通・宿泊手配画面"
    '手配ステータス
    Public Shared Function GetName_STATUS_TEHAI(ByVal STATUS_TEHAI As String, Optional ByVal KAIJO As Boolean = False, Optional ByVal ShortName As Boolean = False) As String
        If KAIJO = False Then
            '宿泊・交通
            Select Case STATUS_TEHAI
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.Tehai
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                    End If

                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.Change
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                    End If

                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.Cancel
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel
                    End If

                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Fuka, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Fuka
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Fuka

                Case Else
                    Return ""
            End Select
        Else
            '会場
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
    '緊急フラグ
    Public Shared Function GetName_KINKYU_FLAG(ByVal KINKYU_FLAG As String) As String
        If KINKYU_FLAG = AppConst.KOTSUHOTEL.KINKYU_FLAG.Code.Yes Then
            Return AppConst.KOTSUHOTEL.KINKYU_FLAG.Name.Yes
        Else
            Return AppConst.KOTSUHOTEL.KINKYU_FLAG.Name.No
        End If
    End Function
    Public Shared Function GetMark_KINKYU_FLAG(ByVal KINKYU_FLAG As String) As String
        If KINKYU_FLAG = AppConst.KOTSUHOTEL.KINKYU_FLAG.Code.Yes Then
            Return AppConst.KOTSUHOTEL.KINKYU_FLAG.Mark.Yes
        Else
            Return AppConst.KOTSUHOTEL.KINKYU_FLAG.Mark.No
        End If
    End Function

    '【依頼】手配ステータス
    Public Shared Function GetName_REQ_STATUS_TEHAI(ByVal REQ_STATUS_TEHAI As String, Optional ByVal KAIJO As Boolean = False, Optional ByVal ShortName As Boolean = False) As String
        If KAIJO = False Then
            Select Case REQ_STATUS_TEHAI
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.Tehai
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai
                    End If
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.Change
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change
                    End If
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.Cancel
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel
                    End If
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Jigo, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.After
                    If ShortName Then
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.ShortName.After
                    Else
                        Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.After
                    End If

                Case Else
                    Return ""
            End Select
        Else
            Select Case REQ_STATUS_TEHAI
                Case AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Mitsumori, AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Mitsumori
                    Return AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Mitsumori
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

    '【回答】手配ステータス
    Public Shared Function GetName_ANS_STATUS_TEHAI(ByVal ANS_STATUS_TEHAI As String, Optional ByVal KAIJO As Boolean = False) As String
        If KAIJO = False Then
            Select Case ANS_STATUS_TEHAI
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NewTehai
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.NewTehai
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled
                Case AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Fuka
                    Return AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Fuka
                Case Else
                    Return ""
            End Select
        Else
            Select Case ANS_STATUS_TEHAI
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.NewTehai
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.NewTehai
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoSearch, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoSearch
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoSearch
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.UchiawaseSeisanUketsuke, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.UchiawaseSeisanUketsuke
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.UchiawaseSeisanUketsuke
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanUketsuke, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanUketsuke
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanUketsuke
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.TehaiFuka, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.TehaiFuka
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.TehaiFuka
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.ShoninIrai, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ShoninIrai
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ShoninIrai
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoKettei, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoKettei
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoKettei
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanIrai, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanIrai
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanIrai
                'Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanZumi, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanZumi
                '    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanZumi
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.NewTehai
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.NewTehai
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoSearch, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoSearch
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoSearch
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.ShoninIrai, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ShoninIrai
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ShoninIrai
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoKettei, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoKettei
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoKettei
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.Cancel, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Cancel
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Cancel
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.ToriatsukaiFuka, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ToriatsukaiFuka
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ToriatsukaiFuka
                Case AppConst.KAIJO.ANS_STATUS_TEHAI.Code.AkiNashi, AppConst.KAIJO.ANS_STATUS_TEHAI.Name.AkiNashi
                    Return AppConst.KAIJO.ANS_STATUS_TEHAI.Name.AkiNashi

                Case Else
                    Return ""
            End Select
        End If
    End Function

    'DR性別
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

    '参加者役割
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

    '参加／不参加
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

    'MR BU
    Public Shared Function GetName_MR_BU(ByVal MR_BU As String) As String
        Return MR_BU
    End Function

    'MR エリア
    Public Shared Function GetName_MR_AREA(ByVal MR_AREA As String) As String
        Return MR_AREA
    End Function

    'MR 営業所
    Public Shared Function GetName_MR_EIGYOSHO(ByVal MR_EIGYOSHO As String) As String
        Return MR_EIGYOSHO
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

    'MR 氏名
    Public Shared Function GetName_MR_NAME(ByVal MR_NAME As String) As String
        Return MR_NAME
    End Function

    'MR 氏名（ローマ字）
    Public Shared Function GetName_MR_ROMA(ByVal MR_ROMA As String) As String
        Return MR_ROMA
    End Function

    'MR 氏名（カナ）
    Public Shared Function GetName_MR_KANA(ByVal MR_KANA As String) As String
        Return MR_KANA
    End Function

    'MR 携帯電話番号
    Public Shared Function GetName_MR_KEITAI(ByVal MR_KEITAI As String) As String
        Return MR_KEITAI
    End Function

    'MR オフィスの電話番号
    Public Shared Function GetName_MR_TEL(ByVal MR_TEL As String) As String
        Return MR_TEL
    End Function

    'MR 携帯Emailアドレス
    Public Shared Function GetName_MR_EMAIL_KEITAI(ByVal MR_EMAIL_KEITAI As String) As String
        Return MR_EMAIL_KEITAI
    End Function

    'MR Emailアドレス
    Public Shared Function GetName_MR_EMAIL_PC(ByVal MR_EMAIL_PC As String) As String
        Return MR_EMAIL_PC
    End Function

    'チケット送付先FS名
    Public Shared Function GetName_MR_SEND_SAKI_FS(ByVal MR_SEND_SAKI_FS As String) As String
        Return MR_SEND_SAKI_FS
    End Function

    'チケットその他送付先
    Public Shared Function GetName_MR_SEND_SAKI_OTHER(ByVal MR_SEND_SAKI_OTHER As String) As String
        Return MR_SEND_SAKI_OTHER
    End Function

    'DR MPID
    Public Shared Function GetName_DR_MPID(ByVal DR_MPID As String) As String
        Return DR_MPID
    End Function

    'DR CD
    Public Shared Function GetName_DR_CD(ByVal DR_CD As String) As String
        Return DR_CD
    End Function

    'DR 氏名
    Public Shared Function GetName_DR_NAME(ByVal DR_NAME As String) As String
        Return DR_NAME
    End Function

    'DR 氏名（カナ）
    Public Shared Function GetName_DR_KANA(ByVal DR_KANA As String) As String
        Return DR_KANA
    End Function

    'DCF施設コード
    Public Shared Function GetName_DR_SHISETSU_CD(ByVal DR_SHISETSU_CD As String) As String
        Return DR_SHISETSU_CD
    End Function

    '施設名
    Public Shared Function GetName_DR_SHISETSU_NAME(ByVal DR_SHISETSU_NAME As String) As String
        Return DR_SHISETSU_NAME
    End Function

    '施設住所
    Public Shared Function GetName_DR_SHISETSU_ADDRESS(ByVal DR_SHISETSU_ADDRESS As String) As String
        Return DR_SHISETSU_ADDRESS
    End Function

    'DR年齢
    Public Shared Function GetName_DR_AGE(ByVal DR_AGE As String) As String
        Return DR_AGE
    End Function

    '指定外申請理由
    Public Shared Function GetName_SHITEIGAI_RIYU(ByVal SHITEIGAI_RIYU As String) As String
        Return SHITEIGAI_RIYU
    End Function


    '承認者（氏名）
    Public Shared Function GetName_SHONIN_NAME(ByVal SHONIN_NAME As String) As String
        Return SHONIN_NAME
    End Function

    '承認日時
    Public Shared Function GetName_SHONIN_DATE(ByVal SHONIN_DATE As String) As String
        Return CmnModule.Format_Date(SHONIN_DATE, CmnModule.DateFormatType.YYYYMD)
    End Function

    'CM承認者（氏名）
    Public Shared Function GetName_CMSHONIN_NAME(ByVal CMSHONIN_NAME As String) As String
        Return CMSHONIN_NAME
    End Function

    'CM承認日時
    Public Shared Function GetName_CMSHONIN_DATE(ByVal CMSHONIN_DATE As String) As String
        Return CmnModule.Format_Date(CMSHONIN_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    'CM承認者備考
    Public Shared Function GetName_CMSHONIN_NOTE(ByVal CMSHONIN_NOTE As String) As String
        Return CMSHONIN_NOTE
    End Function

    '宿泊手配
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

    '宿泊手配
    Public Shared Function GetMark_TEHAI_HOTEL(ByVal TEHAI_HOTEL As String) As String
        Select Case TEHAI_HOTEL
            Case AppConst.KOTSUHOTEL.TEHAI_HOTEL.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.Yes
                Return AppConst.KOTSUHOTEL.TEHAI_HOTEL.Mark.Yes
                'Case AppConst.KOTSUHOTEL.TEHAI_HOTEL.Code.No, AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.No
            Case Else
                Return AppConst.KOTSUHOTEL.TEHAI_HOTEL.Mark.No

        End Select
    End Function

    '宿泊依頼内容
    Public Shared Function GetName_HOTEL_IRAINAIYOU(ByVal HOTEL_IRAINAIYOU As String) As String
        Select Case HOTEL_IRAINAIYOU
            Case AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Code.Tehai, AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Tehai
                Return AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Tehai
            Case AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Code.Change, AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Change
                Return AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Change
            Case AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Code.Cancel, AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Cancel
                Return AppConst.KOTSUHOTEL.HOTEL_IRAINAIYOU.Name.Cancel
            Case ""
                Return "未指定"

            Case Else
                Return ""
        End Select
    End Function

    '宿泊日（依頼）
    Public Shared Function GetName_REQ_HOTEL_DATE(ByVal REQ_HOTEL_DATE As String) As String
        Return CmnModule.Format_Date(REQ_HOTEL_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '泊数（依頼）
    Public Shared Function GetName_REQ_HAKUSU(ByVal REQ_HAKUSU As String) As String
        Return REQ_HAKUSU
    End Function

    '宿泊ホテル喫煙（依頼）
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

    '宿泊備考（依頼）
    Public Shared Function GetName_REQ_HOTEL_NOTE(ByVal REQ_HOTEL_NOTE As String) As String
        Return REQ_HOTEL_NOTE
    End Function

    '宿泊ステータス（回答）
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

    '宿泊部屋タイプ（回答）
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

    '宿泊ホテル喫煙（回答）
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

    '往路：交通手配
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

    '往路：交通手配
    Public Shared Function GetMark_REQ_O_TEHAI(ByVal REQ_O_TEHAI As String) As String
        Select Case REQ_O_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes, AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.Yes
                Return AppConst.KOTSUHOTEL.REQ_O_TEHAI.Mark.Yes
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No, AppConst.KOTSUHOTEL.REQ_O_TEHAI.Name.No
                Return AppConst.KOTSUHOTEL.REQ_O_TEHAI.Mark.No

            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetMark_REQ_O_TEHAI_1(ByVal REQ_O_TEHAI_1 As String) As String
        Return GetMark_REQ_O_TEHAI(REQ_O_TEHAI_1)
    End Function
    Public Shared Function GetMark_REQ_O_TEHAI_2(ByVal REQ_O_TEHAI_2 As String) As String
        Return GetMark_REQ_O_TEHAI(REQ_O_TEHAI_2)
    End Function
    Public Shared Function GetMark_REQ_O_TEHAI_3(ByVal REQ_O_TEHAI_3 As String) As String
        Return GetMark_REQ_O_TEHAI(REQ_O_TEHAI_3)
    End Function
    Public Shared Function GetMark_REQ_O_TEHAI_4(ByVal REQ_O_TEHAI_4 As String) As String
        Return GetMark_REQ_O_TEHAI(REQ_O_TEHAI_4)
    End Function
    Public Shared Function GetMark_REQ_O_TEHAI_5(ByVal REQ_O_TEHAI_5 As String) As String
        Return GetMark_REQ_O_TEHAI(REQ_O_TEHAI_5)
    End Function

    'MR手配
    Public Shared Function GetMark_REQ_MR_TEHAI(ByVal REQ_MR_TEHAI As String) As String
        Select Case REQ_MR_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes
                Return AppConst.KOTSUHOTEL.REQ_O_TEHAI.Mark.Yes
            Case AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No
                Return AppConst.KOTSUHOTEL.REQ_O_TEHAI.Mark.No

            Case Else
                Return ""
        End Select
    End Function

    '往路：交通依頼内容
    Public Shared Function GetName_REQ_O_IRAINAIYOU(ByVal REQ_O_IRAINAIYOU As String) As String
        Select Case REQ_O_IRAINAIYOU
            Case AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Code.Tehai, AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Tehai
                Return AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Tehai
            Case AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Code.Change, AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Change
                Return AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Change
            Case AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Code.Cancel, AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Cancel
                Return AppConst.KOTSUHOTEL.REQ_O_IRAINAIYOU.Name.Cancel
            Case ""
                Return "未指定"
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

    '復路・交通手配
    Public Shared Function GetMark_REQ_F_TEHAI(ByVal REQ_F_TEHAI As String) As String
        Select Case REQ_F_TEHAI
            Case AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes, AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.Yes
                Return AppConst.KOTSUHOTEL.REQ_F_TEHAI.Mark.Yes
            Case AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.No, AppConst.KOTSUHOTEL.REQ_F_TEHAI.Name.No
                Return AppConst.KOTSUHOTEL.REQ_F_TEHAI.Mark.No
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetMark_REQ_F_TEHAI_1(ByVal REQ_F_TEHAI_1 As String) As String
        Return GetMark_REQ_F_TEHAI(REQ_F_TEHAI_1)
    End Function
    Public Shared Function GetMark_REQ_F_TEHAI_2(ByVal REQ_F_TEHAI_2 As String) As String
        Return GetMark_REQ_F_TEHAI(REQ_F_TEHAI_2)
    End Function
    Public Shared Function GetMark_REQ_F_TEHAI_3(ByVal REQ_F_TEHAI_3 As String) As String
        Return GetMark_REQ_F_TEHAI(REQ_F_TEHAI_3)
    End Function
    Public Shared Function GetMark_REQ_F_TEHAI_4(ByVal REQ_F_TEHAI_4 As String) As String
        Return GetMark_REQ_F_TEHAI(REQ_F_TEHAI_4)
    End Function
    Public Shared Function GetMark_REQ_F_TEHAI_5(ByVal REQ_F_TEHAI_5 As String) As String
        Return GetMark_REQ_F_TEHAI(REQ_F_TEHAI_5)
    End Function

    '往路：交通機関
    Public Shared Function GetName_REQ_O_KOTSUKIKAN(ByVal REQ_O_KOTSUKIKAN As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_O_KOTSUKIKAN.Trim Then
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

    '往路：列車名・便名（依頼）
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

    '往路：座席区分
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

    '往路：座席希望
    Public Shared Function GetName_REQ_O_SEAT_KIBOU(ByVal REQ_O_SEAT_KIBOU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_SEAT_KIBOU AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_O_SEAT_KIBOU Then
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

    '往路：航空搭乗者年齢（年齢）
    Public Shared Function GetName_REQ_O_AGE(ByVal REQ_O_AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(REQ_O_AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = True Then
                Return Trim(REQ_O_AGE)
            Else
                Return Trim(REQ_O_AGE) & "歳"
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

    '往路：回答ステータス
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

    '往路：交通機関（回答）
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

    '往路：利用日（回答）
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

    '往路：出発地（依頼）
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

    '往路：到着地（依頼）
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

    '往路：出発時間（依頼）
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

    '往路：到着時間（依頼）
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

    '往路：列車名・便名（依頼）
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

    '往路：座席区分
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

    '往路：座席希望
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

    '復路：交通手配
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

    '復路：交通依頼内容
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

    '復路：交通機関
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

    '復路：利用日（依頼）
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

    '復路：出発地（依頼）
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

    '復路：到着地（依頼）
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

    '復路：出発時間（依頼）
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

    '復路：到着時間（依頼）
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

    '復路：列車名・便名（依頼）
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

    '復路：座席区分
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

    '復路：座席希望
    Public Shared Function GetName_REQ_F_SEAT_KIBOU(ByVal REQ_F_SEAT_KIBOU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_SEAT_KIBOU AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_F_SEAT_KIBOU Then
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

    '復路：航空搭乗者年齢（年齢）
    Public Shared Function GetName_REQ_F_AGE(ByVal REQ_F_AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(REQ_F_AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = True Then
                Return Trim(REQ_F_AGE)
            Else
                Return Trim(REQ_F_AGE) & "歳"
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

    '復路：回答ステータス
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

    '復路：交通機関（回答）
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

    '復路：利用日（回答）
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

    '復路：出発地（依頼）
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

    '復路：到着地（依頼）
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

    '復路：出発時間（依頼）
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

    '復路：到着時間（依頼）
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

    '復路：列車名・便名（依頼）
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

    '復路：座席区分
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

    '復路：座席希望
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

    '【確定】JR・鉄道代金
    Public Shared Function GetName_ANS_RAIL_FARE(ByVal ANS_RAIL_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_RAIL_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_RAIL_FARE).ToString("#,#")
            Else
                Return ANS_RAIL_FARE
            End If
        End If
    End Function

    '【確定】JR・鉄道取消料
    Public Shared Function GetName_ANS_RAIL_CANCELLATION(ByVal ANS_RAIL_CANCELLATION As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_RAIL_CANCELLATION) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_RAIL_CANCELLATION).ToString("#,#")
            Else
                Return ANS_RAIL_CANCELLATION
            End If
        End If
    End Function

    '【確定】航空券代金
    Public Shared Function GetName_ANS_AIR_FARE(ByVal ANS_AIR_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_AIR_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_AIR_FARE).ToString("#,#")
            Else
                Return ANS_AIR_FARE
            End If
        End If
    End Function

    '【確定】航空券取消料
    Public Shared Function GetName_ANS_AIR_CANCELLATION(ByVal ANS_AIR_CANCELLATION As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_AIR_CANCELLATION) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_AIR_CANCELLATION).ToString("#,#")
            Else
                Return ANS_AIR_CANCELLATION
            End If
        End If
    End Function

    '【確定】バス・船等代金
    Public Shared Function GetName_ANS_OTHER_FARE(ByVal ANS_OTHER_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_OTHER_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_OTHER_FARE).ToString("#,#")
            Else
                Return ANS_OTHER_FARE
            End If
        End If
    End Function

    '【確定】バス・船等取消料
    Public Shared Function GetName_ANS_OTHER_CANCELLATION(ByVal ANS_OTHER_CANCELLATION As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_OTHER_CANCELLATION) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_OTHER_CANCELLATION).ToString("#,#")
            Else
                Return ANS_OTHER_CANCELLATION
            End If
        End If
    End Function

    '【回答】手数料(交通・宿泊)
    Public Shared Function GetName_ANS_KOTSUHOTEL_TESURYO(ByVal KOTSUHOTEL_TESURYO As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(KOTSUHOTEL_TESURYO) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(KOTSUHOTEL_TESURYO).ToString("#,#")
            Else
                Return KOTSUHOTEL_TESURYO
            End If
        End If
    End Function

    '【回答】手数料(タクチケ発券手数料)
    Public Shared Function GetName_ANS_TAXI_TESURYO(ByVal ANS_TAXI_TESURYO As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ANS_TAXI_TESURYO) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ANS_TAXI_TESURYO).ToString("#,#")
            Else
                Return ANS_TAXI_TESURYO
            End If
        End If
    End Function

    'タクチケ発行枚数
    Public Shared Function GetName_ANS_TAXI_MAISUU(ByVal ANS_TAXI_TESURYO As String, ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection) As String
        If Double.Parse(GetName_TAXI_TESURYO(FROM_DATE, dbConn)) = 0 OrElse Val(ANS_TAXI_TESURYO) = 0 Then
            Return "0"
        Else
            'タクチケ発券手数料÷タクチケ発券手数料単価を切り上げ
            Return Math.Ceiling(Double.Parse(ANS_TAXI_TESURYO) / Double.Parse(GetName_TAXI_TESURYO(FROM_DATE, dbConn))).ToString
        End If
    End Function

    '手数料単価（交通・宿泊）
    Public Shared Function GetName_TESURYO(ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TESURYO Then
                Dim strZeiRate As String = AppModule.GetZeiRate(FROM_DATE, dbConn)
                wStr = (Double.Parse(MS_CODE(wCnt).DISP_TEXT) * (1 + Double.Parse(strZeiRate))).ToString
                Exit For
            End If
        Next
        Return wStr
    End Function

    '登録管理手数料
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

    'タクチケ備考（依頼）
    Public Shared Function GetName_REQ_TAXI_NOTE(ByVal REQ_TAXI_NOTE As String) As String
        Return REQ_TAXI_NOTE
    End Function

    'タクチケ備考（回答）
    Public Shared Function GetName_ANS_TAXI_NOTE(ByVal ANS_TAXI_NOTE As String) As String
        Return ANS_TAXI_NOTE
    End Function

    'タクチケ発券手数料
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

    'タクチケ精算手数料
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

    'タクシーチケット
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

    'タクシーチケット
    Public Shared Function GetMark_TEHAI_TAXI(ByVal TEHAI_TAXI As String) As String
        Select Case TEHAI_TAXI
            Case AppConst.KOTSUHOTEL.TEHAI_TAXI.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.Yes
                Return AppConst.KOTSUHOTEL.TEHAI_TAXI.Mark.Yes
                'Case AppConst.KOTSUHOTEL.TEHAI_TAXI.Code.No, AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.No
            Case Else
                Return AppConst.KOTSUHOTEL.TEHAI_TAXI.Mark.No
        End Select
    End Function

    'タクシーチケット：利用日（依頼）
    Public Shared Function GetName_REQ_TAXI_DATE(ByVal REQ_TAXI_DATE As String) As String
        Return CmnModule.Format_Date(REQ_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
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

    'タクシーチケット：発地（依頼）
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

    'タクシーチケット：着地（依頼）
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

    'タクシーチケット：予定金額
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

    'タクシーチケット：利用日（回答）
    Public Shared Function GetName_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_1(ByVal ANS_TAXI_DATE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_1, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_2(ByVal ANS_TAXI_DATE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_2, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_3(ByVal ANS_TAXI_DATE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_3, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_4(ByVal ANS_TAXI_DATE_4 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_4, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_5(ByVal ANS_TAXI_DATE_5 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_5, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_6(ByVal ANS_TAXI_DATE_6 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_6, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_7(ByVal ANS_TAXI_DATE_7 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_7, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_8(ByVal ANS_TAXI_DATE_8 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_8, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_9(ByVal ANS_TAXI_DATE_9 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_9, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_10(ByVal ANS_TAXI_DATE_10 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_10, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_11(ByVal ANS_TAXI_DATE_11 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_11, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_12(ByVal ANS_TAXI_DATE_12 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_12, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_13(ByVal ANS_TAXI_DATE_13 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_13, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_14(ByVal ANS_TAXI_DATE_14 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_14, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_15(ByVal ANS_TAXI_DATE_15 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_15, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_16(ByVal ANS_TAXI_DATE_16 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_16, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_17(ByVal ANS_TAXI_DATE_17 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_17, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_18(ByVal ANS_TAXI_DATE_18 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_18, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_19(ByVal ANS_TAXI_DATE_19 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_19, ShortFormat)
    End Function
    Public Shared Function GetName_ANS_TAXI_DATE_20(ByVal ANS_TAXI_DATE_20 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ANS_TAXI_DATE(ANS_TAXI_DATE_20, ShortFormat)
    End Function

    'タクシーチケット：券種（回答）
    Public Shared Function GetName_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TAXI_KENSHU AndAlso MS_CODE(wCnt).DISP_VALUE = ANS_TAXI_KENSHU Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
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
    Public Shared Function GetName_ANS_TAXI_KENSHU_11(ByVal ANS_TAXI_KENSHU_11 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_11)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_12(ByVal ANS_TAXI_KENSHU_12 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_12)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_13(ByVal ANS_TAXI_KENSHU_13 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_13)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_14(ByVal ANS_TAXI_KENSHU_14 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_14)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_15(ByVal ANS_TAXI_KENSHU_15 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_15)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_16(ByVal ANS_TAXI_KENSHU_16 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_16)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_17(ByVal ANS_TAXI_KENSHU_17 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_17)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_18(ByVal ANS_TAXI_KENSHU_18 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_18)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_19(ByVal ANS_TAXI_KENSHU_19 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_19)
    End Function
    Public Shared Function GetName_ANS_TAXI_KENSHU_20(ByVal ANS_TAXI_KENSHU_20 As String) As String
        Return GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_20)
    End Function

    'タクシーチケット：番号（回答）
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
    Public Shared Function GetName_ANS_TAXI_NO_11(ByVal ANS_TAXI_NO_11 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_11)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_12(ByVal ANS_TAXI_NO_12 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_12)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_13(ByVal ANS_TAXI_NO_13 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_13)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_14(ByVal ANS_TAXI_NO_14 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_14)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_15(ByVal ANS_TAXI_NO_15 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_15)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_16(ByVal ANS_TAXI_NO_16 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_16)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_17(ByVal ANS_TAXI_NO_17 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_17)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_18(ByVal ANS_TAXI_NO_18 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_18)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_19(ByVal ANS_TAXI_NO_19 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_19)
    End Function
    Public Shared Function GetName_ANS_TAXI_NO_20(ByVal ANS_TAXI_NO_20 As String) As String
        Return GetName_ANS_TAXI_NO(ANS_TAXI_NO_20)
    End Function

    'タクシーチケット：発行日（回答）
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE(ByVal ANS_TAXI_HAKKO_DATE As String) As String
        Return CmnModule.Format_Date(ANS_TAXI_HAKKO_DATE, CmnModule.DateFormatType.YYYYMMDD)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_1(ByVal ANS_TAXI_HAKKO_DATE_1 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_1)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_2(ByVal ANS_TAXI_HAKKO_DATE_2 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_2)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_3(ByVal ANS_TAXI_HAKKO_DATE_3 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_3)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_4(ByVal ANS_TAXI_HAKKO_DATE_4 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_4)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_5(ByVal ANS_TAXI_HAKKO_DATE_5 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_5)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_6(ByVal ANS_TAXI_HAKKO_DATE_6 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_6)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_7(ByVal ANS_TAXI_HAKKO_DATE_7 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_7)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_8(ByVal ANS_TAXI_HAKKO_DATE_8 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_8)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_9(ByVal ANS_TAXI_HAKKO_DATE_9 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_9)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_10(ByVal ANS_TAXI_HAKKO_DATE_10 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_10)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_11(ByVal ANS_TAXI_HAKKO_DATE_11 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_11)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_12(ByVal ANS_TAXI_HAKKO_DATE_12 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_12)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_13(ByVal ANS_TAXI_HAKKO_DATE_13 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_13)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_14(ByVal ANS_TAXI_HAKKO_DATE_14 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_14)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_15(ByVal ANS_TAXI_HAKKO_DATE_15 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_15)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_16(ByVal ANS_TAXI_HAKKO_DATE_16 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_16)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_17(ByVal ANS_TAXI_HAKKO_DATE_17 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_17)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_18(ByVal ANS_TAXI_HAKKO_DATE_18 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_18)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_19(ByVal ANS_TAXI_HAKKO_DATE_19 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_19)
    End Function
    Public Shared Function GetName_ANS_TAXI_HAKKO_DATE_20(ByVal ANS_TAXI_HAKKO_DATE_20 As String) As String
        Return GetName_ANS_TAXI_HAKKO_DATE(ANS_TAXI_HAKKO_DATE_20)
    End Function

    'タクチケ発券手数料単価
    Public Shared Function GetName_TAXI_TESURYO(ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TAXI_TESURYO Then
                Dim strZeiRate As String = AppModule.GetZeiRate(FROM_DATE, dbConn)
                wStr = (Double.Parse(MS_CODE(wCnt).DISP_TEXT) * Double.Parse(1 + Double.Parse(strZeiRate))).ToString()
                Exit For
            End If
        Next
        Return wStr
    End Function

    'タクチケ精算手数料
    Public Shared Function GetName_TAXI_SEISAN_TESURYO(ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TAXI_SEISAN_TESURYO Then
                Dim strZeiRate As String = AppModule.GetZeiRate(FROM_DATE, dbConn)
                wStr = (Double.Parse(MS_CODE(wCnt).DISP_TEXT) * Double.Parse(1 + Double.Parse(strZeiRate))).ToString()
                Exit For
            End If
        Next
        Return wStr
    End Function

    'MR随行有無(MR入力）
    Public Shared Function GetName_TEHAI_MR(ByVal TEHAI_MR As String) As String
        Return TEHAI_MR
    End Function

    'MR随行（隣席、別席）(MR入力）
    Public Shared Function GetName_MR_SEAT(ByVal MR_SEAT As String) As String
        Return MR_SEAT
    End Function

    'MR性別
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

    '社員用往路臨席希望（依頼）
    Public Shared Function GetName_REQ_MR_O_TEHAI(ByVal REQ_MR_O_TEHAI As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_MR_TEHAI AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_MR_O_TEHAI Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '社員用復路臨席希望（依頼）
    Public Shared Function GetName_REQ_MR_F_TEHAI(ByVal REQ_MR_F_TEHAI As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_MR_TEHAI AndAlso MS_CODE(wCnt).DISP_VALUE = REQ_MR_F_TEHAI Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '社員用往路臨席希望（回答）
    Public Shared Function GetName_ANS_MR_O_TEHAI(ByVal ANS_MR_O_TEHAI As String) As String
        Select Case ANS_MR_O_TEHAI
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Prepare, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.OK, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Daian, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Canceled, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Fuka, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka

            Case Else
                Return ""
        End Select
    End Function

    '社員用復路臨席希望（回答）
    Public Shared Function GetName_ANS_MR_F_TEHAI(ByVal ANS_MR_F_TEHAI As String) As String
        Select Case ANS_MR_F_TEHAI
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Prepare, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.OK, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Daian, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Canceled, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Fuka, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka

            Case Else
                Return ""
        End Select
    End Function

    '社員用交通・宿泊備考
    Public Shared Function GetName_REQ_MR_HOTEL_NOTE(ByVal REQ_MR_HOTEL_NOTE As String) As String
        Return REQ_MR_HOTEL_NOTE
    End Function

    '社員用宿泊備考
    Public Shared Function GetName_ANS_MR_HOTEL_NOTE(ByVal ANS_MR_HOTEL_NOTE As String) As String
        Return ANS_MR_HOTEL_NOTE
    End Function

    '社員用交通費
    Public Shared Function GetName_ANS_MR_KOTSUHI(ByVal ANS_MR_KOTSUHI As String) As String
        Return ANS_MR_KOTSUHI
    End Function

    '社員用宿泊費
    Public Shared Function GetName_ANS_MR_HOTELHI(ByVal ANS_MR_HOTELHI As String) As String
        Return ANS_MR_HOTELHI
    End Function

    'MR年齢
    Public Shared Function GetName_MR_AGE(ByVal MR_AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(MR_AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = True Then
                Return Trim(MR_AGE)
            Else
                Return Trim(MR_AGE) & "歳"
            End If
        End If
    End Function

    '発送日(最新)
    Public Shared Function GetName_ANS_TICKET_SEND_DAY(ByVal ANS_TICKET_SEND_DAY As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = True Then
            Return CmnModule.Format_Date(ANS_TICKET_SEND_DAY, CmnModule.DateFormatType.YYYYMD)
        Else
            Dim wStr As String = ""
            wStr = CmnModule.Format_DateJP(Trim(ANS_TICKET_SEND_DAY), CmnModule.DateFormatType.YYYYMD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(ANS_TICKET_SEND_DAY), CmnModule.DateFormatType.YYYYMD), True)
            wStr = Replace(wStr, "月0", "月")
            wStr = Replace(wStr, "日0", "日")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        End If
    End Function
#End Region

#Region "精算情報"

    'トップツアー精算年月
    Public Shared Function GetName_SEISAN_YM(ByVal SEISAN_YM As String) As String
        Return Mid(CmnModule.Format_DateJP(SEISAN_YM & "01", CmnModule.DateFormatType.YYYYMMDD), 1, 8)
    End Function

    '承認区分
    Public Shared Function GetName_SHOUNIN_KUBUN(ByVal SHOUNIN_KUBUN As String, Optional ByVal IsJoken As Boolean = False) As String
        Select Case SHOUNIN_KUBUN
            Case AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN
                Return AppConst.SEISAN.SHOUNIN_KUBUN.Name.SHOUNIN
            Case AppConst.SEISAN.SHOUNIN_KUBUN.Code.HININ
                Return AppConst.SEISAN.SHOUNIN_KUBUN.Name.HININ
            Case AppConst.SEISAN.SHOUNIN_KUBUN.Code.Mi
                If IsJoken Then
                    Return AppConst.SEISAN.SHOUNIN_KUBUN.Name.Mi
                Else
                    Return String.Empty
                End If
            Case Else
                Return String.Empty
        End Select
    End Function

    '精算完了
    Public Shared Function GetName_SEISAN_KANRYO(ByVal SEISAN_KANRYO As String) As String
        Select Case SEISAN_KANRYO
            Case AppConst.SEISAN.SEISAN_KANRYO.Code.Mi
                Return AppConst.SEISAN.SEISAN_KANRYO.Name.Mi
            Case AppConst.SEISAN.SEISAN_KANRYO.Code.Kanryo
                Return AppConst.SEISAN.SEISAN_KANRYO.Name.Kanryo
            Case Else
                Return String.Empty
        End Select
    End Function
    Public Shared Function GetMark_SEISAN_KANRYO(ByVal SEISAN_KANRYO As String) As String
        Select Case SEISAN_KANRYO
            Case AppConst.SEISAN.SEISAN_KANRYO.Code.Mi
                Return AppConst.SEISAN.SEISAN_KANRYO.Mark.Mi
            Case AppConst.SEISAN.SEISAN_KANRYO.Code.Kanryo
                Return AppConst.SEISAN.SEISAN_KANRYO.Mark.Kanryo
            Case Else
                Return String.Empty
        End Select
    End Function


    'SAPCSVの請求年月日
    Public Shared Function GetName_SAP_SEIKYU_YMD(ByVal strYMD As String) As String

        Dim wStr As String = CmnModule.Format_Date(strYMD, CmnModule.DateFormatType.YYYYMMDD)

        If IsDate(wStr) Then
            wStr = CDate(wStr).ToString("dd.MM.yyyy")
        End If

        Return wStr
    End Function

#End Region

    '発送日
    Public Shared Function GetName_SEND_DATE(ByVal SEND_DATE As String) As String
        Return CmnModule.Format_Date(SEND_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '登録日時
    Public Shared Function GetName_INPUT_DATE(ByVal INPUT_DATE As String) As String
        Return CmnModule.Format_Date(INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    '更新日時
    Public Shared Function GetName_UPDATE_DATE(ByVal UPDATE_DATE As String) As String
        Return CmnModule.Format_Date(UPDATE_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Function

    'ユーザマスタ：権限
    Public Shared Function GetName_KENGEN(ByVal KENGEN As String) As String
        Select Case KENGEN
            Case AppConst.MS_USER.KENGEN.Code.Admin, AppConst.MS_USER.KENGEN.Name.Admin
                Return AppConst.MS_USER.KENGEN.Name.Admin
            Case AppConst.MS_USER.KENGEN.Code.User, AppConst.MS_USER.KENGEN.Name.User
                Return AppConst.MS_USER.KENGEN.Name.User

            Case Else
                Return ""
        End Select
    End Function

    'ユーザマスタ：精算入力
    Public Shared Function GetName_KENGEN_SEISAN(ByVal KENGEN_SEISAN As String, Optional ByVal ShortFormat As Boolean = False) As String
        Select Case KENGEN_SEISAN
            Case AppConst.MS_USER.KENGEN_SEISAN.Code.Yes, AppConst.MS_USER.KENGEN_SEISAN.Name.Yes, AppConst.MS_USER.KENGEN_SEISAN.Name.ShortFormat.Yes
                If ShortFormat = False Then
                    Return AppConst.MS_USER.KENGEN_SEISAN.Name.Yes
                Else
                    Return AppConst.MS_USER.KENGEN_SEISAN.Name.ShortFormat.Yes
                End If
            Case AppConst.MS_USER.KENGEN_SEISAN.Code.No, AppConst.MS_USER.KENGEN_SEISAN.Name.No, AppConst.MS_USER.KENGEN_SEISAN.Name.ShortFormat.No
                If ShortFormat = False Then
                    Return AppConst.MS_USER.KENGEN_SEISAN.Name.No
                Else
                    Return AppConst.MS_USER.KENGEN_SEISAN.Name.ShortFormat.No
                End If

            Case Else
                Return ""
        End Select
    End Function

    'ユーザマスタ：利用停止フラグ
    Public Shared Function GetName_STOP_FLG(ByVal STOP_FLG As String) As String
        Select Case STOP_FLG
            Case AppConst.STOP_FLG.Code.Stop, AppConst.STOP_FLG.Name.Stop
                Return AppConst.STOP_FLG.Name.Stop

            Case Else
                Return ""
        End Select
    End Function

    'ログテーブル：送受信
    Public Shared Function GetName_EXPORTIMPORT(ByVal INPUT_USER As String) As String
        If Mid(Trim(INPUT_USER).ToUpper, 1, 6) = "EXPORT" Then
            Return AppConst.TBL_LOG.EXPORTIMPORT.Name.EXPORT
        ElseIf Mid(Trim(INPUT_USER).ToUpper, 1, 6) = "IMPORT" Then
            Return AppConst.TBL_LOG.EXPORTIMPORT.Name.IMPORT
        Else
            Return ""
        End If
    End Function

    'ログテーブル：ステータス
    Public Shared Function GetName_STATUS(ByVal STATUS As String) As String
        Select Case STATUS
            Case AppConst.TBL_LOG.STATUS.Code.OK, AppConst.TBL_LOG.STATUS.Name.OK
                Return AppConst.TBL_LOG.STATUS.Name.OK
            Case AppConst.TBL_LOG.STATUS.Code.NG, AppConst.TBL_LOG.STATUS.Name.NG
                Return AppConst.TBL_LOG.STATUS.Name.NG
            Case Else
                Return ""
        End Select
    End Function

    'ログテーブル：ログイン者
    Public Shared Function GetName_INPUT_USER(ByVal INPUT_USER As String, ByVal USER_NAME As String) As String
        If Trim(CmnModule.ClearHtmlSpace(INPUT_USER)) = "" AndAlso Trim(CmnModule.ClearHtmlSpace(USER_NAME)) = "" Then
            Return ""
        ElseIf Trim(CmnModule.ClearHtmlSpace(INPUT_USER)) <> "" AndAlso Trim(CmnModule.ClearHtmlSpace(USER_NAME)) <> "" Then
            Return Trim(CmnModule.ClearHtmlSpace(INPUT_USER)) & "：" & Trim(CmnModule.ClearHtmlSpace(USER_NAME))
        Else
            Return Trim(CmnModule.ClearHtmlSpace(INPUT_USER) & CmnModule.ClearHtmlSpace(USER_NAME))
        End If
    End Function

    'SalesForceID
    Public Shared Function GetName_SALEFORCE_ID(ByVal SALEFORCE_ID As String) As String
        Return Trim(SALEFORCE_ID)
    End Function

#Region "未決登録"
    Public Shared Function GetName_TKT_KAISHA(ByVal TKT_KAISHA As String) As String
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If MS_CODE(wCnt).CODE = AppConst.MS_CODE.KOTSUKIKAN AndAlso MS_CODE(wCnt).DISP_VALUE = TKT_KAISHA Then
                wStr = MS_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function
#End Region

#Region "タクチケ管理台帳"

    'エンタ
    Public Shared Function GetName_TKT_ENTA(ByVal TKT_ENTA As String) As String
        Select Case TKT_ENTA
            Case AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.FuSanka
                Return AppConst.TAXITICKET_HAKKO.TKT_ENTA.Name.FuSanka
            Case AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.SeisanFuka
                Return AppConst.TAXITICKET_HAKKO.TKT_ENTA.Name.SeisanFuka
            Case Else
                Return String.Empty
        End Select
    End Function

#End Region

#End Region


    '== コントロールをセット ==
    'ログインID
    Public Shared Sub SetForm_LOGIN_ID(ByVal LOGIN_ID As String, ByRef control As TextBox)
        control.Text = LOGIN_ID
    End Sub

    'パスワード
    Public Shared Sub SetForm_PASSWORD(ByVal PASSWORD As String, ByRef control As TextBox)
        control.Text = PASSWORD
    End Sub

    '氏名
    Public Shared Sub SetForm_USER_NAME(ByVal USER_NAME As String, ByRef control As TextBox)
        control.Text = USER_NAME
    End Sub

#Region "交通・宿泊手配回答登録画面　画面項目表示"
    '会合番号
    Public Shared Sub SetForm_KOUENKAI_NO(ByVal KOUENKAI_NO As String, ByRef control As Label)
        control.Text = KOUENKAI_NO
    End Sub

    '開催日
    Public Shared Sub SetForm_KOUENKAI_DATE(ByVal FROM_DATE As String, ByVal TO_DATE As String, ByRef control As Label)
        control.Text = GetName_KOUENKAI_DATE(FROM_DATE, TO_DATE)
    End Sub

    '会合名
    Public Shared Sub SetForm_KOUENKAI_NAME(ByVal KOUENKAI_NAME As String, ByRef control As TextBox)
        control.Text = KOUENKAI_NAME
    End Sub

    '会場名
    Public Shared Sub SetForm_KAIJO_NAME(ByVal KAIJO_NAME As String, ByRef control As TextBox)
        control.Text = KAIJO_NAME
    End Sub

    '団体コード
    Public Shared Sub SetForm_DANTAI_CODE(ByVal DANTAI_CODE As String, ByRef control As Label)
        control.Text = DANTAI_CODE
    End Sub

    '会合基本情報TimeStamp
    Public Shared Sub SetForm_KOUENKAI_TIME_STAMP(ByVal KOUENKAI_TIME_STAMP As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(KOUENKAI_TIME_STAMP, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Sub

    '開催日FROM
    Public Shared Sub SetForm_FROM_DATE(ByVal FROM_DATE As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(FROM_DATE, CmnModule.DateFormatType.YYYYMD)
    End Sub

    '開催日TO
    Public Shared Sub SetForm_TO_DATE(ByVal TO_DATE As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(TO_DATE, CmnModule.DateFormatType.YYYYMD)
    End Sub

    'タクシー印字名
    Public Shared Sub SetForm_TAXI_PRT_NAME(ByVal TAXI_PRT_NAME As String, ByRef control As Label)
        control.Text = TAXI_PRT_NAME
    End Sub

    'MR BU
    Public Shared Sub SetForm_MR_BU(ByVal MR_BU As String, ByRef control As Label)
        control.Text = MR_BU
    End Sub

    'MR エリア
    Public Shared Sub SetForm_MR_AREA(ByVal MR_AREA As String, ByRef control As Label)
        control.Text = MR_AREA
    End Sub

    'MR 営業所
    Public Shared Sub SetForm_MR_EIGYOSHO(ByVal MR_EIGYOSHO As String, ByRef control As Label)
        control.Text = MR_EIGYOSHO
    End Sub

    'MR ACCOUNT CODE
    Public Shared Sub SetForm_ACCOUNT_CODE(ByVal ACCOUNT_CODE As String, ByRef control As Label)
        control.Text = ACCOUNT_CODE
    End Sub

    'MR COST CENTER
    Public Shared Sub SetForm_COST_CENTER(ByVal COST_CENTER As String, ByRef control As Label)
        control.Text = COST_CENTER
    End Sub

    'MR INTERNAL ORDER
    Public Shared Sub SetForm_INTERNAL_ORDER(ByVal INTERNAL_ORDER As String, ByRef control As Label)
        control.Text = INTERNAL_ORDER
    End Sub

    'MR ZETIA CODE
    Public Shared Sub SetForm_ZETIA_CODE(ByVal ZETIA_CODE As String, ByRef control As Label)
        control.Text = ZETIA_CODE
    End Sub

    'MR名
    Public Shared Sub SetForm_MR_NAME(ByVal MR_NAME As String, ByRef control As TextBox)
        control.Text = MR_NAME
    End Sub

    'MR名(ローマ字)
    Public Shared Sub SetForm_MR_ROMA(ByVal MR_ROMA As String, ByRef control As TextBox)
        control.Text = MR_ROMA
    End Sub

    'MR携帯電話番号
    Public Shared Sub SetForm_MR_KEITAI(ByVal MR_KEITAI As String, ByRef control As Label)
        control.Text = MR_KEITAI
    End Sub

    'MRオフィスの電話番号
    Public Shared Sub SetForm_MR_TEL(ByVal MR_TEL As String, ByRef control As Label)
        control.Text = MR_TEL
    End Sub

    'MR携帯メールアドレス
    Public Shared Sub SetForm_MR_EMAIL_KEITAI(ByVal MR_EMAIL_KEITAI As String, ByRef control As TextBox)
        control.Text = MR_EMAIL_KEITAI
    End Sub

    'MRメールアドレス
    Public Shared Sub SetForm_MR_EMAIL_PC(ByVal MR_EMAIL_PC As String, ByRef control As TextBox)
        control.Text = MR_EMAIL_PC
    End Sub

    'MR送付先FS
    Public Shared Sub SetForm_MR_SEND_SAKI_FS(ByVal MR_SEND_SAKI_FS As String, ByRef control As Label)
        control.Text = MR_SEND_SAKI_FS
    End Sub

    'MRその他送付先
    Public Shared Sub SetForm_MR_SEND_SAKI_OTHER(ByVal MR_SEND_SAKI_OTHER As String, ByRef control As TextBox)
        control.Text = MR_SEND_SAKI_OTHER
    End Sub

    '【依頼】手配ステータス
    Public Shared Sub SetForm_REQ_STATUS_TEHAI(ByVal REQ_STATUS_TEHAI As String, ByRef control As Label)
        control.Text = GetName_REQ_STATUS_TEHAI(REQ_STATUS_TEHAI)
    End Sub

    '【回答】手配ステータス
    Public Shared Sub SetForm_ANS_TICKET_SEND_DAY(ByVal ANS_TICKET_SEND_DAY As String, ByRef control As TextBox)
        control.Text = ANS_TICKET_SEND_DAY
    End Sub

    'チケット類発送日（最新）
    Public Shared Sub SetForm_ANS_STATUS_TEHAI(ByVal ANS_STATUS_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_STATUS_TEHAI, control, True)
    End Sub

    'NOZOMI送信ステータス
    Public Shared Sub SetForm_SEND_FLAG(ByVal SEND_FLAG As String, ByRef control As Label)
        control.Text = AppModule.GetName_SEND_FLAG(SEND_FLAG)
    End Sub

    '参加者ID
    Public Shared Sub SetForm_SANKASHA_ID(ByVal SANKASHA_ID As String, ByRef control As Label)
        control.Text = SANKASHA_ID
    End Sub

    '参加者ID
    Public Shared Sub SetForm_SANKASHA_ID(ByVal SANKASHA_ID As String, ByRef control As TextBox)
        control.Text = SANKASHA_ID
    End Sub

    'DRコード
    Public Shared Sub SetForm_DR_CD(ByVal DR_CD As String, ByRef control As Label)
        control.Text = DR_CD
    End Sub

    'TIME STAMP BYL
    Public Shared Sub SetForm_TIME_STAMP_BYL(ByVal TIME_STAMP_BYL As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Sub

    'TIME STAMP TOP
    Public Shared Sub SetForm_TIME_STAMP_TOP(ByVal TIME_STAMP_TOP As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(TIME_STAMP_TOP, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
    End Sub

    'DR氏名
    Public Shared Sub SetForm_DR_NAME(ByVal DR_NAME As String, ByRef control As TextBox)
        control.Text = DR_NAME
    End Sub

    'DR氏名（カナ）
    Public Shared Sub SetForm_DR_KANA(ByVal DR_KANA As String, ByRef control As TextBox)
        control.Text = DR_KANA
    End Sub

    'DR性別
    Public Shared Sub SetForm_DR_SEX(ByVal DR_SEX As String, ByRef control As Label)
        control.Text = GetName_DR_SEX(DR_SEX)
    End Sub

    'DR年齢
    Public Shared Sub SetForm_DR_AGE(ByVal DR_AGE As String, ByRef control As Label)
        control.Text = DR_AGE
    End Sub

    '会合への参加
    Public Shared Sub SetForm_DR_SANKA(ByVal DR_SANKA As String, ByRef control As Label)
        control.Text = GetName_DR_SANKA(DR_SANKA)
    End Sub

    '参加者の役割
    Public Shared Sub SetForm_DR_YAKUWARI(ByVal DR_YAKUWARI As String, ByRef control As Label)
        control.Text = GetName_DR_YAKUWARI(DR_YAKUWARI)
    End Sub

    '参加／不参加
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

    '手配ステータス
    Public Shared Sub SetForm_STATUS_TEHAI(ByVal STATUS_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(STATUS_TEHAI, control)
    End Sub

    'DCF施設コード
    Public Shared Sub SetForm_DR_SHISETSU_CD(ByVal DR_SHISETSU_CD As String, ByRef control As Label)
        control.Text = DR_SHISETSU_CD
    End Sub

    '施設名
    Public Shared Sub SetForm_DR_SHISETSU_NAME(ByVal DR_SHISETSU_NANE As String, ByRef control As TextBox)
        control.Text = DR_SHISETSU_NANE
    End Sub

    '施設住所
    Public Shared Sub SetForm_DR_SHISETSU_ADDRESS(ByVal DR_SHISETSU_ADDRESS As String, ByRef control As TextBox)
        control.Text = DR_SHISETSU_ADDRESS
    End Sub

    '指定外理由
    Public Shared Sub SetForm_SHITEIGAI_RIYU(ByVal SHITEIGAI_RIYU As String, ByRef control As TextBox)
        control.Text = SHITEIGAI_RIYU
    End Sub

    '承認者
    Public Shared Sub SetForm_SHONIN_NAME(ByVal SHONIN_NAME As String, ByRef control As TextBox)
        control.Text = SHONIN_NAME
    End Sub

    '承認日
    Public Shared Sub SetForm_SHONIN_DATE(ByVal SHONIN_DATE As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(SHONIN_DATE, CmnModule.DateFormatType.YYYYMD)
    End Sub

    '宿泊依頼（依頼）
    Public Shared Sub SetForm_TEHAI_HOTEL(ByVal TEHAI_HOTEL As String, ByRef control As Label)
        control.Text = GetName_TEHAI_HOTEL(TEHAI_HOTEL)
    End Sub

    '宿泊依頼内容（依頼）
    Public Shared Sub SetForm_HOTEL_IRAINAIYOU(ByVal HOTEL_IRAINAIYOU As String, ByRef control As Label)
        control.Text = GetName_HOTEL_IRAINAIYOU(HOTEL_IRAINAIYOU)
    End Sub

    '宿泊日（依頼）
    Public Shared Sub SetForm_REQ_HOTEL_DATE(ByVal REQ_HOTEL_DATE As String, ByRef control As Label)
        Dim wStr As String = ""
        wStr = CmnModule.Format_Date(Trim(REQ_HOTEL_DATE), CmnModule.DateFormatType.YYYYMMDD) _
             & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(REQ_HOTEL_DATE), CmnModule.DateFormatType.YYYYMMDD), True)
        control.Text = wStr
    End Sub

    '泊数（依頼）
    Public Shared Sub SetForm_REQ_HAKUSU(ByVal REQ_HAKUSU As String, ByRef control As Label)
        control.Text = REQ_HAKUSU
    End Sub

    '喫煙（依頼）
    Public Shared Sub SetForm_REQ_HOTEL_SMOKING(ByVal REQ_HOTEL_SMOKING As String, ByRef control As Label)
        control.Text = GetName_REQ_HOTEL_SMOKING(REQ_HOTEL_SMOKING)
    End Sub

    '宿泊備考（依頼）
    Public Shared Sub SetForm_REQ_HOTEL_NOTE(ByVal REQ_HOTEL_NOTE As String, ByRef control As TextBox)
        control.Text = REQ_HOTEL_NOTE
    End Sub

    '宿泊ステータス（回答）
    Public Shared Sub SetForm_ANS_STATUS_HOTEL(ByVal ANS_STATUS_HOTEL As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_STATUS_HOTEL, control)
    End Sub

    '宿泊先（回答）
    Public Shared Sub SetForm_ANS_HOTEL_NAME(ByVal ANS_HOTEL_NAME As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_NAME
    End Sub

    '宿泊先住所（回答）
    Public Shared Sub SetForm_ANS_HOTEL_ADDRESS(ByVal ANS_HOTEL_ADDRESS As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_ADDRESS
    End Sub

    '宿泊先電話番号（回答）
    Public Shared Sub SetForm_ANS_HOTEL_TEL(ByVal ANS_HOTEL_TEL As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_TEL
    End Sub

    '宿泊日（回答）
    Public Shared Sub SetForm_ANS_HOTEL_DATE(ByVal ANS_HOTEL_DATE As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_DATE
    End Sub

    '泊数（回答）
    Public Shared Sub SetForm_ANS_HAKUSU(ByVal ANS_HAKUSU As String, ByRef control As TextBox)
        control.Text = ANS_HAKUSU
    End Sub

    '宿泊先チェックイン時間（回答）
    Public Shared Sub SetForm_ANS_CHECKIN_TIME(ByVal ANS_CHECKIN_TIME As String, ByRef control As TextBox)
        control.Text = ANS_CHECKIN_TIME
    End Sub

    '宿泊先チェックアウト時間（回答）
    Public Shared Sub SetForm_ANS_CHECKOUT_TIME(ByVal ANS_CHECKOUT_TIME As String, ByRef control As TextBox)
        control.Text = ANS_CHECKOUT_TIME
    End Sub

    '宿泊部屋タイプ（回答）
    Public Shared Sub SetForm_ANS_ROOM_TYPE(ByVal ANS_ROOM_TYPE As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_ROOM_TYPE, control)
    End Sub

    '宿泊ホテル喫煙（回答）
    Public Shared Sub SetForm_ANS_HOTEL_SMOKING(ByVal ANS_HOTEL_SMOKING As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_HOTEL_SMOKING, control)
    End Sub

    '宿泊備考（回答）
    Public Shared Sub SetForm_ANS_HOTEL_NOTE(ByVal ANS_HOTEL_NOTE As String, ByRef control As TextBox)
        control.Text = ANS_HOTEL_NOTE
    End Sub

    '宿泊代金  ?????

    '往路：手配（依頼）
    Public Shared Sub SetForm_REQ_O_TEHAI(ByVal REQ_O_TEHAI As String, ByRef control As Label)
        control.Text = GetName_REQ_O_TEHAI(REQ_O_TEHAI)
    End Sub
    Public Shared Sub SetForm_REQ_O_TEHAI_1(ByVal REQ_O_TEHAI_1 As String, ByRef control As Label)
        SetForm_REQ_O_TEHAI(REQ_O_TEHAI_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TEHAI_2(ByVal REQ_O_TEHAI_2 As String, ByRef control As Label)
        SetForm_REQ_O_TEHAI(REQ_O_TEHAI_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TEHAI_3(ByVal REQ_O_TEHAI_3 As String, ByRef control As Label)
        SetForm_REQ_O_TEHAI(REQ_O_TEHAI_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TEHAI_4(ByVal REQ_O_TEHAI_4 As String, ByRef control As Label)
        SetForm_REQ_O_TEHAI(REQ_O_TEHAI_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TEHAI_5(ByVal REQ_O_TEHAI_5 As String, ByRef control As Label)
        SetForm_REQ_O_TEHAI(REQ_O_TEHAI_5, control)
    End Sub

    '往路：依頼内容（依頼）
    Public Shared Sub SetForm_REQ_O_IRAINAIYOU(ByVal REQ_O_IRAINAIYOU As String, ByRef control As Label)
        control.Text = GetName_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU)
    End Sub
    Public Shared Sub SetForm_REQ_O_IRAINAIYOU_1(ByVal REQ_O_IRAINAIYOU_1 As String, ByRef control As Label)
        SetForm_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_IRAINAIYOU_2(ByVal REQ_O_IRAINAIYOU_2 As String, ByRef control As Label)
        SetForm_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_IRAINAIYOU_3(ByVal REQ_O_IRAINAIYOU_3 As String, ByRef control As Label)
        SetForm_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_IRAINAIYOU_4(ByVal REQ_O_IRAINAIYOU_4 As String, ByRef control As Label)
        SetForm_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_IRAINAIYOU_5(ByVal REQ_O_IRAINAIYOU_5 As String, ByRef control As Label)
        SetForm_REQ_O_IRAINAIYOU(REQ_O_IRAINAIYOU_5, control)
    End Sub

    '往路：交通機関（依頼）
    Public Shared Sub SetForm_REQ_O_KOTSUKIKAN(ByVal REQ_O_KOTSUKIKAN As String, ByRef control As Label)
        control.Text = GetName_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN)
    End Sub
    Public Shared Sub SetForm_REQ_O_KOTSUKIKAN_1(ByVal REQ_O_KOTSUKIKAN_1 As String, ByRef control As Label)
        SetForm_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_KOTSUKIKAN_2(ByVal REQ_O_KOTSUKIKAN_2 As String, ByRef control As Label)
        SetForm_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_KOTSUKIKAN_3(ByVal REQ_O_KOTSUKIKAN_3 As String, ByRef control As Label)
        SetForm_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_KOTSUKIKAN_4(ByVal REQ_O_KOTSUKIKAN_4 As String, ByRef control As Label)
        SetForm_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_KOTSUKIKAN_5(ByVal REQ_O_KOTSUKIKAN_5 As String, ByRef control As Label)
        SetForm_REQ_O_KOTSUKIKAN(REQ_O_KOTSUKIKAN_5, control)
    End Sub

    '往路：利用日（依頼）
    Public Shared Sub SetForm_REQ_O_DATE(ByVal REQ_O_DATE As String, ByRef control As Label)
        Dim wStr As String = ""
        wStr = CmnModule.Format_Date(Trim(REQ_O_DATE), CmnModule.DateFormatType.YYYYMMDD) _
             & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(REQ_O_DATE), CmnModule.DateFormatType.YYYYMMDD), True)
        control.Text = wStr
    End Sub
    Public Shared Sub SetForm_REQ_O_DATE_1(ByVal REQ_O_DATE_1 As String, ByRef control As Label)
        SetForm_REQ_O_DATE(REQ_O_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_DATE_2(ByVal REQ_O_DATE_2 As String, ByRef control As Label)
        SetForm_REQ_O_DATE(REQ_O_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_DATE_3(ByVal REQ_O_DATE_3 As String, ByRef control As Label)
        SetForm_REQ_O_DATE(REQ_O_DATE_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_DATE_4(ByVal REQ_O_DATE_4 As String, ByRef control As Label)
        SetForm_REQ_O_DATE(REQ_O_DATE_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_DATE_5(ByVal REQ_O_DATE_5 As String, ByRef control As Label)
        SetForm_REQ_O_DATE(REQ_O_DATE_5, control)
    End Sub

    '往路：出発地（依頼）
    Public Shared Sub SetForm_REQ_O_AIRPORT1(ByVal REQ_O_AIRPORT1 As String, ByRef control As TextBox)
        control.Text = REQ_O_AIRPORT1
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT1_1(ByVal REQ_O_AIRPORT1_1 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT1(REQ_O_AIRPORT1_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT1_2(ByVal REQ_O_AIRPORT1_2 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT1(REQ_O_AIRPORT1_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT1_3(ByVal REQ_O_AIRPORT1_3 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT1(REQ_O_AIRPORT1_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT1_4(ByVal REQ_O_AIRPORT1_4 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT1(REQ_O_AIRPORT1_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT1_5(ByVal REQ_O_AIRPORT1_5 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT1(REQ_O_AIRPORT1_5, control)
    End Sub

    '往路：到着地（依頼）
    Public Shared Sub SetForm_REQ_O_AIRPORT2(ByVal REQ_O_AIRPORT2 As String, ByRef control As TextBox)
        control.Text = REQ_O_AIRPORT2
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT2_1(ByVal REQ_O_AIRPORT2_1 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT2(REQ_O_AIRPORT2_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT2_2(ByVal REQ_O_AIRPORT2_2 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT2(REQ_O_AIRPORT2_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT2_3(ByVal REQ_O_AIRPORT2_3 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT2(REQ_O_AIRPORT2_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT2_4(ByVal REQ_O_AIRPORT2_4 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT2(REQ_O_AIRPORT2_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_AIRPORT2_5(ByVal REQ_O_AIRPORT2_5 As String, ByRef control As TextBox)
        SetForm_REQ_O_AIRPORT2(REQ_O_AIRPORT2_5, control)
    End Sub

    '往路：出発時刻（依頼）
    Public Shared Sub SetForm_REQ_O_TIME1(ByVal REQ_O_TIME1 As String, ByRef control As Label)
        control.Text = CommonLib.CmnModule.Format_Date(REQ_O_TIME1, CmnModule.DateFormatType.HHMM)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME1_1(ByVal REQ_O_TIME1_1 As String, ByRef control As Label)
        SetForm_REQ_O_TIME1(REQ_O_TIME1_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME1_2(ByVal REQ_O_TIME1_2 As String, ByRef control As Label)
        SetForm_REQ_O_TIME1(REQ_O_TIME1_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME1_3(ByVal REQ_O_TIME1_3 As String, ByRef control As Label)
        SetForm_REQ_O_TIME1(REQ_O_TIME1_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME1_4(ByVal REQ_O_TIME1_4 As String, ByRef control As Label)
        SetForm_REQ_O_TIME1(REQ_O_TIME1_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME1_5(ByVal REQ_O_TIME1_5 As String, ByRef control As Label)
        SetForm_REQ_O_TIME1(REQ_O_TIME1_5, control)
    End Sub

    '往路：到着時刻（依頼）
    Public Shared Sub SetForm_REQ_O_TIME2(ByVal REQ_O_TIME2 As String, ByRef control As Label)
        control.Text = CommonLib.CmnModule.Format_Date(REQ_O_TIME2, CmnModule.DateFormatType.HHMM)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME2_1(ByVal REQ_O_TIME2_1 As String, ByRef control As Label)
        SetForm_REQ_O_TIME2(REQ_O_TIME2_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME2_2(ByVal REQ_O_TIME2_2 As String, ByRef control As Label)
        SetForm_REQ_O_TIME2(REQ_O_TIME2_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME2_3(ByVal REQ_O_TIME2_3 As String, ByRef control As Label)
        SetForm_REQ_O_TIME2(REQ_O_TIME2_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME2_4(ByVal REQ_O_TIME2_4 As String, ByRef control As Label)
        SetForm_REQ_O_TIME2(REQ_O_TIME2_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_TIME2_5(ByVal REQ_O_TIME2_5 As String, ByRef control As Label)
        SetForm_REQ_O_TIME2(REQ_O_TIME2_5, control)
    End Sub

    '往路：列車・便名（依頼）
    Public Shared Sub SetForm_REQ_O_BIN(ByVal REQ_O_BIN As String, ByRef control As TextBox)
        control.Text = CommonLib.CmnModule.Format_Date(REQ_O_BIN, CmnModule.DateFormatType.HHMM)
    End Sub
    Public Shared Sub SetForm_REQ_O_BIN_1(ByVal REQ_O_BIN_1 As String, ByRef control As TextBox)
        SetForm_REQ_O_BIN(REQ_O_BIN_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_BIN_2(ByVal REQ_O_BIN_2 As String, ByRef control As TextBox)
        SetForm_REQ_O_BIN(REQ_O_BIN_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_BIN_3(ByVal REQ_O_BIN_3 As String, ByRef control As TextBox)
        SetForm_REQ_O_BIN(REQ_O_BIN_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_BIN_4(ByVal REQ_O_BIN_4 As String, ByRef control As TextBox)
        SetForm_REQ_O_BIN(REQ_O_BIN_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_BIN_5(ByVal REQ_O_BIN_5 As String, ByRef control As TextBox)
        SetForm_REQ_O_BIN(REQ_O_BIN_5, control)
    End Sub

    '往路：座席区分（依頼）
    Public Shared Sub SetForm_REQ_O_SEAT(ByVal REQ_O_SEAT As String, ByRef control As Label)
        control.Text = GetName_REQ_O_SEAT(REQ_O_SEAT)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_1(ByVal REQ_O_SEAT_1 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT(REQ_O_SEAT_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_2(ByVal REQ_O_SEAT_2 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT(REQ_O_SEAT_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_3(ByVal REQ_O_SEAT_3 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT(REQ_O_SEAT_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_4(ByVal REQ_O_SEAT_4 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT(REQ_O_SEAT_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_5(ByVal REQ_O_SEAT_5 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT(REQ_O_SEAT_5, control)
    End Sub

    '往路：座席位置（依頼）
    Public Shared Sub SetForm_REQ_O_SEAT_KIBOU(ByVal REQ_O_SEAT_KIBOU As String, ByRef control As Label)
        control.Text = GetName_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_KIBOU1(ByVal REQ_O_SEAT_KIBOU1 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU1, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_KIBOU2(ByVal REQ_O_SEAT_KIBOU2 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU2, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_KIBOU3(ByVal REQ_O_SEAT_KIBOU3 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU3, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_KIBOU4(ByVal REQ_O_SEAT_KIBOU4 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU4, control)
    End Sub
    Public Shared Sub SetForm_REQ_O_SEAT_KIBOU5(ByVal REQ_O_SEAT_KIBOU5 As String, ByRef control As Label)
        SetForm_REQ_O_SEAT_KIBOU(REQ_O_SEAT_KIBOU5, control)
    End Sub
    '復路：手配（依頼）
    Public Shared Sub SetForm_REQ_F_TEHAI(ByVal REQ_F_TEHAI As String, ByRef control As Label)
        control.Text = GetName_REQ_F_TEHAI(REQ_F_TEHAI)
    End Sub
    Public Shared Sub SetForm_REQ_F_TEHAI_1(ByVal REQ_F_TEHAI_1 As String, ByRef control As Label)
        SetForm_REQ_F_TEHAI(REQ_F_TEHAI_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TEHAI_2(ByVal REQ_F_TEHAI_2 As String, ByRef control As Label)
        SetForm_REQ_F_TEHAI(REQ_F_TEHAI_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TEHAI_3(ByVal REQ_F_TEHAI_3 As String, ByRef control As Label)
        SetForm_REQ_F_TEHAI(REQ_F_TEHAI_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TEHAI_4(ByVal REQ_F_TEHAI_4 As String, ByRef control As Label)
        SetForm_REQ_F_TEHAI(REQ_F_TEHAI_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TEHAI_5(ByVal REQ_F_TEHAI_5 As String, ByRef control As Label)
        SetForm_REQ_F_TEHAI(REQ_F_TEHAI_5, control)
    End Sub

    '復路：依頼内容（依頼）
    Public Shared Sub SetForm_REQ_F_IRAINAIYOU(ByVal REQ_F_IRAINAIYOU As String, ByRef control As Label)
        control.Text = GetName_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU)
    End Sub
    Public Shared Sub SetForm_REQ_F_IRAINAIYOU_1(ByVal REQ_F_IRAINAIYOU_1 As String, ByRef control As Label)
        SetForm_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_IRAINAIYOU_2(ByVal REQ_F_IRAINAIYOU_2 As String, ByRef control As Label)
        SetForm_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_IRAINAIYOU_3(ByVal REQ_F_IRAINAIYOU_3 As String, ByRef control As Label)
        SetForm_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_IRAINAIYOU_4(ByVal REQ_F_IRAINAIYOU_4 As String, ByRef control As Label)
        SetForm_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_IRAINAIYOU_5(ByVal REQ_F_IRAINAIYOU_5 As String, ByRef control As Label)
        SetForm_REQ_F_IRAINAIYOU(REQ_F_IRAINAIYOU_5, control)
    End Sub

    '復路：交通機関（依頼）
    Public Shared Sub SetForm_REQ_F_KOTSUKIKAN(ByVal REQ_F_KOTSUKIKAN As String, ByRef control As Label)
        control.Text = GetName_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN)
    End Sub
    Public Shared Sub SetForm_REQ_F_KOTSUKIKAN_1(ByVal REQ_F_KOTSUKIKAN_1 As String, ByRef control As Label)
        SetForm_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_KOTSUKIKAN_2(ByVal REQ_F_KOTSUKIKAN_2 As String, ByRef control As Label)
        SetForm_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_KOTSUKIKAN_3(ByVal REQ_F_KOTSUKIKAN_3 As String, ByRef control As Label)
        SetForm_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_KOTSUKIKAN_4(ByVal REQ_F_KOTSUKIKAN_4 As String, ByRef control As Label)
        SetForm_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_KOTSUKIKAN_5(ByVal REQ_F_KOTSUKIKAN_5 As String, ByRef control As Label)
        SetForm_REQ_F_KOTSUKIKAN(REQ_F_KOTSUKIKAN_5, control)
    End Sub

    '復路：利用日（依頼）
    Public Shared Sub SetForm_REQ_F_DATE(ByVal REQ_F_DATE As String, ByRef control As Label)
        Dim wStr As String = ""
        wStr = CmnModule.Format_Date(Trim(REQ_F_DATE), CmnModule.DateFormatType.YYYYMMDD) _
             & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(REQ_F_DATE), CmnModule.DateFormatType.YYYYMMDD), True)
        control.Text = wStr
    End Sub
    Public Shared Sub SetForm_REQ_F_DATE_1(ByVal REQ_F_DATE_1 As String, ByRef control As Label)
        SetForm_REQ_F_DATE(REQ_F_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_DATE_2(ByVal REQ_F_DATE_2 As String, ByRef control As Label)
        SetForm_REQ_F_DATE(REQ_F_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_DATE_3(ByVal REQ_F_DATE_3 As String, ByRef control As Label)
        SetForm_REQ_F_DATE(REQ_F_DATE_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_DATE_4(ByVal REQ_F_DATE_4 As String, ByRef control As Label)
        SetForm_REQ_F_DATE(REQ_F_DATE_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_DATE_5(ByVal REQ_F_DATE_5 As String, ByRef control As Label)
        SetForm_REQ_F_DATE(REQ_F_DATE_5, control)
    End Sub

    '復路：出発地（依頼）
    Public Shared Sub SetForm_REQ_F_AIRPORT1(ByVal REQ_F_AIRPORT1 As String, ByRef control As TextBox)
        control.Text = REQ_F_AIRPORT1
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT1_1(ByVal REQ_F_AIRPORT1_1 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT1(REQ_F_AIRPORT1_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT1_2(ByVal REQ_F_AIRPORT1_2 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT1(REQ_F_AIRPORT1_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT1_3(ByVal REQ_F_AIRPORT1_3 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT1(REQ_F_AIRPORT1_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT1_4(ByVal REQ_F_AIRPORT1_4 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT1(REQ_F_AIRPORT1_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT1_5(ByVal REQ_F_AIRPORT1_5 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT1(REQ_F_AIRPORT1_5, control)
    End Sub

    '復路：到着地（依頼）
    Public Shared Sub SetForm_REQ_F_AIRPORT2(ByVal REQ_F_AIRPORT2 As String, ByRef control As TextBox)
        control.Text = REQ_F_AIRPORT2
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT2_1(ByVal REQ_F_AIRPORT2_1 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT2(REQ_F_AIRPORT2_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT2_2(ByVal REQ_F_AIRPORT2_2 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT2(REQ_F_AIRPORT2_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT2_3(ByVal REQ_F_AIRPORT2_3 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT2(REQ_F_AIRPORT2_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT2_4(ByVal REQ_F_AIRPORT2_4 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT2(REQ_F_AIRPORT2_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_AIRPORT2_5(ByVal REQ_F_AIRPORT2_5 As String, ByRef control As TextBox)
        SetForm_REQ_F_AIRPORT2(REQ_F_AIRPORT2_5, control)
    End Sub

    '復路：出発時刻（依頼）
    Public Shared Sub SetForm_REQ_F_TIME1(ByVal REQ_F_TIME1 As String, ByRef control As Label)
        control.Text = CommonLib.CmnModule.Format_Date(REQ_F_TIME1, CmnModule.DateFormatType.HHMM)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME1_1(ByVal REQ_F_TIME1_1 As String, ByRef control As Label)
        SetForm_REQ_F_TIME1(REQ_F_TIME1_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME1_2(ByVal REQ_F_TIME1_2 As String, ByRef control As Label)
        SetForm_REQ_F_TIME1(REQ_F_TIME1_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME1_3(ByVal REQ_F_TIME1_3 As String, ByRef control As Label)
        SetForm_REQ_F_TIME1(REQ_F_TIME1_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME1_4(ByVal REQ_F_TIME1_4 As String, ByRef control As Label)
        SetForm_REQ_F_TIME1(REQ_F_TIME1_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME1_5(ByVal REQ_F_TIME1_5 As String, ByRef control As Label)
        SetForm_REQ_F_TIME1(REQ_F_TIME1_5, control)
    End Sub

    '復路：到着時刻（依頼）
    Public Shared Sub SetForm_REQ_F_TIME2(ByVal REQ_F_TIME2 As String, ByRef control As Label)
        control.Text = CommonLib.CmnModule.Format_Date(REQ_F_TIME2, CmnModule.DateFormatType.HHMM)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME2_1(ByVal REQ_F_TIME2_1 As String, ByRef control As Label)
        SetForm_REQ_F_TIME2(REQ_F_TIME2_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME2_2(ByVal REQ_F_TIME2_2 As String, ByRef control As Label)
        SetForm_REQ_F_TIME2(REQ_F_TIME2_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME2_3(ByVal REQ_F_TIME2_3 As String, ByRef control As Label)
        SetForm_REQ_F_TIME2(REQ_F_TIME2_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME2_4(ByVal REQ_F_TIME2_4 As String, ByRef control As Label)
        SetForm_REQ_F_TIME2(REQ_F_TIME2_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_TIME2_5(ByVal REQ_F_TIME2_5 As String, ByRef control As Label)
        SetForm_REQ_F_TIME2(REQ_F_TIME2_5, control)
    End Sub

    '復路：列車・便名（依頼）
    Public Shared Sub SetForm_REQ_F_BIN(ByVal REQ_F_BIN As String, ByRef control As TextBox)
        control.Text = CommonLib.CmnModule.Format_Date(REQ_F_BIN, CmnModule.DateFormatType.HHMM)
    End Sub
    Public Shared Sub SetForm_REQ_F_BIN_1(ByVal REQ_F_BIN_1 As String, ByRef control As TextBox)
        SetForm_REQ_F_BIN(REQ_F_BIN_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_BIN_2(ByVal REQ_F_BIN_2 As String, ByRef control As TextBox)
        SetForm_REQ_F_BIN(REQ_F_BIN_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_BIN_3(ByVal REQ_F_BIN_3 As String, ByRef control As TextBox)
        SetForm_REQ_F_BIN(REQ_F_BIN_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_BIN_4(ByVal REQ_F_BIN_4 As String, ByRef control As TextBox)
        SetForm_REQ_F_BIN(REQ_F_BIN_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_BIN_5(ByVal REQ_F_BIN_5 As String, ByRef control As TextBox)
        SetForm_REQ_F_BIN(REQ_F_BIN_5, control)
    End Sub

    '復路：座席区分（依頼）
    Public Shared Sub SetForm_REQ_F_SEAT(ByVal REQ_F_SEAT As String, ByRef control As Label)
        control.Text = GetName_REQ_F_SEAT(REQ_F_SEAT)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_1(ByVal REQ_F_SEAT_1 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT(REQ_F_SEAT_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_2(ByVal REQ_F_SEAT_2 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT(REQ_F_SEAT_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_3(ByVal REQ_F_SEAT_3 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT(REQ_F_SEAT_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_4(ByVal REQ_F_SEAT_4 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT(REQ_F_SEAT_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_5(ByVal REQ_F_SEAT_5 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT(REQ_F_SEAT_5, control)
    End Sub

    '復路：座席位置（依頼）
    Public Shared Sub SetForm_REQ_F_SEAT_KIBOU(ByVal REQ_F_SEAT_KIBOU As String, ByRef control As Label)
        control.Text = GetName_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_KIBOU1(ByVal REQ_F_SEAT_KIBOU1 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU1, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_KIBOU2(ByVal REQ_F_SEAT_KIBOU2 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU2, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_KIBOU3(ByVal REQ_F_SEAT_KIBOU3 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU3, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_KIBOU4(ByVal REQ_F_SEAT_KIBOU4 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU4, control)
    End Sub
    Public Shared Sub SetForm_REQ_F_SEAT_KIBOU5(ByVal REQ_F_SEAT_KIBOU5 As String, ByRef control As Label)
        SetForm_REQ_F_SEAT_KIBOU(REQ_F_SEAT_KIBOU5, control)
    End Sub

    '往路：ステータス（回答）
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

    '往路：交通機関（回答）
    Public Shared Sub SetForm_ANS_O_KOTSUKIKAN(ByVal ANS_O_KOTSUKIKAN As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_O_KOTSUKIKAN, control, True)
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

    '往路：利用日（回答）
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

    '往路：出発地（回答）
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

    '往路：到着地（回答）
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

    '往路：出発時間（回答）
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

    '往路：到着時間（回答）
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

    '往路：列車名・便名（回答）
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

    '往路：座席希望（回答）
    Public Shared Sub SetForm_ANS_O_SEAT_KIBOU(ByVal ANS_O_SEAT_KIBOU As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_O_SEAT_KIBOU, control, True)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_KIBOU1(ByVal ANS_O_SEAT_KIBOU1 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_KIBOU1, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_KIBOU2(ByVal ANS_O_SEAT_KIBOU2 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_KIBOU2, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_KIBOU3(ByVal ANS_O_SEAT_KIBOU3 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_KIBOU3, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_KIBOU4(ByVal ANS_O_SEAT_KIBOU4 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_KIBOU4, control)
    End Sub
    Public Shared Sub SetForm_ANS_O_SEAT_KIBOU5(ByVal ANS_O_SEAT_KIBOU5 As String, ByRef control As DropDownList)
        SetForm_ANS_O_SEAT(ANS_O_SEAT_KIBOU5, control)
    End Sub

    '往路：座席区分（回答）
    Public Shared Sub SetForm_ANS_O_SEAT(ByVal ANS_O_SEAT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_O_SEAT, control, True)
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

    '復路：ステータス（回答）
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

    '復路：交通機関（回答）
    Public Shared Sub SetForm_ANS_F_KOTSUKIKAN(ByVal ANS_F_KOTSUKIKAN As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_F_KOTSUKIKAN, control, True)
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

    '復路：利用日（回答）
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

    '復路：出発地（回答）
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

    '復路：到着地（回答）
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

    '復路：出発時間（回答）
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

    '復路：到着時間（回答）
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

    '復路：列車名・便名（回答）
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

    '復路：座席区分（回答）
    Public Shared Sub SetForm_ANS_F_SEAT(ByVal ANS_F_SEAT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_F_SEAT, control, True)
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

    '復路：座席希望（回答）
    Public Shared Sub SetForm_ANS_F_SEAT_KIBOU(ByVal ANS_F_SEAT_KIBOU As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_F_SEAT_KIBOU, control, True)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_KIBOU1(ByVal ANS_F_SEAT_KIBOU1 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_KIBOU1, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_KIBOU2(ByVal ANS_F_SEAT_KIBOU2 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_KIBOU2, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_KIBOU3(ByVal ANS_F_SEAT_KIBOU3 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_KIBOU3, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_KIBOU4(ByVal ANS_F_SEAT_KIBOU4 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_KIBOU4, control)
    End Sub
    Public Shared Sub SetForm_ANS_F_SEAT_KIBOU5(ByVal ANS_F_SEAT_KIBOU5 As String, ByRef control As DropDownList)
        SetForm_ANS_F_SEAT(ANS_F_SEAT_KIBOU5, control)
    End Sub

    '交通備考（依頼）
    Public Shared Sub SetForm_REQ_KOTSU_BIKO(ByVal REQ_KOTSU_BIKO As String, ByRef control As TextBox)
        control.Text = REQ_KOTSU_BIKO
    End Sub

    '交通備考（回答）
    Public Shared Sub SetForm_ANS_KOTSU_BIKO(ByVal ANS_KOTSU_BIKO As String, ByRef control As TextBox)
        control.Text = ANS_KOTSU_BIKO
    End Sub

    '【確定】JR・鉄道代金
    Public Shared Sub SetForm_FIX_RAIL_FARE(ByVal FIX_RAIL_FARE As String, ByRef control As TextBox)
        control.Text = FIX_RAIL_FARE
    End Sub

    '【確定】JR・鉄道取消料
    Public Shared Sub SetForm_FIX_RAIL_CANCELLATION(ByVal FIX_RAIL_CANCELLATION As String, ByRef control As TextBox)
        control.Text = FIX_RAIL_CANCELLATION
    End Sub

    '【確定】航空券代金
    Public Shared Sub SetForm_FIX_AIR_FARE(ByVal FIX_AIR_FARE As String, ByRef control As TextBox)
        control.Text = FIX_AIR_FARE
    End Sub

    '【確定】航空券取消料
    Public Shared Sub SetForm_FIX_AIR_CANCELLATION(ByVal FIX_AIR_CANCELLATION As String, ByRef control As TextBox)
        control.Text = FIX_AIR_CANCELLATION
    End Sub

    '【確定】バス・船等代金
    Public Shared Sub SetForm_FIX_OTHER_FARE(ByVal FIX_OTHER_FARE As String, ByRef control As TextBox)
        control.Text = FIX_OTHER_FARE
    End Sub

    '【確定】バス・船等取消料
    Public Shared Sub SetForm_FIX_OTHER_CANCELLATION(ByVal FIX_OTHER_CANCELLATION As String, ByRef control As TextBox)
        control.Text = FIX_OTHER_CANCELLATION
    End Sub

    '【回答】手数料(交通・宿泊)
    Public Shared Sub SetForm_ANS_KOTSUHOTEL_TESURYO(ByVal ANS_KOTSUHOTEL_TESURYO As String, ByRef control As CheckBox)
        If Val(ANS_KOTSUHOTEL_TESURYO) <> 0 Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub

    '【回答】手数料(タクチケ発券手数料)
    Public Shared Sub SetForm_ANS_TAXI_TESURYO(ByVal ANS_TAXI_TESURYO As String, ByRef control As Label)
        If ANS_TAXI_TESURYO = "" Then
            control.Text = "0"
        Else
            control.Text = CmnModule.EditComma(ANS_TAXI_TESURYO)
        End If
    End Sub

    'タクチケ発行枚数
    Public Shared Sub SetForm_ANS_TAXI_MAISUU(ByVal ANS_TAXI_TESURYO As String, ByRef control As TextBox, ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection)
        If Double.Parse(GetName_TAXI_TESURYO(FROM_DATE, dbConn)) = 0 OrElse Val(ANS_TAXI_TESURYO) = 0 Then
            control.Text = String.Empty
        Else
            'タクチケ発券手数料÷タクチケ発券手数料単価を切り上げ
            control.Text = Math.Ceiling(Double.Parse(ANS_TAXI_TESURYO) / Double.Parse(GetName_TAXI_TESURYO(FROM_DATE, dbConn))).ToString
        End If
    End Sub

    '登録管理手数料
    Public Shared Sub SetForm_TOUROKUKANRI_FEE(ByVal TOUROKUKANRI_FEE As String, ByRef control As TextBox)
        control.Text = TOUROKUKANRI_FEE
    End Sub

    'タクチケ発券手数料
    Public Shared Sub SetForm_TAXI_HAKKEN_FEE(ByVal TAXI_HAKKEN_FEE As String, ByRef control As TextBox)
        control.Text = TAXI_HAKKEN_FEE
    End Sub

    'タクチケ精算手数料
    Public Shared Sub SetForm_TAXI_SEISAN_FEE(ByVal TAXI_SEISAN_FEE As String, ByRef control As TextBox)
        control.Text = TAXI_SEISAN_FEE
    End Sub

    'タクシーチケット：手配（依頼）
    Public Shared Sub SetForm_TEHAI_TAXI(ByVal TEHAI_TAXI As String, ByRef control As Label)
        control.Text = GetName_TEHAI_TAXI(TEHAI_TAXI)
    End Sub

    'スキャニングデータ取込日
    Public Shared Sub SetForm_SCAN_IMPORT_DATE(ByVal SCAN_IMPORT_DATE As String, ByRef control As Label)
        control.Text = CommonLib.CmnModule.Format_Date(SCAN_IMPORT_DATE, CmnModule.DateFormatType.YYYYMMDD)
    End Sub

    'タクシーチケット：利用日（依頼）
    Public Shared Sub SetForm_REQ_TAXI_DATE(ByVal REQ_TAXI_DATE As String, ByRef control As Label)
        Dim wStr As String = ""
        wStr = CmnModule.Format_Date(Trim(REQ_TAXI_DATE), CmnModule.DateFormatType.YYYYMMDD) _
             & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(REQ_TAXI_DATE), CmnModule.DateFormatType.YYYYMMDD), True)
        control.Text = wStr
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_1(ByVal REQ_TAXI_DATE_1 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_2(ByVal REQ_TAXI_DATE_2 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_3(ByVal REQ_TAXI_DATE_3 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_4(ByVal REQ_TAXI_DATE_4 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_5(ByVal REQ_TAXI_DATE_5 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_5, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_6(ByVal REQ_TAXI_DATE_6 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_6, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_7(ByVal REQ_TAXI_DATE_7 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_7, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_8(ByVal REQ_TAXI_DATE_8 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_8, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_9(ByVal REQ_TAXI_DATE_9 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_9, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_DATE_10(ByVal REQ_TAXI_DATE_10 As String, ByRef control As Label)
        SetForm_REQ_TAXI_DATE(REQ_TAXI_DATE_10, control)
    End Sub

    'タクシーチケット：発地（依頼）
    Public Shared Sub SetForm_REQ_TAXI_FROM(ByVal REQ_TAXI_FROM As String, ByRef control As TextBox)
        control.Text = REQ_TAXI_FROM
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_1(ByVal REQ_TAXI_FROM_1 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_1, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_2(ByVal REQ_TAXI_FROM_2 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_2, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_3(ByVal REQ_TAXI_FROM_3 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_3, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_4(ByVal REQ_TAXI_FROM_4 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_4, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_5(ByVal REQ_TAXI_FROM_5 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_5, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_6(ByVal REQ_TAXI_FROM_6 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_6, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_7(ByVal REQ_TAXI_FROM_7 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_7, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_8(ByVal REQ_TAXI_FROM_8 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_8, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_9(ByVal REQ_TAXI_FROM_9 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_9, control)
    End Sub
    Public Shared Sub SetForm_REQ_TAXI_FROM_10(ByVal REQ_TAXI_FROM_10 As String, ByRef control As TextBox)
        SetForm_REQ_TAXI_FROM(REQ_TAXI_FROM_10, control)
    End Sub

    'タクシーチケット：予定金額（依頼）
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU(ByVal TAXI_YOTEIKINGAKU As String, ByRef control As Label)
        control.Text = GetName_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_1(ByVal TAXI_YOTEIKINGAKU_1 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_1, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_2(ByVal TAXI_YOTEIKINGAKU_2 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_2, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_3(ByVal TAXI_YOTEIKINGAKU_3 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_3, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_4(ByVal TAXI_YOTEIKINGAKU_4 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_4, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_5(ByVal TAXI_YOTEIKINGAKU_5 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_5, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_6(ByVal TAXI_YOTEIKINGAKU_6 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_6, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_7(ByVal TAXI_YOTEIKINGAKU_7 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_7, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_8(ByVal TAXI_YOTEIKINGAKU_8 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_8, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_9(ByVal TAXI_YOTEIKINGAKU_9 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_9, control)
    End Sub
    Public Shared Sub SetForm_TAXI_YOTEIKINGAKU_10(ByVal TAXI_YOTEIKINGAKU_10 As String, ByRef control As Label)
        SetForm_TAXI_YOTEIKINGAKU(TAXI_YOTEIKINGAKU_10, control)
    End Sub

    'タクシーチケット：利用日（回答）
    Public Shared Sub SetForm_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        control.Text = ANS_TAXI_DATE
        If ANS_TAXI_HAKKO_DATE.Trim <> "" Then
            control.Enabled = False
        Else
            control.Enabled = True
        End If
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_1(ByVal ANS_TAXI_DATE_1 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_1, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_2(ByVal ANS_TAXI_DATE_2 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_2, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_3(ByVal ANS_TAXI_DATE_3 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_3, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_4(ByVal ANS_TAXI_DATE_4 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_4, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_5(ByVal ANS_TAXI_DATE_5 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_5, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_6(ByVal ANS_TAXI_DATE_6 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_6, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_7(ByVal ANS_TAXI_DATE_7 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_7, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_8(ByVal ANS_TAXI_DATE_8 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_8, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_9(ByVal ANS_TAXI_DATE_9 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_9, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_10(ByVal ANS_TAXI_DATE_10 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_10, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_11(ByVal ANS_TAXI_DATE_11 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_11, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_12(ByVal ANS_TAXI_DATE_12 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_12, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_13(ByVal ANS_TAXI_DATE_13 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_13, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_14(ByVal ANS_TAXI_DATE_14 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_14, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_15(ByVal ANS_TAXI_DATE_15 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_15, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_16(ByVal ANS_TAXI_DATE_16 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_16, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_17(ByVal ANS_TAXI_DATE_17 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_17, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_18(ByVal ANS_TAXI_DATE_18 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_18, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_19(ByVal ANS_TAXI_DATE_19 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_19, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_DATE_20(ByVal ANS_TAXI_DATE_20 As String, ByRef control As TextBox, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_DATE(ANS_TAXI_DATE_20, control, ANS_TAXI_HAKKO_DATE)
    End Sub

    'タクシーチケット：券種（回答）
    Public Shared Sub SetForm_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_TAXI_KENSHU, control, True)
        If ANS_TAXI_HAKKO_DATE.Trim <> "" Then
            control.Enabled = False
        Else
            control.Enabled = True
        End If
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_1(ByVal ANS_TAXI_KENSHU_1 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_1, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_2(ByVal ANS_TAXI_KENSHU_2 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_2, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_3(ByVal ANS_TAXI_KENSHU_3 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_3, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_4(ByVal ANS_TAXI_KENSHU_4 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_4, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_5(ByVal ANS_TAXI_KENSHU_5 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_5, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_6(ByVal ANS_TAXI_KENSHU_6 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_6, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_7(ByVal ANS_TAXI_KENSHU_7 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_7, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_8(ByVal ANS_TAXI_KENSHU_8 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_8, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_9(ByVal ANS_TAXI_KENSHU_9 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_9, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_10(ByVal ANS_TAXI_KENSHU_10 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_10, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_11(ByVal ANS_TAXI_KENSHU_11 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_11, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_12(ByVal ANS_TAXI_KENSHU_12 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_12, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_13(ByVal ANS_TAXI_KENSHU_13 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_13, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_14(ByVal ANS_TAXI_KENSHU_14 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_14, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_15(ByVal ANS_TAXI_KENSHU_15 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_15, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_16(ByVal ANS_TAXI_KENSHU_16 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_16, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_17(ByVal ANS_TAXI_KENSHU_17 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_17, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_18(ByVal ANS_TAXI_KENSHU_18 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_18, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_19(ByVal ANS_TAXI_KENSHU_19 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_19, control, ANS_TAXI_HAKKO_DATE)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_KENSHU_20(ByVal ANS_TAXI_KENSHU_20 As String, ByRef control As DropDownList, ByVal ANS_TAXI_HAKKO_DATE As String)
        SetForm_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_20, control, ANS_TAXI_HAKKO_DATE)
    End Sub

    'タクシーチケット：番号（回答）
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
    Public Shared Sub SetForm_ANS_TAXI_NO_11(ByVal ANS_TAXI_NO_11 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_11, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_12(ByVal ANS_TAXI_NO_12 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_12, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_13(ByVal ANS_TAXI_NO_13 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_13, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_14(ByVal ANS_TAXI_NO_14 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_14, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_15(ByVal ANS_TAXI_NO_15 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_15, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_16(ByVal ANS_TAXI_NO_16 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_16, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_17(ByVal ANS_TAXI_NO_17 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_17, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_18(ByVal ANS_TAXI_NO_18 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_18, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_19(ByVal ANS_TAXI_NO_19 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_19, control)
    End Sub
    Public Shared Sub SetForm_ANS_TAXI_NO_20(ByVal ANS_TAXI_NO_20 As String, ByRef control As TextBox)
        SetForm_ANS_TAXI_NO(ANS_TAXI_NO_20, control)
    End Sub

    'タクチケ備考（依頼）
    Public Shared Sub SetForm_REQ_TAXI_NOTE(ByVal REQ_TAXI_NOTE As String, ByRef control As TextBox)
        control.Text = REQ_TAXI_NOTE
    End Sub

    'タクチケ備考（回答）
    Public Shared Sub SetForm_ANS_TAXI_NOTE(ByVal ANS_TAXI_NOTE As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_NOTE
    End Sub

    '社員用往路隣席希望（依頼）
    Public Shared Sub SetForm_REQ_MR_O_TEHAI(ByVal REQ_MR_O_TEHAI As String, ByRef control As Label)
        control.Text = GetName_REQ_MR_O_TEHAI(REQ_MR_O_TEHAI)
    End Sub

    '社員用往路隣席希望（回答）
    Public Shared Sub SetForm_ANS_MR_O_TEHAI(ByVal ANR_MR_O_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANR_MR_O_TEHAI, control, True)
    End Sub

    '社員用復路隣席希望（依頼）
    Public Shared Sub SetForm_REQ_MR_F_TEHAI(ByVal REQ_MR_F_TEHAI As String, ByRef control As Label)
        control.Text = GetName_REQ_MR_F_TEHAI(REQ_MR_F_TEHAI)
    End Sub

    '社員用復路隣席希望（回答）
    Public Shared Sub SetForm_ANS_MR_F_TEHAI(ByVal ANS_MR_F_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ANS_MR_F_TEHAI, control, True)
    End Sub

    'MR性別
    Public Shared Sub SetForm_MR_SEX(ByVal MR_SEX As String, ByRef control As Label)
        control.Text = GetName_MR_SEX(MR_SEX)
    End Sub

    'MR年齢
    Public Shared Sub SetForm_MR_AGE(ByVal MR_AGE As String, ByRef control As Label)
        control.Text = MR_AGE
    End Sub

    '宿泊費(税込)
    Public Shared Sub SetForm_ANS_HOTELHI(ByVal ANS_HOTLHI As String, ByRef control As TextBox)
        control.Text = ANS_HOTLHI
    End Sub

    '宿泊費都税
    Public Shared Sub SetForm_ANS_HOTELHI_TOZEI(ByVal ANS_HOTLHI_TOZEI As String, ByRef control As TextBox)
        control.Text = ANS_HOTLHI_TOZEI
    End Sub

    '宿泊費都税
    Public Shared Sub SetForm_ANS_HOTELHI_CANCEL(ByVal ANS_HOTELHI_CANCEL As String, ByRef control As TextBox)
        control.Text = ANS_HOTELHI_CANCEL
    End Sub

    '社員用交通・宿泊備考（依頼）
    Public Shared Sub SetForm_REQ_MR_HOTEL_NOTE(ByVal REQ_MR_HOTEL_NOTE As String, ByRef control As TextBox)
        control.Text = REQ_MR_HOTEL_NOTE
    End Sub

    '社員用交通・宿泊備考（回答）
    Public Shared Sub SetForm_ANS_MR_HOTEL_NOTE(ByVal ANS_MR_HOTEL_NOTE As String, ByRef control As TextBox)
        control.Text = ANS_MR_HOTEL_NOTE
    End Sub

    'JR・鉄道代金（回答）
    Public Shared Sub SetForm_ANS_RAIL_FARE(ByVal ANS_RAIL_FARE As String, ByRef control As TextBox)
        control.Text = ANS_RAIL_FARE
    End Sub

    'JR・鉄道取消料（回答）
    Public Shared Sub SetForm_ANS_RAIL_CANCELLATION(ByVal RAIL_CANCELLATION As String, ByRef control As TextBox)
        control.Text = RAIL_CANCELLATION
    End Sub

    'その他鉄道等代金（回答）
    Public Shared Sub SetForm_ANS_OTHER_FARE(ByVal ANS_OTHER_FARE As String, ByRef control As TextBox)
        control.Text = ANS_OTHER_FARE
    End Sub

    'その他鉄道等取消料（回答）
    Public Shared Sub SetForm_ANS_OTHER_CANCELLATION(ByVal ANS_OTHER_CANCELLATION As String, ByRef control As TextBox)
        control.Text = ANS_OTHER_CANCELLATION
    End Sub

    '航空券代金（回答）
    Public Shared Sub SetForm_ANS_AIR_FARE(ByVal ANS_AIRL_FARE As String, ByRef control As TextBox)
        control.Text = ANS_AIRL_FARE
    End Sub

    '航空券取消料（回答）
    Public Shared Sub SetForm_ANS_AIR_CANCELLATION(ByVal ANS_AIR_CANCELLATION As String, ByRef control As TextBox)
        control.Text = ANS_AIR_CANCELLATION
    End Sub

    'MR交通費（回答）
    Public Shared Sub SetForm_ANS_MR_KOTSUHI(ByVal ANS_MR_KOTSUHI As String, ByRef control As TextBox)
        control.Text = ANS_MR_KOTSUHI
    End Sub

    'MR宿泊費（税込）（回答）
    Public Shared Sub SetForm_ANS_MR_HOTELHI(ByVal ANS_MR_HOTELHI As String, ByRef control As TextBox)
        control.Text = ANS_MR_HOTELHI
    End Sub

    'MR宿泊費都税（回答）
    Public Shared Sub SetForm_ANS_MR_HOTELHI_TOZEI(ByVal ANS_MR_HOTELHI_TOZEI As String, ByRef control As TextBox)
        control.Text = ANS_MR_HOTELHI_TOZEI
    End Sub
#End Region

#Region "会場手配回答登録画面　画面項目表示"
    '電話番号
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

    '携帯電話番号
    Public Shared Sub SetForm_KEITAI(ByVal KEITAI As String, ByRef control As TextBox)
        SetForm_TEL(KEITAI, control)
    End Sub
    Public Shared Sub SetForm_KEITAI(ByVal KEITAI As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox, ByRef control_3 As TextBox)
        SetForm_TEL(KEITAI, control_1, control_2, control_3)
    End Sub

    '郵便番号
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

    '都道府県
    Public Shared Sub SetForm_ADDRESS1(ByVal ADDRESS1 As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ADDRESS1, control)
    End Sub

    '住所
    Public Shared Sub SetForm_ADDRESS(ByVal ADDRESS As String, ByRef control As TextBox)
        control.Text = ADDRESS
    End Sub
    Public Shared Sub SetForm_ANS_SHISETSU_ADDRESS(ByVal ANS_SHISETSU_ADDRESS As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_ADDRESS
    End Sub

    '市町村
    Public Shared Sub SetForm_ADDRESS2(ByVal ADDRESS2 As String, ByRef control As TextBox)
        control.Text = ADDRESS2
    End Sub

    '施設名
    Public Shared Sub SetForm_SHISETSU_NAME(ByVal SHISETSU_NAME As String, ByRef control As TextBox)
        control.Text = SHISETSU_NAME
    End Sub
    Public Shared Sub SetForm_ANS_SHISETSU_NAME(ByVal ANS_SHISETSU_NAME As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_NAME
    End Sub

    '施設名(カナ)
    Public Shared Sub SetForm_SHISETSU_KANA(ByVal SHISETSU_KANA As String, ByRef control As TextBox)
        control.Text = SHISETSU_KANA
    End Sub

    '【回答】施設選定理由
    Public Shared Sub SetForm_ANS_SENTEI_RIYU(ByVal ANS_SENTEI_RIYU As String, ByRef control As TextBox)
        control.Text = ANS_SENTEI_RIYU
    End Sub

    '【回答】 開催地 (施設郵便番号)
    Public Shared Sub SetForm_ANS_SHISETSU_ZIP(ByVal ANS_SHISETSU_ZIP As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_ZIP
    End Sub

    '【回答】開催地(会合会場名)
    Public Shared Sub SetForm_ANS_KOUEN_KAIJO_NAME(ByVal ANS_KOUEN_KAIJO_NAME As String, ByRef control As TextBox)
        control.Text = ANS_KOUEN_KAIJO_NAME
    End Sub

    '【回答】開催地(会合会場フロア)
    Public Shared Sub SetForm_ANS_KOUEN_KAIJO_FLOOR(ByVal ANS_KOUEN_KAIJO_FLOOR As String, ByRef control As TextBox)
        control.Text = ANS_KOUEN_KAIJO_FLOOR
    End Sub

    '【回答】開催地(意見交換会場名)
    Public Shared Sub SetForm_ANS_IKENKOUKAN_KAIJO_NAME(ByVal ANS_IKENKOUKAN_KAIJO_NAME As String, ByRef control As TextBox)
        control.Text = ANS_IKENKOUKAN_KAIJO_NAME
    End Sub

    '【回答】開催地(慰労会会場名)
    Public Shared Sub SetForm_ANS_IROUKAI_KAIJO_NAME(ByVal ANS_IROUKAI_KAIJO_NAME As String, ByRef control As TextBox)
        control.Text = ANS_IROUKAI_KAIJO_NAME
    End Sub

    '【回答】開催地(講師控室会場名)
    Public Shared Sub SetForm_ANS_KOUSHI_ROOM_NAME(ByVal ANS_KOUSHI_ROOM_NAME As String, ByRef control As TextBox)
        control.Text = ANS_KOUSHI_ROOM_NAME
    End Sub

    '【回答】開催地(社員控室会場名)
    Public Shared Sub SetForm_ANS_SHAIN_ROOM_NAME(ByVal ANS_SHAIN_ROOM_NAME As String, ByRef control As TextBox)
        control.Text = ANS_SHAIN_ROOM_NAME
    End Sub

    '【回答】開催地(世話人会会場名)
    Public Shared Sub SetForm_ANS_MANAGER_KAIJO_NAME(ByVal ANS_MANAGER_KAIJO_NAME As String, ByRef control As TextBox)
        control.Text = ANS_MANAGER_KAIJO_NAME
    End Sub

    '【回答】開催地(備考欄)
    Public Shared Sub SetForm_ANS_KAISAI_NOTE(ByVal ANS_KAISAI_NOTE As String, ByRef control As TextBox)
        control.Text = ANS_KAISAI_NOTE
    End Sub

    '見積額（非課税）
    Public Shared Sub SetForm_ANS_MITSUMORI_TF(ByVal ANS_MITSUMORI_TF As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_TF
    End Sub

    '見積額（課税）
    Public Shared Sub SetForm_ANS_MITSUMORI_T(ByVal ANS_MITSUMORI_T As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_T
    End Sub

    '見積額（合計）
    Public Shared Sub SetForm_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_TOTAL
    End Sub
    Public Shared Sub SetForm_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_MITSUMORI_TOTAL(ANS_MITSUMORI_TOTAL, ShortFormat)
    End Sub

    '(回答)見積関連
    Public Shared Sub SetForm_ANS_KAIJOUHI_TF(ByVal ANS_KAIJOUHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_KAIJOUHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_KIZAIHI_TF(ByVal ANS_KIZAIHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_KIZAIHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_INSHOKUHI_TF(ByVal ANS_INSHOKUHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_INSHOKUHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_HOTELHI_TF(ByVal ANS_HOTELHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_HOTELHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_KOTSUHI_TF(ByVal ANS_KOTSUHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_KOTSUHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_TAXI_TF(ByVal ANS_TAXI_TF As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_TF
    End Sub

    Public Shared Sub SetForm_ANS_TEHAI_TESURYO_TF(ByVal ANS_TEHAI_TESURYO_TF As String, ByRef control As TextBox)
        control.Text = ANS_TEHAI_TESURYO_TF
    End Sub

    Public Shared Sub SetForm_ANS_TAXI_HAKKEN_TESURYO_TF(ByVal ANS_TAXI_HAKKEN_TESURYO_TF As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_HAKKEN_TESURYO_TF
    End Sub

    Public Shared Sub SetForm_ANS_TAXI_SEISAN_TESURYO_TF(ByVal ANS_TAXI_SEISAN_TESURYO_TF As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_SEISAN_TESURYO_TF
    End Sub

    Public Shared Sub SetForm_ANS_JINKENHI_TF(ByVal ANS_JINKENHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_JINKENHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_OTHER_TF(ByVal ANS_OTHER_TF As String, ByRef control As TextBox)
        control.Text = ANS_OTHER_TF
    End Sub

    Public Shared Sub SetForm_ANS_KANRIHI_TF(ByVal ANS_KANRIHI_TF As String, ByRef control As TextBox)
        control.Text = ANS_KANRIHI_TF
    End Sub

    Public Shared Sub SetForm_ANS_KAIJOUHI_T(ByVal ANS_KAIJOUHI_T As String, ByRef control As TextBox)
        control.Text = ANS_KAIJOUHI_T
    End Sub

    Public Shared Sub SetForm_ANS_KIZAIHI_T(ByVal ANS_KIZAIHI_T As String, ByRef control As TextBox)
        control.Text = ANS_KIZAIHI_T
    End Sub

    Public Shared Sub SetForm_ANS_INSHOKUHI_T(ByVal ANS_INSHOKUHI_T As String, ByRef control As TextBox)
        control.Text = ANS_INSHOKUHI_T
    End Sub

    Public Shared Sub SetForm_ANS_JINKENHI_T(ByVal ANS_JINKENHI_T As String, ByRef control As TextBox)
        control.Text = ANS_JINKENHI_T
    End Sub

    Public Shared Sub SetForm_ANS_OTHER_T(ByVal ANS_OTHER_T As String, ByRef control As TextBox)
        control.Text = ANS_OTHER_T
    End Sub

    Public Shared Sub SetForm_ANS_KANRIHI_T(ByVal ANS_KANRIHI_T As String, ByRef control As TextBox)
        control.Text = ANS_KANRIHI_T
    End Sub

    Public Shared Sub SetForm_ANS_991330401_TF(ByVal ANS_991330401_TF As String, ByRef control As TextBox)
        control.Text = ANS_991330401_TF
    End Sub
    Public Shared Sub SetForm_ANS_41120200_TF(ByVal ANS_41120200_TF As String, ByRef control As TextBox)
        control.Text = ANS_41120200_TF
    End Sub
    Public Shared Sub SetForm_ANS_TOTAL_TF(ByVal ANS_TOTAL_TF As String, ByRef control As TextBox)
        control.Text = ANS_TOTAL_TF
    End Sub
    Public Shared Sub SetForm_ANS_991330401_T(ByVal ANS_991330401_T As String, ByRef control As TextBox)
        control.Text = ANS_991330401_T
    End Sub
    Public Shared Sub SetForm_ANS_41120200_T(ByVal ANS_41120200_T As String, ByRef control As TextBox)
        control.Text = ANS_41120200_T
    End Sub
    Public Shared Sub SetForm_ANS_TOTAL_T(ByVal ANS_TOTAL_T As String, ByRef control As TextBox)
        control.Text = ANS_TOTAL_T
    End Sub
    Public Shared Sub SetForm_ANS_991330401_TF(ByVal ANS_991330401_TF As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_991330401_TF(ANS_991330401_TF, ShortFormat)
    End Sub
    Public Shared Sub SetForm_ANS_41120200_TF(ByVal ANS_41120200_TF As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_41120200_TF(ANS_41120200_TF, ShortFormat)
    End Sub
    Public Shared Sub SetForm_ANS_TOTAL_TF(ByVal ANS_TOTAL_TF As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_TOTAL_TF(ANS_TOTAL_TF, ShortFormat)
    End Sub
    Public Shared Sub SetForm_ANS_991330401_T(ByVal ANS_991330401_T As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_991330401_T(ANS_991330401_T, ShortFormat)
    End Sub
    Public Shared Sub SetForm_ANS_41120200_T(ByVal ANS_41120200_T As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_41120200_T(ANS_41120200_T, ShortFormat)
    End Sub
    Public Shared Sub SetForm_ANS_TOTAL_T(ByVal ANS_TOTAL_T As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_TOTAL_T(ANS_TOTAL_T, ShortFormat)
    End Sub

    '精算額（非課税）
    Public Shared Sub SetForm_ANS_SEISAN_TF(ByVal ANS_SEISAN_TF As String, ByRef control As TextBox)
        control.Text = ANS_SEISAN_TF
    End Sub

    '精算額（課税）
    Public Shared Sub SetForm_ANS_SEISAN_T(ByVal ANS_SEISAN_T As String, ByRef control As TextBox)
        control.Text = ANS_SEISAN_T
    End Sub

    '精算額（合計）
    Public Shared Sub SetForm_ANS_SEISAN_TOTAL(ByVal ANS_SEISAN_TF As String, ByVal ANS_SEISAN_T As String, ByRef control As Label, Optional ByVal ShortFormat As Boolean = False)
        control.Text = GetName_ANS_SEISAN_TOTAL(ANS_SEISAN_TF, ANS_SEISAN_T, ShortFormat)
    End Sub

    '開催希望地　（都道府県）
    Public Shared Sub SetForm_KAISAI_KIBOU_ADDRESS1(ByVal KAISAI_KIBOU_ADDRESS1 As String, ByRef control As TextBox)
        control.Text = KAISAI_KIBOU_ADDRESS1
    End Sub

    '開催希望地　（市町村）
    Public Shared Sub SetForm_KAISAI_KIBOU_ADDRESS2(ByVal KAISAI_KIBOU_ADDRESS2 As String, ByRef control As TextBox)
        control.Text = KAISAI_KIBOU_ADDRESS2
    End Sub

    '【確定】　開催地　（施設名）
    Public Shared Sub SetForm_FIX_KAISAI_SHISETSU(ByVal FIX_KAISAI_SHISETSU As String, ByRef control As TextBox)
        control.Text = FIX_KAISAI_SHISETSU
    End Sub

    '【確定】　開催地　（備考欄）
    Public Shared Sub SetForm_FIX_KAISAI_NOTE(ByVal FIX_KAISAI_NOTE As String, ByRef control As TextBox)
        control.Text = FIX_KAISAI_NOTE
    End Sub

    '【確定精算情報】　非課税
    Public Shared Sub SetForm_FIX_SEISAN_TF(ByVal FIX_SEISAN_TF As String, ByRef control As TextBox)
        control.Text = FIX_SEISAN_TF
    End Sub

    '【確定精算情報】　課税１　(社外）
    Public Shared Sub SetForm_FIX_SEISAN_GTAX(ByVal FIX_SEISAN_GTAX As String, ByRef control As TextBox)
        control.Text = FIX_SEISAN_GTAX
    End Sub

    '【確定精算情報】　課税１　(社内）
    Public Shared Sub SetForm_FIX_SEISAN_NTAX(ByVal FIX_SEISAN_NTAX As String, ByRef control As TextBox)
        control.Text = FIX_SEISAN_NTAX
    End Sub

    '利用額計
    Public Shared Sub SetForm_FIX_TOTAL(ByVal FIX_SEISAN_TF As String, ByVal FIX_SEISAN_GTAX As String, ByVal FIX_SEISAN_FTAX As String, ByRef control As TextBox)
        Dim wTOTAL As Long = 0
        wTOTAL = CmnModule.DbVal(FIX_SEISAN_TF) + CmnModule.DbVal(FIX_SEISAN_FTAX) + CmnModule.DbVal(FIX_SEISAN_GTAX)
        control.Text = wTOTAL
    End Sub

    '会場URL
    Public Shared Sub SetForm_KAIJO_URL(ByVal KAIJO_URL As String, ByRef control As TextBox)
        control.Text = KAIJO_URL
    End Sub

    '施設TEL
    Public Shared Sub SetForm_ANS_SHISETSU_TEL(ByVal ANS_SHISETSU_TEL As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_TEL
    End Sub

    '施設URL
    Public Shared Sub SetForm_ANS_SHISETSU_URL(ByVal ANS_SHISETSU_URL As String, ByRef control As TextBox)
        control.Text = ANS_SHISETSU_URL
    End Sub

    '見積算書　保存場所URL
    Public Shared Sub SetForm_ANS_MITSUMORI_URL(ByVal ANS_MITSUMORI_URL As String, ByRef control As TextBox)
        control.Text = ANS_MITSUMORI_URL
    End Sub

    '精算算書　保存場所URL
    Public Shared Sub SetForm_ANS_SEISANSHO_URL(ByVal ANS_SEISANSHO_URL As String, ByRef control As TextBox)
        control.Text = ANS_SEISANSHO_URL
    End Sub

    'ユーザマスタ：権限
    Public Shared Sub SetForm_KENGEN(ByVal KENGEN As String, ByRef control_Admin As RadioButton, ByRef control_User As RadioButton)
        If KENGEN = AppConst.MS_USER.KENGEN.Code.Admin Then
            control_Admin.Checked = True
            control_User.Checked = False
        ElseIf KENGEN = AppConst.MS_USER.KENGEN.Code.User Then
            control_Admin.Checked = False
            control_User.Checked = True
        Else
            control_Admin.Checked = False
            control_User.Checked = False
        End If
    End Sub

    'ユーザマスタ：精算入力
    Public Shared Sub SetForm_KENGEN_SEISAN(ByVal KENGEN_SEISAN As String, ByRef control As CheckBox)
        If KENGEN_SEISAN = AppConst.MS_USER.KENGEN_SEISAN.Code.Yes Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub

    '施設マスタ：チェックイン時間
    Public Shared Sub SetForm_CHECKIN_TIME(ByVal CHECKIN_TIME As String, ByRef control As TextBox)
        control.Text = CHECKIN_TIME
    End Sub
    Public Shared Sub SetForm_CHECKIN_TIME(ByVal CHECKIN_TIME As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox)
        Dim wCHECKIN_TIME_1 As String = ""
        Dim wCHECKIN_TIME_2 As String = ""
        If Trim(CHECKIN_TIME) = "" OrElse Trim(StrConv(CHECKIN_TIME, VbStrConv.Narrow)) = ":" Then
        Else
            Dim wSplit() As String
            If InStr(CHECKIN_TIME, ":") > 0 Then
                wSplit = Split(Trim(CHECKIN_TIME), ":")
                Try
                    wCHECKIN_TIME_1 = wSplit(0)
                    wCHECKIN_TIME_2 = wSplit(1)
                Catch ex As Exception
                    wCHECKIN_TIME_1 = ""
                    wCHECKIN_TIME_2 = ""
                End Try
            End If
        End If
        control_1.Text = wCHECKIN_TIME_1
        control_2.Text = wCHECKIN_TIME_2
    End Sub

    '施設マスタ：チェックアウト時間
    Public Shared Sub SetForm_CHECKOUT_TIME(ByVal CHECKOUT_TIME As String, ByRef control As TextBox)
        SetForm_CHECKIN_TIME(CHECKOUT_TIME, control)
    End Sub
    Public Shared Sub SetForm_CHECKOUT_TIME(ByVal CHECKOUT_TIME As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox)
        SetForm_CHECKIN_TIME(CHECKOUT_TIME, control_1, control_2)
    End Sub

    '施設マスタ：URL
    Public Shared Sub SetForm_URL(ByVal URL As String, ByRef control As TextBox)
        control.Text = URL
    End Sub

    '利用停止フラグ
    Public Shared Sub SetForm_STOP_FLG(ByVal STOP_FLG As String, ByRef control As CheckBox)
        If STOP_FLG = AppConst.STOP_FLG.Code.Stop Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub
#End Region

#Region "精算入力画面　画面項目表示"

    Public Shared Sub SetForm_SEISAN_KANRYO(ByVal SEISAN_KANRYO As String, ByRef control As CheckBox)
        If SEISAN_KANRYO = CmnConst.Flag.On Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub

#End Region

#Region "未決登録画面　画面項目表示"
    '会合開催日(From〜To)
    Public Shared Sub SetForm_JISSI_DATE(ByVal FROM_DATE As String, ByVal TO_DATE As String, ByRef control As Label)
        control.Text = AppModule.GetName_KOUENKAI_DATE(FROM_DATE, TO_DATE, True)
    End Sub

    '氏名
    Public Shared Sub SetForm_USER_NAME(ByVal USER_NAME As String, ByRef control As Label)
        control.Text = USER_NAME
    End Sub

    '行番号
    Public Shared Sub SetForm_TKT_LINE_NO(ByVal TKT_LINE_NO As String, ByRef control As Label)
        control.Text = TKT_LINE_NO
    End Sub

    'タクチケ番号
    Public Shared Sub SetForm_TKT_NO(ByVal TKT_NO As String, ByRef control As Label)
        control.Text = TKT_NO
    End Sub

    'タクシー会社
    Public Shared Sub SetForm_TKT_KAISHA(ByVal TKT_KAISHA As String, ByRef control As Label)
        control.Text = GetName_TKT_KAISHA(TKT_KAISHA)
    End Sub

    '券種
    Public Shared Sub SetForm_TKT_KENSHU(ByVal TKT_KENSHU As String, ByRef control As Label)
        control.Text = TKT_KENSHU
    End Sub

    '利用予定日
    Public Shared Sub SetForm_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
    End Sub

    '発行日
    Public Shared Sub SetForm_ANS_TAXI_HAKKO_DATE(ByVal ANS_TAXI_HAKKO_DATE As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(ANS_TAXI_HAKKO_DATE, CmnModule.DateFormatType.YYYYMMDD)
    End Sub

    'タクチケ備考
    Public Shared Sub SetForm_ANS_TAXI_RMKS(ByVal ANS_TAXI_RMKS As String, ByRef control As TextBox)
        control.Text = ANS_TAXI_RMKS
    End Sub

    'タクチケ発行フラグ
    Public Shared Sub SetForm_ANS_TAXI_HAKKO(ByVal ANS_TAXI_HAKKO As String, ByVal ANS_TAXI_HAKKO_DATE As String, ByRef control1 As Label, ByRef control2 As CheckBox)
        If ANS_TAXI_HAKKO_DATE.Trim <> "" Then
            control1.Visible = True
            control1.Text = "発行済"
            control2.Visible = False
        Else
            control1.Visible = False
            control2.Visible = True
            If ANS_TAXI_HAKKO = AppConst.KOTSUHOTEL.TAXI_HAKKO.Code.Mi OrElse ANS_TAXI_HAKKO.Trim = String.Empty Then
                control2.Checked = False
            Else
                control2.Checked = True
            End If
        End If
    End Sub

    '実車日
    Public Shared Sub SetForm_TKT_USED_DATE(ByVal TKT_USED_DATE As String, ByRef control As Label)
        control.Text = CmnModule.Format_Date(TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD)
    End Sub

    'VOID(日)
    Public Shared Sub SetForm_TKT_VOID(ByVal TKT_VOID As String, ByVal UPDATE_DATE As String, ByRef control As Label)
        If TKT_VOID = CmnConst.Flag.On Then
            control.Text = CmnModule.Format_Date(UPDATE_DATE, CmnModule.DateFormatType.YYYYMMDD)
        Else
            control.Text = ""
        End If
    End Sub

    'VOID
    Public Shared Sub SetForm_TKT_VOID(ByVal TKT_VOID As String, ByRef control As CheckBox)
        If TKT_VOID = CmnConst.Flag.On Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub

#End Region

#Region "== プルダウン設定 =="
#Region "BU"
    Public Shared Sub SetDropDownList_BU(ByRef BU As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With BU
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_BU.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_BU.Column.BU, RsData), CmnDb.DbData(TableDef.MS_BU.Column.BU, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
#End Region

#Region "エリア"
    Public Shared Sub SetDropDownList_AREA(ByRef AREA As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With AREA
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_AREA.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_AREA.Column.AREA, RsData), CmnDb.DbData(TableDef.MS_AREA.Column.AREA, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
#End Region

#Region "製品"
    Public Shared Sub SetDropDownList_SEIHIN(ByRef SEIHIN As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With SEIHIN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_SEIHIN.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_SEIHIN.Column.SEIHIN, RsData), CmnDb.DbData(TableDef.MS_SEIHIN.Column.SEIHIN, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
#End Region

#Region "TOP担当者"
    Public Shared Sub SetDropDownList_USER_NAME(ByRef USER_NAME As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With USER_NAME
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_USER.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_USER.Column.USER_NAME, RsData), CmnDb.DbData(TableDef.MS_USER.Column.LOGIN_ID, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
#End Region

#Region "手配ステータス"
    Public Shared Sub SetDropDownList_STATUS_TEHAI(ByRef STATUS_TEHAI As DropDownList, Optional ByVal KAIJO As Boolean = False)
        With STATUS_TEHAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            If KAIJO = False Then
                '宿泊交通
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Fuka, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Fuka))
            Else
                '会場
                .Items.Add(New ListItem(AppConst.KAIJO.STATUS_TEHAI.Name.Tehai, AppConst.KAIJO.STATUS_TEHAI.Code.Tehai))
                .Items.Add(New ListItem(AppConst.KAIJO.STATUS_TEHAI.Name.Change, AppConst.KAIJO.STATUS_TEHAI.Code.Change))
                .Items.Add(New ListItem(AppConst.KAIJO.STATUS_TEHAI.Name.Cancel, AppConst.KAIJO.STATUS_TEHAI.Code.Cancel))
            End If
        End With
    End Sub
#End Region

#Region "【依頼】手配ステータス"
    Public Shared Sub SetDropDownList_REQ_STATUS_TEHAI(ByRef REQ_STATUS_TEHAI As DropDownList, Optional ByVal KAIJO As Boolean = False)
        With REQ_STATUS_TEHAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            If KAIJO = False Then
                '宿泊交通
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Tehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Change, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Name.Cancel, AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel))
            Else
                '会場
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Mitsumori, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Mitsumori))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.NewRequest, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.NewRequest))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Change, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Change))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.Cancel, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.Cancel))
                .Items.Add(New ListItem(AppConst.KAIJO.REQ_STATUS_TEHAI.Name.After, AppConst.KAIJO.REQ_STATUS_TEHAI.Code.After))
            End If
        End With
    End Sub
#End Region

#Region "【回答】手配ステータス"
    Public Shared Sub SetDropDownList_ANS_STATUS_TEHAI(ByRef ANS_STATUS_TEHAI As DropDownList, Optional ByVal KAIJO As Boolean = False)
        With ANS_STATUS_TEHAI
            .Items.Clear()
            '.Items.Add(New ListItem("---", "0"))

            If KAIJO = False Then
                '宿泊交通
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.NewTehai, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NewTehai))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Uketsuke, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Prepare, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Prepare))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.OK, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.OK))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.TicketSend, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.TicketSend))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Canceled, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Canceled))
                .Items.Add(New ListItem(AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Name.Fuka, AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Fuka))
            Else
                '会場
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.NewTehai, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoSearch, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoSearch))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.UchiawaseSeisanUketsuke, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.UchiawaseSeisanUketsuke))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanUketsuke, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanUketsuke))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.TehaiFuka, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.TehaiFuka))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ShoninIrai, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.ShoninIrai))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoKettei, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoKettei))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanIrai, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanIrai))
                '.Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.SeisanZumi, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.SeisanZumi))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.NewTehai, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoSearch, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoSearch))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ShoninIrai, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.ShoninIrai))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.KaijoKettei, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.KaijoKettei))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.Cancel, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.Cancel))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.ToriatsukaiFuka, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.ToriatsukaiFuka))
                .Items.Add(New ListItem(AppConst.KAIJO.ANS_STATUS_TEHAI.Name.AkiNashi, AppConst.KAIJO.ANS_STATUS_TEHAI.Code.AkiNashi))
            End If
        End With
    End Sub
#End Region

#Region "宿泊ステータス（回答）"
    Public Shared Sub SetDropDownList_ANS_STATUS_HOTEL(ByRef ANS_STATUS_HOTEL As DropDownList)
        With ANS_STATUS_HOTEL
            .Items.Clear()
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.NewTehai, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.NewTehai))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Prepare, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.OK, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Canceled, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Canceled))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Name.Fuka, AppConst.KOTSUHOTEL.ANS_STATUS_HOTEL.Code.Fuka))
        End With
    End Sub
#End Region

#Region "宿泊部屋タイプ（回答）"
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
#End Region

#Region "宿泊ホテル喫煙（回答）"
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
#End Region

#Region "都道府県"
    Public Shared Sub SetDropDownList_ADDRESS1(ByRef ADDRESS1 As DropDownList)
        With ADDRESS1
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem("北海道", "北海道"))
            .Items.Add(New ListItem("青森県", "青森県"))
            .Items.Add(New ListItem("岩手県", "岩手県"))
            .Items.Add(New ListItem("宮城県", "宮城県"))
            .Items.Add(New ListItem("秋田県", "秋田県"))
            .Items.Add(New ListItem("山形県", "山形県"))
            .Items.Add(New ListItem("福島県", "福島県"))
            .Items.Add(New ListItem("茨城県", "茨城県"))
            .Items.Add(New ListItem("栃木県", "栃木県"))
            .Items.Add(New ListItem("群馬県", "群馬県"))
            .Items.Add(New ListItem("埼玉県", "埼玉県"))
            .Items.Add(New ListItem("千葉県", "千葉県"))
            .Items.Add(New ListItem("東京都", "東京都"))
            .Items.Add(New ListItem("神奈川県", "神奈川県"))
            .Items.Add(New ListItem("山梨県", "山梨県"))
            .Items.Add(New ListItem("静岡県", "静岡県"))
            .Items.Add(New ListItem("長野県", "長野県"))
            .Items.Add(New ListItem("岐阜県", "岐阜県"))
            .Items.Add(New ListItem("愛知県", "愛知県"))
            .Items.Add(New ListItem("三重県", "三重県"))
            .Items.Add(New ListItem("新潟県", "新潟県"))
            .Items.Add(New ListItem("富山県", "富山県"))
            .Items.Add(New ListItem("石川県", "石川県"))
            .Items.Add(New ListItem("福井県", "福井県"))
            .Items.Add(New ListItem("滋賀県", "滋賀県"))
            .Items.Add(New ListItem("京都府", "京都府"))
            .Items.Add(New ListItem("大阪府", "大阪府"))
            .Items.Add(New ListItem("兵庫県", "兵庫県"))
            .Items.Add(New ListItem("奈良県", "奈良県"))
            .Items.Add(New ListItem("和歌山県", "和歌山県"))
            .Items.Add(New ListItem("鳥取県", "鳥取県"))
            .Items.Add(New ListItem("島根県", "島根県"))
            .Items.Add(New ListItem("岡山県", "岡山県"))
            .Items.Add(New ListItem("広島県", "広島県"))
            .Items.Add(New ListItem("山口県", "山口県"))
            .Items.Add(New ListItem("徳島県", "徳島県"))
            .Items.Add(New ListItem("香川県", "香川県"))
            .Items.Add(New ListItem("愛媛県", "愛媛県"))
            .Items.Add(New ListItem("高知県", "高知県"))
            .Items.Add(New ListItem("福岡県", "福岡県"))
            .Items.Add(New ListItem("佐賀県", "佐賀県"))
            .Items.Add(New ListItem("長崎県", "長崎県"))
            .Items.Add(New ListItem("熊本県", "熊本県"))
            .Items.Add(New ListItem("大分県", "大分県"))
            .Items.Add(New ListItem("宮崎県", "宮崎県"))
            .Items.Add(New ListItem("鹿児島県", "鹿児島県"))
            .Items.Add(New ListItem("沖縄県", "沖縄県"))
        End With
    End Sub
#End Region

#Region "往路：ステータス（回答）"
    Public Shared Sub SetDropDownList_ANS_O_STATUS(ByRef ANS_O_STATUS As DropDownList)
        With ANS_O_STATUS
            .Items.Clear()

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.NewTehai, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.NewTehai))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Prepare, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.OK, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Daian, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Daian))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Canceled, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Canceled))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_O_STATUS.Name.Fuka, AppConst.KOTSUHOTEL.ANS_O_STATUS.Code.Fuka))
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
#End Region

#Region "往路：交通機関（回答）"
    Public Shared Sub SetDropDownList_ANS_O_KOTSUKIKAN(ByRef ANS_O_KOTSUKIKAN As DropDownList)
        With ANS_O_KOTSUKIKAN
            .Items.Clear()

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
#End Region

#Region "往路：座席区分（回答）"
    Public Shared Sub SetDropDownList_ANS_O_SEAT(ByRef ANS_O_SEAT As DropDownList)
        With ANS_O_SEAT
            .Items.Clear()

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
#End Region

#Region "往路：座席希望（回答）"
    Public Shared Sub SetDropDownList_ANS_O_SEAT_KIBOU(ByRef ANS_O_SEAT_KIBOU As DropDownList)
        With ANS_O_SEAT_KIBOU
            .Items.Clear()

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
#End Region

#Region "復路：ステータス（回答）"
    Public Shared Sub SetDropDownList_ANS_F_STATUS(ByRef ANS_F_STATUS As DropDownList)
        With ANS_F_STATUS
            .Items.Clear()

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.NewTehai, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.NewTehai))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Prepare, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.OK, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Daian, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Daian))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Canceled, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Canceled))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_F_STATUS.Name.Fuka, AppConst.KOTSUHOTEL.ANS_F_STATUS.Code.Fuka))
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
#End Region

#Region "復路：交通機関（回答）"
    Public Shared Sub SetDropDownList_ANS_F_KOTSUKIKAN(ByRef ANS_F_KOTSUKIKAN As DropDownList)
        With ANS_F_KOTSUKIKAN
            .Items.Clear()

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
#End Region

#Region "復路：座席区分（回答）"
    Public Shared Sub SetDropDownList_ANS_F_SEAT(ByRef ANS_F_SEAT As DropDownList)
        With ANS_F_SEAT
            .Items.Clear()

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
#End Region

#Region "復路：座席希望（回答）"
    Public Shared Sub SetDropDownList_ANS_F_SEAT_KIBOU(ByRef ANS_F_SEAT_KIBOU As DropDownList)
        With ANS_F_SEAT_KIBOU
            .Items.Clear()

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
#End Region

#Region "社員用往路手配（回答）"
    Public Shared Sub SetDropDownList_ANS_MR_O_TEHAI(ByRef ANS_MR_O_TEHAI As DropDownList)
        With ANS_MR_O_TEHAI
            .Items.Clear()

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.NewTehai, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.NewTehai))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Daian))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Canceled))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Fuka))
        End With
    End Sub
#End Region

#Region "社員用復路手配（回答）"
    Public Shared Sub SetDropDownList_ANS_MR_F_TEHAI(ByRef ANS_MR_F_TEHAI As DropDownList)
        With ANS_MR_F_TEHAI
            .Items.Clear()

            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.NewTehai, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.NewTehai))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Prepare))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.OK))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Daian))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Canceled))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Fuka))
        End With
    End Sub
#End Region

#Region "タクチケ券種（回答）"
    Public Shared Sub SetDropDownList_ANS_TAXI_KENSHU(ByRef ANS_TAXI_KENSHU As DropDownList)
        With ANS_TAXI_KENSHU
            .Items.Clear()

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TAXI_KENSHU Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
#End Region

#Region "新着一覧　区分"
    Public Shared Sub SetDropDownList_KUBUN(ByRef KUBUN As DropDownList, Optional ByVal KOTSUHOTEL As Boolean = False)
        With KUBUN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))
            .Items.Add(New ListItem("新規", "A"))
            .Items.Add(New ListItem("変更", "U"))

            If KOTSUHOTEL Then
                .Items.Add(New ListItem("取消", "C"))
            End If
        End With
    End Sub
#End Region

#Region "会合基本情報　ステータス"
    Public Shared Sub SetDropDownList_KIDOKU(ByRef KUBUN As DropDownList)
        With KUBUN
            .Items.Clear()
            .Items.Add(New ListItem(AppConst.KOUENKAI.KIDOKU_FLG.Name.No, AppConst.KOUENKAI.KIDOKU_FLG.Code.No))
            .Items.Add(New ListItem(AppConst.KOUENKAI.KIDOKU_FLG.Name.Yes, AppConst.KOUENKAI.KIDOKU_FLG.Code.Yes))

        End With
    End Sub
#End Region

#Region "参加/不参加　区分"
    Public Shared Sub SetDropDownList_DR_SANKA(ByRef KUBUN As DropDownList)
        With KUBUN
            .Items.Clear()
            .Items.Add(New ListItem("---", ""))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.DR_SANKA.Name.Yes, AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes))
            .Items.Add(New ListItem(AppConst.KOTSUHOTEL.DR_SANKA.Name.No, AppConst.KOTSUHOTEL.DR_SANKA.Code.No))
        End With
    End Sub
#End Region

#Region "ログ照会 画面名"
    '送受信ログ
    Public Class SetDropDownList_SYORI_NAME
        Public Shared Sub LogFile(ByRef SYORI_NAME As DropDownList)
            With SYORI_NAME
                .Items.Clear()
                .Items.Add(New ListItem("---", ""))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportKouenkai, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportKouenkai))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportKaijo, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportKaijo))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ExportKaijo, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ExportKaijo))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportKotsuHotel, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportKotsuHotel))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ExportKotsuHotel, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ExportKotsuHotel))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportSanka, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportSanka))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ExportSeisan, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ExportSeisan))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportSeisan, AppConst.TBL_LOG.SYORI_NAME.BATCH.Name.ImportSeisan))
            End With
        End Sub
        '操作ログ
        Public Shared Sub LogSousa(ByRef SYORI_NAME As DropDownList)
            With SYORI_NAME
                .Items.Clear()
                .Items.Add(New ListItem("---", ""))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KouenkaiRegist, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KouenkaiRegist))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.DrRegist, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.DrRegist))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KaijoRegist, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KaijoRegist))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.SeisanRegist, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.SeisanRegist))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.CostRegist, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.CostRegist))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstShisetsu, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstShisetsu))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstUser, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstUser))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCode, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCode))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCostcenter, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCostcenter))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiNouhinTorikomi, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiNouhinTorikomi))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiPrintCsv, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiPrintCsv))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiScan, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiScan))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMaintenance, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMaintenance))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJisseki, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJisseki))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiSeisanMikanryou, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiSeisanMikanryou))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMiketsu, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMiketsu))
                .Items.Add(New ListItem(AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMeisaiCsv, AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMeisaiCsv))
            End With
        End Sub
    End Class
#End Region

#Region "ログ照会 送受信"
    Public Shared Sub SetDropDownList_EXPORTIMPORT(ByRef EXPORTIMPORT As DropDownList)
        With EXPORTIMPORT
            .Items.Clear()
            .Items.Add(New ListItem("---", ""))
            .Items.Add(New ListItem(AppConst.TBL_LOG.EXPORTIMPORT.Name.IMPORT, AppConst.TBL_LOG.EXPORTIMPORT.Code.IMPORT))
            .Items.Add(New ListItem(AppConst.TBL_LOG.EXPORTIMPORT.Name.EXPORT, AppConst.TBL_LOG.EXPORTIMPORT.Code.EXPORT))
        End With
    End Sub
#End Region

#Region "ログ照会 結果"
    Public Class SetDropDownList_STATUS
        Public Shared Sub LogFile(ByRef STATUS As DropDownList)
            With STATUS
                .Items.Clear()
                .Items.Add(New ListItem("---", ""))
                .Items.Add(New ListItem(AppConst.TBL_LOG.STATUS.Name.OK, AppConst.TBL_LOG.STATUS.Code.OK))
                .Items.Add(New ListItem(AppConst.TBL_LOG.STATUS.Name.NG, AppConst.TBL_LOG.STATUS.Code.NG))
            End With
        End Sub
        Public Shared Sub LogSousa(ByRef STATUS As DropDownList)
            With STATUS
                .Items.Clear()
                .Items.Add(New ListItem("---", ""))
                .Items.Add(New ListItem(AppConst.TBL_LOG.STATUS.Name.OK, AppConst.TBL_LOG.STATUS.Code.OK))
                .Items.Add(New ListItem(AppConst.TBL_LOG.STATUS.Name.NG, AppConst.TBL_LOG.STATUS.Code.NG))
            End With
        End Sub
    End Class
#End Region

#Region "送信フラグ"
    Public Shared Sub SetDropDownList_SEND_FLAG(ByRef SEND_FLAG As DropDownList)
        With SEND_FLAG
            .Items.Clear()
            .Items.Add(New ListItem(AppConst.SEND_FLAG.Name.Mi, AppConst.SEND_FLAG.Code.Mi))
            .Items.Add(New ListItem(AppConst.SEND_FLAG.Name.Taisho, AppConst.SEND_FLAG.Code.Taisho))
            .Items.Add(New ListItem(AppConst.SEND_FLAG.Name.Sumi, AppConst.SEND_FLAG.Code.Sumi))
        End With
    End Sub
#End Region

#Region "コストセンターコード"
    Public Shared Sub SetDropDownList_COSTCENTER(ByRef COSTCENTER As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        With COSTCENTER
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            Dim strSQL As String
            Dim RsData As System.Data.SqlClient.SqlDataReader
            strSQL = SQL.MS_COSTCENTER.bySTOP_FLG(CmnConst.Flag.Off)
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_COSTCENTER.Column.COSTCENTER_CD, RsData), CmnDb.DbData(TableDef.MS_COSTCENTER.Column.COSTCENTER_CD, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
#End Region

#Region "承認区分"
    Public Shared Sub SetDropDownList_SHOUNIN_KUBUN(ByRef SHOUNIN_KUBUN As DropDownList)
        With SHOUNIN_KUBUN
            .Items.Clear()
            .Items.Add(New ListItem("---", ""))
            .Items.Add(New ListItem(AppConst.SEISAN.SHOUNIN_KUBUN.Name.Mi, AppConst.SEISAN.SHOUNIN_KUBUN.Code.Mi))
            .Items.Add(New ListItem(AppConst.SEISAN.SHOUNIN_KUBUN.Name.SHOUNIN, AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN))
            .Items.Add(New ListItem(AppConst.SEISAN.SHOUNIN_KUBUN.Name.HININ, AppConst.SEISAN.SHOUNIN_KUBUN.Code.HININ))
        End With
    End Sub
#End Region

#Region "SRM発注区分"
    Public Shared Sub SetDropDownList_SRM_HACYU_KBN(ByRef SRM_HACYU_KBN As DropDownList)
        With SRM_HACYU_KBN
            .Items.Clear()
            .Items.Add(New ListItem("---", ""))
            .Items.Add(New ListItem(AppConst.KAIJO.SRM_HACYU_KBN.Name.Yes, AppConst.KAIJO.SRM_HACYU_KBN.Code.Yes))
            .Items.Add(New ListItem(AppConst.KAIJO.SRM_HACYU_KBN.Name.No, AppConst.KAIJO.SRM_HACYU_KBN.Code.No))
        End With
    End Sub
#End Region

#End Region

#Region "== ラジオボタン設定 =="
#Region "タクシー会社"
    Public Shared Sub SetRadioButtonList_RDO_TAXI(ByRef RDO_TAXI As RadioButtonList)
        With RDO_TAXI
            .Items.Clear()

            Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
            Dim wStr As String = ""
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            For wCnt As Integer = 0 To MS_CODE.Count - 1
                If MS_CODE(wCnt).CODE = AppConst.MS_CODE.TAXI_KAISHA Then
                    .Items.Add(New ListItem(MS_CODE(wCnt).DISP_TEXT, MS_CODE(wCnt).DISP_VALUE))
                End If
            Next
        End With
    End Sub
#End Region
#End Region

#Region "== コントロールからDB用の値を返す =="
    'ログインID
    Public Shared Function GetValue_LOGIN_ID(ByVal LOGIN_ID As TextBox) As String
        Return Trim(StrConv(LOGIN_ID.Text, VbStrConv.Narrow))
    End Function

    'パスワード
    Public Shared Function GetValue_PASSWORD(ByVal PASSWORD As TextBox) As String
        Return Trim(StrConv(PASSWORD.Text, VbStrConv.Narrow))
    End Function

    '氏名
    Public Shared Function GetValue_USER_NAME(ByVal USER_NAME As TextBox) As String
        Return Trim(USER_NAME.Text)
    End Function

    '新着　既読フラグ
    Public Shared Function GetValue_KIDOKU_FLG(ByVal KIDOKU_FLG As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(KIDOKU_FLG)
    End Function

    '手配ステータス
    Public Shared Function GetValue_STATUS_TEHAI(ByVal STATUS_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(STATUS_TEHAI)
    End Function

    '【回答】手配ステータス
    Public Shared Function GetValue_ANS_STATUS_TEHAI(ByVal ANS_STATUS_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_STATUS_TEHAI, True)
    End Function

    '【回答】チケット類発送日
    Public Shared Function GetValue_ANS_TICKET_SEND_DAY(ByVal ANS_TICKET_SEND_DAY As TextBox) As String
        Return Trim(ANS_TICKET_SEND_DAY.Text)
    End Function

    '【回答】手配ステータス
    Public Shared Function GetValue_ANS_STATUS_HOTEL(ByVal ANS_STATUS_HOTEL As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_STATUS_HOTEL)
    End Function

    '宿泊先（回答）
    Public Shared Function GetValue_ANS_HOTEL_NAME(ByVal ANS_HOTEL_NAME As TextBox) As String
        Return Trim(ANS_HOTEL_NAME.Text)
    End Function

    '宿泊先住所（回答）
    Public Shared Function GetValue_ANS_HOTEL_ADDRESS(ByVal ANS_HOTEL_ADDRESS As TextBox) As String
        Return Trim(ANS_HOTEL_ADDRESS.Text)
    End Function

    '宿泊先電話番号（回答）
    Public Shared Function GetValue_ANS_HOTEL_TEL(ByVal ANS_HOTEL_TEL As TextBox) As String
        Return Trim(ANS_HOTEL_TEL.Text)
    End Function

    '宿泊日（回答）
    Public Shared Function GetValue_ANS_HOTEL_DATE(ByVal ANS_HOTEL_DATE As TextBox) As String
        Return Trim(ANS_HOTEL_DATE.Text)
    End Function

    '泊数（回答）
    Public Shared Function GetValue_ANS_HAKUSU(ByVal ANS_HAKUSU As TextBox) As String
        Return Trim(ANS_HAKUSU.Text)
    End Function

    '宿泊先チェックイン時間（回答）
    Public Shared Function GetValue_ANS_CHECKIN_TIME(ByVal ANS_CHECKIN_TIME As TextBox) As String
        Return Trim(ANS_CHECKIN_TIME.Text)
    End Function

    '宿泊先チェックアウト時間（回答）
    Public Shared Function GetValue_ANS_CHECKOUT_TIME(ByVal ANS_CHECKOUT_TIME As TextBox) As String
        Return Trim(ANS_CHECKOUT_TIME.Text)
    End Function

    '宿泊部屋タイプ（回答）
    Public Shared Function GetValue_ANS_ROOM_TYPE(ByVal ANS_ROOM_TYPE As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_ROOM_TYPE, True)
    End Function

    '宿泊ホテル喫煙（回答）
    Public Shared Function GetValue_ANS_HOTEL_SMOKING(ByVal ANS_HOTEL_SMOKING As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_HOTEL_SMOKING, True)
    End Function

    '宿泊備考（回答）
    Public Shared Function GetValue_ANS_HOTEL_NOTE(ByVal ANS_HOTEL_NOTE As TextBox) As String
        Return Trim(ANS_HOTEL_NOTE.Text)
    End Function

    '往路：ステータス（回答）
    Public Shared Function GetValue_ANS_O_STATUS(ByVal ANS_O_STATUS As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_STATUS, True)
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

    '往路：交通機関（回答）
    Public Shared Function GetValue_ANS_O_KOTSUKIKAN(ByVal ANS_O_KOTSUKIKAN As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_KOTSUKIKAN, True)
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

    '往路：利用日（回答）
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

    '往路：出発地（回答）
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

    '往路：到着地（回答）
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

    '往路：出発時間（回答）
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

    '往路：到着時間（回答）
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

    '往路：列車名・便名（回答）
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

    '往路：座席区分（回答）
    Public Shared Function GetValue_ANS_O_SEAT(ByVal ANS_O_SEAT As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_SEAT, True)
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

    '往路：座席希望（回答）
    Public Shared Function GetValue_ANS_O_SEAT_KIBOU(ByVal ANS_O_SEAT_KIBOU As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_O_SEAT_KIBOU, True)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_KIBOU1(ByVal ANS_O_SEAT_KIBOU1 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_KIBOU1)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_KIBOU2(ByVal ANS_O_SEAT_KIBOU2 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_KIBOU2)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_KIBOU3(ByVal ANS_O_SEAT_KIBOU3 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_KIBOU3)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_KIBOU4(ByVal ANS_O_SEAT_KIBOU4 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_KIBOU4)
    End Function
    Public Shared Function GetValue_ANS_O_SEAT_KIBOU5(ByVal ANS_O_SEAT_KIBOU5 As DropDownList) As String
        Return GetValue_ANS_O_SEAT(ANS_O_SEAT_KIBOU5)
    End Function

    '復路：ステータス（回答）
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

    '復路：交通機関（回答）
    Public Shared Function GetValue_ANS_F_KOTSUKIKAN(ByVal ANS_F_KOTSUKIKAN As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_F_KOTSUKIKAN, True)
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

    '復路：利用日（回答）
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

    '復路：出発地（回答）
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

    '復路：到着地（回答）
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

    '復路：出発時間（回答）
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

    '復路：到着時間（回答）
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

    '復路：列車名・便名（回答）
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

    '復路：座席区分（回答）
    Public Shared Function GetValue_ANS_F_SEAT(ByVal ANS_F_SEAT As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_F_SEAT, True)
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

    '復路：座席希望（回答）
    Public Shared Function GetValue_ANS_F_SEAT_KIBOU(ByVal ANS_F_SEAT_KIBOU As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_F_SEAT_KIBOU, True)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_KIBOU1(ByVal ANS_F_SEAT_KIBOU1 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_KIBOU1)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_KIBOU2(ByVal ANS_F_SEAT_KIBOU2 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_KIBOU2)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_KIBOU3(ByVal ANS_F_SEAT_KIBOU3 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_KIBOU3)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_KIBOU4(ByVal ANS_F_SEAT_KIBOU4 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_KIBOU4)
    End Function
    Public Shared Function GetValue_ANS_F_SEAT_KIBOU5(ByVal ANS_F_SEAT_KIBOU5 As DropDownList) As String
        Return GetValue_ANS_F_SEAT(ANS_F_SEAT_KIBOU5)
    End Function

    '交通備考（回答）
    Public Shared Function GetValue_ANS_KOTSU_BIKO(ByVal ANS_KOTSU_BIKO As TextBox) As String
        Return Trim(ANS_KOTSU_BIKO.Text)
    End Function

    '復路備考（回答）
    Public Shared Function GetValue_ANS_F_NOTE_1(ByVal ANS_F_NOTE_1 As TextBox) As String
        Return Trim(ANS_F_NOTE_1.Text)
    End Function

    '宿泊費（税込）
    Public Shared Function GetValue_ANS_HOTELHI(ByVal ANS_HOTELHI As TextBox) As String
        Return Trim(StrConv(ANS_HOTELHI.Text, VbStrConv.Narrow))
    End Function

    '宿泊費都税
    Public Shared Function GetValue_ANS_HOTELHI_TOZEI(ByVal ANS_HOTELHI_TOZEI As TextBox) As String
        Return Trim(StrConv(ANS_HOTELHI_TOZEI.Text, VbStrConv.Narrow))
    End Function

    '宿泊費取消料
    Public Shared Function GetValue_ANS_HOTELHI_CANCEL(ByVal ANS_HOTELHI_CANCEL As TextBox) As String
        Return Trim(StrConv(ANS_HOTELHI_CANCEL.Text, VbStrConv.Narrow))
    End Function

    '【確定】JR・鉄道代金
    Public Shared Function GetValue_ANS_RAIL_FARE(ByVal ANS_RAIL_FARE As TextBox) As String
        Return Trim(StrConv(ANS_RAIL_FARE.Text, VbStrConv.Narrow))
    End Function

    '【確定】JR・鉄道取消料
    Public Shared Function GetValue_ANS_RAIL_CANCELLATION(ByVal ANS_RAIL_CANCELLATION As TextBox) As String
        Return Trim(StrConv(ANS_RAIL_CANCELLATION.Text, VbStrConv.Narrow))
    End Function

    '【確定】航空券代金
    Public Shared Function GetValue_ANS_AIR_FARE(ByVal ANS_AIR_FARE As TextBox) As String
        Return Trim(StrConv(ANS_AIR_FARE.Text, VbStrConv.Narrow))
    End Function

    '【確定】航空券取消料
    Public Shared Function GetValue_ANS_AIR_CANCELLATION(ByVal ANS_AIR_CANCELLATION As TextBox) As String
        Return Trim(StrConv(ANS_AIR_CANCELLATION.Text, VbStrConv.Narrow))
    End Function

    '【確定】バス・船等代金
    Public Shared Function GetValue_ANS_OTHER_FARE(ByVal ANS_OTHER_FARE As TextBox) As String
        Return Trim(StrConv(ANS_OTHER_FARE.Text, VbStrConv.Narrow))
    End Function

    '【確定】バス・船等取消料
    Public Shared Function GetValue_ANS_OTHER_CANCELLATION(ByVal ANS_OTHER_CANCELLATION As TextBox) As String
        Return Trim(StrConv(ANS_OTHER_CANCELLATION.Text, VbStrConv.Narrow))
    End Function

    '【回答】手数料(交通・宿泊)
    Public Shared Function GetValue_ANS_KOTSUHOTEL_TESURYO(ByVal ANS_KOTSUHOTEL_TESURYO As CheckBox, ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection) As String
        If ANS_KOTSUHOTEL_TESURYO.Checked Then
            Return GetName_TESURYO(FROM_DATE, dbConn)
        Else
            Return "0"
        End If
    End Function

    '【回答】手数料(タクチケ発券手数料)
    Public Shared Function GetValue_ANS_TAXI_TESURYO(ByVal ANS_TAXI_MAISUU As TextBox, ByVal FROM_DATE As String, ByVal dbConn As System.Data.SqlClient.SqlConnection) As String
        If ANS_TAXI_MAISUU.Text.Trim = String.Empty OrElse ANS_TAXI_MAISUU.Text.Trim = "0" Then
            Return "0"
            Exit Function
        End If

        Dim strZeiRate As String = AppModule.GetZeiRate(FROM_DATE, dbConn)
        Return (Double.Parse(Val(ANS_TAXI_MAISUU.Text)) * Double.Parse(AppModule.GetName_TAXI_TESURYO(FROM_DATE, dbConn))).ToString
    End Function

    '【回答】MR　交通費
    Public Shared Function GetValue_ANS_MR_KOTSUHI(ByVal ANS_MR_KOTSUHI As TextBox) As String
        Return Trim(StrConv(ANS_MR_KOTSUHI.Text, VbStrConv.Narrow))
    End Function

    '【回答】MR　宿泊費
    Public Shared Function GetValue_ANS_MR_HOTELHI(ByVal ANS_MR_HOTELHI As TextBox) As String
        Return Trim(StrConv(ANS_MR_HOTELHI.Text, VbStrConv.Narrow))
    End Function

    '【回答】MR　宿泊費都税
    Public Shared Function GetValue_ANS_MR_HOTELHI_TOZEI(ByVal ANS_MR_HOTELHI_TOZEI As TextBox) As String
        Return Trim(StrConv(ANS_MR_HOTELHI_TOZEI.Text, VbStrConv.Narrow))
    End Function

    '登録管理手数料
    Public Shared Function GetValue_TOUROKUKANRI_FEE(ByVal TOUROKUKANRI_FEE As TextBox) As String
        Return Trim(StrConv(TOUROKUKANRI_FEE.Text, VbStrConv.Narrow))
    End Function

    'タクチケ備考（回答）
    Public Shared Function GetValue_ANS_TAXI_NOTE(ByVal ANS_TAXI_NOTE As TextBox) As String
        Return Trim(ANS_TAXI_NOTE.Text)
    End Function

    'タクチケ発券手数料
    Public Shared Function GetValue_TAXI_HAKKEN_FEE(ByVal TAXI_HAKKEN_FEE As TextBox) As String
        Return Trim(StrConv(TAXI_HAKKEN_FEE.Text, VbStrConv.Narrow))
    End Function

    'タクチケ精算手数料
    Public Shared Function GetValue_TAXI_SEISAN_FEE(ByVal TAXI_SEISAN_FEE As TextBox) As String
        Return Trim(StrConv(TAXI_SEISAN_FEE.Text, VbStrConv.Narrow))
    End Function

    'タクシーチケット：番号（回答）
    Public Shared Function GetValue_ANS_TAXI_HAKKO(ByVal ANS_TAXI_HAKKO As CheckBox) As String
        If ANS_TAXI_HAKKO.Checked Then
            Return AppConst.KOTSUHOTEL.TAXI_HAKKO.Code.Taisho
        Else
            Return AppConst.KOTSUHOTEL.TAXI_HAKKO.Code.Mi
        End If
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_1(ByVal ANS_TAXI_HAKKO_1 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_2(ByVal ANS_TAXI_HAKKO_2 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_3(ByVal ANS_TAXI_HAKKO_3 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_4(ByVal ANS_TAXI_HAKKO_4 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_5(ByVal ANS_TAXI_HAKKO_5 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_6(ByVal ANS_TAXI_HAKKO_6 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_7(ByVal ANS_TAXI_HAKKO_7 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_8(ByVal ANS_TAXI_HAKKO_8 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_9(ByVal ANS_TAXI_HAKKO_9 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_10(ByVal ANS_TAXI_HAKKO_10 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_10)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_11(ByVal ANS_TAXI_HAKKO_11 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_11)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_12(ByVal ANS_TAXI_HAKKO_12 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_12)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_13(ByVal ANS_TAXI_HAKKO_13 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_13)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_14(ByVal ANS_TAXI_HAKKO_14 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_14)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_15(ByVal ANS_TAXI_HAKKO_15 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_15)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_16(ByVal ANS_TAXI_HAKKO_16 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_16)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_17(ByVal ANS_TAXI_HAKKO_17 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_17)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_18(ByVal ANS_TAXI_HAKKO_18 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_18)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_19(ByVal ANS_TAXI_HAKKO_19 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_19)
    End Function
    Public Shared Function GetValue_ANS_TAXI_HAKKO_20(ByVal ANS_TAXI_HAKKO_20 As CheckBox) As String
        Return GetValue_ANS_TAXI_HAKKO(ANS_TAXI_HAKKO_20)
    End Function

    'タクシーチケット：利用日（回答）
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
    Public Shared Function GetValue_ANS_TAXI_DATE_11(ByVal ANS_TAXI_DATE_11 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_11)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_12(ByVal ANS_TAXI_DATE_12 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_12)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_13(ByVal ANS_TAXI_DATE_13 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_13)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_14(ByVal ANS_TAXI_DATE_14 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_14)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_15(ByVal ANS_TAXI_DATE_15 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_15)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_16(ByVal ANS_TAXI_DATE_16 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_16)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_17(ByVal ANS_TAXI_DATE_17 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_17)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_18(ByVal ANS_TAXI_DATE_18 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_18)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_19(ByVal ANS_TAXI_DATE_19 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_19)
    End Function
    Public Shared Function GetValue_ANS_TAXI_DATE_20(ByVal ANS_TAXI_DATE_20 As TextBox) As String
        Return GetValue_ANS_TAXI_DATE(ANS_TAXI_DATE_20)
    End Function

    'タクシーチケット：券種（回答）
    Public Shared Function GetValue_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_TAXI_KENSHU, True)
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
    Public Shared Function GetValue_ANS_TAXI_KENSHU_11(ByVal ANS_TAXI_KENSHU_11 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_11)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_12(ByVal ANS_TAXI_KENSHU_12 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_12)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_13(ByVal ANS_TAXI_KENSHU_13 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_13)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_14(ByVal ANS_TAXI_KENSHU_14 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_14)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_15(ByVal ANS_TAXI_KENSHU_15 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_15)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_16(ByVal ANS_TAXI_KENSHU_16 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_16)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_17(ByVal ANS_TAXI_KENSHU_17 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_17)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_18(ByVal ANS_TAXI_KENSHU_18 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_18)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_19(ByVal ANS_TAXI_KENSHU_19 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_19)
    End Function
    Public Shared Function GetValue_ANS_TAXI_KENSHU_20(ByVal ANS_TAXI_KENSHU_20 As DropDownList) As String
        Return GetValue_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU_20)
    End Function

    'タクシーチケット：番号（回答）
    Public Shared Function GetValue_ANS_TAXI_NO(ByVal ANS_TAXI_NO As TextBox) As String
        Return Trim(ANS_TAXI_NO.Text)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_1(ByVal ANS_TAXI_NO_1 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_2(ByVal ANS_TAXI_NO_2 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_3(ByVal ANS_TAXI_NO_3 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_4(ByVal ANS_TAXI_NO_4 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_5(ByVal ANS_TAXI_NO_5 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_6(ByVal ANS_TAXI_NO_6 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_7(ByVal ANS_TAXI_NO_7 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_8(ByVal ANS_TAXI_NO_8 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_9(ByVal ANS_TAXI_NO_9 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_10(ByVal ANS_TAXI_NO_10 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_10)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_11(ByVal ANS_TAXI_NO_11 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_11)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_12(ByVal ANS_TAXI_NO_12 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_12)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_13(ByVal ANS_TAXI_NO_13 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_13)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_14(ByVal ANS_TAXI_NO_14 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_14)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_15(ByVal ANS_TAXI_NO_15 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_15)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_16(ByVal ANS_TAXI_NO_16 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_16)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_17(ByVal ANS_TAXI_NO_17 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_17)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_18(ByVal ANS_TAXI_NO_18 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_18)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_19(ByVal ANS_TAXI_NO_19 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_19)
    End Function
    Public Shared Function GetValue_ANS_TAXI_NO_20(ByVal ANS_TAXI_NO_20 As TextBox) As String
        Return GetValue_ANS_TAXI_NO(ANS_TAXI_NO_20)
    End Function

    'タクシーチケット：備考（回答）
    Public Shared Function GetValue_ANS_TAXI_RMKS(ByVal ANS_TAXI_RMKS As TextBox) As String
        Return Trim(ANS_TAXI_RMKS.Text)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_1(ByVal ANS_TAXI_RMKS_1 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_1)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_2(ByVal ANS_TAXI_RMKS_2 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_2)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_3(ByVal ANS_TAXI_RMKS_3 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_3)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_4(ByVal ANS_TAXI_RMKS_4 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_4)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_5(ByVal ANS_TAXI_RMKS_5 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_5)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_6(ByVal ANS_TAXI_RMKS_6 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_6)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_7(ByVal ANS_TAXI_RMKS_7 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_7)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_8(ByVal ANS_TAXI_RMKS_8 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_8)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_9(ByVal ANS_TAXI_RMKS_9 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_9)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_10(ByVal ANS_TAXI_RMKS_10 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_10)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_11(ByVal ANS_TAXI_RMKS_11 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_11)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_12(ByVal ANS_TAXI_RMKS_12 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_12)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_13(ByVal ANS_TAXI_RMKS_13 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_13)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_14(ByVal ANS_TAXI_RMKS_14 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_14)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_15(ByVal ANS_TAXI_RMKS_15 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_15)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_16(ByVal ANS_TAXI_RMKS_16 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_16)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_17(ByVal ANS_TAXI_RMKS_17 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_17)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_18(ByVal ANS_TAXI_RMKS_18 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_18)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_19(ByVal ANS_TAXI_RMKS_19 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_19)
    End Function
    Public Shared Function GetValue_ANS_TAXI_RMKS_20(ByVal ANS_TAXI_RMKS_20 As TextBox) As String
        Return GetValue_ANS_TAXI_RMKS(ANS_TAXI_RMKS_20)
    End Function

    '社員用往路手配（回答）
    Public Shared Function GetValue_ANS_MR_O_TEHAI(ByVal ANS_MR_O_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_MR_O_TEHAI, True)
    End Function

    '社員用復路手配（回答）
    Public Shared Function GetValue_ANS_MR_F_TEHAI(ByVal ANS_MR_F_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ANS_MR_F_TEHAI, True)
    End Function

    '社員用手配備考（回答）
    Public Shared Function GetValue_ANS_MR_HOTEL_NOTE(ByVal ANS_MR_HOTEL_NOTE As TextBox) As String
        Return Trim(ANS_MR_HOTEL_NOTE.Text)
    End Function


    '【回答】施設選定理由
    Public Shared Function GetValue_ANS_SENTEI_RIYU(ByVal ANS_SENTEI_RIYU As TextBox) As String
        Return Trim(ANS_SENTEI_RIYU.Text)
    End Function

    '【回答】 開催地 (施設郵便番号)
    Public Shared Function GetValue_ANS_SHISETSU_ZIP(ByVal ANS_SHISETSU_ZIP As TextBox) As String
        Return Trim(ANS_SHISETSU_ZIP.Text)
    End Function

    '【回答】開催地(会合会場名)
    Public Shared Function GetValue_ANS_KOUEN_KAIJO_NAME(ByVal ANS_KOUEN_KAIJO_NAME As TextBox) As String
        Return Trim(ANS_KOUEN_KAIJO_NAME.Text)
    End Function

    '【回答】開催地(会合会場フロア)
    Public Shared Function GetValue_ANS_KOUEN_KAIJO_FLOOR(ByVal ANS_KOUEN_KAIJO_FLOOR As TextBox) As String
        Return Trim(ANS_KOUEN_KAIJO_FLOOR.Text)
    End Function

    '【回答】施設名
    Public Shared Function GetValue_ANS_SHISETSU_NAME(ByVal ANS_SHISETSU_NAME As TextBox) As String
        Return Trim(ANS_SHISETSU_NAME.Text)
    End Function
    Public Shared Function GetValue_SHISETSU_KANA(ByVal SHISETSU_KANA As TextBox) As String
        Return Trim(SHISETSU_KANA.Text)
    End Function

    '【回答】 開催地 (施設住所)
    Public Shared Function GetValue_ANS_SHISETSU_ADDRESS(ByVal ANS_SHISETSU_ADDRESS As TextBox) As String
        Return Trim(ANS_SHISETSU_ADDRESS.Text)
    End Function

    '【回答】 開催地 (施設TEL)
    Public Shared Function GetValue_ANS_SHISETSU_TEL(ByVal ANS_SHISETSU_TEL As TextBox) As String
        Return Trim(StrConv(ANS_SHISETSU_TEL.Text, VbStrConv.Narrow))
    End Function

    '【回答】 開催地 (施設URL)
    Public Shared Function GetValue_ANS_SHISETSU_URL(ByVal ANS_SHISETSU_URL As TextBox) As String
        Return Trim(StrConv(ANS_SHISETSU_URL.Text, VbStrConv.Narrow))
    End Function

    '【回答】開催地(意見交換会場名)
    Public Shared Function GetValue_ANS_IKENKOUKAN_KAIJO_NAME(ByVal ANS_IKENKOUKAN_KAIJO_NAME As TextBox) As String
        Return Trim(ANS_IKENKOUKAN_KAIJO_NAME.Text)
    End Function

    '【回答】開催地(慰労会会場名)
    Public Shared Function GetValue_ANS_IROUKAI_KAIJO_NAME(ByVal ANS_IROUKAI_KAIJO_NAME As TextBox) As String
        Return Trim(ANS_IROUKAI_KAIJO_NAME.Text)
    End Function

    '【回答】開催地(講師控室会場名)
    Public Shared Function GetValue_ANS_KOUSHI_ROOM_NAME(ByVal ANS_KOUSHI_ROOM_NAME As TextBox) As String
        Return Trim(ANS_KOUSHI_ROOM_NAME.Text)
    End Function

    '【回答】開催地(社員控室会場名)
    Public Shared Function GetValue_ANS_SHAIN_ROOM_NAME(ByVal ANS_SHAIN_ROOM_NAME As TextBox) As String
        Return Trim(ANS_SHAIN_ROOM_NAME.Text)
    End Function

    '【回答】開催地(世話人会会場名)
    Public Shared Function GetValue_ANS_MANAGER_KAIJO_NAME(ByVal ANS_MANAGER_KAIJO_NAME As TextBox) As String
        Return Trim(ANS_MANAGER_KAIJO_NAME.Text)
    End Function

    '【回答】開催地(備考欄)
    Public Shared Function GetValue_ANS_KAISAI_NOTE(ByVal ANS_KAISAI_NOTE As TextBox) As String
        Return Trim(ANS_KAISAI_NOTE.Text)
    End Function

    '見積額（非課税）
    Public Shared Function GetValue_ANS_MITSUMORI_TF(ByVal ANS_MITSUMORI_TF As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_TF.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_MITSUMORI_TF(ByVal ANS_TOTAL_TF As String) As String
        Return ANS_TOTAL_TF
    End Function

    '見積額（課税）
    Public Shared Function GetValue_ANS_MITSUMORI_T(ByVal ANS_MITSUMORI_T As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_T.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_MITSUMORI_T(ByVal ANS_TOTAL_T As String) As String
        Return ANS_TOTAL_T
    End Function

    '見積額（合計）
    Public Shared Function GetValue_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_TOTAL As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_TOTAL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_T As TextBox, ByVal ANS_MITSUMORI_TF As TextBox) As String
        Return CmnModule.DbVal(StrConv(ANS_MITSUMORI_T.Text, VbStrConv.Narrow)) + CmnModule.DbVal(StrConv(ANS_MITSUMORI_TF.Text, VbStrConv.Narrow)).ToString
    End Function

    Public Shared Function GetValue_ANS_MITSUMORI_TOTAL(ByVal ANS_MITSUMORI_T As String, ByVal ANS_MITSUMORI_TF As String) As String
        Return CmnModule.DbVal(StrConv(ANS_MITSUMORI_T, VbStrConv.Narrow)) + CmnModule.DbVal(StrConv(ANS_MITSUMORI_TF, VbStrConv.Narrow)).ToString
    End Function

    '見積書保存場所URL
    Public Shared Function GetValue_ANS_MITSUMORI_URL(ByVal ANS_MITSUMORI_URL As TextBox) As String
        Return Trim(StrConv(ANS_MITSUMORI_URL.Text, VbStrConv.Narrow))
    End Function

    '(回答) 見積関連
    Public Shared Function GetValue_ANS_KAIJOUHI_TF(ByVal ANS_KAIJOUHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_KAIJOUHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_KIZAIHI_TF(ByVal ANS_KIZAIHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_KIZAIHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_INSHOKUHI_TF(ByVal ANS_INSHOKUHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_INSHOKUHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_HOTELHI_TF(ByVal ANS_HOTELHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_HOTELHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_KOTSUHI_TF(ByVal ANS_KOTSUHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_KOTSUHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_TAXI_TF(ByVal ANS_TAXI_TF As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_TEHAI_TESURYO_TF(ByVal ANS_TEHAI_TESURYO_TF As TextBox) As String
        Return Trim(StrConv(ANS_TEHAI_TESURYO_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_TAXI_HAKKEN_TESURYO_TF(ByVal ANS_TAXI_HAKKEN_TESURYO_TF As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_HAKKEN_TESURYO_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_TAXI_SEISAN_TESURYO_TF(ByVal ANS_TAXI_SEISAN_TESURYO_TF As TextBox) As String
        Return Trim(StrConv(ANS_TAXI_SEISAN_TESURYO_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_JINKENHI_TF(ByVal ANS_JINKENHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_JINKENHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_OTHER_TF(ByVal ANS_OTHER_TF As TextBox) As String
        Return Trim(StrConv(ANS_OTHER_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_KANRIHI_TF(ByVal ANS_KANRIHI_TF As TextBox) As String
        Return Trim(StrConv(ANS_KANRIHI_TF.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_KAIJOUHI_T(ByVal ANS_KAIJOUHI_T As TextBox) As String
        Return Trim(StrConv(ANS_KAIJOUHI_T.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_KIZAIHI_T(ByVal ANS_KIZAIHI_T As TextBox) As String
        Return Trim(StrConv(ANS_KIZAIHI_T.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_INSHOKUHI_T(ByVal ANS_INSHOKUHI_T As TextBox) As String
        Return Trim(StrConv(ANS_INSHOKUHI_T.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_JINKENHI_T(ByVal ANS_JINKENHI_T As TextBox) As String
        Return Trim(StrConv(ANS_JINKENHI_T.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_OTHER_T(ByVal ANS_OTHER_T As TextBox) As String
        Return Trim(StrConv(ANS_OTHER_T.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_KANRIHI_T(ByVal ANS_KANRIHI_T As TextBox) As String
        Return Trim(StrConv(ANS_KANRIHI_T.Text, VbStrConv.Narrow))
    End Function

    Public Shared Function GetValue_ANS_991330401_TF(ByVal ANS_KAIJOUHI_TF As TextBox, ByVal ANS_KIZAIHI_TF As TextBox, ByVal ANS_INSHOKUHI_TF As TextBox) As String
        Dim wANS_KAIJOUHI_TF As String = Replace(Trim(StrConv(ANS_KAIJOUHI_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_KIZAIHI_TF As String = Replace(Trim(StrConv(ANS_KIZAIHI_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_INSHOKUHI_TF As String = Replace(Trim(StrConv(ANS_INSHOKUHI_TF.Text, VbStrConv.Narrow)), ",", "")

        Return CmnModule.DbVal(wANS_KAIJOUHI_TF) + CmnModule.DbVal(wANS_KIZAIHI_TF) + CmnModule.DbVal(wANS_INSHOKUHI_TF).ToString
    End Function

    Public Shared Function GetValue_ANS_991330401_T(ByVal ANS_KAIJOUHI_T As TextBox, ByVal ANS_KIZAIHI_T As TextBox, ByVal ANS_INSHOKUHI_T As TextBox) As String
        Dim wANS_KAIJOUHI_T As String = Replace(Trim(StrConv(ANS_KAIJOUHI_T.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_KIZAIHI_T As String = Replace(Trim(StrConv(ANS_KIZAIHI_T.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_INSHOKUHI_T As String = Replace(Trim(StrConv(ANS_INSHOKUHI_T.Text, VbStrConv.Narrow)), ",", "")

        Return CmnModule.DbVal(wANS_KAIJOUHI_T) + CmnModule.DbVal(wANS_KIZAIHI_T) + CmnModule.DbVal(wANS_INSHOKUHI_T).ToString
    End Function

    Public Shared Function GetValue_ANS_41120200_TF(ByVal ANS_HOTELHI_TF As TextBox, ByVal ANS_KOTSUHI_TF As TextBox, ByVal ANS_TAXI_TF As TextBox, ByVal ANS_TEHAI_TESURYO_TF As TextBox, ByVal ANS_TAXI_HAKKEN_TESURYO_TF As TextBox, ByVal ANS_TAXI_SEISAN_TESURYO_TF As TextBox, ByVal ANS_JINKENHI_TF As TextBox, ByVal ANS_OTHER_TF As TextBox, ByVal ANS_KANRIHI_TF As TextBox) As String
        Dim wANS_HOTELHI_TF As String = Replace(Trim(StrConv(ANS_HOTELHI_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_KOTSUHI_TF As String = Replace(Trim(StrConv(ANS_KOTSUHI_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_TAXI_TF As String = Replace(Trim(StrConv(ANS_TAXI_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_TEHAI_TESURYO_TF As String = Replace(Trim(StrConv(ANS_TEHAI_TESURYO_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_TAXI_HAKKEN_TESURYO_TF As String = Replace(Trim(StrConv(ANS_TAXI_HAKKEN_TESURYO_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_TAXI_SEISAN_TESURYO_TF As String = Replace(Trim(StrConv(ANS_TAXI_SEISAN_TESURYO_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_JINKENHI_TF As String = Replace(Trim(StrConv(ANS_JINKENHI_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_OTHER_TF As String = Replace(Trim(StrConv(ANS_OTHER_TF.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_KANRIHI_TF As String = Replace(Trim(StrConv(ANS_KANRIHI_TF.Text, VbStrConv.Narrow)), ",", "")

        Return CmnModule.DbVal(wANS_HOTELHI_TF) + CmnModule.DbVal(wANS_KOTSUHI_TF) + CmnModule.DbVal(wANS_TAXI_TF) + CmnModule.DbVal(wANS_TEHAI_TESURYO_TF) + CmnModule.DbVal(wANS_TAXI_HAKKEN_TESURYO_TF) + CmnModule.DbVal(wANS_TAXI_SEISAN_TESURYO_TF) + CmnModule.DbVal(wANS_JINKENHI_TF) + CmnModule.DbVal(wANS_OTHER_TF) + CmnModule.DbVal(wANS_KANRIHI_TF).ToString
    End Function

    Public Shared Function GetValue_ANS_41120200_T(ByVal ANS_JINKENHI_T As TextBox, ByVal ANS_OTHER_T As TextBox, ByVal ANS_KANRIHI_T As TextBox) As String
        Dim wANS_JINKENHI_T As String = Replace(Trim(StrConv(ANS_JINKENHI_T.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_OTHER_T As String = Replace(Trim(StrConv(ANS_OTHER_T.Text, VbStrConv.Narrow)), ",", "")
        Dim wANS_KANRIHI_T As String = Replace(Trim(StrConv(ANS_KANRIHI_T.Text, VbStrConv.Narrow)), ",", "")

        Return CmnModule.DbVal(wANS_JINKENHI_T) + CmnModule.DbVal(wANS_OTHER_T) + CmnModule.DbVal(wANS_KANRIHI_T).ToString
    End Function

    Public Shared Function GetValue_ANS_TOTAL_TF(ByVal ANS_991330401_TF As String, ByVal ANS_41120200_TF As String) As String
        Return (CmnModule.DbVal(ANS_991330401_TF) + CmnModule.DbVal(ANS_41120200_TF)).ToString
    End Function

    Public Shared Function GetValue_ANS_TOTAL_T(ByVal ANS_991330401_T As String, ByVal ANS_41120200_T As String) As String
        Return (CmnModule.DbVal(ANS_991330401_T) + CmnModule.DbVal(ANS_41120200_T)).ToString
    End Function

    Public Shared Function GetValue_SEISAN_KANRYO(ByVal SEISAN_KANRYO As CheckBox) As String
        If SEISAN_KANRYO.Checked = True Then
            Return CmnConst.Flag.On
        Else
            Return CmnConst.Flag.Off
        End If
    End Function

    'マスタ全般
    Public Shared Function GetValue_STOP_FLG(ByVal STOP_FLG As CheckBox) As String
        If STOP_FLG.Checked = True Then
            Return AppConst.STOP_FLG.Code.Stop
        Else
            Return ""
        End If
    End Function

    '施設マスタ関連
    Public Shared Function GetValue_SHISETSU_NAME(ByVal SHISETSU_NAME As TextBox) As String
        Return Trim(SHISETSU_NAME.Text)
    End Function
    Public Shared Function GetValue_ADDRESS1(ByVal ADDRESS1 As TextBox) As String
        Return Trim(ADDRESS1.Text)
    End Function
    Public Shared Function GetValue_ADDRESS1(ByVal ADDRESS1 As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(ADDRESS1)
    End Function
    Public Shared Function GetValue_ADDRESS2(ByVal ADDRESS2 As TextBox) As String
        Return Trim(ADDRESS2.Text)
    End Function
    Public Shared Function GetValue_ZIP(ByVal ZIP As TextBox) As String
        Return Trim(StrConv(ZIP.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ZIP(ByVal ZIP1 As TextBox, ByVal ZIP2 As TextBox) As String
        Dim wStr As String = ""
        wStr = Trim(StrConv(ZIP1.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(ZIP2.Text, VbStrConv.Narrow))
        If Trim(wStr) = "-" Then wStr = ""
        Return wStr
    End Function
    Public Shared Function GetValue_TEL(ByVal TEL As TextBox) As String
        Return Trim(StrConv(TEL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_TEL(ByVal TEL1 As TextBox, ByVal TEL2 As TextBox, ByVal TEL3 As TextBox) As String
        Dim wStr As String = ""
        wStr = Trim(StrConv(TEL1.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TEL2.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TEL3.Text, VbStrConv.Narrow))
        If Trim(wStr) = "--" Then wStr = ""
        Return wStr
    End Function
    Public Shared Function GetValue_CHECKIN_TIME(ByVal CHECKIN_TIME As TextBox) As String
        Return Trim(StrConv(CHECKIN_TIME.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_CHECKIN_TIME(ByVal CHECKIN_TIME1 As TextBox, ByVal CHECKIN_TIME2 As TextBox) As String
        Dim wStr As String = ""
        wStr = Trim(StrConv(CHECKIN_TIME1.Text, VbStrConv.Narrow)) & ":" & Trim(StrConv(CHECKIN_TIME2.Text, VbStrConv.Narrow))
        If Trim(wStr) = ":" Then wStr = ""
        Return wStr
    End Function
    Public Shared Function GetValue_CHECKOUT_TIME(ByVal CHECKOUT_TIME As TextBox) As String
        Return Trim(StrConv(CHECKOUT_TIME.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_CHECKOUT_TIME(ByVal CHECKOUT_TIME1 As TextBox, ByVal CHECKOUT_TIME2 As TextBox) As String
        Dim wStr As String = ""
        wStr = Trim(StrConv(CHECKOUT_TIME1.Text, VbStrConv.Narrow)) & ":" & Trim(StrConv(CHECKOUT_TIME2.Text, VbStrConv.Narrow))
        If Trim(wStr) = ":" Then wStr = ""
        Return wStr
    End Function
    Public Shared Function GetValue_URL(ByVal URL As TextBox) As String
        Return Trim(StrConv(URL.Text, VbStrConv.Narrow))
    End Function

    'ユーザマスタ関連
    Public Shared Function GetValue_KENGEN(ByVal KENGEN_Admin As RadioButton, ByVal KENGEN_User As RadioButton) As String
        If KENGEN_Admin.Checked = True Then
            Return AppConst.MS_USER.KENGEN.Code.Admin
        ElseIf KENGEN_User.Checked = True Then
            Return AppConst.MS_USER.KENGEN.Code.User
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_KENGEN_SEISAN(ByVal KENGEN_SEISAN As CheckBox) As String
        If KENGEN_SEISAN.Checked = True Then
            Return AppConst.MS_USER.KENGEN_SEISAN.Code.Yes
        Else
            Return AppConst.MS_USER.KENGEN_SEISAN.Code.No
        End If
    End Function

#End Region

#Region "== コントロールからコントロールを返す =="

    'GridViewのItemTemplateに配置したコントロールがある行(GridViewRow)を取得する
    Public Shared Function GetGridViewRow(ByVal ctl As System.Web.UI.Control) As GridViewRow

        Dim item As GridViewRow

        While (Not ctl Is Nothing)
            Try
                item = DirectCast(ctl, GridViewRow)
                If (Not item Is Nothing) Then
                    Return item
                End If
            Catch ex As Exception
            End Try

            ctl = ctl.Parent '一階層上のコントロールを取得する
        End While

        Return Nothing
    End Function

#End Region

    '==
    '宿泊手配依頼ありはTrueを返す
    Public Shared Function IsTEHAI_HOTEL(ByVal TEHAI_HOTEL As String) As Boolean
        Select Case TEHAI_HOTEL
            Case AppConst.KOTSUHOTEL.TEHAI_HOTEL.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_HOTEL.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function

    '交通手配依頼ありはTrueを返す
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

    'タクシーチケット（有・無）
    Public Shared Function IsTEHAI_TAXI(ByVal TEHAI_TAXI As String) As Boolean
        Select Case TEHAI_TAXI
            Case AppConst.KOTSUHOTEL.TEHAI_TAXI.Code.Yes, AppConst.KOTSUHOTEL.TEHAI_TAXI.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function


    '参加取消はTrueを返す
    Public Shared Function IsCanceled(ByVal data As String) As Boolean
        Select Case data
            Case AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Cancel, AppConst.KOTSUHOTEL.RECORD_KUBUN.Name.Cancel
                Return True
            Case Else
                Return False
        End Select
    End Function

    ''手配完了=Trueを返す
    'Public Shared Function IsOK_TEHAI(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As Boolean
    '    If IsCanceled(TBL_DR.RECORD_KUBUN) Then
    '        '参加取消→True
    '        Return True
    '    Else
    '        If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '手配不要→True
    '            Return True
    '        ElseIf IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '宿泊、交通 手配あり
    '            If IsOK_TEHAI_HOTEL(TBL_DR.STATUS_TEHAI) AndAlso IsOK_TEHAI_KOTSU(TBL_DR.STATUS_TEHAI) Then
    '                '宿泊完了+交通完了→True
    '                Return True
    '            End If
    '        ElseIf IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '宿泊手配あり
    '            If IsOK_TEHAI_HOTEL(TBL_DR.STATUS_TEHAI) Then
    '                '宿泊完了→True
    '                Return True
    '            End If
    '        ElseIf Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
    '            '公共交通手配あり
    '            If IsOK_TEHAI_KOTSU(TBL_DR.STATUS_TEHAI) Then
    '                '交通完了→True
    '                Return True
    '            End If
    '        End If
    '    End If
    '    Return False    '手配中
    'End Function

    ''宿泊手配完了=Trueを返す
    'Public Shared Function IsOK_TEHAI_HOTEL(ByVal STATUS_TEHAI As String) As Boolean
    '    Select Case STATUS_TEHAI
    '        Case AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK_KotsuNG, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
    '             AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK_KotsuNG, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK_KotsuOK
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function

    ''公共交通手配完了=Trueを返す
    'Public Shared Function IsOK_TEHAI_KOTSU(ByVal STATUS_TEHAI As String) As Boolean
    '    Select Case STATUS_TEHAI
    '        Case AppConst.kotsuhotel.STATUS_TEHAI.Code.KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelNG_KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
    '             AppConst.kotsuhotel.STATUS_TEHAI.Name.KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelNG_KotsuOK, AppConst.kotsuhotel.STATUS_TEHAI.Name.HotelOK_KotsuOK
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function

#Region "消費税関連の処理"

    '税率取得
    Public Shared Function GetZeiRate(ByVal KIJUN_DATE As String, ByVal DbConn As System.Data.SqlClient.SqlConnection, Optional ByVal DbTrans As SqlClient.SqlTransaction = Nothing) As String

        Dim strZeiRate As String = "0"
        Dim MS_ZEI() As TableDef.MS_ZEI.DataStruct = AppModule.GetZeiData(KIJUN_DATE, DbConn, DbTrans)

        If Not MS_ZEI Is Nothing Then
            For Each record As TableDef.MS_ZEI.DataStruct In MS_ZEI
                If record.START_DATE <= KIJUN_DATE AndAlso KIJUN_DATE <= record.END_DATE Then
                    strZeiRate = record.ZEI_RATE
                    Exit For
                End If
            Next
        End If

        Return strZeiRate

    End Function

    'SAP用税コード取得
    Public Shared Function GetSapZeiCd(ByVal KIJUN_DATE As String, ByVal DbConn As System.Data.SqlClient.SqlConnection, Optional ByVal DbTrans As SqlClient.SqlTransaction = Nothing) As String

        Dim strSapZeiCd As String = ""
        Dim MS_ZEI() As TableDef.MS_ZEI.DataStruct = AppModule.GetZeiData(KIJUN_DATE, DbConn, DbTrans)

        If Not MS_ZEI Is Nothing Then
            For Each record As TableDef.MS_ZEI.DataStruct In MS_ZEI
                If record.START_DATE <= KIJUN_DATE AndAlso KIJUN_DATE <= record.END_DATE Then
                    strSapZeiCd = record.SAP_ZEI_CD
                    Exit For
                End If
            Next
        End If

        Return strSapZeiCd

    End Function

    '消費税データ取得
    Public Shared Function GetZeiData(ByVal KIJUN_DATE As String, ByVal DbConn As System.Data.SqlClient.SqlConnection, Optional ByVal DbTrans As SqlClient.SqlTransaction = Nothing) As TableDef.MS_ZEI.DataStruct()

        Dim wCnt As Integer = 0
        Dim MS_ZEI(wCnt) As TableDef.MS_ZEI.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.MS_ZEI.AllData
        Dim RsData As System.Data.SqlClient.SqlDataReader

        If DbTrans Is Nothing Then
            RsData = CmnDb.Read(strSQL, DbConn)
        Else
            RsData = CmnDbBatch.Read(strSQL, DbConn, DbTrans)
        End If

        While RsData.Read()
            wFlag = True
            ReDim Preserve MS_ZEI(wCnt)

            MS_ZEI(wCnt) = AppModule.SetRsData(RsData, MS_ZEI(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return MS_ZEI
        Else
            Return Nothing
        End If

    End Function

    '税抜き額の取得
    Public Shared Function GetZeinukiGaku(ByVal strZeikomiGaku As String, ByVal strZeiritu As String) As String
        Dim lngZeinukiGaku As Long = CmnModule.ToRoundDown(CDbl(CDec(CmnModule.DbVal(strZeikomiGaku)) / CDec(CmnModule.DbVal(strZeiritu) + 1)))
        Return lngZeinukiGaku.ToString
    End Function

#End Region

    '== 列挙型 ==
    'テーブル
    Public Enum TableType
        [TBL_KOUENKAI]
        [TBL_SEIKYU]
        [TBL_KOTSUHOTEL]
        [TBL_KAIJO]
        [TBL_BENTO]
        [TBL_COST]
        [TBL_TAXITICKET_HAKKO]
        [MS_SHISETSU]
        [MS_USER]
        [MS_COSTCENTER]
        [MS_CODE]
        [TBL_LOG]
        '[MS_JIGYOSHO]
        '[MS_AREA]
        '[MS_EIGYOSHO]
    End Enum

End Class
