Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR01500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR01500StreamingService

    <OperationContract(Action:="getChkCmb", ReplyAction:="getChkCmb")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getChkCmb() As Message

    <OperationContract(Action:="getData", ReplyAction:="getData")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message

    <OperationContract(Action:="getSubData", ReplyAction:="getSubData")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSubData() As Message
End Interface
