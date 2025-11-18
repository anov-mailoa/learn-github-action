Imports R_BackEnd
Imports R_Common
Imports LNT00700Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00700Service" in code, svc and config file together.
Public Class LNT00700Service
    Implements ILNT00700Service

    Public Sub Svc_R_Delete(poEntity As LNT00700Back.LNT00700Dto) Implements R_BackEnd.R_IServicebase(Of LNT00700Back.LNT00700Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00700Back.LNT00700Dto) As LNT00700Back.LNT00700Dto Implements R_BackEnd.R_IServicebase(Of LNT00700Back.LNT00700Dto).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700Cls
        Dim loRtn As LNT00700Dto

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00700Back.LNT00700Dto, poCRUDMode As R_Common.eCRUDMode) As LNT00700Back.LNT00700Dto Implements R_BackEnd.R_IServicebase(Of LNT00700Back.LNT00700Dto).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00700Cls
        Dim loRtn As LNT00700Dto

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
