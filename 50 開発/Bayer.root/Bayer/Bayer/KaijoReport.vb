Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document
Imports AppLib
Imports CommonLib

Public Class KaijoReport

    Private pMS_USER As TableDef.MS_USER.DataStruct
    Public WriteOnly Property MS_USER() As TableDef.MS_USER.DataStruct
        Set(ByVal value As TableDef.MS_USER.DataStruct)
            pMS_USER = value
        End Set
    End Property

    Private pOldTBL_KAIJO As TableDef.TBL_KAIJO.DataStruct
    Public WriteOnly Property OldTBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
        Set(ByVal value As TableDef.TBL_KAIJO.DataStruct)
            pOldTBL_KAIJO = value
        End Set
    End Property

    Private pRireki As Boolean
    Public Property Rireki() As Boolean
        Get
            Return pRireki
        End Get
        Set(ByVal value As Boolean)
            pRireki = value
        End Set
    End Property

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        Me.PrintDate.Text = CmnModule.Format_Date(Now(), CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        Me.LOGIN_USER_NAME.Text = pMS_USER.USER_NAME
    End Sub

    Private Sub PageHeader_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.BeforePrint
        Me.LabelPage.Text = "(" & Me.PageCount.Text & "/" & Me.PageTotal.Text & "ページ)"
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '差異のある項目の背景色を変更
        If pRireki = False AndAlso Trim(pOldTBL_KAIJO.KOUENKAI_NO) <> "" Then
            '履歴、新規登録時は除外
            SetChangedColor(Me.KOUENKAI_NAME, pOldTBL_KAIJO.KOUENKAI_NAME, Me.KOUENKAI_NAME.Text)
            SetChangedColor(Me.KAIJO_NAME, pOldTBL_KAIJO.KAIJO_NAME, Me.KAIJO_NAME.Text)
            SetChangedColor(Me.FROM_DATE, pOldTBL_KAIJO.FROM_DATE & "," & pOldTBL_KAIJO.TO_DATE, Me.FROM_DATE.Text & "," & Me.TO_DATE.Text)
            SetChangedColor(Me.KOUENKAI_NO, pOldTBL_KAIJO.KOUENKAI_NO, Me.KOUENKAI_NO.Text)
            SetChangedColor(Me.TEHAI_ID, pOldTBL_KAIJO.TEHAI_ID, Me.TEHAI_ID.Text)
            SetChangedColor(Me.TIME_STAMP_BYL, pOldTBL_KAIJO.TIME_STAMP_BYL, Me.TIME_STAMP_BYL.Text)
            SetChangedColor(Me.REQ_STATUS_TEHAI, pOldTBL_KAIJO.REQ_STATUS_TEHAI, Me.REQ_STATUS_TEHAI.Text)
            SetChangedColor(Me.SEIHIN_NAME, pOldTBL_KAIJO.SEIHIN_NAME, Me.SEIHIN_NAME.Text)
            SetChangedColor(Me.TAXI_PRT_NAME, pOldTBL_KAIJO.TAXI_PRT_NAME, Me.TAXI_PRT_NAME.Text)
            SetChangedColor(Me.ZETIA_CD, pOldTBL_KAIJO.ZETIA_CD, Me.ZETIA_CD.Text)
            SetChangedColor(Me.SHONIN_NAME, pOldTBL_KAIJO.SHONIN_NAME, Me.SHONIN_NAME.Text)
            SetChangedColor(Me.SHONIN_DATE, pOldTBL_KAIJO.SHONIN_DATE, Me.SHONIN_DATE.Text)
            SetChangedColor(Me.BU, pOldTBL_KAIJO.BU, Me.BU.Text)
            SetChangedColor(Me.KIKAKU_TANTO_AREA, pOldTBL_KAIJO.KIKAKU_TANTO_AREA, Me.KIKAKU_TANTO_AREA.Text)
            SetChangedColor(Me.KIKAKU_TANTO_EIGYOSHO, pOldTBL_KAIJO.KIKAKU_TANTO_EIGYOSHO, Me.KIKAKU_TANTO_EIGYOSHO.Text)
            SetChangedColor(Me.KIKAKU_TANTO_ROMA, pOldTBL_KAIJO.KIKAKU_TANTO_ROMA, Me.KIKAKU_TANTO_ROMA.Text)
            SetChangedColor(Me.KIKAKU_TANTO_TEL, pOldTBL_KAIJO.KIKAKU_TANTO_TEL, Me.KIKAKU_TANTO_TEL.Text)
            SetChangedColor(Me.KIKAKU_TANTO_EMAIL_PC, pOldTBL_KAIJO.KIKAKU_TANTO_EMAIL_PC, Me.KIKAKU_TANTO_EMAIL_PC.Text)
            SetChangedColor(Me.KIKAKU_TANTO_KEITAI, pOldTBL_KAIJO.KIKAKU_TANTO_KEITAI, Me.KIKAKU_TANTO_KEITAI.Text)
            SetChangedColor(Me.KIKAKU_TANTO_NAME, pOldTBL_KAIJO.KIKAKU_TANTO_NAME, Me.KIKAKU_TANTO_NAME.Text)
            SetChangedColor(Me.KIKAKU_TANTO_EMAIL_KEITAI, pOldTBL_KAIJO.KIKAKU_TANTO_EMAIL_KEITAI, Me.KIKAKU_TANTO_EMAIL_KEITAI.Text)
            SetChangedColor(Me.TEHAI_TANTO_EMAIL_PC, pOldTBL_KAIJO.TEHAI_TANTO_EMAIL_PC, Me.TEHAI_TANTO_EMAIL_PC.Text)
            SetChangedColor(Me.TEHAI_TANTO_ROMA, pOldTBL_KAIJO.TEHAI_TANTO_ROMA, Me.TEHAI_TANTO_ROMA.Text)
            SetChangedColor(Me.TEHAI_TANTO_TEL, pOldTBL_KAIJO.TEHAI_TANTO_TEL, Me.TEHAI_TANTO_TEL.Text)
            SetChangedColor(Me.TEHAI_TANTO_KEITAI, pOldTBL_KAIJO.TEHAI_TANTO_KEITAI, Me.TEHAI_TANTO_KEITAI.Text)
            SetChangedColor(Me.TEHAI_TANTO_NAME, pOldTBL_KAIJO.TEHAI_TANTO_NAME, Me.TEHAI_TANTO_NAME.Text)
            SetChangedColor(Me.TEHAI_TANTO_EMAIL_KEITAI, pOldTBL_KAIJO.TEHAI_TANTO_EMAIL_KEITAI, Me.TEHAI_TANTO_EMAIL_KEITAI.Text)
            SetChangedColor(Me.TEHAI_TANTO_EIGYOSHO, pOldTBL_KAIJO.TEHAI_TANTO_EIGYOSHO, Me.TEHAI_TANTO_EIGYOSHO.Text)
            SetChangedColor(Me.TEHAI_TANTO_AREA, pOldTBL_KAIJO.TEHAI_TANTO_AREA, Me.TEHAI_TANTO_AREA.Text)
            SetChangedColor(Me.TEHAI_TANTO_BU, pOldTBL_KAIJO.TEHAI_TANTO_BU, Me.TEHAI_TANTO_BU.Text)
            SetChangedColor(Me.SANKA_YOTEI_CNT_NMBR, pOldTBL_KAIJO.SANKA_YOTEI_CNT_NMBR, Me.SANKA_YOTEI_CNT_NMBR.Text)
            SetChangedColor(Me.SRM_HACYU_KBN, pOldTBL_KAIJO.SRM_HACYU_KBN, Me.SRM_HACYU_KBN.Text)
            SetChangedColor(Me.SANKA_YOTEI_CNT_MBR, pOldTBL_KAIJO.SANKA_YOTEI_CNT_MBR, Me.SANKA_YOTEI_CNT_MBR.Text)
            SetChangedColor(Me.YOSAN_TF, pOldTBL_KAIJO.YOSAN_TF, Me.YOSAN_TF.Text)
            SetChangedColor(Me.YOSAN_T, pOldTBL_KAIJO.YOSAN_T, Me.YOSAN_T.Text)
            SetChangedColor(Me.YOSAN_TOTAL, pOldTBL_KAIJO.YOSAN_T & "," & pOldTBL_KAIJO.YOSAN_TF, Me.YOSAN_T.Text & "," & Me.YOSAN_TF.Text)
            SetChangedColor(Me.IKENKOUKAN_YOSAN_T, pOldTBL_KAIJO.IKENKOUKAN_YOSAN_T, Me.IKENKOUKAN_YOSAN_T.Text)
            SetChangedColor(Me.IROUKAI_YOSAN_T, pOldTBL_KAIJO.IROUKAI_YOSAN_T, Me.IROUKAI_YOSAN_T.Text)
            SetChangedColor(Me.KAISAI_DATE_NOTE, pOldTBL_KAIJO.KAISAI_DATE_NOTE, Me.KAISAI_DATE_NOTE.Text)
            SetChangedColor(Me.KAISAI_KIBOU_ADDRESS1, pOldTBL_KAIJO.KAISAI_KIBOU_ADDRESS1, Me.KAISAI_KIBOU_ADDRESS1.Text)
            SetChangedColor(Me.KAISAI_KIBOU_ADDRESS2, pOldTBL_KAIJO.KAISAI_KIBOU_ADDRESS2, Me.KAISAI_KIBOU_ADDRESS2.Text)
            SetChangedColor(Me.KOUEN_TIME1, pOldTBL_KAIJO.KOUEN_TIME1, Me.KOUEN_TIME1.Text)
            SetChangedColor(Me.KOUEN_TIME2, pOldTBL_KAIJO.KOUEN_TIME2, Me.KOUEN_TIME2.Text)
            SetChangedColor(Me.KOUEN_KAIJO_LAYOUT, pOldTBL_KAIJO.KOUEN_KAIJO_LAYOUT, Me.KOUEN_KAIJO_LAYOUT.Text)
            SetChangedColor(Me.KAISAI_KIBOU_NOTE, pOldTBL_KAIJO.KAISAI_KIBOU_NOTE, Me.KAISAI_KIBOU_NOTE.Text)
            SetChangedColor(Me.IKENKOUKAN_KAIJO_TEHAI, pOldTBL_KAIJO.IKENKOUKAN_KAIJO_TEHAI, Me.IKENKOUKAN_KAIJO_TEHAI.Text)
            SetChangedColor(Me.IROUKAI_KAIJO_TEHAI, pOldTBL_KAIJO.IROUKAI_KAIJO_TEHAI, Me.IROUKAI_KAIJO_TEHAI.Text)
            SetChangedColor(Me.IROUKAI_SANKA_YOTEI_CNT, pOldTBL_KAIJO.IROUKAI_SANKA_YOTEI_CNT, Me.IROUKAI_SANKA_YOTEI_CNT.Text)
            SetChangedColor(Me.KOUSHI_ROOM_TEHAI, pOldTBL_KAIJO.KOUSHI_ROOM_TEHAI, Me.KOUSHI_ROOM_TEHAI.Text)
            SetChangedColor(Me.KOUSHI_ROOM_FROM, pOldTBL_KAIJO.KOUSHI_ROOM_FROM, Me.KOUSHI_ROOM_FROM.Text)
            SetChangedColor(Me.KOUSHI_ROOM_CNT, pOldTBL_KAIJO.KOUSHI_ROOM_CNT, Me.KOUSHI_ROOM_CNT.Text)
            SetChangedColor(Me.SHAIN_ROOM_TEHAI, pOldTBL_KAIJO.SHAIN_ROOM_TEHAI, Me.SHAIN_ROOM_TEHAI.Text)
            SetChangedColor(Me.SHAIN_ROOM_CNT, pOldTBL_KAIJO.SHAIN_ROOM_CNT, Me.SHAIN_ROOM_CNT.Text)
            SetChangedColor(Me.MANAGER_KAIJO_TEHAI, pOldTBL_KAIJO.MANAGER_KAIJO_TEHAI, Me.MANAGER_KAIJO_TEHAI.Text)
            SetChangedColor(Me.MANAGER_ROOM_FROM, pOldTBL_KAIJO.MANAGER_ROOM_FROM, Me.MANAGER_ROOM_FROM.Text)
            SetChangedColor(Me.MANAGER_ROOM_CNT, pOldTBL_KAIJO.MANAGER_ROOM_CNT, Me.MANAGER_ROOM_CNT.Text)
            SetChangedColor(Me.REQ_STAY_DATE, pOldTBL_KAIJO.REQ_STAY_DATE, Me.REQ_STAY_DATE.Text)
            SetChangedColor(Me.REQ_ROOM_CNT, pOldTBL_KAIJO.REQ_ROOM_CNT, Me.REQ_ROOM_CNT.Text)
            SetChangedColor(Me.REQ_KOTSU_CNT, pOldTBL_KAIJO.REQ_KOTSU_CNT, Me.REQ_KOTSU_CNT.Text)
            SetChangedColor(Me.REQ_TAXI_CNT, pOldTBL_KAIJO.REQ_TAXI_CNT, Me.REQ_TAXI_CNT.Text)
            SetChangedColor(Me.OTHER_NOTE, pOldTBL_KAIJO.OTHER_NOTE, Me.OTHER_NOTE.Text)
        End If

        Me.SEND_FLAG.Text = AppModule.GetName_SEND_FLAG(Me.SEND_FLAG.Text)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(Me.KOUENKAI_NAME.Text)
        Me.KAIJO_NAME.Text = AppModule.GetName_KAIJO_NAME(Me.KAIJO_NAME.Text)
        Me.FROM_DATE.Text = AppModule.GetName_KOUENKAI_DATE(Me.FROM_DATE.Text, Me.TO_DATE.Text)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(Me.KOUENKAI_NO.Text)
        Me.TEHAI_ID.Text = AppModule.GetName_TEHAI_ID(Me.TEHAI_ID.Text)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(Me.TIME_STAMP_BYL.Text)
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(Me.REQ_STATUS_TEHAI.Text, True)
        Me.SEIHIN_NAME.Text = AppModule.GetName_SEIHIN_NAME(Me.SEIHIN_NAME.Text)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(Me.TAXI_PRT_NAME.Text)
        Me.ZETIA_CD.Text = AppModule.GetName_ZETIA_CD(Me.ZETIA_CD.Text)
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(Me.SHONIN_NAME.Text)
        Me.SHONIN_DATE.Text = AppModule.GetName_SHONIN_DATE(Me.SHONIN_DATE.Text)
        Me.BU.Text = AppModule.GetName_BU(Me.BU.Text)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(Me.KIKAKU_TANTO_AREA.Text)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(Me.KIKAKU_TANTO_EIGYOSHO.Text)
        Me.KIKAKU_TANTO_ROMA.Text = AppModule.GetName_KIKAKU_TANTO_ROMA(Me.KIKAKU_TANTO_ROMA.Text)
        Me.KIKAKU_TANTO_TEL.Text = AppModule.GetName_KIKAKU_TANTO_TEL(Me.KIKAKU_TANTO_TEL.Text)
        Me.KIKAKU_TANTO_EMAIL_PC.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL_PC(Me.KIKAKU_TANTO_EMAIL_PC.Text)
        Me.KIKAKU_TANTO_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_KEITAI(Me.KIKAKU_TANTO_KEITAI.Text)
        Me.KIKAKU_TANTO_NAME.Text = AppModule.GetName_KIKAKU_TANTO_NAME(Me.KIKAKU_TANTO_NAME.Text)
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL_KEITAI(Me.KIKAKU_TANTO_EMAIL_KEITAI.Text)
        Me.TEHAI_TANTO_EMAIL_PC.Text = AppModule.GetName_TEHAI_TANTO_EMAIL_PC(Me.TEHAI_TANTO_EMAIL_PC.Text)
        Me.TEHAI_TANTO_ROMA.Text = AppModule.GetName_TEHAI_TANTO_ROMA(Me.TEHAI_TANTO_ROMA.Text)
        Me.TEHAI_TANTO_TEL.Text = AppModule.GetName_TEHAI_TANTO_TEL(Me.TEHAI_TANTO_TEL.Text)
        Me.TEHAI_TANTO_KEITAI.Text = AppModule.GetName_TEHAI_TANTO_KEITAI(Me.TEHAI_TANTO_KEITAI.Text)
        Me.TEHAI_TANTO_NAME.Text = AppModule.GetName_TEHAI_TANTO_NAME(Me.TEHAI_TANTO_NAME.Text)
        Me.TEHAI_TANTO_EMAIL_KEITAI.Text = AppModule.GetName_TEHAI_TANTO_EMAIL_KEITAI(Me.TEHAI_TANTO_EMAIL_KEITAI.Text)
        Me.TEHAI_TANTO_EIGYOSHO.Text = AppModule.GetName_TEHAI_TANTO_EIGYOSHO(Me.TEHAI_TANTO_EIGYOSHO.Text)
        Me.TEHAI_TANTO_AREA.Text = AppModule.GetName_TEHAI_TANTO_AREA(Me.TEHAI_TANTO_AREA.Text)
        Me.TEHAI_TANTO_BU.Text = AppModule.GetName_TEHAI_TANTO_BU(Me.TEHAI_TANTO_BU.Text)
        Me.SANKA_YOTEI_CNT_NMBR.Text = AppModule.GetName_SANKA_YOTEI_CNT_NMBR(Me.SANKA_YOTEI_CNT_NMBR.Text) & "名"
        Me.SRM_HACYU_KBN.Text = AppModule.GetName_SRM_HACYU_KBN(Me.SRM_HACYU_KBN.Text)
        Me.SANKA_YOTEI_CNT_MBR.Text = AppModule.GetName_SANKA_YOTEI_CNT_MBR(Me.SANKA_YOTEI_CNT_MBR.Text) & "名"
        Me.YOSAN_TOTAL.Text = AppModule.GetName_YOSAN_TOTAL(Me.YOSAN_T.Text, Me.YOSAN_TF.Text) & "円"
        Me.YOSAN_TF.Text = AppModule.GetName_YOSAN_TF(Me.YOSAN_TF.Text) & "円"
        Me.YOSAN_T.Text = AppModule.GetName_YOSAN_T(Me.YOSAN_T.Text) & "円"
        Me.IKENKOUKAN_YOSAN_T.Text = AppModule.GetName_IKENKOUKAN_YOSAN_T(Me.IKENKOUKAN_YOSAN_T.Text) & "円"
        Me.IROUKAI_YOSAN_T.Text = AppModule.GetName_IROUKAI_YOSAN_T(Me.IROUKAI_YOSAN_T.Text) & "円"
        Me.KAISAI_DATE_NOTE.Text = AppModule.GetName_KAISAI_DATE_NOTE(Me.KAISAI_DATE_NOTE.Text)
        Me.KAISAI_KIBOU_ADDRESS1.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS1(Me.KAISAI_KIBOU_ADDRESS1.Text)
        Me.KAISAI_KIBOU_ADDRESS2.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS2(Me.KAISAI_KIBOU_ADDRESS2.Text)
        Me.KOUEN_TIME1.Text = AppModule.GetName_KOUEN_TIME1(Me.KOUEN_TIME1.Text)
        Me.KOUEN_TIME2.Text = AppModule.GetName_KOUEN_TIME2(Me.KOUEN_TIME2.Text)
        Me.KOUEN_KAIJO_LAYOUT.Text = AppModule.GetName_KOUEN_KAIJO_LAYOUT(Me.KOUEN_KAIJO_LAYOUT.Text)
        Me.KAISAI_KIBOU_NOTE.Text = AppModule.GetName_KAISAI_KIBOU_NOTE(Me.KAISAI_KIBOU_NOTE.Text)
        Me.IKENKOUKAN_KAIJO_TEHAI.Text = AppModule.GetName_IKENKOUKAN_KAIJO_TEHAI(Me.IKENKOUKAN_KAIJO_TEHAI.Text)
        Me.IROUKAI_KAIJO_TEHAI.Text = AppModule.GetName_IROUKAI_KAIJO_TEHAI(Me.IROUKAI_KAIJO_TEHAI.Text)
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = AppModule.GetName_IROUKAI_SANKA_YOTEI_CNT(Me.IROUKAI_SANKA_YOTEI_CNT.Text) & "名"
        Me.KOUSHI_ROOM_TEHAI.Text = AppModule.GetName_KOUSHI_ROOM_TEHAI(Me.KOUSHI_ROOM_TEHAI.Text)
        Me.KOUSHI_ROOM_FROM.Text = AppModule.GetName_KOUSHI_ROOM_FROM(Me.KOUSHI_ROOM_FROM.Text)
        If Trim(Me.KOUSHI_ROOM_FROM.Text) <> "" Then Me.KOUSHI_ROOM_FROM.Text &= "～"
        Me.KOUSHI_ROOM_CNT.Text = AppModule.GetName_KOUSHI_ROOM_CNT(Me.KOUSHI_ROOM_CNT.Text) & "名"
        Me.SHAIN_ROOM_TEHAI.Text = AppModule.GetName_SHAIN_ROOM_TEHAI(Me.SHAIN_ROOM_TEHAI.Text)
        Me.SHAIN_ROOM_CNT.Text = AppModule.GetName_SHAIN_ROOM_CNT(Me.SHAIN_ROOM_CNT.Text) & "名"
        Me.MANAGER_KAIJO_TEHAI.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI(Me.MANAGER_KAIJO_TEHAI.Text)
        Me.MANAGER_ROOM_FROM.Text = AppModule.GetName_MANAGER_ROOM_FROM(Me.MANAGER_ROOM_FROM.Text)
        If Trim(Me.MANAGER_ROOM_FROM.Text) <> "" Then Me.MANAGER_ROOM_FROM.Text &= "～"
        Me.MANAGER_ROOM_CNT.Text = AppModule.GetName_MANAGER_ROOM_CNT(Me.MANAGER_ROOM_CNT.Text) & "名"
        Me.REQ_STAY_DATE.Text = AppModule.GetName_REQ_STAY_DATE(Me.REQ_STAY_DATE.Text)
        Me.REQ_ROOM_CNT.Text = AppModule.GetName_REQ_ROOM_CNT(Me.REQ_ROOM_CNT.Text) & "室"
        Me.REQ_KOTSU_CNT.Text = AppModule.GetName_REQ_KOTSU_CNT(Me.REQ_KOTSU_CNT.Text) & "名"
        Me.REQ_TAXI_CNT.Text = AppModule.GetName_REQ_TAXI_CNT(Me.REQ_TAXI_CNT.Text) & "名"
        Me.OTHER_NOTE.Text = AppModule.GetName_OTHER_NOTE(Me.OTHER_NOTE.Text)
    End Sub

    '差異
    Private Sub SetChangedColor(ByRef control As TextBox, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(255, 255, 0)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
    End Sub

End Class
