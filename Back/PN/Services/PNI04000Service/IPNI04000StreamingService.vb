Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports PNI04000Back
Imports R_Common

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNI04000StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNI04000StreamingService

    <OperationContract(Action:="getCmbCriteria", ReplyAction:="getCmbCriteria")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCmbCriteria() As Message

    <OperationContract(Action:="getCriteriaSelectedValue", ReplyAction:="getCriteriaSelectedValue")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function getCriteriaSelectedValue() As Message

    <OperationContract(Action:="getReportData", ReplyAction:="getReportData")>
   <FaultContract(GetType(R_ServiceExceptions))>
    Function getReportData() As Message

    <OperationContract(Action:="GetCriteriaList", ReplyAction:="GetCriteriaList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetCriteriaList() As Message

    <OperationContract(Action:="GetCategoryList", ReplyAction:="GetCategoryList")>
    <FaultContract(GetType(R_ServiceExceptions))>
    Function GetCategoryList() As Message

End Interface
