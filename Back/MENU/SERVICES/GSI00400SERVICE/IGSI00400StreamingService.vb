Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports GSI00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSI00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSI00400StreamingService

    <OperationContract(Action:="getEmailList", ReplyAction:="getEmailList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmailList() As Message

End Interface
