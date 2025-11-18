Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB04000Back

<ServiceContract()>
Public Interface IMCB04000RegularService
    Inherits R_IServicebase(Of MCB04000UntransferedClaimDto)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrentMedicalYear(poParam As MCB04000UntransferedClaimDto) As MCB04000UntransferedClaimDto

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub CloseProcess(ByVal poParam As MCB04000UntransferedClaimDto)

End Interface
