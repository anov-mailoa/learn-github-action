Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT04200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT04200Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT04200Service

    Inherits R_IServicebase(Of PNT04200DTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT04200DTO) As PNT04200DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT04200DTO) As PNT04200DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT04200DTO) As PNT04200DTO

End Interface
