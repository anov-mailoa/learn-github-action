Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNM02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02100SubService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02100SubService
    Inherits R_IServicebase(Of PNM02100ScoreInfoDTO)

End Interface
