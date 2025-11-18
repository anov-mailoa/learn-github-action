' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT02100PartnerService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports MCT02100Back

Public Class MCT02100PartnerService
    Implements IMCT02100PartnerService

    Public Sub Svc_R_Delete(poEntity As MCT02100Back.MCT02100DetailGvDto) Implements R_BackEnd.R_IServicebase(Of MCT02100Back.MCT02100DetailGvDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100PartnerCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT02100Back.MCT02100DetailGvDto) As MCT02100Back.MCT02100DetailGvDto Implements R_BackEnd.R_IServicebase(Of MCT02100Back.MCT02100DetailGvDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100PartnerCLS
        Dim loRtn As New MCT02100DetailGvDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT02100Back.MCT02100DetailGvDto, poCRUDMode As R_Common.eCRUDMode) As MCT02100Back.MCT02100DetailGvDto Implements R_BackEnd.R_IServicebase(Of MCT02100Back.MCT02100DetailGvDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100PartnerCLS
        Dim loRtn As New MCT02100DetailGvDto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub DownloadValidation(poParam As MCT02100Back.MCT02100DetailGvDto) Implements IMCT02100PartnerService.DownloadValidation
        Dim loEx As New R_Exception
        Dim loCls As New MCT02100Cls

        Try
            loCls.DownloadValidation(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
