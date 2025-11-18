Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNR00200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNR00200Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNR00200Service
    Inherits R_IServicebase(Of LNR00200Dto)
End Interface
