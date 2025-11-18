Imports R_BackEnd
Imports R_Common
Imports MCB01100Back
Imports System.ServiceModel

<ServiceContract()>
Public Interface IMCB01100MainLimitService
    Inherits R_IServicebase(Of MCB01100MainLimitDto)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmLimitPolicy(poParam As MCB01100MainLimitDto) As MCB01100MainLimitDto

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekMcmLimitPolicy(poParam As MCB01100MainLimitDto) As MCB01100MainLimitDto

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getInit(pcCompid As String) As MCB01100MainLimitDto

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function UpdateValidation(pcCompid As MCB01100MainLimitDto) As MCB01100MainLimitDto
End Interface
