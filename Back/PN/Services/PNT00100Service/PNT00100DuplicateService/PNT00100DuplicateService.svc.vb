' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT00100DuplicateService" in code, svc and config file together.
Imports R_BackEnd
Imports R_Common
Imports PNT00100Back
Imports System.ServiceModel
Imports SIAPP_PUB_DTO
Public Class PNT00100DuplicateService
    Implements IPNT00100DuplicateService


    Public Sub Svc_R_Delete(poEntity As PNT00100Back.PNT00100DuplicateDTO) Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100DuplicateDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT00100Back.PNT00100DuplicateDTO) As PNT00100Back.PNT00100DuplicateDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100DuplicateDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT00100DuplicateCLS
        Dim loRtn As PNT00100DuplicateDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT00100Back.PNT00100DuplicateDTO, poCRUDMode As R_Common.eCRUDMode) As PNT00100Back.PNT00100DuplicateDTO Implements R_BackEnd.R_IServicebase(Of PNT00100Back.PNT00100DuplicateDTO).Svc_R_Save

    End Function

End Class
