Imports System.ServiceModel
Imports ATR00580Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00580Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00580Service
    Inherits R_IServicebase(Of ATR00580DTO)
End Interface
