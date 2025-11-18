Imports System.ServiceModel
Imports R_Common
Imports PYT00200Back
Imports R_BackEnd

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00200DetailService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00200DetailService
    Inherits R_IServicebase(Of PYT00200DetailDTO)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function isValidDownloadExcel(poParam As PYT00200DetailDTO) As Boolean

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub UnassignEmployee(poEntity As List(Of PYT00200DetailDTO))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ProcessDetail(poEntity As List(Of PYT00200DetailDTO))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ValidationAssign(poParam As PYT00200DetailDTO)

End Interface
