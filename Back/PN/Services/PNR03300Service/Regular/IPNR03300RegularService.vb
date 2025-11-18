Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR03300Back

<ServiceContract()>
Public Interface IPNR03300RegularService
    Inherits R_IServicebase(Of PNR03300GridDto)

End Interface
