Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportSanka" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    Private Const COL_COUNT As Integer = 3 'ファイルの項目数

    Private Enum COL_NO
        Field1 = 0
        Field2
        Field3
    End Enum

    Private Class COL_NAME
        Public Const Field1 As String = "講演会番号"
        Public Const Field2 As String = "MTP ID (参加者ID)"
        Public Const Field3 As String = "参加・不参加"
    End Class

#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

    End Sub
End Class
