Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports MCB04000Back

Public Class MCB04000RegularService
    Implements IMCB04000RegularService


    Public Sub Svc_R_Delete(poEntity As MCB04000Back.MCB04000UntransferedClaimDto) Implements R_BackEnd.R_IServicebase(Of MCB04000Back.MCB04000UntransferedClaimDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB04000Back.MCB04000UntransferedClaimDto) As MCB04000Back.MCB04000UntransferedClaimDto Implements R_BackEnd.R_IServicebase(Of MCB04000Back.MCB04000UntransferedClaimDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCB04000Back.MCB04000UntransferedClaimDto, poCRUDMode As R_Common.eCRUDMode) As MCB04000Back.MCB04000UntransferedClaimDto Implements R_BackEnd.R_IServicebase(Of MCB04000Back.MCB04000UntransferedClaimDto).Svc_R_Save

    End Function

    Public Function getCurrentMedicalYear(poParam As MCB04000Back.MCB04000UntransferedClaimDto) As MCB04000Back.MCB04000UntransferedClaimDto Implements IMCB04000RegularService.getCurrentMedicalYear
        Dim loException As New R_Exception
        Dim loCls As New MCB04000ClosePolicyCls
        Dim loRtn As New MCB04000UntransferedClaimDto

        Try
            loRtn = loCls.getCurrentMedicalYear(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Sub CloseProcess(poParam As MCB04000Back.MCB04000UntransferedClaimDto) Implements IMCB04000RegularService.CloseProcess
        Dim loEx As New R_Exception
        Dim loCls As New MCB04000ClosePolicyCls

        Try
            loCls.CloseProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
