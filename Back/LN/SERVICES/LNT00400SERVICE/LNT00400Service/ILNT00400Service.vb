Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00400Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00400Service
    Inherits R_IServicebase(Of LNT00400Dto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As LNT00400Dto) As LNT00400Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As LNT00400Dto) As LNT00400Dto

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLocalTypeCurrency(poParam As LNT00400Dto) As LNT00400Dto

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCurrencyRate(poParam As LNT00400Dto) As Decimal

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub AddNewTransaction(poParam As LNT00400Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckAdd(poParam As LNT00400Dto) As Boolean
End Interface
