Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM14100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14100Service
    Inherits R_IServicebase(Of PNM14100Dto)

End Interface
