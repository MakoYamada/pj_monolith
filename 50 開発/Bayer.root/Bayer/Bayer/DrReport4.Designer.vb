<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DrReport4
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DrReport4))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.PRINT_DATE = New DataDynamics.ActiveReports.TextBox
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.USER_NAME = New DataDynamics.ActiveReports.TextBox
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Detail = New DataDynamics.ActiveReports.Detail
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
        Me.KOUENKAI_NO = New DataDynamics.ActiveReports.TextBox
        Me.REQ_STATUS_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.TIME_STAMP_BYL = New DataDynamics.ActiveReports.TextBox
        Me.SANKASHA_ID = New DataDynamics.ActiveReports.TextBox
        Me.DR_CD = New DataDynamics.ActiveReports.TextBox
        Me.DR_NAME = New DataDynamics.ActiveReports.TextBox
        Me.DR_KANA = New DataDynamics.ActiveReports.TextBox
        Me.DR_SHISETSU_CD = New DataDynamics.ActiveReports.TextBox
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.Label40 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.Label43 = New DataDynamics.ActiveReports.Label
        Me.REQ_MR_O_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.REQ_MR_F_TEHAI = New DataDynamics.ActiveReports.TextBox
        Me.MR_SEX = New DataDynamics.ActiveReports.TextBox
        Me.MR_AGE = New DataDynamics.ActiveReports.TextBox
        Me.REQ_MR_HOTEL_NOTE = New DataDynamics.ActiveReports.TextBox
        Me.Line40 = New DataDynamics.ActiveReports.Line
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line30 = New DataDynamics.ActiveReports.Line
        Me.Line31 = New DataDynamics.ActiveReports.Line
        Me.Line32 = New DataDynamics.ActiveReports.Line
        Me.Line33 = New DataDynamics.ActiveReports.Line
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter
        Me.Line13 = New DataDynamics.ActiveReports.Line
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
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_KANA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DR_SHISETSU_CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_O_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_F_TEHAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_SEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MR_AGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REQ_MR_HOTEL_NOTE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Text = "(4/4ページ)"
        Me.Label4.Top = 0.4409449!
        Me.Label4.Width = 0.7188979!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape2, Me.Label5, Me.KOUENKAI_NAME, Me.Label6, Me.Label7, Me.Label8, Me.Label9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.KOUENKAI_NO, Me.REQ_STATUS_TEHAI, Me.TIME_STAMP_BYL, Me.SANKASHA_ID, Me.DR_CD, Me.DR_NAME, Me.DR_KANA, Me.DR_SHISETSU_CD, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line8, Me.Line9, Me.Label39, Me.Label40, Me.Label41, Me.Label42, Me.Label43, Me.REQ_MR_O_TEHAI, Me.REQ_MR_F_TEHAI, Me.MR_SEX, Me.MR_AGE, Me.REQ_MR_HOTEL_NOTE, Me.Line40, Me.Line2, Me.Line10, Me.Line11, Me.Line12, Me.Shape1, Me.Label3, Me.Label1, Me.PRINT_DATE, Me.Label2, Me.USER_NAME, Me.Label4, Me.Line23, Me.Line30, Me.Line31, Me.Line32, Me.Line33, Me.Line1, Me.Line13})
        Me.Detail.Height = 4.623084!
        Me.Detail.Name = "Detail"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Shape2.Height = 3.4!
        Me.Shape2.Left = 0.0!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = 9.999999!
        Me.Shape2.Top = 1.189764!
        Me.Shape2.Width = 1.771654!
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
        'Label39
        '
        Me.Label39.Height = 0.2!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 0.0!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "white-space: nowrap"
        Me.Label39.Text = "社員用往路臨席希望 (依頼)"
        Me.Label39.Top = 2.789773!
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
        Me.Label40.Top = 2.989773!
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
        Me.Label41.Top = 3.189764!
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
        Me.Label42.Top = 3.389774!
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
        Me.Label43.Top = 3.589774!
        Me.Label43.Width = 1.771653!
        '
        'REQ_MR_O_TEHAI
        '
        Me.REQ_MR_O_TEHAI.DataField = "REQ_MR_O_TEHAI"
        Me.REQ_MR_O_TEHAI.Height = 0.2!
        Me.REQ_MR_O_TEHAI.Left = 1.771654!
        Me.REQ_MR_O_TEHAI.Name = "REQ_MR_O_TEHAI"
        Me.REQ_MR_O_TEHAI.Text = Nothing
        Me.REQ_MR_O_TEHAI.Top = 2.789764!
        Me.REQ_MR_O_TEHAI.Width = 5.393701!
        '
        'REQ_MR_F_TEHAI
        '
        Me.REQ_MR_F_TEHAI.DataField = "REQ_MR_F_TEHAI"
        Me.REQ_MR_F_TEHAI.Height = 0.2!
        Me.REQ_MR_F_TEHAI.Left = 1.771654!
        Me.REQ_MR_F_TEHAI.Name = "REQ_MR_F_TEHAI"
        Me.REQ_MR_F_TEHAI.Text = Nothing
        Me.REQ_MR_F_TEHAI.Top = 2.989773!
        Me.REQ_MR_F_TEHAI.Width = 5.393701!
        '
        'MR_SEX
        '
        Me.MR_SEX.DataField = "MR_SEX"
        Me.MR_SEX.Height = 0.2!
        Me.MR_SEX.Left = 1.771654!
        Me.MR_SEX.Name = "MR_SEX"
        Me.MR_SEX.Text = Nothing
        Me.MR_SEX.Top = 3.189764!
        Me.MR_SEX.Width = 5.393701!
        '
        'MR_AGE
        '
        Me.MR_AGE.DataField = "MR_AGE"
        Me.MR_AGE.Height = 0.2!
        Me.MR_AGE.Left = 1.771654!
        Me.MR_AGE.Name = "MR_AGE"
        Me.MR_AGE.Text = Nothing
        Me.MR_AGE.Top = 3.389774!
        Me.MR_AGE.Width = 5.393701!
        '
        'REQ_MR_HOTEL_NOTE
        '
        Me.REQ_MR_HOTEL_NOTE.DataField = "REQ_MR_HOTEL_NOTE"
        Me.REQ_MR_HOTEL_NOTE.Height = 1.0!
        Me.REQ_MR_HOTEL_NOTE.Left = 1.771654!
        Me.REQ_MR_HOTEL_NOTE.Name = "REQ_MR_HOTEL_NOTE"
        Me.REQ_MR_HOTEL_NOTE.Text = Nothing
        Me.REQ_MR_HOTEL_NOTE.Top = 3.589774!
        Me.REQ_MR_HOTEL_NOTE.Width = 5.393701!
        '
        'Line40
        '
        Me.Line40.Height = 3.4!
        Me.Line40.Left = 1.771654!
        Me.Line40.LineWeight = 1.0!
        Me.Line40.Name = "Line40"
        Me.Line40.Top = 1.189764!
        Me.Line40.Width = 0.0!
        Me.Line40.X1 = 1.771654!
        Me.Line40.X2 = 1.771654!
        Me.Line40.Y1 = 1.189764!
        Me.Line40.Y2 = 4.589764!
        '
        'Line2
        '
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.0!
        Me.Line2.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.989764!
        Me.Line2.Width = 7.165354!
        Me.Line2.X1 = 0.0!
        Me.Line2.X2 = 7.165354!
        Me.Line2.Y1 = 2.989764!
        Me.Line2.Y2 = 2.989764!
        '
        'Line10
        '
        Me.Line10.Height = 0.0!
        Me.Line10.Left = 0.0!
        Me.Line10.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 3.189764!
        Me.Line10.Width = 7.165354!
        Me.Line10.X1 = 0.0!
        Me.Line10.X2 = 7.165354!
        Me.Line10.Y1 = 3.189764!
        Me.Line10.Y2 = 3.189764!
        '
        'Line11
        '
        Me.Line11.Height = 0.0!
        Me.Line11.Left = 0.0!
        Me.Line11.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 3.389774!
        Me.Line11.Width = 7.165354!
        Me.Line11.X1 = 0.0!
        Me.Line11.X2 = 7.165354!
        Me.Line11.Y1 = 3.389774!
        Me.Line11.Y2 = 3.389774!
        '
        'Line12
        '
        Me.Line12.Height = 0.0!
        Me.Line12.Left = 0.0!
        Me.Line12.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 3.589765!
        Me.Line12.Width = 7.165354!
        Me.Line12.X1 = 0.0!
        Me.Line12.X2 = 7.165354!
        Me.Line12.Y1 = 3.589765!
        Me.Line12.Y2 = 3.589765!
        '
        'Line23
        '
        Me.Line23.Height = 3.4!
        Me.Line23.Left = 0.0!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.189764!
        Me.Line23.Width = 0.0!
        Me.Line23.X1 = 0.0!
        Me.Line23.X2 = 0.0!
        Me.Line23.Y1 = 1.189764!
        Me.Line23.Y2 = 4.589764!
        '
        'Line30
        '
        Me.Line30.Height = 0.0!
        Me.Line30.Left = 0.0!
        Me.Line30.LineWeight = 1.0!
        Me.Line30.Name = "Line30"
        Me.Line30.Top = 4.589764!
        Me.Line30.Width = 7.165354!
        Me.Line30.X1 = 0.0!
        Me.Line30.X2 = 7.165354!
        Me.Line30.Y1 = 4.589764!
        Me.Line30.Y2 = 4.589764!
        '
        'Line31
        '
        Me.Line31.Height = 3.4!
        Me.Line31.Left = 7.165355!
        Me.Line31.LineWeight = 1.0!
        Me.Line31.Name = "Line31"
        Me.Line31.Top = 1.189764!
        Me.Line31.Width = 0.0!
        Me.Line31.X1 = 7.165355!
        Me.Line31.X2 = 7.165355!
        Me.Line31.Y1 = 1.189764!
        Me.Line31.Y2 = 4.589764!
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
        'Line1
        '
        Me.Line1.Height = 3.4!
        Me.Line1.Left = 7.165355!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.189764!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 7.165355!
        Me.Line1.X2 = 7.165355!
        Me.Line1.Y1 = 1.189764!
        Me.Line1.Y2 = 4.589764!
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Line13
        '
        Me.Line13.Height = 3.4!
        Me.Line13.Left = 7.165355!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 1.189764!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 7.165355!
        Me.Line13.X2 = 7.165355!
        Me.Line13.Y1 = 1.189764!
        Me.Line13.Y2 = 4.589764!
        '
        'DrReport4
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
        CType(Me.KOUENKAI_NO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_STATUS_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIME_STAMP_BYL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SANKASHA_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_NAME, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_KANA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DR_SHISETSU_CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_O_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_F_TEHAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_SEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MR_AGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REQ_MR_HOTEL_NOTE, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents KOUENKAI_NO As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_STATUS_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents TIME_STAMP_BYL As DataDynamics.ActiveReports.TextBox
    Private WithEvents SANKASHA_ID As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_NAME As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_KANA As DataDynamics.ActiveReports.TextBox
    Private WithEvents DR_SHISETSU_CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line3 As DataDynamics.ActiveReports.Line
    Private WithEvents Line4 As DataDynamics.ActiveReports.Line
    Private WithEvents Line5 As DataDynamics.ActiveReports.Line
    Private WithEvents Line6 As DataDynamics.ActiveReports.Line
    Private WithEvents Line7 As DataDynamics.ActiveReports.Line
    Private WithEvents Line8 As DataDynamics.ActiveReports.Line
    Private WithEvents Line9 As DataDynamics.ActiveReports.Line
    Private WithEvents Label39 As DataDynamics.ActiveReports.Label
    Private WithEvents Label40 As DataDynamics.ActiveReports.Label
    Private WithEvents Label41 As DataDynamics.ActiveReports.Label
    Private WithEvents Label42 As DataDynamics.ActiveReports.Label
    Private WithEvents Label43 As DataDynamics.ActiveReports.Label
    Private WithEvents REQ_MR_O_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_F_TEHAI As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_SEX As DataDynamics.ActiveReports.TextBox
    Private WithEvents MR_AGE As DataDynamics.ActiveReports.TextBox
    Private WithEvents REQ_MR_HOTEL_NOTE As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line40 As DataDynamics.ActiveReports.Line
    Private WithEvents Line2 As DataDynamics.ActiveReports.Line
    Private WithEvents Line10 As DataDynamics.ActiveReports.Line
    Private WithEvents Line11 As DataDynamics.ActiveReports.Line
    Private WithEvents Line12 As DataDynamics.ActiveReports.Line
    Private WithEvents Line23 As DataDynamics.ActiveReports.Line
    Private WithEvents Line30 As DataDynamics.ActiveReports.Line
    Private WithEvents Line31 As DataDynamics.ActiveReports.Line
    Private WithEvents Line32 As DataDynamics.ActiveReports.Line
    Private WithEvents Line33 As DataDynamics.ActiveReports.Line
    Private WithEvents Shape2 As DataDynamics.ActiveReports.Shape
    Private WithEvents Line1 As DataDynamics.ActiveReports.Line
    Private WithEvents Line13 As DataDynamics.ActiveReports.Line
End Class
