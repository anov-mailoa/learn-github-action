Imports System.ServiceModel
Imports R_Common
Imports ESM00100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00100StreamingService

    <OperationContract(Action:="GetTransactionList", ReplyAction:="GetTransactionList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionList() As Message

    'Approval Code List
    <OperationContract(Action:="GetApprovalCodeList", ReplyAction:="GetApprovalCodeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetApprovalCodeList() As Message

    'Approver List
    <OperationContract(Action:="GetApproverList", ReplyAction:="GetApproverList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetApproverList() As Message

    'Approval Positions List
    <OperationContract(Action:="GetApprovalPositionsList", ReplyAction:="GetApprovalPositionsList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetApprovalPositionsList() As Message

    'Structural Positions List
    <OperationContract(Action:="GetStructuralPositionsList", ReplyAction:="GetStructuralPositionsList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetStructuralPositionsList() As Message

    'LookUp Positions List
    <OperationContract(Action:="GetPositionLookUpList", ReplyAction:="GetPositionLookUpList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetPositionLookUpList() As Message

    'LookUp Transaction Escalate List
    <OperationContract(Action:="GetEscalateLookUpList", ReplyAction:="GetEscalateLookUpList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEscalateLookUpList() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyDTO(ByVal poPar As List(Of ESM00100ParamDTO))

    <OperationContract(Action:="GetAppList", ReplyAction:="GetAppList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetAppList() As Message

    <OperationContract(Action:="PrintProcess", ReplyAction:="PrintProcess")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function PrintProcess() As Message

End Interface
