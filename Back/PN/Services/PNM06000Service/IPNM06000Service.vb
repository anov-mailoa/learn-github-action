Imports System.ServiceModel
Imports R_Common
Imports PNM06000Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06000Service
    Inherits R_IServicebase(Of PNM06000DTO)

End Interface
