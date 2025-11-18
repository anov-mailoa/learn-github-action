Imports System.ServiceModel
Imports R_Common
Imports JCT01100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCT01100StreamingService
    <OperationContract(Action:="getEvaluation", ReplyAction:="getEvaluation")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEvaluation() As Message

    <OperationContract(Action:="getEvaluationDetail", ReplyAction:="getEvaluationDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEvaluationDetail() As Message


End Interface
