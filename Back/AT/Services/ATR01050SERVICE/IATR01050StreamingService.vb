Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR01050Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01050StreamingService" in both code and config file together.

<ServiceContract()>
Public Interface IATR01050StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

    <OperationContract(Action:="getReason", ReplyAction:="getReason")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReason() As Message
End Interface
