Imports System.ServiceModel
Imports R_Common
Imports LNT00100Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00100Service_Streaming" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00100Service_Streaming
    <OperationContract(Action:="getTransaction", ReplyAction:="getTransaction")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="getExpense", ReplyAction:="getExpense")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getExpenseList() As Message

    <OperationContract(Action:="getTransacationDoc", ReplyAction:="getTransacationDoc")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransacationDoc() As Message

    <OperationContract(Action:="RSP_Installment_Schedule", ReplyAction:="RSP_Installment_Schedule")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function RSP_Installment_Schedule() As Message

    <OperationContract(Action:="getErrorData", ReplyAction:="getErrorData")> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Function getErrorData() As Message

    <OperationContract()> _
        <FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00100Dto_R), _
              poListSchedule As System.Collections.Generic.List(Of LNT00100_ScheduleDTO), poLisDocDto_R As System.Collections.Generic.List(Of LNT00100ListDocDto_R))

End Interface
