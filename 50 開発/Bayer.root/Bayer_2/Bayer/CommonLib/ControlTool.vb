Imports System.Collections.Specialized
Public Class ControlTool

    '�S�R���g���[���擾
    Public Shared Function GetAllControls(ByVal top As System.Web.UI.Control) As System.Web.UI.Control()
        Dim buf As ArrayList = New ArrayList
        For Each c As System.Web.UI.Control In top.Controls

            buf.Add(c)
            buf.AddRange(GetAllControls(c))

        Next
        Return CType(buf.ToArray(GetType(System.Web.UI.Control)), System.Web.UI.Control())
    End Function

    '�V���[�g�l�[���̎擾
    Public Shared Function GetClientShortName(ByVal c As System.Web.UI.Control) As String
        If c.ID Is Nothing Then
            Dim name As String() = c.UniqueID.Split("$"c)
            Return name(name.Length - 1)
            'Return c.ClientID
        Else
            Return c.ID
        End If
    End Function

    ''�t�B�[���h��`����Ă��閼�̂Ɠ����R���g���[�����̃R���g���[���̒l��
    ''StringDictionary�Ɋi�[����B
    'Public Shared Function GetAllInputValue(ByVal top As System.Web.UI.Control, ByVal fields As Fields) As StringDictionary
    '    Return GetAllInputValue(top, fields, New StringDictionary)
    'End Function


    ''�t�B�[���h��`����Ă��閼�̂Ɠ����R���g���[�����̃R���g���[���̒l��
    ''StringDictionary�Ɋi�[����B
    'Public Shared Function GetAllInputValue(ByVal top As System.Web.UI.Control, ByVal fields As Fields, ByVal values As StringDictionary) As StringDictionary

    '    Dim emu As IEnumerator = ControlTool.GetAllControls(top).GetEnumerator
    '    Do While emu.MoveNext

    '        Dim c As System.Web.UI.Control = CType(emu.Current, System.Web.UI.Control)
    '        Dim clientShortName As String = GetClientShortName(c)
    '        If fields.Contains(clientShortName) Then
    '            Dim f As Field = CType(fields.GetField(clientShortName), Field)

    '            '�L�[�����݂����ꍇ�㏑��
    '            If f.GetControlValue(c) Is Nothing = False Then
    '                values.Item(f.Name) = f.GetControlValue(c)
    '            End If
    '        End If
    '    Loop

    '    Return values

    'End Function

    ''�p�����[�^��StringDictionary�Ɋi�[����Ă���Key���ƃt�B�[���h��`�̖��̂���v�����R���g���[����
    ''Hashtable�̒l���i�[���܂��B
    'Public Shared Sub SetValue(ByVal top As System.Web.UI.Control, ByVal fields As Fields, ByVal values As StringDictionary)

    '    If values Is Nothing Then
    '        Exit Sub
    '    End If

    '    Dim emu As IEnumerator = ControlTool.GetAllControls(top).GetEnumerator
    '    Do While emu.MoveNext
    '        Dim c As System.Web.UI.Control = CType(emu.Current, System.Web.UI.Control)
    '        Dim clientShortName As String = ControlTool.GetClientShortName(c)
    '        If fields.Contains(clientShortName) Then
    '            If values.ContainsKey(clientShortName) Then
    '                Dim f As Field = CType(fields.GetField(clientShortName), Field)
    '                f.SetControlValue(c, CType(values.Item(f.Name), String))
    '            End If
    '        End If
    '    Loop

    'End Sub

    ''-------------------------------------------------------------------
    ''   �@�@�\�F�t�B�[���h��`����Ă���R���g���[�����S�Ė����͂��ۂ�
    ''   ���@���F�R���g���[���A�t�B�[���h
    ''   �߂�l�FTrue:�S�ċ�AFalse:�����ꂩ�ɓ��͂�����
    ''-------------------------------------------------------------------
    'Public Shared Function IsEmptyAllInputValue(ByVal top As System.Web.UI.Control, ByVal fields As Fields) As Boolean

    '    Dim emu As IEnumerator = ControlTool.GetAllControls(top).GetEnumerator
    '    Do While emu.MoveNext

    '        Dim c As System.Web.UI.Control = CType(emu.Current, System.Web.UI.Control)
    '        Dim clientShortName As String = ControlTool.GetClientShortName(c)
    '        If fields.Contains(clientShortName) Then
    '            Dim f As Field = CType(fields.GetField(clientShortName), Field)

    '            If f.GetControlValue(c) IsNot Nothing Then
    '                If Not String.IsNullOrEmpty(f.GetControlValue(c)) Then
    '                    Return False
    '                End If
    '            End If
    '        End If
    '    Loop

    '    Return True

    'End Function

End Class
