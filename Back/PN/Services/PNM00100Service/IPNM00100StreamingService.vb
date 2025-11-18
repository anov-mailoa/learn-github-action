Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM00100StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getData() As Message

    <OperationContract(Action:="getHistory", ReplyAction:="getHistory")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getHistory() As Message

    <OperationContract(Action:="GetLocalCurrency", ReplyAction:="GetLocalCurrency")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetLocalCurrency() As Message


    <OperationContract(Action:="getSourceList", ReplyAction:="getSourceList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getSourceList() As Message

    <OperationContract(Action:="GetFullNameList", ReplyAction:="GetFullNameList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetFullNameList() As Message

End Interface
