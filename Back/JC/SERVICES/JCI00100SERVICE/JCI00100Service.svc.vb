' NOTE: You can use the "Rename" command on the context menu to change the class name "JCI00100Service" in code, svc and config file together.
Imports R_Common
Imports JCI00100Back

Public Class JCI00100Service
    Implements IJCI00100Service


    Public Function getHeaderJcEvaluation(poParam As JCI00100Back.JCI00100DTO) As JCI00100Back.JCI00100DTO Implements IJCI00100Service.getHeaderJcEvaluation
        Dim loEx As New R_Exception
        Dim loCls As New JCI00100CLS
        Dim loRtn As JCI00100DTO = Nothing

        Try
            loRtn = loCls.getHeaderJcEvaluation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getFooterJcEvaluation(poParam As JCI00100Back.JCI00100DTO) As JCI00100Back.JCI00100DTO Implements IJCI00100Service.getFooterJcEvaluation

        Dim loEx As New R_Exception
        Dim loCls As New JCI00100CLS
        Dim loRtn As JCI00100DTO = Nothing

        Try
            loRtn = loCls.getFooterJcEvaluation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function
End Class
