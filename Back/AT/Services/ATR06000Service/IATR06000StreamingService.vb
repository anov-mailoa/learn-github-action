Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR06000Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR06000streamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR06000StreamingService


    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(popar2 As List(Of ATR06000DTO))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
