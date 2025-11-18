Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT09200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT09200StreamingService

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportData() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParPNT09201Grid As List(Of PNT09201GridDTO))

End Interface
