Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01300ReimbursementHdService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01300ReimbursementHdService
    Inherits R_IServicebase(Of ESM01300ReimbursementHdDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLimitPolicyYear(pcCompId) As String

    'Get Local Currency
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLocalCurrency(pcCompId) As String

    'Annual Salary Card
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTaxStatus(poParam As ESM01300DTO) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkPassword(poParam As ESM01300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPDF(poParam As ESM01300DTO) As ESM01300DTO

    'Get Currency Rate
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCurrencyRate(poParam As ESM01300ReimbursementHdDTO) As Decimal

    'Get Remaining Limit
    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function GetRemainingLimit(poParam As ESM01300ReimbursementHdDTO) As Decimal

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedical(poParam As ESM01300ReimbursementHdDTO) As Integer

End Interface
