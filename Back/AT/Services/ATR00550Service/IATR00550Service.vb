Imports System.ServiceModel
Imports ATR00550Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00550Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00550Service
    Inherits R_IServicebase(Of ATR00550DTO)
End Interface
