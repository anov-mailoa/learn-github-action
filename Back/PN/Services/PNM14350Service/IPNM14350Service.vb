Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14350Back


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14350Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14350Service
    Inherits R_IServicebase(Of PNM14350DTO)

End Interface
