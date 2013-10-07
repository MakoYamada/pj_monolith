Imports AppLib
Imports CommonLib
Imports System.IO

Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKaijo" 'バッチID
    Private Const pDelimiter As String = ","

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

    End Sub

End Class
