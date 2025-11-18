Imports System.ServiceModel
Imports R_Common
Imports PYM00700Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYM00700StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYM00700StreamingService

    <OperationContract(Action:="getTransferCodeHd", ReplyAction:="getTransferCodeHd")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransferCodeHd() As Message

    <OperationContract(Action:="getProcessCode", ReplyAction:="getProcessCode")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getProcessCode() As Message

    <OperationContract(Action:="getBankAccount", ReplyAction:="getBankAccount")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function getBankAccount() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of PYM00700TransCodeDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poPar1 As List(Of PYM00700ProcessCodeDTO))


End Interface
