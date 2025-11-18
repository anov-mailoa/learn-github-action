Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100RelatedTrainingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100RelatedTrainingService
    Inherits R_IServicebase(Of PNM03100JobCompetencyDetailDTO)
    <OperationContract()>
    Sub DoWork()

End Interface
