Imports System.ServiceModel.Channels
Imports ATM00200Back
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00200StreamingService

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(poParam2 As List(Of ATM0020002DTO))

    <OperationContract(Action:="getATM00200List", ReplyAction:="getATM00200List")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getATM00200List() As Message

    <OperationContract(Action:="GetReasonList", ReplyAction:="GetReasonList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function GetReasonList() As Message

End Interface
