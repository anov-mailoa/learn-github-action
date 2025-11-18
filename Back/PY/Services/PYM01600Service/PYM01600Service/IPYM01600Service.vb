Imports System.ServiceModel
Imports R_Common
Imports PYM01600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM01600Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYM01600Service

    Inherits R_IServicebase(Of PYM01600DTO)


End Interface
