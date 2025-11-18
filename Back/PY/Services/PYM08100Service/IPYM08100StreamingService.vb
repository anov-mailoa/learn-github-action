Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYM08100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM08100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM08100StreamingService

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(poParam2 As List(Of PYM08100UnboundDTO))

    <OperationContract(Action:="getGLTemplateList", ReplyAction:="getGLTemplateList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getGLTemplateList() As Message

    <OperationContract(Action:="getGLHeader", ReplyAction:="getGLHeader")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getGLHeader() As Message

    <OperationContract(Action:="getGLJournal", ReplyAction:="getGLJournal")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getGLJournal() As Message


End Interface
