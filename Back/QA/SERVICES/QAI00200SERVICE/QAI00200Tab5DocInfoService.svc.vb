'===== MT CR04 ====='


Imports R_BackEnd
Imports R_Common
Imports QAI00200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI00200Tab5DocInfoService" in code, svc and config file together.
Public Class QAI00200Tab5DocInfoService
    Implements IQAI00200Tab5DocInfoService

    Public Sub Svc_R_Delete(poEntity As QAI00200Back.QAI00200Tab5DocInfoDTO) Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Tab5DocInfoDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Tab5DocInfoCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAI00200Back.QAI00200Tab5DocInfoDTO) As QAI00200Back.QAI00200Tab5DocInfoDTO Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Tab5DocInfoDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Tab5DocInfoCLS
        Dim loRtn As QAI00200Tab5DocInfoDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAI00200Back.QAI00200Tab5DocInfoDTO, poCRUDMode As R_Common.eCRUDMode) As QAI00200Back.QAI00200Tab5DocInfoDTO Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Tab5DocInfoDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Tab5DocInfoCLS
        Dim loRtn As New QAI00200Tab5DocInfoDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEditRelatedDoc(poParam As String) As Boolean Implements IQAI00200Tab5DocInfoService.getEditRelatedDoc
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Tab5DocInfoCLS
        Dim loRtn As New Boolean

        Try
            loRtn = loCls.getEditRelatedDoc(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
