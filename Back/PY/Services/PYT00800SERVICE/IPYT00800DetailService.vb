Imports System.ServiceModel
Imports R_Common
Imports PYT00800Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00800Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00800DetailService

    Inherits R_IServicebase(Of PYT00800DetailDTO)

End Interface
