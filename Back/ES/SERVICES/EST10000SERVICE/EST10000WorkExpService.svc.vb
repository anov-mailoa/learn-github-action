Imports R_Common
Imports EST10000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "EST10000WorkExpService" in code, svc and config file together.
Public Class EST10000WorkExpService
    Implements IEST10000WorkExpService

    Public Sub Svc_R_Delete(poEntity As EST10000Back.EST10000WorkExperienceDTO) Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000WorkExperienceDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As EST10000Back.EST10000WorkExperienceDTO) As EST10000Back.EST10000WorkExperienceDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000WorkExperienceDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New EST10000WorkExperienceCls
        Dim loRtn As New EST10000WorkExperienceDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As EST10000Back.EST10000WorkExperienceDTO, poCRUDMode As R_Common.eCRUDMode) As EST10000Back.EST10000WorkExperienceDTO Implements R_BackEnd.R_IServicebase(Of EST10000Back.EST10000WorkExperienceDTO).Svc_R_Save

    End Function

    Public Sub ApprovalWorkExpData(poParam As EST10000Back.EST10000WorkExperienceDTO) Implements IEST10000WorkExpService.ApprovalWorkExpData
        Dim loEx As New R_Exception
        Dim loCls As New EST10000WorkExperienceCls
        Try
            loCls.ApprovalWorkExpData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
