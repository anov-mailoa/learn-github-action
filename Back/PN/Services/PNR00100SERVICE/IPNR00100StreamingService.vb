Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR00100Back
Imports PNR00100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR00100StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract(Action:="GetListPosition", ReplyAction:="GetListPosition")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetListPosition() As Message

    <OperationContract(Action:="GetCmbBox", ReplyAction:="GetCmbBox")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbBox() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR00100DTO)
End Interface
