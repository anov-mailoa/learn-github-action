Imports System.ServiceModel
Imports ATM00150Back
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATM00150StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATM00150StreamingService


    <OperationContract(Action:="ATM0150", ReplyAction:="ATM0150")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getATM0150List() As Message

    <OperationContract(Action:="ATM0150Detail", ReplyAction:="ATM0150Detail")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getATM0150DetailList() As Message

End Interface
