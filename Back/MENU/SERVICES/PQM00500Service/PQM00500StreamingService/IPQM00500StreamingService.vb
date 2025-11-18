Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00500StreamingService

    <OperationContract(Action:="getListDataMenu", ReplyAction:="getListDataMenu")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDataMenu() As Message

    <OperationContract(Action:="getListDataUser", ReplyAction:="getListDataUser")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDataUser() As Message

    <OperationContract(Action:="getCmbCompany", ReplyAction:="getCmbCompany")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbCompany() As Message

    <OperationContract(Action:="getCmbUser", ReplyAction:="getCmbUser")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbUser() As Message

End Interface
