Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05211Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05211Service
    Inherits R_IServicebase(Of PNM05211DTO)

End Interface
