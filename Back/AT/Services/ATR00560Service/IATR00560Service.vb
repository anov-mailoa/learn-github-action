Imports System.ServiceModel
Imports ATR00560Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00560Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00560Service
    Inherits R_IServicebase(Of ATR00560DTO)
End Interface
