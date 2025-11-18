Imports R_BackEnd
Imports R_Common
Imports QAT00300Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT003005Service" in code, svc and config file together.
Public Class QAT003005Service
    Implements IQAT003005Service

    Public Sub Svc_R_Delete(poEntity As QAT00300Back.QAT003005DTO) Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003005DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainDocumentCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00300Back.QAT003005DTO) As QAT00300Back.QAT003005DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003005DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainDocumentCLS
        Dim loRtn As QAT003005DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00300Back.QAT003005DTO, poCRUDMode As R_Common.eCRUDMode) As QAT00300Back.QAT003005DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003005DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainDocumentCLS
        Dim loRtn As New QAT003005DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkDocTypeMandatory(poParam As QAT00300Back.QAT003005DTO) As Boolean Implements IQAT003005Service.checkDocTypeMandatory
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainDocumentCLS
        Dim loRtn As New Boolean

        Try
            loRtn = loCls.checkDocTypeMandatory(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEditRelatedDoc(poParam As String) As Boolean Implements IQAT003005Service.getEditRelatedDoc
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainDocumentCLS
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
