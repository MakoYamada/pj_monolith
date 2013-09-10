Imports CommonLib
Imports AppLib
Imports System.Web.UI.WebControls
Imports System.Drawing

Public Class AppModule

    '== データベース関連 ==
    'テーブルから構造体にデータをセット
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

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_OFFICE As TableDef.MS_OFFICE.DataStruct) As TableDef.MS_OFFICE.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_OFFICE.Column.OFFICE.ToUpper Then MS_OFFICE.OFFICE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_OFFICE.Column.ZIP.ToUpper Then MS_OFFICE.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_OFFICE.Column.ADDRESS.ToUpper Then MS_OFFICE.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_OFFICE.Column.TEL.ToUpper Then MS_OFFICE.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_OFFICE.Column.FAX.ToUpper Then MS_OFFICE.FAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_OFFICE.Column.SORT_NO.ToUpper Then MS_OFFICE.SORT_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_OFFICE
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_MEMBER As TableDef.MS_MEMBER.DataStruct) As TableDef.MS_MEMBER.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_ID.ToUpper Then MS_MEMBER.MEMBER_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_PW.ToUpper Then MS_MEMBER.MEMBER_PW = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.LOGIN_FLAG.ToUpper Then MS_MEMBER.LOGIN_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.UPD_DATE.ToUpper Then MS_MEMBER.UPD_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.UPD_USER.ToUpper Then MS_MEMBER.UPD_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.UPD_PGM.ToUpper Then MS_MEMBER.UPD_PGM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.INS_DATE.ToUpper Then MS_MEMBER.INS_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.INS_USER.ToUpper Then MS_MEMBER.INS_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.INS_PGM.ToUpper Then MS_MEMBER.INS_PGM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_NAME_FIRST.ToUpper Then MS_MEMBER.MEMBER_NAME_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_NAME_LAST.ToUpper Then MS_MEMBER.MEMBER_NAME_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA_FIRST.ToUpper Then MS_MEMBER.MEMBER_NAME_KANA_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA_LAST.ToUpper Then MS_MEMBER.MEMBER_NAME_KANA_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.OFFICE.ToUpper Then MS_MEMBER.OFFICE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.ZIP.ToUpper Then MS_MEMBER.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.ADDRESS.ToUpper Then MS_MEMBER.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.TEL.ToUpper Then MS_MEMBER.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.FAX.ToUpper Then MS_MEMBER.FAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.KEITAI.ToUpper Then MS_MEMBER.KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.PC_MAIL.ToUpper Then MS_MEMBER.PC_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.KEITAI_MAIL.ToUpper Then MS_MEMBER.KEITAI_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.SEX.ToUpper Then MS_MEMBER.SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.AGE.ToUpper Then MS_MEMBER.AGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.ATTEND.ToUpper Then MS_MEMBER.ATTEND = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_NAME.ToUpper Then MS_MEMBER.MEMBER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA.ToUpper Then MS_MEMBER.MEMBER_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MEMBER.Column.SORT_NO.ToUpper Then MS_MEMBER.SORT_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_MEMBER
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As TableDef.TBL_DR.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DATA_NO.ToUpper Then TBL_DR.DATA_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_ID.ToUpper Then TBL_DR.MEMBER_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_ID.ToUpper Then TBL_DR.DR_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.RECORD_KUBUN.ToUpper Then TBL_DR.RECORD_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.STATUS_TEHAI.ToUpper Then TBL_DR.STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.STATUS_PAYMENT.ToUpper Then TBL_DR.STATUS_PAYMENT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.UPD_DATE.ToUpper Then TBL_DR.UPD_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.UPD_USER.ToUpper Then TBL_DR.UPD_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.UPD_PGM.ToUpper Then TBL_DR.UPD_PGM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.INS_DATE.ToUpper Then TBL_DR.INS_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.INS_USER.ToUpper Then TBL_DR.INS_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.INS_PGM.ToUpper Then TBL_DR.INS_PGM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.INS_TYPE.ToUpper Then TBL_DR.INS_TYPE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_MAIL.ToUpper Then TBL_DR.DR_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_NAME_FIRST.ToUpper Then TBL_DR.DR_NAME_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_NAME_LAST.ToUpper Then TBL_DR.DR_NAME_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_NAME_KANA_FIRST.ToUpper Then TBL_DR.DR_NAME_KANA_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_NAME_KANA_LAST.ToUpper Then TBL_DR.DR_NAME_KANA_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PREFECTURES_NO.ToUpper Then TBL_DR.PREFECTURES_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SHISETSU_NAME.ToUpper Then TBL_DR.SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SHISETSU_NAME_KANA.ToUpper Then TBL_DR.SHISETSU_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.KAMOKU.ToUpper Then TBL_DR.KAMOKU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.YAKUSHOKU.ToUpper Then TBL_DR.YAKUSHOKU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SEX.ToUpper Then TBL_DR.SEX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.AGE.ToUpper Then TBL_DR.AGE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PARTY.ToUpper Then TBL_DR.PARTY = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.WETLAB_FLAG.ToUpper Then TBL_DR.WETLAB_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.WETLAB_COURSE.ToUpper Then TBL_DR.WETLAB_COURSE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SANKA_KUBUN.ToUpper Then TBL_DR.SANKA_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TEHAI_HOTEL.ToUpper Then TBL_DR.TEHAI_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_NO.ToUpper Then TBL_DR.HOTEL_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ROOM_RATE.ToUpper Then TBL_DR.ROOM_RATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.STAY_DATE.ToUpper Then TBL_DR.STAY_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.CHECK_IN.ToUpper Then TBL_DR.CHECK_IN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.CHECK_OUT.ToUpper Then TBL_DR.CHECK_OUT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_SMOKING.ToUpper Then TBL_DR.HOTEL_SMOKING = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_NAME.ToUpper Then TBL_DR.HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_ADDRESS.ToUpper Then TBL_DR.HOTEL_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_TEL.ToUpper Then TBL_DR.HOTEL_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_FAX.ToUpper Then TBL_DR.HOTEL_FAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ROOM_TYPE.ToUpper Then TBL_DR.ROOM_TYPE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ROOM_SU.ToUpper Then TBL_DR.ROOM_SU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_SHIHARAI.ToUpper Then TBL_DR.HOTELPRINT_SHIHARAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_CHECKIN.ToUpper Then TBL_DR.HOTELPRINT_CHECKIN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_RENRAKU.ToUpper Then TBL_DR.HOTELPRINT_RENRAKU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_CHECKIN_DATE.ToUpper Then TBL_DR.HOTEL_CHECKIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTEL_CHECKOUT_DATE.ToUpper Then TBL_DR.HOTEL_CHECKOUT_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_SHIHARAI_IDX.ToUpper Then TBL_DR.HOTELPRINT_SHIHARAI_IDX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_CHECKIN_IDX.ToUpper Then TBL_DR.HOTELPRINT_CHECKIN_IDX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_RENRAKU_IDX.ToUpper Then TBL_DR.HOTELPRINT_RENRAKU_IDX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NOTE_HOTEL.ToUpper Then TBL_DR.NOTE_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TEHAIMAIL_HOTEL.ToUpper Then TBL_DR.TEHAIMAIL_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_FLAG.ToUpper Then TBL_DR.ACCOMPANY_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NOTE_ACCOMPANY.ToUpper Then TBL_DR.NOTE_ACCOMPANY = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_STAY.ToUpper Then TBL_DR.ACCOMPANY_STAY = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_SAME_ROOM.ToUpper Then TBL_DR.ACCOMPANY_SAME_ROOM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_STAY_DATE.ToUpper Then TBL_DR.ACCOMPANY_STAY_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHECK_IN.ToUpper Then TBL_DR.ACCOMPANY_CHECK_IN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHECK_OUT.ToUpper Then TBL_DR.ACCOMPANY_CHECK_OUT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_ADULT_SU.ToUpper Then TBL_DR.ACCOMPANY_ADULT_SU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SU.ToUpper Then TBL_DR.ACCOMPANY_CHILD_SU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_AGE_1.ToUpper Then TBL_DR.ACCOMPANY_CHILD_AGE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_AGE_2.ToUpper Then TBL_DR.ACCOMPANY_CHILD_AGE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_BED_1.ToUpper Then TBL_DR.ACCOMPANY_CHILD_BED_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_BED_2.ToUpper Then TBL_DR.ACCOMPANY_CHILD_BED_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SEX_1.ToUpper Then TBL_DR.ACCOMPANY_CHILD_SEX_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SEX_2.ToUpper Then TBL_DR.ACCOMPANY_CHILD_SEX_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCOMPANY_ROOM_RATE.ToUpper Then TBL_DR.ACCOMPANY_ROOM_RATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TEHAI_KOTSU.ToUpper Then TBL_DR.TEHAI_KOTSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.KOTSU_NO.ToUpper Then TBL_DR.KOTSU_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_KOTSU_FARE.ToUpper Then TBL_DR.O_KOTSU_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_KOTSU_FARE.ToUpper Then TBL_DR.F_KOTSU_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_KOTSU_KUBUN_1.ToUpper Then TBL_DR.O_KOTSU_KUBUN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_DATE_1.ToUpper Then TBL_DR.O_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_BIN_1.ToUpper Then TBL_DR.O_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_AIRPORT1_1.ToUpper Then TBL_DR.O_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_AIRPORT2_1.ToUpper Then TBL_DR.O_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_LOCAL1_1.ToUpper Then TBL_DR.O_LOCAL1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_LOCAL2_1.ToUpper Then TBL_DR.O_LOCAL2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_EXPRESS1_1.ToUpper Then TBL_DR.O_EXPRESS1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_EXPRESS2_1.ToUpper Then TBL_DR.O_EXPRESS2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_TIME1_1.ToUpper Then TBL_DR.O_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_TIME2_1.ToUpper Then TBL_DR.O_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_SEAT_1.ToUpper Then TBL_DR.O_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_SEATCLASS_1.ToUpper Then TBL_DR.O_SEATCLASS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_KOTSU_KUBUN_2.ToUpper Then TBL_DR.O_KOTSU_KUBUN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_DATE_2.ToUpper Then TBL_DR.O_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_BIN_2.ToUpper Then TBL_DR.O_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_AIRPORT1_2.ToUpper Then TBL_DR.O_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_AIRPORT2_2.ToUpper Then TBL_DR.O_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_LOCAL1_2.ToUpper Then TBL_DR.O_LOCAL1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_LOCAL2_2.ToUpper Then TBL_DR.O_LOCAL2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_EXPRESS1_2.ToUpper Then TBL_DR.O_EXPRESS1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_EXPRESS2_2.ToUpper Then TBL_DR.O_EXPRESS2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_TIME1_2.ToUpper Then TBL_DR.O_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_TIME2_2.ToUpper Then TBL_DR.O_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_SEAT_2.ToUpper Then TBL_DR.O_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_SEATCLASS_2.ToUpper Then TBL_DR.O_SEATCLASS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_KOTSU_KUBUN_3.ToUpper Then TBL_DR.O_KOTSU_KUBUN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_DATE_3.ToUpper Then TBL_DR.O_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_BIN_3.ToUpper Then TBL_DR.O_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_AIRPORT1_3.ToUpper Then TBL_DR.O_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_AIRPORT2_3.ToUpper Then TBL_DR.O_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_LOCAL1_3.ToUpper Then TBL_DR.O_LOCAL1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_LOCAL2_3.ToUpper Then TBL_DR.O_LOCAL2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_EXPRESS1_3.ToUpper Then TBL_DR.O_EXPRESS1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_EXPRESS2_3.ToUpper Then TBL_DR.O_EXPRESS2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_TIME1_3.ToUpper Then TBL_DR.O_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_TIME2_3.ToUpper Then TBL_DR.O_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_SEAT_3.ToUpper Then TBL_DR.O_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.O_SEATCLASS_3.ToUpper Then TBL_DR.O_SEATCLASS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_KOTSU_KUBUN_1.ToUpper Then TBL_DR.F_KOTSU_KUBUN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_DATE_1.ToUpper Then TBL_DR.F_DATE_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_BIN_1.ToUpper Then TBL_DR.F_BIN_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_AIRPORT1_1.ToUpper Then TBL_DR.F_AIRPORT1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_AIRPORT2_1.ToUpper Then TBL_DR.F_AIRPORT2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_LOCAL1_1.ToUpper Then TBL_DR.F_LOCAL1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_LOCAL2_1.ToUpper Then TBL_DR.F_LOCAL2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_EXPRESS1_1.ToUpper Then TBL_DR.F_EXPRESS1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_EXPRESS2_1.ToUpper Then TBL_DR.F_EXPRESS2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_TIME1_1.ToUpper Then TBL_DR.F_TIME1_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_TIME2_1.ToUpper Then TBL_DR.F_TIME2_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_SEAT_1.ToUpper Then TBL_DR.F_SEAT_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_SEATCLASS_1.ToUpper Then TBL_DR.F_SEATCLASS_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_KOTSU_KUBUN_2.ToUpper Then TBL_DR.F_KOTSU_KUBUN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_DATE_2.ToUpper Then TBL_DR.F_DATE_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_BIN_2.ToUpper Then TBL_DR.F_BIN_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_AIRPORT1_2.ToUpper Then TBL_DR.F_AIRPORT1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_AIRPORT2_2.ToUpper Then TBL_DR.F_AIRPORT2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_LOCAL1_2.ToUpper Then TBL_DR.F_LOCAL1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_LOCAL2_2.ToUpper Then TBL_DR.F_LOCAL2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_EXPRESS1_2.ToUpper Then TBL_DR.F_EXPRESS1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_EXPRESS2_2.ToUpper Then TBL_DR.F_EXPRESS2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_TIME1_2.ToUpper Then TBL_DR.F_TIME1_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_TIME2_2.ToUpper Then TBL_DR.F_TIME2_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_SEAT_2.ToUpper Then TBL_DR.F_SEAT_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_SEATCLASS_2.ToUpper Then TBL_DR.F_SEATCLASS_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_KOTSU_KUBUN_3.ToUpper Then TBL_DR.F_KOTSU_KUBUN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_DATE_3.ToUpper Then TBL_DR.F_DATE_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_BIN_3.ToUpper Then TBL_DR.F_BIN_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_AIRPORT1_3.ToUpper Then TBL_DR.F_AIRPORT1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_AIRPORT2_3.ToUpper Then TBL_DR.F_AIRPORT2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_LOCAL1_3.ToUpper Then TBL_DR.F_LOCAL1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_LOCAL2_3.ToUpper Then TBL_DR.F_LOCAL2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_EXPRESS1_3.ToUpper Then TBL_DR.F_EXPRESS1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_EXPRESS2_3.ToUpper Then TBL_DR.F_EXPRESS2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_TIME1_3.ToUpper Then TBL_DR.F_TIME1_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_TIME2_3.ToUpper Then TBL_DR.F_TIME2_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_SEAT_3.ToUpper Then TBL_DR.F_SEAT_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.F_SEATCLASS_3.ToUpper Then TBL_DR.F_SEATCLASS_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.AIRLINE.ToUpper Then TBL_DR.AIRLINE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MILAGE_NO.ToUpper Then TBL_DR.MILAGE_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NOTE_KOTSU.ToUpper Then TBL_DR.NOTE_KOTSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TEHAIMAIL_KOTSU.ToUpper Then TBL_DR.TEHAIMAIL_KOTSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NOTES.ToUpper Then TBL_DR.NOTES = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SEND_SAKI.ToUpper Then TBL_DR.SEND_SAKI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SEND_ZIP.ToUpper Then TBL_DR.SEND_ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SEND_ADDRESS.ToUpper Then TBL_DR.SEND_ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SEND_TEL.ToUpper Then TBL_DR.SEND_TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SEND_NAME.ToUpper Then TBL_DR.SEND_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ATTEND_FLAG.ToUpper Then TBL_DR.ATTEND_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MAIL_FLAG.ToUpper Then TBL_DR.MAIL_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ARRIVE_TIME.ToUpper Then TBL_DR.ARRIVE_TIME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TOTAL_AMOUNT.ToUpper Then TBL_DR.TOTAL_AMOUNT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_NAME_1.ToUpper Then TBL_DR.SAGAKU_NAME_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_1.ToUpper Then TBL_DR.SAGAKU_1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_NAME_2.ToUpper Then TBL_DR.SAGAKU_NAME_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_2.ToUpper Then TBL_DR.SAGAKU_2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_NAME_3.ToUpper Then TBL_DR.SAGAKU_NAME_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_3.ToUpper Then TBL_DR.SAGAKU_3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_NAME_4.ToUpper Then TBL_DR.SAGAKU_NAME_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_4.ToUpper Then TBL_DR.SAGAKU_4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_NAME_5.ToUpper Then TBL_DR.SAGAKU_NAME_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SAGAKU_5.ToUpper Then TBL_DR.SAGAKU_5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.REPLY.ToUpper Then TBL_DR.REPLY = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.REPLY_HOTEL.ToUpper Then TBL_DR.REPLY_HOTEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.REPLY_KOTSU.ToUpper Then TBL_DR.REPLY_KOTSU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PAYMENT_METHOD.ToUpper Then TBL_DR.PAYMENT_METHOD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.BILL_NO.ToUpper Then TBL_DR.BILL_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.BILL_NAME.ToUpper Then TBL_DR.BILL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PAYMENT_DATE_BANK.ToUpper Then TBL_DR.PAYMENT_DATE_BANK = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.AUTHORIZATION_NO.ToUpper Then TBL_DR.AUTHORIZATION_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TRANSACTION_NO.ToUpper Then TBL_DR.TRANSACTION_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PAYMENT_DATE_CARD.ToUpper Then TBL_DR.PAYMENT_DATE_CARD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PUBLIC_SERVANT.ToUpper Then TBL_DR.PUBLIC_SERVANT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SECANDARY_USE.ToUpper Then TBL_DR.SECANDARY_USE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_ACCOMPANY.ToUpper Then TBL_DR.HOTELPRINT_ACCOMPANY = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HOTELPRINT_BREAKFAST.ToUpper Then TBL_DR.HOTELPRINT_BREAKFAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCESS_ID.ToUpper Then TBL_DR.ACCESS_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ACCESS_PW.ToUpper Then TBL_DR.ACCESS_PW = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TICKET_FLAG.ToUpper Then TBL_DR.TICKET_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TICKET_SEND_DATE1.ToUpper Then TBL_DR.TICKET_SEND_DATE1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TICKET_SEND_DATE2.ToUpper Then TBL_DR.TICKET_SEND_DATE2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.YOBI1.ToUpper Then TBL_DR.YOBI1 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.YOBI2.ToUpper Then TBL_DR.YOBI2 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.YOBI3.ToUpper Then TBL_DR.YOBI3 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.YOBI4.ToUpper Then TBL_DR.YOBI4 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.YOBI5.ToUpper Then TBL_DR.YOBI5 = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NEW_RECORD_KUBUN.ToUpper Then TBL_DR.NEW_RECORD_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NEW_STATUS_TEHAI.ToUpper Then TBL_DR.NEW_STATUS_TEHAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.NEW_STATUS_PAYMENT.ToUpper Then TBL_DR.NEW_STATUS_PAYMENT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_NAME.ToUpper Then TBL_DR.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DR_NAME_KANA.ToUpper Then TBL_DR.DR_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_NAME_FIRST.ToUpper Then TBL_DR.MEMBER_NAME_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_NAME_LAST.ToUpper Then TBL_DR.MEMBER_NAME_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_NAME_KANA_FIRST.ToUpper Then TBL_DR.MEMBER_NAME_KANA_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_NAME_KANA_LAST.ToUpper Then TBL_DR.MEMBER_NAME_KANA_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_NAME.ToUpper Then TBL_DR.MEMBER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.MEMBER_NAME_KANA.ToUpper Then TBL_DR.MEMBER_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.HIS_KUBUN.ToUpper Then TBL_DR.HIS_KUBUN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.DATANO.ToUpper Then TBL_DR.DATANO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.UPDDATE.ToUpper Then TBL_DR.UPDDATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.LOGIN_FLAG.ToUpper Then TBL_DR.LOGIN_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.OFFICE.ToUpper Then TBL_DR.OFFICE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ZIP.ToUpper Then TBL_DR.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.ADDRESS.ToUpper Then TBL_DR.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.TEL.ToUpper Then TBL_DR.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.FAX.ToUpper Then TBL_DR.FAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.KEITAI.ToUpper Then TBL_DR.KEITAI = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.PC_MAIL.ToUpper Then TBL_DR.PC_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.KEITAI_MAIL.ToUpper Then TBL_DR.KEITAI_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_DR.Column.SORT_NO.ToUpper Then TBL_DR.SORT_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_DR
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_PACKAGE_HOTEL As TableDef.MS_PACKAGE_HOTEL.DataStruct) As TableDef.MS_PACKAGE_HOTEL.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.HOTEL_NO.ToUpper Then MS_PACKAGE_HOTEL.HOTEL_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.HOTEL_NAME.ToUpper Then MS_PACKAGE_HOTEL.HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.CHECKIN_DATE.ToUpper Then MS_PACKAGE_HOTEL.CHECKIN_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.ROOM_RATE.ToUpper Then MS_PACKAGE_HOTEL.ROOM_RATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.ACCOMPANY_ROOM_RATE_TWIN.ToUpper Then MS_PACKAGE_HOTEL.ACCOMPANY_ROOM_RATE_TWIN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.ACCOMPANY_ROOM_RATE_TRIPLE.ToUpper Then MS_PACKAGE_HOTEL.ACCOMPANY_ROOM_RATE_TRIPLE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_HOTEL.Column.ACCOMPANY_ROOM_RATE_OTHER.ToUpper Then MS_PACKAGE_HOTEL.ACCOMPANY_ROOM_RATE_OTHER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_PACKAGE_HOTEL
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_PACKAGE_KOTSU As TableDef.MS_PACKAGE_KOTSU.DataStruct) As TableDef.MS_PACKAGE_KOTSU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_KOTSU.Column.KOTSU_NO.ToUpper Then MS_PACKAGE_KOTSU.KOTSU_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_KOTSU.Column.PREFECTURES_NO.ToUpper Then MS_PACKAGE_KOTSU.PREFECTURES_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_KOTSU.Column.AIR_FLAG.ToUpper Then MS_PACKAGE_KOTSU.AIR_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_KOTSU.Column.AIR_FARE.ToUpper Then MS_PACKAGE_KOTSU.AIR_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_KOTSU.Column.JR_FLAG.ToUpper Then MS_PACKAGE_KOTSU.JR_FLAG = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PACKAGE_KOTSU.Column.JR_FARE.ToUpper Then MS_PACKAGE_KOTSU.JR_FARE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_PACKAGE_KOTSU
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_HOTEL As TableDef.MS_HOTEL.DataStruct) As TableDef.MS_HOTEL.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTEL.Column.DATA_ID.ToUpper Then MS_HOTEL.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTEL.Column.HOTEL_NAME.ToUpper Then MS_HOTEL.HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTEL.Column.ADDRESS.ToUpper Then MS_HOTEL.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTEL.Column.TEL.ToUpper Then MS_HOTEL.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTEL.Column.FAX.ToUpper Then MS_HOTEL.FAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTEL.Column.URL.ToUpper Then MS_HOTEL.URL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_HOTEL
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_HOTELPRINT_ACCOMPANY As TableDef.MS_HOTELPRINT_ACCOMPANY.DataStruct) As TableDef.MS_HOTELPRINT_ACCOMPANY.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_ACCOMPANY.Column.DATA_ID.ToUpper Then MS_HOTELPRINT_ACCOMPANY.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_ACCOMPANY.Column.DISP_TEXT.ToUpper Then MS_HOTELPRINT_ACCOMPANY.DISP_TEXT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_ACCOMPANY.Column.DISP_VALUE.ToUpper Then MS_HOTELPRINT_ACCOMPANY.DISP_VALUE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_ACCOMPANY.Column.DETAIL.ToUpper Then MS_HOTELPRINT_ACCOMPANY.DETAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_HOTELPRINT_ACCOMPANY
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_HOTELPRINT_BREAKFAST As TableDef.MS_HOTELPRINT_BREAKFAST.DataStruct) As TableDef.MS_HOTELPRINT_BREAKFAST.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_BREAKFAST.Column.DATA_ID.ToUpper Then MS_HOTELPRINT_BREAKFAST.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_BREAKFAST.Column.DISP_TEXT.ToUpper Then MS_HOTELPRINT_BREAKFAST.DISP_TEXT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_BREAKFAST.Column.DISP_VALUE.ToUpper Then MS_HOTELPRINT_BREAKFAST.DISP_VALUE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_BREAKFAST.Column.DETAIL.ToUpper Then MS_HOTELPRINT_BREAKFAST.DETAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_HOTELPRINT_BREAKFAST
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_HOTELPRINT_CHECKIN As TableDef.MS_HOTELPRINT_CHECKIN.DataStruct) As TableDef.MS_HOTELPRINT_CHECKIN.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_CHECKIN.Column.DATA_ID.ToUpper Then MS_HOTELPRINT_CHECKIN.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_CHECKIN.Column.DISP_TEXT.ToUpper Then MS_HOTELPRINT_CHECKIN.DISP_TEXT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_CHECKIN.Column.DISP_VALUE.ToUpper Then MS_HOTELPRINT_CHECKIN.DISP_VALUE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_CHECKIN.Column.DETAIL.ToUpper Then MS_HOTELPRINT_CHECKIN.DETAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_HOTELPRINT_CHECKIN
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_HOTELPRINT_RENRAKU As TableDef.MS_HOTELPRINT_RENRAKU.DataStruct) As TableDef.MS_HOTELPRINT_RENRAKU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_RENRAKU.Column.DATA_ID.ToUpper Then MS_HOTELPRINT_RENRAKU.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_RENRAKU.Column.DISP_TEXT.ToUpper Then MS_HOTELPRINT_RENRAKU.DISP_TEXT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_RENRAKU.Column.DISP_VALUE.ToUpper Then MS_HOTELPRINT_RENRAKU.DISP_VALUE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_RENRAKU.Column.DETAIL.ToUpper Then MS_HOTELPRINT_RENRAKU.DETAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_HOTELPRINT_RENRAKU
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_HOTELPRINT_SHIHARAI As TableDef.MS_HOTELPRINT_SHIHARAI.DataStruct) As TableDef.MS_HOTELPRINT_SHIHARAI.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_SHIHARAI.Column.DATA_ID.ToUpper Then MS_HOTELPRINT_SHIHARAI.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_SHIHARAI.Column.DISP_TEXT.ToUpper Then MS_HOTELPRINT_SHIHARAI.DISP_TEXT = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_SHIHARAI.Column.DISP_VALUE.ToUpper Then MS_HOTELPRINT_SHIHARAI.DISP_VALUE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_HOTELPRINT_SHIHARAI.Column.DETAIL.ToUpper Then MS_HOTELPRINT_SHIHARAI.DETAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_HOTELPRINT_SHIHARAI
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_ROOM_TYPE As TableDef.MS_ROOM_TYPE.DataStruct) As TableDef.MS_ROOM_TYPE.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ROOM_TYPE.Column.DATA_ID.ToUpper Then MS_ROOM_TYPE.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ROOM_TYPE.Column.HOTEL_NAME.ToUpper Then MS_ROOM_TYPE.HOTEL_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_ROOM_TYPE.Column.ROOM_TYPE.ToUpper Then MS_ROOM_TYPE.ROOM_TYPE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_ROOM_TYPE
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_MANAGE As TableDef.MS_MANAGE.DataStruct) As TableDef.MS_MANAGE.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.MANAGE_ID.ToUpper Then MS_MANAGE.MANAGE_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.MANAGE_PW.ToUpper Then MS_MANAGE.MANAGE_PW = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.SHITEN_CD.ToUpper Then MS_MANAGE.SHITEN_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.SHITEN_NAME.ToUpper Then MS_MANAGE.SHITEN_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.EIGYOSHO_CD.ToUpper Then MS_MANAGE.EIGYOSHO_CD = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.EIGYOSHO_NAME.ToUpper Then MS_MANAGE.EIGYOSHO_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_MANAGE.Column.KENGEN.ToUpper Then MS_MANAGE.KENGEN = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_MANAGE
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_PREFECTURES As TableDef.MS_PREFECTURES.DataStruct) As TableDef.MS_PREFECTURES.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PREFECTURES.Column.PREFECTURES_NO.ToUpper Then MS_PREFECTURES.PREFECTURES_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_PREFECTURES.Column.PREFECTURES_NO.ToUpper Then MS_PREFECTURES.PREFECTURES_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_PREFECTURES
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_DR As TableDef.MS_DR.DataStruct) As TableDef.MS_DR.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_ID.ToUpper Then MS_DR.DR_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_PW.ToUpper Then MS_DR.DR_PW = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.UPD_DATE.ToUpper Then MS_DR.UPD_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.UPD_USER.ToUpper Then MS_DR.UPD_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.UPD_PGM.ToUpper Then MS_DR.UPD_PGM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.INS_DATE.ToUpper Then MS_DR.INS_DATE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.INS_USER.ToUpper Then MS_DR.INS_USER = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.INS_PGM.ToUpper Then MS_DR.INS_PGM = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_ID.ToUpper Then MS_DR.MEMBER_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_NAME.ToUpper Then MS_DR.MEMBER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_NAME_FIRST.ToUpper Then MS_DR.DR_NAME_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_NAME_LAST.ToUpper Then MS_DR.DR_NAME_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_NAME_KANA_FIRST.ToUpper Then MS_DR.DR_NAME_KANA_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_NAME_KANA_LAST.ToUpper Then MS_DR.DR_NAME_KANA_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DATA_ID.ToUpper Then MS_DR.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.SHISETSU_NAME.ToUpper Then MS_DR.SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.SHISETSU_NAME_KANA.ToUpper Then MS_DR.SHISETSU_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_MAIL.ToUpper Then MS_DR.DR_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.PC_MAIL.ToUpper Then MS_DR.PC_MAIL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.OFFICE.ToUpper Then MS_DR.OFFICE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.ZIP.ToUpper Then MS_DR.ZIP = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.ADDRESS.ToUpper Then MS_DR.ADDRESS = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.TEL.ToUpper Then MS_DR.TEL = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.FAX.ToUpper Then MS_DR.FAX = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_NAME.ToUpper Then MS_DR.DR_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.DR_NAME_KANA.ToUpper Then MS_DR.DR_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_NAME_FIRST.ToUpper Then MS_DR.MEMBER_NAME_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_NAME_LAST.ToUpper Then MS_DR.MEMBER_NAME_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_NAME_KANA_FIRST.ToUpper Then MS_DR.MEMBER_NAME_KANA_FIRST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_NAME_KANA_LAST.ToUpper Then MS_DR.MEMBER_NAME_KANA_LAST = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.MEMBER_NAME_KANA.ToUpper Then MS_DR.MEMBER_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_DR.Column.SORT_NO.ToUpper Then MS_DR.SORT_NO = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_DR
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As TableDef.MS_SHISETSU.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.DATA_ID.ToUpper Then MS_SHISETSU.DATA_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.MEMBER_ID.ToUpper Then MS_SHISETSU.MEMBER_ID = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.SHISETSU_NAME.ToUpper Then MS_SHISETSU.SHISETSU_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.SHISETSU_NAME_KANA.ToUpper Then MS_SHISETSU.SHISETSU_NAME_KANA = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.MEMBER_NAME.ToUpper Then MS_SHISETSU.MEMBER_NAME = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.MS_SHISETSU.Column.OFFICE.ToUpper Then MS_SHISETSU.OFFICE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return MS_SHISETSU
    End Function

    Public Shared Function SetRsData(ByVal RsData As System.Data.SqlClient.SqlDataReader, ByVal TBL_ZAIKO As TableDef.TBL_ZAIKO.DataStruct) As TableDef.TBL_ZAIKO.DataStruct
        Dim wCnt As Integer = 0

        For wCnt = 0 To RsData.FieldCount - 1
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_ZAIKO.Column.WETLAB_COURSE.ToUpper Then TBL_ZAIKO.WETLAB_COURSE = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_ZAIKO.Column.ZAIKO_SU.ToUpper Then TBL_ZAIKO.ZAIKO_SU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
            If RsData.GetName(wCnt).ToUpper = TableDef.TBL_ZAIKO.Column.TOROKU_SU.ToUpper Then TBL_ZAIKO.TOROKU_SU = CmnDb.DbData(RsData.GetName(wCnt), RsData)
        Next wCnt

        Return TBL_ZAIKO
    End Function


    'データ取得
    Public Shared Function GetOneRecord(ByVal TableType As TableType, ByVal SQL As String, ByVal DbConn As System.Data.SqlClient.SqlConnection) As Object
        Dim CmnDb As New CmnDb
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Select Case TableType
            Case AppModule.TableType.MS_CODE
                Dim MS_CODE As TableDef.MS_CODE.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_CODE = SetRsData(RsData, MS_CODE)
                End If
                RsData.Close()
                Return MS_CODE
            Case AppModule.TableType.MS_OFFICE
                Dim MS_OFFICE As TableDef.MS_OFFICE.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_OFFICE = SetRsData(RsData, MS_OFFICE)
                End If
                RsData.Close()
                Return MS_OFFICE
            Case AppModule.TableType.MS_PREFECTURES
                Dim MS_PREFECTURES As TableDef.MS_PREFECTURES.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_PREFECTURES = SetRsData(RsData, MS_PREFECTURES)
                End If
                RsData.Close()
                Return MS_PREFECTURES
            Case AppModule.TableType.MS_MEMBER
                Dim MS_MEMBER As TableDef.MS_MEMBER.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_MEMBER = SetRsData(RsData, MS_MEMBER)
                End If
                RsData.Close()
                Return MS_MEMBER
            Case AppModule.TableType.TBL_DR
                Dim TBL_DR As TableDef.TBL_DR.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    TBL_DR = SetRsData(RsData, TBL_DR)
                End If
                RsData.Close()
                Return TBL_DR
            Case AppModule.TableType.MS_PACKAGE_HOTEL
                Dim MS_PACKAGE_HOTEL As TableDef.MS_PACKAGE_HOTEL.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_PACKAGE_HOTEL = SetRsData(RsData, MS_PACKAGE_HOTEL)
                End If
                RsData.Close()
                Return MS_PACKAGE_HOTEL
            Case AppModule.TableType.MS_PACKAGE_KOTSU
                Dim MS_PACKAGE_KOTSU As TableDef.MS_PACKAGE_KOTSU.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_PACKAGE_KOTSU = SetRsData(RsData, MS_PACKAGE_KOTSU)
                End If
                RsData.Close()
                Return MS_PACKAGE_KOTSU
            Case AppModule.TableType.MS_HOTEL
                Dim MS_HOTEL As TableDef.MS_HOTEL.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_HOTEL = SetRsData(RsData, MS_HOTEL)
                End If
                RsData.Close()
                Return MS_HOTEL
            Case AppModule.TableType.MS_HOTELPRINT_ACCOMPANY
                Dim MS_HOTELPRINT_ACCOMPANY As TableDef.MS_HOTELPRINT_ACCOMPANY.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_HOTELPRINT_ACCOMPANY = SetRsData(RsData, MS_HOTELPRINT_ACCOMPANY)
                End If
                RsData.Close()
                Return MS_HOTELPRINT_ACCOMPANY
            Case AppModule.TableType.MS_HOTELPRINT_BREAKFAST
                Dim MS_HOTELPRINT_BREAKFAST As TableDef.MS_HOTELPRINT_BREAKFAST.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_HOTELPRINT_BREAKFAST = SetRsData(RsData, MS_HOTELPRINT_BREAKFAST)
                End If
                RsData.Close()
                Return MS_HOTELPRINT_BREAKFAST
            Case AppModule.TableType.MS_HOTELPRINT_CHECKIN
                Dim MS_HOTELPRINT_CHECKIN As TableDef.MS_HOTELPRINT_CHECKIN.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_HOTELPRINT_CHECKIN = SetRsData(RsData, MS_HOTELPRINT_CHECKIN)
                End If
                RsData.Close()
                Return MS_HOTELPRINT_CHECKIN
            Case AppModule.TableType.MS_HOTELPRINT_RENRAKU
                Dim MS_HOTELPRINT_RENRAKU As TableDef.MS_HOTELPRINT_RENRAKU.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_HOTELPRINT_RENRAKU = SetRsData(RsData, MS_HOTELPRINT_RENRAKU)
                End If
                RsData.Close()
                Return MS_HOTELPRINT_RENRAKU
            Case AppModule.TableType.MS_HOTELPRINT_SHIHARAI
                Dim MS_HOTELPRINT_SHIHARAI As TableDef.MS_HOTELPRINT_SHIHARAI.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_HOTELPRINT_SHIHARAI = SetRsData(RsData, MS_HOTELPRINT_SHIHARAI)
                End If
                RsData.Close()
                Return MS_HOTELPRINT_SHIHARAI
            Case AppModule.TableType.MS_ROOM_TYPE
                Dim MS_ROOM_TYPE As TableDef.MS_ROOM_TYPE.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_ROOM_TYPE = SetRsData(RsData, MS_ROOM_TYPE)
                End If
                RsData.Close()
                Return MS_ROOM_TYPE
            Case AppModule.TableType.MS_MANAGE
                Dim MS_MANAGE As TableDef.MS_MANAGE.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_MANAGE = SetRsData(RsData, MS_MANAGE)
                End If
                RsData.Close()
                Return MS_MANAGE
            Case AppModule.TableType.MS_SHISETSU
                Dim MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_SHISETSU = SetRsData(RsData, MS_SHISETSU)
                End If
                RsData.Close()
                Return MS_SHISETSU
            Case AppModule.TableType.MS_DR
                Dim MS_dr As TableDef.MS_DR.DataStruct = Nothing
                RsData = CmnDb.Read(SQL, DbConn)
                If RsData.Read() Then
                    MS_dr = SetRsData(RsData, MS_dr)
                End If
                RsData.Close()
                Return MS_dr
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

    '支払状況
    Public Shared Function GetColor_STATUS_PAYMENT(ByVal STATUS_PAYMENT As String) As Color
        Dim ColorInput As Color = Color.FromArgb(51, 67, 183)
        Dim ColorWait As Color = Color.FromArgb(176, 14, 75)
        Dim ColorOK As Color = Color.FromArgb(21, 71, 40)
        Dim ColorOkTo As Color = Color.FromArgb(112, 34, 41)
        Dim ColorEndTo As Color = Color.FromArgb(191, 21, 37)

        Select Case STATUS_PAYMENT
            Case AppConst.STATUS_PAYMENT.Code.Input, AppConst.STATUS_PAYMENT.Name.Input
                Return ColorInput
            Case AppConst.STATUS_PAYMENT.Code.OK, AppConst.STATUS_PAYMENT.Name.OK, _
                 AppConst.STATUS_PAYMENT.Code.BillPrint, AppConst.STATUS_PAYMENT.Name.BillPrint
                Return ColorWait
            Case AppConst.STATUS_PAYMENT.Code.Fuyo, AppConst.STATUS_PAYMENT.Name.Fuyo, _
                 AppConst.STATUS_PAYMENT.Code.BillEnd, AppConst.STATUS_PAYMENT.Name.BillEnd, _
                 AppConst.STATUS_PAYMENT.Code.CardEnd, AppConst.STATUS_PAYMENT.Name.CardEnd
                Return ColorOK
            Case AppConst.STATUS_PAYMENT.Code.OKToFuyo, AppConst.STATUS_PAYMENT.Name.OKToFuyo, _
                 AppConst.STATUS_PAYMENT.Code.OkToChange, AppConst.STATUS_PAYMENT.Name.OkToChange, _
                 AppConst.STATUS_PAYMENT.Code.OKToCancel, AppConst.STATUS_PAYMENT.Name.OKToCancel
                Return ColorOkTo
            Case AppConst.STATUS_PAYMENT.Code.EndToFuyo, AppConst.STATUS_PAYMENT.Name.EndToFuyo, _
                 AppConst.STATUS_PAYMENT.Code.EndToChange, AppConst.STATUS_PAYMENT.Name.EndToChange, _
                 AppConst.STATUS_PAYMENT.Code.EndToCancel, AppConst.STATUS_PAYMENT.Name.EndToCancel
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

    'CSV履歴区分
    Public Shared Function GetName_HIS_KUBUN(ByVal HIS_KUBUN As String, ByVal RECORD_KUBUN As String) As String
        If HIS_KUBUN = "1" Then
            Return "OLD"
        Else
            Select Case RECORD_KUBUN
                Case AppConst.RECORD_KUBUN.Code.Cancel, AppConst.RECORD_KUBUN.Name.Cancel
                    Return "CXL"
                Case Else
                    Return ""
            End Select
        End If
    End Function

    'ログインID
    Public Shared Function GetName_MEMBER_ID(ByVal MEMBER_ID As String) As String
        Return MEMBER_ID
    End Function
    Public Shared Function GetName_DR_ID(ByVal DR_ID As String) As String
        Return DR_ID
    End Function

    'パスワード
    Public Shared Function GetName_MEMBER_PW(ByVal MEMBER_PW As String) As String
        Return MEMBER_PW
    End Function
    Public Shared Function GetName_DR_PW(ByVal DR_PW As String) As String
        Return DR_PW
    End Function

    '社員コード
    Public Shared Function GetName_LOGIN_FLAG(ByVal LOGIN_FLAG As String) As String
        Select Case LOGIN_FLAG
            Case AppConst.LOGIN_FLAG.Code.Yes, AppConst.LOGIN_FLAG.Name.Yes
                Return AppConst.LOGIN_FLAG.Name.Yes
            Case AppConst.LOGIN_FLAG.Code.No, AppConst.LOGIN_FLAG.Name.No
                Return AppConst.LOGIN_FLAG.Name.No
            Case Else
                Return ""
        End Select
    End Function

    '所属
    Public Shared Function GetName_OFFICE(ByVal OFFICE As String) As String
        Return OFFICE
    End Function

    '登録番号
    Public Shared Function GetName_DATA_NO(ByVal DATA_NO As String) As String
        Return DATA_NO
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

    '支払状況
    Public Shared Function GetName_STATUS_PAYMENT(ByVal STATUS_PAYMENT As String) As String
        Select Case STATUS_PAYMENT
            Case AppConst.STATUS_PAYMENT.Code.Fuyo, AppConst.STATUS_PAYMENT.Name.Fuyo
                Return AppConst.STATUS_PAYMENT.Name.Fuyo
            Case AppConst.STATUS_PAYMENT.Code.Input, AppConst.STATUS_PAYMENT.Name.Input
                Return AppConst.STATUS_PAYMENT.Name.Input
            Case AppConst.STATUS_PAYMENT.Code.OK, AppConst.STATUS_PAYMENT.Name.OK
                Return AppConst.STATUS_PAYMENT.Name.OK
            Case AppConst.STATUS_PAYMENT.Code.BillPrint, AppConst.STATUS_PAYMENT.Name.BillPrint
                Return AppConst.STATUS_PAYMENT.Name.BillPrint
            Case AppConst.STATUS_PAYMENT.Code.CardEnd, AppConst.STATUS_PAYMENT.Name.CardEnd
                Return AppConst.STATUS_PAYMENT.Name.CardEnd
            Case AppConst.STATUS_PAYMENT.Code.BillEnd, AppConst.STATUS_PAYMENT.Name.BillEnd
                Return AppConst.STATUS_PAYMENT.Name.BillEnd
            Case AppConst.STATUS_PAYMENT.Code.OKToFuyo, AppConst.STATUS_PAYMENT.Name.OKToFuyo
                Return AppConst.STATUS_PAYMENT.Name.OKToFuyo
            Case AppConst.STATUS_PAYMENT.Code.OkToChange, AppConst.STATUS_PAYMENT.Name.OkToChange
                Return AppConst.STATUS_PAYMENT.Name.OkToChange
            Case AppConst.STATUS_PAYMENT.Code.OKToCancel, AppConst.STATUS_PAYMENT.Name.OKToCancel
                Return AppConst.STATUS_PAYMENT.Name.OKToCancel
            Case AppConst.STATUS_PAYMENT.Code.EndToFuyo, AppConst.STATUS_PAYMENT.Name.EndToFuyo
                Return AppConst.STATUS_PAYMENT.Name.EndToFuyo
            Case AppConst.STATUS_PAYMENT.Code.EndToChange, AppConst.STATUS_PAYMENT.Name.EndToChange
                Return AppConst.STATUS_PAYMENT.Name.EndToChange
            Case AppConst.STATUS_PAYMENT.Code.EndToCancel, AppConst.STATUS_PAYMENT.Name.EndToCancel
                Return AppConst.STATUS_PAYMENT.Name.EndToCancel
            Case Else
                Return ""
        End Select
    End Function

    'ドクター氏名(漢字)
    Public Shared Function GetName_DR_NAME(ByVal DR_NAME As String) As String
        Return DR_NAME
    End Function
    Public Shared Function GetName_DR_NAME_FIRST(ByVal DR_NAME_FIRST As String) As String
        Return DR_NAME_FIRST
    End Function
    Public Shared Function GetName_DR_NAME_LAST(ByVal DR_NAME_LAST As String) As String
        Return DR_NAME_LAST
    End Function
    'ドクター氏名＋施設名称
    Public Shared Function GetName_DR_NAME(ByVal DR_NAME As String, ByVal SHISETSU_NAME As String) As String
        Return DR_NAME & "　" & SHISETSU_NAME
    End Function

    'ドクター氏名(カナ)
    Public Shared Function GetName_DR_NAME_KANA(ByVal DR_NAME_KANA As String) As String
        Return DR_NAME_KANA
    End Function
    Public Shared Function GetName_DR_NAME_KANA_FIRST(ByVal DR_NAME_KANA_FIRST As String) As String
        Return DR_NAME_KANA_FIRST
    End Function
    Public Shared Function GetName_DR_NAME_KANA_LAST(ByVal DR_NAME_KANA_LAST As String) As String
        Return DR_NAME_KANA_LAST
    End Function

    '営業担当者氏名(漢字)
    Public Shared Function GetName_MEMBER_NAME(ByVal MEMBER_NAME As String) As String
        Return MEMBER_NAME
    End Function
    Public Shared Function GetName_MEMBER_NAME_FIRST(ByVal MEMBER_NAME_FIRST As String) As String
        Return MEMBER_NAME_FIRST
    End Function
    Public Shared Function GetName_MEMBER_NAME_LAST(ByVal MEMBER_NAME_LAST As String) As String
        Return MEMBER_NAME_LAST
    End Function

    '営業担当者氏名(カナ)
    Public Shared Function GetName_MEMBER_NAME_KANA(ByVal MEMBER_NAME_KANA As String) As String
        Return MEMBER_NAME_KANA
    End Function
    Public Shared Function GetName_MEMBER_NAME_KANA_FIRST(ByVal MEMBER_NAME_KANA_FIRST As String) As String
        Return MEMBER_NAME_KANA_FIRST
    End Function
    Public Shared Function GetName_MEMBER_NAME_KANA_LAST(ByVal MEMBER_NAME_KANA_LAST As String) As String
        Return MEMBER_NAME_KANA_LAST
    End Function

    '都道府県
    Public Shared Function GetName_PREFECTURES_NO(ByVal PREFECTURES_NO As String) As String
        Select Case PREFECTURES_NO
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO01, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO01
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO01
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO02, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO02
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO02
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO03, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO03
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO03
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO04, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO04
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO04
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO05, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO05
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO05
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO06, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO06
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO06
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO07, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO07
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO07
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO08, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO08
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO08
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO09, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO09
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO09
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO10, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO10
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO10
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO11, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO11
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO11
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO12, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO12
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO12
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO13, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO13
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO13
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO14, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO14
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO14
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO15, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO15
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO15
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO16, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO16
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO16
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO17, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO17
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO17
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO18, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO18
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO18
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO19, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO19
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO19
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO20, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO20
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO20
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO21, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO21
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO21
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO22, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO22
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO22
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO23, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO23
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO23
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO24, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO24
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO24
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO25, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO25
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO25
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO26, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO26
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO26
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO27, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO27
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO27
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO28, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO28
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO28
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO29, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO29
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO29
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO30, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO30
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO30
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO31, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO31
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO31
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO32, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO32
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO32
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO33, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO33
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO33
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO34, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO34
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO34
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO35, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO35
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO35
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO36, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO36
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO36
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO37, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO37
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO37
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO38, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO38
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO38
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO39, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO39
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO39
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO40, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO40
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO40
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO41, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO41
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO41
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO42, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO42
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO42
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO43, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO43
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO43
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO44, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO44
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO44
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO45, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO45
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO45
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO46, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO46
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO46
            Case AppConst.PREFECTURES_NO.Code.PREFECTURES_NO47, AppConst.PREFECTURES_NO.Name.PREFECTURES_NO47
                Return AppConst.PREFECTURES_NO.Name.PREFECTURES_NO47
            Case Else
                Return PREFECTURES_NO
        End Select
    End Function

    '施設・病院名称
    Public Shared Function GetName_SHISETSU_NAME(ByVal SHISETSU_NAME As String) As String
        Return SHISETSU_NAME
    End Function
    Public Shared Function GetName_SHISETSU_NAME_KANA(ByVal SHISETSU_NAME_KANA As String) As String
        Return SHISETSU_NAME_KANA
    End Function

    '診療科
    Public Shared Function GetName_KAMOKU(ByVal KAMOKU As String) As String
        Return KAMOKU
    End Function

    '役職
    Public Shared Function GetName_YAKUSHOKU(ByVal YAKUSHOKU As String) As String
        Return YAKUSHOKU
    End Function

    '参加区分
    Public Shared Function GetName_SANKA_KUBUN(ByVal SANKA_KUBUN As String) As String
        Select Case SANKA_KUBUN
            Case AppConst.SANKA_KUBUN.Code.Listener, AppConst.SANKA_KUBUN.Name.Listener
                Return AppConst.SANKA_KUBUN.Name.Listener
            Case AppConst.SANKA_KUBUN.Code.Speaker, AppConst.SANKA_KUBUN.Name.Speaker
                Return AppConst.SANKA_KUBUN.Name.Speaker
            Case Else
                Return ""
        End Select
    End Function

    '情報交換会
    Public Shared Function GetName_PARTY(ByVal PARTY As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case PARTY
                Case AppConst.PARTY.Code.Yes, AppConst.PARTY.Name.Yes, AppConst.PARTY.Name.ShortFormat.Yes
                    Return AppConst.PARTY.Name.Yes
                Case AppConst.PARTY.Code.No, AppConst.PARTY.Name.No, AppConst.PARTY.Name.ShortFormat.No
                    Return AppConst.PARTY.Name.No
                Case Else
                    Return ""
            End Select
        Else
            Select Case PARTY
                Case AppConst.PARTY.Code.Yes, AppConst.PARTY.Name.Yes, AppConst.PARTY.Name.ShortFormat.Yes
                    Return AppConst.PARTY.Name.ShortFormat.Yes
                Case AppConst.PARTY.Code.No, AppConst.PARTY.Name.No, AppConst.PARTY.Name.ShortFormat.No
                    Return AppConst.PARTY.Name.ShortFormat.No
                Case Else
                    Return ""
            End Select
        End If
    End Function

    '公務員
    Public Shared Function GetName_PUBLIC_SERVANT(ByVal PUBLIC_SERVANT As String) As String
        Select Case PUBLIC_SERVANT
            Case AppConst.PUBLIC_SERVANT.Code.Yes, AppConst.PUBLIC_SERVANT.Name.Yes
                Return AppConst.PUBLIC_SERVANT.Name.Yes
            Case AppConst.PUBLIC_SERVANT.Code.No, AppConst.PUBLIC_SERVANT.Name.No
                Return AppConst.PUBLIC_SERVANT.Name.No
            Case Else
                Return ""
        End Select
    End Function

    '画像及び発言の二次使用
    Public Shared Function GetName_SECANDARY_USE(ByVal SECANDARY_USE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case SECANDARY_USE
                Case AppConst.SECANDARY_USE.Code.Yes, AppConst.SECANDARY_USE.Name.Yes, AppConst.SECANDARY_USE.Name.ShortFormat.Yes
                    Return AppConst.SECANDARY_USE.Name.Yes
                Case AppConst.SECANDARY_USE.Code.No, AppConst.SECANDARY_USE.Name.No, AppConst.SECANDARY_USE.Name.ShortFormat.No
                    Return AppConst.SECANDARY_USE.Name.No
                Case Else
                    Return ""
            End Select
        Else
            Select Case SECANDARY_USE
                Case AppConst.SECANDARY_USE.Code.Yes, AppConst.SECANDARY_USE.Name.Yes, AppConst.SECANDARY_USE.Name.ShortFormat.Yes
                    Return AppConst.SECANDARY_USE.Name.ShortFormat.Yes
                Case AppConst.SECANDARY_USE.Code.No, AppConst.SECANDARY_USE.Name.No, AppConst.SECANDARY_USE.Name.ShortFormat.No
                    Return AppConst.SECANDARY_USE.Name.ShortFormat.No
                Case Else
                    Return ""
            End Select
        End If
    End Function

    'ウェットラボ
    Public Shared Function GetName_WETLAB_FLAG(ByVal WETLAB_FLAG As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case WETLAB_FLAG
                Case AppConst.WETLAB_FLAG.Code.Yes, AppConst.WETLAB_FLAG.Name.Yes, AppConst.WETLAB_FLAG.Name.ShortFormat.Yes
                    Return AppConst.WETLAB_FLAG.Name.Yes
                Case AppConst.WETLAB_FLAG.Code.No, AppConst.WETLAB_FLAG.Name.No, AppConst.WETLAB_FLAG.Name.ShortFormat.No
                    Return AppConst.WETLAB_FLAG.Name.No
                Case Else
                    Return ""
            End Select
        Else
            Select Case WETLAB_FLAG
                Case AppConst.WETLAB_FLAG.Code.Yes, AppConst.WETLAB_FLAG.Name.Yes, AppConst.WETLAB_FLAG.Name.ShortFormat.Yes
                    Return AppConst.WETLAB_FLAG.Name.ShortFormat.Yes
                Case AppConst.WETLAB_FLAG.Code.No, AppConst.WETLAB_FLAG.Name.No, AppConst.WETLAB_FLAG.Name.ShortFormat.No
                    Return AppConst.WETLAB_FLAG.Name.ShortFormat.No
                Case Else
                    Return ""
            End Select
        End If
    End Function

    'ウェットラボ コース
    Public Shared Function GetName_WETLAB_COURSE(ByVal WETLAB_COURSE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case WETLAB_COURSE
                Case AppConst.WETLAB_COURSE.Code.A, AppConst.WETLAB_COURSE.Name.A, AppConst.WETLAB_COURSE.Name.ShortFormat.A
                    Return AppConst.WETLAB_COURSE.Name.A
                Case AppConst.WETLAB_COURSE.Code.B, AppConst.WETLAB_COURSE.Name.B, AppConst.WETLAB_COURSE.Name.ShortFormat.B
                    Return AppConst.WETLAB_COURSE.Name.B
                Case Else
                    Return ""
            End Select
        Else
            Select Case WETLAB_COURSE
                Case AppConst.WETLAB_COURSE.Code.A, AppConst.WETLAB_COURSE.Name.A, AppConst.WETLAB_COURSE.Name.ShortFormat.A
                    Return AppConst.WETLAB_COURSE.Name.ShortFormat.A
                Case AppConst.WETLAB_COURSE.Code.B, AppConst.WETLAB_COURSE.Name.B, AppConst.WETLAB_COURSE.Name.ShortFormat.B
                    Return AppConst.WETLAB_COURSE.Name.ShortFormat.B
                Case Else
                    Return ""
            End Select
        End If
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

    '宿泊日
    Public Shared Function GetName_STAY_DATE(ByVal STAY_DATE As String) As String
        Select Case STAY_DATE
            Case AppConst.STAY_DATE.Code.Before, AppConst.STAY_DATE.Name.Before
                Return AppConst.STAY_DATE.Name.Before
            Case AppConst.STAY_DATE.Code.Tojitsu, AppConst.STAY_DATE.Name.Tojitsu
                Return AppConst.STAY_DATE.Name.Tojitsu
            Case AppConst.STAY_DATE.Code.After, AppConst.STAY_DATE.Name.After
                Return AppConst.STAY_DATE.Name.After
            Case Else
                Return ""
        End Select
    End Function

    '入金日
    Public Shared Function GetName_PAYMENT_DATE_BANK(ByVal PAYMENT_DATE_BANK As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(PAYMENT_DATE_BANK, ShortFormat)
    End Function

    'カード決済日
    Public Shared Function GetName_PAYMENT_DATE_CARD(ByVal PAYMENT_DATE_CARD As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(PAYMENT_DATE_CARD, ShortFormat)
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
            Case AppConst.HOTEL_SMOKING.Code.No, AppConst.HOTEL_SMOKING.Name.No
                Return AppConst.HOTEL_SMOKING.Name.No
            Case AppConst.HOTEL_SMOKING.Code.Yes, AppConst.HOTEL_SMOKING.Name.Yes
                Return AppConst.HOTEL_SMOKING.Name.Yes
            Case Else
                Return ""
        End Select
    End Function

    '宿泊備考欄
    Public Shared Function GetName_NOTE_HOTEL(ByVal NOTE_HOTEL As String) As String
        Return NOTE_HOTEL
    End Function

    '来場
    Public Shared Function GetName_ATTEND(ByVal ATTEND As String) As String
        Select Case ATTEND
            Case AppConst.ATTEND.Code.Yes, AppConst.ATTEND.Name.Yes
                Return AppConst.ATTEND.Name.Yes
            Case AppConst.ATTEND.Code.No, AppConst.ATTEND.Name.No
                Return AppConst.ATTEND.Name.No
            Case AppConst.ATTEND.Code.Mi, AppConst.ATTEND.Name.Mi
                Return AppConst.ATTEND.Name.Mi
            Case Else
                Return ""
        End Select
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

    '航空便/JR
    Public Shared Function GetName_O_KOTSU_KUBUN_1(ByVal O_KOTSU_KUBUN_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case O_KOTSU_KUBUN_1
                Case AppConst.KOTSU_KUBUN.Code.AIR, AppConst.KOTSU_KUBUN.Name.AIR, AppConst.KOTSU_KUBUN.Name.ShortFormat.AIR
                    Return AppConst.KOTSU_KUBUN.Name.AIR
                Case AppConst.KOTSU_KUBUN.Code.JR, AppConst.KOTSU_KUBUN.Name.JR, AppConst.KOTSU_KUBUN.Name.ShortFormat.JR
                    Return AppConst.KOTSU_KUBUN.Name.JR
                Case Else
                    Return AppConst.KOTSU_KUBUN.Name.None
            End Select
        Else
            Select Case O_KOTSU_KUBUN_1
                Case AppConst.KOTSU_KUBUN.Code.AIR, AppConst.KOTSU_KUBUN.Name.AIR, AppConst.KOTSU_KUBUN.Name.ShortFormat.AIR
                    Return AppConst.KOTSU_KUBUN.Name.ShortFormat.AIR
                Case AppConst.KOTSU_KUBUN.Code.JR, AppConst.KOTSU_KUBUN.Name.JR, AppConst.KOTSU_KUBUN.Name.ShortFormat.JR
                    Return AppConst.KOTSU_KUBUN.Name.ShortFormat.JR
                Case Else
                    Return AppConst.KOTSU_KUBUN.Name.ShortFormat.None
            End Select
        End If
    End Function
    Public Shared Function GetName_O_KOTSU_KUBUN_2(ByVal O_KOTSU_KUBUN_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_KOTSU_KUBUN_3(ByVal O_KOTSU_KUBUN_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_KOTSU_KUBUN_1(ByVal F_KOTSU_KUBUN_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_KOTSU_KUBUN_2(ByVal F_KOTSU_KUBUN_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_KOTSU_KUBUN_3(ByVal F_KOTSU_KUBUN_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_3, ShortFormat)
    End Function

    '乗車・搭乗日
    Public Shared Function GetName_O_DATE_1(ByVal O_DATE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(O_DATE_1, ShortFormat)
    End Function
    Public Shared Function GetName_O_DATE_2(ByVal O_DATE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_DATE_1(O_DATE_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_DATE_3(ByVal O_DATE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_DATE_1(O_DATE_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_DATE_1(ByVal F_DATE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_DATE_1(F_DATE_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_DATE_2(ByVal F_DATE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_DATE_1(F_DATE_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_DATE_3(ByVal F_DATE_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_DATE_1(F_DATE_3, ShortFormat)
    End Function

    '区間
    Public Shared Function GetName_O_AIRPORT_1(ByVal O_AIRPORT1_1 As String, ByVal O_AIRPORT2_1 As String) As String
        Dim wStr As String = ""

        If Trim(O_AIRPORT1_1) <> "" AndAlso Trim(O_AIRPORT2_1) <> "" Then
            wStr = Trim(O_AIRPORT1_1) & "発～" & Trim(O_AIRPORT2_1) & "着"
        ElseIf Trim(O_AIRPORT1_1) <> "" AndAlso Trim(O_AIRPORT2_1) = "" Then
            wStr = Trim(O_AIRPORT1_1) & "発"
        ElseIf Trim(O_AIRPORT1_1) = "" AndAlso Trim(O_AIRPORT2_1) <> "" Then
            wStr = Trim(O_AIRPORT2_1) & "着"
        End If
        Return wStr
    End Function
    Public Shared Function GetName_O_AIRPORT_2(ByVal O_AIRPORT1_2 As String, ByVal O_AIRPORT2_2 As String) As String
        Return GetName_O_AIRPORT_1(O_AIRPORT1_2, O_AIRPORT2_2)
    End Function
    Public Shared Function GetName_O_AIRPORT_3(ByVal O_AIRPORT1_3 As String, ByVal O_AIRPORT2_3 As String) As String
        Return GetName_O_AIRPORT_1(O_AIRPORT1_3, O_AIRPORT2_3)
    End Function
    Public Shared Function GetName_F_AIRPORT_1(ByVal F_AIRPORT1_1 As String, ByVal F_AIRPORT2_1 As String) As String
        Return GetName_O_AIRPORT_1(F_AIRPORT1_1, F_AIRPORT2_1)
    End Function
    Public Shared Function GetName_F_AIRPORT_2(ByVal F_AIRPORT1_2 As String, ByVal F_AIRPORT2_2 As String) As String
        Return GetName_O_AIRPORT_1(F_AIRPORT1_2, F_AIRPORT2_2)
    End Function
    Public Shared Function GetName_F_AIRPORT_3(ByVal F_AIRPORT1_3 As String, ByVal F_AIRPORT2_3 As String) As String
        Return GetName_O_AIRPORT_1(F_AIRPORT1_3, F_AIRPORT2_3)
    End Function

    Public Shared Function GetName_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If O_AIRPORT1_1.Trim <> String.Empty Then
            If ShortFormat = False Then
                Return O_AIRPORT1_1 & "発"
            Else
                Return O_AIRPORT1_1
            End If
        Else
            Return O_AIRPORT1_1
        End If
    End Function
    Public Shared Function GetName_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT1_1(O_AIRPORT1_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT1_1(O_AIRPORT1_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT1_1(F_AIRPORT1_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT1_1(F_AIRPORT1_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT1_1(F_AIRPORT1_3, ShortFormat)
    End Function

    Public Shared Function GetName_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If O_AIRPORT2_1.Trim <> String.Empty Then
            If ShortFormat = False Then
                Return O_AIRPORT2_1 & "着"
            Else
                Return O_AIRPORT2_1
            End If
        Else
            Return O_AIRPORT2_1
        End If
    End Function
    Public Shared Function GetName_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT2_1(O_AIRPORT2_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT2_1(O_AIRPORT2_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT2_1(F_AIRPORT2_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT2_1(F_AIRPORT2_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_AIRPORT2_1(F_AIRPORT2_3, ShortFormat)
    End Function

    '新幹線・特急区間
    Public Shared Function GetName_O_EXPRESS_1(ByVal O_EXPRESS1_1 As String, ByVal O_EXPRESS2_1 As String) As String
        Dim wStr As String = ""

        If Trim(O_EXPRESS1_1) <> "" AndAlso Trim(O_EXPRESS2_1) <> "" Then
            wStr = Trim(O_EXPRESS1_1) & "発～" & Trim(O_EXPRESS2_1) & "着"
        ElseIf Trim(O_EXPRESS1_1) <> "" AndAlso Trim(O_EXPRESS2_1) = "" Then
            wStr = Trim(O_EXPRESS1_1) & "発"
        ElseIf Trim(O_EXPRESS1_1) = "" AndAlso Trim(O_EXPRESS2_1) <> "" Then
            wStr = Trim(O_EXPRESS2_1) & "着"
        End If
        Return wStr
    End Function
    Public Shared Function GetName_O_EXPRESS_2(ByVal O_EXPRESS1_2 As String, ByVal O_EXPRESS2_2 As String) As String
        Return GetName_O_EXPRESS_1(O_EXPRESS1_2, O_EXPRESS2_2)
    End Function
    Public Shared Function GetName_O_EXPRESS_3(ByVal O_EXPRESS1_3 As String, ByVal O_EXPRESS2_3 As String) As String
        Return GetName_O_EXPRESS_1(O_EXPRESS1_3, O_EXPRESS2_3)
    End Function
    Public Shared Function GetName_F_EXPRESS_1(ByVal F_EXPRESS1_1 As String, ByVal F_EXPRESS2_1 As String) As String
        Return GetName_O_EXPRESS_1(F_EXPRESS1_1, F_EXPRESS2_1)
    End Function
    Public Shared Function GetName_F_EXPRESS_2(ByVal F_EXPRESS1_2 As String, ByVal F_EXPRESS2_2 As String) As String
        Return GetName_O_EXPRESS_1(F_EXPRESS1_2, F_EXPRESS2_2)
    End Function
    Public Shared Function GetName_F_EXPRESS_3(ByVal F_EXPRESS1_3 As String, ByVal F_EXPRESS2_3 As String) As String
        Return GetName_O_EXPRESS_1(F_EXPRESS1_3, F_EXPRESS2_3)
    End Function

    Public Shared Function GetName_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If O_EXPRESS1_1.Trim <> String.Empty Then
            If ShortFormat = False Then
                Return O_EXPRESS1_1 & "発"
            Else
                Return O_EXPRESS1_1
            End If
        Else
            Return O_EXPRESS1_1
        End If
    End Function
    Public Shared Function GetName_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS1_1(O_EXPRESS1_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS1_1(O_EXPRESS1_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS1_1(F_EXPRESS1_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS1_1(F_EXPRESS1_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS1_1(F_EXPRESS1_3, ShortFormat)
    End Function

    Public Shared Function GetName_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If O_EXPRESS2_1.Trim <> String.Empty Then
            If ShortFormat = False Then
                Return O_EXPRESS2_1 & "着"
            Else
                Return O_EXPRESS2_1
            End If
        Else
            Return O_EXPRESS2_1
        End If
    End Function
    Public Shared Function GetName_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS2_1(O_EXPRESS2_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS2_1(O_EXPRESS2_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS2_1(F_EXPRESS2_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS2_1(F_EXPRESS2_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_EXPRESS2_1(F_EXPRESS2_3, ShortFormat)
    End Function

    '乗車券区間
    Public Shared Function GetName_O_LOCAL_1(ByVal O_LOCAL1_1 As String, ByVal O_LOCAL2_1 As String) As String
        Dim wStr As String = ""

        If Trim(O_LOCAL1_1) <> "" AndAlso Trim(O_LOCAL2_1) <> "" Then
            wStr = Trim(O_LOCAL1_1) & "発～" & Trim(O_LOCAL2_1) & "着"
        ElseIf Trim(O_LOCAL1_1) <> "" AndAlso Trim(O_LOCAL2_1) = "" Then
            wStr = Trim(O_LOCAL1_1) & "発"
        ElseIf Trim(O_LOCAL1_1) = "" AndAlso Trim(O_LOCAL2_1) <> "" Then
            wStr = Trim(O_LOCAL2_1) & "着"
        End If
        Return wStr
    End Function
    Public Shared Function GetName_O_LOCAL_2(ByVal O_LOCAL1_2 As String, ByVal O_LOCAL2_2 As String) As String
        Return GetName_O_LOCAL_1(O_LOCAL1_2, O_LOCAL2_2)
    End Function
    Public Shared Function GetName_O_LOCAL_3(ByVal O_LOCAL1_3 As String, ByVal O_LOCAL2_3 As String) As String
        Return GetName_O_LOCAL_1(O_LOCAL1_3, O_LOCAL2_3)
    End Function
    Public Shared Function GetName_F_LOCAL_1(ByVal F_LOCAL1_1 As String, ByVal F_LOCAL2_1 As String) As String
        Return GetName_O_LOCAL_1(F_LOCAL1_1, F_LOCAL2_1)
    End Function
    Public Shared Function GetName_F_LOCAL_2(ByVal F_LOCAL1_2 As String, ByVal F_LOCAL2_2 As String) As String
        Return GetName_O_LOCAL_1(F_LOCAL1_2, F_LOCAL2_2)
    End Function
    Public Shared Function GetName_F_LOCAL_3(ByVal F_LOCAL1_3 As String, ByVal F_LOCAL2_3 As String) As String
        Return GetName_O_LOCAL_1(F_LOCAL1_3, F_LOCAL2_3)
    End Function

    Public Shared Function GetName_O_LOCAL1_1(ByVal O_LOCAL1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If O_LOCAL1_1.Trim <> String.Empty Then
            If ShortFormat = False Then
                Return O_LOCAL1_1 & "発"
            Else
                Return O_LOCAL1_1
            End If
        Else
            Return O_LOCAL1_1
        End If
    End Function
    Public Shared Function GetName_O_LOCAL1_2(ByVal O_LOCAL1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL1_1(O_LOCAL1_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_LOCAL1_3(ByVal O_LOCAL1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL1_1(O_LOCAL1_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_LOCAL1_1(ByVal F_LOCAL1_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL1_1(F_LOCAL1_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_LOCAL1_2(ByVal F_LOCAL1_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL1_1(F_LOCAL1_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_LOCAL1_3(ByVal F_LOCAL1_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL1_1(F_LOCAL1_3, ShortFormat)
    End Function

    Public Shared Function GetName_O_LOCAL2_1(ByVal O_LOCAL2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If O_LOCAL2_1.Trim <> String.Empty Then
            If ShortFormat = False Then
                Return O_LOCAL2_1 & "着"
            Else
                Return O_LOCAL2_1
            End If
        Else
            Return O_LOCAL2_1
        End If
    End Function
    Public Shared Function GetName_O_LOCAL2_2(ByVal O_LOCAL2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL2_1(O_LOCAL2_2, ShortFormat)
    End Function
    Public Shared Function GetName_O_LOCAL2_3(ByVal O_LOCAL2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL2_1(O_LOCAL2_3, ShortFormat)
    End Function
    Public Shared Function GetName_F_LOCAL2_1(ByVal F_LOCAL2_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL2_1(F_LOCAL2_1, ShortFormat)
    End Function
    Public Shared Function GetName_F_LOCAL2_2(ByVal F_LOCAL2_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL2_1(F_LOCAL2_2, ShortFormat)
    End Function
    Public Shared Function GetName_F_LOCAL2_3(ByVal F_LOCAL2_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_O_LOCAL2_1(F_LOCAL2_3, ShortFormat)
    End Function

    '時間
    Public Shared Function GetName_O_TIME_1(ByVal O_TIME1_1 As String, ByVal O_TIME2_1 As String) As String
        Dim wStr As String = ""

        If Trim(O_TIME1_1) <> "" AndAlso Trim(O_TIME2_1) <> "" Then
            wStr = Trim(O_TIME1_1) & "～" & Trim(O_TIME2_1)
        ElseIf Trim(O_TIME1_1) <> "" AndAlso Trim(O_TIME2_1) = "" Then
            wStr = Trim(O_TIME1_1) & "～"
        ElseIf Trim(O_TIME1_1) = "" AndAlso Trim(O_TIME2_1) <> "" Then
            wStr = "～" & Trim(O_TIME2_1)
        End If

        Return wStr
    End Function
    Public Shared Function GetName_O_TIME_2(ByVal O_TIME1_2 As String, ByVal O_TIME2_2 As String) As String
        Return GetName_O_TIME_1(O_TIME1_2, O_TIME2_2)
    End Function
    Public Shared Function GetName_O_TIME_3(ByVal O_TIME1_3 As String, ByVal O_TIME2_3 As String) As String
        Return GetName_O_TIME_1(O_TIME1_3, O_TIME2_3)
    End Function
    Public Shared Function GetName_F_TIME_1(ByVal F_TIME1_1 As String, ByVal F_TIME2_1 As String) As String
        Return GetName_O_TIME_1(F_TIME1_1, F_TIME2_1)
    End Function
    Public Shared Function GetName_F_TIME_2(ByVal F_TIME1_2 As String, ByVal F_TIME2_2 As String) As String
        Return GetName_O_TIME_1(F_TIME1_2, F_TIME2_2)
    End Function
    Public Shared Function GetName_F_TIME_3(ByVal F_TIME1_3 As String, ByVal F_TIME2_3 As String) As String
        Return GetName_O_TIME_1(F_TIME1_3, F_TIME2_3)
    End Function
    Public Shared Function GetName_O_TIME1_1(ByVal O_TIME1_1 As String) As String
        Return O_TIME1_1
    End Function
    Public Shared Function GetName_O_TIME2_1(ByVal O_TIME2_1 As String) As String
        Return GetName_O_TIME1_1(O_TIME2_1)
    End Function
    Public Shared Function GetName_O_TIME1_2(ByVal O_TIME1_2 As String) As String
        Return GetName_O_TIME1_1(O_TIME1_2)
    End Function
    Public Shared Function GetName_O_TIME2_2(ByVal O_TIME2_2 As String) As String
        Return GetName_O_TIME1_1(O_TIME2_2)
    End Function
    Public Shared Function GetName_O_TIME1_3(ByVal O_TIME1_3 As String) As String
        Return GetName_O_TIME1_1(O_TIME1_3)
    End Function
    Public Shared Function GetName_O_TIME2_3(ByVal O_TIME2_3 As String) As String
        Return GetName_O_TIME1_1(O_TIME2_3)
    End Function
    Public Shared Function GetName_F_TIME1_1(ByVal F_TIME1_1 As String) As String
        Return GetName_O_TIME1_1(F_TIME1_1)
    End Function
    Public Shared Function GetName_F_TIME2_1(ByVal F_TIME2_1 As String) As String
        Return GetName_O_TIME1_1(F_TIME2_1)
    End Function
    Public Shared Function GetName_F_TIME1_2(ByVal F_TIME1_2 As String) As String
        Return GetName_O_TIME1_1(F_TIME1_2)
    End Function
    Public Shared Function GetName_F_TIME2_2(ByVal F_TIME2_2 As String) As String
        Return GetName_O_TIME1_1(F_TIME2_2)
    End Function
    Public Shared Function GetName_F_TIME1_3(ByVal F_TIME1_3 As String) As String
        Return GetName_O_TIME1_1(F_TIME1_3)
    End Function
    Public Shared Function GetName_F_TIME2_3(ByVal F_TIME2_3 As String) As String
        Return GetName_O_TIME1_1(F_TIME2_3)
    End Function

    '便名
    Public Shared Function GetName_O_BIN_1(ByVal O_BIN_1 As String) As String
        Return O_BIN_1
    End Function
    Public Shared Function GetName_O_BIN_2(ByVal O_BIN_2 As String) As String
        Return GetName_O_BIN_1(O_BIN_2)
    End Function
    Public Shared Function GetName_O_BIN_3(ByVal O_BIN_3 As String) As String
        Return GetName_O_BIN_1(O_BIN_3)
    End Function
    Public Shared Function GetName_F_BIN_1(ByVal F_BIN_1 As String) As String
        Return GetName_O_BIN_1(F_BIN_1)
    End Function
    Public Shared Function GetName_F_BIN_2(ByVal F_BIN_2 As String) As String
        Return GetName_O_BIN_1(F_BIN_2)
    End Function
    Public Shared Function GetName_F_BIN_3(ByVal F_BIN_3 As String) As String
        Return GetName_O_BIN_1(F_BIN_3)
    End Function

    '座席希望
    Public Shared Function GetName_O_SEAT_1(ByVal O_SEAT_1 As String) As String
        Select Case O_SEAT_1
            Case AppConst.SEAT.Code.Window, AppConst.SEAT.Name.Window
                Return AppConst.SEAT.Name.Window
            Case AppConst.SEAT.Code.Aisle, AppConst.SEAT.Name.Aisle
                Return AppConst.SEAT.Name.Aisle
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_O_SEAT_2(ByVal O_SEAT_2 As String) As String
        Return GetName_O_SEAT_1(O_SEAT_2)
    End Function
    Public Shared Function GetName_O_SEAT_3(ByVal O_SEAT_3 As String) As String
        Return GetName_O_SEAT_1(O_SEAT_3)
    End Function
    Public Shared Function GetName_F_SEAT_1(ByVal F_SEAT_1 As String) As String
        Return GetName_O_SEAT_1(F_SEAT_1)
    End Function
    Public Shared Function GetName_F_SEAT_2(ByVal F_SEAT_2 As String) As String
        Return GetName_O_SEAT_1(F_SEAT_2)
    End Function
    Public Shared Function GetName_F_SEAT_3(ByVal F_SEAT_3 As String) As String
        Return GetName_O_SEAT_1(F_SEAT_3)
    End Function

    '座席区分
    Public Shared Function GetName_O_SEATCLASS_1(ByVal O_SEATCLASS_1 As String) As String
        Select Case O_SEATCLASS_1
            Case AppConst.SEATCLASS.Code.Regular, AppConst.SEATCLASS.Name.Regular
                Return AppConst.SEATCLASS.Name.Regular
            Case AppConst.SEATCLASS.Code.Premium, AppConst.SEATCLASS.Name.Premium
                Return AppConst.SEATCLASS.Name.Premium
            Case AppConst.SEATCLASS.Code.Unreserved, AppConst.SEATCLASS.Name.Unreserved
                Return AppConst.SEATCLASS.Name.Unreserved
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_O_SEATCLASS_2(ByVal O_SEATCLASS_2 As String) As String
        Return GetName_O_SEATCLASS_1(O_SEATCLASS_2)
    End Function
    Public Shared Function GetName_O_SEATCLASS_3(ByVal O_SEATCLASS_3 As String) As String
        Return GetName_O_SEATCLASS_1(O_SEATCLASS_3)
    End Function
    Public Shared Function GetName_F_SEATCLASS_1(ByVal F_SEATCLASS_1 As String) As String
        Return GetName_O_SEATCLASS_1(F_SEATCLASS_1)
    End Function
    Public Shared Function GetName_F_SEATCLASS_2(ByVal F_SEATCLASS_2 As String) As String
        Return GetName_O_SEATCLASS_1(F_SEATCLASS_2)
    End Function
    Public Shared Function GetName_F_SEATCLASS_3(ByVal F_SEATCLASS_3 As String) As String
        Return GetName_O_SEATCLASS_1(F_SEATCLASS_3)
    End Function

    '航空会社
    Public Shared Function GetName_AIRLINE(ByVal AIRLINE As String) As String
        Select Case AIRLINE
            Case AppConst.AIRLINE.Code.ANA, AppConst.AIRLINE.Name.ANA
                Return AppConst.AIRLINE.Name.ANA
            Case AppConst.AIRLINE.Code.JAL, AppConst.AIRLINE.Name.JAL
                Return AppConst.AIRLINE.Name.JAL
            Case Else
                Return ""
        End Select
    End Function

    'マイレージナンバー
    Public Shared Function GetName_MILAGE_NO(ByVal MILAGE_NO As String) As String
        Return MILAGE_NO
    End Function

    '交通備考欄
    Public Shared Function GetName_NOTE_KOTSU(ByVal NOTE_KOTSU As String) As String
        Return GetName_NOTE_HOTEL(NOTE_KOTSU)
    End Function

    'チケット送付先
    Public Shared Function GetName_SEND_SAKI(ByVal SEND_SAKI As String) As String
        Select Case SEND_SAKI
            Case AppConst.SEND_SAKI.Code.DrOffice, AppConst.SEND_SAKI.Name.DrOffice
                Return AppConst.SEND_SAKI.Name.DrOffice
            Case AppConst.SEND_SAKI.Code.DrHome, AppConst.SEND_SAKI.Name.DrHome
                Return AppConst.SEND_SAKI.Name.DrHome
            Case AppConst.SEND_SAKI.Code.MemberOffice, AppConst.SEND_SAKI.Name.MemberOffice
                Return AppConst.SEND_SAKI.Name.MemberOffice
            Case Else
                Return ""
        End Select
    End Function

    '送付先CD
    Public Shared Function GetName_SEND_CD(ByVal SEND_CD As String) As String
        Return SEND_CD
    End Function

    '送付先: 郵便番号
    Public Shared Function GetName_SEND_ZIP(ByVal SEND_ZIP As String) As String
        Return SEND_ZIP
    End Function

    '送付先: 住所
    Public Shared Function GetName_SEND_ADDRESS(ByVal SEND_ADDRESS As String) As String
        Return SEND_ADDRESS
    End Function

    '送付先: 宛先名
    Public Shared Function GetName_SEND_NAME(ByVal SEND_NAME As String) As String
        Return SEND_NAME
    End Function
    Public Shared Function GetName_SEND_NAME(ByVal OFFICE As String, ByVal SEND_NAME As String) As String
        Return OFFICE & "　" & SEND_NAME
    End Function

    '送付先: 電話番号
    Public Shared Function GetName_SEND_TEL(ByVal SEND_TEL As String) As String
        Return SEND_TEL
    End Function

    '備考欄
    Public Shared Function GetName_NOTES(ByVal NOTES As String) As String
        Return NOTES
    End Function

    '同伴者
    Public Shared Function GetName_ACCOMPANY_FLAG(ByVal ACCOMPANY_FLAG As String) As String
        Select Case ACCOMPANY_FLAG
            Case AppConst.ACCOMPANY_FLAG.Code.Yes, AppConst.ACCOMPANY_FLAG.Name.Yes
                Return AppConst.ACCOMPANY_FLAG.Name.Yes
            Case AppConst.ACCOMPANY_FLAG.Code.No, AppConst.ACCOMPANY_FLAG.Name.No
                Return AppConst.ACCOMPANY_FLAG.Name.No
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_ACCOMPANY_STAY(ByVal ACCOMPANY_STAY As String) As String
        Select Case ACCOMPANY_STAY
            Case AppConst.ACCOMPANY_STAY.Code.Yes, AppConst.ACCOMPANY_STAY.Name.Yes
                Return AppConst.ACCOMPANY_STAY.Name.Yes
            Case AppConst.ACCOMPANY_STAY.Code.No, AppConst.ACCOMPANY_STAY.Name.No
                Return AppConst.ACCOMPANY_STAY.Name.No
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_ACCOMPANY_SAME_ROOM(ByVal ACCOMPANY_SAME_ROOM As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = False Then
            Select Case ACCOMPANY_SAME_ROOM
                Case AppConst.ACCOMPANY_SAME_ROOM.Code.Yes, AppConst.ACCOMPANY_SAME_ROOM.Name.Yes, AppConst.ACCOMPANY_SAME_ROOM.Name.ShortFormat.Yes
                    Return AppConst.ACCOMPANY_SAME_ROOM.Name.Yes
                Case AppConst.ACCOMPANY_SAME_ROOM.Code.No, AppConst.ACCOMPANY_SAME_ROOM.Name.No, AppConst.ACCOMPANY_SAME_ROOM.Name.ShortFormat.No
                    Return AppConst.ACCOMPANY_SAME_ROOM.Name.No
                Case Else
                    Return ""
            End Select
        Else
            Select Case ACCOMPANY_SAME_ROOM
                Case AppConst.ACCOMPANY_SAME_ROOM.Code.Yes, AppConst.ACCOMPANY_SAME_ROOM.Name.Yes, AppConst.ACCOMPANY_SAME_ROOM.Name.ShortFormat.Yes
                    Return AppConst.ACCOMPANY_SAME_ROOM.Name.ShortFormat.Yes
                Case AppConst.ACCOMPANY_SAME_ROOM.Code.No, AppConst.ACCOMPANY_SAME_ROOM.Name.No, AppConst.ACCOMPANY_SAME_ROOM.Name.ShortFormat.No
                    Return AppConst.ACCOMPANY_SAME_ROOM.Name.ShortFormat.No
                Case Else
                    Return ""
            End Select
        End If
    End Function
    Public Shared Function GetName_ACCOMPANY_CHECK_IN(ByVal ACCOMPANY_CHECK_IN As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(ACCOMPANY_CHECK_IN, ShortFormat)
    End Function
    Public Shared Function GetName_ACCOMPANY_CHECK_OUT(ByVal ACCOMPANY_CHECK_OUT As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_CHECK_IN(ACCOMPANY_CHECK_OUT, ShortFormat)
    End Function
    Public Shared Function GetName_ACCOMPANY_ADULT_SU(ByVal ACCOMPANY_ADULT_SU As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = True Then
            If Val(ACCOMPANY_ADULT_SU) = 0 Then
                Return ""
            Else
                Return Trim(ACCOMPANY_ADULT_SU)
            End If
        Else
            If Val(ACCOMPANY_ADULT_SU) = 0 Then
                Return "0人"
            Else
                Return Trim(ACCOMPANY_ADULT_SU) & "人"
            End If
        End If
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_SU(ByVal ACCOMPANY_CHILD_SU As String, Optional ByVal ShortFormat As Boolean = False) As String
        If ShortFormat = True Then
            If Val(ACCOMPANY_CHILD_SU) = 0 Then
                Return ""
            Else
                Return Trim(ACCOMPANY_CHILD_SU)
            End If
        Else
            If Val(ACCOMPANY_CHILD_SU) = 0 Then
                Return "0人"
            Else
                Return Trim(ACCOMPANY_CHILD_SU) & "人"
            End If
        End If
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_SEX_1(ByVal ACCOMPANY_CHILD_SEX_1 As String) As String
        Select Case ACCOMPANY_CHILD_SEX_1
            Case AppConst.SEX.Code.Male, AppConst.SEX.Name.Male
                Return AppConst.SEX.Name.Male
            Case AppConst.SEX.Code.Female, AppConst.SEX.Name.Female
                Return AppConst.SEX.Name.Female
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_SEX_2(ByVal ACCOMPANY_CHILD_SEX_2 As String) As String
        Return GetName_ACCOMPANY_CHILD_SEX_1(ACCOMPANY_CHILD_SEX_2)
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_AGE_1(ByVal ACCOMPANY_CHILD_AGE_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(ACCOMPANY_CHILD_AGE_1) = 0 Then
            Return ""
        Else
            If ShortFormat = False Then
                Return Trim(ACCOMPANY_CHILD_AGE_1) & "歳"
            Else
                Return Trim(ACCOMPANY_CHILD_AGE_1)
            End If
        End If
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_AGE_2(ByVal ACCOMPANY_CHILD_AGE_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ACCOMPANY_CHILD_AGE_1(ACCOMPANY_CHILD_AGE_2, ShortFormat)
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_BED_1(ByVal ACCOMPANY_CHILD_BED_1 As String) As String
        Select Case ACCOMPANY_CHILD_BED_1
            Case AppConst.ACCOMPANY_BED.Code.Yes, AppConst.ACCOMPANY_BED.Name.Yes
                Return AppConst.ACCOMPANY_BED.Name.Yes
            Case AppConst.ACCOMPANY_BED.Code.No, AppConst.ACCOMPANY_BED.Name.No
                Return AppConst.ACCOMPANY_BED.Name.No
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_ACCOMPANY_CHILD_BED_2(ByVal ACCOMPANY_CHILD_BED_2 As String) As String
        Return GetName_ACCOMPANY_CHILD_BED_1(ACCOMPANY_CHILD_BED_2)
    End Function
    Public Shared Function GetName_NOTE_ACCOMPANY(ByVal NOTE_ACCOMPANY As String) As String
        Return NOTE_ACCOMPANY
    End Function

    '支払方法
    Public Shared Function GetName_PAYMENT_METHOD(ByVal PAYMENT_METHOD As String, Optional ByVal ShortFormat As Boolean = False) As String
        Select Case PAYMENT_METHOD
            Case AppConst.PAYMENT_METHOD.Code.Card, AppConst.PAYMENT_METHOD.Name.Card, AppConst.PAYMENT_METHOD.Name.ShortFormat.Card
                If ShortFormat = False Then
                    Return AppConst.PAYMENT_METHOD.Name.Card
                Else
                    Return AppConst.PAYMENT_METHOD.Name.ShortFormat.Card
                End If
            Case AppConst.PAYMENT_METHOD.Code.Bank, AppConst.PAYMENT_METHOD.Name.Bank, AppConst.PAYMENT_METHOD.Name.ShortFormat.Bank
                If ShortFormat = False Then
                    Return AppConst.PAYMENT_METHOD.Name.Bank
                Else
                    Return AppConst.PAYMENT_METHOD.Name.ShortFormat.Bank
                End If
            Case Else
                Return ""
        End Select
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
    Public Shared Function GetName_ACCOMPANY_ROOM_RATE(ByVal ACCOMPANY_ROOM_RATE As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_ROOM_RATE(ACCOMPANY_ROOM_RATE, ShortFormat)
    End Function

    Public Shared Function GetName_O_KOTSU_FARE(ByVal O_KOTSU_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(O_KOTSU_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(O_KOTSU_FARE).ToString("#,#")
            Else
                Return O_KOTSU_FARE
            End If
        End If
    End Function
    Public Shared Function GetName_F_KOTSU_FARE(ByVal F_KOTSU_FARE As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(F_KOTSU_FARE) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(F_KOTSU_FARE).ToString("#,#")
            Else
                Return F_KOTSU_FARE
            End If
        End If
    End Function

    Public Shared Function GetName_TOTAL_AMOUNT(ByVal TOTAL_AMOUNT As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(TOTAL_AMOUNT) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(TOTAL_AMOUNT).ToString("#,#")
            Else
                Return TOTAL_AMOUNT
            End If
        End If
    End Function

    '電話番号
    Public Shared Function GetName_TEL(ByVal TEL As String) As String
        Return TEL
    End Function

    'FAX番号
    Public Shared Function GetName_FAX(ByVal FAX As String) As String
        Return FAX
    End Function

    '携帯電話番号
    Public Shared Function GetName_KEITAI(ByVal KEITAI As String) As String
        Return KEITAI
    End Function

    'PCメールアドレス
    Public Shared Function GetName_PC_MAIL(ByVal PC_MAIL As String) As String
        Return PC_MAIL
    End Function

    'メールアドレス
    Public Shared Function GetName_DR_MAIL(ByVal DR_MAIL As String) As String
        Return DR_MAIL
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

    '請求先名
    Public Shared Function GetName_BILL_NAME(ByVal BILL_NAME As String) As String
        Return BILL_NAME
    End Function

    '請求番号
    Public Shared Function GetName_BILL_NO(ByVal BILL_NO As String) As String
        Return BILL_NO
    End Function

    '登録者
    Public Shared Function GetName_INS_TYPE(ByVal INS_TYPE As String) As String
        Select Case INS_TYPE
            Case AppConst.INS_TYPE.Code.Member, AppConst.INS_TYPE.Name.Member
                Return AppConst.INS_TYPE.Name.Member
            Case AppConst.INS_TYPE.Code.Dr, AppConst.INS_TYPE.Name.Dr
                Return AppConst.INS_TYPE.Name.Dr
            Case AppConst.INS_TYPE.Code.Admin, AppConst.INS_TYPE.Name.Admin
                Return AppConst.INS_TYPE.Name.Admin
            Case Else
                Return ""
        End Select
    End Function

    '手配関連
    Public Shared Function GetName_TEHAIMAIL_HOTEL(ByVal TEHAIMAIL_HOTEL As String) As String
        Return TEHAIMAIL_HOTEL
    End Function
    Public Shared Function GetName_HOTELPRINT_SHIHARAI(ByVal HOTELPRINT_SHIHARAI As String, Optional ByVal Break As Boolean = False) As String
        If Break = False Then
            Return HOTELPRINT_SHIHARAI
        Else
            Dim wStr As String = ""
            wStr = Replace(HOTELPRINT_SHIHARAI, vbNewLine & vbNewLine, "<div class='FontSize1' style='height: 12px;'></div>")
            wStr = Replace(wStr, vbNewLine, CmnConst.Html.Break)
            Return wStr
        End If
    End Function
    Public Shared Function GetName_HOTELPRINT_CHECKIN(ByVal HOTELPRINT_CHECKIN As String, Optional ByVal Break As Boolean = False) As String
        Return GetName_HOTELPRINT_SHIHARAI(HOTELPRINT_CHECKIN, Break)
    End Function
    Public Shared Function GetName_HOTELPRINT_RENRAKU(ByVal HOTELPRINT_RENRAKU As String, Optional ByVal Break As Boolean = False) As String
        Return GetName_HOTELPRINT_SHIHARAI(HOTELPRINT_RENRAKU, Break)
    End Function
    Public Shared Function GetName_HOTELPRINT_ACCOMPANY(ByVal HOTELPRINT_ACCOMPANY As String, Optional ByVal Break As Boolean = False) As String
        Return GetName_HOTELPRINT_SHIHARAI(HOTELPRINT_ACCOMPANY, Break)
    End Function
    Public Shared Function GetName_HOTELPRINT_BREAKFAST(ByVal HOTELPRINT_BREAKFAST As String, Optional ByVal Break As Boolean = False) As String
        Return GetName_HOTELPRINT_SHIHARAI(HOTELPRINT_BREAKFAST, Break)
    End Function
    Public Shared Function GetName_HOTEL_NAME(ByVal HOTEL_NAME As String) As String
        Return HOTEL_NAME
    End Function
    Public Shared Function GetName_HOTEL_ADDRESS(ByVal HOTEL_ADDRESS As String) As String
        Return HOTEL_ADDRESS
    End Function
    Public Shared Function GetName_HOTEL_TEL(ByVal HOTEL_TEL As String) As String
        Return HOTEL_TEL
    End Function
    Public Shared Function GetName_HOTEL_FAX(ByVal HOTEL_FAX As String) As String
        Return HOTEL_FAX
    End Function
    Public Shared Function GetName_ROOM_TYPE(ByVal ROOM_TYPE As String, Optional ByVal ShortFomat As Boolean = False) As String
        If ShortFomat = False Then
            Return ROOM_TYPE
        Else
            Select Case ROOM_TYPE
                Case AppConst.ROOM_TYPE.Single, AppConst.ROOM_TYPE.ShortFormat.Single
                    Return AppConst.ROOM_TYPE.ShortFormat.Single
                Case AppConst.ROOM_TYPE.Twin, AppConst.ROOM_TYPE.ShortFormat.Twin
                    Return AppConst.ROOM_TYPE.ShortFormat.Twin
                Case AppConst.ROOM_TYPE.Triple, AppConst.ROOM_TYPE.ShortFormat.Triple
                    Return AppConst.ROOM_TYPE.ShortFormat.Triple
                Case Else
                    Return ROOM_TYPE
            End Select
        End If
    End Function
    Public Shared Function GetName_ROOM_SU(ByVal ROOM_SU As String) As String
        Return ROOM_SU
    End Function
    Public Shared Function GetName_TEHAIMAIL_KOTSU(ByVal TEHAIMAIL_KOTSU As String) As String
        Return TEHAIMAIL_KOTSU
    End Function
    Public Shared Function GetName_SAGAKU_NAME_1(ByVal SAGAKU_NAME_1 As String) As String
        Return SAGAKU_NAME_1
    End Function
    Public Shared Function GetName_SAGAKU_NAME_2(ByVal SAGAKU_NAME_2 As String) As String
        Return GetName_SAGAKU_NAME_1(SAGAKU_NAME_2)
    End Function
    Public Shared Function GetName_SAGAKU_NAME_3(ByVal SAGAKU_NAME_3 As String) As String
        Return GetName_SAGAKU_NAME_1(SAGAKU_NAME_3)
    End Function
    Public Shared Function GetName_SAGAKU_1(ByVal SAGAKU_1 As String, Optional ByVal ShortFormat As Boolean = False) As String
        If Val(SAGAKU_1) = 0 Then
            Return "0"
        Else
            If ShortFormat = False Then
                Return CLng(SAGAKU_1).ToString("#,#")
            Else
                Return CLng(SAGAKU_1).ToString
            End If
        End If
    End Function
    Public Shared Function GetName_SAGAKU_2(ByVal SAGAKU_2 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SAGAKU_1(SAGAKU_2, ShortFormat)
    End Function
    Public Shared Function GetName_SAGAKU_3(ByVal SAGAKU_3 As String, Optional ByVal ShortFormat As Boolean = False) As String
        Return GetName_SAGAKU_1(SAGAKU_3, ShortFormat)
    End Function

    Public Shared Function GetName_ZAIKO_SU(ByVal ZAIKO_SU As String) As String
        Return ZAIKO_SU
    End Function
    Public Shared Function GetName_TOROKU_SU(ByVal TOROKU_SU As String) As String
        Return TOROKU_SU
    End Function

    'GMOオーダーID
    Public Shared Function GetName_GMO_ORDER_ID(ByVal DATA_NO As String, ByVal PAYMENT_METHOD As String, ByVal EVENT_CODE As String) As String
        If PAYMENT_METHOD = AppConst.PAYMENT_METHOD.Code.Card Then
            Return EVENT_CODE & DATA_NO
        Else
            Return String.Empty
        End If
    End Function

    'チケット発送
    Public Shared Function GetName_TICKET_FLAG(ByVal TICKET_FLAG As String, Optional ByVal ShortFormat As Boolean = False) As String
        Select Case TICKET_FLAG
            Case CmnConst.Flag.On
                If ShortFormat = True Then
                    Return "済"
                Else
                    Return "チケット発送済み"
                End If
            Case Else
                Return ""
        End Select
    End Function
    Public Shared Function GetName_TICKET_SEND_DATE1(ByVal TICKET_SEND_DATE1 As String) As String
        If Trim(TICKET_SEND_DATE1) <> "" Then
            Return CmnModule.Format_Date("2013" & TICKET_SEND_DATE1, CmnModule.DateFormatType.MD)
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetName_TICKET_SEND_DATE2(ByVal TICKET_SEND_DATE2 As String) As String
        If Trim(TICKET_SEND_DATE2) <> "" Then
            Return CmnModule.Format_Date("2013" & TICKET_SEND_DATE2, CmnModule.DateFormatType.MD)
        Else
            Return ""
        End If
    End Function


    '== コントロールをセット ==
    '登録番号
    Public Shared Sub SetForm_DATA_NO(ByVal DATA_NO As String, ByRef control As TextBox)
        control.Text = DATA_NO
    End Sub
    Public Shared Sub SetForm_DATA_NO(ByVal DATA_NO As String, ByRef control As Label)
        control.Text = DATA_NO
    End Sub

    'ログインID
    Public Shared Sub SetForm_MEMBER_ID(ByVal MEMBER_ID As String, ByRef control As TextBox)
        control.Text = MEMBER_ID
    End Sub
    Public Shared Sub SetForm_DR_ID(ByVal DR_ID As String, ByRef control As TextBox)
        control.Text = DR_ID
    End Sub
    Public Shared Sub SetForm_MEMBER_ID(ByVal MEMBER_ID As String, ByRef control As HiddenField)
        control.Value = MEMBER_ID
    End Sub

    'パスワード
    Public Shared Sub SetForm_MEMBER_PW(ByVal MEMBER_PW As String, ByRef control As TextBox)
        control.Text = MEMBER_PW
    End Sub
    Public Shared Sub SetForm_DR_PW(ByVal DR_PW As String, ByRef control As TextBox)
        control.Text = DR_PW
    End Sub

    '施設データ番号
    Public Shared Sub SetForm_DATA_ID(ByVal DATA_ID As String, ByRef control As HiddenField)
        control.Value = DATA_ID
    End Sub

    '氏名(漢字)
    Public Shared Sub SetForm_DR_NAME_FIRST(ByVal DR_NAME_FIRST As String, ByRef control As TextBox)
        control.Text = DR_NAME_FIRST
    End Sub
    Public Shared Sub SetForm_DR_NAME_LAST(ByVal DR_NAME_LAST As String, ByRef control As TextBox)
        control.Text = DR_NAME_LAST
    End Sub

    Public Shared Sub SetForm_MEMBER_NAME_FIRST(ByVal MEMBER_NAME_FIRST As String, ByRef control As TextBox)
        control.Text = MEMBER_NAME_FIRST
    End Sub
    Public Shared Sub SetForm_MEMBER_NAME_LAST(ByVal MEMBER_NAME_LAST As String, ByRef control As TextBox)
        control.Text = MEMBER_NAME_LAST
    End Sub

    '氏名(カナ)
    Public Shared Sub SetForm_DR_NAME_KANA_FIRST(ByVal DR_NAME_KANA_FIRST As String, ByRef control As TextBox)
        control.Text = DR_NAME_KANA_FIRST
    End Sub
    Public Shared Sub SetForm_DR_NAME_KANA_LAST(ByVal DR_NAME_KANA_LAST As String, ByRef control As TextBox)
        control.Text = DR_NAME_KANA_LAST
    End Sub

    Public Shared Sub SetForm_MEMBER_NAME_KANA_FIRST(ByVal MEMBER_NAME_KANA_FIRST As String, ByRef control As TextBox)
        control.Text = MEMBER_NAME_KANA_FIRST
    End Sub
    Public Shared Sub SetForm_MEMBER_NAME_KANA_LAST(ByVal MEMBER_NAME_KANA_LAST As String, ByRef control As TextBox)
        control.Text = MEMBER_NAME_KANA_LAST
    End Sub

    '所属
    Public Shared Sub SetForm_OFFICE(ByVal OFFICE As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(OFFICE, control)
    End Sub

    'PCメールアドレス
    Public Shared Sub SetForm_PC_MAIL(ByVal PC_MAIL As String, ByRef control As TextBox)
        control.Text = Replace(PC_MAIL, System.Configuration.ConfigurationManager.AppSettings("DomainPC"), "")
    End Sub
    'Public Shared sub SetForm_PC_MAIL(ByVal PC_MAIL As String, ByRef control As TextBox)
    '    control.Text = PC_MAIL
    'End Sub

    'Drメールアドレス
    Public Shared Sub SetForm_DR_MAIL(ByVal DR_MAIL As String, ByRef control As TextBox)
        control.Text = DR_MAIL
    End Sub

    '携帯メールアドレス
    Public Shared Sub SetForm_KEITAI_MAIL(ByVal KEITAI_MAIL As String, ByRef control As TextBox)
        control.Text = Replace(KEITAI_MAIL, System.Configuration.ConfigurationManager.AppSettings("DomainKeitai"), "")
    End Sub
    'Public Shared sub SetForm_KEITAI_MAIL(ByVal KEITAI_MAIL As String, ByRef control As TextBox)
    '    control.Text = KEITAI_MAIL
    'End Sub

    '施設・病院名称
    Public Shared Sub SetForm_SHISETSU_NAME(ByVal SHISETSU_NAME As String, ByRef control As TextBox)
        control.Text = SHISETSU_NAME
    End Sub
    Public Shared Sub SetForm_SHISETSU_NAME(ByVal SHISETSU_NAME As String, ByRef control As Label)
        control.Text = SHISETSU_NAME
    End Sub
    Public Shared Sub SetForm_SHISETSU_NAME(ByVal DATA_ID As String, ByVal MEMBER_ID As String, ByVal SHISETSU_NAME As String, ByRef control As DropDownList)
        On Error Resume Next

        Dim wCount As Integer
        Dim wIndex As Integer = 0
        Dim wStr As String = DATA_ID & "|" & MEMBER_ID & "|" & SHISETSU_NAME
        If Trim(SHISETSU_NAME) = "" Then wIndex = 0

        For wCount = 0 To control.Items.Count - 1
            If SHISETSU_NAME = Trim(control.Items(wCount).Text) Then
                wIndex = wCount
            End If
        Next
        control.SelectedIndex = wIndex
    End Sub

    '施設・病院名称(カナ)
    Public Shared Sub SetForm_SHISETSU_NAME_KANA(ByVal SHISETSU_NAME_KANA As String, ByRef control As TextBox)
        control.Text = SHISETSU_NAME_KANA
    End Sub

    '診療科
    Public Shared Sub SetForm_KAMOKU(ByVal KAMOKU As String, ByRef control As TextBox)
        control.Text = KAMOKU
    End Sub

    '役職
    Public Shared Sub SetForm_YAKUSHOKU(ByVal YAKUSHOKU As String, ByRef control As TextBox)
        control.Text = YAKUSHOKU
    End Sub

    'おたばこ
    Public Shared Sub SetForm_HOTEL_SMOKING(ByVal HOTEL_SMOKING As String, ByRef control_No As RadioButton, ByRef control_Yes As RadioButton)
        If HOTEL_SMOKING = AppConst.HOTEL_SMOKING.Code.No Then
            control_No.Checked = True
            control_Yes.Checked = False
        ElseIf HOTEL_SMOKING = AppConst.HOTEL_SMOKING.Code.Yes Then
            control_No.Checked = False
            control_Yes.Checked = True
        Else
            control_No.Checked = False
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_HOTEL_SMOKING_No(ByVal HOTEL_SMOKING As String, ByRef control_No As RadioButton)
        If HOTEL_SMOKING = AppConst.HOTEL_SMOKING.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_HOTEL_SMOKING_Yes(ByVal HOTEL_SMOKING As String, ByRef control_Yes As RadioButton)
        If HOTEL_SMOKING = AppConst.HOTEL_SMOKING.Code.Yes Then
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

    '宿泊日
    Public Shared Sub SetForm_STAY_DATE(ByVal STAY_DATE As String, ByRef control_Before As RadioButton, ByRef control_BeforeTojitsu As RadioButton, ByRef control_Tojitsu As RadioButton, ByRef control_TojitsuAfter As RadioButton, ByRef control_After As RadioButton)
        Select Case STAY_DATE
            Case AppConst.STAY_DATE.Code.Before, AppConst.STAY_DATE.Name.Before
                control_Before.Checked = True
                control_BeforeTojitsu.Checked = False
                control_Tojitsu.Checked = False
                control_TojitsuAfter.Checked = False
                control_After.Checked = False
            Case AppConst.STAY_DATE.Code.BeforeTojitsu, AppConst.STAY_DATE.Name.BeforeTojitsu
                control_Before.Checked = False
                control_BeforeTojitsu.Checked = True
                control_Tojitsu.Checked = False
                control_TojitsuAfter.Checked = False
                control_After.Checked = False
            Case AppConst.STAY_DATE.Code.Tojitsu, AppConst.STAY_DATE.Name.Tojitsu
                control_Before.Checked = False
                control_BeforeTojitsu.Checked = False
                control_Tojitsu.Checked = True
                control_TojitsuAfter.Checked = False
                control_After.Checked = False
            Case AppConst.STAY_DATE.Code.TojitsuAfter, AppConst.STAY_DATE.Name.TojitsuAfter
                control_Before.Checked = False
                control_BeforeTojitsu.Checked = False
                control_Tojitsu.Checked = False
                control_TojitsuAfter.Checked = True
                control_After.Checked = False
            Case AppConst.STAY_DATE.Code.After, AppConst.STAY_DATE.Name.After
                control_Before.Checked = False
                control_BeforeTojitsu.Checked = False
                control_Tojitsu.Checked = False
                control_TojitsuAfter.Checked = False
                control_After.Checked = True
            Case Else
                control_Before.Checked = False
                control_BeforeTojitsu.Checked = False
                control_Tojitsu.Checked = False
                control_TojitsuAfter.Checked = False
                control_After.Checked = False
        End Select
    End Sub
    Public Shared Sub SetForm_STAY_DATE_Before(ByVal STAY_DATE As String, ByRef control_Before As RadioButton)
        If STAY_DATE = AppConst.STAY_DATE.Code.Before Then
            control_Before.Checked = True
        Else
            control_Before.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_STAY_DATE_BeforeTojitsu(ByVal STAY_DATE As String, ByRef control_BeforeTojitsu As RadioButton)
        If STAY_DATE = AppConst.STAY_DATE.Code.BeforeTojitsu Then
            control_BeforeTojitsu.Checked = True
        Else
            control_BeforeTojitsu.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_STAY_DATE_Tojitsu(ByVal STAY_DATE As String, ByRef control_Tojitsu As RadioButton)
        If STAY_DATE = AppConst.STAY_DATE.Code.Tojitsu Then
            control_Tojitsu.Checked = True
        Else
            control_Tojitsu.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_STAY_DATE_TojitsuAfter(ByVal STAY_DATE As String, ByRef control_TojitsuAfter As RadioButton)
        If STAY_DATE = AppConst.STAY_DATE.Code.TojitsuAfter Then
            control_TojitsuAfter.Checked = True
        Else
            control_TojitsuAfter.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_STAY_DATE_After(ByVal STAY_DATE As String, ByRef control_After As RadioButton)
        If STAY_DATE = AppConst.STAY_DATE.Code.After Then
            control_After.Checked = True
        Else
            control_After.Checked = False
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

    '航空便/JR
    Public Shared Sub SetForm_O_KOTSU_KUBUN_1(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
        If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR Then
            control_AIR.Checked = True
            control_JR.Checked = False
            control_None.Checked = False
        ElseIf O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR Then
            control_AIR.Checked = False
            control_JR.Checked = True
            control_None.Checked = False
        Else
            control_AIR.Checked = False
            control_JR.Checked = False
            control_None.Checked = True
        End If
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_1_AIR(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton)
        If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR Then
            control_AIR.Checked = True
        Else
            control_AIR.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_1_JR(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_JR As RadioButton)
        If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR Then
            control_JR.Checked = True
        Else
            control_JR.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_1_None(ByVal O_KOTSU_KUBUN_1 As String, ByRef control_None As RadioButton)
        If O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR Then
            control_None.Checked = False
        ElseIf O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR Then
            control_None.Checked = False
        Else
            control_None.Checked = True
        End If
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_2(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_2, control_AIR, control_JR, control_None)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_2_AIR(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_AIR(O_KOTSU_KUBUN_2, control_AIR)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_2_JR(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_JR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_JR(O_KOTSU_KUBUN_2, control_JR)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_2_None(ByVal O_KOTSU_KUBUN_2 As String, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_None(O_KOTSU_KUBUN_2, control_None)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_3(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_3, control_AIR, control_JR, control_None)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_3_AIR(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_AIR(O_KOTSU_KUBUN_3, control_AIR)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_3_JR(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_JR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_JR(O_KOTSU_KUBUN_3, control_JR)
    End Sub
    Public Shared Sub SetForm_O_KOTSU_KUBUN_3_None(ByVal O_KOTSU_KUBUN_3 As String, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_None(O_KOTSU_KUBUN_3, control_None)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_1(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_1, control_AIR, control_JR, control_None)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_1_AIR(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_AIR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_AIR(F_KOTSU_KUBUN_1, control_AIR)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_1_JR(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_JR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_JR(F_KOTSU_KUBUN_1, control_JR)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_1_None(ByVal F_KOTSU_KUBUN_1 As String, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_None(F_KOTSU_KUBUN_1, control_None)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_2(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_2, control_AIR, control_JR, control_None)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_2_AIR(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_AIR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_AIR(F_KOTSU_KUBUN_2, control_AIR)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_2_JR(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_JR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_JR(F_KOTSU_KUBUN_2, control_JR)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_2_None(ByVal F_KOTSU_KUBUN_2 As String, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_None(F_KOTSU_KUBUN_2, control_None)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_3(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton, ByRef control_JR As RadioButton, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_3, control_AIR, control_JR, control_None)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_3_AIR(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_AIR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_AIR(F_KOTSU_KUBUN_3, control_AIR)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_3_JR(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_JR As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_JR(F_KOTSU_KUBUN_3, control_JR)
    End Sub
    Public Shared Sub SetForm_F_KOTSU_KUBUN_3_None(ByVal F_KOTSU_KUBUN_3 As String, ByRef control_None As RadioButton)
        SetForm_O_KOTSU_KUBUN_1_None(F_KOTSU_KUBUN_3, control_None)
    End Sub

    '参加区分
    Public Shared Sub SetForm_SANKA_KUBUN(ByVal SANKA_KUBUN As String, ByRef control_Listener As RadioButton, ByRef control_Speaker As RadioButton)
        If SANKA_KUBUN = AppConst.SANKA_KUBUN.Code.Listener Then
            control_Listener.Checked = True
            control_Speaker.Checked = False
        ElseIf SANKA_KUBUN = AppConst.SANKA_KUBUN.Code.Speaker Then
            control_Listener.Checked = False
            control_Speaker.Checked = True
        Else
            control_Listener.Checked = False
            control_Speaker.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_SANKA_KUBUN_Listener(ByVal SANKA_KUBUN As String, ByRef control_Listener As RadioButton)
        If SANKA_KUBUN = AppConst.SANKA_KUBUN.Code.Listener Then
            control_Listener.Checked = True
        Else
            control_Listener.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_SANKA_KUBUN_Speaker(ByVal SANKA_KUBUN As String, ByRef control_Speaker As RadioButton)
        If SANKA_KUBUN = AppConst.SANKA_KUBUN.Code.Speaker Then
            control_Speaker.Checked = True
        Else
            control_Speaker.Checked = False
        End If
    End Sub

    '情報交換会
    Public Shared Sub SetForm_PARTY(ByVal PARTY As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If PARTY = AppConst.PARTY.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf PARTY = AppConst.PARTY.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_PARTY_Yes(ByVal PARTY As String, ByRef control_Yes As RadioButton)
        If PARTY = AppConst.PARTY.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_PARTY_No(ByVal PARTY As String, ByRef control_No As RadioButton)
        If PARTY = AppConst.PARTY.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub

    '公務員
    Public Shared Sub SetForm_PUBLIC_SERVANT(ByVal PUBLIC_SERVANT As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If PUBLIC_SERVANT = AppConst.PUBLIC_SERVANT.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf PUBLIC_SERVANT = AppConst.PUBLIC_SERVANT.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_PUBLIC_SERVANT_Yes(ByVal PUBLIC_SERVANT As String, ByRef control_Yes As RadioButton)
        If PUBLIC_SERVANT = AppConst.PUBLIC_SERVANT.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_PUBLIC_SERVANT_No(ByVal PUBLIC_SERVANT As String, ByRef control_No As RadioButton)
        If PUBLIC_SERVANT = AppConst.PUBLIC_SERVANT.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub

    '二次使用
    Public Shared Sub SetForm_SECANDARY_USE(ByVal SECANDARY_USE As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If SECANDARY_USE = AppConst.SECANDARY_USE.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf SECANDARY_USE = AppConst.SECANDARY_USE.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_SECANDARY_USE_Yes(ByVal SECANDARY_USE As String, ByRef control_Yes As RadioButton)
        If SECANDARY_USE = AppConst.SECANDARY_USE.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_SECANDARY_USE_No(ByVal SECANDARY_USE As String, ByRef control_No As RadioButton)
        If SECANDARY_USE = AppConst.SECANDARY_USE.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub

    'ウェットラボ
    Public Shared Sub SetForm_WETLAB_FLAG(ByVal WETLAB_FLAG As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If WETLAB_FLAG = AppConst.WETLAB_FLAG.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf WETLAB_FLAG = AppConst.WETLAB_FLAG.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_WETLAB_FLAG_Yes(ByVal WETLAB_FLAG As String, ByRef control_Yes As RadioButton)
        If WETLAB_FLAG = AppConst.WETLAB_FLAG.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_WETLAB_FLAG_No(ByVal WETLAB_FLAG As String, ByRef control_No As RadioButton)
        If WETLAB_FLAG = AppConst.WETLAB_FLAG.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub

    'ウェットラボコース
    Public Shared Sub SetForm_WETLAB_COURSE(ByVal WETLAB_COURSE As String, ByRef control_A As RadioButton, ByRef control_B As RadioButton)
        If WETLAB_COURSE = AppConst.WETLAB_COURSE.Code.A Then
            control_A.Checked = True
            control_B.Checked = False
        ElseIf WETLAB_COURSE = AppConst.WETLAB_COURSE.Code.B Then
            control_A.Checked = False
            control_B.Checked = True
        Else
            control_A.Checked = False
            control_B.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_WETLAB_COURSE_A(ByVal WETLAB_COURSE As String, ByRef control_A As RadioButton)
        If WETLAB_COURSE = AppConst.WETLAB_COURSE.Code.A Then
            control_A.Checked = True
        Else
            control_A.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_WETLAB_COURSE_B(ByVal WETLAB_COURSE As String, ByRef control_B As RadioButton)
        If WETLAB_COURSE = AppConst.WETLAB_COURSE.Code.B Then
            control_B.Checked = True
        Else
            control_B.Checked = False
        End If
    End Sub

    '宿泊備考欄
    Public Shared Sub SetForm_NOTE_HOTEL(ByVal NOTE_HOTEL As String, ByRef control As TextBox)
        control.Text = NOTE_HOTEL
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

    '来場
    Public Shared Sub SetForm_ATTEND(ByVal ATTEND As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton, ByVal control_Mi As RadioButton)
        If ATTEND = AppConst.ATTEND.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
            control_Mi.Checked = False
        ElseIf ATTEND = AppConst.ATTEND.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
            control_Mi.Checked = False
        ElseIf ATTEND = AppConst.ATTEND.Code.Mi Then
            control_Yes.Checked = False
            control_No.Checked = False
            control_Mi.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
            control_Mi.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ATTEND_Yes(ByVal ATTEND As String, ByRef control_Yes As RadioButton)
        If ATTEND = AppConst.ATTEND.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ATTEND_No(ByVal ATTEND As String, ByRef control_No As RadioButton)
        If ATTEND = AppConst.ATTEND.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ATTEND_Mi(ByVal ATTEND As String, ByRef control_Mi As RadioButton)
        If ATTEND = AppConst.ATTEND.Code.Mi Then
            control_Mi.Checked = True
        Else
            control_Mi.Checked = False
        End If
    End Sub

    '都道府県
    Public Shared Sub SetForm_PREFECTURES_NO(ByVal PREFECTURES_NO As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(PREFECTURES_NO, control)
    End Sub

    '年齢
    Public Shared Sub SetForm_AGE(ByVal AGE As String, ByRef control As TextBox)
        control.Text = AGE
    End Sub

    'チェックイン
    Public Shared Sub SetForm_CHECK_IN(ByVal CHECK_IN As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(CHECK_IN, control)
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHECK_IN(ByVal ACCOMPANY_CHECK_IN As String, ByRef control As DropDownList)
        SetForm_CHECK_IN(ACCOMPANY_CHECK_IN, control)
    End Sub
    Public Shared Sub SetForm_CHECK_IN(ByVal CHECK_IN As String, ByRef control As Label)
        control.Text = GetName_CHECK_IN(CHECK_IN)
    End Sub

    'チェックアウト
    Public Shared Sub SetForm_CHECK_OUT(ByVal CHECK_OUT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(CHECK_OUT, control)
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHECK_OUT(ByVal ACCOMPANY_CHECK_OUT As String, ByRef control As DropDownList)
        SetForm_CHECK_OUT(ACCOMPANY_CHECK_OUT, control)
    End Sub
    Public Shared Sub SetForm_CHECK_OUT(ByVal CHECK_out As String, ByRef control As Label)
        control.Text = GetName_CHECK_OUT(CHECK_out)
    End Sub

    '乗車・搭乗日
    Public Shared Sub SetForm_O_DATE_1(ByVal O_DATE_1 As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(O_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_O_DATE_2(ByVal O_DATE_2 As String, ByRef control As DropDownList)
        SetForm_O_DATE_1(O_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_O_DATE_3(ByVal O_DATE3 As String, ByRef control As DropDownList)
        SetForm_O_DATE_1(O_DATE3, control)
    End Sub
    Public Shared Sub SetForm_F_DATE_1(ByVal F_DATE_1 As String, ByRef control As DropDownList)
        SetForm_O_DATE_1(F_DATE_1, control)
    End Sub
    Public Shared Sub SetForm_F_DATE_2(ByVal F_DATE_2 As String, ByRef control As DropDownList)
        SetForm_O_DATE_1(F_DATE_2, control)
    End Sub
    Public Shared Sub SetForm_F_DATE_3(ByVal F_DATE_3 As String, ByRef control As DropDownList)
        SetForm_O_DATE_1(F_DATE_3, control)
    End Sub

    '区間
    Public Shared Sub SetForm_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As String, ByRef control As TextBox)
        control.Text = O_AIRPORT1_1
    End Sub
    Public Shared Sub SetForm_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(O_AIRPORT2_1, control)
    End Sub
    Public Shared Sub SetForm_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(O_AIRPORT1_2, control)
    End Sub
    Public Shared Sub SetForm_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(O_AIRPORT2_2, control)
    End Sub
    Public Shared Sub SetForm_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(O_AIRPORT1_3, control)
    End Sub
    Public Shared Sub SetForm_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(O_AIRPORT2_3, control)
    End Sub
    Public Shared Sub SetForm_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(F_AIRPORT1_1, control)
    End Sub
    Public Shared Sub SetForm_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(F_AIRPORT2_1, control)
    End Sub
    Public Shared Sub SetForm_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(F_AIRPORT1_2, control)
    End Sub
    Public Shared Sub SetForm_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(F_AIRPORT2_2, control)
    End Sub
    Public Shared Sub SetForm_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(F_AIRPORT1_3, control)
    End Sub
    Public Shared Sub SetForm_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As String, ByRef control As TextBox)
        SetForm_O_AIRPORT1_1(F_AIRPORT2_3, control)
    End Sub

    '新幹線・特急区間
    Public Shared Sub SetForm_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As String, ByRef control As TextBox)
        control.Text = O_EXPRESS1_1
    End Sub
    Public Shared Sub SetForm_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(O_EXPRESS2_1, control)
    End Sub
    Public Shared Sub SetForm_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(O_EXPRESS1_2, control)
    End Sub
    Public Shared Sub SetForm_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(O_EXPRESS2_2, control)
    End Sub
    Public Shared Sub SetForm_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(O_EXPRESS1_3, control)
    End Sub
    Public Shared Sub SetForm_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(O_EXPRESS2_3, control)
    End Sub
    Public Shared Sub SetForm_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(F_EXPRESS1_1, control)
    End Sub
    Public Shared Sub SetForm_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(F_EXPRESS2_1, control)
    End Sub
    Public Shared Sub SetForm_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(F_EXPRESS1_2, control)
    End Sub
    Public Shared Sub SetForm_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(F_EXPRESS2_2, control)
    End Sub
    Public Shared Sub SetForm_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(F_EXPRESS1_3, control)
    End Sub
    Public Shared Sub SetForm_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As String, ByRef control As TextBox)
        SetForm_O_EXPRESS1_1(F_EXPRESS2_3, control)
    End Sub

    '乗車券区間
    Public Shared Sub SetForm_O_LOCAL1_1(ByVal O_LOCAL1_1 As String, ByRef control As TextBox)
        control.Text = O_LOCAL1_1
    End Sub
    Public Shared Sub SetForm_O_LOCAL2_1(ByVal O_LOCAL2_1 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(O_LOCAL2_1, control)
    End Sub
    Public Shared Sub SetForm_O_LOCAL1_2(ByVal O_LOCAL1_2 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(O_LOCAL1_2, control)
    End Sub
    Public Shared Sub SetForm_O_LOCAL2_2(ByVal O_LOCAL2_2 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(O_LOCAL2_2, control)
    End Sub
    Public Shared Sub SetForm_O_LOCAL1_3(ByVal O_LOCAL1_3 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(O_LOCAL1_3, control)
    End Sub
    Public Shared Sub SetForm_O_LOCAL2_3(ByVal O_LOCAL2_3 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(O_LOCAL2_3, control)
    End Sub
    Public Shared Sub SetForm_F_LOCAL1_1(ByVal F_LOCAL1_1 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(F_LOCAL1_1, control)
    End Sub
    Public Shared Sub SetForm_F_LOCAL2_1(ByVal F_LOCAL2_1 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(F_LOCAL2_1, control)
    End Sub
    Public Shared Sub SetForm_F_LOCAL1_2(ByVal F_LOCAL1_2 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(F_LOCAL1_2, control)
    End Sub
    Public Shared Sub SetForm_F_LOCAL2_2(ByVal F_LOCAL2_2 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(F_LOCAL2_2, control)
    End Sub
    Public Shared Sub SetForm_F_LOCAL1_3(ByVal F_LOCAL1_3 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(F_LOCAL1_3, control)
    End Sub
    Public Shared Sub SetForm_F_LOCAL2_3(ByVal F_LOCAL2_3 As String, ByRef control As TextBox)
        SetForm_O_LOCAL1_1(F_LOCAL2_3, control)
    End Sub

    '時間
    Public Shared Sub SetForm_O_TIME1_1(ByVal O_TIME1_1 As String, ByRef control As TextBox)
        control.Text = O_TIME1_1
    End Sub
    Public Shared Sub SetForm_O_TIME2_1(ByVal O_TIME2_1 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(O_TIME2_1, control)
    End Sub
    Public Shared Sub SetForm_O_TIME1_2(ByVal O_TIME1_2 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(O_TIME1_2, control)
    End Sub
    Public Shared Sub SetForm_O_TIME2_2(ByVal O_TIME2_2 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(O_TIME2_2, control)
    End Sub
    Public Shared Sub SetForm_O_TIME1_3(ByVal O_TIME1_3 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(O_TIME1_3, control)
    End Sub
    Public Shared Sub SetForm_O_TIME2_3(ByVal O_TIME2_3 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(O_TIME2_3, control)
    End Sub
    Public Shared Sub SetForm_F_TIME1_1(ByVal F_TIME1_1 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(F_TIME1_1, control)
    End Sub
    Public Shared Sub SetForm_F_TIME2_1(ByVal F_TIME2_1 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(F_TIME2_1, control)
    End Sub
    Public Shared Sub SetForm_F_TIME1_2(ByVal F_TIME1_2 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(F_TIME1_2, control)
    End Sub
    Public Shared Sub SetForm_F_TIME2_2(ByVal F_TIME2_2 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(F_TIME2_2, control)
    End Sub
    Public Shared Sub SetForm_F_TIME1_3(ByVal F_TIME1_3 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(F_TIME1_3, control)
    End Sub
    Public Shared Sub SetForm_F_TIME2_3(ByVal F_TIME2_3 As String, ByRef control As TextBox)
        SetForm_O_TIME1_1(F_TIME2_3, control)
    End Sub

    '便名
    Public Shared Sub SetForm_O_BIN_1(ByVal O_BIN_1 As String, ByRef control As TextBox)
        control.Text = O_BIN_1
    End Sub
    Public Shared Sub SetForm_O_BIN_2(ByVal O_BIN_2 As String, ByRef control As TextBox)
        SetForm_O_BIN_1(O_BIN_2, control)
    End Sub
    Public Shared Sub SetForm_O_BIN_3(ByVal O_BIN_3 As String, ByRef control As TextBox)
        SetForm_O_BIN_1(O_BIN_3, control)
    End Sub
    Public Shared Sub SetForm_F_BIN_1(ByVal F_BIN_1 As String, ByRef control As TextBox)
        SetForm_O_BIN_1(F_BIN_1, control)
    End Sub
    Public Shared Sub SetForm_F_BIN_2(ByVal F_BIN_2 As String, ByRef control As TextBox)
        SetForm_O_BIN_1(F_BIN_2, control)
    End Sub
    Public Shared Sub SetForm_F_BIN_3(ByVal F_BIN_3 As String, ByRef control As TextBox)
        SetForm_O_BIN_1(F_BIN_3, control)
    End Sub

    '航空会社
    Public Shared Sub SetForm_AIRLINE(ByVal AIRLINE As String, ByRef control_ANA As RadioButton, ByRef control_JAL As RadioButton)
        If AIRLINE = AppConst.AIRLINE.Code.ANA Then
            control_ANA.Checked = True
            control_JAL.Checked = False
        ElseIf AIRLINE = AppConst.AIRLINE.Code.JAL Then
            control_ANA.Checked = False
            control_JAL.Checked = True
        Else
            control_ANA.Checked = False
            control_JAL.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_AIRLINE_ANA(ByVal AIRLINE As String, ByRef control_ANA As RadioButton)
        If AIRLINE = AppConst.AIRLINE.Code.ANA Then
            control_ANA.Checked = True
        Else
            control_ANA.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_AIRLINE_JAL(ByVal AIRLINE As String, ByRef control_JAL As RadioButton)
        If AIRLINE = AppConst.AIRLINE.Code.JAL Then
            control_JAL.Checked = True
        Else
            control_JAL.Checked = False
        End If
    End Sub

    'マイレージナンバー
    Public Shared Sub SetForm_MILAGE_NO(ByVal MILAGE_NO As String, ByRef control As TextBox)
        control.Text = MILAGE_NO
    End Sub

    '座席希望
    Public Shared Sub SetForm_O_SEAT_1(ByVal O_SEAT_1 As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(O_SEAT_1, control)
    End Sub
    Public Shared Sub SetForm_O_SEAT_2(ByVal O_SEAT_2 As String, ByRef control As DropDownList)
        SetForm_O_SEAT_1(O_SEAT_2, control)
    End Sub
    Public Shared Sub SetForm_O_SEAT_3(ByVal O_SEAT_3 As String, ByRef control As DropDownList)
        SetForm_O_SEAT_1(O_SEAT_3, control)
    End Sub
    Public Shared Sub SetForm_F_SEAT_1(ByVal F_SEAT_1 As String, ByRef control As DropDownList)
        SetForm_O_SEAT_1(F_SEAT_1, control)
    End Sub
    Public Shared Sub SetForm_F_SEAT_2(ByVal F_SEAT_2 As String, ByRef control As DropDownList)
        SetForm_O_SEAT_1(F_SEAT_2, control)
    End Sub
    Public Shared Sub SetForm_F_SEAT_3(ByVal F_SEAT_3 As String, ByRef control As DropDownList)
        SetForm_O_SEAT_1(F_SEAT_3, control)
    End Sub

    '座席区分
    Public Shared Sub SetForm_O_SEATCLASS_1(ByVal O_SEATCLASS_1 As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(O_SEATCLASS_1, control)
    End Sub
    Public Shared Sub SetForm_O_SEATCLASS_2(ByVal O_SEATCLASS_2 As String, ByRef control As DropDownList)
        SetForm_O_SEATCLASS_1(O_SEATCLASS_2, control)
    End Sub
    Public Shared Sub SetForm_O_SEATCLASS_3(ByVal O_SEATCLASS_3 As String, ByRef control As DropDownList)
        SetForm_O_SEATCLASS_1(O_SEATCLASS_3, control)
    End Sub
    Public Shared Sub SetForm_F_SEATCLASS_1(ByVal F_SEATCLASS_1 As String, ByRef control As DropDownList)
        SetForm_O_SEATCLASS_1(F_SEATCLASS_1, control)
    End Sub
    Public Shared Sub SetForm_F_SEATCLASS_2(ByVal F_SEATCLASS_2 As String, ByRef control As DropDownList)
        SetForm_O_SEATCLASS_1(F_SEATCLASS_2, control)
    End Sub
    Public Shared Sub SetForm_F_SEATCLASS_3(ByVal F_SEATCLASS_3 As String, ByRef control As DropDownList)
        SetForm_O_SEATCLASS_1(F_SEATCLASS_3, control)
    End Sub

    '交通備考欄
    Public Shared Sub SetForm_NOTE_KOTSU(ByVal NOTE_KOTSU As String, ByRef control As TextBox)
        control.Text = NOTE_KOTSU
    End Sub

    '携帯電話番号
    Public Shared Sub SetForm_KEITAI(ByVal KEITAI As String, ByRef control As TextBox)
        control.Text = KEITAI
    End Sub
    Public Shared Sub SetForm_KEITAI(ByVal KEITAI As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox, ByRef control_3 As TextBox)
        Dim wKEITAI_1 As String = ""
        Dim wKEITAI_2 As String = ""
        Dim wKEITAI_3 As String = ""
        If Trim(KEITAI) = "" OrElse Trim(StrConv(KEITAI, VbStrConv.Narrow)) = "-" Then
        Else
            Dim wSplit() As String
            If InStr(KEITAI, "-") > 0 Then
                wSplit = Split(Trim(KEITAI), "-")
                Try
                    wKEITAI_1 = wSplit(0)
                    wKEITAI_2 = wSplit(1)
                    wKEITAI_3 = wSplit(2)
                Catch ex As Exception
                    wKEITAI_1 = ""
                    wKEITAI_2 = ""
                    wKEITAI_3 = ""
                End Try
            End If
        End If
        control_1.Text = wKEITAI_1
        control_2.Text = wKEITAI_2
        control_3.Text = wKEITAI_3
    End Sub

    'チケット送付先
    Public Shared Sub SetForm_SEND_SAKI(ByVal SEND_SAKI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(SEND_SAKI, control)
    End Sub

    '送付先: 郵便番号
    Public Shared Sub SetForm_SEND_ZIP(ByVal SEND_ZIP As String, ByRef control As TextBox)
        control.Text = SEND_ZIP
    End Sub
    Public Shared Sub SetForm_SEND_ZIP(ByVal SEND_ZIP As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox)
        Dim wZIP_1 As String = ""
        Dim wZIP_2 As String = ""
        If Trim(SEND_ZIP) = "" OrElse Trim(StrConv(SEND_ZIP, VbStrConv.Narrow)) = "-" Then
        Else
            Dim wSplit() As String
            If InStr(SEND_ZIP, "-") > 0 Then
                wSplit = Split(Trim(SEND_ZIP), "-")
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

    '送付先: 住所
    Public Shared Sub SetForm_SEND_ADDRESS(ByVal SEND_ADDRESS As String, ByRef control As TextBox)
        control.Text = SEND_ADDRESS
    End Sub

    '送付先: 電話番号
    Public Shared Sub SetForm_SEND_TEL(ByVal SEND_TEL As String, ByRef control As TextBox)
        control.Text = SEND_TEL
    End Sub
    Public Shared Sub SetForm_SEND_TEL(ByVal SEND_TEL As String, ByRef control_1 As TextBox, ByRef control_2 As TextBox, ByRef control_3 As TextBox)
        Dim wTEL_1 As String = ""
        Dim wTEL_2 As String = ""
        Dim wTEL_3 As String = ""
        If Trim(SEND_TEL) = "" OrElse Trim(StrConv(SEND_TEL, VbStrConv.Narrow)) = "-" Then
        Else
            Dim wSplit() As String
            If InStr(SEND_TEL, "-") > 0 Then
                wSplit = Split(Trim(SEND_TEL), "-")
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


    '送付先: 宛先名
    Public Shared Sub SetForm_SEND_NAME(ByVal SEND_NAME As String, ByRef control As TextBox)
        control.Text = SEND_NAME
    End Sub

    '備考
    Public Shared Sub SetForm_NOTES(ByVal NOTES As String, ByRef control As TextBox)
        control.Text = NOTES
    End Sub

    '同伴者
    Public Shared Sub SetForm_NOTE_ACCOMPANY(ByVal NOTE_ACCOMPANY As String, ByRef control As TextBox)
        control.Text = NOTE_ACCOMPANY
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_FLAG(ByVal ACCOMPANY_FLAG As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If ACCOMPANY_FLAG = AppConst.ACCOMPANY_FLAG.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf ACCOMPANY_FLAG = AppConst.ACCOMPANY_FLAG.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = True
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_FLAG_Yes(ByVal ACCOMPANY_FLAG As String, ByRef control_Yes As RadioButton)
        If ACCOMPANY_FLAG = AppConst.ACCOMPANY_FLAG.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_FLAG_No(ByVal ACCOMPANY_FLAG As String, ByRef control_No As RadioButton)
        If ACCOMPANY_FLAG = AppConst.ACCOMPANY_FLAG.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_STAY(ByVal ACCOMPANY_STAY As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = True
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_STAY_Yes(ByVal ACCOMPANY_STAY As String, ByRef control_Yes As RadioButton)
        If ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_STAY_No(ByVal ACCOMPANY_STAY As String, ByRef control_No As RadioButton)
        If ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub

    '同日程
    Public Shared Sub SetForm_ACCOMPANY_STAY_DATE(ByVal ACCOMPANY_STAY_DATE As String, ByRef control_Yes As CheckBox)
        If ACCOMPANY_STAY_DATE = AppConst.ACCOMPANY_STAY_DATE.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub

    '同室
    Public Shared Sub SetForm_ACCOMPANY_SAME_ROOM(ByVal ACCOMPANY_SAME_ROOM As String, ByRef control_Yes As CheckBox)
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub

    '同伴者 性別
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SEX_1(ByVal ACCOMPANY_CHILD_SEX_1 As String, ByRef control_Male As RadioButton, ByRef control_Female As RadioButton)
        If ACCOMPANY_CHILD_SEX_1 = AppConst.SEX.Code.Male Then
            control_Male.Checked = True
            control_Female.Checked = False
        ElseIf ACCOMPANY_CHILD_SEX_1 = AppConst.SEX.Code.Female Then
            control_Male.Checked = False
            control_Female.Checked = True
        Else
            control_Male.Checked = False
            control_Female.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SEX_1_Male(ByVal ACCOMPANY_CHILD_SEX_1 As String, ByRef control_Male As RadioButton)
        If ACCOMPANY_CHILD_SEX_1 = AppConst.SEX.Code.Male Then
            control_Male.Checked = True
        Else
            control_Male.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SEX_1_Female(ByVal ACCOMPANY_CHILD_SEX_1 As String, ByRef control_Female As RadioButton)
        If ACCOMPANY_CHILD_SEX_1 = AppConst.SEX.Code.Female Then
            control_Female.Checked = True
        Else
            control_Female.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SEX_2(ByVal ACCOMPANY_CHILD_SEX_2 As String, ByRef control_Male As RadioButton, ByRef control_Female As RadioButton)
        SetForm_ACCOMPANY_CHILD_SEX_1(ACCOMPANY_CHILD_SEX_2, control_Male, control_Female)
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SEX_2_Male(ByVal ACCOMPANY_CHILD_SEX_2 As String, ByRef control_Male As RadioButton)
        SetForm_ACCOMPANY_CHILD_SEX_1_Male(ACCOMPANY_CHILD_SEX_2, control_Male)
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SEX_2_Female(ByVal ACCOMPANY_CHILD_SEX_2 As String, ByRef control_Female As RadioButton)
        SetForm_ACCOMPANY_CHILD_SEX_1_Female(ACCOMPANY_CHILD_SEX_2, control_Female)
    End Sub

    '同伴者ベッド
    Public Shared Sub SetForm_ACCOMPANY_CHILD_BED_1(ByVal ACCOMPANY_CHILD_BED_1 As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        If ACCOMPANY_CHILD_BED_1 = AppConst.ACCOMPANY_BED.Code.Yes Then
            control_Yes.Checked = True
            control_No.Checked = False
        ElseIf ACCOMPANY_CHILD_BED_1 = AppConst.ACCOMPANY_BED.Code.No Then
            control_Yes.Checked = False
            control_No.Checked = True
        Else
            control_Yes.Checked = False
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_BED_1_Yes(ByVal ACCOMPANY_CHILD_BED_1 As String, ByRef control_Yes As RadioButton)
        If ACCOMPANY_CHILD_BED_1 = AppConst.ACCOMPANY_BED.Code.Yes Then
            control_Yes.Checked = True
        Else
            control_Yes.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_BED_1_No(ByVal ACCOMPANY_CHILD_BED_1 As String, ByRef control_No As RadioButton)
        If ACCOMPANY_CHILD_BED_1 = AppConst.ACCOMPANY_BED.Code.No Then
            control_No.Checked = True
        Else
            control_No.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_BED_2(ByVal ACCOMPANY_CHILD_BED_2 As String, ByRef control_Yes As RadioButton, ByRef control_No As RadioButton)
        SetForm_ACCOMPANY_CHILD_BED_1(ACCOMPANY_CHILD_BED_2, control_Yes, control_No)
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_BED_2_Yes(ByVal ACCOMPANY_CHILD_BED_2 As String, ByRef control_Yes As RadioButton)
        SetForm_ACCOMPANY_CHILD_BED_1_Yes(ACCOMPANY_CHILD_BED_2, control_Yes)
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_BED_2_No(ByVal ACCOMPANY_CHILD_BED_2 As String, ByRef control_No As RadioButton)
        SetForm_ACCOMPANY_CHILD_BED_1_No(ACCOMPANY_CHILD_BED_2, control_No)
    End Sub

    '同室者人数(大人)
    Public Shared Sub SetForm_ACCOMPANY_ADULT_SU(ByVal ACCOMPANY_ADULT_SU As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ACCOMPANY_ADULT_SU, control)
    End Sub

    '同室者人数(小人)
    Public Shared Sub SetForm_ACCOMPANY_CHILD_SU(ByVal ACCOMPANY_CHILD_SU As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ACCOMPANY_CHILD_SU, control)
    End Sub

    '同室者 年齢
    Public Shared Sub SetForm_ACCOMPANY_CHILD_AGE_1(ByVal ACCOMPANY_CHILD_AGE_1 As String, ByRef control As TextBox)
        control.Text = ACCOMPANY_CHILD_AGE_1
    End Sub
    Public Shared Sub SetForm_ACCOMPANY_CHILD_AGE_2(ByVal ACCOMPANY_CHILD_AGE_2 As String, ByRef control As TextBox)
        SetForm_ACCOMPANY_CHILD_AGE_1(ACCOMPANY_CHILD_AGE_2, control)
    End Sub

    '支払方法
    Public Shared Sub SetForm_PAYMENT_METHOD(ByVal PAYMENT_METHOD As String, ByRef control_Card As RadioButton, ByRef control_Bank As RadioButton)
        If PAYMENT_METHOD = AppConst.PAYMENT_METHOD.Code.Card Then
            control_Card.Checked = True
            control_Bank.Checked = False
        ElseIf PAYMENT_METHOD = AppConst.PAYMENT_METHOD.Code.Bank Then
            control_Card.Checked = False
            control_Bank.Checked = True
        Else
            control_Card.Checked = False
            control_Bank.Checked = True
        End If
    End Sub
    Public Shared Sub SetForm_PAYMENT_METHOD_Card(ByVal PAYMENT_METHOD As String, ByRef control_Card As RadioButton)
        If PAYMENT_METHOD = AppConst.PAYMENT_METHOD.Code.Card Then
            control_Card.Checked = True
        Else
            control_Card.Checked = False
        End If
    End Sub
    Public Shared Sub SetForm_PAYMENT_METHOD_Bank(ByVal PAYMENT_METHOD As String, ByRef control_Bank As RadioButton)
        If PAYMENT_METHOD = AppConst.PAYMENT_METHOD.Code.Bank Then
            control_Bank.Checked = True
        Else
            control_Bank.Checked = False
        End If
    End Sub

    '請求先名
    Public Shared Sub SetForm_BILL_NAME(ByVal BILL_NAME As String, ByRef control As TextBox)
        control.Text = BILL_NAME
    End Sub
    Public Shared Sub SetForm_BILL_NAME(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByRef control As TextBox)
        If Trim(TBL_DR.BILL_NAME) = "" Then
            control.Text = TBL_DR.SHISETSU_NAME & "　" & TBL_DR.DR_NAME_FIRST & " " & TBL_DR.DR_NAME_LAST
        Else
            control.Text = TBL_DR.BILL_NAME
        End If
    End Sub

    '手配状況
    Public Shared Sub SetForm_STATUS_TEHAI(ByVal STATUS_TEHAI As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(STATUS_TEHAI, control)
    End Sub

    '決済状況
    Public Shared Sub SetForm_STATUS_PAYMENT(ByVal STATUS_PAYMENT As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(STATUS_PAYMENT, control)
    End Sub

    '手配特別事項
    Public Shared Sub SetForm_TEHAIMAIL_HOTEL(ByVal TEHAIMAIL_HOTEL As String, ByRef control As TextBox)
        control.Text = TEHAIMAIL_HOTEL
    End Sub
    Public Shared Sub SetForm_TEHAIMAIL_KOTSU(ByVal TEHAIMAIL_KOTSU As String, ByRef control As TextBox)
        control.Text = TEHAIMAIL_KOTSU
    End Sub

    '宿泊確認書
    Public Shared Sub SetForm_HOTELPRINT_SHIHARAI(ByVal HOTELPRINT_SHIHARAI As String, ByRef control As TextBox)
        control.Text = HOTELPRINT_SHIHARAI
    End Sub
    Public Shared Sub SetForm_HOTELPRINT_RENRAKU(ByVal HOTELPRINT_RENRAKU As String, ByRef control As TextBox)
        control.Text = HOTELPRINT_RENRAKU
    End Sub
    Public Shared Sub SetForm_HOTELPRINT_CHECKIN(ByVal HOTELPRINT_CHECKIN As String, ByRef control As TextBox)
        control.Text = HOTELPRINT_CHECKIN
    End Sub
    Public Shared Sub SetForm_HOTELPRINT_ACCOMPANY(ByVal HOTELPRINT_ACCOMPANY As String, ByRef control As TextBox)
        control.Text = HOTELPRINT_ACCOMPANY
    End Sub
    Public Shared Sub SetForm_HOTELPRINT_BREAKFAST(ByVal HOTELPRINT_BREAKFAST As String, ByRef control As TextBox)
        control.Text = HOTELPRINT_BREAKFAST
    End Sub
    Public Shared Sub SetForm_MS_HOTELPRINT_SHIHARAI(ByVal HOTELPRINT_SHIHARAI_IDX As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.DbVal(HOTELPRINT_SHIHARAI_IDX)
    End Sub
    Public Shared Sub SetForm_MS_HOTELPRINT_RENRAKU(ByVal HOTELPRINT_RENRAKU_IDX As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.DbVal(HOTELPRINT_RENRAKU_IDX)
    End Sub
    Public Shared Sub SetForm_MS_HOTELPRINT_CHECKIN(ByVal HOTELPRINT_CHECKIN_IDX As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.DbVal(HOTELPRINT_CHECKIN_IDX)
    End Sub
    Public Shared Sub SetForm_MS_HOTELPRINT_ACCOMPANY(ByVal HOTELPRINT_ACCOMPANY_IDX As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.DbVal(HOTELPRINT_ACCOMPANY_IDX)
    End Sub
    Public Shared Sub SetForm_MS_HOTELPRINT_BREAKFAST(ByVal HOTELPRINT_BREAKFAST_IDX As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.DbVal(HOTELPRINT_BREAKFAST_IDX)
    End Sub

    'ホテル
    Public Shared Sub SetForm_MS_HOTEL(ByVal HOTEL_NAME As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(HOTEL_NAME, control)
    End Sub
    Public Shared Sub SetForm_HOTEL_NAME(ByVal HOTEL_NAME As String, ByRef control As TextBox)
        control.Text = HOTEL_NAME
    End Sub
    Public Shared Sub SetForm_HOTEL_ADDRESS(ByVal HOTEL_ADDRESS As String, ByRef control As TextBox)
        control.Text = HOTEL_ADDRESS
    End Sub
    Public Shared Sub SetForm_HOTEL_TEL(ByVal HOTEL_TEL As String, ByRef control As TextBox)
        control.Text = HOTEL_TEL
    End Sub
    Public Shared Sub SetForm_HOTEL_FAX(ByVal HOTEL_FAX As String, ByRef control As TextBox)
        control.Text = HOTEL_FAX
    End Sub
    Public Shared Sub SetForm_ROOM_TYPE(ByVal ROOM_TYPE As String, ByRef control As DropDownList)
        control.SelectedIndex = CmnModule.GetSelectedIndex(ROOM_TYPE, control)
    End Sub
    Public Shared Sub SetForm_ROOM_TYPE(ByVal ROOM_TYPE As String, ByRef control As HiddenField)
        control.Value = ROOM_TYPE
    End Sub

    '差額
    Public Shared Sub SetForm_SAGAKU_NAME_1(ByVal SAGAKU_NAME_1 As String, ByRef control As TextBox)
        control.Text = SAGAKU_NAME_1
    End Sub
    Public Shared Sub SetForm_SAGAKU_NAME_2(ByVal SAGAKU_NAME_2 As String, ByRef control As TextBox)
        SetForm_SAGAKU_NAME_1(SAGAKU_NAME_2, control)
    End Sub
    Public Shared Sub SetForm_SAGAKU_NAME_3(ByVal SAGAKU_NAME_3 As String, ByRef control As TextBox)
        SetForm_SAGAKU_NAME_1(SAGAKU_NAME_3, control)
    End Sub
    Public Shared Sub SetForm_SAGAKU_1(ByVal SAGAKU_1 As String, ByRef control As TextBox)
        control.Text = SAGAKU_1
    End Sub
    Public Shared Sub SetForm_SAGAKU_2(ByVal SAGAKU_2 As String, ByRef control As TextBox)
        SetForm_SAGAKU_1(SAGAKU_2, control)
    End Sub
    Public Shared Sub SetForm_SAGAKU_3(ByVal SAGAKU_3 As String, ByRef control As TextBox)
        SetForm_SAGAKU_1(SAGAKU_3, control)
    End Sub

    'チケット発送
    Public Shared Sub SetForm_TICKET_SEND_DATE1(ByVal TICKET_SEND_DATE1 As String, ByRef control As TextBox)
        control.Text = TICKET_SEND_DATE1
    End Sub
    Public Shared Sub SetForm_TICKET_SEND_DATE2(ByVal TICKET_SEND_DATE2 As String, ByRef control As TextBox)
        control.Text = TICKET_SEND_DATE2
    End Sub
    Public Shared Sub SetForm_TICKET_FLAG(ByVal TICKET_FLAG As String, ByRef control As CheckBox)
        Select Case TICKET_FLAG
            Case CmnConst.Flag.On
                control.Checked = True
            Case Else
                control.Checked = False
        End Select
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
    Public Shared Sub SetDropDownList_STATUS_TEHAI(ByRef STATUS_TEHAI As DropDownList, ByVal TBL_DR As TableDef.TBL_DR.DataStruct)
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
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelOK, AppConst.STATUS_TEHAI.Code.HotelOK))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.KotsuOK, AppConst.STATUS_TEHAI.Code.KotsuOK))
            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK))

            Select Case TBL_DR.STATUS_TEHAI
                Case AppConst.STATUS_TEHAI.Code.KotsuOK, AppConst.STATUS_TEHAI.Code.HotelOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
                     AppConst.STATUS_TEHAI.Code.OKToFuyo, AppConst.STATUS_TEHAI.Code.OkToChange, AppConst.STATUS_TEHAI.Code.OKToCancel
                    '手配完了後
                    .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.OKToFuyo, AppConst.STATUS_TEHAI.Code.OKToFuyo))
                    .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.OkToChange, AppConst.STATUS_TEHAI.Code.OkToChange))
                    .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.OKToCancel, AppConst.STATUS_TEHAI.Code.OKToCancel))
                    Select Case TBL_DR.STATUS_PAYMENT
                        Case AppConst.STATUS_PAYMENT.Code.CardEnd, AppConst.STATUS_PAYMENT.Code.BillEnd, _
                             AppConst.STATUS_PAYMENT.Code.EndToFuyo, AppConst.STATUS_PAYMENT.Code.EndToChange, AppConst.STATUS_PAYMENT.Code.EndToCancel, _
                             AppConst.STATUS_PAYMENT.Code.EndToNG
                            '入金後
                            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.EndToFuyo, AppConst.STATUS_TEHAI.Code.EndToFuyo))
                            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.EndToChange, AppConst.STATUS_TEHAI.Code.EndToChange))
                            .Items.Add(New ListItem(AppConst.STATUS_TEHAI.Name.EndToCancel, AppConst.STATUS_TEHAI.Code.EndToCancel))
                    End Select
            End Select
        End With
    End Sub

    '決済状況
    Public Shared Sub SetDropDownList_STATUS_PAYMENT(ByRef STATUS_PAYMENT As DropDownList)
        With STATUS_PAYMENT
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.Fuyo, AppConst.STATUS_PAYMENT.Code.Fuyo))
            '.Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.Input, AppConst.STATUS_PAYMENT.Code.Input))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.OK, AppConst.STATUS_PAYMENT.Code.OK))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.BillPrint, AppConst.STATUS_PAYMENT.Code.BillPrint))
            '.Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.CardEnd, AppConst.STATUS_PAYMENT.Code.CardEnd))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.BillEnd, AppConst.STATUS_PAYMENT.Code.BillEnd))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.OKToFuyo, AppConst.STATUS_PAYMENT.Code.OKToFuyo))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.OkToChange, AppConst.STATUS_PAYMENT.Code.OkToChange))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.OKToCancel, AppConst.STATUS_PAYMENT.Code.OKToCancel))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.EndToFuyo, AppConst.STATUS_PAYMENT.Code.EndToFuyo))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.EndToChange, AppConst.STATUS_PAYMENT.Code.EndToChange))
            .Items.Add(New ListItem(AppConst.STATUS_PAYMENT.Name.EndToCancel, AppConst.STATUS_PAYMENT.Code.EndToCancel))
        End With
    End Sub

    '都道府県
    Public Shared Sub SetDropDownList_PREFECTURES_NO(ByRef PREFECTURES_NO As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With PREFECTURES_NO
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_PREFECTURES.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_PREFECTURES.Column.PREFECTURES, RsData), _
                                        CmnDb.DbData(TableDef.MS_PREFECTURES.Column.PREFECTURES_NO, RsData)))
            End While
            RsData.Close()
        End With
    End Sub

    '宿泊日
    Public Shared Sub SetDropDownList_STAY_DATE(ByRef STAY_DATE As DropDownList)
        With STAY_DATE
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.STAY_DATE.Name.Before, AppConst.STAY_DATE.Code.Before))
            .Items.Add(New ListItem(AppConst.STAY_DATE.Name.Tojitsu, AppConst.STAY_DATE.Code.Tojitsu))
            .Items.Add(New ListItem(AppConst.STAY_DATE.Name.After, AppConst.STAY_DATE.Code.After))
        End With
    End Sub

    '座席希望
    Public Shared Sub SetDropDownList_O_SEAT_1(ByRef O_SEAT_1 As DropDownList)
        With O_SEAT_1
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.SEAT.Name.Window, AppConst.SEAT.Code.Window))
            .Items.Add(New ListItem(AppConst.SEAT.Name.Aisle, AppConst.SEAT.Code.Aisle))
        End With
    End Sub
    Public Shared Sub SetDropDownList_O_SEAT_2(ByRef O_SEAT_2 As DropDownList)
        SetDropDownList_O_SEAT_1(O_SEAT_2)
    End Sub
    Public Shared Sub SetDropDownList_O_SEAT_3(ByRef O_SEAT_3 As DropDownList)
        SetDropDownList_O_SEAT_1(O_SEAT_3)
    End Sub
    Public Shared Sub SetDropDownList_F_SEAT_1(ByRef F_SEAT_1 As DropDownList)
        SetDropDownList_O_SEAT_1(F_SEAT_1)
    End Sub
    Public Shared Sub SetDropDownList_F_SEAT_2(ByRef F_SEAT_2 As DropDownList)
        SetDropDownList_O_SEAT_1(F_SEAT_2)
    End Sub
    Public Shared Sub SetDropDownList_F_SEAT_3(ByRef F_SEAT_3 As DropDownList)
        SetDropDownList_O_SEAT_1(F_SEAT_3)
    End Sub

    '座席区分
    Public Shared Sub SetDropDownList_O_SEATCLASS_1(ByRef O_SEATCLASS_1 As DropDownList)
        With O_SEATCLASS_1
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.SEATCLASS.Name.Regular, AppConst.SEATCLASS.Code.Regular))
            .Items.Add(New ListItem(AppConst.SEATCLASS.Name.Premium, AppConst.SEATCLASS.Code.Premium))
            .Items.Add(New ListItem(AppConst.SEATCLASS.Name.Unreserved, AppConst.SEATCLASS.Code.Unreserved))
        End With
    End Sub
    Public Shared Sub SetDropDownList_O_SEATCLASS_2(ByRef O_SEATCLASS_2 As DropDownList)
        SetDropDownList_O_SEATCLASS_1(O_SEATCLASS_2)
    End Sub
    Public Shared Sub SetDropDownList_O_SEATCLASS_3(ByRef O_SEATCLASS_3 As DropDownList)
        SetDropDownList_O_SEATCLASS_1(O_SEATCLASS_3)
    End Sub
    Public Shared Sub SetDropDownList_F_SEATCLASS_1(ByRef F_SEATCLASS_1 As DropDownList)
        SetDropDownList_O_SEATCLASS_1(F_SEATCLASS_1)
    End Sub
    Public Shared Sub SetDropDownList_F_SEATCLASS_2(ByRef F_SEATCLASS_2 As DropDownList)
        SetDropDownList_O_SEATCLASS_1(F_SEATCLASS_2)
    End Sub
    Public Shared Sub SetDropDownList_F_SEATCLASS_3(ByRef F_SEATCLASS_3 As DropDownList)
        SetDropDownList_O_SEATCLASS_1(F_SEATCLASS_3)
    End Sub

    'チケット送付先
    Public Shared Sub SetDropDownList_SEND_SAKI(ByRef SEND_SAKI As DropDownList, ByVal UserType As String)
        With SEND_SAKI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem(AppConst.SEND_SAKI.Name.DrOffice, AppConst.SEND_SAKI.Code.DrOffice))
            .Items.Add(New ListItem(AppConst.SEND_SAKI.Name.DrHome, AppConst.SEND_SAKI.Code.DrHome))
            .Items.Add(New ListItem(AppConst.SEND_SAKI.Name.MemberOffice, AppConst.SEND_SAKI.Code.MemberOffice))
        End With
    End Sub

    '所属
    Public Shared Sub SetDropDownList_OFFICE(ByRef OFFICE As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With OFFICE
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_OFFICE.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_OFFICE.Column.OFFICE, RsData), CmnDb.DbData(TableDef.MS_OFFICE.Column.OFFICE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub

    'チェックイン日
    Public Shared Sub SetDropDownList_CHECK_IN(ByRef CHECK_IN As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With CHECK_IN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.CHECK_IN)
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_ACCOMPANY_CHECK_IN(ByRef ACCOMPANY_CHECK_IN As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        SetDropDownList_CHECK_IN(ACCOMPANY_CHECK_IN, DbConn)
    End Sub

    'チェックアウト日
    Public Shared Sub SetDropDownList_CHECK_OUT(ByRef CHECK_OUT As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With CHECK_OUT
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.CHECK_OUT)
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_ACCOMPANY_CHECK_OUT(ByRef ACCOMPANY_CHECK_OUT As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        SetDropDownList_CHECK_OUT(ACCOMPANY_CHECK_OUT, DbConn)
    End Sub

    '施設名
    Public Shared Sub SetDropDownList_SHISETSU_NAME(ByRef SHISETSU_NAME As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wStr As String

        With SHISETSU_NAME
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_SHISETSU.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                wStr = CmnDb.DbData(TableDef.MS_SHISETSU.Column.DATA_ID, RsData) & "|" & CmnDb.DbData(TableDef.MS_SHISETSU.Column.MEMBER_ID, RsData) & "|" & CmnDb.DbData(TableDef.MS_SHISETSU.Column.SHISETSU_NAME, RsData)
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_SHISETSU.Column.SHISETSU_NAME, RsData), wStr))
            End While
            RsData.Close()
        End With
    End Sub

    '乗車・搭乗日: 往路
    Public Shared Sub SetDropDownList_O_DATE_1(ByRef O_DATE_1 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With O_DATE_1
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.O_DATE)
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_O_DATE_2(ByRef O_DATE_2 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        SetDropDownList_O_DATE_1(O_DATE_2, DbConn)
    End Sub
    Public Shared Sub SetDropDownList_O_DATE_3(ByRef O_DATE_3 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        SetDropDownList_O_DATE_1(O_DATE_3, DbConn)
    End Sub

    '乗車・搭乗日: 復路
    Public Shared Sub SetDropDownList_F_DATE_1(ByRef F_DATE_1 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With F_DATE_1
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.F_DATE)
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_F_DATE_2(ByRef F_DATE_2 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        SetDropDownList_F_DATE_1(F_DATE_2, DbConn)
    End Sub
    Public Shared Sub SetDropDownList_F_DATE_3(ByRef F_DATE_3 As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        SetDropDownList_F_DATE_1(F_DATE_3, DbConn)
    End Sub

    '宿泊確認書
    Public Shared Sub SetDropDownList_MS_HOTELPRINT_SHIHARAI(ByRef MS_HOTELPRINT_SHIHARAI As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With MS_HOTELPRINT_SHIHARAI
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_HOTELPRINT_SHIHARAI.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_HOTELPRINT_SHIHARAI.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_HOTELPRINT_SHIHARAI.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_MS_HOTELPRINT_RENRAKU(ByRef MS_HOTELPRINT_RENRAKU As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With MS_HOTELPRINT_RENRAKU
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_HOTELPRINT_RENRAKU.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_HOTELPRINT_RENRAKU.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_HOTELPRINT_RENRAKU.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_MS_HOTELPRINT_CHECKIN(ByRef MS_HOTELPRINT_CHECKIN As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With MS_HOTELPRINT_CHECKIN
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_HOTELPRINT_CHECKIN.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_HOTELPRINT_CHECKIN.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_HOTELPRINT_CHECKIN.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_MS_HOTELPRINT_ACCOMPANY(ByRef MS_HOTELPRINT_ACCOMPANY As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With MS_HOTELPRINT_ACCOMPANY
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_HOTELPRINT_ACCOMPANY.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_HOTELPRINT_ACCOMPANY.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_HOTELPRINT_ACCOMPANY.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub
    Public Shared Sub SetDropDownList_MS_HOTELPRINT_BREAKFAST(ByRef MS_HOTELPRINT_BREAKFAST As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With MS_HOTELPRINT_BREAKFAST
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_HOTELPRINT_BREAKFAST.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_HOTELPRINT_BREAKFAST.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_HOTELPRINT_BREAKFAST.Column.DISP_VALUE, RsData)))
            End While
            RsData.Close()
        End With
    End Sub

    'ホテル
    Public Shared Sub SetDropDownList_MS_HOTEL(ByRef MS_HOTEL As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        With MS_HOTEL
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_HOTEL.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_HOTEL.Column.HOTEL_NAME, RsData), CmnDb.DbData(TableDef.MS_HOTEL.Column.DATA_ID, RsData)))
            End While
            RsData.Close()
        End With
    End Sub

    '部屋タイプ
    Public Shared Sub SetDropDownList_ROOM_TYPE(ByRef ROOM_TYPE As DropDownList, ByVal HOTEL_NAME As String, ByVal DbConn As System.Data.SqlClient.SqlConnection)
        Dim strSQL As String
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        With ROOM_TYPE
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            strSQL = SQL.MS_ROOM_TYPE.byHOTEL_NAME(HOTEL_NAME)
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                wFlag = True
                .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_ROOM_TYPE.Column.ROOM_TYPE, RsData), CmnDb.DbData(TableDef.MS_ROOM_TYPE.Column.DATA_ID, RsData)))
            End While
            RsData.Close()

            If wFlag = False Then
                '該当部屋タイプがない→コードマスタから汎用的なものを設定
                strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.ROOM_TYPE)
                RsData = CmnDb.Read(strSQL, DbConn)
                While RsData.Read()
                    wFlag = True
                    .Items.Add(New ListItem(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData), CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)))
                End While
                RsData.Close()
            End If
        End With
    End Sub

    '有効期限(年)
    Public Shared Sub SetDropDownList_KIGEN_YYYY(ByRef KIGEN_YYYY As DropDownList)
        With KIGEN_YYYY
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem("2013", "2013"))
            .Items.Add(New ListItem("2014", "2014"))
            .Items.Add(New ListItem("2015", "2015"))
            .Items.Add(New ListItem("2016", "2016"))
            .Items.Add(New ListItem("2017", "2017"))
            .Items.Add(New ListItem("2018", "2018"))
            .Items.Add(New ListItem("2019", "2019"))
            .Items.Add(New ListItem("2020", "2020"))
            .Items.Add(New ListItem("2021", "2021"))
            .Items.Add(New ListItem("2022", "2022"))
            .Items.Add(New ListItem("2023", "2023"))
        End With
    End Sub

    '有効期限(月)
    Public Shared Sub SetDropDownList_KIGEN_MM(ByRef KIGEN_MM As DropDownList)
        With KIGEN_MM
            .Items.Clear()
            .Items.Add(New ListItem("---", "0"))

            .Items.Add(New ListItem("01", "01"))
            .Items.Add(New ListItem("02", "02"))
            .Items.Add(New ListItem("03", "03"))
            .Items.Add(New ListItem("04", "04"))
            .Items.Add(New ListItem("05", "05"))
            .Items.Add(New ListItem("06", "06"))
            .Items.Add(New ListItem("07", "07"))
            .Items.Add(New ListItem("08", "08"))
            .Items.Add(New ListItem("09", "09"))
            .Items.Add(New ListItem("10", "10"))
            .Items.Add(New ListItem("11", "11"))
            .Items.Add(New ListItem("12", "12"))
        End With
    End Sub


    '== コントロールからDB用の値を返す ==
    'ログインID
    Public Shared Function GetValue_MEMBER_ID(ByVal MEMBER_ID As TextBox) As String
        Return Trim(StrConv(MEMBER_ID.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_DR_ID(ByVal DR_ID As TextBox) As String
        Return Trim(StrConv(DR_ID.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_MEMBER_ID(ByVal SHISETSU_NAME As DropDownList) As String
        Dim wStr As String = CmnModule.GetSelectedItemValue(SHISETSU_NAME)
        Dim wSplit() As String
        If InStr(wStr, "|") > 0 Then
            wSplit = Split(wStr, "|")
            wStr = wSplit(1)
        End If
        Return wStr
    End Function
    Public Shared Function GetValue_MEMBER_ID(ByVal MEMBER_ID As HiddenField) As String
        Return Trim(StrConv(MEMBER_ID.Value, VbStrConv.Narrow))
    End Function

    'パスワード
    Public Shared Function GetValue_MEMBER_PW(ByVal MEMBER_PW As TextBox) As String
        Return Trim(StrConv(MEMBER_PW.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_DR_PW(ByVal DR_PW As TextBox) As String
        Return Trim(StrConv(DR_PW.Text, VbStrConv.Narrow))
    End Function

    '施設マスタ 番号
    Public Shared Function GetValue_DATA_ID(ByVal DATA_ID As HiddenField) As String
        Return Trim(StrConv(DATA_ID.Value, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_DATA_ID(ByVal SHISETSU_NAME As DropDownList) As String
        Dim wStr As String = CmnModule.GetSelectedItemValue(SHISETSU_NAME)
        Dim wSplit() As String
        If InStr(wStr, "|") > 0 Then
            wSplit = Split(wStr, "|")
            wStr = wSplit(0)
        End If
        Return wStr
    End Function

    '登録番号
    Public Shared Function GetValue_DATA_NO(ByVal DATA_NO As TextBox) As String
        Return Trim(StrConv(DATA_NO.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_DATA_NO(ByVal DATA_NO As Label) As String
        Return Trim(StrConv(DATA_NO.Text, VbStrConv.Narrow))
    End Function

    '氏名(漢字)
    Public Shared Function GetValue_DR_NAME_FIRST(ByVal DR_NAME_FIRST As TextBox) As String
        Return Trim(StrConv(DR_NAME_FIRST.Text, VbStrConv.Wide))
    End Function
    Public Shared Function GetValue_DR_NAME_LAST(ByVal DR_NAME_LAST As TextBox) As String
        Return Trim(StrConv(DR_NAME_LAST.Text, VbStrConv.Wide))
    End Function
    Public Shared Function GetValue_DR_NAME(ByVal DR_NAME As TextBox) As String
        Return Trim(StrConv(DR_NAME.Text, VbStrConv.Wide))
    End Function
    Public Shared Function GetValue_MEMBER_NAME_FIRST(ByVal MEMBER_NAME_FIRST As TextBox) As String
        Return Trim(StrConv(MEMBER_NAME_FIRST.Text, VbStrConv.Wide))
    End Function
    Public Shared Function GetValue_MEMBER_NAME_LAST(ByVal MEMBER_NAME_LAST As TextBox) As String
        Return Trim(StrConv(MEMBER_NAME_LAST.Text, VbStrConv.Wide))
    End Function
    Public Shared Function GetValue_MEMBER_NAME(ByVal MEMBER_NAME As TextBox) As String
        Return Trim(StrConv(MEMBER_NAME.Text, VbStrConv.Wide))
    End Function
    Public Shared Function GetValue_MEMBER_NAME(ByVal MEMBER_NAME As Label) As String
        Return Trim(StrConv(MEMBER_NAME.Text, VbStrConv.Wide))
    End Function

    '氏名(カナ)
    Public Shared Function GetValue_DR_NAME_KANA_FIRST(ByVal DR_NAME_KANA_FIRST As TextBox) As String
        Return Trim(StrConv(DR_NAME_KANA_FIRST.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function
    Public Shared Function GetValue_DR_NAME_KANA_LAST(ByVal DR_NAME_KANA_LAST As TextBox) As String
        Return Trim(StrConv(DR_NAME_KANA_LAST.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function
    Public Shared Function GetValue_DR_NAME_KANA(ByVal DR_NAME_KANA As TextBox) As String
        Return Trim(StrConv(DR_NAME_KANA.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function
    Public Shared Function GetValue_MEMBER_NAME_KANA_FIRST(ByVal MEMBER_NAME_KANA_FIRST As TextBox) As String
        Return Trim(StrConv(MEMBER_NAME_KANA_FIRST.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function
    Public Shared Function GetValue_MEMBER_NAME_KANA_LAST(ByVal MEMBER_NAME_KANA_LAST As TextBox) As String
        Return Trim(StrConv(MEMBER_NAME_KANA_LAST.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function
    Public Shared Function GetValue_MEMBER_NAME_KANA(ByVal MEMBER_NAME_KANA As TextBox) As String
        Return Trim(StrConv(MEMBER_NAME_KANA.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function

    'メールアドレス
    Public Shared Function GetValue_PC_MAIL(ByVal PC_MAIL As TextBox, Optional ByVal Full As Boolean = False) As String
        If Full = False Then
            Return Trim(StrConv(PC_MAIL.Text, VbStrConv.Narrow)) & System.Configuration.ConfigurationManager.AppSettings("DomainPC")
        Else
            Return Trim(StrConv(PC_MAIL.Text, VbStrConv.Narrow))
        End If
    End Function
    Public Shared Function GetValue_DR_MAIL(ByVal DR_MAIL As TextBox) As String
        Return Trim(StrConv(DR_MAIL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_DR_MAIL(ByVal DR_MAIL As Label) As String
        Return Trim(StrConv(DR_MAIL.Text, VbStrConv.Narrow))
    End Function

    '携帯メールアドレス
    Public Shared Function GetValue_KEITAI_MAIL(ByVal KEITAI_MAIL As TextBox) As String
        Return Trim(StrConv(KEITAI_MAIL.Text, VbStrConv.Narrow)) & System.Configuration.ConfigurationManager.AppSettings("DomainKeitai")
    End Function

    '所属
    Public Shared Function GetValue_OFFICE(ByVal OFFICE As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(OFFICE)
    End Function
    Public Shared Function GetValue_OFFICE(ByVal OFFICE As Label) As String
        Return Trim(OFFICE.Text)
    End Function

    '来場
    Public Shared Function GetValue_ATTEND(ByVal ATTEND_Yes As RadioButton, ByVal ATTEND_No As RadioButton, ByVal ATTEND_Mi As RadioButton) As String
        If ATTEND_Yes.Checked = True Then
            Return AppConst.ATTEND.Code.Yes
        ElseIf ATTEND_No.Checked = True Then
            Return AppConst.ATTEND.Code.No
        ElseIf ATTEND_Mi.Checked = True Then
            Return AppConst.ATTEND.Code.Mi
        Else
            Return ""
        End If
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

    '都道府県
    Public Shared Function GetValue_PREFECTURES_NO(ByVal PREFECTURES_NO As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(PREFECTURES_NO)
    End Function

    '施設・病院名称
    Public Shared Function GetValue_SHISETSU_NAME(ByVal SHISETSU_NAME As TextBox) As String
        Return Trim(SHISETSU_NAME.Text)
    End Function
    Public Shared Function GetValue_SHISETSU_NAME(ByVal SHISETSU_NAME As Label) As String
        Return Trim(SHISETSU_NAME.Text)
    End Function
    Public Shared Function GetValue_SHISETSU_NAME_KANA(ByVal SHISETSU_NAME_KANA As TextBox) As String
        Return Trim(StrConv(SHISETSU_NAME_KANA.Text, VbStrConv.Wide Or VbStrConv.Katakana))
    End Function
    Public Shared Function GetValue_SHISETSU_NAME(ByVal SHISETSU_NAME As DropDownList) As String
        Dim wStr As String = CmnModule.GetSelectedItemValue(SHISETSU_NAME)
        Dim wSplit() As String
        If InStr(wStr, "|") > 0 Then
            wSplit = Split(wStr, "|")
            wStr = wSplit(2)
        End If
        Return wStr
    End Function

    '診療科
    Public Shared Function GetValue_KAMOKU(ByVal KAMOKU As TextBox) As String
        Return Trim(KAMOKU.Text)
    End Function

    '役職
    Public Shared Function GetValue_YAKUSHOKU(ByVal YAKUSHOKU As TextBox) As String
        Return Trim(YAKUSHOKU.Text)
    End Function

    '情報交換会
    Public Shared Function GetValue_PARTY(ByVal PARTY_Yes As RadioButton, ByVal PARTY_No As RadioButton) As String
        If PARTY_Yes.Checked = True Then
            Return AppConst.PARTY.Code.Yes
        ElseIf PARTY_No.Checked = True Then
            Return AppConst.PARTY.Code.No
        Else
            Return ""
        End If
    End Function

    '公務員
    Public Shared Function GetValue_PUBLIC_SERVANT(ByVal PUBLIC_SERVANT_Yes As RadioButton, ByVal PUBLIC_SERVANT_No As RadioButton) As String
        If PUBLIC_SERVANT_Yes.Checked = True Then
            Return AppConst.PUBLIC_SERVANT.Code.Yes
        ElseIf PUBLIC_SERVANT_No.Checked = True Then
            Return AppConst.PUBLIC_SERVANT.Code.No
        Else
            Return ""
        End If
    End Function

    '二次使用
    Public Shared Function GetValue_SECANDARY_USE(ByVal SECANDARY_USE_Yes As RadioButton, ByVal SECANDARY_USE_No As RadioButton) As String
        If SECANDARY_USE_Yes.Checked = True Then
            Return AppConst.SECANDARY_USE.Code.Yes
        ElseIf SECANDARY_USE_No.Checked = True Then
            Return AppConst.SECANDARY_USE.Code.No
        Else
            Return ""
        End If
    End Function

    'ウェットラボ
    Public Shared Function GetValue_WETLAB_FLAG(ByVal WETLAB_FLAG_Yes As RadioButton, ByVal WETLAB_FLAG_No As RadioButton) As String
        If WETLAB_FLAG_Yes.Checked = True Then
            Return AppConst.WETLAB_FLAG.Code.Yes
        ElseIf WETLAB_FLAG_No.Checked = True Then
            Return AppConst.WETLAB_FLAG.Code.No
        Else
            Return ""
        End If
    End Function

    'ウェットラボ コース
    Public Shared Function GetValue_WETLAB_COURSE(ByVal WETLAB_FLAG As String, ByVal WETLAB_COURSE_A As RadioButton, ByVal WETLAB_COURSE_B As RadioButton) As String
        If WETLAB_FLAG = AppConst.WETLAB_FLAG.Code.Yes Then
            If WETLAB_COURSE_A.Checked = True Then
                Return AppConst.WETLAB_COURSE.Code.A
            ElseIf WETLAB_COURSE_B.Checked = True Then
                Return AppConst.WETLAB_COURSE.Code.B
            Else
                Return ""
            End If
        Else
            Return ""
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

    '宿泊日
    Public Shared Function GetValue_STAY_DATE(ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal STAY_DATE_Before As RadioButton, ByVal STAY_DATE_BeforeTojitsu As RadioButton, ByVal STAY_DATE_Tojitsu As RadioButton, ByVal STAY_DATE_TojitsuAfter As RadioButton, ByVal STAY_DATE_After As RadioButton) As String
        If TEHAI_HOTEL_Yes.Checked = True Then
            If STAY_DATE_Before.Checked = True Then
                Return AppConst.STAY_DATE.Code.Before
            ElseIf STAY_DATE_BeforeTojitsu.Checked = True Then
                Return AppConst.STAY_DATE.Code.BeforeTojitsu
            ElseIf STAY_DATE_Tojitsu.Checked = True Then
                Return AppConst.STAY_DATE.Code.Tojitsu
            ElseIf STAY_DATE_TojitsuAfter.Checked = True Then
                Return AppConst.STAY_DATE.Code.TojitsuAfter
            ElseIf STAY_DATE_After.Checked = True Then
                Return AppConst.STAY_DATE.Code.After
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function

    'チェックイン日
    'Public Shared Function GetValue_CHECK_IN(ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal STAY_DATE_Before As RadioButton, ByVal STAY_DATE_BeforeTojitsu As RadioButton, ByVal STAY_DATE_Tojitsu As RadioButton, ByVal STAY_DATE_TojitsuAfter As RadioButton, ByVal STAY_DATE_After As RadioButton) As String
    '    If TEHAI_HOTEL_Yes.Checked = True Then
    '        If STAY_DATE_Before.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_IN.Before
    '        ElseIf STAY_DATE_BeforeTojitsu.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_IN.BeforeTojitsu
    '        ElseIf STAY_DATE_Tojitsu.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_IN.Tojitsu
    '        ElseIf STAY_DATE_TojitsuAfter.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_IN.TojitsuAfter
    '        ElseIf STAY_DATE_After.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_IN.After
    '        Else
    '            Return ""
    '        End If
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Public Shared Function GetValue_CHECK_IN(ByVal CHECK_IN As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(CHECK_IN)
    'End Function
    Public Shared Function GetValue_CHECK_IN(ByVal TEHAI_HOTEL_Yes As RadioButton) As String
        If TEHAI_HOTEL_Yes.Checked = True Then
            Return AppConst.HOTEL.CHECK_IN
        Else
            Return ""
        End If
    End Function

    'チェックアウト日
    'Public Shared Function GetValue_CHECK_OUT(ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal STAY_DATE_Before As RadioButton, ByVal STAY_DATE_BeforeTojitsu As RadioButton, ByVal STAY_DATE_Tojitsu As RadioButton, ByVal STAY_DATE_TojitsuAfter As RadioButton, ByVal STAY_DATE_After As RadioButton) As String
    '    If TEHAI_HOTEL_Yes.Checked = True Then
    '        If STAY_DATE_Before.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_OUT.Before
    '        ElseIf STAY_DATE_BeforeTojitsu.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_OUT.BeforeTojitsu
    '        ElseIf STAY_DATE_Tojitsu.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_OUT.Tojitsu
    '        ElseIf STAY_DATE_TojitsuAfter.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_OUT.TojitsuAfter
    '        ElseIf STAY_DATE_After.Checked = True Then
    '            Return AppConst.STAY_DATE.CHECK_OUT.After
    '        Else
    '            Return ""
    '        End If
    '    Else
    '        Return ""
    '    End If
    'End Function
    'Public Shared Function GetValue_CHECK_OUT(ByVal CHECK_OUT As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(CHECK_OUT)
    'End Function
    Public Shared Function GetValue_CHECK_OUT(ByVal TEHAI_HOTEL_Yes As RadioButton) As String
        If TEHAI_HOTEL_Yes.Checked = True Then
            Return AppConst.HOTEL.CHECK_OUT
        Else
            Return ""
        End If
    End Function

    'おたばこ
    Public Shared Function GetValue_HOTEL_SMOKING(ByVal HOTEL_SMOKING_No As RadioButton, ByVal HOTEL_SMOKING_Yes As RadioButton) As String
        If HOTEL_SMOKING_No.Checked = True Then
            Return AppConst.HOTEL_SMOKING.Code.No
        ElseIf HOTEL_SMOKING_Yes.Checked = True Then
            Return AppConst.HOTEL_SMOKING.Code.Yes
        Else
            Return ""
        End If
    End Function

    '宿泊備考欄
    Public Shared Function GetValue_NOTE_HOTEL(ByVal NOTE_HOTEL As TextBox) As String
        Return Trim(NOTE_HOTEL.Text)
    End Function

    '参加区分
    Public Shared Function GetValue_SANKA_KUBUN(ByVal SANKA_KUBUN_Listener As RadioButton, ByVal SANKA_KUBUN_Speaker As RadioButton) As String
        If SANKA_KUBUN_Listener.Checked = True Then
            Return AppConst.SANKA_KUBUN.Code.Listener
        ElseIf SANKA_KUBUN_Speaker.Checked = True Then
            Return AppConst.SANKA_KUBUN.Code.Speaker
        Else
            Return ""
        End If
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

    '航空便/JR
    Public Shared Function GetValue_O_KOTSU_KUBUN_1(ByVal O_KOTSU_KUBUN_1_AIR As RadioButton, ByVal O_KOTSU_KUBUN_1_JR As RadioButton, ByVal O_KOTSU_KUBUN_1_None As RadioButton) As String
        If O_KOTSU_KUBUN_1_AIR.Checked = True Then
            Return AppConst.KOTSU_KUBUN.Code.AIR
        ElseIf O_KOTSU_KUBUN_1_JR.Checked = True Then
            Return AppConst.KOTSU_KUBUN.Code.JR
        Else
            Return AppConst.KOTSU_KUBUN.Code.None
        End If
    End Function
    Public Shared Function GetValue_O_KOTSU_KUBUN_2(ByVal O_KOTSU_KUBUN_2_AIR As RadioButton, ByVal O_KOTSU_KUBUN_2_JR As RadioButton, ByVal O_KOTSU_KUBUN_2_None As RadioButton) As String
        Return GetValue_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_2_AIR, O_KOTSU_KUBUN_2_JR, O_KOTSU_KUBUN_2_None)
    End Function
    Public Shared Function GetValue_O_KOTSU_KUBUN_3(ByVal O_KOTSU_KUBUN_3_AIR As RadioButton, ByVal O_KOTSU_KUBUN_3_JR As RadioButton, ByVal O_KOTSU_KUBUN_3_None As RadioButton) As String
        Return GetValue_O_KOTSU_KUBUN_1(O_KOTSU_KUBUN_3_AIR, O_KOTSU_KUBUN_3_JR, O_KOTSU_KUBUN_3_None)
    End Function
    Public Shared Function GetValue_F_KOTSU_KUBUN_1(ByVal F_KOTSU_KUBUN_1_AIR As RadioButton, ByVal F_KOTSU_KUBUN_1_JR As RadioButton, ByVal F_KOTSU_KUBUN_1_None As RadioButton) As String
        Return GetValue_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_1_AIR, F_KOTSU_KUBUN_1_JR, F_KOTSU_KUBUN_1_None)
    End Function
    Public Shared Function GetValue_F_KOTSU_KUBUN_2(ByVal F_KOTSU_KUBUN_2_AIR As RadioButton, ByVal F_KOTSU_KUBUN_2_JR As RadioButton, ByVal F_KOTSU_KUBUN_2_None As RadioButton) As String
        Return GetValue_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_2_AIR, F_KOTSU_KUBUN_2_JR, F_KOTSU_KUBUN_2_None)
    End Function
    Public Shared Function GetValue_F_KOTSU_KUBUN_3(ByVal F_KOTSU_KUBUN_3_AIR As RadioButton, ByVal F_KOTSU_KUBUN_3_JR As RadioButton, ByVal F_KOTSU_KUBUN_3_None As RadioButton) As String
        Return GetValue_O_KOTSU_KUBUN_1(F_KOTSU_KUBUN_3_AIR, F_KOTSU_KUBUN_3_JR, F_KOTSU_KUBUN_3_None)
    End Function

    '乗車・搭乗日
    Public Shared Function GetValue_O_DATE_1(ByVal O_DATE_1 As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(O_DATE_1)
    End Function
    Public Shared Function GetValue_O_DATE_2(ByVal O_DATE_2 As DropDownList) As String
        Return GetValue_O_DATE_1(O_DATE_2)
    End Function
    Public Shared Function GetValue_O_DATE_3(ByVal O_DATE_3 As DropDownList) As String
        Return GetValue_O_DATE_1(O_DATE_3)
    End Function
    Public Shared Function GetValue_F_DATE_1(ByVal F_DATE_1 As DropDownList) As String
        Return GetValue_O_DATE_1(F_DATE_1)
    End Function
    Public Shared Function GetValue_F_DATE_2(ByVal F_DATE_2 As DropDownList) As String
        Return GetValue_O_DATE_1(F_DATE_2)
    End Function
    Public Shared Function GetValue_F_DATE_3(ByVal F_DATE_3 As DropDownList) As String
        Return GetValue_O_DATE_1(F_DATE_3)
    End Function

    '区間
    Public Shared Function GetValue_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As TextBox) As String
        Return Trim(O_AIRPORT1_1.Text)
    End Function
    Public Shared Function GetValue_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT2_1)
    End Function
    Public Shared Function GetValue_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT1_2)
    End Function
    Public Shared Function GetValue_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT2_2)
    End Function
    Public Shared Function GetValue_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT1_3)
    End Function
    Public Shared Function GetValue_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT2_3)
    End Function
    Public Shared Function GetValue_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT1_1)
    End Function
    Public Shared Function GetValue_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT2_1)
    End Function
    Public Shared Function GetValue_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT1_2)
    End Function
    Public Shared Function GetValue_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT2_2)
    End Function
    Public Shared Function GetValue_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT1_3)
    End Function
    Public Shared Function GetValue_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As TextBox) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT2_3)
    End Function
    Public Shared Function GetValue_O_AIRPORT1_1(ByVal O_AIRPORT1_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
        If O_KOTSU_KUBUN_1_AIR.Enabled = True AndAlso O_KOTSU_KUBUN_1_AIR.Checked = True Then
            Return Trim(O_AIRPORT1_1.Text)
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_O_AIRPORT2_1(ByVal O_AIRPORT2_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT2_1, O_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_O_AIRPORT1_2(ByVal O_AIRPORT1_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT1_2, O_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_O_AIRPORT2_2(ByVal O_AIRPORT2_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT2_2, O_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_O_AIRPORT1_3(ByVal O_AIRPORT1_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT1_3, O_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_O_AIRPORT2_3(ByVal O_AIRPORT2_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(O_AIRPORT2_3, O_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_F_AIRPORT1_1(ByVal F_AIRPORT1_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT1_1, F_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_F_AIRPORT2_1(ByVal F_AIRPORT2_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT2_1, F_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_F_AIRPORT1_2(ByVal F_AIRPORT1_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT1_2, F_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_F_AIRPORT2_2(ByVal F_AIRPORT2_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT2_2, F_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_F_AIRPORT1_3(ByVal F_AIRPORT1_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT1_3, F_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_F_AIRPORT2_3(ByVal F_AIRPORT2_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_AIRPORT1_1(F_AIRPORT2_3, F_KOTSU_KUBUN_3_AIR)
    End Function

    '新幹線・特急区間
    Public Shared Function GetValue_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As TextBox) As String
        Return Trim(O_EXPRESS1_1.Text)
    End Function
    Public Shared Function GetValue_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS2_1)
    End Function
    Public Shared Function GetValue_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS1_2)
    End Function
    Public Shared Function GetValue_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS2_2)
    End Function
    Public Shared Function GetValue_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS1_3)
    End Function
    Public Shared Function GetValue_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS2_3)
    End Function
    Public Shared Function GetValue_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS1_1)
    End Function
    Public Shared Function GetValue_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS2_1)
    End Function
    Public Shared Function GetValue_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS1_2)
    End Function
    Public Shared Function GetValue_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS2_2)
    End Function
    Public Shared Function GetValue_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS1_3)
    End Function
    Public Shared Function GetValue_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As TextBox) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS2_3)
    End Function
    Public Shared Function GetValue_O_EXPRESS1_1(ByVal O_EXPRESS1_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
        If O_KOTSU_KUBUN_1_AIR.Enabled = True AndAlso O_KOTSU_KUBUN_1_AIR.Checked = True Then
            Return Trim(O_EXPRESS1_1.Text)
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_O_EXPRESS2_1(ByVal O_EXPRESS2_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS2_1, O_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_O_EXPRESS1_2(ByVal O_EXPRESS1_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS1_2, O_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_O_EXPRESS2_2(ByVal O_EXPRESS2_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS2_2, O_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_O_EXPRESS1_3(ByVal O_EXPRESS1_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS1_3, O_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_O_EXPRESS2_3(ByVal O_EXPRESS2_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(O_EXPRESS2_3, O_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_F_EXPRESS1_1(ByVal F_EXPRESS1_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS1_1, F_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_F_EXPRESS2_1(ByVal F_EXPRESS2_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS2_1, F_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_F_EXPRESS1_2(ByVal F_EXPRESS1_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS1_2, F_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_F_EXPRESS2_2(ByVal F_EXPRESS2_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS2_2, F_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_F_EXPRESS1_3(ByVal F_EXPRESS1_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS1_3, F_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_F_EXPRESS2_3(ByVal F_EXPRESS2_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_EXPRESS1_1(F_EXPRESS2_3, F_KOTSU_KUBUN_3_AIR)
    End Function

    '乗車券区間
    Public Shared Function GetValue_O_LOCAL1_1(ByVal O_LOCAL1_1 As TextBox) As String
        Return Trim(O_LOCAL1_1.Text)
    End Function
    Public Shared Function GetValue_O_LOCAL2_1(ByVal O_LOCAL2_1 As TextBox) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL2_1)
    End Function
    Public Shared Function GetValue_O_LOCAL1_2(ByVal O_LOCAL1_2 As TextBox) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL1_2)
    End Function
    Public Shared Function GetValue_O_LOCAL2_2(ByVal O_LOCAL2_2 As TextBox) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL2_2)
    End Function
    Public Shared Function GetValue_O_LOCAL1_3(ByVal O_LOCAL1_3 As TextBox) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL1_3)
    End Function
    Public Shared Function GetValue_O_LOCAL2_3(ByVal O_LOCAL2_3 As TextBox) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL2_3)
    End Function
    Public Shared Function GetValue_F_LOCAL1_1(ByVal F_LOCAL1_1 As TextBox) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL1_1)
    End Function
    Public Shared Function GetValue_F_LOCAL2_1(ByVal F_LOCAL2_1 As TextBox) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL2_1)
    End Function
    Public Shared Function GetValue_F_LOCAL1_2(ByVal F_LOCAL1_2 As TextBox) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL1_2)
    End Function
    Public Shared Function GetValue_F_LOCAL2_2(ByVal F_LOCAL2_2 As TextBox) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL2_2)
    End Function
    Public Shared Function GetValue_F_LOCAL1_3(ByVal F_LOCAL1_3 As TextBox) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL1_3)
    End Function
    Public Shared Function GetValue_F_LOCAL2_3(ByVal F_LOCAL2_3 As TextBox) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL2_3)
    End Function
    Public Shared Function GetValue_O_LOCAL1_1(ByVal O_LOCAL1_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
        If O_KOTSU_KUBUN_1_AIR.Enabled = True AndAlso O_KOTSU_KUBUN_1_AIR.Checked = True Then
            Return Trim(O_LOCAL1_1.Text)
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_O_LOCAL2_1(ByVal O_LOCAL2_1 As TextBox, ByVal O_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL2_1, O_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_O_LOCAL1_2(ByVal O_LOCAL1_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL1_2, O_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_O_LOCAL2_2(ByVal O_LOCAL2_2 As TextBox, ByVal O_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL2_2, O_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_O_LOCAL1_3(ByVal O_LOCAL1_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL1_3, O_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_O_LOCAL2_3(ByVal O_LOCAL2_3 As TextBox, ByVal O_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(O_LOCAL2_3, O_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_F_LOCAL1_1(ByVal F_LOCAL1_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL1_1, F_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_F_LOCAL2_1(ByVal F_LOCAL2_1 As TextBox, ByVal F_KOTSU_KUBUN_1_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL2_1, F_KOTSU_KUBUN_1_AIR)
    End Function
    Public Shared Function GetValue_F_LOCAL1_2(ByVal F_LOCAL1_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL1_2, F_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_F_LOCAL2_2(ByVal F_LOCAL2_2 As TextBox, ByVal F_KOTSU_KUBUN_2_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL2_2, F_KOTSU_KUBUN_2_AIR)
    End Function
    Public Shared Function GetValue_F_LOCAL1_3(ByVal F_LOCAL1_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL1_3, F_KOTSU_KUBUN_3_AIR)
    End Function
    Public Shared Function GetValue_F_LOCAL2_3(ByVal F_LOCAL2_3 As TextBox, ByVal F_KOTSU_KUBUN_3_AIR As RadioButton) As String
        Return GetValue_O_LOCAL1_1(F_LOCAL2_3, F_KOTSU_KUBUN_3_AIR)
    End Function

    '時間
    Public Shared Function GetValue_O_TIME1_1(ByVal O_TIME1_1 As TextBox) As String
        Return Trim(StrConv(O_TIME1_1.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_O_TIME2_1(ByVal O_TIME2_1 As TextBox) As String
        Return GetValue_O_TIME1_1(O_TIME2_1)
    End Function
    Public Shared Function GetValue_O_TIME1_2(ByVal O_TIME1_2 As TextBox) As String
        Return GetValue_O_TIME1_1(O_TIME1_2)
    End Function
    Public Shared Function GetValue_O_TIME2_2(ByVal O_TIME2_2 As TextBox) As String
        Return GetValue_O_TIME1_1(O_TIME2_2)
    End Function
    Public Shared Function GetValue_O_TIME1_3(ByVal O_TIME1_3 As TextBox) As String
        Return GetValue_O_TIME1_1(O_TIME1_3)
    End Function
    Public Shared Function GetValue_O_TIME2_3(ByVal O_TIME2_3 As TextBox) As String
        Return GetValue_O_TIME1_1(O_TIME2_3)
    End Function
    Public Shared Function GetValue_F_TIME1_1(ByVal F_TIME1_1 As TextBox) As String
        Return GetValue_O_TIME1_1(F_TIME1_1)
    End Function
    Public Shared Function GetValue_F_TIME2_1(ByVal F_TIME2_1 As TextBox) As String
        Return GetValue_O_TIME1_1(F_TIME2_1)
    End Function
    Public Shared Function GetValue_F_TIME1_2(ByVal F_TIME1_2 As TextBox) As String
        Return GetValue_O_TIME1_1(F_TIME1_2)
    End Function
    Public Shared Function GetValue_F_TIME2_2(ByVal F_TIME2_2 As TextBox) As String
        Return GetValue_O_TIME1_1(F_TIME2_2)
    End Function
    Public Shared Function GetValue_F_TIME1_3(ByVal F_TIME1_3 As TextBox) As String
        Return GetValue_O_TIME1_1(F_TIME1_3)
    End Function
    Public Shared Function GetValue_F_TIME2_3(ByVal F_TIME2_3 As TextBox) As String
        Return GetValue_O_TIME1_1(F_TIME2_3)
    End Function

    '便名
    Public Shared Function GetValue_O_BIN_1(ByVal O_BIN_1 As TextBox) As String
        Return Trim(O_BIN_1.Text)
    End Function
    Public Shared Function GetValue_O_BIN_2(ByVal O_BIN_2 As TextBox) As String
        Return GetValue_O_BIN_1(O_BIN_2)
    End Function
    Public Shared Function GetValue_O_BIN_3(ByVal O_BIN_3 As TextBox) As String
        Return GetValue_O_BIN_1(O_BIN_3)
    End Function
    Public Shared Function GetValue_F_BIN_1(ByVal F_BIN_1 As TextBox) As String
        Return GetValue_O_BIN_1(F_BIN_1)
    End Function
    Public Shared Function GetValue_F_BIN_2(ByVal F_BIN_2 As TextBox) As String
        Return GetValue_O_BIN_1(F_BIN_2)
    End Function
    Public Shared Function GetValue_F_BIN_3(ByVal F_BIN_3 As TextBox) As String
        Return GetValue_O_BIN_1(F_BIN_3)
    End Function

    '座席希望
    Public Shared Function GetValue_O_SEAT_1(ByVal O_SEAT_1 As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(O_SEAT_1)
    End Function
    Public Shared Function GetValue_O_SEAT_2(ByVal O_SEAT_2 As DropDownList) As String
        Return GetValue_O_SEAT_1(O_SEAT_2)
    End Function
    Public Shared Function GetValue_O_SEAT_3(ByVal O_SEAT_3 As DropDownList) As String
        Return GetValue_O_SEAT_1(O_SEAT_3)
    End Function
    Public Shared Function GetValue_F_SEAT_1(ByVal F_SEAT_1 As DropDownList) As String
        Return GetValue_O_SEAT_1(F_SEAT_1)
    End Function
    Public Shared Function GetValue_F_SEAT_2(ByVal F_SEAT_2 As DropDownList) As String
        Return GetValue_O_SEAT_1(F_SEAT_2)
    End Function
    Public Shared Function GetValue_F_SEAT_3(ByVal F_SEAT_3 As DropDownList) As String
        Return GetValue_O_SEAT_1(F_SEAT_3)
    End Function

    '座席区分
    Public Shared Function GetValue_O_SEATCLASS_1(ByVal O_SEATCLASS_1 As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(O_SEATCLASS_1)
    End Function
    Public Shared Function GetValue_O_SEATCLASS_2(ByVal O_SEATCLASS_2 As DropDownList) As String
        Return GetValue_O_SEATCLASS_1(O_SEATCLASS_2)
    End Function
    Public Shared Function GetValue_O_SEATCLASS_3(ByVal O_SEATCLASS_3 As DropDownList) As String
        Return GetValue_O_SEATCLASS_1(O_SEATCLASS_3)
    End Function
    Public Shared Function GetValue_F_SEATCLASS_1(ByVal F_SEATCLASS_1 As DropDownList) As String
        Return GetValue_O_SEATCLASS_1(F_SEATCLASS_1)
    End Function
    Public Shared Function GetValue_F_SEATCLASS_2(ByVal F_SEATCLASS_2 As DropDownList) As String
        Return GetValue_O_SEATCLASS_1(F_SEATCLASS_2)
    End Function
    Public Shared Function GetValue_F_SEATCLASS_3(ByVal F_SEATCLASS_3 As DropDownList) As String
        Return GetValue_O_SEATCLASS_1(F_SEATCLASS_3)
    End Function

    '航空会社
    Public Shared Function GetValue_AIRLINE(ByVal AIRLINE_ANA As RadioButton, ByVal AIRLINE_JAL As RadioButton) As String
        If AIRLINE_ANA.Checked = True Then
            Return AppConst.AIRLINE.Code.ANA
        ElseIf AIRLINE_JAL.Checked = True Then
            Return AppConst.AIRLINE.Code.JAL
        Else
            Return ""
        End If
    End Function

    'マイレージナンバー
    Public Shared Function GetValue_MILAGE_NO(ByVal MILAGE_NO As TextBox) As String
        Return Trim(StrConv(MILAGE_NO.Text, VbStrConv.Narrow))
    End Function

    '交通備考欄
    Public Shared Function GetValue_NOTE_KOTSU(ByVal NOTEL_KOTSU As TextBox) As String
        Return Trim(NOTEL_KOTSU.Text)
    End Function

    '備考欄
    Public Shared Function GetValue_NOTES(ByVal NOTES As TextBox) As String
        Return Trim(NOTES.Text)
    End Function

    '同伴者
    Public Shared Function GetValue_ACCOMPANY_FLAG(ByVal ACCOMPANY_FLAG_Yes As RadioButton, ByVal ACCOMPANY_FLAG_No As RadioButton) As String
        If ACCOMPANY_FLAG_Yes.Checked = True Then
            Return AppConst.ACCOMPANY_FLAG.Code.Yes
        ElseIf ACCOMPANY_FLAG_No.Checked = True Then
            Return AppConst.ACCOMPANY_FLAG.Code.No
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_SAME_ROOM(ByVal ACCOMPANY_STAY_Yes As RadioButton, ByVal ACCOMPANY_SAME_ROOM As CheckBox) As String
        Dim wStr As String
        If ACCOMPANY_STAY_Yes.Checked = True Then
            wStr = AppConst.ACCOMPANY_STAY.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_STAY.Code.No
        End If
        Return GetValue_ACCOMPANY_SAME_ROOM(wStr, ACCOMPANY_SAME_ROOM)
    End Function
    Public Shared Function GetValue_ACCOMPANY_SAME_ROOM(ByVal ACCOMPANY_STAY As String, ByVal ACCOMPANY_SAME_ROOM As CheckBox) As String
        If ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.Yes Then
            If ACCOMPANY_SAME_ROOM.Checked = True Then
                Return AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
            Else
                Return AppConst.ACCOMPANY_SAME_ROOM.Code.No
            End If
        Else
            Return ""
        End If
    End Function

    'Public Shared Function GetValue_ACCOMPANY_CHECK_IN(ByVal ACCOMPANY_CHECK_IN As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(ACCOMPANY_CHECK_IN)
    'End Function
    Public Shared Function GetValue_ACCOMPANY_CHECK_IN(ByVal ACCOMPANY_STAY_Yes As RadioButton, ByVal ACCOMPANY_STAY_DATE As CheckBox) As String
        If ACCOMPANY_STAY_DATE.Visible = True AndAlso ACCOMPANY_STAY_Yes.Checked = True AndAlso ACCOMPANY_STAY_DATE.Checked = True Then
            Return AppConst.HOTEL.CHECK_IN
        Else
            Return ""
        End If
    End Function
    'Public Shared Function GetValue_ACCOMPANY_CHECK_OUT(ByVal ACCOMPANY_CHECK_OUT As DropDownList) As String
    '    Return CmnModule.GetSelectedItemValue(ACCOMPANY_CHECK_OUT)
    'End Function
    Public Shared Function GetValue_ACCOMPANY_CHECK_OUT(ByVal ACCOMPANY_STAY_Yes As RadioButton, ByVal ACCOMPANY_STAY_DATE As CheckBox) As String
        If ACCOMPANY_STAY_DATE.Visible = True AndAlso ACCOMPANY_STAY_Yes.Checked = True AndAlso ACCOMPANY_STAY_DATE.Checked = True Then
            Return AppConst.HOTEL.CHECK_OUT
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_STAY(ByVal ACCOMPANY_STAY_Yes As RadioButton, ByVal ACCOMPANY_STAY_No As RadioButton) As String
        If ACCOMPANY_STAY_Yes.Visible = True Then
            If ACCOMPANY_STAY_Yes.Checked = True Then
                Return AppConst.ACCOMPANY_STAY.Code.Yes
            Else
                Return AppConst.ACCOMPANY_STAY.Code.No
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_STAY_DATE(ByVal ACCOMPANY_STAY_DATE_Yes As CheckBox) As String
        If ACCOMPANY_STAY_DATE_Yes.Visible = True Then
            If ACCOMPANY_STAY_DATE_Yes.Checked = True Then
                Return AppConst.ACCOMPANY_STAY_DATE.Code.Yes
            Else
                Return AppConst.ACCOMPANY_STAY_DATE.Code.No
            End If
        Else
            Return ""
        End If
    End Function

    Public Shared Function GetValue_ACCOMPANY_ADULT_SU(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_ADULT_SU As DropDownList) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_ADULT_SU.Visible = True Then
            Return CmnModule.GetSelectedItemValue(ACCOMPANY_ADULT_SU)
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_ADULT_SU(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_ADULT_SU As DropDownList) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_ADULT_SU(wStr, ACCOMPANY_ADULT_SU)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_SU(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_SU.Visible = True Then
            Return CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU)
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_SU(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As DropDownList) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_SU(wStr, ACCOMPANY_CHILD_SU)
    End Function

    Public Shared Function GetValue_ACCOMPANY_CHILD_BED_1(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_BED_1_Yes As RadioButton, ByVal ACCOMPANY_CHILD_BED_1_No As RadioButton) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_BED_1_Yes.Visible = True Then
            If ACCOMPANY_CHILD_SU = "1" OrElse ACCOMPANY_CHILD_SU = "2" Then
                If ACCOMPANY_CHILD_BED_1_Yes.Enabled = False Then
                    Return AppConst.ACCOMPANY_BED.Code.No
                Else
                    If ACCOMPANY_CHILD_BED_1_Yes.Checked = True Then
                        Return AppConst.ACCOMPANY_BED.Code.Yes
                    ElseIf ACCOMPANY_CHILD_BED_1_No.Checked = True Then
                        Return AppConst.ACCOMPANY_BED.Code.No
                    Else
                        Return ""
                    End If
                End If
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_BED_1(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_BED_1_Yes As RadioButton, ByVal ACCOMPANY_CHILD_BED_1_No As RadioButton) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_BED_1(wStr, ACCOMPANY_CHILD_SU, ACCOMPANY_CHILD_BED_1_Yes, ACCOMPANY_CHILD_BED_1_No)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_BED_1(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList, ByVal ACCOMPANY_CHILD_BED_1_Yes As RadioButton, ByVal ACCOMPANY_CHILD_BED_1_No As RadioButton) As String
        Return GetValue_ACCOMPANY_CHILD_BED_1(ACCOMPANY_SAME_ROOM, CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU), ACCOMPANY_CHILD_BED_1_Yes, ACCOMPANY_CHILD_BED_1_No)
    End Function

    Public Shared Function GetValue_ACCOMPANY_CHILD_BED_2(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_BED_2_Yes As RadioButton, ByVal ACCOMPANY_CHILD_BED_2_No As RadioButton) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_BED_2_Yes.Visible = True Then
            If ACCOMPANY_CHILD_SU = "2" Then
                If ACCOMPANY_CHILD_BED_2_Yes.Enabled = False Then
                    Return AppConst.ACCOMPANY_BED.Code.No
                Else
                    If ACCOMPANY_CHILD_BED_2_Yes.Checked = True Then
                        Return AppConst.ACCOMPANY_BED.Code.Yes
                    ElseIf ACCOMPANY_CHILD_BED_2_No.Checked = True Then
                        Return AppConst.ACCOMPANY_BED.Code.No
                    Else
                        Return ""
                    End If
                End If
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_BED_2(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_BED_2_Yes As RadioButton, ByVal ACCOMPANY_CHILD_BED_2_No As RadioButton) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_BED_2(wStr, ACCOMPANY_CHILD_SU, ACCOMPANY_CHILD_BED_2_Yes, ACCOMPANY_CHILD_BED_2_No)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_BED_2(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList, ByVal ACCOMPANY_CHILD_BED_2_Yes As RadioButton, ByVal ACCOMPANY_CHILD_BED_2_No As RadioButton) As String
        Return GetValue_ACCOMPANY_CHILD_BED_2(ACCOMPANY_SAME_ROOM, CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU), ACCOMPANY_CHILD_BED_2_Yes, ACCOMPANY_CHILD_BED_2_No)
    End Function

    Public Shared Function GetValue_ACCOMPANY_CHILD_SEX_1(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_SEX_1_Male As RadioButton, ByVal ACCOMPANY_CHILD_SEX_1_Female As RadioButton) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_SEX_1_Male.Visible = True AndAlso ACCOMPANY_CHILD_SEX_1_Female.Visible = True Then
            If ACCOMPANY_CHILD_SU = "1" OrElse ACCOMPANY_CHILD_SU = "2" Then
                If ACCOMPANY_CHILD_SEX_1_Male.Checked = True Then
                    Return AppConst.SEX.Code.Male
                ElseIf ACCOMPANY_CHILD_SEX_1_Female.Checked = True Then
                    Return AppConst.SEX.Code.Female
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_SEX_1(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_SEX_1_Male As RadioButton, ByVal ACCOMPANY_CHILD_SEX_1_Female As RadioButton) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_SEX_1(wStr, ACCOMPANY_CHILD_SU, ACCOMPANY_CHILD_SEX_1_Male, ACCOMPANY_CHILD_SEX_1_Female)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_SEX_1(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList, ByVal ACCOMPANY_CHILD_SEX_1_Male As RadioButton, ByVal ACCOMPANY_CHILD_SEX_1_Female As RadioButton) As String
        Return GetValue_ACCOMPANY_CHILD_SEX_1(ACCOMPANY_SAME_ROOM, CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU), ACCOMPANY_CHILD_SEX_1_Male, ACCOMPANY_CHILD_SEX_1_Female)
    End Function

    Public Shared Function GetValue_ACCOMPANY_CHILD_SEX_2(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_SEX_2_Male As RadioButton, ByVal ACCOMPANY_CHILD_SEX_2_Female As RadioButton) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_SEX_2_Male.Visible = True AndAlso ACCOMPANY_CHILD_SEX_2_Female.Visible = True Then
            If ACCOMPANY_CHILD_SU = "2" Then
                If ACCOMPANY_CHILD_SEX_2_Male.Checked = True Then
                    Return AppConst.SEX.Code.Male
                ElseIf ACCOMPANY_CHILD_SEX_2_Female.Checked = True Then
                    Return AppConst.SEX.Code.Female
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_SEX_2(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_SEX_2_Male As RadioButton, ByVal ACCOMPANY_CHILD_SEX_2_Female As RadioButton) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_SEX_2(wStr, ACCOMPANY_CHILD_SU, ACCOMPANY_CHILD_SEX_2_Male, ACCOMPANY_CHILD_SEX_2_Female)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_SEX_2(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList, ByVal ACCOMPANY_CHILD_SEX_2_Male As RadioButton, ByVal ACCOMPANY_CHILD_SEX_2_Female As RadioButton) As String
        Return GetValue_ACCOMPANY_CHILD_SEX_2(ACCOMPANY_SAME_ROOM, CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU), ACCOMPANY_CHILD_SEX_2_Male, ACCOMPANY_CHILD_SEX_2_Female)
    End Function

    Public Shared Function GetValue_ACCOMPANY_CHILD_AGE_1(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_AGE_1 As TextBox) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_AGE_1.Visible = True Then
            If ACCOMPANY_CHILD_SU = "1" OrElse ACCOMPANY_CHILD_SU = "2" Then
                If Trim(ACCOMPANY_CHILD_AGE_1.Text) = "" Then
                    Return ""
                Else
                    Return Trim(StrConv(ACCOMPANY_CHILD_AGE_1.Text, VbStrConv.Narrow))
                End If
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_AGE_1(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_AGE_1 As TextBox) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_AGE_1(wStr, ACCOMPANY_CHILD_SU, ACCOMPANY_CHILD_AGE_1)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_AGE_1(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList, ByVal ACCOMPANY_CHILD_AGE_1 As TextBox) As String
        Return GetValue_ACCOMPANY_CHILD_AGE_1(ACCOMPANY_SAME_ROOM, CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU), ACCOMPANY_CHILD_AGE_1)
    End Function

    Public Shared Function GetValue_ACCOMPANY_CHILD_AGE_2(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_AGE_2 As TextBox) As String
        If ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes AndAlso ACCOMPANY_CHILD_AGE_2.Visible = True Then
            If ACCOMPANY_CHILD_SU = "2" Then
                If Trim(ACCOMPANY_CHILD_AGE_2.Text) = "" Then
                    Return ""
                Else
                    Return Trim(StrConv(ACCOMPANY_CHILD_AGE_2.Text, VbStrConv.Narrow))
                End If
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_AGE_2(ByVal ACCOMPANY_SAME_ROOM As CheckBox, ByVal ACCOMPANY_CHILD_SU As String, ByVal ACCOMPANY_CHILD_AGE_2 As TextBox) As String
        Dim wStr As String
        If ACCOMPANY_SAME_ROOM.Checked = True Then
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.Yes
        Else
            wStr = AppConst.ACCOMPANY_SAME_ROOM.Code.No
        End If
        Return GetValue_ACCOMPANY_CHILD_AGE_2(wStr, ACCOMPANY_CHILD_SU, ACCOMPANY_CHILD_AGE_2)
    End Function
    Public Shared Function GetValue_ACCOMPANY_CHILD_AGE_2(ByVal ACCOMPANY_SAME_ROOM As String, ByVal ACCOMPANY_CHILD_SU As DropDownList, ByVal ACCOMPANY_CHILD_AGE_2 As TextBox) As String
        Return GetValue_ACCOMPANY_CHILD_AGE_2(ACCOMPANY_SAME_ROOM, CmnModule.GetSelectedItemValue(ACCOMPANY_CHILD_SU), ACCOMPANY_CHILD_AGE_2)
    End Function

    Public Shared Function GetValue_NOTE_ACCOMPANY(ByVal NOTE_ACCOMPANY As TextBox) As String
        If NOTE_ACCOMPANY.Visible = True Then
            Return Trim(NOTE_ACCOMPANY.Text)
        Else
            Return ""
        End If
    End Function

    '支払方法
    Public Shared Function GetValue_PAYMENT_METHOD(ByVal PAYMENT_METHOD_Card As RadioButton, ByVal PAYMENT_METHOD_Bank As RadioButton) As String
        If PAYMENT_METHOD_Card.Checked = True Then
            Return AppConst.PAYMENT_METHOD.Code.Card
        ElseIf PAYMENT_METHOD_Bank.Checked = True Then
            Return AppConst.PAYMENT_METHOD.Code.Bank
        Else
            Return ""
        End If
    End Function

    '携帯電話番号
    Public Shared Function GetValue_KEITAI(ByVal KEITAI As TextBox) As String
        Return Trim(StrConv(KEITAI.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_KEITAI(ByVal KEITAI_1 As TextBox, ByVal KEITAI_2 As TextBox, ByVal KEITAI_3 As TextBox) As String
        Dim wStr As String = Trim(StrConv(KEITAI_1.Text & "-" & KEITAI_2.Text & "-" & KEITAI_3.Text, VbStrConv.Narrow))
        If wStr = "--" Then wStr = ""
        Return wStr
    End Function

    '送付先
    Public Shared Function GetValue_SEND_SAKI(ByVal SEND_SAKI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(SEND_SAKI)
    End Function
    Public Shared Function GetValue_SEND_ZIP(ByVal SEND_ZIP As TextBox) As String
        Return Trim(StrConv(SEND_ZIP.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_SEND_ZIP(ByVal SEND_ZIP_1 As TextBox, ByVal SEND_ZIP_2 As TextBox) As String
        Dim wStr As String = Trim(StrConv(SEND_ZIP_1.Text & "-" & SEND_ZIP_2.Text, VbStrConv.Narrow))
        If wStr = "-" Then wStr = ""
        Return wStr
    End Function
    Public Shared Function GetValue_SEND_ZIP(ByVal SEND_SAKI As String, ByVal SEND_ZIP_1 As TextBox, ByVal SEND_ZIP_2 As TextBox) As String
        If Trim(SEND_SAKI) = "" Then
            Return ""
        Else
            Dim wStr As String = Trim(StrConv(SEND_ZIP_1.Text & "-" & SEND_ZIP_2.Text, VbStrConv.Narrow))
            If wStr = "-" Then wStr = ""
            Return wStr
        End If
    End Function
    Public Shared Function GetValue_SEND_ADDRESS(ByVal SEND_SAKI As String, ByVal SEND_ADDRESS As TextBox) As String
        If Trim(SEND_SAKI) = "" Then
            Return ""
        Else
            Return Trim(SEND_ADDRESS.Text)
        End If
    End Function
    Public Shared Function GetValue_SEND_NAME(ByVal SEND_SAKI As String, ByVal SEND_NAME As TextBox) As String
        If Trim(SEND_SAKI) = "" Then
            Return ""
        Else
            Return Trim(SEND_NAME.Text)
        End If
    End Function
    Public Shared Function GetValue_SEND_TEL(ByVal SEND_TEL As TextBox) As String
        Return Trim(StrConv(SEND_TEL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_SEND_TEL(ByVal SEND_SAKI As String, ByVal SEND_TEL_1 As TextBox, ByVal SEND_TEL_2 As TextBox, ByVal SEND_TEL_3 As TextBox) As String
        If Trim(SEND_SAKI) = "" Then
            Return ""
        Else
            Dim wStr As String = Trim(StrConv(SEND_TEL_1.Text & "-" & SEND_TEL_2.Text & "-" & SEND_TEL_3.Text, VbStrConv.Narrow))
            If wStr = "--" Then wStr = ""
            Return wStr
        End If
    End Function

    '宿泊料金関連
    Public Shared Function GetValue_HOTEL_NO(ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal STAY_DATE As DropDownList) As String
        If TEHAI_HOTEL_Yes.Checked = True Then
            Return CmnModule.GetSelectedItemValue(STAY_DATE)
        Else
            Return ""
        End If
    End Function

    '宿泊料金
    Public Shared Function GetValue_ROOM_RATE(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        If TBL_DR.TEHAI_HOTEL <> AppConst.TEHAI.Code.Yes Then
            Return "0"
        Else
            Dim strSQL As String = ""
            Dim RsData As System.Data.SqlClient.SqlDataReader
            Dim wROOM_RATE As Long = 0

            strSQL = SQL.MS_PACKAGE_HOTEL.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                Select Case CmnDb.DbData(TableDef.MS_PACKAGE_HOTEL.Column.CHECKIN_DATE, RsData)
                    Case "09/07"
                        wROOM_RATE = CmnModule.DbVal_Kingaku(CmnDb.DbData(TableDef.MS_PACKAGE_HOTEL.Column.ROOM_RATE, RsData))
                End Select
            End While
            RsData.Close()
            Return wROOM_RATE.ToString
        End If
    End Function

    '宿泊料金(同伴者)
    Public Shared Function GetValue_ACCOMPANY_ROOM_RATE(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        If TBL_DR.TEHAI_HOTEL <> AppConst.TEHAI.Code.Yes Then
            Return "0"
        ElseIf TBL_DR.ACCOMPANY_STAY <> AppConst.ACCOMPANY_STAY.Code.Yes Then
            Return "0"
        Else
            Dim strSQL As String = ""
            Dim RsData As System.Data.SqlClient.SqlDataReader
            Dim wROOM_RATE As Long = 0
            Dim wACCOMPANY_ROOM_RATE_TWIN As Long = 0
            Dim wACCOMPANY_ROOM_RATE_TRIPLE As Long = 0
            Dim wACCOMPANY_ROOM_RATE_OTHER As Long = 0

            strSQL = SQL.MS_PACKAGE_HOTEL.AllData()
            RsData = CmnDb.Read(strSQL, DbConn)
            While RsData.Read()
                Select Case CmnDb.DbData(TableDef.MS_PACKAGE_HOTEL.Column.CHECKIN_DATE, RsData)
                    Case "09/07"
                        wACCOMPANY_ROOM_RATE_TWIN = CmnDb.DbData(TableDef.MS_PACKAGE_HOTEL.Column.ACCOMPANY_ROOM_RATE_TWIN, RsData)
                        wACCOMPANY_ROOM_RATE_TRIPLE = CmnDb.DbData(TableDef.MS_PACKAGE_HOTEL.Column.ACCOMPANY_ROOM_RATE_TRIPLE, RsData)
                        wACCOMPANY_ROOM_RATE_OTHER = CmnDb.DbData(TableDef.MS_PACKAGE_HOTEL.Column.ACCOMPANY_ROOM_RATE_OTHER, RsData)
                End Select
            End While
            RsData.Close()

            '同室者あり
            If TBL_DR.ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.Yes Then
                If TBL_DR.ACCOMPANY_SAME_ROOM = AppConst.ACCOMPANY_SAME_ROOM.Code.No Then
                    '別室
                    wROOM_RATE = CmnModule.DbVal_Kingaku(wACCOMPANY_ROOM_RATE_OTHER)
                Else
                    '同室
                    Select Case TBL_DR.ROOM_TYPE
                        Case AppConst.ROOM_TYPE.Twin
                            wROOM_RATE = CmnModule.DbVal_Kingaku(wACCOMPANY_ROOM_RATE_TWIN)
                        Case AppConst.ROOM_TYPE.Triple
                            wROOM_RATE = CmnModule.DbVal_Kingaku(wACCOMPANY_ROOM_RATE_TRIPLE)
                    End Select
                End If
            End If
            Return wROOM_RATE.ToString
        End If
    End Function

    '交通料金関連
    Public Shared Function GetValue_KOTSU_NO(ByVal TEHAI_KOTSU_Yes As RadioButton, ByVal PREFECTURES_NO As DropDownList) As String
        If TEHAI_KOTSU_Yes.Checked = True Then
            Return CmnModule.GetSelectedItemValue(PREFECTURES_NO)
        Else
            Return ""
        End If
    End Function

    Public Shared Function GetValue_O_KOTSU_FARE(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wAIR As Boolean = False
        Dim wJR As Boolean = False
        Dim wAIR_FARE As String = "0"
        Dim wJR_FARE As String = "0"

        If TBL_DR.TEHAI_KOTSU = AppConst.TEHAI.Code.Yes Then
            '交通手配あり
            If TBL_DR.O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR OrElse TBL_DR.O_KOTSU_KUBUN_2 = AppConst.KOTSU_KUBUN.Code.AIR OrElse TBL_DR.O_KOTSU_KUBUN_3 = AppConst.KOTSU_KUBUN.Code.AIR Then
                wAIR = True
            End If
            If TBL_DR.O_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR OrElse TBL_DR.O_KOTSU_KUBUN_2 = AppConst.KOTSU_KUBUN.Code.JR OrElse TBL_DR.O_KOTSU_KUBUN_3 = AppConst.KOTSU_KUBUN.Code.JR Then
                wJR = True
            End If

            If wAIR = True OrElse wJR = True Then
                '都道府県パッケージ金額取得
                Dim strSQL As String = ""
                Dim RsData As System.Data.SqlClient.SqlDataReader
                strSQL &= SQL.MS_PACKAGE_KOTSU.byPREFECTURES_NO(TBL_DR.KOTSU_NO)
                RsData = CmnDb.Read(strSQL, DbConn)
                If RsData.Read() Then
                    wAIR_FARE = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.AIR_FARE, RsData)
                    wJR_FARE = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.JR_FARE, RsData)
                End If
                RsData.Close()
            End If
        End If

        '航空便とJRの両方があった場合は、航空料金を返す
        If wAIR = True Then
            '航空便
            Return wAIR_FARE
        Else
            'JR
            Return wJR_FARE
        End If
    End Function
    Public Shared Function GetValue_F_KOTSU_FARE(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wAIR As Boolean = False
        Dim wJR As Boolean = False
        Dim wAIR_FARE As String = "0"
        Dim wJR_FARE As String = "0"

        If TBL_DR.TEHAI_KOTSU = AppConst.TEHAI.Code.Yes Then
            '交通手配あり
            If TBL_DR.F_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.AIR OrElse TBL_DR.F_KOTSU_KUBUN_2 = AppConst.KOTSU_KUBUN.Code.AIR OrElse TBL_DR.F_KOTSU_KUBUN_3 = AppConst.KOTSU_KUBUN.Code.AIR Then
                wAIR = True
            End If
            If TBL_DR.F_KOTSU_KUBUN_1 = AppConst.KOTSU_KUBUN.Code.JR OrElse TBL_DR.F_KOTSU_KUBUN_2 = AppConst.KOTSU_KUBUN.Code.JR OrElse TBL_DR.F_KOTSU_KUBUN_3 = AppConst.KOTSU_KUBUN.Code.JR Then
                wJR = True
            End If

            If wAIR = True OrElse wJR = True Then
                '都道府県パッケージ金額取得
                Dim strSQL As String = ""
                Dim RsData As System.Data.SqlClient.SqlDataReader
                strSQL &= SQL.MS_PACKAGE_KOTSU.byPREFECTURES_NO(TBL_DR.KOTSU_NO)
                RsData = CmnDb.Read(strSQL, DbConn)
                If RsData.Read() Then
                    wAIR_FARE = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.AIR_FARE, RsData)
                    wJR_FARE = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.JR_FARE, RsData)
                End If
                RsData.Close()
            End If
        End If

        '航空便とJRの両方があった場合は、航空料金を返す
        If wAIR = True Then
            '航空便
            Return wAIR_FARE
        Else
            'JR
            Return wJR_FARE
        End If
    End Function

    Public Shared Function GetValue_O_KOTSU_FARE(ByVal TEHAI_KOTSU_Yes As RadioButton, ByVal O_AIR_FLAG As CheckBox, ByVal PREFECTURES_NO As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wStr As String = "0"
        If TEHAI_KOTSU_Yes.Checked = True Then
            If O_AIR_FLAG.Enabled = True Then
                If O_AIR_FLAG.Checked = True Then
                    Dim strSQL As String = ""
                    Dim RsData As System.Data.SqlClient.SqlDataReader

                    strSQL &= SQL.MS_PACKAGE_KOTSU.byPREFECTURES_NO(CmnModule.GetSelectedItemValue(PREFECTURES_NO))
                    RsData = CmnDb.Read(strSQL, DbConn)
                    If RsData.Read() Then
                        wStr = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.AIR_FARE, RsData)
                    End If
                    RsData.Close()
                End If
            End If
        End If
        Return wStr
    End Function
    Public Shared Function GetValue_F_KOTSU_FARE(ByVal TEHAI_KOTSU_Yes As RadioButton, ByVal F_AIR_FLAG As CheckBox, ByVal PREFECTURES_NO As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wStr As String = "0"
        If TEHAI_KOTSU_Yes.Checked = True Then
            If F_AIR_FLAG.Enabled = True Then
                If F_AIR_FLAG.Checked = True Then
                    Dim strSQL As String = ""
                    Dim RsData As System.Data.SqlClient.SqlDataReader

                    strSQL &= SQL.MS_PACKAGE_KOTSU.byPREFECTURES_NO(CmnModule.GetSelectedItemValue(PREFECTURES_NO))
                    RsData = CmnDb.Read(strSQL, DbConn)
                    If RsData.Read() Then
                        wStr = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.AIR_FARE, RsData)
                    End If
                    RsData.Close()
                End If
            End If
        End If
        Return wStr
    End Function
    Public Shared Function GetValue_O_JR_FARE(ByVal TEHAI_KOTSU_Yes As RadioButton, ByVal O_JR_FLAG As CheckBox, ByVal PREFECTURES_NO As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wStr As String = "0"
        If TEHAI_KOTSU_Yes.Checked = True Then
            If O_JR_FLAG.Enabled = True Then
                If O_JR_FLAG.Checked = True Then
                    Dim strSQL As String = ""
                    Dim RsData As System.Data.SqlClient.SqlDataReader

                    strSQL &= SQL.MS_PACKAGE_KOTSU.byPREFECTURES_NO(CmnModule.GetSelectedItemValue(PREFECTURES_NO))
                    RsData = CmnDb.Read(strSQL, DbConn)
                    If RsData.Read() Then
                        wStr = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.JR_FARE, RsData)
                    End If
                    RsData.Close()
                End If
            End If
        End If
        Return wStr
    End Function
    Public Shared Function GetValue_F_JR_FARE(ByVal TEHAI_KOTSU_Yes As RadioButton, ByVal F_JR_FLAG As CheckBox, ByVal PREFECTURES_NO As DropDownList, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wStr As String = "0"
        If TEHAI_KOTSU_Yes.Checked = True Then
            If F_JR_FLAG.Enabled = True Then
                If F_JR_FLAG.Checked = True Then
                    Dim strSQL As String = ""
                    Dim RsData As System.Data.SqlClient.SqlDataReader

                    strSQL &= SQL.MS_PACKAGE_KOTSU.byPREFECTURES_NO(CmnModule.GetSelectedItemValue(PREFECTURES_NO))
                    RsData = CmnDb.Read(strSQL, DbConn)
                    If RsData.Read() Then
                        wStr = CmnDb.DbData(TableDef.MS_PACKAGE_KOTSU.Column.JR_FARE, RsData)
                    End If
                    RsData.Close()
                End If
            End If
        End If
        Return wStr
    End Function

    'Public Shared Function GetValue_TOTAL_AMOUNT(ByVal ROOM_RATE As String, ByVal ACCOMPANY_ROOM_RATE As String, ByVal O_KOTSU_FARE As String, ByVal F_KOTSU_FARE As String, ByVal O_JR_FARE As String, ByVal F_JR_FARE As String) As String
    '    Dim wTOTAL_AMOUNT As Long = 0
    '    Try
    '        Dim wROOM_RATE As Long = CmnModule.DbVal(ROOM_RATE)
    '        Dim wACCOMPANY_ROOM_RATE As Long = CmnModule.DbVal(ACCOMPANY_ROOM_RATE)
    '        Dim wO_KOTSU_FARE As Long = CmnModule.DbVal(O_KOTSU_FARE)
    '        Dim wF_KOTSU_FARE As Long = CmnModule.DbVal(F_KOTSU_FARE)
    '        Dim wO_JR_FARE As Long = CmnModule.DbVal(O_JR_FARE)
    '        Dim wF_JR_FARE As Long = CmnModule.DbVal(F_JR_FARE)
    '        wTOTAL_AMOUNT = wROOM_RATE + wACCOMPANY_ROOM_RATE + wO_KOTSU_FARE + wF_KOTSU_FARE + wO_JR_FARE + wF_JR_FARE
    '    Catch ex As Exception
    '    End Try
    '    Return wTOTAL_AMOUNT.ToString
    'End Function
    Public Shared Function GetValue_TOTAL_AMOUNT(ByVal ROOM_RATE As String, ByVal ACCOMPANY_ROOM_RATE As String, ByVal O_KOTSU_FARE As String, ByVal F_KOTSU_FARE As String, ByVal O_JR_FARE As String, ByVal F_JR_FARE As String, ByVal SAGAKU_1 As String, ByVal SAGAKU_2 As String, ByVal SAGAKU_3 As String) As String
        Dim wTOTAL_AMOUNT As Long = 0
        Try
            Dim wROOM_RATE As Long = CmnModule.DbVal_Kingaku(ROOM_RATE)
            Dim wACCOMPANY_ROOM_RATE As Long = CmnModule.DbVal_Kingaku(ACCOMPANY_ROOM_RATE)
            Dim wO_KOTSU_FARE As Long = CmnModule.DbVal_Kingaku(O_KOTSU_FARE)
            Dim wF_KOTSU_FARE As Long = CmnModule.DbVal_Kingaku(F_KOTSU_FARE)
            Dim wO_JR_FARE As Long = CmnModule.DbVal_Kingaku(O_JR_FARE)
            Dim wF_JR_FARE As Long = CmnModule.DbVal_Kingaku(F_JR_FARE)
            Dim wSAGAKU_1 As Long = CmnModule.DbVal_Kingaku(SAGAKU_1)
            Dim wSAGAKU_2 As Long = CmnModule.DbVal_Kingaku(SAGAKU_2)
            Dim wSAGAKU_3 As Long = CmnModule.DbVal_Kingaku(SAGAKU_3)

            wTOTAL_AMOUNT = wROOM_RATE + wACCOMPANY_ROOM_RATE + wO_KOTSU_FARE + wF_KOTSU_FARE + wO_JR_FARE + wF_JR_FARE + wSAGAKU_1 + wSAGAKU_2 + wSAGAKU_3
        Catch ex As Exception
        End Try
        Return wTOTAL_AMOUNT.ToString
    End Function
    Public Shared Function GetValue_TOTAL_AMOUNT(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
        Dim wTOTAL_AMOUNT As Long = 0
        Try
            Dim wROOM_RATE As Long = CmnModule.DbVal_Kingaku(TBL_DR.ROOM_RATE)
            Dim wACCOMPANY_ROOM_RATE As Long = CmnModule.DbVal_Kingaku(TBL_DR.ACCOMPANY_ROOM_RATE)
            Dim wO_KOTSU_FARE As Long = CmnModule.DbVal_Kingaku(TBL_DR.O_KOTSU_FARE)
            Dim wF_KOTSU_FARE As Long = CmnModule.DbVal_Kingaku(TBL_DR.F_KOTSU_FARE)
            Dim wSAGAKU_1 As Long = CmnModule.DbVal_Kingaku(TBL_DR.SAGAKU_1)
            Dim wSAGAKU_2 As Long = CmnModule.DbVal_Kingaku(TBL_DR.SAGAKU_2)
            Dim wSAGAKU_3 As Long = CmnModule.DbVal_Kingaku(TBL_DR.SAGAKU_3)

            wTOTAL_AMOUNT = wROOM_RATE + wACCOMPANY_ROOM_RATE + wO_KOTSU_FARE + wF_KOTSU_FARE + wSAGAKU_1 + wSAGAKU_2 + wSAGAKU_3
        Catch ex As Exception
        End Try
        Return wTOTAL_AMOUNT.ToString
    End Function

    '手配状況
    Public Shared Function GetValue_STATUS_TEHAI(ByVal RECORD_KUBUN As String, ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal OldTBL_DR As TableDef.TBL_DR.DataStruct) As String
        Dim wSTATUS_TEHAI As String = TBL_DR.STATUS_TEHAI

        Select Case RECORD_KUBUN
            Case AppConst.RECORD_KUBUN.Code.Insert
                '新規
                If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                    '手配なし
                    wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.Fuyo
                Else
                    '手配あり
                    wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.Input
                End If
            Case AppConst.RECORD_KUBUN.Code.Update
                '変更
                Select Case OldTBL_DR.STATUS_PAYMENT
                    Case AppConst.STATUS_PAYMENT.Code.CardEnd, _
                         AppConst.STATUS_PAYMENT.Code.BillEnd
                        '決済・入金完了後
                        If IsPriceChange(TBL_DR, OldTBL_DR) Then    '支払関連で変更ありの時
                            If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                                '手配なし
                                wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.EndToFuyo
                            Else
                                '手配あり
                                wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.EndToChange
                            End If
                        End If
                    Case AppConst.STATUS_PAYMENT.Code.OK, _
                         AppConst.STATUS_PAYMENT.Code.BillPrint
                        'OKメール送信済み、請求書印刷
                        If IsPriceChange(TBL_DR, OldTBL_DR) Then    '支払関連で変更ありの時
                            If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                                '手配なし
                                wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.OKToFuyo
                            Else
                                '手配あり
                                wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.OkToChange
                            End If
                        End If
                    Case Else
                        Select Case OldTBL_DR.STATUS_TEHAI
                            Case AppConst.STATUS_TEHAI.Code.Fuyo, _
                                 AppConst.STATUS_TEHAI.Code.Input, _
                                 AppConst.STATUS_TEHAI.Code.Change, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG, _
                                 AppConst.STATUS_TEHAI.Code.KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK
                                '手配中以下
                                If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                                    '手配なし
                                    If TBL_DR.STATUS_TEHAI <> AppConst.STATUS_TEHAI.Code.Fuyo Then
                                        wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.Change
                                    End If
                                Else
                                    '手配あり
                                    wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.Change
                                End If
                        End Select
                End Select
            Case AppConst.RECORD_KUBUN.Code.Cancel
                '取消
                Select Case OldTBL_DR.STATUS_PAYMENT
                    Case AppConst.STATUS_PAYMENT.Code.CardEnd, _
                         AppConst.STATUS_PAYMENT.Code.BillEnd
                        '決済・入金完了後
                        wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.EndToCancel
                    Case AppConst.STATUS_PAYMENT.Code.OK, _
                        AppConst.STATUS_PAYMENT.Code.BillPrint
                        'OKメール送信済み、請求書印刷
                        wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.OKToCancel
                    Case Else
                        Select Case OldTBL_DR.STATUS_TEHAI
                            Case AppConst.STATUS_TEHAI.Code.Cancel, _
                                 AppConst.STATUS_TEHAI.Code.Fuyo, _
                                 AppConst.STATUS_TEHAI.Code.Input, _
                                 AppConst.STATUS_TEHAI.Code.Change, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG, _
                                 AppConst.STATUS_TEHAI.Code.KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK
                                '手配中以下
                                wSTATUS_TEHAI = AppConst.STATUS_TEHAI.Code.Cancel
                        End Select
                End Select
        End Select
        Return wSTATUS_TEHAI
    End Function

    Public Shared Function GetValue_STATUS_TEHAI(ByVal STATUS_TEHAI As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(STATUS_TEHAI)
    End Function

    '支払状況
    Public Shared Function GetValue_STATUS_PAYMENT(ByVal STATUS_PAYMENT As DropDownList) As String
        Return CmnModule.GetSelectedItemValue(STATUS_PAYMENT)
    End Function
    Public Shared Function GetValue_STATUS_PAYMENT(ByVal RECORD_KUBUN As String, ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal OldTBL_DR As TableDef.TBL_DR.DataStruct) As String
        Dim wSTATUS_PAYMENT As String = TBL_DR.STATUS_PAYMENT

        Select Case RECORD_KUBUN
            Case AppConst.RECORD_KUBUN.Code.Insert
                '新規
                If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                    '手配なし
                    wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.Fuyo
                Else
                    '手配あり
                    wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.Input
                End If
            Case AppConst.RECORD_KUBUN.Code.Update
                '変更
                Select Case OldTBL_DR.STATUS_PAYMENT
                    Case AppConst.STATUS_PAYMENT.Code.CardEnd, _
                         AppConst.STATUS_PAYMENT.Code.BillEnd
                        '決済・入金完了後
                        If IsPriceChange(TBL_DR, OldTBL_DR) Then    '支払関連で変更ありの時
                            If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                                '手配なし
                                wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.EndToFuyo
                            Else
                                '手配あり
                                wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.EndToChange
                            End If
                        End If
                    Case AppConst.STATUS_PAYMENT.Code.OK, _
                         AppConst.STATUS_PAYMENT.Code.BillPrint
                        'OKメール送信済み、請求書印刷
                        If IsPriceChange(TBL_DR, OldTBL_DR) Then    '支払関連で変更ありの時
                            If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                                '手配なし
                                wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.OKToFuyo
                            Else
                                '手配あり
                                wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.OkToChange
                            End If
                        End If
                    Case Else
                        '手配中以下
                        If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                            '手配なし
                            wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.Fuyo
                        Else
                            '手配あり
                            wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.Input
                        End If
                End Select
            Case AppConst.RECORD_KUBUN.Code.Cancel
                '取消
                Select Case OldTBL_DR.STATUS_PAYMENT
                    Case AppConst.STATUS_PAYMENT.Code.CardEnd, _
                         AppConst.STATUS_PAYMENT.Code.BillEnd
                        '決済・入金完了後
                        wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.EndToCancel
                    Case AppConst.STATUS_PAYMENT.Code.OK, _
                        AppConst.STATUS_PAYMENT.Code.BillPrint
                        'OKメール送信済み、請求書印刷
                        wSTATUS_PAYMENT = AppConst.STATUS_PAYMENT.Code.OKToCancel
                End Select
        End Select
        Return wSTATUS_PAYMENT
    End Function

    '請求先名
    Public Shared Function GetValue_BILL_NAME(ByVal BILL_NAME As TextBox) As String
        Return Trim(BILL_NAME.Text)
    End Function

    '登録者
    Public Shared Function GetValue_INS_TYPE(ByVal UserType As AppModule.UserType) As String
        Dim wStr As String = ""
        Select Case UserType
            Case UserType.Member
                wStr = AppConst.INS_TYPE.Code.Member
            Case UserType.Dr
                wStr = AppConst.INS_TYPE.Code.Dr
            Case UserType.Admin
                wStr = AppConst.INS_TYPE.Code.Admin
        End Select

        Return wStr
    End Function

    '手配特別事項
    Public Shared Function GetValue_TEHAIMAIL_HOTEL(ByVal TEHAIMAIL_HOTEL As TextBox) As String
        Return Trim(TEHAIMAIL_HOTEL.Text)
    End Function
    Public Shared Function GetValue_TEHAIMAIL_KOTSU(ByVal TEHAIMAIL_KOTSU As TextBox) As String
        Return Trim(TEHAIMAIL_KOTSU.Text)
    End Function

    '宿泊確認書
    Public Shared Function GetValue_HOTELPRINT_SHIHARAI_IDX(ByVal MS_HOTELPRINT_SHIHARAI As DropDownList) As String
        Return MS_HOTELPRINT_SHIHARAI.SelectedIndex
    End Function
    Public Shared Function GetValue_HOTELPRINT_CHECKIN_IDX(ByVal MS_HOTELPRINT_CHECKIN As DropDownList) As String
        Return MS_HOTELPRINT_CHECKIN.SelectedIndex
    End Function
    Public Shared Function GetValue_HOTELPRINT_RENRAKU_IDX(ByVal MS_HOTELPRINT_RENRAKU As DropDownList) As String
        Return MS_HOTELPRINT_RENRAKU.SelectedIndex
    End Function
    Public Shared Function GetValue_HOTELPRINT_SHIHARAI(ByVal HOTELPRINT_SHIHARAI As TextBox) As String
        Return Trim(HOTELPRINT_SHIHARAI.Text)
    End Function
    Public Shared Function GetValue_HOTELPRINT_CHECKIN(ByVal HOTELPRINT_CHECKIN As TextBox) As String
        Return Trim(HOTELPRINT_CHECKIN.Text)
    End Function
    Public Shared Function GetValue_HOTELPRINT_RENRAKU(ByVal HOTELPRINT_RENRAKU As TextBox) As String
        Return Trim(HOTELPRINT_RENRAKU.Text)
    End Function
    Public Shared Function GetValue_HOTELPRINT_ACCOMPANY(ByVal HOTELPRINT_ACCOMPANY As TextBox) As String
        Return Trim(HOTELPRINT_ACCOMPANY.Text)
    End Function
    Public Shared Function GetValue_HOTELPRINT_BREAKFAST(ByVal HOTELPRINT_BREAKFAST As TextBox) As String
        Return Trim(HOTELPRINT_BREAKFAST.Text)
    End Function

    'ホテル
    Public Shared Function GetValue_HOTEL_NAME(ByVal HOTEL_NAME As TextBox) As String
        Return Trim(HOTEL_NAME.Text)
    End Function
    Public Shared Function GetValue_HOTEL_ADDRESS(ByVal HOTEL_ADDRESS As TextBox) As String
        Return Trim(HOTEL_ADDRESS.Text)
    End Function
    Public Shared Function GetValue_HOTEL_TEL(ByVal HOTEL_TEL As TextBox) As String
        Return Trim(StrConv(HOTEL_TEL.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_HOTEL_FAX(ByVal HOTEL_FAX As TextBox) As String
        Return Trim(StrConv(HOTEL_FAX.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_ROOM_TYPE(ByVal ROOM_TYPE As DropDownList) As String
        Return CmnModule.GetSelectedItemText(ROOM_TYPE)
    End Function
    Public Shared Function GetValue_ROOM_TYPE(ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal ROOM_TYPE As HiddenField) As String
        If TEHAI_HOTEL_Yes.Checked = False Then
            Return ""
        Else
            Return ROOM_TYPE.Value
        End If
    End Function

    '差額
    Public Shared Function GetValue_SAGAKU_NAME_1(ByVal SAGAKU_NAME_1 As TextBox) As String
        Return Trim(SAGAKU_NAME_1.Text)
    End Function
    Public Shared Function GetValue_SAGAKU_NAME_2(ByVal SAGAKU_NAME_2 As TextBox) As String
        Return GetValue_SAGAKU_NAME_1(SAGAKU_NAME_2)
    End Function
    Public Shared Function GetValue_SAGAKU_NAME_3(ByVal SAGAKU_NAME_3 As TextBox) As String
        Return GetValue_SAGAKU_NAME_1(SAGAKU_NAME_3)
    End Function
    Public Shared Function GetValue_SAGAKU_1(ByVal SAGAKU_1 As TextBox) As String
        Return Trim(Replace(StrConv(SAGAKU_1.Text, VbStrConv.Narrow), ",", ""))
    End Function
    Public Shared Function GetValue_SAGAKU_2(ByVal SAGAKU_2 As TextBox) As String
        Return GetValue_SAGAKU_1(SAGAKU_2)
    End Function
    Public Shared Function GetValue_SAGAKU_3(ByVal SAGAKU_3 As TextBox) As String
        Return GetValue_SAGAKU_1(SAGAKU_3)
    End Function

    '入金日
    Public Shared Function GetValue_PAYMENT_DATE_BANK() As String
        Return CmnModule.GetSysDateTime()
    End Function
    Public Shared Function GetValue_PAYMENT_DATE_CARD() As String
        Return CmnModule.GetSysDateTime()
    End Function

    'チケット発送
    Public Shared Function GetValue_TICKET_SEND_DATE1(ByVal TICKET_SEND_DATE1 As TextBox) As String
        Return Trim(StrConv(TICKET_SEND_DATE1.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_TICKET_SEND_DATE2(ByVal TICKET_SEND_DATE2 As TextBox) As String
        Return Trim(StrConv(TICKET_SEND_DATE2.Text, VbStrConv.Narrow))
    End Function
    Public Shared Function GetValue_TICKET_FLAG(ByVal TICKET_SEND_DATE1 As String, ByVal TICKET_SEND_DATE2 As String) As String
        If Trim(TICKET_SEND_DATE1) <> "" OrElse Trim(TICKET_SEND_DATE2) <> "" Then
            Return CmnConst.Flag.On
        Else
            Return CmnConst.Flag.Off
        End If
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

    '手配完了=Trueを返す
    Public Shared Function IsOK_TEHAI(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As Boolean
        If IsCanceled(TBL_DR.RECORD_KUBUN) Then
            '参加取消→True
            Return True
        Else
            If Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                '手配不要→True
                Return True
            ElseIf IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                '宿泊、交通 手配あり
                If IsOK_TEHAI_HOTEL(TBL_DR.STATUS_TEHAI) AndAlso IsOK_TEHAI_KOTSU(TBL_DR.STATUS_TEHAI) Then
                    '宿泊完了+交通完了→True
                    Return True
                End If
            ElseIf IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                '宿泊手配あり
                If IsOK_TEHAI_HOTEL(TBL_DR.STATUS_TEHAI) Then
                    '宿泊完了→True
                    Return True
                End If
            ElseIf Not IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                '公共交通手配あり
                If IsOK_TEHAI_KOTSU(TBL_DR.STATUS_TEHAI) Then
                    '交通完了→True
                    Return True
                End If
            End If
        End If
        Return False    '手配中
    End Function

    '宿泊手配完了=Trueを返す
    Public Shared Function IsOK_TEHAI_HOTEL(ByVal STATUS_TEHAI As String) As Boolean
        Select Case STATUS_TEHAI
            Case AppConst.STATUS_TEHAI.Code.HotelOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
                 AppConst.STATUS_TEHAI.Name.HotelOK, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuNG, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
                Return True
            Case Else
                Return False
        End Select
    End Function

    '公共交通手配完了=Trueを返す
    Public Shared Function IsOK_TEHAI_KOTSU(ByVal STATUS_TEHAI As String) As Boolean
        Select Case STATUS_TEHAI
            Case AppConst.STATUS_TEHAI.Code.KotsuOK, AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
                 AppConst.STATUS_TEHAI.Name.KotsuOK, AppConst.STATUS_TEHAI.Name.HotelNG_KotsuOK, AppConst.STATUS_TEHAI.Name.HotelOK_KotsuOK
                Return True
            Case Else
                Return False
        End Select
    End Function

    '支払関係で変更があった場合、Trueを返す
    Public Shared Function IsPriceChange(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal OldTBL_DR As TableDef.TBL_DR.DataStruct) As Boolean
        '都道府県、宿泊手配、交通手配をチェック
        If (Not AppModule.IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU)) AndAlso _
           (Not AppModule.IsTEHAI_HOTEL(OldTBL_DR.TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(OldTBL_DR.TEHAI_KOTSU)) Then
            '新旧ともに手配不要
            Return False
        End If

        If TBL_DR.TEHAI_HOTEL <> OldTBL_DR.TEHAI_HOTEL Then
            '宿泊手配が違う場合
            Return True
        Else
            If AppModule.IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) OrElse AppModule.IsTEHAI_HOTEL(TBL_DR.TEHAI_HOTEL) Then
                '新旧どちらかの宿泊手配が必要な場合
                If IsChanged(OldTBL_DR.HOTEL_NO, TBL_DR.HOTEL_NO) Then Return True
                If IsChanged(OldTBL_DR.CHECK_IN, TBL_DR.CHECK_IN) Then Return True
                If IsChanged(OldTBL_DR.CHECK_OUT, TBL_DR.CHECK_OUT) Then Return True
                If IsChanged(OldTBL_DR.ROOM_TYPE, TBL_DR.ROOM_TYPE) Then Return True
                If IsChanged(OldTBL_DR.ROOM_SU, TBL_DR.ROOM_SU) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_STAY, TBL_DR.ACCOMPANY_STAY) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_STAY_DATE, TBL_DR.ACCOMPANY_STAY_DATE) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_CHECK_IN, TBL_DR.ACCOMPANY_CHECK_IN) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_CHECK_OUT, TBL_DR.ACCOMPANY_CHECK_OUT) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_ADULT_SU, TBL_DR.ACCOMPANY_ADULT_SU) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_CHILD_SU, TBL_DR.ACCOMPANY_CHILD_SU) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_CHILD_BED_1, TBL_DR.ACCOMPANY_CHILD_BED_1) Then Return True
                If IsChanged(OldTBL_DR.ACCOMPANY_CHILD_BED_2, TBL_DR.ACCOMPANY_CHILD_BED_2) Then Return True
            End If
        End If
        If TBL_DR.TEHAI_KOTSU <> OldTBL_DR.TEHAI_KOTSU Then
            '交通手配が違う場合
            Return True
        Else
            If AppModule.IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) OrElse AppModule.IsTEHAI_KOTSU(TBL_DR.TEHAI_KOTSU) Then
                '新旧どちらかの交通手配が必要な場合
                If IsChanged(OldTBL_DR.PREFECTURES_NO, TBL_DR.PREFECTURES_NO) Then Return True
                If IsChanged(OldTBL_DR.KOTSU_NO, TBL_DR.KOTSU_NO) Then Return True
                If IsChanged(OldTBL_DR.O_KOTSU_FARE, TBL_DR.O_KOTSU_FARE) Then Return True
                If IsChanged(OldTBL_DR.F_KOTSU_FARE, TBL_DR.F_KOTSU_FARE) Then Return True
                If IsChanged(OldTBL_DR.O_KOTSU_KUBUN_1, TBL_DR.O_KOTSU_KUBUN_1) Then Return True
                If IsChanged(OldTBL_DR.O_KOTSU_KUBUN_2, TBL_DR.O_KOTSU_KUBUN_2) Then Return True
                If IsChanged(OldTBL_DR.O_KOTSU_KUBUN_3, TBL_DR.O_KOTSU_KUBUN_3) Then Return True
                If IsChanged(OldTBL_DR.F_KOTSU_KUBUN_1, TBL_DR.F_KOTSU_KUBUN_1) Then Return True
                If IsChanged(OldTBL_DR.F_KOTSU_KUBUN_2, TBL_DR.F_KOTSU_KUBUN_2) Then Return True
                If IsChanged(OldTBL_DR.F_KOTSU_KUBUN_3, TBL_DR.F_KOTSU_KUBUN_3) Then Return True
            End If
        End If

        '差額
        If IsChanged(OldTBL_DR.SAGAKU_1, TBL_DR.SAGAKU_1) Then Return True
        If IsChanged(OldTBL_DR.SAGAKU_2, TBL_DR.SAGAKU_2) Then Return True
        If IsChanged(OldTBL_DR.SAGAKU_3, TBL_DR.SAGAKU_3) Then Return True

        Return False
    End Function

    '旧データと新データを比較して違っていたらTrueを返す
    Public Shared Function IsChanged(ByVal OldData As String, ByVal NewData As String) As Boolean
        Dim wOldData As String = Trim(StrConv(OldData, VbStrConv.Wide)).ToLower
        Dim wNewData As String = Trim(StrConv(NewData, VbStrConv.Wide)).ToLower
        If wOldData <> wNewData Then
            Return True
        Else
            Return False
        End If
    End Function

    '支払完了はTrueを返す
    Public Shared Function IsPayEnd(ByVal STATUS_PAYMENT As String) As Boolean
        Select Case CmnModule.ClearHtmlSpace(STATUS_PAYMENT)
            Case AppConst.STATUS_PAYMENT.Code.CardEnd, AppConst.STATUS_PAYMENT.Code.BillEnd
                Return True
            Case Else
                Return False
        End Select
    End Function


    '== 列挙型 ==
    'ユーザ種類
    Enum UserType
        [Member] = 1
        [Dr] = 2
        [Manage] = 3
        [Admin] = 4
        [Keiri] = 5
    End Enum
    'テーブル
    Enum TableType
        [MS_CODE]
        [MS_OFFICE]
        [MS_PREFECTURES]
        [MS_MEMBER]
        [MS_PACKAGE_HOTEL]
        [MS_PACKAGE_KOTSU]
        [MS_HOTEL]
        [MS_HOTELPRINT_CHECKIN]
        [MS_HOTELPRINT_RENRAKU]
        [MS_HOTELPRINT_SHIHARAI]
        [MS_HOTELPRINT_ACCOMPANY]
        [MS_HOTELPRINT_BREAKFAST]
        [MS_ROOM_TYPE]
        [MS_MANAGE]
        [MS_SHISETSU]
        [MS_DR]
        [TBL_DR]
    End Enum

End Class
