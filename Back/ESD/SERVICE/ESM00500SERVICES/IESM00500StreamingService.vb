Imports R_Common
Imports ESM00500Back
Imports ESM00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00500StreamingService

    <OperationContract(Action:="getListNews", ReplyAction:="getListNews")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListNews() As Message

    <OperationContract(Action:="getListAttachment", ReplyAction:="getListAttachment")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListAttachment() As Message

End Interface
