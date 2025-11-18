Imports R_BackEnd
Imports R_Common
Imports MCB00200Back
Imports System.ServiceModel

Public Class MCB00200RegularService
    Implements IMCB00200RegularService

    Public Function getYearProcess(poParam As MCB00200Back.MCB00200DTO) As System.Collections.Generic.List(Of MCB00200Back.MCB00200DTO) Implements IMCB00200RegularService.getYearProcess
        Dim loCls As New MCB00200Cls
        Dim loRtn As New List(Of MCB00200DTO)
        Dim loEx As New R_Exception()

        Try
            loRtn = loCls.getYearProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
