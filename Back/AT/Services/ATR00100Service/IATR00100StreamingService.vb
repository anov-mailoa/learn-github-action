Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATR00100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR00100StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
