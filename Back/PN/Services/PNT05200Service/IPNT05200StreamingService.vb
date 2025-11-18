Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_Common
Imports PNT05200Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPNT05200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPNT05200StreamingService

    <OperationContract(Action:="PntTransactionHd", ReplyAction:="PntTransactionHd")> _
          <FaultContract(GetType(R_ServiceExceptions))> _
    Function getPntTransactionHd() As Message

    <OperationContract(Action:="TransferRegistration", ReplyAction:="TransferRegistration")> _
         <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransferRegis() As Message

    <OperationContract()> _
      <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poParam As System.Collections.Generic.List(Of PNT05200GridDTO))

End Interface
