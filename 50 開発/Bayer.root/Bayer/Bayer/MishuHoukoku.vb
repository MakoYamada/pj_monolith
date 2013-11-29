Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class MishuHoukoku

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        Dim calendar = New System.Globalization.JapaneseCalendar()
        Dim culture = New System.Globalization.CultureInfo("ja-JP")
        Culture.DateTimeFormat.Calendar = Calendar
        PRINT_DATE.Text = Now.ToString("gyy年MM月dd日", culture)
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
    End Sub
End Class
