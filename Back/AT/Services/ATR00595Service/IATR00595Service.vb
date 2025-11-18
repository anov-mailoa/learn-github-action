Imports System.ServiceModel
Imports ATR00595Back
Imports R_BackEnd
Imports R_Common
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00595Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00595Service
    Inherits R_IServicebase(Of ATR00595DTO)

End Interface
