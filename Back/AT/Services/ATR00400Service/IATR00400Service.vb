Imports System.ServiceModel
Imports ATR00400Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00400Service
    Inherits R_IServicebase(Of ATR00400DTO)
End Interface
