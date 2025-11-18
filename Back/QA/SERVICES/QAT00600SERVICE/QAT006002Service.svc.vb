Imports R_BackEnd
Imports R_Common
Imports QAT00600Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT006002Service" in code, svc and config file together.
Public Class QAT006002Service
    Implements IQAT006002Service

    Public Sub Svc_R_Delete(ByVal poEntity As QAT00600Back.QAT006002DTO) Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT006002DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT006002Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As QAT00600Back.QAT006002DTO) As QAT00600Back.QAT006002DTO Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT006002DTO).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(ByVal poEntity As QAT00600Back.QAT006002DTO, ByVal poCRUDMode As R_Common.eCRUDMode) As QAT00600Back.QAT006002DTO Implements R_BackEnd.R_IServicebase(Of QAT00600Back.QAT006002DTO).Svc_R_Save

    End Function

    Public Function getValidationBatch(ByVal poParam As QAT00600Back.QAT006002DTO) As Boolean Implements IQAT006002Service.getValidationBatch
        Dim loException As New R_Exception
        Dim loCls As New QAT006002Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getValidationBatch(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
