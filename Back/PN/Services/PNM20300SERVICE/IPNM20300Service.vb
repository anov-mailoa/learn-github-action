Imports R_Common
Imports R_BackEnd
Imports PNM20300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM20000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM20300Service
    Inherits R_IServicebase(Of PNM20300DTO)

End Interface
