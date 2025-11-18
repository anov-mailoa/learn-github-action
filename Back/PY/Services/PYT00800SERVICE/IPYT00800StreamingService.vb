Imports System.ServiceModel
Imports R_Common
Imports PYT00800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00800StreamingService

    <OperationContract(Action:="GetTransList", ReplyAction:="GetTransList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransList() As Message

    <OperationContract(Action:="GetTransDetail", ReplyAction:="GetTransDetail")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransDetail() As Message

    <OperationContract(Action:="getTransaction", ReplyAction:="getTransaction")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYT00800GridDTO))

End Interface
