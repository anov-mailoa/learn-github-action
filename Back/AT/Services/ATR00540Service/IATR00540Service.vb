Imports System.ServiceModel
Imports ATR00540Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00540Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00540Service
    Inherits R_IServicebase(Of ATR00540DTO)
End Interface
