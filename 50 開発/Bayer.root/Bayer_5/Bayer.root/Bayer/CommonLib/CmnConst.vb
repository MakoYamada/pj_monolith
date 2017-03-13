Public Class CmnConst

    Public Class Flag
        '汎用
        Public Const [On] As String = "1"
        Public Const Off As String = "0"
    End Class

    Public Class JavaScript
        'Javascript
        Public Const Alert As String = "alert"
        Public Const WinOpen As String = "winopen"
    End Class

    Public Class Sort
        'ソート
        Public Const Ascending As String = "Ascending"      '昇順
        Public Const Descending As String = "Descending"    '降順
    End Class

    Public Class Html
        'HTML定数
        Public Const Space As String = "&nbsp;"
        Public Const Ampersand As String = "&amp;"
        Public Const Break As String = "<br />"
        Public Const BreakEscape As String = "\n"
        Public Class Color
            Public Const OK As String = "#ffffff"
            Public Const NG As String = "#f1f1f1"
            Public Const Border As String = "#687981"
        End Class
        Public Class Collapse
            Public Const Collapse As String = "collapse"
        End Class

        Public Class Style
            Public Const TextAlign As String = "text-align"
            Public Const VerticalAlign As String = "vertical-align"
            Public Const ImeMode As String = "ime-mode"
            Public Const Color As String = "color"
            Public Const BackgroundColor As String = "background-color"
            Public Const BackgroundImage As String = "background-image"
            Public Const Border As String = "border"
            Public Const BorderTop As String = "border-top"
            Public Const BorderLeft As String = "border-left"
            Public Const BorderBottom As String = "border-bottom"
            Public Const BorderRight As String = "border-right"
            Public Const BorderCollapse As String = "border-collapse"
            Public Const Width As String = "width"
            Public Const Height As String = "height"
            Public Const Display As String = "display"
            Public Const Position As String = "position"
            Public Const Top As String = "top"
            Public Const Left As String = "left"
        End Class
        Public Class Attributes
            Public Const [Class] As String = "class"
            Public Const BorderColor As String = "bordercolor"
            Public Const TabIndex As String = "tabindex"
            Public Const OnClick As String = "onclick"
            Public Const OnMouseOver As String = "onmouseover"
            Public Const OnMouseOut As String = "onmouseout"
            Public Const RowSpan As String = "rowspan"
        End Class
    End Class

    Public Class Csv
        'CSV出力
        Public Const ContentType As String = "Application/octet-stream"
        Public Const Charset As String = "shift_jis"
        Public Const AppendHeader1 As String = "Content-Disposition"
        Public Const AppendHeader2 As String = "attachment;filename="
        Public Const Delimiter As String = """"
        Public Const Comma As String = ","
        Public Shared NewLine As String = vbNewLine
    End Class

End Class
