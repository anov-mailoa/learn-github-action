Imports System.ServiceModel
Imports R_Common
Imports PYB00110Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00120StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00120StreamingService

    <OperationContract(Action:="getFestivalInterfaceList", ReplyAction:="getFestivalInterfaceList")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getFestivalInterfaceList() As Message

    <OperationContract(Action:="getDetailInterfaceList", ReplyAction:="getDetailInterfaceList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailInterfaceList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poDetail As List(Of PYB00100DetailDTO))

End Interface
