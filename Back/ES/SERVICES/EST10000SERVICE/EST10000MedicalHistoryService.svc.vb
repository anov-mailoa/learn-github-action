Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000MedicalHistoryService" in code, svc and config file together.
Public Class EST10000MedicalHistoryService
    Implements IEST10000MedicalHistoryService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000MedicalHistoryDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000MedicalHistoryDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000MedicalHistoryDTO) As EST10000Back.EST10000MedicalHistoryDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000MedicalHistoryDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000MedicalHistoryCls
        Dim loRtn As New EST10000MedicalHistoryDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000MedicalHistoryDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000MedicalHistoryDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000MedicalHistoryDTO).Svc_R_Save

    End Function

    Public Sub ApprovalMedicalHistory(poParam As EST10000Back.EST10000MedicalHistoryDTO) Implements IEST10000MedicalHistoryService.ApprovalMedicalHistory
        Dim loEx As New R_Exception
        Dim loCls As New EST10000MedicalHistoryCls
        Try
            loCls.ApprovalMedicalHistory(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
