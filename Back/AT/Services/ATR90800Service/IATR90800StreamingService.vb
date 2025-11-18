Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90800Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR90800StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

End Interface
