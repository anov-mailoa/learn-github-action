Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR12000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR12000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR12000StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

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
    Sub Dummy(ByVal poParam As List(Of ATR12000DTO))

    <OperationContract(Action:="getExportExcelHeader", ReplyAction:="getExportExcelHeader")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelHeader() As Message
    '
End Interface
