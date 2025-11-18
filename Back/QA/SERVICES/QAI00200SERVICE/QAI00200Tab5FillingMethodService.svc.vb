'===== MT CR04 ====='



Imports System.ServiceModel
Imports R_Common
Imports QAI00200Back
Imports R_BackEnd
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI00200Tab5FillingMethodService" in code, svc and config file together.
Public Class QAI00200Tab5FillingMethodService
    Implements IQAI00200Tab5FillingMethodService

    Public Sub Svc_R_Delete(poEntity As QAI00200Back.QAI00200Tab5FillingMethodDTO) Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Tab5FillingMethodDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAI00200Back.QAI00200Tab5FillingMethodDTO) As QAI00200Back.QAI00200Tab5FillingMethodDTO Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Tab5FillingMethodDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Tab5FillingMethodCLS
        Dim loRtn As QAI00200Tab5FillingMethodDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAI00200Back.QAI00200Tab5FillingMethodDTO, poCRUDMode As R_Common.eCRUDMode) As QAI00200Back.QAI00200Tab5FillingMethodDTO Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Tab5FillingMethodDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Tab5FillingMethodCLS
        Dim loRtn As New QAI00200Tab5FillingMethodDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
