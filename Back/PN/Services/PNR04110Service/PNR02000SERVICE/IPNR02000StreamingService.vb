Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR02000Back
Imports PNR02000Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR02000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR02000StreamingService

    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR02000BackDTO)

End Interface
