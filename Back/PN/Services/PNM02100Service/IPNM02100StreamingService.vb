Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNM02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02100StreamingService

    <OperationContract(Action:="getScoreGroups", ReplyAction:="getScoreGroups")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getScoreGroups() As Message

    <OperationContract(Action:="getScoreInfo", ReplyAction:="getScoreInfo")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getScoreInfo() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

End Interface
