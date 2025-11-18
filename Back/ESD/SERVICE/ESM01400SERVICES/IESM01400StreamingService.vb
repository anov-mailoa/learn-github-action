Imports R_Common
Imports ESM01400Back
Imports ESM01400Common
Imports System.ServiceModel
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01400StreamingService

    <OperationContract(Action:="getTreeList", ReplyAction:="getTreeList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTreeList() As Message

    <OperationContract(Action:="getEmployeeList", ReplyAction:="getEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeList() As Message

    <OperationContract(Action:="getEmployeeLeaveInfo", ReplyAction:="getEmployeeLeaveInfo")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeLeaveInfo() As Message

    <OperationContract(Action:="getHistoryLeaveInfo", ReplyAction:="getHistoryLeaveInfo")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistoryLeaveInfo() As Message

    <OperationContract(Action:="getEmployeeAttendanceList", ReplyAction:="getEmployeeAttendanceList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeAttendanceList() As Message

    <OperationContract(Action:="getEmployeeData", ReplyAction:="getEmployeeData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeData() As Message

    <OperationContract(Action:="getOvertimeCalcIndex", ReplyAction:="getOvertimeCalcIndex")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvertimeCalcIndex() As Message


End Interface
