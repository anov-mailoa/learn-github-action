Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNT02100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT02100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT02100StreamingService

    <OperationContract(Action:="PntTransactionHd", ReplyAction:="PntTransactionHd")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPntTransactionHd() As Message

    <OperationContract(Action:="TransferRegis", ReplyAction:="TransferRegis")> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransferRegis() As Message

    <OperationContract()> _
       <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of PNT02100GridDTO))

    <OperationContract(Action:="getCmbSubGrade", ReplyAction:="getCmbSubGrade")>
              <FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbSubGrade() As Message

End Interface
