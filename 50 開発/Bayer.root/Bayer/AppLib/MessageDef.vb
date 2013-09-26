Imports CommonLib
Public Class MessageDef

    Public Class [Error]
        'Public Const SecurityCheck As String = "入力欄に正しくない文字が入力されています。「;」「--」「*」「%」「?」「=」「<」「>」は使用できません。"
        Public Const SecurityCheck As String = "以下の文字は使用できません。\n\n「\""」\n改行"
        Public Const Login As String = "入力されたログインID、パスワードは登録されていません。"
        Public Const MustInput_Kotsu As String = "公共交通手配がチェックされています。手配内容を入力してください。"
        Public Const MustInput_Joken As String = "検索条件を指定してください。"
        Public Const InvalidTime As String = "時間は半角数字4桁で入力してください。：は不要です。"

        '必須        Public Shared Function MustInput(ByVal ItemName As String) As String
            Return ItemName & "を入力してください。"
        End Function
        Public Shared Function MustSelect(ByVal ItemName As String) As String
            Return ItemName & "を選択してください。"
        End Function

        '登録されていません
        Public Shared Function IsNotRegistered(ByVal ItemName As String) As String
            Return ItemName & "は登録されていません。"
        End Function

        '既に登録されています
        Public Shared Function IsRegistered(ByVal ItemName As String) As String
            Return ItemName & "は既に登録されています。"
        End Function

        '正しくありません
        Public Shared Function Invalid(ByVal ItemName As String) As String
            Return ItemName & "が正しくありません。"
        End Function

        '一致しない
        Public Shared Function IsNotEQ(ByVal ItemName As String) As String
            Return ItemName & "が一致しません。"
        End Function

        '数字で入力
        Public Shared Function NumberOnly(ByVal ItemName As String) As String
            Return ItemName & "は数字で入力してください。"
        End Function

        '数字とハイフンで入力
        Public Shared Function NumberHypenOnly(ByVal ItemName As String) As String
            Return ItemName & "は数字とハイフンで入力してください。"
        End Function

        '数字とスラッシュで入力
        Public Shared Function NumberSlashOnly(ByVal ItemName As String) As String
            Return ItemName & "は数字とスラッシュ(/)で入力してください。"
        End Function

        '半角
        Public Shared Function HankakuOnly(ByVal ItemName As String) As String
            Return ItemName & "は半角で入力してください。"
        End Function

        '半角英数字で入力
        Public Shared Function AlphanumericOnly(ByVal ItemName As String) As String
            Return ItemName & "は半角英数字で入力してください。"
        End Function

        '半角英数字(小文字)で入力
        Public Shared Function AlphanumericLowerOnly(ByVal ItemName As String) As String
            Return ItemName & "は半角英数字(小文字)で入力してください。"
        End Function

        '全角カタカナ
        Public Shared Function ZenKatakanaOnly(ByVal ItemName As String) As String
            Return ItemName & "は全角カタカナで入力してください。"
        End Function

        'カタカナ
        Public Shared Function KatakanaOnly(ByVal ItemName As String) As String
            Return ItemName & "はカタカナで入力してください。"
        End Function

        'カタカナ、アルファベット不可
        Public Shared Function NoAlphabetKana(ByVal ItemName As String) As String
            Return ItemName & "にはカタカナ、アルファベットは入力できません。"
        End Function

        '再入力
        Public Shared Function Retry(ByVal ItemName As String) As String
            Return ItemName & "が間違っています。再入力してください。"
        End Function

        '桁数エラー時のメッセージを返す
        '引数: 項目名、バイト数、(任意)全角 ←全角のときはバイト数を半分にして返す
        Public Shared Function LengthEQ(ByVal ItemName As String, ByVal Length As Integer, Optional ByVal Zenkaku As Boolean = False) As String
            Dim wStr As String = ""
            Dim wLength As Integer = Length
            If Zenkaku = True Then
                '全角の場合

                wStr = "全角"
                wLength = Length / 2
            End If
            Return ItemName & " は " & wStr & wLength & "文字で入力してください。"
        End Function

        '桁数上限エラー時のメッセージを返す
        '引数: 項目名、バイト数、(任意)全角 ←全角のときはバイト数を半分にして返す
        Public Shared Function LengthLE(ByVal ItemName As String, ByVal Length As Integer, Optional ByVal Zenkaku As Boolean = False) As String
            Dim wStr As String = ""
            Dim wLength As Integer = Length
            If Zenkaku = True Then
                '全角の場合

                wStr = "全角"
                wLength = Length / 2
            End If
            Return ItemName & " は " & wStr & wLength & "文字 以内で入力してください。"
        End Function

        '桁数範囲エラー時のメッセージを返す
        '引数: 項目名、バイト数Min、バイト数Max、(任意)全角 ←全角のときはバイト数を半分にして返す
        Public Shared Function LengthRange(ByVal ItemName As String, ByVal LengthMin As Integer, ByVal LengthMax As Integer, Optional ByVal Zenkaku As Boolean = False) As String
            Dim wStr As String = ""
            Dim wLengthMin As Integer = LengthMin
            Dim wLengthMax As Integer = LengthMax
            If Zenkaku = True Then
                '全角の場合
                wStr = "全角"
                wLengthMin = LengthMin / 2
            End If
            Return ItemName & " は " & wStr & wLengthMin & "文字以上" & wLengthMax & "文字 以内で入力してください。"
        End Function

        'DBエラー発生
        Public Shared Function DbSubmit(ByVal ItemName As String, ByVal Insert As Boolean) As String
            If Insert = True Then
                Return ItemName & "登録時にエラーが発生しました"
            Else
                Return ItemName & " 変更時にエラーが発生しました"
            End If
        End Function
    End Class

    Public Class Confirm
        Public Const DataInsert As String = "新規登録します。よろしいですか？"
        Public Const DataUpdate As String = "更新します。よろしいですか？"
        Public Const DataCancel As String = "キャンセルします。よろしいですか？"
        Public Const DataDelete As String = "削除します。よろしいですか？"
    End Class

    Public Class Message
        'DB更新正常終了        Public Shared Function DbCommited(ByVal ItemName As String, ByVal Insert As Boolean) As String
            If Insert = True Then
                Return ItemName & "を登録しました"
            Else
                Return ItemName & "を変更しました"
            End If
        End Function
    End Class

End Class
