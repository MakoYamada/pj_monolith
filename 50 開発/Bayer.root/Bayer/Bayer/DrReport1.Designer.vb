<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrReport1 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrReport1))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Shape3 = New DataDynamics.ActiveReports.Shape
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.Label35 = New DataDynamics.ActiveReports.Label
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.Label37 = New DataDynamics.ActiveReports.Label
        Me.Label38 = New DataDynamics.ActiveReports.Label
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.Label44 = New DataDynamics.ActiveReports.Label
        Me.Label45 = New DataDynamics.ActiveReports.Label
        Me.Label46 = New DataDynamics.ActiveReports.Label
        Me.Label47 = New DataDynamics.ActiveReports.Label
        Me.Label48 = New DataDynamics.ActiveReports.Label
        Me.Label49 = New DataDynamics.ActiveReports.Label
        Me.Label50 = New DataDynamics.ActiveReports.Label
        Me.Label51 = New DataDynamics.ActiveReports.Label
        Me.Label52 = New DataDynamics.ActiveReports.Label
        Me.Label53 = New DataDynamics.ActiveReports.Label
        Me.Label54 = New DataDynamics.ActiveReports.Label
        Me.Label56 = New DataDynamics.ActiveReports.Label
        Me.Label57 = New DataDynamics.ActiveReports.Label
        Me.Label58 = New DataDynamics.ActiveReports.Label
        Me.Label59 = New DataDynamics.ActiveReports.Label
        Me.Label60 = New DataDynamics.ActiveReports.Label
        Me.Label61 = New DataDynamics.ActiveReports.Label
        Me.Label62 = New DataDynamics.ActiveReports.Label
        Me.Label63 = New DataDynamics.ActiveReports.Label
        Me.Label64 = New DataDynamics.ActiveReports.Label
        Me.Label65 = New DataDynamics.ActiveReports.Label
        Me.Label66 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.SANKASHA_ID = New DataDynamics.ActiveReports.TextBox
        Me.DR_CD = New DataDynamics.ActiveReports.TextBox
        Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.DR_KANA = New DataDynamics.ActiveReports.TextBox
        Me.DR_SHISETSU_CD = New DataDynamics.ActiveReports.TextBox
        Me.DR_SHISETSU_NAME = New DataDynamics.ActiveReports.TextBox
        Me.DR_SHISETSU_ADDRESS = New DataDynamics.ActiveReports.TextBox
        Me.DR_YAKUWARI = New DataDynamics.ActiveReports.TextBox
        Me.DR_SEX = New DataDynamics.ActiveReports.TextBox
        Me.DR_AGE = New DataDynamics.ActiveReports.TextBox
        Me.SHITEIGAI_RIYU = New DataDynamics.ActiveReports.TextBox
        Me.MR_AREA = New DataDynamics.ActiveReports.TextBox
        Me.MR_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
        Me.MR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.MR_ROMA = New DataDynamics.ActiveReports.TextBox
        Me.MR_KANA = New DataDynamics.ActiveReports.TextBox
        Me.MR_EMAIL_PC = New DataDynamics.ActiveReports.TextBox
        Me.MR_EMAIL_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.MR_KEITAI = New DataDynamics.ActiveReports.TextBox
        Me.MR_TEL = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEND_SAKI_FS = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEND_SAKI_OTHER = New DataDynamics.ActiveReports.TextBox
        Me.ACCOUNT_CD = New DataDynamics.ActiveReports.TextBox
        Me.COST_CENTER = New DataDynamics.ActiveReports.TextBox
        Me.INTERNAL_ORDER = New DataDynamics.ActiveReports.TextBox
        Me.ZETIA_CD = New DataDynamics.ActiveReports.TextBox
        Me.SHONIN_NAME = New DataDynamics.ActiveReports.TextBox
        Me.SHONIN_DATE = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_HOTEL = New DataDynamics.ActiveReports.TextBox
        Me.HOTEL_IRAINAIYOU = New DataDynamics.ActiveReports.TextBox
        Me.REQ_HOTEL_DATE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_HAKUSU = New DataDynamics.ActiveReports.TextBox
        Me.REQ_HOTEL_SMOKING = New DataDynamics.ActiveReports.TextBox
        Me.REQ_HOTEL_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_IRAINAIYOU_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_KOTSUKIKAN_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_DATE_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_AIRPORT1_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_AIRPORT2_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TIME1_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TIME2_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_BIN_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_SEAT_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_SEAT_KIBOU1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_IRAINAIYOU_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_KOTSUKIKAN_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_DATE_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_AIRPORT1_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_AIRPORT2_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TIME1_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TIME2_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_BIN_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_SEAT_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_SEAT_KIBOU1 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.Line35 = New DataDynamics.ActiveReports.Line
        Me.Line36 = New DataDynamics.ActiveReports.Line
        Me.Line37 = New DataDynamics.ActiveReports.Line
        Me.Line38 = New DataDynamics.ActiveReports.Line
        Me.Line39 = New DataDynamics.ActiveReports.Line
        Me.Line40 = New DataDynamics.ActiveReports.Line
        Me.Line41 = New DataDynamics.ActiveReports.Line
        Me.Line42 = New DataDynamics.ActiveReports.Line
        Me.Line43 = New DataDynamics.ActiveReports.Line
        Me.Line44 = New DataDynamics.ActiveReports.Line
        Me.Line45 = New DataDynamics.ActiveReports.Line
        Me.Line46 = New DataDynamics.ActiveReports.Line
        Me.Line47 = New DataDynamics.ActiveReports.Line
        Me.Line48 = New DataDynamics.ActiveReports.Line
        Me.Line49 = New DataDynamics.ActiveReports.Line
        Me.Line50 = New DataDynamics.ActiveReports.Line
        Me.Line51 = New DataDynamics.ActiveReports.Line
        Me.Line52 = New DataDynamics.ActiveReports.Line
        Me.Line53 = New DataDynamics.ActiveReports.Line
        Me.Line54 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_KANA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SHISETSU_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SHISETSU_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SHISETSU_ADDRESS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_YAKUWARI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_AGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHITEIGAI_RIYU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_AREA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_EIGYOSHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_ROMA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_KANA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_EMAIL_PC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_KEITAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_TEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEND_SAKI_FS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEND_SAKI_OTHER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCOUNT_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COST_CENTER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERNAL_ORDER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZETIA_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_HOTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HOTEL_IRAINAIYOU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_HOTEL_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_HAKUSU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_HOTEL_SMOKING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_HOTEL_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_IRAINAIYOU_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_KOTSUKIKAN_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_DATE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_AIRPORT1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_AIRPORT2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TIME1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TIME2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_BIN_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_SEAT_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_SEAT_KIBOU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_IRAINAIYOU_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_KOTSUKIKAN_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_DATE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_AIRPORT1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_AIRPORT2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TIME1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TIME2_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_BIN_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_SEAT_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_SEAT_KIBOU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Silver
        Me.Shape1.Height = 0.2740157!
        Me.Shape1.Left = 0.0000004768372!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6409445!
        Me.Shape1.Width = 7.165355!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.217323!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = ""
        Me.Label1.Text = "出力日："
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.5834651!
        '
        'PRINT_DATE
        '
        Me.PRINT_DATE.Height = 0.2!
        Me.PRINT_DATE.Left = 5.800788!
        Me.PRINT_DATE.Name = "PRINT_DATE"
        Me.PRINT_DATE.Style = "white-space: nowrap"
        Me.PRINT_DATE.Text = "1234/56/78 12:34:56"
        Me.PRINT_DATE.Top = 0.0!
        Me.PRINT_DATE.Width = 1.364567!
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.217323!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = ""
        Me.Label2.Text = "出力担当："
        Me.Label2.Top = 0.1999998!
        Me.Label2.Width = 0.7291336!
        '
        'USER_NAME
        '
        Me.USER_NAME.Height = 0.2!
        Me.USER_NAME.Left = 5.946457!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Style = "white-space: nowrap"
        Me.USER_NAME.Text = "1234/56/78 12:34:56"
        Me.USER_NAME.Top = 0.1999998!
        Me.USER_NAME.Width = 1.218898!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0000004768372!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center"
        Me.Label3.Text = "交通宿泊手配依頼"
        Me.Label3.Top = 0.6740155!
        Me.Label3.Width = 7.165355!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.446457!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: right"
        Me.Label4.Text = "(1/4ページ)"
        Me.Label4.Top = 0.4409447!
        Me.Label4.Width = 0.7188978!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape3, Me.Shape2, Me.Label5, Me.KOUENKAI_NAME, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.Label19, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label38, Me.Label39, Me.Label40, Me.Label41, Me.Label42, Me.Label43, Me.Label44, Me.Label45, Me.Label46, Me.Label47, Me.Label48, Me.Label49, Me.Label50, Me.Label51, Me.Label52, Me.Label53, Me.Label54, Me.Label56, Me.Label57, Me.Label58, Me.Label59, Me.Label60, Me.Label61, Me.Label62, Me.Label63, Me.Label64, Me.Label65, Me.Label66, Me.KOUENKAI_NO, Me.REQ_STATUS_TEHAI, Me.TIME_STAMP_BYL, Me.SANKASHA_ID, Me.DR_CD, Me.DR_NAME, Me.DR_KANA, Me.DR_SHISETSU_CD, Me.DR_SHISETSU_NAME, Me.DR_SHISETSU_ADDRESS, Me.DR_YAKUWARI, Me.DR_SEX, Me.DR_AGE, Me.SHITEIGAI_RIYU, Me.MR_AREA, Me.MR_EIGYOSHO, Me.MR_NAME, Me.MR_ROMA, Me.MR_KANA, Me.MR_EMAIL_PC, Me.MR_EMAIL_KEITAI, Me.MR_KEITAI, Me.MR_TEL, Me.MR_SEND_SAKI_FS, Me.MR_SEND_SAKI_OTHER, Me.ACCOUNT_CD, Me.COST_CENTER, Me.INTERNAL_ORDER, Me.ZETIA_CD, Me.SHONIN_NAME, Me.SHONIN_DATE, Me.TEHAI_HOTEL, Me.HOTEL_IRAINAIYOU, Me.REQ_HOTEL_DATE, Me.REQ_HAKUSU, Me.REQ_HOTEL_SMOKING, Me.REQ_HOTEL_NOTE, Me.REQ_O_TEHAI_1, Me.REQ_O_IRAINAIYOU_1, Me.REQ_O_KOTSUKIKAN_1, Me.REQ_O_DATE_1, Me.REQ_O_AIRPORT1_1, Me.REQ_O_AIRPORT2_1, Me.REQ_O_TIME1_1, Me.REQ_O_TIME2_1, Me.REQ_O_BIN_1, Me.REQ_O_SEAT_1, Me.REQ_O_SEAT_KIBOU1, Me.REQ_F_TEHAI_1, Me.REQ_F_IRAINAIYOU_1, Me.REQ_F_KOTSUKIKAN_1, Me.REQ_F_DATE_1, Me.REQ_F_AIRPORT1_1, Me.REQ_F_AIRPORT2_1, Me.REQ_F_TIME1_1, Me.REQ_F_TIME2_1, Me.REQ_F_BIN_1, Me.REQ_F_SEAT_1, Me.REQ_F_SEAT_KIBOU1, Me.Line1, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line34, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line39, Me.Line40, Me.Line41, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line51, Me.Line52, Me.Line53, Me.Line54, Me.Label2, Me.Label1, Me.PRINT_DATE, Me.Shape1, Me.USER_NAME, Me.Label3, Me.Label4})
        Me.Detail.Height = 10.79181!
        Me.Detail.Name = "Detail"
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.Color.Silver
        Me.Shape3.Height = 2.200001!
        Me.Shape3.Left = 3.582677!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 8.608662!
        Me.Shape3.Width = 1.771654!
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.Silver
        Me.Shape2.Height = 9.583071!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 1.208662!
        Me.Shape2.Width = 1.771654!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0000004768372!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
        Me.Label5.Text = "講演会名："
        Me.Label5.Top = 1.008661!
        Me.Label5.Width = 0.8437008!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2!
        Me.KOUENKAI_NAME.Left = 0.8437013!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-weight: bold; white-space: nowrap"
        Me.KOUENKAI_NAME.Text = Nothing
        Me.KOUENKAI_NAME.Top = 1.008661!
        Me.KOUENKAI_NAME.Width = 6.321654!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0000004768372!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label6.Text = "講演会番号"
        Me.Label6.Top = 1.208661!
        Me.Label6.Width = 1.771654!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.0000004768372!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label7.Text = "手配ステータス(依頼)"
        Me.Label7.Top = 1.408661!
        Me.Label7.Width = 1.771654!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0000004768372!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label8.Text = "Timestamp(BYL)"
        Me.Label8.Top = 1.608661!
        Me.Label8.Width = 1.771654!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.0000004768372!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label9.Text = "MTP ID(参加者ID)"
        Me.Label9.Top = 1.808661!
        Me.Label9.Width = 1.771654!
        '
        'Label10
        '
        Me.Label10.Height = 0.2!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0000004768372!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label10.Text = "DRコード"
        Me.Label10.Top = 2.008661!
        Me.Label10.Width = 1.771654!
        '
        'Label11
        '
        Me.Label11.Height = 0.2!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.0000004768372!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label11.Text = "DR氏名"
        Me.Label11.Top = 2.208661!
        Me.Label11.Width = 1.771654!
        '
        'Label12
        '
        Me.Label12.Height = 0.2!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0000004768372!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label12.Text = "DR氏名(半角ｶﾀｶﾅ)"
        Me.Label12.Top = 2.408661!
        Me.Label12.Width = 1.771654!
        '
        'Label13
        '
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0000004768372!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label13.Text = "DCF施設コード"
        Me.Label13.Top = 2.608661!
        Me.Label13.Width = 1.771654!
        '
        'Label14
        '
        Me.Label14.Height = 0.2!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.0000004768372!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label14.Text = "施設名"
        Me.Label14.Top = 2.808661!
        Me.Label14.Width = 1.771654!
        '
        'Label15
        '
        Me.Label15.Height = 0.2!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.0000004768372!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label15.Text = "施設住所"
        Me.Label15.Top = 3.008661!
        Me.Label15.Width = 1.771654!
        '
        'Label16
        '
        Me.Label16.Height = 0.2!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.0000004768372!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label16.Text = "参加者役割"
        Me.Label16.Top = 3.208661!
        Me.Label16.Width = 1.771654!
        '
        'Label17
        '
        Me.Label17.Height = 0.2!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.0000004768372!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label17.Text = "性別"
        Me.Label17.Top = 3.408661!
        Me.Label17.Width = 1.771654!
        '
        'Label18
        '
        Me.Label18.Height = 0.2!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.0000004768372!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label18.Text = "航空搭乗者年齢(年齢)"
        Me.Label18.Top = 3.60866!
        Me.Label18.Width = 1.771654!
        '
        'Label19
        '
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.0000004768372!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label19.Text = "指定外申請理由(依頼)"
        Me.Label19.Top = 3.80866!
        Me.Label19.Width = 1.771654!
        '
        'Label21
        '
        Me.Label21.Height = 0.2!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.0000004768372!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label21.Text = "所属エリア(担当MR)"
        Me.Label21.Top = 4.008661!
        Me.Label21.Width = 1.771654!
        '
        'Label22
        '
        Me.Label22.Height = 0.2!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.0000004768372!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label22.Text = "所属営業所(担当MR)"
        Me.Label22.Top = 4.208661!
        Me.Label22.Width = 1.771654!
        '
        'Label23
        '
        Me.Label23.Height = 0.2!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.0000004768372!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label23.Text = "担当者(担当MR)名"
        Me.Label23.Top = 4.408661!
        Me.Label23.Width = 1.771654!
        '
        'Label24
        '
        Me.Label24.Height = 0.2!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.0000004768372!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label24.Text = "担当者名(担当MR)(ローマ字)"
        Me.Label24.Top = 4.608661!
        Me.Label24.Width = 1.771654!
        '
        'Label25
        '
        Me.Label25.Height = 0.2!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.0000004768372!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label25.Text = "担当者名(担当MR)(カナ)"
        Me.Label25.Top = 4.808661!
        Me.Label25.Width = 1.771653!
        '
        'Label26
        '
        Me.Label26.Height = 0.2!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.0000004768372!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label26.Text = "Emailアドレス(担当MR)"
        Me.Label26.Top = 5.008661!
        Me.Label26.Width = 1.771653!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.0000004768372!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label27.Text = "携帯Emailアドレス(担当MR)"
        Me.Label27.Top = 5.208661!
        Me.Label27.Width = 1.771653!
        '
        'Label28
        '
        Me.Label28.Height = 0.2!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 0.0000004768372!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label28.Text = "携帯電話番号(担当MR)"
        Me.Label28.Top = 5.408661!
        Me.Label28.Width = 1.771653!
        '
        'Label29
        '
        Me.Label29.Height = 0.2!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.0000004768372!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: justify; text-justify: distribu" & _
            "te; white-space: nowrap"
        Me.Label29.Text = "オフィスの電話番号(担当MR)"
        Me.Label29.Top = 5.608661!
        Me.Label29.Width = 1.771653!
        '
        'Label30
        '
        Me.Label30.Height = 0.2!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.0000004768372!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label30.Text = "チケット送付先FS"
        Me.Label30.Top = 5.808661!
        Me.Label30.Width = 1.771653!
        '
        'Label31
        '
        Me.Label31.Height = 0.2!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.0000004768372!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label31.Text = "チケット送付先(その他)"
        Me.Label31.Top = 6.008661!
        Me.Label31.Width = 1.771653!
        '
        'Label32
        '
        Me.Label32.Height = 0.2!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.0000004768372!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label32.Text = "Account Code"
        Me.Label32.Top = 6.208662!
        Me.Label32.Width = 1.771653!
        '
        'Label33
        '
        Me.Label33.Height = 0.2!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.0000004768372!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label33.Text = "Cost Center"
        Me.Label33.Top = 6.408661!
        Me.Label33.Width = 1.771653!
        '
        'Label34
        '
        Me.Label34.Height = 0.2!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.0000004768372!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label34.Text = "Internal Order"
        Me.Label34.Top = 6.608661!
        Me.Label34.Width = 1.771653!
        '
        'Label35
        '
        Me.Label35.Height = 0.2!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 0.0000004768372!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label35.Text = "zetia Code"
        Me.Label35.Top = 6.808662!
        Me.Label35.Width = 1.771653!
        '
        'Label36
        '
        Me.Label36.Height = 0.2!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 0.0000004768372!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label36.Text = "最終承認者(氏名)"
        Me.Label36.Top = 7.00866!
        Me.Label36.Width = 1.771653!
        '
        'Label37
        '
        Me.Label37.Height = 0.2!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 0.0000004768372!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label37.Text = "最終承認日"
        Me.Label37.Top = 7.208664!
        Me.Label37.Width = 1.771653!
        '
        'Label38
        '
        Me.Label38.Height = 0.2!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 0.0000004768372!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label38.Text = "宿泊手配"
        Me.Label38.Top = 7.408663!
        Me.Label38.Width = 1.771653!
        '
        'Label39
        '
        Me.Label39.Height = 0.2!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 0.0000004768372!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label39.Text = "宿泊依頼内容"
        Me.Label39.Top = 7.608664!
        Me.Label39.Width = 1.771653!
        '
        'Label40
        '
        Me.Label40.Height = 0.2!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 0.0000004768372!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label40.Text = "宿泊日(依頼)"
        Me.Label40.Top = 7.808664!
        Me.Label40.Width = 1.771653!
        '
        'Label41
        '
        Me.Label41.Height = 0.2!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0.0000004768372!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label41.Text = "泊数(依頼)"
        Me.Label41.Top = 8.008663!
        Me.Label41.Width = 1.771653!
        '
        'Label42
        '
        Me.Label42.Height = 0.2!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 0.0000004768372!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label42.Text = "宿泊ホテル喫煙(依頼)"
        Me.Label42.Top = 8.208666!
        Me.Label42.Width = 1.771653!
        '
        'Label43
        '
        Me.Label43.Height = 0.2!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 0.0000004768372!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label43.Text = "宿泊備考(依頼)"
        Me.Label43.Top = 8.408665!
        Me.Label43.Width = 1.771653!
        '
        'Label44
        '
        Me.Label44.Height = 0.2!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 0.0000004768372!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label44.Text = "往路1：希望する(依頼)"
        Me.Label44.Top = 8.608665!
        Me.Label44.Width = 1.771653!
        '
        'Label45
        '
        Me.Label45.Height = 0.2!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 0.0000004768372!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label45.Text = "往路1：依頼内容(依頼)"
        Me.Label45.Top = 8.808666!
        Me.Label45.Width = 1.771653!
        '
        'Label46
        '
        Me.Label46.Height = 0.2!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.0000004768372!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label46.Text = "往路1：交通機関(依頼)"
        Me.Label46.Top = 9.008663!
        Me.Label46.Width = 1.771653!
        '
        'Label47
        '
        Me.Label47.Height = 0.2!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 0.0000004768372!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label47.Text = "往路1：利用日(依頼)"
        Me.Label47.Top = 9.208662!
        Me.Label47.Width = 1.771653!
        '
        'Label48
        '
        Me.Label48.Height = 0.2!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 0.0000004768372!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label48.Text = "往路1：出発地(依頼)"
        Me.Label48.Top = 9.408663!
        Me.Label48.Width = 1.771653!
        '
        'Label49
        '
        Me.Label49.Height = 0.2!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 0.0000004768372!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label49.Text = "往路1：到着地(依頼)"
        Me.Label49.Top = 9.608662!
        Me.Label49.Width = 1.771653!
        '
        'Label50
        '
        Me.Label50.Height = 0.2!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 0.0000004768372!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label50.Text = "往路1：出発時間(依頼)"
        Me.Label50.Top = 9.808662!
        Me.Label50.Width = 1.771653!
        '
        'Label51
        '
        Me.Label51.Height = 0.2!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 0.0000004768372!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label51.Text = "往路1：到着時間(依頼)"
        Me.Label51.Top = 10.00866!
        Me.Label51.Width = 1.771653!
        '
        'Label52
        '
        Me.Label52.Height = 0.2!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 0.0000004768372!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label52.Text = "往路1：列車名・便名(依頼)"
        Me.Label52.Top = 10.20866!
        Me.Label52.Width = 1.771653!
        '
        'Label53
        '
        Me.Label53.Height = 0.2!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 0.0000004768372!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label53.Text = "往路1：座席区分(依頼)"
        Me.Label53.Top = 10.40866!
        Me.Label53.Width = 1.771653!
        '
        'Label54
        '
        Me.Label54.Height = 0.2!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 0.0000004768372!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label54.Text = "往路1：座席位置(依頼)"
        Me.Label54.Top = 10.60866!
        Me.Label54.Width = 1.771653!
        '
        'Label56
        '
        Me.Label56.Height = 0.2!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 3.582677!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label56.Text = "復路1：希望する(依頼)"
        Me.Label56.Top = 8.608665!
        Me.Label56.Width = 1.771653!
        '
        'Label57
        '
        Me.Label57.Height = 0.2!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 3.582677!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label57.Text = "復路1：依頼内容(依頼)"
        Me.Label57.Top = 8.808664!
        Me.Label57.Width = 1.771653!
        '
        'Label58
        '
        Me.Label58.Height = 0.2!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 3.582677!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label58.Text = "復路1：交通機関(依頼)"
        Me.Label58.Top = 9.008663!
        Me.Label58.Width = 1.771653!
        '
        'Label59
        '
        Me.Label59.Height = 0.2!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 3.582677!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label59.Text = "復路1：利用日(依頼)"
        Me.Label59.Top = 9.208662!
        Me.Label59.Width = 1.771653!
        '
        'Label60
        '
        Me.Label60.Height = 0.2!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 3.582677!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label60.Text = "復路1：出発地(依頼)"
        Me.Label60.Top = 9.408663!
        Me.Label60.Width = 1.771653!
        '
        'Label61
        '
        Me.Label61.Height = 0.2!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 3.582677!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label61.Text = "復路1：到着地(依頼)"
        Me.Label61.Top = 9.608664!
        Me.Label61.Width = 1.771653!
        '
        'Label62
        '
        Me.Label62.Height = 0.2!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 3.582677!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label62.Text = "復路1：出発時間(依頼)"
        Me.Label62.Top = 9.808662!
        Me.Label62.Width = 1.771653!
        '
        'Label63
        '
        Me.Label63.Height = 0.2!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 3.582677!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label63.Text = "復路1：到着時間(依頼)"
        Me.Label63.Top = 10.00866!
        Me.Label63.Width = 1.771653!
        '
        'Label64
        '
        Me.Label64.Height = 0.2!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 3.582677!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label64.Text = "復路1：列車名・便名(依頼)"
        Me.Label64.Top = 10.20866!
        Me.Label64.Width = 1.771653!
        '
        'Label65
        '
        Me.Label65.Height = 0.2!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 3.582677!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label65.Text = "復路1：座席区分(依頼)"
        Me.Label65.Top = 10.40866!
        Me.Label65.Width = 1.771653!
        '
        'Label66
        '
        Me.Label66.Height = 0.2!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 3.582677!
        Me.Label66.Name = "Label66"
        Me.Label66.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; white-space: nowrap"
        Me.Label66.Text = "復路1：座席位置(依頼)"
        Me.Label66.Top = 10.60866!
        Me.Label66.Width = 1.771653!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.2!
        Me.KOUENKAI_NO.Left = 1.771654!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Text = Nothing
        Me.KOUENKAI_NO.Top = 1.208661!
        Me.KOUENKAI_NO.Width = 5.393701!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.2!
        Me.REQ_STATUS_TEHAI.Left = 1.771654!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Text = Nothing
        Me.REQ_STATUS_TEHAI.Top = 1.408661!
        Me.REQ_STATUS_TEHAI.Width = 5.393702!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Height = 0.2!
        Me.TIME_STAMP_BYL.Left = 1.771654!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Text = Nothing
        Me.TIME_STAMP_BYL.Top = 1.608661!
        Me.TIME_STAMP_BYL.Width = 5.393702!
        '
        'SANKASHA_ID
        '
        Me.SANKASHA_ID.DataField = "SANKASHA_ID"
        Me.SANKASHA_ID.Height = 0.2!
        Me.SANKASHA_ID.Left = 1.771654!
        Me.SANKASHA_ID.Name = "SANKASHA_ID"
        Me.SANKASHA_ID.Text = Nothing
        Me.SANKASHA_ID.Top = 1.808661!
        Me.SANKASHA_ID.Width = 5.393702!
        '
        'DR_CD
        '
        Me.DR_CD.DataField = "DR_CD"
        Me.DR_CD.Height = 0.2!
        Me.DR_CD.Left = 1.771654!
        Me.DR_CD.Name = "DR_CD"
        Me.DR_CD.Text = Nothing
        Me.DR_CD.Top = 2.008661!
        Me.DR_CD.Width = 5.393702!
        '
        'DR_NAME
        '
        Me.DR_NAME.DataField = "DR_NAME"
        Me.DR_NAME.Height = 0.2!
        Me.DR_NAME.Left = 1.771654!
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.Text = Nothing
        Me.DR_NAME.Top = 2.208661!
        Me.DR_NAME.Width = 5.393702!
        '
        'DR_KANA
        '
        Me.DR_KANA.DataField = "DR_KANA"
        Me.DR_KANA.Height = 0.2!
        Me.DR_KANA.Left = 1.771654!
        Me.DR_KANA.Name = "DR_KANA"
        Me.DR_KANA.Text = Nothing
        Me.DR_KANA.Top = 2.408661!
        Me.DR_KANA.Width = 5.393702!
        '
        'DR_SHISETSU_CD
        '
        Me.DR_SHISETSU_CD.DataField = "DR_SHISETSU_CD"
        Me.DR_SHISETSU_CD.Height = 0.2!
        Me.DR_SHISETSU_CD.Left = 1.771654!
        Me.DR_SHISETSU_CD.Name = "DR_SHISETSU_CD"
        Me.DR_SHISETSU_CD.Text = Nothing
        Me.DR_SHISETSU_CD.Top = 2.608661!
        Me.DR_SHISETSU_CD.Width = 5.393702!
        '
        'DR_SHISETSU_NAME
        '
        Me.DR_SHISETSU_NAME.DataField = "DR_SHISETSU_NAME"
        Me.DR_SHISETSU_NAME.Height = 0.2!
        Me.DR_SHISETSU_NAME.Left = 1.771654!
        Me.DR_SHISETSU_NAME.Name = "DR_SHISETSU_NAME"
        Me.DR_SHISETSU_NAME.Text = Nothing
        Me.DR_SHISETSU_NAME.Top = 2.808661!
        Me.DR_SHISETSU_NAME.Width = 5.393702!
        '
        'DR_SHISETSU_ADDRESS
        '
        Me.DR_SHISETSU_ADDRESS.DataField = "DR_SHISETSU_ADDRESS"
        Me.DR_SHISETSU_ADDRESS.Height = 0.2!
        Me.DR_SHISETSU_ADDRESS.Left = 1.771654!
        Me.DR_SHISETSU_ADDRESS.Name = "DR_SHISETSU_ADDRESS"
        Me.DR_SHISETSU_ADDRESS.Text = Nothing
        Me.DR_SHISETSU_ADDRESS.Top = 3.008661!
        Me.DR_SHISETSU_ADDRESS.Width = 5.393702!
        '
        'DR_YAKUWARI
        '
        Me.DR_YAKUWARI.DataField = "DR_YAKUWARI"
        Me.DR_YAKUWARI.Height = 0.2!
        Me.DR_YAKUWARI.Left = 1.771654!
        Me.DR_YAKUWARI.Name = "DR_YAKUWARI"
        Me.DR_YAKUWARI.Text = Nothing
        Me.DR_YAKUWARI.Top = 3.208661!
        Me.DR_YAKUWARI.Width = 5.393702!
        '
        'DR_SEX
        '
        Me.DR_SEX.DataField = "DR_SEX"
        Me.DR_SEX.Height = 0.2!
        Me.DR_SEX.Left = 1.771654!
        Me.DR_SEX.Name = "DR_SEX"
        Me.DR_SEX.Text = Nothing
        Me.DR_SEX.Top = 3.408661!
        Me.DR_SEX.Width = 5.393702!
        '
        'DR_AGE
        '
        Me.DR_AGE.DataField = "DR_AGE"
        Me.DR_AGE.Height = 0.2!
        Me.DR_AGE.Left = 1.771654!
        Me.DR_AGE.Name = "DR_AGE"
        Me.DR_AGE.Text = Nothing
        Me.DR_AGE.Top = 3.60866!
        Me.DR_AGE.Width = 5.393702!
        '
        'SHITEIGAI_RIYU
        '
        Me.SHITEIGAI_RIYU.DataField = "SEITEIGAI_RIYU"
        Me.SHITEIGAI_RIYU.Height = 0.2!
        Me.SHITEIGAI_RIYU.Left = 1.771654!
        Me.SHITEIGAI_RIYU.Name = "SHITEIGAI_RIYU"
        Me.SHITEIGAI_RIYU.Text = Nothing
        Me.SHITEIGAI_RIYU.Top = 3.80866!
        Me.SHITEIGAI_RIYU.Width = 5.393702!
        '
        'MR_AREA
        '
        Me.MR_AREA.DataField = "MR_AREA"
        Me.MR_AREA.Height = 0.2!
        Me.MR_AREA.Left = 1.771654!
        Me.MR_AREA.Name = "MR_AREA"
        Me.MR_AREA.Text = Nothing
        Me.MR_AREA.Top = 4.008661!
        Me.MR_AREA.Width = 5.393702!
        '
        'MR_EIGYOSHO
        '
        Me.MR_EIGYOSHO.DataField = "MR_EIGYOSHO"
        Me.MR_EIGYOSHO.Height = 0.2!
        Me.MR_EIGYOSHO.Left = 1.771654!
        Me.MR_EIGYOSHO.Name = "MR_EIGYOSHO"
        Me.MR_EIGYOSHO.Text = Nothing
        Me.MR_EIGYOSHO.Top = 4.208661!
        Me.MR_EIGYOSHO.Width = 5.393702!
        '
        'MR_NAME
        '
        Me.MR_NAME.DataField = "MR_NAME"
        Me.MR_NAME.Height = 0.2!
        Me.MR_NAME.Left = 1.771654!
        Me.MR_NAME.Name = "MR_NAME"
        Me.MR_NAME.Text = Nothing
        Me.MR_NAME.Top = 4.408661!
        Me.MR_NAME.Width = 5.393702!
        '
        'MR_ROMA
        '
        Me.MR_ROMA.DataField = "MR_ROMA"
        Me.MR_ROMA.Height = 0.2!
        Me.MR_ROMA.Left = 1.771654!
        Me.MR_ROMA.Name = "MR_ROMA"
        Me.MR_ROMA.Text = Nothing
        Me.MR_ROMA.Top = 4.608661!
        Me.MR_ROMA.Width = 5.393702!
        '
        'MR_KANA
        '
        Me.MR_KANA.DataField = "MR_KANA"
        Me.MR_KANA.Height = 0.2!
        Me.MR_KANA.Left = 1.771654!
        Me.MR_KANA.Name = "MR_KANA"
        Me.MR_KANA.Text = Nothing
        Me.MR_KANA.Top = 4.808661!
        Me.MR_KANA.Width = 5.393702!
        '
        'MR_EMAIL_PC
        '
        Me.MR_EMAIL_PC.DataField = "MR_EMAIL_PC"
        Me.MR_EMAIL_PC.Height = 0.2!
        Me.MR_EMAIL_PC.Left = 1.771654!
        Me.MR_EMAIL_PC.Name = "MR_EMAIL_PC"
        Me.MR_EMAIL_PC.Text = Nothing
        Me.MR_EMAIL_PC.Top = 5.008661!
        Me.MR_EMAIL_PC.Width = 5.393702!
        '
        'MR_EMAIL_KEITAI
        '
        Me.MR_EMAIL_KEITAI.DataField = "MR_EMAIL_KEITAI"
        Me.MR_EMAIL_KEITAI.Height = 0.2!
        Me.MR_EMAIL_KEITAI.Left = 1.771654!
        Me.MR_EMAIL_KEITAI.Name = "MR_EMAIL_KEITAI"
        Me.MR_EMAIL_KEITAI.Text = Nothing
        Me.MR_EMAIL_KEITAI.Top = 5.208661!
        Me.MR_EMAIL_KEITAI.Width = 5.393702!
        '
        'MR_KEITAI
        '
        Me.MR_KEITAI.DataField = "MR_KEITAI"
        Me.MR_KEITAI.Height = 0.2!
        Me.MR_KEITAI.Left = 1.771654!
        Me.MR_KEITAI.Name = "MR_KEITAI"
        Me.MR_KEITAI.Text = Nothing
        Me.MR_KEITAI.Top = 5.408661!
        Me.MR_KEITAI.Width = 5.393702!
        '
        'MR_TEL
        '
        Me.MR_TEL.DataField = "MR_TEL"
        Me.MR_TEL.Height = 0.2!
        Me.MR_TEL.Left = 1.771654!
        Me.MR_TEL.Name = "MR_TEL"
        Me.MR_TEL.Text = Nothing
        Me.MR_TEL.Top = 5.608661!
        Me.MR_TEL.Width = 5.393702!
        '
        'MR_SEND_SAKI_FS
        '
        Me.MR_SEND_SAKI_FS.DataField = "MR_SEND_SAKI_FS"
        Me.MR_SEND_SAKI_FS.Height = 0.2!
        Me.MR_SEND_SAKI_FS.Left = 1.771654!
        Me.MR_SEND_SAKI_FS.Name = "MR_SEND_SAKI_FS"
        Me.MR_SEND_SAKI_FS.Text = Nothing
        Me.MR_SEND_SAKI_FS.Top = 5.808661!
        Me.MR_SEND_SAKI_FS.Width = 5.393702!
        '
        'MR_SEND_SAKI_OTHER
        '
        Me.MR_SEND_SAKI_OTHER.DataField = "MR_SEND_SAKI_OTHER"
        Me.MR_SEND_SAKI_OTHER.Height = 0.2!
        Me.MR_SEND_SAKI_OTHER.Left = 1.771654!
        Me.MR_SEND_SAKI_OTHER.Name = "MR_SEND_SAKI_OTHER"
        Me.MR_SEND_SAKI_OTHER.Text = Nothing
        Me.MR_SEND_SAKI_OTHER.Top = 6.008661!
        Me.MR_SEND_SAKI_OTHER.Width = 5.393702!
        '
        'ACCOUNT_CD
        '
        Me.ACCOUNT_CD.DataField = "ACCOUNT_CD"
        Me.ACCOUNT_CD.Height = 0.2!
        Me.ACCOUNT_CD.Left = 1.771654!
        Me.ACCOUNT_CD.Name = "ACCOUNT_CD"
        Me.ACCOUNT_CD.Text = Nothing
        Me.ACCOUNT_CD.Top = 6.208661!
        Me.ACCOUNT_CD.Width = 5.393702!
        '
        'COST_CENTER
        '
        Me.COST_CENTER.DataField = "CONST_CENTER"
        Me.COST_CENTER.Height = 0.2!
        Me.COST_CENTER.Left = 1.771654!
        Me.COST_CENTER.Name = "COST_CENTER"
        Me.COST_CENTER.Text = Nothing
        Me.COST_CENTER.Top = 6.408662!
        Me.COST_CENTER.Width = 5.393702!
        '
        'INTERNAL_ORDER
        '
        Me.INTERNAL_ORDER.DataField = "INTERNAL_ORDER"
        Me.INTERNAL_ORDER.Height = 0.2!
        Me.INTERNAL_ORDER.Left = 1.771654!
        Me.INTERNAL_ORDER.Name = "INTERNAL_ORDER"
        Me.INTERNAL_ORDER.Text = Nothing
        Me.INTERNAL_ORDER.Top = 6.608661!
        Me.INTERNAL_ORDER.Width = 5.393702!
        '
        'ZETIA_CD
        '
        Me.ZETIA_CD.DataField = "ZETIA_CD"
        Me.ZETIA_CD.Height = 0.2!
        Me.ZETIA_CD.Left = 1.771654!
        Me.ZETIA_CD.Name = "ZETIA_CD"
        Me.ZETIA_CD.Text = Nothing
        Me.ZETIA_CD.Top = 6.808662!
        Me.ZETIA_CD.Width = 5.393702!
        '
        'SHONIN_NAME
        '
        Me.SHONIN_NAME.DataField = "SHONIN_NAME"
        Me.SHONIN_NAME.Height = 0.2!
        Me.SHONIN_NAME.Left = 1.771654!
        Me.SHONIN_NAME.Name = "SHONIN_NAME"
        Me.SHONIN_NAME.Text = Nothing
        Me.SHONIN_NAME.Top = 7.00866!
        Me.SHONIN_NAME.Width = 5.393702!
        '
        'SHONIN_DATE
        '
        Me.SHONIN_DATE.DataField = "SHONIN_DATE"
        Me.SHONIN_DATE.Height = 0.2!
        Me.SHONIN_DATE.Left = 1.771654!
        Me.SHONIN_DATE.Name = "SHONIN_DATE"
        Me.SHONIN_DATE.Text = Nothing
        Me.SHONIN_DATE.Top = 7.208664!
        Me.SHONIN_DATE.Width = 5.393702!
        '
        'TEHAI_HOTEL
        '
        Me.TEHAI_HOTEL.DataField = "TEHAI_HOTEL"
        Me.TEHAI_HOTEL.Height = 0.2!
        Me.TEHAI_HOTEL.Left = 1.771654!
        Me.TEHAI_HOTEL.Name = "TEHAI_HOTEL"
        Me.TEHAI_HOTEL.Text = Nothing
        Me.TEHAI_HOTEL.Top = 7.408665!
        Me.TEHAI_HOTEL.Width = 5.393702!
        '
        'HOTEL_IRAINAIYOU
        '
        Me.HOTEL_IRAINAIYOU.DataField = "HOTEL_IRAINAIYOU"
        Me.HOTEL_IRAINAIYOU.Height = 0.2!
        Me.HOTEL_IRAINAIYOU.Left = 1.771654!
        Me.HOTEL_IRAINAIYOU.Name = "HOTEL_IRAINAIYOU"
        Me.HOTEL_IRAINAIYOU.Text = Nothing
        Me.HOTEL_IRAINAIYOU.Top = 7.608664!
        Me.HOTEL_IRAINAIYOU.Width = 5.393702!
        '
        'REQ_HOTEL_DATE
        '
        Me.REQ_HOTEL_DATE.DataField = "REQ_HOTEL_DATE"
        Me.REQ_HOTEL_DATE.Height = 0.2!
        Me.REQ_HOTEL_DATE.Left = 1.771654!
        Me.REQ_HOTEL_DATE.Name = "REQ_HOTEL_DATE"
        Me.REQ_HOTEL_DATE.Text = Nothing
        Me.REQ_HOTEL_DATE.Top = 7.808664!
        Me.REQ_HOTEL_DATE.Width = 5.393702!
        '
        'REQ_HAKUSU
        '
        Me.REQ_HAKUSU.DataField = "REQ_HAKUSU"
        Me.REQ_HAKUSU.Height = 0.2!
        Me.REQ_HAKUSU.Left = 1.771654!
        Me.REQ_HAKUSU.Name = "REQ_HAKUSU"
        Me.REQ_HAKUSU.Text = Nothing
        Me.REQ_HAKUSU.Top = 8.008663!
        Me.REQ_HAKUSU.Width = 5.393702!
        '
        'REQ_HOTEL_SMOKING
        '
        Me.REQ_HOTEL_SMOKING.DataField = "REQ_HOTEL_SMOKING"
        Me.REQ_HOTEL_SMOKING.Height = 0.2!
        Me.REQ_HOTEL_SMOKING.Left = 1.771654!
        Me.REQ_HOTEL_SMOKING.Name = "REQ_HOTEL_SMOKING"
        Me.REQ_HOTEL_SMOKING.Text = Nothing
        Me.REQ_HOTEL_SMOKING.Top = 8.208664!
        Me.REQ_HOTEL_SMOKING.Width = 5.393702!
        '
        'REQ_HOTEL_NOTE
        '
        Me.REQ_HOTEL_NOTE.DataField = "REQ_HOTEL_NOTE"
        Me.REQ_HOTEL_NOTE.Height = 0.2!
        Me.REQ_HOTEL_NOTE.Left = 1.771654!
        Me.REQ_HOTEL_NOTE.Name = "REQ_HOTEL_NOTE"
        Me.REQ_HOTEL_NOTE.Text = Nothing
        Me.REQ_HOTEL_NOTE.Top = 8.408665!
        Me.REQ_HOTEL_NOTE.Width = 5.393702!
        '
        'REQ_O_TEHAI_1
        '
        Me.REQ_O_TEHAI_1.DataField = "REQ_O_TEHAI_1"
        Me.REQ_O_TEHAI_1.Height = 0.1999998!
        Me.REQ_O_TEHAI_1.Left = 1.771654!
        Me.REQ_O_TEHAI_1.Name = "REQ_O_TEHAI_1"
        Me.REQ_O_TEHAI_1.Text = Nothing
        Me.REQ_O_TEHAI_1.Top = 8.608664!
        Me.REQ_O_TEHAI_1.Width = 1.811025!
        '
        'REQ_O_IRAINAIYOU_1
        '
        Me.REQ_O_IRAINAIYOU_1.DataField = "REQ_O_IRAINAIYOU_1"
        Me.REQ_O_IRAINAIYOU_1.Height = 0.1999998!
        Me.REQ_O_IRAINAIYOU_1.Left = 1.771654!
        Me.REQ_O_IRAINAIYOU_1.Name = "REQ_O_IRAINAIYOU_1"
        Me.REQ_O_IRAINAIYOU_1.Text = Nothing
        Me.REQ_O_IRAINAIYOU_1.Top = 8.808664!
        Me.REQ_O_IRAINAIYOU_1.Width = 1.811024!
        '
        'REQ_O_KOTSUKIKAN_1
        '
        Me.REQ_O_KOTSUKIKAN_1.DataField = "REQ_O_KOTSUKIKAN_1"
        Me.REQ_O_KOTSUKIKAN_1.Height = 0.1999998!
        Me.REQ_O_KOTSUKIKAN_1.Left = 1.771654!
        Me.REQ_O_KOTSUKIKAN_1.Name = "REQ_O_KOTSUKIKAN_1"
        Me.REQ_O_KOTSUKIKAN_1.Text = Nothing
        Me.REQ_O_KOTSUKIKAN_1.Top = 9.008663!
        Me.REQ_O_KOTSUKIKAN_1.Width = 1.811024!
        '
        'REQ_O_DATE_1
        '
        Me.REQ_O_DATE_1.DataField = "REQ_O_DATE_1"
        Me.REQ_O_DATE_1.Height = 0.1999998!
        Me.REQ_O_DATE_1.Left = 1.771654!
        Me.REQ_O_DATE_1.Name = "REQ_O_DATE_1"
        Me.REQ_O_DATE_1.Text = Nothing
        Me.REQ_O_DATE_1.Top = 9.208662!
        Me.REQ_O_DATE_1.Width = 1.811024!
        '
        'REQ_O_AIRPORT1_1
        '
        Me.REQ_O_AIRPORT1_1.DataField = "REQ_O_AIRPORT1_!"
        Me.REQ_O_AIRPORT1_1.Height = 0.1999998!
        Me.REQ_O_AIRPORT1_1.Left = 1.771654!
        Me.REQ_O_AIRPORT1_1.Name = "REQ_O_AIRPORT1_1"
        Me.REQ_O_AIRPORT1_1.Text = Nothing
        Me.REQ_O_AIRPORT1_1.Top = 9.408663!
        Me.REQ_O_AIRPORT1_1.Width = 1.811024!
        '
        'REQ_O_AIRPORT2_1
        '
        Me.REQ_O_AIRPORT2_1.DataField = "REQ_O_AIRPORT2_1"
        Me.REQ_O_AIRPORT2_1.Height = 0.1999998!
        Me.REQ_O_AIRPORT2_1.Left = 1.771654!
        Me.REQ_O_AIRPORT2_1.Name = "REQ_O_AIRPORT2_1"
        Me.REQ_O_AIRPORT2_1.Text = Nothing
        Me.REQ_O_AIRPORT2_1.Top = 9.608662!
        Me.REQ_O_AIRPORT2_1.Width = 1.811024!
        '
        'REQ_O_TIME1_1
        '
        Me.REQ_O_TIME1_1.DataField = "REQ_O_TIME1_1"
        Me.REQ_O_TIME1_1.Height = 0.1999998!
        Me.REQ_O_TIME1_1.Left = 1.771654!
        Me.REQ_O_TIME1_1.Name = "REQ_O_TIME1_1"
        Me.REQ_O_TIME1_1.Text = Nothing
        Me.REQ_O_TIME1_1.Top = 9.808662!
        Me.REQ_O_TIME1_1.Width = 1.811024!
        '
        'REQ_O_TIME2_1
        '
        Me.REQ_O_TIME2_1.DataField = "REQ_O_TIME2_1"
        Me.REQ_O_TIME2_1.Height = 0.1999998!
        Me.REQ_O_TIME2_1.Left = 1.771654!
        Me.REQ_O_TIME2_1.Name = "REQ_O_TIME2_1"
        Me.REQ_O_TIME2_1.Text = Nothing
        Me.REQ_O_TIME2_1.Top = 10.00866!
        Me.REQ_O_TIME2_1.Width = 1.811024!
        '
        'REQ_O_BIN_1
        '
        Me.REQ_O_BIN_1.DataField = "REQ_O_BIN_1"
        Me.REQ_O_BIN_1.Height = 0.1999998!
        Me.REQ_O_BIN_1.Left = 1.771654!
        Me.REQ_O_BIN_1.Name = "REQ_O_BIN_1"
        Me.REQ_O_BIN_1.Text = Nothing
        Me.REQ_O_BIN_1.Top = 10.20866!
        Me.REQ_O_BIN_1.Width = 1.811024!
        '
        'REQ_O_SEAT_1
        '
        Me.REQ_O_SEAT_1.DataField = "REQ_O_SEAT_1"
        Me.REQ_O_SEAT_1.Height = 0.1999998!
        Me.REQ_O_SEAT_1.Left = 1.771654!
        Me.REQ_O_SEAT_1.Name = "REQ_O_SEAT_1"
        Me.REQ_O_SEAT_1.Text = Nothing
        Me.REQ_O_SEAT_1.Top = 10.40866!
        Me.REQ_O_SEAT_1.Width = 1.811024!
        '
        'REQ_O_SEAT_KIBOU1
        '
        Me.REQ_O_SEAT_KIBOU1.DataField = "REQ_O_SEAT_KIBOU1"
        Me.REQ_O_SEAT_KIBOU1.Height = 0.1999998!
        Me.REQ_O_SEAT_KIBOU1.Left = 1.771654!
        Me.REQ_O_SEAT_KIBOU1.Name = "REQ_O_SEAT_KIBOU1"
        Me.REQ_O_SEAT_KIBOU1.Text = Nothing
        Me.REQ_O_SEAT_KIBOU1.Top = 10.60866!
        Me.REQ_O_SEAT_KIBOU1.Width = 1.811024!
        '
        'REQ_F_TEHAI_1
        '
        Me.REQ_F_TEHAI_1.DataField = "REQ_F_TEHAI_1"
        Me.REQ_F_TEHAI_1.Height = 0.1999998!
        Me.REQ_F_TEHAI_1.Left = 5.354331!
        Me.REQ_F_TEHAI_1.Name = "REQ_F_TEHAI_1"
        Me.REQ_F_TEHAI_1.Text = Nothing
        Me.REQ_F_TEHAI_1.Top = 8.608664!
        Me.REQ_F_TEHAI_1.Width = 1.811024!
        '
        'REQ_F_IRAINAIYOU_1
        '
        Me.REQ_F_IRAINAIYOU_1.DataField = "REQ_F_IRAINAIYOU_1"
        Me.REQ_F_IRAINAIYOU_1.Height = 0.1999998!
        Me.REQ_F_IRAINAIYOU_1.Left = 5.354331!
        Me.REQ_F_IRAINAIYOU_1.Name = "REQ_F_IRAINAIYOU_1"
        Me.REQ_F_IRAINAIYOU_1.Text = Nothing
        Me.REQ_F_IRAINAIYOU_1.Top = 8.808664!
        Me.REQ_F_IRAINAIYOU_1.Width = 1.811024!
        '
        'REQ_F_KOTSUKIKAN_1
        '
        Me.REQ_F_KOTSUKIKAN_1.DataField = "REQ_F_KOTSUKIKAN_1"
        Me.REQ_F_KOTSUKIKAN_1.Height = 0.1999998!
        Me.REQ_F_KOTSUKIKAN_1.Left = 5.354331!
        Me.REQ_F_KOTSUKIKAN_1.Name = "REQ_F_KOTSUKIKAN_1"
        Me.REQ_F_KOTSUKIKAN_1.Text = Nothing
        Me.REQ_F_KOTSUKIKAN_1.Top = 9.008663!
        Me.REQ_F_KOTSUKIKAN_1.Width = 1.811024!
        '
        'REQ_F_DATE_1
        '
        Me.REQ_F_DATE_1.DataField = "REQ_F_DATE_1"
        Me.REQ_F_DATE_1.Height = 0.1999998!
        Me.REQ_F_DATE_1.Left = 5.354331!
        Me.REQ_F_DATE_1.Name = "REQ_F_DATE_1"
        Me.REQ_F_DATE_1.Text = Nothing
        Me.REQ_F_DATE_1.Top = 9.208662!
        Me.REQ_F_DATE_1.Width = 1.811024!
        '
        'REQ_F_AIRPORT1_1
        '
        Me.REQ_F_AIRPORT1_1.DataField = "REQ_F_AIRPORT1_1"
        Me.REQ_F_AIRPORT1_1.Height = 0.1999998!
        Me.REQ_F_AIRPORT1_1.Left = 5.354331!
        Me.REQ_F_AIRPORT1_1.Name = "REQ_F_AIRPORT1_1"
        Me.REQ_F_AIRPORT1_1.Text = Nothing
        Me.REQ_F_AIRPORT1_1.Top = 9.408663!
        Me.REQ_F_AIRPORT1_1.Width = 1.811024!
        '
        'REQ_F_AIRPORT2_1
        '
        Me.REQ_F_AIRPORT2_1.DataField = "REQ_F_AIRPORT2_1"
        Me.REQ_F_AIRPORT2_1.Height = 0.1999998!
        Me.REQ_F_AIRPORT2_1.Left = 5.354331!
        Me.REQ_F_AIRPORT2_1.Name = "REQ_F_AIRPORT2_1"
        Me.REQ_F_AIRPORT2_1.Text = Nothing
        Me.REQ_F_AIRPORT2_1.Top = 9.608662!
        Me.REQ_F_AIRPORT2_1.Width = 1.811024!
        '
        'REQ_F_TIME1_1
        '
        Me.REQ_F_TIME1_1.DataField = "REQ_F_TIME1_1"
        Me.REQ_F_TIME1_1.Height = 0.1999998!
        Me.REQ_F_TIME1_1.Left = 5.354331!
        Me.REQ_F_TIME1_1.Name = "REQ_F_TIME1_1"
        Me.REQ_F_TIME1_1.Text = Nothing
        Me.REQ_F_TIME1_1.Top = 9.808662!
        Me.REQ_F_TIME1_1.Width = 1.811024!
        '
        'REQ_F_TIME2_1
        '
        Me.REQ_F_TIME2_1.DataField = "REQ_F_TIME2_1"
        Me.REQ_F_TIME2_1.Height = 0.1999998!
        Me.REQ_F_TIME2_1.Left = 5.354331!
        Me.REQ_F_TIME2_1.Name = "REQ_F_TIME2_1"
        Me.REQ_F_TIME2_1.Text = Nothing
        Me.REQ_F_TIME2_1.Top = 10.00866!
        Me.REQ_F_TIME2_1.Width = 1.811024!
        '
        'REQ_F_BIN_1
        '
        Me.REQ_F_BIN_1.DataField = "REQ_F_BIN_1"
        Me.REQ_F_BIN_1.Height = 0.1999998!
        Me.REQ_F_BIN_1.Left = 5.354331!
        Me.REQ_F_BIN_1.Name = "REQ_F_BIN_1"
        Me.REQ_F_BIN_1.Text = Nothing
        Me.REQ_F_BIN_1.Top = 10.20866!
        Me.REQ_F_BIN_1.Width = 1.811024!
        '
        'REQ_F_SEAT_1
        '
        Me.REQ_F_SEAT_1.DataField = "REQ_F_SEAT_1"
        Me.REQ_F_SEAT_1.Height = 0.1999998!
        Me.REQ_F_SEAT_1.Left = 5.354331!
        Me.REQ_F_SEAT_1.Name = "REQ_F_SEAT_1"
        Me.REQ_F_SEAT_1.Text = Nothing
        Me.REQ_F_SEAT_1.Top = 10.40866!
        Me.REQ_F_SEAT_1.Width = 1.811024!
        '
        'REQ_F_SEAT_KIBOU1
        '
        Me.REQ_F_SEAT_KIBOU1.DataField = "REQ_F_KIBOU1"
        Me.REQ_F_SEAT_KIBOU1.Height = 0.1999998!
        Me.REQ_F_SEAT_KIBOU1.Left = 5.354331!
        Me.REQ_F_SEAT_KIBOU1.Name = "REQ_F_SEAT_KIBOU1"
        Me.REQ_F_SEAT_KIBOU1.Text = Nothing
        Me.REQ_F_SEAT_KIBOU1.Top = 10.60866!
        Me.REQ_F_SEAT_KIBOU1.Width = 1.811024!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0000004768372!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 2.808661!
        Me.Line1.Width = 7.165356!
        Me.Line1.X1 = 0.0000004768372!
        Me.Line1.X2 = 7.165356!
        Me.Line1.Y1 = 2.808661!
        Me.Line1.Y2 = 2.808661!
        '
        'Line2
        '
        Me.Line2.Height = 9.599998!
        Me.Line2.Left = 1.771654!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 1.208661!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 1.771654!
        Me.Line2.X2 = 1.771654!
        Me.Line2.Y1 = 1.208661!
        Me.Line2.Y2 = 10.80866!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0000004768372!
        Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.408661!
        Me.Line3.Width = 7.165353!
        Me.Line3.X1 = 0.0000004768372!
        Me.Line3.X2 = 7.165354!
        Me.Line3.Y1 = 1.408661!
        Me.Line3.Y2 = 1.408661!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0000004768372!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.608661!
        Me.Line4.Width = 7.165353!
        Me.Line4.X1 = 0.0000004768372!
        Me.Line4.X2 = 7.165354!
        Me.Line4.Y1 = 1.608661!
        Me.Line4.Y2 = 1.608661!
        '
        'Line5
        '
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.0000004768372!
        Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.808661!
        Me.Line5.Width = 7.165353!
        Me.Line5.X1 = 0.0000004768372!
        Me.Line5.X2 = 7.165354!
        Me.Line5.Y1 = 1.808661!
        Me.Line5.Y2 = 1.808661!
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0000004768372!
        Me.Line6.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 2.008661!
        Me.Line6.Width = 7.165353!
        Me.Line6.X1 = 0.0000004768372!
        Me.Line6.X2 = 7.165354!
        Me.Line6.Y1 = 2.008661!
        Me.Line6.Y2 = 2.008661!
        '
        'Line7
        '
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 0.0000004768372!
        Me.Line7.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 2.208661!
        Me.Line7.Width = 7.165353!
        Me.Line7.X1 = 0.0000004768372!
        Me.Line7.X2 = 7.165354!
        Me.Line7.Y1 = 2.208661!
        Me.Line7.Y2 = 2.208661!
        '
        'Line8
        '
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.0000004768372!
        Me.Line8.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.408661!
        Me.Line8.Width = 7.165353!
        Me.Line8.X1 = 0.0000004768372!
        Me.Line8.X2 = 7.165354!
        Me.Line8.Y1 = 2.408661!
        Me.Line8.Y2 = 2.408661!
        '
        'Line9
        '
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.0000004768372!
        Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 2.608661!
        Me.Line9.Width = 7.165353!
        Me.Line9.X1 = 0.0000004768372!
        Me.Line9.X2 = 7.165354!
        Me.Line9.Y1 = 2.608661!
        Me.Line9.Y2 = 2.608661!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0000004768372!
        Me.Line10.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 3.008661!
        Me.Line10.Width = 7.165353!
        Me.Line10.X1 = 0.0000004768372!
        Me.Line10.X2 = 7.165354!
        Me.Line10.Y1 = 3.008661!
        Me.Line10.Y2 = 3.008661!
        '
        'Line11
        '
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 0.0000004768372!
        Me.Line11.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 3.208661!
        Me.Line11.Width = 7.165353!
        Me.Line11.X1 = 0.0000004768372!
        Me.Line11.X2 = 7.165354!
        Me.Line11.Y1 = 3.208661!
        Me.Line11.Y2 = 3.208661!
        '
        'Line12
        '
        Me.Line12.Height = 0.0!
        Me.Line12.Left = 0.0000004768372!
        Me.Line12.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 3.408661!
        Me.Line12.Width = 7.165353!
        Me.Line12.X1 = 0.0000004768372!
        Me.Line12.X2 = 7.165354!
        Me.Line12.Y1 = 3.408661!
        Me.Line12.Y2 = 3.408661!
        '
        'Line13
        '
        Me.Line13.Height = 0.0!
        Me.Line13.Left = 0.0000004768372!
        Me.Line13.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 3.60866!
        Me.Line13.Width = 7.165353!
        Me.Line13.X1 = 0.0000004768372!
        Me.Line13.X2 = 7.165354!
        Me.Line13.Y1 = 3.60866!
        Me.Line13.Y2 = 3.60866!
        '
        'Line14
        '
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 0.0000004768372!
        Me.Line14.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 3.80866!
        Me.Line14.Width = 7.165353!
        Me.Line14.X1 = 0.0000004768372!
        Me.Line14.X2 = 7.165354!
        Me.Line14.Y1 = 3.80866!
        Me.Line14.Y2 = 3.80866!
        '
        'Line15
        '
        Me.Line15.Height = 0.0!
        Me.Line15.Left = 0.0000004768372!
        Me.Line15.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 4.008661!
        Me.Line15.Width = 7.165353!
        Me.Line15.X1 = 0.0000004768372!
        Me.Line15.X2 = 7.165354!
        Me.Line15.Y1 = 4.008661!
        Me.Line15.Y2 = 4.008661!
        '
        'Line16
        '
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 0.0000004768372!
        Me.Line16.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 4.208661!
        Me.Line16.Width = 7.165353!
        Me.Line16.X1 = 0.0000004768372!
        Me.Line16.X2 = 7.165354!
        Me.Line16.Y1 = 4.208661!
        Me.Line16.Y2 = 4.208661!
        '
        'Line17
        '
        Me.Line17.Height = 0.0!
        Me.Line17.Left = 0.0000004768372!
        Me.Line17.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 4.408661!
        Me.Line17.Width = 7.165353!
        Me.Line17.X1 = 0.0000004768372!
        Me.Line17.X2 = 7.165354!
        Me.Line17.Y1 = 4.408661!
        Me.Line17.Y2 = 4.408661!
        '
        'Line18
        '
        Me.Line18.Height = 0.0!
        Me.Line18.Left = 0.0000004768372!
        Me.Line18.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 4.608661!
        Me.Line18.Width = 7.165353!
        Me.Line18.X1 = 0.0000004768372!
        Me.Line18.X2 = 7.165354!
        Me.Line18.Y1 = 4.608661!
        Me.Line18.Y2 = 4.608661!
        '
        'Line19
        '
        Me.Line19.Height = 0.0!
        Me.Line19.Left = 0.0000004768372!
        Me.Line19.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 4.808661!
        Me.Line19.Width = 7.165353!
        Me.Line19.X1 = 0.0000004768372!
        Me.Line19.X2 = 7.165354!
        Me.Line19.Y1 = 4.808661!
        Me.Line19.Y2 = 4.808661!
        '
        'Line20
        '
        Me.Line20.Height = 0.0!
        Me.Line20.Left = 0.0000004768372!
        Me.Line20.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 5.008661!
        Me.Line20.Width = 7.165353!
        Me.Line20.X1 = 0.0000004768372!
        Me.Line20.X2 = 7.165354!
        Me.Line20.Y1 = 5.008661!
        Me.Line20.Y2 = 5.008661!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.0000004768372!
        Me.Line21.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 5.208661!
        Me.Line21.Width = 7.165353!
        Me.Line21.X1 = 0.0000004768372!
        Me.Line21.X2 = 7.165354!
        Me.Line21.Y1 = 5.208661!
        Me.Line21.Y2 = 5.208661!
        '
        'Line22
        '
        Me.Line22.Height = 0.0!
        Me.Line22.Left = 0.0000004768372!
        Me.Line22.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 5.408661!
        Me.Line22.Width = 7.165353!
        Me.Line22.X1 = 0.0000004768372!
        Me.Line22.X2 = 7.165354!
        Me.Line22.Y1 = 5.408661!
        Me.Line22.Y2 = 5.408661!
        '
        'Line23
        '
        Me.Line23.Height = 0.0!
        Me.Line23.Left = 0.0000004768372!
        Me.Line23.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 5.608661!
        Me.Line23.Width = 7.165353!
        Me.Line23.X1 = 0.0000004768372!
        Me.Line23.X2 = 7.165354!
        Me.Line23.Y1 = 5.608661!
        Me.Line23.Y2 = 5.608661!
        '
        'Line24
        '
        Me.Line24.Height = 0.0!
        Me.Line24.Left = 0.0000004768372!
        Me.Line24.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 5.808661!
        Me.Line24.Width = 7.165353!
        Me.Line24.X1 = 0.0000004768372!
        Me.Line24.X2 = 7.165354!
        Me.Line24.Y1 = 5.808661!
        Me.Line24.Y2 = 5.808661!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.0000004768372!
        Me.Line25.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 6.008661!
        Me.Line25.Width = 7.165353!
        Me.Line25.X1 = 0.0000004768372!
        Me.Line25.X2 = 7.165354!
        Me.Line25.Y1 = 6.008661!
        Me.Line25.Y2 = 6.008661!
        '
        'Line26
        '
        Me.Line26.Height = 0.0!
        Me.Line26.Left = 0.0000004768372!
        Me.Line26.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 6.20866!
        Me.Line26.Width = 7.165353!
        Me.Line26.X1 = 0.0000004768372!
        Me.Line26.X2 = 7.165354!
        Me.Line26.Y1 = 6.20866!
        Me.Line26.Y2 = 6.20866!
        '
        'Line27
        '
        Me.Line27.Height = 0.0!
        Me.Line27.Left = 0.0000004768372!
        Me.Line27.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 6.40866!
        Me.Line27.Width = 7.165353!
        Me.Line27.X1 = 0.0000004768372!
        Me.Line27.X2 = 7.165354!
        Me.Line27.Y1 = 6.40866!
        Me.Line27.Y2 = 6.40866!
        '
        'Line28
        '
        Me.Line28.Height = 0.0!
        Me.Line28.Left = 0.0000004768372!
        Me.Line28.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 6.60866!
        Me.Line28.Width = 7.165353!
        Me.Line28.X1 = 0.0000004768372!
        Me.Line28.X2 = 7.165354!
        Me.Line28.Y1 = 6.60866!
        Me.Line28.Y2 = 6.60866!
        '
        'Line29
        '
        Me.Line29.Height = 0.0!
        Me.Line29.Left = 0.0000004768372!
        Me.Line29.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 6.808661!
        Me.Line29.Width = 7.165353!
        Me.Line29.X1 = 0.0000004768372!
        Me.Line29.X2 = 7.165354!
        Me.Line29.Y1 = 6.808661!
        Me.Line29.Y2 = 6.808661!
        '
        'Line30
        '
        Me.Line30.Height = 0.0!
        Me.Line30.Left = 0.0000004768372!
        Me.Line30.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 7.00866!
        Me.Line30.Width = 7.165353!
        Me.Line30.X1 = 0.0000004768372!
        Me.Line30.X2 = 7.165354!
        Me.Line30.Y1 = 7.00866!
        Me.Line30.Y2 = 7.00866!
        '
        'Line31
        '
        Me.Line31.Height = 0.0!
        Me.Line31.Left = 0.0000004768372!
        Me.Line31.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 7.208662!
        Me.Line31.Width = 7.165353!
        Me.Line31.X1 = 0.0000004768372!
        Me.Line31.X2 = 7.165354!
        Me.Line31.Y1 = 7.208662!
        Me.Line31.Y2 = 7.208662!
        '
        'Line32
        '
        Me.Line32.Height = 0.0!
        Me.Line32.Left = 0.0000004768372!
        Me.Line32.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 7.408661!
        Me.Line32.Width = 7.165353!
        Me.Line32.X1 = 0.0000004768372!
        Me.Line32.X2 = 7.165354!
        Me.Line32.Y1 = 7.408661!
        Me.Line32.Y2 = 7.408661!
        '
        'Line33
        '
        Me.Line33.Height = 0.0!
        Me.Line33.Left = 0.0000004768372!
        Me.Line33.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 7.608662!
        Me.Line33.Width = 7.165353!
        Me.Line33.X1 = 0.0000004768372!
        Me.Line33.X2 = 7.165354!
        Me.Line33.Y1 = 7.608662!
        Me.Line33.Y2 = 7.608662!
        '
        'Line34
        '
        Me.Line34.Height = 0.0!
        Me.Line34.Left = 0.0000004768372!
        Me.Line34.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 7.808661!
        Me.Line34.Width = 7.165353!
        Me.Line34.X1 = 0.0000004768372!
        Me.Line34.X2 = 7.165354!
        Me.Line34.Y1 = 7.808661!
        Me.Line34.Y2 = 7.808661!
        '
        'Line35
        '
        Me.Line35.Height = 0.0!
        Me.Line35.Left = 0.0000004768372!
        Me.Line35.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 8.008661!
        Me.Line35.Width = 7.165353!
        Me.Line35.X1 = 0.0000004768372!
        Me.Line35.X2 = 7.165354!
        Me.Line35.Y1 = 8.008661!
        Me.Line35.Y2 = 8.008661!
        '
        'Line36
        '
        Me.Line36.Height = 0.0!
        Me.Line36.Left = 0.0000004768372!
        Me.Line36.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line36.LineWeight = 1.0!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 8.20866!
        Me.Line36.Width = 7.165353!
        Me.Line36.X1 = 0.0000004768372!
        Me.Line36.X2 = 7.165354!
        Me.Line36.Y1 = 8.20866!
        Me.Line36.Y2 = 8.20866!
        '
        'Line37
        '
        Me.Line37.Height = 0.0!
        Me.Line37.Left = 0.0000004768372!
        Me.Line37.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line37.LineWeight = 1.0!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 8.408661!
        Me.Line37.Width = 7.165353!
        Me.Line37.X1 = 0.0000004768372!
        Me.Line37.X2 = 7.165354!
        Me.Line37.Y1 = 8.408661!
        Me.Line37.Y2 = 8.408661!
        '
        'Line38
        '
        Me.Line38.Height = 0.0!
        Me.Line38.Left = 0.0000004768372!
        Me.Line38.LineWeight = 1.0!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 8.60866!
        Me.Line38.Width = 7.165353!
        Me.Line38.X1 = 0.0000004768372!
        Me.Line38.X2 = 7.165354!
        Me.Line38.Y1 = 8.60866!
        Me.Line38.Y2 = 8.60866!
        '
        'Line39
        '
        Me.Line39.Height = 0.0!
        Me.Line39.Left = 0.0000004768372!
        Me.Line39.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line39.LineWeight = 1.0!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 8.808661!
        Me.Line39.Width = 7.165353!
        Me.Line39.X1 = 0.0000004768372!
        Me.Line39.X2 = 7.165354!
        Me.Line39.Y1 = 8.808661!
        Me.Line39.Y2 = 8.808661!
        '
        'Line40
        '
        Me.Line40.Height = 0.0!
        Me.Line40.Left = 0.0000004768372!
        Me.Line40.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 9.008659!
        Me.Line40.Width = 7.165353!
        Me.Line40.X1 = 0.0000004768372!
        Me.Line40.X2 = 7.165354!
        Me.Line40.Y1 = 9.008659!
        Me.Line40.Y2 = 9.008659!
        '
        'Line41
        '
        Me.Line41.Height = 0.0!
        Me.Line41.Left = 0.0000004768372!
        Me.Line41.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line41.LineWeight = 1.0!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 9.208658!
        Me.Line41.Width = 7.165353!
        Me.Line41.X1 = 0.0000004768372!
        Me.Line41.X2 = 7.165354!
        Me.Line41.Y1 = 9.208658!
        Me.Line41.Y2 = 9.208658!
        '
        'Line42
        '
        Me.Line42.Height = 0.0!
        Me.Line42.Left = 0.0000004768372!
        Me.Line42.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line42.LineWeight = 1.0!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 9.408659!
        Me.Line42.Width = 7.165353!
        Me.Line42.X1 = 0.0000004768372!
        Me.Line42.X2 = 7.165354!
        Me.Line42.Y1 = 9.408659!
        Me.Line42.Y2 = 9.408659!
        '
        'Line43
        '
        Me.Line43.Height = 0.0!
        Me.Line43.Left = 0.0000004768372!
        Me.Line43.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line43.LineWeight = 1.0!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 9.608658!
        Me.Line43.Width = 7.165353!
        Me.Line43.X1 = 0.0000004768372!
        Me.Line43.X2 = 7.165354!
        Me.Line43.Y1 = 9.608658!
        Me.Line43.Y2 = 9.608658!
        '
        'Line44
        '
        Me.Line44.Height = 0.0!
        Me.Line44.Left = 0.0000004768372!
        Me.Line44.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line44.LineWeight = 1.0!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 9.808659!
        Me.Line44.Width = 7.165353!
        Me.Line44.X1 = 0.0000004768372!
        Me.Line44.X2 = 7.165354!
        Me.Line44.Y1 = 9.808659!
        Me.Line44.Y2 = 9.808659!
        '
        'Line45
        '
        Me.Line45.Height = 0.0!
        Me.Line45.Left = 0.0000004768372!
        Me.Line45.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line45.LineWeight = 1.0!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 10.00866!
        Me.Line45.Width = 7.165353!
        Me.Line45.X1 = 0.0000004768372!
        Me.Line45.X2 = 7.165354!
        Me.Line45.Y1 = 10.00866!
        Me.Line45.Y2 = 10.00866!
        '
        'Line46
        '
        Me.Line46.Height = 0.0!
        Me.Line46.Left = 0.0000004768372!
        Me.Line46.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line46.LineWeight = 1.0!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 10.20866!
        Me.Line46.Width = 7.165353!
        Me.Line46.X1 = 0.0000004768372!
        Me.Line46.X2 = 7.165354!
        Me.Line46.Y1 = 10.20866!
        Me.Line46.Y2 = 10.20866!
        '
        'Line47
        '
        Me.Line47.Height = 0.0!
        Me.Line47.Left = 0.0000004768372!
        Me.Line47.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line47.LineWeight = 1.0!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 10.40866!
        Me.Line47.Width = 7.165353!
        Me.Line47.X1 = 0.0000004768372!
        Me.Line47.X2 = 7.165354!
        Me.Line47.Y1 = 10.40866!
        Me.Line47.Y2 = 10.40866!
        '
        'Line48
        '
        Me.Line48.Height = 0.0!
        Me.Line48.Left = 0.0000004768372!
        Me.Line48.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line48.LineWeight = 1.0!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 10.60866!
        Me.Line48.Width = 7.165353!
        Me.Line48.X1 = 0.0000004768372!
        Me.Line48.X2 = 7.165354!
        Me.Line48.Y1 = 10.60866!
        Me.Line48.Y2 = 10.60866!
        '
        'Line49
        '
        Me.Line49.Height = 2.199996!
        Me.Line49.Left = 3.582677!
        Me.Line49.LineWeight = 1.0!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 8.608664!
        Me.Line49.Width = 0.0!
        Me.Line49.X1 = 3.582677!
        Me.Line49.X2 = 3.582677!
        Me.Line49.Y1 = 8.608664!
        Me.Line49.Y2 = 10.80866!
        '
        'Line50
        '
        Me.Line50.Height = 2.199996!
        Me.Line50.Left = 5.354331!
        Me.Line50.LineWeight = 1.0!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 8.608664!
        Me.Line50.Width = 0.0!
        Me.Line50.X1 = 5.354331!
        Me.Line50.X2 = 5.354331!
        Me.Line50.Y1 = 8.608664!
        Me.Line50.Y2 = 10.80866!
        '
        'Line51
        '
        Me.Line51.Height = 0.0!
        Me.Line51.Left = 0.0000004768372!
        Me.Line51.LineWeight = 1.0!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 1.208661!
        Me.Line51.Width = 7.165355!
        Me.Line51.X1 = 0.0000004768372!
        Me.Line51.X2 = 7.165355!
        Me.Line51.Y1 = 1.208661!
        Me.Line51.Y2 = 1.208661!
        '
        'Line52
        '
        Me.Line52.Height = 9.599998!
        Me.Line52.Left = 0.0000004768372!
        Me.Line52.LineWeight = 1.0!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 1.208661!
        Me.Line52.Width = 0.0!
        Me.Line52.X1 = 0.0000004768372!
        Me.Line52.X2 = 0.0000004768372!
        Me.Line52.Y1 = 1.208661!
        Me.Line52.Y2 = 10.80866!
        '
        'Line53
        '
        Me.Line53.Height = 0.0!
        Me.Line53.Left = 0.0000004768372!
        Me.Line53.LineWeight = 1.0!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 10.80866!
        Me.Line53.Width = 7.165355!
        Me.Line53.X1 = 0.0000004768372!
        Me.Line53.X2 = 7.165355!
        Me.Line53.Y1 = 10.80866!
        Me.Line53.Y2 = 10.80866!
        '
        'Line54
        '
        Me.Line54.Height = 9.599998!
        Me.Line54.Left = 7.165355!
        Me.Line54.LineWeight = 1.0!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 1.208661!
        Me.Line54.Width = 0.0!
        Me.Line54.X1 = 7.165355!
        Me.Line54.X2 = 7.165355!
        Me.Line54.Y1 = 1.208661!
        Me.Line54.Y2 = 10.80866!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'DrReport1
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.165357!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_KANA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SHISETSU_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SHISETSU_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SHISETSU_ADDRESS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_YAKUWARI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_AGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHITEIGAI_RIYU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_AREA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_EIGYOSHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_ROMA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_KANA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_EMAIL_PC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_EMAIL_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_KEITAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_TEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEND_SAKI_FS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEND_SAKI_OTHER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCOUNT_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COST_CENTER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERNAL_ORDER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZETIA_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SHONIN_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_HOTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HOTEL_IRAINAIYOU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_HOTEL_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_HAKUSU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_HOTEL_SMOKING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_HOTEL_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_IRAINAIYOU_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_KOTSUKIKAN_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_DATE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_AIRPORT1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_AIRPORT2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TIME1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TIME2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_BIN_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_SEAT_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_SEAT_KIBOU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_IRAINAIYOU_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_KOTSUKIKAN_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_DATE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_AIRPORT1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_AIRPORT2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TIME1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TIME2_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_BIN_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_SEAT_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_SEAT_KIBOU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents Label35 As DataDynamics.ActiveReports.Label
    Private WithEvents Label36 As DataDynamics.ActiveReports.Label
    Private WithEvents Label37 As DataDynamics.ActiveReports.Label
    Private WithEvents Label38 As DataDynamics.ActiveReports.Label
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents Label44 As DataDynamics.ActiveReports.Label
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents Label46 As DataDynamics.ActiveReports.Label
    Private WithEvents Label47 As DataDynamics.ActiveReports.Label
    Private WithEvents Label48 As DataDynamics.ActiveReports.Label
    Private WithEvents Label49 As DataDynamics.ActiveReports.Label
    Private WithEvents Label50 As DataDynamics.ActiveReports.Label
    Private WithEvents Label51 As DataDynamics.ActiveReports.Label
    Private WithEvents Label52 As DataDynamics.ActiveReports.Label
    Private WithEvents Label53 As DataDynamics.ActiveReports.Label
    Private WithEvents Label54 As DataDynamics.ActiveReports.Label
    Private WithEvents Label56 As DataDynamics.ActiveReports.Label
    Private WithEvents Label57 As DataDynamics.ActiveReports.Label
    Private WithEvents Label58 As DataDynamics.ActiveReports.Label
    Private WithEvents Label59 As DataDynamics.ActiveReports.Label
    Private WithEvents Label60 As DataDynamics.ActiveReports.Label
    Private WithEvents Label61 As DataDynamics.ActiveReports.Label
    Private WithEvents Label62 As DataDynamics.ActiveReports.Label
    Private WithEvents Label63 As DataDynamics.ActiveReports.Label
    Private WithEvents Label64 As DataDynamics.ActiveReports.Label
    Private WithEvents Label65 As DataDynamics.ActiveReports.Label
    Private WithEvents Label66 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKASHA_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_KANA As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SHISETSU_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SHISETSU_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SHISETSU_ADDRESS As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_YAKUWARI As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SEX As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_AGE As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHITEIGAI_RIYU As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_AREA As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_EIGYOSHO As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_ROMA As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_KANA As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_EMAIL_PC As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_EMAIL_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_KEITAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_TEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEND_SAKI_FS As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEND_SAKI_OTHER As DataDynamics.ActiveReports.TextBox
    Private WithEvents ACCOUNT_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents COST_CENTER As DataDynamics.ActiveReports.TextBox
    Private WithEvents INTERNAL_ORDER As DataDynamics.ActiveReports.TextBox
    Private WithEvents ZETIA_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_HOTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents HOTEL_IRAINAIYOU As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HAKUSU As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL_SMOKING As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_KIBOU1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_KIBOU1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
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
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents Line33 As DataDynamics.ActiveReports.Line
    Private WithEvents Line34 As DataDynamics.ActiveReports.Line
    Private WithEvents Line35 As DataDynamics.ActiveReports.Line
    Private WithEvents Line36 As DataDynamics.ActiveReports.Line
    Private WithEvents Line37 As DataDynamics.ActiveReports.Line
    Private WithEvents Line38 As DataDynamics.ActiveReports.Line
    Private WithEvents Line39 As DataDynamics.ActiveReports.Line
    Private WithEvents Line40 As DataDynamics.ActiveReports.Line
    Private WithEvents Line41 As DataDynamics.ActiveReports.Line
    Private WithEvents Line42 As DataDynamics.ActiveReports.Line
    Private WithEvents Line43 As DataDynamics.ActiveReports.Line
    Private WithEvents Line44 As DataDynamics.ActiveReports.Line
    Private WithEvents Line45 As DataDynamics.ActiveReports.Line
    Private WithEvents Line46 As DataDynamics.ActiveReports.Line
    Private WithEvents Line47 As DataDynamics.ActiveReports.Line
    Private WithEvents Line48 As DataDynamics.ActiveReports.Line
    Private WithEvents Line49 As DataDynamics.ActiveReports.Line
    Private WithEvents Line50 As DataDynamics.ActiveReports.Line
    Private WithEvents Line51 As DataDynamics.ActiveReports.Line
    Private WithEvents Line52 As DataDynamics.ActiveReports.Line
    Private WithEvents Line53 As DataDynamics.ActiveReports.Line
    Private WithEvents Line54 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Shape3 As DataDynamics.ActiveReports.Shape
End Class 
