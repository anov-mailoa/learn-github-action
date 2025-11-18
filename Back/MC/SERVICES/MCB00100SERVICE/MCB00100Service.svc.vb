Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCB00100Back
Imports SIAPP_PUB_DTO
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCB00100Service" in code, svc and config file together.
Public Class MCB00100Service
    Implements IMCB00100Service

    Public Function getYearProcess(ByVal poParam As MCB00100Back.MCB00100DTO) As System.Collections.Generic.List(Of MCB00100Back.MCB00100DTO) Implements IMCB00100Service.getYearProcess
        Dim loCls As New MCB00100Cls
        Dim loRtn As New List(Of MCB00100DTO)
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getYearProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCmbMedicalRule(ByVal poParam As MCB00100Back.MCB00100DTO) As System.Collections.Generic.List(Of SIAPP_PUB_DTO.LookUpCmbDTO) Implements IMCB00100Service.getCmbMedicalRule
        Dim loCls As New MCB00100Cls
        Dim loRtn As New List(Of LookUpCmbDTO)
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getCmbMedicalRule(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getValidateUser(poParam As MCB00100Back.MCB00100DTO) As Integer Implements IMCB00100Service.getValidateUser
        Dim loCls As New MCB00100Cls
        Dim loRtn As Integer
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getValidateUser(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getValidateUsage(poParam As MCB00100Back.MCB00100DTO) As Integer Implements IMCB00100Service.getValidateUsage
        Dim loCls As New MCB00100Cls
        Dim loRtn As Integer
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getValidateUsage(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub UpdateUsageMedical(poParam As MCB00100Back.MCB00100DTO) Implements IMCB00100Service.UpdateUsageMedical
        Dim loCls As New MCB00100Cls
        Dim loEx As New R_Exception()

        Try
            loCls.UpdateUsageMedical(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function EnableTabEmployee(poParam As MCB00100Back.MCB00100DTO) As Integer Implements IMCB00100Service.EnableTabEmployee
        Dim loCls As New MCB00100Cls
        Dim loRtn As Integer
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.EnableTabEmployee(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function CheckCurrentYear(pcCompId As String, pcYear As String) As Integer Implements IMCB00100Service.CheckCurrentYear
        Dim loCls As New MCB00100Cls
        Dim loRtn As Integer
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.CheckCurrentYear(pcCompId, pcYear)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
