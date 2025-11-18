Imports System.ServiceModel
Imports R_Common
Imports GSR00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGSR00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGSR00100StreamingService

    <OperationContract(Action:="getReportList", ReplyAction:="getReportList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportList() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of GSR00100DTO))

End Interface
