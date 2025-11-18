Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02900StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02900StreamingService

    <OperationContract(Action:="GetNonMFAUsers", ReplyAction:="GetNonMFAUsers")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetNonMFAUsers() As Message

    <OperationContract(Action:="GetUserList", ReplyAction:="GetUserList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetUserList() As Message

End Interface
