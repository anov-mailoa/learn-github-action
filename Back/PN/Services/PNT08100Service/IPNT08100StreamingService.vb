Imports R_Common
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNT08100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT08100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT08100StreamingService

    <OperationContract(Action:="getEmployeeBondList", ReplyAction:="getEmployeeBondList")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getEmployeeBondList() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

End Interface
