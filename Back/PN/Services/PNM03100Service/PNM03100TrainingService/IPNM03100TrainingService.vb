Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100TrainingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100TrainingService
    Inherits R_IServicebase(Of PNM03100TrainingDTO)

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub deleteAllTraining(poParam As PNM03100TrainingDTO)

End Interface
