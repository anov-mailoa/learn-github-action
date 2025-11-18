Imports R_Common
Imports ESB00100Back
Imports ESB00100Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESI01000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESB00100StreamingService

    <OperationContract(Action:="getApproverList", ReplyAction:="getApproverList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getApproverList() As Message

    <OperationContract(Action:="getTrxList", ReplyAction:="getTrxList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTrxList() As Message


    <OperationContract(Action:="getHistoryTrxList", ReplyAction:="getHistoryTrxList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistoryTrxList() As Message

    <OperationContract(Action:="getUserList", ReplyAction:="getUserList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUserList() As Message

    <OperationContract(Action:="GetSubItemsList", ReplyAction:="GetSubItemsList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetSubItemsList() As Message


    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParam As ESB00100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getViewDetail(poParam As ESB00100ViewDetailDTO) As ESB00100ViewDetailDTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailSubItem(poParam As ESB00100ViewDetailDTO) As ESB00100ViewDetailDTO
End Interface
