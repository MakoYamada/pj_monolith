<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrReport3
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrReport3))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
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
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.SANKASHA_ID = New DataDynamics.ActiveReports.TextBox
        Me.DR_CD = New DataDynamics.ActiveReports.TextBox
        Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.DR_KANA = New DataDynamics.ActiveReports.TextBox
        Me.DR_SHISETSU_CD = New DataDynamics.ActiveReports.TextBox
        Me.REQ_KOTSU_BIKO = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_1 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_1 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Label20 = New DataDynamics.ActiveReports.Label
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
        Me.REQ_TAXI_DATE_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_3 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_4 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_5 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.Line39 = New DataDynamics.ActiveReports.Line
        Me.Line40 = New DataDynamics.ActiveReports.Line
        Me.Line52 = New DataDynamics.ActiveReports.Line
        Me.Label73 = New DataDynamics.ActiveReports.Label
        Me.Label74 = New DataDynamics.ActiveReports.Label
        Me.Label75 = New DataDynamics.ActiveReports.Label
        Me.Label76 = New DataDynamics.ActiveReports.Label
        Me.Label77 = New DataDynamics.ActiveReports.Label
        Me.Label78 = New DataDynamics.ActiveReports.Label
        Me.Label79 = New DataDynamics.ActiveReports.Label
        Me.Label80 = New DataDynamics.ActiveReports.Label
        Me.Label81 = New DataDynamics.ActiveReports.Label
        Me.Label82 = New DataDynamics.ActiveReports.Label
        Me.Label83 = New DataDynamics.ActiveReports.Label
        Me.Label84 = New DataDynamics.ActiveReports.Label
        Me.Label85 = New DataDynamics.ActiveReports.Label
        Me.Label86 = New DataDynamics.ActiveReports.Label
        Me.Label98 = New DataDynamics.ActiveReports.Label
        Me.Label99 = New DataDynamics.ActiveReports.Label
        Me.TAXI_YOTEIKINGAKU_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_6 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_6 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_6 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_7 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_7 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_7 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_8 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_8 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_8 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_9 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_9 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_9 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_DATE_10 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_10 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_10 = New DataDynamics.ActiveReports.TextBox
        Me.TEHAI_TAXI = New DataDynamics.ActiveReports.TextBox
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
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
        Me.REQ_O_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_IRAINAIYOU_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_KOTSUKIKAN_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_DATE_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_AIRPORT1_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_AIRPORT2_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TIME1_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TIME2_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_BIN_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_SEAT_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_IRAINAIYOU_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_KOTSUKIKAN_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_DATE_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_AIRPORT1_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_AIRPORT2_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TIME1_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TIME2_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_BIN_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_SEAT_5 = New DataDynamics.ActiveReports.TextBox
        Me.Line42 = New DataDynamics.ActiveReports.Line
        Me.Line43 = New DataDynamics.ActiveReports.Line
        Me.Line44 = New DataDynamics.ActiveReports.Line
        Me.Line45 = New DataDynamics.ActiveReports.Line
        Me.Line46 = New DataDynamics.ActiveReports.Line
        Me.Line47 = New DataDynamics.ActiveReports.Line
        Me.Line48 = New DataDynamics.ActiveReports.Line
        Me.Line49 = New DataDynamics.ActiveReports.Line
        Me.Line50 = New DataDynamics.ActiveReports.Line
        Me.Line54 = New DataDynamics.ActiveReports.Line
        Me.Label55 = New DataDynamics.ActiveReports.Label
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
        Me.Label97 = New DataDynamics.ActiveReports.Label
        Me.REQ_O_SEAT_KIBOU5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_SEAT_KIBOU5 = New DataDynamics.ActiveReports.TextBox
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Shape3 = New DataDynamics.ActiveReports.Shape
        Me.Line35 = New DataDynamics.ActiveReports.Line
        Me.Line36 = New DataDynamics.ActiveReports.Line
        Me.Shape4 = New DataDynamics.ActiveReports.Shape
        Me.Line37 = New DataDynamics.ActiveReports.Line
        Me.Line38 = New DataDynamics.ActiveReports.Line
        Me.Line41 = New DataDynamics.ActiveReports.Line
        Me.Line51 = New DataDynamics.ActiveReports.Line
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_KANA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SHISETSU_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_KOTSU_BIKO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.REQ_TAXI_DATE_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.REQ_O_TEHAI_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_IRAINAIYOU_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_KOTSUKIKAN_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_DATE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_AIRPORT1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_AIRPORT2_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TIME1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TIME2_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_BIN_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_SEAT_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_IRAINAIYOU_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_KOTSUKIKAN_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_DATE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_AIRPORT1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_AIRPORT2_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TIME1_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TIME2_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_BIN_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_SEAT_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Label97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_SEAT_KIBOU5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_SEAT_KIBOU5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Shape1.Height = 0.2740157!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.6409448!
        Me.Shape1.Width = 7.165354!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center"
        Me.Label3.Text = "交通宿泊手配依頼"
        Me.Label3.Top = 0.6740159!
        Me.Label3.Width = 7.165354!
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
        Me.Label1.Width = 0.5834652!
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
        Me.Label2.Top = 0.2!
        Me.Label2.Width = 0.7291334!
        '
        'USER_NAME
        '
        Me.USER_NAME.Height = 0.2!
        Me.USER_NAME.Left = 5.946457!
        Me.USER_NAME.Name = "USER_NAME"
        Me.USER_NAME.Style = "white-space: nowrap"
        Me.USER_NAME.Text = "1234/56/78 12:34:56"
        Me.USER_NAME.Top = 0.2!
        Me.USER_NAME.Width = 1.218898!
        '
        'Label4
        '
        Me.Label4.Height = 0.2!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.446457!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: right"
        Me.Label4.Text = "(3/4ページ)"
        Me.Label4.Top = 0.4409449!
        Me.Label4.Width = 0.7188979!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape4, Me.Shape3, Me.Shape2, Me.Label5, Me.KOUENKAI_NAME, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label19, Me.Label21, Me.Label22, Me.Label23, Me.KOUENKAI_NO, Me.REQ_STATUS_TEHAI, Me.TIME_STAMP_BYL, Me.SANKASHA_ID, Me.DR_CD, Me.DR_NAME, Me.DR_KANA, Me.DR_SHISETSU_CD, Me.REQ_KOTSU_BIKO, Me.REQ_TAXI_DATE_1, Me.REQ_TAXI_FROM_1, Me.TAXI_YOTEIKINGAKU_1, Me.Line1, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Label20, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.REQ_TAXI_DATE_2, Me.REQ_TAXI_FROM_2, Me.REQ_TAXI_DATE_3, Me.REQ_TAXI_FROM_3, Me.TAXI_YOTEIKINGAKU_3, Me.REQ_TAXI_DATE_4, Me.REQ_TAXI_FROM_4, Me.TAXI_YOTEIKINGAKU_4, Me.REQ_TAXI_DATE_5, Me.REQ_TAXI_FROM_5, Me.TAXI_YOTEIKINGAKU_5, Me.REQ_TAXI_NOTE, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Line28, Me.Line34, Me.Line39, Me.Line40, Me.Line52, Me.Label73, Me.Label74, Me.Label75, Me.Label76, Me.Label77, Me.Label78, Me.Label79, Me.Label80, Me.Label81, Me.Label82, Me.Label83, Me.Label84, Me.Label85, Me.Label86, Me.Label98, Me.Label99, Me.TAXI_YOTEIKINGAKU_2, Me.REQ_TAXI_DATE_6, Me.REQ_TAXI_FROM_6, Me.TAXI_YOTEIKINGAKU_6, Me.REQ_TAXI_DATE_7, Me.REQ_TAXI_FROM_7, Me.TAXI_YOTEIKINGAKU_7, Me.REQ_TAXI_DATE_8, Me.REQ_TAXI_FROM_8, Me.TAXI_YOTEIKINGAKU_8, Me.REQ_TAXI_DATE_9, Me.REQ_TAXI_FROM_9, Me.TAXI_YOTEIKINGAKU_9, Me.REQ_TAXI_DATE_10, Me.REQ_TAXI_FROM_10, Me.TAXI_YOTEIKINGAKU_10, Me.TEHAI_TAXI, Me.Line13, Me.Line18, Me.REQ_O_TEHAI_5, Me.Label45, Me.Label46, Me.Label47, Me.Label48, Me.Label49, Me.Label50, Me.Label51, Me.Label52, Me.Label53, Me.Label54, Me.REQ_F_SEAT_KIBOU5, Me.REQ_O_IRAINAIYOU_5, Me.REQ_O_KOTSUKIKAN_5, Me.REQ_O_DATE_5, Me.REQ_O_AIRPORT1_5, Me.REQ_O_AIRPORT2_5, Me.REQ_O_TIME1_5, Me.REQ_O_TIME2_5, Me.REQ_O_BIN_5, Me.REQ_O_SEAT_5, Me.REQ_F_TEHAI_5, Me.REQ_F_IRAINAIYOU_5, Me.REQ_F_KOTSUKIKAN_5, Me.REQ_F_DATE_5, Me.REQ_F_AIRPORT1_5, Me.REQ_F_AIRPORT2_5, Me.REQ_F_TIME1_5, Me.REQ_F_TIME2_5, Me.REQ_F_BIN_5, Me.REQ_F_SEAT_5, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line54, Me.Label55, Me.Label57, Me.Label58, Me.Label59, Me.Label60, Me.Label61, Me.Label62, Me.Label63, Me.Label64, Me.Label65, Me.Label66, Me.Label97, Me.REQ_O_SEAT_KIBOU5, Me.Shape1, Me.Label3, Me.Label1, Me.PRINT_DATE, Me.Label2, Me.USER_NAME, Me.Label4, Me.Line23, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line29, Me.Line35, Me.Line36, Me.Line37, Me.Line38, Me.Line41, Me.Line51})
        Me.Detail.Height = 10.18558!
        Me.Detail.Name = "Detail"
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
        Me.Label5.Text = "講演会名："
        Me.Label5.Top = 0.9897639!
        Me.Label5.Width = 0.8437006!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2!
        Me.KOUENKAI_NAME.Left = 0.8437006!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-weight: bold; white-space: nowrap"
        Me.KOUENKAI_NAME.Text = Nothing
        Me.KOUENKAI_NAME.Top = 0.9897639!
        Me.KOUENKAI_NAME.Width = 6.321654!
        '
        'Label6
        '
        Me.Label6.Height = 0.2!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "white-space: nowrap"
        Me.Label6.Text = "講演会番号"
        Me.Label6.Top = 1.189764!
        Me.Label6.Width = 1.771654!
        '
        'Label7
        '
        Me.Label7.Height = 0.2!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.0!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "white-space: nowrap"
        Me.Label7.Text = "手配ステータス(依頼)"
        Me.Label7.Top = 1.389764!
        Me.Label7.Width = 1.771654!
        '
        'Label8
        '
        Me.Label8.Height = 0.2!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.0!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "white-space: nowrap"
        Me.Label8.Text = "Timestamp(BYL)"
        Me.Label8.Top = 1.589764!
        Me.Label8.Width = 1.771654!
        '
        'Label9
        '
        Me.Label9.Height = 0.2!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 0.0!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "white-space: nowrap"
        Me.Label9.Text = "MTP ID(参加者ID)"
        Me.Label9.Top = 1.789764!
        Me.Label9.Width = 1.771654!
        '
        'Label10
        '
        Me.Label10.Height = 0.2!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.0!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "white-space: nowrap"
        Me.Label10.Text = "DRコード"
        Me.Label10.Top = 1.989764!
        Me.Label10.Width = 1.771654!
        '
        'Label11
        '
        Me.Label11.Height = 0.2!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.0!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "white-space: nowrap"
        Me.Label11.Text = "DR氏名"
        Me.Label11.Top = 2.189764!
        Me.Label11.Width = 1.771654!
        '
        'Label12
        '
        Me.Label12.Height = 0.2!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.0!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "white-space: nowrap"
        Me.Label12.Text = "DR氏名(半角ｶﾀｶﾅ)"
        Me.Label12.Top = 2.389764!
        Me.Label12.Width = 1.771654!
        '
        'Label13
        '
        Me.Label13.Height = 0.2!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "white-space: nowrap"
        Me.Label13.Text = "DCF施設コード"
        Me.Label13.Top = 2.589764!
        Me.Label13.Width = 1.771654!
        '
        'Label14
        '
        Me.Label14.Height = 0.2!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "white-space: nowrap"
        Me.Label14.Text = "交通備考(依頼)"
        Me.Label14.Top = 4.989764!
        Me.Label14.Width = 1.771654!
        '
        'Label19
        '
        Me.Label19.Height = 0.2!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.0!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "white-space: nowrap"
        Me.Label19.Text = "タクシーチケット(有・無)"
        Me.Label19.Top = 5.989765!
        Me.Label19.Width = 1.771654!
        '
        'Label21
        '
        Me.Label21.Height = 0.2!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.0!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "white-space: nowrap"
        Me.Label21.Text = "行程1：利用日(依頼)"
        Me.Label21.Top = 6.189764!
        Me.Label21.Width = 1.771654!
        '
        'Label22
        '
        Me.Label22.Height = 0.2!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.0!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "white-space: nowrap"
        Me.Label22.Text = "行程1：発地(依頼)"
        Me.Label22.Top = 6.389765!
        Me.Label22.Width = 1.771654!
        '
        'Label23
        '
        Me.Label23.Height = 0.2!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 0.0!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "white-space: nowrap"
        Me.Label23.Text = "行程1：依頼金額(依頼)"
        Me.Label23.Top = 6.589766!
        Me.Label23.Width = 1.771654!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.2!
        Me.KOUENKAI_NO.Left = 1.771654!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Text = Nothing
        Me.KOUENKAI_NO.Top = 1.189764!
        Me.KOUENKAI_NO.Width = 5.393702!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Height = 0.2!
        Me.REQ_STATUS_TEHAI.Left = 1.771654!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Text = Nothing
        Me.REQ_STATUS_TEHAI.Top = 1.389764!
        Me.REQ_STATUS_TEHAI.Width = 5.393702!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Height = 0.2!
        Me.TIME_STAMP_BYL.Left = 1.771654!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Text = Nothing
        Me.TIME_STAMP_BYL.Top = 1.589764!
        Me.TIME_STAMP_BYL.Width = 5.393702!
        '
        'SANKASHA_ID
        '
        Me.SANKASHA_ID.DataField = "SANKASHA_ID"
        Me.SANKASHA_ID.Height = 0.2!
        Me.SANKASHA_ID.Left = 1.771654!
        Me.SANKASHA_ID.Name = "SANKASHA_ID"
        Me.SANKASHA_ID.Text = Nothing
        Me.SANKASHA_ID.Top = 1.789764!
        Me.SANKASHA_ID.Width = 5.393702!
        '
        'DR_CD
        '
        Me.DR_CD.DataField = "DR_CD"
        Me.DR_CD.Height = 0.2!
        Me.DR_CD.Left = 1.771654!
        Me.DR_CD.Name = "DR_CD"
        Me.DR_CD.Text = Nothing
        Me.DR_CD.Top = 1.989764!
        Me.DR_CD.Width = 5.393702!
        '
        'DR_NAME
        '
        Me.DR_NAME.DataField = "DR_NAME"
        Me.DR_NAME.Height = 0.2!
        Me.DR_NAME.Left = 1.771654!
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.Text = Nothing
        Me.DR_NAME.Top = 2.189764!
        Me.DR_NAME.Width = 5.393702!
        '
        'DR_KANA
        '
        Me.DR_KANA.DataField = "DR_KANA"
        Me.DR_KANA.Height = 0.2!
        Me.DR_KANA.Left = 1.771654!
        Me.DR_KANA.Name = "DR_KANA"
        Me.DR_KANA.Text = Nothing
        Me.DR_KANA.Top = 2.389764!
        Me.DR_KANA.Width = 5.393702!
        '
        'DR_SHISETSU_CD
        '
        Me.DR_SHISETSU_CD.DataField = "DR_SHISETSU_CD"
        Me.DR_SHISETSU_CD.Height = 0.2!
        Me.DR_SHISETSU_CD.Left = 1.771654!
        Me.DR_SHISETSU_CD.Name = "DR_SHISETSU_CD"
        Me.DR_SHISETSU_CD.Text = Nothing
        Me.DR_SHISETSU_CD.Top = 2.589764!
        Me.DR_SHISETSU_CD.Width = 5.393702!
        '
        'REQ_KOTSU_BIKO
        '
        Me.REQ_KOTSU_BIKO.DataField = "REQ_KOTSU_BIKO"
        Me.REQ_KOTSU_BIKO.Height = 1.0!
        Me.REQ_KOTSU_BIKO.Left = 1.771654!
        Me.REQ_KOTSU_BIKO.Name = "REQ_KOTSU_BIKO"
        Me.REQ_KOTSU_BIKO.Text = Nothing
        Me.REQ_KOTSU_BIKO.Top = 4.989764!
        Me.REQ_KOTSU_BIKO.Width = 5.393701!
        '
        'REQ_TAXI_DATE_1
        '
        Me.REQ_TAXI_DATE_1.DataField = "REQ_TAXI_DATE_1"
        Me.REQ_TAXI_DATE_1.Height = 0.2!
        Me.REQ_TAXI_DATE_1.Left = 1.771654!
        Me.REQ_TAXI_DATE_1.Name = "REQ_TAXI_DATE_1"
        Me.REQ_TAXI_DATE_1.Text = Nothing
        Me.REQ_TAXI_DATE_1.Top = 6.189764!
        Me.REQ_TAXI_DATE_1.Width = 1.811024!
        '
        'REQ_TAXI_FROM_1
        '
        Me.REQ_TAXI_FROM_1.DataField = "REQ_TAXI_FROM_1"
        Me.REQ_TAXI_FROM_1.Height = 0.2!
        Me.REQ_TAXI_FROM_1.Left = 1.771654!
        Me.REQ_TAXI_FROM_1.Name = "REQ_TAXI_FROM_1"
        Me.REQ_TAXI_FROM_1.Text = Nothing
        Me.REQ_TAXI_FROM_1.Top = 6.389765!
        Me.REQ_TAXI_FROM_1.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_1
        '
        Me.TAXI_YOTEIKINGAKU_1.DataField = "TAXI_YOTEIKINGAKU_1"
        Me.TAXI_YOTEIKINGAKU_1.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_1.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_1.Name = "TAXI_YOTEIKINGAKU_1"
        Me.TAXI_YOTEIKINGAKU_1.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_1.Top = 6.589766!
        Me.TAXI_YOTEIKINGAKU_1.Width = 1.811024!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 4.989764!
        Me.Line1.Width = 7.165354!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.165354!
        Me.Line1.Y1 = 4.989764!
        Me.Line1.Y2 = 4.989764!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.389764!
        Me.Line3.Width = 7.165354!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.165354!
        Me.Line3.Y1 = 1.389764!
        Me.Line3.Y2 = 1.389764!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.589764!
        Me.Line4.Width = 7.165354!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.165354!
        Me.Line4.Y1 = 1.589764!
        Me.Line4.Y2 = 1.589764!
        '
        'Line5
        '
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.0!
        Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.789764!
        Me.Line5.Width = 7.165354!
        Me.Line5.X1 = 0.0!
        Me.Line5.X2 = 7.165354!
        Me.Line5.Y1 = 1.789764!
        Me.Line5.Y2 = 1.789764!
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0!
        Me.Line6.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.989764!
        Me.Line6.Width = 7.165354!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 7.165354!
        Me.Line6.Y1 = 1.989764!
        Me.Line6.Y2 = 1.989764!
        '
        'Line7
        '
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 0.0!
        Me.Line7.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 2.189764!
        Me.Line7.Width = 7.165354!
        Me.Line7.X1 = 0.0!
        Me.Line7.X2 = 7.165354!
        Me.Line7.Y1 = 2.189764!
        Me.Line7.Y2 = 2.189764!
        '
        'Line8
        '
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.0!
        Me.Line8.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 2.389764!
        Me.Line8.Width = 7.165354!
        Me.Line8.X1 = 0.0!
        Me.Line8.X2 = 7.165354!
        Me.Line8.Y1 = 2.389764!
        Me.Line8.Y2 = 2.389764!
        '
        'Line9
        '
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.0!
        Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 2.589764!
        Me.Line9.Width = 7.165354!
        Me.Line9.X1 = 0.0!
        Me.Line9.X2 = 7.165354!
        Me.Line9.Y1 = 2.589764!
        Me.Line9.Y2 = 2.589764!
        '
        'Line14
        '
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 0.0!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 5.989765!
        Me.Line14.Width = 7.165354!
        Me.Line14.X1 = 0.0!
        Me.Line14.X2 = 7.165354!
        Me.Line14.Y1 = 5.989765!
        Me.Line14.Y2 = 5.989765!
        '
        'Line15
        '
        Me.Line15.Height = 0.0!
        Me.Line15.Left = 0.0!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 6.189764!
        Me.Line15.Width = 7.165354!
        Me.Line15.X1 = 0.0!
        Me.Line15.X2 = 7.165354!
        Me.Line15.Y1 = 6.189764!
        Me.Line15.Y2 = 6.189764!
        '
        'Line16
        '
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 0.0!
        Me.Line16.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 6.389765!
        Me.Line16.Width = 7.165354!
        Me.Line16.X1 = 0.0!
        Me.Line16.X2 = 7.165354!
        Me.Line16.Y1 = 6.389765!
        Me.Line16.Y2 = 6.389765!
        '
        'Line17
        '
        Me.Line17.Height = 0.0!
        Me.Line17.Left = 0.0!
        Me.Line17.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 6.589766!
        Me.Line17.Width = 7.165354!
        Me.Line17.X1 = 0.0!
        Me.Line17.X2 = 7.165354!
        Me.Line17.Y1 = 6.589766!
        Me.Line17.Y2 = 6.589766!
        '
        'Label20
        '
        Me.Label20.Height = 0.2!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.0!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "white-space: nowrap"
        Me.Label20.Text = "行程2：利用日(依頼)"
        Me.Label20.Top = 6.789764!
        Me.Label20.Width = 1.771654!
        '
        'Label24
        '
        Me.Label24.Height = 0.2!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 0.0!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "white-space: nowrap"
        Me.Label24.Text = "行程2：発地(依頼)"
        Me.Label24.Top = 6.989765!
        Me.Label24.Width = 1.771654!
        '
        'Label25
        '
        Me.Label25.Height = 0.2!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.0!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "white-space: nowrap"
        Me.Label25.Text = "行程3：利用日(依頼)"
        Me.Label25.Top = 7.389765!
        Me.Label25.Width = 1.771653!
        '
        'Label26
        '
        Me.Label26.Height = 0.2!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.0!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "white-space: nowrap"
        Me.Label26.Text = "行程3：発地(依頼)"
        Me.Label26.Top = 7.589765!
        Me.Label26.Width = 1.771653!
        '
        'Label27
        '
        Me.Label27.Height = 0.2!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 0.0!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "white-space: nowrap"
        Me.Label27.Text = "行程3：依頼金額(依頼)"
        Me.Label27.Top = 7.789765!
        Me.Label27.Width = 1.771653!
        '
        'Label28
        '
        Me.Label28.Height = 0.2!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 0.0!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "white-space: nowrap"
        Me.Label28.Text = "行程4：利用日(依頼)"
        Me.Label28.Top = 7.989766!
        Me.Label28.Width = 1.771653!
        '
        'Label29
        '
        Me.Label29.Height = 0.2!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.0!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "white-space: nowrap"
        Me.Label29.Text = "行程4：発地(依頼)"
        Me.Label29.Top = 8.189765!
        Me.Label29.Width = 1.771653!
        '
        'Label30
        '
        Me.Label30.Height = 0.2!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 0.0!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "white-space: nowrap"
        Me.Label30.Text = "行程4：依頼金額(依頼)"
        Me.Label30.Top = 8.389764!
        Me.Label30.Width = 1.771653!
        '
        'Label31
        '
        Me.Label31.Height = 0.2!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 0.0!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "white-space: nowrap"
        Me.Label31.Text = "行程5：利用日(依頼)"
        Me.Label31.Top = 8.589765!
        Me.Label31.Width = 1.771653!
        '
        'Label32
        '
        Me.Label32.Height = 0.2!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 0.0!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "white-space: nowrap"
        Me.Label32.Text = "行程5：発地(依頼)"
        Me.Label32.Top = 8.789765!
        Me.Label32.Width = 1.771653!
        '
        'Label33
        '
        Me.Label33.Height = 0.2!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 0.0!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "white-space: nowrap"
        Me.Label33.Text = "行程5：依頼金額(依頼)"
        Me.Label33.Top = 8.989766!
        Me.Label33.Width = 1.771653!
        '
        'Label34
        '
        Me.Label34.Height = 0.2!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 0.0!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "white-space: nowrap"
        Me.Label34.Text = "タクチケ備考 (依頼)"
        Me.Label34.Top = 9.189765!
        Me.Label34.Width = 1.771653!
        '
        'REQ_TAXI_DATE_2
        '
        Me.REQ_TAXI_DATE_2.DataField = "REQ_TAXI_DATE_2"
        Me.REQ_TAXI_DATE_2.Height = 0.2!
        Me.REQ_TAXI_DATE_2.Left = 1.771654!
        Me.REQ_TAXI_DATE_2.Name = "REQ_TAXI_DATE_2"
        Me.REQ_TAXI_DATE_2.Text = Nothing
        Me.REQ_TAXI_DATE_2.Top = 6.789764!
        Me.REQ_TAXI_DATE_2.Width = 1.811024!
        '
        'REQ_TAXI_FROM_2
        '
        Me.REQ_TAXI_FROM_2.DataField = "REQ_TAXI_FROM_2"
        Me.REQ_TAXI_FROM_2.Height = 0.2!
        Me.REQ_TAXI_FROM_2.Left = 1.771654!
        Me.REQ_TAXI_FROM_2.Name = "REQ_TAXI_FROM_2"
        Me.REQ_TAXI_FROM_2.Text = Nothing
        Me.REQ_TAXI_FROM_2.Top = 6.989765!
        Me.REQ_TAXI_FROM_2.Width = 1.811024!
        '
        'REQ_TAXI_DATE_3
        '
        Me.REQ_TAXI_DATE_3.DataField = "REQ_TAXI_DATE_3"
        Me.REQ_TAXI_DATE_3.Height = 0.2!
        Me.REQ_TAXI_DATE_3.Left = 1.771654!
        Me.REQ_TAXI_DATE_3.Name = "REQ_TAXI_DATE_3"
        Me.REQ_TAXI_DATE_3.Text = Nothing
        Me.REQ_TAXI_DATE_3.Top = 7.389765!
        Me.REQ_TAXI_DATE_3.Width = 1.811024!
        '
        'REQ_TAXI_FROM_3
        '
        Me.REQ_TAXI_FROM_3.DataField = "REQ_TAXI_FROM_3"
        Me.REQ_TAXI_FROM_3.Height = 0.2!
        Me.REQ_TAXI_FROM_3.Left = 1.771654!
        Me.REQ_TAXI_FROM_3.Name = "REQ_TAXI_FROM_3"
        Me.REQ_TAXI_FROM_3.Text = Nothing
        Me.REQ_TAXI_FROM_3.Top = 7.589765!
        Me.REQ_TAXI_FROM_3.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_3
        '
        Me.TAXI_YOTEIKINGAKU_3.DataField = "TAXI_YOTEIKINGAKU_3"
        Me.TAXI_YOTEIKINGAKU_3.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_3.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_3.Name = "TAXI_YOTEIKINGAKU_3"
        Me.TAXI_YOTEIKINGAKU_3.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_3.Top = 7.789765!
        Me.TAXI_YOTEIKINGAKU_3.Width = 1.811024!
        '
        'REQ_TAXI_DATE_4
        '
        Me.REQ_TAXI_DATE_4.DataField = "REQ_TAXI_DATE_4"
        Me.REQ_TAXI_DATE_4.Height = 0.2!
        Me.REQ_TAXI_DATE_4.Left = 1.771654!
        Me.REQ_TAXI_DATE_4.Name = "REQ_TAXI_DATE_4"
        Me.REQ_TAXI_DATE_4.Text = Nothing
        Me.REQ_TAXI_DATE_4.Top = 7.989766!
        Me.REQ_TAXI_DATE_4.Width = 1.811024!
        '
        'REQ_TAXI_FROM_4
        '
        Me.REQ_TAXI_FROM_4.DataField = "REQ_TAXI_FROM_4"
        Me.REQ_TAXI_FROM_4.Height = 0.2!
        Me.REQ_TAXI_FROM_4.Left = 1.771654!
        Me.REQ_TAXI_FROM_4.Name = "REQ_TAXI_FROM_4"
        Me.REQ_TAXI_FROM_4.Text = Nothing
        Me.REQ_TAXI_FROM_4.Top = 8.189765!
        Me.REQ_TAXI_FROM_4.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_4
        '
        Me.TAXI_YOTEIKINGAKU_4.DataField = "TAXI_YOTEIKINGAKU_4"
        Me.TAXI_YOTEIKINGAKU_4.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_4.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_4.Name = "TAXI_YOTEIKINGAKU_4"
        Me.TAXI_YOTEIKINGAKU_4.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_4.Top = 8.389764!
        Me.TAXI_YOTEIKINGAKU_4.Width = 1.811024!
        '
        'REQ_TAXI_DATE_5
        '
        Me.REQ_TAXI_DATE_5.DataField = "REQ_TAXI_DATE_5"
        Me.REQ_TAXI_DATE_5.Height = 0.2!
        Me.REQ_TAXI_DATE_5.Left = 1.771654!
        Me.REQ_TAXI_DATE_5.Name = "REQ_TAXI_DATE_5"
        Me.REQ_TAXI_DATE_5.Text = Nothing
        Me.REQ_TAXI_DATE_5.Top = 8.589765!
        Me.REQ_TAXI_DATE_5.Width = 1.811024!
        '
        'REQ_TAXI_FROM_5
        '
        Me.REQ_TAXI_FROM_5.DataField = "REQ_TAXI_FROM_5"
        Me.REQ_TAXI_FROM_5.Height = 0.2!
        Me.REQ_TAXI_FROM_5.Left = 1.771654!
        Me.REQ_TAXI_FROM_5.Name = "REQ_TAXI_FROM_5"
        Me.REQ_TAXI_FROM_5.Text = Nothing
        Me.REQ_TAXI_FROM_5.Top = 8.789765!
        Me.REQ_TAXI_FROM_5.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_5
        '
        Me.TAXI_YOTEIKINGAKU_5.DataField = "TAXI_YOTEIKINGAKU_5"
        Me.TAXI_YOTEIKINGAKU_5.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_5.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_5.Name = "TAXI_YOTEIKINGAKU_5"
        Me.TAXI_YOTEIKINGAKU_5.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_5.Top = 8.989766!
        Me.TAXI_YOTEIKINGAKU_5.Width = 1.811024!
        '
        'REQ_TAXI_NOTE
        '
        Me.REQ_TAXI_NOTE.DataField = "REQ_TAXI_NOTE"
        Me.REQ_TAXI_NOTE.Height = 1.0!
        Me.REQ_TAXI_NOTE.Left = 1.771654!
        Me.REQ_TAXI_NOTE.Name = "REQ_TAXI_NOTE"
        Me.REQ_TAXI_NOTE.Text = Nothing
        Me.REQ_TAXI_NOTE.Top = 9.189765!
        Me.REQ_TAXI_NOTE.Width = 5.393701!
        '
        'Line19
        '
        Me.Line19.Height = 0.0!
        Me.Line19.Left = 0.0!
        Me.Line19.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 6.989765!
        Me.Line19.Width = 7.165354!
        Me.Line19.X1 = 0.0!
        Me.Line19.X2 = 7.165354!
        Me.Line19.Y1 = 6.989765!
        Me.Line19.Y2 = 6.989765!
        '
        'Line20
        '
        Me.Line20.Height = 0.0!
        Me.Line20.Left = 0.0!
        Me.Line20.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 7.189764!
        Me.Line20.Width = 7.165354!
        Me.Line20.X1 = 0.0!
        Me.Line20.X2 = 7.165354!
        Me.Line20.Y1 = 7.189764!
        Me.Line20.Y2 = 7.189764!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.0!
        Me.Line21.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 7.589765!
        Me.Line21.Width = 7.165354!
        Me.Line21.X1 = 0.0!
        Me.Line21.X2 = 7.165354!
        Me.Line21.Y1 = 7.589765!
        Me.Line21.Y2 = 7.589765!
        '
        'Line22
        '
        Me.Line22.Height = 0.0!
        Me.Line22.Left = 0.0!
        Me.Line22.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 7.789765!
        Me.Line22.Width = 7.165354!
        Me.Line22.X1 = 0.0!
        Me.Line22.X2 = 7.165354!
        Me.Line22.Y1 = 7.789765!
        Me.Line22.Y2 = 7.789765!
        '
        'Line24
        '
        Me.Line24.Height = 0.0!
        Me.Line24.Left = 0.0!
        Me.Line24.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 8.189765!
        Me.Line24.Width = 7.165354!
        Me.Line24.X1 = 0.0!
        Me.Line24.X2 = 7.165354!
        Me.Line24.Y1 = 8.189765!
        Me.Line24.Y2 = 8.189765!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.0!
        Me.Line25.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 8.389764!
        Me.Line25.Width = 7.165354!
        Me.Line25.X1 = 0.0!
        Me.Line25.X2 = 7.165354!
        Me.Line25.Y1 = 8.389764!
        Me.Line25.Y2 = 8.389764!
        '
        'Line26
        '
        Me.Line26.Height = 0.0!
        Me.Line26.Left = 0.0!
        Me.Line26.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 8.589765!
        Me.Line26.Width = 7.165354!
        Me.Line26.X1 = 0.0!
        Me.Line26.X2 = 7.165354!
        Me.Line26.Y1 = 8.589765!
        Me.Line26.Y2 = 8.589765!
        '
        'Line27
        '
        Me.Line27.Height = 0.0!
        Me.Line27.Left = 0.0!
        Me.Line27.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 8.789765!
        Me.Line27.Width = 7.165354!
        Me.Line27.X1 = 0.0!
        Me.Line27.X2 = 7.165354!
        Me.Line27.Y1 = 8.789765!
        Me.Line27.Y2 = 8.789765!
        '
        'Line28
        '
        Me.Line28.Height = 0.0!
        Me.Line28.Left = 0.0!
        Me.Line28.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 8.989764!
        Me.Line28.Width = 7.165354!
        Me.Line28.X1 = 0.0!
        Me.Line28.X2 = 7.165354!
        Me.Line28.Y1 = 8.989764!
        Me.Line28.Y2 = 8.989764!
        '
        'Line34
        '
        Me.Line34.Height = 0.0!
        Me.Line34.Left = 0.0!
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 10.18976!
        Me.Line34.Width = 7.165354!
        Me.Line34.X1 = 0.0!
        Me.Line34.X2 = 7.165354!
        Me.Line34.Y1 = 10.18976!
        Me.Line34.Y2 = 10.18976!
        '
        'Line39
        '
        Me.Line39.Height = 0.0!
        Me.Line39.Left = 0.0!
        Me.Line39.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line39.LineWeight = 1.0!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 6.789764!
        Me.Line39.Width = 7.165354!
        Me.Line39.X1 = 0.0!
        Me.Line39.X2 = 7.165354!
        Me.Line39.Y1 = 6.789764!
        Me.Line39.Y2 = 6.789764!
        '
        'Line40
        '
        Me.Line40.Height = 9.0!
        Me.Line40.Left = 1.771654!
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 1.189764!
        Me.Line40.Width = 0.0!
        Me.Line40.X1 = 1.771654!
        Me.Line40.X2 = 1.771654!
        Me.Line40.Y1 = 1.189764!
        Me.Line40.Y2 = 10.18976!
        '
        'Line52
        '
        Me.Line52.Height = 3.0!
        Me.Line52.Left = 5.354331!
        Me.Line52.LineWeight = 1.0!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 6.189764!
        Me.Line52.Width = 0.0!
        Me.Line52.X1 = 5.354331!
        Me.Line52.X2 = 5.354331!
        Me.Line52.Y1 = 6.189764!
        Me.Line52.Y2 = 9.189764!
        '
        'Label73
        '
        Me.Label73.Height = 0.2!
        Me.Label73.HyperLink = Nothing
        Me.Label73.Left = 3.582677!
        Me.Label73.Name = "Label73"
        Me.Label73.Style = "white-space: nowrap"
        Me.Label73.Text = "行程6：利用日(依頼)"
        Me.Label73.Top = 6.189764!
        Me.Label73.Width = 1.771654!
        '
        'Label74
        '
        Me.Label74.Height = 0.2!
        Me.Label74.HyperLink = Nothing
        Me.Label74.Left = 3.582677!
        Me.Label74.Name = "Label74"
        Me.Label74.Style = "white-space: nowrap"
        Me.Label74.Text = "行程6：発地(依頼)"
        Me.Label74.Top = 6.389765!
        Me.Label74.Width = 1.771654!
        '
        'Label75
        '
        Me.Label75.Height = 0.2!
        Me.Label75.HyperLink = Nothing
        Me.Label75.Left = 3.582677!
        Me.Label75.Name = "Label75"
        Me.Label75.Style = "white-space: nowrap"
        Me.Label75.Text = "行程6：依頼金額(依頼)"
        Me.Label75.Top = 6.589766!
        Me.Label75.Width = 1.771654!
        '
        'Label76
        '
        Me.Label76.Height = 0.2!
        Me.Label76.HyperLink = Nothing
        Me.Label76.Left = 3.582677!
        Me.Label76.Name = "Label76"
        Me.Label76.Style = "white-space: nowrap"
        Me.Label76.Text = "行程7：利用日(依頼)"
        Me.Label76.Top = 6.789764!
        Me.Label76.Width = 1.771654!
        '
        'Label77
        '
        Me.Label77.Height = 0.2!
        Me.Label77.HyperLink = Nothing
        Me.Label77.Left = 3.582677!
        Me.Label77.Name = "Label77"
        Me.Label77.Style = "white-space: nowrap"
        Me.Label77.Text = "行程7：発地(依頼)"
        Me.Label77.Top = 6.989765!
        Me.Label77.Width = 1.771654!
        '
        'Label78
        '
        Me.Label78.Height = 0.2!
        Me.Label78.HyperLink = Nothing
        Me.Label78.Left = 3.582677!
        Me.Label78.Name = "Label78"
        Me.Label78.Style = "white-space: nowrap"
        Me.Label78.Text = "行程8：利用日(依頼)"
        Me.Label78.Top = 7.389765!
        Me.Label78.Width = 1.771653!
        '
        'Label79
        '
        Me.Label79.Height = 0.2!
        Me.Label79.HyperLink = Nothing
        Me.Label79.Left = 3.582677!
        Me.Label79.Name = "Label79"
        Me.Label79.Style = "white-space: nowrap"
        Me.Label79.Text = "行程8：発地(依頼)"
        Me.Label79.Top = 7.589767!
        Me.Label79.Width = 1.771653!
        '
        'Label80
        '
        Me.Label80.Height = 0.2!
        Me.Label80.HyperLink = Nothing
        Me.Label80.Left = 3.582677!
        Me.Label80.Name = "Label80"
        Me.Label80.Style = "white-space: nowrap"
        Me.Label80.Text = "行程8：依頼金額(依頼)"
        Me.Label80.Top = 7.789765!
        Me.Label80.Width = 1.771653!
        '
        'Label81
        '
        Me.Label81.Height = 0.2!
        Me.Label81.HyperLink = Nothing
        Me.Label81.Left = 3.582677!
        Me.Label81.Name = "Label81"
        Me.Label81.Style = "white-space: nowrap"
        Me.Label81.Text = "行程9：利用日(依頼)"
        Me.Label81.Top = 7.989766!
        Me.Label81.Width = 1.771653!
        '
        'Label82
        '
        Me.Label82.Height = 0.2!
        Me.Label82.HyperLink = Nothing
        Me.Label82.Left = 3.582677!
        Me.Label82.Name = "Label82"
        Me.Label82.Style = "white-space: nowrap"
        Me.Label82.Text = "行程9：発地(依頼)"
        Me.Label82.Top = 8.189765!
        Me.Label82.Width = 1.771653!
        '
        'Label83
        '
        Me.Label83.Height = 0.2!
        Me.Label83.HyperLink = Nothing
        Me.Label83.Left = 3.582677!
        Me.Label83.Name = "Label83"
        Me.Label83.Style = "white-space: nowrap"
        Me.Label83.Text = "行程9：依頼金額 (依頼)"
        Me.Label83.Top = 8.389766!
        Me.Label83.Width = 1.771653!
        '
        'Label84
        '
        Me.Label84.Height = 0.2!
        Me.Label84.HyperLink = Nothing
        Me.Label84.Left = 3.582677!
        Me.Label84.Name = "Label84"
        Me.Label84.Style = "white-space: nowrap"
        Me.Label84.Text = "行程１0：利用日 (依頼)"
        Me.Label84.Top = 8.589767!
        Me.Label84.Width = 1.771653!
        '
        'Label85
        '
        Me.Label85.Height = 0.2!
        Me.Label85.HyperLink = Nothing
        Me.Label85.Left = 3.582677!
        Me.Label85.Name = "Label85"
        Me.Label85.Style = "white-space: nowrap"
        Me.Label85.Text = "行程１0：発地 (依頼)"
        Me.Label85.Top = 8.789765!
        Me.Label85.Width = 1.771653!
        '
        'Label86
        '
        Me.Label86.Height = 0.2!
        Me.Label86.HyperLink = Nothing
        Me.Label86.Left = 3.582677!
        Me.Label86.Name = "Label86"
        Me.Label86.Style = "white-space: nowrap"
        Me.Label86.Text = "行程１0：依頼金額 (依頼)"
        Me.Label86.Top = 8.989766!
        Me.Label86.Width = 1.771653!
        '
        'Label98
        '
        Me.Label98.Height = 0.2!
        Me.Label98.HyperLink = Nothing
        Me.Label98.Left = 0.0!
        Me.Label98.Name = "Label98"
        Me.Label98.Style = "white-space: nowrap"
        Me.Label98.Text = "行程2：依頼金額(依頼)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label98.Top = 7.189764!
        Me.Label98.Width = 1.771654!
        '
        'Label99
        '
        Me.Label99.Height = 0.2!
        Me.Label99.HyperLink = Nothing
        Me.Label99.Left = 3.582677!
        Me.Label99.Name = "Label99"
        Me.Label99.Style = "white-space: nowrap"
        Me.Label99.Text = "行程7：依頼金額(依頼)"
        Me.Label99.Top = 7.189764!
        Me.Label99.Width = 1.771654!
        '
        'TAXI_YOTEIKINGAKU_2
        '
        Me.TAXI_YOTEIKINGAKU_2.DataField = "TAXI_YOTEIKINGAKU_2"
        Me.TAXI_YOTEIKINGAKU_2.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_2.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_2.Name = "TAXI_YOTEIKINGAKU_2"
        Me.TAXI_YOTEIKINGAKU_2.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_2.Top = 7.189764!
        Me.TAXI_YOTEIKINGAKU_2.Width = 1.811024!
        '
        'REQ_TAXI_DATE_6
        '
        Me.REQ_TAXI_DATE_6.DataField = "REQ_TAXI_DATE_6"
        Me.REQ_TAXI_DATE_6.Height = 0.2!
        Me.REQ_TAXI_DATE_6.Left = 5.354331!
        Me.REQ_TAXI_DATE_6.Name = "REQ_TAXI_DATE_6"
        Me.REQ_TAXI_DATE_6.Text = Nothing
        Me.REQ_TAXI_DATE_6.Top = 6.189764!
        Me.REQ_TAXI_DATE_6.Width = 1.811024!
        '
        'REQ_TAXI_FROM_6
        '
        Me.REQ_TAXI_FROM_6.DataField = "REQ_TAXI_FROM_6"
        Me.REQ_TAXI_FROM_6.Height = 0.2!
        Me.REQ_TAXI_FROM_6.Left = 5.354331!
        Me.REQ_TAXI_FROM_6.Name = "REQ_TAXI_FROM_6"
        Me.REQ_TAXI_FROM_6.Text = Nothing
        Me.REQ_TAXI_FROM_6.Top = 6.389765!
        Me.REQ_TAXI_FROM_6.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_6
        '
        Me.TAXI_YOTEIKINGAKU_6.DataField = "TAXI_YOTEIKINGAKU_6"
        Me.TAXI_YOTEIKINGAKU_6.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_6.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_6.Name = "TAXI_YOTEIKINGAKU_6"
        Me.TAXI_YOTEIKINGAKU_6.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_6.Top = 6.589766!
        Me.TAXI_YOTEIKINGAKU_6.Width = 1.811024!
        '
        'REQ_TAXI_DATE_7
        '
        Me.REQ_TAXI_DATE_7.DataField = "REQ_TAXI_DATE_7"
        Me.REQ_TAXI_DATE_7.Height = 0.2!
        Me.REQ_TAXI_DATE_7.Left = 5.354331!
        Me.REQ_TAXI_DATE_7.Name = "REQ_TAXI_DATE_7"
        Me.REQ_TAXI_DATE_7.Text = Nothing
        Me.REQ_TAXI_DATE_7.Top = 6.789764!
        Me.REQ_TAXI_DATE_7.Width = 1.811024!
        '
        'REQ_TAXI_FROM_7
        '
        Me.REQ_TAXI_FROM_7.DataField = "REQ_TAXI_FROM_7"
        Me.REQ_TAXI_FROM_7.Height = 0.2!
        Me.REQ_TAXI_FROM_7.Left = 5.354331!
        Me.REQ_TAXI_FROM_7.Name = "REQ_TAXI_FROM_7"
        Me.REQ_TAXI_FROM_7.Text = Nothing
        Me.REQ_TAXI_FROM_7.Top = 6.989765!
        Me.REQ_TAXI_FROM_7.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_7
        '
        Me.TAXI_YOTEIKINGAKU_7.DataField = "TAXI_YOTEIKINGAKU_7"
        Me.TAXI_YOTEIKINGAKU_7.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_7.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_7.Name = "TAXI_YOTEIKINGAKU_7"
        Me.TAXI_YOTEIKINGAKU_7.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_7.Top = 7.189764!
        Me.TAXI_YOTEIKINGAKU_7.Width = 1.811024!
        '
        'REQ_TAXI_DATE_8
        '
        Me.REQ_TAXI_DATE_8.DataField = "REQ_TAXI_DATE_8"
        Me.REQ_TAXI_DATE_8.Height = 0.2!
        Me.REQ_TAXI_DATE_8.Left = 5.354331!
        Me.REQ_TAXI_DATE_8.Name = "REQ_TAXI_DATE_8"
        Me.REQ_TAXI_DATE_8.Text = Nothing
        Me.REQ_TAXI_DATE_8.Top = 7.389765!
        Me.REQ_TAXI_DATE_8.Width = 1.811024!
        '
        'REQ_TAXI_FROM_8
        '
        Me.REQ_TAXI_FROM_8.DataField = "REQ_TAXI_FROM_8"
        Me.REQ_TAXI_FROM_8.Height = 0.2!
        Me.REQ_TAXI_FROM_8.Left = 5.354331!
        Me.REQ_TAXI_FROM_8.Name = "REQ_TAXI_FROM_8"
        Me.REQ_TAXI_FROM_8.Text = Nothing
        Me.REQ_TAXI_FROM_8.Top = 7.589765!
        Me.REQ_TAXI_FROM_8.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_8
        '
        Me.TAXI_YOTEIKINGAKU_8.DataField = "TAXI_YOTEIKINGAKU_8"
        Me.TAXI_YOTEIKINGAKU_8.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_8.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_8.Name = "TAXI_YOTEIKINGAKU_8"
        Me.TAXI_YOTEIKINGAKU_8.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_8.Top = 7.789765!
        Me.TAXI_YOTEIKINGAKU_8.Width = 1.811024!
        '
        'REQ_TAXI_DATE_9
        '
        Me.REQ_TAXI_DATE_9.DataField = "REQ_TAXI_DATE_9"
        Me.REQ_TAXI_DATE_9.Height = 0.2!
        Me.REQ_TAXI_DATE_9.Left = 5.354331!
        Me.REQ_TAXI_DATE_9.Name = "REQ_TAXI_DATE_9"
        Me.REQ_TAXI_DATE_9.Text = Nothing
        Me.REQ_TAXI_DATE_9.Top = 7.989764!
        Me.REQ_TAXI_DATE_9.Width = 1.811024!
        '
        'REQ_TAXI_FROM_9
        '
        Me.REQ_TAXI_FROM_9.DataField = "REQ_TAXI_FROM_9"
        Me.REQ_TAXI_FROM_9.Height = 0.2!
        Me.REQ_TAXI_FROM_9.Left = 5.354331!
        Me.REQ_TAXI_FROM_9.Name = "REQ_TAXI_FROM_9"
        Me.REQ_TAXI_FROM_9.Text = Nothing
        Me.REQ_TAXI_FROM_9.Top = 8.189765!
        Me.REQ_TAXI_FROM_9.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_9
        '
        Me.TAXI_YOTEIKINGAKU_9.DataField = "TAXI_YOTEIKINGAKU_9"
        Me.TAXI_YOTEIKINGAKU_9.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_9.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_9.Name = "TAXI_YOTEIKINGAKU_9"
        Me.TAXI_YOTEIKINGAKU_9.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_9.Top = 8.389764!
        Me.TAXI_YOTEIKINGAKU_9.Width = 1.811024!
        '
        'REQ_TAXI_DATE_10
        '
        Me.REQ_TAXI_DATE_10.DataField = "REQ_TAXI_DATE_10"
        Me.REQ_TAXI_DATE_10.Height = 0.2!
        Me.REQ_TAXI_DATE_10.Left = 5.354331!
        Me.REQ_TAXI_DATE_10.Name = "REQ_TAXI_DATE_10"
        Me.REQ_TAXI_DATE_10.Text = Nothing
        Me.REQ_TAXI_DATE_10.Top = 8.589767!
        Me.REQ_TAXI_DATE_10.Width = 1.811024!
        '
        'REQ_TAXI_FROM_10
        '
        Me.REQ_TAXI_FROM_10.DataField = "REQ_TAXI_FROM_10"
        Me.REQ_TAXI_FROM_10.Height = 0.2!
        Me.REQ_TAXI_FROM_10.Left = 5.354331!
        Me.REQ_TAXI_FROM_10.Name = "REQ_TAXI_FROM_10"
        Me.REQ_TAXI_FROM_10.Text = Nothing
        Me.REQ_TAXI_FROM_10.Top = 8.789765!
        Me.REQ_TAXI_FROM_10.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_10
        '
        Me.TAXI_YOTEIKINGAKU_10.DataField = "TAXI_YOTEIKINGAKU_10"
        Me.TAXI_YOTEIKINGAKU_10.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_10.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_10.Name = "TAXI_YOTEIKINGAKU_10"
        Me.TAXI_YOTEIKINGAKU_10.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_10.Top = 8.989764!
        Me.TAXI_YOTEIKINGAKU_10.Width = 1.811024!
        '
        'TEHAI_TAXI
        '
        Me.TEHAI_TAXI.DataField = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Height = 0.2!
        Me.TEHAI_TAXI.Left = 1.771654!
        Me.TEHAI_TAXI.Name = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Text = Nothing
        Me.TEHAI_TAXI.Top = 5.989765!
        Me.TEHAI_TAXI.Width = 5.393701!
        '
        'Line13
        '
        Me.Line13.Height = 2.2!
        Me.Line13.Left = 3.582677!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 2.789764!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 3.582677!
        Me.Line13.X2 = 3.582677!
        Me.Line13.Y1 = 2.789764!
        Me.Line13.Y2 = 4.989764!
        '
        'Line18
        '
        Me.Line18.Height = 2.2!
        Me.Line18.Left = 5.354331!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 2.789764!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 5.354331!
        Me.Line18.X2 = 5.354331!
        Me.Line18.Y1 = 2.789764!
        Me.Line18.Y2 = 4.989764!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label45
        '
        Me.Label45.Height = 0.2!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 0.0000002384186!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "white-space: nowrap"
        Me.Label45.Text = "往路5：希望する(依頼)"
        Me.Label45.Top = 2.789764!
        Me.Label45.Width = 1.771653!
        '
        'Label46
        '
        Me.Label46.Height = 0.2!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.0000002384186!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "white-space: nowrap"
        Me.Label46.Text = "往路5：依頼内容(依頼)"
        Me.Label46.Top = 2.989764!
        Me.Label46.Width = 1.771653!
        '
        'Label47
        '
        Me.Label47.Height = 0.2!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 0.0000002384186!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "white-space: nowrap"
        Me.Label47.Text = "往路5：交通機関(依頼)"
        Me.Label47.Top = 3.189757!
        Me.Label47.Width = 1.771653!
        '
        'Label48
        '
        Me.Label48.Height = 0.2!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 0.0000002384186!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "white-space: nowrap"
        Me.Label48.Text = "往路5：利用日(依頼)"
        Me.Label48.Top = 3.389758!
        Me.Label48.Width = 1.771653!
        '
        'Label49
        '
        Me.Label49.Height = 0.2!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 0.0000002384186!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "white-space: nowrap"
        Me.Label49.Text = "往路5：出発地(依頼)"
        Me.Label49.Top = 3.589757!
        Me.Label49.Width = 1.771653!
        '
        'Label50
        '
        Me.Label50.Height = 0.2!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 0.0000002384186!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "white-space: nowrap"
        Me.Label50.Text = "往路5：到着地(依頼)"
        Me.Label50.Top = 3.789757!
        Me.Label50.Width = 1.771653!
        '
        'Label51
        '
        Me.Label51.Height = 0.2!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 0.0000002384186!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "white-space: nowrap"
        Me.Label51.Text = "往路5：出発時間(依頼)"
        Me.Label51.Top = 3.989757!
        Me.Label51.Width = 1.771653!
        '
        'Label52
        '
        Me.Label52.Height = 0.2!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 0.0000002384186!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "white-space: nowrap"
        Me.Label52.Text = "往路5：到着時間(依頼)"
        Me.Label52.Top = 4.189757!
        Me.Label52.Width = 1.771653!
        '
        'Label53
        '
        Me.Label53.Height = 0.2!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 0.0000002384186!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "white-space: nowrap"
        Me.Label53.Text = "往路5：列車名・便名(依頼)"
        Me.Label53.Top = 4.389758!
        Me.Label53.Width = 1.771653!
        '
        'Label54
        '
        Me.Label54.Height = 0.2!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 0.0000002384186!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "white-space: nowrap"
        Me.Label54.Text = "往路5：座席区分(依頼)"
        Me.Label54.Top = 4.589764!
        Me.Label54.Width = 1.771653!
        '
        'REQ_O_TEHAI_5
        '
        Me.REQ_O_TEHAI_5.DataField = "REQ_O_TEHAI_5"
        Me.REQ_O_TEHAI_5.Height = 0.1999998!
        Me.REQ_O_TEHAI_5.Left = 1.771654!
        Me.REQ_O_TEHAI_5.Name = "REQ_O_TEHAI_5"
        Me.REQ_O_TEHAI_5.Text = Nothing
        Me.REQ_O_TEHAI_5.Top = 2.789764!
        Me.REQ_O_TEHAI_5.Width = 1.811024!
        '
        'REQ_O_IRAINAIYOU_5
        '
        Me.REQ_O_IRAINAIYOU_5.DataField = "REQ_O_IRAINAIYOU_5"
        Me.REQ_O_IRAINAIYOU_5.Height = 0.1999998!
        Me.REQ_O_IRAINAIYOU_5.Left = 1.771654!
        Me.REQ_O_IRAINAIYOU_5.Name = "REQ_O_IRAINAIYOU_5"
        Me.REQ_O_IRAINAIYOU_5.Text = Nothing
        Me.REQ_O_IRAINAIYOU_5.Top = 2.989764!
        Me.REQ_O_IRAINAIYOU_5.Width = 1.811024!
        '
        'REQ_O_KOTSUKIKAN_5
        '
        Me.REQ_O_KOTSUKIKAN_5.DataField = "REQ_O_KOTSUKIKAN_5"
        Me.REQ_O_KOTSUKIKAN_5.Height = 0.1999998!
        Me.REQ_O_KOTSUKIKAN_5.Left = 1.771654!
        Me.REQ_O_KOTSUKIKAN_5.Name = "REQ_O_KOTSUKIKAN_5"
        Me.REQ_O_KOTSUKIKAN_5.Text = Nothing
        Me.REQ_O_KOTSUKIKAN_5.Top = 3.189757!
        Me.REQ_O_KOTSUKIKAN_5.Width = 1.811024!
        '
        'REQ_O_DATE_5
        '
        Me.REQ_O_DATE_5.DataField = "REQ_O_DATE_5"
        Me.REQ_O_DATE_5.Height = 0.1999998!
        Me.REQ_O_DATE_5.Left = 1.771654!
        Me.REQ_O_DATE_5.Name = "REQ_O_DATE_5"
        Me.REQ_O_DATE_5.Text = Nothing
        Me.REQ_O_DATE_5.Top = 3.389758!
        Me.REQ_O_DATE_5.Width = 1.811024!
        '
        'REQ_O_AIRPORT1_5
        '
        Me.REQ_O_AIRPORT1_5.DataField = "REQ_O_AIRPORT1_5"
        Me.REQ_O_AIRPORT1_5.Height = 0.1999998!
        Me.REQ_O_AIRPORT1_5.Left = 1.771654!
        Me.REQ_O_AIRPORT1_5.Name = "REQ_O_AIRPORT1_5"
        Me.REQ_O_AIRPORT1_5.Text = Nothing
        Me.REQ_O_AIRPORT1_5.Top = 3.589757!
        Me.REQ_O_AIRPORT1_5.Width = 1.811024!
        '
        'REQ_O_AIRPORT2_5
        '
        Me.REQ_O_AIRPORT2_5.DataField = "REQ_O_AIRPORT2_5"
        Me.REQ_O_AIRPORT2_5.Height = 0.1999998!
        Me.REQ_O_AIRPORT2_5.Left = 1.771654!
        Me.REQ_O_AIRPORT2_5.Name = "REQ_O_AIRPORT2_5"
        Me.REQ_O_AIRPORT2_5.Text = Nothing
        Me.REQ_O_AIRPORT2_5.Top = 3.789757!
        Me.REQ_O_AIRPORT2_5.Width = 1.811024!
        '
        'REQ_O_TIME1_5
        '
        Me.REQ_O_TIME1_5.DataField = "REQ_O_TIME1_5"
        Me.REQ_O_TIME1_5.Height = 0.1999998!
        Me.REQ_O_TIME1_5.Left = 1.771654!
        Me.REQ_O_TIME1_5.Name = "REQ_O_TIME1_5"
        Me.REQ_O_TIME1_5.Text = Nothing
        Me.REQ_O_TIME1_5.Top = 3.989757!
        Me.REQ_O_TIME1_5.Width = 1.811024!
        '
        'REQ_O_TIME2_5
        '
        Me.REQ_O_TIME2_5.DataField = "REQ_O_TIME2_5"
        Me.REQ_O_TIME2_5.Height = 0.1999998!
        Me.REQ_O_TIME2_5.Left = 1.771654!
        Me.REQ_O_TIME2_5.Name = "REQ_O_TIME2_5"
        Me.REQ_O_TIME2_5.Text = Nothing
        Me.REQ_O_TIME2_5.Top = 4.189757!
        Me.REQ_O_TIME2_5.Width = 1.811024!
        '
        'REQ_O_BIN_5
        '
        Me.REQ_O_BIN_5.DataField = "REQ_O_BIN_5"
        Me.REQ_O_BIN_5.Height = 0.1999998!
        Me.REQ_O_BIN_5.Left = 1.771654!
        Me.REQ_O_BIN_5.Name = "REQ_O_BIN_5"
        Me.REQ_O_BIN_5.Text = Nothing
        Me.REQ_O_BIN_5.Top = 4.389758!
        Me.REQ_O_BIN_5.Width = 1.811024!
        '
        'REQ_O_SEAT_5
        '
        Me.REQ_O_SEAT_5.DataField = "REQ_O_SEAT_5"
        Me.REQ_O_SEAT_5.Height = 0.1999998!
        Me.REQ_O_SEAT_5.Left = 1.771654!
        Me.REQ_O_SEAT_5.Name = "REQ_O_SEAT_5"
        Me.REQ_O_SEAT_5.Text = Nothing
        Me.REQ_O_SEAT_5.Top = 4.589764!
        Me.REQ_O_SEAT_5.Width = 1.811024!
        '
        'REQ_F_TEHAI_5
        '
        Me.REQ_F_TEHAI_5.DataField = "REQ_F_TEHAI_5"
        Me.REQ_F_TEHAI_5.Height = 0.1999998!
        Me.REQ_F_TEHAI_5.Left = 5.354331!
        Me.REQ_F_TEHAI_5.Name = "REQ_F_TEHAI_5"
        Me.REQ_F_TEHAI_5.Text = Nothing
        Me.REQ_F_TEHAI_5.Top = 2.789764!
        Me.REQ_F_TEHAI_5.Width = 1.811024!
        '
        'REQ_F_IRAINAIYOU_5
        '
        Me.REQ_F_IRAINAIYOU_5.DataField = "REQ_F_IRAINAIYOU_5"
        Me.REQ_F_IRAINAIYOU_5.Height = 0.1999998!
        Me.REQ_F_IRAINAIYOU_5.Left = 5.354331!
        Me.REQ_F_IRAINAIYOU_5.Name = "REQ_F_IRAINAIYOU_5"
        Me.REQ_F_IRAINAIYOU_5.Text = Nothing
        Me.REQ_F_IRAINAIYOU_5.Top = 2.989764!
        Me.REQ_F_IRAINAIYOU_5.Width = 1.811024!
        '
        'REQ_F_KOTSUKIKAN_5
        '
        Me.REQ_F_KOTSUKIKAN_5.DataField = "REQ_F_KOTSUKIKAN_5"
        Me.REQ_F_KOTSUKIKAN_5.Height = 0.1999998!
        Me.REQ_F_KOTSUKIKAN_5.Left = 5.354331!
        Me.REQ_F_KOTSUKIKAN_5.Name = "REQ_F_KOTSUKIKAN_5"
        Me.REQ_F_KOTSUKIKAN_5.Text = Nothing
        Me.REQ_F_KOTSUKIKAN_5.Top = 3.189757!
        Me.REQ_F_KOTSUKIKAN_5.Width = 1.811024!
        '
        'REQ_F_DATE_5
        '
        Me.REQ_F_DATE_5.DataField = "REQ_F_DATE_5"
        Me.REQ_F_DATE_5.Height = 0.1999998!
        Me.REQ_F_DATE_5.Left = 5.354331!
        Me.REQ_F_DATE_5.Name = "REQ_F_DATE_5"
        Me.REQ_F_DATE_5.Text = Nothing
        Me.REQ_F_DATE_5.Top = 3.389758!
        Me.REQ_F_DATE_5.Width = 1.811024!
        '
        'REQ_F_AIRPORT1_5
        '
        Me.REQ_F_AIRPORT1_5.DataField = "REQ_F_AIRPORT1_5"
        Me.REQ_F_AIRPORT1_5.Height = 0.1999998!
        Me.REQ_F_AIRPORT1_5.Left = 5.354331!
        Me.REQ_F_AIRPORT1_5.Name = "REQ_F_AIRPORT1_5"
        Me.REQ_F_AIRPORT1_5.Text = Nothing
        Me.REQ_F_AIRPORT1_5.Top = 3.589757!
        Me.REQ_F_AIRPORT1_5.Width = 1.811024!
        '
        'REQ_F_AIRPORT2_5
        '
        Me.REQ_F_AIRPORT2_5.DataField = "REQ_F_AIRPORT2_5"
        Me.REQ_F_AIRPORT2_5.Height = 0.1999998!
        Me.REQ_F_AIRPORT2_5.Left = 5.354331!
        Me.REQ_F_AIRPORT2_5.Name = "REQ_F_AIRPORT2_5"
        Me.REQ_F_AIRPORT2_5.Text = Nothing
        Me.REQ_F_AIRPORT2_5.Top = 3.789757!
        Me.REQ_F_AIRPORT2_5.Width = 1.811024!
        '
        'REQ_F_TIME1_5
        '
        Me.REQ_F_TIME1_5.DataField = "REQ_F_TIME1_5"
        Me.REQ_F_TIME1_5.Height = 0.1999998!
        Me.REQ_F_TIME1_5.Left = 5.354331!
        Me.REQ_F_TIME1_5.Name = "REQ_F_TIME1_5"
        Me.REQ_F_TIME1_5.Text = Nothing
        Me.REQ_F_TIME1_5.Top = 3.989757!
        Me.REQ_F_TIME1_5.Width = 1.811024!
        '
        'REQ_F_TIME2_5
        '
        Me.REQ_F_TIME2_5.DataField = "REQ_F_TIME2_5"
        Me.REQ_F_TIME2_5.Height = 0.1999998!
        Me.REQ_F_TIME2_5.Left = 5.354331!
        Me.REQ_F_TIME2_5.Name = "REQ_F_TIME2_5"
        Me.REQ_F_TIME2_5.Text = Nothing
        Me.REQ_F_TIME2_5.Top = 4.189757!
        Me.REQ_F_TIME2_5.Width = 1.811024!
        '
        'REQ_F_BIN_5
        '
        Me.REQ_F_BIN_5.DataField = "REQ_F_BIN_5"
        Me.REQ_F_BIN_5.Height = 0.1999998!
        Me.REQ_F_BIN_5.Left = 5.354331!
        Me.REQ_F_BIN_5.Name = "REQ_F_BIN_5"
        Me.REQ_F_BIN_5.Text = Nothing
        Me.REQ_F_BIN_5.Top = 4.389758!
        Me.REQ_F_BIN_5.Width = 1.811024!
        '
        'REQ_F_SEAT_5
        '
        Me.REQ_F_SEAT_5.DataField = "REQ_F_SEAT_5"
        Me.REQ_F_SEAT_5.Height = 0.1999998!
        Me.REQ_F_SEAT_5.Left = 5.354331!
        Me.REQ_F_SEAT_5.Name = "REQ_F_SEAT_5"
        Me.REQ_F_SEAT_5.Text = Nothing
        Me.REQ_F_SEAT_5.Top = 4.589764!
        Me.REQ_F_SEAT_5.Width = 1.811024!
        '
        'Line42
        '
        Me.Line42.Height = 0.0!
        Me.Line42.Left = 0.0000002384186!
        Me.Line42.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line42.LineWeight = 1.0!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 2.989764!
        Me.Line42.Width = 7.165354!
        Me.Line42.X1 = 0.0000002384186!
        Me.Line42.X2 = 7.165354!
        Me.Line42.Y1 = 2.989764!
        Me.Line42.Y2 = 2.989764!
        '
        'Line43
        '
        Me.Line43.Height = 0.0!
        Me.Line43.Left = 0.0000002384186!
        Me.Line43.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line43.LineWeight = 1.0!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 3.189757!
        Me.Line43.Width = 7.165354!
        Me.Line43.X1 = 0.0000002384186!
        Me.Line43.X2 = 7.165354!
        Me.Line43.Y1 = 3.189757!
        Me.Line43.Y2 = 3.189757!
        '
        'Line44
        '
        Me.Line44.Height = 0.0!
        Me.Line44.Left = 0.0000002384186!
        Me.Line44.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line44.LineWeight = 1.0!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 3.389758!
        Me.Line44.Width = 7.165354!
        Me.Line44.X1 = 0.0000002384186!
        Me.Line44.X2 = 7.165354!
        Me.Line44.Y1 = 3.389758!
        Me.Line44.Y2 = 3.389758!
        '
        'Line45
        '
        Me.Line45.Height = 0.0!
        Me.Line45.Left = 0.0000002384186!
        Me.Line45.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line45.LineWeight = 1.0!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 3.589757!
        Me.Line45.Width = 7.165354!
        Me.Line45.X1 = 0.0000002384186!
        Me.Line45.X2 = 7.165354!
        Me.Line45.Y1 = 3.589757!
        Me.Line45.Y2 = 3.589757!
        '
        'Line46
        '
        Me.Line46.Height = 0.0!
        Me.Line46.Left = 0.0000002384186!
        Me.Line46.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line46.LineWeight = 1.0!
        Me.Line46.Name = "Line46"
        Me.Line46.Top = 3.789757!
        Me.Line46.Width = 7.165354!
        Me.Line46.X1 = 0.0000002384186!
        Me.Line46.X2 = 7.165354!
        Me.Line46.Y1 = 3.789757!
        Me.Line46.Y2 = 3.789757!
        '
        'Line47
        '
        Me.Line47.Height = 0.0!
        Me.Line47.Left = 0.0000002384186!
        Me.Line47.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line47.LineWeight = 1.0!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 3.98975!
        Me.Line47.Width = 7.165354!
        Me.Line47.X1 = 0.0000002384186!
        Me.Line47.X2 = 7.165354!
        Me.Line47.Y1 = 3.98975!
        Me.Line47.Y2 = 3.98975!
        '
        'Line48
        '
        Me.Line48.Height = 0.0!
        Me.Line48.Left = 0.0000002384186!
        Me.Line48.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line48.LineWeight = 1.0!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 4.18975!
        Me.Line48.Width = 7.165354!
        Me.Line48.X1 = 0.0000002384186!
        Me.Line48.X2 = 7.165354!
        Me.Line48.Y1 = 4.18975!
        Me.Line48.Y2 = 4.18975!
        '
        'Line49
        '
        Me.Line49.Height = 0.0!
        Me.Line49.Left = 0.0000002384186!
        Me.Line49.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line49.LineWeight = 1.0!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 4.389751!
        Me.Line49.Width = 7.165354!
        Me.Line49.X1 = 0.0000002384186!
        Me.Line49.X2 = 7.165354!
        Me.Line49.Y1 = 4.389751!
        Me.Line49.Y2 = 4.389751!
        '
        'Line50
        '
        Me.Line50.Height = 0.0!
        Me.Line50.Left = 0.0000002384186!
        Me.Line50.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line50.LineWeight = 1.0!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 4.589751!
        Me.Line50.Width = 7.165354!
        Me.Line50.X1 = 0.0000002384186!
        Me.Line50.X2 = 7.165354!
        Me.Line50.Y1 = 4.589751!
        Me.Line50.Y2 = 4.589751!
        '
        'Line54
        '
        Me.Line54.Height = 0.0!
        Me.Line54.Left = 0.0000002384186!
        Me.Line54.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line54.LineWeight = 1.0!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 4.789751!
        Me.Line54.Width = 7.165354!
        Me.Line54.X1 = 0.0000002384186!
        Me.Line54.X2 = 7.165354!
        Me.Line54.Y1 = 4.789751!
        Me.Line54.Y2 = 4.789751!
        '
        'Label55
        '
        Me.Label55.Height = 0.2!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 0.0!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "white-space: nowrap"
        Me.Label55.Text = "往路5：座席希望(依頼)"
        Me.Label55.Top = 4.789757!
        Me.Label55.Width = 1.771653!
        '
        'Label57
        '
        Me.Label57.Height = 0.2!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 3.582677!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "white-space: nowrap"
        Me.Label57.Text = "復路5：希望する(依頼)"
        Me.Label57.Top = 2.789764!
        Me.Label57.Width = 1.771653!
        '
        'Label58
        '
        Me.Label58.Height = 0.2!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 3.582677!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "white-space: nowrap"
        Me.Label58.Text = "復路5：依頼内容(依頼)"
        Me.Label58.Top = 2.989764!
        Me.Label58.Width = 1.771653!
        '
        'Label59
        '
        Me.Label59.Height = 0.2!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 3.582677!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "white-space: nowrap"
        Me.Label59.Text = "復路5：交通機関(依頼)"
        Me.Label59.Top = 3.189764!
        Me.Label59.Width = 1.771653!
        '
        'Label60
        '
        Me.Label60.Height = 0.2!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 3.582677!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "white-space: nowrap"
        Me.Label60.Text = "復路5：利用日(依頼)"
        Me.Label60.Top = 3.389764!
        Me.Label60.Width = 1.771653!
        '
        'Label61
        '
        Me.Label61.Height = 0.2!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 3.582677!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "white-space: nowrap"
        Me.Label61.Text = "復路5：出発地(依頼)"
        Me.Label61.Top = 3.589764!
        Me.Label61.Width = 1.771653!
        '
        'Label62
        '
        Me.Label62.Height = 0.2!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 3.582677!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "white-space: nowrap"
        Me.Label62.Text = "復路5：到着地(依頼)"
        Me.Label62.Top = 3.789764!
        Me.Label62.Width = 1.771653!
        '
        'Label63
        '
        Me.Label63.Height = 0.2!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 3.582677!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "white-space: nowrap"
        Me.Label63.Text = "復路5：出発時間(依頼)"
        Me.Label63.Top = 3.989764!
        Me.Label63.Width = 1.771653!
        '
        'Label64
        '
        Me.Label64.Height = 0.2!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 3.582677!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "white-space: nowrap"
        Me.Label64.Text = "復路5：到着時間(依頼)"
        Me.Label64.Top = 4.189764!
        Me.Label64.Width = 1.771653!
        '
        'Label65
        '
        Me.Label65.Height = 0.2!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 3.582677!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "white-space: nowrap"
        Me.Label65.Text = "復路5：列車名・便名(依頼)"
        Me.Label65.Top = 4.389764!
        Me.Label65.Width = 1.771653!
        '
        'Label66
        '
        Me.Label66.Height = 0.2!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 3.582677!
        Me.Label66.Name = "Label66"
        Me.Label66.Style = "white-space: nowrap"
        Me.Label66.Text = "復路5：座席区分(依頼)"
        Me.Label66.Top = 4.589764!
        Me.Label66.Width = 1.771653!
        '
        'Label97
        '
        Me.Label97.Height = 0.2!
        Me.Label97.HyperLink = Nothing
        Me.Label97.Left = 3.582677!
        Me.Label97.Name = "Label97"
        Me.Label97.Style = "white-space: nowrap"
        Me.Label97.Text = "復路5：座席希望(依頼)"
        Me.Label97.Top = 4.789757!
        Me.Label97.Width = 1.771653!
        '
        'REQ_O_SEAT_KIBOU5
        '
        Me.REQ_O_SEAT_KIBOU5.DataField = "REQ_O_SEAT_KIBOU5"
        Me.REQ_O_SEAT_KIBOU5.Height = 0.1999998!
        Me.REQ_O_SEAT_KIBOU5.Left = 1.771654!
        Me.REQ_O_SEAT_KIBOU5.Name = "REQ_O_SEAT_KIBOU5"
        Me.REQ_O_SEAT_KIBOU5.Text = Nothing
        Me.REQ_O_SEAT_KIBOU5.Top = 4.789757!
        Me.REQ_O_SEAT_KIBOU5.Width = 1.811024!
        '
        'REQ_F_SEAT_KIBOU5
        '
        Me.REQ_F_SEAT_KIBOU5.DataField = "REQ_F_SEAT_KIBOU5"
        Me.REQ_F_SEAT_KIBOU5.Height = 0.1999998!
        Me.REQ_F_SEAT_KIBOU5.Left = 5.354331!
        Me.REQ_F_SEAT_KIBOU5.Name = "REQ_F_SEAT_KIBOU5"
        Me.REQ_F_SEAT_KIBOU5.Text = Nothing
        Me.REQ_F_SEAT_KIBOU5.Top = 4.789757!
        Me.REQ_F_SEAT_KIBOU5.Width = 1.811024!
        '
        'Line23
        '
        Me.Line23.Height = 9.0!
        Me.Line23.Left = 0.0!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.189764!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 0.0!
        Me.Line23.X2 = 0.0!
        Me.Line23.Y1 = 1.189764!
        Me.Line23.Y2 = 10.18976!
        '
        'Line30
        '
        Me.Line30.Height = 0.0!
        Me.Line30.Left = 0.0!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 10.18976!
        Me.Line30.Width = 7.165354!
        Me.Line30.X1 = 0.0!
        Me.Line30.X2 = 7.165354!
        Me.Line30.Y1 = 10.18976!
        Me.Line30.Y2 = 10.18976!
        '
        'Line31
        '
        Me.Line31.Height = 9.0!
        Me.Line31.Left = 7.165355!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 1.189764!
        Me.Line31.Width = 0.0!
        Me.Line31.X1 = 7.165355!
        Me.Line31.X2 = 7.165355!
        Me.Line31.Y1 = 1.189764!
        Me.Line31.Y2 = 10.18976!
        '
        'Line32
        '
        Me.Line32.Height = 0.0!
        Me.Line32.Left = 0.0!
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 1.189764!
        Me.Line32.Width = 7.165354!
        Me.Line32.X1 = 0.0!
        Me.Line32.X2 = 7.165354!
        Me.Line32.Y1 = 1.189764!
        Me.Line32.Y2 = 1.189764!
        '
        'Line33
        '
        Me.Line33.Height = 0.0!
        Me.Line33.Left = 0.0!
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 2.789764!
        Me.Line33.Width = 7.165354!
        Me.Line33.X1 = 0.0!
        Me.Line33.X2 = 7.165354!
        Me.Line33.Y1 = 2.789764!
        Me.Line33.Y2 = 2.789764!
        '
        'Line29
        '
        Me.Line29.Height = 0.0!
        Me.Line29.Left = 0.0!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 9.189764!
        Me.Line29.Width = 7.165354!
        Me.Line29.X1 = 0.0!
        Me.Line29.X2 = 7.165354!
        Me.Line29.Y1 = 9.189764!
        Me.Line29.Y2 = 9.189764!
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Shape2.Height = 9.0!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 1.189764!
        Me.Shape2.Width = 1.771654!
        '
        'Shape3
        '
        Me.Shape3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Shape3.Height = 2.2!
        Me.Shape3.Left = 3.582677!
        Me.Shape3.Name = "Shape3"
        Me.Shape3.RoundingRadius = 9.999999!
        Me.Shape3.Top = 2.789764!
        Me.Shape3.Width = 1.771654!
        '
        'Line35
        '
        Me.Line35.Height = 0.0!
        Me.Line35.Left = 0.0!
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 4.989764!
        Me.Line35.Width = 7.165354!
        Me.Line35.X1 = 0.0!
        Me.Line35.X2 = 7.165354!
        Me.Line35.Y1 = 4.989764!
        Me.Line35.Y2 = 4.989764!
        '
        'Line36
        '
        Me.Line36.Height = 0.0!
        Me.Line36.Left = 0.0!
        Me.Line36.LineWeight = 1.0!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 5.989764!
        Me.Line36.Width = 7.165354!
        Me.Line36.X1 = 0.0!
        Me.Line36.X2 = 7.165354!
        Me.Line36.Y1 = 5.989764!
        Me.Line36.Y2 = 5.989764!
        '
        'Shape4
        '
        Me.Shape4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Shape4.Height = 3.0!
        Me.Shape4.Left = 3.582677!
        Me.Shape4.Name = "Shape4"
        Me.Shape4.RoundingRadius = 9.999999!
        Me.Shape4.Top = 6.189764!
        Me.Shape4.Width = 1.771654!
        '
        'Line37
        '
        Me.Line37.Height = 3.0!
        Me.Line37.Left = 3.582677!
        Me.Line37.LineWeight = 1.0!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 6.189764!
        Me.Line37.Width = 0.0!
        Me.Line37.X1 = 3.582677!
        Me.Line37.X2 = 3.582677!
        Me.Line37.Y1 = 6.189764!
        Me.Line37.Y2 = 9.189764!
        '
        'Line38
        '
        Me.Line38.Height = 0.0!
        Me.Line38.Left = 0.0!
        Me.Line38.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line38.LineWeight = 1.0!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 7.389764!
        Me.Line38.Width = 7.165354!
        Me.Line38.X1 = 0.0!
        Me.Line38.X2 = 7.165354!
        Me.Line38.Y1 = 7.389764!
        Me.Line38.Y2 = 7.389764!
        '
        'Line41
        '
        Me.Line41.Height = 0.0!
        Me.Line41.Left = 0.0!
        Me.Line41.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line41.LineWeight = 1.0!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 6.789764!
        Me.Line41.Width = 7.165354!
        Me.Line41.X1 = 0.0!
        Me.Line41.X2 = 7.165354!
        Me.Line41.Y1 = 6.789764!
        Me.Line41.Y2 = 6.789764!
        '
        'Line51
        '
        Me.Line51.Height = 0.0!
        Me.Line51.Left = 0.0!
        Me.Line51.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line51.LineWeight = 1.0!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 7.989764!
        Me.Line51.Width = 7.165354!
        Me.Line51.X1 = 0.0!
        Me.Line51.X2 = 7.165354!
        Me.Line51.Y1 = 7.989764!
        Me.Line51.Y2 = 7.989764!
        '
        'DrReport3
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.165452!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USER_NAME, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_KANA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SHISETSU_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_KOTSU_BIKO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.REQ_TAXI_DATE_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.REQ_O_TEHAI_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_IRAINAIYOU_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_KOTSUKIKAN_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_DATE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_AIRPORT1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_AIRPORT2_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TIME1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TIME2_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_BIN_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_SEAT_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_IRAINAIYOU_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_KOTSUKIKAN_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_DATE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_AIRPORT1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_AIRPORT2_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TIME1_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TIME2_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_BIN_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_SEAT_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Label97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_SEAT_KIBOU5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_SEAT_KIBOU5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents USER_NAME As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKASHA_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_KANA As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SHISETSU_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_KOTSU_BIKO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
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
    Private WithEvents REQ_TAXI_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line34 As DataDynamics.ActiveReports.Line
    Private WithEvents Line39 As DataDynamics.ActiveReports.Line
    Private WithEvents Line40 As DataDynamics.ActiveReports.Line
    Private WithEvents Line52 As DataDynamics.ActiveReports.Line
    Private WithEvents Label73 As DataDynamics.ActiveReports.Label
    Private WithEvents Label74 As DataDynamics.ActiveReports.Label
    Private WithEvents Label75 As DataDynamics.ActiveReports.Label
    Private WithEvents Label76 As DataDynamics.ActiveReports.Label
    Private WithEvents Label77 As DataDynamics.ActiveReports.Label
    Private WithEvents Label78 As DataDynamics.ActiveReports.Label
    Private WithEvents Label79 As DataDynamics.ActiveReports.Label
    Private WithEvents Label80 As DataDynamics.ActiveReports.Label
    Private WithEvents Label81 As DataDynamics.ActiveReports.Label
    Private WithEvents Label82 As DataDynamics.ActiveReports.Label
    Private WithEvents Label83 As DataDynamics.ActiveReports.Label
    Private WithEvents Label84 As DataDynamics.ActiveReports.Label
    Private WithEvents Label85 As DataDynamics.ActiveReports.Label
    Private WithEvents Label86 As DataDynamics.ActiveReports.Label
    Private WithEvents Label98 As DataDynamics.ActiveReports.Label
    Private WithEvents Label99 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_TAXI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents REQ_O_TEHAI_5 As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents REQ_F_SEAT_KIBOU5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line42 As DataDynamics.ActiveReports.Line
    Private WithEvents Line43 As DataDynamics.ActiveReports.Line
    Private WithEvents Line44 As DataDynamics.ActiveReports.Line
    Private WithEvents Line45 As DataDynamics.ActiveReports.Line
    Private WithEvents Line46 As DataDynamics.ActiveReports.Line
    Private WithEvents Line47 As DataDynamics.ActiveReports.Line
    Private WithEvents Line48 As DataDynamics.ActiveReports.Line
    Private WithEvents Line49 As DataDynamics.ActiveReports.Line
    Private WithEvents Line50 As DataDynamics.ActiveReports.Line
    Private WithEvents Line54 As DataDynamics.ActiveReports.Line
    Private WithEvents Label55 As DataDynamics.ActiveReports.Label
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
    Private WithEvents Label97 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_O_SEAT_KIBOU5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents Line33 As DataDynamics.ActiveReports.Line
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Shape3 As DataDynamics.ActiveReports.Shape
    Private WithEvents Line35 As DataDynamics.ActiveReports.Line
    Private WithEvents Line36 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape4 As DataDynamics.ActiveReports.Shape
    Private WithEvents Line37 As DataDynamics.ActiveReports.Line
    Private WithEvents Line38 As DataDynamics.ActiveReports.Line
    Private WithEvents Line41 As DataDynamics.ActiveReports.Line
    Private WithEvents Line51 As DataDynamics.ActiveReports.Line
End Class
