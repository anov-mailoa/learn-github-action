' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100JobDescService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back

Public Class PNM03100JobDescService
    Implements IPNM03100JobDescService

    Public Function getJobDesc(poParam As PNM03100Back.PNM03100JobDescDTO) As PNM03100Back.PNM03100JobDescDTO Implements IPNM03100JobDescService.getJobDesc
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100JobDescCLS
        Dim loRtn As PNM03100JobDescDTO

        Try
            loRtn = loCls.getJobDesc(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As PNM03100Back.PNM03100JobDescDTO) Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100JobDescDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100JobDescCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM03100Back.PNM03100JobDescDTO) As PNM03100Back.PNM03100JobDescDTO Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100JobDescDTO).Svc_R_GetRecord


        Dim loEx As New R_Exception
        Dim loCls As New PNM03100JobDescCLS
        Dim loRtn As PNM03100JobDescDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function Svc_R_Save(poEntity As PNM03100Back.PNM03100JobDescDTO, poCRUDMode As R_Common.eCRUDMode) As PNM03100Back.PNM03100JobDescDTO Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100JobDescDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100JobDescCLS
        Dim loRtn As PNM03100JobDescDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
