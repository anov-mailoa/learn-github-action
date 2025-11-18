Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100Service
    Inherits R_IServicebase(Of PNT00100OfficialDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkInterface(pcCompanyId As String) As PNT00100OfficialDTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidate(ByVal poParameter As PNT00100OfficialDTO)


    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkEmployeeId(pcCompId As String, pcEmpId As String)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateDelete(ByVal poParameter As PNT00100OfficialDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateAdd(ByVal poParameter As PNT00100OfficialDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT00100OfficialDTO) As PNT00100OfficialDTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPersonalDataEmployee(poParam As PNT00100OfficialDTO) As PNT00100OfficialDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT00100OfficialDTO) As PNT00100OfficialDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekResources(poParam As PNT00100OfficialDTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkNPWP(pcNpwp As String) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_FULLNAME(poParam As PNT00100OfficialDTO) As String


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function regisApplicant(poParam As PNT00100OfficialDTO) As PNT00100OfficialDTO

End Interface
