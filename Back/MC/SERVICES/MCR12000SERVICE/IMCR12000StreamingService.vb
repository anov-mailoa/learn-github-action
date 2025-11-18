Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels
Imports MCR12000Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCR12000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCR12000StreamingService

    <OperationContract(Action:="getCmbReportTemplateList", ReplyAction:="getCmbReportTemplateList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbReportTemplateList() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of MCR12000DTO))

    <OperationContract(Action:="getExportExcelHeader", ReplyAction:="getExportExcelHeader")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelHeader() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelData() As Message

End Interface
