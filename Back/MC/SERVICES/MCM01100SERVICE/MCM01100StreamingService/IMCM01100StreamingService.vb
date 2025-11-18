Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports MCM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCM01100StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function MedicalRole() As Message

    <OperationContract(Action:="MedicalItemList", ReplyAction:="MedicalItemList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function MedicalItemList() As Message

    <OperationContract(Action:="MedicaSublItemList", ReplyAction:="MedicaSublItemList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function MedicaSublItemList() As Message

    <OperationContract(Action:="ComboSubMedicalItem", ReplyAction:="ComboSubMedicalItem")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ComboSubMedicalItem() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of MCM01100RoleListDto), _
              ByVal poPar2 As System.Collections.Generic.List(Of MCM01101GvDto), _
              ByVal poPar4 As System.Collections.Generic.List(Of MCM01102GvDto))

    'Changes Log (Date)
    <OperationContract(Action:="GetDlogMedicalRule", ReplyAction:="GetDlogMedicalRule")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogMedicalRule() As Message

    <OperationContract(Action:="GetDlogMedicalItem", ReplyAction:="GetDlogMedicalItem")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogMedicalItem() As Message

    <OperationContract(Action:="GetDlogMedicalSubItem", ReplyAction:="GetDlogMedicalSubItem")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogMedicalSubItem() As Message


    'Gridview (Changes Log)
    <OperationContract(Action:="GetLogMedicalRuleList", ReplyAction:="GetLogMedicalRuleList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLogMedicalRuleList() As Message

    <OperationContract(Action:="GetLogMedicalItemList", ReplyAction:="GetLogMedicalItemList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLogMedicalItemList() As Message

    <OperationContract(Action:="GetLogMedicalSubItemList", ReplyAction:="GetLogMedicalSubItemList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLogMedicalSubItemList() As Message

End Interface
