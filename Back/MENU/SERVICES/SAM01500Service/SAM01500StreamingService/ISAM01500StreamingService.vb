Imports System.ServiceModel
Imports R_Common
Imports SAM01500Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01500StreamingService

    <OperationContract(Action:="getLockingList", ReplyAction:="getLockingList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLockingList() As Message
End Interface
