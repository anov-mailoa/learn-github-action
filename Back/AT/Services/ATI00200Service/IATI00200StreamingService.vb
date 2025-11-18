Imports System.ServiceModel
Imports ATI00200Back
Imports R_Common
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATI00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATI00200StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(poParam1 As List(Of ATI00200StreamingDTO),
              poParam2 As List(Of ATI00200ComboDTO))

    <OperationContract(Action:="getPeriod", ReplyAction:="getPeriod")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getPeriod() As Message

    <OperationContract(Action:="getGridForm200", ReplyAction:="getGridForm200")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridForm200() As Message

    <OperationContract(Action:="getGridForm210", ReplyAction:="getGridForm210")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridForm210() As Message

    <OperationContract(Action:="getGridForm220", ReplyAction:="getGridForm220")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridForm220() As Message

    <OperationContract(Action:="getGridForm230", ReplyAction:="getGridForm230")>
        <FaultContract(GetType(R_ServiceExceptions))>
    Function getGridForm230() As Message
End Interface
