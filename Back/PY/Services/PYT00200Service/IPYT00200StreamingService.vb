Imports System.ServiceModel
Imports R_Common
Imports PYT00200Back
'Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "IPYT00200StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface IPYT00200StreamingService

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message

    <OperationContract(Action:="getHeaderTransactionListData", ReplyAction:="getHeaderTransactionListData")> _
  <FaultContract(GetType(R_ServiceExceptions))> _
    Function getHeaderTransactionList() As Message

    <OperationContract(Action:="getNewSalaryGroup", ReplyAction:="getNewSalaryGroup")> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Function getNewSalaryGroup() As Message

    <OperationContract(Action:="getCurrentSalaryGroup", ReplyAction:="getCurrentSalaryGroup")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCurrentSalaryGroup() As Message

    <OperationContract(Action:="getExcelData", ReplyAction:="getExcelData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getExcelData() As Message


    <OperationContract(Action:="getDetailTransaction", ReplyAction:="getDetailTransaction")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getDetailTransaction() As Message

    <OperationContract(Action:="getListHistory", ReplyAction:="getListHistory")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListHistory() As Message

    <OperationContract(Action:="getCmbPeriod", ReplyAction:="getCmbPeriod")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getCmbPeriod() As Message

    <OperationContract(Action:="getListHistoryDetail", ReplyAction:="getListHistoryDetail")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getListHistoryDetail() As Message

    <OperationContract()> _
 <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy3(ByVal poPar As List(Of PYT00200DetailGridDTO), ByVal poPar1 As List(Of PYT00200HeaderDTO))

End Interface
