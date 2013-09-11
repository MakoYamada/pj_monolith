Imports CommonLib
Imports AppLib
Public Class MyModule

    'ページアクセス時のチェック
    Public Shared Function IsPageOK(ByVal CheckUrlReferrer As Boolean, ByVal LoginID As String, ByVal WebForm As System.Web.UI.Page, Optional ByVal AdminOnly As Boolean = True) As Boolean
        'URL直打ちチェック
        If CheckUrlReferrer = True Then
            If System.Web.HttpContext.Current.Request.UrlReferrer Is Nothing Then
                System.Web.HttpContext.Current.Response.Redirect(URL.Login)
                Return False
            End If
        End If

        'セッションチェック
        If IsNothing(LoginID) = True OrElse Trim(LoginID) = "" Then
            System.Web.HttpContext.Current.Response.Redirect(URL.TimeOut)
            Return False
        End If

        Return True
    End Function

    'データ登録モードを返す
    Public Shared Function IsInsertMode() As Boolean
        If Trim(System.Web.HttpContext.Current.Session(SessionDef.RECORD_KUBUN)) = AppConst.RECORD_KUBUN.Code.Insert Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsInsertMode(ByVal RECORD_KUBUN As String) As Boolean
        If RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Insert Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function IsUpdateMode() As Boolean
        If Trim(System.Web.HttpContext.Current.Session(SessionDef.RECORD_KUBUN)) = AppConst.RECORD_KUBUN.Code.Update Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsUpdateMode(ByVal RECORD_KUBUN As String) As Boolean
        If RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Update Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function IsCancelMode() As Boolean
        If Trim(System.Web.HttpContext.Current.Session(SessionDef.RECORD_KUBUN)) = AppConst.RECORD_KUBUN.Code.Cancel Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsCancelMode(ByVal RECORD_KUBUN As String) As Boolean
        If RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Cancel Then
            Return True
        Else
            Return False
        End If
    End Function

    '行番号チェック
    Public Shared Function IsValidSEQ(ByVal SEQ As Object) As Boolean
        If SEQ Is Nothing Then
            Return False
        Else
            If Trim(SEQ) = "" Then Return False
            If Not CmnCheck.IsNumberOnly(Trim(SEQ)) Then Return False
            If CmnModule.DbVal(SEQ) < 0 Then Return False
        End If
        Return True
    End Function

    '手配状況チェック
    Public Shared Function IsValidSTATUS_TEHAI(ByVal RECORD_KUBUN As String, ByVal OldSTATAUS_TEHAI As String, ByVal STATUS_TEHAI As String, ByVal TEHAI_HOTEL As String, ByVal TEHAI_KOTSU As String) As Boolean
        Select Case RECORD_KUBUN
            Case AppConst.RECORD_KUBUN.Code.Insert
                '新規
                If Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                    '手配なし
                    Select Case STATUS_TEHAI
                        Case AppConst.STATUS_TEHAI.Code.Fuyo
                            Return True
                        Case Else
                            Return False
                    End Select
                Else
                    '手配あり
                    If AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) Then
                        '宿泊手配あり
                        Select Case STATUS_TEHAI
                            Case AppConst.STATUS_TEHAI.Code.Input, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelOK, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK
                                Return True
                            Case Else
                                Return False
                        End Select
                    End If
                    If AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                        '交通手配あり
                        Select Case STATUS_TEHAI
                            Case AppConst.STATUS_TEHAI.Code.Input, _
                                 AppConst.STATUS_TEHAI.Code.KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.KotsuOK, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                 AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK
                                Return True
                            Case Else
                                Return False
                        End Select
                    End If
                End If
            Case AppConst.RECORD_KUBUN.Code.Update
                '変更
                Select Case OldSTATAUS_TEHAI
                    Case AppConst.STATUS_TEHAI.Code.Fuyo, _
                         AppConst.STATUS_TEHAI.Code.Input, _
                         AppConst.STATUS_TEHAI.Code.Change, _
                         AppConst.STATUS_TEHAI.Code.HotelNG, _
                         AppConst.STATUS_TEHAI.Code.KotsuNG, _
                         AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                         AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK
                        '確定前
                        If Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                            '手配なし                            Select Case STATUS_TEHAI
                                Case AppConst.STATUS_TEHAI.Code.Fuyo
                                    Return True
                                Case Else
                                    Return False
                            End Select
                        Else
                            If AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '宿泊・交通手配あり                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.Input, _
                                         AppConst.STATUS_TEHAI.Code.Change, _
                                         AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            ElseIf AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '宿泊のみ
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.Input, _
                                         AppConst.STATUS_TEHAI.Code.Change, _
                                         AppConst.STATUS_TEHAI.Code.HotelNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            ElseIf Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '交通のみ
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.Input, _
                                         AppConst.STATUS_TEHAI.Code.Change, _
                                         AppConst.STATUS_TEHAI.Code.KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.KotsuOK
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            End If
                        End If

                    Case AppConst.STATUS_TEHAI.Code.KotsuOK, _
                         AppConst.STATUS_TEHAI.Code.HotelOK, _
                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
                         AppConst.STATUS_TEHAI.Code.OKToFuyo, _
                         AppConst.STATUS_TEHAI.Code.OkToChange, _
                         AppConst.STATUS_TEHAI.Code.OKToCancel
                        '確定後                        If Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                            '手配なし                            Select Case STATUS_TEHAI
                                Case AppConst.STATUS_TEHAI.Code.Fuyo, _
                                     AppConst.STATUS_TEHAI.Code.OKToFuyo
                                    Return True
                                Case Else
                                    Return False
                            End Select
                        Else
                            If AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '宿泊・交通手配あり
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.OkToChange, _
                                         AppConst.STATUS_TEHAI.Code.OKToCancel, _
                                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                                         AppConst.STATUS_TEHAI.Code.EndToCancel
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            ElseIf AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '宿泊のみ
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.HotelNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK, _
                                         AppConst.STATUS_TEHAI.Code.OkToChange, _
                                         AppConst.STATUS_TEHAI.Code.OKToCancel, _
                                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                                         AppConst.STATUS_TEHAI.Code.EndToCancel
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            ElseIf Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '交通のみ
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.OkToChange, _
                                         AppConst.STATUS_TEHAI.Code.OKToCancel, _
                                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                                         AppConst.STATUS_TEHAI.Code.EndToCancel
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            End If
                        End If
                    Case AppConst.STATUS_TEHAI.Code.EndToFuyo, _
                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                         AppConst.STATUS_TEHAI.Code.EndToCancel
                        '確定後                        If Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                            '手配なし                            Select Case STATUS_TEHAI
                                Case AppConst.STATUS_TEHAI.Code.Fuyo, _
                                     AppConst.STATUS_TEHAI.Code.EndToFuyo
                                    Return True
                                Case Else
                                    Return False
                            End Select
                        Else
                            If AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '宿泊・交通手配あり                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.HotelNG_KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelNG_KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK_KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                                         AppConst.STATUS_TEHAI.Code.EndToCancel
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            ElseIf AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso Not AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '宿泊のみ
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.HotelNG, _
                                         AppConst.STATUS_TEHAI.Code.HotelOK, _
                                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                                         AppConst.STATUS_TEHAI.Code.EndToCancel
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            ElseIf Not AppModule.IsTEHAI_HOTEL(TEHAI_HOTEL) AndAlso AppModule.IsTEHAI_KOTSU(TEHAI_KOTSU) Then
                                '交通のみ
                                Select Case STATUS_TEHAI
                                    Case AppConst.STATUS_TEHAI.Code.KotsuNG, _
                                         AppConst.STATUS_TEHAI.Code.KotsuOK, _
                                         AppConst.STATUS_TEHAI.Code.EndToChange, _
                                         AppConst.STATUS_TEHAI.Code.EndToCancel
                                        Return True
                                    Case Else
                                        Return False
                                End Select
                            End If
                        End If
                End Select
        End Select
        Return True
    End Function
    Public Shared Function IsValidSTATUS_TEHAI(ByVal RECORD_KUBUN As String, ByVal OldSTATAUS_TEHAI As String, ByVal STATUS_TEHAI As DropDownList, ByVal TEHAI_HOTEL_Yes As RadioButton, ByVal TEHAI_KOTSU_Yes As RadioButton) As Boolean
        Dim wSTATUS_TEHAI As String
        Dim wTEHAI_HOTEL As String
        Dim wTEHAI_KOTSU As String

        wSTATUS_TEHAI = CmnModule.GetSelectedItemValue(STATUS_TEHAI)

        If TEHAI_HOTEL_Yes.Checked = True Then
            wTEHAI_HOTEL = AppConst.TEHAI.Code.Yes
        Else
            wTEHAI_HOTEL = AppConst.TEHAI.Code.No
        End If

        If TEHAI_KOTSU_Yes.Checked = True Then
            wTEHAI_KOTSU = AppConst.TEHAI.Code.Yes
        Else
            wTEHAI_KOTSU = AppConst.TEHAI.Code.No
        End If

        Return IsValidSTATUS_TEHAI(RECORD_KUBUN, OldSTATAUS_TEHAI, wSTATUS_TEHAI, wTEHAI_HOTEL, wTEHAI_KOTSU)
    End Function

      
    '== CSV ==
    Public Class Csv
        'Public Shared Function Detail_MemberInfo(ByVal CsvData() As TableDef.MS_MEMBER.DataStruct) As String
        '    Dim wCnt As Integer = 0
        '    Dim sb As New System.Text.StringBuilder

        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員コード")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("パスワード")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("氏名(漢字)")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("氏名(カナ)")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("携帯電話番号")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("PCメールアドレス ")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("携帯メールアドレス ")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("来場")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ログイン")))
        '    sb.Append(vbNewLine)

        '    For wCnt = 0 To UBound(CsvData)
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_ID(CsvData(wCnt).MEMBER_ID))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_PW(CsvData(wCnt).MEMBER_PW))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_NAME(CsvData(wCnt).MEMBER_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_NAME_KANA(CsvData(wCnt).MEMBER_NAME_KANA))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_OFFICE(CsvData(wCnt).OFFICE))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_KEITAI(CsvData(wCnt).KEITAI))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_PC_MAIL(CsvData(wCnt).PC_MAIL))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_KEITAI_MAIL(CsvData(wCnt).KEITAI_MAIL))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ATTEND(CsvData(wCnt).ATTEND))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_LOGIN_FLAG(CsvData(wCnt).LOGIN_FLAG))))
        '        sb.Append(vbNewLine)
        '    Next wCnt

        '    Return sb.ToString
        'End Function

        ''MemberInfoList
        'Public Shared Function MemberInfoList(ByVal CsvData() As TableDef.MS_MEMBER.DataStruct) As String
        '    Dim sb As New System.Text.StringBuilder

        '    '明細行
        '    sb.Append(Detail_MemberInfo(CsvData))

        '    Return sb.ToString
        'End Function

        'Public Shared Function Detail_DrInfo(ByVal CsvData() As TableDef.MS_DR.DataStruct) As String
        '    Dim wCnt As Integer = 0
        '    Dim sb As New System.Text.StringBuilder

        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ログインID")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("パスワード")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("氏名(漢字)")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("氏名(カナ)")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設・病院名称")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("営業担当 所属")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("営業担当 氏名")))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("メールアドレス")))
        '    sb.Append(vbNewLine)

        '    For wCnt = 0 To UBound(CsvData)
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_ID(CsvData(wCnt).DR_ID))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_PW(CsvData(wCnt).DR_PW))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_NAME(CsvData(wCnt).DR_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_NAME_KANA(CsvData(wCnt).DR_NAME_KANA))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SHISETSU_NAME(CsvData(wCnt).SHISETSU_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_OFFICE(CsvData(wCnt).OFFICE))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_NAME(CsvData(wCnt).MEMBER_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_MAIL(CsvData(wCnt).PC_MAIL))))
        '        sb.Append(vbNewLine)
        '    Next wCnt

        '    Return sb.ToString
        'End Function

        ''DrInfoList
        'Public Shared Function DrInfoList(ByVal CsvData() As TableDef.MS_DR.DataStruct) As String
        '    Dim sb As New System.Text.StringBuilder

        '    '明細行
        '    sb.Append(Detail_DrInfo(CsvData))

        '    Return sb.ToString
        'End Function

        'Public Shared Function Detail_DrList(ByVal CsvData() As TableDef.TBL_DR.DataStruct, Optional ByVal HIS As Boolean = False) As String
        '    Dim wCnt As Integer = 0
        '    Dim sb As New System.Text.StringBuilder

        '    If HIS = True Then
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.HIS_KUBUN)))
        '    End If
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.DATA_NO)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.STATUS_TEHAI)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.STATUS_PAYMENT)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.UPD_DATE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.INS_DATE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.INS_TYPE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.DR_MAIL)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.DR_NAME)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.DR_NAME_KANA)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SEX)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.PREFECTURES_NO)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SHISETSU_NAME)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SHISETSU_NAME_KANA)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.KAMOKU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.YAKUSHOKU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.AGE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.PUBLIC_SERVANT)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SECANDARY_USE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TEHAI_HOTEL)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.CHECK_IN)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.CHECK_OUT)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.HOTEL_SMOKING)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.NOTE_HOTEL)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.HOTEL_NAME)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ROOM_TYPE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_FLAG)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_STAY)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_SAME_ROOM)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_ADULT_SU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_SU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_AGE_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_AGE_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_SEX_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_SEX_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_BED_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_BED_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.NOTE_ACCOMPANY)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TEHAIMAIL_HOTEL)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.PARTY)))
        '    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.BYCAR)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SANKA_KUBUN)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TEHAI_KOTSU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_KOTSU_KUBUN_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_DATE_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_BIN_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_AIRPORT1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_AIRPORT2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_EXPRESS1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_EXPRESS2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_LOCAL1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_LOCAL2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_TIME1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_TIME2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_SEAT_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_SEATCLASS_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_KOTSU_KUBUN_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_DATE_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_BIN_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_AIRPORT1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_AIRPORT2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_EXPRESS1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_EXPRESS2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_LOCAL1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_LOCAL2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_TIME1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_TIME2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_SEAT_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_SEATCLASS_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_KOTSU_KUBUN_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_DATE_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_BIN_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_AIRPORT1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_AIRPORT2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_EXPRESS1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_EXPRESS2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_LOCAL1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_LOCAL2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_TIME1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_TIME2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_SEAT_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_SEATCLASS_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_KOTSU_KUBUN_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_DATE_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_BIN_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_AIRPORT1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_AIRPORT2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_EXPRESS1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_EXPRESS2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_LOCAL1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_LOCAL2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_TIME1_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_TIME2_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_SEAT_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_SEATCLASS_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_KOTSU_KUBUN_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_DATE_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_BIN_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_AIRPORT1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_AIRPORT2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_EXPRESS1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_EXPRESS2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_LOCAL1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_LOCAL2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_TIME1_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_TIME2_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_SEAT_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_SEATCLASS_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_KOTSU_KUBUN_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_DATE_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_BIN_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_AIRPORT1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_AIRPORT2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_EXPRESS1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_EXPRESS2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_LOCAL1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_LOCAL2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_TIME1_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_TIME2_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_SEAT_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_SEATCLASS_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.AIRLINE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.MILAGE_NO)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.NOTE_KOTSU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TEHAIMAIL_KOTSU)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SEND_SAKI)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SEND_ZIP)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SEND_ADDRESS)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SEND_NAME)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SEND_TEL)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.NOTES)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ROOM_RATE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.ACCOMPANY_ROOM_RATE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.O_KOTSU_FARE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.F_KOTSU_FARE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SAGAKU_NAME_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SAGAKU_1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SAGAKU_NAME_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SAGAKU_2)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SAGAKU_NAME_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.SAGAKU_3)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TOTAL_AMOUNT)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.PAYMENT_METHOD)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.GMO_ORDER_ID)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.PAYMENT_DATE_CARD)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.BILL_NO)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.BILL_NAME)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.PAYMENT_DATE_BANK)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.MEMBER_ID)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.OFFICE)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.MEMBER_NAME)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.MEMBER_NAME_KANA)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TICKET_SEND_DATE1)))
        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.TBL_DR.Name.TICKET_SEND_DATE2)))
        '    sb.Append(vbNewLine)

        '    For wCnt = 0 To UBound(CsvData)
        '        If HIS = True Then
        '            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_HIS_KUBUN(CsvData(wCnt).HIS_KUBUN, CsvData(wCnt).RECORD_KUBUN))))
        '        End If
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DATA_NO(CsvData(wCnt).DATA_NO))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_STATUS_TEHAI(CsvData(wCnt).STATUS_TEHAI))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_STATUS_PAYMENT(CsvData(wCnt).STATUS_PAYMENT))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_UPD_DATE(CsvData(wCnt).UPD_DATE, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_INS_DATE(CsvData(wCnt).INS_DATE, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_INS_TYPE(CsvData(wCnt).INS_TYPE))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_MAIL(CsvData(wCnt).DR_MAIL))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_NAME(CsvData(wCnt).DR_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_NAME_KANA(CsvData(wCnt).DR_NAME_KANA))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEX(CsvData(wCnt).SEX))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_PREFECTURES_NO(CsvData(wCnt).PREFECTURES_NO))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SHISETSU_NAME(CsvData(wCnt).SHISETSU_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SHISETSU_NAME_KANA(CsvData(wCnt).SHISETSU_NAME_KANA))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_KAMOKU(CsvData(wCnt).KAMOKU))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_YAKUSHOKU(CsvData(wCnt).YAKUSHOKU))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_AGE(CsvData(wCnt).AGE, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_PUBLIC_SERVANT(CsvData(wCnt).PUBLIC_SERVANT))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SECANDARY_USE(CsvData(wCnt).SECANDARY_USE, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_CHECK_IN(CsvData(wCnt).CHECK_IN, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_CHECK_OUT(CsvData(wCnt).CHECK_OUT, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_HOTEL_SMOKING(CsvData(wCnt).HOTEL_SMOKING))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_NOTE_HOTEL(CsvData(wCnt).NOTE_HOTEL))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_HOTEL_NAME(CsvData(wCnt).HOTEL_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ROOM_TYPE(CsvData(wCnt).ROOM_TYPE))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_FLAG(CsvData(wCnt).ACCOMPANY_FLAG))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_STAY(CsvData(wCnt).ACCOMPANY_STAY))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_SAME_ROOM(CsvData(wCnt).ACCOMPANY_SAME_ROOM, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_ACCOMPANY_ADULT_SU(CsvData(wCnt).ACCOMPANY_ADULT_SU, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_ACCOMPANY_CHILD_SU(CsvData(wCnt).ACCOMPANY_CHILD_SU, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_ACCOMPANY_CHILD_AGE_1(CsvData(wCnt).ACCOMPANY_CHILD_AGE_1, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_ACCOMPANY_CHILD_AGE_2(CsvData(wCnt).ACCOMPANY_CHILD_AGE_2, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_CHILD_SEX_1(CsvData(wCnt).ACCOMPANY_CHILD_SEX_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_CHILD_SEX_2(CsvData(wCnt).ACCOMPANY_CHILD_SEX_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_CHILD_BED_1(CsvData(wCnt).ACCOMPANY_CHILD_BED_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ACCOMPANY_CHILD_BED_2(CsvData(wCnt).ACCOMPANY_CHILD_BED_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_NOTE_ACCOMPANY(CsvData(wCnt).NOTE_ACCOMPANY))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAIMAIL_HOTEL(CsvData(wCnt).TEHAIMAIL_HOTEL))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_PARTY(CsvData(wCnt).PARTY, True))))
        '        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_BYCAR(CsvData(wCnt).BYCAR, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SANKA_KUBUN(CsvData(wCnt).SANKA_KUBUN))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAI_KOTSU(CsvData(wCnt).TEHAI_KOTSU, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_KOTSU_KUBUN_1(CsvData(wCnt).O_KOTSU_KUBUN_1, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_O_DATE_1(CsvData(wCnt).O_DATE_1, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_BIN_1(CsvData(wCnt).O_BIN_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_AIRPORT1_1(CsvData(wCnt).O_AIRPORT1_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_AIRPORT2_1(CsvData(wCnt).O_AIRPORT2_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_EXPRESS1_1(CsvData(wCnt).O_EXPRESS1_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_EXPRESS2_1(CsvData(wCnt).O_EXPRESS2_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_LOCAL1_1(CsvData(wCnt).O_LOCAL1_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_LOCAL2_1(CsvData(wCnt).O_LOCAL2_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_TIME1_1(CsvData(wCnt).O_TIME1_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_TIME2_1(CsvData(wCnt).O_TIME2_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_SEAT_1(CsvData(wCnt).O_SEAT_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_SEATCLASS_1(CsvData(wCnt).O_SEATCLASS_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_KOTSU_KUBUN_2(CsvData(wCnt).O_KOTSU_KUBUN_2, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_O_DATE_2(CsvData(wCnt).O_DATE_2, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_BIN_2(CsvData(wCnt).O_BIN_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_AIRPORT1_2(CsvData(wCnt).O_AIRPORT1_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_AIRPORT2_2(CsvData(wCnt).O_AIRPORT2_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_EXPRESS1_2(CsvData(wCnt).O_EXPRESS1_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_EXPRESS2_2(CsvData(wCnt).O_EXPRESS2_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_LOCAL1_2(CsvData(wCnt).O_LOCAL1_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_LOCAL2_2(CsvData(wCnt).O_LOCAL2_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_TIME1_2(CsvData(wCnt).O_TIME1_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_TIME2_2(CsvData(wCnt).O_TIME2_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_SEAT_2(CsvData(wCnt).O_SEAT_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_SEATCLASS_2(CsvData(wCnt).O_SEATCLASS_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_KOTSU_KUBUN_3(CsvData(wCnt).O_KOTSU_KUBUN_3, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_O_DATE_3(CsvData(wCnt).O_DATE_3, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_BIN_3(CsvData(wCnt).O_BIN_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_AIRPORT1_3(CsvData(wCnt).O_AIRPORT1_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_AIRPORT2_3(CsvData(wCnt).O_AIRPORT2_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_EXPRESS1_3(CsvData(wCnt).O_EXPRESS1_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_EXPRESS2_3(CsvData(wCnt).O_EXPRESS2_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_LOCAL1_3(CsvData(wCnt).O_LOCAL1_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_LOCAL2_3(CsvData(wCnt).O_LOCAL2_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_TIME1_3(CsvData(wCnt).O_TIME1_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_TIME2_3(CsvData(wCnt).O_TIME2_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_SEAT_3(CsvData(wCnt).O_SEAT_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_O_SEATCLASS_3(CsvData(wCnt).O_SEATCLASS_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_KOTSU_KUBUN_1(CsvData(wCnt).F_KOTSU_KUBUN_1, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_F_DATE_1(CsvData(wCnt).F_DATE_1, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_BIN_1(CsvData(wCnt).F_BIN_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_AIRPORT1_1(CsvData(wCnt).F_AIRPORT1_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_AIRPORT2_1(CsvData(wCnt).F_AIRPORT2_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_EXPRESS1_1(CsvData(wCnt).F_EXPRESS1_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_EXPRESS2_1(CsvData(wCnt).F_EXPRESS2_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_LOCAL1_1(CsvData(wCnt).F_LOCAL1_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_LOCAL2_1(CsvData(wCnt).F_LOCAL2_1, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_TIME1_1(CsvData(wCnt).F_TIME1_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_TIME2_1(CsvData(wCnt).F_TIME2_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_SEAT_1(CsvData(wCnt).F_SEAT_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_SEATCLASS_1(CsvData(wCnt).F_SEATCLASS_1))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_KOTSU_KUBUN_2(CsvData(wCnt).F_KOTSU_KUBUN_2, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_F_DATE_2(CsvData(wCnt).F_DATE_2, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_BIN_2(CsvData(wCnt).F_BIN_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_AIRPORT1_2(CsvData(wCnt).F_AIRPORT1_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_AIRPORT2_2(CsvData(wCnt).F_AIRPORT2_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_EXPRESS1_2(CsvData(wCnt).F_EXPRESS1_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_EXPRESS2_2(CsvData(wCnt).F_EXPRESS2_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_LOCAL1_2(CsvData(wCnt).F_LOCAL1_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_LOCAL2_2(CsvData(wCnt).F_LOCAL2_2, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_TIME1_2(CsvData(wCnt).F_TIME1_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_TIME2_2(CsvData(wCnt).F_TIME2_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_SEAT_2(CsvData(wCnt).F_SEAT_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_SEATCLASS_2(CsvData(wCnt).F_SEATCLASS_2))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_KOTSU_KUBUN_3(CsvData(wCnt).F_KOTSU_KUBUN_3, True))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_F_DATE_3(CsvData(wCnt).F_DATE_3, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_BIN_3(CsvData(wCnt).F_BIN_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_AIRPORT1_3(CsvData(wCnt).F_AIRPORT1_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_AIRPORT2_3(CsvData(wCnt).F_AIRPORT2_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_EXPRESS1_3(CsvData(wCnt).F_EXPRESS1_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_EXPRESS2_3(CsvData(wCnt).F_EXPRESS2_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_LOCAL1_3(CsvData(wCnt).F_LOCAL1_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_LOCAL2_3(CsvData(wCnt).F_LOCAL2_3, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_TIME1_3(CsvData(wCnt).F_TIME1_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_TIME2_3(CsvData(wCnt).F_TIME2_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_SEAT_3(CsvData(wCnt).F_SEAT_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_F_SEATCLASS_3(CsvData(wCnt).F_SEATCLASS_3))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_AIRLINE(CsvData(wCnt).AIRLINE))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MILAGE_NO(CsvData(wCnt).MILAGE_NO))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_NOTE_KOTSU(CsvData(wCnt).NOTE_KOTSU))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAIMAIL_KOTSU(CsvData(wCnt).TEHAIMAIL_KOTSU))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_SAKI(CsvData(wCnt).SEND_SAKI))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_ZIP(CsvData(wCnt).SEND_ZIP))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_ADDRESS(CsvData(wCnt).SEND_ADDRESS))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_NAME(CsvData(wCnt).SEND_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_TEL(CsvData(wCnt).SEND_TEL))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_NOTES(CsvData(wCnt).NOTES))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_ROOM_RATE(CsvData(wCnt).ROOM_RATE, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_ACCOMPANY_ROOM_RATE(CsvData(wCnt).ACCOMPANY_ROOM_RATE, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_O_KOTSU_FARE(CsvData(wCnt).O_KOTSU_FARE, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_F_KOTSU_FARE(CsvData(wCnt).F_KOTSU_FARE, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SAGAKU_NAME_1(CsvData(wCnt).SAGAKU_NAME_1))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_SAGAKU_1(CsvData(wCnt).SAGAKU_1, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SAGAKU_NAME_2(CsvData(wCnt).SAGAKU_NAME_2))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_SAGAKU_2(CsvData(wCnt).SAGAKU_2, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SAGAKU_NAME_3(CsvData(wCnt).SAGAKU_NAME_3))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_SAGAKU_3(CsvData(wCnt).SAGAKU_3, True)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_TOTAL_AMOUNT(CsvData(wCnt).TOTAL_AMOUNT, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_PAYMENT_METHOD(CsvData(wCnt).PAYMENT_METHOD, True))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_GMO_ORDER_ID(CsvData(wCnt).DATA_NO, CsvData(wCnt).PAYMENT_METHOD, ConfigurationManager.AppSettings("EventCode")))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_PAYMENT_DATE_CARD(CsvData(wCnt).PAYMENT_DATE_CARD, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_BILL_NO(CsvData(wCnt).BILL_NO))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_BILL_NAME(CsvData(wCnt).BILL_NAME))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_PAYMENT_DATE_BANK(CsvData(wCnt).PAYMENT_DATE_BANK, True)))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_ID(CsvData(wCnt).MEMBER_ID))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_OFFICE(CsvData(wCnt).OFFICE))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_NAME(CsvData(wCnt).MEMBER_NAME))))
        '        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_MEMBER_NAME_KANA(CsvData(wCnt).MEMBER_NAME_KANA))))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_TICKET_SEND_DATE1(CsvData(wCnt).TICKET_SEND_DATE1)))
        '        sb.Append(CmnCsv.SetData(AppModule.GetName_TICKET_SEND_DATE2(CsvData(wCnt).TICKET_SEND_DATE2)))
        '        sb.Append(vbNewLine)
        '    Next wCnt

        '    Return sb.ToString
        'End Function

        ''DrList
        'Public Shared Function DrList(ByVal CsvData() As TableDef.TBL_DR.DataStruct) As String
        '    Dim sb As New System.Text.StringBuilder

        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("作成日時:")))
        '    sb.Append(CmnCsv.SetData(CmnModule.GetSysDateTime(True)))
        '    sb.Append(vbNewLine)

        '    '明細行
        '    sb.Append(Detail_DrList(CsvData))

        '    Return sb.ToString
        'End Function

        ''DrHistoryList
        'Public Shared Function DrHistoryList(ByVal CsvData() As TableDef.TBL_DR.DataStruct) As String
        '    Dim sb As New System.Text.StringBuilder

        '    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("作成日時:")))
        '    sb.Append(CmnCsv.SetData(CmnModule.GetSysDateTime(True)))
        '    sb.Append(vbNewLine)

        '    '明細行
        '    sb.Append(Detail_DrList(CsvData, True))

        '    Return sb.ToString
        'End Function

    End Class

End Class
