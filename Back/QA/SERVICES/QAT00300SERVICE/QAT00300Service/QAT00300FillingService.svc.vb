Imports R_BackEnd
Imports R_Common
Imports QAT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT00300FillingService" in code, svc and config file together.
Public Class QAT00300FillingService
    Implements IQAT00300FillingService

    Public Sub Svc_R_Delete(poEntity As QAT00300Back.QAT00300FillingDTO) Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT00300FillingDTO).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00300Back.QAT00300FillingDTO) As QAT00300Back.QAT00300FillingDTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT00300FillingDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300FillingCLS
        Dim loRtn As QAT00300FillingDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00300Back.QAT00300FillingDTO, poCRUDMode As R_Common.eCRUDMode) As QAT00300Back.QAT00300FillingDTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT00300FillingDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300FillingCLS
        Dim loRtn As New QAT00300FillingDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEditRelatedDoc(poParam As String) As Boolean Implements IQAT00300FillingService.getEditRelatedDoc
        Dim loEx As New R_Exception
        Dim loCls As New QAT00300FillingCLS
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
