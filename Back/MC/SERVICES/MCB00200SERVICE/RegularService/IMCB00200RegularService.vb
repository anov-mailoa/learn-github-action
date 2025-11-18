Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB00200Back

<ServiceContract()>
Public Interface IMCB00200RegularService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearProcess(ByVal poParam As MCB00200DTO) As List(Of MCB00200DTO)

End Interface
