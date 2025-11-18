Imports System.ServiceModel
Imports ATR00570Back
Imports R_BackEnd
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00570Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00570Service
    Inherits R_IServicebase(Of ATR00570DTO)
End Interface
