Imports System.ServiceModel
Imports R_Common
Imports JCT00100Back
Imports R_BackEnd
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IJCT00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IJCT00100StreamingService

    <OperationContract(Action:="getListEmployee", ReplyAction:="getListEmployee")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getListEmployee() As Message

    'FORM2
    <OperationContract(Action:="getTransactionList", ReplyAction:="getTransactionList")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransactionList() As Message

    <OperationContract(Action:="getProbation", ReplyAction:="getProbation")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProbation() As Message

    'FORM ADD
    <OperationContract(Action:="getComboDept", ReplyAction:="getComboDept")> _
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getComboDept() As Message

End Interface
