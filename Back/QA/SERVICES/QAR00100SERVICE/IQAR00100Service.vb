Imports System.ServiceModel
Imports R_Common
Imports QAR00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAR00100Service

    Inherits R_IServicebase(Of QAR00100DTO)

End Interface
