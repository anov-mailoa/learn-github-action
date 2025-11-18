Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports R_BackEnd
Imports R_Common
Imports LNT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00600StreamingService" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00600StreamingService

    <OperationContract(Action:="getData", ReplyAction:="getData")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransaction() As Message

    <OperationContract(Action:="getExpense", ReplyAction:="getExpense")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getExpenseList() As Message

    <OperationContract(Action:="getTransacationDoc", ReplyAction:="getTransacationDoc")> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Function getTransacationDoc() As Message

    <OperationContract()> _
<FaultContract(GetType(R_ServiceExceptions))> _
    Sub Dummy(poParTenor As System.Collections.Generic.List(Of LNT00600Dto_R), _
              poListExpense As System.Collections.Generic.List(Of LNT00600Dto_Expense_R), poListExpense_S As System.Collections.Generic.List(Of LNT00600Dto_Expense_S), _
              poSchedule As LNT00600ScheduleDto, poScheduleList As System.Collections.Generic.List(Of LNT00600ScheduleDto_S), poLisDocDto_R As System.Collections.Generic.List(Of LNT00600ListDocDto_R), poLisDocDto_S As System.Collections.Generic.List(Of LNT00600ListDocDto_S))

End Interface
