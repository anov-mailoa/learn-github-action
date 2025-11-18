Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATR01400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR01400StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

End Interface
