Imports AppLib
Imports CommonLib
Imports System.IO
Public Class Proc
    Inherits batchBase

    Private Const pbatchID As String = "ImportKotsuHotel" 'バッチID
    Private Const pDelimiter As String = ","

#Region "ファイル項目"

    'TODO:項目確定次第定義する
    Private Const COL_COUNT As Integer = 199 'ファイルの項目数

    Private Enum COL_NO
        Id
        Name
        MeetingName__c
        MeetingNo__c
        TT_ArrangeStatusRequest__c
        TT_ArrangeStatusResponse__c
        TT_TimestampBYL__c
        TT_TimestampTOP__c
        TT_LastApprovalUserName__c
        TT_LastApprovalDate__c
        TT_DoctorName__c
        TT_DoctorNameKana__c
        TT_DoctorCode__c
        TT_DoctorInstituteCode__c
        TT_DoctorInstituteName__c
        TT_DoctorInstituteAddress__c
        TT_DoctorPart__c
        TT_DoctorSex__c
        TT_DoctorAge__c
        TT_ReasonOutSpec__c
        TT_ContactPersonBU_NameEN__c
        TT_ContactPersonAreaName__c
        TT_ContactPersonFS_Name__c
        TT_ContactPersonNameKanji__c
        TT_ContactPersonName__c
        TT_ContactPersonPhone__c
        TT_ContactPersonEmail__c
        TT_ContactPersonMobile__c
        TT_ContactPersonMobileMail__c
        TT_SendFS__c
        TT_SendFS_Other__c
        TT_AccountCode__c
        TT_CostCenter__c
        TT_InternalOrder__c
        TT_ZetiaCode__c
        TT_ReqStay__c
        TT_ReqStayStatus__c
        TT_ReqStayDate__c
        TT_ReqStayNumber__c
        TT_ReqStaySmoking__c
        TT_ReqStayRemarks__c
        TT_ReqOutBound1__c
        TT_ReqOutBoundStatus1__c
        TT_ReqOutBoundTransport1__c
        TT_ReqOutBoundDate1__c
        TT_ReqOutBoundDeparture1__c
        TT_ReqOutBoundArrival1__c
        TT_ReqOutBoundDepartureTime1__c
        TT_ReqOutBoundArrivalTime1__c
        TT_ReqOutBoundTrainName1__c
        TT_ReqOutBoundSeatClass1__c
        TT_ReqOutBoundSeat1__c
        TT_ReqOutBound2__c
        TT_ReqOutBoundStatus2__c
        TT_ReqOutBoundTransport2__c
        TT_ReqOutBoundDate2__c
        TT_ReqOutBoundDeparture2__c
        TT_ReqOutBoundArrival2__c
        TT_ReqOutBoundDepartureTime2__c
        TT_ReqOutBoundArrivalTime2__c
        TT_ReqOutBoundTrainName2__c
        TT_ReqOutBoundSeatClass2_c
        TT_ReqOutBoundSeat2__c
        TT_ReqOutBound3__c
        TT_ReqOutBoundStatus3__c
        TT_ReqOutBoundTransport3__c
        TT_ReqOutBoundDate3__c
        TT_ReqOutBoundDeparture3__c
        TT_ReqOutBoundArrival3__c
        TT_ReqOutBoundDepartureTime3__c
        TT_ReqOutBoundArrivalTime3__c
        TT_ReqOutBoundTrainName3__c
        TT_ReqOutBoundSeatClass3__c
        TT_ReqOutBoundSeat3__c
        TT_ReqOutBound4__c
        TT_ReqOutBoundStatus4__c
        TT_ReqOutBoundTransport4__c
        TT_ReqOutBoundDate4__c
        TT_ReqOutBoundDeparture4__c
        TT_ReqOutBoundArrival4__c
        TT_ReqOutBoundDepartureTime4__c
        TT_ReqOutBoundArrivalTime4__c
        TT_ReqOutBoundTrainName4__c
        TT_ReqOutBoundSeatClass4__c
        TT_ReqOutBoundSeat4__c
        TT_ReqOutBound5__c
        TT_ReqOutBoundStatus5__c
        TT_ReqOutBoundTransport5__c
        TT_ReqOutBoundDate5__c
        TT_ReqOutBoundDeparture5__c
        TT_ReqOutBoundArrival5__c
        TT_ReqOutBoundDepartureTime5__c
        TT_ReqOutBoundArrivalTime5__c
        TT_ReqOutBoundTrainName5__c
        TT_ReqOutBoundSeatClass5__c
        TT_ReqOutBoundSeat5__c
        TT_ReqInBound1__c
        TT_ReqInBoundStatus1__c
        TT_ReqInBoundTransport1__c
        TT_ReqInBoundDate1__c
        TT_ReqInBoundDeparture1__c
        TT_ReqInBoundArrival1__c
        TT_ReqInBoundDepartureTime1__c
        TT_ReqInBoundArrivalTime1__c
        TT_ReqInBoundTrainName1__c
        TT_ReqInBoundSeatClass1__c
        TT_ReqInBoundSeat1__c
        TT_ReqInBound2__c
        TT_ReqInBoundStatus2__c
        TT_ReqInBoundTransport2__c
        TT_ReqInBoundDate2__c
        TT_ReqInBoundDeparture2__c
        TT_ReqInBoundArrival2__c
        TT_ReqInBoundDepartureTime2__c
        TT_ReqInBoundArrivalTime2__c
        TT_ReqInBoundTrainName2__c
        TT_ReqInBoundSeatClass2__c
        TT_ReqInBoundSeat2__c
        TT_ReqInBound3__c
        TT_ReqInBoundStatus3__c
        TT_ReqInBoundTransport3__c
        TT_ReqInBoundDate3__c
        TT_ReqInBoundDeparture3__c
        TT_ReqInBoundArrival3__c
        TT_ReqInBoundDepartureTime3__c
        TT_ReqInBoundArrivalTime3__c
        TT_ReqInBoundTrainName3__c
        TT_ReqInBoundSeatClass3__c
        TT_ReqInBoundSeat3__c
        TT_ReqInBound4__c
        TT_ReqInBoundStatus4__c
        TT_ReqInBoundTransport4__c
        TT_ReqInBoundDate4__c
        TT_ReqInBoundDeparture4__c
        TT_ReqInBoundArrival4__c
        TT_ReqInBoundDepartureTime4__c
        TT_ReqInBoundArrivalTime4__c
        TT_ReqInBoundTrainName4__c
        TT_ReqInBoundSeatClass4__c
        TT_ReqInBoundSeat4__c
        TT_ReqInBound5__c
        TT_ReqInBoundStatus5__c
        TT_ReqInBoundTransport5__c
        TT_ReqInBoundDate5__c
        TT_ReqInBoundDeparture5__c
        TT_ReqInBoundArrival5__c
        TT_ReqInBoundDepartureTime5__c
        TT_ReqInBoundArrivalTime5__c
        TT_ReqInBoundTrainName5__c
        TT_ReqInBoundSeatClass5__c
        TT_ReqInBoundSeat5__c
        TT_ReqRemarksTraffic__c
        TT_ReqTaxi__c
        TT_ReqTaxiDate1__c
        TT_ReqTaxiArrival1__c
        TT_ReqTaxiAmount1__c
        TT_ReqTaxiDate2__c
        TT_ReqTaxiArrival2__c
        TT_ReqTaxiAmount2__c
        TT_ReqTaxiDate3__c
        TT_ReqTaxiArrival3__c
        TT_ReqTaxiAmount3__c
        TT_ReqTaxiDate4__c
        TT_ReqTaxiArrival4__c
        TT_ReqTaxiAmount4__c
        TT_ReqTaxiDate5__c
        TT_ReqTaxiArrival5__c
        TT_ReqTaxiAmount5__c
        TT_ReqTaxiDate6__c
        TT_ReqTaxiArrival6__c
        TT_ReqTaxiAmount6__c
        TT_ReqTaxiDate7__c
        TT_ReqTaxiArrival7__c
        TT_ReqTaxiAmount7__c
        TT_ReqTaxiDate8__c
        TT_ReqTaxiArrival8__c
        TT_ReqTaxiAmount8__c
        TT_ReqTaxiDate9__c
        TT_ReqTaxiArrival9__c
        TT_ReqTaxiAmount9__c
        TT_ReqTaxiDate10__c
        TT_ReqTaxiArrival10__c
        TT_ReqTaxiAmount10__c
        TT_ReqTaxiRemarks__c
        TT_ReqEmployeeOutBound__c
        TT_ReqEmployeeInBound__c
        TT_ReqEmployeeSex__c
        TT_ReqEmployeeAge__c
        TT_ReqEmployeeStay__c
        TT_ReqEmployeeStaySmorking__c
        TT_ReqEmployeeStayRemarks__c
        TT_Attendance__c
        TT_StatusRequest__c
        TT_StatusRequestActual__c
        TT_LastModifiedDate__c
        MeetingDivision__c
        Invalid__c
        CreatedDate
        LastModifiedDate
    End Enum

    Private Class COL_NAME
        Public Const Id As String = "Salesforce Id"
        Public Const Name As String = "会合参加者Id"
        Public Const MeetingName__c As String = "会合名"
        Public Const MeetingNo__c As String = "会合番号"
        Public Const TT_ArrangeStatusRequest__c As String = "手配ステータス (依頼)"
        Public Const TT_ArrangeStatusResponse__c As String = "手配ステータス (回答)"
        Public Const TT_TimestampBYL__c As String = "Timestamp (BYL)"
        Public Const TT_TimestampTOP__c As String = "Timestamp (TOP)"
        Public Const TT_LastApprovalUserName__c As String = "最終承認者"
        Public Const TT_LastApprovalDate__c As String = "最終承認日"
        Public Const TT_DoctorName__c As String = "医師名"
        Public Const TT_DoctorNameKana__c As String = "医師名(カナ)"
        Public Const TT_DoctorCode__c As String = "医師コード"
        Public Const TT_DoctorInstituteCode__c As String = "施設コード"
        Public Const TT_DoctorInstituteName__c As String = "施設名"
        Public Const TT_DoctorInstituteAddress__c As String = "施設住所"
        Public Const TT_DoctorPart__c As String = "参加者役割"
        Public Const TT_DoctorSex__c As String = "性別"
        Public Const TT_DoctorAge__c As String = "年齢"
        Public Const TT_ReasonOutSpec__c As String = "指定外申請理由（依頼）"
        Public Const TT_ContactPersonBU_NameEN__c As String = "担当MRのBU英名"
        Public Const TT_ContactPersonAreaName__c As String = "担当MRのエリア名"
        Public Const TT_ContactPersonFS_Name__c As String = "担当MRの営業所名"
        Public Const TT_ContactPersonNameKanji__c As String = "担当MRの氏名"
        Public Const TT_ContactPersonName__c As String = "担当MRの氏名(ﾛｰﾏ字)"
        Public Const TT_ContactPersonPhone__c As String = "担当MRの会社電話"
        Public Const TT_ContactPersonEmail__c As String = "担当MRのEmail"
        Public Const TT_ContactPersonMobile__c As String = "担当MRの携帯番号"
        Public Const TT_ContactPersonMobileMail__c As String = "担当MRの携帯メール"
        Public Const TT_SendFS__c As String = "チケット送付先FS"
        Public Const TT_SendFS_Other__c As String = "チケット送付先（その他）"
        Public Const TT_AccountCode__c As String = "Account Code"
        Public Const TT_CostCenter__c As String = "Cost Center"
        Public Const TT_InternalOrder__c As String = "Internal Order"
        Public Const TT_ZetiaCode__c As String = "Zetia Code"
        Public Const TT_ReqStay__c As String = "宿泊手配（希望する）"
        Public Const TT_ReqStayStatus__c As String = "宿泊依頼内容"
        Public Const TT_ReqStayDate__c As String = "宿泊日（依頼）"
        Public Const TT_ReqStayNumber__c As String = "泊数（依頼）"
        Public Const TT_ReqStaySmoking__c As String = "宿泊ホテル喫煙（依頼）"
        Public Const TT_ReqStayRemarks__c As String = "宿泊備考（依頼）"
        Public Const TT_ReqOutBound1__c As String = "往路1：希望する（依頼）"
        Public Const TT_ReqOutBoundStatus1__c As String = "往路1：依頼内容（依頼）"
        Public Const TT_ReqOutBoundTransport1__c As String = "往路1：交通機関（依頼）"
        Public Const TT_ReqOutBoundDate1__c As String = "往路1：利用日（依頼）"
        Public Const TT_ReqOutBoundDeparture1__c As String = "往路1：出発地（依頼）"
        Public Const TT_ReqOutBoundArrival1__c As String = "往路1：到着地（依頼）"
        Public Const TT_ReqOutBoundDepartureTime1__c As String = "往路1：出発時間（依頼）"
        Public Const TT_ReqOutBoundArrivalTime1__c As String = "往路1：到着時間（依頼）"
        Public Const TT_ReqOutBoundTrainName1__c As String = "往路1：列車名・便名（依頼）"
        Public Const TT_ReqOutBoundSeatClass1__c As String = "往路1：座席区分（依頼）"
        Public Const TT_ReqOutBoundSeat1__c As String = "往路1：座席希望（依頼）"
        Public Const TT_ReqOutBound2__c As String = "往路2：希望する（依頼）"
        Public Const TT_ReqOutBoundStatus2__c As String = "往路2：依頼内容（依頼）"
        Public Const TT_ReqOutBoundTransport2__c As String = "往路2：交通機関（依頼）"
        Public Const TT_ReqOutBoundDate2__c As String = "往路2：利用日（依頼）"
        Public Const TT_ReqOutBoundDeparture2__c As String = "往路2：出発地（依頼）"
        Public Const TT_ReqOutBoundArrival2__c As String = "往路2：到着地（依頼）"
        Public Const TT_ReqOutBoundDepartureTime2__c As String = "往路2：出発時間（依頼）"
        Public Const TT_ReqOutBoundArrivalTime2__c As String = "往路2：到着時間（依頼）"
        Public Const TT_ReqOutBoundTrainName2__c As String = "往路2：列車名・便名（依頼）"
        Public Const TT_ReqOutBoundSeatClass2_c As String = "往路2：座席区分（依頼）"
        Public Const TT_ReqOutBoundSeat2__c As String = "往路2：座席希望（依頼）"
        Public Const TT_ReqOutBound3__c As String = "往路3：希望する（依頼）"
        Public Const TT_ReqOutBoundStatus3__c As String = "往路3：依頼内容（依頼）"
        Public Const TT_ReqOutBoundTransport3__c As String = "往路3：交通機関（依頼）"
        Public Const TT_ReqOutBoundDate3__c As String = "往路3：利用日（依頼）"
        Public Const TT_ReqOutBoundDeparture3__c As String = "往路3：出発地（依頼）"
        Public Const TT_ReqOutBoundArrival3__c As String = "往路3：到着地（依頼）"
        Public Const TT_ReqOutBoundDepartureTime3__c As String = "往路3：出発時間（依頼）"
        Public Const TT_ReqOutBoundArrivalTime3__c As String = "往路3：到着時間（依頼）"
        Public Const TT_ReqOutBoundTrainName3__c As String = "往路3：列車名・便名（依頼）"
        Public Const TT_ReqOutBoundSeatClass3__c As String = "往路3：座席区分（依頼）"
        Public Const TT_ReqOutBoundSeat3__c As String = "往路3：座席希望（依頼）"
        Public Const TT_ReqOutBound4__c As String = "往路4：希望する（依頼）"
        Public Const TT_ReqOutBoundStatus4__c As String = "往路4：依頼内容（依頼）"
        Public Const TT_ReqOutBoundTransport4__c As String = "往路4：交通機関（依頼）"
        Public Const TT_ReqOutBoundDate4__c As String = "往路4：利用日（依頼）"
        Public Const TT_ReqOutBoundDeparture4__c As String = "往路4：出発地（依頼）"
        Public Const TT_ReqOutBoundArrival4__c As String = "往路4：到着地（依頼）"
        Public Const TT_ReqOutBoundDepartureTime4__c As String = "往路4：出発時間（依頼）"
        Public Const TT_ReqOutBoundArrivalTime4__c As String = "往路4：到着時間（依頼）"
        Public Const TT_ReqOutBoundTrainName4__c As String = "往路4：列車名・便名（依頼）"
        Public Const TT_ReqOutBoundSeatClass4__c As String = "往路4：座席区分（依頼）"
        Public Const TT_ReqOutBoundSeat4__c As String = "往路4：座席希望（依頼）"
        Public Const TT_ReqOutBound5__c As String = "往路5：希望する（依頼）"
        Public Const TT_ReqOutBoundStatus5__c As String = "往路5：依頼内容（依頼）"
        Public Const TT_ReqOutBoundTransport5__c As String = "往路5：交通機関（依頼）"
        Public Const TT_ReqOutBoundDate5__c As String = "往路5：利用日（依頼）"
        Public Const TT_ReqOutBoundDeparture5__c As String = "往路5：出発地（依頼）"
        Public Const TT_ReqOutBoundArrival5__c As String = "往路5：到着地（依頼）"
        Public Const TT_ReqOutBoundDepartureTime5__c As String = "往路5：出発時間（依頼）"
        Public Const TT_ReqOutBoundArrivalTime5__c As String = "往路5：到着時間（依頼）"
        Public Const TT_ReqOutBoundTrainName5__c As String = "往路5：列車名・便名（依頼）"
        Public Const TT_ReqOutBoundSeatClass5__c As String = "往路5：座席区分（依頼）"
        Public Const TT_ReqOutBoundSeat5__c As String = "往路5：座席希望（依頼）"
        Public Const TT_ReqInBound1__c As String = "復路1：希望する（依頼）"
        Public Const TT_ReqInBoundStatus1__c As String = "復路1：依頼内容（依頼）"
        Public Const TT_ReqInBoundTransport1__c As String = "復路1：交通機関（依頼）"
        Public Const TT_ReqInBoundDate1__c As String = "復路1：利用日（依頼）"
        Public Const TT_ReqInBoundDeparture1__c As String = "復路1：出発地（依頼）"
        Public Const TT_ReqInBoundArrival1__c As String = "復路1：到着地（依頼）"
        Public Const TT_ReqInBoundDepartureTime1__c As String = "復路1：出発時間（依頼）"
        Public Const TT_ReqInBoundArrivalTime1__c As String = "復路1：到着時間（依頼）"
        Public Const TT_ReqInBoundTrainName1__c As String = "復路1：列車名・便名（依頼）"
        Public Const TT_ReqInBoundSeatClass1__c As String = "復路1：座席区分（依頼）"
        Public Const TT_ReqInBoundSeat1__c As String = "復路1：座席希望（依頼）"
        Public Const TT_ReqInBound2__c As String = "復路2：希望する（依頼）"
        Public Const TT_ReqInBoundStatus2__c As String = "復路2：依頼内容（依頼）"
        Public Const TT_ReqInBoundTransport2__c As String = "復路2：交通機関（依頼）"
        Public Const TT_ReqInBoundDate2__c As String = "復路2：利用日（依頼）"
        Public Const TT_ReqInBoundDeparture2__c As String = "復路2：出発地（依頼）"
        Public Const TT_ReqInBoundArrival2__c As String = "復路2：到着地（依頼）"
        Public Const TT_ReqInBoundDepartureTime2__c As String = "復路2：出発時間（依頼）"
        Public Const TT_ReqInBoundArrivalTime2__c As String = "復路2：到着時間（依頼）"
        Public Const TT_ReqInBoundTrainName2__c As String = "復路2：列車名・便名（依頼）"
        Public Const TT_ReqInBoundSeatClass2__c As String = "復路2：座席区分（依頼）"
        Public Const TT_ReqInBoundSeat2__c As String = "復路2：座席希望（依頼）"
        Public Const TT_ReqInBound3__c As String = "復路3：希望する（依頼）"
        Public Const TT_ReqInBoundStatus3__c As String = "復路3：依頼内容（依頼）"
        Public Const TT_ReqInBoundTransport3__c As String = "復路3：交通機関（依頼）"
        Public Const TT_ReqInBoundDate3__c As String = "復路3：利用日（依頼）"
        Public Const TT_ReqInBoundDeparture3__c As String = "復路3：出発地（依頼）"
        Public Const TT_ReqInBoundArrival3__c As String = "復路3：到着地（依頼）"
        Public Const TT_ReqInBoundDepartureTime3__c As String = "復路3：出発時間（依頼）"
        Public Const TT_ReqInBoundArrivalTime3__c As String = "復路3：到着時間（依頼）"
        Public Const TT_ReqInBoundTrainName3__c As String = "復路3：列車名・便名（依頼）"
        Public Const TT_ReqInBoundSeatClass3__c As String = "復路3：座席区分（依頼）"
        Public Const TT_ReqInBoundSeat3__c As String = "復路3：座席希望（依頼）"
        Public Const TT_ReqInBound4__c As String = "復路4：希望する（依頼）"
        Public Const TT_ReqInBoundStatus4__c As String = "復路4：依頼内容（依頼）"
        Public Const TT_ReqInBoundTransport4__c As String = "復路4：交通機関（依頼）"
        Public Const TT_ReqInBoundDate4__c As String = "復路4：利用日（依頼）"
        Public Const TT_ReqInBoundDeparture4__c As String = "復路4：出発地（依頼）"
        Public Const TT_ReqInBoundArrival4__c As String = "復路4：到着地（依頼）"
        Public Const TT_ReqInBoundDepartureTime4__c As String = "復路4：出発時間（依頼）"
        Public Const TT_ReqInBoundArrivalTime4__c As String = "復路4：到着時間（依頼）"
        Public Const TT_ReqInBoundTrainName4__c As String = "復路4：列車名・便名（依頼）"
        Public Const TT_ReqInBoundSeatClass4__c As String = "復路4：座席区分（依頼）"
        Public Const TT_ReqInBoundSeat4__c As String = "復路4：座席希望（依頼）"
        Public Const TT_ReqInBound5__c As String = "復路5：希望する（依頼）"
        Public Const TT_ReqInBoundStatus5__c As String = "復路5：依頼内容（依頼）"
        Public Const TT_ReqInBoundTransport5__c As String = "復路5：交通機関（依頼）"
        Public Const TT_ReqInBoundDate5__c As String = "復路5：利用日（依頼）"
        Public Const TT_ReqInBoundDeparture5__c As String = "復路5：出発地（依頼）"
        Public Const TT_ReqInBoundArrival5__c As String = "復路5：到着地（依頼）"
        Public Const TT_ReqInBoundDepartureTime5__c As String = "復路5：出発時間（依頼）"
        Public Const TT_ReqInBoundArrivalTime5__c As String = "復路5：到着時間（依頼）"
        Public Const TT_ReqInBoundTrainName5__c As String = "復路5：列車名・便名（依頼）"
        Public Const TT_ReqInBoundSeatClass5__c As String = "復路5：座席区分（依頼）"
        Public Const TT_ReqInBoundSeat5__c As String = "復路5：座席希望（依頼）"
        Public Const TT_ReqRemarksTraffic__c As String = "交通備考（依頼）"
        Public Const TT_ReqTaxi__c As String = "タクシーチケット（有・無）"
        Public Const TT_ReqTaxiDate1__c As String = "行程1：利用日（依頼）"
        Public Const TT_ReqTaxiArrival1__c As String = "行程1：発地（依頼）"
        Public Const TT_ReqTaxiAmount1__c As String = "行程1：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate2__c As String = "行程2：利用日（依頼）"
        Public Const TT_ReqTaxiArrival2__c As String = "行程2：発地（依頼）"
        Public Const TT_ReqTaxiAmount2__c As String = "行程2：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate3__c As String = "行程3：利用日（依頼）"
        Public Const TT_ReqTaxiArrival3__c As String = "行程3：発地（依頼）"
        Public Const TT_ReqTaxiAmount3__c As String = "行程3：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate4__c As String = "行程4：利用日（依頼）"
        Public Const TT_ReqTaxiArrival4__c As String = "行程4：発地（依頼）"
        Public Const TT_ReqTaxiAmount4__c As String = "行程4：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate5__c As String = "行程5：利用日（依頼）"
        Public Const TT_ReqTaxiArrival5__c As String = "行程5：発地（依頼）"
        Public Const TT_ReqTaxiAmount5__c As String = "行程5：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate6__c As String = "行程6：利用日（依頼）"
        Public Const TT_ReqTaxiArrival6__c As String = "行程6：発地（依頼）"
        Public Const TT_ReqTaxiAmount6__c As String = "行程6：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate7__c As String = "行程7：利用日（依頼）"
        Public Const TT_ReqTaxiArrival7__c As String = "行程7：発地（依頼）"
        Public Const TT_ReqTaxiAmount7__c As String = "行程7：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate8__c As String = "行程8：利用日（依頼）"
        Public Const TT_ReqTaxiArrival8__c As String = "行程8：発地（依頼）"
        Public Const TT_ReqTaxiAmount8__c As String = "行程8：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate9__c As String = "行程9：利用日（依頼）"
        Public Const TT_ReqTaxiArrival9__c As String = "行程9：発地（依頼）"
        Public Const TT_ReqTaxiAmount9__c As String = "行程9：依頼金額（依頼）"
        Public Const TT_ReqTaxiDate10__c As String = "行程10：利用日（依頼）"
        Public Const TT_ReqTaxiArrival10__c As String = "行程10：発地（依頼）"
        Public Const TT_ReqTaxiAmount10__c As String = "行程10：依頼金額（依頼）"
        Public Const TT_ReqTaxiRemarks__c As String = "タクチケ備考（依頼）"
        Public Const TT_ReqEmployeeOutBound__c As String = "社員用往路臨席希望（依頼）"
        Public Const TT_ReqEmployeeInBound__c As String = "社員用復路臨席希望（依頼）"
        Public Const TT_ReqEmployeeSex__c As String = "MR性別（航空券の場合）"
        Public Const TT_ReqEmployeeAge__c As String = "MR年齢（航空券の場合）"
        Public Const TT_ReqEmployeeStay__c As String = "社員用宿泊希望（有・無）"
        Public Const TT_ReqEmployeeStaySmorking__c As String = "社員用宿泊　（禁煙・喫煙）"
        Public Const TT_ReqEmployeeStayRemarks__c As String = "社員用交通・宿泊備考"
        Public Const TT_Attendance__c As String = "参加/不参加"
        Public Const TT_StatusRequest__c As String = "連携ステータス(Request)"
        Public Const TT_StatusRequestActual__c As String = "出欠情報連携ステータス(Request)"
        Public Const TT_LastModifiedDate__c As String = "TT連携用最終更新日"
        Public Const MeetingDivision__c As String = "会合種別"
        Public Const Invalid__c As String = "無効"
        Public Const CreatedDate As String = "作成日時"
        Public Const LastModifiedDate As String = "最終更新日時"
    End Class
