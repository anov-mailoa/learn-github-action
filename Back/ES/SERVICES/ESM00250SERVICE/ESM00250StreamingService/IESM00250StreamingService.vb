Imports System.ServiceModel
Imports R_Common
Imports ESM00250Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESM00250StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESM00250StreamingService

    <OperationContract(Action:="getMenuList", ReplyAction:="getMenuList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMenuList() As Message

    <OperationContract(Action:="getMenuProgramList", ReplyAction:="getMenuProgramList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getMenuProgramList() As Message

    <OperationContract(Action:="getProgramList", ReplyAction:="getProgramList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProgramList() As Message

    '<OperationContract(Action:="getProgramButton", ReplyAction:="getProgramButton")> _
    '<FaultContract(GetType(R_ServiceExceptions))> _
    'Function getProgramButton() As Message
End Interface
