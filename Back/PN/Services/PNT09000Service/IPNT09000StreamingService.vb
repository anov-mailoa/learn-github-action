Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNT09000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09000StreamingService

    <OperationContract(Action:="getPnhEmpOffense", ReplyAction:="getPnhEmpOffense")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPnhEmpOffense() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPNT09300(ByVal poParam As System.Collections.Generic.List(Of PNT09300StreamingDTO))

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub DummyPNT09400(ByVal poParam As System.Collections.Generic.List(Of PNT09400StreamingDTO))

End Interface
