Imports R_Common
Imports PYM01500Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYM01500ServiceRef" in code, svc and config file together.
Public Class PYM01500Service
    Implements IPYM01500Service

    Public Sub Svc_R_Delete(poEntity As PYM01500Back.PYM01500DTO) Implements R_BackEnd.R_IServicebase(Of PYM01500Back.PYM01500DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PYM01500Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYM01500Back.PYM01500DTO) As PYM01500Back.PYM01500DTO Implements R_BackEnd.R_IServicebase(Of PYM01500Back.PYM01500DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYM01500Cls
        Dim loRtn As New PYM01500DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYM01500Back.PYM01500DTO, poCRUDMode As R_Common.eCRUDMode) As PYM01500Back.PYM01500DTO Implements R_BackEnd.R_IServicebase(Of PYM01500Back.PYM01500DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYM01500Cls
        Dim loRtn As New PYM01500DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getLastYear(poParam As String) As String Implements IPYM01500Service.getLastYear
        Dim loEx As New R_Exception
        Dim loCls As New PYM01500Cls
        Dim lcRtn As String

        Try
            lcRtn = loCls.getLastYear(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function

    Public Sub getCheckSyntax(pcSyntax As String) Implements IPYM01500Service.getCheckSyntax
        Dim loCls As New PYM01500Cls
        Dim loEx As New R_Exception

        Try
            loCls.getCheckSyntax(pcSyntax)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub cloneProcess(poParam As PYM01500Back.PYM01500DTO) Implements IPYM01500Service.cloneProcess
        Dim loCls As New PYM01500Cls
        Dim loEx As New R_Exception

        Try
            loCls.cloneProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub
End Class
