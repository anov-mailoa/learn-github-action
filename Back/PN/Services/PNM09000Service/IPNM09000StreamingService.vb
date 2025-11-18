Imports System.ServiceModel
Imports R_Common
Imports PNM09000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM09000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM09000StreamingService

    <OperationContract(Action:="getEmailAlerts", ReplyAction:="getEmailAlerts")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmailAlerts() As Message

    <OperationContract(Action:="getUserList", ReplyAction:="getUserList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUserList() As Message

    <OperationContract(Action:="getLookUpUser", ReplyAction:="getLookUpUser")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpUser() As Message


    <OperationContract(Action:="getEmailDt", ReplyAction:="getEmailDt")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmailDt() As Message

    <OperationContract(Action:="getCmbSequence", ReplyAction:="getCmbSequence")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSequence() As Message


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of PNM09000GridDTO),
              ByVal poPar2 As List(Of PNM09000DetailGridDTO))
End Interface
