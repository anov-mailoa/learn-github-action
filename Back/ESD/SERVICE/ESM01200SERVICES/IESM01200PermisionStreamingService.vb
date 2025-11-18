Imports R_Common
Imports ESM01200Back
Imports ESM01200Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01240StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01200PermisionStreamingService

    <OperationContract(Action:="GetList", ReplyAction:="GetList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetList() As Message

    <OperationContract(Action:="GetList2", ReplyAction:="GetList2")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetList2() As Message

    <OperationContract(Action:="getcmbReason", ReplyAction:="getcmbReason")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getcmbReason() As Message

    <OperationContract(Action:="ValidateStart", ReplyAction:="ValidateStart")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidateStart() As Message

End Interface
