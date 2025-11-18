Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09200Service" in code, svc and config file together.
Public Class PNT09200Service
    Implements IPNT09200Service



    Public Sub Svc_R_Delete(poEntity As PNT09200Back.PNT09200DTO) Implements R_BackEnd.R_IServicebase(Of PNT09200Back.PNT09200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT09200Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09200Back.PNT09200DTO) As PNT09200Back.PNT09200DTO Implements R_BackEnd.R_IServicebase(Of PNT09200Back.PNT09200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT09200Cls
        Dim loRtn As PNT09200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09200Back.PNT09200DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09200Back.PNT09200DTO Implements R_BackEnd.R_IServicebase(Of PNT09200Back.PNT09200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT09200Cls
        Dim loRtn As PNT09200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT09200Back.PNT09200DTO) As PNT09200Back.PNT09200DTO Implements IPNT09200Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As PNT09200DTO = Nothing

        Try
            loRtn = New PNT09200Cls().DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Submit(poParam As PNT09200Back.PNT09200DTO) As PNT09200Back.PNT09200DTO Implements IPNT09200Service.Submit
        Dim loEx As New R_Exception
        Dim loRtn As PNT09200DTO = Nothing

        Try
            loRtn = New PNT09200Cls().Submit(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getRejectReward(poCurrent As PNT09200Back.PNT09200DTO) As Boolean Implements IPNT09200Service.getRejectReward
        Dim loEx As New R_Exception
        Dim loCls As New PNT09200Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.getRejectReward(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poParam As PNT09200Back.PNT09200DTO) As PNT09200Back.PNT09200DTO Implements IPNT09200Service.Reject
        Dim loEx As New R_Exception
        Dim loRtn As PNT09200DTO = Nothing

        Try
            loRtn = New PNT09200Cls().Reject(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    'Public Function getReportData(poParam As PNT09200Back.PNT09200DTO) As PNT09200Back.PNT09200ReportDTO Implements IPNT09200Service.getReportData
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNT09200Cls
    '    Dim loRtn As PNT09200ReportDTO

    '    Try
    '        loRtn = loCls.getReportData(poParam)

    '    Catch ex As Exception
    '        loEx.Add(ex)

    '    End Try
    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()
    '    Return loRtn
    'End Function
End Class
