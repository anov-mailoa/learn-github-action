Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00300Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00300Service
    Inherits R_IServicebase(Of LNR00300Dto)

End Interface
