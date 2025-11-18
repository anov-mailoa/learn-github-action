Imports R_Common
Imports QAT01000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT01000Service" in code, svc and config file together.
Public Class QAT01000Service
    Implements IQAT01000Service

    Public Sub Svc_R_Delete(poEntity As QAT01000Back.QAT01000DTO) Implements R_BackEnd.R_IServicebase(Of QAT01000Back.QAT01000DTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT01000Back.QAT01000DTO) As QAT01000Back.QAT01000DTO Implements R_BackEnd.R_IServicebase(Of QAT01000Back.QAT01000DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As QAT01000Back.QAT01000DTO, poCRUDMode As R_Common.eCRUDMode) As QAT01000Back.QAT01000DTO Implements R_BackEnd.R_IServicebase(Of QAT01000Back.QAT01000DTO).Svc_R_Save

    End Function

    'Public Sub doUploadDocument(poParam As QAT01000Back.QAT01000DTO) Implements IQAT01000Service.doUploadDocument
    '    Dim loEx As New R_Exception
    '    Dim loCls As New QAT01000CLS

    '    Try
    '        loCls.doUploadDocument(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub

    'Public Sub doUploadSource(poParam As QAT01000Back.QAT01000DTO) Implements IQAT01000Service.doUploadSource
    '    Dim loEx As New R_Exception
    '    Dim loCls As New QAT01000CLS

    '    Try
    '        loCls.doUploadSource(poParam)
    '    Catch ex As Exception
    '        loEx.Add(ex)
    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    'End Sub
End Class
