Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM02400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02400PnmGradeDtService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02400PnmGradeDtService

    Inherits R_IServicebase(Of PNM02400PnmGradeDtDTO)

End Interface
