Imports R_BackEnd
Imports R_Common
Imports QAT00300Back
' NOTE: You can use th
' NOTE: You can use the "Rename" command on the context menu to change the class name "QAT003001Service" in code, svc and config file together.
Public Class QAT003001Service
    Implements IQAT003001Service



    Public Sub Svc_R_Delete(poEntity As QAT00300Back.QAT003001DTO) Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003001DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New QAT003001CLS

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As QAT00300Back.QAT003001DTO) As QAT00300Back.QAT003001DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003001DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New QAT003001CLS
        Dim loRtn As New QAT003001DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As QAT00300Back.QAT003001DTO, poCRUDMode As R_Common.eCRUDMode) As QAT00300Back.QAT003001DTO Implements R_BackEnd.R_IServicebase(Of QAT00300Back.QAT003001DTO).Svc_R_Save

        Dim loEx As New R_Exception
        Dim loCls As New QAT003001CLS
        Dim loRtn As New QAT003001DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
