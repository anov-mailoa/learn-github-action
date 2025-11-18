' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM03100RelatedTrainingService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNM03100Back
Imports System.ServiceModel

Public Class PNM03100ScoringInfoService
    Implements IPNM03100ScoringInfoService

    Public Sub Svc_R_Delete(poEntity As PNM03100Back.PNM03100ScoringInfoDTO) Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100ScoringInfoDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100ScoringInfoCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM03100Back.PNM03100ScoringInfoDTO) As PNM03100Back.PNM03100ScoringInfoDTO Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100ScoringInfoDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100ScoringInfoCLS
        Dim loRtn As New PNM03100ScoringInfoDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM03100Back.PNM03100ScoringInfoDTO, poCRUDMode As R_Common.eCRUDMode) As PNM03100Back.PNM03100ScoringInfoDTO Implements R_BackEnd.R_IServicebase(Of PNM03100Back.PNM03100ScoringInfoDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM03100ScoringInfoCLS
        Dim loRtn As New PNM03100ScoringInfoDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
