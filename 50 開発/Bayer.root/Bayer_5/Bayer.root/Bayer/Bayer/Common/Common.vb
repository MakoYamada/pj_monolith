Imports CommonLib
Imports AppLib

Module Common
    '<ThreadStatic()> Public cnt As Integer
    '<ThreadStatic()> Public maxcount As Integer
    <ThreadStatic()> Public MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
    <ThreadStatic()> Public csvFlag As Boolean
    '<ThreadStatic()> Public csvStr As String
End Module
