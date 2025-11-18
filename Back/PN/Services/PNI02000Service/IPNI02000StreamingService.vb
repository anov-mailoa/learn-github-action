Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNI02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNI02000StreamingService

    <OperationContract(Action:="getOutstanding", ReplyAction:="getOutstanding")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getOutstanding() As Message

    <OperationContract(Action:="getTransactionType", ReplyAction:="getTransactionType")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getTransactionType() As Message

    <OperationContract(Action:="getOutstandingTransaction", ReplyAction:="getOutstandingTransaction")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getOutstandingTransaction() As Message
End Interface
