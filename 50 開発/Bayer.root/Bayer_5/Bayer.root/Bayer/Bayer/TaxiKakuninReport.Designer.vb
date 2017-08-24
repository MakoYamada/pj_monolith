<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TaxiKakuninReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TaxiKakuninReport))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Label198 = New DataDynamics.ActiveReports.Label
        Me.Label201 = New DataDynamics.ActiveReports.Label
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.SANKASHA_ID = New DataDynamics.ActiveReports.TextBox
        Me.DR_CD = New DataDynamics.ActiveReports.TextBox
        Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line51 = New DataDynamics.ActiveReports.Line
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.MR_SEND_SAKI_OTHER = New DataDynamics.ActiveReports.TextBox
        Me.Label174 = New DataDynamics.ActiveReports.Label
        Me.KINKYU_FLAG = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_16 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_16 = New DataDynamics.ActiveReports.TextBox
        Me.Label144 = New DataDynamics.ActiveReports.Label
        Me.Label53 = New DataDynamics.ActiveReports.Label
        Me.Label49 = New DataDynamics.ActiveReports.Label
        Me.Label45 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label202 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_FROM_1 = New DataDynamics.ActiveReports.TextBox
        Me.DANTAI_CODE = New DataDynamics.ActiveReports.TextBox
        Me.Label200 = New DataDynamics.ActiveReports.Label
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.Label185 = New DataDynamics.ActiveReports.Label
        Me.REQ_MR_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.Label178 = New DataDynamics.ActiveReports.Label
        Me.Label184 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_HOTEL = New DataDynamics.ActiveReports.TextBox
        Me.Label183 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_KOTSU = New DataDynamics.ActiveReports.TextBox
        Me.Label182 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Label180 = New DataDynamics.ActiveReports.Label
        Me.Label124 = New DataDynamics.ActiveReports.Label
        Me.Label90 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_10 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_10 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_10 = New DataDynamics.ActiveReports.TextBox
        Me.Label86 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_9 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_9 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_9 = New DataDynamics.ActiveReports.TextBox
        Me.Label82 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_8 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_8 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_8 = New DataDynamics.ActiveReports.TextBox
        Me.Label78 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_7 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_7 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_7 = New DataDynamics.ActiveReports.TextBox
        Me.Label65 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_6 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_6 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_6 = New DataDynamics.ActiveReports.TextBox
        Me.Label61 = New DataDynamics.ActiveReports.Label
        Me.Label60 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_5 = New DataDynamics.ActiveReports.TextBox
        Me.Label58 = New DataDynamics.ActiveReports.Label
        Me.TAXI_YOTEIKINGAKU_5 = New DataDynamics.ActiveReports.TextBox
        Me.Label57 = New DataDynamics.ActiveReports.Label
        Me.Label56 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_4 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_4 = New DataDynamics.ActiveReports.TextBox
        Me.Label52 = New DataDynamics.ActiveReports.Label
        Me.Label51 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_3 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_3 = New DataDynamics.ActiveReports.TextBox
        Me.Label48 = New DataDynamics.ActiveReports.Label
        Me.Label47 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_TAXI_FROM_2 = New DataDynamics.ActiveReports.TextBox
        Me.TAXI_YOTEIKINGAKU_2 = New DataDynamics.ActiveReports.TextBox
        Me.KOUTEI_1 = New DataDynamics.ActiveReports.Label
        Me.REQ_TAXI_DATE_1 = New DataDynamics.ActiveReports.TextBox
        Me.Label73 = New DataDynamics.ActiveReports.Label
        Me.Label74 = New DataDynamics.ActiveReports.Label
        Me.TAXI_YOTEIKINGAKU_1 = New DataDynamics.ActiveReports.TextBox
        Me.Label71 = New DataDynamics.ActiveReports.Label
        Me.TEHAI_TAXI = New DataDynamics.ActiveReports.TextBox
        Me.DR_SHISETSU_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Line62 = New DataDynamics.ActiveReports.Line
        Me.Line63 = New DataDynamics.ActiveReports.Line
        Me.Line163 = New DataDynamics.ActiveReports.Line
        Me.Line164 = New DataDynamics.ActiveReports.Line
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line42 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_DATE_1 = New DataDynamics.ActiveReports.TextBox
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_KENSHU_1 = New DataDynamics.ActiveReports.TextBox
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_NO_1 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_1 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_1 = New DataDynamics.ActiveReports.TextBox
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_DATE_2 = New DataDynamics.ActiveReports.TextBox
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_KENSHU_2 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_2 = New DataDynamics.ActiveReports.TextBox
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_HAKKO_DATE_2 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_2 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_3 = New DataDynamics.ActiveReports.TextBox
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_KENSHU_3 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_3 = New DataDynamics.ActiveReports.TextBox
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_HAKKO_DATE_3 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_3 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_4 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_4 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_4 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_4 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_4 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_5 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_5 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_5 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_5 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_5 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_6 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_6 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_6 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_6 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_6 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_7 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_7 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_7 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_7 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_7 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_8 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_8 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_8 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_8 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_8 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_9 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_9 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_9 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_9 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_9 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_10 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_10 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_10 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_10 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_10 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_11 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_11 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_11 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_11 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_11 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_12 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_12 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_12 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_12 = New DataDynamics.ActiveReports.TextBox
        Me.Label130 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_12 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_13 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_13 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_13 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_13 = New DataDynamics.ActiveReports.TextBox
        Me.Label136 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_13 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_14 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_14 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_14 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_14 = New DataDynamics.ActiveReports.TextBox
        Me.Label142 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_14 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_RMKS_15 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_15 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_15 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_15 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_15 = New DataDynamics.ActiveReports.TextBox
        Me.Label148 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_16 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_16 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_16 = New DataDynamics.ActiveReports.TextBox
        Me.Label154 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_17 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_17 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_17 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_17 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_17 = New DataDynamics.ActiveReports.TextBox
        Me.Label160 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_18 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_18 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_18 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_18 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_18 = New DataDynamics.ActiveReports.TextBox
        Me.Label166 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_19 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_19 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_19 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_19 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_19 = New DataDynamics.ActiveReports.TextBox
        Me.Label172 = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_RMKS_20 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_HAKKO_DATE_20 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_DATE_20 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_KENSHU_20 = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_NO_20 = New DataDynamics.ActiveReports.TextBox
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.Label38 = New DataDynamics.ActiveReports.Label
        Me.Label69 = New DataDynamics.ActiveReports.Label
        Me.Label94 = New DataDynamics.ActiveReports.Label
        Me.Label100 = New DataDynamics.ActiveReports.Label
        Me.Label106 = New DataDynamics.ActiveReports.Label
        Me.Label112 = New DataDynamics.ActiveReports.Label
        Me.Label118 = New DataDynamics.ActiveReports.Label
        Me.Line36 = New DataDynamics.ActiveReports.Line
        Me.Line104 = New DataDynamics.ActiveReports.Line
        Me.Label181 = New DataDynamics.ActiveReports.Label
        Me.REQ_O_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_O_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_1 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_2 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_3 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_4 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_F_TEHAI_5 = New DataDynamics.ActiveReports.TextBox
        Me.REQ_MR_O_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.REQ_MR_F_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Line37 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line152 = New DataDynamics.ActiveReports.Line
        Me.Line153 = New DataDynamics.ActiveReports.Line
        Me.Line155 = New DataDynamics.ActiveReports.Line
        Me.Line17 = New DataDynamics.ActiveReports.Line
        Me.Line107 = New DataDynamics.ActiveReports.Line
        Me.Line109 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line85 = New DataDynamics.ActiveReports.Line
        Me.Label46 = New DataDynamics.ActiveReports.Label
        Me.Line110 = New DataDynamics.ActiveReports.Line
        Me.Label50 = New DataDynamics.ActiveReports.Label
        Me.Line135 = New DataDynamics.ActiveReports.Line
        Me.Label203 = New DataDynamics.ActiveReports.Label
        Me.Label204 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Label205 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.Label35 = New DataDynamics.ActiveReports.Label
        Me.Label37 = New DataDynamics.ActiveReports.Label
        Me.Label54 = New DataDynamics.ActiveReports.Label
        Me.Label206 = New DataDynamics.ActiveReports.Label
        Me.Label207 = New DataDynamics.ActiveReports.Label
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.Label44 = New DataDynamics.ActiveReports.Label
        Me.Label55 = New DataDynamics.ActiveReports.Label
        Me.Label59 = New DataDynamics.ActiveReports.Label
        Me.Label62 = New DataDynamics.ActiveReports.Label
        Me.Label63 = New DataDynamics.ActiveReports.Label
        Me.Label64 = New DataDynamics.ActiveReports.Label
        Me.Label67 = New DataDynamics.ActiveReports.Label
        Me.Label68 = New DataDynamics.ActiveReports.Label
        Me.Label70 = New DataDynamics.ActiveReports.Label
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.Label75 = New DataDynamics.ActiveReports.Label
        Me.Label91 = New DataDynamics.ActiveReports.Label
        Me.Label92 = New DataDynamics.ActiveReports.Label
        Me.Label93 = New DataDynamics.ActiveReports.Label
        Me.Label95 = New DataDynamics.ActiveReports.Label
        Me.Label208 = New DataDynamics.ActiveReports.Label
        Me.Label209 = New DataDynamics.ActiveReports.Label
        Me.Label210 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label66 = New DataDynamics.ActiveReports.Label
        Me.Label76 = New DataDynamics.ActiveReports.Label
        Me.Label77 = New DataDynamics.ActiveReports.Label
        Me.Label79 = New DataDynamics.ActiveReports.Label
        Me.Label80 = New DataDynamics.ActiveReports.Label
        Me.Label81 = New DataDynamics.ActiveReports.Label
        Me.Label96 = New DataDynamics.ActiveReports.Label
        Me.Label97 = New DataDynamics.ActiveReports.Label
        Me.Label98 = New DataDynamics.ActiveReports.Label
        Me.Label99 = New DataDynamics.ActiveReports.Label
        Me.Label101 = New DataDynamics.ActiveReports.Label
        Me.Label211 = New DataDynamics.ActiveReports.Label
        Me.Label212 = New DataDynamics.ActiveReports.Label
        Me.Label213 = New DataDynamics.ActiveReports.Label
        Me.Label214 = New DataDynamics.ActiveReports.Label
        Me.Label215 = New DataDynamics.ActiveReports.Label
        Me.Label216 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Label83 = New DataDynamics.ActiveReports.Label
        Me.Label84 = New DataDynamics.ActiveReports.Label
        Me.Label85 = New DataDynamics.ActiveReports.Label
        Me.Label102 = New DataDynamics.ActiveReports.Label
        Me.Label103 = New DataDynamics.ActiveReports.Label
        Me.Label104 = New DataDynamics.ActiveReports.Label
        Me.Label105 = New DataDynamics.ActiveReports.Label
        Me.Label72 = New DataDynamics.ActiveReports.Label
        Me.Label87 = New DataDynamics.ActiveReports.Label
        Me.Label88 = New DataDynamics.ActiveReports.Label
        Me.Label89 = New DataDynamics.ActiveReports.Label
        Me.Label107 = New DataDynamics.ActiveReports.Label
        Me.Label108 = New DataDynamics.ActiveReports.Label
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line41 = New DataDynamics.ActiveReports.Line
        Me.Line111 = New DataDynamics.ActiveReports.Line
        Me.Line136 = New DataDynamics.ActiveReports.Line
        Me.Line106 = New DataDynamics.ActiveReports.Line
        Me.Line138 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line139 = New DataDynamics.ActiveReports.Line
        Me.Line140 = New DataDynamics.ActiveReports.Line
        Me.Line105 = New DataDynamics.ActiveReports.Line
        Me.Line143 = New DataDynamics.ActiveReports.Line
        Me.Line102 = New DataDynamics.ActiveReports.Line
        Me.Line144 = New DataDynamics.ActiveReports.Line
        Me.Line101 = New DataDynamics.ActiveReports.Line
        Me.Line145 = New DataDynamics.ActiveReports.Line
        Me.Line100 = New DataDynamics.ActiveReports.Line
        Me.Line15 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line20 = New DataDynamics.ActiveReports.Line
        Me.Line21 = New DataDynamics.ActiveReports.Line
        Me.Line22 = New DataDynamics.ActiveReports.Line
        Me.Line35 = New DataDynamics.ActiveReports.Line
        Me.Line49 = New DataDynamics.ActiveReports.Line
        Me.Line54 = New DataDynamics.ActiveReports.Line
        Me.Line58 = New DataDynamics.ActiveReports.Line
        Me.Line59 = New DataDynamics.ActiveReports.Line
        Me.Line60 = New DataDynamics.ActiveReports.Line
        Me.Line61 = New DataDynamics.ActiveReports.Line
        Me.Line64 = New DataDynamics.ActiveReports.Line
        Me.Line65 = New DataDynamics.ActiveReports.Line
        Me.Line67 = New DataDynamics.ActiveReports.Line
        Me.Line68 = New DataDynamics.ActiveReports.Line
        Me.Line69 = New DataDynamics.ActiveReports.Line
        Me.Line87 = New DataDynamics.ActiveReports.Line
        Me.Label109 = New DataDynamics.ActiveReports.Label
        Me.Label110 = New DataDynamics.ActiveReports.Label
        Me.Label111 = New DataDynamics.ActiveReports.Label
        Me.Label113 = New DataDynamics.ActiveReports.Label
        Me.Label114 = New DataDynamics.ActiveReports.Label
        Me.Label115 = New DataDynamics.ActiveReports.Label
        Me.Line99 = New DataDynamics.ActiveReports.Line
        Me.Label116 = New DataDynamics.ActiveReports.Label
        Me.Label117 = New DataDynamics.ActiveReports.Label
        Me.Label119 = New DataDynamics.ActiveReports.Label
        Me.Label120 = New DataDynamics.ActiveReports.Label
        Me.Label121 = New DataDynamics.ActiveReports.Label
        Me.Label122 = New DataDynamics.ActiveReports.Label
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Label123 = New DataDynamics.ActiveReports.Label
        Me.Label125 = New DataDynamics.ActiveReports.Label
        Me.Label126 = New DataDynamics.ActiveReports.Label
        Me.Label127 = New DataDynamics.ActiveReports.Label
        Me.Label128 = New DataDynamics.ActiveReports.Label
        Me.Label129 = New DataDynamics.ActiveReports.Label
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.Label131 = New DataDynamics.ActiveReports.Label
        Me.Label132 = New DataDynamics.ActiveReports.Label
        Me.Label133 = New DataDynamics.ActiveReports.Label
        Me.Label134 = New DataDynamics.ActiveReports.Label
        Me.Label135 = New DataDynamics.ActiveReports.Label
        Me.Label137 = New DataDynamics.ActiveReports.Label
        Me.Line27 = New DataDynamics.ActiveReports.Line
        Me.Label138 = New DataDynamics.ActiveReports.Label
        Me.Label139 = New DataDynamics.ActiveReports.Label
        Me.Label140 = New DataDynamics.ActiveReports.Label
        Me.Label141 = New DataDynamics.ActiveReports.Label
        Me.Label143 = New DataDynamics.ActiveReports.Label
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Label145 = New DataDynamics.ActiveReports.Label
        Me.Label146 = New DataDynamics.ActiveReports.Label
        Me.Label147 = New DataDynamics.ActiveReports.Label
        Me.Label149 = New DataDynamics.ActiveReports.Label
        Me.Label150 = New DataDynamics.ActiveReports.Label
        Me.Label151 = New DataDynamics.ActiveReports.Label
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.Label152 = New DataDynamics.ActiveReports.Label
        Me.Label153 = New DataDynamics.ActiveReports.Label
        Me.Label155 = New DataDynamics.ActiveReports.Label
        Me.Label156 = New DataDynamics.ActiveReports.Label
        Me.Label157 = New DataDynamics.ActiveReports.Label
        Me.Label158 = New DataDynamics.ActiveReports.Label
        Me.Line40 = New DataDynamics.ActiveReports.Line
        Me.Label159 = New DataDynamics.ActiveReports.Label
        Me.Label161 = New DataDynamics.ActiveReports.Label
        Me.Label162 = New DataDynamics.ActiveReports.Label
        Me.Label163 = New DataDynamics.ActiveReports.Label
        Me.Label164 = New DataDynamics.ActiveReports.Label
        Me.Label165 = New DataDynamics.ActiveReports.Label
        Me.Line43 = New DataDynamics.ActiveReports.Line
        Me.Label167 = New DataDynamics.ActiveReports.Label
        Me.Label168 = New DataDynamics.ActiveReports.Label
        Me.Label169 = New DataDynamics.ActiveReports.Label
        Me.Label170 = New DataDynamics.ActiveReports.Label
        Me.Label171 = New DataDynamics.ActiveReports.Label
        Me.Label173 = New DataDynamics.ActiveReports.Label
        Me.Line44 = New DataDynamics.ActiveReports.Line
        Me.Line74 = New DataDynamics.ActiveReports.Line
        Me.Line112 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Line45 = New DataDynamics.ActiveReports.Line
        Me.Line47 = New DataDynamics.ActiveReports.Line
        Me.Line48 = New DataDynamics.ActiveReports.Line
        Me.Line50 = New DataDynamics.ActiveReports.Line
        Me.Line52 = New DataDynamics.ActiveReports.Line
        Me.Line53 = New DataDynamics.ActiveReports.Line
        Me.Line55 = New DataDynamics.ActiveReports.Line
        Me.Line56 = New DataDynamics.ActiveReports.Line
        Me.Line57 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line66 = New DataDynamics.ActiveReports.Line
        Me.Line14 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line29 = New DataDynamics.ActiveReports.Line
        Me.Line76 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line70 = New DataDynamics.ActiveReports.Line
        Me.Line71 = New DataDynamics.ActiveReports.Line
        Me.Line72 = New DataDynamics.ActiveReports.Line
        Me.Line73 = New DataDynamics.ActiveReports.Line
        Me.Line28 = New DataDynamics.ActiveReports.Line
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Line75 = New DataDynamics.ActiveReports.Line
        Me.Line79 = New DataDynamics.ActiveReports.Line
        Me.Line38 = New DataDynamics.ActiveReports.Line
        Me.Line114 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line103 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.PRINT_USER = New DataDynamics.ActiveReports.TextBox
        Me.ANS_TAXI_MAISUU = New DataDynamics.ActiveReports.TextBox
        Me.LblMaisuu = New DataDynamics.ActiveReports.Label
        Me.ANS_TAXI_TESURYO = New DataDynamics.ActiveReports.TextBox
        Me.FROM_DATE = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label198, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label201, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEND_SAKI_OTHER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label174, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KINKYU_FLAG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label144, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label202, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DANTAI_CODE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label185, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label178, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label184, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_HOTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label183, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_KOTSU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label182, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label180, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label124, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label90, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label82, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_FROM_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KOUTEI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_TAXI_DATE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TAXI_YOTEIKINGAKU_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SHISETSU_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label130, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label136, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label142, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label148, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label154, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label160, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label166, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label172, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_RMKS_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_DATE_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_KENSHU_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_NO_20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label106, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label112, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label118, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label181, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_O_TEHAI_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_F_TEHAI_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_O_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_F_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label203, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label204, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label205, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label206, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label207, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label208, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label209, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label210, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label80, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label99, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label101, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label211, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label212, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label213, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label214, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label215, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label216, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label83, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label84, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label85, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label102, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label103, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label104, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label105, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label88, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label89, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label107, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label108, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label109, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label110, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label113, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label114, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label115, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label116, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label117, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label119, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label120, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label121, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label122, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label123, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label125, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label126, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label127, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label128, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label129, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label131, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label132, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label133, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label134, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label135, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label137, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label138, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label139, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label140, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label141, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label143, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label145, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label146, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label147, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label149, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label150, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label151, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label152, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label153, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label155, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label156, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label157, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label158, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label159, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label161, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label162, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label163, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label164, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label165, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label167, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label168, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label169, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label170, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label171, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label173, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRINT_USER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_MAISUU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LblMaisuu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANS_TAXI_TESURYO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label198, Me.Label201})
        Me.PageHeader.Height = 0.3976265!
        Me.PageHeader.Name = "PageHeader"
        '
        'Label198
        '
        Me.Label198.Height = 0.2!
        Me.Label198.HyperLink = Nothing
        Me.Label198.Left = 0.0!
        Me.Label198.Name = "Label198"
        Me.Label198.Style = "font-family: ＭＳ ゴシック; font-size: 10pt; font-weight: bold; vertical-align: middle"
        Me.Label198.Text = "【予備タクシーチケット担当者様へ】"
        Me.Label198.Top = 0.0!
        Me.Label198.Width = 2.483465!
        '
        'Label201
        '
        Me.Label201.Height = 0.2!
        Me.Label201.HyperLink = Nothing
        Me.Label201.Left = 2.576772!
        Me.Label201.Name = "Label201"
        Me.Label201.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal"
        Me.Label201.Text = "この用紙は、管理台帳としてご利用ください。"
        Me.Label201.Top = 0.0!
        Me.Label201.Width = 3.558662!
        '
        'Shape1
        '
        Me.Shape1.Height = 0.2740157!
        Me.Shape1.Left = 0.0!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 9.999999!
        Me.Shape1.Top = 0.0!
        Me.Shape1.Width = 7.649607!
        '
        'Label5
        '
        Me.Label5.Height = 0.2!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-family: ＭＳ ゴシック; font-size: 11pt; font-weight: bold"
        Me.Label5.Text = "会合名："
        Me.Label5.Top = 0.2740158!
        Me.Label5.Width = 0.8437008!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.DataField = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Height = 0.2!
        Me.KOUENKAI_NAME.Left = 0.8437008!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-weight: bold; white-space: nowrap"
        Me.KOUENKAI_NAME.Text = Nothing
        Me.KOUENKAI_NAME.Top = 0.2740158!
        Me.KOUENKAI_NAME.Width = 6.321654!
        '
        'Label6
        '
        Me.Label6.Height = 0.2255906!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.0000004768372!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align" & _
            ": middle; white-space: nowrap"
        Me.Label6.Text = "会合番号"
        Me.Label6.Top = 0.4740149!
        Me.Label6.Width = 0.6570862!
        '
        'Label9
        '
        Me.Label9.Height = 0.2255906!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 2.155512!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align" & _
            ": middle; white-space: nowrap"
        Me.Label9.Text = "MTP ID(参加者ID)"
        Me.Label9.Top = 0.4740158!
        Me.Label9.Width = 1.081889!
        '
        'Label10
        '
        Me.Label10.Height = 0.2255906!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 4.942126!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label10.Text = "DRコード"
        Me.Label10.Top = 0.4740158!
        Me.Label10.Width = 0.7047243!
        '
        'Label11
        '
        Me.Label11.Height = 0.2255906!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.0!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align" & _
            ": middle; white-space: nowrap"
        Me.Label11.Text = "DR氏名"
        Me.Label11.Top = 0.6996064!
        Me.Label11.Width = 1.323622!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.DataField = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Height = 0.2255906!
        Me.KOUENKAI_NO.Left = 0.6570867!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Style = "vertical-align: middle"
        Me.KOUENKAI_NO.Text = Nothing
        Me.KOUENKAI_NO.Top = 0.4740158!
        Me.KOUENKAI_NO.Width = 1.498425!
        '
        'SANKASHA_ID
        '
        Me.SANKASHA_ID.DataField = "SANKASHA_ID"
        Me.SANKASHA_ID.Height = 0.2255906!
        Me.SANKASHA_ID.Left = 3.237402!
        Me.SANKASHA_ID.Name = "SANKASHA_ID"
        Me.SANKASHA_ID.Style = "vertical-align: middle"
        Me.SANKASHA_ID.Text = Nothing
        Me.SANKASHA_ID.Top = 0.4740158!
        Me.SANKASHA_ID.Width = 1.498425!
        '
        'DR_CD
        '
        Me.DR_CD.DataField = "DR_CD"
        Me.DR_CD.Height = 0.2255906!
        Me.DR_CD.Left = 5.646851!
        Me.DR_CD.Name = "DR_CD"
        Me.DR_CD.Style = "vertical-align: middle"
        Me.DR_CD.Text = Nothing
        Me.DR_CD.Top = 0.4740158!
        Me.DR_CD.Width = 1.500788!
        '
        'DR_NAME
        '
        Me.DR_NAME.DataField = "DR_NAME"
        Me.DR_NAME.Height = 0.2255906!
        Me.DR_NAME.Left = 1.313386!
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.Style = "vertical-align: middle"
        Me.DR_NAME.Text = Nothing
        Me.DR_NAME.Top = 0.6996063!
        Me.DR_NAME.Width = 2.23504!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0000004768372!
        Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.6996063!
        Me.Line3.Width = 7.649607!
        Me.Line3.X1 = 0.0000004768372!
        Me.Line3.X2 = 7.649607!
        Me.Line3.Y1 = 0.6996063!
        Me.Line3.Y2 = 0.6996063!
        '
        'Line51
        '
        Me.Line51.Height = 0.0!
        Me.Line51.Left = 5.684342E-14!
        Me.Line51.LineWeight = 1.0!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 0.4740158!
        Me.Line51.Width = 7.649607!
        Me.Line51.X1 = 5.684342E-14!
        Me.Line51.X2 = 7.649607!
        Me.Line51.Y1 = 0.4740158!
        Me.Line51.Y2 = 0.4740158!
        '
        'Label3
        '
        Me.Label3.Height = 0.2!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: bold; text-align: center"
        Me.Label3.Text = "タクチケ手配確認票"
        Me.Label3.Top = 0.0330711!
        Me.Label3.Width = 7.649607!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3, Me.Shape1, Me.Label25, Me.MR_SEND_SAKI_OTHER, Me.Label174, Me.KINKYU_FLAG, Me.ANS_TAXI_KENSHU_16, Me.ANS_TAXI_HAKKO_DATE_16, Me.Label144, Me.Label53, Me.Label49, Me.Label45, Me.Label12, Me.Label202, Me.Label24, Me.REQ_TAXI_FROM_1, Me.Label5, Me.KOUENKAI_NAME, Me.DANTAI_CODE, Me.Label200, Me.Label8, Me.Label185, Me.REQ_MR_TEHAI, Me.Label178, Me.Label184, Me.TEHAI_HOTEL, Me.Label183, Me.TEHAI_KOTSU, Me.Label182, Me.ANS_TAXI_NOTE, Me.REQ_TAXI_NOTE, Me.Label180, Me.Label124, Me.Label90, Me.REQ_TAXI_DATE_10, Me.REQ_TAXI_FROM_10, Me.TAXI_YOTEIKINGAKU_10, Me.Label86, Me.REQ_TAXI_DATE_9, Me.REQ_TAXI_FROM_9, Me.TAXI_YOTEIKINGAKU_9, Me.Label82, Me.REQ_TAXI_DATE_8, Me.REQ_TAXI_FROM_8, Me.TAXI_YOTEIKINGAKU_8, Me.Label78, Me.REQ_TAXI_DATE_7, Me.REQ_TAXI_FROM_7, Me.TAXI_YOTEIKINGAKU_7, Me.Label65, Me.REQ_TAXI_DATE_6, Me.REQ_TAXI_FROM_6, Me.TAXI_YOTEIKINGAKU_6, Me.Label61, Me.Label60, Me.REQ_TAXI_DATE_5, Me.REQ_TAXI_FROM_5, Me.Label58, Me.TAXI_YOTEIKINGAKU_5, Me.Label57, Me.Label56, Me.REQ_TAXI_DATE_4, Me.REQ_TAXI_FROM_4, Me.TAXI_YOTEIKINGAKU_4, Me.Label52, Me.Label51, Me.REQ_TAXI_DATE_3, Me.REQ_TAXI_FROM_3, Me.TAXI_YOTEIKINGAKU_3, Me.Label48, Me.Label47, Me.REQ_TAXI_DATE_2, Me.REQ_TAXI_FROM_2, Me.TAXI_YOTEIKINGAKU_2, Me.KOUTEI_1, Me.REQ_TAXI_DATE_1, Me.Label73, Me.Label74, Me.TAXI_YOTEIKINGAKU_1, Me.Label71, Me.TEHAI_TAXI, Me.DR_SHISETSU_NAME, Me.Label6, Me.Label9, Me.Label10, Me.Label11, Me.Label14, Me.KOUENKAI_NO, Me.SANKASHA_ID, Me.DR_CD, Me.DR_NAME, Me.Line3, Me.Line51, Me.Line62, Me.Line63, Me.Line163, Me.Line164, Me.Line1, Me.Line2, Me.Line5, Me.Line42, Me.Line23, Me.Line26, Me.Label21, Me.ANS_TAXI_DATE_1, Me.Label22, Me.ANS_TAXI_KENSHU_1, Me.Label23, Me.ANS_TAXI_NO_1, Me.ANS_TAXI_HAKKO_DATE_1, Me.ANS_TAXI_RMKS_1, Me.Label27, Me.ANS_TAXI_DATE_2, Me.Label28, Me.ANS_TAXI_KENSHU_2, Me.ANS_TAXI_NO_2, Me.Label30, Me.ANS_TAXI_HAKKO_DATE_2, Me.ANS_TAXI_RMKS_2, Me.ANS_TAXI_DATE_3, Me.Label34, Me.ANS_TAXI_KENSHU_3, Me.ANS_TAXI_NO_3, Me.Label36, Me.ANS_TAXI_HAKKO_DATE_3, Me.ANS_TAXI_RMKS_3, Me.ANS_TAXI_DATE_4, Me.ANS_TAXI_KENSHU_4, Me.ANS_TAXI_NO_4, Me.ANS_TAXI_HAKKO_DATE_4, Me.ANS_TAXI_RMKS_4, Me.ANS_TAXI_HAKKO_DATE_5, Me.ANS_TAXI_DATE_5, Me.ANS_TAXI_KENSHU_5, Me.ANS_TAXI_NO_5, Me.ANS_TAXI_RMKS_5, Me.ANS_TAXI_HAKKO_DATE_6, Me.ANS_TAXI_DATE_6, Me.ANS_TAXI_KENSHU_6, Me.ANS_TAXI_NO_6, Me.ANS_TAXI_RMKS_6, Me.ANS_TAXI_HAKKO_DATE_7, Me.ANS_TAXI_DATE_7, Me.ANS_TAXI_KENSHU_7, Me.ANS_TAXI_NO_7, Me.ANS_TAXI_RMKS_7, Me.ANS_TAXI_HAKKO_DATE_8, Me.ANS_TAXI_DATE_8, Me.ANS_TAXI_KENSHU_8, Me.ANS_TAXI_NO_8, Me.ANS_TAXI_RMKS_8, Me.ANS_TAXI_HAKKO_DATE_9, Me.ANS_TAXI_DATE_9, Me.ANS_TAXI_KENSHU_9, Me.ANS_TAXI_NO_9, Me.ANS_TAXI_RMKS_9, Me.ANS_TAXI_HAKKO_DATE_10, Me.ANS_TAXI_DATE_10, Me.ANS_TAXI_KENSHU_10, Me.ANS_TAXI_NO_10, Me.ANS_TAXI_RMKS_10, Me.ANS_TAXI_HAKKO_DATE_11, Me.ANS_TAXI_DATE_11, Me.ANS_TAXI_KENSHU_11, Me.ANS_TAXI_NO_11, Me.ANS_TAXI_RMKS_11, Me.ANS_TAXI_HAKKO_DATE_12, Me.ANS_TAXI_DATE_12, Me.ANS_TAXI_KENSHU_12, Me.ANS_TAXI_NO_12, Me.Label130, Me.ANS_TAXI_RMKS_12, Me.ANS_TAXI_HAKKO_DATE_13, Me.ANS_TAXI_DATE_13, Me.ANS_TAXI_KENSHU_13, Me.ANS_TAXI_NO_13, Me.Label136, Me.ANS_TAXI_RMKS_13, Me.ANS_TAXI_HAKKO_DATE_14, Me.ANS_TAXI_DATE_14, Me.ANS_TAXI_KENSHU_14, Me.ANS_TAXI_NO_14, Me.Label142, Me.ANS_TAXI_RMKS_14, Me.ANS_TAXI_RMKS_15, Me.ANS_TAXI_HAKKO_DATE_15, Me.ANS_TAXI_DATE_15, Me.ANS_TAXI_KENSHU_15, Me.ANS_TAXI_NO_15, Me.Label148, Me.ANS_TAXI_RMKS_16, Me.ANS_TAXI_DATE_16, Me.ANS_TAXI_NO_16, Me.Label154, Me.ANS_TAXI_RMKS_17, Me.ANS_TAXI_HAKKO_DATE_17, Me.ANS_TAXI_DATE_17, Me.ANS_TAXI_KENSHU_17, Me.ANS_TAXI_NO_17, Me.Label160, Me.ANS_TAXI_RMKS_18, Me.ANS_TAXI_HAKKO_DATE_18, Me.ANS_TAXI_DATE_18, Me.ANS_TAXI_KENSHU_18, Me.ANS_TAXI_NO_18, Me.Label166, Me.ANS_TAXI_RMKS_19, Me.ANS_TAXI_HAKKO_DATE_19, Me.ANS_TAXI_DATE_19, Me.ANS_TAXI_KENSHU_19, Me.ANS_TAXI_NO_19, Me.Label172, Me.ANS_TAXI_RMKS_20, Me.ANS_TAXI_HAKKO_DATE_20, Me.ANS_TAXI_DATE_20, Me.ANS_TAXI_KENSHU_20, Me.ANS_TAXI_NO_20, Me.Label20, Me.Label26, Me.Label32, Me.Label38, Me.Label69, Me.Label94, Me.Label100, Me.Label106, Me.Label112, Me.Label118, Me.Line36, Me.Line104, Me.Label181, Me.REQ_O_TEHAI_1, Me.REQ_O_TEHAI_2, Me.REQ_O_TEHAI_3, Me.REQ_O_TEHAI_4, Me.REQ_O_TEHAI_5, Me.REQ_F_TEHAI_1, Me.REQ_F_TEHAI_2, Me.REQ_F_TEHAI_3, Me.REQ_F_TEHAI_4, Me.REQ_F_TEHAI_5, Me.REQ_MR_O_TEHAI, Me.REQ_MR_F_TEHAI, Me.Line32, Me.Label7, Me.Line37, Me.Line6, Me.Line7, Me.Line4, Me.Line152, Me.Line153, Me.Line155, Me.Line17, Me.Line107, Me.Line109, Me.Line18, Me.Line85, Me.Label46, Me.Line110, Me.Label50, Me.Line135, Me.Label203, Me.Label204, Me.Label31, Me.Label205, Me.Label13, Me.Label33, Me.Label35, Me.Label37, Me.Label54, Me.Label206, Me.Label207, Me.Label15, Me.Label16, Me.Label39, Me.Label40, Me.Label41, Me.Label42, Me.Label43, Me.Label44, Me.Label55, Me.Label59, Me.Label62, Me.Label63, Me.Label64, Me.Label67, Me.Label68, Me.Label70, Me.Label17, Me.Label75, Me.Label91, Me.Label92, Me.Label93, Me.Label95, Me.Label208, Me.Label209, Me.Label210, Me.Label18, Me.Label66, Me.Label76, Me.Label77, Me.Label79, Me.Label80, Me.Label81, Me.Label96, Me.Label97, Me.Label98, Me.Label99, Me.Label101, Me.Label211, Me.Label212, Me.Label213, Me.Label214, Me.Label215, Me.Label216, Me.Label19, Me.Label29, Me.Label83, Me.Label84, Me.Label85, Me.Label102, Me.Label103, Me.Label104, Me.Label105, Me.Label72, Me.Label87, Me.Label88, Me.Label89, Me.Label107, Me.Label108, Me.Line13, Me.Line16, Me.Line41, Me.Line111, Me.Line136, Me.Line106, Me.Line138, Me.Line11, Me.Line139, Me.Line140, Me.Line105, Me.Line143, Me.Line102, Me.Line144, Me.Line101, Me.Line145, Me.Line100, Me.Line15, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line35, Me.Line49, Me.Line54, Me.Line58, Me.Line59, Me.Line60, Me.Line61, Me.Line64, Me.Line65, Me.Line67, Me.Line68, Me.Line69, Me.Line87, Me.Label109, Me.Label110, Me.Label111, Me.Label113, Me.Label114, Me.Label115, Me.Line99, Me.Label116, Me.Label117, Me.Label119, Me.Label120, Me.Label121, Me.Label122, Me.Line8, Me.Label123, Me.Label125, Me.Label126, Me.Label127, Me.Label128, Me.Label129, Me.Line25, Me.Label131, Me.Label132, Me.Label133, Me.Label134, Me.Label135, Me.Label137, Me.Line27, Me.Label138, Me.Label139, Me.Label140, Me.Label141, Me.Label143, Me.Line33, Me.Label145, Me.Label146, Me.Label147, Me.Label149, Me.Label150, Me.Label151, Me.Line34, Me.Label152, Me.Label153, Me.Label155, Me.Label156, Me.Label157, Me.Label158, Me.Line40, Me.Label159, Me.Label161, Me.Label162, Me.Label163, Me.Label164, Me.Label165, Me.Line43, Me.Label167, Me.Label168, Me.Label169, Me.Label170, Me.Label171, Me.Label173, Me.Line44, Me.Line74, Me.Line112, Me.Line9, Me.Line45, Me.Line47, Me.Line48, Me.Line50, Me.Line52, Me.Line53, Me.Line55, Me.Line56, Me.Line57, Me.Line10, Me.Line66, Me.Line14, Me.Line24, Me.Line29, Me.Line76, Me.Line30, Me.Line70, Me.Line71, Me.Line72, Me.Line73, Me.Line28, Me.Label4, Me.Line75, Me.Line79, Me.Line38, Me.Line114, Me.Line12, Me.Line31, Me.Line103})
        Me.Detail.Height = 10.21198!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'Label25
        '
        Me.Label25.Height = 0.2255906!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 5.966536!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label25.Text = "備考"
        Me.Label25.Top = 1.376378!
        Me.Label25.Width = 0.3948819!
        '
        'MR_SEND_SAKI_OTHER
        '
        Me.MR_SEND_SAKI_OTHER.DataField = "MR_SEND_SAKI_OTHER"
        Me.MR_SEND_SAKI_OTHER.Height = 1.261024!
        Me.MR_SEND_SAKI_OTHER.Left = 0.0!
        Me.MR_SEND_SAKI_OTHER.Name = "MR_SEND_SAKI_OTHER"
        Me.MR_SEND_SAKI_OTHER.Style = "font-size: 9pt; vertical-align: top"
        Me.MR_SEND_SAKI_OTHER.Text = Nothing
        Me.MR_SEND_SAKI_OTHER.Top = 8.913386!
        Me.MR_SEND_SAKI_OTHER.Width = 2.787402!
        '
        'Label174
        '
        Me.Label174.Height = 0.2255906!
        Me.Label174.HyperLink = Nothing
        Me.Label174.Left = 0.008661418!
        Me.Label174.Name = "Label174"
        Me.Label174.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label174.Text = "チケット送付先(その他)"
        Me.Label174.Top = 8.682678!
        Me.Label174.Width = 2.77874!
        '
        'KINKYU_FLAG
        '
        Me.KINKYU_FLAG.DataField = "KINKYU_FLAG"
        Me.KINKYU_FLAG.Height = 0.2255906!
        Me.KINKYU_FLAG.Left = 4.924803!
        Me.KINKYU_FLAG.Name = "KINKYU_FLAG"
        Me.KINKYU_FLAG.Style = "text-align: center; vertical-align: middle"
        Me.KINKYU_FLAG.Text = Nothing
        Me.KINKYU_FLAG.Top = 0.9251968!
        Me.KINKYU_FLAG.Width = 0.2893701!
        '
        'ANS_TAXI_KENSHU_16
        '
        Me.ANS_TAXI_KENSHU_16.DataField = "ANS_TAXI_KENSHU_16"
        Me.ANS_TAXI_KENSHU_16.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_16.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_16.Name = "ANS_TAXI_KENSHU_16"
        Me.ANS_TAXI_KENSHU_16.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_16.Text = Nothing
        Me.ANS_TAXI_KENSHU_16.Top = 7.918504!
        Me.ANS_TAXI_KENSHU_16.Width = 0.8944882!
        '
        'ANS_TAXI_HAKKO_DATE_16
        '
        Me.ANS_TAXI_HAKKO_DATE_16.DataField = "ANS_TAXI_HAKKO_DATE_16"
        Me.ANS_TAXI_HAKKO_DATE_16.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_16.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_16.Name = "ANS_TAXI_HAKKO_DATE_16"
        Me.ANS_TAXI_HAKKO_DATE_16.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_16.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_16.Top = 7.918504!
        Me.ANS_TAXI_HAKKO_DATE_16.Width = 0.7472441!
        '
        'Label144
        '
        Me.Label144.Height = 0.2255906!
        Me.Label144.HyperLink = Nothing
        Me.Label144.Left = 4.378346!
        Me.Label144.Name = "Label144"
        Me.Label144.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label144.Text = "利用者名"
        Me.Label144.Top = 8.144094!
        Me.Label144.Width = 0.5464572!
        '
        'Label53
        '
        Me.Label53.Height = 0.2255906!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 1.612992!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label53.Text = "依頼金額"
        Me.Label53.Top = 2.504331!
        Me.Label53.Width = 0.5811024!
        '
        'Label49
        '
        Me.Label49.Height = 0.2255906!
        Me.Label49.HyperLink = Nothing
        Me.Label49.Left = 1.612992!
        Me.Label49.Name = "Label49"
        Me.Label49.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label49.Text = "依頼金額"
        Me.Label49.Top = 2.05315!
        Me.Label49.Width = 0.5811025!
        '
        'Label45
        '
        Me.Label45.Height = 0.2255906!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 1.612992!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label45.Text = "依頼金額"
        Me.Label45.Top = 1.612599!
        Me.Label45.Width = 0.5811026!
        '
        'Label12
        '
        Me.Label12.Height = 0.2255906!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 4.378346!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label12.Text = "利用者名"
        Me.Label12.Top = 1.827559!
        Me.Label12.Width = 0.5464572!
        '
        'Label202
        '
        Me.Label202.Height = 0.2255906!
        Me.Label202.HyperLink = Nothing
        Me.Label202.Left = 5.966536!
        Me.Label202.Name = "Label202"
        Me.Label202.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label202.Text = "備考"
        Me.Label202.Top = 1.827559!
        Me.Label202.Width = 0.3948819!
        '
        'Label24
        '
        Me.Label24.Height = 0.2255906!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 5.966536!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label24.Text = "発行日"
        Me.Label24.Top = 1.150787!
        Me.Label24.Width = 0.3948817!
        '
        'REQ_TAXI_FROM_1
        '
        Me.REQ_TAXI_FROM_1.DataField = "REQ_TAXI_FROM_1"
        Me.REQ_TAXI_FROM_1.Height = 0.2255906!
        Me.REQ_TAXI_FROM_1.Left = 0.8437009!
        Me.REQ_TAXI_FROM_1.Name = "REQ_TAXI_FROM_1"
        Me.REQ_TAXI_FROM_1.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_1.Text = Nothing
        Me.REQ_TAXI_FROM_1.Top = 1.376378!
        Me.REQ_TAXI_FROM_1.Width = 1.943701!
        '
        'DANTAI_CODE
        '
        Me.DANTAI_CODE.DataField = "DANTAI_CODE"
        Me.DANTAI_CODE.Height = 0.2255906!
        Me.DANTAI_CODE.Left = 6.67126!
        Me.DANTAI_CODE.Name = "DANTAI_CODE"
        Me.DANTAI_CODE.Style = "vertical-align: middle"
        Me.DANTAI_CODE.Text = Nothing
        Me.DANTAI_CODE.Top = 0.9251968!
        Me.DANTAI_CODE.Width = 0.7925197!
        '
        'Label200
        '
        Me.Label200.Height = 0.2255906!
        Me.Label200.HyperLink = Nothing
        Me.Label200.Left = 5.966536!
        Me.Label200.Name = "Label200"
        Me.Label200.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label200.Text = "団体コード"
        Me.Label200.Top = 0.9251968!
        Me.Label200.Width = 0.7047244!
        '
        'Label8
        '
        Me.Label8.Height = 0.2255906!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 3.236221!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label8.Text = "番号"
        Me.Label8.Top = 1.827559!
        Me.Label8.Width = 0.381496!
        '
        'Label185
        '
        Me.Label185.Height = 0.2255906!
        Me.Label185.HyperLink = Nothing
        Me.Label185.Left = 4.378347!
        Me.Label185.Name = "Label185"
        Me.Label185.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label185.Text = "利用者名"
        Me.Label185.Top = 1.376378!
        Me.Label185.Width = 0.5464572!
        '
        'REQ_MR_TEHAI
        '
        Me.REQ_MR_TEHAI.Height = 0.2255906!
        Me.REQ_MR_TEHAI.Left = 3.910237!
        Me.REQ_MR_TEHAI.Name = "REQ_MR_TEHAI"
        Me.REQ_MR_TEHAI.Style = "vertical-align: middle"
        Me.REQ_MR_TEHAI.Text = Nothing
        Me.REQ_MR_TEHAI.Top = 0.9251968!
        Me.REQ_MR_TEHAI.Width = 0.4677158!
        '
        'Label178
        '
        Me.Label178.Height = 0.4511811!
        Me.Label178.HyperLink = Nothing
        Me.Label178.Left = 2.787402!
        Me.Label178.Name = "Label178"
        Me.Label178.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label178.Text = "ﾀｸﾁｹ20"
        Me.Label178.Top = 9.723228!
        Me.Label178.Width = 0.4488189!
        '
        'Label184
        '
        Me.Label184.Height = 0.2255906!
        Me.Label184.HyperLink = Nothing
        Me.Label184.Left = 3.329134!
        Me.Label184.Name = "Label184"
        Me.Label184.Style = "vertical-align: middle; white-space: nowrap"
        Me.Label184.Text = "MR手配"
        Me.Label184.Top = 0.9251968!
        Me.Label184.Width = 0.5811024!
        '
        'TEHAI_HOTEL
        '
        Me.TEHAI_HOTEL.DataField = "TEHAI_HOTEL"
        Me.TEHAI_HOTEL.Height = 0.2255906!
        Me.TEHAI_HOTEL.Left = 3.064567!
        Me.TEHAI_HOTEL.Name = "TEHAI_HOTEL"
        Me.TEHAI_HOTEL.Style = "text-align: center; vertical-align: middle"
        Me.TEHAI_HOTEL.Text = Nothing
        Me.TEHAI_HOTEL.Top = 0.9251968!
        Me.TEHAI_HOTEL.Width = 0.2893701!
        '
        'Label183
        '
        Me.Label183.Height = 0.2255906!
        Me.Label183.HyperLink = Nothing
        Me.Label183.Left = 2.483465!
        Me.Label183.Name = "Label183"
        Me.Label183.Style = "vertical-align: middle; white-space: nowrap"
        Me.Label183.Text = "宿泊手配"
        Me.Label183.Top = 0.9251968!
        Me.Label183.Width = 0.5811024!
        '
        'TEHAI_KOTSU
        '
        Me.TEHAI_KOTSU.Height = 0.2255906!
        Me.TEHAI_KOTSU.Left = 2.194095!
        Me.TEHAI_KOTSU.Name = "TEHAI_KOTSU"
        Me.TEHAI_KOTSU.Style = "text-align: center; vertical-align: middle"
        Me.TEHAI_KOTSU.Text = Nothing
        Me.TEHAI_KOTSU.Top = 0.9251968!
        Me.TEHAI_KOTSU.Width = 0.2893701!
        '
        'Label182
        '
        Me.Label182.Height = 0.2255906!
        Me.Label182.HyperLink = Nothing
        Me.Label182.Left = 1.612992!
        Me.Label182.Name = "Label182"
        Me.Label182.Style = "vertical-align: middle; white-space: nowrap"
        Me.Label182.Text = "交通手配"
        Me.Label182.Top = 0.9251968!
        Me.Label182.Width = 0.5811024!
        '
        'ANS_TAXI_NOTE
        '
        Me.ANS_TAXI_NOTE.DataField = "ANS_TAXI_NOTE"
        Me.ANS_TAXI_NOTE.Height = 1.279134!
        Me.ANS_TAXI_NOTE.Left = 0.0!
        Me.ANS_TAXI_NOTE.Name = "ANS_TAXI_NOTE"
        Me.ANS_TAXI_NOTE.Style = "vertical-align: top"
        Me.ANS_TAXI_NOTE.Text = Nothing
        Me.ANS_TAXI_NOTE.Top = 7.403544!
        Me.ANS_TAXI_NOTE.Width = 2.787402!
        '
        'REQ_TAXI_NOTE
        '
        Me.REQ_TAXI_NOTE.DataField = "REQ_TAXI_NOTE"
        Me.REQ_TAXI_NOTE.Height = 1.289764!
        Me.REQ_TAXI_NOTE.Left = 0.008661415!
        Me.REQ_TAXI_NOTE.Name = "REQ_TAXI_NOTE"
        Me.REQ_TAXI_NOTE.Style = "vertical-align: top"
        Me.REQ_TAXI_NOTE.Text = Nothing
        Me.REQ_TAXI_NOTE.Top = 5.888189!
        Me.REQ_TAXI_NOTE.Width = 2.787402!
        '
        'Label180
        '
        Me.Label180.Height = 0.2255906!
        Me.Label180.HyperLink = Nothing
        Me.Label180.Left = 2.842171E-14!
        Me.Label180.Name = "Label180"
        Me.Label180.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label180.Text = "備考（依頼）"
        Me.Label180.Top = 5.662599!
        Me.Label180.Width = 2.787402!
        '
        'Label124
        '
        Me.Label124.Height = 0.4511811!
        Me.Label124.HyperLink = Nothing
        Me.Label124.Left = 2.787402!
        Me.Label124.Name = "Label124"
        Me.Label124.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label124.Text = "ﾀｸﾁｹ11"
        Me.Label124.Top = 5.662599!
        Me.Label124.Width = 0.4488189!
        '
        'Label90
        '
        Me.Label90.Height = 0.4511811!
        Me.Label90.HyperLink = Nothing
        Me.Label90.Left = 2.842171E-14!
        Me.Label90.Name = "Label90"
        Me.Label90.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label90.Text = "行程10"
        Me.Label90.Top = 5.211418!
        Me.Label90.Width = 0.448819!
        '
        'REQ_TAXI_DATE_10
        '
        Me.REQ_TAXI_DATE_10.DataField = "REQ_TAXI_DATE_10"
        Me.REQ_TAXI_DATE_10.Height = 0.2255906!
        Me.REQ_TAXI_DATE_10.Left = 0.8437008!
        Me.REQ_TAXI_DATE_10.Name = "REQ_TAXI_DATE_10"
        Me.REQ_TAXI_DATE_10.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_10.Text = Nothing
        Me.REQ_TAXI_DATE_10.Top = 5.211418!
        Me.REQ_TAXI_DATE_10.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_10
        '
        Me.REQ_TAXI_FROM_10.DataField = "REQ_TAXI_FROM_10"
        Me.REQ_TAXI_FROM_10.Height = 0.2255906!
        Me.REQ_TAXI_FROM_10.Left = 0.8437009!
        Me.REQ_TAXI_FROM_10.Name = "REQ_TAXI_FROM_10"
        Me.REQ_TAXI_FROM_10.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_10.Text = Nothing
        Me.REQ_TAXI_FROM_10.Top = 5.437008!
        Me.REQ_TAXI_FROM_10.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_10
        '
        Me.TAXI_YOTEIKINGAKU_10.DataField = "TAXI_YOTEIKINGAKU_10"
        Me.TAXI_YOTEIKINGAKU_10.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_10.Left = 2.194094!
        Me.TAXI_YOTEIKINGAKU_10.Name = "TAXI_YOTEIKINGAKU_10"
        Me.TAXI_YOTEIKINGAKU_10.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_10.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_10.Top = 5.211418!
        Me.TAXI_YOTEIKINGAKU_10.Width = 0.5933071!
        '
        'Label86
        '
        Me.Label86.Height = 0.4511811!
        Me.Label86.HyperLink = Nothing
        Me.Label86.Left = 0.0000001788139!
        Me.Label86.Name = "Label86"
        Me.Label86.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label86.Text = "行程9"
        Me.Label86.Top = 4.760236!
        Me.Label86.Width = 0.4488189!
        '
        'REQ_TAXI_DATE_9
        '
        Me.REQ_TAXI_DATE_9.DataField = "REQ_TAXI_DATE_9"
        Me.REQ_TAXI_DATE_9.Height = 0.2255906!
        Me.REQ_TAXI_DATE_9.Left = 0.8437008!
        Me.REQ_TAXI_DATE_9.Name = "REQ_TAXI_DATE_9"
        Me.REQ_TAXI_DATE_9.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_9.Text = Nothing
        Me.REQ_TAXI_DATE_9.Top = 4.760236!
        Me.REQ_TAXI_DATE_9.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_9
        '
        Me.REQ_TAXI_FROM_9.DataField = "REQ_TAXI_FROM_9"
        Me.REQ_TAXI_FROM_9.Height = 0.2255906!
        Me.REQ_TAXI_FROM_9.Left = 0.8437009!
        Me.REQ_TAXI_FROM_9.Name = "REQ_TAXI_FROM_9"
        Me.REQ_TAXI_FROM_9.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_9.Text = Nothing
        Me.REQ_TAXI_FROM_9.Top = 4.985826!
        Me.REQ_TAXI_FROM_9.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_9
        '
        Me.TAXI_YOTEIKINGAKU_9.DataField = "TAXI_YOTEIKINGAKU_9"
        Me.TAXI_YOTEIKINGAKU_9.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_9.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_9.Name = "TAXI_YOTEIKINGAKU_9"
        Me.TAXI_YOTEIKINGAKU_9.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_9.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_9.Top = 4.760236!
        Me.TAXI_YOTEIKINGAKU_9.Width = 0.5933071!
        '
        'Label82
        '
        Me.Label82.Height = 0.4511811!
        Me.Label82.HyperLink = Nothing
        Me.Label82.Left = 0.0000001788139!
        Me.Label82.Name = "Label82"
        Me.Label82.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label82.Text = "行程8"
        Me.Label82.Top = 4.309055!
        Me.Label82.Width = 0.448819!
        '
        'REQ_TAXI_DATE_8
        '
        Me.REQ_TAXI_DATE_8.DataField = "REQ_TAXI_DATE_8"
        Me.REQ_TAXI_DATE_8.Height = 0.2255906!
        Me.REQ_TAXI_DATE_8.Left = 0.8437008!
        Me.REQ_TAXI_DATE_8.Name = "REQ_TAXI_DATE_8"
        Me.REQ_TAXI_DATE_8.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_8.Text = Nothing
        Me.REQ_TAXI_DATE_8.Top = 4.309055!
        Me.REQ_TAXI_DATE_8.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_8
        '
        Me.REQ_TAXI_FROM_8.DataField = "REQ_TAXI_FROM_8"
        Me.REQ_TAXI_FROM_8.Height = 0.2255906!
        Me.REQ_TAXI_FROM_8.Left = 0.8437008!
        Me.REQ_TAXI_FROM_8.Name = "REQ_TAXI_FROM_8"
        Me.REQ_TAXI_FROM_8.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_8.Text = Nothing
        Me.REQ_TAXI_FROM_8.Top = 4.534646!
        Me.REQ_TAXI_FROM_8.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_8
        '
        Me.TAXI_YOTEIKINGAKU_8.DataField = "TAXI_YOTEIKINGAKU_8"
        Me.TAXI_YOTEIKINGAKU_8.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_8.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_8.Name = "TAXI_YOTEIKINGAKU_8"
        Me.TAXI_YOTEIKINGAKU_8.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_8.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_8.Top = 4.309055!
        Me.TAXI_YOTEIKINGAKU_8.Width = 0.5933071!
        '
        'Label78
        '
        Me.Label78.Height = 0.4511811!
        Me.Label78.HyperLink = Nothing
        Me.Label78.Left = 2.842171E-14!
        Me.Label78.Name = "Label78"
        Me.Label78.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label78.Text = "行程7"
        Me.Label78.Top = 3.857874!
        Me.Label78.Width = 0.448819!
        '
        'REQ_TAXI_DATE_7
        '
        Me.REQ_TAXI_DATE_7.DataField = "REQ_TAXI_DATE_7"
        Me.REQ_TAXI_DATE_7.Height = 0.2255906!
        Me.REQ_TAXI_DATE_7.Left = 0.8437008!
        Me.REQ_TAXI_DATE_7.Name = "REQ_TAXI_DATE_7"
        Me.REQ_TAXI_DATE_7.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_7.Text = Nothing
        Me.REQ_TAXI_DATE_7.Top = 3.857874!
        Me.REQ_TAXI_DATE_7.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_7
        '
        Me.REQ_TAXI_FROM_7.DataField = "REQ_TAXI_FROM_7"
        Me.REQ_TAXI_FROM_7.Height = 0.2255906!
        Me.REQ_TAXI_FROM_7.Left = 0.8437009!
        Me.REQ_TAXI_FROM_7.Name = "REQ_TAXI_FROM_7"
        Me.REQ_TAXI_FROM_7.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_7.Text = Nothing
        Me.REQ_TAXI_FROM_7.Top = 4.083465!
        Me.REQ_TAXI_FROM_7.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_7
        '
        Me.TAXI_YOTEIKINGAKU_7.DataField = "TAXI_YOTEIKINGAKU_7"
        Me.TAXI_YOTEIKINGAKU_7.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_7.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_7.Name = "TAXI_YOTEIKINGAKU_7"
        Me.TAXI_YOTEIKINGAKU_7.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_7.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_7.Top = 3.857874!
        Me.TAXI_YOTEIKINGAKU_7.Width = 0.5933071!
        '
        'Label65
        '
        Me.Label65.Height = 0.4511811!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 0.0000001788139!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label65.Text = "行程6"
        Me.Label65.Top = 3.406693!
        Me.Label65.Width = 0.448819!
        '
        'REQ_TAXI_DATE_6
        '
        Me.REQ_TAXI_DATE_6.DataField = "REQ_TAXI_DATE_6"
        Me.REQ_TAXI_DATE_6.Height = 0.2255906!
        Me.REQ_TAXI_DATE_6.Left = 0.8437008!
        Me.REQ_TAXI_DATE_6.Name = "REQ_TAXI_DATE_6"
        Me.REQ_TAXI_DATE_6.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_6.Text = Nothing
        Me.REQ_TAXI_DATE_6.Top = 3.406693!
        Me.REQ_TAXI_DATE_6.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_6
        '
        Me.REQ_TAXI_FROM_6.DataField = "REQ_TAXI_FROM_6"
        Me.REQ_TAXI_FROM_6.Height = 0.2255906!
        Me.REQ_TAXI_FROM_6.Left = 0.8437009!
        Me.REQ_TAXI_FROM_6.Name = "REQ_TAXI_FROM_6"
        Me.REQ_TAXI_FROM_6.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_6.Text = Nothing
        Me.REQ_TAXI_FROM_6.Top = 3.632283!
        Me.REQ_TAXI_FROM_6.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_6
        '
        Me.TAXI_YOTEIKINGAKU_6.DataField = "TAXI_YOTEIKINGAKU_6"
        Me.TAXI_YOTEIKINGAKU_6.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_6.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_6.Name = "TAXI_YOTEIKINGAKU_6"
        Me.TAXI_YOTEIKINGAKU_6.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_6.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_6.Top = 3.406693!
        Me.TAXI_YOTEIKINGAKU_6.Width = 0.5933071!
        '
        'Label61
        '
        Me.Label61.Height = 0.4511811!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 0.0000001788139!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label61.Text = "行程5"
        Me.Label61.Top = 2.955512!
        Me.Label61.Width = 0.448819!
        '
        'Label60
        '
        Me.Label60.Height = 0.2255906!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 0.4488192!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label60.Text = "利用日"
        Me.Label60.Top = 2.955512!
        Me.Label60.Width = 0.3948819!
        '
        'REQ_TAXI_DATE_5
        '
        Me.REQ_TAXI_DATE_5.DataField = "REQ_TAXI_DATE_5"
        Me.REQ_TAXI_DATE_5.Height = 0.2255906!
        Me.REQ_TAXI_DATE_5.Left = 0.8437008!
        Me.REQ_TAXI_DATE_5.Name = "REQ_TAXI_DATE_5"
        Me.REQ_TAXI_DATE_5.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_5.Text = Nothing
        Me.REQ_TAXI_DATE_5.Top = 2.955512!
        Me.REQ_TAXI_DATE_5.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_5
        '
        Me.REQ_TAXI_FROM_5.DataField = "REQ_TAXI_FROM_5"
        Me.REQ_TAXI_FROM_5.Height = 0.2255906!
        Me.REQ_TAXI_FROM_5.Left = 0.8437008!
        Me.REQ_TAXI_FROM_5.Name = "REQ_TAXI_FROM_5"
        Me.REQ_TAXI_FROM_5.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_5.Text = Nothing
        Me.REQ_TAXI_FROM_5.Top = 3.181102!
        Me.REQ_TAXI_FROM_5.Width = 1.943701!
        '
        'Label58
        '
        Me.Label58.Height = 0.2255906!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 1.612992!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label58.Text = "依頼金額"
        Me.Label58.Top = 2.955512!
        Me.Label58.Width = 0.5811024!
        '
        'TAXI_YOTEIKINGAKU_5
        '
        Me.TAXI_YOTEIKINGAKU_5.DataField = "TAXI_YOTEIKINGAKU_5"
        Me.TAXI_YOTEIKINGAKU_5.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_5.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_5.Name = "TAXI_YOTEIKINGAKU_5"
        Me.TAXI_YOTEIKINGAKU_5.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_5.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_5.Top = 2.955512!
        Me.TAXI_YOTEIKINGAKU_5.Width = 0.5933071!
        '
        'Label57
        '
        Me.Label57.Height = 0.4511811!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 0.0!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label57.Text = "行程4"
        Me.Label57.Top = 2.504331!
        Me.Label57.Width = 0.448819!
        '
        'Label56
        '
        Me.Label56.Height = 0.2255906!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 0.4488189!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label56.Text = "利用日"
        Me.Label56.Top = 2.504331!
        Me.Label56.Width = 0.3948819!
        '
        'REQ_TAXI_DATE_4
        '
        Me.REQ_TAXI_DATE_4.DataField = "REQ_TAXI_DATE_4"
        Me.REQ_TAXI_DATE_4.Height = 0.2255906!
        Me.REQ_TAXI_DATE_4.Left = 0.8437008!
        Me.REQ_TAXI_DATE_4.Name = "REQ_TAXI_DATE_4"
        Me.REQ_TAXI_DATE_4.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_4.Text = Nothing
        Me.REQ_TAXI_DATE_4.Top = 2.504331!
        Me.REQ_TAXI_DATE_4.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_4
        '
        Me.REQ_TAXI_FROM_4.DataField = "REQ_TAXI_FROM_4"
        Me.REQ_TAXI_FROM_4.Height = 0.2255906!
        Me.REQ_TAXI_FROM_4.Left = 0.8437008!
        Me.REQ_TAXI_FROM_4.Name = "REQ_TAXI_FROM_4"
        Me.REQ_TAXI_FROM_4.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_4.Text = Nothing
        Me.REQ_TAXI_FROM_4.Top = 2.729921!
        Me.REQ_TAXI_FROM_4.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_4
        '
        Me.TAXI_YOTEIKINGAKU_4.DataField = "TAXI_YOTEIKINGAKU_4"
        Me.TAXI_YOTEIKINGAKU_4.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_4.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_4.Name = "TAXI_YOTEIKINGAKU_4"
        Me.TAXI_YOTEIKINGAKU_4.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_4.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_4.Top = 2.504331!
        Me.TAXI_YOTEIKINGAKU_4.Width = 0.5933071!
        '
        'Label52
        '
        Me.Label52.Height = 0.4511811!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 0.0000001788139!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label52.Text = "行程3"
        Me.Label52.Top = 2.05315!
        Me.Label52.Width = 0.448819!
        '
        'Label51
        '
        Me.Label51.Height = 0.2255906!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 0.4488189!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label51.Text = "利用日"
        Me.Label51.Top = 2.05315!
        Me.Label51.Width = 0.3948819!
        '
        'REQ_TAXI_DATE_3
        '
        Me.REQ_TAXI_DATE_3.DataField = "REQ_TAXI_DATE_3"
        Me.REQ_TAXI_DATE_3.Height = 0.2255906!
        Me.REQ_TAXI_DATE_3.Left = 0.8437008!
        Me.REQ_TAXI_DATE_3.Name = "REQ_TAXI_DATE_3"
        Me.REQ_TAXI_DATE_3.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_3.Text = Nothing
        Me.REQ_TAXI_DATE_3.Top = 2.05315!
        Me.REQ_TAXI_DATE_3.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_3
        '
        Me.REQ_TAXI_FROM_3.DataField = "REQ_TAXI_FROM_3"
        Me.REQ_TAXI_FROM_3.Height = 0.2255906!
        Me.REQ_TAXI_FROM_3.Left = 0.8437009!
        Me.REQ_TAXI_FROM_3.Name = "REQ_TAXI_FROM_3"
        Me.REQ_TAXI_FROM_3.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_3.Text = Nothing
        Me.REQ_TAXI_FROM_3.Top = 2.27874!
        Me.REQ_TAXI_FROM_3.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_3
        '
        Me.TAXI_YOTEIKINGAKU_3.DataField = "TAXI_YOTEIKINGAKU_3"
        Me.TAXI_YOTEIKINGAKU_3.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_3.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_3.Name = "TAXI_YOTEIKINGAKU_3"
        Me.TAXI_YOTEIKINGAKU_3.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_3.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_3.Top = 2.05315!
        Me.TAXI_YOTEIKINGAKU_3.Width = 0.5933071!
        '
        'Label48
        '
        Me.Label48.Height = 0.4511811!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 2.842171E-14!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: nowrap" & _
            ""
        Me.Label48.Text = "行程2"
        Me.Label48.Top = 1.612599!
        Me.Label48.Width = 0.448819!
        '
        'Label47
        '
        Me.Label47.Height = 0.2255906!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 0.4488189!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label47.Text = "利用日"
        Me.Label47.Top = 1.612599!
        Me.Label47.Width = 0.3948819!
        '
        'REQ_TAXI_DATE_2
        '
        Me.REQ_TAXI_DATE_2.DataField = "REQ_TAXI_DATE_2"
        Me.REQ_TAXI_DATE_2.Height = 0.2255906!
        Me.REQ_TAXI_DATE_2.Left = 0.8437008!
        Me.REQ_TAXI_DATE_2.Name = "REQ_TAXI_DATE_2"
        Me.REQ_TAXI_DATE_2.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_2.Text = Nothing
        Me.REQ_TAXI_DATE_2.Top = 1.612599!
        Me.REQ_TAXI_DATE_2.Width = 0.7692917!
        '
        'REQ_TAXI_FROM_2
        '
        Me.REQ_TAXI_FROM_2.DataField = "REQ_TAXI_FROM_2"
        Me.REQ_TAXI_FROM_2.Height = 0.2255906!
        Me.REQ_TAXI_FROM_2.Left = 0.8437008!
        Me.REQ_TAXI_FROM_2.Name = "REQ_TAXI_FROM_2"
        Me.REQ_TAXI_FROM_2.Style = "vertical-align: middle"
        Me.REQ_TAXI_FROM_2.Text = Nothing
        Me.REQ_TAXI_FROM_2.Top = 1.827559!
        Me.REQ_TAXI_FROM_2.Width = 1.943701!
        '
        'TAXI_YOTEIKINGAKU_2
        '
        Me.TAXI_YOTEIKINGAKU_2.DataField = "TAXI_YOTEIKINGAKU_2"
        Me.TAXI_YOTEIKINGAKU_2.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_2.Left = 2.194095!
        Me.TAXI_YOTEIKINGAKU_2.Name = "TAXI_YOTEIKINGAKU_2"
        Me.TAXI_YOTEIKINGAKU_2.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_2.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_2.Top = 1.612599!
        Me.TAXI_YOTEIKINGAKU_2.Width = 0.5933071!
        '
        'KOUTEI_1
        '
        Me.KOUTEI_1.Height = 0.4511811!
        Me.KOUTEI_1.HyperLink = Nothing
        Me.KOUTEI_1.Left = 0.0!
        Me.KOUTEI_1.Name = "KOUTEI_1"
        Me.KOUTEI_1.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.KOUTEI_1.Text = "行程1"
        Me.KOUTEI_1.Top = 1.161417!
        Me.KOUTEI_1.Width = 0.4488189!
        '
        'REQ_TAXI_DATE_1
        '
        Me.REQ_TAXI_DATE_1.DataField = "REQ_TAXI_DATE_1"
        Me.REQ_TAXI_DATE_1.Height = 0.2255906!
        Me.REQ_TAXI_DATE_1.Left = 0.8437008!
        Me.REQ_TAXI_DATE_1.Name = "REQ_TAXI_DATE_1"
        Me.REQ_TAXI_DATE_1.Style = "vertical-align: middle"
        Me.REQ_TAXI_DATE_1.Text = Nothing
        Me.REQ_TAXI_DATE_1.Top = 1.150787!
        Me.REQ_TAXI_DATE_1.Width = 0.7692915!
        '
        'Label73
        '
        Me.Label73.Height = 0.2255906!
        Me.Label73.HyperLink = Nothing
        Me.Label73.Left = 0.4488189!
        Me.Label73.Name = "Label73"
        Me.Label73.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label73.Text = "発地"
        Me.Label73.Top = 1.376378!
        Me.Label73.Width = 0.3948819!
        '
        'Label74
        '
        Me.Label74.Height = 0.2255906!
        Me.Label74.HyperLink = Nothing
        Me.Label74.Left = 1.612992!
        Me.Label74.Name = "Label74"
        Me.Label74.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label74.Text = "依頼金額"
        Me.Label74.Top = 1.150787!
        Me.Label74.Width = 0.5811025!
        '
        'TAXI_YOTEIKINGAKU_1
        '
        Me.TAXI_YOTEIKINGAKU_1.DataField = "TAXI_YOTEIKINGAKU_1"
        Me.TAXI_YOTEIKINGAKU_1.Height = 0.2255906!
        Me.TAXI_YOTEIKINGAKU_1.Left = 2.194094!
        Me.TAXI_YOTEIKINGAKU_1.Name = "TAXI_YOTEIKINGAKU_1"
        Me.TAXI_YOTEIKINGAKU_1.Style = "vertical-align: middle"
        Me.TAXI_YOTEIKINGAKU_1.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_1.Top = 1.150787!
        Me.TAXI_YOTEIKINGAKU_1.Width = 0.5933079!
        '
        'Label71
        '
        Me.Label71.Height = 0.2255906!
        Me.Label71.HyperLink = Nothing
        Me.Label71.Left = 2.842171E-14!
        Me.Label71.Name = "Label71"
        Me.Label71.Style = "background-color: LightGrey; white-space: nowrap"
        Me.Label71.Text = "タクシーチケット手配"
        Me.Label71.Top = 0.9251968!
        Me.Label71.Width = 1.323622!
        '
        'TEHAI_TAXI
        '
        Me.TEHAI_TAXI.DataField = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Height = 0.2255906!
        Me.TEHAI_TAXI.Left = 1.323622!
        Me.TEHAI_TAXI.Name = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Style = "text-align: center; vertical-align: middle"
        Me.TEHAI_TAXI.Text = Nothing
        Me.TEHAI_TAXI.Top = 0.9251968!
        Me.TEHAI_TAXI.Width = 0.2893703!
        '
        'DR_SHISETSU_NAME
        '
        Me.DR_SHISETSU_NAME.DataField = "DR_SHISETSU_NAME"
        Me.DR_SHISETSU_NAME.Height = 0.2255906!
        Me.DR_SHISETSU_NAME.Left = 4.507481!
        Me.DR_SHISETSU_NAME.Name = "DR_SHISETSU_NAME"
        Me.DR_SHISETSU_NAME.Style = "font-size: 8pt; vertical-align: middle"
        Me.DR_SHISETSU_NAME.Text = Nothing
        Me.DR_SHISETSU_NAME.Top = 0.6996063!
        Me.DR_SHISETSU_NAME.Width = 2.657874!
        '
        'Label14
        '
        Me.Label14.Height = 0.2255906!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 3.558662!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align" & _
            ": middle; white-space: nowrap"
        Me.Label14.Text = "施設名"
        Me.Label14.Top = 0.6996063!
        Me.Label14.Width = 0.9488189!
        '
        'Line62
        '
        Me.Line62.Height = 0.2255905!
        Me.Line62.Left = 4.928741!
        Me.Line62.LineWeight = 1.0!
        Me.Line62.Name = "Line62"
        Me.Line62.Top = 0.4740158!
        Me.Line62.Width = 0.0!
        Me.Line62.X1 = 4.928741!
        Me.Line62.X2 = 4.928741!
        Me.Line62.Y1 = 0.4740158!
        Me.Line62.Y2 = 0.6996063!
        '
        'Line63
        '
        Me.Line63.Height = 0.2255905!
        Me.Line63.Left = 5.646851!
        Me.Line63.LineWeight = 1.0!
        Me.Line63.Name = "Line63"
        Me.Line63.Top = 0.4740158!
        Me.Line63.Width = 0.0!
        Me.Line63.X1 = 5.646851!
        Me.Line63.X2 = 5.646851!
        Me.Line63.Y1 = 0.4740158!
        Me.Line63.Y2 = 0.6996063!
        '
        'Line163
        '
        Me.Line163.Height = 0.2255905!
        Me.Line163.Left = 2.155512!
        Me.Line163.LineWeight = 1.0!
        Me.Line163.Name = "Line163"
        Me.Line163.Top = 0.4740158!
        Me.Line163.Width = 0.0!
        Me.Line163.X1 = 2.155512!
        Me.Line163.X2 = 2.155512!
        Me.Line163.Y1 = 0.4740158!
        Me.Line163.Y2 = 0.6996063!
        '
        'Line164
        '
        Me.Line164.Height = 0.2255905!
        Me.Line164.Left = 3.237402!
        Me.Line164.LineWeight = 1.0!
        Me.Line164.Name = "Line164"
        Me.Line164.Top = 0.4740158!
        Me.Line164.Width = 0.0!
        Me.Line164.X1 = 3.237402!
        Me.Line164.X2 = 3.237402!
        Me.Line164.Y1 = 0.4740158!
        Me.Line164.Y2 = 0.6996063!
        '
        'Line1
        '
        Me.Line1.Height = 0.4511807!
        Me.Line1.Left = 1.323622!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.6996063!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 1.323622!
        Me.Line1.X2 = 1.323622!
        Me.Line1.Y1 = 0.6996063!
        Me.Line1.Y2 = 1.150787!
        '
        'Line2
        '
        Me.Line2.Height = 0.2255905!
        Me.Line2.Left = 3.548425!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.6996063!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 3.548425!
        Me.Line2.X2 = 3.548425!
        Me.Line2.Y1 = 0.6996063!
        Me.Line2.Y2 = 0.9251968!
        '
        'Line5
        '
        Me.Line5.Height = 0.2255905!
        Me.Line5.Left = 4.507481!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.6996063!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 4.507481!
        Me.Line5.X2 = 4.507481!
        Me.Line5.Y1 = 0.6996063!
        Me.Line5.Y2 = 0.9251968!
        '
        'Line42
        '
        Me.Line42.Height = 9.700394!
        Me.Line42.Left = 0.0!
        Me.Line42.LineWeight = 1.0!
        Me.Line42.Name = "Line42"
        Me.Line42.Top = 0.4740158!
        Me.Line42.Width = 0.0!
        Me.Line42.X1 = 0.0!
        Me.Line42.X2 = 0.0!
        Me.Line42.Y1 = 0.4740158!
        Me.Line42.Y2 = 10.17441!
        '
        'Line23
        '
        Me.Line23.Height = 0.4511812!
        Me.Line23.Left = 1.612992!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 0.9251968!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 1.612992!
        Me.Line23.X2 = 1.612992!
        Me.Line23.Y1 = 0.9251968!
        Me.Line23.Y2 = 1.376378!
        '
        'Line26
        '
        Me.Line26.Height = 0.4511812!
        Me.Line26.Left = 2.194095!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.9251968!
        Me.Line26.Width = 0.0!
        Me.Line26.X1 = 2.194095!
        Me.Line26.X2 = 2.194095!
        Me.Line26.Y1 = 0.9251968!
        Me.Line26.Y2 = 1.376378!
        '
        'Label21
        '
        Me.Label21.Height = 0.2255906!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 3.236221!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label21.Text = "利用日"
        Me.Label21.Top = 1.150787!
        Me.Label21.Width = 0.3948819!
        '
        'ANS_TAXI_DATE_1
        '
        Me.ANS_TAXI_DATE_1.DataField = "ANS_TAXI_DATE_1"
        Me.ANS_TAXI_DATE_1.Height = 0.2255906!
        Me.ANS_TAXI_DATE_1.Left = 3.631102!
        Me.ANS_TAXI_DATE_1.Name = "ANS_TAXI_DATE_1"
        Me.ANS_TAXI_DATE_1.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_1.Text = Nothing
        Me.ANS_TAXI_DATE_1.Top = 1.150787!
        Me.ANS_TAXI_DATE_1.Width = 0.7472441!
        '
        'Label22
        '
        Me.Label22.Height = 0.2255906!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 4.378346!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label22.Text = "券種"
        Me.Label22.Top = 1.150787!
        Me.Label22.Width = 0.5464567!
        '
        'ANS_TAXI_KENSHU_1
        '
        Me.ANS_TAXI_KENSHU_1.DataField = "ANS_TAXI_KENSHU_1"
        Me.ANS_TAXI_KENSHU_1.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_1.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_1.Name = "ANS_TAXI_KENSHU_1"
        Me.ANS_TAXI_KENSHU_1.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_1.Text = Nothing
        Me.ANS_TAXI_KENSHU_1.Top = 1.150787!
        Me.ANS_TAXI_KENSHU_1.Width = 0.8944882!
        '
        'Label23
        '
        Me.Label23.Height = 0.2255906!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 3.236221!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label23.Text = "番号"
        Me.Label23.Top = 1.376378!
        Me.Label23.Width = 0.3948819!
        '
        'ANS_TAXI_NO_1
        '
        Me.ANS_TAXI_NO_1.DataField = "ANS_TAXI_NO_1"
        Me.ANS_TAXI_NO_1.Height = 0.2255906!
        Me.ANS_TAXI_NO_1.Left = 3.631102!
        Me.ANS_TAXI_NO_1.Name = "ANS_TAXI_NO_1"
        Me.ANS_TAXI_NO_1.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_1.Text = Nothing
        Me.ANS_TAXI_NO_1.Top = 1.376378!
        Me.ANS_TAXI_NO_1.Width = 0.7472441!
        '
        'ANS_TAXI_HAKKO_DATE_1
        '
        Me.ANS_TAXI_HAKKO_DATE_1.DataField = "ANS_TAXI_HAKKO_DATE_1"
        Me.ANS_TAXI_HAKKO_DATE_1.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_1.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_1.Name = "ANS_TAXI_HAKKO_DATE_1"
        Me.ANS_TAXI_HAKKO_DATE_1.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_1.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_1.Top = 1.150787!
        Me.ANS_TAXI_HAKKO_DATE_1.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_1
        '
        Me.ANS_TAXI_RMKS_1.DataField = "ANS_TAXI_RMKS_1"
        Me.ANS_TAXI_RMKS_1.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_1.Left = 6.361418!
        Me.ANS_TAXI_RMKS_1.Name = "ANS_TAXI_RMKS_1"
        Me.ANS_TAXI_RMKS_1.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_1.Text = Nothing
        Me.ANS_TAXI_RMKS_1.Top = 1.387008!
        Me.ANS_TAXI_RMKS_1.Width = 1.170079!
        '
        'Label27
        '
        Me.Label27.Height = 0.2255906!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 3.236221!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label27.Text = "利用日"
        Me.Label27.Top = 1.612599!
        Me.Label27.Width = 0.3948819!
        '
        'ANS_TAXI_DATE_2
        '
        Me.ANS_TAXI_DATE_2.DataField = "ANS_TAXI_DATE_2"
        Me.ANS_TAXI_DATE_2.Height = 0.2255906!
        Me.ANS_TAXI_DATE_2.Left = 3.631103!
        Me.ANS_TAXI_DATE_2.Name = "ANS_TAXI_DATE_2"
        Me.ANS_TAXI_DATE_2.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_2.Text = Nothing
        Me.ANS_TAXI_DATE_2.Top = 1.612599!
        Me.ANS_TAXI_DATE_2.Width = 0.7472441!
        '
        'Label28
        '
        Me.Label28.Height = 0.2255906!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 4.378346!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label28.Text = "券種"
        Me.Label28.Top = 1.612599!
        Me.Label28.Width = 0.5464567!
        '
        'ANS_TAXI_KENSHU_2
        '
        Me.ANS_TAXI_KENSHU_2.DataField = "ANS_TAXI_KENSHU_2"
        Me.ANS_TAXI_KENSHU_2.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_2.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_2.Name = "ANS_TAXI_KENSHU_2"
        Me.ANS_TAXI_KENSHU_2.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_2.Text = Nothing
        Me.ANS_TAXI_KENSHU_2.Top = 1.612599!
        Me.ANS_TAXI_KENSHU_2.Width = 0.8944882!
        '
        'ANS_TAXI_NO_2
        '
        Me.ANS_TAXI_NO_2.DataField = "ANS_TAXI_NO_2"
        Me.ANS_TAXI_NO_2.Height = 0.2255906!
        Me.ANS_TAXI_NO_2.Left = 3.631103!
        Me.ANS_TAXI_NO_2.Name = "ANS_TAXI_NO_2"
        Me.ANS_TAXI_NO_2.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_2.Text = Nothing
        Me.ANS_TAXI_NO_2.Top = 1.827559!
        Me.ANS_TAXI_NO_2.Width = 0.7472441!
        '
        'Label30
        '
        Me.Label30.Height = 0.2255906!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 5.966536!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label30.Text = "発行日"
        Me.Label30.Top = 1.612599!
        Me.Label30.Width = 0.3948819!
        '
        'ANS_TAXI_HAKKO_DATE_2
        '
        Me.ANS_TAXI_HAKKO_DATE_2.DataField = "ANS_TAXI_HAKKO_DATE_2"
        Me.ANS_TAXI_HAKKO_DATE_2.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_2.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_2.Name = "ANS_TAXI_HAKKO_DATE_2"
        Me.ANS_TAXI_HAKKO_DATE_2.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_2.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_2.Top = 1.612599!
        Me.ANS_TAXI_HAKKO_DATE_2.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_2
        '
        Me.ANS_TAXI_RMKS_2.DataField = "ANS_TAXI_RMKS_2"
        Me.ANS_TAXI_RMKS_2.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_2.Left = 6.299212!
        Me.ANS_TAXI_RMKS_2.Name = "ANS_TAXI_RMKS_2"
        Me.ANS_TAXI_RMKS_2.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_2.Text = Nothing
        Me.ANS_TAXI_RMKS_2.Top = 1.827559!
        Me.ANS_TAXI_RMKS_2.Width = 1.28937!
        '
        'ANS_TAXI_DATE_3
        '
        Me.ANS_TAXI_DATE_3.DataField = "ANS_TAXI_DATE_3"
        Me.ANS_TAXI_DATE_3.Height = 0.2255906!
        Me.ANS_TAXI_DATE_3.Left = 3.631103!
        Me.ANS_TAXI_DATE_3.Name = "ANS_TAXI_DATE_3"
        Me.ANS_TAXI_DATE_3.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_3.Text = Nothing
        Me.ANS_TAXI_DATE_3.Top = 2.05315!
        Me.ANS_TAXI_DATE_3.Width = 0.7472441!
        '
        'Label34
        '
        Me.Label34.Height = 0.2255906!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 4.378347!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label34.Text = "券種"
        Me.Label34.Top = 2.05315!
        Me.Label34.Width = 0.5464567!
        '
        'ANS_TAXI_KENSHU_3
        '
        Me.ANS_TAXI_KENSHU_3.DataField = "ANS_TAXI_KENSHU_3"
        Me.ANS_TAXI_KENSHU_3.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_3.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_3.Name = "ANS_TAXI_KENSHU_3"
        Me.ANS_TAXI_KENSHU_3.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_3.Text = Nothing
        Me.ANS_TAXI_KENSHU_3.Top = 2.05315!
        Me.ANS_TAXI_KENSHU_3.Width = 0.8944882!
        '
        'ANS_TAXI_NO_3
        '
        Me.ANS_TAXI_NO_3.DataField = "ANS_TAXI_NO_3"
        Me.ANS_TAXI_NO_3.Height = 0.2255906!
        Me.ANS_TAXI_NO_3.Left = 3.631103!
        Me.ANS_TAXI_NO_3.Name = "ANS_TAXI_NO_3"
        Me.ANS_TAXI_NO_3.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_3.Text = Nothing
        Me.ANS_TAXI_NO_3.Top = 2.27874!
        Me.ANS_TAXI_NO_3.Width = 0.7472441!
        '
        'Label36
        '
        Me.Label36.Height = 0.2255906!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 5.966536!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label36.Text = "発行日"
        Me.Label36.Top = 2.05315!
        Me.Label36.Width = 0.3948819!
        '
        'ANS_TAXI_HAKKO_DATE_3
        '
        Me.ANS_TAXI_HAKKO_DATE_3.DataField = "ANS_TAXI_HAKKO_DATE_3"
        Me.ANS_TAXI_HAKKO_DATE_3.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_3.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_3.Name = "ANS_TAXI_HAKKO_DATE_3"
        Me.ANS_TAXI_HAKKO_DATE_3.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_3.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_3.Top = 2.05315!
        Me.ANS_TAXI_HAKKO_DATE_3.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_3
        '
        Me.ANS_TAXI_RMKS_3.DataField = "ANS_TAXI_RMKS_3"
        Me.ANS_TAXI_RMKS_3.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_3.Left = 6.299212!
        Me.ANS_TAXI_RMKS_3.Name = "ANS_TAXI_RMKS_3"
        Me.ANS_TAXI_RMKS_3.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_3.Text = Nothing
        Me.ANS_TAXI_RMKS_3.Top = 2.27874!
        Me.ANS_TAXI_RMKS_3.Width = 1.28937!
        '
        'ANS_TAXI_DATE_4
        '
        Me.ANS_TAXI_DATE_4.DataField = "ANS_TAXI_DATE_4"
        Me.ANS_TAXI_DATE_4.Height = 0.2255906!
        Me.ANS_TAXI_DATE_4.Left = 3.631102!
        Me.ANS_TAXI_DATE_4.Name = "ANS_TAXI_DATE_4"
        Me.ANS_TAXI_DATE_4.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_4.Text = Nothing
        Me.ANS_TAXI_DATE_4.Top = 2.504331!
        Me.ANS_TAXI_DATE_4.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_4
        '
        Me.ANS_TAXI_KENSHU_4.DataField = "ANS_TAXI_KENSHU_4"
        Me.ANS_TAXI_KENSHU_4.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_4.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_4.Name = "ANS_TAXI_KENSHU_4"
        Me.ANS_TAXI_KENSHU_4.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_4.Text = Nothing
        Me.ANS_TAXI_KENSHU_4.Top = 2.504331!
        Me.ANS_TAXI_KENSHU_4.Width = 0.8944882!
        '
        'ANS_TAXI_NO_4
        '
        Me.ANS_TAXI_NO_4.DataField = "ANS_TAXI_NO_4"
        Me.ANS_TAXI_NO_4.Height = 0.2255906!
        Me.ANS_TAXI_NO_4.Left = 3.650787!
        Me.ANS_TAXI_NO_4.Name = "ANS_TAXI_NO_4"
        Me.ANS_TAXI_NO_4.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_4.Text = Nothing
        Me.ANS_TAXI_NO_4.Top = 2.729921!
        Me.ANS_TAXI_NO_4.Width = 0.7472437!
        '
        'ANS_TAXI_HAKKO_DATE_4
        '
        Me.ANS_TAXI_HAKKO_DATE_4.DataField = "ANS_TAXI_HAKKO_DATE_4"
        Me.ANS_TAXI_HAKKO_DATE_4.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_4.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_4.Name = "ANS_TAXI_HAKKO_DATE_4"
        Me.ANS_TAXI_HAKKO_DATE_4.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_4.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_4.Top = 2.504331!
        Me.ANS_TAXI_HAKKO_DATE_4.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_4
        '
        Me.ANS_TAXI_RMKS_4.DataField = "ANS_TAXI_RMKS_4"
        Me.ANS_TAXI_RMKS_4.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_4.Left = 6.299212!
        Me.ANS_TAXI_RMKS_4.Name = "ANS_TAXI_RMKS_4"
        Me.ANS_TAXI_RMKS_4.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_4.Text = Nothing
        Me.ANS_TAXI_RMKS_4.Top = 2.729921!
        Me.ANS_TAXI_RMKS_4.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_5
        '
        Me.ANS_TAXI_HAKKO_DATE_5.DataField = "ANS_TAXI_HAKKO_DATE_5"
        Me.ANS_TAXI_HAKKO_DATE_5.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_5.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_5.Name = "ANS_TAXI_HAKKO_DATE_5"
        Me.ANS_TAXI_HAKKO_DATE_5.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_5.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_5.Top = 2.955512!
        Me.ANS_TAXI_HAKKO_DATE_5.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_5
        '
        Me.ANS_TAXI_DATE_5.DataField = "ANS_TAXI_DATE_5"
        Me.ANS_TAXI_DATE_5.Height = 0.2255906!
        Me.ANS_TAXI_DATE_5.Left = 3.631103!
        Me.ANS_TAXI_DATE_5.Name = "ANS_TAXI_DATE_5"
        Me.ANS_TAXI_DATE_5.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_5.Text = Nothing
        Me.ANS_TAXI_DATE_5.Top = 2.955512!
        Me.ANS_TAXI_DATE_5.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_5
        '
        Me.ANS_TAXI_KENSHU_5.DataField = "ANS_TAXI_KENSHU_5"
        Me.ANS_TAXI_KENSHU_5.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_5.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_5.Name = "ANS_TAXI_KENSHU_5"
        Me.ANS_TAXI_KENSHU_5.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_5.Text = Nothing
        Me.ANS_TAXI_KENSHU_5.Top = 2.955512!
        Me.ANS_TAXI_KENSHU_5.Width = 0.8944882!
        '
        'ANS_TAXI_NO_5
        '
        Me.ANS_TAXI_NO_5.DataField = "ANS_TAXI_NO_5"
        Me.ANS_TAXI_NO_5.Height = 0.2255906!
        Me.ANS_TAXI_NO_5.Left = 3.631102!
        Me.ANS_TAXI_NO_5.Name = "ANS_TAXI_NO_5"
        Me.ANS_TAXI_NO_5.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_5.Text = Nothing
        Me.ANS_TAXI_NO_5.Top = 3.181102!
        Me.ANS_TAXI_NO_5.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_5
        '
        Me.ANS_TAXI_RMKS_5.DataField = "ANS_TAXI_RMKS_5"
        Me.ANS_TAXI_RMKS_5.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_5.Left = 6.361418!
        Me.ANS_TAXI_RMKS_5.Name = "ANS_TAXI_RMKS_5"
        Me.ANS_TAXI_RMKS_5.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_5.Text = Nothing
        Me.ANS_TAXI_RMKS_5.Top = 3.181102!
        Me.ANS_TAXI_RMKS_5.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_6
        '
        Me.ANS_TAXI_HAKKO_DATE_6.DataField = "ANS_TAXI_HAKKO_DATE_6"
        Me.ANS_TAXI_HAKKO_DATE_6.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_6.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_6.Name = "ANS_TAXI_HAKKO_DATE_6"
        Me.ANS_TAXI_HAKKO_DATE_6.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_6.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_6.Top = 3.406693!
        Me.ANS_TAXI_HAKKO_DATE_6.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_6
        '
        Me.ANS_TAXI_DATE_6.DataField = "ANS_TAXI_DATE_6"
        Me.ANS_TAXI_DATE_6.Height = 0.2255906!
        Me.ANS_TAXI_DATE_6.Left = 3.631103!
        Me.ANS_TAXI_DATE_6.Name = "ANS_TAXI_DATE_6"
        Me.ANS_TAXI_DATE_6.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_6.Text = Nothing
        Me.ANS_TAXI_DATE_6.Top = 3.406693!
        Me.ANS_TAXI_DATE_6.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_6
        '
        Me.ANS_TAXI_KENSHU_6.DataField = "ANS_TAXI_KENSHU_6"
        Me.ANS_TAXI_KENSHU_6.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_6.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_6.Name = "ANS_TAXI_KENSHU_6"
        Me.ANS_TAXI_KENSHU_6.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_6.Text = Nothing
        Me.ANS_TAXI_KENSHU_6.Top = 3.406693!
        Me.ANS_TAXI_KENSHU_6.Width = 0.8944882!
        '
        'ANS_TAXI_NO_6
        '
        Me.ANS_TAXI_NO_6.DataField = "ANS_TAXI_NO_6"
        Me.ANS_TAXI_NO_6.Height = 0.2255906!
        Me.ANS_TAXI_NO_6.Left = 3.631103!
        Me.ANS_TAXI_NO_6.Name = "ANS_TAXI_NO_6"
        Me.ANS_TAXI_NO_6.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_6.Text = Nothing
        Me.ANS_TAXI_NO_6.Top = 3.632283!
        Me.ANS_TAXI_NO_6.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_6
        '
        Me.ANS_TAXI_RMKS_6.DataField = "ANS_TAXI_RMKS_6"
        Me.ANS_TAXI_RMKS_6.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_6.Left = 6.361418!
        Me.ANS_TAXI_RMKS_6.Name = "ANS_TAXI_RMKS_6"
        Me.ANS_TAXI_RMKS_6.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_6.Text = Nothing
        Me.ANS_TAXI_RMKS_6.Top = 3.632283!
        Me.ANS_TAXI_RMKS_6.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_7
        '
        Me.ANS_TAXI_HAKKO_DATE_7.DataField = "ANS_TAXI_HAKKO_DATE_7"
        Me.ANS_TAXI_HAKKO_DATE_7.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_7.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_7.Name = "ANS_TAXI_HAKKO_DATE_7"
        Me.ANS_TAXI_HAKKO_DATE_7.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_7.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_7.Top = 3.857874!
        Me.ANS_TAXI_HAKKO_DATE_7.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_7
        '
        Me.ANS_TAXI_DATE_7.DataField = "ANS_TAXI_DATE_7"
        Me.ANS_TAXI_DATE_7.Height = 0.2255906!
        Me.ANS_TAXI_DATE_7.Left = 3.631103!
        Me.ANS_TAXI_DATE_7.Name = "ANS_TAXI_DATE_7"
        Me.ANS_TAXI_DATE_7.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_7.Text = Nothing
        Me.ANS_TAXI_DATE_7.Top = 3.857874!
        Me.ANS_TAXI_DATE_7.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_7
        '
        Me.ANS_TAXI_KENSHU_7.DataField = "ANS_TAXI_KENSHU_7"
        Me.ANS_TAXI_KENSHU_7.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_7.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_7.Name = "ANS_TAXI_KENSHU_7"
        Me.ANS_TAXI_KENSHU_7.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_7.Text = Nothing
        Me.ANS_TAXI_KENSHU_7.Top = 3.857874!
        Me.ANS_TAXI_KENSHU_7.Width = 0.8944882!
        '
        'ANS_TAXI_NO_7
        '
        Me.ANS_TAXI_NO_7.DataField = "ANS_TAXI_NO_7"
        Me.ANS_TAXI_NO_7.Height = 0.2255906!
        Me.ANS_TAXI_NO_7.Left = 3.631103!
        Me.ANS_TAXI_NO_7.Name = "ANS_TAXI_NO_7"
        Me.ANS_TAXI_NO_7.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_7.Text = Nothing
        Me.ANS_TAXI_NO_7.Top = 4.083465!
        Me.ANS_TAXI_NO_7.Width = 0.7692917!
        '
        'ANS_TAXI_RMKS_7
        '
        Me.ANS_TAXI_RMKS_7.DataField = "ANS_TAXI_RMKS_7"
        Me.ANS_TAXI_RMKS_7.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_7.Left = 6.361418!
        Me.ANS_TAXI_RMKS_7.Name = "ANS_TAXI_RMKS_7"
        Me.ANS_TAXI_RMKS_7.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_7.Text = Nothing
        Me.ANS_TAXI_RMKS_7.Top = 4.083465!
        Me.ANS_TAXI_RMKS_7.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_8
        '
        Me.ANS_TAXI_HAKKO_DATE_8.DataField = "ANS_TAXI_HAKKO_DATE_8"
        Me.ANS_TAXI_HAKKO_DATE_8.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_8.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_8.Name = "ANS_TAXI_HAKKO_DATE_8"
        Me.ANS_TAXI_HAKKO_DATE_8.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_8.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_8.Top = 4.309055!
        Me.ANS_TAXI_HAKKO_DATE_8.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_8
        '
        Me.ANS_TAXI_DATE_8.DataField = "ANS_TAXI_DATE_8"
        Me.ANS_TAXI_DATE_8.Height = 0.2255906!
        Me.ANS_TAXI_DATE_8.Left = 3.631103!
        Me.ANS_TAXI_DATE_8.Name = "ANS_TAXI_DATE_8"
        Me.ANS_TAXI_DATE_8.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_8.Text = Nothing
        Me.ANS_TAXI_DATE_8.Top = 4.309055!
        Me.ANS_TAXI_DATE_8.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_8
        '
        Me.ANS_TAXI_KENSHU_8.DataField = "ANS_TAXI_KENSHU_8"
        Me.ANS_TAXI_KENSHU_8.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_8.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_8.Name = "ANS_TAXI_KENSHU_8"
        Me.ANS_TAXI_KENSHU_8.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_8.Text = Nothing
        Me.ANS_TAXI_KENSHU_8.Top = 4.309055!
        Me.ANS_TAXI_KENSHU_8.Width = 0.8944882!
        '
        'ANS_TAXI_NO_8
        '
        Me.ANS_TAXI_NO_8.DataField = "ANS_TAXI_NO_8"
        Me.ANS_TAXI_NO_8.Height = 0.2255906!
        Me.ANS_TAXI_NO_8.Left = 3.631103!
        Me.ANS_TAXI_NO_8.Name = "ANS_TAXI_NO_8"
        Me.ANS_TAXI_NO_8.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_8.Text = Nothing
        Me.ANS_TAXI_NO_8.Top = 4.534646!
        Me.ANS_TAXI_NO_8.Width = 0.7692917!
        '
        'ANS_TAXI_RMKS_8
        '
        Me.ANS_TAXI_RMKS_8.DataField = "ANS_TAXI_RMKS_8"
        Me.ANS_TAXI_RMKS_8.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_8.Left = 6.361418!
        Me.ANS_TAXI_RMKS_8.Name = "ANS_TAXI_RMKS_8"
        Me.ANS_TAXI_RMKS_8.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_8.Text = Nothing
        Me.ANS_TAXI_RMKS_8.Top = 4.534646!
        Me.ANS_TAXI_RMKS_8.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_9
        '
        Me.ANS_TAXI_HAKKO_DATE_9.DataField = "ANS_TAXI_HAKKO_DATE_9"
        Me.ANS_TAXI_HAKKO_DATE_9.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_9.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_9.Name = "ANS_TAXI_HAKKO_DATE_9"
        Me.ANS_TAXI_HAKKO_DATE_9.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_9.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_9.Top = 4.760236!
        Me.ANS_TAXI_HAKKO_DATE_9.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_9
        '
        Me.ANS_TAXI_DATE_9.DataField = "ANS_TAXI_DATE_9"
        Me.ANS_TAXI_DATE_9.Height = 0.2255906!
        Me.ANS_TAXI_DATE_9.Left = 3.631103!
        Me.ANS_TAXI_DATE_9.Name = "ANS_TAXI_DATE_9"
        Me.ANS_TAXI_DATE_9.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_9.Text = Nothing
        Me.ANS_TAXI_DATE_9.Top = 4.760236!
        Me.ANS_TAXI_DATE_9.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_9
        '
        Me.ANS_TAXI_KENSHU_9.DataField = "ANS_TAXI_KENSHU_9"
        Me.ANS_TAXI_KENSHU_9.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_9.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_9.Name = "ANS_TAXI_KENSHU_9"
        Me.ANS_TAXI_KENSHU_9.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_9.Text = Nothing
        Me.ANS_TAXI_KENSHU_9.Top = 4.760236!
        Me.ANS_TAXI_KENSHU_9.Width = 0.8944882!
        '
        'ANS_TAXI_NO_9
        '
        Me.ANS_TAXI_NO_9.DataField = "ANS_TAXI_NO_9"
        Me.ANS_TAXI_NO_9.Height = 0.2255906!
        Me.ANS_TAXI_NO_9.Left = 3.631102!
        Me.ANS_TAXI_NO_9.Name = "ANS_TAXI_NO_9"
        Me.ANS_TAXI_NO_9.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_9.Text = Nothing
        Me.ANS_TAXI_NO_9.Top = 4.985826!
        Me.ANS_TAXI_NO_9.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_9
        '
        Me.ANS_TAXI_RMKS_9.DataField = "ANS_TAXI_RMKS_9"
        Me.ANS_TAXI_RMKS_9.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_9.Left = 6.361418!
        Me.ANS_TAXI_RMKS_9.Name = "ANS_TAXI_RMKS_9"
        Me.ANS_TAXI_RMKS_9.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_9.Text = Nothing
        Me.ANS_TAXI_RMKS_9.Top = 4.985826!
        Me.ANS_TAXI_RMKS_9.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_10
        '
        Me.ANS_TAXI_HAKKO_DATE_10.DataField = "ANS_TAXI_HAKKO_DATE_10"
        Me.ANS_TAXI_HAKKO_DATE_10.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_10.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_10.Name = "ANS_TAXI_HAKKO_DATE_10"
        Me.ANS_TAXI_HAKKO_DATE_10.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_10.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_10.Top = 5.211418!
        Me.ANS_TAXI_HAKKO_DATE_10.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_10
        '
        Me.ANS_TAXI_DATE_10.DataField = "ANS_TAXI_DATE_10"
        Me.ANS_TAXI_DATE_10.Height = 0.2255906!
        Me.ANS_TAXI_DATE_10.Left = 3.631103!
        Me.ANS_TAXI_DATE_10.Name = "ANS_TAXI_DATE_10"
        Me.ANS_TAXI_DATE_10.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_10.Text = Nothing
        Me.ANS_TAXI_DATE_10.Top = 5.211418!
        Me.ANS_TAXI_DATE_10.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_10
        '
        Me.ANS_TAXI_KENSHU_10.DataField = "ANS_TAXI_KENSHU_10"
        Me.ANS_TAXI_KENSHU_10.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_10.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_10.Name = "ANS_TAXI_KENSHU_10"
        Me.ANS_TAXI_KENSHU_10.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_10.Text = Nothing
        Me.ANS_TAXI_KENSHU_10.Top = 5.211418!
        Me.ANS_TAXI_KENSHU_10.Width = 0.8944882!
        '
        'ANS_TAXI_NO_10
        '
        Me.ANS_TAXI_NO_10.DataField = "ANS_TAXI_NO_10"
        Me.ANS_TAXI_NO_10.Height = 0.2255906!
        Me.ANS_TAXI_NO_10.Left = 3.631103!
        Me.ANS_TAXI_NO_10.Name = "ANS_TAXI_NO_10"
        Me.ANS_TAXI_NO_10.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_10.Text = Nothing
        Me.ANS_TAXI_NO_10.Top = 5.437008!
        Me.ANS_TAXI_NO_10.Width = 0.7472441!
        '
        'ANS_TAXI_RMKS_10
        '
        Me.ANS_TAXI_RMKS_10.DataField = "ANS_TAXI_RMKS_10"
        Me.ANS_TAXI_RMKS_10.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_10.Left = 6.361418!
        Me.ANS_TAXI_RMKS_10.Name = "ANS_TAXI_RMKS_10"
        Me.ANS_TAXI_RMKS_10.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_10.Text = Nothing
        Me.ANS_TAXI_RMKS_10.Top = 5.437008!
        Me.ANS_TAXI_RMKS_10.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_11
        '
        Me.ANS_TAXI_HAKKO_DATE_11.DataField = "ANS_TAXI_HAKKO_DATE_11"
        Me.ANS_TAXI_HAKKO_DATE_11.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_11.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_11.Name = "ANS_TAXI_HAKKO_DATE_11"
        Me.ANS_TAXI_HAKKO_DATE_11.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_11.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_11.Top = 5.662599!
        Me.ANS_TAXI_HAKKO_DATE_11.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_11
        '
        Me.ANS_TAXI_DATE_11.DataField = "ANS_TAXI_DATE_11"
        Me.ANS_TAXI_DATE_11.Height = 0.2255906!
        Me.ANS_TAXI_DATE_11.Left = 3.631103!
        Me.ANS_TAXI_DATE_11.Name = "ANS_TAXI_DATE_11"
        Me.ANS_TAXI_DATE_11.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_11.Text = Nothing
        Me.ANS_TAXI_DATE_11.Top = 5.662599!
        Me.ANS_TAXI_DATE_11.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_11
        '
        Me.ANS_TAXI_KENSHU_11.DataField = "ANS_TAXI_KENSHU_11"
        Me.ANS_TAXI_KENSHU_11.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_11.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_11.Name = "ANS_TAXI_KENSHU_11"
        Me.ANS_TAXI_KENSHU_11.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_11.Text = Nothing
        Me.ANS_TAXI_KENSHU_11.Top = 5.662599!
        Me.ANS_TAXI_KENSHU_11.Width = 0.8944882!
        '
        'ANS_TAXI_NO_11
        '
        Me.ANS_TAXI_NO_11.DataField = "ANS_TAXI_NO_11"
        Me.ANS_TAXI_NO_11.Height = 0.2255906!
        Me.ANS_TAXI_NO_11.Left = 3.631103!
        Me.ANS_TAXI_NO_11.Name = "ANS_TAXI_NO_11"
        Me.ANS_TAXI_NO_11.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_11.Text = Nothing
        Me.ANS_TAXI_NO_11.Top = 5.888189!
        Me.ANS_TAXI_NO_11.Width = 0.7692917!
        '
        'ANS_TAXI_RMKS_11
        '
        Me.ANS_TAXI_RMKS_11.DataField = "ANS_TAXI_RMKS_11"
        Me.ANS_TAXI_RMKS_11.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_11.Left = 6.361418!
        Me.ANS_TAXI_RMKS_11.Name = "ANS_TAXI_RMKS_11"
        Me.ANS_TAXI_RMKS_11.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_11.Text = Nothing
        Me.ANS_TAXI_RMKS_11.Top = 5.888189!
        Me.ANS_TAXI_RMKS_11.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_12
        '
        Me.ANS_TAXI_HAKKO_DATE_12.DataField = "ANS_TAXI_HAKKO_DATE_12"
        Me.ANS_TAXI_HAKKO_DATE_12.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_12.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_12.Name = "ANS_TAXI_HAKKO_DATE_12"
        Me.ANS_TAXI_HAKKO_DATE_12.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_12.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_12.Top = 6.11378!
        Me.ANS_TAXI_HAKKO_DATE_12.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_12
        '
        Me.ANS_TAXI_DATE_12.DataField = "ANS_TAXI_DATE_12"
        Me.ANS_TAXI_DATE_12.Height = 0.2255906!
        Me.ANS_TAXI_DATE_12.Left = 3.631102!
        Me.ANS_TAXI_DATE_12.Name = "ANS_TAXI_DATE_12"
        Me.ANS_TAXI_DATE_12.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_12.Text = Nothing
        Me.ANS_TAXI_DATE_12.Top = 6.11378!
        Me.ANS_TAXI_DATE_12.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_12
        '
        Me.ANS_TAXI_KENSHU_12.DataField = "ANS_TAXI_KENSHU_12"
        Me.ANS_TAXI_KENSHU_12.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_12.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_12.Name = "ANS_TAXI_KENSHU_12"
        Me.ANS_TAXI_KENSHU_12.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_12.Text = Nothing
        Me.ANS_TAXI_KENSHU_12.Top = 6.11378!
        Me.ANS_TAXI_KENSHU_12.Width = 0.8944882!
        '
        'ANS_TAXI_NO_12
        '
        Me.ANS_TAXI_NO_12.DataField = "ANS_TAXI_NO_12"
        Me.ANS_TAXI_NO_12.Height = 0.2255906!
        Me.ANS_TAXI_NO_12.Left = 3.631102!
        Me.ANS_TAXI_NO_12.Name = "ANS_TAXI_NO_12"
        Me.ANS_TAXI_NO_12.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_12.Text = Nothing
        Me.ANS_TAXI_NO_12.Top = 6.33937!
        Me.ANS_TAXI_NO_12.Width = 0.7692917!
        '
        'Label130
        '
        Me.Label130.Height = 0.4511811!
        Me.Label130.HyperLink = Nothing
        Me.Label130.Left = 2.787402!
        Me.Label130.Name = "Label130"
        Me.Label130.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label130.Text = "ﾀｸﾁｹ12"
        Me.Label130.Top = 6.11378!
        Me.Label130.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_12
        '
        Me.ANS_TAXI_RMKS_12.DataField = "ANS_TAXI_RMKS_12"
        Me.ANS_TAXI_RMKS_12.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_12.Left = 6.361418!
        Me.ANS_TAXI_RMKS_12.Name = "ANS_TAXI_RMKS_12"
        Me.ANS_TAXI_RMKS_12.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_12.Text = Nothing
        Me.ANS_TAXI_RMKS_12.Top = 6.33937!
        Me.ANS_TAXI_RMKS_12.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_13
        '
        Me.ANS_TAXI_HAKKO_DATE_13.DataField = "ANS_TAXI_HAKKO_DATE_13"
        Me.ANS_TAXI_HAKKO_DATE_13.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_13.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_13.Name = "ANS_TAXI_HAKKO_DATE_13"
        Me.ANS_TAXI_HAKKO_DATE_13.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_13.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_13.Top = 6.56496!
        Me.ANS_TAXI_HAKKO_DATE_13.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_13
        '
        Me.ANS_TAXI_DATE_13.DataField = "ANS_TAXI_DATE_13"
        Me.ANS_TAXI_DATE_13.Height = 0.2255906!
        Me.ANS_TAXI_DATE_13.Left = 3.631102!
        Me.ANS_TAXI_DATE_13.Name = "ANS_TAXI_DATE_13"
        Me.ANS_TAXI_DATE_13.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_13.Text = Nothing
        Me.ANS_TAXI_DATE_13.Top = 6.56496!
        Me.ANS_TAXI_DATE_13.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_13
        '
        Me.ANS_TAXI_KENSHU_13.DataField = "ANS_TAXI_KENSHU_13"
        Me.ANS_TAXI_KENSHU_13.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_13.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_13.Name = "ANS_TAXI_KENSHU_13"
        Me.ANS_TAXI_KENSHU_13.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_13.Text = Nothing
        Me.ANS_TAXI_KENSHU_13.Top = 6.56496!
        Me.ANS_TAXI_KENSHU_13.Width = 0.8944882!
        '
        'ANS_TAXI_NO_13
        '
        Me.ANS_TAXI_NO_13.DataField = "ANS_TAXI_NO_13"
        Me.ANS_TAXI_NO_13.Height = 0.2255906!
        Me.ANS_TAXI_NO_13.Left = 3.631103!
        Me.ANS_TAXI_NO_13.Name = "ANS_TAXI_NO_13"
        Me.ANS_TAXI_NO_13.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_13.Text = Nothing
        Me.ANS_TAXI_NO_13.Top = 6.790551!
        Me.ANS_TAXI_NO_13.Width = 0.7692917!
        '
        'Label136
        '
        Me.Label136.Height = 0.4511811!
        Me.Label136.HyperLink = Nothing
        Me.Label136.Left = 2.787402!
        Me.Label136.Name = "Label136"
        Me.Label136.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label136.Text = "ﾀｸﾁｹ13"
        Me.Label136.Top = 6.56496!
        Me.Label136.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_13
        '
        Me.ANS_TAXI_RMKS_13.DataField = "ANS_TAXI_RMKS_13"
        Me.ANS_TAXI_RMKS_13.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_13.Left = 6.361418!
        Me.ANS_TAXI_RMKS_13.Name = "ANS_TAXI_RMKS_13"
        Me.ANS_TAXI_RMKS_13.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_13.Text = Nothing
        Me.ANS_TAXI_RMKS_13.Top = 6.790551!
        Me.ANS_TAXI_RMKS_13.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_14
        '
        Me.ANS_TAXI_HAKKO_DATE_14.DataField = "ANS_TAXI_HAKKO_DATE_14"
        Me.ANS_TAXI_HAKKO_DATE_14.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_14.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_14.Name = "ANS_TAXI_HAKKO_DATE_14"
        Me.ANS_TAXI_HAKKO_DATE_14.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_14.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_14.Top = 7.016141!
        Me.ANS_TAXI_HAKKO_DATE_14.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_14
        '
        Me.ANS_TAXI_DATE_14.DataField = "ANS_TAXI_DATE_14"
        Me.ANS_TAXI_DATE_14.Height = 0.2255906!
        Me.ANS_TAXI_DATE_14.Left = 3.631103!
        Me.ANS_TAXI_DATE_14.Name = "ANS_TAXI_DATE_14"
        Me.ANS_TAXI_DATE_14.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_14.Text = Nothing
        Me.ANS_TAXI_DATE_14.Top = 7.016141!
        Me.ANS_TAXI_DATE_14.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_14
        '
        Me.ANS_TAXI_KENSHU_14.DataField = "ANS_TAXI_KENSHU_14"
        Me.ANS_TAXI_KENSHU_14.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_14.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_14.Name = "ANS_TAXI_KENSHU_14"
        Me.ANS_TAXI_KENSHU_14.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_14.Text = Nothing
        Me.ANS_TAXI_KENSHU_14.Top = 7.016141!
        Me.ANS_TAXI_KENSHU_14.Width = 0.8944882!
        '
        'ANS_TAXI_NO_14
        '
        Me.ANS_TAXI_NO_14.DataField = "ANS_TAXI_NO_14"
        Me.ANS_TAXI_NO_14.Height = 0.2255906!
        Me.ANS_TAXI_NO_14.Left = 3.631103!
        Me.ANS_TAXI_NO_14.Name = "ANS_TAXI_NO_14"
        Me.ANS_TAXI_NO_14.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_14.Text = Nothing
        Me.ANS_TAXI_NO_14.Top = 7.241732!
        Me.ANS_TAXI_NO_14.Width = 0.7692917!
        '
        'Label142
        '
        Me.Label142.Height = 0.4511811!
        Me.Label142.HyperLink = Nothing
        Me.Label142.Left = 2.787402!
        Me.Label142.Name = "Label142"
        Me.Label142.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label142.Text = "ﾀｸﾁｹ14"
        Me.Label142.Top = 7.016141!
        Me.Label142.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_14
        '
        Me.ANS_TAXI_RMKS_14.DataField = "ANS_TAXI_RMKS_14"
        Me.ANS_TAXI_RMKS_14.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_14.Left = 6.361418!
        Me.ANS_TAXI_RMKS_14.Name = "ANS_TAXI_RMKS_14"
        Me.ANS_TAXI_RMKS_14.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_14.Text = Nothing
        Me.ANS_TAXI_RMKS_14.Top = 7.241732!
        Me.ANS_TAXI_RMKS_14.Width = 1.28937!
        '
        'ANS_TAXI_RMKS_15
        '
        Me.ANS_TAXI_RMKS_15.DataField = "ANS_TAXI_RMKS_15"
        Me.ANS_TAXI_RMKS_15.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_15.Left = 6.361418!
        Me.ANS_TAXI_RMKS_15.Name = "ANS_TAXI_RMKS_15"
        Me.ANS_TAXI_RMKS_15.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_15.Text = Nothing
        Me.ANS_TAXI_RMKS_15.Top = 7.692914!
        Me.ANS_TAXI_RMKS_15.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_15
        '
        Me.ANS_TAXI_HAKKO_DATE_15.DataField = "ANS_TAXI_HAKKO_DATE_15"
        Me.ANS_TAXI_HAKKO_DATE_15.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_15.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_15.Name = "ANS_TAXI_HAKKO_DATE_15"
        Me.ANS_TAXI_HAKKO_DATE_15.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_15.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_15.Top = 7.467322!
        Me.ANS_TAXI_HAKKO_DATE_15.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_15
        '
        Me.ANS_TAXI_DATE_15.DataField = "ANS_TAXI_DATE_15"
        Me.ANS_TAXI_DATE_15.Height = 0.2255906!
        Me.ANS_TAXI_DATE_15.Left = 3.631103!
        Me.ANS_TAXI_DATE_15.Name = "ANS_TAXI_DATE_15"
        Me.ANS_TAXI_DATE_15.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_15.Text = Nothing
        Me.ANS_TAXI_DATE_15.Top = 7.467322!
        Me.ANS_TAXI_DATE_15.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_15
        '
        Me.ANS_TAXI_KENSHU_15.DataField = "ANS_TAXI_KENSHU_15"
        Me.ANS_TAXI_KENSHU_15.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_15.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_15.Name = "ANS_TAXI_KENSHU_15"
        Me.ANS_TAXI_KENSHU_15.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_15.Text = Nothing
        Me.ANS_TAXI_KENSHU_15.Top = 7.467322!
        Me.ANS_TAXI_KENSHU_15.Width = 0.8944882!
        '
        'ANS_TAXI_NO_15
        '
        Me.ANS_TAXI_NO_15.DataField = "ANS_TAXI_NO_15"
        Me.ANS_TAXI_NO_15.Height = 0.2255906!
        Me.ANS_TAXI_NO_15.Left = 3.631103!
        Me.ANS_TAXI_NO_15.Name = "ANS_TAXI_NO_15"
        Me.ANS_TAXI_NO_15.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_15.Text = Nothing
        Me.ANS_TAXI_NO_15.Top = 7.692914!
        Me.ANS_TAXI_NO_15.Width = 0.7692917!
        '
        'Label148
        '
        Me.Label148.Height = 0.4511811!
        Me.Label148.HyperLink = Nothing
        Me.Label148.Left = 2.787402!
        Me.Label148.Name = "Label148"
        Me.Label148.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label148.Text = "ﾀｸﾁｹ15"
        Me.Label148.Top = 7.467322!
        Me.Label148.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_16
        '
        Me.ANS_TAXI_RMKS_16.DataField = "ANS_TAXI_RMKS_16"
        Me.ANS_TAXI_RMKS_16.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_16.Left = 6.361418!
        Me.ANS_TAXI_RMKS_16.Name = "ANS_TAXI_RMKS_16"
        Me.ANS_TAXI_RMKS_16.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_16.Text = Nothing
        Me.ANS_TAXI_RMKS_16.Top = 8.144094!
        Me.ANS_TAXI_RMKS_16.Width = 1.28937!
        '
        'ANS_TAXI_DATE_16
        '
        Me.ANS_TAXI_DATE_16.DataField = "ANS_TAXI_DATE_16"
        Me.ANS_TAXI_DATE_16.Height = 0.2255906!
        Me.ANS_TAXI_DATE_16.Left = 3.631103!
        Me.ANS_TAXI_DATE_16.Name = "ANS_TAXI_DATE_16"
        Me.ANS_TAXI_DATE_16.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_16.Text = Nothing
        Me.ANS_TAXI_DATE_16.Top = 7.918504!
        Me.ANS_TAXI_DATE_16.Width = 0.7472441!
        '
        'ANS_TAXI_NO_16
        '
        Me.ANS_TAXI_NO_16.DataField = "ANS_TAXI_NO_16"
        Me.ANS_TAXI_NO_16.Height = 0.2255906!
        Me.ANS_TAXI_NO_16.Left = 3.631103!
        Me.ANS_TAXI_NO_16.Name = "ANS_TAXI_NO_16"
        Me.ANS_TAXI_NO_16.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_16.Text = Nothing
        Me.ANS_TAXI_NO_16.Top = 8.144094!
        Me.ANS_TAXI_NO_16.Width = 0.7692917!
        '
        'Label154
        '
        Me.Label154.Height = 0.4511811!
        Me.Label154.HyperLink = Nothing
        Me.Label154.Left = 2.787402!
        Me.Label154.Name = "Label154"
        Me.Label154.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label154.Text = "ﾀｸﾁｹ16"
        Me.Label154.Top = 7.918504!
        Me.Label154.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_17
        '
        Me.ANS_TAXI_RMKS_17.DataField = "ANS_TAXI_RMKS_17"
        Me.ANS_TAXI_RMKS_17.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_17.Left = 6.361418!
        Me.ANS_TAXI_RMKS_17.Name = "ANS_TAXI_RMKS_17"
        Me.ANS_TAXI_RMKS_17.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_17.Text = Nothing
        Me.ANS_TAXI_RMKS_17.Top = 8.595276!
        Me.ANS_TAXI_RMKS_17.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_17
        '
        Me.ANS_TAXI_HAKKO_DATE_17.DataField = "ANS_TAXI_HAKKO_DATE_17"
        Me.ANS_TAXI_HAKKO_DATE_17.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_17.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_17.Name = "ANS_TAXI_HAKKO_DATE_17"
        Me.ANS_TAXI_HAKKO_DATE_17.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_17.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_17.Top = 8.369685!
        Me.ANS_TAXI_HAKKO_DATE_17.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_17
        '
        Me.ANS_TAXI_DATE_17.DataField = "ANS_TAXI_DATE_17"
        Me.ANS_TAXI_DATE_17.Height = 0.2255906!
        Me.ANS_TAXI_DATE_17.Left = 3.631103!
        Me.ANS_TAXI_DATE_17.Name = "ANS_TAXI_DATE_17"
        Me.ANS_TAXI_DATE_17.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_17.Text = Nothing
        Me.ANS_TAXI_DATE_17.Top = 8.369685!
        Me.ANS_TAXI_DATE_17.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_17
        '
        Me.ANS_TAXI_KENSHU_17.DataField = "ANS_TAXI_KENSHU_17"
        Me.ANS_TAXI_KENSHU_17.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_17.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_17.Name = "ANS_TAXI_KENSHU_17"
        Me.ANS_TAXI_KENSHU_17.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_17.Text = Nothing
        Me.ANS_TAXI_KENSHU_17.Top = 8.369685!
        Me.ANS_TAXI_KENSHU_17.Width = 0.8944882!
        '
        'ANS_TAXI_NO_17
        '
        Me.ANS_TAXI_NO_17.DataField = "ANS_TAXI_NO_17"
        Me.ANS_TAXI_NO_17.Height = 0.2255906!
        Me.ANS_TAXI_NO_17.Left = 3.631103!
        Me.ANS_TAXI_NO_17.Name = "ANS_TAXI_NO_17"
        Me.ANS_TAXI_NO_17.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_17.Text = Nothing
        Me.ANS_TAXI_NO_17.Top = 8.595276!
        Me.ANS_TAXI_NO_17.Width = 0.7692917!
        '
        'Label160
        '
        Me.Label160.Height = 0.4511811!
        Me.Label160.HyperLink = Nothing
        Me.Label160.Left = 2.787402!
        Me.Label160.Name = "Label160"
        Me.Label160.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label160.Text = "ﾀｸﾁｹ17"
        Me.Label160.Top = 8.369685!
        Me.Label160.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_18
        '
        Me.ANS_TAXI_RMKS_18.DataField = "ANS_TAXI_RMKS_18"
        Me.ANS_TAXI_RMKS_18.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_18.Left = 6.361418!
        Me.ANS_TAXI_RMKS_18.Name = "ANS_TAXI_RMKS_18"
        Me.ANS_TAXI_RMKS_18.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_18.Text = Nothing
        Me.ANS_TAXI_RMKS_18.Top = 9.046457!
        Me.ANS_TAXI_RMKS_18.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_18
        '
        Me.ANS_TAXI_HAKKO_DATE_18.DataField = "ANS_TAXI_HAKKO_DATE_18"
        Me.ANS_TAXI_HAKKO_DATE_18.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_18.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_18.Name = "ANS_TAXI_HAKKO_DATE_18"
        Me.ANS_TAXI_HAKKO_DATE_18.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_18.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_18.Top = 8.820867!
        Me.ANS_TAXI_HAKKO_DATE_18.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_18
        '
        Me.ANS_TAXI_DATE_18.DataField = "ANS_TAXI_DATE_18"
        Me.ANS_TAXI_DATE_18.Height = 0.2255906!
        Me.ANS_TAXI_DATE_18.Left = 3.631103!
        Me.ANS_TAXI_DATE_18.Name = "ANS_TAXI_DATE_18"
        Me.ANS_TAXI_DATE_18.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_18.Text = Nothing
        Me.ANS_TAXI_DATE_18.Top = 8.820867!
        Me.ANS_TAXI_DATE_18.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_18
        '
        Me.ANS_TAXI_KENSHU_18.DataField = "ANS_TAXI_KENSHU_18"
        Me.ANS_TAXI_KENSHU_18.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_18.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_18.Name = "ANS_TAXI_KENSHU_18"
        Me.ANS_TAXI_KENSHU_18.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_18.Text = Nothing
        Me.ANS_TAXI_KENSHU_18.Top = 8.820867!
        Me.ANS_TAXI_KENSHU_18.Width = 0.8944882!
        '
        'ANS_TAXI_NO_18
        '
        Me.ANS_TAXI_NO_18.DataField = "ANS_TAXI_NO_18"
        Me.ANS_TAXI_NO_18.Height = 0.2255906!
        Me.ANS_TAXI_NO_18.Left = 3.631103!
        Me.ANS_TAXI_NO_18.Name = "ANS_TAXI_NO_18"
        Me.ANS_TAXI_NO_18.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_18.Text = Nothing
        Me.ANS_TAXI_NO_18.Top = 9.046457!
        Me.ANS_TAXI_NO_18.Width = 0.7692917!
        '
        'Label166
        '
        Me.Label166.Height = 0.4511811!
        Me.Label166.HyperLink = Nothing
        Me.Label166.Left = 2.787402!
        Me.Label166.Name = "Label166"
        Me.Label166.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label166.Text = "ﾀｸﾁｹ18"
        Me.Label166.Top = 8.820867!
        Me.Label166.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_19
        '
        Me.ANS_TAXI_RMKS_19.DataField = "ANS_TAXI_RMKS_19"
        Me.ANS_TAXI_RMKS_19.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_19.Left = 6.361418!
        Me.ANS_TAXI_RMKS_19.Name = "ANS_TAXI_RMKS_19"
        Me.ANS_TAXI_RMKS_19.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_19.Text = Nothing
        Me.ANS_TAXI_RMKS_19.Top = 9.497638!
        Me.ANS_TAXI_RMKS_19.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_19
        '
        Me.ANS_TAXI_HAKKO_DATE_19.DataField = "ANS_TAXI_HAKKO_DATE_19"
        Me.ANS_TAXI_HAKKO_DATE_19.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_19.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_19.Name = "ANS_TAXI_HAKKO_DATE_19"
        Me.ANS_TAXI_HAKKO_DATE_19.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_19.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_19.Top = 9.272048!
        Me.ANS_TAXI_HAKKO_DATE_19.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_19
        '
        Me.ANS_TAXI_DATE_19.DataField = "ANS_TAXI_DATE_19"
        Me.ANS_TAXI_DATE_19.Height = 0.2255906!
        Me.ANS_TAXI_DATE_19.Left = 3.631103!
        Me.ANS_TAXI_DATE_19.Name = "ANS_TAXI_DATE_19"
        Me.ANS_TAXI_DATE_19.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_19.Text = Nothing
        Me.ANS_TAXI_DATE_19.Top = 9.272048!
        Me.ANS_TAXI_DATE_19.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_19
        '
        Me.ANS_TAXI_KENSHU_19.DataField = "ANS_TAXI_KENSHU_19"
        Me.ANS_TAXI_KENSHU_19.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_19.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_19.Name = "ANS_TAXI_KENSHU_19"
        Me.ANS_TAXI_KENSHU_19.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_19.Text = Nothing
        Me.ANS_TAXI_KENSHU_19.Top = 9.272048!
        Me.ANS_TAXI_KENSHU_19.Width = 0.8944882!
        '
        'ANS_TAXI_NO_19
        '
        Me.ANS_TAXI_NO_19.DataField = "ANS_TAXI_NO_19"
        Me.ANS_TAXI_NO_19.Height = 0.2255906!
        Me.ANS_TAXI_NO_19.Left = 3.631103!
        Me.ANS_TAXI_NO_19.Name = "ANS_TAXI_NO_19"
        Me.ANS_TAXI_NO_19.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_19.Text = Nothing
        Me.ANS_TAXI_NO_19.Top = 9.497638!
        Me.ANS_TAXI_NO_19.Width = 0.7692917!
        '
        'Label172
        '
        Me.Label172.Height = 0.4511811!
        Me.Label172.HyperLink = Nothing
        Me.Label172.Left = 2.787402!
        Me.Label172.Name = "Label172"
        Me.Label172.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label172.Text = "ﾀｸﾁｹ19"
        Me.Label172.Top = 9.272048!
        Me.Label172.Width = 0.4488189!
        '
        'ANS_TAXI_RMKS_20
        '
        Me.ANS_TAXI_RMKS_20.DataField = "ANS_TAXI_RMKS_20"
        Me.ANS_TAXI_RMKS_20.Height = 0.2255906!
        Me.ANS_TAXI_RMKS_20.Left = 6.361418!
        Me.ANS_TAXI_RMKS_20.Name = "ANS_TAXI_RMKS_20"
        Me.ANS_TAXI_RMKS_20.Style = "vertical-align: middle"
        Me.ANS_TAXI_RMKS_20.Text = Nothing
        Me.ANS_TAXI_RMKS_20.Top = 9.948819!
        Me.ANS_TAXI_RMKS_20.Width = 1.28937!
        '
        'ANS_TAXI_HAKKO_DATE_20
        '
        Me.ANS_TAXI_HAKKO_DATE_20.DataField = "ANS_TAXI_HAKKO_DATE_20"
        Me.ANS_TAXI_HAKKO_DATE_20.Height = 0.2255906!
        Me.ANS_TAXI_HAKKO_DATE_20.Left = 6.361418!
        Me.ANS_TAXI_HAKKO_DATE_20.Name = "ANS_TAXI_HAKKO_DATE_20"
        Me.ANS_TAXI_HAKKO_DATE_20.Style = "vertical-align: middle"
        Me.ANS_TAXI_HAKKO_DATE_20.Text = Nothing
        Me.ANS_TAXI_HAKKO_DATE_20.Top = 9.723228!
        Me.ANS_TAXI_HAKKO_DATE_20.Width = 0.7472441!
        '
        'ANS_TAXI_DATE_20
        '
        Me.ANS_TAXI_DATE_20.DataField = "ANS_TAXI_DATE_20"
        Me.ANS_TAXI_DATE_20.Height = 0.2255906!
        Me.ANS_TAXI_DATE_20.Left = 3.631103!
        Me.ANS_TAXI_DATE_20.Name = "ANS_TAXI_DATE_20"
        Me.ANS_TAXI_DATE_20.Style = "vertical-align: middle"
        Me.ANS_TAXI_DATE_20.Text = Nothing
        Me.ANS_TAXI_DATE_20.Top = 9.723228!
        Me.ANS_TAXI_DATE_20.Width = 0.7472441!
        '
        'ANS_TAXI_KENSHU_20
        '
        Me.ANS_TAXI_KENSHU_20.DataField = "ANS_TAXI_KENSHU_20"
        Me.ANS_TAXI_KENSHU_20.Height = 0.2255906!
        Me.ANS_TAXI_KENSHU_20.Left = 4.924803!
        Me.ANS_TAXI_KENSHU_20.Name = "ANS_TAXI_KENSHU_20"
        Me.ANS_TAXI_KENSHU_20.Style = "vertical-align: middle"
        Me.ANS_TAXI_KENSHU_20.Text = Nothing
        Me.ANS_TAXI_KENSHU_20.Top = 9.723228!
        Me.ANS_TAXI_KENSHU_20.Width = 0.8944882!
        '
        'ANS_TAXI_NO_20
        '
        Me.ANS_TAXI_NO_20.DataField = "ANS_TAXI_NO_20"
        Me.ANS_TAXI_NO_20.Height = 0.2255906!
        Me.ANS_TAXI_NO_20.Left = 3.631103!
        Me.ANS_TAXI_NO_20.Name = "ANS_TAXI_NO_20"
        Me.ANS_TAXI_NO_20.Style = "vertical-align: middle"
        Me.ANS_TAXI_NO_20.Text = Nothing
        Me.ANS_TAXI_NO_20.Top = 9.948819!
        Me.ANS_TAXI_NO_20.Width = 0.7692917!
        '
        'Label20
        '
        Me.Label20.Height = 0.4511811!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 2.787402!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label20.Text = "ﾀｸﾁｹ1"
        Me.Label20.Top = 1.150787!
        Me.Label20.Width = 0.4488189!
        '
        'Label26
        '
        Me.Label26.Height = 0.4511811!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 2.787402!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label26.Text = "ﾀｸﾁｹ2"
        Me.Label26.Top = 1.612599!
        Me.Label26.Width = 0.4488189!
        '
        'Label32
        '
        Me.Label32.Height = 0.4511811!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 2.787402!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label32.Text = "ﾀｸﾁｹ3"
        Me.Label32.Top = 2.05315!
        Me.Label32.Width = 0.4488189!
        '
        'Label38
        '
        Me.Label38.Height = 0.4511811!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 2.787402!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label38.Text = "ﾀｸﾁｹ4"
        Me.Label38.Top = 2.504331!
        Me.Label38.Width = 0.4488189!
        '
        'Label69
        '
        Me.Label69.Height = 0.4511811!
        Me.Label69.HyperLink = Nothing
        Me.Label69.Left = 2.787402!
        Me.Label69.Name = "Label69"
        Me.Label69.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label69.Text = "ﾀｸﾁｹ5"
        Me.Label69.Top = 2.955512!
        Me.Label69.Width = 0.4488189!
        '
        'Label94
        '
        Me.Label94.Height = 0.4511811!
        Me.Label94.HyperLink = Nothing
        Me.Label94.Left = 2.787402!
        Me.Label94.Name = "Label94"
        Me.Label94.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label94.Text = "ﾀｸﾁｹ6"
        Me.Label94.Top = 3.406693!
        Me.Label94.Width = 0.4488189!
        '
        'Label100
        '
        Me.Label100.Height = 0.4511811!
        Me.Label100.HyperLink = Nothing
        Me.Label100.Left = 2.787402!
        Me.Label100.Name = "Label100"
        Me.Label100.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label100.Text = "ﾀｸﾁｹ7"
        Me.Label100.Top = 3.857874!
        Me.Label100.Width = 0.4488189!
        '
        'Label106
        '
        Me.Label106.Height = 0.4511811!
        Me.Label106.HyperLink = Nothing
        Me.Label106.Left = 2.787402!
        Me.Label106.Name = "Label106"
        Me.Label106.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label106.Text = "ﾀｸﾁｹ8"
        Me.Label106.Top = 4.309055!
        Me.Label106.Width = 0.4488189!
        '
        'Label112
        '
        Me.Label112.Height = 0.4511811!
        Me.Label112.HyperLink = Nothing
        Me.Label112.Left = 2.787402!
        Me.Label112.Name = "Label112"
        Me.Label112.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label112.Text = "ﾀｸﾁｹ9"
        Me.Label112.Top = 4.760236!
        Me.Label112.Width = 0.4488189!
        '
        'Label118
        '
        Me.Label118.Height = 0.4511811!
        Me.Label118.HyperLink = Nothing
        Me.Label118.Left = 2.787402!
        Me.Label118.Name = "Label118"
        Me.Label118.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; vertical-align: middle; white-space: inheri" & _
            "t; ddo-font-vertical: none"
        Me.Label118.Text = "ﾀｸﾁｹ10"
        Me.Label118.Top = 5.211418!
        Me.Label118.Width = 0.4488189!
        '
        'Line36
        '
        Me.Line36.Height = 9.700394!
        Me.Line36.Left = 7.641732!
        Me.Line36.LineWeight = 1.0!
        Me.Line36.Name = "Line36"
        Me.Line36.Top = 0.4740157!
        Me.Line36.Width = 0.0!
        Me.Line36.X1 = 7.641732!
        Me.Line36.X2 = 7.641732!
        Me.Line36.Y1 = 0.4740157!
        Me.Line36.Y2 = 10.17441!
        '
        'Line104
        '
        Me.Line104.Height = 0.0!
        Me.Line104.Left = 2.842171E-14!
        Me.Line104.LineWeight = 1.0!
        Me.Line104.Name = "Line104"
        Me.Line104.Top = 5.888189!
        Me.Line104.Width = 2.787402!
        Me.Line104.X1 = 2.842171E-14!
        Me.Line104.X2 = 2.787402!
        Me.Line104.Y1 = 5.888189!
        Me.Line104.Y2 = 5.888189!
        '
        'Label181
        '
        Me.Label181.Height = 0.2255906!
        Me.Label181.HyperLink = Nothing
        Me.Label181.Left = 1.862645E-9!
        Me.Label181.Name = "Label181"
        Me.Label181.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label181.Text = "備考（回答）"
        Me.Label181.Top = 7.177953!
        Me.Label181.Width = 2.787402!
        '
        'REQ_O_TEHAI_1
        '
        Me.REQ_O_TEHAI_1.DataField = "REQ_O_TEHAI_1"
        Me.REQ_O_TEHAI_1.Height = 0.2!
        Me.REQ_O_TEHAI_1.Left = 0.0!
        Me.REQ_O_TEHAI_1.Name = "REQ_O_TEHAI_1"
        Me.REQ_O_TEHAI_1.Text = Nothing
        Me.REQ_O_TEHAI_1.Top = 10.86614!
        Me.REQ_O_TEHAI_1.Visible = False
        Me.REQ_O_TEHAI_1.Width = 1.0!
        '
        'REQ_O_TEHAI_2
        '
        Me.REQ_O_TEHAI_2.DataField = "REQ_O_TEHAI_2"
        Me.REQ_O_TEHAI_2.Height = 0.2!
        Me.REQ_O_TEHAI_2.Left = 4.064567!
        Me.REQ_O_TEHAI_2.Name = "REQ_O_TEHAI_2"
        Me.REQ_O_TEHAI_2.Text = Nothing
        Me.REQ_O_TEHAI_2.Top = 11.17874!
        Me.REQ_O_TEHAI_2.Visible = False
        Me.REQ_O_TEHAI_2.Width = 1.0!
        '
        'REQ_O_TEHAI_3
        '
        Me.REQ_O_TEHAI_3.DataField = "REQ_O_TEHAI_3"
        Me.REQ_O_TEHAI_3.Height = 0.2!
        Me.REQ_O_TEHAI_3.Left = 0.0!
        Me.REQ_O_TEHAI_3.Name = "REQ_O_TEHAI_3"
        Me.REQ_O_TEHAI_3.Text = Nothing
        Me.REQ_O_TEHAI_3.Top = 11.17874!
        Me.REQ_O_TEHAI_3.Visible = False
        Me.REQ_O_TEHAI_3.Width = 1.0!
        '
        'REQ_O_TEHAI_4
        '
        Me.REQ_O_TEHAI_4.DataField = "REQ_O_TEHAI_4"
        Me.REQ_O_TEHAI_4.Height = 0.2!
        Me.REQ_O_TEHAI_4.Left = 3.064567!
        Me.REQ_O_TEHAI_4.Name = "REQ_O_TEHAI_4"
        Me.REQ_O_TEHAI_4.Text = Nothing
        Me.REQ_O_TEHAI_4.Top = 11.17874!
        Me.REQ_O_TEHAI_4.Visible = False
        Me.REQ_O_TEHAI_4.Width = 1.0!
        '
        'REQ_O_TEHAI_5
        '
        Me.REQ_O_TEHAI_5.DataField = "REQ_O_TEHAI_5"
        Me.REQ_O_TEHAI_5.Height = 0.2!
        Me.REQ_O_TEHAI_5.Left = 2.064567!
        Me.REQ_O_TEHAI_5.Name = "REQ_O_TEHAI_5"
        Me.REQ_O_TEHAI_5.Text = Nothing
        Me.REQ_O_TEHAI_5.Top = 11.17874!
        Me.REQ_O_TEHAI_5.Visible = False
        Me.REQ_O_TEHAI_5.Width = 1.0!
        '
        'REQ_F_TEHAI_1
        '
        Me.REQ_F_TEHAI_1.DataField = "REQ_F_TEHAI_1"
        Me.REQ_F_TEHAI_1.Height = 0.2!
        Me.REQ_F_TEHAI_1.Left = 1.0!
        Me.REQ_F_TEHAI_1.Name = "REQ_F_TEHAI_1"
        Me.REQ_F_TEHAI_1.Text = Nothing
        Me.REQ_F_TEHAI_1.Top = 11.17874!
        Me.REQ_F_TEHAI_1.Visible = False
        Me.REQ_F_TEHAI_1.Width = 1.0!
        '
        'REQ_F_TEHAI_2
        '
        Me.REQ_F_TEHAI_2.DataField = "REQ_F_TEHAI_2"
        Me.REQ_F_TEHAI_2.Height = 0.2!
        Me.REQ_F_TEHAI_2.Left = 0.9165355!
        Me.REQ_F_TEHAI_2.Name = "REQ_F_TEHAI_2"
        Me.REQ_F_TEHAI_2.Text = Nothing
        Me.REQ_F_TEHAI_2.Top = 10.86614!
        Me.REQ_F_TEHAI_2.Visible = False
        Me.REQ_F_TEHAI_2.Width = 1.0!
        '
        'REQ_F_TEHAI_3
        '
        Me.REQ_F_TEHAI_3.DataField = "REQ_F_TEHAI_3"
        Me.REQ_F_TEHAI_3.Height = 0.2!
        Me.REQ_F_TEHAI_3.Left = 6.039764!
        Me.REQ_F_TEHAI_3.Name = "REQ_F_TEHAI_3"
        Me.REQ_F_TEHAI_3.Text = Nothing
        Me.REQ_F_TEHAI_3.Top = 10.86614!
        Me.REQ_F_TEHAI_3.Visible = False
        Me.REQ_F_TEHAI_3.Width = 1.0!
        '
        'REQ_F_TEHAI_4
        '
        Me.REQ_F_TEHAI_4.DataField = "REQ_F_TEHAI_4"
        Me.REQ_F_TEHAI_4.Height = 0.2!
        Me.REQ_F_TEHAI_4.Left = 5.039764!
        Me.REQ_F_TEHAI_4.Name = "REQ_F_TEHAI_4"
        Me.REQ_F_TEHAI_4.Text = Nothing
        Me.REQ_F_TEHAI_4.Top = 10.86614!
        Me.REQ_F_TEHAI_4.Visible = False
        Me.REQ_F_TEHAI_4.Width = 1.0!
        '
        'REQ_F_TEHAI_5
        '
        Me.REQ_F_TEHAI_5.DataField = "REQ_F_TEHAI_5"
        Me.REQ_F_TEHAI_5.Height = 0.2!
        Me.REQ_F_TEHAI_5.Left = 3.942126!
        Me.REQ_F_TEHAI_5.Name = "REQ_F_TEHAI_5"
        Me.REQ_F_TEHAI_5.Text = Nothing
        Me.REQ_F_TEHAI_5.Top = 10.86614!
        Me.REQ_F_TEHAI_5.Visible = False
        Me.REQ_F_TEHAI_5.Width = 1.0!
        '
        'REQ_MR_O_TEHAI
        '
        Me.REQ_MR_O_TEHAI.DataField = "REQ_MR_O_TEHAI"
        Me.REQ_MR_O_TEHAI.Height = 0.2!
        Me.REQ_MR_O_TEHAI.Left = 2.910236!
        Me.REQ_MR_O_TEHAI.Name = "REQ_MR_O_TEHAI"
        Me.REQ_MR_O_TEHAI.Text = Nothing
        Me.REQ_MR_O_TEHAI.Top = 10.86614!
        Me.REQ_MR_O_TEHAI.Visible = False
        Me.REQ_MR_O_TEHAI.Width = 1.0!
        '
        'REQ_MR_F_TEHAI
        '
        Me.REQ_MR_F_TEHAI.DataField = "REQ_MR_F_TEHAI"
        Me.REQ_MR_F_TEHAI.Height = 0.2!
        Me.REQ_MR_F_TEHAI.Left = 1.787402!
        Me.REQ_MR_F_TEHAI.Name = "REQ_MR_F_TEHAI"
        Me.REQ_MR_F_TEHAI.Text = Nothing
        Me.REQ_MR_F_TEHAI.Top = 10.86614!
        Me.REQ_MR_F_TEHAI.Visible = False
        Me.REQ_MR_F_TEHAI.Width = 1.0!
        '
        'Line32
        '
        Me.Line32.Height = 0.0!
        Me.Line32.Left = 3.236221!
        Me.Line32.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line32.LineWeight = 1.0!
        Me.Line32.Name = "Line32"
        Me.Line32.Top = 1.376378!
        Me.Line32.Width = 4.413386!
        Me.Line32.X1 = 3.236221!
        Me.Line32.X2 = 7.649607!
        Me.Line32.Y1 = 1.376378!
        Me.Line32.Y2 = 1.376378!
        '
        'Label7
        '
        Me.Label7.Height = 0.2255906!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.4488189!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label7.Text = "利用日"
        Me.Label7.Top = 1.150787!
        Me.Label7.Width = 0.3948819!
        '
        'Line37
        '
        Me.Line37.Height = 0.0!
        Me.Line37.Left = 2.842171E-14!
        Me.Line37.LineWeight = 1.0!
        Me.Line37.Name = "Line37"
        Me.Line37.Top = 1.612599!
        Me.Line37.Width = 7.649607!
        Me.Line37.X1 = 2.842171E-14!
        Me.Line37.X2 = 7.649607!
        Me.Line37.Y1 = 1.612599!
        Me.Line37.Y2 = 1.612599!
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 1.862645E-9!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 7.177953!
        Me.Line6.Width = 2.787402!
        Me.Line6.X1 = 1.862645E-9!
        Me.Line6.X2 = 2.787402!
        Me.Line6.Y1 = 7.177953!
        Me.Line6.Y2 = 7.177953!
        '
        'Line7
        '
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 1.862645E-9!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 7.408268!
        Me.Line7.Width = 2.787402!
        Me.Line7.X1 = 1.862645E-9!
        Me.Line7.X2 = 2.787402!
        Me.Line7.Y1 = 7.408268!
        Me.Line7.Y2 = 7.408268!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.4488189!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.838189!
        Me.Line4.Width = 2.338583!
        Me.Line4.X1 = 0.4488189!
        Me.Line4.X2 = 2.787402!
        Me.Line4.Y1 = 1.838189!
        Me.Line4.Y2 = 1.838189!
        '
        'Line152
        '
        Me.Line152.Height = 0.2255905!
        Me.Line152.Left = 0.6570867!
        Me.Line152.LineWeight = 1.0!
        Me.Line152.Name = "Line152"
        Me.Line152.Top = 0.4740158!
        Me.Line152.Width = 0.0!
        Me.Line152.X1 = 0.6570867!
        Me.Line152.X2 = 0.6570867!
        Me.Line152.Y1 = 0.4740158!
        Me.Line152.Y2 = 0.6996063!
        '
        'Line153
        '
        Me.Line153.Height = 0.2255902!
        Me.Line153.Left = 6.67126!
        Me.Line153.LineWeight = 1.0!
        Me.Line153.Name = "Line153"
        Me.Line153.Top = 0.9251968!
        Me.Line153.Width = 0.0!
        Me.Line153.X1 = 6.67126!
        Me.Line153.X2 = 6.67126!
        Me.Line153.Y1 = 0.9251968!
        Me.Line153.Y2 = 1.150787!
        '
        'Line155
        '
        Me.Line155.Height = 0.2255902!
        Me.Line155.Left = 2.483465!
        Me.Line155.LineWeight = 1.0!
        Me.Line155.Name = "Line155"
        Me.Line155.Top = 0.9251968!
        Me.Line155.Width = 0.0!
        Me.Line155.X1 = 2.483465!
        Me.Line155.X2 = 2.483465!
        Me.Line155.Y1 = 0.9251968!
        Me.Line155.Y2 = 1.150787!
        '
        'Line17
        '
        Me.Line17.Height = 0.2255902!
        Me.Line17.Left = 3.064567!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.9251968!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 3.064567!
        Me.Line17.X2 = 3.064567!
        Me.Line17.Y1 = 0.9251968!
        Me.Line17.Y2 = 1.150787!
        '
        'Line107
        '
        Me.Line107.Height = 0.2255902!
        Me.Line107.Left = 3.333465!
        Me.Line107.LineWeight = 1.0!
        Me.Line107.Name = "Line107"
        Me.Line107.Top = 0.9251968!
        Me.Line107.Width = 0.0!
        Me.Line107.X1 = 3.333465!
        Me.Line107.X2 = 3.333465!
        Me.Line107.Y1 = 0.9251968!
        Me.Line107.Y2 = 1.150787!
        '
        'Line109
        '
        Me.Line109.Height = 0.2255902!
        Me.Line109.Left = 3.910237!
        Me.Line109.LineWeight = 1.0!
        Me.Line109.Name = "Line109"
        Me.Line109.Top = 0.9251968!
        Me.Line109.Width = 0.0!
        Me.Line109.X1 = 3.910237!
        Me.Line109.X2 = 3.910237!
        Me.Line109.Y1 = 0.9251968!
        Me.Line109.Y2 = 1.150787!
        '
        'Line18
        '
        Me.Line18.Height = 0.0!
        Me.Line18.Left = 0.4488189!
        Me.Line18.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 1.376378!
        Me.Line18.Width = 2.338583!
        Me.Line18.X1 = 0.4488189!
        Me.Line18.X2 = 2.787402!
        Me.Line18.Y1 = 1.376378!
        Me.Line18.Y2 = 1.376378!
        '
        'Line85
        '
        Me.Line85.Height = 0.398031!
        Me.Line85.Left = 5.966536!
        Me.Line85.LineWeight = 1.0!
        Me.Line85.Name = "Line85"
        Me.Line85.Top = 2.084252!
        Me.Line85.Width = 0.0!
        Me.Line85.X1 = 5.966536!
        Me.Line85.X2 = 5.966536!
        Me.Line85.Y1 = 2.084252!
        Me.Line85.Y2 = 2.482283!
        '
        'Label46
        '
        Me.Label46.Height = 0.2255906!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 0.4488189!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label46.Text = "発地"
        Me.Label46.Top = 1.827559!
        Me.Label46.Width = 0.3948819!
        '
        'Line110
        '
        Me.Line110.Height = 0.0!
        Me.Line110.Left = 3.236221!
        Me.Line110.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line110.LineWeight = 1.0!
        Me.Line110.Name = "Line110"
        Me.Line110.Top = 1.838189!
        Me.Line110.Width = 4.413386!
        Me.Line110.X1 = 3.236221!
        Me.Line110.X2 = 7.649607!
        Me.Line110.Y1 = 1.838189!
        Me.Line110.Y2 = 1.838189!
        '
        'Label50
        '
        Me.Label50.Height = 0.2255906!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 0.4488189!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label50.Text = "発地"
        Me.Label50.Top = 2.27874!
        Me.Label50.Width = 0.3948819!
        '
        'Line135
        '
        Me.Line135.Height = 0.0!
        Me.Line135.Left = 0.4488189!
        Me.Line135.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line135.LineWeight = 1.0!
        Me.Line135.Name = "Line135"
        Me.Line135.Top = 2.27874!
        Me.Line135.Width = 2.338582!
        Me.Line135.X1 = 0.4488189!
        Me.Line135.X2 = 2.787401!
        Me.Line135.Y1 = 2.27874!
        Me.Line135.Y2 = 2.27874!
        '
        'Label203
        '
        Me.Label203.Height = 0.2255906!
        Me.Label203.HyperLink = Nothing
        Me.Label203.Left = 3.236221!
        Me.Label203.Name = "Label203"
        Me.Label203.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label203.Text = "利用日"
        Me.Label203.Top = 2.05315!
        Me.Label203.Width = 0.3948819!
        '
        'Label204
        '
        Me.Label204.Height = 0.2255906!
        Me.Label204.HyperLink = Nothing
        Me.Label204.Left = 3.236221!
        Me.Label204.Name = "Label204"
        Me.Label204.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label204.Text = "番号"
        Me.Label204.Top = 2.27874!
        Me.Label204.Width = 0.381496!
        '
        'Label31
        '
        Me.Label31.Height = 0.2255906!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 5.966536!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label31.Text = "備考"
        Me.Label31.Top = 2.27874!
        Me.Label31.Width = 0.3948819!
        '
        'Label205
        '
        Me.Label205.Height = 0.2255906!
        Me.Label205.HyperLink = Nothing
        Me.Label205.Left = 4.378346!
        Me.Label205.Name = "Label205"
        Me.Label205.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label205.Text = "利用者名"
        Me.Label205.Top = 2.27874!
        Me.Label205.Width = 0.5464572!
        '
        'Label13
        '
        Me.Label13.Height = 0.2255906!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.4488189!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label13.Text = "発地"
        Me.Label13.Top = 2.729921!
        Me.Label13.Width = 0.3948819!
        '
        'Label33
        '
        Me.Label33.Height = 0.2255906!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 3.236221!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label33.Text = "利用日"
        Me.Label33.Top = 2.504331!
        Me.Label33.Width = 0.3948819!
        '
        'Label35
        '
        Me.Label35.Height = 0.2255906!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 3.236221!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label35.Text = "番号"
        Me.Label35.Top = 2.729921!
        Me.Label35.Width = 0.381496!
        '
        'Label37
        '
        Me.Label37.Height = 0.2255906!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 4.378347!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label37.Text = "券種"
        Me.Label37.Top = 2.504331!
        Me.Label37.Width = 0.5464567!
        '
        'Label54
        '
        Me.Label54.Height = 0.2255906!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 5.966536!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label54.Text = "備考"
        Me.Label54.Top = 2.729921!
        Me.Label54.Width = 0.3948819!
        '
        'Label206
        '
        Me.Label206.Height = 0.2255906!
        Me.Label206.HyperLink = Nothing
        Me.Label206.Left = 5.966536!
        Me.Label206.Name = "Label206"
        Me.Label206.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label206.Text = "発行日"
        Me.Label206.Top = 2.504331!
        Me.Label206.Width = 0.3948819!
        '
        'Label207
        '
        Me.Label207.Height = 0.2255906!
        Me.Label207.HyperLink = Nothing
        Me.Label207.Left = 4.378346!
        Me.Label207.Name = "Label207"
        Me.Label207.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label207.Text = "利用者名"
        Me.Label207.Top = 2.729921!
        Me.Label207.Width = 0.5464572!
        '
        'Label15
        '
        Me.Label15.Height = 0.2255906!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.4488189!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label15.Text = "発地"
        Me.Label15.Top = 3.181102!
        Me.Label15.Width = 0.3948819!
        '
        'Label16
        '
        Me.Label16.Height = 0.2255906!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 3.236221!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label16.Text = "利用日"
        Me.Label16.Top = 2.955512!
        Me.Label16.Width = 0.3948819!
        '
        'Label39
        '
        Me.Label39.Height = 0.2255906!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 3.236221!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label39.Text = "番号"
        Me.Label39.Top = 3.181102!
        Me.Label39.Width = 0.381496!
        '
        'Label40
        '
        Me.Label40.Height = 0.2255906!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 4.378347!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label40.Text = "券種"
        Me.Label40.Top = 2.955512!
        Me.Label40.Width = 0.5464567!
        '
        'Label41
        '
        Me.Label41.Height = 0.2255906!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 5.966536!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label41.Text = "備考"
        Me.Label41.Top = 3.181103!
        Me.Label41.Width = 0.3948819!
        '
        'Label42
        '
        Me.Label42.Height = 0.2255906!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 5.966536!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label42.Text = "発行日"
        Me.Label42.Top = 2.955512!
        Me.Label42.Width = 0.3948819!
        '
        'Label43
        '
        Me.Label43.Height = 0.2255906!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 4.377953!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label43.Text = "利用者名"
        Me.Label43.Top = 3.181102!
        Me.Label43.Width = 0.5464572!
        '
        'Label44
        '
        Me.Label44.Height = 0.2255906!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 0.4488192!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label44.Text = "利用日"
        Me.Label44.Top = 3.406693!
        Me.Label44.Width = 0.3948819!
        '
        'Label55
        '
        Me.Label55.Height = 0.2255906!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 0.4488189!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label55.Text = "発地"
        Me.Label55.Top = 3.632283!
        Me.Label55.Width = 0.3948819!
        '
        'Label59
        '
        Me.Label59.Height = 0.2255906!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 1.612992!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label59.Text = "依頼金額"
        Me.Label59.Top = 3.406693!
        Me.Label59.Width = 0.5811024!
        '
        'Label62
        '
        Me.Label62.Height = 0.2255906!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 3.236221!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label62.Text = "利用日"
        Me.Label62.Top = 3.406693!
        Me.Label62.Width = 0.3948819!
        '
        'Label63
        '
        Me.Label63.Height = 0.2255906!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 3.236221!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label63.Text = "番号"
        Me.Label63.Top = 3.632283!
        Me.Label63.Width = 0.381496!
        '
        'Label64
        '
        Me.Label64.Height = 0.2255906!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 4.378347!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label64.Text = "券種"
        Me.Label64.Top = 3.406693!
        Me.Label64.Width = 0.5464567!
        '
        'Label67
        '
        Me.Label67.Height = 0.2255906!
        Me.Label67.HyperLink = Nothing
        Me.Label67.Left = 5.966536!
        Me.Label67.Name = "Label67"
        Me.Label67.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label67.Text = "備考"
        Me.Label67.Top = 3.632283!
        Me.Label67.Width = 0.3948819!
        '
        'Label68
        '
        Me.Label68.Height = 0.2255906!
        Me.Label68.HyperLink = Nothing
        Me.Label68.Left = 5.966536!
        Me.Label68.Name = "Label68"
        Me.Label68.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label68.Text = "発行日"
        Me.Label68.Top = 3.406693!
        Me.Label68.Width = 0.3948819!
        '
        'Label70
        '
        Me.Label70.Height = 0.2255906!
        Me.Label70.HyperLink = Nothing
        Me.Label70.Left = 4.378346!
        Me.Label70.Name = "Label70"
        Me.Label70.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label70.Text = "利用者名"
        Me.Label70.Top = 3.632283!
        Me.Label70.Width = 0.5464572!
        '
        'Label17
        '
        Me.Label17.Height = 0.2255906!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.4488192!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label17.Text = "利用日"
        Me.Label17.Top = 3.857874!
        Me.Label17.Width = 0.3948819!
        '
        'Label75
        '
        Me.Label75.Height = 0.2255906!
        Me.Label75.HyperLink = Nothing
        Me.Label75.Left = 0.4488189!
        Me.Label75.Name = "Label75"
        Me.Label75.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label75.Text = "発地"
        Me.Label75.Top = 4.083465!
        Me.Label75.Width = 0.3948819!
        '
        'Label91
        '
        Me.Label91.Height = 0.2255906!
        Me.Label91.HyperLink = Nothing
        Me.Label91.Left = 1.612992!
        Me.Label91.Name = "Label91"
        Me.Label91.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label91.Text = "依頼金額"
        Me.Label91.Top = 3.857874!
        Me.Label91.Width = 0.5811024!
        '
        'Label92
        '
        Me.Label92.Height = 0.2255906!
        Me.Label92.HyperLink = Nothing
        Me.Label92.Left = 3.236221!
        Me.Label92.Name = "Label92"
        Me.Label92.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label92.Text = "利用日"
        Me.Label92.Top = 3.857874!
        Me.Label92.Width = 0.3948819!
        '
        'Label93
        '
        Me.Label93.Height = 0.2255906!
        Me.Label93.HyperLink = Nothing
        Me.Label93.Left = 3.236221!
        Me.Label93.Name = "Label93"
        Me.Label93.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label93.Text = "番号"
        Me.Label93.Top = 4.083465!
        Me.Label93.Width = 0.381496!
        '
        'Label95
        '
        Me.Label95.Height = 0.2255906!
        Me.Label95.HyperLink = Nothing
        Me.Label95.Left = 4.378347!
        Me.Label95.Name = "Label95"
        Me.Label95.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label95.Text = "券種"
        Me.Label95.Top = 3.857874!
        Me.Label95.Width = 0.5464567!
        '
        'Label208
        '
        Me.Label208.Height = 0.2255906!
        Me.Label208.HyperLink = Nothing
        Me.Label208.Left = 5.966536!
        Me.Label208.Name = "Label208"
        Me.Label208.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label208.Text = "備考"
        Me.Label208.Top = 4.083465!
        Me.Label208.Width = 0.3948819!
        '
        'Label209
        '
        Me.Label209.Height = 0.2255906!
        Me.Label209.HyperLink = Nothing
        Me.Label209.Left = 5.966536!
        Me.Label209.Name = "Label209"
        Me.Label209.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label209.Text = "発行日"
        Me.Label209.Top = 3.857874!
        Me.Label209.Width = 0.3948819!
        '
        'Label210
        '
        Me.Label210.Height = 0.2255906!
        Me.Label210.HyperLink = Nothing
        Me.Label210.Left = 4.378346!
        Me.Label210.Name = "Label210"
        Me.Label210.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label210.Text = "利用者名"
        Me.Label210.Top = 4.083465!
        Me.Label210.Width = 0.5464572!
        '
        'Label18
        '
        Me.Label18.Height = 0.2255906!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.4488192!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label18.Text = "利用日"
        Me.Label18.Top = 4.309055!
        Me.Label18.Width = 0.3948819!
        '
        'Label66
        '
        Me.Label66.Height = 0.2255906!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 1.612992!
        Me.Label66.Name = "Label66"
        Me.Label66.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label66.Text = "依頼金額"
        Me.Label66.Top = 4.309055!
        Me.Label66.Width = 0.5811024!
        '
        'Label76
        '
        Me.Label76.Height = 0.2255906!
        Me.Label76.HyperLink = Nothing
        Me.Label76.Left = 0.4488189!
        Me.Label76.Name = "Label76"
        Me.Label76.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label76.Text = "発地"
        Me.Label76.Top = 4.534646!
        Me.Label76.Width = 0.3948819!
        '
        'Label77
        '
        Me.Label77.Height = 0.2255906!
        Me.Label77.HyperLink = Nothing
        Me.Label77.Left = 3.236221!
        Me.Label77.Name = "Label77"
        Me.Label77.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label77.Text = "利用日"
        Me.Label77.Top = 4.309055!
        Me.Label77.Width = 0.3948819!
        '
        'Label79
        '
        Me.Label79.Height = 0.2255906!
        Me.Label79.HyperLink = Nothing
        Me.Label79.Left = 3.236221!
        Me.Label79.Name = "Label79"
        Me.Label79.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label79.Text = "番号"
        Me.Label79.Top = 4.534646!
        Me.Label79.Width = 0.381496!
        '
        'Label80
        '
        Me.Label80.Height = 0.2255906!
        Me.Label80.HyperLink = Nothing
        Me.Label80.Left = 4.378347!
        Me.Label80.Name = "Label80"
        Me.Label80.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label80.Text = "券種"
        Me.Label80.Top = 4.309055!
        Me.Label80.Width = 0.5464567!
        '
        'Label81
        '
        Me.Label81.Height = 0.2255906!
        Me.Label81.HyperLink = Nothing
        Me.Label81.Left = 5.966536!
        Me.Label81.Name = "Label81"
        Me.Label81.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label81.Text = "備考"
        Me.Label81.Top = 4.534646!
        Me.Label81.Width = 0.3948819!
        '
        'Label96
        '
        Me.Label96.Height = 0.2255906!
        Me.Label96.HyperLink = Nothing
        Me.Label96.Left = 5.966536!
        Me.Label96.Name = "Label96"
        Me.Label96.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label96.Text = "発行日"
        Me.Label96.Top = 4.309055!
        Me.Label96.Width = 0.3948819!
        '
        'Label97
        '
        Me.Label97.Height = 0.2255906!
        Me.Label97.HyperLink = Nothing
        Me.Label97.Left = 4.378346!
        Me.Label97.Name = "Label97"
        Me.Label97.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label97.Text = "利用者名"
        Me.Label97.Top = 4.534646!
        Me.Label97.Width = 0.5464572!
        '
        'Label98
        '
        Me.Label98.Height = 0.2255906!
        Me.Label98.HyperLink = Nothing
        Me.Label98.Left = 0.4488192!
        Me.Label98.Name = "Label98"
        Me.Label98.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label98.Text = "利用日"
        Me.Label98.Top = 4.760236!
        Me.Label98.Width = 0.3948819!
        '
        'Label99
        '
        Me.Label99.Height = 0.2255906!
        Me.Label99.HyperLink = Nothing
        Me.Label99.Left = 0.4488189!
        Me.Label99.Name = "Label99"
        Me.Label99.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label99.Text = "発地"
        Me.Label99.Top = 4.985826!
        Me.Label99.Width = 0.3948819!
        '
        'Label101
        '
        Me.Label101.Height = 0.2255906!
        Me.Label101.HyperLink = Nothing
        Me.Label101.Left = 1.612992!
        Me.Label101.Name = "Label101"
        Me.Label101.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label101.Text = "依頼金額"
        Me.Label101.Top = 4.760236!
        Me.Label101.Width = 0.5811024!
        '
        'Label211
        '
        Me.Label211.Height = 0.2255906!
        Me.Label211.HyperLink = Nothing
        Me.Label211.Left = 3.236221!
        Me.Label211.Name = "Label211"
        Me.Label211.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label211.Text = "利用日"
        Me.Label211.Top = 4.760236!
        Me.Label211.Width = 0.3948819!
        '
        'Label212
        '
        Me.Label212.Height = 0.2255906!
        Me.Label212.HyperLink = Nothing
        Me.Label212.Left = 3.236221!
        Me.Label212.Name = "Label212"
        Me.Label212.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label212.Text = "番号"
        Me.Label212.Top = 4.985826!
        Me.Label212.Width = 0.381496!
        '
        'Label213
        '
        Me.Label213.Height = 0.2255906!
        Me.Label213.HyperLink = Nothing
        Me.Label213.Left = 4.378347!
        Me.Label213.Name = "Label213"
        Me.Label213.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label213.Text = "券種"
        Me.Label213.Top = 4.760236!
        Me.Label213.Width = 0.5464567!
        '
        'Label214
        '
        Me.Label214.Height = 0.2255906!
        Me.Label214.HyperLink = Nothing
        Me.Label214.Left = 5.966536!
        Me.Label214.Name = "Label214"
        Me.Label214.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label214.Text = "備考"
        Me.Label214.Top = 4.985826!
        Me.Label214.Width = 0.3948819!
        '
        'Label215
        '
        Me.Label215.Height = 0.2255906!
        Me.Label215.HyperLink = Nothing
        Me.Label215.Left = 5.966536!
        Me.Label215.Name = "Label215"
        Me.Label215.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label215.Text = "発行日"
        Me.Label215.Top = 4.760236!
        Me.Label215.Width = 0.3948819!
        '
        'Label216
        '
        Me.Label216.Height = 0.2255906!
        Me.Label216.HyperLink = Nothing
        Me.Label216.Left = 4.378346!
        Me.Label216.Name = "Label216"
        Me.Label216.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label216.Text = "利用者名"
        Me.Label216.Top = 4.985826!
        Me.Label216.Width = 0.5464572!
        '
        'Label19
        '
        Me.Label19.Height = 0.2255906!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.4488192!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label19.Text = "利用日"
        Me.Label19.Top = 5.211418!
        Me.Label19.Width = 0.3948819!
        '
        'Label29
        '
        Me.Label29.Height = 0.2255906!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 0.4488189!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label29.Text = "発地"
        Me.Label29.Top = 5.437008!
        Me.Label29.Width = 0.3948819!
        '
        'Label83
        '
        Me.Label83.Height = 0.2255906!
        Me.Label83.HyperLink = Nothing
        Me.Label83.Left = 1.612992!
        Me.Label83.Name = "Label83"
        Me.Label83.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label83.Text = "依頼金額"
        Me.Label83.Top = 5.211418!
        Me.Label83.Width = 0.5811024!
        '
        'Label84
        '
        Me.Label84.Height = 0.2255906!
        Me.Label84.HyperLink = Nothing
        Me.Label84.Left = 3.236221!
        Me.Label84.Name = "Label84"
        Me.Label84.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label84.Text = "利用日"
        Me.Label84.Top = 5.211418!
        Me.Label84.Width = 0.3948819!
        '
        'Label85
        '
        Me.Label85.Height = 0.2255906!
        Me.Label85.HyperLink = Nothing
        Me.Label85.Left = 3.236221!
        Me.Label85.Name = "Label85"
        Me.Label85.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label85.Text = "番号"
        Me.Label85.Top = 5.437008!
        Me.Label85.Width = 0.381496!
        '
        'Label102
        '
        Me.Label102.Height = 0.2255906!
        Me.Label102.HyperLink = Nothing
        Me.Label102.Left = 4.378347!
        Me.Label102.Name = "Label102"
        Me.Label102.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label102.Text = "券種"
        Me.Label102.Top = 5.211418!
        Me.Label102.Width = 0.5464567!
        '
        'Label103
        '
        Me.Label103.Height = 0.2255906!
        Me.Label103.HyperLink = Nothing
        Me.Label103.Left = 5.966536!
        Me.Label103.Name = "Label103"
        Me.Label103.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label103.Text = "備考"
        Me.Label103.Top = 5.437008!
        Me.Label103.Width = 0.3948819!
        '
        'Label104
        '
        Me.Label104.Height = 0.2255906!
        Me.Label104.HyperLink = Nothing
        Me.Label104.Left = 5.966536!
        Me.Label104.Name = "Label104"
        Me.Label104.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label104.Text = "発行日"
        Me.Label104.Top = 5.211418!
        Me.Label104.Width = 0.3948819!
        '
        'Label105
        '
        Me.Label105.Height = 0.2255906!
        Me.Label105.HyperLink = Nothing
        Me.Label105.Left = 4.378346!
        Me.Label105.Name = "Label105"
        Me.Label105.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label105.Text = "利用者名"
        Me.Label105.Top = 5.437008!
        Me.Label105.Width = 0.5464572!
        '
        'Label72
        '
        Me.Label72.Height = 0.2255906!
        Me.Label72.HyperLink = Nothing
        Me.Label72.Left = 3.236221!
        Me.Label72.Name = "Label72"
        Me.Label72.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label72.Text = "利用日"
        Me.Label72.Top = 5.662599!
        Me.Label72.Width = 0.3948819!
        '
        'Label87
        '
        Me.Label87.Height = 0.2255906!
        Me.Label87.HyperLink = Nothing
        Me.Label87.Left = 3.236221!
        Me.Label87.Name = "Label87"
        Me.Label87.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label87.Text = "番号"
        Me.Label87.Top = 5.888189!
        Me.Label87.Width = 0.381496!
        '
        'Label88
        '
        Me.Label88.Height = 0.2255906!
        Me.Label88.HyperLink = Nothing
        Me.Label88.Left = 4.378347!
        Me.Label88.Name = "Label88"
        Me.Label88.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label88.Text = "券種"
        Me.Label88.Top = 5.662599!
        Me.Label88.Width = 0.5464567!
        '
        'Label89
        '
        Me.Label89.Height = 0.2255906!
        Me.Label89.HyperLink = Nothing
        Me.Label89.Left = 5.966536!
        Me.Label89.Name = "Label89"
        Me.Label89.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label89.Text = "備考"
        Me.Label89.Top = 5.888189!
        Me.Label89.Width = 0.3948819!
        '
        'Label107
        '
        Me.Label107.Height = 0.2255906!
        Me.Label107.HyperLink = Nothing
        Me.Label107.Left = 5.966536!
        Me.Label107.Name = "Label107"
        Me.Label107.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label107.Text = "発行日"
        Me.Label107.Top = 5.662599!
        Me.Label107.Width = 0.3948819!
        '
        'Label108
        '
        Me.Label108.Height = 0.2255906!
        Me.Label108.HyperLink = Nothing
        Me.Label108.Left = 4.378346!
        Me.Label108.Name = "Label108"
        Me.Label108.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label108.Text = "利用者名"
        Me.Label108.Top = 5.888189!
        Me.Label108.Width = 0.5464572!
        '
        'Line13
        '
        Me.Line13.Height = 0.0!
        Me.Line13.Left = 3.236221!
        Me.Line13.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 5.888189!
        Me.Line13.Width = 4.413386!
        Me.Line13.X1 = 3.236221!
        Me.Line13.X2 = 7.649607!
        Me.Line13.Y1 = 5.888189!
        Me.Line13.Y2 = 5.888189!
        '
        'Line16
        '
        Me.Line16.Height = 4.511812!
        Me.Line16.Left = 0.4488189!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 1.150787!
        Me.Line16.Width = 0.0!
        Me.Line16.X1 = 0.4488189!
        Me.Line16.X2 = 0.4488189!
        Me.Line16.Y1 = 1.150787!
        Me.Line16.Y2 = 5.662599!
        '
        'Line41
        '
        Me.Line41.Height = 4.511812!
        Me.Line41.Left = 0.8437008!
        Me.Line41.LineWeight = 1.0!
        Me.Line41.Name = "Line41"
        Me.Line41.Top = 1.150787!
        Me.Line41.Width = 0.0!
        Me.Line41.X1 = 0.8437008!
        Me.Line41.X2 = 0.8437008!
        Me.Line41.Y1 = 1.150787!
        Me.Line41.Y2 = 5.662599!
        '
        'Line111
        '
        Me.Line111.Height = 0.0!
        Me.Line111.Left = 2.842171E-14!
        Me.Line111.LineWeight = 1.0!
        Me.Line111.Name = "Line111"
        Me.Line111.Top = 2.504331!
        Me.Line111.Width = 7.649607!
        Me.Line111.X1 = 2.842171E-14!
        Me.Line111.X2 = 7.649607!
        Me.Line111.Y1 = 2.504331!
        Me.Line111.Y2 = 2.504331!
        '
        'Line136
        '
        Me.Line136.Height = 0.0!
        Me.Line136.Left = 0.4488189!
        Me.Line136.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line136.LineWeight = 1.0!
        Me.Line136.Name = "Line136"
        Me.Line136.Top = 2.729921!
        Me.Line136.Width = 2.338583!
        Me.Line136.X1 = 0.4488189!
        Me.Line136.X2 = 2.787402!
        Me.Line136.Y1 = 2.729921!
        Me.Line136.Y2 = 2.729921!
        '
        'Line106
        '
        Me.Line106.Height = 0.0!
        Me.Line106.Left = 2.842171E-14!
        Me.Line106.LineWeight = 1.0!
        Me.Line106.Name = "Line106"
        Me.Line106.Top = 2.955512!
        Me.Line106.Width = 7.649607!
        Me.Line106.X1 = 2.842171E-14!
        Me.Line106.X2 = 7.649607!
        Me.Line106.Y1 = 2.955512!
        Me.Line106.Y2 = 2.955512!
        '
        'Line138
        '
        Me.Line138.Height = 0.0!
        Me.Line138.Left = 0.4488189!
        Me.Line138.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line138.LineWeight = 1.0!
        Me.Line138.Name = "Line138"
        Me.Line138.Top = 3.181102!
        Me.Line138.Width = 2.338583!
        Me.Line138.X1 = 0.4488189!
        Me.Line138.X2 = 2.787402!
        Me.Line138.Y1 = 3.181102!
        Me.Line138.Y2 = 3.181102!
        '
        'Line11
        '
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 0.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 3.406693!
        Me.Line11.Width = 7.649607!
        Me.Line11.X1 = 0.0!
        Me.Line11.X2 = 7.649607!
        Me.Line11.Y1 = 3.406693!
        Me.Line11.Y2 = 3.406693!
        '
        'Line139
        '
        Me.Line139.Height = 0.0!
        Me.Line139.Left = 0.4488189!
        Me.Line139.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line139.LineWeight = 1.0!
        Me.Line139.Name = "Line139"
        Me.Line139.Top = 3.632283!
        Me.Line139.Width = 2.338583!
        Me.Line139.X1 = 0.4488189!
        Me.Line139.X2 = 2.787402!
        Me.Line139.Y1 = 3.632283!
        Me.Line139.Y2 = 3.632283!
        '
        'Line140
        '
        Me.Line140.Height = 0.0!
        Me.Line140.Left = 0.4488189!
        Me.Line140.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line140.LineWeight = 1.0!
        Me.Line140.Name = "Line140"
        Me.Line140.Top = 4.083465!
        Me.Line140.Width = 2.338583!
        Me.Line140.X1 = 0.4488189!
        Me.Line140.X2 = 2.787402!
        Me.Line140.Y1 = 4.083465!
        Me.Line140.Y2 = 4.083465!
        '
        'Line105
        '
        Me.Line105.Height = 0.0!
        Me.Line105.Left = 2.842171E-14!
        Me.Line105.LineWeight = 1.0!
        Me.Line105.Name = "Line105"
        Me.Line105.Top = 4.309055!
        Me.Line105.Width = 7.649607!
        Me.Line105.X1 = 2.842171E-14!
        Me.Line105.X2 = 7.649607!
        Me.Line105.Y1 = 4.309055!
        Me.Line105.Y2 = 4.309055!
        '
        'Line143
        '
        Me.Line143.Height = 0.0!
        Me.Line143.Left = 0.4488189!
        Me.Line143.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line143.LineWeight = 1.0!
        Me.Line143.Name = "Line143"
        Me.Line143.Top = 4.534646!
        Me.Line143.Width = 2.338583!
        Me.Line143.X1 = 0.4488189!
        Me.Line143.X2 = 2.787402!
        Me.Line143.Y1 = 4.534646!
        Me.Line143.Y2 = 4.534646!
        '
        'Line102
        '
        Me.Line102.Height = 0.0!
        Me.Line102.Left = 2.842171E-14!
        Me.Line102.LineWeight = 1.0!
        Me.Line102.Name = "Line102"
        Me.Line102.Top = 4.760236!
        Me.Line102.Width = 7.649607!
        Me.Line102.X1 = 2.842171E-14!
        Me.Line102.X2 = 7.649607!
        Me.Line102.Y1 = 4.760236!
        Me.Line102.Y2 = 4.760236!
        '
        'Line144
        '
        Me.Line144.Height = 0.0!
        Me.Line144.Left = 0.4488189!
        Me.Line144.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line144.LineWeight = 1.0!
        Me.Line144.Name = "Line144"
        Me.Line144.Top = 4.985826!
        Me.Line144.Width = 2.338583!
        Me.Line144.X1 = 0.4488189!
        Me.Line144.X2 = 2.787402!
        Me.Line144.Y1 = 4.985826!
        Me.Line144.Y2 = 4.985826!
        '
        'Line101
        '
        Me.Line101.Height = 0.0!
        Me.Line101.Left = 2.842171E-14!
        Me.Line101.LineWeight = 1.0!
        Me.Line101.Name = "Line101"
        Me.Line101.Top = 5.211418!
        Me.Line101.Width = 7.649607!
        Me.Line101.X1 = 2.842171E-14!
        Me.Line101.X2 = 7.649607!
        Me.Line101.Y1 = 5.211418!
        Me.Line101.Y2 = 5.211418!
        '
        'Line145
        '
        Me.Line145.Height = 0.0!
        Me.Line145.Left = 0.4488189!
        Me.Line145.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line145.LineWeight = 1.0!
        Me.Line145.Name = "Line145"
        Me.Line145.Top = 5.437008!
        Me.Line145.Width = 2.338583!
        Me.Line145.X1 = 0.4488189!
        Me.Line145.X2 = 2.787402!
        Me.Line145.Y1 = 5.437008!
        Me.Line145.Y2 = 5.437008!
        '
        'Line100
        '
        Me.Line100.Height = 0.0!
        Me.Line100.Left = 2.842171E-14!
        Me.Line100.LineWeight = 1.0!
        Me.Line100.Name = "Line100"
        Me.Line100.Top = 5.662599!
        Me.Line100.Width = 7.649607!
        Me.Line100.X1 = 2.842171E-14!
        Me.Line100.X2 = 7.649607!
        Me.Line100.Y1 = 5.662599!
        Me.Line100.Y2 = 5.662599!
        '
        'Line15
        '
        Me.Line15.Height = 0.21496!
        Me.Line15.Left = 1.612992!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 1.612599!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 1.612992!
        Me.Line15.X2 = 1.612992!
        Me.Line15.Y1 = 1.612599!
        Me.Line15.Y2 = 1.827559!
        '
        'Line19
        '
        Me.Line19.Height = 0.22559!
        Me.Line19.Left = 1.612992!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 2.05315!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 1.612992!
        Me.Line19.X2 = 1.612992!
        Me.Line19.Y1 = 2.05315!
        Me.Line19.Y2 = 2.27874!
        '
        'Line20
        '
        Me.Line20.Height = 0.22559!
        Me.Line20.Left = 1.612992!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 2.504331!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 1.612992!
        Me.Line20.X2 = 1.612992!
        Me.Line20.Y1 = 2.504331!
        Me.Line20.Y2 = 2.729921!
        '
        'Line21
        '
        Me.Line21.Height = 0.22559!
        Me.Line21.Left = 1.612992!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 2.955512!
        Me.Line21.Width = 0.0!
        Me.Line21.X1 = 1.612992!
        Me.Line21.X2 = 1.612992!
        Me.Line21.Y1 = 2.955512!
        Me.Line21.Y2 = 3.181102!
        '
        'Line22
        '
        Me.Line22.Height = 0.22559!
        Me.Line22.Left = 1.612992!
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 3.406693!
        Me.Line22.Width = 0.0!
        Me.Line22.X1 = 1.612992!
        Me.Line22.X2 = 1.612992!
        Me.Line22.Y1 = 3.406693!
        Me.Line22.Y2 = 3.632283!
        '
        'Line35
        '
        Me.Line35.Height = 0.2255912!
        Me.Line35.Left = 1.612992!
        Me.Line35.LineWeight = 1.0!
        Me.Line35.Name = "Line35"
        Me.Line35.Top = 3.857874!
        Me.Line35.Width = 0.0!
        Me.Line35.X1 = 1.612992!
        Me.Line35.X2 = 1.612992!
        Me.Line35.Y1 = 3.857874!
        Me.Line35.Y2 = 4.083465!
        '
        'Line49
        '
        Me.Line49.Height = 0.2255912!
        Me.Line49.Left = 1.612992!
        Me.Line49.LineWeight = 1.0!
        Me.Line49.Name = "Line49"
        Me.Line49.Top = 4.309055!
        Me.Line49.Width = 0.0!
        Me.Line49.X1 = 1.612992!
        Me.Line49.X2 = 1.612992!
        Me.Line49.Y1 = 4.309055!
        Me.Line49.Y2 = 4.534646!
        '
        'Line54
        '
        Me.Line54.Height = 0.2255902!
        Me.Line54.Left = 1.612992!
        Me.Line54.LineWeight = 1.0!
        Me.Line54.Name = "Line54"
        Me.Line54.Top = 4.760236!
        Me.Line54.Width = 0.0!
        Me.Line54.X1 = 1.612992!
        Me.Line54.X2 = 1.612992!
        Me.Line54.Y1 = 4.760236!
        Me.Line54.Y2 = 4.985826!
        '
        'Line58
        '
        Me.Line58.Height = 0.2255898!
        Me.Line58.Left = 1.612992!
        Me.Line58.LineWeight = 1.0!
        Me.Line58.Name = "Line58"
        Me.Line58.Top = 5.211418!
        Me.Line58.Width = 0.0!
        Me.Line58.X1 = 1.612992!
        Me.Line58.X2 = 1.612992!
        Me.Line58.Y1 = 5.211418!
        Me.Line58.Y2 = 5.437008!
        '
        'Line59
        '
        Me.Line59.Height = 0.21496!
        Me.Line59.Left = 2.194095!
        Me.Line59.LineWeight = 1.0!
        Me.Line59.Name = "Line59"
        Me.Line59.Top = 1.612599!
        Me.Line59.Width = 0.0!
        Me.Line59.X1 = 2.194095!
        Me.Line59.X2 = 2.194095!
        Me.Line59.Y1 = 1.612599!
        Me.Line59.Y2 = 1.827559!
        '
        'Line60
        '
        Me.Line60.Height = 0.22559!
        Me.Line60.Left = 2.194095!
        Me.Line60.LineWeight = 1.0!
        Me.Line60.Name = "Line60"
        Me.Line60.Top = 2.05315!
        Me.Line60.Width = 0.0!
        Me.Line60.X1 = 2.194095!
        Me.Line60.X2 = 2.194095!
        Me.Line60.Y1 = 2.05315!
        Me.Line60.Y2 = 2.27874!
        '
        'Line61
        '
        Me.Line61.Height = 0.22559!
        Me.Line61.Left = 2.194095!
        Me.Line61.LineWeight = 1.0!
        Me.Line61.Name = "Line61"
        Me.Line61.Top = 2.504331!
        Me.Line61.Width = 0.0!
        Me.Line61.X1 = 2.194095!
        Me.Line61.X2 = 2.194095!
        Me.Line61.Y1 = 2.504331!
        Me.Line61.Y2 = 2.729921!
        '
        'Line64
        '
        Me.Line64.Height = 0.22559!
        Me.Line64.Left = 2.194095!
        Me.Line64.LineWeight = 1.0!
        Me.Line64.Name = "Line64"
        Me.Line64.Top = 2.955512!
        Me.Line64.Width = 0.0!
        Me.Line64.X1 = 2.194095!
        Me.Line64.X2 = 2.194095!
        Me.Line64.Y1 = 2.955512!
        Me.Line64.Y2 = 3.181102!
        '
        'Line65
        '
        Me.Line65.Height = 0.22559!
        Me.Line65.Left = 2.194095!
        Me.Line65.LineWeight = 1.0!
        Me.Line65.Name = "Line65"
        Me.Line65.Top = 3.406693!
        Me.Line65.Width = 0.0!
        Me.Line65.X1 = 2.194095!
        Me.Line65.X2 = 2.194095!
        Me.Line65.Y1 = 3.406693!
        Me.Line65.Y2 = 3.632283!
        '
        'Line67
        '
        Me.Line67.Height = 0.2255912!
        Me.Line67.Left = 2.194095!
        Me.Line67.LineWeight = 1.0!
        Me.Line67.Name = "Line67"
        Me.Line67.Top = 3.857874!
        Me.Line67.Width = 0.0!
        Me.Line67.X1 = 2.194095!
        Me.Line67.X2 = 2.194095!
        Me.Line67.Y1 = 3.857874!
        Me.Line67.Y2 = 4.083465!
        '
        'Line68
        '
        Me.Line68.Height = 0.2255912!
        Me.Line68.Left = 2.194095!
        Me.Line68.LineWeight = 1.0!
        Me.Line68.Name = "Line68"
        Me.Line68.Top = 4.309055!
        Me.Line68.Width = 0.0!
        Me.Line68.X1 = 2.194095!
        Me.Line68.X2 = 2.194095!
        Me.Line68.Y1 = 4.309055!
        Me.Line68.Y2 = 4.534646!
        '
        'Line69
        '
        Me.Line69.Height = 0.2255902!
        Me.Line69.Left = 2.194095!
        Me.Line69.LineWeight = 1.0!
        Me.Line69.Name = "Line69"
        Me.Line69.Top = 4.760236!
        Me.Line69.Width = 0.0!
        Me.Line69.X1 = 2.194095!
        Me.Line69.X2 = 2.194095!
        Me.Line69.Y1 = 4.760236!
        Me.Line69.Y2 = 4.985826!
        '
        'Line87
        '
        Me.Line87.Height = 0.2255898!
        Me.Line87.Left = 2.194095!
        Me.Line87.LineWeight = 1.0!
        Me.Line87.Name = "Line87"
        Me.Line87.Top = 5.211418!
        Me.Line87.Width = 0.0!
        Me.Line87.X1 = 2.194095!
        Me.Line87.X2 = 2.194095!
        Me.Line87.Y1 = 5.211418!
        Me.Line87.Y2 = 5.437008!
        '
        'Label109
        '
        Me.Label109.Height = 0.2255906!
        Me.Label109.HyperLink = Nothing
        Me.Label109.Left = 3.236221!
        Me.Label109.Name = "Label109"
        Me.Label109.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label109.Text = "利用日"
        Me.Label109.Top = 6.11378!
        Me.Label109.Width = 0.3948819!
        '
        'Label110
        '
        Me.Label110.Height = 0.2255906!
        Me.Label110.HyperLink = Nothing
        Me.Label110.Left = 4.378347!
        Me.Label110.Name = "Label110"
        Me.Label110.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label110.Text = "券種"
        Me.Label110.Top = 6.11378!
        Me.Label110.Width = 0.5464567!
        '
        'Label111
        '
        Me.Label111.Height = 0.2255906!
        Me.Label111.HyperLink = Nothing
        Me.Label111.Left = 5.966536!
        Me.Label111.Name = "Label111"
        Me.Label111.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label111.Text = "発行日"
        Me.Label111.Top = 6.11378!
        Me.Label111.Width = 0.3948819!
        '
        'Label113
        '
        Me.Label113.Height = 0.2255906!
        Me.Label113.HyperLink = Nothing
        Me.Label113.Left = 3.236221!
        Me.Label113.Name = "Label113"
        Me.Label113.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label113.Text = "番号"
        Me.Label113.Top = 6.33937!
        Me.Label113.Width = 0.381496!
        '
        'Label114
        '
        Me.Label114.Height = 0.2255906!
        Me.Label114.HyperLink = Nothing
        Me.Label114.Left = 5.966536!
        Me.Label114.Name = "Label114"
        Me.Label114.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label114.Text = "備考"
        Me.Label114.Top = 6.33937!
        Me.Label114.Width = 0.3948819!
        '
        'Label115
        '
        Me.Label115.Height = 0.2255906!
        Me.Label115.HyperLink = Nothing
        Me.Label115.Left = 4.378346!
        Me.Label115.Name = "Label115"
        Me.Label115.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label115.Text = "利用者名"
        Me.Label115.Top = 6.33937!
        Me.Label115.Width = 0.5464572!
        '
        'Line99
        '
        Me.Line99.Height = 0.0!
        Me.Line99.Left = 3.236221!
        Me.Line99.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line99.LineWeight = 1.0!
        Me.Line99.Name = "Line99"
        Me.Line99.Top = 6.33937!
        Me.Line99.Width = 4.413386!
        Me.Line99.X1 = 3.236221!
        Me.Line99.X2 = 7.649607!
        Me.Line99.Y1 = 6.33937!
        Me.Line99.Y2 = 6.33937!
        '
        'Label116
        '
        Me.Label116.Height = 0.2255906!
        Me.Label116.HyperLink = Nothing
        Me.Label116.Left = 3.236221!
        Me.Label116.Name = "Label116"
        Me.Label116.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label116.Text = "利用日"
        Me.Label116.Top = 6.56496!
        Me.Label116.Width = 0.3948819!
        '
        'Label117
        '
        Me.Label117.Height = 0.2255906!
        Me.Label117.HyperLink = Nothing
        Me.Label117.Left = 3.236221!
        Me.Label117.Name = "Label117"
        Me.Label117.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label117.Text = "番号"
        Me.Label117.Top = 6.790551!
        Me.Label117.Width = 0.381496!
        '
        'Label119
        '
        Me.Label119.Height = 0.2255906!
        Me.Label119.HyperLink = Nothing
        Me.Label119.Left = 4.378347!
        Me.Label119.Name = "Label119"
        Me.Label119.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label119.Text = "券種"
        Me.Label119.Top = 6.56496!
        Me.Label119.Width = 0.5464567!
        '
        'Label120
        '
        Me.Label120.Height = 0.2255906!
        Me.Label120.HyperLink = Nothing
        Me.Label120.Left = 5.966536!
        Me.Label120.Name = "Label120"
        Me.Label120.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label120.Text = "備考"
        Me.Label120.Top = 6.790551!
        Me.Label120.Width = 0.3948819!
        '
        'Label121
        '
        Me.Label121.Height = 0.2255906!
        Me.Label121.HyperLink = Nothing
        Me.Label121.Left = 5.966536!
        Me.Label121.Name = "Label121"
        Me.Label121.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label121.Text = "発行日"
        Me.Label121.Top = 6.56496!
        Me.Label121.Width = 0.3948819!
        '
        'Label122
        '
        Me.Label122.Height = 0.2255906!
        Me.Label122.HyperLink = Nothing
        Me.Label122.Left = 4.378346!
        Me.Label122.Name = "Label122"
        Me.Label122.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label122.Text = "利用者名"
        Me.Label122.Top = 6.790551!
        Me.Label122.Width = 0.5464572!
        '
        'Line8
        '
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 3.236221!
        Me.Line8.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 6.790551!
        Me.Line8.Width = 4.413386!
        Me.Line8.X1 = 3.236221!
        Me.Line8.X2 = 7.649607!
        Me.Line8.Y1 = 6.790551!
        Me.Line8.Y2 = 6.790551!
        '
        'Label123
        '
        Me.Label123.Height = 0.2255906!
        Me.Label123.HyperLink = Nothing
        Me.Label123.Left = 3.236221!
        Me.Label123.Name = "Label123"
        Me.Label123.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label123.Text = "利用日"
        Me.Label123.Top = 7.016141!
        Me.Label123.Width = 0.3948819!
        '
        'Label125
        '
        Me.Label125.Height = 0.2255906!
        Me.Label125.HyperLink = Nothing
        Me.Label125.Left = 3.236221!
        Me.Label125.Name = "Label125"
        Me.Label125.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label125.Text = "番号"
        Me.Label125.Top = 7.241732!
        Me.Label125.Width = 0.381496!
        '
        'Label126
        '
        Me.Label126.Height = 0.2255906!
        Me.Label126.HyperLink = Nothing
        Me.Label126.Left = 4.378347!
        Me.Label126.Name = "Label126"
        Me.Label126.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label126.Text = "券種"
        Me.Label126.Top = 7.016141!
        Me.Label126.Width = 0.5464567!
        '
        'Label127
        '
        Me.Label127.Height = 0.2255906!
        Me.Label127.HyperLink = Nothing
        Me.Label127.Left = 5.966536!
        Me.Label127.Name = "Label127"
        Me.Label127.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label127.Text = "備考"
        Me.Label127.Top = 7.241732!
        Me.Label127.Width = 0.3948819!
        '
        'Label128
        '
        Me.Label128.Height = 0.2255906!
        Me.Label128.HyperLink = Nothing
        Me.Label128.Left = 5.966536!
        Me.Label128.Name = "Label128"
        Me.Label128.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label128.Text = "発行日"
        Me.Label128.Top = 7.016141!
        Me.Label128.Width = 0.3948819!
        '
        'Label129
        '
        Me.Label129.Height = 0.2255906!
        Me.Label129.HyperLink = Nothing
        Me.Label129.Left = 4.378346!
        Me.Label129.Name = "Label129"
        Me.Label129.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label129.Text = "利用者名"
        Me.Label129.Top = 7.241732!
        Me.Label129.Width = 0.5464572!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 3.236221!
        Me.Line25.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 7.241732!
        Me.Line25.Width = 4.413386!
        Me.Line25.X1 = 3.236221!
        Me.Line25.X2 = 7.649607!
        Me.Line25.Y1 = 7.241732!
        Me.Line25.Y2 = 7.241732!
        '
        'Label131
        '
        Me.Label131.Height = 0.2255906!
        Me.Label131.HyperLink = Nothing
        Me.Label131.Left = 3.236221!
        Me.Label131.Name = "Label131"
        Me.Label131.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label131.Text = "利用日"
        Me.Label131.Top = 7.467322!
        Me.Label131.Width = 0.3948819!
        '
        'Label132
        '
        Me.Label132.Height = 0.2255906!
        Me.Label132.HyperLink = Nothing
        Me.Label132.Left = 3.236221!
        Me.Label132.Name = "Label132"
        Me.Label132.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label132.Text = "番号"
        Me.Label132.Top = 7.692914!
        Me.Label132.Width = 0.381496!
        '
        'Label133
        '
        Me.Label133.Height = 0.2255906!
        Me.Label133.HyperLink = Nothing
        Me.Label133.Left = 4.378347!
        Me.Label133.Name = "Label133"
        Me.Label133.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label133.Text = "券種"
        Me.Label133.Top = 7.467322!
        Me.Label133.Width = 0.5464567!
        '
        'Label134
        '
        Me.Label134.Height = 0.2255906!
        Me.Label134.HyperLink = Nothing
        Me.Label134.Left = 5.966536!
        Me.Label134.Name = "Label134"
        Me.Label134.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label134.Text = "備考"
        Me.Label134.Top = 7.692914!
        Me.Label134.Width = 0.3948819!
        '
        'Label135
        '
        Me.Label135.Height = 0.2255906!
        Me.Label135.HyperLink = Nothing
        Me.Label135.Left = 5.966536!
        Me.Label135.Name = "Label135"
        Me.Label135.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label135.Text = "発行日"
        Me.Label135.Top = 7.467322!
        Me.Label135.Width = 0.3948819!
        '
        'Label137
        '
        Me.Label137.Height = 0.2255906!
        Me.Label137.HyperLink = Nothing
        Me.Label137.Left = 4.378346!
        Me.Label137.Name = "Label137"
        Me.Label137.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label137.Text = "利用者名"
        Me.Label137.Top = 7.692914!
        Me.Label137.Width = 0.5464572!
        '
        'Line27
        '
        Me.Line27.Height = 0.0!
        Me.Line27.Left = 3.236221!
        Me.Line27.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 7.692914!
        Me.Line27.Width = 4.413386!
        Me.Line27.X1 = 3.236221!
        Me.Line27.X2 = 7.649607!
        Me.Line27.Y1 = 7.692914!
        Me.Line27.Y2 = 7.692914!
        '
        'Label138
        '
        Me.Label138.Height = 0.2255906!
        Me.Label138.HyperLink = Nothing
        Me.Label138.Left = 3.236221!
        Me.Label138.Name = "Label138"
        Me.Label138.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label138.Text = "利用日"
        Me.Label138.Top = 7.918504!
        Me.Label138.Width = 0.3948819!
        '
        'Label139
        '
        Me.Label139.Height = 0.2255906!
        Me.Label139.HyperLink = Nothing
        Me.Label139.Left = 3.236221!
        Me.Label139.Name = "Label139"
        Me.Label139.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label139.Text = "番号"
        Me.Label139.Top = 8.144094!
        Me.Label139.Width = 0.381496!
        '
        'Label140
        '
        Me.Label140.Height = 0.2255906!
        Me.Label140.HyperLink = Nothing
        Me.Label140.Left = 4.378347!
        Me.Label140.Name = "Label140"
        Me.Label140.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label140.Text = "券種"
        Me.Label140.Top = 7.918504!
        Me.Label140.Width = 0.5464567!
        '
        'Label141
        '
        Me.Label141.Height = 0.2255906!
        Me.Label141.HyperLink = Nothing
        Me.Label141.Left = 5.966536!
        Me.Label141.Name = "Label141"
        Me.Label141.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label141.Text = "備考"
        Me.Label141.Top = 8.144094!
        Me.Label141.Width = 0.3948819!
        '
        'Label143
        '
        Me.Label143.Height = 0.2255906!
        Me.Label143.HyperLink = Nothing
        Me.Label143.Left = 5.966536!
        Me.Label143.Name = "Label143"
        Me.Label143.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label143.Text = "発行日"
        Me.Label143.Top = 7.918504!
        Me.Label143.Width = 0.3948819!
        '
        'Line33
        '
        Me.Line33.Height = 0.0!
        Me.Line33.Left = 3.236221!
        Me.Line33.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line33.LineWeight = 1.0!
        Me.Line33.Name = "Line33"
        Me.Line33.Top = 8.144094!
        Me.Line33.Width = 4.413386!
        Me.Line33.X1 = 3.236221!
        Me.Line33.X2 = 7.649607!
        Me.Line33.Y1 = 8.144094!
        Me.Line33.Y2 = 8.144094!
        '
        'Label145
        '
        Me.Label145.Height = 0.2255906!
        Me.Label145.HyperLink = Nothing
        Me.Label145.Left = 3.236221!
        Me.Label145.Name = "Label145"
        Me.Label145.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label145.Text = "利用日"
        Me.Label145.Top = 8.369685!
        Me.Label145.Width = 0.3948819!
        '
        'Label146
        '
        Me.Label146.Height = 0.2255906!
        Me.Label146.HyperLink = Nothing
        Me.Label146.Left = 3.236221!
        Me.Label146.Name = "Label146"
        Me.Label146.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label146.Text = "番号"
        Me.Label146.Top = 8.595276!
        Me.Label146.Width = 0.381496!
        '
        'Label147
        '
        Me.Label147.Height = 0.2255906!
        Me.Label147.HyperLink = Nothing
        Me.Label147.Left = 4.378347!
        Me.Label147.Name = "Label147"
        Me.Label147.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label147.Text = "券種"
        Me.Label147.Top = 8.369685!
        Me.Label147.Width = 0.5464567!
        '
        'Label149
        '
        Me.Label149.Height = 0.2255906!
        Me.Label149.HyperLink = Nothing
        Me.Label149.Left = 5.966536!
        Me.Label149.Name = "Label149"
        Me.Label149.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label149.Text = "備考"
        Me.Label149.Top = 8.595276!
        Me.Label149.Width = 0.3948819!
        '
        'Label150
        '
        Me.Label150.Height = 0.2255906!
        Me.Label150.HyperLink = Nothing
        Me.Label150.Left = 5.966536!
        Me.Label150.Name = "Label150"
        Me.Label150.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label150.Text = "発行日"
        Me.Label150.Top = 8.369685!
        Me.Label150.Width = 0.3948819!
        '
        'Label151
        '
        Me.Label151.Height = 0.2255906!
        Me.Label151.HyperLink = Nothing
        Me.Label151.Left = 4.378346!
        Me.Label151.Name = "Label151"
        Me.Label151.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label151.Text = "利用者名"
        Me.Label151.Top = 8.595276!
        Me.Label151.Width = 0.5464572!
        '
        'Line34
        '
        Me.Line34.Height = 0.0!
        Me.Line34.Left = 3.236221!
        Me.Line34.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 8.595276!
        Me.Line34.Width = 4.413386!
        Me.Line34.X1 = 3.236221!
        Me.Line34.X2 = 7.649607!
        Me.Line34.Y1 = 8.595276!
        Me.Line34.Y2 = 8.595276!
        '
        'Label152
        '
        Me.Label152.Height = 0.2255906!
        Me.Label152.HyperLink = Nothing
        Me.Label152.Left = 3.236221!
        Me.Label152.Name = "Label152"
        Me.Label152.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label152.Text = "利用日"
        Me.Label152.Top = 8.820867!
        Me.Label152.Width = 0.3948819!
        '
        'Label153
        '
        Me.Label153.Height = 0.2255906!
        Me.Label153.HyperLink = Nothing
        Me.Label153.Left = 3.236221!
        Me.Label153.Name = "Label153"
        Me.Label153.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label153.Text = "番号"
        Me.Label153.Top = 9.046457!
        Me.Label153.Width = 0.381496!
        '
        'Label155
        '
        Me.Label155.Height = 0.2255906!
        Me.Label155.HyperLink = Nothing
        Me.Label155.Left = 4.378347!
        Me.Label155.Name = "Label155"
        Me.Label155.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label155.Text = "券種"
        Me.Label155.Top = 8.820867!
        Me.Label155.Width = 0.5464567!
        '
        'Label156
        '
        Me.Label156.Height = 0.2255906!
        Me.Label156.HyperLink = Nothing
        Me.Label156.Left = 5.966536!
        Me.Label156.Name = "Label156"
        Me.Label156.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label156.Text = "備考"
        Me.Label156.Top = 9.046457!
        Me.Label156.Width = 0.3948819!
        '
        'Label157
        '
        Me.Label157.Height = 0.2255906!
        Me.Label157.HyperLink = Nothing
        Me.Label157.Left = 5.966536!
        Me.Label157.Name = "Label157"
        Me.Label157.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label157.Text = "発行日"
        Me.Label157.Top = 8.820867!
        Me.Label157.Width = 0.3948819!
        '
        'Label158
        '
        Me.Label158.Height = 0.2255906!
        Me.Label158.HyperLink = Nothing
        Me.Label158.Left = 4.378346!
        Me.Label158.Name = "Label158"
        Me.Label158.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label158.Text = "利用者名"
        Me.Label158.Top = 9.046457!
        Me.Label158.Width = 0.5464572!
        '
        'Line40
        '
        Me.Line40.Height = 0.0!
        Me.Line40.Left = 3.236221!
        Me.Line40.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 9.046457!
        Me.Line40.Width = 4.413386!
        Me.Line40.X1 = 3.236221!
        Me.Line40.X2 = 7.649607!
        Me.Line40.Y1 = 9.046457!
        Me.Line40.Y2 = 9.046457!
        '
        'Label159
        '
        Me.Label159.Height = 0.2255906!
        Me.Label159.HyperLink = Nothing
        Me.Label159.Left = 3.236221!
        Me.Label159.Name = "Label159"
        Me.Label159.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label159.Text = "利用日"
        Me.Label159.Top = 9.272048!
        Me.Label159.Width = 0.3948819!
        '
        'Label161
        '
        Me.Label161.Height = 0.2255906!
        Me.Label161.HyperLink = Nothing
        Me.Label161.Left = 3.236221!
        Me.Label161.Name = "Label161"
        Me.Label161.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label161.Text = "番号"
        Me.Label161.Top = 9.497638!
        Me.Label161.Width = 0.381496!
        '
        'Label162
        '
        Me.Label162.Height = 0.2255906!
        Me.Label162.HyperLink = Nothing
        Me.Label162.Left = 4.378347!
        Me.Label162.Name = "Label162"
        Me.Label162.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label162.Text = "券種"
        Me.Label162.Top = 9.272048!
        Me.Label162.Width = 0.5464567!
        '
        'Label163
        '
        Me.Label163.Height = 0.2255906!
        Me.Label163.HyperLink = Nothing
        Me.Label163.Left = 5.966536!
        Me.Label163.Name = "Label163"
        Me.Label163.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label163.Text = "備考"
        Me.Label163.Top = 9.497638!
        Me.Label163.Width = 0.3948819!
        '
        'Label164
        '
        Me.Label164.Height = 0.2255906!
        Me.Label164.HyperLink = Nothing
        Me.Label164.Left = 5.966536!
        Me.Label164.Name = "Label164"
        Me.Label164.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label164.Text = "発行日"
        Me.Label164.Top = 9.272048!
        Me.Label164.Width = 0.3948819!
        '
        'Label165
        '
        Me.Label165.Height = 0.2255906!
        Me.Label165.HyperLink = Nothing
        Me.Label165.Left = 4.378346!
        Me.Label165.Name = "Label165"
        Me.Label165.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label165.Text = "利用者名"
        Me.Label165.Top = 9.497638!
        Me.Label165.Width = 0.5464572!
        '
        'Line43
        '
        Me.Line43.Height = 0.0!
        Me.Line43.Left = 3.236221!
        Me.Line43.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line43.LineWeight = 1.0!
        Me.Line43.Name = "Line43"
        Me.Line43.Top = 9.497638!
        Me.Line43.Width = 4.413386!
        Me.Line43.X1 = 3.236221!
        Me.Line43.X2 = 7.649607!
        Me.Line43.Y1 = 9.497638!
        Me.Line43.Y2 = 9.497638!
        '
        'Label167
        '
        Me.Label167.Height = 0.2255906!
        Me.Label167.HyperLink = Nothing
        Me.Label167.Left = 3.236221!
        Me.Label167.Name = "Label167"
        Me.Label167.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label167.Text = "利用日"
        Me.Label167.Top = 9.723228!
        Me.Label167.Width = 0.3948819!
        '
        'Label168
        '
        Me.Label168.Height = 0.2255906!
        Me.Label168.HyperLink = Nothing
        Me.Label168.Left = 3.236221!
        Me.Label168.Name = "Label168"
        Me.Label168.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label168.Text = "番号"
        Me.Label168.Top = 9.948819!
        Me.Label168.Width = 0.381496!
        '
        'Label169
        '
        Me.Label169.Height = 0.2255906!
        Me.Label169.HyperLink = Nothing
        Me.Label169.Left = 4.378347!
        Me.Label169.Name = "Label169"
        Me.Label169.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label169.Text = "券種"
        Me.Label169.Top = 9.723228!
        Me.Label169.Width = 0.5464567!
        '
        'Label170
        '
        Me.Label170.Height = 0.2255906!
        Me.Label170.HyperLink = Nothing
        Me.Label170.Left = 5.966536!
        Me.Label170.Name = "Label170"
        Me.Label170.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label170.Text = "備考"
        Me.Label170.Top = 9.948819!
        Me.Label170.Width = 0.3948819!
        '
        'Label171
        '
        Me.Label171.Height = 0.2255906!
        Me.Label171.HyperLink = Nothing
        Me.Label171.Left = 5.966536!
        Me.Label171.Name = "Label171"
        Me.Label171.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label171.Text = "発行日"
        Me.Label171.Top = 9.723228!
        Me.Label171.Width = 0.3948819!
        '
        'Label173
        '
        Me.Label173.Height = 0.2255906!
        Me.Label173.HyperLink = Nothing
        Me.Label173.Left = 4.378346!
        Me.Label173.Name = "Label173"
        Me.Label173.Style = "background-color: LightGrey; font-family: ＭＳ ゴシック; font-size: 9pt; text-align: ce" & _
            "nter; vertical-align: middle; white-space: nowrap"
        Me.Label173.Text = "利用者名"
        Me.Label173.Top = 9.948819!
        Me.Label173.Width = 0.5464572!
        '
        'Line44
        '
        Me.Line44.Height = 0.0!
        Me.Line44.Left = 3.236221!
        Me.Line44.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line44.LineWeight = 1.0!
        Me.Line44.Name = "Line44"
        Me.Line44.Top = 9.948819!
        Me.Line44.Width = 4.413386!
        Me.Line44.X1 = 3.236221!
        Me.Line44.X2 = 7.649607!
        Me.Line44.Y1 = 9.948819!
        Me.Line44.Y2 = 9.948819!
        '
        'Line74
        '
        Me.Line74.Height = 0.0!
        Me.Line74.Left = 0.0!
        Me.Line74.LineWeight = 1.0!
        Me.Line74.Name = "Line74"
        Me.Line74.Top = 10.17441!
        Me.Line74.Width = 7.649607!
        Me.Line74.X1 = 0.0!
        Me.Line74.X2 = 7.649607!
        Me.Line74.Y1 = 10.17441!
        Me.Line74.Y2 = 10.17441!
        '
        'Line112
        '
        Me.Line112.Height = 0.0!
        Me.Line112.Left = 2.842171E-14!
        Me.Line112.LineWeight = 1.0!
        Me.Line112.Name = "Line112"
        Me.Line112.Top = 2.05315!
        Me.Line112.Width = 7.649607!
        Me.Line112.X1 = 2.842171E-14!
        Me.Line112.X2 = 7.649607!
        Me.Line112.Y1 = 2.05315!
        Me.Line112.Y2 = 2.05315!
        '
        'Line9
        '
        Me.Line9.Height = 9.023623!
        Me.Line9.Left = 3.631103!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.150787!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 3.631103!
        Me.Line9.X2 = 3.631103!
        Me.Line9.Y1 = 1.150787!
        Me.Line9.Y2 = 10.17441!
        '
        'Line45
        '
        Me.Line45.Height = 9.023623!
        Me.Line45.Left = 3.236221!
        Me.Line45.LineWeight = 1.0!
        Me.Line45.Name = "Line45"
        Me.Line45.Top = 1.150787!
        Me.Line45.Width = 0.0!
        Me.Line45.X1 = 3.236221!
        Me.Line45.X2 = 3.236221!
        Me.Line45.Y1 = 1.150787!
        Me.Line45.Y2 = 10.17441!
        '
        'Line47
        '
        Me.Line47.Height = 0.0!
        Me.Line47.Left = 3.236221!
        Me.Line47.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line47.LineWeight = 1.0!
        Me.Line47.Name = "Line47"
        Me.Line47.Top = 2.27874!
        Me.Line47.Width = 4.413386!
        Me.Line47.X1 = 3.236221!
        Me.Line47.X2 = 7.649607!
        Me.Line47.Y1 = 2.27874!
        Me.Line47.Y2 = 2.27874!
        '
        'Line48
        '
        Me.Line48.Height = 0.0!
        Me.Line48.Left = 3.236221!
        Me.Line48.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line48.LineWeight = 1.0!
        Me.Line48.Name = "Line48"
        Me.Line48.Top = 2.729921!
        Me.Line48.Width = 4.413386!
        Me.Line48.X1 = 3.236221!
        Me.Line48.X2 = 7.649607!
        Me.Line48.Y1 = 2.729921!
        Me.Line48.Y2 = 2.729921!
        '
        'Line50
        '
        Me.Line50.Height = 0.0!
        Me.Line50.Left = 3.236221!
        Me.Line50.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line50.LineWeight = 1.0!
        Me.Line50.Name = "Line50"
        Me.Line50.Top = 3.181102!
        Me.Line50.Width = 4.413386!
        Me.Line50.X1 = 3.236221!
        Me.Line50.X2 = 7.649607!
        Me.Line50.Y1 = 3.181102!
        Me.Line50.Y2 = 3.181102!
        '
        'Line52
        '
        Me.Line52.Height = 0.0!
        Me.Line52.Left = 3.236221!
        Me.Line52.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line52.LineWeight = 1.0!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 3.632283!
        Me.Line52.Width = 4.413386!
        Me.Line52.X1 = 3.236221!
        Me.Line52.X2 = 7.649607!
        Me.Line52.Y1 = 3.632283!
        Me.Line52.Y2 = 3.632283!
        '
        'Line53
        '
        Me.Line53.Height = 0.0!
        Me.Line53.Left = 3.236221!
        Me.Line53.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line53.LineWeight = 1.0!
        Me.Line53.Name = "Line53"
        Me.Line53.Top = 4.083465!
        Me.Line53.Width = 4.413386!
        Me.Line53.X1 = 3.236221!
        Me.Line53.X2 = 7.649607!
        Me.Line53.Y1 = 4.083465!
        Me.Line53.Y2 = 4.083465!
        '
        'Line55
        '
        Me.Line55.Height = 0.0!
        Me.Line55.Left = 3.236221!
        Me.Line55.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line55.LineWeight = 1.0!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 4.534646!
        Me.Line55.Width = 4.413386!
        Me.Line55.X1 = 3.236221!
        Me.Line55.X2 = 7.649607!
        Me.Line55.Y1 = 4.534646!
        Me.Line55.Y2 = 4.534646!
        '
        'Line56
        '
        Me.Line56.Height = 0.0!
        Me.Line56.Left = 3.236221!
        Me.Line56.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line56.LineWeight = 1.0!
        Me.Line56.Name = "Line56"
        Me.Line56.Top = 4.985826!
        Me.Line56.Width = 4.413386!
        Me.Line56.X1 = 3.236221!
        Me.Line56.X2 = 7.649607!
        Me.Line56.Y1 = 4.985826!
        Me.Line56.Y2 = 4.985826!
        '
        'Line57
        '
        Me.Line57.Height = 0.0!
        Me.Line57.Left = 3.236221!
        Me.Line57.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line57.LineWeight = 1.0!
        Me.Line57.Name = "Line57"
        Me.Line57.Top = 5.437008!
        Me.Line57.Width = 4.413386!
        Me.Line57.X1 = 3.236221!
        Me.Line57.X2 = 7.649607!
        Me.Line57.Y1 = 5.437008!
        Me.Line57.Y2 = 5.437008!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 3.857874!
        Me.Line10.Width = 7.649607!
        Me.Line10.X1 = 0.0!
        Me.Line10.X2 = 7.649607!
        Me.Line10.Y1 = 3.857874!
        Me.Line10.Y2 = 3.857874!
        '
        'Line66
        '
        Me.Line66.Height = 9.023623!
        Me.Line66.Left = 6.361418!
        Me.Line66.LineWeight = 1.0!
        Me.Line66.Name = "Line66"
        Me.Line66.Top = 1.150787!
        Me.Line66.Width = 0.0!
        Me.Line66.X1 = 6.361418!
        Me.Line66.X2 = 6.361418!
        Me.Line66.Y1 = 1.150787!
        Me.Line66.Y2 = 10.17441!
        '
        'Line14
        '
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 2.787402!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 6.11378!
        Me.Line14.Width = 4.862206!
        Me.Line14.X1 = 2.787402!
        Me.Line14.X2 = 7.649607!
        Me.Line14.Y1 = 6.11378!
        Me.Line14.Y2 = 6.11378!
        '
        'Line24
        '
        Me.Line24.Height = 0.0!
        Me.Line24.Left = 2.787402!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 7.016141!
        Me.Line24.Width = 4.862206!
        Me.Line24.X1 = 2.787402!
        Me.Line24.X2 = 7.649607!
        Me.Line24.Y1 = 7.016141!
        Me.Line24.Y2 = 7.016141!
        '
        'Line29
        '
        Me.Line29.Height = 0.0!
        Me.Line29.Left = 2.787402!
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 7.467322!
        Me.Line29.Width = 4.862206!
        Me.Line29.X1 = 2.787402!
        Me.Line29.X2 = 7.649607!
        Me.Line29.Y1 = 7.467322!
        Me.Line29.Y2 = 7.467322!
        '
        'Line76
        '
        Me.Line76.Height = 9.249213!
        Me.Line76.Left = 5.966536!
        Me.Line76.LineWeight = 1.0!
        Me.Line76.Name = "Line76"
        Me.Line76.Top = 0.9251968!
        Me.Line76.Width = 0.0!
        Me.Line76.X1 = 5.966536!
        Me.Line76.X2 = 5.966536!
        Me.Line76.Y1 = 0.9251968!
        Me.Line76.Y2 = 10.17441!
        '
        'Line30
        '
        Me.Line30.Height = 0.0!
        Me.Line30.Left = 2.787402!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 7.918504!
        Me.Line30.Width = 4.862206!
        Me.Line30.X1 = 2.787402!
        Me.Line30.X2 = 7.649607!
        Me.Line30.Y1 = 7.918504!
        Me.Line30.Y2 = 7.918504!
        '
        'Line70
        '
        Me.Line70.Height = 0.0!
        Me.Line70.Left = 2.787402!
        Me.Line70.LineWeight = 1.0!
        Me.Line70.Name = "Line70"
        Me.Line70.Top = 8.369685!
        Me.Line70.Width = 4.862206!
        Me.Line70.X1 = 2.787402!
        Me.Line70.X2 = 7.649607!
        Me.Line70.Y1 = 8.369685!
        Me.Line70.Y2 = 8.369685!
        '
        'Line71
        '
        Me.Line71.Height = 0.0!
        Me.Line71.Left = 2.787402!
        Me.Line71.LineWeight = 1.0!
        Me.Line71.Name = "Line71"
        Me.Line71.Top = 8.820867!
        Me.Line71.Width = 4.862206!
        Me.Line71.X1 = 2.787402!
        Me.Line71.X2 = 7.649607!
        Me.Line71.Y1 = 8.820867!
        Me.Line71.Y2 = 8.820867!
        '
        'Line72
        '
        Me.Line72.Height = 0.0!
        Me.Line72.Left = 2.787402!
        Me.Line72.LineWeight = 1.0!
        Me.Line72.Name = "Line72"
        Me.Line72.Top = 9.272048!
        Me.Line72.Width = 4.862206!
        Me.Line72.X1 = 2.787402!
        Me.Line72.X2 = 7.649607!
        Me.Line72.Y1 = 9.272048!
        Me.Line72.Y2 = 9.272048!
        '
        'Line73
        '
        Me.Line73.Height = 0.0!
        Me.Line73.Left = 2.787402!
        Me.Line73.LineWeight = 1.0!
        Me.Line73.Name = "Line73"
        Me.Line73.Top = 9.723228!
        Me.Line73.Width = 4.862206!
        Me.Line73.X1 = 2.787402!
        Me.Line73.X2 = 7.649607!
        Me.Line73.Y1 = 9.723228!
        Me.Line73.Y2 = 9.723228!
        '
        'Line28
        '
        Me.Line28.Height = 9.023623!
        Me.Line28.Left = 2.787402!
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 1.150787!
        Me.Line28.Width = 0.0!
        Me.Line28.X1 = 2.787402!
        Me.Line28.X2 = 2.787402!
        Me.Line28.Y1 = 1.150787!
        Me.Line28.Y2 = 10.17441!
        '
        'Label4
        '
        Me.Label4.Height = 0.2255906!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.378346!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: ＭＳ ゴシック; font-size: 9pt; text-align: center; vertical-align: middle;" & _
            " white-space: nowrap"
        Me.Label4.Text = "緊急"
        Me.Label4.Top = 0.9251968!
        Me.Label4.Width = 0.5464566!
        '
        'Line75
        '
        Me.Line75.Height = 9.249213!
        Me.Line75.Left = 4.378346!
        Me.Line75.LineWeight = 1.0!
        Me.Line75.Name = "Line75"
        Me.Line75.Top = 0.9251968!
        Me.Line75.Width = 0.0!
        Me.Line75.X1 = 4.378346!
        Me.Line75.X2 = 4.378346!
        Me.Line75.Y1 = 0.9251968!
        Me.Line75.Y2 = 10.17441!
        '
        'Line79
        '
        Me.Line79.Height = 9.249213!
        Me.Line79.Left = 4.924803!
        Me.Line79.LineWeight = 1.0!
        Me.Line79.Name = "Line79"
        Me.Line79.Top = 0.9251968!
        Me.Line79.Width = 0.0!
        Me.Line79.X1 = 4.924803!
        Me.Line79.X2 = 4.924803!
        Me.Line79.Y1 = 0.9251968!
        Me.Line79.Y2 = 10.17441!
        '
        'Line38
        '
        Me.Line38.Height = 0.0!
        Me.Line38.Left = 2.842171E-14!
        Me.Line38.LineWeight = 1.0!
        Me.Line38.Name = "Line38"
        Me.Line38.Top = 1.150787!
        Me.Line38.Width = 7.649607!
        Me.Line38.X1 = 2.842171E-14!
        Me.Line38.X2 = 7.649607!
        Me.Line38.Y1 = 1.150787!
        Me.Line38.Y2 = 1.150787!
        '
        'Line114
        '
        Me.Line114.Height = 0.0!
        Me.Line114.Left = 0.0000004768373!
        Me.Line114.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line114.LineWeight = 1.0!
        Me.Line114.Name = "Line114"
        Me.Line114.Top = 0.9251968!
        Me.Line114.Width = 7.649607!
        Me.Line114.X1 = 0.0000004768373!
        Me.Line114.X2 = 7.649607!
        Me.Line114.Y1 = 0.9251968!
        Me.Line114.Y2 = 0.9251968!
        '
        'Line12
        '
        Me.Line12.Height = 0.0!
        Me.Line12.Left = 1.862645E-9!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 8.682678!
        Me.Line12.Width = 2.787402!
        Me.Line12.X1 = 1.862645E-9!
        Me.Line12.X2 = 2.787402!
        Me.Line12.Y1 = 8.682678!
        Me.Line12.Y2 = 8.682678!
        '
        'Line31
        '
        Me.Line31.Height = 0.0!
        Me.Line31.Left = 0.0!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 8.913386!
        Me.Line31.Width = 2.787402!
        Me.Line31.X1 = 0.0!
        Me.Line31.X2 = 2.787402!
        Me.Line31.Y1 = 8.913386!
        Me.Line31.Y2 = 8.913386!
        '
        'Line103
        '
        Me.Line103.Height = 0.0!
        Me.Line103.Left = 2.787402!
        Me.Line103.LineWeight = 1.0!
        Me.Line103.Name = "Line103"
        Me.Line103.Top = 6.56496!
        Me.Line103.Width = 4.862206!
        Me.Line103.X1 = 2.787402!
        Me.Line103.X2 = 7.649607!
        Me.Line103.Y1 = 6.56496!
        Me.Line103.Y2 = 6.56496!
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label2, Me.Label1, Me.PRINT_DATE, Me.PRINT_USER, Me.ANS_TAXI_MAISUU, Me.LblMaisuu, Me.ANS_TAXI_TESURYO, Me.FROM_DATE})
        Me.PageFooter.Height = 0.6070866!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label2
        '
        Me.Label2.Height = 0.2!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 5.548032!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "text-align: right"
        Me.Label2.Text = "出力担当："
        Me.Label2.Top = 0.2070866!
        Me.Label2.Width = 0.7291334!
        '
        'Label1
        '
        Me.Label1.Height = 0.2!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 5.693701!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "text-align: right"
        Me.Label1.Text = "出力日："
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.5834652!
        '
        'PRINT_DATE
        '
        Me.PRINT_DATE.Height = 0.2!
        Me.PRINT_DATE.Left = 6.277166!
        Me.PRINT_DATE.Name = "PRINT_DATE"
        Me.PRINT_DATE.Style = "white-space: nowrap"
        Me.PRINT_DATE.Text = "1234/56/78 12:34:56"
        Me.PRINT_DATE.Top = 0.0!
        Me.PRINT_DATE.Width = 1.364567!
        '
        'PRINT_USER
        '
        Me.PRINT_USER.Height = 0.2!
        Me.PRINT_USER.Left = 6.277165!
        Me.PRINT_USER.Name = "PRINT_USER"
        Me.PRINT_USER.Style = "white-space: nowrap"
        Me.PRINT_USER.Text = Nothing
        Me.PRINT_USER.Top = 0.2070864!
        Me.PRINT_USER.Width = 1.364567!
        '
        'ANS_TAXI_MAISUU
        '
        Me.ANS_TAXI_MAISUU.Height = 0.4271654!
        Me.ANS_TAXI_MAISUU.Left = 0.0!
        Me.ANS_TAXI_MAISUU.Name = "ANS_TAXI_MAISUU"
        Me.ANS_TAXI_MAISUU.Style = "font-size: 24pt; text-align: right; vertical-align: bottom"
        Me.ANS_TAXI_MAISUU.Text = Nothing
        Me.ANS_TAXI_MAISUU.Top = 0.0!
        Me.ANS_TAXI_MAISUU.Width = 0.4488189!
        '
        'LblMaisuu
        '
        Me.LblMaisuu.Height = 0.3937008!
        Me.LblMaisuu.HyperLink = Nothing
        Me.LblMaisuu.Left = 0.5307087!
        Me.LblMaisuu.Name = "LblMaisuu"
        Me.LblMaisuu.Style = "font-size: 14pt; text-align: left; vertical-align: bottom"
        Me.LblMaisuu.Text = "枚"
        Me.LblMaisuu.Top = 0.0!
        Me.LblMaisuu.Width = 0.3129922!
        '
        'ANS_TAXI_TESURYO
        '
        Me.ANS_TAXI_TESURYO.DataField = "ANS_TAXI_TESURYO"
        Me.ANS_TAXI_TESURYO.Height = 0.2!
        Me.ANS_TAXI_TESURYO.Left = 1.118898!
        Me.ANS_TAXI_TESURYO.Name = "ANS_TAXI_TESURYO"
        Me.ANS_TAXI_TESURYO.Style = "white-space: nowrap"
        Me.ANS_TAXI_TESURYO.Text = Nothing
        Me.ANS_TAXI_TESURYO.Top = 0.007086615!
        Me.ANS_TAXI_TESURYO.Width = 1.364567!
        '
        'FROM_DATE
        '
        Me.FROM_DATE.DataField = "FROM_DATE"
        Me.FROM_DATE.Height = 0.2!
        Me.FROM_DATE.Left = 2.7!
        Me.FROM_DATE.Name = "FROM_DATE"
        Me.FROM_DATE.Style = "white-space: nowrap"
        Me.FROM_DATE.Text = Nothing
        Me.FROM_DATE.Top = 0.007086605!
        Me.FROM_DATE.Width = 1.364567!
        '
        'TaxiKakuninReport
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.649607!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
                    "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.Label198, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label201, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEND_SAKI_OTHER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label174, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KINKYU_FLAG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label144, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label202, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DANTAI_CODE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label185, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label178, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label184, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_HOTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label183, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_KOTSU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label182, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label180, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label124, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label90, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label82, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_FROM_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KOUTEI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_TAXI_DATE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label74, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TAXI_YOTEIKINGAKU_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SHISETSU_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label130, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label136, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label142, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label148, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label154, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label160, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label166, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label172, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_RMKS_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_HAKKO_DATE_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_DATE_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_KENSHU_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_NO_20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label106, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label112, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label118, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label181, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_O_TEHAI_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_F_TEHAI_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_O_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_F_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label203, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label204, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label205, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label206, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label207, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label75, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label208, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label209, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label210, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label76, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label77, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label79, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label80, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label99, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label101, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label211, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label212, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label213, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label214, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label215, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label216, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label83, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label84, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label85, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label102, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label103, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label104, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label105, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label88, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label89, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label107, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label108, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label109, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label110, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label113, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label114, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label115, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label116, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label117, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label119, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label120, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label121, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label122, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label123, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label125, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label126, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label127, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label128, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label129, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label131, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label132, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label133, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label134, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label135, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label137, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label138, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label139, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label140, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label141, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label143, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label145, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label146, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label147, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label149, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label150, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label151, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label152, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label153, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label155, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label156, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label157, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label158, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label159, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label161, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label162, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label163, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label164, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label165, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label167, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label168, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label169, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label170, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label171, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label173, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRINT_USER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_MAISUU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LblMaisuu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANS_TAXI_TESURYO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FROM_DATE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUTEI_1 As DataDynamics.ActiveReports.Label
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKASHA_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line37 As DataDynamics.ActiveReports.Line
    Private WithEvents Line38 As DataDynamics.ActiveReports.Line
    Private WithEvents Line51 As DataDynamics.ActiveReports.Line
    Private WithEvents Label71 As DataDynamics.ActiveReports.Label
    Private WithEvents TEHAI_TAXI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label73 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label74 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TAXI_YOTEIKINGAKU_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label45 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label47 As DataDynamics.ActiveReports.Label
    Private WithEvents Label48 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label49 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label51 As DataDynamics.ActiveReports.Label
    Private WithEvents Label52 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label53 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label56 As DataDynamics.ActiveReports.Label
    Private WithEvents Label57 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label58 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_TAXI_FROM_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label60 As DataDynamics.ActiveReports.Label
    Private WithEvents Label61 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label65 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label78 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label82 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label86 As DataDynamics.ActiveReports.Label
    Private WithEvents TAXI_YOTEIKINGAKU_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_FROM_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_TAXI_DATE_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label90 As DataDynamics.ActiveReports.Label
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
    Private WithEvents Line41 As DataDynamics.ActiveReports.Line
    Private WithEvents Line42 As DataDynamics.ActiveReports.Line
    Private WithEvents DR_SHISETSU_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Line62 As DataDynamics.ActiveReports.Line
    Private WithEvents Line63 As DataDynamics.ActiveReports.Line
    Private WithEvents Line163 As DataDynamics.ActiveReports.Line
    Private WithEvents Line164 As DataDynamics.ActiveReports.Line
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line16 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line26 As DataDynamics.ActiveReports.Line
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_KENSHU_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_NO_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_HAKKO_DATE_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents Label27 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label28 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_KENSHU_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label30 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_HAKKO_DATE_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_RMKS_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label32 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label34 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_KENSHU_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label36 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_HAKKO_DATE_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_RMKS_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label38 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_RMKS_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label69 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label94 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label100 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label106 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label112 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label118 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label124 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label130 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label136 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label142 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_RMKS_15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label148 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label154 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label160 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label166 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label172 As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_RMKS_20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_HAKKO_DATE_20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_DATE_20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_KENSHU_20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NO_20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label178 As DataDynamics.ActiveReports.Label
    Private WithEvents Line28 As DataDynamics.ActiveReports.Line
    Private WithEvents Line36 As DataDynamics.ActiveReports.Line
    Private WithEvents Label180 As DataDynamics.ActiveReports.Label
    Private WithEvents Line104 As DataDynamics.ActiveReports.Line
    Private WithEvents REQ_TAXI_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents ANS_TAXI_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label181 As DataDynamics.ActiveReports.Label
    Private WithEvents Label183 As DataDynamics.ActiveReports.Label
    Private WithEvents TEHAI_KOTSU As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label182 As DataDynamics.ActiveReports.Label
    Private WithEvents TEHAI_HOTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label184 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_MR_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_O_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_F_TEHAI_5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_O_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_F_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label185 As DataDynamics.ActiveReports.Label
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line47 As DataDynamics.ActiveReports.Line
    Private WithEvents Line50 As DataDynamics.ActiveReports.Line
    Private WithEvents Line52 As DataDynamics.ActiveReports.Line
    Private WithEvents Line53 As DataDynamics.ActiveReports.Line
    Private WithEvents Line55 As DataDynamics.ActiveReports.Line
    Private WithEvents Line56 As DataDynamics.ActiveReports.Line
    Private WithEvents Line57 As DataDynamics.ActiveReports.Line
    Private WithEvents Line100 As DataDynamics.ActiveReports.Line
    Private WithEvents Line101 As DataDynamics.ActiveReports.Line
    Private WithEvents Line102 As DataDynamics.ActiveReports.Line
    Private WithEvents Line105 As DataDynamics.ActiveReports.Line
    Private WithEvents Line106 As DataDynamics.ActiveReports.Line
    Private WithEvents Line111 As DataDynamics.ActiveReports.Line
    Private WithEvents Line112 As DataDynamics.ActiveReports.Line
    Private WithEvents Line114 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line136 As DataDynamics.ActiveReports.Line
    Private WithEvents Line138 As DataDynamics.ActiveReports.Line
    Private WithEvents Line139 As DataDynamics.ActiveReports.Line
    Private WithEvents Line140 As DataDynamics.ActiveReports.Line
    Private WithEvents Line143 As DataDynamics.ActiveReports.Line
    Private WithEvents Line144 As DataDynamics.ActiveReports.Line
    Private WithEvents Line145 As DataDynamics.ActiveReports.Line
    Private WithEvents DANTAI_CODE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line152 As DataDynamics.ActiveReports.Line
    Private WithEvents Line153 As DataDynamics.ActiveReports.Line
    Private WithEvents Label200 As DataDynamics.ActiveReports.Label
    Private WithEvents Line155 As DataDynamics.ActiveReports.Line
    Private WithEvents Line17 As DataDynamics.ActiveReports.Line
    Private WithEvents Line107 As DataDynamics.ActiveReports.Line
    Private WithEvents Line109 As DataDynamics.ActiveReports.Line
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents PRINT_DATE As DataDynamics.ActiveReports.TextBox
    Private WithEvents PRINT_USER As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label198 As DataDynamics.ActiveReports.Label
    Private WithEvents Label201 As DataDynamics.ActiveReports.Label
    Private WithEvents Line85 As DataDynamics.ActiveReports.Line
    Private WithEvents Label46 As DataDynamics.ActiveReports.Label
    Private WithEvents Line110 As DataDynamics.ActiveReports.Line
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents Label202 As DataDynamics.ActiveReports.Label
    Private WithEvents Line66 As DataDynamics.ActiveReports.Line
    Private WithEvents Label50 As DataDynamics.ActiveReports.Label
    Private WithEvents Line135 As DataDynamics.ActiveReports.Line
    Private WithEvents Label203 As DataDynamics.ActiveReports.Label
    Private WithEvents Label204 As DataDynamics.ActiveReports.Label
    Private WithEvents Label31 As DataDynamics.ActiveReports.Label
    Private WithEvents Label205 As DataDynamics.ActiveReports.Label
    Private WithEvents Line48 As DataDynamics.ActiveReports.Line
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents Label33 As DataDynamics.ActiveReports.Label
    Private WithEvents Label35 As DataDynamics.ActiveReports.Label
    Private WithEvents Label37 As DataDynamics.ActiveReports.Label
    Private WithEvents Label54 As DataDynamics.ActiveReports.Label
    Private WithEvents Label206 As DataDynamics.ActiveReports.Label
    Private WithEvents Label207 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Label44 As DataDynamics.ActiveReports.Label
    Private WithEvents Label55 As DataDynamics.ActiveReports.Label
    Private WithEvents Label59 As DataDynamics.ActiveReports.Label
    Private WithEvents Label62 As DataDynamics.ActiveReports.Label
    Private WithEvents Label63 As DataDynamics.ActiveReports.Label
    Private WithEvents Label64 As DataDynamics.ActiveReports.Label
    Private WithEvents Label67 As DataDynamics.ActiveReports.Label
    Private WithEvents Label68 As DataDynamics.ActiveReports.Label
    Private WithEvents Label70 As DataDynamics.ActiveReports.Label
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents Label75 As DataDynamics.ActiveReports.Label
    Private WithEvents Label91 As DataDynamics.ActiveReports.Label
    Private WithEvents Label92 As DataDynamics.ActiveReports.Label
    Private WithEvents Label93 As DataDynamics.ActiveReports.Label
    Private WithEvents Label95 As DataDynamics.ActiveReports.Label
    Private WithEvents Label208 As DataDynamics.ActiveReports.Label
    Private WithEvents Label209 As DataDynamics.ActiveReports.Label
    Private WithEvents Label210 As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label66 As DataDynamics.ActiveReports.Label
    Private WithEvents Label76 As DataDynamics.ActiveReports.Label
    Private WithEvents Label77 As DataDynamics.ActiveReports.Label
    Private WithEvents Label79 As DataDynamics.ActiveReports.Label
    Private WithEvents Label80 As DataDynamics.ActiveReports.Label
    Private WithEvents Label81 As DataDynamics.ActiveReports.Label
    Private WithEvents Label96 As DataDynamics.ActiveReports.Label
    Private WithEvents Label97 As DataDynamics.ActiveReports.Label
    Private WithEvents Label98 As DataDynamics.ActiveReports.Label
    Private WithEvents Label99 As DataDynamics.ActiveReports.Label
    Private WithEvents Label101 As DataDynamics.ActiveReports.Label
    Private WithEvents Label211 As DataDynamics.ActiveReports.Label
    Private WithEvents Label212 As DataDynamics.ActiveReports.Label
    Private WithEvents Label213 As DataDynamics.ActiveReports.Label
    Private WithEvents Label214 As DataDynamics.ActiveReports.Label
    Private WithEvents Label215 As DataDynamics.ActiveReports.Label
    Private WithEvents Label216 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label29 As DataDynamics.ActiveReports.Label
    Private WithEvents Label83 As DataDynamics.ActiveReports.Label
    Private WithEvents Label84 As DataDynamics.ActiveReports.Label
    Private WithEvents Label85 As DataDynamics.ActiveReports.Label
    Private WithEvents Label102 As DataDynamics.ActiveReports.Label
    Private WithEvents Label103 As DataDynamics.ActiveReports.Label
    Private WithEvents Label104 As DataDynamics.ActiveReports.Label
    Private WithEvents Label105 As DataDynamics.ActiveReports.Label
    Private WithEvents Label72 As DataDynamics.ActiveReports.Label
    Private WithEvents Label87 As DataDynamics.ActiveReports.Label
    Private WithEvents Label88 As DataDynamics.ActiveReports.Label
    Private WithEvents Label89 As DataDynamics.ActiveReports.Label
    Private WithEvents Label107 As DataDynamics.ActiveReports.Label
    Private WithEvents Label108 As DataDynamics.ActiveReports.Label
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line14 As DataDynamics.ActiveReports.Line
    Private WithEvents Line15 As DataDynamics.ActiveReports.Line
    Private WithEvents Line19 As DataDynamics.ActiveReports.Line
    Private WithEvents Line20 As DataDynamics.ActiveReports.Line
    Private WithEvents Line21 As DataDynamics.ActiveReports.Line
    Private WithEvents Line22 As DataDynamics.ActiveReports.Line
    Private WithEvents Line35 As DataDynamics.ActiveReports.Line
    Private WithEvents Line49 As DataDynamics.ActiveReports.Line
    Private WithEvents Line54 As DataDynamics.ActiveReports.Line
    Private WithEvents Line58 As DataDynamics.ActiveReports.Line
    Private WithEvents Line59 As DataDynamics.ActiveReports.Line
    Private WithEvents Line60 As DataDynamics.ActiveReports.Line
    Private WithEvents Line61 As DataDynamics.ActiveReports.Line
    Private WithEvents Line64 As DataDynamics.ActiveReports.Line
    Private WithEvents Line65 As DataDynamics.ActiveReports.Line
    Private WithEvents Line67 As DataDynamics.ActiveReports.Line
    Private WithEvents Line68 As DataDynamics.ActiveReports.Line
    Private WithEvents Line69 As DataDynamics.ActiveReports.Line
    Private WithEvents Line87 As DataDynamics.ActiveReports.Line
    Private WithEvents Label109 As DataDynamics.ActiveReports.Label
    Private WithEvents Label110 As DataDynamics.ActiveReports.Label
    Private WithEvents Label111 As DataDynamics.ActiveReports.Label
    Private WithEvents Label113 As DataDynamics.ActiveReports.Label
    Private WithEvents Label114 As DataDynamics.ActiveReports.Label
    Private WithEvents Label115 As DataDynamics.ActiveReports.Label
    Private WithEvents Line99 As DataDynamics.ActiveReports.Line
    Private WithEvents Line103 As DataDynamics.ActiveReports.Line
    Private WithEvents Label116 As DataDynamics.ActiveReports.Label
    Private WithEvents Label117 As DataDynamics.ActiveReports.Label
    Private WithEvents Label119 As DataDynamics.ActiveReports.Label
    Private WithEvents Label120 As DataDynamics.ActiveReports.Label
    Private WithEvents Label121 As DataDynamics.ActiveReports.Label
    Private WithEvents Label122 As DataDynamics.ActiveReports.Label
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line24 As DataDynamics.ActiveReports.Line
    Private WithEvents Label123 As DataDynamics.ActiveReports.Label
    Private WithEvents Label125 As DataDynamics.ActiveReports.Label
    Private WithEvents Label126 As DataDynamics.ActiveReports.Label
    Private WithEvents Label127 As DataDynamics.ActiveReports.Label
    Private WithEvents Label128 As DataDynamics.ActiveReports.Label
    Private WithEvents Label129 As DataDynamics.ActiveReports.Label
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Line29 As DataDynamics.ActiveReports.Line
    Private WithEvents Label131 As DataDynamics.ActiveReports.Label
    Private WithEvents Label132 As DataDynamics.ActiveReports.Label
    Private WithEvents Label133 As DataDynamics.ActiveReports.Label
    Private WithEvents Label134 As DataDynamics.ActiveReports.Label
    Private WithEvents Label135 As DataDynamics.ActiveReports.Label
    Private WithEvents Label137 As DataDynamics.ActiveReports.Label
    Private WithEvents Line27 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Label138 As DataDynamics.ActiveReports.Label
    Private WithEvents Label139 As DataDynamics.ActiveReports.Label
    Private WithEvents Label140 As DataDynamics.ActiveReports.Label
    Private WithEvents Label141 As DataDynamics.ActiveReports.Label
    Private WithEvents Label143 As DataDynamics.ActiveReports.Label
    Private WithEvents Label144 As DataDynamics.ActiveReports.Label
    Private WithEvents Line33 As DataDynamics.ActiveReports.Line
    Private WithEvents Line70 As DataDynamics.ActiveReports.Line
    Private WithEvents Label145 As DataDynamics.ActiveReports.Label
    Private WithEvents Label146 As DataDynamics.ActiveReports.Label
    Private WithEvents Label147 As DataDynamics.ActiveReports.Label
    Private WithEvents Label149 As DataDynamics.ActiveReports.Label
    Private WithEvents Label150 As DataDynamics.ActiveReports.Label
    Private WithEvents Label151 As DataDynamics.ActiveReports.Label
    Private WithEvents Line34 As DataDynamics.ActiveReports.Line
    Private WithEvents Line71 As DataDynamics.ActiveReports.Line
    Private WithEvents Label152 As DataDynamics.ActiveReports.Label
    Private WithEvents Label153 As DataDynamics.ActiveReports.Label
    Private WithEvents Label155 As DataDynamics.ActiveReports.Label
    Private WithEvents Label156 As DataDynamics.ActiveReports.Label
    Private WithEvents Label157 As DataDynamics.ActiveReports.Label
    Private WithEvents Label158 As DataDynamics.ActiveReports.Label
    Private WithEvents Line40 As DataDynamics.ActiveReports.Line
    Private WithEvents Line72 As DataDynamics.ActiveReports.Line
    Private WithEvents Label159 As DataDynamics.ActiveReports.Label
    Private WithEvents Label161 As DataDynamics.ActiveReports.Label
    Private WithEvents Label162 As DataDynamics.ActiveReports.Label
    Private WithEvents Label163 As DataDynamics.ActiveReports.Label
    Private WithEvents Label164 As DataDynamics.ActiveReports.Label
    Private WithEvents Label165 As DataDynamics.ActiveReports.Label
    Private WithEvents Line43 As DataDynamics.ActiveReports.Line
    Private WithEvents Line73 As DataDynamics.ActiveReports.Line
    Private WithEvents Label167 As DataDynamics.ActiveReports.Label
    Private WithEvents Label168 As DataDynamics.ActiveReports.Label
    Private WithEvents Label169 As DataDynamics.ActiveReports.Label
    Private WithEvents Label170 As DataDynamics.ActiveReports.Label
    Private WithEvents Label171 As DataDynamics.ActiveReports.Label
    Private WithEvents Label173 As DataDynamics.ActiveReports.Label
    Private WithEvents Line44 As DataDynamics.ActiveReports.Line
    Private WithEvents Line74 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Line45 As DataDynamics.ActiveReports.Line
    Private WithEvents Line75 As DataDynamics.ActiveReports.Line
    Private WithEvents Line76 As DataDynamics.ActiveReports.Line
    Private WithEvents Line79 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents KINKYU_FLAG As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Label174 As DataDynamics.ActiveReports.Label
    Private WithEvents MR_SEND_SAKI_OTHER As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents ANS_TAXI_MAISUU As DataDynamics.ActiveReports.TextBox
    Private WithEvents LblMaisuu As DataDynamics.ActiveReports.Label
    Private WithEvents ANS_TAXI_TESURYO As DataDynamics.ActiveReports.TextBox
    Private WithEvents FROM_DATE As DataDynamics.ActiveReports.TextBox
End Class
