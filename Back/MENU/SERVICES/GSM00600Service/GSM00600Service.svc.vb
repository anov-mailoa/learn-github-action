' NOTE: You can use the "Rename" command on the context menu to change the class name "GSM00600Service" in code, svc and config file together.
Imports R_Common
Imports GSM00600Back

Public Class GSM00600Service
    Implements IGSM00600Service


    Public Sub Svc_R_Delete(poEntity As GSM00600Back.GSM00600DTO) Implements R_BackEnd.R_IServicebase(Of GSM00600Back.GSM00600DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As GSM00600Back.GSM00600DTO) As GSM00600Back.GSM00600DTO Implements R_BackEnd.R_IServicebase(Of GSM00600Back.GSM00600DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New GSM00600CLS
        Dim loRtn As New GSM00600DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As GSM00600Back.GSM00600DTO, poCRUDMode As R_Common.eCRUDMode) As GSM00600Back.GSM00600DTO Implements R_BackEnd.R_IServicebase(Of GSM00600Back.GSM00600DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New GSM00600CLS
        Dim loRtn As New GSM00600DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function


    Public Sub CekSoftPeriod(pcCompId As String, pcUserId As String) Implements IGSM00600Service.CekSoftPeriod
        Dim loEx As New R_Exception
        Dim loCls As New GSM00600CLS
        Try
            loCls.CekSoftPeriod(pcCompId, pcUserId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
