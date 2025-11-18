Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCB00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCB00100StreamingService

    <OperationContract(Action:="getDimensionList", ReplyAction:="getDimensionList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getDimensionList() As Message

    <OperationContract(Action:="getEmployeeList", ReplyAction:="getEmployeeList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getEmployeeList() As Message

End Interface
