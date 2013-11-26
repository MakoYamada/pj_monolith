Imports CommonLib
Imports AppLib
Partial Public Class SapCsv
    Inherits WebBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ''共通チェック
        'MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        ''セッションを変数に格納
        'If Not SetSession() Then
        '    Response.Redirect(URL.TimeOut)
        'End If

        If Not Page.IsPostBack Then

            '画面項目 初期化
            InitControls()

            ''画面項目表示
            'SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "SAP用CSV出力"
        End With
    End Sub

    '画面項目 初期化
    Private Sub InitControls()

        'IME設定
        CmnModule.SetIme(Me.JokenSHOUNIN_Y, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSHOUNIN_M, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[CSV出力]
    Protected Sub BtnCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCSV.Click

        '入力チェック
        If Not Check() Then Exit Sub

        'Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        'If GetData(CsvData) Then

        '    'CSV出力        '    Response.Clear()
        '    Response.ContentType = CmnConst.Csv.ContentType
        '    Response.Charset = CmnConst.Csv.Charset
        '    Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "Sap.csv")
        '    Response.ContentEncoding = System.Text.Encoding.GetEncoding("utf-8")

        '    'Response.Write(MyModule.Csv.SapCsv(CsvData))
        '    Response.End()
        'End If

    End Sub

    '入力チェック
    Private Function Check() As Boolean

        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '必須入力
        If Not CmnCheck.IsInput(Me.JokenSHOUNIN_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("承認年月(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.JokenSHOUNIN_M) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("承認年月(月)"), Me)
            Return False
        End If

        '数値
        If Not CmnCheck.IsNumberOnly(Me.JokenSHOUNIN_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("承認年月(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenSHOUNIN_M) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("承認年月(月)"), Me)
            Return False
        End If

        '日付妥当性
        If CmnCheck.IsInput(Me.JokenSHOUNIN_Y) OrElse CmnCheck.IsInput(Me.JokenSHOUNIN_M) Then
            Dim wStr As String = StrConv(Trim(Me.JokenSHOUNIN_Y.Text) & "/" & Trim(Me.JokenSHOUNIN_M.Text) & "/01", VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("承認年月"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    'CSV用データ取得
    Private Function GetData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        'strSQL = SQL.TBL_KOTSUHOTEL.TaxiCsv(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

        Return True
    End Function

    '仮
    Public Shared Function SapCsv(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As String

        Dim wCnt As Integer = 0
        Dim sbCsv As New System.Text.StringBuilder
        Dim sbTitel As New System.Text.StringBuilder
        Dim sbMeisai1 As New System.Text.StringBuilder
        Dim sbMeisai2 As New System.Text.StringBuilder

        Dim strShouninDate As String = ""
        Dim strCostCenter As String = ""
        Dim lngTotalKingaku As Long = 0
        Dim MR_HOTEL_TOZEI As Long = 0
        Dim MR_JR As Long = 0
        Dim KEI_MR_HOTEL As Long = 0
        Dim KEI_MR_HOTEL_TOZEI As Long = 0
        Dim KEI_MR_JR As Long = 0

        'タイトル行
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("BKZ")))   '区分
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("BUKRS"))) '会社コード
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("BLDAT"))) '請求年月日
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("BLART"))) '伝票タイプ
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("XBLNR"))) '請求書番号
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("BKTXT"))) 'ドキュメントヘッダーテキスト
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("NEWKO"))) 'Account
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("WRBTR"))) '金額
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("MWSKZ"))) '消費税コード
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("KOSTL"))) 'Cost Center
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("AUFNR"))) 'Internal Order
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("SGTXT"))) '会合名
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("ZLSPR"))) 'Payment block
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("ZJP1")))  'Zetia Code
        sbTitel.Append(CmnCsv.SetData(CmnCsv.Quotes("BARCD"))) 'バーコード
        sbTitel.Append(vbNewLine)

        For wCnt = 0 To UBound(CsvData)

            'TODO:
            strShouninDate = ""
            lngTotalKingaku += 0
        Next


        '1行目
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("X")))   '区分
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("0094"))) '会社コード
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes(strShouninDate))) '請求年月日
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("KR"))) '伝票タイプ
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes(""))) '請求書番号
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("Top tour"))) 'ドキュメントヘッダーテキスト
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("7007466"))) 'Account
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKingaku))) '金額
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("**"))) '消費税コード
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes(""))) 'Cost Center
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes(""))) 'Internal Order
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("Nozomi 一括請求" & "月分"))) '会合名
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("E"))) 'Payment block
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes("")))  'Zetia Code
        sbMeisai1.Append(CmnCsv.SetData(CmnCsv.Quotes(""))) 'バーコード
        sbMeisai1.Append(vbNewLine)


        'CSVデータ組立
        sbCsv.Append(sbTitel.ToString)
        sbCsv.Append(sbMeisai1.ToString)
        sbCsv.Append(sbMeisai2.ToString)
        
        Return sbCsv.ToString

    End Function

End Class