Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports SIAPP_PUB_DTO
'Imports SIAPP_PUB_DTO_NEW

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISIAPP_PUB_DTOService" in both code and config file together.
<ServiceContract()>
Public Interface ISIAPP_PUB_DTOService

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetPDP(compID As String) As String

    '<OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Function getGlobalVar(pcCompanyId As String,
    '                      pcUserId As String) As GlobalVarDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function ClassAndTranslate(poParam As ParameterDTO) As List(Of LookUpCmbDTO)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLookUpAttendanceSettingParameter(pcCompId As String) As LookUpAttendanceSettingParameterDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_VALIDATE_PN_CANCEL_TRANSACTION(poParam As ParameterDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_CHECK_MTD_PROCESS(poParam As ParameterSPDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GET_LAST_ATT_PYR_DATE(poParam As ParameterDTO) As String

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GET_PY_SYSTEM_PARAM(poParam As ParameterDTO) As PYSystemParamDTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function RSP_GET_TRX_ATTACHMENT_HEADER(poParam As ParameterDTO) As SIAPP_PUB_DTOs

#Region "LOOKUP CLASS"
#Region "PAYROLL"

#Region "COMBOBOX COMPONENT TYPE"
    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbLookUpComponent() As List(Of LookUpCmbDTO)
#End Region

#End Region

#Region "PERSONAL"

    '   <OperationContract()> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '   Function GetLookUpRftDeptUser(poParam As ParameterDTO) As List(Of LookUpDepartmentDTO)

#End Region

#Region "FUNCTION GET DESCRIPTION FOR LOOKUP"

#Region "PERSONEL"
    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL01000DESC(poParam As ParameterDTO) As LookUpCountryDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL01100DESC(poParam As ParameterDTO) As LookUpProvinceDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL01110DESC(poParam As ParameterDTO) As LookUpCityDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00100DESC(poParam As ParameterDTO) As LookUpPositionDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00200DESC(poParam As ParameterDTO) As LookUpLocationDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00300DESC(poParam As ParameterDTO) As LookUpGradeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00400DESC(poParam As ParameterDTO) As LookUpCodeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00500DESC(poParam As ParameterDTO) As LookUpEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00501DESC(poParam As ParameterDTO) As LookUpActiveEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00502DESC(poParam As ParameterDTO) As LookUpEmployeeWithFacilityDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00503DESC(poParam As ParameterDTO) As LookUpProbationEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00504DESC(poParam As ParameterDTO) As LookUpResignedContractEmployeeDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00505DESC(poParam As ParameterDTO) As LookUpActiveContractEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00506DESC(poParam As ParameterDTO) As LookUpReactivationEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00600DESC(poParam As ParameterDTO) As LookUpFacilityDeviceDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00700DESC(poParam As ParameterDTO) As LookUpEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00900DESC(poParam As ParameterDTO) As LookUpCriteriaDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL1000DESC(poParam As ParameterDTO) As LookUpCodeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL02000DESC(poParam As ParameterDTO) As LookUpGeographyDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL02010DESC(poParam As ParameterDTO) As LookUpEmployeeTransactionAndReportDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL02050DESC(poParam As ParameterDTO) As LookUpBPJSEmployeeAssignmentDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL02100DESC(poParam As ParameterDTO) As LookUpFasilitasKesehatanDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL09000ApreciationDESC(poParam As ParameterDTO) As LookUpMaintenanceDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL09000OffenseDESC(poParam As ParameterDTO) As LookUpMaintenanceDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL15000DESC(poParam As ParameterDTO) As LookUpAnggotaKeluargaPNL15000DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00150DESC(poParam As ParameterDTO) As LookUpTemporaryPositionPNL00150DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00520DESC(poParam As ParameterDTO) As LookUpTemporaryAssignmentPNL00520DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL01600DESC(poParam As ParameterDTO) As LookUpLetterMasterPNL01600DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL01700DESC(poParam As ParameterDTO) As LookUpLetterTemplatePNL01700DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00521DESC(poParam As ParameterDTO) As LookUpTemporaryAssignmentReportPNL00521DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00530DESC(poParam As ParameterDTO) As LookUpEmployeeProbationHistoryPNL00530DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00540DESC(poParam As ParameterDTO) As LookUpEmployeeContractHistoryPNL00540DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL00550DESC(poParam As ParameterDTO) As LookUpEmployeeTransferPNL00550DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function PNL05100DESC(poParam As ParameterDTO) As LookUpBPJSPerusahaanDTO



#End Region

