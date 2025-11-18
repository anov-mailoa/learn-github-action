Imports System.ServiceModel
Imports ATR00530Back
Imports R_BackEnd
Imports R_Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATR00530Service" in both code and config file together.
<ServiceContract()>
Public Interface IATR00530Service
    Inherits R_IServicebase(Of ATR00530DTO)
End Interface
