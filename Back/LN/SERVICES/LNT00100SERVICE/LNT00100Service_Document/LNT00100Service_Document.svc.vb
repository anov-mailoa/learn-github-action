Imports R_BackEnd
Imports R_Common
Imports LNT00100Back
Imports System.ServiceModel

' NOTE: You can use the "Rename" command on the context menu to change the class name "LNT00100Service_Document" in code, svc and config file together.
Public Class LNT00100Service_Document
    Implements ILNT00100Service_Document

    Public Sub Svc_R_Delete(poEntity As LNT00100Back.LNT00100DocDTO) Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100DocDTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100DocumentCls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As LNT00100Back.LNT00100DocDTO) As LNT00100Back.LNT00100DocDTO Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100DocDTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100DocumentCls
        Dim loRtn As LNT00100DocDTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As LNT00100Back.LNT00100DocDTO, poCRUDMode As R_Common.eCRUDMode) As LNT00100Back.LNT00100DocDTO Implements R_BackEnd.R_IServicebase(Of LNT00100Back.LNT00100DocDTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100DocumentCls
        Dim loRtn As LNT00100DocDTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub RemoveDocument(poParam As LNT00100Back.LNT00100DocDTO) Implements ILNT00100Service_Document.RemoveDocument
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100DocumentCls

        Try
            loCls.RemoveDocument(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub ScanDocument(poParam As LNT00100Back.LNT00100DocDTO) Implements ILNT00100Service_Document.ScanDocument
        Dim loEx As New R_Exception
        Dim loCls As New LNT00100DocumentCls

        Try
            loCls.ScanDocument(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
