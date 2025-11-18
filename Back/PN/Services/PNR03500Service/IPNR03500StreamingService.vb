Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR03500Back
Imports PNR03500Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR03500StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR03500StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR03500DTO)
End Interface
