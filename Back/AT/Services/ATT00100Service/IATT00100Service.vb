Imports R_BackEnd
Imports R_Common
Imports ATT00100Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports ATT00100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00100Service
    Inherits R_IServicebase(Of ATT00100DTO)



    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poEntity As ATT00100DTO) As ATT00100DTO

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSystemParam(pcCompId As String) As ATT00100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckShift(poParam As ATT00100DTO) As Boolean

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getScheduleDate(poParam As ATT00100DTO) As ATT00100DTO

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHoliday(poParam As ATT00100DTO) As ATT00100DTO


End Interface
