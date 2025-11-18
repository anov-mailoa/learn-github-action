Imports R_Common
Imports LNM00400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNM00400DetailService" in code, svc and config file together.
Public Class LNM00400DetailService
    Implements ILNM00400DetailService

    Public Sub Svc_R_Delete(poEntity As LNM00400Back.LNM00400DetailDTO) Implements R_BackEnd.R_IServicebase(Of LNM00400Back.LNM00400DetailDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNM00400Cls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNM00400Back.LNM00400DetailDTO) As LNM00400Back.LNM00400DetailDTO Implements R_BackEnd.R_IServicebase(Of LNM00400Back.LNM00400DetailDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNM00400Cls
        Dim loRtn As New LNM00400DetailDTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNM00400Back.LNM00400DetailDTO, poCRUDMode As R_Common.eCRUDMode) As LNM00400Back.LNM00400DetailDTO Implements R_BackEnd.R_IServicebase(Of LNM00400Back.LNM00400DetailDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNM00400Cls
        Dim loRtn As New LNM00400DetailDTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of LNM00400Back.LNM00400DetailGridDTO)) Implements ILNM00400DetailService.Dummy

    End Sub

    Public Sub removeAll(poParam As LNM00400Back.LNM00400DetailDTO) Implements ILNM00400DetailService.removeAll
        Dim loEx As New R_Exception
        Dim loCls As New LNM00400Cls
        Try
            loCls.removeAll(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
