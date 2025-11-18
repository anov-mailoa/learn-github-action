Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00595Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00595StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00595StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
     <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

    <OperationContract(Action:="getReason", ReplyAction:="getReason")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReason() As Message

End Interface
