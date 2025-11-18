Imports System.ServiceModel
Imports ATI00100Back
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATI00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATI00100Service

    Inherits R_IServicebase(Of ATI00100DTO)
    

End Interface
