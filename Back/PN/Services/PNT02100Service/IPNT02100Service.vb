Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT02100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT02100Service

    Inherits R_IServicebase(Of PNT02100DTO)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT02100DTO) As PNT02100DTO

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT02100DTO) As PNT02100DTO

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkAllowedResources(poParam As PNT02100DTO) As Boolean

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function CekAttendance(poParam As PNT02100DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CekLeave(poParam As PNT02100DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CekPayroll(poParam As PNT02100DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CekMedical(poParam As PNT02100DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CekLoan(poParam As PNT02100DTO) As Boolean
End Interface
