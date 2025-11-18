Imports System.ServiceModel
Imports R_Common
Imports QAR01200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01200StreamingService
    <OperationContract(Action:="getISOTypeList", ReplyAction:="getISOTypeList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getISOTypeList() As Message

    <OperationContract(Action:="getISOTypeVersionList", ReplyAction:="getISOTypeVersionList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getISOTypeVersionList() As Message

    <OperationContract(Action:="getGridClauseList", ReplyAction:="getGridClauseList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridClauseList() As Message

    <OperationContract(Action:="getGridDocumentList", ReplyAction:="getGridDocumentList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridDocumentList() As Message

    <OperationContract(Action:="getReportClauseList", ReplyAction:="getReportClauseList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportClauseList() As Message

    <OperationContract(Action:="getSubReportClauseList", ReplyAction:="getSubReportClauseList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getSubReportClauseList() As Message

    <OperationContract(Action:="getReportDocumentList", ReplyAction:="getReportDocumentList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportDocumentList() As Message

    <OperationContract(Action:="getSubReportDocumentList", ReplyAction:="getSubReportDocumentList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getSubReportDocumentList() As Message

    <OperationContract(Action:="getSubReportDocumentClause", ReplyAction:="getSubReportDocumentClause")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getSubReportDocumentClause() As Message

 
End Interface
