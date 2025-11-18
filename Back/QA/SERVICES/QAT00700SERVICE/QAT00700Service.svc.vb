Imports R_BackEnd
Imports R_Common
Imports QAT00700Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00700Service" in code, svc and config file together.
Public Class QAT00700Service
    Implements IQAT00700Service

    Public Sub Svc_R_Delete(poEntity As QAT00700Back.QAT00700Dto) Implements R_BackEnd.R_IServicebase(Of QAT00700Back.QAT00700Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00700Back.QAT00700Dto) As QAT00700Back.QAT00700Dto Implements R_BackEnd.R_IServicebase(Of QAT00700Back.QAT00700Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAT00700Back.QAT00700Dto, poCRUDMode As R_Common.eCRUDMode) As QAT00700Back.QAT00700Dto Implements R_BackEnd.R_IServicebase(Of QAT00700Back.QAT00700Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00700Cls
        Dim loRtn As New QAT00700Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetSocializationInfoProcess(poParam As QAT00700Back.QAT00700Dto) As QAT00700Back.QAT00700Dto Implements IQAT00700Service.GetSocializationInfoProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00700Cls
        Dim loRtn As New QAT00700Dto

        Try
            loRtn = loCls.GetSocializationInfoProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetSystemParameter(poParam As QAT00700Back.QAT00700Dto) As QAT00700Back.QAT00700Dto Implements IQAT00700Service.GetSystemParameter
        Dim loEx As New R_Exception
        Dim loCls As New QAT00700Cls
        Dim loRtn As New QAT00700Dto

        Try
            loRtn = loCls.GetSystemParameter(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
