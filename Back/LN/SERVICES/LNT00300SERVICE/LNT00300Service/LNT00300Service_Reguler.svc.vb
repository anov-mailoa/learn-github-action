Imports R_BackEnd
Imports R_Common
Imports LNT00300Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00300Service_Reguler" in code, svc and config file together.
Public Class LNT00300Service_Reguler
    Implements ILNT00300Service_Reguler

    Public Sub Svc_R_Delete(poEntity As LNT00300Back.LNT00300Dto) Implements R_BackEnd.R_IServicebase(Of LNT00300Back.LNT00300Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00300Back.LNT00300Dto) As LNT00300Back.LNT00300Dto Implements R_BackEnd.R_IServicebase(Of LNT00300Back.LNT00300Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As LNT00300Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00300Back.LNT00300Dto, poCRUDMode As R_Common.eCRUDMode) As LNT00300Back.LNT00300Dto Implements R_BackEnd.R_IServicebase(Of LNT00300Back.LNT00300Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As New LNT00300Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getStarDate(poParam As LNT00300Back.LNT00300Dto) As String Implements ILNT00300Service_Reguler.getStarDate
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getStarDate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getPrincipal(poParam As LNT00300Back.LNT00300Dto) As Decimal Implements ILNT00300Service_Reguler.getPrincipal
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As Decimal

        Try
            loRtn = loCls.getPrincipal(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getRemaining(poParam As LNT00300Back.LNT00300Dto) As LNT00300Back.LNT00300Dto Implements ILNT00300Service_Reguler.getRemaining
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As New LNT00300Dto

        Try
            loRtn = loCls.getRemaining(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getValidateReschedule(poParam As LNT00300Back.LNT00300Dto) As Integer Implements ILNT00300Service_Reguler.getValidateReschedule
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getValidateReschedule(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCountTenor(poParam As LNT00300Back.LNT00300Dto) As Integer Implements ILNT00300Service_Reguler.getCountTenor
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getCountTenor(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftSubmit(poParam As LNT00300Back.LNT00300Dto) As LNT00300Back.LNT00300Dto Implements ILNT00300Service_Reguler.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New LNT00300Cls
        Dim loRtn As New LNT00300Dto

        Try
            loRtn = loCls.DraftSubmit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
