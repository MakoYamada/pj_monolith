<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class KaijoReport 
    Inherits DataDynamics.ActiveReports.ActiveReport

    'ActiveReport がコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'メモ: 以下のプロシージャは ActiveReport デザイナで必要です。
    'ActiveReport デザイナを使用して変更できます。
    'コード エディタを使って変更しないでください。
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KaijoReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.LabelPage = New DataDynamics.ActiveReports.Label
        Me.LOGIN_USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.PrintDate = New DataDynamics.ActiveReports.TextBox
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.PageTotal = New DataDynamics.ActiveReports.TextBox
        Me.PageCount = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.OTHER_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.Label46 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.KAISAI_KIBOU_ADDRESS2 = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.Label72 = New DataDynamics.ActiveReports.Label
        Me.Label70 = New DataDynamics.ActiveReports.Label
        Me.Label67 = New DataDynamics.ActiveReports.Label
        Me.Label65 = New DataDynamics.ActiveReports.Label
        Me.SHAIN_ROOM_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.Label69 = New DataDynamics.ActiveReports.Label
        Me.Label77 = New DataDynamics.ActiveReports.Label
        Me.Label76 = New DataDynamics.ActiveReports.Label
        Me.KAISAI_KIBOU_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.KAISAI_DATE_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.KOUEN_KAIJO_LAYOUT = New DataDynamics.ActiveReports.TextBox
        Me.Label74 = New DataDynamics.ActiveReports.Label
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label62 = New DataDynamics.ActiveReports.Label
        Me.Label35 = New DataDynamics.ActiveReports.Label
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.KOUEN_TIME1 = New DataDynamics.ActiveReports.TextBox
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.SANKA_YOTEI_CNT_MBR = New DataDynamics.ActiveReports.TextBox
        Me.Label56 = New DataDynamics.ActiveReports.Label
        Me.Label57 = New DataDynamics.ActiveReports.Label
        Me.Label58 = New DataDynamics.ActiveReports.Label
        Me.Label59 = New DataDynamics.ActiveReports.Label
        Me.KIKAKU_TANTO_EMAIL_PC = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_TEL = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EMAIL_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.Label50 = New DataDynamics.ActiveReports.Label
        Me.Label49 = New DataDynamics.ActiveReports.Label
        Me.Label48 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.ZETIA_CD = New DataDynamics.ActiveReports.TextBox
        Me.SEIHIN_NAME = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.Label47 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label44 = New DataDynamics.ActiveReports.Label
        Me.Label45 = New DataDynamics.ActiveReports.Label
        Me.SHONIN_NAME = New DataDynamics.ActiveReports.TextBox
        Me.SHONIN_DATE = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_PRT_NAME = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.Label37 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_ID = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.SEND_FLAG = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.KAIJO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line40 = New DataDynamics.ActiveReports.Line
        Me.Line43 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line46 = New DataDynamics.ActiveReports.Line
        Me.Line47 = New DataDynamics.ActiveReports.Line
        Me.Line54 = New DataDynamics.ActiveReports.Line
        Me.Line55 = New DataDynamics.ActiveReports.Line
        Me.TEHAI_TANTO_EMAIL_PC = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_TEL = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_EMAIL_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label51 = New DataDynamics.ActiveReports.Label
        Me.Label52 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_BU = New DataDynamics.ActiveReports.TextBox
        Me.Label53 = New DataDynamics.ActiveReports.Label
        Me.Label54 = New DataDynamics.ActiveReports.Label
        Me.Label55 = New DataDynamics.ActiveReports.Label
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line56 = New DataDynamics.ActiveReports.Line
        Me.Line57 = New DataDynamics.ActiveReports.Line
        Me.Line59 = New DataDynamics.ActiveReports.Line
        Me.Line60 = New DataDynamics.ActiveReports.Line
        Me.Line61 = New DataDynamics.ActiveReports.Line
        Me.Line62 = New DataDynamics.ActiveReports.Line
        Me.Line63 = New DataDynamics.ActiveReports.Line
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.SANKA_YOTEI_CNT_NMBR = New DataDynamics.ActiveReports.TextBox
        Me.SRM_HACYU_KBN = New DataDynamics.ActiveReports.TextBox
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.YOSAN_TF = New DataDynamics.ActiveReports.TextBox
        Me.YOSAN_T = New DataDynamics.ActiveReports.TextBox
        Me.YOSAN_TOTAL = New DataDynamics.ActiveReports.TextBox
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.IKENKOUKAN_YOSAN_T = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_YOSAN_T = New DataDynamics.ActiveReports.TextBox
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line65 = New DataDynamics.ActiveReports.Line
        Me.Line64 = New DataDynamics.ActiveReports.Line
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.KAISAI_KIBOU_ADDRESS1 = New DataDynamics.ActiveReports.TextBox
        Me.Line38 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line70 = New DataDynamics.ActiveReports.Line
        Me.KOUEN_TIME2 = New DataDynamics.ActiveReports.TextBox
        Me.Line71 = New DataDynamics.ActiveReports.Line
        Me.Line72 = New DataDynamics.ActiveReports.Line
        Me.Label63 = New DataDynamics.ActiveReports.Label
        Me.Label64 = New DataDynamics.ActiveReports.Label
        Me.Label66 = New DataDynamics.ActiveReports.Label
        Me.Label68 = New DataDynamics.ActiveReports.Label
        Me.Label71 = New DataDynamics.ActiveReports.Label
        Me.Label73 = New DataDynamics.ActiveReports.Label
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_KAIJO_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_SANKA_YOTEI_CNT = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_FROM = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_KAIJO_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_ROOM_FROM = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STAY_DATE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.REQ_KOTSU_CNT = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_CNT = New DataDynamics.ActiveReports.TextBox
        Me.Line82 = New DataDynamics.ActiveReports.Line
        Me.Line83 = New DataDynamics.ActiveReports.Line
        Me.Line84 = New DataDynamics.ActiveReports.Line
        Me.Line85 = New DataDynamics.ActiveReports.Line
        Me.Label75 = New DataDynamics.ActiveReports.Label
        Me.MANAGER_KAIJO_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_KAIJO_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.IKENKOUKAN_KAIJO_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.Label78 = New DataDynamics.ActiveReports.Label
        Me.Line67 = New DataDynamics.ActiveReports.Line
        Me.Line76 = New DataDynamics.ActiveReports.Line
        Me.Line77 = New DataDynamics.ActiveReports.Line
        Me.Line78 = New DataDynamics.ActiveReports.Line
        Me.Line79 = New DataDynamics.ActiveReports.Line
        Me.Line75 = New DataDynamics.ActiveReports.Line
        Me.Line69 = New DataDynamics.ActiveReports.Line
        Me.Line73 = New DataDynamics.ActiveReports.Line
        Me.Line68 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line66 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line42 = New DataDynamics.ActiveReports.Line
        Me.Line44 = New DataDynamics.ActiveReports.Line
        Me.Line74 = New DataDynamics.ActiveReports.Line
        Me.Line35 = New DataDynamics.ActiveReports.Line
        Me.Line41 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Line36 = New DataDynamics.ActiveReports.Line
        Me.Line53 = New DataDynamics.ActiveReports.Line
        Me.Line52 = New DataDynamics.ActiveReports.Line
        Me.Line51 = New DataDynamics.ActiveReports.Line
        Me.Line50 = New DataDynamics.ActiveReports.Line
        Me.Line49 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line45 = New DataDynamics.ActiveReports.Line
        Me.Line48 = New DataDynamics.ActiveReports.Line
        Me.Line58 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line80 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_ADDRESS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_DATE_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_KAIJO_LAYOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_TIME1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKA_YOTEI_CNT_MBR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_TEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZETIA_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEIHIN_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_PRT_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEND_FLAG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAIJO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_TEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKA_YOTEI_CNT_NMBR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRM_HACYU_KBN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOSAN_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOSAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOSAN_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_YOSAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_YOSAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_ADDRESS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_TIME2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_SANKA_YOTEI_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_ROOM_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STAY_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_KOTSU_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.BackColor = System.Drawing.Color.Empty
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.LabelPage, Me.LOGIN_USER_NAME, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.PrintDate, Me.Shape1, Me.PageTotal, Me.PageCount, Me.Label8})
        Me.PageHeader.Height = 0.8484252!
        Me.PageHeader.Name = "PageHeader"
        '
        'LabelPage
        '
        Me.LabelPage.Height = 0.1771654!
        Me.LabelPage.HyperLink = Nothing
        Me.LabelPage.Left = 6.6063!
        Me.LabelPage.Name = "LabelPage"
        Me.LabelPage.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: right; vertical-align: top"
        Me.LabelPage.Text = "(999/999ページ)"
        Me.LabelPage.Top = 0.3590551!
        Me.LabelPage.Width = 1.429133!
        '
        'LOGIN_USER_NAME
        '
        Me.LOGIN_USER_NAME.CanGrow = False
        Me.LOGIN_USER_NAME.DataField = "USER_NAME"
        Me.LOGIN_USER_NAME.Height = 0.1771654!
        Me.LOGIN_USER_NAME.Left = 6.657481!
        Me.LOGIN_USER_NAME.Name = "LOGIN_USER_NAME"
        Me.LOGIN_USER_NAME.Style = "font-family: ＭＳ ゴシック; vertical-align: top"
        Me.LOGIN_USER_NAME.Text = Nothing
        Me.LOGIN_USER_NAME.Top = 0.1771654!
        Me.LOGIN_USER_NAME.Width = 1.377953!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.906694!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: top"
        Me.Label1.Text = "出力日"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.6251969!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.906693!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: top"
        Me.Label2.Text = "出力担当"
        Me.Label2.Top = 0.1771655!
        Me.Label2.Width = 0.6251969!
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 6.500823!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: top"
        Me.Label3.Text = "："
        Me.Label3.Top = 0.1772966!
        Me.Label3.Width = 0.1669291!
        '
        'Label4
        '
        Me.Label4.Height = 0.1771654!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.500823!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align: top"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001311153!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1771654!
        Me.PrintDate.Left = 6.657516!
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Style = "font-family: ＭＳ ゴシック; vertical-align: top"
        Me.PrintDate.Text = "2013/12/12 00:00:00"
        Me.PrintDate.Top = 0.0001311153!
        Me.PrintDate.Width = 1.377953!
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.2755905!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.5500001!
        Me.Shape1.Width = 8.039371!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 5.404331!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.3590551!
        Me.PageTotal.Visible = False
        Me.PageTotal.Width = 0.2559055!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 5.05!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.PageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.3590551!
        Me.PageCount.Visible = False
        Me.PageCount.Width = 0.2559055!
        '
        'Label8
        '
        Me.Label8.Height = 0.2362205!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 3.232284!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "会場手配依頼"
        Me.Label8.Top = 0.5696851!
        Me.Label8.Width = 1.574803!
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.Empty
        Me.Detail.CanGrow = False
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label16, Me.OTHER_NOTE, Me.Label36, Me.Label41, Me.TEHAI_TANTO_EIGYOSHO, Me.Label46, Me.Label42, Me.Label13, Me.Line34, Me.Label32, Me.KAISAI_KIBOU_ADDRESS2, Me.KOUSHI_ROOM_CNT, Me.MANAGER_ROOM_CNT, Me.Label72, Me.Label70, Me.Label67, Me.Label65, Me.SHAIN_ROOM_TEHAI_No, Me.SHAIN_ROOM_TEHAI_Yes, Me.Label69, Me.Label77, Me.Label76, Me.KAISAI_KIBOU_NOTE, Me.KAISAI_DATE_NOTE, Me.Label31, Me.Label30, Me.KOUEN_KAIJO_LAYOUT, Me.Label74, Me.Label39, Me.Label33, Me.Label11, Me.Label62, Me.Label35, Me.Label34, Me.KOUEN_TIME1, Me.Label20, Me.SANKA_YOTEI_CNT_MBR, Me.Label56, Me.Label57, Me.Label58, Me.Label59, Me.KIKAKU_TANTO_EMAIL_PC, Me.KIKAKU_TANTO_ROMA, Me.KIKAKU_TANTO_TEL, Me.KIKAKU_TANTO_KEITAI, Me.KIKAKU_TANTO_NAME, Me.KIKAKU_TANTO_EMAIL_KEITAI, Me.Label50, Me.Label49, Me.Label48, Me.KOUENKAI_NO, Me.ZETIA_CD, Me.SEIHIN_NAME, Me.REQ_STATUS_TEHAI, Me.Label40, Me.Label12, Me.Label22, Me.KIKAKU_TANTO_EIGYOSHO, Me.KIKAKU_TANTO_AREA, Me.BU, Me.Label47, Me.Label18, Me.Label17, Me.Label44, Me.Label45, Me.SHONIN_NAME, Me.SHONIN_DATE, Me.TAXI_PRT_NAME, Me.TIME_STAMP_BYL, Me.Label37, Me.Label10, Me.Label43, Me.TEHAI_ID, Me.Label9, Me.KOUENKAI_NAME, Me.SEND_FLAG, Me.Label6, Me.Label7, Me.Label14, Me.FROM_DATE, Me.TO_DATE, Me.KAIJO_NAME, Me.Line1, Me.Line30, Me.Line40, Me.Line43, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line14, Me.Line46, Me.Line47, Me.Line54, Me.Line55, Me.TEHAI_TANTO_EMAIL_PC, Me.TEHAI_TANTO_ROMA, Me.TEHAI_TANTO_TEL, Me.TEHAI_TANTO_KEITAI, Me.TEHAI_TANTO_NAME, Me.TEHAI_TANTO_EMAIL_KEITAI, Me.Label5, Me.Label51, Me.Label52, Me.TEHAI_TANTO_AREA, Me.TEHAI_TANTO_BU, Me.Label53, Me.Label54, Me.Label55, Me.Line9, Me.Line56, Me.Line57, Me.Line59, Me.Line60, Me.Line61, Me.Line62, Me.Line63, Me.Label15, Me.Label19, Me.SANKA_YOTEI_CNT_NMBR, Me.SRM_HACYU_KBN, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.YOSAN_TF, Me.YOSAN_T, Me.YOSAN_TOTAL, Me.Label27, Me.Label28, Me.IKENKOUKAN_YOSAN_T, Me.IROUKAI_YOSAN_T, Me.Line10, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line65, Me.Line64, Me.Label29, Me.Line16, Me.KAISAI_KIBOU_ADDRESS1, Me.Line38, Me.Line11, Me.Line70, Me.KOUEN_TIME2, Me.Line71, Me.Line72, Me.Label63, Me.Label64, Me.Label66, Me.Label68, Me.Label71, Me.Label73, Me.IKENKOUKAN_KAIJO_TEHAI_Yes, Me.IROUKAI_KAIJO_TEHAI_Yes, Me.IROUKAI_SANKA_YOTEI_CNT, Me.KOUSHI_ROOM_TEHAI_Yes, Me.KOUSHI_ROOM_FROM, Me.SHAIN_ROOM_CNT, Me.MANAGER_KAIJO_TEHAI_Yes, Me.MANAGER_ROOM_FROM, Me.REQ_STAY_DATE, Me.REQ_ROOM_CNT, Me.REQ_KOTSU_CNT, Me.REQ_TAXI_CNT, Me.Line82, Me.Line83, Me.Line84, Me.Line85, Me.Label75, Me.MANAGER_KAIJO_TEHAI_No, Me.KOUSHI_ROOM_TEHAI_No, Me.IROUKAI_KAIJO_TEHAI_No, Me.IKENKOUKAN_KAIJO_TEHAI_No, Me.Label78, Me.Line67, Me.Line76, Me.Line77, Me.Line78, Me.Line79, Me.Line75, Me.Line69, Me.Line73, Me.Line68, Me.Line32, Me.Line13, Me.Line12, Me.Line66, Me.Line31, Me.Line42, Me.Line44, Me.Line74, Me.Line35, Me.Line41, Me.Line28, Me.Line36, Me.Line53, Me.Line52, Me.Line51, Me.Line50, Me.Line49, Me.Line29, Me.Line33, Me.Line7, Me.Line2, Me.Line45, Me.Line48, Me.Line58, Me.Line17, Me.Line8, Me.Line80, Me.Line26, Me.Line27, Me.Line15})
        Me.Detail.Height = 10.36693!
        Me.Detail.Name = "Detail"
        Me.Detail.NewPage = DataDynamics.ActiveReports.NewPage.After
        '
        'Label16
        '
        Me.Label16.Height = 0.2559055!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label16.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label16.Text = "Zetia Code"
        Me.Label16.Top = 1.437008!
        Me.Label16.Width = 1.728346!
        '
        'OTHER_NOTE
        '
        Me.OTHER_NOTE.CanGrow = False
        Me.OTHER_NOTE.DataField = "OTHER_NOTE"
        Me.OTHER_NOTE.Height = 0.7480315!
        Me.OTHER_NOTE.Left = 1.729921!
        Me.OTHER_NOTE.Name = "OTHER_NOTE"
        Me.OTHER_NOTE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.OTHER_NOTE.Style = "font-family: ＭＳ ゴシック"
        Me.OTHER_NOTE.Text = "OTHER_NOTE"
        Me.OTHER_NOTE.Top = 9.611811!
        Me.OTHER_NOTE.Width = 6.294882!
        '
        'Label36
        '
        Me.Label36.Height = 0.7480315!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 0.0!
        Me.Label36.Name = "Label36"
        Me.Label36.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label36.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label36.Text = "その他備考欄"
        Me.Label36.Top = 9.611811!
        Me.Label36.Width = 1.728346!
        '
        'Label41
        '
        Me.Label41.Height = 0.2559055!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0.001574803!
        Me.Label41.Name = "Label41"
        Me.Label41.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label41.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label41.Text = "携帯アドレス"
        Me.Label41.Top = 2.716536!
        Me.Label41.Width = 1.728346!
        '
        'TEHAI_TANTO_EIGYOSHO
        '
        Me.TEHAI_TANTO_EIGYOSHO.CanGrow = False
        Me.TEHAI_TANTO_EIGYOSHO.DataField = "TEHAI_TANTO_EIGYOSHO"
        Me.TEHAI_TANTO_EIGYOSHO.Height = 0.2559055!
        Me.TEHAI_TANTO_EIGYOSHO.Left = 6.064174!
        Me.TEHAI_TANTO_EIGYOSHO.Name = "TEHAI_TANTO_EIGYOSHO"
        Me.TEHAI_TANTO_EIGYOSHO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_EIGYOSHO.Text = "TEHAI_TANTO_EIGYOSHO"
        Me.TEHAI_TANTO_EIGYOSHO.Top = 2.972441!
        Me.TEHAI_TANTO_EIGYOSHO.Width = 1.968504!
        '
        'Label46
        '
        Me.Label46.Height = 0.2559055!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 3.050394!
        Me.Label46.Name = "Label46"
        Me.Label46.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label46.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label46.Text = "エリア"
        Me.Label46.Top = 1.948819!
        Me.Label46.Width = 0.5905512!
        '
        'Label42
        '
        Me.Label42.Height = 0.2559055!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 1.731102!
        Me.Label42.Name = "Label42"
        Me.Label42.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label42.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label42.Text = "BU"
        Me.Label42.Top = 1.948819!
        Me.Label42.Width = 0.3334646!
        '
        'Label13
        '
        Me.Label13.Height = 0.2559055!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label13.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label13.Text = "■会合 企画担当者"
        Me.Label13.Top = 1.948819!
        Me.Label13.Width = 1.728346!
        '
        'Line34
        '
        Me.Line34.Height = 1.112599!
        Me.Line34.Left = 1.729921!
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 0.6692914!
        Me.Line34.Width = 0.0!
        Me.Line34.X1 = 1.729921!
        Me.Line34.X2 = 1.729921!
        Me.Line34.Y1 = 0.6692914!
        Me.Line34.Y2 = 1.78189!
        '
        'Label32
        '
        Me.Label32.Height = 0.2559055!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 3.409055!
        Me.Label32.Name = "Label32"
        Me.Label32.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label32.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label32.Text = "市町村"
        Me.Label32.Top = 5.033465!
        Me.Label32.Width = 0.5590551!
        '
        'KAISAI_KIBOU_ADDRESS2
        '
        Me.KAISAI_KIBOU_ADDRESS2.CanGrow = False
        Me.KAISAI_KIBOU_ADDRESS2.DataField = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Height = 0.2559056!
        Me.KAISAI_KIBOU_ADDRESS2.Left = 3.968111!
        Me.KAISAI_KIBOU_ADDRESS2.Name = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KAISAI_KIBOU_ADDRESS2.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KAISAI_KIBOU_ADDRESS2.Text = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Top = 5.033465!
        Me.KAISAI_KIBOU_ADDRESS2.Width = 4.059055!
        '
        'KOUSHI_ROOM_CNT
        '
        Me.KOUSHI_ROOM_CNT.CanGrow = False
        Me.KOUSHI_ROOM_CNT.DataField = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Height = 0.2559055!
        Me.KOUSHI_ROOM_CNT.Left = 7.218898!
        Me.KOUSHI_ROOM_CNT.Name = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUSHI_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KOUSHI_ROOM_CNT.Text = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Top = 7.809056!
        Me.KOUSHI_ROOM_CNT.Width = 0.7992126!
        '
        'MANAGER_ROOM_CNT
        '
        Me.MANAGER_ROOM_CNT.CanGrow = False
        Me.MANAGER_ROOM_CNT.DataField = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Height = 0.2559055!
        Me.MANAGER_ROOM_CNT.Left = 7.21378!
        Me.MANAGER_ROOM_CNT.Name = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.MANAGER_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.MANAGER_ROOM_CNT.Text = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Top = 8.320871!
        Me.MANAGER_ROOM_CNT.Width = 0.7992126!
        '
        'Label72
        '
        Me.Label72.Height = 0.2559055!
        Me.Label72.HyperLink = Nothing
        Me.Label72.Left = 3.640159!
        Me.Label72.Name = "Label72"
        Me.Label72.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label72.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label72.Text = "世話人控室(時間 From)"
        Me.Label72.Top = 8.320871!
        Me.Label72.Width = 1.574803!
        '
        'Label70
        '
        Me.Label70.Height = 0.2559055!
        Me.Label70.HyperLink = Nothing
        Me.Label70.Left = 3.640158!
        Me.Label70.Name = "Label70"
        Me.Label70.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label70.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label70.Text = "人数"
        Me.Label70.Top = 8.064966!
        Me.Label70.Width = 1.574803!
        '
        'Label67
        '
        Me.Label67.Height = 0.2559055!
        Me.Label67.HyperLink = Nothing
        Me.Label67.Left = 3.640158!
        Me.Label67.Name = "Label67"
        Me.Label67.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label67.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label67.Text = "時間 From"
        Me.Label67.Top = 7.809056!
        Me.Label67.Width = 1.574803!
        '
        'Label65
        '
        Me.Label65.Height = 0.2559055!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 3.640158!
        Me.Label65.Name = "Label65"
        Me.Label65.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label65.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label65.Text = "参加予定者数"
        Me.Label65.Top = 7.55315!
        Me.Label65.Width = 1.574803!
        '
        'SHAIN_ROOM_TEHAI_No
        '
        Me.SHAIN_ROOM_TEHAI_No.CanGrow = False
        Me.SHAIN_ROOM_TEHAI_No.DataField = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI_No.Height = 0.2559055!
        Me.SHAIN_ROOM_TEHAI_No.Left = 3.194095!
        Me.SHAIN_ROOM_TEHAI_No.Name = "SHAIN_ROOM_TEHAI_No"
        Me.SHAIN_ROOM_TEHAI_No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SHAIN_ROOM_TEHAI_No.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.SHAIN_ROOM_TEHAI_No.Text = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI_No.Top = 8.064966!
        Me.SHAIN_ROOM_TEHAI_No.Width = 0.446063!
        '
        'SHAIN_ROOM_TEHAI_Yes
        '
        Me.SHAIN_ROOM_TEHAI_Yes.CanGrow = False
        Me.SHAIN_ROOM_TEHAI_Yes.DataField = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI_Yes.Height = 0.2559055!
        Me.SHAIN_ROOM_TEHAI_Yes.Left = 2.748033!
        Me.SHAIN_ROOM_TEHAI_Yes.Name = "SHAIN_ROOM_TEHAI_Yes"
        Me.SHAIN_ROOM_TEHAI_Yes.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SHAIN_ROOM_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.SHAIN_ROOM_TEHAI_Yes.Text = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI_Yes.Top = 8.064966!
        Me.SHAIN_ROOM_TEHAI_Yes.Width = 0.446063!
        '
        'Label69
        '
        Me.Label69.Height = 0.2559055!
        Me.Label69.HyperLink = Nothing
        Me.Label69.Left = 1.729921!
        Me.Label69.Name = "Label69"
        Me.Label69.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label69.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label69.Text = "社員控室"
        Me.Label69.Top = 8.064966!
        Me.Label69.Width = 1.01811!
        '
        'Label77
        '
        Me.Label77.Height = 0.2559055!
        Me.Label77.HyperLink = Nothing
        Me.Label77.Left = 3.194095!
        Me.Label77.Name = "Label77"
        Me.Label77.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label77.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; text-align: cen" & _
            "ter; vertical-align: middle"
        Me.Label77.Text = "不要"
        Me.Label77.Top = 7.041339!
        Me.Label77.Width = 0.446063!
        '
        'Label76
        '
        Me.Label76.Height = 0.2559055!
        Me.Label76.HyperLink = Nothing
        Me.Label76.Left = 2.748032!
        Me.Label76.Name = "Label76"
        Me.Label76.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label76.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; text-align: cen" & _
            "ter; vertical-align: middle"
        Me.Label76.Text = "要"
        Me.Label76.Top = 7.041339!
        Me.Label76.Width = 0.446063!
        '
        'KAISAI_KIBOU_NOTE
        '
        Me.KAISAI_KIBOU_NOTE.CanGrow = False
        Me.KAISAI_KIBOU_NOTE.DataField = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Height = 0.7480315!
        Me.KAISAI_KIBOU_NOTE.Left = 2.509449!
        Me.KAISAI_KIBOU_NOTE.Name = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.KAISAI_KIBOU_NOTE.Style = "font-family: ＭＳ ゴシック"
        Me.KAISAI_KIBOU_NOTE.Text = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Top = 6.293307!
        Me.KAISAI_KIBOU_NOTE.Width = 5.511811!
        '
        'KAISAI_DATE_NOTE
        '
        Me.KAISAI_DATE_NOTE.CanGrow = False
        Me.KAISAI_DATE_NOTE.DataField = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Height = 0.7480315!
        Me.KAISAI_DATE_NOTE.Left = 2.509449!
        Me.KAISAI_DATE_NOTE.Name = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.KAISAI_DATE_NOTE.Style = "font-family: ＭＳ ゴシック"
        Me.KAISAI_DATE_NOTE.Text = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Top = 5.289371!
        Me.KAISAI_DATE_NOTE.Width = 5.511811!
        '
        'Label31
        '
        Me.Label31.Height = 0.7480315!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 1.729921!
        Me.Label31.Name = "Label31"
        Me.Label31.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label31.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label31.Text = "開催日備考"
        Me.Label31.Top = 5.289371!
        Me.Label31.Width = 0.7795276!
        '
        'Label30
        '
        Me.Label30.Height = 0.7480315!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 1.729921!
        Me.Label30.Name = "Label30"
        Me.Label30.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label30.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label30.Text = "開催希望地"
        Me.Label30.Top = 6.293307!
        Me.Label30.Width = 0.7795276!
        '
        'KOUEN_KAIJO_LAYOUT
        '
        Me.KOUEN_KAIJO_LAYOUT.CanGrow = False
        Me.KOUEN_KAIJO_LAYOUT.DataField = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Height = 0.2559055!
        Me.KOUEN_KAIJO_LAYOUT.Left = 6.614567!
        Me.KOUEN_KAIJO_LAYOUT.Name = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUEN_KAIJO_LAYOUT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KOUEN_KAIJO_LAYOUT.Text = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Top = 6.037402!
        Me.KOUEN_KAIJO_LAYOUT.Width = 1.417323!
        '
        'Label74
        '
        Me.Label74.Height = 0.2559055!
        Me.Label74.HyperLink = Nothing
        Me.Label74.Left = 0.0000004768372!
        Me.Label74.Name = "Label74"
        Me.Label74.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label74.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label74.Text = "宿泊希望室数"
        Me.Label74.Top = 8.833857!
        Me.Label74.Width = 1.728346!
        '
        'Label39
        '
        Me.Label39.Height = 0.2559055!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 0.0!
        Me.Label39.Name = "Label39"
        Me.Label39.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label39.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label39.Text = "宿泊希望日"
        Me.Label39.Top = 8.577953!
        Me.Label39.Width = 1.728346!
        '
        'Label33
        '
        Me.Label33.Height = 0.2559055!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.0000004768372!
        Me.Label33.Name = "Label33"
        Me.Label33.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label33.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label33.Text = "タクシー手配予定人数"
        Me.Label33.Top = 9.34567!
        Me.Label33.Width = 1.728346!
        '
        'Label11
        '
        Me.Label11.Height = 0.2559055!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.0000004768372!
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label11.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label11.Text = "交通手配予定人数(JR/AIR)"
        Me.Label11.Top = 9.089765!
        Me.Label11.Width = 1.728346!
        '
        'Label62
        '
        Me.Label62.Height = 0.2559055!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 3.748032!
        Me.Label62.Name = "Label62"
        Me.Label62.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label62.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label62.Text = "会合終了時間"
        Me.Label62.Top = 6.037402!
        Me.Label62.Width = 1.01811!
        '
        'Label35
        '
        Me.Label35.Height = 0.2559055!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 5.766142!
        Me.Label35.Name = "Label35"
        Me.Label35.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label35.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label35.Text = "レイアウト"
        Me.Label35.Top = 6.037402!
        Me.Label35.Width = 0.8484252!
        '
        'Label34
        '
        Me.Label34.Height = 0.2559055!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 1.729922!
        Me.Label34.Name = "Label34"
        Me.Label34.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label34.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label34.Text = "会合開始時間"
        Me.Label34.Top = 6.037402!
        Me.Label34.Width = 1.01811!
        '
        'KOUEN_TIME1
        '
        Me.KOUEN_TIME1.CanGrow = False
        Me.KOUEN_TIME1.DataField = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Height = 0.2559055!
        Me.KOUEN_TIME1.Left = 2.748032!
        Me.KOUEN_TIME1.Name = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUEN_TIME1.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KOUEN_TIME1.Text = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Top = 6.037402!
        Me.KOUEN_TIME1.Width = 1.0!
        '
        'Label20
        '
        Me.Label20.Height = 0.5118114!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.0!
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label20.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label20.Text = "総予算額(円)"
        Me.Label20.Top = 4.521654!
        Me.Label20.Width = 1.728346!
        '
        'SANKA_YOTEI_CNT_MBR
        '
        Me.SANKA_YOTEI_CNT_MBR.CanGrow = False
        Me.SANKA_YOTEI_CNT_MBR.DataField = "SANKA_YOTEI_CNT_MBR"
        Me.SANKA_YOTEI_CNT_MBR.Height = 0.2559055!
        Me.SANKA_YOTEI_CNT_MBR.Left = 5.619292!
        Me.SANKA_YOTEI_CNT_MBR.Name = "SANKA_YOTEI_CNT_MBR"
        Me.SANKA_YOTEI_CNT_MBR.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SANKA_YOTEI_CNT_MBR.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SANKA_YOTEI_CNT_MBR.Text = "SANKA_YOTEI_CNT_MBR"
        Me.SANKA_YOTEI_CNT_MBR.Top = 3.996063!
        Me.SANKA_YOTEI_CNT_MBR.Width = 2.413386!
        '
        'Label56
        '
        Me.Label56.Height = 0.2559055!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 0.0!
        Me.Label56.Name = "Label56"
        Me.Label56.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label56.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label56.Text = "携帯アドレス"
        Me.Label56.Top = 3.740158!
        Me.Label56.Width = 1.728346!
        '
        'Label57
        '
        Me.Label57.Height = 0.2559055!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 0.0!
        Me.Label57.Name = "Label57"
        Me.Label57.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label57.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label57.Text = "携帯電話番号"
        Me.Label57.Top = 3.484252!
        Me.Label57.Width = 1.728346!
        '
        'Label58
        '
        Me.Label58.Height = 0.2559055!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 0.0!
        Me.Label58.Name = "Label58"
        Me.Label58.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label58.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label58.Text = "企画担当者 氏名"
        Me.Label58.Top = 3.228347!
        Me.Label58.Width = 1.728346!
        '
        'Label59
        '
        Me.Label59.Height = 0.2559055!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 0.0!
        Me.Label59.Name = "Label59"
        Me.Label59.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label59.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label59.Text = "■会合 手配担当者"
        Me.Label59.Top = 2.972441!
        Me.Label59.Width = 1.728346!
        '
        'KIKAKU_TANTO_EMAIL_PC
        '
        Me.KIKAKU_TANTO_EMAIL_PC.CanGrow = False
        Me.KIKAKU_TANTO_EMAIL_PC.DataField = "KIKAKU_TANTO_EMAIL_PC"
        Me.KIKAKU_TANTO_EMAIL_PC.Height = 0.2559055!
        Me.KIKAKU_TANTO_EMAIL_PC.Left = 5.619292!
        Me.KIKAKU_TANTO_EMAIL_PC.Name = "KIKAKU_TANTO_EMAIL_PC"
        Me.KIKAKU_TANTO_EMAIL_PC.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_EMAIL_PC.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_EMAIL_PC.Text = "KIKAKU_TANTO_EMAIL_PC"
        Me.KIKAKU_TANTO_EMAIL_PC.Top = 2.716536!
        Me.KIKAKU_TANTO_EMAIL_PC.Width = 2.413386!
        '
        'KIKAKU_TANTO_ROMA
        '
        Me.KIKAKU_TANTO_ROMA.CanGrow = False
        Me.KIKAKU_TANTO_ROMA.DataField = "KIKAKU_TANTO_ROMA"
        Me.KIKAKU_TANTO_ROMA.Height = 0.2559055!
        Me.KIKAKU_TANTO_ROMA.Left = 5.619292!
        Me.KIKAKU_TANTO_ROMA.Name = "KIKAKU_TANTO_ROMA"
        Me.KIKAKU_TANTO_ROMA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_ROMA.Text = "KIKAKU_TANTO_ROMA"
        Me.KIKAKU_TANTO_ROMA.Top = 2.204725!
        Me.KIKAKU_TANTO_ROMA.Width = 2.413386!
        '
        'KIKAKU_TANTO_TEL
        '
        Me.KIKAKU_TANTO_TEL.CanGrow = False
        Me.KIKAKU_TANTO_TEL.DataField = "KIKAKU_TANTO_TEL"
        Me.KIKAKU_TANTO_TEL.Height = 0.2559055!
        Me.KIKAKU_TANTO_TEL.Left = 5.619292!
        Me.KIKAKU_TANTO_TEL.Name = "KIKAKU_TANTO_TEL"
        Me.KIKAKU_TANTO_TEL.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_TEL.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_TEL.Text = "KIKAKU_TANTO_TEL"
        Me.KIKAKU_TANTO_TEL.Top = 2.46063!
        Me.KIKAKU_TANTO_TEL.Width = 2.413386!
        '
        'KIKAKU_TANTO_KEITAI
        '
        Me.KIKAKU_TANTO_KEITAI.CanGrow = False
        Me.KIKAKU_TANTO_KEITAI.DataField = "KIKAKU_TANTO_KEITAI"
        Me.KIKAKU_TANTO_KEITAI.Height = 0.2559055!
        Me.KIKAKU_TANTO_KEITAI.Left = 1.731496!
        Me.KIKAKU_TANTO_KEITAI.Name = "KIKAKU_TANTO_KEITAI"
        Me.KIKAKU_TANTO_KEITAI.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_KEITAI.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_KEITAI.Text = "KIKAKU_TANTO_KEITAI"
        Me.KIKAKU_TANTO_KEITAI.Top = 2.46063!
        Me.KIKAKU_TANTO_KEITAI.Width = 2.413386!
        '
        'KIKAKU_TANTO_NAME
        '
        Me.KIKAKU_TANTO_NAME.CanGrow = False
        Me.KIKAKU_TANTO_NAME.DataField = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Height = 0.2559055!
        Me.KIKAKU_TANTO_NAME.Left = 1.731496!
        Me.KIKAKU_TANTO_NAME.Name = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_NAME.Text = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Top = 2.204725!
        Me.KIKAKU_TANTO_NAME.Width = 2.413386!
        '
        'KIKAKU_TANTO_EMAIL_KEITAI
        '
        Me.KIKAKU_TANTO_EMAIL_KEITAI.CanGrow = False
        Me.KIKAKU_TANTO_EMAIL_KEITAI.DataField = "KIKAKU_TANTO_EMAIL_KEITAI"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Height = 0.2559055!
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Left = 1.731496!
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Name = "KIKAKU_TANTO_EMAIL_KEITAI"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Text = "KIKAKU_TANTO_EMAIL_KEITAI"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Top = 2.716536!
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Width = 2.413386!
        '
        'Label50
        '
        Me.Label50.Height = 0.2559055!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 4.146457!
        Me.Label50.Name = "Label50"
        Me.Label50.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label50.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label50.Text = "E Mailアドレス"
        Me.Label50.Top = 2.716536!
        Me.Label50.Width = 1.466929!
        '
        'Label49
        '
        Me.Label49.Height = 0.2559055!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 4.144882!
        Me.Label49.Name = "Label49"
        Me.Label49.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label49.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label49.Text = "オフィス電話番号"
        Me.Label49.Top = 2.46063!
        Me.Label49.Width = 1.466929!
        '
        'Label48
        '
        Me.Label48.Height = 0.2559055!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 4.144882!
        Me.Label48.Name = "Label48"
        Me.Label48.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label48.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label48.Text = "企画担当者(ローマ字)"
        Me.Label48.Top = 2.203543!
        Me.Label48.Width = 1.466929!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.2559055!
        Me.KOUENKAI_NO.Left = 1.731496!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KOUENKAI_NO.Text = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Top = 0.6692914!
        Me.KOUENKAI_NO.Width = 2.413386!
        '
        'ZETIA_CD
        '
        Me.ZETIA_CD.CanGrow = False
        Me.ZETIA_CD.DataField = "ZETIA_CD"
        Me.ZETIA_CD.Height = 0.2559055!
        Me.ZETIA_CD.Left = 1.731496!
        Me.ZETIA_CD.Name = "ZETIA_CD"
        Me.ZETIA_CD.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.ZETIA_CD.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.ZETIA_CD.Text = "ZETIA_CD"
        Me.ZETIA_CD.Top = 1.437008!
        Me.ZETIA_CD.Width = 6.299212!
        '
        'SEIHIN_NAME
        '
        Me.SEIHIN_NAME.CanGrow = False
        Me.SEIHIN_NAME.DataField = "SEIHIN_NAME"
        Me.SEIHIN_NAME.Height = 0.2559055!
        Me.SEIHIN_NAME.Left = 1.731496!
        Me.SEIHIN_NAME.Name = "SEIHIN_NAME"
        Me.SEIHIN_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SEIHIN_NAME.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SEIHIN_NAME.Text = "SEIHIN_NAME"
        Me.SEIHIN_NAME.Top = 1.181102!
        Me.SEIHIN_NAME.Width = 2.413386!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.CanGrow = False
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.2559055!
        Me.REQ_STATUS_TEHAI.Left = 1.731496!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.REQ_STATUS_TEHAI.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.REQ_STATUS_TEHAI.Text = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Top = 0.9251969!
        Me.REQ_STATUS_TEHAI.Width = 2.413386!
        '
        'Label40
        '
        Me.Label40.Height = 0.2559055!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 0.0!
        Me.Label40.Name = "Label40"
        Me.Label40.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label40.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label40.Text = "依頼内容"
        Me.Label40.Top = 0.9251969!
        Me.Label40.Width = 1.728346!
        '
        'Label12
        '
        Me.Label12.Height = 0.2559055!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0000002384186!
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label12.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label12.Text = "製品名"
        Me.Label12.Top = 1.181102!
        Me.Label12.Width = 1.728346!
        '
        'Label22
        '
        Me.Label22.Height = 0.2559055!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.0!
        Me.Label22.Name = "Label22"
        Me.Label22.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label22.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label22.Text = "会合番号"
        Me.Label22.Top = 0.6692907!
        Me.Label22.Width = 1.728346!
        '
        'KIKAKU_TANTO_EIGYOSHO
        '
        Me.KIKAKU_TANTO_EIGYOSHO.CanGrow = False
        Me.KIKAKU_TANTO_EIGYOSHO.DataField = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Height = 0.2559055!
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 6.064174!
        Me.KIKAKU_TANTO_EIGYOSHO.Name = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_EIGYOSHO.Text = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Top = 1.948819!
        Me.KIKAKU_TANTO_EIGYOSHO.Width = 1.968504!
        '
        'KIKAKU_TANTO_AREA
        '
        Me.KIKAKU_TANTO_AREA.CanGrow = False
        Me.KIKAKU_TANTO_AREA.DataField = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Height = 0.2559055!
        Me.KIKAKU_TANTO_AREA.Left = 3.640945!
        Me.KIKAKU_TANTO_AREA.Name = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KIKAKU_TANTO_AREA.Text = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Top = 1.948819!
        Me.KIKAKU_TANTO_AREA.Width = 1.850394!
        '
        'BU
        '
        Me.BU.CanGrow = False
        Me.BU.DataField = "BU"
        Me.BU.Height = 0.2559055!
        Me.BU.Left = 2.066142!
        Me.BU.Name = "BU"
        Me.BU.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.BU.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.BU.Text = "BU"
        Me.BU.Top = 1.948819!
        Me.BU.Width = 0.984252!
        '
        'Label47
        '
        Me.Label47.Height = 0.2559055!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 5.491339!
        Me.Label47.Name = "Label47"
        Me.Label47.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label47.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label47.Text = "営業所"
        Me.Label47.Top = 1.948819!
        Me.Label47.Width = 0.5708662!
        '
        'Label18
        '
        Me.Label18.Height = 0.2559055!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0!
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label18.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label18.Text = "携帯電話番号"
        Me.Label18.Top = 2.46063!
        Me.Label18.Width = 1.728346!
        '
        'Label17
        '
        Me.Label17.Height = 0.2559055!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.0!
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label17.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label17.Text = "企画担当者 氏名"
        Me.Label17.Top = 2.204725!
        Me.Label17.Width = 1.728346!
        '
        'Label44
        '
        Me.Label44.Height = 0.2559055!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 0.0!
        Me.Label44.Name = "Label44"
        Me.Label44.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label44.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label44.Text = "最終承認者(氏名)"
        Me.Label44.Top = 1.692914!
        Me.Label44.Width = 1.728346!
        '
        'Label45
        '
        Me.Label45.Height = 0.2559055!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 4.144882!
        Me.Label45.Name = "Label45"
        Me.Label45.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label45.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label45.Text = "最終承認日"
        Me.Label45.Top = 1.692914!
        Me.Label45.Width = 1.466929!
        '
        'SHONIN_NAME
        '
        Me.SHONIN_NAME.CanGrow = False
        Me.SHONIN_NAME.DataField = "SHONIN_NAME"
        Me.SHONIN_NAME.Height = 0.2559055!
        Me.SHONIN_NAME.Left = 1.731496!
        Me.SHONIN_NAME.Name = "SHONIN_NAME"
        Me.SHONIN_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SHONIN_NAME.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SHONIN_NAME.Text = "SHONIN_NAME"
        Me.SHONIN_NAME.Top = 1.692915!
        Me.SHONIN_NAME.Width = 2.413386!
        '
        'SHONIN_DATE
        '
        Me.SHONIN_DATE.CanGrow = False
        Me.SHONIN_DATE.DataField = "SHONIN_DATE"
        Me.SHONIN_DATE.Height = 0.2559055!
        Me.SHONIN_DATE.Left = 5.618505!
        Me.SHONIN_DATE.Name = "SHONIN_DATE"
        Me.SHONIN_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SHONIN_DATE.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SHONIN_DATE.Text = "SHONIN_DATE"
        Me.SHONIN_DATE.Top = 1.692914!
        Me.SHONIN_DATE.Width = 2.413386!
        '
        'TAXI_PRT_NAME
        '
        Me.TAXI_PRT_NAME.CanGrow = False
        Me.TAXI_PRT_NAME.DataField = "TAXI_PRT_NAME"
        Me.TAXI_PRT_NAME.Height = 0.2559055!
        Me.TAXI_PRT_NAME.Left = 5.618505!
        Me.TAXI_PRT_NAME.Name = "TAXI_PRT_NAME"
        Me.TAXI_PRT_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TAXI_PRT_NAME.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TAXI_PRT_NAME.Text = "TAXI_PRT_NAME"
        Me.TAXI_PRT_NAME.Top = 1.181102!
        Me.TAXI_PRT_NAME.Width = 2.413386!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.CanGrow = False
        Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Height = 0.2559055!
        Me.TIME_STAMP_BYL.Left = 5.618505!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TIME_STAMP_BYL.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TIME_STAMP_BYL.Text = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Top = 0.9251969!
        Me.TIME_STAMP_BYL.Width = 2.413386!
        '
        'Label37
        '
        Me.Label37.Height = 0.2559055!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 4.144882!
        Me.Label37.Name = "Label37"
        Me.Label37.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label37.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label37.Text = "会合手配Id"
        Me.Label37.Top = 0.6692914!
        Me.Label37.Width = 1.466929!
        '
        'Label10
        '
        Me.Label10.Height = 0.2559055!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.144882!
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label10.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label10.Text = "Timestamp (BYL)"
        Me.Label10.Top = 0.9251969!
        Me.Label10.Width = 1.466929!
        '
        'Label43
        '
        Me.Label43.Height = 0.2559055!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 4.144882!
        Me.Label43.Name = "Label43"
        Me.Label43.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label43.Style = "background-color: #B5B5B5; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label43.Text = "チケット印字名"
        Me.Label43.Top = 1.181102!
        Me.Label43.Width = 1.466929!
        '
        'TEHAI_ID
        '
        Me.TEHAI_ID.CanGrow = False
        Me.TEHAI_ID.DataField = "TEHAI_ID"
        Me.TEHAI_ID.Height = 0.2559055!
        Me.TEHAI_ID.Left = 5.618505!
        Me.TEHAI_ID.Name = "TEHAI_ID"
        Me.TEHAI_ID.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_ID.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_ID.Text = "TEHAI_ID"
        Me.TEHAI_ID.Top = 0.6692914!
        Me.TEHAI_ID.Width = 2.413386!
        '
        'Label9
        '
        Me.Label9.Height = 0.1909449!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.01023622!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: top; wh" & _
            "ite-space: nowrap"
        Me.Label9.Text = "会合名："
        Me.Label9.Top = 0.01023622!
        Me.Label9.Width = 0.7496063!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.1909449!
        Me.KOUENKAI_NAME.Left = 0.7700788!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: top; wh" & _
            "ite-space: nowrap"
        Me.KOUENKAI_NAME.Text = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Top = 0.01023622!
        Me.KOUENKAI_NAME.Width = 5.612598!
        '
        'SEND_FLAG
        '
        Me.SEND_FLAG.CanGrow = False
        Me.SEND_FLAG.DataField = "SEND_FLAG"
        Me.SEND_FLAG.Height = 0.1968504!
        Me.SEND_FLAG.Left = 7.368505!
        Me.SEND_FLAG.Name = "SEND_FLAG"
        Me.SEND_FLAG.Style = "font-family: ＭＳ ゴシック; text-align: left; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.SEND_FLAG.Text = "◎◎◎◎"
        Me.SEND_FLAG.Top = 0.07480322!
        Me.SEND_FLAG.Visible = False
        Me.SEND_FLAG.Width = 0.6389766!
        '
        'Label6
        '
        Me.Label6.Height = 0.1770833!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.503937!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: right; vertical-align: middle"
        Me.Label6.Text = "NOZOMI送信："
        Me.Label6.Top = 0.07480322!
        Me.Label6.Visible = False
        Me.Label6.Width = 0.8956695!
        '
        'Label7
        '
        Me.Label7.Height = 0.1909449!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.01023622!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: top; wh" & _
            "ite-space: nowrap"
        Me.Label7.Text = "開催日："
        Me.Label7.Top = 0.2232284!
        Me.Label7.Width = 0.7496063!
        '
        'Label14
        '
        Me.Label14.Height = 0.1909449!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.01023622!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: top; wh" & _
            "ite-space: nowrap"
        Me.Label14.Text = "開催場所:"
        Me.Label14.Top = 0.4362205!
        Me.Label14.Width = 0.7496063!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.1909449!
        Me.FROM_DATE.Left = 0.7700788!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: top; wh" & _
            "ite-space: nowrap"
        Me.FROM_DATE.Text = "FROM_DATE"
        Me.FROM_DATE.Top = 0.2232284!
        Me.FROM_DATE.Width = 5.612598!
        '
        'TO_DATE
        '
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.1968504!
        Me.TO_DATE.Left = 6.887796!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.TO_DATE.Text = "TO_DATE"
        Me.TO_DATE.Top = 0.2519686!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 1.119685!
        '
        'KAIJO_NAME
        '
        Me.KAIJO_NAME.DataField = "KAIJO_NAME"
        Me.KAIJO_NAME.Height = 0.1909449!
        Me.KAIJO_NAME.Left = 0.7700788!
        Me.KAIJO_NAME.Name = "KAIJO_NAME"
        Me.KAIJO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: top; wh" & _
            "ite-space: nowrap"
        Me.KAIJO_NAME.Text = "KAIJO_NAME"
        Me.KAIJO_NAME.Top = 0.4362205!
        Me.KAIJO_NAME.Width = 5.612598!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.9251969!
        Me.Line1.Width = 8.035433!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 8.035433!
        Me.Line1.Y1 = 0.9251969!
        Me.Line1.Y2 = 0.9251969!
        '
        'Line30
        '
        Me.Line30.Height = 0.7677166!
        Me.Line30.Left = 5.611812!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 0.6692914!
        Me.Line30.Width = 0.0!
        Me.Line30.X1 = 5.611812!
        Me.Line30.X2 = 5.611812!
        Me.Line30.Y1 = 0.6692914!
        Me.Line30.Y2 = 1.437008!
        '
        'Line40
        '
        Me.Line40.Height = 0.0!
        Me.Line40.Left = 0.0!
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 1.181102!
        Me.Line40.Width = 8.035432!
        Me.Line40.X1 = 0.0!
        Me.Line40.X2 = 8.035432!
        Me.Line40.Y1 = 1.181102!
        Me.Line40.Y2 = 1.181102!
        '
        'Line43
        '
        Me.Line43.Height = 0.0!
        Me.Line43.Left = 0.0!
        Me.Line43.LineWeight = 1.0!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 1.437008!
        Me.Line43.Width = 8.035432!
        Me.Line43.X1 = 0.0!
        Me.Line43.X2 = 8.035432!
        Me.Line43.Y1 = 1.437008!
        Me.Line43.Y2 = 1.437008!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 2.204725!
        Me.Line3.Width = 8.035432!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 8.035432!
        Me.Line3.Y1 = 2.204725!
        Me.Line3.Y2 = 2.204725!
        '
        'Line4
        '
        Me.Line4.Height = 0.255905!
        Me.Line4.Left = 4.144882!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line4.LineWeight = 3.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.692914!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 4.144882!
        Me.Line4.X2 = 4.144882!
        Me.Line4.Y1 = 1.692914!
        Me.Line4.Y2 = 1.948819!
        '
        'Line5
        '
        Me.Line5.Height = 0.255905!
        Me.Line5.Left = 5.618505!
        Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line5.LineWeight = 3.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.692914!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 5.618505!
        Me.Line5.X2 = 5.618505!
        Me.Line5.Y1 = 1.692914!
        Me.Line5.Y2 = 1.948819!
        '
        'Line6
        '
        Me.Line6.Height = 0.255905!
        Me.Line6.Left = 1.729921!
        Me.Line6.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line6.LineWeight = 3.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.692914!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 1.729921!
        Me.Line6.X2 = 1.729921!
        Me.Line6.Y1 = 1.692914!
        Me.Line6.Y2 = 1.948819!
        '
        'Line14
        '
        Me.Line14.Height = 0.7677166!
        Me.Line14.Left = 4.144882!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.6692914!
        Me.Line14.Width = 0.0!
        Me.Line14.X1 = 4.144882!
        Me.Line14.X2 = 4.144882!
        Me.Line14.Y1 = 0.6692914!
        Me.Line14.Y2 = 1.437008!
        '
        'Line46
        '
        Me.Line46.Height = 0.0!
        Me.Line46.Left = 0.0!
        Me.Line46.LineWeight = 1.0!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 2.46063!
        Me.Line46.Width = 8.035432!
        Me.Line46.X1 = 0.0!
        Me.Line46.X2 = 8.035432!
        Me.Line46.Y1 = 2.46063!
        Me.Line46.Y2 = 2.46063!
        '
        'Line47
        '
        Me.Line47.Height = 0.0!
        Me.Line47.Left = 0.001574803!
        Me.Line47.LineWeight = 1.0!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 2.716536!
        Me.Line47.Width = 8.035434!
        Me.Line47.X1 = 0.001574803!
        Me.Line47.X2 = 8.037008!
        Me.Line47.Y1 = 2.716536!
        Me.Line47.Y2 = 2.716536!
        '
        'Line54
        '
        Me.Line54.Height = 0.7677159!
        Me.Line54.Left = 4.144882!
        Me.Line54.LineWeight = 1.0!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 2.204725!
        Me.Line54.Width = 0.0!
        Me.Line54.X1 = 4.144882!
        Me.Line54.X2 = 4.144882!
        Me.Line54.Y1 = 2.204725!
        Me.Line54.Y2 = 2.972441!
        '
        'Line55
        '
        Me.Line55.Height = 0.7677159!
        Me.Line55.Left = 5.618505!
        Me.Line55.LineWeight = 1.0!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 2.204725!
        Me.Line55.Width = 0.0!
        Me.Line55.X1 = 5.618505!
        Me.Line55.X2 = 5.618505!
        Me.Line55.Y1 = 2.204725!
        Me.Line55.Y2 = 2.972441!
        '
        'TEHAI_TANTO_EMAIL_PC
        '
        Me.TEHAI_TANTO_EMAIL_PC.CanGrow = False
        Me.TEHAI_TANTO_EMAIL_PC.DataField = "TEHAI_TANTO_EMAIL_PC"
        Me.TEHAI_TANTO_EMAIL_PC.Height = 0.2559055!
        Me.TEHAI_TANTO_EMAIL_PC.Left = 5.619292!
        Me.TEHAI_TANTO_EMAIL_PC.Name = "TEHAI_TANTO_EMAIL_PC"
        Me.TEHAI_TANTO_EMAIL_PC.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_EMAIL_PC.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_EMAIL_PC.Text = "TEHAI_TANTO_EMAIL_PC"
        Me.TEHAI_TANTO_EMAIL_PC.Top = 3.740159!
        Me.TEHAI_TANTO_EMAIL_PC.Width = 2.413386!
        '
        'TEHAI_TANTO_ROMA
        '
        Me.TEHAI_TANTO_ROMA.CanGrow = False
        Me.TEHAI_TANTO_ROMA.DataField = "TEHAI_TANTO_ROMA"
        Me.TEHAI_TANTO_ROMA.Height = 0.2559055!
        Me.TEHAI_TANTO_ROMA.Left = 5.619292!
        Me.TEHAI_TANTO_ROMA.Name = "TEHAI_TANTO_ROMA"
        Me.TEHAI_TANTO_ROMA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_ROMA.Text = "TEHAI_TANTO_ROMA"
        Me.TEHAI_TANTO_ROMA.Top = 3.228347!
        Me.TEHAI_TANTO_ROMA.Width = 2.413386!
        '
        'TEHAI_TANTO_TEL
        '
        Me.TEHAI_TANTO_TEL.CanGrow = False
        Me.TEHAI_TANTO_TEL.DataField = "TEHAI_TANTO_TEL"
        Me.TEHAI_TANTO_TEL.Height = 0.2559055!
        Me.TEHAI_TANTO_TEL.Left = 5.619292!
        Me.TEHAI_TANTO_TEL.Name = "TEHAI_TANTO_TEL"
        Me.TEHAI_TANTO_TEL.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_TEL.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_TEL.Text = "TEHAI_TANTO_TEL"
        Me.TEHAI_TANTO_TEL.Top = 3.484252!
        Me.TEHAI_TANTO_TEL.Width = 2.413386!
        '
        'TEHAI_TANTO_KEITAI
        '
        Me.TEHAI_TANTO_KEITAI.CanGrow = False
        Me.TEHAI_TANTO_KEITAI.DataField = "TEHAI_TANTO_KEITAI"
        Me.TEHAI_TANTO_KEITAI.Height = 0.2559055!
        Me.TEHAI_TANTO_KEITAI.Left = 1.731496!
        Me.TEHAI_TANTO_KEITAI.Name = "TEHAI_TANTO_KEITAI"
        Me.TEHAI_TANTO_KEITAI.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_KEITAI.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_KEITAI.Text = "TEHAI_TANTO_KEITAI"
        Me.TEHAI_TANTO_KEITAI.Top = 3.484252!
        Me.TEHAI_TANTO_KEITAI.Width = 2.413386!
        '
        'TEHAI_TANTO_NAME
        '
        Me.TEHAI_TANTO_NAME.CanGrow = False
        Me.TEHAI_TANTO_NAME.DataField = "TEHAI_TANTO_NAME"
        Me.TEHAI_TANTO_NAME.Height = 0.2559055!
        Me.TEHAI_TANTO_NAME.Left = 1.731496!
        Me.TEHAI_TANTO_NAME.Name = "TEHAI_TANTO_NAME"
        Me.TEHAI_TANTO_NAME.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_NAME.Text = "TEHAI_TANTO_NAME"
        Me.TEHAI_TANTO_NAME.Top = 3.228347!
        Me.TEHAI_TANTO_NAME.Width = 2.413386!
        '
        'TEHAI_TANTO_EMAIL_KEITAI
        '
        Me.TEHAI_TANTO_EMAIL_KEITAI.CanGrow = False
        Me.TEHAI_TANTO_EMAIL_KEITAI.DataField = "TEHAI_TANTO_EMAIL_KEITAI"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Height = 0.2559055!
        Me.TEHAI_TANTO_EMAIL_KEITAI.Left = 1.731496!
        Me.TEHAI_TANTO_EMAIL_KEITAI.Name = "TEHAI_TANTO_EMAIL_KEITAI"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_EMAIL_KEITAI.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Text = "TEHAI_TANTO_EMAIL_KEITAI"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Top = 3.740159!
        Me.TEHAI_TANTO_EMAIL_KEITAI.Width = 2.413386!
        '
        'Label5
        '
        Me.Label5.Height = 0.2559055!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.146457!
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label5.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label5.Text = "E Mailアドレス"
        Me.Label5.Top = 3.740159!
        Me.Label5.Width = 1.466929!
        '
        'Label51
        '
        Me.Label51.Height = 0.2559055!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 4.146457!
        Me.Label51.Name = "Label51"
        Me.Label51.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label51.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label51.Text = "オフィス電話番号"
        Me.Label51.Top = 3.484252!
        Me.Label51.Width = 1.466929!
        '
        'Label52
        '
        Me.Label52.Height = 0.2559055!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 4.146457!
        Me.Label52.Name = "Label52"
        Me.Label52.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label52.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label52.Text = "手配担当者(ローマ字)"
        Me.Label52.Top = 3.227559!
        Me.Label52.Width = 1.466929!
        '
        'TEHAI_TANTO_AREA
        '
        Me.TEHAI_TANTO_AREA.CanGrow = False
        Me.TEHAI_TANTO_AREA.DataField = "TEHAI_TANTO_AREA"
        Me.TEHAI_TANTO_AREA.Height = 0.2559055!
        Me.TEHAI_TANTO_AREA.Left = 3.640158!
        Me.TEHAI_TANTO_AREA.Name = "TEHAI_TANTO_AREA"
        Me.TEHAI_TANTO_AREA.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_AREA.Text = "TEHAI_TANTO_AREA"
        Me.TEHAI_TANTO_AREA.Top = 2.972441!
        Me.TEHAI_TANTO_AREA.Width = 1.850394!
        '
        'TEHAI_TANTO_BU
        '
        Me.TEHAI_TANTO_BU.CanGrow = False
        Me.TEHAI_TANTO_BU.DataField = "TEHAI_TANTO_BU"
        Me.TEHAI_TANTO_BU.Height = 0.2559055!
        Me.TEHAI_TANTO_BU.Left = 2.066142!
        Me.TEHAI_TANTO_BU.Name = "TEHAI_TANTO_BU"
        Me.TEHAI_TANTO_BU.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.TEHAI_TANTO_BU.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TEHAI_TANTO_BU.Text = "TEHAI_TANTO_BU"
        Me.TEHAI_TANTO_BU.Top = 2.972441!
        Me.TEHAI_TANTO_BU.Width = 0.984252!
        '
        'Label53
        '
        Me.Label53.Height = 0.2559055!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 5.491339!
        Me.Label53.Name = "Label53"
        Me.Label53.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label53.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label53.Text = "営業所"
        Me.Label53.Top = 2.972441!
        Me.Label53.Width = 0.5708662!
        '
        'Label54
        '
        Me.Label54.Height = 0.2559055!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 3.049607!
        Me.Label54.Name = "Label54"
        Me.Label54.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label54.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label54.Text = "エリア"
        Me.Label54.Top = 2.972441!
        Me.Label54.Width = 0.5905512!
        '
        'Label55
        '
        Me.Label55.Height = 0.2559055!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 1.731496!
        Me.Label55.Name = "Label55"
        Me.Label55.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label55.Style = "background-color: #828282; color: White; font-family: ＭＳ ゴシック; font-size: 10pt; v" & _
            "ertical-align: middle"
        Me.Label55.Text = "BU"
        Me.Label55.Top = 2.972441!
        Me.Label55.Width = 0.3334646!
        '
        'Line9
        '
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.004330709!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 3.228347!
        Me.Line9.Width = 8.031102!
        Me.Line9.X1 = 0.004330709!
        Me.Line9.X2 = 8.035433!
        Me.Line9.Y1 = 3.228347!
        Me.Line9.Y2 = 3.228347!
        '
        'Line56
        '
        Me.Line56.Height = 0.0!
        Me.Line56.Left = 0.0!
        Me.Line56.LineWeight = 1.0!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 3.484252!
        Me.Line56.Width = 8.035432!
        Me.Line56.X1 = 0.0!
        Me.Line56.X2 = 8.035432!
        Me.Line56.Y1 = 3.484252!
        Me.Line56.Y2 = 3.484252!
        '
        'Line57
        '
        Me.Line57.Height = 0.0!
        Me.Line57.Left = 0.0!
        Me.Line57.LineWeight = 1.0!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 3.740158!
        Me.Line57.Width = 8.035432!
        Me.Line57.X1 = 0.0!
        Me.Line57.X2 = 8.035432!
        Me.Line57.Y1 = 3.740158!
        Me.Line57.Y2 = 3.740158!
        '
        'Line59
        '
        Me.Line59.Height = 0.2559052!
        Me.Line59.Left = 2.066142!
        Me.Line59.LineWeight = 1.0!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 2.972441!
        Me.Line59.Width = 0.0!
        Me.Line59.X1 = 2.066142!
        Me.Line59.X2 = 2.066142!
        Me.Line59.Y1 = 2.972441!
        Me.Line59.Y2 = 3.228346!
        '
        'Line60
        '
        Me.Line60.Height = 0.2559052!
        Me.Line60.Left = 3.049607!
        Me.Line60.LineWeight = 1.0!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 2.972441!
        Me.Line60.Width = 0.00006604195!
        Me.Line60.X1 = 3.049607!
        Me.Line60.X2 = 3.049673!
        Me.Line60.Y1 = 2.972441!
        Me.Line60.Y2 = 3.228346!
        '
        'Line61
        '
        Me.Line61.Height = 0.2559052!
        Me.Line61.Left = 3.640158!
        Me.Line61.LineWeight = 1.0!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 2.972441!
        Me.Line61.Width = 0.00006604195!
        Me.Line61.X1 = 3.640158!
        Me.Line61.X2 = 3.640224!
        Me.Line61.Y1 = 2.972441!
        Me.Line61.Y2 = 3.228346!
        '
        'Line62
        '
        Me.Line62.Height = 0.2559052!
        Me.Line62.Left = 5.490551!
        Me.Line62.LineWeight = 1.0!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 2.972441!
        Me.Line62.Width = 0.00006484985!
        Me.Line62.X1 = 5.490551!
        Me.Line62.X2 = 5.490616!
        Me.Line62.Y1 = 2.972441!
        Me.Line62.Y2 = 3.228346!
        '
        'Line63
        '
        Me.Line63.Height = 0.2559052!
        Me.Line63.Left = 6.064174!
        Me.Line63.LineWeight = 1.0!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 2.972441!
        Me.Line63.Width = 0.0!
        Me.Line63.X1 = 6.064174!
        Me.Line63.X2 = 6.064174!
        Me.Line63.Y1 = 2.972441!
        Me.Line63.Y2 = 3.228346!
        '
        'Label15
        '
        Me.Label15.Height = 0.2559055!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.0!
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label15.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label15.Text = "参加予定数(従業員以外)"
        Me.Label15.Top = 3.996063!
        Me.Label15.Width = 1.728346!
        '
        'Label19
        '
        Me.Label19.Height = 0.2559055!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.0!
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label19.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label19.Text = "SRM発注区分"
        Me.Label19.Top = 4.26063!
        Me.Label19.Width = 1.728346!
        '
        'SANKA_YOTEI_CNT_NMBR
        '
        Me.SANKA_YOTEI_CNT_NMBR.CanGrow = False
        Me.SANKA_YOTEI_CNT_NMBR.DataField = "SANKA_YOTEI_CNT_NMBR"
        Me.SANKA_YOTEI_CNT_NMBR.Height = 0.2559055!
        Me.SANKA_YOTEI_CNT_NMBR.Left = 1.731496!
        Me.SANKA_YOTEI_CNT_NMBR.Name = "SANKA_YOTEI_CNT_NMBR"
        Me.SANKA_YOTEI_CNT_NMBR.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SANKA_YOTEI_CNT_NMBR.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SANKA_YOTEI_CNT_NMBR.Text = "SANKA_YOTEI_CNT_NMBR"
        Me.SANKA_YOTEI_CNT_NMBR.Top = 3.996063!
        Me.SANKA_YOTEI_CNT_NMBR.Width = 2.413386!
        '
        'SRM_HACYU_KBN
        '
        Me.SRM_HACYU_KBN.CanGrow = False
        Me.SRM_HACYU_KBN.DataField = "SRM_HACYU_KBN"
        Me.SRM_HACYU_KBN.Height = 0.2559055!
        Me.SRM_HACYU_KBN.Left = 1.731496!
        Me.SRM_HACYU_KBN.Name = "SRM_HACYU_KBN"
        Me.SRM_HACYU_KBN.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SRM_HACYU_KBN.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SRM_HACYU_KBN.Text = "SRM_HACYU_KBN"
        Me.SRM_HACYU_KBN.Top = 4.26063!
        Me.SRM_HACYU_KBN.Width = 6.299212!
        '
        'Label23
        '
        Me.Label23.Height = 0.2598425!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 4.152362!
        Me.Label23.Name = "Label23"
        Me.Label23.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label23.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label23.Text = "参加予定数(従業員)"
        Me.Label23.Top = 3.996063!
        Me.Label23.Width = 1.466929!
        '
        'Label24
        '
        Me.Label24.Height = 0.2559055!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 1.731496!
        Me.Label24.Name = "Label24"
        Me.Label24.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label24.Style = "background-color: #A8A8A8; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label24.Text = "総予算合計"
        Me.Label24.Top = 4.521654!
        Me.Label24.Width = 0.7874016!
        '
        'Label25
        '
        Me.Label25.Height = 0.2559055!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 3.688189!
        Me.Label25.Name = "Label25"
        Me.Label25.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label25.Style = "background-color: #A8A8A8; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label25.Text = "予算額(非課税)"
        Me.Label25.Top = 4.521654!
        Me.Label25.Width = 1.061811!
        '
        'Label26
        '
        Me.Label26.Height = 0.2559055!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 5.925197!
        Me.Label26.Name = "Label26"
        Me.Label26.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label26.Style = "background-color: #A8A8A8; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label26.Text = "予算額(課税)"
        Me.Label26.Top = 4.521654!
        Me.Label26.Width = 0.9311023!
        '
        'YOSAN_TF
        '
        Me.YOSAN_TF.CanGrow = False
        Me.YOSAN_TF.DataField = "YOSAN_TF"
        Me.YOSAN_TF.Height = 0.2559055!
        Me.YOSAN_TF.Left = 4.75!
        Me.YOSAN_TF.Name = "YOSAN_TF"
        Me.YOSAN_TF.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.YOSAN_TF.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.YOSAN_TF.Text = "YOSAN_TF"
        Me.YOSAN_TF.Top = 4.521654!
        Me.YOSAN_TF.Width = 1.169291!
        '
        'YOSAN_T
        '
        Me.YOSAN_T.CanGrow = False
        Me.YOSAN_T.DataField = "YOSAN_T"
        Me.YOSAN_T.Height = 0.2559055!
        Me.YOSAN_T.Left = 6.8563!
        Me.YOSAN_T.Name = "YOSAN_T"
        Me.YOSAN_T.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.YOSAN_T.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.YOSAN_T.Text = "YOSAN_T"
        Me.YOSAN_T.Top = 4.521654!
        Me.YOSAN_T.Width = 1.169291!
        '
        'YOSAN_TOTAL
        '
        Me.YOSAN_TOTAL.CanGrow = False
        Me.YOSAN_TOTAL.DataField = "YOSAN_TOTAL"
        Me.YOSAN_TOTAL.Height = 0.2559055!
        Me.YOSAN_TOTAL.Left = 2.518898!
        Me.YOSAN_TOTAL.Name = "YOSAN_TOTAL"
        Me.YOSAN_TOTAL.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.YOSAN_TOTAL.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.YOSAN_TOTAL.Text = "YOSAN_TOTAL"
        Me.YOSAN_TOTAL.Top = 4.521654!
        Me.YOSAN_TOTAL.Width = 1.169291!
        '
        'Label27
        '
        Me.Label27.Height = 0.2559055!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 1.731496!
        Me.Label27.Name = "Label27"
        Me.Label27.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label27.Style = "background-color: #B9B9B9; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label27.Text = "意見交換会予算(課税)"
        Me.Label27.Top = 4.777559!
        Me.Label27.Width = 1.556299!
        '
        'Label28
        '
        Me.Label28.Height = 0.2559055!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 5.020079!
        Me.Label28.Name = "Label28"
        Me.Label28.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label28.Style = "background-color: #B9B9B9; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label28.Text = "慰労会予算(課税)"
        Me.Label28.Top = 4.777559!
        Me.Label28.Width = 1.259843!
        '
        'IKENKOUKAN_YOSAN_T
        '
        Me.IKENKOUKAN_YOSAN_T.CanGrow = False
        Me.IKENKOUKAN_YOSAN_T.DataField = "IKENKOUKAN_YOSAN_T"
        Me.IKENKOUKAN_YOSAN_T.Height = 0.2559055!
        Me.IKENKOUKAN_YOSAN_T.Left = 3.287796!
        Me.IKENKOUKAN_YOSAN_T.Name = "IKENKOUKAN_YOSAN_T"
        Me.IKENKOUKAN_YOSAN_T.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IKENKOUKAN_YOSAN_T.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.IKENKOUKAN_YOSAN_T.Text = "IKENKOUKAN_YOSAN_T"
        Me.IKENKOUKAN_YOSAN_T.Top = 4.777559!
        Me.IKENKOUKAN_YOSAN_T.Width = 1.732283!
        '
        'IROUKAI_YOSAN_T
        '
        Me.IROUKAI_YOSAN_T.CanGrow = False
        Me.IROUKAI_YOSAN_T.DataField = "IROUKAI_YOSAN_T"
        Me.IROUKAI_YOSAN_T.Height = 0.2559055!
        Me.IROUKAI_YOSAN_T.Left = 6.279922!
        Me.IROUKAI_YOSAN_T.Name = "IROUKAI_YOSAN_T"
        Me.IROUKAI_YOSAN_T.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IROUKAI_YOSAN_T.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.IROUKAI_YOSAN_T.Text = "IROUKAI_YOSAN_T"
        Me.IROUKAI_YOSAN_T.Top = 4.777559!
        Me.IROUKAI_YOSAN_T.Width = 1.755906!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 4.261811!
        Me.Line10.Width = 8.035432!
        Me.Line10.X1 = 0.0!
        Me.Line10.X2 = 8.035432!
        Me.Line10.Y1 = 4.261811!
        Me.Line10.Y2 = 4.261811!
        '
        'Line18
        '
        Me.Line18.Height = 0.2559047!
        Me.Line18.Left = 2.518898!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 4.521654!
        Me.Line18.Width = 0.00006508827!
        Me.Line18.X1 = 2.518898!
        Me.Line18.X2 = 2.518963!
        Me.Line18.Y1 = 4.521654!
        Me.Line18.Y2 = 4.777559!
        '
        'Line19
        '
        Me.Line19.Height = 0.2559052!
        Me.Line19.Left = 3.287796!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 4.777559!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 3.287796!
        Me.Line19.X2 = 3.287796!
        Me.Line19.Y1 = 4.777559!
        Me.Line19.Y2 = 5.033464!
        '
        'Line20
        '
        Me.Line20.Height = 0.2559047!
        Me.Line20.Left = 3.688189!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 4.521654!
        Me.Line20.Width = 0.00006508827!
        Me.Line20.X1 = 3.688189!
        Me.Line20.X2 = 3.688254!
        Me.Line20.Y1 = 4.521654!
        Me.Line20.Y2 = 4.777559!
        '
        'Line21
        '
        Me.Line21.Height = 0.2559047!
        Me.Line21.Left = 4.75!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 4.521654!
        Me.Line21.Width = 0.00007009506!
        Me.Line21.X1 = 4.75!
        Me.Line21.X2 = 4.75007!
        Me.Line21.Y1 = 4.521654!
        Me.Line21.Y2 = 4.777559!
        '
        'Line22
        '
        Me.Line22.Height = 0.2559047!
        Me.Line22.Left = 5.925197!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 4.521654!
        Me.Line22.Width = 0.00006389618!
        Me.Line22.X1 = 5.925197!
        Me.Line22.X2 = 5.925261!
        Me.Line22.Y1 = 4.521654!
        Me.Line22.Y2 = 4.777559!
        '
        'Line23
        '
        Me.Line23.Height = 0.2559047!
        Me.Line23.Left = 6.8563!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 4.521654!
        Me.Line23.Width = 0.00006818771!
        Me.Line23.X1 = 6.8563!
        Me.Line23.X2 = 6.856368!
        Me.Line23.Y1 = 4.521654!
        Me.Line23.Y2 = 4.777559!
        '
        'Line24
        '
        Me.Line24.Height = 0.2559052!
        Me.Line24.Left = 6.279922!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 4.777559!
        Me.Line24.Width = 0.00006484985!
        Me.Line24.X1 = 6.279922!
        Me.Line24.X2 = 6.279987!
        Me.Line24.Y1 = 4.777559!
        Me.Line24.Y2 = 5.033464!
        '
        'Line25
        '
        Me.Line25.Height = 0.2559052!
        Me.Line25.Left = 5.022835!
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 4.777559!
        Me.Line25.Width = 0.0!
        Me.Line25.X1 = 5.022835!
        Me.Line25.X2 = 5.022835!
        Me.Line25.Y1 = 4.777559!
        Me.Line25.Y2 = 5.033464!
        '
        'Line65
        '
        Me.Line65.Height = 1.033464!
        Me.Line65.Left = 5.618505!
        Me.Line65.LineWeight = 1.0!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 3.228347!
        Me.Line65.Width = 0.0!
        Me.Line65.X1 = 5.618505!
        Me.Line65.X2 = 5.618505!
        Me.Line65.Y1 = 3.228347!
        Me.Line65.Y2 = 4.261811!
        '
        'Line64
        '
        Me.Line64.Height = 1.033464!
        Me.Line64.Left = 4.146457!
        Me.Line64.LineWeight = 1.0!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 3.228347!
        Me.Line64.Width = 0.0!
        Me.Line64.X1 = 4.146457!
        Me.Line64.X2 = 4.146457!
        Me.Line64.Y1 = 3.228347!
        Me.Line64.Y2 = 4.261811!
        '
        'Label29
        '
        Me.Label29.Height = 2.007874!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.0!
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label29.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label29.Text = "開催希望地"
        Me.Label29.Top = 5.033465!
        Me.Label29.Width = 1.728346!
        '
        'Line16
        '
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 1.729921!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 4.777559!
        Me.Line16.Width = 6.294882!
        Me.Line16.X1 = 1.729921!
        Me.Line16.X2 = 8.024803!
        Me.Line16.Y1 = 4.777559!
        Me.Line16.Y2 = 4.777559!
        '
        'KAISAI_KIBOU_ADDRESS1
        '
        Me.KAISAI_KIBOU_ADDRESS1.CanGrow = False
        Me.KAISAI_KIBOU_ADDRESS1.DataField = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Height = 0.2559055!
        Me.KAISAI_KIBOU_ADDRESS1.Left = 2.509449!
        Me.KAISAI_KIBOU_ADDRESS1.Name = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KAISAI_KIBOU_ADDRESS1.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KAISAI_KIBOU_ADDRESS1.Text = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Top = 5.033465!
        Me.KAISAI_KIBOU_ADDRESS1.Width = 0.8996063!
        '
        'Line38
        '
        Me.Line38.Height = 0.2559061!
        Me.Line38.Left = 3.409055!
        Me.Line38.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line38.LineWeight = 1.0!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 5.033465!
        Me.Line38.Width = 0.00006389618!
        Me.Line38.X1 = 3.409055!
        Me.Line38.X2 = 3.409119!
        Me.Line38.Y1 = 5.033465!
        Me.Line38.Y2 = 5.289371!
        '
        'Line11
        '
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 0.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 4.521654!
        Me.Line11.Width = 8.035432!
        Me.Line11.X1 = 0.0!
        Me.Line11.X2 = 8.035432!
        Me.Line11.Y1 = 4.521654!
        Me.Line11.Y2 = 4.521654!
        '
        'Line70
        '
        Me.Line70.Height = 0.2559047!
        Me.Line70.Left = 3.748032!
        Me.Line70.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line70.LineWeight = 1.0!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 6.037402!
        Me.Line70.Width = 0.0!
        Me.Line70.X1 = 3.748032!
        Me.Line70.X2 = 3.748032!
        Me.Line70.Y1 = 6.037402!
        Me.Line70.Y2 = 6.293307!
        '
        'KOUEN_TIME2
        '
        Me.KOUEN_TIME2.CanGrow = False
        Me.KOUEN_TIME2.DataField = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Height = 0.2559055!
        Me.KOUEN_TIME2.Left = 4.766142!
        Me.KOUEN_TIME2.Name = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUEN_TIME2.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KOUEN_TIME2.Text = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Top = 6.037402!
        Me.KOUEN_TIME2.Width = 1.0!
        '
        'Line71
        '
        Me.Line71.Height = 0.2559047!
        Me.Line71.Left = 4.766142!
        Me.Line71.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line71.LineWeight = 1.0!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 6.037402!
        Me.Line71.Width = 0.0!
        Me.Line71.X1 = 4.766142!
        Me.Line71.X2 = 4.766142!
        Me.Line71.Y1 = 6.037402!
        Me.Line71.Y2 = 6.293307!
        '
        'Line72
        '
        Me.Line72.Height = 0.0!
        Me.Line72.Left = 1.729921!
        Me.Line72.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line72.LineWeight = 1.0!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 6.037402!
        Me.Line72.Width = 6.305511!
        Me.Line72.X1 = 1.729921!
        Me.Line72.X2 = 8.035432!
        Me.Line72.Y1 = 6.037402!
        Me.Line72.Y2 = 6.037402!
        '
        'Label63
        '
        Me.Label63.Height = 1.535433!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 0.0!
        Me.Label63.Name = "Label63"
        Me.Label63.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label63.Style = "background-color: #C3C3C3; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label63.Text = "必要会場"
        Me.Label63.Top = 7.041339!
        Me.Label63.Width = 1.728346!
        '
        'Label64
        '
        Me.Label64.Height = 0.2559055!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 1.729921!
        Me.Label64.Name = "Label64"
        Me.Label64.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label64.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label64.Text = "慰労会会場"
        Me.Label64.Top = 7.55315!
        Me.Label64.Width = 1.01811!
        '
        'Label66
        '
        Me.Label66.Height = 0.2559055!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 1.729921!
        Me.Label66.Name = "Label66"
        Me.Label66.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label66.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label66.Text = "講師控室"
        Me.Label66.Top = 7.809056!
        Me.Label66.Width = 1.01811!
        '
        'Label68
        '
        Me.Label68.Height = 0.2559055!
        Me.Label68.HyperLink = Nothing
        Me.Label68.Left = 5.99449!
        Me.Label68.Name = "Label68"
        Me.Label68.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label68.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label68.Text = "人数"
        Me.Label68.Top = 7.809056!
        Me.Label68.Width = 1.224409!
        '
        'Label71
        '
        Me.Label71.Height = 0.2559055!
        Me.Label71.HyperLink = Nothing
        Me.Label71.Left = 1.729922!
        Me.Label71.Name = "Label71"
        Me.Label71.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label71.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label71.Text = "世話人会会場"
        Me.Label71.Top = 8.320871!
        Me.Label71.Width = 1.01811!
        '
        'Label73
        '
        Me.Label73.Height = 0.2559055!
        Me.Label73.HyperLink = Nothing
        Me.Label73.Left = 5.994488!
        Me.Label73.Name = "Label73"
        Me.Label73.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label73.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label73.Text = "世話人控室(人数)"
        Me.Label73.Top = 8.320871!
        Me.Label73.Width = 1.224409!
        '
        'IKENKOUKAN_KAIJO_TEHAI_Yes
        '
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.CanGrow = False
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.DataField = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Height = 0.2559055!
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Left = 2.748032!
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Name = "IKENKOUKAN_KAIJO_TEHAI_Yes"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Text = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Top = 7.297245!
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Width = 0.446063!
        '
        'IROUKAI_KAIJO_TEHAI_Yes
        '
        Me.IROUKAI_KAIJO_TEHAI_Yes.CanGrow = False
        Me.IROUKAI_KAIJO_TEHAI_Yes.DataField = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI_Yes.Height = 0.2559055!
        Me.IROUKAI_KAIJO_TEHAI_Yes.Left = 2.748032!
        Me.IROUKAI_KAIJO_TEHAI_Yes.Name = "IROUKAI_KAIJO_TEHAI_Yes"
        Me.IROUKAI_KAIJO_TEHAI_Yes.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IROUKAI_KAIJO_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.IROUKAI_KAIJO_TEHAI_Yes.Text = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI_Yes.Top = 7.55315!
        Me.IROUKAI_KAIJO_TEHAI_Yes.Width = 0.446063!
        '
        'IROUKAI_SANKA_YOTEI_CNT
        '
        Me.IROUKAI_SANKA_YOTEI_CNT.CanGrow = False
        Me.IROUKAI_SANKA_YOTEI_CNT.DataField = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Height = 0.2559055!
        Me.IROUKAI_SANKA_YOTEI_CNT.Left = 5.214961!
        Me.IROUKAI_SANKA_YOTEI_CNT.Name = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IROUKAI_SANKA_YOTEI_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Top = 7.55315!
        Me.IROUKAI_SANKA_YOTEI_CNT.Width = 0.7795276!
        '
        'KOUSHI_ROOM_TEHAI_Yes
        '
        Me.KOUSHI_ROOM_TEHAI_Yes.CanGrow = False
        Me.KOUSHI_ROOM_TEHAI_Yes.DataField = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI_Yes.Height = 0.2559055!
        Me.KOUSHI_ROOM_TEHAI_Yes.Left = 2.748033!
        Me.KOUSHI_ROOM_TEHAI_Yes.Name = "KOUSHI_ROOM_TEHAI_Yes"
        Me.KOUSHI_ROOM_TEHAI_Yes.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUSHI_ROOM_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.KOUSHI_ROOM_TEHAI_Yes.Text = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI_Yes.Top = 7.809056!
        Me.KOUSHI_ROOM_TEHAI_Yes.Width = 0.446063!
        '
        'KOUSHI_ROOM_FROM
        '
        Me.KOUSHI_ROOM_FROM.CanGrow = False
        Me.KOUSHI_ROOM_FROM.DataField = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Height = 0.2559055!
        Me.KOUSHI_ROOM_FROM.Left = 5.214962!
        Me.KOUSHI_ROOM_FROM.Name = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUSHI_ROOM_FROM.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.KOUSHI_ROOM_FROM.Text = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Top = 7.809056!
        Me.KOUSHI_ROOM_FROM.Width = 0.7795276!
        '
        'SHAIN_ROOM_CNT
        '
        Me.SHAIN_ROOM_CNT.CanGrow = False
        Me.SHAIN_ROOM_CNT.DataField = "SHAIN_ROOM_CNT"
        Me.SHAIN_ROOM_CNT.Height = 0.2559055!
        Me.SHAIN_ROOM_CNT.Left = 5.214962!
        Me.SHAIN_ROOM_CNT.Name = "SHAIN_ROOM_CNT"
        Me.SHAIN_ROOM_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.SHAIN_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.SHAIN_ROOM_CNT.Text = "SHAIN_ROOM_CNT"
        Me.SHAIN_ROOM_CNT.Top = 8.064966!
        Me.SHAIN_ROOM_CNT.Width = 0.7795276!
        '
        'MANAGER_KAIJO_TEHAI_Yes
        '
        Me.MANAGER_KAIJO_TEHAI_Yes.CanGrow = False
        Me.MANAGER_KAIJO_TEHAI_Yes.DataField = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI_Yes.Height = 0.2559055!
        Me.MANAGER_KAIJO_TEHAI_Yes.Left = 2.748033!
        Me.MANAGER_KAIJO_TEHAI_Yes.Name = "MANAGER_KAIJO_TEHAI_Yes"
        Me.MANAGER_KAIJO_TEHAI_Yes.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.MANAGER_KAIJO_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.MANAGER_KAIJO_TEHAI_Yes.Text = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI_Yes.Top = 8.320871!
        Me.MANAGER_KAIJO_TEHAI_Yes.Width = 0.446063!
        '
        'MANAGER_ROOM_FROM
        '
        Me.MANAGER_ROOM_FROM.CanGrow = False
        Me.MANAGER_ROOM_FROM.DataField = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Height = 0.2559055!
        Me.MANAGER_ROOM_FROM.Left = 5.214962!
        Me.MANAGER_ROOM_FROM.Name = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.MANAGER_ROOM_FROM.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.MANAGER_ROOM_FROM.Text = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Top = 8.320871!
        Me.MANAGER_ROOM_FROM.Width = 0.7795276!
        '
        'REQ_STAY_DATE
        '
        Me.REQ_STAY_DATE.CanGrow = False
        Me.REQ_STAY_DATE.DataField = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Height = 0.2559055!
        Me.REQ_STAY_DATE.Left = 1.729921!
        Me.REQ_STAY_DATE.Name = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.REQ_STAY_DATE.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.REQ_STAY_DATE.Text = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Top = 8.577953!
        Me.REQ_STAY_DATE.Width = 6.299212!
        '
        'REQ_ROOM_CNT
        '
        Me.REQ_ROOM_CNT.CanGrow = False
        Me.REQ_ROOM_CNT.DataField = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Height = 0.2559055!
        Me.REQ_ROOM_CNT.Left = 1.729921!
        Me.REQ_ROOM_CNT.Name = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.REQ_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.REQ_ROOM_CNT.Text = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Top = 8.833858!
        Me.REQ_ROOM_CNT.Width = 6.299212!
        '
        'REQ_KOTSU_CNT
        '
        Me.REQ_KOTSU_CNT.CanGrow = False
        Me.REQ_KOTSU_CNT.DataField = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Height = 0.2559055!
        Me.REQ_KOTSU_CNT.Left = 1.729921!
        Me.REQ_KOTSU_CNT.Name = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.REQ_KOTSU_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.REQ_KOTSU_CNT.Text = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Top = 9.089765!
        Me.REQ_KOTSU_CNT.Width = 6.299212!
        '
        'REQ_TAXI_CNT
        '
        Me.REQ_TAXI_CNT.CanGrow = False
        Me.REQ_TAXI_CNT.DataField = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Height = 0.2559055!
        Me.REQ_TAXI_CNT.Left = 1.729921!
        Me.REQ_TAXI_CNT.Name = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.REQ_TAXI_CNT.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.REQ_TAXI_CNT.Text = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Top = 9.34567!
        Me.REQ_TAXI_CNT.Width = 6.299212!
        '
        'Line82
        '
        Me.Line82.Height = 0.0!
        Me.Line82.Left = 0.0!
        Me.Line82.LineWeight = 1.0!
        Me.Line82.Name = "Line82"
        Me.Line82.Top = 8.833858!
        Me.Line82.Width = 8.035433!
        Me.Line82.X1 = 0.0!
        Me.Line82.X2 = 8.035433!
        Me.Line82.Y1 = 8.833858!
        Me.Line82.Y2 = 8.833858!
        '
        'Line83
        '
        Me.Line83.Height = 0.0!
        Me.Line83.Left = 0.0!
        Me.Line83.LineWeight = 1.0!
        Me.Line83.Name = "Line83"
        Me.Line83.Top = 9.089765!
        Me.Line83.Width = 8.035433!
        Me.Line83.X1 = 0.0!
        Me.Line83.X2 = 8.035433!
        Me.Line83.Y1 = 9.089765!
        Me.Line83.Y2 = 9.089765!
        '
        'Line84
        '
        Me.Line84.Height = 0.0!
        Me.Line84.Left = 0.0!
        Me.Line84.LineWeight = 1.0!
        Me.Line84.Name = "Line84"
        Me.Line84.Top = 9.34567!
        Me.Line84.Width = 8.035433!
        Me.Line84.X1 = 0.0!
        Me.Line84.X2 = 8.035433!
        Me.Line84.Y1 = 9.34567!
        Me.Line84.Y2 = 9.34567!
        '
        'Line85
        '
        Me.Line85.Height = 0.0!
        Me.Line85.Left = 0.0!
        Me.Line85.LineWeight = 1.0!
        Me.Line85.Name = "Line85"
        Me.Line85.Top = 9.606299!
        Me.Line85.Width = 8.035434!
        Me.Line85.X1 = 0.0!
        Me.Line85.X2 = 8.035434!
        Me.Line85.Y1 = 9.606299!
        Me.Line85.Y2 = 9.606299!
        '
        'Label75
        '
        Me.Label75.Height = 0.2559055!
        Me.Label75.HyperLink = Nothing
        Me.Label75.Left = 1.72992!
        Me.Label75.Name = "Label75"
        Me.Label75.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 1, 0, 0)
        Me.Label75.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label75.Text = "意見交換会場"
        Me.Label75.Top = 7.297245!
        Me.Label75.Width = 1.01811!
        '
        'MANAGER_KAIJO_TEHAI_No
        '
        Me.MANAGER_KAIJO_TEHAI_No.CanGrow = False
        Me.MANAGER_KAIJO_TEHAI_No.DataField = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI_No.Height = 0.2559055!
        Me.MANAGER_KAIJO_TEHAI_No.Left = 3.194096!
        Me.MANAGER_KAIJO_TEHAI_No.Name = "MANAGER_KAIJO_TEHAI_No"
        Me.MANAGER_KAIJO_TEHAI_No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.MANAGER_KAIJO_TEHAI_No.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.MANAGER_KAIJO_TEHAI_No.Text = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI_No.Top = 8.320871!
        Me.MANAGER_KAIJO_TEHAI_No.Width = 0.446063!
        '
        'KOUSHI_ROOM_TEHAI_No
        '
        Me.KOUSHI_ROOM_TEHAI_No.CanGrow = False
        Me.KOUSHI_ROOM_TEHAI_No.DataField = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI_No.Height = 0.2559055!
        Me.KOUSHI_ROOM_TEHAI_No.Left = 3.194095!
        Me.KOUSHI_ROOM_TEHAI_No.Name = "KOUSHI_ROOM_TEHAI_No"
        Me.KOUSHI_ROOM_TEHAI_No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.KOUSHI_ROOM_TEHAI_No.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.KOUSHI_ROOM_TEHAI_No.Text = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI_No.Top = 7.809056!
        Me.KOUSHI_ROOM_TEHAI_No.Width = 0.446063!
        '
        'IROUKAI_KAIJO_TEHAI_No
        '
        Me.IROUKAI_KAIJO_TEHAI_No.CanGrow = False
        Me.IROUKAI_KAIJO_TEHAI_No.DataField = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI_No.Height = 0.2559055!
        Me.IROUKAI_KAIJO_TEHAI_No.Left = 3.194095!
        Me.IROUKAI_KAIJO_TEHAI_No.Name = "IROUKAI_KAIJO_TEHAI_No"
        Me.IROUKAI_KAIJO_TEHAI_No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IROUKAI_KAIJO_TEHAI_No.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.IROUKAI_KAIJO_TEHAI_No.Text = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI_No.Top = 7.55315!
        Me.IROUKAI_KAIJO_TEHAI_No.Width = 0.446063!
        '
        'IKENKOUKAN_KAIJO_TEHAI_No
        '
        Me.IKENKOUKAN_KAIJO_TEHAI_No.CanGrow = False
        Me.IKENKOUKAN_KAIJO_TEHAI_No.DataField = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Height = 0.2559055!
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Left = 3.194094!
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Name = "IKENKOUKAN_KAIJO_TEHAI_No"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Style = "font-family: ＭＳ ゴシック; text-align: center; vertical-align: middle; white-space: no" & _
            "wrap"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Text = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Top = 7.297245!
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Width = 0.446063!
        '
        'Label78
        '
        Me.Label78.Height = 0.2559055!
        Me.Label78.HyperLink = Nothing
        Me.Label78.Left = 1.731497!
        Me.Label78.Name = "Label78"
        Me.Label78.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 1, 0, 0)
        Me.Label78.Style = "background-color: #EAEAEA; font-family: ＭＳ ゴシック; font-size: 10pt; vertical-align:" & _
            " middle"
        Me.Label78.Text = "都道府県"
        Me.Label78.Top = 5.033465!
        Me.Label78.Width = 0.7795276!
        '
        'Line67
        '
        Me.Line67.Height = 0.2559061!
        Me.Line67.Left = 2.509449!
        Me.Line67.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line67.LineWeight = 1.0!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 5.033465!
        Me.Line67.Width = 0.00006484985!
        Me.Line67.X1 = 2.509449!
        Me.Line67.X2 = 2.509514!
        Me.Line67.Y1 = 5.033465!
        Me.Line67.Y2 = 5.289371!
        '
        'Line76
        '
        Me.Line76.Height = 0.0!
        Me.Line76.Left = 1.729921!
        Me.Line76.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line76.LineWeight = 1.0!
        Me.Line76.Name = "Line76"
        Me.Line76.Top = 6.293307!
        Me.Line76.Width = 6.305511!
        Me.Line76.X1 = 1.729921!
        Me.Line76.X2 = 8.035432!
        Me.Line76.Y1 = 6.293307!
        Me.Line76.Y2 = 6.293307!
        '
        'Line77
        '
        Me.Line77.Height = 0.2559047!
        Me.Line77.Left = 2.748032!
        Me.Line77.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line77.LineWeight = 1.0!
        Me.Line77.Name = "Line77"
        Me.Line77.Top = 6.037402!
        Me.Line77.Width = 0.00006580353!
        Me.Line77.X1 = 2.748032!
        Me.Line77.X2 = 2.748098!
        Me.Line77.Y1 = 6.037402!
        Me.Line77.Y2 = 6.293307!
        '
        'Line78
        '
        Me.Line78.Height = 0.2559047!
        Me.Line78.Left = 5.766142!
        Me.Line78.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line78.LineWeight = 1.0!
        Me.Line78.Name = "Line78"
        Me.Line78.Top = 6.037402!
        Me.Line78.Width = 0.0!
        Me.Line78.X1 = 5.766142!
        Me.Line78.X2 = 5.766142!
        Me.Line78.Y1 = 6.037402!
        Me.Line78.Y2 = 6.293307!
        '
        'Line79
        '
        Me.Line79.Height = 0.2559047!
        Me.Line79.Left = 6.614567!
        Me.Line79.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line79.LineWeight = 1.0!
        Me.Line79.Name = "Line79"
        Me.Line79.Top = 6.037402!
        Me.Line79.Width = 0.0!
        Me.Line79.X1 = 6.614567!
        Me.Line79.X2 = 6.614567!
        Me.Line79.Y1 = 6.037402!
        Me.Line79.Y2 = 6.293307!
        '
        'Line75
        '
        Me.Line75.Height = 0.0!
        Me.Line75.Left = 1.729921!
        Me.Line75.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line75.LineWeight = 1.0!
        Me.Line75.Name = "Line75"
        Me.Line75.Top = 5.289371!
        Me.Line75.Width = 6.305512!
        Me.Line75.X1 = 1.729921!
        Me.Line75.X2 = 8.035433!
        Me.Line75.Y1 = 5.289371!
        Me.Line75.Y2 = 5.289371!
        '
        'Line69
        '
        Me.Line69.Height = 0.7480311!
        Me.Line69.Left = 2.509449!
        Me.Line69.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line69.LineWeight = 1.0!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 5.289371!
        Me.Line69.Width = 0.00006389618!
        Me.Line69.X1 = 2.509449!
        Me.Line69.X2 = 2.509513!
        Me.Line69.Y1 = 5.289371!
        Me.Line69.Y2 = 6.037402!
        '
        'Line73
        '
        Me.Line73.Height = 0.7480321!
        Me.Line73.Left = 2.509449!
        Me.Line73.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line73.LineWeight = 1.0!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 6.293307!
        Me.Line73.Width = 0.00006508827!
        Me.Line73.X1 = 2.509449!
        Me.Line73.X2 = 2.509514!
        Me.Line73.Y1 = 6.293307!
        Me.Line73.Y2 = 7.041339!
        '
        'Line68
        '
        Me.Line68.Height = 0.2559061!
        Me.Line68.Left = 3.968111!
        Me.Line68.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line68.LineWeight = 1.0!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 5.033465!
        Me.Line68.Width = 0.00006628036!
        Me.Line68.X1 = 3.968111!
        Me.Line68.X2 = 3.968177!
        Me.Line68.Y1 = 5.033465!
        Me.Line68.Y2 = 5.289371!
        '
        'Line32
        '
        Me.Line32.Height = 1.535439!
        Me.Line32.Left = 3.640945!
        Me.Line32.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 7.041339!
        Me.Line32.Width = 0.0!
        Me.Line32.X1 = 3.640945!
        Me.Line32.X2 = 3.640945!
        Me.Line32.Y1 = 7.041339!
        Me.Line32.Y2 = 8.576777!
        '
        'Line13
        '
        Me.Line13.Height = 1.535439!
        Me.Line13.Left = 3.194095!
        Me.Line13.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 7.041339!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 3.194095!
        Me.Line13.X2 = 3.194095!
        Me.Line13.Y1 = 7.041339!
        Me.Line13.Y2 = 8.576777!
        '
        'Line12
        '
        Me.Line12.Height = 1.535439!
        Me.Line12.Left = 2.748032!
        Me.Line12.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 7.041339!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 2.748032!
        Me.Line12.X2 = 2.748032!
        Me.Line12.Y1 = 7.041339!
        Me.Line12.Y2 = 8.576777!
        '
        'Line66
        '
        Me.Line66.Height = 0.0!
        Me.Line66.Left = 1.729921!
        Me.Line66.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line66.LineWeight = 1.0!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 7.297245!
        Me.Line66.Width = 1.911024!
        Me.Line66.X1 = 1.729921!
        Me.Line66.X2 = 3.640945!
        Me.Line66.Y1 = 7.297245!
        Me.Line66.Y2 = 7.297245!
        '
        'Line31
        '
        Me.Line31.Height = 0.0!
        Me.Line31.Left = 1.729921!
        Me.Line31.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 7.55315!
        Me.Line31.Width = 4.264567!
        Me.Line31.X1 = 1.729921!
        Me.Line31.X2 = 5.994488!
        Me.Line31.Y1 = 7.55315!
        Me.Line31.Y2 = 7.55315!
        '
        'Line42
        '
        Me.Line42.Height = 0.0!
        Me.Line42.Left = 1.729921!
        Me.Line42.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line42.LineWeight = 1.0!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 7.809056!
        Me.Line42.Width = 6.30945!
        Me.Line42.X1 = 1.729921!
        Me.Line42.X2 = 8.039371!
        Me.Line42.Y1 = 7.809056!
        Me.Line42.Y2 = 7.809056!
        '
        'Line44
        '
        Me.Line44.Height = 0.0!
        Me.Line44.Left = 1.729921!
        Me.Line44.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line44.LineWeight = 1.0!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 8.064966!
        Me.Line44.Width = 6.30945!
        Me.Line44.X1 = 1.729921!
        Me.Line44.X2 = 8.039371!
        Me.Line44.Y1 = 8.064966!
        Me.Line44.Y2 = 8.064966!
        '
        'Line74
        '
        Me.Line74.Height = 0.0!
        Me.Line74.Left = 1.729921!
        Me.Line74.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line74.LineWeight = 1.0!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 8.320871!
        Me.Line74.Width = 6.30945!
        Me.Line74.X1 = 1.729921!
        Me.Line74.X2 = 8.039371!
        Me.Line74.Y1 = 8.320871!
        Me.Line74.Y2 = 8.320871!
        '
        'Line35
        '
        Me.Line35.Height = 1.023627!
        Me.Line35.Left = 5.214961!
        Me.Line35.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 7.55315!
        Me.Line35.Width = 0.0!
        Me.Line35.X1 = 5.214961!
        Me.Line35.X2 = 5.214961!
        Me.Line35.Y1 = 7.55315!
        Me.Line35.Y2 = 8.576777!
        '
        'Line41
        '
        Me.Line41.Height = 0.2559114!
        Me.Line41.Left = 7.218898!
        Me.Line41.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line41.LineWeight = 1.0!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 7.809055!
        Me.Line41.Width = 0.0!
        Me.Line41.X1 = 7.218898!
        Me.Line41.X2 = 7.218898!
        Me.Line41.Y1 = 7.809055!
        Me.Line41.Y2 = 8.064966!
        '
        'Line28
        '
        Me.Line28.Height = 0.2559061!
        Me.Line28.Left = 7.220474!
        Me.Line28.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 8.320871!
        Me.Line28.Width = 0.0!
        Me.Line28.X1 = 7.220474!
        Me.Line28.X2 = 7.220474!
        Me.Line28.Y1 = 8.320871!
        Me.Line28.Y2 = 8.576777!
        '
        'Line36
        '
        Me.Line36.Height = 1.023627!
        Me.Line36.Left = 5.994489!
        Me.Line36.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line36.LineWeight = 1.0!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 7.55315!
        Me.Line36.Width = 0.0!
        Me.Line36.X1 = 5.994489!
        Me.Line36.X2 = 5.994489!
        Me.Line36.Y1 = 7.55315!
        Me.Line36.Y2 = 8.576777!
        '
        'Line53
        '
        Me.Line53.Height = 0.255905!
        Me.Line53.Left = 6.062205!
        Me.Line53.LineWeight = 1.0!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 1.948819!
        Me.Line53.Width = 0.00006437302!
        Me.Line53.X1 = 6.062205!
        Me.Line53.X2 = 6.062269!
        Me.Line53.Y1 = 1.948819!
        Me.Line53.Y2 = 2.204724!
        '
        'Line52
        '
        Me.Line52.Height = 0.255905!
        Me.Line52.Left = 5.491339!
        Me.Line52.LineWeight = 1.0!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 1.948819!
        Me.Line52.Width = 0.00006389618!
        Me.Line52.X1 = 5.491339!
        Me.Line52.X2 = 5.491403!
        Me.Line52.Y1 = 1.948819!
        Me.Line52.Y2 = 2.204724!
        '
        'Line51
        '
        Me.Line51.Height = 0.255905!
        Me.Line51.Left = 3.640158!
        Me.Line51.LineWeight = 1.0!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 1.948819!
        Me.Line51.Width = 0.00006699562!
        Me.Line51.X1 = 3.640158!
        Me.Line51.X2 = 3.640225!
        Me.Line51.Y1 = 1.948819!
        Me.Line51.Y2 = 2.204724!
        '
        'Line50
        '
        Me.Line50.Height = 0.255905!
        Me.Line50.Left = 3.050394!
        Me.Line50.LineWeight = 1.0!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 1.948819!
        Me.Line50.Width = 0.00006604195!
        Me.Line50.X1 = 3.050394!
        Me.Line50.X2 = 3.05046!
        Me.Line50.Y1 = 1.948819!
        Me.Line50.Y2 = 2.204724!
        '
        'Line49
        '
        Me.Line49.Height = 0.255905!
        Me.Line49.Left = 2.066142!
        Me.Line49.LineWeight = 1.0!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 1.948819!
        Me.Line49.Width = 0.0!
        Me.Line49.X1 = 2.066142!
        Me.Line49.X2 = 2.066142!
        Me.Line49.Y1 = 1.948819!
        Me.Line49.Y2 = 2.204724!
        '
        'Line29
        '
        Me.Line29.Height = 8.412201!
        Me.Line29.Left = 1.729921!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 1.948819!
        Me.Line29.Width = 0.0!
        Me.Line29.X1 = 1.729921!
        Me.Line29.X2 = 1.729921!
        Me.Line29.Y1 = 1.948819!
        Me.Line29.Y2 = 10.36102!
        '
        'Line33
        '
        Me.Line33.Height = 1.023623!
        Me.Line33.Left = 1.729921!
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 0.6692914!
        Me.Line33.Width = 0.0!
        Me.Line33.X1 = 1.729921!
        Me.Line33.X2 = 1.729921!
        Me.Line33.Y1 = 0.6692914!
        Me.Line33.Y2 = 1.692914!
        '
        'Line7
        '
        Me.Line7.Height = 0.0!
        Me.Line7.Left = -0.003937008!
        Me.Line7.LineWeight = 3.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.6692908!
        Me.Line7.Width = 8.046062!
        Me.Line7.X1 = -0.003937008!
        Me.Line7.X2 = 8.042126!
        Me.Line7.Y1 = 0.6692908!
        Me.Line7.Y2 = 0.6692908!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line2.LineWeight = 3.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.692914!
        Me.Line2.Width = 8.035432!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 8.035432!
        Me.Line2.Y1 = 1.692914!
        Me.Line2.Y2 = 1.692914!
        '
        'Line45
        '
        Me.Line45.Height = 0.0!
        Me.Line45.Left = 0.0!
        Me.Line45.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line45.LineWeight = 3.0!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 1.948819!
        Me.Line45.Width = 8.035432!
        Me.Line45.X1 = 0.0!
        Me.Line45.X2 = 8.035432!
        Me.Line45.Y1 = 1.948819!
        Me.Line45.Y2 = 1.948819!
        '
        'Line48
        '
        Me.Line48.Height = 0.0!
        Me.Line48.Left = 0.0!
        Me.Line48.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
        Me.Line48.LineWeight = 3.0!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 2.972441!
        Me.Line48.Width = 8.035432!
        Me.Line48.X1 = 0.0!
        Me.Line48.X2 = 8.035432!
        Me.Line48.Y1 = 2.972441!
        Me.Line48.Y2 = 2.972441!
        '
        'Line58
        '
        Me.Line58.Height = 0.0!
        Me.Line58.Left = 0.0!
        Me.Line58.LineStyle = DataDynamics.ActiveReports.LineStyle.DashDot
        Me.Line58.LineWeight = 3.0!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 3.996063!
        Me.Line58.Width = 8.035432!
        Me.Line58.X1 = 0.0!
        Me.Line58.X2 = 8.035432!
        Me.Line58.Y1 = 3.996063!
        Me.Line58.Y2 = 3.996063!
        '
        'Line17
        '
        Me.Line17.Height = 0.0!
        Me.Line17.Left = 0.0!
        Me.Line17.LineWeight = 3.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 5.033465!
        Me.Line17.Width = 8.035432!
        Me.Line17.X1 = 0.0!
        Me.Line17.X2 = 8.035432!
        Me.Line17.Y1 = 5.033465!
        Me.Line17.Y2 = 5.033465!
        '
        'Line8
        '
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.0!
        Me.Line8.LineWeight = 3.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 7.041339!
        Me.Line8.Width = 8.035433!
        Me.Line8.X1 = 0.0!
        Me.Line8.X2 = 8.035433!
        Me.Line8.Y1 = 7.041339!
        Me.Line8.Y2 = 7.041339!
        '
        'Line80
        '
        Me.Line80.Height = 0.001180649!
        Me.Line80.Left = 0.0!
        Me.Line80.LineWeight = 3.0!
        Me.Line80.Name = "Line80"
        Me.Line80.Top = 8.576773!
        Me.Line80.Width = 8.035433!
        Me.Line80.X1 = 0.0!
        Me.Line80.X2 = 8.035433!
        Me.Line80.Y1 = 8.577953!
        Me.Line80.Y2 = 8.576773!
        '
        'Line26
        '
        Me.Line26.Height = 0.0!
        Me.Line26.Left = -0.003937008!
        Me.Line26.LineWeight = 3.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 10.36299!
        Me.Line26.Width = 8.046062!
        Me.Line26.X1 = -0.003937008!
        Me.Line26.X2 = 8.042126!
        Me.Line26.Y1 = 10.36299!
        Me.Line26.Y2 = 10.36299!
        '
        'Line27
        '
        Me.Line27.Height = 9.699213!
        Me.Line27.Left = 0.003937055!
        Me.Line27.LineWeight = 3.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 0.6677166!
        Me.Line27.Width = 0.0!
        Me.Line27.X1 = 0.003937055!
        Me.Line27.X2 = 0.003937055!
        Me.Line27.Y1 = 0.6677166!
        Me.Line27.Y2 = 10.36693!
        '
        'Line15
        '
        Me.Line15.Height = 9.699057!
        Me.Line15.Left = 8.039371!
        Me.Line15.LineWeight = 3.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.6678734!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 8.039371!
        Me.Line15.X2 = 8.039371!
        Me.Line15.Y1 = 0.6678734!
        Me.Line15.Y2 = 10.36693!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'KaijoReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 8.059055!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: ""ＭＳ ゴシック""; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_ADDRESS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_DATE_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_KAIJO_LAYOUT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_TIME1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKA_YOTEI_CNT_MBR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_TEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZETIA_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEIHIN_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_PRT_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEND_FLAG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAIJO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_TEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKA_YOTEI_CNT_NMBR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRM_HACYU_KBN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOSAN_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOSAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOSAN_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_YOSAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_YOSAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_ADDRESS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_TIME2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_SANKA_YOTEI_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_ROOM_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STAY_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_KOTSU_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents PrintDate As DataDynamics.ActiveReports.TextBox
    Private WithEvents LOGIN_USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageCount As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageTotal As DataDynamics.ActiveReports.TextBox
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents LabelPage As DataDynamics.ActiveReports.Label
    Private WithEvents SEND_FLAG As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KAIJO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents Label37 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents SEIHIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_PRT_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents ZETIA_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line40 As DataDynamics.ActiveReports.Line
    Private WithEvents Line43 As DataDynamics.ActiveReports.Line
    Private WithEvents Label44 As DataDynamics.ActiveReports.Label
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents SHONIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line45 As DataDynamics.ActiveReports.Line
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents Label46 As DataDynamics.ActiveReports.Label
    Private WithEvents Label47 As DataDynamics.ActiveReports.Label
    Private WithEvents BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line46 As DataDynamics.ActiveReports.Line
    Private WithEvents Line47 As DataDynamics.ActiveReports.Line
    Private WithEvents Line48 As DataDynamics.ActiveReports.Line
    Private WithEvents Line49 As DataDynamics.ActiveReports.Line
    Private WithEvents Line50 As DataDynamics.ActiveReports.Line
    Private WithEvents Line51 As DataDynamics.ActiveReports.Line
    Private WithEvents Line52 As DataDynamics.ActiveReports.Line
    Private WithEvents Line53 As DataDynamics.ActiveReports.Line
    Private WithEvents Label50 As DataDynamics.ActiveReports.Label
    Private WithEvents Label49 As DataDynamics.ActiveReports.Label
    Private WithEvents Label48 As DataDynamics.ActiveReports.Label
    Private WithEvents Line54 As DataDynamics.ActiveReports.Line
    Private WithEvents Line55 As DataDynamics.ActiveReports.Line
    Private WithEvents KIKAKU_TANTO_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_TEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EMAIL_PC As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EMAIL_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_EMAIL_PC As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_TEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_EMAIL_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label51 As DataDynamics.ActiveReports.Label
    Private WithEvents Label52 As DataDynamics.ActiveReports.Label
    Private WithEvents TEHAI_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label53 As DataDynamics.ActiveReports.Label
    Private WithEvents Label54 As DataDynamics.ActiveReports.Label
    Private WithEvents Label55 As DataDynamics.ActiveReports.Label
    Private WithEvents Label56 As DataDynamics.ActiveReports.Label
    Private WithEvents Label57 As DataDynamics.ActiveReports.Label
    Private WithEvents Label58 As DataDynamics.ActiveReports.Label
    Private WithEvents Label59 As DataDynamics.ActiveReports.Label
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line56 As DataDynamics.ActiveReports.Line
    Private WithEvents Line57 As DataDynamics.ActiveReports.Line
    Private WithEvents Line58 As DataDynamics.ActiveReports.Line
    Private WithEvents Line59 As DataDynamics.ActiveReports.Line
    Private WithEvents Line60 As DataDynamics.ActiveReports.Line
    Private WithEvents Line61 As DataDynamics.ActiveReports.Line
    Private WithEvents Line62 As DataDynamics.ActiveReports.Line
    Private WithEvents Line63 As DataDynamics.ActiveReports.Line
    Private WithEvents Line64 As DataDynamics.ActiveReports.Line
    Private WithEvents Line65 As DataDynamics.ActiveReports.Line
    Private WithEvents Line34 As DataDynamics.ActiveReports.Line
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents SANKA_YOTEI_CNT_NMBR As DataDynamics.ActiveReports.TextBox
    Private WithEvents SRM_HACYU_KBN As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKA_YOTEI_CNT_MBR As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents YOSAN_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents YOSAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents YOSAN_TOTAL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents IKENKOUKAN_YOSAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_YOSAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_DATE_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_KIBOU_ADDRESS1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KAISAI_KIBOU_ADDRESS2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line38 As DataDynamics.ActiveReports.Line
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents Label35 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUEN_TIME1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUEN_KAIJO_LAYOUT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label62 As DataDynamics.ActiveReports.Label
    Private WithEvents Line70 As DataDynamics.ActiveReports.Line
    Private WithEvents Line71 As DataDynamics.ActiveReports.Line
    Private WithEvents Line72 As DataDynamics.ActiveReports.Line
    Private WithEvents KOUEN_TIME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label63 As DataDynamics.ActiveReports.Label
    Private WithEvents Label64 As DataDynamics.ActiveReports.Label
    Private WithEvents Label65 As DataDynamics.ActiveReports.Label
    Private WithEvents Label66 As DataDynamics.ActiveReports.Label
    Private WithEvents Label67 As DataDynamics.ActiveReports.Label
    Private WithEvents Label68 As DataDynamics.ActiveReports.Label
    Private WithEvents Label69 As DataDynamics.ActiveReports.Label
    Private WithEvents Label70 As DataDynamics.ActiveReports.Label
    Private WithEvents Label71 As DataDynamics.ActiveReports.Label
    Private WithEvents Label72 As DataDynamics.ActiveReports.Label
    Private WithEvents Label73 As DataDynamics.ActiveReports.Label
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents IKENKOUKAN_KAIJO_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_KAIJO_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_SANKA_YOTEI_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_FROM As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_KAIJO_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_ROOM_FROM As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line80 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Line42 As DataDynamics.ActiveReports.Line
    Private WithEvents Line44 As DataDynamics.ActiveReports.Line
    Private WithEvents Line74 As DataDynamics.ActiveReports.Line
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents Label36 As DataDynamics.ActiveReports.Label
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents Label74 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_STAY_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_KOTSU_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents OTHER_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line82 As DataDynamics.ActiveReports.Line
    Private WithEvents Line83 As DataDynamics.ActiveReports.Line
    Private WithEvents Line84 As DataDynamics.ActiveReports.Line
    Private WithEvents Line85 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Label75 As DataDynamics.ActiveReports.Label
    Private WithEvents Label76 As DataDynamics.ActiveReports.Label
    Private WithEvents Label77 As DataDynamics.ActiveReports.Label
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents MANAGER_KAIJO_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_KAIJO_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents IKENKOUKAN_KAIJO_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line35 As DataDynamics.ActiveReports.Line
    Private WithEvents Line36 As DataDynamics.ActiveReports.Line
    Private WithEvents Line41 As DataDynamics.ActiveReports.Line
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line66 As DataDynamics.ActiveReports.Line
    Private WithEvents Label78 As DataDynamics.ActiveReports.Label
    Private WithEvents Line67 As DataDynamics.ActiveReports.Line
    Private WithEvents Line68 As DataDynamics.ActiveReports.Line
    Private WithEvents Line76 As DataDynamics.ActiveReports.Line
    Private WithEvents Line77 As DataDynamics.ActiveReports.Line
    Private WithEvents Line78 As DataDynamics.ActiveReports.Line
    Private WithEvents Line79 As DataDynamics.ActiveReports.Line
    Private WithEvents Line73 As DataDynamics.ActiveReports.Line
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_KIBOU_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Line75 As DataDynamics.ActiveReports.Line
    Private WithEvents Line69 As DataDynamics.ActiveReports.Line
    Private WithEvents Line33 As DataDynamics.ActiveReports.Line
End Class
