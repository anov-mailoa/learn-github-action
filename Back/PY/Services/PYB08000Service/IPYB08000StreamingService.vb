Imports System.ServiceModel
Imports R_Common
Imports PYB08000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB08000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB08000StreamingService

    <OperationContract(Action:="getList", ReplyAction:="getList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getList() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar2 As System.Collections.Generic.List(Of PYB08000Dto))

End Interface
