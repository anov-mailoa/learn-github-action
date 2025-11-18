Imports R_Common
Imports PNT08100Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT08100Service" in code, svc and config file together.
Public Class PNT08100Service
    Implements IPNT08100Service

    Public Sub Svc_R_Delete(poEntity As PNT08100Back.PNT08100DTO) Implements R_BackEnd.R_IServicebase(Of PNT08100Back.PNT08100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT08100Back.PNT08100DTO) As PNT08100Back.PNT08100DTO Implements R_BackEnd.R_IServicebase(Of PNT08100Back.PNT08100DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT08100Back.PNT08100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT08100Back.PNT08100DTO Implements R_BackEnd.R_IServicebase(Of PNT08100Back.PNT08100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function checkStatus(poParam As PNT08100Back.PNT08100DTO) As Object Implements IPNT08100Service.checkStatus
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loRtn = loCls.checkStatus(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Function DraftProcess(poParam As PNT08100Back.PNT08100DTO) As PNT08100Back.PNT08100DTO Implements IPNT08100Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT08100Back.PNT08100DTO) As PNT08100Back.PNT08100DTO Implements IPNT08100Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getEmployeeBondDetail(poParam As PNT08100Back.PNT08100DTO) As PNT08100Back.PNT08100DTO Implements IPNT08100Service.getEmployeeBondDetail
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loRtn = loCls.getEmployeeBondDetail(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Dummy(poParam1 As System.Collections.Generic.List(Of PNT08100Back.PNT08100GridDTO), poParam2 As System.Collections.Generic.List(Of PNT08100Back.PNT08100ReportDTO)) Implements IPNT08100Service.Dummy

    End Sub

    Public Sub reject(poParam As PNT08100Back.PNT08100DTO) Implements IPNT08100Service.reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As New PNT08100DTO
        Try
            loCls.reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function removeDocument(poParameter As PNT08100Back.PNT08100DTO) As PNT08100Back.PNT08100DTO Implements IPNT08100Service.removeDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As PNT08100DTO

        Try
            loRtn = loCls.removeDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function saveDocument(poParameter As PNT08100Back.PNT08100DTO) As PNT08100Back.PNT08100DTO Implements IPNT08100Service.saveDocument
        Dim loEx As New R_Exception
        Dim loCls As New PNT08100CLS
        Dim loRtn As PNT08100DTO

        Try
            loRtn = loCls.saveDocument(poParameter)

        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

End Class

