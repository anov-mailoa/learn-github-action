Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM05100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05100HeaderService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05100HeaderService
    Inherits R_IServicebase(Of PNM05100HeaderDTO)

End Interface
