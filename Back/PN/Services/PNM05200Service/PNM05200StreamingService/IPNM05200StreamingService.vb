Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM05200BACK
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM05200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM05200StreamingService


    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")>
                <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="getMedicalHistory", ReplyAction:="getMedicalHistory")>
                <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalHistory() As Message

    <OperationContract(Action:="getCategory", ReplyAction:="getCategory")>
                <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCategory() As Message

    <OperationContract(Action:="getPosition", ReplyAction:="getPosition")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPosition() As Message

    <OperationContract(Action:="getEmpType", ReplyAction:="getEmpType")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmpType() As Message

    <OperationContract(Action:="getTrainingHistory", ReplyAction:="getTrainingHistory")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTrainingHistory() As Message

    <OperationContract(Action:="getBondAggreement", ReplyAction:="getBondAggreement")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBondAggreement() As Message

    <OperationContract(Action:="getAppreciation", ReplyAction:="getAppreciation")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAppreciation() As Message

    <OperationContract(Action:="getPunishment", ReplyAction:="getPunishment")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPunishment() As Message

    <OperationContract(Action:="getDocumentInfoFacilities", ReplyAction:="getDocumentInfoFacilities")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDocumentInfoFacilities() As Message

    <OperationContract(Action:="getGridFacility", ReplyAction:="getGridFacility")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridFacility() As Message

    <OperationContract(Action:="getInterface", ReplyAction:="getInterface")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getInterface() As Message

    'Family Data
    <OperationContract(Action:="getFamilyData", ReplyAction:="getFamilyData")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFamilyData() As Message

    <OperationContract(Action:="getEmergencyData", ReplyAction:="getEmergencyData")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmergencyData() As Message

    <OperationContract(Action:="getFormalEducation", ReplyAction:="getFormalEducation")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getFormalEducation() As Message

    <OperationContract(Action:="getLanguages", ReplyAction:="getLanguages")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLanguages() As Message

    <OperationContract(Action:="getWorkExperience", ReplyAction:="getWorkExperience")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkExperience() As Message

    <OperationContract(Action:="getLicence", ReplyAction:="getLicence")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLicence() As Message

    <OperationContract(Action:="getPrevTrainingHistory", ReplyAction:="getPrevTrainingHistory")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrevTrainingHistory() As Message

    'Medical Checkup
    <OperationContract(Action:="getMedical", ReplyAction:="getMedical")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedical() As Message

    'Personal Bank
    <OperationContract(Action:="getPersonalBank", ReplyAction:="getPersonalBank")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPersonalBank() As Message

    'SUBJECT
    <OperationContract(Action:="getCmbSubject", ReplyAction:="getCmbSubject")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSubject() As Message

    'CATEGORY
    <OperationContract(Action:="getCmbCategory", ReplyAction:="getCmbCategory")>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCategory() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParPNM05200Grid As List(Of PNM05200DTO),
              poParPNM05220Grid As List(Of PNM05220GridDTO),
              poParPNM05230Grid As List(Of PNM05230DTO),
              poParPNM05240 As List(Of PNM05240DTO),
              poParPNM05250Grid As List(Of PNM05250GridDTO),
              poParPNM05260Grid As List(Of PNM05260GridDTO),
              poParPNM05270Grid As List(Of PNM05270GridDTO),
              poParPNM05280Grid As List(Of PNM05280GridDTO),
              poParPNM05200FamilyGrid As List(Of PNM05200FamilyDataGridDTO),
              poParPNM05200FormalEducationGrid As List(Of PNM05200FormalEducationGridDTO),
              poParPNM05200WorkExperienceGrid As List(Of PNM05200WorkExperienceGridDTO),
              poParPNM05200LicenceGrid As List(Of PNM05200LicenceGridDTO),
              poParPNM05200MedicalGrid As List(Of PNM05200MedicalGridDTO),
              poParPNM05200MedicalPhysicalStreaming As List(Of PNM05200MedicalPhysicalStreamingDTO),
              poParPNM05200MedicalDiseaseStreaming As List(Of PNM05200MedicalDiseaseStreamingDTO),
              poParPNM05200MedicalHistoryGrid As List(Of PNM05200MedicalHistoryGridDTO))

End Interface
