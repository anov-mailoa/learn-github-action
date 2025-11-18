Imports System.ServiceModel
Imports R_Common
Imports PYT00200Back
Imports R_BackEnd


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00200HeaderService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00200HeaderService
    Inherits R_IServicebase(Of PYT00200HeaderDetailDTO)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkActivePeriod(poParam As PYT00200HeaderDetailDTO) As Boolean

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSalaryGroupDetail(poParam As PYT00200HeaderDetailDTO) As PYT00200HeaderDetailDTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PYT00200HeaderDetailDTO) As PYT00200HeaderDetailDTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function OpenProcess(poParam As PYT00200HeaderDetailDTO) As PYT00200HeaderDetailDTO


    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function cekSalaryEffectiveDate(poParam As PYT00200HeaderDetailDTO) As String

End Interface
