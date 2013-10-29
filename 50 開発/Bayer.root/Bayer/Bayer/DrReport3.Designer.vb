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
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
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
        Me.REQ_MR_O_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.REQ_MR_F_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEX = New DataDynamics.ActiveReports.TextBox
        Me.MR_AGE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_MR_HOTEL_NOTE = New DataDynamics.ActiveReports.TextBox
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
        Me.Line34 = New DataDynamics.ActiveReports.Line
        Me.Line39 = New DataDynamics.ActiveReports.Line
        Me.Line40 = New DataDynamics.ActiveReports.Line
        Me.Line51 = New DataDynamics.ActiveReports.Line
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
        Me.Line55 = New DataDynamics.ActiveReports.Line
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
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.REQ_TAXI_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Shape2 = New DataDynamics.ActiveReports.Shape
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.TEHAI_TAXI = New DataDynamics.ActiveReports.TextBox
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line18 = New DataDynamics.ActiveReports.Line
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
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.REQ_MR_O_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_F_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_AGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_HOTEL_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.REQ_TAXI_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.Label3, Me.Label1, Me.PRINT_DATE, Me.Label2, Me.USER_NAME, Me.Label4})
        Me.PageHeader.Height = 0.9270834!
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
        Me.Label4.Text = "(3/3ページ)"
        Me.Label4.Top = 0.4409449!
        Me.Label4.Width = 0.7188979!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Label5, Me.KOUENKAI_NAME, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Label19, Me.Label21, Me.Label22, Me.Label23, Me.KOUENKAI_NO, Me.REQ_STATUS_TEHAI, Me.TIME_STAMP_BYL, Me.SANKASHA_ID, Me.DR_CD, Me.DR_NAME, Me.DR_KANA, Me.DR_SHISETSU_CD, Me.REQ_KOTSU_BIKO, Me.REQ_TAXI_DATE_1, Me.REQ_TAXI_FROM_1, Me.TAXI_YOTEIKINGAKU_1, Me.Line1, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Line14, Me.Line15, Me.Line16, Me.Line17, Me.Label20, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label39, Me.Label40, Me.Label41, Me.Label42, Me.Label43, Me.REQ_TAXI_DATE_2, Me.REQ_TAXI_FROM_2, Me.REQ_TAXI_DATE_3, Me.REQ_TAXI_FROM_3, Me.TAXI_YOTEIKINGAKU_3, Me.REQ_TAXI_DATE_4, Me.REQ_TAXI_FROM_4, Me.TAXI_YOTEIKINGAKU_4, Me.REQ_TAXI_DATE_5, Me.REQ_TAXI_FROM_5, Me.TAXI_YOTEIKINGAKU_5, Me.REQ_TAXI_NOTE, Me.REQ_MR_O_TEHAI, Me.REQ_MR_F_TEHAI, Me.MR_SEX, Me.MR_AGE, Me.REQ_MR_HOTEL_NOTE, Me.Line19, Me.Line20, Me.Line21, Me.Line22, Me.Line23, Me.Line24, Me.Line25, Me.Line26, Me.Line27, Me.Line28, Me.Line29, Me.Line34, Me.Line39, Me.Line40, Me.Line51, Me.Line52, Me.Label73, Me.Label74, Me.Label75, Me.Label76, Me.Label77, Me.Label78, Me.Label79, Me.Label80, Me.Label81, Me.Label82, Me.Label83, Me.Label84, Me.Label85, Me.Label86, Me.Label98, Me.Label99, Me.TAXI_YOTEIKINGAKU_2, Me.Line55, Me.REQ_TAXI_DATE_6, Me.REQ_TAXI_FROM_6, Me.TAXI_YOTEIKINGAKU_6, Me.REQ_TAXI_DATE_7, Me.REQ_TAXI_FROM_7, Me.TAXI_YOTEIKINGAKU_7, Me.REQ_TAXI_DATE_8, Me.REQ_TAXI_FROM_8, Me.TAXI_YOTEIKINGAKU_8, Me.REQ_TAXI_DATE_9, Me.REQ_TAXI_FROM_9, Me.TAXI_YOTEIKINGAKU_9, Me.REQ_TAXI_DATE_10, Me.REQ_TAXI_FROM_10, Me.TAXI_YOTEIKINGAKU_10, Me.Line2, Me.Line10, Me.Line11, Me.Line12, Me.TEHAI_TAXI, Me.Line13, Me.Line18})
        Me.Detail.Height = 8.8!
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
        Me.Label5.Top = 0.0!
        Me.Label5.Width = 0.8437006!
        '
        'KOUENKAI_NAME
        '
        Me.KOUENKAI_NAME.Height = 0.2!
        Me.KOUENKAI_NAME.Left = 0.8437006!
        Me.KOUENKAI_NAME.Name = "KOUENKAI_NAME"
        Me.KOUENKAI_NAME.Style = "font-weight: bold; white-space: nowrap"
        Me.KOUENKAI_NAME.Text = Nothing
        Me.KOUENKAI_NAME.Top = 0.0!
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
        Me.Label6.Top = 0.2!
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
        Me.Label7.Top = 0.4!
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
        Me.Label8.Top = 0.6000001!
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
        Me.Label9.Top = 0.8!
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
        Me.Label10.Top = 1.0!
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
        Me.Label11.Top = 1.2!
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
        Me.Label12.Top = 1.4!
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
        Me.Label13.Top = 1.6!
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
        Me.Label14.Top = 1.8!
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
        Me.Label19.Top = 2.8!
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
        Me.Label21.Top = 3.0!
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
        Me.Label22.Top = 3.2!
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
        Me.Label23.Top = 3.4!
        Me.Label23.Width = 1.771654!
        '
        'KOUENKAI_NO
        '
        Me.KOUENKAI_NO.Height = 0.2!
        Me.KOUENKAI_NO.Left = 1.771654!
        Me.KOUENKAI_NO.Name = "KOUENKAI_NO"
        Me.KOUENKAI_NO.Text = Nothing
        Me.KOUENKAI_NO.Top = 0.2!
        Me.KOUENKAI_NO.Width = 5.393702!
        '
        'REQ_STATUS_TEHAI
        '
        Me.REQ_STATUS_TEHAI.Height = 0.2!
        Me.REQ_STATUS_TEHAI.Left = 1.771654!
        Me.REQ_STATUS_TEHAI.Name = "REQ_STATUS_TEHAI"
        Me.REQ_STATUS_TEHAI.Text = Nothing
        Me.REQ_STATUS_TEHAI.Top = 0.4!
        Me.REQ_STATUS_TEHAI.Width = 5.393702!
        '
        'TIME_STAMP_BYL
        '
        Me.TIME_STAMP_BYL.Height = 0.2!
        Me.TIME_STAMP_BYL.Left = 1.771654!
        Me.TIME_STAMP_BYL.Name = "TIME_STAMP_BYL"
        Me.TIME_STAMP_BYL.Text = Nothing
        Me.TIME_STAMP_BYL.Top = 0.6000001!
        Me.TIME_STAMP_BYL.Width = 5.393702!
        '
        'SANKASHA_ID
        '
        Me.SANKASHA_ID.Height = 0.2!
        Me.SANKASHA_ID.Left = 1.771654!
        Me.SANKASHA_ID.Name = "SANKASHA_ID"
        Me.SANKASHA_ID.Text = Nothing
        Me.SANKASHA_ID.Top = 0.8!
        Me.SANKASHA_ID.Width = 5.393702!
        '
        'DR_CD
        '
        Me.DR_CD.Height = 0.2!
        Me.DR_CD.Left = 1.771654!
        Me.DR_CD.Name = "DR_CD"
        Me.DR_CD.Text = Nothing
        Me.DR_CD.Top = 1.0!
        Me.DR_CD.Width = 5.393702!
        '
        'DR_NAME
        '
        Me.DR_NAME.Height = 0.2!
        Me.DR_NAME.Left = 1.771654!
        Me.DR_NAME.Name = "DR_NAME"
        Me.DR_NAME.Text = Nothing
        Me.DR_NAME.Top = 1.2!
        Me.DR_NAME.Width = 5.393702!
        '
        'DR_KANA
        '
        Me.DR_KANA.Height = 0.2!
        Me.DR_KANA.Left = 1.771654!
        Me.DR_KANA.Name = "DR_KANA"
        Me.DR_KANA.Text = Nothing
        Me.DR_KANA.Top = 1.4!
        Me.DR_KANA.Width = 5.393702!
        '
        'DR_SHISETSU_CD
        '
        Me.DR_SHISETSU_CD.Height = 0.2!
        Me.DR_SHISETSU_CD.Left = 1.771654!
        Me.DR_SHISETSU_CD.Name = "DR_SHISETSU_CD"
        Me.DR_SHISETSU_CD.Text = Nothing
        Me.DR_SHISETSU_CD.Top = 1.6!
        Me.DR_SHISETSU_CD.Width = 5.393702!
        '
        'REQ_KOTSU_BIKO
        '
        Me.REQ_KOTSU_BIKO.Height = 1.0!
        Me.REQ_KOTSU_BIKO.Left = 1.771654!
        Me.REQ_KOTSU_BIKO.Name = "REQ_KOTSU_BIKO"
        Me.REQ_KOTSU_BIKO.Top = 1.8!
        Me.REQ_KOTSU_BIKO.Width = 5.393701!
        '
        'REQ_TAXI_DATE_1
        '
        Me.REQ_TAXI_DATE_1.Height = 0.2!
        Me.REQ_TAXI_DATE_1.Left = 1.771654!
        Me.REQ_TAXI_DATE_1.Name = "REQ_TAXI_DATE_1"
        Me.REQ_TAXI_DATE_1.Text = Nothing
        Me.REQ_TAXI_DATE_1.Top = 3.0!
        Me.REQ_TAXI_DATE_1.Width = 1.811024!
        '
        'REQ_TAXI_FROM_1
        '
        Me.REQ_TAXI_FROM_1.Height = 0.2!
        Me.REQ_TAXI_FROM_1.Left = 1.771654!
        Me.REQ_TAXI_FROM_1.Name = "REQ_TAXI_FROM_1"
        Me.REQ_TAXI_FROM_1.Text = Nothing
        Me.REQ_TAXI_FROM_1.Top = 3.2!
        Me.REQ_TAXI_FROM_1.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_1
        '
        Me.TAXI_YOTEIKINGAKU_1.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_1.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_1.Name = "TAXI_YOTEIKINGAKU_1"
        Me.TAXI_YOTEIKINGAKU_1.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_1.Top = 3.4!
        Me.TAXI_YOTEIKINGAKU_1.Width = 1.811024!
        '
        'Line1
        '
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.8!
        Me.Line1.Width = 7.165354!
        Me.Line1.X1 = 0.0!
        Me.Line1.X2 = 7.165354!
        Me.Line1.Y1 = 1.8!
        Me.Line1.Y2 = 1.8!
        '
        'Line3
        '
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.0!
        Me.Line3.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.4000001!
        Me.Line3.Width = 7.165354!
        Me.Line3.X1 = 0.0!
        Me.Line3.X2 = 7.165354!
        Me.Line3.Y1 = 0.4000001!
        Me.Line3.Y2 = 0.4000001!
        '
        'Line4
        '
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 0.0!
        Me.Line4.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.6000001!
        Me.Line4.Width = 7.165354!
        Me.Line4.X1 = 0.0!
        Me.Line4.X2 = 7.165354!
        Me.Line4.Y1 = 0.6000001!
        Me.Line4.Y2 = 0.6000001!
        '
        'Line5
        '
        Me.Line5.Height = 0.0!
        Me.Line5.Left = 0.0!
        Me.Line5.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.8!
        Me.Line5.Width = 7.165354!
        Me.Line5.X1 = 0.0!
        Me.Line5.X2 = 7.165354!
        Me.Line5.Y1 = 0.8!
        Me.Line5.Y2 = 0.8!
        '
        'Line6
        '
        Me.Line6.Height = 0.0!
        Me.Line6.Left = 0.0!
        Me.Line6.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.0!
        Me.Line6.Width = 7.165354!
        Me.Line6.X1 = 0.0!
        Me.Line6.X2 = 7.165354!
        Me.Line6.Y1 = 1.0!
        Me.Line6.Y2 = 1.0!
        '
        'Line7
        '
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 0.0!
        Me.Line7.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.2!
        Me.Line7.Width = 7.165354!
        Me.Line7.X1 = 0.0!
        Me.Line7.X2 = 7.165354!
        Me.Line7.Y1 = 1.2!
        Me.Line7.Y2 = 1.2!
        '
        'Line8
        '
        Me.Line8.Height = 0.0!
        Me.Line8.Left = 0.0!
        Me.Line8.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.4!
        Me.Line8.Width = 7.165354!
        Me.Line8.X1 = 0.0!
        Me.Line8.X2 = 7.165354!
        Me.Line8.Y1 = 1.4!
        Me.Line8.Y2 = 1.4!
        '
        'Line9
        '
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.0!
        Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.6!
        Me.Line9.Width = 7.165354!
        Me.Line9.X1 = 0.0!
        Me.Line9.X2 = 7.165354!
        Me.Line9.Y1 = 1.6!
        Me.Line9.Y2 = 1.6!
        '
        'Line14
        '
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 0.0!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 2.8!
        Me.Line14.Width = 7.165354!
        Me.Line14.X1 = 0.0!
        Me.Line14.X2 = 7.165354!
        Me.Line14.Y1 = 2.8!
        Me.Line14.Y2 = 2.8!
        '
        'Line15
        '
        Me.Line15.Height = 0.0!
        Me.Line15.Left = 0.0!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 3.0!
        Me.Line15.Width = 7.165354!
        Me.Line15.X1 = 0.0!
        Me.Line15.X2 = 7.165354!
        Me.Line15.Y1 = 3.0!
        Me.Line15.Y2 = 3.0!
        '
        'Line16
        '
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 0.0!
        Me.Line16.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 3.2!
        Me.Line16.Width = 7.165354!
        Me.Line16.X1 = 0.0!
        Me.Line16.X2 = 7.165354!
        Me.Line16.Y1 = 3.2!
        Me.Line16.Y2 = 3.2!
        '
        'Line17
        '
        Me.Line17.Height = 0.0!
        Me.Line17.Left = 0.0!
        Me.Line17.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 3.4!
        Me.Line17.Width = 7.165354!
        Me.Line17.X1 = 0.0!
        Me.Line17.X2 = 7.165354!
        Me.Line17.Y1 = 3.4!
        Me.Line17.Y2 = 3.4!
        '
        'Label20
        '
        Me.Label20.Height = 0.2!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.0!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "white-space: nowrap"
        Me.Label20.Text = "行程2：利用日(依頼)"
        Me.Label20.Top = 3.6!
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
        Me.Label24.Top = 3.8!
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
        Me.Label25.Top = 4.2!
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
        Me.Label26.Top = 4.4!
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
        Me.Label27.Top = 4.6!
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
        Me.Label28.Top = 4.800001!
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
        Me.Label29.Top = 5.000001!
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
        Me.Label30.Top = 5.2!
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
        Me.Label31.Top = 5.4!
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
        Me.Label32.Top = 5.600001!
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
        Me.Label33.Top = 5.800001!
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
        Me.Label34.Top = 6.000001!
        Me.Label34.Width = 1.771653!
        '
        'Label39
        '
        Me.Label39.Height = 0.2!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 0.0!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "white-space: nowrap"
        Me.Label39.Text = "社員用往路臨席希望 (依頼)"
        Me.Label39.Top = 7.000002!
        Me.Label39.Width = 1.771653!
        '
        'Label40
        '
        Me.Label40.Height = 0.2!
        Me.Label40.HyperLink = Nothing
        Me.Label40.Left = 0.0!
        Me.Label40.Name = "Label40"
        Me.Label40.Style = "white-space: nowrap"
        Me.Label40.Text = "社員用復路臨席希望 (依頼)"
        Me.Label40.Top = 7.200001!
        Me.Label40.Width = 1.771653!
        '
        'Label41
        '
        Me.Label41.Height = 0.2!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0.0!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "white-space: nowrap"
        Me.Label41.Text = "MR性別 (航空券の場合)"
        Me.Label41.Top = 7.4!
        Me.Label41.Width = 1.771653!
        '
        'Label42
        '
        Me.Label42.Height = 0.2!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 0.0!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "white-space: nowrap"
        Me.Label42.Text = "MR年齢 (航空券の場合)"
        Me.Label42.Top = 7.6!
        Me.Label42.Width = 1.771653!
        '
        'Label43
        '
        Me.Label43.Height = 0.2!
        Me.Label43.HyperLink = Nothing
        Me.Label43.Left = 0.0!
        Me.Label43.Name = "Label43"
        Me.Label43.Style = "white-space: nowrap"
        Me.Label43.Text = "社員用交通・宿泊備考"
        Me.Label43.Top = 7.800001!
        Me.Label43.Width = 1.771653!
        '
        'REQ_TAXI_DATE_2
        '
        Me.REQ_TAXI_DATE_2.Height = 0.2!
        Me.REQ_TAXI_DATE_2.Left = 1.771654!
        Me.REQ_TAXI_DATE_2.Name = "REQ_TAXI_DATE_2"
        Me.REQ_TAXI_DATE_2.Text = Nothing
        Me.REQ_TAXI_DATE_2.Top = 3.6!
        Me.REQ_TAXI_DATE_2.Width = 1.811024!
        '
        'REQ_TAXI_FROM_2
        '
        Me.REQ_TAXI_FROM_2.Height = 0.2!
        Me.REQ_TAXI_FROM_2.Left = 1.771654!
        Me.REQ_TAXI_FROM_2.Name = "REQ_TAXI_FROM_2"
        Me.REQ_TAXI_FROM_2.Text = Nothing
        Me.REQ_TAXI_FROM_2.Top = 3.8!
        Me.REQ_TAXI_FROM_2.Width = 1.811024!
        '
        'REQ_TAXI_DATE_3
        '
        Me.REQ_TAXI_DATE_3.Height = 0.2!
        Me.REQ_TAXI_DATE_3.Left = 1.771654!
        Me.REQ_TAXI_DATE_3.Name = "REQ_TAXI_DATE_3"
        Me.REQ_TAXI_DATE_3.Text = Nothing
        Me.REQ_TAXI_DATE_3.Top = 4.2!
        Me.REQ_TAXI_DATE_3.Width = 1.811024!
        '
        'REQ_TAXI_FROM_3
        '
        Me.REQ_TAXI_FROM_3.Height = 0.2!
        Me.REQ_TAXI_FROM_3.Left = 1.771654!
        Me.REQ_TAXI_FROM_3.Name = "REQ_TAXI_FROM_3"
        Me.REQ_TAXI_FROM_3.Text = Nothing
        Me.REQ_TAXI_FROM_3.Top = 4.4!
        Me.REQ_TAXI_FROM_3.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_3
        '
        Me.TAXI_YOTEIKINGAKU_3.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_3.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_3.Name = "TAXI_YOTEIKINGAKU_3"
        Me.TAXI_YOTEIKINGAKU_3.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_3.Top = 4.6!
        Me.TAXI_YOTEIKINGAKU_3.Width = 1.811024!
        '
        'REQ_TAXI_DATE_4
        '
        Me.REQ_TAXI_DATE_4.Height = 0.2!
        Me.REQ_TAXI_DATE_4.Left = 1.771654!
        Me.REQ_TAXI_DATE_4.Name = "REQ_TAXI_DATE_4"
        Me.REQ_TAXI_DATE_4.Text = Nothing
        Me.REQ_TAXI_DATE_4.Top = 4.800001!
        Me.REQ_TAXI_DATE_4.Width = 1.811024!
        '
        'REQ_TAXI_FROM_4
        '
        Me.REQ_TAXI_FROM_4.Height = 0.2!
        Me.REQ_TAXI_FROM_4.Left = 1.771654!
        Me.REQ_TAXI_FROM_4.Name = "REQ_TAXI_FROM_4"
        Me.REQ_TAXI_FROM_4.Text = Nothing
        Me.REQ_TAXI_FROM_4.Top = 5.000001!
        Me.REQ_TAXI_FROM_4.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_4
        '
        Me.TAXI_YOTEIKINGAKU_4.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_4.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_4.Name = "TAXI_YOTEIKINGAKU_4"
        Me.TAXI_YOTEIKINGAKU_4.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_4.Top = 5.2!
        Me.TAXI_YOTEIKINGAKU_4.Width = 1.811024!
        '
        'REQ_TAXI_DATE_5
        '
        Me.REQ_TAXI_DATE_5.Height = 0.2!
        Me.REQ_TAXI_DATE_5.Left = 1.771654!
        Me.REQ_TAXI_DATE_5.Name = "REQ_TAXI_DATE_5"
        Me.REQ_TAXI_DATE_5.Text = Nothing
        Me.REQ_TAXI_DATE_5.Top = 5.4!
        Me.REQ_TAXI_DATE_5.Width = 1.811024!
        '
        'REQ_TAXI_FROM_5
        '
        Me.REQ_TAXI_FROM_5.Height = 0.2!
        Me.REQ_TAXI_FROM_5.Left = 1.771654!
        Me.REQ_TAXI_FROM_5.Name = "REQ_TAXI_FROM_5"
        Me.REQ_TAXI_FROM_5.Text = Nothing
        Me.REQ_TAXI_FROM_5.Top = 5.6!
        Me.REQ_TAXI_FROM_5.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_5
        '
        Me.TAXI_YOTEIKINGAKU_5.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_5.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_5.Name = "TAXI_YOTEIKINGAKU_5"
        Me.TAXI_YOTEIKINGAKU_5.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_5.Top = 5.800001!
        Me.TAXI_YOTEIKINGAKU_5.Width = 1.811024!
        '
        'REQ_MR_O_TEHAI
        '
        Me.REQ_MR_O_TEHAI.Height = 0.2!
        Me.REQ_MR_O_TEHAI.Left = 1.771654!
        Me.REQ_MR_O_TEHAI.Name = "REQ_MR_O_TEHAI"
        Me.REQ_MR_O_TEHAI.Text = Nothing
        Me.REQ_MR_O_TEHAI.Top = 7.000001!
        Me.REQ_MR_O_TEHAI.Width = 5.393701!
        '
        'REQ_MR_F_TEHAI
        '
        Me.REQ_MR_F_TEHAI.Height = 0.2!
        Me.REQ_MR_F_TEHAI.Left = 1.771654!
        Me.REQ_MR_F_TEHAI.Name = "REQ_MR_F_TEHAI"
        Me.REQ_MR_F_TEHAI.Text = Nothing
        Me.REQ_MR_F_TEHAI.Top = 7.200001!
        Me.REQ_MR_F_TEHAI.Width = 5.393701!
        '
        'MR_SEX
        '
        Me.MR_SEX.Height = 0.2!
        Me.MR_SEX.Left = 1.771654!
        Me.MR_SEX.Name = "MR_SEX"
        Me.MR_SEX.Text = Nothing
        Me.MR_SEX.Top = 7.4!
        Me.MR_SEX.Width = 5.393701!
        '
        'MR_AGE
        '
        Me.MR_AGE.Height = 0.2!
        Me.MR_AGE.Left = 1.771654!
        Me.MR_AGE.Name = "MR_AGE"
        Me.MR_AGE.Text = Nothing
        Me.MR_AGE.Top = 7.6!
        Me.MR_AGE.Width = 5.393701!
        '
        'REQ_MR_HOTEL_NOTE
        '
        Me.REQ_MR_HOTEL_NOTE.Height = 1.0!
        Me.REQ_MR_HOTEL_NOTE.Left = 1.771654!
        Me.REQ_MR_HOTEL_NOTE.Name = "REQ_MR_HOTEL_NOTE"
        Me.REQ_MR_HOTEL_NOTE.Text = Nothing
        Me.REQ_MR_HOTEL_NOTE.Top = 7.800001!
        Me.REQ_MR_HOTEL_NOTE.Width = 5.393701!
        '
        'Line19
        '
        Me.Line19.Height = 0.0!
        Me.Line19.Left = 0.0!
        Me.Line19.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 3.8!
        Me.Line19.Width = 7.165354!
        Me.Line19.X1 = 0.0!
        Me.Line19.X2 = 7.165354!
        Me.Line19.Y1 = 3.8!
        Me.Line19.Y2 = 3.8!
        '
        'Line20
        '
        Me.Line20.Height = 0.0!
        Me.Line20.Left = 0.0!
        Me.Line20.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 4.0!
        Me.Line20.Width = 7.165354!
        Me.Line20.X1 = 0.0!
        Me.Line20.X2 = 7.165354!
        Me.Line20.Y1 = 4.0!
        Me.Line20.Y2 = 4.0!
        '
        'Line21
        '
        Me.Line21.Height = 0.0!
        Me.Line21.Left = 0.0!
        Me.Line21.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 4.4!
        Me.Line21.Width = 7.165354!
        Me.Line21.X1 = 0.0!
        Me.Line21.X2 = 7.165354!
        Me.Line21.Y1 = 4.4!
        Me.Line21.Y2 = 4.4!
        '
        'Line22
        '
        Me.Line22.Height = 0.0!
        Me.Line22.Left = 0.0!
        Me.Line22.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line22.LineWeight = 1.0!
        Me.Line22.Name = "Line22"
        Me.Line22.Top = 4.6!
        Me.Line22.Width = 7.165354!
        Me.Line22.X1 = 0.0!
        Me.Line22.X2 = 7.165354!
        Me.Line22.Y1 = 4.6!
        Me.Line22.Y2 = 4.6!
        '
        'Line23
        '
        Me.Line23.Height = 0.0!
        Me.Line23.Left = 0.0!
        Me.Line23.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 4.800001!
        Me.Line23.Width = 7.165354!
        Me.Line23.X1 = 0.0!
        Me.Line23.X2 = 7.165354!
        Me.Line23.Y1 = 4.800001!
        Me.Line23.Y2 = 4.800001!
        '
        'Line24
        '
        Me.Line24.Height = 0.0!
        Me.Line24.Left = 0.0!
        Me.Line24.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 5.000001!
        Me.Line24.Width = 7.165354!
        Me.Line24.X1 = 0.0!
        Me.Line24.X2 = 7.165354!
        Me.Line24.Y1 = 5.000001!
        Me.Line24.Y2 = 5.000001!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.0!
        Me.Line25.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 5.2!
        Me.Line25.Width = 7.165354!
        Me.Line25.X1 = 0.0!
        Me.Line25.X2 = 7.165354!
        Me.Line25.Y1 = 5.2!
        Me.Line25.Y2 = 5.2!
        '
        'Line26
        '
        Me.Line26.Height = 0.0!
        Me.Line26.Left = 0.0!
        Me.Line26.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 5.4!
        Me.Line26.Width = 7.165354!
        Me.Line26.X1 = 0.0!
        Me.Line26.X2 = 7.165354!
        Me.Line26.Y1 = 5.4!
        Me.Line26.Y2 = 5.4!
        '
        'Line27
        '
        Me.Line27.Height = 0.0!
        Me.Line27.Left = 0.0!
        Me.Line27.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line27.LineWeight = 1.0!
        Me.Line27.Name = "Line27"
        Me.Line27.Top = 5.6!
        Me.Line27.Width = 7.165354!
        Me.Line27.X1 = 0.0!
        Me.Line27.X2 = 7.165354!
        Me.Line27.Y1 = 5.6!
        Me.Line27.Y2 = 5.6!
        '
        'Line28
        '
        Me.Line28.Height = 0.0!
        Me.Line28.Left = 0.0!
        Me.Line28.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line28.LineWeight = 1.0!
        Me.Line28.Name = "Line28"
        Me.Line28.Top = 5.8!
        Me.Line28.Width = 7.165354!
        Me.Line28.X1 = 0.0!
        Me.Line28.X2 = 7.165354!
        Me.Line28.Y1 = 5.8!
        Me.Line28.Y2 = 5.8!
        '
        'Line29
        '
        Me.Line29.Height = 0.0!
        Me.Line29.Left = 0.0!
        Me.Line29.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line29.LineWeight = 1.0!
        Me.Line29.Name = "Line29"
        Me.Line29.Top = 6.0!
        Me.Line29.Width = 7.165354!
        Me.Line29.X1 = 0.0!
        Me.Line29.X2 = 7.165354!
        Me.Line29.Y1 = 6.0!
        Me.Line29.Y2 = 6.0!
        '
        'Line34
        '
        Me.Line34.Height = 0.0!
        Me.Line34.Left = 0.0!
        Me.Line34.LineWeight = 1.0!
        Me.Line34.Name = "Line34"
        Me.Line34.Top = 7.0!
        Me.Line34.Width = 7.165354!
        Me.Line34.X1 = 0.0!
        Me.Line34.X2 = 7.165354!
        Me.Line34.Y1 = 7.0!
        Me.Line34.Y2 = 7.0!
        '
        'Line39
        '
        Me.Line39.Height = 0.0!
        Me.Line39.Left = 0.0!
        Me.Line39.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line39.LineWeight = 1.0!
        Me.Line39.Name = "Line39"
        Me.Line39.Top = 3.6!
        Me.Line39.Width = 7.165354!
        Me.Line39.X1 = 0.0!
        Me.Line39.X2 = 7.165354!
        Me.Line39.Y1 = 3.6!
        Me.Line39.Y2 = 3.6!
        '
        'Line40
        '
        Me.Line40.Height = 8.400001!
        Me.Line40.Left = 1.771654!
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 0.4!
        Me.Line40.Width = 0.0000003576279!
        Me.Line40.X1 = 1.771654!
        Me.Line40.X2 = 1.771654!
        Me.Line40.Y1 = 0.4!
        Me.Line40.Y2 = 8.8!
        '
        'Line51
        '
        Me.Line51.Height = 3.0!
        Me.Line51.Left = 3.582677!
        Me.Line51.LineWeight = 1.0!
        Me.Line51.Name = "Line51"
        Me.Line51.Top = 3.0!
        Me.Line51.Width = 0.0!
        Me.Line51.X1 = 3.582677!
        Me.Line51.X2 = 3.582677!
        Me.Line51.Y1 = 3.0!
        Me.Line51.Y2 = 6.0!
        '
        'Line52
        '
        Me.Line52.Height = 3.0!
        Me.Line52.Left = 5.354331!
        Me.Line52.LineWeight = 1.0!
        Me.Line52.Name = "Line52"
        Me.Line52.Top = 3.0!
        Me.Line52.Width = 0.0!
        Me.Line52.X1 = 5.354331!
        Me.Line52.X2 = 5.354331!
        Me.Line52.Y1 = 3.0!
        Me.Line52.Y2 = 6.0!
        '
        'Label73
        '
        Me.Label73.Height = 0.2!
        Me.Label73.HyperLink = Nothing
        Me.Label73.Left = 3.582677!
        Me.Label73.Name = "Label73"
        Me.Label73.Style = "white-space: nowrap"
        Me.Label73.Text = "行程6：利用日(依頼)"
        Me.Label73.Top = 3.0!
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
        Me.Label74.Top = 3.2!
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
        Me.Label75.Top = 3.4!
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
        Me.Label76.Top = 3.6!
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
        Me.Label77.Top = 3.8!
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
        Me.Label78.Top = 4.200001!
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
        Me.Label79.Top = 4.400001!
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
        Me.Label80.Top = 4.6!
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
        Me.Label81.Top = 4.800001!
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
        Me.Label82.Top = 5.0!
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
        Me.Label83.Top = 5.200001!
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
        Me.Label84.Top = 5.400001!
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
        Me.Label85.Top = 5.600001!
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
        Me.Label86.Top = 5.800001!
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
        Me.Label98.Top = 4.0!
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
        Me.Label99.Top = 4.0!
        Me.Label99.Width = 1.771654!
        '
        'TAXI_YOTEIKINGAKU_2
        '
        Me.TAXI_YOTEIKINGAKU_2.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_2.Left = 1.771654!
        Me.TAXI_YOTEIKINGAKU_2.Name = "TAXI_YOTEIKINGAKU_2"
        Me.TAXI_YOTEIKINGAKU_2.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_2.Top = 4.0!
        Me.TAXI_YOTEIKINGAKU_2.Width = 1.811024!
        '
        'Line55
        '
        Me.Line55.Height = 0.0!
        Me.Line55.Left = 0.0!
        Me.Line55.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line55.LineWeight = 1.0!
        Me.Line55.Name = "Line55"
        Me.Line55.Top = 4.2!
        Me.Line55.Width = 7.165354!
        Me.Line55.X1 = 0.0!
        Me.Line55.X2 = 7.165354!
        Me.Line55.Y1 = 4.2!
        Me.Line55.Y2 = 4.2!
        '
        'REQ_TAXI_DATE_6
        '
        Me.REQ_TAXI_DATE_6.Height = 0.2!
        Me.REQ_TAXI_DATE_6.Left = 5.354331!
        Me.REQ_TAXI_DATE_6.Name = "REQ_TAXI_DATE_6"
        Me.REQ_TAXI_DATE_6.Text = Nothing
        Me.REQ_TAXI_DATE_6.Top = 3.0!
        Me.REQ_TAXI_DATE_6.Width = 1.811024!
        '
        'REQ_TAXI_FROM_6
        '
        Me.REQ_TAXI_FROM_6.Height = 0.2!
        Me.REQ_TAXI_FROM_6.Left = 5.354331!
        Me.REQ_TAXI_FROM_6.Name = "REQ_TAXI_FROM_6"
        Me.REQ_TAXI_FROM_6.Text = Nothing
        Me.REQ_TAXI_FROM_6.Top = 3.2!
        Me.REQ_TAXI_FROM_6.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_6
        '
        Me.TAXI_YOTEIKINGAKU_6.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_6.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_6.Name = "TAXI_YOTEIKINGAKU_6"
        Me.TAXI_YOTEIKINGAKU_6.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_6.Top = 3.4!
        Me.TAXI_YOTEIKINGAKU_6.Width = 1.811024!
        '
        'REQ_TAXI_DATE_7
        '
        Me.REQ_TAXI_DATE_7.Height = 0.2!
        Me.REQ_TAXI_DATE_7.Left = 5.354331!
        Me.REQ_TAXI_DATE_7.Name = "REQ_TAXI_DATE_7"
        Me.REQ_TAXI_DATE_7.Text = Nothing
        Me.REQ_TAXI_DATE_7.Top = 3.6!
        Me.REQ_TAXI_DATE_7.Width = 1.811024!
        '
        'REQ_TAXI_FROM_7
        '
        Me.REQ_TAXI_FROM_7.Height = 0.2!
        Me.REQ_TAXI_FROM_7.Left = 5.354331!
        Me.REQ_TAXI_FROM_7.Name = "REQ_TAXI_FROM_7"
        Me.REQ_TAXI_FROM_7.Text = Nothing
        Me.REQ_TAXI_FROM_7.Top = 3.8!
        Me.REQ_TAXI_FROM_7.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_7
        '
        Me.TAXI_YOTEIKINGAKU_7.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_7.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_7.Name = "TAXI_YOTEIKINGAKU_7"
        Me.TAXI_YOTEIKINGAKU_7.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_7.Top = 4.0!
        Me.TAXI_YOTEIKINGAKU_7.Width = 1.811024!
        '
        'REQ_TAXI_DATE_8
        '
        Me.REQ_TAXI_DATE_8.Height = 0.2!
        Me.REQ_TAXI_DATE_8.Left = 5.354331!
        Me.REQ_TAXI_DATE_8.Name = "REQ_TAXI_DATE_8"
        Me.REQ_TAXI_DATE_8.Text = Nothing
        Me.REQ_TAXI_DATE_8.Top = 4.2!
        Me.REQ_TAXI_DATE_8.Width = 1.811024!
        '
        'REQ_TAXI_FROM_8
        '
        Me.REQ_TAXI_FROM_8.Height = 0.2!
        Me.REQ_TAXI_FROM_8.Left = 5.354331!
        Me.REQ_TAXI_FROM_8.Name = "REQ_TAXI_FROM_8"
        Me.REQ_TAXI_FROM_8.Text = Nothing
        Me.REQ_TAXI_FROM_8.Top = 4.4!
        Me.REQ_TAXI_FROM_8.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_8
        '
        Me.TAXI_YOTEIKINGAKU_8.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_8.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_8.Name = "TAXI_YOTEIKINGAKU_8"
        Me.TAXI_YOTEIKINGAKU_8.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_8.Top = 4.6!
        Me.TAXI_YOTEIKINGAKU_8.Width = 1.811024!
        '
        'REQ_TAXI_DATE_9
        '
        Me.REQ_TAXI_DATE_9.Height = 0.2!
        Me.REQ_TAXI_DATE_9.Left = 5.354331!
        Me.REQ_TAXI_DATE_9.Name = "REQ_TAXI_DATE_9"
        Me.REQ_TAXI_DATE_9.Text = Nothing
        Me.REQ_TAXI_DATE_9.Top = 4.8!
        Me.REQ_TAXI_DATE_9.Width = 1.811024!
        '
        'REQ_TAXI_FROM_9
        '
        Me.REQ_TAXI_FROM_9.Height = 0.2!
        Me.REQ_TAXI_FROM_9.Left = 5.354331!
        Me.REQ_TAXI_FROM_9.Name = "REQ_TAXI_FROM_9"
        Me.REQ_TAXI_FROM_9.Text = Nothing
        Me.REQ_TAXI_FROM_9.Top = 5.0!
        Me.REQ_TAXI_FROM_9.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_9
        '
        Me.TAXI_YOTEIKINGAKU_9.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_9.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_9.Name = "TAXI_YOTEIKINGAKU_9"
        Me.TAXI_YOTEIKINGAKU_9.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_9.Top = 5.2!
        Me.TAXI_YOTEIKINGAKU_9.Width = 1.811024!
        '
        'REQ_TAXI_DATE_10
        '
        Me.REQ_TAXI_DATE_10.Height = 0.2!
        Me.REQ_TAXI_DATE_10.Left = 5.354331!
        Me.REQ_TAXI_DATE_10.Name = "REQ_TAXI_DATE_10"
        Me.REQ_TAXI_DATE_10.Text = Nothing
        Me.REQ_TAXI_DATE_10.Top = 5.400001!
        Me.REQ_TAXI_DATE_10.Width = 1.811024!
        '
        'REQ_TAXI_FROM_10
        '
        Me.REQ_TAXI_FROM_10.Height = 0.2!
        Me.REQ_TAXI_FROM_10.Left = 5.354331!
        Me.REQ_TAXI_FROM_10.Name = "REQ_TAXI_FROM_10"
        Me.REQ_TAXI_FROM_10.Text = Nothing
        Me.REQ_TAXI_FROM_10.Top = 5.6!
        Me.REQ_TAXI_FROM_10.Width = 1.811024!
        '
        'TAXI_YOTEIKINGAKU_10
        '
        Me.TAXI_YOTEIKINGAKU_10.Height = 0.2!
        Me.TAXI_YOTEIKINGAKU_10.Left = 5.354331!
        Me.TAXI_YOTEIKINGAKU_10.Name = "TAXI_YOTEIKINGAKU_10"
        Me.TAXI_YOTEIKINGAKU_10.Text = Nothing
        Me.TAXI_YOTEIKINGAKU_10.Top = 5.8!
        Me.TAXI_YOTEIKINGAKU_10.Width = 1.811024!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'REQ_TAXI_NOTE
        '
        Me.REQ_TAXI_NOTE.Height = 1.0!
        Me.REQ_TAXI_NOTE.Left = 1.771654!
        Me.REQ_TAXI_NOTE.Name = "REQ_TAXI_NOTE"
        Me.REQ_TAXI_NOTE.Text = Nothing
        Me.REQ_TAXI_NOTE.Top = 6.0!
        Me.REQ_TAXI_NOTE.Width = 5.393701!
        '
        'Shape2
        '
        Me.Shape2.Height = 8.6!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 10.0!
        Me.Shape2.Top = 0.2!
        Me.Shape2.Width = 7.165355!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 7.2!
        Me.Line2.Width = 7.165354!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.165354!
        Me.Line2.Y1 = 7.2!
        Me.Line2.Y2 = 7.2!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0!
        Me.Line10.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 7.4!
        Me.Line10.Width = 7.165354!
        Me.Line10.X1 = 0.0!
        Me.Line10.X2 = 7.165354!
        Me.Line10.Y1 = 7.4!
        Me.Line10.Y2 = 7.4!
        '
        'Line11
        '
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 0.0!
        Me.Line11.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 7.6!
        Me.Line11.Width = 7.165354!
        Me.Line11.X1 = 0.0!
        Me.Line11.X2 = 7.165354!
        Me.Line11.Y1 = 7.6!
        Me.Line11.Y2 = 7.6!
        '
        'Line12
        '
        Me.Line12.Height = 0.0!
        Me.Line12.Left = 0.0!
        Me.Line12.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 7.8!
        Me.Line12.Width = 7.165354!
        Me.Line12.X1 = 0.0!
        Me.Line12.X2 = 7.165354!
        Me.Line12.Y1 = 7.8!
        Me.Line12.Y2 = 7.8!
        '
        'TEHAI_TAXI
        '
        Me.TEHAI_TAXI.Height = 0.2!
        Me.TEHAI_TAXI.Left = 1.771654!
        Me.TEHAI_TAXI.Name = "TEHAI_TAXI"
        Me.TEHAI_TAXI.Text = Nothing
        Me.TEHAI_TAXI.Top = 2.8!
        Me.TEHAI_TAXI.Width = 5.393701!
        '
        'Line13
        '
        Me.Line13.Height = 3.0!
        Me.Line13.Left = 3.582677!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 3.0!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 3.582677!
        Me.Line13.X2 = 3.582677!
        Me.Line13.Y1 = 3.0!
        Me.Line13.Y2 = 6.0!
        '
        'Line18
        '
        Me.Line18.Height = 3.000001!
        Me.Line18.Left = 5.354331!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 3.0!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 5.354331!
        Me.Line18.X2 = 5.354331!
        Me.Line18.Y1 = 3.0!
        Me.Line18.Y2 = 6.000001!
        '
        'DrReport3
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.165356!
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
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.REQ_MR_O_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_F_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_AGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_HOTEL_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.REQ_TAXI_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEHAI_TAXI, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
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
    Private WithEvents REQ_MR_O_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_F_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEX As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_AGE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_HOTEL_NOTE As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents Line34 As DataDynamics.ActiveReports.Line
    Private WithEvents Line39 As DataDynamics.ActiveReports.Line
    Private WithEvents Line40 As DataDynamics.ActiveReports.Line
    Private WithEvents Line51 As DataDynamics.ActiveReports.Line
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
    Private WithEvents Line55 As DataDynamics.ActiveReports.Line
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
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents TEHAI_TAXI As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
    Private WithEvents Line18 As DataDynamics.ActiveReports.Line
End Class
