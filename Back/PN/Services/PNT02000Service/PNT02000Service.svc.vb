Imports R_Common
Imports R_BackEnd
Imports PNT02000Back
' NOTE: You can use the "Rename" command on the context menu to change the class name "PNT02000Service" in code, svc and config file together.
Public Class PNT02000Service
    Implements IPNT02000Service

    Public Sub Svc_R_Delete(poEntity As PNT02000Back.PNT02000DTO) Implements R_BackEnd.R_IServicebase(Of PNT02000Back.PNT02000DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New PNT02000Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As PNT02000Back.PNT02000DTO) As PNT02000Back.PNT02000DTO Implements R_BackEnd.R_IServicebase(Of PNT02000Back.PNT02000DTO).Svc_R_GetRecord
        Dim loException As New R_Exception
        Dim loCls As New PNT02000Cls
        Dim loRtn As New PNT02000DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As PNT02000Back.PNT02000DTO, poCRUDMode As R_Common.eCRUDMode) As PNT02000Back.PNT02000DTO Implements R_BackEnd.R_IServicebase(Of PNT02000Back.PNT02000DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New PNT02000Cls
        Dim loRtn As New PNT02000DTO
        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As PNT02000Back.PNT02000DTO) As PNT02000Back.PNT02000DTO Implements IPNT02000Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New PNT02000Cls
        Dim loRtn As New PNT02000DTO

        Try
            loRtn = loCls.DraftUndraft(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As PNT02000Back.PNT02000DTO) As PNT02000Back.PNT02000DTO Implements IPNT02000Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New PNT02000Cls
        Dim loRtn As New PNT02000DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Reject(poCurrent As PNT02000Back.PNT02000DTO) As PNT02000Back.PNT02000DTO Implements IPNT02000Service.Reject
        Dim loEx As New R_Exception
        Dim loCls As New PNT02000Cls
        Dim loRtn As New PNT02000DTO

        Try
            loRtn = loCls.Reject(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Sub chekStatusEdit(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT02000Service.chekStatusEdit
        Dim loException As New R_Exception
        Dim loCls As New PNT02000Cls

        Try
            loCls.chekStatusEdit(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Sub chekStatusDelete(pcCompId As String, pcTransCode As String, pcDeptCode As String, pcRefNo As String, pcTransacStatus As String) Implements IPNT02000Service.chekStatusDelete
        Dim loException As New R_Exception
        Dim loCls As New PNT02000Cls

        Try
            loCls.chekStatusDelete(pcCompId, pcTransCode, pcDeptCode, pcRefNo, pcTransacStatus)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function checkAllowedResources(poParam As PNT02000Back.PNT02000DTO) As Boolean Implements IPNT02000Service.checkAllowedResources
        Dim loException As New R_Exception
        Dim loCls As New PNT02000Cls
        Dim loRtn As Boolean

        Try
            loRtn = loCls.checkAllowedResources(poParam)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
