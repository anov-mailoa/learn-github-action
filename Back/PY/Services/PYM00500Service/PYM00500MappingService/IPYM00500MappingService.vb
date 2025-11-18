Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00500PerusahaanService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00500MappingService
    Inherits R_IServicebase(Of PYM00500MappingDTO)

End Interface
