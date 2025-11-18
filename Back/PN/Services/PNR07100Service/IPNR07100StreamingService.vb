Imports System.ServiceModel.Channels
Imports R_Common
Imports PNR07100Back
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNR07100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNR07100StreamingService

    <OperationContract(Action:="GetReportData", ReplyAction:="GetReportData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetReportData() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As PNR07100BackDTO)

End Interface
