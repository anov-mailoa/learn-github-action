Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR01500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR01500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR01500StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getPeriod", ReplyAction:="getPeriod")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriod() As Message

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PYR01500DTO))

End Interface
