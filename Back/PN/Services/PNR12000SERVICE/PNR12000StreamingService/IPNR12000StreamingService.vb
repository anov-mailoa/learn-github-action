Imports System.ServiceModel
Imports R_Common
Imports PNR12000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR12000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR12000StreamingService

    <OperationContract()>
    Sub DoWork()

    <OperationContract(Action:="getReportTemplate", ReplyAction:="getReportTemplate")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTemplate() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getExportExcelData() As Message

    <OperationContract(Action:="getExcelHeaderData", ReplyAction:="getExcelHeaderData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getExcelHeaderData() As Message

    '    <OperationContract(Action:="getTemplateList", ReplyAction:="getTemplateList")>
    '<FaultContract(GetType(R_ServiceExceptions))>
    '    Function getTemplateList() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam As List(Of PNR12000DTO))

End Interface
