Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports MCT01100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IMCT01100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IMCT01100StreamingService

    <OperationContract(Action:="getCashPaymentList", ReplyAction:="getCashPaymentList")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCashPaymentList() As Message

    <OperationContract(Action:="getCashPaymentDetail", ReplyAction:="getCashPaymentDetail")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCashPaymentDetail() As Message

    <OperationContract(Action:="getCashPaymentSummary", ReplyAction:="getCashPaymentSummary")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCashPaymentSummary() As Message

    <OperationContract()> _
     <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of MCT01100CastPaymentListGridDTO),
              poPar2 As System.Collections.Generic.List(Of MCT01100CashPaymentDetailGridDTO),
              poPar4 As System.Collections.Generic.List(Of MCT01100CashPaymentSummaryGridDTO))

End Interface
