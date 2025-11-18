Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports MCB01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCB01000StreamingService

    <OperationContract(Action:="getUsage", ReplyAction:="getUsage")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUsage() As Message

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message


    <OperationContract(Action:="getMcmCutOffValue", ReplyAction:="getMcmCutOffValue")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmCutOffValue() As Message

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of MCB01000GridDTO))

End Interface
