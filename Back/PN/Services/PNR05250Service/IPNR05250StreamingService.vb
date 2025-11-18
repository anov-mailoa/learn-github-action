Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR05250Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR05250StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR05250StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar As System.Collections.Generic.List(Of PNR05250BackStreamingDTO),
              ByVal poParam As PNR05250BackDTO)

End Interface
