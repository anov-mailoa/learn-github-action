Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports ATR01150Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01150StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR01150StreamingService
    <OperationContract(Action:="SPData", ReplyAction:="SPData")>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSP() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal  poParGridStreaming As List(Of ATR01150GridDTO),
               popar1 As List(Of ATR01150SPDTO))
End Interface
