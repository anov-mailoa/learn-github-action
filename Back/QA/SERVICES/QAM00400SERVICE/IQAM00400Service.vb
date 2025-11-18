Imports System.ServiceModel
Imports R_Common
Imports QAM00400Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAM00400Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAM00400Service

    Inherits R_IServicebase(Of QAM00400DTO)

End Interface
