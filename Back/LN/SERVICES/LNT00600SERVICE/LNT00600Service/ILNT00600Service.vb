Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00600Service" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00600Service
    Inherits R_IServicebase(Of LNT00600Dto)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionProfile(ByVal poParam As LNT00600Dto) As LNT00600Dto

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Draft(poParam As LNT00600Dto) As LNT00600Dto

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function Submit(poParam As LNT00600Dto) As LNT00600Dto

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRemaining(poParam As LNT00600Dto) As LNT00600Dto

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkStatus(poParam As LNT00600Dto) As Boolean

End Interface
