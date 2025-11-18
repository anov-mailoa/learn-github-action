Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00560Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00560StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00560StreamingService
    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message
End Interface
