Imports R_BackEnd
Imports R_Common
Imports MCB01100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

<ServiceContract()>
Public Interface IMCB01100StreamingService

    <OperationContract(Action:="getMainLimitList", ReplyAction:="getMainLimitList")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMainLimitList() As Message

    <OperationContract(Action:="getMedicalItemLimitList", ReplyAction:="getMedicalItemLimitList")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalItemLimitList() As Message

    <OperationContract(action:="getRemainingLimit", ReplyAction:="getRemainingLimit")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRemainingLimit() As Message

    <OperationContract(action:="getRemainingLimitItem", ReplyAction:="getRemainingLimitItem")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRemainingLimitItem() As Message

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message


End Interface
