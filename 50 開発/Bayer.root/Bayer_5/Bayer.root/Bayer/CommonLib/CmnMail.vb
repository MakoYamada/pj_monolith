Imports System.Net
Imports System.Net.Mail
Public Class CmnMail

    Private pSMTP As String
    Private pTo As String
    Private pCc As String
    Private pBCc As String
    Private pBCc2 As String
    Private pFrom As String
    Private pSubject As String
    Private pBody As String

    Public Sub New()
    End Sub

    Public WriteOnly Property SMTP() As String
        Set(ByVal Value As String)
            pSMTP = Trim(StrConv(Value, VbStrConv.Narrow))
        End Set
    End Property

    Public WriteOnly Property [To]() As String
        Set(ByVal value As String)
            pTo = Trim(StrConv(value, VbStrConv.Narrow))
        End Set
    End Property

    Public WriteOnly Property From() As String
        Set(ByVal Value As String)
            pFrom = Trim(StrConv(Value, VbStrConv.Narrow))
        End Set
    End Property

    Public WriteOnly Property Cc() As String
        Set(ByVal value As String)
            pCC = value
        End Set
    End Property

    Public WriteOnly Property BCc() As String
        Set(ByVal value As String)
            pBCC = value
        End Set
    End Property
    Public WriteOnly Property BCc2() As String
        Set(ByVal value As String)
            pBCC2 = value
        End Set
    End Property

    Public WriteOnly Property Subject() As String
        Set(ByVal Value As String)
            pSubject = Value
        End Set
    End Property

    Public WriteOnly Property Body() As String
        Set(ByVal Value As String)
            pBody = Value
        End Set
    End Property

    Public Function Send(ByVal MailSend As String) As Boolean
        'メール送信指定がない場合は抜ける
        If MailSend <> CmnConst.Flag.On Then Return True

        Dim objMailMessage As MailMessage = New MailMessage()
        Dim wBody As String = ""
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("ISO-2022-JP")
        Dim SendFlag As Boolean

        With objMailMessage
            'SMTPサーバ
            Dim sc As New System.Net.Mail.SmtpClient
            If Trim(pSMTP) = "" Then
                sc.Host = System.Configuration.ConfigurationManager.AppSettings("SMTP")
            Else
                sc.Host = pSMTP
            End If

            'To
            If Trim(pTo) <> "" Then
                .To.Add(New MailAddress(pTo))
            End If
            'cc
            If Trim(pCc) <> "" Then
                .CC.Add(New MailAddress(pCc))
            End If
            'BCC
            If Trim(pBCc) <> "" Then
                .Bcc.Add(New MailAddress(pBCc))
            End If
            If Trim(pBCc2) <> "" Then
                .Bcc.Add(New MailAddress(pBCc2))
            End If
            Dim BccKeiwa As String = System.Configuration.ConfigurationManager.AppSettings("bcckeiwa")
            If Trim(BccKeiwa) <> "" Then
                .Bcc.Add(New MailAddress(BccKeiwa))
            End If
            'From
            If Trim(pFrom) <> "" Then
                .From = New MailAddress(pFrom)
            End If

            '件名
            .Subject = ConvertBEncode(pSubject, enc)
            '   .SubjectEncoding = enc

            '本文
            wBody = pBody
            wBody = Replace(wBody, "&nbsp;", " ")
            .Body = wBody
            .BodyEncoding = enc

            Try
                sc.Send(objMailMessage)
                SendFlag = True                     '正常送信
            Catch ehttp As Exception
                SendFlag = False                    '失敗送信
            Finally
                If objMailMessage Is Nothing = False Then
                    objMailMessage.Dispose()
                End If
            End Try

            Return SendFlag

        End With
    End Function

    Private Function ConvertBEncode(ByVal val As String, ByVal encode As System.Text.Encoding) As String
        Return "=?iso-2022-jp?B?" + Convert.ToBase64String(encode.GetBytes(val)) + "?="
    End Function

End Class
