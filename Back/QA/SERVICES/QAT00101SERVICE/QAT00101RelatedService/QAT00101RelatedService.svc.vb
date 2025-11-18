' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00101RelatedService" in code, svc and config file together.
Imports System.ServiceModel
Imports R_Common
Imports R_BackEnd
Imports QAT00101Back

Public Class QAT00101RelatedService
    Implements IQAT00101RelatedService
     
    Public Sub Svc_R_Delete(poEntity As QAT00101Back.QAT00101RelatedPositionGridDTO) Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101RelatedPositionGridDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00101RelatedPositionCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00101Back.QAT00101RelatedPositionGridDTO) As QAT00101Back.QAT00101RelatedPositionGridDTO Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101RelatedPositionGridDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New QAT00101RelatedPositionCLS
        Dim loRtn As New QAT00101RelatedPositionGridDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00101Back.QAT00101RelatedPositionGridDTO, poCRUDMode As R_Common.eCRUDMode) As QAT00101Back.QAT00101RelatedPositionGridDTO Implements R_BackEnd.R_IServicebase(Of QAT00101Back.QAT00101RelatedPositionGridDTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New QAT00101RelatedPositionCLS
        Dim loRtn As New QAT00101RelatedPositionGridDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub saveAllAudit(poParam As QAT00101Back.QAT00101RelatedPositionGridDTO) Implements IQAT00101RelatedService.saveAllAudit

        Dim loEx As New R_Exception
        Dim loCls As New QAT00101RelatedPositionCLS

        Try
            loCls.saveAllAudit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

End Class
