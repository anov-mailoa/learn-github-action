' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02200DetailService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back
Imports System.ServiceModel

Public Class PNM02200DetailService
    Implements IPNM02200DetailService

    Public Sub Svc_R_Delete(poEntity As PNM02200Back.PNM02200FormDTO) Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200FormDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200DetailCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02200Back.PNM02200FormDTO) As PNM02200Back.PNM02200FormDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200FormDTO).Svc_R_GetRecord
        Dim loCls As New PNM02200DetailCLS
        Dim loRtn As PNM02200FormDTO
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02200Back.PNM02200FormDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02200Back.PNM02200FormDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200FormDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200DetailCLS
        Dim loRtn As PNM02200FormDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getActive(poParam As PNM02200Back.PNM02200FormDTO) As PNM02200Back.PNM02200FormDTO Implements IPNM02200DetailService.getActive
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200DetailCLS
        Dim loRtn As New PNM02200FormDTO

        Try
            loRtn = loCls.getActive(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
