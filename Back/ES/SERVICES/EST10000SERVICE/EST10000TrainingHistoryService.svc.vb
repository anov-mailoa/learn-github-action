Imports R_Common
Imports EST10000Back ' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000TrainingHistoryService" in code, svc and config file together.
Public Class EST10000TrainingHistoryService
    Implements IEST10000TrainingHistoryService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000TrainingHistoryDataDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000TrainingHistoryDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000TrainingHistoryDataDTO) As EST10000Back.EST10000TrainingHistoryDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000TrainingHistoryDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000TrainingHistoryDataCls
        Dim loRtn As New EST10000TrainingHistoryDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000TrainingHistoryDataDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000TrainingHistoryDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000TrainingHistoryDataDTO).Svc_R_Save

    End Function

    Public Sub ApprovalTrainingHistoryData(poParam As EST10000Back.EST10000TrainingHistoryDataDTO) Implements IEST10000TrainingHistoryService.ApprovalTrainingHistoryData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000TrainingHistoryDataCls
        Try
            loCls.ApprovalTrainingHistoryData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
