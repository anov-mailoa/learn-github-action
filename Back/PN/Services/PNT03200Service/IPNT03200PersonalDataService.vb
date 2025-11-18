Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports pnt03200back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03200PersonalDataService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200PersonalDataService
    Inherits R_IServicebase(Of PNT03200PersonalDataDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkLocalNationality(poParam As PNT03200PersonalDataDTO) As String


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftUndraft(poParam As PNT03200PersonalDataDTO) As PNT03200PersonalDataDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As PNT03200PersonalDataDTO) As PNT03200PersonalDataDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidate(poParam As PNT03200PersonalDataDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateDelete(poParam As PNT03200PersonalDataDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub checkStatusValidateAdd(poParam As PNT03200PersonalDataDTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkStatusDraft(poParam As PNT03200PersonalDataDTO) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function validasiPersonalDataEmployeeKey(poParam As PNT03200PersonalDataDTO) As PNT03200PersonalDataDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub CheckValidateEmployeeResignation(poParam As PNT03200PersonalDataDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPersonalData(poParam As PNT03200PersonalDataDTO) As PNT03200PersonalDataDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPersonalData(poParam As PNT03200PersonalDataDTO) As PNT03200PersonalDataDTO

End Interface
