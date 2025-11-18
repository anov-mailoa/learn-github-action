Imports R_BackEnd
Imports R_Common
Imports QAT00400Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00400Service" in code, svc and config file together.
Public Class QAT00400Service
    Implements IQAT00400Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAT00400Back.QAT00400DTO) Implements R_BackEnd.R_IServicebase(Of QAT00400Back.QAT00400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAT00400Back.QAT00400DTO) As QAT00400Back.QAT00400DTO Implements R_BackEnd.R_IServicebase(Of QAT00400Back.QAT00400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As QAT00400DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAT00400Back.QAT00400DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAT00400Back.QAT00400DTO Implements R_BackEnd.R_IServicebase(Of QAT00400Back.QAT00400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As New QAT00400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function GetLoadQAParameter(ByVal poPar As QAT00400Back.QAT00400DTO) As QAT00400Back.QAT00400DTO Implements IQAT00400Service.GetLoadQAParameter
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As QAT00400DTO

        Try
            loRtn = loCls.GetLoadQAParameter(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCheckDocument(ByVal poPar As QAT00400Back.QAT00400DTO) As QAT00400Back.QAT00400DTO Implements IQAT00400Service.getCheckDocument
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As QAT00400DTO

        Try
            loRtn = loCls.getCheckDocument(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDocumentInfo(ByVal poPar As QAT00400Back.QAT00400DTO) As QAT00400Back.QAT00400DTO Implements IQAT00400Service.getDocumentInfo
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As QAT00400DTO

        Try
            loRtn = loCls.getDocumentInfo(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getVlidationSavemodenew(ByVal poPar As QAT00400Back.QAT00400DTO) As Integer Implements IQAT00400Service.getVlidationSavemodenew
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.getVlidationSavemodenew(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    '===== MT 20170831 ====='
    Public Function getCheckRelatedDocument(poPar As QAT00400Back.QAT00400DTO) As Integer Implements IQAT00400Service.getCheckRelatedDocument
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As Integer

        Try
            loRtn = loCls.getCheckRelatedDocument(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub redraftProcess(poParam As QAT00400Back.QAT00400DTO) Implements IQAT00400Service.redraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS

        Try
            loCls.redraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub submitProcess(poParam As QAT00400Back.QAT00400DTO) Implements IQAT00400Service.submitProcess
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS

        Try
            loCls.submitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
    '======================='

    Public Function getTransProfile(poPar As QAT00400Back.QAT00400DTO) As QAT00400Back.QAT00400RSPGetTransProfileDTO Implements IQAT00400Service.getTransProfile
        Dim loEx As New R_Exception
        Dim loCls As New QAT00400CLS
        Dim loRtn As New QAT00400RSPGetTransProfileDTO

        Try
            loRtn = loCls.getTransProfile(poPar)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
