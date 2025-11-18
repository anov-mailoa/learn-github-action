Imports R_BackEnd
Imports R_Common
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00600Service" in code, svc and config file together.
Public Class QAT00600Service
    Implements IQAT00600Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAT00600Back.QAT00600DTO) Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT00600DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00600Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAT00600Back.QAT00600DTO) As QAT00600Back.QAT00600DTO Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT00600DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtn As QAT00600DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAT00600Back.QAT00600DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAT00600Back.QAT00600DTO Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT00600DTO).Svc_R_Save
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtn As QAT00600DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getInitialProcess(ByVal poParam As QAT00600Back.QAT00600DTO) As QAT00600Back.QAT00600DTO Implements IQAT00600Service.getInitialProcess
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtn As New QAT00600DTO

        Try
            loRtn = loCls.getInitialProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RedraftProcess(ByVal poParam As QAT00600Back.QAT00600DTO) Implements IQAT00600Service.RedraftProcess
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls

        Try
            loCls.RedraftProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub SubmitProcess(ByVal poParam As QAT00600Back.QAT00600DTO) Implements IQAT00600Service.SubmitProcess
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls

        Try
            loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getCopySocProcess(ByVal poParam As QAT00600Back.QAT00600DTO) As QAT00600Back.QAT00600DTO Implements IQAT00600Service.getCopySocProcess
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtn As QAT00600DTO = Nothing

        Try
            loRtn = loCls.getCopySocProcess(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSubmitValidationTab2(ByVal poParam As QAT00600Back.QAT00600DTO) As QAT00600Back.QAT00600DTO Implements IQAT00600Service.getSubmitValidationTab2
        Dim loException As New R_Exception
        Dim loCls As New QAT00600Cls
        Dim loRtn As New QAT00600DTO

        Try
            loRtn = loCls.getSubmitValidationTab2(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
