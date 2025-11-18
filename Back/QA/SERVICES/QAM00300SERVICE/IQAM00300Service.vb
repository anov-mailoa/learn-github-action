Imports System.ServiceModel
Imports R_Common
Imports QAM00300Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00300Service

    Inherits R_IServicebase(Of QAM00300DTO)

End Interface
