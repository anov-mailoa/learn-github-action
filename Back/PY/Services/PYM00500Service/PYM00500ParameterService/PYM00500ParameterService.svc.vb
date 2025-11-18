' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM00500ParameterService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PYM00500Back
Imports System.ServiceModel

Public Class PYM00500ParameterService
    Implements IPYM00500ParameterService

    Public Sub Svc_R_Delete(poEntity As PYM00500Back.PYM00500ParameterDTO) Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500ParameterDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM00500ParameterCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM00500Back.PYM00500ParameterDTO) As PYM00500Back.PYM00500ParameterDTO Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500ParameterDTO).Svc_R_GetRecord

        Dim loEx As New R_Exception
        Dim loCls As New PYM00500ParameterCLS
        Dim loRtn As PYM00500ParameterDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PYM00500Back.PYM00500ParameterDTO, poCRUDMode As R_Common.eCRUDMode) As PYM00500Back.PYM00500ParameterDTO Implements R_BackEnd.R_IServicebase(Of PYM00500Back.PYM00500ParameterDTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New PYM00500ParameterCLS
        Dim loRtn As PYM00500ParameterDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function getMaxYear(poParam As PYM00500Back.PYM00500ParameterDTO) As Integer Implements IPYM00500ParameterService.getMaxYear

        Dim loEx As New R_Exception
        Dim loCls As New PYM00500ParameterCLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.getMaxYear(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Sub getCheckSyntax(poParam As PYM00500Back.PYM00500ParameterDTO) Implements IPYM00500ParameterService.getCheckSyntax
        Dim loEx As New R_Exception
        Dim loCls As New PYM00500ParameterCLS
        Try
            loCls.getCheckSyntax(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
