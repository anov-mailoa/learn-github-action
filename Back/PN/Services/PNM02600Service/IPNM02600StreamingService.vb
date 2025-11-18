Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNM02600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNM02600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNM02600StreamingService

    <OperationContract(Action:="PnmCriteria", ReplyAction:="PnmCriteria")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getPnmCriteria() As Message

    <OperationContract(Action:="getReport", ReplyAction:="getReport")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

End Interface
