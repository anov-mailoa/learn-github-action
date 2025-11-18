Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCT00200Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT00200Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCT00200Service

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getInitialProcess(pcCompId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCutOffYear(pcCompId As String) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteProcess(poParam As JCT00200Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ReDraftProcess(poParam As JCT00200Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitProcess(poParam As JCT00200Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidateAdd(poParam As JCT00200Dto) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidateFound(pcCompId As String, pcRefNo As String, pcTransStatus As String) As String
End Interface
