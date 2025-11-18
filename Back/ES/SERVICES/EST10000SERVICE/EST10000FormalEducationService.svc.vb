Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000FormalEducationService" in code, svc and config file together.
Public Class EST10000FormalEducationService
    Implements IEST10000FormalEducationService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000FormalEducationDataDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000FormalEducationDataDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000FormalEducationDataDTO) As EST10000Back.EST10000FormalEducationDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000FormalEducationDataDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000FormalEducationDataCls
        Dim loRtn As New EST10000FormalEducationDataDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000FormalEducationDataDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000FormalEducationDataDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000FormalEducationDataDTO).Svc_R_Save

    End Function

    Public Sub ApprovalFormalEducationData(poParam As EST10000Back.EST10000FormalEducationDataDTO) Implements IEST10000FormalEducationService.ApprovalFormalEducationData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000FormalEducationDataCls
        Try
            loCls.ApprovalFormalEducationData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
