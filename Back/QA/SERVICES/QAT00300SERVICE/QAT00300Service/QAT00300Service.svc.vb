Imports R_BackEnd
Imports R_Common
Imports QAT00300Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00300Service" in code, svc and config file together.
Public Class QAT00300Service
    Implements IQAT00300Service

    Public Sub Svc_R_Delete(poEntity As QAT00300Back.QAT00300DTO) Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT00300DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00300Back.QAT00300DTO) As QAT00300Back.QAT00300DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT00300DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAT00300Back.QAT00300DTO, poCRUDMode As R_Common.eCRUDMode) As QAT00300Back.QAT00300DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT00300DTO).Svc_R_Save

    End Function

    Public Function getCheckDocument(poParam As QAT00300Back.QAT00300DTO) As QAT00300Back.QAT00300DTO Implements IQAT00300Service.getCheckDocument
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New QAT00300DTO

        Try
            loRtn = loCls.getCheckDocument(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCheckOpenDocument(poParam As QAT00300Back.QAT00300DTO) As QAT00300Back.QAT00300DTO Implements IQAT00300Service.getCheckOpenDocument
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New QAT00300DTO

        Try
            loRtn = loCls.getCheckOpenDocument(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getCheckRelatedDocument(poParam As QAT00300Back.QAT00300DTO) As QAT00300Back.QAT00300DTO Implements IQAT00300Service.getCheckRelatedDocument
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New QAT00300DTO

        Try
            loRtn = loCls.getCheckRelatedDocument(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getDocumentInfo(poParam As QAT00300Back.QAT00300DTO) As QAT00300Back.QAT00300DTO Implements IQAT00300Service.getDocumentInfo
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New QAT00300DTO

        Try
            loRtn = loCls.getDocumentInfo(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getPropertData(poParam As QAT00300Back.QAT00300DTO) As QAT00300Back.QAT00300DTO Implements IQAT00300Service.getPropertData
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300CLS
        Dim loRtn As New QAT00300DTO

        Try
            loRtn = loCls.getPropertData(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
