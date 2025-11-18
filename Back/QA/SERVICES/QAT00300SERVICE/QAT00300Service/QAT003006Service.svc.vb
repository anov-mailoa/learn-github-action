Imports R_BackEnd
Imports R_Common
Imports QAT00300Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT003006Service" in code, svc and config file together.
Public Class QAT003006Service
    Implements IQAT003006Service

    Public Sub Svc_R_Delete(poEntity As QAT00300Back.QAT003006DTO) Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003006DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainersCLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00300Back.QAT003006DTO) As QAT00300Back.QAT003006DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003006DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainersCLS
        Dim loRtn As QAT003006DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00300Back.QAT003006DTO, poCRUDMode As R_Common.eCRUDMode) As QAT00300Back.QAT003006DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003006DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainersCLS
        Dim loRtn As New QAT003006DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEditRelatedDoc(poParam As String) As Boolean Implements IQAT003006Service.getEditRelatedDoc
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300RetainersCLS
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
