Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR09200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR09200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR09200StreamingService

    <OperationContract()>
<FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR09200Dto))

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReport() As Message

    <OperationContract(Action:="getPnmAppreciation", ReplyAction:="getPnmAppreciation")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmAppreciation() As Message

End Interface
