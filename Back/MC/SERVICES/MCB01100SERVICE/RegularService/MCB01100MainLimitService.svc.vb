Imports R_BackEnd
Imports R_Common
Imports MCB01100Back
Imports System.ServiceModel

Public Class MCB01100MainLimitService
    Implements IMCB01100MainLimitService

    Public Sub Svc_R_Delete(poEntity As MCB01100Back.MCB01100MainLimitDto) Implements R_BackEnd.R_IServicebase(Of MCB01100Back.MCB01100MainLimitDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB01100Back.MCB01100MainLimitDto) As MCB01100Back.MCB01100MainLimitDto Implements R_BackEnd.R_IServicebase(Of MCB01100Back.MCB01100MainLimitDto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As MCB01100Back.MCB01100MainLimitDto, poCRUDMode As R_Common.eCRUDMode) As MCB01100Back.MCB01100MainLimitDto Implements R_BackEnd.R_IServicebase(Of MCB01100Back.MCB01100MainLimitDto).Svc_R_Save

    End Function

    Public Function cekMcmLimitPolicy(poParam As MCB01100Back.MCB01100MainLimitDto) As MCB01100Back.MCB01100MainLimitDto Implements IMCB01100MainLimitService.cekMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCB01100MainLimitCls
        Dim loRtn As New MCB01100MainLimitDto

        Try
            loRtn = loCls.cekMcmLimitPolicy(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getMcmLimitPolicy(poParam As MCB01100Back.MCB01100MainLimitDto) As MCB01100Back.MCB01100MainLimitDto Implements IMCB01100MainLimitService.getMcmLimitPolicy
        Dim loException As New R_Exception
        Dim loCls As New MCB01100MainLimitCls
        Dim loRtn As New MCB01100MainLimitDto

        Try
            loRtn = loCls.getMcmLimitPolicy(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getInit(pcCompid As String) As MCB01100Back.MCB01100MainLimitDto Implements IMCB01100MainLimitService.getInit
        Dim loException As New R_Exception
        Dim loCls As New MCB01100MainLimitCls
        Dim loRtn As New MCB01100MainLimitDto

        Try
            loRtn = loCls.getInit(pcCompid)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function UpdateValidation(pcCompid As MCB01100Back.MCB01100MainLimitDto) As MCB01100Back.MCB01100MainLimitDto Implements IMCB01100MainLimitService.UpdateValidation
        Dim loException As New R_Exception
        Dim loCls As New MCB01100MainLimitCls
        Dim loRtn As New MCB01100MainLimitDto

        Try
            loRtn = loCls.UpdateValidation(pcCompid)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
