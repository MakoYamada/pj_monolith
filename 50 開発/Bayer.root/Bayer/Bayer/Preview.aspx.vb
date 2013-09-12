Imports CommonLib
Imports AppLib
Partial Public Class Preview
    Inherits WebBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'マスターページ設定
        With Me.Master
            .PageTitle = "プレビュー"
        End With

    End Sub

End Class