Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00400Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00400Service
    Inherits R_IServicebase(Of LNR00400Dto)

End Interface
