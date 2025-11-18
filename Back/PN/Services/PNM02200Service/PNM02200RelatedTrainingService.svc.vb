' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02200DetailService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back
Imports System.ServiceModel

Public Class PNM02200RelatedTrainingService
    Implements IPNM02200RelatedTrainingService

    Public Sub Svc_R_Delete(poEntity As PNM02200Back.PNM02200RelatedTrainingDTO) Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200RelatedTrainingDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200RelatedTrainingCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02200Back.PNM02200RelatedTrainingDTO) As PNM02200Back.PNM02200RelatedTrainingDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200RelatedTrainingDTO).Svc_R_GetRecord
        Dim loCls As New PNM02200RelatedTrainingCLS
        Dim loRtn As PNM02200RelatedTrainingDTO
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02200Back.PNM02200RelatedTrainingDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02200Back.PNM02200RelatedTrainingDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200RelatedTrainingDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200RelatedTrainingCLS
        Dim loRtn As New PNM02200RelatedTrainingDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
