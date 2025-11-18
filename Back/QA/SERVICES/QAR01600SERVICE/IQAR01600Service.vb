Imports System.ServiceModel
Imports R_Common
Imports QAR01600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR01600Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAR01600Service

    Inherits R_IServicebase(Of QAR01600DTO)

End Interface
