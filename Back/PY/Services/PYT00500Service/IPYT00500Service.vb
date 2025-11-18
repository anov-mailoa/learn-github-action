Imports System.ServiceModel
Imports R_Common
Imports PYT00500Back
Imports R_BackEnd
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00500Service" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00500Service

    Inherits R_IServicebase(Of PYT00500DTO)

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEndPeriod(poParam As PYT00500DTO) As PYT00500DTO

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkTransStatus(poParam As PYT00500DTO) As String

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftProcess(poParam As PYT00500DTO) As PYT00500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function OpenProcess(poParam As PYT00500DTO) As PYT00500DTO

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub createRapidTransHeader(poParam As PYT00500DTO)

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function checkResult(poParam As PYT00500DTO) As Boolean

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getExistPeriod(poParam As PYT00500DTO) As Boolean


End Interface
