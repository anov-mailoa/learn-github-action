Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00500Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00500StreamingService

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR00500DTO))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
