Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09100Service
    Inherits R_IServicebase(Of PNT09100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPunishmentLevel(pcCompId As String) As PNT09100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function chekStatus(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT09100DTO) As PNT09100DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT09100DTO) As PNT09100DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT09100DTO) As PNT09100DTO

    
End Interface
