Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00540Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00540StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00540StreamingService
    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message
End Interface
