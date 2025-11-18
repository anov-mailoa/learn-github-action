Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR09100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR09100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR09100StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR09100Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

End Interface
