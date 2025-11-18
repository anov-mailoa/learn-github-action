Imports System.ServiceModel.Channels
Imports R_Common
Imports ESM00100Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM00100ApprovalService" in code, svc and config file together.
Public Class ESM00100ApprovalService
    Implements IESM00100ApprovalService

    Public Sub Svc_R_Delete(poEntity As ESM00100Back.ESM00100ApprovalDTO) Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100ApprovalDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls

        Try

            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM00100Back.ESM00100ApprovalDTO) As ESM00100Back.ESM00100ApprovalDTO Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100ApprovalDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls
        Dim loRtn As New ESM00100ApprovalDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM00100Back.ESM00100ApprovalDTO, poCRUDMode As R_Common.eCRUDMode) As ESM00100Back.ESM00100ApprovalDTO Implements R_BackEnd.R_IServicebase(Of ESM00100Back.ESM00100ApprovalDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls
        Dim loRtn As New ESM00100ApprovalDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function CheckApprovalSetting(poParam As ESM00100Back.ESM00100ApprovalDTO) As Boolean Implements IESM00100ApprovalService.CheckApprovalSetting
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.CheckApprovalSetting(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub CopyToProcess(loParam As ESM00100Back.ESM00100ApprovalDTO) Implements IESM00100ApprovalService.CopyToProcess
        Dim loEx As New R_Exception
        Dim loCls As New ESM00100ApprovalCls

        Try
            loCls.CopyToProcess(loParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
