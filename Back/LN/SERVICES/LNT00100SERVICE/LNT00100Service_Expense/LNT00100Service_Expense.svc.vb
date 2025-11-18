Imports R_BackEnd
Imports R_Common
Imports LNT00100Back
Imports System.ServiceModel

Public Class LNT00100Service_Expense
    Implements ILNT00100Service_Expense

    Public Sub Svc_R_Delete(poEntity As LNT00100Back.LNT00100Dto_Expense_R) Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100Dto_Expense_R).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls_Expense

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00100Back.LNT00100Dto_Expense_R) As LNT00100Back.LNT00100Dto_Expense_R Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100Dto_Expense_R).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls_Expense
        Dim loRtn As LNT00100Dto_Expense_R

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00100Back.LNT00100Dto_Expense_R, poCRUDMode As R_Common.eCRUDMode) As LNT00100Back.LNT00100Dto_Expense_R Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100Dto_Expense_R).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls_Expense
        Dim loRtn As LNT00100Dto_Expense_R

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub setExpense(poParam As LNT00100Back.LNT00100Dto_Expense_R, poCRUDMode As R_Common.eCRUDMode) Implements ILNT00100Service_Expense.setExpense
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls_Expense
        Dim loRtn As LNT00100Dto_Expense_R

        Try
            loCls.setExpense(poParam, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
