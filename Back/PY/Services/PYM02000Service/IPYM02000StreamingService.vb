Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM02000StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PYM02000GridDTO))

    <OperationContract(Action:="getUserList", ReplyAction:="getUserList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getUserList() As Message

    <OperationContract(Action:="getSalaryGroupList", ReplyAction:="getSalaryGroupList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getSalaryGroupList() As Message


End Interface
