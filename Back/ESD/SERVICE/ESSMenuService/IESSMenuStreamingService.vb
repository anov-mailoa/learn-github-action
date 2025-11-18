Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports ESSMenuBack

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IESSMenuStreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IESSMenuStreamingService

    <OperationContract(Action:="GetMenu", ReplyAction:="GetMenu")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetMenu() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of ESSMenuDTO))
End Interface
