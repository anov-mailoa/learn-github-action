Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00300Service_Reguler" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00300Service_Reguler
    Inherits R_IServicebase(Of LNT00300Dto)

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getStarDate(poParam As LNT00300Dto) As String

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPrincipal(poParam As LNT00300Dto) As Decimal

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRemaining(poParam As LNT00300Dto) As LNT00300Dto

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getValidateReschedule(poParam As LNT00300Dto) As Integer

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCountTenor(poParam As LNT00300Dto) As Integer


    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poParam As LNT00300Dto) As LNT00300Dto
End Interface
