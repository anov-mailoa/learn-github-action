Imports System.ServiceModel
Imports R_Common
Imports GST00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IGST00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IGST00100StreamingService

    <OperationContract(Action:="getGridInbox", ReplyAction:="getGridInbox")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridInbox() As Message

    <OperationContract(Action:="getGridOutbox", ReplyAction:="getGridOutbox")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridOutbox() As Message

    <OperationContract(Action:="getGridOutbox1", ReplyAction:="getGridOutbox1")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridOutbox1() As Message

    <OperationContract(Action:="getGridDraft", ReplyAction:="getGridDraft")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getGridDraft() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of GST00100InboxGridDTO), ByVal poPar2 As List(Of GST00100OutboxGrid2DTO))

End Interface
