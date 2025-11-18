Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR12300Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR12200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR12300StreamingService

    <OperationContract(Action:="GetSalaryGroup", ReplyAction:="GetSalaryGroup")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetSalaryGroup() As Message

    <OperationContract(Action:="getCmbPeriod", ReplyAction:="getCmbPeriod")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbPeriod() As Message

    <OperationContract(Action:="GetReportInterface", ReplyAction:="GetReportInterface")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetReportInterface() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYR12300DTO))
End Interface