#End Region

    Public Sub New()
        MyBase.New(pbatchID)
    End Sub

    Public Overrides Sub run()

        Dim receiveFiles() As String = Directory.GetFiles(My.Settings.PATH_RECEIVE)

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(My.Settings.PATH_WORK) Then Directory.CreateDirectory(My.Settings.PATH_WORK)
        If Not Directory.Exists(My.Settings.PATH_RECEIVE_BKUP) Then Directory.CreateDirectory(My.Settings.PATH_RECEIVE_BKUP)

        '受信フォルダ→作業フォルダへコピー
        '受信フォルダからファイルを削除
        For Each motofile As String In receiveFiles
            If motofile.ToLower.IndexOf(My.Settings.FILE_NAME.ToLower) >= 0 Then
                File.Copy(motofile, My.Settings.PATH_WORK & "\" & Path.GetFileName(motofile))
                File.Delete(motofile)
            End If
        Next

        Dim workFiles() As String = Directory.GetFiles(My.Settings.PATH_WORK)
        If workFiles.Length = 0 Then
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, "処理対象ファイルがありません。")
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント
        For Each filePath As String In workFiles
            ImportData(filePath, insCnt)
        Next

        InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, insCnt.ToString & "件のデータを登録しました。")

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        For Each filePath As String In workFiles
            File.Copy(filePath, My.Settings.PATH_RECEIVE_BKUP & "\" & Path.GetFileName(filePath))
            File.Delete(filePath)
        Next

    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("UTF-8"))
        Else
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.OK, strFilePath & "が見つかりません。")
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        Dim strNgMoji As String = My.Settings.NG_MOJI
        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            If CheckInput(fileData, strFileName, rowCnt.ToString, strNgMoji) Then
                insCnt += InsertTable(fileData)
            End If

        End While

        'インスタンス開放
        parser.Dispose()

    End Function

    '入力チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, _
                                ByVal strNGMoji As String) As Boolean

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                Throw New Exception("項目数が不正です。")
            End If

            '必須入力チェック
            If fileData(COL_NO.Id).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Id & "がセットされていません。")
            End If

            If fileData(COL_NO.Name).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.Name & "がセットされていません。")
            End If

            If fileData(COL_NO.MeetingNo__c).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.MeetingNo__c & "がセットされていません。")
            End If

            If fileData(COL_NO.TT_TimestampBYL__c).Trim.Equals(String.Empty) Then
                Throw New Exception(COL_NAME.TT_TimestampBYL__c & "がセットされていません。")
            End If

            '禁則文字チェック
            If Not strNGMoji.Equals(String.Empty) Then
                Dim chkMoji() As String = strNGMoji.Split(",")
                For Each colData As String In fileData
                    For Each moji As String In chkMoji
                        If colData.Contains(moji) Then
                            Throw New Exception("禁則文字[" & moji & "]が含まれています。")
                        End If
                    Next
                Next
            End If

        Catch ex As Exception
            Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, strErrMsg)
            Return False
        End Try

        Return True

    End Function

    'ログテーブル登録処理
    Private Sub InsertTBL_LOG(ByVal status As String, ByVal strMsg As String, Optional ByVal tableName As String = "", Optional ByVal strSQL As String = "")

        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct
        TBL_LOG.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_LOG.INPUT_USER = pbatchID
        TBL_LOG.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.BATCH
        TBL_LOG.SYORI_NAME = "交通宿泊手配依頼ファイル取込"
        TBL_LOG.TABLE_NAME = tableName
        TBL_LOG.STATUS = status
        TBL_LOG.NOTE = strMsg

        CmnDbBatch.Execute(SQL.TBL_LOG.Insert(TBL_LOG), MyBase.DbConnection, MyBase.DbTransaction)

        'ログファイル出力
        MyBase.WriteInfoLog(strMsg & " " & strSQL)

    End Sub

    'データ登録
    Private Function InsertTable(ByVal fileData As String()) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct

        Try
            TBL_KOTSUHOTEL = SetInsData(fileData)
            strSQL = SQL.TBL_KOTSUHOTEL.Insert(TBL_KOTSUHOTEL)
            insCnt = CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

        Catch ex As Exception
            'ログテーブルに登録
            InsertTBL_LOG(AppConst.TBL_LOG.STATUS.Code.NG, "[データ登録失敗]" & ex.Message, "TBL_KOTSUHOTEL", " SQL:" & strSQL)
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    '登録内容をセットする
    Private Function SetInsData(ByVal fileData As String()) As TableDef.TBL_KOTSUHOTEL.DataStruct

        Dim TBL_KOTSUHOTEL_Ins As New TableDef.TBL_KOTSUHOTEL.DataStruct

        'TODO:ダブルクォート囲みのとき、またダブルクォートのエスケープの仕様が確定したら処理追加

        'TODO:ファイル項目が確定次第セットする値を修正する

        TBL_KOTSUHOTEL_Ins.SALEFORCE_ID = fileData(COL_NO.Id)
        TBL_KOTSUHOTEL_Ins.SANKASHA_ID = fileData(COL_NO.Name)
        TBL_KOTSUHOTEL_Ins.KOUENKAI_NO = fileData(COL_NO.MeetingNo__c)
        TBL_KOTSUHOTEL_Ins.REQ_STATUS_TEHAI = fileData(COL_NO.TT_ArrangeStatusRequest__c)
        'TODO:要確認
        TBL_KOTSUHOTEL_Ins.ANS_STATUS_TEHAI = "1"
        TBL_KOTSUHOTEL_Ins.TIME_STAMP_BYL = fileData(COL_NO.TT_TimestampBYL__c)
        TBL_KOTSUHOTEL_Ins.TIME_STAMP_TOP = fileData(COL_NO.TT_TimestampTOP__c)
        TBL_KOTSUHOTEL_Ins.DR_MPID = fileData(COL_NO.Name)
        TBL_KOTSUHOTEL_Ins.DR_CD = fileData(COL_NO.TT_DoctorCode__c)
        TBL_KOTSUHOTEL_Ins.DR_NAME = fileData(COL_NO.TT_DoctorName__c)
        TBL_KOTSUHOTEL_Ins.DR_KANA = fileData(COL_NO.TT_DoctorNameKana__c)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_CD = fileData(COL_NO.TT_DoctorInstituteCode__c)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_NAME = fileData(COL_NO.TT_DoctorInstituteName__c)
        TBL_KOTSUHOTEL_Ins.DR_SHISETSU_ADDRESS = fileData(COL_NO.TT_DoctorInstituteAddress__c)
        TBL_KOTSUHOTEL_Ins.DR_YAKUWARI = fileData(COL_NO.TT_DoctorPart__c)
        TBL_KOTSUHOTEL_Ins.DR_SEX = fileData(COL_NO.TT_DoctorSex__c)
        TBL_KOTSUHOTEL_Ins.DR_AGE = fileData(COL_NO.TT_DoctorAge__c)
        TBL_KOTSUHOTEL_Ins.SHITEIGAI_RIYU = fileData(COL_NO.TT_ReasonOutSpec__c)
        TBL_KOTSUHOTEL_Ins.DR_SANKA = ""
        TBL_KOTSUHOTEL_Ins.MR_BU = fileData(COL_NO.TT_ContactPersonBU_NameEN__c)
        TBL_KOTSUHOTEL_Ins.MR_AREA = fileData(COL_NO.TT_ContactPersonAreaName__c)
        TBL_KOTSUHOTEL_Ins.MR_EIGYOSHO = fileData(COL_NO.TT_ContactPersonFS_Name__c)
        TBL_KOTSUHOTEL_Ins.MR_NAME = fileData(COL_NO.TT_ContactPersonNameKanji__c)
        TBL_KOTSUHOTEL_Ins.MR_ROMA = fileData(COL_NO.TT_ContactPersonName__c)
        TBL_KOTSUHOTEL_Ins.MR_EMAIL_PC = fileData(COL_NO.TT_ContactPersonEmail__c)
        TBL_KOTSUHOTEL_Ins.MR_EMAIL_KEITAI = fileData(COL_NO.TT_ContactPersonMobileMail__c)
        TBL_KOTSUHOTEL_Ins.MR_KEITAI = fileData(COL_NO.TT_ContactPersonMobile__c)
        TBL_KOTSUHOTEL_Ins.MR_TEL = fileData(COL_NO.TT_ContactPersonPhone__c)
        TBL_KOTSUHOTEL_Ins.MR_SEND_SAKI_FS = fileData(COL_NO.TT_SendFS__c)
        TBL_KOTSUHOTEL_Ins.MR_SEND_SAKI_OTHER = fileData(COL_NO.TT_SendFS_Other__c)
        TBL_KOTSUHOTEL_Ins.ACCOUNT_CD = fileData(COL_NO.TT_AccountCode__c)
        TBL_KOTSUHOTEL_Ins.COST_CENTER = fileData(COL_NO.TT_CostCenter__c)
        TBL_KOTSUHOTEL_Ins.INTERNAL_ORDER = fileData(COL_NO.TT_InternalOrder__c)
        TBL_KOTSUHOTEL_Ins.ZETIA_CD = fileData(COL_NO.TT_ZetiaCode__c)
        TBL_KOTSUHOTEL_Ins.SHONIN_NAME = fileData(COL_NO.TT_LastApprovalUserName__c)
        TBL_KOTSUHOTEL_Ins.SHONIN_DATE = fileData(COL_NO.TT_LastApprovalDate__c)
        TBL_KOTSUHOTEL_Ins.TEHAI_HOTEL = fileData(COL_NO.TT_ReqStay__c)
        TBL_KOTSUHOTEL_Ins.HOTEL_IRAINAIYOU = fileData(COL_NO.TT_ReqStayStatus__c)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_DATE = fileData(COL_NO.TT_ReqStayDate__c)
        TBL_KOTSUHOTEL_Ins.REQ_HAKUSU = fileData(COL_NO.TT_ReqStayNumber__c)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_SMOKING = fileData(COL_NO.TT_ReqStaySmoking__c)
        TBL_KOTSUHOTEL_Ins.REQ_HOTEL_NOTE = fileData(COL_NO.TT_ReqStayRemarks__c)
        TBL_KOTSUHOTEL_Ins.ANS_STATUS_HOTEL = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NAME = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_ADDRESS = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_TEL = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_DATE = ""
        TBL_KOTSUHOTEL_Ins.ANS_HAKUSU = ""
        TBL_KOTSUHOTEL_Ins.ANS_CHECKIN_TIME = ""
        TBL_KOTSUHOTEL_Ins.ANS_CHECKOUT_TIME = ""
        TBL_KOTSUHOTEL_Ins.ANS_ROOM_TYPE = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_SMOKING = ""
        TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NOTE = ""
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_1 = fileData(COL_NO.TT_ReqOutBound1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_1 = fileData(COL_NO.TT_ReqOutBoundStatus1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_1 = fileData(COL_NO.TT_ReqOutBoundTransport1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_1 = fileData(COL_NO.TT_ReqOutBoundDate1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_1 = fileData(COL_NO.TT_ReqOutBoundDeparture1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_1 = fileData(COL_NO.TT_ReqOutBoundArrival1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_1 = fileData(COL_NO.TT_ReqOutBoundDepartureTime1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_1 = fileData(COL_NO.TT_ReqOutBoundArrivalTime1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_1 = fileData(COL_NO.TT_ReqOutBoundTrainName1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_1 = fileData(COL_NO.TT_ReqOutBoundSeatClass1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU1 = fileData(COL_NO.TT_ReqOutBoundSeat1__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_2 = fileData(COL_NO.TT_ReqOutBound2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_2 = fileData(COL_NO.TT_ReqOutBoundStatus2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_2 = fileData(COL_NO.TT_ReqOutBoundTransport2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_2 = fileData(COL_NO.TT_ReqOutBoundDate2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_2 = fileData(COL_NO.TT_ReqOutBoundDeparture2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_2 = fileData(COL_NO.TT_ReqOutBoundArrival2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_2 = fileData(COL_NO.TT_ReqOutBoundDepartureTime2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_2 = fileData(COL_NO.TT_ReqOutBoundArrivalTime2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_2 = fileData(COL_NO.TT_ReqOutBoundTrainName2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_2 = fileData(COL_NO.TT_ReqOutBoundSeatClass2_c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU2 = fileData(COL_NO.TT_ReqOutBoundSeat2__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_3 = fileData(COL_NO.TT_ReqOutBound3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_3 = fileData(COL_NO.TT_ReqOutBoundStatus3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_3 = fileData(COL_NO.TT_ReqOutBoundTransport3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_3 = fileData(COL_NO.TT_ReqOutBoundDate3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_3 = fileData(COL_NO.TT_ReqOutBoundDeparture3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_3 = fileData(COL_NO.TT_ReqOutBoundArrival3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_3 = fileData(COL_NO.TT_ReqOutBoundDepartureTime3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_3 = fileData(COL_NO.TT_ReqOutBoundArrivalTime3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_3 = fileData(COL_NO.TT_ReqOutBoundTrainName3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_3 = fileData(COL_NO.TT_ReqOutBoundSeatClass3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU3 = fileData(COL_NO.TT_ReqOutBoundSeat3__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_4 = fileData(COL_NO.TT_ReqOutBound4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_4 = fileData(COL_NO.TT_ReqOutBoundStatus4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_4 = fileData(COL_NO.TT_ReqOutBoundTransport4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_4 = fileData(COL_NO.TT_ReqOutBoundDate4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_4 = fileData(COL_NO.TT_ReqOutBoundDeparture4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_4 = fileData(COL_NO.TT_ReqOutBoundArrival4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_4 = fileData(COL_NO.TT_ReqOutBoundDepartureTime4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_4 = fileData(COL_NO.TT_ReqOutBoundArrivalTime4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_4 = fileData(COL_NO.TT_ReqOutBoundTrainName4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_4 = fileData(COL_NO.TT_ReqOutBoundSeatClass4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU4 = fileData(COL_NO.TT_ReqOutBoundSeat4__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TEHAI_5 = fileData(COL_NO.TT_ReqOutBound5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_IRAINAIYOU_5 = fileData(COL_NO.TT_ReqOutBoundStatus5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_KOTSUKIKAN_5 = fileData(COL_NO.TT_ReqOutBoundTransport5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_DATE_5 = fileData(COL_NO.TT_ReqOutBoundDate5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT1_5 = fileData(COL_NO.TT_ReqOutBoundDeparture5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_AIRPORT2_5 = fileData(COL_NO.TT_ReqOutBoundArrival5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME1_5 = fileData(COL_NO.TT_ReqOutBoundDepartureTime5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_TIME2_5 = fileData(COL_NO.TT_ReqOutBoundArrivalTime5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_BIN_5 = fileData(COL_NO.TT_ReqOutBoundTrainName5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_5 = fileData(COL_NO.TT_ReqOutBoundSeatClass5__c)
        TBL_KOTSUHOTEL_Ins.REQ_O_SEAT_KIBOU5 = fileData(COL_NO.TT_ReqOutBoundSeat5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_1 = fileData(COL_NO.TT_ReqInBound1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_1 = fileData(COL_NO.TT_ReqInBoundStatus1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_1 = fileData(COL_NO.TT_ReqInBoundTransport1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_1 = fileData(COL_NO.TT_ReqInBoundDate1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_1 = fileData(COL_NO.TT_ReqInBoundDeparture1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_1 = fileData(COL_NO.TT_ReqInBoundArrival1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_1 = fileData(COL_NO.TT_ReqInBoundDepartureTime1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_1 = fileData(COL_NO.TT_ReqInBoundArrivalTime1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_1 = fileData(COL_NO.TT_ReqInBoundTrainName1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_1 = fileData(COL_NO.TT_ReqInBoundSeatClass1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU1 = fileData(COL_NO.TT_ReqInBoundSeat1__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_2 = fileData(COL_NO.TT_ReqInBound2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_2 = fileData(COL_NO.TT_ReqInBoundStatus2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_2 = fileData(COL_NO.TT_ReqInBoundTransport2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_2 = fileData(COL_NO.TT_ReqInBoundDate2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_2 = fileData(COL_NO.TT_ReqInBoundDeparture2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_2 = fileData(COL_NO.TT_ReqInBoundArrival2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_2 = fileData(COL_NO.TT_ReqInBoundDepartureTime2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_2 = fileData(COL_NO.TT_ReqInBoundArrivalTime2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_2 = fileData(COL_NO.TT_ReqInBoundTrainName2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_2 = fileData(COL_NO.TT_ReqInBoundSeatClass2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU2 = fileData(COL_NO.TT_ReqInBoundSeat2__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_3 = fileData(COL_NO.TT_ReqInBound3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_3 = fileData(COL_NO.TT_ReqInBoundStatus3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_3 = fileData(COL_NO.TT_ReqInBoundTransport3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_3 = fileData(COL_NO.TT_ReqInBoundDate3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_3 = fileData(COL_NO.TT_ReqInBoundDeparture3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_3 = fileData(COL_NO.TT_ReqInBoundArrival3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_3 = fileData(COL_NO.TT_ReqInBoundDepartureTime3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_3 = fileData(COL_NO.TT_ReqInBoundArrivalTime3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_3 = fileData(COL_NO.TT_ReqInBoundTrainName3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_3 = fileData(COL_NO.TT_ReqInBoundSeatClass3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU3 = fileData(COL_NO.TT_ReqInBoundSeat3__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_4 = fileData(COL_NO.TT_ReqInBound4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_4 = fileData(COL_NO.TT_ReqInBoundStatus4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_4 = fileData(COL_NO.TT_ReqInBoundTransport4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_4 = fileData(COL_NO.TT_ReqInBoundDate4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_4 = fileData(COL_NO.TT_ReqInBoundDeparture4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_4 = fileData(COL_NO.TT_ReqInBoundArrival4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_4 = fileData(COL_NO.TT_ReqInBoundDepartureTime4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_4 = fileData(COL_NO.TT_ReqInBoundArrivalTime4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_4 = fileData(COL_NO.TT_ReqInBoundTrainName4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_4 = fileData(COL_NO.TT_ReqInBoundSeatClass4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU4 = fileData(COL_NO.TT_ReqInBoundSeat4__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TEHAI_5 = fileData(COL_NO.TT_ReqInBound5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_IRAINAIYOU_5 = fileData(COL_NO.TT_ReqInBoundStatus5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_KOTSUKIKAN_5 = fileData(COL_NO.TT_ReqInBoundTransport5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_DATE_5 = fileData(COL_NO.TT_ReqInBoundDate5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT1_5 = fileData(COL_NO.TT_ReqInBoundDeparture5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_AIRPORT2_5 = fileData(COL_NO.TT_ReqInBoundArrival5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME1_5 = fileData(COL_NO.TT_ReqInBoundDepartureTime5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_TIME2_5 = fileData(COL_NO.TT_ReqInBoundArrivalTime5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_BIN_5 = fileData(COL_NO.TT_ReqInBoundTrainName5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_5 = fileData(COL_NO.TT_ReqInBoundSeatClass5__c)
        TBL_KOTSUHOTEL_Ins.REQ_F_SEAT_KIBOU5 = fileData(COL_NO.TT_ReqInBoundSeat5__c)
        TBL_KOTSUHOTEL_Ins.REQ_KOTSU_BIKO = fileData(COL_NO.TT_ReqRemarksTraffic__c)
        TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_DATE_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_BIN_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_1 = ""
        TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU1 = ""
        
        TBL_KOTSUHOTEL_Ins.TEHAI_TAXI = fileData(COL_NO.TT_ReqTaxi__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_1 = fileData(COL_NO.TT_ReqTaxiDate1__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_1 = fileData(COL_NO.TT_ReqTaxiArrival1__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_1 = fileData(COL_NO.TT_ReqTaxiAmount1__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_2 = fileData(COL_NO.TT_ReqTaxiDate2__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_2 = fileData(COL_NO.TT_ReqTaxiArrival2__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_2 = fileData(COL_NO.TT_ReqTaxiAmount2__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_3 = fileData(COL_NO.TT_ReqTaxiDate3__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_3 = fileData(COL_NO.TT_ReqTaxiArrival3__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_3 = fileData(COL_NO.TT_ReqTaxiAmount3__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_4 = fileData(COL_NO.TT_ReqTaxiDate4__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_4 = fileData(COL_NO.TT_ReqTaxiArrival4__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_4 = fileData(COL_NO.TT_ReqTaxiAmount4__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_5 = fileData(COL_NO.TT_ReqTaxiDate5__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_5 = fileData(COL_NO.TT_ReqTaxiArrival5__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_5 = fileData(COL_NO.TT_ReqTaxiAmount5__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_6 = fileData(COL_NO.TT_ReqTaxiDate6__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_6 = fileData(COL_NO.TT_ReqTaxiArrival6__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_6 = fileData(COL_NO.TT_ReqTaxiAmount6__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_7 = fileData(COL_NO.TT_ReqTaxiDate7__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_7 = fileData(COL_NO.TT_ReqTaxiArrival7__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_7 = fileData(COL_NO.TT_ReqTaxiAmount7__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_8 = fileData(COL_NO.TT_ReqTaxiDate8__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_8 = fileData(COL_NO.TT_ReqTaxiArrival8__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_8 = fileData(COL_NO.TT_ReqTaxiAmount8__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_9 = fileData(COL_NO.TT_ReqTaxiDate9__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_9 = fileData(COL_NO.TT_ReqTaxiArrival9__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_9 = fileData(COL_NO.TT_ReqTaxiAmount9__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_DATE_10 = fileData(COL_NO.TT_ReqTaxiDate10__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_FROM_10 = fileData(COL_NO.TT_ReqTaxiArrival10__c)
        TBL_KOTSUHOTEL_Ins.TAXI_YOTEIKINGAKU_10 = fileData(COL_NO.TT_ReqTaxiAmount10__c)
        TBL_KOTSUHOTEL_Ins.REQ_TAXI_NOTE = fileData(COL_NO.TT_ReqTaxiRemarks__c)
        
        TBL_KOTSUHOTEL_Ins.REQ_MR_O_TEHAI = fileData(COL_NO.TT_ReqEmployeeOutBound__c)
        TBL_KOTSUHOTEL_Ins.REQ_MR_F_TEHAI = fileData(COL_NO.TT_ReqEmployeeInBound__c)
        TBL_KOTSUHOTEL_Ins.MR_SEX = fileData(COL_NO.TT_ReqEmployeeSex__c)
        TBL_KOTSUHOTEL_Ins.MR_AGE = fileData(COL_NO.TT_ReqEmployeeAge__c)
        TBL_KOTSUHOTEL_Ins.REQ_MR_TEHAI_HOTEL = fileData(COL_NO.TT_ReqEmployeeStay__c)
        TBL_KOTSUHOTEL_Ins.REQ_MR_HOTEL_SMOKING = fileData(COL_NO.TT_ReqEmployeeStaySmorking__c)
        TBL_KOTSUHOTEL_Ins.REQ_MR_HOTEL_NOTE = fileData(COL_NO.TT_ReqEmployeeStayRemarks__c)
        
        TBL_KOTSUHOTEL_Ins.SEND_FLAG = AppConst.SEND_FLAG.Code.Mi

        TBL_KOTSUHOTEL_Ins.INPUT_USER = pbatchID
        TBL_KOTSUHOTEL_Ins.UPDATE_USER = pbatchID
        TBL_KOTSUHOTEL_Ins.SEND_DATE = ""

        '同一キーのデータを検索
        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct = GetData(fileData(COL_NO.Name), fileData(COL_NO.MeetingNo__c))

        If Not TBL_KOTSUHOTEL Is Nothing Then
            '該当データがあるとき
            Dim idx As Integer = GetLastData(TBL_KOTSUHOTEL)

            TBL_KOTSUHOTEL_Ins.ANS_STATUS_HOTEL = TBL_KOTSUHOTEL(idx).ANS_STATUS_HOTEL
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NAME = TBL_KOTSUHOTEL(idx).ANS_HOTEL_NAME
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_ADDRESS = TBL_KOTSUHOTEL(idx).ANS_HOTEL_ADDRESS
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_TEL = TBL_KOTSUHOTEL(idx).ANS_HOTEL_TEL
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_DATE = TBL_KOTSUHOTEL(idx).ANS_HOTEL_DATE
            TBL_KOTSUHOTEL_Ins.ANS_HAKUSU = TBL_KOTSUHOTEL(idx).ANS_HAKUSU
            TBL_KOTSUHOTEL_Ins.ANS_CHECKIN_TIME = TBL_KOTSUHOTEL(idx).ANS_CHECKIN_TIME
            TBL_KOTSUHOTEL_Ins.ANS_CHECKOUT_TIME = TBL_KOTSUHOTEL(idx).ANS_CHECKOUT_TIME
            TBL_KOTSUHOTEL_Ins.ANS_ROOM_TYPE = TBL_KOTSUHOTEL(idx).ANS_ROOM_TYPE
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_SMOKING = TBL_KOTSUHOTEL(idx).ANS_HOTEL_SMOKING
            TBL_KOTSUHOTEL_Ins.ANS_HOTEL_NOTE = TBL_KOTSUHOTEL(idx).ANS_HOTEL_NOTE

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_1 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_1
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_1 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_1
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_1 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_1
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_1 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_1
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_1 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_1
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_1 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_1
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_1 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_1
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_1 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_1
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU1 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU1

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_2 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_2
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_2 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_2
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_2 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_2
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_2 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_2
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_2 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_2
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_2 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_2
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_2 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_2
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_2 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_2
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU2 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU2

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_3 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_3
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_3 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_3
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_3 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_3
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_3 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_3
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_3 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_3
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_3 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_3
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_3 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_3
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_3 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_3
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU3 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU3

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_4 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_4
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_4 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_4
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_4 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_4
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_4 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_4
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_4 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_4
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_4 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_4
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_4 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_4
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_4 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_4
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU4 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU4

            TBL_KOTSUHOTEL_Ins.ANS_O_STATUS_5 = TBL_KOTSUHOTEL(idx).ANS_O_STATUS_5
            TBL_KOTSUHOTEL_Ins.ANS_O_KOTSUKIKAN_5 = TBL_KOTSUHOTEL(idx).ANS_O_KOTSUKIKAN_5
            TBL_KOTSUHOTEL_Ins.ANS_O_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_O_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT1_5 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT1_5
            TBL_KOTSUHOTEL_Ins.ANS_O_AIRPORT2_5 = TBL_KOTSUHOTEL(idx).ANS_O_AIRPORT2_5
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME1_5 = TBL_KOTSUHOTEL(idx).ANS_O_TIME1_5
            TBL_KOTSUHOTEL_Ins.ANS_O_TIME2_5 = TBL_KOTSUHOTEL(idx).ANS_O_TIME2_5
            TBL_KOTSUHOTEL_Ins.ANS_O_BIN_5 = TBL_KOTSUHOTEL(idx).ANS_O_BIN_5
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_5 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_5
            TBL_KOTSUHOTEL_Ins.ANS_O_SEAT_KIBOU5 = TBL_KOTSUHOTEL(idx).ANS_O_SEAT_KIBOU5

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_1 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_1
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_1 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_1
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_1 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_1
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_1 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_1
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_1 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_1
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_1 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_1
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_1 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_1
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_1 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_1
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU1 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU1

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_2 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_2
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_2 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_2
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_2 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_2
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_2 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_2
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_2 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_2
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_2 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_2
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_2 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_2
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_2 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_2
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU2 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU2

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_3 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_3
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_3 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_3
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_3 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_3
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_3 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_3
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_3 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_3
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_3 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_3
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_3 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_3
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_3 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_3
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU3 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU3

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_4 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_4
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_4 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_4
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_4 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_4
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_4 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_4
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_4 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_4
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_4 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_4
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_4 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_4
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_4 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_4
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU4 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU4

            TBL_KOTSUHOTEL_Ins.ANS_F_STATUS_5 = TBL_KOTSUHOTEL(idx).ANS_F_STATUS_5
            TBL_KOTSUHOTEL_Ins.ANS_F_KOTSUKIKAN_5 = TBL_KOTSUHOTEL(idx).ANS_F_KOTSUKIKAN_5
            TBL_KOTSUHOTEL_Ins.ANS_F_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_F_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT1_5 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT1_5
            TBL_KOTSUHOTEL_Ins.ANS_F_AIRPORT2_5 = TBL_KOTSUHOTEL(idx).ANS_F_AIRPORT2_5
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME1_5 = TBL_KOTSUHOTEL(idx).ANS_F_TIME1_5
            TBL_KOTSUHOTEL_Ins.ANS_F_TIME2_5 = TBL_KOTSUHOTEL(idx).ANS_F_TIME2_5
            TBL_KOTSUHOTEL_Ins.ANS_F_BIN_5 = TBL_KOTSUHOTEL(idx).ANS_F_BIN_5
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_5 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_5
            TBL_KOTSUHOTEL_Ins.ANS_F_SEAT_KIBOU5 = TBL_KOTSUHOTEL(idx).ANS_F_SEAT_KIBOU5

            TBL_KOTSUHOTEL_Ins.ANS_KOTSU_BIKO = TBL_KOTSUHOTEL(idx).ANS_KOTSU_BIKO

            TBL_KOTSUHOTEL_Ins.ANS_RAIL_FARE = TBL_KOTSUHOTEL(idx).ANS_RAIL_FARE
            TBL_KOTSUHOTEL_Ins.ANS_RAIL_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_RAIL_CANCELLATION
            TBL_KOTSUHOTEL_Ins.ANS_OTHER_FARE = TBL_KOTSUHOTEL(idx).ANS_OTHER_FARE
            TBL_KOTSUHOTEL_Ins.ANS_OTHER_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_OTHER_CANCELLATION
            TBL_KOTSUHOTEL_Ins.ANS_AIR_FARE = TBL_KOTSUHOTEL(idx).ANS_AIR_FARE
            TBL_KOTSUHOTEL_Ins.ANS_AIR_CANCELLATION = TBL_KOTSUHOTEL(idx).ANS_AIR_CANCELLATION

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_1
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_1 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_1

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_2
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_2 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_2

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_3
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_3 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_3

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_4
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_4 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_4

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_5
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_5 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_5

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_6
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_6 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_6

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_7
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_7 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_7

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_8
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_8 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_8

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_9
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_9 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_9

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_10
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_10 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_10

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_11
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_11 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_11

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_12
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_12 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_12

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_13
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_13 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_13

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_14
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_14 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_14

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_15
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_15 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_15

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_16
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_16 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_16

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_17
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_17 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_17

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_18
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_18 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_18

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_19
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_19 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_19

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_DATE_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_DATE_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_KENSHU_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_KENSHU_20
            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NO_20 = TBL_KOTSUHOTEL(idx).ANS_TAXI_NO_20

            TBL_KOTSUHOTEL_Ins.ANS_TAXI_NOTE = TBL_KOTSUHOTEL(idx).ANS_TAXI_NOTE

            TBL_KOTSUHOTEL_Ins.ANS_MR_O_TEHAI = TBL_KOTSUHOTEL(idx).ANS_MR_O_TEHAI
            TBL_KOTSUHOTEL_Ins.ANS_MR_F_TEHAI = TBL_KOTSUHOTEL(idx).ANS_MR_F_TEHAI
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NAME = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_NAME
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_ADDRESS = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_ADDRESS
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_TEL = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_TEL
            TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKIN_TIME = TBL_KOTSUHOTEL(idx).ANS_MR_CHECKIN_TIME
            TBL_KOTSUHOTEL_Ins.ANS_MR_CHECKOUT_TIME = TBL_KOTSUHOTEL(idx).ANS_MR_CHECKOUT_TIME
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_SMOKING = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_SMOKING
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTEL_NOTE = TBL_KOTSUHOTEL(idx).ANS_MR_HOTEL_NOTE
            TBL_KOTSUHOTEL_Ins.ANS_MR_KOTSUHI = TBL_KOTSUHOTEL(idx).ANS_MR_KOTSUHI
            TBL_KOTSUHOTEL_Ins.ANS_MR_HOTELHI = TBL_KOTSUHOTEL(idx).ANS_MR_HOTELHI

            TBL_KOTSUHOTEL_Ins.TTANTO_ID = TBL_KOTSUHOTEL(idx).TTANTO_ID
        End If

        Return TBL_KOTSUHOTEL_Ins

    End Function

    'TimeStamp以外のキーが同一のデータを検索
    Private Function GetData(ByVal strSankashaId As String, ByVal strKouenkaiNo As String) As TableDef.TBL_KOTSUHOTEL.DataStruct()

        Dim wCnt As Integer = 0

        Dim TBL_KOTSUHOTEL(wCnt) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wFlag As Boolean = False

        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID(strKouenkaiNo, strSankashaId)
        Dim RsData As System.Data.SqlClient.SqlDataReader = CmnDbBatch.Read(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KOTSUHOTEL(wCnt)

            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        If wFlag Then
            Return TBL_KOTSUHOTEL
        Else
            Return Nothing
        End If

    End Function

    '最新データがセットされている配列の添え字を取得する
    Private Function GetLastData(ByVal TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Integer
        Dim rowNo As Integer = 0
        Dim wCnt As Integer = 0

        For Each record As TableDef.TBL_KOTSUHOTEL.DataStruct In TBL_KOTSUHOTEL
            rowNo = wCnt
            wCnt += 1
        Next

        Return rowNo

    End Function

End Class
