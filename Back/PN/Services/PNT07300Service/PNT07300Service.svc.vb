Imports R_Common
Imports PNT07300Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07300Service" in code, svc and config file together.
Public Class PNT07300Service
    Implements IPNT07300Service

    Public Sub Svc_R_Delete(poEntity As PNT07300Back.PNT07300DTO) Implements R_BackEnd.R_IServicebase(Of PNT07300Back.PNT07300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT07300Back.PNT07300DTO) As PNT07300Back.PNT07300DTO Implements R_BackEnd.R_IServicebase(Of PNT07300Back.PNT07300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim loRtn As New PNT07300DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT07300Back.PNT07300DTO, poCRUDMode As R_Common.eCRUDMode) As PNT07300Back.PNT07300DTO Implements R_BackEnd.R_IServicebase(Of PNT07300Back.PNT07300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim loRtn As New PNT07300DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkStatus(poParam As PNT07300Back.PNT07300DTO) As Object Implements IPNT07300Service.checkStatus
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim loRtn As New PNT07300DTO
        Try
            loRtn = loCls.checkStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PNT07300Back.PNT07300DTO) As PNT07300Back.PNT07300DTO Implements IPNT07300Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim loRtn As New PNT07300DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT07300Back.PNT07300DTO) As PNT07300Back.PNT07300DTO Implements IPNT07300Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim loRtn As New PNT07300DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkAllowedResources(poParam As PNT07300Back.PNT07300DTO) As Boolean Implements IPNT07300Service.checkAllowedResources
        Dim loException As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkAllowedResources(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function checkActiveLoanTrx(poParam As PNT07300Back.PNT07300DTO) As String Implements IPNT07300Service.checkActiveLoanTrx
        Dim loEx As New R_Exception
        Dim loCls As New PNT07300CLS
        Dim lcRtn As String = ""
        Try
            lcRtn = loCls.checkActiveLoanTrx(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return lcRtn
    End Function
End Class
