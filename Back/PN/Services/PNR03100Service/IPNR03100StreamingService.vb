Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR03100Back
Imports PNR03100Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR03100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR03100StreamingService
    <OperationContract(Action:="GetEmployeeList", ReplyAction:="GetEmployeeList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEmployeeList() As Message

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR03100BackDTO)
End Interface
