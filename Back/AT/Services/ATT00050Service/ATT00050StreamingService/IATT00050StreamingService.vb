Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports ATT00050Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IATT00050StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IATT00050StreamingService

    <OperationContract(Action:="TransactionData", ReplyAction:="TransactionData")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="OutstandingReportData", ReplyAction:="OutstandingReportData")>
               <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOutstandingReport() As Message

    <OperationContract(Action:="getOutstandingReportView", ReplyAction:="getOutstandingReportView")>
            <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOutstandingReportView() As Message

    <OperationContract(Action:="TransactionHistoryData", ReplyAction:="TransactionHistoryData")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionHistory() As Message

    <OperationContract()>
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParATT00050 As System.Collections.Generic.List(Of ATT00050GridStreamingDTO), poParATT00051 As System.Collections.Generic.List(Of ATT00050GridDTO), poParATT00052 As System.Collections.Generic.List(Of COMBOBOXDTO))

End Interface
