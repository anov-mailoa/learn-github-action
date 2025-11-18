Imports R_BackEnd
Imports R_Common
Imports ATM00300Back
Imports System.ServiceModel

Public Class ATM00300BService
    Implements IATM00300BService

    Public Sub DoWork() Implements IATM00300BService.DoWork

    End Sub

    
    Public Sub Svc_R_Delete1(poEntity As ATM00300Back.ATM00300BDTO) Implements R_BackEnd.R_IServicebase(Of ATM00300Back.ATM00300BDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATM00300BCls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATM00300Back.ATM00300BDTO) As ATM00300Back.ATM00300BDTO Implements R_BackEnd.R_IServicebase(Of ATM00300Back.ATM00300BDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATM00300BCls
        Dim loRtn As ATM00300BDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATM00300Back.ATM00300BDTO, poCRUDMode As R_Common.eCRUDMode) As ATM00300Back.ATM00300BDTO Implements R_BackEnd.R_IServicebase(Of ATM00300Back.ATM00300BDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATM00300BCls
        Dim loRtn As ATM00300BDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class


