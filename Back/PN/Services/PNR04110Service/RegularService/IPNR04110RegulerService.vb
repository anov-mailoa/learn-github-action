Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR04110Back


<ServiceContract()>
Public Interface IPNR04110RegulerService
    Inherits R_IServicebase(Of PNR04110BackGridDto)

End Interface
