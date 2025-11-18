Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCB01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCB01000Service

    Inherits R_IServicebase(Of MCB01000DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmLimitPolicy(pcCompId As String) As MCB01000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekMcmLimitPolicy(pcCompId As String) As MCB01000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getInit(pcCompid As String) As MCB01000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function UpdateValidation(pcCompid As MCB01000DTO) As MCB01000DTO
End Interface
