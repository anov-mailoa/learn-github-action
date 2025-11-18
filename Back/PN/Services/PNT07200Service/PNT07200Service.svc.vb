Imports R_Common
Imports PNT07200Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07200Service" in code, svc and config file together.
Public Class PNT07200Service
    Implements IPNT07200Service

    Public Sub DoWork() Implements IPNT07200Service.DoWork
    End Sub

    Public Sub Svc_R_Delete(poEntity As PNT07200Back.PNT07200DTO) Implements R_BackEnd.R_IServicebase(Of PNT07200Back.PNT07200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT07200CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT07200Back.PNT07200DTO) As PNT07200Back.PNT07200DTO Implements R_BackEnd.R_IServicebase(Of PNT07200Back.PNT07200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT07200CLS
        Dim loRtn As New PNT07200DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT07200Back.PNT07200DTO, poCRUDMode As R_Common.eCRUDMode) As PNT07200Back.PNT07200DTO Implements R_BackEnd.R_IServicebase(Of PNT07200Back.PNT07200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT07200CLS
        Dim loRtn As New PNT07200DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PNT07200Back.PNT07200DTO) As PNT07200Back.PNT07200DTO Implements IPNT07200Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT07200CLS
        Dim loRtn As New PNT07200DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT07200Back.PNT07200DTO) As PNT07200Back.PNT07200DTO Implements IPNT07200Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT07200CLS
        Dim loRtn As New PNT07200DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkStatus(poParam As PNT07200Back.PNT07200DTO) As Object Implements IPNT07200Service.checkStatus
        Dim loEx As New R_Exception
        Dim loCls As New PNT07200CLS
        Dim loRtn As New PNT07200DTO
        Try
            loRtn = loCls.checkStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Function


End Class
