Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR12200Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR12200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR12200StreamingService

    <OperationContract(Action:="GetSalaryGroup", ReplyAction:="GetSalaryGroup")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetSalaryGroup() As Message

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetReportData() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function CheckSalaryRange(poEntity As PYR12200DTO) As PYR12200DTO

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYR12200GridDTO))
End Interface
