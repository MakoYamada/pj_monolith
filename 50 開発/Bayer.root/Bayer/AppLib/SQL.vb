Imports CommonLib
Imports AppLib
Public Class SQL

    Public Class GetValue
        Public Shared Function [DATE]() As String
            Return CmnModule.GetSysDateTime()
        End Function
        Public Shared Function USER() As String
            Return System.Web.HttpContext.Current.Session.Item(SessionDef.UserType) & ":" & System.Web.HttpContext.Current.Session.Item(SessionDef.LoginID)
        End Function
        Public Shared Function PGM() As String
            Return System.Web.HttpContext.Current.Request.Path
        End Function
    End Class

    Public Class MS_CODE

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_CODE.*" _
        & " FROM MS_CODE"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_CODE.DATA_ID"

        Public Shared Function byCODE(ByVal CODE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_CODE.CODE='" & CmnDb.SqlString(CODE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_OFFICE

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_OFFICE.*" _
        & " FROM MS_OFFICE"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_OFFICE.SORT_NO"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byOFFICE(ByVal OFFICE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_OFFICE.OFFICE='" & CmnDb.SqlString(OFFICE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_MEMBER

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_MEMBER.*" _
        & ",MS_MEMBER.MEMBER_NAME_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_LAST AS MEMBER_NAME" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_KANA_LAST AS MEMBER_NAME_KANA" _
        & ",MS_OFFICE.SORT_NO" _
        & " FROM MS_OFFICE" _
        & " INNER JOIN MS_MEMBER" _
        & " ON MS_OFFICE.OFFICE=MS_MEMBER.OFFICE"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_OFFICE.SORT_NO" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_FIRST" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_LAST" _
        & ",MS_MEMBER.MEMBER_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byMEMBER_ID(ByVal MEMBER_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_MEMBER.MEMBER_ID='" & CmnDb.SqlString(MEMBER_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Login(ByVal MEMBER_ID As String, ByVal MEMBER_PW As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_MEMBER.MEMBER_ID='" & CmnDb.SqlString(MEMBER_ID) & "'"
            strSQL &= " AND MS_MEMBER.MEMBER_PW='" & CmnDb.SqlString(MEMBER_PW) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE 1=1"

            If Trim(Joken.MEMBER_ID) <> "" Then
                strSQL &= " AND MS_MEMBER.MEMBER_ID='" & CmnDb.SqlString(Joken.MEMBER_ID) & "'"
            End If

            If Trim(Joken.MEMBER_NAME) <> "" Then
                strSQL &= " AND (" _
                        & "      MS_MEMBER.MEMBER_NAME_FIRST LIKE '" & CmnDb.SqlString(Joken.MEMBER_NAME) & "%'" _
                        & "      OR " _
                        & "      MS_MEMBER.MEMBER_NAME_KANA_FIRST LIKE '" & CmnDb.SqlString(Joken.MEMBER_NAME) & "%'" _
                        & ")"
            End If

            If Trim(Joken.OFFICE) <> "" Then
                strSQL &= " AND (MS_MEMBER.OFFICE='" & CmnDb.SqlString(Joken.OFFICE) & "')"
            End If

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function PasswordRemain(ByVal PC_MAIL As String, ByVal MEMBER_NAME_FIRST As String, ByVal MEMBER_NAME_LAST As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_MEMBER.PC_MAIL='" & CmnDb.SqlString(PC_MAIL) & "'"
            strSQL &= " AND (" _
                   & "      MS_MEMBER.MEMBER_NAME_FIRST='" & CmnDb.SqlString(MEMBER_NAME_FIRST) & "'" _
                   & "      OR " _
                   & "      MS_MEMBER.MEMBER_NAME_KANA_FIRST='" & CmnDb.SqlString(MEMBER_NAME_FIRST) & "'" _
                   & ")"
            strSQL &= " AND (" _
                 & "      MS_MEMBER.MEMBER_NAME_LAST='" & CmnDb.SqlString(MEMBER_NAME_LAST) & "'" _
                 & "      OR " _
                 & "      MS_MEMBER.MEMBER_NAME_KANA_LAST='" & CmnDb.SqlString(MEMBER_NAME_LAST) & "'" _
                 & ")"

            Return strSQL
        End Function

        '登録
        Public Shared Function Insert(ByVal MS_MEMBER As TableDef.MS_MEMBER.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_MEMBER.MEMBER_ID) = "" OrElse Trim(MS_MEMBER.MEMBER_NAME_FIRST) = "" OrElse Trim(MS_MEMBER.OFFICE) = "" Then
                strSQL = "ERROR! MS_MEMBER.INSERT"
            Else
                strSQL = "INSERT INTO MS_MEMBER"
                strSQL &= "(" & TableDef.MS_MEMBER.Column.MEMBER_ID
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_PW
                strSQL &= "," & TableDef.MS_MEMBER.Column.LOGIN_FLAG
                strSQL &= "," & TableDef.MS_MEMBER.Column.UPD_DATE
                strSQL &= "," & TableDef.MS_MEMBER.Column.UPD_USER
                strSQL &= "," & TableDef.MS_MEMBER.Column.UPD_PGM
                strSQL &= "," & TableDef.MS_MEMBER.Column.INS_DATE
                strSQL &= "," & TableDef.MS_MEMBER.Column.INS_USER
                strSQL &= "," & TableDef.MS_MEMBER.Column.INS_PGM
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_FIRST
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_LAST
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA_FIRST
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA_LAST
                strSQL &= "," & TableDef.MS_MEMBER.Column.OFFICE
                strSQL &= "," & TableDef.MS_MEMBER.Column.ZIP
                strSQL &= "," & TableDef.MS_MEMBER.Column.ADDRESS
                strSQL &= "," & TableDef.MS_MEMBER.Column.TEL
                strSQL &= "," & TableDef.MS_MEMBER.Column.FAX
                strSQL &= "," & TableDef.MS_MEMBER.Column.KEITAI
                strSQL &= "," & TableDef.MS_MEMBER.Column.PC_MAIL
                strSQL &= "," & TableDef.MS_MEMBER.Column.KEITAI_MAIL
                strSQL &= "," & TableDef.MS_MEMBER.Column.SEX
                strSQL &= "," & TableDef.MS_MEMBER.Column.AGE
                strSQL &= "," & TableDef.MS_MEMBER.Column.ATTEND
                strSQL &= ")"
                strSQL &= " VALUES"
                strSQL &= "('" & CmnDb.SqlString(MS_MEMBER.MEMBER_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.MEMBER_PW) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.LOGIN_FLAG) & "'"
                strSQL &= ",'" & GetValue.DATE() & "'"
                strSQL &= ",'" & GetValue.USER() & "'"
                strSQL &= ",'" & GetValue.PGM() & "'"
                strSQL &= ",'" & GetValue.DATE() & "'"
                strSQL &= ",'" & GetValue.USER() & "'"
                strSQL &= ",'" & GetValue.PGM() & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_FIRST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_LAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_KANA_FIRST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_KANA_LAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.OFFICE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.ZIP) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.ADDRESS) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.TEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.FAX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.KEITAI) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.PC_MAIL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.KEITAI_MAIL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.SEX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.AGE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_MEMBER.ATTEND) & "'"
                strSQL &= ")"
            End If

            Return strSQL
        End Function

        '更新
        Public Shared Function Update(ByVal MS_MEMBER As TableDef.MS_MEMBER.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_MEMBER.MEMBER_ID) = "" OrElse Trim(MS_MEMBER.MEMBER_NAME_FIRST) = "" OrElse Trim(MS_MEMBER.OFFICE) = "" Then
                strSQL = "ERROR! MS_MEMBER.UPDATE"
            Else
                strSQL = "UPDATE MS_MEMBER SET"
                strSQL &= " " & TableDef.MS_MEMBER.Column.MEMBER_PW & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_PW) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.LOGIN_FLAG & "='" & CmnDb.SqlString(MS_MEMBER.LOGIN_FLAG) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.UPD_DATE & "='" & GetValue.DATE() & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.UPD_USER & "='" & GetValue.USER() & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.UPD_PGM & "='" & GetValue.PGM() & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_FIRST & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_FIRST) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_LAST & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_LAST) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA_FIRST & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_KANA_FIRST) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.MEMBER_NAME_KANA_LAST & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME_KANA_LAST) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.OFFICE & "='" & CmnDb.SqlString(MS_MEMBER.OFFICE) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.ZIP & "='" & CmnDb.SqlString(MS_MEMBER.ZIP) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.ADDRESS & "='" & CmnDb.SqlString(MS_MEMBER.ADDRESS) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.TEL & "='" & CmnDb.SqlString(MS_MEMBER.TEL) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.FAX & "='" & CmnDb.SqlString(MS_MEMBER.FAX) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.KEITAI & "='" & CmnDb.SqlString(MS_MEMBER.KEITAI) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.PC_MAIL & "='" & CmnDb.SqlString(MS_MEMBER.PC_MAIL) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.KEITAI_MAIL & "='" & CmnDb.SqlString(MS_MEMBER.KEITAI_MAIL) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.SEX & "='" & CmnDb.SqlString(MS_MEMBER.SEX) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.AGE & "='" & CmnDb.SqlString(MS_MEMBER.AGE) & "'"
                strSQL &= "," & TableDef.MS_MEMBER.Column.ATTEND & "='" & CmnDb.SqlString(MS_MEMBER.ATTEND) & "'"
                strSQL &= " WHERE " & TableDef.MS_MEMBER.Column.MEMBER_ID & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_ID) & "'"
            End If

            Return strSQL
        End Function

    End Class

    Public Class TBL_DR

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_DR.*" _
        & ",TBL_DR.RECORD_KUBUN AS NEW_RECORD_KUBUN" _
        & ",TBL_DR.STATUS_TEHAI AS NEW_STATUS_TEHAI" _
        & ",TBL_DR.STATUS_PAYMENT AS NEW_STATUS_PAYMENT" _
        & ",TBL_DR.DR_NAME_FIRST + ' ' + TBL_DR.DR_NAME_LAST AS DR_NAME" _
        & ",TBL_DR.DR_NAME_KANA_FIRST + ' ' + TBL_DR.DR_NAME_KANA_LAST AS DR_NAME_KANA" _
        & ",MS_MEMBER.MEMBER_NAME_FIRST" _
        & ",MS_MEMBER.MEMBER_NAME_LAST" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_FIRST" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_LAST" _
        & ",MS_MEMBER.MEMBER_NAME_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_LAST AS MEMBER_NAME" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_KANA_LAST AS MEMBER_NAME_KANA" _
        & ",MS_MEMBER.OFFICE" _
        & ",MS_MEMBER.ZIP" _
        & ",MS_MEMBER.ADDRESS" _
        & ",MS_MEMBER.TEL" _
        & ",MS_MEMBER.FAX" _
        & ",MS_MEMBER.KEITAI" _
        & ",MS_MEMBER.PC_MAIL" _
        & ",MS_MEMBER.KEITAI_MAIL" _
        & ",MS_OFFICE.SORT_NO" _
        & " FROM (MS_MEMBER" _
        & " INNER JOIN MS_OFFICE" _
        & " ON MS_MEMBER.OFFICE=MS_OFFICE.OFFICE)" _
        & " INNER JOIN TBL_DR" _
        & " ON MS_MEMBER.MEMBER_ID=TBL_DR.MEMBER_ID"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_DR.DATA_NO"

        Public Shared Function CsvAll() As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " '1' AS HIS_KUBUN"
            strSQL &= ",TBL_DR_HIS.DATA_NO AS DATANO"
            strSQL &= ",SUBSTRING(TBL_DR_HIS.UPD_DATE,1,14) AS UPDDATE"
            strSQL &= ",TBL_DR_HIS.*"
            strSQL &= ",TBL_DR_HIS.DR_NAME_FIRST + ' ' + TBL_DR_HIS.DR_NAME_LAST AS DR_NAME"
            strSQL &= ",TBL_DR_HIS.DR_NAME_KANA_FIRST + ' ' + TBL_DR_HIS.DR_NAME_KANA_LAST AS DR_NAME_KANA"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_FIRST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_LAST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_KANA_FIRST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_KANA_LAST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_LAST AS MEMBER_NAME"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_KANA_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_KANA_LAST AS MEMBER_NAME_KANA"
            strSQL &= ",MS_MEMBER.OFFICE"
            strSQL &= ",MS_MEMBER.ZIP"
            strSQL &= ",MS_MEMBER.ADDRESS"
            strSQL &= ",MS_MEMBER.TEL"
            strSQL &= ",MS_MEMBER.FAX"
            strSQL &= ",MS_MEMBER.KEITAI"
            strSQL &= ",MS_MEMBER.PC_MAIL"
            strSQL &= ",MS_MEMBER.KEITAI_MAIL"
            strSQL &= ",MS_OFFICE.SORT_NO"
            strSQL &= " FROM (MS_MEMBER"
            strSQL &= " INNER JOIN MS_OFFICE"
            strSQL &= " ON MS_MEMBER.OFFICE=MS_OFFICE.OFFICE)"
            strSQL &= " INNER JOIN TBL_DR_HIS"
            strSQL &= " ON MS_MEMBER.MEMBER_ID=TBL_DR_HIS.MEMBER_ID"
            strSQL &= " UNION ALL "
            strSQL &= "SELECT"
            strSQL &= " '2' AS HIS_KUBUN"
            strSQL &= ",TBL_DR.DATA_NO AS DATANO"
            strSQL &= ",SUBSTRING(TBL_DR.UPD_DATE,1,14) AS UPDDATE"
            strSQL &= ",TBL_DR.*"
            strSQL &= ",TBL_DR.DR_NAME_FIRST + ' ' + TBL_DR.DR_NAME_LAST AS DR_NAME"
            strSQL &= ",TBL_DR.DR_NAME_KANA_FIRST + ' ' + TBL_DR.DR_NAME_KANA_LAST AS DR_NAME_KANA"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_FIRST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_LAST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_KANA_FIRST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_KANA_LAST"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_LAST AS MEMBER_NAME"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_KANA_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_KANA_LAST AS MEMBER_NAME_KANA"
            strSQL &= ",MS_MEMBER.OFFICE"
            strSQL &= ",MS_MEMBER.ZIP"
            strSQL &= ",MS_MEMBER.ADDRESS"
            strSQL &= ",MS_MEMBER.TEL"
            strSQL &= ",MS_MEMBER.FAX"
            strSQL &= ",MS_MEMBER.KEITAI"
            strSQL &= ",MS_MEMBER.PC_MAIL"
            strSQL &= ",MS_MEMBER.KEITAI_MAIL"
            strSQL &= ",MS_OFFICE.SORT_NO"
            strSQL &= " FROM (MS_MEMBER"
            strSQL &= " INNER JOIN MS_OFFICE"
            strSQL &= " ON MS_MEMBER.OFFICE=MS_OFFICE.OFFICE)"
            strSQL &= " INNER JOIN TBL_DR"
            strSQL &= " ON MS_MEMBER.MEMBER_ID=TBL_DR.MEMBER_ID"
            strSQL &= " ORDER BY DATANO"
            strSQL &= ",HIS_KUBUN"
            strSQL &= ",UPDDATE"

            Return strSQL
        End Function

        Public Shared Function byDATA_NO(ByVal DATA_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.DATA_NO='" & CmnDb.SqlString(DATA_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_NO_DR_ID(ByVal DATA_NO As String, ByVal DR_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.DATA_NO='" & CmnDb.SqlString(DATA_NO) & "'"
            strSQL &= " AND TBL_DR.DR_ID='" & CmnDb.SqlString(DR_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_NO_MEMBER_ID(ByVal DATA_NO As String, ByVal MEMBER_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.DATA_NO='" & CmnDb.SqlString(DATA_NO) & "'"
            strSQL &= " AND TBL_DR.MEMBER_ID='" & CmnDb.SqlString(MEMBER_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDR_ID(ByVal DR_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.DR_ID='" & CmnDb.SqlString(DR_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byMEMBER_ID(ByVal MEMBER_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.MEMBER_ID='" & CmnDb.SqlString(MEMBER_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byOFFICE(ByVal OFFICE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_MEMBER.OFFICE='" & CmnDb.SqlString(OFFICE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byACCESS_ID(ByVal ACCESS_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.ACCESS_ID='" & CmnDb.SqlString(ACCESS_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function TehaiList(ByVal TehaiListJoken As String, ByVal TehaiListTicketJoken As String) As String
            Dim strSQL As String = SQL_SELECT
            strSQL &= " WHERE 1=1"

            strSQL &= " AND TBL_DR.STATUS_TEHAI IN ("
            Select Case TehaiListJoken
                Case "1"
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.Input & "'"
                    'strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.Change & "'"
                Case "2"
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.HotelNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.KotsuNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG & "'"
                Case "3"
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.HotelOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.KotsuOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK & "'"
                Case "4"
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.OKToFuyo & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.OkToChange & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.OKToCancel & "'"
                Case "5"
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.EndToFuyo & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.EndToChange & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.EndToCancel & "'"
                Case "6"
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.Fuyo & "'"
                Case Else
                    strSQL &= " '" & AppConst.STATUS_TEHAI.Code.Fuyo & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.Input & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.Change & "'"
                    'strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.Cancel & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.KotsuNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.KotsuOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.OKToFuyo & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.OkToChange & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.OKToCancel & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.EndToFuyo & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.EndToChange & "'"
                    strSQL &= ",'" & AppConst.STATUS_TEHAI.Code.EndToCancel & "'"
                    System.Web.HttpContext.Current.Session.Item(SessionDef.TehaiListJoken) = ""
            End Select
            strSQL &= ")"

            Select Case TehaiListTicketJoken
                Case "0"
                    strSQL &= " AND (TBL_DR.TICKET_FLAG = ''"
                    strSQL &= " OR TBL_DR.TICKET_FLAG IS NULL"
                    strSQL &= " OR TBL_DR.TICKET_FLAG='0')"
                Case "1"
                    strSQL &= " AND TBL_DR.TICKET_FLAG = '1'"
            End Select

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function SankaData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.RECORD_KUBUN<>'" & AppConst.RECORD_KUBUN.Code.Cancel & "'"

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function SankaData(ByVal OFFICE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.RECORD_KUBUN<>'" & AppConst.RECORD_KUBUN.Code.Cancel & "'"
            strSQL &= " AND MS_MEMBER.OFFICE='" & CmnDb.SqlString(OFFICE) & "'"

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function CancelData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.RECORD_KUBUN='" & AppConst.RECORD_KUBUN.Code.Cancel & "'"

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function CancelData(ByVal OFFICE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.RECORD_KUBUN='" & AppConst.RECORD_KUBUN.Code.Cancel & "'"
            strSQL &= " AND MS_MEMBER.OFFICE='" & CmnDb.SqlString(OFFICE) & "'"

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function WetLab(ByVal WETLAB_COURSE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.RECORD_KUBUN<>'" & AppConst.RECORD_KUBUN.Code.Cancel & "'"
            strSQL &= " AND TBL_DR.WETLAB_FLAG='" & AppConst.WETLAB_FLAG.Code.Yes & "'"
            strSQL &= " AND TBL_DR.WETLAB_COURSE='" & CmnDb.SqlString(WETLAB_COURSE) & "'"

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byMEMBER_ID_SEND_SAKI(ByVal MEMBER_ID As String, ByVal SEND_SAKI As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " TBL_DR.*"
            strSQL &= " FROM TBL_DR"
            strSQL &= " WHERE TBL_DR.MEMBER_ID='" & CmnDb.SqlString(MEMBER_ID) & "'"
            strSQL &= " AND TBL_DR.SEND_SAKI='" & AppConst.SEND_SAKI.Code.MemberOffice & "'"

            Return strSQL
        End Function

        Public Shared Function PayList(ByVal Joken As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.STATUS_PAYMENT IN("
            If Joken = "1" Then     '完了                strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.BillEnd & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.CardEnd & "'"
            ElseIf Joken = "2" Then '完了後変更依頼
                strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.EndToFuyo & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToChange & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToCancel & "'"
            ElseIf Joken = "3" Then '手配済                strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.OK & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.BillPrint & "'"
            ElseIf Joken = "4" Then '手配済後変更依頼
                strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.OKToFuyo & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OkToChange & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OKToCancel & "'"
            ElseIf Joken = "5" Then '決済失敗                strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.EndToNG & "'"
            Else
                strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.BillEnd & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.CardEnd & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToFuyo & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToChange & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToCancel & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OK & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.BillPrint & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OKToFuyo & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OkToChange & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OKToCancel & "'"
                strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToNG & "'"
            End If
            strSQL &= ")"
            strSQL &= " ORDER BY TBL_DR.STATUS_PAYMENT"
            strSQL &= ",TBL_DR.DATA_NO"

            Return strSQL
        End Function

        Public Shared Function UnPaidList() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_DR.STATUS_PAYMENT IN("
            strSQL &= " '" & AppConst.STATUS_PAYMENT.Code.OK & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.BillPrint & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToFuyo & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToChange & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToCancel & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.EndToNG & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OKToFuyo & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OkToChange & "'"
            strSQL &= ",'" & AppConst.STATUS_PAYMENT.Code.OKToCancel & "'"
            strSQL &= ")"
            strSQL &= " ORDER BY TBL_DR.STATUS_PAYMENT"
            strSQL &= ",TBL_DR.DATA_NO"

            Return strSQL
        End Function

        Public Shared Function Search(ByVal Joken As TableDef.Joken.DataStruct) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE 1=1"

            If Trim(Joken.DATA_NO) <> "" Then
                strSQL &= " AND (TBL_DR.DATA_NO='" & CmnDb.SqlString(Joken.DATA_NO) & "')"
            End If

            If Trim(Joken.DR_NAME) <> "" Then
                strSQL &= " AND (" _
                        & "      TBL_DR.DR_NAME_KANA_FIRST LIKE '" & CmnDb.SqlString(Joken.DR_NAME) & "%'" _
                        & "      OR " _
                        & "      TBL_DR.DR_NAME_FIRST LIKE '" & CmnDb.SqlString(Joken.DR_NAME) & "%'" _
                        & ")"
            End If

            If Trim(Joken.SHISETSU_NAME) <> "" Then
                strSQL &= " AND (" _
                        & "      TBL_DR.SHISETSU_NAME_KANA LIKE '%" & CmnDb.SqlString(Joken.SHISETSU_NAME) & "%'" _
                        & "      OR " _
                        & "      TBL_DR.SHISETSU_NAME LIKE '%" & CmnDb.SqlString(Joken.SHISETSU_NAME) & "%'" _
                        & ")"
            End If

            If Trim(Joken.MEMBER_NAME) <> "" Then
                strSQL &= " AND (" _
                        & "      MS_MEMBER.MEMBER_NAME_KANA_FIRST LIKE '" & CmnDb.SqlString(Joken.MEMBER_NAME) & "%'" _
                        & "      OR " _
                        & "      MS_MEMBER.MEMBER_NAME_FIRST LIKE '" & CmnDb.SqlString(Joken.MEMBER_NAME) & "%'" _
                        & ")"
            End If

            If Trim(Joken.OFFICE) <> "" Then
                strSQL &= " AND (MS_MEMBER.OFFICE='" & CmnDb.SqlString(Joken.OFFICE) & "')"
            End If

            If Trim(Joken.RECORD_KUBUN) <> "" Then
                strSQL &= " AND (TBL_DR.RECORD_KUBUN='" & AppConst.RECORD_KUBUN.Code.Cancel & "')"
            End If

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        '最大請求書番号
        Public Shared Function MaxBILL_NO() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT MAX(CONVERT(INT,BILL_NO)) AS BILL_NO"
            strSQL &= " FROM TBL_DR"
            Return strSQL
        End Function

        '最大登録番号
        Public Shared Function MaxDATA_NO() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT MAX(SUBSTRING(DATA_NO," & CmnModule.LenB(AppConst.DATA_NO.Head) + 1.ToString & "," & AppConst.DATA_NO.NumberLength & ")) AS DATA_NO"
            strSQL &= " FROM TBL_DR"
            Return strSQL
        End Function

        '登録
        Public Shared Function Insert(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.RECORD_KUBUN) = "" Then
                strSQL = "ERROR! TBL_DR.INSERT"
            Else
                strSQL = "INSERT INTO TBL_DR"
                strSQL &= "(" & TableDef.TBL_DR.Column.DATA_NO
                strSQL &= "," & TableDef.TBL_DR.Column.MEMBER_ID
                strSQL &= "," & TableDef.TBL_DR.Column.DR_ID
                strSQL &= "," & TableDef.TBL_DR.Column.RECORD_KUBUN
                strSQL &= "," & TableDef.TBL_DR.Column.STATUS_TEHAI
                strSQL &= "," & TableDef.TBL_DR.Column.STATUS_PAYMENT
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_DATE
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_USER
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_PGM
                strSQL &= "," & TableDef.TBL_DR.Column.INS_DATE
                strSQL &= "," & TableDef.TBL_DR.Column.INS_USER
                strSQL &= "," & TableDef.TBL_DR.Column.INS_PGM
                strSQL &= "," & TableDef.TBL_DR.Column.INS_TYPE
                strSQL &= "," & TableDef.TBL_DR.Column.DR_MAIL
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_FIRST
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_LAST
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_KANA_FIRST
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_KANA_LAST
                strSQL &= "," & TableDef.TBL_DR.Column.PREFECTURES_NO
                strSQL &= "," & TableDef.TBL_DR.Column.SHISETSU_NAME
                strSQL &= "," & TableDef.TBL_DR.Column.SHISETSU_NAME_KANA
                strSQL &= "," & TableDef.TBL_DR.Column.KAMOKU
                strSQL &= "," & TableDef.TBL_DR.Column.YAKUSHOKU
                strSQL &= "," & TableDef.TBL_DR.Column.SEX
                strSQL &= "," & TableDef.TBL_DR.Column.AGE
                strSQL &= "," & TableDef.TBL_DR.Column.PARTY
                strSQL &= "," & TableDef.TBL_DR.Column.WETLAB_FLAG
                strSQL &= "," & TableDef.TBL_DR.Column.WETLAB_COURSE
                strSQL &= "," & TableDef.TBL_DR.Column.SANKA_KUBUN
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAI_HOTEL
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_NO
                strSQL &= "," & TableDef.TBL_DR.Column.ROOM_RATE
                strSQL &= "," & TableDef.TBL_DR.Column.STAY_DATE
                strSQL &= "," & TableDef.TBL_DR.Column.CHECK_IN
                strSQL &= "," & TableDef.TBL_DR.Column.CHECK_OUT
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_SMOKING
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_NAME
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_ADDRESS
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_TEL
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_FAX
                strSQL &= "," & TableDef.TBL_DR.Column.ROOM_TYPE
                strSQL &= "," & TableDef.TBL_DR.Column.ROOM_SU
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_SHIHARAI
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_CHECKIN
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_RENRAKU
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_CHECKIN_DATE
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_CHECKOUT_DATE
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_SHIHARAI_IDX
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_CHECKIN_IDX
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_RENRAKU_IDX
                strSQL &= "," & TableDef.TBL_DR.Column.NOTE_HOTEL
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAIMAIL_HOTEL
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_FLAG
                strSQL &= "," & TableDef.TBL_DR.Column.NOTE_ACCOMPANY
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_STAY
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_SAME_ROOM
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_STAY_DATE
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHECK_IN
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHECK_OUT
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_ADULT_SU
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SU
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_AGE_1
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_AGE_2
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_BED_1
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_BED_2
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SEX_1
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SEX_2
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_ROOM_RATE
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAI_KOTSU
                strSQL &= "," & TableDef.TBL_DR.Column.KOTSU_NO
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_FARE
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_FARE
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_KUBUN_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_DATE_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_BIN_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT1_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT2_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS1_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS2_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL1_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL2_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME1_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME2_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEAT_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEATCLASS_1
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_KUBUN_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_DATE_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_BIN_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT1_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT2_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS1_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS2_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL1_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL2_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME1_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME2_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEAT_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEATCLASS_2
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_KUBUN_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_DATE_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_BIN_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT1_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT2_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS1_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS2_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL1_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL2_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME1_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME2_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEAT_3
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEATCLASS_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_KUBUN_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_DATE_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_BIN_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT1_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT2_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS1_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS2_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL1_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL2_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME1_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME2_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEAT_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEATCLASS_1
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_KUBUN_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_DATE_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_BIN_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT1_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT2_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS1_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS2_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL1_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL2_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME1_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME2_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEAT_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEATCLASS_2
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_KUBUN_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_DATE_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_BIN_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT1_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT2_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS1_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS2_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL1_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL2_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME1_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME2_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEAT_3
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEATCLASS_3
                strSQL &= "," & TableDef.TBL_DR.Column.AIRLINE
                strSQL &= "," & TableDef.TBL_DR.Column.MILAGE_NO
                strSQL &= "," & TableDef.TBL_DR.Column.NOTE_KOTSU
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAIMAIL_KOTSU
                strSQL &= "," & TableDef.TBL_DR.Column.NOTES
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_SAKI
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_ZIP
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_ADDRESS
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_TEL
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_NAME
                strSQL &= "," & TableDef.TBL_DR.Column.ATTEND_FLAG
                strSQL &= "," & TableDef.TBL_DR.Column.MAIL_FLAG
                strSQL &= "," & TableDef.TBL_DR.Column.ARRIVE_TIME
                strSQL &= "," & TableDef.TBL_DR.Column.TOTAL_AMOUNT
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_1
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_1
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_2
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_2
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_3
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_3
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_4
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_4
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_5
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_5
                strSQL &= "," & TableDef.TBL_DR.Column.REPLY
                strSQL &= "," & TableDef.TBL_DR.Column.REPLY_HOTEL
                strSQL &= "," & TableDef.TBL_DR.Column.REPLY_KOTSU
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_METHOD
                strSQL &= "," & TableDef.TBL_DR.Column.BILL_NO
                strSQL &= "," & TableDef.TBL_DR.Column.BILL_NAME
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_DATE_BANK
                strSQL &= "," & TableDef.TBL_DR.Column.AUTHORIZATION_NO
                strSQL &= "," & TableDef.TBL_DR.Column.TRANSACTION_NO
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_DATE_CARD
                strSQL &= "," & TableDef.TBL_DR.Column.PUBLIC_SERVANT
                strSQL &= "," & TableDef.TBL_DR.Column.SECANDARY_USE
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_ACCOMPANY
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_BREAKFAST
                strSQL &= "," & TableDef.TBL_DR.Column.ACCESS_ID
                strSQL &= "," & TableDef.TBL_DR.Column.ACCESS_PW
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_FLAG
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_SEND_DATE1
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_SEND_DATE2
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI1
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI2
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI3
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI4
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI5
                strSQL &= ")"
                strSQL &= " VALUES"
                strSQL &= "('" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.MEMBER_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.DR_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NEW_RECORD_KUBUN) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NEW_STATUS_TEHAI) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NEW_STATUS_PAYMENT) & "'"
                strSQL &= ",'" & GetValue.DATE() & "'"
                strSQL &= ",'" & GetValue.USER() & "'"
                strSQL &= ",'" & GetValue.PGM() & "'"
                strSQL &= ",'" & GetValue.DATE() & "'"
                strSQL &= ",'" & GetValue.USER() & "'"
                strSQL &= ",'" & GetValue.PGM() & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.INS_TYPE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.DR_MAIL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.DR_NAME_FIRST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.DR_NAME_LAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.DR_NAME_KANA_FIRST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.DR_NAME_KANA_LAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.PREFECTURES_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SHISETSU_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SHISETSU_NAME_KANA) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.KAMOKU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.YAKUSHOKU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SEX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.AGE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.PARTY) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.WETLAB_FLAG) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.WETLAB_COURSE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SANKA_KUBUN) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TEHAI_HOTEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ROOM_RATE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.STAY_DATE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.CHECK_IN) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.CHECK_OUT) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_SMOKING) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_ADDRESS) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_TEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_FAX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ROOM_TYPE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ROOM_SU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_SHIHARAI) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_CHECKIN) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_RENRAKU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_CHECKIN_DATE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTEL_CHECKOUT_DATE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_SHIHARAI_IDX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_CHECKIN_IDX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_RENRAKU_IDX) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NOTE_HOTEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TEHAIMAIL_HOTEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_FLAG) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NOTE_ACCOMPANY) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_STAY) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_SAME_ROOM) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_STAY_DATE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHECK_IN) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHECK_OUT) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_ADULT_SU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_SU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_AGE_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_AGE_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_BED_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_BED_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_SEX_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_SEX_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCOMPANY_ROOM_RATE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TEHAI_KOTSU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.KOTSU_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_KOTSU_FARE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_KOTSU_FARE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_KOTSU_KUBUN_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_DATE_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_BIN_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_AIRPORT1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_AIRPORT2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_EXPRESS1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_EXPRESS2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_LOCAL1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_LOCAL2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_TIME1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_TIME2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_SEAT_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_SEATCLASS_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_KOTSU_KUBUN_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_DATE_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_BIN_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_AIRPORT1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_AIRPORT2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_EXPRESS1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_EXPRESS2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_LOCAL1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_LOCAL2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_TIME1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_TIME2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_SEAT_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_SEATCLASS_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_KOTSU_KUBUN_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_DATE_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_BIN_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_AIRPORT1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_AIRPORT2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_EXPRESS1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_EXPRESS2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_LOCAL1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_LOCAL2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_TIME1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_TIME2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_SEAT_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.O_SEATCLASS_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_KOTSU_KUBUN_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_DATE_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_BIN_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_AIRPORT1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_AIRPORT2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_EXPRESS1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_EXPRESS2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_LOCAL1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_LOCAL2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_TIME1_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_TIME2_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_SEAT_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_SEATCLASS_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_KOTSU_KUBUN_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_DATE_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_BIN_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_AIRPORT1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_AIRPORT2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_EXPRESS1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_EXPRESS2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_LOCAL1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_LOCAL2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_TIME1_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_TIME2_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_SEAT_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_SEATCLASS_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_KOTSU_KUBUN_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_DATE_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_BIN_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_AIRPORT1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_AIRPORT2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_EXPRESS1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_EXPRESS2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_LOCAL1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_LOCAL2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_TIME1_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_TIME2_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_SEAT_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.F_SEATCLASS_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.AIRLINE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.MILAGE_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NOTE_KOTSU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TEHAIMAIL_KOTSU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.NOTES) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SEND_SAKI) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SEND_ZIP) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SEND_ADDRESS) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SEND_TEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SEND_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ATTEND_FLAG) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.MAIL_FLAG) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ARRIVE_TIME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TOTAL_AMOUNT) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_4) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_4) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_5) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SAGAKU_5) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.REPLY) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.REPLY_HOTEL) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.REPLY_KOTSU) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.PAYMENT_METHOD) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.BILL_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.BILL_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.PAYMENT_DATE_BANK) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.AUTHORIZATION_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TRANSACTION_NO) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.PAYMENT_DATE_CARD) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.PUBLIC_SERVANT) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.SECANDARY_USE) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_ACCOMPANY) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.HOTELPRINT_BREAKFAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCESS_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.ACCESS_PW) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TICKET_FLAG) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TICKET_SEND_DATE1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.TICKET_SEND_DATE2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.YOBI1) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.YOBI2) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.YOBI3) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.YOBI4) & "'"
                strSQL &= ",'" & CmnDb.SqlString(TBL_DR.YOBI5) & "'"
                strSQL &= ")"
            End If

            Return strSQL
        End Function

        '更新
        Public Shared Function Update(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.RECORD_KUBUN) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.RECORD_KUBUN & "='" & CmnDb.SqlString(TBL_DR.NEW_RECORD_KUBUN) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.STATUS_TEHAI & "='" & CmnDb.SqlString(TBL_DR.NEW_STATUS_TEHAI) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.STATUS_PAYMENT & "='" & CmnDb.SqlString(TBL_DR.NEW_STATUS_PAYMENT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_DATE & "='" & GetValue.DATE() & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_USER & "='" & GetValue.USER() & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_PGM & "='" & GetValue.PGM() & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.DR_MAIL & "='" & CmnDb.SqlString(TBL_DR.DR_MAIL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_FIRST & "='" & CmnDb.SqlString(TBL_DR.DR_NAME_FIRST) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_LAST & "='" & CmnDb.SqlString(TBL_DR.DR_NAME_LAST) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_KANA_FIRST & "='" & CmnDb.SqlString(TBL_DR.DR_NAME_KANA_FIRST) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.DR_NAME_KANA_LAST & "='" & CmnDb.SqlString(TBL_DR.DR_NAME_KANA_LAST) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PREFECTURES_NO & "='" & CmnDb.SqlString(TBL_DR.PREFECTURES_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SHISETSU_NAME & "='" & CmnDb.SqlString(TBL_DR.SHISETSU_NAME) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SHISETSU_NAME_KANA & "='" & CmnDb.SqlString(TBL_DR.SHISETSU_NAME_KANA) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.KAMOKU & "='" & CmnDb.SqlString(TBL_DR.KAMOKU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.YAKUSHOKU & "='" & CmnDb.SqlString(TBL_DR.YAKUSHOKU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEX & "='" & CmnDb.SqlString(TBL_DR.SEX) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.AGE & "='" & CmnDb.SqlString(TBL_DR.AGE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PARTY & "='" & CmnDb.SqlString(TBL_DR.PARTY) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.WETLAB_FLAG & "='" & CmnDb.SqlString(TBL_DR.WETLAB_FLAG) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.WETLAB_COURSE & "='" & CmnDb.SqlString(TBL_DR.WETLAB_COURSE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SANKA_KUBUN & "='" & CmnDb.SqlString(TBL_DR.SANKA_KUBUN) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAI_HOTEL & "='" & CmnDb.SqlString(TBL_DR.TEHAI_HOTEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_NO & "='" & CmnDb.SqlString(TBL_DR.HOTEL_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ROOM_RATE & "='" & CmnDb.SqlString(TBL_DR.ROOM_RATE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.STAY_DATE & "='" & CmnDb.SqlString(TBL_DR.STAY_DATE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.CHECK_IN & "='" & CmnDb.SqlString(TBL_DR.CHECK_IN) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.CHECK_OUT & "='" & CmnDb.SqlString(TBL_DR.CHECK_OUT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_SMOKING & "='" & CmnDb.SqlString(TBL_DR.HOTEL_SMOKING) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_NAME & "='" & CmnDb.SqlString(TBL_DR.HOTEL_NAME) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_ADDRESS & "='" & CmnDb.SqlString(TBL_DR.HOTEL_ADDRESS) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_TEL & "='" & CmnDb.SqlString(TBL_DR.HOTEL_TEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_FAX & "='" & CmnDb.SqlString(TBL_DR.HOTEL_FAX) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ROOM_TYPE & "='" & CmnDb.SqlString(TBL_DR.ROOM_TYPE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ROOM_SU & "='" & CmnDb.SqlString(TBL_DR.ROOM_SU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_SHIHARAI & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_SHIHARAI) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_CHECKIN & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_CHECKIN) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_RENRAKU & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_RENRAKU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_CHECKIN_DATE & "='" & CmnDb.SqlString(TBL_DR.HOTEL_CHECKIN_DATE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTEL_CHECKOUT_DATE & "='" & CmnDb.SqlString(TBL_DR.HOTEL_CHECKOUT_DATE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_SHIHARAI_IDX & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_SHIHARAI_IDX) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_CHECKIN_IDX & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_CHECKIN_IDX) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_RENRAKU_IDX & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_RENRAKU_IDX) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.NOTE_HOTEL & "='" & CmnDb.SqlString(TBL_DR.NOTE_HOTEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAIMAIL_HOTEL & "='" & CmnDb.SqlString(TBL_DR.TEHAIMAIL_HOTEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_FLAG & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_FLAG) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.NOTE_ACCOMPANY & "='" & CmnDb.SqlString(TBL_DR.NOTE_ACCOMPANY) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_STAY & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_STAY) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_SAME_ROOM & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_SAME_ROOM) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_STAY_DATE & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_STAY_DATE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHECK_IN & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHECK_IN) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHECK_OUT & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHECK_OUT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_ADULT_SU & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_ADULT_SU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SU & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_SU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_AGE_1 & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_AGE_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_AGE_2 & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_AGE_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_BED_1 & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_BED_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_BED_2 & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_BED_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SEX_1 & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_SEX_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_CHILD_SEX_2 & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_CHILD_SEX_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCOMPANY_ROOM_RATE & "='" & CmnDb.SqlString(TBL_DR.ACCOMPANY_ROOM_RATE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAI_KOTSU & "='" & CmnDb.SqlString(TBL_DR.TEHAI_KOTSU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.KOTSU_NO & "='" & CmnDb.SqlString(TBL_DR.KOTSU_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_FARE & "='" & CmnDb.SqlString(TBL_DR.O_KOTSU_FARE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_FARE & "='" & CmnDb.SqlString(TBL_DR.F_KOTSU_FARE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_KUBUN_1 & "='" & CmnDb.SqlString(TBL_DR.O_KOTSU_KUBUN_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_DATE_1 & "='" & CmnDb.SqlString(TBL_DR.O_DATE_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_BIN_1 & "='" & CmnDb.SqlString(TBL_DR.O_BIN_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_DR.O_AIRPORT1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_DR.O_AIRPORT2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL1_1 & "='" & CmnDb.SqlString(TBL_DR.O_LOCAL1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL2_1 & "='" & CmnDb.SqlString(TBL_DR.O_LOCAL2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS1_1 & "='" & CmnDb.SqlString(TBL_DR.O_EXPRESS1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS2_1 & "='" & CmnDb.SqlString(TBL_DR.O_EXPRESS2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME1_1 & "='" & CmnDb.SqlString(TBL_DR.O_TIME1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME2_1 & "='" & CmnDb.SqlString(TBL_DR.O_TIME2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEAT_1 & "='" & CmnDb.SqlString(TBL_DR.O_SEAT_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEATCLASS_1 & "='" & CmnDb.SqlString(TBL_DR.O_SEATCLASS_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_KUBUN_2 & "='" & CmnDb.SqlString(TBL_DR.O_KOTSU_KUBUN_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_DATE_2 & "='" & CmnDb.SqlString(TBL_DR.O_DATE_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_BIN_2 & "='" & CmnDb.SqlString(TBL_DR.O_BIN_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_DR.O_AIRPORT1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_DR.O_AIRPORT2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL1_2 & "='" & CmnDb.SqlString(TBL_DR.O_LOCAL1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL2_2 & "='" & CmnDb.SqlString(TBL_DR.O_LOCAL2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS1_2 & "='" & CmnDb.SqlString(TBL_DR.O_EXPRESS1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS2_2 & "='" & CmnDb.SqlString(TBL_DR.O_EXPRESS2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME1_2 & "='" & CmnDb.SqlString(TBL_DR.O_TIME1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME2_2 & "='" & CmnDb.SqlString(TBL_DR.O_TIME2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEAT_2 & "='" & CmnDb.SqlString(TBL_DR.O_SEAT_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEATCLASS_2 & "='" & CmnDb.SqlString(TBL_DR.O_SEATCLASS_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_KOTSU_KUBUN_3 & "='" & CmnDb.SqlString(TBL_DR.O_KOTSU_KUBUN_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_DATE_3 & "='" & CmnDb.SqlString(TBL_DR.O_DATE_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_BIN_3 & "='" & CmnDb.SqlString(TBL_DR.O_BIN_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_DR.O_AIRPORT1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_DR.O_AIRPORT2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL1_3 & "='" & CmnDb.SqlString(TBL_DR.O_LOCAL1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_LOCAL2_3 & "='" & CmnDb.SqlString(TBL_DR.O_LOCAL2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS1_3 & "='" & CmnDb.SqlString(TBL_DR.O_EXPRESS1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_EXPRESS2_3 & "='" & CmnDb.SqlString(TBL_DR.O_EXPRESS2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME1_3 & "='" & CmnDb.SqlString(TBL_DR.O_TIME1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_TIME2_3 & "='" & CmnDb.SqlString(TBL_DR.O_TIME2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEAT_3 & "='" & CmnDb.SqlString(TBL_DR.O_SEAT_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.O_SEATCLASS_3 & "='" & CmnDb.SqlString(TBL_DR.O_SEATCLASS_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_KUBUN_1 & "='" & CmnDb.SqlString(TBL_DR.F_KOTSU_KUBUN_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_DATE_1 & "='" & CmnDb.SqlString(TBL_DR.F_DATE_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_BIN_1 & "='" & CmnDb.SqlString(TBL_DR.F_BIN_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT1_1 & "='" & CmnDb.SqlString(TBL_DR.F_AIRPORT1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT2_1 & "='" & CmnDb.SqlString(TBL_DR.F_AIRPORT2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL1_1 & "='" & CmnDb.SqlString(TBL_DR.F_LOCAL1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL2_1 & "='" & CmnDb.SqlString(TBL_DR.F_LOCAL2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS1_1 & "='" & CmnDb.SqlString(TBL_DR.F_EXPRESS1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS2_1 & "='" & CmnDb.SqlString(TBL_DR.F_EXPRESS2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME1_1 & "='" & CmnDb.SqlString(TBL_DR.F_TIME1_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME2_1 & "='" & CmnDb.SqlString(TBL_DR.F_TIME2_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEAT_1 & "='" & CmnDb.SqlString(TBL_DR.F_SEAT_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEATCLASS_1 & "='" & CmnDb.SqlString(TBL_DR.F_SEATCLASS_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_KUBUN_2 & "='" & CmnDb.SqlString(TBL_DR.F_KOTSU_KUBUN_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_DATE_2 & "='" & CmnDb.SqlString(TBL_DR.F_DATE_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_BIN_2 & "='" & CmnDb.SqlString(TBL_DR.F_BIN_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT1_2 & "='" & CmnDb.SqlString(TBL_DR.F_AIRPORT1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT2_2 & "='" & CmnDb.SqlString(TBL_DR.F_AIRPORT2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL1_2 & "='" & CmnDb.SqlString(TBL_DR.F_LOCAL1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL2_2 & "='" & CmnDb.SqlString(TBL_DR.F_LOCAL2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS1_2 & "='" & CmnDb.SqlString(TBL_DR.F_EXPRESS1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS2_2 & "='" & CmnDb.SqlString(TBL_DR.F_EXPRESS2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME1_2 & "='" & CmnDb.SqlString(TBL_DR.F_TIME1_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME2_2 & "='" & CmnDb.SqlString(TBL_DR.F_TIME2_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEAT_2 & "='" & CmnDb.SqlString(TBL_DR.F_SEAT_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEATCLASS_2 & "='" & CmnDb.SqlString(TBL_DR.F_SEATCLASS_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_KOTSU_KUBUN_3 & "='" & CmnDb.SqlString(TBL_DR.F_KOTSU_KUBUN_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_DATE_3 & "='" & CmnDb.SqlString(TBL_DR.F_DATE_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_BIN_3 & "='" & CmnDb.SqlString(TBL_DR.F_BIN_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT1_3 & "='" & CmnDb.SqlString(TBL_DR.F_AIRPORT1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_AIRPORT2_3 & "='" & CmnDb.SqlString(TBL_DR.F_AIRPORT2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL1_3 & "='" & CmnDb.SqlString(TBL_DR.F_LOCAL1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_LOCAL2_3 & "='" & CmnDb.SqlString(TBL_DR.F_LOCAL2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS1_3 & "='" & CmnDb.SqlString(TBL_DR.F_EXPRESS1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_EXPRESS2_3 & "='" & CmnDb.SqlString(TBL_DR.F_EXPRESS2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME1_3 & "='" & CmnDb.SqlString(TBL_DR.F_TIME1_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_TIME2_3 & "='" & CmnDb.SqlString(TBL_DR.F_TIME2_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEAT_3 & "='" & CmnDb.SqlString(TBL_DR.F_SEAT_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.F_SEATCLASS_3 & "='" & CmnDb.SqlString(TBL_DR.F_SEATCLASS_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.AIRLINE & "='" & CmnDb.SqlString(TBL_DR.AIRLINE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.MILAGE_NO & "='" & CmnDb.SqlString(TBL_DR.MILAGE_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.NOTE_KOTSU & "='" & CmnDb.SqlString(TBL_DR.NOTE_KOTSU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TEHAIMAIL_KOTSU & "='" & CmnDb.SqlString(TBL_DR.TEHAIMAIL_KOTSU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.NOTES & "='" & CmnDb.SqlString(TBL_DR.NOTES) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_SAKI & "='" & CmnDb.SqlString(TBL_DR.SEND_SAKI) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_ZIP & "='" & CmnDb.SqlString(TBL_DR.SEND_ZIP) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_ADDRESS & "='" & CmnDb.SqlString(TBL_DR.SEND_ADDRESS) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_TEL & "='" & CmnDb.SqlString(TBL_DR.SEND_TEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_NAME & "='" & CmnDb.SqlString(TBL_DR.SEND_NAME) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ATTEND_FLAG & "='" & CmnDb.SqlString(TBL_DR.ATTEND_FLAG) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.MAIL_FLAG & "='" & CmnDb.SqlString(TBL_DR.MAIL_FLAG) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ARRIVE_TIME & "='" & CmnDb.SqlString(TBL_DR.ARRIVE_TIME) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TOTAL_AMOUNT & "='" & CmnDb.SqlString(TBL_DR.TOTAL_AMOUNT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_1 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_1 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_2 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_2 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_3 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_3 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_4 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_4) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_4 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_4) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_NAME_5 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_NAME_5) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SAGAKU_5 & "='" & CmnDb.SqlString(TBL_DR.SAGAKU_5) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.REPLY & "='" & CmnDb.SqlString(TBL_DR.REPLY) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.REPLY_HOTEL & "='" & CmnDb.SqlString(TBL_DR.REPLY_HOTEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.REPLY_KOTSU & "='" & CmnDb.SqlString(TBL_DR.REPLY_KOTSU) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_METHOD & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_METHOD) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.BILL_NO & "='" & CmnDb.SqlString(TBL_DR.BILL_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.BILL_NAME & "='" & CmnDb.SqlString(TBL_DR.BILL_NAME) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_DATE_BANK & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_DATE_BANK) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.AUTHORIZATION_NO & "='" & CmnDb.SqlString(TBL_DR.AUTHORIZATION_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TRANSACTION_NO & "='" & CmnDb.SqlString(TBL_DR.TRANSACTION_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_DATE_CARD & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_DATE_CARD) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PUBLIC_SERVANT & "='" & CmnDb.SqlString(TBL_DR.PUBLIC_SERVANT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SECANDARY_USE & "='" & CmnDb.SqlString(TBL_DR.SECANDARY_USE) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_ACCOMPANY & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_ACCOMPANY) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.HOTELPRINT_BREAKFAST & "='" & CmnDb.SqlString(TBL_DR.HOTELPRINT_BREAKFAST) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_FLAG & "='" & CmnDb.SqlString(TBL_DR.TICKET_FLAG) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_SEND_DATE1 & "='" & CmnDb.SqlString(TBL_DR.TICKET_SEND_DATE1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_SEND_DATE2 & "='" & CmnDb.SqlString(TBL_DR.TICKET_SEND_DATE2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI1 & "='" & CmnDb.SqlString(TBL_DR.YOBI1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI2 & "='" & CmnDb.SqlString(TBL_DR.YOBI2) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI3 & "='" & CmnDb.SqlString(TBL_DR.YOBI3) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI4 & "='" & CmnDb.SqlString(TBL_DR.YOBI4) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.YOBI5 & "='" & CmnDb.SqlString(TBL_DR.YOBI5) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(請求先名)
        Public Shared Function Update_BILL_NAME(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.BILL_NAME) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_BILL_NAME"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.BILL_NAME & "='" & CmnDb.SqlString(TBL_DR.BILL_NAME) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(請求書番号)
        Public Shared Function Update_BILL_NO(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.BILL_NO) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_BILL_NO"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.BILL_NO & "='" & CmnDb.SqlString(TBL_DR.BILL_NO) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(支払方法)
        Public Shared Function Update_PAYMENT_METHOD(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.PAYMENT_METHOD) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_PAYMENT_METHOD"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.PAYMENT_METHOD & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_METHOD) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(決済状況)
        Public Shared Function Update_STATUS_PAYMENT_BANK(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.RECORD_KUBUN) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_STATUS_PAYMENT"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.STATUS_PAYMENT & "='" & CmnDb.SqlString(TBL_DR.STATUS_PAYMENT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_METHOD & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_METHOD) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_DATE_BANK & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_DATE_BANK) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_DATE & "='" & GetValue.DATE() & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_USER & "='" & GetValue.USER() & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.UPD_PGM & "='" & GetValue.PGM() & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(決済状況)
        Public Shared Function Update_STATUS_PAYMENT_CARD(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.RECORD_KUBUN) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_STATUS_PAYMENT"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.STATUS_PAYMENT & "='" & CmnDb.SqlString(TBL_DR.STATUS_PAYMENT) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_METHOD & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_METHOD) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.PAYMENT_DATE_CARD & "='" & CmnDb.SqlString(TBL_DR.PAYMENT_DATE_CARD) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.AUTHORIZATION_NO & "='" & CmnDb.SqlString(TBL_DR.AUTHORIZATION_NO) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TRANSACTION_NO & "='" & CmnDb.SqlString(TBL_DR.TRANSACTION_NO) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(GMO取引ID)
        Public Shared Function Update_ACCESSID_CARD(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(TBL_DR.DATA_NO) = "" OrElse Trim(TBL_DR.RECORD_KUBUN) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_STATUS_PAYMENT"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.ACCESS_ID & "='" & CmnDb.SqlString(TBL_DR.ACCESS_ID) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.ACCESS_PW & "='" & CmnDb.SqlString(TBL_DR.ACCESS_PW) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_DR.DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(チケット送付先)
        Public Shared Function Update_SEND(ByVal MS_MEMBER As TableDef.MS_MEMBER.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_MEMBER.MEMBER_ID) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_SEND"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.SEND_ZIP & "='" & CmnDb.SqlString(MS_MEMBER.ZIP) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_ADDRESS & "='" & CmnDb.SqlString(MS_MEMBER.ADDRESS) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_TEL & "='" & CmnDb.SqlString(MS_MEMBER.TEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_NAME & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.SEND_SAKI & "='" & AppConst.SEND_SAKI.Code.MemberOffice & "'"
            End If

            Return strSQL
        End Function
        Public Shared Function Update_SEND(ByVal MS_MEMBER As TableDef.MS_MEMBER.DataStruct, ByVal DATA_NO As String) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_MEMBER.MEMBER_ID) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_SEND"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.SEND_ZIP & "='" & CmnDb.SqlString(MS_MEMBER.ZIP) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_ADDRESS & "='" & CmnDb.SqlString(MS_MEMBER.ADDRESS) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_TEL & "='" & CmnDb.SqlString(MS_MEMBER.TEL) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.SEND_NAME & "='" & CmnDb.SqlString(MS_MEMBER.MEMBER_NAME) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.SEND_SAKI & "='" & AppConst.SEND_SAKI.Code.MemberOffice & "'"
                strSQL &= " AND " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(DATA_NO) & "'"
            End If

            Return strSQL
        End Function

        '更新(メールアドレス)
        Public Shared Function Update_DR_MAIL(ByVal DR_ID As String, ByVal DR_MAIL As String) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(DR_ID) = "" OrElse Trim(DR_MAIL) = "" Then
                strSQL = "ERROR! TBL_DR.UPDATE_DR_MAIL"
            Else
                strSQL = "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.DR_MAIL & "='" & CmnDb.SqlString(DR_MAIL) & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DR_ID & "='" & CmnDb.SqlString(DR_ID) & "'"
            End If

            Return strSQL
        End Function

        '更新(チケット発送)
        Public Shared Function Update_TICKET(ByVal DATA_NO As String, ByVal TICKET_SEND_DATE1 As String, ByVal TICKET_SEND_DATE2 As String) As String
            Dim strSQL As String = ""
            Dim wStr As String = ""

            'チェック
            If Trim(DATA_NO) = "" Then
                strSQL &= "ERROR! UPDATE_TICKET"
            Else
                strSQL &= "UPDATE TBL_DR SET"
                strSQL &= " " & TableDef.TBL_DR.Column.TICKET_SEND_DATE1 & "='" & CmnDb.SqlString(TICKET_SEND_DATE1) & "'"
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_SEND_DATE2 & "='" & CmnDb.SqlString(TICKET_SEND_DATE2) & "'"
                If Trim(TICKET_SEND_DATE1) <> "" OrElse Trim(TICKET_SEND_DATE2) <> "" Then
                    wStr = CmnConst.Flag.On
                Else
                    wStr = CmnConst.Flag.Off
                End If
                strSQL &= "," & TableDef.TBL_DR.Column.TICKET_FLAG & "='" & wStr & "'"
                strSQL &= " WHERE " & TableDef.TBL_DR.Column.DATA_NO & "='" & CmnDb.SqlString(DATA_NO) & "'"
            End If

            Return strSQL
        End Function

    End Class

    Public Class TBL_DR_HIS

        '登録
        Public Shared Function Insert(ByVal DATA_NO As String, ByVal UPD_DATE As String) As String
            Dim strSQL As String = ""

            strSQL = "INSERT INTO TBL_DR_HIS"
            strSQL &= " SELECT * FROM TBL_DR"
            strSQL &= " WHERE DATA_NO='" & CmnDb.SqlString(DATA_NO) & "'"

            If Trim(UPD_DATE) <> "" Then
                Dim r As New System.Random()          '初期化
                Dim i1 As Integer = r.Next(0, 99999)  '0以上99999未満の乱数を整数で返す

                strSQL &= ";"
                strSQL &= "UPDATE TBL_DR_HIS SET"
                strSQL &= " UPD_DATE='" & Mid(UPD_DATE, 1, 14) & " " & i1.ToString & "'"
                strSQL &= " WHERE DATA_NO='" & CmnDb.SqlString(DATA_NO) & "'"
                strSQL &= " AND UPD_DATE='" & CmnDb.SqlString(UPD_DATE) & "'"
                strSQL &= ";"
            End If

            Return strSQL
        End Function

    End Class

    Public Class MS_PREFECTURES

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_PREFECTURES.*" _
        & " FROM MS_PREFECTURES"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_PREFECTURES.PREFECTURES_NO"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byPREFECTURES_NO(ByVal PREFECTURES_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_PREFECTURES.PREFECTURES_NO='" & CmnDb.SqlString(PREFECTURES_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_PACKAGE_KOTSU

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_PACKAGE_KOTSU.*" _
        & " FROM MS_PACKAGE_KOTSU"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_PACKAGE_KOTSU.KOTSU_NO"

        Public Shared Function byPREFECTURES_NO(ByVal PREFECTURES_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_PACKAGE_KOTSU.KOTSU_NO='" & CmnDb.SqlString(PREFECTURES_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_PACKAGE_HOTEL

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_PACKAGE_HOTEL.*" _
        & " FROM MS_PACKAGE_HOTEL"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_PACKAGE_HOTEL.HOTEL_NO"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byHOTEL_NO(ByVal HOTEL_NO As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_PACKAGE_HOTEL.HOTEL_NO='" & CmnDb.SqlString(HOTEL_NO) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byCHECKIN_DATE(ByVal CHECKIN_DATE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_PACKAGE_HOTEL.CHECKIN_DATE='" & CmnDb.SqlString(CHECKIN_DATE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_DR

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_DR.*" _
        & ",MS_DR.DR_NAME_FIRST + ' ' + MS_DR.DR_NAME_LAST AS DR_NAME" _
        & ",MS_DR.DR_NAME_KANA_FIRST + ' ' + MS_DR.DR_NAME_KANA_LAST AS DR_NAME_KANA" _
        & ",MS_MEMBER.MEMBER_NAME_KANA_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_KANA_LAST AS MEMBER_NAME_KANA" _
        & ",MS_MEMBER.PC_MAIL" _
        & ",MS_MEMBER.OFFICE" _
        & ",MS_MEMBER.ZIP" _
        & ",MS_MEMBER.ADDRESS" _
        & ",MS_MEMBER.TEL" _
        & ",MS_MEMBER.FAX" _
        & ",MS_OFFICE.SORT_NO" _
        & " FROM MS_OFFICE" _
        & " INNER JOIN (MS_DR" _
        & " INNER JOIN MS_MEMBER" _
        & " ON MS_DR.MEMBER_ID=MS_MEMBER.MEMBER_ID)" _
        & " ON MS_OFFICE.OFFICE=MS_MEMBER.OFFICE"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_OFFICE.SORT_NO" _
        & ",MS_DR.DR_NAME_KANA_FIRST" _
        & ",MS_DR.DR_NAME_KANA_LAST" _
        & ",MS_DR.DR_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDR_ID(ByVal DR_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_DR.DR_ID='" & CmnDb.SqlString(DR_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byMEMBER_ID(ByVal MEMBER_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_DR.MEMBER_ID='" & CmnDb.SqlString(MEMBER_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Login(ByVal DR_ID As String, ByVal DR_PW As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_DR.DR_ID='" & CmnDb.SqlString(DR_ID) & "'"
            strSQL &= " AND MS_DR.DR_PW='" & CmnDb.SqlString(DR_PW) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function PasswordRemain(ByVal DR_MAIL As String, ByVal DR_NAME_FIRST As String, ByVal DR_NAME_LAST As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_DR.DR_MAIL='" & CmnDb.SqlString(DR_MAIL) & "'"
            strSQL &= " AND (" _
                   & "      MS_DR.DR_NAME_FIRST='" & CmnDb.SqlString(DR_NAME_FIRST) & "'" _
                   & "      OR " _
                   & "      MS_DR.DR_NAME_KANA_FIRST='" & CmnDb.SqlString(DR_NAME_FIRST) & "'" _
                   & ")"
            strSQL &= " AND (" _
                 & "      MS_DR.DR_NAME_LAST='" & CmnDb.SqlString(DR_NAME_LAST) & "'" _
                 & "      OR " _
                 & "      MS_DR.DR_NAME_KANA_LAST='" & CmnDb.SqlString(DR_NAME_LAST) & "'" _
                 & ")"

            Return strSQL
        End Function

        '登録
        Public Shared Function Insert(ByVal MS_DR As TableDef.MS_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_DR.DR_ID) = "" OrElse Trim(MS_DR.DR_NAME_FIRST) = "" OrElse Trim(MS_DR.MEMBER_ID) = "" Then
                strSQL = "ERROR! MS_DR.INSERT"
            Else
                strSQL = "INSERT INTO MS_DR"
                strSQL &= "(" & TableDef.MS_DR.Column.DR_ID
                strSQL &= "," & TableDef.MS_DR.Column.DR_PW
                strSQL &= "," & TableDef.MS_DR.Column.UPD_DATE
                strSQL &= "," & TableDef.MS_DR.Column.UPD_USER
                strSQL &= "," & TableDef.MS_DR.Column.UPD_PGM
                strSQL &= "," & TableDef.MS_DR.Column.INS_DATE
                strSQL &= "," & TableDef.MS_DR.Column.INS_USER
                strSQL &= "," & TableDef.MS_DR.Column.INS_PGM
                strSQL &= "," & TableDef.MS_DR.Column.MEMBER_ID
                strSQL &= "," & TableDef.MS_DR.Column.MEMBER_NAME
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_FIRST
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_LAST
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_KANA_FIRST
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_KANA_LAST
                strSQL &= "," & TableDef.MS_DR.Column.DATA_ID
                strSQL &= "," & TableDef.MS_DR.Column.SHISETSU_NAME
                strSQL &= "," & TableDef.MS_DR.Column.SHISETSU_NAME_KANA
                strSQL &= "," & TableDef.MS_DR.Column.DR_MAIL
                strSQL &= ")"
                strSQL &= " VALUES"
                strSQL &= "('" & CmnDb.SqlString(MS_DR.DR_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DR_PW) & "'"
                strSQL &= ",'" & GetValue.DATE() & "'"
                strSQL &= ",'" & GetValue.USER() & "'"
                strSQL &= ",'" & GetValue.PGM() & "'"
                strSQL &= ",'" & GetValue.DATE() & "'"
                strSQL &= ",'" & GetValue.USER() & "'"
                strSQL &= ",'" & GetValue.PGM() & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.MEMBER_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.MEMBER_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DR_NAME_FIRST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DR_NAME_LAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DR_NAME_KANA_FIRST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DR_NAME_KANA_LAST) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DATA_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.SHISETSU_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.SHISETSU_NAME_KANA) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_DR.DR_MAIL) & "'"
                strSQL &= ")"
            End If

            Return strSQL
        End Function

        '更新
        Public Shared Function Update(ByVal MS_DR As TableDef.MS_DR.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_DR.DR_ID) = "" OrElse Trim(MS_DR.DR_NAME_FIRST) = "" OrElse Trim(MS_DR.MEMBER_ID) = "" Then
                strSQL = "ERROR! MS_DR.UPDATE"
            Else
                strSQL = "UPDATE MS_DR SET"
                strSQL &= " " & TableDef.MS_DR.Column.DR_PW & "='" & CmnDb.SqlString(MS_DR.DR_PW) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.UPD_DATE & "='" & GetValue.DATE() & "'"
                strSQL &= "," & TableDef.MS_DR.Column.UPD_USER & "='" & GetValue.USER() & "'"
                strSQL &= "," & TableDef.MS_DR.Column.UPD_PGM & "='" & GetValue.PGM() & "'"
                strSQL &= "," & TableDef.MS_DR.Column.MEMBER_ID & "='" & CmnDb.SqlString(MS_DR.MEMBER_ID) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.MEMBER_NAME & "='" & CmnDb.SqlString(MS_DR.MEMBER_NAME) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_FIRST & "='" & CmnDb.SqlString(MS_DR.DR_NAME_FIRST) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_LAST & "='" & CmnDb.SqlString(MS_DR.DR_NAME_LAST) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_KANA_FIRST & "='" & CmnDb.SqlString(MS_DR.DR_NAME_KANA_FIRST) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.DR_NAME_KANA_LAST & "='" & CmnDb.SqlString(MS_DR.DR_NAME_KANA_LAST) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.DATA_ID & "='" & CmnDb.SqlString(MS_DR.DATA_ID) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.SHISETSU_NAME & "='" & CmnDb.SqlString(MS_DR.SHISETSU_NAME) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.SHISETSU_NAME_KANA & "='" & CmnDb.SqlString(MS_DR.SHISETSU_NAME_KANA) & "'"
                strSQL &= "," & TableDef.MS_DR.Column.DR_MAIL & "='" & CmnDb.SqlString(MS_DR.DR_MAIL) & "'"
                strSQL &= " WHERE " & TableDef.MS_DR.Column.DR_ID & "='" & CmnDb.SqlString(MS_DR.DR_ID) & "'"
            End If

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
        & " MS_SHISETSU.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function bySHISETSU_NAME(ByVal SHISETSU_NAME As String) As String
            Dim strSQL As String = ""

            strSQL &= "SELECT"
            strSQL &= " MS_SHISETSU.*"
            strSQL &= ",MS_MEMBER.MEMBER_ID"
            strSQL &= ",MS_MEMBER.MEMBER_NAME_FIRST + ' ' + MS_MEMBER.MEMBER_NAME_LAST AS MEMBER_NAME"
            strSQL &= ",MS_MEMBER.OFFICE"
            strSQL &= " FROM MS_MEMBER"
            strSQL &= " INNER JOIN MS_SHISETSU"
            strSQL &= " ON MS_MEMBER.MEMBER_ID=MS_SHISETSU.MEMBER_ID"
            strSQL &= " WHERE MS_SHISETSU.SHISETSU_NAME LIKE '%" & CmnDb.SqlString(SHISETSU_NAME) & "%'"
            strSQL &= " OR MS_SHISETSU.SHISETSU_NAME_KANA LIKE '%" & CmnDb.SqlString(SHISETSU_NAME) & "%'"
            strSQL &= " ORDER BY MS_SHISETSU.DATA_ID"
             
            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_SHISETSU.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function MaxDATA_ID() As String
            Dim strSQL As String = ""
            strSQL &= "SELECT MAX(CONVERT(INT,DATA_ID)) AS DATA_ID"
            strSQL &= " FROM MS_SHISETSU"
            Return strSQL
        End Function

        '登録
        Public Shared Function Insert(ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct) As String
            Dim strSQL As String = ""

            'チェック
            If Trim(MS_SHISETSU.DATA_ID) = "" OrElse Trim(MS_SHISETSU.SHISETSU_NAME) = "" OrElse TRIM(MS_SHISETSU.MEMBER_ID) = "" Then
                strSQL = "ERROR! MS_SHISETSU.INSERT"
            Else
                strSQL = "INSERT INTO MS_SHISETSU"
                strSQL &= "(" & TableDef.MS_SHISETSU.Column.DATA_ID
                strSQL &= "," & TableDef.MS_SHISETSU.Column.MEMBER_ID
                strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME
                strSQL &= "," & TableDef.MS_SHISETSU.Column.SHISETSU_NAME_KANA
                strSQL &= ")"
                strSQL &= " VALUES"
                strSQL &= "('" & CmnDb.SqlString(MS_SHISETSU.DATA_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.MEMBER_ID) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME) & "'"
                strSQL &= ",'" & CmnDb.SqlString(MS_SHISETSU.SHISETSU_NAME_KANA) & "'"
                strSQL &= ")"
            End If

            Return strSQL
        End Function

    End Class

    Public Class MS_HOTELPRINT_SHIHARAI

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_HOTELPRINT_SHIHARAI.*" _
        & " FROM MS_HOTELPRINT_SHIHARAI"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_HOTELPRINT_SHIHARAI.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_HOTELPRINT_SHIHARAI.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_HOTELPRINT_ACCOMPANY

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_HOTELPRINT_ACCOMPANY.*" _
        & " FROM MS_HOTELPRINT_ACCOMPANY"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_HOTELPRINT_ACCOMPANY.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_HOTELPRINT_ACCOMPANY.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_HOTELPRINT_BREAKFAST

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_HOTELPRINT_BREAKFAST.*" _
        & " FROM MS_HOTELPRINT_BREAKFAST"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_HOTELPRINT_BREAKFAST.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_HOTELPRINT_BREAKFAST.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_HOTELPRINT_CHECKIN

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_HOTELPRINT_CHECKIN.*" _
        & " FROM MS_HOTELPRINT_CHECKIN"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_HOTELPRINT_CHECKIN.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_HOTELPRINT_CHECKIN.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_HOTELPRINT_RENRAKU

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_HOTELPRINT_RENRAKU.*" _
        & " FROM MS_HOTELPRINT_RENRAKU"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_HOTELPRINT_RENRAKU.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_HOTELPRINT_RENRAKU.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_HOTEL

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_HOTEL.*" _
        & " FROM MS_HOTEL"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_HOTEL.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_HOTEL.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class MS_ROOM_TYPE

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " MS_ROOM_TYPE.*" _
        & " FROM MS_ROOM_TYPE"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " MS_ROOM_TYPE.DATA_ID"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byDATA_ID(ByVal DATA_ID As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_ROOM_TYPE.DATA_ID='" & CmnDb.SqlString(DATA_ID) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byHOTEL_NAME(ByVal HOTEL_NAME As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE MS_ROOM_TYPE.HOTEL_NAME='" & CmnDb.SqlString(HOTEL_NAME) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

    End Class

    Public Class TBL_ZAIKO

        Private Const SQL_SELECT As String _
        = "SELECT" _
        & " TBL_ZAIKO.*" _
        & " FROM TBL_ZAIKO"

        Private Const SQL_ORDERBY As String _
        = " ORDER BY" _
        & " TBL_ZAIKO.WETLAB_COURSE"

        Public Shared Function AllData() As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function byWETLAB_COURSE(ByVal WETLAB_COURSE As String) As String
            Dim strSQL As String = SQL_SELECT

            strSQL &= " WHERE TBL_ZAIKO.WETLAB_COURSE='" & CmnDb.SqlString(WETLAB_COURSE) & "'"
            strSQL &= SQL_ORDERBY

            Return strSQL
        End Function

        Public Shared Function Update_TOROKU_SU_Regist(ByVal WETLAB_COURSE As String) As String
            Dim strSQL As String = ""

            strSQL &= "UPDATE TBL_ZAIKO SET"
            strSQL &= " TOROKU_SU=TOROKU_SU+1"
            strSQL &= " WHERE WETLAB_COURSE='" & CmnDb.SqlString(WETLAB_COURSE) & "'"

            Return strSQL
        End Function

        Public Shared Function Update_TOROKU_SU_Cancel(ByVal WETLAB_COURSE As String) As String
            Dim strSQL As String = ""

            strSQL &= "UPDATE TBL_ZAIKO SET"
            strSQL &= " TOROKU_SU=TOROKU_SU-1"
            strSQL &= " WHERE WETLAB_COURSE='" & CmnDb.SqlString(WETLAB_COURSE) & "'"

            Return strSQL
        End Function

    End Class

    Public Class TBL_SEND_MAIL
        Public Shared Function Insert(ByVal TBL_SEND_MAIL As TableDef.TBL_SEND_MAIL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SET ANSI_DEFAULTS OFF;"
            strSQL &= "INSERT INTO TBL_SEND_MAIL"
            strSQL &= "(" & TableDef.TBL_SEND_MAIL.Column.SEND_DATE
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.DATA_NO
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.ADDRESS_TO
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.ADDRESS_CC
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.ADDRESS_BCC
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.ADDRESS_FROM
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.SUBJECT
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.BODY
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.RESULT
            strSQL &= "," & TableDef.TBL_SEND_MAIL.Column.INS_PGM
            strSQL &= ")"
            strSQL &= " VALUES"
            strSQL &= "('" & CmnDb.SqlString(TBL_SEND_MAIL.SEND_DATE) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.DATA_NO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.ADDRESS_TO) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.ADDRESS_CC) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.ADDRESS_BCC) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.ADDRESS_FROM) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.SUBJECT) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.BODY) & "'"
            strSQL &= ",'" & CmnDb.SqlString(TBL_SEND_MAIL.RESULT) & "'"
            strSQL &= ",'" & GetValue.PGM() & "'"
            strSQL &= ")"

            Return strSQL
        End Function

        Public Shared Function Update(ByVal TBL_SEND_MAIL As TableDef.TBL_SEND_MAIL.DataStruct) As String
            Dim strSQL As String = ""

            strSQL &= "SET ANSI_DEFAULTS OFF;"
            strSQL &= "UPDATE TBL_SEND_MAIL SET"
            strSQL &= " " & TableDef.TBL_SEND_MAIL.Column.RESULT & "='" & CmnDb.SqlString(TBL_SEND_MAIL.RESULT) & "'"
            strSQL &= " WHERE " & TableDef.TBL_SEND_MAIL.Column.SEND_DATE & "='" & CmnDb.SqlString(TBL_SEND_MAIL.SEND_DATE) & "'"
            strSQL &= " AND " & TableDef.TBL_SEND_MAIL.Column.DATA_NO & "='" & CmnDb.SqlString(TBL_SEND_MAIL.DATA_NO) & "'"

            Return strSQL
        End Function

    End Class

End Class
