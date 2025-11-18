Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports QAR01300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01300StreamingService

    <OperationContract(Action:="getDocTypeList", ReplyAction:="getDocTypeList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getDocTypeList() As Message

    <OperationContract(Action:="getDocOwnerList", ReplyAction:="getDocOwnerList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getDocOwnerList() As Message

    <OperationContract(Action:="getReportSumDocumentList", ReplyAction:="getReportSumDocumentList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportSumDocumentList() As Message

    <OperationContract(Action:="getSubReportSumDocumentList", ReplyAction:="getSubReportSumDocumentList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getSubReportSumDocumentList() As Message

    <OperationContract(Action:="getReportTab2", ReplyAction:="getReportTab2")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportTab2() As Message

    <OperationContract(Action:="getSubReportTab2", ReplyAction:="getSubReportTab2")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getSubReportTab2() As Message

    <OperationContract(Action:="getReport_DOCINFO", ReplyAction:="getReport_DOCINFO")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_DOCINFO() As Message

    <OperationContract(Action:="getReport_RELPOS", ReplyAction:="getReport_RELPOS")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_RELPOS() As Message

    <OperationContract(Action:="getReport_FILING", ReplyAction:="getReport_FILING")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_FILING() As Message

    <OperationContract(Action:="getReport_RETAINER", ReplyAction:="getReport_RETAINER")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_RETAINER() As Message

    <OperationContract(Action:="getReport_CLAUSE", ReplyAction:="getReport_CLAUSE")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_CLAUSE() As Message

    <OperationContract(Action:="getReport_RELDOC", ReplyAction:="getReport_RELDOC")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_RELDOC() As Message

    <OperationContract(Action:="getReport_RELDOCFILING", ReplyAction:="getReport_RELDOCFILING")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_RELDOCFILING() As Message

    <OperationContract(Action:="getReport_RELDOCRETAINER", ReplyAction:="getReport_RELDOCRETAINER")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getReport_RELDOCRETAINER() As Message

    <OperationContract(Action:="getDocOwnerCombo", ReplyAction:="getDocOwnerCombo")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getDocOwnerCombo() As Message

    <OperationContract(Action:="getDocList", ReplyAction:="getDocList")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getDocList() As Message


End Interface
