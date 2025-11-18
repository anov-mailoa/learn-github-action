Imports System.ServiceModel.Channels
Imports R_Common
Imports R_BackEnd
Imports PNR05270Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR05250StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR05270StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR05270DTO)

End Interface
