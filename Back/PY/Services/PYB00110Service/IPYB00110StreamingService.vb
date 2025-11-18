Imports System.ServiceModel
Imports R_Common
Imports PYB00110Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYB00110StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYB00110StreamingService

    <OperationContract(Action:="getAvailableInterfaceList", ReplyAction:="getAvailableInterfaceList")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getAvailableInterfaceList() As Message

    <OperationContract(Action:="getProcessedInterfaceList", ReplyAction:="getProcessedInterfaceList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProcessedInterfaceList() As Message

    <OperationContract(Action:="getDetailInterfaceList", ReplyAction:="getDetailInterfaceList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailInterfaceList() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poDetail As List(Of PYB00100DetailDTO))

End Interface
