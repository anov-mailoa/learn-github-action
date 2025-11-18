Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNI00200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNI00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNI00200StreamingService
    <OperationContract(Action:="getRSP_LN_OUTSTANDING_TRANSACTION", ReplyAction:="getRSP_LN_OUTSTANDING_TRANSACTION")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getRSP_LN_OUTSTANDING_TRANSACTION() As Message

    <OperationContract(Action:="getTransactionCombo", ReplyAction:="getTransactionCombo")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionCombo() As Message
End Interface
