Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM02600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02600Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02600Service

    Inherits R_IServicebase(Of PNM02600DTO)

End Interface
