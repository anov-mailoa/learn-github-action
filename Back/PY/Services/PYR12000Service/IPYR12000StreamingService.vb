Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR12000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR12000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR12000StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getReportFooter", ReplyAction:="getReportFooter")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportFooter() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelData() As Message

    <OperationContract(Action:="getPeriod", ReplyAction:="getPeriod")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriod() As Message

    <OperationContract(Action:="getTemplateList", ReplyAction:="getTemplateList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getTemplateList() As Message

    <OperationContract(Action:="getProcess", ReplyAction:="getProcess")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getProcess() As Message

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PYR12000DTO))

    <OperationContract(Action:="getExportExcelHeader", ReplyAction:="getExportExcelHeader")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelHeader() As Message

    <OperationContract(Action:="getSalarySingle", ReplyAction:="getSalarySingle")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getSalarySingle() As Message

    <OperationContract(Action:="getPeriodSingle", ReplyAction:="getPeriodSingle")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriodSingle() As Message

End Interface
