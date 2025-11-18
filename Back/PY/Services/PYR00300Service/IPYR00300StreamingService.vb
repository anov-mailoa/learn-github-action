Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR00300StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam1 As List(Of PYR00300DTO))

End Interface
