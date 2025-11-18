Imports R_BackEnd
Imports R_Common
Imports LNM00200Back
Imports System.ServiceModel
' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00200CategoryService" in code, svc and config file together.
Public Class LNM00200CategoryService
    Implements ILNM00200CategoryService

    Public Sub Svc_R_Delete(poEntity As LNM00200Back.LNM00200Category_R) Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Category_R).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNMCategoryCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00200Back.LNM00200Category_R) As LNM00200Back.LNM00200Category_R Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Category_R).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNMCategoryCls
        Dim loRtn As LNM00200Category_R

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00200Back.LNM00200Category_R, poCRUDMode As R_Common.eCRUDMode) As LNM00200Back.LNM00200Category_R Implements R_BackEnd.R_IServicebase(Of LNM00200Back.LNM00200Category_R).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNMCategoryCls
        Dim loRtn As LNM00200Category_R

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
