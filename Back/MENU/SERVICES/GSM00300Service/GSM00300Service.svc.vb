Imports R_Common
Imports GSM00300Back
Imports System.ServiceModel.Channels
' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00300Service" in code, svc and config file together.
Public Class GSM00300Service
    Implements IGSM00300Service

    Public Sub Svc_R_Delete(poEntity As GSM00300Back.GSM00300DTO) Implements R_BackEnd.R_IServicebase(Of GSM00300Back.GSM00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM00300Back.GSM00300DTO) As GSM00300Back.GSM00300DTO Implements R_BackEnd.R_IServicebase(Of GSM00300Back.GSM00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As GSM00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM00300Back.GSM00300DTO, poCRUDMode As R_Common.eCRUDMode) As GSM00300Back.GSM00300DTO Implements R_BackEnd.R_IServicebase(Of GSM00300Back.GSM00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As GSM00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getYearPeriod(poParam As GSM00300Back.GSM00300DTO) As GSM00300Back.GSM00300DTO Implements IGSM00300Service.getYearPeriod
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As GSM00300DTO

        Try
            loRtn = loCls.getYearPeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getCmbPeriodMode() As System.Collections.Generic.List(Of GSM00300Back.GSM00300CmbDTO) Implements IGSM00300Service.getCmbPeriodMode
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As List(Of GSM00300CmbDTO)

        Try
            loRtn = loCls.getCmbPeriodMode()
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ValidateCurrenctPeriod(poParam As GSM00300Back.GSM00300DTO) As GSM00300Back.GSM00300DTO Implements IGSM00300Service.ValidateCurrenctPeriod
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As New GSM00300DTO

        Try
            loRtn = loCls.ValidateCurrenctPeriod(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getGsmCompanies(poParam As GSM00300Back.GSM00300DTO) As String Implements IGSM00300Service.getGsmCompanies
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getGsmCompanies(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getNextYearPeriodMode(poParam As GSM00300Back.GSM00300DTO) As Boolean Implements IGSM00300Service.getNextYearPeriodMode
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getNextYearPeriodMode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkPrevYearPeriodMode(poParam As GSM00300Back.GSM00300DTO) As Boolean Implements IGSM00300Service.checkPrevYearPeriodMode
        Dim loEx As New R_Exception
        Dim loCls As New GSM00300Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkPrevYearPeriodMode(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
