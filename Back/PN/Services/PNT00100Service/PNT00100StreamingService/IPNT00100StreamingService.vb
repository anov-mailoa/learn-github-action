Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT00100StreamingService

    <OperationContract(Action:="getCmbEmployeeType", ReplyAction:="getCmbEmployeeType")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbEmployeeType() As Message

    <OperationContract(Action:="getCmbSalaryType", ReplyAction:="getCmbSalaryType")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSalaryType() As Message

    <OperationContract(Action:="getCmbTaxType", ReplyAction:="getCmbTaxType")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTaxType() As Message

    <OperationContract(Action:="getCmbSubGrade", ReplyAction:="getCmbSubGrade")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSubGrade() As Message

    <OperationContract(Action:="getCmbMarital", ReplyAction:="getCmbMarital")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbMarital() As Message

    <OperationContract(Action:="getCmbReligion", ReplyAction:="getCmbReligion")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbReligion() As Message

    <OperationContract(Action:="getCmbBloodType", ReplyAction:="getCmbBloodType")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbBloodType() As Message

    <OperationContract(Action:="getCmbNationality", ReplyAction:="getCmbNationality")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbNationality() As Message

    <OperationContract(Action:="getCmbOwnership", ReplyAction:="getCmbOwnership")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbOwnership() As Message

    <OperationContract(Action:="getAdditionalInfo", ReplyAction:="getAdditionalInfo")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAdditionalInfo() As Message

    <OperationContract(Action:="getCmbSalutation", ReplyAction:="getCmbSalutation")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSalutation() As Message

    <OperationContract(Action:="getCmbCategoryValue", ReplyAction:="getCmbCategoryValue")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCategoryValue() As Message

    <OperationContract(Action:="getFamilyData", ReplyAction:="getFamilyData")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFamilyData() As Message

    <OperationContract(Action:="getEmergencyData", ReplyAction:="getEmergencyData")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmergencyData() As Message

    <OperationContract(Action:="getEducationData", ReplyAction:="getEducationData")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEducationData() As Message

    <OperationContract(Action:="getLanguage", ReplyAction:="getLanguage")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLanguage() As Message

    <OperationContract(Action:="getWorkExp", ReplyAction:="getWorkExp")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getWorkExp() As Message

    <OperationContract(Action:="getDuplicate", ReplyAction:="getDuplicate")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDuplicate() As Message

    <OperationContract(Action:="getBankAccList", ReplyAction:="getBankAccList")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBankAccList() As Message

    <OperationContract(Action:="getCmbCurrencyCode", ReplyAction:="getCmbCurrencyCode")>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCurrencyCode() As Message

    <OperationContract(Action:="getApplicantList", ReplyAction:="getApplicantList")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getApplicantList() As Message

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParPNT00101 As System.Collections.Generic.List(Of PNT00100AdditionalInfoGridHeaderDTO),
              poParPNT00102 As System.Collections.Generic.List(Of PNT00100FamilyDataGridHeaderDTO),
              poParPNT00105 As System.Collections.Generic.List(Of PNT00100EducationGridHeaderDTO),
              poParPNT00108 As System.Collections.Generic.List(Of PNT00100WorkExpGridHeaderDTO),
              poParPNT00110 As System.Collections.Generic.List(Of PNT00100DuplicateGridDTO))

End Interface
