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
        & ",TBL_KOUENKAI.TIME_STAMP"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_TIME_STAMP(ByVal KOUENKAI_NO As String, ByVal TIME_STAMP As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KOUENKAI.TIME_STAMP='" & CmnDb.SqlString(TIME_STAMP) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= " SELECT *"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " ) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI"

            If NewData = True Then
                '新着
                strSQL &= " WHERE " & TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG & " <>'1'"
                wFlag = True
            End If

            If Trim(Joken.KUBUN) = "A" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= " CNT = 1"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= " CNT > 1"
            End If

            If Trim(Joken.BU) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.BU
                strSQL &= " LIKE '%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
                strSQL &= " LIKE '%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
                strSQL &= " LIKE '%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
                strSQL &= " ='" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE '%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN '" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND '" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " ='" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " FROM_DATE='" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME
                strSQL &= " LIKE '%" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                If wFlag Then
                    strSQL &= " AND "
                Else
                    strSQL &= " WHERE "
                End If
                wFlag = True
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTANTO_ID
                strSQL &= " ='" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            strSQL &= " ORDER BY "
            If NewData Then
                '新着
                strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
                strSQL &= " DESC"
            Else
                '検索
                strSQL &= TableDef.TBL_KOUENKAI.Column.UPDATE_DATE
                strSQL &= " DESC"
            End If

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KOUENKAI"
            strSQL &= "(" & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TORIKESHI_FLG
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.FROM_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TO_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KAIJO_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_TF
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ZETIA_CD
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.BU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_PC
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_TEL
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_TF
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TIME_STAMP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TORIKESHI_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIDOKU_FLG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_TITLE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TAXI_PRT_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.FROM_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.TO_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KAIJO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.SEIHIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.ZETIA_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.SANKA_YOTEI_CNT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.BU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_ROMA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.COST_CENTER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOUENKAI.SEND_FLAG) & "'"
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
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TORIKESHI_FLG & "='" & CmnDb.SqlString(TBL_KOUENKAI.TORIKESHI_FLG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIDOKU_FLG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE & "='" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_TITLE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.TAXI_PRT_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.FROM_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.FROM_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TO_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.TO_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KAIJO_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.SEIHIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T & "='" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF & "='" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_T & "='" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_TF & "='" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ZETIA_CD & "='" & CmnDb.SqlString(TBL_KOUENKAI.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT & "='" & CmnDb.SqlString(TBL_KOUENKAI.SANKA_YOTEI_CNT) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.BU & "='" & CmnDb.SqlString(TBL_KOUENKAI.BU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_ROMA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_PC & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_KEITAI & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_TEL & "='" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.COST_CENTER & "='" & CmnDb.SqlString(TBL_KOUENKAI.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_TF & "='" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_T & "='" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEND_FLAG & "='" & CmnDb.SqlString(TBL_KOUENKAI.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTANTO_ID & "='" & CmnDb.SqlString(TBL_KOUENKAI.TTANTO_ID) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE & "='" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_USER & "='" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOUENKAI.Column.TIME_STAMP & "='" & CmnDb.SqlString(TBL_KOUENKAI.TIME_STAMP) & "'"

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

        Public Shared Function byKOUENKAI_NO_SEISAN_YM(ByVal KOUENKAI_NO As String, ByVal SEISAN_YM As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_SEIKYU.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_SEIKYU.SEISAN_YM='" & CmnDb.SqlString(SEISAN_YM) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_SEISAN_YM_PAYMENT_NO(ByVal KOUENKAI_NO As String, ByVal SEISAN_YM As String, ByVal PAYMENT_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_SEIKYU.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_SEIKYU.SEISAN_YM='" & CmnDb.SqlString(SEISAN_YM) & "'"
            strSQL &= " AND TBL_SEIKYU.PAYMENT_NO='" & CmnDb.SqlString(PAYMENT_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_SEIKYU"
            strSQL &= "(" & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_YM
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.PAYMENT_NO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_99133040_1
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UNEIHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JINKENHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_1
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JR_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTEL_COMMISSION_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_COMMISSION_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_2
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOUHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_99133040_2
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TICKET_URL
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_1
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_2
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_3
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_4
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_5
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_6
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_7
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_8
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_9
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_10
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_11
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_12
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_13
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_14
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_15
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_1
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_2
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_3
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_4
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_5
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_6
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_7
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_8
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_9
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_10
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_11
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_12
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_13
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_14
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_15
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_1
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_2
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_3
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_4
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_5
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_6
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_7
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_8
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_9
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_10
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_11
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_12
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_13
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_14
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_15
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_1
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_2
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_3
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_4
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_5
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_6
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_7
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_8
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_9
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_10
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_11
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_12
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_13
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_14
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_15
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_YM) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.PAYMENT_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_KUBUN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KEI_99133040_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.UNEIHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.JINKENHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.JR_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.HOTEL_COMMISSION_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_COMMISSION_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KEI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOUHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KEI_99133040_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.KEI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TICKET_URL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.TTANTO_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SEIKYU SET"
            strSQL &= " " & TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN & "='" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_KUBUN) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE & "='" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_99133040_1 & "='" & CmnDb.SqlString(TBL_SEIKYU.KEI_99133040_1) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UNEIHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.UNEIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JINKENHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.JINKENHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_1 & "='" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_1) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JR_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.JR_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.OTHER_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTEL_COMMISSION_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.HOTEL_COMMISSION_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_COMMISSION_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_COMMISSION_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_2 & "='" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_2) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_TF & "='" & CmnDb.SqlString(TBL_SEIKYU.KEI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOUHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.KAIJOUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_99133040_2 & "='" & CmnDb.SqlString(TBL_SEIKYU.KEI_99133040_2) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.KEI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR & "='" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_T & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_T & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TICKET_URL & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TICKET_URL) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_1 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_1) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_2 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_2) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_3 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_3) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_4 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_4) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_5 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_5) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_6 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_6) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_7 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_7) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_8 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_8) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_9 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_9) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_10 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_10) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_11 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_11) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_12 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_12) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_13 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_13) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_14 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_14) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR_15 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_JR_15) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_1 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_1) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_2 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_2) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_3 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_3) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_4 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_4) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_5 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_5) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_6 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_6) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_7 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_7) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_8 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_8) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_9 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_9) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_10 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_10) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_11 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_11) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_12 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_12) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_13 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_13) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_14 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_14) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_15 & "='" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_15) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_1 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_1) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_2 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_2) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_3 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_3) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_4 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_4) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_5 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_5) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_6 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_6) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_7 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_7) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_8 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_8) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_9 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_9) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_10 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_10) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_11 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_11) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_12 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_12) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_13 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_13) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_14 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_14) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF_15 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF_15) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_1 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_1) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_2 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_2) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_3 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_3) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_4 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_4) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_5 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_5) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_6 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_6) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_7 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_7) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_8 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_8) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_9 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_9) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_10 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_10) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_11 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_11) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_12 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_12) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_13 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_13) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_14 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_14) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF_15 & "='" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF_15) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEND_FLAG & "='" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TTANTO_ID & "='" & CmnDb.SqlString(TBL_SEIKYU.TTANTO_ID) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE & "='" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER & "='" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SEIKYU.Column.SEISAN_YM & "='" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_YM) & "'"
            strSQL &= " AND " & TableDef.TBL_SEIKYU.Column.PAYMENT_NO & "='" & CmnDb.SqlString(TBL_SEIKYU.PAYMENT_NO) & "'"

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

        Public Shared Function byKOUENKAI_NO_SANKASHA_ID(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO='" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KOTSUHOTEL.SANKASHA_ID='" & CmnDb.SqlString(SANKASHA_ID) & "'"
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
            strSQL &= "(" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_TOP
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_CD
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_KANA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SEX
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_AGE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHITEIGAI_RIYU
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_BU
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AREA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_PC
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_KEITAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_TEL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CD
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ZETIA_CD
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU1
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU2
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU3
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU4
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU5
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU1
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU2
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU3
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU4
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_KOTSU_BIKO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSU_BIKO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_FARE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_CANCELLATION
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_FARE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_CANCELLATION
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_FARE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_CANCELLATION
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_O_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_F_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEX
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AGE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_TEHAI_HOTEL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_SMOKING
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_O_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_F_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NAME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_ADDRESS
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_TEL
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_CHECKIN_TIME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_CHECKOUT_TIME
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_SMOKING
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_KOTSUHI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_TOP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_YAKUWARI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SEX) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_AGE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHITEIGAI_RIYU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SANKA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_BU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_ROMA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL_PC) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_FS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ACCOUNT_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.COST_CENTER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INTERNAL_ORDER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ZETIA_CD) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_DATE) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4) & "'"
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
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_KOTSU_BIKO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_KOTSU_BIKO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_FARE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_FARE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_FARE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_TAXI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_11) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_12) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_13) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_14) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_15) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_16) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_17) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_18) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_19) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_20) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_O_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_F_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEX) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AGE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_TEHAI_HOTEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_HOTEL_SMOKING) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_O_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_F_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_CHECKIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_CHECKOUT_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_SMOKING) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_KOTSUHI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTELHI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_FLAG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TTANTO_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_DATE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_TOP & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_TOP) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_CD & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_KANA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_KANA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_YAKUWARI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SEX & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SEX) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_AGE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_AGE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHITEIGAI_RIYU & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHITEIGAI_RIYU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SANKA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_BU & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_BU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AREA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EIGYOSHO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_ROMA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_PC & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL_PC) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_EMAIL_KEITAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KEITAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_TEL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_FS & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_FS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEND_SAKI_OTHER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ACCOUNT_CD & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ACCOUNT_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.COST_CENTER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INTERNAL_ORDER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.INTERNAL_ORDER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ZETIA_CD & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SHONIN_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_DATE) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_O_SEAT_KIBOU5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4) & "'"
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_F_SEAT_KIBOU5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_KOTSU_BIKO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_KOTSU_BIKO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSU_BIKO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_KOTSU_BIKO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_FARE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_CANCELLATION & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_FARE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_CANCELLATION & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_FARE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_CANCELLATION & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TEHAI_TAXI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_TAXI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_DATE_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_FROM_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TAXI_YOTEIKINGAKU_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_TAXI_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20 & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_O_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_O_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_F_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_F_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEX & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEX) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AGE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AGE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_TEHAI_HOTEL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_TEHAI_HOTEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_SMOKING & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_HOTEL_SMOKING) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_O_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_O_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_F_TEHAI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_F_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NAME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_ADDRESS & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_TEL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_CHECKIN_TIME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_CHECKIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_CHECKOUT_TIME & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_CHECKOUT_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_SMOKING & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_SMOKING) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NOTE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_KOTSUHI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_KOTSUHI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTELHI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TTANTO_ID & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TTANTO_ID) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_USER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_USER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_DATE) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "='" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"

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

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " TBL_KOUENKAI.*"
            strSQL &= ",TBL_KAIJO.TEHAI_ID"
            strSQL &= ",TBL_KAIJO.REQ_STATUS_TEHAI"
            strSQL &= ",TBL_KAIJO.ANS_STATUS_TEHAI"
            strSQL &= ",TBL_KAIJO.TIME_STAMP_BYL"
            strSQL &= ",TBL_KAIJO.TIME_STAMP_TOP"
            strSQL &= ",TBL_KAIJO.SHONIN_NAME"
            strSQL &= ",TBL_KAIJO.SHONIN_DATE"
            strSQL &= ",TBL_KAIJO.KAISAI_DATE_NOTE"
            strSQL &= ",TBL_KAIJO.KAISAI_KIBOU_ADDRESS1"
            strSQL &= ",TBL_KAIJO.KAISAI_KIBOU_ADDRESS2"
            strSQL &= ",TBL_KAIJO.KAISAI_KIBOU_NOTE"
            strSQL &= ",TBL_KAIJO.KOUEN_TIME1"
            strSQL &= ",TBL_KAIJO.KOUEN_TIME2"
            strSQL &= ",TBL_KAIJO.KOUEN_KAIJO_LAYOUT"
            strSQL &= ",TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI"
            strSQL &= ",TBL_KAIJO.IROUKAI_KAIJO_TEHAI"
            strSQL &= ",TBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT"
            strSQL &= ",TBL_KAIJO.KOUSHI_ROOM_TEHAI"
            strSQL &= ",TBL_KAIJO.SHAIN_ROOM_TEHAI"
            strSQL &= ",TBL_KAIJO.MANAGER_KAIJO_TEHAI"
            strSQL &= ",TBL_KAIJO.KAIJO_URL"
            strSQL &= ",TBL_KAIJO.OTHER_NOTE"
            strSQL &= ",TBL_KAIJO.ANS_SENTEI_RIYU"
            strSQL &= ",TBL_KAIJO.ANS_MITSUMORI_TF"
            strSQL &= ",TBL_KAIJO.ANS_MITSUMORI_T"
            strSQL &= ",TBL_KAIJO.ANS_MITSUMORI_TOTAL"
            strSQL &= ",TBL_KAIJO.ANS_MITSUMORI_URL"
            strSQL &= ",TBL_KAIJO.ANS_SHISETSU_NAME"
            strSQL &= ",TBL_KAIJO.ANS_SHISETSU_ZIP"
            strSQL &= ",TBL_KAIJO.ANS_SHISETSU_ADDRESS"
            strSQL &= ",TBL_KAIJO.ANS_SHISETSU_TEL"
            strSQL &= ",TBL_KAIJO.ANS_SHISETSU_URL"
            strSQL &= ",TBL_KAIJO.ANS_KOUEN_KAIJO_NAME"
            strSQL &= ",TBL_KAIJO.ANS_KOUEN_KAIJO_FLOOR"
            strSQL &= ",TBL_KAIJO.ANS_IKENKOUKAN_KAIJO_NAME"
            strSQL &= ",TBL_KAIJO.ANS_IROUKAI_KAIJO_NAME"
            strSQL &= ",TBL_KAIJO.ANS_KOUSHI_ROOM_NAME"
            strSQL &= ",TBL_KAIJO.ANS_SHAIN_ROOM_NAME"
            strSQL &= ",TBL_KAIJO.ANS_MANAGER_KAIJO_NAME"
            strSQL &= ",TBL_KAIJO.ANS_KAISAI_NOTE"
            strSQL &= ",TBL_KAIJO.ANS_SEISAN_TF"
            strSQL &= ",TBL_KAIJO.ANS_SEISAN_T"
            strSQL &= ",TBL_KAIJO.ANS_SEISANSHO_URL"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KAIJO.TEHAI_TANTO_TEL"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM (TBL_KOUENKAI"
            strSQL &= " LEFT JOIN TBL_KAIJO"
            strSQL &= " ON TBL_KOUENKAI.KOUENKAI_NO=TBL_KAIJO.KOUENKAI_NO)"
            strSQL &= " LEFT JOIN MS_USER"
            strSQL &= " ON TBL_KOUENKAI.TTANTO_ID=MS_USER.LOGIN_ID"

            strSQL &= " WHERE 1=1"

            If NewData = True Then
                '新着
                strSQL &= " AND ISNULL(TBL_KOUENKAI.KIDOKU_FLG,'')<>'1'"
            Else
                '検索
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.BU='" & CmnDb.SqlString(Joken.BU) & "'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KIKAKU_TANTO_AREA='" & CmnDb.SqlString(Joken.AREA) & "'"
            End If

            If Trim(Joken.EIGYOSHO) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO='" & CmnDb.SqlString(Joken.EIGYOSHO) & "'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.TTANTO_ID='" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KIKAKU_TANTO_ROMA LIKE '%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND TBL_KAIJO.TEHAI_TANTO_ROMA LIKE '%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.SEIHIN_NAME LIKE '%" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NO='" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NAME LIKE '%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE BETWEEN '" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND '" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE='" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE='" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            strSQL &= " ORDER BY"
            If NewData = True Then
                '新着
                strSQL &= " TBL_KOUENKAI.UPDATE_DATE DESC"
            Else
                '検索
                strSQL &= " TBL_KAIJO.UPDATE_DATE DESC"
            End If

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KAIJO"
            strSQL &= "(" & TableDef.TBL_KAIJO.Column.TEHAI_ID
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_KAIJO.Column.REQ_STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TIME_STAMP_BYL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TIME_STAMP_TOP
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_DATE_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME1
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME2
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_LAYOUT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IROUKAI_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IROUKAI_SANKA_YOTEI_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHAIN_ROOM_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAIJO_URL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.OTHER_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SENTEI_RIYU
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TOTAL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_URL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ZIP
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ADDRESS
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_TEL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_URL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_FLOOR
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_IKENKOUKAN_KAIJO_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_IROUKAI_KAIJO_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUSHI_ROOM_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHAIN_ROOM_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MANAGER_KAIJO_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAISAI_NOTE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SEISAN_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SEISAN_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SEISANSHO_URL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_BU
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_AREA
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_NAME
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_ROMA
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_PC
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_KEITAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_KEITAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_TEL
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_KAIJO.TEHAI_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.REQ_STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_BYL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_TOP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_DATE_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_LAYOUT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.IROUKAI_KAIJO_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SHAIN_ROOM_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TEHAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.KAIJO_URL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.OTHER_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SENTEI_RIYU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TOTAL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_URL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ZIP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ADDRESS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_URL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_FLOOR) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_IKENKOUKAN_KAIJO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_IROUKAI_KAIJO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUSHI_ROOM_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHAIN_ROOM_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_MANAGER_KAIJO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAISAI_NOTE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SEISAN_TF) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SEISAN_T) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.ANS_SEISANSHO_URL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_BU) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_AREA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_EIGYOSHO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_ROMA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_EMAIL_PC) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_KEITAI) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.SEND_FLAG) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.UPDATE_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_KAIJO.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KAIJO SET"
            strSQL &= " " & TableDef.TBL_KAIJO.Column.REQ_STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.REQ_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TIME_STAMP_TOP & "='" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_TOP) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHONIN_DATE & "='" & CmnDb.SqlString(TBL_KAIJO.SHONIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_DATE_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_DATE_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS1 & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_ADDRESS2 & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAISAI_KIBOU_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME1 & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME1) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_TIME2 & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME2) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUEN_KAIJO_LAYOUT & "='" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_LAYOUT) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IKENKOUKAN_KAIJO_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IROUKAI_KAIJO_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.IROUKAI_KAIJO_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.IROUKAI_SANKA_YOTEI_CNT & "='" & CmnDb.SqlString(TBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHAIN_ROOM_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.SHAIN_ROOM_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI & "='" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KAIJO_URL & "='" & CmnDb.SqlString(TBL_KAIJO.KAIJO_URL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.OTHER_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.OTHER_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SENTEI_RIYU & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SENTEI_RIYU) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TF & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_T & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TOTAL & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TOTAL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_URL & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_URL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ZIP & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ZIP) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ADDRESS & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_TEL & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_URL & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_URL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_FLOOR & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_FLOOR) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_IKENKOUKAN_KAIJO_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_IKENKOUKAN_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_IROUKAI_KAIJO_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_IROUKAI_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUSHI_ROOM_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUSHI_ROOM_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHAIN_ROOM_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SHAIN_ROOM_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MANAGER_KAIJO_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_MANAGER_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAISAI_NOTE & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_KAISAI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SEISAN_TF & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SEISAN_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SEISAN_T & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SEISAN_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SEISANSHO_URL & "='" & CmnDb.SqlString(TBL_KAIJO.ANS_SEISANSHO_URL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_BU & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_BU) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_AREA & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EIGYOSHO & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_NAME & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_ROMA & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_ROMA) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_PC & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_EMAIL_PC) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_EMAIL_KEITAI & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_KEITAI & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_TANTO_TEL & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_TANTO_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEND_FLAG & "='" & CmnDb.SqlString(TBL_KAIJO.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_DATE & "='" & CmnDb.SqlString(TBL_KAIJO.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_USER & "='" & CmnDb.SqlString(TBL_KAIJO.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KAIJO.Column.TEHAI_ID & "='" & CmnDb.SqlString(TBL_KAIJO.TEHAI_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.KOUENKAI_NO & "='" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.TIME_STAMP_BYL & "='" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_BYL) & "'"

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
        & " MS_SHISETSU.SYSTEM_ID"

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SHISETSU.SYSTEM_ID='" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE ISNULL(MS_SHISETSU.STOP_FLG,'')<>'1'"

            If Trim(Joken.ADDRESS1) <> "" Then
                strSQL &= " AND MS_SHISETSU.ADDRESS1='" & CmnDb.SqlString(Joken.ADDRESS1) & "'"
            End If

            If Trim(Joken.ADDRESS2) <> "" Then
                strSQL &= " AND MS_SHISETSU.ADDRESS2 LIKE '%" & CmnDb.SqlString(Joken.ADDRESS2) & "%'"
            End If

            If Trim(Joken.SHISETSU_NAME) <> "" Then
                strSQL &= " AND MS_SHISETSU.SHISETSU_NAME LIKE '%" & CmnDb.SqlString(Joken.SHISETSU_NAME) & "%'"
            End If

            If Trim(Joken.SHISETSU_NAME_KANA) <> "" Then
                strSQL &= " AND MS_SHISETSU.SHISETSU_NAME_KANA LIKE '%" & CmnDb.SqlString(Joken.SHISETSU_NAME_KANA) & "%'"
            End If

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_SHISETSU"
            strSQL &= "(" & TableDef.MS_SHISETSU.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ZIP
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS1
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS2
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_KANA
            strSQL &= "," & TableDef.MS_SHISETSU.Column.TEL
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKIN_TIME
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKOUT_TIME
            strSQL &= "," & TableDef.MS_SHISETSU.Column.URL
            strSQL &= "," & TableDef.MS_SHISETSU.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_SHISETSU.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_SHISETSU.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_SHISETSU.SYSTEM_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.ZIP) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS1) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS2) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_KANA) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.TEL) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.CHECKIN_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.CHECKOUT_TIME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.URL) & "'"
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
            strSQL &= " " & TableDef.MS_SHISETSU.Column.ZIP & "='" & CmnDb.SqlString(MS_SHISETSU.ZIP) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS1 & "='" & CmnDb.SqlString(MS_SHISETSU.ADDRESS1) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS2 & "='" & CmnDb.SqlString(MS_SHISETSU.ADDRESS2) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME & "='" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_KANA & "='" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_KANA) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.TEL & "='" & CmnDb.SqlString(MS_SHISETSU.TEL) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKIN_TIME & "='" & CmnDb.SqlString(MS_SHISETSU.CHECKIN_TIME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKOUT_TIME & "='" & CmnDb.SqlString(MS_SHISETSU.CHECKOUT_TIME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.URL & "='" & CmnDb.SqlString(MS_SHISETSU.URL) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.STOP_FLG & "='" & CmnDb.SqlString(MS_SHISETSU.STOP_FLG) & "'"
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

        Public Shared Function byLOGIN_ID(ByVal LOGIN_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_USER.LOGIN_ID='" & CmnDb.SqlString(LOGIN_ID) & "'"
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

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE 1=1"

            If Trim(Joken.LOGIN_ID) <> "" Then
                strSQL &= " AND MS_USER.LOGIN_ID='" & CmnDb.SqlString(Joken.LOGIN_ID) & "'"
            End If
            If Trim(Joken.USER_NAME) <> "" Then
                strSQL &= " AND MS_USER.USER_NAME LIKE '%" & CmnDb.SqlString(Joken.USER_NAME) & "%'"
            End If
            If Trim(Joken.KENGEN) <> "" Then
                strSQL &= " AND MS_USER.KENGEN='" & CmnDb.SqlString(Joken.KENGEN) & "'"
            End If
            If Trim(Joken.STOP_FLG) <> "" Then
                strSQL &= " AND MS_USER.STOP_FLG='" & CmnDb.SqlString(Joken.STOP_FLG) & "'"
            End If

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function MaxSYSTEM_ID() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT CONVERT(INT,SYSTEM_ID) AS SYSTEM_ID FROM MS_USER"
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
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.UPDATE_DATE & "='" & CmnDb.SqlString(MS_EIGYOSHO.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.MS_EIGYOSHO.Column.UPDATE_USER & "='" & CmnDb.SqlString(MS_EIGYOSHO.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_EIGYOSHO.Column.SYSTEM_ID & "='" & CmnDb.SqlString(MS_EIGYOSHO.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_CODE

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_CODE.*" _
        & " FROM MS_CODE"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_CODE.CODE" _
        & ",MS_CODE.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCODE(ByVal CODE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_CODE.CODE='" & CmnDb.SqlString(CODE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCODE_DATA_ID(ByVal CODE As String, ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_CODE.CODE='" & CmnDb.SqlString(CODE) & "'"
            strSQL &= " AND MS_CODE.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_CODE As TableDef.MS_CODE.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_CODE"
            strSQL &= "(" & TableDef.MS_CODE.Column.CODE
            strSQL &= "," & TableDef.MS_CODE.Column.DATA_ID
            strSQL &= "," & TableDef.MS_CODE.Column.DISP_TEXT
            strSQL &= "," & TableDef.MS_CODE.Column.DISP_VALUE
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(MS_CODE.CODE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_CODE.DATA_ID) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_CODE.DISP_TEXT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(MS_CODE.DISP_VALUE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_CODE As TableDef.MS_CODE.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_CODE SET"
            strSQL &= " " & TableDef.MS_CODE.Column.DISP_TEXT & "='" & CmnDb.SqlString(MS_CODE.DISP_TEXT) & "'"
            strSQL &= "," & TableDef.MS_CODE.Column.DISP_VALUE & "='" & CmnDb.SqlString(MS_CODE.DISP_VALUE) & "'"
            strSQL &= " WHERE " & TableDef.MS_CODE.Column.CODE & "='" & CmnDb.SqlString(MS_CODE.CODE) & "'"
            strSQL &= " AND" & TableDef.MS_CODE.Column.DATA_ID & "='" & CmnDb.SqlString(MS_CODE.DATA_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_LOG

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_LOG.*" _
        & " FROM TBL_LOG"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_LOG.INPUT_DATE"

        Public Shared Function byINPUT_DATE(ByVal INPUT_DATE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_LOG.INPUT_DATE='" & CmnDb.SqlString(INPUT_DATE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_LOG"
            strSQL &= "(" & TableDef.TBL_LOG.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_LOG.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_LOG.Column.SYORI_KBN
            strSQL &= "," & TableDef.TBL_LOG.Column.SYORI_NAME
            strSQL &= "," & TableDef.TBL_LOG.Column.TABLE_NAME
            strSQL &= "," & TableDef.TBL_LOG.Column.STATUS
            strSQL &= "," & TableDef.TBL_LOG.Column.NOTE
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_LOG.INPUT_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_LOG.INPUT_USER) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_LOG.SYORI_KBN) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_LOG.SYORI_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_LOG.TABLE_NAME) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_LOG.STATUS) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_LOG.NOTE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_LOG SET"
            strSQL &= " " & TableDef.TBL_LOG.Column.INPUT_USER & "='" & CmnDb.SqlString(TBL_LOG.INPUT_USER) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.SYORI_KBN & "='" & CmnDb.SqlString(TBL_LOG.SYORI_KBN) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.SYORI_NAME & "='" & CmnDb.SqlString(TBL_LOG.SYORI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.TABLE_NAME & "='" & CmnDb.SqlString(TBL_LOG.TABLE_NAME) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.STATUS & "='" & CmnDb.SqlString(TBL_LOG.STATUS) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.NOTE & "='" & CmnDb.SqlString(TBL_LOG.NOTE) & "'"
            strSQL &= " WHERE" & TableDef.TBL_LOG.Column.INPUT_DATE & "='" & CmnDb.SqlString(TBL_LOG.INPUT_DATE) & "'"

            Return strSQL
        End Function

    End Class

End Class
