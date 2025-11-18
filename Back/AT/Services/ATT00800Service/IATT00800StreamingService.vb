Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00800StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy()

    <OperationContract(Action:="ATT00800", ReplyAction:="ATT00800")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

   

End Interface
