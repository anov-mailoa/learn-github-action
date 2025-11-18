Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09100Service" in code, svc and config file together.
Public Class PNT09100Service
    Implements IPNT09100Service

    Public Sub Svc_R_Delete(poEntity As PNT09000Back.PNT09100DTO) Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09100DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT09100Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09100DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNT09100Cls
        Dim loRtn As New PNT09100DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09000Back.PNT09100DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09000Back.PNT09100DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09100DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT09100Cls
        Dim loRtn As New PNT09100DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    'Public Function GetPunishmentMemo(poParam As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements IPNT09100Service.GetPunishmentMemo
    '    Dim loEx As New R_Exception
    '    Dim loCls As New PNT09100Cls
    '    Dim loRtn As New PNT09100DTO

    '    Try
    '        loRtn = loCls.GetPunishmentMemo(poParam)

    '    Catch ex As Exception
    '        loEx.Add(ex)

    '    End Try

    '    loEx.ConvertAndThrowToServiceExceptionIfErrors()

    '    Return loRtn
    'End Function

    Public Function chekStatus(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String) As Object Implements IPNT09100Service.chekStatus
        Dim loException As New R_Exception
        Dim loCls As New PNT09100Cls

        Try
            loCls.chekStatus(pcCompId, pcTransCode, pcDeptCode, pcRefNo)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function DraftUndraft(poParam As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements IPNT09100Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loRtn As PNT09100DTO = Nothing

        Try
            loRtn = New PNT09100Cls().DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements IPNT09100Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT09100Cls
        Dim loRtn As New PNT09100DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function getPunishmentLevel(pcCompId As String) As PNT09000Back.PNT09100DTO Implements IPNT09100Service.getPunishmentLevel
        Dim loEx As New R_Exception
        Dim loCls As New PNT09100Cls
        Dim loRtn As New PNT09100DTO

        Try
            loRtn = loCls.getPunishmentLevel(pcCompId)

        Catch ex As Exception
            loEx.Add(ex)

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT09000Back.PNT09100DTO) As PNT09000Back.PNT09100DTO Implements IPNT09100Service.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT09100Cls
        Dim loRtn As New PNT09100DTO

        Try
            loCls.reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
