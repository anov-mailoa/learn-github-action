Imports R_BackEnd
Imports R_Common
Imports QAT00300Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00300StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00300StreamService

    <OperationContract(Action:="getDepartmentList", ReplyAction:="getDepartmentList")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDepartmentList() As Message

    <OperationContract(Action:="getListGrid", ReplyAction:="getListGrid")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGrid() As Message

    <OperationContract(Action:="getListGridClause", ReplyAction:="getListGridClause")>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridClause() As Message

    <OperationContract(Action:="ISO_Type", ReplyAction:="ISO_Type")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ISO_Type() As Message

    <OperationContract(Action:="Clause_Type", ReplyAction:="Clause_Type")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Clause_Type() As Message

    <OperationContract(Action:="getListGridRetainer", ReplyAction:="getListGridRetainer")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridRetainer() As Message

    <OperationContract(Action:="ComboPositionCode", ReplyAction:="ComboPositionCode")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ComboPositionCode() As Message

    <OperationContract(Action:="getListGridDocumentInfo", ReplyAction:="getListGridDocumentInfo")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridDocumentInfo() As Message

    <OperationContract(Action:="getGridRetain", ReplyAction:="getGridRetain")>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridRetain() As Message

    <OperationContract(Action:="getCmbDocType", ReplyAction:="getCmbDocType")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDocType() As Message

    <OperationContract(Action:="getCmbPositionCodeRetainer", ReplyAction:="getCmbPositionCodeRetainer")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPositionCodeRetainer() As Message

End Interface
