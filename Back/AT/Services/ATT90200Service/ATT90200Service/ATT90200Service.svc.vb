Imports R_BackEnd
Imports R_Common
Imports ATT90200Back
Imports System.ServiceModel.Channels

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90200Service" in code, svc and config file together.
Public Class ATT90200Service
    Implements IATT90200Service

    Public Sub Svc_R_Delete(poEntity As ATT90200Back.ATT90200DTO) Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90200DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT90200Cls

        Try
            loCls.R_Delete(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90200Back.ATT90200DTO) As ATT90200Back.ATT90200DTO Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90200DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim loRtn As ATT90200DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT90200Back.ATT90200DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90200Back.ATT90200DTO Implements R_BackEnd.R_IServicebase(Of ATT90200Back.ATT90200DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim loRtn As ATT90200DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftUndraft(poParam As ATT90200Back.ATT90200DTO) As ATT90200Back.ATT90200DTO Implements IATT90200Service.DraftUndraft
        Dim loEx As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim loRtn As ATT90200DTO

        Try
            loRtn = loCls.DraftUndraft(poParam)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftProcess(poParam As ATT90200Back.ATT90200DTO) As ATT90200Back.ATT90200DTO Implements IATT90200Service.DraftProcess
        Dim loEx As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim loRtn As New ATT90200DTO
        Try
            loRtn = loCls.DraftProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function SubmitProcess(poParam As ATT90200Back.ATT90200DTO) As ATT90200Back.ATT90200DTO Implements IATT90200Service.SubmitProcess
        Dim loEx As New R_Exception
        Dim loCls As New ATT90200Cls
        Dim loRtn As New ATT90200DTO
        Try
            loRtn = loCls.SubmitProcess(poParam)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

End Class
