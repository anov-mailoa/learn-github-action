Imports R_BackEnd
Imports R_Common
Imports LNT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00600ServiceExpense" in code, svc and config file together.
Public Class LNT00600ServiceExpense
    Implements ILNT00600ServiceExpense
    Public Sub Svc_R_Delete(poEntity As LNT00600Back.LNT00600Dto_Expense) Implements R_BackEnd.R_IServicebase(Of LNT00600Back.LNT00600Dto_Expense).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00600Back.LNT00600Dto_Expense) As LNT00600Back.LNT00600Dto_Expense Implements R_BackEnd.R_IServicebase(Of LNT00600Back.LNT00600Dto_Expense).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00600Cls_Expense
        Dim loRtn As LNT00600Dto_Expense

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00600Back.LNT00600Dto_Expense, poCRUDMode As R_Common.eCRUDMode) As LNT00600Back.LNT00600Dto_Expense Implements R_BackEnd.R_IServicebase(Of LNT00600Back.LNT00600Dto_Expense).Svc_R_Save

    End Function

    Public Function getExpenseForm(poParam As LNT00600Back.LNT00600Dto_Expense) As LNT00600Back.LNT00600Dto_Expense Implements ILNT00600ServiceExpense.getExpenseForm
        Dim loCls As New LNT00600Cls
        Dim loRtn As New LNT00600Dto_Expense
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getExpenseForm(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
