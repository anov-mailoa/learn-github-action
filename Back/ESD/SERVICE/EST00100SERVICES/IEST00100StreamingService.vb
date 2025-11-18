Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports EST00100Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the interface name "IEST00100StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IEST00100StreamingService

    <OperationContract(Action:="GetTransactionList", ReplyAction:="GetTransactionList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTransactionList() As Message

    <OperationContract(Action:="GetEscalateTransactionList", ReplyAction:="GetEscalateTransactionList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetEscalateTransactionList() As Message

    <OperationContract(Action:="GetCmbReasonList", ReplyAction:="GetCmbReasonList")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetCmbReasonList() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub ParamDTO(ByVal poPar As List(Of EST00100DTO))

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransType(poParam As EST00100DTO) As String

End Interface
