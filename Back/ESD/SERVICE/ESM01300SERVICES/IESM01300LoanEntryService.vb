Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports ESM01300Back
Imports ESM01300Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01300LoanEntryService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01300LoanEntryService

  Inherits R_IServicebase(Of ESM01300LoanParameterDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecord(poParam As ESM01300LoanParameterDTO) As ESM01300LoanParameterDTO

    'Get Local Currency
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetInterestInstallment(poParam As ESM01300LoanParameterDTO) As ESM01300LoanEntryDTO



    'Get Local Currency
    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function CheckLoanPrincipal(poParam As ESM01300LoanParameterDTO) As String
End Interface
