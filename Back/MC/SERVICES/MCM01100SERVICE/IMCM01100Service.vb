Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCM01100Service" in both code and config file together.
<ServiceContract()>
Public Interface IMCM01100Service
    Inherits R_IServicebase(Of MCM01100Dto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetYear(ByRef pcCompanyId As String) As List(Of MCM01100GridYearDto)

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub CopyPrevious(poParam As MCM01100Dto)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub CopyRule(poParam As MCM01100Dto)

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DeleteAll(poParam As MCM01100Dto)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function ChkDatRul(poParam As MCM01100Dto) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDlogRecord(poParam As MCM01100Dto) As MCM01100Dto

End Interface
