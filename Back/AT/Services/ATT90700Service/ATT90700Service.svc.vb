Imports R_Common
Imports ATT90700Back

' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT90700Service" in code, svc and config file together.
Public Class ATT90700Service
    Implements IATT90700Service

    Public Function DraftSubmit(poCurrent As ATT90700Back.ATT90700DTO) As ATT90700Back.ATT90700DTO Implements IATT90700Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT90700Cls
        Dim loRtn As New ATT90700DTO

        Try
            loRtn = loCls.DraftSubmit(poCurrent)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Sub Svc_R_Delete(poEntity As ATT90700Back.ATT90700DTO) Implements R_BackEnd.R_IServicebase(Of ATT90700Back.ATT90700DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT90700Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT90700Back.ATT90700DTO) As ATT90700Back.ATT90700DTO Implements R_BackEnd.R_IServicebase(Of ATT90700Back.ATT90700DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT90700Cls
        Dim loRtn As New ATT90700DTO
        Try
            loRtn = loCls.R_GetRecord(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT90700Back.ATT90700DTO, poCRUDMode As R_Common.eCRUDMode) As ATT90700Back.ATT90700DTO Implements R_BackEnd.R_IServicebase(Of ATT90700Back.ATT90700DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT90700Cls
        Dim loRtn As ATT90700DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function
End Class
