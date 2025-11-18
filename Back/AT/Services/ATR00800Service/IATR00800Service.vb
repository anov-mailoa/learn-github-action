Imports System.ServiceModel
Imports ATR00800Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00800Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00800Service
    Inherits R_IServicebase(Of ATR00800DTO)
End Interface
