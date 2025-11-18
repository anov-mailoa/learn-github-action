Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05220Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05220Service
    Inherits R_IServicebase(Of PNM05220DTO)

  

End Interface
