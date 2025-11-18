Imports System.ServiceModel
Imports R_Common
Imports SAM01700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ISAM01700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ISAM01700StreamingService

    <OperationContract(Action:="GetHistory", ReplyAction:="GetHistory")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetHistory() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of SAM01700DTO))
End Interface
