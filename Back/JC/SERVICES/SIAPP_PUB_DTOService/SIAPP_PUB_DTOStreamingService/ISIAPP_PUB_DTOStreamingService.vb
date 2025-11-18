Imports System.ServiceModel
Imports R_Common
Imports SIAPP_PUB_DTO
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISIAPP_PUB_DTOStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISIAPP_PUB_DTOStreamingService

#Region "PYR00800"
    <OperationContract(Action:="getCmbTaxOffice", ReplyAction:="getCmbTaxOffice")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbTaxOffice() As Message

    <OperationContract(Action:="getCmbPosition", ReplyAction:="getCmbPosition")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPosition() As Message

    <OperationContract(Action:="getCmbLocation", ReplyAction:="getCmbLocation")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbLocation() As Message

    <OperationContract(Action:="getCmbGrade", ReplyAction:="getCmbGrade")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbGrade() As Message

    <OperationContract(Action:="getCmbCurr", ReplyAction:="getCmbCurr")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCurr() As Message

    <OperationContract(Action:="getCmbSalaryGroup", ReplyAction:="getCmbSalaryGroup")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSalaryGroup() As Message

    <OperationContract(Action:="getCmbKodeObjekPajak", ReplyAction:="getCmbKodeObjekPajak")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbKodeObjekPajak() As Message

#End Region

#Region "LOOKUP SECTION"

