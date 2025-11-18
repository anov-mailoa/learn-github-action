Imports System.ServiceModel
Imports ATR00590Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00590Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00590Service
    Inherits R_IServicebase(Of ATR00590DTO)
End Interface
