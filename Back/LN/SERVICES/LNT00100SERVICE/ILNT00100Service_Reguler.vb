Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00100Service_Reguler" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00100Service_Reguler
    Inherits R_IServicebase(Of LNT00100Dto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As LNT00100Dto) As LNT00100Dto

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As LNT00100Dto) As LNT00100Dto

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidatePayroll(poParam As LNT00100Dto) As Integer

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getImaxDate(poParam As String) As Integer

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function SystemParam(poParam As LNT00100Dto, poCRUDMode As R_Common.eCRUDMode) As Integer

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_SCHEDULE_VALIDATION(poParam As LNT00100Dto) As String


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLocalTypeCurrency(poParam As LNT00100Dto) As LNT00100Dto

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCurrencyRate(poParam As LNT00100Dto) As Decimal
End Interface
