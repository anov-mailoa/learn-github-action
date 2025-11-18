Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR07300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR07300StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR07300StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR07300Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getPnmOrgStructure", ReplyAction:="getPnmOrgStructure")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmOrgStructure() As Message

    <OperationContract(Action:="getSamCompanies", ReplyAction:="getSamCompanies")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getSamCompanies() As Message

End Interface
