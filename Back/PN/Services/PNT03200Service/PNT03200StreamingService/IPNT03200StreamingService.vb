Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT03200Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT03200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT03200StreamingService

    'Medical Checkup
    <OperationContract(Action:="getMedical", ReplyAction:="getMedical")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedical() As Message

    <OperationContract(Action:="getMedicalHistory", ReplyAction:="getMedicalHistory")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalHistory() As Message

    <OperationContract(Action:="getCmbEmployeeType", ReplyAction:="getCmbEmployeeType")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbEmployeeType() As Message

    <OperationContract(Action:="getCmbIdentityType", ReplyAction:="getCmbIdentityType")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbIdentityType() As Message

    <OperationContract(Action:="getCmbSalutation", ReplyAction:="getCmbSalutation")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSalutation() As Message

    <OperationContract(Action:="getCmbMarital", ReplyAction:="getCmbMarital")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbMarital() As Message

    <OperationContract(Action:="getCmbCurrencyCode", ReplyAction:="getCmbCurrencyCode")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCurrencyCode() As Message

    <OperationContract(Action:="getCmbReligion", ReplyAction:="getCmbReligion")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbReligion() As Message

    <OperationContract(Action:="getCmbBloodType", ReplyAction:="getCmbBloodType")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbBloodType() As Message

    <OperationContract(Action:="getCmbNationality", ReplyAction:="getCmbNationality")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbNationality() As Message

    <OperationContract(Action:="getAdditionalInfo", ReplyAction:="getAdditionalInfo")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAdditionalInfo() As Message

    <OperationContract(Action:="getFamilyData", ReplyAction:="getFamilyData")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFamilyData() As Message

    <OperationContract(Action:="getEducationData", ReplyAction:="getEducationData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEducationData() As Message

    <OperationContract(Action:="getEmergencyData", ReplyAction:="getEmergencyData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmergencyData() As Message

    <OperationContract(Action:="getLanguageData", ReplyAction:="getLanguageData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLanguageData() As Message


    <OperationContract(Action:="getWorkExp", ReplyAction:="getWorkExp")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkExp() As Message

    <OperationContract(Action:="getLicenceData", ReplyAction:="getLicenceData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLicenceData() As Message

    <OperationContract(Action:="getBankAccData", ReplyAction:="getBankAccData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBankAccData() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParPNT03200Additional As System.Collections.Generic.List(Of PNT03200AdditionalInfoGridDTO),
              poParPNT03200Family As List(Of PNT03200FamilyDataGridDTO),
              poParPNT03200EducationDataGrid As List(Of PNT03200EducationDataGridDTO),
              poParPNT03200WorkExpDataGrid As List(Of PNT03200WorkExperienceGridDTO),
              poParPNT03200LicenceDataGrid As List(Of PNT03200LicenceDataGridDTO))

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Medical(poParPNT03200MedicalGrid As List(Of PNT03200MedicalGridDTO),
                poParPNT03200MedicalHistoryGrid As List(Of PNT03200MedicalHistoryGridDTO))

End Interface
