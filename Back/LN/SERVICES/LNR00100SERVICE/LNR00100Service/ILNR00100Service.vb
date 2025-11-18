Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00100Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00100Service
    Inherits R_IServicebase(Of LNR00100Dto)

End Interface
