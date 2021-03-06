﻿Imports CommonLib
Imports AppLib
Public Class MyModule

    'ページアクセス時のチェック
    Public Shared Function IsPageOK(ByVal CheckUrlReferror As Boolean, ByVal LoginID As String, ByVal WebForm As WebBase, Optional ByVal AdminOnly As Boolean = True) As Boolean
        'URL直打ちチェック
        If CheckUrlReferror = True Then
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

        'コードマスタ
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wFlag As Boolean = False
        Try
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            If MS_CODE Is Nothing Then wFlag = True
        Catch ex As Exception
            wFlag = False
        End Try
        If wFlag = True Then
            'Nothingの場合、コードマスタ再取得
            MS_CODE = New List(Of TableDef.MS_CODE.DataStruct)
            Dim strSQL As String = SQL.MS_CODE.AllData()
            Dim RsData As System.Data.SqlClient.SqlDataReader
            CmnDb.DbOpen(WebForm.DbConnection)
            RsData = CmnDb.Read(strSQL, WebForm.DbConnection)
            While RsData.Read()
                Dim MS_CODE_Item As New TableDef.MS_CODE.DataStruct
                With MS_CODE_Item
                    .CODE = CmnDb.DbData(TableDef.MS_CODE.Column.CODE, RsData)
                    .DATA_ID = CmnDb.DbData(TableDef.MS_CODE.Column.DATA_ID, RsData)
                    .DISP_VALUE = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
                    .DISP_TEXT = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData)
                End With
                MS_CODE.Add(MS_CODE_Item)
            End While
            RsData.Close()
            System.Web.HttpContext.Current.Session.Item(SessionDef.MS_CODE) = MS_CODE
        End If

        Return True
    End Function

    'セキュリティ(CSRF)対策の為、遷移元をチェック
    Public Shared Function IsReferer(ByVal wkRequest As Web.HttpRequest) As Boolean

        Dim currentUrl As String = wkRequest.Url.AbsoluteUri    '表示中のURLを格納
        Dim referreUrl As String     'ReferrerURLを格納
        Dim chkArray() As String    'チェック用URLを格納
        Dim cnt As Integer  'チェックURL個数をカウント

        If Not wkRequest.UrlReferrer Is Nothing Then
            referreUrl = wkRequest.UrlReferrer.AbsoluteUri
        Else
            referreUrl = ""
        End If

        If referreUrl.ToLower = WebConfig.Site.URL.ToLower Then
            referreUrl = URL.Login
        End If

        If wkRequest.UrlReferrer Is Nothing AndAlso _
           (currentUrl.ToLower.IndexOf(URL.Login.ToLower) >= 0 Or _
            currentUrl.ToLower.IndexOf(URL.HotelKensaku.ToLower) >= 0 Or _
            currentUrl.ToLower.IndexOf(URL.ShisetsuKensaku.ToLower) >= 0 Or _
            currentUrl.ToLower.IndexOf(URL.DrRegist.ToLower) >= 0 Or _
            currentUrl.ToLower.IndexOf(URL.KouenkaiRegist.ToLower) >= 0) Then
            Return True
        ElseIf wkRequest.UrlReferrer Is Nothing Then
            'Referrer無し
            Return False
        ElseIf currentUrl.ToLower.IndexOf(URL.HotelKensaku.ToLower) >= 0 Then
            '施設検索(ホテル)
            Return True
        ElseIf currentUrl.ToLower.IndexOf(URL.ShisetsuKensaku.ToLower) >= 0 Then
            '施設検索(会場)
            Return True

        ElseIf currentUrl.ToLower.IndexOf(URL.Menu.ToLower) >= 0 Then
            'メニュー
            cnt = 0
            ReDim chkArray(37)
            AddChkArray(cnt, chkArray, URL.Login)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.NewKouenkaiList)
            AddChkArray(cnt, chkArray, URL.NewKaijoList)
            AddChkArray(cnt, chkArray, URL.NewDrList)
            AddChkArray(cnt, chkArray, URL.KouenkaiList)
            AddChkArray(cnt, chkArray, URL.KouenkaiRegist)
            AddChkArray(cnt, chkArray, URL.KouenkaiRireki)
            AddChkArray(cnt, chkArray, URL.KaijoList)
            AddChkArray(cnt, chkArray, URL.KaijoRegist)
            AddChkArray(cnt, chkArray, URL.KaijoRireki)
            AddChkArray(cnt, chkArray, URL.Preview)
            AddChkArray(cnt, chkArray, URL.DrList)
            AddChkArray(cnt, chkArray, URL.DrRegist)
            AddChkArray(cnt, chkArray, URL.DrRireki)
            AddChkArray(cnt, chkArray, URL.MstShisetsu)
            AddChkArray(cnt, chkArray, URL.MstUser)
            AddChkArray(cnt, chkArray, URL.MstCode)
            AddChkArray(cnt, chkArray, URL.LogFile)
            AddChkArray(cnt, chkArray, URL.LogSousa)
            AddChkArray(cnt, chkArray, URL.SeisanKensaku)
            AddChkArray(cnt, chkArray, URL.SeisanList)
            AddChkArray(cnt, chkArray, URL.SeisanRegist)
            AddChkArray(cnt, chkArray, URL.CostRegist)
            AddChkArray(cnt, chkArray, URL.SapCsv)
            AddChkArray(cnt, chkArray, URL.SapCsvTop)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiNouhinTorikomi)
            AddChkArray(cnt, chkArray, URL.TaxiPrintCsv)
            AddChkArray(cnt, chkArray, URL.TaxiScan)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenance)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenanceRegist)
            AddChkArray(cnt, chkArray, URL.TaxiJisseki)
            AddChkArray(cnt, chkArray, URL.TaxiSeisanMikanryou)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsu)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsuRegist)
            AddChkArray(cnt, chkArray, URL.TaxiMeisaiCsv)
            AddChkArray(cnt, chkArray, URL.TaxiMeisaiCsv2)
            AddChkArray(cnt, chkArray, URL.TaxiMikanryou)
            AddChkArray(cnt, chkArray, URL.TaxiSoufujoIkkatsu)
            AddChkArray(cnt, chkArray, URL.KaigouHiyouCsv)
            AddChkArray(cnt, chkArray, URL.SankashaRyohiCsv)
            AddChkArray(cnt, chkArray, URL.MRRyohiCsv)
            AddChkArray(cnt, chkArray, URL.TaxiJissekiCsv)
            AddChkArray(cnt, chkArray, URL.TaxiJissekiOTH)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.NewKaijoList.ToLower) >= 0 Then
            '新着会場手配一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.NewKaijoList)
            AddChkArray(cnt, chkArray, URL.KaijoRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.KaijoList.ToLower) >= 0 Then
            '検索会場手配一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.KaijoList)
            AddChkArray(cnt, chkArray, URL.KaijoRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.KaijoRegist.ToLower) >= 0 Then
            '会場手配
            cnt = 0
            ReDim chkArray(5)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.NewKaijoList)
            AddChkArray(cnt, chkArray, URL.KaijoList)
            AddChkArray(cnt, chkArray, URL.KaijoRireki)
            AddChkArray(cnt, chkArray, URL.KaijoRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.KaijoRireki.ToLower) >= 0 Then
            '会場履歴
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.KaijoRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.SeisanKensaku.ToLower) >= 0 Then
            '精算処理
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.SeisanList)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.SeisanList.ToLower) >= 0 Then
            '【検索】精算データ
            cnt = 0
            ReDim chkArray(4)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.SeisanKensaku)
            AddChkArray(cnt, chkArray, URL.SeisanRegist)
            AddChkArray(cnt, chkArray, URL.SeisanMaintenance)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.SeisanRegist.ToLower) >= 0 Then
            '精算金額入力
            cnt = 0
            ReDim chkArray(2)
            AddChkArray(cnt, chkArray, URL.SeisanList)
            AddChkArray(cnt, chkArray, URL.SeisanRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.SeisanMaintenance.ToLower) >= 0 Then
            '精算データメンテナンス
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.SeisanList)
            AddChkArray(cnt, chkArray, URL.SeisanMaintenance)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.SapCsv.ToLower) >= 0 Then
            'SAP用CSVデータ作成
            cnt = 0
            ReDim chkArray(0)
            AddChkArray(cnt, chkArray, URL.Menu)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.SapCsvTop.ToLower) >= 0 Then
            'SAP用CSVデータ作成
            cnt = 0
            ReDim chkArray(0)
            AddChkArray(cnt, chkArray, URL.Menu)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.Preview.ToLower) >= 0 Then
            'プレビュー
            cnt = 0
            ReDim chkArray(13)
            AddChkArray(cnt, chkArray, URL.SeisanList)
            AddChkArray(cnt, chkArray, URL.SeisanRegist)
            AddChkArray(cnt, chkArray, URL.KouenkaiList)
            AddChkArray(cnt, chkArray, URL.KouenkaiRireki)
            AddChkArray(cnt, chkArray, URL.NewKouenkaiList)
            AddChkArray(cnt, chkArray, URL.KaijoList)
            AddChkArray(cnt, chkArray, URL.KaijoRegist)
            AddChkArray(cnt, chkArray, URL.KaijoRireki)
            AddChkArray(cnt, chkArray, URL.NewKaijoList)
            AddChkArray(cnt, chkArray, URL.DrList)
            AddChkArray(cnt, chkArray, URL.DrRegist)
            AddChkArray(cnt, chkArray, URL.DrRireki)
            AddChkArray(cnt, chkArray, URL.NewDrList)
            AddChkArray(cnt, chkArray, URL.TaxiSoufujoIkkatsu)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.NewDrList.ToLower) >= 0 Then
            '新着交通宿泊手配一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.NewDrList)
            AddChkArray(cnt, chkArray, URL.DrRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.DrList.ToLower) >= 0 Then
            '検索交通宿泊手配一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.DrList)
            AddChkArray(cnt, chkArray, URL.DrRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.DrRegist.ToLower) >= 0 Then
            '交通宿泊登録
            cnt = 0
            ReDim chkArray(4)
            AddChkArray(cnt, chkArray, URL.NewDrList)
            AddChkArray(cnt, chkArray, URL.DrList)
            AddChkArray(cnt, chkArray, URL.DrRegist)
            AddChkArray(cnt, chkArray, URL.DrRireki)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.NewKouenkaiList.ToLower) >= 0 Then
            '新規基本情報一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.NewKouenkaiList)
            AddChkArray(cnt, chkArray, URL.KouenkaiRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.KouenkaiList.ToLower) >= 0 Then
            '検索基本情報一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.KouenkaiList)
            AddChkArray(cnt, chkArray, URL.KouenkaiRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.KouenkaiRegist.ToLower) >= 0 Then
            '基本情報登録
            cnt = 0
            ReDim chkArray(6)
            AddChkArray(cnt, chkArray, URL.NewKouenkaiList)
            AddChkArray(cnt, chkArray, URL.KouenkaiList)
            AddChkArray(cnt, chkArray, URL.KouenkaiRegist)
            AddChkArray(cnt, chkArray, URL.KouenkaiRireki)
            AddChkArray(cnt, chkArray, URL.DrRegist)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMenu.ToLower) >= 0 Then
            'タクチケ管理メニュー
            cnt = 0
            ReDim chkArray(12)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiJisseki)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenance)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenanceRegist)
            AddChkArray(cnt, chkArray, URL.TaxiMeisaiCsv)
            AddChkArray(cnt, chkArray, URL.TaxiMeisaiCsv2)
            AddChkArray(cnt, chkArray, URL.TaxiMikanryou)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsu)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsuRegist)
            AddChkArray(cnt, chkArray, URL.TaxiNouhinTorikomi)
            AddChkArray(cnt, chkArray, URL.TaxiPrintCsv)
            AddChkArray(cnt, chkArray, URL.TaxiScan)
            AddChkArray(cnt, chkArray, URL.TaxiSoufujoIkkatsu)
            AddChkArray(cnt, chkArray, URL.TaxiJissekiOTH)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiNouhinTorikomi.ToLower) >= 0 Then
            'タクチケ納品データ取込
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiNouhinTorikomi)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiPrintCsv.ToLower) >= 0 Then
            'タクチケ印刷データ出力
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiPrintCsv)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiScan.ToLower) >= 0 Then
            'タクチケスキャンデータ取込
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiScan)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMeisaiCsv.ToLower) >= 0 Then
            'タクチケ明細Csv
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiMeisaiCsv)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMeisaiCsv2.ToLower) >= 0 Then
            'タクチケ明細Csv
            cnt = 0
            ReDim chkArray(0)
            AddChkArray(cnt, chkArray, URL.TaxiMeisaiCsv)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiJisseki.ToLower) >= 0 Then
            'タクチケ実績データ取込
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiJisseki)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiJissekiOTH.ToLower) >= 0 Then
            'その他タクチケ実績データ取込
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiJissekiOTH)

            Return IsReferrer(referreUrl, chkArray)
        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMaintenance.ToLower) >= 0 Then
            'タクチケメンテナンス一覧
            cnt = 0
            ReDim chkArray(3)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenance)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenanceRegist)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMaintenanceRegist.ToLower) >= 0 Then
            'タクチケメンテナンス
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenance)
            AddChkArray(cnt, chkArray, URL.TaxiMaintenanceRegist)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMikanryou.ToLower) >= 0 Then
            'タクチケ未完了リスト
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiMikanryou)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMiketsu.ToLower) >= 0 Then
            'タクチケ未決一覧
            cnt = 0
            ReDim chkArray(2)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsu)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsuRegist)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiMiketsuRegist.ToLower) >= 0 Then
            'タクチケ未決登録
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsu)
            AddChkArray(cnt, chkArray, URL.TaxiMiketsuRegist)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiJissekiMiseisanCsv.ToLower) >= 0 Then
            'タクチケ実績未精算CSV
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiJissekiMiseisanCsv)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.TaxiSoufujoIkkatsu.ToLower) >= 0 Then
            '送付状・確認票一括印刷
            cnt = 0
            ReDim chkArray(2)
            AddChkArray(cnt, chkArray, URL.TaxiMenu)
            AddChkArray(cnt, chkArray, URL.TaxiSoufujoIkkatsu)
            AddChkArray(cnt, chkArray, URL.Preview)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.MstShisetsu.ToLower) >= 0 Then
            '施設マスタメンテナンス
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.MstShisetsu)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.MstUser.ToLower) >= 0 Then
            'TOP担当者マスタメンテナンス
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.MstUser)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.MstCode.ToLower) >= 0 Then
            'コードマスタメンテナンス
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.MstCode)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.LogFile.ToLower) >= 0 Then
            '送受信ログ照会
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.LogFile)

            Return IsReferrer(referreUrl, chkArray)

        ElseIf currentUrl.ToLower.IndexOf(URL.LogSousa.ToLower) >= 0 Then
            '操作ログ照会
            cnt = 0
            ReDim chkArray(1)
            AddChkArray(cnt, chkArray, URL.Menu)
            AddChkArray(cnt, chkArray, URL.LogSousa)

            Return IsReferrer(referreUrl, chkArray)
        End If

        Return True

    End Function

    '引数文字列１に文字列配列の値が含まれているかチェックし、
    '含まれる場合「True」、含まれない場合「False」
    Private Shared Function IsReferrer(ByVal referreUrl As String, ByVal chkArray() As String) As Boolean

        Dim cnt As Integer

        For cnt = 0 To chkArray.Length - 1
            '全部小文字にして比較
            If referreUrl.ToLower.IndexOf(chkArray(cnt).ToLower) >= 0 Then
                Return True
            End If

        Next

        Return False

    End Function

    'IsReffererチェック用に、チェック用配列を作成する。
    Private Shared Sub AddChkArray(ByRef cnt As Integer, ByRef wkArray() As String, ByVal wkString As String)

        ReDim Preserve wkArray(cnt)

        wkArray(cnt) = wkString

        cnt += 1

    End Sub


    'データ登録モードを返す
    Public Shared Function IsInsertMode() As Boolean
        If Trim(System.Web.HttpContext.Current.Session(SessionDef.RECORD_KUBUN)) = AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Insert Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsInsertMode(ByVal RECORD_KUBUN As String) As Boolean
        If RECORD_KUBUN = AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Insert Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function IsUpdateMode() As Boolean
        If Trim(System.Web.HttpContext.Current.Session(SessionDef.RECORD_KUBUN)) = AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Update Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsUpdateMode(ByVal RECORD_KUBUN As String) As Boolean
        If RECORD_KUBUN = AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Update Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function IsCancelMode() As Boolean
        If Trim(System.Web.HttpContext.Current.Session(SessionDef.RECORD_KUBUN)) = AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Cancel Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function IsCancelMode(ByVal RECORD_KUBUN As String) As Boolean
        If RECORD_KUBUN = AppConst.KOTSUHOTEL.RECORD_KUBUN.Code.Cancel Then
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

    '登録用システムID
    Public Shared Function GetMaxSYSTEM_ID(ByVal TableType As AppModule.TableType, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wSYSTEM_ID As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Select Case TableType
            Case AppModule.TableType.MS_USER
                strSQL = SQL.MS_USER.MaxSYSTEM_ID()
            Case AppModule.TableType.MS_SHISETSU
                strSQL = SQL.MS_SHISETSU.MaxSYSTEM_ID()
        End Select

        RsData = CmnDb.Read(strSQL, DbConn)
        If RsData.Read() Then
            wSYSTEM_ID = CmnModule.DbVal(CmnDb.DbData(TableDef.MS_USER.Column.SYSTEM_ID, RsData))
        End If
        RsData.Close()
        wSYSTEM_ID += 1

        Return wSYSTEM_ID.ToString.PadLeft(10, "0"c)
    End Function

    'コードマスタ
    Public Shared Function GetMaxDATA_ID(ByVal CODE As String, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wDATA_ID As Integer = 0
        Dim strSQL As String = SQL.MS_CODE.MaxDATA_ID(CODE)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        RsData = CmnDb.Read(strSQL, DbConn)
        If RsData.Read() Then
            wDATA_ID = CmnModule.DbVal(CmnDb.DbData(TableDef.MS_CODE.Column.DATA_ID, RsData))
        End If
        RsData.Close()
        wDATA_ID += 1

        Return wDATA_ID.ToString.PadLeft(2, "0"c)
    End Function

    'コストセンター名
    Public Shared Function GetCostCenterName(ByVal COSTCENTER_CD As String, ByVal DbConn As System.Data.SqlClient.SqlConnection) As String

        Dim strSQL As String = SQL.MS_COSTCENTER.byCOSTCENTER_CD(COSTCENTER_CD)
        Dim MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct = AppModule.GetOneRecord(AppModule.TableType.MS_COSTCENTER, strSQL, DbConn)

        Return MS_COSTCENTER.COSTCENTER_NAME
    End Function

    '精算番号自動採番
    Public Shared Function GetMaxSEISAN_NO(ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
        Dim wSEISAN_NO As Long = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_SEIKYU.MaxSEISAN_NO()

        RsData = CmnDb.Read(strSQL, DbConn)
        If RsData.Read() Then
            wSEISAN_NO = CmnModule.DbVal(CmnDb.DbData(TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR, RsData))
        End If
        RsData.Close()
        wSEISAN_NO += 1

        Return wSEISAN_NO.ToString.PadLeft(14, "0"c)
    End Function

    '承認年月から対象となる精算承認日の期間(FromTo)を取得
    Public Shared Sub GetSeisanFromTo(ByVal shouninY As String, ByVal shouninM As String, ByRef strFromDate As String, ByRef strToDate As String)

        Dim shouninDate As Date = CDate(shouninY & "/" & shouninM & "/01")
        Dim fromDate As Date = shouninDate.AddMonths(-1).Year.ToString & "/" & shouninDate.AddMonths(-1).Month.ToString & "/" & AppConst.SEISAN.START_DAY

        strFromDate = fromDate.ToString("yyyyMMdd")

        '@@@@@
        'strToDate = fromDate.AddMonths(1).ToString("yyyyMM") & "10"
        strToDate = fromDate.AddMonths(1).AddDays(-1).ToString("yyyyMMdd")

    End Sub

    'ログテーブル
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_KOUENKAI.KOUENKAI_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_KAIJO.KOUENKAI_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_KOTSUHOTEL.KOUENKAI_NO _
                     & "／" _
                     & "参加者ID：" & TBL_KOTSUHOTEL.SANKASHA_ID _
                     & "／" _
                     & "MPID：" & TBL_KOTSUHOTEL.DR_MPID

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_SEIKYU As TableDef.TBL_SEIKYU.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_SEIKYU.KOUENKAI_NO _
                     & "／" _
                     & "精算番号：" & TBL_SEIKYU.SEIKYU_NO_TOPTOUR

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_SHOUNIN As TableDef.TBL_SHOUNIN.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "会合番号：" & TBL_SHOUNIN.KOUENKAI_NO _
                     & "／" _
                     & "精算番号：" & TBL_SHOUNIN.SEIKYU_NO_TOPTOUR

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_COST As TableDef.TBL_COST.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "請求番号：" & TBL_COST.SEIKYU_NO _
                     & "／" _
                     & "請求年月：" & TBL_COST.SEIKYU_YM _
                     & "／" _
                     & "コストセンターコード：" & TBL_COST.COSTCENTER_CD

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_COST As TableDef.TBL_COST.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                         ByVal DbTran As System.Data.SqlClient.SqlTransaction) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "請求番号：" & TBL_COST.SEIKYU_NO _
                     & "／" _
                     & "請求年月：" & TBL_COST.SEIKYU_YM _
                     & "／" _
                     & "コストセンターコード：" & TBL_COST.COSTCENTER_CD

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn, DbTran)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal MS_USER As TableDef.MS_USER.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        Dim wStr As String = ""

        TBL_LOG.NOTE = "ログインID：" & MS_USER.LOGIN_ID _
                     & "／" _
                     & "氏名：" & MS_USER.USER_NAME

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal MS_SHISETSU As TableDef.MS_SHISETSU.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "施設名：" & MS_SHISETSU.SHISETSU_NAME

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                     ByVal MS_COSTCENTER As TableDef.MS_COSTCENTER.DataStruct, _
                                     ByVal STATUS_OK As Boolean, _
                                     ByVal Message As String, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "コストセンターコード：" & MS_COSTCENTER.COSTCENTER_CD

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal MS_CODE As TableDef.MS_CODE.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        Dim wStr As String = ""

        Select Case MS_CODE.CODE
            Case AppConst.MS_CODE.SEX
                wStr = "性別"
            Case AppConst.MS_CODE.KOUEN_KAIJO_LAYOUT
                wStr = "レイアウト"
            Case AppConst.MS_CODE.DR_YAKUWARI
                wStr = "参加者役割"
            Case AppConst.MS_CODE.REQ_HOTEL_SMOKING
                wStr = "依頼：ホテル喫煙"
            Case AppConst.MS_CODE.ANS_HOTEL_SMOKING
                wStr = "回答：ホテル喫煙"
            Case AppConst.MS_CODE.KOTSUKIKAN
                wStr = "交通機関"
            Case AppConst.MS_CODE.SEAT
                wStr = "座席区分"
            Case AppConst.MS_CODE.SEAT_KIBOU
                wStr = "座席希望"
            Case AppConst.MS_CODE.REQ_MR_TEHAI
                wStr = "依頼：社員臨席希望"
            Case AppConst.MS_CODE.MR_HOTEL_SMOKING
                wStr = "社員ホテル禁煙"
            Case AppConst.MS_CODE.ROOM_TYPE
                wStr = "宿泊部屋タイプ"
            Case AppConst.MS_CODE.TAXI_KENSHU
                wStr = "タクチケ券種"
            Case AppConst.MS_CODE.TAXI_TESURYO
                wStr = "タクチケ発券手数料単価"
            Case AppConst.MS_CODE.TAXI_SEISAN_TESURYO
                wStr = "タクチケ精算手数料"
            Case AppConst.MS_CODE.TAXI_KAISHA
                wStr = "タクシー会社"
            Case AppConst.MS_CODE.TESURYO
                wStr = "手数料（交通・宿泊）"
            Case AppConst.MS_CODE.REQ_SEAT_KIBOU
                wStr = "依頼：座席希望"
            Case Else
                wStr = MS_CODE.CODE
        End Select

        TBL_LOG.NOTE = "コード：" & wStr

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "タクシー会社：" & TBL_TAXITICKET_HAKKO.TKT_KAISHA _
                     & "／" _
                     & "タクチケ番号：" & TBL_TAXITICKET_HAKKO.TKT_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TKT_KENSHU As String, _
                                         ByVal KOUENKAI_NO As String, _
                                         ByVal SANKASHA_ID As String, _
                                         ByVal TKT_LINE_NO As String, _
                                         ByVal SALEFORCE_ID As String, _
                                         ByVal TIME_STAMP_BYL As String, _
                                         ByVal DR_MPID As String, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'TBL_LOG.NOTE = "券種：" & TKT_KENSHU _
        '             & "／" _
        '             & "会合番号：" & KOUENKAI_NO _
        '             & "／" _
        '             & "参加者ID：" & SANKASHA_ID _
        '             & "／" _
        '             & "行番号：" & TKT_LINE_NO _
        '             & "／" _
        '             & "SalesForceID：" & SALEFORCE_ID _
        '             & "／" _
        '             & "タイムスタンプBYL：" & TIME_STAMP_BYL _
        '             & "／" _
        '             & "MPID：" & DR_MPID

        TBL_LOG.NOTE = "券種：" & TKT_KENSHU _
                     & "／" _
                     & "会合番号：" & KOUENKAI_NO _
                     & "／" _
                     & "参加者ID：" & SANKASHA_ID _
                     & "／" _
                     & "行番号：" & TKT_LINE_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, TBL_LOG.NOTE, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct, _
                                         ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal TableName As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                         Optional ByVal DbTran As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        If STATUS_OK = False Then
            TBL_LOG.NOTE = Message & "　" & vbNewLine
        End If
        'TBL_LOG.NOTE &= "タクシーチケット番号：" & TBL_TAXITICKET_HAKKO.TKT_NO _
        '             & "／" _
        '             & "会合番号：" & TBL_TAXITICKET_HAKKO.KOUENKAI_NO _
        '             & "／" _
        '             & "参加者ID：" & TBL_TAXITICKET_HAKKO.SANKASHA_ID _
        '             & "／" _
        '             & "行番号：" & TBL_TAXITICKET_HAKKO.TKT_LINE_NO _
        '             & "／" _
        '             & "SalesForceID：" & TBL_TAXITICKET_HAKKO.SALEFORCE_ID _
        '             & "／" _
        '             & "タイムスタンプBYL：" & TBL_TAXITICKET_HAKKO.TIME_STAMP_BYL _
        '             & "／" _
        '             & "MPID：" & TBL_TAXITICKET_HAKKO.DR_MPID

        TBL_LOG.NOTE &= "タクシーチケット番号：" & TBL_TAXITICKET_HAKKO.TKT_NO _
                     & "／" _
                     & "会合番号：" & TBL_TAXITICKET_HAKKO.KOUENKAI_NO _
                     & "／" _
                     & "参加者ID：" & TBL_TAXITICKET_HAKKO.SANKASHA_ID _
                     & "／" _
                     & "行番号：" & TBL_TAXITICKET_HAKKO.TKT_LINE_NO

        If TableName <> "" Then
            TBL_LOG.TABLE_NAME = TableName
        End If

        If DbTran Is Nothing Then
            Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, "", DbConn)
        Else
            Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, "", DbConn, DbTran)
        End If
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        TBL_LOG = GetValue_TBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message)

        Dim strSQL As String

        Try
            strSQL = SQL.TBL_LOG.Insert(TBL_LOG)
            CmnDb.Execute(strSQL, DbConn)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                         ByVal DbTran As System.Data.SqlClient.SqlTransaction) As Boolean

        TBL_LOG = GetValue_TBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message)

        Dim strSQL As String

        Try
            strSQL = SQL.TBL_LOG.Insert(TBL_LOG)
            CmnDb.Execute(strSQL, DbConn, DbTran)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        TBL_LOG = GetValue_TBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message)

        Dim strSQL As String

        Try
            strSQL = SQL.TBL_LOG.Insert(TBL_LOG)
            CmnDb.Execute(strSQL, DbConn)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                         ByVal DbTran As System.Data.SqlClient.SqlTransaction) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        TBL_LOG = GetValue_TBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message)

        Dim strSQL As String

        Try
            strSQL = SQL.TBL_LOG.Insert(TBL_LOG)
            CmnDb.Execute(strSQL, DbConn, DbTran)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Shared Function GetValue_TBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                            ByVal TBL_LOG As TableDef.TBL_LOG.DataStruct, _
                                            ByVal STATUS_OK As Boolean, _
                                            ByVal Message As String) As TableDef.TBL_LOG.DataStruct

        TBL_LOG.INPUT_DATE = CmnModule.GetSysDateTime()
        TBL_LOG.INPUT_USER = System.Web.HttpContext.Current.Session.Item(SessionDef.LoginID)
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.GAMEN

        '処理名
        Select Case GamenType
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KouenkaiRegist
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.DrRegist
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.DrRegist
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KaijoRegist
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.KaijoRegist
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.SeisanRegist
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.CostRegist
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.CostRegist
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstShisetsu
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstUser
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstUser
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCode
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCostcenter
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.MstCostcenter
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiNouhinTorikomi
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiNouhinTorikomi
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiPrintCsv
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiScan
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMaintenance
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMaintenance
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJisseki
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJissekiOTH
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJissekiOTH
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiSeisanMikanryou
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiSeisanMikanryou
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMiketsu
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMeisaiCsv
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMeisaiCsv
            Case Else
                TBL_LOG.SYORI_NAME = "画面名 エラー"
        End Select

        'テーブル名
        If TBL_LOG.TABLE_NAME = "" Then
            Select Case GamenType
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist
                    TBL_LOG.TABLE_NAME = "TBL_KOUENKAI"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KaijoRegist
                    TBL_LOG.TABLE_NAME = "TBL_KAIJO"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.DrRegist
                    TBL_LOG.TABLE_NAME = "TBL_KOTSUHOTEL"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.SeisanRegist
                    TBL_LOG.TABLE_NAME = "TBL_SEIKYU"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.CostRegist
                    TBL_LOG.TABLE_NAME = "TBL_COST"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstShisetsu
                    TBL_LOG.TABLE_NAME = "MS_SHISETSU"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstUser
                    TBL_LOG.TABLE_NAME = "MS_USER"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCode
                    TBL_LOG.TABLE_NAME = "MS_CODE"
                Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.MstCostcenter
                    TBL_LOG.TABLE_NAME = "MS_COSTCENTER"
                Case Else
                    TBL_LOG.TABLE_NAME = ""
            End Select
        End If

        If STATUS_OK = True Then
            TBL_LOG.STATUS = AppConst.TBL_LOG.STATUS.Code.OK
            If Trim(Message) <> "" Then
                TBL_LOG.NOTE = Trim(Message)
            End If
        Else
            TBL_LOG.STATUS = AppConst.TBL_LOG.STATUS.Code.NG
            If Trim(TBL_LOG.NOTE) <> "" Then TBL_LOG.NOTE &= "　"

            Dim wStr As String = ""
            If InStr(Message, "    SQL：") > 0 Then
                wStr = Mid(Message, 1, InStr(Message, "    SQL："))
            Else
                wStr = Message
            End If
            TBL_LOG.NOTE &= wStr
        End If

        Return TBL_LOG
    End Function

    '不要なセッションを破棄
    Public Shared Sub ClearSession()
        Dim SessionItemNames() As String
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        'ログイン以外のセッションを破棄
        ReDim SessionItemNames(wCnt)
        For Each ItemName As String In System.Web.HttpContext.Current.Session.Contents
            Select Case Trim(ItemName).ToLower
                Case Trim(SessionDef.LoginID.ToLower), Trim(SessionDef.MS_USER.ToLower), Trim(SessionDef.MS_CODE.ToLower)
                Case Else
                    If Trim(ItemName) <> "" Then
                        ReDim Preserve SessionItemNames(wCnt)
                        SessionItemNames(wCnt) = ItemName
                        wFlag = True
                        wCnt += 1
                    End If
            End Select
        Next
        If wFlag = True Then
            For wCnt = LBound(SessionItemNames) To UBound(SessionItemNames)
                System.Web.HttpContext.Current.Session.Remove(SessionItemNames(wCnt))
            Next wCnt
        End If
    End Sub


    '== CSV ==
    Public Class Csv
        Public Shared Function DrCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim KEI_HOTELHI As Long = 0
            Dim KEI_HOTELHI_CANCEL As Long = 0 '宿泊取消料
            Dim KEI_HOTELHI_TOTAL As Long = 0 '宿泊費+宿泊取消料
            Dim KEI_HOTELHI_TOZEI As Long = 0
            Dim KEI_RAIL_FARE As Long = 0
            Dim KEI_RAIL_CANCELLATION As Long = 0 'JR取消料
            Dim KEI_RAIL_TOTAL As Long = 0 'JR代+JR取消料
            Dim KEI_AIR_FARE As Long = 0
            Dim KEI_AIR_CANCELLATION As Long = 0 '航空券取消料
            Dim KEI_AIR_TOTAL As Long = 0 '航空券代+航空券取消料
            Dim KEI_OTHER_FARE As Long = 0
            Dim KEI_OTHER_CANCELLATION As Long = 0 'その他鉄道取消料
            Dim KEI_OTHER_TOTAL As Long = 0 'その他鉄道等費用+その他鉄道取消料
            Dim KEI_KOTSUHOTEL_TESURYO As Long = 0
            Dim KEI_TAXI_TESURYO As Long = 0
            Dim KEI_SANKASHA_TOTAL As Long = 0

            '税率取得
            Dim strZeiRate As String = AppModule.GetZeiRate(CsvData(wCnt).FROM_DATE, DbConn)

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード"))) '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))  '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("指定外申請理由")))  '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠状況")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊取消料(込)")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費+宿泊取消料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費都税(-)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR取消料(込)")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代+JR取消料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券取消料(込)")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代+航空券取消料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道等費用(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道取消料(込)")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道等費用+その他鉄道取消料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("登録手数料(込)")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者旅費合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのBU")))  '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのエリア名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの営業所名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先FS")))    '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先(その他)")))  '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Cost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal order")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("zetia Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Timestamp(BYL)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊手配(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊依頼内容(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊日(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("泊数(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ホテル喫煙(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL宿泊備考(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Timestamp(TOP)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("泊数(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊施設名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊部屋タイプ(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ホテル喫煙(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP宿泊備考(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊先電話番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL交通備考(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP交通備考(回答)"), True))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                Dim HOTELHI_TOTAL As Long = 0 '宿泊費+宿泊取消料
                Dim RAIL_TOTAL As Long = 0 'JR代+JR取消料
                Dim AIR_TOTAL As Long = 0 '航空券代+航空券取消料
                Dim OTHER_TOTAL As Long = 0 'その他鉄道等費用+その他鉄道取消料
                Dim SANKASHA_TOTAL As Long = 0 '参加者旅費合計

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_YAKUWARI(CsvData(wCnt).DR_YAKUWARI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHITEIGAI_RIYU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_SANKA(CsvData(wCnt).DR_SANKA))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_CANCEL))))

                HOTELHI_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI) + _
                                CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_CANCEL)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(HOTELHI_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_TOZEI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_CANCELLATION))))

                RAIL_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_FARE) + _
                             CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_CANCELLATION)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(RAIL_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_CANCELLATION))))

                AIR_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_FARE) + _
                            CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_CANCELLATION)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AIR_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_CANCELLATION))))

                OTHER_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_FARE) + _
                              CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_CANCELLATION)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(OTHER_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_TAXI_TESURYO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO))))

                SANKASHA_TOTAL = HOTELHI_TOTAL + RAIL_TOTAL + AIR_TOTAL + OTHER_TOTAL + _
                                 CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO) + _
                                 CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_TAXI_TESURYO) + _
                                 CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_TOZEI)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SANKASHA_TOTAL)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_FS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_OTHER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_STATUS_TEHAI(CsvData(wCnt).REQ_STATUS_TEHAI, False, True))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TIME_STAMP_BYL(CsvData(wCnt).TIME_STAMP_BYL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_HOTEL_IRAINAIYOU(CsvData(wCnt).HOTEL_IRAINAIYOU))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).REQ_HOTEL_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_HAKUSU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_HOTEL_SMOKING(CsvData(wCnt).REQ_HOTEL_SMOKING))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TIME_STAMP_TOP(CsvData(wCnt).TIME_STAMP_TOP))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_TEHAI(CsvData(wCnt).ANS_STATUS_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_HOTEL(CsvData(wCnt).ANS_STATUS_HOTEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).ANS_HOTEL_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HAKUSU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_ROOM_TYPE(CsvData(wCnt).ANS_ROOM_TYPE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_HOTEL_SMOKING(CsvData(wCnt).ANS_HOTEL_SMOKING))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_TEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_KOTSU_BIKO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_1, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_1(CsvData(wCnt).ANS_O_TIME1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_1(CsvData(wCnt).ANS_O_TIME2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_1(CsvData(wCnt).ANS_O_SEAT_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_1(CsvData(wCnt).ANS_O_SEAT_KIBOU1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_2, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_2(CsvData(wCnt).ANS_O_TIME1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_2(CsvData(wCnt).ANS_O_TIME2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_2(CsvData(wCnt).ANS_O_SEAT_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_2(CsvData(wCnt).ANS_O_SEAT_KIBOU2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_3, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_3(CsvData(wCnt).ANS_O_TIME1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_3(CsvData(wCnt).ANS_O_TIME2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_3(CsvData(wCnt).ANS_O_SEAT_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_3(CsvData(wCnt).ANS_O_SEAT_KIBOU3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_4, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_4(CsvData(wCnt).ANS_O_TIME1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_4(CsvData(wCnt).ANS_O_TIME2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_4(CsvData(wCnt).ANS_O_SEAT_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_4(CsvData(wCnt).ANS_O_SEAT_KIBOU4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_5, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_5(CsvData(wCnt).ANS_O_TIME1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_5(CsvData(wCnt).ANS_O_TIME2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_5(CsvData(wCnt).ANS_O_SEAT_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_5(CsvData(wCnt).ANS_O_SEAT_KIBOU5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_1, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_1(CsvData(wCnt).ANS_F_TIME1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_1(CsvData(wCnt).ANS_F_TIME2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_1(CsvData(wCnt).ANS_F_SEAT_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_1(CsvData(wCnt).ANS_F_SEAT_KIBOU1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_2, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_2(CsvData(wCnt).ANS_F_TIME1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_2(CsvData(wCnt).ANS_F_TIME2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_2(CsvData(wCnt).ANS_F_SEAT_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_2(CsvData(wCnt).ANS_F_SEAT_KIBOU2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_3, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_3(CsvData(wCnt).ANS_F_TIME1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_3(CsvData(wCnt).ANS_F_TIME2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_3(CsvData(wCnt).ANS_F_SEAT_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_3(CsvData(wCnt).ANS_F_SEAT_KIBOU3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_4, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_4(CsvData(wCnt).ANS_F_TIME1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_4(CsvData(wCnt).ANS_F_TIME2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_4(CsvData(wCnt).ANS_F_SEAT_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_4(CsvData(wCnt).ANS_F_SEAT_KIBOU4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_5, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_5(CsvData(wCnt).ANS_F_TIME1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_5(CsvData(wCnt).ANS_F_TIME2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_5(CsvData(wCnt).ANS_F_SEAT_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_5(CsvData(wCnt).ANS_F_SEAT_KIBOU5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_KOTSU_BIKO), True))
                sb.Append(vbNewLine)

                KEI_HOTELHI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI)
                KEI_HOTELHI_CANCEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_CANCEL)
                KEI_HOTELHI_TOTAL += HOTELHI_TOTAL
                KEI_HOTELHI_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_TOZEI)
                KEI_RAIL_FARE += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_FARE)
                KEI_RAIL_CANCELLATION += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_CANCELLATION)
                KEI_RAIL_TOTAL += RAIL_TOTAL
                KEI_AIR_FARE += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_FARE)
                KEI_AIR_CANCELLATION += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_CANCELLATION)
                KEI_AIR_TOTAL += AIR_TOTAL
                KEI_OTHER_FARE += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_FARE)
                KEI_OTHER_CANCELLATION += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_CANCELLATION)
                KEI_OTHER_TOTAL += OTHER_TOTAL
                KEI_KOTSUHOTEL_TESURYO += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO)
                KEI_TAXI_TESURYO += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_TAXI_TESURYO)
            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI_CANCEL)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI_TOTAL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_RAIL_FARE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_RAIL_CANCELLATION)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_RAIL_TOTAL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_AIR_FARE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_AIR_CANCELLATION)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_AIR_TOTAL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_OTHER_FARE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_OTHER_CANCELLATION)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_OTHER_TOTAL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_TAXI_TESURYO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_KOTSUHOTEL_TESURYO)))

            'KEI_SANKASHA_TOTAL = KEI_HOTELHI_TOTAL + KEI_RAIL_TOTAL + KEI_AIR_TOTAL + KEI_OTHER_TOTAL + _
            '                     KEI_KOTSUHOTEL_TESURYO + _
            '                     KEI_TAXI_TESURYO + _
            '                     KEI_HOTELHI_TOZEI
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_SANKASHA_TOTAL)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        Public Shared Function MrCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim strCostCenter As String = ""
            Dim COSTKEI_MR_HOTEL As Long = 0
            Dim COSTKEI_MR_HOTEL_TOZEI As Long = 0
            Dim COSTKEI_MR_JR As Long = 0

            Dim KEI_MR_HOTEL As Long = 0
            Dim KEI_MR_HOTEL_TOZEI As Long = 0
            Dim KEI_MR_JR As Long = 0

            '税率取得
            Dim strZeiRate As String = AppModule.GetZeiRate(CsvData(wCnt).FROM_DATE, DbConn)

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属BU(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属エリア(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属営業所(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員氏名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL社員用備考(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用往路隣席希望(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用復路隣席希望(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP社員用備考(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費(非課税)(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費都税(非課税)(-)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費(非課税)(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名"), True))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                If strCostCenter <> "" AndAlso _
                   strCostCenter <> CsvData(wCnt).COST_CENTER Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計(込)")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL_TOZEI)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_JR)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL + COSTKEI_MR_HOTEL_TOZEI + COSTKEI_MR_JR)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
                    sb.Append(vbNewLine)

                    '初期化
                    COSTKEI_MR_HOTEL = 0
                    COSTKEI_MR_HOTEL_TOZEI = 0
                    COSTKEI_MR_JR = 0
                End If

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_MR_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_MR_O_TEHAI(CsvData(wCnt).ANS_MR_O_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_MR_F_TEHAI(CsvData(wCnt).ANS_MR_F_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTELHI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_KOTSUHI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME), True))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL) + _
                '                                       CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI) + _
                '                                       CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR)), True))
                sb.Append(vbNewLine)

                strCostCenter = CsvData(wCnt).COST_CENTER

                'コストセンター計　加算
                COSTKEI_MR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI)
                COSTKEI_MR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)
                COSTKEI_MR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)

                '合計　加算
                KEI_MR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI)
                KEI_MR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)
                KEI_MR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_JR)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL + COSTKEI_MR_HOTEL_TOZEI + COSTKEI_MR_JR), True))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_JR)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL + KEI_MR_HOTEL_TOZEI + KEI_MR_JR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        Public Shared Function TaxiSeisanCsv(ByVal CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct, _
                                             ByVal DbConn As System.Data.SqlClient.SqlConnection) As String

            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim strKazeiKbn As String = ""
            Dim strCostCenter As String = ""
            Dim TKT_URIAGE As Long = 0
            Dim TKT_SEISAN_FEE As Long = 0
            Dim KAZEIKEI_TKT_URIAGE As Long = 0
            Dim KAZEIKEI_TKT_SEISAN_FEE As Long = 0

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("課税区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用年月日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("売上金額")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号"), True))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                If (strCostCenter <> "" AndAlso _
                   strCostCenter <> CsvData(wCnt).COST_CENTER) OrElse _
                   (strKazeiKbn <> "" AndAlso _
                   strKazeiKbn <> CsvData(wCnt).KAZEI_KBN) Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計 " & strKazeiKbn)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_URIAGE)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_SEISAN_FEE)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
                    sb.Append(vbNewLine)

                    '初期化
                    TKT_URIAGE = 0
                    TKT_SEISAN_FEE = 0
                End If

                If strKazeiKbn <> "" AndAlso _
                   strKazeiKbn <> CsvData(wCnt).KAZEI_KBN Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計 " & strKazeiKbn)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAZEIKEI_TKT_URIAGE)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAZEIKEI_TKT_SEISAN_FEE)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
                    sb.Append(vbNewLine)

                    '初期化
                    KAZEIKEI_TKT_URIAGE = 0
                    KAZEIKEI_TKT_SEISAN_FEE = 0
                End If

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAZEI_KBN)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).REQ_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_URIAGE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_SEISAN_FEE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR), True))
                sb.Append(vbNewLine)

                strKazeiKbn = CsvData(wCnt).KAZEI_KBN
                strCostCenter = CsvData(wCnt).COST_CENTER

                'コストセンター計　加算
                TKT_URIAGE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE)
                TKT_SEISAN_FEE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE)

                '課税区分合計　加算
                KAZEIKEI_TKT_URIAGE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE)
                KAZEIKEI_TKT_SEISAN_FEE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE)
            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計 " & strKazeiKbn)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_URIAGE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_SEISAN_FEE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計 " & strKazeiKbn)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAZEIKEI_TKT_URIAGE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAZEIKEI_TKT_SEISAN_FEE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        Public Shared Function SapCsv(ByVal CsvData() As TableDef.SAP_CSV.DataStruct) As String

            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KUBUN)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAISHA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_YMD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DENPYO_TYPE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYUSHO_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DOC_HTEXT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WAERS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZFBDT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZTERM)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).XMWST)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).NEWBS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KINGAKU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZEI_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIGOU_MEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).PAYMENT_BLOCK)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BARCODE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ASSIGNMENT), True))
                sb.Append(vbNewLine)
            Next

            Return sb.ToString

        End Function

        Public Shared Function SapTopTourCsv(ByVal CsvData() As TableDef.SAP_CSV.DataStruct) As String

            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KUBUN)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAISHA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_YMD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DENPYO_TYPE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYUSHO_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DOC_HTEXT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WAERS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZFBDT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZTERM)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).XMWST)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).NEWBS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KINGAKU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZEI_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIGOU_MEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).PAYMENT_BLOCK)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BARCODE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ASSIGNMENT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DANTAI_CODE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME))
                sb.Append(vbNewLine)
            Next

            Return sb.ToString

        End Function

        Public Shared Function SapEvidenceCsv(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As String

            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ出力
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("トップツアー精算年月")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("支払番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("承認区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算承認日")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("総合計金額")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("飲食費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("機材費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(非課税)991330401")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("東京都宿泊税(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道等費用(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("スタッフ費用(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("管理費(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配手数料(宿泊・交通)(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(非課税)41120200")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("非課税金額合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("飲食費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("機材費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(課税)991330401")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("スタッフ費用(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("管理費(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(課税)41120200")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("課税金額合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員東京都宿泊税")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金(エンタ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(エンタ)"), True))
            sb.Append(vbNewLine)

            '集計行用
            Dim lngTotalSougouKei As Long = 0

            Dim lngTotalKAIJOHI_TF As Long = 0
            Dim lngTotalINSHOKUHI_TF As Long = 0
            Dim lngTotalKIZAIHI_TF As Long = 0
            Dim lngTotalKEI_991330401_TF As Long = 0

            Dim lngTotalHOTELHI_TF As Long = 0
            Dim lngTotalHOTELHI_TOZEI As Long = 0
            Dim lngTotalAIR_TF As Long = 0
            Dim lngTotalJR_TF As Long = 0
            Dim lngTotalOTHER_TRAFFIC_TF As Long = 0
            Dim lngTotalJINKENHI_TF As Long = 0
            Dim lngTotalKANRIHI_TF As Long = 0
            Dim lngTotalHOTEL_COMMISSION_TF As Long = 0
            Dim lngTotalTAXI_COMMISSION_TF As Long = 0
            Dim lngTotalOTHER_TF As Long = 0
            Dim lngTotalTAXI_TF As Long = 0
            Dim lngTotalTAXI_SEISAN_TF As Long = 0
            Dim lngTotalKEI_41120200_TF As Long = 0

            Dim lngTotalKEI_TF As Long = 0

            Dim lngTotalKAIJOUHI_T As Long = 0
            Dim lngTotalINSHOKUHI_T As Long = 0
            Dim lngTotalKIZAIHI_T As Long = 0
            Dim lngTotalKEI_991330401_T As Long = 0

            Dim lngTotalJINKENHI_T As Long = 0
            Dim lngTotalKANRIHI_T As Long = 0
            Dim lngTotalOTHER_T As Long = 0
            Dim lngTotalKEI_41120200_T As Long = 0

            Dim lngTotalKEI_T As Long = 0

            Dim lngTotalMR_HOTEL As Long = 0
            Dim lngTotalMR_HOTEL_TOZEI As Long = 0
            Dim lngTotalMR_JR As Long = 0

            Dim lngTotalTAXI_T As Long = 0
            Dim lngTotalTAXI_SEISAN_T As Long = 0

            '明細行出力
            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEISAN_YM)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHIHARAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SHOUNIN_KUBUN(CsvData(wCnt).SHOUNIN_KUBUN))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHOUNIN_DATE)))

                '総合計金額
                Dim lngSougouKei As Long = CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_TF) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_T) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_T) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_T)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngSougouKei.ToString)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).AIR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TRAFFIC_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTEL_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_JR)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_T), True))

                sb.Append(vbNewLine)

                '集計行用に加算
                lngTotalSougouKei += lngSougouKei
                lngTotalKAIJOHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KAIJOHI_TF)
                lngTotalINSHOKUHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).INSHOKUHI_TF)
                lngTotalKIZAIHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KIZAIHI_TF)
                lngTotalKEI_991330401_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_991330401_TF)

                lngTotalHOTELHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTELHI_TF)
                lngTotalHOTELHI_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTELHI_TOZEI)
                lngTotalAIR_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).AIR_TF)
                lngTotalJR_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).JR_TF)
                lngTotalOTHER_TRAFFIC_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_TRAFFIC_TF)
                lngTotalJINKENHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).JINKENHI_TF)
                lngTotalKANRIHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KANRIHI_TF)
                lngTotalHOTEL_COMMISSION_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTEL_COMMISSION_TF)
                lngTotalTAXI_COMMISSION_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_COMMISSION_TF)
                lngTotalOTHER_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_TF)
                lngTotalTAXI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_TF)
                lngTotalTAXI_SEISAN_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_TF)
                lngTotalKEI_41120200_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_41120200_TF)

                lngTotalKEI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_TF)
                lngTotalKAIJOUHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KAIJOUHI_T)
                lngTotalINSHOKUHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).INSHOKUHI_T)
                lngTotalKIZAIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KIZAIHI_T)
                lngTotalKEI_991330401_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_991330401_T)

                lngTotalJINKENHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).JINKENHI_T)
                lngTotalKANRIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KANRIHI_T)
                lngTotalOTHER_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_T)
                lngTotalKEI_41120200_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_41120200_T)

                lngTotalKEI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_T)

                lngTotalMR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL)
                lngTotalMR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI)
                lngTotalMR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR)

                lngTotalTAXI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_T)
                lngTotalTAXI_SEISAN_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_T)
            Next

            '集計行出力
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalSougouKei.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKAIJOHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalINSHOKUHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKIZAIHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_991330401_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTELHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTELHI_TOZEI.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalAIR_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJR_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_TRAFFIC_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJINKENHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKANRIHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTEL_COMMISSION_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_COMMISSION_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_SEISAN_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_41120200_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKAIJOUHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalINSHOKUHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKIZAIHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_991330401_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJINKENHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKANRIHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_41120200_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_HOTEL.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_HOTEL_TOZEI.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_JR.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_SEISAN_T.ToString), True))

            sb.Append(vbNewLine)

            Return sb.ToString

        End Function

        Public Shared Function TaxiMiketsu(ByVal CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列 必要?
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開催日From")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開催日To")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP担当者")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("備考")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算年月")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID(日)")))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TO_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).USER_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
                Select Case CsvData(wCnt).TKT_LINE_NO
                    Case 1
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_1)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_1)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_1)))
                    Case 2
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_2)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_2)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_2)))
                    Case 3
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_3)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_3)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_3)))
                    Case 4
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_4)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_4)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_4)))
                    Case 5
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_5)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_5)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_5)))
                    Case 6
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_6)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_6)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_6)))
                    Case 7
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_7)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_7)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_7)))
                    Case 8
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_8)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_8)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_8)))
                    Case 9
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_9)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_9)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_9)))
                    Case 10
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_10)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_10)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_10)))
                    Case 11
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_11)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_11)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_11)))
                    Case 12
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_12)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_12)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_12)))
                    Case 13
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_13)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_13)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_13)))
                    Case 14
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_14)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_14)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_14)))
                    Case 15
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_15)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_15)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_15)))
                    Case 16
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_16)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_16)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_16)))
                    Case 17
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_17)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_17)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_17)))
                    Case 18
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_18)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_18)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_18)))
                    Case 19
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_19)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_19)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_19)))
                    Case 20
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_20)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_HAKKO_DATE_20)))
                        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS_20)))
                End Select
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_USED_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_SEIKYU_YM)))
                If CsvData(wCnt).TKT_VOID = CmnConst.Flag.On Then
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).UPDATE_DATE.Substring(0, 8))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                End If
                sb.Append(vbNewLine)
            Next wCnt

            Return sb.ToString
        End Function

        Public Shared Function TaxiMaintenance(ByVal CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列 必要?
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開催日From")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開催日To")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP担当者")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算年月")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID(日)")))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TO_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).USER_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_USED_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_SEIKYU_YM)))
                If CsvData(wCnt).TKT_VOID = CmnConst.Flag.On Then
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).UPDATE_DATE.Substring(0, 8))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                End If
                sb.Append(vbNewLine)
            Next wCnt

            Return sb.ToString
        End Function

        Public Shared Function Mikanryou(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列 必要?
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開催日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG №")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者")))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                sb.Append(vbNewLine)
            Next wCnt

            Return sb.ToString
        End Function

        'タクチケ関連
        '印刷用データ
        Public Class TaxiPrintCsv
            Public Class CsvIndex
                Public Const TAXI_DATE As Integer = 0
                Public Const TAXI_PRT_NAME As Integer = 1
                Public Const TAXI_DATE_MM As Integer = 2
                Public Const TAXI_DATE_DD As Integer = 3
                Public Const SANKASHA_ID As Integer = 4
                Public Const TAXI_KENSHU As Integer = 5
                Public Const TAXI_HAKKO_DATE As Integer = 6
                Public Const TKT_LINE_NO As Integer = 7
                Public Const TKT_KAISHA As Integer = 8
                Public Const KOUENKAI_NO As Integer = 9
                Public Const SALEFORCE_ID As Integer = 10
                Public Const TIME_STAMP_BYL As Integer = 11
                Public Const DR_NAME As Integer = 12
                Public Const BARCODE As Integer = 13
            End Class
            'バーコード
            Public Class Barcode
                <Serializable()> Public Structure DataStruct
                    Public SALEFORCE_ID As String
                    Public SANKASHA_ID As String
                    Public KOUENKAI_NO As String
                    Public TIME_STAMP_BYL As String
                    Public DR_MPID As String
                    Public TKT_LINE_NO As String
                End Structure
                Public Class Length
                    Public Const SALEFORCE_ID As Integer = 18
                    Public Const SANKASHA_ID As Integer = 14
                    Public Const KOUENKAI_NO As Integer = 14
                    Public Const TIME_STAMP_BYL As Integer = 14
                    Public Const DR_MPID As Integer = 16
                    Public Const TKT_LINE_NO As Integer = 2
                End Class
                Public Class CsvIndex
                    Public Const SALEFORCE_ID As Integer = 0
                    Public Const SANKASHA_ID As Integer = 1
                    Public Const KOUENKAI_NO As Integer = 2
                    Public Const TIME_STAMP_BYL As Integer = 3
                    Public Const DR_MPID As Integer = 4
                    Public Const TKT_LINE_NO As Integer = 5
                End Class
            End Class
        End Class

        'タクチケスキャンデータ
        Public Class TaxiScan
            <Serializable()> Public Structure DataStruct
                Public SALEFORCE_ID As String
                Public SANKASHA_ID As String
                Public KOUENKAI_NO As String
                Public TIME_STAMP_BYL As String
                Public DR_MPID As String
                Public TKT_LINE_NO As String
                Public TKT_NO As String
            End Structure
            Public Class Length
                Public Const SALEFORCE_ID As Integer = 18
                Public Const SANKASHA_ID As Integer = 14
                Public Const KOUENKAI_NO As Integer = 14
                Public Const TIME_STAMP_BYL As Integer = 14
                Public Const DR_MPID As Integer = 16
                Public Const TKT_LINE_NO As Integer = 2
                Public Const TKT_NO As Integer = 9
            End Class
            Public Class CsvIndex
                Public Const SALEFORCE_ID As Integer = 0
                Public Const SANKASHA_ID As Integer = 1
                Public Const KOUENKAI_NO As Integer = 2
                Public Const TIME_STAMP_BYL As Integer = 3
                Public Const DR_MPID As Integer = 4
                Public Const TKT_LINE_NO As Integer = 5
                Public Const TKT_NO As Integer = 6
            End Class
        End Class

        '新着交通・宿泊一覧CSV
        Public Shared Function NewDrCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.FROM_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TO_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.DR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TIME_STAMP_BYL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.INPUT_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.USER_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.REQ_STATUS_TEHAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_KOTSU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_TAXI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_MR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KINKYU_FLAG)))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TO_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).USER_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_STATUS_TEHAI(CsvData(wCnt).REQ_STATUS_TEHAI, False, True))))
                '宿泊
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL))))
                '交通
                If CsvData(wCnt).REQ_O_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No))))
                End If
                'タクチケ
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_TEHAI_TAXI(CsvData(wCnt).TEHAI_TAXI))))
                'MR手配
                If CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                    CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                    CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                    CsvData(wCnt).REQ_MR_HOTEL_NOTE.Trim <> "" OrElse _
                    CsvData(wCnt).ANS_MR_HOTEL_NOTE.Trim <> "" Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No))))
                End If
                '緊急
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_KINKYU_FLAG(CsvData(wCnt).KINKYU_FLAG))))

                sb.Append(vbNewLine)
            Next wCnt
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        '検索交通・宿泊一覧CSV
        Public Shared Function DrKensakuCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.FROM_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TO_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.DR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TIME_STAMP_BYL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.INPUT_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.USER_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.REQ_STATUS_TEHAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_KOTSU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_TAXI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.TEHAI_MR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.KINKYU_FLAG)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TableDef.NEW_DR_CSV.Name.SEND_FLAG)))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TO_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).USER_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_STATUS_TEHAI(CsvData(wCnt).REQ_STATUS_TEHAI, False, True))))
                '宿泊
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL))))
                '交通
                If CsvData(wCnt).REQ_O_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_O_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                    CsvData(wCnt).REQ_F_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No))))
                End If
                'タクチケ
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_TEHAI_TAXI(CsvData(wCnt).TEHAI_TAXI))))
                'MR手配
                If CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                    CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                    CsvData(wCnt).REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                    CsvData(wCnt).REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                    CsvData(wCnt).REQ_MR_HOTEL_NOTE.Trim <> "" OrElse _
                    CsvData(wCnt).ANS_MR_HOTEL_NOTE.Trim <> "" Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes))))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No))))
                End If
                '緊急
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetMark_KINKYU_FLAG(CsvData(wCnt).KINKYU_FLAG))))
                'NZ送信
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_FLAG(CsvData(wCnt).SEND_FLAG, True))))

                sb.Append(vbNewLine)
            Next wCnt
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        '会合費用総合一覧表CSV

        Public Shared Function KaigouHiyouCsv(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As String

            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ出力
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SRM発注区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("トップツアー精算年月")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("支払番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("承認区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算承認日")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("総合計金額")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("飲食費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("機材費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(非課税)991330401")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("入湯税・宿泊税(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他交通費用(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("スタッフ費用(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("管理費(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配手数料(宿泊・交通)(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(非課税)41120200")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("非課税金額合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("飲食費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("機材費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(課税)991330401")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("スタッフ費用(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("管理費(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(課税)41120200")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("課税金額合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員入湯税・宿泊税")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金(エンタ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(エンタ)")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("製品名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order（非課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order（課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code（非課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code（課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Cost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Zetia Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者BU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者エリア")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者営業所")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP送信日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("NZ送信"), True))

            sb.Append(vbNewLine)

            '集計行用
            Dim lngTotalSougouKei As Long = 0

            Dim lngTotalKAIJOHI_TF As Long = 0
            Dim lngTotalINSHOKUHI_TF As Long = 0
            Dim lngTotalKIZAIHI_TF As Long = 0
            Dim lngTotalKEI_991330401_TF As Long = 0

            Dim lngTotalHOTELHI_TF As Long = 0
            Dim lngTotalHOTELHI_TOZEI As Long = 0
            Dim lngTotalAIR_TF As Long = 0
            Dim lngTotalJR_TF As Long = 0
            Dim lngTotalOTHER_TRAFFIC_TF As Long = 0
            Dim lngTotalJINKENHI_TF As Long = 0
            Dim lngTotalKANRIHI_TF As Long = 0
            Dim lngTotalHOTEL_COMMISSION_TF As Long = 0
            Dim lngTotalTAXI_COMMISSION_TF As Long = 0
            Dim lngTotalOTHER_TF As Long = 0
            Dim lngTotalTAXI_TF As Long = 0
            Dim lngTotalTAXI_SEISAN_TF As Long = 0
            Dim lngTotalKEI_41120200_TF As Long = 0

            Dim lngTotalKEI_TF As Long = 0

            Dim lngTotalKAIJOUHI_T As Long = 0
            Dim lngTotalINSHOKUHI_T As Long = 0
            Dim lngTotalKIZAIHI_T As Long = 0
            Dim lngTotalKEI_991330401_T As Long = 0

            Dim lngTotalJINKENHI_T As Long = 0
            Dim lngTotalKANRIHI_T As Long = 0
            Dim lngTotalOTHER_T As Long = 0
            Dim lngTotalKEI_41120200_T As Long = 0

            Dim lngTotalKEI_T As Long = 0

            Dim lngTotalMR_HOTEL As Long = 0
            Dim lngTotalMR_HOTEL_TOZEI As Long = 0
            Dim lngTotalMR_JR As Long = 0

            Dim lngTotalTAXI_T As Long = 0
            Dim lngTotalTAXI_SEISAN_T As Long = 0

            '明細行出力
            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SRM_HACYU_KBN(CsvData(wCnt).SRM_HACYU_KBN))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEISAN_YM)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHIHARAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SHOUNIN_KUBUN(CsvData(wCnt).SHOUNIN_KUBUN))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHOUNIN_DATE)))

                '総合計金額
                Dim lngSougouKei As Long = CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_TF) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_T) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_T) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_T)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngSougouKei.ToString)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).AIR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TRAFFIC_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTEL_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_JR)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_T)))

                '@@@ Phase2
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIHIN_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).UPDATE_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_FLAG(CsvData(wCnt).SEND_FLAG)), True))
                '@@@ Phase2

                sb.Append(vbNewLine)

                '集計行用に加算
                lngTotalSougouKei += lngSougouKei
                lngTotalKAIJOHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KAIJOHI_TF)
                lngTotalINSHOKUHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).INSHOKUHI_TF)
                lngTotalKIZAIHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KIZAIHI_TF)
                lngTotalKEI_991330401_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_991330401_TF)

                lngTotalHOTELHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTELHI_TF)
                lngTotalHOTELHI_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTELHI_TOZEI)
                lngTotalAIR_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).AIR_TF)
                lngTotalJR_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).JR_TF)
                lngTotalOTHER_TRAFFIC_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_TRAFFIC_TF)
                lngTotalJINKENHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).JINKENHI_TF)
                lngTotalKANRIHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KANRIHI_TF)
                lngTotalHOTEL_COMMISSION_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTEL_COMMISSION_TF)
                lngTotalTAXI_COMMISSION_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_COMMISSION_TF)
                lngTotalOTHER_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_TF)
                lngTotalTAXI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_TF)
                lngTotalTAXI_SEISAN_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_TF)
                lngTotalKEI_41120200_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_41120200_TF)

                lngTotalKEI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_TF)
                lngTotalKAIJOUHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KAIJOUHI_T)
                lngTotalINSHOKUHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).INSHOKUHI_T)
                lngTotalKIZAIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KIZAIHI_T)
                lngTotalKEI_991330401_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_991330401_T)

                lngTotalJINKENHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).JINKENHI_T)
                lngTotalKANRIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KANRIHI_T)
                lngTotalOTHER_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_T)
                lngTotalKEI_41120200_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_41120200_T)

                lngTotalKEI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_T)

                lngTotalMR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL)
                lngTotalMR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI)
                lngTotalMR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR)

                lngTotalTAXI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_T)
                lngTotalTAXI_SEISAN_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_T)
            Next

            '集計行出力
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalSougouKei.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKAIJOHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalINSHOKUHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKIZAIHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_991330401_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTELHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTELHI_TOZEI.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalAIR_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJR_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_TRAFFIC_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJINKENHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKANRIHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTEL_COMMISSION_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_COMMISSION_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_SEISAN_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_41120200_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKAIJOUHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalINSHOKUHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKIZAIHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_991330401_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJINKENHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKANRIHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_41120200_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_HOTEL.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_HOTEL_TOZEI.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_JR.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_SEISAN_T.ToString), True))

            sb.Append(vbNewLine)

            Return sb.ToString

        End Function


        Public Shared Function DrHiyouCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim KEI_HOTELHI As Long = 0
            Dim KEI_HOTELHI_CANCEL As Long = 0 '宿泊取消料
            Dim KEI_HOTELHI_TOTAL As Long = 0 '宿泊費+宿泊取消料
            Dim KEI_HOTELHI_TOZEI As Long = 0
            Dim KEI_RAIL_FARE As Long = 0
            Dim KEI_RAIL_CANCELLATION As Long = 0 'JR取消料
            Dim KEI_RAIL_TOTAL As Long = 0 'JR代+JR取消料
            Dim KEI_AIR_FARE As Long = 0
            Dim KEI_AIR_CANCELLATION As Long = 0 '航空券取消料
            Dim KEI_AIR_TOTAL As Long = 0 '航空券代+航空券取消料
            Dim KEI_OTHER_FARE As Long = 0
            Dim KEI_OTHER_CANCELLATION As Long = 0 'その他鉄道取消料
            Dim KEI_OTHER_TOTAL As Long = 0 'その他鉄道等費用+その他鉄道取消料
            Dim KEI_KOTSUHOTEL_TESURYO As Long = 0
            Dim KEI_TAXI_TESURYO As Long = 0
            Dim KEI_SANKASHA_TOTAL As Long = 0
            Dim KEI_RYOHI_TOTAL As Long = 0   'Dr旅費合計
            Dim KEI_TAXI_TICKET_MAISU As Long = 0  'タクチケ枚数

            '税率取得
            Dim strZeiRate As String = AppModule.GetZeiRate(CsvData(wCnt).FROM_DATE, DbConn)

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード"))) '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))  '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("指定外申請理由")))  '4/28 ADD
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠状況")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊取消料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費都税(-)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR取消料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券取消料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道等費用(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道取消料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("登録手数料(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR旅費合計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行枚数")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのBU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのエリア名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの営業所名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR携帯番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先FS")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先(その他)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("承認者")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Account Code")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Cost Center")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Internal order")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのAccount Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal order")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("zetia Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Timestamp(BYL)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊手配(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊依頼内容(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊日(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("泊数(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ホテル喫煙(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL宿泊備考(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Timestamp(TOP)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("泊数(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊施設名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊部屋タイプ(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ホテル喫煙(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP宿泊備考(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊先電話番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL交通備考(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(依頼)")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR航空券番号１")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR航空券番号２")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR航空券番号３")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR航空券番号４")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR航空券番号５")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR航空券番号６")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路1座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路2座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路3座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路4座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("往路5座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路1座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路2座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路3座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路4座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5ステータス(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5乗車日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5交通機関(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5列車名・便名(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5発地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5出発時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5着地(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5到着時間(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5座席区分(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("復路5座席位置(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP交通備考(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(回答)"), True))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                Dim HOTELHI_TOTAL As Long = 0 '宿泊費+宿泊取消料
                Dim RAIL_TOTAL As Long = 0 'JR代+JR取消料
                Dim AIR_TOTAL As Long = 0 '航空券代+航空券取消料
                Dim OTHER_TOTAL As Long = 0 'その他鉄道等費用+その他鉄道取消料
                Dim SANKASHA_TOTAL As Long = 0 '参加者旅費合計
                Dim TAXI_TICKET_MAISU As Long = 0  'タクチケ枚数

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_YAKUWARI(CsvData(wCnt).DR_YAKUWARI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHITEIGAI_RIYU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_SANKA(CsvData(wCnt).DR_SANKA))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_CANCEL))))

                HOTELHI_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI) + _
                                CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_CANCEL)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(HOTELHI_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_TOZEI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_CANCELLATION))))

                RAIL_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_FARE) + _
                             CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_CANCELLATION)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(RAIL_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_CANCELLATION))))

                AIR_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_FARE) + _
                            CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_CANCELLATION)

                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AIR_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_FARE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_CANCELLATION))))

                OTHER_TOTAL = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_FARE) + _
                              CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_CANCELLATION)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_TAXI_TESURYO))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO))))

                SANKASHA_TOTAL = HOTELHI_TOTAL + RAIL_TOTAL + AIR_TOTAL + OTHER_TOTAL + _
                                 CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO) + _
                                 CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_TAXI_TESURYO) + _
                                 CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_TOZEI)

                TAXI_TICKET_MAISU = Long.Parse(AppModule.GetName_ANS_TAXI_MAISUU(CsvData(wCnt).ANS_TAXI_TESURYO, _
                                                                                CsvData(wCnt).FROM_DATE, DbConn))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SANKASHA_TOTAL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TAXI_TICKET_MAISU)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KEITAI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_FS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_OTHER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHONIN_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_STATUS_TEHAI(CsvData(wCnt).REQ_STATUS_TEHAI, False, True))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TIME_STAMP_BYL(CsvData(wCnt).TIME_STAMP_BYL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_HOTEL_IRAINAIYOU(CsvData(wCnt).HOTEL_IRAINAIYOU))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).REQ_HOTEL_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_HAKUSU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_HOTEL_SMOKING(CsvData(wCnt).REQ_HOTEL_SMOKING))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_UPDATE_DATE(CsvData(wCnt).UPDATE_DATE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_TEHAI(CsvData(wCnt).ANS_STATUS_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_HOTEL(CsvData(wCnt).ANS_STATUS_HOTEL))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).ANS_HOTEL_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HAKUSU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_ROOM_TYPE(CsvData(wCnt).ANS_ROOM_TYPE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_HOTEL_SMOKING(CsvData(wCnt).ANS_HOTEL_SMOKING))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_TEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_KOTSU_BIKO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_TAXI_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_1, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_1(CsvData(wCnt).ANS_O_TIME1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_1(CsvData(wCnt).ANS_O_TIME2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_1(CsvData(wCnt).ANS_O_SEAT_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_1(CsvData(wCnt).ANS_O_SEAT_KIBOU1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_2, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_2(CsvData(wCnt).ANS_O_TIME1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_2(CsvData(wCnt).ANS_O_TIME2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_2(CsvData(wCnt).ANS_O_SEAT_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_2(CsvData(wCnt).ANS_O_SEAT_KIBOU2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_3, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_3(CsvData(wCnt).ANS_O_TIME1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_3(CsvData(wCnt).ANS_O_TIME2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_3(CsvData(wCnt).ANS_O_SEAT_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_3(CsvData(wCnt).ANS_O_SEAT_KIBOU3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_4, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_4(CsvData(wCnt).ANS_O_TIME1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_4(CsvData(wCnt).ANS_O_TIME2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_4(CsvData(wCnt).ANS_O_SEAT_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_4(CsvData(wCnt).ANS_O_SEAT_KIBOU4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_STATUS(CsvData(wCnt).ANS_O_STATUS_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_O_DATE_5, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_KOTSUKIKAN(CsvData(wCnt).ANS_O_KOTSUKIKAN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_BIN_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT1_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME1_5(CsvData(wCnt).ANS_O_TIME1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_O_AIRPORT2_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_TIME2_5(CsvData(wCnt).ANS_O_TIME2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_5(CsvData(wCnt).ANS_O_SEAT_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_O_SEAT_KIBOU_5(CsvData(wCnt).ANS_O_SEAT_KIBOU5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_1, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_1(CsvData(wCnt).ANS_F_TIME1_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_1(CsvData(wCnt).ANS_F_TIME2_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_1(CsvData(wCnt).ANS_F_SEAT_1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_1(CsvData(wCnt).ANS_F_SEAT_KIBOU1))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_2, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_2(CsvData(wCnt).ANS_F_TIME1_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_2(CsvData(wCnt).ANS_F_TIME2_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_2(CsvData(wCnt).ANS_F_SEAT_2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_2(CsvData(wCnt).ANS_F_SEAT_KIBOU2))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_3, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_3(CsvData(wCnt).ANS_F_TIME1_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_3(CsvData(wCnt).ANS_F_TIME2_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_3(CsvData(wCnt).ANS_F_SEAT_3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_3(CsvData(wCnt).ANS_F_SEAT_KIBOU3))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_4, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_4(CsvData(wCnt).ANS_F_TIME1_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_4(CsvData(wCnt).ANS_F_TIME2_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_4(CsvData(wCnt).ANS_F_SEAT_4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_4(CsvData(wCnt).ANS_F_SEAT_KIBOU4))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_STATUS(CsvData(wCnt).ANS_F_STATUS_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_F_DATE_5, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_KOTSUKIKAN(CsvData(wCnt).ANS_F_KOTSUKIKAN_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_BIN_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT1_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME1_5(CsvData(wCnt).ANS_F_TIME1_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_F_AIRPORT2_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_TIME2_5(CsvData(wCnt).ANS_F_TIME2_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_5(CsvData(wCnt).ANS_F_SEAT_5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_F_SEAT_KIBOU_5(CsvData(wCnt).ANS_F_SEAT_KIBOU5))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_KOTSU_BIKO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE), True))
                sb.Append(vbNewLine)

                KEI_HOTELHI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI)
                KEI_HOTELHI_CANCEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_CANCEL)
                KEI_HOTELHI_TOTAL += HOTELHI_TOTAL
                KEI_HOTELHI_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_HOTELHI_TOZEI)
                KEI_RAIL_FARE += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_FARE)
                KEI_RAIL_CANCELLATION += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_RAIL_CANCELLATION)
                KEI_RAIL_TOTAL += RAIL_TOTAL
                KEI_AIR_FARE += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_FARE)
                KEI_AIR_CANCELLATION += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_AIR_CANCELLATION)
                KEI_AIR_TOTAL += AIR_TOTAL
                KEI_OTHER_FARE += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_FARE)
                KEI_OTHER_CANCELLATION += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_OTHER_CANCELLATION)
                KEI_OTHER_TOTAL += OTHER_TOTAL
                KEI_KOTSUHOTEL_TESURYO += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_KOTSUHOTEL_TESURYO)
                KEI_TAXI_TESURYO += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_TAXI_TESURYO)
                KEI_SANKASHA_TOTAL += SANKASHA_TOTAL
                KEI_TAXI_TICKET_MAISU += TAXI_TICKET_MAISU

            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI_CANCEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_RAIL_FARE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_RAIL_CANCELLATION)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_AIR_FARE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_AIR_CANCELLATION)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_OTHER_FARE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_OTHER_CANCELLATION)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_TAXI_TESURYO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_KOTSUHOTEL_TESURYO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_SANKASHA_TOTAL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_TAXI_TICKET_MAISU)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        Public Shared Function MrHiyouCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                     ByVal DbConn As System.Data.SqlClient.SqlConnection) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim strCostCenter As String = ""
            Dim COSTKEI_MR_HOTEL As Long = 0
            Dim COSTKEI_MR_HOTEL_TOZEI As Long = 0
            Dim COSTKEI_MR_JR As Long = 0
            Dim COSTKEI_MR_RYOHI As Long = 0

            Dim KEI_MR_HOTEL As Long = 0
            Dim KEI_MR_HOTEL_TOZEI As Long = 0
            Dim KEI_MR_JR As Long = 0
            Dim KEI_MR_RYOHI As Long = 0

            '税率取得
            Dim strZeiRate As String = AppModule.GetZeiRate(CsvData(wCnt).FROM_DATE, DbConn)

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属BU(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属エリア(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属営業所(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員氏名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL社員用備考(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用往路隣席希望(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用復路隣席希望(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP社員用備考(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費(非課税)(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員入湯税・宿泊税(非課税)(-)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費(非課税)(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員旅費合計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割"), True))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                If strCostCenter <> "" AndAlso _
                   strCostCenter <> CsvData(wCnt).COST_CENTER Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計(込)")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL_TOZEI)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_JR)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_RYOHI)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
                    sb.Append(vbNewLine)

                    '初期化
                    COSTKEI_MR_HOTEL = 0
                    COSTKEI_MR_HOTEL_TOZEI = 0
                    COSTKEI_MR_JR = 0
                    COSTKEI_MR_RYOHI = 0
                End If

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_MR_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_MR_O_TEHAI(CsvData(wCnt).ANS_MR_O_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_MR_F_TEHAI(CsvData(wCnt).ANS_MR_F_TEHAI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTEL_NOTE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTELHI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_KOTSUHI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes( CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI) _
                                    + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI) _
                                    + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_YAKUWARI(CsvData(wCnt).DR_YAKUWARI)), True))
                sb.Append(vbNewLine)

                strCostCenter = CsvData(wCnt).COST_CENTER

                'コストセンター計　加算
                COSTKEI_MR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI)
                COSTKEI_MR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)
                COSTKEI_MR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
                COSTKEI_MR_RYOHI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI) _
                                    + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI) _
                                    + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)

                '合計　加算
                KEI_MR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI)
                KEI_MR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)
                KEI_MR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
                KEI_MR_RYOHI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI) _
                                    + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI) _
                                    + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_HOTEL_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_JR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(COSTKEI_MR_RYOHI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計(込)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_JR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_RYOHI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        Public Shared Function TaxiJissekiCsv(ByVal CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim strKaisha As String = ""
            Dim KAISHAKEI_URIAGE As Long = 0
            Dim KAISHAKEI_SEISAN_FEE As Long = 0

            Dim KEI_URIAGE As Long = 0
            Dim KEI_SEISAN_FEE As Long = 0

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TAXI会社")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ№")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("枚数枝番")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠状況")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("印字済利用日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("乗車日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行手数料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("破棄日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SRM発注区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求方法")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発注番号")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求先")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者氏名(ローマ字)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("基本情報Account Code(非課税)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("基本情報Account Code(課税)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("基本情報企画担当者のCost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのBU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのエリア名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの営業所名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Account Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Cost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Internal order")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("zetia Code"), True))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                If strKaisha <> "" AndAlso _
                   strKaisha <> CsvData(wCnt).TKT_KAISHA Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAISHAKEI_URIAGE)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAISHAKEI_SEISAN_FEE)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
                    sb.Append(vbNewLine)

                    '初期化
                    KAISHAKEI_URIAGE = 0
                    KAISHAKEI_SEISAN_FEE = 0
                End If

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KAISHA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_LINE_NO)))
                '出欠状況
                If CmnModule.Format_Date(CsvData(wCnt).SANKA_UPDATE, CmnModule.DateFormatType.YYYYMMDD) >= CsvData(wCnt).TKT_IMPORT_DATE Then
                    If CsvData(wCnt).SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
                        sb.Append(CmnCsv.SetData("**参加"))
                    ElseIf CsvData(wCnt).SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
                        sb.Append(CmnCsv.SetData("**不参加"))
                    Else
                        sb.Append(CmnCsv.SetData("**"))
                    End If
                Else
                    If CsvData(wCnt).SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
                        sb.Append(CmnCsv.SetData("参加"))
                    ElseIf CsvData(wCnt).SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
                        sb.Append(CmnCsv.SetData("不参加"))
                    Else
                        sb.Append(CmnCsv.SetData(""))
                    End If
                End If
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_HAKKO_FEE))))
                'エンタ
                If CsvData(wCnt).TKT_ENTA.Trim <> "" Then
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_ENTA)))
                ElseIf CsvData(wCnt).SANKA_FLAG.Trim = "" Then
                    sb.Append(CmnCsv.SetData("出欠未"))
                Else
                    sb.Append(CmnCsv.SetData(""))
                End If
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TKT_VOID_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TKT_IMPORT_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                'SRM発注区分・請求方法
                If CsvData(wCnt).SRM_HACYU_KBN = AppConst.KAIJO.SRM_HACYU_KBN.Code.Yes Then
                    sb.Append(CmnCsv.SetData(AppConst.KAIJO.SRM_HACYU_KBN.Name.Yes))
                    If CsvData(wCnt).TKT_ENTA.Trim = "E" Or CsvData(wCnt).SANKA_FLAG.Trim = "" Then
                        sb.Append(CmnCsv.SetData("SAP"))
                    ElseIf CsvData(wCnt).TKT_ENTA.Trim = "" Then
                        sb.Append(CmnCsv.SetData("請求書"))
                    Else
                        sb.Append(CmnCsv.SetData(""))
                    End If
                ElseIf CsvData(wCnt).SRM_HACYU_KBN = AppConst.KAIJO.SRM_HACYU_KBN.Code.No Then
                    sb.Append(CmnCsv.SetData(AppConst.KAIJO.SRM_HACYU_KBN.Name.No))
                    sb.Append(CmnCsv.SetData("SAP"))
                Else
                    sb.Append(CmnCsv.SetData(""))
                    sb.Append(CmnCsv.SetData("SAP"))
                End If
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_MPID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_DR_YAKUWARI(CsvData(wCnt).DR_YAKUWARI))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_ROMA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ACCOUNT_CD_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ACCOUNT_CD_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))

                '精算実績
                If CsvData(wCnt).TKT_ENTA = "E" Then
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_ACCOUNT_CD)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
                    sb.Append(CmnCsv.SetData(""))
                Else
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ACCOUNT_CD_TF)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_INTERNAL_ORDER)))
                End If

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ZETIA_CD), True))
                sb.Append(vbNewLine)

                strKaisha = CsvData(wCnt).TKT_KAISHA

                'TAXI会社計　加算
                KAISHAKEI_URIAGE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE)
                KAISHAKEI_SEISAN_FEE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE)

                '合計　加算
                KEI_URIAGE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE)
                KEI_SEISAN_FEE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE)
            Next wCnt


            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAISHAKEI_URIAGE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KAISHAKEI_SEISAN_FEE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)


            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_URIAGE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_SEISAN_FEE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
            sb.Append(vbNewLine)
            Return sb.ToString
        End Function

    End Class

End Class
