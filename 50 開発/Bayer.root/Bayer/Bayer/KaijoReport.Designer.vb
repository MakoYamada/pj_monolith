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
        Me.LabelPage = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.KAISAI_DATE_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.SHONIN_DATE = New DataDynamics.ActiveReports.TextBox
        Me.SHONIN_NAME = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.Label37 = New DataDynamics.ActiveReports.Label
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.TAXI_PRT_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.SEIHIN_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.INTERNAL_ORDER_T = New DataDynamics.ActiveReports.TextBox
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.INTERNAL_ORDER_TF = New DataDynamics.ActiveReports.TextBox
        Me.ACCOUNT_CD_T = New DataDynamics.ActiveReports.TextBox
        Me.ACCOUNT_CD_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label44 = New DataDynamics.ActiveReports.Label
        Me.ZETIA_CD = New DataDynamics.ActiveReports.TextBox
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label45 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.Label46 = New DataDynamics.ActiveReports.Label
        Me.Label47 = New DataDynamics.ActiveReports.Label
        Me.Label48 = New DataDynamics.ActiveReports.Label
        Me.Label49 = New DataDynamics.ActiveReports.Label
        Me.Label50 = New DataDynamics.ActiveReports.Label
        Me.Label51 = New DataDynamics.ActiveReports.Label
        Me.Label52 = New DataDynamics.ActiveReports.Label
        Me.BU = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EMAIL_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_EMAIL_PC = New DataDynamics.ActiveReports.TextBox
        Me.KIKAKU_TANTO_TEL = New DataDynamics.ActiveReports.TextBox
        Me.Label53 = New DataDynamics.ActiveReports.Label
        Me.Label54 = New DataDynamics.ActiveReports.Label
        Me.Label55 = New DataDynamics.ActiveReports.Label
        Me.Label56 = New DataDynamics.ActiveReports.Label
        Me.Label57 = New DataDynamics.ActiveReports.Label
        Me.Label58 = New DataDynamics.ActiveReports.Label
        Me.Label59 = New DataDynamics.ActiveReports.Label
        Me.Label60 = New DataDynamics.ActiveReports.Label
        Me.Label61 = New DataDynamics.ActiveReports.Label
        Me.Label62 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_TANTO_BU = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_AREA = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_NAME = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_EMAIL_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_EMAIL_PC = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TANTO_TEL = New DataDynamics.ActiveReports.TextBox
        Me.Label63 = New DataDynamics.ActiveReports.Label
        Me.Label64 = New DataDynamics.ActiveReports.Label
        Me.SANKA_YOTEI_CNT_NMBR = New DataDynamics.ActiveReports.TextBox
        Me.Label65 = New DataDynamics.ActiveReports.Label
        Me.Label66 = New DataDynamics.ActiveReports.Label
        Me.Label67 = New DataDynamics.ActiveReports.Label
        Me.SANKA_YOTEI_CNT_MBR = New DataDynamics.ActiveReports.TextBox
        Me.Label68 = New DataDynamics.ActiveReports.Label
        Me.Label69 = New DataDynamics.ActiveReports.Label
        Me.SRM_HACYU_KBN = New DataDynamics.ActiveReports.TextBox
        Me.YOSAN_T = New DataDynamics.ActiveReports.TextBox
        Me.YOSAN_TF = New DataDynamics.ActiveReports.TextBox
        Me.Label70 = New DataDynamics.ActiveReports.Label
        Me.Label71 = New DataDynamics.ActiveReports.Label
        Me.YOSAN_TOTAL = New DataDynamics.ActiveReports.TextBox
        Me.Label72 = New DataDynamics.ActiveReports.Label
        Me.IROUKAI_YOSAN_T = New DataDynamics.ActiveReports.TextBox
        Me.IKENKOUKAN_YOSAN_T = New DataDynamics.ActiveReports.TextBox
        Me.Label73 = New DataDynamics.ActiveReports.Label
        Me.Label74 = New DataDynamics.ActiveReports.Label
        Me.Label75 = New DataDynamics.ActiveReports.Label
        Me.KAISAI_KIBOU_ADDRESS1 = New DataDynamics.ActiveReports.TextBox
        Me.Label79 = New DataDynamics.ActiveReports.Label
        Me.KAISAI_KIBOU_ADDRESS2 = New DataDynamics.ActiveReports.TextBox
        Me.Label77 = New DataDynamics.ActiveReports.Label
        Me.KAISAI_KIBOU_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Label78 = New DataDynamics.ActiveReports.Label
        Me.Label83 = New DataDynamics.ActiveReports.Label
        Me.Label76 = New DataDynamics.ActiveReports.Label
        Me.Label84 = New DataDynamics.ActiveReports.Label
        Me.Label85 = New DataDynamics.ActiveReports.Label
        Me.Label86 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label87 = New DataDynamics.ActiveReports.Label
        Me.KOUEN_TIME1 = New DataDynamics.ActiveReports.TextBox
        Me.KOUEN_TIME2 = New DataDynamics.ActiveReports.TextBox
        Me.KOUEN_KAIJO_LAYOUT = New DataDynamics.ActiveReports.TextBox
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_KAIJO_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_KAIJO_TEHAI_Yes = New DataDynamics.ActiveReports.TextBox
        Me.IKENKOUKAN_KAIJO_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_KAIJO_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_KAIJO_TEHAI_No = New DataDynamics.ActiveReports.TextBox
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.IROUKAI_SANKA_YOTEI_CNT = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_FROM = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_ROOM_FROM = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.REQ_ROOM_CNT = New DataDynamics.ActiveReports.TextBox
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.REQ_STAY_DATE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_KOTSU_CNT = New DataDynamics.ActiveReports.TextBox
        Me.Label82 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_CNT = New DataDynamics.ActiveReports.TextBox
        Me.Label89 = New DataDynamics.ActiveReports.Label
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.OTHER_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.IKENKOUKAN_KAIJO_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.KOUSHI_ROOM_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.IROUKAI_KAIJO_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.SHAIN_ROOM_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.MANAGER_KAIJO_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_DATE_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_PRT_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEIHIN_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERNAL_ORDER_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERNAL_ORDER_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCOUNT_CD_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCOUNT_CD_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZETIA_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KIKAKU_TANTO_TEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_BU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TANTO_TEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKA_YOTEI_CNT_NMBR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKA_YOTEI_CNT_MBR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRM_HACYU_KBN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOSAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOSAN_TF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YOSAN_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_YOSAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_YOSAN_T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_ADDRESS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_ADDRESS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KAISAI_KIBOU_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_TIME1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_TIME2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUEN_KAIJO_LAYOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_SANKA_YOTEI_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_ROOM_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_ROOM_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STAY_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_KOTSU_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_CNT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OTHER_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUSHI_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IROUKAI_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHAIN_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANAGER_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.LOGIN_USER_NAME, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.PrintDate, Me.Shape1, Me.PageTotal, Me.PageCount, Me.Label8, Me.LabelPage})
        Me.PageHeader.Height = 0.8496063!
        Me.PageHeader.Name = "PageHeader"
        '
        'LOGIN_USER_NAME
        '
        Me.LOGIN_USER_NAME.CanGrow = False
        Me.LOGIN_USER_NAME.DataField = "USER_NAME"
        Me.LOGIN_USER_NAME.Height = 0.1968504!
        Me.LOGIN_USER_NAME.Left = 6.143308!
        Me.LOGIN_USER_NAME.Name = "LOGIN_USER_NAME"
        Me.LOGIN_USER_NAME.Style = "font-family: ＭＳ ゴシック"
        Me.LOGIN_USER_NAME.Text = Nothing
        Me.LOGIN_USER_NAME.Top = 0.1771654!
        Me.LOGIN_USER_NAME.Width = 1.377953!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.392521!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label1.Text = "出力日"
        Me.Label1.Top = 0.00000001490116!
        Me.Label1.Width = 0.6251969!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.39252!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label2.Text = "出力担当"
        Me.Label2.Top = 0.1771655!
        Me.Label2.Width = 0.6251969!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 5.98665!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label3.Text = "："
        Me.Label3.Top = 0.1772966!
        Me.Label3.Width = 0.1669291!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 5.986649!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 10pt"
        Me.Label4.Text = "："
        Me.Label4.Top = 0.0001311302!
        Me.Label4.Width = 0.1669291!
        '
        'PrintDate
        '
        Me.PrintDate.Height = 0.1968504!
        Me.PrintDate.Left = 6.143342!
        Me.PrintDate.Name = "PrintDate"
        Me.PrintDate.Style = "font-family: ＭＳ ゴシック"
        Me.PrintDate.Text = "2013/12/12 00:00:00"
        Me.PrintDate.Top = 0.0001311302!
        Me.PrintDate.Width = 1.377953!
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Shape1.Height = 0.2480315!
        Me.Shape1.Left = 0.0001883507!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.5612205!
        Me.Shape1.Width = 7.529922!
        '
        'PageTotal
        '
        Me.PageTotal.Height = 0.1692913!
        Me.PageTotal.Left = 4.91063!
        Me.PageTotal.Name = "PageTotal"
        Me.PageTotal.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageTotal.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageTotal.Text = "000"
        Me.PageTotal.Top = 0.3590551!
        Me.PageTotal.Visible = False
        Me.PageTotal.Width = 0.2755905!
        '
        'PageCount
        '
        Me.PageCount.Height = 0.1692913!
        Me.PageCount.Left = 4.556299!
        Me.PageCount.Name = "PageCount"
        Me.PageCount.Style = "font-family: ＭＳ ゴシック; text-align: right"
        Me.PageCount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.PageCount.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.PageCount.Text = "000"
        Me.PageCount.Top = 0.3590551!
        Me.PageCount.Visible = False
        Me.PageCount.Width = 0.2755905!
        '
        'Label8
        '
        Me.Label8.Height = 0.2165354!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 2.879921!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = resources.GetString("Label8.Style")
        Me.Label8.Text = "会場手配依頼"
        Me.Label8.Top = 0.584252!
        Me.Label8.Width = 1.770473!
        '
        'LabelPage
        '
        Me.LabelPage.Height = 0.1771654!
        Me.LabelPage.HyperLink = Nothing
        Me.LabelPage.Left = 6.084646!
        Me.LabelPage.Name = "LabelPage"
        Me.LabelPage.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; text-align: right"
        Me.LabelPage.Text = "(999/999ページ)"
        Me.LabelPage.Top = 0.3740157!
        Me.LabelPage.Width = 1.429133!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.KAISAI_DATE_NOTE, Me.SHONIN_DATE, Me.SHONIN_NAME, Me.FROM_DATE, Me.TIME_STAMP_BYL, Me.REQ_STATUS_TEHAI, Me.KOUENKAI_NO, Me.KOUENKAI_NAME, Me.Label6, Me.Label7, Me.Label9, Me.Label14, Me.Label22, Me.Label37, Me.Label40, Me.Label10, Me.TAXI_PRT_NAME, Me.Label12, Me.TO_DATE, Me.Label16, Me.SEIHIN_NAME, Me.Label13, Me.Label17, Me.INTERNAL_ORDER_T, Me.Label18, Me.Label41, Me.Label42, Me.INTERNAL_ORDER_TF, Me.ACCOUNT_CD_T, Me.ACCOUNT_CD_TF, Me.Label44, Me.ZETIA_CD, Me.Label5, Me.Label45, Me.Label43, Me.Label46, Me.Label47, Me.Label48, Me.Label49, Me.Label50, Me.Label51, Me.Label52, Me.BU, Me.KIKAKU_TANTO_AREA, Me.KIKAKU_TANTO_EIGYOSHO, Me.KIKAKU_TANTO_NAME, Me.KIKAKU_TANTO_ROMA, Me.KIKAKU_TANTO_KEITAI, Me.KIKAKU_TANTO_EMAIL_KEITAI, Me.KIKAKU_TANTO_EMAIL_PC, Me.KIKAKU_TANTO_TEL, Me.Label53, Me.Label54, Me.Label55, Me.Label56, Me.Label57, Me.Label58, Me.Label59, Me.Label60, Me.Label61, Me.Label62, Me.TEHAI_TANTO_BU, Me.TEHAI_TANTO_AREA, Me.TEHAI_TANTO_EIGYOSHO, Me.TEHAI_TANTO_NAME, Me.TEHAI_TANTO_ROMA, Me.TEHAI_TANTO_KEITAI, Me.TEHAI_TANTO_EMAIL_KEITAI, Me.TEHAI_TANTO_EMAIL_PC, Me.TEHAI_TANTO_TEL, Me.Label63, Me.Label64, Me.SANKA_YOTEI_CNT_NMBR, Me.Label65, Me.Label66, Me.Label67, Me.SANKA_YOTEI_CNT_MBR, Me.Label68, Me.Label69, Me.SRM_HACYU_KBN, Me.YOSAN_T, Me.YOSAN_TF, Me.Label70, Me.Label71, Me.YOSAN_TOTAL, Me.Label72, Me.IROUKAI_YOSAN_T, Me.IKENKOUKAN_YOSAN_T, Me.Label73, Me.Label74, Me.Label75, Me.KAISAI_KIBOU_ADDRESS1, Me.Label79, Me.KAISAI_KIBOU_ADDRESS2, Me.Label77, Me.KAISAI_KIBOU_NOTE, Me.Label78, Me.Label83, Me.Label76, Me.Label84, Me.Label85, Me.Label86, Me.Label15, Me.Label19, Me.Label25, Me.Label87, Me.KOUEN_TIME1, Me.KOUEN_TIME2, Me.KOUEN_KAIJO_LAYOUT, Me.Label20, Me.Label21, Me.IKENKOUKAN_KAIJO_TEHAI_Yes, Me.IROUKAI_KAIJO_TEHAI_Yes, Me.KOUSHI_ROOM_TEHAI_Yes, Me.SHAIN_ROOM_TEHAI_Yes, Me.MANAGER_KAIJO_TEHAI_Yes, Me.IKENKOUKAN_KAIJO_TEHAI_No, Me.IROUKAI_KAIJO_TEHAI_No, Me.KOUSHI_ROOM_TEHAI_No, Me.SHAIN_ROOM_TEHAI_No, Me.MANAGER_KAIJO_TEHAI_No, Me.Label23, Me.Label24, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.IROUKAI_SANKA_YOTEI_CNT, Me.KOUSHI_ROOM_FROM, Me.SHAIN_ROOM_CNT, Me.MANAGER_ROOM_FROM, Me.KOUSHI_ROOM_CNT, Me.MANAGER_ROOM_CNT, Me.Label30, Me.Label31, Me.REQ_ROOM_CNT, Me.Label32, Me.REQ_STAY_DATE, Me.REQ_KOTSU_CNT, Me.Label82, Me.REQ_TAXI_CNT, Me.Label89, Me.Label34, Me.OTHER_NOTE, Me.IKENKOUKAN_KAIJO_TEHAI, Me.KOUSHI_ROOM_TEHAI, Me.IROUKAI_KAIJO_TEHAI, Me.SHAIN_ROOM_TEHAI, Me.MANAGER_KAIJO_TEHAI})
        Me.Detail.Height = 10.16517!
        Me.Detail.Name = "Detail"
        Me.Detail.NewPage = DataDynamics.ActiveReports.NewPage.After
        '
        'KAISAI_DATE_NOTE
        '
        Me.KAISAI_DATE_NOTE.CanGrow = False
        Me.KAISAI_DATE_NOTE.DataField = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Height = 0.492126!
        Me.KAISAI_DATE_NOTE.Left = 1.482677!
        Me.KAISAI_DATE_NOTE.Name = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Padding = New DataDynamics.ActiveReports.PaddingEx(0, 2, 0, 0)
        Me.KAISAI_DATE_NOTE.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt"
        Me.KAISAI_DATE_NOTE.Text = "KAISAI_DATE_NOTE"
        Me.KAISAI_DATE_NOTE.Top = 1.253543!
        Me.KAISAI_DATE_NOTE.Width = 6.04882!
        '
        'SHONIN_DATE
        '
        Me.SHONIN_DATE.CanGrow = False
        Me.SHONIN_DATE.DataField = "SHONIN_DATE"
        Me.SHONIN_DATE.Height = 0.1771654!
        Me.SHONIN_DATE.Left = 4.576772!
        Me.SHONIN_DATE.Name = "SHONIN_DATE"
        Me.SHONIN_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.SHONIN_DATE.Text = "SHONIN_DATE"
        Me.SHONIN_DATE.Top = 0.4212599!
        Me.SHONIN_DATE.Width = 1.574803!
        '
        'SHONIN_NAME
        '
        Me.SHONIN_NAME.CanGrow = False
        Me.SHONIN_NAME.DataField = "SHONIN_NAME"
        Me.SHONIN_NAME.Height = 0.1771654!
        Me.SHONIN_NAME.Left = 1.482677!
        Me.SHONIN_NAME.Name = "SHONIN_NAME"
        Me.SHONIN_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.SHONIN_NAME.Text = "SHONIN_NAME"
        Me.SHONIN_NAME.Top = 0.4212599!
        Me.SHONIN_NAME.Width = 2.086614!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.CanGrow = False
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.1771654!
        Me.FROM_DATE.Left = 1.482677!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.FROM_DATE.Text = "FROM_DATE"
        Me.FROM_DATE.Top = 0.8307087!
        Me.FROM_DATE.Width = 2.755906!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.CanGrow = False
        Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Height = 0.1771654!
        Me.TIME_STAMP_BYL.Left = 6.010632!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.TIME_STAMP_BYL.Text = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Top = 0.212599!
        Me.TIME_STAMP_BYL.Width = 1.526771!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.CanGrow = False
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.1771654!
        Me.REQ_STATUS_TEHAI.Left = 3.908662!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.REQ_STATUS_TEHAI.Text = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Top = 0.2125989!
        Me.REQ_STATUS_TEHAI.Width = 1.023622!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.CanGrow = False
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.1771654!
        Me.KOUENKAI_NO.Left = 1.482677!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.KOUENKAI_NO.Text = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Top = 0.2125989!
        Me.KOUENKAI_NO.Width = 1.181102!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.1771654!
        Me.KOUENKAI_NAME.Left = 1.482677!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; font-weight: normal; vertical-align: midd" & _
            "le; white-space: nowrap"
        Me.KOUENKAI_NAME.Text = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Top = 0.628347!
        Me.KOUENKAI_NAME.Width = 6.04882!
        '
        'Label6
        '
        Me.Label6.Height = 0.1968504!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0000002384186!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal"
        Me.Label6.Text = "■ 講演会情報"
        Me.Label6.Top = 0.02519743!
        Me.Label6.Width = 7.086614!
        '
        'Label7
        '
        Me.Label7.Height = 0.1771654!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.02755908!
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label7.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label7.Text = "会合番号"
        Me.Label7.Top = 0.2125989!
        Me.Label7.Width = 1.417323!
        '
        'Label9
        '
        Me.Label9.Height = 0.1771654!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 2.972441!
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label9.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label9.Text = "依頼内容"
        Me.Label9.Top = 0.2125989!
        Me.Label9.Width = 0.9055118!
        '
        'Label14
        '
        Me.Label14.Height = 0.1771654!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 5.07441!
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label14.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label14.Text = "Timestamp"
        Me.Label14.Top = 0.212599!
        Me.Label14.Width = 0.9055118!
        '
        'Label22
        '
        Me.Label22.Height = 0.1771654!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.02755882!
        Me.Label22.Name = "Label22"
        Me.Label22.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label22.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label22.Text = "承認者"
        Me.Label22.Top = 0.4212599!
        Me.Label22.Width = 1.417323!
        '
        'Label37
        '
        Me.Label37.Height = 0.1771654!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 3.63504!
        Me.Label37.Name = "Label37"
        Me.Label37.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label37.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label37.Text = "承認日"
        Me.Label37.Top = 0.4212599!
        Me.Label37.Width = 0.9055118!
        '
        'Label40
        '
        Me.Label40.Height = 0.1771654!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 0.0275593!
        Me.Label40.Name = "Label40"
        Me.Label40.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label40.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label40.Text = "会合名"
        Me.Label40.Top = 0.628347!
        Me.Label40.Width = 1.417323!
        '
        'Label10
        '
        Me.Label10.Height = 0.1771654!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.02755906!
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label10.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label10.Text = "チケット印字名"
        Me.Label10.Top = 1.046457!
        Me.Label10.Width = 1.417323!
        '
        'TAXI_PRT_NAME
        '
        Me.TAXI_PRT_NAME.CanGrow = False
        Me.TAXI_PRT_NAME.DataField = "TAXI_PRT_NAME"
        Me.TAXI_PRT_NAME.Height = 0.1771654!
        Me.TAXI_PRT_NAME.Left = 1.482677!
        Me.TAXI_PRT_NAME.Name = "TAXI_PRT_NAME"
        Me.TAXI_PRT_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.TAXI_PRT_NAME.Text = "TAXI_PRT_NAME"
        Me.TAXI_PRT_NAME.Top = 1.046457!
        Me.TAXI_PRT_NAME.Width = 2.086615!
        '
        'Label12
        '
        Me.Label12.Height = 0.1771654!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0275593!
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label12.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label12.Text = "講演開催日"
        Me.Label12.Top = 0.8307087!
        Me.Label12.Width = 1.417323!
        '
        'TO_DATE
        '
        Me.TO_DATE.CanGrow = False
        Me.TO_DATE.DataField = "TO_DATE"
        Me.TO_DATE.Height = 0.1771654!
        Me.TO_DATE.Left = 4.527559!
        Me.TO_DATE.Name = "TO_DATE"
        Me.TO_DATE.Style = "font-family: ＭＳ ゴシック; vertical-align: middle; white-space: nowrap"
        Me.TO_DATE.Text = "TO_DATE"
        Me.TO_DATE.Top = 0.8307087!
        Me.TO_DATE.Visible = False
        Me.TO_DATE.Width = 1.574803!
        '
        'Label16
        '
        Me.Label16.Height = 0.1771654!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 3.63504!
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label16.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label16.Text = "製品名"
        Me.Label16.Top = 1.046457!
        Me.Label16.Width = 0.9055118!
        '
        'SEIHIN_NAME
        '
        Me.SEIHIN_NAME.CanGrow = False
        Me.SEIHIN_NAME.DataField = "SEIHIN_NAME"
        Me.SEIHIN_NAME.Height = 0.1771654!
        Me.SEIHIN_NAME.Left = 4.576772!
        Me.SEIHIN_NAME.Name = "SEIHIN_NAME"
        Me.SEIHIN_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.SEIHIN_NAME.Text = "SEIHIN_NAME"
        Me.SEIHIN_NAME.Top = 1.046457!
        Me.SEIHIN_NAME.Width = 2.954724!
        '
        'Label13
        '
        Me.Label13.Height = 0.492126!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0275593!
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label13.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label13.Text = "開催日備考"
        Me.Label13.Top = 1.253543!
        Me.Label13.Width = 1.417323!
        '
        'Label17
        '
        Me.Label17.Height = 0.3149606!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.02755906!
        Me.Label17.Name = "Label17"
        Me.Label17.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label17.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label17.Text = "Internal Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(課税)"
        Me.Label17.Top = 1.775591!
        Me.Label17.Width = 1.417323!
        '
        'INTERNAL_ORDER_T
        '
        Me.INTERNAL_ORDER_T.CanGrow = False
        Me.INTERNAL_ORDER_T.DataField = "INTERNAL_ORDER_T"
        Me.INTERNAL_ORDER_T.Height = 0.3149606!
        Me.INTERNAL_ORDER_T.Left = 1.482677!
        Me.INTERNAL_ORDER_T.Name = "INTERNAL_ORDER_T"
        Me.INTERNAL_ORDER_T.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.INTERNAL_ORDER_T.Text = "INTERNAL_ORDER_T"
        Me.INTERNAL_ORDER_T.Top = 1.775591!
        Me.INTERNAL_ORDER_T.Width = 0.9212598!
        '
        'Label18
        '
        Me.Label18.Height = 0.3149606!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.460236!
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label18.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label18.Text = "Internal Order" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(非課税)"
        Me.Label18.Top = 1.775591!
        Me.Label18.Width = 1.007874!
        '
        'Label41
        '
        Me.Label41.Height = 0.3149606!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 4.492126!
        Me.Label41.Name = "Label41"
        Me.Label41.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label41.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label41.Text = "Account Code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(課税)"
        Me.Label41.Top = 1.775591!
        Me.Label41.Width = 0.8779528!
        '
        'Label42
        '
        Me.Label42.Height = 0.3149606!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 6.037795!
        Me.Label42.Name = "Label42"
        Me.Label42.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label42.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label42.Text = "Account Code" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(非課税)"
        Me.Label42.Top = 1.775591!
        Me.Label42.Width = 0.8779528!
        '
        'INTERNAL_ORDER_TF
        '
        Me.INTERNAL_ORDER_TF.CanGrow = False
        Me.INTERNAL_ORDER_TF.DataField = "INTERNAL_ORDER_TF"
        Me.INTERNAL_ORDER_TF.Height = 0.3149606!
        Me.INTERNAL_ORDER_TF.Left = 3.497638!
        Me.INTERNAL_ORDER_TF.Name = "INTERNAL_ORDER_TF"
        Me.INTERNAL_ORDER_TF.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.INTERNAL_ORDER_TF.Text = "INTERNAL_ORDER_TF"
        Me.INTERNAL_ORDER_TF.Top = 1.775591!
        Me.INTERNAL_ORDER_TF.Width = 0.9212598!
        '
        'ACCOUNT_CD_T
        '
        Me.ACCOUNT_CD_T.CanGrow = False
        Me.ACCOUNT_CD_T.DataField = "ACCOUNT_CD_T"
        Me.ACCOUNT_CD_T.Height = 0.3149606!
        Me.ACCOUNT_CD_T.Left = 5.390945!
        Me.ACCOUNT_CD_T.Name = "ACCOUNT_CD_T"
        Me.ACCOUNT_CD_T.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.ACCOUNT_CD_T.Text = "ACCOUNT_CD_T"
        Me.ACCOUNT_CD_T.Top = 1.775591!
        Me.ACCOUNT_CD_T.Width = 0.5787402!
        '
        'ACCOUNT_CD_TF
        '
        Me.ACCOUNT_CD_TF.CanGrow = False
        Me.ACCOUNT_CD_TF.DataField = "ACCOUNT_CD_TF"
        Me.ACCOUNT_CD_TF.Height = 0.3149606!
        Me.ACCOUNT_CD_TF.Left = 6.949998!
        Me.ACCOUNT_CD_TF.Name = "ACCOUNT_CD_TF"
        Me.ACCOUNT_CD_TF.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.ACCOUNT_CD_TF.Text = "ACCOUNT_CD_TF"
        Me.ACCOUNT_CD_TF.Top = 1.775591!
        Me.ACCOUNT_CD_TF.Width = 0.5787402!
        '
        'Label44
        '
        Me.Label44.Height = 0.1771654!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 0.0275593!
        Me.Label44.Name = "Label44"
        Me.Label44.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label44.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label44.Text = "Zetia Code"
        Me.Label44.Top = 2.111024!
        Me.Label44.Width = 1.417323!
        '
        'ZETIA_CD
        '
        Me.ZETIA_CD.CanGrow = False
        Me.ZETIA_CD.DataField = "ZETIA_CD"
        Me.ZETIA_CD.Height = 0.1771654!
        Me.ZETIA_CD.Left = 1.482677!
        Me.ZETIA_CD.Name = "ZETIA_CD"
        Me.ZETIA_CD.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap"
        Me.ZETIA_CD.Text = "ZETIA_CD"
        Me.ZETIA_CD.Top = 2.111024!
        Me.ZETIA_CD.Width = 0.8385828!
        '
        'Label5
        '
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal"
        Me.Label5.Text = "■ 講演会 企画担当者"
        Me.Label5.Top = 2.369292!
        Me.Label5.Width = 7.086611!
        '
        'Label45
        '
        Me.Label45.Height = 0.1771654!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 0.02755906!
        Me.Label45.Name = "Label45"
        Me.Label45.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label45.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle"
        Me.Label45.Text = "所属BU"
        Me.Label45.Top = 2.552756!
        Me.Label45.Width = 1.417323!
        '
        'Label43
        '
        Me.Label43.Height = 0.1771654!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 0.02755906!
        Me.Label43.Name = "Label43"
        Me.Label43.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label43.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label43.Text = "所属エリア"
        Me.Label43.Top = 2.759843!
        Me.Label43.Width = 1.417323!
        '
        'Label46
        '
        Me.Label46.Height = 0.1771654!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.02755906!
        Me.Label46.Name = "Label46"
        Me.Label46.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label46.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label46.Text = "所属営業所"
        Me.Label46.Top = 2.966929!
        Me.Label46.Width = 1.417323!
        '
        'Label47
        '
        Me.Label47.Height = 0.1771654!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 0.02755906!
        Me.Label47.Name = "Label47"
        Me.Label47.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label47.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label47.Text = "担当者氏名"
        Me.Label47.Top = 3.174016!
        Me.Label47.Width = 1.417323!
        '
        'Label48
        '
        Me.Label48.Height = 0.1771654!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 0.02755906!
        Me.Label48.Name = "Label48"
        Me.Label48.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label48.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label48.Text = "担当者氏名(ローマ字)"
        Me.Label48.Top = 3.381103!
        Me.Label48.Width = 1.417323!
        '
        'Label49
        '
        Me.Label49.Height = 0.1771654!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 0.02755906!
        Me.Label49.Name = "Label49"
        Me.Label49.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label49.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label49.Text = "携帯電話番号"
        Me.Label49.Top = 3.598425!
        Me.Label49.Width = 1.417323!
        '
        'Label50
        '
        Me.Label50.Height = 0.1771654!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 0.02755906!
        Me.Label50.Name = "Label50"
        Me.Label50.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label50.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label50.Text = "携帯アドレス"
        Me.Label50.Top = 3.805512!
        Me.Label50.Width = 1.417323!
        '
        'Label51
        '
        Me.Label51.Height = 0.1771654!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 3.800394!
        Me.Label51.Name = "Label51"
        Me.Label51.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label51.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label51.Text = "オフィス電話番号"
        Me.Label51.Top = 3.598425!
        Me.Label51.Width = 1.417323!
        '
        'Label52
        '
        Me.Label52.Height = 0.1771654!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 3.800394!
        Me.Label52.Name = "Label52"
        Me.Label52.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label52.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label52.Text = "EMailアドレス"
        Me.Label52.Top = 3.805512!
        Me.Label52.Width = 1.417323!
        '
        'BU
        '
        Me.BU.CanGrow = False
        Me.BU.DataField = "BU"
        Me.BU.Height = 0.1771654!
        Me.BU.Left = 1.482677!
        Me.BU.Name = "BU"
        Me.BU.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.BU.Text = "BU"
        Me.BU.Top = 2.552756!
        Me.BU.Width = 3.937008!
        '
        'KIKAKU_TANTO_AREA
        '
        Me.KIKAKU_TANTO_AREA.CanGrow = False
        Me.KIKAKU_TANTO_AREA.DataField = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Height = 0.1771654!
        Me.KIKAKU_TANTO_AREA.Left = 1.482677!
        Me.KIKAKU_TANTO_AREA.Name = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_AREA.Text = "KIKAKU_TANTO_AREA"
        Me.KIKAKU_TANTO_AREA.Top = 2.759843!
        Me.KIKAKU_TANTO_AREA.Width = 3.937008!
        '
        'KIKAKU_TANTO_EIGYOSHO
        '
        Me.KIKAKU_TANTO_EIGYOSHO.CanGrow = False
        Me.KIKAKU_TANTO_EIGYOSHO.DataField = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Height = 0.1771654!
        Me.KIKAKU_TANTO_EIGYOSHO.Left = 1.482677!
        Me.KIKAKU_TANTO_EIGYOSHO.Name = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_EIGYOSHO.Text = "KIKAKU_TANTO_EIGYOSHO"
        Me.KIKAKU_TANTO_EIGYOSHO.Top = 2.966929!
        Me.KIKAKU_TANTO_EIGYOSHO.Width = 3.937008!
        '
        'KIKAKU_TANTO_NAME
        '
        Me.KIKAKU_TANTO_NAME.CanGrow = False
        Me.KIKAKU_TANTO_NAME.DataField = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Height = 0.1771654!
        Me.KIKAKU_TANTO_NAME.Left = 1.482677!
        Me.KIKAKU_TANTO_NAME.Name = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_NAME.Text = "KIKAKU_TANTO_NAME"
        Me.KIKAKU_TANTO_NAME.Top = 3.174016!
        Me.KIKAKU_TANTO_NAME.Width = 3.937008!
        '
        'KIKAKU_TANTO_ROMA
        '
        Me.KIKAKU_TANTO_ROMA.CanGrow = False
        Me.KIKAKU_TANTO_ROMA.DataField = "KIKAKU_TANTO_ROMA"
        Me.KIKAKU_TANTO_ROMA.Height = 0.1771654!
        Me.KIKAKU_TANTO_ROMA.Left = 1.482677!
        Me.KIKAKU_TANTO_ROMA.Name = "KIKAKU_TANTO_ROMA"
        Me.KIKAKU_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_ROMA.Text = "KIKAKU_TANTO_ROMA"
        Me.KIKAKU_TANTO_ROMA.Top = 3.381103!
        Me.KIKAKU_TANTO_ROMA.Width = 3.937008!
        '
        'KIKAKU_TANTO_KEITAI
        '
        Me.KIKAKU_TANTO_KEITAI.CanGrow = False
        Me.KIKAKU_TANTO_KEITAI.DataField = "KIKAKU_TANTO_KEITAI"
        Me.KIKAKU_TANTO_KEITAI.Height = 0.1771654!
        Me.KIKAKU_TANTO_KEITAI.Left = 1.482677!
        Me.KIKAKU_TANTO_KEITAI.Name = "KIKAKU_TANTO_KEITAI"
        Me.KIKAKU_TANTO_KEITAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_KEITAI.Text = "KIKAKU_TANTO_KEITAI"
        Me.KIKAKU_TANTO_KEITAI.Top = 3.598425!
        Me.KIKAKU_TANTO_KEITAI.Width = 2.283465!
        '
        'KIKAKU_TANTO_EMAIL_KEITAI
        '
        Me.KIKAKU_TANTO_EMAIL_KEITAI.CanGrow = False
        Me.KIKAKU_TANTO_EMAIL_KEITAI.DataField = "KIKAKU_TANTO_EMAIL_KEITAI"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Height = 0.1771654!
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Left = 1.482677!
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Name = "KIKAKU_TANTO_EMAIL_KEITAI"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Text = "KIKAKU_TANTO_EMAIL_KEITAI"
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Top = 3.805512!
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Width = 2.283465!
        '
        'KIKAKU_TANTO_EMAIL_PC
        '
        Me.KIKAKU_TANTO_EMAIL_PC.CanGrow = False
        Me.KIKAKU_TANTO_EMAIL_PC.DataField = "KIKAKU_TANTO_EMAIL_PC"
        Me.KIKAKU_TANTO_EMAIL_PC.Height = 0.1771654!
        Me.KIKAKU_TANTO_EMAIL_PC.Left = 5.253937!
        Me.KIKAKU_TANTO_EMAIL_PC.Name = "KIKAKU_TANTO_EMAIL_PC"
        Me.KIKAKU_TANTO_EMAIL_PC.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_EMAIL_PC.Text = "KIKAKU_TANTO_EMAIL_PC"
        Me.KIKAKU_TANTO_EMAIL_PC.Top = 3.805512!
        Me.KIKAKU_TANTO_EMAIL_PC.Width = 2.283465!
        '
        'KIKAKU_TANTO_TEL
        '
        Me.KIKAKU_TANTO_TEL.CanGrow = False
        Me.KIKAKU_TANTO_TEL.DataField = "KIKAKU_TANTO_TEL"
        Me.KIKAKU_TANTO_TEL.Height = 0.1771654!
        Me.KIKAKU_TANTO_TEL.Left = 5.253937!
        Me.KIKAKU_TANTO_TEL.Name = "KIKAKU_TANTO_TEL"
        Me.KIKAKU_TANTO_TEL.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KIKAKU_TANTO_TEL.Text = "KIKAKU_TANTO_TEL"
        Me.KIKAKU_TANTO_TEL.Top = 3.598425!
        Me.KIKAKU_TANTO_TEL.Width = 2.283465!
        '
        'Label53
        '
        Me.Label53.Height = 0.1968504!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 0.0!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal"
        Me.Label53.Text = "■ 講演会 手配担当者"
        Me.Label53.Top = 4.053544!
        Me.Label53.Width = 7.086611!
        '
        'Label54
        '
        Me.Label54.Height = 0.1771654!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 0.02755906!
        Me.Label54.Name = "Label54"
        Me.Label54.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label54.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label54.Text = "所属BU"
        Me.Label54.Top = 4.237008!
        Me.Label54.Width = 1.417323!
        '
        'Label55
        '
        Me.Label55.Height = 0.1771654!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 0.02755905!
        Me.Label55.Name = "Label55"
        Me.Label55.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label55.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label55.Text = "所属エリア"
        Me.Label55.Top = 4.444095!
        Me.Label55.Width = 1.417323!
        '
        'Label56
        '
        Me.Label56.Height = 0.1771654!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 0.02755905!
        Me.Label56.Name = "Label56"
        Me.Label56.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label56.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label56.Text = "所属営業所"
        Me.Label56.Top = 4.661417!
        Me.Label56.Width = 1.417323!
        '
        'Label57
        '
        Me.Label57.Height = 0.1771654!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 0.02755905!
        Me.Label57.Name = "Label57"
        Me.Label57.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label57.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label57.Text = "担当者氏名"
        Me.Label57.Top = 4.868504!
        Me.Label57.Width = 1.417323!
        '
        'Label58
        '
        Me.Label58.Height = 0.1771654!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 0.02755905!
        Me.Label58.Name = "Label58"
        Me.Label58.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label58.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label58.Text = "担当者氏名(ローマ字)"
        Me.Label58.Top = 5.075591!
        Me.Label58.Width = 1.417323!
        '
        'Label59
        '
        Me.Label59.Height = 0.1771654!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 0.02755905!
        Me.Label59.Name = "Label59"
        Me.Label59.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label59.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label59.Text = "携帯電話番号"
        Me.Label59.Top = 5.282677!
        Me.Label59.Width = 1.417323!
        '
        'Label60
        '
        Me.Label60.Height = 0.1771654!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 0.02755905!
        Me.Label60.Name = "Label60"
        Me.Label60.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label60.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label60.Text = "携帯アドレス"
        Me.Label60.Top = 5.489764!
        Me.Label60.Width = 1.417323!
        '
        'Label61
        '
        Me.Label61.Height = 0.1771654!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 3.800394!
        Me.Label61.Name = "Label61"
        Me.Label61.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label61.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label61.Text = "オフィス電話番号"
        Me.Label61.Top = 5.282677!
        Me.Label61.Width = 1.417323!
        '
        'Label62
        '
        Me.Label62.Height = 0.1771654!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 3.800394!
        Me.Label62.Name = "Label62"
        Me.Label62.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label62.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label62.Text = "EMailアドレス"
        Me.Label62.Top = 5.489764!
        Me.Label62.Width = 1.417323!
        '
        'TEHAI_TANTO_BU
        '
        Me.TEHAI_TANTO_BU.CanGrow = False
        Me.TEHAI_TANTO_BU.DataField = "TEHAI_TANTO_BU"
        Me.TEHAI_TANTO_BU.Height = 0.1771654!
        Me.TEHAI_TANTO_BU.Left = 1.482677!
        Me.TEHAI_TANTO_BU.Name = "TEHAI_TANTO_BU"
        Me.TEHAI_TANTO_BU.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_BU.Text = "TEHAI_TANTO_BU"
        Me.TEHAI_TANTO_BU.Top = 4.237008!
        Me.TEHAI_TANTO_BU.Width = 3.937008!
        '
        'TEHAI_TANTO_AREA
        '
        Me.TEHAI_TANTO_AREA.CanGrow = False
        Me.TEHAI_TANTO_AREA.DataField = "TEHAI_TANTO_AREA"
        Me.TEHAI_TANTO_AREA.Height = 0.1771654!
        Me.TEHAI_TANTO_AREA.Left = 1.482677!
        Me.TEHAI_TANTO_AREA.Name = "TEHAI_TANTO_AREA"
        Me.TEHAI_TANTO_AREA.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_AREA.Text = "TEHAI_TANTO_AREA"
        Me.TEHAI_TANTO_AREA.Top = 4.444095!
        Me.TEHAI_TANTO_AREA.Width = 3.937008!
        '
        'TEHAI_TANTO_EIGYOSHO
        '
        Me.TEHAI_TANTO_EIGYOSHO.CanGrow = False
        Me.TEHAI_TANTO_EIGYOSHO.DataField = "TEHAI_TANTO_EIGYOSHO"
        Me.TEHAI_TANTO_EIGYOSHO.Height = 0.1771654!
        Me.TEHAI_TANTO_EIGYOSHO.Left = 1.482677!
        Me.TEHAI_TANTO_EIGYOSHO.Name = "TEHAI_TANTO_EIGYOSHO"
        Me.TEHAI_TANTO_EIGYOSHO.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_EIGYOSHO.Text = "TEHAI_TANTO_EIGYOSHO"
        Me.TEHAI_TANTO_EIGYOSHO.Top = 4.661417!
        Me.TEHAI_TANTO_EIGYOSHO.Width = 3.937008!
        '
        'TEHAI_TANTO_NAME
        '
        Me.TEHAI_TANTO_NAME.CanGrow = False
        Me.TEHAI_TANTO_NAME.DataField = "TEHAI_TANTO_NAME"
        Me.TEHAI_TANTO_NAME.Height = 0.1771654!
        Me.TEHAI_TANTO_NAME.Left = 1.482677!
        Me.TEHAI_TANTO_NAME.Name = "TEHAI_TANTO_NAME"
        Me.TEHAI_TANTO_NAME.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_NAME.Text = "TEHAI_TANTO_NAME"
        Me.TEHAI_TANTO_NAME.Top = 4.868504!
        Me.TEHAI_TANTO_NAME.Width = 3.937008!
        '
        'TEHAI_TANTO_ROMA
        '
        Me.TEHAI_TANTO_ROMA.CanGrow = False
        Me.TEHAI_TANTO_ROMA.DataField = "TEHAI_TANTO_ROMA"
        Me.TEHAI_TANTO_ROMA.Height = 0.1771654!
        Me.TEHAI_TANTO_ROMA.Left = 1.482677!
        Me.TEHAI_TANTO_ROMA.Name = "TEHAI_TANTO_ROMA"
        Me.TEHAI_TANTO_ROMA.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_ROMA.Text = "TEHAI_TANTO_ROMA"
        Me.TEHAI_TANTO_ROMA.Top = 5.075591!
        Me.TEHAI_TANTO_ROMA.Width = 3.937008!
        '
        'TEHAI_TANTO_KEITAI
        '
        Me.TEHAI_TANTO_KEITAI.CanGrow = False
        Me.TEHAI_TANTO_KEITAI.DataField = "TEHAI_TANTO_KEITAI"
        Me.TEHAI_TANTO_KEITAI.Height = 0.1771654!
        Me.TEHAI_TANTO_KEITAI.Left = 1.482677!
        Me.TEHAI_TANTO_KEITAI.Name = "TEHAI_TANTO_KEITAI"
        Me.TEHAI_TANTO_KEITAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_KEITAI.Text = "TEHAI_TANTO_KEITAI"
        Me.TEHAI_TANTO_KEITAI.Top = 5.282677!
        Me.TEHAI_TANTO_KEITAI.Width = 2.283465!
        '
        'TEHAI_TANTO_EMAIL_KEITAI
        '
        Me.TEHAI_TANTO_EMAIL_KEITAI.CanGrow = False
        Me.TEHAI_TANTO_EMAIL_KEITAI.DataField = "TEHAI_TANTO_EMAIL_KEITAI"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Height = 0.1771654!
        Me.TEHAI_TANTO_EMAIL_KEITAI.Left = 1.482677!
        Me.TEHAI_TANTO_EMAIL_KEITAI.Name = "TEHAI_TANTO_EMAIL_KEITAI"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Text = "TEHAI_TANTO_EMAIL_KEITAI"
        Me.TEHAI_TANTO_EMAIL_KEITAI.Top = 5.489764!
        Me.TEHAI_TANTO_EMAIL_KEITAI.Width = 2.283465!
        '
        'TEHAI_TANTO_EMAIL_PC
        '
        Me.TEHAI_TANTO_EMAIL_PC.CanGrow = False
        Me.TEHAI_TANTO_EMAIL_PC.DataField = "TEHAI_TANTO_EMAIL_PC"
        Me.TEHAI_TANTO_EMAIL_PC.Height = 0.1771654!
        Me.TEHAI_TANTO_EMAIL_PC.Left = 5.253937!
        Me.TEHAI_TANTO_EMAIL_PC.Name = "TEHAI_TANTO_EMAIL_PC"
        Me.TEHAI_TANTO_EMAIL_PC.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_EMAIL_PC.Text = "TEHAI_TANTO_EMAIL_PC"
        Me.TEHAI_TANTO_EMAIL_PC.Top = 5.489764!
        Me.TEHAI_TANTO_EMAIL_PC.Width = 2.283465!
        '
        'TEHAI_TANTO_TEL
        '
        Me.TEHAI_TANTO_TEL.CanGrow = False
        Me.TEHAI_TANTO_TEL.DataField = "TEHAI_TANTO_TEL"
        Me.TEHAI_TANTO_TEL.Height = 0.1771654!
        Me.TEHAI_TANTO_TEL.Left = 5.253937!
        Me.TEHAI_TANTO_TEL.Name = "TEHAI_TANTO_TEL"
        Me.TEHAI_TANTO_TEL.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.TEHAI_TANTO_TEL.Text = "TEHAI_TANTO_TEL"
        Me.TEHAI_TANTO_TEL.Top = 5.282677!
        Me.TEHAI_TANTO_TEL.Width = 2.283465!
        '
        'Label63
        '
        Me.Label63.Height = 0.1968504!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 0.0!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal"
        Me.Label63.Text = "■ 概要"
        Me.Label63.Top = 5.737796!
        Me.Label63.Width = 7.086611!
        '
        'Label64
        '
        Me.Label64.Height = 0.1771654!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 0.02755906!
        Me.Label64.Name = "Label64"
        Me.Label64.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label64.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label64.Text = "参加予定数"
        Me.Label64.Top = 5.92441!
        Me.Label64.Width = 1.417323!
        '
        'SANKA_YOTEI_CNT_NMBR
        '
        Me.SANKA_YOTEI_CNT_NMBR.CanGrow = False
        Me.SANKA_YOTEI_CNT_NMBR.DataField = "SANKA_YOTEI_CNT_NMBR"
        Me.SANKA_YOTEI_CNT_NMBR.Height = 0.1771654!
        Me.SANKA_YOTEI_CNT_NMBR.Left = 2.388189!
        Me.SANKA_YOTEI_CNT_NMBR.Name = "SANKA_YOTEI_CNT_NMBR"
        Me.SANKA_YOTEI_CNT_NMBR.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.SANKA_YOTEI_CNT_NMBR.Text = "SANKA_YOTEI_CNT_NMBR"
        Me.SANKA_YOTEI_CNT_NMBR.Top = 5.92441!
        Me.SANKA_YOTEI_CNT_NMBR.Width = 0.7874016!
        '
        'Label65
        '
        Me.Label65.Height = 0.1771654!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 0.02755906!
        Me.Label65.Name = "Label65"
        Me.Label65.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label65.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label65.Text = "予算額(課税)"
        Me.Label65.Top = 6.131497!
        Me.Label65.Width = 1.417323!
        '
        'Label66
        '
        Me.Label66.Height = 0.1771654!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 0.02755906!
        Me.Label66.Name = "Label66"
        Me.Label66.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label66.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label66.Text = "慰労会予算(課税)"
        Me.Label66.Top = 6.338583!
        Me.Label66.Width = 1.417323!
        '
        'Label67
        '
        Me.Label67.Height = 0.1771654!
        Me.Label67.HyperLink = Nothing
        Me.Label67.Left = 1.482677!
        Me.Label67.Name = "Label67"
        Me.Label67.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label67.Text = "従業員以外："
        Me.Label67.Top = 5.92441!
        Me.Label67.Width = 0.9055118!
        '
        'SANKA_YOTEI_CNT_MBR
        '
        Me.SANKA_YOTEI_CNT_MBR.CanGrow = False
        Me.SANKA_YOTEI_CNT_MBR.DataField = "SANKA_YOTEI_CNT_MBR"
        Me.SANKA_YOTEI_CNT_MBR.Height = 0.1771654!
        Me.SANKA_YOTEI_CNT_MBR.Left = 3.972441!
        Me.SANKA_YOTEI_CNT_MBR.Name = "SANKA_YOTEI_CNT_MBR"
        Me.SANKA_YOTEI_CNT_MBR.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.SANKA_YOTEI_CNT_MBR.Text = "SANKA_YOTEI_CNT_MBR"
        Me.SANKA_YOTEI_CNT_MBR.Top = 5.92441!
        Me.SANKA_YOTEI_CNT_MBR.Width = 0.7874016!
        '
        'Label68
        '
        Me.Label68.Height = 0.1771654!
        Me.Label68.HyperLink = Nothing
        Me.Label68.Left = 3.371654!
        Me.Label68.Name = "Label68"
        Me.Label68.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; ddo-char-set: 1"
        Me.Label68.Text = "従業員："
        Me.Label68.Top = 5.92441!
        Me.Label68.Width = 0.5905512!
        '
        'Label69
        '
        Me.Label69.Height = 0.1771654!
        Me.Label69.HyperLink = Nothing
        Me.Label69.Left = 5.076772!
        Me.Label69.Name = "Label69"
        Me.Label69.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label69.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label69.Text = "SRM発注区分"
        Me.Label69.Top = 5.92441!
        Me.Label69.Width = 1.023622!
        '
        'SRM_HACYU_KBN
        '
        Me.SRM_HACYU_KBN.CanGrow = False
        Me.SRM_HACYU_KBN.DataField = "SRM_HACYU_KBN"
        Me.SRM_HACYU_KBN.Height = 0.1771654!
        Me.SRM_HACYU_KBN.Left = 6.125591!
        Me.SRM_HACYU_KBN.Name = "SRM_HACYU_KBN"
        Me.SRM_HACYU_KBN.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.SRM_HACYU_KBN.Text = "SRM_HACYU_KBN"
        Me.SRM_HACYU_KBN.Top = 5.92441!
        Me.SRM_HACYU_KBN.Width = 0.8661417!
        '
        'YOSAN_T
        '
        Me.YOSAN_T.CanGrow = False
        Me.YOSAN_T.DataField = "YOSAN_T"
        Me.YOSAN_T.Height = 0.1771654!
        Me.YOSAN_T.Left = 1.482677!
        Me.YOSAN_T.Name = "YOSAN_T"
        Me.YOSAN_T.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.YOSAN_T.Text = "YOSAN_T"
        Me.YOSAN_T.Top = 6.131497!
        Me.YOSAN_T.Width = 1.102362!
        '
        'YOSAN_TF
        '
        Me.YOSAN_TF.CanGrow = False
        Me.YOSAN_TF.DataField = "YOSAN_TF"
        Me.YOSAN_TF.Height = 0.1771654!
        Me.YOSAN_TF.Left = 4.144095!
        Me.YOSAN_TF.Name = "YOSAN_TF"
        Me.YOSAN_TF.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.YOSAN_TF.Text = "YOSAN_TF"
        Me.YOSAN_TF.Top = 6.131497!
        Me.YOSAN_TF.Width = 1.102362!
        '
        'Label70
        '
        Me.Label70.Height = 0.1771654!
        Me.Label70.HyperLink = Nothing
        Me.Label70.Left = 2.696063!
        Me.Label70.Name = "Label70"
        Me.Label70.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label70.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label70.Text = "予算額(非課税)"
        Me.Label70.Top = 6.131497!
        Me.Label70.Width = 1.417323!
        '
        'Label71
        '
        Me.Label71.Height = 0.1771654!
        Me.Label71.HyperLink = Nothing
        Me.Label71.Left = 2.696063!
        Me.Label71.Name = "Label71"
        Me.Label71.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label71.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label71.Text = "意見交換会予算(課税)"
        Me.Label71.Top = 6.338584!
        Me.Label71.Width = 1.417323!
        '
        'YOSAN_TOTAL
        '
        Me.YOSAN_TOTAL.CanGrow = False
        Me.YOSAN_TOTAL.DataField = "YOSAN_TOTAL"
        Me.YOSAN_TOTAL.Height = 0.1771654!
        Me.YOSAN_TOTAL.Left = 6.417717!
        Me.YOSAN_TOTAL.Name = "YOSAN_TOTAL"
        Me.YOSAN_TOTAL.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.YOSAN_TOTAL.Text = "YOSAN_TOTAL"
        Me.YOSAN_TOTAL.Top = 6.131497!
        Me.YOSAN_TOTAL.Width = 1.102362!
        '
        'Label72
        '
        Me.Label72.Height = 0.1771654!
        Me.Label72.HyperLink = Nothing
        Me.Label72.Left = 5.364567!
        Me.Label72.Name = "Label72"
        Me.Label72.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label72.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label72.Text = "予算額合計"
        Me.Label72.Top = 6.131497!
        Me.Label72.Width = 1.023622!
        '
        'IROUKAI_YOSAN_T
        '
        Me.IROUKAI_YOSAN_T.CanGrow = False
        Me.IROUKAI_YOSAN_T.DataField = "IROUKAI_YOSAN_T"
        Me.IROUKAI_YOSAN_T.Height = 0.1771654!
        Me.IROUKAI_YOSAN_T.Left = 1.482677!
        Me.IROUKAI_YOSAN_T.Name = "IROUKAI_YOSAN_T"
        Me.IROUKAI_YOSAN_T.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.IROUKAI_YOSAN_T.Text = "IROUKAI_YOSAN_T"
        Me.IROUKAI_YOSAN_T.Top = 6.338583!
        Me.IROUKAI_YOSAN_T.Width = 1.102362!
        '
        'IKENKOUKAN_YOSAN_T
        '
        Me.IKENKOUKAN_YOSAN_T.CanGrow = False
        Me.IKENKOUKAN_YOSAN_T.DataField = "IKENKOUKAN_YOSAN_T"
        Me.IKENKOUKAN_YOSAN_T.Height = 0.1771654!
        Me.IKENKOUKAN_YOSAN_T.Left = 4.144095!
        Me.IKENKOUKAN_YOSAN_T.Name = "IKENKOUKAN_YOSAN_T"
        Me.IKENKOUKAN_YOSAN_T.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.IKENKOUKAN_YOSAN_T.Text = "IKENKOUKAN_YOSAN_T"
        Me.IKENKOUKAN_YOSAN_T.Top = 6.338584!
        Me.IKENKOUKAN_YOSAN_T.Width = 1.102362!
        '
        'Label73
        '
        Me.Label73.Height = 0.1968504!
        Me.Label73.HyperLink = Nothing
        Me.Label73.Left = 0.0!
        Me.Label73.Name = "Label73"
        Me.Label73.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal"
        Me.Label73.Text = "■ 会場"
        Me.Label73.Top = 6.596851!
        Me.Label73.Width = 7.086611!
        '
        'Label74
        '
        Me.Label74.Height = 0.1771654!
        Me.Label74.HyperLink = Nothing
        Me.Label74.Left = 0.8015749!
        Me.Label74.Name = "Label74"
        Me.Label74.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label74.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label74.Text = "都道府県"
        Me.Label74.Top = 6.803937!
        Me.Label74.Width = 1.023622!
        '
        'Label75
        '
        Me.Label75.Height = 0.472441!
        Me.Label75.HyperLink = Nothing
        Me.Label75.Left = 0.8015749!
        Me.Label75.Name = "Label75"
        Me.Label75.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label75.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label75.Text = "備考欄"
        Me.Label75.Top = 7.011024!
        Me.Label75.Width = 1.023622!
        '
        'KAISAI_KIBOU_ADDRESS1
        '
        Me.KAISAI_KIBOU_ADDRESS1.CanGrow = False
        Me.KAISAI_KIBOU_ADDRESS1.DataField = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Height = 0.1771654!
        Me.KAISAI_KIBOU_ADDRESS1.Left = 1.859055!
        Me.KAISAI_KIBOU_ADDRESS1.Name = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KAISAI_KIBOU_ADDRESS1.Text = "KAISAI_KIBOU_ADDRESS1"
        Me.KAISAI_KIBOU_ADDRESS1.Top = 6.803937!
        Me.KAISAI_KIBOU_ADDRESS1.Width = 0.7086614!
        '
        'Label79
        '
        Me.Label79.Height = 0.1771654!
        Me.Label79.HyperLink = Nothing
        Me.Label79.Left = 2.799213!
        Me.Label79.Name = "Label79"
        Me.Label79.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label79.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label79.Text = "市町村"
        Me.Label79.Top = 6.803937!
        Me.Label79.Width = 0.7086614!
        '
        'KAISAI_KIBOU_ADDRESS2
        '
        Me.KAISAI_KIBOU_ADDRESS2.CanGrow = False
        Me.KAISAI_KIBOU_ADDRESS2.DataField = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Height = 0.1771654!
        Me.KAISAI_KIBOU_ADDRESS2.Left = 3.538583!
        Me.KAISAI_KIBOU_ADDRESS2.Name = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KAISAI_KIBOU_ADDRESS2.Text = "KAISAI_KIBOU_ADDRESS2"
        Me.KAISAI_KIBOU_ADDRESS2.Top = 6.803937!
        Me.KAISAI_KIBOU_ADDRESS2.Width = 3.992913!
        '
        'Label77
        '
        Me.Label77.Height = 0.6795284!
        Me.Label77.HyperLink = Nothing
        Me.Label77.Left = 0.02755906!
        Me.Label77.Name = "Label77"
        Me.Label77.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label77.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label77.Text = "開催希望地"
        Me.Label77.Top = 6.803937!
        Me.Label77.Width = 0.7401575!
        '
        'KAISAI_KIBOU_NOTE
        '
        Me.KAISAI_KIBOU_NOTE.CanGrow = False
        Me.KAISAI_KIBOU_NOTE.DataField = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Height = 0.472441!
        Me.KAISAI_KIBOU_NOTE.Left = 1.859055!
        Me.KAISAI_KIBOU_NOTE.Name = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Padding = New DataDynamics.ActiveReports.PaddingEx(0, 2, 0, 0)
        Me.KAISAI_KIBOU_NOTE.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; ddo-char-set: 1"
        Me.KAISAI_KIBOU_NOTE.Text = "KAISAI_KIBOU_NOTE"
        Me.KAISAI_KIBOU_NOTE.Top = 7.011024!
        Me.KAISAI_KIBOU_NOTE.Width = 5.672441!
        '
        'Label78
        '
        Me.Label78.Height = 1.459843!
        Me.Label78.HyperLink = Nothing
        Me.Label78.Left = 0.02755906!
        Me.Label78.Name = "Label78"
        Me.Label78.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label78.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label78.Text = "必要会場"
        Me.Label78.Top = 7.512599!
        Me.Label78.Width = 0.7401577!
        '
        'Label83
        '
        Me.Label83.Height = 0.1771654!
        Me.Label83.HyperLink = Nothing
        Me.Label83.Left = 0.8015749!
        Me.Label83.Name = "Label83"
        Me.Label83.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label83.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label83.Text = "意見交換会会場"
        Me.Label83.Top = 7.962982!
        Me.Label83.Width = 1.023622!
        '
        'Label76
        '
        Me.Label76.Height = 0.1771654!
        Me.Label76.HyperLink = Nothing
        Me.Label76.Left = 0.8015749!
        Me.Label76.Name = "Label76"
        Me.Label76.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label76.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label76.Text = "慰労会会場"
        Me.Label76.Top = 8.170067!
        Me.Label76.Width = 1.023622!
        '
        'Label84
        '
        Me.Label84.Height = 0.1771654!
        Me.Label84.HyperLink = Nothing
        Me.Label84.Left = 0.8015749!
        Me.Label84.Name = "Label84"
        Me.Label84.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label84.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label84.Text = "講師控室"
        Me.Label84.Top = 8.370867!
        Me.Label84.Width = 1.023622!
        '
        'Label85
        '
        Me.Label85.Height = 0.1771654!
        Me.Label85.HyperLink = Nothing
        Me.Label85.Left = 0.8015749!
        Me.Label85.Name = "Label85"
        Me.Label85.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label85.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label85.Text = "社員控室"
        Me.Label85.Top = 8.588177!
        Me.Label85.Width = 1.023622!
        '
        'Label86
        '
        Me.Label86.Height = 0.1771654!
        Me.Label86.HyperLink = Nothing
        Me.Label86.Left = 0.8015749!
        Me.Label86.Name = "Label86"
        Me.Label86.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label86.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label86.Text = "世話人会会場"
        Me.Label86.Top = 8.795263!
        Me.Label86.Width = 1.023622!
        '
        'Label15
        '
        Me.Label15.Height = 0.1771654!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.8015749!
        Me.Label15.Name = "Label15"
        Me.Label15.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label15.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label15.Text = "会合"
        Me.Label15.Top = 7.512599!
        Me.Label15.Width = 1.023622!
        '
        'Label19
        '
        Me.Label19.Height = 0.1771654!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 1.859055!
        Me.Label19.Name = "Label19"
        Me.Label19.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label19.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label19.Text = "開始時間"
        Me.Label19.Top = 7.512599!
        Me.Label19.Width = 0.7874016!
        '
        'Label25
        '
        Me.Label25.Height = 0.1771654!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 3.302756!
        Me.Label25.Name = "Label25"
        Me.Label25.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label25.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label25.Text = "終了時間"
        Me.Label25.Top = 7.512599!
        Me.Label25.Width = 0.7874016!
        '
        'Label87
        '
        Me.Label87.Height = 0.1771654!
        Me.Label87.HyperLink = Nothing
        Me.Label87.Left = 5.186221!
        Me.Label87.Name = "Label87"
        Me.Label87.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label87.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label87.Text = "レイアウト"
        Me.Label87.Top = 7.512599!
        Me.Label87.Width = 0.7874016!
        '
        'KOUEN_TIME1
        '
        Me.KOUEN_TIME1.CanGrow = False
        Me.KOUEN_TIME1.DataField = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Height = 0.1771654!
        Me.KOUEN_TIME1.Left = 2.676378!
        Me.KOUEN_TIME1.Name = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KOUEN_TIME1.Text = "KOUEN_TIME1"
        Me.KOUEN_TIME1.Top = 7.512599!
        Me.KOUEN_TIME1.Width = 0.472441!
        '
        'KOUEN_TIME2
        '
        Me.KOUEN_TIME2.CanGrow = False
        Me.KOUEN_TIME2.DataField = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Height = 0.1771654!
        Me.KOUEN_TIME2.Left = 4.123622!
        Me.KOUEN_TIME2.Name = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KOUEN_TIME2.Text = "KOUEN_TIME2"
        Me.KOUEN_TIME2.Top = 7.512599!
        Me.KOUEN_TIME2.Width = 0.472441!
        '
        'KOUEN_KAIJO_LAYOUT
        '
        Me.KOUEN_KAIJO_LAYOUT.CanGrow = False
        Me.KOUEN_KAIJO_LAYOUT.DataField = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Height = 0.1771654!
        Me.KOUEN_KAIJO_LAYOUT.Left = 6.017717!
        Me.KOUEN_KAIJO_LAYOUT.Name = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KOUEN_KAIJO_LAYOUT.Text = "KOUEN_KAIJO_LAYOUT"
        Me.KOUEN_KAIJO_LAYOUT.Top = 7.512599!
        Me.KOUEN_KAIJO_LAYOUT.Width = 0.984252!
        '
        'Label20
        '
        Me.Label20.Height = 0.1771654!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 1.859055!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: " & _
            "center; vertical-align: middle; ddo-char-set: 1"
        Me.Label20.Text = "要"
        Me.Label20.Top = 7.745668!
        Me.Label20.Width = 0.472441!
        '
        'Label21
        '
        Me.Label21.Height = 0.1771654!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 2.351969!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: " & _
            "center; vertical-align: middle; ddo-char-set: 1"
        Me.Label21.Text = "不要"
        Me.Label21.Top = 7.745668!
        Me.Label21.Width = 0.472441!
        '
        'IKENKOUKAN_KAIJO_TEHAI_Yes
        '
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.CanGrow = False
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Height = 0.1771654!
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Left = 1.859055!
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Name = "IKENKOUKAN_KAIJO_TEHAI_Yes"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Text = "●"
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Top = 7.962982!
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Width = 0.472441!
        '
        'IROUKAI_KAIJO_TEHAI_Yes
        '
        Me.IROUKAI_KAIJO_TEHAI_Yes.CanGrow = False
        Me.IROUKAI_KAIJO_TEHAI_Yes.Height = 0.1771654!
        Me.IROUKAI_KAIJO_TEHAI_Yes.Left = 1.859055!
        Me.IROUKAI_KAIJO_TEHAI_Yes.Name = "IROUKAI_KAIJO_TEHAI_Yes"
        Me.IROUKAI_KAIJO_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.IROUKAI_KAIJO_TEHAI_Yes.Text = Nothing
        Me.IROUKAI_KAIJO_TEHAI_Yes.Top = 8.170067!
        Me.IROUKAI_KAIJO_TEHAI_Yes.Width = 0.472441!
        '
        'KOUSHI_ROOM_TEHAI_Yes
        '
        Me.KOUSHI_ROOM_TEHAI_Yes.CanGrow = False
        Me.KOUSHI_ROOM_TEHAI_Yes.Height = 0.1771654!
        Me.KOUSHI_ROOM_TEHAI_Yes.Left = 1.859055!
        Me.KOUSHI_ROOM_TEHAI_Yes.Name = "KOUSHI_ROOM_TEHAI_Yes"
        Me.KOUSHI_ROOM_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.KOUSHI_ROOM_TEHAI_Yes.Text = Nothing
        Me.KOUSHI_ROOM_TEHAI_Yes.Top = 8.370867!
        Me.KOUSHI_ROOM_TEHAI_Yes.Width = 0.472441!
        '
        'SHAIN_ROOM_TEHAI_Yes
        '
        Me.SHAIN_ROOM_TEHAI_Yes.CanGrow = False
        Me.SHAIN_ROOM_TEHAI_Yes.Height = 0.1771654!
        Me.SHAIN_ROOM_TEHAI_Yes.Left = 1.859055!
        Me.SHAIN_ROOM_TEHAI_Yes.Name = "SHAIN_ROOM_TEHAI_Yes"
        Me.SHAIN_ROOM_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.SHAIN_ROOM_TEHAI_Yes.Text = Nothing
        Me.SHAIN_ROOM_TEHAI_Yes.Top = 8.588177!
        Me.SHAIN_ROOM_TEHAI_Yes.Width = 0.472441!
        '
        'MANAGER_KAIJO_TEHAI_Yes
        '
        Me.MANAGER_KAIJO_TEHAI_Yes.CanGrow = False
        Me.MANAGER_KAIJO_TEHAI_Yes.Height = 0.1771654!
        Me.MANAGER_KAIJO_TEHAI_Yes.Left = 1.859055!
        Me.MANAGER_KAIJO_TEHAI_Yes.Name = "MANAGER_KAIJO_TEHAI_Yes"
        Me.MANAGER_KAIJO_TEHAI_Yes.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.MANAGER_KAIJO_TEHAI_Yes.Text = Nothing
        Me.MANAGER_KAIJO_TEHAI_Yes.Top = 8.795263!
        Me.MANAGER_KAIJO_TEHAI_Yes.Width = 0.472441!
        '
        'IKENKOUKAN_KAIJO_TEHAI_No
        '
        Me.IKENKOUKAN_KAIJO_TEHAI_No.CanGrow = False
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Height = 0.1771654!
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Left = 2.351969!
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Name = "IKENKOUKAN_KAIJO_TEHAI_No"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Text = "○"
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Top = 7.962982!
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Width = 0.472441!
        '
        'IROUKAI_KAIJO_TEHAI_No
        '
        Me.IROUKAI_KAIJO_TEHAI_No.CanGrow = False
        Me.IROUKAI_KAIJO_TEHAI_No.Height = 0.1771654!
        Me.IROUKAI_KAIJO_TEHAI_No.Left = 2.351969!
        Me.IROUKAI_KAIJO_TEHAI_No.Name = "IROUKAI_KAIJO_TEHAI_No"
        Me.IROUKAI_KAIJO_TEHAI_No.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.IROUKAI_KAIJO_TEHAI_No.Text = Nothing
        Me.IROUKAI_KAIJO_TEHAI_No.Top = 8.170063!
        Me.IROUKAI_KAIJO_TEHAI_No.Width = 0.472441!
        '
        'KOUSHI_ROOM_TEHAI_No
        '
        Me.KOUSHI_ROOM_TEHAI_No.CanGrow = False
        Me.KOUSHI_ROOM_TEHAI_No.Height = 0.1771654!
        Me.KOUSHI_ROOM_TEHAI_No.Left = 2.351969!
        Me.KOUSHI_ROOM_TEHAI_No.Name = "KOUSHI_ROOM_TEHAI_No"
        Me.KOUSHI_ROOM_TEHAI_No.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.KOUSHI_ROOM_TEHAI_No.Text = Nothing
        Me.KOUSHI_ROOM_TEHAI_No.Top = 8.370867!
        Me.KOUSHI_ROOM_TEHAI_No.Width = 0.472441!
        '
        'SHAIN_ROOM_TEHAI_No
        '
        Me.SHAIN_ROOM_TEHAI_No.CanGrow = False
        Me.SHAIN_ROOM_TEHAI_No.Height = 0.1771654!
        Me.SHAIN_ROOM_TEHAI_No.Left = 2.351969!
        Me.SHAIN_ROOM_TEHAI_No.Name = "SHAIN_ROOM_TEHAI_No"
        Me.SHAIN_ROOM_TEHAI_No.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.SHAIN_ROOM_TEHAI_No.Text = Nothing
        Me.SHAIN_ROOM_TEHAI_No.Top = 8.588173!
        Me.SHAIN_ROOM_TEHAI_No.Width = 0.472441!
        '
        'MANAGER_KAIJO_TEHAI_No
        '
        Me.MANAGER_KAIJO_TEHAI_No.CanGrow = False
        Me.MANAGER_KAIJO_TEHAI_No.Height = 0.1771654!
        Me.MANAGER_KAIJO_TEHAI_No.Left = 2.351969!
        Me.MANAGER_KAIJO_TEHAI_No.Name = "MANAGER_KAIJO_TEHAI_No"
        Me.MANAGER_KAIJO_TEHAI_No.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.MANAGER_KAIJO_TEHAI_No.Text = Nothing
        Me.MANAGER_KAIJO_TEHAI_No.Top = 8.795263!
        Me.MANAGER_KAIJO_TEHAI_No.Width = 0.472441!
        '
        'Label23
        '
        Me.Label23.Height = 0.1771654!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 2.934252!
        Me.Label23.Name = "Label23"
        Me.Label23.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label23.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label23.Text = "参加予定者数"
        Me.Label23.Top = 8.170067!
        Me.Label23.Width = 1.488189!
        '
        'Label24
        '
        Me.Label24.Height = 0.1771654!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 2.934252!
        Me.Label24.Name = "Label24"
        Me.Label24.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label24.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label24.Text = "時間(From)"
        Me.Label24.Top = 8.370867!
        Me.Label24.Width = 1.488189!
        '
        'Label26
        '
        Me.Label26.Height = 0.1771654!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 2.934252!
        Me.Label26.Name = "Label26"
        Me.Label26.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label26.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label26.Text = "人数"
        Me.Label26.Top = 8.588177!
        Me.Label26.Width = 1.488189!
        '
        'Label27
        '
        Me.Label27.Height = 0.1771654!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 2.934252!
        Me.Label27.Name = "Label27"
        Me.Label27.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label27.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label27.Text = "世話人控室 時間(From)"
        Me.Label27.Top = 8.795263!
        Me.Label27.Width = 1.488189!
        '
        'Label28
        '
        Me.Label28.Height = 0.1771654!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 5.368111!
        Me.Label28.Name = "Label28"
        Me.Label28.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label28.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label28.Text = "人数"
        Me.Label28.Top = 8.370867!
        Me.Label28.Width = 1.181102!
        '
        'Label29
        '
        Me.Label29.Height = 0.1771654!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.368111!
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label29.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-ali" & _
            "gn: middle; ddo-char-set: 1"
        Me.Label29.Text = "世話人控室 人数"
        Me.Label29.Top = 8.795263!
        Me.Label29.Width = 1.181102!
        '
        'IROUKAI_SANKA_YOTEI_CNT
        '
        Me.IROUKAI_SANKA_YOTEI_CNT.CanGrow = False
        Me.IROUKAI_SANKA_YOTEI_CNT.DataField = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Height = 0.1771654!
        Me.IROUKAI_SANKA_YOTEI_CNT.Left = 4.453937!
        Me.IROUKAI_SANKA_YOTEI_CNT.Name = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = "IROUKAI_SANKA_YOTEI_CNT"
        Me.IROUKAI_SANKA_YOTEI_CNT.Top = 8.170067!
        Me.IROUKAI_SANKA_YOTEI_CNT.Width = 0.7874016!
        '
        'KOUSHI_ROOM_FROM
        '
        Me.KOUSHI_ROOM_FROM.CanGrow = False
        Me.KOUSHI_ROOM_FROM.DataField = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Height = 0.1771654!
        Me.KOUSHI_ROOM_FROM.Left = 4.453937!
        Me.KOUSHI_ROOM_FROM.Name = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KOUSHI_ROOM_FROM.Text = "KOUSHI_ROOM_FROM"
        Me.KOUSHI_ROOM_FROM.Top = 8.370867!
        Me.KOUSHI_ROOM_FROM.Width = 0.7874016!
        '
        'SHAIN_ROOM_CNT
        '
        Me.SHAIN_ROOM_CNT.CanGrow = False
        Me.SHAIN_ROOM_CNT.DataField = "SHAIN_ROOM_CNT"
        Me.SHAIN_ROOM_CNT.Height = 0.1771654!
        Me.SHAIN_ROOM_CNT.Left = 4.453937!
        Me.SHAIN_ROOM_CNT.Name = "SHAIN_ROOM_CNT"
        Me.SHAIN_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.SHAIN_ROOM_CNT.Text = "SHAIN_ROOM_CNT"
        Me.SHAIN_ROOM_CNT.Top = 8.588177!
        Me.SHAIN_ROOM_CNT.Width = 0.7874016!
        '
        'MANAGER_ROOM_FROM
        '
        Me.MANAGER_ROOM_FROM.CanGrow = False
        Me.MANAGER_ROOM_FROM.DataField = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Height = 0.1771654!
        Me.MANAGER_ROOM_FROM.Left = 4.453937!
        Me.MANAGER_ROOM_FROM.Name = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.MANAGER_ROOM_FROM.Text = "MANAGER_ROOM_FROM"
        Me.MANAGER_ROOM_FROM.Top = 8.795263!
        Me.MANAGER_ROOM_FROM.Width = 0.7874016!
        '
        'KOUSHI_ROOM_CNT
        '
        Me.KOUSHI_ROOM_CNT.CanGrow = False
        Me.KOUSHI_ROOM_CNT.DataField = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Height = 0.1771654!
        Me.KOUSHI_ROOM_CNT.Left = 6.577953!
        Me.KOUSHI_ROOM_CNT.Name = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.KOUSHI_ROOM_CNT.Text = "KOUSHI_ROOM_CNT"
        Me.KOUSHI_ROOM_CNT.Top = 8.370867!
        Me.KOUSHI_ROOM_CNT.Width = 0.7874014!
        '
        'MANAGER_ROOM_CNT
        '
        Me.MANAGER_ROOM_CNT.CanGrow = False
        Me.MANAGER_ROOM_CNT.DataField = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Height = 0.1771654!
        Me.MANAGER_ROOM_CNT.Left = 6.577953!
        Me.MANAGER_ROOM_CNT.Name = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.MANAGER_ROOM_CNT.Text = "MANAGER_ROOM_CNT"
        Me.MANAGER_ROOM_CNT.Top = 8.795263!
        Me.MANAGER_ROOM_CNT.Width = 0.7874014!
        '
        'Label30
        '
        Me.Label30.Height = 0.1968504!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.0!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: normal"
        Me.Label30.Text = "■ 宿泊・交通・その他"
        Me.Label30.Top = 9.043307!
        Me.Label30.Width = 7.086611!
        '
        'Label31
        '
        Me.Label31.Height = 0.1771654!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.02755906!
        Me.Label31.Name = "Label31"
        Me.Label31.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label31.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label31.Text = "宿泊希望室数"
        Me.Label31.Top = 9.250396!
        Me.Label31.Width = 1.104725!
        '
        'REQ_ROOM_CNT
        '
        Me.REQ_ROOM_CNT.CanGrow = False
        Me.REQ_ROOM_CNT.DataField = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Height = 0.1771654!
        Me.REQ_ROOM_CNT.Left = 1.165354!
        Me.REQ_ROOM_CNT.Name = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.REQ_ROOM_CNT.Text = "REQ_ROOM_CNT"
        Me.REQ_ROOM_CNT.Top = 9.250396!
        Me.REQ_ROOM_CNT.Width = 0.7874014!
        '
        'Label32
        '
        Me.Label32.Height = 0.1771654!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.02755906!
        Me.Label32.Name = "Label32"
        Me.Label32.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label32.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label32.Text = "宿泊希望日"
        Me.Label32.Top = 9.457482!
        Me.Label32.Width = 1.104725!
        '
        'REQ_STAY_DATE
        '
        Me.REQ_STAY_DATE.CanGrow = False
        Me.REQ_STAY_DATE.DataField = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Height = 0.1771654!
        Me.REQ_STAY_DATE.Left = 1.165354!
        Me.REQ_STAY_DATE.Name = "REQ_STAY_DATE"
        Me.REQ_STAY_DATE.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.REQ_STAY_DATE.Text = "2013年12月31日(月)"
        Me.REQ_STAY_DATE.Top = 9.457482!
        Me.REQ_STAY_DATE.Width = 1.338583!
        '
        'REQ_KOTSU_CNT
        '
        Me.REQ_KOTSU_CNT.CanGrow = False
        Me.REQ_KOTSU_CNT.DataField = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Height = 0.1771654!
        Me.REQ_KOTSU_CNT.Left = 4.4!
        Me.REQ_KOTSU_CNT.Name = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.REQ_KOTSU_CNT.Text = "REQ_KOTSU_CNT"
        Me.REQ_KOTSU_CNT.Top = 9.45748!
        Me.REQ_KOTSU_CNT.Width = 0.7086614!
        '
        'Label82
        '
        Me.Label82.Height = 0.1771654!
        Me.Label82.HyperLink = Nothing
        Me.Label82.Left = 2.655118!
        Me.Label82.Name = "Label82"
        Me.Label82.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label82.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label82.Text = "交通手配予定人数(JR/AIR)"
        Me.Label82.Top = 9.45748!
        Me.Label82.Width = 1.712598!
        '
        'REQ_TAXI_CNT
        '
        Me.REQ_TAXI_CNT.CanGrow = False
        Me.REQ_TAXI_CNT.DataField = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Height = 0.1771654!
        Me.REQ_TAXI_CNT.Left = 6.694095!
        Me.REQ_TAXI_CNT.Name = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align: middle; white-space: nowr" & _
            "ap; ddo-char-set: 1"
        Me.REQ_TAXI_CNT.Text = "REQ_TAXI_CNT"
        Me.REQ_TAXI_CNT.Top = 9.45748!
        Me.REQ_TAXI_CNT.Width = 0.7086614!
        '
        'Label89
        '
        Me.Label89.Height = 0.1771654!
        Me.Label89.HyperLink = Nothing
        Me.Label89.Left = 5.251969!
        Me.Label89.Name = "Label89"
        Me.Label89.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label89.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label89.Text = "タクシー手配予定人数"
        Me.Label89.Top = 9.45748!
        Me.Label89.Width = 1.417323!
        '
        'Label34
        '
        Me.Label34.Height = 0.472441!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.02755905!
        Me.Label34.Name = "Label34"
        Me.Label34.Padding = New DataDynamics.ActiveReports.PaddingEx(2, 0, 0, 0)
        Me.Label34.Style = "background-color: #C8C8C8; font-family: ＭＳ ゴシック; font-size: 9.5pt; vertical-align" & _
            ": middle; ddo-char-set: 1"
        Me.Label34.Text = "その他備考欄"
        Me.Label34.Top = 9.664569!
        Me.Label34.Width = 1.104725!
        '
        'OTHER_NOTE
        '
        Me.OTHER_NOTE.CanGrow = False
        Me.OTHER_NOTE.DataField = "OTHER_NOTE"
        Me.OTHER_NOTE.Height = 0.472441!
        Me.OTHER_NOTE.Left = 1.165354!
        Me.OTHER_NOTE.Name = "OTHER_NOTE"
        Me.OTHER_NOTE.Padding = New DataDynamics.ActiveReports.PaddingEx(0, 2, 0, 0)
        Me.OTHER_NOTE.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; ddo-char-set: 1"
        Me.OTHER_NOTE.Text = "OTHER_NOTE"
        Me.OTHER_NOTE.Top = 9.664569!
        Me.OTHER_NOTE.Width = 6.366142!
        '
        'IKENKOUKAN_KAIJO_TEHAI
        '
        Me.IKENKOUKAN_KAIJO_TEHAI.CanGrow = False
        Me.IKENKOUKAN_KAIJO_TEHAI.DataField = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI.Height = 0.1771654!
        Me.IKENKOUKAN_KAIJO_TEHAI.Left = 7.869292!
        Me.IKENKOUKAN_KAIJO_TEHAI.Name = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.IKENKOUKAN_KAIJO_TEHAI.Text = "IKENKOUKAN_KAIJO_TEHAI"
        Me.IKENKOUKAN_KAIJO_TEHAI.Top = 7.922835!
        Me.IKENKOUKAN_KAIJO_TEHAI.Visible = False
        Me.IKENKOUKAN_KAIJO_TEHAI.Width = 0.472441!
        '
        'KOUSHI_ROOM_TEHAI
        '
        Me.KOUSHI_ROOM_TEHAI.CanGrow = False
        Me.KOUSHI_ROOM_TEHAI.DataField = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI.Height = 0.1771654!
        Me.KOUSHI_ROOM_TEHAI.Left = 7.869292!
        Me.KOUSHI_ROOM_TEHAI.Name = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.KOUSHI_ROOM_TEHAI.Text = "KOUSHI_ROOM_TEHAI"
        Me.KOUSHI_ROOM_TEHAI.Top = 8.340946!
        Me.KOUSHI_ROOM_TEHAI.Visible = False
        Me.KOUSHI_ROOM_TEHAI.Width = 0.472441!
        '
        'IROUKAI_KAIJO_TEHAI
        '
        Me.IROUKAI_KAIJO_TEHAI.CanGrow = False
        Me.IROUKAI_KAIJO_TEHAI.DataField = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI.Height = 0.1771654!
        Me.IROUKAI_KAIJO_TEHAI.Left = 7.869292!
        Me.IROUKAI_KAIJO_TEHAI.Name = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.IROUKAI_KAIJO_TEHAI.Text = "IROUKAI_KAIJO_TEHAI"
        Me.IROUKAI_KAIJO_TEHAI.Top = 8.129926!
        Me.IROUKAI_KAIJO_TEHAI.Visible = False
        Me.IROUKAI_KAIJO_TEHAI.Width = 0.472441!
        '
        'SHAIN_ROOM_TEHAI
        '
        Me.SHAIN_ROOM_TEHAI.CanGrow = False
        Me.SHAIN_ROOM_TEHAI.DataField = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI.Height = 0.1771654!
        Me.SHAIN_ROOM_TEHAI.Left = 7.869292!
        Me.SHAIN_ROOM_TEHAI.Name = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.SHAIN_ROOM_TEHAI.Text = "SHAIN_ROOM_TEHAI"
        Me.SHAIN_ROOM_TEHAI.Top = 8.54803!
        Me.SHAIN_ROOM_TEHAI.Visible = False
        Me.SHAIN_ROOM_TEHAI.Width = 0.472441!
        '
        'MANAGER_KAIJO_TEHAI
        '
        Me.MANAGER_KAIJO_TEHAI.CanGrow = False
        Me.MANAGER_KAIJO_TEHAI.DataField = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI.Height = 0.1771654!
        Me.MANAGER_KAIJO_TEHAI.Left = 7.869292!
        Me.MANAGER_KAIJO_TEHAI.Name = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI.Style = "font-family: ＭＳ ゴシック; font-size: 9.5pt; text-align: center; vertical-align: middl" & _
            "e; white-space: nowrap; ddo-char-set: 1"
        Me.MANAGER_KAIJO_TEHAI.Text = "MANAGER_KAIJO_TEHAI"
        Me.MANAGER_KAIJO_TEHAI.Top = 8.755119!
        Me.MANAGER_KAIJO_TEHAI.Visible = False
        Me.MANAGER_KAIJO_TEHAI.Width = 0.472441!
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
        Me.PrintWidth = 7.559055!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: ""ＭＳ ゴシック""; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.LOGIN_USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_DATE_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_PRT_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TO_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEIHIN_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERNAL_ORDER_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERNAL_ORDER_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCOUNT_CD_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCOUNT_CD_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZETIA_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KIKAKU_TANTO_TEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_BU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_EMAIL_PC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TANTO_TEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKA_YOTEI_CNT_NMBR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKA_YOTEI_CNT_MBR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRM_HACYU_KBN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOSAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOSAN_TF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YOSAN_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_YOSAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_YOSAN_T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_ADDRESS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_ADDRESS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KAISAI_KIBOU_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_TIME1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_TIME2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUEN_KAIJO_LAYOUT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_KAIJO_TEHAI_Yes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_KAIJO_TEHAI_No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_SANKA_YOTEI_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_ROOM_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_ROOM_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STAY_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_KOTSU_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_CNT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OTHER_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IKENKOUKAN_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUSHI_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IROUKAI_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHAIN_ROOM_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANAGER_KAIJO_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents KAISAI_DATE_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents LabelPage As DataDynamics.ActiveReports.Label
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents Label37 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_PRT_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents SEIHIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents INTERNAL_ORDER_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents INTERNAL_ORDER_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents ACCOUNT_CD_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents ACCOUNT_CD_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label44 As DataDynamics.ActiveReports.Label
    Private WithEvents ZETIA_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents Label46 As DataDynamics.ActiveReports.Label
    Private WithEvents Label47 As DataDynamics.ActiveReports.Label
    Private WithEvents Label48 As DataDynamics.ActiveReports.Label
    Private WithEvents Label49 As DataDynamics.ActiveReports.Label
    Private WithEvents Label50 As DataDynamics.ActiveReports.Label
    Private WithEvents Label51 As DataDynamics.ActiveReports.Label
    Private WithEvents Label52 As DataDynamics.ActiveReports.Label
    Private WithEvents BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EMAIL_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_EMAIL_PC As DataDynamics.ActiveReports.TextBox
    Private WithEvents KIKAKU_TANTO_TEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label53 As DataDynamics.ActiveReports.Label
    Private WithEvents Label54 As DataDynamics.ActiveReports.Label
    Private WithEvents Label55 As DataDynamics.ActiveReports.Label
    Private WithEvents Label56 As DataDynamics.ActiveReports.Label
    Private WithEvents Label57 As DataDynamics.ActiveReports.Label
    Private WithEvents Label58 As DataDynamics.ActiveReports.Label
    Private WithEvents Label59 As DataDynamics.ActiveReports.Label
    Private WithEvents Label60 As DataDynamics.ActiveReports.Label
    Private WithEvents Label61 As DataDynamics.ActiveReports.Label
    Private WithEvents Label62 As DataDynamics.ActiveReports.Label
    Private WithEvents TEHAI_TANTO_BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_EMAIL_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_EMAIL_PC As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TANTO_TEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label63 As DataDynamics.ActiveReports.Label
    Private WithEvents Label64 As DataDynamics.ActiveReports.Label
    Private WithEvents SANKA_YOTEI_CNT_NMBR As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label65 As DataDynamics.ActiveReports.Label
    Private WithEvents Label66 As DataDynamics.ActiveReports.Label
    Private WithEvents Label67 As DataDynamics.ActiveReports.Label
    Private WithEvents SANKA_YOTEI_CNT_MBR As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label68 As DataDynamics.ActiveReports.Label
    Private WithEvents SRM_HACYU_KBN As DataDynamics.ActiveReports.TextBox
    Private WithEvents YOSAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label69 As DataDynamics.ActiveReports.Label
    Private WithEvents YOSAN_TF As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label70 As DataDynamics.ActiveReports.Label
    Private WithEvents Label71 As DataDynamics.ActiveReports.Label
    Private WithEvents YOSAN_TOTAL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label72 As DataDynamics.ActiveReports.Label
    Private WithEvents IROUKAI_YOSAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents IKENKOUKAN_YOSAN_T As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label73 As DataDynamics.ActiveReports.Label
    Private WithEvents Label74 As DataDynamics.ActiveReports.Label
    Private WithEvents Label75 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_KIBOU_ADDRESS1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label79 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_KIBOU_ADDRESS2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label77 As DataDynamics.ActiveReports.Label
    Private WithEvents KAISAI_KIBOU_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label78 As DataDynamics.ActiveReports.Label
    Private WithEvents Label83 As DataDynamics.ActiveReports.Label
    Private WithEvents Label76 As DataDynamics.ActiveReports.Label
    Private WithEvents Label84 As DataDynamics.ActiveReports.Label
    Private WithEvents Label85 As DataDynamics.ActiveReports.Label
    Private WithEvents Label86 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label87 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUEN_TIME1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUEN_TIME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUEN_KAIJO_LAYOUT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents IKENKOUKAN_KAIJO_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_KAIJO_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_KAIJO_TEHAI_Yes As DataDynamics.ActiveReports.TextBox
    Private WithEvents IKENKOUKAN_KAIJO_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_KAIJO_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_KAIJO_TEHAI_No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents IROUKAI_SANKA_YOTEI_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_FROM As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_ROOM_FROM As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_ROOM_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_STAY_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_KOTSU_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label82 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_CNT As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label89 As DataDynamics.ActiveReports.Label
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents OTHER_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents IKENKOUKAN_KAIJO_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents KOUSHI_ROOM_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents IROUKAI_KAIJO_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHAIN_ROOM_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MANAGER_KAIJO_TEHAI As DataDynamics.ActiveReports.TextBox
End Class
