Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR06900Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR06900StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR06900StreamingService

    <OperationContract(Action:="getCmbPaymentType", ReplyAction:="getCmbPaymentType")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPaymentType() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract(Action:="getSalaryGroupList", ReplyAction:="getSalaryGroupList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroupList() As Message

    <OperationContract(Action:="getCmbJabatan", ReplyAction:="getCmbJabatan")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbJabatan() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSptSetting(poParam As PYR06900DTO) As PYR06900DTO

    <OperationContract(Action:="getExportExcelHeader", ReplyAction:="getExportExcelHeader")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelHeader() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelData() As Message

End Interface
