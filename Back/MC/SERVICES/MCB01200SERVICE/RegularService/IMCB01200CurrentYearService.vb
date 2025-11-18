Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCB01200Back

<ServiceContract()>
Public Interface IMCB01200CurrentYearService
    Inherits R_IServicebase(Of MCB01200CurrentYearDto)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrentMedicalYear(poParam As MCB01200CurrentYearDto) As MCB01200CurrentYearDto

End Interface
