Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR04500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR04500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR04500StreamingService

    <OperationContract(Action:="getPeriod", ReplyAction:="getPeriod")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriod() As Message

    <OperationContract(Action:="getBankTransferList", ReplyAction:="getBankTransferList")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getBankTransferList() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getSubReportData", ReplyAction:="getSubReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getSubReportData() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelData() As Message

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PYR04500DTO))


End Interface
