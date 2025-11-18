Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PYM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00400PPH21Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00400SevernService
    Inherits R_IServicebase(Of PYM00400SevernDTO)

End Interface
