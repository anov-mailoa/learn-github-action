Imports System.ServiceModel
Imports R_Common
Imports PYM00800Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00800PolicyDetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00800PolicyDetailService

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSinglePolicyDetail(poParam As PYM00800PolicyDetailDTO) As PYM00800PolicyDetailDTO


End Interface
