Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR05500Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR05500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR05500StreamingService

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR05500DTO))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
