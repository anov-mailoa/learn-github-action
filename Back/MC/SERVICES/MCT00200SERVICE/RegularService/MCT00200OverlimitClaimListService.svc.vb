Imports R_BackEnd
Imports R_Common
Imports MCT00200Back
Imports System.ServiceModel
Imports SIAPP_SERVICE_MC

Public Class MCT00200OverlimitClaimListService
    Implements IMCT00200OverlimitClaimListService

    Public Sub Svc_R_Delete(poEntity As MCT00200Back.MCT00200OverlimitClaimDetailDto) Implements R_BackEnd.R_IServicebase(Of MCT00200Back.MCT00200OverlimitClaimDetailDto).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT00200OverlimitClaimListCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT00200Back.MCT00200OverlimitClaimDetailDto) As MCT00200Back.MCT00200OverlimitClaimDetailDto Implements R_BackEnd.R_IServicebase(Of MCT00200Back.MCT00200OverlimitClaimDetailDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT00200Back.MCT00200OverlimitClaimDetailDto, poCRUDMode As R_Common.eCRUDMode) As MCT00200Back.MCT00200OverlimitClaimDetailDto Implements R_BackEnd.R_IServicebase(Of MCT00200Back.MCT00200OverlimitClaimDetailDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function saveOverlimitClaimList(poParam As MCT00200Back.MCT00200OverlimitClaimDetailDto) As Object Implements IMCT00200OverlimitClaimListService.saveOverlimitClaimList
        Dim loEx As New R_Exception
        Dim loCLS As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto

        Try
            loRtn = loCLS.saveOverlimitClaimList(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function cekMedicalYear(pcCompId As String) As MCT00200Back.MCT00200OverlimitClaimDetailDto Implements IMCT00200OverlimitClaimListService.cekMedicalYear
        Dim loException As New R_Exception
        Dim loCls As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto

        Try
            loRtn = loCls.cekMedicalYear(pcCompId)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function saveApproveClaimProcess(poParam As MCT00200Back.MCT00200OverlimitClaimDetailDto) As Object Implements IMCT00200OverlimitClaimListService.saveApproveClaimProcess
        Dim loEx As New R_Exception
        Dim loCLS As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto

        Try
            loRtn = loCLS.saveApproveClaimProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function getRecordMedicalRestriction(poParam As MCT00200Back.MCT00200ApprovalClaimDto) As MCT00200Back.MCT00200ApprovalClaimDto Implements IMCT00200OverlimitClaimListService.getRecordMedicalRestriction
        Dim loEx As New R_Exception
        Dim loCls As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200ApprovalClaimDto

        Try
            loRtn = loCls.getRecordMedicalRestriction(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn

    End Function

    Public Function SubmitSaveOverlimitTransaction(poParam As MCT00200OverlimitClaimDetailDto) As Object Implements IMCT00200OverlimitClaimListService.SubmitSaveOverlimitTransaction
        Dim loEx As New R_Exception
        Dim loCLS As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto

        Try
            loRtn = loCLS.SubmitSaveOverlimitTransaction(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function DraftSaveOverlimitTransaction(poParam As MCT00200OverlimitClaimDetailDto) As Object Implements IMCT00200OverlimitClaimListService.DraftSaveOverlimitTransaction
        Dim loEx As New R_Exception
        Dim loCLS As New MCT00200OverlimitClaimListCls
        Dim loRtn As New MCT00200OverlimitClaimDetailDto

        Try
            loRtn = loCLS.DraftSaveOverlimitTransaction(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Function
End Class
