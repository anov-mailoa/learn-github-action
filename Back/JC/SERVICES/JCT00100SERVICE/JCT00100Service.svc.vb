Imports R_BackEnd
Imports R_Common
Imports JCT00100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT00100Service" in code, svc and config file together.
Public Class JCT00100Service
    Implements IJCT00100Service

    Public Sub Svc_R_Delete(poEntity As JCT00100Back.JCT00100Dto) Implements R_BackEnd.R_IServicebase(Of JCT00100Back.JCT00100Dto).Svc_R_Delete

    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCT00100Back.JCT00100Dto) As JCT00100Back.JCT00100Dto Implements R_BackEnd.R_IServicebase(Of JCT00100Back.JCT00100Dto).Svc_R_GetRecord

    End Function

    Public Function Svc_R_Save(poEntity As JCT00100Back.JCT00100Dto, poCRUDMode As R_Common.eCRUDMode) As JCT00100Back.JCT00100Dto Implements R_BackEnd.R_IServicebase(Of JCT00100Back.JCT00100Dto).Svc_R_Save

    End Function

    Public Function getCutOffYear(pcCompId As String) As String Implements IJCT00100Service.getCutOffYear
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getCutOffYear(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getInitialProcess(pcCompId As String) As Integer Implements IJCT00100Service.getInitialProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getInitialProcess(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub DeleteProcess(poParam As JCT00100Back.JCT00100Dto) Implements IJCT00100Service.DeleteProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls

        Try
            loCls.DeleteProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Sub ReDraftProcess(poParam As JCT00100Back.JCT00100Dto) Implements IJCT00100Service.ReDraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls

        Try
            loCls.ReDraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub SubmitProcess(poParam As JCT00100Back.JCT00100Dto) Implements IJCT00100Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls

        Try
            loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getValidateAdd(poParam As JCT00100Back.JCT00100Dto) As String Implements IJCT00100Service.getValidateAdd
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getValidateAdd(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function ValidateFound(pcCompId As String, pcRefNo As String, pcTransStatus As String) As String Implements IJCT00100Service.ValidateFound
        Dim loEx As New R_Exception
        Dim loCls As New JCT00100Cls
        Dim loRtn As String

        Try
            loRtn = loCls.ValidateFound(pcCompId, pcRefNo, pcTransStatus)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
