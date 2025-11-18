Imports R_BackEnd
Imports R_Common
Imports LNM00300Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00300Service" in code, svc and config file together.
Public Class LNM00300Service
    Implements ILNM00300Service


    Public Sub Svc_R_Delete(poEntity As LNM00300Back.LNM00300Dto_R) Implements R_BackEnd.R_IServicebase(Of LNM00300Back.LNM00300Dto_R).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNM00300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00300Back.LNM00300Dto_R) As LNM00300Back.LNM00300Dto_R Implements R_BackEnd.R_IServicebase(Of LNM00300Back.LNM00300Dto_R).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00300Cls
        Dim loRtn As LNM00300Dto_R

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00300Back.LNM00300Dto_R, poCRUDMode As R_Common.eCRUDMode) As LNM00300Back.LNM00300Dto_R Implements R_BackEnd.R_IServicebase(Of LNM00300Back.LNM00300Dto_R).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00300Cls
        Dim loRtn As LNM00300Dto_R

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
