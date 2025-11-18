Imports System.ServiceModel
Imports ATR00510Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00510Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00510Service
    Inherits R_IServicebase(Of ATR00510DTO)
End Interface
