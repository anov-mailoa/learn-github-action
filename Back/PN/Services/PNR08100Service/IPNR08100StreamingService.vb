Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR08100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR08100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR08100StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR08100Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getGsbCodeDt", ReplyAction:="getGsbCodeDt")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getGsbCodeDt() As Message

End Interface
