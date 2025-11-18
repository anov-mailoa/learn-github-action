Imports System.ServiceModel
Imports R_Common
Imports PYM00900Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00900SalaryProcessService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00900SalaryProcessService
    Inherits R_IServicebase(Of PYM00900SalaryProcessDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidasi(poParam As PYM00900SalaryProcessDTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_IS_POSTING_VALID(poParam As PYM00900SalaryProcessDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidasiComponentTwice(poParam As PYM00900SalaryProcessDTO) As Integer

End Interface
