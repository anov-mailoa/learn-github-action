Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00300Back
Imports System.ServiceModel.Channels
Imports ATT00300Common
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00300Service" in both code and config file together.
<ServiceContract()>
Public Interface IATT00300Service
    Inherits R_IServicebase(Of ATT00300DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function DraftSubmit(poEntity As ATT00300DTO) As ATT00300DTO
     
    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSchedule(poEntity As ATT00300DTO) As ATT00300DTO

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getScheduleWorkGroup(poEntity As ATT00300DTO) As ATT00300DTO

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function permission_Validate(poEntity As ATT00300DTO) As ATT00300DTO


End Interface
