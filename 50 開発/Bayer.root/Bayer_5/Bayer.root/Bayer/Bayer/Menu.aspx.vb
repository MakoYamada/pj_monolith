Imports CommonLib
Imports AppLib
Partial Public Class Menu1
    Inherits WebBase

    Private MS_USER As TableDef.MS_USER.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    '新着交通・宿泊CSV列定義    Private Enum CellIndex
        JISSHI_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        DR_NAME
        MR_NAME
        TIME_STAMP
        USER_NAME
        KUBUN
        REQ_HOTEL
        REQ_KOTSU
        REQ_TAXI
        REQ_MR
        REQ_EMERGENCY
        SALESFORCE_ID
        TO_DATE
        REQ_O_TEHAI_1
        REQ_O_TEHAI_2
        REQ_O_TEHAI_3
        REQ_O_TEHAI_4
        REQ_O_TEHAI_5
        REQ_F_TEHAI_1
        REQ_F_TEHAI_2
        REQ_F_TEHAI_3
        REQ_F_TEHAI_4
        REQ_F_TEHAI_5
        REQ_MR_O_TEHAI
        REQ_MR_F_TEHAI
        REQ_MR_HOTEL_NOTE
        ANS_MR_HOTEL_NOTE
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        'Me.BUNSEKI_TR.Visible = False

        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '不要なセッションを破棄
            MyModule.ClearSession()

            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .HideMenu = True
            .PageTitle = "メインメニュー"
        End With

        CmnModule.SetEnabled(Me.BtnNewBentoList, False)
        CmnModule.SetEnabled(Me.BtnBentoList, False)

        ''リリース時
        'CmnModule.SetEnabled(Me.BtnMstCostcenter, False)
        'CmnModule.SetEnabled(Me.BtnTaxiMenu, False)
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            MS_USER = Session.Item(SessionDef.MS_USER)
            If IsNothing(MS_USER) Then Return False
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '画面項目 初期化

    Private Sub InitControls()

        'クリア
        'CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        If MS_USER.KENGEN = AppConst.MS_USER.KENGEN.Code.Admin Then
            CmnModule.SetEnabled(Me.BtnMstUser, True)
            CmnModule.SetEnabled(Me.BtnMstCode, True)
            CmnModule.SetEnabled(Me.BtnMstCostcenter, True)
            CmnModule.SetEnabled(Me.BtnLogFile, True)
            CmnModule.SetEnabled(Me.BtnLogSousa, True)
            CmnModule.SetEnabled(Me.BtnKotsuMaintenance, True)
            CmnModule.SetEnabled(Me.BtnTaxiMaintenance, True)
            CmnModule.SetEnabled(Me.BtnSeisanMaintenance, True)
        Else
            CmnModule.SetEnabled(Me.BtnMstUser, False)
            CmnModule.SetEnabled(Me.BtnMstCode, False)
            CmnModule.SetEnabled(Me.BtnMstCostcenter, False)
            CmnModule.SetEnabled(Me.BtnLogFile, False)
            CmnModule.SetEnabled(Me.BtnLogSousa, False)
            CmnModule.SetEnabled(Me.BtnKotsuMaintenance, False)
            CmnModule.SetEnabled(Me.BtnTaxiMaintenance, False)
            CmnModule.SetEnabled(Me.BtnSeisanMaintenance, False)
        End If
        If MS_USER.KENGEN_SEISAN = AppConst.MS_USER.KENGEN_SEISAN.Code.Yes Then
            CmnModule.SetEnabled(Me.BtnSeisan, True)
            CmnModule.SetEnabled(Me.BtnCost, True)
            CmnModule.SetEnabled(Me.BtnSap, True)
        Else
            CmnModule.SetEnabled(Me.BtnSeisan, False)
            CmnModule.SetEnabled(Me.BtnCost, False)
            CmnModule.SetEnabled(Me.BtnSap, False)
        End If
    End Sub

    '[新着：会場手配]
    Protected Sub BtnNewKaijoList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewKaijoList.Click
        Response.Redirect(URL.NewKaijoList)
    End Sub

    '[検索：会場手配]
    Protected Sub BtnKaijoList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaijoList.Click
        Response.Redirect(URL.KaijoList)
    End Sub

    '[TOP担当者マスタ]
    Protected Sub BtnMstUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMstUser.Click
        Response.Redirect(URL.MstUser)
    End Sub

    '[施設マスタ]
    Protected Sub BtnMstShisetsu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMstShisetsu.Click
        Response.Redirect(URL.MstShisetsu)
    End Sub

    '[コードマスタ]
    Protected Sub BtnMstCode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnMstCode.Click
        Response.Redirect(URL.MstCode)
    End Sub

    '[新着 会合基本情報一覧]
    Private Sub BtnNewKoenkaiList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewKoenkaiList.Click
        Response.Redirect(URL.NewKouenkaiList)
    End Sub

    '[検索 会合基本情報一覧]
    Private Sub BtnKoenkaiList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKoenkaiList.Click
        Response.Redirect(URL.KouenkaiList)
    End Sub

    '[送受信ログ照会]
    Protected Sub BtnLogFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLogFile.Click
        Dim Joken As TableDef.Joken.DataStruct = Nothing
        Joken.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.LogFile)
    End Sub

    '[操作ログ照会]
    Protected Sub BtnLogSousa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLogSousa.Click
        Dim Joken As TableDef.Joken.DataStruct = Nothing
        Joken.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.GAMEN
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.LogSousa)
    End Sub

    '[新着 交通・宿泊]
    Protected Sub BtnNewKotsuList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewKotsuList.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.Off
        Response.Redirect(URL.NewDrList)
    End Sub

    '[新着 交通・宿泊CSV出力]
    Private Sub BtnNewKotsuCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNewKotsuCsv.Click
        Response.Redirect(URL.NewDrCsv)
    End Sub

    '[検索 交通・宿泊]
    Protected Sub BtnKotsuList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKotsuList.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.Off
        Response.Redirect(URL.DrList)
    End Sub

    '[精算処理]
    Protected Sub BtnSeisan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSeisan.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.Off
        Response.Redirect(URL.SeisanKensaku)
    End Sub

    '[コストセンター別費用入力]
    Protected Sub BtnCost_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCost.Click
        Response.Redirect(URL.CostRegist)
    End Sub

    '[SAPデータ作成]
    Protected Sub BtnSap_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSap.Click
        Response.Redirect(URL.SapCsv)
    End Sub

    '[SAPデータ(TOPTOUR用)作成]
    Protected Sub BtnToptour_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnToptour.Click
        Response.Redirect(URL.SapCsvTop)
    End Sub

    '[タクシーチケット管理]
    Protected Sub BtnSeikyuMeisai0_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMenu.Click
        Response.Redirect(URL.TaxiMenu)
    End Sub

    '新着交通・宿泊一覧CSV出力
    Private Sub OutputDrCsv()

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetDrCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "NewDrList_" & Now.ToString("yyyyMMddHHmmss") & ".csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.NewDrCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If
    End Sub

    '新着交通・宿泊CSV用データ取得
    Private Function GetDrCsvData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim csvJoken As TableDef.Joken.DataStruct
        strSQL = SQL.TBL_KOTSUHOTEL.NewDrCsv(csvJoken, True)
        'strSQL = SQL.TBL_KOTSUHOTEL.Search(csvJoken, True)
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

    '[会合費用総合一覧CSV]
    Protected Sub BtnKaigouHiyouCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaigouHiyouCsv.Click
        Response.Redirect(URL.KaigouHiyouCsv)
    End Sub

    '[参加者旅費一覧CSV]
    Private Sub BtnSankashaRyohiCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSankashaRyohiCsv.Click
        Response.Redirect(URL.SankashaRyohiCsv)
    End Sub

    '[社員旅費一覧CSV]
    Private Sub BtnMRRyohiCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnMRRyohiCsv.Click
        Response.Redirect(URL.MRRyohiCsv)
    End Sub

    '[タクチケ実績取込一覧CSV]
    Private Sub BtnTaxiJissekiCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTaxiJissekiCsv.Click
        Response.Redirect(URL.TaxiJissekiCsv)
    End Sub

    '[手動取込ログ参照]
    Protected Sub BtnLogManuImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnLogManuImport.Click
        Dim Joken As TableDef.Joken.DataStruct = Nothing
        Joken.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.MANUALBAT
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.LogManual)
    End Sub

    '[交通・宿泊データメンテナンス]
    Protected Sub BtnKotsuMaintenance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKotsuMaintenance.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.On
        Response.Redirect(URL.DrList)
    End Sub

    '[タクチケデータメンテナンス]
    Protected Sub BtnTaxiMaintenance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMaintenance.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.On
        Response.Redirect(URL.TaxiMaintenance)
    End Sub

    '[精算データメンテナンス]
    Protected Sub BtnSeisanMaintenance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSeisanMaintenance.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.On
        Response.Redirect(URL.SeisanList)
    End Sub
End Class
