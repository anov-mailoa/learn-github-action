Imports System.ServiceModel
Imports R_Common
Imports ATT90500Back
Imports ATT90500Common
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90500StreamingService

    <OperationContract(Action:="getListLeave", ReplyAction:="getListLeave")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListLeave() As Message
     
    <OperationContract(Action:="getListLeaveHistory", ReplyAction:="getListLeaveHistory")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListLeaveHistory() As Message

    <OperationContract(Action:="getCmbLeaveCode", ReplyAction:="getCmbLeaveCode")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbLeaveCode() As Message


End Interface
