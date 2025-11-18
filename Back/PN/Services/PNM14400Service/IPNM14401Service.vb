Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports PNM14400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14401Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14401Service
    Inherits R_IServicebase(Of PNM14400KartuKeluargaDTO)

End Interface
