Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM02300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02300HeaderService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02300HeaderService
    Inherits R_IServicebase(Of PNM02300HeaderDTO)

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkDetail(poParam As PNM02300HeaderDTO) As Boolean

End Interface
