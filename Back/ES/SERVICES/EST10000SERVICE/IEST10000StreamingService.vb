Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports EST10000Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST10000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IEST10000StreamingService

    'Employee
    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    'Family
    <OperationContract(Action:="GetFamilyDataList", ReplyAction:="GetFamilyDataList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetFamilyDataList() As Message

    'Emergency Contact
    <OperationContract(Action:="GetEmergencyContactList", ReplyAction:="GetEmergencyContactList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmergencyContactList() As Message

    'Bank Account
    <OperationContract(Action:="GetBankAccountList", ReplyAction:="GetBankAccountList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetBankAccountList() As Message

    'Work Experience
    <OperationContract(Action:="GetWorkExperienceList", ReplyAction:="GetWorkExperienceList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetWorkExperienceList() As Message

    'Formal Education
    <OperationContract(Action:="GetFormalEducationList", ReplyAction:="GetFormalEducationList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetFormalEducationList() As Message

    'Training History
    <OperationContract(Action:="GetTrainingHistoryList", ReplyAction:="GetTrainingHistoryList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTrainingHistoryList() As Message

    'License
    <OperationContract(Action:="GetLicenseList", ReplyAction:="GetLicenseList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLicenseList() As Message

    'Language
    <OperationContract(Action:="GetLanguageList", ReplyAction:="GetLanguageList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLanguageList() As Message

    'Language
    <OperationContract(Action:="getMedicalHistoryList", ReplyAction:="getMedicalHistoryList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalHistoryList() As Message

    'Dummy
    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyDTO(ByVal poPar As List(Of EST10000GridDTO))

End Interface
