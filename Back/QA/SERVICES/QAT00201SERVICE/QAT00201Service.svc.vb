Imports R_Common
Imports QAT00201Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00201Service" in code, svc and config file together.
Public Class QAT00201Service
    Implements IQAT00201Service

    Public Sub Svc_R_Delete(poEntity As QAT00201Back.QAT00201DTO) Implements R_BackEnd.R_IServicebase(Of QAT00201Back.QAT00201DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS

        Try

            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00201Back.QAT00201DTO) As QAT00201Back.QAT00201DTO Implements R_BackEnd.R_IServicebase(Of QAT00201Back.QAT00201DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim loRtn As QAT00201DTO = Nothing

        Try

            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00201Back.QAT00201DTO, poCRUDMode As R_Common.eCRUDMode) As QAT00201Back.QAT00201DTO Implements R_BackEnd.R_IServicebase(Of QAT00201Back.QAT00201DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim loRtn As QAT00201DTO = Nothing

        Try

            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getDocumentInfoProcess(poParam As QAT00201Back.QAT00201DTO) As QAT00201Back.QAT00201DTO Implements IQAT00201Service.getDocumentInfoProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim loRtn As QAT00201DTO

        Try
            loRtn = loCls.getDocumentInfoProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getQAParam(poParam As QAT00201Back.QAT00201DTO) As QAT00201Back.QAT00201DTO Implements IQAT00201Service.getQAParam
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim loRtn As QAT00201DTO

        Try
            loRtn = loCls.getQAParam(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getTransactionProfile(poParam As QAT00201Back.QAT00201DTO) As QAT00201Back.QAT00201DTO Implements IQAT00201Service.getTransactionProfile
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS
        Dim loRtn As QAT00201DTO

        Try
            loRtn = loCls.getTransactionProfile(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub confirmProcess(poParam As QAT00201Back.QAT00201DTO) Implements IQAT00201Service.confirmProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS

        Try
            loCls.confirmProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub redraftProcess(poParam As QAT00201Back.QAT00201DTO) Implements IQAT00201Service.redraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS

        Try
            loCls.redraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub submitProcess(poParam As QAT00201Back.QAT00201DTO) Implements IQAT00201Service.submitProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS

        Try
            loCls.submitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub unverifyProcess(poParam As QAT00201Back.QAT00201DTO) Implements IQAT00201Service.unverifyProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS

        Try
            loCls.unverifyProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub verifyProcess(poParam As QAT00201Back.QAT00201DTO) Implements IQAT00201Service.verifyProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00201CLS

        Try
            loCls.verifyProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
