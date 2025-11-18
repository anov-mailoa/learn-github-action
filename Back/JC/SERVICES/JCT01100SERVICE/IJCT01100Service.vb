Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCT01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCT01100Service
    Inherits R_IServicebase(Of JCT01100DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEvaluationYear() As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeader(poParam As JCT01100DTO) As JCT01100DTO
End Interface
