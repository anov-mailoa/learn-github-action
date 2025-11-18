Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNR07150Back
Imports PNR07150Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR07150StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR07150StreamingService

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))>
    Sub Dummy(ByVal poPar As List(Of PNR07150Dto))

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetReportData() As Message

End Interface
