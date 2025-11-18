Imports System.ServiceModel
Imports R_Common
Imports PYM00800Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00800PolicyService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00800PolicyService
    Inherits R_IServicebase(Of PYM00800PolicyDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkSalaryPolicyUsage(poParam As PYM00800PolicyDTO) As Boolean

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPolicyDetail(poParam As PYM00800PolicyDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYM00800UsageDTO))


End Interface
