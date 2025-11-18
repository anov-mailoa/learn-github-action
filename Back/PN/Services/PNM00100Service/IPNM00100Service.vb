Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM00100Service
    Inherits R_IServicebase(Of PNM00100DTO)

    <OperationContract()>
    Sub DoWork()

    '  <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '  Function checkDetail(poParam As PNM02100ScoreGroupsDTO) As Boolean

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRecord(poParam As PNM00100DTO) As PNM00100DTO

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_ADD_EMPLOYEE_TYPE()

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkPntTransactionHd(poParam As PNM00100DTO) As Boolean

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCheckSyntax(poParam As PNM00100DTO) As PNM00100DTO
End Interface
