Imports R_BackEnd
Imports R_Common
Imports QAI00200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAI00200Service" in code, svc and config file together.
Public Class QAI00200Service
    Implements IQAI00200Service

    Public Sub Svc_R_Delete(poEntity As QAI00200Back.QAI00200Dto) Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Dto).Svc_R_Delete
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As QAI00200Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAI00200Back.QAI00200Dto, poCRUDMode As R_Common.eCRUDMode) As QAI00200Back.QAI00200Dto Implements R_BackEnd.R_IServicebase(Of QAI00200Back.QAI00200Dto).Svc_R_Save
    End Function

    Public Function GetDOC(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetDOC
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetDOC(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetFILING(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetFILING
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetFILING(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetHISTDOCINFO(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetHISTDOCINFO
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetHISTDOCINFO(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetHISTFILING(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetHISTFILING
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetHISTFILING(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetRELDOC(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetRELDOC
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetRELDOC(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetRELDOCFILING(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetRELDOCFILING
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetRELDOCFILING(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetRSP_QAI00200_GETDOCCOVER(poParam As QAI00200Back.QAI00200Dto) As QAI00200Back.QAI00200Dto Implements IQAI00200Service.GetRSP_QAI00200_GETDOCCOVER
        Dim loEx As New R_Exception
        Dim loCls As New QAI00200Cls
        Dim loRtn As New QAI00200Dto

        Try
            loRtn = loCls.GetRSP_QAI00200_GETDOCCOVER(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class