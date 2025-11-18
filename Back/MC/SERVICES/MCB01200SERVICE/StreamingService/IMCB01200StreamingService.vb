Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB01200Back

<ServiceContract()>
Public Interface IMCB01200StreamingService

    <OperationContract(Action:="getRulesListRecord", ReplyAction:="getRulesListRecord")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRulesListRecord() As Message

    <OperationContract(Action:="getCurrentYearList", ReplyAction:="getCurrentYearList")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrentYearList() As Message

    <OperationContract(Action:="getPreviousYearList", ReplyAction:="getPreviousYearList")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPreviousYearList() As Message

    <OperationContract(Action:="getChangesLogList", ReplyAction:="getChangesLogList")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getChangesLogList() As Message

    <OperationContract(Action:="getPreviousUsage", ReplyAction:="getPreviousUsage")> _
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPreviousUsage() As Message

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid1 As List(Of MCB01200RulesDto))

End Interface
