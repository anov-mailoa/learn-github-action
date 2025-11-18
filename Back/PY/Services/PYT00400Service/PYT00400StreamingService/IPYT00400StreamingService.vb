Imports System.ServiceModel
Imports R_Common
Imports PYT00400Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00400StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00400StreamingService

    <OperationContract(Action:="GetTaxOfficeTransferTransactionList", ReplyAction:="GetTaxOfficeTransferTransactionList")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTaxOfficeTransferTransactionList() As Message

    <OperationContract(Action:="GetTaxOfficeTransferTransactionListDt", ReplyAction:="GetTaxOfficeTransferTransactionListDt")> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTaxOfficeTransferTransactionListDt() As Message

    <OperationContract(Action:="GetTaxTransferTransactionHistoryHd", ReplyAction:="GetTaxTransferTransactionHistoryHd")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function GetTaxTransferTransactionHistoryHd() As Message

    <OperationContract(Action:="getCmbPeriod", ReplyAction:="getCmbPeriod")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPeriod() As Message

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(ByVal poPar1 As List(Of PYT00400GridHdDTO))

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy1(ByVal poPar1 As List(Of PYT00400GridDtDTO), poPar2 As List(Of PYT00400DtDTO))
End Interface
