Imports System.ServiceModel
Imports R_Common
Imports ATT90600Back
Imports ATT90600Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90600StreamingService

    <OperationContract(Action:="getListCompensatory", ReplyAction:="getListCompensatory")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCompensatory() As Message

    <OperationContract(Action:="getListCompensatoryHistory", ReplyAction:="getListCompensatoryHistory")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListCompensatoryHistory() As Message

    <OperationContract(Action:="getCmbLeaveCode", ReplyAction:="getCmbLeaveCode")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbLeaveCode() As Message

    <OperationContract(Action:="getLeaveBalance", ReplyAction:="getLeaveBalance")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveBalance() As Message

End Interface
