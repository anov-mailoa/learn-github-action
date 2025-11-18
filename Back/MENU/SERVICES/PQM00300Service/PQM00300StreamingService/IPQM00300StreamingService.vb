Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPQM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPQM00300StreamingService

    <OperationContract(Action:="getListData", ReplyAction:="getListData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListData() As Message


    <OperationContract(Action:="getUserCompany", ReplyAction:="getUserCompany")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getUserCompany() As Message

End Interface
