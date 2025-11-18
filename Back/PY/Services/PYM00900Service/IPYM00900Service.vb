Imports System.ServiceModel
Imports R_Common
Imports PYM00900Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00900Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00900Service
    Inherits R_IServicebase(Of PYM00900DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateActive(poParam As PYM00900DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPymSalaryGroupHd(poEntity As PYM00900DTO) As PYM00900DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub cloneSaving(poParam As PYM00900DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkSyntax(ByVal poParam As PYM00900DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function GeneratePeriod(poParam As PYM00900DTO) As Boolean

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function updateBackdateInterface(poParam As PYM00900DTO) As PYM00900DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPymSalaryGroupDt(poEntity As PYM00900DTO) As PYM00900DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkExistPeriods(poParam As PYM00900DTO) As Integer

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidasiUndoPeriod(ByVal poParam As PYM00900DTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub UndoPeriod(ByVal poParam As PYM00900DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDefaultValueGeneratePeriod(ByVal poParam As PYM00900DTO) As PYM00900DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckPeriodicSalaryProcess(ByVal poParam As PYM00900DTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidationEnabledDelete(ByVal poParam As PYM00900DTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckPeriodExist(ByVal poEntity As PYM00900DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub GenerateProcess(ByVal poEntity As PYM00900DTO)

End Interface
