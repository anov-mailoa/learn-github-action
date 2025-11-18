Imports System.ServiceModel
Imports ATR00520Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00520Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00520Service
    Inherits R_IServicebase(Of ATR00520DTO)
End Interface
