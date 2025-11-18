Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports LNT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the interface name "ILNT00100Service_Expense" in both code and config file together.
<ServiceContract()>
Public Interface ILNT00100Service_Expense
    Inherits R_IServicebase(Of LNT00100Dto_Expense_R)

    <OperationContract()> _
    <FaultContract(GetType(R_ServiceExceptions))> _
    Sub setExpense(poParam As LNT00100Dto_Expense_R, poCRUDMode As R_Common.eCRUDMode)
End Interface
