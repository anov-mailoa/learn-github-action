Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM02800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM02800StreamingService

    <OperationContract(Action:="GetDashboardList", ReplyAction:="GetDashboardList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetDashboardList() As Message

    <OperationContract(Action:="GetUserDashboardList", ReplyAction:="GetUserDashboardList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetUserDashboardList() As Message

    <OperationContract(Action:="GetDashboardAssignment", ReplyAction:="GetDashboardAssignment")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetDashboardAssignment() As Message

    <OperationContract(Action:="GetUserList", ReplyAction:="GetUserList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetUserList() As Message
End Interface
