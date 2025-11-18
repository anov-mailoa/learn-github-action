Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00400StreamingService

    <OperationContract(Action:="getListDataMenu", ReplyAction:="getListDataMenu")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDataMenu() As Message

    <OperationContract(Action:="getListDataService", ReplyAction:="getListDataService")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListDataService() As Message

    <OperationContract(Action:="getCmbCompany", ReplyAction:="getCmbCompany")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbCompany() As Message

    <OperationContract(Action:="getCmbService", ReplyAction:="getCmbService")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbService() As Message

End Interface
