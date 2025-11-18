Imports R_BackEnd
Imports R_Common
Imports ATM00500Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM0500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00500StreamingService

    <OperationContract(Action:="OvertimeData", ReplyAction:="OvertimeData")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOvertime() As Message

    <OperationContract(Action:="DetailData", ReplyAction:="DetailData")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetail() As Message

    <OperationContract(Action:="JoinData", ReplyAction:="JoinData")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getJoin() As Message

 
End Interface
