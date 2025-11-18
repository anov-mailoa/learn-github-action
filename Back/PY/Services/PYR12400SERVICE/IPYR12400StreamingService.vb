Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PYR12400Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR12400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR12400StreamingService

    <OperationContract(Action:="GetSalaryGroup", ReplyAction:="GetSalaryGroup")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetSalaryGroup() As Message

    <OperationContract(Action:="GetComponentReport", ReplyAction:="GetComponentReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function GetComponentReport() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PYR12400DTO))
End Interface
