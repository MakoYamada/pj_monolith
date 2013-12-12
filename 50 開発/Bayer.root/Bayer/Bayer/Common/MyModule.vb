Imports CommonLib
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

    'ログテーブル
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "講演会番号：" & TBL_KOUENKAI.KOUENKAI_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_KAIJO As TableDef.TBL_KAIJO.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "講演会番号：" & TBL_KAIJO.KOUENKAI_NO

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
    End Function
    Public Shared Function InsertTBL_LOG(ByVal GamenType As AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType, _
                                         ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                         ByVal STATUS_OK As Boolean, _
                                         ByVal Message As String, _
                                         ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        TBL_LOG.NOTE = "講演会番号：" & TBL_KOTSUHOTEL.KOUENKAI_NO _
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

        TBL_LOG.NOTE = "講演会番号：" & TBL_SEIKYU.KOUENKAI_NO _
                     & "／" _
                     & "精算番号：" & TBL_SEIKYU.SEIKYU_NO_TOPTOUR

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
            Case AppConst.MS_CODE.MR_TEHAI
                wStr = "社員臨席希望"
            Case AppConst.MS_CODE.MR_HOTEL_SMOKING
                wStr = "社員ホテル禁煙"
            Case AppConst.MS_CODE.ROOM_TYPE
                wStr = "宿泊部屋タイプ"
            Case Else
                wStr = MS_CODE.CODE
        End Select

        TBL_LOG.NOTE = "コード：" & wStr

        Return InsertTBL_LOG(GamenType, TBL_LOG, STATUS_OK, Message, DbConn)
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
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiCsv
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiCsv
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiScan
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMaintenance
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMaintenance
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiJisseki
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiMiketsu
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiSeikyuMeisai
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiSeikyuMeisai
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiSeikyuFuka
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiSeikyuFuka
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiKouenkaiMeisai
                TBL_LOG.SYORI_NAME = AppConst.TBL_LOG.SYORI_NAME.GAMEN.Name.TaxiKouenkaiMeisai
            Case Else
                TBL_LOG.SYORI_NAME = "画面名 エラー"
        End Select

        'テーブル名
        Select Case GamenType
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KouenkaiRegist
                TBL_LOG.TABLE_NAME = "TBL_KOUENKAI"
            Case AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.KaijoRegist
                TBL_LOG.TABLE_NAME = "TBL_KAIJO"
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

        If STATUS_OK = True Then
            TBL_LOG.STATUS = AppConst.TBL_LOG.STATUS.Code.OK
            TBL_LOG.NOTE = Trim(Message)
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
        Public Shared Function TaxiCsv(ByVal CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ列 必要?
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会基本情報：Timestamp(BYL)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("取消フラグ")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会名(チケット印字用)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会開催日From")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会開催日To")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会会場名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("製品名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Salesforce Id")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("交通宿泊手配：Timestamp(BYL)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTP ID(参加者ID)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名(半角カタカナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DCF施設コード")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設住所")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("性別")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空搭乗者年齢")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("指定外申請理由(依頼)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属事業部(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属エリア(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("所属営業所(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当者(担当MR)名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当者名(担当MR)(ローマ字)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当者名(担当MR)(カナ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Emailアドレス(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("携帯Emailアドレス(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("携帯電話番号(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("オフィスの電話番号(担当MR)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先FS")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先(その他)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("最終承認者(氏名)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("最終承認日時")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット(有・無)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット1:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット1:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット1:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット2:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット2:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット2:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット3:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット3:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット3:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット4:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット4:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット4:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット5:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット5:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット5:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット6:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット6:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット6:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット7:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット7:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット7:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット8:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット8:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット8:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット9:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット9:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット9:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット10:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット10:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット10:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット11:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット11:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット11:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット12:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット12:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット12:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット13:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット13:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット13:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット14:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット14:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット14:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット15:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット15:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット15:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット16:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット16:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット16:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット17:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット17:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット17:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット18:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット18:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット18:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット19:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット19:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット19:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット20:利用日(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット20:券種(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット20:番号(回答)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット:備考(回答)")))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TIME_STAMP)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TORIKESHI_FLG)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_PRT_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TO_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIHIN_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SALEFORCE_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_STATUS_TEHAI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TIME_STAMP_BYL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_MPID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_ADDRESS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_YAKUWARI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SEX)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_AGE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHITEIGAI_RIYU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_ROMA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EMAIL_PC)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EMAIL_KEITAI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KEITAI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_TEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_FS)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_OTHER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHONIN_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHONIN_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TAXI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_1)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_2)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_3)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_4)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_5)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_6)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_6)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_6)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_7)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_7)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_7)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_8)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_8)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_8)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_9)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_9)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_9)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_10)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_10)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_10)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_11)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_11)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_11)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_12)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_12)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_12)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_13)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_13)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_13)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_14)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_14)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_14)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_15)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_15)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_15)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_16)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_16)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_16)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_17)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_17)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_17)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_18)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_18)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_18)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_19)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_19)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_19)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_DATE_20)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_KENSHU_20)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NO_20)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE)))
                sb.Append(vbNewLine)
            Next wCnt

            Return sb.ToString
        End Function

        Public Shared Function DrCsv(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim HOTELHI_TF As Long = 0
            Dim HOTELHI_TOZEI As Long = 0
            Dim JR_TF As Long = 0
            Dim AIR_TF As Long = 0
            Dim OTHER_TRAFFIC_TF As Long = 0
            Dim TAXI_COMMISSION_TF As Long = 0
            Dim HOTEL_COMMISSION_TF As Long = 0
            Dim TAXI_TF As Long = 0
            Dim TAXI_SEISAN_TF As Long = 0

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ドクター氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費都税")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他鉄道等費用")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発券手数料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("登録手数料")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料")))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).AIR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TRAFFIC_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTEL_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_TF)))
                sb.Append(vbNewLine)

                HOTELHI_TF += CmnModule.DbVal(CsvData(wCnt).HOTELHI_TF)
                HOTELHI_TOZEI += CmnModule.DbVal(CsvData(wCnt).HOTELHI_TOZEI)
                JR_TF += CmnModule.DbVal(CsvData(wCnt).JR_TF)
                AIR_TF += CmnModule.DbVal(CsvData(wCnt).AIR_TF)
                OTHER_TRAFFIC_TF += CmnModule.DbVal(CsvData(wCnt).OTHER_TRAFFIC_TF)
                TAXI_COMMISSION_TF += CmnModule.DbVal(CsvData(wCnt).TAXI_COMMISSION_TF)
                HOTEL_COMMISSION_TF += CmnModule.DbVal(CsvData(wCnt).HOTEL_COMMISSION_TF)
                TAXI_TF += CmnModule.DbVal(CsvData(wCnt).TAXI_TF)
                TAXI_SEISAN_TF += CmnModule.DbVal(CsvData(wCnt).TAXI_SEISAN_TF)
            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(HOTELHI_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(HOTELHI_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(JR_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AIR_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(OTHER_TRAFFIC_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TAXI_COMMISSION_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(HOTEL_COMMISSION_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TAXI_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TAXI_SEISAN_TF)))
            sb.Append(vbNewLine)

            Return sb.ToString
        End Function

        Public Shared Function MrCsv(ByVal CsvData() As TableDef.TBL_SEIKYU.DataStruct) As String
            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            Dim strCostCenter As String = ""
            Dim MR_HOTEL As Long = 0
            Dim MR_HOTEL_TOZEI As Long = 0
            Dim MR_JR As Long = 0
            Dim KEI_MR_HOTEL As Long = 0
            Dim KEI_MR_HOTEL_TOZEI As Long = 0
            Dim KEI_MR_JR As Long = 0

            'ヘッダ列
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("講演会名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費(非課税)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費都税(非課税)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費(非課税)")))
            sb.Append(vbNewLine)

            For wCnt = 0 To UBound(CsvData)

                If strCostCenter <> "" AndAlso _
                   strCostCenter <> CsvData(wCnt).COST_CENTER Then

                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MR_HOTEL)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MR_HOTEL_TOZEI)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MR_JR)))
                    sb.Append(vbNewLine)

                    '初期化
                    MR_HOTEL = 0
                    MR_HOTEL_TOZEI = 0
                    MR_JR = 0
                End If

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_JR)))
                sb.Append(vbNewLine)

                strCostCenter = CsvData(wCnt).COST_CENTER

                'コストセンター計　加算
                MR_HOTEL += CmnModule.DbVal(CsvData(wCnt).MR_HOTEL)
                MR_HOTEL_TOZEI += CmnModule.DbVal(CsvData(wCnt).MR_HOTEL_TOZEI)
                MR_JR += CmnModule.DbVal(CsvData(wCnt).MR_JR)

                '合計　加算
                KEI_MR_HOTEL += CmnModule.DbVal(CsvData(wCnt).MR_HOTEL)
                KEI_MR_HOTEL_TOZEI += CmnModule.DbVal(CsvData(wCnt).MR_HOTEL_TOZEI)
                KEI_MR_JR += CmnModule.DbVal(CsvData(wCnt).MR_JR)
            Next wCnt

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("コストセンター計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strCostCenter)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MR_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MR_HOTEL_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MR_JR)))
            sb.Append(vbNewLine)

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_HOTEL_TOZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_MR_JR)))
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
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KINGAKU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZEI_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIGOU_MEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).PAYMENT_BLOCK)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.Quotes(CsvData(wCnt).BARCODE))
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
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KINGAKU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZEI_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIGOU_MEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).PAYMENT_BLOCK)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BARCODE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DANTAI_CODE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME))
                sb.Append(vbNewLine)
            Next

            Return sb.ToString

        End Function
    End Class

End Class
