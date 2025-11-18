Imports System.ServiceModel
Imports R_Common
Imports PYT00100Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00100Service

    Inherits R_IServicebase(Of PYT00100DTO)

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PYT00100DTO) As PYT00100DTO

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function validateBySubGrade(poParam As PYT00100DTO) As Boolean

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function OpenProcess(poParam As PYT00100DTO) As PYT00100DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function UpdatePytTransDt(poParam As PYT00100DTO) As Boolean

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbCurrencyRateType(poParam As PYT00100DTO) As List(Of PYT00100CmbDTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function LostFocusEmployeeId(poParam As PYT00100DTO) As PYT00100DTO


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekSalaryEffectiveDate(poParam As PYT00100DTO) As String


End Interface
