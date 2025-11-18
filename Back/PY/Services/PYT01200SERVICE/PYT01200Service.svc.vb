Imports R_Common
Imports PYT01200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PYT01200Service" in code, svc and config file together.
Public Class PYT01200Service
    Implements IPYT01200Service

    Public Sub Svc_R_Delete(poEntity As PYT01200Back.PYT01200DTO) Implements R_BackEnd.R_IServicebase(Of PYT01200Back.PYT01200DTO).Svc_R_Delete
        Dim loException As New R_Exception
        Dim loCls As New PYT01200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PYT01200Back.PYT01200DTO) As PYT01200Back.PYT01200DTO Implements R_BackEnd.R_IServicebase(Of PYT01200Back.PYT01200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New PYT01200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PYT01200Back.PYT01200DTO, poCRUDMode As R_Common.eCRUDMode) As PYT01200Back.PYT01200DTO Implements R_BackEnd.R_IServicebase(Of PYT01200Back.PYT01200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New PYT01200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function DraftSubmitProcess(poParam As PYT01200Back.PYT01200DTO) As PYT01200Back.PYT01200DTO Implements IPYT01200Service.DraftSubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New PYT01200DTO
        Try
            loRtn = loCls.DraftSubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getSummary(poParam As PYT01200Back.PYT01200DTO) As PYT01200Back.PYT01200DTO Implements IPYT01200Service.getSummary
        Dim loEx As New R_Exception
        Dim loCls As New PYT01200Cls
        Dim loRtn As New PYT01200DTO
        Try
            loRtn = loCls.getSummary(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
