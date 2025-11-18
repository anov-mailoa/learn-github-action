' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02200DetailService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM02200Back
Imports System.ServiceModel

Public Class PNM02200CompetencyScoreService
    Implements IPNM02200CompetencyScoreService


    Public Sub Svc_R_Delete(poEntity As PNM02200Back.PNM02200CompetencyScoreDTO) Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200CompetencyScoreDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200CompetencyScoreCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02200Back.PNM02200CompetencyScoreDTO) As PNM02200Back.PNM02200CompetencyScoreDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200CompetencyScoreDTO).Svc_R_GetRecord
        Dim loCls As New PNM02200CompetencyScoreCLS
        Dim loRtn As PNM02200CompetencyScoreDTO
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02200Back.PNM02200CompetencyScoreDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02200Back.PNM02200CompetencyScoreDTO Implements R_BackEnd.R_IServicebase(Of PNM02200Back.PNM02200CompetencyScoreDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02200CompetencyScoreCLS
        Dim loRtn As New PNM02200CompetencyScoreDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
