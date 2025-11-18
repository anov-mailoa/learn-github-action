Imports System.ServiceModel.Channels
Imports ATT00800Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00810StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00810StreamingService

    <OperationContract(Action:="getHistoryList", ReplyAction:="getHistoryList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getHistoryList() As Message

    <OperationContract(Action:="getHistoryListView", ReplyAction:="getHistoryListView")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getHistoryListView() As Message

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy()

End Interface
