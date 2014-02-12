<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrReport
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
Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrReport))
Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
Me.Shape1 = New DataDynamics.ActiveReports.Shape
Me.DR_SHISETSU_ADDRESS = New DataDynamics.ActiveReports.TextBox
Me.DR_SHISETSU_NAME = New DataDynamics.ActiveReports.TextBox
Me.Label5 = New DataDynamics.ActiveReports.Label
Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
Me.Label6 = New DataDynamics.ActiveReports.Label
Me.Label7 = New DataDynamics.ActiveReports.Label
Me.Label8 = New DataDynamics.ActiveReports.Label
Me.Label9 = New DataDynamics.ActiveReports.Label
Me.Label10 = New DataDynamics.ActiveReports.Label
Me.Label11 = New DataDynamics.ActiveReports.Label
Me.Label12 = New DataDynamics.ActiveReports.Label
Me.Label14 = New DataDynamics.ActiveReports.Label
Me.Label15 = New DataDynamics.ActiveReports.Label
Me.Label16 = New DataDynamics.ActiveReports.Label
Me.Label17 = New DataDynamics.ActiveReports.Label
Me.Label18 = New DataDynamics.ActiveReports.Label
Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
Me.SANKASHA_ID = New DataDynamics.ActiveReports.TextBox
Me.DR_CD = New DataDynamics.ActiveReports.TextBox
Me.DR_NAME1 = New DataDynamics.ActiveReports.TextBox
Me.DR_KANA = New DataDynamics.ActiveReports.TextBox
Me.DR_YAKUWARI = New DataDynamics.ActiveReports.TextBox
Me.DR_AGE = New DataDynamics.ActiveReports.TextBox
Me.Line3 = New DataDynamics.ActiveReports.Line
Me.Line4 = New DataDynamics.ActiveReports.Line
Me.Line5 = New DataDynamics.ActiveReports.Line
Me.Line51 = New DataDynamics.ActiveReports.Line
Me.DR_SEX = New DataDynamics.ActiveReports.TextBox
Me.Label3 = New DataDynamics.ActiveReports.Label
Me.Label4 = New DataDynamics.ActiveReports.Label
Me.Line36 = New DataDynamics.ActiveReports.Line
Me.Line62 = New DataDynamics.ActiveReports.Line
Me.Line63 = New DataDynamics.ActiveReports.Line
Me.Line64 = New DataDynamics.ActiveReports.Line
Me.Line65 = New DataDynamics.ActiveReports.Line
Me.Line6 = New DataDynamics.ActiveReports.Line
Me.Line7 = New DataDynamics.ActiveReports.Line
Me.Detail = New DataDynamics.ActiveReports.Detail
Me.Label226 = New DataDynamics.ActiveReports.Label
Me.ANS_TICKET_SEND_DAY2 = New DataDynamics.ActiveReports.TextBox
Me.Label225 = New DataDynamics.ActiveReports.Label
Me.FROM_DATE1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_TAXI_NOTE = New DataDynamics.ActiveReports.TextBox
Me.Label224 = New DataDynamics.ActiveReports.Label
Me.TAXI_PRT_NAME2 = New DataDynamics.ActiveReports.TextBox
Me.Label223 = New DataDynamics.ActiveReports.Label
Me.FROM_DATE2 = New DataDynamics.ActiveReports.TextBox
Me.Label222 = New DataDynamics.ActiveReports.Label
Me.Label206 = New DataDynamics.ActiveReports.Label
Me.KOUENKAI_NAME2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME1_3 = New DataDynamics.ActiveReports.TextBox
Me.DR_SHISETSU_NAME2 = New DataDynamics.ActiveReports.TextBox
Me.Label184 = New DataDynamics.ActiveReports.Label
Me.REQ_F_SEAT_3 = New DataDynamics.ActiveReports.TextBox
Me.Label187 = New DataDynamics.ActiveReports.Label
Me.REQ_F_TIME1_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT1_3 = New DataDynamics.ActiveReports.TextBox
Me.Label189 = New DataDynamics.ActiveReports.Label
Me.Label155 = New DataDynamics.ActiveReports.Label
Me.Label158 = New DataDynamics.ActiveReports.Label
Me.Label160 = New DataDynamics.ActiveReports.Label
Me.Label156 = New DataDynamics.ActiveReports.Label
Me.Label175 = New DataDynamics.ActiveReports.Label
Me.FUKURO1 = New DataDynamics.ActiveReports.Label
Me.Label172 = New DataDynamics.ActiveReports.Label
Me.Label185 = New DataDynamics.ActiveReports.Label
Me.Label188 = New DataDynamics.ActiveReports.Label
Me.Label186 = New DataDynamics.ActiveReports.Label
Me.Label191 = New DataDynamics.ActiveReports.Label
Me.Label194 = New DataDynamics.ActiveReports.Label
Me.FUKURO3 = New DataDynamics.ActiveReports.Label
Me.Label195 = New DataDynamics.ActiveReports.Label
Me.Label198 = New DataDynamics.ActiveReports.Label
Me.Label200 = New DataDynamics.ActiveReports.Label
Me.REQ_O_SEAT_1 = New DataDynamics.ActiveReports.TextBox
Me.Label162 = New DataDynamics.ActiveReports.Label
Me.REQ_O_TIME1_1 = New DataDynamics.ActiveReports.TextBox
Me.Label165 = New DataDynamics.ActiveReports.Label
Me.REQ_O_AIRPORT1_1 = New DataDynamics.ActiveReports.TextBox
Me.Label167 = New DataDynamics.ActiveReports.Label
Me.Label163 = New DataDynamics.ActiveReports.Label
Me.REQ_O_DATE_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
Me.Label171 = New DataDynamics.ActiveReports.Label
Me.Label168 = New DataDynamics.ActiveReports.Label
Me.FUKURO2 = New DataDynamics.ActiveReports.Label
Me.REQ_O_TIME2_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT2_3 = New DataDynamics.ActiveReports.TextBox
Me.Label216 = New DataDynamics.ActiveReports.Label
Me.Label215 = New DataDynamics.ActiveReports.Label
Me.Label214 = New DataDynamics.ActiveReports.Label
Me.Label211 = New DataDynamics.ActiveReports.Label
Me.Label208 = New DataDynamics.ActiveReports.Label
Me.Line140 = New DataDynamics.ActiveReports.Line
Me.Label201 = New DataDynamics.ActiveReports.Label
Me.Label199 = New DataDynamics.ActiveReports.Label
Me.Label190 = New DataDynamics.ActiveReports.Label
Me.REQ_O_AIRPORT1_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT2_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME2_3 = New DataDynamics.ActiveReports.TextBox
Me.TO_DATE = New DataDynamics.ActiveReports.TextBox
Me.TAXI_PRT_NAME1 = New DataDynamics.ActiveReports.TextBox
Me.Label220 = New DataDynamics.ActiveReports.Label
Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
Me.Label219 = New DataDynamics.ActiveReports.Label
Me.FUKURO4 = New DataDynamics.ActiveReports.Label
Me.Line117 = New DataDynamics.ActiveReports.Line
Me.Line116 = New DataDynamics.ActiveReports.Line
Me.Line115 = New DataDynamics.ActiveReports.Line
Me.Line114 = New DataDynamics.ActiveReports.Line
Me.Line113 = New DataDynamics.ActiveReports.Line
Me.Line112 = New DataDynamics.ActiveReports.Line
Me.REQ_F_DATE_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_KOTSUKIKAN_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_IRAINAIYOU_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
Me.Label174 = New DataDynamics.ActiveReports.Label
Me.Label173 = New DataDynamics.ActiveReports.Label
Me.Label159 = New DataDynamics.ActiveReports.Label
Me.Label157 = New DataDynamics.ActiveReports.Label
Me.Label154 = New DataDynamics.ActiveReports.Label
Me.REQ_F_AIRPORT1_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT2_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME1_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME2_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_BIN_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_KIBOU1 = New DataDynamics.ActiveReports.TextBox
Me.TAXI_TESURYO = New DataDynamics.ActiveReports.TextBox
Me.Label87 = New DataDynamics.ActiveReports.Label
Me.Label92 = New DataDynamics.ActiveReports.Label
Me.Label91 = New DataDynamics.ActiveReports.Label
Me.Label90 = New DataDynamics.ActiveReports.Label
Me.Label89 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_10 = New DataDynamics.ActiveReports.TextBox
Me.Label88 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_10 = New DataDynamics.ActiveReports.TextBox
Me.TAXI_YOTEIKINGAKU_10 = New DataDynamics.ActiveReports.TextBox
Me.Label86 = New DataDynamics.ActiveReports.Label
Me.Label85 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_9 = New DataDynamics.ActiveReports.TextBox
Me.Label84 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_9 = New DataDynamics.ActiveReports.TextBox
Me.Label83 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_9 = New DataDynamics.ActiveReports.TextBox
Me.Label82 = New DataDynamics.ActiveReports.Label
Me.Label81 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_8 = New DataDynamics.ActiveReports.TextBox
Me.Label80 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_8 = New DataDynamics.ActiveReports.TextBox
Me.Label79 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_8 = New DataDynamics.ActiveReports.TextBox
Me.Label78 = New DataDynamics.ActiveReports.Label
Me.Label77 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_7 = New DataDynamics.ActiveReports.TextBox
Me.Label76 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_7 = New DataDynamics.ActiveReports.TextBox
Me.Label66 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_7 = New DataDynamics.ActiveReports.TextBox
Me.Label65 = New DataDynamics.ActiveReports.Label
Me.Label64 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_6 = New DataDynamics.ActiveReports.TextBox
Me.Label63 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_6 = New DataDynamics.ActiveReports.TextBox
Me.Label62 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_6 = New DataDynamics.ActiveReports.TextBox
Me.Label61 = New DataDynamics.ActiveReports.Label
Me.Label60 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_5 = New DataDynamics.ActiveReports.TextBox
Me.Label59 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_5 = New DataDynamics.ActiveReports.TextBox
Me.Label58 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_5 = New DataDynamics.ActiveReports.TextBox
Me.Label57 = New DataDynamics.ActiveReports.Label
Me.Label56 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_4 = New DataDynamics.ActiveReports.TextBox
Me.Label54 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_4 = New DataDynamics.ActiveReports.TextBox
Me.Label53 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_4 = New DataDynamics.ActiveReports.TextBox
Me.Label52 = New DataDynamics.ActiveReports.Label
Me.Label51 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_3 = New DataDynamics.ActiveReports.TextBox
Me.Label50 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_3 = New DataDynamics.ActiveReports.TextBox
Me.Label49 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_3 = New DataDynamics.ActiveReports.TextBox
Me.Label48 = New DataDynamics.ActiveReports.Label
Me.Label47 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_2 = New DataDynamics.ActiveReports.TextBox
Me.Label46 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_2 = New DataDynamics.ActiveReports.TextBox
Me.Label45 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_2 = New DataDynamics.ActiveReports.TextBox
Me.Label44 = New DataDynamics.ActiveReports.Label
Me.Label72 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_DATE_1 = New DataDynamics.ActiveReports.TextBox
Me.Label73 = New DataDynamics.ActiveReports.Label
Me.REQ_TAXI_FROM_1 = New DataDynamics.ActiveReports.TextBox
Me.Label74 = New DataDynamics.ActiveReports.Label
Me.TAXI_YOTEIKINGAKU_1 = New DataDynamics.ActiveReports.TextBox
Me.Label75 = New DataDynamics.ActiveReports.Label
Me.Label71 = New DataDynamics.ActiveReports.Label
Me.TEHAI_TAXI = New DataDynamics.ActiveReports.TextBox
Me.ANS_HOTEL_NAME = New DataDynamics.ActiveReports.TextBox
Me.ANS_ROOM_TYPE = New DataDynamics.ActiveReports.TextBox
Me.ANS_HOTELHI = New DataDynamics.ActiveReports.TextBox
Me.ANS_HOTELHI_TOZEI = New DataDynamics.ActiveReports.TextBox
Me.ANS_HOTELHI_CANCEL = New DataDynamics.ActiveReports.TextBox
Me.Label70 = New DataDynamics.ActiveReports.Label
Me.Label69 = New DataDynamics.ActiveReports.Label
Me.Label35 = New DataDynamics.ActiveReports.Label
Me.Label34 = New DataDynamics.ActiveReports.Label
Me.Label32 = New DataDynamics.ActiveReports.Label
Me.REQ_MR_HOTEL_NOTE = New DataDynamics.ActiveReports.TextBox
Me.Label68 = New DataDynamics.ActiveReports.Label
Me.Label67 = New DataDynamics.ActiveReports.Label
Me.Label55 = New DataDynamics.ActiveReports.Label
Me.REQ_MR_O_TEHAI = New DataDynamics.ActiveReports.TextBox
Me.REQ_MR_F_TEHAI = New DataDynamics.ActiveReports.TextBox
Me.MR_SEX = New DataDynamics.ActiveReports.TextBox
Me.MR_AGE = New DataDynamics.ActiveReports.TextBox
Me.MR_KANA = New DataDynamics.ActiveReports.TextBox
Me.Label13 = New DataDynamics.ActiveReports.Label
Me.Label25 = New DataDynamics.ActiveReports.Label
Me.Label20 = New DataDynamics.ActiveReports.Label
Me.Label19 = New DataDynamics.ActiveReports.Label
Me.Label21 = New DataDynamics.ActiveReports.Label
Me.Label22 = New DataDynamics.ActiveReports.Label
Me.Label23 = New DataDynamics.ActiveReports.Label
Me.Label24 = New DataDynamics.ActiveReports.Label
Me.Label26 = New DataDynamics.ActiveReports.Label
Me.Label27 = New DataDynamics.ActiveReports.Label
Me.Label28 = New DataDynamics.ActiveReports.Label
Me.Label29 = New DataDynamics.ActiveReports.Label
Me.Label30 = New DataDynamics.ActiveReports.Label
Me.Label31 = New DataDynamics.ActiveReports.Label
Me.Label33 = New DataDynamics.ActiveReports.Label
Me.Label36 = New DataDynamics.ActiveReports.Label
Me.Label37 = New DataDynamics.ActiveReports.Label
Me.Label38 = New DataDynamics.ActiveReports.Label
Me.Label39 = New DataDynamics.ActiveReports.Label
Me.Label40 = New DataDynamics.ActiveReports.Label
Me.Label41 = New DataDynamics.ActiveReports.Label
Me.Label42 = New DataDynamics.ActiveReports.Label
Me.Label43 = New DataDynamics.ActiveReports.Label
Me.SHITEIGAI_RIYU = New DataDynamics.ActiveReports.TextBox
Me.MR_AREA = New DataDynamics.ActiveReports.TextBox
Me.MR_EIGYOSHO = New DataDynamics.ActiveReports.TextBox
Me.MR_NAME = New DataDynamics.ActiveReports.TextBox
Me.MR_ROMA = New DataDynamics.ActiveReports.TextBox
Me.MR_EMAIL_PC = New DataDynamics.ActiveReports.TextBox
Me.MR_EMAIL_KEITAI = New DataDynamics.ActiveReports.TextBox
Me.MR_KEITAI = New DataDynamics.ActiveReports.TextBox
Me.MR_TEL = New DataDynamics.ActiveReports.TextBox
Me.MR_SEND_SAKI_FS = New DataDynamics.ActiveReports.TextBox
Me.MR_SEND_SAKI_OTHER = New DataDynamics.ActiveReports.TextBox
Me.COST_CENTER = New DataDynamics.ActiveReports.TextBox
Me.SHONIN_NAME = New DataDynamics.ActiveReports.TextBox
Me.SHONIN_DATE = New DataDynamics.ActiveReports.TextBox
Me.TEHAI_HOTEL = New DataDynamics.ActiveReports.TextBox
Me.HOTEL_IRAINAIYOU = New DataDynamics.ActiveReports.TextBox
Me.REQ_HOTEL_DATE = New DataDynamics.ActiveReports.TextBox
Me.REQ_HAKUSU = New DataDynamics.ActiveReports.TextBox
Me.REQ_HOTEL_SMOKING = New DataDynamics.ActiveReports.TextBox
Me.REQ_HOTEL_NOTE = New DataDynamics.ActiveReports.TextBox
Me.Line1 = New DataDynamics.ActiveReports.Line
Me.Line9 = New DataDynamics.ActiveReports.Line
Me.Line10 = New DataDynamics.ActiveReports.Line
Me.Line11 = New DataDynamics.ActiveReports.Line
Me.Line12 = New DataDynamics.ActiveReports.Line
Me.Line13 = New DataDynamics.ActiveReports.Line
Me.Line14 = New DataDynamics.ActiveReports.Line
Me.Line15 = New DataDynamics.ActiveReports.Line
Me.Line16 = New DataDynamics.ActiveReports.Line
Me.Line17 = New DataDynamics.ActiveReports.Line
Me.Line23 = New DataDynamics.ActiveReports.Line
Me.Line26 = New DataDynamics.ActiveReports.Line
Me.Line28 = New DataDynamics.ActiveReports.Line
Me.Line29 = New DataDynamics.ActiveReports.Line
Me.Line30 = New DataDynamics.ActiveReports.Line
Me.Line31 = New DataDynamics.ActiveReports.Line
Me.Line32 = New DataDynamics.ActiveReports.Line
Me.Line33 = New DataDynamics.ActiveReports.Line
Me.Line37 = New DataDynamics.ActiveReports.Line
Me.Line38 = New DataDynamics.ActiveReports.Line
Me.Line2 = New DataDynamics.ActiveReports.Line
Me.Line55 = New DataDynamics.ActiveReports.Line
Me.Line18 = New DataDynamics.ActiveReports.Line
Me.Line19 = New DataDynamics.ActiveReports.Line
Me.Line20 = New DataDynamics.ActiveReports.Line
Me.Line21 = New DataDynamics.ActiveReports.Line
Me.Line22 = New DataDynamics.ActiveReports.Line
Me.Line24 = New DataDynamics.ActiveReports.Line
Me.Line25 = New DataDynamics.ActiveReports.Line
Me.Line27 = New DataDynamics.ActiveReports.Line
Me.Line34 = New DataDynamics.ActiveReports.Line
Me.Line35 = New DataDynamics.ActiveReports.Line
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
Me.Line53 = New DataDynamics.ActiveReports.Line
Me.Line57 = New DataDynamics.ActiveReports.Line
Me.Line58 = New DataDynamics.ActiveReports.Line
Me.Line59 = New DataDynamics.ActiveReports.Line
Me.Line60 = New DataDynamics.ActiveReports.Line
Me.Line61 = New DataDynamics.ActiveReports.Line
Me.Line66 = New DataDynamics.ActiveReports.Line
Me.PageBreak1 = New DataDynamics.ActiveReports.PageBreak
Me.Shape2 = New DataDynamics.ActiveReports.Shape
Me.Label94 = New DataDynamics.ActiveReports.Label
Me.Label95 = New DataDynamics.ActiveReports.Label
Me.REQ_F_SEAT_KIBOU5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_BIN_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME2_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME1_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT2_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT1_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_DATE_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_KOTSUKIKAN_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_IRAINAIYOU_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_KIBOU4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_BIN_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME2_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME1_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT2_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT1_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_DATE_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_KOTSUKIKAN_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_IRAINAIYOU_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TEHAI_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_KIBOU5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_BIN_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME2_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME1_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT2_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT1_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_DATE_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_KOTSUKIKAN_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_IRAINAIYOU_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_KIBOU2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_SEAT_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_BIN_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME2_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TIME1_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT2_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_AIRPORT1_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_DATE_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_KOTSUKIKAN_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_IRAINAIYOU_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_KIBOU2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_BIN_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME2_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME1_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT2_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT1_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_DATE_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_KOTSUKIKAN_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_IRAINAIYOU_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TEHAI_2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TEHAI_2 = New DataDynamics.ActiveReports.TextBox
Me.Label108 = New DataDynamics.ActiveReports.Label
Me.Label107 = New DataDynamics.ActiveReports.Label
Me.Label106 = New DataDynamics.ActiveReports.Label
Me.Label105 = New DataDynamics.ActiveReports.Label
Me.Label104 = New DataDynamics.ActiveReports.Label
Me.Label103 = New DataDynamics.ActiveReports.Label
Me.Label102 = New DataDynamics.ActiveReports.Label
Me.Label101 = New DataDynamics.ActiveReports.Label
Me.Label100 = New DataDynamics.ActiveReports.Label
Me.Label99 = New DataDynamics.ActiveReports.Label
Me.Label98 = New DataDynamics.ActiveReports.Label
Me.FUKURO5 = New DataDynamics.ActiveReports.Label
Me.Label96 = New DataDynamics.ActiveReports.Label
Me.Label97 = New DataDynamics.ActiveReports.Label
Me.Label109 = New DataDynamics.ActiveReports.Label
Me.Label110 = New DataDynamics.ActiveReports.Label
Me.Label111 = New DataDynamics.ActiveReports.Label
Me.Label112 = New DataDynamics.ActiveReports.Label
Me.Label113 = New DataDynamics.ActiveReports.Label
Me.Label114 = New DataDynamics.ActiveReports.Label
Me.Label115 = New DataDynamics.ActiveReports.Label
Me.Label116 = New DataDynamics.ActiveReports.Label
Me.Label117 = New DataDynamics.ActiveReports.Label
Me.OURO5 = New DataDynamics.ActiveReports.Label
Me.Label118 = New DataDynamics.ActiveReports.Label
Me.Label119 = New DataDynamics.ActiveReports.Label
Me.Label120 = New DataDynamics.ActiveReports.Label
Me.Label121 = New DataDynamics.ActiveReports.Label
Me.Label122 = New DataDynamics.ActiveReports.Label
Me.Label123 = New DataDynamics.ActiveReports.Label
Me.Label124 = New DataDynamics.ActiveReports.Label
Me.Label125 = New DataDynamics.ActiveReports.Label
Me.Label126 = New DataDynamics.ActiveReports.Label
Me.Label127 = New DataDynamics.ActiveReports.Label
Me.Label128 = New DataDynamics.ActiveReports.Label
Me.Line71 = New DataDynamics.ActiveReports.Line
Me.Label129 = New DataDynamics.ActiveReports.Label
Me.Label130 = New DataDynamics.ActiveReports.Label
Me.Label131 = New DataDynamics.ActiveReports.Label
Me.Label132 = New DataDynamics.ActiveReports.Label
Me.Label133 = New DataDynamics.ActiveReports.Label
Me.Label134 = New DataDynamics.ActiveReports.Label
Me.Label135 = New DataDynamics.ActiveReports.Label
Me.Label136 = New DataDynamics.ActiveReports.Label
Me.Label137 = New DataDynamics.ActiveReports.Label
Me.Label138 = New DataDynamics.ActiveReports.Label
Me.Label139 = New DataDynamics.ActiveReports.Label
Me.OURO2 = New DataDynamics.ActiveReports.Label
Me.REQ_O_SEAT_KIBOU4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_BIN_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME2_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME1_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT2_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT1_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_KIBOU1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_BIN_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TIME2_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_AIRPORT2_1 = New DataDynamics.ActiveReports.TextBox
Me.Label140 = New DataDynamics.ActiveReports.Label
Me.Label141 = New DataDynamics.ActiveReports.Label
Me.Label142 = New DataDynamics.ActiveReports.Label
Me.Label143 = New DataDynamics.ActiveReports.Label
Me.Label144 = New DataDynamics.ActiveReports.Label
Me.Label145 = New DataDynamics.ActiveReports.Label
Me.Label146 = New DataDynamics.ActiveReports.Label
Me.Label147 = New DataDynamics.ActiveReports.Label
Me.Label148 = New DataDynamics.ActiveReports.Label
Me.Label149 = New DataDynamics.ActiveReports.Label
Me.Label150 = New DataDynamics.ActiveReports.Label
Me.Label151 = New DataDynamics.ActiveReports.Label
Me.Label152 = New DataDynamics.ActiveReports.Label
Me.Label153 = New DataDynamics.ActiveReports.Label
Me.OURO4 = New DataDynamics.ActiveReports.Label
Me.Line75 = New DataDynamics.ActiveReports.Line
Me.Label161 = New DataDynamics.ActiveReports.Label
Me.Label164 = New DataDynamics.ActiveReports.Label
Me.Label166 = New DataDynamics.ActiveReports.Label
Me.OURO1 = New DataDynamics.ActiveReports.Label
Me.Label169 = New DataDynamics.ActiveReports.Label
Me.Label170 = New DataDynamics.ActiveReports.Label
Me.Label176 = New DataDynamics.ActiveReports.Label
Me.Label177 = New DataDynamics.ActiveReports.Label
Me.Label178 = New DataDynamics.ActiveReports.Label
Me.Label179 = New DataDynamics.ActiveReports.Label
Me.Label181 = New DataDynamics.ActiveReports.Label
Me.Label182 = New DataDynamics.ActiveReports.Label
Me.Label183 = New DataDynamics.ActiveReports.Label
Me.REQ_O_IRAINAIYOU_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_KOTSUKIKAN_1 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TEHAI_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_IRAINAIYOU_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_KOTSUKIKAN_4 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_DATE_4 = New DataDynamics.ActiveReports.TextBox
Me.Line76 = New DataDynamics.ActiveReports.Line
Me.REQ_F_SEAT_KIBOU3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_BIN_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_DATE_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_KOTSUKIKAN_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_IRAINAIYOU_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_KIBOU3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_SEAT_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_BIN_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_DATE_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_KOTSUKIKAN_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_IRAINAIYOU_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_F_TEHAI_3 = New DataDynamics.ActiveReports.TextBox
Me.REQ_O_TEHAI_3 = New DataDynamics.ActiveReports.TextBox
Me.Label192 = New DataDynamics.ActiveReports.Label
Me.Label193 = New DataDynamics.ActiveReports.Label
Me.Line78 = New DataDynamics.ActiveReports.Line
Me.Label196 = New DataDynamics.ActiveReports.Label
Me.Label197 = New DataDynamics.ActiveReports.Label
Me.Label202 = New DataDynamics.ActiveReports.Label
Me.Label203 = New DataDynamics.ActiveReports.Label
Me.Label204 = New DataDynamics.ActiveReports.Label
Me.Label205 = New DataDynamics.ActiveReports.Label
Me.OURO3 = New DataDynamics.ActiveReports.Label
Me.Line80 = New DataDynamics.ActiveReports.Line
Me.Line87 = New DataDynamics.ActiveReports.Line
Me.Line88 = New DataDynamics.ActiveReports.Line
Me.Line89 = New DataDynamics.ActiveReports.Line
Me.Line90 = New DataDynamics.ActiveReports.Line
Me.Line91 = New DataDynamics.ActiveReports.Line
Me.Line92 = New DataDynamics.ActiveReports.Line
Me.Line93 = New DataDynamics.ActiveReports.Line
Me.Line94 = New DataDynamics.ActiveReports.Line
Me.Line95 = New DataDynamics.ActiveReports.Line
Me.Line96 = New DataDynamics.ActiveReports.Line
Me.Line101 = New DataDynamics.ActiveReports.Line
Me.Line118 = New DataDynamics.ActiveReports.Line
Me.Line119 = New DataDynamics.ActiveReports.Line
Me.Line120 = New DataDynamics.ActiveReports.Line
Me.Line121 = New DataDynamics.ActiveReports.Line
Me.Line152 = New DataDynamics.ActiveReports.Line
Me.Line173 = New DataDynamics.ActiveReports.Line
Me.Line52 = New DataDynamics.ActiveReports.Line
Me.DR_SHISETSU_ADDRESS2 = New DataDynamics.ActiveReports.TextBox
Me.Label207 = New DataDynamics.ActiveReports.Label
Me.Label209 = New DataDynamics.ActiveReports.Label
Me.Label210 = New DataDynamics.ActiveReports.Label
Me.Label212 = New DataDynamics.ActiveReports.Label
Me.Label213 = New DataDynamics.ActiveReports.Label
Me.Label217 = New DataDynamics.ActiveReports.Label
Me.KOUENKAI_NO2 = New DataDynamics.ActiveReports.TextBox
Me.REQ_STATUS_TEHAI2 = New DataDynamics.ActiveReports.TextBox
Me.TIME_STAMP_BYL2 = New DataDynamics.ActiveReports.TextBox
Me.SANKASHA_ID2 = New DataDynamics.ActiveReports.TextBox
Me.DR_CD2 = New DataDynamics.ActiveReports.TextBox
Me.DR_NAME2 = New DataDynamics.ActiveReports.TextBox
Me.DR_KANA2 = New DataDynamics.ActiveReports.TextBox
Me.DR_AGE2 = New DataDynamics.ActiveReports.TextBox
Me.Line67 = New DataDynamics.ActiveReports.Line
Me.Line192 = New DataDynamics.ActiveReports.Line
Me.Line193 = New DataDynamics.ActiveReports.Line
Me.Line194 = New DataDynamics.ActiveReports.Line
Me.DR_SEX2 = New DataDynamics.ActiveReports.TextBox
Me.Line195 = New DataDynamics.ActiveReports.Line
Me.Line196 = New DataDynamics.ActiveReports.Line
Me.Line199 = New DataDynamics.ActiveReports.Line
Me.Line200 = New DataDynamics.ActiveReports.Line
Me.Line79 = New DataDynamics.ActiveReports.Line
Me.Line68 = New DataDynamics.ActiveReports.Line
Me.Line203 = New DataDynamics.ActiveReports.Line
Me.Line70 = New DataDynamics.ActiveReports.Line
Me.Line74 = New DataDynamics.ActiveReports.Line
Me.Line81 = New DataDynamics.ActiveReports.Line
Me.Line82 = New DataDynamics.ActiveReports.Line
Me.Line97 = New DataDynamics.ActiveReports.Line
Me.Line99 = New DataDynamics.ActiveReports.Line
Me.Line100 = New DataDynamics.ActiveReports.Line
Me.Line102 = New DataDynamics.ActiveReports.Line
Me.Line103 = New DataDynamics.ActiveReports.Line
Me.Line98 = New DataDynamics.ActiveReports.Line
Me.Line105 = New DataDynamics.ActiveReports.Line
Me.Line106 = New DataDynamics.ActiveReports.Line
Me.Line107 = New DataDynamics.ActiveReports.Line
Me.Line108 = New DataDynamics.ActiveReports.Line
Me.Line109 = New DataDynamics.ActiveReports.Line
Me.Line110 = New DataDynamics.ActiveReports.Line
Me.Line111 = New DataDynamics.ActiveReports.Line
Me.Line132 = New DataDynamics.ActiveReports.Line
Me.Line133 = New DataDynamics.ActiveReports.Line
Me.Line134 = New DataDynamics.ActiveReports.Line
Me.Line135 = New DataDynamics.ActiveReports.Line
Me.Line137 = New DataDynamics.ActiveReports.Line
Me.Line138 = New DataDynamics.ActiveReports.Line
Me.Line139 = New DataDynamics.ActiveReports.Line
Me.Line141 = New DataDynamics.ActiveReports.Line
Me.Line153 = New DataDynamics.ActiveReports.Line
Me.Line84 = New DataDynamics.ActiveReports.Line
Me.Label180 = New DataDynamics.ActiveReports.Label
Me.Line123 = New DataDynamics.ActiveReports.Line
Me.Line124 = New DataDynamics.ActiveReports.Line
Me.Line125 = New DataDynamics.ActiveReports.Line
Me.Line126 = New DataDynamics.ActiveReports.Line
Me.Line127 = New DataDynamics.ActiveReports.Line
Me.Line122 = New DataDynamics.ActiveReports.Line
Me.Line85 = New DataDynamics.ActiveReports.Line
Me.Line86 = New DataDynamics.ActiveReports.Line
Me.Line154 = New DataDynamics.ActiveReports.Line
Me.Line155 = New DataDynamics.ActiveReports.Line
Me.Line156 = New DataDynamics.ActiveReports.Line
Me.Line83 = New DataDynamics.ActiveReports.Line
Me.Line104 = New DataDynamics.ActiveReports.Line
Me.Line72 = New DataDynamics.ActiveReports.Line
Me.Line128 = New DataDynamics.ActiveReports.Line
Me.Line129 = New DataDynamics.ActiveReports.Line
Me.Line130 = New DataDynamics.ActiveReports.Line
Me.Line131 = New DataDynamics.ActiveReports.Line
Me.Line54 = New DataDynamics.ActiveReports.Line
Me.Line142 = New DataDynamics.ActiveReports.Line
Me.Line143 = New DataDynamics.ActiveReports.Line
Me.Line144 = New DataDynamics.ActiveReports.Line
Me.Line146 = New DataDynamics.ActiveReports.Line
Me.Line147 = New DataDynamics.ActiveReports.Line
Me.Line148 = New DataDynamics.ActiveReports.Line
Me.Line149 = New DataDynamics.ActiveReports.Line
Me.Line150 = New DataDynamics.ActiveReports.Line
Me.Line151 = New DataDynamics.ActiveReports.Line
Me.Line157 = New DataDynamics.ActiveReports.Line
Me.Line158 = New DataDynamics.ActiveReports.Line
Me.Line159 = New DataDynamics.ActiveReports.Line
Me.Line160 = New DataDynamics.ActiveReports.Line
Me.Line161 = New DataDynamics.ActiveReports.Line
Me.Line162 = New DataDynamics.ActiveReports.Line
Me.Line163 = New DataDynamics.ActiveReports.Line
Me.Line164 = New DataDynamics.ActiveReports.Line
Me.Line8 = New DataDynamics.ActiveReports.Line
Me.Label218 = New DataDynamics.ActiveReports.Label
Me.KAIJO_NAME = New DataDynamics.ActiveReports.TextBox
Me.Line136 = New DataDynamics.ActiveReports.Line
Me.Line69 = New DataDynamics.ActiveReports.Line
Me.Line73 = New DataDynamics.ActiveReports.Line
Me.Line145 = New DataDynamics.ActiveReports.Line
Me.Line198 = New DataDynamics.ActiveReports.Line
Me.Line201 = New DataDynamics.ActiveReports.Line
Me.Line77 = New DataDynamics.ActiveReports.Line
Me.Label221 = New DataDynamics.ActiveReports.Label
Me.KAIJO_NAME2 = New DataDynamics.ActiveReports.TextBox
Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
Me.Label1 = New DataDynamics.ActiveReports.Label
Me.PRINT_USER = New DataDynamics.ActiveReports.TextBox
Me.Label2 = New DataDynamics.ActiveReports.Label
Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
Me.Label227 = New DataDynamics.ActiveReports.Label
Me.MR_BU = New DataDynamics.ActiveReports.TextBox
Me.Label93 = New DataDynamics.ActiveReports.Label
Me.Label228 = New DataDynamics.ActiveReports.Label
Me.Label229 = New DataDynamics.ActiveReports.Label
Me.Label230 = New DataDynamics.ActiveReports.Label
Me.Label231 = New DataDynamics.ActiveReports.Label
Me.Label232 = New DataDynamics.ActiveReports.Label
Me.Label233 = New DataDynamics.ActiveReports.Label
Me.Label234 = New DataDynamics.ActiveReports.Label
Me.Label235 = New DataDynamics.ActiveReports.Label
Me.Line56 = New DataDynamics.ActiveReports.Line
Me.Line165 = New DataDynamics.ActiveReports.Line
Me.Line166 = New DataDynamics.ActiveReports.Line
Me.Line167 = New DataDynamics.ActiveReports.Line
Me.Line168 = New DataDynamics.ActiveReports.Line
Me.Line169 = New DataDynamics.ActiveReports.Line
Me.Line170 = New DataDynamics.ActiveReports.Line
Me.ANS_AIR_FARE = New DataDynamics.ActiveReports.TextBox
Me.ANS_AIR_CANCELLATION = New DataDynamics.ActiveReports.TextBox
Me.ANS_RAIL_FARE = New DataDynamics.ActiveReports.TextBox
Me.ANS_RAIL_CANCELLATION = New DataDynamics.ActiveReports.TextBox
Me.ANS_MR_HOTELHI = New DataDynamics.ActiveReports.TextBox
Me.ANS_MR_HOTELHI_TOZEI = New DataDynamics.ActiveReports.TextBox
Me.ANS_MR_KOTSUHI = New DataDynamics.ActiveReports.TextBox
Me.ANS_OTHER_FARE = New DataDynamics.ActiveReports.TextBox
Me.ANS_OTHER_CANCELLATION = New DataDynamics.ActiveReports.TextBox
Me.TAXI_PRT_NAME = New DataDynamics.ActiveReports.TextBox
Me.ANS_TICKET_SEND_DAY = New DataDynamics.ActiveReports.TextBox
Me.REQ_STATUS_TEHAI1 = New DataDynamics.ActiveReports.TextBox
Me.TIME_STAMP_BYL1 = New DataDynamics.ActiveReports.TextBox
Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
CType(Me.DR_SHISETSU_ADDRESS,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_SHISETSU_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.KOUENKAI_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label6,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label7,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label8,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label9,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label10,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label11,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label12,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label14,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label15,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label16,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label17,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label18,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.KOUENKAI_NO,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_STATUS_TEHAI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TIME_STAMP_BYL,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SANKASHA_ID,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_CD,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_NAME1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_KANA,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_YAKUWARI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_AGE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_SEX,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label226,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_TICKET_SEND_DAY2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label225,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FROM_DATE1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_NOTE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label224,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_PRT_NAME2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label223,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FROM_DATE2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label222,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label206,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.KOUENKAI_NAME2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME1_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_SHISETSU_NAME2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label184,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label187,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME1_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT1_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label189,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label155,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label158,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label160,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label156,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label175,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FUKURO1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label172,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label185,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label188,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label186,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label191,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label194,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FUKURO3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label195,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label198,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label200,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label162,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME1_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label165,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT1_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label167,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label163,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_DATE_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TEHAI_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label171,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label168,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FUKURO2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME2_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT2_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label216,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label215,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label214,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label211,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label208,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label201,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label199,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label190,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT1_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT2_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME2_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TO_DATE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_PRT_NAME1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label220,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FROM_DATE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label219,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FUKURO4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_DATE_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_KOTSUKIKAN_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_IRAINAIYOU_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TEHAI_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label174,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label173,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label159,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label157,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label154,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT1_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT2_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME1_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME2_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_BIN_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_KIBOU1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_TESURYO,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label87,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label92,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label91,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label90,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label89,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_10,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label88,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_10,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_10,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label86,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label85,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_9,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label84,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_9,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label83,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_9,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label82,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label81,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_8,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label80,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_8,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label79,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_8,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label78,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label77,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_7,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label76,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_7,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label66,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_7,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label65,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label64,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_6,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label63,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_6,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label62,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_6,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label61,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label60,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label59,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label58,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label57,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label56,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label54,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label53,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label52,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label51,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label50,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label49,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label48,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label47,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label46,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label45,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label44,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label72,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_DATE_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label73,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_TAXI_FROM_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label74,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_YOTEIKINGAKU_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label75,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label71,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TEHAI_TAXI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_HOTEL_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_ROOM_TYPE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_HOTELHI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_HOTELHI_TOZEI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_HOTELHI_CANCEL,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label70,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label69,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label35,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label34,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label32,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_MR_HOTEL_NOTE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label68,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label67,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label55,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_MR_O_TEHAI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_MR_F_TEHAI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_SEX,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_AGE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_KANA,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label13,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label25,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label20,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label19,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label21,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label22,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label23,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label24,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label26,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label27,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label28,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label29,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label30,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label31,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label33,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label36,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label37,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label38,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label39,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label40,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label41,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label42,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label43,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SHITEIGAI_RIYU,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_AREA,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_EIGYOSHO,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_ROMA,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_EMAIL_PC,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_EMAIL_KEITAI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_KEITAI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_TEL,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_SEND_SAKI_FS,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_SEND_SAKI_OTHER,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.COST_CENTER,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SHONIN_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SHONIN_DATE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TEHAI_HOTEL,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.HOTEL_IRAINAIYOU,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_HOTEL_DATE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_HAKUSU,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_HOTEL_SMOKING,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_HOTEL_NOTE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label94,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label95,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_KIBOU5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_BIN_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME2_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME1_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT2_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT1_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_DATE_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_KOTSUKIKAN_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_IRAINAIYOU_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TEHAI_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_KIBOU4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_BIN_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME2_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME1_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT2_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT1_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_DATE_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_KOTSUKIKAN_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_IRAINAIYOU_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TEHAI_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_KIBOU5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_BIN_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME2_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME1_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT2_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT1_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_DATE_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_KOTSUKIKAN_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_IRAINAIYOU_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TEHAI_5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_KIBOU2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_BIN_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME2_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TIME1_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT2_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_AIRPORT1_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_DATE_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_KOTSUKIKAN_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_IRAINAIYOU_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_KIBOU2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_BIN_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME2_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME1_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT2_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT1_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_DATE_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_KOTSUKIKAN_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_IRAINAIYOU_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TEHAI_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TEHAI_2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label108,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label107,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label106,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label105,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label104,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label103,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label102,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label101,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label100,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label99,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label98,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.FUKURO5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label96,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label97,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label109,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label110,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label111,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label112,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label113,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label114,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label115,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label116,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label117,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.OURO5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label118,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label119,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label120,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label121,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label122,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label123,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label124,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label125,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label126,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label127,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label128,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label129,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label130,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label131,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label132,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label133,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label134,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label135,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label136,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label137,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label138,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label139,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.OURO2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_KIBOU4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_BIN_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME2_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME1_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT2_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT1_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_KIBOU1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_BIN_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TIME2_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_AIRPORT2_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label140,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label141,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label142,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label143,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label144,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label145,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label146,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label147,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label148,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label149,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label150,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label151,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label152,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label153,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.OURO4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label161,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label164,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label166,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.OURO1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label169,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label170,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label176,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label177,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label178,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label179,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label181,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label182,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label183,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_IRAINAIYOU_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_KOTSUKIKAN_1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TEHAI_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_IRAINAIYOU_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_KOTSUKIKAN_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_DATE_4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_SEAT_KIBOU3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_BIN_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_DATE_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_KOTSUKIKAN_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_IRAINAIYOU_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_KIBOU3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_SEAT_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_BIN_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_DATE_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_KOTSUKIKAN_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_IRAINAIYOU_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_F_TEHAI_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_O_TEHAI_3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label192,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label193,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label196,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label197,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label202,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label203,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label204,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label205,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.OURO3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_SHISETSU_ADDRESS2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label207,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label209,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label210,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label212,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label213,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label217,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.KOUENKAI_NO2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_STATUS_TEHAI2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TIME_STAMP_BYL2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SANKASHA_ID2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_CD2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_NAME2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_KANA2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_AGE2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_SEX2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label180,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label218,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.KAIJO_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label221,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.KAIJO_NAME2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PRINT_USER,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PRINT_DATE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label227,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MR_BU,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label93,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label228,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label229,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label230,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label231,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label232,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label233,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label234,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.Label235,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_AIR_FARE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_AIR_CANCELLATION,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_RAIL_FARE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_RAIL_CANCELLATION,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_MR_HOTELHI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_MR_HOTELHI_TOZEI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_MR_KOTSUHI,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_OTHER_FARE,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_OTHER_CANCELLATION,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TAXI_PRT_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ANS_TICKET_SEND_DAY,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.REQ_STATUS_TEHAI1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TIME_STAMP_BYL1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DR_NAME,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
'
'PageHeader
'
Me.PageHeader.Height = 0.4184599!
Me.PageHeader.Name = "PageHeader"
'
'Shape1
'
Me.Shape1.BackColor = System.Drawing.Color.DarkGray
Me.Shape1.Height = 0.2740157!
Me.Shape1.Left = 0!
Me.Shape1.Name = "Shape1"
Me.Shape1.RoundingRadius = 9.999999!
Me.Shape1.Top = 0!
Me.Shape1.Width = 7.151969!
'
'DR_SHISETSU_ADDRESS
'
Me.DR_SHISETSU_ADDRESS.DataField = "DR_SHISETSU_ADDRESS"
Me.DR_SHISETSU_ADDRESS.Height = 0.1999999!
Me.DR_SHISETSU_ADDRESS.Left = 4.507481!
Me.DR_SHISETSU_ADDRESS.Name = "DR_SHISETSU_ADDRESS"
Me.DR_SHISETSU_ADDRESS.Style = "vertical-align: middle"
Me.DR_SHISETSU_ADDRESS.Text = Nothing
Me.DR_SHISETSU_ADDRESS.Top = 1.474016!
Me.DR_SHISETSU_ADDRESS.Width = 2.644488!
'
'DR_SHISETSU_NAME
'
Me.DR_SHISETSU_NAME.DataField = "DR_SHISETSU_NAME"
Me.DR_SHISETSU_NAME.Height = 0.2!
Me.DR_SHISETSU_NAME.Left = 4.507481!
Me.DR_SHISETSU_NAME.Name = "DR_SHISETSU_NAME"
Me.DR_SHISETSU_NAME.Style = "font-size: 9pt; vertical-align: middle"
Me.DR_SHISETSU_NAME.Top = 1.274016!
Me.DR_SHISETSU_NAME.Width = 2.657874!
'
'Label5
'
Me.Label5.Height = 0.2!
Me.Label5.HyperLink = Nothing
Me.Label5.Left = 0!
Me.Label5.Name = "Label5"
Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
Me.Label5.Text = "会合名："
Me.Label5.Top = 0.2740158!
Me.Label5.Width = 0.6771654!
'
'KOUENKAI_NAME
'
Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
Me.KOUENKAI_NAME.Height = 0.2!
Me.KOUENKAI_NAME.Left = 0.6771655!
Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
Me.KOUENKAI_NAME.Style = "font-weight: bold; white-space: nowrap"
Me.KOUENKAI_NAME.Text = Nothing
Me.KOUENKAI_NAME.Top = 0.2740158!
Me.KOUENKAI_NAME.Width = 3.996063!
'
'Label6
'
Me.Label6.Height = 0.2!
Me.Label6.HyperLink = Nothing
Me.Label6.Left = 4.768372E-07!
Me.Label6.Name = "Label6"
Me.Label6.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label6.Text = "会合番号"
Me.Label6.Top = 0.8740149!
Me.Label6.Width = 1.323622!
'
'Label7
'
Me.Label7.Height = 0.2!
Me.Label7.HyperLink = Nothing
Me.Label7.Left = 3.558662!
Me.Label7.Name = "Label7"
Me.Label7.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label7.Text = "手配ステータス"
Me.Label7.Top = 0.8740158!
Me.Label7.Width = 0.948819!
'
'Label8
'
Me.Label8.Height = 0.2!
Me.Label8.HyperLink = Nothing
Me.Label8.Left = 4.828347!
Me.Label8.Name = "Label8"
Me.Label8.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label8.Text = "Timestamp(BYL)"
Me.Label8.Top = 0.8740158!
Me.Label8.Width = 0.9590553!
'
'Label9
'
Me.Label9.Height = 0.2!
Me.Label9.HyperLink = Nothing
Me.Label9.Left = 0!
Me.Label9.Name = "Label9"
Me.Label9.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label9.Text = "MTP ID(参加者ID)"
Me.Label9.Top = 1.074015!
Me.Label9.Width = 1.323622!
'
'Label10
'
Me.Label10.Height = 0.2!
Me.Label10.HyperLink = Nothing
Me.Label10.Left = 3.558662!
Me.Label10.Name = "Label10"
Me.Label10.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label10.Text = "DRコード"
Me.Label10.Top = 1.074015!
Me.Label10.Width = 0.9488187!
'
'Label11
'
Me.Label11.Height = 0.2!
Me.Label11.HyperLink = Nothing
Me.Label11.Left = 0!
Me.Label11.Name = "Label11"
Me.Label11.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label11.Text = "DR氏名"
Me.Label11.Top = 1.274016!
Me.Label11.Width = 1.323622!
'
'Label12
'
Me.Label12.Height = 0.2!
Me.Label12.HyperLink = Nothing
Me.Label12.Left = 0!
Me.Label12.Name = "Label12"
Me.Label12.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label12.Text = "DR氏名(半角ｶﾀｶﾅ)"
Me.Label12.Top = 1.474016!
Me.Label12.Width = 1.323622!
'
'Label14
'
Me.Label14.Height = 0.2!
Me.Label14.HyperLink = Nothing
Me.Label14.Left = 3.558662!
Me.Label14.Name = "Label14"
Me.Label14.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label14.Text = "施設名"
Me.Label14.Top = 1.274016!
Me.Label14.Width = 0.9488189!
'
'Label15
'
Me.Label15.Height = 0.2!
Me.Label15.HyperLink = Nothing
Me.Label15.Left = 3.558662!
Me.Label15.Name = "Label15"
Me.Label15.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label15.Text = "施設住所"
Me.Label15.Top = 1.474016!
Me.Label15.Width = 0.9488189!
'
'Label16
'
Me.Label16.Height = 0.2!
Me.Label16.HyperLink = Nothing
Me.Label16.Left = 0!
Me.Label16.Name = "Label16"
Me.Label16.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label16.Text = "参加者役割"
Me.Label16.Top = 1.874016!
Me.Label16.Width = 1.323622!
'
'Label17
'
Me.Label17.Height = 0.2!
Me.Label17.HyperLink = Nothing
Me.Label17.Left = 3.558662!
Me.Label17.Name = "Label17"
Me.Label17.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label17.Text = "性別"
Me.Label17.Top = 1.674016!
Me.Label17.Width = 0.9488189!
'
'Label18
'
Me.Label18.Height = 0.2!
Me.Label18.HyperLink = Nothing
Me.Label18.Left = 0!
Me.Label18.Name = "Label18"
Me.Label18.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label18.Text = "航空搭乗者年齢(年齢)"
Me.Label18.Top = 1.674016!
Me.Label18.Width = 1.323622!
'
'KOUENKAI_NO
'
Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
Me.KOUENKAI_NO.Height = 0.2!
Me.KOUENKAI_NO.Left = 1.323622!
Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
Me.KOUENKAI_NO.Style = "vertical-align: middle"
Me.KOUENKAI_NO.Text = Nothing
Me.KOUENKAI_NO.Top = 0.8740158!
Me.KOUENKAI_NO.Width = 2.23504!
'
'REQ_STATUS_TEHAI
'
Me.REQ_STATUS_TEHAI.DataField = "REQ_STATUS_TEHAI"
Me.REQ_STATUS_TEHAI.Height = 0.2!
Me.REQ_STATUS_TEHAI.Left = 4.507481!
Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
Me.REQ_STATUS_TEHAI.Style = "text-align: center; vertical-align: middle"
Me.REQ_STATUS_TEHAI.Text = Nothing
Me.REQ_STATUS_TEHAI.Top = 0.8740158!
Me.REQ_STATUS_TEHAI.Visible = false
Me.REQ_STATUS_TEHAI.Width = 0.3208661!
'
'TIME_STAMP_BYL
'
Me.TIME_STAMP_BYL.DataField = "TIME_STAMP_BYL"
Me.TIME_STAMP_BYL.Height = 0.2!
Me.TIME_STAMP_BYL.Left = 5.787402!
Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
Me.TIME_STAMP_BYL.Style = "vertical-align: middle"
Me.TIME_STAMP_BYL.Text = Nothing
Me.TIME_STAMP_BYL.Top = 0.8740158!
Me.TIME_STAMP_BYL.Visible = false
Me.TIME_STAMP_BYL.Width = 1.364567!
'
'SANKASHA_ID
'
Me.SANKASHA_ID.DataField = "SANKASHA_ID"
Me.SANKASHA_ID.Height = 0.2!
Me.SANKASHA_ID.Left = 1.323622!
Me.SANKASHA_ID.Name = "SANKASHA_ID"
Me.SANKASHA_ID.Style = "vertical-align: middle"
Me.SANKASHA_ID.Text = Nothing
Me.SANKASHA_ID.Top = 1.074015!
Me.SANKASHA_ID.Width = 2.23504!
'
'DR_CD
'
Me.DR_CD.DataField = "DR_CD"
Me.DR_CD.Height = 0.2!
Me.DR_CD.Left = 4.507481!
Me.DR_CD.Name = "DR_CD"
Me.DR_CD.Style = "vertical-align: middle"
Me.DR_CD.Top = 1.074015!
Me.DR_CD.Width = 2.644488!
'
'DR_NAME1
'
Me.DR_NAME1.DataField = "DR_NAME"
Me.DR_NAME1.Height = 0.2!
Me.DR_NAME1.Left = 1.323622!
Me.DR_NAME1.Name = "DR_NAME1"
Me.DR_NAME1.Style = "vertical-align: middle"
Me.DR_NAME1.Text = Nothing
Me.DR_NAME1.Top = 1.274016!
Me.DR_NAME1.Width = 2.23504!
'
'DR_KANA
'
Me.DR_KANA.DataField = "DR_KANA"
Me.DR_KANA.Height = 0.2!
Me.DR_KANA.Left = 1.323622!
Me.DR_KANA.Name = "DR_KANA"
Me.DR_KANA.Style = "vertical-align: middle"
Me.DR_KANA.Text = Nothing
Me.DR_KANA.Top = 1.474016!
Me.DR_KANA.Width = 2.23504!
'
'DR_YAKUWARI
'
Me.DR_YAKUWARI.DataField = "DR_YAKUWARI"
Me.DR_YAKUWARI.Height = 0.2!
Me.DR_YAKUWARI.Left = 1.323622!
Me.DR_YAKUWARI.Name = "DR_YAKUWARI"
Me.DR_YAKUWARI.Style = "vertical-align: middle"
Me.DR_YAKUWARI.Text = Nothing
Me.DR_YAKUWARI.Top = 1.874016!
Me.DR_YAKUWARI.Width = 2.23504!
'
'DR_AGE
'
Me.DR_AGE.DataField = "DR_AGE"
Me.DR_AGE.Height = 0.2!
Me.DR_AGE.Left = 1.323622!
Me.DR_AGE.Name = "DR_AGE"
Me.DR_AGE.Style = "vertical-align: middle"
Me.DR_AGE.Text = Nothing
Me.DR_AGE.Top = 1.674016!
Me.DR_AGE.Width = 2.23504!
'
'Line3
'
Me.Line3.Height = 0!
Me.Line3.Left = 4.768372E-07!
Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line3.LineWeight = 1!
Me.Line3.Name = "Line3"
Me.Line3.Top = 1.074015!
Me.Line3.Width = 7.165353!
Me.Line3.X1 = 4.768372E-07!
Me.Line3.X2 = 7.165354!
Me.Line3.Y1 = 1.074015!
Me.Line3.Y2 = 1.074015!
'
'Line4
'
Me.Line4.Height = 0!
Me.Line4.Left = 4.768372E-07!
Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line4.LineWeight = 1!
Me.Line4.Name = "Line4"
Me.Line4.Top = 1.274015!
Me.Line4.Width = 7.165353!
Me.Line4.X1 = 4.768372E-07!
Me.Line4.X2 = 7.165354!
Me.Line4.Y1 = 1.274015!
Me.Line4.Y2 = 1.274015!
'
'Line5
'
Me.Line5.Height = 0!
Me.Line5.Left = 4.768372E-07!
Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line5.LineWeight = 1!
Me.Line5.Name = "Line5"
Me.Line5.Top = 1.474015!
Me.Line5.Width = 7.165353!
Me.Line5.X1 = 4.768372E-07!
Me.Line5.X2 = 7.165354!
Me.Line5.Y1 = 1.474015!
Me.Line5.Y2 = 1.474015!
'
'Line51
'
Me.Line51.Height = 0!
Me.Line51.Left = 5.684342E-14!
Me.Line51.LineWeight = 1!
Me.Line51.Name = "Line51"
Me.Line51.Top = 0.8740157!
Me.Line51.Width = 7.165355!
Me.Line51.X1 = 5.684342E-14!
Me.Line51.X2 = 7.165355!
Me.Line51.Y1 = 0.8740157!
Me.Line51.Y2 = 0.8740157!
'
'DR_SEX
'
Me.DR_SEX.DataField = "DR_SEX"
Me.DR_SEX.Height = 0.2!
Me.DR_SEX.Left = 4.507481!
Me.DR_SEX.Name = "DR_SEX"
Me.DR_SEX.Style = "vertical-align: middle"
Me.DR_SEX.Text = Nothing
Me.DR_SEX.Top = 1.674016!
Me.DR_SEX.Width = 2.644488!
'
'Label3
'
Me.Label3.Height = 0.2!
Me.Label3.HyperLink = Nothing
Me.Label3.Left = 0!
Me.Label3.Name = "Label3"
Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center"
Me.Label3.Text = "交通宿泊タクチケ手配依頼"
Me.Label3.Top = 0.0330711!
Me.Label3.Width = 7.151969!
'
'Label4
'
Me.Label4.Height = 0.2!
Me.Label4.HyperLink = Nothing
Me.Label4.Left = 6.433071!
Me.Label4.Name = "Label4"
Me.Label4.Style = "text-align: right"
Me.Label4.Text = "(1/2ページ)"
Me.Label4.Top = 0.03307089!
Me.Label4.Width = 0.7188978!
'
'Line36
'
Me.Line36.Height = 1.827165!
Me.Line36.Left = 1.323622!
Me.Line36.LineWeight = 1!
Me.Line36.Name = "Line36"
Me.Line36.Top = 0.8740158!
Me.Line36.Width = 1.192093E-07!
Me.Line36.X1 = 1.323622!
Me.Line36.X2 = 1.323622!
Me.Line36.Y1 = 0.8740158!
Me.Line36.Y2 = 2.701181!
'
'Line62
'
Me.Line62.Height = 0.2000002!
Me.Line62.Left = 4.828347!
Me.Line62.LineWeight = 1!
Me.Line62.Name = "Line62"
Me.Line62.Top = 0.8740158!
Me.Line62.Width = 0!
Me.Line62.X1 = 4.828347!
Me.Line62.X2 = 4.828347!
Me.Line62.Y1 = 0.8740158!
Me.Line62.Y2 = 1.074016!
'
'Line63
'
Me.Line63.Height = 0.2000002!
Me.Line63.Left = 5.800788!
Me.Line63.LineWeight = 1!
Me.Line63.Name = "Line63"
Me.Line63.Top = 0.8740158!
Me.Line63.Width = 0!
Me.Line63.X1 = 5.800788!
Me.Line63.X2 = 5.800788!
Me.Line63.Y1 = 0.8740158!
Me.Line63.Y2 = 1.074016!
'
'Line64
'
Me.Line64.Height = 1!
Me.Line64.Left = 3.558662!
Me.Line64.LineWeight = 1!
Me.Line64.Name = "Line64"
Me.Line64.Top = 0.8740158!
Me.Line64.Width = 0!
Me.Line64.X1 = 3.558662!
Me.Line64.X2 = 3.558662!
Me.Line64.Y1 = 0.8740158!
Me.Line64.Y2 = 1.874016!
'
'Line65
'
Me.Line65.Height = 1!
Me.Line65.Left = 4.507481!
Me.Line65.LineWeight = 1!
Me.Line65.Name = "Line65"
Me.Line65.Top = 0.8740158!
Me.Line65.Width = 0!
Me.Line65.X1 = 4.507481!
Me.Line65.X2 = 4.507481!
Me.Line65.Y1 = 0.8740158!
Me.Line65.Y2 = 1.874016!
'
'Line6
'
Me.Line6.Height = 0!
Me.Line6.Left = 4.768372E-07!
Me.Line6.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line6.LineWeight = 1!
Me.Line6.Name = "Line6"
Me.Line6.Top = 1.674015!
Me.Line6.Width = 7.165353!
Me.Line6.X1 = 4.768372E-07!
Me.Line6.X2 = 7.165354!
Me.Line6.Y1 = 1.674015!
Me.Line6.Y2 = 1.674015!
'
'Line7
'
Me.Line7.Height = 0!
Me.Line7.Left = 4.768372E-07!
Me.Line7.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line7.LineWeight = 1!
Me.Line7.Name = "Line7"
Me.Line7.Top = 1.874015!
Me.Line7.Width = 7.165353!
Me.Line7.X1 = 4.768372E-07!
Me.Line7.X2 = 7.165354!
Me.Line7.Y1 = 1.874015!
Me.Line7.Y2 = 1.874015!
'
'Detail
'
Me.Detail.ColumnSpacing = 0!
Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.DR_CD, Me.TIME_STAMP_BYL, Me.TIME_STAMP_BYL1, Me.REQ_STATUS_TEHAI1, Me.ANS_TICKET_SEND_DAY, Me.REQ_MR_HOTEL_NOTE, Me.DR_NAME, Me.TAXI_PRT_NAME, Me.ANS_OTHER_FARE, Me.ANS_OTHER_CANCELLATION, Me.ANS_AIR_FARE, Me.ANS_AIR_CANCELLATION, Me.ANS_RAIL_FARE, Me.ANS_RAIL_CANCELLATION, Me.ANS_MR_HOTELHI, Me.ANS_MR_HOTELHI_TOZEI, Me.ANS_MR_KOTSUHI, Me.Label232, Me.Label235, Me.Label234, Me.Label233, Me.Label230, Me.Label229, Me.Label228, Me.Label231, Me.Label93, Me.REQ_TAXI_NOTE, Me.MR_BU, Me.Label227, Me.Label226, Me.ANS_TICKET_SEND_DAY2, Me.Label225, Me.FROM_DATE1, Me.Label224, Me.TAXI_PRT_NAME2, Me.Label223, Me.FROM_DATE2, Me.Label222, Me.Label206, Me.KOUENKAI_NAME2, Me.REQ_O_TIME1_3, Me.DR_SHISETSU_NAME2, Me.Label184, Me.REQ_F_SEAT_3, Me.Label187, Me.REQ_F_TIME1_3, Me.REQ_F_AIRPORT1_3, Me.Label189, Me.Label155, Me.Label158, Me.Label160, Me.Label156, Me.Label175, Me.FUKURO1, Me.Label172, Me.Label185, Me.Label188, Me.Label186, Me.Label191, Me.Label194, Me.FUKURO3, Me.Label195, Me.Label198, Me.Label200, Me.REQ_O_SEAT_1, Me.Label162, Me.REQ_O_TIME1_1, Me.Label165, Me.REQ_O_AIRPORT1_1, Me.Label167, Me.Label163, Me.REQ_O_DATE_1, Me.REQ_O_TEHAI_1, Me.Label171, Me.Label168, Me.FUKURO2, Me.REQ_O_TIME2_3, Me.REQ_O_AIRPORT2_3, Me.Label216, Me.Label215, Me.Label214, Me.Label211, Me.Label208, Me.Line140, Me.Label201, Me.Label199, Me.Label190, Me.REQ_O_AIRPORT1_3, Me.REQ_F_AIRPORT2_3, Me.REQ_F_TIME2_3, Me.TO_DATE, Me.TAXI_PRT_NAME1, Me.Label220, Me.FROM_DATE, Me.Label219, Me.FUKURO4, Me.Line117, Me.Line116, Me.Line115, Me.Line114, Me.Line113, Me.Line112, Me.REQ_F_DATE_1, Me.REQ_F_KOTSUKIKAN_1, Me.REQ_F_IRAINAIYOU_1, Me.REQ_F_TEHAI_1, Me.Label174, Me.Label173, Me.Label159, Me.Label157, Me.Label154, Me.REQ_F_AIRPORT1_1, Me.REQ_F_AIRPORT2_1, Me.REQ_F_TIME1_1, Me.REQ_F_TIME2_1, Me.REQ_F_BIN_1, Me.REQ_F_SEAT_1, Me.REQ_F_SEAT_KIBOU1, Me.TAXI_TESURYO, Me.Label87, Me.Label92, Me.Label91, Me.Label90, Me.Label89, Me.REQ_TAXI_DATE_10, Me.Label88, Me.REQ_TAXI_FROM_10, Me.TAXI_YOTEIKINGAKU_10, Me.Label86, Me.Label85, Me.REQ_TAXI_DATE_9, Me.Label84, Me.REQ_TAXI_FROM_9, Me.Label83, Me.TAXI_YOTEIKINGAKU_9, Me.Label82, Me.Label81, Me.REQ_TAXI_DATE_8, Me.Label80, Me.REQ_TAXI_FROM_8, Me.Label79, Me.TAXI_YOTEIKINGAKU_8, Me.Label78, Me.Label77, Me.REQ_TAXI_DATE_7, Me.Label76, Me.REQ_TAXI_FROM_7, Me.Label66, Me.TAXI_YOTEIKINGAKU_7, Me.Label65, Me.Label64, Me.REQ_TAXI_DATE_6, Me.Label63, Me.REQ_TAXI_FROM_6, Me.Label62, Me.TAXI_YOTEIKINGAKU_6, Me.Label61, Me.Label60, Me.REQ_TAXI_DATE_5, Me.Label59, Me.REQ_TAXI_FROM_5, Me.Label58, Me.TAXI_YOTEIKINGAKU_5, Me.Label57, Me.Label56, Me.REQ_TAXI_DATE_4, Me.Label54, Me.REQ_TAXI_FROM_4, Me.Label53, Me.TAXI_YOTEIKINGAKU_4, Me.Label52, Me.Label51, Me.REQ_TAXI_DATE_3, Me.Label50, Me.REQ_TAXI_FROM_3, Me.Label49, Me.TAXI_YOTEIKINGAKU_3, Me.Label48, Me.Label47, Me.REQ_TAXI_DATE_2, Me.Label46, Me.REQ_TAXI_FROM_2, Me.Label45, Me.TAXI_YOTEIKINGAKU_2, Me.Label44, Me.Label72, Me.REQ_TAXI_DATE_1, Me.Label73, Me.REQ_TAXI_FROM_1, Me.Label74, Me.TAXI_YOTEIKINGAKU_1, Me.Label75, Me.Label71, Me.TEHAI_TAXI, Me.ANS_HOTEL_NAME, Me.ANS_ROOM_TYPE, Me.ANS_HOTELHI, Me.ANS_HOTELHI_TOZEI, Me.ANS_HOTELHI_CANCEL, Me.Label70, Me.Label69, Me.Label35, Me.Label34, Me.Label32, Me.Label68, Me.Label67, Me.Label55, Me.REQ_MR_O_TEHAI, Me.REQ_MR_F_TEHAI, Me.MR_SEX, Me.MR_AGE, Me.MR_KANA, Me.Label13, Me.Label25, Me.Label20, Me.Label19, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label33, Me.Label36, Me.Label37, Me.Label38, Me.Label39, Me.Label40, Me.Label41, Me.Label42, Me.Label43, Me.SHITEIGAI_RIYU, Me.MR_AREA, Me.MR_EIGYOSHO, Me.MR_NAME, Me.MR_ROMA, Me.MR_EMAIL_PC, Me.MR_EMAIL_KEITAI, Me.MR_KEITAI, Me.MR_TEL, Me.MR_SEND_SAKI_FS, Me.MR_SEND_SAKI_OTHER, Me.COST_CENTER, Me.SHONIN_NAME, Me.SHONIN_DATE, Me.TEHAI_HOTEL, Me.HOTEL_IRAINAIYOU, Me.REQ_HOTEL_DATE, Me.REQ_HAKUSU, Me.REQ_HOTEL_SMOKING, Me.REQ_HOTEL_NOTE, Me.Line1, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line13, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Line23, Me.Line26, Me.Line28, Me.Line29, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line37, Me.Line38, Me.Line2, Me.Line55, Me.Line18, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line24, Me.Line25, Me.Line27, Me.Line34, Me.Line35, Me.Line39, Me.Line40, Me.Line41, Me.Line42, Me.Line43, Me.Line44, Me.Line45, Me.Line46, Me.Line47, Me.Line48, Me.Line49, Me.Line50, Me.Line53, Me.Line57, Me.Line58, Me.Line59, Me.Line60, Me.Line61, Me.Line66, Me.PageBreak1, Me.DR_SHISETSU_ADDRESS, Me.DR_SHISETSU_NAME, Me.Label5, Me.KOUENKAI_NAME, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label14, Me.Label15, Me.Label16, Me.Label17, Me.Label18, Me.KOUENKAI_NO, Me.REQ_STATUS_TEHAI, Me.SANKASHA_ID, Me.DR_NAME1, Me.DR_KANA, Me.DR_YAKUWARI, Me.DR_AGE, Me.Line3, Me.Line4, Me.Line5, Me.DR_SEX, Me.Line36, Me.Line62, Me.Line63, Me.Line64, Me.Line65, Me.Line6, Me.Line7, Me.Shape2, Me.Label94, Me.Label95, Me.REQ_F_SEAT_KIBOU5, Me.REQ_F_SEAT_5, Me.REQ_F_BIN_5, Me.REQ_F_TIME2_5, Me.REQ_F_TIME1_5, Me.REQ_F_AIRPORT2_5, Me.REQ_F_AIRPORT1_5, Me.REQ_F_DATE_5, Me.REQ_F_KOTSUKIKAN_5, Me.REQ_F_IRAINAIYOU_5, Me.REQ_F_TEHAI_5, Me.REQ_F_SEAT_KIBOU4, Me.REQ_F_SEAT_4, Me.REQ_F_BIN_4, Me.REQ_F_TIME2_4, Me.REQ_F_TIME1_4, Me.REQ_F_AIRPORT2_4, Me.REQ_F_AIRPORT1_4, Me.REQ_F_DATE_4, Me.REQ_F_KOTSUKIKAN_4, Me.REQ_F_IRAINAIYOU_4, Me.REQ_F_TEHAI_4, Me.REQ_O_SEAT_KIBOU5, Me.REQ_O_SEAT_5, Me.REQ_O_BIN_5, Me.REQ_O_TIME2_5, Me.REQ_O_TIME1_5, Me.REQ_O_AIRPORT2_5, Me.REQ_O_AIRPORT1_5, Me.REQ_O_DATE_5, Me.REQ_O_KOTSUKIKAN_5, Me.REQ_O_IRAINAIYOU_5, Me.REQ_O_TEHAI_5, Me.REQ_F_SEAT_KIBOU2, Me.REQ_F_SEAT_2, Me.REQ_F_BIN_2, Me.REQ_F_TIME2_2, Me.REQ_F_TIME1_2, Me.REQ_F_AIRPORT2_2, Me.REQ_F_AIRPORT1_2, Me.REQ_F_DATE_2, Me.REQ_F_KOTSUKIKAN_2, Me.REQ_F_IRAINAIYOU_2, Me.REQ_O_SEAT_KIBOU2, Me.REQ_O_SEAT_2, Me.REQ_O_BIN_2, Me.REQ_O_TIME2_2, Me.REQ_O_TIME1_2, Me.REQ_O_AIRPORT2_2, Me.REQ_O_AIRPORT1_2, Me.REQ_O_DATE_2, Me.REQ_O_KOTSUKIKAN_2, Me.REQ_O_IRAINAIYOU_2, Me.REQ_F_TEHAI_2, Me.REQ_O_TEHAI_2, Me.Label108, Me.Label107, Me.Label106, Me.Label105, Me.Label104, Me.Label103, Me.Label102, Me.Label101, Me.Label100, Me.Label99, Me.Label98, Me.FUKURO5, Me.Label96, Me.Label97, Me.Label109, Me.Label110, Me.Label111, Me.Label112, Me.Label113, Me.Label114, Me.Label115, Me.Label116, Me.Label117, Me.OURO5, Me.Label118, Me.Label119, Me.Label120, Me.Label121, Me.Label122, Me.Label123, Me.Label124, Me.Label125, Me.Label126, Me.Label127, Me.Label128, Me.Line71, Me.Label129, Me.Label130, Me.Label131, Me.Label132, Me.Label133, Me.Label134, Me.Label135, Me.Label136, Me.Label137, Me.Label138, Me.Label139, Me.OURO2, Me.REQ_O_SEAT_KIBOU4, Me.REQ_O_SEAT_4, Me.REQ_O_BIN_4, Me.REQ_O_TIME2_4, Me.REQ_O_TIME1_4, Me.REQ_O_AIRPORT2_4, Me.REQ_O_AIRPORT1_4, Me.REQ_O_SEAT_KIBOU1, Me.REQ_O_BIN_1, Me.REQ_O_TIME2_1, Me.REQ_O_AIRPORT2_1, Me.Label140, Me.Label141, Me.Label142, Me.Label143, Me.Label144, Me.Label145, Me.Label146, Me.Label147, Me.Label148, Me.Label149, Me.Label150, Me.Label151, Me.Label152, Me.Label153, Me.OURO4, Me.Line75, Me.Label161, Me.Label164, Me.Label166, Me.OURO1, Me.Label169, Me.Label170, Me.Label176, Me.Label177, Me.Label178, Me.Label179, Me.Label181, Me.Label182, Me.Label183, Me.REQ_O_IRAINAIYOU_1, Me.REQ_O_KOTSUKIKAN_1, Me.REQ_O_TEHAI_4, Me.REQ_O_IRAINAIYOU_4, Me.REQ_O_KOTSUKIKAN_4, Me.REQ_O_DATE_4, Me.Line76, Me.REQ_F_SEAT_KIBOU3, Me.REQ_F_BIN_3, Me.REQ_F_DATE_3, Me.REQ_F_KOTSUKIKAN_3, Me.REQ_F_IRAINAIYOU_3, Me.REQ_O_SEAT_KIBOU3, Me.REQ_O_SEAT_3, Me.REQ_O_BIN_3, Me.REQ_O_DATE_3, Me.REQ_O_KOTSUKIKAN_3, Me.REQ_O_IRAINAIYOU_3, Me.REQ_F_TEHAI_3, Me.REQ_O_TEHAI_3, Me.Label192, Me.Label193, Me.Line78, Me.Label196, Me.Label197, Me.Label202, Me.Label203, Me.Label204, Me.Label205, Me.OURO3, Me.Line80, Me.Line87, Me.Line88, Me.Line89, Me.Line90, Me.Line91, Me.Line92, Me.Line93, Me.Line94, Me.Line95, Me.Line96, Me.Line101, Me.Line118, Me.Line119, Me.Line120, Me.Line121, Me.Line152, Me.Line173, Me.Line52, Me.DR_SHISETSU_ADDRESS2, Me.Label207, Me.Label209, Me.Label210, Me.Label212, Me.Label213, Me.Label217, Me.KOUENKAI_NO2, Me.REQ_STATUS_TEHAI2, Me.TIME_STAMP_BYL2, Me.SANKASHA_ID2, Me.DR_CD2, Me.DR_NAME2, Me.DR_KANA2, Me.DR_AGE2, Me.Line67, Me.Line192, Me.Line193, Me.Line194, Me.DR_SEX2, Me.Line195, Me.Line196, Me.Line199, Me.Line200, Me.Line79, Me.Line68, Me.Line203, Me.Line70, Me.Line74, Me.Line81, Me.Line82, Me.Line97, Me.Line99, Me.Line100, Me.Line102, Me.Line103, Me.Line98, Me.Line105, Me.Line106, Me.Line107, Me.Line108, Me.Line109, Me.Line110, Me.Line111, Me.Line132, Me.Line133, Me.Line134, Me.Line135, Me.Line137, Me.Line138, Me.Line139, Me.Line141, Me.Line153, Me.Line84, Me.Label180, Me.Line123, Me.Line124, Me.Line125, Me.Line126, Me.Line127, Me.Line122, Me.Line85, Me.Line86, Me.Line154, Me.Line155, Me.Line156, Me.Line83, Me.Line104, Me.Line72, Me.Line128, Me.Line129, Me.Line130, Me.Line131, Me.Line54, Me.Line142, Me.Line143, Me.Line144, Me.Line146, Me.Line147, Me.Line148, Me.Line149, Me.Line150, Me.Line151, Me.Line157, Me.Line158, Me.Line159, Me.Line160, Me.Line161, Me.Line162, Me.Line163, Me.Line164, Me.Line8, Me.Shape1, Me.Label218, Me.KAIJO_NAME, Me.Line136, Me.Line69, Me.Line73, Me.Line145, Me.Line198, Me.Line77, Me.Label221, Me.KAIJO_NAME2, Me.Label3, Me.Label4, Me.Line201, Me.Line56, Me.Line165, Me.Line166, Me.Line167, Me.Line168, Me.Line169, Me.Line170, Me.Line51})
Me.Detail.Height = 18.95102!
Me.Detail.KeepTogether = true
Me.Detail.Name = "Detail"
'
'Label226
'
Me.Label226.Height = 0.2!
Me.Label226.HyperLink = Nothing
Me.Label226.Left = 4.673229!
Me.Label226.Name = "Label226"
Me.Label226.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; text-align: left"
Me.Label226.Text = "発送日(最新)："
Me.Label226.Top = 0.6740158!
Me.Label226.Width = 1.127559!
'
'ANS_TICKET_SEND_DAY2
'
Me.ANS_TICKET_SEND_DAY2.DataField = "ANS_TICKET_SEND_DAY"
Me.ANS_TICKET_SEND_DAY2.Height = 0.1999998!
Me.ANS_TICKET_SEND_DAY2.Left = 5.800788!
Me.ANS_TICKET_SEND_DAY2.Name = "ANS_TICKET_SEND_DAY2"
Me.ANS_TICKET_SEND_DAY2.Style = "vertical-align: middle"
Me.ANS_TICKET_SEND_DAY2.Text = Nothing
Me.ANS_TICKET_SEND_DAY2.Top = 10.29685!
Me.ANS_TICKET_SEND_DAY2.Width = 1.364567!
'
'Label225
'
Me.Label225.Height = 0.2!
Me.Label225.HyperLink = Nothing
Me.Label225.Left = 4.686615!
Me.Label225.Name = "Label225"
Me.Label225.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; text-align: left"
Me.Label225.Text = "発送日(最新)："
Me.Label225.Top = 10.29685!
Me.Label225.Width = 1.100787!
'
'FROM_DATE1
'
Me.FROM_DATE1.Height = 0.2!
Me.FROM_DATE1.Left = 0.6771654!
Me.FROM_DATE1.Name = "FROM_DATE1"
Me.FROM_DATE1.Style = "font-weight: normal; white-space: nowrap"
Me.FROM_DATE1.Text = Nothing
Me.FROM_DATE1.Top = 0.6740158!
Me.FROM_DATE1.Width = 2.871259!
'
'REQ_TAXI_NOTE
'
Me.REQ_TAXI_NOTE.DataField = "REQ_TAXI_NOTE"
Me.REQ_TAXI_NOTE.Height = 2.2!
Me.REQ_TAXI_NOTE.Left = 4.919291!
Me.REQ_TAXI_NOTE.Name = "REQ_TAXI_NOTE"
Me.REQ_TAXI_NOTE.Style = "font-size: 9pt"
Me.REQ_TAXI_NOTE.Top = 7.302756!
Me.REQ_TAXI_NOTE.Width = 2.246064!
'
'Label224
'
Me.Label224.Height = 0.2!
Me.Label224.HyperLink = Nothing
Me.Label224.Left = 2.934252!
Me.Label224.Name = "Label224"
Me.Label224.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;"& _ 
    " white-space: nowrap"
Me.Label224.Text = "枚"
Me.Label224.Top = 9.302755!
Me.Label224.Width = 0.3948819!
'
'TAXI_PRT_NAME2
'
Me.TAXI_PRT_NAME2.DataField = "TAXI_PRT_NAME"
Me.TAXI_PRT_NAME2.Height = 0.2!
Me.TAXI_PRT_NAME2.Left = 5.9563!
Me.TAXI_PRT_NAME2.Name = "TAXI_PRT_NAME2"
Me.TAXI_PRT_NAME2.Style = "vertical-align: middle"
Me.TAXI_PRT_NAME2.Text = Nothing
Me.TAXI_PRT_NAME2.Top = 9.896851!
Me.TAXI_PRT_NAME2.Width = 1.209055!
'
'Label223
'
Me.Label223.Height = 0.2!
Me.Label223.HyperLink = Nothing
Me.Label223.Left = 4.686615!
Me.Label223.Name = "Label223"
Me.Label223.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
Me.Label223.Text = "チケット印字名："
Me.Label223.Top = 9.896851!
Me.Label223.Width = 1.269685!
'
'FROM_DATE2
'
Me.FROM_DATE2.Height = 0.2!
Me.FROM_DATE2.Left = 0.6771654!
Me.FROM_DATE2.Name = "FROM_DATE2"
Me.FROM_DATE2.Style = "font-weight: normal; white-space: nowrap"
Me.FROM_DATE2.Text = Nothing
Me.FROM_DATE2.Top = 10.29685!
Me.FROM_DATE2.Width = 2.871259!
'
'Label222
'
Me.Label222.Height = 0.2!
Me.Label222.HyperLink = Nothing
Me.Label222.Left = 0!
Me.Label222.Name = "Label222"
Me.Label222.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
Me.Label222.Text = "開催日："
Me.Label222.Top = 10.29685!
Me.Label222.Width = 0.6771654!
'
'Label206
'
Me.Label206.Height = 0.2!
Me.Label206.HyperLink = Nothing
Me.Label206.Left = 0!
Me.Label206.Name = "Label206"
Me.Label206.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
Me.Label206.Text = "会合名："
Me.Label206.Top = 9.896851!
Me.Label206.Width = 0.6771654!
'
'KOUENKAI_NAME2
'
Me.KOUENKAI_NAME2.DataField = "KOUENKAI_NAME"
Me.KOUENKAI_NAME2.Height = 0.2!
Me.KOUENKAI_NAME2.Left = 0.6771654!
Me.KOUENKAI_NAME2.Name = "KOUENKAI_NAME2"
Me.KOUENKAI_NAME2.Style = "font-weight: bold; white-space: nowrap"
Me.KOUENKAI_NAME2.Text = Nothing
Me.KOUENKAI_NAME2.Top = 9.896851!
Me.KOUENKAI_NAME2.Width = 3.996063!
'
'REQ_O_TIME1_3
'
Me.REQ_O_TIME1_3.DataField = "REQ_O_TIME1_3"
Me.REQ_O_TIME1_3.Height = 0.2!
Me.REQ_O_TIME1_3.Left = 0.9165355!
Me.REQ_O_TIME1_3.Name = "REQ_O_TIME1_3"
Me.REQ_O_TIME1_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME1_3.Text = Nothing
Me.REQ_O_TIME1_3.Top = 14.69685!
Me.REQ_O_TIME1_3.Width = 0.9858269!
'
'DR_SHISETSU_NAME2
'
Me.DR_SHISETSU_NAME2.DataField = "DR_SHISETSU_NAME"
Me.DR_SHISETSU_NAME2.Height = 0.2!
Me.DR_SHISETSU_NAME2.Left = 4.507481!
Me.DR_SHISETSU_NAME2.Name = "DR_SHISETSU_NAME2"
Me.DR_SHISETSU_NAME2.Style = "font-size: 9pt; vertical-align: middle"
Me.DR_SHISETSU_NAME2.Text = Nothing
Me.DR_SHISETSU_NAME2.Top = 10.89685!
Me.DR_SHISETSU_NAME2.Width = 2.657874!
'
'Label184
'
Me.Label184.Height = 0.2!
Me.Label184.HyperLink = Nothing
Me.Label184.Left = 5.485433!
Me.Label184.Name = "Label184"
Me.Label184.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label184.Text = "座席希望"
Me.Label184.Top = 14.89685!
Me.Label184.Width = 0.6874018!
'
'REQ_F_SEAT_3
'
Me.REQ_F_SEAT_3.DataField = "REQ_F_SEAT_3"
Me.REQ_F_SEAT_3.Height = 0.2!
Me.REQ_F_SEAT_3.Left = 4.507481!
Me.REQ_F_SEAT_3.Name = "REQ_F_SEAT_3"
Me.REQ_F_SEAT_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_3.Text = Nothing
Me.REQ_F_SEAT_3.Top = 14.89685!
Me.REQ_F_SEAT_3.Width = 0.9779529!
'
'Label187
'
Me.Label187.Height = 0.2!
Me.Label187.HyperLink = Nothing
Me.Label187.Left = 5.485433!
Me.Label187.Name = "Label187"
Me.Label187.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label187.Text = "到着時間"
Me.Label187.Top = 14.69685!
Me.Label187.Width = 0.6874018!
'
'REQ_F_TIME1_3
'
Me.REQ_F_TIME1_3.DataField = "REQ_F_TIME1_3"
Me.REQ_F_TIME1_3.Height = 0.2!
Me.REQ_F_TIME1_3.Left = 4.507481!
Me.REQ_F_TIME1_3.Name = "REQ_F_TIME1_3"
Me.REQ_F_TIME1_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME1_3.Text = Nothing
Me.REQ_F_TIME1_3.Top = 14.69685!
Me.REQ_F_TIME1_3.Width = 0.9779529!
'
'REQ_F_AIRPORT1_3
'
Me.REQ_F_AIRPORT1_3.DataField = "REQ_F_AIRPORT1_3"
Me.REQ_F_AIRPORT1_3.Height = 0.2!
Me.REQ_F_AIRPORT1_3.Left = 4.507481!
Me.REQ_F_AIRPORT1_3.Name = "REQ_F_AIRPORT1_3"
Me.REQ_F_AIRPORT1_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT1_3.Text = Nothing
Me.REQ_F_AIRPORT1_3.Top = 14.49685!
Me.REQ_F_AIRPORT1_3.Width = 0.9779529!
'
'Label189
'
Me.Label189.Height = 0.2!
Me.Label189.HyperLink = Nothing
Me.Label189.Left = 5.485433!
Me.Label189.Name = "Label189"
Me.Label189.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label189.Text = "到着地"
Me.Label189.Top = 14.49685!
Me.Label189.Width = 0.6874018!
'
'Label155
'
Me.Label155.Height = 0.2!
Me.Label155.HyperLink = Nothing
Me.Label155.Left = 3.787795!
Me.Label155.Name = "Label155"
Me.Label155.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label155.Text = "座席区分"
Me.Label155.Top = 12.49685!
Me.Label155.Width = 0.7196856!
'
'Label158
'
Me.Label158.Height = 0.2!
Me.Label158.HyperLink = Nothing
Me.Label158.Left = 3.787795!
Me.Label158.Name = "Label158"
Me.Label158.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label158.Text = "出発時間"
Me.Label158.Top = 12.29685!
Me.Label158.Width = 0.7196856!
'
'Label160
'
Me.Label160.Height = 0.2!
Me.Label160.HyperLink = Nothing
Me.Label160.Left = 3.787796!
Me.Label160.Name = "Label160"
Me.Label160.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label160.Text = "出発地"
Me.Label160.Top = 12.09685!
Me.Label160.Width = 0.7196851!
'
'Label156
'
Me.Label156.Height = 0.2!
Me.Label156.HyperLink = Nothing
Me.Label156.Left = 3.787795!
Me.Label156.Name = "Label156"
Me.Label156.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label156.Text = "列車・便名"
Me.Label156.Top = 11.89685!
Me.Label156.Width = 0.7196854!
'
'Label175
'
Me.Label175.Height = 0.2!
Me.Label175.HyperLink = Nothing
Me.Label175.Left = 3.787795!
Me.Label175.Name = "Label175"
Me.Label175.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label175.Text = "利用日"
Me.Label175.Top = 11.69685!
Me.Label175.Width = 0.7196856!
'
'FUKURO1
'
Me.FUKURO1.Height = 1.2!
Me.FUKURO1.HyperLink = Nothing
Me.FUKURO1.Left = 3.558662!
Me.FUKURO1.Name = "FUKURO1"
Me.FUKURO1.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bo"& _ 
    "ld; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-ve"& _ 
    "rtical: true"
Me.FUKURO1.Text = ""
Me.FUKURO1.Top = 11.49685!
Me.FUKURO1.Width = 0.2291338!
'
'Label172
'
Me.Label172.Height = 0.1999999!
Me.Label172.HyperLink = Nothing
Me.Label172.Left = 3.787795!
Me.Label172.Name = "Label172"
Me.Label172.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label172.Text = "希望する"
Me.Label172.Top = 11.49685!
Me.Label172.Width = 0.7196856!
'
'Label185
'
Me.Label185.Height = 0.2!
Me.Label185.HyperLink = Nothing
Me.Label185.Left = 3.763779!
Me.Label185.Name = "Label185"
Me.Label185.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label185.Text = "座席区分"
Me.Label185.Top = 14.89685!
Me.Label185.Width = 0.743701!
'
'Label188
'
Me.Label188.Height = 0.2!
Me.Label188.HyperLink = Nothing
Me.Label188.Left = 3.763779!
Me.Label188.Name = "Label188"
Me.Label188.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label188.Text = "出発時間"
Me.Label188.Top = 14.69685!
Me.Label188.Width = 0.743701!
'
'Label186
'
Me.Label186.Height = 0.2!
Me.Label186.HyperLink = Nothing
Me.Label186.Left = 3.763779!
Me.Label186.Name = "Label186"
Me.Label186.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label186.Text = "列車・便名"
Me.Label186.Top = 14.29685!
Me.Label186.Width = 0.7437013!
'
'Label191
'
Me.Label191.Height = 0.2!
Me.Label191.HyperLink = Nothing
Me.Label191.Left = 3.763779!
Me.Label191.Name = "Label191"
Me.Label191.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label191.Text = "利用日"
Me.Label191.Top = 14.09685!
Me.Label191.Width = 0.743701!
'
'Label194
'
Me.Label194.Height = 0.1999999!
Me.Label194.HyperLink = Nothing
Me.Label194.Left = 3.763779!
Me.Label194.Name = "Label194"
Me.Label194.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label194.Text = "希望する"
Me.Label194.Top = 13.89685!
Me.Label194.Width = 0.743701!
'
'FUKURO3
'
Me.FUKURO3.Height = 1.200001!
Me.FUKURO3.HyperLink = Nothing
Me.FUKURO3.Left = 3.558662!
Me.FUKURO3.Name = "FUKURO3"
Me.FUKURO3.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bo"& _ 
    "ld; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-ve"& _ 
    "rtical: true"
Me.FUKURO3.Text = ""
Me.FUKURO3.Top = 13.89685!
Me.FUKURO3.Width = 0.2051181!
'
'Label195
'
Me.Label195.Height = 0.2!
Me.Label195.HyperLink = Nothing
Me.Label195.Left = 1.892126!
Me.Label195.Name = "Label195"
Me.Label195.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label195.Text = "座席希望"
Me.Label195.Top = 14.89685!
Me.Label195.Width = 0.6874014!
'
'Label198
'
Me.Label198.Height = 0.2!
Me.Label198.HyperLink = Nothing
Me.Label198.Left = 1.892126!
Me.Label198.Name = "Label198"
Me.Label198.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label198.Text = "到着時間"
Me.Label198.Top = 14.69685!
Me.Label198.Width = 0.6874014!
'
'Label200
'
Me.Label200.Height = 0.2!
Me.Label200.HyperLink = Nothing
Me.Label200.Left = 1.892126!
Me.Label200.Name = "Label200"
Me.Label200.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label200.Text = "到着地"
Me.Label200.Top = 14.49685!
Me.Label200.Width = 0.6874015!
'
'REQ_O_SEAT_1
'
Me.REQ_O_SEAT_1.DataField = "REQ_O_SEAT_1"
Me.REQ_O_SEAT_1.Height = 0.2!
Me.REQ_O_SEAT_1.Left = 0.9165352!
Me.REQ_O_SEAT_1.Name = "REQ_O_SEAT_1"
Me.REQ_O_SEAT_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_1.Text = Nothing
Me.REQ_O_SEAT_1.Top = 12.49685!
Me.REQ_O_SEAT_1.Width = 0.9858268!
'
'Label162
'
Me.Label162.Height = 0.2!
Me.Label162.HyperLink = Nothing
Me.Label162.Left = 0.2291339!
Me.Label162.Name = "Label162"
Me.Label162.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label162.Text = "座席区分"
Me.Label162.Top = 12.49685!
Me.Label162.Width = 0.6874014!
'
'REQ_O_TIME1_1
'
Me.REQ_O_TIME1_1.DataField = "REQ_O_TIME1_1"
Me.REQ_O_TIME1_1.Height = 0.2!
Me.REQ_O_TIME1_1.Left = 0.9165352!
Me.REQ_O_TIME1_1.Name = "REQ_O_TIME1_1"
Me.REQ_O_TIME1_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME1_1.Text = Nothing
Me.REQ_O_TIME1_1.Top = 12.29685!
Me.REQ_O_TIME1_1.Width = 0.9858268!
'
'Label165
'
Me.Label165.Height = 0.2!
Me.Label165.HyperLink = Nothing
Me.Label165.Left = 0.2291339!
Me.Label165.Name = "Label165"
Me.Label165.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label165.Text = "出発時間"
Me.Label165.Top = 12.29685!
Me.Label165.Width = 0.6874014!
'
'REQ_O_AIRPORT1_1
'
Me.REQ_O_AIRPORT1_1.DataField = "REQ_O_AIRPORT1_1"
Me.REQ_O_AIRPORT1_1.Height = 0.2!
Me.REQ_O_AIRPORT1_1.Left = 0.9165352!
Me.REQ_O_AIRPORT1_1.Name = "REQ_O_AIRPORT1_1"
Me.REQ_O_AIRPORT1_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT1_1.Text = Nothing
Me.REQ_O_AIRPORT1_1.Top = 12.09685!
Me.REQ_O_AIRPORT1_1.Width = 0.9858268!
'
'Label167
'
Me.Label167.Height = 0.2!
Me.Label167.HyperLink = Nothing
Me.Label167.Left = 0.2291339!
Me.Label167.Name = "Label167"
Me.Label167.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label167.Text = "出発地"
Me.Label167.Top = 12.09685!
Me.Label167.Width = 0.6874015!
'
'Label163
'
Me.Label163.Height = 0.2!
Me.Label163.HyperLink = Nothing
Me.Label163.Left = 0.2291339!
Me.Label163.Name = "Label163"
Me.Label163.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label163.Text = "列車・便名"
Me.Label163.Top = 11.89685!
Me.Label163.Width = 0.6874015!
'
'REQ_O_DATE_1
'
Me.REQ_O_DATE_1.DataField = "REQ_O_DATE_1"
Me.REQ_O_DATE_1.Height = 0.2!
Me.REQ_O_DATE_1.Left = 0.9165355!
Me.REQ_O_DATE_1.Name = "REQ_O_DATE_1"
Me.REQ_O_DATE_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_DATE_1.Text = Nothing
Me.REQ_O_DATE_1.Top = 11.69685!
Me.REQ_O_DATE_1.Width = 0.9858268!
'
'REQ_O_TEHAI_1
'
Me.REQ_O_TEHAI_1.DataField = "REQ_O_TEHAI_1"
Me.REQ_O_TEHAI_1.Height = 0.1999998!
Me.REQ_O_TEHAI_1.Left = 0.9165355!
Me.REQ_O_TEHAI_1.Name = "REQ_O_TEHAI_1"
Me.REQ_O_TEHAI_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TEHAI_1.Text = Nothing
Me.REQ_O_TEHAI_1.Top = 11.49685!
Me.REQ_O_TEHAI_1.Width = 0.9858268!
'
'Label171
'
Me.Label171.Height = 0.2!
Me.Label171.HyperLink = Nothing
Me.Label171.Left = 0.2291339!
Me.Label171.Name = "Label171"
Me.Label171.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label171.Text = "利用日"
Me.Label171.Top = 11.69685!
Me.Label171.Width = 0.6874015!
'
'Label168
'
Me.Label168.Height = 0.1999999!
Me.Label168.HyperLink = Nothing
Me.Label168.Left = 0.2291346!
Me.Label168.Name = "Label168"
Me.Label168.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label168.Text = "希望する"
Me.Label168.Top = 11.49685!
Me.Label168.Width = 0.6874014!
'
'FUKURO2
'
Me.FUKURO2.Height = 1.2!
Me.FUKURO2.HyperLink = Nothing
Me.FUKURO2.Left = 3.558662!
Me.FUKURO2.Name = "FUKURO2"
Me.FUKURO2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: b"& _ 
    "old; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-v"& _ 
    "ertical: true"
Me.FUKURO2.Text = ""
Me.FUKURO2.Top = 12.69685!
Me.FUKURO2.Width = 0.2051181!
'
'REQ_O_TIME2_3
'
Me.REQ_O_TIME2_3.DataField = "REQ_O_TIME2_3"
Me.REQ_O_TIME2_3.Height = 0.2!
Me.REQ_O_TIME2_3.Left = 2.579528!
Me.REQ_O_TIME2_3.Name = "REQ_O_TIME2_3"
Me.REQ_O_TIME2_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME2_3.Text = Nothing
Me.REQ_O_TIME2_3.Top = 14.69685!
Me.REQ_O_TIME2_3.Width = 0.9791338!
'
'REQ_O_AIRPORT2_3
'
Me.REQ_O_AIRPORT2_3.DataField = "REQ_O_AIRPORT2_3"
Me.REQ_O_AIRPORT2_3.Height = 0.2!
Me.REQ_O_AIRPORT2_3.Left = 2.579528!
Me.REQ_O_AIRPORT2_3.Name = "REQ_O_AIRPORT2_3"
Me.REQ_O_AIRPORT2_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT2_3.Text = Nothing
Me.REQ_O_AIRPORT2_3.Top = 14.49685!
Me.REQ_O_AIRPORT2_3.Width = 0.9791338!
'
'Label216
'
Me.Label216.Height = 0.2!
Me.Label216.HyperLink = Nothing
Me.Label216.Left = 3.558662!
Me.Label216.Name = "Label216"
Me.Label216.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label216.Text = "性別"
Me.Label216.Top = 11.29685!
Me.Label216.Width = 0.9488187!
'
'Label215
'
Me.Label215.Height = 0.2!
Me.Label215.HyperLink = Nothing
Me.Label215.Left = 3.558662!
Me.Label215.Name = "Label215"
Me.Label215.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label215.Text = "施設住所"
Me.Label215.Top = 11.09685!
Me.Label215.Width = 0.9488187!
'
'Label214
'
Me.Label214.Height = 0.2!
Me.Label214.HyperLink = Nothing
Me.Label214.Left = 3.558662!
Me.Label214.Name = "Label214"
Me.Label214.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label214.Text = "施設名"
Me.Label214.Top = 10.89685!
Me.Label214.Width = 0.9488187!
'
'Label211
'
Me.Label211.Height = 0.2!
Me.Label211.HyperLink = Nothing
Me.Label211.Left = 3.558662!
Me.Label211.Name = "Label211"
Me.Label211.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label211.Text = "DRコード"
Me.Label211.Top = 10.69685!
Me.Label211.Width = 0.9488187!
'
'Label208
'
Me.Label208.Height = 0.2!
Me.Label208.HyperLink = Nothing
Me.Label208.Left = 3.558662!
Me.Label208.Name = "Label208"
Me.Label208.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label208.Text = "手配ステータス"
Me.Label208.Top = 10.49685!
Me.Label208.Width = 0.9488187!
'
'Line140
'
Me.Line140.Height = 1!
Me.Line140.Left = 2.589764!
Me.Line140.LineWeight = 1!
Me.Line140.Name = "Line140"
Me.Line140.Top = 14.49685!
Me.Line140.Width = 0!
Me.Line140.X1 = 2.589764!
Me.Line140.X2 = 2.589764!
Me.Line140.Y1 = 14.49685!
Me.Line140.Y2 = 15.49685!
'
'Label201
'
Me.Label201.Height = 0.2!
Me.Label201.HyperLink = Nothing
Me.Label201.Left = 0.229134!
Me.Label201.Name = "Label201"
Me.Label201.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label201.Text = "出発地"
Me.Label201.Top = 14.49685!
Me.Label201.Width = 0.6874015!
'
'Label199
'
Me.Label199.Height = 0.2!
Me.Label199.HyperLink = Nothing
Me.Label199.Left = 0.229134!
Me.Label199.Name = "Label199"
Me.Label199.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label199.Text = "出発時間"
Me.Label199.Top = 14.69685!
Me.Label199.Width = 0.6874014!
'
'Label190
'
Me.Label190.Height = 0.2!
Me.Label190.HyperLink = Nothing
Me.Label190.Left = 3.763779!
Me.Label190.Name = "Label190"
Me.Label190.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label190.Text = "出発地"
Me.Label190.Top = 14.49685!
Me.Label190.Width = 0.743701!
'
'REQ_O_AIRPORT1_3
'
Me.REQ_O_AIRPORT1_3.DataField = "REQ_O_AIRPORT1_3"
Me.REQ_O_AIRPORT1_3.Height = 0.2!
Me.REQ_O_AIRPORT1_3.Left = 0.9165355!
Me.REQ_O_AIRPORT1_3.Name = "REQ_O_AIRPORT1_3"
Me.REQ_O_AIRPORT1_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT1_3.Text = Nothing
Me.REQ_O_AIRPORT1_3.Top = 14.49685!
Me.REQ_O_AIRPORT1_3.Width = 0.9755906!
'
'REQ_F_AIRPORT2_3
'
Me.REQ_F_AIRPORT2_3.DataField = "REQ_F_AIRPORT2_3"
Me.REQ_F_AIRPORT2_3.Height = 0.2!
Me.REQ_F_AIRPORT2_3.Left = 6.172835!
Me.REQ_F_AIRPORT2_3.Name = "REQ_F_AIRPORT2_3"
Me.REQ_F_AIRPORT2_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT2_3.Text = Nothing
Me.REQ_F_AIRPORT2_3.Top = 14.49685!
Me.REQ_F_AIRPORT2_3.Width = 0.979134!
'
'REQ_F_TIME2_3
'
Me.REQ_F_TIME2_3.DataField = "REQ_F_TIME2_3"
Me.REQ_F_TIME2_3.Height = 0.2!
Me.REQ_F_TIME2_3.Left = 6.172835!
Me.REQ_F_TIME2_3.Name = "REQ_F_TIME2_3"
Me.REQ_F_TIME2_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME2_3.Text = Nothing
Me.REQ_F_TIME2_3.Top = 14.69685!
Me.REQ_F_TIME2_3.Width = 0.979134!
'
'TO_DATE
'
Me.TO_DATE.DataField = "TO_DATE"
Me.TO_DATE.Height = 0.2!
Me.TO_DATE.Left = 0.6771654!
Me.TO_DATE.Name = "TO_DATE"
Me.TO_DATE.Style = "font-weight: normal; white-space: nowrap"
Me.TO_DATE.Text = Nothing
Me.TO_DATE.Top = 0.6740158!
Me.TO_DATE.Visible = false
Me.TO_DATE.Width = 2.871259!
'
'TAXI_PRT_NAME1
'
Me.TAXI_PRT_NAME1.DataField = "TAXI_PRT_NAME"
Me.TAXI_PRT_NAME1.Height = 0.2!
Me.TAXI_PRT_NAME1.Left = 5.942914!
Me.TAXI_PRT_NAME1.Name = "TAXI_PRT_NAME1"
Me.TAXI_PRT_NAME1.Style = "vertical-align: middle"
Me.TAXI_PRT_NAME1.Top = 0.2740158!
Me.TAXI_PRT_NAME1.Width = 1.209055!
'
'Label220
'
Me.Label220.Height = 0.2!
Me.Label220.HyperLink = Nothing
Me.Label220.Left = 4.673229!
Me.Label220.Name = "Label220"
Me.Label220.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
Me.Label220.Text = "チケット印字名："
Me.Label220.Top = 0.2740158!
Me.Label220.Width = 1.269685!
'
'FROM_DATE
'
Me.FROM_DATE.DataField = "FROM_DATE"
Me.FROM_DATE.Height = 0.2!
Me.FROM_DATE.Left = 0.6771654!
Me.FROM_DATE.Name = "FROM_DATE"
Me.FROM_DATE.Style = "font-weight: normal; white-space: nowrap"
Me.FROM_DATE.Text = Nothing
Me.FROM_DATE.Top = 0.6740158!
Me.FROM_DATE.Visible = false
Me.FROM_DATE.Width = 2.87126!
'
'Label219
'
Me.Label219.Height = 0.2!
Me.Label219.HyperLink = Nothing
Me.Label219.Left = 0!
Me.Label219.Name = "Label219"
Me.Label219.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
Me.Label219.Text = "開催日："
Me.Label219.Top = 0.6740158!
Me.Label219.Width = 0.6771654!
'
'FUKURO4
'
Me.FUKURO4.Height = 1.2!
Me.FUKURO4.HyperLink = Nothing
Me.FUKURO4.Left = 3.558662!
Me.FUKURO4.Name = "FUKURO4"
Me.FUKURO4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: b"& _ 
    "old; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-v"& _ 
    "ertical: true"
Me.FUKURO4.Text = ""
Me.FUKURO4.Top = 15.09685!
Me.FUKURO4.Width = 0.2051181!
'
'Line117
'
Me.Line117.Height = 0!
Me.Line117.Left = 3.787796!
Me.Line117.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line117.LineWeight = 1!
Me.Line117.Name = "Line117"
Me.Line117.Top = 12.69685!
Me.Line117.Width = 1.586221!
Me.Line117.X1 = 3.787796!
Me.Line117.X2 = 5.374017!
Me.Line117.Y1 = 12.69685!
Me.Line117.Y2 = 12.69685!
'
'Line116
'
Me.Line116.Height = 0!
Me.Line116.Left = 3.787796!
Me.Line116.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line116.LineWeight = 1!
Me.Line116.Name = "Line116"
Me.Line116.Top = 12.49685!
Me.Line116.Width = 1.586221!
Me.Line116.X1 = 3.787796!
Me.Line116.X2 = 5.374017!
Me.Line116.Y1 = 12.49685!
Me.Line116.Y2 = 12.49685!
'
'Line115
'
Me.Line115.Height = 0!
Me.Line115.Left = 3.787796!
Me.Line115.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line115.LineWeight = 1!
Me.Line115.Name = "Line115"
Me.Line115.Top = 12.29685!
Me.Line115.Width = 1.586221!
Me.Line115.X1 = 3.787796!
Me.Line115.X2 = 5.374017!
Me.Line115.Y1 = 12.29685!
Me.Line115.Y2 = 12.29685!
'
'Line114
'
Me.Line114.Height = 0!
Me.Line114.Left = 3.787796!
Me.Line114.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line114.LineWeight = 1!
Me.Line114.Name = "Line114"
Me.Line114.Top = 12.09685!
Me.Line114.Width = 1.586221!
Me.Line114.X1 = 3.787796!
Me.Line114.X2 = 5.374017!
Me.Line114.Y1 = 12.09685!
Me.Line114.Y2 = 12.09685!
'
'Line113
'
Me.Line113.Height = 0!
Me.Line113.Left = 3.787796!
Me.Line113.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line113.LineWeight = 1!
Me.Line113.Name = "Line113"
Me.Line113.Top = 11.89685!
Me.Line113.Width = 1.586221!
Me.Line113.X1 = 3.787796!
Me.Line113.X2 = 5.374017!
Me.Line113.Y1 = 11.89685!
Me.Line113.Y2 = 11.89685!
'
'Line112
'
Me.Line112.Height = 0!
Me.Line112.Left = 3.787796!
Me.Line112.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line112.LineWeight = 1!
Me.Line112.Name = "Line112"
Me.Line112.Top = 11.69685!
Me.Line112.Width = 1.586221!
Me.Line112.X1 = 3.787796!
Me.Line112.X2 = 5.374017!
Me.Line112.Y1 = 11.69685!
Me.Line112.Y2 = 11.69685!
'
'REQ_F_DATE_1
'
Me.REQ_F_DATE_1.DataField = "REQ_F_DATE_1"
Me.REQ_F_DATE_1.Height = 0.2!
Me.REQ_F_DATE_1.Left = 4.507481!
Me.REQ_F_DATE_1.Name = "REQ_F_DATE_1"
Me.REQ_F_DATE_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_DATE_1.Text = Nothing
Me.REQ_F_DATE_1.Top = 11.69685!
Me.REQ_F_DATE_1.Width = 0.9779529!
'
'REQ_F_KOTSUKIKAN_1
'
Me.REQ_F_KOTSUKIKAN_1.DataField = "REQ_F_KOTSUKIKAN_1"
Me.REQ_F_KOTSUKIKAN_1.Height = 0.2!
Me.REQ_F_KOTSUKIKAN_1.Left = 6.172835!
Me.REQ_F_KOTSUKIKAN_1.Name = "REQ_F_KOTSUKIKAN_1"
Me.REQ_F_KOTSUKIKAN_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_KOTSUKIKAN_1.Text = Nothing
Me.REQ_F_KOTSUKIKAN_1.Top = 11.69685!
Me.REQ_F_KOTSUKIKAN_1.Width = 0.988583!
'
'REQ_F_IRAINAIYOU_1
'
Me.REQ_F_IRAINAIYOU_1.DataField = "REQ_F_IRAINAIYOU_1"
Me.REQ_F_IRAINAIYOU_1.Height = 0.1999998!
Me.REQ_F_IRAINAIYOU_1.Left = 6.172835!
Me.REQ_F_IRAINAIYOU_1.Name = "REQ_F_IRAINAIYOU_1"
Me.REQ_F_IRAINAIYOU_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_IRAINAIYOU_1.Text = Nothing
Me.REQ_F_IRAINAIYOU_1.Top = 11.49685!
Me.REQ_F_IRAINAIYOU_1.Width = 0.9791338!
'
'REQ_F_TEHAI_1
'
Me.REQ_F_TEHAI_1.DataField = "REQ_F_TEHAI_1"
Me.REQ_F_TEHAI_1.Height = 0.1999998!
Me.REQ_F_TEHAI_1.Left = 4.507481!
Me.REQ_F_TEHAI_1.Name = "REQ_F_TEHAI_1"
Me.REQ_F_TEHAI_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TEHAI_1.Text = Nothing
Me.REQ_F_TEHAI_1.Top = 11.49685!
Me.REQ_F_TEHAI_1.Width = 0.977953!
'
'Label174
'
Me.Label174.Height = 0.2!
Me.Label174.HyperLink = Nothing
Me.Label174.Left = 5.485433!
Me.Label174.Name = "Label174"
Me.Label174.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label174.Text = "交通機関"
Me.Label174.Top = 11.69685!
Me.Label174.Width = 0.6874018!
'
'Label173
'
Me.Label173.Height = 0.2!
Me.Label173.HyperLink = Nothing
Me.Label173.Left = 5.485434!
Me.Label173.Name = "Label173"
Me.Label173.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label173.Text = "依頼内容"
Me.Label173.Top = 11.49685!
Me.Label173.Width = 0.6874018!
'
'Label159
'
Me.Label159.Height = 0.2!
Me.Label159.HyperLink = Nothing
Me.Label159.Left = 5.485433!
Me.Label159.Name = "Label159"
Me.Label159.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label159.Text = "到着地"
Me.Label159.Top = 12.09685!
Me.Label159.Width = 0.6874022!
'
'Label157
'
Me.Label157.Height = 0.2!
Me.Label157.HyperLink = Nothing
Me.Label157.Left = 5.485433!
Me.Label157.Name = "Label157"
Me.Label157.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label157.Text = "到着時間"
Me.Label157.Top = 12.29685!
Me.Label157.Width = 0.6874022!
'
'Label154
'
Me.Label154.Height = 0.2!
Me.Label154.HyperLink = Nothing
Me.Label154.Left = 5.485433!
Me.Label154.Name = "Label154"
Me.Label154.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label154.Text = "座席希望"
Me.Label154.Top = 12.49685!
Me.Label154.Width = 0.6874018!
'
'REQ_F_AIRPORT1_1
'
Me.REQ_F_AIRPORT1_1.DataField = "REQ_F_AIRPORT1_1"
Me.REQ_F_AIRPORT1_1.Height = 0.2!
Me.REQ_F_AIRPORT1_1.Left = 4.507481!
Me.REQ_F_AIRPORT1_1.Name = "REQ_F_AIRPORT1_1"
Me.REQ_F_AIRPORT1_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT1_1.Text = Nothing
Me.REQ_F_AIRPORT1_1.Top = 12.09685!
Me.REQ_F_AIRPORT1_1.Width = 0.9779529!
'
'REQ_F_AIRPORT2_1
'
Me.REQ_F_AIRPORT2_1.DataField = "REQ_F_AIRPORT2_1"
Me.REQ_F_AIRPORT2_1.Height = 0.2!
Me.REQ_F_AIRPORT2_1.Left = 6.172835!
Me.REQ_F_AIRPORT2_1.Name = "REQ_F_AIRPORT2_1"
Me.REQ_F_AIRPORT2_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT2_1.Text = Nothing
Me.REQ_F_AIRPORT2_1.Top = 12.09685!
Me.REQ_F_AIRPORT2_1.Width = 0.979134!
'
'REQ_F_TIME1_1
'
Me.REQ_F_TIME1_1.DataField = "REQ_F_TIME1_1"
Me.REQ_F_TIME1_1.Height = 0.2!
Me.REQ_F_TIME1_1.Left = 4.507481!
Me.REQ_F_TIME1_1.Name = "REQ_F_TIME1_1"
Me.REQ_F_TIME1_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME1_1.Text = Nothing
Me.REQ_F_TIME1_1.Top = 12.29685!
Me.REQ_F_TIME1_1.Width = 0.9779529!
'
'REQ_F_TIME2_1
'
Me.REQ_F_TIME2_1.DataField = "REQ_F_TIME2_1"
Me.REQ_F_TIME2_1.Height = 0.2!
Me.REQ_F_TIME2_1.Left = 6.172835!
Me.REQ_F_TIME2_1.Name = "REQ_F_TIME2_1"
Me.REQ_F_TIME2_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME2_1.Text = Nothing
Me.REQ_F_TIME2_1.Top = 12.29685!
Me.REQ_F_TIME2_1.Width = 0.979134!
'
'REQ_F_BIN_1
'
Me.REQ_F_BIN_1.DataField = "REQ_F_BIN_1"
Me.REQ_F_BIN_1.Height = 0.2!
Me.REQ_F_BIN_1.Left = 4.507481!
Me.REQ_F_BIN_1.Name = "REQ_F_BIN_1"
Me.REQ_F_BIN_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_BIN_1.Text = Nothing
Me.REQ_F_BIN_1.Top = 11.89685!
Me.REQ_F_BIN_1.Width = 2.644488!
'
'REQ_F_SEAT_1
'
Me.REQ_F_SEAT_1.DataField = "REQ_F_SEAT_1"
Me.REQ_F_SEAT_1.Height = 0.2!
Me.REQ_F_SEAT_1.Left = 4.507481!
Me.REQ_F_SEAT_1.Name = "REQ_F_SEAT_1"
Me.REQ_F_SEAT_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_1.Text = Nothing
Me.REQ_F_SEAT_1.Top = 12.49685!
Me.REQ_F_SEAT_1.Width = 0.9779529!
'
'REQ_F_SEAT_KIBOU1
'
Me.REQ_F_SEAT_KIBOU1.DataField = "REQ_F_SEAT_KIBOU1"
Me.REQ_F_SEAT_KIBOU1.Height = 0.2!
Me.REQ_F_SEAT_KIBOU1.Left = 6.172835!
Me.REQ_F_SEAT_KIBOU1.Name = "REQ_F_SEAT_KIBOU1"
Me.REQ_F_SEAT_KIBOU1.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_KIBOU1.Text = Nothing
Me.REQ_F_SEAT_KIBOU1.Top = 12.49685!
Me.REQ_F_SEAT_KIBOU1.Width = 0.979134!
'
'TAXI_TESURYO
'
Me.TAXI_TESURYO.Height = 0.2!
Me.TAXI_TESURYO.Left = 1.227559!
Me.TAXI_TESURYO.Name = "TAXI_TESURYO"
Me.TAXI_TESURYO.Style = "background-color: darkgray; vertical-align: middle"
Me.TAXI_TESURYO.Text = Nothing
Me.TAXI_TESURYO.Top = 9.302755!
Me.TAXI_TESURYO.Width = 0.3854332!
'
'Label87
'
Me.Label87.Height = 0.2!
Me.Label87.HyperLink = Nothing
Me.Label87.Left = 3.329135!
Me.Label87.Name = "Label87"
Me.Label87.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label87.Text = "依頼金額"
Me.Label87.Top = 9.102752!
Me.Label87.Width = 0.5811025!
'
'Label92
'
Me.Label92.Height = 0.2!
Me.Label92.HyperLink = Nothing
Me.Label92.Left = 1.612992!
Me.Label92.Name = "Label92"
Me.Label92.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;"& _ 
    " white-space: nowrap"
Me.Label92.Text = "×"
Me.Label92.Top = 9.302755!
Me.Label92.Width = 0.3948819!
'
'Label91
'
Me.Label91.Height = 0.2!
Me.Label91.HyperLink = Nothing
Me.Label91.Left = 2.384186E-07!
Me.Label91.Name = "Label91"
Me.Label91.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label91.Text = "タクチケ発行手数料@"
Me.Label91.Top = 9.302755!
Me.Label91.Width = 1.227559!
'
'Label90
'
Me.Label90.Height = 0.2!
Me.Label90.HyperLink = Nothing
Me.Label90.Left = 4.172325E-07!
Me.Label90.Name = "Label90"
Me.Label90.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label90.Text = "行程10"
Me.Label90.Top = 9.102752!
Me.Label90.Width = 0.448819!
'
'Label89
'
Me.Label89.Height = 0.2!
Me.Label89.HyperLink = Nothing
Me.Label89.Left = 0.4488194!
Me.Label89.Name = "Label89"
Me.Label89.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label89.Text = "利用日"
Me.Label89.Top = 9.102752!
Me.Label89.Width = 0.3948819!
'
'REQ_TAXI_DATE_10
'
Me.REQ_TAXI_DATE_10.DataField = "REQ_TAXI_DATE_10"
Me.REQ_TAXI_DATE_10.Height = 0.1999998!
Me.REQ_TAXI_DATE_10.Left = 0.843701!
Me.REQ_TAXI_DATE_10.Name = "REQ_TAXI_DATE_10"
Me.REQ_TAXI_DATE_10.Text = Nothing
Me.REQ_TAXI_DATE_10.Top = 9.102752!
Me.REQ_TAXI_DATE_10.Width = 0.7692917!
'
'Label88
'
Me.Label88.Height = 0.2!
Me.Label88.HyperLink = Nothing
Me.Label88.Left = 1.612993!
Me.Label88.Name = "Label88"
Me.Label88.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label88.Text = "発地"
Me.Label88.Top = 9.102752!
Me.Label88.Width = 0.3948819!
'
'REQ_TAXI_FROM_10
'
Me.REQ_TAXI_FROM_10.DataField = "REQ_TAXI_FROM_10"
Me.REQ_TAXI_FROM_10.Height = 0.1999998!
Me.REQ_TAXI_FROM_10.Left = 2.007875!
Me.REQ_TAXI_FROM_10.Name = "REQ_TAXI_FROM_10"
Me.REQ_TAXI_FROM_10.Text = Nothing
Me.REQ_TAXI_FROM_10.Top = 9.102752!
Me.REQ_TAXI_FROM_10.Width = 1.32126!
'
'TAXI_YOTEIKINGAKU_10
'
Me.TAXI_YOTEIKINGAKU_10.DataField = "TAXI_YOTEIKINGAKU_10"
Me.TAXI_YOTEIKINGAKU_10.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_10.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_10.Name = "TAXI_YOTEIKINGAKU_10"
Me.TAXI_YOTEIKINGAKU_10.Text = Nothing
Me.TAXI_YOTEIKINGAKU_10.Top = 9.102752!
Me.TAXI_YOTEIKINGAKU_10.Width = 1.009056!
'
'Label86
'
Me.Label86.Height = 0.2!
Me.Label86.HyperLink = Nothing
Me.Label86.Left = 4.172325E-07!
Me.Label86.Name = "Label86"
Me.Label86.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label86.Text = "行程9"
Me.Label86.Top = 8.902754!
Me.Label86.Width = 0.448819!
'
'Label85
'
Me.Label85.Height = 0.2!
Me.Label85.HyperLink = Nothing
Me.Label85.Left = 0.4488194!
Me.Label85.Name = "Label85"
Me.Label85.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label85.Text = "利用日"
Me.Label85.Top = 8.902754!
Me.Label85.Width = 0.3948819!
'
'REQ_TAXI_DATE_9
'
Me.REQ_TAXI_DATE_9.DataField = "REQ_TAXI_DATE_9"
Me.REQ_TAXI_DATE_9.Height = 0.1999998!
Me.REQ_TAXI_DATE_9.Left = 0.843701!
Me.REQ_TAXI_DATE_9.Name = "REQ_TAXI_DATE_9"
Me.REQ_TAXI_DATE_9.Text = Nothing
Me.REQ_TAXI_DATE_9.Top = 8.902754!
Me.REQ_TAXI_DATE_9.Width = 0.7692917!
'
'Label84
'
Me.Label84.Height = 0.2!
Me.Label84.HyperLink = Nothing
Me.Label84.Left = 1.612993!
Me.Label84.Name = "Label84"
Me.Label84.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label84.Text = "発地"
Me.Label84.Top = 8.902754!
Me.Label84.Width = 0.3948819!
'
'REQ_TAXI_FROM_9
'
Me.REQ_TAXI_FROM_9.DataField = "REQ_TAXI_FROM_9"
Me.REQ_TAXI_FROM_9.Height = 0.1999998!
Me.REQ_TAXI_FROM_9.Left = 2.007875!
Me.REQ_TAXI_FROM_9.Name = "REQ_TAXI_FROM_9"
Me.REQ_TAXI_FROM_9.Text = Nothing
Me.REQ_TAXI_FROM_9.Top = 8.902754!
Me.REQ_TAXI_FROM_9.Width = 1.32126!
'
'Label83
'
Me.Label83.Height = 0.2!
Me.Label83.HyperLink = Nothing
Me.Label83.Left = 3.329135!
Me.Label83.Name = "Label83"
Me.Label83.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label83.Text = "依頼金額"
Me.Label83.Top = 8.902754!
Me.Label83.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_9
'
Me.TAXI_YOTEIKINGAKU_9.DataField = "TAXI_YOTEIKINGAKU_9"
Me.TAXI_YOTEIKINGAKU_9.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_9.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_9.Name = "TAXI_YOTEIKINGAKU_9"
Me.TAXI_YOTEIKINGAKU_9.Text = Nothing
Me.TAXI_YOTEIKINGAKU_9.Top = 8.902754!
Me.TAXI_YOTEIKINGAKU_9.Width = 1.009056!
'
'Label82
'
Me.Label82.Height = 0.2!
Me.Label82.HyperLink = Nothing
Me.Label82.Left = 4.172325E-07!
Me.Label82.Name = "Label82"
Me.Label82.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label82.Text = "行程8"
Me.Label82.Top = 8.702752!
Me.Label82.Width = 0.448819!
'
'Label81
'
Me.Label81.Height = 0.2!
Me.Label81.HyperLink = Nothing
Me.Label81.Left = 0.4488194!
Me.Label81.Name = "Label81"
Me.Label81.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label81.Text = "利用日"
Me.Label81.Top = 8.702752!
Me.Label81.Width = 0.3948819!
'
'REQ_TAXI_DATE_8
'
Me.REQ_TAXI_DATE_8.DataField = "REQ_TAXI_DATE_8"
Me.REQ_TAXI_DATE_8.Height = 0.1999998!
Me.REQ_TAXI_DATE_8.Left = 0.843701!
Me.REQ_TAXI_DATE_8.Name = "REQ_TAXI_DATE_8"
Me.REQ_TAXI_DATE_8.Text = Nothing
Me.REQ_TAXI_DATE_8.Top = 8.702752!
Me.REQ_TAXI_DATE_8.Width = 0.7692917!
'
'Label80
'
Me.Label80.Height = 0.2!
Me.Label80.HyperLink = Nothing
Me.Label80.Left = 1.612993!
Me.Label80.Name = "Label80"
Me.Label80.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; white-space: nowrap"
Me.Label80.Text = "発地"
Me.Label80.Top = 8.702752!
Me.Label80.Width = 0.3948819!
'
'REQ_TAXI_FROM_8
'
Me.REQ_TAXI_FROM_8.DataField = "REQ_TAXI_FROM_8"
Me.REQ_TAXI_FROM_8.Height = 0.1999998!
Me.REQ_TAXI_FROM_8.Left = 2.007875!
Me.REQ_TAXI_FROM_8.Name = "REQ_TAXI_FROM_8"
Me.REQ_TAXI_FROM_8.Text = Nothing
Me.REQ_TAXI_FROM_8.Top = 8.702752!
Me.REQ_TAXI_FROM_8.Width = 1.32126!
'
'Label79
'
Me.Label79.Height = 0.2!
Me.Label79.HyperLink = Nothing
Me.Label79.Left = 3.329135!
Me.Label79.Name = "Label79"
Me.Label79.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label79.Text = "依頼金額"
Me.Label79.Top = 8.702752!
Me.Label79.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_8
'
Me.TAXI_YOTEIKINGAKU_8.DataField = "TAXI_YOTEIKINGAKU_8"
Me.TAXI_YOTEIKINGAKU_8.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_8.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_8.Name = "TAXI_YOTEIKINGAKU_8"
Me.TAXI_YOTEIKINGAKU_8.Text = Nothing
Me.TAXI_YOTEIKINGAKU_8.Top = 8.702752!
Me.TAXI_YOTEIKINGAKU_8.Width = 1.009056!
'
'Label78
'
Me.Label78.Height = 0.2!
Me.Label78.HyperLink = Nothing
Me.Label78.Left = 4.172325E-07!
Me.Label78.Name = "Label78"
Me.Label78.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label78.Text = "行程7"
Me.Label78.Top = 8.502752!
Me.Label78.Width = 0.448819!
'
'Label77
'
Me.Label77.Height = 0.2!
Me.Label77.HyperLink = Nothing
Me.Label77.Left = 0.4488194!
Me.Label77.Name = "Label77"
Me.Label77.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label77.Text = "利用日"
Me.Label77.Top = 8.502752!
Me.Label77.Width = 0.3948819!
'
'REQ_TAXI_DATE_7
'
Me.REQ_TAXI_DATE_7.DataField = "REQ_TAXI_DATE_7"
Me.REQ_TAXI_DATE_7.Height = 0.1999998!
Me.REQ_TAXI_DATE_7.Left = 0.843701!
Me.REQ_TAXI_DATE_7.Name = "REQ_TAXI_DATE_7"
Me.REQ_TAXI_DATE_7.Text = Nothing
Me.REQ_TAXI_DATE_7.Top = 8.502752!
Me.REQ_TAXI_DATE_7.Width = 0.7692917!
'
'Label76
'
Me.Label76.Height = 0.2!
Me.Label76.HyperLink = Nothing
Me.Label76.Left = 1.612993!
Me.Label76.Name = "Label76"
Me.Label76.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label76.Text = "発地"
Me.Label76.Top = 8.502752!
Me.Label76.Width = 0.3948819!
'
'REQ_TAXI_FROM_7
'
Me.REQ_TAXI_FROM_7.DataField = "REQ_TAXI_FROM_7"
Me.REQ_TAXI_FROM_7.Height = 0.1999998!
Me.REQ_TAXI_FROM_7.Left = 2.007875!
Me.REQ_TAXI_FROM_7.Name = "REQ_TAXI_FROM_7"
Me.REQ_TAXI_FROM_7.Text = Nothing
Me.REQ_TAXI_FROM_7.Top = 8.502752!
Me.REQ_TAXI_FROM_7.Width = 1.32126!
'
'Label66
'
Me.Label66.Height = 0.2!
Me.Label66.HyperLink = Nothing
Me.Label66.Left = 3.329135!
Me.Label66.Name = "Label66"
Me.Label66.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label66.Text = "依頼金額"
Me.Label66.Top = 8.502752!
Me.Label66.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_7
'
Me.TAXI_YOTEIKINGAKU_7.DataField = "TAXI_YOTEIKINGAKU_7"
Me.TAXI_YOTEIKINGAKU_7.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_7.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_7.Name = "TAXI_YOTEIKINGAKU_7"
Me.TAXI_YOTEIKINGAKU_7.Text = Nothing
Me.TAXI_YOTEIKINGAKU_7.Top = 8.502752!
Me.TAXI_YOTEIKINGAKU_7.Width = 1.009056!
'
'Label65
'
Me.Label65.Height = 0.2!
Me.Label65.HyperLink = Nothing
Me.Label65.Left = 4.172325E-07!
Me.Label65.Name = "Label65"
Me.Label65.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label65.Text = "行程6"
Me.Label65.Top = 8.302748!
Me.Label65.Width = 0.448819!
'
'Label64
'
Me.Label64.Height = 0.2!
Me.Label64.HyperLink = Nothing
Me.Label64.Left = 0.4488194!
Me.Label64.Name = "Label64"
Me.Label64.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label64.Text = "利用日"
Me.Label64.Top = 8.302748!
Me.Label64.Width = 0.3948819!
'
'REQ_TAXI_DATE_6
'
Me.REQ_TAXI_DATE_6.DataField = "REQ_TAXI_DATE_6"
Me.REQ_TAXI_DATE_6.Height = 0.1999998!
Me.REQ_TAXI_DATE_6.Left = 0.843701!
Me.REQ_TAXI_DATE_6.Name = "REQ_TAXI_DATE_6"
Me.REQ_TAXI_DATE_6.Text = Nothing
Me.REQ_TAXI_DATE_6.Top = 8.302748!
Me.REQ_TAXI_DATE_6.Width = 0.7692917!
'
'Label63
'
Me.Label63.Height = 0.2!
Me.Label63.HyperLink = Nothing
Me.Label63.Left = 1.612993!
Me.Label63.Name = "Label63"
Me.Label63.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label63.Text = "発地"
Me.Label63.Top = 8.302748!
Me.Label63.Width = 0.3948819!
'
'REQ_TAXI_FROM_6
'
Me.REQ_TAXI_FROM_6.DataField = "REQ_TAXI_FROM_6"
Me.REQ_TAXI_FROM_6.Height = 0.1999998!
Me.REQ_TAXI_FROM_6.Left = 2.007875!
Me.REQ_TAXI_FROM_6.Name = "REQ_TAXI_FROM_6"
Me.REQ_TAXI_FROM_6.Text = Nothing
Me.REQ_TAXI_FROM_6.Top = 8.302748!
Me.REQ_TAXI_FROM_6.Width = 1.32126!
'
'Label62
'
Me.Label62.Height = 0.2!
Me.Label62.HyperLink = Nothing
Me.Label62.Left = 3.329135!
Me.Label62.Name = "Label62"
Me.Label62.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label62.Text = "依頼金額"
Me.Label62.Top = 8.302748!
Me.Label62.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_6
'
Me.TAXI_YOTEIKINGAKU_6.DataField = "TAXI_YOTEIKINGAKU_6"
Me.TAXI_YOTEIKINGAKU_6.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_6.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_6.Name = "TAXI_YOTEIKINGAKU_6"
Me.TAXI_YOTEIKINGAKU_6.Text = Nothing
Me.TAXI_YOTEIKINGAKU_6.Top = 8.302748!
Me.TAXI_YOTEIKINGAKU_6.Width = 1.009056!
'
'Label61
'
Me.Label61.Height = 0.2!
Me.Label61.HyperLink = Nothing
Me.Label61.Left = 4.172325E-07!
Me.Label61.Name = "Label61"
Me.Label61.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label61.Text = "行程5"
Me.Label61.Top = 8.10275!
Me.Label61.Width = 0.448819!
'
'Label60
'
Me.Label60.Height = 0.2!
Me.Label60.HyperLink = Nothing
Me.Label60.Left = 0.4488194!
Me.Label60.Name = "Label60"
Me.Label60.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label60.Text = "利用日"
Me.Label60.Top = 8.10275!
Me.Label60.Width = 0.3948819!
'
'REQ_TAXI_DATE_5
'
Me.REQ_TAXI_DATE_5.DataField = "REQ_TAXI_DATE_5"
Me.REQ_TAXI_DATE_5.Height = 0.1999998!
Me.REQ_TAXI_DATE_5.Left = 0.843701!
Me.REQ_TAXI_DATE_5.Name = "REQ_TAXI_DATE_5"
Me.REQ_TAXI_DATE_5.Text = Nothing
Me.REQ_TAXI_DATE_5.Top = 8.10275!
Me.REQ_TAXI_DATE_5.Width = 0.7692917!
'
'Label59
'
Me.Label59.Height = 0.2!
Me.Label59.HyperLink = Nothing
Me.Label59.Left = 1.612993!
Me.Label59.Name = "Label59"
Me.Label59.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; white-space: nowrap"
Me.Label59.Text = "発地"
Me.Label59.Top = 8.10275!
Me.Label59.Width = 0.3948819!
'
'REQ_TAXI_FROM_5
'
Me.REQ_TAXI_FROM_5.DataField = "REQ_TAXI_FROM_5"
Me.REQ_TAXI_FROM_5.Height = 0.1999998!
Me.REQ_TAXI_FROM_5.Left = 2.007875!
Me.REQ_TAXI_FROM_5.Name = "REQ_TAXI_FROM_5"
Me.REQ_TAXI_FROM_5.Text = Nothing
Me.REQ_TAXI_FROM_5.Top = 8.10275!
Me.REQ_TAXI_FROM_5.Width = 1.32126!
'
'Label58
'
Me.Label58.Height = 0.2!
Me.Label58.HyperLink = Nothing
Me.Label58.Left = 3.329135!
Me.Label58.Name = "Label58"
Me.Label58.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label58.Text = "依頼金額"
Me.Label58.Top = 8.10275!
Me.Label58.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_5
'
Me.TAXI_YOTEIKINGAKU_5.DataField = "TAXI_YOTEIKINGAKU_5"
Me.TAXI_YOTEIKINGAKU_5.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_5.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_5.Name = "TAXI_YOTEIKINGAKU_5"
Me.TAXI_YOTEIKINGAKU_5.Text = Nothing
Me.TAXI_YOTEIKINGAKU_5.Top = 8.10275!
Me.TAXI_YOTEIKINGAKU_5.Width = 1.009056!
'
'Label57
'
Me.Label57.Height = 0.2!
Me.Label57.HyperLink = Nothing
Me.Label57.Left = 4.172325E-07!
Me.Label57.Name = "Label57"
Me.Label57.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label57.Text = "行程4"
Me.Label57.Top = 7.902749!
Me.Label57.Width = 0.448819!
'
'Label56
'
Me.Label56.Height = 0.2!
Me.Label56.HyperLink = Nothing
Me.Label56.Left = 0.4488194!
Me.Label56.Name = "Label56"
Me.Label56.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label56.Text = "利用日"
Me.Label56.Top = 7.902749!
Me.Label56.Width = 0.3948819!
'
'REQ_TAXI_DATE_4
'
Me.REQ_TAXI_DATE_4.DataField = "REQ_TAXI_DATE_4"
Me.REQ_TAXI_DATE_4.Height = 0.1999998!
Me.REQ_TAXI_DATE_4.Left = 0.843701!
Me.REQ_TAXI_DATE_4.Name = "REQ_TAXI_DATE_4"
Me.REQ_TAXI_DATE_4.Text = Nothing
Me.REQ_TAXI_DATE_4.Top = 7.902749!
Me.REQ_TAXI_DATE_4.Width = 0.7692917!
'
'Label54
'
Me.Label54.Height = 0.2!
Me.Label54.HyperLink = Nothing
Me.Label54.Left = 1.612993!
Me.Label54.Name = "Label54"
Me.Label54.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label54.Text = "発地"
Me.Label54.Top = 7.902749!
Me.Label54.Width = 0.3948819!
'
'REQ_TAXI_FROM_4
'
Me.REQ_TAXI_FROM_4.DataField = "REQ_TAXI_FROM_4"
Me.REQ_TAXI_FROM_4.Height = 0.1999998!
Me.REQ_TAXI_FROM_4.Left = 2.007875!
Me.REQ_TAXI_FROM_4.Name = "REQ_TAXI_FROM_4"
Me.REQ_TAXI_FROM_4.Text = Nothing
Me.REQ_TAXI_FROM_4.Top = 7.902749!
Me.REQ_TAXI_FROM_4.Width = 1.32126!
'
'Label53
'
Me.Label53.Height = 0.2!
Me.Label53.HyperLink = Nothing
Me.Label53.Left = 3.329135!
Me.Label53.Name = "Label53"
Me.Label53.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label53.Text = "依頼金額"
Me.Label53.Top = 7.902749!
Me.Label53.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_4
'
Me.TAXI_YOTEIKINGAKU_4.DataField = "TAXI_YOTEIKINGAKU_4"
Me.TAXI_YOTEIKINGAKU_4.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_4.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_4.Name = "TAXI_YOTEIKINGAKU_4"
Me.TAXI_YOTEIKINGAKU_4.Text = Nothing
Me.TAXI_YOTEIKINGAKU_4.Top = 7.902749!
Me.TAXI_YOTEIKINGAKU_4.Width = 1.009056!
'
'Label52
'
Me.Label52.Height = 0.2!
Me.Label52.HyperLink = Nothing
Me.Label52.Left = 4.172325E-07!
Me.Label52.Name = "Label52"
Me.Label52.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label52.Text = "行程3"
Me.Label52.Top = 7.702749!
Me.Label52.Width = 0.448819!
'
'Label51
'
Me.Label51.Height = 0.2!
Me.Label51.HyperLink = Nothing
Me.Label51.Left = 0.4488194!
Me.Label51.Name = "Label51"
Me.Label51.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label51.Text = "利用日"
Me.Label51.Top = 7.702749!
Me.Label51.Width = 0.3948819!
'
'REQ_TAXI_DATE_3
'
Me.REQ_TAXI_DATE_3.DataField = "REQ_TAXI_DATE_3"
Me.REQ_TAXI_DATE_3.Height = 0.1999998!
Me.REQ_TAXI_DATE_3.Left = 0.843701!
Me.REQ_TAXI_DATE_3.Name = "REQ_TAXI_DATE_3"
Me.REQ_TAXI_DATE_3.Text = Nothing
Me.REQ_TAXI_DATE_3.Top = 7.702749!
Me.REQ_TAXI_DATE_3.Width = 0.7692917!
'
'Label50
'
Me.Label50.Height = 0.2!
Me.Label50.HyperLink = Nothing
Me.Label50.Left = 1.612993!
Me.Label50.Name = "Label50"
Me.Label50.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; white-space: nowrap"
Me.Label50.Text = "発地"
Me.Label50.Top = 7.702749!
Me.Label50.Width = 0.3948819!
'
'REQ_TAXI_FROM_3
'
Me.REQ_TAXI_FROM_3.DataField = "REQ_TAXI_FROM_3"
Me.REQ_TAXI_FROM_3.Height = 0.1999998!
Me.REQ_TAXI_FROM_3.Left = 2.007875!
Me.REQ_TAXI_FROM_3.Name = "REQ_TAXI_FROM_3"
Me.REQ_TAXI_FROM_3.Text = Nothing
Me.REQ_TAXI_FROM_3.Top = 7.702749!
Me.REQ_TAXI_FROM_3.Width = 1.32126!
'
'Label49
'
Me.Label49.Height = 0.2!
Me.Label49.HyperLink = Nothing
Me.Label49.Left = 3.329135!
Me.Label49.Name = "Label49"
Me.Label49.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label49.Text = "依頼金額"
Me.Label49.Top = 7.702749!
Me.Label49.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_3
'
Me.TAXI_YOTEIKINGAKU_3.DataField = "TAXI_YOTEIKINGAKU_3"
Me.TAXI_YOTEIKINGAKU_3.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_3.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_3.Name = "TAXI_YOTEIKINGAKU_3"
Me.TAXI_YOTEIKINGAKU_3.Text = Nothing
Me.TAXI_YOTEIKINGAKU_3.Top = 7.702749!
Me.TAXI_YOTEIKINGAKU_3.Width = 1.009056!
'
'Label48
'
Me.Label48.Height = 0.2!
Me.Label48.HyperLink = Nothing
Me.Label48.Left = 2.384186E-07!
Me.Label48.Name = "Label48"
Me.Label48.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label48.Text = "行程2"
Me.Label48.Top = 7.502749!
Me.Label48.Width = 0.448819!
'
'Label47
'
Me.Label47.Height = 0.2!
Me.Label47.HyperLink = Nothing
Me.Label47.Left = 0.4488192!
Me.Label47.Name = "Label47"
Me.Label47.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label47.Text = "利用日"
Me.Label47.Top = 7.502749!
Me.Label47.Width = 0.3948819!
'
'REQ_TAXI_DATE_2
'
Me.REQ_TAXI_DATE_2.DataField = "REQ_TAXI_DATE_2"
Me.REQ_TAXI_DATE_2.Height = 0.1999998!
Me.REQ_TAXI_DATE_2.Left = 0.8437008!
Me.REQ_TAXI_DATE_2.Name = "REQ_TAXI_DATE_2"
Me.REQ_TAXI_DATE_2.Text = Nothing
Me.REQ_TAXI_DATE_2.Top = 7.502749!
Me.REQ_TAXI_DATE_2.Width = 0.7692917!
'
'Label46
'
Me.Label46.Height = 0.2!
Me.Label46.HyperLink = Nothing
Me.Label46.Left = 1.612992!
Me.Label46.Name = "Label46"
Me.Label46.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label46.Text = "発地"
Me.Label46.Top = 7.502749!
Me.Label46.Width = 0.3948819!
'
'REQ_TAXI_FROM_2
'
Me.REQ_TAXI_FROM_2.DataField = "REQ_TAXI_FROM_2"
Me.REQ_TAXI_FROM_2.Height = 0.1999998!
Me.REQ_TAXI_FROM_2.Left = 2.007874!
Me.REQ_TAXI_FROM_2.Name = "REQ_TAXI_FROM_2"
Me.REQ_TAXI_FROM_2.Text = Nothing
Me.REQ_TAXI_FROM_2.Top = 7.502749!
Me.REQ_TAXI_FROM_2.Width = 1.32126!
'
'Label45
'
Me.Label45.Height = 0.2!
Me.Label45.HyperLink = Nothing
Me.Label45.Left = 3.329135!
Me.Label45.Name = "Label45"
Me.Label45.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label45.Text = "依頼金額"
Me.Label45.Top = 7.502749!
Me.Label45.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_2
'
Me.TAXI_YOTEIKINGAKU_2.DataField = "TAXI_YOTEIKINGAKU_2"
Me.TAXI_YOTEIKINGAKU_2.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_2.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_2.Name = "TAXI_YOTEIKINGAKU_2"
Me.TAXI_YOTEIKINGAKU_2.Text = Nothing
Me.TAXI_YOTEIKINGAKU_2.Top = 7.502749!
Me.TAXI_YOTEIKINGAKU_2.Width = 1.009056!
'
'Label44
'
Me.Label44.Height = 0.2!
Me.Label44.HyperLink = Nothing
Me.Label44.Left = 2.384186E-07!
Me.Label44.Name = "Label44"
Me.Label44.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label44.Text = "行程1"
Me.Label44.Top = 7.302749!
Me.Label44.Width = 0.4488189!
'
'Label72
'
Me.Label72.Height = 0.2!
Me.Label72.HyperLink = Nothing
Me.Label72.Left = 0.4488191!
Me.Label72.Name = "Label72"
Me.Label72.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label72.Text = "利用日"
Me.Label72.Top = 7.302749!
Me.Label72.Width = 0.3948819!
'
'REQ_TAXI_DATE_1
'
Me.REQ_TAXI_DATE_1.DataField = "REQ_TAXI_DATE_1"
Me.REQ_TAXI_DATE_1.Height = 0.1999998!
Me.REQ_TAXI_DATE_1.Left = 0.843701!
Me.REQ_TAXI_DATE_1.Name = "REQ_TAXI_DATE_1"
Me.REQ_TAXI_DATE_1.Text = Nothing
Me.REQ_TAXI_DATE_1.Top = 7.302749!
Me.REQ_TAXI_DATE_1.Width = 0.7692915!
'
'Label73
'
Me.Label73.Height = 0.2!
Me.Label73.HyperLink = Nothing
Me.Label73.Left = 1.612992!
Me.Label73.Name = "Label73"
Me.Label73.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label73.Text = "発地"
Me.Label73.Top = 7.302749!
Me.Label73.Width = 0.3948819!
'
'REQ_TAXI_FROM_1
'
Me.REQ_TAXI_FROM_1.DataField = "REQ_TAXI_FROM_1"
Me.REQ_TAXI_FROM_1.Height = 0.1999998!
Me.REQ_TAXI_FROM_1.Left = 2.007874!
Me.REQ_TAXI_FROM_1.Name = "REQ_TAXI_FROM_1"
Me.REQ_TAXI_FROM_1.Text = Nothing
Me.REQ_TAXI_FROM_1.Top = 7.302749!
Me.REQ_TAXI_FROM_1.Width = 1.32126!
'
'Label74
'
Me.Label74.Height = 0.2!
Me.Label74.HyperLink = Nothing
Me.Label74.Left = 3.329134!
Me.Label74.Name = "Label74"
Me.Label74.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: cen"& _ 
    "ter; vertical-align: middle; white-space: nowrap"
Me.Label74.Text = "依頼金額"
Me.Label74.Top = 7.302749!
Me.Label74.Width = 0.5811025!
'
'TAXI_YOTEIKINGAKU_1
'
Me.TAXI_YOTEIKINGAKU_1.DataField = "TAXI_YOTEIKINGAKU_1"
Me.TAXI_YOTEIKINGAKU_1.Height = 0.2!
Me.TAXI_YOTEIKINGAKU_1.Left = 3.910237!
Me.TAXI_YOTEIKINGAKU_1.Name = "TAXI_YOTEIKINGAKU_1"
Me.TAXI_YOTEIKINGAKU_1.Text = Nothing
Me.TAXI_YOTEIKINGAKU_1.Top = 7.302749!
Me.TAXI_YOTEIKINGAKU_1.Width = 1.009056!
'
'Label75
'
Me.Label75.Height = 0.1999998!
Me.Label75.HyperLink = Nothing
Me.Label75.Left = 4.919291!
Me.Label75.Name = "Label75"
Me.Label75.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; white-space: no"& _ 
    "wrap"
Me.Label75.Text = "タクチケ備考"
Me.Label75.Top = 7.102749!
Me.Label75.Width = 2.232677!
'
'Label71
'
Me.Label71.Height = 0.2!
Me.Label71.HyperLink = Nothing
Me.Label71.Left = 2.384186E-07!
Me.Label71.Name = "Label71"
Me.Label71.Style = "background-color: darkgray; white-space: nowrap"
Me.Label71.Text = "タクシーチケット手配"
Me.Label71.Top = 7.102749!
Me.Label71.Width = 1.677953!
'
'TEHAI_TAXI
'
Me.TEHAI_TAXI.DataField = "TEHAI_TAXI"
Me.TEHAI_TAXI.Height = 0.1999998!
Me.TEHAI_TAXI.Left = 1.677953!
Me.TEHAI_TAXI.Name = "TEHAI_TAXI"
Me.TEHAI_TAXI.Text = Nothing
Me.TEHAI_TAXI.Top = 7.102749!
Me.TEHAI_TAXI.Width = 3.241339!
'
'ANS_HOTEL_NAME
'
Me.ANS_HOTEL_NAME.DataField = "ANS_HOTEL_NAME"
Me.ANS_HOTEL_NAME.Height = 0.2!
Me.ANS_HOTEL_NAME.Left = 4.507481!
Me.ANS_HOTEL_NAME.Name = "ANS_HOTEL_NAME"
Me.ANS_HOTEL_NAME.Style = "vertical-align: middle"
Me.ANS_HOTEL_NAME.Text = Nothing
Me.ANS_HOTEL_NAME.Top = 5.43622!
Me.ANS_HOTEL_NAME.Width = 2.644488!
'
'ANS_ROOM_TYPE
'
Me.ANS_ROOM_TYPE.DataField = "ANS_ROOM_TYPE"
Me.ANS_ROOM_TYPE.Height = 0.2!
Me.ANS_ROOM_TYPE.Left = 4.507481!
Me.ANS_ROOM_TYPE.Name = "ANS_ROOM_TYPE"
Me.ANS_ROOM_TYPE.Style = "vertical-align: middle"
Me.ANS_ROOM_TYPE.Text = Nothing
Me.ANS_ROOM_TYPE.Top = 5.636222!
Me.ANS_ROOM_TYPE.Width = 2.644488!
'
'ANS_HOTELHI
'
Me.ANS_HOTELHI.DataField = "ANS_HOTELHI"
Me.ANS_HOTELHI.Height = 0.2!
Me.ANS_HOTELHI.Left = 4.507481!
Me.ANS_HOTELHI.Name = "ANS_HOTELHI"
Me.ANS_HOTELHI.Style = "vertical-align: middle"
Me.ANS_HOTELHI.Text = Nothing
Me.ANS_HOTELHI.Top = 5.836221!
Me.ANS_HOTELHI.Width = 2.644488!
'
'ANS_HOTELHI_TOZEI
'
Me.ANS_HOTELHI_TOZEI.DataField = "ANS_HOTELHI_TOZEI"
Me.ANS_HOTELHI_TOZEI.Height = 0.2!
Me.ANS_HOTELHI_TOZEI.Left = 4.507481!
Me.ANS_HOTELHI_TOZEI.Name = "ANS_HOTELHI_TOZEI"
Me.ANS_HOTELHI_TOZEI.Style = "vertical-align: middle"
Me.ANS_HOTELHI_TOZEI.Text = Nothing
Me.ANS_HOTELHI_TOZEI.Top = 6.036222!
Me.ANS_HOTELHI_TOZEI.Width = 2.644488!
'
'ANS_HOTELHI_CANCEL
'
Me.ANS_HOTELHI_CANCEL.DataField = "ANS_HOTELHI_CANCEL"
Me.ANS_HOTELHI_CANCEL.Height = 0.2!
Me.ANS_HOTELHI_CANCEL.Left = 4.507481!
Me.ANS_HOTELHI_CANCEL.Name = "ANS_HOTELHI_CANCEL"
Me.ANS_HOTELHI_CANCEL.Style = "vertical-align: middle"
Me.ANS_HOTELHI_CANCEL.Text = Nothing
Me.ANS_HOTELHI_CANCEL.Top = 6.236221!
Me.ANS_HOTELHI_CANCEL.Width = 2.644488!
'
'Label70
'
Me.Label70.Height = 0.2000001!
Me.Label70.HyperLink = Nothing
Me.Label70.Left = 3.558662!
Me.Label70.Name = "Label70"
Me.Label70.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label70.Text = "宿泊取消料"
Me.Label70.Top = 6.236221!
Me.Label70.Width = 0.9488187!
'
'Label69
'
Me.Label69.Height = 0.2000001!
Me.Label69.HyperLink = Nothing
Me.Label69.Left = 3.558662!
Me.Label69.Name = "Label69"
Me.Label69.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label69.Text = "都税"
Me.Label69.Top = 6.036222!
Me.Label69.Width = 0.9488187!
'
'Label35
'
Me.Label35.Height = 0.2000001!
Me.Label35.HyperLink = Nothing
Me.Label35.Left = 3.558662!
Me.Label35.Name = "Label35"
Me.Label35.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label35.Text = "宿泊費(税込)"
Me.Label35.Top = 5.836221!
Me.Label35.Width = 0.9488187!
'
'Label34
'
Me.Label34.Height = 0.2000001!
Me.Label34.HyperLink = Nothing
Me.Label34.Left = 3.558662!
Me.Label34.Name = "Label34"
Me.Label34.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label34.Text = "部屋タイプ"
Me.Label34.Top = 5.636222!
Me.Label34.Width = 0.9488187!
'
'Label32
'
Me.Label32.Height = 0.2000001!
Me.Label32.HyperLink = Nothing
Me.Label32.Left = 3.558662!
Me.Label32.Name = "Label32"
Me.Label32.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label32.Text = "宿泊ホテル"
Me.Label32.Top = 5.43622!
Me.Label32.Width = 0.9488187!
'
'REQ_MR_HOTEL_NOTE
'
Me.REQ_MR_HOTEL_NOTE.DataField = "REQ_MR_HOTEL_NOTE"
Me.REQ_MR_HOTEL_NOTE.Height = 0.6767716!
Me.REQ_MR_HOTEL_NOTE.Left = 1.687402!
Me.REQ_MR_HOTEL_NOTE.Name = "REQ_MR_HOTEL_NOTE"
Me.REQ_MR_HOTEL_NOTE.Style = "font-size: 9pt"
Me.REQ_MR_HOTEL_NOTE.Top = 4.101182!
Me.REQ_MR_HOTEL_NOTE.Width = 5.474016!
'
'Label68
'
Me.Label68.Height = 0.6767728!
Me.Label68.HyperLink = Nothing
Me.Label68.Left = 0!
Me.Label68.Name = "Label68"
Me.Label68.Style = "background-color: LightGrey; white-space: nowrap"
Me.Label68.Text = "社員用交通・宿泊備考"
Me.Label68.Top = 4.101181!
Me.Label68.Width = 1.677953!
'
'Label67
'
Me.Label67.Height = 0.2!
Me.Label67.HyperLink = Nothing
Me.Label67.Left = 3.11063!
Me.Label67.Name = "Label67"
Me.Label67.Style = "background-color: LightGrey; vertical-align: middle; white-space: nowrap"
Me.Label67.Text = "担当MR隣席希望(復路)"
Me.Label67.Top = 3.90118!
Me.Label67.Width = 1.615355!
'
'Label55
'
Me.Label55.Height = 0.2!
Me.Label55.HyperLink = Nothing
Me.Label55.Left = 0!
Me.Label55.Name = "Label55"
Me.Label55.Style = "background-color: LightGrey; vertical-align: middle; white-space: nowrap"
Me.Label55.Text = "担当MR隣席希望(往路)"
Me.Label55.Top = 3.90118!
Me.Label55.Width = 1.677953!
'
'REQ_MR_O_TEHAI
'
Me.REQ_MR_O_TEHAI.DataField = "REQ_MR_O_TEHAI"
Me.REQ_MR_O_TEHAI.Height = 0.2!
Me.REQ_MR_O_TEHAI.Left = 1.677953!
Me.REQ_MR_O_TEHAI.Name = "REQ_MR_O_TEHAI"
Me.REQ_MR_O_TEHAI.Style = "vertical-align: middle"
Me.REQ_MR_O_TEHAI.Text = Nothing
Me.REQ_MR_O_TEHAI.Top = 3.90118!
Me.REQ_MR_O_TEHAI.Width = 1.432677!
'
'REQ_MR_F_TEHAI
'
Me.REQ_MR_F_TEHAI.DataField = "REQ_MR_F_TEHAI"
Me.REQ_MR_F_TEHAI.Height = 0.1999998!
Me.REQ_MR_F_TEHAI.Left = 4.725985!
Me.REQ_MR_F_TEHAI.Name = "REQ_MR_F_TEHAI"
Me.REQ_MR_F_TEHAI.Style = "vertical-align: middle"
Me.REQ_MR_F_TEHAI.Text = Nothing
Me.REQ_MR_F_TEHAI.Top = 3.90118!
Me.REQ_MR_F_TEHAI.Width = 2.425984!
'
'MR_SEX
'
Me.MR_SEX.DataField = "MR_SEX"
Me.MR_SEX.Height = 0.2!
Me.MR_SEX.Left = 4.725985!
Me.MR_SEX.Name = "MR_SEX"
Me.MR_SEX.Style = "vertical-align: middle"
Me.MR_SEX.Text = Nothing
Me.MR_SEX.Top = 3.301181!
Me.MR_SEX.Width = 2.425984!
'
'MR_AGE
'
Me.MR_AGE.DataField = "MR_AGE"
Me.MR_AGE.Height = 0.2!
Me.MR_AGE.Left = 1.677953!
Me.MR_AGE.Name = "MR_AGE"
Me.MR_AGE.Style = "vertical-align: middle"
Me.MR_AGE.Text = Nothing
Me.MR_AGE.Top = 3.301183!
Me.MR_AGE.Width = 1.432677!
'
'MR_KANA
'
Me.MR_KANA.DataField = "MR_KANA"
Me.MR_KANA.Height = 0.2!
Me.MR_KANA.Left = 1.323622!
Me.MR_KANA.Name = "MR_KANA"
Me.MR_KANA.Style = "vertical-align: middle"
Me.MR_KANA.Text = Nothing
Me.MR_KANA.Top = 3.101181!
Me.MR_KANA.Width = 1.787008!
'
'Label13
'
Me.Label13.Height = 0.2!
Me.Label13.HyperLink = Nothing
Me.Label13.Left = 3.11063!
Me.Label13.Name = "Label13"
Me.Label13.Style = "background-color: LightGrey; vertical-align: middle; white-space: nowrap"
Me.Label13.Text = "MR性別 (航空券の場合)"
Me.Label13.Top = 3.301181!
Me.Label13.Width = 1.615355!
'
'Label25
'
Me.Label25.Height = 0.2!
Me.Label25.HyperLink = Nothing
Me.Label25.Left = 0!
Me.Label25.Name = "Label25"
Me.Label25.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label25.Text = "担当MR名(カナ)"
Me.Label25.Top = 3.101182!
Me.Label25.Width = 1.323622!
'
'Label20
'
Me.Label20.Height = 0.2!
Me.Label20.HyperLink = Nothing
Me.Label20.Left = 0!
Me.Label20.Name = "Label20"
Me.Label20.Style = "background-color: LightGrey; vertical-align: middle; white-space: nowrap"
Me.Label20.Text = "MR年齢 (航空券の場合)"
Me.Label20.Top = 3.301172!
Me.Label20.Width = 1.677953!
'
'Label19
'
Me.Label19.Height = 0.4271642!
Me.Label19.HyperLink = Nothing
Me.Label19.Left = 5.684342E-14!
Me.Label19.Name = "Label19"
Me.Label19.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; white-space: no"& _ 
    "wrap"
Me.Label19.Text = "指定外申請理由"
Me.Label19.Top = 2.274017!
Me.Label19.Width = 1.323622!
'
'Label21
'
Me.Label21.Height = 0.2!
Me.Label21.HyperLink = Nothing
Me.Label21.Left = 3.11063!
Me.Label21.Name = "Label21"
Me.Label21.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label21.Text = "所属エリア(担当MR)"
Me.Label21.Top = 2.901181!
Me.Label21.Width = 1.167323!
'
'Label22
'
Me.Label22.Height = 0.2!
Me.Label22.HyperLink = Nothing
Me.Label22.Left = 3.115748!
Me.Label22.Name = "Label22"
Me.Label22.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label22.Text = "所属営業所(担当MR)"
Me.Label22.Top = 3.101181!
Me.Label22.Width = 1.162205!
'
'Label23
'
Me.Label23.Height = 0.2!
Me.Label23.HyperLink = Nothing
Me.Label23.Left = 0!
Me.Label23.Name = "Label23"
Me.Label23.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label23.Text = "担当MR名"
Me.Label23.Top = 2.701183!
Me.Label23.Width = 1.323622!
'
'Label24
'
Me.Label24.Height = 0.2!
Me.Label24.HyperLink = Nothing
Me.Label24.Left = 5.684342E-14!
Me.Label24.Name = "Label24"
Me.Label24.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label24.Text = "担当MR名(ローマ字)"
Me.Label24.Top = 2.901183!
Me.Label24.Width = 1.323622!
'
'Label26
'
Me.Label26.Height = 0.2!
Me.Label26.HyperLink = Nothing
Me.Label26.Left = 3.11063!
Me.Label26.Name = "Label26"
Me.Label26.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label26.Text = "Emailアドレス(担当MR)"
Me.Label26.Top = 3.701181!
Me.Label26.Width = 1.615354!
'
'Label27
'
Me.Label27.Height = 0.2!
Me.Label27.HyperLink = Nothing
Me.Label27.Left = 3.11063!
Me.Label27.Name = "Label27"
Me.Label27.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label27.Text = "携帯Emailアドレス(担当MR)"
Me.Label27.Top = 3.50118!
Me.Label27.Width = 1.615354!
'
'Label28
'
Me.Label28.Height = 0.2!
Me.Label28.HyperLink = Nothing
Me.Label28.Left = 0!
Me.Label28.Name = "Label28"
Me.Label28.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label28.Text = "携帯電話番号(担当MR)"
Me.Label28.Top = 3.50118!
Me.Label28.Width = 1.677953!
'
'Label29
'
Me.Label29.Height = 0.2!
Me.Label29.HyperLink = Nothing
Me.Label29.Left = 0!
Me.Label29.Name = "Label29"
Me.Label29.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ju"& _ 
    "stify; text-justify: distribute; vertical-align: middle; white-space: nowrap"
Me.Label29.Text = "オフィスの電話番号(担当MR)"
Me.Label29.Top = 3.701181!
Me.Label29.Width = 1.677953!
'
'Label30
'
Me.Label30.Height = 0.2!
Me.Label30.HyperLink = Nothing
Me.Label30.Left = 0!
Me.Label30.Name = "Label30"
Me.Label30.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label30.Text = "チケット送付先FS"
Me.Label30.Top = 4.777953!
Me.Label30.Width = 1.677953!
'
'Label31
'
Me.Label31.Height = 0.4582677!
Me.Label31.HyperLink = Nothing
Me.Label31.Left = 0!
Me.Label31.Name = "Label31"
Me.Label31.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; white-space: n"& _ 
    "owrap"
Me.Label31.Text = "チケット送付先(その他)"
Me.Label31.Top = 4.977953!
Me.Label31.Width = 1.677953!
'
'Label33
'
Me.Label33.Height = 0.2!
Me.Label33.HyperLink = Nothing
Me.Label33.Left = 4.919291!
Me.Label33.Name = "Label33"
Me.Label33.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label33.Text = "Cost Center"
Me.Label33.Top = 2.701181!
Me.Label33.Width = 1.167323!
'
'Label36
'
Me.Label36.Height = 0.2!
Me.Label36.HyperLink = Nothing
Me.Label36.Left = 0!
Me.Label36.Name = "Label36"
Me.Label36.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label36.Text = "最終承認者(氏名)"
Me.Label36.Top = 2.074017!
Me.Label36.Width = 1.323622!
'
'Label37
'
Me.Label37.Height = 0.2!
Me.Label37.HyperLink = Nothing
Me.Label37.Left = 3.558662!
Me.Label37.Name = "Label37"
Me.Label37.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label37.Text = "最終承認日"
Me.Label37.Top = 2.074017!
Me.Label37.Width = 0.9488189!
'
'Label38
'
Me.Label38.Height = 0.2!
Me.Label38.HyperLink = Nothing
Me.Label38.Left = 1.192093E-07!
Me.Label38.Name = "Label38"
Me.Label38.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label38.Text = "宿泊手配"
Me.Label38.Top = 5.43622!
Me.Label38.Width = 1.677953!
'
'Label39
'
Me.Label39.Height = 0.2!
Me.Label39.HyperLink = Nothing
Me.Label39.Left = 1.192093E-07!
Me.Label39.Name = "Label39"
Me.Label39.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label39.Text = "宿泊依頼内容"
Me.Label39.Top = 5.636222!
Me.Label39.Width = 1.677953!
'
'Label40
'
Me.Label40.Height = 0.2!
Me.Label40.HyperLink = Nothing
Me.Label40.Left = 1.192093E-07!
Me.Label40.Name = "Label40"
Me.Label40.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label40.Text = "宿泊日"
Me.Label40.Top = 5.836221!
Me.Label40.Width = 1.677953!
'
'Label41
'
Me.Label41.Height = 0.2!
Me.Label41.HyperLink = Nothing
Me.Label41.Left = 1.192093E-07!
Me.Label41.Name = "Label41"
Me.Label41.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label41.Text = "泊数"
Me.Label41.Top = 6.036223!
Me.Label41.Width = 1.677953!
'
'Label42
'
Me.Label42.Height = 0.2!
Me.Label42.HyperLink = Nothing
Me.Label42.Left = 1.192093E-07!
Me.Label42.Name = "Label42"
Me.Label42.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label42.Text = "宿泊ホテル喫煙"
Me.Label42.Top = 6.236221!
Me.Label42.Width = 1.677953!
'
'Label43
'
Me.Label43.Height = 0.6665322!
Me.Label43.HyperLink = Nothing
Me.Label43.Left = 1.192093E-07!
Me.Label43.Name = "Label43"
Me.Label43.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; white-space: no"& _ 
    "wrap"
Me.Label43.Text = "宿泊備考"
Me.Label43.Top = 6.436224!
Me.Label43.Width = 1.677953!
'
'SHITEIGAI_RIYU
'
Me.SHITEIGAI_RIYU.DataField = "SHITEIGAI_RIYU"
Me.SHITEIGAI_RIYU.Height = 0.427164!
Me.SHITEIGAI_RIYU.Left = 1.323622!
Me.SHITEIGAI_RIYU.Name = "SHITEIGAI_RIYU"
Me.SHITEIGAI_RIYU.Style = "font-size: 9pt"
Me.SHITEIGAI_RIYU.Top = 2.274017!
Me.SHITEIGAI_RIYU.Width = 5.828347!
'
'MR_AREA
'
Me.MR_AREA.DataField = "MR_AREA"
Me.MR_AREA.Height = 0.2!
Me.MR_AREA.Left = 4.277953!
Me.MR_AREA.Name = "MR_AREA"
Me.MR_AREA.Style = "vertical-align: middle"
Me.MR_AREA.Top = 2.901181!
Me.MR_AREA.Width = 2.883465!
'
'MR_EIGYOSHO
'
Me.MR_EIGYOSHO.DataField = "MR_EIGYOSHO"
Me.MR_EIGYOSHO.Height = 0.1999998!
Me.MR_EIGYOSHO.Left = 4.290158!
Me.MR_EIGYOSHO.Name = "MR_EIGYOSHO"
Me.MR_EIGYOSHO.Style = "vertical-align: middle"
Me.MR_EIGYOSHO.Text = Nothing
Me.MR_EIGYOSHO.Top = 3.101181!
Me.MR_EIGYOSHO.Width = 2.861811!
'
'MR_NAME
'
Me.MR_NAME.DataField = "MR_NAME"
Me.MR_NAME.Height = 0.2!
Me.MR_NAME.Left = 1.323622!
Me.MR_NAME.Name = "MR_NAME"
Me.MR_NAME.Style = "vertical-align: middle"
Me.MR_NAME.Top = 2.701182!
Me.MR_NAME.Width = 1.787008!
'
'MR_ROMA
'
Me.MR_ROMA.DataField = "MR_ROMA"
Me.MR_ROMA.Height = 0.1999998!
Me.MR_ROMA.Left = 1.323622!
Me.MR_ROMA.Name = "MR_ROMA"
Me.MR_ROMA.Style = "vertical-align: middle"
Me.MR_ROMA.Top = 2.901181!
Me.MR_ROMA.Width = 1.787008!
'
'MR_EMAIL_PC
'
Me.MR_EMAIL_PC.DataField = "MR_EMAIL_PC"
Me.MR_EMAIL_PC.Height = 0.1999998!
Me.MR_EMAIL_PC.Left = 4.725985!
Me.MR_EMAIL_PC.Name = "MR_EMAIL_PC"
Me.MR_EMAIL_PC.Style = "vertical-align: middle"
Me.MR_EMAIL_PC.Text = Nothing
Me.MR_EMAIL_PC.Top = 3.701181!
Me.MR_EMAIL_PC.Width = 2.439372!
'
'MR_EMAIL_KEITAI
'
Me.MR_EMAIL_KEITAI.DataField = "MR_EMAIL_KEITAI"
Me.MR_EMAIL_KEITAI.Height = 0.1999998!
Me.MR_EMAIL_KEITAI.Left = 4.725985!
Me.MR_EMAIL_KEITAI.Name = "MR_EMAIL_KEITAI"
Me.MR_EMAIL_KEITAI.Style = "vertical-align: middle"
Me.MR_EMAIL_KEITAI.Text = Nothing
Me.MR_EMAIL_KEITAI.Top = 3.50118!
Me.MR_EMAIL_KEITAI.Width = 2.439372!
'
'MR_KEITAI
'
Me.MR_KEITAI.DataField = "MR_KEITAI"
Me.MR_KEITAI.Height = 0.2!
Me.MR_KEITAI.Left = 1.677953!
Me.MR_KEITAI.Name = "MR_KEITAI"
Me.MR_KEITAI.Style = "vertical-align: middle"
Me.MR_KEITAI.Text = Nothing
Me.MR_KEITAI.Top = 3.50118!
Me.MR_KEITAI.Width = 1.432677!
'
'MR_TEL
'
Me.MR_TEL.DataField = "MR_TEL"
Me.MR_TEL.Height = 0.1999998!
Me.MR_TEL.Left = 1.677953!
Me.MR_TEL.Name = "MR_TEL"
Me.MR_TEL.Style = "vertical-align: middle"
Me.MR_TEL.Text = Nothing
Me.MR_TEL.Top = 3.701181!
Me.MR_TEL.Width = 1.432677!
'
'MR_SEND_SAKI_FS
'
Me.MR_SEND_SAKI_FS.DataField = "MR_SEND_SAKI_FS"
Me.MR_SEND_SAKI_FS.Height = 0.1999998!
Me.MR_SEND_SAKI_FS.Left = 1.677953!
Me.MR_SEND_SAKI_FS.Name = "MR_SEND_SAKI_FS"
Me.MR_SEND_SAKI_FS.Style = "vertical-align: middle"
Me.MR_SEND_SAKI_FS.Text = Nothing
Me.MR_SEND_SAKI_FS.Top = 4.777953!
Me.MR_SEND_SAKI_FS.Width = 5.487403!
'
'MR_SEND_SAKI_OTHER
'
Me.MR_SEND_SAKI_OTHER.DataField = "MR_SEND_SAKI_OTHER"
Me.MR_SEND_SAKI_OTHER.Height = 0.4582676!
Me.MR_SEND_SAKI_OTHER.Left = 1.677953!
Me.MR_SEND_SAKI_OTHER.Name = "MR_SEND_SAKI_OTHER"
Me.MR_SEND_SAKI_OTHER.Style = "font-size: 9pt"
Me.MR_SEND_SAKI_OTHER.Text = Nothing
Me.MR_SEND_SAKI_OTHER.Top = 4.977953!
Me.MR_SEND_SAKI_OTHER.Width = 5.474016!
'
'COST_CENTER
'
Me.COST_CENTER.DataField = "COST_CENTER"
Me.COST_CENTER.Height = 0.1999998!
Me.COST_CENTER.Left = 6.081497!
Me.COST_CENTER.Name = "COST_CENTER"
Me.COST_CENTER.Style = "vertical-align: middle"
Me.COST_CENTER.Text = Nothing
Me.COST_CENTER.Top = 2.701181!
Me.COST_CENTER.Width = 1.070472!
'
'SHONIN_NAME
'
Me.SHONIN_NAME.DataField = "SHONIN_NAME"
Me.SHONIN_NAME.Height = 0.2!
Me.SHONIN_NAME.Left = 1.323622!
Me.SHONIN_NAME.Name = "SHONIN_NAME"
Me.SHONIN_NAME.Style = "vertical-align: middle"
Me.SHONIN_NAME.Text = Nothing
Me.SHONIN_NAME.Top = 2.074017!
Me.SHONIN_NAME.Width = 2.235039!
'
'SHONIN_DATE
'
Me.SHONIN_DATE.DataField = "SHONIN_DATE"
Me.SHONIN_DATE.Height = 0.1999998!
Me.SHONIN_DATE.Left = 4.507481!
Me.SHONIN_DATE.Name = "SHONIN_DATE"
Me.SHONIN_DATE.Style = "vertical-align: middle"
Me.SHONIN_DATE.Text = Nothing
Me.SHONIN_DATE.Top = 2.074017!
Me.SHONIN_DATE.Width = 2.644488!
'
'TEHAI_HOTEL
'
Me.TEHAI_HOTEL.DataField = "TEHAI_HOTEL"
Me.TEHAI_HOTEL.Height = 0.1999998!
Me.TEHAI_HOTEL.Left = 1.677953!
Me.TEHAI_HOTEL.Name = "TEHAI_HOTEL"
Me.TEHAI_HOTEL.Style = "vertical-align: middle"
Me.TEHAI_HOTEL.Text = Nothing
Me.TEHAI_HOTEL.Top = 5.43622!
Me.TEHAI_HOTEL.Width = 1.880708!
'
'HOTEL_IRAINAIYOU
'
Me.HOTEL_IRAINAIYOU.DataField = "HOTEL_IRAINAIYOU"
Me.HOTEL_IRAINAIYOU.Height = 0.1999998!
Me.HOTEL_IRAINAIYOU.Left = 1.677953!
Me.HOTEL_IRAINAIYOU.Name = "HOTEL_IRAINAIYOU"
Me.HOTEL_IRAINAIYOU.Style = "vertical-align: middle"
Me.HOTEL_IRAINAIYOU.Text = Nothing
Me.HOTEL_IRAINAIYOU.Top = 5.636222!
Me.HOTEL_IRAINAIYOU.Width = 1.880708!
'
'REQ_HOTEL_DATE
'
Me.REQ_HOTEL_DATE.DataField = "REQ_HOTEL_DATE"
Me.REQ_HOTEL_DATE.Height = 0.1999998!
Me.REQ_HOTEL_DATE.Left = 1.677953!
Me.REQ_HOTEL_DATE.Name = "REQ_HOTEL_DATE"
Me.REQ_HOTEL_DATE.Style = "vertical-align: middle"
Me.REQ_HOTEL_DATE.Text = Nothing
Me.REQ_HOTEL_DATE.Top = 5.836221!
Me.REQ_HOTEL_DATE.Width = 1.880708!
'
'REQ_HAKUSU
'
Me.REQ_HAKUSU.DataField = "REQ_HAKUSU"
Me.REQ_HAKUSU.Height = 0.1999998!
Me.REQ_HAKUSU.Left = 1.677953!
Me.REQ_HAKUSU.Name = "REQ_HAKUSU"
Me.REQ_HAKUSU.Style = "vertical-align: middle"
Me.REQ_HAKUSU.Text = Nothing
Me.REQ_HAKUSU.Top = 6.036222!
Me.REQ_HAKUSU.Width = 1.880708!
'
'REQ_HOTEL_SMOKING
'
Me.REQ_HOTEL_SMOKING.DataField = "REQ_HOTEL_SMOKING"
Me.REQ_HOTEL_SMOKING.Height = 0.1999998!
Me.REQ_HOTEL_SMOKING.Left = 1.677953!
Me.REQ_HOTEL_SMOKING.Name = "REQ_HOTEL_SMOKING"
Me.REQ_HOTEL_SMOKING.Style = "vertical-align: middle"
Me.REQ_HOTEL_SMOKING.Text = Nothing
Me.REQ_HOTEL_SMOKING.Top = 6.236221!
Me.REQ_HOTEL_SMOKING.Width = 1.880708!
'
'REQ_HOTEL_NOTE
'
Me.REQ_HOTEL_NOTE.DataField = "REQ_HOTEL_NOTE"
Me.REQ_HOTEL_NOTE.Height = 0.6665392!
Me.REQ_HOTEL_NOTE.Left = 1.677953!
Me.REQ_HOTEL_NOTE.Name = "REQ_HOTEL_NOTE"
Me.REQ_HOTEL_NOTE.Style = "font-size: 9pt"
Me.REQ_HOTEL_NOTE.Top = 6.43622!
Me.REQ_HOTEL_NOTE.Width = 5.474017!
'
'Line1
'
Me.Line1.Height = 0!
Me.Line1.Left = 5.684342E-14!
Me.Line1.LineWeight = 1!
Me.Line1.Name = "Line1"
Me.Line1.Top = 2.701183!
Me.Line1.Width = 7.165356!
Me.Line1.X1 = 5.684342E-14!
Me.Line1.X2 = 7.165356!
Me.Line1.Y1 = 2.701183!
Me.Line1.Y2 = 2.701183!
'
'Line9
'
Me.Line9.Height = 0!
Me.Line9.Left = 4.768372E-07!
Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line9.LineWeight = 1!
Me.Line9.Name = "Line9"
Me.Line9.Top = 2.274016!
Me.Line9.Width = 7.165353!
Me.Line9.X1 = 4.768372E-07!
Me.Line9.X2 = 7.165354!
Me.Line9.Y1 = 2.274016!
Me.Line9.Y2 = 2.274016!
'
'Line10
'
Me.Line10.Height = 0!
Me.Line10.Left = 4.768372E-07!
Me.Line10.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line10.LineWeight = 1!
Me.Line10.Name = "Line10"
Me.Line10.Top = 2.901182!
Me.Line10.Width = 7.165353!
Me.Line10.X1 = 4.768372E-07!
Me.Line10.X2 = 7.165354!
Me.Line10.Y1 = 2.901182!
Me.Line10.Y2 = 2.901182!
'
'Line11
'
Me.Line11.Height = 0!
Me.Line11.Left = 4.768372E-07!
Me.Line11.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line11.LineWeight = 1!
Me.Line11.Name = "Line11"
Me.Line11.Top = 3.101182!
Me.Line11.Width = 7.165353!
Me.Line11.X1 = 4.768372E-07!
Me.Line11.X2 = 7.165354!
Me.Line11.Y1 = 3.101182!
Me.Line11.Y2 = 3.101182!
'
'Line12
'
Me.Line12.Height = 0!
Me.Line12.Left = 4.768372E-07!
Me.Line12.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line12.LineWeight = 1!
Me.Line12.Name = "Line12"
Me.Line12.Top = 3.301181!
Me.Line12.Width = 7.165353!
Me.Line12.X1 = 4.768372E-07!
Me.Line12.X2 = 7.165354!
Me.Line12.Y1 = 3.301181!
Me.Line12.Y2 = 3.301181!
'
'Line13
'
Me.Line13.Height = 0!
Me.Line13.Left = 4.768372E-07!
Me.Line13.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line13.LineWeight = 1!
Me.Line13.Name = "Line13"
Me.Line13.Top = 3.501181!
Me.Line13.Width = 7.165353!
Me.Line13.X1 = 4.768372E-07!
Me.Line13.X2 = 7.165354!
Me.Line13.Y1 = 3.501181!
Me.Line13.Y2 = 3.501181!
'
'Line14
'
Me.Line14.Height = 0!
Me.Line14.Left = 4.768372E-07!
Me.Line14.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line14.LineWeight = 1!
Me.Line14.Name = "Line14"
Me.Line14.Top = 3.501179!
Me.Line14.Width = 7.165353!
Me.Line14.X1 = 4.768372E-07!
Me.Line14.X2 = 7.165354!
Me.Line14.Y1 = 3.501179!
Me.Line14.Y2 = 3.501179!
'
'Line15
'
Me.Line15.Height = 0!
Me.Line15.Left = 4.768372E-07!
Me.Line15.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line15.LineWeight = 1!
Me.Line15.Name = "Line15"
Me.Line15.Top = 3.70118!
Me.Line15.Width = 7.165353!
Me.Line15.X1 = 4.768372E-07!
Me.Line15.X2 = 7.165354!
Me.Line15.Y1 = 3.70118!
Me.Line15.Y2 = 3.70118!
'
'Line16
'
Me.Line16.Height = 0!
Me.Line16.Left = 4.768372E-07!
Me.Line16.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line16.LineWeight = 1!
Me.Line16.Name = "Line16"
Me.Line16.Top = 3.901179!
Me.Line16.Width = 7.165353!
Me.Line16.X1 = 4.768372E-07!
Me.Line16.X2 = 7.165354!
Me.Line16.Y1 = 3.901179!
Me.Line16.Y2 = 3.901179!
'
'Line17
'
Me.Line17.Height = 0!
Me.Line17.Left = 4.768372E-07!
Me.Line17.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line17.LineWeight = 1!
Me.Line17.Name = "Line17"
Me.Line17.Top = 4.101181!
Me.Line17.Width = 7.165353!
Me.Line17.X1 = 4.768372E-07!
Me.Line17.X2 = 7.165354!
Me.Line17.Y1 = 4.101181!
Me.Line17.Y2 = 4.101181!
'
'Line23
'
Me.Line23.Height = 0!
Me.Line23.Left = 0!
Me.Line23.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line23.LineWeight = 1!
Me.Line23.Name = "Line23"
Me.Line23.Top = 4.977953!
Me.Line23.Width = 7.165353!
Me.Line23.X1 = 0!
Me.Line23.X2 = 7.165353!
Me.Line23.Y1 = 4.977953!
Me.Line23.Y2 = 4.977953!
'
'Line26
'
Me.Line26.Height = 0!
Me.Line26.Left = 1.192093E-07!
Me.Line26.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line26.LineWeight = 1!
Me.Line26.Name = "Line26"
Me.Line26.Top = 6.424803!
Me.Line26.Width = 7.165353!
Me.Line26.X1 = 1.192093E-07!
Me.Line26.X2 = 7.165353!
Me.Line26.Y1 = 6.424803!
Me.Line26.Y2 = 6.424803!
'
'Line28
'
Me.Line28.Height = 0!
Me.Line28.Left = 0!
Me.Line28.LineWeight = 1!
Me.Line28.Name = "Line28"
Me.Line28.Top = 5.436221!
Me.Line28.Width = 7.165353!
Me.Line28.X1 = 0!
Me.Line28.X2 = 7.165353!
Me.Line28.Y1 = 5.436221!
Me.Line28.Y2 = 5.436221!
'
'Line29
'
Me.Line29.Height = 0!
Me.Line29.Left = 0!
Me.Line29.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line29.LineWeight = 1!
Me.Line29.Name = "Line29"
Me.Line29.Top = 5.636221!
Me.Line29.Width = 7.165353!
Me.Line29.X1 = 0!
Me.Line29.X2 = 7.165353!
Me.Line29.Y1 = 5.636221!
Me.Line29.Y2 = 5.636221!
'
'Line30
'
Me.Line30.Height = 0!
Me.Line30.Left = 1.192093E-07!
Me.Line30.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line30.LineWeight = 1!
Me.Line30.Name = "Line30"
Me.Line30.Top = 5.836221!
Me.Line30.Width = 7.165353!
Me.Line30.X1 = 1.192093E-07!
Me.Line30.X2 = 7.165353!
Me.Line30.Y1 = 5.836221!
Me.Line30.Y2 = 5.836221!
'
'Line31
'
Me.Line31.Height = 0!
Me.Line31.Left = 0!
Me.Line31.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line31.LineWeight = 1!
Me.Line31.Name = "Line31"
Me.Line31.Top = 6.036221!
Me.Line31.Width = 7.165353!
Me.Line31.X1 = 0!
Me.Line31.X2 = 7.165353!
Me.Line31.Y1 = 6.036221!
Me.Line31.Y2 = 6.036221!
'
'Line32
'
Me.Line32.Height = 0!
Me.Line32.Left = 1.192093E-07!
Me.Line32.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line32.LineWeight = 1!
Me.Line32.Name = "Line32"
Me.Line32.Top = 6.236221!
Me.Line32.Width = 7.165353!
Me.Line32.X1 = 1.192093E-07!
Me.Line32.X2 = 7.165353!
Me.Line32.Y1 = 6.236221!
Me.Line32.Y2 = 6.236221!
'
'Line33
'
Me.Line33.Height = 0!
Me.Line33.Left = 0!
Me.Line33.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line33.LineWeight = 1!
Me.Line33.Name = "Line33"
Me.Line33.Top = 4.777953!
Me.Line33.Width = 7.165353!
Me.Line33.X1 = 0!
Me.Line33.X2 = 7.165353!
Me.Line33.Y1 = 4.777953!
Me.Line33.Y2 = 4.777953!
'
'Line37
'
Me.Line37.Height = 0!
Me.Line37.Left = 2.384186E-07!
Me.Line37.LineWeight = 1!
Me.Line37.Name = "Line37"
Me.Line37.Top = 7.302749!
Me.Line37.Width = 7.165353!
Me.Line37.X1 = 2.384186E-07!
Me.Line37.X2 = 7.165353!
Me.Line37.Y1 = 7.302749!
Me.Line37.Y2 = 7.302749!
'
'Line38
'
Me.Line38.Height = 0!
Me.Line38.Left = 1.192093E-07!
Me.Line38.LineWeight = 1!
Me.Line38.Name = "Line38"
Me.Line38.Top = 7.102755!
Me.Line38.Width = 7.165353!
Me.Line38.X1 = 1.192093E-07!
Me.Line38.X2 = 7.165353!
Me.Line38.Y1 = 7.102755!
Me.Line38.Y2 = 7.102755!
'
'Line2
'
Me.Line2.Height = 0!
Me.Line2.Left = 0!
Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line2.LineWeight = 1!
Me.Line2.Name = "Line2"
Me.Line2.Top = 3.301172!
Me.Line2.Width = 7.165354!
Me.Line2.X1 = 0!
Me.Line2.X2 = 7.165354!
Me.Line2.Y1 = 3.301172!
Me.Line2.Y2 = 3.301172!
'
'Line55
'
Me.Line55.Height = 0!
Me.Line55.Left = 0!
Me.Line55.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line55.LineWeight = 1!
Me.Line55.Name = "Line55"
Me.Line55.Top = 3.501173!
Me.Line55.Width = 7.165354!
Me.Line55.X1 = 0!
Me.Line55.X2 = 7.165354!
Me.Line55.Y1 = 3.501173!
Me.Line55.Y2 = 3.501173!
'
'Line18
'
Me.Line18.Height = 7.629395E-06!
Me.Line18.Left = 2.384186E-07!
Me.Line18.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line18.LineWeight = 1!
Me.Line18.Name = "Line18"
Me.Line18.Top = 7.502749!
Me.Line18.Width = 4.919291!
Me.Line18.X1 = 2.384186E-07!
Me.Line18.X2 = 4.919291!
Me.Line18.Y1 = 7.502749!
Me.Line18.Y2 = 7.502757!
'
'Line19
'
Me.Line19.Height = 7.152557E-06!
Me.Line19.Left = 2.384186E-07!
Me.Line19.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line19.LineWeight = 1!
Me.Line19.Name = "Line19"
Me.Line19.Top = 7.702749!
Me.Line19.Width = 4.919291!
Me.Line19.X1 = 2.384186E-07!
Me.Line19.X2 = 4.919291!
Me.Line19.Y1 = 7.702749!
Me.Line19.Y2 = 7.702756!
'
'Line20
'
Me.Line20.Height = 7.629395E-06!
Me.Line20.Left = 2.384186E-07!
Me.Line20.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line20.LineWeight = 1!
Me.Line20.Name = "Line20"
Me.Line20.Top = 7.902749!
Me.Line20.Width = 4.919291!
Me.Line20.X1 = 2.384186E-07!
Me.Line20.X2 = 4.919291!
Me.Line20.Y1 = 7.902749!
Me.Line20.Y2 = 7.902757!
'
'Line21
'
Me.Line21.Height = 8.583069E-06!
Me.Line21.Left = 2.384186E-07!
Me.Line21.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line21.LineWeight = 1!
Me.Line21.Name = "Line21"
Me.Line21.Top = 8.102748!
Me.Line21.Width = 4.919291!
Me.Line21.X1 = 2.384186E-07!
Me.Line21.X2 = 4.919291!
Me.Line21.Y1 = 8.102748!
Me.Line21.Y2 = 8.102757!
'
'Line22
'
Me.Line22.Height = 9.536743E-06!
Me.Line22.Left = 2.384186E-07!
Me.Line22.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line22.LineWeight = 1!
Me.Line22.Name = "Line22"
Me.Line22.Top = 8.302747!
Me.Line22.Width = 4.919291!
Me.Line22.X1 = 2.384186E-07!
Me.Line22.X2 = 4.919291!
Me.Line22.Y1 = 8.302747!
Me.Line22.Y2 = 8.302756!
'
'Line24
'
Me.Line24.Height = 3.814697E-06!
Me.Line24.Left = 2.384186E-07!
Me.Line24.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line24.LineWeight = 1!
Me.Line24.Name = "Line24"
Me.Line24.Top = 8.502752!
Me.Line24.Width = 4.919291!
Me.Line24.X1 = 2.384186E-07!
Me.Line24.X2 = 4.919291!
Me.Line24.Y1 = 8.502752!
Me.Line24.Y2 = 8.502756!
'
'Line25
'
Me.Line25.Height = 1.430511E-05!
Me.Line25.Left = 2.384186E-07!
Me.Line25.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line25.LineWeight = 1!
Me.Line25.Name = "Line25"
Me.Line25.Top = 8.702743!
Me.Line25.Width = 4.919291!
Me.Line25.X1 = 2.384186E-07!
Me.Line25.X2 = 4.919291!
Me.Line25.Y1 = 8.702743!
Me.Line25.Y2 = 8.702757!
'
'Line27
'
Me.Line27.Height = 1.430511E-05!
Me.Line27.Left = 2.384186E-07!
Me.Line27.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line27.LineWeight = 1!
Me.Line27.Name = "Line27"
Me.Line27.Top = 8.902742!
Me.Line27.Width = 4.919291!
Me.Line27.X1 = 2.384186E-07!
Me.Line27.X2 = 4.919291!
Me.Line27.Y1 = 8.902742!
Me.Line27.Y2 = 8.902757!
'
'Line34
'
Me.Line34.Height = 1.430511E-05!
Me.Line34.Left = 2.384186E-07!
Me.Line34.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line34.LineWeight = 1!
Me.Line34.Name = "Line34"
Me.Line34.Top = 9.102742!
Me.Line34.Width = 4.919291!
Me.Line34.X1 = 2.384186E-07!
Me.Line34.X2 = 4.919291!
Me.Line34.Y1 = 9.102742!
Me.Line34.Y2 = 9.102757!
'
'Line35
'
Me.Line35.Height = 1.049042E-05!
Me.Line35.Left = 2.384186E-07!
Me.Line35.LineWeight = 1!
Me.Line35.Name = "Line35"
Me.Line35.Top = 9.302746!
Me.Line35.Width = 4.919291!
Me.Line35.X1 = 2.384186E-07!
Me.Line35.X2 = 4.919291!
Me.Line35.Y1 = 9.302746!
Me.Line35.Y2 = 9.302756!
'
'Line39
'
Me.Line39.Height = 0.6000001!
Me.Line39.Left = 1.323622!
Me.Line39.LineWeight = 1!
Me.Line39.Name = "Line39"
Me.Line39.Top = 2.701181!
Me.Line39.Width = 0!
Me.Line39.X1 = 1.323622!
Me.Line39.X2 = 1.323622!
Me.Line39.Y1 = 2.701181!
Me.Line39.Y2 = 3.301181!
'
'Line40
'
Me.Line40.Height = 4.001573!
Me.Line40.Left = 1.677953!
Me.Line40.LineWeight = 1!
Me.Line40.Name = "Line40"
Me.Line40.Top = 3.301181!
Me.Line40.Width = 2.384186E-07!
Me.Line40.X1 = 1.677953!
Me.Line40.X2 = 1.677953!
Me.Line40.Y1 = 3.301181!
Me.Line40.Y2 = 7.302754!
'
'Line41
'
Me.Line41.Height = 2.000006!
Me.Line41.Left = 0.843701!
Me.Line41.LineWeight = 1!
Me.Line41.Name = "Line41"
Me.Line41.Top = 7.302749!
Me.Line41.Width = 0!
Me.Line41.X1 = 0.843701!
Me.Line41.X2 = 0.843701!
Me.Line41.Y1 = 7.302749!
Me.Line41.Y2 = 9.302755!
'
'Line42
'
Me.Line42.Height = 2.000006!
Me.Line42.Left = 0.4488191!
Me.Line42.LineWeight = 1!
Me.Line42.Name = "Line42"
Me.Line42.Top = 7.302749!
Me.Line42.Width = 0!
Me.Line42.X1 = 0.4488191!
Me.Line42.X2 = 0.4488191!
Me.Line42.Y1 = 7.302749!
Me.Line42.Y2 = 9.302755!
'
'Line43
'
Me.Line43.Height = 2.200006!
Me.Line43.Left = 1.612992!
Me.Line43.LineWeight = 1!
Me.Line43.Name = "Line43"
Me.Line43.Top = 7.302749!
Me.Line43.Width = 0!
Me.Line43.X1 = 1.612992!
Me.Line43.X2 = 1.612992!
Me.Line43.Y1 = 7.302749!
Me.Line43.Y2 = 9.502755!
'
'Line44
'
Me.Line44.Height = 2.200006!
Me.Line44.Left = 2.007874!
Me.Line44.LineWeight = 1!
Me.Line44.Name = "Line44"
Me.Line44.Top = 7.302749!
Me.Line44.Width = 0!
Me.Line44.X1 = 2.007874!
Me.Line44.X2 = 2.007874!
Me.Line44.Y1 = 7.302749!
Me.Line44.Y2 = 9.502755!
'
'Line45
'
Me.Line45.Height = 2.200006!
Me.Line45.Left = 3.329134!
Me.Line45.LineWeight = 1!
Me.Line45.Name = "Line45"
Me.Line45.Top = 7.302749!
Me.Line45.Width = 0!
Me.Line45.X1 = 3.329134!
Me.Line45.X2 = 3.329134!
Me.Line45.Y1 = 7.302749!
Me.Line45.Y2 = 9.502755!
'
'Line46
'
Me.Line46.Height = 2.000006!
Me.Line46.Left = 3.910237!
Me.Line46.LineWeight = 1!
Me.Line46.Name = "Line46"
Me.Line46.Top = 7.302749!
Me.Line46.Width = 0!
Me.Line46.X1 = 3.910237!
Me.Line46.X2 = 3.910237!
Me.Line46.Y1 = 7.302749!
Me.Line46.Y2 = 9.302755!
'
'Line47
'
Me.Line47.Height = 2.200006!
Me.Line47.Left = 4.919291!
Me.Line47.LineWeight = 1!
Me.Line47.Name = "Line47"
Me.Line47.Top = 7.102749!
Me.Line47.Width = 0!
Me.Line47.X1 = 4.919291!
Me.Line47.X2 = 4.919291!
Me.Line47.Y1 = 7.102749!
Me.Line47.Y2 = 9.302755!
'
'Line48
'
Me.Line48.Height = 1!
Me.Line48.Left = 3.558662!
Me.Line48.LineWeight = 1!
Me.Line48.Name = "Line48"
Me.Line48.Top = 5.436221!
Me.Line48.Width = 0!
Me.Line48.X1 = 3.558662!
Me.Line48.X2 = 3.558662!
Me.Line48.Y1 = 5.436221!
Me.Line48.Y2 = 6.436221!
'
'Line49
'
Me.Line49.Height = 0.9999971!
Me.Line49.Left = 4.507481!
Me.Line49.LineWeight = 1!
Me.Line49.Name = "Line49"
Me.Line49.Top = 5.436221!
Me.Line49.Width = 0!
Me.Line49.X1 = 4.507481!
Me.Line49.X2 = 4.507481!
Me.Line49.Y1 = 5.436221!
Me.Line49.Y2 = 6.436218!
'
'Line50
'
Me.Line50.Height = 0.6000001!
Me.Line50.Left = 3.11063!
Me.Line50.LineWeight = 1!
Me.Line50.Name = "Line50"
Me.Line50.Top = 3.501181!
Me.Line50.Width = 0!
Me.Line50.X1 = 3.11063!
Me.Line50.X2 = 3.11063!
Me.Line50.Y1 = 3.501181!
Me.Line50.Y2 = 4.101182!
'
'Line53
'
Me.Line53.Height = 0.6000001!
Me.Line53.Left = 4.725985!
Me.Line53.LineWeight = 1!
Me.Line53.Name = "Line53"
Me.Line53.Top = 3.501181!
Me.Line53.Width = 0!
Me.Line53.X1 = 4.725985!
Me.Line53.X2 = 4.725985!
Me.Line53.Y1 = 3.501181!
Me.Line53.Y2 = 4.101182!
'
'Line57
'
Me.Line57.Height = 0.6000001!
Me.Line57.Left = 4.290158!
Me.Line57.LineWeight = 1!
Me.Line57.Name = "Line57"
Me.Line57.Top = 2.701181!
Me.Line57.Width = 0!
Me.Line57.X1 = 4.290158!
Me.Line57.X2 = 4.290158!
Me.Line57.Y1 = 2.701181!
Me.Line57.Y2 = 3.301181!
'
'Line58
'
Me.Line58.Height = 0.1999989!
Me.Line58.Left = 4.919291!
Me.Line58.LineWeight = 1!
Me.Line58.Name = "Line58"
Me.Line58.Top = 2.701182!
Me.Line58.Width = 4.768372E-07!
Me.Line58.X1 = 4.919291!
Me.Line58.X2 = 4.919291!
Me.Line58.Y1 = 2.701182!
Me.Line58.Y2 = 2.901181!
'
'Line59
'
Me.Line59.Height = 0.1999989!
Me.Line59.Left = 6.081497!
Me.Line59.LineWeight = 1!
Me.Line59.Name = "Line59"
Me.Line59.Top = 2.701182!
Me.Line59.Width = 4.768372E-07!
Me.Line59.X1 = 6.081497!
Me.Line59.X2 = 6.081497!
Me.Line59.Y1 = 2.701182!
Me.Line59.Y2 = 2.901181!
'
'Line60
'
Me.Line60.Height = 0.2!
Me.Line60.Left = 3.558662!
Me.Line60.LineWeight = 1!
Me.Line60.Name = "Line60"
Me.Line60.Top = 2.074017!
Me.Line60.Width = 0!
Me.Line60.X1 = 3.558662!
Me.Line60.X2 = 3.558662!
Me.Line60.Y1 = 2.074017!
Me.Line60.Y2 = 2.274017!
'
'Line61
'
Me.Line61.Height = 0.2!
Me.Line61.Left = 4.507481!
Me.Line61.LineWeight = 1!
Me.Line61.Name = "Line61"
Me.Line61.Top = 2.074017!
Me.Line61.Width = 0!
Me.Line61.X1 = 4.507481!
Me.Line61.X2 = 4.507481!
Me.Line61.Y1 = 2.074017!
Me.Line61.Y2 = 2.274017!
'
'Line66
'
Me.Line66.Height = 0!
Me.Line66.Left = 2.384186E-07!
Me.Line66.LineWeight = 1!
Me.Line66.Name = "Line66"
Me.Line66.Top = 9.502746!
Me.Line66.Width = 7.165354!
Me.Line66.X1 = 2.384186E-07!
Me.Line66.X2 = 7.165354!
Me.Line66.Y1 = 9.502746!
Me.Line66.Y2 = 9.502746!
'
'PageBreak1
'
Me.PageBreak1.Height = 0.01!
Me.PageBreak1.Left = 0!
Me.PageBreak1.Name = "PageBreak1"
Me.PageBreak1.Size = New System.Drawing.SizeF(7.165357!, 0.01!)
Me.PageBreak1.Top = 9.590158!
Me.PageBreak1.Width = 7.165357!
'
'Shape2
'
Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
Me.Shape2.Height = 0.2740157!
Me.Shape2.Left = 0!
Me.Shape2.Name = "Shape2"
Me.Shape2.RoundingRadius = 9.999999!
Me.Shape2.Top = 9.622841!
Me.Shape2.Width = 7.151965!
'
'Label94
'
Me.Label94.Height = 0.2!
Me.Label94.HyperLink = Nothing
Me.Label94.Left = 0!
Me.Label94.Name = "Label94"
Me.Label94.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center"
Me.Label94.Text = "交通宿泊タクチケ手配依頼"
Me.Label94.Top = 9.65591!
Me.Label94.Width = 7.151965!
'
'Label95
'
Me.Label95.Height = 0.2!
Me.Label95.HyperLink = Nothing
Me.Label95.Left = 6.38504!
Me.Label95.Name = "Label95"
Me.Label95.Style = "text-align: right"
Me.Label95.Text = "(2/2ページ)"
Me.Label95.Top = 9.65591!
Me.Label95.Width = 0.7188979!
'
'REQ_F_SEAT_KIBOU5
'
Me.REQ_F_SEAT_KIBOU5.DataField = "REQ_F_SEAT_KIBOU5"
Me.REQ_F_SEAT_KIBOU5.Height = 0.2!
Me.REQ_F_SEAT_KIBOU5.Left = 6.172835!
Me.REQ_F_SEAT_KIBOU5.Name = "REQ_F_SEAT_KIBOU5"
Me.REQ_F_SEAT_KIBOU5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_KIBOU5.Text = Nothing
Me.REQ_F_SEAT_KIBOU5.Top = 17.29685!
Me.REQ_F_SEAT_KIBOU5.Width = 0.979134!
'
'REQ_F_SEAT_5
'
Me.REQ_F_SEAT_5.DataField = "REQ_F_SEAT_5"
Me.REQ_F_SEAT_5.Height = 0.2!
Me.REQ_F_SEAT_5.Left = 4.507481!
Me.REQ_F_SEAT_5.Name = "REQ_F_SEAT_5"
Me.REQ_F_SEAT_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_5.Text = Nothing
Me.REQ_F_SEAT_5.Top = 17.29685!
Me.REQ_F_SEAT_5.Width = 0.9779529!
'
'REQ_F_BIN_5
'
Me.REQ_F_BIN_5.DataField = "REQ_F_BIN_5"
Me.REQ_F_BIN_5.Height = 0.2!
Me.REQ_F_BIN_5.Left = 4.507481!
Me.REQ_F_BIN_5.Name = "REQ_F_BIN_5"
Me.REQ_F_BIN_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_BIN_5.Text = Nothing
Me.REQ_F_BIN_5.Top = 16.69685!
Me.REQ_F_BIN_5.Width = 2.644488!
'
'REQ_F_TIME2_5
'
Me.REQ_F_TIME2_5.DataField = "REQ_F_TIME2_5"
Me.REQ_F_TIME2_5.Height = 0.2!
Me.REQ_F_TIME2_5.Left = 6.172835!
Me.REQ_F_TIME2_5.Name = "REQ_F_TIME2_5"
Me.REQ_F_TIME2_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME2_5.Text = Nothing
Me.REQ_F_TIME2_5.Top = 17.09685!
Me.REQ_F_TIME2_5.Width = 0.979134!
'
'REQ_F_TIME1_5
'
Me.REQ_F_TIME1_5.DataField = "REQ_F_TIME1_5"
Me.REQ_F_TIME1_5.Height = 0.2!
Me.REQ_F_TIME1_5.Left = 4.507481!
Me.REQ_F_TIME1_5.Name = "REQ_F_TIME1_5"
Me.REQ_F_TIME1_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME1_5.Text = Nothing
Me.REQ_F_TIME1_5.Top = 17.09685!
Me.REQ_F_TIME1_5.Width = 0.9779529!
'
'REQ_F_AIRPORT2_5
'
Me.REQ_F_AIRPORT2_5.DataField = "REQ_F_AIRPORT2_5"
Me.REQ_F_AIRPORT2_5.Height = 0.2!
Me.REQ_F_AIRPORT2_5.Left = 6.172833!
Me.REQ_F_AIRPORT2_5.Name = "REQ_F_AIRPORT2_5"
Me.REQ_F_AIRPORT2_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT2_5.Text = Nothing
Me.REQ_F_AIRPORT2_5.Top = 16.89685!
Me.REQ_F_AIRPORT2_5.Width = 0.979134!
'
'REQ_F_AIRPORT1_5
'
Me.REQ_F_AIRPORT1_5.DataField = "REQ_F_AIRPORT1_5"
Me.REQ_F_AIRPORT1_5.Height = 0.2!
Me.REQ_F_AIRPORT1_5.Left = 4.507479!
Me.REQ_F_AIRPORT1_5.Name = "REQ_F_AIRPORT1_5"
Me.REQ_F_AIRPORT1_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT1_5.Text = Nothing
Me.REQ_F_AIRPORT1_5.Top = 16.89685!
Me.REQ_F_AIRPORT1_5.Width = 0.9779529!
'
'REQ_F_DATE_5
'
Me.REQ_F_DATE_5.DataField = "REQ_F_DATE_5"
Me.REQ_F_DATE_5.Height = 0.2!
Me.REQ_F_DATE_5.Left = 4.507481!
Me.REQ_F_DATE_5.Name = "REQ_F_DATE_5"
Me.REQ_F_DATE_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_DATE_5.Text = Nothing
Me.REQ_F_DATE_5.Top = 16.49685!
Me.REQ_F_DATE_5.Width = 0.9779529!
'
'REQ_F_KOTSUKIKAN_5
'
Me.REQ_F_KOTSUKIKAN_5.DataField = "REQ_F_KOTSUKIKAN_5"
Me.REQ_F_KOTSUKIKAN_5.Height = 0.2!
Me.REQ_F_KOTSUKIKAN_5.Left = 6.172835!
Me.REQ_F_KOTSUKIKAN_5.Name = "REQ_F_KOTSUKIKAN_5"
Me.REQ_F_KOTSUKIKAN_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_KOTSUKIKAN_5.Text = Nothing
Me.REQ_F_KOTSUKIKAN_5.Top = 16.49685!
Me.REQ_F_KOTSUKIKAN_5.Width = 0.979134!
'
'REQ_F_IRAINAIYOU_5
'
Me.REQ_F_IRAINAIYOU_5.DataField = "REQ_F_IRAINAIYOU_5"
Me.REQ_F_IRAINAIYOU_5.Height = 0.2!
Me.REQ_F_IRAINAIYOU_5.Left = 6.186221!
Me.REQ_F_IRAINAIYOU_5.Name = "REQ_F_IRAINAIYOU_5"
Me.REQ_F_IRAINAIYOU_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_IRAINAIYOU_5.Text = Nothing
Me.REQ_F_IRAINAIYOU_5.Top = 16.29685!
Me.REQ_F_IRAINAIYOU_5.Width = 0.9657478!
'
'REQ_F_TEHAI_5
'
Me.REQ_F_TEHAI_5.DataField = "REQ_F_TEHAI_5"
Me.REQ_F_TEHAI_5.Height = 0.2!
Me.REQ_F_TEHAI_5.Left = 4.507481!
Me.REQ_F_TEHAI_5.Name = "REQ_F_TEHAI_5"
Me.REQ_F_TEHAI_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TEHAI_5.Text = Nothing
Me.REQ_F_TEHAI_5.Top = 16.29685!
Me.REQ_F_TEHAI_5.Width = 0.9779529!
'
'REQ_F_SEAT_KIBOU4
'
Me.REQ_F_SEAT_KIBOU4.DataField = "REQ_F_SEAT_KIBOU4"
Me.REQ_F_SEAT_KIBOU4.Height = 0.2!
Me.REQ_F_SEAT_KIBOU4.Left = 6.172835!
Me.REQ_F_SEAT_KIBOU4.Name = "REQ_F_SEAT_KIBOU4"
Me.REQ_F_SEAT_KIBOU4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_KIBOU4.Text = Nothing
Me.REQ_F_SEAT_KIBOU4.Top = 16.09685!
Me.REQ_F_SEAT_KIBOU4.Width = 0.979134!
'
'REQ_F_SEAT_4
'
Me.REQ_F_SEAT_4.DataField = "REQ_F_SEAT_4"
Me.REQ_F_SEAT_4.Height = 0.2!
Me.REQ_F_SEAT_4.Left = 4.507481!
Me.REQ_F_SEAT_4.Name = "REQ_F_SEAT_4"
Me.REQ_F_SEAT_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_4.Text = Nothing
Me.REQ_F_SEAT_4.Top = 16.09685!
Me.REQ_F_SEAT_4.Width = 0.9779529!
'
'REQ_F_BIN_4
'
Me.REQ_F_BIN_4.DataField = "REQ_F_BIN_4"
Me.REQ_F_BIN_4.Height = 0.2!
Me.REQ_F_BIN_4.Left = 4.507481!
Me.REQ_F_BIN_4.Name = "REQ_F_BIN_4"
Me.REQ_F_BIN_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_BIN_4.Text = Nothing
Me.REQ_F_BIN_4.Top = 15.49685!
Me.REQ_F_BIN_4.Width = 2.657874!
'
'REQ_F_TIME2_4
'
Me.REQ_F_TIME2_4.DataField = "REQ_F_TIME2_4"
Me.REQ_F_TIME2_4.Height = 0.2!
Me.REQ_F_TIME2_4.Left = 6.172835!
Me.REQ_F_TIME2_4.Name = "REQ_F_TIME2_4"
Me.REQ_F_TIME2_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME2_4.Text = Nothing
Me.REQ_F_TIME2_4.Top = 15.89685!
Me.REQ_F_TIME2_4.Width = 0.979134!
'
'REQ_F_TIME1_4
'
Me.REQ_F_TIME1_4.DataField = "REQ_F_TIME1_4"
Me.REQ_F_TIME1_4.Height = 0.2!
Me.REQ_F_TIME1_4.Left = 4.507481!
Me.REQ_F_TIME1_4.Name = "REQ_F_TIME1_4"
Me.REQ_F_TIME1_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME1_4.Text = Nothing
Me.REQ_F_TIME1_4.Top = 15.89685!
Me.REQ_F_TIME1_4.Width = 0.9779529!
'
'REQ_F_AIRPORT2_4
'
Me.REQ_F_AIRPORT2_4.DataField = "REQ_F_AIRPORT2_4"
Me.REQ_F_AIRPORT2_4.Height = 0.2!
Me.REQ_F_AIRPORT2_4.Left = 6.172835!
Me.REQ_F_AIRPORT2_4.Name = "REQ_F_AIRPORT2_4"
Me.REQ_F_AIRPORT2_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT2_4.Text = Nothing
Me.REQ_F_AIRPORT2_4.Top = 15.69685!
Me.REQ_F_AIRPORT2_4.Width = 0.979134!
'
'REQ_F_AIRPORT1_4
'
Me.REQ_F_AIRPORT1_4.DataField = "REQ_F_AIRPORT1_4"
Me.REQ_F_AIRPORT1_4.Height = 0.2!
Me.REQ_F_AIRPORT1_4.Left = 4.507481!
Me.REQ_F_AIRPORT1_4.Name = "REQ_F_AIRPORT1_4"
Me.REQ_F_AIRPORT1_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT1_4.Text = Nothing
Me.REQ_F_AIRPORT1_4.Top = 15.69685!
Me.REQ_F_AIRPORT1_4.Width = 0.9779529!
'
'REQ_F_DATE_4
'
Me.REQ_F_DATE_4.DataField = "REQ_F_DATE_4"
Me.REQ_F_DATE_4.Height = 0.2!
Me.REQ_F_DATE_4.Left = 4.507481!
Me.REQ_F_DATE_4.Name = "REQ_F_DATE_4"
Me.REQ_F_DATE_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_DATE_4.Text = Nothing
Me.REQ_F_DATE_4.Top = 15.29685!
Me.REQ_F_DATE_4.Width = 0.9779529!
'
'REQ_F_KOTSUKIKAN_4
'
Me.REQ_F_KOTSUKIKAN_4.DataField = "REQ_F_KOTSUKIKAN_4"
Me.REQ_F_KOTSUKIKAN_4.Height = 0.2!
Me.REQ_F_KOTSUKIKAN_4.Left = 6.172835!
Me.REQ_F_KOTSUKIKAN_4.Name = "REQ_F_KOTSUKIKAN_4"
Me.REQ_F_KOTSUKIKAN_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_KOTSUKIKAN_4.Text = Nothing
Me.REQ_F_KOTSUKIKAN_4.Top = 15.29685!
Me.REQ_F_KOTSUKIKAN_4.Width = 0.979134!
'
'REQ_F_IRAINAIYOU_4
'
Me.REQ_F_IRAINAIYOU_4.DataField = "REQ_F_IRAINAIYOU_4"
Me.REQ_F_IRAINAIYOU_4.Height = 0.2!
Me.REQ_F_IRAINAIYOU_4.Left = 6.186221!
Me.REQ_F_IRAINAIYOU_4.Name = "REQ_F_IRAINAIYOU_4"
Me.REQ_F_IRAINAIYOU_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_IRAINAIYOU_4.Text = Nothing
Me.REQ_F_IRAINAIYOU_4.Top = 15.09685!
Me.REQ_F_IRAINAIYOU_4.Width = 0.9657478!
'
'REQ_F_TEHAI_4
'
Me.REQ_F_TEHAI_4.DataField = "REQ_F_TEHAI_4"
Me.REQ_F_TEHAI_4.Height = 0.2!
Me.REQ_F_TEHAI_4.Left = 4.507481!
Me.REQ_F_TEHAI_4.Name = "REQ_F_TEHAI_4"
Me.REQ_F_TEHAI_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TEHAI_4.Text = Nothing
Me.REQ_F_TEHAI_4.Top = 15.09685!
Me.REQ_F_TEHAI_4.Width = 0.9779529!
'
'REQ_O_SEAT_KIBOU5
'
Me.REQ_O_SEAT_KIBOU5.DataField = "REQ_O_SEAT_KIBOU5"
Me.REQ_O_SEAT_KIBOU5.Height = 0.2!
Me.REQ_O_SEAT_KIBOU5.Left = 2.579528!
Me.REQ_O_SEAT_KIBOU5.Name = "REQ_O_SEAT_KIBOU5"
Me.REQ_O_SEAT_KIBOU5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_KIBOU5.Text = Nothing
Me.REQ_O_SEAT_KIBOU5.Top = 17.29685!
Me.REQ_O_SEAT_KIBOU5.Width = 0.9791338!
'
'REQ_O_SEAT_5
'
Me.REQ_O_SEAT_5.DataField = "REQ_O_SEAT_5"
Me.REQ_O_SEAT_5.Height = 0.2!
Me.REQ_O_SEAT_5.Left = 0.9165355!
Me.REQ_O_SEAT_5.Name = "REQ_O_SEAT_5"
Me.REQ_O_SEAT_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_5.Text = Nothing
Me.REQ_O_SEAT_5.Top = 17.29685!
Me.REQ_O_SEAT_5.Width = 0.9755906!
'
'REQ_O_BIN_5
'
Me.REQ_O_BIN_5.DataField = "REQ_O_BIN_5"
Me.REQ_O_BIN_5.Height = 0.2!
Me.REQ_O_BIN_5.Left = 0.9165355!
Me.REQ_O_BIN_5.Name = "REQ_O_BIN_5"
Me.REQ_O_BIN_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_BIN_5.Text = Nothing
Me.REQ_O_BIN_5.Top = 16.69685!
Me.REQ_O_BIN_5.Width = 2.642126!
'
'REQ_O_TIME2_5
'
Me.REQ_O_TIME2_5.DataField = "REQ_O_TIME2_5"
Me.REQ_O_TIME2_5.Height = 0.2!
Me.REQ_O_TIME2_5.Left = 2.579528!
Me.REQ_O_TIME2_5.Name = "REQ_O_TIME2_5"
Me.REQ_O_TIME2_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME2_5.Text = Nothing
Me.REQ_O_TIME2_5.Top = 17.09685!
Me.REQ_O_TIME2_5.Width = 0.9791338!
'
'REQ_O_TIME1_5
'
Me.REQ_O_TIME1_5.DataField = "REQ_O_TIME1_5"
Me.REQ_O_TIME1_5.Height = 0.2!
Me.REQ_O_TIME1_5.Left = 0.9165355!
Me.REQ_O_TIME1_5.Name = "REQ_O_TIME1_5"
Me.REQ_O_TIME1_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME1_5.Text = Nothing
Me.REQ_O_TIME1_5.Top = 17.09685!
Me.REQ_O_TIME1_5.Width = 0.9755906!
'
'REQ_O_AIRPORT2_5
'
Me.REQ_O_AIRPORT2_5.DataField = "REQ_O_AIRPORT2_5"
Me.REQ_O_AIRPORT2_5.Height = 0.2!
Me.REQ_O_AIRPORT2_5.Left = 2.579528!
Me.REQ_O_AIRPORT2_5.Name = "REQ_O_AIRPORT2_5"
Me.REQ_O_AIRPORT2_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT2_5.Text = Nothing
Me.REQ_O_AIRPORT2_5.Top = 16.89685!
Me.REQ_O_AIRPORT2_5.Width = 0.9791338!
'
'REQ_O_AIRPORT1_5
'
Me.REQ_O_AIRPORT1_5.DataField = "REQ_O_AIRPORT1_5"
Me.REQ_O_AIRPORT1_5.Height = 0.2!
Me.REQ_O_AIRPORT1_5.Left = 0.9165355!
Me.REQ_O_AIRPORT1_5.Name = "REQ_O_AIRPORT1_5"
Me.REQ_O_AIRPORT1_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT1_5.Text = Nothing
Me.REQ_O_AIRPORT1_5.Top = 16.89685!
Me.REQ_O_AIRPORT1_5.Width = 0.9755906!
'
'REQ_O_DATE_5
'
Me.REQ_O_DATE_5.DataField = "REQ_O_DATE_5"
Me.REQ_O_DATE_5.Height = 0.2!
Me.REQ_O_DATE_5.Left = 0.9165355!
Me.REQ_O_DATE_5.Name = "REQ_O_DATE_5"
Me.REQ_O_DATE_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_DATE_5.Text = Nothing
Me.REQ_O_DATE_5.Top = 16.49685!
Me.REQ_O_DATE_5.Width = 0.9755906!
'
'REQ_O_KOTSUKIKAN_5
'
Me.REQ_O_KOTSUKIKAN_5.DataField = "REQ_O_KOTSUKIKAN_5"
Me.REQ_O_KOTSUKIKAN_5.Height = 0.2!
Me.REQ_O_KOTSUKIKAN_5.Left = 2.579528!
Me.REQ_O_KOTSUKIKAN_5.Name = "REQ_O_KOTSUKIKAN_5"
Me.REQ_O_KOTSUKIKAN_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_KOTSUKIKAN_5.Text = Nothing
Me.REQ_O_KOTSUKIKAN_5.Top = 16.49685!
Me.REQ_O_KOTSUKIKAN_5.Width = 0.9688975!
'
'REQ_O_IRAINAIYOU_5
'
Me.REQ_O_IRAINAIYOU_5.DataField = "REQ_O_IRAINAIYOU_5"
Me.REQ_O_IRAINAIYOU_5.Height = 0.2!
Me.REQ_O_IRAINAIYOU_5.Left = 2.579528!
Me.REQ_O_IRAINAIYOU_5.Name = "REQ_O_IRAINAIYOU_5"
Me.REQ_O_IRAINAIYOU_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_IRAINAIYOU_5.Text = Nothing
Me.REQ_O_IRAINAIYOU_5.Top = 16.29685!
Me.REQ_O_IRAINAIYOU_5.Width = 0.9791338!
'
'REQ_O_TEHAI_5
'
Me.REQ_O_TEHAI_5.DataField = "REQ_O_TEHAI_5"
Me.REQ_O_TEHAI_5.Height = 0.2!
Me.REQ_O_TEHAI_5.Left = 0.9165355!
Me.REQ_O_TEHAI_5.Name = "REQ_O_TEHAI_5"
Me.REQ_O_TEHAI_5.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TEHAI_5.Text = Nothing
Me.REQ_O_TEHAI_5.Top = 16.29685!
Me.REQ_O_TEHAI_5.Width = 0.9755906!
'
'REQ_F_SEAT_KIBOU2
'
Me.REQ_F_SEAT_KIBOU2.DataField = "REQ_F_SEAT_KIBOU2"
Me.REQ_F_SEAT_KIBOU2.Height = 0.2!
Me.REQ_F_SEAT_KIBOU2.Left = 6.172835!
Me.REQ_F_SEAT_KIBOU2.Name = "REQ_F_SEAT_KIBOU2"
Me.REQ_F_SEAT_KIBOU2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_KIBOU2.Text = Nothing
Me.REQ_F_SEAT_KIBOU2.Top = 13.69685!
Me.REQ_F_SEAT_KIBOU2.Width = 0.979134!
'
'REQ_F_SEAT_2
'
Me.REQ_F_SEAT_2.DataField = "REQ_F_SEAT_2"
Me.REQ_F_SEAT_2.Height = 0.2!
Me.REQ_F_SEAT_2.Left = 4.507481!
Me.REQ_F_SEAT_2.Name = "REQ_F_SEAT_2"
Me.REQ_F_SEAT_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_2.Text = Nothing
Me.REQ_F_SEAT_2.Top = 13.69685!
Me.REQ_F_SEAT_2.Width = 0.9779529!
'
'REQ_F_BIN_2
'
Me.REQ_F_BIN_2.DataField = "REQ_F_BIN_2"
Me.REQ_F_BIN_2.Height = 0.2!
Me.REQ_F_BIN_2.Left = 4.507481!
Me.REQ_F_BIN_2.Name = "REQ_F_BIN_2"
Me.REQ_F_BIN_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_BIN_2.Text = Nothing
Me.REQ_F_BIN_2.Top = 13.09685!
Me.REQ_F_BIN_2.Width = 2.644488!
'
'REQ_F_TIME2_2
'
Me.REQ_F_TIME2_2.DataField = "REQ_F_TIME2_2"
Me.REQ_F_TIME2_2.Height = 0.2!
Me.REQ_F_TIME2_2.Left = 6.172835!
Me.REQ_F_TIME2_2.Name = "REQ_F_TIME2_2"
Me.REQ_F_TIME2_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME2_2.Text = Nothing
Me.REQ_F_TIME2_2.Top = 13.49685!
Me.REQ_F_TIME2_2.Width = 0.988583!
'
'REQ_F_TIME1_2
'
Me.REQ_F_TIME1_2.DataField = "REQ_F_TIME1_2"
Me.REQ_F_TIME1_2.Height = 0.2!
Me.REQ_F_TIME1_2.Left = 4.507481!
Me.REQ_F_TIME1_2.Name = "REQ_F_TIME1_2"
Me.REQ_F_TIME1_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TIME1_2.Text = Nothing
Me.REQ_F_TIME1_2.Top = 13.49685!
Me.REQ_F_TIME1_2.Width = 0.9779529!
'
'REQ_F_AIRPORT2_2
'
Me.REQ_F_AIRPORT2_2.DataField = "REQ_F_AIRPORT2_2"
Me.REQ_F_AIRPORT2_2.Height = 0.2!
Me.REQ_F_AIRPORT2_2.Left = 6.172835!
Me.REQ_F_AIRPORT2_2.Name = "REQ_F_AIRPORT2_2"
Me.REQ_F_AIRPORT2_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT2_2.Text = Nothing
Me.REQ_F_AIRPORT2_2.Top = 13.29685!
Me.REQ_F_AIRPORT2_2.Width = 0.988583!
'
'REQ_F_AIRPORT1_2
'
Me.REQ_F_AIRPORT1_2.DataField = "REQ_F_AIRPORT1_2"
Me.REQ_F_AIRPORT1_2.Height = 0.2!
Me.REQ_F_AIRPORT1_2.Left = 4.507481!
Me.REQ_F_AIRPORT1_2.Name = "REQ_F_AIRPORT1_2"
Me.REQ_F_AIRPORT1_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_AIRPORT1_2.Text = Nothing
Me.REQ_F_AIRPORT1_2.Top = 13.29685!
Me.REQ_F_AIRPORT1_2.Width = 0.9779529!
'
'REQ_F_DATE_2
'
Me.REQ_F_DATE_2.DataField = "REQ_F_DATE_2"
Me.REQ_F_DATE_2.Height = 0.2!
Me.REQ_F_DATE_2.Left = 4.507481!
Me.REQ_F_DATE_2.Name = "REQ_F_DATE_2"
Me.REQ_F_DATE_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_DATE_2.Text = Nothing
Me.REQ_F_DATE_2.Top = 12.89685!
Me.REQ_F_DATE_2.Width = 0.9779529!
'
'REQ_F_KOTSUKIKAN_2
'
Me.REQ_F_KOTSUKIKAN_2.DataField = "REQ_F_KOTSUKIKAN_2"
Me.REQ_F_KOTSUKIKAN_2.Height = 0.2!
Me.REQ_F_KOTSUKIKAN_2.Left = 6.172835!
Me.REQ_F_KOTSUKIKAN_2.Name = "REQ_F_KOTSUKIKAN_2"
Me.REQ_F_KOTSUKIKAN_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_KOTSUKIKAN_2.Text = Nothing
Me.REQ_F_KOTSUKIKAN_2.Top = 12.89685!
Me.REQ_F_KOTSUKIKAN_2.Width = 0.979134!
'
'REQ_F_IRAINAIYOU_2
'
Me.REQ_F_IRAINAIYOU_2.DataField = "REQ_F_IRAINAIYOU_2"
Me.REQ_F_IRAINAIYOU_2.Height = 0.2!
Me.REQ_F_IRAINAIYOU_2.Left = 6.172835!
Me.REQ_F_IRAINAIYOU_2.Name = "REQ_F_IRAINAIYOU_2"
Me.REQ_F_IRAINAIYOU_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_IRAINAIYOU_2.Text = Nothing
Me.REQ_F_IRAINAIYOU_2.Top = 12.69685!
Me.REQ_F_IRAINAIYOU_2.Width = 0.979134!
'
'REQ_O_SEAT_KIBOU2
'
Me.REQ_O_SEAT_KIBOU2.DataField = "REQ_O_SEAT_KIBOU2"
Me.REQ_O_SEAT_KIBOU2.Height = 0.2!
Me.REQ_O_SEAT_KIBOU2.Left = 2.579528!
Me.REQ_O_SEAT_KIBOU2.Name = "REQ_O_SEAT_KIBOU2"
Me.REQ_O_SEAT_KIBOU2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_KIBOU2.Text = Nothing
Me.REQ_O_SEAT_KIBOU2.Top = 13.69685!
Me.REQ_O_SEAT_KIBOU2.Width = 0.9791338!
'
'REQ_O_SEAT_2
'
Me.REQ_O_SEAT_2.DataField = "REQ_O_SEAT_2"
Me.REQ_O_SEAT_2.Height = 0.2!
Me.REQ_O_SEAT_2.Left = 0.9165355!
Me.REQ_O_SEAT_2.Name = "REQ_O_SEAT_2"
Me.REQ_O_SEAT_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_2.Text = Nothing
Me.REQ_O_SEAT_2.Top = 13.69685!
Me.REQ_O_SEAT_2.Width = 0.9755906!
'
'REQ_O_BIN_2
'
Me.REQ_O_BIN_2.DataField = "REQ_O_BIN_2"
Me.REQ_O_BIN_2.Height = 0.2!
Me.REQ_O_BIN_2.Left = 0.9165355!
Me.REQ_O_BIN_2.Name = "REQ_O_BIN_2"
Me.REQ_O_BIN_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_BIN_2.Text = Nothing
Me.REQ_O_BIN_2.Top = 13.09685!
Me.REQ_O_BIN_2.Width = 2.642126!
'
'REQ_O_TIME2_2
'
Me.REQ_O_TIME2_2.DataField = "REQ_O_TIME2_2"
Me.REQ_O_TIME2_2.Height = 0.2!
Me.REQ_O_TIME2_2.Left = 2.579528!
Me.REQ_O_TIME2_2.Name = "REQ_O_TIME2_2"
Me.REQ_O_TIME2_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME2_2.Text = Nothing
Me.REQ_O_TIME2_2.Top = 13.49685!
Me.REQ_O_TIME2_2.Width = 0.9791338!
'
'REQ_O_TIME1_2
'
Me.REQ_O_TIME1_2.DataField = "REQ_O_TIME1_2"
Me.REQ_O_TIME1_2.Height = 0.2!
Me.REQ_O_TIME1_2.Left = 0.9165355!
Me.REQ_O_TIME1_2.Name = "REQ_O_TIME1_2"
Me.REQ_O_TIME1_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME1_2.Text = Nothing
Me.REQ_O_TIME1_2.Top = 13.49685!
Me.REQ_O_TIME1_2.Width = 0.9755906!
'
'REQ_O_AIRPORT2_2
'
Me.REQ_O_AIRPORT2_2.DataField = "REQ_O_AIRPORT2_2"
Me.REQ_O_AIRPORT2_2.Height = 0.2!
Me.REQ_O_AIRPORT2_2.Left = 2.579528!
Me.REQ_O_AIRPORT2_2.Name = "REQ_O_AIRPORT2_2"
Me.REQ_O_AIRPORT2_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT2_2.Text = Nothing
Me.REQ_O_AIRPORT2_2.Top = 13.29685!
Me.REQ_O_AIRPORT2_2.Width = 0.9791338!
'
'REQ_O_AIRPORT1_2
'
Me.REQ_O_AIRPORT1_2.DataField = "REQ_O_AIRPORT1_2"
Me.REQ_O_AIRPORT1_2.Height = 0.2!
Me.REQ_O_AIRPORT1_2.Left = 0.9165355!
Me.REQ_O_AIRPORT1_2.Name = "REQ_O_AIRPORT1_2"
Me.REQ_O_AIRPORT1_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT1_2.Text = Nothing
Me.REQ_O_AIRPORT1_2.Top = 13.29685!
Me.REQ_O_AIRPORT1_2.Width = 0.9755906!
'
'REQ_O_DATE_2
'
Me.REQ_O_DATE_2.DataField = "REQ_O_DATE_2"
Me.REQ_O_DATE_2.Height = 0.2!
Me.REQ_O_DATE_2.Left = 0.9165355!
Me.REQ_O_DATE_2.Name = "REQ_O_DATE_2"
Me.REQ_O_DATE_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_DATE_2.Text = Nothing
Me.REQ_O_DATE_2.Top = 12.89685!
Me.REQ_O_DATE_2.Width = 0.9755906!
'
'REQ_O_KOTSUKIKAN_2
'
Me.REQ_O_KOTSUKIKAN_2.DataField = "REQ_O_KOTSUKIKAN_2"
Me.REQ_O_KOTSUKIKAN_2.Height = 0.2!
Me.REQ_O_KOTSUKIKAN_2.Left = 2.579528!
Me.REQ_O_KOTSUKIKAN_2.Name = "REQ_O_KOTSUKIKAN_2"
Me.REQ_O_KOTSUKIKAN_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_KOTSUKIKAN_2.Text = Nothing
Me.REQ_O_KOTSUKIKAN_2.Top = 12.89685!
Me.REQ_O_KOTSUKIKAN_2.Width = 0.9791338!
'
'REQ_O_IRAINAIYOU_2
'
Me.REQ_O_IRAINAIYOU_2.DataField = "REQ_O_IRAINAIYOU_2"
Me.REQ_O_IRAINAIYOU_2.Height = 0.2!
Me.REQ_O_IRAINAIYOU_2.Left = 2.579528!
Me.REQ_O_IRAINAIYOU_2.Name = "REQ_O_IRAINAIYOU_2"
Me.REQ_O_IRAINAIYOU_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_IRAINAIYOU_2.Text = Nothing
Me.REQ_O_IRAINAIYOU_2.Top = 12.69685!
Me.REQ_O_IRAINAIYOU_2.Width = 0.9791338!
'
'REQ_F_TEHAI_2
'
Me.REQ_F_TEHAI_2.DataField = "REQ_F_TEHAI_2"
Me.REQ_F_TEHAI_2.Height = 0.2!
Me.REQ_F_TEHAI_2.Left = 4.507481!
Me.REQ_F_TEHAI_2.Name = "REQ_F_TEHAI_2"
Me.REQ_F_TEHAI_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TEHAI_2.Text = Nothing
Me.REQ_F_TEHAI_2.Top = 12.69685!
Me.REQ_F_TEHAI_2.Width = 0.9779529!
'
'REQ_O_TEHAI_2
'
Me.REQ_O_TEHAI_2.DataField = "REQ_O_TEHAI_2"
Me.REQ_O_TEHAI_2.Height = 0.2!
Me.REQ_O_TEHAI_2.Left = 0.9165355!
Me.REQ_O_TEHAI_2.Name = "REQ_O_TEHAI_2"
Me.REQ_O_TEHAI_2.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TEHAI_2.Text = Nothing
Me.REQ_O_TEHAI_2.Top = 12.69685!
Me.REQ_O_TEHAI_2.Width = 0.9755906!
'
'Label108
'
Me.Label108.Height = 0.2!
Me.Label108.HyperLink = Nothing
Me.Label108.Left = 5.485435!
Me.Label108.Name = "Label108"
Me.Label108.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label108.Text = "座席希望"
Me.Label108.Top = 17.29685!
Me.Label108.Width = 0.6874015!
'
'Label107
'
Me.Label107.Height = 0.2!
Me.Label107.HyperLink = Nothing
Me.Label107.Left = 3.763782!
Me.Label107.Name = "Label107"
Me.Label107.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label107.Text = "座席区分"
Me.Label107.Top = 17.29685!
Me.Label107.Width = 0.7436993!
'
'Label106
'
Me.Label106.Height = 0.2!
Me.Label106.HyperLink = Nothing
Me.Label106.Left = 3.763782!
Me.Label106.Name = "Label106"
Me.Label106.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label106.Text = "列車・便名"
Me.Label106.Top = 16.69685!
Me.Label106.Width = 0.7436993!
'
'Label105
'
Me.Label105.Height = 0.2!
Me.Label105.HyperLink = Nothing
Me.Label105.Left = 5.485435!
Me.Label105.Name = "Label105"
Me.Label105.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label105.Text = "到着時間"
Me.Label105.Top = 17.09685!
Me.Label105.Width = 0.6874015!
'
'Label104
'
Me.Label104.Height = 0.2!
Me.Label104.HyperLink = Nothing
Me.Label104.Left = 3.763782!
Me.Label104.Name = "Label104"
Me.Label104.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label104.Text = "出発時間"
Me.Label104.Top = 17.09685!
Me.Label104.Width = 0.7436993!
'
'Label103
'
Me.Label103.Height = 0.2!
Me.Label103.HyperLink = Nothing
Me.Label103.Left = 5.485434!
Me.Label103.Name = "Label103"
Me.Label103.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label103.Text = "到着地"
Me.Label103.Top = 16.89685!
Me.Label103.Width = 0.6874015!
'
'Label102
'
Me.Label102.Height = 0.2!
Me.Label102.HyperLink = Nothing
Me.Label102.Left = 3.76378!
Me.Label102.Name = "Label102"
Me.Label102.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label102.Text = "出発地"
Me.Label102.Top = 16.89685!
Me.Label102.Width = 0.7436993!
'
'Label101
'
Me.Label101.Height = 0.2!
Me.Label101.HyperLink = Nothing
Me.Label101.Left = 3.763782!
Me.Label101.Name = "Label101"
Me.Label101.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label101.Text = "利用日"
Me.Label101.Top = 16.49685!
Me.Label101.Width = 0.7436993!
'
'Label100
'
Me.Label100.Height = 0.2!
Me.Label100.HyperLink = Nothing
Me.Label100.Left = 5.485435!
Me.Label100.Name = "Label100"
Me.Label100.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label100.Text = "交通機関"
Me.Label100.Top = 16.49685!
Me.Label100.Width = 0.6874015!
'
'Label99
'
Me.Label99.Height = 0.2!
Me.Label99.HyperLink = Nothing
Me.Label99.Left = 5.485434!
Me.Label99.Name = "Label99"
Me.Label99.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label99.Text = "依頼内容"
Me.Label99.Top = 16.29685!
Me.Label99.Width = 0.7007875!
'
'Label98
'
Me.Label98.Height = 0.1999999!
Me.Label98.HyperLink = Nothing
Me.Label98.Left = 3.76378!
Me.Label98.Name = "Label98"
Me.Label98.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label98.Text = "希望する"
Me.Label98.Top = 16.29685!
Me.Label98.Width = 0.7437003!
'
'FUKURO5
'
Me.FUKURO5.Height = 1.2!
Me.FUKURO5.HyperLink = Nothing
Me.FUKURO5.Left = 3.558662!
Me.FUKURO5.Name = "FUKURO5"
Me.FUKURO5.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bo"& _ 
    "ld; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-ve"& _ 
    "rtical: true"
Me.FUKURO5.Text = ""
Me.FUKURO5.Top = 16.29685!
Me.FUKURO5.Width = 0.2051181!
'
'Label96
'
Me.Label96.Height = 0.2!
Me.Label96.HyperLink = Nothing
Me.Label96.Left = 1.892125!
Me.Label96.Name = "Label96"
Me.Label96.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label96.Text = "座席希望"
Me.Label96.Top = 17.29685!
Me.Label96.Width = 0.6874028!
'
'Label97
'
Me.Label97.Height = 0.2!
Me.Label97.HyperLink = Nothing
Me.Label97.Left = 0.2291329!
Me.Label97.Name = "Label97"
Me.Label97.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label97.Text = "座席区分"
Me.Label97.Top = 17.29685!
Me.Label97.Width = 0.6874026!
'
'Label109
'
Me.Label109.Height = 0.2!
Me.Label109.HyperLink = Nothing
Me.Label109.Left = 0.2291329!
Me.Label109.Name = "Label109"
Me.Label109.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label109.Text = "列車・便名"
Me.Label109.Top = 16.69685!
Me.Label109.Width = 0.6874026!
'
'Label110
'
Me.Label110.Height = 0.2!
Me.Label110.HyperLink = Nothing
Me.Label110.Left = 1.902361!
Me.Label110.Name = "Label110"
Me.Label110.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label110.Text = "到着時間"
Me.Label110.Top = 17.09685!
Me.Label110.Width = 0.6771665!
'
'Label111
'
Me.Label111.Height = 0.2!
Me.Label111.HyperLink = Nothing
Me.Label111.Left = 0.2291329!
Me.Label111.Name = "Label111"
Me.Label111.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label111.Text = "出発時間"
Me.Label111.Top = 17.09685!
Me.Label111.Width = 0.6874026!
'
'Label112
'
Me.Label112.Height = 0.2!
Me.Label112.HyperLink = Nothing
Me.Label112.Left = 1.892125!
Me.Label112.Name = "Label112"
Me.Label112.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label112.Text = "到着地"
Me.Label112.Top = 16.89685!
Me.Label112.Width = 0.6874028!
'
'Label113
'
Me.Label113.Height = 0.2!
Me.Label113.HyperLink = Nothing
Me.Label113.Left = 0.2291329!
Me.Label113.Name = "Label113"
Me.Label113.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label113.Text = "出発地"
Me.Label113.Top = 16.89685!
Me.Label113.Width = 0.6874026!
'
'Label114
'
Me.Label114.Height = 0.2!
Me.Label114.HyperLink = Nothing
Me.Label114.Left = 0.2291329!
Me.Label114.Name = "Label114"
Me.Label114.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label114.Text = "利用日"
Me.Label114.Top = 16.49685!
Me.Label114.Width = 0.6874026!
'
'Label115
'
Me.Label115.Height = 0.2!
Me.Label115.HyperLink = Nothing
Me.Label115.Left = 1.892125!
Me.Label115.Name = "Label115"
Me.Label115.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label115.Text = "交通機関"
Me.Label115.Top = 16.49685!
Me.Label115.Width = 0.6874027!
'
'Label116
'
Me.Label116.Height = 0.2!
Me.Label116.HyperLink = Nothing
Me.Label116.Left = 1.892125!
Me.Label116.Name = "Label116"
Me.Label116.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label116.Text = "依頼内容"
Me.Label116.Top = 16.29685!
Me.Label116.Width = 0.6874028!
'
'Label117
'
Me.Label117.Height = 0.1999999!
Me.Label117.HyperLink = Nothing
Me.Label117.Left = 0.2291338!
Me.Label117.Name = "Label117"
Me.Label117.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label117.Text = "希望する"
Me.Label117.Top = 16.29685!
Me.Label117.Width = 0.6874017!
'
'OURO5
'
Me.OURO5.Height = 1.2!
Me.OURO5.HyperLink = Nothing
Me.OURO5.Left = 0!
Me.OURO5.Name = "OURO5"
Me.OURO5.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bo"& _ 
    "ld; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-ve"& _ 
    "rtical: true"
Me.OURO5.Text = ""
Me.OURO5.Top = 16.29685!
Me.OURO5.Width = 0.2291338!
'
'Label118
'
Me.Label118.Height = 0.2!
Me.Label118.HyperLink = Nothing
Me.Label118.Left = 5.485433!
Me.Label118.Name = "Label118"
Me.Label118.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label118.Text = "座席希望"
Me.Label118.Top = 13.69685!
Me.Label118.Width = 0.6874018!
'
'Label119
'
Me.Label119.Height = 0.2!
Me.Label119.HyperLink = Nothing
Me.Label119.Left = 3.76378!
Me.Label119.Name = "Label119"
Me.Label119.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label119.Text = "座席区分"
Me.Label119.Top = 13.69685!
Me.Label119.Width = 0.743701!
'
'Label120
'
Me.Label120.Height = 0.2!
Me.Label120.HyperLink = Nothing
Me.Label120.Left = 3.76378!
Me.Label120.Name = "Label120"
Me.Label120.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label120.Text = "列車・便名"
Me.Label120.Top = 13.09685!
Me.Label120.Width = 0.7437008!
'
'Label121
'
Me.Label121.Height = 0.2!
Me.Label121.HyperLink = Nothing
Me.Label121.Left = 5.485433!
Me.Label121.Name = "Label121"
Me.Label121.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label121.Text = "到着時間"
Me.Label121.Top = 13.49685!
Me.Label121.Width = 0.6874018!
'
'Label122
'
Me.Label122.Height = 0.2!
Me.Label122.HyperLink = Nothing
Me.Label122.Left = 3.76378!
Me.Label122.Name = "Label122"
Me.Label122.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label122.Text = "出発時間"
Me.Label122.Top = 13.49685!
Me.Label122.Width = 0.743701!
'
'Label123
'
Me.Label123.Height = 0.2!
Me.Label123.HyperLink = Nothing
Me.Label123.Left = 5.485434!
Me.Label123.Name = "Label123"
Me.Label123.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label123.Text = "到着地"
Me.Label123.Top = 13.29685!
Me.Label123.Width = 0.6874018!
'
'Label124
'
Me.Label124.Height = 0.2!
Me.Label124.HyperLink = Nothing
Me.Label124.Left = 3.76378!
Me.Label124.Name = "Label124"
Me.Label124.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label124.Text = "出発地"
Me.Label124.Top = 13.29685!
Me.Label124.Width = 0.743701!
'
'Label125
'
Me.Label125.Height = 0.2!
Me.Label125.HyperLink = Nothing
Me.Label125.Left = 3.76378!
Me.Label125.Name = "Label125"
Me.Label125.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label125.Text = "利用日"
Me.Label125.Top = 12.89685!
Me.Label125.Width = 0.743701!
'
'Label126
'
Me.Label126.Height = 0.2!
Me.Label126.HyperLink = Nothing
Me.Label126.Left = 5.485433!
Me.Label126.Name = "Label126"
Me.Label126.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label126.Text = "交通機関"
Me.Label126.Top = 12.89685!
Me.Label126.Width = 0.6874018!
'
'Label127
'
Me.Label127.Height = 0.2!
Me.Label127.HyperLink = Nothing
Me.Label127.Left = 5.485433!
Me.Label127.Name = "Label127"
Me.Label127.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label127.Text = "依頼内容"
Me.Label127.Top = 12.69685!
Me.Label127.Width = 0.6874018!
'
'Label128
'
Me.Label128.Height = 0.1999999!
Me.Label128.HyperLink = Nothing
Me.Label128.Left = 3.76378!
Me.Label128.Name = "Label128"
Me.Label128.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label128.Text = "希望する"
Me.Label128.Top = 12.69685!
Me.Label128.Width = 0.743701!
'
'Line71
'
Me.Line71.Height = 2.2!
Me.Line71.Left = 0.2291343!
Me.Line71.LineWeight = 1!
Me.Line71.Name = "Line71"
Me.Line71.Top = 14.09685!
Me.Line71.Width = 8.940697E-08!
Me.Line71.X1 = 0.2291343!
Me.Line71.X2 = 0.2291344!
Me.Line71.Y1 = 14.09685!
Me.Line71.Y2 = 16.29685!
'
'Label129
'
Me.Label129.Height = 0.2!
Me.Label129.HyperLink = Nothing
Me.Label129.Left = 1.892126!
Me.Label129.Name = "Label129"
Me.Label129.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label129.Text = "座席希望"
Me.Label129.Top = 13.69685!
Me.Label129.Width = 0.6874014!
'
'Label130
'
Me.Label130.Height = 0.2!
Me.Label130.HyperLink = Nothing
Me.Label130.Left = 0.229134!
Me.Label130.Name = "Label130"
Me.Label130.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label130.Text = "座席区分"
Me.Label130.Top = 13.69685!
Me.Label130.Width = 0.6874014!
'
'Label131
'
Me.Label131.Height = 0.2!
Me.Label131.HyperLink = Nothing
Me.Label131.Left = 0.229134!
Me.Label131.Name = "Label131"
Me.Label131.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label131.Text = "列車・便名"
Me.Label131.Top = 13.09685!
Me.Label131.Width = 0.6874015!
'
'Label132
'
Me.Label132.Height = 0.2!
Me.Label132.HyperLink = Nothing
Me.Label132.Left = 1.892126!
Me.Label132.Name = "Label132"
Me.Label132.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label132.Text = "到着時間"
Me.Label132.Top = 13.49685!
Me.Label132.Width = 0.6874014!
'
'Label133
'
Me.Label133.Height = 0.2!
Me.Label133.HyperLink = Nothing
Me.Label133.Left = 0.229134!
Me.Label133.Name = "Label133"
Me.Label133.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label133.Text = "出発時間"
Me.Label133.Top = 13.49685!
Me.Label133.Width = 0.6874014!
'
'Label134
'
Me.Label134.Height = 0.2!
Me.Label134.HyperLink = Nothing
Me.Label134.Left = 1.892126!
Me.Label134.Name = "Label134"
Me.Label134.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label134.Text = "到着地"
Me.Label134.Top = 13.29685!
Me.Label134.Width = 0.6874015!
'
'Label135
'
Me.Label135.Height = 0.2!
Me.Label135.HyperLink = Nothing
Me.Label135.Left = 0.229134!
Me.Label135.Name = "Label135"
Me.Label135.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label135.Text = "出発地"
Me.Label135.Top = 13.29685!
Me.Label135.Width = 0.6874015!
'
'Label136
'
Me.Label136.Height = 0.2!
Me.Label136.HyperLink = Nothing
Me.Label136.Left = 0.2291339!
Me.Label136.Name = "Label136"
Me.Label136.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label136.Text = "利用日"
Me.Label136.Top = 12.89685!
Me.Label136.Width = 0.6874015!
'
'Label137
'
Me.Label137.Height = 0.2!
Me.Label137.HyperLink = Nothing
Me.Label137.Left = 1.892126!
Me.Label137.Name = "Label137"
Me.Label137.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label137.Text = "交通機関"
Me.Label137.Top = 12.89685!
Me.Label137.Width = 0.6874015!
'
'Label138
'
Me.Label138.Height = 0.2!
Me.Label138.HyperLink = Nothing
Me.Label138.Left = 1.892126!
Me.Label138.Name = "Label138"
Me.Label138.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label138.Text = "依頼内容"
Me.Label138.Top = 12.69685!
Me.Label138.Width = 0.6874016!
'
'Label139
'
Me.Label139.Height = 0.1999999!
Me.Label139.HyperLink = Nothing
Me.Label139.Left = 0.2291339!
Me.Label139.Name = "Label139"
Me.Label139.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label139.Text = "希望する"
Me.Label139.Top = 12.69685!
Me.Label139.Width = 0.6874014!
'
'OURO2
'
Me.OURO2.Height = 1.2!
Me.OURO2.HyperLink = Nothing
Me.OURO2.Left = 0!
Me.OURO2.Name = "OURO2"
Me.OURO2.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: b"& _ 
    "old; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-v"& _ 
    "ertical: true"
Me.OURO2.Text = ""
Me.OURO2.Top = 12.69685!
Me.OURO2.Width = 0.2291338!
'
'REQ_O_SEAT_KIBOU4
'
Me.REQ_O_SEAT_KIBOU4.DataField = "REQ_O_SEAT_KIBOU4"
Me.REQ_O_SEAT_KIBOU4.Height = 0.2!
Me.REQ_O_SEAT_KIBOU4.Left = 2.579528!
Me.REQ_O_SEAT_KIBOU4.Name = "REQ_O_SEAT_KIBOU4"
Me.REQ_O_SEAT_KIBOU4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_KIBOU4.Text = Nothing
Me.REQ_O_SEAT_KIBOU4.Top = 16.09685!
Me.REQ_O_SEAT_KIBOU4.Width = 0.9791338!
'
'REQ_O_SEAT_4
'
Me.REQ_O_SEAT_4.DataField = "REQ_O_SEAT_4"
Me.REQ_O_SEAT_4.Height = 0.2!
Me.REQ_O_SEAT_4.Left = 0.9165355!
Me.REQ_O_SEAT_4.Name = "REQ_O_SEAT_4"
Me.REQ_O_SEAT_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_4.Text = Nothing
Me.REQ_O_SEAT_4.Top = 16.09685!
Me.REQ_O_SEAT_4.Width = 0.9755906!
'
'REQ_O_BIN_4
'
Me.REQ_O_BIN_4.DataField = "REQ_O_BIN_4"
Me.REQ_O_BIN_4.Height = 0.2!
Me.REQ_O_BIN_4.Left = 0.9165355!
Me.REQ_O_BIN_4.Name = "REQ_O_BIN_4"
Me.REQ_O_BIN_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_BIN_4.Text = Nothing
Me.REQ_O_BIN_4.Top = 15.49685!
Me.REQ_O_BIN_4.Width = 2.642126!
'
'REQ_O_TIME2_4
'
Me.REQ_O_TIME2_4.DataField = "REQ_O_TIME2_4"
Me.REQ_O_TIME2_4.Height = 0.2!
Me.REQ_O_TIME2_4.Left = 2.579528!
Me.REQ_O_TIME2_4.Name = "REQ_O_TIME2_4"
Me.REQ_O_TIME2_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME2_4.Text = Nothing
Me.REQ_O_TIME2_4.Top = 15.89685!
Me.REQ_O_TIME2_4.Width = 0.9791338!
'
'REQ_O_TIME1_4
'
Me.REQ_O_TIME1_4.DataField = "REQ_O_TIME1_4"
Me.REQ_O_TIME1_4.Height = 0.2!
Me.REQ_O_TIME1_4.Left = 0.9165355!
Me.REQ_O_TIME1_4.Name = "REQ_O_TIME1_4"
Me.REQ_O_TIME1_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME1_4.Text = Nothing
Me.REQ_O_TIME1_4.Top = 15.89685!
Me.REQ_O_TIME1_4.Width = 0.9755906!
'
'REQ_O_AIRPORT2_4
'
Me.REQ_O_AIRPORT2_4.DataField = "REQ_O_AIRPORT2_4"
Me.REQ_O_AIRPORT2_4.Height = 0.2!
Me.REQ_O_AIRPORT2_4.Left = 2.579528!
Me.REQ_O_AIRPORT2_4.Name = "REQ_O_AIRPORT2_4"
Me.REQ_O_AIRPORT2_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT2_4.Text = Nothing
Me.REQ_O_AIRPORT2_4.Top = 15.69685!
Me.REQ_O_AIRPORT2_4.Width = 1.011024!
'
'REQ_O_AIRPORT1_4
'
Me.REQ_O_AIRPORT1_4.DataField = "REQ_O_AIRPORT1_4"
Me.REQ_O_AIRPORT1_4.Height = 0.2!
Me.REQ_O_AIRPORT1_4.Left = 0.9165355!
Me.REQ_O_AIRPORT1_4.Name = "REQ_O_AIRPORT1_4"
Me.REQ_O_AIRPORT1_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT1_4.Text = Nothing
Me.REQ_O_AIRPORT1_4.Top = 15.69685!
Me.REQ_O_AIRPORT1_4.Width = 0.9755906!
'
'REQ_O_SEAT_KIBOU1
'
Me.REQ_O_SEAT_KIBOU1.DataField = "REQ_O_SEAT_KIBOU1"
Me.REQ_O_SEAT_KIBOU1.Height = 0.2!
Me.REQ_O_SEAT_KIBOU1.Left = 2.579528!
Me.REQ_O_SEAT_KIBOU1.Name = "REQ_O_SEAT_KIBOU1"
Me.REQ_O_SEAT_KIBOU1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_KIBOU1.Text = Nothing
Me.REQ_O_SEAT_KIBOU1.Top = 12.49685!
Me.REQ_O_SEAT_KIBOU1.Width = 0.9791338!
'
'REQ_O_BIN_1
'
Me.REQ_O_BIN_1.DataField = "REQ_O_BIN_1"
Me.REQ_O_BIN_1.Height = 0.2!
Me.REQ_O_BIN_1.Left = 0.9165355!
Me.REQ_O_BIN_1.Name = "REQ_O_BIN_1"
Me.REQ_O_BIN_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_BIN_1.Text = Nothing
Me.REQ_O_BIN_1.Top = 11.89685!
Me.REQ_O_BIN_1.Width = 2.642126!
'
'REQ_O_TIME2_1
'
Me.REQ_O_TIME2_1.DataField = "REQ_O_TIME2_1"
Me.REQ_O_TIME2_1.Height = 0.2!
Me.REQ_O_TIME2_1.Left = 2.579528!
Me.REQ_O_TIME2_1.Name = "REQ_O_TIME2_1"
Me.REQ_O_TIME2_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TIME2_1.Text = Nothing
Me.REQ_O_TIME2_1.Top = 12.29685!
Me.REQ_O_TIME2_1.Width = 0.9791338!
'
'REQ_O_AIRPORT2_1
'
Me.REQ_O_AIRPORT2_1.DataField = "REQ_O_AIRPORT2_1"
Me.REQ_O_AIRPORT2_1.Height = 0.2!
Me.REQ_O_AIRPORT2_1.Left = 2.579528!
Me.REQ_O_AIRPORT2_1.Name = "REQ_O_AIRPORT2_1"
Me.REQ_O_AIRPORT2_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_AIRPORT2_1.Text = Nothing
Me.REQ_O_AIRPORT2_1.Top = 12.09685!
Me.REQ_O_AIRPORT2_1.Width = 0.9688975!
'
'Label140
'
Me.Label140.Height = 0.2!
Me.Label140.HyperLink = Nothing
Me.Label140.Left = 5.485435!
Me.Label140.Name = "Label140"
Me.Label140.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label140.Text = "座席希望"
Me.Label140.Top = 16.09685!
Me.Label140.Width = 0.6874015!
'
'Label141
'
Me.Label141.Height = 0.2!
Me.Label141.HyperLink = Nothing
Me.Label141.Left = 3.763782!
Me.Label141.Name = "Label141"
Me.Label141.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label141.Text = "座席区分"
Me.Label141.Top = 16.09685!
Me.Label141.Width = 0.7436993!
'
'Label142
'
Me.Label142.Height = 0.2!
Me.Label142.HyperLink = Nothing
Me.Label142.Left = 3.763782!
Me.Label142.Name = "Label142"
Me.Label142.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label142.Text = "列車・便名"
Me.Label142.Top = 15.49685!
Me.Label142.Width = 0.7436993!
'
'Label143
'
Me.Label143.Height = 0.2!
Me.Label143.HyperLink = Nothing
Me.Label143.Left = 5.485435!
Me.Label143.Name = "Label143"
Me.Label143.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label143.Text = "到着時間"
Me.Label143.Top = 15.89685!
Me.Label143.Width = 0.6874015!
'
'Label144
'
Me.Label144.Height = 0.2!
Me.Label144.HyperLink = Nothing
Me.Label144.Left = 3.763782!
Me.Label144.Name = "Label144"
Me.Label144.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label144.Text = "出発時間"
Me.Label144.Top = 15.89685!
Me.Label144.Width = 0.7436993!
'
'Label145
'
Me.Label145.Height = 0.2!
Me.Label145.HyperLink = Nothing
Me.Label145.Left = 5.485435!
Me.Label145.Name = "Label145"
Me.Label145.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label145.Text = "到着地"
Me.Label145.Top = 15.69685!
Me.Label145.Width = 0.6874015!
'
'Label146
'
Me.Label146.Height = 0.2!
Me.Label146.HyperLink = Nothing
Me.Label146.Left = 3.763782!
Me.Label146.Name = "Label146"
Me.Label146.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label146.Text = "出発地"
Me.Label146.Top = 15.69685!
Me.Label146.Width = 0.7436993!
'
'Label147
'
Me.Label147.Height = 0.2!
Me.Label147.HyperLink = Nothing
Me.Label147.Left = 1.892125!
Me.Label147.Name = "Label147"
Me.Label147.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label147.Text = "座席希望"
Me.Label147.Top = 16.09685!
Me.Label147.Width = 0.6874028!
'
'Label148
'
Me.Label148.Height = 0.2!
Me.Label148.HyperLink = Nothing
Me.Label148.Left = 0.229133!
Me.Label148.Name = "Label148"
Me.Label148.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label148.Text = "座席区分"
Me.Label148.Top = 16.09685!
Me.Label148.Width = 0.6874025!
'
'Label149
'
Me.Label149.Height = 0.2!
Me.Label149.HyperLink = Nothing
Me.Label149.Left = 0.229133!
Me.Label149.Name = "Label149"
Me.Label149.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label149.Text = "列車・便名"
Me.Label149.Top = 15.49685!
Me.Label149.Width = 0.6874025!
'
'Label150
'
Me.Label150.Height = 0.2!
Me.Label150.HyperLink = Nothing
Me.Label150.Left = 1.902361!
Me.Label150.Name = "Label150"
Me.Label150.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label150.Text = "到着時間"
Me.Label150.Top = 15.89685!
Me.Label150.Width = 0.6771665!
'
'Label151
'
Me.Label151.Height = 0.2!
Me.Label151.HyperLink = Nothing
Me.Label151.Left = 0.229133!
Me.Label151.Name = "Label151"
Me.Label151.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label151.Text = "出発時間"
Me.Label151.Top = 15.89685!
Me.Label151.Width = 0.6874025!
'
'Label152
'
Me.Label152.Height = 0.2!
Me.Label152.HyperLink = Nothing
Me.Label152.Left = 1.892125!
Me.Label152.Name = "Label152"
Me.Label152.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label152.Text = "到着地"
Me.Label152.Top = 15.69685!
Me.Label152.Width = 0.6874028!
'
'Label153
'
Me.Label153.Height = 0.2!
Me.Label153.HyperLink = Nothing
Me.Label153.Left = 0.229133!
Me.Label153.Name = "Label153"
Me.Label153.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label153.Text = "出発地"
Me.Label153.Top = 15.69685!
Me.Label153.Width = 0.6874025!
'
'OURO4
'
Me.OURO4.Height = 1.2!
Me.OURO4.HyperLink = Nothing
Me.OURO4.Left = 0!
Me.OURO4.Name = "OURO4"
Me.OURO4.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: b"& _ 
    "old; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-v"& _ 
    "ertical: true"
Me.OURO4.Text = ""
Me.OURO4.Top = 15.09685!
Me.OURO4.Width = 0.2291338!
'
'Line75
'
Me.Line75.Height = 2.2!
Me.Line75.Left = 0.2291343!
Me.Line75.LineWeight = 1!
Me.Line75.Name = "Line75"
Me.Line75.Top = 11.49685!
Me.Line75.Width = 8.940697E-08!
Me.Line75.X1 = 0.2291343!
Me.Line75.X2 = 0.2291344!
Me.Line75.Y1 = 11.49685!
Me.Line75.Y2 = 13.69685!
'
'Label161
'
Me.Label161.Height = 0.2!
Me.Label161.HyperLink = Nothing
Me.Label161.Left = 1.892126!
Me.Label161.Name = "Label161"
Me.Label161.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label161.Text = "座席希望"
Me.Label161.Top = 12.49685!
Me.Label161.Width = 0.6874014!
'
'Label164
'
Me.Label164.Height = 0.2!
Me.Label164.HyperLink = Nothing
Me.Label164.Left = 1.892126!
Me.Label164.Name = "Label164"
Me.Label164.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label164.Text = "到着時間"
Me.Label164.Top = 12.29685!
Me.Label164.Width = 0.6874014!
'
'Label166
'
Me.Label166.Height = 0.2!
Me.Label166.HyperLink = Nothing
Me.Label166.Left = 1.892126!
Me.Label166.Name = "Label166"
Me.Label166.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label166.Text = "到着地"
Me.Label166.Top = 12.09685!
Me.Label166.Width = 0.6874015!
'
'OURO1
'
Me.OURO1.Height = 1.200002!
Me.OURO1.HyperLink = Nothing
Me.OURO1.Left = 4.768372E-07!
Me.OURO1.Name = "OURO1"
Me.OURO1.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bo"& _ 
    "ld; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-ve"& _ 
    "rtical: true"
Me.OURO1.Text = ""
Me.OURO1.Top = 11.49685!
Me.OURO1.Width = 0.2291338!
'
'Label169
'
Me.Label169.Height = 0.2!
Me.Label169.HyperLink = Nothing
Me.Label169.Left = 1.902362!
Me.Label169.Name = "Label169"
Me.Label169.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label169.Text = "依頼内容"
Me.Label169.Top = 11.49685!
Me.Label169.Width = 0.6874014!
'
'Label170
'
Me.Label170.Height = 0.2!
Me.Label170.HyperLink = Nothing
Me.Label170.Left = 1.892126!
Me.Label170.Name = "Label170"
Me.Label170.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label170.Text = "交通機関"
Me.Label170.Top = 11.69685!
Me.Label170.Width = 0.6874016!
'
'Label176
'
Me.Label176.Height = 0.1999999!
Me.Label176.HyperLink = Nothing
Me.Label176.Left = 0.2291331!
Me.Label176.Name = "Label176"
Me.Label176.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label176.Text = "希望する"
Me.Label176.Top = 15.09685!
Me.Label176.Width = 0.6874024!
'
'Label177
'
Me.Label177.Height = 0.2!
Me.Label177.HyperLink = Nothing
Me.Label177.Left = 1.892126!
Me.Label177.Name = "Label177"
Me.Label177.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label177.Text = "依頼内容"
Me.Label177.Top = 15.09685!
Me.Label177.Width = 0.6874018!
'
'Label178
'
Me.Label178.Height = 0.2!
Me.Label178.HyperLink = Nothing
Me.Label178.Left = 1.892125!
Me.Label178.Name = "Label178"
Me.Label178.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label178.Text = "交通機関"
Me.Label178.Top = 15.29685!
Me.Label178.Width = 0.6874028!
'
'Label179
'
Me.Label179.Height = 0.2!
Me.Label179.HyperLink = Nothing
Me.Label179.Left = 0.229133!
Me.Label179.Name = "Label179"
Me.Label179.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label179.Text = "利用日"
Me.Label179.Top = 15.29685!
Me.Label179.Width = 0.6874025!
'
'Label181
'
Me.Label181.Height = 0.2!
Me.Label181.HyperLink = Nothing
Me.Label181.Left = 5.485434!
Me.Label181.Name = "Label181"
Me.Label181.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label181.Text = "依頼内容"
Me.Label181.Top = 15.09685!
Me.Label181.Width = 0.6874008!
'
'Label182
'
Me.Label182.Height = 0.2!
Me.Label182.HyperLink = Nothing
Me.Label182.Left = 5.485435!
Me.Label182.Name = "Label182"
Me.Label182.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label182.Text = "交通機関"
Me.Label182.Top = 15.29685!
Me.Label182.Width = 0.6874015!
'
'Label183
'
Me.Label183.Height = 0.2!
Me.Label183.HyperLink = Nothing
Me.Label183.Left = 3.763782!
Me.Label183.Name = "Label183"
Me.Label183.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label183.Text = "利用日"
Me.Label183.Top = 15.29685!
Me.Label183.Width = 0.7436993!
'
'REQ_O_IRAINAIYOU_1
'
Me.REQ_O_IRAINAIYOU_1.DataField = "REQ_O_IRAINAIYOU_1"
Me.REQ_O_IRAINAIYOU_1.Height = 0.1999998!
Me.REQ_O_IRAINAIYOU_1.Left = 2.579528!
Me.REQ_O_IRAINAIYOU_1.Name = "REQ_O_IRAINAIYOU_1"
Me.REQ_O_IRAINAIYOU_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_IRAINAIYOU_1.Text = Nothing
Me.REQ_O_IRAINAIYOU_1.Top = 11.49685!
Me.REQ_O_IRAINAIYOU_1.Width = 0.9791338!
'
'REQ_O_KOTSUKIKAN_1
'
Me.REQ_O_KOTSUKIKAN_1.DataField = "REQ_O_KOTSUKIKAN_1"
Me.REQ_O_KOTSUKIKAN_1.Height = 0.1999998!
Me.REQ_O_KOTSUKIKAN_1.Left = 2.579528!
Me.REQ_O_KOTSUKIKAN_1.Name = "REQ_O_KOTSUKIKAN_1"
Me.REQ_O_KOTSUKIKAN_1.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_KOTSUKIKAN_1.Text = Nothing
Me.REQ_O_KOTSUKIKAN_1.Top = 11.69685!
Me.REQ_O_KOTSUKIKAN_1.Width = 0.9688978!
'
'REQ_O_TEHAI_4
'
Me.REQ_O_TEHAI_4.DataField = "REQ_O_TEHAI_4"
Me.REQ_O_TEHAI_4.Height = 0.2!
Me.REQ_O_TEHAI_4.Left = 0.9165355!
Me.REQ_O_TEHAI_4.Name = "REQ_O_TEHAI_4"
Me.REQ_O_TEHAI_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TEHAI_4.Text = Nothing
Me.REQ_O_TEHAI_4.Top = 15.09685!
Me.REQ_O_TEHAI_4.Width = 0.9755906!
'
'REQ_O_IRAINAIYOU_4
'
Me.REQ_O_IRAINAIYOU_4.DataField = "REQ_O_IRAINAIYOU_4"
Me.REQ_O_IRAINAIYOU_4.Height = 0.2!
Me.REQ_O_IRAINAIYOU_4.Left = 2.579528!
Me.REQ_O_IRAINAIYOU_4.Name = "REQ_O_IRAINAIYOU_4"
Me.REQ_O_IRAINAIYOU_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_IRAINAIYOU_4.Text = Nothing
Me.REQ_O_IRAINAIYOU_4.Top = 15.09685!
Me.REQ_O_IRAINAIYOU_4.Width = 0.9791338!
'
'REQ_O_KOTSUKIKAN_4
'
Me.REQ_O_KOTSUKIKAN_4.DataField = "REQ_O_KOTSUKIKAN_4"
Me.REQ_O_KOTSUKIKAN_4.Height = 0.2!
Me.REQ_O_KOTSUKIKAN_4.Left = 2.579528!
Me.REQ_O_KOTSUKIKAN_4.Name = "REQ_O_KOTSUKIKAN_4"
Me.REQ_O_KOTSUKIKAN_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_KOTSUKIKAN_4.Text = Nothing
Me.REQ_O_KOTSUKIKAN_4.Top = 15.29685!
Me.REQ_O_KOTSUKIKAN_4.Width = 0.9791338!
'
'REQ_O_DATE_4
'
Me.REQ_O_DATE_4.DataField = "REQ_O_DATE_4"
Me.REQ_O_DATE_4.Height = 0.2!
Me.REQ_O_DATE_4.Left = 0.9165355!
Me.REQ_O_DATE_4.Name = "REQ_O_DATE_4"
Me.REQ_O_DATE_4.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_DATE_4.Text = Nothing
Me.REQ_O_DATE_4.Top = 15.29685!
Me.REQ_O_DATE_4.Width = 0.9755906!
'
'Line76
'
Me.Line76.Height = 0!
Me.Line76.Left = 9.536743E-07!
Me.Line76.LineWeight = 1!
Me.Line76.Name = "Line76"
Me.Line76.Top = 11.49685!
Me.Line76.Width = 7.165354!
Me.Line76.X1 = 9.536743E-07!
Me.Line76.X2 = 7.165355!
Me.Line76.Y1 = 11.49685!
Me.Line76.Y2 = 11.49685!
'
'REQ_F_SEAT_KIBOU3
'
Me.REQ_F_SEAT_KIBOU3.DataField = "REQ_F_SEAT_KIBOU3"
Me.REQ_F_SEAT_KIBOU3.Height = 0.2!
Me.REQ_F_SEAT_KIBOU3.Left = 6.172835!
Me.REQ_F_SEAT_KIBOU3.Name = "REQ_F_SEAT_KIBOU3"
Me.REQ_F_SEAT_KIBOU3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_SEAT_KIBOU3.Text = Nothing
Me.REQ_F_SEAT_KIBOU3.Top = 14.89685!
Me.REQ_F_SEAT_KIBOU3.Width = 0.979134!
'
'REQ_F_BIN_3
'
Me.REQ_F_BIN_3.DataField = "REQ_F_BIN_3"
Me.REQ_F_BIN_3.Height = 0.2!
Me.REQ_F_BIN_3.Left = 4.507481!
Me.REQ_F_BIN_3.Name = "REQ_F_BIN_3"
Me.REQ_F_BIN_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_BIN_3.Text = Nothing
Me.REQ_F_BIN_3.Top = 14.29685!
Me.REQ_F_BIN_3.Width = 2.644488!
'
'REQ_F_DATE_3
'
Me.REQ_F_DATE_3.DataField = "REQ_F_DATE_3"
Me.REQ_F_DATE_3.Height = 0.2!
Me.REQ_F_DATE_3.Left = 4.507481!
Me.REQ_F_DATE_3.Name = "REQ_F_DATE_3"
Me.REQ_F_DATE_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_DATE_3.Text = Nothing
Me.REQ_F_DATE_3.Top = 14.09685!
Me.REQ_F_DATE_3.Width = 0.9779529!
'
'REQ_F_KOTSUKIKAN_3
'
Me.REQ_F_KOTSUKIKAN_3.DataField = "REQ_F_KOTSUKIKAN_3"
Me.REQ_F_KOTSUKIKAN_3.Height = 0.2!
Me.REQ_F_KOTSUKIKAN_3.Left = 6.172835!
Me.REQ_F_KOTSUKIKAN_3.Name = "REQ_F_KOTSUKIKAN_3"
Me.REQ_F_KOTSUKIKAN_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_KOTSUKIKAN_3.Text = Nothing
Me.REQ_F_KOTSUKIKAN_3.Top = 14.09685!
Me.REQ_F_KOTSUKIKAN_3.Width = 0.979134!
'
'REQ_F_IRAINAIYOU_3
'
Me.REQ_F_IRAINAIYOU_3.DataField = "REQ_F_IRAINAIYOU_3"
Me.REQ_F_IRAINAIYOU_3.Height = 0.2!
Me.REQ_F_IRAINAIYOU_3.Left = 6.172835!
Me.REQ_F_IRAINAIYOU_3.Name = "REQ_F_IRAINAIYOU_3"
Me.REQ_F_IRAINAIYOU_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_IRAINAIYOU_3.Text = Nothing
Me.REQ_F_IRAINAIYOU_3.Top = 13.89685!
Me.REQ_F_IRAINAIYOU_3.Width = 0.979134!
'
'REQ_O_SEAT_KIBOU3
'
Me.REQ_O_SEAT_KIBOU3.DataField = "REQ_O_SEAT_KIBOU3"
Me.REQ_O_SEAT_KIBOU3.Height = 0.2!
Me.REQ_O_SEAT_KIBOU3.Left = 2.579528!
Me.REQ_O_SEAT_KIBOU3.Name = "REQ_O_SEAT_KIBOU3"
Me.REQ_O_SEAT_KIBOU3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_KIBOU3.Text = Nothing
Me.REQ_O_SEAT_KIBOU3.Top = 14.89685!
Me.REQ_O_SEAT_KIBOU3.Width = 0.9791338!
'
'REQ_O_SEAT_3
'
Me.REQ_O_SEAT_3.DataField = "REQ_O_SEAT_3"
Me.REQ_O_SEAT_3.Height = 0.2!
Me.REQ_O_SEAT_3.Left = 0.9165355!
Me.REQ_O_SEAT_3.Name = "REQ_O_SEAT_3"
Me.REQ_O_SEAT_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_SEAT_3.Text = Nothing
Me.REQ_O_SEAT_3.Top = 14.89685!
Me.REQ_O_SEAT_3.Width = 0.9755906!
'
'REQ_O_BIN_3
'
Me.REQ_O_BIN_3.DataField = "REQ_O_BIN_3"
Me.REQ_O_BIN_3.Height = 0.2!
Me.REQ_O_BIN_3.Left = 0.9165355!
Me.REQ_O_BIN_3.Name = "REQ_O_BIN_3"
Me.REQ_O_BIN_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_BIN_3.Text = Nothing
Me.REQ_O_BIN_3.Top = 14.29685!
Me.REQ_O_BIN_3.Width = 2.642126!
'
'REQ_O_DATE_3
'
Me.REQ_O_DATE_3.DataField = "REQ_O_DATE_3"
Me.REQ_O_DATE_3.Height = 0.2!
Me.REQ_O_DATE_3.Left = 0.9165355!
Me.REQ_O_DATE_3.Name = "REQ_O_DATE_3"
Me.REQ_O_DATE_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_DATE_3.Text = Nothing
Me.REQ_O_DATE_3.Top = 14.09685!
Me.REQ_O_DATE_3.Width = 0.9755906!
'
'REQ_O_KOTSUKIKAN_3
'
Me.REQ_O_KOTSUKIKAN_3.DataField = "REQ_O_KOTSUKIKAN_3"
Me.REQ_O_KOTSUKIKAN_3.Height = 0.2!
Me.REQ_O_KOTSUKIKAN_3.Left = 2.579528!
Me.REQ_O_KOTSUKIKAN_3.Name = "REQ_O_KOTSUKIKAN_3"
Me.REQ_O_KOTSUKIKAN_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_KOTSUKIKAN_3.Text = Nothing
Me.REQ_O_KOTSUKIKAN_3.Top = 14.09685!
Me.REQ_O_KOTSUKIKAN_3.Width = 0.9791338!
'
'REQ_O_IRAINAIYOU_3
'
Me.REQ_O_IRAINAIYOU_3.DataField = "REQ_O_IRAINAIYOU_3"
Me.REQ_O_IRAINAIYOU_3.Height = 0.2!
Me.REQ_O_IRAINAIYOU_3.Left = 2.579528!
Me.REQ_O_IRAINAIYOU_3.Name = "REQ_O_IRAINAIYOU_3"
Me.REQ_O_IRAINAIYOU_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_IRAINAIYOU_3.Text = Nothing
Me.REQ_O_IRAINAIYOU_3.Top = 13.89685!
Me.REQ_O_IRAINAIYOU_3.Width = 0.9791338!
'
'REQ_F_TEHAI_3
'
Me.REQ_F_TEHAI_3.DataField = "REQ_F_TEHAI_3"
Me.REQ_F_TEHAI_3.Height = 0.2!
Me.REQ_F_TEHAI_3.Left = 4.507481!
Me.REQ_F_TEHAI_3.Name = "REQ_F_TEHAI_3"
Me.REQ_F_TEHAI_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_F_TEHAI_3.Text = Nothing
Me.REQ_F_TEHAI_3.Top = 13.89685!
Me.REQ_F_TEHAI_3.Width = 0.9779529!
'
'REQ_O_TEHAI_3
'
Me.REQ_O_TEHAI_3.DataField = "REQ_O_TEHAI_3"
Me.REQ_O_TEHAI_3.Height = 0.2!
Me.REQ_O_TEHAI_3.Left = 0.9165355!
Me.REQ_O_TEHAI_3.Name = "REQ_O_TEHAI_3"
Me.REQ_O_TEHAI_3.Style = "text-align: left; vertical-align: middle"
Me.REQ_O_TEHAI_3.Text = Nothing
Me.REQ_O_TEHAI_3.Top = 13.89685!
Me.REQ_O_TEHAI_3.Width = 0.9755906!
'
'Label192
'
Me.Label192.Height = 0.2!
Me.Label192.HyperLink = Nothing
Me.Label192.Left = 5.485433!
Me.Label192.Name = "Label192"
Me.Label192.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label192.Text = "交通機関"
Me.Label192.Top = 14.09685!
Me.Label192.Width = 0.6874018!
'
'Label193
'
Me.Label193.Height = 0.2!
Me.Label193.HyperLink = Nothing
Me.Label193.Left = 5.485433!
Me.Label193.Name = "Label193"
Me.Label193.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label193.Text = "依頼内容"
Me.Label193.Top = 13.89685!
Me.Label193.Width = 0.6874018!
'
'Line78
'
Me.Line78.Height = 1.599998!
Me.Line78.Left = 0.2291339!
Me.Line78.LineWeight = 1!
Me.Line78.Name = "Line78"
Me.Line78.Top = 15.89685!
Me.Line78.Width = 4.023314E-07!
Me.Line78.X1 = 0.2291343!
Me.Line78.X2 = 0.2291339!
Me.Line78.Y1 = 15.89685!
Me.Line78.Y2 = 17.49685!
'
'Label196
'
Me.Label196.Height = 0.2!
Me.Label196.HyperLink = Nothing
Me.Label196.Left = 0.229134!
Me.Label196.Name = "Label196"
Me.Label196.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label196.Text = "座席区分"
Me.Label196.Top = 14.89685!
Me.Label196.Width = 0.6874014!
'
'Label197
'
Me.Label197.Height = 0.2!
Me.Label197.HyperLink = Nothing
Me.Label197.Left = 0.229134!
Me.Label197.Name = "Label197"
Me.Label197.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label197.Text = "列車・便名"
Me.Label197.Top = 14.29685!
Me.Label197.Width = 0.6874015!
'
'Label202
'
Me.Label202.Height = 0.2!
Me.Label202.HyperLink = Nothing
Me.Label202.Left = 0.229134!
Me.Label202.Name = "Label202"
Me.Label202.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label202.Text = "利用日"
Me.Label202.Top = 14.09685!
Me.Label202.Width = 0.6874015!
'
'Label203
'
Me.Label203.Height = 0.2!
Me.Label203.HyperLink = Nothing
Me.Label203.Left = 1.892126!
Me.Label203.Name = "Label203"
Me.Label203.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label203.Text = "交通機関"
Me.Label203.Top = 14.09685!
Me.Label203.Width = 0.6874015!
'
'Label204
'
Me.Label204.Height = 0.2!
Me.Label204.HyperLink = Nothing
Me.Label204.Left = 1.892126!
Me.Label204.Name = "Label204"
Me.Label204.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label204.Text = "依頼内容"
Me.Label204.Top = 13.89685!
Me.Label204.Width = 0.6874014!
'
'Label205
'
Me.Label205.Height = 0.1999999!
Me.Label205.HyperLink = Nothing
Me.Label205.Left = 0.229134!
Me.Label205.Name = "Label205"
Me.Label205.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label205.Text = "希望する"
Me.Label205.Top = 13.89685!
Me.Label205.Width = 0.6874014!
'
'OURO3
'
Me.OURO3.Height = 1.2!
Me.OURO3.HyperLink = Nothing
Me.OURO3.Left = 0!
Me.OURO3.Name = "OURO3"
Me.OURO3.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bo"& _ 
    "ld; text-align: center; vertical-align: middle; white-space: nowrap; ddo-font-ve"& _ 
    "rtical: true"
Me.OURO3.Text = ""
Me.OURO3.Top = 13.89685!
Me.OURO3.Width = 0.2291338!
'
'Line80
'
Me.Line80.Height = 6.000002!
Me.Line80.Left = 0.2291335!
Me.Line80.LineWeight = 1!
Me.Line80.Name = "Line80"
Me.Line80.Top = 11.49685!
Me.Line80.Width = 4.023314E-07!
Me.Line80.X1 = 0.2291339!
Me.Line80.X2 = 0.2291335!
Me.Line80.Y1 = 11.49685!
Me.Line80.Y2 = 17.49685!
'
'Line87
'
Me.Line87.Height = 0!
Me.Line87.Left = 0.2291344!
Me.Line87.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line87.LineWeight = 1!
Me.Line87.Name = "Line87"
Me.Line87.Top = 11.69685!
Me.Line87.Width = 3.329528!
Me.Line87.X1 = 0.2291344!
Me.Line87.X2 = 3.558662!
Me.Line87.Y1 = 11.69685!
Me.Line87.Y2 = 11.69685!
'
'Line88
'
Me.Line88.Height = 0!
Me.Line88.Left = 0.2291344!
Me.Line88.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line88.LineWeight = 1!
Me.Line88.Name = "Line88"
Me.Line88.Top = 11.89685!
Me.Line88.Width = 3.329528!
Me.Line88.X1 = 0.2291344!
Me.Line88.X2 = 3.558662!
Me.Line88.Y1 = 11.89685!
Me.Line88.Y2 = 11.89685!
'
'Line89
'
Me.Line89.Height = 0!
Me.Line89.Left = 0.2291344!
Me.Line89.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line89.LineWeight = 1!
Me.Line89.Name = "Line89"
Me.Line89.Top = 12.09685!
Me.Line89.Width = 3.329528!
Me.Line89.X1 = 0.2291344!
Me.Line89.X2 = 3.558662!
Me.Line89.Y1 = 12.09685!
Me.Line89.Y2 = 12.09685!
'
'Line90
'
Me.Line90.Height = 0!
Me.Line90.Left = 0.2291344!
Me.Line90.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line90.LineWeight = 1!
Me.Line90.Name = "Line90"
Me.Line90.Top = 12.29685!
Me.Line90.Width = 3.329528!
Me.Line90.X1 = 0.2291344!
Me.Line90.X2 = 3.558662!
Me.Line90.Y1 = 12.29685!
Me.Line90.Y2 = 12.29685!
'
'Line91
'
Me.Line91.Height = 0!
Me.Line91.Left = 0.2291344!
Me.Line91.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line91.LineWeight = 1!
Me.Line91.Name = "Line91"
Me.Line91.Top = 12.49685!
Me.Line91.Width = 3.329528!
Me.Line91.X1 = 0.2291344!
Me.Line91.X2 = 3.558662!
Me.Line91.Y1 = 12.49685!
Me.Line91.Y2 = 12.49685!
'
'Line92
'
Me.Line92.Height = 0!
Me.Line92.Left = 0!
Me.Line92.LineWeight = 1!
Me.Line92.Name = "Line92"
Me.Line92.Top = 12.69685!
Me.Line92.Width = 7.151969!
Me.Line92.X1 = 0!
Me.Line92.X2 = 7.151969!
Me.Line92.Y1 = 12.69685!
Me.Line92.Y2 = 12.69685!
'
'Line93
'
Me.Line93.Height = 0!
Me.Line93.Left = 0.2291344!
Me.Line93.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line93.LineWeight = 1!
Me.Line93.Name = "Line93"
Me.Line93.Top = 12.89685!
Me.Line93.Width = 3.329528!
Me.Line93.X1 = 0.2291344!
Me.Line93.X2 = 3.558662!
Me.Line93.Y1 = 12.89685!
Me.Line93.Y2 = 12.89685!
'
'Line94
'
Me.Line94.Height = 0!
Me.Line94.Left = 0.2291344!
Me.Line94.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line94.LineWeight = 1!
Me.Line94.Name = "Line94"
Me.Line94.Top = 13.09685!
Me.Line94.Width = 3.329528!
Me.Line94.X1 = 0.2291344!
Me.Line94.X2 = 3.558662!
Me.Line94.Y1 = 13.09685!
Me.Line94.Y2 = 13.09685!
'
'Line95
'
Me.Line95.Height = 0!
Me.Line95.Left = 0.2291344!
Me.Line95.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line95.LineWeight = 1!
Me.Line95.Name = "Line95"
Me.Line95.Top = 13.29685!
Me.Line95.Width = 3.329528!
Me.Line95.X1 = 0.2291344!
Me.Line95.X2 = 3.558662!
Me.Line95.Y1 = 13.29685!
Me.Line95.Y2 = 13.29685!
'
'Line96
'
Me.Line96.Height = 0!
Me.Line96.Left = 0.2291338!
Me.Line96.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line96.LineWeight = 1!
Me.Line96.Name = "Line96"
Me.Line96.Top = 13.49685!
Me.Line96.Width = 3.329527!
Me.Line96.X1 = 0.2291338!
Me.Line96.X2 = 3.558661!
Me.Line96.Y1 = 13.49685!
Me.Line96.Y2 = 13.49685!
'
'Line101
'
Me.Line101.Height = 0!
Me.Line101.Left = 0!
Me.Line101.LineWeight = 1!
Me.Line101.Name = "Line101"
Me.Line101.Top = 17.49685!
Me.Line101.Width = 7.151969!
Me.Line101.X1 = 0!
Me.Line101.X2 = 7.151969!
Me.Line101.Y1 = 17.49685!
Me.Line101.Y2 = 17.49685!
'
'Line118
'
Me.Line118.Height = 0!
Me.Line118.Left = 3.76378!
Me.Line118.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line118.LineWeight = 1!
Me.Line118.Name = "Line118"
Me.Line118.Top = 12.89685!
Me.Line118.Width = 3.388189!
Me.Line118.X1 = 3.76378!
Me.Line118.X2 = 7.151969!
Me.Line118.Y1 = 12.89685!
Me.Line118.Y2 = 12.89685!
'
'Line119
'
Me.Line119.Height = 0!
Me.Line119.Left = 3.76378!
Me.Line119.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line119.LineWeight = 1!
Me.Line119.Name = "Line119"
Me.Line119.Top = 13.09685!
Me.Line119.Width = 3.388189!
Me.Line119.X1 = 3.76378!
Me.Line119.X2 = 7.151969!
Me.Line119.Y1 = 13.09685!
Me.Line119.Y2 = 13.09685!
'
'Line120
'
Me.Line120.Height = 0!
Me.Line120.Left = 3.76378!
Me.Line120.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line120.LineWeight = 1!
Me.Line120.Name = "Line120"
Me.Line120.Top = 13.29685!
Me.Line120.Width = 3.388189!
Me.Line120.X1 = 3.76378!
Me.Line120.X2 = 7.151969!
Me.Line120.Y1 = 13.29685!
Me.Line120.Y2 = 13.29685!
'
'Line121
'
Me.Line121.Height = 0!
Me.Line121.Left = 3.76378!
Me.Line121.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line121.LineWeight = 1!
Me.Line121.Name = "Line121"
Me.Line121.Top = 13.49685!
Me.Line121.Width = 3.397638!
Me.Line121.X1 = 3.76378!
Me.Line121.X2 = 7.161418!
Me.Line121.Y1 = 13.49685!
Me.Line121.Y2 = 13.49685!
'
'Line152
'
Me.Line152.Height = 0!
Me.Line152.Left = 0!
Me.Line152.LineWeight = 1!
Me.Line152.Name = "Line152"
Me.Line152.Top = 13.89685!
Me.Line152.Width = 7.151969!
Me.Line152.X1 = 0!
Me.Line152.X2 = 7.151969!
Me.Line152.Y1 = 13.89685!
Me.Line152.Y2 = 13.89685!
'
'Line173
'
Me.Line173.Height = 0!
Me.Line173.Left = 5.589764!
Me.Line173.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line173.LineWeight = 1!
Me.Line173.Name = "Line173"
Me.Line173.Top = 16.29685!
Me.Line173.Width = 1.562206!
Me.Line173.X1 = 5.589764!
Me.Line173.X2 = 7.15197!
Me.Line173.Y1 = 16.29685!
Me.Line173.Y2 = 16.29685!
'
'Line52
'
Me.Line52.Height = 8.62874!
Me.Line52.Left = 0!
Me.Line52.LineWeight = 1!
Me.Line52.Name = "Line52"
Me.Line52.Top = 0.8740158!
Me.Line52.Width = 5.684342E-14!
Me.Line52.X1 = 5.684342E-14!
Me.Line52.X2 = 0!
Me.Line52.Y1 = 0.8740158!
Me.Line52.Y2 = 9.502756!
'
'DR_SHISETSU_ADDRESS2
'
Me.DR_SHISETSU_ADDRESS2.DataField = "DR_SHISETSU_ADDRESS"
Me.DR_SHISETSU_ADDRESS2.Height = 0.1999999!
Me.DR_SHISETSU_ADDRESS2.Left = 4.507481!
Me.DR_SHISETSU_ADDRESS2.Name = "DR_SHISETSU_ADDRESS2"
Me.DR_SHISETSU_ADDRESS2.Style = "vertical-align: middle"
Me.DR_SHISETSU_ADDRESS2.Text = Nothing
Me.DR_SHISETSU_ADDRESS2.Top = 11.09685!
Me.DR_SHISETSU_ADDRESS2.Width = 2.644488!
'
'Label207
'
Me.Label207.Height = 0.2!
Me.Label207.HyperLink = Nothing
Me.Label207.Left = 4.768372E-07!
Me.Label207.Name = "Label207"
Me.Label207.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label207.Text = "会合番号"
Me.Label207.Top = 10.49685!
Me.Label207.Width = 1.323622!
'
'Label209
'
Me.Label209.Height = 0.2!
Me.Label209.HyperLink = Nothing
Me.Label209.Left = 4.828347!
Me.Label209.Name = "Label209"
Me.Label209.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label209.Text = "Timestamp(BYL)"
Me.Label209.Top = 10.49685!
Me.Label209.Width = 0.9590556!
'
'Label210
'
Me.Label210.Height = 0.2!
Me.Label210.HyperLink = Nothing
Me.Label210.Left = 0!
Me.Label210.Name = "Label210"
Me.Label210.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label210.Text = "MTP ID(参加者ID)"
Me.Label210.Top = 10.69685!
Me.Label210.Width = 1.323622!
'
'Label212
'
Me.Label212.Height = 0.2!
Me.Label212.HyperLink = Nothing
Me.Label212.Left = 0!
Me.Label212.Name = "Label212"
Me.Label212.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label212.Text = "DR氏名"
Me.Label212.Top = 10.89685!
Me.Label212.Width = 1.323622!
'
'Label213
'
Me.Label213.Height = 0.2!
Me.Label213.HyperLink = Nothing
Me.Label213.Left = 0!
Me.Label213.Name = "Label213"
Me.Label213.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label213.Text = "DR氏名(半角ｶﾀｶﾅ)"
Me.Label213.Top = 11.09685!
Me.Label213.Width = 1.323622!
'
'Label217
'
Me.Label217.Height = 0.2!
Me.Label217.HyperLink = Nothing
Me.Label217.Left = 0!
Me.Label217.Name = "Label217"
Me.Label217.Style = "background-color: darkgray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label217.Text = "航空搭乗者年齢(年齢)"
Me.Label217.Top = 11.29685!
Me.Label217.Width = 1.323622!
'
'KOUENKAI_NO2
'
Me.KOUENKAI_NO2.DataField = "KOUENKAI_NO"
Me.KOUENKAI_NO2.Height = 0.2!
Me.KOUENKAI_NO2.Left = 1.323622!
Me.KOUENKAI_NO2.Name = "KOUENKAI_NO2"
Me.KOUENKAI_NO2.Style = "vertical-align: middle"
Me.KOUENKAI_NO2.Text = Nothing
Me.KOUENKAI_NO2.Top = 10.49685!
Me.KOUENKAI_NO2.Width = 2.23504!
'
'REQ_STATUS_TEHAI2
'
Me.REQ_STATUS_TEHAI2.DataField = "REQ_STATUS_TEHAI"
Me.REQ_STATUS_TEHAI2.Height = 0.2!
Me.REQ_STATUS_TEHAI2.Left = 4.507481!
Me.REQ_STATUS_TEHAI2.Name = "REQ_STATUS_TEHAI2"
Me.REQ_STATUS_TEHAI2.Style = "text-align: center; vertical-align: middle"
Me.REQ_STATUS_TEHAI2.Text = Nothing
Me.REQ_STATUS_TEHAI2.Top = 10.49685!
Me.REQ_STATUS_TEHAI2.Width = 0.3208661!
'
'TIME_STAMP_BYL2
'
Me.TIME_STAMP_BYL2.DataField = "TIME_STAMP_BYL"
Me.TIME_STAMP_BYL2.Height = 0.2!
Me.TIME_STAMP_BYL2.Left = 5.787402!
Me.TIME_STAMP_BYL2.Name = "TIME_STAMP_BYL2"
Me.TIME_STAMP_BYL2.Style = "vertical-align: middle"
Me.TIME_STAMP_BYL2.Text = Nothing
Me.TIME_STAMP_BYL2.Top = 10.49685!
Me.TIME_STAMP_BYL2.Width = 1.364567!
'
'SANKASHA_ID2
'
Me.SANKASHA_ID2.DataField = "SANKASHA_ID"
Me.SANKASHA_ID2.Height = 0.2!
Me.SANKASHA_ID2.Left = 1.323622!
Me.SANKASHA_ID2.Name = "SANKASHA_ID2"
Me.SANKASHA_ID2.Style = "vertical-align: middle"
Me.SANKASHA_ID2.Text = Nothing
Me.SANKASHA_ID2.Top = 10.69685!
Me.SANKASHA_ID2.Width = 2.23504!
'
'DR_CD2
'
Me.DR_CD2.DataField = "DR_CD"
Me.DR_CD2.Height = 0.2!
Me.DR_CD2.Left = 4.507481!
Me.DR_CD2.Name = "DR_CD2"
Me.DR_CD2.Style = "vertical-align: middle"
Me.DR_CD2.Text = Nothing
Me.DR_CD2.Top = 10.69685!
Me.DR_CD2.Width = 2.644488!
'
'DR_NAME2
'
Me.DR_NAME2.DataField = "DR_NAME"
Me.DR_NAME2.Height = 0.2!
Me.DR_NAME2.Left = 1.323622!
Me.DR_NAME2.Name = "DR_NAME2"
Me.DR_NAME2.Style = "vertical-align: middle"
Me.DR_NAME2.Text = Nothing
Me.DR_NAME2.Top = 10.89685!
Me.DR_NAME2.Width = 2.23504!
'
'DR_KANA2
'
Me.DR_KANA2.DataField = "DR_KANA"
Me.DR_KANA2.Height = 0.2!
Me.DR_KANA2.Left = 1.323622!
Me.DR_KANA2.Name = "DR_KANA2"
Me.DR_KANA2.Style = "vertical-align: middle"
Me.DR_KANA2.Text = Nothing
Me.DR_KANA2.Top = 11.09685!
Me.DR_KANA2.Width = 2.23504!
'
'DR_AGE2
'
Me.DR_AGE2.DataField = "DR_AGE"
Me.DR_AGE2.Height = 0.2!
Me.DR_AGE2.Left = 1.323622!
Me.DR_AGE2.Name = "DR_AGE2"
Me.DR_AGE2.Style = "vertical-align: middle"
Me.DR_AGE2.Text = Nothing
Me.DR_AGE2.Top = 11.29685!
Me.DR_AGE2.Width = 2.23504!
'
'Line67
'
Me.Line67.Height = 0!
Me.Line67.Left = 4.768372E-07!
Me.Line67.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line67.LineWeight = 1!
Me.Line67.Name = "Line67"
Me.Line67.Top = 10.69685!
Me.Line67.Width = 7.165353!
Me.Line67.X1 = 4.768372E-07!
Me.Line67.X2 = 7.165354!
Me.Line67.Y1 = 10.69685!
Me.Line67.Y2 = 10.69685!
'
'Line192
'
Me.Line192.Height = 0!
Me.Line192.Left = 4.768372E-07!
Me.Line192.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line192.LineWeight = 1!
Me.Line192.Name = "Line192"
Me.Line192.Top = 10.89685!
Me.Line192.Width = 7.165353!
Me.Line192.X1 = 4.768372E-07!
Me.Line192.X2 = 7.165354!
Me.Line192.Y1 = 10.89685!
Me.Line192.Y2 = 10.89685!
'
'Line193
'
Me.Line193.Height = 0!
Me.Line193.Left = 4.768372E-07!
Me.Line193.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line193.LineWeight = 1!
Me.Line193.Name = "Line193"
Me.Line193.Top = 11.09685!
Me.Line193.Width = 7.165353!
Me.Line193.X1 = 4.768372E-07!
Me.Line193.X2 = 7.165354!
Me.Line193.Y1 = 11.09685!
Me.Line193.Y2 = 11.09685!
'
'Line194
'
Me.Line194.Height = 0!
Me.Line194.Left = 5.684342E-14!
Me.Line194.LineWeight = 1!
Me.Line194.Name = "Line194"
Me.Line194.Top = 10.49685!
Me.Line194.Width = 7.165354!
Me.Line194.X1 = 5.684342E-14!
Me.Line194.X2 = 7.165354!
Me.Line194.Y1 = 10.49685!
Me.Line194.Y2 = 10.49685!
'
'DR_SEX2
'
Me.DR_SEX2.DataField = "DR_SEX"
Me.DR_SEX2.Height = 0.2!
Me.DR_SEX2.Left = 4.507481!
Me.DR_SEX2.Name = "DR_SEX2"
Me.DR_SEX2.Style = "vertical-align: middle"
Me.DR_SEX2.Text = Nothing
Me.DR_SEX2.Top = 11.29685!
Me.DR_SEX2.Width = 2.644488!
'
'Line195
'
Me.Line195.Height = 0.1999998!
Me.Line195.Left = 4.828347!
Me.Line195.LineWeight = 1!
Me.Line195.Name = "Line195"
Me.Line195.Top = 10.49685!
Me.Line195.Width = 0!
Me.Line195.X1 = 4.828347!
Me.Line195.X2 = 4.828347!
Me.Line195.Y1 = 10.49685!
Me.Line195.Y2 = 10.69685!
'
'Line196
'
Me.Line196.Height = 0.1999998!
Me.Line196.Left = 5.800788!
Me.Line196.LineWeight = 1!
Me.Line196.Name = "Line196"
Me.Line196.Top = 10.49685!
Me.Line196.Width = 0!
Me.Line196.X1 = 5.800788!
Me.Line196.X2 = 5.800788!
Me.Line196.Y1 = 10.49685!
Me.Line196.Y2 = 10.69685!
'
'Line199
'
Me.Line199.Height = 0!
Me.Line199.Left = 4.768372E-07!
Me.Line199.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line199.LineWeight = 1!
Me.Line199.Name = "Line199"
Me.Line199.Top = 11.29685!
Me.Line199.Width = 7.165353!
Me.Line199.X1 = 4.768372E-07!
Me.Line199.X2 = 7.165354!
Me.Line199.Y1 = 11.29685!
Me.Line199.Y2 = 11.29685!
'
'Line200
'
Me.Line200.Height = 0!
Me.Line200.Left = 4.768372E-07!
Me.Line200.LineWeight = 1!
Me.Line200.Name = "Line200"
Me.Line200.Top = 11.49685!
Me.Line200.Width = 7.165353!
Me.Line200.X1 = 4.768372E-07!
Me.Line200.X2 = 7.165354!
Me.Line200.Y1 = 11.49685!
Me.Line200.Y2 = 11.49685!
'
'Line79
'
Me.Line79.Height = 8.400002!
Me.Line79.Left = 0!
Me.Line79.LineWeight = 1!
Me.Line79.Name = "Line79"
Me.Line79.Top = 10.49685!
Me.Line79.Width = 0!
Me.Line79.X1 = 0!
Me.Line79.X2 = 0!
Me.Line79.Y1 = 10.49685!
Me.Line79.Y2 = 18.89685!
'
'Line68
'
Me.Line68.Height = 8.62874!
Me.Line68.Left = 7.151969!
Me.Line68.LineWeight = 1!
Me.Line68.Name = "Line68"
Me.Line68.Top = 0.8740158!
Me.Line68.Width = 0!
Me.Line68.X1 = 7.151969!
Me.Line68.X2 = 7.151969!
Me.Line68.Y1 = 0.8740158!
Me.Line68.Y2 = 9.502756!
'
'Line203
'
Me.Line203.Height = 1!
Me.Line203.Left = 1.323622!
Me.Line203.LineWeight = 1!
Me.Line203.Name = "Line203"
Me.Line203.Top = 10.49685!
Me.Line203.Width = 0!
Me.Line203.X1 = 1.323622!
Me.Line203.X2 = 1.323622!
Me.Line203.Y1 = 10.49685!
Me.Line203.Y2 = 11.49685!
'
'Line70
'
Me.Line70.Height = 0.3999996!
Me.Line70.Left = 1.892126!
Me.Line70.LineWeight = 1!
Me.Line70.Name = "Line70"
Me.Line70.Top = 11.49685!
Me.Line70.Width = 0!
Me.Line70.X1 = 1.892126!
Me.Line70.X2 = 1.892126!
Me.Line70.Y1 = 11.49685!
Me.Line70.Y2 = 11.89685!
'
'Line74
'
Me.Line74.Height = 1!
Me.Line74.Left = 1.892126!
Me.Line74.LineWeight = 1!
Me.Line74.Name = "Line74"
Me.Line74.Top = 12.09685!
Me.Line74.Width = 0!
Me.Line74.X1 = 1.892126!
Me.Line74.X2 = 1.892126!
Me.Line74.Y1 = 12.09685!
Me.Line74.Y2 = 13.09685!
'
'Line81
'
Me.Line81.Height = 0!
Me.Line81.Left = 0.2291338!
Me.Line81.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line81.LineWeight = 1!
Me.Line81.Name = "Line81"
Me.Line81.Top = 13.69685!
Me.Line81.Width = 3.329528!
Me.Line81.X1 = 0.2291338!
Me.Line81.X2 = 3.558662!
Me.Line81.Y1 = 13.69685!
Me.Line81.Y2 = 13.69685!
'
'Line82
'
Me.Line82.Height = 1!
Me.Line82.Left = 1.892126!
Me.Line82.LineWeight = 1!
Me.Line82.Name = "Line82"
Me.Line82.Top = 13.29685!
Me.Line82.Width = 0!
Me.Line82.X1 = 1.892126!
Me.Line82.X2 = 1.892126!
Me.Line82.Y1 = 13.29685!
Me.Line82.Y2 = 14.29685!
'
'Line97
'
Me.Line97.Height = 0!
Me.Line97.Left = 0.2291339!
Me.Line97.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line97.LineWeight = 1!
Me.Line97.Name = "Line97"
Me.Line97.Top = 14.09685!
Me.Line97.Width = 3.329528!
Me.Line97.X1 = 0.2291339!
Me.Line97.X2 = 3.558662!
Me.Line97.Y1 = 14.09685!
Me.Line97.Y2 = 14.09685!
'
'Line99
'
Me.Line99.Height = 0!
Me.Line99.Left = 0.2291339!
Me.Line99.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line99.LineWeight = 1!
Me.Line99.Name = "Line99"
Me.Line99.Top = 14.29685!
Me.Line99.Width = 3.329528!
Me.Line99.X1 = 0.2291339!
Me.Line99.X2 = 3.558662!
Me.Line99.Y1 = 14.29685!
Me.Line99.Y2 = 14.29685!
'
'Line100
'
Me.Line100.Height = 0!
Me.Line100.Left = 0.2291339!
Me.Line100.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line100.LineWeight = 1!
Me.Line100.Name = "Line100"
Me.Line100.Top = 14.49685!
Me.Line100.Width = 3.329528!
Me.Line100.X1 = 0.2291339!
Me.Line100.X2 = 3.558662!
Me.Line100.Y1 = 14.49685!
Me.Line100.Y2 = 14.49685!
'
'Line102
'
Me.Line102.Height = 0!
Me.Line102.Left = 0.2291339!
Me.Line102.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line102.LineWeight = 1!
Me.Line102.Name = "Line102"
Me.Line102.Top = 14.29685!
Me.Line102.Width = 3.329528!
Me.Line102.X1 = 0.2291339!
Me.Line102.X2 = 3.558662!
Me.Line102.Y1 = 14.29685!
Me.Line102.Y2 = 14.29685!
'
'Line103
'
Me.Line103.Height = 0!
Me.Line103.Left = 0.2291339!
Me.Line103.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line103.LineWeight = 1!
Me.Line103.Name = "Line103"
Me.Line103.Top = 14.89685!
Me.Line103.Width = 3.329528!
Me.Line103.X1 = 0.2291339!
Me.Line103.X2 = 3.558662!
Me.Line103.Y1 = 14.89685!
Me.Line103.Y2 = 14.89685!
'
'Line98
'
Me.Line98.Height = 0!
Me.Line98.Left = 0.2291339!
Me.Line98.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line98.LineWeight = 1!
Me.Line98.Name = "Line98"
Me.Line98.Top = 15.29685!
Me.Line98.Width = 3.329528!
Me.Line98.X1 = 0.2291339!
Me.Line98.X2 = 3.558662!
Me.Line98.Y1 = 15.29685!
Me.Line98.Y2 = 15.29685!
'
'Line105
'
Me.Line105.Height = 0!
Me.Line105.Left = 0.2291339!
Me.Line105.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line105.LineWeight = 1!
Me.Line105.Name = "Line105"
Me.Line105.Top = 15.49685!
Me.Line105.Width = 3.329528!
Me.Line105.X1 = 0.2291339!
Me.Line105.X2 = 3.558662!
Me.Line105.Y1 = 15.49685!
Me.Line105.Y2 = 15.49685!
'
'Line106
'
Me.Line106.Height = 0!
Me.Line106.Left = 0.2291339!
Me.Line106.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line106.LineWeight = 1!
Me.Line106.Name = "Line106"
Me.Line106.Top = 15.69685!
Me.Line106.Width = 3.329528!
Me.Line106.X1 = 0.2291339!
Me.Line106.X2 = 3.558662!
Me.Line106.Y1 = 15.69685!
Me.Line106.Y2 = 15.69685!
'
'Line107
'
Me.Line107.Height = 0!
Me.Line107.Left = 0.2291339!
Me.Line107.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line107.LineWeight = 1!
Me.Line107.Name = "Line107"
Me.Line107.Top = 15.89685!
Me.Line107.Width = 3.329528!
Me.Line107.X1 = 0.2291339!
Me.Line107.X2 = 3.558662!
Me.Line107.Y1 = 15.89685!
Me.Line107.Y2 = 15.89685!
'
'Line108
'
Me.Line108.Height = 0!
Me.Line108.Left = 0.2291339!
Me.Line108.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line108.LineWeight = 1!
Me.Line108.Name = "Line108"
Me.Line108.Top = 16.09685!
Me.Line108.Width = 3.329528!
Me.Line108.X1 = 0.2291339!
Me.Line108.X2 = 3.558662!
Me.Line108.Y1 = 16.09685!
Me.Line108.Y2 = 16.09685!
'
'Line109
'
Me.Line109.Height = 0!
Me.Line109.Left = 0.2291339!
Me.Line109.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line109.LineWeight = 1!
Me.Line109.Name = "Line109"
Me.Line109.Top = 16.49685!
Me.Line109.Width = 3.329528!
Me.Line109.X1 = 0.2291339!
Me.Line109.X2 = 3.558662!
Me.Line109.Y1 = 16.49685!
Me.Line109.Y2 = 16.49685!
'
'Line110
'
Me.Line110.Height = 0!
Me.Line110.Left = 0.2291339!
Me.Line110.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line110.LineWeight = 1!
Me.Line110.Name = "Line110"
Me.Line110.Top = 16.69685!
Me.Line110.Width = 3.329528!
Me.Line110.X1 = 0.2291339!
Me.Line110.X2 = 3.558662!
Me.Line110.Y1 = 16.69685!
Me.Line110.Y2 = 16.69685!
'
'Line111
'
Me.Line111.Height = 0!
Me.Line111.Left = 0.2291339!
Me.Line111.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line111.LineWeight = 1!
Me.Line111.Name = "Line111"
Me.Line111.Top = 16.89685!
Me.Line111.Width = 3.329528!
Me.Line111.X1 = 0.2291339!
Me.Line111.X2 = 3.558662!
Me.Line111.Y1 = 16.89685!
Me.Line111.Y2 = 16.89685!
'
'Line132
'
Me.Line132.Height = 0!
Me.Line132.Left = 0.2291339!
Me.Line132.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line132.LineWeight = 1!
Me.Line132.Name = "Line132"
Me.Line132.Top = 17.09685!
Me.Line132.Width = 3.329528!
Me.Line132.X1 = 0.2291339!
Me.Line132.X2 = 3.558662!
Me.Line132.Y1 = 17.09685!
Me.Line132.Y2 = 17.09685!
'
'Line133
'
Me.Line133.Height = 0!
Me.Line133.Left = 0.2291339!
Me.Line133.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line133.LineWeight = 1!
Me.Line133.Name = "Line133"
Me.Line133.Top = 17.29686!
Me.Line133.Width = 3.329528!
Me.Line133.X1 = 0.2291339!
Me.Line133.X2 = 3.558662!
Me.Line133.Y1 = 17.29686!
Me.Line133.Y2 = 17.29686!
'
'Line134
'
Me.Line134.Height = 1!
Me.Line134.Left = 1.892126!
Me.Line134.LineWeight = 1!
Me.Line134.Name = "Line134"
Me.Line134.Top = 15.69685!
Me.Line134.Width = 0!
Me.Line134.X1 = 1.892126!
Me.Line134.X2 = 1.892126!
Me.Line134.Y1 = 15.69685!
Me.Line134.Y2 = 16.69685!
'
'Line135
'
Me.Line135.Height = 2.000002!
Me.Line135.Left = 1.892126!
Me.Line135.LineWeight = 1!
Me.Line135.Name = "Line135"
Me.Line135.Top = 16.89685!
Me.Line135.Width = 1.192093E-07!
Me.Line135.X1 = 1.892126!
Me.Line135.X2 = 1.892126!
Me.Line135.Y1 = 16.89685!
Me.Line135.Y2 = 18.89685!
'
'Line137
'
Me.Line137.Height = 0.3999996!
Me.Line137.Left = 2.589764!
Me.Line137.LineWeight = 1!
Me.Line137.Name = "Line137"
Me.Line137.Top = 11.49685!
Me.Line137.Width = 0!
Me.Line137.X1 = 2.589764!
Me.Line137.X2 = 2.589764!
Me.Line137.Y1 = 11.49685!
Me.Line137.Y2 = 11.89685!
'
'Line138
'
Me.Line138.Height = 1!
Me.Line138.Left = 2.589764!
Me.Line138.LineWeight = 1!
Me.Line138.Name = "Line138"
Me.Line138.Top = 12.09685!
Me.Line138.Width = 0!
Me.Line138.X1 = 2.589764!
Me.Line138.X2 = 2.589764!
Me.Line138.Y1 = 12.09685!
Me.Line138.Y2 = 13.09685!
'
'Line139
'
Me.Line139.Height = 1!
Me.Line139.Left = 2.589764!
Me.Line139.LineWeight = 1!
Me.Line139.Name = "Line139"
Me.Line139.Top = 13.29685!
Me.Line139.Width = 0!
Me.Line139.X1 = 2.589764!
Me.Line139.X2 = 2.589764!
Me.Line139.Y1 = 13.29685!
Me.Line139.Y2 = 14.29685!
'
'Line141
'
Me.Line141.Height = 1!
Me.Line141.Left = 2.589764!
Me.Line141.LineWeight = 1!
Me.Line141.Name = "Line141"
Me.Line141.Top = 15.69685!
Me.Line141.Width = 0!
Me.Line141.X1 = 2.589764!
Me.Line141.X2 = 2.589764!
Me.Line141.Y1 = 15.69685!
Me.Line141.Y2 = 16.69685!
'
'Line153
'
Me.Line153.Height = 0.5999985!
Me.Line153.Left = 2.589764!
Me.Line153.LineWeight = 1!
Me.Line153.Name = "Line153"
Me.Line153.Top = 16.89685!
Me.Line153.Width = 0!
Me.Line153.X1 = 2.589764!
Me.Line153.X2 = 2.589764!
Me.Line153.Y1 = 16.89685!
Me.Line153.Y2 = 17.49685!
'
'Line84
'
Me.Line84.Height = 0!
Me.Line84.Left = 3.76378!
Me.Line84.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line84.LineWeight = 1!
Me.Line84.Name = "Line84"
Me.Line84.Top = 13.69685!
Me.Line84.Width = 3.388189!
Me.Line84.X1 = 3.76378!
Me.Line84.X2 = 7.151969!
Me.Line84.Y1 = 13.69685!
Me.Line84.Y2 = 13.69685!
'
'Label180
'
Me.Label180.Height = 0.1999999!
Me.Label180.HyperLink = Nothing
Me.Label180.Left = 3.76378!
Me.Label180.Name = "Label180"
Me.Label180.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label180.Text = "希望する"
Me.Label180.Top = 15.09685!
Me.Label180.Width = 0.7437003!
'
'Line123
'
Me.Line123.Height = 0!
Me.Line123.Left = 3.787796!
Me.Line123.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line123.LineWeight = 1!
Me.Line123.Name = "Line123"
Me.Line123.Top = 14.09685!
Me.Line123.Width = 3.364173!
Me.Line123.X1 = 3.787796!
Me.Line123.X2 = 7.151969!
Me.Line123.Y1 = 14.09685!
Me.Line123.Y2 = 14.09685!
'
'Line124
'
Me.Line124.Height = 0!
Me.Line124.Left = 3.787796!
Me.Line124.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line124.LineWeight = 1!
Me.Line124.Name = "Line124"
Me.Line124.Top = 14.29685!
Me.Line124.Width = 3.364173!
Me.Line124.X1 = 3.787796!
Me.Line124.X2 = 7.151969!
Me.Line124.Y1 = 14.29685!
Me.Line124.Y2 = 14.29685!
'
'Line125
'
Me.Line125.Height = 0!
Me.Line125.Left = 3.787796!
Me.Line125.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line125.LineWeight = 1!
Me.Line125.Name = "Line125"
Me.Line125.Top = 14.49685!
Me.Line125.Width = 3.364173!
Me.Line125.X1 = 3.787796!
Me.Line125.X2 = 7.151969!
Me.Line125.Y1 = 14.49685!
Me.Line125.Y2 = 14.49685!
'
'Line126
'
Me.Line126.Height = 0!
Me.Line126.Left = 3.787796!
Me.Line126.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line126.LineWeight = 1!
Me.Line126.Name = "Line126"
Me.Line126.Top = 14.29685!
Me.Line126.Width = 3.364173!
Me.Line126.X1 = 3.787796!
Me.Line126.X2 = 7.151969!
Me.Line126.Y1 = 14.29685!
Me.Line126.Y2 = 14.29685!
'
'Line127
'
Me.Line127.Height = 0!
Me.Line127.Left = 3.76378!
Me.Line127.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line127.LineWeight = 1!
Me.Line127.Name = "Line127"
Me.Line127.Top = 14.89685!
Me.Line127.Width = 3.397638!
Me.Line127.X1 = 3.76378!
Me.Line127.X2 = 7.161418!
Me.Line127.Y1 = 14.89685!
Me.Line127.Y2 = 14.89685!
'
'Line122
'
Me.Line122.Height = 0!
Me.Line122.Left = 3.76378!
Me.Line122.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line122.LineWeight = 1!
Me.Line122.Name = "Line122"
Me.Line122.Top = 12.49685!
Me.Line122.Width = 3.397638!
Me.Line122.X1 = 3.76378!
Me.Line122.X2 = 7.161418!
Me.Line122.Y1 = 12.49685!
Me.Line122.Y2 = 12.49685!
'
'Line85
'
Me.Line85.Height = 0!
Me.Line85.Left = 3.76378!
Me.Line85.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line85.LineWeight = 1!
Me.Line85.Name = "Line85"
Me.Line85.Top = 11.69685!
Me.Line85.Width = 3.397637!
Me.Line85.X1 = 3.76378!
Me.Line85.X2 = 7.161417!
Me.Line85.Y1 = 11.69685!
Me.Line85.Y2 = 11.69685!
'
'Line86
'
Me.Line86.Height = 0!
Me.Line86.Left = 3.76378!
Me.Line86.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line86.LineWeight = 1!
Me.Line86.Name = "Line86"
Me.Line86.Top = 11.89685!
Me.Line86.Width = 3.397637!
Me.Line86.X1 = 3.76378!
Me.Line86.X2 = 7.161417!
Me.Line86.Y1 = 11.89685!
Me.Line86.Y2 = 11.89685!
'
'Line154
'
Me.Line154.Height = 0!
Me.Line154.Left = 3.76378!
Me.Line154.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line154.LineWeight = 1!
Me.Line154.Name = "Line154"
Me.Line154.Top = 12.09685!
Me.Line154.Width = 3.397637!
Me.Line154.X1 = 3.76378!
Me.Line154.X2 = 7.161417!
Me.Line154.Y1 = 12.09685!
Me.Line154.Y2 = 12.09685!
'
'Line155
'
Me.Line155.Height = 0!
Me.Line155.Left = 3.76378!
Me.Line155.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line155.LineWeight = 1!
Me.Line155.Name = "Line155"
Me.Line155.Top = 12.29685!
Me.Line155.Width = 3.397637!
Me.Line155.X1 = 3.76378!
Me.Line155.X2 = 7.161417!
Me.Line155.Y1 = 12.29685!
Me.Line155.Y2 = 12.29685!
'
'Line156
'
Me.Line156.Height = 0!
Me.Line156.Left = 3.76378!
Me.Line156.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line156.LineWeight = 1!
Me.Line156.Name = "Line156"
Me.Line156.Top = 12.49685!
Me.Line156.Width = 3.397637!
Me.Line156.X1 = 3.76378!
Me.Line156.X2 = 7.161417!
Me.Line156.Y1 = 12.49685!
Me.Line156.Y2 = 12.49685!
'
'Line83
'
Me.Line83.Height = 0!
Me.Line83.Left = 0!
Me.Line83.LineWeight = 1!
Me.Line83.Name = "Line83"
Me.Line83.Top = 16.29685!
Me.Line83.Width = 7.161418!
Me.Line83.X1 = 0!
Me.Line83.X2 = 7.161418!
Me.Line83.Y1 = 16.29685!
Me.Line83.Y2 = 16.29685!
'
'Line104
'
Me.Line104.Height = 0!
Me.Line104.Left = 0!
Me.Line104.LineWeight = 1!
Me.Line104.Name = "Line104"
Me.Line104.Top = 15.09685!
Me.Line104.Width = 7.151969!
Me.Line104.X1 = 0!
Me.Line104.X2 = 7.151969!
Me.Line104.Y1 = 15.09685!
Me.Line104.Y2 = 15.09685!
'
'Line72
'
Me.Line72.Height = 0!
Me.Line72.Left = 3.76378!
Me.Line72.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line72.LineWeight = 1!
Me.Line72.Name = "Line72"
Me.Line72.Top = 15.29685!
Me.Line72.Width = 3.397637!
Me.Line72.X1 = 3.76378!
Me.Line72.X2 = 7.161417!
Me.Line72.Y1 = 15.29685!
Me.Line72.Y2 = 15.29685!
'
'Line128
'
Me.Line128.Height = 0!
Me.Line128.Left = 3.76378!
Me.Line128.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line128.LineWeight = 1!
Me.Line128.Name = "Line128"
Me.Line128.Top = 15.49685!
Me.Line128.Width = 3.397637!
Me.Line128.X1 = 3.76378!
Me.Line128.X2 = 7.161417!
Me.Line128.Y1 = 15.49685!
Me.Line128.Y2 = 15.49685!
'
'Line129
'
Me.Line129.Height = 0!
Me.Line129.Left = 3.76378!
Me.Line129.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line129.LineWeight = 1!
Me.Line129.Name = "Line129"
Me.Line129.Top = 15.69685!
Me.Line129.Width = 3.397637!
Me.Line129.X1 = 3.76378!
Me.Line129.X2 = 7.161417!
Me.Line129.Y1 = 15.69685!
Me.Line129.Y2 = 15.69685!
'
'Line130
'
Me.Line130.Height = 0!
Me.Line130.Left = 3.76378!
Me.Line130.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line130.LineWeight = 1!
Me.Line130.Name = "Line130"
Me.Line130.Top = 15.89685!
Me.Line130.Width = 3.397637!
Me.Line130.X1 = 3.76378!
Me.Line130.X2 = 7.161417!
Me.Line130.Y1 = 15.89685!
Me.Line130.Y2 = 15.89685!
'
'Line131
'
Me.Line131.Height = 0!
Me.Line131.Left = 3.76378!
Me.Line131.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line131.LineWeight = 1!
Me.Line131.Name = "Line131"
Me.Line131.Top = 16.09685!
Me.Line131.Width = 3.397637!
Me.Line131.X1 = 3.76378!
Me.Line131.X2 = 7.161417!
Me.Line131.Y1 = 16.09685!
Me.Line131.Y2 = 16.09685!
'
'Line54
'
Me.Line54.Height = 0.3999996!
Me.Line54.Left = 5.485434!
Me.Line54.LineWeight = 1!
Me.Line54.Name = "Line54"
Me.Line54.Top = 11.49685!
Me.Line54.Width = 0!
Me.Line54.X1 = 5.485434!
Me.Line54.X2 = 5.485434!
Me.Line54.Y1 = 11.49685!
Me.Line54.Y2 = 11.89685!
'
'Line142
'
Me.Line142.Height = 0.3999996!
Me.Line142.Left = 6.186221!
Me.Line142.LineWeight = 1!
Me.Line142.Name = "Line142"
Me.Line142.Top = 11.49685!
Me.Line142.Width = 0!
Me.Line142.X1 = 6.186221!
Me.Line142.X2 = 6.186221!
Me.Line142.Y1 = 11.49685!
Me.Line142.Y2 = 11.89685!
'
'Line143
'
Me.Line143.Height = 1!
Me.Line143.Left = 5.485434!
Me.Line143.LineWeight = 1!
Me.Line143.Name = "Line143"
Me.Line143.Top = 12.09685!
Me.Line143.Width = 0!
Me.Line143.X1 = 5.485434!
Me.Line143.X2 = 5.485434!
Me.Line143.Y1 = 12.09685!
Me.Line143.Y2 = 13.09685!
'
'Line144
'
Me.Line144.Height = 1!
Me.Line144.Left = 5.485434!
Me.Line144.LineWeight = 1!
Me.Line144.Name = "Line144"
Me.Line144.Top = 13.29685!
Me.Line144.Width = 0!
Me.Line144.X1 = 5.485434!
Me.Line144.X2 = 5.485434!
Me.Line144.Y1 = 13.29685!
Me.Line144.Y2 = 14.29685!
'
'Line146
'
Me.Line146.Height = 1!
Me.Line146.Left = 5.485434!
Me.Line146.LineWeight = 1!
Me.Line146.Name = "Line146"
Me.Line146.Top = 15.69685!
Me.Line146.Width = 0!
Me.Line146.X1 = 5.485434!
Me.Line146.X2 = 5.485434!
Me.Line146.Y1 = 15.69685!
Me.Line146.Y2 = 16.69685!
'
'Line147
'
Me.Line147.Height = 1!
Me.Line147.Left = 6.172835!
Me.Line147.LineWeight = 1!
Me.Line147.Name = "Line147"
Me.Line147.Top = 12.09685!
Me.Line147.Width = 0!
Me.Line147.X1 = 6.172835!
Me.Line147.X2 = 6.172835!
Me.Line147.Y1 = 12.09685!
Me.Line147.Y2 = 13.09685!
'
'Line148
'
Me.Line148.Height = 1!
Me.Line148.Left = 6.172835!
Me.Line148.LineWeight = 1!
Me.Line148.Name = "Line148"
Me.Line148.Top = 13.29685!
Me.Line148.Width = 0!
Me.Line148.X1 = 6.172835!
Me.Line148.X2 = 6.172835!
Me.Line148.Y1 = 13.29685!
Me.Line148.Y2 = 14.29685!
'
'Line149
'
Me.Line149.Height = 1!
Me.Line149.Left = 6.172835!
Me.Line149.LineWeight = 1!
Me.Line149.Name = "Line149"
Me.Line149.Top = 14.49685!
Me.Line149.Width = 0!
Me.Line149.X1 = 6.172835!
Me.Line149.X2 = 6.172835!
Me.Line149.Y1 = 14.49685!
Me.Line149.Y2 = 15.49685!
'
'Line150
'
Me.Line150.Height = 1!
Me.Line150.Left = 6.172835!
Me.Line150.LineWeight = 1!
Me.Line150.Name = "Line150"
Me.Line150.Top = 15.69685!
Me.Line150.Width = 0!
Me.Line150.X1 = 6.172835!
Me.Line150.X2 = 6.172835!
Me.Line150.Y1 = 15.69685!
Me.Line150.Y2 = 16.69685!
'
'Line151
'
Me.Line151.Height = 1.000002!
Me.Line151.Left = 5.485434!
Me.Line151.LineWeight = 1!
Me.Line151.Name = "Line151"
Me.Line151.Top = 16.89685!
Me.Line151.Width = 4.768372E-07!
Me.Line151.X1 = 5.485434!
Me.Line151.X2 = 5.485434!
Me.Line151.Y1 = 16.89685!
Me.Line151.Y2 = 17.89685!
'
'Line157
'
Me.Line157.Height = 0.5999985!
Me.Line157.Left = 6.186221!
Me.Line157.LineWeight = 1!
Me.Line157.Name = "Line157"
Me.Line157.Top = 16.89685!
Me.Line157.Width = 0!
Me.Line157.X1 = 6.186221!
Me.Line157.X2 = 6.186221!
Me.Line157.Y1 = 16.89685!
Me.Line157.Y2 = 17.49685!
'
'Line158
'
Me.Line158.Height = 0!
Me.Line158.Left = 3.76378!
Me.Line158.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line158.LineWeight = 1!
Me.Line158.Name = "Line158"
Me.Line158.Top = 16.49685!
Me.Line158.Width = 3.397637!
Me.Line158.X1 = 3.76378!
Me.Line158.X2 = 7.161417!
Me.Line158.Y1 = 16.49685!
Me.Line158.Y2 = 16.49685!
'
'Line159
'
Me.Line159.Height = 0!
Me.Line159.Left = 3.76378!
Me.Line159.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line159.LineWeight = 1!
Me.Line159.Name = "Line159"
Me.Line159.Top = 16.69685!
Me.Line159.Width = 3.397637!
Me.Line159.X1 = 3.76378!
Me.Line159.X2 = 7.161417!
Me.Line159.Y1 = 16.69685!
Me.Line159.Y2 = 16.69685!
'
'Line160
'
Me.Line160.Height = 0!
Me.Line160.Left = 3.76378!
Me.Line160.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line160.LineWeight = 1!
Me.Line160.Name = "Line160"
Me.Line160.Top = 16.89685!
Me.Line160.Width = 3.397637!
Me.Line160.X1 = 3.76378!
Me.Line160.X2 = 7.161417!
Me.Line160.Y1 = 16.89685!
Me.Line160.Y2 = 16.89685!
'
'Line161
'
Me.Line161.Height = 0!
Me.Line161.Left = 3.76378!
Me.Line161.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line161.LineWeight = 1!
Me.Line161.Name = "Line161"
Me.Line161.Top = 17.09685!
Me.Line161.Width = 3.397637!
Me.Line161.X1 = 3.76378!
Me.Line161.X2 = 7.161417!
Me.Line161.Y1 = 17.09685!
Me.Line161.Y2 = 17.09685!
'
'Line162
'
Me.Line162.Height = 0!
Me.Line162.Left = 3.76378!
Me.Line162.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
Me.Line162.LineWeight = 1!
Me.Line162.Name = "Line162"
Me.Line162.Top = 17.29686!
Me.Line162.Width = 3.397637!
Me.Line162.X1 = 3.76378!
Me.Line162.X2 = 7.161417!
Me.Line162.Y1 = 17.29686!
Me.Line162.Y2 = 17.29686!
'
'Line163
'
Me.Line163.Height = 0.8000002!
Me.Line163.Left = 3.11063!
Me.Line163.LineWeight = 1!
Me.Line163.Name = "Line163"
Me.Line163.Top = 2.701181!
Me.Line163.Width = 0.005118132!
Me.Line163.X1 = 3.115748!
Me.Line163.X2 = 3.11063!
Me.Line163.Y1 = 2.701181!
Me.Line163.Y2 = 3.501181!
'
'Line164
'
Me.Line164.Height = 0.2!
Me.Line164.Left = 4.725985!
Me.Line164.LineWeight = 1!
Me.Line164.Name = "Line164"
Me.Line164.Top = 3.301181!
Me.Line164.Width = 0!
Me.Line164.X1 = 4.725985!
Me.Line164.X2 = 4.725985!
Me.Line164.Y1 = 3.301181!
Me.Line164.Y2 = 3.501181!
'
'Line8
'
Me.Line8.Height = 0!
Me.Line8.Left = 4.768372E-07!
Me.Line8.LineWeight = 1!
Me.Line8.Name = "Line8"
Me.Line8.Top = 2.074016!
Me.Line8.Width = 7.165353!
Me.Line8.X1 = 4.768372E-07!
Me.Line8.X2 = 7.165354!
Me.Line8.Y1 = 2.074016!
Me.Line8.Y2 = 2.074016!
'
'Label218
'
Me.Label218.Height = 0.2!
Me.Label218.HyperLink = Nothing
Me.Label218.Left = 0!
Me.Label218.Name = "Label218"
Me.Label218.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: middle"
Me.Label218.Text = "会場名："
Me.Label218.Top = 0.4740158!
Me.Label218.Width = 0.6771654!
'
'KAIJO_NAME
'
Me.KAIJO_NAME.DataField = "KAIJO_NAME"
Me.KAIJO_NAME.Height = 0.2!
Me.KAIJO_NAME.Left = 0.6771654!
Me.KAIJO_NAME.Name = "KAIJO_NAME"
Me.KAIJO_NAME.Style = "font-weight: normal; white-space: nowrap"
Me.KAIJO_NAME.Text = Nothing
Me.KAIJO_NAME.Top = 0.4740158!
Me.KAIJO_NAME.Width = 6.488189!
'
'Line136
'
Me.Line136.Height = 6.00001!
Me.Line136.Left = 0.916535!
Me.Line136.LineWeight = 1!
Me.Line136.Name = "Line136"
Me.Line136.Top = 11.49685!
Me.Line136.Width = 4.768372E-07!
Me.Line136.X1 = 0.9165355!
Me.Line136.X2 = 0.916535!
Me.Line136.Y1 = 11.49685!
Me.Line136.Y2 = 17.49686!
'
'Line69
'
Me.Line69.Height = 8.400002!
Me.Line69.Left = 3.548425!
Me.Line69.LineWeight = 1!
Me.Line69.Name = "Line69"
Me.Line69.Top = 10.49685!
Me.Line69.Width = 0.01023626!
Me.Line69.X1 = 3.558662!
Me.Line69.X2 = 3.548425!
Me.Line69.Y1 = 10.49685!
Me.Line69.Y2 = 18.89685!
'
'Line73
'
Me.Line73.Height = 5.999998!
Me.Line73.Left = 3.76378!
Me.Line73.LineWeight = 1!
Me.Line73.Name = "Line73"
Me.Line73.Top = 11.49685!
Me.Line73.Width = 0!
Me.Line73.X1 = 3.76378!
Me.Line73.X2 = 3.76378!
Me.Line73.Y1 = 11.49685!
Me.Line73.Y2 = 17.49685!
'
'Line145
'
Me.Line145.Height = 1!
Me.Line145.Left = 5.485434!
Me.Line145.LineWeight = 1!
Me.Line145.Name = "Line145"
Me.Line145.Top = 14.49685!
Me.Line145.Width = 0!
Me.Line145.X1 = 5.485434!
Me.Line145.X2 = 5.485434!
Me.Line145.Y1 = 14.49685!
Me.Line145.Y2 = 15.49685!
'
'Line198
'
Me.Line198.Height = 6.999998!
Me.Line198.Left = 4.507481!
Me.Line198.LineWeight = 1!
Me.Line198.Name = "Line198"
Me.Line198.Top = 10.49685!
Me.Line198.Width = 0!
Me.Line198.X1 = 4.507481!
Me.Line198.X2 = 4.507481!
Me.Line198.Y1 = 10.49685!
Me.Line198.Y2 = 17.49685!
'
'Line201
'
Me.Line201.Height = 8.400002!
Me.Line201.Left = 7.161418!
Me.Line201.LineWeight = 1!
Me.Line201.Name = "Line201"
Me.Line201.Top = 10.49685!
Me.Line201.Width = 0.003936768!
Me.Line201.X1 = 7.165355!
Me.Line201.X2 = 7.161418!
Me.Line201.Y1 = 10.49685!
Me.Line201.Y2 = 18.89685!
'
'Line77
'
Me.Line77.Height = 1!
Me.Line77.Left = 1.892126!
Me.Line77.LineWeight = 1!
Me.Line77.Name = "Line77"
Me.Line77.Top = 14.49685!
Me.Line77.Width = 0!
Me.Line77.X1 = 1.892126!
Me.Line77.X2 = 1.892126!
Me.Line77.Y1 = 14.49685!
Me.Line77.Y2 = 15.49685!
'
'Label221
'
Me.Label221.Height = 0.2!
Me.Label221.HyperLink = Nothing
Me.Label221.Left = 0!
Me.Label221.Name = "Label221"
Me.Label221.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold; vertical-align: middle"
Me.Label221.Text = "会場名："
Me.Label221.Top = 10.09685!
Me.Label221.Width = 0.6771654!
'
'KAIJO_NAME2
'
Me.KAIJO_NAME2.DataField = "KAIJO_NAME"
Me.KAIJO_NAME2.Height = 0.2!
Me.KAIJO_NAME2.Left = 0.6771654!
Me.KAIJO_NAME2.Name = "KAIJO_NAME2"
Me.KAIJO_NAME2.Style = "font-weight: normal; white-space: nowrap"
Me.KAIJO_NAME2.Text = Nothing
Me.KAIJO_NAME2.Top = 10.09685!
Me.KAIJO_NAME2.Width = 6.488189!
'
'PageFooter
'
Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.PRINT_USER, Me.Label2, Me.PRINT_DATE})
Me.PageFooter.Height = 0.4185039!
Me.PageFooter.Name = "PageFooter"
'
'Label1
'
Me.Label1.Height = 0.2!
Me.Label1.HyperLink = Nothing
Me.Label1.Left = 5.203937!
Me.Label1.Name = "Label1"
Me.Label1.Style = "text-align: right"
Me.Label1.Text = "出力日："
Me.Label1.Top = 0!
Me.Label1.Width = 0.5834652!
'
'PRINT_USER
'
Me.PRINT_USER.Height = 0.2!
Me.PRINT_USER.Left = 5.787402!
Me.PRINT_USER.Name = "PRINT_USER"
Me.PRINT_USER.Style = "white-space: nowrap"
Me.PRINT_USER.Text = Nothing
Me.PRINT_USER.Top = 0.1999998!
Me.PRINT_USER.Width = 1.364567!
'
'Label2
'
Me.Label2.Height = 0.2!
Me.Label2.HyperLink = Nothing
Me.Label2.Left = 5.058269!
Me.Label2.Name = "Label2"
Me.Label2.Style = "text-align: right"
Me.Label2.Text = "出力担当："
Me.Label2.Top = 0.2!
Me.Label2.Width = 0.7291334!
'
'PRINT_DATE
'
Me.PRINT_DATE.Height = 0.2!
Me.PRINT_DATE.Left = 5.787402!
Me.PRINT_DATE.Name = "PRINT_DATE"
Me.PRINT_DATE.Style = "white-space: nowrap"
Me.PRINT_DATE.Text = "1234/56/78 12:34:56"
Me.PRINT_DATE.Top = 0!
Me.PRINT_DATE.Width = 1.364567!
'
'Label227
'
Me.Label227.Height = 0.2!
Me.Label227.HyperLink = Nothing
Me.Label227.Left = 3.11063!
Me.Label227.Name = "Label227"
Me.Label227.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label227.Text = "BU(担当MR)"
Me.Label227.Top = 2.701181!
Me.Label227.Width = 1.167323!
'
'MR_BU
'
Me.MR_BU.DataField = "MR_BU"
Me.MR_BU.Height = 0.2!
Me.MR_BU.Left = 4.277953!
Me.MR_BU.Name = "MR_BU"
Me.MR_BU.Style = "vertical-align: middle"
Me.MR_BU.Text = Nothing
Me.MR_BU.Top = 2.701181!
Me.MR_BU.Width = 0.6413383!
'
'Label93
'
Me.Label93.Height = 0.2!
Me.Label93.HyperLink = Nothing
Me.Label93.Left = 0!
Me.Label93.Name = "Label93"
Me.Label93.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label93.Text = "航空券代(税込)"
Me.Label93.Top = 17.49685!
Me.Label93.Width = 1.892126!
'
'Label228
'
Me.Label228.Height = 0.2!
Me.Label228.HyperLink = Nothing
Me.Label228.Left = 0!
Me.Label228.Name = "Label228"
Me.Label228.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label228.Text = "航空券取消料(税込)"
Me.Label228.Top = 17.69685!
Me.Label228.Width = 1.892126!
'
'Label229
'
Me.Label229.Height = 0.2!
Me.Label229.HyperLink = Nothing
Me.Label229.Left = 0!
Me.Label229.Name = "Label229"
Me.Label229.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label229.Text = "JR券代(税込)"
Me.Label229.Top = 17.89685!
Me.Label229.Width = 1.892126!
'
'Label230
'
Me.Label230.Height = 0.2!
Me.Label230.HyperLink = Nothing
Me.Label230.Left = 0!
Me.Label230.Name = "Label230"
Me.Label230.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label230.Text = "JR券取消料(税込)"
Me.Label230.Top = 18.09685!
Me.Label230.Width = 1.892126!
'
'Label231
'
Me.Label231.Height = 0.2!
Me.Label231.HyperLink = Nothing
Me.Label231.Left = 3.558662!
Me.Label231.Name = "Label231"
Me.Label231.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label231.Text = "その他鉄道代等(税込)"
Me.Label231.Top = 17.49685!
Me.Label231.Width = 1.926772!
'
'Label232
'
Me.Label232.Height = 0.2!
Me.Label232.HyperLink = Nothing
Me.Label232.Left = 3.558662!
Me.Label232.Name = "Label232"
Me.Label232.Style = "background-color: Gainsboro; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align"& _ 
    ": middle; white-space: nowrap"
Me.Label232.Text = "その他鉄道代等取消料(税込)"
Me.Label232.Top = 17.69685!
Me.Label232.Width = 1.926772!
'
'Label233
'
Me.Label233.Height = 0.2!
Me.Label233.HyperLink = Nothing
Me.Label233.Left = 0!
Me.Label233.Name = "Label233"
Me.Label233.Style = "background-color: DarkGray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label233.Text = "MR宿泊費(税込)"
Me.Label233.Top = 18.29685!
Me.Label233.Width = 1.892126!
'
'Label234
'
Me.Label234.Height = 0.2!
Me.Label234.HyperLink = Nothing
Me.Label234.Left = 0!
Me.Label234.Name = "Label234"
Me.Label234.Style = "background-color: DarkGray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label234.Text = "MR宿泊東京都税"
Me.Label234.Top = 18.49685!
Me.Label234.Width = 1.892126!
'
'Label235
'
Me.Label235.Height = 0.2!
Me.Label235.HyperLink = Nothing
Me.Label235.Left = 0!
Me.Label235.Name = "Label235"
Me.Label235.Style = "background-color: DarkGray; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align:"& _ 
    " middle; white-space: nowrap"
Me.Label235.Text = "MR交通費(税込)"
Me.Label235.Top = 18.69685!
Me.Label235.Width = 1.892126!
'
'Line56
'
Me.Line56.Height = 0!
Me.Line56.Left = 0!
Me.Line56.LineWeight = 1!
Me.Line56.Name = "Line56"
Me.Line56.Top = 17.69685!
Me.Line56.Width = 7.151965!
Me.Line56.X1 = 0!
Me.Line56.X2 = 7.151965!
Me.Line56.Y1 = 17.69685!
Me.Line56.Y2 = 17.69685!
'
'Line165
'
Me.Line165.Height = 0!
Me.Line165.Left = 0!
Me.Line165.LineWeight = 1!
Me.Line165.Name = "Line165"
Me.Line165.Top = 17.89685!
Me.Line165.Width = 7.151965!
Me.Line165.X1 = 0!
Me.Line165.X2 = 7.151965!
Me.Line165.Y1 = 17.89685!
Me.Line165.Y2 = 17.89685!
'
'Line166
'
Me.Line166.Height = 0!
Me.Line166.Left = 0!
Me.Line166.LineWeight = 1!
Me.Line166.Name = "Line166"
Me.Line166.Top = 18.09685!
Me.Line166.Width = 3.548425!
Me.Line166.X1 = 0!
Me.Line166.X2 = 3.548425!
Me.Line166.Y1 = 18.09685!
Me.Line166.Y2 = 18.09685!
'
'Line167
'
Me.Line167.Height = 0!
Me.Line167.Left = 0!
Me.Line167.LineWeight = 1!
Me.Line167.Name = "Line167"
Me.Line167.Top = 18.29685!
Me.Line167.Width = 3.548425!
Me.Line167.X1 = 0!
Me.Line167.X2 = 3.548425!
Me.Line167.Y1 = 18.29685!
Me.Line167.Y2 = 18.29685!
'
'Line168
'
Me.Line168.Height = 1.907349E-06!
Me.Line168.Left = 0!
Me.Line168.LineWeight = 1!
Me.Line168.Name = "Line168"
Me.Line168.Top = 18.49685!
Me.Line168.Width = 3.548425!
Me.Line168.X1 = 0!
Me.Line168.X2 = 3.548425!
Me.Line168.Y1 = 18.49685!
Me.Line168.Y2 = 18.49685!
'
'Line169
'
Me.Line169.Height = 1.907349E-06!
Me.Line169.Left = 0!
Me.Line169.LineWeight = 1!
Me.Line169.Name = "Line169"
Me.Line169.Top = 18.69685!
Me.Line169.Width = 3.548425!
Me.Line169.X1 = 0!
Me.Line169.X2 = 3.548425!
Me.Line169.Y1 = 18.69685!
Me.Line169.Y2 = 18.69685!
'
'Line170
'
Me.Line170.Height = 0!
Me.Line170.Left = 0!
Me.Line170.LineWeight = 1!
Me.Line170.Name = "Line170"
Me.Line170.Top = 18.89685!
Me.Line170.Width = 7.151965!
Me.Line170.X1 = 0!
Me.Line170.X2 = 7.151965!
Me.Line170.Y1 = 18.89685!
Me.Line170.Y2 = 18.89685!
'
'ANS_AIR_FARE
'
Me.ANS_AIR_FARE.DataField = "ANS_AIR_FARE"
Me.ANS_AIR_FARE.Height = 0.2!
Me.ANS_AIR_FARE.Left = 1.902362!
Me.ANS_AIR_FARE.Name = "ANS_AIR_FARE"
Me.ANS_AIR_FARE.Style = "text-align: left; vertical-align: middle"
Me.ANS_AIR_FARE.Text = Nothing
Me.ANS_AIR_FARE.Top = 17.49685!
Me.ANS_AIR_FARE.Width = 1.646063!
'
'ANS_AIR_CANCELLATION
'
Me.ANS_AIR_CANCELLATION.DataField = "ANS_AIR_CANCELLATION"
Me.ANS_AIR_CANCELLATION.Height = 0.2!
Me.ANS_AIR_CANCELLATION.Left = 1.902362!
Me.ANS_AIR_CANCELLATION.Name = "ANS_AIR_CANCELLATION"
Me.ANS_AIR_CANCELLATION.Style = "text-align: left; vertical-align: middle"
Me.ANS_AIR_CANCELLATION.Text = Nothing
Me.ANS_AIR_CANCELLATION.Top = 17.69685!
Me.ANS_AIR_CANCELLATION.Width = 1.646063!
'
'ANS_RAIL_FARE
'
Me.ANS_RAIL_FARE.DataField = "ANS_RAIL_FARE"
Me.ANS_RAIL_FARE.Height = 0.2!
Me.ANS_RAIL_FARE.Left = 1.902362!
Me.ANS_RAIL_FARE.Name = "ANS_RAIL_FARE"
Me.ANS_RAIL_FARE.Style = "text-align: left; vertical-align: middle"
Me.ANS_RAIL_FARE.Text = Nothing
Me.ANS_RAIL_FARE.Top = 17.89685!
Me.ANS_RAIL_FARE.Width = 1.646063!
'
'ANS_RAIL_CANCELLATION
'
Me.ANS_RAIL_CANCELLATION.DataField = "ANS_RAIL_CANCELLATION"
Me.ANS_RAIL_CANCELLATION.Height = 0.2!
Me.ANS_RAIL_CANCELLATION.Left = 1.902362!
Me.ANS_RAIL_CANCELLATION.Name = "ANS_RAIL_CANCELLATION"
Me.ANS_RAIL_CANCELLATION.Style = "text-align: left; vertical-align: middle"
Me.ANS_RAIL_CANCELLATION.Text = Nothing
Me.ANS_RAIL_CANCELLATION.Top = 18.09685!
Me.ANS_RAIL_CANCELLATION.Width = 1.646063!
'
'ANS_MR_HOTELHI
'
Me.ANS_MR_HOTELHI.DataField = "ANS_MR_HOTELHI"
Me.ANS_MR_HOTELHI.Height = 0.2!
Me.ANS_MR_HOTELHI.Left = 1.902362!
Me.ANS_MR_HOTELHI.Name = "ANS_MR_HOTELHI"
Me.ANS_MR_HOTELHI.Style = "text-align: left; vertical-align: middle"
Me.ANS_MR_HOTELHI.Text = Nothing
Me.ANS_MR_HOTELHI.Top = 18.29685!
Me.ANS_MR_HOTELHI.Width = 1.646063!
'
'ANS_MR_HOTELHI_TOZEI
'
Me.ANS_MR_HOTELHI_TOZEI.DataField = "ANS_MR_HOTELHI_TOZEI"
Me.ANS_MR_HOTELHI_TOZEI.Height = 0.2!
Me.ANS_MR_HOTELHI_TOZEI.Left = 1.902362!
Me.ANS_MR_HOTELHI_TOZEI.Name = "ANS_MR_HOTELHI_TOZEI"
Me.ANS_MR_HOTELHI_TOZEI.Style = "text-align: left; vertical-align: middle"
Me.ANS_MR_HOTELHI_TOZEI.Text = Nothing
Me.ANS_MR_HOTELHI_TOZEI.Top = 18.49685!
Me.ANS_MR_HOTELHI_TOZEI.Width = 1.646063!
'
'ANS_MR_KOTSUHI
'
Me.ANS_MR_KOTSUHI.DataField = "ANS_MR_KOTSUHI"
Me.ANS_MR_KOTSUHI.Height = 0.2!
Me.ANS_MR_KOTSUHI.Left = 1.902362!
Me.ANS_MR_KOTSUHI.Name = "ANS_MR_KOTSUHI"
Me.ANS_MR_KOTSUHI.Style = "text-align: left; vertical-align: middle"
Me.ANS_MR_KOTSUHI.Text = Nothing
Me.ANS_MR_KOTSUHI.Top = 18.69685!
Me.ANS_MR_KOTSUHI.Width = 1.646063!
'
'ANS_OTHER_FARE
'
Me.ANS_OTHER_FARE.DataField = "ANS_OTHER_FARE"
Me.ANS_OTHER_FARE.Height = 0.2!
Me.ANS_OTHER_FARE.Left = 5.485434!
Me.ANS_OTHER_FARE.Name = "ANS_OTHER_FARE"
Me.ANS_OTHER_FARE.Style = "text-align: left; vertical-align: middle"
Me.ANS_OTHER_FARE.Text = Nothing
Me.ANS_OTHER_FARE.Top = 17.49685!
Me.ANS_OTHER_FARE.Width = 1.646063!
'
'ANS_OTHER_CANCELLATION
'
Me.ANS_OTHER_CANCELLATION.DataField = "ANS_OTHER_CANCELLATION"
Me.ANS_OTHER_CANCELLATION.Height = 0.2!
Me.ANS_OTHER_CANCELLATION.Left = 5.485434!
Me.ANS_OTHER_CANCELLATION.Name = "ANS_OTHER_CANCELLATION"
Me.ANS_OTHER_CANCELLATION.Style = "text-align: left; vertical-align: middle"
Me.ANS_OTHER_CANCELLATION.Text = Nothing
Me.ANS_OTHER_CANCELLATION.Top = 17.69685!
Me.ANS_OTHER_CANCELLATION.Width = 1.646063!
'
'TAXI_PRT_NAME
'
Me.TAXI_PRT_NAME.DataField = "TAXI_PRT_NAME"
Me.TAXI_PRT_NAME.Height = 0.2!
Me.TAXI_PRT_NAME.Left = 5.942914!
Me.TAXI_PRT_NAME.Name = "TAXI_PRT_NAME"
Me.TAXI_PRT_NAME.Style = "vertical-align: middle"
Me.TAXI_PRT_NAME.Top = 0.2740158!
Me.TAXI_PRT_NAME.Visible = false
Me.TAXI_PRT_NAME.Width = 1.209055!
'
'ANS_TICKET_SEND_DAY
'
Me.ANS_TICKET_SEND_DAY.DataField = "ANS_TICKET_SEND_DAY"
Me.ANS_TICKET_SEND_DAY.Height = 0.2!
Me.ANS_TICKET_SEND_DAY.Left = 5.800788!
Me.ANS_TICKET_SEND_DAY.Name = "ANS_TICKET_SEND_DAY"
Me.ANS_TICKET_SEND_DAY.Style = "vertical-align: middle"
Me.ANS_TICKET_SEND_DAY.Text = Nothing
Me.ANS_TICKET_SEND_DAY.Top = 0.6740158!
Me.ANS_TICKET_SEND_DAY.Width = 1.351181!
'
'REQ_STATUS_TEHAI1
'
Me.REQ_STATUS_TEHAI1.DataField = "REQ_STATUS_TEHAI"
Me.REQ_STATUS_TEHAI1.Height = 0.2!
Me.REQ_STATUS_TEHAI1.Left = 4.507481!
Me.REQ_STATUS_TEHAI1.Name = "REQ_STATUS_TEHAI1"
Me.REQ_STATUS_TEHAI1.Style = "text-align: center; vertical-align: middle"
Me.REQ_STATUS_TEHAI1.Text = Nothing
Me.REQ_STATUS_TEHAI1.Top = 0.8740158!
Me.REQ_STATUS_TEHAI1.Width = 0.3208661!
'
'TIME_STAMP_BYL1
'
Me.TIME_STAMP_BYL1.DataField = "TIME_STAMP_BYL"
Me.TIME_STAMP_BYL1.Height = 0.2!
Me.TIME_STAMP_BYL1.Left = 5.787402!
Me.TIME_STAMP_BYL1.Name = "TIME_STAMP_BYL1"
Me.TIME_STAMP_BYL1.Style = "vertical-align: middle"
Me.TIME_STAMP_BYL1.Text = Nothing
Me.TIME_STAMP_BYL1.Top = 0.8740158!
Me.TIME_STAMP_BYL1.Width = 1.364567!
'
'DR_NAME
'
Me.DR_NAME.DataField = "DR_NAME"
Me.DR_NAME.Height = 0.2!
Me.DR_NAME.Left = 1.323622!
Me.DR_NAME.Name = "DR_NAME"
Me.DR_NAME.Style = "vertical-align: middle"
Me.DR_NAME.Text = Nothing
Me.DR_NAME.Top = 1.274016!
Me.DR_NAME.Visible = false
Me.DR_NAME.Width = 2.23504!
'
'DrReport
'
Me.MasterReport = false
Me.PageSettings.PaperHeight = 11!
Me.PageSettings.PaperWidth = 8.5!
Me.PrintWidth = 7.165357!
Me.Sections.Add(Me.PageHeader)
Me.Sections.Add(Me.Detail)
Me.Sections.Add(Me.PageFooter)
Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; "& _ 
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
CType(Me.DR_SHISETSU_ADDRESS,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_SHISETSU_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.KOUENKAI_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label6,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label7,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label8,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label9,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label10,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label11,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label12,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label14,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label15,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label16,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label17,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label18,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.KOUENKAI_NO,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_STATUS_TEHAI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TIME_STAMP_BYL,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SANKASHA_ID,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_CD,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_NAME1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_KANA,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_YAKUWARI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_AGE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_SEX,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label226,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_TICKET_SEND_DAY2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label225,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FROM_DATE1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_NOTE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label224,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_PRT_NAME2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label223,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FROM_DATE2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label222,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label206,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.KOUENKAI_NAME2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME1_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_SHISETSU_NAME2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label184,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label187,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME1_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT1_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label189,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label155,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label158,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label160,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label156,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label175,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FUKURO1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label172,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label185,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label188,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label186,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label191,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label194,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FUKURO3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label195,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label198,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label200,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label162,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME1_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label165,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT1_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label167,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label163,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_DATE_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TEHAI_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label171,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label168,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FUKURO2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME2_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT2_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label216,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label215,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label214,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label211,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label208,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label201,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label199,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label190,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT1_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT2_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME2_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TO_DATE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_PRT_NAME1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label220,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FROM_DATE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label219,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FUKURO4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_DATE_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_KOTSUKIKAN_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_IRAINAIYOU_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TEHAI_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label174,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label173,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label159,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label157,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label154,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT1_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT2_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME1_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME2_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_BIN_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_KIBOU1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_TESURYO,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label87,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label92,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label91,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label90,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label89,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_10,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label88,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_10,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_10,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label86,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label85,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_9,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label84,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_9,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label83,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_9,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label82,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label81,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_8,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label80,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_8,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label79,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_8,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label78,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label77,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_7,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label76,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_7,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label66,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_7,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label65,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label64,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_6,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label63,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_6,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label62,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_6,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label61,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label60,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label59,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label58,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label57,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label56,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label54,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label53,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label52,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label51,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label50,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label49,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label48,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label47,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label46,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label45,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label44,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label72,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_DATE_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label73,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_TAXI_FROM_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label74,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_YOTEIKINGAKU_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label75,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label71,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TEHAI_TAXI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_HOTEL_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_ROOM_TYPE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_HOTELHI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_HOTELHI_TOZEI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_HOTELHI_CANCEL,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label70,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label69,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label35,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label34,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label32,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_MR_HOTEL_NOTE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label68,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label67,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label55,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_MR_O_TEHAI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_MR_F_TEHAI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_SEX,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_AGE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_KANA,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label13,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label25,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label20,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label19,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label21,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label22,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label23,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label24,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label26,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label27,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label28,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label29,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label30,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label31,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label33,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label36,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label37,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label38,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label39,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label40,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label41,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label42,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label43,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SHITEIGAI_RIYU,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_AREA,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_EIGYOSHO,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_ROMA,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_EMAIL_PC,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_EMAIL_KEITAI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_KEITAI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_TEL,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_SEND_SAKI_FS,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_SEND_SAKI_OTHER,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.COST_CENTER,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SHONIN_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SHONIN_DATE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TEHAI_HOTEL,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.HOTEL_IRAINAIYOU,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_HOTEL_DATE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_HAKUSU,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_HOTEL_SMOKING,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_HOTEL_NOTE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label94,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label95,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_KIBOU5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_BIN_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME2_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME1_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT2_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT1_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_DATE_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_KOTSUKIKAN_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_IRAINAIYOU_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TEHAI_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_KIBOU4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_BIN_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME2_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME1_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT2_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT1_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_DATE_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_KOTSUKIKAN_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_IRAINAIYOU_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TEHAI_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_KIBOU5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_BIN_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME2_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME1_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT2_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT1_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_DATE_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_KOTSUKIKAN_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_IRAINAIYOU_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TEHAI_5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_KIBOU2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_BIN_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME2_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TIME1_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT2_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_AIRPORT1_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_DATE_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_KOTSUKIKAN_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_IRAINAIYOU_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_KIBOU2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_BIN_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME2_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME1_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT2_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT1_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_DATE_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_KOTSUKIKAN_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_IRAINAIYOU_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TEHAI_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TEHAI_2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label108,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label107,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label106,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label105,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label104,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label103,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label102,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label101,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label100,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label99,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label98,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.FUKURO5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label96,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label97,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label109,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label110,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label111,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label112,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label113,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label114,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label115,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label116,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label117,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.OURO5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label118,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label119,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label120,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label121,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label122,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label123,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label124,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label125,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label126,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label127,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label128,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label129,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label130,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label131,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label132,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label133,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label134,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label135,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label136,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label137,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label138,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label139,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.OURO2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_KIBOU4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_BIN_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME2_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME1_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT2_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT1_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_KIBOU1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_BIN_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TIME2_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_AIRPORT2_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label140,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label141,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label142,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label143,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label144,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label145,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label146,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label147,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label148,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label149,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label150,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label151,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label152,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label153,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.OURO4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label161,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label164,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label166,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.OURO1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label169,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label170,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label176,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label177,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label178,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label179,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label181,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label182,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label183,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_IRAINAIYOU_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_KOTSUKIKAN_1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TEHAI_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_IRAINAIYOU_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_KOTSUKIKAN_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_DATE_4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_SEAT_KIBOU3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_BIN_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_DATE_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_KOTSUKIKAN_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_IRAINAIYOU_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_KIBOU3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_SEAT_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_BIN_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_DATE_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_KOTSUKIKAN_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_IRAINAIYOU_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_F_TEHAI_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_O_TEHAI_3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label192,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label193,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label196,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label197,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label202,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label203,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label204,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label205,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.OURO3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_SHISETSU_ADDRESS2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label207,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label209,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label210,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label212,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label213,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label217,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.KOUENKAI_NO2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_STATUS_TEHAI2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TIME_STAMP_BYL2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SANKASHA_ID2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_CD2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_NAME2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_KANA2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_AGE2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_SEX2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label180,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label218,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.KAIJO_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label221,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.KAIJO_NAME2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PRINT_USER,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PRINT_DATE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label227,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MR_BU,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label93,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label228,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label229,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label230,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label231,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label232,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label233,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label234,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.Label235,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_AIR_FARE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_AIR_CANCELLATION,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_RAIL_FARE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_RAIL_CANCELLATION,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_MR_HOTELHI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_MR_HOTELHI_TOZEI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_MR_KOTSUHI,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_OTHER_FARE,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_OTHER_CANCELLATION,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TAXI_PRT_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ANS_TICKET_SEND_DAY,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.REQ_STATUS_TEHAI1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TIME_STAMP_BYL1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DR_NAME,System.ComponentModel.ISupportInitialize).EndInit
CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
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
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents Label36 As DataDynamics.ActiveReports.Label
    Private WithEvents Label37 As DataDynamics.ActiveReports.Label
    Private WithEvents Label38 As DataDynamics.ActiveReports.Label
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents Label44 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKASHA_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_KANA As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents COST_CENTER As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents SHONIN_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents TEHAI_HOTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents HOTEL_IRAINAIYOU As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HAKUSU As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL_SMOKING As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_HOTEL_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
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
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents Line33 As DataDynamics.ActiveReports.Line
    Private WithEvents Line37 As DataDynamics.ActiveReports.Line
    Private WithEvents Line38 As DataDynamics.ActiveReports.Line
    Private WithEvents Line51 As DataDynamics.ActiveReports.Line
    Private WithEvents Line52 As DataDynamics.ActiveReports.Line
    Private WithEvents MR_SEX As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_AGE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line55 As DataDynamics.ActiveReports.Line
    Private WithEvents Label55 As DataDynamics.ActiveReports.Label
    Private WithEvents Label67 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_MR_O_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_F_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label68 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_MR_HOTEL_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label70 As DataDynamics.ActiveReports.Label
    Private WithEvents Label69 As DataDynamics.ActiveReports.Label
    Private WithEvents Label35 As DataDynamics.ActiveReports.Label
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_HOTEL_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_ROOM_TYPE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_HOTELHI As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_HOTELHI_TOZEI As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_HOTELHI_CANCEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label71 As DataDynamics.ActiveReports.Label
    Private WithEvents TEHAI_TAXI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label72 As DataDynamics.ActiveReports.Label
    Private WithEvents Label73 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label74 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label75 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label46 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label47 As DataDynamics.ActiveReports.Label
    Private WithEvents Label48 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label49 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label50 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label51 As DataDynamics.ActiveReports.Label
    Private WithEvents Label52 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label53 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label54 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label56 As DataDynamics.ActiveReports.Label
    Private WithEvents Label57 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label58 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label59 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label60 As DataDynamics.ActiveReports.Label
    Private WithEvents Label61 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label62 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label63 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label64 As DataDynamics.ActiveReports.Label
    Private WithEvents Label65 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label66 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label76 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label77 As DataDynamics.ActiveReports.Label
    Private WithEvents Label78 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label79 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label80 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label81 As DataDynamics.ActiveReports.Label
    Private WithEvents Label82 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label83 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label84 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label85 As DataDynamics.ActiveReports.Label
    Private WithEvents Label86 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label87 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label88 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_DATE_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label89 As DataDynamics.ActiveReports.Label
    Private WithEvents Label90 As DataDynamics.ActiveReports.Label
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line34 As DataDynamics.ActiveReports.Line
    Private WithEvents Line35 As DataDynamics.ActiveReports.Line
    Private WithEvents Line36 As DataDynamics.ActiveReports.Line
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
    Private WithEvents Line53 As DataDynamics.ActiveReports.Line
    Private WithEvents Line57 As DataDynamics.ActiveReports.Line
    Private WithEvents Line58 As DataDynamics.ActiveReports.Line
    Private WithEvents Line59 As DataDynamics.ActiveReports.Line
    Private WithEvents Line60 As DataDynamics.ActiveReports.Line
    Private WithEvents Line61 As DataDynamics.ActiveReports.Line
    Private WithEvents Line62 As DataDynamics.ActiveReports.Line
    Private WithEvents Line63 As DataDynamics.ActiveReports.Line
    Private WithEvents Line64 As DataDynamics.ActiveReports.Line
    Private WithEvents Line65 As DataDynamics.ActiveReports.Line
    Private WithEvents Label91 As DataDynamics.ActiveReports.Label
    Private WithEvents Label92 As DataDynamics.ActiveReports.Label
    Private WithEvents Line66 As DataDynamics.ActiveReports.Line
    Private WithEvents PageBreak1 As DataDynamics.ActiveReports.PageBreak
    Private WithEvents Line68 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label94 As DataDynamics.ActiveReports.Label
    Private WithEvents Label95 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_F_SEAT_KIBOU4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_KIBOU5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_KIBOU2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_KIBOU2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label108 As DataDynamics.ActiveReports.Label
    Private WithEvents Label107 As DataDynamics.ActiveReports.Label
    Private WithEvents Label106 As DataDynamics.ActiveReports.Label
    Private WithEvents Label105 As DataDynamics.ActiveReports.Label
    Private WithEvents Label104 As DataDynamics.ActiveReports.Label
    Private WithEvents Label103 As DataDynamics.ActiveReports.Label
    Private WithEvents Label102 As DataDynamics.ActiveReports.Label
    Private WithEvents Label101 As DataDynamics.ActiveReports.Label
    Private WithEvents Label100 As DataDynamics.ActiveReports.Label
    Private WithEvents Label99 As DataDynamics.ActiveReports.Label
    Private WithEvents Label98 As DataDynamics.ActiveReports.Label
    Private WithEvents FUKURO5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label96 As DataDynamics.ActiveReports.Label
    Private WithEvents Label97 As DataDynamics.ActiveReports.Label
    Private WithEvents Label109 As DataDynamics.ActiveReports.Label
    Private WithEvents Label110 As DataDynamics.ActiveReports.Label
    Private WithEvents Label111 As DataDynamics.ActiveReports.Label
    Private WithEvents Label112 As DataDynamics.ActiveReports.Label
    Private WithEvents Label113 As DataDynamics.ActiveReports.Label
    Private WithEvents Label114 As DataDynamics.ActiveReports.Label
    Private WithEvents Label115 As DataDynamics.ActiveReports.Label
    Private WithEvents Label116 As DataDynamics.ActiveReports.Label
    Private WithEvents Label117 As DataDynamics.ActiveReports.Label
    Private WithEvents OURO5 As DataDynamics.ActiveReports.Label
    Private WithEvents Line70 As DataDynamics.ActiveReports.Line
    Private WithEvents Label118 As DataDynamics.ActiveReports.Label
    Private WithEvents Label119 As DataDynamics.ActiveReports.Label
    Private WithEvents Label120 As DataDynamics.ActiveReports.Label
    Private WithEvents Label121 As DataDynamics.ActiveReports.Label
    Private WithEvents Label122 As DataDynamics.ActiveReports.Label
    Private WithEvents Label123 As DataDynamics.ActiveReports.Label
    Private WithEvents Label124 As DataDynamics.ActiveReports.Label
    Private WithEvents Label125 As DataDynamics.ActiveReports.Label
    Private WithEvents Label126 As DataDynamics.ActiveReports.Label
    Private WithEvents Label127 As DataDynamics.ActiveReports.Label
    Private WithEvents Label128 As DataDynamics.ActiveReports.Label
    Private WithEvents FUKURO2 As DataDynamics.ActiveReports.Label
    Private WithEvents Line71 As DataDynamics.ActiveReports.Line
    Private WithEvents Label129 As DataDynamics.ActiveReports.Label
    Private WithEvents Label130 As DataDynamics.ActiveReports.Label
    Private WithEvents Label131 As DataDynamics.ActiveReports.Label
    Private WithEvents Label132 As DataDynamics.ActiveReports.Label
    Private WithEvents Label133 As DataDynamics.ActiveReports.Label
    Private WithEvents Label134 As DataDynamics.ActiveReports.Label
    Private WithEvents Label135 As DataDynamics.ActiveReports.Label
    Private WithEvents Label136 As DataDynamics.ActiveReports.Label
    Private WithEvents Label137 As DataDynamics.ActiveReports.Label
    Private WithEvents Label138 As DataDynamics.ActiveReports.Label
    Private WithEvents Label139 As DataDynamics.ActiveReports.Label
    Private WithEvents OURO2 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_O_SEAT_KIBOU4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_KIBOU1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_KIBOU1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label140 As DataDynamics.ActiveReports.Label
    Private WithEvents Label141 As DataDynamics.ActiveReports.Label
    Private WithEvents Label142 As DataDynamics.ActiveReports.Label
    Private WithEvents Label143 As DataDynamics.ActiveReports.Label
    Private WithEvents Label144 As DataDynamics.ActiveReports.Label
    Private WithEvents Label145 As DataDynamics.ActiveReports.Label
    Private WithEvents Label146 As DataDynamics.ActiveReports.Label
    Private WithEvents FUKURO4 As DataDynamics.ActiveReports.Label
    Private WithEvents Line73 As DataDynamics.ActiveReports.Line
    Private WithEvents Label147 As DataDynamics.ActiveReports.Label
    Private WithEvents Label148 As DataDynamics.ActiveReports.Label
    Private WithEvents Label149 As DataDynamics.ActiveReports.Label
    Private WithEvents Label150 As DataDynamics.ActiveReports.Label
    Private WithEvents Label151 As DataDynamics.ActiveReports.Label
    Private WithEvents Label152 As DataDynamics.ActiveReports.Label
    Private WithEvents Label153 As DataDynamics.ActiveReports.Label
    Private WithEvents OURO4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label154 As DataDynamics.ActiveReports.Label
    Private WithEvents Label155 As DataDynamics.ActiveReports.Label
    Private WithEvents Label156 As DataDynamics.ActiveReports.Label
    Private WithEvents Label157 As DataDynamics.ActiveReports.Label
    Private WithEvents Label158 As DataDynamics.ActiveReports.Label
    Private WithEvents Label159 As DataDynamics.ActiveReports.Label
    Private WithEvents Label160 As DataDynamics.ActiveReports.Label
    Private WithEvents Line75 As DataDynamics.ActiveReports.Line
    Private WithEvents Label161 As DataDynamics.ActiveReports.Label
    Private WithEvents Label162 As DataDynamics.ActiveReports.Label
    Private WithEvents Label163 As DataDynamics.ActiveReports.Label
    Private WithEvents Label164 As DataDynamics.ActiveReports.Label
    Private WithEvents Label165 As DataDynamics.ActiveReports.Label
    Private WithEvents Label166 As DataDynamics.ActiveReports.Label
    Private WithEvents Label167 As DataDynamics.ActiveReports.Label
    Private WithEvents OURO1 As DataDynamics.ActiveReports.Label
    Private WithEvents Label168 As DataDynamics.ActiveReports.Label
    Private WithEvents Label169 As DataDynamics.ActiveReports.Label
    Private WithEvents Label170 As DataDynamics.ActiveReports.Label
    Private WithEvents Label171 As DataDynamics.ActiveReports.Label
    Private WithEvents Label172 As DataDynamics.ActiveReports.Label
    Private WithEvents Label173 As DataDynamics.ActiveReports.Label
    Private WithEvents Label174 As DataDynamics.ActiveReports.Label
    Private WithEvents Label175 As DataDynamics.ActiveReports.Label
    Private WithEvents Label176 As DataDynamics.ActiveReports.Label
    Private WithEvents Label177 As DataDynamics.ActiveReports.Label
    Private WithEvents Label178 As DataDynamics.ActiveReports.Label
    Private WithEvents Label179 As DataDynamics.ActiveReports.Label
    Private WithEvents Label180 As DataDynamics.ActiveReports.Label
    Private WithEvents Label181 As DataDynamics.ActiveReports.Label
    Private WithEvents Label182 As DataDynamics.ActiveReports.Label
    Private WithEvents Label183 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_O_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line76 As DataDynamics.ActiveReports.Line
    Private WithEvents REQ_F_SEAT_KIBOU3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_KIBOU3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_SEAT_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_BIN_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME2_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TIME1_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT2_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_AIRPORT1_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_KOTSUKIKAN_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_IRAINAIYOU_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label184 As DataDynamics.ActiveReports.Label
    Private WithEvents Label185 As DataDynamics.ActiveReports.Label
    Private WithEvents Label186 As DataDynamics.ActiveReports.Label
    Private WithEvents Label187 As DataDynamics.ActiveReports.Label
    Private WithEvents Label188 As DataDynamics.ActiveReports.Label
    Private WithEvents Label189 As DataDynamics.ActiveReports.Label
    Private WithEvents Label190 As DataDynamics.ActiveReports.Label
    Private WithEvents Label191 As DataDynamics.ActiveReports.Label
    Private WithEvents Label192 As DataDynamics.ActiveReports.Label
    Private WithEvents Label193 As DataDynamics.ActiveReports.Label
    Private WithEvents Label194 As DataDynamics.ActiveReports.Label
    Private WithEvents FUKURO3 As DataDynamics.ActiveReports.Label
    Private WithEvents Line78 As DataDynamics.ActiveReports.Line
    Private WithEvents Label195 As DataDynamics.ActiveReports.Label
    Private WithEvents Label196 As DataDynamics.ActiveReports.Label
    Private WithEvents Label197 As DataDynamics.ActiveReports.Label
    Private WithEvents Label198 As DataDynamics.ActiveReports.Label
    Private WithEvents Label199 As DataDynamics.ActiveReports.Label
    Private WithEvents Label200 As DataDynamics.ActiveReports.Label
    Private WithEvents Label201 As DataDynamics.ActiveReports.Label
    Private WithEvents Label202 As DataDynamics.ActiveReports.Label
    Private WithEvents Label203 As DataDynamics.ActiveReports.Label
    Private WithEvents Label204 As DataDynamics.ActiveReports.Label
    Private WithEvents Label205 As DataDynamics.ActiveReports.Label
    Private WithEvents OURO3 As DataDynamics.ActiveReports.Label
    Private WithEvents Line79 As DataDynamics.ActiveReports.Line
    Private WithEvents Line80 As DataDynamics.ActiveReports.Line
    Private WithEvents Line87 As DataDynamics.ActiveReports.Line
    Private WithEvents Line88 As DataDynamics.ActiveReports.Line
    Private WithEvents Line89 As DataDynamics.ActiveReports.Line
    Private WithEvents Line90 As DataDynamics.ActiveReports.Line
    Private WithEvents Line91 As DataDynamics.ActiveReports.Line
    Private WithEvents Line92 As DataDynamics.ActiveReports.Line
    Private WithEvents Line93 As DataDynamics.ActiveReports.Line
    Private WithEvents Line94 As DataDynamics.ActiveReports.Line
    Private WithEvents Line95 As DataDynamics.ActiveReports.Line
    Private WithEvents Line96 As DataDynamics.ActiveReports.Line
    Private WithEvents Line101 As DataDynamics.ActiveReports.Line
    Private WithEvents Line112 As DataDynamics.ActiveReports.Line
    Private WithEvents Line113 As DataDynamics.ActiveReports.Line
    Private WithEvents Line114 As DataDynamics.ActiveReports.Line
    Private WithEvents Line115 As DataDynamics.ActiveReports.Line
    Private WithEvents Line116 As DataDynamics.ActiveReports.Line
    Private WithEvents Line117 As DataDynamics.ActiveReports.Line
    Private WithEvents Line118 As DataDynamics.ActiveReports.Line
    Private WithEvents Line119 As DataDynamics.ActiveReports.Line
    Private WithEvents Line120 As DataDynamics.ActiveReports.Line
    Private WithEvents Line121 As DataDynamics.ActiveReports.Line
    Private WithEvents Line123 As DataDynamics.ActiveReports.Line
    Private WithEvents Line124 As DataDynamics.ActiveReports.Line
    Private WithEvents Line125 As DataDynamics.ActiveReports.Line
    Private WithEvents Line126 As DataDynamics.ActiveReports.Line
    Private WithEvents Line127 As DataDynamics.ActiveReports.Line
    Private WithEvents Line152 As DataDynamics.ActiveReports.Line
    Private WithEvents Line173 As DataDynamics.ActiveReports.Line
    Private WithEvents DR_SHISETSU_ADDRESS2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SHISETSU_NAME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label206 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NAME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label207 As DataDynamics.ActiveReports.Label
    Private WithEvents Label208 As DataDynamics.ActiveReports.Label
    Private WithEvents Label209 As DataDynamics.ActiveReports.Label
    Private WithEvents Label210 As DataDynamics.ActiveReports.Label
    Private WithEvents Label211 As DataDynamics.ActiveReports.Label
    Private WithEvents Label212 As DataDynamics.ActiveReports.Label
    Private WithEvents Label213 As DataDynamics.ActiveReports.Label
    Private WithEvents Label214 As DataDynamics.ActiveReports.Label
    Private WithEvents Label215 As DataDynamics.ActiveReports.Label
    Private WithEvents Label216 As DataDynamics.ActiveReports.Label
    Private WithEvents Label217 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKASHA_ID2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_CD2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_KANA2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_AGE2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line67 As DataDynamics.ActiveReports.Line
    Private WithEvents Line192 As DataDynamics.ActiveReports.Line
    Private WithEvents Line193 As DataDynamics.ActiveReports.Line
    Private WithEvents Line194 As DataDynamics.ActiveReports.Line
    Private WithEvents DR_SEX2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line195 As DataDynamics.ActiveReports.Line
    Private WithEvents Line196 As DataDynamics.ActiveReports.Line
    Private WithEvents Line198 As DataDynamics.ActiveReports.Line
    Private WithEvents Line199 As DataDynamics.ActiveReports.Line
    Private WithEvents Line200 As DataDynamics.ActiveReports.Line
    Private WithEvents Line201 As DataDynamics.ActiveReports.Line
    Private WithEvents Line203 As DataDynamics.ActiveReports.Line
    Private WithEvents TAXI_TESURYO As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line74 As DataDynamics.ActiveReports.Line
    Private WithEvents Line81 As DataDynamics.ActiveReports.Line
    Private WithEvents Line82 As DataDynamics.ActiveReports.Line
    Private WithEvents Line97 As DataDynamics.ActiveReports.Line
    Private WithEvents Line99 As DataDynamics.ActiveReports.Line
    Private WithEvents Line100 As DataDynamics.ActiveReports.Line
    Private WithEvents Line102 As DataDynamics.ActiveReports.Line
    Private WithEvents Line103 As DataDynamics.ActiveReports.Line
    Private WithEvents Line104 As DataDynamics.ActiveReports.Line
    Private WithEvents Line77 As DataDynamics.ActiveReports.Line
    Private WithEvents Line83 As DataDynamics.ActiveReports.Line
    Private WithEvents Line98 As DataDynamics.ActiveReports.Line
    Private WithEvents Line105 As DataDynamics.ActiveReports.Line
    Private WithEvents Line106 As DataDynamics.ActiveReports.Line
    Private WithEvents Line107 As DataDynamics.ActiveReports.Line
    Private WithEvents Line108 As DataDynamics.ActiveReports.Line
    Private WithEvents Line109 As DataDynamics.ActiveReports.Line
    Private WithEvents Line110 As DataDynamics.ActiveReports.Line
    Private WithEvents Line111 As DataDynamics.ActiveReports.Line
    Private WithEvents Line132 As DataDynamics.ActiveReports.Line
    Private WithEvents Line133 As DataDynamics.ActiveReports.Line
    Private WithEvents Line134 As DataDynamics.ActiveReports.Line
    Private WithEvents Line135 As DataDynamics.ActiveReports.Line
    Private WithEvents Line136 As DataDynamics.ActiveReports.Line
    Private WithEvents Line137 As DataDynamics.ActiveReports.Line
    Private WithEvents Line138 As DataDynamics.ActiveReports.Line
    Private WithEvents Line139 As DataDynamics.ActiveReports.Line
    Private WithEvents Line140 As DataDynamics.ActiveReports.Line
    Private WithEvents Line141 As DataDynamics.ActiveReports.Line
    Private WithEvents Line153 As DataDynamics.ActiveReports.Line
    Private WithEvents FUKURO1 As DataDynamics.ActiveReports.Label
    Private WithEvents Line84 As DataDynamics.ActiveReports.Line
    Private WithEvents Line69 As DataDynamics.ActiveReports.Line
    Private WithEvents Line122 As DataDynamics.ActiveReports.Line
    Private WithEvents Line85 As DataDynamics.ActiveReports.Line
    Private WithEvents Line86 As DataDynamics.ActiveReports.Line
    Private WithEvents Line154 As DataDynamics.ActiveReports.Line
    Private WithEvents Line155 As DataDynamics.ActiveReports.Line
    Private WithEvents Line156 As DataDynamics.ActiveReports.Line
    Private WithEvents REQ_F_SEAT_KIBOU5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_SEAT_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_BIN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TIME1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT2_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_AIRPORT1_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_KOTSUKIKAN_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_IRAINAIYOU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line72 As DataDynamics.ActiveReports.Line
    Private WithEvents Line128 As DataDynamics.ActiveReports.Line
    Private WithEvents Line129 As DataDynamics.ActiveReports.Line
    Private WithEvents Line130 As DataDynamics.ActiveReports.Line
    Private WithEvents Line131 As DataDynamics.ActiveReports.Line
    Private WithEvents Line54 As DataDynamics.ActiveReports.Line
    Private WithEvents Line142 As DataDynamics.ActiveReports.Line
    Private WithEvents Line143 As DataDynamics.ActiveReports.Line
    Private WithEvents Line144 As DataDynamics.ActiveReports.Line
    Private WithEvents Line145 As DataDynamics.ActiveReports.Line
    Private WithEvents Line146 As DataDynamics.ActiveReports.Line
    Private WithEvents Line147 As DataDynamics.ActiveReports.Line
    Private WithEvents Line148 As DataDynamics.ActiveReports.Line
    Private WithEvents Line149 As DataDynamics.ActiveReports.Line
    Private WithEvents Line150 As DataDynamics.ActiveReports.Line
    Private WithEvents Line151 As DataDynamics.ActiveReports.Line
    Private WithEvents Line157 As DataDynamics.ActiveReports.Line
    Private WithEvents Line158 As DataDynamics.ActiveReports.Line
    Private WithEvents Line159 As DataDynamics.ActiveReports.Line
    Private WithEvents Line160 As DataDynamics.ActiveReports.Line
    Private WithEvents Line161 As DataDynamics.ActiveReports.Line
    Private WithEvents Line162 As DataDynamics.ActiveReports.Line
    Private WithEvents Line163 As DataDynamics.ActiveReports.Line
    Private WithEvents Line164 As DataDynamics.ActiveReports.Line
    Private WithEvents Label218 As DataDynamics.ActiveReports.Label
    Private WithEvents KAIJO_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label219 As DataDynamics.ActiveReports.Label
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label220 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_PRT_NAME1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TO_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_PRT_NAME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label223 As DataDynamics.ActiveReports.Label
    Private WithEvents FROM_DATE2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label222 As DataDynamics.ActiveReports.Label
    Private WithEvents Label221 As DataDynamics.ActiveReports.Label
    Private WithEvents KAIJO_NAME2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents FROM_DATE1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_USER As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label224 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TICKET_SEND_DAY2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label225 As DataDynamics.ActiveReports.Label
    Private WithEvents Label226 As DataDynamics.ActiveReports.Label
    Private WithEvents MR_BU As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label227 As DataDynamics.ActiveReports.Label
    Private WithEvents Label93 As DataDynamics.ActiveReports.Label
    Private WithEvents Label228 As DataDynamics.ActiveReports.Label
    Private WithEvents Label229 As DataDynamics.ActiveReports.Label
    Private WithEvents Label230 As DataDynamics.ActiveReports.Label
    Private WithEvents Label231 As DataDynamics.ActiveReports.Label
    Private WithEvents Label232 As DataDynamics.ActiveReports.Label
    Private WithEvents Label235 As DataDynamics.ActiveReports.Label
    Private WithEvents Label234 As DataDynamics.ActiveReports.Label
    Private WithEvents Label233 As DataDynamics.ActiveReports.Label
    Private WithEvents Line56 As DataDynamics.ActiveReports.Line
    Private WithEvents Line165 As DataDynamics.ActiveReports.Line
    Private WithEvents Line166 As DataDynamics.ActiveReports.Line
    Private WithEvents Line167 As DataDynamics.ActiveReports.Line
    Private WithEvents Line168 As DataDynamics.ActiveReports.Line
    Private WithEvents Line169 As DataDynamics.ActiveReports.Line
    Private WithEvents Line170 As DataDynamics.ActiveReports.Line
    Private WithEvents ANS_AIR_FARE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_AIR_CANCELLATION As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_RAIL_FARE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_RAIL_CANCELLATION As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_MR_HOTELHI As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_MR_HOTELHI_TOZEI As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_OTHER_FARE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_OTHER_CANCELLATION As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_MR_KOTSUHI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_PRT_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TICKET_SEND_DAY As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
End Class
