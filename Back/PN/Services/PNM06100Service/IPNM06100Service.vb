Imports System.ServiceModel
Imports R_Common
Imports PNM06100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM06100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM06100Service
    Inherits R_IServicebase(Of PNM06100DTO)


End Interface
