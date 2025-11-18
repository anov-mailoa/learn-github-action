Imports System.ServiceModel
Imports R_Common
Imports PYM01200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01200HeaderService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01200HeaderService
    Inherits R_IServicebase(Of PYM01200SalaryHeaderDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLocalCurrency(poParam As String) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekProsesGaji(poParam As PYM01200SalaryHeaderDTO) As Integer

End Interface
