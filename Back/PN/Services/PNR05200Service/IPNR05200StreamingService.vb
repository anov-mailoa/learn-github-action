Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR05200Back
Imports PNR05200Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR05200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR05200StreamingService

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poPar1 As List(Of PNR05200DTO), ByVal poPar2 As List(Of PNR05200GridDTO))

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
  <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getEmployeeName(pcCompId As String, pcEmpId As String) As PNR05200DTO

End Interface
