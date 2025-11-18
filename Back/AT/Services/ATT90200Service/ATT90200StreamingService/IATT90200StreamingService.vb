Imports R_BackEnd
Imports R_Common
Imports ATT90200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90200StreamingService

    <OperationContract(Action:="LeaveData", ReplyAction:="LeaveData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeave() As Message

    <OperationContract(Action:="EmployeeData", ReplyAction:="EmployeeData")>
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployee() As Message

    <OperationContract(Action:="AdditionalData", ReplyAction:="AdditionalData")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAdditional() As Message

    <OperationContract(Action:="OvertimeData", ReplyAction:="OvertimeData")>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvertime() As Message

    <OperationContract(Action:="HistoryLeaveData", ReplyAction:="HistoryLeaveData")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistoryLeave() As Message

    <OperationContract(Action:="HistoryEmployeeData", ReplyAction:="HistoryEmployeeData")>
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistoryEmployee() As Message

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParATT00601 As List(Of ATT90201DTO), poParATT00621 As List(Of ATT90221DTO), poParATT00612 As List(Of ATT90212DTO))

End Interface
