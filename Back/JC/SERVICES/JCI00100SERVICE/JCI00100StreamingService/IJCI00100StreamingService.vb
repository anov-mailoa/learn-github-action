Imports System.ServiceModel
Imports R_Common
Imports JCI00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCI00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCI00100StreamingService

    <OperationContract(Action:="getCmbPosition", ReplyAction:="getCmbPosition")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPosition() As Message

    <OperationContract(Action:="getListEmployee", ReplyAction:="getListEmployee")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEmployee() As Message

    <OperationContract(Action:="getCmbYear", ReplyAction:="getCmbYear")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbYear() As Message

    <OperationContract(Action:="getListEvaluationDetail", ReplyAction:="getListEvaluationDetail")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEvaluationDetail() As Message


End Interface
