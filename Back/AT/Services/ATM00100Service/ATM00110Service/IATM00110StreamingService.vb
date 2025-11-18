Imports System.ServiceModel
Imports ATM00100Back
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00110StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00110StreamingService


    <OperationContract(Action:="ATM0110", ReplyAction:="ATM0110")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getATM0110List() As Message

    <OperationContract(Action:="ATM0110Detail", ReplyAction:="ATM0110Detail")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getATM0110DetailList() As Message

End Interface
