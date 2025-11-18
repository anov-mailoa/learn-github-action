Imports System.ServiceModel
Imports R_Common
Imports PNM14000Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM14000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM14000StreamingService

    <OperationContract(Action:="getListGeography", ReplyAction:="getListGeography")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGeography() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As List(Of PNM14000TreeDTO))

End Interface
