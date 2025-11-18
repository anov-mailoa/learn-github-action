Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR01100Back
Imports PNR01100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR01100StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR01100BackDTO)
End Interface
