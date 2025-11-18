Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCB00100Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCB00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCB00100Service

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearProcess(ByVal poParam As MCB00100DTO) As List(Of MCB00100DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbMedicalRule(ByVal poParam As MCB00100DTO) As List(Of LookUpCmbDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function EnableTabEmployee(ByVal poParam As MCB00100DTO) As Integer

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidateUser(ByVal poParam As MCB00100DTO) As Integer

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidateUsage(ByVal poParam As MCB00100DTO) As Integer

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub UpdateUsageMedical(ByVal poParam As MCB00100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckCurrentYear(pcCompId As String, pcYear As String) As Integer
End Interface
