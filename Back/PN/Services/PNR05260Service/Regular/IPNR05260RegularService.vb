Imports R_BackEnd
Imports R_Common
Imports PNR05260Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR05260RegularService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR05260RegularService
    Inherits R_IServicebase(Of PNR05260GridDto)

End Interface
