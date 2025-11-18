Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM01200StreamingService

    <OperationContract(Action:="getMyActivity", ReplyAction:="getMyActivity")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMyActivity() As Message

    <OperationContract(Action:="getIncorrectAtt", ReplyAction:="getIncorrectAtt")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getIncorrectAtt() As Message

    <OperationContract(Action:="getOvtList", ReplyAction:="getOvtList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvtList() As Message

    <OperationContract(Action:="getOvtType", ReplyAction:="getOvtType")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvtType() As Message

    <OperationContract(Action:="getShiftList", ReplyAction:="getShiftList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getShiftList() As Message

    <OperationContract(Action:="getShiftDaysOffList", ReplyAction:="getShiftDaysOffList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getShiftDaysOffList() As Message

    <OperationContract(Action:="getLeaveList", ReplyAction:="getLeaveList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveList() As Message

    <OperationContract(Action:="getLeaveBalanceDetail", ReplyAction:="getLeaveBalanceDetail")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveBalanceDetail() As Message

    <OperationContract(Action:="getCmbReason", ReplyAction:="getCmbReason")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbReason() As Message

    <OperationContract(Action:="getLeaveBalanceList", ReplyAction:="getLeaveBalanceList")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveBalanceList() As Message

    <OperationContract(Action:="getOvtDtValueChanged", ReplyAction:="getOvtDtValueChanged")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvtDtValueChanged() As Message

    <OperationContract(Action:="RSP_ESS_GET_PAID_BY_LIST", ReplyAction:="RSP_ESS_GET_PAID_BY_LIST")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_ESS_GET_PAID_BY_LIST() As Message


End Interface
