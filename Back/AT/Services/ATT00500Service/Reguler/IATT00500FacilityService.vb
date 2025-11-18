Imports System.ServiceModel
Imports R_Common
Imports ATT00500Back
Imports R_BackEnd
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00500facilityService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00500FacilityService
    Inherits R_IServicebase(Of ATT00500FacilityDTO)
    <OperationContract()>
    Sub DoWork()

End Interface
