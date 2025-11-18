Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNT04100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT04100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT04100Service

    Inherits R_IServicebase(Of PNT04100DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkInterface(pcCompanyId As String) As PNT04100DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PNT04100DTO) As PNT04100DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function maxYearsContractValidate(poParam As PNT04100DTO) As Boolean

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function maxYearsContractValidate1(poParam As PNT04100DTO) As Boolean

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As PNT04100DTO) As PNT04100DTO

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getContractTimes(pcCompId As String, pcEmployeeId As String) As PNT04100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poCurrent As PNT04100DTO) As PNT04100DTO

End Interface
