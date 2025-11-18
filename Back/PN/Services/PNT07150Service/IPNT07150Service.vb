Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT07150Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07150Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07150Service

    Inherits R_IServicebase(Of PNT07150DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidate(ByVal poParameter As PNT07150DTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateDelete(ByVal poParameter As PNT07150DTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getResignDate(ByVal poParameter As PNT07150DTO) As PNT07150DTO


    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Sub EmployeeOfficialDataValidation(ByVal poParameter As PNT07250DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateAdd(ByVal poParameter As PNT07150DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT07150DTO) As PNT07150DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT07150DTO) As PNT07150DTO

End Interface
