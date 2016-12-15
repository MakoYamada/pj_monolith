Public Class CmnCsv

    '引用符で囲む
    Public Shared Function Quotes(ByVal CsvData As String) As String
        Return CmnConst.Csv.Delimiter & CsvData & CmnConst.Csv.Delimiter
    End Function

    'カンマをつける
    Public Shared Function SetData(ByVal str1 As String, Optional ByVal NoComma As Boolean = False) As String
        If NoComma = False Then
            Return str1 & CmnConst.Csv.Comma
        Else
            Return str1
        End If
    End Function

    'ダブルクォーテーションが含まれている文字列のとき、ダブルクォーテーションでエスケープする
    Public Shared Function EscapeQuotes(ByVal CsvData As String) As String
        If CsvData.Contains(CmnConst.Csv.Delimiter) Then
            CsvData = CsvData.Replace(CmnConst.Csv.Delimiter, CmnConst.Csv.Delimiter & CmnConst.Csv.Delimiter)
        End If

        Return CsvData
    End Function

End Class
