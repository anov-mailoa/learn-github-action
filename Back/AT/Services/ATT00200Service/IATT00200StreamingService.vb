Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00200StreamingService
    <OperationContract(Action:="getPermission", ReplyAction:="getPermission")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPermission() As Message

    <OperationContract(Action:="getReason", ReplyAction:="getReason")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReason() As Message


    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message
End Interface
