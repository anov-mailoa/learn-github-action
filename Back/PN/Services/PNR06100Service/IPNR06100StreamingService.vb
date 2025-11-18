Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR06100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR06100StreamingService" in both code and config file together.

<ServiceContract()>
Public Interface IPNR06100StreamingService

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR06100Dto))
End Interface
