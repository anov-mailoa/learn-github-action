Imports R_BackEnd
Imports R_Common
Imports JCT00200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT00200Service" in code, svc and config file together.
Public Class JCT00200Service
    Implements IJCT00200Service

    Public Sub DeleteProcess(poParam As JCT00200Back.JCT00200Dto) Implements IJCT00200Service.DeleteProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls

        Try
            loCls.DeleteProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function getCutOffYear(pcCompId As String) As String Implements IJCT00200Service.getCutOffYear
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getCutOffYear(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getInitialProcess(pcCompId As String) As Integer Implements IJCT00200Service.getInitialProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getInitialProcess(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getValidateAdd(poParam As JCT00200Back.JCT00200Dto) As String Implements IJCT00200Service.getValidateAdd
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
        Dim loRtn As String

        Try
            loRtn = loCls.getValidateAdd(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub ReDraftProcess(poParam As JCT00200Back.JCT00200Dto) Implements IJCT00200Service.ReDraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls

        Try
            loCls.ReDraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub SubmitProcess(poParam As JCT00200Back.JCT00200Dto) Implements IJCT00200Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls

        Try
            loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function ValidateFound(pcCompId As String, pcRefNo As String, pcTransStatus As String) As String Implements IJCT00200Service.ValidateFound
        Dim loEx As New R_Exception
        Dim loCls As New JCT00200Cls
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
