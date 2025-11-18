Imports R_BackEnd
Imports R_Common
Imports JCT01000Back
Imports JCT01000Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT01000DetailService" in code, svc and config file together.
Public Class JCT01000DetailService
    Implements IJCT01000DetailService

    Public Sub Svc_R_Delete(poEntity As JCT01000Back.JCT01000DetailDto) Implements R_BackEnd.R_IServicebase(Of JCT01000Back.JCT01000DetailDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCT01000Back.JCT01000DetailDto) As JCT01000Back.JCT01000DetailDto Implements R_BackEnd.R_IServicebase(Of JCT01000Back.JCT01000DetailDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As New JCT01000DetailDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As JCT01000Back.JCT01000DetailDto, poCRUDMode As R_Common.eCRUDMode) As JCT01000Back.JCT01000DetailDto Implements R_BackEnd.R_IServicebase(Of JCT01000Back.JCT01000DetailDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As New JCT01000DetailDto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RejectProcess(poParam As JCT01000Back.JCT01000DetailDto) Implements IJCT01000DetailService.RejectProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls

        Try
            loCls.RejectProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub ReopenProcess(poParam As JCT01000Back.JCT01000DetailDto) Implements IJCT01000DetailService.ReopenProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls

        Try
            loCls.ReopenProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function getHeader(poParam As JCT01000Back.JCT01000DetailDto) As JCT01000Back.HeaderDTO Implements IJCT01000DetailService.getHeader
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As New HeaderDTO
        Try
            loRtn = loCls.getHeader(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub ReassignProcess(poParam As JCT01000Back.JCT01000DetailDto) Implements IJCT01000DetailService.ReassignProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls

        Try
            loCls.ReassignProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub ResyncProcess(poParam As JCT01000Back.JCT01000DetailDto) Implements IJCT01000DetailService.ResyncProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls

        Try
            loCls.ResyncProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function GetJcSystemParam(pcCompId As String) As JCT01000Back.JCT01000DetailDto Implements IJCT01000DetailService.GetJcSystemParam
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Dim loRtn As New JCT01000DetailDto
        Try
            loRtn = loCls.GetJcSystemParam(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub ProcessFileResult(poParam As JCT01000Back.JCT01000DetailDto) Implements IJCT01000DetailService.ProcessFileResult
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000DetailCls
        Try
            loCls.ProcessFileResult(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function UpdateAttachmentFile(poParam As System.Collections.Generic.List(Of JCT01000Back.JCT01000DetailDto)) As Object Implements IJCT01000DetailService.UpdateAttachmentFile
        Dim loEx As New R_Exception
        Dim loCls As New JCT01000Cls

        Try

            loCls.UpdateAttachmentFile(poParam)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
