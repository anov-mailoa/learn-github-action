Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR00700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR00700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR00700StreamingService

    <OperationContract(Action:="getGrupGaji", ReplyAction:="getGrupGaji")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getGrupGaji() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getExportExcelData", ReplyAction:="getExportExcelData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExportExcelData() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam3 As List(Of PYR00700DTO))

End Interface
