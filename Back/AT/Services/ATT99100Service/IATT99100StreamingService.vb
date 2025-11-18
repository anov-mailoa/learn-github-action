Imports System.ServiceModel.Channels
Imports ATT99100Back
Imports R_Common


' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT99100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT99100StreamingService

    <OperationContract(Action:="getTransaction", ReplyAction:="getTransaction")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getTransaction() As Message


    <OperationContract(Action:="getTransactionType", ReplyAction:="getTransactionType")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getTransactionType() As Message

    'MT CR Pop Up Mass Leave
    <OperationContract(Action:="getDataGridMassLeave", ReplyAction:="getDataGridMassLeave")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getDataGridMassLeave() As Message

    'MT CR Pop Up Leave
    <OperationContract(Action:="getDataGridLeave", ReplyAction:="getDataGridLeave")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getDataGridLeave() As Message
End Interface
