Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM03100Service" in both code and config file together.
<ServiceContract()>
Public Interface IPNM03100Service
    Inherits R_IServicebase(Of PNM03100DTO)

    '  <OperationContract()>
    '<FaultContract(GetType(R_ServiceExceptions))> _
    '  Sub RSP_GET_POSITION_RIGHTS(poParam As PNM03100DTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveJobDesc(poParam As PNM03100CopyFromDTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveTraining(poParam As PNM03100CopyFromDTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveJobSpec(poParam As PNM03100CopyFromDTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub saveJobCompetency(poParam As PNM03100CopyFromDTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_PNM_ORG_STRUCTURE_MOVE_POSITION(poParam As PNM03100DTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub ActiveToInactive(poParam As PNM03100DTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEditValidate(poParam As PNM03100DTO) As Boolean

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function validateNoChild(poParam As PNM03100DTO) As Boolean

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function checkHasPosition(pcCompId As String) As Boolean

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function validateJCandiNoResources(poParam As PNM03100DTO) As Boolean

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function RFN_GET_NO_OF_RESOURCES(poParam As PNM03100DTO) As Boolean

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Function validateParentResources(poParam As PNM03100DTO)

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub RSP_UPLOAD_ORG_STRUCTURE(poParam As PNM03100DTO)

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLevelParent(poParam As PNM03100DTO) As Integer

    <OperationContract()>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getParentPositionCode(poParam As PNM03100DTO) As String

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function MemberOfEmployee(poParam As PNM03100DTO) As Boolean

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function UsePosition(poParam As PNM03100DTO) As Integer

    <OperationContract()>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub EditTree(poParam As PNM03100DTO)

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMinResources(poParam As PNM03100DTO) As Integer

    <OperationContract()>
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function validateHistoryEmployee(poParam As PNM03100DTO) As Boolean



End Interface
