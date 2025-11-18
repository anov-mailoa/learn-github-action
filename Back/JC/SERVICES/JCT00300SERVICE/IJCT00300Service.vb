Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports JCT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IJCT00300Service
    Inherits R_IServicebase(Of JCT00300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getInitialProcess(pcCompId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ReDraftProcess(poParam As JCT00300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub SubmitProcess(poParam As JCT00300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidateCREFNO(poParam As JCT00300DTO) As Integer

End Interface
