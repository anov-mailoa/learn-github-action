Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNM02400Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02400StreamingService

    <OperationContract(Action:="PnmGradeHd", ReplyAction:="PnmGradeHd")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPnmGradeHd() As Message

    <OperationContract(Action:="PnmGradeDt", ReplyAction:="PnmGradeDt")> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPnmGradeDt() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of PNM02400ReportDTO))

End Interface
