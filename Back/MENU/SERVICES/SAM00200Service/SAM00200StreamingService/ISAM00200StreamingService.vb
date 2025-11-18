Imports System.ServiceModel
Imports R_Common
Imports SAM00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM00200StreamingService

    <OperationContract(Action:="getLOBList", ReplyAction:="getLOBList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLOBList() As Message
End Interface
