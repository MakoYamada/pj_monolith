Imports System.Collections.Specialized
Public Class ControlTool

    '全コントロール取得
    Public Shared Function GetAllControls(ByVal top As System.Web.UI.Control) As System.Web.UI.Control()
        Dim buf As ArrayList = New ArrayList
        For Each c As System.Web.UI.Control In top.Controls

            buf.Add(c)
            buf.AddRange(GetAllControls(c))

        Next
        Return CType(buf.ToArray(GetType(System.Web.UI.Control)), System.Web.UI.Control())
    End Function

    'ショートネームの取得
    Public Shared Function GetClientShortName(ByVal c As System.Web.UI.Control) As String
        If c.ID Is Nothing Then
            Dim name As String() = c.UniqueID.Split("$"c)
            Return name(name.Length - 1)
            'Return c.ClientID
        Else
            Return c.ID
        End If
    End Function

    ''フィールド定義されている名称と同じコントロール名のコントロールの値を
    ''StringDictionaryに格納する。
    'Public Shared Function GetAllInputValue(ByVal top As System.Web.UI.Control, ByVal fields As Fields) As StringDictionary
    '    Return GetAllInputValue(top, fields, New StringDictionary)
    'End Function


    ''フィールド定義されている名称と同じコントロール名のコントロールの値を
    ''StringDictionaryに格納する。
    'Public Shared Function GetAllInputValue(ByVal top As System.Web.UI.Control, ByVal fields As Fields, ByVal values As StringDictionary) As StringDictionary

    '    Dim emu As IEnumerator = ControlTool.GetAllControls(top).GetEnumerator
    '    Do While emu.MoveNext

    '        Dim c As System.Web.UI.Control = CType(emu.Current, System.Web.UI.Control)
    '        Dim clientShortName As String = GetClientShortName(c)
    '        If fields.Contains(clientShortName) Then
    '            Dim f As Field = CType(fields.GetField(clientShortName), Field)

    '            'キーが存在した場合上書き
    '            If f.GetControlValue(c) Is Nothing = False Then
    '                values.Item(f.Name) = f.GetControlValue(c)
    '            End If
    '        End If
    '    Loop

    '    Return values

    'End Function

    ''パラメータのStringDictionaryに格納されているKey名とフィールド定義の名称が一致したコントロールに
    ''Hashtableの値を格納します。
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
    ''   機　能：フィールド定義されているコントロールが全て未入力か否か
    ''   引　数：コントロール、フィールド
    ''   戻り値：True:全て空、False:いずれかに入力がある
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
