Imports R_Common
Imports R_BackEnd
Imports MCT02000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "MCT02000Service" in code, svc and config file together.
Public Class MCT02000LimitCorDetService
    Implements IMCT02000LimitCorDetService

    Public Sub Svc_R_Delete(poEntity As MCT02000Back.MCT02000LimitCorDetDTO) Implements R_BackEnd.R_IServicebase(Of MCT02000Back.MCT02000LimitCorDetDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000LimitCorDetCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As MCT02000Back.MCT02000LimitCorDetDTO) As MCT02000Back.MCT02000LimitCorDetDTO Implements R_BackEnd.R_IServicebase(Of MCT02000Back.MCT02000LimitCorDetDTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New MCT02000LimitCorDetCls
        Dim loRtn As New MCT02000LimitCorDetDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As MCT02000Back.MCT02000LimitCorDetDTO, poCRUDMode As R_Common.eCRUDMode) As MCT02000Back.MCT02000LimitCorDetDTO Implements R_BackEnd.R_IServicebase(Of MCT02000Back.MCT02000LimitCorDetDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New MCT02000LimitCorDetCls
        Dim loRtn As New MCT02000LimitCorDetDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
