Imports R_Common
Imports PYT00800Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT00800Service" in code, svc and config file together.
Public Class PYT00800Service
    Implements IPYT00800Service

    Public Sub Svc_R_Delete(poEntity As PYT00800Back.PYT00800DTO) Implements R_BackEnd.R_IServicebase(Of PYT00800Back.PYT00800DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New PYT00800Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT00800Back.PYT00800DTO) As PYT00800Back.PYT00800DTO Implements R_BackEnd.R_IServicebase(Of PYT00800Back.PYT00800DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800Cls
        Dim loRtn As PYT00800DTO = Nothing

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT00800Back.PYT00800DTO, poCRUDMode As R_Common.eCRUDMode) As PYT00800Back.PYT00800DTO Implements R_BackEnd.R_IServicebase(Of PYT00800Back.PYT00800DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800Cls
        Dim loRtn As PYT00800DTO = Nothing

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PYT00800Back.PYT00800DTO) As PYT00800Back.PYT00800DTO Implements IPYT00800Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800Cls
        Dim loRtn As PYT00800DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PYT00800Back.PYT00800DTO) As PYT00800Back.PYT00800DTO Implements IPYT00800Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800Cls
        Dim loRtn As PYT00800DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function CheckSPT(poParam As String) As Boolean Implements IPYT00800Service.CheckSPT
        Dim loEx As New R_Exception
        Dim loCls As New PYT00800Cls
        Dim loRtn As Boolean
        Try
            loRtn = loCls.CheckSPT(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
