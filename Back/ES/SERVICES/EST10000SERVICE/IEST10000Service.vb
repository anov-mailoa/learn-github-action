Imports System.ServiceModel
Imports R_Common
Imports EST10000Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST10000Service" in both code and config file together.
<ServiceContract()>
Public Interface IEST10000Service
    Inherits R_IServicebase(Of EST10000DTO)

End Interface
