Imports R_BackEnd
Imports R_Common
Imports MCB01200Back
Imports System.ServiceModel

Public Class MCB01200CurrentYearService
    Implements IMCB01200CurrentYearService

    Public Function getCurrentMedicalYear(poParam As MCB01200Back.MCB01200CurrentYearDto) As MCB01200Back.MCB01200CurrentYearDto Implements IMCB01200CurrentYearService.getCurrentMedicalYear
        Dim loException As New R_Exception
        Dim loCls As New MCB01200CurrentYearCls
        Dim loRtn As New MCB01200CurrentYearDto

        Try
            loRtn = loCls.getCurrentMedicalYear(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As MCB01200Back.MCB01200CurrentYearDto) Implements R_BackEnd.R_IServicebase(Of MCB01200Back.MCB01200CurrentYearDto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCB01200Back.MCB01200CurrentYearDto) As MCB01200Back.MCB01200CurrentYearDto Implements R_BackEnd.R_IServicebase(Of MCB01200Back.MCB01200CurrentYearDto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New MCB01200CurrentYearCls
        Dim loRtn As New MCB01200CurrentYearDto

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCB01200Back.MCB01200CurrentYearDto, poCRUDMode As R_Common.eCRUDMode) As MCB01200Back.MCB01200CurrentYearDto Implements R_BackEnd.R_IServicebase(Of MCB01200Back.MCB01200CurrentYearDto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCLS As New MCB01200CurrentYearCls
        Dim loRtn As New MCB01200CurrentYearDto

        Try
            loRtn = loCLS.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
