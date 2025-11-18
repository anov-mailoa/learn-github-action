Imports System.ServiceModel
Imports R_Common
Imports GSM00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSM00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IGSM00300Service

    Inherits R_IServicebase(Of GSM00300DTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getYearPeriod(poParam As GSM00300DTO) As GSM00300DTO

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGsmCompanies(poParam As GSM00300DTO) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPeriodMode() As List(Of GSM00300CmbDTO)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidateCurrenctPeriod(poParam As GSM00300DTO) As GSM00300DTO

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getNextYearPeriodMode(poParam As GSM00300DTO) As Boolean

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPrevYearPeriodMode(poParam As GSM00300DTO) As Boolean


End Interface
