Imports R_BackEnd
Imports R_Common
Imports MCB04000Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

<ServiceContract()>
Public Interface IMCB04000StreamingService
    <OperationContract(action:="getUntransferedClaimList", ReplyAction:="getUntransferedClaimList")> _
                    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getUntransferedClaimList() As Message

    <OperationContract(action:="getOutstandingTransactionList", ReplyAction:="getOutstandingTransactionList")> _
                 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getOutstandingTransactionList() As Message

    <OperationContract()> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParGrid1 As List(Of MCB04000OutstandingTransactionDto),
              ByVal poReport As List(Of MCB04000UntransferedReportDto),
              ByVal poReport1 As List(Of MCB04000OutstandingReportDto))

End Interface
