Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR01100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNR01100Service
    Inherits R_IServicebase(Of PNR01100BackDTO)

End Interface
