Imports R_Common
Imports ATT90400Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90400Service" in code, svc and config file together.
Public Class ATT90400Service
    Implements IATT90400Service


    Public Sub Svc_R_Delete(poEntity As ATT90400Back.ATT90400DTO) Implements R_BackEnd.R_IServicebase(Of ATT90400Back.ATT90400DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT90400Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90400Back.ATT90400DTO) As ATT90400Back.ATT90400DTO Implements R_BackEnd.R_IServicebase(Of ATT90400Back.ATT90400DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT90400Cls
        Dim loRtn As New ATT90400DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT90400Back.ATT90400DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90400Back.ATT90400DTO Implements R_BackEnd.R_IServicebase(Of ATT90400Back.ATT90400DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT90400Cls
        Dim loRtn As ATT90400DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftSubmit(poCurrent As ATT90400Back.ATT90400DTO) As ATT90400Back.ATT90400DTO Implements IATT90400Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT90400Cls
        Dim loRtn As New ATT90400DTO

        Try
            loRtn = loCls.DraftSubmit(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getExpired(poCurrent As ATT90400Back.ATT90400DTO) As ATT90400Back.ATT90400DTO Implements IATT90400Service.getExpired
        Dim loEx As New R_Exception
        Dim loCls As New ATT90400Cls
        Dim loRtn As New ATT90400DTO

        Try
            loRtn = loCls.getExpired(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
