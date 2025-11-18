Imports R_Common
Imports ESI00500Back
Imports ESI00500Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESI00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESI00500StreamingService

    <OperationContract(Action:="getNewsList", ReplyAction:="getNewsList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getNewsList() As Message

    <OperationContract(Action:="getNewsDetail", ReplyAction:="getNewsDetail")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getNewsDetail() As Message

    <OperationContract(Action:="getListAttachment", ReplyAction:="getListAttachment")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListAttachment() As Message


End Interface
