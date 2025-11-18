Imports R_BackEnd
Imports R_Common
Imports PNR05220Back
Imports System.ServiceModel

<ServiceContract()>
Public Interface IPNR05220RegulerService
    Inherits R_IServicebase(Of PNR05220BackGridDto)

End Interface
