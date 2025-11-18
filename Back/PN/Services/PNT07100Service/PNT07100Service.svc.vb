Imports R_Common
Imports PNT07100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT07100Service" in code, svc and config file together.
Public Class PNT07100Service
    Implements IPNT07100Service

    Public Sub Svc_R_Delete(poEntity As PNT07100Back.PNT07100DTO) Implements R_BackEnd.R_IServicebase(Of PNT07100Back.PNT07100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT07100Back.PNT07100DTO) As PNT07100Back.PNT07100DTO Implements R_BackEnd.R_IServicebase(Of PNT07100Back.PNT07100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loRtn As New PNT07100DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT07100Back.PNT07100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT07100Back.PNT07100DTO Implements R_BackEnd.R_IServicebase(Of PNT07100Back.PNT07100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loRtn As New PNT07100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PNT07100Back.PNT07100DTO) As PNT07100Back.PNT07100DTO Implements IPNT07100Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loRtn As New PNT07100DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT07100Back.PNT07100DTO) As PNT07100Back.PNT07100DTO Implements IPNT07100Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loRtn As New PNT07100DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn

    End Function

    Public Function checkStatus(poParam As PNT07100Back.PNT07100DTO) As Object Implements IPNT07100Service.checkStatus
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim loRtn As New PNT07100DTO
        Try
            loRtn = loCls.checkStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Function OutstandingTransactionCheck(poParam As PNT07100Back.PNT07100DTO) As Integer Implements IPNT07100Service.OutstandingTransactionCheck
        Dim loEx As New R_Exception
        Dim loCls As New PNT07100CLS
        Dim liRtn As New Integer
        Try
            liRtn = loCls.OutstandingTransactionCheck(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return liRtn
    End Function
End Class
