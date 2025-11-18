Imports R_BackEnd
Imports R_Common
Imports LNT00200Back
Imports System.ServiceModel

Public Class LNT00200Service
    Implements ILNT00200Service

    Public Sub Svc_R_Delete(poEntity As LNT00200Back.LNT00200Dto) Implements R_BackEnd.R_IServicebase(Of LNT00200Back.LNT00200Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00200Back.LNT00200Dto) As LNT00200Back.LNT00200Dto Implements R_BackEnd.R_IServicebase(Of LNT00200Back.LNT00200Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00200Cls
        Dim loRtn As LNT00200Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00200Back.LNT00200Dto, poCRUDMode As R_Common.eCRUDMode) As LNT00200Back.LNT00200Dto Implements R_BackEnd.R_IServicebase(Of LNT00200Back.LNT00200Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00200Cls
        Dim loRtn As LNT00200Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(poParam As LNT00200Back.LNT00200Dto) As LNT00200Back.LNT00200Dto Implements ILNT00200Service.Draft
        Dim loEx As New R_Exception
        Dim loCls As New LNT00200Cls
        Dim loRtn As New LNT00200Dto

        Try
            loRtn = loCls.DraftSubmit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
