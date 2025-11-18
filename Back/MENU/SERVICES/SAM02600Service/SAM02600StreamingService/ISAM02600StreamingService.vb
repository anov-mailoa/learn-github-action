Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02600StreamingService

    <OperationContract(Action:="GetData", ReplyAction:="GetData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetData() As Message

End Interface
