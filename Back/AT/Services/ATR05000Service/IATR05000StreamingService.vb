Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR05000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR05000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR05000StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR05000DTO))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

    <OperationContract(Action:="getAllEmployee", ReplyAction:="getAllEmployee")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getAllEmployee() As Message

End Interface
