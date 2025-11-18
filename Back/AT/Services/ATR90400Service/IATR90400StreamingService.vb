Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90400Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR90400StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
