Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00700Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00700Service
    Inherits R_IServicebase(Of LNT00700Dto)

End Interface
