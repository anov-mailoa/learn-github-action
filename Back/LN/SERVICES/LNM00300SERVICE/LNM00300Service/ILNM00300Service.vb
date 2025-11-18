Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNM00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNM00300Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNM00300Service
    Inherits R_IServicebase(Of LNM00300Dto_R)
End Interface
