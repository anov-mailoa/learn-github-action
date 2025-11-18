Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT90300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90300StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90300StreamService
    <OperationContract(Action:="GetTransactionHistoryList", ReplyAction:="GetTransactionHistoryList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionHistoryList() As Message

    <OperationContract(Action:="GetTransactionList", ReplyAction:="GetTransactionList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionList() As Message

    <OperationContract(Action:="GetDetailList", ReplyAction:="GetDetailList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDetailList() As Message

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetDepartmentList", ReplyAction:="GetDepartmentList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDepartmentList() As Message

    <OperationContract(Action:="GetMonthList", ReplyAction:="GetMonthList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetMonthList() As Message

    <OperationContract(Action:="getListShift", ReplyAction:="getListShift")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getListShift() As Message
End Interface
