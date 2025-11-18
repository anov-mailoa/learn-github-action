Imports R_BackEnd
Imports R_Common
Imports ATT00300Back
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports SIAPP_PUB_DTO
Imports ATT00300Common
' NOTE: You can use the "Rename" command on the context menu to change the class name "ATT00300Service" in code, svc and config file together.
Public Class ATT00300Service
    Implements IATT00300Service
     
    Public Sub Svc_R_Delete(poEntity As ATT00300Back.ATT00300DTO) Implements R_BackEnd.R_IServicebase(Of ATT00300Back.ATT00300DTO).Svc_R_Delete
        Dim loEx As New R_Exception
        Dim loCls As New ATT00300Cls

        Try
            loCls.R_Delete(poEntity)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_R_GetRecord(poEntity As ATT00300Back.ATT00300DTO) As ATT00300Back.ATT00300DTO Implements R_BackEnd.R_IServicebase(Of ATT00300Back.ATT00300DTO).Svc_R_GetRecord
        Dim loEx As New R_Exception
        Dim loCls As New ATT00300Cls
        Dim loRtn As ATT00300DTO

        Try
            loRtn = loCls.R_GetRecord(poEntity)

        Catch ex As Exception

        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function Svc_R_Save(poEntity As ATT00300Back.ATT00300DTO, poCRUDMode As R_Common.eCRUDMode) As ATT00300Back.ATT00300DTO Implements R_BackEnd.R_IServicebase(Of ATT00300Back.ATT00300DTO).Svc_R_Save
        Dim loEx As New R_Exception
        Dim loCls As New ATT00300Cls
        Dim loRtn As ATT00300DTO

        Try
            loRtn = loCls.R_Save(poEntity, poCRUDMode)

        Catch ex As Exception
            loEx.Add(ex)

        End Try
        loEx.ConvertAndThrowToServiceExceptionIfErrors()
        Return loRtn
    End Function

    Public Function DraftSubmit(poEntity As ATT00300Back.ATT00300DTO) As ATT00300Back.ATT00300DTO Implements IATT00300Service.DraftSubmit
        Dim loEx As New R_Exception
        Dim loCls As New ATT00300Cls
        Dim loRtn As New ATT00300DTO

        Try
            loRtn = loCls.DraftSubmit(poEntity)

        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getSchedule(poEntity As ATT00300Back.ATT00300DTO) As ATT00300Back.ATT00300DTO Implements IATT00300Service.getSchedule
        Dim loRtn As New ATT00300DTO
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getSchedule(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function getScheduleWorkGroup(poEntity As ATT00300Back.ATT00300DTO) As ATT00300Back.ATT00300DTO Implements IATT00300Service.getScheduleWorkGroup
        Dim loRtn As New ATT00300DTO
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.getScheduleWorkGroup(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function

    Public Function permission_Validate(poEntity As ATT00300Back.ATT00300DTO) As ATT00300Back.ATT00300DTO Implements IATT00300Service.permission_Validate
        Dim loRtn As New ATT00300DTO
        Dim loCls As New ATT00300Cls
        Dim loEx As New R_Exception

        Try
            loRtn = loCls.permission_Validate(poEntity)
        Catch ex As Exception
            loEx.Add(ex)
        End Try

        loEx.ConvertAndThrowToServiceExceptionIfErrors()

        Return loRtn
    End Function
End Class