#Region "PERSONAL"
    <OperationContract(Action:="getLookUpCountry", ReplyAction:="getLookUpCountry")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCountry() As Message

    <OperationContract(Action:="getLookUpProvince", ReplyAction:="getLookUpProvince")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpProvince() As Message

    <OperationContract(Action:="getLookUpCity", ReplyAction:="getLookUpCity")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCity() As Message

    <OperationContract(Action:="getLookUpPosition", ReplyAction:="getLookUpPosition")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPosition() As Message

    <OperationContract(Action:="getLookUpLocation", ReplyAction:="getLookUpLocation")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpLocation() As Message

    <OperationContract(Action:="getLookUpGrade", ReplyAction:="getLookUpGrade")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpGrade() As Message

    <OperationContract(Action:="getLookUpCode", ReplyAction:="getLookUpCode")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCode() As Message

    <OperationContract(Action:="getLookUpEmployee", ReplyAction:="getLookUpEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployee() As Message

    <OperationContract(Action:="getLookUpActiveEmployee", ReplyAction:="getLookUpActiveEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpActiveEmployee() As Message

    <OperationContract(Action:="getLookUpEmployeeWithFacility", ReplyAction:="getLookUpEmployeeWithFacility")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeWithFacility() As Message

    <OperationContract(Action:="getLookUpProbationEmployee", ReplyAction:="getLookUpProbationEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpProbationEmployee() As Message

    <OperationContract(Action:="getLookUpResignedContractEmployee", ReplyAction:="getLookUpResignedContractEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpResignedContractEmployee() As Message

    <OperationContract(Action:="getLookUpActiveContractEmployee", ReplyAction:="getLookUpActiveContractEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpActiveContractEmployee() As Message

    <OperationContract(Action:="getLookUpReactivationEmployee", ReplyAction:="getLookUpReactivationEmployee")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpReactivationEmployee() As Message

    <OperationContract(Action:="getFacilityDeviceLookup", ReplyAction:="getFacilityDeviceLookup")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFacilityDeviceLookup() As Message

    <OperationContract(Action:="getEmployeeResignLookup", ReplyAction:="getEmployeeResignLookup")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeResignLookup() As Message

    <OperationContract(Action:="getLookUpCriteria", ReplyAction:="getLookUpCriteria")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCriteria() As Message

    <OperationContract(Action:="getLookUpCategory", ReplyAction:="getLookUpCategory")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCategory() As Message

    <OperationContract(Action:="getLookUpMasterFacility", ReplyAction:="getLookUpMasterFacility")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMasterFacility() As Message

    <OperationContract(Action:="getLookUpFasilitasKesehatan", ReplyAction:="getLookUpFasilitasKesehatan")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpFasilitasKesehatan() As Message

    <OperationContract(Action:="getLookUpReligion", ReplyAction:="getLookUpReligion")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpReligion() As Message

    <OperationContract(Action:="getLookUpGeography", ReplyAction:="getLookUpGeography")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpGeography() As Message

    <OperationContract(Action:="getLookUpReference", ReplyAction:="getLookUpReference")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpReference() As Message

    <OperationContract(Action:="getLookUpMaintenance", ReplyAction:="getLookUpMaintenance")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMaintenance() As Message

    <OperationContract(Action:="getLookUpTraining", ReplyAction:="getLookUpTraining")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTraining() As Message

    <OperationContract(Action:="getLookUpEmployeePNL11000", ReplyAction:="getLookUpEmployeePNL11000")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeePNL11000() As Message

    <OperationContract(Action:="getLookUpAnggotaKeluargaPNL15000", ReplyAction:="getLookUpAnggotaKeluargaPNL15000")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAnggotaKeluargaPNL15000() As Message

    <OperationContract(Action:="getLookUpTemporaryPositionPNL00150", ReplyAction:="getLookUpTemporaryPositionPNL00150")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTemporaryPositionPNL00150() As Message

    <OperationContract(Action:="getLookUpTemporaryAssignmentPNL00520", ReplyAction:="getLookUpTemporaryAssignmentPNL00520")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTemporaryAssignmentPNL00520() As Message

    <OperationContract(Action:="getCmbPattern", ReplyAction:="getCmbPattern")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPattern() As Message

    <OperationContract(Action:="getLookUpLetterMasterPNL01600", ReplyAction:="getLookUpLetterMasterPNL01600")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpLetterMasterPNL01600() As Message

    <OperationContract(Action:="getLookUpLetterTemplatePNL01700", ReplyAction:="getLookUpLetterTemplatePNL01700")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpLetterTemplatePNL01700() As Message

    <OperationContract(Action:="getLookUpEmployeeTransactionAndReport", ReplyAction:="getLookUpEmployeeTransactionAndReport")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeTransactionAndReport() As Message

    <OperationContract(Action:="getLookUpBPJSEmployeeAssignment", ReplyAction:="getLookUpBPJSEmployeeAssignment")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpBPJSEmployeeAssignment() As Message

#End Region

#Region "PAYROLL"
    <OperationContract(Action:="getLookUpCurrency", ReplyAction:="getLookUpCurrency")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCurrency() As Message

    <OperationContract(Action:="getLookUpSalaryGroup", ReplyAction:="getLookUpSalaryGroup")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryGroup() As Message

    <OperationContract(Action:="getLookUpTransferSalaryGroup", ReplyAction:="getLookUpTransferSalaryGroup")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTransferSalaryGroup() As Message

    <OperationContract(Action:="getLookUpSalaryGroupPeriod", ReplyAction:="getLookUpSalaryGroupPeriod")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryGroupPeriod() As Message

    <OperationContract(Action:="getLookUpEmployeeList", ReplyAction:="getLookUpEmployeeList")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeList() As Message

    <OperationContract(Action:="getLookUpMembershipEmployee", ReplyAction:="getLookUpMembershipEmployee")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMembershipEmployee() As Message

#Region "COMPONENT LIST LOOKUP"
    <OperationContract(Action:="getLookUpComponentModel1", ReplyAction:="getLookUpComponentModel1")> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpComponentModel1() As Message

    <OperationContract(Action:="getLookUpComponentModel2", ReplyAction:="getLookUpComponentModel2")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpComponentModel2() As Message

    <OperationContract(Action:="getLookUpComponentModel3", ReplyAction:="getLookUpComponentModel3")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpComponentModel3() As Message

    <OperationContract(Action:="getLookUpComponentList", ReplyAction:="getLookUpComponentList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpComponentList() As Message
#End Region

    <OperationContract(Action:="getLookUpSalaryPolicyUsage", ReplyAction:="getLookUpSalaryPolicyUsage")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryPolicyUsage() As Message

#Region "SALARY PROCESS CODE LOOKUP"
    <OperationContract(Action:="getLookUpSalaryProcessCodeModel1", ReplyAction:="getLookUpSalaryProcessCodeModel1")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryProcessCodeModel1() As Message

    <OperationContract(Action:="getLookUpSalaryProcessCodeModel2", ReplyAction:="getLookUpSalaryProcessCodeModel2")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryProcessCodeModel2() As Message

    <OperationContract(Action:="getLookUpSalaryProcessCodeModel3", ReplyAction:="getLookUpSalaryProcessCodeModel3")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryProcessCodeModel3() As Message
#End Region

    <OperationContract(Action:="getLookUpJamsostek", ReplyAction:="getLookUpJamsostek")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpJamsostek() As Message

    <OperationContract(Action:="getLookUpTransferCode", ReplyAction:="getLookUpTransferCode")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTransferCode() As Message

    <OperationContract(Action:="getLookUpBank", ReplyAction:="getLookUpBank")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpBank() As Message

    <OperationContract(Action:="getLookUpTaxOffice", ReplyAction:="getLookUpTaxOffice")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTaxOffice() As Message

    <OperationContract(Action:="getLookUpUserDefineParams", ReplyAction:="getLookUpUserDefineParams")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpUserDefineParams() As Message

    <OperationContract(Action:="getLookUpFormula", ReplyAction:="getLookUpFormula")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpFormula() As Message

    <OperationContract(Action:="getLookupRapelCompList", ReplyAction:="getLookupRapelCompList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookupRapelCompList() As Message

    <OperationContract(Action:="getLookUpBPJSBank", ReplyAction:="getLookUpBPJSBank")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpBPJSBank() As Message

    <OperationContract(Action:="getLookUpAllEmployee", ReplyAction:="getLookUpAllEmployee")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAllEmployee() As Message

    <OperationContract(Action:="getLookUpCompanyBankAccount", ReplyAction:="getLookUpCompanyBankAccount")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCompanyBankAccount() As Message

    <OperationContract(Action:="getLookUpEmployeeBankAccount", ReplyAction:="getLookUpEmployeeBankAccount")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeBankAccount() As Message

    <OperationContract(Action:="getLookUpSalaryGroupMulti", ReplyAction:="getLookUpSalaryGroupMulti")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSalaryGroupMulti() As Message

    <OperationContract(Action:="getLookUpPayrollUser", ReplyAction:="getLookUpPayrollUser")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPayrollUser() As Message

    <OperationContract(Action:="getLookUpBpjsPerusahaan", ReplyAction:="getLookUpBpjsPerusahaan")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpBpjsPerusahaan() As Message

    <OperationContract(Action:="getLookUpObjekPajak", ReplyAction:="getLookUpObjekPajak")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpObjekPajak() As Message

#End Region

#Region "ATTENDANCE"

    <OperationContract(Action:="getLookUpMachineSetting", ReplyAction:="getLookUpMachineSetting")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMachineSetting() As Message

    <OperationContract(Action:="getLookUpMachineTable", ReplyAction:="getLookUpMachineTable")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMachineTable() As Message

    <OperationContract(Action:="getLookUpReasonsParameter", ReplyAction:="getLookUpReasonsParameter")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpReasonsParameter() As Message

    <OperationContract(Action:="getLookUpHolidaysParameter", ReplyAction:="getLookUpHolidaysParameter")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpHolidaysParameter() As Message

    <OperationContract(Action:="getLookUpHolidayEmployee", ReplyAction:="getLookUpHolidayEmployee")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpHolidayEmployee() As Message

    <OperationContract(Action:="getLookUpCardMaster", ReplyAction:="getLookUpCardMaster")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpCardMaster() As Message

    <OperationContract(Action:="getLookUpOvertimeManagement", ReplyAction:="getLookUpOvertimeManagement")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpOvertimeManagement() As Message

    <OperationContract(Action:="getLookUpOvertimeIndexDetail", ReplyAction:="getLookUpOvertimeIndexDetail")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpOvertimeIndexDetail() As Message

    <OperationContract(Action:="getLookUpOvertimeRounded", ReplyAction:="getLookUpOvertimeRounded")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpOvertimeRounded() As Message

    <OperationContract(Action:="getLookUpOvertimeCalculationIndex", ReplyAction:="getLookUpOvertimeCalculationIndex")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpOvertimeCalculationIndex() As Message

    <OperationContract(Action:="getLookUpShiftManagement", ReplyAction:="getLookUpShiftManagement")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpShiftManagement() As Message

    <OperationContract(Action:="getLookUpShiftPattern", ReplyAction:="getLookUpShiftPattern")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpShiftPattern() As Message

    <OperationContract(Action:="getLookUpPatternSequence", ReplyAction:="getLookUpPatternSequence")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPatternSequence() As Message

    <OperationContract(Action:="getLookUpShiftGroup", ReplyAction:="getLookUpShiftGroup")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpShiftGroup() As Message

    <OperationContract(Action:="getLookUpShiftGroupEmployee", ReplyAction:="getLookUpShiftGroupEmployee")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpShiftGroupEmployee() As Message

    <OperationContract(Action:="getLookUpSpecialLeave", ReplyAction:="getLookUpSpecialLeave")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSpecialLeave() As Message

    <OperationContract(Action:="getLookUpAnnualLeave", ReplyAction:="getLookUpAnnualLeave")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAnnualLeave() As Message

    <OperationContract(Action:="getLookUpIncidentalLeave", ReplyAction:="getLookUpIncidentalLeave")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpIncidentalLeave() As Message

    <OperationContract(Action:="getLookUpAdditionalLeave", ReplyAction:="getLookUpAdditionalLeave")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAdditionalLeave() As Message

    '<OperationContract(Action:="getLookUpAdditionalLeaveBalance", ReplyAction:="getLookUpAdditionalLeaveBalance")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function getLookUpAdditionalLeaveBalance() As Message

    <OperationContract(Action:="getLookUpAnualLeaveEmployee", ReplyAction:="getLookUpAnualLeaveEmployee")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAnualLeaveEmployee() As Message

    <OperationContract(Action:="getLookUpSchedule", ReplyAction:="getLookUpSchedule")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSchedule() As Message

    <OperationContract(Action:="getLookUpRequestOvertime", ReplyAction:="getLookUpRequestOvertime")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpRequestOvertime() As Message

    <OperationContract(Action:="getLookUpDailyTimeHistory", ReplyAction:="getLookUpDailyTimeHistory")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpDailyTimeHistory() As Message

    <OperationContract(Action:="getLookUpRequestToDepartment", ReplyAction:="getLookUpRequestToDepartment")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpRequestToDepartment() As Message

    <OperationContract(Action:="getLookUpAnalysisTable", ReplyAction:="getLookUpAnalysisTable")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAnalysisTable() As Message

#End Region

#Region "JC"
    <OperationContract(Action:="getLookUpPositionCompetencies", ReplyAction:="getLookUpPositionCompetencies")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPositionCompetencies() As Message
#End Region

#Region "LOAN"
    '<OperationContract(Action:="getLookUpLoanTypeList", ReplyAction:="getLookUpLoanTypeList")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function getLookUpLoanTypeList() As Message

    <OperationContract(Action:="getLookUpLoanExpenseList", ReplyAction:="getLookUpLoanExpenseList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpLoanExpenseList() As Message

    <OperationContract(Action:="getLookUpLoanCategoryList", ReplyAction:="getLookUpLoanCategoryList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpLoanCategoryList() As Message

    <OperationContract(Action:="getLookUpNewLoanTransactionLNL00300", ReplyAction:="getLookUpNewLoanTransactionLNL00300")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpNewLoanTransactionLNL00300() As Message

    <OperationContract(Action:="getLookUpEmployeeLNL01000", ReplyAction:="getLookUpEmployeeLNL01000")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeLNL01000() As Message

    <OperationContract(Action:="getLookUpEmployeeLNL01500", ReplyAction:="getLookUpEmployeeLNL01500")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeLNL01500() As Message

    <OperationContract(Action:="getLookUpEmployeeLNL02000", ReplyAction:="getLookUpEmployeeLNL02000")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeLNL02000() As Message
#End Region

#Region "QA"

    'COMBO BOX

    <OperationContract(Action:="getCmbDocumentType", ReplyAction:="getCmbDocumentType")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDocumentType() As Message

    <OperationContract(Action:="getCmbDepartment", ReplyAction:="getCmbDepartment")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbDepartment() As Message

    '============================================================================================

    <OperationContract(Action:="getLookUpParentDocument", ReplyAction:="getLookUpParentDocument")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpParentDocument() As Message

    <OperationContract(Action:="getLookUpDocument", ReplyAction:="getLookUpDocument")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpDocument() As Message

    <OperationContract(Action:="getLookUpFillingMethod", ReplyAction:="getLookUpFillingMethod")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpFillingMethod() As Message
     
    <OperationContract(Action:="getLookUpSocializationHeader", ReplyAction:="getLookUpSocializationHeader")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSocializationHeader() As Message

    <OperationContract(Action:="getLookUpSocializationDetail", ReplyAction:="getLookUpSocializationDetail")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpSocializationDetail() As Message

    <OperationContract(Action:="getLookUpEmployeeQA", ReplyAction:="getLookUpEmployeeQA")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeQA() As Message


    <OperationContract(Action:="getLookUpClause", ReplyAction:="getLookUpClause")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpClause() As Message


#End Region

#End Region

#Region "MEDICAL"
    <OperationContract(Action:="getLookUpFamilyMember", ReplyAction:="getLookUpFamilyMember")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpFamilyMember() As Message

    <OperationContract(Action:="getLookUpMedicalItem", ReplyAction:="getLookUpMedicalItem")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMedicalItem() As Message

    <OperationContract(Action:="getLookUpMedicalSubItem", ReplyAction:="getLookUpMedicalSubItem")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMedicalSubItem() As Message

    <OperationContract(Action:="getLookUpBankAccount", ReplyAction:="getLookUpBankAccount")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpBankAccount() As Message

    <OperationContract(Action:="getLookUpMedicalLimitItem", ReplyAction:="getLookUpMedicalLimitItem")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMedicalLimitItem() As Message

    <OperationContract(Action:="getLookUpHealthPartner", ReplyAction:="getLookUpHealthPartner")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpHealthPartner() As Message

    <OperationContract(Action:="getLookUpMedicalRule", ReplyAction:="getLookUpMedicalRule")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMedicalRule() As Message

    <OperationContract(Action:="getLookUpPartner", ReplyAction:="getLookUpPartner")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPartner() As Message

    <OperationContract(Action:="getLookUpEmployeeFamily", ReplyAction:="getLookUpEmployeeFamily")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpEmployeeFamily() As Message

    <OperationContract(Action:="getLookUpPartnerContractTransaction", ReplyAction:="getLookUpPartnerContractTransaction")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpPartnerContractTransaction() As Message

    <OperationContract(Action:="getMedicalItem", ReplyAction:="getMedicalItem")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalItem() As Message

    <OperationContract(Action:="getMedicalPartner", ReplyAction:="getMedicalPartner")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalPartner() As Message

    <OperationContract(Action:="getMedicalIllness", ReplyAction:="getMedicalIllness")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMedicalIllness() As Message

    <OperationContract(Action:="getLookUpMedicalEmployee", ReplyAction:="getLookUpMedicalEmployee")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMedicalEmployee() As Message

    <OperationContract(Action:="getLookUpMedicalClaim", ReplyAction:="getLookUpMedicalClaim")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpMedicalClaim() As Message

    <OperationContract(Action:="getLookUpTransferBank", ReplyAction:="getLookUpTransferBank")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpTransferBank() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

#End Region

#Region "General System"
    <OperationContract(Action:="getLookUpDepartmentList", ReplyAction:="getLookUpDepartmentList")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpDepartmentList() As Message

    <OperationContract(Action:="GetLookUpCompany", ReplyAction:="GetLookUpCompany")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLookUpCompany() As Message
#End Region

#Region "STORED PROCEDURE SECTION"
    <OperationContract(Action:="RSP_Get_Payroll_Dimension", ReplyAction:="RSP_Get_Payroll_Dimension")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Get_Payroll_Dimension() As Message

    <OperationContract(Action:="RSP_GET_USER_RIGHTS", ReplyAction:="RSP_GET_USER_RIGHTS")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_GET_USER_RIGHTS() As Message

    '<OperationContract(Action:="SP_Get_Reference_Number", ReplyAction:="SP_Get_Reference_Number")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function SP_Get_Reference_Number() As String

    '<OperationContract(Action:="RSP_Check_MTD_Process", ReplyAction:="RSP_Check_MTD_Process")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function RSP_Check_MTD_Process() As Message

    '<OperationContract(Action:="RSP_Payroll_Update_Master", ReplyAction:="RSP_Payroll_Update_Master")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function RSP_Payroll_Update_Master() As Message

    '<OperationContract(Action:="SP_Get_Transaction_Profile", ReplyAction:="SP_Get_Transaction_Profile")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function SP_Get_Transaction_Profile() As Message

    '<OperationContract(Action:="RSP_Create_Rapel_Result", ReplyAction:="RSP_Create_Rapel_Result")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function RSP_Create_Rapel_Result() As Message

    '<OperationContract(Action:="SP_Get_Period", ReplyAction:="SP_Get_Period")> _
    ' <FaultContract(GetType(R_ServiceExceptions))> _
    'Function SP_Get_Period() As Message

    <OperationContract(Action:="RSP_Get_Class_Info", ReplyAction:="RSP_Get_Class_Info")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Get_Class_Info() As Message

    <OperationContract(Action:="RSP_EMPSAL_COMPONENTS", ReplyAction:="RSP_EMPSAL_COMPONENTS")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_EMPSAL_COMPONENTS() As Message

    <OperationContract(Action:="RSP_PAYROLL_LOOKUP_EMPLOYEE", ReplyAction:="RSP_PAYROLL_LOOKUP_EMPLOYEE")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_PAYROLL_LOOKUP_EMPLOYEE() As Message

    <OperationContract(Action:="RSP_PERSONEL_LOOKUP_EMPLOYEE", ReplyAction:="RSP_PERSONEL_LOOKUP_EMPLOYEE")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_PERSONEL_LOOKUP_EMPLOYEE() As Message

    <OperationContract(Action:="RSP_Build_Loan_Policy_Matrix", ReplyAction:="RSP_Build_Loan_Policy_Matrix")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Build_Loan_Policy_Matrix() As Boolean

    <OperationContract(Action:="RSP_Get_Loan_Policy_Matrix", ReplyAction:="RSP_Get_Loan_Policy_Matrix")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Get_Loan_Policy_Matrix() As Message

    <OperationContract(Action:="RSP_Get_Loan_Policy_Dimension", ReplyAction:="RSP_Get_Loan_Policy_Dimension")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Get_Loan_Policy_Dimension() As Message

    <OperationContract(Action:="RSP_Installment_Schedule", ReplyAction:="RSP_Installment_Schedule")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Installment_Schedule() As Message

    <OperationContract(Action:="RSP_View_Feasibility", ReplyAction:="RSP_View_Feasibility")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_View_Feasibility() As Message

    <OperationContract(Action:="RSP_FIND_NON_EMP_TRANSACTION", ReplyAction:="RSP_FIND_NON_EMP_TRANSACTION")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_FIND_NON_EMP_TRANSACTION() As Message

    <OperationContract(Action:="RSP_FIND_NON_EMPLOYEE", ReplyAction:="RSP_FIND_NON_EMPLOYEE")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_FIND_NON_EMPLOYEE() As Message

    <OperationContract(Action:="RSP_MDB00100", ReplyAction:="RSP_MDB00100")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_MDB00100() As Message

    <OperationContract(Action:="RSP_MEDICAL_LIMIT", ReplyAction:="RSP_MEDICAL_LIMIT")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_MEDICAL_LIMIT() As Message

    <OperationContract(Action:="RSP_GET_SELECTION_EMPLOYEE", ReplyAction:="RSP_GET_SELECTION_EMPLOYEE")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_GET_SELECTION_EMPLOYEE() As Message

#End Region

#Region "FUNCTION"
    <OperationContract(Action:="RFT_FIND_SIMILAR_EMPLOYEES", ReplyAction:="RFT_FIND_SIMILAR_EMPLOYEES")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_FIND_SIMILAR_EMPLOYEES() As Message

    <OperationContract(Action:="RFT_VALIDATE_IDENTITY", ReplyAction:="RFT_VALIDATE_IDENTITY")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_VALIDATE_IDENTITY() As Message

    <OperationContract(Action:="RFT_GET_USER_RIGHTS", ReplyAction:="RFT_GET_USER_RIGHTS")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_USER_RIGHTS() As Message

    <OperationContract(Action:="RFT_GET_PERSONAL_INFO", ReplyAction:="RFT_GET_PERSONAL_INFO")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_PERSONAL_INFO() As Message

    <OperationContract(Action:="RFT_GET_DEPARTMENT_USER", ReplyAction:="RFT_GET_DEPARTMENT_USER")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_DEPARTMENT_USER() As Message

    <OperationContract(Action:="RFT_GET_LEAVE_INFO", ReplyAction:="RFT_GET_LEAVE_INFO")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LEAVE_INFO() As Message

    <OperationContract(Action:="RFT_GET_REASONS_PARAMETER", ReplyAction:="RFT_GET_REASONS_PARAMETER")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_REASONS_PARAMETER() As Message

    <OperationContract(Action:="RFT_GET_SCHEDULE", ReplyAction:="RFT_GET_SCHEDULE")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_SCHEDULE() As Message

    <OperationContract(Action:="RFT_GET_SHIFT_GROUP", ReplyAction:="RFT_GET_SHIFT_GROUP")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_SHIFT_GROUP() As Message

    <OperationContract(Action:="RFT_GET_SHIFT_INFO", ReplyAction:="RFT_GET_SHIFT_INFO")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_SHIFT_INFO() As Message

    <OperationContract(Action:="RFT_GET_GSB_CODE_INFO", ReplyAction:="RFT_GET_GSB_CODE_INFO")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_GSB_CODE_INFO() As Message

    <OperationContract(Action:="RFT_GET_ACTUAL", ReplyAction:="RFT_GET_ACTUAL")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_ACTUAL() As Message

    <OperationContract(Action:="RFT_GET_CLASS_INFO", ReplyAction:="RFT_GET_CLASS_INFO")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_CLASS_INFO() As Message

    <OperationContract(Action:="RFT_GET_TIME_HISTORY", ReplyAction:="RFT_GET_TIME_HISTORY")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_TIME_HISTORY() As Message

    <OperationContract(Action:="RFT_GET_CURRENCY_INFO", ReplyAction:="RFT_GET_CURRENCY_INFO")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_CURRENCY_INFO() As Message

    <OperationContract(Action:="RFT_GET_LOAN_TYPE_INFO", ReplyAction:="RFT_GET_LOAN_TYPE_INFO")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LOAN_TYPE_INFO() As Message

    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Function RFT_GET_LOAN_EXPENSE_INFO() As LookUpLoanExpenseListDTO

    <OperationContract(Action:="RFT_GET_LOAN_TRANSACTION_INFO", ReplyAction:="RFT_GET_LOAN_TRANSACTION_INFO")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LOAN_TRANSACTION_INFO() As Message

    <OperationContract(Action:="RFT_GET_LOAN_SYSTEM_PARAM", ReplyAction:="RFT_GET_LOAN_SYSTEM_PARAM")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LOAN_SYSTEM_PARAM() As Message

    <OperationContract(Action:="RFT_GET_LOAN_INSTALLMENT_INFO", ReplyAction:="RFT_GET_LOAN_INSTALLMENT_INFO")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LOAN_INSTALLMENT_INFO() As Message

    <OperationContract(Action:="RFT_GET_LEAVE_BALANCE", ReplyAction:="RFT_GET_LEAVE_BALANCE")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LEAVE_BALANCE() As Message

    <OperationContract(Action:="RFT_SPLITSTRING", ReplyAction:="RFT_SPLITSTRING")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_SPLITSTRING() As Message

    <OperationContract(Action:="RFT_GET_ANALYSIS_BALANCE", ReplyAction:="RFT_GET_ANALYSIS_BALANCE")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_ANALYSIS_BALANCE() As Message

    <OperationContract(Action:="RFT_GET_ORG_STRUCTURE", ReplyAction:="RFT_GET_ORG_STRUCTURE")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_ORG_STRUCTURE() As Message

#End Region

#Region "ATP00100"
    <OperationContract(Action:="getDataATP00100", ReplyAction:="getDataATP00100")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataATP00100() As Message
#End Region

#Region "DUMMY SUB"
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPayroll1(ByVal poPar3 As List(Of LookUpEmployeeListDTO), ByVal poPar1 As List(Of RSP_GET_SELECTION_EMPLOYEEDTO), ByVal poPar4 As List(Of PNP00100GridDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPayroll2(ByVal poPar As List(Of LookUpSalaryPolicyUsageDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPayroll3(ByVal poPar1 As List(Of LookUpUserDefineParamsDTO), ByVal poPar3 As List(Of LookUpRapelComponentListDTO))

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPayroll4(ByVal poPar As List(Of LookUpSalaryGroupMultiDTO), ByVal poPar2 As List(Of LookUpTrainingDTO))


    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Sub DummyGeneralSystem(ByVal poPar1 As List(Of LookUpCompanyDTO))
    'ByVal poPar As List(Of LookUpDepartmentDTO),

    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Sub DummyPersonal(ByVal poPar As List(Of LookUpCountryDTO), ByVal poPar1 As List(Of LookUpProvinceDTO), ByVal poPar2 As List(Of LookUpCityDTO), ByVal poPar3 As List(Of LookUpPositionDTO))

    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Sub DummyPersonal1(ByVal poPar As List(Of LookUpLocationDTO), ByVal poPar1 As List(Of LookUpGradeDTO), ByVal poPar2 As List(Of LookUpCodeDTO), ByVal poPar3 As List(Of LookUpEmployeeDTO))

    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Sub DummyPersonal2(ByVal poPar As List(Of LookUpFacilityDeviceDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance(ByVal poPar2 As List(Of LookUpMachineTableDTO), ByVal poPar3 As List(Of LookUpReasonsParameterDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance1(ByVal poPar As List(Of LookUpHolidaysParameterDTO), ByVal poPar1 As List(Of LookUpHolidayEmployeeDTO), ByVal poPar2 As List(Of LookUpCardMasterDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance2(ByVal poPar1 As List(Of LookUpOvertimeRoundedDTO), ByVal poPar2 As List(Of LookUpOvertimeCalculationIndexDTO), ByVal poPar3 As List(Of LookUpShiftDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance3(ByVal poPar As List(Of LookUpShiftPatternDTO), ByVal poPar2 As List(Of LookUpShiftGroupDTO), ByVal poPar3 As List(Of LookUpShiftGroupEmployeeDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance4(ByVal poPar1 As List(Of LookUpAnualLeaveEmployeeDTO), ByVal poPar3 As List(Of LookUpRequestOvertimeDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance5(ByVal poPar As List(Of LookUpDailyTimeHistoryDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance6(ByVal poPar1 As List(Of LookUpIncidentalLeaveDTO), ByVal poPar2 As List(Of LookUpAdditionalLeaveDTO))


    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyAttendance7(ByVal poPar As List(Of LookUpAnalysisTableDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummySP(ByVal poPar As List(Of RSP_Get_Payroll_DimensionDTO), ByVal poPar1 As List(Of RSP_Get_User_RightsDTO), ByVal poPar2 As List(Of SP_Get_Reference_NumberDTO), ByVal poPar3 As List(Of RSP_Check_MTD_ProcessDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummySP1(ByVal poPar As List(Of SP_Get_PeriodDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummySP2(ByVal poPar As List(Of RSP_Empsal_ComponentsDTO), ByVal poPar1 As List(Of RSP_Payroll_Lookup_EmployeeDTO), ByVal poPar2 As List(Of RSP_Get_Loan_Policy_MatrixDTO), ByVal poPar3 As List(Of RSP_Get_Loan_Policy_DimensionDTO))

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummySP3(ByVal poPar2 As List(Of RSP_View_FeasibilityDTO))

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummySP4(ByVal poPar2 As List(Of RSP_MDB00100DTO), ByVal poPar3 As List(Of RSP_Medical_LimitDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyFunction(ByVal poPar1 As List(Of RFT_Get_Department_UserDTO), ByVal poPar2 As List(Of RFT_Get_Leave_InfoDTO), ByVal poPar3 As List(Of RFT_Get_Reasons_ParameterDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyFunction1(ByVal poPar As List(Of RFT_Get_ScheduleDTO), ByVal poPar1 As List(Of RFT_Get_Shift_GroupDTO), ByVal poPar2 As List(Of RFT_Get_Shift_InfoDTO), ByVal poPar3 As List(Of RFT_Get_Class_InfoDTO))

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyFunction2(ByVal poPar As List(Of RFT_Get_ActualDTO), ByVal poPar1 As List(Of RFT_Get_Time_HistoryDTO), ByVal poPar2 As List(Of RFT_Get_Currency_InfoDTO))

    <OperationContract()> _
           <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyFunction3(ByVal poPar As List(Of RFT_Get_Loan_System_ParamDTO), ByVal poPar1 As List(Of RFT_Get_Loan_Installment_InfoDTO), ByVal poPar2 As List(Of RFT_Get_Leave_BalanceDTO), ByVal poPar3 As List(Of RFT_SplitstringDTO))

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyFunction4(ByVal poPar As List(Of RFT_GET_ANALYSIS_BALANCEDTO), ByVal poPar1 As List(Of RFT_Get_Org_StructureDTO))

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyFunction5(ByVal poPar As List(Of RFT_Find_Similar_EmployeesDTO))

    <OperationContract()> _
           <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyMedical(ByVal poPar As List(Of LookUpFamilyMemberDTO),
                     ByVal poPar2 As List(Of LookUpMedicalSubItemDTO),
                     ByVal poPar3 As List(Of LookUpBankAccountDTO),
                     ByVal poPar4 As List(Of LookUpHealthPartnerDTO),
                     ByVal poPar5 As List(Of LookUpMedicalRuleDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyLoan(ByVal poPar As List(Of LookUpLoanCategoryDTO),
                  ByVal poPar1 As List(Of LookUpEmployeeLNL01000DTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPersonal(ByVal poPar As List(Of LookUpReferenceDTO),
                      ByVal poPar2 As List(Of LookUpEmployeePNL11000DTO)
                      )

    <OperationContract()> _
           <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of SIAPP_PUB_DTOs), ByVal poPar1 As List(Of ATP00100GridDTO))

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyJobCompetencies(ByVal poPar As List(Of JCL00100DTO))
     
    '<OperationContract()> _
    '       <FaultContract(GetType(R_ServiceExceptions))> _
    'Sub DummyPayroll(ByVal poPar1 As List(Of LookUpBPJSPerusahaanDTO))

#End Region

#Region "CLASS AND TRANSLATE"
    <OperationContract(Action:="ClassAndTranslate", ReplyAction:="ClassAndTranslate")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function ClassAndTranslate() As Message
#End Region

End Interface
