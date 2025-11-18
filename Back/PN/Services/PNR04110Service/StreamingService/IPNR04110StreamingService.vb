Imports System.ServiceModel.Channels
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNR04110Back


<ServiceContract()>
Public Interface IPNR04110StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

End Interface
