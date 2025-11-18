Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100WorkingExperienceService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100WorkingExperienceService
    Inherits R_IServicebase(Of PNT00100WorkExpDTO)
    
End Interface
