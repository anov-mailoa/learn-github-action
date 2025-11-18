Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT02000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT02000Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT02000Service
    Inherits R_IServicebase(Of PNT02000DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT02000DTO) As PNT02000DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT02000DTO) As PNT02000DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT02000DTO) As PNT02000DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkAllowedResources(poParam As PNT02000DTO) As Boolean

End Interface
