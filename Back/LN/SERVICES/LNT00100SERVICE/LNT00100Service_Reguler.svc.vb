Imports R_BackEnd
Imports R_Common
Imports LNT00100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00100Service_Reguler" in code, svc and config file together.
Public Class LNT00100Service_Reguler
    Implements ILNT00100Service_Reguler

    Public Sub Svc_R_Delete(poEntity As LNT00100Back.LNT00100Dto) Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00100Back.LNT00100Dto) As LNT00100Back.LNT00100Dto Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As LNT00100Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00100Back.LNT00100Dto, poCRUDMode As R_Common.eCRUDMode) As LNT00100Back.LNT00100Dto Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As LNT00100Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(poParam As LNT00100Back.LNT00100Dto) As LNT00100Back.LNT00100Dto Implements ILNT00100Service_Reguler.Draft
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As New LNT00100Dto

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As LNT00100Back.LNT00100Dto) As LNT00100Back.LNT00100Dto Implements ILNT00100Service_Reguler.Submit
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As New LNT00100Dto

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function RSP_SCHEDULE_VALIDATION(poParam As LNT00100Back.LNT00100Dto) As String Implements ILNT00100Service_Reguler.RSP_SCHEDULE_VALIDATION
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.RSP_SCHEDULE_VALIDATION(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SystemParam(poParam As LNT00100Back.LNT00100Dto, poCRUDMode As R_Common.eCRUDMode) As Integer Implements ILNT00100Service_Reguler.SystemParam
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.SystemParam(poParam, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getImaxDate(poParam As String) As Integer Implements ILNT00100Service_Reguler.getImaxDate
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getImaxDate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        Return loRtn
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Function getValidatePayroll(poParam As LNT00100Dto) As Integer Implements ILNT00100Service_Reguler.getValidatePayroll
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getValidatePayroll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetCurrencyRate(poParam As LNT00100Back.LNT00100Dto) As Decimal Implements ILNT00100Service_Reguler.GetCurrencyRate
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As Decimal

        Try
            loRtn = loCls.GetCurrencyRate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetLocalTypeCurrency(poParam As LNT00100Back.LNT00100Dto) As LNT00100Back.LNT00100Dto Implements ILNT00100Service_Reguler.GetLocalTypeCurrency
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100Cls
        Dim loRtn As LNT00100Dto

        Try
            loRtn = loCls.GetLocalTypeCurrency(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function



End Class
