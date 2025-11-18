Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNB01200Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNB01200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNB01200StreamingService

    <OperationContract(Action:="getPnmOrgStructure", ReplyAction:="getPnmOrgStructure")>
 <FaultContract(GetType(R_ServiceExceptions))>
    Function getPnmOrgStructure() As Message

    <OperationContract(Action:="getDataDetail", ReplyAction:="getDataDetail")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getDataDetail() As Message

    <OperationContract(Action:="getDataHeader", ReplyAction:="getDataHeader")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getDataHeader() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
<FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

End Interface
