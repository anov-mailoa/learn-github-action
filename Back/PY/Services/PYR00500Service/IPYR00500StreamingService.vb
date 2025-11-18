Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR00500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR00500StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getPivotData", ReplyAction:="getPivotData")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPivotData() As Message


    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PYR00500DTO))


End Interface
