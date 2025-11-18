Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports QAR01300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01300Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01300Service
    Inherits R_IServicebase(Of QAR01300DTO)

End Interface
