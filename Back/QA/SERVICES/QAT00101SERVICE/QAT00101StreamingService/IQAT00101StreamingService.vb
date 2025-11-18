Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports QAT00101Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00101StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00101StreamingService

    <OperationContract(Action:="getCmbDepartment", ReplyAction:="getCmbDepartment")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDepartment() As Message

    <OperationContract(Action:="getCmbDocType", ReplyAction:="getCmbDocType")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDocType() As Message

    <OperationContract(Action:="getListDocument", ReplyAction:="getListDocument")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListDocument() As Message

    <OperationContract(Action:="getListRelatedPosition", ReplyAction:="getListRelatedPosition")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRelatedPosition() As Message

    <OperationContract(Action:="getCmbRetainersPosition", ReplyAction:="getCmbRetainersPosition")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbRetainersPosition() As Message

    <OperationContract(Action:="getListRetainersPosition", ReplyAction:="getListRetainersPosition")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRetainersPosition() As Message

    'TAB 4
    <OperationContract(Action:="getCmbDocTypeRelatedDocuments", ReplyAction:="getCmbDocTypeRelatedDocuments")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDocTypeRelatedDocuments() As Message

    <OperationContract(Action:="getListRelatedDocuments", ReplyAction:="getListRelatedDocuments")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRelatedDocuments() As Message

    <OperationContract(Action:="getListRetainersRelated", ReplyAction:="getListRetainersRelated")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListRetainersRelated() As Message

    <OperationContract(Action:="getCmbRelatedRetainer", ReplyAction:="getCmbRelatedRetainer")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbRelatedRetainer() As Message

    'TAB 5
    <OperationContract(Action:="getCmbIsoType", ReplyAction:="getCmbIsoType")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbIsoType() As Message

    <OperationContract(Action:="getCmbClause", ReplyAction:="getCmbClause")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbClause() As Message

    <OperationContract(Action:="getListClause", ReplyAction:="getListClause")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListClause() As Message

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam2 As System.Collections.Generic.List(Of QAT00101GridDTO),
              ByVal poParam8 As System.Collections.Generic.List(Of QAT00101RelatedDocumentsGridDTO))

End Interface
