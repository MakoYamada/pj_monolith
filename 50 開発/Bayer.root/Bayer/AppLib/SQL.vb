Imports CommonLib
Imports AppLib
Public Class SQL

    Public Class GetValue
        Public Shared Function [DATE]() As String
            Return CmnModule.GetSysDateTime()
        End Function
        Public Shared Function USER() As String
            Return System.Web.HttpContext.Current.Session.Item(SessionDef.LoginID)
        End Function
        Public Shared Function PGM() As String
            Return System.Web.HttpContext.Current.Request.Path
        End Function
    End Class

    Public Class TBL_KOUENKAI

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_KOUENKAI.*" _
        & " FROM TBL_KOUENKAI"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_KOUENKAI.KOUENKAI_NO" _
        & ",TBL_KOUENKAI.KOUENKAI_EDABAN"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KOUENKAI"
            strSQL &= "(" & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_EDABAN
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.FROM_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TO_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ZETIA_CD
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.BU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_JIGYOBU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KANA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_JIGYOBU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KANA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CODE_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.DAIKIBO_FLG
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_EDABAN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TAXI_PRT_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.FROM_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TO_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.SEIHIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.ZETIA_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.BU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_JIGYOBU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_JIGYOBU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EMAIL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CODE_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.COST_CENTER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.DAIKIBO_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TTANTO_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOUENKAI SET"
            strSQL &= " " & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.TAXI_PRT_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.FROM_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.FROM_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TO_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.TO_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.SEIHIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T & "='" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF & "='" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ZETIA_CD & "='" & CmnDb.SqlString(TBL_KOUENKAI.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.BU & "='" & CmnDb.SqlString(TBL_KOUENKAI.BU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_JIGYOBU & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_JIGYOBU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NO & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KANA & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_JIGYOBU & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_JIGYOBU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NO & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_NO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KANA & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EMAIL) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI & "='" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CODE_T & "='" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CODE_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.COST_CENTER & "='" & CmnDb.SqlString(TBL_KOUENKAI.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.DAIKIBO_FLG & "='" & CmnDb.SqlString(TBL_KOUENKAI.DAIKIBO_FLG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTANTO_ID & "='" & CmnDb.SqlString(TBL_KOUENKAI.TTANTO_ID) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_USER & "='" & CmnDb.SqlString(TBL_KOUENKAI.INPUT_USER) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_USER & "='" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOUENKAI.Column.KOUENKAI_EDABAN & "='" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_EDABAN) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_SEIKYU

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_SEIKYU.*" _
        & " FROM TBL_SEIKYU"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_SEIKYU.KOUENKAI_NO"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_SEIKYU.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_SEIKYU"
            strSQL &= "(" & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UNEIHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KOTSUHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UNEIHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KOTSUHI_T
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.UNEIHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KOTSUHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.UNEIHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KOTSUHI_T) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SEIKYU SET"
            strSQL &= " " & TableDef.TBL_SEIKYU.Column.KAIJOHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UNEIHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.UNEIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KOTSUHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.KOTSUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UNEIHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.UNEIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KOTSUHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.KOTSUHI_T) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_KOTSUHOTEL

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_KOTSUHOTEL.*" _
        & " FROM TBL_KOTSUHOTEL"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_KOTSUHOTEL.KOUENKAI_NO"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_DR_MPID(ByVal KOUENKAI_NO As String, ByVal DR_MPID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KOTSUHOTEL.DR_MPID='" & CmnDb.SqlString(DR_MPID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KOTSUHOTEL"
            strSQL &= "(" & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_CD
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_EDABAN
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_KANA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SEX
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_JIGYOBU
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AREA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_NO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KANA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CODE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_HOTEL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.HOTEL_IRAINAIYOU
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HAKUSU
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_SMOKING
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_HOTEL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_ADDRESS
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_TEL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HAKUSU
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKIN_TIME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKOUT_TIME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_ROOM_TYPE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_SMOKING
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_NOTE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_NOTE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_NOTE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_NOTE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_RAIL_FARE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_RAIL_CANCELLATION
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_AIR_FARE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_AIR_CANCELLATION
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_OTHER_FARE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_OTHER_CANCELLATION
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TOUROKUKANRI_FEE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_HAKKEN_FEE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_SEISAN_FEE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_MOUSHIKOMI_SAKI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_MR
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEAT
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEX
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AGE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_EDABAN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SEX) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_YAKUWARI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SANKA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_JIGYOBU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_FS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ACCOUNT_CODE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.COST_CENTER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INTERNAL_ORDER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.CMSHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.CMSHONIN_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.CMSHONIN_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_HOTEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.HOTEL_IRAINAIYOU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HAKUSU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_SMOKING) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_HOTEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HAKUSU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_ROOM_TYPE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_NOTE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_NOTE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_NOTE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_NOTE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_RAIL_FARE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_RAIL_CANCELLATION) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_AIR_FARE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_AIR_CANCELLATION) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_OTHER_FARE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_OTHER_CANCELLATION) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TOUROKUKANRI_FEE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_HAKKEN_FEE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_SEISAN_FEE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_TAXI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_MOUSHIKOMI_SAKI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_MR) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEAT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEX) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AGE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_DATE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_KANA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SEX & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SEX) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_YAKUWARI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SANKA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_JIGYOBU & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_JIGYOBU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AREA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_NO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KANA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_FS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CODE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ACCOUNT_CODE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.INTERNAL_ORDER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.CMSHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.CMSHONIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.CMSHONIN_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.CMSHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_HOTEL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_HOTEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.HOTEL_IRAINAIYOU & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.HOTEL_IRAINAIYOU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HAKUSU & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HAKUSU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_SMOKING & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_SMOKING) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_HOTEL_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_HOTEL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_HOTEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_ADDRESS & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_TEL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HAKUSU & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HAKUSU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKIN_TIME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKOUT_TIME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_ROOM_TYPE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_ROOM_TYPE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_SMOKING & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TEHAI_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_IRAINAIYOU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_KOTSUKIKAN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AIRPORT2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_TIME2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_BIN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_AGE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AGE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TEHAI_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_IRAINAIYOU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_KOTSUKIKAN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AIRPORT2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_TIME2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_BIN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_AGE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AGE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_NOTE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_NOTE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_NOTE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_NOTE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_NOTE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_NOTE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_NOTE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_NOTE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_RAIL_FARE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_RAIL_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_RAIL_CANCELLATION & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_RAIL_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_AIR_FARE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_AIR_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_AIR_CANCELLATION & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_AIR_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_OTHER_FARE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_OTHER_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.FIX_OTHER_CANCELLATION & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.FIX_OTHER_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TOUROKUKANRI_FEE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TOUROKUKANRI_FEE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_HAKKEN_FEE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_HAKKEN_FEE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_SEISAN_FEE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_SEISAN_FEE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_TAXI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_MOUSHIKOMI_SAKI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_MOUSHIKOMI_SAKI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_TO_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_TO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_FROM_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_FROM_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TO_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KINGAKU_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KINGAKU_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_MEISAI_NO_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_MEISAI_NO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_VOID_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_VOID_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_PRINTDATE_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_PRINTDATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SEIKYUDATE_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SEIKYUDATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_MR & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_MR) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEAT & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEAT) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEX & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEX) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AGE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AGE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_DATE) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_CD & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_CD) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_EDABAN & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_EDABAN) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_KAIJO

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_KAIJO.*" _
        & " FROM TBL_KAIJO"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_KAIJO.KOUENKAI_ID"

        Public Shared Function byKOUENKAI_ID(ByVal KOUENKAI_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_ID='" & CmnDb.SqlString(KOUENKAI_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KAIJO"
            strSQL &= "(" & TableDef.TBL_KAIJO.Column.KOUENKAI_ID
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TIME_STAMP
            strSQL &= "," & TableDef.TBL_KAIJO.Column.AREA
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ADDRESS
            strSQL &= "," & TableDef.TBL_KAIJO.Column.EIGYOSHO
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ZIP
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TANTO_NO
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TANTO_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TANTO_KANA
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INTERNAL_ORDER_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ACCOUNT_CODE_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.EMAIL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEND_SAKI_FS
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_MPID
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_KANA
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_SHISETSU_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_CD
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_SHISETSU_CD
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_ADDRESS
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_GOFFICIAL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_YAKUWARI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.BU
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ACCOUNT_CODE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INTERNAL_ORDER
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ZETIA_CD
            strSQL &= "," & TableDef.TBL_KAIJO.Column.STATUS_SHONIN
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_TIME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.CMSHONIN_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.CMSHONIN_TIME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.CMSHONIN_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.YOTEI_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_DATE_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MEETING_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEIHIN_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_DR
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_OTHER
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MITSUMORI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MITSUMORI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MITSUMORI_TOTAL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_LAYOUT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_TIME1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_TIME2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TIME1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TIME2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TIME1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TIME2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.OTHER_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_KAISAI_SHISETSU
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_KAISAI_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_SEISAN_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_SEISAN_GTAX
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_SEISAN_NTAX
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ZIP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TANTO_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TANTO_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.INTERNAL_ORDER_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ACCOUNT_CODE_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.EMAIL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SEND_SAKI_FS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_MPID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_SHISETSU_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_GOFFICIAL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.DR_YAKUWARI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.BU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ACCOUNT_CODE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.COST_CENTER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.INTERNAL_ORDER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ZETIA_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.STATUS_SHONIN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.CMSHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.CMSHONIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.CMSHONIN_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.YOTEI_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_DATE_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MEETING_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SEIHIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SANKA_YOTEI_CNT_DR) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SANKA_YOTEI_CNT_OTHER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MITSUMORI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MITSUMORI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MITSUMORI_TOTAL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_LAYOUT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_TIME1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_TIME2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TIME1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TIME2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_CNT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TIME1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TIME2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.OTHER_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.FIX_KAISAI_SHISETSU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.FIX_KAISAI_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.FIX_SEISAN_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.FIX_SEISAN_GTAX) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.FIX_SEISAN_NTAX) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KAIJO SET"
            strSQL &= " " & TableDef.TBL_KAIJO.Column.TIME_STAMP & "='" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.AREA & "='" & CmnDb.SqlString(TBL_KAIJO.AREA) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ADDRESS & "='" & CmnDb.SqlString(TBL_KAIJO.ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.EIGYOSHO & "='" & CmnDb.SqlString(TBL_KAIJO.EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ZIP & "='" & CmnDb.SqlString(TBL_KAIJO.ZIP) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TANTO_NO & "='" & CmnDb.SqlString(TBL_KAIJO.TANTO_NO) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TANTO_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TANTO_KANA & "='" & CmnDb.SqlString(TBL_KAIJO.TANTO_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INTERNAL_ORDER_T & "='" & CmnDb.SqlString(TBL_KAIJO.INTERNAL_ORDER_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ACCOUNT_CODE_T & "='" & CmnDb.SqlString(TBL_KAIJO.ACCOUNT_CODE_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEL & "='" & CmnDb.SqlString(TBL_KAIJO.TEL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.EMAIL & "='" & CmnDb.SqlString(TBL_KAIJO.EMAIL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEND_SAKI_FS & "='" & CmnDb.SqlString(TBL_KAIJO.SEND_SAKI_FS) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_MPID & "='" & CmnDb.SqlString(TBL_KAIJO.DR_MPID) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.DR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_KANA & "='" & CmnDb.SqlString(TBL_KAIJO.DR_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_SHISETSU_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.DR_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_CD & "='" & CmnDb.SqlString(TBL_KAIJO.DR_CD) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_SHISETSU_CD & "='" & CmnDb.SqlString(TBL_KAIJO.DR_SHISETSU_CD) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_ADDRESS & "='" & CmnDb.SqlString(TBL_KAIJO.DR_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_GOFFICIAL & "='" & CmnDb.SqlString(TBL_KAIJO.DR_GOFFICIAL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.DR_YAKUWARI & "='" & CmnDb.SqlString(TBL_KAIJO.DR_YAKUWARI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.BU & "='" & CmnDb.SqlString(TBL_KAIJO.BU) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ACCOUNT_CODE & "='" & CmnDb.SqlString(TBL_KAIJO.ACCOUNT_CODE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.COST_CENTER & "='" & CmnDb.SqlString(TBL_KAIJO.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INTERNAL_ORDER & "='" & CmnDb.SqlString(TBL_KAIJO.INTERNAL_ORDER) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ZETIA_CD & "='" & CmnDb.SqlString(TBL_KAIJO.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.STATUS_SHONIN & "='" & CmnDb.SqlString(TBL_KAIJO.STATUS_SHONIN) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_TIME & "='" & CmnDb.SqlString(TBL_KAIJO.SHONIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.CMSHONIN_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.CMSHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.CMSHONIN_TIME & "='" & CmnDb.SqlString(TBL_KAIJO.CMSHONIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.CMSHONIN_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.CMSHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.YOTEI_DATE & "='" & CmnDb.SqlString(TBL_KAIJO.YOTEI_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_DATE_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_DATE_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MEETING_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.MEETING_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEIHIN_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.SEIHIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_DR & "='" & CmnDb.SqlString(TBL_KAIJO.SANKA_YOTEI_CNT_DR) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SANKA_YOTEI_CNT_OTHER & "='" & CmnDb.SqlString(TBL_KAIJO.SANKA_YOTEI_CNT_OTHER) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MITSUMORI_TF & "='" & CmnDb.SqlString(TBL_KAIJO.MITSUMORI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MITSUMORI_T & "='" & CmnDb.SqlString(TBL_KAIJO.MITSUMORI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MITSUMORI_TOTAL & "='" & CmnDb.SqlString(TBL_KAIJO.MITSUMORI_TOTAL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS1 & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS2 & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME1 & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME2 & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_LAYOUT & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_LAYOUT) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_KAIJO_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_TIME1 & "='" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_TIME1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_TIME2 & "='" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_TIME2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TIME1 & "='" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TIME1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TIME2 & "='" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TIME2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_CNT & "='" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_CNT) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TIME1 & "='" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TIME1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TIME2 & "='" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TIME2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.OTHER_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.OTHER_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_KAISAI_SHISETSU & "='" & CmnDb.SqlString(TBL_KAIJO.FIX_KAISAI_SHISETSU) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_KAISAI_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.FIX_KAISAI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_SEISAN_TF & "='" & CmnDb.SqlString(TBL_KAIJO.FIX_SEISAN_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_SEISAN_GTAX & "='" & CmnDb.SqlString(TBL_KAIJO.FIX_SEISAN_GTAX) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.FIX_SEISAN_NTAX & "='" & CmnDb.SqlString(TBL_KAIJO.FIX_SEISAN_NTAX) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KAIJO.Column.KOUENKAI_ID & "='" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_BENTO

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_BENTO.*" _
        & " FROM TBL_BENTO"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_BENTO.ID"

        Public Shared Function byID(ByVal ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_BENTO.ID='" & CmnDb.SqlString(ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_BENTO As TableDef.TBL_BENTO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_BENTO"
            strSQL &= "(" & TableDef.TBL_BENTO.Column.ID
            strSQL &= "," & TableDef.TBL_BENTO.Column.KINKYU_FLG
            strSQL &= "," & TableDef.TBL_BENTO.Column.RAIJO_FLG
            strSQL &= "," & TableDef.TBL_BENTO.Column.AREA
            strSQL &= "," & TableDef.TBL_BENTO.Column.ADDRESS
            strSQL &= "," & TableDef.TBL_BENTO.Column.EIGYOSHO
            strSQL &= "," & TableDef.TBL_BENTO.Column.ZIP
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_NO
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_NAME
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_KANA
            strSQL &= "," & TableDef.TBL_BENTO.Column.INTERNAL_ORDER_T
            strSQL &= "," & TableDef.TBL_BENTO.Column.ACCOUNT_CODE_T
            strSQL &= "," & TableDef.TBL_BENTO.Column.TEL
            strSQL &= "," & TableDef.TBL_BENTO.Column.EMAIL
            strSQL &= "," & TableDef.TBL_BENTO.Column.SEND_SAKI_FS
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_MPID
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_NAME
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_KANA
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_SHISETSU_NAME
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_CD
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_SHISETSU_CD
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_ADDRESS
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_GOFFICIAL
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_YAKUWARI
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_NAME
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_DATE
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_BENTO.Column.KAIJO
            strSQL &= "," & TableDef.TBL_BENTO.Column.BU
            strSQL &= "," & TableDef.TBL_BENTO.Column.ACCOUNT_CODE
            strSQL &= "," & TableDef.TBL_BENTO.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_BENTO.Column.INTERNAL_ORDER
            strSQL &= "," & TableDef.TBL_BENTO.Column.ZETIA_CD
            strSQL &= "," & TableDef.TBL_BENTO.Column.STATUS_SHONIN
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_NAME
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_TIME
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_NOTE
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_NAME
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_TIME
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_NOTE
            strSQL &= "," & TableDef.TBL_BENTO.Column.STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_DATE
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_KIBOU_TIME
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_ADDRESS
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_SHISETSU
            strSQL &= "," & TableDef.TBL_BENTO.Column.SURYO
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANKA
            strSQL &= "," & TableDef.TBL_BENTO.Column.KIBOU_MAKER
            strSQL &= "," & TableDef.TBL_BENTO.Column.KIBOU_MENU
            strSQL &= "," & TableDef.TBL_BENTO.Column.NOTE
            strSQL &= "," & TableDef.TBL_BENTO.Column.ANS_STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_TIME
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_ADDRESS
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_SHISETSU
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_SURYO
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_TANKA
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_KINGAKU_TOTAL
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_MAKER
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_MAKER_CONTACT
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_KIBOU_MAKER
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_NOTE
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_BENTO.ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KINKYU_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.RAIJO_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.ZIP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.TANTO_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.TANTO_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.EMAIL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.SEND_SAKI_FS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_MPID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_GOFFICIAL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.DR_YAKUWARI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KAIJO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.BU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.COST_CENTER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.ZETIA_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.STATUS_SHONIN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.SHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.SHONIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.SHONIN_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_KIBOU_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_SHISETSU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.SURYO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.TANKA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KIBOU_MAKER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.KIBOU_MENU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_SHISETSU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_SURYO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_TANKA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_KINGAKU_TOTAL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER_CONTACT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_KIBOU_MAKER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_BENTO.FIX_NOTE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_BENTO As TableDef.TBL_BENTO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_BENTO SET"
            strSQL &= " " & TableDef.TBL_BENTO.Column.KINKYU_FLG & "='" & CmnDb.SqlString(TBL_BENTO.KINKYU_FLG) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.RAIJO_FLG & "='" & CmnDb.SqlString(TBL_BENTO.RAIJO_FLG) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.AREA & "='" & CmnDb.SqlString(TBL_BENTO.AREA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ADDRESS & "='" & CmnDb.SqlString(TBL_BENTO.ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.EIGYOSHO & "='" & CmnDb.SqlString(TBL_BENTO.EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ZIP & "='" & CmnDb.SqlString(TBL_BENTO.ZIP) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_NO & "='" & CmnDb.SqlString(TBL_BENTO.TANTO_NO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_NAME & "='" & CmnDb.SqlString(TBL_BENTO.TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_KANA & "='" & CmnDb.SqlString(TBL_BENTO.TANTO_KANA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.INTERNAL_ORDER_T & "='" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER_T) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ACCOUNT_CODE_T & "='" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE_T) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TEL & "='" & CmnDb.SqlString(TBL_BENTO.TEL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.EMAIL & "='" & CmnDb.SqlString(TBL_BENTO.EMAIL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SEND_SAKI_FS & "='" & CmnDb.SqlString(TBL_BENTO.SEND_SAKI_FS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_MPID & "='" & CmnDb.SqlString(TBL_BENTO.DR_MPID) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_NAME & "='" & CmnDb.SqlString(TBL_BENTO.DR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_KANA & "='" & CmnDb.SqlString(TBL_BENTO.DR_KANA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_SHISETSU_NAME & "='" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_CD & "='" & CmnDb.SqlString(TBL_BENTO.DR_CD) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_SHISETSU_CD & "='" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_CD) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_ADDRESS & "='" & CmnDb.SqlString(TBL_BENTO.DR_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_GOFFICIAL & "='" & CmnDb.SqlString(TBL_BENTO.DR_GOFFICIAL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_YAKUWARI & "='" & CmnDb.SqlString(TBL_BENTO.DR_YAKUWARI) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_NAME & "='" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_DATE & "='" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_DATE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KAIJO & "='" & CmnDb.SqlString(TBL_BENTO.KAIJO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.BU & "='" & CmnDb.SqlString(TBL_BENTO.BU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ACCOUNT_CODE & "='" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.COST_CENTER & "='" & CmnDb.SqlString(TBL_BENTO.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.INTERNAL_ORDER & "='" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ZETIA_CD & "='" & CmnDb.SqlString(TBL_BENTO.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.STATUS_SHONIN & "='" & CmnDb.SqlString(TBL_BENTO.STATUS_SHONIN) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_NAME & "='" & CmnDb.SqlString(TBL_BENTO.SHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_TIME & "='" & CmnDb.SqlString(TBL_BENTO.SHONIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_NOTE & "='" & CmnDb.SqlString(TBL_BENTO.SHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_NAME & "='" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_TIME & "='" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_NOTE & "='" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_BENTO.STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_DATE & "='" & CmnDb.SqlString(TBL_BENTO.HAITATSU_DATE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_KIBOU_TIME & "='" & CmnDb.SqlString(TBL_BENTO.HAITATSU_KIBOU_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_ADDRESS & "='" & CmnDb.SqlString(TBL_BENTO.HAITATSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_SHISETSU & "='" & CmnDb.SqlString(TBL_BENTO.HAITATSU_SHISETSU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SURYO & "='" & CmnDb.SqlString(TBL_BENTO.SURYO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANKA & "='" & CmnDb.SqlString(TBL_BENTO.TANKA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KIBOU_MAKER & "='" & CmnDb.SqlString(TBL_BENTO.KIBOU_MAKER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KIBOU_MENU & "='" & CmnDb.SqlString(TBL_BENTO.KIBOU_MENU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.NOTE & "='" & CmnDb.SqlString(TBL_BENTO.NOTE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ANS_STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_BENTO.ANS_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_TIME & "='" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_ADDRESS & "='" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_SHISETSU & "='" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_SHISETSU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_SURYO & "='" & CmnDb.SqlString(TBL_BENTO.FIX_SURYO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_TANKA & "='" & CmnDb.SqlString(TBL_BENTO.FIX_TANKA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_KINGAKU_TOTAL & "='" & CmnDb.SqlString(TBL_BENTO.FIX_KINGAKU_TOTAL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_MAKER & "='" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_MAKER_CONTACT & "='" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER_CONTACT) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_KIBOU_MAKER & "='" & CmnDb.SqlString(TBL_BENTO.FIX_KIBOU_MAKER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_NOTE & "='" & CmnDb.SqlString(TBL_BENTO.FIX_NOTE) & "'"
            strSQL &= " WHERE " & TableDef.TBL_BENTO.Column.ID & "='" & CmnDb.SqlString(TBL_BENTO.ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_SHISETSU

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_SHISETSU.*" _
        & " FROM MS_SHISETSU"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_SHISETSU.ID"

        Public Shared Function byID(ByVal ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SHISETSU.ID='" & CmnDb.SqlString(ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_SHISETSU"
            strSQL &= "(" & TableDef.MS_SHISETSU.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS1
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS2
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME
            strSQL &= "," & TableDef.MS_SHISETSU.Column.TEL
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKIN_TIME
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKOUT_TIME
            strSQL &= "," & TableDef.MS_SHISETSU.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_SHISETSU.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_SHISETSU.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_SHISETSU.SYSTEM_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.CHECKIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.CHECKOUT_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.STOP_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_SHISETSU SET"
            strSQL &= " " & TableDef.MS_SHISETSU.Column.ADDRESS1 & "='" & CmnDb.SqlString(MS_SHISETSU.ADDRESS1) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS2 & "='" & CmnDb.SqlString(MS_SHISETSU.ADDRESS2) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME & "='" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.TEL & "='" & CmnDb.SqlString(MS_SHISETSU.TEL) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKIN_TIME & "='" & CmnDb.SqlString(MS_SHISETSU.CHECKIN_TIME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKOUT_TIME & "='" & CmnDb.SqlString(MS_SHISETSU.CHECKOUT_TIME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.STOP_FLG & "='" & CmnDb.SqlString(MS_SHISETSU.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.INPUT_DATE & "='" & CmnDb.SqlString(MS_SHISETSU.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.INPUT_USER & "='" & CmnDb.SqlString(MS_SHISETSU.INPUT_USER) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_DATE & "='" & CmnDb.SqlString(MS_SHISETSU.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_USER & "='" & CmnDb.SqlString(MS_SHISETSU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_SHISETSU.Column.SYSTEM_ID & "='" & CmnDb.SqlString(MS_SHISETSU.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_USER

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_USER.*" _
        & " FROM MS_USER"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_USER.SYSTEM_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_USER.SYSTEM_ID='" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Login(ByVal LOGIN_ID As String, ByVal PASSWORD As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_USER.LOGIN_ID='" & CmnDb.SqlString(LOGIN_ID) & "'"
            strSQL &= " AND MS_USER.PASSWORD='" & CmnDb.SqlString(PASSWORD) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_USER As TableDef.MS_USER.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_USER"
            strSQL &= "(" & TableDef.MS_USER.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_USER.Column.LOGIN_ID
            strSQL &= "," & TableDef.MS_USER.Column.PASSWORD
            strSQL &= "," & TableDef.MS_USER.Column.KENGEN
            strSQL &= "," & TableDef.MS_USER.Column.USER_NAME
            strSQL &= "," & TableDef.MS_USER.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_USER.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_USER.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_USER.SYSTEM_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.LOGIN_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.PASSWORD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.KENGEN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.USER_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.STOP_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_USER.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_USER As TableDef.MS_USER.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_USER SET"
            strSQL &= " " & TableDef.MS_USER.Column.LOGIN_ID & "='" & CmnDb.SqlString(MS_USER.LOGIN_ID) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.PASSWORD & "='" & CmnDb.SqlString(MS_USER.PASSWORD) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.KENGEN & "='" & CmnDb.SqlString(MS_USER.KENGEN) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.USER_NAME & "='" & CmnDb.SqlString(MS_USER.USER_NAME) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.STOP_FLG & "='" & CmnDb.SqlString(MS_USER.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.INPUT_DATE & "='" & CmnDb.SqlString(MS_USER.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.INPUT_USER & "='" & CmnDb.SqlString(MS_USER.INPUT_USER) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_DATE & "='" & CmnDb.SqlString(MS_USER.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_USER & "='" & CmnDb.SqlString(MS_USER.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_USER.Column.SYSTEM_ID & "='" & CmnDb.SqlString(MS_USER.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_JIGYOSHO

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_JIGYOSHO.*" _
        & " FROM MS_JIGYOSHO"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_JIGYOSHO.SYSTEM_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_JIGYOSHO.SYSTEM_ID='" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_JIGYOSHO As TableDef.MS_JIGYOSHO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_JIGYOSHO"
            strSQL &= "(" & TableDef.MS_JIGYOSHO.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.未定
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_JIGYOSHO.SYSTEM_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_JIGYOSHO.未定) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_JIGYOSHO.STOP_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_JIGYOSHO.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_JIGYOSHO.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_JIGYOSHO.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_JIGYOSHO.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_JIGYOSHO As TableDef.MS_JIGYOSHO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_JIGYOSHO SET"
            strSQL &= " " & TableDef.MS_JIGYOSHO.Column.未定 & "='" & CmnDb.SqlString(MS_JIGYOSHO.未定) & "'"
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.STOP_FLG & "='" & CmnDb.SqlString(MS_JIGYOSHO.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.INPUT_DATE & "='" & CmnDb.SqlString(MS_JIGYOSHO.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.INPUT_USER & "='" & CmnDb.SqlString(MS_JIGYOSHO.INPUT_USER) & "'"
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.UPDATE_DATE & "='" & CmnDb.SqlString(MS_JIGYOSHO.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.MS_JIGYOSHO.Column.UPDATE_USER & "='" & CmnDb.SqlString(MS_JIGYOSHO.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_JIGYOSHO.Column.SYSTEM_ID & "='" & CmnDb.SqlString(MS_JIGYOSHO.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_AREA

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_AREA.*" _
        & " FROM MS_AREA"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_AREA.SYSTEM_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_AREA.SYSTEM_ID='" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_AREA As TableDef.MS_AREA.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_AREA"
            strSQL &= "(" & TableDef.MS_AREA.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_AREA.Column.未定
            strSQL &= "," & TableDef.MS_AREA.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_AREA.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_AREA.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_AREA.SYSTEM_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_AREA.未定) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_AREA.STOP_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_AREA.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_AREA.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_AREA.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_AREA.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_AREA As TableDef.MS_AREA.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_AREA SET"
            strSQL &= " " & TableDef.MS_AREA.Column.未定 & "='" & CmnDb.SqlString(MS_AREA.未定) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.STOP_FLG & "='" & CmnDb.SqlString(MS_AREA.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.INPUT_DATE & "='" & CmnDb.SqlString(MS_AREA.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.INPUT_USER & "='" & CmnDb.SqlString(MS_AREA.INPUT_USER) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_DATE & "='" & CmnDb.SqlString(MS_AREA.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_USER & "='" & CmnDb.SqlString(MS_AREA.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_AREA.Column.SYSTEM_ID & "='" & CmnDb.SqlString(MS_AREA.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_EIGYOSHO

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_EIGYOSHO.*" _
        & " FROM MS_EIGYOSHO"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_EIGYOSHO.SYSTEM_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_EIGYOSHO.SYSTEM_ID='" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_EIGYOSHO As TableDef.MS_EIGYOSHO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_EIGYOSHO"
            strSQL &= "(" & TableDef.MS_EIGYOSHO.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.未定
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_EIGYOSHO.SYSTEM_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_EIGYOSHO.未定) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_EIGYOSHO.STOP_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_EIGYOSHO.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_EIGYOSHO.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_EIGYOSHO.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_EIGYOSHO.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_EIGYOSHO As TableDef.MS_EIGYOSHO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_EIGYOSHO SET"
            strSQL &= " " & TableDef.MS_EIGYOSHO.Column.未定 & "='" & CmnDb.SqlString(MS_EIGYOSHO.未定) & "'"
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.STOP_FLG & "='" & CmnDb.SqlString(MS_EIGYOSHO.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.INPUT_DATE & "='" & CmnDb.SqlString(MS_EIGYOSHO.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.INPUT_USER & "='" & CmnDb.SqlString(MS_EIGYOSHO.INPUT_USER) & "'"
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.UPDATE_DATE & "='" & CmnDb.SqlString(MS_EIGYOSHO.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.UPDATE_USER & "='" & CmnDb.SqlString(MS_EIGYOSHO.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_EIGYOSHO.Column.SYSTEM_ID & "='" & CmnDb.SqlString(MS_EIGYOSHO.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_KENSAKU

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_KENSAKU.*" _
        & " FROM TBL_KENSAKU"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_KENSAKU.SYSTEM_ID"

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KENSAKU.SYSTEM_ID='" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KENSAKU As TableDef.TBL_KENSAKU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KENSAKU"
            strSQL &= "(" & TableDef.TBL_KENSAKU.Column.KOUENKAI_ID
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.AREA
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.EIGYOSHO
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.TANTO_NAME
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.TANTO_KANA
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.KOUENKAI_NAME
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.KOUENKAI_DATE
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.KOUENKAI_NO
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.TANTO_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_NO) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KENSAKU As TableDef.TBL_KENSAKU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KENSAKU SET"
            strSQL &= " " & TableDef.TBL_KENSAKU.Column.AREA & "='" & CmnDb.SqlString(TBL_KENSAKU.AREA) & "'"
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.EIGYOSHO & "='" & CmnDb.SqlString(TBL_KENSAKU.EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.TANTO_NAME & "='" & CmnDb.SqlString(TBL_KENSAKU.TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.TANTO_KANA & "='" & CmnDb.SqlString(TBL_KENSAKU.TANTO_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.KOUENKAI_NAME & "='" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.KOUENKAI_DATE & "='" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KENSAKU.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_NO) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KENSAKU.Column.KOUENKAI_ID & "='" & CmnDb.SqlString(TBL_KENSAKU.KOUENKAI_ID) & "'"

            Return strSQL
        End Function

    End Class

End Class
