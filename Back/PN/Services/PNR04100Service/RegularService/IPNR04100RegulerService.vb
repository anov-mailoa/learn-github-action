Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR04100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR04100RegulerService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR04100RegulerService
    Inherits R_IServicebase(Of PNR04100GridDto)

End Interface
