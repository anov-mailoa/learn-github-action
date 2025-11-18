Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01500StreamingService

    <OperationContract(Action:="getDelegateList", ReplyAction:="getDelegateList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDelegateList() As Message




End Interface
