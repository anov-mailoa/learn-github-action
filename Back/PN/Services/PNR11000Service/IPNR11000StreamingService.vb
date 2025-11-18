Imports System.ServiceModel
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR11000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR11000StreamingService

    <OperationContract(Action:="getSearchList", ReplyAction:="getSearchList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSearchList() As Message

    <OperationContract(Action:="getMailMergeData", ReplyAction:="getMailMergeData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMailMergeData() As Message

End Interface
