Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports MCM02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM02000StreamingService

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(poParam2 As List(Of MCM02000UnboundDTO))

    <OperationContract(Action:="getCmbBank", ReplyAction:="getCmbBank")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbBank() As Message


    <OperationContract(Action:="getBankTransferTemplateList", ReplyAction:="getBankTransferTemplateList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getBankTransferTemplateList() As Message

    <OperationContract(Action:="getTemplateHeader", ReplyAction:="getTemplateHeader")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getTemplateHeader() As Message

    <OperationContract(Action:="getTemplateHeaderDetail", ReplyAction:="getTemplateHeaderDetail")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getTemplateHeaderDetail() As Message

End Interface
