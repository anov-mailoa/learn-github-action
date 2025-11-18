Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT07100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT07100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT07100StreamingService

    <OperationContract(Action:="GetOutstandingTransactionList", ReplyAction:="GetOutstandingTransactionList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetOutstandingTransactionList() As Message


    <OperationContract(Action:="GetTrxList", ReplyAction:="GetTrxList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTrxList() As Message

End Interface
