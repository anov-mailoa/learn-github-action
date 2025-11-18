Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNB09100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNB09100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNB09100Service
    Inherits R_IServicebase(Of PNB09100DTO)

End Interface
