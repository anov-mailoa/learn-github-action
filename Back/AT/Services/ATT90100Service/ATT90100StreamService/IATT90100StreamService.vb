Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90100StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90100StreamService
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

    <OperationContract(Action:="GetMonthList", ReplyAction:="GetMonthList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMonthList() As Message

    <OperationContract(Action:="getLookUpShift", ReplyAction:="getLookUpShift")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getLookUpShift() As Message
End Interface
