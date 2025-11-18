Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR05210Back

<ServiceContract()>
Public Interface IPNR05210RegularService
    Inherits R_IServicebase(Of PNR05210GridDto)

End Interface
