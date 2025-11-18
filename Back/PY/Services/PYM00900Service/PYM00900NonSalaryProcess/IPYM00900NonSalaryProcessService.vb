Imports System.ServiceModel
Imports R_Common
Imports PYM00900Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00900NonSalaryProcessService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00900NonSalaryProcessService
    Inherits R_IServicebase(Of PYM00900NonSalaryProcessDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkExistSequence(ByVal poParam As PYM00900NonSalaryProcessDTO) As PYM00900NonSalaryProcessDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckExistPeriodsNONSALARY(ByVal poParam As PYM00900NonSalaryProcessDTO) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckProcessStatus(ByVal poParam As PYM00900NonSalaryProcessDTO) As Integer

End Interface
