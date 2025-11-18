Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATT90400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90400StreamingService
    <OperationContract(Action:="getAdditional", ReplyAction:="getAdditional")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAdditional() As Message
     
    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="getPopUpEmployee", ReplyAction:="getPopUpEmployee")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPopUpEmployee() As Message

    <OperationContract(Action:="getEmployeeDetail", ReplyAction:="getEmployeeDetail")>
             <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeDetail() As Message


End Interface
