Imports System.ServiceModel
Imports R_Common
Imports ATI00300Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATI00300SreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATI00300StreamingService
    <OperationContract(Action:="getOvtCalc", ReplyAction:="getOvtCalc")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getOvtCalc() As Message

    <OperationContract(Action:="getLeave", ReplyAction:="getLeave")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getLeave() As Message

    <OperationContract(Action:="getOvertime", ReplyAction:="getOvertime")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getOvertime() As Message

    <OperationContract(Action:="getEmployee", ReplyAction:="getEmployee")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getEmployee() As Message

    <OperationContract(Action:="getLeaveBalance", ReplyAction:="getLeaveBalance")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getLeaveBalance() As Message

    <OperationContract(Action:="getSchedule", ReplyAction:="getSchedule")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getSchedule() As Message

    <OperationContract(Action:="getDaily", ReplyAction:="getDaily")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getDaily() As Message

    <OperationContract(Action:="getAttendance", ReplyAction:="getAttendance")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getAttendance() As Message


End Interface
