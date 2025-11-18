Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back
Imports SIAPP_PUB_DTO

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09400Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09400Service

    Inherits R_IServicebase(Of PNT09400DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT09400DTO) As PNT09400DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT09400DTO) As PNT09400DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT09400DTO) As PNT09400DTO

End Interface
