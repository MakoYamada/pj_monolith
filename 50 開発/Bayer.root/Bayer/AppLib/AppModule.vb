Imports CommonLib
Imports AppLib
Imports System.Web.UI.WebControls
Imports System.Drawing

Public Class AppModule

    '== データベース関連 ==
    'テーブルから構造体にデータをセット
    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As TableDef.TBL_KOUENKAI.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO.ToUpper Then TBL_KOUENKAI.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUENKAI_EDABAN.ToUpper Then TBL_KOUENKAI.KOUENKAI_EDABAN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME.ToUpper Then TBL_KOUENKAI.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME.ToUpper Then TBL_KOUENKAI.TAXI_PRT_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.FROM_DATE.ToUpper Then TBL_KOUENKAI.FROM_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TO_DATE.ToUpper Then TBL_KOUENKAI.TO_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME.ToUpper Then TBL_KOUENKAI.SEIHIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T.ToUpper Then TBL_KOUENKAI.INTERNAL_ORDER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF.ToUpper Then TBL_KOUENKAI.INTERNAL_ORDER_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ZETIA_CD.ToUpper Then TBL_KOUENKAI.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.BU.ToUpper Then TBL_KOUENKAI.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_JIGYOBU.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_JIGYOBU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NO.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KANA.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_EMAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI.ToUpper Then TBL_KOUENKAI.KIKAKU_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_JIGYOBU.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_JIGYOBU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NO.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KANA.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_EMAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI.ToUpper Then TBL_KOUENKAI.TEHAI_TANTO_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.ACCOUNT_CODE_T.ToUpper Then TBL_KOUENKAI.ACCOUNT_CODE_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.COST_CENTER.ToUpper Then TBL_KOUENKAI.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.DAIKIBO_FLG.ToUpper Then TBL_KOUENKAI.DAIKIBO_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.TTANTO_ID.ToUpper Then TBL_KOUENKAI.TTANTO_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INPUT_DATE.ToUpper Then TBL_KOUENKAI.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.INPUT_USER.ToUpper Then TBL_KOUENKAI.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.UPDATE_DATE.ToUpper Then TBL_KOUENKAI.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOUENKAI.Column.UPDATE_USER.ToUpper Then TBL_KOUENKAI.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KOUENKAI
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As TableDef.TBL_SEIKYU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KOUENKAI_NO.ToUpper Then TBL_SEIKYU.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJOHI_TF.ToUpper Then TBL_SEIKYU.KAIJOHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF.ToUpper Then TBL_SEIKYU.INSHOKUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIZAIHI_TF.ToUpper Then TBL_SEIKYU.KIZAIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UNEIHI_TF.ToUpper Then TBL_SEIKYU.UNEIHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTELHI_TF.ToUpper Then TBL_SEIKYU.HOTELHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KOTSUHI_TF.ToUpper Then TBL_SEIKYU.KOTSUHI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KAIJOHI_T.ToUpper Then TBL_SEIKYU.KAIJOHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.INSHOKUHI_T.ToUpper Then TBL_SEIKYU.INSHOKUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KIZAIHI_T.ToUpper Then TBL_SEIKYU.KIZAIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.UNEIHI_T.ToUpper Then TBL_SEIKYU.UNEIHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.HOTELHI_T.ToUpper Then TBL_SEIKYU.HOTELHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_SEIKYU.Column.KOTSUHI_T.ToUpper Then TBL_SEIKYU.KOTSUHI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_SEIKYU
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO.ToUpper Then TBL_KOTSUHOTEL.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.STATUS_TEHAI.ToUpper Then TBL_KOTSUHOTEL.STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_MPID.ToUpper Then TBL_KOTSUHOTEL.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_CD.ToUpper Then TBL_KOTSUHOTEL.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_EDABAN.ToUpper Then TBL_KOTSUHOTEL.DR_EDABAN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_NAME.ToUpper Then TBL_KOTSUHOTEL.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_KANA.ToUpper Then TBL_KOTSUHOTEL.DR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SEX.ToUpper Then TBL_KOTSUHOTEL.DR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS.ToUpper Then TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI.ToUpper Then TBL_KOTSUHOTEL.DR_YAKUWARI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA.ToUpper Then TBL_KOTSUHOTEL.DR_SANKA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_JIGYOBU.ToUpper Then TBL_KOTSUHOTEL.MR_JIGYOBU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_AREA.ToUpper Then TBL_KOTSUHOTEL.MR_AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO.ToUpper Then TBL_KOTSUHOTEL.MR_EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_NO.ToUpper Then TBL_KOTSUHOTEL.MR_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_NAME.ToUpper Then TBL_KOTSUHOTEL.MR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_KANA.ToUpper Then TBL_KOTSUHOTEL.MR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL.ToUpper Then TBL_KOTSUHOTEL.MR_EMAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI.ToUpper Then TBL_KOTSUHOTEL.MR_KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS.ToUpper Then TBL_KOTSUHOTEL.MR_SEND_SAKI_FS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER.ToUpper Then TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CODE.ToUpper Then TBL_KOTSUHOTEL.ACCOUNT_CODE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER.ToUpper Then TBL_KOTSUHOTEL.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER.ToUpper Then TBL_KOTSUHOTEL.INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME.ToUpper Then TBL_KOTSUHOTEL.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE.ToUpper Then TBL_KOTSUHOTEL.SHONIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_NAME.ToUpper Then TBL_KOTSUHOTEL.CMSHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_DATE.ToUpper Then TBL_KOTSUHOTEL.CMSHONIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_NOTE.ToUpper Then TBL_KOTSUHOTEL.CMSHONIN_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AGE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AGE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AGE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AGE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_O_AGE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_STATUS_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.ANS_O_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AGE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AGE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AGE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AGE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_F_AGE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_STATUS_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME1_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_TIME2_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_BIN_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5.ToUpper Then TBL_KOTSUHOTEL.ANS_F_SEAT_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_O_NOTE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_O_NOTE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_O_NOTE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_O_NOTE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_F_NOTE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_F_NOTE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_F_NOTE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_F_NOTE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FIX_RAIL_FARE.ToUpper Then TBL_KOTSUHOTEL.FIX_RAIL_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FIX_RAIL_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.FIX_RAIL_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FIX_AIR_FARE.ToUpper Then TBL_KOTSUHOTEL.FIX_AIR_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FIX_AIR_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.FIX_AIR_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FIX_OTHER_FARE.ToUpper Then TBL_KOTSUHOTEL.FIX_OTHER_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.FIX_OTHER_CANCELLATION.ToUpper Then TBL_KOTSUHOTEL.FIX_OTHER_CANCELLATION = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TOUROKUKANRI_FEE.ToUpper Then TBL_KOTSUHOTEL.TOUROKUKANRI_FEE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_HAKKEN_FEE.ToUpper Then TBL_KOTSUHOTEL.TAXI_HAKKEN_FEE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_SEISAN_FEE.ToUpper Then TBL_KOTSUHOTEL.TAXI_SEISAN_FEE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI.ToUpper Then TBL_KOTSUHOTEL.TEHAI_TAXI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_MOUSHIKOMI_SAKI.ToUpper Then TBL_KOTSUHOTEL.TAXI_MOUSHIKOMI_SAKI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_1.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_1.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_2.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_2.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_3.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_3.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_4.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_4.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_5.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_5.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_6.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_6.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_6 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_7.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_7.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_7 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_8.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_8.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_8 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_9.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_9.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_9 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_FROM_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_10.ToUpper Then TBL_KOTSUHOTEL.REQ_TAXI_TO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10.ToUpper Then TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_FROM_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_TO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_NO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_VOID_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_10.ToUpper Then TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_10 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TAXI_NOTE.ToUpper Then TBL_KOTSUHOTEL.TAXI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.TEHAI_MR.ToUpper Then TBL_KOTSUHOTEL.TEHAI_MR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEAT.ToUpper Then TBL_KOTSUHOTEL.MR_SEAT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_SEX.ToUpper Then TBL_KOTSUHOTEL.MR_SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.MR_AGE.ToUpper Then TBL_KOTSUHOTEL.MR_AGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE.ToUpper Then TBL_KOTSUHOTEL.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE.ToUpper Then TBL_KOTSUHOTEL.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE.ToUpper Then TBL_KOTSUHOTEL.SEND_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KOTSUHOTEL
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As TableDef.TBL_KAIJO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUENKAI_ID.ToUpper Then TBL_KAIJO.KOUENKAI_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TIME_STAMP.ToUpper Then TBL_KAIJO.TIME_STAMP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.AREA.ToUpper Then TBL_KAIJO.AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ADDRESS.ToUpper Then TBL_KAIJO.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.EIGYOSHO.ToUpper Then TBL_KAIJO.EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ZIP.ToUpper Then TBL_KAIJO.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TANTO_NO.ToUpper Then TBL_KAIJO.TANTO_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TANTO_NAME.ToUpper Then TBL_KAIJO.TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TANTO_KANA.ToUpper Then TBL_KAIJO.TANTO_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.INTERNAL_ORDER_T.ToUpper Then TBL_KAIJO.INTERNAL_ORDER_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ACCOUNT_CODE_T.ToUpper Then TBL_KAIJO.ACCOUNT_CODE_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.TEL.ToUpper Then TBL_KAIJO.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.EMAIL.ToUpper Then TBL_KAIJO.EMAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SEND_SAKI_FS.ToUpper Then TBL_KAIJO.SEND_SAKI_FS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_MPID.ToUpper Then TBL_KAIJO.DR_MPID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_NAME.ToUpper Then TBL_KAIJO.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_KANA.ToUpper Then TBL_KAIJO.DR_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_SHISETSU_NAME.ToUpper Then TBL_KAIJO.DR_SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_CD.ToUpper Then TBL_KAIJO.DR_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_SHISETSU_CD.ToUpper Then TBL_KAIJO.DR_SHISETSU_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_ADDRESS.ToUpper Then TBL_KAIJO.DR_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_GOFFICIAL.ToUpper Then TBL_KAIJO.DR_GOFFICIAL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.DR_YAKUWARI.ToUpper Then TBL_KAIJO.DR_YAKUWARI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.BU.ToUpper Then TBL_KAIJO.BU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ACCOUNT_CODE.ToUpper Then TBL_KAIJO.ACCOUNT_CODE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.COST_CENTER.ToUpper Then TBL_KAIJO.COST_CENTER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.INTERNAL_ORDER.ToUpper Then TBL_KAIJO.INTERNAL_ORDER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ZETIA_CD.ToUpper Then TBL_KAIJO.ZETIA_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.STATUS_SHONIN.ToUpper Then TBL_KAIJO.STATUS_SHONIN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHONIN_NAME.ToUpper Then TBL_KAIJO.SHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHONIN_TIME.ToUpper Then TBL_KAIJO.SHONIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SHONIN_NOTE.ToUpper Then TBL_KAIJO.SHONIN_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.CMSHONIN_NAME.ToUpper Then TBL_KAIJO.CMSHONIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.CMSHONIN_TIME.ToUpper Then TBL_KAIJO.CMSHONIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.CMSHONIN_NOTE.ToUpper Then TBL_KAIJO.CMSHONIN_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.STATUS_TEHAI.ToUpper Then TBL_KAIJO.STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI.ToUpper Then TBL_KAIJO.ANS_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.YOTEI_DATE.ToUpper Then TBL_KAIJO.YOTEI_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_DATE_NOTE.ToUpper Then TBL_KAIJO.KAISAI_DATE_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MEETING_NAME.ToUpper Then TBL_KAIJO.MEETING_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SEIHIN_NAME.ToUpper Then TBL_KAIJO.SEIHIN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_DR.ToUpper Then TBL_KAIJO.SANKA_YOTEI_CNT_DR = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_OTHER.ToUpper Then TBL_KAIJO.SANKA_YOTEI_CNT_OTHER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MITSUMORI_TF.ToUpper Then TBL_KAIJO.MITSUMORI_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MITSUMORI_T.ToUpper Then TBL_KAIJO.MITSUMORI_T = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MITSUMORI_TOTAL.ToUpper Then TBL_KAIJO.MITSUMORI_TOTAL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS1.ToUpper Then TBL_KAIJO.KAISAI_KIBOU_ADDRESS1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS2.ToUpper Then TBL_KAIJO.KAISAI_KIBOU_ADDRESS2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_NOTE.ToUpper Then TBL_KAIJO.KAISAI_KIBOU_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.KOUEN_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_TIME1.ToUpper Then TBL_KAIJO.KOUEN_TIME1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_TIME2.ToUpper Then TBL_KAIJO.KOUEN_TIME2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_LAYOUT.ToUpper Then TBL_KAIJO.KOUEN_KAIJO_LAYOUT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IKENKOUKAN_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IKENKOUKAN_TIME1.ToUpper Then TBL_KAIJO.IKENKOUKAN_TIME1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.IKENKOUKAN_TIME2.ToUpper Then TBL_KAIJO.IKENKOUKAN_TIME2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TEHAI.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TIME1.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_TIME1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TIME2.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_TIME2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_CNT.ToUpper Then TBL_KAIJO.KOUSHI_ROOM_CNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI.ToUpper Then TBL_KAIJO.MANAGER_KAIJO_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TIME1.ToUpper Then TBL_KAIJO.MANAGER_KAIJO_TIME1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TIME2.ToUpper Then TBL_KAIJO.MANAGER_KAIJO_TIME2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.OTHER_NOTE.ToUpper Then TBL_KAIJO.OTHER_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.FIX_KAISAI_SHISETSU.ToUpper Then TBL_KAIJO.FIX_KAISAI_SHISETSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.FIX_KAISAI_NOTE.ToUpper Then TBL_KAIJO.FIX_KAISAI_NOTE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.FIX_SEISAN_TF.ToUpper Then TBL_KAIJO.FIX_SEISAN_TF = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.FIX_SEISAN_GTAX.ToUpper Then TBL_KAIJO.FIX_SEISAN_GTAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KAIJO.Column.FIX_SEISAN_NTAX.ToUpper Then TBL_KAIJO.FIX_SEISAN_NTAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.ADDRESS1.ToUpper Then MS_SHISETSU.ADDRESS1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.ADDRESS2.ToUpper Then MS_SHISETSU.ADDRESS2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.SHISETSU_NAME.ToUpper Then MS_SHISETSU.SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.TEL.ToUpper Then MS_SHISETSU.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.CHECKIN_TIME.ToUpper Then MS_SHISETSU.CHECKIN_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.CHECKOUT_TIME.ToUpper Then MS_SHISETSU.CHECKOUT_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_JIGYOSHO.Column.未定.ToUpper Then MS_JIGYOSHO.未定 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_AREA.Column.未定.ToUpper Then MS_AREA.未定 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
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
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.未定.ToUpper Then MS_EIGYOSHO.未定 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.STOP_FLG.ToUpper Then MS_EIGYOSHO.STOP_FLG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.INPUT_DATE.ToUpper Then MS_EIGYOSHO.INPUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.INPUT_USER.ToUpper Then MS_EIGYOSHO.INPUT_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.UPDATE_DATE.ToUpper Then MS_EIGYOSHO.UPDATE_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_EIGYOSHO.Column.UPDATE_USER.ToUpper Then MS_EIGYOSHO.UPDATE_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_EIGYOSHO
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_KENSAKU As TableDef.TBL_KENSAKU.DataStruct) As TableDef.TBL_KENSAKU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.KOUENKAI_ID.ToUpper Then TBL_KENSAKU.KOUENKAI_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.AREA.ToUpper Then TBL_KENSAKU.AREA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.EIGYOSHO.ToUpper Then TBL_KENSAKU.EIGYOSHO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.TANTO_NAME.ToUpper Then TBL_KENSAKU.TANTO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.TANTO_KANA.ToUpper Then TBL_KENSAKU.TANTO_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.KOUENKAI_NAME.ToUpper Then TBL_KENSAKU.KOUENKAI_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.KOUENKAI_DATE.ToUpper Then TBL_KENSAKU.KOUENKAI_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_KENSAKU.Column.KOUENKAI_NO.ToUpper Then TBL_KENSAKU.KOUENKAI_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_KENSAKU
    End Function


    'データ取得
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
            Case AppModule.TableType.TBL_KENSAKU
                Dim TBL_KENSAKU As TableDef.TBL_KENSAKU.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_KENSAKU = SetRsData(RsData, TBL_KENSAKU)
                End If
                RsData.Close()
                Return TBL_KENSAKU
            Case Else
                Return Nothing
        End Select
    End Function


    '== 表示用に色を返す ==
    '手配状況
    Public Shared Function GetColor_STATUS_TEHAI(ByVal STATUS_TEHAI As String) As Color
        Dim ColorInput As Color = Color.FromArgb(51, 67, 183)
        Dim ColorCancel As Color = Color.FromArgb(100, 100, 100)
        Dim ColorTehaiNG As Color = Color.FromArgb(117, 21, 191)
        Dim ColorOK As Color = Color.FromArgb(21, 71, 40)
        Dim ColorOkTo As Color = Color.FromArgb(112, 34, 41)
        Dim ColorEndTo As Color = Color.FromArgb(191, 21, 37)

        Select Case STATUS_TEHAI
            Case AppConst.STATUS_TEHAI.Code.Input, AppConst.STATUS_TEHAI.Name.Input, _
                 AppConst.STATUS_TEHAI.Code.Change, AppConst.STATUS_TEHAI.Name.Change
                Return ColorInput
            Case AppConst.STATUS_TEHAI.Code.Cancel, AppConst.STATUS_TEHAI.Name.Cancel
                Return ColorCancel
            Case AppConst.STATUS_TEHAI.Code.HotelNG, AppConst.STATUS_TEHAI.Name.HotelNG, _
                 AppConst.STATUS_TEHAI.Code.KotsuNG, AppConst.STATUS_TEHAI.Name.KotsuNG, _
                 AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuNG, _
                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Name.HotelNG_KotsuOK, _
                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, AppConst.STATUS_TEHAI.Name.HotelNG_KotsuNG
                Return ColorTehaiNG
            Case AppConst.STATUS_TEHAI.Code.Fuyo, AppConst.STATUS_TEHAI.Name.Fuyo, _
                 AppConst.STATUS_TEHAI.Code.HotelOK, AppConst.STATUS_TEHAI.Name.HotelOK, _
                 AppConst.STATUS_TEHAI.Code.KotsuOK, AppConst.STATUS_TEHAI.Name.KotsuOK, _
                 AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
                Return ColorOK
            Case AppConst.STATUS_TEHAI.Code.OKToFuyo, AppConst.STATUS_TEHAI.Name.OKToFuyo, _
                 AppConst.STATUS_TEHAI.Code.OkToChange, AppConst.STATUS_TEHAI.Name.OkToChange, _
                 AppConst.STATUS_TEHAI.Code.OKToCancel, AppConst.STATUS_TEHAI.Name.OKToCancel
                Return ColorOkTo
            Case AppConst.STATUS_TEHAI.Code.EndToFuyo, AppConst.STATUS_TEHAI.Name.EndToFuyo, _
                 AppConst.STATUS_TEHAI.Code.EndToChange, AppConst.STATUS_TEHAI.Name.EndToChange, _
                 AppConst.STATUS_TEHAI.Code.EndToCancel, AppConst.STATUS_TEHAI.Name.EndToCancel
                Return ColorEndTo
            Case Else
                Return Color.Silver
        End Select
    End Function


    '== 表示用に文字列を編集 ==
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

    '手配状況
    Public Shared Function GetName_STATUS_TEHAI(ByVal STATUS_TEHAI As String) As String
        Select Case STATUS_TEHAI
            Case AppConst.STATUS_TEHAI.Code.Fuyo, AppConst.STATUS_TEHAI.Name.Fuyo
                Return AppConst.STATUS_TEHAI.Name.Fuyo
            Case AppConst.STATUS_TEHAI.Code.Input, AppConst.STATUS_TEHAI.Name.Input
                Return AppConst.STATUS_TEHAI.Name.Input
            Case AppConst.STATUS_TEHAI.Code.Change, AppConst.STATUS_TEHAI.Name.Change
                Return AppConst.STATUS_TEHAI.Name.Change
            Case AppConst.STATUS_TEHAI.Code.Cancel, AppConst.STATUS_TEHAI.Name.Cancel
                Return AppConst.STATUS_TEHAI.Name.Cancel
            Case AppConst.STATUS_TEHAI.Code.HotelNG, AppConst.STATUS_TEHAI.Name.HotelNG
                Return AppConst.STATUS_TEHAI.Name.HotelNG
            Case AppConst.STATUS_TEHAI.Code.KotsuNG, AppConst.STATUS_TEHAI.Name.KotsuNG
                Return AppConst.STATUS_TEHAI.Name.KotsuNG
            Case AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, AppConst.STATUS_TEHAI.Name.HotelNG_KotsuNG
                Return AppConst.STATUS_TEHAI.Name.HotelNG_KotsuNG
            Case AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuNG
                Return AppConst.STATUS_TEHAI.Name.HotelOK_KotsuNG
            Case AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Name.HotelNG_KotsuOK
                Return AppConst.STATUS_TEHAI.Name.HotelNG_KotsuOK
            Case AppConst.STATUS_TEHAI.Code.KotsuOK, AppConst.STATUS_TEHAI.Name.KotsuOK
                Return AppConst.STATUS_TEHAI.Name.KotsuOK
            Case AppConst.STATUS_TEHAI.Code.HotelOK, AppConst.STATUS_TEHAI.Name.HotelOK
                Return AppConst.STATUS_TEHAI.Name.HotelOK
            Case AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
                Return AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
            Case AppConst.STATUS_TEHAI.Code.OKToFuyo, AppConst.STATUS_TEHAI.Name.OKToFuyo
                Return AppConst.STATUS_TEHAI.Name.OKToFuyo
            Case AppConst.STATUS_TEHAI.Code.OkToChange, AppConst.STATUS_TEHAI.Name.OkToChange
                Return AppConst.STATUS_TEHAI.Name.OkToChange
            Case AppConst.STATUS_TEHAI.Code.OKToCancel, AppConst.STATUS_TEHAI.Name.OKToCancel
                Return AppConst.STATUS_TEHAI.Name.OKToCancel
            Case AppConst.STATUS_TEHAI.Code.EndToFuyo, AppConst.STATUS_TEHAI.Name.EndToFuyo
                Return AppConst.STATUS_TEHAI.Name.EndToFuyo
            Case AppConst.STATUS_TEHAI.Code.EndToChange, AppConst.STATUS_TEHAI.Name.EndToChange
                Return AppConst.STATUS_TEHAI.Name.EndToChange
            Case AppConst.STATUS_TEHAI.Code.EndToCancel, AppConst.STATUS_TEHAI.Name.EndToCancel
                Return AppConst.STATUS_TEHAI.Name.EndToCancel
            Case Else
                Return ""
        End Select
    End Function

    '宿泊手配
    Public Shared Function GetName_TEHAI_HOTEL(ByVal TEHAI_HOTEL As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case TEHAI_HOTEL
                Case AppConst.TEHAI.Code.Yes, AppConst.TEHAI.Name.Yes, AppConst.TEHAI.Name.ShortFormat.Yes
                    Return AppConst.TEHAI.Name.Yes
                Case AppConst.TEHAI.Code.No, AppConst.TEHAI.Name.No, AppConst.TEHAI.Name.ShortFormat.No
                    Return AppConst.TEHAI.Name.No
                Case Else
                    Return ""
            End Select
        Else
            Select Case TEHAI_HOTEL
                Case AppConst.TEHAI.Code.Yes, AppConst.TEHAI.Name.Yes, AppConst.TEHAI.Name.ShortFormat.Yes
                    Return AppConst.TEHAI.Name.ShortFormat.Yes
                Case AppConst.TEHAI.Code.No, AppConst.TEHAI.Name.No, AppConst.TEHAI.Name.ShortFormat.No
                    Return AppConst.TEHAI.Name.ShortFormat.No
                Case Else
                    Return ""
            End Select
        End If
    End Function

    'チェックイン日
    Public Shared Function GetName_CHECK_IN(ByVal CHECK_IN As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Dim wStr As String = ""
            wStr = CmnModule.Format_Date(Trim(CHECK_IN), CmnModule.DateFormatType.MMDD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(CHECK_IN), CmnModule.DateFormatType.MMDD), True)
            wStr = Replace(Replace(wStr, "/", "月"), "(", "日(")
            wStr = Replace(wStr, "月0", "月")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        Else
            Return CmnModule.Format_Date(CHECK_IN, CmnModule.DateFormatType.MD)
        End If
    End Function

    'チェックアウト日
    Public Shared Function GetName_CHECK_OUT(ByVal CHECK_OUT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(CHECK_OUT, ShortFormat)
    End Function

    'おたばこ
    Public Shared Function GetName_HOTEL_SMOKING(ByVal HOTEL_SMOKING As String) As String
        Select Case HOTEL_SMOKING
            Case AppConst.SMOKING.Code.No, AppConst.SMOKING.Name.No
                Return AppConst.SMOKING.Name.No
            Case AppConst.SMOKING.Code.Yes, AppConst.SMOKING.Name.Yes
                Return AppConst.SMOKING.Name.Yes
            Case Else
                Return ""
        End Select
    End Function

    '宿泊備考欄
    Public Shared Function GetName_HOTEL_NOTE(ByVal HOTEL_NOTE As String) As String
        Return HOTEL_NOTE
    End Function

    '性別
    Public Shared Function GetName_SEX(ByVal SEX As String) As String
        Select Case SEX
            Case AppConst.SEX.Code.Male, AppConst.SEX.Name.Male
                Return AppConst.SEX.Name.Male
            Case AppConst.SEX.Code.Female, AppConst.SEX.Name.Female
                Return AppConst.SEX.Name.Female
            Case Else
                Return ""
        End Select
    End Function

    '年齢
    Public Shared Function GetName_AGE(ByVal AGE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(AGE) = 0 Then
            Return ""
        Else
            If ShortFormat = False Then
                Return Trim(AGE) & "歳"
            Else
                Return Trim(AGE)
            End If
        End If
    End Function

    '公共交通手配
    Public Shared Function GetName_TEHAI_KOTSU(ByVal TEHAI_KOTSU As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_TEHAI_HOTEL(TEHAI_KOTSU, ShortFormat)
    End Function

    ''航空便/JR
    'Public Shared Function GetName_O_KOTSU_KUBUN_1(ByVal O_KOTSU_KUBUN_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If ShortFormat = False Then
    '        Select Case O_KOTSU_KUBUN_1
    '            Case AppConst.KOTSU_KUBUN.Code.AIR, AppConst.KOTSU_KUBUN.Name.AIR, AppConst.KOTSU_KUBUN.Name.ShortFormat.AIR
    '                Return AppConst.KOTSU_KUBUN.Name.AIR
    '            Case AppConst.KOTSU_KUBUN.Code.JR, AppConst.KOTSU_KUBUN.Name.JR, AppConst.KOTSU_KUBUN.Name.ShortFormat.JR
    '                Return AppConst.KOTSU_KUBUN.Name.JR
    '            Case Else
    '                Return AppConst.KOTSU_KUBUN.Name.None
    '        End Select
    '    Else
    '        Select Case O_KOTSU_KUBUN_1
    '            Case AppConst.KOTSU_KUBUN.Code.AIR, AppConst.KOTSU_KUBUN.Name.AIR, AppConst.KOTSU_KUBUN.Name.ShortFormat.AIR
    '                Return AppConst.KOTSU_KUBUN.Name.ShortFormat.AIR
    '            Case AppConst.KOTSU_KUBUN.Code.JR, AppConst.KOTSU_KUBUN.Name.JR, AppConst.KOTSU_KUBUN.Name.ShortFormat.JR
    '                Return AppConst.KOTSU_KUBUN.Name.ShortFormat.JR
    '            Case Else
    '                Return AppConst.KOTSU_KUBUN.Name.ShortFormat.None
    '        End Select
    '    End If
    'End Function
    'Public Shared Function GetName_O_KOTSU_KUBUN_2(ByVal O_KOTSU_KUBUN_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_KOTSU_KUBUN_3(ByVal O_KOTSU_KUBUN_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_KOTSU_KUBUN_1(ByVal F_KOTSU_KUBUN_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_KOTSU_KUBUN_2(ByVal F_KOTSU_KUBUN_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_KOTSU_KUBUN_3(ByVal F_KOTSU_KUBUN_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_3, ShortFormat)
    'End Function

    ''乗車・搭乗日
    'Public Shared Function GetName_O_DATE_1(ByVal O_DATE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_CHECK_IN(O_DATE_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_DATE_2(ByVal O_DATE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_DATE_1(O_DATE_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_DATE_3(ByVal O_DATE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_DATE_1(O_DATE_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_DATE_1(ByVal F_DATE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_DATE_1(F_DATE_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_DATE_2(ByVal F_DATE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_DATE_1(F_DATE_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_DATE_3(ByVal F_DATE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_DATE_1(F_DATE_3, ShortFormat)
    'End Function

    ''区間
    'Public Shared Function GetName_O_AIRPORT_1(ByVal O_AIRPORT1_1 As String, ByVal O_AIRPORT2_1 As String) As String
    '    Dim wStr As String = ""

    '    If Trim(O_AIRPORT1_1) <> "" AndAlso Trim(O_AIRPORT2_1) <> "" Then
    '        wStr = Trim(O_AIRPORT1_1) & "発～" & Trim(O_AIRPORT2_1) & "着"
    '    ElseIf Trim(O_AIRPORT1_1) <> "" AndAlso Trim(O_AIRPORT2_1) = "" Then
    '        wStr = Trim(O_AIRPORT1_1) & "発"
    '    ElseIf Trim(O_AIRPORT1_1) = "" AndAlso Trim(O_AIRPORT2_1) <> "" Then
    '        wStr = Trim(O_AIRPORT2_1) & "着"
    '    End If
    '    Return wStr
    'End Function
    'Public Shared Function GetName_O_AIRPORT_2(ByVal O_AIRPORT1_2 As String, ByVal O_AIRPORT2_2 As String) As String
    '    Return GetName_O_AIRPORT_1(O_AIRPORT1_2, O_AIRPORT2_2)
    'End Function
    'Public Shared Function GetName_O_AIRPORT_3(ByVal O_AIRPORT1_3 As String, ByVal O_AIRPORT2_3 As String) As String
    '    Return GetName_O_AIRPORT_1(O_AIRPORT1_3, O_AIRPORT2_3)
    'End Function
    'Public Shared Function GetName_F_AIRPORT_1(ByVal F_AIRPORT1_1 As String, ByVal F_AIRPORT2_1 As String) As String
    '    Return GetName_O_AIRPORT_1(F_AIRPORT1_1, F_AIRPORT2_1)
    'End Function
    'Public Shared Function GetName_F_AIRPORT_2(ByVal F_AIRPORT1_2 As String, ByVal F_AIRPORT2_2 As String) As String
    '    Return GetName_O_AIRPORT_1(F_AIRPORT1_2, F_AIRPORT2_2)
    'End Function
    'Public Shared Function GetName_F_AIRPORT_3(ByVal F_AIRPORT1_3 As String, ByVal F_AIRPORT2_3 As String) As String
    '    Return GetName_O_AIRPORT_1(F_AIRPORT1_3, F_AIRPORT2_3)
    'End Function

    'Public Shared Function GetName_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If O_AIRPORT1_1.Trim <> String.Empty Then
    '        If ShortFormat = False Then
    '            Return O_AIRPORT1_1 & "発"
    '        Else
    '            Return O_AIRPORT1_1
    '        End If
    '    Else
    '        Return O_AIRPORT1_1
    '    End If
    'End Function
    'Public Shared Function GetName_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT1_1(O_AIRPORT1_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT1_1(O_AIRPORT1_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT1_1(F_AIRPORT1_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT1_1(F_AIRPORT1_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT1_1(F_AIRPORT1_3, ShortFormat)
    'End Function

    'Public Shared Function GetName_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If O_AIRPORT2_1.Trim <> String.Empty Then
    '        If ShortFormat = False Then
    '            Return O_AIRPORT2_1 & "着"
    '        Else
    '            Return O_AIRPORT2_1
    '        End If
    '    Else
    '        Return O_AIRPORT2_1
    '    End If
    'End Function
    'Public Shared Function GetName_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT2_1(O_AIRPORT2_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT2_1(O_AIRPORT2_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT2_1(F_AIRPORT2_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT2_1(F_AIRPORT2_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_AIRPORT2_1(F_AIRPORT2_3, ShortFormat)
    'End Function

    ''新幹線・特急区間
    'Public Shared Function GetName_O_EXPRESS_1(ByVal O_EXPRESS1_1 As String, ByVal O_EXPRESS2_1 As String) As String
    '    Dim wStr As String = ""

    '    If Trim(O_EXPRESS1_1) <> "" AndAlso Trim(O_EXPRESS2_1) <> "" Then
    '        wStr = Trim(O_EXPRESS1_1) & "発～" & Trim(O_EXPRESS2_1) & "着"
    '    ElseIf Trim(O_EXPRESS1_1) <> "" AndAlso Trim(O_EXPRESS2_1) = "" Then
    '        wStr = Trim(O_EXPRESS1_1) & "発"
    '    ElseIf Trim(O_EXPRESS1_1) = "" AndAlso Trim(O_EXPRESS2_1) <> "" Then
    '        wStr = Trim(O_EXPRESS2_1) & "着"
    '    End If
    '    Return wStr
    'End Function
    'Public Shared Function GetName_O_EXPRESS_2(ByVal O_EXPRESS1_2 As String, ByVal O_EXPRESS2_2 As String) As String
    '    Return GetName_O_EXPRESS_1(O_EXPRESS1_2, O_EXPRESS2_2)
    'End Function
    'Public Shared Function GetName_O_EXPRESS_3(ByVal O_EXPRESS1_3 As String, ByVal O_EXPRESS2_3 As String) As String
    '    Return GetName_O_EXPRESS_1(O_EXPRESS1_3, O_EXPRESS2_3)
    'End Function
    'Public Shared Function GetName_F_EXPRESS_1(ByVal F_EXPRESS1_1 As String, ByVal F_EXPRESS2_1 As String) As String
    '    Return GetName_O_EXPRESS_1(F_EXPRESS1_1, F_EXPRESS2_1)
    'End Function
    'Public Shared Function GetName_F_EXPRESS_2(ByVal F_EXPRESS1_2 As String, ByVal F_EXPRESS2_2 As String) As String
    '    Return GetName_O_EXPRESS_1(F_EXPRESS1_2, F_EXPRESS2_2)
    'End Function
    'Public Shared Function GetName_F_EXPRESS_3(ByVal F_EXPRESS1_3 As String, ByVal F_EXPRESS2_3 As String) As String
    '    Return GetName_O_EXPRESS_1(F_EXPRESS1_3, F_EXPRESS2_3)
    'End Function

    'Public Shared Function GetName_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If O_EXPRESS1_1.Trim <> String.Empty Then
    '        If ShortFormat = False Then
    '            Return O_EXPRESS1_1 & "発"
    '        Else
    '            Return O_EXPRESS1_1
    '        End If
    '    Else
    '        Return O_EXPRESS1_1
    '    End If
    'End Function
    'Public Shared Function GetName_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS1_1(O_EXPRESS1_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS1_1(O_EXPRESS1_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS1_1(F_EXPRESS1_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS1_1(F_EXPRESS1_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS1_1(F_EXPRESS1_3, ShortFormat)
    'End Function

    'Public Shared Function GetName_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If O_EXPRESS2_1.Trim <> String.Empty Then
    '        If ShortFormat = False Then
    '            Return O_EXPRESS2_1 & "着"
    '        Else
    '            Return O_EXPRESS2_1
    '        End If
    '    Else
    '        Return O_EXPRESS2_1
    '    End If
    'End Function
    'Public Shared Function GetName_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS2_1(O_EXPRESS2_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS2_1(O_EXPRESS2_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS2_1(F_EXPRESS2_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS2_1(F_EXPRESS2_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_EXPRESS2_1(F_EXPRESS2_3, ShortFormat)
    'End Function

    ''乗車券区間
    'Public Shared Function GetName_O_LOCAL_1(ByVal O_LOCAL1_1 As String, ByVal O_LOCAL2_1 As String) As String
    '    Dim wStr As String = ""

    '    If Trim(O_LOCAL1_1) <> "" AndAlso Trim(O_LOCAL2_1) <> "" Then
    '        wStr = Trim(O_LOCAL1_1) & "発～" & Trim(O_LOCAL2_1) & "着"
    '    ElseIf Trim(O_LOCAL1_1) <> "" AndAlso Trim(O_LOCAL2_1) = "" Then
    '        wStr = Trim(O_LOCAL1_1) & "発"
    '    ElseIf Trim(O_LOCAL1_1) = "" AndAlso Trim(O_LOCAL2_1) <> "" Then
    '        wStr = Trim(O_LOCAL2_1) & "着"
    '    End If
    '    Return wStr
    'End Function
    'Public Shared Function GetName_O_LOCAL_2(ByVal O_LOCAL1_2 As String, ByVal O_LOCAL2_2 As String) As String
    '    Return GetName_O_LOCAL_1(O_LOCAL1_2, O_LOCAL2_2)
    'End Function
    'Public Shared Function GetName_O_LOCAL_3(ByVal O_LOCAL1_3 As String, ByVal O_LOCAL2_3 As String) As String
    '    Return GetName_O_LOCAL_1(O_LOCAL1_3, O_LOCAL2_3)
    'End Function
    'Public Shared Function GetName_F_LOCAL_1(ByVal F_LOCAL1_1 As String, ByVal F_LOCAL2_1 As String) As String
    '    Return GetName_O_LOCAL_1(F_LOCAL1_1, F_LOCAL2_1)
    'End Function
    'Public Shared Function GetName_F_LOCAL_2(ByVal F_LOCAL1_2 As String, ByVal F_LOCAL2_2 As String) As String
    '    Return GetName_O_LOCAL_1(F_LOCAL1_2, F_LOCAL2_2)
    'End Function
    'Public Shared Function GetName_F_LOCAL_3(ByVal F_LOCAL1_3 As String, ByVal F_LOCAL2_3 As String) As String
    '    Return GetName_O_LOCAL_1(F_LOCAL1_3, F_LOCAL2_3)
    'End Function

    'Public Shared Function GetName_O_LOCAL1_1(ByVal O_LOCAL1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If O_LOCAL1_1.Trim <> String.Empty Then
    '        If ShortFormat = False Then
    '            Return O_LOCAL1_1 & "発"
    '        Else
    '            Return O_LOCAL1_1
    '        End If
    '    Else
    '        Return O_LOCAL1_1
    '    End If
    'End Function
    'Public Shared Function GetName_O_LOCAL1_2(ByVal O_LOCAL1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL1_1(O_LOCAL1_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_LOCAL1_3(ByVal O_LOCAL1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL1_1(O_LOCAL1_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_LOCAL1_1(ByVal F_LOCAL1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL1_1(F_LOCAL1_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_LOCAL1_2(ByVal F_LOCAL1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL1_1(F_LOCAL1_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_LOCAL1_3(ByVal F_LOCAL1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL1_1(F_LOCAL1_3, ShortFormat)
    'End Function

    'Public Shared Function GetName_O_LOCAL2_1(ByVal O_LOCAL2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    If O_LOCAL2_1.Trim <> String.Empty Then
    '        If ShortFormat = False Then
    '            Return O_LOCAL2_1 & "着"
    '        Else
    '            Return O_LOCAL2_1
    '        End If
    '    Else
    '        Return O_LOCAL2_1
    '    End If
    'End Function
    'Public Shared Function GetName_O_LOCAL2_2(ByVal O_LOCAL2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL2_1(O_LOCAL2_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_O_LOCAL2_3(ByVal O_LOCAL2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL2_1(O_LOCAL2_3, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_LOCAL2_1(ByVal F_LOCAL2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL2_1(F_LOCAL2_1, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_LOCAL2_2(ByVal F_LOCAL2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL2_1(F_LOCAL2_2, ShortFormat)
    'End Function
    'Public Shared Function GetName_F_LOCAL2_3(ByVal F_LOCAL2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
    '    Return GetName_O_LOCAL2_1(F_LOCAL2_3, ShortFormat)
    'End Function

    ''時間
    'Public Shared Function GetName_O_TIME_1(ByVal O_TIME1_1 As String, ByVal O_TIME2_1 As String) As String
    '    Dim wStr As String = ""

    '    If Trim(O_TIME1_1) <> "" AndAlso Trim(O_TIME2_1) <> "" Then
    '        wStr = Trim(O_TIME1_1) & "～" & Trim(O_TIME2_1)
    '    ElseIf Trim(O_TIME1_1) <> "" AndAlso Trim(O_TIME2_1) = "" Then
    '        wStr = Trim(O_TIME1_1) & "～"
    '    ElseIf Trim(O_TIME1_1) = "" AndAlso Trim(O_TIME2_1) <> "" Then
    '        wStr = "～" & Trim(O_TIME2_1)
    '    End If

    '    Return wStr
    'End Function
    'Public Shared Function GetName_O_TIME_2(ByVal O_TIME1_2 As String, ByVal O_TIME2_2 As String) As String
    '    Return GetName_O_TIME_1(O_TIME1_2, O_TIME2_2)
    'End Function
    'Public Shared Function GetName_O_TIME_3(ByVal O_TIME1_3 As String, ByVal O_TIME2_3 As String) As String
    '    Return GetName_O_TIME_1(O_TIME1_3, O_TIME2_3)
    'End Function
    'Public Shared Function GetName_F_TIME_1(ByVal F_TIME1_1 As String, ByVal F_TIME2_1 As String) As String
    '    Return GetName_O_TIME_1(F_TIME1_1, F_TIME2_1)
    'End Function
    'Public Shared Function GetName_F_TIME_2(ByVal F_TIME1_2 As String, ByVal F_TIME2_2 As String) As String
    '    Return GetName_O_TIME_1(F_TIME1_2, F_TIME2_2)
    'End Function
    'Public Shared Function GetName_F_TIME_3(ByVal F_TIME1_3 As String, ByVal F_TIME2_3 As String) As String
    '    Return GetName_O_TIME_1(F_TIME1_3, F_TIME2_3)
    'End Function
    'Public Shared Function GetName_O_TIME1_1(ByVal O_TIME1_1 As String) As String
    '    Return O_TIME1_1
    'End Function
    'Public Shared Function GetName_O_TIME2_1(ByVal O_TIME2_1 As String) As String
    '    Return GetName_O_TIME1_1(O_TIME2_1)
    'End Function
    'Public Shared Function GetName_O_TIME1_2(ByVal O_TIME1_2 As String) As String
    '    Return GetName_O_TIME1_1(O_TIME1_2)
    'End Function
    'Public Shared Function GetName_O_TIME2_2(ByVal O_TIME2_2 As String) As String
    '    Return GetName_O_TIME1_1(O_TIME2_2)
    'End Function
    'Public Shared Function GetName_O_TIME1_3(ByVal O_TIME1_3 As String) As String
    '    Return GetName_O_TIME1_1(O_TIME1_3)
    'End Function
    'Public Shared Function GetName_O_TIME2_3(ByVal O_TIME2_3 As String) As String
    '    Return GetName_O_TIME1_1(O_TIME2_3)
    'End Function
    'Public Shared Function GetName_F_TIME1_1(ByVal F_TIME1_1 As String) As String
    '    Return GetName_O_TIME1_1(F_TIME1_1)
    'End Function
    'Public Shared Function GetName_F_TIME2_1(ByVal F_TIME2_1 As String) As String
    '    Return GetName_O_TIME1_1(F_TIME2_1)
    'End Function
    'Public Shared Function GetName_F_TIME1_2(ByVal F_TIME1_2 As String) As String
    '    Return GetName_O_TIME1_1(F_TIME1_2)
    'End Function
    'Public Shared Function GetName_F_TIME2_2(ByVal F_TIME2_2 As String) As String
    '    Return GetName_O_TIME1_1(F_TIME2_2)
    'End Function
    'Public Shared Function GetName_F_TIME1_3(ByVal F_TIME1_3 As String) As String
    '    Return GetName_O_TIME1_1(F_TIME1_3)
    'End Function
    'Public Shared Function GetName_F_TIME2_3(ByVal F_TIME2_3 As String) As String
    '    Return GetName_O_TIME1_1(F_TIME2_3)
    'End Function

    ''便名
    'Public Shared Function GetName_O_BIN_1(ByVal O_BIN_1 As String) As String
    '    Return O_BIN_1
    'End Function
    'Public Shared Function GetName_O_BIN_2(ByVal O_BIN_2 As String) As String
    '    Return GetName_O_BIN_1(O_BIN_2)
    'End Function
    'Public Shared Function GetName_O_BIN_3(ByVal O_BIN_3 As String) As String
    '    Return GetName_O_BIN_1(O_BIN_3)
    'End Function
    'Public Shared Function GetName_F_BIN_1(ByVal F_BIN_1 As String) As String
    '    Return GetName_O_BIN_1(F_BIN_1)
    'End Function
    'Public Shared Function GetName_F_BIN_2(ByVal F_BIN_2 As String) As String
    '    Return GetName_O_BIN_1(F_BIN_2)
    'End Function
    'Public Shared Function GetName_F_BIN_3(ByVal F_BIN_3 As String) As String
    '    Return GetName_O_BIN_1(F_BIN_3)
    'End Function

    ''座席希望
    'Public Shared Function GetName_O_SEAT_1(ByVal O_SEAT_1 As String) As String
    '    Select Case O_SEAT_1
    '        Case AppConst.SEAT.Code.Window, AppConst.SEAT.Name.Window
    '            Return AppConst.SEAT.Name.Window
    '        Case AppConst.SEAT.Code.Aisle, AppConst.SEAT.Name.Aisle
    '            Return AppConst.SEAT.Name.Aisle
    '        Case Else
    '            Return ""
    '    End Select
    'End Function
    'Public Shared Function GetName_O_SEAT_2(ByVal O_SEAT_2 As String) As String
    '    Return GetName_O_SEAT_1(O_SEAT_2)
    'End Function
    'Public Shared Function GetName_O_SEAT_3(ByVal O_SEAT_3 As String) As String
    '    Return GetName_O_SEAT_1(O_SEAT_3)
    'End Function
    'Public Shared Function GetName_F_SEAT_1(ByVal F_SEAT_1 As String) As String
    '    Return GetName_O_SEAT_1(F_SEAT_1)
    'End Function
    'Public Shared Function GetName_F_SEAT_2(ByVal F_SEAT_2 As String) As String
    '    Return GetName_O_SEAT_1(F_SEAT_2)
    'End Function
    'Public Shared Function GetName_F_SEAT_3(ByVal F_SEAT_3 As String) As String
    '    Return GetName_O_SEAT_1(F_SEAT_3)
    'End Function

    ''座席区分
    'Public Shared Function GetName_O_SEATCLASS_1(ByVal O_SEATCLASS_1 As String) As String
    '    Select Case O_SEATCLASS_1
    '        Case AppConst.SEATCLASS.Code.Regular, AppConst.SEATCLASS.Name.Regular
    '            Return AppConst.SEATCLASS.Name.Regular
    '        Case AppConst.SEATCLASS.Code.Premium, AppConst.SEATCLASS.Name.Premium
    '            Return AppConst.SEATCLASS.Name.Premium
    '        Case AppConst.SEATCLASS.Code.Unreserved, AppConst.SEATCLASS.Name.Unreserved
    '            Return AppConst.SEATCLASS.Name.Unreserved
    '        Case Else
    '            Return ""
    '    End Select
    'End Function
    'Public Shared Function GetName_O_SEATCLASS_2(ByVal O_SEATCLASS_2 As String) As String
    '    Return GetName_O_SEATCLASS_1(O_SEATCLASS_2)
    'End Function
    'Public Shared Function GetName_O_SEATCLASS_3(ByVal O_SEATCLASS_3 As String) As String
    '    Return GetName_O_SEATCLASS_1(O_SEATCLASS_3)
    'End Function
    'Public Shared Function GetName_F_SEATCLASS_1(ByVal F_SEATCLASS_1 As String) As String
    '    Return GetName_O_SEATCLASS_1(F_SEATCLASS_1)
    'End Function
    'Public Shared Function GetName_F_SEATCLASS_2(ByVal F_SEATCLASS_2 As String) As String
    '    Return GetName_O_SEATCLASS_1(F_SEATCLASS_2)
    'End Function
    'Public Shared Function GetName_F_SEATCLASS_3(ByVal F_SEATCLASS_3 As String) As String
    '    Return GetName_O_SEATCLASS_1(F_SEATCLASS_3)
    'End Function

    '交通備考欄
    Public Shared Function GetName_KOTSU_NOTE(ByVal KOTSU_NOTE As String) As String
        Return GetName_HOTEL_NOTE(KOTSU_NOTE)
    End Function

    '備考欄
    Public Shared Function GetName_NOTES(ByVal NOTES As String) As String
        Return NOTES
    End Function

    '料金等
    Public Shared Function GetName_ROOM_KOTSU(ByVal ROOM_RATE As String, ByVal O_KOTSU_FARE As String, ByVal F_KOTSU_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Dim wKINGAKU As Long = 0
        wKINGAKU = CmnModule.DbVal_Kingaku(ROOM_RATE) + CmnModule.DbVal_Kingaku(O_KOTSU_FARE) + CmnModule.DbVal_Kingaku(F_KOTSU_FARE)
        If ShortFormat = False Then
            Return wKINGAKU.ToString("#,#")
        Else
            Return wKINGAKU
        End If
    End Function
    Public Shared Function GetName_ROOM_RATE(ByVal ROOM_RATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ROOM_RATE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(ROOM_RATE).ToString("#,#")
            Else
                Return ROOM_RATE
            End If
        End If
    End Function

    '電話番号
    Public Shared Function GetName_TEL(ByVal TEL As String) As String
        Return TEL
    End Function

    '携帯電話番号
    Public Shared Function GetName_KEITAI(ByVal KEITAI As String) As String
        Return KEITAI
    End Function

    '郵便番号
    Public Shared Function GetName_ZIP(ByVal ZIP As String) As String
        Return ZIP
    End Function

    'メールアドレス
    Public Shared Function GetName_EMAIL(ByVal EMAIL As String) As String
        Return EMAIL
    End Function

    '携帯メールアドレス
    Public Shared Function GetName_KEITAI_MAIL(ByVal KEITAI_MAIL As String) As String
        Return KEITAI_MAIL
    End Function

    '登録日
    Public Shared Function GetName_INS_DATE(ByVal INS_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(Mid(INS_DATE, 1, 14), ShortFormat)
    End Function

    '登録日
    Public Shared Function GetName_INS_DATE_CSV(ByVal INS_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Dim wStr As String = ""
            wStr = CmnModule.Format_Date(Trim(INS_DATE), CmnModule.DateFormatType.MMDD) _
                 & CmnModule.GetName_Weekday(CmnModule.Format_Date(Trim(INS_DATE), CmnModule.DateFormatType.MMDD), True)
            wStr = Replace(Replace(wStr, "/", "月"), "(", "日(")
            wStr = Replace(wStr, "月0", "月")
            If Mid(wStr, 1, 1) = "0" Then wStr = Mid(wStr, 2, 10)
            Return wStr
        Else
            Return CmnModule.Format_Date(INS_DATE, CmnModule.DateFormatType.YYYYMMDD)
        End If
    End Function

    '更新日
    Public Shared Function GetName_UPD_DATE(ByVal UPD_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_INS_DATE(Mid(UPD_DATE, 1, 14), ShortFormat)
    End Function

    '更新日
    Public Shared Function GetName_UPD_DATE_CSV(ByVal UPD_DATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_INS_DATE_CSV(Mid(UPD_DATE, 1, 14), ShortFormat)
    End Function


    '== コントロールをセット ==
    'ログインID
    Public Shared Sub SetForm_LOGIN_ID(ByVal LOGIN_ID As String, ByRef control As TextBox)
        control.Text = LOGIN_ID
    End Sub

    'パスワード
    Public Shared Sub SetForm_PASSWORD(ByVal PASSWORD As String, ByRef control As TextBox)
        control.Text = PASSWORD
    End Sub

    '氏名(漢字)
    Public Shared Sub SetForm_DR_NAME(ByVal DR_NAME As String, ByRef control As TextBox)
        control.Text = DR_NAME
    End Sub

    '氏名(カナ)
    Public Shared Sub SetForm_DR_NAME_KANA(ByVal DR_NAME_KANA As String, ByRef control As TextBox)
        control.Text = DR_NAME_KANA
    End Sub

    '所属
    Public Shared Sub SetForm_OFFICE(ByVal OFFICE As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(OFFICE, control)
    End Sub

    'メールアドレス
    Public Shared Sub SetForm_EMAIL(ByVal EMAIL As String, ByRef control As TextBox)
        control.Text = EMAIL
    End Sub

    '施設・病院名称
    Public Shared Sub SetForm_SHISETSU_NAME(ByVal SHISETSU_NAME As String, ByRef control As TextBox)
        control.Text = SHISETSU_NAME
    End Sub

    'おたばこ
    Public Shared Sub SetForm_HOTEL_SMOKING(ByVal HOTEL_SMOKING As String, ByRef control_No As RadioButton, ByRef control_Yes As RadioButton)
        If HOTEL_SMOKING = AppConst.SMOKING.Code.No Then
            control_No.Checked = True
            control_Yes.Checked = False
        ElseIf HOTEL_SMOKING = AppConst.SMOKING.Code.Yes Then
            control_No.Checked = False
            control_Yes.Checked = True
        Else
            control_No.Checked = False
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_HOTEL_SMOKING_No(ByVal HOTEL_SMOKING As String, ByRef control_No As RadioButton)
        If HOTEL_SMOKING = AppConst.SMOKING.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_HOTEL_SMOKING_Yes(ByVal HOTEL_SMOKING As String, ByRef control_Yes As RadioButton)
        If HOTEL_SMOKING = AppConst.SMOKING.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub

    '宿泊手配
    Public Shared Sub SetForm_TEHAI_HOTEL(ByVal TEHAI_HOTEL As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If TEHAI_HOTEL = AppConst.TEHAI.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf TEHAI_HOTEL = AppConst.TEHAI.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = True
        End If
    End Sub
    Public Shared Sub SetForm_TEHAI_HOTEL_Yes(ByVal TEHAI_HOTEL As String, ByRef control_Yes As RadioButton)
        If TEHAI_HOTEL = AppConst.TEHAI.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_TEHAI_HOTEL_No(ByVal TEHAI_HOTEL As String, ByRef control_No As RadioButton)
        If TEHAI_HOTEL = AppConst.TEHAI.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_TEHAI_HOTEL(ByVal TEHAI_HOTEL As String, ByRef control As CheckBox)
        If TEHAI_HOTEL = AppConst.TEHAI.Code.Yes Then
            control.Checked = True
        Else
            control.Checked = False
        End If
    End Sub

    '公共交通手配
    Public Shared Sub SetForm_TEHAI_KOTSU(ByVal TEHAI_KOTSU As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        SetForm_TEHAI_HOTEL(TEHAI_KOTSU, control_Yes, control_No)
    End Sub
    Public Shared Sub SetForm_TEHAI_KOTSU_Yes(ByVal TEHAI_KOTSU As String, ByRef control_Yes As RadioButton)
        SetForm_TEHAI_HOTEL_Yes(TEHAI_KOTSU, control_Yes)
    End Sub
    Public Shared Sub SetForm_TEHAI_KOTSU_No(ByVal TEHAI_KOTSU As String, ByRef control_No As RadioButton)
        SetForm_TEHAI_HOTEL_No(TEHAI_KOTSU, control_No)
    End Sub
    Public Shared Sub SetForm_TEHAI_KOTSU(ByVal TEHAI_KOTSU As String, ByRef control As CheckBox)
        SetForm_TEHAI_HOTEL(TEHAI_KOTSU, control)
    End Sub

    ''航空便/JR
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_1(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
    '    If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR Then
    '        control_AIR.Checked = True
    '        control_JR.Checked = False
    '        control_None.Checked = False
    '    ElseIf O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR Then
    '        control_AIR.Checked = False
    '        control_JR.Checked = True
    '        control_None.Checked = False
    '    Else
    '        control_AIR.Checked = False
    '        control_JR.Checked = False
    '        control_None.Checked = True
    '    End If
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_1_AIR(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton)
    '    If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR Then
    '        control_AIR.Checked = True
    '    Else
    '        control_AIR.Checked = False
    '    End If
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_1_JR(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_JR As RadioButton)
    '    If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR Then
    '        control_JR.Checked = True
    '    Else
    '        control_JR.Checked = False
    '    End If
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_1_None(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_None As RadioButton)
    '    If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR Then
    '        control_None.Checked = False
    '    ElseIf O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR Then
    '        control_None.Checked = False
    '    Else
    '        control_None.Checked = True
    '    End If
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_2(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_2, control_AIR, control_JR, control_None)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_2_AIR(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_AIR(O_KOTSU_KUBUN_2, control_AIR)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_2_JR(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_JR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_JR(O_KOTSU_KUBUN_2, control_JR)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_2_None(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_None(O_KOTSU_KUBUN_2, control_None)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_3(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_3, control_AIR, control_JR, control_None)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_3_AIR(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_AIR(O_KOTSU_KUBUN_3, control_AIR)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_3_JR(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_JR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_JR(O_KOTSU_KUBUN_3, control_JR)
    'End Sub
    'Public Shared Sub SetForm_O_KOTSU_KUBUN_3_None(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_None(O_KOTSU_KUBUN_3, control_None)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_1(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_1, control_AIR, control_JR, control_None)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_1_AIR(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_AIR(F_KOTSU_KUBUN_1, control_AIR)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_1_JR(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_JR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_JR(F_KOTSU_KUBUN_1, control_JR)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_1_None(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_None(F_KOTSU_KUBUN_1, control_None)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_2(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_2, control_AIR, control_JR, control_None)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_2_AIR(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_AIR(F_KOTSU_KUBUN_2, control_AIR)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_2_JR(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_JR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_JR(F_KOTSU_KUBUN_2, control_JR)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_2_None(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_None(F_KOTSU_KUBUN_2, control_None)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_3(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_3, control_AIR, control_JR, control_None)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_3_AIR(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_AIR(F_KOTSU_KUBUN_3, control_AIR)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_3_JR(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_JR As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_JR(F_KOTSU_KUBUN_3, control_JR)
    'End Sub
    'Public Shared Sub SetForm_F_KOTSU_KUBUN_3_None(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_None As RadioButton)
    '    SetForm_O_KOTSU_KUBUN_1_None(F_KOTSU_KUBUN_3, control_None)
    'End Sub

    '宿泊備考欄
    Public Shared Sub SetForm_HOTEL_NOTE(ByVal HOTEL_NOTE As String, ByRef control As TextBox)
        control.Text = HOTEL_NOTE
    End Sub

    '性別
    Public Shared Sub SetForm_SEX(ByVal SEX As String, ByRef control_Male As RadioButton, ByRef control_Female As RadioButton)
        If SEX = AppConst.SEX.Code.Male Then
            control_Male.Checked = True
            control_Female.Checked = False
        ElseIf SEX = AppConst.SEX.Code.Female Then
            control_Male.Checked = False
            control_Female.Checked = True
        Else
            control_Male.Checked = False
            control_Female.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_SEX_Male(ByVal SEX As String, ByRef control_Male As RadioButton)
        If SEX = AppConst.SEX.Code.Male Then
            control_Male.Checked = True
        Else
            control_Male.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_SEX_Female(ByVal SEX As String, ByRef control_Female As RadioButton)
        If SEX = AppConst.SEX.Code.Female Then
            control_Female.Checked = True
        Else
            control_Female.Checked = False
        End If
    End Sub

    '年齢
    Public Shared Sub SetForm_AGE(ByVal AGE As String, ByRef control As TextBox)
        control.Text = AGE
    End Sub

    'チェックイン
    Public Shared Sub SetForm_CHECK_IN(ByVal CHECK_IN As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(CHECK_IN, control)
    End Sub
    Public Shared Sub SetForm_CHECK_IN(ByVal CHECK_IN As String, ByRef control As Label)
        control.Text = GetName_CHECK_IN(CHECK_IN)
    End Sub

    'チェックアウト
    Public Shared Sub SetForm_CHECK_OUT(ByVal CHECK_OUT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(CHECK_OUT, control)
    End Sub
    Public Shared Sub SetForm_CHECK_OUT(ByVal CHECK_out As String, ByRef control As Label)
        control.Text = GetName_CHECK_OUT(CHECK_out)
    End Sub

    ''乗車・搭乗日
    'Public Shared Sub SetForm_O_DATE_1(ByVal O_DATE_1 As String, ByRef control As DropDownList)
    '    control.SelectedIndex = CmnModule.GetSelectedIndex(O_DATE_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_DATE_2(ByVal O_DATE_2 As String, ByRef control As DropDownList)
    '    SetForm_O_DATE_1(O_DATE_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_DATE_3(ByVal O_DATE3 As String, ByRef control As DropDownList)
    '    SetForm_O_DATE_1(O_DATE3, control)
    'End Sub
    'Public Shared Sub SetForm_F_DATE_1(ByVal F_DATE_1 As String, ByRef control As DropDownList)
    '    SetForm_O_DATE_1(F_DATE_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_DATE_2(ByVal F_DATE_2 As String, ByRef control As DropDownList)
    '    SetForm_O_DATE_1(F_DATE_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_DATE_3(ByVal F_DATE_3 As String, ByRef control As DropDownList)
    '    SetForm_O_DATE_1(F_DATE_3, control)
    'End Sub

    ''区間
    'Public Shared Sub SetForm_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As String, ByRef control As TextBox)
    '    control.Text = O_AIRPORT1_1
    'End Sub
    'Public Shared Sub SetForm_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(O_AIRPORT2_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(O_AIRPORT1_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(O_AIRPORT2_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(O_AIRPORT1_3, control)
    'End Sub
    'Public Shared Sub SetForm_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(O_AIRPORT2_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(F_AIRPORT1_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(F_AIRPORT2_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(F_AIRPORT1_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(F_AIRPORT2_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(F_AIRPORT1_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As String, ByRef control As TextBox)
    '    SetForm_O_AIRPORT1_1(F_AIRPORT2_3, control)
    'End Sub

    ''新幹線・特急区間
    'Public Shared Sub SetForm_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As String, ByRef control As TextBox)
    '    control.Text = O_EXPRESS1_1
    'End Sub
    'Public Shared Sub SetForm_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(O_EXPRESS2_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(O_EXPRESS1_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(O_EXPRESS2_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(O_EXPRESS1_3, control)
    'End Sub
    'Public Shared Sub SetForm_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(O_EXPRESS2_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(F_EXPRESS1_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(F_EXPRESS2_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(F_EXPRESS1_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(F_EXPRESS2_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(F_EXPRESS1_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As String, ByRef control As TextBox)
    '    SetForm_O_EXPRESS1_1(F_EXPRESS2_3, control)
    'End Sub

    ''乗車券区間
    'Public Shared Sub SetForm_O_LOCAL1_1(ByVal O_LOCAL1_1 As String, ByRef control As TextBox)
    '    control.Text = O_LOCAL1_1
    'End Sub
    'Public Shared Sub SetForm_O_LOCAL2_1(ByVal O_LOCAL2_1 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(O_LOCAL2_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_LOCAL1_2(ByVal O_LOCAL1_2 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(O_LOCAL1_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_LOCAL2_2(ByVal O_LOCAL2_2 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(O_LOCAL2_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_LOCAL1_3(ByVal O_LOCAL1_3 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(O_LOCAL1_3, control)
    'End Sub
    'Public Shared Sub SetForm_O_LOCAL2_3(ByVal O_LOCAL2_3 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(O_LOCAL2_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_LOCAL1_1(ByVal F_LOCAL1_1 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(F_LOCAL1_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_LOCAL2_1(ByVal F_LOCAL2_1 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(F_LOCAL2_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_LOCAL1_2(ByVal F_LOCAL1_2 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(F_LOCAL1_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_LOCAL2_2(ByVal F_LOCAL2_2 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(F_LOCAL2_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_LOCAL1_3(ByVal F_LOCAL1_3 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(F_LOCAL1_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_LOCAL2_3(ByVal F_LOCAL2_3 As String, ByRef control As TextBox)
    '    SetForm_O_LOCAL1_1(F_LOCAL2_3, control)
    'End Sub

    ''時間
    'Public Shared Sub SetForm_O_TIME1_1(ByVal O_TIME1_1 As String, ByRef control As TextBox)
    '    control.Text = O_TIME1_1
    'End Sub
    'Public Shared Sub SetForm_O_TIME2_1(ByVal O_TIME2_1 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(O_TIME2_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_TIME1_2(ByVal O_TIME1_2 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(O_TIME1_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_TIME2_2(ByVal O_TIME2_2 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(O_TIME2_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_TIME1_3(ByVal O_TIME1_3 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(O_TIME1_3, control)
    'End Sub
    'Public Shared Sub SetForm_O_TIME2_3(ByVal O_TIME2_3 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(O_TIME2_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_TIME1_1(ByVal F_TIME1_1 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(F_TIME1_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_TIME2_1(ByVal F_TIME2_1 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(F_TIME2_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_TIME1_2(ByVal F_TIME1_2 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(F_TIME1_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_TIME2_2(ByVal F_TIME2_2 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(F_TIME2_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_TIME1_3(ByVal F_TIME1_3 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(F_TIME1_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_TIME2_3(ByVal F_TIME2_3 As String, ByRef control As TextBox)
    '    SetForm_O_TIME1_1(F_TIME2_3, control)
    'End Sub

    ''便名
    'Public Shared Sub SetForm_O_BIN_1(ByVal O_BIN_1 As String, ByRef control As TextBox)
    '    control.Text = O_BIN_1
    'End Sub
    'Public Shared Sub SetForm_O_BIN_2(ByVal O_BIN_2 As String, ByRef control As TextBox)
    '    SetForm_O_BIN_1(O_BIN_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_BIN_3(ByVal O_BIN_3 As String, ByRef control As TextBox)
    '    SetForm_O_BIN_1(O_BIN_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_BIN_1(ByVal F_BIN_1 As String, ByRef control As TextBox)
    '    SetForm_O_BIN_1(F_BIN_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_BIN_2(ByVal F_BIN_2 As String, ByRef control As TextBox)
    '    SetForm_O_BIN_1(F_BIN_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_BIN_3(ByVal F_BIN_3 As String, ByRef control As TextBox)
    '    SetForm_O_BIN_1(F_BIN_3, control)
    'End Sub

    ''座席希望
    'Public Shared Sub SetForm_O_SEAT_1(ByVal O_SEAT_1 As String, ByRef control As DropDownList)
    '    control.SelectedIndex = CmnModule.GetSelectedIndex(O_SEAT_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_SEAT_2(ByVal O_SEAT_2 As String, ByRef control As DropDownList)
    '    SetForm_O_SEAT_1(O_SEAT_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_SEAT_3(ByVal O_SEAT_3 As String, ByRef control As DropDownList)
    '    SetForm_O_SEAT_1(O_SEAT_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_SEAT_1(ByVal F_SEAT_1 As String, ByRef control As DropDownList)
    '    SetForm_O_SEAT_1(F_SEAT_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_SEAT_2(ByVal F_SEAT_2 As String, ByRef control As DropDownList)
    '    SetForm_O_SEAT_1(F_SEAT_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_SEAT_3(ByVal F_SEAT_3 As String, ByRef control As DropDownList)
    '    SetForm_O_SEAT_1(F_SEAT_3, control)
    'End Sub

    ''座席区分
    'Public Shared Sub SetForm_O_SEATCLASS_1(ByVal O_SEATCLASS_1 As String, ByRef control As DropDownList)
    '    control.SelectedIndex = CmnModule.GetSelectedIndex(O_SEATCLASS_1, control)
    'End Sub
    'Public Shared Sub SetForm_O_SEATCLASS_2(ByVal O_SEATCLASS_2 As String, ByRef control As DropDownList)
    '    SetForm_O_SEATCLASS_1(O_SEATCLASS_2, control)
    'End Sub
    'Public Shared Sub SetForm_O_SEATCLASS_3(ByVal O_SEATCLASS_3 As String, ByRef control As DropDownList)
    '    SetForm_O_SEATCLASS_1(O_SEATCLASS_3, control)
    'End Sub
    'Public Shared Sub SetForm_F_SEATCLASS_1(ByVal F_SEATCLASS_1 As String, ByRef control As DropDownList)
    '    SetForm_O_SEATCLASS_1(F_SEATCLASS_1, control)
    'End Sub
    'Public Shared Sub SetForm_F_SEATCLASS_2(ByVal F_SEATCLASS_2 As String, ByRef control As DropDownList)
    '    SetForm_O_SEATCLASS_1(F_SEATCLASS_2, control)
    'End Sub
    'Public Shared Sub SetForm_F_SEATCLASS_3(ByVal F_SEATCLASS_3 As String, ByRef control As DropDownList)
    '    SetForm_O_SEATCLASS_1(F_SEATCLASS_3, control)
    'End Sub

    '交通備考欄
    Public Shared Sub SetForm_KOTSU_NOTE(ByVal KOTSU_NOTE As String, ByRef control As TextBox)
        control.Text = KOTSU_NOTE
    End Sub

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


    '== プルダウン設定 ==
    '手配状況
    Public Shared Sub SetDropDownList_STATUS_TEHAI(ByRef STATUS_TEHAI As DropDownList)
        With STATUS_TEHAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.Fuyo, AppConst.STATUS_TEHAI.Code.Fuyo))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.Input, AppConst.STATUS_TEHAI.Code.Input))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.Change, AppConst.STATUS_TEHAI.Code.Change))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.Cancel, AppConst.STATUS_TEHAI.Code.Cancel))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelNG, AppConst.STATUS_TEHAI.Code.HotelNG))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.KotsuNG, AppConst.STATUS_TEHAI.Code.KotsuNG))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelNG_KotsuNG, AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.KotsuOK, AppConst.STATUS_TEHAI.Code.KotsuOK))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelOK, AppConst.STATUS_TEHAI.Code.HotelOK))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.OKToFuyo, AppConst.STATUS_TEHAI.Code.OKToFuyo))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.OkToChange, AppConst.STATUS_TEHAI.Code.OkToChange))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.OKToCancel, AppConst.STATUS_TEHAI.Code.OKToCancel))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.EndToFuyo, AppConst.STATUS_TEHAI.Code.EndToFuyo))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.EndToChange, AppConst.STATUS_TEHAI.Code.EndToChange))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.EndToCancel, AppConst.STATUS_TEHAI.Code.EndToCancel))
        End With
    End Sub

    ''チェックイン日
    'Public Shared Sub SetDropDownList_CHECK_IN(ByRef CHECK_IN As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    Dim strSQL As String
    '    Dim RsData As System.Data.SqlClient.SqlDataReader

    '    With CHECK_IN
    '        .Items.Clear()
    '        .Items.Add(New ListItem("---", "0"))

    '        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.CHECK_IN)
    '        RsData = CmnDb.Read(strSQL, DbConn)
    '        While RsData.Read()
    '            .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
    '        End While
    '        RsData.Close()
    '    End With
    'End Sub

    ''チェックアウト日
    'Public Shared Sub SetDropDownList_CHECK_OUT(ByRef CHECK_OUT As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    Dim strSQL As String
    '    Dim RsData As System.Data.SqlClient.SqlDataReader

    '    With CHECK_OUT
    '        .Items.Clear()
    '        .Items.Add(New ListItem("---", "0"))

    '        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.CHECK_OUT)
    '        RsData = CmnDb.Read(strSQL, DbConn)
    '        While RsData.Read()
    '            .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
    '        End While
    '        RsData.Close()
    '    End With
    'End Sub

    ''座席希望
    'Public Shared Sub SetDropDownList_O_SEAT_1(ByRef O_SEAT_1 As DropDownList)
    '    With O_SEAT_1
    '        .Items.Clear()
    '        .Items.Add(New ListItem("---", "0"))

    '        .Items.Add(New ListItem(AppConst.SEAT.Name.Window, AppConst.SEAT.Code.Window))
    '        .Items.Add(New ListItem(AppConst.SEAT.Name.Aisle, AppConst.SEAT.Code.Aisle))
    '    End With
    'End Sub
    'Public Shared Sub SetDropDownList_O_SEAT_2(ByRef O_SEAT_2 As DropDownList)
    '    SetDropDownList_O_SEAT_1(O_SEAT_2)
    'End Sub
    'Public Shared Sub SetDropDownList_O_SEAT_3(ByRef O_SEAT_3 As DropDownList)
    '    SetDropDownList_O_SEAT_1(O_SEAT_3)
    'End Sub
    'Public Shared Sub SetDropDownList_F_SEAT_1(ByRef F_SEAT_1 As DropDownList)
    '    SetDropDownList_O_SEAT_1(F_SEAT_1)
    'End Sub
    'Public Shared Sub SetDropDownList_F_SEAT_2(ByRef F_SEAT_2 As DropDownList)
    '    SetDropDownList_O_SEAT_1(F_SEAT_2)
    'End Sub
    'Public Shared Sub SetDropDownList_F_SEAT_3(ByRef F_SEAT_3 As DropDownList)
    '    SetDropDownList_O_SEAT_1(F_SEAT_3)
    'End Sub

    ''座席区分
    'Public Shared Sub SetDropDownList_O_SEATCLASS_1(ByRef O_SEATCLASS_1 As DropDownList)
    '    With O_SEATCLASS_1
    '        .Items.Clear()
    '        .Items.Add(New ListItem("---", "0"))

    '        .Items.Add(New ListItem(AppConst.SEATCLASS.Name.Regular, AppConst.SEATCLASS.Code.Regular))
    '        .Items.Add(New ListItem(AppConst.SEATCLASS.Name.Premium, AppConst.SEATCLASS.Code.Premium))
    '        .Items.Add(New ListItem(AppConst.SEATCLASS.Name.Unreserved, AppConst.SEATCLASS.Code.Unreserved))
    '    End With
    'End Sub
    'Public Shared Sub SetDropDownList_O_SEATCLASS_2(ByRef O_SEATCLASS_2 As DropDownList)
    '    SetDropDownList_O_SEATCLASS_1(O_SEATCLASS_2)
    'End Sub
    'Public Shared Sub SetDropDownList_O_SEATCLASS_3(ByRef O_SEATCLASS_3 As DropDownList)
    '    SetDropDownList_O_SEATCLASS_1(O_SEATCLASS_3)
    'End Sub
    'Public Shared Sub SetDropDownList_F_SEATCLASS_1(ByRef F_SEATCLASS_1 As DropDownList)
    '    SetDropDownList_O_SEATCLASS_1(F_SEATCLASS_1)
    'End Sub
    'Public Shared Sub SetDropDownList_F_SEATCLASS_2(ByRef F_SEATCLASS_2 As DropDownList)
    '    SetDropDownList_O_SEATCLASS_1(F_SEATCLASS_2)
    'End Sub
    'Public Shared Sub SetDropDownList_F_SEATCLASS_3(ByRef F_SEATCLASS_3 As DropDownList)
    '    SetDropDownList_O_SEATCLASS_1(F_SEATCLASS_3)
    'End Sub

    ''乗車・搭乗日: 往路
    'Public Shared Sub SetDropDownList_O_DATE_1(ByRef O_DATE_1 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    Dim strSQL As String
    '    Dim RsData As System.Data.SqlClient.SqlDataReader

    '    With O_DATE_1
    '        .Items.Clear()
    '        .Items.Add(New ListItem("---", "0"))

    '        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.O_DATE)
    '        RsData = CmnDb.Read(strSQL, DbConn)
    '        While RsData.Read()
    '            .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
    '        End While
    '        RsData.Close()
    '    End With
    'End Sub
    'Public Shared Sub SetDropDownList_O_DATE_2(ByRef O_DATE_2 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    SetDropDownList_O_DATE_1(O_DATE_2, DbConn)
    'End Sub
    'Public Shared Sub SetDropDownList_O_DATE_3(ByRef O_DATE_3 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    SetDropDownList_O_DATE_1(O_DATE_3, DbConn)
    'End Sub

    ''乗車・搭乗日: 復路
    'Public Shared Sub SetDropDownList_F_DATE_1(ByRef F_DATE_1 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    Dim strSQL As String
    '    Dim RsData As System.Data.SqlClient.SqlDataReader

    '    With F_DATE_1
    '        .Items.Clear()
    '        .Items.Add(New ListItem("---", "0"))

    '        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.F_DATE)
    '        RsData = CmnDb.Read(strSQL, DbConn)
    '        While RsData.Read()
    '            .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
    '        End While
    '        RsData.Close()
    '    End With
    'End Sub
    'Public Shared Sub SetDropDownList_F_DATE_2(ByRef F_DATE_2 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    SetDropDownList_F_DATE_1(F_DATE_2, DbConn)
    'End Sub
    'Public Shared Sub SetDropDownList_F_DATE_3(ByRef F_DATE_3 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
    '    SetDropDownList_F_DATE_1(F_DATE_3, DbConn)
    'End Sub


    '== コントロールからDB用の値を返す ==
    'ログインID
    Public Shared Function GetValue_LOGIN_ID(ByVal LOGIN_ID As TextBox) As String
        Return Trim(StrConv(LOGIN_ID.Text, VbStrConv.Narrow))
    End Function

    'パスワード
    Public Shared Function GetValue_PASSWORD(ByVal PASSWORD As TextBox) As String
        Return Trim(StrConv(PASSWORD.Text, VbStrConv.Narrow))
    End Function

    '氏名(漢字)
    Public Shared Function GetValue_DR_NAME(ByVal DR_NAME As TextBox) As String
        Return Trim(StrConv(DR_NAME.Text, VbStrConv.Wide))
    End Function

    '氏名(カナ)
    Public Shared Function GetValue_DR_NAME_KANA(ByVal DR_NAME_KANA As TextBox) As String
        Return Trim(StrConv(DR_NAME_KANA.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function

    'メールアドレス
    Public Shared Function GetValue_EMAIL(ByVal EMAIL As TextBox) As String
        Return Trim(StrConv(EMAIL.Text, VbStrConv.Narrow))
    End Function

    '性別
    Public Shared Function GetValue_SEX(ByVal SEX_Male As RadioButton, ByVal SEX_Female As RadioButton) As String
        If SEX_Male.Checked = True Then
            Return AppConst.SEX.Code.Male
        ElseIf SEX_Female.Checked = True Then
            Return AppConst.SEX.Code.Female
        Else
            Return ""
        End If
    End Function

    '年齢
    Public Shared Function GetValue_AGE(ByVal AGE As TextBox) As String
        If Trim(AGE.Text) = "" Then
            Return ""
        Else
            Return Trim(StrConv(AGE.Text, VbStrConv.Narrow))
        End If
    End Function

    '宿泊手配
    Public Shared Function GetValue_TEHAI_HOTEL(ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal TEHAI_HOTEL_No As RadioButton) As String
        If TEHAI_HOTEL_Yes.Checked = True Then
            Return AppConst.TEHAI.Code.Yes
        ElseIf TEHAI_HOTEL_No.Checked = True Then
            Return AppConst.TEHAI.Code.No
        Else
            Return AppConst.TEHAI.DefaultValue
        End If
    End Function

    'チェックイン日
    Public Shared Function GetValue_CHECK_IN(ByVal CHECK_IN As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(CHECK_IN)
    End Function

    'チェックアウト日
    Public Shared Function GetValue_CHECK_OUT(ByVal CHECK_OUT As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(CHECK_OUT)
    End Function

    'おたばこ
    Public Shared Function GetValue_HOTEL_SMOKING(ByVal HOTEL_SMOKING_No As RadioButton, ByVal HOTEL_SMOKING_Yes As RadioButton) As String
        If HOTEL_SMOKING_No.Checked = True Then
            Return AppConst.SMOKING.Code.No
        ElseIf HOTEL_SMOKING_Yes.Checked = True Then
            Return AppConst.SMOKING.Code.Yes
        Else
            Return ""
        End If
    End Function

    '宿泊備考欄
    Public Shared Function GetValue_HOTEL_NOTE(ByVal HOTEL_NOTE As TextBox) As String
        Return Trim(HOTEL_NOTE.Text)
    End Function

    '公共交通手配
    Public Shared Function GetValue_TEHAI_KOTSU(ByVal TEHAI_KOTSU_Yes As RadioButton, ByVal TEHAI_KOTSU_No As RadioButton) As String
        If TEHAI_KOTSU_Yes.Checked = True Then
            Return AppConst.TEHAI.Code.Yes
        ElseIf TEHAI_KOTSU_No.Checked = True Then
            Return AppConst.TEHAI.Code.No
        Else
            Return AppConst.TEHAI.DefaultValue
        End If
    End Function

    ''乗車・搭乗日
    'Public Shared Function GetValue_O_DATE_1(ByVal O_DATE_1 As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(O_DATE_1)
    'End Function
    'Public Shared Function GetValue_O_DATE_2(ByVal O_DATE_2 As DropDownList) As String
    '    Return GetValue_O_DATE_1(O_DATE_2)
    'End Function
    'Public Shared Function GetValue_O_DATE_3(ByVal O_DATE_3 As DropDownList) As String
    '    Return GetValue_O_DATE_1(O_DATE_3)
    'End Function
    'Public Shared Function GetValue_F_DATE_1(ByVal F_DATE_1 As DropDownList) As String
    '    Return GetValue_O_DATE_1(F_DATE_1)
    'End Function
    'Public Shared Function GetValue_F_DATE_2(ByVal F_DATE_2 As DropDownList) As String
    '    Return GetValue_O_DATE_1(F_DATE_2)
    'End Function
    'Public Shared Function GetValue_F_DATE_3(ByVal F_DATE_3 As DropDownList) As String
    '    Return GetValue_O_DATE_1(F_DATE_3)
    'End Function

    ''区間
    'Public Shared Function GetValue_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As TextBox) As String
    '    Return Trim(O_AIRPORT1_1.Text)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT2_1)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT1_2)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT2_2)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT1_3)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT2_3)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT1_1)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT2_1)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT1_2)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT2_2)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT1_3)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As TextBox) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT2_3)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    If O_KOTSU_KUBUN_1_AIR.Enabled = True AndAlso O_KOTSU_KUBUN_1_AIR.Checked = True Then
    '        Return Trim(O_AIRPORT1_1.Text)
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Public Shared Function GetValue_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT2_1, O_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT1_2, O_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT2_2, O_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT1_3, O_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(O_AIRPORT2_3, O_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT1_1, F_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT2_1, F_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT1_2, F_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT2_2, F_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT1_3, F_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_AIRPORT1_1(F_AIRPORT2_3, F_KOTSU_KUBUN_3_AIR)
    'End Function

    ''新幹線・特急区間
    'Public Shared Function GetValue_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As TextBox) As String
    '    Return Trim(O_EXPRESS1_1.Text)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS2_1)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS1_2)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS2_2)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS1_3)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS2_3)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS1_1)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS2_1)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS1_2)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS2_2)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS1_3)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As TextBox) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS2_3)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    If O_KOTSU_KUBUN_1_AIR.Enabled = True AndAlso O_KOTSU_KUBUN_1_AIR.Checked = True Then
    '        Return Trim(O_EXPRESS1_1.Text)
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Public Shared Function GetValue_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS2_1, O_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS1_2, O_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS2_2, O_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS1_3, O_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(O_EXPRESS2_3, O_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS1_1, F_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS2_1, F_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS1_2, F_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS2_2, F_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS1_3, F_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_EXPRESS1_1(F_EXPRESS2_3, F_KOTSU_KUBUN_3_AIR)
    'End Function

    ''乗車券区間
    'Public Shared Function GetValue_O_LOCAL1_1(ByVal O_LOCAL1_1 As TextBox) As String
    '    Return Trim(O_LOCAL1_1.Text)
    'End Function
    'Public Shared Function GetValue_O_LOCAL2_1(ByVal O_LOCAL2_1 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL2_1)
    'End Function
    'Public Shared Function GetValue_O_LOCAL1_2(ByVal O_LOCAL1_2 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL1_2)
    'End Function
    'Public Shared Function GetValue_O_LOCAL2_2(ByVal O_LOCAL2_2 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL2_2)
    'End Function
    'Public Shared Function GetValue_O_LOCAL1_3(ByVal O_LOCAL1_3 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL1_3)
    'End Function
    'Public Shared Function GetValue_O_LOCAL2_3(ByVal O_LOCAL2_3 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL2_3)
    'End Function
    'Public Shared Function GetValue_F_LOCAL1_1(ByVal F_LOCAL1_1 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL1_1)
    'End Function
    'Public Shared Function GetValue_F_LOCAL2_1(ByVal F_LOCAL2_1 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL2_1)
    'End Function
    'Public Shared Function GetValue_F_LOCAL1_2(ByVal F_LOCAL1_2 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL1_2)
    'End Function
    'Public Shared Function GetValue_F_LOCAL2_2(ByVal F_LOCAL2_2 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL2_2)
    'End Function
    'Public Shared Function GetValue_F_LOCAL1_3(ByVal F_LOCAL1_3 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL1_3)
    'End Function
    'Public Shared Function GetValue_F_LOCAL2_3(ByVal F_LOCAL2_3 As TextBox) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL2_3)
    'End Function
    'Public Shared Function GetValue_O_LOCAL1_1(ByVal O_LOCAL1_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    If O_KOTSU_KUBUN_1_AIR.Enabled = True AndAlso O_KOTSU_KUBUN_1_AIR.Checked = True Then
    '        Return Trim(O_LOCAL1_1.Text)
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Public Shared Function GetValue_O_LOCAL2_1(ByVal O_LOCAL2_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL2_1, O_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_O_LOCAL1_2(ByVal O_LOCAL1_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL1_2, O_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_O_LOCAL2_2(ByVal O_LOCAL2_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL2_2, O_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_O_LOCAL1_3(ByVal O_LOCAL1_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL1_3, O_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_O_LOCAL2_3(ByVal O_LOCAL2_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(O_LOCAL2_3, O_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_F_LOCAL1_1(ByVal F_LOCAL1_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL1_1, F_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_F_LOCAL2_1(ByVal F_LOCAL2_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL2_1, F_KOTSU_KUBUN_1_AIR)
    'End Function
    'Public Shared Function GetValue_F_LOCAL1_2(ByVal F_LOCAL1_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL1_2, F_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_F_LOCAL2_2(ByVal F_LOCAL2_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL2_2, F_KOTSU_KUBUN_2_AIR)
    'End Function
    'Public Shared Function GetValue_F_LOCAL1_3(ByVal F_LOCAL1_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL1_3, F_KOTSU_KUBUN_3_AIR)
    'End Function
    'Public Shared Function GetValue_F_LOCAL2_3(ByVal F_LOCAL2_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
    '    Return GetValue_O_LOCAL1_1(F_LOCAL2_3, F_KOTSU_KUBUN_3_AIR)
    'End Function

    ''時間
    'Public Shared Function GetValue_O_TIME1_1(ByVal O_TIME1_1 As TextBox) As String
    '    Return Trim(StrConv(O_TIME1_1.Text, VbStrConv.Narrow))
    'End Function
    'Public Shared Function GetValue_O_TIME2_1(ByVal O_TIME2_1 As TextBox) As String
    '    Return GetValue_O_TIME1_1(O_TIME2_1)
    'End Function
    'Public Shared Function GetValue_O_TIME1_2(ByVal O_TIME1_2 As TextBox) As String
    '    Return GetValue_O_TIME1_1(O_TIME1_2)
    'End Function
    'Public Shared Function GetValue_O_TIME2_2(ByVal O_TIME2_2 As TextBox) As String
    '    Return GetValue_O_TIME1_1(O_TIME2_2)
    'End Function
    'Public Shared Function GetValue_O_TIME1_3(ByVal O_TIME1_3 As TextBox) As String
    '    Return GetValue_O_TIME1_1(O_TIME1_3)
    'End Function
    'Public Shared Function GetValue_O_TIME2_3(ByVal O_TIME2_3 As TextBox) As String
    '    Return GetValue_O_TIME1_1(O_TIME2_3)
    'End Function
    'Public Shared Function GetValue_F_TIME1_1(ByVal F_TIME1_1 As TextBox) As String
    '    Return GetValue_O_TIME1_1(F_TIME1_1)
    'End Function
    'Public Shared Function GetValue_F_TIME2_1(ByVal F_TIME2_1 As TextBox) As String
    '    Return GetValue_O_TIME1_1(F_TIME2_1)
    'End Function
    'Public Shared Function GetValue_F_TIME1_2(ByVal F_TIME1_2 As TextBox) As String
    '    Return GetValue_O_TIME1_1(F_TIME1_2)
    'End Function
    'Public Shared Function GetValue_F_TIME2_2(ByVal F_TIME2_2 As TextBox) As String
    '    Return GetValue_O_TIME1_1(F_TIME2_2)
    'End Function
    'Public Shared Function GetValue_F_TIME1_3(ByVal F_TIME1_3 As TextBox) As String
    '    Return GetValue_O_TIME1_1(F_TIME1_3)
    'End Function
    'Public Shared Function GetValue_F_TIME2_3(ByVal F_TIME2_3 As TextBox) As String
    '    Return GetValue_O_TIME1_1(F_TIME2_3)
    'End Function

    ''便名
    'Public Shared Function GetValue_O_BIN_1(ByVal O_BIN_1 As TextBox) As String
    '    Return Trim(O_BIN_1.Text)
    'End Function
    'Public Shared Function GetValue_O_BIN_2(ByVal O_BIN_2 As TextBox) As String
    '    Return GetValue_O_BIN_1(O_BIN_2)
    'End Function
    'Public Shared Function GetValue_O_BIN_3(ByVal O_BIN_3 As TextBox) As String
    '    Return GetValue_O_BIN_1(O_BIN_3)
    'End Function
    'Public Shared Function GetValue_F_BIN_1(ByVal F_BIN_1 As TextBox) As String
    '    Return GetValue_O_BIN_1(F_BIN_1)
    'End Function
    'Public Shared Function GetValue_F_BIN_2(ByVal F_BIN_2 As TextBox) As String
    '    Return GetValue_O_BIN_1(F_BIN_2)
    'End Function
    'Public Shared Function GetValue_F_BIN_3(ByVal F_BIN_3 As TextBox) As String
    '    Return GetValue_O_BIN_1(F_BIN_3)
    'End Function

    ''座席希望
    'Public Shared Function GetValue_O_SEAT_1(ByVal O_SEAT_1 As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(O_SEAT_1)
    'End Function
    'Public Shared Function GetValue_O_SEAT_2(ByVal O_SEAT_2 As DropDownList) As String
    '    Return GetValue_O_SEAT_1(O_SEAT_2)
    'End Function
    'Public Shared Function GetValue_O_SEAT_3(ByVal O_SEAT_3 As DropDownList) As String
    '    Return GetValue_O_SEAT_1(O_SEAT_3)
    'End Function
    'Public Shared Function GetValue_F_SEAT_1(ByVal F_SEAT_1 As DropDownList) As String
    '    Return GetValue_O_SEAT_1(F_SEAT_1)
    'End Function
    'Public Shared Function GetValue_F_SEAT_2(ByVal F_SEAT_2 As DropDownList) As String
    '    Return GetValue_O_SEAT_1(F_SEAT_2)
    'End Function
    'Public Shared Function GetValue_F_SEAT_3(ByVal F_SEAT_3 As DropDownList) As String
    '    Return GetValue_O_SEAT_1(F_SEAT_3)
    'End Function

    ''座席区分
    'Public Shared Function GetValue_O_SEATCLASS_1(ByVal O_SEATCLASS_1 As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(O_SEATCLASS_1)
    'End Function
    'Public Shared Function GetValue_O_SEATCLASS_2(ByVal O_SEATCLASS_2 As DropDownList) As String
    '    Return GetValue_O_SEATCLASS_1(O_SEATCLASS_2)
    'End Function
    'Public Shared Function GetValue_O_SEATCLASS_3(ByVal O_SEATCLASS_3 As DropDownList) As String
    '    Return GetValue_O_SEATCLASS_1(O_SEATCLASS_3)
    'End Function
    'Public Shared Function GetValue_F_SEATCLASS_1(ByVal F_SEATCLASS_1 As DropDownList) As String
    '    Return GetValue_O_SEATCLASS_1(F_SEATCLASS_1)
    'End Function
    'Public Shared Function GetValue_F_SEATCLASS_2(ByVal F_SEATCLASS_2 As DropDownList) As String
    '    Return GetValue_O_SEATCLASS_1(F_SEATCLASS_2)
    'End Function
    'Public Shared Function GetValue_F_SEATCLASS_3(ByVal F_SEATCLASS_3 As DropDownList) As String
    '    Return GetValue_O_SEATCLASS_1(F_SEATCLASS_3)
    'End Function

    '交通備考欄
    Public Shared Function GetValue_KOTSU_NOTE(ByVal NOTEL_KOTSU As TextBox) As String
        Return Trim(NOTEL_KOTSU.Text)
    End Function

    '備考欄
    Public Shared Function GetValue_NOTES(ByVal NOTES As TextBox) As String
        Return Trim(NOTES.Text)
    End Function

    '電話番号
    Public Shared Function GetValue_TEL(ByVal TEL As TextBox) As String
        Return Trim(StrConv(TEL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_TEL(ByVal TEL_1 As TextBox, ByVal TEL_2 As TextBox, ByVal TEL_3 As TextBox) As String
        Dim wStr As String = Trim(StrConv(TEL_1.Text & "-" & TEL_2.Text & "-" & TEL_3.Text, VbStrConv.Narrow))
        If wStr = "--" Then wStr = ""
        Return wStr
    End Function

    '携帯電話番号
    Public Shared Function GetValue_KEITAI(ByVal KEITAI As TextBox) As String
        Return GetValue_TEL(KEITAI)
    End Function
    Public Shared Function GetValue_KEITAI(ByVal KEITAI_1 As TextBox, ByVal KEITAI_2 As TextBox, ByVal KEITAI_3 As TextBox) As String
        Return GetValue_TEL(KEITAI_1, KEITAI_2, KEITAI_3)
    End Function

    '郵便番号
    Public Shared Function GetValue_ZIP(ByVal ZIP As TextBox) As String
        Return Trim(StrConv(ZIP.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ZIP(ByVal ZIP_1 As TextBox, ByVal ZIP_2 As TextBox) As String
        Dim wStr As String = Trim(StrConv(ZIP_1.Text & "-" & ZIP_2.Text, VbStrConv.Narrow))
        If wStr = "-" Then wStr = ""
        Return wStr
    End Function

    '手配状況
    Public Shared Function GetValue_STATUS_TEHAI(ByVal STATUS_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(STATUS_TEHAI)
    End Function

         
    '==
    '手配依頼ありはTrueを返す
    Public Shared Function IsTEHAI_HOTEL(ByVal TEHAI_HOTEL As String) As Boolean
        Select Case TEHAI_HOTEL
            Case AppConst.TEHAI.Code.Yes, AppConst.TEHAI.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function
    Public Shared Function IsTEHAI_KOTSU(ByVal TEHAI_KOTSU As String) As Boolean
        Select Case TEHAI_KOTSU
            Case AppConst.TEHAI.Code.Yes, AppConst.TEHAI.Name.Yes
                Return True
            Case Else
                Return False
        End Select
    End Function

    '参加取消はTrueを返す
    Public Shared Function IsCanceled(ByVal data As String) As Boolean
        Select Case data
            Case AppConst.RECORD_KUBUN.Code.Cancel, AppConst.RECORD_KUBUN.Name.Cancel
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
    '        Case AppConst.STATUS_TEHAI.Code.HotelOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
    '             AppConst.STATUS_TEHAI.Name.HotelOK, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function

    ''公共交通手配完了=Trueを返す
    'Public Shared Function IsOK_TEHAI_KOTSU(ByVal STATUS_TEHAI As String) As Boolean
    '    Select Case STATUS_TEHAI
    '        Case AppConst.STATUS_TEHAI.Code.KotsuOK, AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
    '             AppConst.STATUS_TEHAI.Name.KotsuOK, AppConst.STATUS_TEHAI.Name.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
    '            Return True
    '        Case Else
    '            Return False
    '    End Select
    'End Function


    '== 列挙型 ==
    'テーブル
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
        [TBL_KENSAKU]
    End Enum

End Class
