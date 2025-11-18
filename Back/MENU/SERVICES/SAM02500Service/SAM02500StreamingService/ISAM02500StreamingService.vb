Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02500StreamingService

    <OperationContract(Action:="GetOutboxList", ReplyAction:="GetOutboxList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetOutboxList() As Message

End Interface
