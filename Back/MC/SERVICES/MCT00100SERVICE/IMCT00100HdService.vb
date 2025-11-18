Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports MCT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCT00100HdService
    Inherits R_IServicebase(Of MCT00100HdDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLimitPolicyYear(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DisplayValidation(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMedicalRestriction(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLimitPolicy(poParam As MCT00100HdDTO) As MCT00100HdDTO


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeInfo(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function SubmitProcess(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ReDraftProcess(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidatePayMethod(pcCompId As String, pcEmployeeId As String) As Integer

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLocalTypeCurrency(poParam As MCT00100HdDTO) As MCT00100HdDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCurrencyRate(poParam As MCT00100HdDTO) As Decimal

End Interface