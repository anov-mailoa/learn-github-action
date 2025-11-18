Imports System.ServiceModel
Imports R_Common
Imports PYT00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00100StreamingService

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message

    <OperationContract(Action:="getPytTransactionHd", ReplyAction:="getPytTransactionHd")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPytTransactionHd() As Message

    <OperationContract(Action:="RSP_RESTRICT_SUBGRADE_VALIDATION", ReplyAction:="RSP_RESTRICT_SUBGRADE_VALIDATION")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_RESTRICT_SUBGRADE_VALIDATION() As Message

#Region "EMPLOYEE"
    <OperationContract(Action:="getDownloadTemplate", ReplyAction:="getDownloadTemplate")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDownloadTemplate() As Message

    <OperationContract(Action:="getListNonDraft", ReplyAction:="getListNonDraft")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListNonDraft() As Message

    <OperationContract(Action:="getListDraft", ReplyAction:="getListDraft")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDraft() As Message

    <OperationContract(Action:="getEmpCompList", ReplyAction:="getEmpCompList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpCompList() As Message

#End Region

#Region "COMPONENT"
    <OperationContract(Action:="getListDraftComponent", ReplyAction:="getListDraftComponent")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDraftComponent() As Message

    <OperationContract(Action:="getListNonDraftComponent", ReplyAction:="getListNonDraftComponent")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListNonDraftComponent() As Message
#End Region

#Region "CURRENCY"
    <OperationContract(Action:="getListDraftCurrency", ReplyAction:="getListDraftCurrency")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDraftCurrency() As Message

    <OperationContract(Action:="getListNonDraftCurrency", ReplyAction:="getListNonDraftCurrency")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListNonDraftCurrency() As Message
#End Region

#Region "History"
    <OperationContract(Action:="getTransaction", ReplyAction:="getTransaction")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="getComponent", ReplyAction:="getComponent")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getComponent() As Message

    <OperationContract(Action:="getPeriodList", ReplyAction:="getPeriodList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPeriodList() As Message

    <OperationContract(Action:="getDownloadTemplateEmployee", ReplyAction:="getDownloadTemplateEmployee")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDownloadTemplateEmployee() As Message

    <OperationContract(Action:="getDownloadTemplateComponent", ReplyAction:="getDownloadTemplateComponent")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDownloadTemplateComponent() As Message
#End Region

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYT00100GridDTO))

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poPar As List(Of ComponentListGridDTO))

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy2(ByVal poPar As List(Of EmployeeListGridDTO))

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy3(ByVal poPar As List(Of PYT00100ComponentDTO))


End Interface
