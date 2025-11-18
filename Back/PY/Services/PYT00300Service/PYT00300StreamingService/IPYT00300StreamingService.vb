Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PYT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00300StreamingService

    <OperationContract(Action:="RapidTransactionHd", ReplyAction:="RapidTransactionHd")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListRapidTransactionHd() As Message

    <OperationContract(Action:="RapidTransactionDt", ReplyAction:="RapidTransactionDt")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListRapidTransactionDt() As Message

    <OperationContract(Action:="getPeriods", ReplyAction:="getPeriods")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPeriods() As Message

    <OperationContract(Action:="getSalaryGroups", ReplyAction:="getSalaryGroups")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroups() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="getCmbUploadRapidTo", ReplyAction:="getCmbUploadRapidTo")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbUploadRapidTo() As Message

    <OperationContract(Action:="getSalaryGroupList", ReplyAction:="getSalaryGroupList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroupList() As Message

    <OperationContract(Action:="getDownloadData", ReplyAction:="getDownloadData")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDownloadData() As Message

    <OperationContract(Action:="getCompList", ReplyAction:="getCompList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCompList() As Message

    <OperationContract(Action:="getEmpHistory", ReplyAction:="getEmpHistory")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpHistory() As Message

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message


    <OperationContract(Action:="getCmbCurrency", ReplyAction:="getCmbCurrency")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCurrency() As Message

    <OperationContract(Action:="GetTemplate", ReplyAction:="GetTemplate")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTemplate() As Message

    <OperationContract(Action:="DownloadExcel", ReplyAction:="DownloadExcel")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function DownloadExcel() As Message

  


End Interface
