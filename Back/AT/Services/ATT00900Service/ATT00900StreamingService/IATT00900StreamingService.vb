Imports R_BackEnd
Imports R_Common
Imports ATT00900Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00900StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00900StreamingService


    <OperationContract(Action:="AnalysisData", ReplyAction:="AnalysisData")>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAnalysis() As Message

    <OperationContract(Action:="HistoryData", ReplyAction:="HistoryData")>
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHistory() As Message

    <OperationContract(Action:="SummaryData", ReplyAction:="SummaryData")>
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getSummary() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of ATT00900StreamingDTO), poParATT00901 As List(Of ATT00901StreamingDTO), poParATT00910 As List(Of ATT00910StreamingDTO))

End Interface
