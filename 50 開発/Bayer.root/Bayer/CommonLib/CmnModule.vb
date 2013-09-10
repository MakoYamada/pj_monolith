Imports System.Web.UI
Public Class CmnModule

    '--------------------------------------------------------------
    ' �󔒔���
    ' �߂�l True  : ��
    '        False : �󔒂ł͖���
    ' ����   �`�F�b�N�p������
    '--------------------------------------------------------------
    Public Shared Function IsNull(ByVal in_Str As String) As Boolean
        'Nothing����
        If IsNothing(in_Str) = True Then
            Return True
        End If
        '�󕶎�����
        If in_Str Is String.Empty Then
            Return True
        End If
        '""��������
        If in_Str.ToString = "" Then
            Return True
        End If
        Return False
    End Function

    '--------------------------------------------------------------
    ' Null��������󕶎���Ԃ�
    '--------------------------------------------------------------
    Public Shared Function DbTrim(ByVal in_Str As String) As String
        If IsNull(in_Str) = True Then
            Return ""
        Else
            Return Trim(in_Str)
        End If
    End Function

    '--------------------------------------------------------------
    ' Null��������0��Ԃ�
    '--------------------------------------------------------------
    Public Shared Function DbVal(ByVal in_Str)
        If IsNull(in_Str) = True Then
            Return 0
        Else
            If in_Str.ToString.IndexOf(".") < 0 Then
                '����
                If CmnCheck.IsNumberOnly(in_Str) = False Then
                    Return 0
                Else
                    Return Integer.Parse(in_Str)
                End If
            Else
                '�����_
                If CmnCheck.IsNumberOnly(in_Str, True) = False Then
                    Return 0.0
                Else
                    Return Single.Parse(in_Str)
                End If
            End If
        End If
    End Function
    Public Shared Function DbVal_Kingaku(ByVal in_Str)
        If IsNull(in_Str) = True Then
            Return 0
        Else
            If CmnCheck.IsValidKingaku(in_Str) = False Then
                Return 0
            Else
                Return Integer.Parse(in_Str)
            End If
        End If
    End Function

    '----------------------------------------------
    ' JavaScript�ɂ�郁�b�Z�[�W�\��
    '----------------------------------------------
    Public Shared Function GetJavaAlert(ByVal Message As String) As String
        Dim wStr As String = ""

        wStr = "<script language='javascript' type='text/javascript'>"
        wStr &= "alert(" & ControlChars.Quote & Message & ControlChars.Quote & ")"
        wStr &= " </script>"

        Return wStr
    End Function

    '----------------------------------------------
    ' ���E�B���h�E�����
    '----------------------------------------------
    Public Shared Function CloseWindow() As String
        Dim wStr As String = ""

        'wStr = "<script language='javascript' type='text/javascript'>"
        wStr &= "window.close();"
        'wStr &= "</script>"

        Return wStr
    End Function

    '----------------------------------------------
    ' �V�����E�B���h�E���J��(�I�v�V�����Ȃ�)
    '----------------------------------------------
    Public Shared Function OpenNewWindow(ByVal URL As String, Optional ByVal WindowName As String = "_blank") As String
        Dim wStr As String = ""

        'wStr = "<script language='javascript' type='text/javascript'>"
        wStr &= "window.open('" & URL & "','" & WindowName & "');"
        wStr &= "return false;"
        'wStr &= "</script>"

        Return wStr
    End Function

    '----------------------------------------------
    ' �V�����E�B���h�E���J��(�e��I�v�V��������)
    '----------------------------------------------
    Public Shared Function OpenNewWindow(ByVal URL As String, _
                                         ByVal Width As String, _
                                         ByVal Height As String, _
                                         ByVal Top As String, _
                                         ByVal Left As String, _
                                         ByVal MenuBar As OpenWidowOption, _
                                         ByVal ToolBar As OpenWidowOption, _
                                         ByVal Status As OpenWidowOption, _
                                         ByVal ReSizable As OpenWidowOption, _
                                         ByVal ScrollBars As OpenWidowOption) As String
        Dim wStr As String = ""

        wStr = "<script language='javascript' type='text/javascript'>"
        wStr &= "window.open('" & URL & "','_blank'," _
              & "'" _
              & "menubar=" & MenuBar.ToString & "," _
              & "toolbar=" & ToolBar.ToString & "," _
              & "status=" & Status.ToString & "," _
              & "resizable=" & ReSizable.ToString & "," _
              & "scrollbars=" & ScrollBars.ToString & "," _
              & "width=" & Width & "," _
              & "height=" & Height & "," _
              & "left=" & Left & "," _
              & "top=" & Top & "');"
        wStr &= "return false;"
        wStr &= "</script>"

        Return wStr
    End Function
    Enum OpenWidowOption
        [Yes]
        [No]
    End Enum

    '----------------------------------------------
    ' JavaScript�ɂ��m�F�_�C�A���O�\��
    '----------------------------------------------
    Public Shared Function GetJavaConfirm(ByVal str As String) As String
        Return "javascript:return window.confirm('" & str & "')"
    End Function

    '--------------------------------
    ' ������̃o�C�g����Ԃ�
    '--------------------------------
    Public Shared Function LenB(ByVal strString As String) As Integer
        If Trim(strString) = "" OrElse IsNothing(strString) Then Return 0

        'Shift JIS�ɕϊ������Ƃ��ɕK�v�ȃo�C�g����Ԃ�
        Return System.Text.Encoding.GetEncoding(932).GetByteCount(strString)
    End Function

    '--------------------------------
    ' ��������o�C�g���Ő؂��ĕԂ�
    '--------------------------------
    Public Shared Function MidB(ByVal stTarget As String, ByVal iStart As Integer, ByVal iByteSize As Integer) As String
        If LenB(stTarget) < (iStart) Then Return ""
        If LenB(stTarget) < (iByteSize + iStart - 1) Then Return ""

        Dim hEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim btBytes As Byte() = hEncoding.GetBytes(stTarget)

        Return hEncoding.GetString(btBytes, iStart - 1, iByteSize)
    End Function

    '--------------------------------
    ' ������̍��[����w�肵���o�C�g�����̕������Ԃ�
    '--------------------------------
    Public Shared Function LeftB(ByVal stTarget As String, ByVal iByteSize As Integer) As String
        If LenB(stTarget) < (iByteSize) Then Return ""

        Return MidB(stTarget, 1, iByteSize)
    End Function

    '--------------------------------
    ' ������̉E�[����w�肵���o�C�g�����̕������Ԃ�
    '--------------------------------
    Public Shared Function RightB(ByVal stTarget As String, ByVal iByteSize As Integer) As String
        Dim hEncoding As System.Text.Encoding = System.Text.Encoding.GetEncoding("Shift_JIS")
        Dim btBytes As Byte() = hEncoding.GetBytes(stTarget)

        If LenB(stTarget) < (iByteSize) Then Return ""

        Return hEncoding.GetString(btBytes, btBytes.Length - iByteSize, iByteSize)
    End Function

    '--------------------------------------------------------------
    ' ������̌��ɃX�y�[�X���Z�b�g���Ďw�肳�ꂽ�����̕�����ɂ���
    '--------------------------------------------------------------
    Public Shared Function EditStringLength(ByVal in_Str As String, ByVal in_Len As Integer) As String
        Dim wLen As Integer

        wLen = LenB(Trim(in_Str))
        If wLen <= in_Len Then
            EditStringLength = Trim(in_Str) & Space(in_Len - wLen)
        Else
            EditStringLength = Trim(in_Str)
        End If
    End Function

    '--------------------------------------------------------------
    ' ������̑O�Ɏw�蕶�����Z�b�g���Ďw�肳�ꂽ�����̕�����ɂ���
    ' ���߂�w�蕶���͏����l=0
    '--------------------------------------------------------------
    Public Shared Function EditRight(ByVal in_Str As String, ByVal in_Len As Integer, Optional ByVal in_PaddingChar As String = "0") As String
        If Len(Trim(in_Str)) = 0 OrElse in_Len = 0 Then
            Return ""
        End If

        '�w��̕������ɂȂ�܂Ő擪�𖄂߂�
        Return in_Str.PadLeft(in_Len, in_PaddingChar)
    End Function

    '3���J���}�ҏW
    Public Shared Function EditComma(ByVal str As String) As String
        If Val(str) = 0 Then
            Return "0"
        Else
            Return CLng(str).ToString("#,#")
        End If
    End Function
    Public Shared Function EditComma(ByVal str As Long) As String
        Return EditComma(str.ToString)
    End Function


    '--------------------------------------------------------------
    ' �e�L�X�g�{�b�N�X��IME-MODE�ݒ�
    '--------------------------------------------------------------
    Public Shared Sub SetIme(ByRef in_TextBox As System.Web.UI.WebControls.TextBox, ByVal in_Type As ImeType)
        Dim wIME As String = ""

        Select Case in_Type
            Case ImeType.Auto
                wIME = ImeType.Auto.ToString
            Case ImeType.Active
                wIME = ImeType.Active.ToString
            Case ImeType.Disabled
                wIME = ImeType.Disabled.ToString
            Case ImeType.InActive
                wIME = ImeType.InActive.ToString
            Case Else
                Exit Sub
        End Select

        in_TextBox.Style(CmnConst.Html.Style.ImeMode) = wIME
    End Sub
    Enum ImeType
        [Auto]
        [Active]
        [InActive]
        [Disabled]
    End Enum

    '�R���g���[���N���A(��)
    Public Shared Sub ClearControl(ByRef control As System.Web.UI.WebControls.TextBox)
        control.Text = ""
    End Sub
    Public Shared Sub ClearControl(ByRef control As System.Web.UI.WebControls.Label)
        control.Text = ""
    End Sub
    Public Shared Sub ClearControl(ByRef control As System.Web.UI.WebControls.CheckBox)
        control.Checked = False
    End Sub
    Public Shared Sub ClearControl(ByRef control As System.Web.UI.WebControls.RadioButton)
        control.Checked = False
    End Sub
    Public Shared Sub ClearControl(ByRef control As System.Web.UI.WebControls.DropDownList)
        Try
             control.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub

    '�R���g���[���N���A(�S����)
    Public Shared Sub ClearAllControl(ByVal WebForm As Page)
        For Each wPageControl As Control In WebForm.Controls
            If wPageControl.Controls.Count > 0 Then
                For Each wControl As Control In wPageControl.Controls
                    If TypeOf wControl Is WebControls.TextBox Then
                        '�e�L�X�g�{�b�N�X
                        CType(wControl, WebControls.TextBox).Text = ""
                    ElseIf TypeOf wControl Is WebControls.DropDownList Then
                        '�v���_�E��
                        CType(wControl, WebControls.DropDownList).SelectedIndex = 0
                    ElseIf TypeOf wControl Is WebControls.CheckBox Then
                        '�`�F�b�N�{�b�N�X
                        CType(wControl, WebControls.CheckBox).Checked = False
                    ElseIf TypeOf wControl Is WebControls.RadioButton Then
                        '���W�I�{�^��
                        CType(wControl, WebControls.RadioButton).Checked = False
                    ElseIf TypeOf wControl Is WebControls.Label Then
                        '���x��
                        If LCase(Mid(CType(wControl, WebControls.Label).ID, 1, LenB("lablel"))) = "label" Then
                            'ID�����uLabel�v�̏ꍇ���̂���
                        Else
                            CType(wControl, WebControls.Label).Text = ""
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    '--------------------------------------------------------------
    ' ������YYYYMMDDHHNNSS�`���ɕϊ�
    '--------------------------------------------------------------
    Public Shared Function Format_DateToString(ByVal in_Date As Date, Optional ByVal in_Type As DateFormatType = DateFormatType.YYYYMMDDHHMMSS) As String
        Dim wStr As String = ""

        Select Case in_Type
            Case DateFormatType.YYYYMMDDHHMMSS
                wStr = Format(in_Date, "yyyyMMddHHmmss")
            Case DateFormatType.YYYYMMDD
                wStr = Format(in_Date, "yyyyMMdd")
            Case DateFormatType.YYMMDD
                wStr = Format(in_Date, "yyMMdd")
            Case DateFormatType.MMDD
                wStr = Format(in_Date, "MMdd")
            Case DateFormatType.HHMMSS
                wStr = Format(in_Date, "HHmmss")
        End Select

        Return wStr
    End Function

    '--------------------------------------------------------------
    ' �������yyyy/mm/dd�܂���yy/mm/dd�̌`���ɕҏW���ĕԂ�
    '--------------------------------------------------------------
    Public Shared Function Format_Date(ByVal in_Str As String, ByVal in_Type As DateFormatType) As String
        Dim wStr As String = ""

        If DbTrim(in_Str) = "" Then
            Return in_Str
        End If

        wStr = Trim(in_Str)

        '���� ����
        If Len(wStr) < 5 AndAlso InStr(wStr, "/") > 0 Then
            Dim wSplit
            wSplit = Split(wStr, "/")
            If UBound(wSplit) = 1 Then
                wStr = wSplit(0).ToString.PadLeft(2, "0"c) & "/" & wSplit(1).ToString.PadLeft(2, "0"c)
            End If
        End If

        '/��:������
        wStr = Trim(Replace(Replace(Replace(Replace(wStr, "/", ""), ".", ""), ":", ""), " ", ""))

        '�w��̌`���ɕҏW
        Select Case in_Type
            Case DateFormatType.YYYYMMDD
                'yyyy/mm/dd
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) = 6 Then wStr &= "20" & wStr '6���́�����2���Ɣ��f
                If Len(wStr) = 4 Then wStr &= "2013" & wStr '4�����N�Ȃ��Ɣ��f

                wStr = Mid(wStr, 1, 4) & "/" & Mid(wStr, 5, 2) & "/" & Mid(wStr, 7, 2)
            Case DateFormatType.YYMMDD
                'yy/mm/dd
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) > 6 Then wStr = Right(wStr, 6) '6���ȏと�N2��+������؂���

                wStr = Mid(wStr, 1, 2) & "/" & Mid(wStr, 3, 2) & "/" & Mid(wStr, 5, 2)
            Case DateFormatType.MMDD, CmnModule.DateFormatType.MD
                'mm/dd
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) > 4 Then wStr = Right(wStr, 4) '4���ȏと������؂���

                wStr = Mid(wStr, 1, 2) & "/" & Mid(wStr, 3, 2)

                If in_Type = DateFormatType.MD Then
                    If Left(wStr, 1) = "0" Then wStr = Mid(wStr, 2, 20)
                    wStr = Replace(wStr, "/0", "/")
                End If
            Case DateFormatType.YYYYMMDDHHMMSS
                'yyyy/mm/dd hh:mm:ss
                '14���ȊO�́~
                If Len(wStr) <> 14 Then Return in_Str

                wStr = Mid(wStr, 1, 4) & "/" & Mid(wStr, 5, 2) & "/" & Mid(wStr, 7, 2) _
                     & " " _
                     & Mid(wStr, 9, 2) & ":" & Mid(wStr, 11, 2) & ":" & Mid(wStr, 13, 2)
            Case DateFormatType.HHMMSS
                'hh:mm:ss
                '14���ȊO�́~
                If Len(wStr) <> 14 Then Return in_Str

                wStr = Mid(wStr, 9, 2) & ":" & Mid(wStr, 11, 2) & ":" & Mid(wStr, 13, 2)
            Case DateFormatType.HHMM
                'hh:mm:ss
                '14���ȊO�́~
                If Len(wStr) <> 14 Then Return in_Str

                wStr = Mid(wStr, 9, 2) & ":" & Mid(wStr, 11, 2)
            Case DateFormatType.YYYYMD
                'yyyy/m/d
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) = 6 Then wStr &= "20" & wStr '6���́�����2���Ɣ��f
                If Len(wStr) = 4 Then wStr &= "2013" & wStr '4�����N�Ȃ��Ɣ��f

                wStr = Mid(wStr, 1, 4) & "/" & CStr(Val(Mid(wStr, 5, 2))) & "/" & CStr(Val(Mid(wStr, 7, 2)))
        End Select

        If IsDate(wStr) = False Then
            'wStr = in_Str
            wStr = ""
        End If

        Return wStr
    End Function
    '--------------------------------------------------------------
    ' �������yyyy�Nmm��dd���̌`���ɕҏW���ĕԂ�(����)
    '--------------------------------------------------------------
    Public Shared Function Format_DateJP(ByVal in_Str As String, ByVal in_Type As DateFormatType) As String
        Dim wStr As String = ""

        If DbTrim(in_Str) = "" Then
            Return in_Str
        End If

        wStr = Trim(in_Str)

        '���� ����
        If Len(wStr) < 5 AndAlso InStr(wStr, "/") > 0 Then
            Dim wSplit
            wSplit = Split(wStr, "/")
            If UBound(wSplit) = 1 Then
                wStr = wSplit(0).ToString.PadLeft(2, "0"c) & "/" & wSplit(1).ToString.PadLeft(2, "0"c)
            End If
        End If

        '/��:������
        wStr = Trim(Replace(Replace(Replace(Replace(wStr, "/", ""), ".", ""), ":", ""), " ", ""))

        '�w��̌`���ɕҏW
        Select Case in_Type
            Case DateFormatType.YYYYMMDD
                'yyyy�Nmm��dd��
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) = 6 Then wStr &= "20" & wStr '6���́�����2���Ɣ��f
                If Len(wStr) = 4 Then wStr &= "2013" & wStr '4�����N�Ȃ��Ɣ��f

                wStr = Mid(wStr, 1, 4) & "�N" & Mid(wStr, 5, 2) & "��" & Mid(wStr, 7, 2) & "��"
            Case DateFormatType.YYMMDD
                'yy�Nmm��dd��
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) > 6 Then wStr = Right(wStr, 6) '6���ȏと�N2��+������؂���

                wStr = Mid(wStr, 1, 2) & "�N" & Mid(wStr, 3, 2) & "��" & Mid(wStr, 5, 2) & "��"
            Case DateFormatType.MMDD, CmnModule.DateFormatType.MD
                'mm��dd
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) > 4 Then wStr = Right(wStr, 4) '4���ȏと������؂���

                wStr = Mid(wStr, 1, 2) & "��" & Mid(wStr, 3, 2) & "��"

                If in_Type = DateFormatType.MD Then
                    If Left(wStr, 1) = "0" Then wStr = Mid(wStr, 2, 20)
                    wStr = Replace(wStr, "��0", "��")
                End If
            Case DateFormatType.YYYYMMDDHHMMSS
                'yyyy�Nmm��dd�� hh��mm��ss�b
                '14���ȊO�́~
                If Len(wStr) <> 14 Then Return in_Str

                wStr = Mid(wStr, 1, 4) & "�N" & Mid(wStr, 5, 2) & "��" & Mid(wStr, 7, 2) & "��" _
                     & " " _
                     & Mid(wStr, 9, 2) & "��" & Mid(wStr, 11, 2) & "��" & Mid(wStr, 13, 2) & "�b"
            Case DateFormatType.HHMMSS
                'hh��mm��ss�b
                '14���ȊO�́~
                If Len(wStr) <> 14 Then Return in_Str

                wStr = Mid(wStr, 9, 2) & "��" & Mid(wStr, 11, 2) & "��" & Mid(wStr, 13, 2) & "�b"
            Case DateFormatType.HHMM
                'hh��mm��ss�b
                '14���ȊO�́~
                If Len(wStr) <> 14 Then Return in_Str

                wStr = Mid(wStr, 9, 2) & "��" & Mid(wStr, 11, 2) & "��"
            Case DateFormatType.YYYYMD
                'yyyy�Nm��d��
                If Len(wStr) = 14 Then wStr = Mid(wStr, 1, 8) '���Ԃ������Ă�����A���ɂ�������؂���
                If Len(wStr) = 6 Then wStr &= "20" & wStr '6���́�����2���Ɣ��f
                If Len(wStr) = 4 Then wStr &= "2013" & wStr '4�����N�Ȃ��Ɣ��f

                wStr = Mid(wStr, 1, 4) & "�N" & CStr(Val(Mid(wStr, 5, 2))) & "��" & CStr(Val(Mid(wStr, 7, 2))) & "��"
        End Select

        If IsDate(wStr) = False Then
            'wStr = in_Str
            wStr = ""
        End If

        Return wStr
    End Function

    Enum DateFormatType
        [YYYYMMDD]
        [YYMMDD]
        [YYYYMD]
        [MD]
        [MMDD]
        [YYYYMMDDHHMMSS]
        [HHMMSS]
        [HHMM]
    End Enum

    '���݂̓�����Ԃ�
    Public Shared Function GetSysDateTime(Optional ByVal LongFormat As Boolean = False) As String
        If LongFormat = False Then
            Return Format(Now, "yyyyMMddHHmmss")
        Else
            Return Format(Now, "yyyy/M/d HH:mm:ss")
        End If
    End Function

    '���݂̓���Ԃ�
    Public Shared Function GetSysDate(Optional ByVal LongFormat As Boolean = False) As String
        If LongFormat = False Then
            Return Format(Now, "yyyyMMdd")
        Else
            Return Format(Now, "yyyy/M/d")
        End If
    End Function

    '--------------------------------------------------------------
    ' ������������J�b�g���A�ȗ��̏ꍇ�́u...�v��t�^
    ' ����: ������A����
    '--------------------------------------------------------------
    Public Shared Function CutString(ByVal in_Str As String, ByVal in_Len As Integer) As String
        If Len(in_Str) <= in_Len Then
            '�w��̒������Z����΂��̂܂�
            Return Trim(in_Str)
        Else
            '�w��̒�����蒷����΁u...�v��t���Đ؂�
            Return Mid(Trim(in_Str), 1, in_Len) & "..."
        End If
    End Function

    '--------------------------------------------------------------
    ' ������(�O��: �����̂�)�̓��Ƀ[�������ĕԂ�
    ' ����  ������A����
    '--------------------------------------------------------------
    Public Shared Function EditStringToNumber(ByVal in_Str As String, ByVal in_Len As Integer) As String
        Return Trim(in_Str).PadLeft(in_Len, "0"c)
    End Function

    '--------------------------------------------------------------
    ' ������(�O��: �����̂�)�̓��̃[�����������ĕԂ�
    ' ����  ������A����
    '--------------------------------------------------------------
    Public Shared Function EditNumberToString(ByVal in_Str As String) As String
        If Trim(in_Str) = "" Then
            Return ""
        ElseIf IsNumeric(Trim(in_Str)) = False Then
            Return in_Str
        Else
            Return CStr(Val(in_Str))
        End If
    End Function

    '----------------------------------------------------------------
    '   �@�@�\: ������̃o�C�g����Ԃ�
    '   ���@��: ������
    '   �߂�l: �o�C�g��(Int)
    '----------------------------------------------------------------
    Public Shared Function GetByte(ByVal strChkString As String) As Integer
        Return System.Text.Encoding.GetEncoding("shift-jis").GetByteCount(strChkString)
    End Function

    Public Shared Function ClearHtmlSpace(ByVal inData As String) As String
        '&nbsp;���������ĕԂ�
        If Trim(inData) = CmnConst.Html.Space Then
            Return ""
        Else
            Return Replace(inData, CmnConst.Html.Space, "")
        End If
    End Function

    '�v���_�E���̒l��Ԃ�
    Public Shared Function GetSelectedItemValue(ByVal DropDownList As System.Web.UI.WebControls.DropDownList) As String
        If Not CmnCheck.IsInput(DropDownList) Then
            '���I����������󕶎���Ԃ�
            Return ""
        Else
            Return DropDownList.SelectedItem.Value
        End If
    End Function

    '�v���_�E���̕\���������Ԃ�
    Public Shared Function GetSelectedItemText(ByVal DropDownList As System.Web.UI.WebControls.DropDownList) As String
        If Not CmnCheck.IsInput(DropDownList) Then
            '���I����������󕶎���Ԃ�
            Return ""
        Else
            Return DropDownList.SelectedItem.Text
        End If
    End Function

    '�v���_�E����SelectedIndex��Ԃ�
    Public Shared Function GetSelectedIndex(ByVal data As String, ByVal DropDownList As System.Web.UI.WebControls.DropDownList) As Integer
        On Error Resume Next

        Dim wCount As Integer
        Dim wDropDownList As New WebControls.DropDownList
        wDropDownList = DropDownList

        If Trim(data) = "" Then Return 0

        For wCount = 0 To wDropDownList.Items.Count - 1
            If data = Trim(wDropDownList.Items(wCount).Text) OrElse data = Trim(wDropDownList.Items(wCount).Value) Then
                Return wCount
            End If
        Next
        Return 0
    End Function

    '�j����Ԃ�
    Public Shared Function GetName_Weekday(ByVal inDate As String, ByVal Kakko As Boolean) As String
        Dim wDate As String = "2013" & "/" & inDate
        If IsDate(wDate) = False Then
            Return ""
        Else
            Dim wWeekday As Integer
            wWeekday = Weekday(CDate(wDate))
            If Kakko = True Then
                Return "(" & Replace(WeekdayName(wWeekday), "�j��", "") & ")"
            Else
                Return Replace(WeekdayName(wWeekday), "�j��", "")
            End If
        End If
    End Function

    '���s��ϊ�
    Public Shared Function EditNewLine(ByVal str As String, ByVal Type As ReplaceType) As String
        Dim wStr As String = Trim(str)
        Select Case Type
            Case ReplaceType.Space
                '�X�y�[�X�ɕϊ�
                wStr = Replace(Trim(wStr), vbNewLine, " ")
                wStr = Replace(Trim(wStr), vbCr, vbNewLine)
                wStr = Replace(Trim(wStr), vbLf, vbNewLine)
            Case ReplaceType.Break
                '<br />�ɕϊ�
                wStr = Replace(Trim(wStr), vbNewLine, CmnConst.Html.Break)
                wStr = Replace(Trim(wStr), vbCr, CmnConst.Html.Break)
                wStr = Replace(Trim(wStr), vbLf, CmnConst.Html.Break)
            Case ReplaceType.BreakEscape
                '\n�ɕϊ�
                wStr = Replace(Trim(wStr), vbNewLine, CmnConst.Html.BreakEscape)
                wStr = Replace(Trim(wStr), vbCr, CmnConst.Html.BreakEscape)
                wStr = Replace(Trim(wStr), vbLf, CmnConst.Html.BreakEscape)
        End Select
        Return wStr
    End Function
    Enum ReplaceType
        [Space]
        [Break]
        [BreakEscape]
    End Enum

    '����ҏW���ĕԂ�
    Public Shared Function EditZip(ByVal Zip As String) As String
        '�n�C�t���������󕶎���Ԃ�
        If StrConv(Trim(Zip), VbStrConv.Narrow) = "-" Then
            Return ""
        Else
            Return StrConv(Trim(Zip), VbStrConv.Narrow)
        End If
    End Function
    Public Shared Function EditZip(ByVal Zip As String, ByRef Zip1 As String, ByRef Zip2 As String) As Boolean
        '�����Ƀn�C�t���̑O����Z�b�g���ĕԂ�
        Zip1 = ""
        Zip2 = ""
        Dim wSplit
        If InStr(StrConv(Zip, VbStrConv.Narrow), "-") > 0 Then
            wSplit = Split(StrConv(Zip, VbStrConv.Narrow), "-")
            Zip1 = StrConv(Trim(wSplit(0)), VbStrConv.Narrow)
            Zip2 = StrConv(Trim(wSplit(1)), VbStrConv.Narrow)
        End If
        Return True
    End Function
    Public Shared Function EditZip(ByVal Zip1 As String, ByVal Zip2 As String) As String
        '2���ڂ��n�C�t���łȂ���
        If Trim(Zip1) <> "" OrElse Trim(Zip2) <> "" Then
            Return StrConv(Trim(Zip1) & "-" & Trim(Zip2), VbStrConv.Narrow)
        Else
            Return ""
        End If
    End Function

    '�d�b�ԍ���ҏW���ĕԂ�
    Public Shared Function EditTel(ByVal Tel As String) As String
        '�n�C�t���������󕶎���Ԃ�
        If StrConv(Trim(Tel), VbStrConv.Narrow) = "-" OrElse StrConv(Trim(Tel), VbStrConv.Narrow) = "--" Then
            Return ""
        Else
            Return StrConv(Trim(Tel), VbStrConv.Narrow)
        End If
    End Function
    Public Shared Function EditTel(ByVal Tel As String, ByRef Tel1 As String, ByRef Tel2 As String, ByRef Tel3 As String) As String
        '������3���ڂ��Z�b�g���ĕԂ�
        Tel1 = ""
        Tel2 = ""
        Tel3 = ""
        Dim wSplit
        If InStr(StrConv(Tel, VbStrConv.Narrow), "-") > 0 Then
            wSplit = Split(StrConv(Tel, VbStrConv.Narrow), "-")
            Tel1 = StrConv(Trim(wSplit(0)), VbStrConv.Narrow)
            Tel2 = StrConv(Trim(wSplit(1)), VbStrConv.Narrow)
            Tel3 = StrConv(Trim(wSplit(2)), VbStrConv.Narrow)
        End If
        Return True
    End Function
    Public Shared Function EditTel(ByVal Tel1 As String, ByVal Tel2 As String, ByVal Tel3 As String) As String
        '3���ڂ��n�C�t���łȂ���
        Return StrConv(Trim(Tel1) & "-" & Trim(Tel2) & "-" & Trim(Tel3), VbStrConv.Narrow)
    End Function

    'Fax�ԍ���ҏW���ĕԂ�(�d�b�ԍ��̊֐����g�p)
    Public Shared Function EditFax(ByVal Fax As String) As String
        Return EditTel(Fax)
    End Function
    Public Shared Function EditFax(ByVal Fax As String, ByRef Fax1 As String, ByRef Fax2 As String, ByRef Fax3 As String) As String
        EditTel(Fax, Fax1, Fax2, Fax3)
        Return True
    End Function
    Public Shared Function EditFax(ByVal Fax1 As String, ByVal Fax2 As String, ByVal Fax3 As String) As String
        Return EditTel(Fax1, Fax2, Fax3)
    End Function

    '�g�ѓd�b�ԍ���ҏW���ĕԂ�(�d�b�ԍ��̊֐����g�p)
    Public Shared Function EditKeitai(ByVal Keitai As String) As String
        Return EditTel(Keitai)
    End Function
    Public Shared Function EditKeitai(ByVal Keitai As String, ByRef Keitai1 As String, ByRef Keitai2 As String, ByRef Keitai3 As String) As String
        EditTel(Keitai, Keitai1, Keitai2, Keitai3)
        Return True
    End Function
    Public Shared Function EditKeitai(ByVal Keitai1 As String, ByVal Keitai2 As String, ByVal Keitai3 As String) As String
        Return EditTel(Keitai1, Keitai2, Keitai3)
    End Function

    '���x���p�ɁA�󕶎���HTML���s��Ԃ�
    Public Shared Function DispLabel_MultiLine(ByVal str As String) As String
        If Trim(str) = "" Then
            Return CmnConst.Html.Break
        Else
            Return EditNewLine(Trim(str), ReplaceType.Break)
        End If
    End Function

    '�g�p�s�ɂ���(FireFox�΍�)
    Public Shared Sub SetEnabled(ByRef TextBox As System.Web.UI.WebControls.WebControl, ByVal Enabled As Boolean)
        TextBox.Enabled = Enabled
        If Enabled = False Then
            TextBox.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Else
            TextBox.ForeColor = System.Drawing.Color.FromArgb(10, 10, 10)
        End If
    End Sub

    Public Shared Sub SetEnabled(ByRef TextBox As System.Web.UI.WebControls.TextBox, ByVal Enabled As Boolean)
        TextBox.Enabled = Enabled
        If Enabled = False Then
            TextBox.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Else
            TextBox.ForeColor = System.Drawing.Color.FromArgb(10, 10, 10)
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef Label As System.Web.UI.WebControls.Label, ByVal Enabled As Boolean)
        Label.Enabled = Enabled
        If Enabled = False Then
            Label.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Else
            Label.ForeColor = System.Drawing.Color.FromArgb(10, 10, 10)
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef DropDownList As System.Web.UI.WebControls.DropDownList, ByVal Enabled As Boolean)
        DropDownList.Enabled = Enabled
        If Enabled = False Then
            DropDownList.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
            DropDownList.BackColor = System.Drawing.Color.FromArgb(241, 241, 241)
        Else
            DropDownList.ForeColor = System.Drawing.Color.FromArgb(10, 10, 10)
            DropDownList.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef RadioButton As System.Web.UI.WebControls.RadioButton, ByVal Enabled As Boolean)
        RadioButton.Enabled = Enabled
        If Enabled = False Then
            RadioButton.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
            RadioButton.BackColor = System.Drawing.Color.FromArgb(241, 241, 241)
        Else
            RadioButton.ForeColor = System.Drawing.Color.FromArgb(10, 10, 10)
            RadioButton.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef CheckBox As System.Web.UI.WebControls.CheckBox, ByVal Enabled As Boolean)
        CheckBox.Enabled = Enabled
        If Enabled = False Then
            CheckBox.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Else
            CheckBox.ForeColor = System.Drawing.Color.FromArgb(10, 10, 10)
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef Button As System.Web.UI.WebControls.Button, ByVal Enabled As Boolean)
        Button.Enabled = Enabled
        If Enabled = False Then
            Button.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Else
            Button.ForeColor = Nothing
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef LinkButton As System.Web.UI.WebControls.LinkButton, ByVal Enabled As Boolean)
        LinkButton.Enabled = Enabled
        If Enabled = False Then
            LinkButton.ForeColor = System.Drawing.Color.FromArgb(160, 160, 160)
        Else
            LinkButton.ForeColor = Nothing
        End If
    End Sub
    Public Shared Sub SetEnabled(ByRef Button As System.Web.UI.HtmlControls.HtmlInputButton, ByVal Enabled As Boolean)
        Button.Disabled = Not (Enabled)
        If Enabled = False Then
            Button.Style(CmnConst.Html.Style.Color) = "#a0a0a0"
        End If
    End Sub

    Public Shared Sub AlertMessage(ByVal str As String, ByVal Page As Web.UI.Page)
        Dim wClientScriptManager As ClientScriptManager
        wClientScriptManager = Page.ClientScript
        wClientScriptManager.RegisterClientScriptBlock(Page.GetType(), CmnConst.JavaScript.Alert, GetJavaAlert(str))
    End Sub

    '----------------------------------------------------------
    ' �w�肵�����x�̐��l�Ɏl�̌ܓ�����
    ' ����   inNumber : �ΏۂƂȂ鐔�l
    '        inDigits : �߂�l�̗L�������̐��x
    ' �߂�l �l�̌ܓ����ꂽ���l
    '----------------------------------------------------------
    Public Shared Function ToHalfAdjust(ByVal inNumber As Double, ByVal inDigits As Integer) As Double
        Dim dCoef As Double = System.Math.Pow(10, inDigits)

        If inNumber > 0 Then
            Return System.Math.Floor((inNumber * dCoef) + 0.5) / dCoef
        Else
            Return System.Math.Ceiling((inNumber * dCoef) - 0.5) / dCoef
        End If
    End Function

    '------------------------------------------------------------------------
    ' �w�肵�����x�̐��l�ɐ؂�̂Ă�
    ' ����  inNumber : �ۂߑΏۂ̔{���x���������_��
    '       iDigits  : �߂�l�̗L�������̐��x
    ' �߂�l    �؂�̂Ă�ꂽ���l
    '------------------------------------------------------------------------
    Public Shared Function ToRoundDown(ByVal inNumber As Double, ByVal iDigits As Integer) As Double
        Dim dCoef As Double = System.Math.Pow(10, iDigits)

        If inNumber > 0 Then
            Return System.Math.Floor(inNumber * dCoef) / dCoef
        Else
            Return System.Math.Ceiling(inNumber * dCoef) / dCoef
        End If
    End Function
    Public Shared Function ToRoundDown(ByVal inNumber As Double) As Long
        '���x�̎w�肪�Ȃ��ꍇ�͐����ŕԂ�
        Dim dCoef As Double = System.Math.Pow(10, 0)

        If inNumber > 0 Then
            Return System.Math.Floor(inNumber * dCoef) / dCoef
        Else
            Return System.Math.Ceiling(inNumber * dCoef) / dCoef
        End If
    End Function

    '------------------------------------------------------------------------
    '�N����Z�o
    '------------------------------------------------------------------------
    Public Shared Function CalcAge(ByVal Birthday As String) As String
        If CmnModule.DbVal(Birthday) = 0 Then
            Return ""
        Else
            '(�����̓��t-�a����)/10000 �̏����_�ȉ��؎̂�
            Dim wNow As String = Format(Now(), "yyyyMMdd")
            Dim wStr As String = ""
            wStr = CStr((Val(wNow) - Val(Birthday)) / 10000)
            If InStr(wStr, ".") > 0 Then
                wStr = Mid(wStr, 1, InStr(wStr, ".") - 1)
            End If
            Return wStr
        End If
    End Function
    Public Shared Function CalcAge(ByVal Birthday_Year As String, ByVal Birthday_Month As String, ByVal Birthday_Day As String) As String
        Dim wBirthday As String = ""
        If IsDate(CDate(Birthday_Year & "/" & Birthday_Month & "/" & Birthday_Day)) Then
            wBirthday = Format(CDate(Birthday_Year & "/" & Birthday_Month & "/" & Birthday_Day), "yyyyMMdd")
        End If
        Return CalcAge(wBirthday)
    End Function

End Class
