Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR10200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR10200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR10200StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR10200DTO))

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getExcelData", ReplyAction:="getExcelData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getExcelData() As Message
End Interface
