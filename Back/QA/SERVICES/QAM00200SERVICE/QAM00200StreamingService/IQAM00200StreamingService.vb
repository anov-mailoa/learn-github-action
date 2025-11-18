Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports QAM00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00200StreamingService

    <OperationContract(Action:="getDocumentTypeList", ReplyAction:="getDocumentTypeList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocumentTypeList() As Message

    <OperationContract(Action:="getCmbDocumentTypeList", ReplyAction:="getCmbDocumentTypeList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDocumentTypeList() As Message

    <OperationContract(Action:="outstandingValidationReturn", ReplyAction:="outstandingValidationReturn")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function outstandingValidationReturn() As Message

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam2 As System.Collections.Generic.List(Of QAM00200TreeDTO))

End Interface
