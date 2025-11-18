Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATB00100Back
Imports ATB00100Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATB00100Service" in both code and config file together.
<ServiceContract()>
Public Interface IATB00100Service

    Inherits R_IServicebase(Of ATB00100DTO)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Validation(poParam As ATB00100DTO)

    <OperationContract(Action:="getMachineTable", ReplyAction:="getMachineTable")>
           <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMachineTable(pcCompId As String) As List(Of ATM_MACHINE_TABLEDTO)

    <OperationContract()>
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetProcessFromDate(poParam As ATB00100DTO) As String

    <OperationContract(Action:="ValidateMachineType", ReplyAction:="ValidateMachineType")>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function ValidateMachineType(pcCompId As String, pcMachineType As String) As ATB00100DTO
End Interface
