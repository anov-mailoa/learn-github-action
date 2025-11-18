Imports System.ServiceModel
Imports R_Common
Imports GSM01300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM01300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSM01300StreamingService

    <OperationContract(Action:="getActivityApprovaList", ReplyAction:="getActivityApprovaList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getActivityApprovaList() As Message

    <OperationContract(Action:="getActivityApprovaUserList", ReplyAction:="getActivityApprovaUserList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getActivityApprovaUserList() As Message

    <OperationContract(Action:="getMultipleUserList", ReplyAction:="getMultipleUserList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMultipleUserList() As Message


End Interface
