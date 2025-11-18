Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100EmergencyDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100EmergencyDataService
    Inherits R_IServicebase(Of PNT00100EmergencyDataDTO)
End Interface
