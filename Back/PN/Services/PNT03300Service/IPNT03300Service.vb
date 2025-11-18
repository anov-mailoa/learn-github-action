Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03300Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03300Service
    Inherits R_IServicebase(Of PNT03300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkInterface(pcCompanyId As String) As PNT03300DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidate(ByVal poParameter As PNT03300DTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateDelete(ByVal poParameter As PNT03300DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub EmployeeOfficialDataValidation(ByVal poParameter As PNT03300DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateAdd(ByVal poParameter As PNT03300DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT03300DTO) As PNT03300DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT03300DTO) As PNT03300DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Reject(poParam As PNT03300DTO) As PNT03300DTO


End Interface
