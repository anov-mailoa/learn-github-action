Imports R_BackEnd
Imports R_Common
Imports JCT00300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "JCT00300Service" in code, svc and config file together.
Public Class JCT00300Service
    Implements IJCT00300Service

    Public Sub Svc_R_Delete(poEntity As JCT00300Back.JCT00300DTO) Implements R_BackEnd.R_IServicebase(Of JCT00300Back.JCT00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As JCT00300Back.JCT00300DTO) As JCT00300Back.JCT00300DTO Implements R_BackEnd.R_IServicebase(Of JCT00300Back.JCT00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
        Dim loRtn As New JCT00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As JCT00300Back.JCT00300DTO, poCRUDMode As R_Common.eCRUDMode) As JCT00300Back.JCT00300DTO Implements R_BackEnd.R_IServicebase(Of JCT00300Back.JCT00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
        Dim loRtn As New JCT00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getInitialProcess(pcCompId As String) As Integer Implements IJCT00300Service.getInitialProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.getInitialProcess(pcCompId)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub ReDraftProcess(poParam As JCT00300Back.JCT00300DTO) Implements IJCT00300Service.ReDraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls

        Try
            loCls.ReDraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub SubmitProcess(poParam As JCT00300Back.JCT00300DTO) Implements IJCT00300Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls

        Try
            loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function ValidateCREFNO(poParam As JCT00300Back.JCT00300DTO) As Integer Implements IJCT00300Service.ValidateCREFNO
        Dim loEx As New R_Exception
        Dim loCls As New JCT00300Cls
        Dim loRtn As Integer

        Try
            loRtn = loCls.ValidateCREFNO(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class
