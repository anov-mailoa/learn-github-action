Imports R_Common
Imports ESM01100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ESM01100Services" in code, svc and config file together.
Public Class ESM01100MedicalHistoryServices
    Implements IESM01100MedicalHistoryServices

    Public Sub Svc_R_Delete(poEntity As ESM01100Back.ESM01100MedicalHistoryDTO) Implements R_BackEnd.R_IServicebase(Of ESM01100Back.ESM01100MedicalHistoryDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100MedicalHistoryCLS

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(poEntity As ESM01100Back.ESM01100MedicalHistoryDTO) As ESM01100Back.ESM01100MedicalHistoryDTO Implements R_BackEnd.R_IServicebase(Of ESM01100Back.ESM01100MedicalHistoryDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100MedicalHistoryCLS
        Dim loRtn As New ESM01100MedicalHistoryDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ESM01100Back.ESM01100MedicalHistoryDTO, poCRUDMode As R_Common.eCRUDMode) As ESM01100Back.ESM01100MedicalHistoryDTO Implements R_BackEnd.R_IServicebase(Of ESM01100Back.ESM01100MedicalHistoryDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ESM01100MedicalHistoryCLS
        Dim loRtn As New ESM01100MedicalHistoryDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
