Imports System.ServiceModel
Imports R_Common
Imports JCM00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCM00100StreamingService

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getList() As Message

End Interface
