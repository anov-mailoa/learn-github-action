Imports System.ServiceModel
Imports R_Common
Imports QAR00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IQAR00100StreamService" in both code and config file together.
<ServiceContract()>
Public Interface IQAR00100StreamService

    <OperationContract(Action:="getListGridDocument", ReplyAction:="getListGridDocument")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridDocument() As Message

    <OperationContract(Action:="getReportDocument", ReplyAction:="getReportDocument")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportDocument() As Message

    <OperationContract(Action:="getListGridTransactionList", ReplyAction:="getListGridTransactionList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListGridTransactionList() As Message

    <OperationContract(Action:="getReportTrackingDocument", ReplyAction:="getReportTrackingDocument")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTrackingDocument() As Message

    <OperationContract(Action:="getReportTrackingDocument_RelPos", ReplyAction:="getReportTrackingDocument_RelPos")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTrackingDocument_RelPos() As Message

    <OperationContract(Action:="getReportTrackingDocument_Clause", ReplyAction:="getReportTrackingDocument_Clause")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTrackingDocument_Clause() As Message


    <OperationContract(Action:="getReportTrackingDocument_RELDOC", ReplyAction:="getReportTrackingDocument_RELDOC")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTrackingDocument_RELDOC() As Message

    <OperationContract(Action:="getReportTrackingDocument_RELDOCRETAINER", ReplyAction:="getReportTrackingDocument_RELDOCRETAINER")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTrackingDocument_RELDOCRETAINER() As Message

    <OperationContract(Action:="getReportTrackingDocument_RETAINER", ReplyAction:="getReportTrackingDocument_RETAINER")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getReportTrackingDocument_RETAINER() As Message




End Interface
