Imports System.ServiceModel
Imports ATR10700Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR10700Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR10700Service
    Inherits R_IServicebase(Of ATR10700DTO)
End Interface
