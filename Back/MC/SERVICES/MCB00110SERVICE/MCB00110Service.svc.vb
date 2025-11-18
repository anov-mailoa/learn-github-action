Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports MCB00110Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCB00100Service" in code, svc and config file together.
Public Class MCB00110Service
    Implements IMCB00110Service

    Public Function getYearProcess(ByVal poParam As MCB00110Back.MCB00110DTO) As System.Collections.Generic.List(Of MCB00110Back.MCB00110DTO) Implements IMCB00110Service.getYearProcess
        Dim loCls As New MCB00110Cls
        Dim loRtn As New List(Of MCB00110DTO)
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
