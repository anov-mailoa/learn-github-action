Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCT02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT02000Service
    Inherits R_IServicebase(Of MCT02000DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As MCT02000DTO) As MCT02000DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As MCT02000DTO) As MCT02000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmLimitPolicy(pcCompId As String) As MCT02000DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMcmLimitPolicy2(pcCompId As String, pcYear As String) As MCT02000DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckLimitCorrection(ByVal pcCompanyId As String) As Integer

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetOriginalAmount(poParam As MCT02000DTO) As Decimal

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDownloadHeader(poParam As MCT02000DTO) As MCT02000DTO

End Interface
