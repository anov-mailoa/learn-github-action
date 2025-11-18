Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05200PictureDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05200PictureDataService
    Inherits R_IServicebase(Of PNM05200PictureDataDTO)

    <OperationContract()>
    Sub DoWork()

End Interface
