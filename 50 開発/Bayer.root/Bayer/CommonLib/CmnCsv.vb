Public Class CmnCsv

    '引用符で囲む
    Public Shared Function Quotes(ByVal CsvData As String) As String
        Return CmnConst.Csv.Delimiter & Trim(CsvData) & CmnConst.Csv.Delimiter
    End Function

    'カンマをつける
    Public Shared Function SetData(ByVal str1 As String) As String
        Return str1 & CmnConst.Csv.Comma
    End Function

End Class
