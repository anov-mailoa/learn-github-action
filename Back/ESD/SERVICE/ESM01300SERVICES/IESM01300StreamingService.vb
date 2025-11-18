Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ESM01300Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01300StreamingService

#Region "Medical"

    <OperationContract(Action:="GetMedicalLimitListHD", ReplyAction:="GetMedicalLimitListHD")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalLimitListHD() As Message

    <OperationContract(Action:="GetMedicalLimitListDT", ReplyAction:="GetMedicalLimitListDT")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalLimitListDT() As Message

    <OperationContract(Action:="GetMedicalHistoryListHD", ReplyAction:="GetMedicalHistoryListHD")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalHistoryListHD() As Message

    <OperationContract(Action:="GetMedicalHistoryListDT", ReplyAction:="GetMedicalHistoryListDT")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalHistoryListDT() As Message


    '(MEDICAL)Reimbursement List
    <OperationContract(Action:="GetReimbursementList", ReplyAction:="GetReimbursementList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReimbursementList() As Message

    '(MEDICAL)Sub Item List
    <OperationContract(Action:="GetSubItemsList", ReplyAction:="GetSubItemsList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSubItemsList() As Message

#End Region

    <OperationContract(Action:="GetCmbYearList", ReplyAction:="GetCmbYearList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbYearList() As Message

    <OperationContract(Action:="GetCmbBoxList", ReplyAction:="GetCmbBoxList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbBoxList() As Message

#Region "Annual Salary Card"
    <OperationContract(Action:="GetAnnualSalaryList", ReplyAction:="GetAnnualSalaryList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetAnnualSalaryList() As Message

    <OperationContract(Action:="GetCmbAnnualSalaryYearList", ReplyAction:="GetCmbAnnualSalaryYearList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbAnnualSalaryYearList() As Message

#End Region

    'Salary Slip
    <OperationContract(Action:="GetCmbPeriodList", ReplyAction:="GetCmbPeriodList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbPeriodList() As Message

    <OperationContract(Action:="GetSalarySlipReportData", ReplyAction:="GetSalarySlipReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSalarySlipReportData() As Message

    'SPT 
    <OperationContract(Action:="GetSptYearList", ReplyAction:="GetSptYearList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSptYearList() As Message

    <OperationContract(Action:="GetSptReportData", ReplyAction:="GetSptReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSptReportData() As Message


    <OperationContract(Action:="GetCmbForWhomName", ReplyAction:="GetCmbForWhomName")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbForWhomName() As Message

    

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ParamDTO(ByVal poGridMedical As List(Of ESM01300MedicalGridDTO),
                 ByVal poGridReimbursement As List(Of ESM01300ReimbursementGridDTO))

#Region "Loan"
    <OperationContract(Action:="GetListLoan", ReplyAction:="GetListLoan")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListLoan() As Message

    <OperationContract(Action:="GetListOutstandingLoan", ReplyAction:="GetListOutstandingLoan")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListOutstandingLoan() As Message

    <OperationContract(Action:="GetListLoanSchedule", ReplyAction:="GetListLoanSchedule")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListLoanSchedule() As Message

    <OperationContract(Action:="GetInstallment", ReplyAction:="GetInstallment")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub GetInstallment()

    <OperationContract(Action:="getHeader", ReplyAction:="getHeader")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeader() As Message

    <OperationContract(Action:="getloanType", ReplyAction:="getloanType")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getloanType() As Message

    <OperationContract(Action:="Summary", ReplyAction:="Summary")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Summary() As Message


#End Region
End Interface
