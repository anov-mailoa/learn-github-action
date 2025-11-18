Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PYR09001Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYR08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYR09001StreamingService

 
    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract(Action:="getMasaPajak", ReplyAction:="getMasaPajak")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getMasaPajak() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of PYR09001DTO))

End Interface
