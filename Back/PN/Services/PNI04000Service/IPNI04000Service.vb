Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNI04000Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNI04000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNI04000Service
    Inherits R_IServicebase(Of PNI04000DTO)

End Interface
