﻿Imports CommonLib
Imports AppLib
Imports System.Collections.Specialized

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

            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            'strSQL &= SQL_ORDERBY
            strSQL &= " ORDER BY"
            strSQL &= " TBL_KOUENKAI.TIME_STAMP DESC"

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO2(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_TIME_STAMP(ByVal KOUENKAI_NO As String, ByVal TIME_STAMP As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KOUENKAI.TIME_STAMP=N'" & CmnDb.SqlString(TIME_STAMP) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byNEW_TIME_STAMP(ByVal KOUENKAI_NO As String, ByVal TIME_STAMP As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT COUNT(*) AS CNT"
            strSQL &= " FROM TBL_KOUENKAI"
            strSQL &= " WHERE "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP & ">N'" & CmnDb.SqlString(TIME_STAMP) & "'"

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_UPDATE_DATE_DESC(ByVal KOUENKAI_NO As String, ByVal UPDATE_DATE As String) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT *"
            strSQL &= ", USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(TBL_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " TBL_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO & "=N'" & KOUENKAI_NO & "'"
            strSQL &= " AND"
            strSQL &= " TBL_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE & "<N'" & UPDATE_DATE & "'"

            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.UPDATE_DATE
            strSQL &= " DESC"

            Return strSQL
        End Function

        Public Shared Function byKey(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT"
            strSQL &= " WK_KOUENKAI.BU"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.TIME_STAMP"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", WK_KOUENKAI.SEIHIN_NAME"
            strSQL &= ", WK_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ", USER_NAME"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " ) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND "
                strSQL &= " CNT = 1"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND "
                strSQL &= " CNT > 1"
            End If

            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= "='" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"

            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= "='" & CmnDb.SqlString(Joken.TIME_STAMP) & "'"
            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE
            strSQL &= "='" & CmnDb.SqlString(Joken.KOUENKAI_TITLE) & "'"

            Return strSQL
        End Function

        Public Shared Function byKey_AllItem(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT"
            strSQL &= " WK_KOUENKAI.*"
            strSQL &= ", USER_NAME"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " ) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            'strSQL &= " AND"
            'strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            'strSQL &= " SELECT MAX(TIME_STAMP)"
            'strSQL &= " FROM"
            'strSQL &= " TBL_KOUENKAI"
            'strSQL &= " WHERE"
            'strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            'strSQL &= " )"

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND "
                strSQL &= " CNT = 1"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND "
                strSQL &= " CNT > 1"
            End If

            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= "='" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"

            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= "='" & CmnDb.SqlString(Joken.TIME_STAMP) & "'"

            If CmnDb.SqlString(Joken.KOUENKAI_TITLE) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE
                strSQL &= "='" & CmnDb.SqlString(Joken.KOUENKAI_TITLE) & "'"
            End If

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT *"
            strSQL &= ", USER_NAME"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " ) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            If NewData = True Then
                '新着
                strSQL &= " AND " & TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG & " <>N'" & AppConst.KAIJO.KIDOKU_FLG.Code.Yes & "'"
                strSQL &= " AND CNT > 1"
            End If

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND "
                strSQL &= " CNT = 1"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND "
                strSQL &= " CNT > 1"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
                'strSQL &= " =N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
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

        Public Shared Function Search_KeyItem(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= ", WK_KOUENKAI.TIME_STAMP"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ", WK_KOUENKAI.KIDOKU_FLG"
            strSQL &= ", WK_KOUENKAI.BU"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.SEIHIN_NAME"
            strSQL &= ", WK_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ", USER_NAME"
            strSQL &= ", CNT"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " DESC) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            If NewData = True Then
                '新着
                strSQL &= " AND " & TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG & " <>N'" & AppConst.KAIJO.KIDOKU_FLG.Code.Yes & "'"
                strSQL &= " AND CNT = 1"
            End If

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND "
                strSQL &= " CNT = 1"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND "
                strSQL &= " CNT > 1"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
                'strSQL &= " =N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
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

        Public Shared Function Search_DelData(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT *"
            strSQL &= ", USER_NAME"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " ) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            If Trim(Joken.FROM_DATE) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= "<= '" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            End If

            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO

            Return strSQL
        End Function

        Public Shared Function Rireki(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT *"
            strSQL &= ", USER_NAME"
            strSQL &= " FROM"
            strSQL &= " (SELECT *,"
            strSQL &= " ROW_NUMBER() OVER( PARTITION BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " ) CNT"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI)"
            strSQL &= " WK_KOUENKAI, "

            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " =N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"

            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP
            strSQL &= " DESC"

            Return strSQL
        End Function

        Public Shared Function TaxiPrintCsv(ByVal pKOUENKAI_NO As String) As String
            Dim strSQL As String = ""
            'Dim strSQL_WHERE_KOTSUHOTEL As String = ""
            'Dim strSQL_WHERE_KOUENKAI As String = ""
            Dim wFrom As String = pKOUENKAI_NO & "-00000000"
            Dim wTo As String = pKOUENKAI_NO & "-99999999"

            strSQL = "SELECT DISTINCT"
            strSQL &= " TBL_KOUENKAI.KOUENKAI_NO,"
            strSQL &= " TBL_KOUENKAI.TAXI_PRT_NAME,"
            strSQL &= " TBL_KOUENKAI.FROM_DATE,"
            strSQL &= " TBL_KOUENKAI.TO_DATE"
            strSQL &= " FROM"
            strSQL &= " (SELECT TBL_KOTSUHOTEL_1.* FROM"
            strSQL &= " (SELECT"
            strSQL &= " TIME_STAMP_BYL,"
            strSQL &= " KOUENKAI_NO,"
            strSQL &= " SALEFORCE_ID,"
            strSQL &= " SANKASHA_ID,"
            strSQL &= " DR_MPID"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL"
            strSQL &= " WHERE"
            strSQL &= " TBL_KOTSUHOTEL.KOUENKAI_NO BETWEEN '" & wFrom & "' AND '" & wTo & "' AND"
            strSQL &= " (ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19,N'')<>N'' OR"
            strSQL &= " ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20,N'')<>N'')"
            strSQL &= ") AS TBL_KOTSUHOTEL_1 JOIN"
            strSQL &= " (SELECT"
            strSQL &= " MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL_2,"
            strSQL &= " KOUENKAI_NO AS KOUENKAI_NO_2,"
            strSQL &= " SALEFORCE_ID AS SALEFORCE_ID_2,"
            strSQL &= " SANKASHA_ID AS SANKASHA_ID_2,"
            strSQL &= " DR_MPID AS DR_MPID_2"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL"
            strSQL &= " GROUP BY"
            strSQL &= " KOUENKAI_NO,"
            strSQL &= " SALEFORCE_ID,"
            strSQL &= " SANKASHA_ID,"
            strSQL &= " DR_MPID"
            strSQL &= ") AS TBL_KOTSUHOTEL_2"
            strSQL &= " ON"
            strSQL &= " TBL_KOTSUHOTEL_1.TIME_STAMP_BYL=TBL_KOTSUHOTEL_2.TIME_STAMP_BYL_2 AND"
            strSQL &= " TBL_KOTSUHOTEL_1.KOUENKAI_NO=TBL_KOTSUHOTEL_2.KOUENKAI_NO_2 AND"
            strSQL &= " TBL_KOTSUHOTEL_1.SALEFORCE_ID=TBL_KOTSUHOTEL_2.SALEFORCE_ID_2 AND"
            strSQL &= " TBL_KOTSUHOTEL_1.SANKASHA_ID=TBL_KOTSUHOTEL_2.SANKASHA_ID_2   AND"
            strSQL &= " TBL_KOTSUHOTEL_1.DR_MPID=TBL_KOTSUHOTEL_2.DR_MPID_2"
            strSQL &= " ) AS TBL_KOTSUHOTEL"
            strSQL &= " JOIN"
            strSQL &= " (SELECT TBL_KOUENKAI_1.* FROM TBL_KOUENKAI AS TBL_KOUENKAI_1"
            strSQL &= " JOIN"
            strSQL &= " (SELECT"
            strSQL &= " MAX(TIME_STAMP) AS TIME_STAMP,"
            strSQL &= " KOUENKAI_NO"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " GROUP BY"
            strSQL &= " KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI_2"
            strSQL &= " ON"
            strSQL &= " TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO AND"
            strSQL &= " TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= " ON"
            strSQL &= " TBL_KOTSUHOTEL.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ORDER BY"
            strSQL &= " TBL_KOUENKAI.KOUENKAI_NO DESC"

            '' ''WHERE
            '' ''交通宿泊手配テーブル
            ' ''strSQL_WHERE_KOTSUHOTEL &= " WHERE ("
            '' ''strSQL_WHERE_KOTSUHOTEL &= " WHERE (TBL_KOTSUHOTEL.KOUENKAI_NO BETWEEN '' AND ''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= "    ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20,N'')<>N''"

            '' '' ''strSQL_WHERE_KOTSUHOTEL &= "    ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19,N'')<>N''"
            '' '' ''strSQL_WHERE_KOTSUHOTEL &= " OR ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20,N'')=N'1' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20,N'')=N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20,N'')<>N'' AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20,N'')<>N''"
            ' ''strSQL_WHERE_KOTSUHOTEL &= ")"

            '' ''会合テーブル
            ' ''strSQL_WHERE_KOUENKAI &= " WHERE 1=1"
            '' ''strSQL_WHERE_KOUENKAI &= " WHERE TBL_KOUENKAI.KOUENKAI_NO BETWEEN '' AND ''"

            ' ''strSQL &= "SELECT"
            ' ''strSQL &= " DISTINCT"
            ' ''strSQL &= " TBL_KOUENKAI.KOUENKAI_NO"
            ' ''strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            ' ''strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            ' ''strSQL &= ",TBL_KOUENKAI.TO_DATE"
            ' ''strSQL &= " FROM"
            ' ''strSQL &= "("
            ' ''strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            ' ''strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            ' ''strSQL &= strSQL_WHERE_KOUENKAI
            ' ''strSQL &= ") AS TBL_KOUENKAI_1"
            ' ''strSQL &= "  ,"
            ' ''strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            ' ''strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            ' ''strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            ' ''strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            ' ''strSQL &= ") AS TBL_KOUENKAI"
            ' ''strSQL &= ","
            ' ''strSQL &= "("
            ' ''strSQL &= " SELECT TBL_KOTSUHOTEL_1.* FROM "
            ' ''strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL"
            ' ''strSQL &= strSQL_WHERE_KOTSUHOTEL
            ' ''strSQL &= ") AS TBL_KOTSUHOTEL_1"
            ' ''strSQL &= "  ,"
            ' ''strSQL &= " (SELECT MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL,KOUENKAI_NO,SALEFORCE_ID,SANKASHA_ID,DR_MPID FROM TBL_KOTSUHOTEL"
            ' ''strSQL &= " GROUP BY KOUENKAI_NO,SALEFORCE_ID,SANKASHA_ID,DR_MPID) AS TBL_KOTSUHOTEL_2"
            ' ''strSQL &= "  WHERE TBL_KOTSUHOTEL_1.TIME_STAMP_BYL=TBL_KOTSUHOTEL_2.TIME_STAMP_BYL"
            ' ''strSQL &= "   AND TBL_KOTSUHOTEL_1.KOUENKAI_NO=TBL_KOTSUHOTEL_2.KOUENKAI_NO"
            ' ''strSQL &= "   AND TBL_KOTSUHOTEL_1.SALEFORCE_ID=TBL_KOTSUHOTEL_2.SALEFORCE_ID"
            ' ''strSQL &= "   AND TBL_KOTSUHOTEL_1.SANKASHA_ID=TBL_KOTSUHOTEL_2.SANKASHA_ID"
            ' ''strSQL &= "   AND TBL_KOTSUHOTEL_1.DR_MPID=TBL_KOTSUHOTEL_2.DR_MPID"
            ' ''strSQL &= ") AS TBL_KOTSUHOTEL"
            ' ''strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            ' ''strSQL &= " ORDER BY"
            '' ''14.9.3 tanaka
            ' ''strSQL &= " TBL_KOUENKAI.KOUENKAI_NO DESC"
            '' ''strSQL &= " TBL_KOUENKAI.KOUENKAI_NO ASC"

            Return strSQL
        End Function

        Public Shared Function TaxiMeisaiCsv_1(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= " FROM"
            strSQL &= "(SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= " WHERE 1=1"
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= ","
            strSQL &= "(SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ",TBL_TAXITICKET_HAKKO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_TAXITICKET_HAKKO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= "   AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND ("
                strSQL &= "      TBL_KOUENKAI.KIKAKU_TANTO_NAME LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
                strSQL &= "      OR "
                strSQL &= "      TBL_KOUENKAI.KIKAKU_TANTO_ROMA LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
                strSQL &= ")"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND ("
                strSQL &= "      TBL_KOUENKAI.TEHAI_TANTO_NAME LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
                strSQL &= "      OR "
                strSQL &= "      TBL_KOUENKAI.TEHAI_TANTO_ROMA LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
                strSQL &= ")"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.SEIHIN_NAME=N'" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NO LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NAME LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE=N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE=N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.BU=N'" & CmnDb.SqlString(Joken.BU) & "'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KIKAKU_TANTO_AREA=N'" & CmnDb.SqlString(Joken.AREA) & "'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.TTANTO_ID=N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Trim(Joken.TKT_ENTA) = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Igai Then
                strSQL &= "   AND ISNULL(TBL_TAXITICKET_HAKKO.TKT_ENTA,N'')<>N'N'"
            ElseIf Trim(Joken.TKT_ENTA) = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Only Then
                strSQL &= "   AND ISNULL(TBL_TAXITICKET_HAKKO.TKT_ENTA,N'')=N'N'"
            End If

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KOUENKAI.FROM_DATE ASC"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NO ASC"

            Return strSQL
        End Function

        Public Shared Function TaxiMeisaiCsv(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.UPDATE_DATE"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= " FROM"
            strSQL &= "(SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= " WHERE 1=1"
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= ","
            strSQL &= "(SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ",TBL_TAXITICKET_HAKKO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_TAXITICKET_HAKKO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= "   AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND ("
                strSQL &= "      TBL_KOUENKAI.KIKAKU_TANTO_NAME LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
                strSQL &= "      OR "
                strSQL &= "      TBL_KOUENKAI.KIKAKU_TANTO_ROMA LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
                strSQL &= ")"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND ("
                strSQL &= "      TBL_KOUENKAI.TEHAI_TANTO_NAME LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
                strSQL &= "      OR "
                strSQL &= "      TBL_KOUENKAI.TEHAI_TANTO_ROMA LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
                strSQL &= ")"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.SEIHIN_NAME=N'" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NO LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NAME LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE=N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.FROM_DATE=N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.BU=N'" & CmnDb.SqlString(Joken.BU) & "'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.KIKAKU_TANTO_AREA=N'" & CmnDb.SqlString(Joken.AREA) & "'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.TTANTO_ID=N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Trim(Joken.TTEHAI_TANTO) <> "" Then
                strSQL &= " AND TBL_KOUENKAI.TTEHAI_TANTO=N'" & CmnDb.SqlString(Joken.TTEHAI_TANTO) & "'"
            End If

            If Trim(Joken.TKT_ENTA) = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Igai Then
                strSQL &= "   AND ISNULL(TBL_TAXITICKET_HAKKO.TKT_ENTA,N'')<>N'N'"
            ElseIf Trim(Joken.TKT_ENTA) = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Only Then
                strSQL &= "   AND ISNULL(TBL_TAXITICKET_HAKKO.TKT_ENTA,N'')=N'N'"
            End If

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KOUENKAI.FROM_DATE ASC"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NO ASC"

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
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT_NMBR
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT_MBR
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SRM_HACYU_KBN
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.BU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_JIGYOUBU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_PC
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_TEL
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.COST_CENTER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_PC
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_TEL
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_TF
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.IROUKAI_YOSAN_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.IKENKOUKAN_YOSAN_T
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.DANTAI_CODE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_USER
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.WBS_ELEMENT
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TIME_STAMP) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TORIKESHI_FLG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIDOKU_FLG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_TITLE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TAXI_PRT_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.FROM_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TO_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KAIJO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.SEIHIN_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.ZETIA_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.SRM_HACYU_KBN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.BU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_AREA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_ROMA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KEITAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.COST_CENTER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_BU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_AREA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_ROMA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_KEITAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.IROUKAI_YOSAN_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.IKENKOUKAN_YOSAN_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.DANTAI_CODE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TTEHAI_TANTO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.SEND_FLAG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.TTANTO_ID) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOUENKAI.WBS_ELEMENT) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOUENKAI SET"
            strSQL &= " " & TableDef.TBL_KOUENKAI.Column.TORIKESHI_FLG & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TORIKESHI_FLG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIDOKU_FLG & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIDOKU_FLG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_TITLE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TAXI_PRT_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.FROM_DATE & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.FROM_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TO_DATE & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TO_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KAIJO_NAME & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.SEIHIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_T & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.INTERNAL_ORDER_TF & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.INTERNAL_ORDER_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_T & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ACCOUNT_CD_TF & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.ACCOUNT_CD_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.ZETIA_CD & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT_NMBR & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SANKA_YOTEI_CNT_MBR & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SRM_HACYU_KBN & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.SRM_HACYU_KBN) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.BU & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.BU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_JIGYOUBU & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_ROMA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_PC & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EMAIL_KEITAI & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_KEITAI & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_TEL & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KIKAKU_TANTO_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.COST_CENTER & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_BU) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_AREA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EIGYOSHO & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_NAME & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_ROMA) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_PC & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_EMAIL_KEITAI & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_KEITAI & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_KEITAI) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_TEL & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TEHAI_TANTO_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_TF & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_TF) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.YOSAN_T & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.YOSAN_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.IROUKAI_YOSAN_T & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.IROUKAI_YOSAN_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.IKENKOUKAN_YOSAN_T & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.IKENKOUKAN_YOSAN_T) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.DANTAI_CODE & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.DANTAI_CODE) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TTEHAI_TANTO) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.TTANTO_ID & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TTANTO_ID) & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOUENKAI.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOUENKAI.Column.TIME_STAMP & "=N'" & CmnDb.SqlString(TBL_KOUENKAI.TIME_STAMP) & "'"

            Return strSQL
        End Function

        Public Shared Function Migragion(ByVal KOUENKAI_NO As String, ByVal OrgDbName As String, ByVal PastDbName As String) As String
            Dim strSQL As String = ""

            strSQL = "SELECT * INTO " & PastDbName & ".TBL_KOUENKAI"
            strSQL &= " FROM " & OrgDbName & ".TBL_KOUENKAI"
            strSQL &= " WHERE " & OrgDbName & ".TBL_KOUENKAI.KOUENKAI_NO='" & KOUENKAI_NO & "'"

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

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

            strSQL &= " WHERE TBL_SEIKYU.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(ByVal KOUENKAI_NO As String, ByVal SEIKYU_NO_TOPTOUR As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_SEIKYU.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_SEIKYU.SEIKYU_NO_TOPTOUR=N'" & CmnDb.SqlString(SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySEND_FLAG(ByVal SEND_FLAG As String) As String
            Dim strSQL As String = ""
            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_SEIKYU.*"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= " FROM"
            strSQL &= " (SELECT "
            strSQL &= "   TSK.KOUENKAI_NO"
            strSQL &= "  ,TSK.SEISAN_YM"
            strSQL &= "  ,TSK.KAIJOHI_TF"
            strSQL &= "  ,TSK.KIZAIHI_TF"
            strSQL &= "  ,TSK.INSHOKUHI_TF"
            strSQL &= "  ,TSK.KEI_991330401_TF"
            strSQL &= "  ,TSK.HOTELHI_TF"
            strSQL &= "  ,TSK.HOTELHI_TOZEI"
            strSQL &= "  ,TSK.JR_TF"
            strSQL &= "  ,TSK.AIR_TF"
            strSQL &= "  ,TSK.OTHER_TRAFFIC_TF"
            strSQL &= "  ,TSK.TAXI_TF"
            strSQL &= "  ,TSK.HOTEL_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_SEISAN_TF"
            strSQL &= "  ,TSK.JINKENHI_TF"
            strSQL &= "  ,TSK.OTHER_TF"
            strSQL &= "  ,TSK.KANRIHI_TF"
            strSQL &= "  ,TSK.KEI_41120200_TF"
            strSQL &= "  ,TSK.KEI_TF"
            strSQL &= "  ,TSK.KAIJOUHI_T"
            strSQL &= "  ,TSK.KIZAIHI_T"
            strSQL &= "  ,TSK.INSHOKUHI_T"
            strSQL &= "  ,TSK.IROUKAIHI_T"
            strSQL &= "  ,TSK.KEI_991330401_T"
            strSQL &= "  ,TSK.JINKENHI_T"
            strSQL &= "  ,TSK.OTHER_T"
            strSQL &= "  ,TSK.KANRIHI_T"
            strSQL &= "  ,TSK.KEI_41120200_T"
            strSQL &= "  ,TSK.KEI_T"
            strSQL &= "  ,TSK.SEIKYU_NO_TOPTOUR"
            strSQL &= "  ,TSK.TAXI_T"
            strSQL &= "  ,TSK.TAXI_SEISAN_T"
            strSQL &= "  ,TSK.SEISANSHO_URL"
            strSQL &= "  ,TSK.TAXI_TICKET_URL"
            strSQL &= "  ,TSK.SEISAN_KANRYO"
            strSQL &= "  ,TSK.MR_JR"
            strSQL &= "  ,TSK.MR_HOTEL"
            strSQL &= "  ,TSK.MR_HOTEL_TOZEI"
            strSQL &= "  ,TSK.SEND_FLAG"
            strSQL &= "  ,TSK.TTANTO_ID"
            strSQL &= "  ,TSK.INPUT_DATE"
            strSQL &= "  ,TSK.INPUT_USER"
            strSQL &= "  ,TSK.UPDATE_DATE"
            strSQL &= "  ,TSK.UPDATE_USER"
            strSQL &= "  ,TSK.SEISAN_DANTAI"
            strSQL &= "  ,TSN.SHIHARAI_NO"
            strSQL &= "  ,TSN.SHOUNIN_KUBUN"
            strSQL &= "  ,TSN.SHOUNIN_DATE"
            strSQL &= "  FROM TBL_SEIKYU TSK"
            strSQL &= "  LEFT JOIN TBL_SHOUNIN TSN"
            strSQL &= "   ON TSK.KOUENKAI_NO = TSN.KOUENKAI_NO"
            strSQL &= "   AND TSK.SEIKYU_NO_TOPTOUR = TSN.SEIKYU_NO_TOPTOUR"
            strSQL &= "   ) WK_SEIKYU"
            strSQL &= ",TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_SEIKYU.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_SEIKYU.SEND_FLAG=N'" & CmnDb.SqlString(SEND_FLAG) & "'"
            strSQL &= " ORDER BY"
            strSQL &= " WK_SEIKYU.KOUENKAI_NO,"
            strSQL &= " WK_SEIKYU.SEIKYU_NO_TOPTOUR DESC"

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK_SEIKYU.*"
            strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",WK_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",WK_KOUENKAI.BU"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",WK_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= ",WK_KOUENKAI.TO_DATE"
            strSQL &= ",WK_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",WK_KOUENKAI.KAIJO_NAME"
            strSQL &= ",WK_KAIJO.TEHAI_ID"
            strSQL &= ",USER_NAME"
            strSQL &= " FROM"
            strSQL &= " (SELECT "
            strSQL &= "   TSK.KOUENKAI_NO"
            strSQL &= "  ,TSK.SEISAN_YM"
            strSQL &= "  ,TSK.KAIJOHI_TF"
            strSQL &= "  ,TSK.KIZAIHI_TF"
            strSQL &= "  ,TSK.INSHOKUHI_TF"
            strSQL &= "  ,TSK.KEI_991330401_TF"
            strSQL &= "  ,TSK.HOTELHI_TF"
            strSQL &= "  ,TSK.HOTELHI_TOZEI"
            strSQL &= "  ,TSK.JR_TF"
            strSQL &= "  ,TSK.AIR_TF"
            strSQL &= "  ,TSK.OTHER_TRAFFIC_TF"
            strSQL &= "  ,TSK.TAXI_TF"
            strSQL &= "  ,TSK.HOTEL_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_SEISAN_TF"
            strSQL &= "  ,TSK.JINKENHI_TF"
            strSQL &= "  ,TSK.OTHER_TF"
            strSQL &= "  ,TSK.KANRIHI_TF"
            strSQL &= "  ,TSK.KEI_41120200_TF"
            strSQL &= "  ,TSK.KEI_TF"
            strSQL &= "  ,TSK.KAIJOUHI_T"
            strSQL &= "  ,TSK.KIZAIHI_T"
            strSQL &= "  ,TSK.INSHOKUHI_T"
            strSQL &= "  ,TSK.IROUKAIHI_T"
            strSQL &= "  ,TSK.KEI_991330401_T"
            strSQL &= "  ,TSK.JINKENHI_T"
            strSQL &= "  ,TSK.OTHER_T"
            strSQL &= "  ,TSK.KANRIHI_T"
            strSQL &= "  ,TSK.KEI_41120200_T"
            strSQL &= "  ,TSK.KEI_T"
            strSQL &= "  ,TSK.SEIKYU_NO_TOPTOUR"
            strSQL &= "  ,TSK.TAXI_T"
            strSQL &= "  ,TSK.TAXI_SEISAN_T"
            strSQL &= "  ,TSK.SEISANSHO_URL"
            strSQL &= "  ,TSK.TAXI_TICKET_URL"
            strSQL &= "  ,TSK.SEISAN_KANRYO"
            strSQL &= "  ,TSK.MR_JR"
            strSQL &= "  ,TSK.MR_HOTEL"
            strSQL &= "  ,TSK.MR_HOTEL_TOZEI"
            strSQL &= "  ,TSK.SEND_FLAG"
            strSQL &= "  ,TSK.TTANTO_ID"
            strSQL &= "  ,TSK.INPUT_DATE"
            strSQL &= "  ,TSK.INPUT_USER"
            strSQL &= "  ,TSK.UPDATE_DATE"
            strSQL &= "  ,TSK.UPDATE_USER"
            strSQL &= "  ,TSK.SEISAN_DANTAI"
            strSQL &= "  ,TSN.SHIHARAI_NO"
            strSQL &= "  ,TSN.SHOUNIN_KUBUN"
            strSQL &= "  ,TSN.SHOUNIN_DATE"
            strSQL &= "  FROM TBL_SEIKYU TSK"
            strSQL &= "  LEFT JOIN TBL_SHOUNIN TSN"
            strSQL &= "   ON TSK.KOUENKAI_NO = TSN.KOUENKAI_NO"
            strSQL &= "   AND TSK.SEIKYU_NO_TOPTOUR = TSN.SEIKYU_NO_TOPTOUR"
            strSQL &= "   ) WK_SEIKYU"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK1"
            strSQL &= "   WHERE  WK1.TIME_STAMP = "
            strSQL &= "   (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "    WHERE TBL_KOUENKAI.KOUENKAI_NO = WK1.KOUENKAI_NO)"
            strSQL &= "  )WK_KOUENKAI"
            strSQL &= " ON WK_SEIKYU.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KAIJO WK1"
            strSQL &= "   WHERE "
            strSQL &= "   WK1.TIME_STAMP_BYL=("
            strSQL &= "    SELECT MAX(WK2.TIME_STAMP_BYL)"
            strSQL &= "    FROM"
            strSQL &= "    TBL_KAIJO WK2"
            strSQL &= "    WHERE"
            strSQL &= "    WK1.KOUENKAI_NO=WK2.KOUENKAI_NO)"
            strSQL &= " ) WK_KAIJO"
            strSQL &= "  ON WK_SEIKYU.KOUENKAI_NO = WK_KAIJO.KOUENKAI_NO"
            strSQL &= " LEFT JOIN "
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= "   UNION ALL "
            strSQL &= "  SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS WK_USER"
            strSQL &= " ON ISNULL(WK_KOUENKAI.TTEHAI_TANTO,N'')=WK_USER.LOGIN_ID"
            strSQL &= " WHERE 1=1"

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_SEIKYU."
                strSQL &= TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
                strSQL &= " =N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.SEIKYU_NO_TOPTOUR) <> "" Then
                strSQL &= " AND WK_SEIKYU."
                strSQL &= TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEIKYU_NO_TOPTOUR) & "'"
            End If

            If Trim(Joken.SEISAN_YM) <> "" Then
                strSQL &= " AND WK_SEIKYU."
                strSQL &= TableDef.TBL_SEIKYU.Column.SEISAN_YM
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEISAN_YM) & "'"
            End If

            If Trim(Joken.SHOUNIN_KUBUN) <> "" Then
                strSQL &= " AND ISNULL(WK_SEIKYU."
                strSQL &= TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN
                strSQL &= ",N'')"

                If Joken.SHOUNIN_KUBUN = AppConst.SEISAN.SHOUNIN_KUBUN.Code.Mi Then
                    strSQL &= " =N''"
                Else
                    strSQL &= " =N'" & CmnDb.SqlString(Joken.SHOUNIN_KUBUN) & "'"
                End If
            End If

            If Trim(Joken.SEND_FLAG) <> "" Then
                strSQL &= " AND ISNULL(WK_SEIKYU."
                strSQL &= TableDef.TBL_SEIKYU.Column.SEND_FLAG
                strSQL &= ",N'')"

                'If Joken.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi Then
                '    strSQL &= " =N''"
                'Else
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEND_FLAG) & "'"
                'End If
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            strSQL &= " ORDER BY"
            strSQL &= " WK_SEIKYU.SEISAN_YM DESC"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= ",WK_SEIKYU.KOUENKAI_NO"
            strSQL &= ",WK_SEIKYU.SEIKYU_NO_TOPTOUR"

            Return strSQL
        End Function

        Public Shared Function SearchGroupByKouenkai(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK_KOUENKAI.*"
            strSQL &= ",WK_USER.USER_NAME"
            'strSQL &= ",ISNULL(WK_SEIKYU.SEISAN_KANRYO,'0') AS SEISAN_KANRYO"
            strSQL &= ",ISNULL(WK_SEIKYU.SEISAN_KANRYO,'') AS SEISAN_KANRYO"
            strSQL &= " FROM"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK1"
            strSQL &= "   WHERE  WK1.TIME_STAMP = "
            strSQL &= "   (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "    WHERE TBL_KOUENKAI.KOUENKAI_NO = WK1.KOUENKAI_NO)"
            strSQL &= " )WK_KOUENKAI"
            strSQL &= " LEFT JOIN "
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= "   UNION ALL "
            strSQL &= "  SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS WK_USER"
            strSQL &= " ON ISNULL(WK_KOUENKAI.TTEHAI_TANTO,N'')=WK_USER.LOGIN_ID"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT KOUENKAI_NO,MAX(SEISAN_KANRYO) AS SEISAN_KANRYO FROM TBL_SEIKYU"
            strSQL &= "  GROUP BY KOUENKAI_NO"
            strSQL &= " ) WK_SEIKYU"
            strSQL &= " ON WK_KOUENKAI.KOUENKAI_NO = WK_SEIKYU.KOUENKAI_NO"
            strSQL &= " WHERE 1= 1"

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
                'strSQL &= " =N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.SEIHIN_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            strSQL &= " ORDER BY WK_KOUENKAI."
            strSQL &= TableDef.TBL_KOUENKAI.Column.TIME_STAMP & " DESC"
            strSQL &= ",WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO

            Return strSQL
        End Function

        Public Shared Function MaxSEISAN_NO() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT MAX(CONVERT(BIGINT,SEIKYU_NO_TOPTOUR)) AS SEIKYU_NO_TOPTOUR FROM TBL_SEIKYU"
            Return strSQL
        End Function

        Public Shared Function SapCsvMain(ByVal fromDate As String, ByVal toDate As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK_SEIKYU.*"
            strSQL &= ",WK_KOUENKAI.*"
            strSQL &= " FROM"
            strSQL &= " (SELECT"
            strSQL &= "   TSK.KOUENKAI_NO"
            strSQL &= "  ,TSK.SEIKYU_NO_TOPTOUR"
            strSQL &= "  ,TSK.KEI_T"
            strSQL &= "  ,TSK.IROUKAIHI_T"
            strSQL &= "  ,TSK.KAIJOHI_TF"
            strSQL &= "  ,TSK.INSHOKUHI_TF"
            strSQL &= "  ,TSK.KIZAIHI_TF"
            strSQL &= "  ,TSK.HOTELHI_TF"
            strSQL &= "  ,TSK.HOTELHI_TOZEI"
            strSQL &= "  ,TSK.AIR_TF"
            strSQL &= "  ,TSK.JR_TF"
            strSQL &= "  ,TSK.OTHER_TRAFFIC_TF"
            strSQL &= "  ,TSK.JINKENHI_TF"
            strSQL &= "  ,TSK.KANRIHI_TF"
            strSQL &= "  ,TSK.HOTEL_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_COMMISSION_TF"
            strSQL &= "  ,TSK.OTHER_TF"
            strSQL &= "  ,TSK.TAXI_TF"
            strSQL &= "  ,TSK.TAXI_SEISAN_TF"
            strSQL &= "  ,TSK.KEI_TF"
            strSQL &= "  ,TSK.SEISAN_DANTAI"
            strSQL &= "  ,TSN.SHIHARAI_NO"
            strSQL &= "  FROM TBL_SEIKYU TSK"
            strSQL &= "  LEFT JOIN TBL_SHOUNIN TSN"
            strSQL &= "   ON TSK.KOUENKAI_NO = TSN.KOUENKAI_NO"
            strSQL &= "   AND TSK.SEIKYU_NO_TOPTOUR = TSN.SEIKYU_NO_TOPTOUR"
            strSQL &= "  WHERE TSN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            strSQL &= "  AND TSN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            strSQL &= " ) WK_SEIKYU"
            strSQL &= " LEFT JOIN"
            strSQL &= "  (SELECT "
            strSQL &= "    WK1.KOUENKAI_NO"
            strSQL &= "   ,WK1.KOUENKAI_NAME"
            strSQL &= "   ,WK1.FROM_DATE"
            strSQL &= "   ,WK1.TO_DATE"
            strSQL &= "   ,WK1.COST_CENTER"
            strSQL &= "   ,WK1.ACCOUNT_CD_T"
            strSQL &= "   ,WK1.ACCOUNT_CD_TF"
            strSQL &= "   ,WK1.INTERNAL_ORDER_T"
            strSQL &= "   ,WK1.INTERNAL_ORDER_TF"
            strSQL &= "   ,WK1.ZETIA_CD"
            strSQL &= "   ,WK1.SRM_HACYU_KBN"
            strSQL &= "   ,WK1.DANTAI_CODE"
            strSQL &= "   ,WK1.KIKAKU_TANTO_NAME"
            strSQL &= "   ,WK1.WBS_ELEMENT"
            strSQL &= "    FROM TBL_KOUENKAI WK1"
            strSQL &= "    WHERE  WK1.TIME_STAMP = "
            strSQL &= "     (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "       WHERE TBL_KOUENKAI.KOUENKAI_NO = WK1.KOUENKAI_NO)"
            strSQL &= "      )WK_KOUENKAI"
            strSQL &= " ON WK_SEIKYU.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ORDER BY WK_SEIKYU.KOUENKAI_NO,WK_SEIKYU.SHIHARAI_NO"

            Return strSQL
        End Function

        Public Shared Function SapCsvMrRyohi(ByVal kouenkaiNo As String, ByVal seisanNo As String) As String
            Dim strSQL As String = ""

            'strSQL &= "SELECT"
            'strSQL &= " WK2.COST_CENTER"
            'strSQL &= ",WK2.ACCOUNT_CD"
            'strSQL &= ",WK2.INTERNAL_ORDER"
            'strSQL &= ",WK2.ZETIA_CD"
            'strSQL &= ",SUM(CAST(ISNULL(WK2.ANS_MR_HOTELHI,'0') AS BIGINT) + CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'0') AS BIGINT)) AS ANS_MR_HOTELHI"
            'strSQL &= ",SUM(CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'0') AS BIGINT)) AS ANS_MR_HOTELHI_TOZEI"
            'strSQL &= " FROM"
            'strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            'strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            'strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            'strSQL &= "  ) WK1"
            'strSQL &= " LEFT JOIN"
            'strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            'strSQL &= "   ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            'strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            'strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            'strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            'strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            'strSQL &= " WHERE"
            'strSQL &= " WK1.KOUENKAI_NO = N'" & CmnDb.SqlString(kouenkaiNo) & "'"
            'strSQL &= " AND WK2.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(seisanNo) & "'"
            'strSQL &= " AND (CAST(ISNULL(WK2.ANS_MR_HOTELHI,'') AS BIGINT) + CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'') AS BIGINT) + CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'') AS BIGINT)) <> 0"
            'strSQL &= " GROUP BY WK2.COST_CENTER,WK2.ACCOUNT_CD,WK2.INTERNAL_ORDER,WK2.ZETIA_CD"
            'strSQL &= " ORDER BY WK2.COST_CENTER"

            strSQL &= "SELECT"
            strSQL &= " WK2.COST_CENTER"
            strSQL &= ",WK2.ACCOUNT_CD"
            strSQL &= ",WK2.INTERNAL_ORDER"
            strSQL &= ",WK2.ZETIA_CD"
            strSQL &= ",WK2.WBS_ELEMENT"
            strSQL &= ",SUM(CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'0') AS BIGINT)) AS ANS_MR_KOTSUHI"
            strSQL &= ",SUM(CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'0') AS BIGINT)) AS ANS_MR_HOTELHI_TOZEI"
            strSQL &= " FROM"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "   ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " WHERE"
            strSQL &= " WK1.KOUENKAI_NO = N'" & CmnDb.SqlString(kouenkaiNo) & "'"
            strSQL &= " AND WK2.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(seisanNo) & "'"
            strSQL &= " AND (CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'') AS BIGINT)) <> 0"
            strSQL &= " GROUP BY WK2.COST_CENTER,WK2.ACCOUNT_CD,WK2.INTERNAL_ORDER,WK2.ZETIA_CD,WK2.WBS_ELEMENT"
            strSQL &= " ORDER BY WK2.COST_CENTER"

            Return strSQL
        End Function

        ' 2014/12/11 ADD
        Public Shared Function SapCsvMrHotelhi(ByVal kouenkaiNo As String, ByVal seisanNo As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK2.COST_CENTER"
            strSQL &= ",WK2.ACCOUNT_CD"
            strSQL &= ",WK2.INTERNAL_ORDER"
            strSQL &= ",WK2.WBS_ELEMENT"
            strSQL &= ",WK2.ZETIA_CD"
            strSQL &= ",SUM(CAST(ISNULL(WK2.ANS_MR_HOTELHI,'0') AS BIGINT)) AS ANS_MR_HOTELHI"
            strSQL &= ",SUM(CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'0') AS BIGINT)) AS ANS_MR_HOTELHI_TOZEI"
            strSQL &= " FROM"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "   ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " WHERE"
            strSQL &= " WK1.KOUENKAI_NO = N'" & CmnDb.SqlString(kouenkaiNo) & "'"
            strSQL &= " AND WK2.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(seisanNo) & "'"
            strSQL &= " AND (CAST(ISNULL(WK2.ANS_MR_HOTELHI,'') AS BIGINT) + CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'') AS BIGINT)) <> 0"
            strSQL &= " GROUP BY WK2.COST_CENTER,WK2.ACCOUNT_CD,WK2.INTERNAL_ORDER,WK2.ZETIA_CD,WK2.WBS_ELEMENT"
            strSQL &= " ORDER BY WK2.COST_CENTER"

            Return strSQL
        End Function

        Public Shared Function SapEvidenceCsv(ByVal fromDate As String, ByVal toDate As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK_SEIKYU.*"
            strSQL &= ",WK_KOUENKAI.*"
            strSQL &= " FROM"
            strSQL &= " (SELECT"
            strSQL &= "   TSK.KOUENKAI_NO"
            strSQL &= "  ,TSK.SEISAN_YM"
            strSQL &= "  ,TSK.KAIJOHI_TF"
            strSQL &= "  ,TSK.KIZAIHI_bTF"
            strSQL &= "  ,TSK.INSHOKUHI_TF"
            strSQL &= "  ,TSK.KEI_991330401_TF"
            strSQL &= "  ,TSK.HOTELHI_TF"
            strSQL &= "  ,TSK.HOTELHI_TOZEI"
            strSQL &= "  ,TSK.JR_TF"
            strSQL &= "  ,TSK.AIR_TF"
            strSQL &= "  ,TSK.OTHER_TRAFFIC_TF"
            strSQL &= "  ,TSK.TAXI_TF"
            strSQL &= "  ,TSK.HOTEL_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_SEISAN_TF"
            strSQL &= "  ,TSK.JINKENHI_TF"
            strSQL &= "  ,TSK.OTHER_TF"
            strSQL &= "  ,TSK.KANRIHI_TF"
            strSQL &= "  ,TSK.KEI_41120200_TF"
            strSQL &= "  ,TSK.KEI_TF"
            strSQL &= "  ,TSK.KAIJOUHI_T"
            strSQL &= "  ,TSK.KIZAIHI_T"
            strSQL &= "  ,TSK.INSHOKUHI_T"
            strSQL &= "  ,TSK.IROUKAIHI_T"
            strSQL &= "  ,TSK.KEI_991330401_T"
            strSQL &= "  ,TSK.JINKENHI_T"
            strSQL &= "  ,TSK.OTHER_T"
            strSQL &= "  ,TSK.KANRIHI_T"
            strSQL &= "  ,TSK.KEI_41120200_T"
            strSQL &= "  ,TSK.KEI_T"
            strSQL &= "  ,TSK.SEIKYU_NO_TOPTOUR"
            strSQL &= "  ,TSK.TAXI_T"
            strSQL &= "  ,TSK.TAXI_SEISAN_T"
            strSQL &= "  ,TSK.SEISANSHO_URL"
            strSQL &= "  ,TSK.TAXI_TICKET_URL"
            strSQL &= "  ,TSK.SEISAN_KANRYO"
            strSQL &= "  ,TSK.MR_JR"
            strSQL &= "  ,TSK.MR_HOTEL"
            strSQL &= "  ,TSK.MR_HOTEL_TOZEI"
            strSQL &= "  ,TSN.SHIHARAI_NO"
            strSQL &= "  ,TSN.SHOUNIN_KUBUN"
            strSQL &= "  ,TSN.SHOUNIN_DATE"
            strSQL &= "  FROM TBL_SEIKYU TSK"
            strSQL &= "  LEFT JOIN TBL_SHOUNIN TSN"
            strSQL &= "   ON TSK.KOUENKAI_NO = TSN.KOUENKAI_NO"
            strSQL &= "   AND TSK.SEIKYU_NO_TOPTOUR = TSN.SEIKYU_NO_TOPTOUR"
            strSQL &= "  WHERE TSN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            strSQL &= "  AND TSN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            strSQL &= " ) WK_SEIKYU"
            strSQL &= " LEFT JOIN"
            strSQL &= "  (SELECT "
            strSQL &= "    WK1.KOUENKAI_NO"
            strSQL &= "   ,WK1.KOUENKAI_NAME"
            strSQL &= "    FROM TBL_KOUENKAI WK1"
            strSQL &= "    WHERE  WK1.TIME_STAMP = "
            strSQL &= "     (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "       WHERE TBL_KOUENKAI.KOUENKAI_NO = WK1.KOUENKAI_NO)"
            strSQL &= "      )WK_KOUENKAI"
            strSQL &= " ON WK_SEIKYU.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ORDER BY WK_SEIKYU.KOUENKAI_NO,WK_SEIKYU.SHIHARAI_NO"

            Return strSQL
        End Function

        Public Shared Function KaigouEvidenceCsv(ByVal fromDate As String, ByVal toDate As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK_SEIKYU.*"
            strSQL &= ",WK_KOUENKAI.*"
            strSQL &= " FROM"
            strSQL &= " (SELECT"
            strSQL &= "   TSK.KOUENKAI_NO"
            strSQL &= "  ,TSK.SEISAN_YM"
            strSQL &= "  ,TSK.KAIJOHI_TF"
            strSQL &= "  ,TSK.KIZAIHI_TF"
            strSQL &= "  ,TSK.INSHOKUHI_TF"
            strSQL &= "  ,TSK.KEI_991330401_TF"
            strSQL &= "  ,TSK.HOTELHI_TF"
            strSQL &= "  ,TSK.HOTELHI_TOZEI"
            strSQL &= "  ,TSK.JR_TF"
            strSQL &= "  ,TSK.AIR_TF"
            strSQL &= "  ,TSK.OTHER_TRAFFIC_TF"
            strSQL &= "  ,TSK.TAXI_TF"
            strSQL &= "  ,TSK.HOTEL_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_COMMISSION_TF"
            strSQL &= "  ,TSK.TAXI_SEISAN_TF"
            strSQL &= "  ,TSK.JINKENHI_TF"
            strSQL &= "  ,TSK.OTHER_TF"
            strSQL &= "  ,TSK.KANRIHI_TF"
            strSQL &= "  ,TSK.KEI_41120200_TF"
            strSQL &= "  ,TSK.KEI_TF"
            strSQL &= "  ,TSK.KAIJOUHI_T"
            strSQL &= "  ,TSK.KIZAIHI_T"
            strSQL &= "  ,TSK.INSHOKUHI_T"
            strSQL &= "  ,TSK.IROUKAIHI_T"
            strSQL &= "  ,TSK.KEI_991330401_T"
            strSQL &= "  ,TSK.JINKENHI_T"
            strSQL &= "  ,TSK.OTHER_T"
            strSQL &= "  ,TSK.KANRIHI_T"
            strSQL &= "  ,TSK.KEI_41120200_T"
            strSQL &= "  ,TSK.KEI_T"
            strSQL &= "  ,TSK.SEIKYU_NO_TOPTOUR"
            strSQL &= "  ,TSK.TAXI_T"
            strSQL &= "  ,TSK.TAXI_SEISAN_T"
            strSQL &= "  ,TSK.SEISANSHO_URL"
            strSQL &= "  ,TSK.TAXI_TICKET_URL"
            strSQL &= "  ,TSK.SEISAN_KANRYO"
            strSQL &= "  ,TSK.MR_JR"
            strSQL &= "  ,TSK.MR_HOTEL"
            strSQL &= "  ,TSK.MR_HOTEL_TOZEI"
            strSQL &= "  ,TSK.SEND_FLAG"
            strSQL &= "  ,TSK.UPDATE_DATE"
            strSQL &= "  ,TSN.SHIHARAI_NO"
            strSQL &= "  ,TSN.SHOUNIN_KUBUN"
            strSQL &= "  ,TSN.SHOUNIN_DATE"
            strSQL &= "  FROM TBL_SEIKYU TSK"
            strSQL &= "  LEFT JOIN TBL_SHOUNIN TSN"
            strSQL &= "   ON TSK.KOUENKAI_NO = TSN.KOUENKAI_NO"
            strSQL &= "   AND TSK.SEIKYU_NO_TOPTOUR = TSN.SEIKYU_NO_TOPTOUR"
            strSQL &= "  WHERE TSN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            strSQL &= "  AND TSN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            strSQL &= " ) WK_SEIKYU"
            strSQL &= " LEFT JOIN"
            strSQL &= "  (SELECT "
            strSQL &= "    WK1.KOUENKAI_NO"
            strSQL &= "   ,WK1.KOUENKAI_NAME"
            strSQL &= "   ,WK1.FROM_DATE"
            strSQL &= "   ,WK1.KAIJO_NAME"
            strSQL &= "   ,WK1.SEIHIN_NAME"
            strSQL &= "   ,WK1.INTERNAL_ORDER_T"
            strSQL &= "   ,WK1.INTERNAL_ORDER_TF"
            strSQL &= "   ,WK1.ACCOUNT_CD_T"
            strSQL &= "   ,WK1.ACCOUNT_CD_TF"
            strSQL &= "   ,WK1.COST_CENTER"
            strSQL &= "   ,WK1.ZETIA_CD"
            strSQL &= "   ,WK1.SRM_HACYU_KBN"
            strSQL &= "   ,WK1.BU"
            strSQL &= "   ,WK1.KIKAKU_TANTO_AREA"
            strSQL &= "   ,WK1.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= "   ,WK1.KIKAKU_TANTO_NAME"
            strSQL &= "   ,WK1.TEHAI_TANTO_BU"
            strSQL &= "   ,WK1.TEHAI_TANTO_AREA"
            strSQL &= "   ,WK1.TEHAI_TANTO_EIGYOSHO"
            strSQL &= "   ,WK1.TEHAI_TANTO_NAME"
            strSQL &= "   ,WK1.WBS_ELEMENT"
            strSQL &= "    FROM TBL_KOUENKAI WK1"
            strSQL &= "    WHERE  WK1.TIME_STAMP = "
            strSQL &= "     (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "       WHERE TBL_KOUENKAI.KOUENKAI_NO = WK1.KOUENKAI_NO)"
            strSQL &= "      )WK_KOUENKAI"
            strSQL &= " ON WK_SEIKYU.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ORDER BY WK_SEIKYU.KOUENKAI_NO,WK_SEIKYU.SHIHARAI_NO"

            Return strSQL
        End Function

        Public Shared Function MishuHoukoku(ByVal MISHU_JOKEN() As TableDef.MISHU_JOKEN.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_SEIKYU.*"
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.FROM_DATE
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TO_DATE
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.DANTAI_CODE
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME

            strSQL &= " , USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_SEIKYU AS WK_SEIKYU"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " ,"
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_SEIKYU.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"

            If Not MISHU_JOKEN Is Nothing Then
                Dim i As Integer = 0
                For i = 0 To UBound(MISHU_JOKEN)
                    If i = 0 Then
                        strSQL &= " AND ("
                    Else
                        strSQL &= " OR"
                    End If
                    strSQL &= " WK_SEIKYU."
                    strSQL &= TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
                    strSQL &= "=N'" & MISHU_JOKEN(i).KOUENKAI_NO & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_SEIKYU."
                    strSQL &= TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR
                    strSQL &= "=N'" & MISHU_JOKEN(i).SEIKYU_NO_TOPTOUR & "'"
                Next i
                strSQL &= ")"
            End If

            'strSQL &= " AND"
            'strSQL &= " WK_SEIKYU."
            'strSQL &= TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN
            'strSQL &= "=N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"

            Return strSQL
        End Function

        Public Shared Function Mikanryou(ByVal JOKEN As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_SEIKYU." & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
            strSQL &= " ,WK_SEIKYU." & TableDef.TBL_SEIKYU.Column.SEISAN_KANRYO
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.BU
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_AREA
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_EIGYOSHO
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KIKAKU_TANTO_NAME
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.FROM_DATE
            strSQL &= " ,WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TO_DATE

            strSQL &= " FROM"
            strSQL &= " TBL_SEIKYU AS WK_SEIKYU"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_SEIKYU.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"

            strSQL &= " AND"
            strSQL &= " WK_SEIKYU."
            strSQL &= TableDef.TBL_SEIKYU.Column.SEISAN_KANRYO
            strSQL &= "=N''"
            'strSQL &= "=N'" & CmnConst.Flag.Off & "'"

            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI."
            strSQL &= TableDef.TBL_KOUENKAI.Column.TO_DATE
            strSQL &= "<=N'" & JOKEN.TO_DATE & "'"

            strSQL &= " ORDER BY"
            strSQL &= " WK_KOUENKAI."
            strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_SEIKYU"
            strSQL &= "(" & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHIHARAI_NO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_YM
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_991330401_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TOZEI
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JR_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.AIR_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_TRAFFIC_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTEL_COMMISSION_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_COMMISSION_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JINKENHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KANRIHI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_TF
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOUHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.IROUKAIHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_991330401_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JINKENHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KANRIHI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_T
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISANSHO_URL
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TICKET_URL
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_KANRYO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_TOZEI
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_DANTAI
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SHIHARAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_YM) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_KUBUN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_991330401_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TOZEI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.JR_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.AIR_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_TRAFFIC_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.HOTEL_COMMISSION_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_COMMISSION_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.JINKENHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KANRIHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOUHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.IROUKAIHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_991330401_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.JINKENHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KANRIHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEISANSHO_URL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TICKET_URL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_KANRYO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_TOZEI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.TTANTO_ID) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_DANTAI) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function InsertSEIKYU_NO(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_SEIKYU"
            strSQL &= " (" & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_YM
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_YM) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SEIKYU SET"
            strSQL &= " " & TableDef.TBL_SEIKYU.Column.SEISAN_YM & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_YM) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOHI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_991330401_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_991330401_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTELHI_TOZEI & "=N'" & CmnDb.SqlString(TBL_SEIKYU.HOTELHI_TOZEI) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JR_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.JR_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.AIR_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.AIR_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_TRAFFIC_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_TRAFFIC_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.HOTEL_COMMISSION_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.HOTEL_COMMISSION_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_COMMISSION_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_COMMISSION_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JINKENHI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.JINKENHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KANRIHI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KANRIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_TF & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_TF) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KAIJOUHI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KAIJOUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KIZAIHI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KIZAIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.INSHOKUHI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.INSHOKUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.IROUKAIHI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.IROUKAIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_991330401_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_991330401_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.JINKENHI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.JINKENHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.OTHER_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.OTHER_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KANRIHI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KANRIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_41120200_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_41120200_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.KEI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KEI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_SEISAN_T & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_SEISAN_T) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISANSHO_URL & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEISANSHO_URL) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TAXI_TICKET_URL & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TAXI_TICKET_URL) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_KANRYO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_KANRYO) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_JR & "=N'" & CmnDb.SqlString(TBL_SEIKYU.MR_JR) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL & "=N'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.MR_HOTEL_TOZEI & "=N'" & CmnDb.SqlString(TBL_SEIKYU.MR_HOTEL_TOZEI) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.TTANTO_ID & "=N'" & CmnDb.SqlString(TBL_SEIKYU.TTANTO_ID) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_DANTAI & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_DANTAI) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_SEND_FLAG(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SEIKYU SET"
            strSQL &= " " & TableDef.TBL_SEIKYU.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_SHOUNIN_KEKKA(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SEIKYU SET"
            strSQL &= " " & TableDef.TBL_SEIKYU.Column.SHIHARAI_NO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SHIHARAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_KUBUN) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_MAINTENANCE(ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SEIKYU SET"
            strSQL &= " " & TableDef.TBL_SEIKYU.Column.SHIHARAI_NO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SHIHARAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_KUBUN & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_KUBUN) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SHOUNIN_DATE & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SHOUNIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEISAN_YM & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEISAN_YM) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SEIKYU.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SEIKYU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEIKYU.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SEIKYU.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_SEIKYU.SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_SEIKYU"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

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
        & " TBL_KOTSUHOTEL.KOUENKAI_NO" _
        & ",TBL_KOTSUHOTEL.TIME_STAMP_BYL"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_SANKASHA_ID(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KOTSUHOTEL.SANKASHA_ID=N'" & CmnDb.SqlString(SANKASHA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_SANKASHA_ID_NEW(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As String
            'Dim strSQL As String = SQL_SELECT
            Dim strSQL As String = String.Empty

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            'strSQL &= " ISNULL(WK_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"
            'strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            strSQL &= " AND WK_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.SANKASHA_ID=N'" & CmnDb.SqlString(SANKASHA_ID) & "'"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.TIME_STAMP_BYL=("
            strSQL &= " SELECT MAX(TIME_STAMP_BYL)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL2"
            strSQL &= " WHERE"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOTSUHOTEL2.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID=WK_KOTSUHOTEL2.SANKASHA_ID)"
            strSQL &= " ORDER BY"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= " ,WK_KOTSUHOTEL.SANKASHA_ID"

            Return strSQL
        End Function

        Public Shared Function byKEY(ByVal SearchKey As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = String.Empty

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= ", WK_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ", WK_KOTSUHOTEL.DR_NAME"
            strSQL &= ", WK_KOTSUHOTEL.MR_NAME"
            strSQL &= ", WK_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ", WK_KOTSUHOTEL.INPUT_DATE"
            strSQL &= ", WK_KOTSUHOTEL.UPDATE_DATE"
            strSQL &= ", WK_KOTSUHOTEL.ANS_STATUS_TEHAI"
            strSQL &= ", WK_KOTSUHOTEL.TEHAI_HOTEL"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_1"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_2"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_3"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_4"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_5"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_1"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_2"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_3"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_4"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_5"
            strSQL &= ", WK_KOTSUHOTEL.TEHAI_TAXI"
            strSQL &= ", WK_KOTSUHOTEL.REQ_MR_O_TEHAI"
            strSQL &= ", WK_KOTSUHOTEL.REQ_MR_F_TEHAI"
            strSQL &= ", WK_KOTSUHOTEL.REQ_MR_HOTEL_NOTE"
            strSQL &= ", WK_KOTSUHOTEL.ANS_MR_HOTEL_NOTE"
            strSQL &= ", WK_KOTSUHOTEL.KINKYU_FLAG"
            strSQL &= ", WK_KOTSUHOTEL.SEND_FLAG"
            strSQL &= ", WK_KOTSUHOTEL.SCAN_IMPORT_DATE"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.KAIJO_NAME"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            '検索
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
            strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"
            strSQL &= " AND WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
            strSQL &= " ='" & CmnDb.SqlString(SearchKey.KOUENKAI_NO) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.SALEFORCE_ID=N'" & CmnDb.SqlString(SearchKey.SALESFORCE_ID) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(SearchKey.KOUENKAI_NO) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.SANKASHA_ID=N'" & CmnDb.SqlString(SearchKey.SANKASHA_ID) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.TIME_STAMP_BYL=N'" & CmnDb.SqlString(SearchKey.TIME_STAMP_BYL) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.DR_MPID=N'" & CmnDb.SqlString(SearchKey.DR_MPID) & "'"

            Return strSQL
        End Function

        Public Shared Function byKEY_AllItem(ByVal SearchKey As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = String.Empty

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            '検索
            strSQL &= " AND WK_KOTSUHOTEL.SALEFORCE_ID=N'" & CmnDb.SqlString(SearchKey.SALESFORCE_ID) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(SearchKey.KOUENKAI_NO) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.SANKASHA_ID=N'" & CmnDb.SqlString(SearchKey.SANKASHA_ID) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.TIME_STAMP_BYL=N'" & CmnDb.SqlString(SearchKey.TIME_STAMP_BYL) & "'"
            strSQL &= " AND WK_KOTSUHOTEL.DR_MPID=N'" & CmnDb.SqlString(SearchKey.DR_MPID) & "'"

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_DR_MPID(ByVal KOUENKAI_NO As String, ByVal DR_MPID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KOTSUHOTEL.DR_MPID=N'" & CmnDb.SqlString(DR_MPID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySEND_FLAG(ByVal SEND_FLAG As String) As String
            Dim strSQL As String = ""
            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.SEND_FLAG=N'" & CmnDb.SqlString(SEND_FLAG) & "'"
            strSQL &= " ORDER BY"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO,"
            strSQL &= " WK_KOTSUHOTEL.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function bySALESFORCE_ID(ByVal SALESFORCE_ID As String) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            strSQL &= " ,WK_KOUENKAI.TO_DATE"
            strSQL &= " , USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " ,"
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOTSUHOTEL.TTANTO_ID,N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"

            ''検索
            'strSQL &= " AND WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
            'strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
            'strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & " )"

            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.SALEFORCE_ID=N'" & CmnDb.SqlString(SALESFORCE_ID) & "'"
            strSQL &= " ORDER BY"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO,"
            strSQL &= " WK_KOTSUHOTEL.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function byNEW_TIME_STAMP(ByVal SALEFORCE_ID As String, ByVal TIME_STAMP_BYL As String, Optional ByVal KOUENKAI_NO As String = "") As String
            Dim strSQL As String = ""

            strSQL &= "SELECT COUNT(*) AS CNT"
            strSQL &= " FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE "
            If KOUENKAI_NO.Trim <> "" Then
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
                strSQL &= " AND "
            End If
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(SALEFORCE_ID) & "'"
            strSQL &= " AND "
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ">N'" & CmnDb.SqlString(TIME_STAMP_BYL) & "'"

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_UPDATE_DATE_DESC(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String, ByVal UPDATE_DATE As String) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            'strSQL &= "SELECT DISTINCT"
            'strSQL &= " WK_KOTSUHOTEL.*"
            'strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            'strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            'strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            'strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            'strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            'strSQL &= " ,WK_KOUENKAI.TO_DATE"
            'strSQL &= " , USER_NAME"
            'strSQL &= " FROM"
            'strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            'strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            'strSQL &= " ,"
            'strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            'strSQL &= " UNION ALL "
            'strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            'strSQL &= " ) AS MS_USER"
            'strSQL &= " WHERE"
            'strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            'strSQL &= " AND"
            'strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            'strSQL &= " SELECT MAX(TIME_STAMP)"
            'strSQL &= " FROM"
            'strSQL &= " TBL_KOUENKAI"
            'strSQL &= " WHERE"
            'strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            'strSQL &= " )"

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            'strSQL &= " ISNULL(WK_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"
            'strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=N'" & KOUENKAI_NO & "'"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID=N'" & SANKASHA_ID & "'"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.UPDATE_DATE<'" & UPDATE_DATE & "'"

            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
            strSQL &= " DESC"

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean, Optional ByVal TEHAISHO_JOKEN() As TableDef.TehaishoJoken.DataStruct = Nothing) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            'strSQL &= "SELECT DISTINCT"
            'strSQL &= " WK_KOTSUHOTEL.*"
            'strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            'strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            'strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            'strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            'strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            'strSQL &= " ,WK_KOUENKAI.TO_DATE"
            'strSQL &= " ,USER_NAME"
            'strSQL &= " FROM"
            'strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            'strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            'strSQL &= " ,"
            'strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            'strSQL &= " UNION ALL "
            'strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            'strSQL &= " ) AS MS_USER"
            'strSQL &= " WHERE"
            'strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            'strSQL &= " AND"
            'strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            'strSQL &= " SELECT MAX(TIME_STAMP)"
            'strSQL &= " FROM"
            'strSQL &= " TBL_KOUENKAI"
            'strSQL &= " WHERE"
            'strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            'strSQL &= " )"
            'strSQL &= " AND"
            'strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= " ,WK_KOUENKAI.KAIJO_NAME"
            strSQL &= " ,WK_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            strSQL &= " ,WK_KOUENKAI.TO_DATE"
            strSQL &= " ,WK_KOUENKAI.DANTAI_CODE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            'strSQL &= " ISNULL(WK_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"
            'strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            If NewData = True Then
                '新着
                strSQL &= " AND"
                strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI & " =N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NewTehai & "'"
                strSQL &= " AND"
                strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
                strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
                strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"
            Else
                If TEHAISHO_JOKEN Is Nothing Then
                    '検索
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
                    strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
                    strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"
                End If
            End If

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai & "'"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change & "'"
            ElseIf Trim(Joken.KUBUN) = "C" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel & "'"
            End If

            If Trim(Joken.MR_ROMA) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.MR_ROMA) & "%'"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.DR_KANA) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_KANA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.DR_KANA) & "%'"
            End If

            If Trim(Joken.DR_SANKA) <> "" Then
                strSQL &= " AND TBL_SANKA.DR_SANKA"
                strSQL &= " =N'" & CmnDb.SqlString(Joken.DR_SANKA) & "'"

                'strSQL &= " AND WK_KOTSUHOTEL."
                'strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA
                'strSQL &= " =N'" & CmnDb.SqlString(Joken.DR_SANKA) & "'"
            End If

            If Trim(Joken.SEND_FLAG) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEND_FLAG) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
                'strSQL &= " =N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.SANKASHA_ID) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.SANKASHA_ID) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.UPDATE_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.UPDATE_DATE) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " = N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Joken.TTEHAI_MITOUROKU = CmnConst.Flag.On Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= "=N''"
            End If

            If Not TEHAISHO_JOKEN Is Nothing Then
                Dim i As Integer = 0
                For i = 0 To UBound(TEHAISHO_JOKEN)
                    If i = 0 Then
                        strSQL &= " AND ("
                    Else
                        strSQL &= " OR"
                    End If
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).KOUENKAI_NO & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).SANKASHA_ID & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).TIME_STAMP_BYL & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).SALEFORCE_ID & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_MPID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).DR_MPID & "'"
                Next i
                strSQL &= ")"
            End If

            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            If NewData Then
                '新着
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
                strSQL &= " DESC"
            Else
                '検索
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
                strSQL &= " DESC"
            End If

            Return strSQL
        End Function

        Public Shared Function Search_KeyItem(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean, Optional ByVal TEHAISHO_JOKEN() As TableDef.TehaishoJoken.DataStruct = Nothing) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= ", WK_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ", WK_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= ", WK_KOTSUHOTEL.DR_MPID"
            strSQL &= ", WK_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ", WK_KOTSUHOTEL.UPDATE_DATE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            If NewData = True Then
                '新着
                strSQL &= " AND"
                strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI & " =N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NewTehai & "'"
                strSQL &= " AND"
                strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
                strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
                strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"
            Else
                If TEHAISHO_JOKEN Is Nothing Then
                    '検索
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
                    strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
                    strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"
                End If
            End If

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai & "'"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change & "'"
            ElseIf Trim(Joken.KUBUN) = "C" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel & "'"
            End If

            If Trim(Joken.MR_ROMA) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.MR_ROMA) & "%'"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.DR_KANA) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_KANA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.DR_KANA) & "%'"
            End If

            If Trim(Joken.DR_SANKA) <> "" Then
                strSQL &= " AND TBL_SANKA.DR_SANKA"
                strSQL &= " =N'" & CmnDb.SqlString(Joken.DR_SANKA) & "'"
            End If

            If Trim(Joken.SEND_FLAG) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEND_FLAG) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.SANKASHA_ID) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.SANKASHA_ID) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.UPDATE_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.UPDATE_DATE) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " = N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Joken.TTEHAI_MITOUROKU = CmnConst.Flag.On Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= "=N''"
            End If

            If Not TEHAISHO_JOKEN Is Nothing Then
                Dim i As Integer = 0
                For i = 0 To UBound(TEHAISHO_JOKEN)
                    If i = 0 Then
                        strSQL &= " AND ("
                    Else
                        strSQL &= " OR"
                    End If
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).KOUENKAI_NO & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).SANKASHA_ID & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).TIME_STAMP_BYL & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).SALEFORCE_ID & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_MPID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).DR_MPID & "'"
                Next i
                strSQL &= ")"
            End If

            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            If NewData Then
                '新着
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
                strSQL &= " DESC"
            Else
                '検索
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
                strSQL &= " DESC"
            End If

            Return strSQL
        End Function

        Public Shared Function NewDrCsv(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean, Optional ByVal TEHAISHO_JOKEN() As TableDef.TehaishoJoken.DataStruct = Nothing) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= ", WK_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ", WK_KOTSUHOTEL.DR_NAME"
            strSQL &= ", WK_KOTSUHOTEL.DR_KANA"
            strSQL &= ", WK_KOTSUHOTEL.MR_NAME"
            strSQL &= ", WK_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ", WK_KOTSUHOTEL.INPUT_DATE"
            strSQL &= ", WK_KOTSUHOTEL.REQ_STATUS_TEHAI"
            strSQL &= ", WK_KOTSUHOTEL.TEHAI_HOTEL"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_1"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_2"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_3"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_4"
            strSQL &= ", WK_KOTSUHOTEL.REQ_O_TEHAI_5"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_1"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_2"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_3"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_4"
            strSQL &= ", WK_KOTSUHOTEL.REQ_F_TEHAI_5"
            strSQL &= ", WK_KOTSUHOTEL.TEHAI_TAXI"
            strSQL &= ", WK_KOTSUHOTEL.REQ_MR_O_TEHAI"
            strSQL &= ", WK_KOTSUHOTEL.REQ_MR_F_TEHAI"
            strSQL &= ", WK_KOTSUHOTEL.REQ_MR_HOTEL_NOTE"
            strSQL &= ", WK_KOTSUHOTEL.ANS_MR_HOTEL_NOTE"
            strSQL &= ", WK_KOTSUHOTEL.KINKYU_FLAG"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", MS_USER.USER_NAME"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= " FROM (("
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL INNER JOIN "
            strSQL &= " TBL_KOUENKAI AS WK_KOUENKAI ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ) LEFT JOIN TBL_SANKA ON ("
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " ) AND ("
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " )) LEFT JOIN MS_USER ON "
            strSQL &= " WK_KOUENKAI.TTEHAI_TANTO = MS_USER.LOGIN_ID"
            strSQL &= " WHERE "
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"

            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI & " =N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.NewTehai & "'"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
            strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"

            If Trim(Joken.KUBUN) = "A" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Tehai & "'"
            ElseIf Trim(Joken.KUBUN) = "U" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Change & "'"
            ElseIf Trim(Joken.KUBUN) = "C" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.REQ_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Request.Code.Cancel & "'"
            End If

            If Trim(Joken.MR_ROMA) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.MR_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.MR_ROMA) & "%'"
            End If

            If Trim(Joken.BU) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_BU
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.BU) & "%'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_AREA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.AREA) & "%'"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TEHAI_TANTO_ROMA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
            End If

            If Trim(Joken.DR_KANA) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_KANA
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.DR_KANA) & "%'"
            End If

            If Trim(Joken.DR_SANKA) <> "" Then
                strSQL &= " AND TBL_SANKA.DR_SANKA"
                strSQL &= " =N'" & CmnDb.SqlString(Joken.DR_SANKA) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            '@@@ 月次参加者CSV出力用
            ' ''strSQL &= " AND WK_KOUENKAI."
            ' ''strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
            ' ''strSQL &= " BETWEEN N'20140921' AND N'20141020'"

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.UPDATE_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.UPDATE_DATE) & "%'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " = N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Joken.TTEHAI_MITOUROKU = CmnConst.Flag.On Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= "=N''"
            End If

            If Not TEHAISHO_JOKEN Is Nothing Then
                Dim i As Integer = 0
                For i = 0 To UBound(TEHAISHO_JOKEN)
                    If i = 0 Then
                        strSQL &= " AND ("
                    Else
                        strSQL &= " OR"
                    End If
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).KOUENKAI_NO & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).SANKASHA_ID & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).TIME_STAMP_BYL & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).SALEFORCE_ID & "'"
                    strSQL &= " AND"
                    strSQL &= " WK_KOTSUHOTEL."
                    strSQL &= TableDef.TBL_KOTSUHOTEL.Column.DR_MPID
                    strSQL &= "=N'" & TEHAISHO_JOKEN(i).DR_MPID & "'"
                Next i
                strSQL &= ")"
            End If

            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            '新着
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
            strSQL &= " DESC"

            Return strSQL
        End Function

        Public Shared Function TaxiPrintCsv(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= ",TBL_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ",TBL_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= ",TBL_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ",TBL_KOTSUHOTEL.DR_MPID"
            strSQL &= ",TBL_KOTSUHOTEL.DR_NAME"
            strSQL &= ",TBL_KOTSUHOTEL.UPDATE_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20"
            strSQL &= " FROM"
            strSQL &= "("
            strSQL &= " SELECT TBL_KOTSUHOTEL_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL"
            strSQL &= "  WHERE KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " ) AS TBL_KOTSUHOTEL_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL,KOUENKAI_NO,SALEFORCE_ID,SANKASHA_ID,DR_MPID FROM TBL_KOTSUHOTEL"
            strSQL &= "  WHERE KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= "  GROUP BY KOUENKAI_NO,SALEFORCE_ID,SANKASHA_ID,DR_MPID"
            strSQL &= "  ) AS TBL_KOTSUHOTEL_2"
            strSQL &= "  WHERE TBL_KOTSUHOTEL_1.TIME_STAMP_BYL=TBL_KOTSUHOTEL_2.TIME_STAMP_BYL"
            strSQL &= "   AND TBL_KOTSUHOTEL_1.KOUENKAI_NO=TBL_KOTSUHOTEL_2.KOUENKAI_NO"
            strSQL &= "   AND TBL_KOTSUHOTEL_1.SALEFORCE_ID=TBL_KOTSUHOTEL_2.SALEFORCE_ID"
            strSQL &= "   AND TBL_KOTSUHOTEL_1.SANKASHA_ID=TBL_KOTSUHOTEL_2.SANKASHA_ID"
            strSQL &= "   AND TBL_KOTSUHOTEL_1.DR_MPID=TBL_KOTSUHOTEL_2.DR_MPID"
            strSQL &= "   AND TBL_KOTSUHOTEL_1.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= ") AS TBL_KOTSUHOTEL"
            strSQL &= " ORDER BY"
            strSQL &= " TBL_KOTSUHOTEL.KOUENKAI_NO DESC"
            strSQL &= ",TBL_KOTSUHOTEL.SANKASHA_ID DESC"
            '14.9.3 tanaka
            'strSQL &= " TBL_KOTSUHOTEL.KOUENKAI_NO ASC"
            'strSQL &= ",TBL_KOTSUHOTEL.SANKASHA_ID ASC"

            Return strSQL
        End Function
 
        Public Shared Function TaxiScanCsv(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= ",TBL_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ",TBL_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= ",TBL_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ",TBL_KOTSUHOTEL.DR_MPID"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20"
            strSQL &= " FROM"
            strSQL &= "(SELECT TBL_KOTSUHOTEL_1.* FROM"
            strSQL &= "(SELECT * FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE TBL_KOTSUHOTEL.SALEFORCE_ID=N'" & TBL_TAXITICKET_HAKKO.SALEFORCE_ID & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.SANKASHA_ID=N'" & TBL_TAXITICKET_HAKKO.SANKASHA_ID & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.KOUENKAI_NO=N'" & TBL_TAXITICKET_HAKKO.KOUENKAI_NO & "'"
            strSQL &= "   AND LTRIM(RTRIM(TBL_KOTSUHOTEL.DR_MPID))=N'" & Trim(TBL_TAXITICKET_HAKKO.DR_MPID) & "'"
            strSQL &= ") AS TBL_KOTSUHOTEL_1"
            strSQL &= ","
            strSQL &= "(SELECT"
            strSQL &= " MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= ",SALEFORCE_ID"
            strSQL &= ",SANKASHA_ID"
            strSQL &= ",DR_MPID"
            strSQL &= ",KOUENKAI_NO"
            strSQL &= " FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE TBL_KOTSUHOTEL.SALEFORCE_ID=N'" & TBL_TAXITICKET_HAKKO.SALEFORCE_ID & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.SANKASHA_ID=N'" & TBL_TAXITICKET_HAKKO.SANKASHA_ID & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.KOUENKAI_NO=N'" & TBL_TAXITICKET_HAKKO.KOUENKAI_NO & "'"
            strSQL &= "   AND LTRIM(RTRIM(TBL_KOTSUHOTEL.DR_MPID))=N'" & Trim(TBL_TAXITICKET_HAKKO.DR_MPID) & "'"
            strSQL &= " GROUP BY SALEFORCE_ID"
            strSQL &= ",SANKASHA_ID"
            strSQL &= ",DR_MPID"
            strSQL &= ",KOUENKAI_NO"
            strSQL &= ") AS TBL_KOTSUHOTEL_2"
            strSQL &= " WHERE TBL_KOTSUHOTEL_1.SALEFORCE_ID=TBL_KOTSUHOTEL_2.SALEFORCE_ID"
            strSQL &= "  AND TBL_KOTSUHOTEL_1.SANKASHA_ID=TBL_KOTSUHOTEL_2.SANKASHA_ID"
            strSQL &= "  AND TBL_KOTSUHOTEL_1.KOUENKAI_NO=TBL_KOTSUHOTEL_2.KOUENKAI_NO"
            strSQL &= "  AND TBL_KOTSUHOTEL_1.DR_MPID=TBL_KOTSUHOTEL_2.DR_MPID"
            strSQL &= "  AND TBL_KOTSUHOTEL_1.TIME_STAMP_BYL=TBL_KOTSUHOTEL_2.TIME_STAMP_BYL"
            strSQL &= ") AS TBL_KOTSUHOTEL"

            Return strSQL
        End Function

        Public Shared Function TaxiScanCsvCheck(ByVal TKT_NO As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " TBL_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= ",TBL_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ",TBL_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= ",TBL_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ",TBL_KOTSUHOTEL.DR_MPID"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20"
            strSQL &= " FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE TBL_KOTSUHOTEL.ANS_TAXI_NO_1=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_2=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_3=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_4=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_5=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_6=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_7=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_8=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_9=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_10=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_11=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_12=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_13=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_14=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_15=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_16=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_17=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_18=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_19=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= "    OR TBL_KOTSUHOTEL.ANS_TAXI_NO_20=N'" & CmnDb.SqlString(TKT_NO) & "'"

            Return strSQL
        End Function

        Public Shared Function TaxiScanCsvCheck(ByVal SALEFORCE_ID As String, ByVal SANKASHA_ID As String, ByVal KOUENKAI_NO As String, ByVal TIME_STAMP_BYL As String, ByVal DR_MPID As String, ByVal TKT_LINE_NO As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " TBL_KOTSUHOTEL.*"
            strSQL &= " FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_" & CInt(TKT_LINE_NO).ToString & "=N'1'"
            strSQL &= "   AND ISNULL(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_" & CInt(TKT_LINE_NO).ToString & ",N'')<>N''"
            strSQL &= "   AND TBL_KOTSUHOTEL.SALEFORCE_ID=N'" & CmnDb.SqlString(SALEFORCE_ID) & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.SANKASHA_ID=N'" & CmnDb.SqlString(SANKASHA_ID) & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= "   AND TBL_KOTSUHOTEL.TIME_STAMP_BYL=N'" & CmnDb.SqlString(TIME_STAMP_BYL) & "'"
            strSQL &= "   AND LTRIM(RTRIM(TBL_KOTSUHOTEL.DR_MPID))=N'" & CmnDb.SqlString(Trim(DR_MPID)) & "'"

            Return strSQL
        End Function

        Public Shared Function DrCsvCheck(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " *"
            strSQL &= " FROM TBL_KOTSUHOTEL TKH"
            strSQL &= " WHERE"
            strSQL &= " TKH.KOUENKAI_NO = N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"

            If Trim(Joken.SEIKYU_NO_TOPTOUR) = "" Then
                strSQL &= " AND RTRIM(ISNULL(TKH.SEIKYU_NO_TOPTOUR,N'')) = N''"
            Else
                strSQL &= " AND "
                strSQL &= " (TKH.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(Joken.SEIKYU_NO_TOPTOUR) & "'"
                strSQL &= "   OR "
                strSQL &= "  RTRIM(ISNULL(TKH.SEIKYU_NO_TOPTOUR,N'')) = N''"
                strSQL &= " )"
            End If

            Return strSQL
        End Function

        Public Shared Function DrCsv(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK1.KOUENKAI_NO"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",WK_KOUENKAI.WBS_ELEMENT AS WBS_ELEMENT_KOUENKAI"
            strSQL &= ",WK1.SANKASHA_ID"
            strSQL &= ",WK2.DR_CD"
            strSQL &= ",WK2.DR_YAKUWARI"
            strSQL &= ",WK2.DR_NAME"
            strSQL &= ",WK2.DR_KANA"
            strSQL &= ",WK2.DR_SHISETSU_NAME"
            strSQL &= ",TBL_SANKA.DR_SANKA"
            strSQL &= ",WK2.SHITEIGAI_RIYU"
            strSQL &= ",WK2.MR_SEND_SAKI_FS"
            strSQL &= ",WK2.MR_SEND_SAKI_OTHER"
            strSQL &= ",WK2.ANS_HOTELHI"
            strSQL &= ",WK2.ANS_HOTELHI_CANCEL"
            strSQL &= ",WK2.ANS_HOTELHI_TOZEI"
            strSQL &= ",WK2.ANS_RAIL_FARE"
            strSQL &= ",WK2.ANS_RAIL_CANCELLATION"
            strSQL &= ",WK2.ANS_AIR_FARE"
            strSQL &= ",WK2.ANS_AIR_CANCELLATION"
            strSQL &= ",WK2.ANS_OTHER_FARE"
            strSQL &= ",WK2.ANS_OTHER_CANCELLATION"
            strSQL &= ",WK2.ANS_TAXI_TESURYO"
            strSQL &= ",WK2.ANS_KOTSUHOTEL_TESURYO"
            strSQL &= ",WK2.MR_BU"
            strSQL &= ",WK2.MR_AREA"
            strSQL &= ",WK2.MR_EIGYOSHO"
            strSQL &= ",WK2.MR_NAME"
            strSQL &= ",WK2.MR_KANA"
            strSQL &= ",WK2.ACCOUNT_CD"
            strSQL &= ",WK2.COST_CENTER"
            strSQL &= ",WK2.INTERNAL_ORDER"
            strSQL &= ",WK2.ZETIA_CD"
            strSQL &= ",WK2.REQ_STATUS_TEHAI"
            strSQL &= ",WK2.TIME_STAMP_BYL"
            strSQL &= ",WK2.TEHAI_HOTEL"
            strSQL &= ",WK2.HOTEL_IRAINAIYOU"
            strSQL &= ",WK2.REQ_HOTEL_DATE"
            strSQL &= ",WK2.REQ_HAKUSU"
            strSQL &= ",WK2.REQ_HOTEL_SMOKING"
            strSQL &= ",WK2.REQ_HOTEL_NOTE"
            strSQL &= ",WK2.TIME_STAMP_TOP"
            strSQL &= ",WK2.ANS_STATUS_TEHAI"
            strSQL &= ",WK2.ANS_STATUS_HOTEL"
            strSQL &= ",WK2.ANS_HOTEL_DATE"
            strSQL &= ",WK2.ANS_HAKUSU"
            strSQL &= ",WK2.ANS_HOTEL_NAME"
            strSQL &= ",WK2.ANS_ROOM_TYPE"
            strSQL &= ",WK2.ANS_HOTEL_SMOKING"
            strSQL &= ",WK2.ANS_HOTEL_NOTE"
            strSQL &= ",WK2.ANS_HOTEL_TEL"
            strSQL &= ",WK2.REQ_KOTSU_BIKO"
            strSQL &= ",WK2.ANS_O_STATUS_1"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_1"
            strSQL &= ",WK2.ANS_O_DATE_1"
            strSQL &= ",WK2.ANS_O_AIRPORT1_1"
            strSQL &= ",WK2.ANS_O_AIRPORT2_1"
            strSQL &= ",WK2.ANS_O_BIN_1"
            strSQL &= ",WK2.ANS_O_TIME1_1"
            strSQL &= ",WK2.ANS_O_TIME2_1"
            strSQL &= ",WK2.ANS_O_SEAT_1"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU1"
            strSQL &= ",WK2.ANS_F_STATUS_1"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_1"
            strSQL &= ",WK2.ANS_F_DATE_1"
            strSQL &= ",WK2.ANS_F_AIRPORT1_1"
            strSQL &= ",WK2.ANS_F_AIRPORT2_1"
            strSQL &= ",WK2.ANS_F_BIN_1"
            strSQL &= ",WK2.ANS_F_TIME1_1"
            strSQL &= ",WK2.ANS_F_TIME2_1"
            strSQL &= ",WK2.ANS_F_SEAT_1"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU1"
            strSQL &= ",WK2.ANS_O_STATUS_2"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_2"
            strSQL &= ",WK2.ANS_O_DATE_2"
            strSQL &= ",WK2.ANS_O_AIRPORT1_2"
            strSQL &= ",WK2.ANS_O_AIRPORT2_2"
            strSQL &= ",WK2.ANS_O_BIN_2"
            strSQL &= ",WK2.ANS_O_TIME1_2"
            strSQL &= ",WK2.ANS_O_TIME2_2"
            strSQL &= ",WK2.ANS_O_SEAT_2"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU2"
            strSQL &= ",WK2.ANS_F_STATUS_2"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_2"
            strSQL &= ",WK2.ANS_F_DATE_2"
            strSQL &= ",WK2.ANS_F_AIRPORT1_2"
            strSQL &= ",WK2.ANS_F_AIRPORT2_2"
            strSQL &= ",WK2.ANS_F_BIN_2"
            strSQL &= ",WK2.ANS_F_TIME1_2"
            strSQL &= ",WK2.ANS_F_TIME2_2"
            strSQL &= ",WK2.ANS_F_SEAT_2"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU2"
            strSQL &= ",WK2.ANS_O_STATUS_3"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_3"
            strSQL &= ",WK2.ANS_O_DATE_3"
            strSQL &= ",WK2.ANS_O_AIRPORT1_3"
            strSQL &= ",WK2.ANS_O_AIRPORT2_3"
            strSQL &= ",WK2.ANS_O_BIN_3"
            strSQL &= ",WK2.ANS_O_TIME1_3"
            strSQL &= ",WK2.ANS_O_TIME2_3"
            strSQL &= ",WK2.ANS_O_SEAT_3"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU3"
            strSQL &= ",WK2.ANS_F_STATUS_3"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_3"
            strSQL &= ",WK2.ANS_F_DATE_3"
            strSQL &= ",WK2.ANS_F_AIRPORT1_3"
            strSQL &= ",WK2.ANS_F_AIRPORT2_3"
            strSQL &= ",WK2.ANS_F_BIN_3"
            strSQL &= ",WK2.ANS_F_TIME1_3"
            strSQL &= ",WK2.ANS_F_TIME2_3"
            strSQL &= ",WK2.ANS_F_SEAT_3"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU3"
            strSQL &= ",WK2.ANS_O_STATUS_4"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_4"
            strSQL &= ",WK2.ANS_O_DATE_4"
            strSQL &= ",WK2.ANS_O_AIRPORT1_4"
            strSQL &= ",WK2.ANS_O_AIRPORT2_4"
            strSQL &= ",WK2.ANS_O_BIN_4"
            strSQL &= ",WK2.ANS_O_TIME1_4"
            strSQL &= ",WK2.ANS_O_TIME2_4"
            strSQL &= ",WK2.ANS_O_SEAT_4"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU4"
            strSQL &= ",WK2.ANS_F_STATUS_4"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_4"
            strSQL &= ",WK2.ANS_F_DATE_4"
            strSQL &= ",WK2.ANS_F_AIRPORT1_4"
            strSQL &= ",WK2.ANS_F_AIRPORT2_4"
            strSQL &= ",WK2.ANS_F_BIN_4"
            strSQL &= ",WK2.ANS_F_TIME1_4"
            strSQL &= ",WK2.ANS_F_TIME2_4"
            strSQL &= ",WK2.ANS_F_SEAT_4"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU4"
            strSQL &= ",WK2.ANS_O_STATUS_5"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_5"
            strSQL &= ",WK2.ANS_O_DATE_5"
            strSQL &= ",WK2.ANS_O_AIRPORT1_5"
            strSQL &= ",WK2.ANS_O_AIRPORT2_5"
            strSQL &= ",WK2.ANS_O_BIN_5"
            strSQL &= ",WK2.ANS_O_TIME1_5"
            strSQL &= ",WK2.ANS_O_TIME2_5"
            strSQL &= ",WK2.ANS_O_SEAT_5"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU5"
            strSQL &= ",WK2.ANS_F_STATUS_5"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_5"
            strSQL &= ",WK2.ANS_F_DATE_5"
            strSQL &= ",WK2.ANS_F_AIRPORT1_5"
            strSQL &= ",WK2.ANS_F_AIRPORT2_5"
            strSQL &= ",WK2.ANS_F_BIN_5"
            strSQL &= ",WK2.ANS_F_TIME1_5"
            strSQL &= ",WK2.ANS_F_TIME2_5"
            strSQL &= ",WK2.ANS_F_SEAT_5"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU5"
            strSQL &= ",WK2.ANS_KOTSU_BIKO"
            strSQL &= ",WK2.ANS_KOTSU_BIKO"
            strSQL &= " FROM"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "   ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            strSQL &= "  WHERE  WK3.TIME_STAMP = "
            strSQL &= "  (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "   WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            strSQL &= "  )WK_KOUENKAI"
            strSQL &= "    ON WK1.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SANKA "
            strSQL &= " ON WK1.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " AND WK1.SANKASHA_ID = TBL_SANKA.SANKASHA_ID  "
            strSQL &= " WHERE"
            strSQL &= " WK1.KOUENKAI_NO = N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " AND WK2.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(Joken.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= " ORDER BY WK1.KOUENKAI_NO,WK1.SANKASHA_ID"

            Return strSQL
        End Function

        Public Shared Function MrCsv(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT WK4.* FROM"
            strSQL &= " (SELECT "
            strSQL &= " WK1.KOUENKAI_NO"
            strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= ",WK_KOUENKAI.TO_DATE"
            strSQL &= ",WK2.COST_CENTER"
            strSQL &= ",WK2.MR_BU"
            strSQL &= ",WK2.MR_AREA"
            strSQL &= ",WK2.MR_EIGYOSHO"
            strSQL &= ",WK2.MR_NAME"
            strSQL &= ",WK2.MR_KANA"
            strSQL &= ",WK2.REQ_MR_HOTEL_NOTE"
            strSQL &= ",WK2.ANS_MR_O_TEHAI"
            strSQL &= ",WK2.ANS_MR_F_TEHAI"
            strSQL &= ",WK2.ANS_MR_HOTEL_NOTE"
            strSQL &= ",WK2.SANKASHA_ID"
            strSQL &= ",WK2.DR_NAME"
            strSQL &= ",WK2.DR_KANA"
            strSQL &= ",WK2.DR_SHISETSU_NAME"
            strSQL &= ",CAST(ISNULL(WK2.ANS_MR_HOTELHI,'0') AS BIGINT) AS ANS_MR_HOTELHI"
            strSQL &= ",CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'0') AS BIGINT) AS ANS_MR_HOTELHI_TOZEI"
            strSQL &= ",CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'0') AS BIGINT) AS ANS_MR_KOTSUHI"
            'strSQL &= ",CAST(ISNULL(WK2.ANS_MR_HOTELHI,'0') AS BIGINT) AS MR_HOTEL"
            'strSQL &= ",CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'0') AS BIGINT) AS MR_HOTEL_TOZEI"
            'strSQL &= ",CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'0') AS BIGINT) AS MR_JR"
            strSQL &= " FROM"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "  ON  (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            strSQL &= "  WHERE  WK3.TIME_STAMP = "
            strSQL &= "  (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "   WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            strSQL &= "  )WK_KOUENKAI"
            strSQL &= "    ON WK1.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " WHERE"
            strSQL &= " WK1.KOUENKAI_NO = N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " AND WK2.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(Joken.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ") WK4"
            strSQL &= " WHERE ((WK4.ANS_MR_HOTELHI <> 0) OR (WK4.ANS_MR_HOTELHI_TOZEI <> 0) OR (WK4.ANS_MR_KOTSUHI <> 0))"
            strSQL &= " ORDER BY WK4.KOUENKAI_NO,WK4.COST_CENTER"

            Return strSQL
        End Function

        Public Shared Function DrReport(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= " ,WK_KOUENKAI.KAIJO_NAME"
            strSQL &= " ,WK_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            strSQL &= " ,WK_KOUENKAI.TO_DATE"
            strSQL &= " ,WK_KOUENKAI.DANTAI_CODE"
            strSQL &= " ,WK_KOUENKAI.WBS_ELEMENT AS WBS_ELEMENT_KOUENKAI"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
            strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=" & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & KOUENKAI_NO & "')"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & KOUENKAI_NO & "'"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & SANKASHA_ID & "'"

            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
            strSQL &= " ,WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
            'strSQL &= TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
            'strSQL &= " DESC"

            Return strSQL
        End Function

        Public Shared Function DrRireki(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            strSQL &= " ,WK_KOUENKAI.TO_DATE"
            strSQL &= " ,USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " ,"
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOTSUHOTEL.TTANTO_ID,N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & KOUENKAI_NO & "'"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & SANKASHA_ID & "'"
            strSQL &= " ORDER BY"
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL
            strSQL &= " DESC"

            Return strSQL
        End Function

        Public Shared Function byTKT_NO_TKT_LINE_NO(ByVal SANKASHA_ID As String, ByVal TKT_NO As String, ByVal TKT_LINE_NO As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " TBL_SANKA.DR_SANKA"
            strSQL &= ",TBL_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= ",TBL_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ",TBL_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_STATUS_TEHAI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_STATUS_TEHAI"
            strSQL &= ",TBL_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= ",TBL_KOTSUHOTEL.TIME_STAMP_TOP"
            strSQL &= ",TBL_KOTSUHOTEL.DR_MPID"
            strSQL &= ",TBL_KOTSUHOTEL.DR_CD"
            strSQL &= ",TBL_KOTSUHOTEL.DR_NAME"
            strSQL &= ",TBL_KOTSUHOTEL.DR_KANA"
            strSQL &= ",TBL_KOTSUHOTEL.DR_SHISETSU_CD"
            strSQL &= ",TBL_KOTSUHOTEL.DR_SHISETSU_NAME"
            strSQL &= ",TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS"
            strSQL &= ",TBL_KOTSUHOTEL.DR_YAKUWARI"
            strSQL &= ",TBL_KOTSUHOTEL.DR_SEX"
            strSQL &= ",TBL_KOTSUHOTEL.DR_AGE"
            strSQL &= ",TBL_KOTSUHOTEL.WBS_ELEMENT"
            strSQL &= ",TBL_KOTSUHOTEL.SHITEIGAI_RIYU"
            'strSQL &= ",TBL_KOTSUHOTEL.DR_SANKA"
            strSQL &= ",TBL_KOTSUHOTEL.MR_BU"
            strSQL &= ",TBL_KOTSUHOTEL.MR_AREA"
            strSQL &= ",TBL_KOTSUHOTEL.MR_EIGYOSHO"
            strSQL &= ",TBL_KOTSUHOTEL.MR_NAME"
            strSQL &= ",TBL_KOTSUHOTEL.MR_ROMA"
            strSQL &= ",TBL_KOTSUHOTEL.MR_KANA"
            strSQL &= ",TBL_KOTSUHOTEL.MR_EMAIL_PC"
            strSQL &= ",TBL_KOTSUHOTEL.MR_EMAIL_KEITAI"
            strSQL &= ",TBL_KOTSUHOTEL.MR_KEITAI"
            strSQL &= ",TBL_KOTSUHOTEL.MR_TEL"
            strSQL &= ",TBL_KOTSUHOTEL.MR_SEND_SAKI_FS"
            strSQL &= ",TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER"
            strSQL &= ",TBL_KOTSUHOTEL.ACCOUNT_CD"
            strSQL &= ",TBL_KOTSUHOTEL.COST_CENTER"
            strSQL &= ",TBL_KOTSUHOTEL.INTERNAL_ORDER"
            strSQL &= ",TBL_KOTSUHOTEL.ZETIA_CD"
            strSQL &= ",TBL_KOTSUHOTEL.SHONIN_NAME"
            strSQL &= ",TBL_KOTSUHOTEL.SHONIN_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.TEHAI_HOTEL"
            strSQL &= ",TBL_KOTSUHOTEL.HOTEL_IRAINAIYOU"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_HOTEL_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_HAKUSU"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_HOTEL_SMOKING"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_HOTEL_NOTE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_STATUS_HOTEL"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTEL_NAME"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTEL_TEL"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTEL_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HAKUSU"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_CHECKIN_TIME"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_ROOM_TYPE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTEL_NOTE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTELHI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTELHI_TOZEI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_HOTELHI_CANCEL"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TEHAI_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT1_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT2_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME1_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME2_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_BIN_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TEHAI_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT1_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT2_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME1_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME2_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_BIN_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TEHAI_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT1_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT2_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME1_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME2_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_BIN_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TEHAI_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT1_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT2_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME1_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME2_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_BIN_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TEHAI_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT1_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_AIRPORT2_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME1_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_TIME2_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_BIN_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TEHAI_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT1_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT2_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME1_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME2_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_BIN_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TEHAI_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT1_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT2_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME1_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME2_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_BIN_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TEHAI_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT1_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT2_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME1_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME2_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_BIN_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TEHAI_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT1_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT2_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME1_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME2_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_BIN_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TEHAI_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT1_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_AIRPORT2_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME1_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_TIME2_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_BIN_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_KOTSU_BIKO"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_STATUS_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME1_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME2_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_BIN_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_STATUS_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME1_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME2_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_BIN_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_STATUS_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME1_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME2_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_BIN_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_STATUS_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME1_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME2_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_BIN_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_STATUS_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME1_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_TIME2_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_BIN_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_STATUS_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME1_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME2_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_BIN_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_STATUS_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME1_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME2_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_BIN_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_STATUS_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME1_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME2_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_BIN_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_STATUS_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME1_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME2_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_BIN_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_STATUS_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME1_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_TIME2_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_BIN_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_KOTSU_BIKO"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_RAIL_FARE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_OTHER_FARE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_AIR_FARE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_KOTSUHOTEL_TESURYO"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_TESURYO"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY"
            strSQL &= ",TBL_KOTSUHOTEL.TEHAI_TAXI"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_1"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_2"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_3"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_4"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_5"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_6"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_6"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_7"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_7"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_8"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_8"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_9"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_9"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_DATE_10"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_FROM_10"
            strSQL &= ",TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_TAXI_NOTE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_1"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_2"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_3"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_4"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_5"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_6"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_7"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_8"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_9"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_10"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_11"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_12"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_13"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_14"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_15"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_16"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_17"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_18"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_19"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_DATE_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NO_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_20"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_TAXI_NOTE"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_MR_O_TEHAI"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_MR_F_TEHAI"
            strSQL &= ",TBL_KOTSUHOTEL.MR_SEX"
            strSQL &= ",TBL_KOTSUHOTEL.MR_AGE"
            strSQL &= ",TBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_MR_O_TEHAI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_MR_F_TEHAI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_MR_KOTSUHI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_MR_HOTELHI"
            strSQL &= ",TBL_KOTSUHOTEL.ANS_MR_HOTELHI_TOZEI"
            strSQL &= ",TBL_KOTSUHOTEL.SEND_FLAG"
            strSQL &= ",TBL_KOTSUHOTEL.TTANTO_ID"
            strSQL &= ",TBL_KOTSUHOTEL.SEIKYU_NO_TOPTOUR"
            strSQL &= ",TBL_KOTSUHOTEL.SCAN_IMPORT_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.INPUT_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.INPUT_USER"
            strSQL &= ",TBL_KOTSUHOTEL.UPDATE_DATE"
            strSQL &= ",TBL_KOTSUHOTEL.UPDATE_USER"
            strSQL &= ",TBL_KOTSUHOTEL.SEND_DATE"
            'strSQL &= " FROM TBL_KOTSUHOTEL"
            'strSQL &= " INNER JOIN TBL_SANKA"
            'strSQL &= " ON (TBL_KOTSUHOTEL.KOUENKAI_NO=TBL_SANKA.KOUENKAI_NO)"
            'strSQL &= " AND (TBL_KOTSUHOTEL.SANKASHA_ID=TBL_SANKA.SANKASHA_ID)"
            strSQL &= " FROM TBL_KOTSUHOTEL"
            strSQL &= " LEFT JOIN TBL_SANKA"
            strSQL &= " ON (TBL_KOTSUHOTEL.SANKASHA_ID=TBL_SANKA.SANKASHA_ID)"
            strSQL &= " AND (TBL_KOTSUHOTEL.KOUENKAI_NO=TBL_SANKA.KOUENKAI_NO)"
            strSQL &= " WHERE TBL_KOTSUHOTEL.SANKASHA_ID=N'" & CmnDb.SqlString(SANKASHA_ID) & "'"
            'strSQL &= " AND TBL_KOTSUHOTEL.ANS_TAXI_NO_" & CInt(TKT_LINE_NO).ToString & "=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= " AND ("
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_1 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_2 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_3 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_4 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_5 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_6 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_7 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_8 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_9 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_10 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_11 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_12 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_13 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_14 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_15 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_16 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_17 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_18 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_19 = N'" & CmnDb.SqlString(TKT_NO) & "' OR"
            strSQL &= " TBL_KOTSUHOTEL.ANS_TAXI_NO_20 = N'" & CmnDb.SqlString(TKT_NO) & "')"
            strSQL &= " ORDER BY TBL_KOTSUHOTEL.UPDATE_DATE DESC"

            Return strSQL
        End Function

        Public Shared Function Soufujo_Disp(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.SALEFORCE_ID"
            strSQL &= " ,WK_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= " ,WK_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= " ,WK_KOTSUHOTEL.TIME_STAMP_BYL"
            strSQL &= " ,WK_KOTSUHOTEL.DR_MPID"
            'strSQL &= " ,WK_KOTSUHOTEL.DR_NAME"
            'strSQL &= " ,WK_KOTSUHOTEL.SCAN_IMPORT_DATE"
            strSQL &= " ,USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " ,"
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.TIME_STAMP_BYL=("
            strSQL &= " SELECT MAX(TIME_STAMP_BYL)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL"
            strSQL &= " WHERE"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID=SANKASHA_ID"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If
            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
            strSQL &= " ,WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID

            Return strSQL
        End Function

        Public Shared Function Soufujo(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""
            Dim wFlag As Boolean = False

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_KOTSUHOTEL.*"
            strSQL &= " ,WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= " ,WK_KOUENKAI.KAIJO_NAME"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= " ,WK_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= " ,WK_KOUENKAI.FROM_DATE"
            strSQL &= " ,WK_KOUENKAI.TO_DATE"
            strSQL &= " ,USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " ,"
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.TIME_STAMP_BYL=("
            strSQL &= " SELECT MAX(TIME_STAMP_BYL)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOTSUHOTEL"
            strSQL &= " WHERE"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID=SANKASHA_ID"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If
            strSQL &= " ORDER BY WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
            strSQL &= " ,WK_KOTSUHOTEL."
            strSQL &= TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID

            Return strSQL
        End Function

        Public Shared Function DrHiyouCsv(ByVal fromDate As String, ByVal toDate As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK1.KOUENKAI_NO"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",WK_KOUENKAI.KAIJO_NAME"
            strSQL &= ",WK_KOUENKAI.WBS_ELEMENT AS WBS_ELEMENT_KOUENKAI"
            strSQL &= ",WK_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_SEIKYU.SEISAN_YM"
            strSQL &= ",TBL_SEIKYU.SEIKYU_NO_TOPTOUR"
            strSQL &= ",TBL_SHOUNIN.SHIHARAI_NO"
            strSQL &= ",WK_KOUENKAI.BU"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",WK_KOUENKAI.ACCOUNT_CD_TF AS KIHON_ACCOUNT_CD_TF"
            strSQL &= ",WK_KOUENKAI.ACCOUNT_CD_T AS KIHON_ACCOUNT_CD_T"
            strSQL &= ",WK_KOUENKAI.COST_CENTER AS KIHON_COST_CENTER"
            strSQL &= ",WK_KOUENKAI.INTERNAL_ORDER_TF AS KIHON_INTERNAL_ORDER_TF"
            strSQL &= ",WK_KOUENKAI.ZETIA_CD AS KIHON_ZETIA_CD"
            strSQL &= ",WK_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",WK1.SANKASHA_ID"
            strSQL &= ",WK2.SEIKYU_NO_TOPTOUR"
            strSQL &= ",WK2.DR_CD"
            strSQL &= ",WK2.DR_NAME"
            strSQL &= ",WK2.DR_KANA"
            strSQL &= ",WK2.DR_SHISETSU_NAME"
            strSQL &= ",WK2.DR_YAKUWARI"
            strSQL &= ",WK2.WBS_ELEMENT"
            strSQL &= ",WK2.SHITEIGAI_RIYU"
            strSQL &= ",TBL_SANKA.DR_SANKA"
            strSQL &= ",WK2.ANS_HOTELHI"
            strSQL &= ",WK2.ANS_HOTELHI_CANCEL"
            strSQL &= ",WK2.ANS_HOTELHI_TOZEI"
            strSQL &= ",WK2.ANS_RAIL_FARE"
            strSQL &= ",WK2.ANS_RAIL_CANCELLATION"
            strSQL &= ",WK2.ANS_AIR_FARE"
            strSQL &= ",WK2.ANS_AIR_CANCELLATION"
            strSQL &= ",WK2.ANS_OTHER_FARE"
            strSQL &= ",WK2.ANS_OTHER_CANCELLATION"
            strSQL &= ",WK2.ANS_TAXI_TESURYO"
            strSQL &= ",WK2.ANS_KOTSUHOTEL_TESURYO"
            strSQL &= ",WK2.MR_BU"
            strSQL &= ",WK2.MR_AREA"
            strSQL &= ",WK2.MR_EIGYOSHO"
            strSQL &= ",WK2.MR_NAME"
            strSQL &= ",WK2.MR_KANA"
            strSQL &= ",WK2.MR_KEITAI"
            strSQL &= ",WK2.MR_SEND_SAKI_FS"
            strSQL &= ",WK2.MR_SEND_SAKI_OTHER"
            strSQL &= ",WK2.SHONIN_NAME"
            strSQL &= ",WK2.ACCOUNT_CD AS KOTSU_ACCOUNT_CD"
            strSQL &= ",WK2.COST_CENTER AS KOTSU_COST_CENTER"
            strSQL &= ",WK2.INTERNAL_ORDER AS KOTSU_INTERNAL_ORDER"
            strSQL &= ",WK2.ZETIA_CD AS KOTSU_ZETIA_CD"
            strSQL &= ",WK2.REQ_STATUS_TEHAI"
            strSQL &= ",WK2.TIME_STAMP_BYL"
            strSQL &= ",WK2.TEHAI_HOTEL"
            strSQL &= ",WK2.HOTEL_IRAINAIYOU"
            strSQL &= ",WK2.REQ_HOTEL_DATE"
            strSQL &= ",WK2.REQ_HAKUSU"
            strSQL &= ",WK2.REQ_HOTEL_SMOKING"
            strSQL &= ",WK2.REQ_HOTEL_NOTE"
            strSQL &= ",WK2.UPDATE_DATE"
            strSQL &= ",WK2.ANS_STATUS_TEHAI"
            strSQL &= ",WK2.ANS_STATUS_HOTEL"
            strSQL &= ",WK2.ANS_HOTEL_DATE"
            strSQL &= ",WK2.ANS_HAKUSU"
            strSQL &= ",WK2.ANS_HOTEL_NAME"
            strSQL &= ",WK2.ANS_ROOM_TYPE"
            strSQL &= ",WK2.ANS_HOTEL_SMOKING"
            strSQL &= ",WK2.ANS_HOTEL_NOTE"
            strSQL &= ",WK2.ANS_HOTEL_TEL"
            strSQL &= ",WK2.REQ_KOTSU_BIKO"
            strSQL &= ",WK2.REQ_TAXI_NOTE"
            strSQL &= ",WK2.ANS_KOTSU_BIKO"
            strSQL &= ",WK2.ANS_TAXI_NOTE"
            strSQL &= ",WK2.REQ_MR_O_TEHAI"
            strSQL &= ",WK2.REQ_MR_F_TEHAI"
            strSQL &= ",WK2.ANS_MR_O_TEHAI"
            strSQL &= ",WK2.ANS_MR_F_TEHAI"
            strSQL &= ",WK2.ANS_MR_HOTEL_NOTE"
            strSQL &= ",WK2.ANS_O_STATUS_1"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_1"
            strSQL &= ",WK2.ANS_O_DATE_1"
            strSQL &= ",WK2.ANS_O_AIRPORT1_1"
            strSQL &= ",WK2.ANS_O_AIRPORT2_1"
            strSQL &= ",WK2.ANS_O_BIN_1"
            strSQL &= ",WK2.ANS_O_TIME1_1"
            strSQL &= ",WK2.ANS_O_TIME2_1"
            strSQL &= ",WK2.ANS_O_SEAT_1"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU1"
            strSQL &= ",WK2.ANS_F_STATUS_1"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_1"
            strSQL &= ",WK2.ANS_F_DATE_1"
            strSQL &= ",WK2.ANS_F_AIRPORT1_1"
            strSQL &= ",WK2.ANS_F_AIRPORT2_1"
            strSQL &= ",WK2.ANS_F_BIN_1"
            strSQL &= ",WK2.ANS_F_TIME1_1"
            strSQL &= ",WK2.ANS_F_TIME2_1"
            strSQL &= ",WK2.ANS_F_SEAT_1"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU1"
            strSQL &= ",WK2.ANS_O_STATUS_2"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_2"
            strSQL &= ",WK2.ANS_O_DATE_2"
            strSQL &= ",WK2.ANS_O_AIRPORT1_2"
            strSQL &= ",WK2.ANS_O_AIRPORT2_2"
            strSQL &= ",WK2.ANS_O_BIN_2"
            strSQL &= ",WK2.ANS_O_TIME1_2"
            strSQL &= ",WK2.ANS_O_TIME2_2"
            strSQL &= ",WK2.ANS_O_SEAT_2"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU2"
            strSQL &= ",WK2.ANS_F_STATUS_2"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_2"
            strSQL &= ",WK2.ANS_F_DATE_2"
            strSQL &= ",WK2.ANS_F_AIRPORT1_2"
            strSQL &= ",WK2.ANS_F_AIRPORT2_2"
            strSQL &= ",WK2.ANS_F_BIN_2"
            strSQL &= ",WK2.ANS_F_TIME1_2"
            strSQL &= ",WK2.ANS_F_TIME2_2"
            strSQL &= ",WK2.ANS_F_SEAT_2"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU2"
            strSQL &= ",WK2.ANS_O_STATUS_3"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_3"
            strSQL &= ",WK2.ANS_O_DATE_3"
            strSQL &= ",WK2.ANS_O_AIRPORT1_3"
            strSQL &= ",WK2.ANS_O_AIRPORT2_3"
            strSQL &= ",WK2.ANS_O_BIN_3"
            strSQL &= ",WK2.ANS_O_TIME1_3"
            strSQL &= ",WK2.ANS_O_TIME2_3"
            strSQL &= ",WK2.ANS_O_SEAT_3"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU3"
            strSQL &= ",WK2.ANS_F_STATUS_3"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_3"
            strSQL &= ",WK2.ANS_F_DATE_3"
            strSQL &= ",WK2.ANS_F_AIRPORT1_3"
            strSQL &= ",WK2.ANS_F_AIRPORT2_3"
            strSQL &= ",WK2.ANS_F_BIN_3"
            strSQL &= ",WK2.ANS_F_TIME1_3"
            strSQL &= ",WK2.ANS_F_TIME2_3"
            strSQL &= ",WK2.ANS_F_SEAT_3"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU3"
            strSQL &= ",WK2.ANS_O_STATUS_4"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_4"
            strSQL &= ",WK2.ANS_O_DATE_4"
            strSQL &= ",WK2.ANS_O_AIRPORT1_4"
            strSQL &= ",WK2.ANS_O_AIRPORT2_4"
            strSQL &= ",WK2.ANS_O_BIN_4"
            strSQL &= ",WK2.ANS_O_TIME1_4"
            strSQL &= ",WK2.ANS_O_TIME2_4"
            strSQL &= ",WK2.ANS_O_SEAT_4"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU4"
            strSQL &= ",WK2.ANS_F_STATUS_4"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_4"
            strSQL &= ",WK2.ANS_F_DATE_4"
            strSQL &= ",WK2.ANS_F_AIRPORT1_4"
            strSQL &= ",WK2.ANS_F_AIRPORT2_4"
            strSQL &= ",WK2.ANS_F_BIN_4"
            strSQL &= ",WK2.ANS_F_TIME1_4"
            strSQL &= ",WK2.ANS_F_TIME2_4"
            strSQL &= ",WK2.ANS_F_SEAT_4"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU4"
            strSQL &= ",WK2.ANS_O_STATUS_5"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_5"
            strSQL &= ",WK2.ANS_O_DATE_5"
            strSQL &= ",WK2.ANS_O_AIRPORT1_5"
            strSQL &= ",WK2.ANS_O_AIRPORT2_5"
            strSQL &= ",WK2.ANS_O_BIN_5"
            strSQL &= ",WK2.ANS_O_TIME1_5"
            strSQL &= ",WK2.ANS_O_TIME2_5"
            strSQL &= ",WK2.ANS_O_SEAT_5"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU5"
            strSQL &= ",WK2.ANS_F_STATUS_5"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_5"
            strSQL &= ",WK2.ANS_F_DATE_5"
            strSQL &= ",WK2.ANS_F_AIRPORT1_5"
            strSQL &= ",WK2.ANS_F_AIRPORT2_5"
            strSQL &= ",WK2.ANS_F_BIN_5"
            strSQL &= ",WK2.ANS_F_TIME1_5"
            strSQL &= ",WK2.ANS_F_TIME2_5"
            strSQL &= ",WK2.ANS_F_SEAT_5"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU5"
            strSQL &= ",WK2.ANS_MR_HOTELHI"
            strSQL &= ",WK2.ANS_MR_HOTELHI_TOZEI"
            strSQL &= ",WK2.ANS_MR_KOTSUHI"
            strSQL &= " FROM"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "   ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            strSQL &= "  WHERE  WK3.TIME_STAMP = "
            strSQL &= "  (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "   WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            strSQL &= "  )WK_KOUENKAI"
            strSQL &= "    ON WK1.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SANKA "
            strSQL &= " ON WK1.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " AND WK1.SANKASHA_ID = TBL_SANKA.SANKASHA_ID  "
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SHOUNIN "
            strSQL &= " ON WK2.KOUENKAI_NO = TBL_SHOUNIN.KOUENKAI_NO"
            strSQL &= " AND "
            strSQL &= " WK2.SEIKYU_NO_TOPTOUR = TBL_SHOUNIN.SEIKYU_NO_TOPTOUR"
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SEIKYU "
            strSQL &= " ON WK2.KOUENKAI_NO = TBL_SEIKYU.KOUENKAI_NO"
            strSQL &= " AND "
            strSQL &= " WK2.SEIKYU_NO_TOPTOUR = TBL_SEIKYU.SEIKYU_NO_TOPTOUR"
            strSQL &= " WHERE"
            strSQL &= " TBL_SHOUNIN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            ' ''strSQL &= " TBL_SHOUNIN.SHOUNIN_DATE BETWEEN N'20141116' AND N'20141125'"
            strSQL &= " AND TBL_SHOUNIN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            strSQL &= " ORDER BY WK1.KOUENKAI_NO,WK1.SANKASHA_ID"

            Return strSQL
        End Function

        Public Shared Function MrHiyouCsv(ByVal fromDate As String, ByVal toDate As String) As String
            Dim strSQL As String = ""


            'strSQL &= "SELECT WK4.* FROM"
            'strSQL &= " (SELECT "
            'strSQL &= " WK1.KOUENKAI_NO"
            'strSQL &= ",WK2.SEIKYU_NO_TOPTOUR"
            'strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            'strSQL &= ",WK_KOUENKAI.FROM_DATE"
            'strSQL &= ",WK_KOUENKAI.TO_DATE"
            'strSQL &= ",WK_KOUENKAI.KAIJO_NAME"
            'strSQL &= ",WK2.COST_CENTER"
            'strSQL &= ",WK2.MR_BU"
            'strSQL &= ",WK2.MR_AREA"
            'strSQL &= ",WK2.MR_EIGYOSHO"
            'strSQL &= ",WK2.MR_NAME"
            'strSQL &= ",WK2.MR_KANA"
            'strSQL &= ",WK2.REQ_MR_HOTEL_NOTE"
            'strSQL &= ",WK2.ANS_MR_O_TEHAI"
            'strSQL &= ",WK2.ANS_MR_F_TEHAI"
            'strSQL &= ",WK2.ANS_MR_HOTEL_NOTE"
            'strSQL &= ",WK2.SANKASHA_ID"
            'strSQL &= ",WK2.DR_NAME"
            'strSQL &= ",WK2.DR_KANA"
            'strSQL &= ",WK2.DR_SHISETSU_NAME"
            'strSQL &= ",WK2.DR_YAKUWARI"
            'strSQL &= ",CAST(ISNULL(WK2.ANS_MR_HOTELHI,'0') AS BIGINT) AS ANS_MR_HOTELHI"
            'strSQL &= ",CAST(ISNULL(WK2.ANS_MR_HOTELHI_TOZEI,'0') AS BIGINT) AS ANS_MR_HOTELHI_TOZEI"
            'strSQL &= ",CAST(ISNULL(WK2.ANS_MR_KOTSUHI,'0') AS BIGINT) AS ANS_MR_KOTSUHI"
            'strSQL &= " FROM"
            'strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            'strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            'strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            'strSQL &= "  ) WK1"
            'strSQL &= " LEFT JOIN"
            'strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            'strSQL &= "  ON  (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            'strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            'strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            'strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            'strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            'strSQL &= " LEFT JOIN"
            'strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            'strSQL &= "  WHERE  WK3.TIME_STAMP = "
            'strSQL &= "  (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            'strSQL &= "   WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            'strSQL &= "  )WK_KOUENKAI"
            'strSQL &= "    ON WK1.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            'strSQL &= " LEFT JOIN"
            'strSQL &= " TBL_SHOUNIN "
            'strSQL &= " ON WK1.KOUENKAI_NO = TBL_SHOUNIN.KOUENKAI_NO"
            'strSQL &= " AND "
            'strSQL &= " WK2.SEIKYU_NO_TOPTOUR = TBL_SHOUNIN.SEIKYU_NO_TOPTOUR"
            'strSQL &= " WHERE"
            'strSQL &= " TBL_SHOUNIN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            'strSQL &= " AND TBL_SHOUNIN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            'strSQL &= ") WK4"

            strSQL &= " SELECT"
            strSQL &= " WK1.KOUENKAI_NO"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= ",WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",WK_KOUENKAI.KAIJO_NAME"
            strSQL &= ",WK_KOUENKAI.WBS_ELEMENT AS WBS_ELEMENT_KOUENKAI"
            strSQL &= ",WK_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_SEIKYU.SEISAN_YM"
            strSQL &= ",TBL_SEIKYU.SEIKYU_NO_TOPTOUR"
            strSQL &= ",TBL_SHOUNIN.SHIHARAI_NO"
            strSQL &= ",WK_KOUENKAI.BU"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",WK_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",WK_KOUENKAI.ACCOUNT_CD_TF AS KIHON_ACCOUNT_CD_TF"
            strSQL &= ",WK_KOUENKAI.ACCOUNT_CD_T AS KIHON_ACCOUNT_CD_T"
            strSQL &= ",WK_KOUENKAI.COST_CENTER AS KIHON_COST_CENTER"
            strSQL &= ",WK_KOUENKAI.INTERNAL_ORDER_TF AS KIHON_INTERNAL_ORDER_TF"
            strSQL &= ",WK_KOUENKAI.ZETIA_CD AS KIHON_ZETIA_CD"
            strSQL &= ",WK_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",WK1.SANKASHA_ID"
            strSQL &= ",WK2.SEIKYU_NO_TOPTOUR"
            strSQL &= ",WK2.DR_CD"
            strSQL &= ",WK2.DR_NAME"
            strSQL &= ",WK2.DR_KANA"
            strSQL &= ",WK2.DR_SHISETSU_NAME"
            strSQL &= ",WK2.DR_YAKUWARI"
            strSQL &= ",WK2.WBS_ELEMENT"
            strSQL &= ",WK2.SHITEIGAI_RIYU"
            strSQL &= ",TBL_SANKA.DR_SANKA"
            strSQL &= ",WK2.ANS_HOTELHI"
            strSQL &= ",WK2.ANS_HOTELHI_CANCEL"
            strSQL &= ",WK2.ANS_HOTELHI_TOZEI"
            strSQL &= ",WK2.ANS_RAIL_FARE"
            strSQL &= ",WK2.ANS_RAIL_CANCELLATION"
            strSQL &= ",WK2.ANS_AIR_FARE"
            strSQL &= ",WK2.ANS_AIR_CANCELLATION"
            strSQL &= ",WK2.ANS_OTHER_FARE"
            strSQL &= ",WK2.ANS_OTHER_CANCELLATION"
            strSQL &= ",WK2.ANS_TAXI_TESURYO"
            strSQL &= ",WK2.ANS_KOTSUHOTEL_TESURYO"
            strSQL &= ",WK2.MR_BU"
            strSQL &= ",WK2.MR_AREA"
            strSQL &= ",WK2.MR_EIGYOSHO"
            strSQL &= ",WK2.MR_NAME"
            strSQL &= ",WK2.MR_KANA"
            strSQL &= ",WK2.MR_KEITAI"
            strSQL &= ",WK2.MR_SEND_SAKI_FS"
            strSQL &= ",WK2.MR_SEND_SAKI_OTHER"
            strSQL &= ",WK2.SHONIN_NAME"
            strSQL &= ",WK2.ACCOUNT_CD AS KOTSU_ACCOUNT_CD"
            strSQL &= ",WK2.COST_CENTER AS KOTSU_COST_CENTER"
            strSQL &= ",WK2.INTERNAL_ORDER AS KOTSU_INTERNAL_ORDER"
            strSQL &= ",WK2.ZETIA_CD AS KOTSU_ZETIA_CD"
            strSQL &= ",WK2.REQ_STATUS_TEHAI"
            strSQL &= ",WK2.TIME_STAMP_BYL"
            strSQL &= ",WK2.TEHAI_HOTEL"
            strSQL &= ",WK2.HOTEL_IRAINAIYOU"
            strSQL &= ",WK2.REQ_HOTEL_DATE"
            strSQL &= ",WK2.REQ_HAKUSU"
            strSQL &= ",WK2.REQ_HOTEL_SMOKING"
            strSQL &= ",WK2.REQ_HOTEL_NOTE"
            strSQL &= ",WK2.UPDATE_DATE"
            strSQL &= ",WK2.ANS_STATUS_TEHAI"
            strSQL &= ",WK2.ANS_STATUS_HOTEL"
            strSQL &= ",WK2.ANS_HOTEL_DATE"
            strSQL &= ",WK2.ANS_HAKUSU"
            strSQL &= ",WK2.ANS_HOTEL_NAME"
            strSQL &= ",WK2.ANS_ROOM_TYPE"
            strSQL &= ",WK2.ANS_HOTEL_SMOKING"
            strSQL &= ",WK2.ANS_HOTEL_NOTE"
            strSQL &= ",WK2.ANS_HOTEL_TEL"
            strSQL &= ",WK2.REQ_KOTSU_BIKO"
            strSQL &= ",WK2.REQ_TAXI_NOTE"
            strSQL &= ",WK2.ANS_KOTSU_BIKO"
            strSQL &= ",WK2.ANS_TAXI_NOTE"
            strSQL &= ",WK2.REQ_MR_O_TEHAI"
            strSQL &= ",WK2.REQ_MR_F_TEHAI"
            strSQL &= ",WK2.ANS_MR_O_TEHAI"
            strSQL &= ",WK2.ANS_MR_F_TEHAI"
            strSQL &= ",WK2.ANS_MR_HOTEL_NOTE"
            strSQL &= ",WK2.ANS_O_STATUS_1"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_1"
            strSQL &= ",WK2.ANS_O_DATE_1"
            strSQL &= ",WK2.ANS_O_AIRPORT1_1"
            strSQL &= ",WK2.ANS_O_AIRPORT2_1"
            strSQL &= ",WK2.ANS_O_BIN_1"
            strSQL &= ",WK2.ANS_O_TIME1_1"
            strSQL &= ",WK2.ANS_O_TIME2_1"
            strSQL &= ",WK2.ANS_O_SEAT_1"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU1"
            strSQL &= ",WK2.ANS_F_STATUS_1"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_1"
            strSQL &= ",WK2.ANS_F_DATE_1"
            strSQL &= ",WK2.ANS_F_AIRPORT1_1"
            strSQL &= ",WK2.ANS_F_AIRPORT2_1"
            strSQL &= ",WK2.ANS_F_BIN_1"
            strSQL &= ",WK2.ANS_F_TIME1_1"
            strSQL &= ",WK2.ANS_F_TIME2_1"
            strSQL &= ",WK2.ANS_F_SEAT_1"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU1"
            strSQL &= ",WK2.ANS_O_STATUS_2"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_2"
            strSQL &= ",WK2.ANS_O_DATE_2"
            strSQL &= ",WK2.ANS_O_AIRPORT1_2"
            strSQL &= ",WK2.ANS_O_AIRPORT2_2"
            strSQL &= ",WK2.ANS_O_BIN_2"
            strSQL &= ",WK2.ANS_O_TIME1_2"
            strSQL &= ",WK2.ANS_O_TIME2_2"
            strSQL &= ",WK2.ANS_O_SEAT_2"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU2"
            strSQL &= ",WK2.ANS_F_STATUS_2"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_2"
            strSQL &= ",WK2.ANS_F_DATE_2"
            strSQL &= ",WK2.ANS_F_AIRPORT1_2"
            strSQL &= ",WK2.ANS_F_AIRPORT2_2"
            strSQL &= ",WK2.ANS_F_BIN_2"
            strSQL &= ",WK2.ANS_F_TIME1_2"
            strSQL &= ",WK2.ANS_F_TIME2_2"
            strSQL &= ",WK2.ANS_F_SEAT_2"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU2"
            strSQL &= ",WK2.ANS_O_STATUS_3"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_3"
            strSQL &= ",WK2.ANS_O_DATE_3"
            strSQL &= ",WK2.ANS_O_AIRPORT1_3"
            strSQL &= ",WK2.ANS_O_AIRPORT2_3"
            strSQL &= ",WK2.ANS_O_BIN_3"
            strSQL &= ",WK2.ANS_O_TIME1_3"
            strSQL &= ",WK2.ANS_O_TIME2_3"
            strSQL &= ",WK2.ANS_O_SEAT_3"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU3"
            strSQL &= ",WK2.ANS_F_STATUS_3"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_3"
            strSQL &= ",WK2.ANS_F_DATE_3"
            strSQL &= ",WK2.ANS_F_AIRPORT1_3"
            strSQL &= ",WK2.ANS_F_AIRPORT2_3"
            strSQL &= ",WK2.ANS_F_BIN_3"
            strSQL &= ",WK2.ANS_F_TIME1_3"
            strSQL &= ",WK2.ANS_F_TIME2_3"
            strSQL &= ",WK2.ANS_F_SEAT_3"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU3"
            strSQL &= ",WK2.ANS_O_STATUS_4"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_4"
            strSQL &= ",WK2.ANS_O_DATE_4"
            strSQL &= ",WK2.ANS_O_AIRPORT1_4"
            strSQL &= ",WK2.ANS_O_AIRPORT2_4"
            strSQL &= ",WK2.ANS_O_BIN_4"
            strSQL &= ",WK2.ANS_O_TIME1_4"
            strSQL &= ",WK2.ANS_O_TIME2_4"
            strSQL &= ",WK2.ANS_O_SEAT_4"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU4"
            strSQL &= ",WK2.ANS_F_STATUS_4"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_4"
            strSQL &= ",WK2.ANS_F_DATE_4"
            strSQL &= ",WK2.ANS_F_AIRPORT1_4"
            strSQL &= ",WK2.ANS_F_AIRPORT2_4"
            strSQL &= ",WK2.ANS_F_BIN_4"
            strSQL &= ",WK2.ANS_F_TIME1_4"
            strSQL &= ",WK2.ANS_F_TIME2_4"
            strSQL &= ",WK2.ANS_F_SEAT_4"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU4"
            strSQL &= ",WK2.ANS_O_STATUS_5"
            strSQL &= ",WK2.ANS_O_KOTSUKIKAN_5"
            strSQL &= ",WK2.ANS_O_DATE_5"
            strSQL &= ",WK2.ANS_O_AIRPORT1_5"
            strSQL &= ",WK2.ANS_O_AIRPORT2_5"
            strSQL &= ",WK2.ANS_O_BIN_5"
            strSQL &= ",WK2.ANS_O_TIME1_5"
            strSQL &= ",WK2.ANS_O_TIME2_5"
            strSQL &= ",WK2.ANS_O_SEAT_5"
            strSQL &= ",WK2.ANS_O_SEAT_KIBOU5"
            strSQL &= ",WK2.ANS_F_STATUS_5"
            strSQL &= ",WK2.ANS_F_KOTSUKIKAN_5"
            strSQL &= ",WK2.ANS_F_DATE_5"
            strSQL &= ",WK2.ANS_F_AIRPORT1_5"
            strSQL &= ",WK2.ANS_F_AIRPORT2_5"
            strSQL &= ",WK2.ANS_F_BIN_5"
            strSQL &= ",WK2.ANS_F_TIME1_5"
            strSQL &= ",WK2.ANS_F_TIME2_5"
            strSQL &= ",WK2.ANS_F_SEAT_5"
            strSQL &= ",WK2.ANS_F_SEAT_KIBOU5"
            strSQL &= ",WK2.ANS_MR_HOTELHI"
            strSQL &= ",WK2.ANS_MR_HOTELHI_TOZEI"
            strSQL &= ",WK2.ANS_MR_KOTSUHI"
            strSQL &= " FROM"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "   ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            strSQL &= "  WHERE  WK3.TIME_STAMP = "
            strSQL &= "  (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "   WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            strSQL &= "  )WK_KOUENKAI"
            strSQL &= "    ON WK1.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SANKA "
            strSQL &= " ON WK1.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " AND WK1.SANKASHA_ID = TBL_SANKA.SANKASHA_ID  "
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SHOUNIN "
            strSQL &= " ON WK2.KOUENKAI_NO = TBL_SHOUNIN.KOUENKAI_NO"
            strSQL &= " AND "
            strSQL &= " WK2.SEIKYU_NO_TOPTOUR = TBL_SHOUNIN.SEIKYU_NO_TOPTOUR"
            strSQL &= " LEFT JOIN"
            strSQL &= " TBL_SEIKYU "
            strSQL &= " ON WK2.KOUENKAI_NO = TBL_SEIKYU.KOUENKAI_NO"
            strSQL &= " AND "
            strSQL &= " WK2.SEIKYU_NO_TOPTOUR = TBL_SEIKYU.SEIKYU_NO_TOPTOUR"
            strSQL &= " WHERE"
            strSQL &= " TBL_SHOUNIN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            strSQL &= " AND TBL_SHOUNIN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            strSQL &= " AND ((WK2.ANS_MR_HOTELHI <> 0) OR (WK2.ANS_MR_HOTELHI_TOZEI <> 0) OR (WK2.ANS_MR_KOTSUHI <> 0))"
            strSQL &= " ORDER BY WK2.KOUENKAI_NO,WK2.COST_CENTER"

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KOTSUHOTEL"
            strSQL &= "(" & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_KANA
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI_TOZEI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI_CANCEL
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSUHOTEL_TESURYO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TESURYO
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TICKET_SEND_DAY
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
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_20
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_O_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_F_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_SEX
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.MR_AGE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.REQ_MR_HOTEL_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_O_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_F_TEHAI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NOTE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_KOTSUHI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI_TOZEI
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TTANTO_ID
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEIKYU_NO_TOPTOUR
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.KINKYU_FLAG
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.YOBI1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.YOBI2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.YOBI3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.YOBI4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.YOBI5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.WBS_ELEMENT
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_1
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_2
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_3
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_4
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_5
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_6
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_7
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_8
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_9
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_10
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_11
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_12
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_13
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_14
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_15
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_16
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_17
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_18
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_19
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_20
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SALEFORCE_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_STATUS_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_TOP) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_KANA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_YAKUWARI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SEX) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_AGE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHITEIGAI_RIYU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SANKA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_BU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AREA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EIGYOSHO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_ROMA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KANA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL_PC) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_EMAIL_KEITAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_KEITAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_FS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ACCOUNT_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.COST_CENTER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INTERNAL_ORDER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ZETIA_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SHONIN_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_HOTEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.HOTEL_IRAINAIYOU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HAKUSU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_SMOKING) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_HOTEL_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_HOTEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HAKUSU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKIN_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_ROOM_TYPE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTELHI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTELHI_TOZEI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTELHI_CANCEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TEHAI_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_AIRPORT2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_TIME2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_BIN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TEHAI_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_AIRPORT2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_TIME2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_BIN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_KOTSU_BIKO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_KOTSU_BIKO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_FARE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_FARE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_FARE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_KOTSUHOTEL_TESURYO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TESURYO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TEHAI_TAXI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_DATE_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_FROM_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_TAXI_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_20) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_O_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_F_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_SEX) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.MR_AGE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_O_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_F_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_KOTSUHI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTELHI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTELHI_TOZEI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_FLAG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TTANTO_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SCAN_IMPORT_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KINKYU_FLAG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.YOBI1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.YOBI2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.YOBI3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.YOBI4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.YOBI5) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.WBS_ELEMENT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_3) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_4) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_5) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_6) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_7) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_8) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_9) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_10) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_11) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_12) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_13) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_14) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_15) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_16) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_17) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_18) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_19) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_20) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_TEHAI) & "'"
            'strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_TOP & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_HOTEL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_STATUS_HOTEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NAME & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_ADDRESS & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_TEL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_DATE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HAKUSU & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HAKUSU) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKIN_TIME & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_CHECKOUT_TIME & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_CHECKOUT_TIME) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_ROOM_TYPE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_ROOM_TYPE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_SMOKING & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_SMOKING) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTEL_NOTE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTEL_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTELHI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI_TOZEI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTELHI_TOZEI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_HOTELHI_CANCEL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_HOTELHI_CANCEL) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_STATUS_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_STATUS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_KOTSUKIKAN_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_DATE_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT1_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_AIRPORT2_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME1_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_TIME2_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_BIN_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_O_SEAT_KIBOU5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_O_SEAT_KIBOU5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_STATUS_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_STATUS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_KOTSUKIKAN_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_KOTSUKIKAN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_DATE_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT1_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_AIRPORT2_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_AIRPORT2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME1_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME1_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_TIME2_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_TIME2_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_BIN_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_BIN_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_F_SEAT_KIBOU5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_F_SEAT_KIBOU5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSU_BIKO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_KOTSU_BIKO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_FARE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_RAIL_CANCELLATION & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_RAIL_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_FARE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_OTHER_CANCELLATION & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_OTHER_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_FARE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_FARE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_AIR_CANCELLATION & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_AIR_CANCELLATION) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_KOTSUHOTEL_TESURYO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_KOTSUHOTEL_TESURYO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_TESURYO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_TESURYO) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TICKET_SEND_DAY & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_DATE_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NOTE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_O_TEHAI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_O_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_F_TEHAI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_F_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTEL_NOTE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTEL_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_KOTSUHI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_KOTSUHI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTELHI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_MR_HOTELHI_TOZEI & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_MR_HOTELHI_TOZEI) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.TTANTO_ID & "=N'" & GetValue.USER() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SCAN_IMPORT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_DATE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_1) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_2) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_3) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_4) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_5) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_6) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_7) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_8) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_9) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_10) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_11) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_12) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_13) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_14) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_15) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_16) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_17) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_18) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_19) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_SRMKS_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_20) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_SEND_FLAG(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_DR_SANKA(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_SANKA) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_TaxiPrint(ByVal TKT_LINE_NO As String, ByVal ANS_TAXI_HAKKO_DATE As String, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            Select Case CmnModule.DbVal(TKT_LINE_NO)
                Case 1
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_1 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 2
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_2 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 3
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_3 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 4
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_4 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 5
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_5 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 6
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_6 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 7
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_7 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 8
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_8 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 9
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_9 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 10
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_10 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 11
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_11 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 12
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_12 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 13
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_13 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 14
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_14 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 15
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_15 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 16
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_16 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 17
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_17 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 18
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_18 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 19
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_19 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
                Case 20
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_20 & "=N'" & CmnDb.SqlString(ANS_TAXI_HAKKO_DATE) & "'"
            End Select

            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.DR_MPID) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_TaxiScan(ByVal TKT_LINE_NO As String, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            Select Case CmnModule.DbVal(TKT_LINE_NO)
                Case 1
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_1) & "'"
                Case 2
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_2) & "'"
                Case 3
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_3) & "'"
                Case 4
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_4) & "'"
                Case 5
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_5) & "'"
                Case 6
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_6) & "'"
                Case 7
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_7) & "'"
                Case 8
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_8) & "'"
                Case 9
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_9) & "'"
                Case 10
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_10) & "'"
                Case 11
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_11) & "'"
                Case 12
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_12) & "'"
                Case 13
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_13) & "'"
                Case 14
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_14) & "'"
                Case 15
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_15) & "'"
                Case 16
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_16) & "'"
                Case 17
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_17) & "'"
                Case 18
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_18) & "'"
                Case 19
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_19) & "'"
                Case 20
                    strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20 & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.ANS_TAXI_NO_20) & "'"
            End Select

            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SCAN_IMPORT_DATE & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SCAN_IMPORT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.SANKASHA_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=N'" & CmnDb.SqlString(TBL_KOTSUHOTEL.TIME_STAMP_BYL) & "'"
            strSQL &= " AND LTRIM(RTRIM(" & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "))=N'" & CmnDb.SqlString(Trim(TBL_KOTSUHOTEL.DR_MPID)) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_SEIKYU_NO(ByVal KOUENKAI_NO As String, ByVal SEIKYU_NO_TOPTOUR As String, ByVal UPDATE_USER As String) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND RTRIM(ISNULL(" & TableDef.TBL_KOTSUHOTEL.Column.SEIKYU_NO_TOPTOUR & ",'')) = ''"

            Return strSQL
        End Function

        Public Shared Function Update_IkkatsuTehai(ByVal whereData As StringDictionary, ByVal pLoginID As String) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KOTSUHOTEL SET"
            strSQL &= " " & TableDef.TBL_KOTSUHOTEL.Column.ANS_STATUS_TEHAI & "=N'" & AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.SEND_FLAG & "=N'" & AppConst.SEND_FLAG.Code.Taisho & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KOTSUHOTEL.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(pLoginID) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID & "=N'" & whereData(TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO & "=N'" & whereData(TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=N'" & whereData(TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=N'" & whereData(TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL) & "'"
            strSQL &= " AND " & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID & "=N'" & whereData(TableDef.TBL_KOTSUHOTEL.Column.DR_MPID) & "'"

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

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
        & " TBL_KAIJO.KOUENKAI_NO" _
        & ",TBL_KAIJO.TIME_STAMP_BYL"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_TEHAI_ID(ByVal KOUENKAI_NO As String, ByVal TEHAI_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(TEHAI_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_TEHAI_ID_TIME_STAMP_BYL(ByVal KOUENKAI_NO As String, ByVal TEHAI_ID As String, ByVal TIME_STAMP_BYL As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(TEHAI_ID) & "'"
            strSQL &= " AND TBL_KAIJO.TIME_STAMP_BYL>N'" & CmnDb.SqlString(TIME_STAMP_BYL) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function OldData(ByVal KOUENKAI_NO As String, ByVal TEHAI_ID As String, ByVal TIME_STAMP_BYL As String) As String
            Dim strSQL As String = ""
            Dim strSQL_WHERE_KAIJO As String = ""
            Dim strSQL_WHERE_KOUENKAI As String = ""

            'WHERE
            '会場手配テーブル
            strSQL_WHERE_KAIJO &= " WHERE 1=1"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(TEHAI_ID) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.TIME_STAMP_BYL<N'" & CmnDb.SqlString(TIME_STAMP_BYL) & "'"

            '会合テーブル
            strSQL_WHERE_KOUENKAI &= " WHERE 1=1"
            strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.TORIKESHI_FLG"
            strSQL &= ",TBL_KOUENKAI.KIDOKU_FLG"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KAIJO_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_T"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_TF"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_T"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_TF"
            strSQL &= ",TBL_KOUENKAI.ZETIA_CD"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR"
            strSQL &= ",TBL_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.COST_CENTER"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.YOSAN_TF"
            strSQL &= ",TBL_KOUENKAI.YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",TBL_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ",TBL_KOUENKAI.IROUKAI_YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.IKENKOUKAN_YOSAN_T"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM"
            strSQL &= "("
            strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ","
            strSQL &= "("
            strSQL &= " SELECT TBL_KAIJO_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO
            strSQL &= ") AS TBL_KAIJO_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL,KOUENKAI_NO,TEHAI_ID FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO
            strSQL &= " GROUP BY KOUENKAI_NO,TEHAI_ID) AS TBL_KAIJO_2"
            strSQL &= "  WHERE TBL_KAIJO_1.TIME_STAMP_BYL=TBL_KAIJO_2.TIME_STAMP_BYL"
            strSQL &= "   AND TBL_KAIJO_1.KOUENKAI_NO=TBL_KAIJO_2.KOUENKAI_NO"
            strSQL &= "   AND TBL_KAIJO_1.TEHAI_ID=TBL_KAIJO_2.TEHAI_ID"
            strSQL &= ") AS TBL_KAIJO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KAIJO.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_TEHAI_ID_TIME_STAMP_BYL_DESC(ByVal KOUENKAI_NO As String, ByVal TEHAI_ID As String, ByVal TIME_STAMP_BYL As String) As String
            Dim strSQL As String = ""
            Dim strSQL_WHERE_KAIJO As String = ""
            Dim strSQL_WHERE_KOUENKAI As String = ""

            'WHERE
            '会場手配テーブル
            strSQL_WHERE_KAIJO &= " WHERE 1=1"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(TEHAI_ID) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.TIME_STAMP_BYL>N'" & CmnDb.SqlString(TIME_STAMP_BYL) & "'"

            '会合テーブル
            strSQL_WHERE_KOUENKAI &= " WHERE 1=1"
            strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.TORIKESHI_FLG"
            strSQL &= ",TBL_KOUENKAI.KIDOKU_FLG"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KAIJO_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_T"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_TF"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_T"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_TF"
            strSQL &= ",TBL_KOUENKAI.ZETIA_CD"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR"
            strSQL &= ",TBL_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.COST_CENTER"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.YOSAN_TF"
            strSQL &= ",TBL_KOUENKAI.YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",TBL_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ",TBL_KOUENKAI.IROUKAI_YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.IKENKOUKAN_YOSAN_T"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM"
            strSQL &= "("
            strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ","
            strSQL &= "("
            strSQL &= " SELECT TBL_KAIJO_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO
            strSQL &= ") AS TBL_KAIJO_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL,KOUENKAI_NO,TEHAI_ID FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO
            strSQL &= " GROUP BY KOUENKAI_NO,TEHAI_ID) AS TBL_KAIJO_2"
            strSQL &= "  WHERE TBL_KAIJO_1.TIME_STAMP_BYL=TBL_KAIJO_2.TIME_STAMP_BYL"
            strSQL &= "   AND TBL_KAIJO_1.KOUENKAI_NO=TBL_KAIJO_2.KOUENKAI_NO"
            strSQL &= "   AND TBL_KAIJO_1.TEHAI_ID=TBL_KAIJO_2.TEHAI_ID"
            strSQL &= ") AS TBL_KAIJO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KAIJO.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function bySEND_FLAG(ByVal SEND_FLAG As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT DISTINCT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",WK_KOUENKAI.FROM_DATE"
            strSQL &= " FROM"
            strSQL &= " TBL_KAIJO"
            strSQL &= " ,TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " TBL_KAIJO.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " TBL_KAIJO.SEND_FLAG=N'" & CmnDb.SqlString(SEND_FLAG) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct, ByVal NewData As Boolean) As String
            Dim strSQL As String = ""
            Dim strSQL_WHERE_KAIJO1 As String = ""
            Dim strSQL_WHERE_KAIJO2 As String = ""
            Dim strSQL_WHERE_KOUENKAI As String = ""

            'WHERE
            '会場手配テーブル
            strSQL_WHERE_KAIJO1 &= " WHERE 1=1"
            strSQL_WHERE_KAIJO2 &= " WHERE 1=1"
            If NewData = True Then
                strSQL_WHERE_KAIJO1 &= " AND ISNULL(TBL_KAIJO.ANS_STATUS_TEHAI,N'')=N'" & AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai & "'"
            End If
            If Trim(Joken.REQ_STATUS_TEHAI) <> "" Then
                strSQL_WHERE_KAIJO1 &= " AND TBL_KAIJO.REQ_STATUS_TEHAI=N'" & CmnDb.SqlString(Joken.REQ_STATUS_TEHAI) & "'"
                strSQL_WHERE_KAIJO2 &= " AND TBL_KAIJO.REQ_STATUS_TEHAI=N'" & CmnDb.SqlString(Joken.REQ_STATUS_TEHAI) & "'"
            End If
            If Trim(Joken.UPDATE_DATE) <> "" Then
                strSQL_WHERE_KAIJO1 &= " AND TBL_KAIJO.UPDATE_DATE=N'" & CmnDb.SqlString(Joken.UPDATE_DATE) & "'"
                strSQL_WHERE_KAIJO2 &= " AND TBL_KAIJO.UPDATE_DATE=N'" & CmnDb.SqlString(Joken.UPDATE_DATE) & "'"
            End If
            If Trim(Joken.TIME_STAMP_BYL) <> "" Then
                strSQL_WHERE_KAIJO1 &= " AND TBL_KAIJO.TIME_STAMP_BYL=N'" & CmnDb.SqlString(Joken.TIME_STAMP_BYL) & "'"
                strSQL_WHERE_KAIJO2 &= " AND TBL_KAIJO.TIME_STAMP_BYL=N'" & CmnDb.SqlString(Joken.TIME_STAMP_BYL) & "'"
            End If
            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL_WHERE_KAIJO1 &= " AND TBL_KAIJO.KOUENKAI_NO LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
                strSQL_WHERE_KAIJO2 &= " AND TBL_KAIJO.KOUENKAI_NO LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If
            If Trim(Joken.TEHAI_ID) <> "" Then
                strSQL_WHERE_KAIJO1 &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(Joken.TEHAI_ID) & "'"
                strSQL_WHERE_KAIJO2 &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(Joken.TEHAI_ID) & "'"
            End If

            '会合テーブル
            strSQL_WHERE_KOUENKAI &= " WHERE 1=1"
            If Trim(Joken.BU) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.BU=N'" & CmnDb.SqlString(Joken.BU) & "'"
            End If

            If Trim(Joken.AREA) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KIKAKU_TANTO_AREA=N'" & CmnDb.SqlString(Joken.AREA) & "'"
            End If

            If Trim(Joken.EIGYOSHO) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO LIKE N'%" & CmnDb.SqlString(Joken.EIGYOSHO) & "%'"
            End If

            If Trim(Joken.TTEHAI_TANTO) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.TTEHAI_TANTO=N'" & CmnDb.SqlString(Joken.TTEHAI_TANTO) & "'"
            End If

            If Trim(Joken.KIKAKU_TANTO_ROMA) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND ("
                strSQL_WHERE_KOUENKAI &= "      TBL_KOUENKAI.KIKAKU_TANTO_ROMA LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_ROMA) & "%'"
                strSQL_WHERE_KOUENKAI &= ")"
            End If
            If Trim(Joken.KIKAKU_TANTO_NAME) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND ("
                strSQL_WHERE_KOUENKAI &= "      TBL_KOUENKAI.KIKAKU_TANTO_NAME LIKE N'%" & CmnDb.SqlString(Joken.KIKAKU_TANTO_NAME) & "%'"
                strSQL_WHERE_KOUENKAI &= ")"
            End If

            If Trim(Joken.TEHAI_TANTO_ROMA) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND ("
                strSQL_WHERE_KOUENKAI &= "      TBL_KOUENKAI.TEHAI_TANTO_ROMA LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_ROMA) & "%'"
                strSQL_WHERE_KOUENKAI &= ")"
            End If
            If Trim(Joken.TEHAI_TANTO_NAME) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND ("
                strSQL_WHERE_KOUENKAI &= "      TBL_KOUENKAI.TEHAI_TANTO_NAME LIKE N'%" & CmnDb.SqlString(Joken.TEHAI_TANTO_NAME) & "%'"
                strSQL_WHERE_KOUENKAI &= ")"
            End If

            If Trim(Joken.SEIHIN_NAME) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.SEIHIN_NAME=N'" & CmnDb.SqlString(Joken.SEIHIN_NAME) & "'"
            End If

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NO LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "%'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NAME LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.FROM_DATE BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.FROM_DATE=N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.FROM_DATE=N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.TORIKESHI_FLG"
            strSQL &= ",TBL_KOUENKAI.KIDOKU_FLG"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KAIJO_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_T"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_TF"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_T"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_TF"
            strSQL &= ",TBL_KOUENKAI.ZETIA_CD"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR"
            strSQL &= ",TBL_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.COST_CENTER"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.YOSAN_TF"
            strSQL &= ",TBL_KOUENKAI.YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",TBL_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ",TBL_KOUENKAI.IROUKAI_YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.IKENKOUKAN_YOSAN_T"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM"
            strSQL &= "("
            strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ","
            strSQL &= "("
            strSQL &= " SELECT TBL_KAIJO_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO1
            strSQL &= ") AS TBL_KAIJO_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL,KOUENKAI_NO,TEHAI_ID FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO2
            strSQL &= " GROUP BY KOUENKAI_NO,TEHAI_ID) AS TBL_KAIJO_2"
            strSQL &= "  WHERE TBL_KAIJO_1.TIME_STAMP_BYL=TBL_KAIJO_2.TIME_STAMP_BYL"
            strSQL &= "   AND TBL_KAIJO_1.KOUENKAI_NO=TBL_KAIJO_2.KOUENKAI_NO"
            strSQL &= "   AND TBL_KAIJO_1.TEHAI_ID=TBL_KAIJO_2.TEHAI_ID"
            strSQL &= ") AS TBL_KAIJO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KAIJO.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function Print(ByVal SALEFORCE_ID As String, ByVal TEHAI_ID As String, ByVal KOUENKAI_NO As String, ByVal TIME_STAMP_BYL As String) As String
            Dim strSQL As String = ""
            Dim strSQL_WHERE_KAIJO As String = ""
            Dim strSQL_WHERE_KOUENKAI As String = ""

            'WHERE
            '会場手配テーブル
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.SALEFORCE_ID=N'" & CmnDb.SqlString(SALEFORCE_ID) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(TEHAI_ID) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL_WHERE_KAIJO &= " AND TBL_KAIJO.TIME_STAMP_BYL=N'" & CmnDb.SqlString(TIME_STAMP_BYL) & "'"

            '会合テーブル
            strSQL_WHERE_KOUENKAI &= " WHERE 1=1"
            strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"

            strSQL &= "SELECT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.TORIKESHI_FLG"
            strSQL &= ",TBL_KOUENKAI.KIDOKU_FLG"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KAIJO_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_T"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_TF"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_T"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_TF"
            strSQL &= ",TBL_KOUENKAI.ZETIA_CD"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR"
            strSQL &= ",TBL_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.COST_CENTER"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.YOSAN_TF"
            strSQL &= ",TBL_KOUENKAI.YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",TBL_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ",TBL_KOUENKAI.IROUKAI_YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.IKENKOUKAN_YOSAN_T"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM"
            strSQL &= "("
            strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ",TBL_KAIJO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"
            strSQL &= strSQL_WHERE_KAIJO

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KAIJO.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function NewListPrint(ByVal KOUENKAI_NO() As String, ByVal TEHAI_ID() As String) As String
            Dim strSQL As String = ""
            Dim strSQL_WHERE_KAIJO As String = ""
            Dim strSQL_WHERE_KOUENKAI As String = ""
            Dim wCnt As Integer = 0
            Dim wStr As String = ""

            'WHERE
            '会場手配テーブル
            wStr = ""
            strSQL_WHERE_KAIJO &= " WHERE 1=1"
            strSQL_WHERE_KAIJO &= " AND ISNULL(TBL_KAIJO.ANS_STATUS_TEHAI,N'')=N'" & AppConst.KAIJO.ANS_STATUS_TEHAI.Code.NewTehai & "'"
            strSQL_WHERE_KAIJO &= " AND ("
            For wCnt = LBound(KOUENKAI_NO) To UBound(KOUENKAI_NO)
                If wCnt > 0 Then wStr &= " OR "
                wStr &= "(TBL_KAIJO.KOUENKAI_NO=N'" & KOUENKAI_NO(wCnt) & "' AND TBL_KAIJO.TEHAI_ID=N'" & TEHAI_ID(wCnt) & "')"
            Next wCnt
            strSQL_WHERE_KAIJO &= wStr
            strSQL_WHERE_KAIJO &= ")"

            '会合テーブル
            wStr = ""
            strSQL_WHERE_KOUENKAI &= " WHERE 1=1"
            strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NO IN("
            For wCnt = LBound(KOUENKAI_NO) To UBound(KOUENKAI_NO)
                If wCnt > 0 Then wStr &= ","
                wStr &= "N'" & KOUENKAI_NO(wCnt) & "'"
            Next wCnt
            strSQL_WHERE_KOUENKAI &= wStr
            strSQL_WHERE_KOUENKAI &= ")"

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.TORIKESHI_FLG"
            strSQL &= ",TBL_KOUENKAI.KIDOKU_FLG"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KAIJO_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_T"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_TF"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_T"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_TF"
            strSQL &= ",TBL_KOUENKAI.ZETIA_CD"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR"
            strSQL &= ",TBL_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.COST_CENTER"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.YOSAN_TF"
            strSQL &= ",TBL_KOUENKAI.YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",TBL_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ",TBL_KOUENKAI.IROUKAI_YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.IKENKOUKAN_YOSAN_T"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM"
            strSQL &= "("
            strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= ","
            strSQL &= "("
            strSQL &= " SELECT TBL_KAIJO_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KAIJO"
            strSQL &= strSQL_WHERE_KAIJO
            strSQL &= ") AS TBL_KAIJO_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP_BYL) AS TIME_STAMP_BYL,KOUENKAI_NO,TEHAI_ID FROM TBL_KAIJO"
            strSQL &= " GROUP BY KOUENKAI_NO,TEHAI_ID) AS TBL_KAIJO_2"
            strSQL &= "  WHERE TBL_KAIJO_1.TIME_STAMP_BYL=TBL_KAIJO_2.TIME_STAMP_BYL"
            strSQL &= "   AND TBL_KAIJO_1.KOUENKAI_NO=TBL_KAIJO_2.KOUENKAI_NO"
            strSQL &= "   AND TBL_KAIJO_1.TEHAI_ID=TBL_KAIJO_2.TEHAI_ID"
            strSQL &= ") AS TBL_KAIJO"
            strSQL &= ","
            strSQL &= "(SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= ") AS MS_USER"
            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"

            strSQL &= " ORDER BY"
            strSQL &= " TBL_KAIJO.TIME_STAMP_BYL DESC"

            Return strSQL
        End Function

        Public Shared Function Rireki(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " DISTINCT"
            strSQL &= " TBL_KAIJO.*"
            strSQL &= ",TBL_KOUENKAI.TIME_STAMP"
            strSQL &= ",TBL_KOUENKAI.TORIKESHI_FLG"
            strSQL &= ",TBL_KOUENKAI.KIDOKU_FLG"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_TITLE"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.TAXI_PRT_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KAIJO_NAME"
            strSQL &= ",TBL_KOUENKAI.SEIHIN_NAME"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_T"
            strSQL &= ",TBL_KOUENKAI.INTERNAL_ORDER_TF"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_T"
            strSQL &= ",TBL_KOUENKAI.ACCOUNT_CD_TF"
            strSQL &= ",TBL_KOUENKAI.ZETIA_CD"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_NMBR"
            strSQL &= ",TBL_KOUENKAI.SANKA_YOTEI_CNT_MBR"
            strSQL &= ",TBL_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ",TBL_KOUENKAI.BU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.COST_CENTER"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_BU"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_ROMA"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_PC"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_EMAIL_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_KEITAI"
            strSQL &= ",TBL_KOUENKAI.TEHAI_TANTO_TEL"
            strSQL &= ",TBL_KOUENKAI.YOSAN_TF"
            strSQL &= ",TBL_KOUENKAI.YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.TTANTO_ID"
            strSQL &= ",TBL_KOUENKAI.TTEHAI_TANTO"
            strSQL &= ",TBL_KOUENKAI.IROUKAI_YOSAN_T"
            strSQL &= ",TBL_KOUENKAI.IKENKOUKAN_YOSAN_T"
            strSQL &= ",MS_USER.USER_NAME"
            strSQL &= " FROM TBL_KAIJO"
            strSQL &= ","
            strSQL &= "(SELECT"
            strSQL &= " TBL_KOUENKAI_1.*"
            strSQL &= " FROM (SELECT"
            strSQL &= " *"
            strSQL &= " FROM TBL_KOUENKAI"
            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= ") AS TBL_KOUENKAI_1"
            strSQL &= ",(SELECT"
            strSQL &= " MAX(TIME_STAMP) AS TIME_STAMP"
            strSQL &= ",KOUENKAI_NO"
            strSQL &= " FROM TBL_KOUENKAI"
            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= " WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= " AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO) AS TBL_KOUENKAI"
            strSQL &= ",(SELECT"
            strSQL &= " N'' AS LOGIN_ID"
            strSQL &= ",N'' AS USER_NAME"
            strSQL &= " UNION ALL"
            strSQL &= " SELECT"
            strSQL &= " LOGIN_ID"
            strSQL &= ",USER_NAME"
            strSQL &= " FROM MS_USER) AS MS_USER"
            strSQL &= " WHERE TBL_KAIJO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND ISNULL(TBL_KOUENKAI.TTEHAI_TANTO,N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KAIJO.KOUENKAI_NO=N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_KAIJO.TEHAI_ID=N'" & CmnDb.SqlString(Joken.TEHAI_ID) & "'"
            strSQL &= " ORDER BY"
            strSQL &= " TBL_KAIJO.TIME_STAMP_BYL DESC"

            If Trim(Joken.KOUENKAI_NO) = "" Then
                strSQL = "TBL_KAIJO.Rireki: JOKEN.KOUTENKAI_NO ERROR!!" & vbNewLine & strSQL
            End If

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_KAIJO"
            strSQL &= "(" & TableDef.TBL_KAIJO.Column.SALEFORCE_ID
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TEHAI_ID
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
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_FROM
            strSQL &= "," & TableDef.TBL_KAIJO.Column.KOUSHI_ROOM_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHAIN_ROOM_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SHAIN_ROOM_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_KAIJO_TEHAI
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_ROOM_FROM
            strSQL &= "," & TableDef.TBL_KAIJO.Column.MANAGER_ROOM_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.REQ_ROOM_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.REQ_STAY_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.REQ_KOTSU_CNT
            strSQL &= "," & TableDef.TBL_KAIJO.Column.REQ_TAXI_CNT
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
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAIJOUHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KIZAIHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_INSHOKUHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_991330401_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_HOTELHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOTSUHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TAXI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TEHAI_TESURYO_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TAXI_HAKKEN_TESURYO_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TAXI_SEISAN_TESURYO_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_JINKENHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_OTHER_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KANRIHI_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_41120200_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TOTAL_TF
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAIJOUHI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KIZAIHI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_INSHOKUHI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_991330401_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_JINKENHI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_OTHER_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KANRIHI_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_41120200_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TOTAL_T
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEND_FLAG
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_KAIJO.SALEFORCE_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.REQ_STATUS_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_BYL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_TOP) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.SHONIN_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_DATE_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_ADDRESS2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KAISAI_KIBOU_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_TIME2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUEN_KAIJO_LAYOUT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.IROUKAI_KAIJO_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_FROM) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KOUSHI_ROOM_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.SHAIN_ROOM_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.SHAIN_ROOM_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_KAIJO_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_ROOM_FROM) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.MANAGER_ROOM_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.REQ_ROOM_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.REQ_STAY_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.REQ_KOTSU_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.REQ_TAXI_CNT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.KAIJO_URL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.OTHER_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SENTEI_RIYU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TOTAL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_URL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ZIP) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_URL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_FLOOR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_IKENKOUKAN_KAIJO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_IROUKAI_KAIJO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUSHI_ROOM_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHAIN_ROOM_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MANAGER_KAIJO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAISAI_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAIJOUHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KIZAIHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_INSHOKUHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_991330401_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_HOTELHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOTSUHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TAXI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TEHAI_TESURYO_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TAXI_HAKKEN_TESURYO_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TAXI_SEISAN_TESURYO_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_JINKENHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_OTHER_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KANRIHI_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_41120200_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TOTAL_TF) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAIJOUHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KIZAIHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_INSHOKUHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_991330401_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_JINKENHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_OTHER_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KANRIHI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_41120200_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TOTAL_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.SEND_FLAG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_KAIJO.UPDATE_USER) & "'"
            strSQL &= ")"

            If Trim(TBL_KAIJO.SALEFORCE_ID) = "" OrElse Trim(TBL_KAIJO.TEHAI_ID) = "" OrElse Trim(TBL_KAIJO.KOUENKAI_NO) = "" OrElse Trim(TBL_KAIJO.TIME_STAMP_BYL) = "" Then
                strSQL = "TBL_KAIJO.Insert: ERROR!!" & vbNewLine & strSQL
            End If

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KAIJO SET"
            strSQL &= " " & TableDef.TBL_KAIJO.Column.ANS_STATUS_TEHAI & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.TIME_STAMP_TOP & "=N'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_TOP) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SENTEI_RIYU & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SENTEI_RIYU) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ZIP & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ZIP) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_ADDRESS & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_TEL & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_TEL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHISETSU_URL & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHISETSU_URL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUEN_KAIJO_FLOOR & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUEN_KAIJO_FLOOR) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_IKENKOUKAN_KAIJO_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_IKENKOUKAN_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_IROUKAI_KAIJO_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_IROUKAI_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOUSHI_ROOM_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOUSHI_ROOM_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_SHAIN_ROOM_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_SHAIN_ROOM_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MANAGER_KAIJO_NAME & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MANAGER_KAIJO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAISAI_NOTE & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAISAI_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_TOTAL & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_TOTAL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_MITSUMORI_URL & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_MITSUMORI_URL) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAIJOUHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAIJOUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KIZAIHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KIZAIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_INSHOKUHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_INSHOKUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_991330401_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_991330401_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_HOTELHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_HOTELHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KOTSUHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KOTSUHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TAXI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TAXI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TEHAI_TESURYO_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TEHAI_TESURYO_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TAXI_HAKKEN_TESURYO_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TAXI_HAKKEN_TESURYO_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TAXI_SEISAN_TESURYO_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TAXI_SEISAN_TESURYO_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_JINKENHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_JINKENHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_OTHER_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_OTHER_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KANRIHI_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KANRIHI_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_41120200_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_41120200_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TOTAL_TF & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TOTAL_TF) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KAIJOUHI_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KAIJOUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KIZAIHI_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KIZAIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_INSHOKUHI_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_INSHOKUHI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_991330401_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_991330401_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_JINKENHI_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_JINKENHI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_OTHER_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_OTHER_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_KANRIHI_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_KANRIHI_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_41120200_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_41120200_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.ANS_TOTAL_T & "=N'" & CmnDb.SqlString(TBL_KAIJO.ANS_TOTAL_T) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_KAIJO.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KAIJO.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KAIJO.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(TBL_KAIJO.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.TEHAI_ID & "=N'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.TIME_STAMP_BYL & "=N'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_BYL) & "'"

            If Trim(TBL_KAIJO.SALEFORCE_ID) = "" OrElse Trim(TBL_KAIJO.TEHAI_ID) = "" OrElse Trim(TBL_KAIJO.KOUENKAI_NO) = "" OrElse Trim(TBL_KAIJO.TIME_STAMP_BYL) = "" Then
                strSQL = "TBL_KAIJO.Update: ERROR!!" & vbNewLine & strSQL
            End If

            Return strSQL
        End Function

        Public Shared Function Update_SEND_FLAG(ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_KAIJO SET"
            strSQL &= " " & TableDef.TBL_KAIJO.Column.SEND_FLAG & "=N'" & CmnDb.SqlString(TBL_KAIJO.SEND_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_KAIJO.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_KAIJO.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_KAIJO.Column.SALEFORCE_ID & "=N'" & CmnDb.SqlString(TBL_KAIJO.SALEFORCE_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.TEHAI_ID & "=N'" & CmnDb.SqlString(TBL_KAIJO.TEHAI_ID) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_KAIJO.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_KAIJO.Column.TIME_STAMP_BYL & "=N'" & CmnDb.SqlString(TBL_KAIJO.TIME_STAMP_BYL) & "'"

            If Trim(TBL_KAIJO.SALEFORCE_ID) = "" OrElse Trim(TBL_KAIJO.TEHAI_ID) = "" OrElse Trim(TBL_KAIJO.KOUENKAI_NO) = "" OrElse Trim(TBL_KAIJO.TIME_STAMP_BYL) = "" Then
                strSQL = "TBL_KAIJO.Update_SEND_FLAG: ERROR!!" & vbNewLine & strSQL
            End If

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_KAIJO"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

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

            strSQL &= " WHERE TBL_BENTO.ID=N'" & CmnDb.SqlString(ID) & "'"
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
            strSQL &= "(N'" & CmnDb.SqlString(TBL_BENTO.ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KINKYU_FLG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.RAIJO_FLG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.AREA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.EIGYOSHO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.ZIP) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.TANTO_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.TANTO_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.TANTO_KANA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.EMAIL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.SEND_SAKI_FS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_MPID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_KANA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_GOFFICIAL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.DR_YAKUWARI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KAIJO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.BU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.COST_CENTER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.ZETIA_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.STATUS_SHONIN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.SHONIN_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.SHONIN_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.SHONIN_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.STATUS_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_KIBOU_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_SHISETSU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.SURYO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.TANKA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KIBOU_MAKER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.KIBOU_MENU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.NOTE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.ANS_STATUS_TEHAI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_ADDRESS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_SHISETSU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_SURYO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_TANKA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_KINGAKU_TOTAL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER_CONTACT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_KIBOU_MAKER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BENTO.FIX_NOTE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_BENTO As TableDef.TBL_BENTO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_BENTO SET"
            strSQL &= " " & TableDef.TBL_BENTO.Column.KINKYU_FLG & "=N'" & CmnDb.SqlString(TBL_BENTO.KINKYU_FLG) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.RAIJO_FLG & "=N'" & CmnDb.SqlString(TBL_BENTO.RAIJO_FLG) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.AREA & "=N'" & CmnDb.SqlString(TBL_BENTO.AREA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ADDRESS & "=N'" & CmnDb.SqlString(TBL_BENTO.ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.EIGYOSHO & "=N'" & CmnDb.SqlString(TBL_BENTO.EIGYOSHO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ZIP & "=N'" & CmnDb.SqlString(TBL_BENTO.ZIP) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_NO & "=N'" & CmnDb.SqlString(TBL_BENTO.TANTO_NO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_NAME & "=N'" & CmnDb.SqlString(TBL_BENTO.TANTO_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANTO_KANA & "=N'" & CmnDb.SqlString(TBL_BENTO.TANTO_KANA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.INTERNAL_ORDER_T & "=N'" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER_T) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ACCOUNT_CODE_T & "=N'" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE_T) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TEL & "=N'" & CmnDb.SqlString(TBL_BENTO.TEL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.EMAIL & "=N'" & CmnDb.SqlString(TBL_BENTO.EMAIL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SEND_SAKI_FS & "=N'" & CmnDb.SqlString(TBL_BENTO.SEND_SAKI_FS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_MPID & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_MPID) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_NAME & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_KANA & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_KANA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_SHISETSU_NAME & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_CD & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_CD) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_SHISETSU_CD & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_SHISETSU_CD) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_ADDRESS & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_GOFFICIAL & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_GOFFICIAL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.DR_YAKUWARI & "=N'" & CmnDb.SqlString(TBL_BENTO.DR_YAKUWARI) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_NAME & "=N'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_DATE & "=N'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_DATE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_BENTO.KOUENKAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KAIJO & "=N'" & CmnDb.SqlString(TBL_BENTO.KAIJO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.BU & "=N'" & CmnDb.SqlString(TBL_BENTO.BU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ACCOUNT_CODE & "=N'" & CmnDb.SqlString(TBL_BENTO.ACCOUNT_CODE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.COST_CENTER & "=N'" & CmnDb.SqlString(TBL_BENTO.COST_CENTER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.INTERNAL_ORDER & "=N'" & CmnDb.SqlString(TBL_BENTO.INTERNAL_ORDER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ZETIA_CD & "=N'" & CmnDb.SqlString(TBL_BENTO.ZETIA_CD) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.STATUS_SHONIN & "=N'" & CmnDb.SqlString(TBL_BENTO.STATUS_SHONIN) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_NAME & "=N'" & CmnDb.SqlString(TBL_BENTO.SHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_TIME & "=N'" & CmnDb.SqlString(TBL_BENTO.SHONIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SHONIN_NOTE & "=N'" & CmnDb.SqlString(TBL_BENTO.SHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_NAME & "=N'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NAME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_TIME & "=N'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.CMSHONIN_NOTE & "=N'" & CmnDb.SqlString(TBL_BENTO.CMSHONIN_NOTE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.STATUS_TEHAI & "=N'" & CmnDb.SqlString(TBL_BENTO.STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_DATE & "=N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_DATE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_KIBOU_TIME & "=N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_KIBOU_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_ADDRESS & "=N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.HAITATSU_SHISETSU & "=N'" & CmnDb.SqlString(TBL_BENTO.HAITATSU_SHISETSU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.SURYO & "=N'" & CmnDb.SqlString(TBL_BENTO.SURYO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.TANKA & "=N'" & CmnDb.SqlString(TBL_BENTO.TANKA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KIBOU_MAKER & "=N'" & CmnDb.SqlString(TBL_BENTO.KIBOU_MAKER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.KIBOU_MENU & "=N'" & CmnDb.SqlString(TBL_BENTO.KIBOU_MENU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.NOTE & "=N'" & CmnDb.SqlString(TBL_BENTO.NOTE) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.ANS_STATUS_TEHAI & "=N'" & CmnDb.SqlString(TBL_BENTO.ANS_STATUS_TEHAI) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_TIME & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_TIME) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_ADDRESS & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_ADDRESS) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_HAITATSU_SHISETSU & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_HAITATSU_SHISETSU) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_SURYO & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_SURYO) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_TANKA & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_TANKA) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_KINGAKU_TOTAL & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_KINGAKU_TOTAL) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_MAKER & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_MAKER_CONTACT & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_MAKER_CONTACT) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_KIBOU_MAKER & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_KIBOU_MAKER) & "'"
            strSQL &= "," & TableDef.TBL_BENTO.Column.FIX_NOTE & "=N'" & CmnDb.SqlString(TBL_BENTO.FIX_NOTE) & "'"
            strSQL &= " WHERE " & TableDef.TBL_BENTO.Column.ID & "=N'" & CmnDb.SqlString(TBL_BENTO.ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_COST

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_COST.*" _
        & " FROM TBL_COST"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_COST.SEIKYU_NO" _
        & ",TBL_COST.SEIKYU_YM" _
        & ",TBL_COST.COSTCENTER_CD"

        Public Shared Function bySEIKYU_NO_SEIKYU_YM(ByVal SEIKYU_NO As String, ByVal SEIKYU_YM As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_COST.SEIKYU_NO=N'" & CmnDb.SqlString(SEIKYU_NO) & "'"
            strSQL &= " AND TBL_COST.SEIKYU_YM=N'" & CmnDb.SqlString(SEIKYU_YM) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= " SELECT"
            strSQL &= " SEIKYU_NO"
            strSQL &= ",SEIKYU_YM "
            strSQL &= " FROM"
            strSQL &= " TBL_COST "
            strSQL &= " WHERE 1=1"

            If Trim(Joken.SEIKYU_NO) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_COST.Column.SEIKYU_NO
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEIKYU_NO) & "'"
            End If

            If Trim(Joken.SEIKYU_YM) <> "" Then
                strSQL &= " AND "
                strSQL &= TableDef.TBL_COST.Column.SEIKYU_YM
                strSQL &= " =N'" & CmnDb.SqlString(Joken.SEIKYU_YM) & "'"
            End If

            strSQL &= " GROUP BY SEIKYU_NO,SEIKYU_YM"
            strSQL &= " ORDER BY SEIKYU_NO,SEIKYU_YM"

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_COST As TableDef.TBL_COST.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_COST"
            strSQL &= "(" & TableDef.TBL_COST.Column.SEIKYU_NO
            strSQL &= "," & TableDef.TBL_COST.Column.SEIKYU_YM
            strSQL &= "," & TableDef.TBL_COST.Column.COSTCENTER_CD
            strSQL &= "," & TableDef.TBL_COST.Column.KOTSUHI
            strSQL &= "," & TableDef.TBL_COST.Column.HOTELHI
            strSQL &= "," & TableDef.TBL_COST.Column.TAXI_T
            strSQL &= "," & TableDef.TBL_COST.Column.TAXI_SEISAN_T
            strSQL &= "," & TableDef.TBL_COST.Column.SAP_FLAG
            strSQL &= "," & TableDef.TBL_COST.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_COST.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_COST.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_COST.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_COST.SEIKYU_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.SEIKYU_YM) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.COSTCENTER_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.KOTSUHI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.HOTELHI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.TAXI_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.TAXI_SEISAN_T) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.SAP_FLAG) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.INPUT_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.INPUT_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.UPDATE_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_COST.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_COST As TableDef.TBL_COST.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_COST SET"
            strSQL &= " " & TableDef.TBL_COST.Column.KOTSUHI & "=N'" & CmnDb.SqlString(TBL_COST.KOTSUHI) & "'"
            strSQL &= "," & TableDef.TBL_COST.Column.HOTELHI & "=N'" & CmnDb.SqlString(TBL_COST.HOTELHI) & "'"
            strSQL &= "," & TableDef.TBL_COST.Column.TAXI_T & "=N'" & CmnDb.SqlString(TBL_COST.TAXI_T) & "'"
            strSQL &= "," & TableDef.TBL_COST.Column.TAXI_SEISAN_T & "=N'" & CmnDb.SqlString(TBL_COST.TAXI_SEISAN_T) & "'"
            strSQL &= "," & TableDef.TBL_COST.Column.SAP_FLAG & "=N'" & CmnDb.SqlString(TBL_COST.SAP_FLAG) & "'"
            strSQL &= "," & TableDef.TBL_COST.Column.UPDATE_DATE & "=N'" & CmnDb.SqlString(TBL_COST.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_COST.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_COST.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_COST.Column.SEIKYU_NO & "=N'" & CmnDb.SqlString(TBL_COST.SEIKYU_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_COST.Column.SEIKYU_YM & "=N'" & CmnDb.SqlString(TBL_COST.SEIKYU_YM) & "'"
            strSQL &= " AND " & TableDef.TBL_COST.Column.COSTCENTER_CD & "=N'" & CmnDb.SqlString(TBL_COST.COSTCENTER_CD) & "'"

            Return strSQL
        End Function

        Public Shared Function Delete(ByVal TBL_COST As TableDef.TBL_COST.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "DELETE TBL_COST"
            strSQL &= " WHERE " & TableDef.TBL_COST.Column.SEIKYU_NO & "=N'" & CmnDb.SqlString(TBL_COST.SEIKYU_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_COST.Column.SEIKYU_YM & "=N'" & CmnDb.SqlString(TBL_COST.SEIKYU_YM) & "'"

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

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SHISETSU.SYSTEM_ID=N'" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySHISETSU_NAME(ByVal SHISETSU_NAME As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SHISETSU.SHISETSU_NAME=N'" & CmnDb.SqlString(SHISETSU_NAME) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE ISNULL(MS_SHISETSU.STOP_FLG,N'')<>N'" & AppConst.STOP_FLG.Code.Stop & "'"

            If Trim(Joken.ADDRESS1) <> "" Then
                strSQL &= " AND MS_SHISETSU.ADDRESS1=N'" & CmnDb.SqlString(Joken.ADDRESS1) & "'"
            End If

            If Trim(Joken.ADDRESS2) <> "" Then
                strSQL &= " AND MS_SHISETSU.ADDRESS2 LIKE N'%" & CmnDb.SqlString(Joken.ADDRESS2) & "%'"
            End If

            If Trim(Joken.SHISETSU_NAME) <> "" Then
                strSQL &= " AND ("
                strSQL &= "      MS_SHISETSU.SHISETSU_NAME LIKE N'%" & CmnDb.SqlString(Joken.SHISETSU_NAME) & "%'"
                strSQL &= "      OR "
                strSQL &= "      MS_SHISETSU.SHISETSU_KANA LIKE N'%" & CmnDb.SqlString(Joken.SHISETSU_NAME) & "%'"
                strSQL &= ")"
            End If

            If Trim(Joken.SHISETSU_KANA) <> "" Then
                strSQL &= " AND ("
                strSQL &= "      MS_SHISETSU.SHISETSU_NAME LIKE N'%" & CmnDb.SqlString(Joken.SHISETSU_KANA) & "%'"
                strSQL &= "      OR "
                strSQL &= "      MS_SHISETSU.SHISETSU_KANA LIKE N'%" & CmnDb.SqlString(Joken.SHISETSU_KANA) & "%'"
                strSQL &= ")"
            End If

            Return strSQL
        End Function

        Public Shared Function MaxSYSTEM_ID() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT MAX(CONVERT(INT,SYSTEM_ID)) AS SYSTEM_ID FROM MS_SHISETSU"
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
            strSQL &= "(N'" & CmnDb.SqlString(MS_SHISETSU.SYSTEM_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.ZIP) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS1) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS2) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_KANA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.TEL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.CHECKIN_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.CHECKOUT_TIME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.URL) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SHISETSU.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_SHISETSU SET"
            strSQL &= " " & TableDef.MS_SHISETSU.Column.ZIP & "=N'" & CmnDb.SqlString(MS_SHISETSU.ZIP) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS1 & "=N'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS1) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.ADDRESS2 & "=N'" & CmnDb.SqlString(MS_SHISETSU.ADDRESS2) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME & "=N'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_KANA & "=N'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_KANA) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.TEL & "=N'" & CmnDb.SqlString(MS_SHISETSU.TEL) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKIN_TIME & "=N'" & CmnDb.SqlString(MS_SHISETSU.CHECKIN_TIME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.CHECKOUT_TIME & "=N'" & CmnDb.SqlString(MS_SHISETSU.CHECKOUT_TIME) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.URL & "=N'" & CmnDb.SqlString(MS_SHISETSU.URL) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.STOP_FLG & "=N'" & CmnDb.SqlString(MS_SHISETSU.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_SHISETSU.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_SHISETSU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_SHISETSU.Column.SYSTEM_ID & "=N'" & CmnDb.SqlString(MS_SHISETSU.SYSTEM_ID) & "'"

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

            strSQL &= " WHERE MS_USER.SYSTEM_ID=N'" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byLOGIN_ID(ByVal LOGIN_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_USER.LOGIN_ID=N'" & CmnDb.SqlString(LOGIN_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Login(ByVal LOGIN_ID As String, ByVal PASSWORD As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_USER.LOGIN_ID=N'" & CmnDb.SqlString(LOGIN_ID) & "'"
            strSQL &= " AND MS_USER.PASSWORD=N'" & CmnDb.SqlString(PASSWORD) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE 1=1"

            If Trim(Joken.LOGIN_ID) <> "" Then
                strSQL &= " AND MS_USER.LOGIN_ID=N'" & CmnDb.SqlString(Joken.LOGIN_ID) & "'"
            End If
            If Trim(Joken.USER_NAME) <> "" Then
                strSQL &= " AND MS_USER.USER_NAME LIKE N'%" & CmnDb.SqlString(Joken.USER_NAME) & "%'"
            End If
            If Trim(Joken.KENGEN) <> "" Then
                strSQL &= " AND MS_USER.KENGEN=N'" & CmnDb.SqlString(Joken.KENGEN) & "'"
            End If
            If Trim(Joken.KENGEN_SEISAN) <> "" Then
                strSQL &= " AND MS_USER.KENGEN_SEISAN=N'" & CmnDb.SqlString(Joken.KENGEN_SEISAN) & "'"
            End If
            If Trim(Joken.STOP_FLG) <> "" Then
                strSQL &= " AND MS_USER.STOP_FLG=N'" & CmnDb.SqlString(Joken.STOP_FLG) & "'"
            End If

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function MaxSYSTEM_ID() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT MAX(CONVERT(INT,SYSTEM_ID)) AS SYSTEM_ID FROM MS_USER"
            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_USER As TableDef.MS_USER.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_USER"
            strSQL &= "(" & TableDef.MS_USER.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_USER.Column.LOGIN_ID
            strSQL &= "," & TableDef.MS_USER.Column.PASSWORD
            strSQL &= "," & TableDef.MS_USER.Column.KENGEN
            strSQL &= "," & TableDef.MS_USER.Column.KENGEN_SEISAN
            strSQL &= "," & TableDef.MS_USER.Column.USER_NAME
            strSQL &= "," & TableDef.MS_USER.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_USER.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_USER.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_USER.SYSTEM_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.LOGIN_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.PASSWORD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.KENGEN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.KENGEN_SEISAN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.USER_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_USER.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_USER As TableDef.MS_USER.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_USER SET"
            strSQL &= " " & TableDef.MS_USER.Column.LOGIN_ID & "=N'" & CmnDb.SqlString(MS_USER.LOGIN_ID) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.PASSWORD & "=N'" & CmnDb.SqlString(MS_USER.PASSWORD) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.KENGEN & "=N'" & CmnDb.SqlString(MS_USER.KENGEN) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.KENGEN_SEISAN & "=N'" & CmnDb.SqlString(MS_USER.KENGEN_SEISAN) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.USER_NAME & "=N'" & CmnDb.SqlString(MS_USER.USER_NAME) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.STOP_FLG & "=N'" & CmnDb.SqlString(MS_USER.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_USER.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_USER.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_USER.Column.SYSTEM_ID & "=N'" & CmnDb.SqlString(MS_USER.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_COSTCENTER
        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_COSTCENTER.*" _
        & " FROM MS_COSTCENTER"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_COSTCENTER.COSTCENTER_CD"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySTOP_FLG(ByVal STOP_FLG As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_COSTCENTER.STOP_FLG=N'" & CmnDb.SqlString(STOP_FLG) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCOSTCENTER_CD(ByVal COSTCENTER_CD As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_COSTCENTER.COSTCENTER_CD=N'" & CmnDb.SqlString(COSTCENTER_CD) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_COSTCENTER"
            strSQL &= "(" & TableDef.MS_COSTCENTER.Column.COSTCENTER_CD
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.COSTCENTER_NAME
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_COSTCENTER.COSTCENTER_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_COSTCENTER.COSTCENTER_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_COSTCENTER.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_COSTCENTER.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_COSTCENTER.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_COSTCENTER SET"
            strSQL &= " " & TableDef.MS_COSTCENTER.Column.COSTCENTER_NAME & "=N'" & CmnDb.SqlString(MS_COSTCENTER.COSTCENTER_NAME) & "'"
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.STOP_FLG & "=N'" & CmnDb.SqlString(MS_COSTCENTER.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_COSTCENTER.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_COSTCENTER.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_COSTCENTER.Column.COSTCENTER_CD & "=N'" & CmnDb.SqlString(MS_COSTCENTER.COSTCENTER_CD) & "'"

            Return strSQL
        End Function
    End Class

    Public Class MS_BU

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_BU.*" _
        & " FROM MS_BU"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_BU.SYSTEM_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_BU.SYSTEM_ID=N'" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_BU As TableDef.MS_BU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_BU"
            strSQL &= "(" & TableDef.MS_BU.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_BU.Column.BU
            strSQL &= "," & TableDef.MS_BU.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_BU.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_BU.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_BU.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_BU.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_BU.SYSTEM_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_BU.BU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_BU.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_BU.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_BU.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_BU As TableDef.MS_BU.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_BU SET"
            strSQL &= " " & TableDef.MS_BU.Column.BU & "=N'" & CmnDb.SqlString(MS_BU.BU) & "'"
            strSQL &= "," & TableDef.MS_BU.Column.STOP_FLG & "=N'" & CmnDb.SqlString(MS_BU.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_BU.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_BU.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_BU.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_BU.Column.SYSTEM_ID & "=N'" & CmnDb.SqlString(MS_BU.SYSTEM_ID) & "'"

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

            strSQL &= " WHERE MS_AREA.SYSTEM_ID=N'" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_AREA As TableDef.MS_AREA.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_AREA"
            strSQL &= "(" & TableDef.MS_AREA.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_AREA.Column.AREA
            strSQL &= "," & TableDef.MS_AREA.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_AREA.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_AREA.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_AREA.SYSTEM_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_AREA.AREA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_AREA.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_AREA.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_AREA.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_AREA As TableDef.MS_AREA.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_AREA SET"
            strSQL &= " " & TableDef.MS_AREA.Column.AREA & "=N'" & CmnDb.SqlString(MS_AREA.AREA) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.STOP_FLG & "=N'" & CmnDb.SqlString(MS_AREA.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_AREA.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_AREA.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_AREA.Column.SYSTEM_ID & "=N'" & CmnDb.SqlString(MS_AREA.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_SEIHIN

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_SEIHIN.*" _
        & " FROM MS_SEIHIN"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_SEIHIN.SYSTEM_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySYSTEM_ID(ByVal SYSTEM_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SEIHIN.SYSTEM_ID=N'" & CmnDb.SqlString(SYSTEM_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_SEIHIN As TableDef.MS_SEIHIN.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_SEIHIN"
            strSQL &= "(" & TableDef.MS_SEIHIN.Column.SYSTEM_ID
            strSQL &= "," & TableDef.MS_SEIHIN.Column.SEIHIN
            strSQL &= "," & TableDef.MS_SEIHIN.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_SEIHIN.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_SEIHIN.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_SEIHIN.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_SEIHIN.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_SEIHIN.SYSTEM_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SEIHIN.SEIHIN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SEIHIN.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SEIHIN.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SEIHIN.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_SEIHIN As TableDef.MS_SEIHIN.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_SEIHIN SET"
            strSQL &= " " & TableDef.MS_SEIHIN.Column.SEIHIN & "=N'" & CmnDb.SqlString(MS_SEIHIN.SEIHIN) & "'"
            strSQL &= "," & TableDef.MS_SEIHIN.Column.STOP_FLG & "=N'" & CmnDb.SqlString(MS_SEIHIN.STOP_FLG) & "'"
            strSQL &= "," & TableDef.MS_SEIHIN.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_SEIHIN.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_SEIHIN.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_SEIHIN.Column.SYSTEM_ID & "=N'" & CmnDb.SqlString(MS_SEIHIN.SYSTEM_ID) & "'"

            Return strSQL
        End Function

    End Class

    Public Class MS_ZEI

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_ZEI.*" _
        & " FROM MS_ZEI"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_ZEI.ZEI_CD"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_ZEI As TableDef.MS_ZEI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_ZEI"
            strSQL &= "(" & TableDef.MS_ZEI.Column.ZEI_CD
            strSQL &= "," & TableDef.MS_ZEI.Column.ZEI_NAME
            strSQL &= "," & TableDef.MS_ZEI.Column.ZEI_RATE
            strSQL &= "," & TableDef.MS_ZEI.Column.START_DATE
            strSQL &= "," & TableDef.MS_ZEI.Column.END_DATE
            strSQL &= "," & TableDef.MS_ZEI.Column.SAP_ZEI_CD
            strSQL &= "," & TableDef.MS_ZEI.Column.STOP_FLG
            strSQL &= "," & TableDef.MS_ZEI.Column.INPUT_DATE
            strSQL &= "," & TableDef.MS_ZEI.Column.INPUT_USER
            strSQL &= "," & TableDef.MS_ZEI.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_ZEI.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_ZEI.ZEI_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.ZEI_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.ZEI_RATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.START_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.END_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.SAP_ZEI_CD) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.STOP_FLG) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_ZEI.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

    End Class

    Public Class MS_SAPKANRI

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_SAPKANRI.*" _
        & " FROM MS_SAPKANRI"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_SAPKANRI.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SAPKANRI.DATA_ID=N'" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal MS_SAPKANRI As TableDef.MS_SAPKANRI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO MS_SAPKANRI"
            strSQL &= "(" & TableDef.MS_SAPKANRI.Column.DATA_ID
            strSQL &= "," & TableDef.MS_SAPKANRI.Column.CODE
            strSQL &= "," & TableDef.MS_SAPKANRI.Column.BIKO
            strSQL &= "," & TableDef.MS_SAPKANRI.Column.UPDATE_DATE
            strSQL &= "," & TableDef.MS_SAPKANRI.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(MS_SAPKANRI.DATA_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SAPKANRI.CODE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SAPKANRI.BIKO) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_SAPKANRI.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_SAPKANRI As TableDef.MS_SAPKANRI.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_SAPKANRI SET"
            strSQL &= " " & TableDef.MS_SAPKANRI.Column.CODE & "=N'" & CmnDb.SqlString(MS_SAPKANRI.CODE) & "'"
            strSQL &= "," & TableDef.MS_SAPKANRI.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.MS_SAPKANRI.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(MS_SAPKANRI.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.MS_SAPKANRI.Column.DATA_ID & "=N'" & CmnDb.SqlString(MS_SAPKANRI.DATA_ID) & "'"

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

            strSQL &= " WHERE MS_CODE.CODE=N'" & CmnDb.SqlString(CODE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCODE_DATA_ID(ByVal CODE As String, ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_CODE.CODE=N'" & CmnDb.SqlString(CODE) & "'"
            strSQL &= " AND MS_CODE.DATA_ID=N'" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCODE_DISP_VALUE(ByVal CODE As String, ByVal DISP_VALUE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_CODE.CODE=N'" & CmnDb.SqlString(CODE) & "'"
            strSQL &= " AND MS_CODE.DISP_VALUE=N'" & CmnDb.SqlString(DISP_VALUE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCODE_DISP_TEXT(ByVal CODE As String, ByVal DISP_TEXT As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_CODE.CODE=N'" & CmnDb.SqlString(CODE) & "'"
            strSQL &= " AND MS_CODE.DISP_TEXT=N'" & CmnDb.SqlString(DISP_TEXT) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function MaxDATA_ID(ByVal CODE As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT MAX(CONVERT(INT,DATA_ID)) AS DATA_ID FROM MS_CODE"
            strSQL &= " WHERE CODE=N'" & CmnDb.SqlString(CODE) & "'"

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
            strSQL &= "(N'" & CmnDb.SqlString(MS_CODE.CODE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_CODE.DATA_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_CODE.DISP_TEXT) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(MS_CODE.DISP_VALUE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal MS_CODE As TableDef.MS_CODE.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE MS_CODE SET"
            strSQL &= " " & TableDef.MS_CODE.Column.DISP_TEXT & "=N'" & CmnDb.SqlString(MS_CODE.DISP_TEXT) & "'"
            strSQL &= "," & TableDef.MS_CODE.Column.DISP_VALUE & "=N'" & CmnDb.SqlString(MS_CODE.DISP_VALUE) & "'"
            strSQL &= " WHERE " & TableDef.MS_CODE.Column.CODE & "=N'" & CmnDb.SqlString(MS_CODE.CODE) & "'"
            strSQL &= " AND " & TableDef.MS_CODE.Column.DATA_ID & "=N'" & CmnDb.SqlString(MS_CODE.DATA_ID) & "'"

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
        & " TBL_LOG.INPUT_DATE DESC" _
        & ",TBL_LOG.LOG_NO DESC"

        Public Shared Function byINPUT_DATE(ByVal INPUT_DATE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_LOG.INPUT_DATE=N'" & CmnDb.SqlString(INPUT_DATE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            If Trim(Joken.SYORI_KBN) = AppConst.TBL_LOG.SYORI_KBN.Code.GAMEN Then
                strSQL &= "SELECT"
                strSQL &= " TBL_LOG.*"
                strSQL &= ",MS_USER.USER_NAME"
                strSQL &= " FROM MS_USER"
                strSQL &= " RIGHT JOIN TBL_LOG"
                strSQL &= " ON MS_USER.LOGIN_ID=TBL_LOG.INPUT_USER"
            Else
                strSQL &= "SELECT"
                strSQL &= " TBL_LOG.*"
                strSQL &= " FROM TBL_LOG"
            End If

            strSQL &= " WHERE 1=1"

            If Trim(Joken.SYORI_KBN) <> "" Then
                strSQL &= " AND TBL_LOG.SYORI_KBN=N'" & CmnDb.SqlString(Joken.SYORI_KBN) & "'"
            End If

            If Trim(Joken.INPUT_DATE) <> "" Then
                strSQL &= " AND SUBSTRING(TBL_LOG.INPUT_DATE,1,8)=N'" & CmnDb.SqlString(Joken.INPUT_DATE) & "'"
            End If

            If Trim(Joken.INPUT_USER) <> "" Then
                strSQL &= " AND TBL_LOG.INPUT_USER=N'" & CmnDb.SqlString(Joken.INPUT_USER) & "'"
            End If

            If Trim(Joken.SYORI_NAME) <> "" Then
                strSQL &= " AND TBL_LOG.SYORI_NAME=N'" & CmnDb.SqlString(Joken.SYORI_NAME) & "'"
            End If

            If Trim(Joken.STATUS) <> "" Then
                strSQL &= " AND TBL_LOG.STATUS=N'" & CmnDb.SqlString(Joken.STATUS) & "'"
            End If

            If Trim(Joken.SYORI_KBN) = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH AndAlso Trim(Joken.EXPORTIMPORT) <> "" Then
                If Joken.EXPORTIMPORT = AppConst.TBL_LOG.EXPORTIMPORT.Code.EXPORT Then
                    strSQL &= " AND TBL_LOG.INPUT_USER LIKE N'" & "Export%'"
                ElseIf Joken.EXPORTIMPORT = AppConst.TBL_LOG.EXPORTIMPORT.Code.EXPORT Then
                    strSQL &= " AND TBL_LOG.INPUT_USER LIKE N'" & "Import%'"
                End If
            End If

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
            strSQL &= "(N'" & CmnDb.SqlString(TBL_LOG.INPUT_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_LOG.INPUT_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_LOG.SYORI_KBN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_LOG.SYORI_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_LOG.TABLE_NAME) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_LOG.STATUS) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_LOG.NOTE) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_LOG SET"
            strSQL &= " " & TableDef.TBL_LOG.Column.INPUT_USER & "=N'" & CmnDb.SqlString(TBL_LOG.INPUT_USER) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.SYORI_KBN & "=N'" & CmnDb.SqlString(TBL_LOG.SYORI_KBN) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.SYORI_NAME & "=N'" & CmnDb.SqlString(TBL_LOG.SYORI_NAME) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.TABLE_NAME & "=N'" & CmnDb.SqlString(TBL_LOG.TABLE_NAME) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.STATUS & "=N'" & CmnDb.SqlString(TBL_LOG.STATUS) & "'"
            strSQL &= "," & TableDef.TBL_LOG.Column.NOTE & "=N'" & CmnDb.SqlString(TBL_LOG.NOTE) & "'"
            strSQL &= " WHERE" & TableDef.TBL_LOG.Column.INPUT_DATE & "=N'" & CmnDb.SqlString(TBL_LOG.INPUT_DATE) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_TAXITICKET_HAKKO

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_TAXITICKET_HAKKO.*" _
        & " FROM TBL_TAXITICKET_HAKKO"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_TAXITICKET_HAKKO.TKT_KAISHA" _
        & ",TBL_TAXITICKET_HAKKO.TKT_NO"

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct, Optional ByVal Miketsu As Boolean = False) As String
            Dim strSQL As String = String.Empty

            strSQL &= "SELECT"
            strSQL &= " TBL_TAXITICKET_HAKKO.*"
            strSQL &= ",WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
            strSQL &= ",WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.FROM_DATE
            strSQL &= ",WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TO_DATE
            strSQL &= ",WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TAXI_PRT_NAME
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_MPID
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_CD
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_NAME
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_KANA
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_CD
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_NAME
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_SHISETSU_ADDRESS
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_YAKUWARI
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_SEX
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_AGE
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SHITEIGAI_RIYU
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.DR_SANKA
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_1
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_1
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_1
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_1
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_1
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_2
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_2
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_2
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_2
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_2
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_3
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_3
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_3
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_3
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_3
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_4
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_4
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_4
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_4
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_4
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_5
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_5
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_5
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_5
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_5
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_6
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_6
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_6
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_6
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_6
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_7
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_7
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_7
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_7
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_7
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_8
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_8
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_8
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_8
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_8
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_9
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_9
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_9
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_9
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_9
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_10
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_10
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_10
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_10
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_10
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_11
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_11
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_11
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_11
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_11
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_12
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_12
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_12
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_12
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_12
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_13
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_13
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_13
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_13
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_13
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_14
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_14
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_14
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_14
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_14
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_15
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_15
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_15
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_15
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_15
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_16
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_16
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_16
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_16
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_16
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_17
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_17
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_17
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_17
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_17
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_18
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_18
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_18
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_18
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_18
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_19
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_19
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_19
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_19
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_19
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_DATE_20
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_NO_20
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_20
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_HAKKO_DATE_20
            strSQL &= ",WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_RMKS_20
            strSQL &= " , USER_NAME"
            strSQL &= " FROM"
            strSQL &= " TBL_TAXITICKET_HAKKO"
            strSQL &= " ,TBL_KOTSUHOTEL AS WK_KOTSUHOTEL"
            strSQL &= " , TBL_KOUENKAI AS WK_KOUENKAI"
            strSQL &= " ,"
            strSQL &= " (SELECT N'' AS LOGIN_ID,N'' AS USER_NAME"
            strSQL &= " UNION ALL "
            strSQL &= " SELECT LOGIN_ID,USER_NAME FROM MS_USER"
            strSQL &= " ) AS MS_USER"
            strSQL &= " WHERE"
            strSQL &= " ISNULL(WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO & ",N'')=MS_USER.LOGIN_ID"
            strSQL &= " AND"
            strSQL &= " WK_KOUENKAI.TIME_STAMP=("
            strSQL &= " SELECT MAX(TIME_STAMP)"
            strSQL &= " FROM"
            strSQL &= " TBL_KOUENKAI"
            strSQL &= " WHERE"
            strSQL &= " WK_KOUENKAI.KOUENKAI_NO=KOUENKAI_NO"
            strSQL &= " )"
            strSQL &= " AND"
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO=WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " AND WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & "=("
            strSQL &= " SELECT MAX(" & TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL & ") FROM TBL_KOTSUHOTEL"
            strSQL &= " WHERE WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & "=TBL_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID & " )"
            strSQL &= " AND"
            strSQL &= " TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO & "="
            strSQL &= " WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO
            strSQL &= " AND"
            strSQL &= " TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID & "="
            strSQL &= " WK_KOTSUHOTEL." & TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID

            '未決一覧の場合
            If Miketsu Then
                strSQL &= " AND"
                strSQL &= " TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_MIKETSU & "=N'" & CmnConst.Flag.Off & "'"
                strSQL &= " AND("
                strSQL &= " TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM & "=N''"
                strSQL &= " OR"
                strSQL &= " TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_VOID & "=N'" & CmnConst.Flag.Off & "'"
                strSQL &= " OR"
                strSQL &= " TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE & "=N''"
                strSQL &= ")"
            End If

            '画面抽出条件
            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL &= " AND WK_KOTSUHOTEL."
                strSQL &= TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO
                strSQL &= " =N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.KOUENKAI_NAME) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.KOUENKAI_NAME
                strSQL &= " LIKE N'%" & CmnDb.SqlString(Joken.KOUENKAI_NAME) & "%'"
            End If

            If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " BETWEEN N'" & CmnDb.SqlString(Joken.FROM_DATE) & "' AND N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.FROM_DATE) & "'"
            ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.FROM_DATE
                strSQL &= " =N'" & CmnDb.SqlString(Joken.TO_DATE) & "'"
            End If

            If Trim(Joken.TTANTO_ID) <> "" Then
                strSQL &= " AND WK_KOUENKAI."
                strSQL &= TableDef.TBL_KOUENKAI.Column.TTEHAI_TANTO
                strSQL &= " = N'" & CmnDb.SqlString(Joken.TTANTO_ID) & "'"
            End If

            If Trim(Joken.TKT_NO) <> "" Then
                strSQL &= " AND TBL_TAXITICKET_HAKKO."
                strSQL &= TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO
                strSQL &= " = N'" & CmnDb.SqlString(Joken.TKT_NO) & "'"
            End If

            If Trim(Joken.SANKASHA_ID) <> "" Then
                strSQL &= " AND TBL_TAXITICKET_HAKKO."
                strSQL &= TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID
                strSQL &= " = N'" & CmnDb.SqlString(Joken.SANKASHA_ID) & "'"
            End If

            strSQL &= " ORDER BY"
            strSQL &= " WK_KOUENKAI." & TableDef.TBL_KOUENKAI.Column.FROM_DATE
            strSQL &= ", TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA
            strSQL &= ", TBL_TAXITICKET_HAKKO." & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO

            Return strSQL
        End Function

        Public Shared Function byTKT_NO(ByVal TKT_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_TAXITICKET_HAKKO.TKT_NO=N'" & CmnDb.SqlString(TKT_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_TAXITICKET_HAKKO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

         Public Shared Function TaxiScanCsvCheck(ByVal SANKASHA_ID As String, ByVal KOUENKAI_NO As String, ByVal TKT_LINE_NO As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT *"
            strSQL &= " FROM TBL_TAXITICKET_HAKKO"
            strSQL &= " WHERE TBL_TAXITICKET_HAKKO.SANKASHA_ID=N'" & CmnDb.SqlString(SANKASHA_ID) & "'"
            strSQL &= "   AND TBL_TAXITICKET_HAKKO.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= "   AND CONVERT(INT,TBL_TAXITICKET_HAKKO.TKT_LINE_NO)=N'" & CInt(CmnDb.SqlString(TKT_LINE_NO)).ToString & "'"

            Return strSQL
        End Function

        Public Shared Function TaxiMeisaiCsv(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""
            Dim strSQL_WHERE_KOUENKAI As String = ""
            Dim strSQL_WHERE_TAXITICKET_HAKKO As String = ""

            If Trim(Joken.KOUENKAI_NO) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND TBL_KOUENKAI.KOUENKAI_NO=N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
                strSQL_WHERE_TAXITICKET_HAKKO &= " AND TBL_TAXITICKET_HAKKO.KOUENKAI_NO=N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            End If

            If Trim(Joken.FROM_DATE) <> "" Then
                strSQL_WHERE_KOUENKAI &= " AND ("
                strSQL_WHERE_KOUENKAI &= "      TBL_KOUENKAI.FROM_DATE LIKE N'" & CmnDb.SqlString(Joken.FROM_DATE) & "%'"
                'strSQL_WHERE_KOUENKAI &= "      OR "
                'strSQL_WHERE_KOUENKAI &= "      TBL_KOUENKAI.TO_DATE LIKE N'" & CmnDb.SqlString(Joken.FROM_DATE) & "%'"
                strSQL_WHERE_KOUENKAI &= ")"
            End If

            If Trim(Joken.TKT_ENTA) = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Igai Then
                strSQL_WHERE_TAXITICKET_HAKKO &= "   AND ISNULL(TBL_TAXITICKET_HAKKO.TKT_ENTA,N'')<>N'N'"
            ElseIf Trim(Joken.TKT_ENTA) = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Only Then
                strSQL_WHERE_TAXITICKET_HAKKO &= "   AND ISNULL(TBL_TAXITICKET_HAKKO.TKT_ENTA,N'')=N'N'"
            End If

            strSQL &= "SELECT"
            strSQL &= " TBL_TAXITICKET_HAKKO.*"
            strSQL &= ",TBL_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ",TBL_KOUENKAI.FROM_DATE"
            strSQL &= ",TBL_KOUENKAI.TO_DATE"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ",TBL_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ",TBL_KOUENKAI.WBS_ELEMENT"
            strSQL &= " FROM"
            strSQL &= " TBL_TAXITICKET_HAKKO"
            strSQL &= ","
            strSQL &= "("
            strSQL &= " SELECT TBL_KOUENKAI_1.* FROM "
            strSQL &= " (SELECT * FROM TBL_KOUENKAI"
            strSQL &= "  WHERE 1=1"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= "  ) AS TBL_KOUENKAI_1"
            strSQL &= "  ,"
            strSQL &= " (SELECT MAX(TIME_STAMP) AS TIME_STAMP,KOUENKAI_NO FROM TBL_KOUENKAI"
            strSQL &= "  WHERE 1=1"
            strSQL &= strSQL_WHERE_KOUENKAI
            strSQL &= "  GROUP BY KOUENKAI_NO) AS TBL_KOUENKAI_2"
            strSQL &= "  WHERE TBL_KOUENKAI_1.TIME_STAMP=TBL_KOUENKAI_2.TIME_STAMP"
            strSQL &= "   AND TBL_KOUENKAI_1.KOUENKAI_NO=TBL_KOUENKAI_2.KOUENKAI_NO"
            strSQL &= ") AS TBL_KOUENKAI"
            strSQL &= " WHERE TBL_TAXITICKET_HAKKO.KOUENKAI_NO=TBL_KOUENKAI.KOUENKAI_NO"
            strSQL &= strSQL_WHERE_TAXITICKET_HAKKO

            strSQL &= " ORDER BY"
            strSQL &= " TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM ASC"

            Return strSQL
        End Function

        Public Shared Function TaxiSeisanCsvCheck(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT * FROM"
            strSQL &= " TBL_TAXITICKET_HAKKO TTH"
            strSQL &= " WHERE"
            strSQL &= " TTH.KOUENKAI_NO = N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " AND CAST(ISNULL(TTH.TKT_URIAGE,'') AS BIGINT) <> 0"
            strSQL &= " AND ISNULL(TTH.TKT_ENTA,N'') <> N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.SeisanFuka & "'"

            If Trim(Joken.SEIKYU_NO_TOPTOUR) = "" Then
                strSQL &= " AND RTRIM(ISNULL(TTH.SEIKYU_NO_TOPTOUR,N'')) = N''"
            Else
                strSQL &= " AND "
                strSQL &= " (TTH.SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(Joken.SEIKYU_NO_TOPTOUR) & "'"
                strSQL &= "   OR "
                strSQL &= "  RTRIM(ISNULL(TTH.SEIKYU_NO_TOPTOUR,N'')) = N''"
                strSQL &= " )"
            End If

            Return strSQL
        End Function

        Public Shared Function TaxiSeisanCsv(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " CASE ISNULL(TTH.TKT_ENTA,N'')"
            strSQL &= "  WHEN N'' THEN '非課税'"
            strSQL &= "  WHEN N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.FuSanka & "' THEN '課税'"
            strSQL &= "  ELSE N'' END AS KAZEI_KBN"
            strSQL &= ",CASE ISNULL(TTH.TKT_ENTA,N'')"
            strSQL &= "  WHEN N'' THEN WK_KOUENKAI.COST_CENTER"
            strSQL &= "  WHEN N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.FuSanka & "' THEN WK_KOTSUHOTEL.COST_CENTER"
            strSQL &= "  ELSE N'' END AS COST_CENTER"
            strSQL &= ",TTH.TKT_NO"
            strSQL &= ",TTH.KOUENKAI_NO"
            strSQL &= ",CASE TTH.TKT_LINE_NO"
            strSQL &= "  WHEN N'1' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_1"
            strSQL &= "  WHEN N'2' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_2"
            strSQL &= "  WHEN N'3' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_3"
            strSQL &= "  WHEN N'4' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_4"
            strSQL &= "  WHEN N'5' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_5"
            strSQL &= "  WHEN N'6' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_6"
            strSQL &= "  WHEN N'7' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_7"
            strSQL &= "  WHEN N'8' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_8"
            strSQL &= "  WHEN N'9' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_9"
            strSQL &= "  WHEN N'10' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_10"
            strSQL &= "  WHEN N'11' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_11"
            strSQL &= "  WHEN N'12' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_12"
            strSQL &= "  WHEN N'13' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_13"
            strSQL &= "  WHEN N'14' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_14"
            strSQL &= "  WHEN N'15' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_15"
            strSQL &= "  WHEN N'16' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_16"
            strSQL &= "  WHEN N'17' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_17"
            strSQL &= "  WHEN N'18' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_18"
            strSQL &= "  WHEN N'19' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_19"
            strSQL &= "  WHEN N'20' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_20"
            strSQL &= "  ELSE N'' END AS REQ_TAXI_DATE"
            strSQL &= ",TTH.TKT_USED_DATE"
            strSQL &= ",TTH.TKT_URIAGE"
            strSQL &= ",TTH.TKT_SEISAN_FEE"
            strSQL &= ",TTH.SEIKYU_NO_TOPTOUR"
            strSQL &= ",TTH.TKT_HATUTI"
            strSQL &= ",TTH.TKT_CHAKUTI"
            strSQL &= ",WK_KOUENKAI.WBS_ELEMENT AS WBS_ELEMENT_KOUENKAI"
            strSQL &= " FROM"
            strSQL &= " (SELECT * FROM"
            strSQL &= " TBL_TAXITICKET_HAKKO"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO = N'" & CmnDb.SqlString(Joken.KOUENKAI_NO) & "'"
            strSQL &= " AND SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(Joken.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= " AND CAST(ISNULL(TKT_URIAGE,'') AS BIGINT) <> 0"
            strSQL &= " AND ISNULL(TKT_ENTA,N'') <> N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.SeisanFuka & "'"
            strSQL &= " ) TTH"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "  FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "  GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "  ) WK1"
            strSQL &= "  ON TTH.KOUENKAI_NO = WK1.KOUENKAI_NO AND TTH.SANKASHA_ID = WK1.SANKASHA_ID"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOTSUHOTEL) WK_KOTSUHOTEL"
            strSQL &= "   ON (WK1.SALEFORCE_ID = WK_KOTSUHOTEL.SALEFORCE_ID)"
            strSQL &= "  AND (WK1.KOUENKAI_NO = WK_KOTSUHOTEL.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK_KOTSUHOTEL.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK_KOTSUHOTEL.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK_KOTSUHOTEL.TIME_STAMP_BYL)"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            strSQL &= "  WHERE  WK3.TIME_STAMP = "
            strSQL &= "  (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= "   WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            strSQL &= "  )WK_KOUENKAI"
            strSQL &= "    ON TTH.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " ORDER BY"
            strSQL &= " CASE ISNULL(TTH.TKT_ENTA,N'')"
            strSQL &= "  WHEN N'' THEN '0' WHEN N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.FuSanka & "' THEN '1' ELSE '9' END"
            strSQL &= ",COST_CENTER"

            Return strSQL
        End Function

        Public Shared Function SapCsvTaxi(ByVal kouenkaiNo As String, ByVal seisanNo As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " WK_KOTSUHOTEL.COST_CENTER"
            strSQL &= ",SUM(CAST(ISNULL(WK_TAXI.TKT_URIAGE,'') AS BIGINT) + CAST(ISNULL(WK_TAXI.TKT_SEISAN_FEE,'') AS BIGINT)) AS TKT_URIAGE"
            strSQL &= " FROM"
            strSQL &= " (SELECT * FROM TBL_TAXITICKET_HAKKO"
            strSQL &= "  WHERE"
            strSQL &= "  KOUENKAI_NO = N'" & CmnDb.SqlString(kouenkaiNo) & "'"
            strSQL &= "  AND SEIKYU_NO_TOPTOUR = N'" & CmnDb.SqlString(seisanNo) & "'"
            strSQL &= "  AND TKT_ENTA = N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.FuSanka & "'"
            strSQL &= " ) WK_TAXI"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT WK2.* FROM"
            strSQL &= "  (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= "   FROM TBL_KOTSUHOTEL TKH"
            strSQL &= "   GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= "   ) WK1"
            strSQL &= "  LEFT JOIN"
            strSQL &= "  (SELECT * FROM TBL_KOTSUHOTEL)WK2"
            strSQL &= "  ON (WK1.SALEFORCE_ID = WK2.SALEFORCE_ID)"
            strSQL &= "  AND(WK1.KOUENKAI_NO = WK2.KOUENKAI_NO)"
            strSQL &= "  AND (WK1.SANKASHA_ID = WK2.SANKASHA_ID)"
            strSQL &= "  AND (WK1.DR_MPID = WK2.DR_MPID)"
            strSQL &= "  AND (WK1.TIME_STAMP_BYL = WK2.TIME_STAMP_BYL)"
            strSQL &= " ) WK_KOTSUHOTEL"
            strSQL &= "  ON WK_TAXI.KOUENKAI_NO = WK_KOTSUHOTEL.KOUENKAI_NO"
            strSQL &= " AND WK_TAXI.SANKASHA_ID = WK_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= " WHERE CAST(ISNULL(WK_TAXI.TKT_URIAGE,'') AS BIGINT) <> 0"
            strSQL &= " GROUP BY WK_KOTSUHOTEL.COST_CENTER"
            strSQL &= " ORDER BY WK_KOTSUHOTEL.COST_CENTER"

            Return strSQL
        End Function

        Public Shared Function TaxiJissekiCsv(ByVal fromDate As String, ByVal toDate As String) As String
            Dim strSQL As String = String.Empty

            strSQL &= "SELECT DISTINCT"
            strSQL &= " WK_SHOUNIN.*"
            strSQL &= ", WK_TAXITICKET_HAKKO.*"
            strSQL &= ", WK_KOTSUHOTEL.*"
            strSQL &= ", WK_SEIKYU.*"
            strSQL &= ", CASE WK_TAXITICKET_HAKKO.TKT_LINE_NO"
            strSQL &= "  WHEN N'1' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_1"
            strSQL &= "  WHEN N'2' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_2"
            strSQL &= "  WHEN N'3' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_3"
            strSQL &= "  WHEN N'4' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_4"
            strSQL &= "  WHEN N'5' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_5"
            strSQL &= "  WHEN N'6' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_6"
            strSQL &= "  WHEN N'7' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_7"
            strSQL &= "  WHEN N'8' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_8"
            strSQL &= "  WHEN N'9' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_9"
            strSQL &= "  WHEN N'10' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_10"
            strSQL &= "  WHEN N'11' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_11"
            strSQL &= "  WHEN N'12' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_12"
            strSQL &= "  WHEN N'13' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_13"
            strSQL &= "  WHEN N'14' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_14"
            strSQL &= "  WHEN N'15' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_15"
            strSQL &= "  WHEN N'16' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_16"
            strSQL &= "  WHEN N'17' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_17"
            strSQL &= "  WHEN N'18' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_18"
            strSQL &= "  WHEN N'19' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_19"
            strSQL &= "  WHEN N'20' THEN WK_KOTSUHOTEL.ANS_TAXI_DATE_20"
            strSQL &= "  ELSE N'' END AS ANS_TAXI_DATE"
            strSQL &= ", CASE WK_TAXITICKET_HAKKO.TKT_LINE_NO"
            strSQL &= "  WHEN N'1' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_1"
            strSQL &= "  WHEN N'2' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_2"
            strSQL &= "  WHEN N'3' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_3"
            strSQL &= "  WHEN N'4' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_4"
            strSQL &= "  WHEN N'5' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_5"
            strSQL &= "  WHEN N'6' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_6"
            strSQL &= "  WHEN N'7' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_7"
            strSQL &= "  WHEN N'8' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_8"
            strSQL &= "  WHEN N'9' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_9"
            strSQL &= "  WHEN N'10' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_10"
            strSQL &= "  WHEN N'11' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_11"
            strSQL &= "  WHEN N'12' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_12"
            strSQL &= "  WHEN N'13' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_13"
            strSQL &= "  WHEN N'14' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_14"
            strSQL &= "  WHEN N'15' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_15"
            strSQL &= "  WHEN N'16' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_16"
            strSQL &= "  WHEN N'17' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_17"
            strSQL &= "  WHEN N'18' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_18"
            strSQL &= "  WHEN N'19' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_19"
            strSQL &= "  WHEN N'20' THEN WK_KOTSUHOTEL.ANS_TAXI_RMKS_20"
            strSQL &= "  ELSE N'' END AS ANS_TAXI_RMKS"
            strSQL &= ", CASE WK_TAXITICKET_HAKKO.TKT_LINE_NO"
            strSQL &= "  WHEN N'1' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_1"
            strSQL &= "  WHEN N'2' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_2"
            strSQL &= "  WHEN N'3' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_3"
            strSQL &= "  WHEN N'4' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_4"
            strSQL &= "  WHEN N'5' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_5"
            strSQL &= "  WHEN N'6' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_6"
            strSQL &= "  WHEN N'7' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_7"
            strSQL &= "  WHEN N'8' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_8"
            strSQL &= "  WHEN N'9' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_9"
            strSQL &= "  WHEN N'10' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_10"
            strSQL &= "  WHEN N'11' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_11"
            strSQL &= "  WHEN N'12' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_12"
            strSQL &= "  WHEN N'13' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_13"
            strSQL &= "  WHEN N'14' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_14"
            strSQL &= "  WHEN N'15' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_15"
            strSQL &= "  WHEN N'16' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_16"
            strSQL &= "  WHEN N'17' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_17"
            strSQL &= "  WHEN N'18' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_18"
            strSQL &= "  WHEN N'19' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_19"
            strSQL &= "  WHEN N'20' THEN WK_KOTSUHOTEL.ANS_TAXI_SRMKS_20"
            strSQL &= "  ELSE N'' END AS ANS_TAXI_SRMKS"
            strSQL &= ", WK_KOUENKAI.KOUENKAI_NAME"
            strSQL &= ", WK_KOUENKAI.KAIJO_NAME"
            strSQL &= ", WK_KOUENKAI.WBS_ELEMENT AS WBS_ELEMENT_KOUENKAI"
            strSQL &= ", WK_KOUENKAI.FROM_DATE"
            strSQL &= ", WK_KOUENKAI.TO_DATE"
            strSQL &= ", WK_KOUENKAI.ACCOUNT_CD_TF AS KIHON_ACCOUNT_CD_TF"
            strSQL &= ", WK_KOUENKAI.ACCOUNT_CD_T AS KIHON_ACCOUNT_CD_T"
            strSQL &= ", WK_KOUENKAI.COST_CENTER AS KIHON_COST_CENTER"
            strSQL &= ", WK_KOUENKAI.INTERNAL_ORDER_TF AS KIHON_INTERNAL_ORDER"
            strSQL &= ", WK_KOUENKAI.ZETIA_CD AS KIHON_ZETIA_CD"
            strSQL &= ", WK_KOUENKAI.SRM_HACYU_KBN"
            strSQL &= ", WK_KOUENKAI.BU"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_AREA"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_EIGYOSHO"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_NAME"
            strSQL &= ", WK_KOUENKAI.KIKAKU_TANTO_ROMA"
            strSQL &= ", TBL_SANKA.DR_SANKA AS SANKA_FLAG"
            strSQL &= ", TBL_SANKA.UPDATE_DATE AS SANKA_UPDATE"
            strSQL &= " FROM"
            strSQL &= " (SELECT"
            strSQL &= " TSN.KOUENKAI_NO"
            strSQL &= " ,TSN.SHOUNIN_DATE"
            strSQL &= " ,TSN.SHIHARAI_NO"
            strSQL &= " ,TSN.SEIKYU_NO_TOPTOUR"
            strSQL &= " FROM TBL_SHOUNIN TSN"
            strSQL &= " WHERE TSN.SHOUNIN_DATE BETWEEN N'" & CmnDb.SqlString(fromDate) & "' AND N'" & CmnDb.SqlString(toDate) & "'"
            strSQL &= " AND TSN.SHOUNIN_KUBUN = N'" & AppConst.SEISAN.SHOUNIN_KUBUN.Code.SHOUNIN & "'"
            strSQL &= " ) WK_SHOUNIN "
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM"
            strSQL &= " TBL_TAXITICKET_HAKKO"
            strSQL &= " ) WK_TAXITICKET_HAKKO"
            strSQL &= " ON WK_SHOUNIN.SEIKYU_NO_TOPTOUR=WK_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID,MAX(TKH.TIME_STAMP_BYL) AS TIME_STAMP_BYL"
            strSQL &= " FROM TBL_KOTSUHOTEL TKH"
            strSQL &= " GROUP BY TKH.SALEFORCE_ID,TKH.KOUENKAI_NO,TKH.SANKASHA_ID,TKH.DR_MPID"
            strSQL &= " ) WK1"
            strSQL &= " ON WK_TAXITICKET_HAKKO.KOUENKAI_NO = WK1.KOUENKAI_NO"
            strSQL &= " AND WK_TAXITICKET_HAKKO.SANKASHA_ID = WK1.SANKASHA_ID"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT"
            strSQL &= " KOUENKAI_NO"
            strSQL &= ", SANKASHA_ID"
            strSQL &= ", TIME_STAMP_BYL"
            strSQL &= ", SALEFORCE_ID"
            strSQL &= ", DR_MPID"
            strSQL &= ", DR_CD"
            strSQL &= ", DR_NAME"
            strSQL &= ", DR_KANA"
            strSQL &= ", DR_SHISETSU_NAME"
            strSQL &= ", DR_YAKUWARI"
            strSQL &= ", WBS_ELEMENT"
            strSQL &= ", SHITEIGAI_RIYU"
            strSQL &= ", MR_BU"
            strSQL &= ", MR_AREA"
            strSQL &= ", MR_EIGYOSHO"
            strSQL &= ", MR_NAME"
            strSQL &= ", MR_KANA"
            strSQL &= ", MR_KEITAI"
            strSQL &= ", COST_CENTER AS KOTSU_COST_CENTER"
            strSQL &= ", ACCOUNT_CD AS KOTSU_ACCOUNT_CD"
            strSQL &= ", INTERNAL_ORDER AS KOTSU_INTERNAL_ORDER"
            strSQL &= ", ZETIA_CD AS KOTSU_ZETIA_CD"
            strSQL &= ", ANS_TAXI_DATE_1"
            strSQL &= ", ANS_TAXI_DATE_2"
            strSQL &= ", ANS_TAXI_DATE_3"
            strSQL &= ", ANS_TAXI_DATE_4"
            strSQL &= ", ANS_TAXI_DATE_5"
            strSQL &= ", ANS_TAXI_DATE_6"
            strSQL &= ", ANS_TAXI_DATE_7"
            strSQL &= ", ANS_TAXI_DATE_8"
            strSQL &= ", ANS_TAXI_DATE_9"
            strSQL &= ", ANS_TAXI_DATE_10"
            strSQL &= ", ANS_TAXI_DATE_11"
            strSQL &= ", ANS_TAXI_DATE_12"
            strSQL &= ", ANS_TAXI_DATE_13"
            strSQL &= ", ANS_TAXI_DATE_14"
            strSQL &= ", ANS_TAXI_DATE_15"
            strSQL &= ", ANS_TAXI_DATE_16"
            strSQL &= ", ANS_TAXI_DATE_17"
            strSQL &= ", ANS_TAXI_DATE_18"
            strSQL &= ", ANS_TAXI_DATE_19"
            strSQL &= ", ANS_TAXI_DATE_20"
            strSQL &= ", ANS_TAXI_RMKS_1"
            strSQL &= ", ANS_TAXI_RMKS_2"
            strSQL &= ", ANS_TAXI_RMKS_3"
            strSQL &= ", ANS_TAXI_RMKS_4"
            strSQL &= ", ANS_TAXI_RMKS_5"
            strSQL &= ", ANS_TAXI_RMKS_6"
            strSQL &= ", ANS_TAXI_RMKS_7"
            strSQL &= ", ANS_TAXI_RMKS_8"
            strSQL &= ", ANS_TAXI_RMKS_9"
            strSQL &= ", ANS_TAXI_RMKS_10"
            strSQL &= ", ANS_TAXI_RMKS_11"
            strSQL &= ", ANS_TAXI_RMKS_12"
            strSQL &= ", ANS_TAXI_RMKS_13"
            strSQL &= ", ANS_TAXI_RMKS_14"
            strSQL &= ", ANS_TAXI_RMKS_15"
            strSQL &= ", ANS_TAXI_RMKS_16"
            strSQL &= ", ANS_TAXI_RMKS_17"
            strSQL &= ", ANS_TAXI_RMKS_18"
            strSQL &= ", ANS_TAXI_RMKS_19"
            strSQL &= ", ANS_TAXI_RMKS_20"
            strSQL &= ", ANS_TAXI_SRMKS_1"
            strSQL &= ", ANS_TAXI_SRMKS_2"
            strSQL &= ", ANS_TAXI_SRMKS_3"
            strSQL &= ", ANS_TAXI_SRMKS_4"
            strSQL &= ", ANS_TAXI_SRMKS_5"
            strSQL &= ", ANS_TAXI_SRMKS_6"
            strSQL &= ", ANS_TAXI_SRMKS_7"
            strSQL &= ", ANS_TAXI_SRMKS_8"
            strSQL &= ", ANS_TAXI_SRMKS_9"
            strSQL &= ", ANS_TAXI_SRMKS_10"
            strSQL &= ", ANS_TAXI_SRMKS_11"
            strSQL &= ", ANS_TAXI_SRMKS_12"
            strSQL &= ", ANS_TAXI_SRMKS_13"
            strSQL &= ", ANS_TAXI_SRMKS_14"
            strSQL &= ", ANS_TAXI_SRMKS_15"
            strSQL &= ", ANS_TAXI_SRMKS_16"
            strSQL &= ", ANS_TAXI_SRMKS_17"
            strSQL &= ", ANS_TAXI_SRMKS_18"
            strSQL &= ", ANS_TAXI_SRMKS_19"
            strSQL &= ", ANS_TAXI_SRMKS_20"
            strSQL &= ", REQ_TAXI_NOTE"
            strSQL &= ", ANS_TAXI_NOTE"
            strSQL &= " FROM TBL_KOTSUHOTEL) WK_KOTSUHOTEL"
            strSQL &= " ON (WK1.SALEFORCE_ID = WK_KOTSUHOTEL.SALEFORCE_ID)"
            strSQL &= " AND (WK1.KOUENKAI_NO = WK_KOTSUHOTEL.KOUENKAI_NO)"
            strSQL &= " AND (WK1.SANKASHA_ID = WK_KOTSUHOTEL.SANKASHA_ID)"
            strSQL &= " AND (WK1.DR_MPID = WK_KOTSUHOTEL.DR_MPID)"
            strSQL &= " AND (WK1.TIME_STAMP_BYL = WK_KOTSUHOTEL.TIME_STAMP_BYL)"
            strSQL &= " LEFT JOIN"
            strSQL &= " (SELECT * FROM TBL_KOUENKAI WK3"
            strSQL &= " WHERE  WK3.TIME_STAMP = "
            strSQL &= " (SELECT MAX(TBL_KOUENKAI.TIME_STAMP) FROM TBL_KOUENKAI"
            strSQL &= " WHERE TBL_KOUENKAI.KOUENKAI_NO = WK3.KOUENKAI_NO)"
            strSQL &= " )WK_KOUENKAI"
            strSQL &= " ON WK_TAXITICKET_HAKKO.KOUENKAI_NO = WK_KOUENKAI.KOUENKAI_NO"
            strSQL &= " LEFT JOIN TBL_SANKA ON "
            strSQL &= " WK_KOTSUHOTEL.KOUENKAI_NO = TBL_SANKA.KOUENKAI_NO"
            strSQL &= " AND "
            strSQL &= " WK_KOTSUHOTEL.SANKASHA_ID = TBL_SANKA.SANKASHA_ID"
            strSQL &= " LEFT JOIN"
            strSQL &= "(SELECT KOUENKAI_NO"
            strSQL &= ", SEIKYU_NO_TOPTOUR"
            strSQL &= ",SEISAN_YM"
            strSQL &= " FROM TBL_SEIKYU) WK_SEIKYU"
            strSQL &= " ON WK_SEIKYU.KOUENKAI_NO=WK_SHOUNIN.KOUENKAI_NO"
            strSQL &= " AND"
            strSQL &= " WK_SEIKYU.SEIKYU_NO_TOPTOUR=WK_SHOUNIN.SEIKYU_NO_TOPTOUR"
            strSQL &= " WHERE"
            strSQL &= " WK_TAXITICKET_HAKKO.TKT_NO<>N''"
            strSQL &= " ORDER BY"
            strSQL &= " WK_SHOUNIN.KOUENKAI_NO"
            strSQL &= ", WK_SHOUNIN.SHIHARAI_NO"
            strSQL &= ", WK_KOTSUHOTEL.SANKASHA_ID"
            strSQL &= ", WK_TAXITICKET_HAKKO.TKT_NO"

            Return strSQL
        End Function
        Public Shared Function TaxiJissekiMiseisanCsv() As String
            Dim strSQL As String = ""

            strSQL &= " SELECT * FROM TBL_TAXITICKET_HAKKO"
            strSQL &= " WHERE "
            strSQL &= TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE
            strSQL &= " IS NOT NULL AND "
            strSQL &= TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE
            strSQL &= "<>'' AND"
            strSQL &= " (" & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM
            strSQL &= "='' OR "
            strSQL &= TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM
            strSQL &= " IS NULL)"
            strSQL &= " ORDER BY "
            strSQL &= TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA
            strSQL &= ", " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_TAXITICKET_HAKKO"
            strSQL &= "(" & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KENSHU
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_LINE_NO
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEISAN_FEE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HAKKO_FEE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_ENTA
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_VOID
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_MIKETSU
            '@@@ 2014/10/20 Delete
            'strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.INPUT_DATE
            'strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KAISHA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KENSHU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SANKASHA_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_LINE_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_USED_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_ENTA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_VOID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_MIKETSU) & "'"
            '@@@ 2014/10/20 Delete
            'strSQL &= ",N'" & GetValue.DATE() & "'"
            'strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Insert_OTH(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_TAXITICKET_HAKKO"
            strSQL &= "(" & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KENSHU
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_LINE_NO
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_URIAGE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEISAN_FEE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HAKKO_FEE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_ENTA
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_VOID
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_MIKETSU
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_IMPORT_DATE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SEIKYU_NO_TOPTOUR
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_USER
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HATUTI
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_CHAKUTI
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KAISHA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KENSHU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SANKASHA_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_LINE_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_USED_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_URIAGE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_ENTA) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_VOID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_MIKETSU) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_IMPORT_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.INPUT_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.INPUT_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_DATE) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_USER) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HATUTI) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_CHAKUTI) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_TAXITICKET_HAKKO SET"
            strSQL &= " " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KENSHU & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KENSHU) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.KOUENKAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SANKASHA_ID) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_LINE_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_LINE_NO) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_URIAGE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_URIAGE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_USED_DATE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEISAN_FEE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HAKKO_FEE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_ENTA & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_ENTA) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_VOID & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_VOID) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_MIKETSU & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_MIKETSU) & "'"
            '@@@ 2014/10/20 Add Start
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_IMPORT_DATE & "=N'" & CmnModule.GetSysDate() & "'"
            '@@@ 2014/10/20 Add End
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            '@@@ 2016/07/07 Add Start
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HATUTI & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HATUTI) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_CHAKUTI & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_CHAKUTI) & "'"
            '@@@ 2016/07/07 Add End
            strSQL &= " WHERE " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KAISHA) & "'"
            strSQL &= " AND " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_NO) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_OTH(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_TAXITICKET_HAKKO SET"
            strSQL &= " " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KENSHU & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KENSHU) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.KOUENKAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SANKASHA_ID) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_LINE_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_LINE_NO) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_USED_DATE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_USED_DATE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_URIAGE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_URIAGE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEISAN_FEE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HAKKO_FEE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_ENTA & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_ENTA) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_VOID & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_VOID) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_MIKETSU & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_MIKETSU) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_IMPORT_DATE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_IMPORT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_DATE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_USER) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HATUTI & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HATUTI) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_CHAKUTI & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_CHAKUTI) & "'"
            strSQL &= " WHERE " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KAISHA) & "'"
            strSQL &= " AND " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_NO) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_TaxiScan(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_TAXITICKET_HAKKO SET"
            strSQL &= " " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KENSHU & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KENSHU) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.KOUENKAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SANKASHA_ID) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_LINE_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_LINE_NO) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_HAKKO_FEE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_IMPORT_DATE & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_IMPORT_DATE) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_USER) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= " WHERE " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KAISHA) & "'"
            strSQL &= " AND " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_NO) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_SEIKYU_NO_YM(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct)
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_TAXITICKET_HAKKO SET"
            strSQL &= " " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_SEIKYU_YM & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.UPDATE_USER) & "'"
            strSQL &= "," & TableDef.TBL_TAXITICKET_HAKKO.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= " WHERE " & TableDef.TBL_TAXITICKET_HAKKO.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.KOUENKAI_NO) & "'"
            strSQL &= " AND ISNULL(" & TableDef.TBL_TAXITICKET_HAKKO.Column.SEIKYU_NO_TOPTOUR & ",N'') = N''"
            strSQL &= " AND CAST(ISNULL(" & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_URIAGE & ",'') AS BIGINT) <> 0"
            strSQL &= " AND ISNULL(" & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_ENTA & ",N'') <> N'" & AppConst.TAXITICKET_HAKKO.TKT_ENTA.Code.SeisanFuka & "'"

            Return strSQL
        End Function

        Public Shared Function Delete(ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "DELETE TBL_TAXITICKET_HAKKO"
            strSQL &= " WHERE " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_KAISHA & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_KAISHA) & "'"
            strSQL &= " AND " & TableDef.TBL_TAXITICKET_HAKKO.Column.TKT_NO & "=N'" & CmnDb.SqlString(TBL_TAXITICKET_HAKKO.TKT_NO) & "'"

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_TAXITICKET_HAKKO"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

            Return strSQL
        End Function
    End Class

    Public Class TBL_SANKA

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_SANKA.*" _
        & " FROM TBL_SANKA"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_SANKA.KOUENKAI_NO" _
        & ",TBL_SANKA.SANKASHA_ID"

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_SANKA.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO_SANKASHA_ID(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_SANKA.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_SANKA.SANKASHA_ID=N'" & CmnDb.SqlString(SANKASHA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_SANKA As TableDef.TBL_SANKA.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_SANKA"
            strSQL &= " (" & TableDef.TBL_SANKA.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_SANKA.Column.SANKASHA_ID
            strSQL &= "," & TableDef.TBL_SANKA.Column.DR_SANKA
            strSQL &= "," & TableDef.TBL_SANKA.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_SANKA.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_SANKA.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_SANKA.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_SANKA.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SANKA.SANKASHA_ID) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SANKA.DR_SANKA) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SANKA.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SANKA.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_SANKA As TableDef.TBL_SANKA.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SANKA SET"
            strSQL &= " " & TableDef.TBL_SANKA.Column.DR_SANKA & "=N'" & CmnDb.SqlString(TBL_SANKA.DR_SANKA) & "'"
            strSQL &= "," & TableDef.TBL_SANKA.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SANKA.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SANKA.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SANKA.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SANKA.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SANKA.Column.SANKASHA_ID & "=N'" & CmnDb.SqlString(TBL_SANKA.SANKASHA_ID) & "'"

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_SANKA"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_SHOUNIN

        Public Shared Function byKOUENKAI_NO_SEIKYU_NO_TOPTOUR(ByVal KOUENKAI_NO As String, ByVal SEIKYU_NO_TOPTOUR As String) As String
            Dim strSQL As String = "SELECT * FROM TBL_SHOUNIN"

            strSQL &= " WHERE TBL_SHOUNIN.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"
            strSQL &= " AND TBL_SHOUNIN.SEIKYU_NO_TOPTOUR=N'" & CmnDb.SqlString(SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function byKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = "SELECT * FROM TBL_SHOUNIN"

            strSQL &= " WHERE TBL_SHOUNIN.KOUENKAI_NO=N'" & CmnDb.SqlString(KOUENKAI_NO) & "'"

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_SHOUNIN As TableDef.TBL_SHOUNIN.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_SHOUNIN"
            strSQL &= " (" & TableDef.TBL_SHOUNIN.Column.KOUENKAI_NO
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SEIKYU_NO_TOPTOUR
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHIHARAI_NO
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHOUNIN_KUBUN
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHOUNIN_DATE
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.INPUT_DATE
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.INPUT_USER
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.UPDATE_DATE
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.UPDATE_USER
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_SHOUNIN.KOUENKAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SHOUNIN.SEIKYU_NO_TOPTOUR) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SHOUNIN.SHIHARAI_NO) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SHOUNIN.SHOUNIN_KUBUN) & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SHOUNIN.SHOUNIN_DATE) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SHOUNIN.INPUT_USER) & "'"
            strSQL &= ",N'" & GetValue.DATE() & "'"
            strSQL &= ",N'" & CmnDb.SqlString(TBL_SHOUNIN.UPDATE_USER) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_SHOUNIN As TableDef.TBL_SHOUNIN.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SHOUNIN SET"
            strSQL &= " " & TableDef.TBL_SHOUNIN.Column.SHIHARAI_NO & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SHIHARAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHOUNIN_KUBUN & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SHOUNIN_KUBUN) & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHOUNIN_DATE & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SHOUNIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SHOUNIN.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SHOUNIN.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_MAINTENANCE(ByVal TBL_SHOUNIN As TableDef.TBL_SHOUNIN.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_SHOUNIN SET"
            strSQL &= " " & TableDef.TBL_SHOUNIN.Column.SHIHARAI_NO & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SHIHARAI_NO) & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHOUNIN_KUBUN & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SHOUNIN_KUBUN) & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.SHOUNIN_DATE & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SHOUNIN_DATE) & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.UPDATE_DATE & "=N'" & GetValue.DATE() & "'"
            strSQL &= "," & TableDef.TBL_SHOUNIN.Column.UPDATE_USER & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.UPDATE_USER) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SHOUNIN.Column.KOUENKAI_NO & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.KOUENKAI_NO) & "'"
            strSQL &= " AND " & TableDef.TBL_SHOUNIN.Column.SEIKYU_NO_TOPTOUR & "=N'" & CmnDb.SqlString(TBL_SHOUNIN.SEIKYU_NO_TOPTOUR) & "'"

            Return strSQL
        End Function

        Public Shared Function DeleteByKOUENKAI_NO(ByVal KOUENKAI_NO As String) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_SHOUNIN"
            strSQL &= " WHERE"
            strSQL &= " KOUENKAI_NO='" & KOUENKAI_NO & "'"

            Return strSQL
        End Function
    End Class

    Public Class TBL_DELIGATE

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_DELIGATE.*" _
        & " FROM TBL_DELIGATE"

        Public Shared Function byLOGIN_ID(ByVal LOGIN_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DELIGATE.LOGIN_ID=N'" & CmnDb.SqlString(LOGIN_ID) & "'"

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_DELIGATE As TableDef.TBL_DELIGATE.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_DELIGATE"
            strSQL &= " (" & TableDef.TBL_DELIGATE.Column.LOGIN_ID
            strSQL &= "," & TableDef.TBL_DELIGATE.Column.CNT
            strSQL &= "," & TableDef.TBL_DELIGATE.Column.MAXCNT
            strSQL &= "," & TableDef.TBL_DELIGATE.Column.CSVSTRING
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_DELIGATE.LOGIN_ID) & "'"
            strSQL &= "," & CmnDb.SqlString(TBL_DELIGATE.CNT)
            strSQL &= "," & CmnDb.SqlString(TBL_DELIGATE.MAXCNT)
            strSQL &= ",N'" & CmnDb.SqlString(TBL_DELIGATE.CSVSTRING) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_DELIGATE As TableDef.TBL_DELIGATE.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_DELIGATE SET"
            strSQL &= " " & TableDef.TBL_DELIGATE.Column.CNT & "=" & TBL_DELIGATE.CNT
            strSQL &= "," & TableDef.TBL_DELIGATE.Column.MAXCNT & "=" & TBL_DELIGATE.MAXCNT
            strSQL &= "," & TableDef.TBL_DELIGATE.Column.CSVSTRING & "=N'" & CmnDb.SqlString(TBL_DELIGATE.CSVSTRING) & "'"
            strSQL &= " WHERE " & TableDef.TBL_DELIGATE.Column.LOGIN_ID & "=N'" & CmnDb.SqlString(TBL_DELIGATE.LOGIN_ID) & "'"

            Return strSQL
        End Function
    End Class

    Public Class TBL_DELIGATE2

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_DELIGATE2.*" _
        & " FROM TBL_DELIGATE2"

        Public Shared Function byLOGIN_ID(ByVal LOGIN_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DELIGATE2.LOGIN_ID=N'" & CmnDb.SqlString(LOGIN_ID) & "'"

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_DELIGATE2"
            strSQL &= " (" & TableDef.TBL_DELIGATE2.Column.LOGIN_ID
            strSQL &= "," & TableDef.TBL_DELIGATE2.Column.CNT
            strSQL &= "," & TableDef.TBL_DELIGATE2.Column.MAXCNT
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_DELIGATE2.LOGIN_ID) & "'"
            strSQL &= "," & CmnDb.SqlString(TBL_DELIGATE2.CNT)
            strSQL &= "," & CmnDb.SqlString(TBL_DELIGATE2.MAXCNT)
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_DELIGATE2 SET"
            strSQL &= " " & TableDef.TBL_DELIGATE2.Column.CNT & "=" & TBL_DELIGATE2.CNT
            strSQL &= "," & TableDef.TBL_DELIGATE2.Column.MAXCNT & "=" & TBL_DELIGATE2.MAXCNT
            strSQL &= " WHERE " & TableDef.TBL_DELIGATE2.Column.LOGIN_ID & "=N'" & CmnDb.SqlString(TBL_DELIGATE2.LOGIN_ID) & "'"

            Return strSQL
        End Function
    End Class

    Public Class TBL_BUNSEKICSV

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_BUNSEKICSV.*" _
        & " FROM TBL_BUNSEKICSV"

        Public Shared Function byLOGIN_ID(ByVal LOGIN_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_BUNSEKICSV.LOGIN_ID=N'" & CmnDb.SqlString(LOGIN_ID) & "'"
            strSQL &= " ORDER BY LINE_NO"

            Return strSQL
        End Function

        Public Shared Function Insert(ByVal TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_BUNSEKICSV"
            strSQL &= " (" & TableDef.TBL_BUNSEKICSV.Column.LOGIN_ID
            strSQL &= "," & TableDef.TBL_BUNSEKICSV.Column.LINE_NO
            strSQL &= "," & TableDef.TBL_BUNSEKICSV.Column.LINE_DATA
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "(N'" & CmnDb.SqlString(TBL_BUNSEKICSV.LOGIN_ID) & "'"
            strSQL &= "," & CmnDb.SqlString(TBL_BUNSEKICSV.LINE_NO)
            strSQL &= ",N'" & CmnDb.SqlString(TBL_BUNSEKICSV.LINE_DATA) & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "UPDATE TBL_BUNSEKICSV SET"
            strSQL &= " " & TableDef.TBL_BUNSEKICSV.Column.LINE_NO & "=" & TBL_BUNSEKICSV.line_no
            strSQL &= "," & TableDef.TBL_BUNSEKICSV.Column.LINE_DATA & "=N'" & TBL_BUNSEKICSV.LINE_DATA & "'"
            strSQL &= " WHERE " & TableDef.TBL_BUNSEKICSV.Column.LOGIN_ID & "=N'" & CmnDb.SqlString(TBL_BUNSEKICSV.LOGIN_ID) & "'"

            Return strSQL
        End Function

        Public Shared Function Delete(ByVal TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct) As String
            Dim strSQL As String = ""

            strSQL = "DELETE FROM TBL_BUNSEKICSV"
            strSQL &= " WHERE " & TableDef.TBL_BUNSEKICSV.Column.LOGIN_ID & "=N'" & CmnDb.SqlString(TBL_BUNSEKICSV.LOGIN_ID) & "'"

            Return strSQL
        End Function
    End Class

    Public Class ALTER_INDEX
        Public Shared Function AlterIndex1() As String
            Dim strSQL As String = ""

            strSQL = "ALTER INDEX ALL ON TBL_KOUENKAI REBUILD;" & vbCrLf

            Return strSQL
        End Function
        Public Shared Function AlterIndex2() As String
            Dim strSQL As String = ""

            strSQL &= "ALTER INDEX ALL ON TBL_KAIJO REBUILD;" & vbCrLf

            Return strSQL
        End Function
        Public Shared Function AlterIndex3() As String
            Dim strSQL As String = ""

            strSQL &= "ALTER INDEX ALL ON TBL_KOTSUHOTEL REBUILD;" & vbCrLf

            Return strSQL
        End Function
        Public Shared Function AlterIndex4() As String
            Dim strSQL As String = ""

            strSQL &= "ALTER INDEX ALL ON TBL_SANKA REBUILD;" & vbCrLf

            Return strSQL
        End Function
        Public Shared Function AlterIndex5() As String
            Dim strSQL As String = ""

            strSQL &= "ALTER INDEX ALL ON TBL_SEIKYU REBUILD;" & vbCrLf

            Return strSQL
        End Function
        Public Shared Function AlterIndex6() As String
            Dim strSQL As String = ""

            strSQL &= "ALTER INDEX ALL ON TBL_TAXITICKET_HAKKO REBUILD;" & vbCrLf

            Return strSQL
        End Function
        Public Shared Function AlterIndex7() As String
            Dim strSQL As String = ""

            strSQL &= "ALTER INDEX ALL ON TBL_SHOUNIN REBUILD;" & vbCrLf

            Return strSQL
        End Function
    End Class
End Class
