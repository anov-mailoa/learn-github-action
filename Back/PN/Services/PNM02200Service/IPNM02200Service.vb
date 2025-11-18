Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02200Service
    Inherits R_IServicebase(Of PNM02200HeaderDTO)

  
End Interface
