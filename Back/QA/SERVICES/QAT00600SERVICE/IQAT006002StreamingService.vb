Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports QAT00600Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT006002StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT006002StreamingService

    <OperationContract(Action:="getDocumentList", ReplyAction:="getDocumentList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocumentList() As Message

    <OperationContract(Action:="getDocLvl1List", ReplyAction:="getDocLvl1List")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocLvl1List() As Message

    <OperationContract(Action:="getDocLvl2List", ReplyAction:="getDocLvl2List")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocLvl2List() As Message



End Interface
