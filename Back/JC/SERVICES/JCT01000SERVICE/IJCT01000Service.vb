Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCT01000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT01000Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCT01000Service
    Inherits R_IServicebase(Of JCT01000DTO)
 
    '    <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '    Function getEvaluationYear() As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub RejectEvaluationProcess(poParam As JCT01000Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CloseEvaluationProcess(poParam As JCT01000Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SendEmail(poParam As JCT01000Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckExist(poParam As JCT01000Dto) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckCompetencies(poParam As JCT01000Dto) As Integer
End Interface
