Imports R_BackEnd
Imports R_Common
Imports PNM02700Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02700StreamingService

    <OperationContract(Action:="getFaultList", ReplyAction:="getFaultList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getFaultList() As Message

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getData() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poGrid As List(Of PNM02700GridDTO), poReport As List(Of PNM02700ReportDTO))

End Interface
