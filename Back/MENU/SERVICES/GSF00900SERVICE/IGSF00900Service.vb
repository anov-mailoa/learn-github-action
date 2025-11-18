Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports GSF00900Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSB00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSF00900Service
    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub cekUserPassword(poParam As GSF00900DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_ACTIVITY_VALIDITY(poParam As GSF00900DTO) As List(Of GSF00900DTO)

End Interface
