Imports R_BackEnd
Imports R_Common
Imports LNT00400Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00400Service" in code, svc and config file together.
Public Class LNT00400Service
    Implements ILNT00400Service

    Public Sub Svc_R_Delete(poEntity As LNT00400Back.LNT00400Dto) Implements R_BackEnd.R_IServicebase(Of LNT00400Back.LNT00400Dto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00400Back.LNT00400Dto) As LNT00400Back.LNT00400Dto Implements R_BackEnd.R_IServicebase(Of LNT00400Back.LNT00400Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim loRtn As LNT00400Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00400Back.LNT00400Dto, poCRUDMode As R_Common.eCRUDMode) As LNT00400Back.LNT00400Dto Implements R_BackEnd.R_IServicebase(Of LNT00400Back.LNT00400Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim loRtn As LNT00400Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Draft(poParam As LNT00400Back.LNT00400Dto) As LNT00400Back.LNT00400Dto Implements ILNT00400Service.Draft
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim loRtn As New LNT00400Dto

        Try
            loRtn = loCls.Draft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As LNT00400Back.LNT00400Dto) As LNT00400Back.LNT00400Dto Implements ILNT00400Service.Submit
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim loRtn As New LNT00400Dto

        Try
            loRtn = loCls.Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetCurrencyRate(poParam As LNT00400Back.LNT00400Dto) As Decimal Implements ILNT00400Service.GetCurrencyRate
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim loRtn As Decimal

        Try
            loRtn = loCls.GetCurrencyRate(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetLocalTypeCurrency(poParam As LNT00400Back.LNT00400Dto) As LNT00400Back.LNT00400Dto Implements ILNT00400Service.GetLocalTypeCurrency
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim loRtn As New LNT00400Dto

        Try
            loRtn = loCls.GetLocalTypeCurrency(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub AddNewTransaction(poParam As LNT00400Back.LNT00400Dto) Implements ILNT00400Service.AddNewTransaction
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls

        Try
            loCls.AddNewTransaction(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function CheckAdd(poParam As LNT00400Back.LNT00400Dto) As Boolean Implements ILNT00400Service.CheckAdd
        Dim loEx As New R_Exception
        Dim loCls As New LNT00400Cls
        Dim llRtn As Boolean

        Try
            llRtn = loCls.CheckAdd(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return llRtn
    End Function
End Class
