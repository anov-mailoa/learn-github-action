Imports R_BackEnd
Imports R_Common
Imports PNR05260Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

<ServiceContract()>
Public Interface IPNR05260StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

End Interface
