Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAT00600Service" in both code and config file together.
<ServiceContract()>
Public Interface IQAT00600Service
    Inherits R_IServicebase(Of QAT00600DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getInitialProcess(ByVal poParam As QAT00600DTO) As QAT00600DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RedraftProcess(ByVal poParam As QAT00600DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitProcess(ByVal poParam As QAT00600DTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCopySocProcess(ByVal poParam As QAT00600DTO) As QAT00600DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSubmitValidationTab2(ByVal poParam As QAT00600DTO) As QAT00600DTO
End Interface
