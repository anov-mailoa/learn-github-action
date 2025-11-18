Imports System.ServiceModel
Imports R_Common
Imports PNM09000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM09000DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM09000DetailService
    Inherits R_IServicebase(Of PNM09000DetailDTO)


End Interface
