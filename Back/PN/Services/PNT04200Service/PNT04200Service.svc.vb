Imports R_Common
Imports PNT04200Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT04200Service" in code, svc and config file together.
Public Class PNT04200Service
    Implements IPNT04200Service

    Public Sub Svc_R_Delete(poEntity As PNT04200Back.PNT04200DTO) Implements R_BackEnd.R_IServicebase(Of PNT04200Back.PNT04200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT04200Cls
        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT04200Back.PNT04200DTO) As PNT04200Back.PNT04200DTO Implements R_BackEnd.R_IServicebase(Of PNT04200Back.PNT04200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New PNT04200Cls
        Dim loRtn As New PNT04200DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT04200Back.PNT04200DTO, poCRUDMode As R_Common.eCRUDMode) As PNT04200Back.PNT04200DTO Implements R_BackEnd.R_IServicebase(Of PNT04200Back.PNT04200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT04200Cls
        Dim loRtn As New PNT04200DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As PNT04200Back.PNT04200DTO) As PNT04200Back.PNT04200DTO Implements IPNT04200Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT04200Cls
        Dim loRtn As New PNT04200DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT04200Back.PNT04200DTO) As PNT04200Back.PNT04200DTO Implements IPNT04200Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT04200Cls
        Dim loRtn As New PNT04200DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT04200Back.PNT04200DTO) As PNT04200Back.PNT04200DTO Implements IPNT04200Service.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT04200Cls
        Dim loRtn As New PNT04200DTO

        Try
            loRtn = loCls.Reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT04200Service.chekStatusDelete
        Dim loException As New R_Exception
        Dim loCls As New PNT04200Cls

        Try
            loCls.chekStatusDelete(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT04200Service.chekStatusEdit
        Dim loException As New R_Exception
        Dim loCls As New PNT04200Cls

        Try
            loCls.chekStatusEdit(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

End Class
