Imports System.ServiceModel
Imports R_Common
Imports SAM01600Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01600StreamingService

    <OperationContract(Action:="GetDatabaseName", ReplyAction:="GetDatabaseName")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetDatabaseName() As Message

    <OperationContract(Action:="GetServerName", ReplyAction:="GetServerName")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetServerName() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar2 As List(Of DatabaseDTO), ByVal poPar3 As List(Of ServerDTO))

End Interface
