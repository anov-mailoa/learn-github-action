Imports System.ServiceModel
Imports R_Common
Imports ESM00600Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IESM00600Service
    Inherits R_IServicebase(Of ESM00600DTO)
End Interface