#Region "ATTENDANCE"

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL00200DESC(poParam As ParameterDTO) As LookUpMachineSettingDTO

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL00800DESC(poParam As ParameterDTO) As LookUpOvertimeIndexCodeDTO

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL00900DESC(poParam As ParameterDTO) As LookUpOvertimeIndexDetailDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL01400DESC(poParam As ParameterDTO) As LookUpPatternSequenceDTO

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL01700DESC(poParam As ParameterDTO) As LookUpSpecialLeaveDTO

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL01800DESC(poParam As ParameterDTO) As LookUpAnnualLeaveDTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL02200DESC(poParam As ParameterDTO) As LookUpScheduleDTO

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function ATL02500DESC(poParam As ParameterDTO) As LookUpRequestToDepartmentDTO
#End Region

#Region "LOAN"
    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function LNL00100DESC(poParam As ParameterFuncDTO) As RFT_Get_Loan_TypeDTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function LNL00200DESC(poParam As ParameterDTO) As LookUpLoanExpenseListDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_LOAN_EXPENSE_INFO(poParam As ParameterFuncDTO) As LookUpLoanExpenseListDTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function LNL00300DESC(poParam As ParameterDTO) As LookUpNewLoanTransactionLNL00300DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function LNL01500DESC(poParam As ParameterDTO) As LookUpEmployeeLNL01500DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function LNL02000DESC(poParam As ParameterDTO) As LookUpEmployeeLNL02000DTO
#End Region

#Region "GENERAL SYSTEM"
    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GSL00100DESC(poParam As ParameterDTO) As LookUpDepartmentDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GSL00200DESC(poParam As ParameterDTO) As LookUpCompanyDTO
#End Region

#Region "PUBLIC FUNCTION"
    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_PERSONAL_INFO_DESC(poParam As ParameterFuncDTO) As RFT_Get_Personal_InfoDTO
#End Region

#Region "PAYROLL"

#Region "COMPONENT MODEL 1 - 3"

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00100DESC(poParam As ParameterDTO) As LookUpSalaryGroupDTO

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00401DESC(poParam As ParameterDTO) As LookUpComponentDTO 'model 1

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00402DESC(poParam As ParameterDTO) As LookUpComponentDTO 'model 1

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00403DESC(poParam As ParameterDTO) As LookUpComponentDTO 'model 3

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00610DESC(poParam As ParameterDTO) As LookUpSalaryProcessCodeDTO 'getLookUpSalaryProcessCodeModel1

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00620DESC(poParam As ParameterDTO) As LookUpSalaryProcessCodeDTO 'getLookUpSalaryProcessCodeModel2

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00700DESC(poParam As ParameterDTO) As LookUpCurrencyDTO 'getLookUpCurrency

    <OperationContract()> _
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01000DESC(poParam As ParameterDTO) As LookUpPayrollUserDTO

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01400DESC(poParam As ParameterDTO) As LookUpBankDTO

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01500DESC(poParam As ParameterDTO) As LookUpJamsostekDTO

    <OperationContract()> _
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01800DESC(poParam As ParameterDTO) As LookUpCompanyBankAccountDTO

    <OperationContract()> _
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL02000DESC(poParam As ParameterDTO) As LookUpFormulaDTO

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL02100DESC(poParam As ParameterDTO) As LookUpSalaryGroupDTO

#End Region

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00900DESC(poParam As ParameterDTO) As LookUpBPJSBankDTO

    <OperationContract()> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01600DESC(poParam As ParameterDTO) As LookUpTaxOfficeDTO

    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL00200DESC(poParam As ParameterDTO) As LookUpSalaryGroupPeriodDTO

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01300DESC(poParam As ParameterDTO) As LookUpTransferCodeDTO

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function PYL01150DESC(poParam As ParameterDTO) As LookUpAllEmployeeDTO

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function NEL00100DESC(poParam As ParameterDTO) As LookUpObjekPajakDTO

#End Region

#Region "MEDICAL"
    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function MDL00500DESC(poParam As ParameterDTO) As LookUpMedicalItemDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL00100DESC(poParam As ParameterDTO) As LookUpMedicalEmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL00200DESC(poParam As ParameterDTO) As LookUpMedicalPartnerDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL00300DESC(poParam As ParameterDTO) As LookUpMedicalEmployeeFamilyDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL00400DESC(poParam As ParameterDTO) As LookUpMedicalPartnerContractTransactionDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL00500DESC(poParam As ParameterDTO) As LookUpMedicalClaimDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL00600DESC(poParam As ParameterDTO) As LookUpTransferBankDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MCL01000DESC(poParam As ParameterDTO) As RSP_Employee_Medical_ClaimDTO

#End Region

#Region "QA"
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function QAL00100DESC(poParam As ParameterDTO) As QAL00100DTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function QAL00300DESC(poParam As ParameterDTO) As QAL00300DTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function QAL00400DESC(poParam As ParameterDTO) As QAL00400DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function QAL00500DESC(poParam As ParameterDTO) As QAL00500DTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function QAL01000DESC(poParam As ParameterDTO) As QAL01000DTO

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function QAL01100DESC(poParam As ParameterDTO) As QAL01100DTO

