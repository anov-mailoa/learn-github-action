Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00600ServiceExpense" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00600ServiceExpense
    Inherits R_IServicebase(Of LNT00600Dto_Expense)

    <OperationContract()>
   <FaultContract(GetType(R_ServiceExceptions))> _
    Function getExpenseForm(ByVal poParam As LNT00600Dto_Expense) As LNT00600Dto_Expense
End Interface
