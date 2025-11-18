Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports ATR90500Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR90500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATR90500StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message
    <OperationContract(Action:="getCmb", ReplyAction:="getCmb")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmb() As Message

End Interface
