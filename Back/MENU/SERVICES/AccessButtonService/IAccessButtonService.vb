Imports System.ServiceModel
Imports R_Common
Imports AccessButtonBack
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IAccessButtonService" in both code and config file together.
<ServiceContract()>
Public Interface IAccessButtonService

    <OperationContract(Action:="getProgramList", ReplyAction:="getProgramList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProgramList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of ProgramDTO))

End Interface
