Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR05000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR05000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR05000StreamingService

    <OperationContract(Action:="getCmbPaymentType", ReplyAction:="getCmbPaymentType")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPaymentType() As Message

    <OperationContract(Action:="getCmbMonth", ReplyAction:="getCmbMonth")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbMonth() As Message

    <OperationContract(Action:="getSalaryGroupList", ReplyAction:="getSalaryGroupList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroupList() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="getReportDataHeader", ReplyAction:="getReportDataHeader")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportDataHeader() As Message

    <OperationContract(Action:="getReportDataPekerjaBaru", ReplyAction:="getReportDataPekerjaBaru")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportDataPekerjaBaru() As Message

    <OperationContract(Action:="getReportDataPekerjaLama", ReplyAction:="getReportDataPekerjaLama")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportDataPekerjaLama() As Message

    <OperationContract(Action:="getReportDataRincianBulanan", ReplyAction:="getReportDataRincianBulanan")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportDataRincianBulanan() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poGridCarrier As List(Of PYR05000ParameterGridDTO), ByVal poParam As List(Of PYR05000DTO))

End Interface
