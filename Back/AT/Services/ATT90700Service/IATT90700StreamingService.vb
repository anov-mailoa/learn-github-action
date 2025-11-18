Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports ATT90700Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT90700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT90700StreamingService
    <OperationContract(Action:="getLeaveBeginning", ReplyAction:="getLeaveBeginning")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveBeginning() As Message

    <OperationContract(Action:="getDetail", ReplyAction:="getDetail")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetail() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="getLeaveDesc", ReplyAction:="getLeaveDesc")>
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveDesc() As Message

    <OperationContract(Action:="getXML", ReplyAction:="getXML")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getXML() As Message
End Interface
