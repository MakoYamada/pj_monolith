Imports System.Web.UI
Public Class CmnCheck

    '----------------------------------------------------
    ' 数値チェックを行い、数値のみならTrueを返す
    ' 引数  in_PeriodFlag(任意) : Trueなら小数点も許可
    '----------------------------------------------------
    Public Shared Function IsNumberOnly(ByVal in_Str As String, Optional ByVal in_PeriodFlag As Boolean = False) As Boolean
        If CmnModule.DbTrim(in_Str) = "" Then
            Return True
        End If

        '数値チェック
        in_Str = Trim(in_Str)
        If in_PeriodFlag = True Then
            '小数点あり
            If System.Text.RegularExpressions.Regex.IsMatch(in_Str, "[^0-9.]") Then
                Return False
            End If
        Else
            '小数点なし
            If System.Text.RegularExpressions.Regex.IsMatch(in_Str, "[^0-9]") Then
                Return False
            End If
        End If

        Return True
    End Function
    Public Shared Function IsNumberOnly(ByVal TextBox As System.Web.UI.WebControls.TextBox, Optional ByVal in_PeriodFlag As Boolean = False) As Boolean
        Return IsNumberOnly(TextBox.Text, in_PeriodFlag)
    End Function

    '金額チェック(数字、ハイフン、カンマOK)
    '任意でピリオドもOK
    Public Shared Function IsValidKingaku(ByVal str As String, Optional ByVal Period As Boolean = False) As Boolean
        If Trim(str) = "" Then
            Return True
        Else
            Dim KINGAKU_LETTER As String
            If Period = True Then
                KINGAKU_LETTER = "0123456789,- "
            Else
                KINGAKU_LETTER = "0123456789.,- "
            End If
            Dim wCnt As Integer = 0
            Dim buff As String

            If str.Length = 0 Then
                Return True
            Else
                For wCnt = 0 To str.Length() - 1
                    buff = str.Substring(wCnt, 1)
                    If KINGAKU_LETTER.IndexOf(buff) = -1 Then
                        Return False
                    End If
                Next
            End If
        End If
        Return True
    End Function
    Public Shared Function IsValidKingaku(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidKingaku(TextBox.Text)
    End Function

    '----------------------------------------------------
    ' 時間が正しいかどうかをチェックする
    '----------------------------------------------------
    Public Shared Function IsTime(ByVal in_Str As String) As Boolean
        If System.Text.RegularExpressions.Regex.IsMatch(Trim(in_Str), "[^0-9.:]") Then
            Return False
        End If
        If IsDate("2013/6/23 " & Trim(in_Str)) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    '全角文字が混ざっているかどうかをチェック
    Public Shared Function IsZenkaku(ByVal in_Str As String) As Boolean
        Dim Lengths As Integer = System.Text.Encoding.GetEncoding("Shift_Jis").GetByteCount(CmnModule.DbTrim(in_Str))

        If System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(CmnModule.DbTrim(in_Str)) <> CmnModule.DbTrim(in_Str).Length Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsZenkaku(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsZenkaku(TextBox.Text)
    End Function

    '半角だけならTrueを返す
    Public Shared Function IsHankaku(ByVal str As String) As Boolean
        If Trim(str) = "" Then Return True

        If IsZenkaku(str) = True Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsHankaku(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsHankaku(TextBox.Text)
    End Function

    '半角英数ハイフンチェック
    Public Shared Function IsAlphanumericHyphen(ByVal str As String) As Boolean
        Const HAN_ALPHANUMERIC As String = " 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If HAN_ALPHANUMERIC.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsAlphanumericHyphen(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsAlphanumericHyphen(TextBox.Text)
    End Function

    '半角英数チェック
    Public Shared Function IsAlphanumeric(ByVal str As String) As Boolean
        Const HAN_ALPHANUMERIC As String = " 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If HAN_ALPHANUMERIC.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsAlphanumeric(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsAlphanumeric(TextBox.Text)
    End Function

    '半角英数(小文字)チェック
    Public Shared Function IsAlphanumericLower(ByVal str As String) As Boolean
        Const HAN_ALPHANUMERIC As String = " 0123456789abcdefghijklmnopqrstuvwxyz"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If HAN_ALPHANUMERIC.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsAlphanumericLower(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsAlphanumericLower(TextBox.Text)
    End Function

    '半角アルファベットチェック
    Public Shared Function IsAlphabetOnly(ByVal str As String) As Boolean
        Const HAN_ALPHABET As String = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.,"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If HAN_ALPHABET.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsAlphabetOnly(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsAlphabetOnly(TextBox.Text)
    End Function

    '全角カナチェック
    Public Shared Function IsZenKatakana(ByVal str As String) As Boolean
        Const HAN_ZENKATAKANA As String = "　アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンガギグゲゴザジズゼゾダヂヅデドバビブベボパピプペポァィゥェォッャュョヴヰヱー・"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If HAN_ZENKATAKANA.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsZenKatakana(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsZenKatakana(TextBox.Text)
    End Function

    '半角カナチェック
    Public Shared Function IsHanKatakana(ByVal str As String) As Boolean
        Const HANKATAKANA As String = " ｱｲｳｴｵｶｷｸｹｺｻｼｽｾｿﾀﾁﾂﾃﾄﾅﾆﾇﾈﾉﾊﾋﾌﾍﾎﾏﾐﾑﾒﾓﾔﾕﾖﾗﾘﾙﾚﾛﾜｦﾝﾞｧｨｩｪｫｯｬｭｮｰ･"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If HANKATAKANA.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsHanKatakana(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsHanKatakana(TextBox.Text)
    End Function

    'メールアドレスチェック
    Public Shared Function IsValidMailAddress(ByVal str As String) As Boolean
        '前半部分        Const HAN_ALPHANUMERIC1 As String = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.-=+_/"
        '後半部分        Const HAN_ALPHANUMERIC2 As String = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ._-"
        '英字        Const HAN_ALPHANUMERIC3 As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

        Dim wCnt As Integer = 0
        Dim buff As String

        If str.Length = 0 Then
            Return True
        Else
            'スペース不許可
            If InStr(str, " ") > 0 Then
                Return False
            End If

            '@が1つだけ
            '@が存在する
            If InStr(str, "@") = 0 Then
                Return False
            End If
            '@が2つ以上は×            If Len(str) - Len(Replace(str, "@", "")) >= 2 Then
                Return False
            End If

            '@の前後を分ける            Dim wSplit() As String
            Dim wLocal As String    '@の前
            Dim wDomain As String   '@の後
            Try
                wSplit = Split(str, "@")
                wLocal = Trim(wSplit(0))
                wDomain = Trim(wSplit(1))
            Catch ex As Exception
                Return False
            End Try

            '@の前チェック
            For wCnt = 0 To wLocal.Length() - 1
                buff = wLocal.Substring(wCnt, 1)
                If HAN_ALPHANUMERIC1.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next

            '@の後チェック
            For wCnt = 0 To wDomain.Length() - 1
                buff = wDomain.Substring(wCnt, 1)
                If HAN_ALPHANUMERIC2.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next

            '.必須            If InStr(wDomain, ".") = 0 Then
                Return False
            End If

            '「..」は×            If InStr(wDomain, "..") > 0 Then
                Return False
            End If

            '　・末尾2文字は必ず半角英文字である事            '2文字以上            If Len(wDomain) < 2 Then
                Return False
            End If

            '末尾 英字のみ可
            For wCnt = Len(wDomain) - 1 To Len(wDomain)
                buff = wDomain.Substring(wCnt - 1, 1)
                If HAN_ALPHANUMERIC3.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next wCnt
        End If

        Return True
    End Function
    Public Shared Function IsValidMailAddress(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidMailAddress(TextBox.Text)
    End Function

    'URLチェック
    Public Shared Function IsValidUrl(ByVal str As String) As Boolean
        Const URL As String = " 0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-_.!~*'();/?:@&=+$,#%"
        Dim wCnt As Integer = 0
        Dim buff As String
        If str.Length = 0 Then
            Return True
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If URL.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function IsValidUrl(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidUrl(TextBox.Text)
    End Function

    '電話番号チェック
    Public Shared Function IsValidTel(ByVal str As String) As Boolean
        If Trim(str) = "" Then
            Return True
        Else
            Const TEL_LETTER As String = "0123456789()- "
            Dim wCnt As Integer = 0
            Dim buff As String

            If str.Length = 0 Then
                Return True
            Else
                For wCnt = 0 To str.Length() - 1
                    buff = str.Substring(wCnt, 1)
                    If TEL_LETTER.IndexOf(buff) = -1 Then
                        Return False
                    End If
                Next
            End If
        End If
        Return True
    End Function
    Public Shared Function IsValidTel(ByVal str1 As String, ByVal str2 As String, ByVal str3 As String) As Boolean
        Return IsValidTel(Trim(StrConv(str1, VbStrConv.Narrow)) & "-" & Trim(StrConv(str2, VbStrConv.Narrow)) & "-" & Trim(StrConv(str3, VbStrConv.Narrow)))
    End Function
    Public Shared Function IsValidTel(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTel(TextBox.Text)
    End Function
    Public Shared Function IsValidTel(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox, ByVal TextBox3 As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTel(Trim(StrConv(TextBox1.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox2.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox3.Text, VbStrConv.Narrow)))
    End Function

    'Fax番号チェック
    Public Shared Function IsValidFax(ByVal str As String) As Boolean
        Return IsValidTel(str)
    End Function
    Public Shared Function IsValidFax(ByVal str1 As String, ByVal str2 As String, ByVal str3 As String) As Boolean
        Return IsValidTel(Trim(StrConv(str1, VbStrConv.Narrow)) & "-" & Trim(StrConv(str2, VbStrConv.Narrow)) & "-" & Trim(StrConv(str3, VbStrConv.Narrow)))
    End Function
    Public Shared Function IsValidFax(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTel(TextBox.Text)
    End Function
    Public Shared Function IsValidFax(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox, ByVal TextBox3 As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTel(Trim(StrConv(TextBox1.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox2.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox3.Text, VbStrConv.Narrow)))
    End Function

    '携帯番号チェック
    Public Shared Function IsValidKeitai(ByVal str As String) As Boolean
        Return IsValidTel(str)
    End Function
    Public Shared Function IsValidKeitai(ByVal str1 As String, ByVal str2 As String, ByVal str3 As String) As Boolean
        Return IsValidTel(Trim(StrConv(str1, VbStrConv.Narrow)) & "-" & Trim(StrConv(str2, VbStrConv.Narrow)) & "-" & Trim(StrConv(str3, VbStrConv.Narrow)))
    End Function
    Public Shared Function IsValidKeitai(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTel(TextBox.Text)
    End Function
    Public Shared Function IsValidKeitai(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox, ByVal TextBox3 As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTel(Trim(StrConv(TextBox1.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox2.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox3.Text, VbStrConv.Narrow)))
    End Function

    '郵便番号チェック
    Public Shared Function IsValidZip(ByVal str As String) As Boolean
        If Trim(str) = "" Then
            Return True
        Else
            Const POST_LETTER As String = "0123456789- "
            Dim wCnt As Integer = 0
            Dim buff As String

            If str.Length = 0 Then
                Return True
            Else
                For wCnt = 0 To str.Length() - 1
                    buff = str.Substring(wCnt, 1)
                    If POST_LETTER.IndexOf(buff) = -1 Then
                        Return False
                    End If
                Next
            End If
        End If
        Return True
    End Function
    Public Shared Function IsValidZip(ByVal str1 As String, ByVal str2 As String) As Boolean
        Return IsValidZip(Trim(StrConv(str1, VbStrConv.Narrow)) & "-" & Trim(StrConv(str2, VbStrConv.Narrow)))
    End Function
    Public Shared Function IsValidZip(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidZip(TextBox.Text)
    End Function
    Public Shared Function IsValidZip(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidZip(Trim(StrConv(TextBox1.Text, VbStrConv.Narrow)) & "-" & Trim(StrConv(TextBox2.Text, VbStrConv.Narrow)))
    End Function

    '年月日チェック
    Public Shared Function IsValidDateYMD(ByVal str As String) As Boolean
        '数字/ のみ可
        Const DATE_LETTER As String = "0123456789/ "
        Dim wCnt As Integer = 0
        Dim buff As String

        If Trim(str).Length = 0 Then
            Return True
        ElseIf Trim(str).Length < 8 OrElse Trim(str).Length > 10 Then
            Return False
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If DATE_LETTER.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If

        '日付チェック
        If InStr(Trim(str), "/") <= 0 Then
            If CmnModule.LenB(Trim(str)) = 8 Then
                str = Mid(Trim(str), 1, 4) & "/" & Mid(Trim(str), 5, 2) & "/" & Mid(Trim(str), 7, 2)
            Else
                Return False
            End If
        End If
        If Not IsDate(Trim(str)) Then
            Return False
        End If
        Return True
    End Function
    Public Shared Function IsValidDateYMD(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidDateYMD(TextBox.Text)
    End Function

    Public Shared Function IsValidDateYMD(ByVal year As String, ByVal month As String, ByVal day As String) As Boolean
        If Trim(year) = "" AndAlso Trim(month) = "" AndAlso Trim(day) = "" Then
            Return True
        Else
            If Not IsNumberOnly(year) Then
                Return False
            End If
            If Val(year) < 1900 OrElse Val(year) > 2100 Then
                Return False
            End If
            If Not IsNumberOnly(month) Then
                Return False
            End If
            If Val(month) < 1 OrElse Val(month) > 12 Then
                Return False
            End If
            If Not IsNumberOnly(day) Then
                Return False
            End If
            If Val(day) < 1 OrElse Val(day) > 31 Then
                Return False
            End If
            If Not IsDate(year & "/" & month & "/" & day) Then
                Return False
            End If
            Return True
        End If
    End Function
    Public Shared Function IsValidDateYMD(ByVal year As System.Web.UI.WebControls.TextBox, ByVal month As System.Web.UI.WebControls.TextBox, ByVal day As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidDateYMD(year.Text, month.Text, day.Text)
    End Function

    ''月日チェック
    'Public Shared Function IsValidDateMD(ByVal str As String) As Boolean
    '    '数字/ のみ可
    '    Const DATE_LETTER As String = "0123456789/ "
    '    Dim wCnt As Integer = 0
    '    Dim buff As String

    '    If Trim(str).Length = 0 Then
    '        Return True
    '    ElseIf Trim(str).Length < 3 OrElse Trim(str).Length > 5 Then
    '        Return False
    '    Else
    '        For wCnt = 0 To str.Length() - 1
    '            buff = str.Substring(wCnt, 1)
    '            If DATE_LETTER.IndexOf(buff) = -1 Then
    '                Return False
    '            End If
    '        Next
    '    End If

    '    '日付チェック
    '    If InStr(Trim(str), "/") <= 0 Then
    '        If CmnModule.LenB(Trim(str)) = 4 Then
    '            str = Mid(Trim(str), 1, 2) & "/" & Mid(Trim(str), 3, 2)
    '        Else
    '            Return False
    '        End If
    '    Else
    '        str = "2013/" & Trim(str)
    '    End If
    '    If Not IsDate(Trim(str)) Then
    '        Return False
    '    End If
    '    Return True
    'End Function
    'Public Shared Function IsValidDateMD(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
    '    Return IsValidDateMD(TextBox.Text)
    'End Function

    '時分チェック
    Public Shared Function IsValidTime(ByVal str As String) As Boolean
        '数字: のみ可
        Const DATE_LETTER As String = "0123456789: "
        Dim wCnt As Integer = 0
        Dim buff As String

        If Trim(str).Length = 0 Then
            Return True
        ElseIf Trim(str).Length < 3 OrElse Trim(str).Length > 5 Then
            Return False
        Else
            For wCnt = 0 To str.Length() - 1
                buff = str.Substring(wCnt, 1)
                If DATE_LETTER.IndexOf(buff) = -1 Then
                    Return False
                End If
            Next
        End If

        '時刻チェック
        If InStr(Trim(str), ":") <= 0 Then
            If CmnModule.LenB(Trim(str)) = 4 Then
                str = Mid(Trim(str), 1, 2) & ":" & Mid(Trim(str), 3, 2)
            Else
                Return False
            End If
        End If
        If Not IsDate("2013/1/1 " & Trim(str)) Then
            Return False
        End If
        Return True
    End Function
    Public Shared Function IsValidTime(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTime(TextBox.Text)
    End Function

    Public Shared Function IsValidTime(ByVal hour As String, ByVal minute As String) As Boolean
        If Trim(hour) = "" AndAlso Trim(minute) = "" Then
            Return True
        Else
            If Not IsNumberOnly(hour) Then
                Return False
            End If
            If Val(hour) < 0 OrElse Val(hour) > 23 Then
                Return False
            End If
            If Not IsNumberOnly(minute) Then
                Return False
            End If
            If Val(minute) < 0 OrElse Val(minute) > 59 Then
                Return False
            End If
            If Not IsDate("2013/1/1 " & hour & ":" & minute) Then
                Return False
            End If
            Return True
        End If
    End Function
    Public Shared Function IsValidTime(ByVal hour As System.Web.UI.WebControls.TextBox, ByVal minute As System.Web.UI.WebControls.TextBox) As Boolean
        Return IsValidTime(hour.Text, minute.Text)
    End Function

    '文字列長さ(桁)のチェック
    Public Shared Function IsLengthEQ(ByVal inData As String, ByVal Length As Integer) As Boolean
        If CmnModule.LenB(Trim(inData)) <> Length Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsLengthEQ(ByVal inData As System.Web.UI.WebControls.TextBox, ByVal Length As Integer) As Boolean
        Return IsLengthEQ(inData.Text, Length)
    End Function

    '文字列長さ(桁)の上限チェック
    Public Shared Function IsLengthLE(ByVal inData As String, ByVal Length As Integer) As Boolean
        If CmnModule.LenB(Trim(inData)) > Length Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsLengthLE(ByVal inData As System.Web.UI.WebControls.TextBox, ByVal Length As Integer) As Boolean
        Return IsLengthLE(inData.Text, Length)
    End Function

    '文字列長さ(桁)の下限チェック
    Public Shared Function IsLengthGE(ByVal inData As String, ByVal Length As Integer) As Boolean
        If CmnModule.LenB(Trim(inData)) < Length Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsLengthGE(ByVal inData As System.Web.UI.WebControls.TextBox, ByVal Length As Integer) As Boolean
        Return IsLengthGE(inData.Text, Length)
    End Function

    '文字列長さ(桁)の範囲チェック
    Public Shared Function IsLengthRange(ByVal inData As String, ByVal Length1 As Integer, ByVal Length2 As Integer) As Boolean
        If CmnModule.LenB(Trim(inData)) < Length1 OrElse CmnModule.LenB(inData) > Length2 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsLengthRange(ByVal inData As System.Web.UI.WebControls.TextBox, ByVal Length1 As Integer, ByVal Length2 As Integer) As Boolean
        Return IsLengthRange(inData.Text, Length1, Length2)
    End Function

    'フォームの全テキストボックスの値をチェック(セキュリティ対策)
    Public Shared Function IsSecurityOK(ByVal WebForm As Control) As Boolean
        Dim wFlag As Boolean = True
        IsSecurityOK2(WebForm, wFlag)
        Return wFlag
    End Function
    Public Shared Sub IsSecurityOK2(ByVal wControl As Control, ByRef wFlag As Boolean)
        If wFlag = False Then Exit Sub
        If wControl.HasControls Then
            For Each wChildControl As Control In wControl.Controls
                IsSecurityOK2(wChildControl, wFlag)        '再帰的に繰り返す
                If TypeOf wChildControl Is WebControls.TextBox Then
                    If CType(wChildControl, WebControls.TextBox).ReadOnly = False AndAlso CType(wChildControl, WebControls.TextBox).Enabled = True Then
                        '入力禁止文字チェック
                        'If InStr(CType(wchildControl, WebControls.TextBox).Text, ";") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, "--") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, "*") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, "%") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, "?") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, "=") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, "<") > 0 OrElse _
                        '   InStr(CType(wchildControl, WebControls.TextBox).Text, ">") > 0 Then
                        If InStr(CType(wChildControl, WebControls.TextBox).Text, """") > 0 Then
                            wFlag = False
                            Exit Sub
                        End If
                        If CType(wChildControl, WebControls.TextBox).Text.Contains(Environment.NewLine) Then
                            wFlag = False
                            Exit Sub
                        End If
                    End If
                End If
            Next wChildControl
        End If
    End Sub

    '入力/選択/チェック されていたらTrueを返す
    Public Shared Function IsInput(ByVal Data As String) As Boolean
        If Trim(Data) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal Label As System.Web.UI.WebControls.Label) As Boolean
        If CmnModule.ClearHtmlSpace(Trim(Label.Text)) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal TextBox As System.Web.UI.WebControls.TextBox) As Boolean
        If Trim(TextBox.Text) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox) As Boolean
        If Trim(TextBox1.Text) = "" OrElse Trim(TextBox2.Text) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox, ByVal TextBox3 As System.Web.UI.WebControls.TextBox) As Boolean
        If Trim(TextBox1.Text) = "" OrElse Trim(TextBox2.Text) = "" OrElse Trim(TextBox3.Text) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal TextBox1 As System.Web.UI.WebControls.TextBox, ByVal TextBox2 As System.Web.UI.WebControls.TextBox, ByVal TextBox3 As System.Web.UI.WebControls.TextBox, ByVal TextBox4 As System.Web.UI.WebControls.TextBox) As Boolean
        If Trim(TextBox1.Text) = "" OrElse Trim(TextBox2.Text) = "" OrElse Trim(TextBox3.Text) = "" OrElse Trim(TextBox4.Text) = "" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal DropDownList As System.Web.UI.WebControls.DropDownList, Optional ByVal Mode As Boolean = False) As Boolean
        If DropDownList.SelectedIndex <= 0 Then
            If Mode Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal DropDownList1 As System.Web.UI.WebControls.DropDownList, ByVal DropDownList2 As System.Web.UI.WebControls.DropDownList) As Boolean
        If DropDownList1.SelectedIndex <= 0 OrElse DropDownList2.SelectedIndex <= 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal DropDownList1 As System.Web.UI.WebControls.DropDownList, ByVal DropDownList2 As System.Web.UI.WebControls.DropDownList, ByVal DropDownList3 As System.Web.UI.WebControls.DropDownList) As Boolean
        If DropDownList1.SelectedIndex <= 0 OrElse DropDownList2.SelectedIndex <= 0 OrElse DropDownList3.SelectedIndex <= 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal RadioButton As System.Web.UI.WebControls.RadioButton) As Boolean
        If RadioButton.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal RadioButton1 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton2 As System.Web.UI.WebControls.RadioButton) As Boolean
        If RadioButton1.Checked = False AndAlso RadioButton2.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal RadioButton1 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton2 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton3 As System.Web.UI.WebControls.RadioButton) As Boolean
        If RadioButton1.Checked = False AndAlso RadioButton2.Checked = False AndAlso RadioButton3.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal RadioButton1 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton2 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton3 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton4 As System.Web.UI.WebControls.RadioButton) As Boolean
        If RadioButton1.Checked = False AndAlso RadioButton2.Checked = False AndAlso RadioButton3.Checked = False AndAlso RadioButton4.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal RadioButton1 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton2 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton3 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton4 As System.Web.UI.WebControls.RadioButton, ByVal RadioButton5 As System.Web.UI.WebControls.RadioButton) As Boolean
        If RadioButton1.Checked = False AndAlso RadioButton2.Checked = False AndAlso RadioButton3.Checked = False AndAlso RadioButton4.Checked = False AndAlso RadioButton5.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function IsInput(ByVal CheckBox As System.Web.UI.WebControls.CheckBox) As Boolean
        If CheckBox.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal CheckBox1 As System.Web.UI.WebControls.CheckBox, ByVal CheckBox2 As System.Web.UI.WebControls.CheckBox) As Boolean
        If CheckBox1.Checked = False AndAlso CheckBox2.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal CheckBox1 As System.Web.UI.WebControls.CheckBox, ByVal CheckBox2 As System.Web.UI.WebControls.CheckBox, ByVal CheckBox3 As System.Web.UI.WebControls.CheckBox) As Boolean
        If CheckBox1.Checked = False AndAlso CheckBox2.Checked = False AndAlso CheckBox3.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Shared Function IsInput(ByVal CheckBox1 As System.Web.UI.WebControls.CheckBox, ByVal CheckBox2 As System.Web.UI.WebControls.CheckBox, ByVal CheckBox3 As System.Web.UI.WebControls.CheckBox, ByVal CheckBox4 As System.Web.UI.WebControls.CheckBox) As Boolean
        If CheckBox1.Checked = False AndAlso CheckBox2.Checked = False AndAlso CheckBox3.Checked = False AndAlso CheckBox4.Checked = False Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
