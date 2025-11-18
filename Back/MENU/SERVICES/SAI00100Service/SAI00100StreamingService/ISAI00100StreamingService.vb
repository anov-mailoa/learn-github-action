Imports System.ServiceModel
Imports R_Common
Imports SAI00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAI00100StreamingService

    <OperationContract(Action:="GetHistory", ReplyAction:="GetHistory")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHistory() As Message

    <OperationContract(Action:="GetCmbProgram", ReplyAction:="GetCmbProgram")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbProgram() As Message

    <OperationContract(Action:="GetCmbUser", ReplyAction:="GetCmbUser")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbUser() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of CmbDTO))
End Interface
