Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02200DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02200RelatedTrainingService
    Inherits R_IServicebase(Of PNM02200RelatedTrainingDTO)

End Interface
