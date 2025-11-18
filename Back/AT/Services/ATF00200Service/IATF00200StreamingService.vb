Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ATF00200Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATF00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATF00200StreamingService
    <OperationContract(Action:="getLeaveBalance", ReplyAction:="getLeaveBalance")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getLeaveBalance() As Message
End Interface
