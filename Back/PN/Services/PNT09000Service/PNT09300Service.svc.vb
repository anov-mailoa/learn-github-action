Imports System.ServiceModel
Imports R_BackEnd
Imports R_Common
Imports PNT09000Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT09300Service" in code, svc and config file together.
Public Class PNT09300Service
    Implements IPNT09300Service

    Public Function DraftUndraft(poParam As PNT09000Back.PNT09300DTO) As PNT09000Back.PNT09300DTO Implements IPNT09300Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New PNT09300Cls
        Dim loRtn As PNT09300DTO = Nothing

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT09000Back.PNT09300DTO) As PNT09000Back.PNT09300DTO Implements IPNT09300Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT09300Cls
        Dim loRtn As New PNT09300DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As PNT09000Back.PNT09300DTO) Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT09300Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT09000Back.PNT09300DTO) As PNT09000Back.PNT09300DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09300DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNT09300Cls
        Dim loRtn As New PNT09300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT09000Back.PNT09300DTO, poCRUDMode As R_Common.eCRUDMode) As PNT09000Back.PNT09300DTO Implements R_BackEnd.R_IServicebase(Of PNT09000Back.PNT09300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT09300Cls
        Dim loRtn As New PNT09300DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT09000Back.PNT09300DTO) As PNT09000Back.PNT09300DTO Implements IPNT09300Service.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT09300Cls
        Dim loRtn As New PNT09300DTO

        Try
            loRtn = loCls.Reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT09300Service.chekStatusDelete
        Dim loException As New R_Exception
        Dim loCls As New PNT09300Cls

        Try
            loCls.chekStatusDelete(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT09300Service.chekStatusEdit
        Dim loException As New R_Exception
        Dim loCls As New PNT09300Cls

        Try
            loCls.chekStatusEdit(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
