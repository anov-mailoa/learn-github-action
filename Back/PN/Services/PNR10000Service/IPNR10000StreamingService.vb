Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR10000Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR10000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR10000StreamingService

    <OperationContract()>
 <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poParam2 As List(Of PNR10000DTO))

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

End Interface
