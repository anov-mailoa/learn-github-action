Imports System.ServiceModel
Imports R_Common
Imports PYM00800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00800StreamingService

    <OperationContract(Action:="getPolicy", ReplyAction:="getPolicy")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPolicy() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="RSP_GET_POLICY_HISTORY", ReplyAction:="RSP_GET_POLICY_HISTORY")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_GET_POLICY_HISTORY() As Message

    <OperationContract(Action:="getPolicyDetailData", ReplyAction:="getPolicyDetailData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPolicyDetailData() As Message

    <OperationContract(Action:="getMatchedPolicyData", ReplyAction:="getMatchedPolicyData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMatchedPolicyData() As Message

    <OperationContract(Action:="getAllPolicyDetail", ReplyAction:="getAllPolicyDetail")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAllPolicyDetail() As Message

    <OperationContract(Action:="getUsage", ReplyAction:="getUsage")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUsage() As Message


End Interface
