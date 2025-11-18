Imports System.ServiceModel
Imports R_Common
Imports PYM01200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01200StreamingService

    <OperationContract(Action:="getSalaryGroupEmployee", ReplyAction:="getSalaryGroupEmployee")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroupEmployee() As Message

    <OperationContract(Action:="getTransferHeaderData", ReplyAction:="getTransferHeaderData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransferHeaderData() As Message

    <OperationContract(Action:="getTransferDetail", ReplyAction:="getTransferDetail")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransferDetail() As Message

    <OperationContract(Action:="getComponentList", ReplyAction:="getComponentList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComponentList() As Message

    <OperationContract(Action:="getProcessList", ReplyAction:="getProcessList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProcessList() As Message

    <OperationContract(Action:="getUserDefineParams", ReplyAction:="getUserDefineParams")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUserDefineParams() As Message

    <OperationContract(Action:="getBankNumber", ReplyAction:="getBankNumber")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBankNumber() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poComponentCarrier As List(Of PYM01200ComponentDTO),
              poParam2 As List(Of PYM01200TransferHeaderGridDTO))



End Interface
