Imports System.ServiceModel
Imports R_Common
Imports PYM00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00300StreamingService

    <OperationContract(Action:="getAllComplist", ReplyAction:="getAllComplist")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAllComplist() As Message

    <OperationContract(Action:="getActiveComplist", ReplyAction:="getActiveComplist")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getActiveComplist() As Message

    <OperationContract(Action:="getCmbBank", ReplyAction:="getCmbBank")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbBank() As Message

    <OperationContract(Action:="getCmbCompanyBank", ReplyAction:="getCmbCompanyBank")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCompanyBank() As Message

    <OperationContract(Action:="getCmbCurrency", ReplyAction:="getCmbCurrency")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCurrency() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of PYM00300CompListDTO))

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetReportData() As Message


End Interface
