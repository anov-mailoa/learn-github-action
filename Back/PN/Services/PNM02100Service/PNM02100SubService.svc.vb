Imports R_Common
Imports PNM02100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNM02100SubService" in code, svc and config file together.
Public Class PNM02100SubService
    Implements IPNM02100SubService

    Public Sub Svc_R_Delete(poEntity As PNM02100Back.PNM02100ScoreInfoDTO) Implements R_BackEnd.R_IServicebase(Of PNM02100Back.PNM02100ScoreInfoDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNM02100SubCLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNM02100Back.PNM02100ScoreInfoDTO) As PNM02100Back.PNM02100ScoreInfoDTO Implements R_BackEnd.R_IServicebase(Of PNM02100Back.PNM02100ScoreInfoDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNM02100SubCLS
        Dim loRtn As New PNM02100ScoreInfoDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNM02100Back.PNM02100ScoreInfoDTO, poCRUDMode As R_Common.eCRUDMode) As PNM02100Back.PNM02100ScoreInfoDTO Implements R_BackEnd.R_IServicebase(Of PNM02100Back.PNM02100ScoreInfoDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNM02100SubCLS
        Dim loRtn As New PNM02100ScoreInfoDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
