Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR01110Back
Imports PNR01110Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR01110StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR01110StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR01110BackDTO)

End Interface