#End Region

#Region "JC"
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function JCL00100DESC(poParam As ParameterDTO) As String

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function JCL01000DESC(poParam As ParameterDTO) As JCL01000DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function JCL02000DESC(poParam As ParameterDTO) As JCL02000DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function JCL03000DESC(poParam As ParameterDTO) As JCL03000DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function JCL04000DESC(poParam As ParameterDTO) As JCL04000DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function JCL04100DESC(poParam As ParameterDTO) As JCL04000DTO

#End Region
#End Region

#Region "FUNCTION GET DESCRIPTION FOR LABEL ON LOOKUP"
    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDescLabelGroup(poParam As ParameterDTO) As String

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDescLabelProcess(poParam As ParameterDTO) As String
#End Region
#End Region

#Region "VALIDATE FUNCTION PAYROLL"
    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function isAuthorizedDepartment(poParam As ParameterDTO) As LookUpDepartmentDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function isAuthorizedSalaryGroup(poParam As ParameterDTO) As LookUpSalaryGroupDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function isValidPeriod(poParam As ParameterDTO) As LookUpSalaryGroupPeriodDTO
#End Region

#Region "PUBLIC FUNCTION"

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDataATP00100DESC(poParam As ParameterDTO) As RSP_Personel_Lookup_EmployeeDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_FIND_NON_EMPLOYEE_DESC(poParam As ParameterSPDTO) As RSP_Find_Non_EmployeeDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_FIND_NON_EMP_TRANSACTION_DESC(poParam As ParameterSPDTO) As RSP_Find_Non_Emp_TransactionDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_Get_Hours(poParam As ParameterFuncDTO) As RFT_Get_HoursDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_HOURS_ADD(poParam As ParameterFuncDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_MCM_CHECK_SYNTAX(pcCompanyId As String, pcFormula As String) As RSP_Medical_Check_SyntaxDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Numeric_Encryption(poParam As ParameterFuncDTO) As Byte()

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_GET_ACTIVE_INDEX(poParam As ParameterFuncDTO) As ParameterFuncDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Numeric_Decryption(poParam As ParameterFuncDTO) As Decimal

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Get_Transaction_No_Used(poParam As ParameterFuncDTO) As Integer

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Get_Period(poParam As ParameterFuncDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Check_MTD_Process(poParam As ParameterFuncDTO) As Integer

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_Get_CutOff_Shift_Date(poParam As ParameterFuncDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_PERSONNEL_SYSTEM(poParam As ParameterFuncDTO) As RFT_Get_Personnel_SystemDTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFT_GET_PERIOD_INDEX_INFO(poParam As ParameterDTO) As RFT_GET_PERIOD_INDEX_INFO_DTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_CHECK_RESTRICT_SALARY(pcCompId As String) As Integer

#End Region

#Region "ENCRYPTION"
    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function SetKey(ByVal pcKey As String) As String
#End Region

#Region "STORED PROCEDURE"
    <OperationContract()> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function SP_Get_Reference_Number(poParam As ParameterSPDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function SP_Get_Period(poParam As ParameterSPDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function SP_Get_Transaction_Profile(poParam As ParameterSPDTO) As SP_Get_Transaction_ProfileDTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Principal_Validation(poParam As ParameterSPDTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Set_Festival_Settlement(poParam As ParameterSPDTO) As Boolean

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Reset_Festival_Settlement(poParam As ParameterSPDTO) As Boolean

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_Payroll_Update_Master(poParam As ParameterSPDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_Create_Rapel_Result(poParam As ParameterSPDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_ATTENDANCE_PROCESS(poParam As ParameterSPDTO) As Boolean

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Loan_Check_Syntax(pcComp As String, pcFormula As String) As RSP_Loan_Check_SyntaxDTO

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_CHECK_LETTER_SYNTAX(poParam As ParameterSPDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_UPLOAD_PERSONNEL(poParam As ParameterSPDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PNM_ORG_STRUCTURE_ADD(poParam As ParameterSPDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PNM_ORG_STRUCTURE_EDIT(poParam As ParameterSPDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PNM_ORG_STRUCTURE_DELETE(poParam As ParameterSPDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PNM_ORG_STRUCTURE_FIRST_TIME(poParam As ParameterSPDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_GET_EMPLOYEE_ID(poParam As ParameterSPDTO) As String

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_TRANSACTION_VALIDATION(poParam As ParameterSPDTO)
#End Region

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GeneratePeriod(poParam As GeneratePeriodDTO) As List(Of GeneratePeriodDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_LN_CANCEL_TRANSACTION(poParam As ParameterDTO)

End Interface
