Imports System.ServiceModel
Imports R_Common
Imports PYM00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00700DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00700DetailService

    Inherits R_IServicebase(Of PYM00700DetailDTO)

End Interface
