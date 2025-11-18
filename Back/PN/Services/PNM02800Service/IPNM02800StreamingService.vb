Imports System.ServiceModel
Imports R_Common
Imports PNM02800Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02800StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02800StreamingService

    <OperationContract(Action:="getApprreciationList", ReplyAction:="getApprreciationList")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getApprreciationList() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poGrid As List(Of PNM02800GridDTO))

End Interface
