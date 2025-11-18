Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR12100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR12100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR12100StreamingService

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

    <OperationContract(Action:="getProcess", ReplyAction:="getProcess")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getProcess() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportSize(pcCompId As String) As String

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PYR12100DTO))

End Interface
