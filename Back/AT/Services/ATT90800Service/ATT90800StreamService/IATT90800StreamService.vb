Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports System.ServiceModel.Channels
Imports ATT90800Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90800StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90800StreamService
    <OperationContract(Action:="GetTransactionHistoryList", ReplyAction:="GetTransactionHistoryList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionHistoryList() As Message

    <OperationContract(Action:="GetTransactionList", ReplyAction:="GetTransactionList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionList() As Message

    <OperationContract(Action:="GetLeaveList", ReplyAction:="GetLeaveList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLeaveList() As Message

    <OperationContract(Action:="GetMonthList", ReplyAction:="GetMonthList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMonthList() As Message
End Interface
