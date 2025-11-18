Imports R_Common
Imports ESI00100Back
Imports ESI00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESI00500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESI00100StreamingService

    <OperationContract(Action:="getListNotification", ReplyAction:="getListNotification")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListNotification() As Message

    <OperationContract(Action:="getNewsList", ReplyAction:="getNewsList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getNewsList() As Message


End Interface
