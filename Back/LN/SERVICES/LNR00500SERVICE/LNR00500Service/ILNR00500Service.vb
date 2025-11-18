Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR00500Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00500Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00500Service
    Inherits R_IServicebase(Of LNR00500Dto)

End Interface
