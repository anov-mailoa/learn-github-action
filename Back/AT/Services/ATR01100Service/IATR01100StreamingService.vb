Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR01100StreamingService

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR01100DTO))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
